Public Enum TipoCalculoEnum
    PorMaximoMinimo
    PorEstadisticas
End Enum

Public Class ParametrosCalcularPromedio
    Public Producto As String
    Public FechaInicio As Date
    Public Periodo As Integer
End Class

Public Class ParametrosCalcularSugerencia
    Public Producto As String
    Public FechaInicio As Date
    Public Periodo As Integer
    Public TipoCalculo As TipoCalculoEnum
End Class