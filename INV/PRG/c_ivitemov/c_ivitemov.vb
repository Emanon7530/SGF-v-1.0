Public Class c_itemov
    Inherits System.Windows.Forms.Form
    Dim oDoc As SGT.Facturacion.Entidades.Documento
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents xlk_cust_name As LibX.LibXLookup
    Friend WithEvents mnuVisualizar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPagos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCliente As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCobro As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRelacionado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSeries As System.Windows.Forms.MenuItem
    Friend WithEvents xlnk_type_code As LibX.XDataGridLinkColumn
    Friend WithEvents xlk_vend_code As LibX.LibXLookup
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents item_name As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents xlnk_doc_number As LibX.XDataGridLinkColumn
    Friend WithEvents xlnk_item_code As LibX.XDataGridLinkColumn
    Friend WithEvents xbln_qty As LibX.XDataGridBoolColumn
    Friend WithEvents xlnk_costo As LibX.XDataGridLinkColumn
    Friend WithEvents Xink_price As LibX.XDataGridTextButtonColumn
    Friend WithEvents xink_bf_onhand As LibX.XEditTextBoxColumn
    Friend WithEvents Lk_whse_code As LibX.LibXLookup
    Friend WithEvents whse_name As System.Windows.Forms.Label
    Friend WithEvents Lk_item_code As LibX.LibXLookup
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents xed_tran_number As LibX.XEditTextBoxColumn
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents LibXCombo2 As LibX.LibXCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.Lk_whse_code = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.whse_name = New System.Windows.Forms.Label
        Me.Lk_item_code = New LibX.LibXLookup
        Me.item_name = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.XTextBox1 = New LibX.XTextBox
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuVisualizar = New System.Windows.Forms.MenuItem
        Me.mnuPagos = New System.Windows.Forms.MenuItem
        Me.mnuCliente = New System.Windows.Forms.MenuItem
        Me.mnuCobro = New System.Windows.Forms.MenuItem
        Me.mnuRelacionado = New System.Windows.Forms.MenuItem
        Me.mnuSeries = New System.Windows.Forms.MenuItem
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.xlnk_type_code = New LibX.XDataGridLinkColumn
        Me.xlnk_doc_number = New LibX.XDataGridLinkColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.xed_tran_number = New LibX.XEditTextBoxColumn
        Me.xlnk_item_code = New LibX.XDataGridLinkColumn
        Me.xbln_qty = New LibX.XDataGridBoolColumn
        Me.xlnk_costo = New LibX.XDataGridLinkColumn
        Me.Xink_price = New LibX.XDataGridTextButtonColumn
        Me.xink_bf_onhand = New LibX.XEditTextBoxColumn
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.LibXCombo2 = New LibX.LibXCombo
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LibXCombo2)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Lk_whse_code)
        Me.GroupBox1.Controls.Add(Me.whse_name)
        Me.GroupBox1.Controls.Add(Me.Lk_item_code)
        Me.GroupBox1.Controls.Add(Me.item_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Año:"
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn1, Me.DataColumn2})
        Me.DataTable2.TableName = "ivmodstd"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "doc_number"
        Me.DataColumn39.MaxLength = 20
        '
        'DataColumn40
        '
        Me.DataColumn40.AllowDBNull = False
        Me.DataColumn40.ColumnName = "doc_date"
        Me.DataColumn40.DataType = GetType(System.DateTime)
        '
        'DataColumn41
        '
        Me.DataColumn41.AllowDBNull = False
        Me.DataColumn41.ColumnName = "type_code"
        Me.DataColumn41.MaxLength = 3
        '
        'DataColumn42
        '
        Me.DataColumn42.AllowDBNull = False
        Me.DataColumn42.ColumnName = "reference"
        Me.DataColumn42.MaxLength = 40
        '
        'DataColumn43
        '
        Me.DataColumn43.AllowDBNull = False
        Me.DataColumn43.AutoIncrement = True
        Me.DataColumn43.ColumnName = "trane_number"
        Me.DataColumn43.DataType = GetType(System.Int32)
        Me.DataColumn43.ReadOnly = True
        '
        'DataColumn44
        '
        Me.DataColumn44.AllowDBNull = False
        Me.DataColumn44.ColumnName = "whse_code"
        Me.DataColumn44.DataType = GetType(System.Int32)
        '
        'DataColumn45
        '
        Me.DataColumn45.AllowDBNull = False
        Me.DataColumn45.ColumnName = "item_code"
        Me.DataColumn45.MaxLength = 10
        '
        'DataColumn46
        '
        Me.DataColumn46.AllowDBNull = False
        Me.DataColumn46.ColumnName = "item_name"
        Me.DataColumn46.MaxLength = 100
        '
        'DataColumn47
        '
        Me.DataColumn47.AllowDBNull = False
        Me.DataColumn47.ColumnName = "line_no"
        Me.DataColumn47.DataType = GetType(System.Int32)
        '
        'DataColumn48
        '
        Me.DataColumn48.AllowDBNull = False
        Me.DataColumn48.ColumnName = "costo"
        Me.DataColumn48.DataType = GetType(System.Decimal)
        '
        'DataColumn49
        '
        Me.DataColumn49.AllowDBNull = False
        Me.DataColumn49.ColumnName = "price"
        Me.DataColumn49.DataType = GetType(System.Decimal)
        '
        'DataColumn50
        '
        Me.DataColumn50.AllowDBNull = False
        Me.DataColumn50.ColumnName = "qty"
        Me.DataColumn50.DataType = GetType(System.Int32)
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "bf_onhand"
        Me.DataColumn51.DataType = GetType(System.Int32)
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "mes"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "anio"
        Me.DataColumn2.DataType = GetType(System.Int32)
        Me.DataColumn2.ReadOnly = True
        '
        'Lk_whse_code
        '
        Me.Lk_whse_code.AlternateFieldSearch = Nothing
        Me.Lk_whse_code.CheckText = Nothing
        Me.Lk_whse_code.ComboMode = False
        Me.Lk_whse_code.DataMember = Nothing
        Me.Lk_whse_code.DataSource = Me.LibXConnector1
        Me.Lk_whse_code.DestParameters = New String() {"whse_code=whse_code", "whse_name=whse_name"}
        Me.Lk_whse_code.FilterField = "whse_name"
        Me.Lk_whse_code.IgnoreFindInBrowseMode = False
        Me.Lk_whse_code.isCanceled = False
        Me.Lk_whse_code.Location = New System.Drawing.Point(496, 40)
        Me.Lk_whse_code.LookCaption = ""
        Me.Lk_whse_code.Name = "Lk_whse_code"
        Me.Lk_whse_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.Lk_whse_code.ShowFilter = True
        Me.Lk_whse_code.ShowMessageNotFound = True
        Me.Lk_whse_code.ShowWarning = False
        Me.Lk_whse_code.Size = New System.Drawing.Size(16, 20)
        Me.Lk_whse_code.SizesColumns = Nothing
        Me.Lk_whse_code.SizesColumnsTab = Nothing
        Me.Lk_whse_code.SqlString = Nothing
        Me.Lk_whse_code.SQLTab = Nothing
        Me.Lk_whse_code.SrcParameters = New String() {"whse_code=whse_code"}
        Me.Lk_whse_code.TabIndex = 9
        Me.Lk_whse_code.TableName = "ivwhsem"
        Me.Lk_whse_code.TabStop = False
        Me.Lk_whse_code.UseCopyConnection = False
        Me.Lk_whse_code.UseRowRetrieveEvents = False
        Me.Lk_whse_code.UseTab = False
        Me.Lk_whse_code.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.Lk_whse_code.WhereCondition = Nothing
        Me.Lk_whse_code.WhereParameters = Nothing
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = False
        Me.LibXConnector1.AllowNew = False
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "ivmodstd"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
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
        Me.LibXConnector1.UseTransactions = True
        '
        'LibXDbSourceTable1
        '
        Me.LibXDbSourceTable1.AllowDelete = True
        Me.LibXDbSourceTable1.AllowEdit = True
        Me.LibXDbSourceTable1.AllowNew = True
        Me.LibXDbSourceTable1.AutoIncrementSerial = False
        Me.LibXDbSourceTable1.CustomDbUpdate = False
        Me.LibXDbSourceTable1.DeleteOrder = 0
        Me.LibXDbSourceTable1.FillOnQuery = True
        Me.LibXDbSourceTable1.FillOnRowChange = False
        Me.LibXDbSourceTable1.HeaderIsOnGrid = False
        Me.LibXDbSourceTable1.InnerJon = True
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ivmodstd"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'whse_name
        '
        Me.whse_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.whse_name.Location = New System.Drawing.Point(184, 40)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.Size = New System.Drawing.Size(312, 20)
        Me.whse_name.TabIndex = 8
        '
        'Lk_item_code
        '
        Me.Lk_item_code.AlternateFieldSearch = Nothing
        Me.Lk_item_code.CheckText = Nothing
        Me.Lk_item_code.ComboMode = False
        Me.Lk_item_code.DataMember = Nothing
        Me.Lk_item_code.DataSource = Me.LibXConnector1
        Me.Lk_item_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name"}
        Me.Lk_item_code.FilterField = "item_name"
        Me.Lk_item_code.IgnoreFindInBrowseMode = False
        Me.Lk_item_code.isCanceled = False
        Me.Lk_item_code.Location = New System.Drawing.Point(496, 16)
        Me.Lk_item_code.LookCaption = ""
        Me.Lk_item_code.Name = "Lk_item_code"
        Me.Lk_item_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.Lk_item_code.ShowFilter = True
        Me.Lk_item_code.ShowMessageNotFound = True
        Me.Lk_item_code.ShowWarning = False
        Me.Lk_item_code.Size = New System.Drawing.Size(16, 20)
        Me.Lk_item_code.SizesColumns = Nothing
        Me.Lk_item_code.SizesColumnsTab = Nothing
        Me.Lk_item_code.SqlString = Nothing
        Me.Lk_item_code.SQLTab = Nothing
        Me.Lk_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.Lk_item_code.TabIndex = 7
        Me.Lk_item_code.TableName = "ivitemm"
        Me.Lk_item_code.TabStop = False
        Me.Lk_item_code.UseCopyConnection = False
        Me.Lk_item_code.UseRowRetrieveEvents = False
        Me.Lk_item_code.UseTab = False
        Me.Lk_item_code.VisParameters = New String() {"Código=item_code", "Descripción=item_name"}
        Me.Lk_item_code.WhereCondition = Nothing
        Me.Lk_item_code.WhereParameters = Nothing
        '
        'item_name
        '
        Me.item_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.item_name.Location = New System.Drawing.Point(184, 17)
        Me.item_name.Name = "item_name"
        Me.item_name.Size = New System.Drawing.Size(312, 20)
        Me.item_name.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Almacen:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Producto:"
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivmodstd.whse_code"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(112, 40)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(72, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 1
        Me.XTextBox2.Text = ""
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivmodstd.item_code"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(112, 16)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(72, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 0
        Me.XTextBox1.Text = ""
        '
        'LibXGrid1
        '
        Me.LibXGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = True
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Resultados de Busquedas"
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.DataMember = "ivmodstd"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = True
        Me.LibXGrid1.Location = New System.Drawing.Point(0, 128)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(784, 360)
        Me.LibXGrid1.TabIndex = 1
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuVisualizar, Me.mnuPagos, Me.mnuCliente, Me.mnuCobro, Me.mnuRelacionado, Me.mnuSeries})
        '
        'mnuVisualizar
        '
        Me.mnuVisualizar.Index = 0
        Me.mnuVisualizar.Text = "Visualizar"
        '
        'mnuPagos
        '
        Me.mnuPagos.Index = 1
        Me.mnuPagos.Text = "Pagos"
        '
        'mnuCliente
        '
        Me.mnuCliente.Index = 2
        Me.mnuCliente.Text = "Cliente"
        '
        'mnuCobro
        '
        Me.mnuCobro.Index = 3
        Me.mnuCobro.Text = "Cobro"
        '
        'mnuRelacionado
        '
        Me.mnuRelacionado.Index = 4
        Me.mnuRelacionado.Text = "Relacionado"
        '
        'mnuSeries
        '
        Me.mnuSeries.Index = 5
        Me.mnuSeries.Text = "Series"
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.HighlightText
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.xlnk_type_code, Me.xlnk_doc_number, Me.XEditTextBoxColumn1, Me.xed_tran_number, Me.xlnk_item_code, Me.xbln_qty, Me.xlnk_costo, Me.Xink_price, Me.xink_bf_onhand})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivmodstd"
        '
        'xlnk_type_code
        '
        Me.xlnk_type_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xlnk_type_code.Format = ""
        Me.xlnk_type_code.FormatInfo = Nothing
        Me.xlnk_type_code.HeaderText = "Tipo"
        Me.xlnk_type_code.ImageList = Nothing
        Me.xlnk_type_code.isReadOnly = False
        Me.xlnk_type_code.MappingName = "type_code"
        Me.xlnk_type_code.MaxLength = 32767
        Me.xlnk_type_code.TabStop = True
        Me.xlnk_type_code.UseCustomCellFormat = True
        Me.xlnk_type_code.Width = 35
        '
        'xlnk_doc_number
        '
        Me.xlnk_doc_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xlnk_doc_number.Format = ""
        Me.xlnk_doc_number.FormatInfo = Nothing
        Me.xlnk_doc_number.HeaderText = "Número"
        Me.xlnk_doc_number.ImageList = Nothing
        Me.xlnk_doc_number.isReadOnly = False
        Me.xlnk_doc_number.MappingName = "doc_number"
        Me.xlnk_doc_number.MaxLength = 32767
        Me.xlnk_doc_number.TabStop = True
        Me.xlnk_doc_number.UseCustomCellFormat = True
        Me.xlnk_doc_number.Width = 50
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Fecha"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "doc_date"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = True
        Me.XEditTextBoxColumn1.Width = 65
        '
        'xed_tran_number
        '
        Me.xed_tran_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xed_tran_number.Format = ""
        Me.xed_tran_number.FormatInfo = Nothing
        Me.xed_tran_number.HeaderText = "No Tran"
        Me.xed_tran_number.ImageList = Nothing
        Me.xed_tran_number.isReadOnly = False
        Me.xed_tran_number.MappingName = "trane_number"
        Me.xed_tran_number.MaxLength = 32767
        Me.xed_tran_number.TabStop = True
        Me.xed_tran_number.UseCustomCellFormat = True
        Me.xed_tran_number.Width = 75
        '
        'xlnk_item_code
        '
        Me.xlnk_item_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xlnk_item_code.Format = ""
        Me.xlnk_item_code.FormatInfo = Nothing
        Me.xlnk_item_code.HeaderText = "Codigo"
        Me.xlnk_item_code.ImageList = Nothing
        Me.xlnk_item_code.isReadOnly = False
        Me.xlnk_item_code.MappingName = "item_code"
        Me.xlnk_item_code.MaxLength = 32767
        Me.xlnk_item_code.TabStop = True
        Me.xlnk_item_code.UseCustomCellFormat = True
        Me.xlnk_item_code.Width = 75
        '
        'xbln_qty
        '
        Me.xbln_qty.FalseValue = CType(1, Short)
        Me.xbln_qty.HeaderText = "Cantidad"
        Me.xbln_qty.MappingName = "qty"
        Me.xbln_qty.NullValue = 0
        Me.xbln_qty.TrueValue = CType(2, Short)
        Me.xbln_qty.UseCustomCellFormat = True
        Me.xbln_qty.Width = 50
        '
        'xlnk_costo
        '
        Me.xlnk_costo.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xlnk_costo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xlnk_costo.Format = "###,###.00"
        Me.xlnk_costo.FormatInfo = Nothing
        Me.xlnk_costo.HeaderText = "Costo"
        Me.xlnk_costo.ImageList = Nothing
        Me.xlnk_costo.isReadOnly = False
        Me.xlnk_costo.MappingName = "costo"
        Me.xlnk_costo.MaxLength = 32767
        Me.xlnk_costo.TabStop = True
        Me.xlnk_costo.UseCustomCellFormat = True
        Me.xlnk_costo.Width = 75
        '
        'Xink_price
        '
        Me.Xink_price.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.Xink_price.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Xink_price.executeFindDuringFill = True
        Me.Xink_price.Format = "###,###.00"
        Me.Xink_price.FormatInfo = Nothing
        Me.Xink_price.HeaderText = "Precio"
        Me.Xink_price.isReadOnly = False
        Me.Xink_price.MappingName = "price"
        Me.Xink_price.MaxLength = 32767
        Me.Xink_price.TabStop = True
        Me.Xink_price.UseCustomCellFormat = False
        Me.Xink_price.Width = 75
        '
        'xink_bf_onhand
        '
        Me.xink_bf_onhand.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xink_bf_onhand.Format = ""
        Me.xink_bf_onhand.FormatInfo = Nothing
        Me.xink_bf_onhand.HeaderText = "Balance"
        Me.xink_bf_onhand.ImageList = Nothing
        Me.xink_bf_onhand.isReadOnly = False
        Me.xink_bf_onhand.MappingName = "bf_onhand"
        Me.xink_bf_onhand.MaxLength = 32767
        Me.xink_bf_onhand.TabStop = True
        Me.xink_bf_onhand.UseCustomCellFormat = False
        Me.xink_bf_onhand.Width = 75
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Nothing
        Me.LibXNavigator1.FirstControlInFindMode = Nothing
        Me.LibXNavigator1.FirstControlInNewMode = Nothing
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(804, 24)
        Me.LibXNavigator1.TabIndex = 4
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.DataSet1, "ivmodstd.anio"))
        Me.LibXCombo1.DataSource = Me.DataSet1
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DisplayMember = "ivmodstd.anio"
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Location = New System.Drawing.Point(224, 64)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = "anio"
        Me.LibXCombo1.LookupTableName = "ivmodstd"
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(64, 21)
        Me.LibXCombo1.SqlString = "select distinct anio from ivmodstd order by anio"
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 12
        Me.LibXCombo1.ValueMember = "ivmodstd.anio"
        '
        'LibXCombo2
        '
        Me.LibXCombo2.AllowDefaultSort = True
        Me.LibXCombo2.bound = True
        Me.LibXCombo2.currValue = Nothing
        Me.LibXCombo2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.DataSet1, "ivmodstd.mes"))
        Me.LibXCombo2.DataSource = Me.DataSet1
        Me.LibXCombo2.DefaultWhereString = Nothing
        Me.LibXCombo2.DisplayMember = "ivmodstd.mes"
        Me.LibXCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo2.EditInitialValue = Nothing
        Me.LibXCombo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.FieldDescription = ""
        Me.LibXCombo2.FindInitialValue = Nothing
        Me.LibXCombo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.IgnoreRequiered = False
        Me.LibXCombo2.Location = New System.Drawing.Point(112, 64)
        Me.LibXCombo2.LookupKeyDisplayFields = Nothing
        Me.LibXCombo2.LookupKeyField = "mes"
        Me.LibXCombo2.LookupTableName = "ivmodstd"
        Me.LibXCombo2.Name = "LibXCombo2"
        Me.LibXCombo2.NewInitialValue = Nothing
        Me.LibXCombo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.Requiered = False
        Me.LibXCombo2.Required = False
        Me.LibXCombo2.Size = New System.Drawing.Size(72, 21)
        Me.LibXCombo2.SqlString = "select distinct mes from ivmodstd order by mes"
        Me.LibXCombo2.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo2.TabIndex = 13
        Me.LibXCombo2.ValueMember = "ivmodstd.mes"
        '
        'c_itemov
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(804, 526)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "c_itemov"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consultar Movimientos Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try

            'If e.Action = LibX.LibxConnectionActions.Find Then
            '    '// limpiar las condiciones unbound
            '    rdb_Contado.Checked = False
            '    rdb_Credito.Checked = False

            '    '// Asignar la fecha de busqueda desde el primero del mes y ano
            '    '// acutal hasta la fecha actual
            '    xdt_FechaFin.Value = LibX.Data.Manager.Connection.GetDate
            '    xdt_FechaInicio.Value = DateSerial(LibX.Data.Manager.Connection.GetDate.Year, LibX.Data.Manager.Connection.GetDate.Month, 1)

            '    '// Limpiar los resultados anteriores
            '    ftfactd.Rows.Clear()
            'End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim DataCol(1) As DataColumn
        Dim LoadAll As Integer = 1

        Try
            e.DoFill = False

            'SelectStmt = String.Concat("select distinct ftfactm.type_code,ftfactm.fact_number,ftfactm.fact_date,", _
            '                           " ftfactm.fact_status, ftfactm.phone,ftfactm.cust_code,", _
            '                            " ftfactm.vend_code,ftfactm.bus_name,cccustm.cust_name,", _
            '                            " ftfactm.fact_total, ftfactm.fact_cond,ftfactm.ftserial_no,ftfactm.descto,ftfactm.itbis, ", _
            '                            "Case fact_status when 1 then  'En Almacen' ", _
            '                            " when 2 then 'En Caja' when 3 then 'Despachada' when 0 then ", _
            '                            " 'Anulada' End Estatus ", _
            '                            " from ftfactm left outer join ftfactd ", _
            '                            " on ftfactd.ftserial_no = ftfactm.ftserial_no ", _
            '                            " left outer join ftseriem ", _
            '                            " on ftfactd.ftserial_no = ftseriem.ftserial_no ", _
            '                            " and ftfactd.line_no = ftseriem.line_no ", _
            '                            " left outer join ivitemm on ivitemm.item_code = ftfactd.item_code ", _
            '                            " left outer join cccustm ", _
            '                            " on cccustm.cust_code = ftfactm.cust_code where 1=1 ")
            SelectStmt = String.Concat("select * from ivmodstd")

            If Trim(e.Where) <> "" Then
                SelectStmt = SelectStmt.Trim & " and " & e.Where
            End If

            'If LibX.IsNull(Me.Xt_mes.Value) = False Then
            '    SelectStmt &= " and ftfactm.fact_date between '" & CType(xdt_FechaInicio.Value, Date).ToString(LibX.Data.Manager.GetSaveDateFormat) & _
            '                  "' and '" & CType(xdt_FechaFin.Value, Date).ToString(LibX.Data.Manager.GetSaveDateFormat) & "'"
            'End If

            'SelectStmt = oDoc.PrepareSelectStmt(SelectStmt)

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)
            oTable.TableName = "ivmodstd"

            DataSet1.Merge(oTable, False, MissingSchemaAction.Ignore)

            LibXConnector1.HasRecords = (oTable.Rows.Count > 0)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If LibXConnector1.IsEditing Then
            LibXConnector1.CurrentDataRow!fact_cond = 1
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If LibXConnector1.IsEditing Then
            LibXConnector1.CurrentDataRow!fact_cond = 2
        End If
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVisualizar.Click, xlnk_doc_number.LinkeClicked
        Dim xParam As LibX.LibxPrgParams
        Dim xParamAdm As SGT.Administracion.Entidades.Program.ParametrosVizualizar
        Dim xProgram As SGT.Administracion.Entidades.Program
        Try
            xParam = New LibX.LibxPrgParams
            xParamAdm = New SGT.Administracion.Entidades.Program.ParametrosVizualizar
            xProgram = New SGT.Administracion.Entidades.Program

            xParam.AllowDelete = False
            xParam.AllowEdit = False
            xParam.AllowNew = False
            xParam.AllowPrint = True
            xParam.AllowQuery = False

            xParam.Value = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xed_tran_number)
            xParam.initMode = LibX.LibxInitModes.Query
            xParam.WhereToExecute = "ivmodstd.trane_number = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xed_tran_number)

            xParamAdm.Parametros = xParam
            xParamAdm.TipoDocumento = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_type_code)

            xProgram.Visualizar(xParamAdm)

            '''If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_type_code) = "FCT" Then
            '''    LibX.LibXRunner.Run("i_ftfact01", "FCT")
            '''End If

            '''If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_type_code) = "FTS" Then
            '''    LibX.LibXRunner.Run("i_ftfact02", "FCT")
            '''End If

            '''If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_type_code) = "DVF" Then
            '''    LibX.LibXRunner.Run("i_ftdevm01", "FCT")
            '''End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCliente.Click
    '    Dim xParam As LibX.LibxPrgParams
    '    Try
    '        xParam = New LibX.LibxPrgParams
    '        xParam.AllowDelete = False
    '        xParam.AllowEdit = False
    '        xParam.AllowNew = False
    '        xParam.AllowPrint = True
    '        xParam.AllowQuery = False

    '        xParam.WhereToExecute = "cccustm.cust_code = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_cust_code).ToString

    '        LibX.App.CurrentPrgParams = xParam

    '        LibX.LibXRunner.Run("i_custrm01", "CXC")

    '    Catch ex As Exception
    '        LibX.Log.Show(ex)
    '    End Try
    'End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPagos.Click, xlnk_item_code.LinkeClicked
    '    Dim oParam As LibX.LibxPrgParams

    '    Dim WhereStmt As String
    '    Try
    '        oParam = New LibX.LibxPrgParams
    '        oParam.WhereToExecute = "ccinvcem.type_code = '" & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_type_code).ToString & "'" & _
    '                                " and ccinvcem.invce_no = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_fact_number).ToString
    '        LibX.App.CurrentPrgParams = oParam

    '        LibX.LibXRunner.Run("c_ccdocs01", "CXC", True)
    '    Catch ex As Exception
    '        LibX.Log.Show(ex)
    '    End Try
    'End Sub

    'Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCobro.Click, xlnk_costo.LinkeClicked
    '    Dim oParam As LibX.LibxPrgParams
    '    Dim WhereStmt As String
    '    Try
    '        oParam = New LibX.LibxPrgParams
    '        oParam.WhereToExecute = "ivmodstd.trane_number = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xed_tran_number).ToString
    '        LibX.App.CurrentPrgParams = oParam

    '        LibX.LibXRunner.Run("c_ftdocs03", "FCT", True)
    '    Catch ex As Exception
    '        LibX.Log.Show(ex)
    '    End Try

    'End Sub

    'Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRelacionado.Click, xlnk_type_code.LinkeClicked
    '    Dim oParam As LibX.LibxPrgParams
    '    Dim WhereStmt As String
    '    Try
    '        oParam = New LibX.LibxPrgParams
    '        oParam.Datos.Add("type_code", LibXGrid1.GetValue(xlnk_type_code))
    '        oParam.Datos.Add("fact_number", LibXGrid1.GetValue(xlnk_fact_number))
    '        oParam.WhereToExecute = "ftfactv.ftserial_afect = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xed_tran_number).ToString
    '        LibX.App.CurrentPrgParams = oParam

    '        LibX.LibXRunner.Run("c_ftdocs02", "FCT", True)
    '    Catch ex As Exception
    '        LibX.Log.Show(ex)
    '    End Try

    'End Sub


    'Private Sub btnSeries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSeries.Click
    '    Dim Param As LibX.LibxPrgParams
    '    Try
    '        If ivmodstd.Rows.Count <= 0 Then
    '            Exit Sub
    '        End If

    '        Param = New LibX.LibxPrgParams


    '        If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "FCT" Then
    '            With Param
    '                .Value = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xed_tran_number)
    '            End With
    '            LibX.App.CurrentPrgParams = Param

    '            LibX.LibXRunner.Run("i_ftserial", "FCT", True)
    '        End If

    '        If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "DVF" Then
    '            With Param
    '                If LibXConnector1.IsDataEditing Then
    '                    .Datos.Add("usetransaction", False)
    '                End If

    '                .Datos.Add("trane_numer", LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xed_tran_number))
    '                '.Datos.Add("ftserial_afect", LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xedSerial_afect))
    '            End With

    '            LibX.App.CurrentPrgParams = Param
    '            LibX.LibXRunner.Run("i_ftserial02", "FCT", True)
    '        End If

    '    Catch ex As Exception
    '        LibX.Log.Show(ex)
    '    End Try
    'End Sub

    'Private Sub rdb_Contado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    Try
    '        'If LibXConnector1.IsEditing Then
    '        '    If Asc(e.KeyChar) = Keys.Escape Then
    '        '        rdb_Contado.Checked = False
    '        '        LibXConnector1.CurrentDataRow!fact_cond = DBNull.Value
    '        '    End If
    '        'End If

    '    Catch ex As Exception
    '        LibX.Log.Show(ex)
    '    End Try
    'End Sub

    'Private Sub rdb_Credito_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    Try
    '        If LibXConnector1.IsEditing Then
    '            If Asc(e.KeyChar) = Keys.Escape Then
    '                rdb_Credito.Checked = False
    '                LibXConnector1.CurrentDataRow!fact_cond = DBNull.Value
    '            End If
    '        End If

    '    Catch ex As Exception
    '        LibX.Log.Show(ex)
    '    End Try
    'End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try

            'btnCliente.Enabled = (e.isEditing = False And ftfactd.Rows.Count > 0)
            'btnCobros.Enabled = (e.isEditing = False And ftfactd.Rows.Count > 0)
            'btnPagos.Enabled = (e.isEditing = False And ftfactd.Rows.Count > 0)
            'btnRelacionado.Enabled = (e.isEditing = False And ftfactd.Rows.Count > 0)
            'btnSeries.Enabled = (e.isEditing = False And ftfactd.Rows.Count > 0)
            'btnVisualizar.Enabled = (e.isEditing = False And ftfactd.Rows.Count > 0)

            'gbx_Filter.Enabled = (e.isEditing = False And ftfactd.Rows.Count > 0)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles LibXGrid1.Navigate

    End Sub

    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid1.CurrentRowChanged
        Try
            If e.row < 0 Then
                Exit Sub
            End If

            'If ftfactd.Rows.Count > 0 Then
            '    btnCliente.Enabled = Not LibX.IsNull(LibXGrid1.GetValue(xlnk_cust_code))
            '    'btnCobros.Enabled = LibXGrid1.GetValue(xedfact_status) = 3
            '    btnPagos.Enabled = LibXGrid1.GetValue(xbln_fact_cond) = True
            '    btnSeries.Enabled = (LibXGrid1.GetValue(xlnk_type_code) = "FCT" OrElse LibXGrid1.GetValue(xlnk_type_code) = "DVF")
            'End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub c_ftdocs01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LibXGrid1.getCurrentGridView.Sort = "type_code,doc_number"
            LibXGrid1.footerOperations.add("type_code", "count(type_code)")
            LibXGrid1.footerOperations.add("bf_onhand", "sum(bf_onhand)")

            oDoc = New SGT.Facturacion.Entidades.Documento

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub


    'Private Sub xbln_fact_cond_SetCellFormat(ByVal sender As Object, ByVal e As LibX.XDataGridFormatCellEventArgs) Handles xbln_fact_cond.SetCellFormat, XEditTextBoxColumn1.SetCellFormat, XEditTextBoxColumn2.SetCellFormat, XEditTextBoxColumn3.SetCellFormat, xlnk_bus_name.SetCellFormat, xlnk_cust_code.SetCellFormat, xlnk_fact_number.SetCellFormat, xlnk_fact_total.SetCellFormat, xlnk_type_code.SetCellFormat, xed_status_name.SetCellFormat
    '    Try

    '        If LibXGrid1.GetValue(e.RowNumber, xlnk_type_code) = "FCT" Then
    '            If (LibXGrid1.GetValue(e.RowNumber, xbln_fact_cond).ToString.Trim <> "" AndAlso LibXGrid1.GetValue(e.RowNumber, xbln_fact_cond) = False) Then
    '                e.BackColor = lblContado.BackColor
    '            Else
    '                e.BackColor = lblCredito.BackColor
    '            End If
    '        End If

    '        If LibXGrid1.GetValue(e.RowNumber, xlnk_type_code) = "DVF" Then
    '            e.BackColor = lbldevoluciones.BackColor
    '        End If

    '        If LibXGrid1.GetValue(e.RowNumber, xlnk_type_code) = "FTS" Then
    '            e.BackColor = lblServicios.BackColor
    '        End If


    '    Catch ex As Exception
    '        LibX.Log.Show(ex)
    '    End Try
    'End Sub

    'Private Sub chk_Facturas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim Filter As String = ""
    '    Try
    '        If chk_contado.Checked = True And chk_credito.Checked = True Then
    '            Filter = "(type_code ='FCT' and (fact_cond=1 or fact_cond=2))"

    '        ElseIf chk_contado.Checked = True Then
    '            Filter = "(type_code ='FCT' and fact_cond=1)"

    '        ElseIf chk_credito.Checked = True Then
    '            Filter = "(type_code ='FCT' and fact_cond=2)"

    '        End If

    '        If chk_Devoluciones.Checked = True Then
    '            If Filter.Trim.Length > 0 Then
    '                Filter &= " or (type_code = 'DVF')"
    '            Else
    '                Filter = " (type_code = 'DVF')"
    '            End If
    '        End If

    '        If chk_servicios.Checked = True Then
    '            If Filter.Trim.Length > 0 Then
    '                Filter &= " or (type_code = 'FTS')"
    '            Else
    '                Filter = " (type_code = 'FTS')"
    '            End If
    '        End If

    '        LibXGrid1.getCurrentGridView.RowFilter = Filter
    '    Catch ex As Exception
    '        LibX.Log.Show(ex)
    '    End Try
    'End Sub

    Private Sub ftfactd_RowChanged(ByVal sender As System.Object, ByVal e As System.Data.DataRowChangeEventArgs)
        Try
            Dim idx As Integer
           If e.Action = DataRowAction.Add Then
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    End Class
