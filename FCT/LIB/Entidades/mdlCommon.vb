
Public Module mdlCommon
    Public Sub Open_CashDrawer(ByVal Caja As String)
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim intFileNo As Integer = FreeFile()

        SelectStmt = "select * from sgfprinter where print_default = 1 and print_name ='" & Caja.Trim & "'"
        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        For Each oRow As DataRow In oTable.Rows
            FileOpen(1, "c:\escapes.txt", OpenMode.Output)
            PrintLine(1, Chr(oRow!char1.trim) & oRow!mode.trim & Chr(oRow!char2.trim) & Chr(oRow!char3.trim) & Chr(oRow!char4.trim))
            FileClose(1)
            Shell("print /" & oRow!print_dev.trim & " c:\escapes.txt", AppWinStyle.Hide)

            'FileOpen(1, "c:\escapes.txt", OpenMode.Output)
            'PrintLine(1, Chr(27) & "p" & Chr(0) & Chr(25) & Chr(250))
            'FileClose(1)
            'Shell("print /d:lpt1 c:\escapes.txt", AppWinStyle.Hide)
        Next
    End Sub
End Module
