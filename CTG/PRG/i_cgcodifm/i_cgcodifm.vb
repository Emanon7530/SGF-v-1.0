Public Class i_cgcodifm
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
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
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
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbltype_name As System.Windows.Forms.Label
    Friend WithEvents Xlk_type_code As LibX.LibXLookup
    Friend WithEvents xlk_acct_type As LibX.LibXLookup
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents XDataGridComboBoxColumn1 As LibX.XDataGridComboBoxColumn
    Friend WithEvents XDataGridTextButtonColumn1 As LibX.XDataGridTextButtonColumn
    Friend WithEvents xcb_Origen As LibX.LibXCombo
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents XDataGridBoolColumn2 As LibX.XDataGridBoolColumn
    Friend WithEvents xcbo_dbcr As LibX.LibXCombo
    Friend WithEvents XDataGridComboBoxColumn2 As LibX.XDataGridComboBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Xlk_type_code = New LibX.LibXLookup
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
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.lbltype_name = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.xcbo_dbcr = New LibX.LibXCombo
        Me.xcb_Origen = New LibX.LibXCombo
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XDataGridTextButtonColumn1 = New LibX.XDataGridTextButtonColumn
        Me.xlk_acct_type = New LibX.LibXLookup
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.XDataGridBoolColumn2 = New LibX.XDataGridBoolColumn
        Me.XDataGridComboBoxColumn2 = New LibX.XDataGridComboBoxColumn
        Me.XDataGridComboBoxColumn1 = New LibX.XDataGridComboBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LibXGrid1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Xlk_type_code)
        Me.GroupBox1.Controls.Add(Me.lbltype_name)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Xlk_type_code
        '
        Me.Xlk_type_code.AlternateFieldSearch = Nothing
        Me.Xlk_type_code.BeginCheck = False
        Me.Xlk_type_code.CheckText = Nothing
        Me.Xlk_type_code.ComboMode = False
        Me.Xlk_type_code.DataMember = Nothing
        Me.Xlk_type_code.DataSource = Me.LibXConnector1
        Me.Xlk_type_code.DestParameters = New String() {"type_code=type_code", "type_name=type_name"}
        Me.Xlk_type_code.FilterField = Nothing
        Me.Xlk_type_code.IgnoreFindInBrowseMode = True
        Me.Xlk_type_code.isCanceled = False
        Me.Xlk_type_code.Location = New System.Drawing.Point(504, 24)
        Me.Xlk_type_code.LookCaption = "Tipos de Documentos"
        Me.Xlk_type_code.Name = "Xlk_type_code"
        Me.Xlk_type_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.Xlk_type_code.ShowFilter = True
        Me.Xlk_type_code.ShowMessageNotFound = True
        Me.Xlk_type_code.ShowWarning = False
        Me.Xlk_type_code.Size = New System.Drawing.Size(16, 20)
        Me.Xlk_type_code.SizesColumns = Nothing
        Me.Xlk_type_code.SizesColumnsTab = Nothing
        Me.Xlk_type_code.SqlString = New String() {"select * from ivtypem", "where apply_ctg = 1"}
        Me.Xlk_type_code.SQLTab = Nothing
        Me.Xlk_type_code.SrcParameters = New String() {"type_code=type_code"}
        Me.Xlk_type_code.TabIndex = 3
        Me.Xlk_type_code.TableName = "ivtypem"
        Me.Xlk_type_code.TabStop = False
        Me.Xlk_type_code.UseCopyConnection = False
        Me.Xlk_type_code.UseRowRetrieveEvents = False
        Me.Xlk_type_code.UseTab = False
        Me.Xlk_type_code.VisParameters = New String() {"Código=type_code", "Descripción=type_name"}
        Me.Xlk_type_code.WhereCondition = Nothing
        Me.Xlk_type_code.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "ivtypem"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"type_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "ivtypem"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "type_code"
        Me.DataColumn1.MaxLength = 3
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "type_name"
        Me.DataColumn2.MaxLength = 30
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "apply_cxc"
        Me.DataColumn3.DataType = GetType(System.Int16)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "apply_cxp"
        Me.DataColumn4.DataType = GetType(System.Int16)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "apply_inv"
        Me.DataColumn5.DataType = GetType(System.Int16)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "apply_ctg"
        Me.DataColumn6.DataType = GetType(System.Int16)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "origen"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "apply_price"
        Me.DataColumn8.DataType = GetType(System.Int16)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "auto_number"
        Me.DataColumn9.DataType = GetType(System.Int16)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "last_number"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "use_salesman"
        Me.DataColumn11.DataType = GetType(System.Int16)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "use_customer"
        Me.DataColumn12.DataType = GetType(System.Int16)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "use_prov"
        Me.DataColumn13.DataType = GetType(System.Int16)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "doc_input"
        Me.DataColumn14.DataType = GetType(System.Int16)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "type_local"
        Me.DataColumn15.DataType = GetType(System.Int16)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "type_default"
        Me.DataColumn16.DataType = GetType(System.Int16)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "type_note"
        Me.DataColumn17.MaxLength = 80
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "pay_comm"
        Me.DataColumn18.DataType = GetType(System.Int16)
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25})
        Me.DataTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"type_code", "acct_no", "line_no"}, True)})
        Me.DataTable2.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn19, Me.DataColumn20, Me.DataColumn21}
        Me.DataTable2.TableName = "cgentrdm"
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "type_code"
        Me.DataColumn19.MaxLength = 3
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "acct_no"
        Me.DataColumn20.MaxLength = 20
        '
        'DataColumn21
        '
        Me.DataColumn21.AllowDBNull = False
        Me.DataColumn21.AutoIncrement = True
        Me.DataColumn21.AutoIncrementSeed = CType(1, Long)
        Me.DataColumn21.ColumnName = "line_no"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "origen"
        Me.DataColumn22.DataType = GetType(System.Int16)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "orig_valor"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "acct_name"
        Me.DataColumn24.MaxLength = 60
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "condicion"
        Me.DataColumn25.DataType = GetType(System.Int16)
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
        Me.LibXDbSourceTable1.Source = New String() {"select distinct cgentrdm.type_code,ivtypem.type_name", "from cgentrdm inner join ivtypem on cgentrdm.type_code=ivtypem.type_code"}
        Me.LibXDbSourceTable1.TableName = "ivtypem"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LibXDbSourceTable2
        '
        Me.LibXDbSourceTable2.AllowDelete = True
        Me.LibXDbSourceTable2.AllowEdit = True
        Me.LibXDbSourceTable2.AllowNew = True
        Me.LibXDbSourceTable2.AutoIncrementSerial = False
        Me.LibXDbSourceTable2.CustomDbUpdate = False
        Me.LibXDbSourceTable2.DeleteOrder = 0
        Me.LibXDbSourceTable2.FillOnQuery = True
        Me.LibXDbSourceTable2.FillOnRowChange = True
        Me.LibXDbSourceTable2.HeaderIsOnGrid = False
        Me.LibXDbSourceTable2.InnerJon = True
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"type_code=type_code"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"SELECT cgentrdm.type_code,", "cgentrdm.acct_no,", "cgentrdm.condicion,", "cgentrdm.line_no,", "cgentrdm.origen,", "cgentrdm.orig_valor,", "acct_name ", "FROM cgentrdm inner join cgacctm", "on cgentrdm.acct_no = cgacctm.acct_no", "order by cgentrdm.line_no,cgentrdm.acct_no"}
        Me.LibXDbSourceTable2.TableName = "cgentrdm"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'lbltype_name
        '
        Me.lbltype_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltype_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtypem.type_name"))
        Me.lbltype_name.Location = New System.Drawing.Point(192, 24)
        Me.lbltype_name.Name = "lbltype_name"
        Me.lbltype_name.Size = New System.Drawing.Size(312, 20)
        Me.lbltype_name.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtypem.type_code"))
        Me.TextBox1.Location = New System.Drawing.Point(128, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Documento:"
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(696, 24)
        Me.LibXNavigator1.TabIndex = 1
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Codificación Contables"
        Me.LibXGrid1.Controls.Add(Me.xcbo_dbcr)
        Me.LibXGrid1.Controls.Add(Me.xcb_Origen)
        Me.LibXGrid1.DataMember = "cgentrdm"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 96)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(680, 264)
        Me.LibXGrid1.TabIndex = 2
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'xcbo_dbcr
        '
        Me.xcbo_dbcr.AllowDefaultSort = True
        Me.xcbo_dbcr.bound = True
        Me.xcbo_dbcr.currValue = Nothing
        Me.xcbo_dbcr.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cgentrdm.origen"))
        Me.xcbo_dbcr.DefaultWhereString = Nothing
        Me.xcbo_dbcr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_dbcr.EditInitialValue = Nothing
        Me.xcbo_dbcr.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_dbcr.FieldDescription = ""
        Me.xcbo_dbcr.FindInitialValue = Nothing
        Me.xcbo_dbcr.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_dbcr.IgnoreRequiered = False
        Me.xcbo_dbcr.Items.AddRange(New Object() {"1-Débito", "2-Crédito"})
        Me.xcbo_dbcr.Location = New System.Drawing.Point(528, 112)
        Me.xcbo_dbcr.LookupKeyDisplayFields = Nothing
        Me.xcbo_dbcr.LookupKeyField = Nothing
        Me.xcbo_dbcr.LookupTableName = Nothing
        Me.xcbo_dbcr.Name = "xcbo_dbcr"
        Me.xcbo_dbcr.NewInitialValue = Nothing
        Me.xcbo_dbcr.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_dbcr.Requiered = False
        Me.xcbo_dbcr.Required = False
        Me.xcbo_dbcr.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_dbcr.SqlString = Nothing
        Me.xcbo_dbcr.StatusBarPanelDescripcion = Nothing
        Me.xcbo_dbcr.TabIndex = 4
        '
        'xcb_Origen
        '
        Me.xcb_Origen.AllowDefaultSort = True
        Me.xcb_Origen.bound = True
        Me.xcb_Origen.currValue = Nothing
        Me.xcb_Origen.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cgentrdm.orig_valor"))
        Me.xcb_Origen.DefaultWhereString = Nothing
        Me.xcb_Origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcb_Origen.EditInitialValue = Nothing
        Me.xcb_Origen.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcb_Origen.FieldDescription = ""
        Me.xcb_Origen.FindInitialValue = Nothing
        Me.xcb_Origen.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcb_Origen.IgnoreRequiered = False
        Me.xcb_Origen.Items.AddRange(New Object() {"1-Monto Bruto", "2-Monto Neto", "3-Descuento", "4-Impuesto", "5-Devolucion", "6-FOB", "7-CIF", "8-Diferencia Cambiaria", "9- MontoExcento", "10- MontoGrabado", "11-Descuento Devolucion", "12-Monto Seguro", "13-Credito", "14-Tarjeta", "15- Contado", "16- NotaCredito", "17-NotaDebito", "18-CostoVenta", "19-CxcCliente", "20-Inventario", "21-Isc", "22-RetItbis", "23-RetIsr"})
        Me.xcb_Origen.Location = New System.Drawing.Point(536, 104)
        Me.xcb_Origen.LookupKeyDisplayFields = Nothing
        Me.xcb_Origen.LookupKeyField = Nothing
        Me.xcb_Origen.LookupTableName = Nothing
        Me.xcb_Origen.Name = "xcb_Origen"
        Me.xcb_Origen.NewInitialValue = Nothing
        Me.xcb_Origen.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcb_Origen.Requiered = False
        Me.xcb_Origen.Required = False
        Me.xcb_Origen.Size = New System.Drawing.Size(121, 21)
        Me.xcb_Origen.SqlString = Nothing
        Me.xcb_Origen.StatusBarPanelDescripcion = Nothing
        Me.xcb_Origen.TabIndex = 4
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XEditTextBoxColumn1, Me.XDataGridTextButtonColumn1, Me.DataGridTextBoxColumn1, Me.XDataGridBoolColumn2, Me.XDataGridComboBoxColumn2, Me.XDataGridComboBoxColumn1})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cgentrdm"
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Orden"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "line_no"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 50
        '
        'XDataGridTextButtonColumn1
        '
        Me.XDataGridTextButtonColumn1.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.XDataGridTextButtonColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XDataGridTextButtonColumn1.executeFindDuringFill = False
        Me.XDataGridTextButtonColumn1.Format = ""
        Me.XDataGridTextButtonColumn1.FormatInfo = Nothing
        Me.XDataGridTextButtonColumn1.HeaderText = "Número Cuenta"
        Me.XDataGridTextButtonColumn1.isReadOnly = False
        Me.XDataGridTextButtonColumn1.Lookup = Me.xlk_acct_type
        Me.XDataGridTextButtonColumn1.MappingName = "acct_no"
        Me.XDataGridTextButtonColumn1.MaxLength = 32767
        Me.XDataGridTextButtonColumn1.TabStop = True
        Me.XDataGridTextButtonColumn1.UseCustomCellFormat = False
        Me.XDataGridTextButtonColumn1.Width = 101
        '
        'xlk_acct_type
        '
        Me.xlk_acct_type.AlternateFieldSearch = Nothing
        Me.xlk_acct_type.BeginCheck = False
        Me.xlk_acct_type.CheckText = Nothing
        Me.xlk_acct_type.ComboMode = False
        Me.xlk_acct_type.DataMember = Nothing
        Me.xlk_acct_type.DataSource = Me.LibXConnector1
        Me.xlk_acct_type.DestParameters = New String() {"acct_no=acct_no", "acct_name=acct_name"}
        Me.xlk_acct_type.FilterField = "acct_name"
        Me.xlk_acct_type.IgnoreFindInBrowseMode = True
        Me.xlk_acct_type.isCanceled = False
        Me.xlk_acct_type.Location = New System.Drawing.Point(632, 96)
        Me.xlk_acct_type.LookCaption = "Cuentas Contables"
        Me.xlk_acct_type.Name = "xlk_acct_type"
        Me.xlk_acct_type.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_acct_type.ShowFilter = True
        Me.xlk_acct_type.ShowMessageNotFound = True
        Me.xlk_acct_type.ShowWarning = False
        Me.xlk_acct_type.Size = New System.Drawing.Size(16, 20)
        Me.xlk_acct_type.SizesColumns = Nothing
        Me.xlk_acct_type.SizesColumnsTab = Nothing
        Me.xlk_acct_type.SqlString = Nothing
        Me.xlk_acct_type.SQLTab = Nothing
        Me.xlk_acct_type.SrcParameters = New String() {"acct_no=acct_no"}
        Me.xlk_acct_type.TabIndex = 3
        Me.xlk_acct_type.TableName = "cgacctm"
        Me.xlk_acct_type.TabStop = False
        Me.xlk_acct_type.UseCopyConnection = False
        Me.xlk_acct_type.UseRowRetrieveEvents = False
        Me.xlk_acct_type.UseTab = False
        Me.xlk_acct_type.VisParameters = New String() {"Número de Cuenta=acct_no", "Descripción=acct_name"}
        Me.xlk_acct_type.WhereCondition = Nothing
        Me.xlk_acct_type.WhereParameters = Nothing
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Nombre de la Cuenta"
        Me.DataGridTextBoxColumn1.MappingName = "acct_name"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 200
        '
        'XDataGridBoolColumn2
        '
        Me.XDataGridBoolColumn2.FalseValue = CType(2, Short)
        Me.XDataGridBoolColumn2.HeaderText = "Contado?"
        Me.XDataGridBoolColumn2.MappingName = "condicion"
        Me.XDataGridBoolColumn2.NullValue = CType(0, Short)
        Me.XDataGridBoolColumn2.TrueValue = CType(1, Short)
        Me.XDataGridBoolColumn2.UseCustomCellFormat = False
        Me.XDataGridBoolColumn2.Width = 75
        '
        'XDataGridComboBoxColumn2
        '
        Me.XDataGridComboBoxColumn2.ComboBox = Me.xcbo_dbcr
        Me.XDataGridComboBoxColumn2.Format = ""
        Me.XDataGridComboBoxColumn2.FormatInfo = Nothing
        Me.XDataGridComboBoxColumn2.HeaderText = "Origen"
        Me.XDataGridComboBoxColumn2.isReadOnly = False
        Me.XDataGridComboBoxColumn2.MappingName = "origen"
        Me.XDataGridComboBoxColumn2.Width = 85
        '
        'XDataGridComboBoxColumn1
        '
        Me.XDataGridComboBoxColumn1.ComboBox = Me.xcb_Origen
        Me.XDataGridComboBoxColumn1.Format = ""
        Me.XDataGridComboBoxColumn1.FormatInfo = Nothing
        Me.XDataGridComboBoxColumn1.HeaderText = "Origen Valor"
        Me.XDataGridComboBoxColumn1.isReadOnly = False
        Me.XDataGridComboBoxColumn1.MappingName = "orig_valor"
        Me.XDataGridComboBoxColumn1.Width = 110
        '
        'i_cgcodifm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(696, 406)
        Me.Controls.Add(Me.xlk_acct_type)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "i_cgcodifm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Codificación de Documentos contables"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LibXGrid1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow

        '''If e.UpdatingArgs.StatementType = StatementType.Insert _
        '''Or e.UpdatingArgs.StatementType = StatementType.Update Then
        '''    e.UpdatingArgs.Status = UpdateStatus.SkipCurrentRow
        '''End If

    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
            Dim oReport As New LibX.ReportLib("CTG", "r_codifrp01.rpt")
            oReport.Action = 1
        End If
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction

    End Sub

    Private Sub LibXConnector1_InsertingDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingDetailRow
        'Try
        '    If e.UpdatingArgs.StatementType = StatementType.Insert _
        '    Or e.UpdatingArgs.StatementType = StatementType.Update Then
        '        If e.UpdatingArgs.Row!origen = 2 Then
        '            e.UpdatingArgs.Row!origen = -1
        '        End If
        '    End If
        'Catch ex As Exception
        '    LibX.Log.Add(ex, True)
        '    e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
        'End Try
    End Sub

    Private Sub LibXConnector1_BeforeLoadDetail(ByVal sender As Object, ByVal e As LibX.XbeforeLoadDetailEventArgs) Handles LibXConnector1.BeforeLoadDetail

    End Sub

    Private Sub i_cgcodifm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
