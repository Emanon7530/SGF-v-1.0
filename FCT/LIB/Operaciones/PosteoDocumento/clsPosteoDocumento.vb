Imports LibX
Imports SGT.PuntodeVenta.Entidades

Public Class PosteoDocumento
    Public Class Parametros
        Public SerialNumero As Integer
        Public AplicarInventario As Boolean = True
        Public AplicarCXC As Boolean = True
        Public ApliarComision As Boolean = True
        Public Completo As Boolean
        Public UseTransaction As Boolean = False
        Public InitSerial As Integer
        Public initCaja As Integer
        Public InitCaje As Integer
    End Class

    Public Class ParametroAplicarGarantia
        Public FacturaSerial As Integer
        Public FacturaFecha As Date
        Public DevolSerial As Integer
    End Class

    Public Class ParametrosBuscarVencimiento
        Public Producto As String
        Public Cantidad As Integer

        Public Class ValoresRetorno
            Public Qty As Integer
            Public Mes As Integer
            Public Ano As Integer
            Public Proveedor As Integer

            Public Qty1 As Integer
            Public Mes1 As Integer
            Public Ano1 As Integer
            Public Proveedor1 As Integer
        End Class

        Public Retorno As New ValoresRetorno
    End Class
    Public Function AplicarGarantia(ByVal e As ParametroAplicarGarantia) As Boolean
        Dim oftfactd As DataTable
        Dim odvfactm As DataRow
        Dim xSelect As LibX.Data.XSelecStmt
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim DiasUtilizados As Double
        Dim TipoGarantia As Integer

        '// buscar los productos que estan en la devolucion
        '// para calcular la garantia restante
        xSelect = New LibX.Data.XSelecStmt("ftfactd")
        xSelect.Fields("ftserial_no") = e.DevolSerial

        oftfactd = xSelect.GetTable

        If oftfactd Is Nothing Then
            Throw New ApplicationException("No existe factura con este serial!")
        End If

        '// buscar la devolucion para calcular los dias transcurridos
        '// entre la fecha  de la devolucion y la fecha de la nueva factura
        xSelect = New LibX.Data.XSelecStmt("ftfactm")
        xSelect.Fields("ftserial_no") = e.DevolSerial

        odvfactm = xSelect.GetDataRow

        If odvfactm Is Nothing Then
            Throw New ApplicationException("No existe devolución con este serial!")
        End If

        '// Establecer la cantidad de dias consumidos
        DiasUtilizados = DateDiff(DateInterval.Day, e.FacturaFecha, odvfactm!fact_date)

        xUpdate = New LibX.Data.XUpdateStmt("ftfactd")
        xUpdate.Fields("ftserial_no") = e.FacturaSerial

        For Each oRow As DataRow In oftfactd.Rows
            TipoGarantia = oRow!garanty_type

            '//verificamos el tipo de periodo de garantia y convertimos el resultado a este
            Select Case oRow!garanty_type
                Case 1 '// Dias
                    '// Se queda en su modo original
                Case 2 '// Meses
                    DiasUtilizados = DiasUtilizados / 30.4
                    If DiasUtilizados < 1 Then
                        DiasUtilizados = DiasUtilizados * 30.4
                        TipoGarantia = 2 '// MESES
                    End If
                Case 3 '// Anos
                    DiasUtilizados = DiasUtilizados / 365
                    If DiasUtilizados < 1 Then
                        DiasUtilizados = DiasUtilizados * 30.4
                        TipoGarantia = 2 '// MESES
                    End If
                    If DiasUtilizados < 1 Then
                        DiasUtilizados = DiasUtilizados * 365
                        TipoGarantia = 1 '// DIAS
                    End If
            End Select

            '// Actualizar la garantia del documento
            xUpdate.FieldsSet("garanty") = DiasUtilizados
            xUpdate.FieldsSet("garanry_type") = TipoGarantia
            xUpdate.Fields("item_code") = oRow!item_code

            xUpdate.Execute()
        Next

        Return True
    End Function

    Public Function Anular(ByVal e As Parametros) As Boolean
        Dim SelectStmt As String

        Dim oRowHeader As DataRow
        Dim oRowType As DataRow

        Dim oDoc As SGT.Inventario.Entidades.Documento
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim oComm As SGT.Facturacion.Entidades.Comisiones

        Dim oCaja As SGT.Caja.Operaciones.Cobro
        Dim oParamCaja As SGT.Caja.Operaciones.Cobro.ParametrosAnular

        Try
            oComm = New SGT.Facturacion.Entidades.Comisiones
            oCaja = New SGT.Caja.Operaciones.Cobro
            oParamCaja = New SGT.Caja.Operaciones.Cobro.ParametrosAnular

            SelectStmt = "select * from ftfactm " & _
                         " where ftserial_no = " & e.SerialNumero.ToString

            oRowHeader = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRowHeader Is Nothing Then
                Throw New ApplicationException("No se encontró documento con este número!")
            End If

            oDoc = New SGT.Inventario.Entidades.Documento(oRowHeader!type_code)

            If oDoc Is Nothing Then
                Throw New ApplicationException("El tipo de este documento es inválido!")
            End If

            If Not LibX.IsNull(oRowHeader!dev_type) Then
                SelectStmt = "select * from ftdevolt " & _
                             " where dev_type = '" & oRowHeader!dev_type & "'"

                oRowType = LibX.Data.Manager.GetDataRow(SelectStmt)

                If oRowType Is Nothing Then
                    Throw New ApplicationException("No existe el motivo de devolución")
                End If
            End If

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            If e.AplicarInventario = True Then
                If oDoc.AfectaINV = True Then
                    AplicarInventario(oDoc, oRowHeader, True)
                End If

                If oDoc.AfectaCTG = True Then
                    'Si el documento es a credito aplicar a cuenta x cobrar
                    'ParametrosCXC = Cliente, Monto, Fecha, Numero, Tipo, Itbis
                End If
            End If

            ''''// Anular comisiones
            '''If e.ApliarComision = True Then
            '''    If oDoc.PagaComision = True Then
            '''        oComm.Anular(e.SerialNumero)
            '''    End If
            '''End If

            '// Anular en caja y CXC
            If e.AplicarCXC = True Then
                With oParamCaja
                    .AfectaCXC = True
                    .Serial = e.SerialNumero
                    .UserTransaction = False
                End With

                oCaja.Anular(oParamCaja)
            End If

            '// Actualizar el documento a Aplicado
            xUpdate = New LibX.Data.XUpdateStmt("ftfactm")
            xUpdate.FieldsSet("fact_status") = EstatusDocumentosEnum.Anulada  '(Anulado)
            xUpdate.FieldsSet("init_serial") = e.InitSerial
            ''xUpdate.FieldsSet("caja_code") = e.initCaja
            ''xUpdate.FieldsSet("caje_code") = e.InitCaje
            xUpdate.Fields("ftserial_no") = e.SerialNumero

            xUpdate.Execute()

            '// Borrar Domicilio
            Dim XDelete As LibX.Data.XDeleteStmt
            If LibX.IsNull(oRowHeader!fact_inddomicilio) = False AndAlso oRowHeader!fact_inddomicilio = 1 Then
                XDelete = New LibX.Data.XDeleteStmt("ftdomim")
                XDelete.Fields("ftserial_no") = e.SerialNumero
                XDelete.Execute()
            End If

            '// Borrar Seguro
            If oDoc.AfectaSeguroMedico = True Then
                XDelete = New LibX.Data.XDeleteStmt("ftsegrm")
                XDelete.Fields("ftserial_no") = e.SerialNumero
                XDelete.Execute()
            End If

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            Return True

        Catch ex As Exception
            LibX.Log.Add(ex)
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If

            Return False

        End Try
    End Function

    Private Sub AnularSerie(ByVal TypeCode As String, ByVal Serial As Integer)
        '// SI ES UNA FACTURA
        '// ACTUALIZAR AL NULO DEL NUMERO DE LA FACTURA EN LA TABLA DE SERIE

        '// SI ES UNA DEVOLUCION
        '// ACTUALIZAR LAS SERIES AL NUMERO DE FACTURA QUE TIENE LA SERIE EN
        '// LA TABLA DE SERIE POR DOCUMENTO
        Dim SelectStmt As String
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim oTable As DataTable
        Try

            If TypeCode = "FCT" Then
                SelectStmt = "select serie_number,null as ftserial_no from ivseriem " & _
                             " where ftserial_no = " & Serial.ToString
            End If

            If TypeCode = "DVF" Then
                SelectStmt = "select serie_number,ftserial_no from ftseriem " & _
                             " where ftserial_no = " & Serial.ToString
            End If

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            For Each oRow As DataRow In oTable.Rows
                XUpdate = New LibX.Data.XUpdateStmt("ivseriem")

                XUpdate.FieldsSet("ftserial_no") = 0
                XUpdate.FieldsSet("ftserial_no") = oRow!ftserial_no
                XUpdate.Fields("serie_number") = oRow!serie_number
                XUpdate.Execute()

                XUpdate.Dispose()
            Next
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Public Function Aplicar(ByVal e As Parametros) As Boolean
        Dim SelectStmt As String
        Dim oRowHeader As DataRow
        Dim oRowType As DataRow
        Dim oDoc As SGT.Inventario.Entidades.Documento
        Dim oComm As SGT.Facturacion.Entidades.Comisiones
        Dim oDev As MotivoDevolucion
        Dim xUpdate As LibX.Data.XUpdateStmt
        Try
            oComm = New SGT.Facturacion.Entidades.Comisiones

            SelectStmt = "select * from ftfactm " & _
                         " where ftserial_no = " & e.SerialNumero.ToString

            oRowHeader = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRowHeader Is Nothing Then
                Throw New ApplicationException("No se encontró documento con este número!")
            End If

            oDoc = New SGT.Inventario.Entidades.Documento(oRowHeader!type_code)

            If oDoc Is Nothing Then
                Throw New ApplicationException("El tipo de este documento es inválido!")
            End If

            If Not LibX.IsNull(oRowHeader!dev_type) Then
                oDev = New MotivoDevolucion(oRowHeader!dev_type)
            End If

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            If oDoc.AfectaINV = True And e.AplicarInventario = True Then
                If oDev Is Nothing OrElse oDev.AfectaInventario = True Then
                    '// Anular si existe
                    AplicarInventario(oDoc, oRowHeader, True)

                    '// Aplicar
                    AplicarInventario(oDoc, oRowHeader)
                End If
            End If

            If oDoc.PagaComision = True And e.ApliarComision = True Then
                '// Crear comision
                If oComm.Crear(e.SerialNumero) = False Then
                    Throw New ApplicationException("Error creando comisión")
                End If
            End If

            If oDoc.AfectaCTG = True Then
                'Si el documento es a credito aplicar a cuenta x cobrar
                'ParametrosCXC = Cliente, Monto, Fecha, Numero, Tipo, Itbis
            End If

            ''''// Actualizar el documento a Aplicado
            '''xUpdate = New LibX.Data.XUpdateStmt("ftfactm")

            '''xUpdate.FieldsSet("fact_ncf") = 1 '(Pendiente)
            '''xUpdate.Fields("ftserial_no") = e.SerialNumero

            '''xUpdate.Execute()

            'Si el documento afecta seriales 
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            Return True

        Catch ex As Exception
            LibX.Log.Add(ex)
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If

            Return False

        End Try
    End Function

    Private Function CrearVencimiento(ByVal pftserial_no As Integer, ByVal ptype_code As String) As Boolean
        Dim XInsert As LibX.Data.XInsertStmt
        Dim oTable As DataTable
        Dim SelectStmt As String
        Dim oProducto As New SGT.Inventario.Entidades.Articulo
        Dim oUnidad As New SGT.Inventario.Entidades.UnidadMedida
        Dim oParamUnidadMin As New SGT.Inventario.Entidades.UnidadMedida.ParametroConvertirUnidadMinima

        SelectStmt = "select * from ftfactd " & _
                     " where ftserial_no = " & pftserial_no.ToString.Trim

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        If oTable Is Nothing Then
            Throw New ApplicationException("No se encontro este documento!")
        End If

        If oTable.Rows.Count <= 0 Then
            Throw New ApplicationException("No se encontro este documento!")
        End If

        XInsert = New LibX.Data.XInsertStmt("ivvcmtod")

        With XInsert
            .Fields("doc_serial") = pftserial_no
            .Fields("type_code") = ptype_code
            .Fields("line_no") = 0
            .Fields("whse_code") = 0
            .Fields("item_code") = ""
            .Fields("unit_code") = ""
            .Fields("purch_cost") = 0
            .Fields("qty_onhand") = 0
            .Fields("qty") = 0
            .Fields("vcmto_month") = 0
            .Fields("vcmto_year") = 0
            .Fields("qty1") = 0
            .Fields("vcmto_month1") = 0
            .Fields("vcmto_year1") = 0
            .Fields("prov_code") = 0
        End With

        Dim Line As Integer
        Line = 0
        Dim oBuscarVencimiento As New ParametrosBuscarVencimiento

        For Each oRow As DataRow In oTable.Rows
            If oProducto.AplicaParaVencimiento(oRow!item_code) = True Then
                Line += 1

                oParamUnidadMin.Cantidad = oRow!qty
                oParamUnidadMin.Producto = oRow!item_code
                oParamUnidadMin.UnidadOrigen = oRow!unit_code
                oUnidad.ConvertirUnidadMinima(oParamUnidadMin)

                oBuscarVencimiento.Producto = oRow!item_code
                oBuscarVencimiento.Cantidad = oParamUnidadMin.Retorno.Cantidad

                If BuscarVencimiento(oBuscarVencimiento) = False Then
                    GoTo next_reg
                End If

                With XInsert
                    .Fields("line_no").value = Line
                    .Fields("whse_code").value = oRow!whse_code
                    .Fields("item_code").value = oRow!item_code
                    .Fields("unit_code").value = oParamUnidadMin.Retorno.Unidad
                    .Fields("purch_cost").value = oRow!costo

                    .Fields("qty").value = oBuscarVencimiento.Retorno.Qty
                    .Fields("vcmto_month").value = oBuscarVencimiento.Retorno.Mes
                    .Fields("vcmto_year").value = oBuscarVencimiento.Retorno.Ano
                    .Fields("prov_code").value = oBuscarVencimiento.Retorno.Proveedor

                    If oBuscarVencimiento.Retorno.Qty1 > 0 And oBuscarVencimiento.Retorno.Proveedor = oBuscarVencimiento.Retorno.Proveedor1 Then
                        .Fields("qty1").value = oBuscarVencimiento.Retorno.Qty1
                        .Fields("vcmto_month1").value = oBuscarVencimiento.Retorno.Mes1
                        .Fields("vcmto_year1").value = oBuscarVencimiento.Retorno.Ano1
                    End If

                    .Execute()

                    '// si hay mas de 1 vencimiento y es de diferentes suplidores insertar
                    '/// uno nuevo con el segundo suplidor
                    If oBuscarVencimiento.Retorno.Qty1 > 0 And oBuscarVencimiento.Retorno.Proveedor <> oBuscarVencimiento.Retorno.Proveedor1 Then
                        Line += 1
                        .Fields("line_no").value = Line

                        .Fields("qty").value = oBuscarVencimiento.Retorno.Qty1
                        .Fields("vcmto_month").value = oBuscarVencimiento.Retorno.Mes1
                        .Fields("vcmto_year").value = oBuscarVencimiento.Retorno.Ano1
                        .Fields("prov_code").value = oBuscarVencimiento.Retorno.Proveedor1

                        .Execute()
                    End If

                End With
            End If
next_reg:
        Next

        Return True
    End Function

    Private Function DevolverVencimiento(ByVal pftserial_no As Integer, ByVal pftserial_afect As Integer, ByVal ptype_code As String) As Boolean
        Dim XInsert As LibX.Data.XInsertStmt
        Dim oTable As DataTable
        Dim SelectStmt As String
        Dim oProducto As New SGT.Inventario.Entidades.Articulo
        Dim oUnidad As New SGT.Inventario.Entidades.UnidadMedida
        Dim oParamUnidadMin As New SGT.Inventario.Entidades.UnidadMedida.ParametroConvertirUnidadMinima

        SelectStmt = "select * from ftfactd " & _
                     " where ftfactd.ftserial_no = " & pftserial_no.ToString.Trim

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        If oTable Is Nothing Then
            Throw New ApplicationException("No se encontro este documento!")
        End If

        If oTable.Rows.Count <= 0 Then
            Throw New ApplicationException("No se encontro este documento!")
        End If

        XInsert = New LibX.Data.XInsertStmt("ivvcmtod")

        With XInsert
            .Fields("doc_serial") = pftserial_no
            .Fields("type_code") = ptype_code
            .Fields("line_no") = 0
            .Fields("whse_code") = 0
            .Fields("item_code") = ""
            .Fields("unit_code") = ""
            .Fields("purch_cost") = 0
            .Fields("qty_onhand") = 0
            .Fields("qty") = 0
            .Fields("vcmto_month") = 0
            .Fields("vcmto_year") = 0
            .Fields("qty1") = 0
            .Fields("vcmto_month1") = 0
            .Fields("vcmto_year1") = 0
            .Fields("prov_code") = 0
        End With

        Dim Line As Integer
        Line = 0

        For Each oRow As DataRow In oTable.Rows
            If oProducto.AplicaParaVencimiento(oRow!item_code) = True Then

                oParamUnidadMin.Cantidad = oRow!qty
                oParamUnidadMin.Producto = oRow!item_code
                oParamUnidadMin.UnidadOrigen = oRow!unit_code
                oUnidad.ConvertirUnidadMinima(oParamUnidadMin)

                '// Buscar el vencimiento facturado
                SelectStmt = "select * from ivvcmtod " & _
                             " where item_code = '" & oRow!item_code.ToString.Trim & "'" & _
                             " and whse_code = " & oRow!whse_code.ToString.Trim & _
                             " and doc_serial = " & pftserial_afect.ToString.Trim

                Dim oTable1 As DataTable

                oTable1 = LibX.Data.Manager.GetDataTable(SelectStmt)

                If oTable1 Is Nothing Then
                    Return False
                End If

                If oTable1.Rows.Count <= 0 Then
                    Return True
                End If

                For Each orow1 As DataRow In oTable1.Rows
                    Line += 1

                    With XInsert
                        .Fields("line_no").value = Line
                        .Fields("whse_code").value = oRow!whse_code
                        .Fields("item_code").value = oRow!item_code
                        .Fields("unit_code").value = oParamUnidadMin.Retorno.Unidad
                        .Fields("purch_cost").value = oRow!costo
                        .Fields("vcmto_month").value = orow1!vcmto_month
                        .Fields("vcmto_year").value = orow1!vcmto_year
                        .Fields("prov_code").value = orow1!prov_code

                        '// Si la cantidad a devolver es mayor que la cantidad del registro de vencimiento
                        '// entonces se afecto mas de 1 vencimiento, si tiene especificado MES1 entonces
                        '// son del mismo suplidor, de lo contrario son de suplidores diferentes y hay mas
                        '// de un registro
                        If oParamUnidadMin.Retorno.Cantidad > Val(orow1!qty.ToString.Trim) And Val(orow1!vcmto_month1.ToString.Trim) > 0 Then
                            .Fields("qty").value = orow1!qty
                            .Fields("qty1").value = oParamUnidadMin.Retorno.Cantidad - Val(orow1!qty.ToString.Trim)

                            .Fields("vcmto_month1").value = orow1!vcmto_month1
                            .Fields("vcmto_year1").value = orow1!vcmto_year1
                        Else
                            '// si la cantidad es mayor que la cantidad del vencimiento
                            '// entonces insertar la cantidad del vencimiento, de lo contrario
                            '// la cantidad a devolver
                            If oParamUnidadMin.Retorno.Cantidad > Val(orow1!qty.ToString.Trim) Then
                                .Fields("qty").value = orow1!qty
                            Else
                                .Fields("qty").value = oParamUnidadMin.Retorno.Cantidad
                            End If
                        End If

                        .Execute()
                    End With
                Next
            End If
        Next

        Return True
    End Function

    Public Function BuscarVencimiento(ByVal p_Args As ParametrosBuscarVencimiento) As Boolean
        Dim SelectStmt As String
        Dim oRow As DataRow
        Dim Resta As Integer
        SelectStmt = "select * from ivvcmtev    " & _
                     " where item_code = {0} " & _
                    " and fechavencimiento in (select min(fechavencimiento) from ivvcmtev ivv " & _
                    "                           where ivv.item_code = '{0}')"

        SelectStmt = String.Format(SelectStmt, p_Args.Producto)

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oRow Is Nothing Then
            Return False
        End If

        p_Args.Retorno.Ano = oRow!Ano
        p_Args.Retorno.Mes = oRow!mes
        p_Args.Retorno.Proveedor = oRow!prov_code

        If Val(oRow!existencia.ToString.Trim) > p_Args.Cantidad Then
            '// Primer Vencimiento
            p_Args.Retorno.Qty = p_Args.Cantidad
        Else
            p_Args.Retorno.Qty = Val(oRow!existencia.ToString.Trim)

            SelectStmt = "select * from ivvcmtev  " & _
                         " where item_code = '{0}' " & _
                        " and fechavencimiento in (select min(fechavencimiento) from ivvcmtev ivv " & _
                        "                           where ivv.item_code = '{0}' and (ivv.mes <> {1} or ivv.ano <> {2}))"

            SelectStmt = String.Format(SelectStmt, p_Args.Producto, p_Args.Retorno.Mes, p_Args.Retorno.Ano)

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If Not oRow Is Nothing Then
                '// Primer Vencimiento
                Resta = p_Args.Cantidad - p_Args.Retorno.Qty
                p_Args.Retorno.Qty1 = Resta
                p_Args.Retorno.Ano1 = oRow!Ano
                p_Args.Retorno.Mes1 = oRow!mes
                p_Args.Retorno.Proveedor1 = oRow!prov_code
            End If

        End If

        Return True
    End Function
    Private Function AplicarInventario(ByVal oDoc As SGT.Inventario.Entidades.Documento, ByVal oRowHeader As DataRow, Optional ByVal Anular As Boolean = False) As Boolean
        Dim SelectStmt As String
        Dim oDetail As DataTable
        Dim oPostInv As SGT.Inventario.Operaciones.PostInventory
        Dim oParamInv As SGT.Inventario.Operaciones.PostInventory.ParametrosAplicar
        Dim oParamAnu As SGT.Inventario.Operaciones.PostInventory.ParametrosAnular
        Dim oItems As SGT.Inventario.Common.Items
        Try
            oPostInv = New SGT.Inventario.Operaciones.PostInventory

            If Anular = True Then
                oParamAnu = New SGT.Inventario.Operaciones.PostInventory.ParametrosAnular

                oParamAnu.Productos = oItems
                oParamAnu.Serial = oRowHeader!ftserial_no
                oParamAnu.Numero = oRowHeader!fact_number.ToString.Trim
                oParamAnu.TipoTransaccion = oRowHeader!type_code
                oParamAnu.UseTransaction = False

                If oPostInv.Anular(oParamAnu) = False Then
                    Throw New ApplicationException("Error aplicando a inventario!")
                End If
            Else
                oParamInv = New SGT.Inventario.Operaciones.PostInventory.ParametrosAplicar

                oItems = New SGT.Inventario.Common.Items

                SelectStmt = "select ftfactd.*,ivitemd.existencia " & _
                            " from ftfactd, ivitemd where ftserial_no = " & _
                            oRowHeader!ftserial_no.ToString & _
                            " and ftfactd.item_code = ivitemd.item_code " & _
                            " and ftfactd.whse_code = ivitemd.whse_code "

                oDetail = LibX.Data.Manager.GetDataTable(SelectStmt)

                For Each oRow As DataRow In oDetail.Rows
                    Dim oItem As New SGT.Inventario.Common.ItemInventory
                    With oItem
                        .ItemID = oRow!item_code
                        .Cost = oRow!costo
                        .Impto = 0
                        .Price = oRow!price
                        .OnHand = oRow!existencia
                        .PurchCost = oRow!costo
                        .Unidad = oRow!unit_code
                        .Qty = oRow!qty
                        .Wh = oRow!whse_code
                        .FacTor = oRow!factor
                    End With

                    With oItems
                        .Add(oItem)
                    End With
                Next

                '// Crear el documento de vencimiento
                If oRowHeader!type_code.ToString.Trim = "DEV" Then
                    If LibX.IsNull(oRowHeader!ftserial_afect) = False Then
                        DevolverVencimiento(oRowHeader!ftserial_no, oRowHeader!ftserial_afect, oRowHeader!type_code)
                    End If
                Else
                    CrearVencimiento(oRowHeader!ftserial_no, oRowHeader!type_code)
                End If

                oParamInv.Productos = oItems
                oParamInv.DocDate = oRowHeader!fact_date
                oParamInv.Numero = oRowHeader!fact_number.ToString.Trim
                oParamInv.Serial = oRowHeader!ftserial_no
                oParamInv.Referencia = Val(oRowHeader!cust_code.ToString)
                oParamInv.TipoTransaccion = oRowHeader!type_code
                oParamInv.UseTransaction = False

                If oPostInv.Aplicar(oParamInv) = False Then
                    Throw New ApplicationException("Error aplicando a inventario!")
                End If
                End If

            Return True

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False
        End Try
    End Function
End Class
