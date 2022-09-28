Imports SGT
Imports SGT.Caja
Imports SGT.CXC
Imports SGT.Caja.Entidades
Imports SGT.CXC.Entidades
Imports SGT.CXC.Posteos
Imports SGT.PuntodeVenta.Entidades
Imports SGT.Inventario.Entidades.Documento

Public Class Cobro
    Public Class ParametrosCobrar
        Public DocSerial As Integer
        Public SucCode As Integer
        Public Caja As Integer
        Public Cajera As Integer
        Public Cuadre As Integer
        Public AfectaCXC As Boolean = True
        Public GenerarNCF As Boolean = False
        Public TipoNCF As TipoNCFEnum = TipoNCFEnum.None
        Public ClienteFiscal As Integer
        Public FormasPago As New SGT.Caja.Entidades.Transaccion.CollectionFormaPago
        Public UseTransaccion As Boolean
    End Class

    Public Class ParametrosAplicarNC
        Public DocSerial As Integer
        Public Documentos As New SGT.CXC.Entidades.CollectionFacturas
    End Class
    Public Class ParametrosAnular
        Public Serial As Integer
        Public AfectaCXC As Boolean
        Public UserTransaction As Boolean
    End Class
    Dim whDefault As Integer
    Dim scDefault As Integer
    Dim WhDefaultNo As Integer

    Public Function Anular(ByVal e As ParametrosAnular) As Boolean
        Dim XSelect As LibX.Data.XSelecStmt
        Dim ocjtranrm As DataTable
        Dim oRowHeader As DataRow

        Dim oParamCXC As CXC.Posteos.PostDocument.ParametrosAnular
        Dim oCXC As CXC.Posteos.PostDocument

        Dim oDoc As SGT.Inventario.Entidades.Documento
        Try
            oParamCXC = New CXC.Posteos.PostDocument.ParametrosAnular
            oCXC = New CXC.Posteos.PostDocument

            XSelect = New LibX.Data.XSelecStmt("cjtranrm")
            XSelect.Parameters.Add("ftserial_no", e.Serial)

            ocjtranrm = XSelect.GetTable(True)

            If ocjtranrm Is Nothing Then
                Throw New ApplicationException("No se encontró pagos para este documento!")
            End If

            XSelect = New LibX.Data.XSelecStmt("ftfactm")

            '// buscar el documento a Cobrar
            XSelect!ftserial_no = e.Serial
            oRowHeader = XSelect.GetDataRow

            If oRowHeader Is Nothing Then
                Throw New ApplicationException("No se encontró pagos para este documento!")
            End If

            oDoc = New SGT.Inventario.Entidades.Documento(oRowHeader!type_code)

            For Each oRow As DataRow In ocjtranrm.Rows
                oRow.BeginEdit()
                oRow!tran_status = Val(EstatusDocumentosEnum.Anulada)
                oRow.EndEdit()
            Next

            If e.UserTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            '// Aplicar a cuenta x cobrar
            If oDoc.AfectaCXC = True And e.AfectaCXC = True Then
                With oParamCXC
                    .TipoDocumento = oRowHeader!type_code.ToString
                    .Serial = e.Serial
                    .Cliente = Val(oRowHeader!cust_code.ToString)
                    .PagoPorAdelantado = Val(oRowHeader!pay_adelant.ToString)
                    .UseTransaction = False
                End With
                oCXC.Anular(oParamCXC)
            End If

            LibX.Data.Manager.Save(ocjtranrm)

            If e.UserTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False
        End Try
    End Function

    Public Function Aplicar(ByVal e As ParametrosCobrar) As Boolean
        Dim SelectStmt As String
        Dim Efectivo As Decimal, Tarjeta As Decimal, CXC As Decimal, NC As Decimal, Cheque As Decimal, Seguro As Decimal, Estafeta As Decimal
        Dim CodigoCliente As Integer
        Dim CodigoClienteTar As Integer
        Dim CodigoClienteSeg As Integer

        Dim XSelect As LibX.Data.XSelecStmt
        Dim XInsert1 As LibX.Data.XInsertStmt
        Dim XInsert As LibX.Data.XInsertStmt
        Dim xUpdate As LibX.Data.XUpdateStmt

        Dim oTable As DataTable
        Dim oRowHeader As DataRow
        Dim oParamCXC As CXC.Posteos.PostDocument.ParametrosAplicar
        Dim oCXC As CXC.Posteos.PostDocument
        Dim oDoc As Inventario.Entidades.Documento

        Try
            oParamCXC = New CXC.Posteos.PostDocument.ParametrosAplicar
            oCXC = New CXC.Posteos.PostDocument

            XSelect = New LibX.Data.XSelecStmt("ftfactm")

            '// buscar el documento a Cobrar
            XSelect!ftserial_no = e.DocSerial
            oTable = XSelect.GetTable

            If e.UseTransaccion = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            whDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxWhDefault")
            scDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxScDefault")
            WhDefaultNo = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibxWhDefaultNo").ToString)

            oRowHeader = oTable.Rows(0)
            oDoc = New Inventario.Entidades.Documento(oTable.Rows(0)!type_code)

            If oDoc Is Nothing Then
                Throw New ApplicationException("No se encontró este tipo de documento!")
            End If

            For Each oPago As SGT.Caja.Entidades.Transaccion.FormaPago In e.FormasPago
                XInsert = New LibX.Data.XInsertStmt("cjtranrm")
                XInsert.Fields("ftserial_no") = e.DocSerial
                XInsert.Fields("suc_code") = e.SucCode
                XInsert.Fields("init_serial") = e.Cuadre
                XInsert.Fields("amount") = oPago.Monto
                XInsert.Fields("tran_status") = Val(EstatusDocumentosEnum.Cobrada)

                Select Case oPago.Tipo
                    Case SGT.Caja.Entidades.Transaccion.TipoFormaPagoEnum.Efectivo
                        XInsert.Fields("pay_method") = "EFE"
                        XInsert.Fields("vuelto") = oPago.Aditional
                        Efectivo = oPago.Monto
                        oTable.Rows(0)!fact_cond = 1 '// Contado
                        If oTable.Rows(0)!type_code = "EST" Then
                            Estafeta = Efectivo
                        End If

                    Case SGT.Caja.Entidades.Transaccion.TipoFormaPagoEnum.Cheque
                        XInsert.Fields("pay_method") = "CHK"
                        Cheque = oPago.Monto
                        oTable.Rows(0)!fact_cond = 1 '// Contado

                        If oTable.Rows(0)!type_code = "EST" Then
                            Estafeta = Cheque
                        End If

                        XInsert1 = New LibX.Data.XInsertStmt("cjchkm", "chk_code")
                        XInsert1.Fields("chk_number") = oPago.Referencia
                        XInsert1.Fields("chk_date") = oPago.Fecha
                        XInsert1.Fields("chk_amount") = oPago.Monto
                        XInsert1.Fields("ban_code") = oPago.Banco
                        XInsert1.Fields("chk_benef") = oPago.Aditional
                        XInsert1.Fields("chk_estatus") = Val(EstatusDocumentosEnum.Cobrada) '// Cobrardo

                        XInsert.Fields("chk_code") = XInsert1.Execute

                    Case SGT.Caja.Entidades.Transaccion.TipoFormaPagoEnum.CXC
                        XInsert.Fields("pay_method") = "CXC"
                        oTable.Rows(0)!fact_cond = 2 '// Credito
                        CXC = oPago.Monto
                        CodigoCliente = oPago.Referencia
                        XInsert.Fields("cust_code") = oPago.Referencia

                        If oTable.Rows(0)!type_code = "EST" Then
                            Estafeta = CXC
                        End If

                    Case SGT.Caja.Entidades.Transaccion.TipoFormaPagoEnum.NC
                        Dim Balance As Decimal
                        oTable.Rows(0)!fact_cond = 4 '// Nota de credito
                        XInsert.Fields("pay_method") = "NC"
                        NC = oPago.Monto

                        If oDoc.AfectaOtrosDocumentos = False Then
                            XInsert.Fields("ncr_code") = oPago.Referencia

                            Balance = Me.GetBalanceNC(oPago.Referencia)
                            Balance -= oPago.Monto

                            xUpdate = New LibX.Data.XUpdateStmt("cjncrm")
                            xUpdate.FieldsSet("ncr_balance") = Balance '// Nota de Credito
                            If Balance <= 0 Then
                                xUpdate.FieldsSet("ncr_estatus") = 0
                            End If
                            xUpdate.Fields("ncr_code") = oPago.Referencia
                            xUpdate.Execute()
                        End If

                        'TODO: Revisar porq cuando la factura tiene itbis y descuento
                        'TODO: y se pago con varias forma de pago manda todo el ITBIS a CXC
                        '// Si No se especifico factura asumir q es una
                        '// devolucion de contado, por lo tanto crear una
                        '// NC
                        If oDoc.AfectaOtrosDocumentos = True Then
                            If CrearNCEfectivo(oRowHeader, NC) = False Then
                                CXC += Efectivo
                            End If
                        End If

                    Case Transaccion.TipoFormaPagoEnum.Seguro
                        XInsert.Fields("pay_method") = "SEG"
                        XInsert.Fields("cust_seg") = oPago.Referencia
                        Seguro = oPago.Monto
                        ''oTable.Rows(0)!fact_cond = 1 '// Contado
                        CodigoClienteSeg = oPago.Referencia

                        If Seguro > 0 And oTable.Rows(0)!type_code = "DEV" Then
                            oDoc = New Inventario.Entidades.Documento(oTable.Rows(0)!type_code)
                        End If

                        If CodigoClienteSeg <= 0 Then
                            Throw New ApplicationException("No se encontro la ARS para este plan de seguro!")
                        End If

                    Case Transaccion.TipoFormaPagoEnum.Tarjeta
                            XInsert.Fields("pay_method") = "TAR"
                            XInsert.Fields("tart_code") = oPago.Aditional
                            Tarjeta = oPago.Monto
                        oTable.Rows(0)!fact_cond = 3 '// Contado
                            CodigoClienteTar = Val(LibX.Data.Manager.GetScalar("select cust_code from pvtipotarm where tart_code = " & oPago.Aditional).ToString.Trim)

                            If oTable.Rows(0)!type_code = "EST" Then
                                Estafeta = Tarjeta
                            End If

                            If CodigoClienteTar <= 0 Then
                                Throw New ApplicationException("No se encontro el banco para este tipo de tarjeta!")
                            End If

                End Select

                XInsert.Execute()
            Next

            '// Actualizar Documento con:
            '- Estatus Cobrada
            '- Numero del Cuadre en que se cobro
            '- Numero del Documento
            '- ?

            oTable.Rows(0)!fact_status = Val(EstatusDocumentosEnum.Cobrada)
            oTable.Rows(0)!init_serial = e.Cuadre

            If LibX.IsNull(oTable.Rows(0)!fact_number) Then
                If WhDefaultNo = 1 Then
                    oTable.Rows(0)!fact_number = oDoc.GenerateNumber(oTable.Rows(0)!type_code, WhDefaultNo)
                Else
                    oTable.Rows(0)!fact_number = oDoc.GenerateNumber(oTable.Rows(0)!type_code, oTable.Rows(0)!whse_code)
                End If

                '// Actualizar el documento aplicado
                xUpdate = New LibX.Data.XUpdateStmt("ivtranrm")
                xUpdate.FieldsSet("doc_number") = oTable.Rows(0)!fact_number
                xUpdate.Fields("doc_serial") = oTable.Rows(0)!ftserial_no
                xUpdate.Fields("type_code") = oTable.Rows(0)!type_code
                xUpdate.Execute()
            End If

            If LibX.IsNull(oTable.Rows(0)!fact_ncf) AndAlso e.GenerarNCF = True Then
                oTable.Rows(0)!fact_ncf = oDoc.GenerateNCF(oTable.Rows(0)!type_code, oTable.Rows(0)!whse_code, e.TipoNCF)
                oTable.Rows(0)!cust_serial = e.ClienteFiscal
            End If

            If CodigoCliente > 0 Then
                oTable.Rows(0)!cust_code = CodigoCliente '// Credito
            End If

            '// Guardar el encabezado
            LibX.Data.Manager.Save(oTable)

            '// Actualizar Fecha de Delivery
            If LibX.IsNull(oTable.Rows(0)!fact_inddomicilio) = False AndAlso oTable.Rows(0)!fact_inddomicilio = 1 Then
                xUpdate = New LibX.Data.XUpdateStmt("cccustm")
                xUpdate.FieldsSet("last_delivery") = LibX.Data.Manager.Connection.GetDate
                xUpdate.Fields("cust_code") = oTable.Rows(0)!cust_code
                xUpdate.Execute()
            End If

            '// Aplicar CXC
            If oDoc.AfectaCXC = True And e.AfectaCXC = True Then
                'Si el documento es a credito aplicar a cuenta x cobrar
                'ParametrosCXC = Cliente, Monto, Fecha, Numero, Tipo, Itbis

                '// Aplicar Monto por CXC
                If CXC > 0 Or oRowHeader!type_code.ToString = "RCB" Then
                    With oParamCXC
                        .Serial = oRowHeader!ftserial_no
                        .mSerial = oRowHeader!ftserial_no
                        .Numero = oRowHeader!fact_number
                        .SucCode = oRowHeader!suc_code
                        .Fecha = oRowHeader!fact_date
                        .Termino = oRowHeader!term_code.ToString
                        .TipoDocumento = oRowHeader!type_code
                        .Cliente = oTable.Rows(0)!cust_code
                        .NCF = oRowHeader!fact_ncf.ToString.Trim

                        If oRowHeader!type_code.ToString = "RCB" Then
                            .Monto = Val(oRowHeader!fact_total.ToString)
                            .Impuesto = Val(oRowHeader!itbis.ToString)
                            .Descuento = Val(oRowHeader!descto.ToString)
                        Else
                            .Monto = CXC
                            .Impuesto = 0
                            .Descuento = 0
                        End If

                        If LibX.IsNull(oRowHeader!ftserial_afect) = False Then
                            .SerialAfect = oRowHeader!ftserial_afect
                        End If

                        .UseTransaction = False
                    End With

                    oCXC.Aplicar(oParamCXC)
                End If

                '// Aplicar Monto A Banco por Tarjeta
                If Tarjeta > 0 Then ''AndAlso oRowHeader!type_code.ToString <> "RCB" Then
                    If oRowHeader!type_code.ToString = "RCB" Then
                        oRowHeader!type_code = "FPV"
                    End If
                    With oParamCXC
                        .Serial = oRowHeader!ftserial_no
                        .mSerial = oRowHeader!ftserial_no
                        .Numero = oRowHeader!fact_number
                        .SucCode = oRowHeader!suc_code
                        .Fecha = oRowHeader!fact_date
                        .Descuento = 0
                        .Termino = oRowHeader!term_code.ToString
                        .TipoDocumento = oRowHeader!type_code
                        .Cliente = CodigoClienteTar
                        .Monto = Tarjeta

                        .UseTransaction = False
                    End With

                    oCXC.Aplicar(oParamCXC)
                End If

                '// Aplicar Monto A ARS por Seguro
                If Seguro > 0 AndAlso oRowHeader!type_code.ToString <> "RCB" Then
                    With oParamCXC
                        .Serial = oRowHeader!ftserial_no
                        .mSerial = oRowHeader!ftserial_no
                        .Numero = oRowHeader!fact_number
                        .SucCode = oRowHeader!suc_code
                        .Fecha = oRowHeader!fact_date
                        .Descuento = 0
                        .Termino = oRowHeader!term_code.ToString
                        .TipoDocumento = oRowHeader!type_code
                        .Cliente = CodigoClienteSeg

                        .Monto = Seguro

                        If LibX.IsNull(oRowHeader!ftserial_afect) = False Then
                            .SerialAfect = oRowHeader!ftserial_afect
                        End If

                        .UseTransaction = False
                    End With

                    oCXC.Aplicar(oParamCXC)
                End If
                '// Aplicar Monto A ARS por Seguro
                If Estafeta > 0 AndAlso oRowHeader!type_code.ToString <> "RCB" Then
                    With oParamCXC
                        .Serial = oRowHeader!ftserial_no
                        .mSerial = oRowHeader!ftserial_no
                        .Numero = oRowHeader!fact_number
                        .SucCode = oRowHeader!suc_code
                        .Fecha = oRowHeader!fact_date
                        .Descuento = 0
                        .Termino = oRowHeader!term_code.ToString
                        .TipoDocumento = oRowHeader!type_code
                        .Cliente = oTable.Rows(0)!cust_code

                        .Monto = Estafeta

                        .UseTransaction = False
                    End With

                    oCXC.Aplicar(oParamCXC)
                End If


            End If

            If e.UseTransaccion = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            Return True

        Catch ex As Exception
            If e.UseTransaccion = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If

            LibX.Log.Add(ex)
            Return False
        End Try
    End Function

    '''Private Function CrearNC(ByVal pRow As DataRow, ByVal Monto As Decimal) As Boolean
    '''    Dim oRow As DataRow
    '''    Dim SelectStmt As String
    '''    Dim oFacturas As New CXC.Entidades.Factura
    '''    Dim XInsert As LibX.Data.XInsertStmt
    '''    Dim Balance As Decimal = 0
    '''    Dim Contado As Boolean = False
    '''    Dim oDoc As SGT.Inventario.Entidades.Documento

    '''    '// Si se especifico documento buscar el documento
    '''    '// si no se especifico documento crear una nota de credito al usuario
    '''    If LibX.IsNull(pRow!ftserial_afect) = False Then
    '''        SelectStmt = "select * from ftfactm " & _
    '''                     " where ftserial_no = " & pRow!ftserial_afect.ToString.Trim

    '''        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

    '''        If oRow Is Nothing Then
    '''            Return False
    '''        End If

    '''        '// Buscar el Balance si es a credito
    '''        If Val(oRow!fact_cond.ToString.Trim) = 2 Then '// Credito
    '''            oFacturas.TipoDocumento = oRow!type_code.ToString
    '''            oFacturas.Numero = CType(oRow!fact_number, Integer)

    '''            Balance = oFacturas.GetBalance()
    '''        Else
    '''            Contado = True
    '''        End If
    '''    Else
    '''        Contado = True
    '''    End If

    '''        Return True

    '''End Function

    Private Function CrearNCEfectivo(ByVal pRow As DataRow, ByVal Monto As Decimal) As Boolean
        Dim oRow As DataRow
        Dim SelectStmt As String
        Dim oFacturas As New CXC.Entidades.Factura
        Dim XInsert As LibX.Data.XInsertStmt
        Dim Balance As Decimal = 0
        Dim Contado As Boolean = False
        Dim oDoc As SGT.Inventario.Entidades.Documento

        oDoc = New SGT.Inventario.Entidades.Documento("NCR")
        '// Si es de contado o es a credito y fue saldada
        '// crear una NC

        XInsert = New LibX.Data.XInsertStmt("cjncrm", "ncr_code")
        If WhDefaultNo = 1 Then
            XInsert.Fields("ncr_number") = oDoc.GenerateNumber("NCR", WhDefaultNo)
        Else
            XInsert.Fields("ncr_number") = oDoc.GenerateNumber("NCR", whDefault)
        End If
        XInsert.Fields("type_code") = "NCR"
        XInsert.Fields("ncr_date") = LibX.Data.Manager.Connection.GetDate
        XInsert.Fields("ncr_amount") = Monto
        XInsert.Fields("ncr_balance") = Monto
        XInsert.Fields("suc_code") = scDefault
        XInsert.Fields("ncr_estatus") = EstatusDocumentosEnum.Pendiente
        XInsert.Fields("ftserial_no") = pRow!ftserial_no
        XInsert.Fields("bus_name") = pRow!bus_name.ToString.Trim

        XInsert.Execute()

        Return True

    End Function
    Private Function GetBalanceNC(ByVal nc_code As Integer) As Decimal
        Dim SelectStmt As String
        Dim Balance As Decimal
        Try
            SelectStmt = "select ncr_balance from cjncrm " & _
                        " where ncr_code = " & nc_code.ToString

            Balance = Val(LibX.Data.Manager.GetScalar(SelectStmt).ToString.Trim)

            Return Balance

        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
