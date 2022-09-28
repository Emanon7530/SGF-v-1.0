Imports SGT
Imports SGT.Contabilidad
Imports SGT.Contabilidad.Intrefaces

Public Class GenerarEDCXP
    Private Function MarcarDocumentos(ByVal p_Args As ParametrosGenerarEDCXP, ByVal EDSerial As Integer) As Boolean
        'Dim SelectStmt As String = ""
        'Dim oTable As DataTable
        'Dim XInsert As LibX.Data.XInsertStmt

        'SelectStmt = String.Concat("select type_code, cpinvcem.invce_serial, cpinvcem.doc_date ", _
        '                           " from cpinvcem ", _
        '                           " where cpinvcem.doc_date between '", _
        '                           p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
        '                           "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), _
        '                           "' and cpinvcem.invce_status = 3", _
        '                           " and type_code in ('CUS','CRD','DVI','NCR','NDC')" & _
        '                            " and cpinvcem.invce_serial not in (select doc_serial from cgdocaplm ", _
        '                            "                                     where cgdocaplm.type_code = cpinvcem.type_code ", _
        '                            "                                       and cgdocaplm.origen = 'CXP'" & _
        '                            "                                       and date_apply between '", _
        '                                                                    p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
        '                            "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat) & "')")

        'If p_Args.TipoDocumento.Trim <> "" Then
        '    SelectStmt = String.Concat(SelectStmt, " and cpinvcem.type_code ='", p_Args.TipoDocumento.Trim, "'")
        'End If

        'If p_Args.Numero > 0 Then
        '    SelectStmt = String.Concat(SelectStmt, " and cpinvcem.doc_no ='", p_Args.Numero.ToString, "'")
        'End If

        'oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        'XInsert = New LibX.Data.XInsertStmt("cgdocaplm")

        'XInsert.Fields("doc_serial") = 0
        'XInsert.Fields("type_code") = "aaa"
        'XInsert.Fields("origen") = "CXP"
        'XInsert.Fields("tranr_serial") = EDSerial
        'XInsert.Fields("date_apply") = LibX.Data.Manager.Connection.GetDate

        'For Each oRow As DataRow In oTable.Rows
        '    XInsert.Fields("doc_serial").value = oRow!invce_serial
        '    XInsert.Fields("type_code").value = oRow!type_code
        '    XInsert.Fields("origen").value = "CXP"
        '    XInsert.Fields("tranr_serial").value = EDSerial
        '    XInsert.Fields("date_apply").value = oRow!doc_date

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
        
        SelectStmt = String.Concat("select count(*)cnt from cgtranrm where orign_code ='CXP' and perdr_year =" & Year & _
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

    Public Function Aplicar(ByVal p_Args As ParametrosGenerarEDCXP) As Boolean
        Dim SelectStmt As String = ""
        Dim oTable, oSucursal As DataTable
        Dim oCobro As DataTable
        Dim oTableAccount As DataTable
        Dim Serial As Integer
        Dim VentasExcentas, VentasGrabadas As Decimal
        Dim VentaBruta, VentaNeta, Gastos As Decimal
        Dim Monto, Impuesto, Aduana, Isc As Decimal
        Dim Descuento, FOB, CIF, Devolucion As Decimal
        Dim Inventario, InvVeterinario As Decimal
        Dim TypeDesc As String

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
                SelectStmt = String.Concat("select type_code,suc_code, sum(total_amount) total_amount,sum(total_dev) total_dev,", _
                                   " sum(descto) disc_amount, sum(itbis) itbis_amount,sum(isc_amount) isc_amount ", _
                                   " from vw_codifcxp ", _
                                   " where vw_codifcxp.doc_date between '", _
                                   p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                   "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                   "' and type_code in ('CRD','NCR','NDP','PEF')   and suc_code = " & oRow1!suc_code)

                If p_Args.Numero > 0 Then
                    SelectStmt = String.Concat(SelectStmt, " and vw_codifcxp.doc_no ='", p_Args.Numero.ToString, "'")
                End If
                If p_Args.TipoDocumento.Trim <> "" Then
                    SelectStmt = String.Concat(SelectStmt, " and vw_codifcxp.type_code ='", p_Args.TipoDocumento.Trim, "'")
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

                    SelectStmt = String.Concat("select type_code,suc_code, sum(total_amount) total_amount,sum(total_dev) total_dev,", _
                                       " sum(descto) disc_amount, sum(itbis) itbis_amount,sum(isc_amount) isc_amount ,sum(balance) balance", _
                                       " from vw_codifcxp ", _
                                       " where vw_codifcxp.doc_date between '", _
                                       p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                       "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                       "' and type_code ='", oRow!type_code.Trim, "' and suc_code = " & oRow1!suc_code)

                    SelectStmt = String.Concat(SelectStmt.Trim, " group by type_code,suc_code ")
                    oCobro = LibX.Data.Manager.GetDataTable(SelectStmt)

                    If oCobro.Rows.Count <= 0 Then
                        GoTo NEXT_ROW
                    End If

                    For Each oRowv As DataRow In oCobro.Rows

                        '// Calcular 
                        '//            FOB = Val(oRow!fob_amount.ToString)
                        '//Aduana = Val(oRow!gastos_aduana.ToString)
                        '//Gastos = Val(oRow!gastos_gen.ToString)
                        Isc = Val(oRow!isc_amount.ToString)
                        Impuesto = Val(oRow!itbis_amount.ToString)
                        Descuento = Val(oRow!disc_amount.ToString)
                        Devolucion = Val(oRow!total_dev.ToString)
                        If oRowv!type_code = "PEF" Then
                            VentaBruta = Val(oRowv!balance.ToString)
                            VentaNeta = Val(oRowv!total_amount.ToString)
                        Else
                            VentaBruta = Val(oRowv!total_amount.ToString)
                            VentaNeta = VentaBruta - Descuento + Impuesto
                        End If
                        FOB = Val(oRow!total_amount.ToString)
                        If oRowv!type_code = "CUS" Then
                            Inventario = VentaBruta
                        Else
                            If oRowv!type_code = "CRD" Then
                                Inventario = VentaBruta
                            End If
                        End If
                    Next

                    VentasGrabadas = Format(Impuesto / (oConf.GetITBIS / 100), "##,###,##0.00")
                    VentasExcentas = Format(VentaBruta - VentasGrabadas, "##,###,##0.00")

                    With oParamED
                        .Fecha = p_Args.FechaFinal
                        .Tipo = oRow!type_code
                        .Sucursal = oRow1!suc_code
                        .Numero = oDocumento.GetNextNumber(oRow!type_code)
                        .Modulo = "CXP"
                        .Referencia = "ENTRADA DE DIARIO " & TypeDesc.ToString.Trim & "  " & p_Args.FechaFinal.ToString("dd/MM/yyyy")
                        .Reversar = False

                        .Cuentas.Clear()

                        '// buscar la codificación correspondiente
                        oTableAccount = oCodif.BuscarPorCondicion(oRow!type_code.ToString, Entidades.Codificacion.CondicionEnum.Credito, 0, 0, "")

                        If oTableAccount.Rows.Count <= 0 Then
                            GoTo NEXT_ROW
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

                                Case Entidades.Codificacion.OrigenValorEnum.FOB
                                    Monto = FOB

                                    ''Case Entidades.Codificacion.OrigenValorEnum.Isc
                                    ''  Monto = Isc

                                    ''Case Entidades.Codificacion.OrigenValorEnum.Inventario
                                    ''  Monto = Inventario

                                Case Entidades.Codificacion.OrigenValorEnum.Devolucion
                                    Monto = Devolucion
                            End Select

                            ''Asignar el origen de la cuenta
                            oRowCodif!origen = IIf(Val(oRowCodif!origen.ToString) = 1, 1, -1)

                            If Monto > 0 Then
                                .Cuentas.Add(oRowCodif!acct_no.ToString, 1, "", "", oRowCodif!origen, Monto)
                            End If
                        Next

                        '// Generar Entrada
                        Serial = oGenerarED.Aplicar(oParamED)

                        '// Marcar Documentos
                        ''p_Args.TipoDocumento = oRow!type_code
                        ''MarcarDocumentos(p_Args, Serial)

                    End With
Next_row:
                Next
Next_Sucursal:
            Next

            codifGastos(p_Args)

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
    Private Function codifGastos(ByVal p_Args As ParametrosGenerarEDCXP) As Boolean
        Dim SelectStmt As String = ""
        Dim oTable, oSucursal As DataTable
        Dim oCobro As DataTable
        Dim oTableAccount As DataTable
        Dim Serial As Integer
        Dim VentasExcentas, VentasGrabadas As Decimal
        Dim VentaBruta, VentaNeta, Gastos As Decimal
        Dim Monto, Impuesto, Aduana, Otros As Decimal
        Dim Descuento, FOB, CIF As Decimal
        Dim TypeDesc As String

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
                SelectStmt = String.Concat("select cpinvcem.suc_code,type_code,sum(isnull(cpinvcem.amount,0)-isnull(disc_amount,0)+isnull(itbis,0)) amount", _
                                           " from cpinvcem inner join cpinvced on cpinvcem.invce_serial  = cpinvced.invce_serial ", _
                                          " and  cpinvcem.doc_date between '", _
                                          p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                          "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                           "' and type_code in ('CCH','FPI') ")
                                          

                If p_Args.Numero > 0 Then
                    SelectStmt = String.Concat(SelectStmt, " and cpinvcem.doc_no ='", p_Args.Numero.ToString, "'")
                End If
                If p_Args.TipoDocumento.Trim <> "" Then
                    SelectStmt = String.Concat(SelectStmt, " and cpinvcem.type_code ='", p_Args.TipoDocumento.Trim, "'")
                End If

                SelectStmt = String.Concat(SelectStmt.Trim, " group by cpinvcem.suc_code,type_code ")

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

                    SelectStmt = String.Concat("select type_code,cpinvcem.suc_code, cpinvced.acct_no, debit_credit, case cpinvcem.type_code when 'CUS' ", _
                                 " then sum(cpinvced.amount*cpinvcem.tasaUS) else  sum(cpinvced.amount) end  amount ", _
                                               " from cpinvcem inner join cpinvced  on cpinvcem.invce_serial = cpinvced.invce_serial", _
                                               " and  cpinvcem.doc_date between '", _
                                               p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                               "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                               "' and type_code ='", oRow!type_code.Trim, "' and cpinvcem.suc_code = " & oRow1!suc_code)

                    SelectStmt = String.Concat(SelectStmt.Trim, " group by type_code,cpinvcem.suc_code,cpinvced.acct_no, debit_credit")
                    oCobro = LibX.Data.Manager.GetDataTable(SelectStmt)

                    If oCobro.Rows.Count <= 0 Then
                        GoTo NEXT_ROW
                    End If

                    With oParamED
                        .Fecha = p_Args.FechaFinal
                        .Tipo = oRow!type_code
                        .Sucursal = oRow1!suc_code
                        .Numero = oDocumento.GetNextNumber(oRow!type_code)
                        .Modulo = "CXP"
                        .Referencia = "ENTRADA DE DIARIO " & TypeDesc.ToString.Trim & "  " & p_Args.FechaFinal.ToString("dd/MM/yyyy")
                        .Reversar = False

                        .Cuentas.Clear()

                        For Each oRowDetail As DataRow In oCobro.Select("type_code = '" & oRow!type_code.ToString.Trim & "'")
                            With oParamED
                                Monto = oRowDetail!amount

                                If Monto > 0 Then
                                    .Cuentas.Add(oRowDetail!acct_no.ToString, 1, "", "", oRowDetail!debit_credit, Monto)
                                End If
                            End With
                        Next

                        '// Generar Entrada
                        Serial = oGenerarED.Aplicar(oParamED)
                    End With
Next_row:
                Next
Next_Sucursal:
            Next
        Catch ex As Exception
            Throw
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
        End Try
    End Function
End Class
