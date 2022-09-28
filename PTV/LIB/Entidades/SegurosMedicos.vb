Public Class ParametroCobertura
    Public Compania As Integer
    Public Producto As String
    Public Plan As Integer
End Class

Public Class ParametroCalcular
    Public Compania As Integer
    Public Poliza As String
    Public Monto As Decimal

    Public Class ValorRetorno
        Public Porc_Cobertura As Decimal
        Public Porc_Descuento As Decimal
        Public Valor_Cobertura As Decimal
        Public Valor_Descuento As Decimal
    End Class

    Public Retorno As New ValorRetorno
End Class
Public Class SegurosMedicos

    Public Function ProductoExcluido(ByVal pProducto As String, ByVal pPlan As Integer) As Boolean
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim Estatus As Integer = 1 '// No esta excluido

        '// Buscar el producto para virificar si el 
        '// especificamente esta excluido
        SelectStmt = "select * from sgcobrm " & _
                     " where item_code = '" & pProducto.Trim & "'" & _
                     "   and plan_serial = " & pPlan.ToString

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        If Not oTable Is Nothing _
        AndAlso oTable.Rows.Count > 0 Then
            Estatus = Val(oTable.Rows(0)!plan_status)
        End If

        '// Si el estatus es 1, esta incluido, de lo contrario esta excluido
        If Estatus = 1 Then '// Incluido
            Return False
        Else
            Return True '// Excluido
        End If
    End Function

    Public Function GrupoExcluido(ByVal pGrupo As Integer, ByVal pPlan As Integer) As Boolean
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim Estatus As Integer = 1 '// No esta excluido

        '// Buscar el producto para virificar si el 
        '// especificamente esta excluido
        SelectStmt = "select * from sgcobrm " & _
                     " where group_code = " & pGrupo.ToString & _
                     "   and plan_serial = " & pPlan.ToString

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        If Not oTable Is Nothing _
        AndAlso oTable.Rows.Count > 0 Then
            Estatus = Val(oTable.Rows(0)!plan_status)
        End If

        If Estatus = 1 Then
            Return False '// no esta excluido
        Else
            Return True  '// esta exclido
        End If
    End Function

    Public Function SubGrupoExcluido(ByVal pGrupo As Integer, ByVal pSubGrupo As Integer, ByVal pPlan As Integer) As Boolean
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim Estatus As Integer = 1 '// No esta excluido

        '// Buscar el producto para virificar si el 
        '// especificamente esta excluido
        SelectStmt = "select * from sgcobrm " & _
                     " where group_code = " & pGrupo.ToString & _
                     "   and sgroup_code = " & pSubGrupo.ToString & _
                     "   and plan_serial = " & pPlan.ToString

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        If Not oTable Is Nothing _
        AndAlso oTable.Rows.Count > 0 Then
            Estatus = Val(oTable.Rows(0)!plan_status)
        End If

        If Estatus = 1 Then
            Return False '// no esta excluido
        Else
            Return True '// excluido
        End If
    End Function

    Public Function TieneCobretura(ByVal p_Args As ParametroCobertura) As Boolean
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim oProducto As DataRow
        Dim Estatus As Integer = 1 '// Si tiene cobertura

        '// Buscar el producto
        SelectStmt = "select group_code,sgroup_code,item_code from ivitemm where item_code ='" & p_Args.Producto.Trim & "'"

        oProducto = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oProducto Is Nothing Then
            Throw New ApplicationException("Producto no existe!")
        End If

        '// Validar si el producto esta incluido o excluido en este plan
        If ProductoExcluido(p_Args.Producto, p_Args.Plan) = True Then
            Estatus = 0 '// No tiene cobertura
        End If

        '// Validar si el Subgrupo esta incluido o excluido en este plan
        If Estatus = 1 AndAlso Not LibX.IsNull(oProducto!group_code) AndAlso Not LibX.IsNull(oProducto!sgroup_code) Then
            If SubGrupoExcluido(oProducto!group_code.ToString, oProducto!sgroup_code, p_Args.Plan) = True Then
                Estatus = 0 '// No tiene cobertura
            End If
        End If

        '// Validar si el grupo esta incluido o excluido en este plan
        If Estatus = 1 AndAlso Not LibX.IsNull(oProducto!group_code) Then
            If GrupoExcluido(oProducto!group_code.ToString, p_Args.Plan) = True Then
                Estatus = 0 '// No tiene cobertura
            End If
        End If

        If Estatus = 1 Then  '// Incluido
            Return True '// tiene cobertura
        Else
            Return False '// no tiene cobertura
        End If

    End Function

    Public Function CalcularCobertura(ByVal p_Args As ParametroCalcular) As Boolean
        Dim SelectStmt As String
        Dim oRow As DataRow

        SelectStmt = "Select plan_cobertura,plan_descto from sgplanm, sgasegm " & _
                    " where sgplanm.plan_serial = sgasegm.plan_serial " & _
                    "   and sgasegm.aseg_poliza = '" & p_Args.Poliza.Trim & "'" & _
                    "   and sgasegm.cia_serial = " & p_Args.Compania.ToString

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oRow Is Nothing Then
            Return False
        End If

        p_Args.Retorno.Porc_Cobertura = Val(oRow!plan_cobertura.ToString.Trim)
        p_Args.Retorno.Porc_Descuento = Val(oRow!plan_descto.ToString.Trim)

        If p_Args.Retorno.Valor_Cobertura <= 0 Then
            If p_Args.Retorno.Porc_Cobertura <= 0 Then
                p_Args.Retorno.Valor_Cobertura = 0
            Else
                p_Args.Retorno.Valor_Cobertura = p_Args.Monto * (p_Args.Retorno.Porc_Cobertura / 100)
            End If
        End If

        If p_Args.Retorno.Porc_Descuento <= 0 Then
            p_Args.Retorno.Porc_Descuento = 0
        Else
            p_Args.Retorno.Valor_Descuento = p_Args.Monto * (p_Args.Retorno.Porc_Descuento / 100)
        End If

        Return True
    End Function

End Class
