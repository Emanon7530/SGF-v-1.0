Public Class PostDocument
    Public Class ParametrosAplicarFacturas
        Public Serial As Integer
        Public Numero As String
        Public Sucursal As Integer
        Public TipoDocumento As String
        Public Termino As String
        Public Comprobante As String
        Public Proveedor As Integer
        Public DocDate As Date
        Public Monto As Decimal
        Public Itbis As Decimal
        Public Descuento As Decimal
        Public DueDate As Date
        Public DiscDate As Date
        Public Excento As Decimal
        Public Grabado As Decimal
        Public SerialEntrada As Integer
        Public SerialDevolucion As Integer
        Public Estatus As Integer
        Public UseTransaction As Boolean = False
        Public TasaUS As Decimal
    End Class
    Public Class ParametrosTransferir
        Public Serial As Integer
        Public ProveedorOrigen As Integer
        Public ProveedorDestino As Integer
        Public MontoBalance As Decimal
        Public MontoItbis As Decimal
        Public UseTransaction As Boolean = False
    End Class
    Public Class ParametrosCrearNC
        Public Serial As Integer
        Public Numero As String
        Public Sucursal As Integer
        Public TipoDocumento As String
        Public Termino As String
        Public Proveedor As Integer
        Public DocDate As Date
        Public Monto As Decimal
        Public Itbis As Decimal
        Public Descuento As Decimal
        Public DueDate As Date
        Public DiscDate As Date
        Public Excento As Decimal
        Public Grabado As Decimal
        Public DevolucionSerial As Integer
        Public UseTransaction As Boolean = False
        Public TasaUS As Decimal
    End Class

    Public Class ParametrosAplicar
        Public Serial As Integer
        Public TipoDocumento As String
        Public UseTransaction As Boolean = False
        Public Sucursal As Integer
        Public dFecha As DateTime
        Public TasaUS As Decimal
    End Class

    Public Class ParametrosAplicarPagos
        Public TipoDocumento As String
        Public Serial As Integer
        Public Numero As String
        Public Sucursal As Integer
        Public Descripcion As String
        Public Proveedor As Integer
        Public DocDate As Date
        Public Chequera As Integer
        Public Monto As Decimal
        Public DevolucionSerial As Integer
        Public Almacen As Integer
        Public CuentaBancaria As String
        Public DocumentosAfectados As New Afectados
        Public UseTransaction As Boolean = False
    End Class

    Public Class ParametrosPagar
        Public Serial As Integer
        Public TipoDocumento As String
        Public Proveedor As Integer
        Public Chequera As Integer
        Public Sucursal As Integer
        Public Descuento As Decimal
        Public MontoAplicado As Decimal
        Public Fecha As DateTime
    End Class

    Public Function CrearNC(ByVal e As ParametrosCrearNC) As Boolean
        Dim oTable As DataTable
        Dim oDocumento As SGT.Inventario.Entidades.Documento
        Dim oTermino As SGT.CXC.Entidades.Termino

        Dim XSelect As LibX.Data.XSelecStmt
        Dim XInsert As LibX.Data.XInsertStmt

        Dim SelectStmt As String
        Dim Origen As Integer
        Dim XSerial As Integer
        Dim DescuentoPP As Decimal '// Descuento x Pronto Pago

        Try
            '// Determinar el origen del documento
            oDocumento = New SGT.Inventario.Entidades.Documento(e.TipoDocumento)
            Origen = oDocumento.Origen

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            '// insetar en la tabla de cuenta x pagar
            XInsert = New LibX.Data.XInsertStmt("cpinvcem", "invce_serial")
            XInsert!term_code = e.Termino
            XInsert!prov_code = e.Proveedor
            XInsert!type_code = e.TipoDocumento
            XInsert!doc_no = e.Numero
            XInsert!suc_code = e.Sucursal
            XInsert!invce_desc = oDocumento.Name
            XInsert!doc_date = e.DocDate
            XInsert!amount = e.Monto
            XInsert!disc_pct = (e.Descuento / e.Monto) * 100
            XInsert!disc_amount = e.Descuento
            XInsert!isc_amount = 0
            XInsert!itbis = e.Itbis
            XInsert!excento = e.Excento
            XInsert!impto = e.Grabado
            XInsert!dev_serial = e.DevolucionSerial
            XInsert!invce_status = 2 '// Pendiente Aplicar
            XInsert!date_created = DateSerial(Year(Now), Month(Now), Day(Now))
            XInsert!userid = LibX.User.UserID
            XInsert!tasaUS = e.TasaUS

            XSerial = XInsert.Execute

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            Return True

        Catch ex As Exception
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If

            LibX.Log.Add(ex)
            Return False

        End Try
    End Function

    Public Function Aplicar(ByVal e As ParametrosAplicar) As Boolean
        Dim oRow As DataRow
        Dim SelectStmt As String

        Try
            Select Case e.TipoDocumento
                Case "CHQ", "DEP", "NDB", "SOL", "DPT", "RET", "PEF"
                    PrepararRecibo(e)

                Case "CUS", "CRD", "NDP", "DVI", "NCR", "CCH"
                    PrepararFacturas(e)

            End Select

            Return True
        Catch ex As Exception
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If

            LibX.Log.Add(ex)
            Return False
        End Try
    End Function

    Private Sub PrepararRecibo(ByVal e As ParametrosAplicar)
        Dim SelectStmt As String
        Dim detalle, concepto, tipo As String
        Dim oRow As DataRow
        Dim oTable As DataTable
        Dim oParametrosPagos As ParametrosAplicarPagos
        Dim oParametroCrear As SGT.ControlBancario.Operaciones.PostDocument.ParametrosCrearDocumento
        Dim oPostControlBan As SGT.ControlBancario.Operaciones.PostDocument
        Dim oMovimiento As SGT.Contabilidad.Entidades.Movimientos
        Dim oChequera As SGT.ControlBancario.Entidades.Chequera
        Dim oParamAplchequera As SGT.ControlBancario.Entidades.Chequera.ParametrosAplicar
        Dim oSuplidor As SGT.CXP.Entidades.Suplidor
        Dim oDocumento As SGT.Inventario.Entidades.Documento
        Dim oParametroCodif As SGT.Contabilidad.Entidades.Movimientos.ParametrosCodificacion
        Dim oPeriodoContable As SGT.Contabilidad.Entidades.Periodo.PeriodoStatusEnum
        Dim xUpdateStmt As LibX.Data.XUpdateStmt
        Try
            oParametrosPagos = New ParametrosAplicarPagos
            oParametroCrear = New SGT.ControlBancario.Operaciones.PostDocument.ParametrosCrearDocumento
            oPostControlBan = New SGT.ControlBancario.Operaciones.PostDocument
            oMovimiento = New SGT.Contabilidad.Entidades.Movimientos
            oParametroCodif = New SGT.Contabilidad.Entidades.Movimientos.ParametrosCodificacion
            oParamAplchequera = New SGT.ControlBancario.Entidades.Chequera.ParametrosAplicar

            SelectStmt = "select cppaymm.*,cpprovm.prov_name,cppaymd.invce_serial from cppaymm, cpprovm, cppaymd " & _
                       " where cppaymm.paym_serial = " & e.Serial.ToString & _
                       "  and cpprovm.prov_code = cppaymm.prov_code " & _
                       " and cppaymm.paym_serial = cppaymd.paym_serial "

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            With oParametrosPagos
                .Serial = e.Serial
                .TipoDocumento = e.TipoDocumento
                .Almacen = oRow!whse_code
                .Chequera = oRow!chequera
                .Sucursal = oRow!suc_code

                If Not LibX.IsNull(oRow!cuentabancaria) Then .CuentaBancaria = oRow!cuentabancaria
                If Not LibX.IsNull(oRow!detail) Then .Descripcion = oRow!detail
                If Not LibX.IsNull(oRow!dev_serial) Then .DevolucionSerial = oRow!dev_serial

                .DocDate = oRow!paym_date
                .Monto = oRow!amount
                If Not LibX.IsNull(oRow!paym_number) Then .Numero = oRow!paym_number
                .Proveedor = oRow!prov_code
                .UseTransaction = Not e.UseTransaction
            End With

            '// Chequera
            oChequera = New SGT.ControlBancario.Entidades.Chequera(oRow!chequera)
            oSuplidor = New SGT.CXP.Entidades.Suplidor(oRow!prov_code)

            SelectStmt = "select * from cppaymd " & _
                         " where paym_serial = " & e.Serial.ToString.Trim
                         '''"   and suc_code = " & e.sucursal.tostring.trim


            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)


            If oTable Is Nothing Then
                Throw New ApplicationException("No se encontro el detalle de este documento!")
            End If

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No se encontro el detalle de este documento!")
            End If

            For Each oRowDetail As DataRow In oTable.Rows
                oParametrosPagos.DocumentosAfectados.Add(oRowDetail!invce_serial, Val(oRowDetail!itbis.ToString.Trim), Val(oRowDetail!disc_amount.ToString.Trim), Val(oRowDetail!amount.ToString.Trim))
                concepto = concepto & Find_Factura(oRowDetail!invce_serial) & ","
                detalle = "SALDO DE DOCUMENTOS No. " & concepto
            Next

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            AplicarPagos(oParametrosPagos)

            '// Codificar documento
            With oParametroCodif
                .TipoDocumento = oRow!type_code.ToString.Trim
                Select Case .TipoDocumento
                    Case "CHQ", "DEP", "NDB", "SOL", "DPT", "RET", "PEF"
                        .Descuento = oParametrosPagos.DocumentosAfectados.GetTotalDescto
                        If .Descuento > oParametrosPagos.DocumentosAfectados.GetTotalDesctoDevo Then
                            .DescuentoDevo = .Descuento - oParametrosPagos.DocumentosAfectados.GetTotalDesctoDevo
                        Else
                            .DescuentoDevo = oParametrosPagos.DocumentosAfectados.GetTotalDesctoDevo - .Descuento
                        End If
                        .Impuesto = oParametrosPagos.DocumentosAfectados.GetTotalItbisDevo
                        .Devolucion = oParametrosPagos.DocumentosAfectados.GetTotalDevo - .Impuesto + oParametrosPagos.DocumentosAfectados.GetTotalDesctoDevo
                        .NotaDebito = oParametrosPagos.DocumentosAfectados.GetTotalNotaDebito
                        .MontoBruto = Val(oRow!amount.ToString.Trim) + .Devolucion + .DescuentoDevo + .Impuesto
                        .MontoNeto = Val(oRow!amount.ToString.Trim)
                        .Proveedor = oRow!prov_code
                        .Chequera = oRow!chequera
                        .Modtype = "CXP"
                    Case "CUS", "CRD", "NDP", "DVI", "NCR", "CCH"
                        .Descuento = oParametrosPagos.DocumentosAfectados.GetTotalDescto
                        .Impuesto = oParametrosPagos.DocumentosAfectados.GetTotalItbis
                        .DescuentoDevo = oParametrosPagos.DocumentosAfectados.GetTotalDesctoDevo
                        .Devolucion = oParametrosPagos.DocumentosAfectados.GetTotalDevo
                        .NotaDebito = oParametrosPagos.DocumentosAfectados.GetTotalNotaDebito
                        .MontoBruto = Val(oRow!amount.ToString.Trim) - .Descuento
                        .MontoNeto = .MontoBruto + .Descuento
                        .Proveedor = oRow!prov_code
                        .Chequera = oRow!chequera
                        .Modtype = "CXP"
                End Select

            End With

            If oRow!type_code.ToString.Trim <> "PEF" Then
                If oMovimiento.GetCodificacion(oParametroCodif) = False Then
                    Throw New ApplicationException("No se encontro codificación contable para este documento!")
                End If
            End If
            'If oMovimiento.GetCodificacion(oParametroCodif) = False Then
            '    Throw New ApplicationException("No se encontro codificación contable para este documento!")
            'End If

            '// Enviar a Control Bancario
            With oParametroCrear
                .Beneficiario = oRow!prov_name.ToString.Trim
                .Chequera = oRow!chequera
                .Sucursal = oRow!suc_code
                .Concepto = detalle
                .Fecha = oRow!paym_date
                .Monto = Val(oRow!amount.ToString.Trim)
                .doc_Serial = oRow!paym_serial
                .suplidor = oRow!prov_code
                If Not LibX.IsNull(oRow!paym_number) Then .Numero = oRow!paym_number
                .TipoDocumento = oRow!type_code.ToString.Trim
                .CuenasContable = oParametroCodif.RetornoCuentas
            End With

            If oRow!type_code.ToString.Trim <> "PEF" Then
                oPostControlBan.CrearDocumento(oParametroCrear)
            End If

            oParamAplchequera.Chequera = oRow!chequera
            oParamAplchequera.Monto = Val(oRow!amount.ToString.Trim)
            oParamAplchequera.TipoDocumento = oRow!type_code.ToString.Trim

            oChequera.Aplicar(oParamAplchequera)

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If

        End Try
    End Sub
    '//Funcion para buscar el numero de los documentos saldados y 
    '//Cosnstruir el consecto de la transacion realizada
    Public Function Find_Factura(ByVal inVserial As Integer) As String
        Dim rEtorno As String
        Dim oRow As DataRow
        Dim SelectStmt As String
        SelectStmt = "select type_code,doc_no from cpinvcem where invce_serial =" & inVserial & ""
        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)
        rEtorno = oRow!type_code & "-" & oRow!doc_no
        Return rEtorno
    End Function

    Private Sub PrepararFacturas(ByVal e As ParametrosAplicar)
        Dim SelectStmt As String
        Dim oRow As DataRow
        Dim oTable As DataTable
        Dim oParametrosFacturas As ParametrosAplicarFacturas

        Try
            oParametrosFacturas = New ParametrosAplicarFacturas

            SelectStmt = "select * from cpinvcem " & _
                       " where invce_serial = " & e.Serial.ToString

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            With oParametrosFacturas
                .Serial = e.Serial
                .TipoDocumento = e.TipoDocumento
                .DocDate = oRow!doc_date
                .Monto = oRow!amount
                .Numero = oRow!doc_no
                .Sucursal = oRow!suc_code
                .Proveedor = oRow!prov_code
                .Termino = oRow!term_code
                .UseTransaction = Not e.UseTransaction
                .TasaUS = e.TasaUS

                If Not LibX.IsNull(oRow!itbis) Then .Itbis = oRow!itbis
                If Not LibX.IsNull(oRow!disc_amount) Then .Descuento = oRow!disc_amount
                If Not LibX.IsNull(oRow!disc_date) Then .DiscDate = oRow!disc_date
                If Not LibX.IsNull(oRow!due_date) Then .DueDate = oRow!due_date
                If Not LibX.IsNull(oRow!excento) Then .Excento = oRow!excento
                If Not LibX.IsNull(oRow!impto) Then .Grabado = oRow!impto
            End With

            AplicarFacturas(oParametrosFacturas)

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Public Function Pagar(ByVal p_Args As ParametrosPagar) As Boolean
        Dim oTable As DataTable
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim occfttypm As SGT.Inventario.Entidades.Documento
        'Dim occfttypmc As SGT.ControlBancario.Entidades.TipoDocumento

        Dim SelectStmt As String
        Dim Balance As Decimal = 0
        Dim Origen As Integer
        Dim Doc_type As String

        '// Determinar el origen del documento

        occfttypm = New SGT.Inventario.Entidades.Documento(p_Args.TipoDocumento)
        Origen = occfttypm.Origen

        '// Buscar el balance documento
        SelectStmt = String.Concat("select balance from cpopend ", _
                                   " where invce_serial = ", p_Args.Serial.ToString)

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        If oTable Is Nothing Then
            Throw New ApplicationException("No existe documento con este serial")
        End If

        If oTable.Rows.Count <= 0 Then
            Throw New ApplicationException("No existe documento con este serial")
        End If
        Balance = Val(oTable.Rows(0)!balance.ToString.Trim)
        Balance = Balance + (p_Args.MontoAplicado * Origen) + (p_Args.Descuento * Origen) '// Monto Aplicado + Descuento por PP

        '// Rebajar el Monto A pagar
        XUpdate = New LibX.Data.XUpdateStmt("cpopend")
        XUpdate.FieldsSet("disc_bal") = p_Args.Descuento
        XUpdate.FieldsSet("balance") = Balance
        XUpdate.FieldsSet("last_pay_date") = p_Args.Fecha


        XUpdate.Fields("invce_serial") = p_Args.Serial
        XUpdate.Fields("suc_code") = p_Args.Sucursal

        XUpdate.Execute()
        XUpdate.Dispose()

        '// Si se saldo el documento cambiar su estatus
        If Balance = 0 Then
            XUpdate = New LibX.Data.XUpdateStmt("cpinvcem")
            XUpdate.FieldsSet("invce_status") = 3 '// Saldado
            XUpdate.FieldsSet("invce_datetran") = LibX.Data.Manager.GetScalar("select getdate()")
            XUpdate.Fields("invce_serial") = p_Args.Serial
            XUpdate.Fields("suc_code") = p_Args.Sucursal

            XUpdate.Execute()
            XUpdate.Dispose()
        End If

        '// Actualizar el Balance del Suplidor
        SelectStmt = String.Concat("select balance from cpprovm ", _
                                   " where prov_code = ", p_Args.Proveedor.ToString)

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        If oTable Is Nothing Then
            Throw New ApplicationException("No se encontro suplidor")
        End If

        If oTable.Rows.Count <= 0 Then
            Throw New ApplicationException("No se encontro suplidor")
        End If

        SelectStmt = String.Concat("select type_code from cpinvcem ", _
                                 " where invce_serial = ", p_Args.Serial.ToString)

        Doc_type = LibX.Data.Manager.GetScalar(SelectStmt)

        If (Doc_type = "CRD" Or Doc_type = "NDP" Or Doc_type = "CUS" Or Doc_type = "CCH") Then
            Balance = Val(oTable.Rows(0)!balance.ToString.Trim)
            Balance = Balance + (p_Args.MontoAplicado * Origen) + (p_Args.Descuento * Origen) '// Monto Aplicado - Descuento por PP

            XUpdate = New LibX.Data.XUpdateStmt("cpprovm")
            XUpdate.FieldsSet("balance") = Balance
            XUpdate.FieldsSet("last_pay_date") = p_Args.Fecha
            If Doc_type = "CRD" Then
                XUpdate.FieldsSet("last_purch_date") = p_Args.Fecha
            End If


            XUpdate.Fields("prov_code") = p_Args.Proveedor

            XUpdate.Execute()
            XUpdate.Dispose()
        End If

        Return True

    End Function

    Public Function AplicarFacturas(ByVal e As ParametrosAplicarFacturas) As Boolean
        Dim oTable As DataTable
        Dim oDocumento As SGT.Inventario.Entidades.Documento
        Dim oTermino As SGT.CXC.Entidades.Termino

        Dim XSelect As LibX.Data.XSelecStmt
        Dim XInsert As LibX.Data.XInsertStmt

        Dim SelectStmt As String
        Dim Origen As Integer
        Dim XSerial As Integer
        Dim DescuentoPP As Decimal '// Descuento x Pronto Pago

        Try
            '// Determinar el origen del documento
            oDocumento = New SGT.Inventario.Entidades.Documento(e.TipoDocumento)
            Origen = oDocumento.Origen

            '// Insertar el documento en la tabla de cuenta por pagar
            SelectStmt = "select * from cpinvcem where invce_serial = " & e.Serial.ToString
            XSelect = New LibX.Data.XSelecStmt("cpinvcem", SelectStmt)
            oTable = XSelect.GetTable(True)

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            oTermino = New SGT.CXC.Entidades.Termino(e.Termino)

            If oTable.Rows.Count <= 0 Then
                '// insetar en la tabla de cuenta x pagar
                e.DueDate = oTermino.CalcularVencimiento(e.DocDate)
                e.DiscDate = oTermino.CalcularFechaDescuento(e.DocDate)

                XInsert = New LibX.Data.XInsertStmt("cpinvcem", "invce_serial")
                XInsert!term_code = e.Termino
                XInsert!prov_code = e.Proveedor
                XInsert!type_code = e.TipoDocumento
                XInsert!doc_no = e.Numero
                XInsert!suc_code = e.Sucursal
                XInsert!invce_desc = oDocumento.Name
                XInsert!doc_date = e.DocDate
                XInsert!invce_ncf = e.Comprobante

                XInsert!due_date = e.DueDate
                XInsert!disc_date = e.DiscDate

                XInsert!amount = e.Monto
                XInsert!disc_pct = Decimal.Round((e.Descuento / e.Monto) * 100, 2)
                XInsert!disc_amount = e.Descuento
                XInsert!isc_amount = 0
                XInsert!itbis = e.Itbis
                XInsert!excento = e.Excento
                XInsert!impto = e.Grabado
                XInsert!invce_status = IIf(e.Estatus <= 0, 1, e.Estatus) '// Aplicado

                XInsert!date_created = DateSerial(Year(Now), Month(Now), Day(Now))
                XInsert!userid = LibX.User.UserID
                XInsert!entr_serial = IIf(e.SerialEntrada > 0, e.SerialEntrada, DBNull.Value)
                XInsert!dev_serial = IIf(e.SerialDevolucion > 0, e.SerialDevolucion, DBNull.Value)
                XInsert!tasaUS = e.TasaUS
                
                XSerial = XInsert.Execute
            Else
                XSerial = oTable.Rows(0)!invce_serial
                oTable.Rows(0)!invce_status = 1 '// Aplicar
                LibX.Data.Manager.Save(oTable)
            End If

            '// Insertar el documento en la tabla de cuenta por pagar
            SelectStmt = "select * from cpopend where invce_serial = " & e.Serial.ToString
            XSelect = New LibX.Data.XSelecStmt("cpopend", SelectStmt)
            oTable = XSelect.GetTable(True)

            If oTable.Rows.Count <= 0 Then
                '// Termino
                If e.Termino.Trim <> "" Then
                    DescuentoPP = e.Monto * (oTermino.PorcDescuento / 100)
                End If

                '// Insertar en la tabla de aplicadas
                XInsert = New LibX.Data.XInsertStmt("cpopend")

                XInsert!invce_serial = XSerial
                XInsert!prov_code = e.Proveedor
                XInsert!open_desc = oDocumento.Name
                XInsert!doc_date = e.DocDate
                XInsert!suc_code = e.Sucursal
                XInsert!amount = (e.Monto * Origen) + _
                                 (e.Itbis * Origen) - _
                                 (e.Descuento * Origen)    '// Convertir el monto según el origen

                XInsert!disc_amount = DescuentoPP * Origen  '// Invertir el descuento
                XInsert!disc_bal = DescuentoPP * Origen     '// Invertir el descuento
                XInsert!balance = (e.Monto * Origen) + _
                                  (e.Itbis * Origen) - _
                                  (e.Descuento * Origen)    '// Convertir el monto según el origen

                If Not LibX.IsNull(e.DueDate) AndAlso e.DueDate <> #12:00:00 AM# Then XInsert!due_date = e.DueDate
                If Not LibX.IsNull(e.DiscDate) AndAlso e.DiscDate <> #12:00:00 AM# Then XInsert!disc_date = e.DiscDate

                XInsert!excento = e.Excento
                XInsert!impto = e.Grabado
                XInsert!last_pay_date = ""
                XInsert!tasaUS = e.TasaUS

                XInsert.Execute()
            Else
                Throw New ApplicationException("Este documento ya fue aplicado al balance del Suplidor!!!")
            End If

            '// buscar el proveedor y actualizar su balance
            SelectStmt = "select * from cpprovm where prov_code = " & e.Proveedor.ToString
            XSelect = New LibX.Data.XSelecStmt("cpprovm", SelectStmt)
            oTable = XSelect.GetTable(True)

            If e.TipoDocumento <> "DVI" And e.TipoDocumento <> "NCR" Then
                oTable.Rows(0)!balance = Val(oTable.Rows(0)!balance.ToString.Trim) + (e.Monto * Origen) + _
                                        (e.Itbis * Origen) - (e.Descuento * Origen)
            End If

            LibX.Data.Manager.Save(oTable)

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            Return True

        Catch ex As Exception
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If

            LibX.Log.Add(ex)
            Return False

        End Try
    End Function

    Public Function AplicarPagos(ByVal e As ParametrosAplicarPagos) As Boolean
        Dim oTable As DataTable
        Dim oDocumento As SGT.Inventario.Entidades.Documento

        Dim oTermino As DataRow
        Dim oPagar As ParametrosPagar

        Dim XSelect As LibX.Data.XSelecStmt
        Dim XInsert As LibX.Data.XInsertStmt

        Dim SelectStmt As String
        Dim Origen As Integer
        Dim XSerial As Integer
        Dim Existe As Boolean = False

        Try
            '// Determinar el origen del documento
            oDocumento = New SGT.Inventario.Entidades.Documento(e.TipoDocumento)
            'oDocumento = New SGT.CXP.Entidades.TipoTransacion(e.TipoDocumento, e.Chequera)
            Origen = oDocumento.Origen

            '// Insertar el documento en la tabla de cuenta por pagar
            SelectStmt = "select * from cppaymm where paym_serial = " & e.Serial.ToString
            XSelect = New LibX.Data.XSelecStmt("cppaymm", SelectStmt)
            oTable = XSelect.GetTable(True)

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            If oTable.Rows.Count <= 0 Then
                Existe = False
                '// insetar en la tabla de cuenta x pagar
                XInsert = New LibX.Data.XInsertStmt("cppaymm", "paym_serial")
                XInsert!prov_code = e.Proveedor
                XInsert!type_code = e.TipoDocumento
                XInsert!pay_number = e.Numero
                XInsert!suc_code = e.Sucursal
                XInsert!invce_desc = e.Descripcion
                XInsert!pay_date = e.DocDate
                XInsert!amount = e.Monto
                XInsert!chequera = e.Chequera
                XInsert!detail = e.Descripcion
                XInsert!paym_status = 1 '// Aplicado
                If e.DevolucionSerial > 0 Then XInsert!dev_serial = e.DevolucionSerial
                XInsert!cuentabancaria = e.CuentaBancaria
                XInsert!whse_code = e.Almacen
                XInsert!invce_status = 1 '// Aplicado
                XInsert!date_created = LibX.Data.Manager.GetScalar("select getdate()")
                XInsert!userid = LibX.User.UserID

                XSerial = XInsert.Execute
            Else
                Existe = True
                XSerial = oTable.Rows(0)!paym_serial
                oTable.Rows(0)!paym_status = 1 '// Aplicado
                oTable.Rows(0)!paym_datetran = LibX.Data.Manager.GetScalar("select getdate()")
                LibX.Data.Manager.Save(oTable)
            End If

            '// Insertar el documento en la tabla de cuenta por pagar
            SelectStmt = "select * from cpopend "
            XSelect = New LibX.Data.XSelecStmt("cpopend", SelectStmt)
            XSelect.Parameters.Add("invce_serial", 1) '// 1 para q cree el parametro
            XInsert = New LibX.Data.XInsertStmt("cppaymd")

            oPagar = New ParametrosPagar
            Dim LineNo As Integer = 1
            If e.TipoDocumento <> "SOL" Then
                For Each oAfectado As Afectado In e.DocumentosAfectados
                    If Existe = False Then
                        '// Buscar el documento afectdo
                        XSelect.Parameters("invce_serial").Value = oAfectado.Serial
                        oTable = XSelect.GetTable(True)

                        XInsert!paym_serial = XSerial
                        XInsert!line_no = LineNo
                        XInsert!invce_serial = oAfectado.Serial
                        XInsert!amount = oAfectado.Monto
                        XInsert!itbis = oAfectado.Itbis
                        XInsert!balance = Val(oTable.Rows(0)!balance.ToString.Trim)
                        XInsert.Execute()
                    End If

                    With oPagar
                        .Serial = oAfectado.Serial
                        .MontoAplicado = oAfectado.Monto
                        .Descuento = oAfectado.Descuento
                        .TipoDocumento = e.TipoDocumento
                        .Proveedor = e.Proveedor
                        .Chequera = e.Chequera
                        .Sucursal = e.Sucursal
                        .Fecha = e.DocDate
                    End With

                    '// Aplicar el Pago
                    Pagar(oPagar)
                Next
            End If
            '''// buscar el proveedor y actualizar su balance
            ''SelectStmt = "select * from cpprovm where prov_code = " & e.Proveedor.ToString
            ''XSelect = New LibX.Data.XSelecStmt("cpprovm", SelectStmt)
            ''oTable = XSelect.GetTable(True)

            ''oTable.Rows(0)!balance = Val(oTable.Rows(0)!balance.ToString.Trim) + (e.Monto * Origen)

            ''LibX.Data.Manager.Save(oTable)

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            Return True

        Catch ex As Exception
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If

            LibX.Log.Add(ex)
            Return False

        End Try
    End Function
    Public Function TransferirFacturas(ByVal e As ParametrosTransferir) As Boolean
        Dim oTable As DataTable
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim SelectStmt As String
        Dim oRow As DataRow
        Dim Balance, Monto As Decimal
        Dim Doc_type As String


        Dim Origen As Integer


        Try
            SelectStmt = String.Concat("select balance from cpopend ", _
                                       " where invce_serial = ", e.Serial.ToString)

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Throw New ApplicationException("No existe documento con este serial")
            End If

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No existe documento con este serial")
            End If

            '// Actualizar el suplidor del documento con el suplidor destino
            XUpdate = New LibX.Data.XUpdateStmt("cpopend")
            XUpdate.FieldsSet("prov_code") = e.ProveedorDestino
            XUpdate.Fields("invce_serial") = e.Serial
            XUpdate.Execute()
            XUpdate.Dispose()

            '// Actualizar el suplidor del documento con el suplidor destino
            XUpdate = New LibX.Data.XUpdateStmt("cpinvcem")
            XUpdate.FieldsSet("prov_code") = e.ProveedorDestino
            XUpdate.Fields("invce_serial") = e.Serial

            XUpdate.Execute()
            XUpdate.Dispose()

            '// Actualizar el Balance del Suplidor del suplidor destino y el suplidor origen
            SelectStmt = String.Concat("select balance from cpprovm ", _
                                       " where prov_code = ", e.ProveedorDestino.ToString)

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Throw New ApplicationException("No se encontro suplidor")
            End If

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No se encontro suplidor")
            End If

            SelectStmt = String.Concat("select type_code from cpinvcem ", _
                                     " where invce_serial = ", e.Serial.ToString)

            Doc_type = LibX.Data.Manager.GetScalar(SelectStmt)

            If Doc_type = "CRD" Then
                Balance = Val(oTable.Rows(0)!balance.ToString.Trim)
                Balance = Balance + e.MontoBalance + e.MontoItbis

                XUpdate = New LibX.Data.XUpdateStmt("cpprovm")
                XUpdate.FieldsSet("balance") = Balance
                XUpdate.Fields("prov_code") = e.ProveedorDestino

                XUpdate.Execute()
                XUpdate.Dispose()


                SelectStmt = String.Concat("select balance from cpprovm ", _
                                       " where prov_code = ", e.ProveedorOrigen.ToString)

                oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

                If oTable Is Nothing Then
                    Throw New ApplicationException("No se encontro suplidor")
                End If

                If oTable.Rows.Count <= 0 Then
                    Throw New ApplicationException("No se encontro suplidor")
                End If

                Balance = Val(oTable.Rows(0)!balance.ToString.Trim)
                Balance = Balance - e.MontoBalance - e.MontoItbis

                XUpdate = New LibX.Data.XUpdateStmt("cpprovm")
                XUpdate.FieldsSet("balance") = Balance
                XUpdate.Fields("prov_code") = e.ProveedorOrigen

                XUpdate.Execute()
                XUpdate.Dispose()
                'Else
                '    Throw New ApplicationException("Solo se permite transferir facturas")
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False

        End Try
    End Function

#Region "Anular Documento"
    Private Function AnularFacturas(ByVal e As ParametrosAplicarFacturas) As Boolean
        Dim oTable As DataTable
        Dim oDocumento As SGT.Inventario.Entidades.Documento
        Dim oTermino As SGT.CXC.Entidades.Termino
        Dim XSelect As LibX.Data.XSelecStmt
        Dim XInsert As LibX.Data.XInsertStmt
        Dim SelectStmt As String
        Dim Origen As Integer
        Dim XSerial As Integer
        Dim DescuentoPP As Decimal '// Descuento x Pronto Pago
        Try
            '// Determinar el origen del documento
            oDocumento = New SGT.Inventario.Entidades.Documento(e.TipoDocumento)
            Origen = oDocumento.Origen '// * -1 '// Invierto el valor del origen

            '// buscar el documento en la tabla de cuenta por pagar
            SelectStmt = "select * from cpinvcem where invce_serial = " & e.Serial.ToString
            XSelect = New LibX.Data.XSelecStmt("cpinvcem", SelectStmt)

            oTable = XSelect.GetTable(True)

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            oTermino = New SGT.CXC.Entidades.Termino(e.Termino)
            If oTable.Rows.Count <= 0 Then
                '// insetar en la tabla de cuenta x pagar
                Throw New ApplicationException("No se encontro esta factura!")
            End If

            XSerial = oTable.Rows(0)!invce_serial
            oTable.Rows(0)!invce_status = 0 '// Apendiente
            oTable.Rows(0)!doc_no = oTable.Rows(0)!invce_serial.ToString.Trim & "-" & oTable.Rows(0)!doc_no.ToString.Trim

            LibX.Data.Manager.Save(oTable)
            '// Insertar el documento en la tabla de cuenta por pagar

            SelectStmt = "delete from cpopend where invce_serial = " & e.Serial.ToString
            'XSelect = New LibX.Data.XSelecStmt("cpopend", SelectStmt)
            LibX.Data.Manager.ExecuteNonQuery(SelectStmt)

            'oTable = XSelect.GetTable(True)

            'If oTable.Rows.Count > 0 Then
            '    'oTable.Rows(0)!balance = Val(oTable.Rows(0)!balance.ToString.Trim) + ((e.Monto) + _
            '    '(e.Itbis) - (e.Descuento))
            '    oTable.Rows(0)!balance = Val(oTable.Rows(0)!balance.ToString.Trim) + ((e.Monto) + _
            '    (e.Descuento))
            '    LibX.Data.Manager.Save(oTable)
            'End If

            '// buscar el proveedor y actualizar su balance
            SelectStmt = "select * from cpprovm where prov_code = " & e.Proveedor.ToString
            XSelect = New LibX.Data.XSelecStmt("cpprovm", SelectStmt)

            oTable = XSelect.GetTable(True)

            Select Case oDocumento.Entrada
                Case True
                    oTable.Rows(0)!balance = Val(oTable.Rows(0)!balance.ToString.Trim) - ((e.Monto * Origen) + _
                    (e.Descuento * Origen))
                Case Else
                    oTable.Rows(0)!balance = Val(oTable.Rows(0)!balance.ToString.Trim) + ((e.Monto * Origen) + _
                    (e.Descuento * Origen))
            End Select

            'If e.TipoDocumento = "CRD" Then
            '    oTable.Rows(0)!balance = Val(oTable.Rows(0)!balance.ToString.Trim) - ((e.Monto * Origen) + _
            '    (e.Descuento * Origen))
            'End If

            'oTable.Rows(0)!balance = Val(oTable.Rows(0)!balance.ToString.Trim) + (e.Monto * Origen) + _
            '(e.Itbis * Origen) - (e.Descuento * Origen)

            LibX.Data.Manager.Save(oTable)

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If
            Return True
        Catch ex As Exception
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
            LibX.Log.Add(ex)
            Return False
        End Try
    End Function

    Public Function Anular(ByVal e As ParametrosAplicar) As Boolean
        Dim oTable As DataTable
        Dim opaymd As DataRow
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim SelectStmt As String
        Dim oAplicarFacturas As ParametrosAplicarFacturas
        Try
            SelectStmt = "select cpinvcem.invce_serial,cpinvcem.type_code," & _
            "cppaymd.disc_amount,cppaymd.itbis,cppaymd.amount, " & _
            " cppaymd.term_code,cpinvcem.prov_code from cppaymd, cpinvcem " & _
            " where cpinvcem.invce_serial = " & e.Serial.ToString.Trim & _
            " and cpinvcem.invce_serial = cppaymd.invce_serial "

            opaymd = LibX.Data.Manager.GetDataRow(SelectStmt)

            If Not opaymd Is Nothing Then
                Throw New ApplicationException("Este documento ya tiene pagos aplicados, no puede ser reversado!")
            End If

            SelectStmt = "select cpinvcem.invce_serial,cpinvcem.type_code," & _
            "cpinvcem.disc_amount,cpinvcem.itbis,cpinvcem.amount, " & _
            " cpinvcem.term_code,cpinvcem.prov_code from  cpinvcem " & _
            " where invce_serial = " & e.Serial.ToString.Trim

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)
            If oTable Is Nothing Then
                Throw New ApplicationException("No existe este documento")
            End If
            oAplicarFacturas = New ParametrosAplicarFacturas


            For Each oRow As DataRow In oTable.Rows
                oAplicarFacturas.TipoDocumento = oRow!type_code
                oAplicarFacturas.Termino = oRow!term_code
                oAplicarFacturas.Descuento = Val(oRow!disc_amount.ToString.Trim)
                oAplicarFacturas.Estatus = 3
                oAplicarFacturas.Itbis = Val(oRow!itbis.ToString.Trim)
                oAplicarFacturas.Monto = Val(oRow!amount.ToString.Trim)
                oAplicarFacturas.Serial = oRow!invce_serial
                oAplicarFacturas.Proveedor = oRow!prov_code
                oAplicarFacturas.UseTransaction = False
                AnularFacturas(oAplicarFacturas)
            Next
            XUpdate = New LibX.Data.XUpdateStmt("cppaymm")
            XUpdate.Fields("paym_serial") = e.Serial
            XUpdate.FieldsSet("paym_status") = 0
            XUpdate.FieldsSet("paym_datetran") = LibX.Data.Manager.GetScalar("select getdate()")
            XUpdate.Execute()
            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
#End Region

End Class
