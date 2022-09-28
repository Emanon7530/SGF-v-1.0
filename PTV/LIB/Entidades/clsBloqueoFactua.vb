Public Class BloqueoFactua

    Public Function BloquearDocumento(ByVal eSerial As Integer, ByVal eTypecode As String) As Integer
        Dim XInsert As LibX.Data.XInsertStmt
        Dim sSerial As Integer
        Try
            XInsert = New LibX.Data.XInsertStmt("ftbloqueo")
            XInsert.Fields("ftserial_no") = eSerial
            XInsert.Fields("type_code") = eTypecode
            XInsert.Execute()

        Catch ex As Exception

        End Try

    End Function
    Public Function BuscarBloqueo(ByVal eSerial As Integer, ByVal eTypecode As String) As Integer
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim Estatus As Integer

        Try

            SelectStmt = "select count(*) ftserial_no from ftbloqueo " & _
                 " where ftserial_no = " & eSerial & " and type_code ='" & eTypecode & "'"

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If Not oTable Is Nothing _
            AndAlso oTable.Rows.Count > 0 Then
                Estatus = oTable.Rows(0)!ftserial_no
            End If

            '// Si el estatus es > 0 esta en pantalla de cobro, de lo contrario se puede modificar
            If Estatus > 0 Then '//bloqueado
                Return True
            Else
                Return False '// libre
            End If

        Catch ex As Exception

        End Try

    End Function
    Public Function BorrarBloqueo(ByVal eSerial As Integer, ByVal eTypecode As String) As Integer
        Dim SelectStmt As String
        Try

            SelectStmt = "delete ftbloqueo " & _
                 " where ftserial_no = " & eSerial & " and type_code ='" & eTypecode & "'"

            LibX.Data.Manager.GetScalar(SelectStmt)

        Catch ex As Exception

        End Try

    End Function
End Class
