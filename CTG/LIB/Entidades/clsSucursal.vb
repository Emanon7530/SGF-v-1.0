Public Class Sucursal
    Public Codigo As Integer
    Public Nombre As String
    Public Direcion As String
    Public Telefono1 As String
    Public Telefono2 As String
    Public Rnc As Decimal
    Public UsoDefault As Decimal
    Public Compañia As Integer

    Sub New(ByVal pSucursal As Integer)
        Dim oRow As DataRow

        oRow = LibX.Data.Manager.GetDataRow("select * from cgsucursal where suc_code = " & pSucursal.ToString.Trim)

        If oRow Is Nothing Then
            Exit Sub
        End If

        SetValue(oRow)
    End Sub

    Private Sub SetValue(ByVal oRow As DataRow)

        Codigo = Val(oRow!suc_code.ToString.Trim)
        Nombre = oRow!suc_name.ToString.Trim
        Direcion = oRow!suc_dir.ToString.Trim
        Telefono1 = oRow!suc_telefono1.ToString.Trim
        Telefono2 = oRow!suc_telefono2.ToString.Trim
        Rnc = Val(oRow!suc_rnc.ToString.Trim)
        UsoDefault = Val(oRow!suc_default.ToString.Trim)
        Compañia = Val(oRow!comp_id.ToString.Trim)
    End Sub
End Class
