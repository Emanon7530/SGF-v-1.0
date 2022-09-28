Public Class NumeroRepetido
    Public Function NumberExiste(ByVal typeCode As String, ByVal suPlidor As Integer, ByVal docNumber As String) As Boolean
        Dim nUmber As String
        Dim SelectStmt As String
        Try
            SelectStmt = "select doc_no from cpinvcem " & _
                        " where type_code = '" & typeCode.Trim & "' and prov_code = " & suPlidor.ToString.Trim & _
                        " and doc_no = '" & docNumber & "'"

            nUmber = LibX.Data.Manager.GetScalar(SelectStmt)
            If Val(nUmber) > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return -1
        End Try
    End Function
End Class
