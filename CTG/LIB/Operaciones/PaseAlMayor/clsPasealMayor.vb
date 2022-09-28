Imports SGT.Contabilidad.Entidades

Public Class PasealMayor

    Public Enum PaseStateEnum
        Continue = 1
        Abort = 2
        SkipCurrent = 3
    End Enum
    Public Class PaseEventArgs
        Inherits EventArgs
        Public Periodo As Periodo
        Public TotalRow As Integer
        Public CurrentRowNo As Integer

        Public Row As DataRow
        Public State As PaseStateEnum
    End Class

    Public Event Procesando(ByVal e As PaseEventArgs)
    Public Event Procesado(ByVal e As PaseEventArgs)

    Public Function Aplicar(ByVal p_Args As ParametrosPase) As Boolean
        Dim i As Integer
        Dim SelectStmt As String

        Dim oTabla, oSucursal As DataTable
        Dim oCuenta As Cuenta
        Dim oMovimiento As Movimientos
        Dim oParam As Cuenta.ParametrosAplicar
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim oEventArgs As PaseEventArgs
        Try
            oEventArgs = New PaseEventArgs
            oCuenta = New Cuenta
            oParam = New Cuenta.ParametrosAplicar
            XUpdate = New LibX.Data.XUpdateStmt("cgtranrm")
            If p_Args.Sucursal > 0 Then
                SelectStmt = "select * from cgsucursal where suc_code = " & p_Args.Sucursal
            Else
                SelectStmt = "select * from cgsucursal"
            End If
            oSucursal = LibX.Data.Manager.GetDataTable(SelectStmt)

            For Each oRow1 As DataRow In oSucursal.Rows
                SelectStmt = String.Concat("select cgtranrm.suc_code,cgtranrm.perdr_year,cgtranrm.perdr_num,", _
                                           "       cgtranrd.acct_no,cgtranrd.debit_credit, ", _
                                           "       cgtranrd.amount * cgtranrd.debit_credit amount ,", _
                                           "       cgtranrd.dept_code,cgtranrm.tranr_serial ", _
                                           "  from cgtranrm inner join cgtranrd", _
                                           "    on cgtranrm.tranr_serial = cgtranrd.tranr_serial", _
                                           "   and cgtranrm.suc_code = cgtranrd.suc_code ", _
                                           " where cgtranrm.perdr_year = ", p_Args.Periodo.year.ToString, _
                                           "   and cgtranrm.perdr_num = ", p_Args.Periodo.Number.ToString, _
                                           "   and cgtranrm.tran_status in ('2','3')" & _
                                           " and cgtranrm.suc_code =" & oRow1!suc_code)

                If p_Args.Documento.Trim <> "" Then
                    SelectStmt = String.Concat(SelectStmt, " and cgtranrm.tran_type ='", p_Args.Documento.Trim, "'")
                End If

                If p_Args.Numero > 0 Then
                    SelectStmt = String.Concat(SelectStmt, " and cgtranrm.tran_number =", p_Args.Numero.ToString.Trim)
                End If

                oTabla = LibX.Data.Manager.GetDataTable(SelectStmt)

                If oTabla Is Nothing Then
                    GoTo Next_Sucursal
                End If

                i = 0
                oEventArgs.CurrentRowNo = i
                oEventArgs.TotalRow = oTabla.Rows.Count
                oEventArgs.Periodo = p_Args.Periodo
                oEventArgs.State = PaseStateEnum.Continue

                XUpdate.FieldsSet("tran_status") = 1
                XUpdate.Fields("tranr_serial") = 0

                For Each oRow As DataRow In oTabla.Rows

                    With oParam
                        .Periodo = p_Args.Periodo
                        .NumeroCuenta = oRow!acct_no.ToString
                        .Depto = Val(oRow!dept_code.ToString.Trim)
                        .Origen = Val(oRow!debit_credit.ToString.Trim)
                        .Monto = Val(oRow!amount.ToString.Trim)
                        .Sucursal = Val(oRow!suc_code)
                    End With

                    i += 1
                    oEventArgs.CurrentRowNo = i
                    oEventArgs.Row = oRow
                    RaiseEvent Procesando(oEventArgs)

                    If oEventArgs.State = PaseStateEnum.Abort Then
                        Throw New ApplicationException("Proceso abortado por el usuario")
                    End If

                    '// Aplicar movimiento a la cuenta
                    oMovimiento = New Movimientos
                    If oMovimiento.ExisteNoBalanceado(oParam.Periodo) = True Then
                        Throw New ApplicationException("Existen Entrada desbalanceada, Verifique!")
                    End If
                    oCuenta.AplicarMovimiento(oParam)

                    oEventArgs.Row = oRow
                    RaiseEvent Procesado(oEventArgs)

                    If oEventArgs.State = PaseStateEnum.Abort Then
                        Throw New ApplicationException("Proceso abortado por el usuario")
                    End If

                    '// Aplicar Entrada 
                    XUpdate.Fields("tranr_serial") = oRow!tranr_serial
                    XUpdate.Execute()
                Next
Next_Sucursal:
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Function

End Class
