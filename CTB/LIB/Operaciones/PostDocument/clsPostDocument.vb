Imports SGT
Imports SGT.Contabilidad
Imports SGT.CXP.Posteos
Imports SGT.ControlBancario.Entidades.TipoDocumento

Public Class PostDocument
    Public Class ParametrosCrearDocumento
        Public doc_Serial As Integer
        Public Chequera As Integer
        Public TipoDocumento As String
        Public Numero As Integer
        Public Sucursal As Integer
        Public Fecha As Date
        Public Beneficiario As String
        Public Concepto As String
        Public Monto As Decimal
        Public suplidor As Integer

        Public CuenasContable As New SGT.Contabilidad.Entidades.CollectionCuentas

    End Class

    Public Function CrearDocumento(ByVal e As ParametrosCrearDocumento) As Integer
        Dim XInsert As LibX.Data.XInsertStmt
        Dim Serial As Integer
        Dim LineNo As Integer
        Dim Estado As Integer
        Dim PeriodoContable As SGT.Contabilidad.Entidades.Periodo
        Dim AnoFiscal As SGT.Contabilidad.Entidades.AnoFiscal

        AnoFiscal = New SGT.Contabilidad.Entidades.AnoFiscal
        PeriodoContable = AnoFiscal.BuscarPeriodoActual

        If e.TipoDocumento = "SOL" Then
            Estado = 2 '// Pendiente
        Else
            Estado = 1 '//Aplicado
        End If


        XInsert = New LibX.Data.XInsertStmt("cbdocsm", "cbm_serial")

        XInsert.Fields("chequera") = e.Chequera
        XInsert.Fields("tran_type") = e.TipoDocumento
        XInsert.Fields("doc_number") = e.Numero
        XInsert.Fields("suc_code") = e.Sucursal
        XInsert.Fields("doc_date") = e.Fecha
        XInsert.Fields("doc_status") = Estado
        XInsert.Fields("Benef") = e.Beneficiario
        XInsert.Fields("doc_concept") = e.Concepto
        XInsert.Fields("amount") = e.Monto
        XInsert.Fields("doc_origen") = e.doc_Serial
        XInsert.Fields("date_created") = LibX.Data.Manager.Connection.GetDate
        XInsert.Fields("perdr_year") = e.Fecha.Year
        XInsert.Fields("perdr_num") = e.Fecha.Month
        XInsert.Fields("userid") = LibX.User.UserID

        Serial = XInsert.Execute()

        XInsert = New LibX.Data.XInsertStmt("cbdocsd")
        XInsert.Fields("cbm_serial") = Serial
        XInsert.Fields("line_no") = 0
        XInsert.Fields("acct_no") = "a"
        XInsert.Fields("debit_credit") = 0
        XInsert.Fields("amount") = 0
        XInsert.Fields("suc_code") = 0

        LineNo = 0
        For Each oCuenta As SGT.Contabilidad.Entidades.Cuenta In e.CuenasContable
            LineNo += 1
            XInsert.Fields("line_no").value = LineNo
            XInsert.Fields("acct_no").value = oCuenta.NumeroCuenta
            XInsert.Fields("debit_credit").value = oCuenta.Origen
            XInsert.Fields("amount").value = oCuenta.Monto
            XInsert.Fields("suc_code").value = e.Sucursal

            XInsert.Execute()
        Next

        Return Serial
    End Function

    Public Function Aplicar(ByVal Serial As Integer, ByVal Sucursal As Integer) As Boolean
        Dim SelectStmt As String
        Dim oChequeRow As DataRow
        Dim oChequera As Entidades.Chequera
        Dim oParamAplchequera As Entidades.Chequera.ParametrosAplicar
        Dim oCuentasTable As DataTable
        Dim mEntrada As Integer
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim oParametroED As SGT.Contabilidad.Operaciones.ParametrosGenerarED
        Dim oGenerarEd As SGT.Contabilidad.Operaciones.GenerarED

        SelectStmt = "select * from cbdocsm " & _
                     " where cbm_serial =  " & Serial.ToString & _
                     "   and suc_code = " & Sucursal.tostring

        '// buscar la cabecera del documento
        oChequeRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oChequeRow Is Nothing Then
            Throw New ApplicationException("No se encontro documento con este serial")
        End If

        '// buscar cuentas
        SelectStmt = "select * from cbdocsd " & _
                     " where cbm_serial = " & Serial.ToString & _
                     "   and suc_code = " & Sucursal.ToString

        oCuentasTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        If oCuentasTable Is Nothing Then
            Throw New ApplicationException("No se encontro codificacion con este serial")
        End If

        If oCuentasTable.Rows.Count <= 0 Then
            Throw New ApplicationException("No se encontro codificacion con este serial")
        End If

        oParametroED = New SGT.Contabilidad.Operaciones.ParametrosGenerarED
        oGenerarEd = New SGT.Contabilidad.Operaciones.GenerarED
        oChequera = New Entidades.Chequera(oChequeRow!chequera)
        oParamAplchequera = New Entidades.Chequera.ParametrosAplicar

        With oParametroED
            .Fecha = oChequeRow!doc_date
            .Modulo = "CTB"
            .Numero = oChequeRow!doc_number
            .Reversar = False
            .Tipo = oChequeRow!tran_type

            For Each oRow As DataRow In oCuentasTable.Rows
                .Cuentas.Add(oRow!acct_no, oRow!dept_code, "", "", oRow!debit_credit, oRow!amount)
            Next
        End With

        mEntrada = oGenerarEd.Aplicar(oParametroED)

        '// Actualizar Documento
        XUpdate = New LibX.Data.XUpdateStmt("cbdocsm")
        XUpdate.FieldsSet("tranr_serial") = mEntrada
        XUpdate.FieldsSet("doc_status") = 1 '// Aplicada
        XUpdate.Fields("cbm_serial") = Serial
        XUpdate.Fields("suc_code") = Sucursal
        XUpdate.Execute()

        '// Aplicar documento a la chequera
        oParamAplchequera.Chequera = oChequera.Codigo
        oParamAplchequera.Monto = Val(oChequeRow!amount.ToString.Trim)
        oParamAplchequera.TipoDocumento = oChequeRow!tran_type.ToString.Trim

        oChequera.Aplicar(oParamAplchequera)

        Return True

    End Function
End Class
