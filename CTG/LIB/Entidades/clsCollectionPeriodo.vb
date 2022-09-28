Public Class CollectionPeriodo
    Inherits CollectionBase

    Public Function Add(ByVal value As Periodo) As Integer
        Return list.Add(value)
    End Function

    Public Function Add(ByVal Year As Integer, _
                        ByVal Number As Integer, _
                        ByVal FromDate As Date, _
                        ByVal ThruDate As Date, _
                        ByVal Begin As Boolean, _
                        ByVal Status As Periodo.PeriodoStatusEnum) As Integer
        Dim oItem As Periodo
        Try
            oItem = New Periodo

            oItem.year = Year
            oItem.Number = Number
            oItem.From = FromDate
            oItem.Thru = ThruDate
            oItem.Begin = Begin
            oItem.Status = Status

            Return list.Add(oItem)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Property Item(ByVal Index As Integer) As Periodo
        Get
            Return list.Item(Index)
        End Get
        Set(ByVal Value As Periodo)

            list.Item(Index) = Value
        End Set
    End Property
End Class
