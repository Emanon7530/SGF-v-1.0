Public Class PostDevol

    Public Class ParametrosAplicar

        Public DocDate As Date
        Public Numero As Integer
        Public Serial As Integer
        Public Referencia As String
        Public TipoTransaccion As String
        Public Termino As String
        Public Proveedor As Integer
        Public UseTransaction As Boolean
        Public Monto As Decimal
        Public Impuesto As Decimal
        Public SucCode As Integer
    End Class


    Public Function Aplicar(ByVal e As ParametrosAplicar) As Boolean
        Dim oParamPost As PostInventory.ParametrosAplicar
        Dim oPost As PostInventory
        Dim oDocumento As SGT.Inventario.Entidades.Documento

        Dim SelectStmt As String
        Dim OnHand As Integer

        Dim oiventrdd As DataTable
        Dim oiventrdm As DataTable

        Dim oArticulo As SGT.Inventario.Entidades.Articulo
        Dim oParam As SGT.Inventario.Entidades.Articulo.GetOnHandParameters
        Dim XUpdate As LibX.Data.XUpdateStmt

        Try

            oParamPost = New PostInventory.ParametrosAplicar
            oPost = New PostInventory

            oArticulo = New SGT.Inventario.Entidades.Articulo
            oParam = New SGT.Inventario.Entidades.Articulo.GetOnHandParameters

            oDocumento = New SGT.Inventario.Entidades.Documento(e.TipoTransaccion)

            '// Buscar los productos
            SelectStmt = "select * from ivdevold " & _
                         " where dev_serial =" & e.Serial.ToString.Trim

            oiventrdd = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oiventrdd.Rows.Count <= 0 Then
                Throw New ApplicationException("No se encontró productos para este documento!")
            End If

            '// Postear a inventario
            With oParamPost
                .DocDate = e.DocDate
                .Numero = e.Numero
                .Serial = e.Serial
                .Referencia = e.Proveedor
                .TipoTransaccion = e.TipoTransaccion
                .Tasa = 0
                .Impuesto = e.Impuesto
                .Termino = e.Termino
                .Proveedor = e.Proveedor
                .UseTransaction = False
                .Monto = e.Monto
                .SucCode = e.SucCode

                For Each oRowd As DataRow In oiventrdd.Rows
                    oParam.Producto = oRowd!item_code.ToString
                    oParam.WareHouse = Val(oRowd!whse_code.ToString)

                    OnHand = Val(oArticulo.GetOnHand(oParam).ToString)

                    .Productos.Add(oRowd!item_code, oRowd!whse_code, Val(oRowd!qty.ToString), _
                                    oRowd!unit_code.ToString, Val(oRowd!costo.ToString), _
                                    Val(oRowd!costo.ToString), Val(oRowd!itbis.ToString), 0, OnHand, Val(oRowd!factor.ToString))
                Next
            End With

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            oPost.Aplicar(oParamPost)

            XUpdate = New LibX.Data.XUpdateStmt("ivdevolm")

            XUpdate.FieldsSet("dev_status") = 1 'Aplicada
            XUpdate.Fields("dev_serial") = e.Serial
            XUpdate.Fields("suc_code") = e.SucCode

            XUpdate.Execute()

            ''''// Aplicar en CXP (crear una NC)
            '''If oDocumento.AfectaCXP = True Then
            '''    With oParamcxp
            '''        .TipoDocumento = e.TipoTransaccion
            '''        .Termino = "00-00"
            '''        .DocDate = e.DocDate
            '''        .Monto = e.Monto
            '''        .Numero = e.Numero  'oDocumento.GenerateNumber(e.TipoTransaccion)
            '''        .Proveedor = e.Proveedor
            '''        .DevolucionSerial = e.Serial
            '''        .UseTransaction = False
            '''    End With

            '''    oPostCXP.CrearNC(oParamcxp)
            '''End If

            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
            If e.UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If

        End Try

    End Function

End Class
