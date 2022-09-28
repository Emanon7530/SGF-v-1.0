Imports SGT
Imports SGT.Contabilidad
Imports SGT.Contabilidad.Intrefaces



Public Class GenerarEDCTB

    Private Function MarcarDocumentos(ByVal p_Args As ParametrosGenerarEDCTB, ByVal EDSerial As Integer) As Boolean
        'Dim SelectStmt As String = ""
        'Dim oTable As DataTable
        'Dim XInsert As LibX.Data.XInsertStmt

        'SelectStmt = String.Concat(" select tran_type, tranr_serial,doc_date ", _
        '                            " from cbdocsm  ", _
        '                            " where cbdocsm.doc_date between '", _
        '                            p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
        '                            "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), _
        '                            "' and cbdocsm.doc_status = 2 ")

        'If p_Args.TipoDocumento.Trim <> "" Then
        '    SelectStmt = String.Concat(SelectStmt, " and ccinvcem.type_code ='", p_Args.TipoDocumento.Trim, "'")
        'End If

        'If p_Args.Numero > 0 Then
        '    SelectStmt = String.Concat(SelectStmt, " and ccinvcem.invce_no ='", p_Args.Numero.ToString, "'")
        'End If

        'oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        'XInsert = New LibX.Data.XInsertStmt("cgdocaplm")

        'XInsert.Fields("doc_serial") = 0
        'XInsert.Fields("type_code") = "aaa"
        'XInsert.Fields("origen") = "CXC"
        'XInsert.Fields("tranr_serial") = EDSerial
        'XInsert.Fields("date_apply") = LibX.Data.Manager.Connection.GetDate

        'For Each oRow As DataRow In oTable.Rows
        '    XInsert.Fields("doc_serial") = oRow!tranr_serial
        '    XInsert.Fields("type_code") = oRow!tran_type
        '    XInsert.Fields("origen") = "CTG"
        '    XInsert.Fields("tranr_serial") = EDSerial
        '    XInsert.Fields("date_apply") = oRow!doc_date

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

        SelectStmt = String.Concat("select count(*)cnt from cgtranrm where orign_code ='CTB' and perdr_year =" & Year & _
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

    Public Function Aplicar(ByVal p_Args As ParametrosGenerarEDCTB) As Boolean
        Dim SelectStmt As String = ""
        Dim oTable, oSucursal As DataTable
        Dim oTableAccount As DataTable
        Dim oCobro As DataTable
        Dim Serial As Integer
        Dim VentasExcentas, VentasGrabadas As Decimal
        Dim VentaBruta, VentaNeta As Decimal
        Dim Monto, Impuesto As Decimal
        Dim Descuento As Decimal
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
                SelectStmt = String.Concat(" select cbdocsm.suc_code,tran_type,chequera, sum(cbdocsd.amount) amount ", _
                                                " from cbdocsm inner join cbdocsd ", _
                                                " on cbdocsm.cbm_serial = cbdocsd.cbm_serial ", _
                                                " where cbdocsm.doc_date between '", _
                                                p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                                "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                                "' and cbdocsm.doc_status = 1 and cbdocsm.suc_code = " & oRow1!suc_code)

                If p_Args.Numero > 0 Then
                    SelectStmt = String.Concat(SelectStmt, " and cbdocsm.doc_number ='", p_Args.Numero.ToString, "'")
                End If

                If p_Args.Chequera > 0 Then
                    SelectStmt = String.Concat(SelectStmt, " and cbdocsm.chequera =", p_Args.Chequera)
                End If

                If p_Args.TipoDocumento.Trim <> "" Then
                    SelectStmt = String.Concat(SelectStmt, " and cbdocsm.tran_type ='", p_Args.TipoDocumento.Trim, "'")
                End If

                SelectStmt = String.Concat(SelectStmt.Trim, " group by cbdocsm.suc_code,tran_type, chequera ")

                oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

                If oTable Is Nothing Then
                    ''Exit Function
                    GoTo Next_Sucursal
                End If

                If oTable.Rows.Count <= 0 Then
                    ''Exit Function
                    GoTo Next_Sucursal
                End If

                oGenerarED = New Operaciones.GenerarED
                oParamED = New Operaciones.ParametrosGenerarED
                oDocumento = New Entidades.Documentos
                oConf = New SGT.Inventario.Common.Configuration
                oCodif = New Entidades.Codificacion

                Dim TypeCode As String = ""

                '// Iniciar Transaccion
                If LibX.Data.Manager.Connection.IsIntransaction = False Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                End If

                For Each oRow As DataRow In oTable.Rows
                    SelectStmt = String.Concat("select type_name from ivtypem where type_code ='", oRow!tran_type.ToString.Trim, "'")
                    TypeDesc = LibX.Data.Manager.GetScalar(SelectStmt)

                    'SelectStmt = String.Concat(" select tran_type,cbdocsm.suc_code, acct_no, debit_credit, sum(cbdocsd.amount) amount, cpchequera.descripcion ", _
                    '            " from cbdocsm inner join cbdocsd  on cbdocsm.cbm_serial = cbdocsd.cbm_serial ", _
                    '            " inner join cpchequera on cpchequera.chequera = cbdocsm.chequera ", _
                    '            " where cbdocsm.doc_date between '", _
                    '            p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                    '            "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                    '            "' and cbdocsm.doc_status = 1 and cbdocsm.chequera = " & oRow!chequera, _
                    '            " and tran_type ='" & oRow!tran_type & "' and cbdocsm.suc_code =" & oRow1!suc_code)

                    'SelectStmt = String.Concat(SelectStmt.Trim, " group by cbdocsm.suc_code,tran_type, acct_no, debit_credit, cpchequera.descripcion")
                    SelectStmt = String.Concat(" select tran_type,cbdocsm.suc_code, acct_no, debit_credit, sum(cbdocsd.amount) amount ", _
                                                    " from cbdocsm inner join cbdocsd  on cbdocsm.cbm_serial = cbdocsd.cbm_serial ", _
                                                    " where cbdocsm.doc_date between '", _
                                                    p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                                    "' and '", p_Args.FechaFinal.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                                    "' and cbdocsm.doc_status = 1 and cbdocsm.chequera = " & oRow!chequera, _
                                                    " and tran_type ='" & oRow!tran_type & "' and cbdocsm.suc_code =" & oRow1!suc_code)

                    SelectStmt = String.Concat(SelectStmt.Trim, " group by cbdocsm.suc_code,tran_type, acct_no, debit_credit")
                    oCobro = LibX.Data.Manager.GetDataTable(SelectStmt)

                    If oCobro.Rows.Count <= 0 Then
                        GoTo Next_Row
                    End If

                    If oParamED.Tipo <> oRow!tran_type.ToString.Trim Then
                        With oParamED
                            .Fecha = p_Args.FechaFinal
                            .Tipo = oRow!tran_type
                            .Numero = 0
                            .Sucursal = oRow1!suc_code
                            .Modulo = "CTB"
                            .Referencia = "ENTRADA DE DIARIO " & TypeDesc.ToString.Trim & p_Args.FechaFinal.ToString("dd/MM/yyyy")
                            .Reversar = False
                            .Cuentas.Clear()
                        End With

                        For Each oRowDetail As DataRow In oCobro.Select("tran_type = '" & oRow!tran_type.ToString.Trim & "'")
                            With oParamED
                                Monto = oRowDetail!amount

                                If Monto > 0 Then
                                    .Cuentas.Add(oRowDetail!acct_no.ToString, 1, "", "", oRowDetail!debit_credit, Monto)
                                End If
                            End With
                        Next
                        Serial = 0
                        Serial = oGenerarED.Aplicar(oParamED)

                    End If
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
