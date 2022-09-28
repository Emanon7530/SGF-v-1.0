Public Class EntradaFinal
    Public Function Generar(ByVal p_Args As ParametrosEntradaFinal) As Boolean
        Dim SelectStmt As String
        Dim CuentaUtilidades As String
        Dim CuentaUtilidadesAnterior As String
        Dim MontoDebito As Decimal
        Dim MontoCredito As Decimal
        Dim BceUtilAnt As Decimal
        Dim BceUtilAct As Decimal
        Dim OrigenAnt As Integer
        Dim OrigenAct As Integer
        Dim Depto As Integer
        Dim Origen As Integer

        Dim oTable, oSucursal As DataTable
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim oCuenta As Entidades.Cuenta
        Dim oPeriodo As Entidades.Periodo
        Dim oAnoFiscal As Entidades.AnoFiscal
        Dim oGenerarED As Operaciones.GenerarED
        Dim oParamED As Operaciones.ParametrosGenerarED
        Dim oConfig As Common.Configuracion

        Try

            If p_Args.Sucursal > 0 Then
                SelectStmt = "select * from cgsucursal where suc_code = " & p_Args.Sucursal
            Else
                SelectStmt = "select * from cgsucursal"
            End If
            oSucursal = LibX.Data.Manager.GetDataTable(SelectStmt)

            For Each oRow1 As DataRow In oSucursal.Rows
                '// BUSCAR LAS CUENTAS NOMINALES CON BALANCE DIFERENTE DE CERO
                SelectStmt = String.Concat("select cgacctd.*,cgacctm.acct_origen from cgacctd ", _
                                          " inner join cgacctm on ", _
                                          " cgacctm.acct_no = cgacctd.acct_no ", _
                                          " and cgacctm.acct_isctrl = 0", _
                                          " inner join cgacctpm on ", _
                                          " cgacctm.acct_type = cgacctpm.acct_type ", _
                                          " and cgacctpm.acct_nominal = 'N'", _
                                          " where cgacctd.perdr_year = ", p_Args.Year.ToString, _
                                          " and cgacctd.perdr_num = ", p_Args.Number.ToString, _
                                          " and cgacctd.balance <> 0 and cgacctd.suc_code =" & oRow1!suc_code)

                oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

                If oTable Is Nothing Then
                    GoTo Next_scursal
                End If

                oGenerarED = New Operaciones.GenerarED
                oParamED = New Operaciones.ParametrosGenerarED
                oAnoFiscal = New Entidades.AnoFiscal
                oConfig = New Common.Configuracion(p_Args.Year, p_Args.Number)
                XUpdate = New LibX.Data.XUpdateStmt("cgperdrm")
                oCuenta = New Entidades.Cuenta

                '''If oAnoFiscal.ExistenPeriodosAbiertos(p_Args.Year) = True Then
                '''    Throw New ApplicationException("Debe cerrar todos los periodos antes!")
                '''End If

                oCuenta.Buscar(oConfig.CuentaUtilidadesAntieriores, p_Args.Number, p_Args.Year)
                BceUtilAnt = oCuenta.Balance
                OrigenAnt = oCuenta.Origen

                oCuenta.Buscar(oConfig.CuentaUtilidades, p_Args.Number, p_Args.Year)
                BceUtilAct = oCuenta.Balance
                OrigenAct = oCuenta.Origen

                oPeriodo = oAnoFiscal.BuscarAnoFiscal

                With oParamED
                    .Fecha = p_Args.Fecha
                    .Numero = p_Args.DocumentoNumero
                    .Tipo = p_Args.TipoDocumento
                    .Sucursal = oRow1!suc_code
                    .Modulo = "CTG"
                    .Referencia = p_Args.Referencia
                    .Reversar = False

                    .Cuentas.Clear()
                    .Cuentas.Add(oConfig.CuentaUtilidadesAntieriores, oCuenta.Depto, "Transferir Utilidades Año Anterior", "", OrigenAct, BceUtilAct)
                    .Cuentas.Add(oConfig.CuentaUtilidades, oCuenta.Depto, "Transferir Utilidades Año Anterior", "", OrigenAct * -1, BceUtilAct)

                    For Each oRow As DataRow In oTable.Rows
                        Origen = oRow!acct_origen * -1
                        Depto = Val(oRow!dept_code.ToString.Trim)
                        .Cuentas.Add(oRow!acct_no, oRow!dept_code, "", "", Origen, Val(oRow!balance.ToString.Trim))

                        If Origen = 1 Then
                            MontoDebito += Val(oRow!balance.ToString.Trim)
                        Else
                            MontoCredito += Val(oRow!balance.ToString.Trim)
                        End If
                    Next

                    CuentaUtilidades = oConfig.CuentaUtilidades

                    If MontoDebito <> 0 Then
                        .Cuentas.Add(CuentaUtilidades, Depto, "", "", -1, MontoDebito)
                    End If

                    If MontoCredito <> 0 Then
                        .Cuentas.Add(CuentaUtilidades, Depto, "", "", 1, MontoCredito)
                    End If

                    If LibX.Data.Manager.Connection.IsIntransaction = False Then
                        LibX.Data.Manager.Connection.BeginTransaction()
                    End If
                    oGenerarED.Aplicar(oParamED)
                End With

                If LibX.Data.Manager.Connection.IsIntransaction = True Then
                    LibX.Data.Manager.Connection.CommitTransaction()
                End If
Next_scursal:
            Next
            Return True

        Catch ex As Exception
            LibX.Log.Show(ex)
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
        End Try
    End Function

End Class
