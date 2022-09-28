Imports SGT
Imports SGT.Contabilidad
Imports SGT.Contabilidad.Intrefaces
Imports SGT.Contabilidad.Entidades

Public Class GenerarEDCXC

    Private Function MarcarDocumentos(ByVal p_Args As ParametrosGenerarEDCXC, ByVal EDSerial As Integer) As Boolean
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

        SelectStmt = String.Concat("select count(*)cnt from cgtranrm where orign_code ='CXC' and perdr_year =" & Year & _
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
    Public Function Aplicar(ByVal p_Args As ParametrosGenerarEDCXC) As Boolean
        Dim oPeriodo As Periodo
        Dim oAnoFiscal As AnoFiscal
        Dim SelectStmt As String = ""
        Dim oTable, oSucursal As DataTable
        Dim oCobro As DataTable
        Dim oTableAccount As DataTable
        Dim Serial As Integer
        Dim VentasExcentas, VentasGrabadas As Decimal
        Dim VentaBruta, VentaNeta As Decimal
        Dim Monto, Impuesto As Decimal
        Dim Descuento, CxcCliente As Decimal
        Dim Efectivo, Credito, Tarjeta As Decimal
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
                SelectStmt = String.Concat(" select type_code,suc_code, sum(fact_total) fact_total,", _
                            "sum(itbis) itbis,sum(descto) descto from vw_rcbcodif ", _
                            " where vw_rcbcodif.invce_date between '", _
                            p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                            "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                            "' and type_code in('FCT','NCC','NDC','RCB','RPS')" & _
                            " and suc_code = " & oRow1!suc_code)
                '"' and type_code in('DCC','FCT','NCC','NDC','RCB','RPS','RSM')" & _
                If p_Args.Numero > 0 Then
                    SelectStmt = String.Concat(SelectStmt, " and vw_rcbcodif.fact_number ='", p_Args.Numero.ToString, "'")
                End If
                If p_Args.TipoDocumento.Trim <> "" Then
                    SelectStmt = String.Concat(SelectStmt, " and vw_rcbcodif.type_code ='", p_Args.TipoDocumento.Trim, "'")
                End If

                SelectStmt = String.Concat(SelectStmt.Trim, " group by suc_code,type_code")

                oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

                If oTable Is Nothing Then
                    'Exit Function
                    GoTo Next_Sucursal
                End If

                If oTable.Rows.Count <= 0 Then
                    'Exit Function
                    GoTo Next_Sucursal
                End If

                oGenerarED = New Operaciones.GenerarED
                oParamED = New Operaciones.ParametrosGenerarED
                oDocumento = New Entidades.Documentos
                oConf = New SGT.Inventario.Common.Configuration
                oCodif = New Entidades.Codificacion
                oAnoFiscal = New AnoFiscal
                oPeriodo = oAnoFiscal.BuscarPeriodoActual

                '// Iniciar Transaccion
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
                        'Seguro = 0.0
                    Efectivo = 0.0
                    Credito = 0.0
                    Tarjeta = 0.0
                        'NotaCredito = 0.0
                        'CostoVenta = 0.0
                        'Cxc = 0.0
                        'Devolucion = 0.0
                        'VBruta  = 0.0

                    SelectStmt = String.Concat("select type_name from ivtypem where type_code ='", oRow!type_code.Trim, "'")
                    TypeDesc = LibX.Data.Manager.GetScalar(SelectStmt)

                    SelectStmt = String.Concat(" select type_code,suc_code, sum(fact_total)as fact_total,", _
                                "sum(itbis) as itbis,sum(descto) as descto from vw_rcbcodif ", _
                                " where vw_rcbcodif.invce_date between '", _
                                p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                "' and type_code = '" & oRow!type_code & "'" & _
                                " and suc_code = " & oRow1!suc_code)

                    SelectStmt = String.Concat(SelectStmt.Trim, " group by suc_code,type_code")

                    oCobro = LibX.Data.Manager.GetDataTable(SelectStmt)

                    If oCobro.Rows.Count <= 0 Then
                        GoTo Next_Row
                    End If

                    For Each oRowv As DataRow In oCobro.Rows

                   

                        '// Calcular 
                        Impuesto = Val(oRowv!itbis.ToString)
                        Descuento = Val(oRowv!descto.ToString)
                        VentaBruta = Val(oRowv!fact_total.ToString)
                        VentaNeta = VentaBruta - Descuento + Impuesto
                        Credito = VentaBruta
                        Efectivo = VentaNeta
                        CxcCliente = VentaNeta
                        
                    Next

                    VentasGrabadas = Impuesto / (oConf.GetITBIS / 100)
                    VentasExcentas = VentaBruta - VentasGrabadas

                    With oParamED
                        .Fecha = p_Args.FechaFinal
                        .Tipo = oRow!type_code
                        .Sucursal = oRow1!suc_code
                        .Numero = 0
                        .Modulo = "CXC"
                        .Referencia = "ENTRADA DE DIARIO  " & TypeDesc.ToString.Trim & "  " & p_Args.FechaFinal.ToString("dd/MM/yyyy")
                        .Reversar = False

                        .Cuentas.Clear()

                        '// buscar la codificación correspondiente
                        oTableAccount = oCodif.BuscarPorCondicion(oRow!type_code.ToString, Entidades.Codificacion.CondicionEnum.Credito, 0, 0, "")

                        If oTableAccount.Rows.Count <= 0 Then
                            GoTo Next_Row
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

                                Case Entidades.Codificacion.OrigenValorEnum.Efectivo
                                    Monto = Efectivo

                                Case Entidades.Codificacion.OrigenValorEnum.Credito
                                    Monto = Credito

                                Case Entidades.Codificacion.OrigenValorEnum.Tarjeta
                                    Monto = Tarjeta

                                Case Entidades.Codificacion.OrigenValorEnum.CxcCliente
                                    Monto = CxcCliente

                            End Select

                            If Monto > 0 Then
                                .Cuentas.Add(oRowCodif!acct_no.ToString, 1, "", "", oRowCodif!origen, Monto)
                            End If
                        Next

                        '// Crear Entrada
                        Serial = oGenerarED.Aplicar(oParamED)

                        '// Marcar Documentos
                        ''p_Args.TipoDocumento = oRow!type_code
                        MarcarDocumentos(p_Args, Serial)

                    End With
Next_Row:
                Next
Next_Sucursal:
            Next

            '// Hacentar Transaccion
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            Return True
        Catch ex As Exception
            Throw
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
            Return False
        End Try
    End Function
End Class
