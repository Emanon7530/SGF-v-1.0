Imports System.Windows.Forms
Public Class Program
    Public Class RunID
        Public ProgID As Integer
        Public Parent As Form
        Public Modal As Boolean
    End Class
    Public Class PermissionArgs
        Public ProgramName As String
        Public UserID As String
        Public Type As PermissionTypeEnum
    End Class
    Public Class Autentication
        Public Machine As String
    End Class
    Public Class ParametrosVizualizar
        Public TipoDocumento As String
        Public Parametros As LibX.LibxPrgParams
    End Class

    Public Enum PermissionTypeEnum
        AccessProgram = 1
        Permission = 2
    End Enum

    Public Class ParametroRunning
        Public Caja As Integer
        Public Cajera As Integer
        Public Fecha As DateTime
        Public Program As String
        Public Machine As String
        Public UserName As String
    End Class

    Public Function BuildAutentication(ByVal e As Autentication) As Boolean
        Dim SelectStmt As String
        Dim oMachine As String
        Try
            SelectStmt = "select machine_name from xtmachine where machine_name ='" & e.Machine & "'"
            oMachine = LibX.Data.Manager.GetScalar(SelectStmt)

            If oMachine Is Nothing Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
    Public Function BuildMenu(ByVal e As Windows.Forms.MenuItem)
        Dim SelectStmt As String
        Dim oProg As DataTable
        Try

            SelectStmt = "select * from stmenue"
            oProg = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oProg Is Nothing Then
                Throw New ApplicationException("No existe este sistema definido")
            End If

            For Each oRow As DataRow In oProg.Rows
                Dim mItem As Windows.Forms.MenuItem = e.MenuItems.Add(oRow!descr)
                LoadSubitem(mItem, oRow!menu_code)
            Next

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Function
    Private Sub LoadSubitem(ByVal e As MenuItem, ByVal ID As Int16)
        Dim oTable As DataTable
        Dim SelectStmt As String
        Try

            SelectStmt = "select * from stmenud where menu_code = " & ID.ToString
            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Throw New ApplicationException("No existe este sistema definido")
            End If

            For Each oRow As DataRow In oTable.Rows
                Dim mItem As MenuItem = e.MenuItems.Add(oRow!descr)

                LoadSubitem2(mItem, oRow!progid)
            Next
        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub
    Private Sub LoadSubitem2(ByVal e As MenuItem, ByVal ID As Int16)
        Dim oTable As DataTable
        Dim SelectStmt As String
        Try

            SelectStmt = "select * from stmenud where progid = " & ID.ToString
            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Throw New ApplicationException("No existe este sistema definido")
            End If

            For Each oRow As DataRow In oTable.Rows
                Dim mItem As MenuItem = e.MenuItems.Add(oRow!descr)

                LoadSubitem2(mItem, oRow!progid)
            Next
        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub

    Public Function HasPermission(ByVal e As PermissionArgs) As Boolean
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim UserID As Integer
        Try

            If e.UserID.ToLower = "UserAdmin".ToLower Then
                Return True
            End If

            SelectStmt = String.Concat("select * from scpermsm ", _
                                       " where userid = ", e.UserID.ToString, _
                                       "   and progname = '", e.ProgramName.Trim & "'")

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Return False
            End If

            If oTable.Rows.Count <= 0 Then
                Return False
            End If

            Return True

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False

        End Try
    End Function

    Public Function isRunning(ByVal e As ParametroRunning) As Boolean
        Dim SelectStmt As String
        Dim Running As Integer
        Try

            SelectStmt = "select count(*) from xtcontrol " & _
                         " where caja_code = " & e.Caja.ToString.Trim & _
                         "   and caje_code = " & e.Cajera.ToString.Trim & _
                         "   and control_machine = '" & e.Machine & "'" & _
                         "   and fecha = '" & e.Fecha.ToString(LibX.Data.Manager.GetSaveDateFormat) & "'"

            Running = LibX.Data.Manager.GetScalar(SelectStmt)

            If Running > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function

    Public Function ProgramRunning(ByVal e As ParametroRunning) As Integer
        Dim SelectStmt As String
        Dim isRunning As Object
        Dim XInsert As LibX.Data.XInsertStmt
        Try

            SelectStmt = "select control_serial from xtcontrol " & _
                         " where caja_code = " & e.Caja.ToString.Trim & _
                         "   and caje_code = " & e.Cajera.ToString.Trim & _
                         "   and control_machine = '" & e.Machine & "'" & _
                         "   and fecha = '" & e.Fecha.ToString(LibX.Data.Manager.GetSaveDateFormat) & "'"

            isRunning = LibX.Data.Manager.GetScalar(SelectStmt)

            If isRunning Is DBNull.Value Then
                isRunning = 0
            End If

            If isRunning Is Nothing Then
                isRunning = 0
            End If

            If isRunning <= 0 Then
                XInsert = New LibX.Data.XInsertStmt("xtcontrol", "control_serial")
                XInsert.Fields("caja_code") = e.Caja
                XInsert.Fields("caje_code") = e.Cajera
                XInsert.Fields("fecha") = e.Fecha
                XInsert.Fields("control_program") = e.Program
                XInsert.Fields("control_machine") = e.Machine
                XInsert.Fields("control_open") = LibX.Data.Manager.Connection.GetDate
                XInsert.Fields("control_username") = e.UserName

                isRunning = XInsert.Execute()
            Else
                isRunning = -1
            End If

            Return isRunning

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function

    Public Function ProgramStopping(ByVal e As ParametroRunning) As Boolean
        Dim SelectStmt As String
        Dim oTAble As DataTable
        Dim isRunning As Integer
        Dim XDelete As LibX.Data.XDeleteStmt
        Try
            XDelete = New LibX.Data.XDeleteStmt("xtcontrol")
            XDelete.Fields("caja_code") = e.Caja
            XDelete.Fields("caje_code") = e.Cajera
            XDelete.Fields("fecha") = e.Fecha
            XDelete.Fields("control_machine") = e.Machine

            XDelete.Execute()

            SelectStmt = "select * from ftbloqueo "
            oTAble = LibX.Data.Manager.GetDataTable(SelectStmt)
            If oTAble.Rows.Count > 0 Then
                For Each orow As DataRow In oTAble.Rows
                    XDelete = New LibX.Data.XDeleteStmt("ftbloqueo")
                    XDelete.Fields("ftserial_no") = orow!ftserial_no
                    XDelete.Execute()
                Next
            End If

            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function

    Public Function RunOption(ByVal e As RunID) As String
        Dim oRowProg As DataRow
        Dim SelectStmt As String
        Dim PathProg As String
        Try

            SelectStmt = String.Concat("select * from stmenud ", " where progid = ", e.ProgID.ToString)
            oRowProg = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRowProg Is Nothing Then
                Throw New ApplicationException("No existe opción con este ID")
            End If

            PathProg = oRowProg!path '& "\" & oRowProg!program & ".exe"

            LibX.App.MainMdi = e.Parent
            LibX.LibXRunner.RunWithPath(PathProg, e.Modal)

            Return oRowProg!program.ToString

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return ""

        End Try
    End Function

    Public Function Visualizar(ByVal p_Args As ParametrosVizualizar) As Boolean
        Dim SelectStmt As String
        Dim oRow As DataRow
        Try

            SelectStmt = "select program,menu_modulo " & _
                         "from ivtypem inner join stmenud " & _
                         "on ivtypem.progid = stmenud.progid " & _
                         "inner join stmenue on stmenue.menu_code = stmenud.menu_code " & _
                         "where type_code = '" & p_Args.TipoDocumento.Trim & "'"

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If Not oRow Is Nothing Then
                If Not LibX.IsNull(oRow!program) AndAlso Not LibX.IsNull(oRow!menu_modulo) Then
                    LibX.App.CurrentPrgParams = p_Args.Parametros
                    LibX.LibXRunner.Run(oRow!program.ToString, oRow!menu_modulo.ToString)
                End If
            End If

            Return True

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Function

End Class
