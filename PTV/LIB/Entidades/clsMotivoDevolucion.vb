Public Class MotivoDevolucion
    Public Codigo As String
    Public Descripcion As String
    Public AfectaInventario As Boolean = False

    Public Sub New()

    End Sub

    Public Sub New(ByVal pCodigo As String)
        Codigo = pCodigo
        Load()

    End Sub

    Public Sub Load()
        Dim SelectStmt As String
        Dim oRow As DataRow

        SelectStmt = "select * from ftdevolt where dev_type ='" & Me.Codigo.Trim & "'"

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        SetValues(oRow)
    End Sub

    Private Sub SetValues(ByVal oRow As DataRow)
        If Not oRow Is Nothing Then
            Codigo = oRow!dev_type.ToString.Trim
            Descripcion = oRow!dev_name.ToString.Trim
            AfectaInventario = IIf(Val(oRow!afect_inv.ToString.Trim) = 1, True, False)
        End If

    End Sub
End Class
