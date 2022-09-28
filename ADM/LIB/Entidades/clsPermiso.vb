Imports System.Windows.Forms
Public Class Permiso
    Public Shared Agregar As Integer
    Public Shared Editar As Integer
    Public Shared Borrar As Integer
    Public Shared Buscar As Integer
    Public Shared Imprimir As Integer
    Public Shared Pgrogram As String
    Public Shared UserID As Integer
    Public Shared ID As Integer

    Public Sub New(ByVal Userid As Integer, ByVal program As String)
        FillData(Userid, program)
    End Sub

    Public Function FillData(ByVal Userid As Integer, ByVal program As String)
        Dim oRow As DataRow
        Dim XSelect As LibX.Data.XSelecStmt
        Try
            XSelect = New LibX.Data.XSelecStmt("scPermsm", "select * from scPermsm where progname ='" & program & "' and userid = " & Userid)
            oRow = XSelect.GetDataRow

            If oRow Is Nothing Then
                Throw New ApplicationException("No se ha definido este tipo de documento")
            End If

            Agregar = Val(oRow!allowadd.ToString)
            Editar = Val(oRow!allowedit.ToString)
            Borrar = Val(oRow!allowdelete.ToString)
            Buscar = Val(oRow!allowquery.ToString)
            Imprimir = Val(oRow!allowprint.ToString)
            Pgrogram = Val(oRow!progname.ToString)
            Userid = Val(oRow!userid.ToString)
            ID = Val(oRow!id.ToString)

            oRow = Nothing

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Function
End Class
