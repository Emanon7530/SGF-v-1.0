Public Class Transaccion
    Public Enum TipoFormaPagoEnum
        Efectivo = 1
        Tarjeta
        Cheque
        NC
        CXC
        Seguro
        Estafeta
    End Enum

    Public Class FormaPago
        Public Tipo As TipoFormaPagoEnum
        Public Monto As Decimal
        Public Referencia As String = ""
        Public Banco As Integer
        Public Fecha As Date
        Public Aditional As Object
    End Class

    Public Class CollectionFormaPago
        Inherits CollectionBase

        Public Function Add(ByVal value As FormaPago) As Int16
            Return list.Add(value)
        End Function

        Public Function Add(ByVal Tipo As TipoFormaPagoEnum, ByVal monto As Decimal, ByVal Referencia As String, ByVal Banco As Integer, ByVal Fecha As Date, ByVal Aditional As Object) As Integer
            Dim oForma As FormaPago
            Try
                oForma = New FormaPago

                With oForma
                    .Tipo = Tipo
                    .Banco = Banco
                    .Monto = monto
                    .Referencia = Referencia
                    .Fecha = Fecha
                    .Aditional = Aditional
                End With

                Return list.Add(oForma)
            Catch ex As Exception
                LibX.Log.Add(ex)
            End Try
        End Function

        Public Function Remove(ByVal value As FormaPago) As Boolean
            Try
                list.Remove(value)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

        Default Public Property Item(ByVal Index As Integer) As FormaPago
            Get
                Return list.Item(Index)
            End Get
            Set(ByVal Value As FormaPago)
                list.Item(Index) = Value
            End Set
        End Property
    End Class

End Class
