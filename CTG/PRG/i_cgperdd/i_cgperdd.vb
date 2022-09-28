Imports SGT.Contabilidad
Public Class i_cgperdd
    Inherits System.Windows.Forms.Form
    Dim mwhere As String = ""
    Dim mCount_per As Integer
    Dim mYear As Integer
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
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents XDataGridBoolColumn1 As LibX.XDataGridBoolColumn
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents libx_from_date As LibX.LibxDateTimePicker
    Friend WithEvents libx_thru_date As LibX.LibxDateTimePicker
    Friend WithEvents txt_perdr_count As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn

    Friend WithEvents XDataGridComboBoxColumn1 As LibX.XDataGridComboBoxColumn
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
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents xcbo_perdm_status As LibX.LibXCombo
    Friend WithEvents xcbo_perdd_status As LibX.LibXCombo
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
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
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.XDataGridBoolColumn1 = New LibX.XDataGridBoolColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.XDataGridComboBoxColumn1 = New LibX.XDataGridComboBoxColumn
        Me.xcbo_perdd_status = New LibX.LibXCombo
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.libx_from_date = New LibX.LibxDateTimePicker
        Me.libx_thru_date = New LibX.LibxDateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_perdr_count = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.xcbo_perdm_status = New LibX.LibXCombo
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = False
        Me.LibXConnector1.AllowNew = True
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "cgperdm"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable2, Me.LibXDbSourceTable1})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"perdr_year"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn2}
        Me.DataTable1.TableName = "cgperdm"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "perdr_descr"
        Me.DataColumn1.MaxLength = 40
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "perdr_year"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "from_date"
        Me.DataColumn3.DataType = GetType(System.DateTime)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "thru_date"
        Me.DataColumn4.DataType = GetType(System.DateTime)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "perdm_status"
        Me.DataColumn5.MaxLength = 1
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "acct_utils"
        Me.DataColumn6.MaxLength = 20
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "perdr_count"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "acct_superavit"
        Me.DataColumn8.MaxLength = 20
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "acct_anticipos"
        Me.DataColumn9.MaxLength = 20
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18})
        Me.DataTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"perdr_year", "perdr_num"}, True)})
        Me.DataTable2.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn10, Me.DataColumn11}
        Me.DataTable2.TableName = "cgperdd"
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "perdr_year"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "perdr_num"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "from_date"
        Me.DataColumn12.DataType = GetType(System.DateTime)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "thru_date"
        Me.DataColumn13.DataType = GetType(System.DateTime)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "perdr_status"
        Me.DataColumn14.MaxLength = 1
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "perdr_begin"
        Me.DataColumn15.DataType = GetType(System.Int32)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "ic_balance"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "result_balance"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "suc_code"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'LibXDbSourceTable2
        '
        Me.LibXDbSourceTable2.AllowDelete = True
        Me.LibXDbSourceTable2.AllowEdit = True
        Me.LibXDbSourceTable2.AllowNew = True
        Me.LibXDbSourceTable2.AutoIncrementSerial = False
        Me.LibXDbSourceTable2.CustomDbUpdate = False
        Me.LibXDbSourceTable2.DeleteOrder = 0
        Me.LibXDbSourceTable2.FillOnQuery = False
        Me.LibXDbSourceTable2.FillOnRowChange = False
        Me.LibXDbSourceTable2.HeaderIsOnGrid = False
        Me.LibXDbSourceTable2.InnerJon = True
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = False
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = ""
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = Nothing
        Me.LibXDbSourceTable2.TableName = "cgperdm"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
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
        Me.LibXDbSourceTable1.FillOnRowChange = True
        Me.LibXDbSourceTable1.HeaderIsOnGrid = False
        Me.LibXDbSourceTable1.InnerJon = True
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = True
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = New String() {"perdr_year=perdr_year"}
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = ""
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cgperdd"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Periodos Contables"
        Me.LibXGrid1.DataMember = "cgperdd"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 136)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(672, 320)
        Me.LibXGrid1.TabIndex = 0
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn3, Me.XDataGridBoolColumn1, Me.DataGridTextBoxColumn1, Me.XDataGridComboBoxColumn1})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cgperdd"
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "No."
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "perdr_num"
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
        Me.XEditTextBoxColumn2.HeaderText = "Fecha Inicio"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "from_date"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 101
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Fecha Final"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = False
        Me.XEditTextBoxColumn3.MappingName = "thru_date"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.TabStop = True
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 101
        '
        'XDataGridBoolColumn1
        '
        Me.XDataGridBoolColumn1.FalseValue = CType(0, Short)
        Me.XDataGridBoolColumn1.HeaderText = "Inicio Periodo"
        Me.XDataGridBoolColumn1.MappingName = "perdr_begin"
        Me.XDataGridBoolColumn1.NullValue = 0
        Me.XDataGridBoolColumn1.TrueValue = CType(1, Short)
        Me.XDataGridBoolColumn1.UseCustomCellFormat = False
        Me.XDataGridBoolColumn1.Width = 80
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn1.Format = "###,###,##0.00"
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Inventario"
        Me.DataGridTextBoxColumn1.MappingName = "ic_balance"
        Me.DataGridTextBoxColumn1.Width = 134
        '
        'XDataGridComboBoxColumn1
        '
        Me.XDataGridComboBoxColumn1.ComboBox = Me.xcbo_perdd_status
        Me.XDataGridComboBoxColumn1.Format = ""
        Me.XDataGridComboBoxColumn1.FormatInfo = Nothing
        Me.XDataGridComboBoxColumn1.HeaderText = "Estatus"
        Me.XDataGridComboBoxColumn1.isReadOnly = False
        Me.XDataGridComboBoxColumn1.MappingName = "perdr_status"
        Me.XDataGridComboBoxColumn1.Width = 75
        '
        'xcbo_perdd_status
        '
        Me.xcbo_perdd_status.AllowDefaultSort = True
        Me.xcbo_perdd_status.bound = True
        Me.xcbo_perdd_status.currValue = Nothing
        Me.xcbo_perdd_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cgperdd.perdr_status"))
        Me.xcbo_perdd_status.DefaultWhereString = Nothing
        Me.xcbo_perdd_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_perdd_status.EditInitialValue = Nothing
        Me.xcbo_perdd_status.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_perdd_status.FieldDescription = ""
        Me.xcbo_perdd_status.FindInitialValue = Nothing
        Me.xcbo_perdd_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_perdd_status.IgnoreRequiered = False
        Me.xcbo_perdd_status.Items.AddRange(New Object() {"1-Abierto", "0-Cerrado"})
        Me.xcbo_perdd_status.Location = New System.Drawing.Point(328, 240)
        Me.xcbo_perdd_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_perdd_status.LookupKeyField = Nothing
        Me.xcbo_perdd_status.LookupTableName = Nothing
        Me.xcbo_perdd_status.Name = "xcbo_perdd_status"
        Me.xcbo_perdd_status.NewInitialValue = Nothing
        Me.xcbo_perdd_status.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_perdd_status.Requiered = False
        Me.xcbo_perdd_status.Required = False
        Me.xcbo_perdd_status.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_perdd_status.SqlString = Nothing
        Me.xcbo_perdd_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_perdd_status.TabIndex = 3
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(688, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.libx_from_date)
        Me.GroupBox1.Controls.Add(Me.libx_thru_date)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_perdr_count)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xcbo_perdm_status)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 96)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgperdm.perdr_year"))
        Me.TextBox2.Location = New System.Drawing.Point(96, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(56, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgperdm.perdr_descr"))
        Me.TextBox1.Location = New System.Drawing.Point(96, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(336, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'libx_from_date
        '
        Me.libx_from_date.CustomFormat = "dd/MM/yyyy"
        Me.libx_from_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cgperdm.from_date"))
        Me.libx_from_date.EditInitialValue = Nothing
        Me.libx_from_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.libx_from_date.FieldDescription = ""
        Me.libx_from_date.FindInitialValue = Nothing
        Me.libx_from_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.libx_from_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.libx_from_date.IgnoreRequiered = False
        Me.libx_from_date.Location = New System.Drawing.Point(96, 64)
        Me.libx_from_date.Name = "libx_from_date"
        Me.libx_from_date.NewInitialValue = Nothing
        Me.libx_from_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.libx_from_date.Requiered = False
        Me.libx_from_date.Size = New System.Drawing.Size(104, 20)
        Me.libx_from_date.StatusBarPanelDescripcion = Nothing
        Me.libx_from_date.TabIndex = 3
        '
        'libx_thru_date
        '
        Me.libx_thru_date.CustomFormat = "dd/MM/yyyy"
        Me.libx_thru_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cgperdm.thru_date"))
        Me.libx_thru_date.EditInitialValue = Nothing
        Me.libx_thru_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.libx_thru_date.FieldDescription = ""
        Me.libx_thru_date.FindInitialValue = Nothing
        Me.libx_thru_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.libx_thru_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.libx_thru_date.IgnoreRequiered = False
        Me.libx_thru_date.Location = New System.Drawing.Point(544, 64)
        Me.libx_thru_date.Name = "libx_thru_date"
        Me.libx_thru_date.NewInitialValue = Nothing
        Me.libx_thru_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.libx_thru_date.Requiered = False
        Me.libx_thru_date.Size = New System.Drawing.Size(120, 20)
        Me.libx_thru_date.StatusBarPanelDescripcion = Nothing
        Me.libx_thru_date.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(488, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Estatus:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(466, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha Final:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(12, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Inicial:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(56, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_perdr_count
        '
        Me.txt_perdr_count.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgperdm.perdr_count"))
        Me.txt_perdr_count.Location = New System.Drawing.Point(544, 16)
        Me.txt_perdr_count.Name = "txt_perdr_count"
        Me.txt_perdr_count.Size = New System.Drawing.Size(56, 20)
        Me.txt_perdr_count.TabIndex = 1
        Me.txt_perdr_count.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(435, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cant. de Periodos:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_perdm_status
        '
        Me.xcbo_perdm_status.AllowDefaultSort = True
        Me.xcbo_perdm_status.bound = True
        Me.xcbo_perdm_status.currValue = Nothing
        Me.xcbo_perdm_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cgperdm.perdm_status"))
        Me.xcbo_perdm_status.DefaultWhereString = Nothing
        Me.xcbo_perdm_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_perdm_status.EditInitialValue = Nothing
        Me.xcbo_perdm_status.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_perdm_status.FieldDescription = ""
        Me.xcbo_perdm_status.FindInitialValue = Nothing
        Me.xcbo_perdm_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_perdm_status.IgnoreRequiered = False
        Me.xcbo_perdm_status.Items.AddRange(New Object() {"1-Abierto", "0-Cerrado"})
        Me.xcbo_perdm_status.Location = New System.Drawing.Point(544, 40)
        Me.xcbo_perdm_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_perdm_status.LookupKeyField = Nothing
        Me.xcbo_perdm_status.LookupTableName = Nothing
        Me.xcbo_perdm_status.Name = "xcbo_perdm_status"
        Me.xcbo_perdm_status.NewInitialValue = "1"
        Me.xcbo_perdm_status.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_perdm_status.Requiered = False
        Me.xcbo_perdm_status.Required = False
        Me.xcbo_perdm_status.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_perdm_status.SqlString = Nothing
        Me.xcbo_perdm_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_perdm_status.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(360, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Generar Periodo"
        '
        'i_cgperdd
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 501)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.xcbo_perdd_status)
        Me.Name = "i_cgperdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Periodos"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Dim oReport As LibX.ReportLib
        Dim SelecStmt As String
        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
                oReport = New LibX.ReportLib("CTG", "r_perdrp01.rpt")
                With oReport
                    .RetrieveSQLQuery()
                    SelecStmt = .SQLQuery
                    SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, mwhere)
                    .SQLQuery = SelecStmt

                    '// Ejecutar el reporte
                    .Action = 1
                End With
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        mwhere = e.Where
    End Sub

    Private Sub i_cgperdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LibXGrid1.footerOperations.add("perdr_num", "count(perdr_num)")
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub GenerarPeriodos()
        Dim i As Integer
        Dim i1 As Integer
        Dim BeginDate As Date
        Dim oAnoFiscal As Entidades.AnoFiscal
        Dim oParamIniciar As Entidades.AnoFiscal.ParametrosIniciar
        Try

            mCount_per = Val(LibXConnector1.CurrentDataRow!perdr_count.ToString)
            If mCount_per <= 0 Then
                mCount_per = txt_perdr_count.Text
            End If
            mYear = Val(LibXConnector1.CurrentDataRow!perdr_year.ToString)
            If mYear <= 0 Then
                mYear = TextBox2.Text
            End If

            If DataSet1.Tables("cgperdd").Rows.Count > 0 Then
                Exit Sub
            End If

            oAnoFiscal = New Entidades.AnoFiscal
            oParamIniciar = New Entidades.AnoFiscal.ParametrosIniciar

            With LibXConnector1.CurrentDataRow
                '// 
                DataSet1.Tables("cgperdd").Rows.Clear()

                With oParamIniciar
                    .CerrarActual = False
                    .CerrarUnbalnced = False
                    .Count = mCount_per
                    .From = libx_from_date.Value
                    .Thru = libx_thru_date.Value
                    .UseTransaction = False
                    .Year = mYear
                    .SavePeriodo = False
                    .SucCode = 1
                End With

                oAnoFiscal.Iniciar(oParamIniciar)

                Dim oRow As DataRow
                BeginDate = libx_from_date.Value

                DataSet1.Tables("cgperdd").Rows.Clear()

                For Each oPeriodo As Entidades.Periodo In oParamIniciar.ValoresRetorno
                    oRow = DataSet1.Tables("cgperdd").NewRow
                    oRow.BeginEdit()
                    oRow!perdr_year = oParamIniciar.Year
                    oRow!perdr_num = oPeriodo.Number
                    oRow!from_date = oPeriodo.From
                    oRow!thru_date = oPeriodo.Thru
                    oRow!perdr_begin = oPeriodo.Begin
                    oRow!perdr_status = Val(oPeriodo.Status)
                    oRow!suc_code = Val(oPeriodo.SucCode)
                    oRow.EndEdit()
                    DataSet1.Tables("cgperdd").Rows.Add(oRow)
                Next

            End With

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibxDateTimePicker1_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles libx_thru_date.Validated
        Try
            If LibXConnector1.IsDataEditing = True Then
                If LibXConnector1.CurrentAction = LibX.LibxConnectionActions.Add _
                Or LibXConnector1.CurrentAction = LibX.LibxConnectionActions.Edit Then

                    GenerarPeriodos()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try

            'libx_from_date.Value = DateSerial(DateTime.Now.Year, 1, 1)
            'libx_thru_date.Value = DateSerial(DateTime.Now.Year, 12, 31)
            libx_from_date.Value = DateSerial(findLastPerido(), 1, 1)
            libx_thru_date.Value = DateSerial(findLastPerido(), 12, 31)
            xcbo_perdm_status.currValue = Val(SGT.Contabilidad.Entidades.Periodo.PeriodoStatusEnum.Abierto)
            txt_perdr_count.Text = "12"
            TextBox2.Text = findLastPerido()

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub libx_from_date_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles libx_from_date.Validated
        Try

            If LibXConnector1.IsDataEditing = True Then
                If LibXConnector1.CurrentAction = LibX.LibxConnectionActions.Add _
                Or LibXConnector1.CurrentAction = LibX.LibxConnectionActions.Edit Then
                    ''GenerarPeriodos()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub txt_perdr_count_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_perdr_count.Validated
        Try
            If LibXConnector1.IsDataEditing = True Then
                If LibXConnector1.CurrentAction = LibX.LibxConnectionActions.Add _
                Or LibXConnector1.CurrentAction = LibX.LibxConnectionActions.Edit Then
                    ''GenerarPeriodos()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub libx_thru_date_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles libx_thru_date.Validating, libx_from_date.Validating
        Try
            If LibXConnector1.IsDataEditing = True Then
                If libx_from_date.Value > libx_thru_date.Value Then
                    Throw New ApplicationException("La fecha de inicio debe ser menor o igual a la fecha final")
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
            e.Cancel = True

        End Try
    End Sub

    Private Function findLastPerido() As Integer
        Dim mAnio As Integer
        Dim StmtSelect As String
        StmtSelect = "select isnull(max(perdr_year),0) from cgperdm"
        mAnio = LibX.Data.Manager.GetScalar(StmtSelect)
        If mAnio = 0 Then
            StmtSelect = "select year(getdate())"
            mAnio = LibX.Data.Manager.GetScalar(StmtSelect)
        End If

        Return mAnio + 1
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If LibXConnector1.IsDataEditing = True Then
                If libx_from_date.Value > libx_thru_date.Value Then
                    Throw New ApplicationException("La fecha de inicio debe ser menor o igual a la fecha final")
                End If
                If LibXConnector1.CurrentAction = LibX.LibxConnectionActions.Add _
                    Or LibXConnector1.CurrentAction = LibX.LibxConnectionActions.Edit Then
                    GenerarPeriodos()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub
End Class
