Public Class CierreFiscal
    Public Function Cierre(ByVal p_Args As ParametrosCierre) As Boolean
        Dim SelectStmt As String
        Dim oTable, oSucursal As DataTable
        Dim oAnoFiscal As Entidades.AnoFiscal
        Dim oParametroIniciar As Entidades.AnoFiscal.ParametrosIniciar
        Dim oParametroProximo As Entidades.AnoFiscal.ParametrosCalcularPeriodo

        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim XInsert As LibX.Data.XInsertStmt
        Dim oPeriodo As Entidades.Periodo
    
        '//
        oAnoFiscal = New Entidades.AnoFiscal
        oParametroProximo = New Entidades.AnoFiscal.ParametrosCalcularPeriodo
        oParametroIniciar = New Entidades.AnoFiscal.ParametrosIniciar
        XInsert = New LibX.Data.XInsertStmt("cgacctd")

        '// Buscar los datos del periodo actual
        oPeriodo = oAnoFiscal.BuscarAnoFiscal

        '// Cacular el proximo ano fiscal
        With oParametroProximo
            .AnoFiscal = p_Args.Year
            .FechaInicio = oPeriodo.From
            .FechaFinal = oPeriodo.Thru
        End With

        oAnoFiscal.CalcularProximo(oParametroProximo)

        '// Buscar los balances de la cuentas reales
        If p_Args.Sucursal > 0 Then
            SelectStmt = "select * from cgsucursal where suc_code = " & p_Args.Sucursal
        Else
            SelectStmt = "select * from cgsucursal"
        End If

        oSucursal = LibX.Data.Manager.GetDataTable(SelectStmt)

        For Each oRow1 As DataRow In oSucursal.Rows
            SelectStmt = "select cgacctd .*,cgacctm.acct_name,cgacctm.acct_origen, " & _
                         " cgacctm.acct_contrl,cgacctm.acct_nivel,cgacctm.acct_isctrl,cgacctpm.* " & _
                         " from cgacctd  inner join cgacctm on cgacctm.acct_no = cgacctd.acct_no " & _
                         " inner join cgacctpm " & _
                         " on cgacctm.acct_type = cgacctpm.acct_type " & _
                         " and cgacctpm.acct_nominal = 'R'" & _
                         " where perdr_num = {0} " & _
                         "   and perdr_year = {1} and cgacctd.suc_code =" & oRow1!suc_code

            SelectStmt = String.Format(SelectStmt.Trim, p_Args.Number.ToString, p_Args.Year.ToString)

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                GoTo next_Sucursal
            End If

            If oTable.Rows.Count <= 0 Then
                GoTo next_Sucursal
            End If

            '// Iniciar los balances de las cuentas
            XInsert.Fields("acct_no") = ""
            'XInsert.Fields("perdr_num") = 1
            XInsert.Fields("perdr_num") = 13
            'XInsert.Fields("perdr_year") = oParametroIniciar.Year
            XInsert.Fields("perdr_year") = p_Args.Year
            XInsert.Fields("debit_amount") = 0
            XInsert.Fields("credit_amount") = 0
            XInsert.Fields("dept_code") = 0
            XInsert.Fields("initial") = 0
            XInsert.Fields("balance") = 0

            For Each oRow As DataRow In oTable.Rows
                XInsert.Fields("acct_no") = oRow!acct_no
                XInsert.Fields("dept_code") = oRow!dept_code
                XInsert.Fields("initial") = oRow!balance
                XInsert.Fields("balance") = oRow!balance
                XInsert.Fields("suc_code") = oRow!suc_code

                XInsert.Execute()
            Next

            '// CERRAR PERIODO ACTUAL
            XUpdate.FieldsSet("perdr_status") = 0
            XUpdate.Fields("perdr_year") = p_Args.Year
            XUpdate.Execute()
next_Sucursal:

        Next
    End Function

End Class
