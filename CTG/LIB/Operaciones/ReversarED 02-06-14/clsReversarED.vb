Imports SGT
Imports SGT.Contabilidad
Imports SGT.Contabilidad.Intrefaces

Public Class ReversarED
    Public Function Aplicar(ByVal p_Args As ParametrosReversarED) As Boolean
        Dim SelectStmt As String
        Dim oTable, oSucursal As DataTable
        Dim oCuenta As Entidades.Cuenta
        Dim oParamAplicar As Entidades.Cuenta.ParametrosAplicar

        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim Serial As Integer

        If p_Args.Sucursal > 0 Then
            SelectStmt = "select * from cgsucursal where suc_code = " & p_Args.Sucursal
        Else
            SelectStmt = "select * from cgsucursal"
        End If
        oSucursal = LibX.Data.Manager.GetDataTable(SelectStmt)

        For Each oRow1 As DataRow In oSucursal.Rows
            SelectStmt = String.Concat("select cgtranrd.*,perdr_num,perdr_year from cgtranrd ", _
                                       " inner join cgtranrm ", _
                                       " on cgtranrd.tranr_serial = cgtranrm.tranr_serial ", _
                                       " and cgtranrm.suc_code = " & oRow1!suc_code)

            If p_Args.Ano > 0 Then
                SelectStmt = LibX.ConcatWherePart(SelectStmt.Trim, " cgtranrm.perdr_year = " & p_Args.Ano.ToString)
            End If

            If p_Args.PeriodoNo > 0 Then
                SelectStmt = LibX.ConcatWherePart(SelectStmt.Trim, " cgtranrm.perdr_num = " & p_Args.PeriodoNo.ToString)
            End If

            If p_Args.Tipo <> "" Then
                SelectStmt = LibX.ConcatWherePart(SelectStmt.Trim, " cgtranrm.tran_type = '" & p_Args.Tipo.ToString.Trim & "'")
            End If

            If p_Args.Numero > 0 Then
                SelectStmt = LibX.ConcatWherePart(SelectStmt.Trim, " cgtranrm.tran_number = " & p_Args.Numero.ToString.Trim)
            End If

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                GoTo Next_sucursal
            End If

            If oTable.Rows.Count <= 0 Then
                GoTo Next_sucursal
            End If

            oCuenta = New Entidades.Cuenta
            oParamAplicar = New Entidades.Cuenta.ParametrosAplicar
            XUpdate = New LibX.Data.XUpdateStmt("cgtranrm")
            XUpdate.FieldsSet("tran_status") = 3 'Reversado

            For Each oRow As DataRow In oTable.Rows
                With oParamAplicar
                    .Depto = oRow!dept_code
                    .Monto = oRow!amount
                    .Origen = oRow!debit_credit
                    .NumeroCuenta = oRow!acct_no
                    .Sucursal = oRow!suc_code
                    .Periodo.year = p_Args.Ano
                    .Periodo.Number = p_Args.PeriodoNo
                    .Reversar = True
                End With

                oCuenta.ReversarMovimiento(oParamAplicar)

                If Serial > 0 And Serial <> oRow!tranr_serial Then
                    XUpdate.Fields("tranr_serial") = Serial
                    XUpdate.Execute()
                    Serial = oRow!tranr_serial
                Else
                    Serial = oRow!tranr_serial
                End If
            Next
            If Serial > 0 Then
                XUpdate.Fields("tranr_serial") = Serial
                XUpdate.Execute()
            End If
Next_sucursal:
        Next

        Return True

    End Function
End Class
