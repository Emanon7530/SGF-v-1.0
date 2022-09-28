Public Class frmTreeMenu
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn4 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn5 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn6 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn7 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn8 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn9 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn10 As LibX.XEditTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn10 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn4 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn5 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn6 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn7 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn8 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn9 = New LibX.XEditTextBoxColumn
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "LISTADO DE PRODUCTOS CON EXISTENCIA MINIMA"
        Me.LibXGrid1.DataMember = "ivitemv1"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 8)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(1136, 472)
        Me.LibXGrid1.TabIndex = 0
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"item_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn4}
        Me.DataTable1.TableName = "ivitemv1"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "item_name"
        Me.DataColumn1.MaxLength = 100
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "existencia"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "whse_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "item_code"
        Me.DataColumn4.MaxLength = 10
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Mes"
        Me.DataColumn5.DataType = GetType(System.Int32)
        Me.DataColumn5.ReadOnly = True
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ano"
        Me.DataColumn6.DataType = GetType(System.Int32)
        Me.DataColumn6.ReadOnly = True
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Ventas"
        Me.DataColumn7.DataType = GetType(System.Int32)
        Me.DataColumn7.ReadOnly = True
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Compras"
        Me.DataColumn8.DataType = GetType(System.Int32)
        Me.DataColumn8.ReadOnly = True
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "DevFact"
        Me.DataColumn9.DataType = GetType(System.Int32)
        Me.DataColumn9.ReadOnly = True
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Vencimiento"
        Me.DataColumn10.DataType = GetType(System.Int32)
        Me.DataColumn10.ReadOnly = True
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "DevInv"
        Me.DataColumn11.DataType = GetType(System.Int32)
        Me.DataColumn11.ReadOnly = True
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Ajustes"
        Me.DataColumn12.DataType = GetType(System.Int32)
        Me.DataColumn12.ReadOnly = True
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "existencia_min"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn3, Me.XEditTextBoxColumn10, Me.XEditTextBoxColumn4, Me.XEditTextBoxColumn5, Me.XEditTextBoxColumn6, Me.XEditTextBoxColumn7, Me.XEditTextBoxColumn8, Me.XEditTextBoxColumn9})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivitemv1"
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Codigo"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "item_code"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 75
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Descripcion"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "item_name"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 300
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Existencia"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = False
        Me.XEditTextBoxColumn3.MappingName = "existencia"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.TabStop = True
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 75
        '
        'XEditTextBoxColumn10
        '
        Me.XEditTextBoxColumn10.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn10.Format = ""
        Me.XEditTextBoxColumn10.FormatInfo = Nothing
        Me.XEditTextBoxColumn10.HeaderText = "Minimo"
        Me.XEditTextBoxColumn10.ImageList = Nothing
        Me.XEditTextBoxColumn10.isReadOnly = False
        Me.XEditTextBoxColumn10.MappingName = "existencia_min"
        Me.XEditTextBoxColumn10.MaxLength = 32767
        Me.XEditTextBoxColumn10.TabStop = True
        Me.XEditTextBoxColumn10.UseCustomCellFormat = False
        Me.XEditTextBoxColumn10.Width = 75
        '
        'XEditTextBoxColumn4
        '
        Me.XEditTextBoxColumn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn4.Format = ""
        Me.XEditTextBoxColumn4.FormatInfo = Nothing
        Me.XEditTextBoxColumn4.HeaderText = "Ventas"
        Me.XEditTextBoxColumn4.ImageList = Nothing
        Me.XEditTextBoxColumn4.isReadOnly = False
        Me.XEditTextBoxColumn4.MappingName = "Ventas"
        Me.XEditTextBoxColumn4.MaxLength = 32767
        Me.XEditTextBoxColumn4.TabStop = True
        Me.XEditTextBoxColumn4.UseCustomCellFormat = False
        Me.XEditTextBoxColumn4.Width = 95
        '
        'XEditTextBoxColumn5
        '
        Me.XEditTextBoxColumn5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn5.Format = ""
        Me.XEditTextBoxColumn5.FormatInfo = Nothing
        Me.XEditTextBoxColumn5.HeaderText = "Compras"
        Me.XEditTextBoxColumn5.ImageList = Nothing
        Me.XEditTextBoxColumn5.isReadOnly = False
        Me.XEditTextBoxColumn5.MappingName = "Compras"
        Me.XEditTextBoxColumn5.MaxLength = 32767
        Me.XEditTextBoxColumn5.TabStop = True
        Me.XEditTextBoxColumn5.UseCustomCellFormat = False
        Me.XEditTextBoxColumn5.Width = 95
        '
        'XEditTextBoxColumn6
        '
        Me.XEditTextBoxColumn6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn6.Format = ""
        Me.XEditTextBoxColumn6.FormatInfo = Nothing
        Me.XEditTextBoxColumn6.HeaderText = "Devoluciones"
        Me.XEditTextBoxColumn6.ImageList = Nothing
        Me.XEditTextBoxColumn6.isReadOnly = False
        Me.XEditTextBoxColumn6.MappingName = "DevFact"
        Me.XEditTextBoxColumn6.MaxLength = 32767
        Me.XEditTextBoxColumn6.TabStop = True
        Me.XEditTextBoxColumn6.UseCustomCellFormat = False
        Me.XEditTextBoxColumn6.Width = 95
        '
        'XEditTextBoxColumn7
        '
        Me.XEditTextBoxColumn7.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn7.Format = ""
        Me.XEditTextBoxColumn7.FormatInfo = Nothing
        Me.XEditTextBoxColumn7.HeaderText = "Vencimiento"
        Me.XEditTextBoxColumn7.ImageList = Nothing
        Me.XEditTextBoxColumn7.isReadOnly = False
        Me.XEditTextBoxColumn7.MappingName = "Vencimiento"
        Me.XEditTextBoxColumn7.MaxLength = 32767
        Me.XEditTextBoxColumn7.TabStop = True
        Me.XEditTextBoxColumn7.UseCustomCellFormat = False
        Me.XEditTextBoxColumn7.Width = 95
        '
        'XEditTextBoxColumn8
        '
        Me.XEditTextBoxColumn8.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn8.Format = ""
        Me.XEditTextBoxColumn8.FormatInfo = Nothing
        Me.XEditTextBoxColumn8.HeaderText = "Dev. Inv."
        Me.XEditTextBoxColumn8.ImageList = Nothing
        Me.XEditTextBoxColumn8.isReadOnly = False
        Me.XEditTextBoxColumn8.MappingName = "DevInv"
        Me.XEditTextBoxColumn8.MaxLength = 32767
        Me.XEditTextBoxColumn8.TabStop = True
        Me.XEditTextBoxColumn8.UseCustomCellFormat = False
        Me.XEditTextBoxColumn8.Width = 95
        '
        'XEditTextBoxColumn9
        '
        Me.XEditTextBoxColumn9.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn9.Format = ""
        Me.XEditTextBoxColumn9.FormatInfo = Nothing
        Me.XEditTextBoxColumn9.HeaderText = "Ajustes"
        Me.XEditTextBoxColumn9.ImageList = Nothing
        Me.XEditTextBoxColumn9.isReadOnly = False
        Me.XEditTextBoxColumn9.MappingName = "Ajustes"
        Me.XEditTextBoxColumn9.MaxLength = 32767
        Me.XEditTextBoxColumn9.TabStop = True
        Me.XEditTextBoxColumn9.UseCustomCellFormat = False
        Me.XEditTextBoxColumn9.Width = 95
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = True
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = True
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "ivitemv1"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = True
        Me.LibXConnector1.ModuleName = ""
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = ""
        Me.LibXConnector1.ReportObject = Nothing
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
        '
        'LibXDbSourceTable1
        '
        Me.LibXDbSourceTable1.AllowDelete = False
        Me.LibXDbSourceTable1.AllowEdit = False
        Me.LibXDbSourceTable1.AllowNew = False
        Me.LibXDbSourceTable1.AutoIncrementSerial = False
        Me.LibXDbSourceTable1.CustomDbUpdate = False
        Me.LibXDbSourceTable1.DeleteOrder = 0
        Me.LibXDbSourceTable1.FillOnQuery = True
        Me.LibXDbSourceTable1.FillOnRowChange = False
        Me.LibXDbSourceTable1.HeaderIsOnGrid = True
        Me.LibXDbSourceTable1.InnerJon = True
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = "item_code"
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select I.item_name, i.existencia,i.existencia_min ,i.exitencia_max,E.* ", "from ESTATISTICA_PRODUCTO E", "inner join ivitemv1 I", "ON I.item_code = E.item_code"}
        Me.LibXDbSourceTable1.TableName = "ivitemv1"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1072, 504)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Cerrar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(992, 504)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "&Imprimir"
        '
        'frmTreeMenu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1154, 534)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTreeMenu"
        Me.Text = "EXISTENCIA MINIMA"
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Public Sub FillFromMenu(ByVal opcMenu As MainMenu)
    '    For Each OBJMENU As MenuItem In opcMenu.MenuItems
    '        FillTree(OBJMENU)
    '    Next

    'End Sub

    'Private Function LocateNode(ByVal objNodo As TreeNode, ByVal NodeTitle As String) As TreeNode
    '    Dim oTreeNOde As TreeNode

    '    For Each objTreeNode As TreeNode In objNodo.Nodes
    '        If objNodo.Text = NodeTitle Then
    '            oTreeNOde = objTreeNode
    '            Exit For
    '        End If

    '        If objTreeNode.GetNodeCount(False) > 0 Then
    '            oTreeNOde = LocateNode(objTreeNode, NodeTitle)
    '            If Not oTreeNOde Is Nothing Then
    '                Exit For
    '            End If
    '        End If
    '    Next

    '    Return oTreeNOde
    'End Function
    'Public Sub FillTree(ByVal opcMenu As MenuItem, Optional ByVal oNodeParent As TreeNode = Nothing)
    '    Dim oTreeNOde As TreeNode


    '    If oNodeParent Is Nothing Then
    '        oNodeParent = TreeView1.Nodes(0)
    '    End If

    '    oTreeNOde = LocateNode(TreeView1.Nodes(0), opcMenu.Text)

    '    If oTreeNOde Is Nothing Then
    '        oTreeNOde = oNodeParent.Nodes.Add(opcMenu.Text)
    '    End If

    '    For Each OBJMENU As MenuItem In opcMenu.MenuItems
    '        If OBJMENU.Text <> "-" Then
    '            If OBJMENU.MenuItems.Count > 0 Then
    '                FillTree(OBJMENU, oTreeNOde)
    '            Else
    '                oTreeNOde.Nodes.Add(OBJMENU.Text)
    '                cbb_buscar.Items.Add(OBJMENU.Text)
    '            End If
    '        End If
    '    Next

    'End Sub


    Private Sub frmTreeMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LibXConnector1.ExecuteFind()

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        e.AditionalWhere = "(existencia < existencia_min or existencia > exitencia_max) and Ventas > 0"

    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmTreeMenu_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'Try
        '    If LibXConnector1.HasRecords = False Then
        '        Me.Close()
        '    End If
        'Catch ex As Exception
        '    LibX.Log.Add(ex)
        'End Try

    End Sub
End Class
