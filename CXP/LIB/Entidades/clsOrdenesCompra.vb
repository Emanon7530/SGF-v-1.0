
Public Class OrdenesCompra

    Public Function estaOrdenando(ByVal Producto As String) As Boolean
        Dim Selectstmt As String
        Dim Existe As Integer

        Selectstmt = "select count(*) from cpordnm, cpordnd " & _
                     " where item_code = '" & Producto.Trim & "'" & _
                     "   and cpordnm.ordn_serial = cpordnd.ordn_serial " & _
                     "   and ordn_status in(1,2)"

        Existe = LibX.Data.Manager.GetScalar(Selectstmt)

        If Existe > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function CalcularVentaPromedio(ByVal e As ParametrosCalcularPromedio) As Decimal
        Dim FechaInicioReal As Date
        Dim VentaTotal As Decimal
        Dim VentasXDias As Decimal
        Dim TotalDias As Decimal
        Dim VentaPromedio As Decimal
        Dim SelectStmt As String

        If e.Producto = "" Then
            Throw New ApplicationException("Debe especificar el producto!")
        End If

        If e.Periodo <= 0 Then
            Throw New ApplicationException("Debe especificar un periodo válido!")
        End If

        FechaInicioReal = DateAdd(DateInterval.Month, -3, e.FechaInicio)

        SelectStmt = "select sum((qty*ivunitd.factor)*ivtypem.origen) " & _
                     " from ivtranrd, ivtranrm, ivunitd,ivtypem " & _
                     " where ivtranrm.trane_number = ivtranrd.trane_number " & _
                     "   and ivtranrm.doc_date between '" & FechaInicioReal.ToString("yyyy/MM/dd") & _
                     "'  and  '" & e.FechaInicio.ToString("yyyy/MM/dd") & "'" & _
                     "   and ivtranrd.item_code = '" & e.Producto.Trim & "'" & _
                     "   and ivunitd.item_code = ivtranrd.item_code " & _
                     "   and ivunitd.unit_code = ivtranrd.unit_code " & _
                     "   and ivtranrm.type_code in ('FPV','FSG','DEV')" & _
                     "   and ivtranrm.type_code=ivtypem.type_code "

        VentaTotal = Val(LibX.Data.Manager.GetScalar(SelectStmt).ToString.Trim)
        TotalDias = VentaTotal / 91.2
        VentasXDias = Decimal.Round(TotalDias, 2)

        Return VentasXDias

    End Function

    Public Function CalcularUltimaVenta(ByVal Producto As String) As Decimal
        Dim SelectStmt As String
        Dim DiasTranscurridos As decimal
        Dim FechaUltimaVenta As Object

        If Trim(Producto) = "" Then
            Throw New ApplicationException("Debe especificar el parametro Producto")
        End If

        SelectStmt = "select max(doc_date) " & _
                     " from ivtranrm ,ivtranrd " & _
                     " where ivtranrd.trane_number = ivtranrm.trane_number " & _
                     "   and ivtranrd.item_code = '" & Producto.Trim & "'" & _
                     "   and ivtranrm.type_code ('FPV',FSG','DEV')"

        FechaUltimaVenta = LibX.Data.Manager.GetScalar(SelectStmt)

        If Not FechaUltimaVenta Is DBNull.Value Then
            DiasTranscurridos = DateDiff(DateInterval.Day, CType(FechaUltimaVenta, Date), DateTime.Now)
        Else
            DiasTranscurridos = 0
        End If

        Return DiasTranscurridos
    End Function

    Public Function CalcularCantidadSugerida(ByVal e As ParametrosCalcularSugerencia) As Decimal
        Dim SelectStmt As String
        Dim Existecia As Decimal
        Dim VentasPromedios As Decimal
        Dim CantidadPeriodo As Decimal
        Dim CantidadSugerida As Decimal
        Dim oParamPromedio As New ParametrosCalcularPromedio
        Dim oRowProducto As DataRow

        If e.Producto = "" Then
            Throw New ApplicationException("Debe especificar el producto!")
        End If

        If e.Periodo <= 0 Then
            Throw New ApplicationException("Debe especificar un periodo válido!")
        End If

        SelectStmt = "select existencia,existencia_min,exitencia_max from ivitemd " & _
                     " where item_code = '" & e.Producto.Trim & "'"

        oRowProducto = LibX.Data.Manager.GetDataRow(SelectStmt)

        '// Calcular por Estadisticas
        If e.TipoCalculo = TipoCalculoEnum.PorEstadisticas Then
            oParamPromedio.Producto = e.Producto
            oParamPromedio.FechaInicio = e.FechaInicio
            oParamPromedio.Periodo = e.Periodo

            '// Calcular Ventas Promedio
            VentasPromedios = CalcularVentaPromedio(oParamPromedio)

            '// Calcular la Cantidad para cubrir el periodo
            CantidadPeriodo = VentasPromedios * e.Periodo

            '// Cantidad a Sugerir
            CantidadSugerida = CantidadPeriodo - Val(oRowProducto!existencia.ToString.Trim)

        End If

        '// Por Maximo y Minimo
        If e.TipoCalculo = TipoCalculoEnum.PorMaximoMinimo Then
            CantidadSugerida = Val(oRowProducto!exitencia_max.ToString.Trim) - Val(oRowProducto!existencia.ToString.Trim)
        End If

        '// Si la cantidad sugerida es negativa, sugerir 0
        If CantidadSugerida < 0 Then
            CantidadSugerida = 0
        End If

        Return CantidadSugerida
    End Function

End Class
