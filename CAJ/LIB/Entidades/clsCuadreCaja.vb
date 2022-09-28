Public Class CuadreCaja
    Public Cierre As Integer = 0

    Public Function GenerateNumberCierre(ByVal caja As Integer) As Integer
        Dim NewNumber As Integer
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim XSelect As LibX.Data.XSelecStmt
        Try

            XSelect = New LibX.Data.XSelecStmt("cjcajam", "select no_cierre from cjcajam")
            XSelect.Parameters.Add("caja_code", caja)

            Cierre = Val(XSelect.GetScalar().ToString)

            XUpdate = New LibX.Data.XUpdateStmt("cjcajam")
            NewNumber = Cierre + 1

            XUpdate.FieldsSet("no_cierre") = NewNumber
            XUpdate.Fields("caja_code") = caja

            XUpdate.Execute()
            XUpdate.Dispose()
            XSelect.Dispose()

            Return NewNumber

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return -1
        Finally

        End Try
    End Function
    
End Class
