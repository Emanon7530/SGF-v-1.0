Imports SGT
Imports SGT.Contabilidad
Imports SGT.Contabilidad.Intrefaces
Imports SGT.PuntoVenta.Operaciones.Codificacion

Public Class CodifVTA
    Private Function MarcarDocumentos(ByVal p_Args As ParametrosCodifVTA, ByVal EDSerial As Integer) As Boolean
    End Function
    Public Function Reversar(ByVal TranSerial As Integer) As Boolean
        Dim DeleteStmt As String
        Try

            If LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            DeleteStmt = "delete cgtranrd where tranr_serial =" & TranSerial
            LibX.Data.Manager.ExecuteNonQuery(DeleteStmt)

            DeleteStmt = "delete cgtranrm where tranr_serial =" & TranSerial
            LibX.Data.Manager.ExecuteNonQuery(DeleteStmt)

            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            Return True
        Catch ex As Exception
            Throw
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
        End Try
    End Function
    Public Function Buscar(ByVal TipoDoc As String, ByVal Sucursal As Integer, ByVal Year As String, ByVal Month As String) As Boolean
        Dim SelectStmt As String = ""
        Dim oCnt As Integer


        SelectStmt = String.Concat("select count(*)cnt from cgtranrm where orign_code ='FCT' and perdr_year =" & Year & _
                                   " and perdr_num = " & Month)
        If TipoDoc <> "" Then
            SelectStmt = String.Concat(SelectStmt, " and cgtranrm.tran_type = '" & TipoDoc & "'")
        End If
        If Sucursal > 0 Then
            SelectStmt = String.Concat(SelectStmt, " and cgtranrm.suc_code = " & Sucursal)
        End If

        oCnt = LibX.Data.Manager.GetScalar(SelectStmt)

        If oCnt > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function Aplicar(ByVal p_Args As ParametrosCodifVTA) As Boolean
        Dim SelectStmt As String = ""
        Dim oTable, oSucursal As DataTable
        Dim oTableAccount As DataTable
        Dim oRows() As DataRow
        Dim Serial As Integer
        Dim oCobro As DataTable
        Dim VentasExcentas, VentasGrabadas As Decimal
        Dim VentaBruta, VentaNeta As Decimal
        Dim Monto, Impuesto, Seguro As Decimal
        Dim Descuento As Decimal
        Dim Efectivo As Decimal
        Dim Tarjeta, Credito As Decimal
        Dim NotaCredito As Decimal
        Dim TypeDesc As String

        Dim oGenerarED As Operaciones.Codificacion.GenerarED
        Dim oParamED As Operaciones.Codificacion.ParametrosGenerarCODIF
        Dim oDocumento As Entidades.Documentos
        Dim oConf As SGT.Inventario.Common.Configuration
        Dim oCodif As Entidades.Codificacion

        Try

            If p_Args.Sucursal > 0 Then
                SelectStmt = "select * from cgsucursal where suc_code = " & p_Args.Sucursal
            Else
                SelectStmt = "select * from cgsucursal"
            End If

            oSucursal = LibX.Data.Manager.GetDataTable(SelectStmt)

            For Each oRow1 As DataRow In oSucursal.Rows

                SelectStmt = String.Concat("select type_code,ftfactm.suc_code,sum(amount) fact_total,", _
                              "sum(itbis) itbis,sum(descto) descto, sum(seg_amount) seg_amount from ftfactm, cjtranrm", _
                              " where ftfactm.fact_date = '", _
                              p_Args.Fecha.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                              "' and ftfactm.fact_status = 2 and ftfactm.fact_cond in(1,2,3)", _
                              " and ftfactm.caja_code = " & p_Args.Caja, _
                              " and ftfactm.caje_code = " & p_Args.Cajera, _
                              " and cjtranrm.ftserial_no = ftfactm.ftserial_no " & _
                              " and cjtranrm.pay_method in ('EFE','CHK','CXC','NC','TAR','SEG') and ftfactm.suc_code = " & oRow1!suc_code)

                '''If p_Args.Numero > 0 Then
                '''    SelectStmt = String.Concat(SelectStmt, " and ftfactm.fact_number ='", p_Args.Numero.ToString, "'")
                '''End If
                If p_Args.Tipo.Trim <> "" Then
                    SelectStmt = String.Concat(SelectStmt.Trim, " and ftfactm.type_code = '" & p_Args.Tipo.Trim, "'")
                End If

                SelectStmt = String.Concat(SelectStmt.Trim, " group by ftfactm.suc_code,type_code ")

                oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

                If oTable Is Nothing Then
                    GoTo Next_Sucursal
                End If

                If oTable.Rows.Count <= 0 Then
                    GoTo Next_Sucursal
                End If

                oGenerarED = New Operaciones.Codificacion.GenerarED
                oParamED = New Operaciones.Codificacion.ParametrosGenerarCODIF
                oDocumento = New Entidades.Documentos
                oConf = New SGT.Inventario.Common.Configuration
                oCodif = New Entidades.Codificacion

                If LibX.Data.Manager.Connection.IsIntransaction = False Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                End If

                For Each oRow As DataRow In oTable.Rows
                    VentaNeta = 0.0
                    VentaBruta = 0.0
                    Descuento = 0.0
                    Impuesto = 0.0
                    VentasGrabadas = 0.0
                    VentasExcentas = 0.0
                    Seguro = 0.0
                    Efectivo = 0.0
                    Credito = 0.0
                    Tarjeta = 0.0
                    NotaCredito = 0.0

                    '// Calcular 
                    SelectStmt = String.Concat("select type_name from ivtypem where type_code ='", oRow!type_code, "'")
                    TypeDesc = LibX.Data.Manager.GetScalar(SelectStmt)

                    If oRow!type_code <> "RCB" Then
                        SelectStmt = String.Concat("select ftfactm.suc_code,type_code,pay_method, isnull(sum(amount),0) fact_total,", _
                                                "isnull(sum(itbis),0) itbis,isnull(sum(descto),0) descto, isnull(sum(seg_amount),0) seg_amount from ftfactm, cjtranrm", _
                                                " where ftfactm.fact_date = '", _
                                                p_Args.Fecha.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                                "' and ftfactm.caja_code =" & p_Args.Caja, _
                                                " and ftfactm.caje_code =" & p_Args.Cajera, _
                                                " and ftfactm.fact_status = 2 and ftfactm.fact_cond in(1,2,3)", _
                                                " and cjtranrm.ftserial_no = ftfactm.ftserial_no " & _
                                                " and cjtranrm.pay_method in ('EFE','CHK','CXC','NC ','TAR','SEG')" & _
                                                " and ftfactm.type_code = '" & oRow!type_code, "'and ftfactm.suc_code = " & oRow1!suc_code)

                        '''If p_Args.Numero > 0 Then
                        '''    SelectStmt = String.Concat(SelectStmt, " and ftfactm.fact_number ='", p_Args.Numero.ToString, "'")
                        '''End If

                        SelectStmt = String.Concat(SelectStmt.Trim, " group by ftfactm.suc_code,type_code,pay_method ")
                    Else
                        SelectStmt = String.Concat("select ftfactm.suc_code,ftfactm.type_code,pay_method, isnull(sum(ccpaymd.amount),0) fact_total,", _
                                    "isnull(sum(ftfactm.itbis),0) itbis,isnull(sum(disc_amount),0)descto, isnull(sum(seg_amount),0) seg_amount ", _
                                    " from ftfactm ", _
                                    " INNER JOIN cjtranrm on cjtranrm.ftserial_no = ftfactm.ftserial_no  ", _
                                    " and ftfactm.fact_date = '", _
                                    p_Args.Fecha.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                    "' and ftfactm.caja_code =" & p_Args.Caja, _
                                    " and ftfactm.caje_code =" & p_Args.Cajera, _
                                    " and ftfactm.fact_status = 2 and ftfactm.fact_cond in(1,2,3)", _
                                    " and cjtranrm.ftserial_no = ftfactm.ftserial_no " & _
                                    " and cjtranrm.pay_method in ('EFE','CHK','CXC','NC ','TAR','SEG') " & _
                                    " and ftfactm.type_code = '" & oRow!type_code, "'" & _
                                    " LEFT OUTER JOIN ccpaymd on ccpaymd.paym_serial = ftfactm.ftserial_no" & _
                                    " where ftfactm.suc_code = " & oRow1!suc_code)

                        '''If p_Args.Numero > 0 Then
                        '''    SelectStmt = String.Concat(SelectStmt, " and ftfactm.fact_number ='", p_Args.Numero.ToString, "'")
                        '''End If

                        SelectStmt = String.Concat(SelectStmt.Trim, " group by ftfactm.suc_code,ftfactm.type_code,pay_method ")

                        SelectStmt = String.Concat(SelectStmt.Trim, " union ", _
                                     " select top 1 ftfactm.suc_code, ftfactm.type_code,'CXC' pay_method,0 fact_total,0 itbis,", _
                                     " 0 descto, 0 seg_amount from ftfactm  ", _
                                     " where ftfactm.fact_date = '", _
                                     p_Args.Fecha.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                     "' and ftfactm.caja_code =" & p_Args.Caja, _
                                     " and ftfactm.caje_code =" & p_Args.Cajera, _
                                     " and ftfactm.type_code = '" & oRow!type_code, "' and ftfactm.suc_code = " & oRow1!suc_code)
                    End If

                    SelectStmt = String.Concat(SelectStmt.Trim, " order by ftfactm.suc_code,ftfactm.type_code,pay_method desc ")
                    oCobro = LibX.Data.Manager.GetDataTable(SelectStmt)

                    For Each oRowv As DataRow In oCobro.Rows

                        Select Case oRowv!pay_method
                            Case "EFE"
                                VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString) + Val(oRowv!descto.ToString) - Val(oRowv!itbis.ToString)
                                Descuento = Descuento + Val(oRowv!descto.ToString)
                                Impuesto = Impuesto + Val(oRowv!itbis.ToString)
                                If oRow!type_code = "RCB" Then
                                    Efectivo = Efectivo + Val(oRowv!fact_total.ToString)
                                Else
                                    Efectivo = Efectivo + Val(oRowv!fact_total.ToString)
                                End If
                            Case "CXC"
                                If oRow!type_code <> "RCB" Then
                                    VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString) + Val(oRowv!descto.ToString) - Val(oRowv!itbis.ToString)
                                    Descuento = Descuento + Val(oRowv!descto.ToString)
                                    Impuesto = Impuesto + Val(oRowv!itbis.ToString)
                                    Credito = Val(oRowv!fact_total.ToString)
                                End If
                            Case "TAR"
                                VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString) + Val(oRowv!descto.ToString) - Val(oRowv!itbis.ToString)
                                Descuento = Descuento + Val(oRowv!descto.ToString)
                                Impuesto = Impuesto + Val(oRowv!itbis.ToString)

                                If oRow!type_code = "RCB" Then
                                    Tarjeta = Val(oRowv!fact_total.ToString)
                                Else
                                    Tarjeta = Val(oRowv!fact_total.ToString)
                                End If

                            Case "NC "
                                If oRow!type_code <> "DEV" Then
                                    VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString)
                                Else
                                    VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString) + Val(oRowv!descto.ToString) - Val(oRowv!itbis.ToString)
                                    Descuento = Descuento + Val(oRowv!descto.ToString)
                                    Impuesto = Impuesto + Val(oRowv!itbis.ToString)
                                End If

                                If oRow!type_code = "RCB" Then
                                    NotaCredito = Val(oRowv!fact_total.ToString)
                                Else
                                    NotaCredito = Val(oRowv!fact_total.ToString)
                                End If

                            Case "SEG"
                                VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString) + Val(oRowv!descto.ToString) - Val(oRowv!itbis.ToString)
                                Descuento = Descuento + Val(oRowv!descto.ToString)
                                Impuesto = Impuesto + Val(oRowv!itbis.ToString)

                                If oRow!type_code = "RCB" Then
                                    Seguro = Val(oRowv!fact_total.ToString)
                                Else
                                    Seguro = Val(oRowv!fact_total.ToString)
                                End If

                            Case "CHK"
                                VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString) + Val(oRowv!descto.ToString) - Val(oRowv!itbis.ToString)
                                Descuento = Descuento + Val(oRowv!descto.ToString)
                                Impuesto = Impuesto + Val(oRowv!itbis.ToString)

                                If oRow!type_code = "RCB" Then
                                    Efectivo = Efectivo + Val(oRowv!fact_total.ToString)
                                Else
                                    Efectivo = Efectivo + Val(oRowv!fact_total.ToString)
                                End If

                        End Select
                        If oRow!type_code = "RCB" Then
                            Credito = Credito + Val(oRowv!fact_total.ToString) + Val(oRowv!descto.ToString)
                        End If
                        p_Args.Tipo = oRow!type_code
                    Next

                    VentaNeta = Format(VentaBruta - Descuento + Impuesto, "###,###,##0.00")
                    VentasGrabadas = Format(Impuesto / (oConf.GetITBIS / 100), "###,###,##0.00")
                    VentasExcentas = Format(VentaBruta - VentasGrabadas, "###,###,##0.00")

                    With oParamED
                        .Tipo = oRow!type_code
                        .Numero = 0
                        .Caja = p_Args.Caja
                        .Cajera = p_Args.Cajera
                        .Fecha = p_Args.Fecha
                        .Sucursal = oRow1!suc_code
                        .Cuentas.Clear()

                        '// buscar la codificación correspondiente
                        oTableAccount = oCodif.BuscarPorCondicion(oRow!type_code.ToString, Entidades.Codificacion.CondicionEnum.Contado, 0, 0, "")

                        If oTableAccount.Rows.Count <= 0 Then
                            GoTo Next_Doc
                        End If

                        For Each oRowCodif As DataRow In oTableAccount.Rows
                            Select Case Val(oRowCodif!orig_valor.ToString)
                                Case Entidades.Codificacion.OrigenValorEnum.MontoNeto
                                    Monto = VentaNeta

                                Case Entidades.Codificacion.OrigenValorEnum.MontoBruto
                                    Monto = VentaBruta

                                Case Entidades.Codificacion.OrigenValorEnum.Descuento
                                    Monto = Descuento

                                Case Entidades.Codificacion.OrigenValorEnum.Impuesto
                                    Monto = Impuesto

                                Case Entidades.Codificacion.OrigenValorEnum.MontoGrabado
                                    Monto = VentasGrabadas

                                Case Entidades.Codificacion.OrigenValorEnum.MontoExcento
                                    Monto = VentasExcentas

                                Case Entidades.Codificacion.OrigenValorEnum.MontoSeguro
                                    Monto = Seguro

                                Case Entidades.Codificacion.OrigenValorEnum.Efectivo
                                    Monto = Efectivo

                                Case Entidades.Codificacion.OrigenValorEnum.Credito
                                    Monto = Credito

                                Case Entidades.Codificacion.OrigenValorEnum.Tarjeta
                                    Monto = Tarjeta

                                Case Entidades.Codificacion.OrigenValorEnum.NotaCredito
                                    Monto = NotaCredito

                            End Select

                            If Monto > 0 Then
                                .Cuentas.Add(oRowCodif!acct_no.ToString, 1, "", "", oRowCodif!origen, Monto)
                            End If
                        Next

                        Serial = oGenerarED.Aplicar(oParamED)
                    End With

                    '// Marcar Documentos
                    p_Args.Tipo = oRow!type_code
                    '''MarcarDocumentos(p_Args, Serial)
Next_Doc:
                Next
Next_Sucursal:
            Next

            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            Return True
        Catch ex As Exception
            Throw
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
        End Try

    End Function
End Class
