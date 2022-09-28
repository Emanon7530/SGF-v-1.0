Public Class Ivbloqueo
    Public Function BloquearDocumento(ByVal eSerial As Integer, ByVal eTypecode As String) As Integer
        Dim XInsert As LibX.Data.XInsertStmt
        Dim sSerial As Integer

        XInsert = New LibX.Data.XInsertStmt("ivbloqueo")
        XInsert.Fields("ftserial_no") = eSerial
        XInsert.Fields("type_code") = eTypecode
        XInsert.Execute()
    End Function
    Public Function BuscarBloqueo(ByVal eSerial As Integer, ByVal eTypecode As String) As Integer
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim Estatus As Integer

        SelectStmt = "select count(*) ftserial_no from ivbloqueo " & _
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
    End Function
    Public Function BorrarBloqueo(ByVal eSerial As Integer, ByVal eTypecode As String) As Integer
        Dim SelectStmt As String

        SelectStmt = "delete ivbloqueo " & _
             " where ftserial_no = " & eSerial & " and type_code ='" & eTypecode & "'"

        LibX.Data.Manager.GetScalar(SelectStmt)

    End Function


End Class
