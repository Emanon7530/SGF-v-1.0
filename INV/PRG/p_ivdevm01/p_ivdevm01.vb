Imports SGT.Inventario.Common
Imports SGT.Inventario.Operaciones
Imports System.Configuration.ConfigurationSettings

Public Class p_ivdevm01
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents whse_name As System.Windows.Forms.TextBox
    Friend WithEvents prov_name As System.Windows.Forms.TextBox
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents gColTipo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ivdevolm As System.Data.DataTable
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents xcbo_dev_type As LibX.LibXCombo
    Friend WithEvents xtxt_dev_number As System.Windows.Forms.TextBox
    Friend WithEvents xdt_dev_date As LibX.LibxDateTimePicker
    Friend WithEvents xlk_whse_code As LibX.LibXLookup
    Friend WithEvents xlk_prov_code As LibX.LibXLookup
    Friend WithEvents xtxt_whse_code As System.Windows.Forms.TextBox
    Friend WithEvents xtxt_prov_code As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn5 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xcbo_dev_type = New LibX.LibXCombo
        Me.xtxt_dev_number = New System.Windows.Forms.TextBox
        Me.xdt_dev_date = New LibX.LibxDateTimePicker
        Me.xlk_whse_code = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ivdevolm = New System.Data.DataTable
        Me.DataColumn36 = New System.Data.DataColumn
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
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.whse_name = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.prov_name = New System.Windows.Forms.TextBox
        Me.xlk_prov_code = New LibX.LibXLookup
        Me.xtxt_whse_code = New System.Windows.Forms.TextBox
        Me.xtxt_prov_code = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
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
        Me.gColTipo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn4 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn6 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn5 = New LibX.XEditTextBoxColumn
        Me.DataView1 = New System.Data.DataView
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnAplicar = New System.Windows.Forms.Button
        Me.DataColumn11 = New System.Data.DataColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivdevolm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xcbo_dev_type)
        Me.GroupBox1.Controls.Add(Me.xtxt_dev_number)
        Me.GroupBox1.Controls.Add(Me.xdt_dev_date)
        Me.GroupBox1.Controls.Add(Me.xlk_whse_code)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.whse_name)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.prov_name)
        Me.GroupBox1.Controls.Add(Me.xlk_prov_code)
        Me.GroupBox1.Controls.Add(Me.xtxt_whse_code)
        Me.GroupBox1.Controls.Add(Me.xtxt_prov_code)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 120)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio"
        '
        'xcbo_dev_type
        '
        Me.xcbo_dev_type.AllowDefaultSort = True
        Me.xcbo_dev_type.bound = True
        Me.xcbo_dev_type.currValue = Nothing
        Me.xcbo_dev_type.DefaultWhereString = "type_code in ('DVI','REP')"
        Me.xcbo_dev_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_dev_type.EditInitialValue = Nothing
        Me.xcbo_dev_type.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_dev_type.FieldDescription = ""
        Me.xcbo_dev_type.FindInitialValue = Nothing
        Me.xcbo_dev_type.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_dev_type.IgnoreRequiered = False
        Me.xcbo_dev_type.Location = New System.Drawing.Point(112, 40)
        Me.xcbo_dev_type.LookupKeyDisplayFields = "type_name"
        Me.xcbo_dev_type.LookupKeyField = "type_code"
        Me.xcbo_dev_type.LookupTableName = "ivtypem"
        Me.xcbo_dev_type.Name = "xcbo_dev_type"
        Me.xcbo_dev_type.NewInitialValue = Nothing
        Me.xcbo_dev_type.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_dev_type.Requiered = False
        Me.xcbo_dev_type.Required = False
        Me.xcbo_dev_type.Size = New System.Drawing.Size(368, 21)
        Me.xcbo_dev_type.SqlString = Nothing
        Me.xcbo_dev_type.StatusBarPanelDescripcion = Nothing
        Me.xcbo_dev_type.TabIndex = 5
        '
        'xtxt_dev_number
        '
        Me.xtxt_dev_number.AcceptsReturn = True
        Me.xtxt_dev_number.Location = New System.Drawing.Point(112, 16)
        Me.xtxt_dev_number.Name = "xtxt_dev_number"
        Me.xtxt_dev_number.Size = New System.Drawing.Size(104, 20)
        Me.xtxt_dev_number.TabIndex = 0
        Me.xtxt_dev_number.Text = ""
        '
        'xdt_dev_date
        '
        Me.xdt_dev_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_dev_date.EditInitialValue = Nothing
        Me.xdt_dev_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_dev_date.FieldDescription = ""
        Me.xdt_dev_date.FindInitialValue = Nothing
        Me.xdt_dev_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_dev_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_dev_date.IgnoreRequiered = False
        Me.xdt_dev_date.Location = New System.Drawing.Point(384, 16)
        Me.xdt_dev_date.Name = "xdt_dev_date"
        Me.xdt_dev_date.NewInitialValue = Nothing
        Me.xdt_dev_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_dev_date.Requiered = False
        Me.xdt_dev_date.Size = New System.Drawing.Size(96, 20)
        Me.xdt_dev_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_dev_date.TabIndex = 3
        '
        'xlk_whse_code
        '
        Me.xlk_whse_code.AlternateFieldSearch = Nothing
        Me.xlk_whse_code.BeginCheck = False
        Me.xlk_whse_code.CheckText = Nothing
        Me.xlk_whse_code.ComboMode = False
        Me.xlk_whse_code.DataMember = Nothing
        Me.xlk_whse_code.DataSource = Me.LibXConnector1
        Me.xlk_whse_code.DestParameters = New String() {"xtxt_whse_code=whse_code", "whse_name=whse_name"}
        Me.xlk_whse_code.FilterField = Nothing
        Me.xlk_whse_code.IgnoreFindInBrowseMode = False
        Me.xlk_whse_code.isCanceled = False
        Me.xlk_whse_code.Location = New System.Drawing.Point(464, 64)
        Me.xlk_whse_code.LookCaption = "Almacenes"
        Me.xlk_whse_code.Name = "xlk_whse_code"
        Me.xlk_whse_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_whse_code.ShowFilter = True
        Me.xlk_whse_code.ShowMessageNotFound = True
        Me.xlk_whse_code.ShowWarning = False
        Me.xlk_whse_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_whse_code.SizesColumns = Nothing
        Me.xlk_whse_code.SizesColumnsTab = Nothing
        Me.xlk_whse_code.SqlString = Nothing
        Me.xlk_whse_code.SQLTab = Nothing
        Me.xlk_whse_code.SrcParameters = New String() {"xtxt_whse_code=whse_code"}
        Me.xlk_whse_code.TabIndex = 4
        Me.xlk_whse_code.TableName = "ivwhsem"
        Me.xlk_whse_code.TabStop = False
        Me.xlk_whse_code.UseCopyConnection = False
        Me.xlk_whse_code.UseRowRetrieveEvents = False
        Me.xlk_whse_code.UseTab = False
        Me.xlk_whse_code.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.xlk_whse_code.WhereCondition = Nothing
        Me.xlk_whse_code.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "ivdevolm"
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
        Me.LibXConnector1.ReportObject = Nothing
        Me.LibXConnector1.RequeryData = False
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
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivdevolm})
        '
        'ivdevolm
        '
        Me.ivdevolm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn36, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.ivdevolm.TableName = "ivdevolm"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "Aplicar"
        Me.DataColumn36.DataType = GetType(System.Int16)
        Me.DataColumn36.DefaultValue = CType(0, Short)
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "dev_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "type_code"
        Me.DataColumn2.MaxLength = 3
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "dev_number"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "dev_date"
        Me.DataColumn4.DataType = GetType(System.DateTime)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "prov_name"
        Me.DataColumn5.MaxLength = 60
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "term_code"
        Me.DataColumn6.MaxLength = 5
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "amount"
        Me.DataColumn7.DataType = GetType(System.Decimal)
        Me.DataColumn7.ReadOnly = True
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "userid"
        Me.DataColumn8.MaxLength = 20
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "prov_code"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "itbis_amount"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'LibXDbSourceTable1
        '
        Me.LibXDbSourceTable1.AllowDelete = True
        Me.LibXDbSourceTable1.AllowEdit = True
        Me.LibXDbSourceTable1.AllowNew = True
        Me.LibXDbSourceTable1.AutoIncrementSerial = False
        Me.LibXDbSourceTable1.CustomDbUpdate = True
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
        Me.LibXDbSourceTable1.Source = New String() {"select ivdevolm.dev_serial,", "type_code,", "dev_number,", "dev_date,", "ivdevolm.prov_code,", "prov_name, ", "term_code,", "itbis_amount,", "amount ,", "ivdevolm.userid,", "suc_code", "from ivdevolm ", "inner join cpprovm", "on cpprovm.prov_code = ivdevolm.prov_code"}
        Me.LibXDbSourceTable1.TableName = "ivdevolm"
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
        Me.Label1.Location = New System.Drawing.Point(17, 16)
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
        Me.Label3.Location = New System.Drawing.Point(52, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Almacén:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'whse_name
        '
        Me.whse_name.Location = New System.Drawing.Point(176, 64)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.ReadOnly = True
        Me.whse_name.Size = New System.Drawing.Size(288, 20)
        Me.whse_name.TabIndex = 3
        Me.whse_name.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(54, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Suplidor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'prov_name
        '
        Me.prov_name.Location = New System.Drawing.Point(176, 88)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.ReadOnly = True
        Me.prov_name.Size = New System.Drawing.Size(288, 20)
        Me.prov_name.TabIndex = 3
        Me.prov_name.Text = ""
        '
        'xlk_prov_code
        '
        Me.xlk_prov_code.AlternateFieldSearch = Nothing
        Me.xlk_prov_code.BeginCheck = False
        Me.xlk_prov_code.CheckText = Nothing
        Me.xlk_prov_code.ComboMode = False
        Me.xlk_prov_code.DataMember = Nothing
        Me.xlk_prov_code.DataSource = Me.LibXConnector1
        Me.xlk_prov_code.DestParameters = New String() {"xtxt_prov_code=prov_code", "prov_name=prov_name"}
        Me.xlk_prov_code.FilterField = Nothing
        Me.xlk_prov_code.IgnoreFindInBrowseMode = False
        Me.xlk_prov_code.isCanceled = False
        Me.xlk_prov_code.Location = New System.Drawing.Point(464, 88)
        Me.xlk_prov_code.LookCaption = "Suplidores"
        Me.xlk_prov_code.Name = "xlk_prov_code"
        Me.xlk_prov_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_prov_code.ShowFilter = True
        Me.xlk_prov_code.ShowMessageNotFound = True
        Me.xlk_prov_code.ShowWarning = False
        Me.xlk_prov_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_prov_code.SizesColumns = Nothing
        Me.xlk_prov_code.SizesColumnsTab = Nothing
        Me.xlk_prov_code.SqlString = Nothing
        Me.xlk_prov_code.SQLTab = Nothing
        Me.xlk_prov_code.SrcParameters = New String() {"xtxt_prov_code=prov_code"}
        Me.xlk_prov_code.TabIndex = 4
        Me.xlk_prov_code.TableName = "cpprovm"
        Me.xlk_prov_code.TabStop = False
        Me.xlk_prov_code.UseCopyConnection = False
        Me.xlk_prov_code.UseRowRetrieveEvents = False
        Me.xlk_prov_code.UseTab = False
        Me.xlk_prov_code.VisParameters = New String() {"Código=prov_code", "Nombre=prov_name", "Tipo=prov_type"}
        Me.xlk_prov_code.WhereCondition = Nothing
        Me.xlk_prov_code.WhereParameters = Nothing
        '
        'xtxt_whse_code
        '
        Me.xtxt_whse_code.AcceptsReturn = True
        Me.xtxt_whse_code.Location = New System.Drawing.Point(112, 64)
        Me.xtxt_whse_code.Name = "xtxt_whse_code"
        Me.xtxt_whse_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_whse_code.TabIndex = 1
        Me.xtxt_whse_code.Text = ""
        '
        'xtxt_prov_code
        '
        Me.xtxt_prov_code.AcceptsReturn = True
        Me.xtxt_prov_code.Location = New System.Drawing.Point(112, 88)
        Me.xtxt_prov_code.Name = "xtxt_prov_code"
        Me.xtxt_prov_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_prov_code.TabIndex = 2
        Me.xtxt_prov_code.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(13, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tipo Documento:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Location = New System.Drawing.Point(640, 96)
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
        Me.LibXGrid1.CaptionText = "Documentos pendientes"
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.DataMember = "ivdevolm"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 136)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(712, 336)
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
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridBoolColumn1, Me.gColTipo, Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn4, Me.XEditTextBoxColumn6, Me.XEditTextBoxColumn3, Me.XEditTextBoxColumn5})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivdevolm"
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
        'gColTipo
        '
        Me.gColTipo.Format = ""
        Me.gColTipo.FormatInfo = Nothing
        Me.gColTipo.HeaderText = "Tipo"
        Me.gColTipo.MappingName = "type_code"
        Me.gColTipo.ReadOnly = True
        Me.gColTipo.Width = 60
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Número"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = True
        Me.XEditTextBoxColumn1.MappingName = "dev_number"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.ReadOnly = True
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = True
        Me.XEditTextBoxColumn1.Width = 80
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Fecha"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = True
        Me.XEditTextBoxColumn2.MappingName = "dev_date"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.ReadOnly = True
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = True
        Me.XEditTextBoxColumn2.Width = 80
        '
        'XEditTextBoxColumn4
        '
        Me.XEditTextBoxColumn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn4.Format = ""
        Me.XEditTextBoxColumn4.FormatInfo = Nothing
        Me.XEditTextBoxColumn4.HeaderText = "Suplidor"
        Me.XEditTextBoxColumn4.ImageList = Nothing
        Me.XEditTextBoxColumn4.isReadOnly = True
        Me.XEditTextBoxColumn4.MappingName = "prov_name"
        Me.XEditTextBoxColumn4.MaxLength = 32767
        Me.XEditTextBoxColumn4.ReadOnly = True
        Me.XEditTextBoxColumn4.TabStop = True
        Me.XEditTextBoxColumn4.UseCustomCellFormat = True
        Me.XEditTextBoxColumn4.Width = 240
        '
        'XEditTextBoxColumn6
        '
        Me.XEditTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn6.Format = "###,##0.00"
        Me.XEditTextBoxColumn6.FormatInfo = Nothing
        Me.XEditTextBoxColumn6.HeaderText = "Montoi"
        Me.XEditTextBoxColumn6.ImageList = Nothing
        Me.XEditTextBoxColumn6.isReadOnly = True
        Me.XEditTextBoxColumn6.MappingName = "amount"
        Me.XEditTextBoxColumn6.MaxLength = 32767
        Me.XEditTextBoxColumn6.ReadOnly = True
        Me.XEditTextBoxColumn6.TabStop = True
        Me.XEditTextBoxColumn6.UseCustomCellFormat = True
        Me.XEditTextBoxColumn6.Width = 101
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Usuario"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = True
        Me.XEditTextBoxColumn3.MappingName = "userid"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.ReadOnly = True
        Me.XEditTextBoxColumn3.TabStop = True
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 60
        '
        'XEditTextBoxColumn5
        '
        Me.XEditTextBoxColumn5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn5.Format = ""
        Me.XEditTextBoxColumn5.FormatInfo = Nothing
        Me.XEditTextBoxColumn5.ImageList = Nothing
        Me.XEditTextBoxColumn5.isReadOnly = False
        Me.XEditTextBoxColumn5.MappingName = "dev_serial"
        Me.XEditTextBoxColumn5.MaxLength = 32767
        Me.XEditTextBoxColumn5.TabStop = True
        Me.XEditTextBoxColumn5.UseCustomCellFormat = False
        Me.XEditTextBoxColumn5.Width = 0
        '
        'DataView1
        '
        Me.DataView1.Table = Me.ivdevolm
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(640, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Limpiar"
        '
        'btnAplicar
        '
        Me.btnAplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAplicar.Location = New System.Drawing.Point(640, 496)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(80, 32)
        Me.btnAplicar.TabIndex = 10
        Me.btnAplicar.Text = "Aplicar"
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "suc_code"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'p_ivdevm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(730, 535)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDetail)
        Me.Controls.Add(Me.btnUnmarkall)
        Me.Controls.Add(Me.btnMarkAll)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAplicar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "p_ivdevm01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Aplicar Devolucion de Inventario"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivdevolm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        If e.Action = LibX.LibxConnectionActions.Find _
        Or e.AcceptedAction = LibX.LibxConnectionActions.Find Then
            DataSet1.Tables(0).Rows.Clear()
            LibXGrid1.ReadOnly = True
        End If

        If e.Action = LibX.LibxConnectionActions.Edit Then
            LibXGrid1.ReadOnly = False
        End If

        If e.AcceptedAction = LibX.LibxConnectionActions.Edit And DataSet1.Tables("ivdevolm").Select("Aplicar=1").Length > 0 Then
            Postear()
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAll.Click
        For Each oRow As DataRow In DataSet1.Tables("ivdevolm").Rows
            oRow!Aplicar = 1
        Next

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnmarkall.Click
        For Each oRow As DataRow In DataSet1.Tables("ivdevolm").Rows
            oRow!Aplicar = 0
        Next

    End Sub

    Private Sub Postear()
        Dim oParamPost As PostDevol.ParametrosAplicar
        Dim oPost As PostDevol

        Dim SelectStmt As String
        Dim oiventrdd As DataTable
        Dim oiventrdm As DataTable
        Dim oArticulo As SGT.Inventario.Entidades.Articulo
        Dim oParam As SGT.Inventario.Entidades.Articulo.GetOnHandParameters

        Dim OnHand As Integer
        Dim XUpdate As LibX.Data.XUpdateStmt
        Try
            If MessageBox.Show("Seguro desea aplicar?", "Aplicar Devoluciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Throw New ApplicationException("Operación Abortada!")
            End If

            oParamPost = New PostDevol.ParametrosAplicar
            oPost = New PostDevol

            oArticulo = New SGT.Inventario.Entidades.Articulo
            oParam = New SGT.Inventario.Entidades.Articulo.GetOnHandParameters

            For Each oRow As DataRow In DataSet1.Tables("ivdevolm").Select("aplicar=1")

                '// Postear a inventario
                With oParamPost
                    .DocDate = oRow!dev_date
                    .Numero = oRow!dev_number
                    .Serial = oRow!dev_serial
                    .Referencia = Val(oRow!prov_code.ToString)
                    .TipoTransaccion = oRow!type_code
                    .Termino = oRow!term_code.ToString.Trim
                    .Proveedor = Val(oRow!prov_code.ToString.Trim)
                    .Impuesto = Val(oRow!itbis_amount.ToString.Trim)
                    .UseTransaction = True
                    .Monto = Val(oRow!amount.ToString.Trim)
                    .SucCode = oRow!suc_code
                End With

                oPost.Aplicar(oParamPost)

                DataSet1.Tables("ivdevolm").Rows.Remove(oRow)
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub p_iventr01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            xcbo_dev_type.LoadDbItems(True)
            Me.xdt_dev_date.Value = DBNull.Value
            btnRefresh_Click(sender, e)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        e.AditionalWhere = "dev_status = 2"
        Try
            If LibX.IsNull(Me.xdt_dev_date.Value) = False Then
                e.AditionalWhere &= " and ivdevolm.dev_date = '" & CDate(Me.xdt_dev_date.Value).ToString(LibX.Data.Manager.GetSaveDateFormat) & "'"
            End If

            If Me.xtxt_whse_code.Text.Trim <> "" Then
                e.AditionalWhere &= " and ivdevolm.whse_code = " & Me.xtxt_whse_code.Text.Trim
            End If

            If Me.xtxt_prov_code.Text.Trim <> "" Then
                e.AditionalWhere &= " and ivdevolm.prov_code = " & Me.xtxt_prov_code.Text.Trim
            End If

            If Me.xtxt_dev_number.Text.Trim <> "" Then
                e.AditionalWhere &= " and ivdevolm.dev_number = " & Me.xtxt_dev_number.Text.Trim
            End If

            If Me.xcbo_dev_type.Text.Trim <> "" Then
                e.AditionalWhere &= " and ivdevolm.type_code = '" & Me.xcbo_dev_type.currValue.ToString.Trim & "'"
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
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
                .WhereToExecute = "dev_serial = " & LibXConnector1.CurrentDataRow!dev_serial.ToString
                .initMode = LibX.LibxInitModes.Query
            End With

            LibX.App.CurrentPrgParams = ProgParam
            LibX.LibXRunner.Run("i_ivdevm01", "INV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        btnMarkAll.Enabled = e.isEditing And LibXConnector1.HasRecords
        btnUnmarkall.Enabled = e.isEditing And LibXConnector1.HasRecords
        btnDetail.Enabled = e.isEditing And LibXConnector1.HasRecords
        btnAplicar.Enabled = e.isEditing And LibXConnector1.HasRecords

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LibXConnector1.AcceptFind()
        If LibXConnector1.HasRecords = True Then
            LibXConnector1.Edit()
        Else
            LibXConnector1.Find()
        End If
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
        DataSet1.Tables("ivdevolm").Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1
        Postear()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Button8_Click(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.xcbo_dev_type.currValue = -1
            Me.xtxt_dev_number.Text = ""
            Me.xtxt_prov_code.Text = ""
            Me.xtxt_whse_code.Text = ""
            Me.xdt_dev_date.Value = DBNull.Value
            Me.xlk_prov_code.ExecuteFind()
            Me.xlk_whse_code.ExecuteFind()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click
        Try
            DataSet1.Tables("ivdevolm").Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1
            Postear()

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
End Class
