Imports SGT.Inventario.Entidades.Documento
Imports SGT.Inventario.Common
Imports LibxPrintFiscalFactura

Public Class clsCobroFiscal

    Public Shared itbis As Decimal
    Public Shared sprice As Decimal

    Public Sub New(ByVal fTserial As Integer)
        FillData(fTserial)
    End Sub

    Public Shared Function FillData(ByVal fTserial As Integer) As Factura
        Dim oTbale As DataTable
        Dim XSelect As LibX.Data.XSelecStmt
        Dim Productos As SGT.Inventario.Common.Items
        Dim m_documentoId As String
        Dim ncf_afect As String

        Dim FacturaEnviar As New Factura

        Try
            XSelect = New LibX.Data.XSelecStmt("vw_ftfiscal", "select * from vw_ftfiscal where ftserial_no = " & fTserial)
            oTbale = XSelect.GetTable

            If oTbale Is Nothing Then
                Throw New ApplicationException("Documento no encontrado")
            End If

            Dim LocalRow As DataRow

            LocalRow = oTbale.Rows(0)

            Dim mDesctoTotal As Decimal = LocalRow!descto
            Dim mFacturaTotal As Decimal = LocalRow!fact_total

            m_documentoId = GetTipoDocumento(LocalRow!fact_ncf, LocalRow!type_code, LocalRow!whse_code)

            If LocalRow!type_code = "DEV" Then
                Dim oAfectado As DataTable
                Dim afectadoRow As DataRow

                oAfectado = LibX.Data.Manager.GetDataTable("select * from ftfactm where ftserial_no = " & LocalRow!ftserial_afect)

                If (oAfectado.Rows.Count > 0) Then
                    afectadoRow = oAfectado.Rows(0)

                    m_documentoId = GetTipoDocumento(afectadoRow!fact_ncf, afectadoRow!type_code, afectadoRow!whse_code)
                    ncf_afect = afectadoRow!fact_ncf

                    If (m_documentoId = "1") Then
                        m_documentoId = 3
                    Else
                        m_documentoId = 2
                    End If

                    If (Not LibX.IsNull(afectadoRow!cust_code)) Then

                        Dim oCliente As DataTable
                        oCliente = LibX.Data.Manager.GetDataTable("select * from cccustm where cust_code = " & afectadoRow!cust_code)

                        If oCliente.Rows.Count > 0 Then
                            Dim oClientesRow = oCliente.Rows(0)

                            Dim dev_cliente As New Cliente
                            With dev_cliente
                                .RNC = Convert.ToString(oClientesRow!rnc_id).Trim().PadLeft(11, "0")
                                .RazonSocial = Convert.ToString(oClientesRow!cust_name).Trim()
                                .SeguroMedico = String.Empty
                                .Telefono = Convert.ToString(oClientesRow!cust_phone).Trim()
                                .Direccion = Convert.ToString(oClientesRow!cust_address).Trim()
                            End With

                            FacturaEnviar.Cliente = dev_cliente
                        End If
                    End If

                End If

            End If

            If (m_documentoId < 0) Then
                Throw New ApplicationException(String.Format("Tipo de Documento no encontrado para NCF {0}, Retorno: {1} " _
                                        , Convert.ToString(LocalRow!fact_ncf), m_documentoId))
            End If

            'Informacion de la sucursal
            Dim m_sucursal As New Sucursal
            With m_sucursal
                .Codigo = Convert.ToString(LocalRow!suc_code).PadLeft(4, "0")
                .Densidad = String.Empty
                .Direccion = "" 'No se Usa
                .Nombre = "" 'No se Usa
                .NumeroLogo = String.Empty
                .RazonSocial = "" 'No se Usa
                .Resolucion = "" 'No se Usa
                .RNC = "" 'No se Usa
                .Telefono = "" 'No se Usa
            End With
            FacturaEnviar.Sucursal = m_sucursal

            'Informacion General de la Factura
            With FacturaEnviar
                .Cajera = LibX.Data.Manager.GetScalar("select vend_name from ftvendm where vend_code =" & LocalRow!caje_code.ToString.Trim)  'Nombre de la Cajera
                .CajeraId = "" 'No se Usa
                .Fecha = Convert.ToString(LocalRow!fact_date).Trim()
                .NCF = Convert.ToString(LocalRow!fact_ncf).Trim()
                .TotalPagar = LocalRow!fact_total
                .NcfReferencia = Convert.ToString(ncf_afect)  'Se utiliza cuando es una devolucion
                .TipoDocumento = String.Empty
                .TipoDocumentoId = m_documentoId 'Se llenara desde la tabla con el Id correspondiente
                .CodigoCaja = Convert.ToString(LocalRow!caja_code).Trim.PadLeft(4, "0")
                .Devuelta = "" ' No se Usa
                .NIF = "" 'No se Usa
                .DescuentoMonto = FormatNumber(LocalRow!descto)
                .EsDomicilio = Convert.ToBoolean(LocalRow!fact_inddomicilio)
                .NumeroFactura = LocalRow!fact_number

                .Hora = LocalRow!fact_time

                If Not LibX.IsNull(LocalRow!itbis) Then
                    .Itbis = LocalRow!itbis
                End If

                If Not LibX.IsNull(LocalRow!descto) Then
                    .DescuentoMonto = LocalRow!descto
                End If


            End With

            If FacturaEnviar.EsDomicilio Then
                Dim m_domicilio As New Domicilio
                m_domicilio.Cambio = Convert.ToString(LocalRow!domi_cambio)

                m_domicilio.Nota = String.Empty
                If Not LibX.IsNull(LocalRow!address) Then
                    m_domicilio.Nota = Convert.ToString(LocalRow!address)
                End If

                m_domicilio.Mensajero = Convert.ToString(LocalRow!mensajero)
                m_domicilio.Cliente = New Cliente
                m_domicilio.Cliente.Nombre = Convert.ToString(LocalRow!bus_name)
                m_domicilio.Cliente.Telefono = Convert.ToString(LocalRow!cust_phone)
                m_domicilio.Cliente.Direccion = Convert.ToString(LocalRow!cust_address)
                m_domicilio.Cliente.Sector = Convert.ToString(LocalRow!sector_name)

                If Not LibX.IsNull(LocalRow!domi_cambio) Then
                    m_domicilio.Vuelto = Convert.ToDecimal(LocalRow!domi_cambio) - Convert.ToDecimal(LocalRow!fact_descto)
                End If

                FacturaEnviar.Domicilio = m_domicilio
            End If

            If IsNothing(FacturaEnviar.Cliente) Then
                Dim m_cliente As New Cliente
                With m_cliente
                    .RNC = Convert.ToString(LocalRow!rnc_id).Trim().PadLeft(11, "0")
                    .RazonSocial = Convert.ToString(LocalRow!cust_name).Trim()
                    .SeguroMedico = Convert.ToString(LocalRow!seg_amount).Trim()
                    .Telefono = Convert.ToString(LocalRow!cust_phone).Trim()
                    .Direccion = Convert.ToString(LocalRow!cust_address).Trim()
                End With

                FacturaEnviar.Cliente = m_cliente
            End If

            'Buscar y pasar las formas de pagos aplicadas
            Dim oPago As DataTable

            ''//Buscar las informaciones para el tipo de pago dependiendo la forma del documento
            If Not LibX.IsNull(LocalRow!fact_inddomicilio) AndAlso LocalRow!fact_inddomicilio = 0 Then
                oPago = LibX.Data.Manager.GetDataTable("select * from cjtranrm where ftserial_no =" & LocalRow!ftserial_no)
            Else
                oPago = LibX.Data.Manager.GetDataTable("select * from ftdomim where ftserial_no =" & LocalRow!ftserial_no)
            End If

            Dim PagoNumbers As Integer = oPago.Rows.Count

            If PagoNumbers <> 0 Then
                PagoNumbers -= 1
            End If

            Dim m_notaCredito As New NotaCredito

            If Not LibX.IsNull(LocalRow!type_code) AndAlso LocalRow!type_code = "DEV" Then

                Dim oNotaCredito As DataTable

                oNotaCredito = LibX.Data.Manager.GetDataTable("select * from cjncrm where ftserial_no =" & LocalRow!ftserial_no)

                If oNotaCredito.Rows.Count > 0 Then

                    Dim NotaCreditoRow As DataRow = oNotaCredito.Rows(0)

                    With m_notaCredito
                        .Balance = NotaCreditoRow!ncr_balance
                        .Fecha = NotaCreditoRow!ncr_date
                        .Monto = NotaCreditoRow!ncr_amount
                        .Nombre = Convert.ToString(NotaCreditoRow!bus_name)
                        .Numero = NotaCreditoRow!ncr_number
                    End With

                    FacturaEnviar.NotaCredito = m_notaCredito

                End If

                Dim oClienteRnc As DataTable

                oClienteRnc = LibX.Data.Manager.GetDataTable("select * from cjncrm where ftserial_no =" & LocalRow!ftserial_no)

            End If

            Dim m_pagos(PagoNumbers) As Pago
            Dim indexp As Integer = 0
            Dim mTipoTargeta As Integer

            For Each oRowp As DataRow In oPago.Rows

                Dim mPagogado As Decimal

                m_pagos(indexp) = New Pago

                With m_pagos(indexp)
                    If LibX.IsNull(LocalRow!fact_inddomicilio) AndAlso oRowp!pay_method = "TAR" Then
                        mTipoTargeta = LibX.Data.Manager.GetScalar("select type from pvtipotarm where tart_codigo =" & LocalRow!tart_codigo)
                    End If
                    If Not LibX.IsNull(LocalRow!fact_inddomicilio) AndAlso LocalRow!fact_inddomicilio = 0 Then
                        If mTipoTargeta = 2 Then
                            .FormaPago = "TAD"
                        Else
                            .FormaPago = Convert.ToString(oRowp!pay_method).Trim()
                        End If
                        .FormaPagoId = "" 'No se Usa
                        .DescripcionExtra = String.Empty
                        .TotalPagado = FormatNumber(oRowp!amount).Trim()
                    Else
                        .FormaPago = Convert.ToString(oRowp!domi_pago).Trim()
                        .FormaPagoId = "" 'No se Usa
                        .DescripcionExtra = String.Empty
                        If Not LibX.IsNull(oRowp!domi_cambio) Then
                            mPagogado = oRowp!domi_cambio
                        Else
                            mPagogado = LocalRow!fact_total - LocalRow!descto + LocalRow!itbis
                        End If
                        .TotalPagado = FormatNumber(mPagogado).Trim()
                    End If
                End With
                indexp += 1
            Next

            FacturaEnviar.Pagos = m_pagos

            'Las Descripciones pueden ser usadas para imprimir
            'informaciones del seguro o del domicilio.
            Dim m_cierre As New Cierre
            With m_cierre
                .ColaRemplazoNo1 = String.Empty
                .ColaRemplazoDescripcion1 = String.Empty
                .ColaRemplazoNo2 = String.Empty
                .ColaRemplazoDescripcion2 = String.Empty
                .ColaRemplazoNo3 = String.Empty
                .ColaRemplazoDescripcion3 = String.Empty
            End With

            FacturaEnviar.Cierre = m_cierre

            ' Introduciendo los articulos a un Arreglo.
            Dim ItemNumbers As Integer = oTbale.Rows.Count

            If ItemNumbers <> 0 Then
                ItemNumbers -= 1
            End If

            Dim m_articulo(ItemNumbers) As Articulo

            Dim index As Integer = 0

            For Each oRowd As DataRow In oTbale.Rows

                m_articulo(index) = New Articulo

                itbis = 0
                sprice = 0

                'Busca y Valida ITBIS
                If oRowd!taxable = 1 Then
                    itbis = LibX.Data.Manager.GetScalar("select percent_itbis from ivsetup")
                ElseIf oRowd!taxable2 = 1 Then
                    itbis = LibX.Data.Manager.GetScalar("select percent_itbis2 from ivsetup")
                End If

                'Dim t_precio As Decimal = TryParseDecimal(oRowd!price)
                'Dim m_descuento As Decimal = 0.0

                Dim m_qty As Integer = TryParseInteger(oRowd!qty)

                Dim pct_descuento As Decimal = IIf(mDesctoTotal > 0, (mDesctoTotal / mFacturaTotal), 0.0)

                pct_descuento = Decimal.Round(pct_descuento, 3)

                ''Dim m_descuento As Decimal = IIf(m_qty > 0, TryParseDecimal(oRowd!dscto) / m_qty, 0.0)

                Dim m_descuento As Decimal = IIf(m_qty > 0, TryParseDecimal((oRowd!qty * oRowd!price) * pct_descuento) / m_qty, 0.0)

                Dim precio_descuento As Decimal = TryParseDecimal(oRowd!price) - m_descuento

                If itbis > 0 Then
                    sprice = Format(precio_descuento + (precio_descuento * (itbis / 100)), "##,###,##0.00")
                Else
                    sprice = Format(precio_descuento, "##,###,##0.00")
                End If


                ' If itbis > 0 Then
                'sprice = oRowd!price + (oRowd!price * (itbis / 100))
                'End If


                With m_articulo(index)
                    .Cantidad = String.Concat(Convert.ToString(oRowd!qty), "000")
                    .Descripcion = Convert.ToString(oRowd!item_name).Trim()
                    .EsExcentoItbis = "" 'No se Usa
                    .Itbis = Convert.ToString(itbis).Trim().PadRight(4, "0")

                    If sprice > 0 Then
                        .Precio = FormatNumber(sprice)
                    Else
                        .Precio = FormatNumber(oRowd!total_price)
                    End If
                    .Valor = String.Empty
                    .DescripcionExtra1 = String.Empty
                    .Descuento = FormatNumber(oRowd!dscto)
                End With

                index += 1
            Next

            FacturaEnviar.Articulos = m_articulo

            oTbale = Nothing

            Return FacturaEnviar

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function

    Private Shared Function FormatNumber(ByVal Number As Object) As String

        Dim TempNumber As String
        Dim ReturnNumber As String = String.Empty

        If Not LibX.IsNull(Number) Then
            TempNumber = Format(Number, "##,###,##0.00")

            ReturnNumber = TempNumber.Replace(".", "").Replace(",", "")
        End If

        Return ReturnNumber

    End Function


    Private Shared Function FormatCantidad(ByVal Number As Integer) As String
        Dim _temp As String = Convert.ToString(Number)
        Dim ReturnValue As String

        Dim index As Integer = _temp.LastIndexOf(".")

        'Valor en Fraccion
        If index <> -1 Then
            Dim m_numeros() As String = _temp.Split(".")

            Dim m_entero As String = m_numeros(0)
            Dim m_decimal As String = m_numeros(1)

            ReturnValue = m_entero & m_decimal.Replace(".", "").PadRight(3, "0")
        Else 'Valor Entero
            ReturnValue = _temp.Concat("000")
        End If

        Return ReturnValue
    End Function

    Private Shared Function GetTipoDocumento(ByVal Ncf As String, ByVal TypeCode As String, ByVal WhseCode As String) As String

        Dim m_documentoId As Integer = -2
        Try

            ''//Para cuando se haga una factura de seguro medico busque la informacion 
            ''//del comprobante de la factura y mantenga la misma seuencia
            If TypeCode = "FSG" Then
                TypeCode = "FPV"
            End If

            If Ncf.Length > 11 Then
                'Get the 11th first characters of the NCF
                Dim NcfLiteral As String = Ncf.Substring(0, 11)

                Dim m_query As String = "select isnull(ncf_dgii, -1) ncf_dgii FROM ftncfm WHERE whse_code = " & WhseCode & " and type_code = '" & TypeCode & "'" & " and ncf_literal ='" & NcfLiteral & "'"

                m_documentoId = LibX.Data.Manager.GetScalar(m_query)
            End If

            If m_documentoId = -1 Then
                Throw New ApplicationException("Ocurrio un error buscando el tipo de documento de la factura")
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

        Return m_documentoId.ToString()

    End Function


    Private Shared Function TryParseDecimal(ByVal valor As Object) As Decimal

        Dim value As Decimal = 0.0

        Try
            If Not valor Is Nothing Then
                value = Decimal.Parse(valor)
            End If

        Catch ex As Exception

        End Try

        Return value
    End Function

    Private Shared Function TryParseInteger(ByVal valor As Object) As Integer

        Dim value As Integer = 0

        Try
            If Not valor Is Nothing Then
                value = Integer.Parse(valor)
            End If

        Catch ex As Exception

        End Try

        Return value
    End Function
End Class
