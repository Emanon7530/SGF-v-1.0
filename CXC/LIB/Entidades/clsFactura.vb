Public Class Factura
    Public Serial As Long
    Public TipoDocumento As String
    Public Numero As Integer
    Public Fecha As Date
    Public Monto As Decimal
    Public Descuento As Decimal
    Public Impuesto As Decimal
    Public Cliente As Integer
    Public Termino As String
    Public NCF As String

    Public Function GetBalance() As Decimal
        Dim SelectStmt As String
        Dim Balance As Decimal

        SelectStmt = "select cast(balance as Decimal) from ccopend inner join ccinvcem " & _
                     " on ccopend.invce_serial = ccinvcem.invce_serial " & _
                     " where ccinvcem.type_code = '" & Me.TipoDocumento.Trim & "'" & _
                     "   and ccinvcem.invce_no = " & Me.Numero.ToString.Trim


        Balance = LibX.Data.Manager.GetScalar(SelectStmt)

        Return Balance

    End Function
End Class

Public Class CollectionFacturas
    Inherits CollectionBase

    Public Function Add(ByVal value As Factura) As Integer
        Return list.Add(value)
    End Function

    Public Function Add(ByVal Serial As Int16, ByVal TipoDocumento As String, ByVal Numero As Int16, ByVal Fecha As Date, _
    ByVal Monto As Decimal, ByVal Descuento As Decimal, ByVal Impuesto As Decimal, ByVal Cliente As Int16, ByVal Termino As String) As Integer

        Try
            Dim oFactura As New Factura

            With oFactura
                .Numero = Numero
                .Cliente = Cliente
                .Descuento = Descuento
                .Fecha = Fecha
                .Impuesto = Impuesto
                .Monto = Monto
                .Serial = Serial
                .TipoDocumento = TipoDocumento
                .Termino = Termino
            End With

            Return list.Add(oFactura)

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
End Class