Namespace Common
    Public Class Items
        Inherits CollectionBase

        Public Function Item(ByVal index As Integer) As ItemInventory
            Return list.Item(index)
        End Function

        Public Function Add(ByVal e As ItemInventory) As Integer
            Try
                Return list.Add(e)

            Catch ex As Exception
                LibX.Log.Add(ex)
            End Try
        End Function

        Public Function Add(ByVal ItemID As String, ByVal Wh As Integer, ByVal Qty As Integer, _
                            ByVal Unidad As String, ByVal Cost As Decimal, ByVal PurchCost As Decimal, _
                            ByVal Impto As Decimal, ByVal Price As Decimal, ByVal OnHand As Integer, _
                            ByVal facTor As Decimal, Optional ByVal Beneficio As Decimal = 30.0) As Integer
            Dim sItem As String
            Dim oItem As ItemInventory
            Try

                oItem = New ItemInventory
                With oItem
                    .ItemID = ItemID
                    .Qty = Qty
                    .OnHand = OnHand
                    .Price = Price
                    .PurchCost = PurchCost
                    .Impto = Impto
                    .Cost = Cost
                    .Wh = Wh
                    .Unidad = Unidad
                    .FacTor = facTor
                    .Beneficio = Beneficio
                End With
                sItem = LibX.Data.Manager.GetScalar("select unit_code from ivunitd where item_code ='" & ItemID & "' and unit_code = '" & Unidad & "'")
                If sItem = "" Then
                    Throw New ApplicationException("Hay productos con la unidad mal definida, Revisar!")
                End If
                Return list.Add(oItem)

            Catch ex As Exception
                LibX.Log.Add(ex)
            End Try
        End Function

    End Class
End Namespace