Imports SGT
Imports SGT.Contabilidad
Imports SGT.Contabilidad.Intrefaces

Public Class GenerarEDFCT

    Private Function MarcarDocumentos(ByVal p_Args As ParametrosGenerarEDFCT, ByVal EDSerial As Integer) As Boolean
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
    Public Function Aplicar(ByVal p_Args As ParametrosGenerarEDFCT) As Boolean
        Dim SelectStmt As String = ""
        Dim oTable, oSucursal As DataTable
        Dim oTableAccount As DataTable
        Dim oRows() As DataRow
        Dim Serial As Integer
        Dim oCobro As DataTable
        Dim VentasExcentas, VentasGrabadas As Decimal
        Dim VentaBruta, VentaNeta, VBruta As Decimal
        Dim Monto, Impuesto, Seguro As Decimal
        Dim Descuento As Decimal
        Dim Efectivo As Decimal
        Dim Tarjeta, Credito As Decimal
        Dim CostoVenta As Decimal
        Dim Inventario As Decimal
        Dim NotaCredito As Decimal
        Dim Devolucion As Decimal
        Dim Cxc As Decimal
        Dim TypeDesc As String

        Dim oGenerarED As Operaciones.GenerarED
        Dim oParamED As Operaciones.ParametrosGenerarED
        Dim oDocumento As Entidades.Documentos
        Dim oConf As SGT.Inventario.Common.Configuration
        Dim oCodif As Entidades.Codificacion

        Try

            If IsDate(p_Args.FechaInicial) = False Then
                Throw New ApplicationException("Especifique la fecha de inicio de movimientos!")
            End If

            If IsDate(p_Args.FechaFinal) = False Then
                Throw New ApplicationException("Especifique la fecha final de movimientos!")
            End If

            If p_Args.Sucursal > 0 Then
                SelectStmt = "select * from cgsucursal where suc_code = " & p_Args.Sucursal
            Else
                SelectStmt = "select * from cgsucursal"
            End If

            oSucursal = LibX.Data.Manager.GetDataTable(SelectStmt)

            For Each oRow1 As DataRow In oSucursal.Rows
                'SelectStmt = String.Concat("select vw_ftcodif.type_code,vw_ftcodif.suc_code, sum(vw_ftcodif.fact_total)fact_total,sum(vw_ftcodif.itbis)itbis,sum(vw_ftcodif.descto)descto,", _
                '                           " sum(vw_ftcodif.seg_amount)seg_amount,sum(vw1_ftcodif.fact_costo)fact_costo ", _
                '                            "from vw_ftcodif,vw1_ftcodif  where vw_ftcodif.fact_date between '", _
                '                            p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                '                            "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                '                            "' and vw_ftcodif.pay_method in ('EFE','CHK','CXC','NC','TAR','SEG') and vw_ftcodif.suc_code = " & oRow1!suc_code, _
                '" and vw_ftcodif.ftserial_no = vw1_ftcodif.ftserial_no ")

                SelectStmt = String.Concat("select vw_ftcodif.type_code,vw_ftcodif.suc_code ", _
                                            "from vw_ftcodif where vw_ftcodif.fact_date between '", _
                                            p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                            "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                            "'  and vw_ftcodif.suc_code = " & oRow1!suc_code)


                If p_Args.Numero > 0 Then
                    SelectStmt = String.Concat(SelectStmt, " and vw_ftcodif.fact_number ='", p_Args.Numero.ToString, "'")
                End If
                If p_Args.TipoDocumento.Trim <> "" Then
                    SelectStmt = String.Concat(SelectStmt.Trim, " and vw_ftcodif.type_code = '" & p_Args.TipoDocumento.Trim, "'")
                End If

                SelectStmt = String.Concat(SelectStmt.Trim, " group by vw_ftcodif.type_code,vw_ftcodif.suc_code")

                oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

                If oTable Is Nothing Then
                    GoTo Next_Sucursal
                End If

                If oTable.Rows.Count <= 0 Then
                    GoTo Next_Sucursal
                End If

                oGenerarED = New Operaciones.GenerarED
                oParamED = New Operaciones.ParametrosGenerarED
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
                    CostoVenta = 0.0
                    Inventario = 0.0
                    Cxc = 0.0
                    Devolucion = 0.0
                    VBruta  = 0.0

                    '// Calcular 
                    SelectStmt = String.Concat("select type_name from ivtypem where type_code ='", oRow!type_code, "'")
                    TypeDesc = LibX.Data.Manager.GetScalar(SelectStmt)

                    'If oRow!type_code <> "RCB" Then
                    If oRow!type_code = ("FPV") Or oRow!type_code = ("FSG") Or oRow!type_code = ("DEV") Then
                        SelectStmt = String.Concat("select vw_ftcodif.type_code,vw_ftcodif.suc_code,vw_ftcodif.pay_method, sum(vw_ftcodif.fact_total)fact_total,sum(vw_ftcodif.itbis)itbis,", _
                                             " sum(vw_ftcodif.descto)descto,sum(vw_ftcodif.seg_amount)seg_amount,sum(vw1_ftcodif.fact_costo)fact_costo from vw_ftcodif,vw1_ftcodif ", _
                                            " where vw_ftcodif.fact_date between '", _
                                            p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                            "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                            "' and vw_ftcodif.pay_method in ('EFE','CHK','CXC','NC','TAR','SEG') and vw_ftcodif.suc_code = " & oRow1!suc_code, _
                                            " and vw_ftcodif.type_code = '" & oRow!type_code, "' and vw_ftcodif.ftserial_no = vw1_ftcodif.ftserial_no ")

                        If p_Args.Numero > 0 Then
                            SelectStmt = String.Concat(SelectStmt, " and vw_ftcodif.fact_number ='", p_Args.Numero.ToString, "'")
                        End If
                        SelectStmt = String.Concat(SelectStmt.Trim, " group by vw_ftcodif.type_code,vw_ftcodif.suc_code,vw_ftcodif.pay_method ")

                    Else
                        'SelectStmt = String.Concat("select vw_ftcodif.type_code,vw_ftcodif.suc_code,vw_ftcodif.pay_method, sum(vw_ftcodif.fact_total)fact_total,sum(vw_ftcodif.itbis)itbis,", _
                        '                                             " sum(vw_ftcodif.descto)descto,sum(vw_ftcodif.seg_amount)seg_amount,sum(vw1_ftcodif.fact_costo)fact_costo from vw_rcbcodif,vw1_ftcodif ", _
                        '                                            " where vw_ftcodif.fact_date between '", _
                        '                                            p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                        '                                            "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                        '                                            "' and vw_ftcodif.pay_method in ('EFE','CHK','CXC','NC','TAR','SEG') and vw_ftcodif.suc_code = " & oRow1!suc_code, _
                        '                                            " and vw_ftcodif.type_code = '" & oRow!type_code, "' and vw_ftcodif.ftserial_no = vw1_ftcodif.ftserial_no ")

                        SelectStmt = String.Concat("select vw_ftcodif.type_code,vw_ftcodif.suc_code,vw_ftcodif.pay_method, sum(vw_ftcodif.fact_total)fact_total,sum(vw_ftcodif.itbis)itbis,", _
                                                                                            " sum(vw_ftcodif.descto)descto,sum(vw_ftcodif.seg_amount)seg_amount,sum(vw_ftcodif.seg_amount)fact_costo from vw_ftcodif ", _
                                                                                           " where vw_ftcodif.fact_date between '", _
                                                                                           p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                                                                           "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                                                                           "' and vw_ftcodif.pay_method in ('EFE','CHK','CXC','NC','TAR','SEG') and vw_ftcodif.suc_code = " & oRow1!suc_code, _
                                                                                           " and vw_ftcodif.type_code = '" & oRow!type_code, "'")

                        If p_Args.Numero > 0 Then
                            SelectStmt = String.Concat(SelectStmt, " and vw_ftcodif.fact_number ='", p_Args.Numero.ToString, "'")
                        End If

                        SelectStmt = String.Concat(SelectStmt.Trim, " group by vw_ftcodif.type_code,vw_ftcodif.suc_code,vw_ftcodif.pay_method ")

                    End If

                    oCobro = LibX.Data.Manager.GetDataTable(SelectStmt)


                    If oCobro.Rows.Count > 0 Then
                        Descuento = Descuento + Val(Val(oCobro.Rows(0)!descto))
                        Impuesto = Impuesto + Val(oCobro.Rows(0)!itbis)
                        CostoVenta = CostoVenta + Val(oCobro.Rows(0)!fact_costo)
                        Inventario = CostoVenta
                    End If

                    For Each oRowv As DataRow In oCobro.Rows

                        Select Case oRowv!pay_method
                            Case "EFE"
                                VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString) '+ Val(oRowv!descto.ToString) - Val(oRowv!itbis.ToString)
                                Efectivo = Efectivo + Val(oRowv!fact_total.ToString)
                                'If oRow!type_code = "RCB" Then
                                '    Efectivo = Efectivo + Val(oRowv!fact_total.ToString) - Val(oRowv!descto.ToString)
                                'Else
                                '    Efectivo = Efectivo + Val(oRowv!fact_total.ToString)
                                'End If

                            Case "CXC"
                                VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString) '+ Val(oRowv!descto.ToString) - Val(oRowv!itbis.ToString)
                                Credito = Val(oRowv!fact_total.ToString)
                                'If oRow!type_code <> "RCB" Then
                                '    VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString) '+ Val(oRowv!descto.ToString) - Val(oRowv!itbis.ToString)
                                '    'Descuento = Descuento + Val(oRowv!descto.ToString)
                                '    'Impuesto = Impuesto + Val(oRowv!itbis.ToString)
                                '    Credito = Val(oRowv!fact_total.ToString)
                                'End If
                            Case "TAR"
                                VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString) '+ Val(oRowv!descto.ToString) - Val(oRowv!itbis.ToString)
                                Tarjeta = Tarjeta + Val(oRowv!fact_total.ToString)
                                'Descuento = Descuento + Val(oRowv!descto.ToString)
                                'Impuesto = Impuesto + Val(oRowv!itbis.ToString)

                                'If oRow!type_code = "RCB" Then
                                '    ''Tarjeta = Val(oRowv!fact_total.ToString)
                                '    Efectivo = Efectivo + Val(oRowv!fact_total.ToString) - Val(oRowv!descto.ToString)
                                'Else
                                '    ''Tarjeta = Val(oRowv!fact_total.ToString)
                                '    Tarjeta = Tarjeta + Val(oRowv!fact_total.ToString)
                                'End If

                            Case "NC "
                                VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString)
                                NotaCredito = Val(oRowv!fact_total.ToString)
                                'If oRow!type_code <> "DEV" Then
                                '    ''VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString) + Val(oRowv!descto.ToString) - Val(oRowv!itbis.ToString)
                                '    ''Descuento = Descuento + Val(oRowv!descto.ToString)
                                '    VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString) ''- Val(oRowv!itbis.ToString)
                                'Else
                                '    VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString) + Val(oRowv!descto.ToString) - Val(oRowv!itbis.ToString)
                                '    Descuento = Descuento + Val(oRowv!descto.ToString)
                                '    Impuesto = Impuesto + Val(oRowv!itbis.ToString)
                                'End If
                                'VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString) '+ Val(oRowv!descto.ToString) - Val(oRowv!itbis.ToString)
                                'Descuento = Descuento + Val(oRowv!descto.ToString)
                                'Impuesto = Impuesto + Val(oRowv!itbis.ToString)

                                'If oRow!type_code = "RCB" Then
                                '    NotaCredito = Val(oRowv!fact_total.ToString) ''- Val(oRowv!descto.ToString)
                                'Else
                                '    NotaCredito = Val(oRowv!fact_total.ToString) ''- Val(oRowv!descto.ToString)
                                '    Devolucion = Val(oRowv!fact_total.ToString)
                                'End If

                            Case "SEG"
                                VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString) '+ Val(oRowv!descto.ToString) - Val(oRowv!itbis.ToString)
                                Seguro = Val(oRowv!fact_total.ToString)
                                'Descuento = Descuento + Val(oRowv!descto.ToString)
                                'Impuesto = Impuesto + Val(oRowv!itbis.ToString)

                                'If oRow!type_code = "RCB" Then
                                '    Seguro = Val(oRowv!fact_total.ToString) - Val(oRowv!descto.ToString)
                                'Else
                                '    Seguro = Val(oRowv!fact_total.ToString)
                                'End If

                            Case "CHK"
                                VentaBruta = VentaBruta + Val(oRowv!fact_total.ToString) '+ Val(oRowv!descto.ToString) - Val(oRowv!itbis.ToString)
                                Efectivo = Efectivo + Val(oRowv!fact_total.ToString)
                                'Descuento = Descuento + Val(oRowv!descto.ToString)
                                'Impuesto = Impuesto + Val(oRowv!itbis.ToString)

                                'If oRow!type_code = "RCB" Then
                                '    Efectivo = Efectivo + Val(oRowv!fact_total.ToString) - Val(oRowv!descto.ToString)
                                'Else
                                '    Efectivo = Efectivo + Val(oRowv!fact_total.ToString)
                                'End If
                        End Select
                        If oRow!type_code = "RCB" Then
                            'Credito = Credito + Val(oRowv!fact_total.ToString)
                            Credito = VentaBruta
                        End If
                        'CostoVenta = CostoVenta + Val(oRowv!fact_costo.ToString)
                    Next


                    If oRow!type_code = ("FPV") Or oRow!type_code = ("FSG") Or oRow!type_code = ("DEV") Then
                        Cxc = Credito - Descuento
                    Else
                        Cxc = Credito + Descuento
                    End If

                    VBruta = VentaBruta + Descuento - Impuesto
                    VentaNeta = Format(VBruta - Descuento + Impuesto, "###,###,##0.00")
                    VentasGrabadas = Format(Impuesto / (oConf.GetITBIS / 100), "###,###,##0.00")
                    VentasExcentas = Format(VBruta - VentasGrabadas, "###,###,##0.00")

                    With oParamED
                        .Fecha = p_Args.FechaFinal
                        .Tipo = oRow!type_code
                        .Sucursal = oRow1!suc_code
                        '.Numero = oDocumento.GetNextNumber(oRow!type_code)
                        .Numero = 0
                        .Modulo = "FCT"
                        .Referencia = "ENTRADA DE DIARIO " & TypeDesc.ToString.Trim & p_Args.FechaFinal.ToString("dd/MM/yyyy")
                        .Reversar = False

                        .Cuentas.Clear()

                        '// buscar la codificación correspondiente
                        oTableAccount = oCodif.BuscarPorCondicion(oRow!type_code.ToString, Entidades.Codificacion.CondicionEnum.Contado, 0, 0, "")

                        If oTableAccount.Rows.Count <= 0 Then
                            GoTo Next_Doc
                        End If

                        'Dim m_factd As DataTable

                        For Each oRowCodif As DataRow In oTableAccount.Rows

                            'm_factd = LibX.Data.Manager.GetDataTable("select itbis, dscto from ")


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

                                Case Entidades.Codificacion.OrigenValorEnum.CxcCliente
                                    Monto = Cxc
                                Case Entidades.Codificacion.OrigenValorEnum.Tarjeta
                                    Monto = Tarjeta

                                Case Entidades.Codificacion.OrigenValorEnum.NotaCredito
                                    Monto = NotaCredito

                                Case Entidades.Codificacion.OrigenValorEnum.Devolucion
                                    Monto = Devolucion

                                Case Entidades.Codificacion.OrigenValorEnum.CostoVenta
                                    Monto = CostoVenta

                                    ''Case Entidades.Codificacion.OrigenValorEnum.Inventario
                                    ''  Monto = Inventario

                            End Select

                            If Monto > 0 Then
                                .Cuentas.Add(oRowCodif!acct_no.ToString, 1, "", "", oRowCodif!origen, Monto)
                            End If
                        Next

                        Serial = oGenerarED.Aplicar(oParamED)
                    End With

                    '// Marcar Documentos
                    p_Args.TipoDocumento = oRow!type_code
                    MarcarDocumentos(p_Args, Serial)
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
