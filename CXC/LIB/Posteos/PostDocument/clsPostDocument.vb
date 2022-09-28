Imports SGT.CXC.Entidades

Public Class PostDocument
    Public Class ParametrosAplicar
        Inherits SGT.CXC.Entidades.Factura
        Public SerialAfect As Long
        Public mSerial As Long
        Public SucCode As Integer
        Public PagoPorAdelantado As Boolean
        Public UseTransaction As Boolean
        Public ClienteOrigen As Long
        Public CrearBalance As Boolean = True
    End Class

    Public Class ParametrosPagos
        Inherits SGT.CXC.Entidades.Recibo
        Public Documentos As New Entidades.CollectionFacturas
        Public UseTransaction As Boolean
    End Class

    Public Class ParametrosAnular
        Public TipoDocumento As String
        Public Serial As Long
        Public SucCode As Integer
        Public Cliente As Integer
        Public PagoPorAdelantado As Integer
        Public UseTransaction As Boolean
    End Class

    Public Class ParametroAplicarCredito
        Public TipoDocumento As String
        Public Serial As Long
        Public SucCode As Integer
        Public SerialAfect As Long
        Public Fecha As Date
        Public Monto As Decimal
        Public Itbis As Decimal
        Public Descuento As Decimal
        Public Estatus As Integer = Val(EstatusDoucmento.Aplicada)
    End Class

#Region "Aplicar"


    Public Function TransferirFacturas(ByVal e As ParametrosAplicar) As Boolean
        Dim oTable As DataTable
        Dim occfttypm As DataRow
        Dim XUpdateBalanceC As LibX.Data.XUpdateStmt
        Dim XUpdateBalanceF As LibX.Data.XUpdateStmt
        Dim XSelect As LibX.Data.XSelecStmt
        Dim SelectStmt As String

        Dim oDoc As SGT.Inventario.Entidades.Documento

        Dim oRow As DataRow
        Dim Balance, Monto As Decimal
        Dim lSerial As Integer
        Dim oTable1 As DataTable

        Dim Origen As Integer


        Try
            'verifica el balance de la factura
            SelectStmt = " select ccopend.balance, ccopend.amount, ccopend.disc_amount,ccopend.itbis_amount " & _
                         " from ccopend" & _
                         " where invce_serial=" & e.Serial

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Throw New ApplicationException("Error buscando cliente")
            End If

            Balance = Val(oRow!balance.ToString)
            Monto = Val(oRow!amount.ToString) - Val(oRow!disc_amount.ToString.Trim) + Val(oRow!itbis_amount.ToString.Trim)

            If Balance < Monto Then
                Throw New ApplicationException(" No se puede Transferir esta factura. Pues tiene un abono!!")
            End If

            '// Aplicar factura al nuevo cliente
            lSerial = e.Serial
            AplicarFacturas(e)

            'actualiza el balance de la factura origen 
            XUpdateBalanceC = New LibX.Data.XUpdateStmt("ccinvcem")
            XUpdateBalanceC.FieldsSet("invce_status") = Val(EstatusDoucmento.Transferido)  '// Transferido
            XUpdateBalanceC.FieldsSet("amount") = 0
            XUpdateBalanceC.FieldsSet("itbis") = 0
            XUpdateBalanceC.FieldsSet("amount_grab") = 0
            XUpdateBalanceC.FieldsSet("amount_excent") = 0
            XUpdateBalanceC.FieldsSet("cargo_banc") = 0
            XUpdateBalanceC.FieldsSet("cargo_desc") = 0
            XUpdateBalanceC.FieldsSet("excento") = 0
            XUpdateBalanceC.FieldsSet("impto") = 0
            XUpdateBalanceC.FieldsSet("total_amount") = 0
            XUpdateBalanceC.Fields("invce_serial") = lSerial
            XUpdateBalanceC.Fields("suc_code") = e.SucCode
            XUpdateBalanceC.Fields("invce_datetran") = LibX.Data.Manager.GetScalar("select getdate()")
            XUpdateBalanceC.Execute()
            XUpdateBalanceC.Dispose()

            'actualiza el balance de la factura origen 
            XUpdateBalanceC = New LibX.Data.XUpdateStmt("ccopend")
            XUpdateBalanceC.FieldsSet("amount") = 0
            XUpdateBalanceC.FieldsSet("disc_amount") = 0
            XUpdateBalanceC.FieldsSet("balance") = 0
            XUpdateBalanceC.FieldsSet("disc_balance") = 0
            XUpdateBalanceC.FieldsSet("excento") = 0
            XUpdateBalanceC.FieldsSet("impto") = 0
            XUpdateBalanceC.FieldsSet("itbis_amount") = 0
            XUpdateBalanceC.FieldsSet("itbis_balance") = 0
            XUpdateBalanceC.Fields("invce_serial") = lSerial
            XUpdateBalanceC.Fields("suc_code") = e.SucCode
            XUpdateBalanceC.Execute()
            XUpdateBalanceC.Dispose()

            '// Determinar el origen del documento
            oDoc = New SGT.Inventario.Entidades.Documento(e.TipoDocumento)
            Origen = oDoc.Origen

            '// buscar el cliente origen  y actualizar su balance
            SelectStmt = "select * from cccustm where cust_code = " & e.ClienteOrigen.ToString
            XSelect = New LibX.Data.XSelecStmt("cccustm", SelectStmt)
            oTable = XSelect.GetTable(True)

            If oTable Is Nothing Then
                Throw New ApplicationException("No se encontró cliente con este código")
            End If

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No se encontró cliente con este código")
            End If

            'TODO // Determinar el origen del documento y aplicar segun el documento
            oTable.Rows(0)!balance = Val(oTable.Rows(0)!balance.ToString) + (Monto * -1)

            LibX.Data.Manager.Save(oTable)

            Return True

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False

        End Try
    End Function

    Public Function AplicarCredito(ByVal e As ParametroAplicarCredito) As Boolean
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim oRow As DataRow
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim XInsert As LibX.Data.XInsertStmt
        Dim oDocumento As SGT.Inventario.Entidades.Documento
        Try
            SelectStmt = "select * from ccopend " & _
                         " where invce_serial = " & e.Serial.ToString

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt, "ccopend", True)

            If oTable Is Nothing Then
                Throw New ApplicationException("Error buscando nota de crédito")
            End If

            oTable.Rows(0)!itbis_balance += e.Itbis
            oTable.Rows(0)!balance += (e.Monto + e.Descuento)
            ''oTable.Rows(0)!balance += e.Monto
            ''oTable.Rows(0)!disc_balance += Format(e.Descuento, "##,##0.00")
            oTable.Rows(0)!last_pay_date = e.Fecha
            If oTable.Rows(0)!balance = 0 Then
                oTable.Rows(0)!disc_balance = 0
            End If

            If oTable.Rows(0)!balance < 0 Then
                oTable.Rows(0)!balance = 0
            End If

            oDocumento = New SGT.Inventario.Entidades.Documento(e.TipoDocumento)

            XUpdate = New LibX.Data.XUpdateStmt("ccinvcem")

            If Val(oTable.Rows(0)!balance.ToString.Trim) <= 0 Then
                XUpdate.FieldsSet("invce_status") = EstatusDoucmento.Saldado
                XUpdate.FieldsSet("invce_datetran") = LibX.Data.Manager.GetScalar("select getdate()")
            Else
                XUpdate.FieldsSet("invce_status") = EstatusDoucmento.Aplicada
            End If
            XUpdate.Fields("invce_serial") = e.Serial

            XUpdate.Execute()

            LibX.Data.Manager.Save(oTable)

            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False
        End Try
    End Function

    Public Function Aplicar(ByVal e As ParametrosAplicar) As Boolean
        Try
            Select Case e.TipoDocumento
                Case "FCT", "FPV", "FSG", "FTS", "EST", "NCC"
                    AplicarFacturas(e)
                Case "RCB", "DCC", "RSM", "RPS"
                    AplicarPago(e)
                Case "DVF", "DEV"
                    If e.SerialAfect > 0 Then
                        AplicarDevolucion(e)
                    Else
                        AplicarFacturas(e)
                    End If
            End Select

            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False
        End Try
    End Function

    Public Function AplicarCXC(ByVal e As ParametrosAplicar) As Boolean
        Try
            Select Case e.TipoDocumento
                Case "FCT"
                    CrearBalance(e)
                Case "NCC"
                    AplicarPago(e)
                Case "RCB", "DCC", "RSM", "RPS"
                    AplicarPago(e)
            End Select

            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False
        End Try
    End Function

    Public Function AplicarFacturas(ByVal e As ParametrosAplicar) As Boolean
        Dim oTable As DataTable
        Dim occfttypm As DataRow
        Dim XSelect As LibX.Data.XSelecStmt
        Dim XInsert As LibX.Data.XInsertStmt

        Dim SelectStmt As String
        Dim XSerial As Long, Origen As Integer
        Dim Excento As Decimal, Grabado As Decimal, DescuentoPP As Decimal

        Dim oDoc As SGT.Inventario.Entidades.Documento
        Dim oTerm As SGT.CXC.Entidades.Termino
        Dim oCliente As SGT.CXC.Entidades.Cliente
        Dim oParamExcede As SGT.CXC.Entidades.Cliente.ParametrosExcedeLimite
        Dim oParamEstadoCliente As SGT.CXC.Entidades.Cliente.ParametrosEstadoCliente
        Dim mConfig As New SGT.Inventario.Common.Configuration

        Try
            '// Determinar el origen del documento
            oDoc = New SGT.Inventario.Entidades.Documento(e.TipoDocumento)
            oCliente = New SGT.CXC.Entidades.Cliente(e.Cliente)

            oParamExcede = New SGT.CXC.Entidades.Cliente.ParametrosExcedeLimite

            With oParamExcede
                .Cliente = e.Cliente
                If e.TipoDocumento = "DEV" Then
                    .MontoAplicar = e.Monto * -1
                Else
                    .MontoAplicar = e.Monto
                End If
            End With

            If oCliente.ExcedeLimite(oParamExcede) = True And e.TipoDocumento <> "DEV" Then
                Throw New ApplicationException("Esta transacción excede el límite de crédito")
            End If

            If e.Termino.Trim.Length <= 0 Then
                e.Termino = oCliente.Termino
            End If

            oTerm = New SGT.CXC.Entidades.Termino(e.Termino)
            Origen = oDoc.Origen

            If oCliente.StoAbono = 1 Or oCliente.StoCheque = 1 Or oCliente.StoVenci = 1 Then
                oParamEstadoCliente = New SGT.CXC.Entidades.Cliente.ParametrosEstadoCliente

                With oParamEstadoCliente
                    .Cliente = e.Cliente
                    .DiaTermino = oTerm.DiasDescuento + oCliente.DiasGracia
                End With

                If oCliente.EstadoCliente(oParamEstadoCliente) = True And e.TipoDocumento <> "DEV" Then
                    Throw New ApplicationException("Este CLiente Tiene Documento Vencido")
                End If
            End If

            '// Insertar el documento en la tabla de cuenta por cobrar
            '// Calcular Grabado y Excento        
            '// insetar en la tabla de cuenta x pagar
            XInsert = New LibX.Data.XInsertStmt("ccinvcem", "invce_serial")

            If e.Termino.Trim.Length > 0 Then
                XInsert!term_code = e.Termino.Trim
            End If

            XInsert!cust_code = e.Cliente
            XInsert!type_code = e.TipoDocumento
            XInsert!invce_no = e.Numero
            XInsert!detail = oDoc.Name
            XInsert!invce_date = e.Fecha
            XInsert!suc_code = e.SucCode
            XInsert!invce_ncf = e.NCF
            XInsert!invce_create = LibX.Data.Manager.GetScalar("select getdate()")

            If Not oTerm Is Nothing Then
                XInsert!due_date = oTerm.CalcularVencimiento(e.Fecha)
            End If
            If e.TipoDocumento = "DEV" Then
                XInsert!amount = e.Monto * -1
                XInsert!itbis = e.Impuesto * -1
                XInsert!cargo_desc = e.Descuento
                XInsert!total_amount = ((e.Monto - e.Descuento) + e.Impuesto) * -1
                XInsert!invce_status = Val(EstatusDoucmento.Aplicada)  '// Aplicado

                '// Calcular Excento y Grabado
                Grabado = (e.Impuesto / (mConfig.GetITBIS / 100)) * -1
                Excento = (e.Monto) - Grabado
            Else
                XInsert!amount = e.Monto
                XInsert!itbis = e.Impuesto
                XInsert!cargo_desc = e.Descuento
                XInsert!total_amount = (e.Monto - e.Descuento) + e.Impuesto
                XInsert!invce_status = Val(EstatusDoucmento.Aplicada)  '// Aplicado

                '// Calcular Excento y Grabado
                Grabado = e.Impuesto / (mConfig.GetITBIS / 100)
                Excento = (e.Monto) - Grabado

            End If
            If Excento < 0 Then
                Excento = 0
            End If
            If Grabado < 0 Then
                Grabado = 0
            End If

            XInsert!excento = Excento
            XInsert!impto = Grabado

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            XSerial = XInsert.Execute
            XInsert.Dispose()

            e.Serial = XSerial

            CrearBalance(e)

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If
            Return True

        Catch ex As Exception
            LibX.Log.Add(ex)
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
            Return False

        End Try
    End Function

    Public Function CrearNotaCredito(ByVal e As ParametrosAplicar) As Boolean
        Dim oTable As DataTable
        Dim occfttypm As DataRow
        Dim XSelect As LibX.Data.XSelecStmt
        Dim XInsert As LibX.Data.XInsertStmt

        Dim SelectStmt As String
        Dim XSerial As Long, Origen As Integer
        Dim Excento, Grabado As Decimal

        Dim oDoc As SGT.Inventario.Entidades.Documento
        Dim oTerm As SGT.CXC.Entidades.Termino
        Dim oCliente As SGT.CXC.Entidades.Cliente
        Dim oParamExcede As SGT.CXC.Entidades.Cliente.ParametrosExcedeLimite

        Try
            '// Determinar el origen del documento
            oDoc = New SGT.Inventario.Entidades.Documento(e.TipoDocumento)
            oCliente = New SGT.CXC.Entidades.Cliente
            oParamExcede = New SGT.CXC.Entidades.Cliente.ParametrosExcedeLimite

            If e.Termino.Trim.Length > 0 Then
                oTerm = New SGT.CXC.Entidades.Termino(e.Termino)
            End If

            Origen = oDoc.Origen

            '// Insertar el documento en la tabla de cuenta por pagar
            '// Calcular Grabado y Excento        
            '// insetar en la tabla de cuenta x pagar
            XInsert = New LibX.Data.XInsertStmt("ccinvcem", "invce_serial")
            If e.Termino.Trim.Length > 0 Then
                XInsert!term_code = e.Termino.Trim
            End If

            XInsert!cust_code = e.Cliente
            XInsert!type_code = e.TipoDocumento
            XInsert!invce_no = e.Numero
            XInsert!suc_code = e.SucCode
            XInsert!detail = oDoc.Name
            XInsert!invce_date = e.Fecha
            XInsert!invce_create = LibX.Data.Manager.GetScalar("select getdate()")

            If Not oTerm Is Nothing Then
                XInsert!due_date = oTerm.CalcularVencimiento(e.Fecha)
            End If

            XInsert!total_amount = e.Monto
            XInsert!amount = e.Monto
            XInsert!cargo_desc = e.Descuento
            XInsert!itbis = e.Impuesto
            XInsert!invce_status = Val(EstatusDoucmento.Aplicada)  '// Aplicada

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            XSerial = XInsert.Execute
            XInsert.Dispose()

            e.Serial = XSerial

            If e.CrearBalance = True Then
                CrearBalance(e)
            End If

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If
            Return True

        Catch ex As Exception
            LibX.Log.Add(ex)
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
            Return False

        End Try
    End Function

    Public Function CrearBalance(ByVal e As ParametrosAplicar) As Boolean
        Dim oTable As DataTable
        Dim occfttypm As DataRow
        Dim XSelect As LibX.Data.XSelecStmt
        Dim XInsert As LibX.Data.XInsertStmt
        Dim SelectStmt As String

        Dim XSerial As Long, Origen As Integer
        Dim Excento, Grabado As Decimal
        Dim DescuentoPP As Decimal

        Dim oDoc As SGT.Inventario.Entidades.Documento
        Dim oCliente As SGT.CXC.Entidades.Cliente
        Dim oTerm As SGT.CXC.Entidades.Termino

        Try

            XInsert = New LibX.Data.XInsertStmt("ccopend")

            '// Determinar el origen del documento
            oDoc = New SGT.Inventario.Entidades.Documento(e.TipoDocumento)
            oCliente = New SGT.CXC.Entidades.Cliente(e.Cliente)

            If e.Termino.Trim.Length > 0 Then
                oTerm = New SGT.CXC.Entidades.Termino(e.Termino)
            End If

            Origen = oDoc.Origen

            If Not oTerm Is Nothing Then
                XInsert!due_date = oTerm.CalcularVencimiento(e.Fecha)
                If oCliente.OtroDescuento Then
                    DescuentoPP = cAlcularDescuentoProductos(e.mSerial, e.Cliente)
                Else
                    DescuentoPP = (e.Monto + e.Impuesto) * (oTerm.PorcDescuento / 100)
                End If
                XInsert!disc_date = oTerm.CalcularFechaDescuento(e.Fecha)
            End If

            XInsert!invce_serial = e.Serial
            XInsert!cust_code = e.Cliente
            XInsert!suc_code = e.SucCode
            XInsert!open_desc = oDoc.Name
            XInsert!doc_date = e.Fecha
            XInsert!amount = ((e.Monto - e.Descuento) + e.Impuesto) * Origen
            XInsert!itbis_amount = e.Impuesto * Origen
            XInsert!itbis_balance = e.Impuesto * Origen
            XInsert!disc_amount = (DescuentoPP * Origen)
            XInsert!disc_balance = (DescuentoPP * Origen)
            XInsert!balance = ((e.Monto - e.Descuento) + e.Impuesto) * Origen

            XInsert!excento = 0
            XInsert!impto = 0

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            XInsert.Execute()
            XInsert.Dispose()

            '// buscar el proveedor y actualizar su balance
            SelectStmt = "select * from cccustm where cust_code = " & e.Cliente.ToString
            XSelect = New LibX.Data.XSelecStmt("cccustm", SelectStmt)
            oTable = XSelect.GetTable(True)

            If oTable Is Nothing Then
                Throw New ApplicationException("No se encontró cliente con este código")
            End If

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No se encontró cliente con este código")
            End If

            'TODO // Determinar el origen del documento y aplicar segun el documento
            oTable.Rows(0)!balance = Val(oTable.Rows(0)!balance.ToString) + (((e.Monto - e.Descuento) + e.Impuesto) * Origen)
            oTable.Rows(0)!last_sell_date = e.Fecha

            LibX.Data.Manager.Save(oTable)

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If
            XSelect.Dispose()

            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If

            Return False

        End Try
    End Function
    Public Function AplicarNC(ByVal e As ParametrosAplicar) As Boolean
        Dim oParamCredito As ParametroAplicarCredito
        Dim xSelect As LibX.Data.XSelecStmt
        Dim oTable, oTable1 As DataTable
        Dim oRow As DataRow
        Try

            oParamCredito = New ParametroAplicarCredito

            '// buscar el cliente
            xSelect = New LibX.Data.XSelecStmt("cccustm")
            xSelect.Fields("cust_code") = e.Cliente

            oTable = xSelect.GetTable
            oTable.TableName = "cccustm"

            xSelect.Dispose()
            If oTable Is Nothing Then
                Throw New ApplicationException("Error buscando cliente!")
            End If

            '// Buscar los documentos a aplicados
            xSelect = New LibX.Data.XSelecStmt("ftfactm")
            xSelect.Fields("ftserial_no") = e.Serial
            xSelect.Fields("suc_code") = e.SucCode

            oTable1 = xSelect.GetTable

            If oTable1 Is Nothing Then
                Throw New ApplicationException("No se encontrarón la devolución!")
            End If

            xSelect.Fields("ftserial_no").value = oTable1.Rows(0)!ftserial_afect
            oRow = xSelect.GetDataRow()

            If oRow Is Nothing Then
                Throw New ApplicationException("No se encontró el documento a afectado!")
            End If

            xSelect.Dispose()

            '// buscar el documento en CXC
            xSelect = New LibX.Data.XSelecStmt("ccinvcem")
            xSelect.Fields("invce_no") = oRow!fact_number
            xSelect.Fields("type_code") = oRow!type_code
            xSelect.Fields("suc_code") = oRow!suc_code

            oRow = xSelect.GetDataRow()
            xSelect.Dispose()

            '// iniciar la transaccion
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            With oParamCredito
                .TipoDocumento = e.TipoDocumento
                .Serial = oRow!invce_serial
                .Fecha = e.Fecha
                .Monto = e.Monto * -1
                .Itbis = 0
                .SucCode = e.SucCode
                .Estatus = Val(EstatusDoucmento.Aplicada)
            End With

            AplicarCredito(oParamCredito)

            oTable.Rows(0)!balance += (e.Monto * -1)
            ''oTable.Rows(0)!balance += ((e.Monto * -1) + (e.Descuento * -1))

            '//Actualizar el cliente
            LibX.Data.Manager.Save(oTable)

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
            Return False

        End Try
    End Function

    Public Function AplicarPago(ByVal e As ParametrosAplicar) As Boolean
        Dim oParamCredito As ParametroAplicarCredito
        Dim xSelect As LibX.Data.XSelecStmt
        Dim SelectStmt As String
        Dim oRowc As DataRow
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim oTable, oTable1 As DataTable

        Dim oParametroCrear As SGT.ControlBancario.Operaciones.PostDocument.ParametrosCrearDocumento
        Dim oPostControlBan As SGT.ControlBancario.Operaciones.PostDocument
        Dim oMovimiento As SGT.Contabilidad.Entidades.Movimientos
        Dim oChequera As SGT.ControlBancario.Entidades.Chequera
        'Dim oSuplidor As SGT.CXP.Entidades.Suplidor
        Dim oNotaCreditoCxp As SGT.CXP.Posteos.PostDocument.ParametrosCrearNC
        Dim oCxpNc As SGT.CXP.Posteos.PostDocument
        Dim oDocumento As SGT.Inventario.Entidades.Documento
        Dim oParametroCodif As SGT.Contabilidad.Entidades.Movimientos.ParametrosCodificacion
        Dim oPeriodoContable As SGT.Contabilidad.Entidades.Periodo.PeriodoStatusEnum
        Try

            oParamCredito = New ParametroAplicarCredito
            oParametroCrear = New SGT.ControlBancario.Operaciones.PostDocument.ParametrosCrearDocumento
            oPostControlBan = New SGT.ControlBancario.Operaciones.PostDocument
            oNotaCreditoCxp = New SGT.CXP.Posteos.PostDocument.ParametrosCrearNC
            oCxpNc = New SGT.CXP.Posteos.PostDocument
            oMovimiento = New SGT.Contabilidad.Entidades.Movimientos
            oParametroCodif = New SGT.Contabilidad.Entidades.Movimientos.ParametrosCodificacion

            SelectStmt = "select ccpaymm.*,cccustm.cust_name,ccpaymd.invce_serial,cccustm.chequera prov_code " & _
                         " from ccpaymm, cccustm,ccpaymd where cccustm.cust_code = ccpaymm.cust_code " & _
                         " and cccustm.cust_code = ccpaymm.cust_code and ccpaymm.paym_serial = ccpaymd.paym_serial " & _
                         " and ccpaymm.paym_serial = " & e.Serial

            oRowc = LibX.Data.Manager.GetDataRow(SelectStmt)

            '// buscar el cliente
            xSelect = New LibX.Data.XSelecStmt("cccustm")
            xSelect.Fields("cust_code") = e.Cliente

            oTable = xSelect.GetTable
            oTable.TableName = "cccustm"

            xSelect.Dispose()
            If oTable Is Nothing Then
                Throw New ApplicationException("Error buscando cliente!")
            End If

            '// Buscar los documentos a aplicados
            xSelect = New LibX.Data.XSelecStmt("ccpaymd")
            xSelect.Fields("paym_serial") = e.Serial
            xSelect.Fields("suc_code") = e.SucCode

            oTable1 = xSelect.GetTable

            xSelect.Dispose()
            If oTable1 Is Nothing Then
                Throw New ApplicationException("No se encontrarón documentos aplicados!")
            End If

            '// iniciar la transaccion
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            '// Aplicar los documentos
            For Each oRow As DataRow In oTable1.Rows
                With oParamCredito
                    .TipoDocumento = e.TipoDocumento
                    .Serial = oRow!invce_serial
                    .Fecha = e.Fecha
                    .SucCode = e.SucCode
                    .Monto = (Val(oRow!Amount.ToString.Trim)) * -1
                    .Descuento = Val(oRow!disc_amount.ToString.Trim) * -1

                    If Not LibX.IsNull(oRow!itbis_amount) Then
                        .Itbis = oRow!itbis_amount * -1
                    Else
                        .Itbis = 0
                    End If
                    .Estatus = Val(EstatusDoucmento.Aplicada)
                End With

                AplicarCredito(oParamCredito)

                oTable.Rows(0)!balance += (oRow!amount * -1) + (Val(oRow!disc_amount.ToString.Trim) * -1)
                ''oTable.Rows(0)!balance += oRow!amount * -1
            Next
            If e.TipoDocumento = "DCC" Or e.TipoDocumento = "RSM" Then
                '// Codificar documento
                With oParametroCodif
                    .TipoDocumento = oRowc!type_code.ToString.Trim
                    .Descuento = Val(oRowc!cargo_desc.ToString.Trim)
                    .Impuesto = Val(oParamCredito.Itbis.ToString.Trim)
                    .MontoBruto = Val(oRowc!amount.ToString.Trim) + Val(oRowc!cargo_desc.ToString.Trim)
                    .MontoNeto = Val(oRowc!amount.ToString.Trim)
                    .Proveedor = oRowc!cust_code
                    .Chequera = oRowc!chequera
                    .Sucursal = oRowc!suc_code
                    .Modtype = "CXC"
                End With

                If oMovimiento.GetCodificacion(oParametroCodif) = False Then
                    Throw New ApplicationException("No se encontro codificación contable para este documento!")
                End If

                '// Enviar a Control Bancario
                With oParametroCrear
                    .Beneficiario = oRowc!cust_name.ToString.Trim
                    .Chequera = oRowc!chequera
                    .Sucursal = oRowc!suc_code
                    .TipoDocumento = oRowc!type_code.ToString.Trim
                    If .TipoDocumento = "DCC" Then
                        .Concepto = "INGRESO DE TARJETA CORRESPONDIENTE A " & oRowc!invce_date
                    Else
                        .Concepto = "RECLAMACION DE SEGURO MEDICOS A " & oRowc!invce_date
                    End If
                    .Fecha = oRowc!invce_date
                    .Monto = Val(oRowc!total_amount.ToString.Trim)
                    .doc_Serial = oRowc!invce_serial
                    .suplidor = oRowc!cust_code
                    If Not LibX.IsNull(oRowc!paym_number) Then .Numero = oRowc!paym_number
                    .CuenasContable = oParametroCodif.RetornoCuentas
                End With

                oPostControlBan.CrearDocumento(oParametroCrear)
            End If
            If e.TipoDocumento = "RPS" Then
                With oNotaCreditoCxp
                    .Descuento = 0
                    .Termino = "30-00"
                    .DevolucionSerial = oRowc!invce_serial
                    .DiscDate = oRowc!invce_date
                    .DocDate = oRowc!invce_date
                    .DueDate = oRowc!invce_date
                    .Excento = Val(oRowc!amount.ToString.Trim)
                    .Grabado = 0
                    .Itbis = 0
                    .Monto = Val(oRowc!amount.ToString.Trim)
                    .Proveedor = oRowc!prov_code.ToString.Trim
                    .Numero = oRowc!paym_number
                    .TipoDocumento = "NCR"
                    .Sucursal = oRowc!suc_code
                    .UseTransaction = True
                End With
                oCxpNc.CrearNC(oNotaCreditoCxp)
            End If

            '//Actualizar el cliente
            oTable.Rows(0)!last_pay_date = e.Fecha
            LibX.Data.Manager.Save(oTable)

            '// Actualizar el Recibo
            XUpdate = New LibX.Data.XUpdateStmt("ccpaymm")
            XUpdate.FieldsSet("invce_status") = EstatusDoucmento.Saldado   '// Aplicado
            XUpdate.FieldsSet("invce_datetran") = LibX.Data.Manager.GetScalar("select getdate()")
            XUpdate.Fields("paym_serial") = e.Serial
            XUpdate.Execute()

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            Return True

        Catch ex As Exception
            LibX.Log.Add(ex)
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
            Return False

        End Try
    End Function

    Public Function AplicarDevolucion(ByVal e As ParametrosAplicar) As Boolean
        Dim oParamCredito As ParametroAplicarCredito
        Dim xSelect As LibX.Data.XSelecStmt
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim oTable, oTable1 As DataTable
        Dim pSerialAfect As Long
        Dim Balance As Decimal
        Dim Aplicado As Decimal = 0
        Dim Pendiente As Decimal = 0
        Dim oRowHeader As DataRow
        Try

            oParamCredito = New ParametroAplicarCredito

            '// Si es una devolucion de Punto de Venta
            '// Crear la nota de credito en ccinvcem
            '// para pagar las facturas afectadas
            'If e.CrearNC = True Then
            e.CrearBalance = False
            CrearNotaCredito(e)

            pSerialAfect = e.SerialAfect
            If pSerialAfect > 0 Then
                oRowHeader = LibX.Data.Manager.GetDataRow("select * from ftfactm " & _
                                                          " where ftserial_no = " & pSerialAfect.ToString.Trim)
                If oRowHeader Is Nothing Then
                    Throw New ApplicationException("NO se encontro este documento")
                End If

                '// determinar si la factura a pagar esta saldada o 
                '// no
                Balance = LibX.Data.Manager.GetScalar("select cast(balance as decimal) from ccopend, ccinvcem " & _
                                            " where ccinvcem.invce_serial = ccopend.invce_serial" & _
                                            "   and ccinvcem.type_code ='" & oRowHeader!type_code.ToString.Trim & "'" & _
                                            "   and ccinvcem.invce_no = " & oRowHeader!fact_number.ToString.Trim)

                '// Si el documento no esta saldado, aplicar la devolucion
                '// de lo contrario buscar el balance del cliente
            End If

            If Balance > 0 Then
                Aplicado = IncluirDocumento(oRowHeader!fact_number, oRowHeader!type_code, e.Serial, e.Monto, e.TipoDocumento, e.Cliente)
                Pendiente = e.Monto - Aplicado
                'oTable1.Rows(0)!fact_cond = 3 '// Devolucion de Credito
            Else
                Balance = Val(LibX.Data.Manager.GetScalar("select cast(balance as decimal) from cccustm " & _
                                            " where cust_code = " & e.Cliente.ToString.Trim).ToString.Trim)
                Pendiente = e.Monto
            End If

            '// si el documento se aplico y queda algun valor pendiente
            '// aplicar a mas documentos pendientes de este cliente

            If Balance > 0 And Pendiente > 0 And oRowHeader!type_code <> "FSG" Then
                oTable = LibX.Data.Manager.GetDataTable("select ccinvcem.* from ccinvcem, ccopend " & _
                                                        " where ccinvcem.invce_serial = ccopend.invce_serial " & _
                                                        "   and ccinvcem.cust_code = " & e.Cliente.ToString.Trim & _
                                                        "   and ccinvcem.invce_no = " & oRowHeader!fact_number.ToString.Trim & _
                                                        "   and ccopend.balance > 0 and ccinvcem.type_code in ('FCT','FTS','FPV','FSG')")

                For Each oRow As DataRow In oTable.Rows
                    Aplicado = IncluirDocumento(oRow!invce_no, oRow!type_code, e.Serial, Pendiente, e.TipoDocumento, e.Cliente)
                    Pendiente -= Aplicado
                    If Pendiente = 0 Then
                        Exit For
                    End If
                Next
                oTable1.Rows(0)!fact_cond = 3 '// Devolucion de Credito
            End If

            '// aplicar documentos luego de creada la devolucion
            'If oTable1.Rows(0)!fact_cond = 2 Then
            AplicarPago(e)

            '// Marcar Devolucion como utilizada
            xUpdate = New LibX.Data.XUpdateStmt("ccinvcem")
            xUpdate.FieldsSet("invce_status") = Val(EstatusDoucmento.Aplicada) '// Aplicada
            xUpdate.FieldsSet("invce_datetran") = LibX.Data.Manager.GetScalar("select getdate()")
            xUpdate.Fields("invce_serial") = e.Serial
            xUpdate.Execute()

            xUpdate.Dispose()
            'Else
            '    CrearNotaCredito(e)
            'End If

            ''''// Actualizar la devolucion
            '''LibX.Data.Manager.Save(oTable1)

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If

            Return False

        End Try
    End Function
#End Region

    Private Function IncluirDocumento(ByVal pNumeroAplicar As Integer, ByVal pTipoAplicar As String, ByVal pSerial As Long, ByVal pMontoAplicar As Decimal, ByVal pTipoDocumentoPadre As String, ByVal pCustCode As Integer) As Decimal
        Dim xInsert As LibX.Data.XInsertStmt
        Dim oRowAplicar As DataTable
        Dim SelectStmt As String
        Dim mSerial As Long
        Dim Monto As Decimal
        Dim line As Integer

        SelectStmt = "select ccopend.* from ccopend " & _
             " inner join ccinvcem on invce_no = " & pNumeroAplicar.ToString & _
             "   and type_code = '" & pTipoAplicar.ToString.Trim & "'" & _
             "   and ccopend.invce_serial = ccinvcem.invce_serial " & _
             "   and ccopend.cust_code = ccinvcem.cust_code "

        oRowAplicar = LibX.Data.Manager.GetDataTable(SelectStmt)

        If oRowAplicar Is Nothing Then
            Throw New ApplicationException("No se encontró el documento a aplicar")
        End If

        '''If Val(oRowAplicar.Rows!Balance.ToString.Trim) <= 0 Then
        '''    Return 0
        '''End If

        For Each oRow As DataRow In oRowAplicar.Rows

            If oRow!balance <= 0 Then
                Return 0
            End If

            line = line + 1
            xInsert = New LibX.Data.XInsertStmt("ccpaymd")

            xInsert.Fields("paym_serial") = pSerial
            xInsert.Fields("type_code") = pTipoDocumentoPadre
            xInsert.Fields("invce_serial") = oRow!invce_serial
            xInsert.Fields("line_no") = line
            xInsert.Fields("suc_code") = oRow!suc_code
            xInsert.Fields("due_date") = oRow!due_date
            xInsert.Fields("mod_type") = "PTV"
            xInsert.Fields("disc_amount") = 0

            If Val(oRow!Balance.ToString.Trim) >= pMontoAplicar Then
                xInsert.Fields("amount") = pMontoAplicar
                xInsert.Fields("balance") = oRow!balance
                Monto = pMontoAplicar
            Else
                xInsert.Fields("amount") = oRow!balance
                xInsert.Fields("balance") = oRow!balance
                Monto = Val(oRow!Balance.ToString.Trim)
            End If

            xInsert.Execute()
        Next

        Return Monto
    End Function
    Private Function cAlcularDescuentoProductos(ByVal pSerial As Long, ByVal pCliente As Integer) As Decimal
        Dim oRowAitem As DataTable
        Dim SelectStmt As String
        Dim mSerial As Long
        Dim mOntoDescto As Decimal
        Dim mdescEtico As Decimal
        Dim mDescGenerico As Decimal
        Dim line As Integer
        Dim oCliente As SGT.CXC.Entidades.Cliente
        Dim oTerm As SGT.CXC.Entidades.Termino

        Try
            oCliente = New SGT.CXC.Entidades.Cliente(pCliente)
            oTerm = New SGT.CXC.Entidades.Termino(oCliente.Termino)

            SelectStmt = "select vw_itemdsct.* from vw_itemdsct " & _
                 " where ftserial_no = " & pSerial

            oRowAitem = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oRowAitem Is Nothing Then
                Throw New ApplicationException("No se encontró el documento a aplicar")
            End If

            For Each oRow As DataRow In oRowAitem.Rows
                If oRow!item_type = 1 Then
                    mdescEtico = (oRow!net_amt + oRow!itbis) * (oTerm.PorcDescuento / 100.0)
                    mDescGenerico = 0
                Else
                    If oRow!item_type = 2 Or oRow!item_type = 0 Then
                        mDescGenerico = (oRow!net_amt + oRow!itbis) * (oTerm.OtroDescuento / 100.0)
                        mdescEtico = 0
                    End If
                End If
                mOntoDescto = mOntoDescto + mDescGenerico + mdescEtico
            Next

            Return mOntoDescto

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
#Region "Anular"
    Public Function Anular(ByVal e As ParametrosAnular) As Boolean
        Try
            Select Case e.TipoDocumento
                Case "FCT"
                    AnularFacturas(e)
                Case "FTS"
                    AnularFacturas(e)
                Case "RCB", "RSM", "DCC"
                    AnularFacturas(e)
                Case "DVF"
                    AnularPago(e)
            End Select


            Return True

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False

        End Try
    End Function

    Public Function AnularPago(ByVal e As ParametrosAnular) As Boolean
        Dim oParamCredito As ParametroAplicarCredito
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim xSelect As LibX.Data.XSelecStmt
        Dim oTable As DataTable
        Dim oTable1 As DataTable
        Try

            oParamCredito = New ParametroAplicarCredito

            '// buscar los documentos aplicados
            xSelect = New LibX.Data.XSelecStmt("ccpaymd")
            xSelect.Fields("paym_serial") = e.Serial
            oTable1 = xSelect.GetTable
            xSelect.Dispose()

            '// buscar el cliente
            xSelect = New LibX.Data.XSelecStmt("cccustm")
            xSelect.Fields("cust_code") = e.Cliente
            oTable = xSelect.GetTable
            oTable.TableName = "cccustm"

            If oTable Is Nothing Then
                Throw New ApplicationException("Error buscando cliente!")
            End If

            xSelect.Dispose()

            '// Iniciar la transaccion
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            '// Aplicar los documentos
            For Each oRow As DataRow In oTable1.Rows
                With oParamCredito
                    .TipoDocumento = e.TipoDocumento
                    .Serial = oRow!invce_serial
                    .Fecha = LibX.Data.Manager.Connection.GetDate
                    .Monto = oRow!amount
                    .SucCode = oRow!suc_code
                    .Estatus = 3 '/Aplicar
                End With

                AplicarCredito(oParamCredito)

                oTable.Rows(0)!balance += oRow!amount
                oRow.Delete()
            Next

            '// Actualizar el balance del cliente
            LibX.Data.Manager.Save(oTable1)

            '// Actualizar el balance del cliente
            LibX.Data.Manager.Save(oTable)

            xUpdate = New LibX.Data.XUpdateStmt("ftfactm")
            xUpdate.FieldsSet("fact_status") = 0 '//Anulado
            xUpdate.Fields("ftserial_no") = e.Serial

            xUpdate.Execute()

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            xUpdate.Dispose()

            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If

            Return False

        End Try
    End Function

    Public Function AnularFacturas(ByVal e As ParametrosAnular) As Boolean
        Dim occopend As DataTable
        Dim occinvcem As DataTable
        Dim oftfactm As DataTable
        Dim occcustm As DataTable

        Dim XSelect As LibX.Data.XSelecStmt

        Dim SelectStmt As String
        Dim Origen As Integer

        Dim oDoc As SGT.Inventario.Entidades.Documento
        Try

            '// buscar el documento en facturación
            XSelect = New LibX.Data.XSelecStmt("ftfactm")
            XSelect.Parameters.Add("ftserial_no", e.Serial)

            oftfactm = XSelect.GetTable(True)

            If oftfactm Is Nothing Then
                Throw New ApplicationException("No existe este documento")
            End If

            If oftfactm.Rows.Count <= 0 Then
                Throw New ApplicationException("No existe este documento")
            End If

            '// Buscar el tipo de documento
            oDoc = New SGT.Inventario.Entidades.Documento(oftfactm.Rows(0)!type_code)

            If oDoc Is Nothing Then
                Throw New ApplicationException("No se encontró este tipo de documento!")
            End If

            '// Buscar el documento en CXC
            XSelect = New LibX.Data.XSelecStmt("ccinvcem")
            XSelect.Parameters.Add("invce_no", oftfactm.Rows(0)!fact_number)
            XSelect.Parameters.Add("suc_code", oftfactm.Rows(0)!suc_code)
            XSelect.Parameters.Add("type_code", oftfactm.Rows(0)!type_code)
            occinvcem = XSelect.GetTable(True)

            If occinvcem Is Nothing Then
                Throw New ApplicationException("No se encontró este documento en CXC")
            End If

            If occinvcem.Rows.Count <= 0 Then
                Throw New ApplicationException("No se encontró este documento en CXC")
            End If

            XSelect = New LibX.Data.XSelecStmt("ccopend")
            XSelect.Parameters.Add("invce_serial", occinvcem.Rows(0)!invce_serial)
            occopend = XSelect.GetTable(True)

            If occopend Is Nothing Then
                Throw New ApplicationException("No se encontró este documento en CXC")
            End If

            If occopend.Rows.Count <= 0 Then
                Throw New ApplicationException("No se encontró este documento en CXC")
            End If

            '// Buscar el cliente
            XSelect = New LibX.Data.XSelecStmt("cccustm")
            XSelect.Parameters.Add("cust_code", oftfactm.Rows(0)!cust_code)
            occcustm = XSelect.GetTable(True)

            If occcustm Is Nothing Then
                Throw New ApplicationException("No se encontró este documento en CXC")
            End If

            If occcustm.Rows.Count <= 0 Then
                Throw New ApplicationException("No se encontró este documento en CXC")
            End If

            '// Anular los documentos
            oftfactm.Rows(0)!fact_status = 0 'Nulo

            occinvcem.Rows(0)!invce_status = 0 'Nulo
            occinvcem.Rows(0)!amount = 0 'Nulo

            occopend.Rows(0)!balance = 0
            occopend.Rows(0)!amount = 0
            occopend.Rows(0)!disc_amount = 0
            occopend.Rows(0)!disc_balance = 0

            '// Actualizar balance cliente
            occcustm.Rows(0)!balance = Val(occcustm.Rows(0)!balance.ToString) + ((Val(occopend.Rows(0)!amount.ToString) * oDoc.Origen) * -1)

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            LibX.Data.Manager.Save(oftfactm)
            LibX.Data.Manager.Save(occinvcem)
            LibX.Data.Manager.Save(occopend)
            LibX.Data.Manager.Save(occcustm)

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            Return True

        Catch ex As Exception
            LibX.Log.Add(ex)
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If

            Return False

        End Try
    End Function
#End Region
End Class
