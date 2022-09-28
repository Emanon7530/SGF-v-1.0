Imports SGT.Inventario
Imports SGT.Inventario.Common

Namespace Operaciones
    Public Class PostInventory

        Public Class ParametrosAplicar
            Public TipoTransaccion As String
            Public Serial As Integer
            Public Numero As String = ""
            Public Proveedor As Integer
            Public Comprobante As String
            Public Termino As String = ""
            Public Referencia As Integer
            Public DocDate As Date
            Public Tasa As Decimal
            Public Monto As Decimal
            Public Impuesto As Decimal
            Public Descuento As Decimal
            Public Productos As New Common.Items
            Public SucCode As Integer
            Public UseTransaction As Boolean = True
            Public WebTrasnf As Boolean
        End Class

        Public Class ParametrosAnular
            Public Serial As Integer
            Public TipoTransaccion As String
            Public Numero As String
            Public Productos As New Common.Items
            Public UseTransaction As Boolean = True
        End Class

        Public Function Anular(ByVal e As ParametrosAnular) As Boolean
            Dim oivitemd As DataRow
            Dim oivOnhand As LibX.Data.XInsertStmt
            Dim oSelect As LibX.Data.XSelecStmt
            Dim oUpdate, oUpd As LibX.Data.XUpdateStmt
            Dim oTable As DataTable
            Dim oTableDetail As DataTable
            Dim oinvceRow As DataRow
            Dim oiventrdm As DataRow
            Dim oMovi As DataTable
            Dim opostcxp As SGT.CXP.Posteos.PostDocument

            Dim SelectStatment As String
            Dim oType As Entidades.Documento
            Dim oUnidad As Entidades.UnidadMedida

            Try
                '// Tipo de documento
                oType = New Entidades.Documento(e.TipoTransaccion)
                oUnidad = New Entidades.UnidadMedida

                '// buscar la transaccion aplicada
                SelectStatment = "select * from ivtranrm where doc_serial = " & e.Serial.ToString & _
                " and type_code = '" & e.TipoTransaccion.Trim & "'"

                oTable = LibX.Data.Manager.GetDataTable(SelectStatment, "ivtranrm", True)

                If oTable Is Nothing Then
                    Return True
                End If

                If oTable.Rows.Count <= 0 Then
                    Return True
                End If

                '// Buscar el detalle de los productos
                SelectStatment = "select * from ivtranrd where trane_number = " & oTable.Rows(0)!trane_number.ToString.Trim

                oTableDetail = LibX.Data.Manager.GetDataTable(SelectStatment, "ivtranrd", True)

                If oTableDetail Is Nothing Then
                    Return True
                End If

                If oTableDetail.Rows.Count <= 0 Then
                    Return True
                End If

                If e.UseTransaction And LibX.Data.Manager.Connection.IsIntransaction = False Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                End If

                '// Actualizar existencia de producto
                oUpdate = New LibX.Data.XUpdateStmt("ivitemd")

                For Each orow As DataRow In oTableDetail.Rows
                    '// Actualizar la existencia del producto        
                    oSelect = New LibX.Data.XSelecStmt("ivitemd", String.Concat("select * from ivitemd where item_code = '", _
                                                        orow!item_code.ToString.Trim, "' and whse_code = ", orow!whse_code.ToString))

                    oivitemd = oSelect.GetDataRow()
                    oivitemd!avg_cost = 0

                    Select Case oType.Entrada
                        Case True
                            '// Actualizar Existencia
                            oivitemd!existencia = Val(oivitemd!existencia.ToString) - _
                                    (Val(orow!qty.ToString.Trim) * _
                                        oUnidad.GetFactor(orow!item_code.ToString.Trim, orow!unit_code.ToString.Trim))

                        Case False
                            '// Actualizar Existencia
                            oivitemd!existencia = Val(oivitemd!existencia.ToString) + _
                                    (Val(orow!qty.ToString.Trim) * _
                                        oUnidad.GetFactor(orow!item_code.ToString.Trim, orow!unit_code.ToString.Trim))
                    End Select

                    oUpdate.FieldsSet("existencia") = oivitemd!existencia
                    oUpdate.Fields("item_code") = oivitemd!item_code
                    oUpdate.Fields("whse_code") = oivitemd!whse_code

                    oUpdate.Execute()

                    SelectStatment = "select * from vwitemmov where doc_serial > " & e.Serial.ToString & " and item_code = '" & orow!item_code.ToString.Trim & _
                                     "' and whse_code = " & orow!whse_code.ToString
                    oMovi = LibX.Data.Manager.GetDataTable(SelectStatment, "vwitemmov", True)

                    If oMovi Is Nothing Then
                        Return True
                    End If

                    oUpd = New LibX.Data.XUpdateStmt("ivtranrd")

                    For Each oRowv As DataRow In oMovi.Rows
                        oUpd.FieldsSet("bf_onhand") = oRowv!bf_onhand + orow!qty
                        oUpd.Fields("item_code") = oRowv!item_code
                        oUpd.Fields("whse_code") = oRowv!whse_code
                        oUpd.Fields("trane_number") = oRowv!trane_number
                        oUpd.Execute()
                    Next

                    '// Borrar
                    orow.Delete()

                Next

                '// ANULAR VENCIMIENTO
                AnularVencimiento(e.Serial, False, e.TipoTransaccion)

                '// ENTRADA DE DIARIO
                SelectStatment = "select * from iventrdm " & _
                                 " where entr_serial = " & e.Serial.ToString()

                oiventrdm = LibX.Data.Manager.GetDataRow(SelectStatment)

                If oiventrdm Is Nothing Then
                    Throw New ApplicationException("No existen entrada con ese serial!")
                End If

                '// FACTURA CXP
                SelectStatment = "select * from cpinvcem " & _
                                 " where doc_no = '" & oiventrdm!entr_number & "'" & _
                                 " and type_code = '" & oiventrdm!type_code & "'"

                oinvceRow = LibX.Data.Manager.GetDataRow(SelectStatment)

                If Not oinvceRow Is Nothing Then

                    '// REVERSAR CXP
                    Dim opostparam As SGT.CXP.Posteos.PostDocument.ParametrosAplicar

                    opostcxp = New SGT.CXP.Posteos.PostDocument
                    opostparam = New SGT.CXP.Posteos.PostDocument.ParametrosAplicar

                    With opostparam
                        .Serial = oinvceRow!invce_serial
                        .TipoDocumento = e.TipoTransaccion
                    End With

                    opostcxp.Anular(opostparam)
                End If

                '// Anular la transacción!!
                oTable.Rows(0).Delete()
                LibX.Data.Manager.Save(oTable)

                '// Anular la transacción!!
                LibX.Data.Manager.Save(oTableDetail)

                If e.UseTransaction And LibX.Data.Manager.Connection.IsIntransaction = True Then
                    LibX.Data.Manager.Connection.CommitTransaction()
                End If

                Return True

            Catch ex As Exception
                LibX.Log.Add(ex)
                If e.UseTransaction And LibX.Data.Manager.Connection.IsIntransaction = True Then
                    LibX.Data.Manager.Connection.RollBackTransaction()
                End If
            End Try

        End Function

        Private Sub AnularSerie(ByVal TypeCode As String, ByVal Serial As Integer)
            '// SI ES UNA FACTURA
            '// ACTUALIZAR AL NULO DEL NUMERO DE LA FACTURA EN LA TABLA DE SERIE

            '// SI ES UNA DEVOLUCION
            '// ACTUALIZAR LAS SERIES AL NUMERO DE FACTURA QUE TIENE LA SERIE EN
            '// LA TABLA DE SERIE POR DOCUMENTO
            Dim SelectStmt As String
            Dim XUpdate As LibX.Data.XUpdateStmt
            Dim oTable As DataTable
            Try

                If TypeCode = "FCT" Then
                    SelectStmt = "select serie_number,null as ftserial_no from ivseriem " & _
                                 " where ftserial_no = " & Serial.ToString
                End If

                If TypeCode = "DVF" Then
                    SelectStmt = "select serie_number,ftserial_afect ftserial_no " & _
                                 " from ftseriem,ftfactm " & _
                                 " where ftseriem.ftserial_no = " & Serial.ToString & _
                                 "   and ftfactm.ftserial_no = ftseriem.ftserial_no "
                End If

                oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

                For Each oRow As DataRow In oTable.Rows
                    XUpdate = New LibX.Data.XUpdateStmt("ivseriem")

                    XUpdate.FieldsSet("ftserial_no") = 0
                    XUpdate.FieldsSet("ftserial_no") = oRow!ftserial_no
                    XUpdate.Fields("serie_number") = oRow!serie_number
                    XUpdate.Execute()

                    XUpdate.Dispose()
                Next
            Catch ex As Exception
                LibX.Log.Add(ex)
            End Try
        End Sub

        Public Function AnularVencimiento(ByVal pSerial As Integer, ByVal UseTransaction As Boolean, ByVal TipoTransaccion As String) As Boolean
            Dim oType As Entidades.Documento
            Dim oUnidad As Entidades.UnidadMedida

            Dim oivvcmted As LibX.Data.XInsertStmt
            Dim ouvvcmted As LibX.Data.XUpdateStmt

            Dim ivvcmted As DataRow
            Dim ivvcmtev As DataRow
            Dim oSelect As LibX.Data.XSelecStmt
            Dim oTable As DataTable
            Dim SelectStatment As String
            Dim UnidadMinVenta As String


            Try
                oType = New Entidades.Documento(TipoTransaccion)

                '// Buscar el documento a aplicar
                '// de aqui se tomara los datos de la cabecera y el proveedor
                oSelect = New LibX.Data.XSelecStmt("ivvcmtov", "select * from ivvcmtov where doc_serial = " & _
                                                    pSerial.ToString & " and type_code = '" & TipoTransaccion.Trim & "'")
                ivvcmtev = oSelect.GetDataRow

                If ivvcmtev Is Nothing Then
                    Return True
                End If

                '// Buscar los productos a aplicar por mes, ano, suplidor
                oTable = LibX.Data.Manager.GetDataTable("select * from ivvcmtod where doc_serial = " & pSerial.ToString & " and type_code = '" & TipoTransaccion.Trim & "'", "ivvcmtod", True)

                If oTable Is Nothing Then
                    Return True
                End If

                If oTable.Rows.Count <= 0 Then
                    Return True
                End If

                oUnidad = New Entidades.UnidadMedida

                If UseTransaction And LibX.Data.Manager.Connection.IsIntransaction = False Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                End If

                '// Actualizar Existencia
                ouvvcmted = New LibX.Data.XUpdateStmt("ivvcmted")

                For Each oRow As DataRow In oTable.Rows
                    '// Actualizar la existencia del producto        
                    oSelect = New LibX.Data.XSelecStmt("ivvcmted", String.Concat("select * from ivvcmted where item_code = '", _
                                                        oRow!item_code.ToString.Trim, "' and Mes = ", oRow!vcmto_month.ToString, _
                                                        " and Ano = ", oRow!vcmto_year.ToString, " and prov_code = ", oRow!prov_code.ToString.Trim))

                    ivvcmted = oSelect.GetDataRow()

                    If ivvcmted Is Nothing Then
                        GoTo Prox_Rreg
                    End If

                    UnidadMinVenta = oUnidad.GetUnidadMinimaVenta(oRow!item_code)

                    If oType.Entrada = True Then
                        ouvvcmted.FieldsSet("Existencia") = Val(ivvcmted!existencia.ToString) _
                                                            - (oRow!qty * oUnidad.GetFactor(oRow!item_code, oRow!unit_code))
                    Else
                        ouvvcmted.FieldsSet("Existencia") = Val(ivvcmted!existencia.ToString) _
                                                            + (oRow!qty * oUnidad.GetFactor(oRow!item_code, oRow!unit_code))
                    End If

                    ouvvcmted.Fields("item_code") = oRow!item_code
                    ouvvcmted.Fields("prov_code") = oRow!prov_code
                    ouvvcmted.Fields("whse_code") = ivvcmtev!whse_code
                    ouvvcmted.Fields("Mes") = oRow!vcmto_month
                    ouvvcmted.Fields("Ano") = oRow!vcmto_year
                    ouvvcmted.Fields("prov_code") = oRow!prov_code
                    ouvvcmted.Execute()

                    '// si tiene 2 vencimientos 
                    If Val(oRow!qty1.ToString.Trim) <> 0 Then
                        '// Actualizar la existencia del producto        
                        oSelect = New LibX.Data.XSelecStmt("ivvcmted", String.Concat("select * from ivvcmted where item_code = '", _
                                                            oRow!item_code.ToString.Trim, "' and Mes = ", oRow!vcmto_month.ToString, _
                                                            " and Ano = ", oRow!vcmto_year.ToString, " and prov_code = ", oRow!prov_code.ToString.Trim))

                        ivvcmted = oSelect.GetDataRow()

                        If ivvcmted Is Nothing Then
                            GoTo Prox_Rreg
                        End If

                        UnidadMinVenta = oUnidad.GetUnidadMinimaVenta(oRow!item_code)

                        If oType.Entrada = True Then
                            ouvvcmted.FieldsSet("Existencia") = Val(ivvcmted!existencia.ToString) _
                                                                - (oRow!qty * oUnidad.GetFactor(oRow!item_code, oRow!unit_code))
                        Else
                            ouvvcmted.FieldsSet("Existencia") = Val(ivvcmted!existencia.ToString) _
                                                                + (oRow!qty * oUnidad.GetFactor(oRow!item_code, oRow!unit_code))
                        End If

                        ouvvcmted.Fields("item_code") = oRow!item_code
                        ouvvcmted.Fields("prov_code") = oRow!prov_code
                        ouvvcmted.Fields("whse_code") = ivvcmtev!whse_code
                        ouvvcmted.Fields("Mes") = oRow!vcmto_month1
                        ouvvcmted.Fields("Ano") = oRow!vcmto_year1
                        ouvvcmted.Fields("prov_code") = oRow!prov_code
                        ouvvcmted.Execute()
                    End If

                    oRow.Delete()
Prox_Rreg:
                Next

                '// Eliminar los vencimientos
                LibX.Data.Manager.Save(oTable)

                If UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                    LibX.Data.Manager.Connection.CommitTransaction()
                End If

                Return True

            Catch ex As Exception
                LibX.Log.Add(ex)
                If UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                    LibX.Data.Manager.Connection.RollBackTransaction()
                End If
            End Try

        End Function


        Public Function AplicarVencimiento(ByVal pSerial As Integer, ByVal UseTransaction As Boolean, ByVal TipoTransaccion As String) As Boolean
            Dim oType As Entidades.Documento
            Dim oUnidad As Entidades.UnidadMedida

            Dim oivvcmted As LibX.Data.XInsertStmt
            Dim ouvvcmted As LibX.Data.XUpdateStmt

            Dim ivvcmted As DataRow
            Dim ivvcmtev As DataRow
            Dim oSelect As LibX.Data.XSelecStmt
            Dim oTable As DataTable
            Dim SelectStatment As String
            Dim UnidadMinVenta As String
            Dim sQty As Integer
            Dim sMes As Integer
            Dim sAnios As Integer

            Try
                oType = New Entidades.Documento(TipoTransaccion)

                '// Buscar el documento a aplicar
                '// de aqui se tomara los datos de la cabecera y el proveedor
                oSelect = New LibX.Data.XSelecStmt("ivvcmtov", "select * from ivvcmtov where doc_serial = " & _
                                                    pSerial.ToString & " and type_code = '" & TipoTransaccion.Trim & "'")
                ivvcmtev = oSelect.GetDataRow

                If ivvcmtev Is Nothing Then
                    Return True
                End If

                '// Buscar los productos a aplicar por mes, ano, suplidor
                oSelect = New LibX.Data.XSelecStmt("ivvcmtod", "select * from ivvcmtov1 where doc_serial = " & pSerial.ToString & " and type_code = '" & TipoTransaccion.Trim & "'")
                oTable = oSelect.GetTable

                If oTable Is Nothing Then
                    Return True
                End If

                If oTable.Rows.Count <= 0 Then
                    Return True
                End If

                oUnidad = New Entidades.UnidadMedida

                If UseTransaction And LibX.Data.Manager.Connection.IsIntransaction = False Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                End If

                For Each oRow As DataRow In oTable.Rows
                    '// Actualizar la existencia del producto del vencimiento        
                    oSelect = New LibX.Data.XSelecStmt("ivvcmted", String.Concat("select * from ivvcmted where item_code = '", _
                                                        oRow!item_code.ToString.Trim, "' and Mes = ", oRow!vcmto_month.ToString, _
                                                        " and Ano = ", oRow!vcmto_year.ToString))

                    ivvcmted = oSelect.GetDataRow()

                    UnidadMinVenta = oUnidad.GetUnidadMinimaVenta(oRow!item_code)

                    ''If ivvcmted Is Nothing Then
                    ''    Return True
                    ''End If

                    ''If oRow!qty_onhand < 0 Then
                    ''    Return True
                    ''End If


                    If ivvcmted Is Nothing And _
                    (TipoTransaccion.Trim <> "FPV" Or TipoTransaccion.Trim <> "FSG") Then

                        oivvcmted = New LibX.Data.XInsertStmt("ivvcmted")

                        oivvcmted.Fields("item_code") = oRow!item_code
                        oivvcmted.Fields("unit_code") = UnidadMinVenta
                        oivvcmted.Fields("prov_code") = oRow!prov_code
                        oivvcmted.Fields("whse_code") = ivvcmtev!whse_code
                        oivvcmted.Fields("Mes") = oRow!vcmto_month
                        oivvcmted.Fields("Ano") = oRow!vcmto_year

                        If oType.Entrada = True Then
                            oivvcmted.Fields("Existencia") = (oRow!qty * oUnidad.GetFactor(oRow!item_code, oRow!unit_code))
                        Else
                            oivvcmted.Fields("Existencia") = -(oRow!qty * oUnidad.GetFactor(oRow!item_code, oRow!unit_code))
                        End If

                        oivvcmted.Execute()
                    Else
                        '// Actualizar Existencia
                        If oRow!qty_onhand < 0 Then
                            oRow!qty = oRow!qty * -1
                        End If

                        ''ouvvcmted = New LibX.Data.XUpdateStmt("ivvcmted")

                        If oType.Entrada = True Then
                            sQty = (Val(ivvcmted!existencia.ToString) + (oRow!qty * oUnidad.GetFactor(oRow!item_code, oRow!unit_code)))

                            ''ouvvcmted.FieldsSet("Existencia") = (Val(ivvcmted!existencia.ToString) _
                            ''+ (oRow!qty * oUnidad.GetFactor(oRow!item_code, oRow!unit_code)))
                        Else
                            sQty = (Val(ivvcmted!existencia.ToString) - (oRow!qty * oUnidad.GetFactor(oRow!item_code, oRow!unit_code)))

                            ''ouvvcmted.FieldsSet("Existencia") = (Val(ivvcmted!existencia.ToString) _
                            ''- (oRow!qty * oUnidad.GetFactor(oRow!item_code, oRow!unit_code)))
                        End If

                        ''ouvvcmted.Fields("item_code") = "'" & oRow!item_code & "'"
                        '''// ouvvcmted.Fields("prov_code") = oRow!prov_code --- No Actualizar por Suplidor
                        ''ouvvcmted.Fields("whse_code") = ivvcmtev!whse_code
                        ''ouvvcmted.Fields("Mes") = "'" & oRow!vcmto_month & "'"
                        ''ouvvcmted.Fields("Ano") = "'" & oRow!vcmto_year & "'"

                        ''ouvvcmted.Execute()
                        ''ouvvcmted.Dispose()

                        ''//Ejecutar un procedimiento llamado "proc_ivvcmtedUpdate" para actualizar el vencimiento

                        sMes = oRow!vcmto_month
                        sAnios = oRow!vcmto_year

                        Dim cmd As OleDb.OleDbCommand

                        cmd = LibX.Data.Manager.Connection.CreateCommand
                        cmd.CommandText = "proc_ivvcmtedUpdate"
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.Add("item_code", oRow!item_code)
                        cmd.Parameters.Add("whse_code", ivvcmtev!whse_code)
                        cmd.Parameters.Add("Mes", sMes.ToString("00"))
                        cmd.Parameters.Add("Ano", sAnios.ToString("0000"))
                        cmd.Parameters.Add("Existencia", sQty)
                        cmd.ExecuteNonQuery()
                    End If
                Next

                If UseTransaction And LibX.Data.Manager.Connection.IsIntransaction = True Then
                    LibX.Data.Manager.Connection.CommitTransaction()
                End If
                Return True

            Catch ex As Exception
                LibX.Log.Add(ex)
                If UseTransaction And LibX.Data.Manager.Connection.IsIntransaction = True Then
                    LibX.Data.Manager.Connection.RollBackTransaction()
                End If

            End Try

        End Function

        Public Function AplicarConEtiqueta(ByVal e As ParametrosAplicar)
            Dim oDocumento As SGT.Inventario.Entidades.Documento
            Dim oAplicarParam As ParametrosAplicar
            Dim XUpdate As LibX.Data.XUpdateStmt
            Try

                oDocumento = New SGT.Inventario.Entidades.Documento(e.TipoTransaccion)

                If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                End If

                '// Aplicar Entrada
                oAplicarParam = New ParametrosAplicar
                With oAplicarParam
                    .DocDate = e.DocDate
                    .Serial = e.Serial
                    .Tasa = e.Tasa
                    .Impuesto = e.Impuesto
                    .Monto = e.Monto
                    .Descuento = e.Descuento
                    .Numero = e.Numero
                    .Productos = e.Productos
                    .Proveedor = e.Proveedor
                    .Comprobante = e.Comprobante
                    .Referencia = e.Referencia
                    .Termino = e.Termino
                    .TipoTransaccion = e.TipoTransaccion
                    .SucCode = e.SucCode
                    .WebTrasnf = e.WebTrasnf
                    .UseTransaction = False
                End With

                Aplicar(oAplicarParam)

                If ValidarEtiqueta(e.Numero) = False Then
                    oDocumento.GenerarEtiqueta(e.Serial)
                End If

                XUpdate = New LibX.Data.XUpdateStmt("iventrdm")

                XUpdate.FieldsSet("entr_status") = 1 'Aplicada
                XUpdate.Fields("entr_serial") = e.Serial
                XUpdate.Fields("prov_code") = e.Proveedor

                XUpdate.Execute()

                If LibX.Data.Manager.Connection.IsIntransaction = True And e.UseTransaction = True Then
                    LibX.Data.Manager.Connection.CommitTransaction()
                End If

            Catch ex As Exception
                If LibX.Data.Manager.Connection.IsIntransaction = True And e.UseTransaction = True Then
                    LibX.Data.Manager.Connection.RollBackTransaction()
                End If

                LibX.Log.Add(ex)
            End Try
        End Function

        Public Function Aplicar(ByVal e As ParametrosAplicar) As Boolean
            Dim getItbis As Decimal
            Dim opostcxp As SGT.CXP.Posteos.PostDocument
            Dim oType As Entidades.Documento
            Dim oUnidad As Entidades.UnidadMedida
            Dim oTermino As SGT.CXC.Entidades.Termino

            Dim oivtranrm As LibX.Data.XInsertStmt
            Dim oivtranrd As LibX.Data.XInsertStmt
            Dim oivitemd As DataRow

            Dim oivOnhand As LibX.Data.XInsertStmt
            Dim oSelect As LibX.Data.XSelecStmt
            Dim oUpdate As LibX.Data.XUpdateStmt

            Dim oTable As DataTable
            Dim xNumber As Integer
            Dim SelectStatment As String

            Try

                oType = New Entidades.Documento(e.TipoTransaccion)

                '// Iniciar Transaccion
                If e.UseTransaction And LibX.Data.Manager.Connection.IsIntransaction = False Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                End If

                '// Insertar la cabecera de la tabla de transacción de inventario
                oivtranrm = New LibX.Data.XInsertStmt("ivtranrm", "trane_number")

                oivtranrm!trane_number = 0
                oivtranrm!type_code = e.TipoTransaccion

                If e.Numero <> "" Then oivtranrm!doc_number = e.Numero

                oivtranrm!doc_serial = e.Serial
                oivtranrm!doc_date = DateSerial(Year(e.DocDate), Month(e.DocDate), Day(e.DocDate))
                oivtranrm!reference = e.Referencia
                oivtranrm!tasa = e.Tasa
                oivtranrm!tranr_status = 1 'Aplicada
                oivtranrm!tran_date = DateSerial(Year(Now), Month(Now), Day(Now))
                getItbis = LibX.Data.Manager.GetScalar("select percent_itbis from ivsetup")

                xNumber = oivtranrm.Execute()

                '// SI EL TIPO DE DOCUMENTO AFECTA A CXP Y ES UN DOCUMENTO A CREDITO
                '// APLICARLO A CUENTA X PAGAR
                If oType.AfectaCXP = True Then
                    oTermino = New SGT.CXC.Entidades.Termino(e.Termino)

                    '// entrada a CREDITO
                    If oTermino.DiasVencimiento > 0 Then

                        If oType.Origen = 1 Then
                            Dim opostparam As SGT.CXP.Posteos.PostDocument.ParametrosAplicarFacturas

                            opostcxp = New SGT.CXP.Posteos.PostDocument
                            opostparam = New SGT.CXP.Posteos.PostDocument.ParametrosAplicarFacturas

                            With opostparam
                                .SerialEntrada = e.Serial
                                .TipoDocumento = e.TipoTransaccion
                                .Proveedor = e.Proveedor
                                .Numero = e.Numero
                                .DocDate = e.DocDate
                                .Termino = e.Termino
                                .Comprobante = e.Comprobante
                                .Itbis = e.Impuesto
                                .Grabado = Decimal.Round(e.Impuesto / (getItbis / 100), 2)
                                .Excento = Decimal.Round((e.Monto - e.Descuento) - (e.Impuesto / (getItbis / 100)), 2)
                                .Descuento = e.Descuento
                                .Sucursal = e.SucCode
                                .UseTransaction = False

                                '// POSTEO EN DOLARES
                                If e.TipoTransaccion = "CUS" Then
                                    .Monto = e.Monto * e.Tasa
                                Else
                                    .Monto = e.Monto
                                End If
                            End With

                            opostcxp.AplicarFacturas(opostparam)
                        Else
                            Dim opostparam As SGT.CXP.Posteos.PostDocument.ParametrosCrearNC

                            opostcxp = New SGT.CXP.Posteos.PostDocument
                            opostparam = New SGT.CXP.Posteos.PostDocument.ParametrosCrearNC

                            With opostparam
                                .TipoDocumento = e.TipoTransaccion
                                .Termino = e.Termino
                                .DocDate = e.DocDate
                                .Monto = e.Monto
                                .Itbis = e.Impuesto
                                .Grabado = Decimal.Round(e.Impuesto / (getItbis / 100), 2)
                                .Excento = Decimal.Round((e.Monto - e.Descuento) - (e.Impuesto / (getItbis / 100)), 2)
                                .Descuento = e.Descuento
                                .Numero = e.Numero
                                .Proveedor = e.Proveedor
                                .DevolucionSerial = e.Serial
                                .Sucursal = e.SucCode
                                .UseTransaction = False
                            End With

                            opostcxp.CrearNC(opostparam)
                        End If
                    End If
                End If

                oUnidad = New Entidades.UnidadMedida
                Dim LineNo As Integer = 1

                For Each oItem As Common.ItemInventory In e.Productos
                    '// Insertar del detalle de la tabla de transacción de inventario
                    LineNo += 1
                    oivtranrd = New LibX.Data.XInsertStmt("ivtranrd")
                    oivtranrd!item_code = oItem.ItemID
                    oivtranrd!trane_number = xNumber
                    oivtranrd!line_no = LineNo
                    oivtranrd!whse_code = oItem.Wh
                    oivtranrd!qty = oItem.Qty
                    oivtranrd!unit_code = oItem.Unidad
                    oivtranrd!costo = oItem.PurchCost
                    oivtranrd!price = oItem.Price
                    oivtranrd!bf_onhand = oItem.OnHand
                    oivtranrd!factor = oItem.FacTor

                    oivtranrd.Execute()

                    '// Actualizar la existencia del producto        
                    oSelect = New LibX.Data.XSelecStmt("ivitemd", String.Concat("select * from ivitemd where item_code = '", _
                                                        oItem.ItemID.ToString, "' and whse_code = ", oItem.Wh.ToString))

                    oivitemd = oSelect.GetDataRow()
                    oivitemd!avg_cost = 0
                    oivitemd!last_cost = oivitemd!purch_cost
                    oivitemd!datelast_purch = DateSerial(Year(e.DocDate), Month(e.DocDate), Day(e.DocDate))

                    '// Actualizar existencia de producto
                    oUpdate = New LibX.Data.XUpdateStmt("ivitemd")

                    Select Case e.TipoTransaccion
                        Case "CUS", "PDI" '// Entradas de almacen internacional
                            Dim oTable1 As DataTable

                            '// Insertar existencia
                            '// Actualizar los datos de costo del producto
                            oivitemd!last_cost = Val(oivitemd!purch_cost.ToString)
                            oivitemd!purch_cost = oItem.PurchCost
                            oivitemd!costus = oItem.Cost
                            oivitemd!impto = oItem.Impto
                            oivitemd!price = oItem.Price
                            oivitemd!benef = oItem.Beneficio
                            oivitemd!datelast_purch = DateSerial(Year(e.DocDate), Month(e.DocDate), Day(e.DocDate))

                            '// Actualizar Existencia
                            oivitemd!existencia = Val(oivitemd!existencia.ToString) + _
                                    oItem.Qty

                            oUpdate.FieldsSet("last_cost") = oivitemd!last_cost
                            oUpdate.FieldsSet("purch_cost") = oivitemd!purch_cost
                            oUpdate.FieldsSet("price") = oivitemd!price
                            oUpdate.FieldsSet("costus") = oivitemd!costus
                            oUpdate.FieldsSet("impto") = oivitemd!impto
                            oUpdate.FieldsSet("benef") = oivitemd!benef
                            oUpdate.FieldsSet("Tasa") = e.Tasa

                            If Not LibX.IsNull(oivitemd!datelast_purch) Then
                                oUpdate.FieldsSet("datelast_purch") = oivitemd!datelast_purch
                            End If

                        Case "CRD" 'Entrada de almacen Local
                            Dim oTable1 As DataTable

                            '// Insertar existencia
                            '// Actualizar Existencia
                            oivitemd!existencia = Val(oivitemd!existencia.ToString) + _
                                    (oItem.Qty * oUnidad.GetFactor(oItem.ItemID, oItem.Unidad))

                            oUpdate.FieldsSet("last_cost") = oivitemd!last_cost
                            oUpdate.FieldsSet("purch_cost") = oItem.PurchCost
                            oUpdate.FieldsSet("price") = oItem.Price
                            oUpdate.FieldsSet("benef") = oItem.Beneficio

                            If Not LibX.IsNull(oivitemd!datelast_purch) Then
                                oUpdate.FieldsSet("datelast_purch") = oivitemd!datelast_purch
                            End If


                        Case "FCT", "FPV", "FSG" '// Facturas, Facturas Punto de Venta

                            'If oivitemd!existencia <= 0 Then
                            '    Throw New ApplicationException(String.Format("No hay existencia disponible para este producto {0}", oItem.ItemID))
                            'End If

                            oivitemd!datelast_sales = DateSerial(Year(e.DocDate), Month(e.DocDate), Day(e.DocDate))

                            '// Actualizar Existencia
                            oivitemd!existencia = Val(oivitemd!existencia.ToString) - _
                                    (oItem.Qty * oUnidad.GetFactor(oItem.ItemID, oItem.Unidad))

                            If Not LibX.IsNull(oivitemd!datelast_sales) Then
                                oUpdate.FieldsSet("datelast_sales") = oivitemd!datelast_sales
                            End If

                            ''SubstractOnHand(oItem)

                        Case "TRF"
                            '// Actualizar Existencia
                            oivitemd!existencia = Val(oivitemd!existencia.ToString) + _
                                    (oItem.Qty * oUnidad.GetFactor(oItem.ItemID, oItem.Unidad))


                        Case Else
                            Select Case oType.Entrada
                                Case True
                                    '// Actualizar Existencia
                                    oivitemd!existencia = Val(oivitemd!existencia.ToString) + _
                                            (oItem.Qty * oUnidad.GetFactor(oItem.ItemID, oItem.Unidad))

                                Case False
                                    '// Actualizar Existencia
                                    'If Val(oivitemd!existencia.ToString.Trim) <= 0 Then
                                    '    Throw New ApplicationException(String.Format("No hay existencia disponible para este producto {0}", oItem.ItemID))
                                    'End If

                                    'If Val(oivitemd!existencia.ToString.Trim) < (oItem.Qty * oUnidad.GetFactor(oItem.ItemID, oItem.Unidad)) Then
                                    '    Throw New ApplicationException(String.Format("No hay existencia disponible para este producto {0}, existencia = {1}, cantidad a rebajar = {2}", oItem.ItemID, Val(oivitemd!existencia.ToString.Trim), (oItem.Qty * oUnidad.GetFactor(oItem.ItemID, oItem.Unidad))))
                                    'End If

                                    oivitemd!existencia = Val(oivitemd!existencia.ToString) - _
                                            (oItem.Qty * oUnidad.GetFactor(oItem.ItemID, oItem.Unidad))
                            End Select
                    End Select

                    oUpdate.FieldsSet("existencia") = oivitemd!existencia
                    oUpdate.FieldsSet("avg_cost") = oivitemd!avg_cost

                    oUpdate.Fields("item_code") = oivitemd!item_code
                    oUpdate.Fields("whse_code") = oivitemd!whse_code

                    oUpdate.Execute()
                    ''//Activar el WebServices las actualizar los precios de los productos en las sucursales
                    If e.WebTrasnf = True Then
                        EntviarProducto(oivitemd!item_code)
                    End If
                Next

                '// Aplicar Vencimiento
                If e.TipoTransaccion <> "TRF" And e.TipoTransaccion <> "ADJ" And e.TipoTransaccion <> "SAL" Then
                    AplicarVencimiento(e.Serial, False, e.TipoTransaccion)
                End If

                If e.UseTransaction And LibX.Data.Manager.Connection.IsIntransaction = True Then
                    LibX.Data.Manager.Connection.CommitTransaction()
                End If
                Return True

            Catch ex As Exception
                If e.UseTransaction And LibX.Data.Manager.Connection.IsIntransaction = True Then
                    LibX.Data.Manager.Connection.RollBackTransaction()
                End If

                LibX.Log.Add(ex)
            End Try
        End Function

        Public Function AddOnHand(ByVal e As ItemInventory)
            Dim oTable As DataTable
            Dim Qty As Integer
            Try
                oTable = GetTableonhand(e, False)

                Qty = e.Qty

                For Each oRow As DataRow In oTable.Rows
                    oRow!onhand += Qty
                    Qty = 0
                    If Qty = 0 Then
                        Exit For
                    End If
                Next

                LibX.Data.Manager.Save(oTable)

            Catch ex As Exception
                LibX.Log.Add(ex)

            End Try

        End Function

        Public Function SubstractOnHand(ByVal e As ItemInventory)
            Dim oTable As DataTable
            Dim Qty As Integer
            Try
                oTable = GetTableonhand(e)

                Qty = e.Qty

                For Each oRow As DataRow In oTable.Rows
                    If oRow!onhand > Qty Then
                        oRow!onhand -= Qty
                        Qty = 0
                    Else
                        Qty -= oRow!onhand
                        oRow!onhand = 0
                    End If

                    If Qty = 0 Then
                        Exit For
                    End If
                Next

                LibX.Data.Manager.Save(oTable)

            Catch ex As Exception
                LibX.Log.Add(ex)

            End Try

        End Function

        Private Function GetTableonhand(ByVal e As ItemInventory, Optional ByVal CheckonHand As Boolean = True) As DataTable
            Dim oSelect As LibX.Data.XSelecStmt
            Dim oTable As DataTable
            Dim xNumber As Integer
            Dim SelectStatment As String
            Try
                SelectStatment = String.Concat("select * from ivonhndm ", _
                                               " where whse_code = " & e.Wh.ToString, _
                                               "   and item_code = '" & e.ItemID.ToString, "'")
                If CheckonHand = True Then
                    SelectStatment = String.Concat(SelectStatment.Trim & "  and onhand > 0")
                End If

                If Configuration.GetCostMethdo = Common.CostMethod.FIFO Then
                    SelectStatment = String.Concat(SelectStatment, " order by purch_date ASC")
                End If

                If Configuration.GetCostMethdo = Common.CostMethod.LIFO Then
                    SelectStatment = String.Concat(SelectStatment, " order by purch_date DESC")
                End If

                If Configuration.GetCostMethdo = Common.CostMethod.PP Then
                    SelectStatment = String.Concat(SelectStatment, " order by purch_date ASC")
                End If

                oSelect = New LibX.Data.XSelecStmt("ivonhndm", SelectStatment)
                oTable = oSelect.GetTable(True)

                If oTable.Rows.Count <= 0 Then
                    Throw New ApplicationException("No existen entradas para este producto")
                End If

                Return oTable

            Catch ex As Exception
                LibX.Log.Add(ex)
                Return Nothing
            End Try
        End Function

        Public Function GetAveragCost(ByVal e As ItemInventory) As DataTable
            Dim oSelect As LibX.Data.XSelecStmt
            Dim oTable As DataTable
            Dim xNumber As Integer
            Dim SelectStatment As String
            Try
                SelectStatment = String.Concat("select * from ivonhndm ", _
                                               " where whse_code = " & e.Wh.ToString, _
                                               "   and item_code = '" & e.ItemID.ToString, "'", _
                                               "   and onhand > 0")


                If Configuration.GetCostMethdo = Common.CostMethod.FIFO Then
                    SelectStatment = String.Concat(SelectStatment, " order by purch_date ASC")
                End If

                If Configuration.GetCostMethdo = Common.CostMethod.LIFO Then
                    SelectStatment = String.Concat(SelectStatment, " order by purch_date DESC")
                End If

                If Configuration.GetCostMethdo = Common.CostMethod.PP Then
                    SelectStatment = String.Concat(SelectStatment, " order by purch_date ASC")
                End If

                oSelect = New LibX.Data.XSelecStmt("ivonhndm", SelectStatment)
                oTable = oSelect.GetTable(True)

                If oTable.Rows.Count <= 0 Then
                    Throw New ApplicationException("No existen entradas para este producto")
                End If

                Return oTable

            Catch ex As Exception
                LibX.Log.Add(ex)
                Return Nothing
            End Try
        End Function
        Public Function ValidarEtiqueta(ByVal Numero As String) As Boolean
            Dim xNumber As Integer
            Dim SelectStatment As String
            Try
                SelectStatment = "select count(*) from ivetiqm where fact_no = '" & Numero & "'"
                xNumber = LibX.Data.Manager.GetScalar(SelectStatment)
                If xNumber > 0 Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                LibX.Log.Add(ex)
                Return Nothing
            End Try
        End Function
        Public Function EntviarProducto(ByVal WSitemCode As String) As Boolean
            Dim wsSGF1 As wsSGF1.WSSGF1

            Dim oDataSet As DataSet

            Dim oTableIvitemm As DataTable
            Dim oTableivitemd As DataTable
            Dim oTableivreferm As DataTable
            Dim oTableivcbarram As DataTable
            Dim oTableivunitd As DataTable
            Dim oRemote As DataTable

            Try

                '// ivitemm
                oTableIvitemm = LibX.Data.Manager.GetDataTable("select * from ivitemm where item_code ='" & WSitemCode & "'", "ivitemm")
                '// ivitemd
                oTableivitemd = LibX.Data.Manager.GetDataTable("select * from ivitemd where item_code ='" & WSitemCode & "' and whse_code = " & LibX.User.WhDefault, "ivitemd")
                '// ivreferm
                oTableivreferm = LibX.Data.Manager.GetDataTable("select * from ivreferm where item_code ='" & WSitemCode & "'", "ivreferm")
                '// ivcbarram
                oTableivcbarram = LibX.Data.Manager.GetDataTable("select * from ivcbarram where item_code ='" & WSitemCode & "'", "ivcbarram")
                '// ivunitd
                oTableivunitd = LibX.Data.Manager.GetDataTable("select * from ivunitd where item_code ='" & WSitemCode & "'", "ivunitd")

                '// DataSet
                oDataSet = New DataSet("dsSGF1")
                '// Tablas
                oDataSet.Tables.Add(oTableIvitemm)
                oDataSet.Tables.Add(oTableivitemd)
                oDataSet.Tables.Add(oTableivreferm)
                oDataSet.Tables.Add(oTableivcbarram)
                oDataSet.Tables.Add(oTableivunitd)

                wsSGF1 = New wsSGF1.WSSGF1

                oRemote = LibX.Data.Manager.GetDataTable("select * from scremote where estatus = 1")

                If oRemote Is Nothing Then
                    Throw New ApplicationException("No hay estaciones remotas configuradas!")
                End If

                If oRemote.Rows.Count <= 0 Then
                    Throw New ApplicationException("No hay estaciones remotas configuradas!")
                End If

                For Each oRow As DataRow In oRemote.Rows
                    wsSGF1.Url = oRow!url.ToString.Trim
                    wsSGF1.Credentials = System.Net.CredentialCache.DefaultCredentials
                    If wsSGF1.InsertarMaestro(oDataSet) Then
                    End If
                Next

            Catch ex As Exception
                Throw
            End Try
        End Function
    End Class
End Namespace