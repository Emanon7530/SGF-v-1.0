Public Class Recibo
    Public Serial As Long
    Public TipoDocumento As String
    Public Numero As Integer
    Public Fecha As Date
    Public Monto As Decimal
    Public Cliente As Integer
    Public Facturas As New CollectionFacturas
End Class

Public Class FacturaPagada
    Public Serial As Integer
    Public MontoAplicado As Decimal
End Class
Public Class CollectionFacturaPagadas
    Inherits CollectionBase

    Public Function Add(ByVal value As FacturaPagada) As Integer
        Return list.Add(value)
    End Function

    Public Function add(ByVal Serial As Integer, ByVal MontoAplicado As Decimal) As Integer
        Dim oFactura As FacturaPagada
        Try
            oFactura = New FacturaPagada

            With oFactura
                .Serial = Serial
                .MontoAplicado = MontoAplicado
            End With

            Return list.Add(oFactura)
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function

End Class
Public Class CollectionRecibos
    Inherits CollectionBase

    Public Function Add(ByVal value As Factura) As Integer
        Return list.Add(value)
    End Function

    Public Function Add(ByVal Serial As Int16, ByVal TipoDocumento As String, ByVal Numero As Int16, ByVal Fecha As Date, _
    ByVal Monto As Decimal, ByVal Cliente As Int16, ByVal Facturas As CollectionFacturas) As Integer

        Try
            Dim oRecibo As New Recibo

            With oRecibo
                .Numero = Numero
                .Cliente = Cliente
                .Fecha = Fecha
                .Monto = Monto
                .Serial = Serial
                .TipoDocumento = TipoDocumento
                .Facturas = Facturas
            End With

            Return list.Add(oRecibo)

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
End Class