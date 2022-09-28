Public Class Documentos

    Public Class ParametrosEmitir
        Public Serial As Integer
        Public Chequera As Integer
        Public TipoDocumento As String
        Public Numero As Integer
        Public Fecha As Date
        Public Monto As Decimal
        Public Sucursal As Integer
    End Class

    Public Function GetNextNumber(ByVal ptrn_type As String) As Integer
        Dim SelectStmt As String
        Dim intNumber As Object
        Dim oRow As DataRow
        Dim XUpdate As LibX.Data.XUpdateStmt

        SelectStmt = String.Concat("select last_number from ivtypem", _
                                   " where type_code = '", ptrn_type.Trim, "'")


        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If LibX.IsNull(oRow!last_number) Then
            intNumber = 0
        Else
            intNumber = CType(oRow!last_number, Integer)
        End If

        intNumber += 1

        XUpdate = New LibX.Data.XUpdateStmt("ivtypem")
        XUpdate.FieldsSet("last_number") = intNumber
        XUpdate.Fields("type_code") = ptrn_type
        XUpdate.Execute()

        Return intNumber

    End Function

    Private Sub VerificarCargosEmitos(ByVal pSerial As Integer)
        Dim Selectstmt As String
        Dim XDelete As LibX.Data.XDeleteStmt

        XDelete = New LibX.Data.XDeleteStmt("cbdocsd")
        XDelete.Fields("cbm_serial") = pSerial
        XDelete.Execute()

        XDelete = New LibX.Data.XDeleteStmt("cbdocsm")
        XDelete.Fields("cbm_serial") = pSerial
        XDelete.Execute()

    End Sub

    Public Function EmitirDocumento(ByVal e As ParametrosEmitir) As Integer
        Dim XInsert As LibX.Data.XInsertStmt
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim oTipoDocRow As DataRow
        Dim oChequeraRow As DataRow
        Dim oConf As SGT.Contabilidad.Common.Configuracion

        Dim Monto As Decimal
        Dim SelectStmt As String
        Dim mSerial As Integer = -1

        '// Verificar si el cargo ya fue creado y eliminarlo
        VerificarCargosEmitos(e.Serial)

        SelectStmt = "select * from cgtrntpm " & _
                     " where tran_type = '" & e.TipoDocumento.Trim & "'"

        oTipoDocRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oTipoDocRow Is Nothing Then
            Throw New ApplicationException("No existe este tipo de documento")
        End If

        If oTipoDocRow!cargo_emision Is DBNull.Value Then
            Exit Function
        End If

        SelectStmt = "select * from cpchequera " & _
                     " where chequera = '" & e.Chequera & "'"

        oChequeraRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oChequeraRow Is Nothing Then
            Throw New ApplicationException("No existe esta Chequera")
        End If

        '// Calcular Monto Emision
        Monto = e.Monto * (oTipoDocRow!cargo_emision / 100)

        oConf = New SGT.Contabilidad.Common.Configuracion

        If oConf.CuentaCargos.Trim = "" Then
            Throw New ApplicationException("No se ha codificado la cuenta cargos financieros")
        End If

        '// Insertar Documento Cargo
        XInsert = New LibX.Data.XInsertStmt("cbdocsm", "cbm_serial")

        XInsert.Fields("tran_type") = oTipoDocRow!tran_cargo
        XInsert.Fields("doc_date") = e.Fecha
        XInsert.Fields("chequera") = e.Chequera
        XInsert.Fields("suc_code") = e.Sucursal
        XInsert.Fields("doc_number") = GetNextNumber(oTipoDocRow!tran_cargo.ToString)
        XInsert.Fields("doc_status") = 2 '// Pendiente
        XInsert.Fields("doc_concept") = "CARGO POR EMISION " & oTipoDocRow!tran_descr.ToString.Trim & " # " & e.Numero.ToString
        XInsert.Fields("amount") = Monto
        XInsert.Fields("date_created") = LibX.Data.Manager.Connection.GetDate
        XInsert.Fields("userid") = LibX.User.UserID
        XInsert.Fields("doc_origen") = e.Serial

        mSerial = XInsert.Execute

        '// Debito a cargos
        XInsert = New LibX.Data.XInsertStmt("cbdocsd")
        XInsert.Fields("cbm_serial") = mSerial
        XInsert.Fields("line_no") = 1
        XInsert.Fields("debit_credit") = 1 'Debito
        XInsert.Fields("acct_no") = oConf.CuentaCargos
        XInsert.Fields("amount") = Monto
        XInsert.Fields("suc_code") = e.Sucursal

        XInsert.Execute()

        '// Credito a cuenta Banco
        XInsert = New LibX.Data.XInsertStmt("cbdocsd")
        XInsert.Fields("cbm_serial") = mSerial
        XInsert.Fields("line_no") = 2
        XInsert.Fields("debit_credit") = -1 'Credit
        XInsert.Fields("acct_no") = oChequeraRow!cuenta_conta.ToString
        XInsert.Fields("amount") = Monto
        XInsert.Fields("suc_code") = e.Sucursal

        XInsert.Execute()

        Return mSerial
    End Function
End Class
