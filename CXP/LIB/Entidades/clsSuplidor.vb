Public Class Suplidor

    Public Codigo As Integer
    Public Nombre As String
    Public Termino As String
    Public CuentaContable As String
    Public CuentaBancaria As String
    Public LimiteCredito As Decimal
    Public Balance As Decimal
    Public Rnc As String
    Public RetIbis As Decimal
    Public RetIsR As Decimal

    Sub New(ByVal pProveedor As Integer)
        Dim oRow As DataRow

        oRow = LibX.Data.Manager.GetDataRow("select * from cpprovm where prov_code = " & pProveedor.ToString.Trim)

        If oRow Is Nothing Then
            Exit Sub
        End If

        SetValue(oRow)
    End Sub

    Private Sub SetValue(ByVal oRow As DataRow)
        Codigo = Val(oRow!prov_code.ToString.Trim)
        Nombre = oRow!prov_name.ToString.Trim
        Termino = oRow!term_code.ToString.Trim
        CuentaContable = oRow!acct_no.ToString.Trim
        CuentaBancaria = oRow!cuenta_bancaria.ToString.Trim
        LimiteCredito = Val(oRow!credit_limit.ToString.Trim)
        Balance = Val(oRow!balance.ToString.Trim)
        Rnc = oRow!rnc_id.ToString.Trim
        RetIbis = Val(oRow!itbis.ToString.Trim)
        RetIsR = Val(oRow!isr.ToString.Trim)
    End Sub

End Class
