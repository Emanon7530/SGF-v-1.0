Public Class Cuenta
    Public NumeroCuenta As String
    Public Depto As Integer
    Public Nombre As String
    Public Control As String
    Public Origen As Integer
    Public Monto As Decimal

    Public BalanceInicial As Decimal
    Public Debitos As Decimal
    Public Creditos As Decimal
    Public Balance As Decimal
    Public Sucursal As Integer

    Public Class ParametrosAplicar
        Public Periodo As New Periodo
        Public NumeroCuenta As String
        Public Depto As Integer
        Public Monto As Decimal
        Public Origen As Integer
        Public Reversar As Boolean = False
        Public Sucursal As Integer
        Public Secuencia As Integer
    End Class

    Dim SelectStmt As String
    Public Function Buscar(ByVal pacct_no As String, ByVal psucursal As Integer, Optional ByVal pperdr_num As Integer = -1, Optional ByVal pperdr_year As Integer = -1) As Boolean
        Dim SelectStmt As String
        Dim oRow As DataRow

        SelectStmt = "select * from cgacctm " & _
                     " where acct_no = '" & pacct_no.Trim & "'"

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oRow Is Nothing Then
            Return False
        End If

        Me.NumeroCuenta = oRow!acct_no.ToString.Trim
        Me.Nombre = oRow!acct_name.ToString.Trim
        Me.Control = oRow!acct_contrl.ToString.Trim
        Me.Origen = oRow!acct_origen.ToString.Trim

        If pperdr_num > 0 Then
            Me.BuscarBalance(pacct_no, pperdr_num, pperdr_year, psucursal)
        End If
    End Function
    Public Function BuscarBalance(ByVal pacct_no As String, ByVal pperdr_num As Integer, ByVal pperdr_year As Integer, ByVal psucursal As Integer) As Boolean
        Dim SelectStmt As String
        Dim oRow As DataRow

        SelectStmt = "Select * from cgacctd " & _
                    " where acct_no = '" & pacct_no.Trim & "'" & _
                    "   and perdr_num  = " & pperdr_num.ToString & _
                    "   and perdr_year = " & pperdr_year.ToString & _
                    " and suc_code = " & psucursal

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oRow Is Nothing Then
            Return False
        End If

        Me.Depto = oRow!dept_code.ToString
        Me.BalanceInicial = Val(oRow!initial.ToString.Trim)
        Me.Debitos = Val(oRow!debit_amount.ToString.Trim)
        Me.Creditos = Val(oRow!credit_amount.ToString.Trim)
        Me.Balance = Val(oRow!balance.ToString.Trim)
        Me.Sucursal = oRow!suc_code

        Return True
    End Function
    Public Function AplicarMovimiento(ByVal p_Args As ParametrosAplicar) As String
        Dim SelectStmt As String
        Dim oRow As DataRow
        Dim oTablec As DataTable
        Dim Debito As Decimal
        Dim Credito As Decimal
        Dim Balance As Decimal
        Dim Acum As Decimal
        Dim Inicial As Decimal
        Dim xInsert As LibX.Data.XInsertStmt
        Dim MontoNeto As Decimal
        Try

            SelectStmt = String.Concat("Select acct_origen,acct_contrl from cgacctm ", _
                                       " where acct_no = '", p_Args.NumeroCuenta.Trim, "'")

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Throw New ApplicationException("No se encontro esta cuenta")
            End If

            SelectStmt = String.Concat("Select * from cgacctd ", _
                                       " where acct_no = '", p_Args.NumeroCuenta.Trim, "'", _
                                       "   and perdr_year = ", p_Args.Periodo.year.ToString, _
                                       "   and perdr_num = ", p_Args.Periodo.Number.ToString)
            If p_Args.Sucursal > 0 Then
                SelectStmt = String.Concat(SelectStmt, " and suc_code =" & p_Args.Sucursal)
            End If

            oTablec = LibX.Data.Manager.GetDataTable(SelectStmt, "cgacctd", True)

            If oTablec.Rows.Count = 0 Then
                '// Si no existe insertar este balance
                xInsert = New LibX.Data.XInsertStmt("cgacctd")

                xInsert!perdr_year = p_Args.Periodo.year
                xInsert!perdr_num = p_Args.Periodo.Number
                xInsert!acct_no = p_Args.NumeroCuenta
                xInsert!dept_code = p_Args.Depto
                xInsert!suc_code = p_Args.Sucursal

                If p_Args.Origen = 1 Then
                    xInsert!debit_amount = p_Args.Monto
                Else
                    If p_Args.Monto < 0 Then
                        p_Args.Monto = p_Args.Monto * -1
                    End If
                    xInsert!credit_amount = p_Args.Monto
                End If

                If p_Args.Origen.ToString <> oRow!acct_origen.ToString Then
                    xInsert!balance = p_Args.Monto * p_Args.Origen
                Else
                    xInsert!balance = p_Args.Monto * p_Args.Origen
                End If

                xInsert!balance_acum = p_Args.Monto * p_Args.Origen

                xInsert.Execute()
                xInsert.Dispose()
            Else
                If p_Args.Origen = 1 Then
                    If Not LibX.IsNull(oTablec.Rows(0)!debit_amount) Then Debito = oTablec.Rows(0)!debit_amount Else Debito = 0
                    oTablec.Rows(0)!debit_amount = Debito + p_Args.Monto
                Else
                    If Not LibX.IsNull(oTablec.Rows(0)!credit_amount) Then Credito = oTablec.Rows(0)!credit_amount Else Credito = 0
                    oTablec.Rows(0)!credit_amount = Credito + p_Args.Monto
                End If
                If Not LibX.IsNull(oTablec.Rows(0)!initial) Then Inicial = oTablec.Rows(0)!initial Else Inicial = 0
                If Not LibX.IsNull(oTablec.Rows(0)!debit_amount) Then Debito = oTablec.Rows(0)!debit_amount Else Debito = 0
                If Not LibX.IsNull(oTablec.Rows(0)!credit_amount) Then Credito = oTablec.Rows(0)!credit_amount Else Credito = 0
                If Not LibX.IsNull(oTablec.Rows(0)!balance) Then Balance = oTablec.Rows(0)!balance Else Balance = 0
                If Not LibX.IsNull(oTablec.Rows(0)!balance_acum) Then Acum = oTablec.Rows(0)!balance_acum Else Acum = 0

                Acum = Inicial + (Debito - Credito)
                Balance = Debito - Credito

                oTablec.Rows(0)!balance = Balance
                oTablec.Rows(0)!balance_acum = Acum

                LibX.Data.Manager.Save(oTablec)
                End If

            If oRow!acct_contrl.ToString.Trim <> "" Then
                Return oRow!acct_contrl
            Else
                Return String.Empty
            End If

        Catch ex As Exception
            Return False
            LibX.Log.Show(ex)
        End Try
    End Function

    Public Function ReversarMovimiento(ByVal p_Args As ParametrosAplicar) As String
        Dim SelectStmt As String
        Dim oRow As DataRow
        Dim oRow1 As DataRow
        Dim oTable As DataTable
        Dim xInsert As LibX.Data.XInsertStmt
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim xEdelete As LibX.Data.XDeleteStmt
        Dim mInitial As Decimal
        Dim MontoNeto As Decimal
        Try

            ''SelectStmt = String.Concat("Select acct_origen,acct_contrl from cgacctm ", _
            ''                           " where acct_no = '", p_Args.NumeroCuenta.Trim, "'")

            ''oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            ''If oRow Is Nothing Then
            ''    Throw New ApplicationException("No se encontro esta cuenta")
            ''End If

            SelectStmt = String.Concat("Select cgacctd.*,acct_contrl,acct_origen from cgacctd ", _
                                               " inner join cgacctm on cgacctm.acct_no = cgacctd.acct_no ", _
                                               " where perdr_year = ", p_Args.Periodo.year.ToString, _
                                               "   and perdr_num = ", p_Args.Periodo.Number.ToString, _
                                               " and cgacctd.acct_no = '", p_Args.NumeroCuenta.Trim, "'")
            If p_Args.Sucursal > 0 Then
                SelectStmt = String.Concat(SelectStmt, " and suc_code =" & p_Args.Sucursal)
            End If

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt, "cgacctd", True)

            If oTable Is Nothing Then
                Return String.Empty
            End If
            If Not LibX.IsNull(oTable.Rows(0)!initial) Then mInitial = oTable.Rows(0)!initial Else mInitial = 0
            ''// REVERSAR MOVIMIENTOS
            If mInitial = 0 Then
                xEdelete = New LibX.Data.XDeleteStmt("cgacctd")
                xEdelete.Fields("perdr_year") = oTable.Rows(0)!perdr_year
                xEdelete.Fields("perdr_num") = oTable.Rows(0)!perdr_num
                xEdelete.Fields("acct_no") = oTable.Rows(0)!acct_no
                xEdelete.Execute()
            Else
                ''xUpdate = New LibX.Data.XUpdateStmt("cgacctd")
                ''xUpdate.FieldsSet("balance_acum") = oRow1!initial
                ''xUpdate.FieldsSet("debit_amount") = 0
                ''xUpdate.FieldsSet("credit_amount") = 0
                ''xUpdate.FieldsSet("balance") = 0

                ''xUpdate.Fields("perdr_year") = oRow1!perdr_year
                ''xUpdate.Fields("debit_amount") = 0
                ''xUpdate.Fields("acct_no") = oRow1!acct_no
                ''xUpdate.Execute()

                oTable.Rows(0)!balance_acum = oTable.Rows(0)!initial
                oTable.Rows(0)!credit_amount = 0
                oTable.Rows(0)!debit_amount = 0
                oTable.Rows(0)!balance = 0

                LibX.Data.Manager.Save(oTable)
            End If

            If oTable.Rows(0)!acct_contrl.ToString.Trim <> "" Then
                Return oTable.Rows(0)!acct_contrl
            Else
                Return String.Empty
            End If

        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
