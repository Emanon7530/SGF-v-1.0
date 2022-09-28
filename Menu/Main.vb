
Module Main
    Sub Main()
        Try
            '// Instanciar la forma Splash
            Dim FrmSpl As New frmSplash
            FrmSpl.Show()

            '// Refrescar sus controles
            FrmSpl.Refresh()

            '// Instanciar el menu principal
            Dim frmMain As sgtmain
            frmMain = New sgtmain

            '// Cerrar la forma splash
            FrmSpl.Close()
            FrmSpl = Nothing

            frmMain.ShowDialog()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Public Function GetScalar()
        Dim intCantidad As Integer


    End Function

    Public Sub FillFromMenu(ByVal opcMenu As MainMenu)
        For Each OBJMENU As MenuItem In opcMenu.MenuItems
            FillTree(OBJMENU)
        Next

    End Sub

    Private Function LocateNode(ByVal objNodo As TreeNode, ByVal NodeTitle As String) As TreeNode
        Dim oTreeNOde As TreeNode

        For Each objTreeNode As TreeNode In objNodo.Nodes
            If objNodo.Text = NodeTitle Then
                oTreeNOde = objTreeNode
                Exit For
            End If

            If objTreeNode.GetNodeCount(False) > 0 Then
                oTreeNOde = LocateNode(objTreeNode, NodeTitle)
                If Not oTreeNOde Is Nothing Then
                    Exit For
                End If
            End If
        Next

        Return oTreeNOde
    End Function
    Public Sub FillTree(ByVal opcMenu As MenuItem, Optional ByVal oNodeParent As TreeNode = Nothing)
        Dim oTreeNOde As TreeNode
        'Dim oNodeParent As TreeNode

        'If oNodeParent Is Nothing Then
        '    oNodeParent = TreeView1.Nodes(0)
        'End If

        oTreeNOde = LocateNode(oNodeParent, opcMenu.Text)

        If oTreeNOde Is Nothing Then
            oTreeNOde = oNodeParent.Nodes.Add(opcMenu.Text)
        End If

        For Each OBJMENU As MenuItem In opcMenu.MenuItems
            If OBJMENU.Text <> "-" Then
                If OBJMENU.MenuItems.Count > 0 Then
                    oTreeNOde.NodeFont = New Font("Arial", 8, FontStyle.Bold)
                    FillTree(OBJMENU, oTreeNOde)
                Else
                    oTreeNOde.Nodes.Add(OBJMENU.Text)
                    '//cbb_buscar.Items.Add(OBJMENU.Text)
                End If
            End If
        Next

    End Sub
End Module
