Imports LibX
Imports SGT.Inventario.Entidades.Documento

Public Class i_ivcount01
    Inherits System.Windows.Forms.Form
    Dim oDoc As SGT.Inventario.Entidades.Documento
    'Dim ScDefault As Integer
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
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lkItem_code As LibX.LibXLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LibXGridDetalle As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents gColITem_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents gColitem_name As LibX.XEditTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents txtwhse_code As LibX.XTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents xcbo_doc_status As LibX.LibXCombo
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable4 As LibX.LibXDbSourceTable
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents gColConteo As LibX.XEditTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents xtxt_PageNo As LibX.XTextBox
    Friend WithEvents gColline_no As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxUnidad As LibX.XEditTextBoxColumn
    Friend WithEvents xtxt_count_number As LibX.XTextBox
    Friend WithEvents xtxt_count_desc As LibX.XTextBox
    Friend WithEvents xdt_count_date As LibX.LibxDateTimePicker
    Friend WithEvents txtwhse_name As System.Windows.Forms.Label
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
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gColFactor As LibX.XEditTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
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
        Me.DataTable2 = New System.Data.DataTable
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
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable4 = New LibX.LibXDbSourceTable
        Me.xtxt_count_desc = New LibX.XTextBox
        Me.xtxt_count_number = New LibX.XTextBox
        Me.txtwhse_code = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lkItem_code = New LibX.LibXLookup
        Me.Label8 = New System.Windows.Forms.Label
        Me.LibXGridDetalle = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColITem_code = New LibX.XDataGridTextButtonColumn
        Me.gColitem_name = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxUnidad = New LibX.XEditTextBoxColumn
        Me.gColFactor = New LibX.XEditTextBoxColumn
        Me.gColline_no = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.gColConteo = New LibX.XEditTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtwhse_name = New System.Windows.Forms.Label
        Me.xdt_count_date = New LibX.LibxDateTimePicker
        Me.xcbo_doc_status = New LibX.LibXCombo
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.xtxt_PageNo = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_count_desc
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_count_number
        Me.LibXNavigator1.FirstControlInNewMode = Me.txtwhse_code
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(986, 24)
        Me.LibXNavigator1.TabIndex = 0
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
        Me.LibXConnector1.DataMember = "ivcounte"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = "INV"
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = "r_ivcount01.rpt"
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable3, Me.LibXDbSourceTable4})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"count_number"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
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
        Me.DataColumn2.ColumnName = "prov_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "whse_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "count_date"
        Me.DataColumn4.DataType = GetType(System.DateTime)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "count_desc"
        Me.DataColumn5.MaxLength = 60
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "count_status"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "userid"
        Me.DataColumn7.MaxLength = 20
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "pageno"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22})
        Me.DataTable2.TableName = "ivcountd"
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "count_number"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "unit_code"
        Me.DataColumn10.MaxLength = 4
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "item_code"
        Me.DataColumn11.MaxLength = 10
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "whse_code"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "count_qty"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "loc_row"
        Me.DataColumn14.MaxLength = 20
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "loc_bin"
        Me.DataColumn15.MaxLength = 20
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "estante"
        Me.DataColumn16.MaxLength = 5
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "qty_on_hand"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "factor"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "pageno"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "line_no"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.AllowDBNull = False
        Me.DataColumn21.ColumnName = "count_status"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "item_name"
        Me.DataColumn22.MaxLength = 100
        '
        'LibXDbSourceTable3
        '
        Me.LibXDbSourceTable3.AllowDelete = True
        Me.LibXDbSourceTable3.AllowEdit = True
        Me.LibXDbSourceTable3.AllowNew = True
        Me.LibXDbSourceTable3.AutoIncrementSerial = False
        Me.LibXDbSourceTable3.CustomDbUpdate = False
        Me.LibXDbSourceTable3.DeleteOrder = 0
        Me.LibXDbSourceTable3.FillOnQuery = True
        Me.LibXDbSourceTable3.FillOnRowChange = False
        Me.LibXDbSourceTable3.HeaderIsOnGrid = False
        Me.LibXDbSourceTable3.InnerJon = True
        Me.LibXDbSourceTable3.InsertOrder = 0
        Me.LibXDbSourceTable3.IsDetail = False
        Me.LibXDbSourceTable3.KeyFields = Nothing
        Me.LibXDbSourceTable3.LineColName = Nothing
        Me.LibXDbSourceTable3.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable3.MasterTableName = Nothing
        Me.LibXDbSourceTable3.SerialColumnName = "count_number"
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = New String() {"SELECT DISTINCT ivcounte.count_number,", "ivcounte.prov_code,", "ivcounte.whse_code,", "ivcounte.count_date,", "ivcounte.count_desc,", "ivcountd.count_status,", "ivcounte.userid,", " ivcountd.pageno from ivcounte, ivcountd", "where ivcounte.count_number = ivcountd.count_number"}
        Me.LibXDbSourceTable3.TableName = "ivcounte"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'LibXDbSourceTable4
        '
        Me.LibXDbSourceTable4.AllowDelete = True
        Me.LibXDbSourceTable4.AllowEdit = True
        Me.LibXDbSourceTable4.AllowNew = True
        Me.LibXDbSourceTable4.AutoIncrementSerial = False
        Me.LibXDbSourceTable4.CustomDbUpdate = False
        Me.LibXDbSourceTable4.DeleteOrder = 0
        Me.LibXDbSourceTable4.FillOnQuery = True
        Me.LibXDbSourceTable4.FillOnRowChange = True
        Me.LibXDbSourceTable4.HeaderIsOnGrid = False
        Me.LibXDbSourceTable4.InnerJon = True
        Me.LibXDbSourceTable4.InsertOrder = 0
        Me.LibXDbSourceTable4.IsDetail = True
        Me.LibXDbSourceTable4.KeyFields = Nothing
        Me.LibXDbSourceTable4.LineColName = "line_no"
        Me.LibXDbSourceTable4.MasterDetailRelation = New String() {"count_number=count_number", "whse_code=whse_code", "PageNo=PageNo"}
        Me.LibXDbSourceTable4.MasterTableName = Nothing
        Me.LibXDbSourceTable4.SerialColumnName = Nothing
        Me.LibXDbSourceTable4.Sort = Nothing
        Me.LibXDbSourceTable4.Source = New String() {"select ivcountd.*,item_name ", "from ivcountd,ivitemm ", "Where ivcountd.item_code=ivitemm.item_code", "order by line_no"}
        Me.LibXDbSourceTable4.TableName = "ivcountd"
        Me.LibXDbSourceTable4.UpdateOrder = 0
        Me.LibXDbSourceTable4.UseRowRetrieve = False
        '
        'xtxt_count_desc
        '
        Me.xtxt_count_desc.AcceptsReturn = True
        Me.xtxt_count_desc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_count_desc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivcounte.count_desc"))
        Me.xtxt_count_desc.EditInitialValue = Nothing
        Me.xtxt_count_desc.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_count_desc.FieldDescription = ""
        Me.xtxt_count_desc.FindInitialValue = Nothing
        Me.xtxt_count_desc.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_count_desc.IgnoreRequiered = False
        Me.xtxt_count_desc.Location = New System.Drawing.Point(96, 64)
        Me.xtxt_count_desc.Multiline = True
        Me.xtxt_count_desc.Name = "xtxt_count_desc"
        Me.xtxt_count_desc.NewInitialValue = Nothing
        Me.xtxt_count_desc.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_count_desc.Requiered = False
        Me.xtxt_count_desc.Size = New System.Drawing.Size(416, 48)
        Me.xtxt_count_desc.StatusBarPanelDescripcion = Nothing
        Me.xtxt_count_desc.TabIndex = 3
        Me.xtxt_count_desc.Text = ""
        '
        'xtxt_count_number
        '
        Me.xtxt_count_number.AcceptsReturn = True
        Me.xtxt_count_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivcounte.count_number"))
        Me.xtxt_count_number.EditInitialValue = Nothing
        Me.xtxt_count_number.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_count_number.FieldDescription = ""
        Me.xtxt_count_number.FindInitialValue = Nothing
        Me.xtxt_count_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_count_number.IgnoreRequiered = True
        Me.xtxt_count_number.Location = New System.Drawing.Point(96, 16)
        Me.xtxt_count_number.Name = "xtxt_count_number"
        Me.xtxt_count_number.NewInitialValue = Nothing
        Me.xtxt_count_number.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_count_number.Requiered = False
        Me.xtxt_count_number.Size = New System.Drawing.Size(96, 20)
        Me.xtxt_count_number.StatusBarPanelDescripcion = Nothing
        Me.xtxt_count_number.TabIndex = 0
        Me.xtxt_count_number.Text = ""
        '
        'txtwhse_code
        '
        Me.txtwhse_code.AcceptsReturn = True
        Me.txtwhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivcounte.whse_code"))
        Me.txtwhse_code.EditInitialValue = Nothing
        Me.txtwhse_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtwhse_code.FieldDescription = ""
        Me.txtwhse_code.FindInitialValue = Nothing
        Me.txtwhse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.IgnoreRequiered = False
        Me.txtwhse_code.Location = New System.Drawing.Point(96, 40)
        Me.txtwhse_code.Name = "txtwhse_code"
        Me.txtwhse_code.NewInitialValue = Nothing
        Me.txtwhse_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.Requiered = False
        Me.txtwhse_code.Size = New System.Drawing.Size(96, 20)
        Me.txtwhse_code.StatusBarPanelDescripcion = Nothing
        Me.txtwhse_code.TabIndex = 2
        Me.txtwhse_code.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(13, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(32, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Número:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lkItem_code
        '
        Me.lkItem_code.AlternateFieldSearch = Nothing
        Me.lkItem_code.BeginCheck = False
        Me.lkItem_code.CheckText = Nothing
        Me.lkItem_code.ComboMode = False
        Me.lkItem_code.DataMember = ""
        Me.lkItem_code.DataSource = Me.LibXConnector1
        Me.lkItem_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "loc_row=loc_row", "loc_bin=loc_col", "estante=estante", "unit_code=unit_code", "factor=factor", "qty_on_hand=existencia"}
        Me.lkItem_code.FilterField = "item_name"
        Me.lkItem_code.IgnoreFindInBrowseMode = True
        Me.lkItem_code.isCanceled = False
        Me.lkItem_code.Location = New System.Drawing.Point(608, 80)
        Me.lkItem_code.LookCaption = "Productos"
        Me.lkItem_code.Name = "lkItem_code"
        Me.lkItem_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkItem_code.ShowFilter = True
        Me.lkItem_code.ShowMessageNotFound = True
        Me.lkItem_code.ShowWarning = False
        Me.lkItem_code.Size = New System.Drawing.Size(16, 20)
        Me.lkItem_code.SizesColumns = New String() {"item_name=400", "loc_row=60", "loc_col=60", "estante=60"}
        Me.lkItem_code.SizesColumnsTab = Nothing
        Me.lkItem_code.SqlString = New String() {"SELECT ivitemd.item_code,", "ivitemd.whse_code,", "ivitemm.item_name,", "ivitemd.loc_row,", "ivitemd.loc_col,", "ivitemd.estante,", "ivitemm.unit_code,", "ivunitd.factor,", "ivitemd.purch_cost,", "ivitemd.existencia ", "from ivitemd inner join ivitemv1 ivitemm", "on ivitemd.item_code=ivitemm.item_code", "left outer join ivunitd", "on ivunitd.item_code = ivitemm.item_code", "and ivunitd.unit_code = ivitemm.unit_code"}
        Me.lkItem_code.SQLTab = Nothing
        Me.lkItem_code.SrcParameters = New String() {"item_code=item_code"}
        Me.lkItem_code.TabIndex = 6
        Me.lkItem_code.TableName = "ivitemd"
        Me.lkItem_code.TabStop = False
        Me.lkItem_code.UseCopyConnection = False
        Me.lkItem_code.UseRowRetrieveEvents = False
        Me.lkItem_code.UseTab = False
        Me.lkItem_code.VisParameters = New String() {"Nombre=item_name", "Estante=estante", "Fila=loc_row", "Columna=loc_col", "Costo=purch_cost", "Existencia=existencia", "Código=item_code"}
        Me.lkItem_code.WhereCondition = Nothing
        Me.lkItem_code.WhereParameters = Nothing
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(728, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Fecha:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXGridDetalle
        '
        Me.LibXGridDetalle.AllowSorting = False
        Me.LibXGridDetalle.AutoAdjustLastColumn = True
        Me.LibXGridDetalle.AutoSearch = False
        Me.LibXGridDetalle.BackgroundColor = System.Drawing.Color.White
        Me.LibXGridDetalle.CaptionText = "Articulos"
        Me.LibXGridDetalle.DataMember = "ivcountd"
        Me.LibXGridDetalle.DataSource = Me.DataSet1
        Me.LibXGridDetalle.FullRowSelect = False
        Me.LibXGridDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGridDetalle.IsReadOnly = False
        Me.LibXGridDetalle.Location = New System.Drawing.Point(8, 160)
        Me.LibXGridDetalle.Name = "LibXGridDetalle"
        Me.LibXGridDetalle.ReadOnly = True
        Me.LibXGridDetalle.RowHeaderWidth = 30
        Me.LibXGridDetalle.searchText = ""
        Me.LibXGridDetalle.showFooterBar = True
        Me.LibXGridDetalle.Size = New System.Drawing.Size(968, 400)
        Me.LibXGridDetalle.TabIndex = 2
        Me.LibXGridDetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGridDetalle.UseAutoFillLines = True
        Me.LibXGridDetalle.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGridDetalle
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColITem_code, Me.gColitem_name, Me.XEditTextBoxColumn3, Me.XEditTextBoxUnidad, Me.gColFactor, Me.gColline_no, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn1, Me.gColConteo})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivcountd"
        Me.XdataGridTableStyle1.RowHeaderWidth = 30
        '
        'gColITem_code
        '
        Me.gColITem_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColITem_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.gColITem_code.executeFindDuringFill = False
        Me.gColITem_code.Format = ""
        Me.gColITem_code.FormatInfo = Nothing
        Me.gColITem_code.HeaderText = "Producto"
        Me.gColITem_code.isReadOnly = False
        Me.gColITem_code.Lookup = Me.lkItem_code
        Me.gColITem_code.MappingName = "item_code"
        Me.gColITem_code.MaxLength = 32767
        Me.gColITem_code.TabStop = True
        Me.gColITem_code.UseCustomCellFormat = False
        Me.gColITem_code.Width = 117
        '
        'gColitem_name
        '
        Me.gColitem_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.gColitem_name.Format = ""
        Me.gColitem_name.FormatInfo = Nothing
        Me.gColitem_name.HeaderText = "Descripción"
        Me.gColitem_name.ImageList = Nothing
        Me.gColitem_name.isReadOnly = True
        Me.gColitem_name.MappingName = "item_name"
        Me.gColitem_name.MaxLength = 32767
        Me.gColitem_name.ReadOnly = True
        Me.gColitem_name.TabStop = True
        Me.gColitem_name.UseCustomCellFormat = False
        Me.gColitem_name.Width = 350
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "EXIST"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = True
        Me.XEditTextBoxColumn3.MappingName = "qty_on_hand"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.ReadOnly = True
        Me.XEditTextBoxColumn3.TabStop = True
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 50
        '
        'XEditTextBoxUnidad
        '
        Me.XEditTextBoxUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxUnidad.Format = ""
        Me.XEditTextBoxUnidad.FormatInfo = Nothing
        Me.XEditTextBoxUnidad.HeaderText = "Unidad"
        Me.XEditTextBoxUnidad.ImageList = Nothing
        Me.XEditTextBoxUnidad.isReadOnly = True
        Me.XEditTextBoxUnidad.MappingName = "unit_code"
        Me.XEditTextBoxUnidad.MaxLength = 32767
        Me.XEditTextBoxUnidad.TabStop = True
        Me.XEditTextBoxUnidad.UseCustomCellFormat = False
        Me.XEditTextBoxUnidad.Width = 75
        '
        'gColFactor
        '
        Me.gColFactor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColFactor.Format = ""
        Me.gColFactor.FormatInfo = Nothing
        Me.gColFactor.HeaderText = "Factor"
        Me.gColFactor.ImageList = Nothing
        Me.gColFactor.isReadOnly = True
        Me.gColFactor.MappingName = "factor"
        Me.gColFactor.MaxLength = 32767
        Me.gColFactor.ReadOnly = True
        Me.gColFactor.TabStop = False
        Me.gColFactor.UseCustomCellFormat = False
        Me.gColFactor.Width = 50
        '
        'gColline_no
        '
        Me.gColline_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColline_no.Format = ""
        Me.gColline_no.FormatInfo = Nothing
        Me.gColline_no.HeaderText = "Linea"
        Me.gColline_no.ImageList = Nothing
        Me.gColline_no.isReadOnly = True
        Me.gColline_no.MappingName = "line_no"
        Me.gColline_no.MaxLength = 32767
        Me.gColline_no.ReadOnly = True
        Me.gColline_no.TabStop = True
        Me.gColline_no.UseCustomCellFormat = False
        Me.gColline_no.Width = 52
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Vencimiento"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "loc_bin"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 75
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Ubicacion"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "loc_row"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 75
        '
        'gColConteo
        '
        Me.gColConteo.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColConteo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColConteo.Format = "###,###"
        Me.gColConteo.FormatInfo = Nothing
        Me.gColConteo.HeaderText = "Conteoi"
        Me.gColConteo.ImageList = Nothing
        Me.gColConteo.isReadOnly = False
        Me.gColConteo.MappingName = "count_qty"
        Me.gColConteo.MaxLength = 32767
        Me.gColConteo.TabStop = True
        Me.gColConteo.UseCustomCellFormat = False
        Me.gColConteo.Width = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(29, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Almacén:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXLookup3
        '
        Me.LibXLookup3.AlternateFieldSearch = Nothing
        Me.LibXLookup3.BeginCheck = False
        Me.LibXLookup3.CheckText = Nothing
        Me.LibXLookup3.ComboMode = False
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Me.LibXConnector1
        Me.LibXLookup3.DestParameters = New String() {"txtwhse_code=whse_code", "txtwhse_name=whse_name"}
        Me.LibXLookup3.FilterField = Nothing
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.isCanceled = False
        Me.LibXLookup3.Location = New System.Drawing.Point(496, 40)
        Me.LibXLookup3.LookCaption = "Almacenes"
        Me.LibXLookup3.Name = "LibXLookup3"
        Me.LibXLookup3.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup3.ShowFilter = True
        Me.LibXLookup3.ShowMessageNotFound = True
        Me.LibXLookup3.ShowWarning = False
        Me.LibXLookup3.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup3.SizesColumns = Nothing
        Me.LibXLookup3.SizesColumnsTab = Nothing
        Me.LibXLookup3.SqlString = Nothing
        Me.LibXLookup3.SQLTab = Nothing
        Me.LibXLookup3.SrcParameters = New String() {"whse_code=whse_code"}
        Me.LibXLookup3.TabIndex = 2
        Me.LibXLookup3.TableName = "ivwhsem"
        Me.LibXLookup3.TabStop = False
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.UseTab = False
        Me.LibXLookup3.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.LibXLookup3.WhereCondition = Nothing
        Me.LibXLookup3.WhereParameters = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtwhse_name)
        Me.GroupBox1.Controls.Add(Me.xdt_count_date)
        Me.GroupBox1.Controls.Add(Me.xcbo_doc_status)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xtxt_count_number)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xtxt_count_desc)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.LibXLookup3)
        Me.GroupBox1.Controls.Add(Me.txtwhse_code)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.XTextBox3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.xtxt_PageNo)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(952, 120)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtwhse_name
        '
        Me.txtwhse_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtwhse_name.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtwhse_name.Location = New System.Drawing.Point(200, 40)
        Me.txtwhse_name.Name = "txtwhse_name"
        Me.txtwhse_name.Size = New System.Drawing.Size(296, 20)
        Me.txtwhse_name.TabIndex = 29
        '
        'xdt_count_date
        '
        Me.xdt_count_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_count_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ivcounte.count_date"))
        Me.xdt_count_date.EditInitialValue = Nothing
        Me.xdt_count_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_count_date.FieldDescription = ""
        Me.xdt_count_date.FindInitialValue = Nothing
        Me.xdt_count_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_count_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_count_date.IgnoreRequiered = False
        Me.xdt_count_date.Location = New System.Drawing.Point(784, 16)
        Me.xdt_count_date.Name = "xdt_count_date"
        Me.xdt_count_date.NewInitialValue = "now"
        Me.xdt_count_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_count_date.Requiered = False
        Me.xdt_count_date.Size = New System.Drawing.Size(120, 20)
        Me.xdt_count_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_count_date.TabIndex = 28
        '
        'xcbo_doc_status
        '
        Me.xcbo_doc_status.AllowDefaultSort = True
        Me.xcbo_doc_status.bound = True
        Me.xcbo_doc_status.currValue = Nothing
        Me.xcbo_doc_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ivcounte.count_status"))
        Me.xcbo_doc_status.DefaultWhereString = Nothing
        Me.xcbo_doc_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_doc_status.EditInitialValue = "1"
        Me.xcbo_doc_status.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_doc_status.FieldDescription = ""
        Me.xcbo_doc_status.FindInitialValue = "0"
        Me.xcbo_doc_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_doc_status.IgnoreRequiered = False
        Me.xcbo_doc_status.Items.AddRange(New Object() {"0 - Generada", "1 - Editada", "2 - Impresa", "3 - Aplicada"})
        Me.xcbo_doc_status.Location = New System.Drawing.Point(784, 40)
        Me.xcbo_doc_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_doc_status.LookupKeyField = Nothing
        Me.xcbo_doc_status.LookupTableName = Nothing
        Me.xcbo_doc_status.Name = "xcbo_doc_status"
        Me.xcbo_doc_status.NewInitialValue = "1"
        Me.xcbo_doc_status.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_doc_status.Requiered = False
        Me.xcbo_doc_status.Required = False
        Me.xcbo_doc_status.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_doc_status.SqlString = Nothing
        Me.xcbo_doc_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_doc_status.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(720, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Estatus:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(720, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Usuario:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = True
        Me.XTextBox2.Location = New System.Drawing.Point(784, 64)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox2.ReadOnly = True
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(120, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 1
        Me.XTextBox2.TabStop = False
        Me.XTextBox2.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(720, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Creado:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = True
        Me.XTextBox3.Location = New System.Drawing.Point(784, 88)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox3.ReadOnly = True
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(120, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 1
        Me.XTextBox3.TabStop = False
        Me.XTextBox3.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(336, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Página No.:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_PageNo
        '
        Me.xtxt_PageNo.AcceptsReturn = True
        Me.xtxt_PageNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivcounte.PageNo"))
        Me.xtxt_PageNo.EditInitialValue = Nothing
        Me.xtxt_PageNo.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_PageNo.FieldDescription = ""
        Me.xtxt_PageNo.FindInitialValue = Nothing
        Me.xtxt_PageNo.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_PageNo.IgnoreRequiered = True
        Me.xtxt_PageNo.Location = New System.Drawing.Point(408, 16)
        Me.xtxt_PageNo.Name = "xtxt_PageNo"
        Me.xtxt_PageNo.NewInitialValue = "1"
        Me.xtxt_PageNo.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_PageNo.Requiered = False
        Me.xtxt_PageNo.Size = New System.Drawing.Size(104, 20)
        Me.xtxt_PageNo.StatusBarPanelDescripcion = Nothing
        Me.xtxt_PageNo.TabIndex = 1
        Me.xtxt_PageNo.Text = ""
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(8, 624)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivcountd.item_name"))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(80, 624)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(592, 20)
        Me.Label4.TabIndex = 32
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "*.txt"
        Me.OpenFileDialog1.Filter = "Texto|*.txt"
        Me.OpenFileDialog1.Title = "Cargar Archivo de Lote"
        '
        'i_ivcount01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(986, 664)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXGridDetalle)
        Me.Controls.Add(Me.lkItem_code)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivcount01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Registrar Hoja de Conteo"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                If IsNull(e.UpdatingArgs.Row!count_date) Then
                    e.UpdatingArgs.Row!count_date = LibX.Data.Manager.Connection.GetDate
                    'e.UpdatingArgs.Row!suc_code = ScDefault
                End If
                '// si se va a aplicar ponerla en estatus editada
                e.UpdatingArgs.Row!count_status = 1 '' generada

                e.UpdatingArgs.Row!count_number = oDoc.GenerateNumber("INV", e.UpdatingArgs.Row!whse_code)
            End If

            If e.UpdatingArgs.Row!count_status = 3 Then '' aplicada
                e.UpdatingArgs.Row!count_status = 2 '' impresa
            End If

            If e.UpdatingArgs.StatementType = StatementType.Delete Then
                Dim XDelete As LibX.Data.XDeleteStmt

                'LiberarProductos(e.UpdatingArgs.Row.Item("count_number", DataRowVersion.Original))

                XDelete = New LibX.Data.XDeleteStmt("ivcountd")
                XDelete.Fields("count_number") = e.UpdatingArgs.Row.Item("count_number", DataRowVersion.Original)
                XDelete.Execute()

                XDelete = New LibX.Data.XDeleteStmt("ivcounte")
                XDelete.Fields("count_number") = e.UpdatingArgs.Row.Item("count_number", DataRowVersion.Original)
                XDelete.Execute()

                e.UpdatingArgs.Status = UpdateStatus.SkipAllRemainingRows
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            Log.Add(ex)

        End Try
    End Sub

    'Private Sub LiberarProductos(ByVal countNumber As Integer)
    '    Dim SelectStmt As String
    '    Dim oTable As DataTable
    '    Dim XUpdate As LibX.Data.XUpdateStmt

    '    SelectStmt = "select item_code, whse_code from ivcountd " & _
    '                 " where count_number = " & countNumber.ToString.Trim

    '    oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

    '    If oTable Is Nothing Then
    '        Exit Sub
    '    End If

    '    If oTable.Rows.Count <= 0 Then
    '        Exit Sub
    '    End If

    '    XUpdate = New LibX.Data.XUpdateStmt("ivitemd")

    '    XUpdate.FieldsSet("frizado_inv") = 0
    '    XUpdate.FieldsSet("fecha_frizado") = DBNull.Value
    '    XUpdate.Fields("item_code") = "aaaaaa"
    '    XUpdate.Fields("whse_code") = 1

    '    For Each oRow As DataRow In oTable.Rows
    '        XUpdate.Fields("item_code").value = oRow!item_code
    '        XUpdate.Fields("whse_code").value = oRow!whse_code
    '        XUpdate.Execute()
    '    Next

    '    oTable = Nothing
    '    XUpdate = Nothing
    'End Sub

    Private Sub lkItem_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lkItem_code.BeforeExecuteQuery
        Try
            If LibXConnector1.CurrentAction = LibxConnectionActions.Edit Then
                e.aditionalWhere = "1=2"
            Else
                If Trim(Me.txtwhse_code.Text) <> "" Then
                    e.aditionalWhere = String.Concat(" ivitemd.whse_code ='", Trim(Me.txtwhse_code.Text), "'")
                End If
            End If

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try
            'LibxDateTimePicker1.Value = LibX.Data.Manager.Connection.GetDate.ToString("d")
            xcbo_doc_status.currValue = 1 '//Editada
            LibXConnector1.CurrentDataRow!count_status = 1
            xtxt_PageNo.Text = "1"

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        'Dim SelecStmt As String
        'Try
        '    Dim AxCrystalReport1 As New LibX.ReportLib

        '    If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
        '        With AxCrystalReport1
        '            .ReportFileName = MdlUtil.GetReportPath("INV", "r_ivcount01.rpt")
        '            .Connect = Configuration.ConfigurationSettings.AppSettings.Get("LibXConnectReport")

        '            For i As Int16 = 0 To .GetNSubreports - 1
        '                .SubreportToChange = .GetNthSubreportName(i)
        '                .Connect = Configuration.ConfigurationSettings.AppSettings.Get("LibXConnectReport")
        '            Next

        '            .SubreportToChange = ""

        '            .RetrieveSQLQuery()
        '            SelecStmt = .SQLQuery
        '            SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, "ivcounte.count_number = " & LibXConnector1.CurrentDataRow!count_number)
        '            .SQLQuery = SelecStmt

        '            .WindowState = ReportLib.WindowsStates.Maximixed
        '            .Action = 1
        '        End With
        '    End If

        'Catch ex As Exception
        '    LibX.Log.Show(ex)

        'End Try
    End Sub

    Private Sub LibXConnector1_InsertingDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingDetailRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then
                If IsNull(e.UpdatingArgs.Row!item_code) Then
                    e.UpdatingArgs.Status = UpdateStatus.SkipCurrentRow
                End If
                e.UpdatingArgs.Row!count_status = Val(EstatusHojaConteoEnum.Editada) 'EDITADA
            End If


        Catch ex As Exception
            Log.Add(ex)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
        End Try
    End Sub

    Private Sub i_ivcount01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            oDoc = New SGT.Inventario.Entidades.Documento("INV")
            LibXGridDetalle.footerOperations.add("item_code", "count(item_code)", "1=1")
            LibXGridDetalle.footerOperations.add("count_qty", "count(count_qty)", "count_qty <> 0")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaulteditValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultEditValues) Handles LibXConnector1.SettingDefaulteditValues
        Try
            xcbo_doc_status.currValue = 1 '// Editar
            LibXConnector1.CurrentDataRow!count_status = Val(EstatusHojaConteoEnum.Editada) '// Editar

            Me.gColITem_code.ReadOnly = True
            Me.gColITem_code.isReadOnly = True

            Me.LibXGridDetalle.getCurrentGridView.AllowDelete = False
            Me.LibXGridDetalle.getCurrentGridView.AllowNew = False

            Me.lkItem_code.Enabled = False
            Me.LibXGridDetalle.Focus()
            'Me.LibXGridDetalle.Focus(0, 6)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        ''''Dim PageNo As Integer
        ''''Dim LineNo As Integer
        ''''Try

        ''''    If LibXConnector1.CurrentAction = LibxConnectionActions.Add Then
        ''''        LineNo = 66
        ''''        PageNo = 0

        ''''        For Each oRow As DataRow In Me.DataSet1.Tables("ivcountd").Rows
        ''''            If LineNo > 33 Then
        ''''                LineNo = 1
        ''''                PageNo += 1
        ''''            End If

        ''''            oRow!line_no = LineNo
        ''''            oRow!pageno = PageNo
        ''''            oRow!count_status = Me.xcbo_doc_status.currValue
        ''''            LineNo += 1
        ''''        Next
        ''''    End If

        If LibXConnector1.CurrentAction = LibxConnectionActions.Edit Then
            For Each oRow As DataRow In Me.DataSet1.Tables("ivcountd").Rows
                oRow!count_status = Val(EstatusHojaConteoEnum.Editada) '// Editar
            Next
        End If

        ''''Catch ex As Exception
        ''''    LibX.Log.Add(ex, True)
        ''''End Try

    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If LibXConnector1.HasRecords = True Then
                If Not e.row Is Nothing Then
                    If Val(e.row!count_status.ToString.Trim) = Val(EstatusHojaConteoEnum.Aplicada) Then
                        LibXConnector1.AllowEdit = False
                        LibXConnector1.AllowDelete = False
                    Else
                        LibXConnector1.AllowEdit = True
                        LibXConnector1.AllowDelete = True
                    End If

                    LibXNavigator1.UpdateState()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.AfterSaveDetail
        Dim XUpdate As LibX.Data.XUpdateStmt
        Try
            LibXConnector1.CurrentDataRow!count_status = Val(EstatusHojaConteoEnum.Editada) '// Editar
            'If LibXConnector1.CurrentAction = LibxConnectionActions.Add Then
            '    XUpdate = New LibX.Data.XUpdateStmt("ivitemd")

            '    For Each oRow As DataRow In Me.DataSet1.Tables("ivcountd").Rows
            '        'XUpdate.Fields("item_code") = "aaaaaaaaaa"
            '        'XUpdate.Fields("whse_code") = 0
            '        'XUpdate.FieldsSet("frizado_inv") = 0
            '        'XUpdate.FieldsSet("fecha_frizado") = LibX.Data.Manager.Connection.GetDate

            '        If oRow.RowState <> DataRowState.Deleted Then
            '            XUpdate.FieldsSet("frizado_inv").value = 1
            '            XUpdate.FieldsSet("fecha_frizado").value = LibX.Data.Manager.Connection.GetDate

            '            XUpdate.Fields("item_code").value = oRow!item_code
            '            XUpdate.Fields("whse_code").value = oRow!whse_code
            '        Else
            '            XUpdate.FieldsSet("frizado_inv").value = 0
            '            XUpdate.FieldsSet("fecha_frizado").value = DBNull.Value

            '            XUpdate.Fields("item_code").value = oRow.Item("item_code", DataRowVersion.Original)
            '            XUpdate.Fields("whse_code").value = oRow.Item("whse_code", DataRowVersion.Original)
            '        End If
            '        XUpdate.Execute()
            '    Next
            'End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        '''Try
        '''    If e.action = LibxConnectionActions.Edit And LibXConnector1.HasRecords = True Then
        '''        gColITem_code.isReadOnly = True
        '''        gColITem_code.ReadOnly = True
        '''        lkItem_code.Enabled = False
        '''    End If
        '''Catch ex As Exception
        '''    LibX.Log.Add(ex, True)
        '''End Try
    End Sub

    Private Sub LibXGridDetalle_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGridDetalle.CellValidate
        Try
            If LibXConnector1.IsDataEditing = True Then
                If e.cell = gColITem_code.Column Then
                    If LibX.IsNull(e.value) Then
                        e.hasErrors = True
                        Exit Sub
                    End If
                End If

                ''''If e.cell = gColConteo.Column Then
                ''''    If LibX.IsNull(e.value) Then
                ''''        e.hasErrors = True
                ''''        Exit Sub
                ''''    End If
                ''''End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXGridDetalle_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles LibXGridDetalle.Navigate

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oParametroCArgas As SGT.Inventario.Operaciones.HojaConteo.ParametrosCargarLote
        Dim oHojaConteo As SGT.Inventario.Operaciones.HojaConteo

        If OpenFileDialog1.ShowDialog(Me) = DialogResult.Cancel Then
            Exit Sub
        End If
        Try
            oParametroCArgas = New SGT.Inventario.Operaciones.HojaConteo.ParametrosCargarLote
            oHojaConteo = New SGT.Inventario.Operaciones.HojaConteo

            oParametroCArgas.PathAndFileName = OpenFileDialog1.FileName
            oParametroCArgas.Almacen = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxWhDefault")
            oParametroCArgas.Descripcion = InputBox("Digite la Descripcion de la Carga", "Generar Hoja")
            oParametroCArgas.UseTransaction = True

            oHojaConteo.CargarLote(oParametroCArgas)

            LibXConnector1.ExecuteFind("ivcounte.count_number = " & oParametroCArgas.Retorno.HojaNumero.ToString)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            If e.Action = LibxConnectionActions.Delete Then
                If MessageBox.Show("Se eliminarán todas las paginas pertecientes a esta hoja de contedo!, Seguro desea eliminarlas?", "Eliminar Hoja con todas sus paginas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                    e.Handled = True
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        If e.Action = LibxConnectionActions.Delete Then
            LibXConnector1.ReQuery()
        End If

    End Sub

    Private Sub txtwhse_name_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtwhse_name.Click

    End Sub

    Private Sub LibXGridDetalle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LibXGridDetalle.Click

    End Sub

    Private Sub LibXConnector1_InsertedRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedRow
        Dim oPost As SGT.Inventario.Operaciones.HojaConteo
        Dim oPostParam As SGT.Inventario.Operaciones.HojaConteo.ParametrosAplicar

        Try

            If xcbo_doc_status.currValue <> 3 Then
                Exit Sub
            End If


            oPost = New SGT.Inventario.Operaciones.HojaConteo
            oPostParam = New SGT.Inventario.Operaciones.HojaConteo.ParametrosAplicar

            With oPostParam
                .Almacen = LibXConnector1.CurrentDataRow!whse_code
                .ConteNo = LibXConnector1.CurrentDataRow!count_number
                .Fecha = LibXConnector1.CurrentDataRow!count_date
                .PaginaNo = LibXConnector1.CurrentDataRow!PageNo
                .UseTransaction = False

            End With

            If oPost.AplicarHoja(oPostParam) = True Then
                MessageBox.Show("Inventario Aplicado!", "Aplicar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class
