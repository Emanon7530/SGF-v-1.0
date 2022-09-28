Public Class CollectionCuentas
    Inherits CollectionBase

    Public Function Add(ByVal value As Cuenta) As String
        list.Add(value)
    End Function

    Public Function Add(ByVal NumeroCuenta As String, ByVal Depto As Integer, ByVal nombre As String, ByVal Control As String, ByVal Origen As Integer, ByVal Monto As Decimal) As String
        Dim oItem As Cuenta
        Try

            oItem = New Cuenta

            oItem.NumeroCuenta = NumeroCuenta
            oItem.Depto = Depto
            oItem.Nombre = nombre
            oItem.Origen = Origen
            oItem.Control = Control
            oItem.Monto = Monto

            Return list.Add(oItem)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Property Item(ByVal index As String) As Cuenta
        Get
            Return list.Item(index)
        End Get
        Set(ByVal Value As Cuenta)

            list.Item(index) = Value
        End Set
    End Property


End Class
