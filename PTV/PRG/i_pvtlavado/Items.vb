Namespace Common
    Public Class Items
        Inherits CollectionBase
        Public Function Item(ByVal index As Integer) As ItemDetail
            Return List.Item(index)
        End Function
        Public Function Addindex(ByVal Index As Integer, ByVal name As String) As Integer
            Dim oItem As controlIndex
            Try
                oItem = New controlIndex
                With oItem
                    .ControlIndex = Index
                    .Nombre = name
                End With

                Return List.Add(oItem)

            Catch ex As Exception
                Return Nothing
                MsgBox(ex.ToString)
            End Try
        End Function
        'Public Function Add(ByVal e As ItemDetail) As Integer
        '    Try
        '        Return List.Add(e)

        '    Catch ex As Exception
        '        Return Nothing
        '        MsgBox(ex.ToString)
        '    End Try
        'End Function

        Public Function AddDatail(ByVal oItem As ItemDetail) As Integer
            Try
                Return List.Add(oItem)

            Catch ex As Exception
                Return Nothing
                MsgBox(ex.ToString)
            End Try
        End Function
    End Class
End Namespace

