Public Class Almacen
    Public Shared Function GetDefault() As Integer
        Dim SelectStmt As String
        Dim oRow As DataRow
        Try
            SelectStmt = "select * from ivwhsem where whse_default = 1"
            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Return -1
            End If

            Return oRow!whse_code

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return -1
        End Try
    End Function
End Class
