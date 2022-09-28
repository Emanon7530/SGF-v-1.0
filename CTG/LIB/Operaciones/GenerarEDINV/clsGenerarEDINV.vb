Imports SGT
Imports SGT.Contabilidad
Imports SGT.Contabilidad.Intrefaces


Public Class GenerarEDINV
    Private Function MarcarDocumentos(ByVal p_Args As ParametrosGenerarEDINV, ByVal EDSerial As Integer) As Boolean
        'Dim SelectStmt As String = ""
        'Dim oTable As DataTable
        'Dim XInsert As LibX.Data.XInsertStmt

        'SelectStmt = String.Concat("select type_code,entr_serial, entr_date  ", _
        '                           " from iventrdm ", _
        '                           " where iventrdm.entr_date between '", _
        '                           p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
        '                           "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), _
        '                           "' and iventrdm.entr_status = 1", _
        '                           " and type_code in ('CUS','CRD')", _
        '                            " and iventrdm.entr_serial not in (select doc_serial from cgdocaplm ", _
        '                            "                                     where cgdocaplm.type_code = iventrdm.type_code ", _
        '                            "                                       and cgdocaplm.origen = 'INV'" & _
        '                            "                                       and date_apply between '", _
        '                                                                    p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
        '                            "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat) & "')")


        'If p_Args.TipoDocumento.Trim <> "" Then
        '    SelectStmt = String.Concat(SelectStmt, " and iventrdm.type_code ='", p_Args.TipoDocumento.Trim, "'")
        'End If

        'If p_Args.Numero > 0 Then
        '    SelectStmt = String.Concat(SelectStmt, " and iventrdm.entr_number ='", p_Args.Numero.ToString, "'")
        'End If

        'oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        'XInsert = New LibX.Data.XInsertStmt("cgdocaplm")

        'XInsert.Fields("doc_serial") = 0
        'XInsert.Fields("type_code") = "aaa"
        'XInsert.Fields("origen") = "CXC"
        'XInsert.Fields("tranr_serial") = EDSerial
        'XInsert.Fields("date_apply") = LibX.Data.Manager.Connection.GetDate

        'For Each oRow As DataRow In oTable.Rows
        '    XInsert.Fields("doc_serial").value = oRow!entr_serial
        '    XInsert.Fields("type_code").value = oRow!type_code
        '    XInsert.Fields("origen").value = "INV"
        '    XInsert.Fields("tranr_serial").value = EDSerial
        '    XInsert.Fields("date_apply").value = oRow!entr_date

        '    XInsert.Execute()
        'Next

        'Return True

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
        
        SelectStmt = String.Concat("select count(*)cnt from cgtranrm where orign_code ='INV' and perdr_year =" & Year & _
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
    Public Function Aplicar(ByVal p_Args As ParametrosGenerarEDINV) As Boolean
        Dim SelectStmt As String = ""
        Dim oTable, oSucursal As DataTable
        Dim oTableAccount As DataTable
        Dim Serial As Integer
        Dim CompraExcentas, CompraGrabadas, Inventario, CostoVenta As Decimal
        Dim CompraBruta, CompraNeta, Gastos, Contado As Decimal
        Dim Monto, Impuesto, Aduana, Otros, Isc, gravado As Decimal
        Dim Descuento, FOB, CIF As Decimal
        Dim Devolucion As Decimal
        Dim oCobro As DataTable
        Dim TypeDesc As String
        Dim mTipo As Integer

        Dim oGenerarED As Operaciones.GenerarED
        Dim oParamED As Operaciones.ParametrosGenerarED
        Dim oConf As SGT.Inventario.Common.Configuration
        Dim oCodif As SGT.Contabilidad.Entidades.Codificacion
        Dim oDocumento As Entidades.Documentos

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
                SelectStmt = String.Concat("select suc_code,type_code, sum(total_amount) total_amount", _
                                                " from vw_codifinv  ", _
                                               "where doc_date between '", _
                                               p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                               "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), "'" & _
                                               " and suc_code =" & oRow1!suc_code)

                If p_Args.Numero > 0 Then
                    SelectStmt = String.Concat(SelectStmt, " and dev_number ='", p_Args.Numero.ToString, "'")
                End If

                If p_Args.TipoDocumento.Trim <> "" Then
                    SelectStmt = String.Concat(SelectStmt.Trim, " and type_code ='", p_Args.TipoDocumento.Trim, "'")
                End If

                SelectStmt = String.Concat(SelectStmt.Trim, " group by suc_code,type_code ")

                oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

                If oTable Is Nothing Then
                    GoTo Next_Sucursal
                End If

                If oTable.Rows.Count <= 0 Then
                    GoTo Next_Sucursal
                End If

                oGenerarED = New Operaciones.GenerarED
                oParamED = New Operaciones.ParametrosGenerarED
                oConf = New SGT.Inventario.Common.Configuration
                oCodif = New SGT.Contabilidad.Entidades.Codificacion
                oDocumento = New Entidades.Documentos

                If LibX.Data.Manager.Connection.IsIntransaction = False Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                End If

                For Each oRow As DataRow In oTable.Rows
                    SelectStmt = String.Concat("select type_name from ivtypem where type_code ='", oRow!type_code.Trim, "'")
                    TypeDesc = LibX.Data.Manager.GetScalar(SelectStmt)

                    SelectStmt = String.Concat("select type_code,term_code,suc_code, sum(total_amount) total_amount,", _
                                      " sum(descto) descto, sum(itbis) itbis ,sum(gravado) gravado,sum(isc)isc,sum(costo) costo ", _
                                      " from vw_codifinv ", _
                                      " where vw_codifinv.doc_date between '", _
                                      p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                      "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), "'" & _
                                      " and type_code ='", oRow!type_code.Trim, "' and suc_code = " & oRow1!suc_code)

                    SelectStmt = String.Concat(SelectStmt.Trim, " group by type_code,suc_code ,term_code")
                    oCobro = LibX.Data.Manager.GetDataTable(SelectStmt)


                    If oCobro.Rows.Count <= 0 Then
                        GoTo Next_Row
                    End If

                    Isc = 0.0
                    Impuesto = 0.0
                    Descuento = 0.0
                    CompraBruta = 0.0
                    Contado = 0.0
                    gravado = 0.0
                    CostoVenta = 0.0

                    For Each oRowv As DataRow In oCobro.Rows

                        '// Calcular 
                        '''mTipo = orow!tipo
                        If oRowv!term_code = 1 Then
                            Isc = Isc + Val(oRowv!Isc.ToString)
                            Impuesto = Impuesto + Val(oRowv!itbis.ToString)
                            Descuento = Descuento + Val(oRowv!descto.ToString)
                            CompraBruta = CompraBruta + Val(oRowv!total_amount.ToString)
                            Contado = Contado + (CompraBruta - Descuento + Impuesto + Isc)
                            gravado = gravado + Val(oRowv!gravado.ToString)
                            CostoVenta = CostoVenta + Val(oRowv!costo.ToString)
                        Else
                            Isc = Isc + Val(oRowv!Isc.ToString)
                            Impuesto = Impuesto + Val(oRowv!itbis.ToString)
                            Descuento = Descuento + Val(oRowv!descto.ToString)
                            CompraBruta = CompraBruta + Val(oRowv!total_amount.ToString)
                            CompraNeta = (Val(oRowv!total_amount.ToString) - Val(oRowv!descto.ToString) + Val(oRowv!itbis.ToString) + Val(oRowv!Isc.ToString))
                            gravado = gravado + Val(oRowv!gravado.ToString)
                            CostoVenta = CostoVenta + Val(oRowv!costo.ToString)
                        End If

                        'If oRow!type_code = "DVI" Then
                        '    Devolucion = Val(oRow!total_amount.ToString) - Val(oRow!itbis_amount.ToString)
                        'Else
                        '    Devolucion = Val(oRow!total_amount.ToString) + Val(oRow!itbis_amount.ToString)
                        'End If
                    Next

                    'CompraGrabadas = Impuesto / (oConf.GetITBIS / 100)
                    CompraGrabadas = gravado
                    CompraExcentas = CompraBruta - CompraGrabadas
                    Inventario = CostoVenta

                    With oParamED
                        .Fecha = p_Args.FechaFinal
                        .Tipo = oRow!type_code
                        .Sucursal = oRow1!suc_code
                        .Numero = 0
                        .Modulo = "INV"
                        .Referencia = "ENTRADA DE DIARIO " & TypeDesc.ToString.Trim & p_Args.FechaFinal.ToString("dd/MM/yyyy")
                        .Reversar = False

                        .Cuentas.Clear()

                        '// buscar la codificación correspondiente
                        '''If mTipo = 1 Then '// Credito
                        oTableAccount = oCodif.BuscarPorCondicion(oRow!type_code.ToString, Entidades.Codificacion.CondicionEnum.Credito, 0, 0, "")
                        '''Else
                        '''    oTableAccount = oCodif.BuscarPorCondicion(oRow!type_code.ToString, Entidades.Codificacion.CondicionEnum.Contado, 0, 0, "")
                        '''End If

                        If oTableAccount.Rows.Count <= 0 Then
                            GoTo Next_Row
                        End If

                        For Each oRowCodif As DataRow In oTableAccount.Rows
                            Select Case Val(oRowCodif!orig_valor.ToString.Trim)
                                Case Entidades.Codificacion.OrigenValorEnum.MontoNeto
                                    Monto = CompraNeta

                                Case Entidades.Codificacion.OrigenValorEnum.MontoBruto
                                    Monto = CompraBruta

                                Case Entidades.Codificacion.OrigenValorEnum.Descuento
                                    Monto = Descuento

                                Case Entidades.Codificacion.OrigenValorEnum.Impuesto
                                    Monto = Impuesto

                                Case Entidades.Codificacion.OrigenValorEnum.MontoGrabado
                                    Monto = CompraGrabadas

                                Case Entidades.Codificacion.OrigenValorEnum.MontoExcento
                                    Monto = CompraExcentas

                                Case Entidades.Codificacion.OrigenValorEnum.FOB
                                    Monto = FOB

                                Case Entidades.Codificacion.OrigenValorEnum.Impuesto
                                    Monto = Otros + Gastos + Aduana

                                Case Entidades.Codificacion.OrigenValorEnum.Devolucion
                                    Monto = Devolucion

                                    ''Case Entidades.Codificacion.OrigenValorEnum.Inventario
                                    ''  Monto = Inventario

                                Case Entidades.Codificacion.OrigenValorEnum.CostoVenta
                                    Monto = CostoVenta

                                    ''Case Entidades.Codificacion.OrigenValorEnum.Isc
                                    ''  Monto = Isc

                                Case Entidades.Codificacion.OrigenValorEnum.Efectivo
                                    Monto = Contado

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

Next_Row:
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
