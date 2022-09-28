Public Class Articulo


    Dim _Codigo As String
    Dim _Almacen As Integer
    Dim _Descripcion As String
    Dim _Abreviada As String
    Dim _UnidadCompra As String
    Dim _UnidadVenta As String
    Dim _Suplidor As Integer
    Dim _Ubicacion As String
    Dim _Costo As Decimal
    Dim _Precio As Decimal
    Public Class ParametrosPrecioValido
        Public Producto As String
        Public Almacen As Integer
        Public Unidad As String
        Public Costo As Decimal
        Public Precio As Decimal
    End Class
    Public Class ParametrosCalcularItbis
        Public Producto As String
        Public Almacen As Integer
        Public Monto As Decimal
    End Class
    Public Class ParametrosCalculardescuentos
        Public Producto As String
        Public Almacen As Integer
        Public Monto As Decimal = 0
    End Class

    Public Class ParametrosAplicarItbis
        Public Producto As String
        Public Almacen As Integer = -1
        Public PagaITBISUNO As Boolean
        Public PagaITBISDOS As Boolean
    End Class

    Public Class ParametrosCostosLocales
        Public Producto As String
        Public Almacen As Integer
        Public Costo As Decimal
        Public Precio As Decimal
        Public ItbisUno As Integer
        Public ItbisDos As Integer
        Public Beneficio As Decimal
        Public PagaItbisUno As Boolean
        Public PagaItbisDos As Boolean
        Public Cantidad As Integer = 1
        Public Ofertas As Integer
        Public UnidadCompra As String = ""
        Public Descuento As String = ""
        Public ISC As String = ""
        Public Sucode As Integer = 1

        Public Importe As Decimal = Costo * Cantidad
        Public TotalFactura As Decimal = 0
        Public TotalITBISUno As Decimal = 0
        Public TotalITBISDos As Decimal = 0

        Public IncluirDescuento As Boolean = False
        Public IncluirITBISUno As Boolean = False
        Public IncluirITBISDos As Boolean = False
        Public incluirISC As Boolean = False
        Public incluirOFERTA As Boolean = False

        Public Class Retorno
            Public Precioitbis As Decimal
            Public Itbis As Decimal
            Public Precio As Decimal
            Public Beneficio As Decimal
            Public costo As Decimal
            Public descuento As Decimal
            Public Impto As Decimal
        End Class

        Public ValoresRetorno As New Retorno
    End Class

    Public Class ParametrosCostosIntern
        Public Producto As String
        Public Almacen As Integer
        Public TotalBruto As Decimal
        Public PorcientoFOB As Decimal
        Public GastosGeneralesUS As Decimal
        Public PorcientoGastosAduanales As Decimal
        Public CostoUS As Decimal
        Public Cantidad As Integer
        Public Beneficio As Decimal
        Public Tasa As Decimal
        Public Class Retorno
            Public Shared CostoCompraUS As Decimal
            Public Shared CostoCompraRD As Decimal
            Public Shared MontoFOBUS As Decimal
            Public Shared MontoGastosUS As Decimal
            Public Shared MontoAduanalesUS As Decimal
            Public Shared PrecioUS As Decimal
            Public Shared PrecioRD As Decimal
        End Class
    End Class
    Public Class GetOnHandParameters
        Public Producto As String
        Public WareHouse As Integer
    End Class
    Public ReadOnly Property Codigo() As String
        Get
            Return _Codigo
        End Get
    End Property


    Public ReadOnly Property Almacen() As String
        Get
            Return _Almacen
        End Get
    End Property

    Public ReadOnly Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
    End Property

    Public ReadOnly Property Abreviada() As String
        Get
            Return _Abreviada
        End Get
    End Property

    Public ReadOnly Property UnidadCompra() As String
        Get
            Return _UnidadCompra
        End Get
    End Property

    Public ReadOnly Property UnidadVenta() As String
        Get
            Return _UnidadVenta
        End Get
    End Property
    Public ReadOnly Property Suplidor() As Integer
        Get
            Return _Suplidor
        End Get
    End Property

    Public ReadOnly Property Ubicacion() As String
        Get
            Return _Ubicacion
        End Get
    End Property

    Public ReadOnly Property Costo() As Decimal
        Get
            Return _Costo
        End Get
    End Property

    Public ReadOnly Property Precio() As Decimal
        Get
            Return _Precio
        End Get
    End Property

    Public Sub New(Optional ByVal Producto As String = "")
        Dim oRow As DataRow
        Dim SelectStmt As String

        If Producto.Trim <> "" Then
            SelectStmt = "Select item_code,item_name,purch_unit,unit_code," & _
                         "prov_code,ubicacion,price,purch_cost,whse_code from ivitemv1 " & _
                         "where item_code = '" & Producto.Trim & "'"

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If Not oRow Is Nothing Then
                Me._Codigo = Producto
                Me._Almacen = oRow!whse_code
                Me._Descripcion = oRow!item_name.ToString.Trim
                Me._UnidadCompra = oRow!purch_unit.ToString.Trim
                Me._UnidadVenta = oRow!unit_code.ToString.Trim
                Me._Suplidor = Val(oRow!prov_code.ToString.Trim)
                Me._Ubicacion = oRow!ubicacion.ToString.Trim
                Me._Costo = Val(oRow!purch_cost.ToString.Trim)
                Me._Precio = Val(oRow!price.ToString.Trim)
            End If

        End If
    End Sub

    Public Sub New(ByVal Producto As String, ByVal Almacen As Integer)
        Dim oRow As DataRow
        Dim SelectStmt As String

        Try
            If Producto.Trim <> "" Then
                SelectStmt = "Select item_code,item_name,purch_unit,unit_code," & _
                             "prov_code,ubicacion,price,purch_cost from ivitemv1 " & _
                             "where item_code = '" & Producto.Trim & "'" & _
                             " and whse_code = " & Almacen.ToString.Trim

                oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

                If Not oRow Is Nothing Then
                    Me._Codigo = Producto
                    Me._Descripcion = oRow!item_name.ToString.Trim
                    Me._UnidadCompra = oRow!purch_unit.ToString.Trim
                    Me._UnidadVenta = oRow!unit_code.ToString.Trim
                    Me._Suplidor = Val(oRow!prov_code.ToString.Trim)
                    Me._Ubicacion = oRow!ubicacion.ToString.Trim
                    Me._Costo = Val(oRow!purch_cost.ToString.Trim)
                    Me._Precio = Val(oRow!price.ToString.Trim)
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Public Function GetOnHand(ByVal e As GetOnHandParameters) As Integer
        Dim SelectStmt As String
        Dim OnHand As Integer
        Try

            SelectStmt = "Select existencia from ivitemd " & _
                         " where item_code = '" & e.Producto.Trim & "'" & _
                         "   and whse_code = " & e.WareHouse.ToString

            OnHand = Val(LibX.Data.Manager.GetScalar(SelectStmt).ToString)

            Return OnHand

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
    Public Function CalcularItbis(ByVal e As ParametrosCalcularItbis) As Decimal
        Dim Taxable As Boolean
        Dim taxable2 As Boolean
        Dim itbis As Decimal
        Dim porc_itbis As Decimal
        Dim oConfig As New SGT.Inventario.Common.Configuration
        Try

            Taxable = PagaItbisUno(e.Producto)
            taxable2 = PagaItbisDos(e.Producto, e.Almacen)


            '// No paga ITBIS
            If Taxable = False And taxable2 = False Then
                Return 0
            End If

            '// Porciento de itbis
            If Taxable = True Then
                porc_itbis = oConfig.GetITBIS
            End If
            If taxable2 = True Then
                porc_itbis = oConfig.GetITBISDOS
            End If

            itbis = e.Monto * (porc_itbis / 100)

            Return itbis

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return -1
        End Try
    End Function
    Public Function CalcularDscto(ByVal e As ParametrosCalculardescuentos) As Decimal
        Dim dscto As Decimal
        Dim descuento As Integer
        Dim porc_dscto As Decimal
        Dim oConfig As New SGT.Inventario.Common.Configuration
        Try

            descuento = AplicadDscto(e.Producto)

            '// Calcular el descuento auto 
            If descuento = 0 Then
                Return 0
            End If

            '// Porciento de descuento
            porc_dscto = PctdDscto(e.Producto)

            If porc_dscto = 0 Then
                porc_dscto = oConfig.GetDSCTO
            End If

            dscto = e.Monto * (porc_dscto / 100)

            If dscto = Nothing Then
                dscto = 0
            End If

            Return dscto

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return -1

        End Try
    End Function
    Public Function CalcularDsctoLineal(ByVal e As ParametrosCalculardescuentos) As Decimal
        Dim dscto As Decimal
        Dim descuento As Decimal
        Dim oConfig As New SGT.Inventario.Common.Configuration
        Try

            descuento = PctdDsctoLineal(e.Producto)

            '// Calcular el descuento auto 
            If descuento = 0 Then
                Return 0
            End If

            dscto = e.Monto * (descuento / 100)

            If dscto = Nothing Then
                dscto = 0
            End If

            Return dscto

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return -1

        End Try
    End Function


    Public Function isPrecioValido(ByVal e As ParametrosPrecioValido) As Boolean
        Dim SelectStmt As String
        Dim factor As Integer
        Dim CostoUnitario As Decimal

        If e.Almacen <= 0 Then
            Return False
        End If

        If e.Precio <= 0 Then
            Return False
        End If

        If e.Costo <= 0 Then
            Return False
        End If

        Dim oUnidad As New UnidadMedida
        factor = oUnidad.GetFactor(e.Producto, e.Unidad)

        If factor = 0 Then
            Throw New ApplicationException("No hay unidades asignada, Factor para esta unidad es 0")
        End If

        CostoUnitario = e.Costo / factor

        If e.Precio < CostoUnitario Then
            Return False
        End If

        Return True

    End Function

    Public Function AplicarITBIS(ByVal e As ParametrosAplicarItbis) As Boolean
        Dim oParamLocal As New ParametrosCostosLocales
        Dim oTable As DataTable
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim SelectStmt As String

        SelectStmt = "select * from ivitemd " & _
                     " where item_code = '" & e.Producto.Trim & "'"

        If e.Almacen <> -1 Then
            SelectStmt = "select * from ivitemd " & _
                         " where item_code = '" & e.Producto.Trim & "'" & _
                         " and whse_code = " & e.Almacen.ToString.Trim
        End If

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        If oTable Is Nothing Then
            Throw New ApplicationException("No se encontro producto!")
        End If

        If oTable.Rows.Count <= 0 Then
            Throw New ApplicationException("No se encontro producto!")
        End If

        XUpdate = New LibX.Data.XUpdateStmt("ivitemd")

        For Each oRow As DataRow In oTable.Rows
            With oParamLocal
                .Producto = e.Producto
                .Almacen = Val(oRow!whse_code.ToString.Trim)
                .Beneficio = Val(oRow!Benef.ToString.Trim)
                .Costo = Val(oRow!purch_cost.ToString.Trim)
                .PagaItbisUno = e.PagaITBISUNO
                .PagaItbisDos = e.PagaITBISDOS
            End With

            CalcularCostoLocal(oParamLocal)
            With XUpdate
                '// Cambio
                If e.PagaITBISUNO = True Then
                    .FieldsSet("taxable") = e.PagaITBISUNO
                End If
                ''If e.PagaITBISDOS = True Then
                ''    .FieldsSet("taxable2") = e.PagaITBISDOS
                ''End If
                .FieldsSet("price") = oParamLocal.ValoresRetorno.Precio

                '// Condicon
                .Fields("item_code") = e.Producto
                .Fields("whse_code") = Val(oRow!whse_code.ToString.Trim)

                .Execute()
            End With
        Next
    End Function

    Public Function CalcularCostoLocal(ByVal e As ParametrosCostosLocales) As Boolean
        Dim Porciento As Decimal
        Dim Benef As Decimal
        Dim oUnidad As UnidadMedida
        Dim factor As Decimal
        Dim pocITBIS As Decimal
        Dim MontoITBIS As Decimal
        Dim TotalDescuento As Decimal
        Dim TotalISC As Decimal
        Dim otable As DataTable
        Dim SelectStmt As String
        Dim mConfig As New SGT.Inventario.Common.Configuration
        Try

            If e.Costo <= 0 Then
                Throw New ApplicationException("Costo inválido, verifique!")
            End If

            If e.ItbisUno <= 0 Then
                e.ItbisUno = mConfig.GetITBIS
            End If
            If e.ItbisDos <= 0 Then
                e.ItbisDos = mConfig.GetITBISDOS
            End If

            If e.Beneficio <= 0 Then
                e.Beneficio = mConfig.GetBenef
            End If

            If e.UnidadCompra.Trim = "" Then
                SelectStmt = "select unit_code from ivitemm " & _
                             " where item_code = '" & e.Producto.Trim & "'"

                e.UnidadCompra = LibX.Data.Manager.GetScalar(SelectStmt).ToString
            End If

            If e.Descuento.Trim <> "" Then
                If e.Descuento.IndexOf("%") > 0 Then
                    TotalDescuento = e.Descuento.Substring(0, e.Descuento.IndexOf("%"))
                    TotalDescuento = (e.Cantidad * e.Costo) * (TotalDescuento / 100)
                Else
                    TotalDescuento = e.Descuento
                End If
            End If

            If e.ISC.Trim <> "" Then
                If e.ISC.IndexOf("%") > 0 Then
                    TotalISC = e.ISC.Substring(0, e.ISC.IndexOf("%"))
                    TotalISC = (e.Cantidad * e.Costo) * (TotalISC / 100)
                Else
                    TotalISC = e.ISC
                End If
            End If

            '// Paga ITBIS
            e.PagaItbisUno = Me.PagaItbisUno(e.Producto)

            If e.PagaItbisUno = False Then
                e.PagaItbisDos = Me.PagaItbisDos(e.Producto, e.Almacen)
            End If

            '// UNIDAD
            oUnidad = New UnidadMedida
            factor = oUnidad.GetFactor(e.Producto, e.UnidadCompra)

            If factor = 0 Then
                Throw New ApplicationException("Factor para esta unidad es 0")
            End If

            '// Calcular Costo Unitario
            e.ValoresRetorno.costo = (e.Costo / factor)

            '// Calcular el monto total de ITBIS
            '// ESTE CALCULO SE HACE POR SI EL MONTO PAGADO POR ITBIS 
            '// NO ES A TODOS LOS PRODUCTOS
            If e.ItbisUno > 0 Then
                MontoITBIS = ((e.TotalITBISUno * 100) / e.ItbisUno)
            End If
            If e.ItbisDos > 0 Then
                MontoITBIS = ((e.TotalITBISDos * 100) / e.ItbisDos)
            End If

            '// Calcular Descuento aplicado
            '// EMR If TotalDescuento > 0 And e.IncluirDescuento = True Then
            If TotalDescuento > 0 Then
                e.ValoresRetorno.descuento = TotalDescuento
                TotalDescuento /= factor
            End If

            '// CAlcular Itbis
            If e.TotalITBISUno > 0 AndAlso e.IncluirITBISUno = True AndAlso e.PagaItbisUno = True Then
                e.ValoresRetorno.Itbis = ((e.Costo * e.Cantidad) - e.ValoresRetorno.descuento) * (e.ItbisUno / 100)
            End If

            If e.TotalITBISDos > 0 AndAlso e.IncluirITBISDos = True AndAlso e.PagaItbisDos = True Then
                e.ValoresRetorno.Itbis = ((e.Costo * e.Cantidad) - e.ValoresRetorno.descuento) * (e.ItbisDos / 100)
            End If

            '// Calcular ISC
            If TotalISC > 0 And e.incluirISC = True Then
                e.ValoresRetorno.Impto = TotalISC
            End If

            '// Distribuir Oferta
            If e.Ofertas > 0 And e.incluirOFERTA = True Then
                e.ValoresRetorno.costo = (e.ValoresRetorno.costo * e.Cantidad) / (e.Cantidad + e.Ofertas)
                'e.Cantidad = e.Cantidad + e.Ofertas
            End If

            '// Distribuir Descuento
            If TotalDescuento > 0 And e.IncluirDescuento = True Then
                e.ValoresRetorno.costo = e.ValoresRetorno.costo - (TotalDescuento / e.Cantidad)
            End If

            '// Distribuir ITBIS
            If e.TotalITBISUno > 0 AndAlso e.IncluirITBISUno = True AndAlso e.PagaItbisUno = True Then
                e.ValoresRetorno.costo = e.ValoresRetorno.costo + (e.ValoresRetorno.Itbis / e.Cantidad)
            End If

            If e.TotalITBISDos > 0 AndAlso e.IncluirITBISDos = True AndAlso e.PagaItbisDos = True Then
                e.ValoresRetorno.costo = e.ValoresRetorno.costo + (e.ValoresRetorno.Itbis / e.Cantidad)
            End If

            '// Distribuir ISC
            If TotalISC > 0 And e.incluirISC = True Then
                e.ValoresRetorno.costo = e.ValoresRetorno.costo + (e.ValoresRetorno.Impto / e.Cantidad)
            End If

            '// Si el precio es cero debe tener Beneficio y Costo
            '// Si el Beneficio es cero debe tener Precio y costo
            '// Si el Costo es cero debe tener Precio y Beneficio
            If e.Precio <= 0 Then
                e.ValoresRetorno.Precio = (e.ValoresRetorno.costo * (e.Beneficio / 100.0)) + e.ValoresRetorno.costo
                e.ValoresRetorno.Beneficio = e.Beneficio
            Else
                e.ValoresRetorno.costo = (e.Costo / factor)
                e.ValoresRetorno.Precio = e.Precio
                e.ValoresRetorno.Beneficio = ((e.Precio - (e.ValoresRetorno.costo / factor)) / (e.ValoresRetorno.costo / factor)) * 100
            End If

            If e.PagaItbisUno = True AndAlso e.IncluirITBISUno = False Then
                e.ValoresRetorno.Itbis = ((e.Costo * e.Cantidad) - e.ValoresRetorno.descuento) * (e.ItbisUno / 100)
            End If
            If e.PagaItbisDos = True AndAlso e.IncluirITBISDos = False Then
                e.ValoresRetorno.Itbis = ((e.Costo * e.Cantidad) - e.ValoresRetorno.descuento) * (e.ItbisDos / 100)
            End If

            If e.PagaItbisUno = True Then
                e.ValoresRetorno.Precioitbis = e.ValoresRetorno.Precio + e.ValoresRetorno.Itbis
            Else
                If e.PagaItbisDos = True Then
                    e.ValoresRetorno.Precioitbis = e.ValoresRetorno.Precio + e.ValoresRetorno.Itbis
                Else
                    e.ValoresRetorno.Precioitbis = 0
                End If
            End If

            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False
        End Try
    End Function

    Public Function CalcularCostoIntern(ByVal e As ParametrosCostosIntern) As Boolean
        Dim Porciento As Decimal
        Dim Benef As Decimal
        Dim Tasa As Decimal
        Dim mConfig As SGT.Inventario.Common.Configuration
        Dim FOBUS, GAUS, GGUS As Decimal
        Try

            '// validar el total bruto
            If e.TotalBruto <= 0 Then
                Throw New ApplicationException("Tota Bruto inválido, verifique!")
            End If

            '// configuracion
            mConfig = New SGT.Inventario.Common.Configuration

            If e.Tasa = 0 Then
                Tasa = mConfig.GetTasaUS
            Else
                Tasa = e.Tasa
            End If

            If Tasa <= 0 Then
                Throw New ApplicationException("No se ha establecido la tasa del dolar!")
            End If

            '// Calcular el Precio
            If e.Beneficio = 0 Then
                Benef = GetBeneficio(e.Producto, e.Almacen)
            Else
                Benef = e.Beneficio
            End If

            If Benef <= 0 Then
                Throw New ApplicationException(String.Format("No se ha establecido el % beneficio para el producto {0}, almcén {1}", e.Producto.ToString, e.Almacen.ToString))
            End If

            '// Calcular FOB en dolar
            '// Total FOB = (TotalBruto * % FOB)
            '// % Apliar al FOB = (Costo * Cantidad) / TotalBruto
            '// FOB = Total FOB * % Aplicar al FOB
            FOBUS = (e.TotalBruto * (e.PorcientoFOB / 100)) * ((e.CostoUS * e.Cantidad) / e.TotalBruto)

            '// Calcular Gastos Aduanales en dolar
            GAUS = (e.TotalBruto * (e.PorcientoGastosAduanales / 100)) * ((e.CostoUS * e.Cantidad) / e.TotalBruto)

            '// Calcular Gastos Generales en dolar
            GGUS = e.GastosGeneralesUS * ((e.CostoUS * e.Cantidad) / e.TotalBruto)

            '// Calcular FOB
            e.Retorno.MontoFOBUS = FOBUS

            '// Calcular Gastos Aduanales
            e.Retorno.MontoAduanalesUS = GAUS

            '// Calcular Gastos Generales
            e.Retorno.MontoGastosUS = GGUS

            '// Costo de Compra en Dolares
            e.Retorno.CostoCompraUS = e.CostoUS + (FOBUS / e.Cantidad) + (GGUS / e.Cantidad) + (GAUS / e.Cantidad)

            '// Costo Compra RD
            e.Retorno.CostoCompraRD = e.Retorno.CostoCompraUS * Tasa

            '// Cacular el Precio RD
            e.Retorno.PrecioRD = e.Retorno.CostoCompraRD + (e.Retorno.CostoCompraRD * (Benef / 100))

            '// Calcular Precio en US
            e.Retorno.PrecioUS = e.Retorno.PrecioRD / Tasa

            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False
        End Try
    End Function

    Public Function AplicaParaVencimiento(ByVal Producto As String) As Boolean
        Dim Vencimiento As Integer
        Dim XSelect As LibX.Data.XSelecStmt
        Dim SelectStmt As String
        Try
            SelectStmt = String.Concat("Select aplicar_vcmto from ivitemm", _
                                     " where item_code = '", Producto.Trim, "'")

            Vencimiento = LibX.Data.Manager.GetScalar(SelectStmt)

            If Vencimiento = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function BuscarRefernBarra(ByVal codigo As String) As String
        Dim Item As String
        Dim Producto As String
        Dim XSelect As LibX.Data.XSelecStmt
        Dim SelectStmt As String
        Try

            SelectStmt = String.Concat("Select item_code from ivreferm", _
                                     " where refer = '", codigo.Trim, "'")


            Item = LibX.Data.Manager.GetScalar(SelectStmt)

            If Item <> "" Then
                Producto = Item
            Else
                SelectStmt = String.Concat("Select item_code from ivcbarram", _
                                                    " where barra = '", codigo.Trim, "'")
            End If

            Producto = LibX.Data.Manager.GetScalar(SelectStmt)

            Return Producto

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function PagaItbisUno(ByVal Producto As String) As Boolean
        Dim Taxable As Integer
        Dim XSelect As LibX.Data.XSelecStmt
        Dim SelectStmt As String
        Try
            SelectStmt = String.Concat("Select taxable from ivitemm", _
                                     " where item_code = '", Producto.Trim, "'")

            Taxable = LibX.Data.Manager.GetScalar(SelectStmt)

            If Taxable = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False

        End Try
    End Function
    Public Function PagaItbisDos(ByVal Producto As String, ByVal Almacen As Integer) As Integer
        Dim Taxable2 As Integer
        Dim XSelect As LibX.Data.XSelecStmt
        Dim SelectStmt As String
        Try
            SelectStmt = String.Concat("Select taxable2 from ivitemd", _
                                     " where item_code = '", Producto.Trim, "' and whse_code = " & Almacen.ToString)

            Taxable2 = LibX.Data.Manager.GetScalar(SelectStmt)

            Return Taxable2

        Catch ex As Exception
            Return False

        End Try
    End Function
    Public Function AplicadDscto(ByVal Producto As String) As Boolean
        Dim AplicaDscto As Integer
        Dim XSelect As LibX.Data.XSelecStmt
        Dim SelectStmt As String
        Try
            SelectStmt = String.Concat("Select aplica_dscnt from ivitemd", _
                                     " where item_code = '", Producto.Trim, "'")

            AplicaDscto = LibX.Data.Manager.GetScalar(SelectStmt)

            If AplicaDscto = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False

        End Try
    End Function
    Public Function PctdDscto(ByVal Producto As String) As Decimal
        Dim PctDsct As Decimal
        Dim SelectStmt As String
        Try
            SelectStmt = String.Concat("Select disc_pct from ivitemd", _
                                     " where item_code = '", Producto.Trim, "'")

            PctDsct = LibX.Data.Manager.GetScalar(SelectStmt)

            If PctDsct > 0 Then
                Return PctDsct
            Else
                Return 0
            End If

        Catch ex As Exception
            Return False

        End Try
    End Function
    Public Function PctdDsctoLineal(ByVal Producto As String) As Decimal
        Dim PctDsct As Decimal
        Dim SelectStmt As String
        Try
            SelectStmt = String.Concat("Select porc_isc from ivitemd", _
                                     " where item_code = '", Producto.Trim, "'")

            PctDsct = LibX.Data.Manager.GetScalar(SelectStmt)

            If PctDsct > 0 Then
                Return PctDsct
            Else
                Return 0
            End If

        Catch ex As Exception
            Return False

        End Try
    End Function
    Public Function GetBeneficio(ByVal Producto As String, ByVal Almacen As Integer) As Decimal
        Dim Benef As Decimal
        Dim XSelect As LibX.Data.XSelecStmt
        Dim SelectStmt As String
        Try
            SelectStmt = String.Concat("Select benef from ivitemd", _
                                     " where item_code = '", Producto.Trim, "'", _
                                     "   and whse_code = ", Almacen.ToString)

            Benef = LibX.Data.Manager.GetScalar(SelectStmt)

            If Benef <= 0 Then
                Benef = SGT.Inventario.Common.Configuration.GetBenef
            End If

            Return Benef

        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function GetNextCode(ByVal IDGroup As Integer) As String
        Dim SelectStmt As String
        Dim NewCode As String
        Dim CodiGo As String
        Dim iLastNumber As Integer
        Dim xUpdateStmt As LibX.Data.XUpdateStmt
        Dim oRow As DataRow

        SelectStmt = "select last_number from ivgroupm " & _
                     " where group_code = " & IDGroup.ToString

        iLastNumber = LibX.Data.Manager.GetScalar(SelectStmt)
goto_next:
        iLastNumber = iLastNumber + 1

        xUpdateStmt = New LibX.Data.XUpdateStmt("ivgroupm")
        xUpdateStmt.FieldsSet("last_number") = iLastNumber
        xUpdateStmt.Fields("group_code") = IDGroup
        xUpdateStmt.Execute()

        NewCode = Format(IDGroup, "00") & Format(iLastNumber, "0000")

        xUpdateStmt = Nothing
        SelectStmt = "select item_code from ivitemm where item_code = '" & NewCode & "'"
        CodiGo = LibX.Data.Manager.GetScalar(SelectStmt)

        If Len(CodiGo) >= 6 Then
            GoTo goto_next
        End If

        Return NewCode

    End Function

    Public Function GetCosto(ByVal Producto As String, ByVal UnidadMedida As String, ByVal Almacen As String) As Decimal
        Dim Costo As Decimal
        Dim factor As Integer
        Dim oUnidad As UnidadMedida
        Dim XSelect As LibX.Data.XSelecStmt
        Dim SelectStmt As String
        Try
            oUnidad = New UnidadMedida
            factor = oUnidad.GetFactor(Producto, UnidadMedida)

            SelectStmt = String.Concat("Select purch_cost from ivitemd", _
                                     " where item_code = '", Producto.Trim, "'", _
                                     "   and whse_code = ", Almacen.ToString)

            Costo = LibX.Data.Manager.GetScalar(SelectStmt)

            Costo = Costo * factor
            Return Costo

        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function GetCostoRD(ByVal Producto As String, ByVal Almacen As Integer) As Decimal
        Dim Benef As Decimal
        Dim XSelect As LibX.Data.XSelecStmt
        Dim SelectStmt As String
        Try
            SelectStmt = String.Concat("Select purch_cost*tasa from ivitemv", _
                                     " where item_code = '", Producto.Trim, "'", _
                                     "   and whse_code = ", Almacen.ToString)

            Benef = LibX.Data.Manager.GetScalar(SelectStmt)

            If Benef <= 0 Then
                Benef = -1
            End If

            Return Benef

        Catch ex As Exception
            Return -1
        End Try
    End Function


    Public Function GetVencimiento(ByVal Producto As String) As String
        Dim oRow As DataRow
        Dim SelectStmt As String

        SelectStmt = "select mes,ano from ivvcmted where item_code = '" & Producto.Trim & "' and existencia <> 0 "

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If Not oRow Is Nothing Then
            SelectStmt = oRow!mes.ToString.Trim & "/" & oRow!ano.ToString.Trim
        Else
            SelectStmt = ""
        End If

        Return SelectStmt
    End Function

    Public Function CerrarInventario(ByVal FechaCierre As DateTime)
        Dim xSelect As LibX.Data.XSelecStmt
        Dim oTable As DataTable
        Dim xInsert As LibX.Data.XInsertStmt

        Try

            xSelect = New LibX.Data.XSelecStmt("ivcierrm")
            xSelect.Parameters.Add("cierr_date", FechaCierre)

            oTable = xSelect.GetTable

            xSelect.Dispose()

            If oTable.Rows.Count > 0 Then
                Exit Function
                'Throw New ApplicationException("Existe un cierre para esta fecha!")
            End If

            xSelect = New LibX.Data.XSelecStmt("ivitemd", "SELECT * FROM ivitemd WHERE existencia <> 0")

            oTable = xSelect.GetTable(False)
            xSelect.Dispose()

            xInsert = New LibX.Data.XInsertStmt("ivcierrm")
            xInsert.Fields("cierr_date") = FechaCierre

            If LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            xInsert.Fields("item_code") = ""
            xInsert.Fields("whse_code") = ""

            xInsert.Fields("onhand") = 0
            xInsert.Fields("cost") = 0
            xInsert.Fields("price") = 0

            For Each oRow As DataRow In oTable.Rows
                'Dim oNewRow As DataRow = ivcierrm.NewRow
                xInsert!item_code.value = oRow!item_code
                xInsert!whse_code.value = oRow!whse_code

                xInsert!onhand.value = oRow!existencia
                xInsert!cost.value = oRow!purch_cost
                xInsert!price.value = oRow!price

                xInsert.Execute()
            Next

            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            'If Me.Chk_Contabil.Checked = True Then
            '    ValorInvCerrado(Me.fecHasta.Value)
            'End If

        Catch ex As Exception
            LibX.Log.Add(ex)
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
        End Try

    End Function

End Class
