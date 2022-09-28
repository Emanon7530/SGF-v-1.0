Imports SGT.Inventario.Common
Imports SGT.Inventario.Operaciones
Imports System.Configuration.ConfigurationSettings
Imports SGT.Inventario.Entidades.Documento
Public Class p_ivcount01
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents whse_name As System.Windows.Forms.TextBox
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn4 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn6 As LibX.XEditTextBoxColumn
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnDetail As System.Windows.Forms.Button
    Friend WithEvents btnUnmarkall As System.Windows.Forms.Button
    Friend WithEvents btnMarkAll As System.Windows.Forms.Button
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents gColNumber As LibX.XEditTextBoxColumn
    Friend WithEvents gColPage As LibX.XEditTextBoxColumn
    Friend WithEvents chk_byPage As System.Windows.Forms.CheckBox
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents xtxt_count_number As System.Windows.Forms.TextBox
    Friend WithEvents xdt_count_date As LibX.LibxDateTimePicker
    Friend WithEvents xtxt_whse_code As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chk_byPage = New System.Windows.Forms.CheckBox
        Me.xtxt_count_number = New System.Windows.Forms.TextBox
        Me.xdt_count_date = New LibX.LibxDateTimePicker
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
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
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.whse_name = New System.Windows.Forms.TextBox
        Me.xtxt_whse_code = New System.Windows.Forms.TextBox
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnDetail = New System.Windows.Forms.Button
        Me.btnUnmarkall = New System.Windows.Forms.Button
        Me.btnMarkAll = New System.Windows.Forms.Button
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.gColNumber = New LibX.XEditTextBoxColumn
        Me.gColPage = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn4 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn6 = New LibX.XEditTextBoxColumn
        Me.DataView1 = New System.Data.DataView
        Me.btnAplicar = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_byPage)
        Me.GroupBox1.Controls.Add(Me.xtxt_count_number)
        Me.GroupBox1.Controls.Add(Me.xdt_count_date)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.whse_name)
        Me.GroupBox1.Controls.Add(Me.xtxt_whse_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 72)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio"
        '
        'chk_byPage
        '
        Me.chk_byPage.Checked = True
        Me.chk_byPage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_byPage.Location = New System.Drawing.Point(176, 16)
        Me.chk_byPage.Name = "chk_byPage"
        Me.chk_byPage.Size = New System.Drawing.Size(120, 16)
        Me.chk_byPage.TabIndex = 5
        Me.chk_byPage.Text = "Listar Por Página"
        '
        'xtxt_count_number
        '
        Me.xtxt_count_number.Location = New System.Drawing.Point(112, 16)
        Me.xtxt_count_number.Name = "xtxt_count_number"
        Me.xtxt_count_number.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_count_number.TabIndex = 0
        Me.xtxt_count_number.Text = ""
        '
        'xdt_count_date
        '
        Me.xdt_count_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_count_date.EditInitialValue = Nothing
        Me.xdt_count_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_count_date.FieldDescription = ""
        Me.xdt_count_date.FindInitialValue = Nothing
        Me.xdt_count_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_count_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_count_date.IgnoreRequiered = False
        Me.xdt_count_date.Location = New System.Drawing.Point(384, 16)
        Me.xdt_count_date.Name = "xdt_count_date"
        Me.xdt_count_date.NewInitialValue = Nothing
        Me.xdt_count_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_count_date.Requiered = False
        Me.xdt_count_date.Size = New System.Drawing.Size(96, 20)
        Me.xdt_count_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_count_date.TabIndex = 3
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"whse_code=whse_code", "whse_name=whse_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(464, 40)
        Me.LibXLookup1.LookCaption = "Almacenes"
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.ShowWarning = False
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SizesColumns = Nothing
        Me.LibXLookup1.SizesColumnsTab = Nothing
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"whse_code=whse_code"}
        Me.LibXLookup1.TabIndex = 4
        Me.LibXLookup1.TableName = "ivwhsem"
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = False
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "ivcounte"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = True
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = Nothing
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = Nothing
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8})
        Me.DataTable1.TableName = "ivcounte"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "count_number"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "pageNo"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "count_date"
        Me.DataColumn3.DataType = GetType(System.DateTime)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "count_desc"
        Me.DataColumn4.MaxLength = 60
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "count_status"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "userid"
        Me.DataColumn6.MaxLength = 20
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "whse_code"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Aplicar"
        Me.DataColumn8.DataType = GetType(System.Int16)
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
        Me.LibXDbSourceTable1.SerialColumnName = "count_number"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select distinct ivcounte.count_number,ivcountd.pageNo, ", "", "ivcounte.count_date, count_desc,ivcountd.count_status, userid", "from ivcounte, ivcountd", "where ivcounte.count_number = ivcountd.count_number"}
        Me.LibXDbSourceTable1.TableName = "ivcounte"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(296, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Factura:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(11, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Documento:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(46, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Almacén:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'whse_name
        '
        Me.whse_name.Location = New System.Drawing.Point(176, 40)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.ReadOnly = True
        Me.whse_name.Size = New System.Drawing.Size(288, 20)
        Me.whse_name.TabIndex = 3
        Me.whse_name.Text = ""
        '
        'xtxt_whse_code
        '
        Me.xtxt_whse_code.AcceptsReturn = True
        Me.xtxt_whse_code.Location = New System.Drawing.Point(112, 40)
        Me.xtxt_whse_code.Name = "xtxt_whse_code"
        Me.xtxt_whse_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_whse_code.TabIndex = 1
        Me.xtxt_whse_code.Text = ""
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Location = New System.Drawing.Point(600, 16)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 32)
        Me.btnRefresh.TabIndex = 10
        Me.btnRefresh.Text = "Refrescar"
        '
        'btnDetail
        '
        Me.btnDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDetail.Location = New System.Drawing.Point(168, 495)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(80, 32)
        Me.btnDetail.TabIndex = 9
        Me.btnDetail.Text = "Visualizar"
        '
        'btnUnmarkall
        '
        Me.btnUnmarkall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUnmarkall.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnmarkall.Location = New System.Drawing.Point(88, 495)
        Me.btnUnmarkall.Name = "btnUnmarkall"
        Me.btnUnmarkall.Size = New System.Drawing.Size(80, 32)
        Me.btnUnmarkall.TabIndex = 8
        Me.btnUnmarkall.Text = "Desmarcar Todos"
        '
        'btnMarkAll
        '
        Me.btnMarkAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMarkAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarkAll.Location = New System.Drawing.Point(8, 495)
        Me.btnMarkAll.Name = "btnMarkAll"
        Me.btnMarkAll.Size = New System.Drawing.Size(80, 32)
        Me.btnMarkAll.TabIndex = 7
        Me.btnMarkAll.Text = "Marcar Todos"
        '
        'LibXGrid1
        '
        Me.LibXGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = True
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Hojas de Conteo Pendientes de Aplicar"
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.DataMember = "ivcounte"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 88)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(672, 392)
        Me.LibXGrid1.TabIndex = 15
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Marcar Todos"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Desmarcar Todos"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Visualizar"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "Refrescar"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 5
        Me.MenuItem6.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 6
        Me.MenuItem7.Text = "Aplicar"
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridBoolColumn1, Me.gColNumber, Me.gColPage, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn4, Me.XEditTextBoxColumn6})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivcounte"
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.FalseValue = CType(0, Short)
        Me.DataGridBoolColumn1.HeaderText = "Aplicar"
        Me.DataGridBoolColumn1.MappingName = "Aplicar"
        Me.DataGridBoolColumn1.NullValue = CType(0, Short)
        Me.DataGridBoolColumn1.TrueValue = CType(1, Short)
        Me.DataGridBoolColumn1.Width = 40
        '
        'gColNumber
        '
        Me.gColNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColNumber.Format = ""
        Me.gColNumber.FormatInfo = Nothing
        Me.gColNumber.HeaderText = "Número"
        Me.gColNumber.ImageList = Nothing
        Me.gColNumber.isReadOnly = True
        Me.gColNumber.MappingName = "count_number"
        Me.gColNumber.MaxLength = 32767
        Me.gColNumber.ReadOnly = True
        Me.gColNumber.TabStop = True
        Me.gColNumber.UseCustomCellFormat = True
        Me.gColNumber.Width = 60
        '
        'gColPage
        '
        Me.gColPage.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColPage.Format = ""
        Me.gColPage.FormatInfo = Nothing
        Me.gColPage.HeaderText = "Página No."
        Me.gColPage.ImageList = Nothing
        Me.gColPage.isReadOnly = False
        Me.gColPage.MappingName = "PageNo"
        Me.gColPage.MaxLength = 32767
        Me.gColPage.TabStop = True
        Me.gColPage.UseCustomCellFormat = False
        Me.gColPage.Width = 50
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Fecha"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = True
        Me.XEditTextBoxColumn2.MappingName = "count_date"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.ReadOnly = True
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = True
        Me.XEditTextBoxColumn2.Width = 75
        '
        'XEditTextBoxColumn4
        '
        Me.XEditTextBoxColumn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn4.Format = ""
        Me.XEditTextBoxColumn4.FormatInfo = Nothing
        Me.XEditTextBoxColumn4.HeaderText = "Descripción"
        Me.XEditTextBoxColumn4.ImageList = Nothing
        Me.XEditTextBoxColumn4.isReadOnly = True
        Me.XEditTextBoxColumn4.MappingName = "count_desc"
        Me.XEditTextBoxColumn4.MaxLength = 32767
        Me.XEditTextBoxColumn4.ReadOnly = True
        Me.XEditTextBoxColumn4.TabStop = True
        Me.XEditTextBoxColumn4.UseCustomCellFormat = True
        Me.XEditTextBoxColumn4.Width = 325
        '
        'XEditTextBoxColumn6
        '
        Me.XEditTextBoxColumn6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn6.Format = ""
        Me.XEditTextBoxColumn6.FormatInfo = Nothing
        Me.XEditTextBoxColumn6.HeaderText = "Usuario"
        Me.XEditTextBoxColumn6.ImageList = Nothing
        Me.XEditTextBoxColumn6.isReadOnly = True
        Me.XEditTextBoxColumn6.MappingName = "userid"
        Me.XEditTextBoxColumn6.MaxLength = 32767
        Me.XEditTextBoxColumn6.ReadOnly = True
        Me.XEditTextBoxColumn6.TabStop = True
        Me.XEditTextBoxColumn6.UseCustomCellFormat = True
        Me.XEditTextBoxColumn6.Width = 75
        '
        'DataView1
        '
        Me.DataView1.AllowDelete = False
        Me.DataView1.AllowEdit = False
        Me.DataView1.AllowNew = False
        '
        'btnAplicar
        '
        Me.btnAplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAplicar.Location = New System.Drawing.Point(600, 496)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(80, 32)
        Me.btnAplicar.TabIndex = 10
        Me.btnAplicar.Text = "Aplicar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpiar.Location = New System.Drawing.Point(600, 48)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(80, 32)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "Limpiar"
        '
        'p_ivcount01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 535)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDetail)
        Me.Controls.Add(Me.btnUnmarkall)
        Me.Controls.Add(Me.btnMarkAll)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "p_ivcount01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Aplicar Hoja de Conteo"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub XEditTextBoxColumn1_SetCellFormat(ByVal sender As System.Object, ByVal e As LibX.XDataGridFormatCellEventArgs) Handles XEditTextBoxColumn2.SetCellFormat, XEditTextBoxColumn4.SetCellFormat, XEditTextBoxColumn6.SetCellFormat, gColNumber.SetCellFormat
        Try

            ''''If Not LibX.IsNull(LibXGrid1.Item(e.RowNumber, 6)) Then
            ''''    If LibXGrid1.Item(e.RowNumber, 6) = "SAL" Then
            ''''        e.BackColor = lblSalidas.BackColor
            ''''    End If

            ''''    If LibXGrid1.Item(e.RowNumber, 6) = "ADJ" Then
            ''''        e.BackColor = lblAjustes.BackColor
            ''''    End If

            ''''    If LibXGrid1.Item(e.RowNumber, 6) = "TRF" Then
            ''''        e.BackColor = lblTrasnf.BackColor
            ''''    End If
            ''''End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            If e.Action = LibX.LibxConnectionActions.Find _
            Or e.AcceptedAction = LibX.LibxConnectionActions.Find Then
                DataSet1.Tables(0).Rows.Clear()
                LibXGrid1.ReadOnly = True
            End If

            If e.Action = LibX.LibxConnectionActions.Edit Then
                LibXGrid1.ReadOnly = False
            End If

            If e.AcceptedAction = LibX.LibxConnectionActions.Edit And DataSet1.Tables("ivcounte").Select("Aplicar=1").Length > 0 Then
                Postear()
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAll.Click
        Try
            For Each oRow As DataRow In DataSet1.Tables("ivcounte").Rows  'ivdocsm
                oRow!Aplicar = 1
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnmarkall.Click
        Try
            For Each oRow As DataRow In DataSet1.Tables("ivcounte").Rows  'ivdocsm
                oRow!Aplicar = 0
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub Postear()
        Dim oParamPost As SGT.Inventario.Operaciones.HojaConteo.ParametrosAplicar
        Dim oPost As SGT.Inventario.Operaciones.HojaConteo
        Dim SelectStmt As String
        Dim oiventrdd As DataTable
        Dim oiventrdm As DataTable
        Dim oArticulo As SGT.Inventario.Entidades.Articulo
        Dim oParam As SGT.Inventario.Entidades.Articulo.GetOnHandParameters
        Dim OnHand As Int16
        Dim sWhse As Integer
        Dim XUpdate As LibX.Data.XUpdateStmt
        Try
            If MessageBox.Show("Seguro desea aplicar?", "Aplicar Conteo", _
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
               MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Throw New ApplicationException("Operación Abortada!")
            End If

            oParamPost = New SGT.Inventario.Operaciones.HojaConteo.ParametrosAplicar
            oPost = New SGT.Inventario.Operaciones.HojaConteo

            oArticulo = New SGT.Inventario.Entidades.Articulo
            oParam = New SGT.Inventario.Entidades.Articulo.GetOnHandParameters

            If Me.xtxt_whse_code.Text = "" Then
                sWhse = 1
            Else
                sWhse = Val(xtxt_whse_code.Text)
            End If
            For Each oRow As DataRow In DataSet1.Tables("ivcounte").Select("aplicar=1")

                '// Buscar los productos
                SelectStmt = String.Concat("select * from ivcountd where count_number =", oRow!count_number.ToString & " and whse_code = " & sWhse.ToString)

                If Me.chk_byPage.Checked = True Then
                    SelectStmt = String.Concat(SelectStmt, " and PageNo = ", oRow!PageNo.ToString)
                End If

                oiventrdd = LibX.Data.Manager.GetDataTable(SelectStmt)

                If oiventrdd.Rows.Count <= 0 Then
                    Throw New ApplicationException("No se encontró productos para este documento!")
                End If

                '// Postear a inventario
                With oParamPost
                    .ConteNo = Val(oRow!count_number.ToString)
                    .Fecha = CType(oRow!count_date.ToString, Date)

                    If Me.chk_byPage.Checked = True Then
                        .PaginaNo = Val(oRow!PageNo.ToString)
                    Else
                        .PaginaNo = -1
                    End If
                    .UseTransaction = True

                    If Val(oRow!whse_code.ToString) = 0 Then
                        .Almacen = 1
                    Else
                        .Almacen = (Val(oRow!whse_code.ToString))
                    End If

                End With

                If oPost.AplicarHoja(oParamPost) = False Then
                    Throw New ApplicationException("Error aplicando hoja de conteo")
                End If

                XUpdate = New LibX.Data.XUpdateStmt("ivcountd")

                XUpdate.FieldsSet("count_status") = Val(EstatusHojaConteoEnum.Aplicada)  'Aplicada
                XUpdate.Fields("count_number") = Val(oRow!count_number.ToString)

                If Me.chk_byPage.Checked = True Then
                    XUpdate.Fields("pageno") = Val(oRow!PageNo.ToString)
                End If

                XUpdate.Execute()

                DataSet1.Tables("ivcounte").Rows.Remove(oRow)
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub p_iventr01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.xdt_count_date.Value = DBNull.Value
            btnRefresh_Click(sender, e)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery

        Try
            If Me.chk_byPage.Checked = False Then
                e.Sql = e.Sql.ToLower.Replace("ivcountd.pageno", "0 pageno")
            Else
                e.Sql = e.Sql.ToLower.Replace("0 pageno", "ivcountd.pageno")
            End If

            e.AditionalWhere = "ivcountd.count_status = " & Val(EstatusHojaConteoEnum.Impresa).ToString    'EDITADA

            If Me.xtxt_whse_code.Text.Trim <> "" Then
                e.AditionalWhere &= " and ivcounte.whse_code = " & Me.xtxt_whse_code.Text.Trim
            End If

            If Me.xtxt_count_number.Text.Trim <> "" Then
                e.AditionalWhere &= " and ivcounte.count_number = " & Me.xtxt_count_number.Text.Trim
            End If

            If Not LibX.IsNull(Me.xdt_count_date.Value) Then
                e.AditionalWhere &= " and ivcounte.count_date = '" & CDate(Me.xdt_count_date.Value).ToString(LibX.Data.Manager.GetSaveDateFormat) & "'"
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetail.Click
        Dim ProgParam As LibX.LibxPrgParams
        Try
            ProgParam = New LibX.LibxPrgParams
            With ProgParam
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowPrint = False
                .AllowQuery = False
                .IsFromOther = True
                .initMode = LibX.LibxInitModes.Query
                .WhereToExecute = "ivcounte.count_number = " & LibXGrid1.GetValue(gColNumber).ToString

                If Me.chk_byPage.Checked = True Then
                    .WhereToExecute = .WhereToExecute.Trim & " and ivcountd.pageno = " & LibXGrid1.GetValue(gColPage).ToString
                End If

            End With

            LibX.App.CurrentPrgParams = ProgParam
            LibX.LibXRunner.Run("i_ivcount01", "INV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        btnMarkAll.Enabled = LibXConnector1.HasRecords
        btnUnmarkall.Enabled = LibXConnector1.HasRecords
        btnDetail.Enabled = LibXConnector1.HasRecords
        btnAplicar.Enabled = LibXConnector1.HasRecords

    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        '''Try
        '''    If e.AcceptedAction = LibX.LibxConnectionActions.Find Then
        '''        For Each oRow As DataRow In DataSet1.Tables("ivdocsm").Rows
        '''            Dim nRow As DataRow = DataSet1.Tables("ivdocsm").NewRow
        '''            nRow.ItemArray = oRow.ItemArray
        '''            DataSet1.Tables("ivdocsm").Rows.Add(nRow)
        '''        Next
        '''    End If

        '''Catch ex As Exception
        '''    LibX.Log.Show(ex)
        '''End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''ApplyFilter()

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''ApplyFilter()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            If LibXConnector1.IsDataEditing = True Then
                LibXConnector1.ShowWarningCancel = False
                LibXConnector1.Cancel()
            End If

            LibXConnector1.AcceptFind()

            If LibXConnector1.HasRecords = True Then
                LibXConnector1.Edit()
            Else
                LibXConnector1.Find()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Button10_Click(sender, e)
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Button9_Click(sender, e)
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        btnRefresh_Click(sender, e)
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Try
            DataSet1.Tables("ivcounte").Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1
            Postear()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Button8_Click(Nothing, Nothing)
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_byPage.CheckedChanged
        Try
            If LibXConnector1.HasRecords = True Then
                btnRefresh_Click(sender, e)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Try
            Me.xtxt_count_number.Text = ""
            Me.xtxt_whse_code.Text = ""
            Me.xdt_count_date.Value = DBNull.Value

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click
        Try
            If DataSet1.Tables("ivcounte").Select("Aplicar = 1").Length > 0 Then
                Postear()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class
