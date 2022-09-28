Imports System.IO
Public Class HojaConteo
    Public Enum ConteoStatus
        Skip = 1
        Abort = 2
    End Enum

    Public Class ConteoEventArgs
        Inherits EventArgs

        Public Producto As String
        Public ConteoNo As Integer
        Public PaginaNo As Integer
        Public Status As ConteoStatus
        Public TotalRegistros As Integer
        Public RegistroActual As Integer
        Public LineNo As Boolean
    End Class

    Public Event Updating(ByVal e As ConteoEventArgs)
    Public Event Updated(ByVal e As ConteoEventArgs)

    Public Class ParametrosGenerar
        Public Fecha As Date
        Public SelectStmt As String
        Public UseTransaction As Boolean
    End Class
    Public Class ParametrosAplicar
        Public Fecha As Date
        Public ConteNo As Integer
        Public PaginaNo As Integer
        Public UseTransaction As Boolean
        Public Almacen As Integer

    End Class

    Public Class ParametrosCalcular
        Public Producto As String
        Public Almacen As Integer
        Public ConteoNo As Integer
        Public FechaConteo As Date
        Public Existencia As Integer
    End Class

    Public Class ParametrosCargarLote
        Public Almacen As Integer
        Public Descripcion As String
        Public PathAndFileName As String
        Public Retorno As New ValoresRetorno
        Public UseTransaction As Boolean

        Public Class ValoresRetorno
            Public HojaNumero As Integer
            Public Cantidad As Integer
        End Class
    End Class

    Public Function CargarLote(ByVal p_Args As ParametrosCargarLote) As Integer
        Dim xInsert As LibX.Data.XInsertStmt
        Dim xInsert1 As LibX.Data.XInsertStmt
        Dim xInsno As LibX.Data.XInsertStmt

        Dim oDoc As SGT.Inventario.Entidades.Documento
        Dim ConteoNo As Integer, PaginaNo As Integer, LineNo As Integer
        Dim e As ConteoEventArgs

        Dim oFile As StreamReader
        Dim ItemLine As String
        Dim Items As String()
        Dim Codigo As String
        Dim Cantidad As Integer
        Try

            oFile = New StreamReader(p_Args.PathAndFileName)

            If p_Args.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            oDoc = New SGT.Inventario.Entidades.Documento("INV")
            xInsert1 = New LibX.Data.XInsertStmt("ivcounte", "count_number")

            xInsert1.Fields("whse_code") = p_Args.Almacen
            xInsert1.Fields("count_date") = LibX.Data.Manager.Connection.GetDate
            xInsert1.Fields("count_desc") = p_Args.Descripcion
            xInsert1.Fields("userid") = LibX.User.UserID

            ConteoNo = xInsert1.Execute()
            xInsert1.Dispose()

            e = New ConteoEventArgs
            e.ConteoNo = ConteoNo
            e.PaginaNo = 1
            e.TotalRegistros = 0
            e.RegistroActual = 0
            e.LineNo = 0

            '// Dispara el evento
            RaiseEvent Updating(e)

            If e.Status = ConteoStatus.Abort Then
                Exit Function
            End If

            PaginaNo = 0
            LineNo = 66
            Dim oNewRow1 As DataRow

            While True
                ItemLine = oFile.ReadLine
                If ItemLine Is Nothing Then
                    Exit While
                End If

                Items = Split(ItemLine, ",")
                If Items(0).Trim = "" Then
                    Exit While
                End If

                'Dim oNewRow As DataRow = ivcountd.NewRow
                xInsert = New LibX.Data.XInsertStmt("ivcountd")

                If LineNo >= 66 Then
                    LineNo = 1
                    PaginaNo += 1
                    e.PaginaNo = PaginaNo
                End If

                e.RegistroActual += 1
                e.LineNo = LineNo

                RaiseEvent Updating(e)

                If e.Status = ConteoStatus.Abort Then
                    Exit Function
                End If

                If e.Status = ConteoStatus.Skip Then
                    GoTo NEXT_REG
                End If
                If Len(Items(0).Trim) > 6 Then
                    Codigo = LibX.Data.Manager.GetScalar("Select item_code from ivcbarram where barra = '" & Items(0).Trim & "'")
                    If Codigo Is Nothing Then
                        Codigo = Items(0).Trim
                    End If
                Else
                    Codigo = Items(0).Trim
                End If

                Dim oRow As DataRow
                oRow = LibX.Data.Manager.GetDataRow("Select unit_code,loc_row,loc_col,estante,existencia " & _
                                    "from ivitemd,ivitemm where ivitemd.item_code = '" & Codigo & "'" & _
                                    " and ivitemd.item_code = ivitemm.item_code and whse_code = " & p_Args.Almacen)
                If oRow Is Nothing Then
                    Cantidad = Val(Items(1).Trim)
                    If Cantidad = 0 Then
                        Cantidad = 1
                    End If
                    '//Insertar los codigo no leido para verificar
                    CargarLoteNoencontrado(Cantidad, Codigo, PaginaNo)
                    GoTo NEXT_REG
                End If

                Cantidad = Val(Items(1).Trim)
                If Cantidad = 0 Then
                    Cantidad = 1
                End If

                xInsert.Fields("count_number") = ConteoNo
                xInsert.Fields("PageNo") = PaginaNo
                xInsert.Fields("line_no") = LineNo
                xInsert.Fields("unit_code") = oRow!unit_code
                xInsert.Fields("item_code") = Codigo
                xInsert.Fields("whse_code") = p_Args.Almacen
                xInsert.Fields("loc_row") = oRow!loc_row
                xInsert.Fields("loc_bin") = oRow!loc_col
                xInsert.Fields("estante") = oRow!estante
                xInsert.Fields("qty_on_hand") = oRow!existencia
                xInsert.Fields("count_qty") = Cantidad
                xInsert.Fields("count_status") = 2

                xInsert.Execute()
                xInsert.Dispose()

                RaiseEvent Updated(e)

                LineNo += 1
NEXT_REG:
                '// Registrar cantidad de registros insertado
                p_Args.Retorno.Cantidad += 1
            End While
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If
            Return ConteoNo

        Catch ex As Exception
            LibX.Log.Show(ex)
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
            Return -1

        End Try
    End Function

    Public Function GenerarHoja(ByVal p_Args As ParametrosGenerar) As Integer
        Dim xSelect As LibX.Data.XSelecStmt
        Dim xInsert As LibX.Data.XInsertStmt
        Dim xInsert1 As LibX.Data.XInsertStmt

        Dim oTable As DataTable
        Dim oDoc As SGT.Inventario.Entidades.Documento
        Dim ConteoNo, PaginaNo, LineNo As Integer
        Dim e As ConteoEventArgs
        Try

            xSelect = New LibX.Data.XSelecStmt("ivitemm", p_Args.SelectStmt)
            oTable = xSelect.GetTable(True)

            xSelect.Dispose()

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No existen registros con esa condición!")
            End If

            If p_Args.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            oDoc = New SGT.Inventario.Entidades.Documento("INV")
            LineNo = 1
            PaginaNo = 1

            xInsert1 = New LibX.Data.XInsertStmt("ivcounte", "count_number")
            xInsert1.Fields("whse_code") = 1
            xInsert1.Fields("count_date") = LibX.Data.Manager.Connection.GetDate
            xInsert1.Fields("count_desc") = "INVENTARIO FISICO AL " & LibX.Data.Manager.Connection.GetDate.ToShortDateString
            xInsert1.Fields("userid") = LibX.User.UserID

            ConteoNo = xInsert1.Execute()
            xInsert1.Dispose()
            e.PaginaNo = PaginaNo

            e = New ConteoEventArgs
            e.ConteoNo = ConteoNo
            e.PaginaNo = 1
            e.TotalRegistros = oTable.Rows.Count
            e.RegistroActual = 0
            e.LineNo = 0

            '// Dispara el evento
            RaiseEvent Updating(e)

            If e.Status = ConteoStatus.Abort Then
                Exit Function
            End If

            PaginaNo = 0
            LineNo = 66
            Dim oNewRow1 As DataRow

            For Each oRow As DataRow In oTable.Rows
                'Dim oNewRow As DataRow = ivcountd.NewRow
                xInsert = New LibX.Data.XInsertStmt("ivcountd")

                If LineNo >= 66 Then
                    PaginaNo += 1
                    LineNo = 1
                End If

                e.RegistroActual += 1
                e.LineNo = LineNo

                RaiseEvent Updating(e)

                If e.Status = ConteoStatus.Abort Then
                    Exit Function
                End If

                If e.Status = ConteoStatus.Skip Then
                    GoTo NEXT_REG
                End If

                xInsert.Fields("count_number") = ConteoNo
                xInsert.Fields("PageNo") = PaginaNo
                xInsert.Fields("line_no") = LineNo
                xInsert.Fields("item_code") = oRow!item_code
                xInsert.Fields("whse_code") = oRow!whse_code
                xInsert.Fields("loc_row") = oRow!loc_row
                xInsert.Fields("loc_bin") = oRow!loc_col
                xInsert.Fields("estante") = oRow!estante
                xInsert.Fields("qty_on_hand") = oRow!existencia
                xInsert.Fields("count_status") = 2 'Pendiente de Aplicar

                xInsert.Execute()
                xInsert.Dispose()

                RaiseEvent Updated(e)

                LineNo += 1
NEXT_REG:
            Next
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If
            Return ConteoNo

        Catch ex As Exception
            LibX.Log.Show(ex)
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
            Return -1

        End Try
    End Function



    Public Function CalcularExistenciaCierre(ByVal p_Args As ParametrosCalcular) As Integer
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim ExistenciaCierre As Integer
        Try
            ExistenciaCierre = p_Args.Existencia

            SelectStmt = "select ivtypem.type_code,qty,origen from ivtranrm " & _
                        " inner join ivtranrd " & _
                        " on ivtranrm.trane_number = ivtranrd.trane_number " & _
                        " inner join ivtypem on ivtypem.type_code = ivtranrm.type_code " & _
                        " where doc_date = '" & p_Args.FechaConteo.ToShortDateString & "'" & _
                        "   and item_code = '" & p_Args.Producto.Trim & "'" & _
                        "   and whse_code = " & p_Args.Almacen.ToString

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Throw New ApplicationException("Error buscando trnasacciones")
            End If

            If oTable.Rows.Count <= 0 Then
                Return ExistenciaCierre
            End If

            '// Calcular la existencia de cierre que sera igual a la existencia actual
            '// menos las entradas mas las salidas
            For Each oRow As DataRow In oTable.Rows
                ExistenciaCierre += Val(oRow!qty.ToString) * (Val(oRow!origen.ToString) * -1)
            Next

            Return ExistenciaCierre

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return -1

        End Try
    End Function

    Public Function CalcularDiferencia(ByVal p_Args As ParametrosCalcular) As Integer
        Dim oTable As DataTable
        Dim SelectStmt As String

        Dim Vendidas As Integer
        Dim Contadas As Integer
        Dim ExistenciaActual As Integer
        Dim ExistenciaInicio As Integer
        Dim Diferencia As Integer
        Try

            '// buscar la existencia inicial
            SelectStmt = "select qty_on_hand from ivcountd " & _
                        " where item_code = '" & p_Args.Producto.Trim & "'" & _
                        "   and whse_code = " & p_Args.Almacen.ToString & _
                        "   and count_number = " & p_Args.ConteoNo.ToString

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Throw New ApplicationException("Error buscando inicio de conteo fisico")
            End If

            If oTable.Rows.Count <= 0 Then
                ExistenciaInicio = 0
            Else
                ExistenciaInicio = Val(oTable.Rows(0)!qty_on_hand.ToString)
            End If

            '// Buscar la existencia actual
            SelectStmt = "select existencia from ivitemd " & _
                         " where item_code = '" & p_Args.Producto.Trim & "'" & _
                         "   and whse_code = " & p_Args.Almacen.ToString

            ExistenciaActual = Val(LibX.Data.Manager.GetScalar(SelectStmt).ToString.Trim)

            '// buscar la cantidad contada
            SelectStmt = "select count_qty from ivcountd " & _
                        " where item_code = '" & p_Args.Producto.Trim & "'" & _
                        "   and whse_code = " & p_Args.Almacen.ToString & _
                        "   and count_number = " & p_Args.ConteoNo.ToString

            Contadas = Val(LibX.Data.Manager.GetScalar(SelectStmt).ToString.Trim)

            '// Calcular la cantidad vendida luego del inicio de inventario
            Vendidas = ExistenciaInicio - ExistenciaActual

            '// Calcular la diferencia
            If Contadas = 0 And Vendidas > 0 And ExistenciaInicio = 0 Then
                Vendidas = Vendidas * -1
            End If

            'Diferencia = (Contadas - Vendidas) - ExistenciaInicio
            Diferencia = (Contadas - Vendidas) - ExistenciaActual

            Return Diferencia

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return -1

        End Try
    End Function

    Public Function AplicarHoja(ByVal p_Args As ParametrosAplicar) As Boolean
        Dim xInsertAjuste As LibX.Data.XInsertStmt
        Dim xUpdateInvent As LibX.Data.XUpdateStmt
        Dim ParamCalcDiff As ParametrosCalcular
        Dim oDoc As SGT.Inventario.Entidades.Documento
        Dim oProd As SGT.Inventario.Entidades.Articulo
        Dim oParamProd As SGT.Inventario.Entidades.Articulo.GetOnHandParameters
        Dim oParamInventario As SGT.Inventario.Operaciones.PostInventory.ParametrosAplicar
        Dim oInventario As SGT.Inventario.Operaciones.PostInventory
        Dim oTable As DataTable

        Dim SelectStmt As String
        Dim SerialNumber As Integer
        Dim DocNumber As Integer
        Dim LineNo As Integer
        Dim Diff As Integer
        Dim Costo As Decimal
        Dim Existencia As Integer
        Dim SucCode As Integer

        Try
            oProd = New SGT.Inventario.Entidades.Articulo
            oParamProd = New SGT.Inventario.Entidades.Articulo.GetOnHandParameters
            oParamInventario = New SGT.Inventario.Operaciones.PostInventory.ParametrosAplicar
            oDoc = New SGT.Inventario.Entidades.Documento("ADJ")
            oInventario = New SGT.Inventario.Operaciones.PostInventory
            ParamCalcDiff = New ParametrosCalcular

            SelectStmt = "select ivcountd.*,count_desc from ivcounte " & _
                         " inner join ivcountd " & _
                         " on ivcounte.count_number = ivcountd.count_number " &  _
                         " and ivcountd.count_status = 2 " & _
                         " where ivcounte.count_number = " & p_Args.ConteNo.ToString & _
                         "   and ivcountd.whse_code = " & p_Args.Almacen.ToString

            If p_Args.PaginaNo > 0 Then
                SelectStmt &= " and ivcountd.pageno = " & p_Args.PaginaNo.ToString
            End If

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Throw New ApplicationException("Error buscando los productos de este conteo")
            End If

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No se encontró hoja de conteo con este número")
            End If
            SucCode = LibX.Data.Manager.GetScalar("select suc_code from cgsucursal where suc_default = 1")

            If p_Args.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            'DocNumber = oDoc.GenerateNumber("ADJ", Val(oTable.Rows(0)!whse_code.ToString))
            DocNumber = oDoc.GenerateNumber("ADJ", Val(oTable.Rows(0)!whse_code.ToString))
            xInsertAjuste = New LibX.Data.XInsertStmt("ivdocsm", "doc_serial")
            xInsertAjuste.Fields("type_code") = "ADJ"
            xInsertAjuste.Fields("doc_number") = DocNumber
            xInsertAjuste.Fields("doc_date") = LibX.Data.Manager.Connection.GetDate
            xInsertAjuste.Fields("whse_code") = Val(oTable.Rows(0)!whse_code.ToString)
            xInsertAjuste.Fields("doc_status") = 2 'Pendiente
            xInsertAjuste.Fields("doc_type") = 28 '// CONTEO DE RUTINA
            xInsertAjuste.Fields("suc_code") = SucCode
            xInsertAjuste.Fields("nota") = oTable.Rows(0)!count_desc.ToString.Trim

            LineNo = 0
            For Each oRow As DataRow In oTable.Rows

                '// Calcular para determinar si existe diferencia
                With ParamCalcDiff
                    .Almacen = Val(oRow!whse_code.ToString)

                    .Producto = oRow!item_code.ToString
                    .ConteoNo = Val(oRow!count_number.ToString)
                End With
                If oRow!item_code.ToString = "010669" Then
                    Diff = CalcularDiferencia(ParamCalcDiff)
                End If

                Diff = CalcularDiferencia(ParamCalcDiff)

                '// Si hay diferencia crear un documento de ajuste
                If Diff <> 0 Then
                    If SerialNumber <= 0 Then
                        SerialNumber = xInsertAjuste.Execute()
                        xInsertAjuste.Dispose()

                        xInsertAjuste = New LibX.Data.XInsertStmt("ivdocsd")

                        xInsertAjuste.Fields("doc_serial") = SerialNumber
                        xInsertAjuste.Fields("whse_code") = 0
                        xInsertAjuste.Fields("bf_onhand") = 0
                        xInsertAjuste.Fields("unit_code") = ""
                        xInsertAjuste.Fields("line_no") = 0
                        xInsertAjuste.Fields("costo") = 0
                        xInsertAjuste.Fields("item_code") = ""
                        xInsertAjuste.Fields("qty") = 0
                        xInsertAjuste.Fields("suc_code") = 0
                    End If

                    '// Buscar la existencia actual
                    With oParamProd
                        .Producto = oRow!item_code.ToString
                        .WareHouse = Val(oRow!whse_code.ToString)
                    End With

                    LineNo += 1
                    Costo = oProd.GetCosto(oRow!item_code, oRow!unit_code, oRow!whse_code)
                    Existencia = oProd.GetOnHand(oParamProd)

                    xInsertAjuste.Parameters.Item("doc_serial").Value = SerialNumber
                    xInsertAjuste.Parameters.Item("whse_code").Value = Val(oRow!whse_code.ToString)
                    xInsertAjuste.Parameters.Item("item_code").Value = oRow!item_code.ToString
                    xInsertAjuste.Parameters.Item("unit_code").Value = oRow!unit_code.ToString
                    xInsertAjuste.Parameters.Item("line_no").Value = LineNo
                    xInsertAjuste.Parameters.Item("bf_onhand").Value = Existencia
                    xInsertAjuste.Parameters.Item("costo").Value = Costo
                    xInsertAjuste.Parameters.Item("qty").Value = Diff
                    xInsertAjuste.Parameters.Item("suc_code").Value = SucCode

                    xInsertAjuste.Execute()

                    '// Agregar para aplicar ajuste
                    With oParamInventario
                        .Productos.Add(oRow!item_code, oRow!whse_code, Diff, oRow!unit_code, Costo, Costo, 0, 0, Existencia, oRow!factor.ToString)
                    End With
                End If

                '// Liberar Producto
                xUpdateInvent = New LibX.Data.XUpdateStmt("ivitemd")
                xUpdateInvent.FieldsSet("frizado_inv") = 0 '// activo
                xUpdateInvent.FieldsSet("fecha_frizado") = DBNull.Value  '// activo
                xUpdateInvent.FieldsSet("fecha_conteo") = LibX.Data.Manager.Connection.GetDate  '// activo
                If Not LibX.IsNull(oRow!loc_row) Then
                    xUpdateInvent.FieldsSet("loc_row") = oRow!loc_row.ToString
                End If
                If Not LibX.IsNull(oRow!loc_bin) Then
                    xUpdateInvent.FieldsSet("loc_col") = oRow!loc_bin.ToString
                End If
                If Not LibX.IsNull(oRow!estante) Then
                    xUpdateInvent.FieldsSet("estante") = oRow!estante.ToString
                End If

                xUpdateInvent.Fields("item_code") = oRow!item_code.ToString
                xUpdateInvent.Fields("whse_code") = oRow!whse_code.ToString

                xUpdateInvent.Execute()
            Next

            '// Si se creo un ajuste aplicarlo
            If SerialNumber > 0 Then
                With oParamInventario
                    .DocDate = p_Args.Fecha
                    .Impuesto = 0
                    .Monto = 0
                    .Numero = DocNumber
                    .Serial = SerialNumber
                    .TipoTransaccion = "ADJ"
                    .UseTransaction = False
                End With

                oInventario.Aplicar(oParamInventario)

                xUpdateInvent = New LibX.Data.XUpdateStmt("ivdocsm")
                xUpdateInvent.FieldsSet("doc_status") = 1
                xUpdateInvent.Fields("doc_serial") = SerialNumber
                xUpdateInvent.Execute()
            End If

            If p_Args.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            Return True
        Catch ex As Exception
            If p_Args.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If

            Return False
        End Try
    End Function
    Function CargarLoteNoencontrado(ByVal cantidad, ByVal items, ByVal PaginaNo)
        Dim xinsno As LibX.Data.XInsertStmt
        Try
            xinsno = New LibX.Data.XInsertStmt("ivcountno", "no_leido")
            xinsno.Fields("item_code") = items
            xinsno.Fields("cantidad") = cantidad
            xinsno.Fields("pagina") = PaginaNo
            xinsno.Fields("item_name") = ""

            xinsno.Execute()
            xinsno.Dispose()
        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False
        End Try
    End Function

End Class
