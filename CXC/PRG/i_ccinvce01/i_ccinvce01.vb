Public Class i_ccinvce01
    Inherits System.Windows.Forms.Form
    Dim Conf As SGT.Inventario.Common.Configuration
    Dim ScDefault As Integer
    Dim Transf As Boolean = False

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As LibX.XTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtinvce_no As LibX.XTextBox
    Friend WithEvents term_name As LibX.XTextBox
    Friend WithEvents txtcust_code As LibX.XTextBox
    Friend WithEvents cust_name As LibX.XTextBox
    Friend WithEvents xlk_term_code As LibX.LibXLookup
    Friend WithEvents xlk_cust_code As LibX.LibXLookup
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents xcbo_invce_status As LibX.LibXCombo
    Friend WithEvents xdtp_due_date As LibX.LibxDateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnDetalle As System.Windows.Forms.Button
    Friend WithEvents btnTermino As System.Windows.Forms.Button
    Friend WithEvents lnk_Cliente As System.Windows.Forms.LinkLabel
    Friend WithEvents btnMov As System.Windows.Forms.Button
    Friend WithEvents balance As LibX.XTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents vend_name As LibX.XTextBox
    Friend WithEvents xlk_vend_code As LibX.LibXLookup
    Friend WithEvents disc_days As LibX.XTextBox
    Friend WithEvents due_days As LibX.XTextBox
    Friend WithEvents disc_pct As LibX.XTextBox
    Friend WithEvents xdtp_invce_date As LibX.LibxDateTimePicker
    Friend WithEvents DataSet1 As System.Data.DataSet
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
    Friend WithEvents txttotal_amount As LibX.XTextBox
    Friend WithEvents txtitbis As LibX.XTextBox
    Friend WithEvents txtamount As LibX.XTextBox
    Friend WithEvents txtExcento As LibX.XTextBox
    Friend WithEvents txtGrabado As LibX.XTextBox
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents txtterm_code As LibX.XTextBox
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents credit_limit As LibX.XTextBox
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdescuento As LibX.XTextBox
    Friend WithEvents txtvend_code As LibX.XTextBox
    Friend WithEvents ccinvcem As System.Data.DataTable
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents xcbo_type_code As LibX.LibXCombo
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents btnTransf As System.Windows.Forms.Button
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents xtc_suc_name As LibX.XTextBox
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(i_ccinvce01))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.XTextBox1 = New LibX.XTextBox
        Me.DataSet1 = New System.Data.DataSet
        Me.ccinvcem = New System.Data.DataTable
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
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.xtc_suc_name = New LibX.XTextBox
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnTransf = New System.Windows.Forms.Button
        Me.xcbo_type_code = New LibX.LibXCombo
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.disc_pct = New LibX.XTextBox
        Me.xdtp_due_date = New LibX.LibxDateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.term_name = New LibX.XTextBox
        Me.due_days = New LibX.XTextBox
        Me.txtterm_code = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.disc_days = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.xlk_term_code = New LibX.LibXLookup
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtcust_code = New LibX.XTextBox
        Me.lnk_Cliente = New System.Windows.Forms.LinkLabel
        Me.xlk_cust_code = New LibX.LibXLookup
        Me.cust_name = New LibX.XTextBox
        Me.balance = New LibX.XTextBox
        Me.credit_limit = New LibX.XTextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.xcbo_invce_status = New LibX.LibXCombo
        Me.xdtp_invce_date = New LibX.LibxDateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtinvce_no = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox8 = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txttotal_amount = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtitbis = New LibX.XTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtamount = New LibX.XTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtExcento = New LibX.XTextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtGrabado = New LibX.XTextBox
        Me.txtvend_code = New LibX.XTextBox
        Me.vend_name = New LibX.XTextBox
        Me.xlk_vend_code = New LibX.LibXLookup
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtdescuento = New LibX.XTextBox
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.btnDetalle = New System.Windows.Forms.Button
        Me.btnTermino = New System.Windows.Forms.Button
        Me.btnMov = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccinvcem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.xtc_suc_name)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.btnTransf)
        Me.GroupBox1.Controls.Add(Me.xcbo_type_code)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.xcbo_invce_status)
        Me.GroupBox1.Controls.Add(Me.xdtp_invce_date)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtinvce_no)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txttotal_amount)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtitbis)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtamount)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtExcento)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtGrabado)
        Me.GroupBox1.Controls.Add(Me.txtvend_code)
        Me.GroupBox1.Controls.Add(Me.vend_name)
        Me.GroupBox1.Controls.Add(Me.xlk_vend_code)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtdescuento)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 376)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.suc_code"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(136, 11)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 49
        Me.XTextBox1.Text = ""
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ccinvcem})
        '
        'ccinvcem
        '
        Me.ccinvcem.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28})
        Me.ccinvcem.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"invce_serial"}, True)})
        Me.ccinvcem.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.ccinvcem.TableName = "ccinvcem"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.AutoIncrementSeed = CType(1, Long)
        Me.DataColumn1.ColumnName = "invce_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "type_code"
        Me.DataColumn2.MaxLength = 3
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "invce_no"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "term_code"
        Me.DataColumn4.MaxLength = 5
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "invce_date"
        Me.DataColumn5.DataType = GetType(System.DateTime)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "detail"
        Me.DataColumn6.MaxLength = 60
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "due_date"
        Me.DataColumn7.DataType = GetType(System.DateTime)
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "amount"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "itbis"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "cust_code"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "excento"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "impto"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "invce_status"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "vend_code"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "total_amount"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "userid"
        Me.DataColumn16.MaxLength = 18
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "amount_grab"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "amount_excent"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "cargo_banc"
        Me.DataColumn19.DataType = GetType(System.Decimal)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "cargo_desc"
        Me.DataColumn20.DataType = GetType(System.Decimal)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "invce_ncf"
        Me.DataColumn21.MaxLength = 20
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "cash_amount"
        Me.DataColumn22.DataType = GetType(System.Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "card_amount"
        Me.DataColumn23.DataType = GetType(System.Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "check_amount"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "chequera"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.AllowDBNull = False
        Me.DataColumn26.ColumnName = "suc_code"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'xtc_suc_name
        '
        Me.xtc_suc_name.AcceptsReturn = True
        Me.xtc_suc_name.EditInitialValue = Nothing
        Me.xtc_suc_name.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtc_suc_name.FieldDescription = ""
        Me.xtc_suc_name.FindInitialValue = Nothing
        Me.xtc_suc_name.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtc_suc_name.IgnoreRequiered = False
        Me.xtc_suc_name.Location = New System.Drawing.Point(200, 11)
        Me.xtc_suc_name.Name = "xtc_suc_name"
        Me.xtc_suc_name.NewInitialValue = Nothing
        Me.xtc_suc_name.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtc_suc_name.ReadOnly = True
        Me.xtc_suc_name.Requiered = False
        Me.xtc_suc_name.Size = New System.Drawing.Size(272, 20)
        Me.xtc_suc_name.StatusBarPanelDescripcion = Nothing
        Me.xtc_suc_name.TabIndex = 48
        Me.xtc_suc_name.TabStop = False
        Me.xtc_suc_name.Text = ""
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"suc_code=suc_code", "xtc_suc_name=suc_name"}
        Me.LibXLookup1.FilterField = ""
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(472, 11)
        Me.LibXLookup1.LookCaption = "Sucursales"
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup1.ShowFilter = True
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.ShowWarning = False
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SizesColumns = Nothing
        Me.LibXLookup1.SizesColumnsTab = Nothing
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"suc_code=suc_code"}
        Me.LibXLookup1.TabIndex = 50
        Me.LibXLookup1.TableName = "cgsucursal"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=suc_code", "Nombre=suc_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "ccinvcem"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
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
        Me.LibXDbSourceTable1.SerialColumnName = "invce_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ccinvcem"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "invce_datetran"
        Me.DataColumn27.DataType = GetType(System.DateTime)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "invce_create"
        Me.DataColumn28.DataType = GetType(System.DateTime)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(64, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 16)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Sucursal:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnTransf
        '
        Me.btnTransf.Image = CType(resources.GetObject("btnTransf.Image"), System.Drawing.Image)
        Me.btnTransf.Location = New System.Drawing.Point(520, 24)
        Me.btnTransf.Name = "btnTransf"
        Me.btnTransf.Size = New System.Drawing.Size(32, 23)
        Me.btnTransf.TabIndex = 46
        '
        'xcbo_type_code
        '
        Me.xcbo_type_code.AllowDefaultSort = True
        Me.xcbo_type_code.bound = True
        Me.xcbo_type_code.currValue = Nothing
        Me.xcbo_type_code.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ccinvcem.type_code"))
        Me.xcbo_type_code.DefaultWhereString = "apply_cxc = 1 and type_code in ('FCT','NCC','NDC','FCT','CDC','CSC')"
        Me.xcbo_type_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_type_code.EditInitialValue = Nothing
        Me.xcbo_type_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_type_code.FieldDescription = ""
        Me.xcbo_type_code.FindInitialValue = Nothing
        Me.xcbo_type_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_type_code.IgnoreRequiered = False
        Me.xcbo_type_code.Location = New System.Drawing.Point(136, 34)
        Me.xcbo_type_code.LookupKeyDisplayFields = "type_name"
        Me.xcbo_type_code.LookupKeyField = "type_code"
        Me.xcbo_type_code.LookupTableName = "ivtypem"
        Me.xcbo_type_code.Name = "xcbo_type_code"
        Me.xcbo_type_code.NewInitialValue = Nothing
        Me.xcbo_type_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_type_code.Requiered = False
        Me.xcbo_type_code.Required = False
        Me.xcbo_type_code.Size = New System.Drawing.Size(352, 21)
        Me.xcbo_type_code.SqlString = Nothing
        Me.xcbo_type_code.StatusBarPanelDescripcion = Nothing
        Me.xcbo_type_code.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.disc_pct)
        Me.GroupBox4.Controls.Add(Me.xdtp_due_date)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.term_name)
        Me.GroupBox4.Controls.Add(Me.due_days)
        Me.GroupBox4.Controls.Add(Me.txtterm_code)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.disc_days)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.xlk_term_code)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox4.Location = New System.Drawing.Point(8, 205)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(504, 96)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Condición"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(256, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Días de Vencimiento:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(264, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Fecha Vencimiento:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'disc_pct
        '
        Me.disc_pct.AcceptsReturn = True
        Me.disc_pct.EditInitialValue = Nothing
        Me.disc_pct.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.disc_pct.FieldDescription = ""
        Me.disc_pct.FindInitialValue = Nothing
        Me.disc_pct.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.disc_pct.IgnoreRequiered = False
        Me.disc_pct.Location = New System.Drawing.Point(128, 64)
        Me.disc_pct.Name = "disc_pct"
        Me.disc_pct.NewInitialValue = Nothing
        Me.disc_pct.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.disc_pct.ReadOnly = True
        Me.disc_pct.Requiered = False
        Me.disc_pct.Size = New System.Drawing.Size(56, 20)
        Me.disc_pct.StatusBarPanelDescripcion = Nothing
        Me.disc_pct.TabIndex = 1
        Me.disc_pct.TabStop = False
        Me.disc_pct.Text = ""
        '
        'xdtp_due_date
        '
        Me.xdtp_due_date.CustomFormat = "dd/MM/yyyy"
        Me.xdtp_due_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ccinvcem.due_date"))
        Me.xdtp_due_date.EditInitialValue = Nothing
        Me.xdtp_due_date.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdtp_due_date.FieldDescription = ""
        Me.xdtp_due_date.FindInitialValue = Nothing
        Me.xdtp_due_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_due_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdtp_due_date.IgnoreRequiered = False
        Me.xdtp_due_date.Location = New System.Drawing.Point(376, 64)
        Me.xdtp_due_date.Name = "xdtp_due_date"
        Me.xdtp_due_date.NewInitialValue = Nothing
        Me.xdtp_due_date.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdtp_due_date.Requiered = False
        Me.xdtp_due_date.Size = New System.Drawing.Size(104, 20)
        Me.xdtp_due_date.StatusBarPanelDescripcion = Nothing
        Me.xdtp_due_date.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(24, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "% de descuento:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'term_name
        '
        Me.term_name.AcceptsReturn = True
        Me.term_name.EditInitialValue = Nothing
        Me.term_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.term_name.FieldDescription = ""
        Me.term_name.FindInitialValue = Nothing
        Me.term_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.term_name.IgnoreRequiered = False
        Me.term_name.Location = New System.Drawing.Point(192, 16)
        Me.term_name.Name = "term_name"
        Me.term_name.NewInitialValue = Nothing
        Me.term_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.term_name.ReadOnly = True
        Me.term_name.Requiered = False
        Me.term_name.Size = New System.Drawing.Size(272, 20)
        Me.term_name.StatusBarPanelDescripcion = Nothing
        Me.term_name.TabIndex = 1
        Me.term_name.TabStop = False
        Me.term_name.Text = ""
        '
        'due_days
        '
        Me.due_days.AcceptsReturn = True
        Me.due_days.EditInitialValue = Nothing
        Me.due_days.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.due_days.FieldDescription = ""
        Me.due_days.FindInitialValue = Nothing
        Me.due_days.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.due_days.IgnoreRequiered = False
        Me.due_days.Location = New System.Drawing.Point(376, 40)
        Me.due_days.Name = "due_days"
        Me.due_days.NewInitialValue = Nothing
        Me.due_days.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.due_days.ReadOnly = True
        Me.due_days.Requiered = False
        Me.due_days.Size = New System.Drawing.Size(104, 20)
        Me.due_days.StatusBarPanelDescripcion = Nothing
        Me.due_days.TabIndex = 1
        Me.due_days.TabStop = False
        Me.due_days.Text = ""
        '
        'txtterm_code
        '
        Me.txtterm_code.AcceptsReturn = True
        Me.txtterm_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.term_code"))
        Me.txtterm_code.EditInitialValue = Nothing
        Me.txtterm_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtterm_code.FieldDescription = ""
        Me.txtterm_code.FindInitialValue = Nothing
        Me.txtterm_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtterm_code.IgnoreRequiered = False
        Me.txtterm_code.Location = New System.Drawing.Point(128, 16)
        Me.txtterm_code.Name = "txtterm_code"
        Me.txtterm_code.NewInitialValue = Nothing
        Me.txtterm_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtterm_code.Requiered = False
        Me.txtterm_code.Size = New System.Drawing.Size(56, 20)
        Me.txtterm_code.StatusBarPanelDescripcion = Nothing
        Me.txtterm_code.TabIndex = 0
        Me.txtterm_code.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(63, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Término:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'disc_days
        '
        Me.disc_days.AcceptsReturn = True
        Me.disc_days.EditInitialValue = Nothing
        Me.disc_days.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.disc_days.FieldDescription = ""
        Me.disc_days.FindInitialValue = Nothing
        Me.disc_days.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.disc_days.IgnoreRequiered = False
        Me.disc_days.Location = New System.Drawing.Point(128, 40)
        Me.disc_days.Name = "disc_days"
        Me.disc_days.NewInitialValue = Nothing
        Me.disc_days.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.disc_days.ReadOnly = True
        Me.disc_days.Requiered = False
        Me.disc_days.Size = New System.Drawing.Size(56, 20)
        Me.disc_days.StatusBarPanelDescripcion = Nothing
        Me.disc_days.TabIndex = 1
        Me.disc_days.TabStop = False
        Me.disc_days.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(11, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Días de descuento:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_term_code
        '
        Me.xlk_term_code.AlternateFieldSearch = Nothing
        Me.xlk_term_code.BeginCheck = False
        Me.xlk_term_code.CheckText = Nothing
        Me.xlk_term_code.ComboMode = False
        Me.xlk_term_code.DataMember = Nothing
        Me.xlk_term_code.DataSource = Me.LibXConnector1
        Me.xlk_term_code.DestParameters = New String() {"term_code=term_code", "term_name=term_name", "disc_days=disc_days", "due_days=due_days", "disc_pct=disc_pct"}
        Me.xlk_term_code.FilterField = "term_name"
        Me.xlk_term_code.IgnoreFindInBrowseMode = False
        Me.xlk_term_code.isCanceled = False
        Me.xlk_term_code.Location = New System.Drawing.Point(464, 16)
        Me.xlk_term_code.LookCaption = "Términos de Venta"
        Me.xlk_term_code.Name = "xlk_term_code"
        Me.xlk_term_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_term_code.ShowFilter = True
        Me.xlk_term_code.ShowMessageNotFound = True
        Me.xlk_term_code.ShowWarning = False
        Me.xlk_term_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_term_code.SizesColumns = Nothing
        Me.xlk_term_code.SizesColumnsTab = Nothing
        Me.xlk_term_code.SqlString = Nothing
        Me.xlk_term_code.SQLTab = Nothing
        Me.xlk_term_code.SrcParameters = New String() {"term_code=term_code"}
        Me.xlk_term_code.TabIndex = 4
        Me.xlk_term_code.TableName = "cctermm"
        Me.xlk_term_code.TabStop = False
        Me.xlk_term_code.UseCopyConnection = False
        Me.xlk_term_code.UseRowRetrieveEvents = False
        Me.xlk_term_code.UseTab = False
        Me.xlk_term_code.VisParameters = New String() {"Código=term_code", "Descripción=term_name", "% Descuento=disc_pct", "Días vencimiento=due_days", "Días Descuento=disc_days"}
        Me.xlk_term_code.WhereCondition = Nothing
        Me.xlk_term_code.WhereParameters = Nothing
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtcust_code)
        Me.GroupBox3.Controls.Add(Me.lnk_Cliente)
        Me.GroupBox3.Controls.Add(Me.xlk_cust_code)
        Me.GroupBox3.Controls.Add(Me.cust_name)
        Me.GroupBox3.Controls.Add(Me.balance)
        Me.GroupBox3.Controls.Add(Me.credit_limit)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Location = New System.Drawing.Point(8, 117)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(504, 72)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cliente"
        '
        'txtcust_code
        '
        Me.txtcust_code.AcceptsReturn = True
        Me.txtcust_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.cust_code"))
        Me.txtcust_code.EditInitialValue = Nothing
        Me.txtcust_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcust_code.FieldDescription = ""
        Me.txtcust_code.FindInitialValue = Nothing
        Me.txtcust_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcust_code.IgnoreRequiered = False
        Me.txtcust_code.Location = New System.Drawing.Point(128, 16)
        Me.txtcust_code.Name = "txtcust_code"
        Me.txtcust_code.NewInitialValue = Nothing
        Me.txtcust_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcust_code.Requiered = False
        Me.txtcust_code.Size = New System.Drawing.Size(56, 20)
        Me.txtcust_code.StatusBarPanelDescripcion = Nothing
        Me.txtcust_code.TabIndex = 0
        Me.txtcust_code.Text = ""
        '
        'lnk_Cliente
        '
        Me.lnk_Cliente.AutoSize = True
        Me.lnk_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lnk_Cliente.Location = New System.Drawing.Point(72, 16)
        Me.lnk_Cliente.Name = "lnk_Cliente"
        Me.lnk_Cliente.Size = New System.Drawing.Size(43, 16)
        Me.lnk_Cliente.TabIndex = 7
        Me.lnk_Cliente.TabStop = True
        Me.lnk_Cliente.Text = "Cliente:"
        Me.lnk_Cliente.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_cust_code
        '
        Me.xlk_cust_code.AlternateFieldSearch = Nothing
        Me.xlk_cust_code.BeginCheck = False
        Me.xlk_cust_code.CheckText = Nothing
        Me.xlk_cust_code.ComboMode = False
        Me.xlk_cust_code.DataMember = Nothing
        Me.xlk_cust_code.DataSource = Me.LibXConnector1
        Me.xlk_cust_code.DestParameters = New String() {"cust_code=cust_code", "cust_name=cust_name", "balance=balance", "credit_limit=credit_limit"}
        Me.xlk_cust_code.FilterField = ""
        Me.xlk_cust_code.IgnoreFindInBrowseMode = False
        Me.xlk_cust_code.isCanceled = False
        Me.xlk_cust_code.Location = New System.Drawing.Point(464, 16)
        Me.xlk_cust_code.LookCaption = "Clientes"
        Me.xlk_cust_code.Name = "xlk_cust_code"
        Me.xlk_cust_code.PopupSize = New System.Drawing.Size(800, 500)
        Me.xlk_cust_code.ShowFilter = True
        Me.xlk_cust_code.ShowMessageNotFound = True
        Me.xlk_cust_code.ShowWarning = False
        Me.xlk_cust_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_cust_code.SizesColumns = New String() {"cust_name=400"}
        Me.xlk_cust_code.SizesColumnsTab = Nothing
        Me.xlk_cust_code.SqlString = Nothing
        Me.xlk_cust_code.SQLTab = Nothing
        Me.xlk_cust_code.SrcParameters = New String() {"cust_code=cust_code"}
        Me.xlk_cust_code.TabIndex = 4
        Me.xlk_cust_code.TableName = "cccustm"
        Me.xlk_cust_code.TabStop = False
        Me.xlk_cust_code.UseCopyConnection = False
        Me.xlk_cust_code.UseRowRetrieveEvents = False
        Me.xlk_cust_code.UseTab = False
        Me.xlk_cust_code.VisParameters = New String() {"Código=cust_code", "Nombre=cust_name", "Limite Crédito=credit_limit", "Balance=balance"}
        Me.xlk_cust_code.WhereCondition = Nothing
        Me.xlk_cust_code.WhereParameters = Nothing
        '
        'cust_name
        '
        Me.cust_name.AcceptsReturn = True
        Me.cust_name.EditInitialValue = Nothing
        Me.cust_name.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.cust_name.FieldDescription = ""
        Me.cust_name.FindInitialValue = Nothing
        Me.cust_name.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.cust_name.IgnoreRequiered = False
        Me.cust_name.Location = New System.Drawing.Point(192, 16)
        Me.cust_name.Name = "cust_name"
        Me.cust_name.NewInitialValue = Nothing
        Me.cust_name.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.cust_name.ReadOnly = True
        Me.cust_name.Requiered = False
        Me.cust_name.Size = New System.Drawing.Size(272, 20)
        Me.cust_name.StatusBarPanelDescripcion = Nothing
        Me.cust_name.TabIndex = 1
        Me.cust_name.TabStop = False
        Me.cust_name.Text = ""
        '
        'balance
        '
        Me.balance.AcceptsReturn = True
        Me.balance.EditInitialValue = Nothing
        Me.balance.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.balance.FieldDescription = ""
        Me.balance.FindInitialValue = Nothing
        Me.balance.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.balance.IgnoreRequiered = False
        Me.balance.Location = New System.Drawing.Point(376, 40)
        Me.balance.Name = "balance"
        Me.balance.NewInitialValue = Nothing
        Me.balance.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.balance.ReadOnly = True
        Me.balance.Requiered = False
        Me.balance.Size = New System.Drawing.Size(104, 20)
        Me.balance.StatusBarPanelDescripcion = Nothing
        Me.balance.TabIndex = 1
        Me.balance.TabStop = False
        Me.balance.Text = ""
        Me.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'credit_limit
        '
        Me.credit_limit.AcceptsReturn = True
        Me.credit_limit.EditInitialValue = Nothing
        Me.credit_limit.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.credit_limit.FieldDescription = ""
        Me.credit_limit.FindInitialValue = Nothing
        Me.credit_limit.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.credit_limit.IgnoreRequiered = False
        Me.credit_limit.Location = New System.Drawing.Point(128, 40)
        Me.credit_limit.Name = "credit_limit"
        Me.credit_limit.NewInitialValue = Nothing
        Me.credit_limit.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.credit_limit.ReadOnly = True
        Me.credit_limit.Requiered = False
        Me.credit_limit.Size = New System.Drawing.Size(104, 20)
        Me.credit_limit.StatusBarPanelDescripcion = Nothing
        Me.credit_limit.TabIndex = 13
        Me.credit_limit.TabStop = False
        Me.credit_limit.Text = ""
        Me.credit_limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label18.Location = New System.Drawing.Point(288, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 16)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Balance Actual:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label20.Location = New System.Drawing.Point(40, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 16)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Limite Crédito:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(528, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 8)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.invce_ncf"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(136, 58)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(352, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 1
        Me.XTextBox2.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Location = New System.Drawing.Point(77, 58)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 16)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "N. C. F.:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_invce_status
        '
        Me.xcbo_invce_status.AllowDefaultSort = True
        Me.xcbo_invce_status.bound = True
        Me.xcbo_invce_status.currValue = Nothing
        Me.xcbo_invce_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ccinvcem.invce_status"))
        Me.xcbo_invce_status.DefaultWhereString = Nothing
        Me.xcbo_invce_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_invce_status.EditInitialValue = Nothing
        Me.xcbo_invce_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_invce_status.Enabled = False
        Me.xcbo_invce_status.FieldDescription = ""
        Me.xcbo_invce_status.FindInitialValue = Nothing
        Me.xcbo_invce_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_invce_status.IgnoreRequiered = False
        Me.xcbo_invce_status.Items.AddRange(New Object() {"0-Anulada", "1-Aplicada", "2-Pendiente de aplicar", "3-Saldado", "4-Transferido"})
        Me.xcbo_invce_status.Location = New System.Drawing.Point(624, 72)
        Me.xcbo_invce_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_invce_status.LookupKeyField = Nothing
        Me.xcbo_invce_status.LookupTableName = Nothing
        Me.xcbo_invce_status.Name = "xcbo_invce_status"
        Me.xcbo_invce_status.NewInitialValue = "2"
        Me.xcbo_invce_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_invce_status.Requiered = False
        Me.xcbo_invce_status.Required = False
        Me.xcbo_invce_status.Size = New System.Drawing.Size(112, 21)
        Me.xcbo_invce_status.SqlString = Nothing
        Me.xcbo_invce_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_invce_status.TabIndex = 8
        '
        'xdtp_invce_date
        '
        Me.xdtp_invce_date.CustomFormat = "dd/MM/yyyy"
        Me.xdtp_invce_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ccinvcem.invce_date"))
        Me.xdtp_invce_date.EditInitialValue = Nothing
        Me.xdtp_invce_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_invce_date.FieldDescription = ""
        Me.xdtp_invce_date.FindInitialValue = Nothing
        Me.xdtp_invce_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_invce_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdtp_invce_date.IgnoreRequiered = False
        Me.xdtp_invce_date.Location = New System.Drawing.Point(624, 48)
        Me.xdtp_invce_date.Name = "xdtp_invce_date"
        Me.xdtp_invce_date.NewInitialValue = "now"
        Me.xdtp_invce_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_invce_date.Requiered = True
        Me.xdtp_invce_date.Size = New System.Drawing.Size(112, 20)
        Me.xdtp_invce_date.StatusBarPanelDescripcion = Nothing
        Me.xdtp_invce_date.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(16, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Documento:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtinvce_no
        '
        Me.txtinvce_no.AcceptsReturn = True
        Me.txtinvce_no.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.invce_no"))
        Me.txtinvce_no.EditInitialValue = Nothing
        Me.txtinvce_no.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtinvce_no.FieldDescription = ""
        Me.txtinvce_no.FindInitialValue = Nothing
        Me.txtinvce_no.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtinvce_no.IgnoreRequiered = False
        Me.txtinvce_no.Location = New System.Drawing.Point(624, 24)
        Me.txtinvce_no.Name = "txtinvce_no"
        Me.txtinvce_no.NewInitialValue = Nothing
        Me.txtinvce_no.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtinvce_no.Requiered = False
        Me.txtinvce_no.Size = New System.Drawing.Size(112, 20)
        Me.txtinvce_no.StatusBarPanelDescripcion = Nothing
        Me.txtinvce_no.TabIndex = 6
        Me.txtinvce_no.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(562, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Número:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(571, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox8
        '
        Me.TextBox8.AcceptsReturn = True
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.detail"))
        Me.TextBox8.EditInitialValue = Nothing
        Me.TextBox8.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox8.FieldDescription = ""
        Me.TextBox8.FindInitialValue = Nothing
        Me.TextBox8.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox8.IgnoreRequiered = False
        Me.TextBox8.Location = New System.Drawing.Point(136, 309)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.NewInitialValue = Nothing
        Me.TextBox8.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox8.Requiered = False
        Me.TextBox8.Size = New System.Drawing.Size(376, 56)
        Me.TextBox8.StatusBarPanelDescripcion = Nothing
        Me.TextBox8.TabIndex = 5
        Me.TextBox8.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(80, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Detalle:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(541, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Monto Bruto:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txttotal_amount
        '
        Me.txttotal_amount.AcceptsReturn = True
        Me.txttotal_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.amount"))
        Me.txttotal_amount.EditInitialValue = Nothing
        Me.txttotal_amount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txttotal_amount.FieldDescription = ""
        Me.txttotal_amount.FindInitialValue = Nothing
        Me.txttotal_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txttotal_amount.IgnoreRequiered = False
        Me.txttotal_amount.Location = New System.Drawing.Point(624, 120)
        Me.txttotal_amount.Name = "txttotal_amount"
        Me.txttotal_amount.NewInitialValue = Nothing
        Me.txttotal_amount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txttotal_amount.Requiered = False
        Me.txttotal_amount.Size = New System.Drawing.Size(112, 20)
        Me.txttotal_amount.StatusBarPanelDescripcion = Nothing
        Me.txttotal_amount.TabIndex = 9
        Me.txttotal_amount.Text = ""
        Me.txttotal_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(565, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Estatus:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtitbis
        '
        Me.txtitbis.AcceptsReturn = True
        Me.txtitbis.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.itbis"))
        Me.txtitbis.EditInitialValue = Nothing
        Me.txtitbis.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtitbis.FieldDescription = ""
        Me.txtitbis.FindInitialValue = Nothing
        Me.txtitbis.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtitbis.IgnoreRequiered = False
        Me.txtitbis.Location = New System.Drawing.Point(624, 168)
        Me.txtitbis.Name = "txtitbis"
        Me.txtitbis.NewInitialValue = Nothing
        Me.txtitbis.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtitbis.Requiered = False
        Me.txtitbis.Size = New System.Drawing.Size(112, 20)
        Me.txtitbis.StatusBarPanelDescripcion = Nothing
        Me.txtitbis.TabIndex = 11
        Me.txtitbis.Text = ""
        Me.txtitbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(582, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Itbis:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtamount
        '
        Me.txtamount.AcceptsReturn = True
        Me.txtamount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.total_amount"))
        Me.txtamount.EditInitialValue = Nothing
        Me.txtamount.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtamount.FieldDescription = ""
        Me.txtamount.FindInitialValue = Nothing
        Me.txtamount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.IgnoreRequiered = False
        Me.txtamount.Location = New System.Drawing.Point(624, 208)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.NewInitialValue = Nothing
        Me.txtamount.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtamount.ReadOnly = True
        Me.txtamount.Requiered = False
        Me.txtamount.Size = New System.Drawing.Size(112, 20)
        Me.txtamount.StatusBarPanelDescripcion = Nothing
        Me.txtamount.TabIndex = 1
        Me.txtamount.TabStop = False
        Me.txtamount.Text = ""
        Me.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(544, 208)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Monto Neto:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Location = New System.Drawing.Point(527, 248)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Monto Excento:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtExcento
        '
        Me.txtExcento.AcceptsReturn = True
        Me.txtExcento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.excento"))
        Me.txtExcento.EditInitialValue = Nothing
        Me.txtExcento.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtExcento.FieldDescription = ""
        Me.txtExcento.FindInitialValue = Nothing
        Me.txtExcento.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtExcento.IgnoreRequiered = False
        Me.txtExcento.Location = New System.Drawing.Point(624, 248)
        Me.txtExcento.Name = "txtExcento"
        Me.txtExcento.NewInitialValue = Nothing
        Me.txtExcento.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtExcento.ReadOnly = True
        Me.txtExcento.Requiered = False
        Me.txtExcento.Size = New System.Drawing.Size(112, 20)
        Me.txtExcento.StatusBarPanelDescripcion = Nothing
        Me.txtExcento.TabIndex = 1
        Me.txtExcento.TabStop = False
        Me.txtExcento.Text = ""
        Me.txtExcento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Location = New System.Drawing.Point(524, 272)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Monto Grabado:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtGrabado
        '
        Me.txtGrabado.AcceptsReturn = True
        Me.txtGrabado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.impto"))
        Me.txtGrabado.EditInitialValue = Nothing
        Me.txtGrabado.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtGrabado.FieldDescription = ""
        Me.txtGrabado.FindInitialValue = Nothing
        Me.txtGrabado.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtGrabado.IgnoreRequiered = False
        Me.txtGrabado.Location = New System.Drawing.Point(624, 272)
        Me.txtGrabado.Name = "txtGrabado"
        Me.txtGrabado.NewInitialValue = Nothing
        Me.txtGrabado.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtGrabado.ReadOnly = True
        Me.txtGrabado.Requiered = False
        Me.txtGrabado.Size = New System.Drawing.Size(112, 20)
        Me.txtGrabado.StatusBarPanelDescripcion = Nothing
        Me.txtGrabado.TabIndex = 1
        Me.txtGrabado.TabStop = False
        Me.txtGrabado.Text = ""
        Me.txtGrabado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtvend_code
        '
        Me.txtvend_code.AcceptsReturn = True
        Me.txtvend_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.vend_code"))
        Me.txtvend_code.EditInitialValue = Nothing
        Me.txtvend_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtvend_code.FieldDescription = ""
        Me.txtvend_code.FindInitialValue = Nothing
        Me.txtvend_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtvend_code.IgnoreRequiered = False
        Me.txtvend_code.Location = New System.Drawing.Point(136, 82)
        Me.txtvend_code.Name = "txtvend_code"
        Me.txtvend_code.NewInitialValue = Nothing
        Me.txtvend_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtvend_code.Requiered = False
        Me.txtvend_code.Size = New System.Drawing.Size(56, 20)
        Me.txtvend_code.StatusBarPanelDescripcion = Nothing
        Me.txtvend_code.TabIndex = 2
        Me.txtvend_code.Text = ""
        '
        'vend_name
        '
        Me.vend_name.AcceptsReturn = True
        Me.vend_name.EditInitialValue = Nothing
        Me.vend_name.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.vend_name.FieldDescription = ""
        Me.vend_name.FindInitialValue = Nothing
        Me.vend_name.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.vend_name.IgnoreRequiered = False
        Me.vend_name.Location = New System.Drawing.Point(200, 82)
        Me.vend_name.Name = "vend_name"
        Me.vend_name.NewInitialValue = Nothing
        Me.vend_name.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.vend_name.ReadOnly = True
        Me.vend_name.Requiered = False
        Me.vend_name.Size = New System.Drawing.Size(272, 20)
        Me.vend_name.StatusBarPanelDescripcion = Nothing
        Me.vend_name.TabIndex = 1
        Me.vend_name.TabStop = False
        Me.vend_name.Text = ""
        '
        'xlk_vend_code
        '
        Me.xlk_vend_code.AlternateFieldSearch = Nothing
        Me.xlk_vend_code.BeginCheck = False
        Me.xlk_vend_code.CheckText = Nothing
        Me.xlk_vend_code.ComboMode = False
        Me.xlk_vend_code.DataMember = Nothing
        Me.xlk_vend_code.DataSource = Me.LibXConnector1
        Me.xlk_vend_code.DestParameters = New String() {"txtvend_code=vend_code", "vend_name=vend_name"}
        Me.xlk_vend_code.FilterField = ""
        Me.xlk_vend_code.IgnoreFindInBrowseMode = False
        Me.xlk_vend_code.isCanceled = False
        Me.xlk_vend_code.Location = New System.Drawing.Point(472, 82)
        Me.xlk_vend_code.LookCaption = "Vendedores"
        Me.xlk_vend_code.Name = "xlk_vend_code"
        Me.xlk_vend_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_vend_code.ShowFilter = True
        Me.xlk_vend_code.ShowMessageNotFound = True
        Me.xlk_vend_code.ShowWarning = False
        Me.xlk_vend_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_vend_code.SizesColumns = Nothing
        Me.xlk_vend_code.SizesColumnsTab = Nothing
        Me.xlk_vend_code.SqlString = Nothing
        Me.xlk_vend_code.SQLTab = Nothing
        Me.xlk_vend_code.SrcParameters = New String() {"vend_code=vend_code"}
        Me.xlk_vend_code.TabIndex = 4
        Me.xlk_vend_code.TableName = "ftvendm"
        Me.xlk_vend_code.TabStop = False
        Me.xlk_vend_code.UseCopyConnection = False
        Me.xlk_vend_code.UseRowRetrieveEvents = False
        Me.xlk_vend_code.UseTab = False
        Me.xlk_vend_code.VisParameters = New String() {"Código=vend_code", "Nombre=vend_name"}
        Me.xlk_vend_code.WhereCondition = Nothing
        Me.xlk_vend_code.WhereParameters = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(67, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Vendedor:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label19.Location = New System.Drawing.Point(549, 144)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 16)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Descuento:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtdescuento
        '
        Me.txtdescuento.AcceptsReturn = True
        Me.txtdescuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.cargo_desc"))
        Me.txtdescuento.EditInitialValue = Nothing
        Me.txtdescuento.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtdescuento.FieldDescription = ""
        Me.txtdescuento.FindInitialValue = Nothing
        Me.txtdescuento.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtdescuento.IgnoreRequiered = False
        Me.txtdescuento.Location = New System.Drawing.Point(624, 144)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.NewInitialValue = Nothing
        Me.txtdescuento.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtdescuento.Requiered = False
        Me.txtdescuento.Size = New System.Drawing.Size(112, 20)
        Me.txtdescuento.StatusBarPanelDescripcion = Nothing
        Me.txtdescuento.TabIndex = 10
        Me.txtdescuento.Text = ""
        Me.txtdescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(770, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'btnDetalle
        '
        Me.btnDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDetalle.Location = New System.Drawing.Point(88, 435)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.TabIndex = 3
        Me.btnDetalle.Text = "Detalle"
        '
        'btnTermino
        '
        Me.btnTermino.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTermino.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTermino.Location = New System.Drawing.Point(8, 435)
        Me.btnTermino.Name = "btnTermino"
        Me.btnTermino.TabIndex = 2
        Me.btnTermino.Text = "Términos"
        '
        'btnMov
        '
        Me.btnMov.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMov.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMov.Location = New System.Drawing.Point(168, 435)
        Me.btnMov.Name = "btnMov"
        Me.btnMov.TabIndex = 4
        Me.btnMov.Text = "Movimientos"
        '
        'i_ccinvce01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(770, 472)
        Me.Controls.Add(Me.btnMov)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnTermino)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ccinvce01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Movimientos de cuenta x cobrar"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccinvcem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Function NumeroDocumento(ByVal type_code, ByVal nodocumento) As Integer
        Dim SelectStmt As String
        Dim NumberDoc As Integer

        Try
            If type_code = "" Then
                Exit Function
            End If

            SelectStmt = "select isnull(ccinvcem.invce_no,0) " & _
                         " from ccinvcem " & _
                         " where ccinvcem.type_code = '" & type_code.Trim & "'" & _
                         " and  ccinvcem.invce_no = '" & nodocumento.Trim & "'"

            NumberDoc = LibX.Data.Manager.GetScalar(SelectStmt)

            Return NumberDoc
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Function

    Public Function CalcularItbis(ByVal Amount) As Decimal
        Dim itbis As Decimal
        Dim porc_itbis As Decimal
        Try
            '// Porciento de itbis
            porc_itbis = Conf.GetITBIS
            itbis = Amount * (porc_itbis / 100)

            Return itbis
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Function

    Private Sub xlk_type_code_BeforeExecuteQuery(ByVal sender As System.Object, ByVal e As LibX.BeforeExecuteQueryEventArgs)
        Try
            e.aditionalWhere = "apply_cxc = 1 and type_code in ('FCT','NCC','NDC','FCT','CDC','CSC') "

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub xlk_term_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_term_code.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.IsDataEditing = True Then
                If Val(e.row!due_days.ToString) > 0 AndAlso xdtp_invce_date.Value.ToString.Length > 0 Then
                    xdtp_due_date.Value = CType(xdtp_invce_date.Value, Date).AddDays(Val(e.row!due_days.ToString))
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            '// SI ESTA INSERTANDO DOCUMENTOS
            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then
                e.UpdatingArgs.Row!suc_code = ScDefault
                e.UpdatingArgs.Row!invce_create = LibX.Data.Manager.GetScalar("select getdate()")
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub TextBox10_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txttotal_amount.Validating
        Try
            If LibXConnector1.IsDataEditing = True Then
                CalcularNeto()
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
            e.Cancel = True
        End Try
    End Sub

    Private Sub CalcularNeto()
        Dim TotalAmount As Decimal
        Dim ItbisAmount As Decimal
        Dim Amount As Decimal
        Dim porcItbis As Decimal
        Dim DescAmount As Decimal
        Dim ExcentoAmount As Decimal
        Dim GrabadoAmount As Decimal

        Try

            If txttotal_amount.Text.Trim <> "" Then TotalAmount = CDbl(txttotal_amount.Text.Trim)
            If txtitbis.Text.Trim <> "" Then ItbisAmount = CDbl(txtitbis.Text.Trim)
            If txtdescuento.Text.Trim <> "" Then DescAmount = CDbl(txtdescuento.Text.Trim)

            If DescAmount > TotalAmount Then
                Throw New ApplicationException("El descuento debe ser menor que el monto!")
            End If

            Amount = (TotalAmount - DescAmount) + ItbisAmount

            porcItbis = Conf.GetITBIS

            GrabadoAmount = ItbisAmount / (porcItbis / 100)

            ExcentoAmount = (TotalAmount - DescAmount) - GrabadoAmount

            txtamount.Text = Format(Amount, "##,###,##0.00")
            txtExcento.Text = Format(ExcentoAmount, "##,###,##0.00")
            txtGrabado.Text = Format(GrabadoAmount, "##,###,##0.00")

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub CalculaVencimiento()
        Try
            If xdtp_invce_date.Value Is System.DBNull.Value Then
                Exit Sub
            End If

            If due_days.Text = "" Then
                Exit Sub
            End If

            xdtp_due_date.Value = DateAdd(DateInterval.Day, Val(due_days.Text), xdtp_invce_date.Value)
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub txtitbis_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtitbis.Validating
        Dim Descuento As Decimal
        Dim Monto As Decimal
        Dim Itbis As Decimal
        Try

            If LibXConnector1.IsDataEditing = True Then
                If txtitbis.Text = "" Then
                    Exit Sub
                End If

                If Me.txtdescuento.Text.Trim <> "" Then Descuento = CDbl(Me.txtdescuento.Text.Trim)
                If Me.txttotal_amount.Text.Trim <> "" Then Monto = CDbl(Me.txttotal_amount.Text.Trim)
                If Me.txtitbis.Text.Trim <> "" Then Itbis = CDbl(Me.txtitbis.Text.Trim)

                If Itbis > CalcularItbis(Monto - Descuento) Then
                    txtitbis.Text = ""
                    Throw New ApplicationException(" El ITBIS digitado no debe ser mayor al ITBIS permitido ! ")
                End If

                CalcularNeto()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
            e.Cancel = True
        End Try
    End Sub
    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibX.LibxConnectionActions.Find Then
                Me.xcbo_invce_status.currValue = 2
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub xlk_cust_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_cust_code.AfterSetValues
        Try

            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.IsDataEditing = True Then
                txtterm_code.Text = e.row!term_code.ToString
                xlk_term_code.ExecuteFind()
                CalculaVencimiento()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub btnTermino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTermino.Click
        Dim oParam As LibX.LibxPrgParams
        Try
            Me.Cursor = Cursors.WaitCursor
            LibX.LibXRunner.Run("i_ccterm01", "CXC", True)
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams
            With oParam
                .IsFromOther = True
                .Value = ""
                .WhereToExecute = "ftfactm.fact_number = " & LibXConnector1.CurrentDataRow!invce_no.ToString & _
                                                        " and ftfactm.type_code = '" & LibXConnector1.CurrentDataRow!type_code.ToString.Trim & "'"
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowPrint = True
                .AllowQuery = False
            End With

            LibX.App.CurrentPrgParams = oParam

            Me.Cursor = Cursors.WaitCursor

            If LibXConnector1.CurrentDataRow!type_code.ToString.Trim = "FCT" Then
                LibX.LibXRunner.Run("i_ftfact01", "FCT", True)
            Else
                LibX.LibXRunner.Run("i_ptvfact01", "FPV", True)
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub btnMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMov.Click
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams
            With oParam
                .IsFromOther = True
                .Value = ""
                .WhereToExecute = "ccinvcem.invce_serial = " & LibXConnector1.CurrentDataRow!invce_serial.ToString
            End With

            LibX.App.CurrentPrgParams = oParam

            Me.Cursor = Cursors.WaitCursor
            LibX.LibXRunner.Run("c_ccdocs01", "CXC", True)
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try
            btnDetalle.Enabled = Not e.isDataEditing And LibXConnector1.HasRecords
            btnMov.Enabled = Not e.isDataEditing And LibXConnector1.HasRecords
            If e.action = LibX.LibxConnectionActions.Add Then
                txtamount.Text = String.Empty
                Me.XTextBox1.Text = FindSucursal()
                Me.LibXLookup1.ExecuteFind()
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub lnk_Cliente_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnk_Cliente.LinkClicked
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams
            With oParam
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowPrint = True
                .AllowQuery = False
                .IsFromOther = True
                .Value = ""
                .WhereToExecute = "cccustm.cust_code = " & LibXConnector1.CurrentDataRow!cust_code.ToString
            End With

            LibX.App.CurrentPrgParams = oParam

            Me.Cursor = Cursors.WaitCursor
            LibX.LibXRunner.Run("i_custrm01", "CXC", True)
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xdtp_invce_date_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xdtp_invce_date.Validating
        Try
            If LibXConnector1.IsDataEditing = True Then
                CalculaVencimiento()
            End If
        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub txtdescuento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtdescuento.Validating
        Try
            If LibXConnector1.IsDataEditing = True Then
                CalcularNeto()
            End If
        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        If LibXConnector1.HasRecords = True Then
            If e.row!invce_status.ToString.Trim <> "2" Then  'APLICADA
                LibXConnector1.AllowEdit = False
                LibXConnector1.AllowDelete = False
            Else
                LibXConnector1.AllowEdit = True
                LibXConnector1.AllowDelete = True
            End If
            LibXNavigator1.UpdateState()
        End If
    End Sub

    Private Sub txtinvce_no_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtinvce_no.Validating
        Try
            If LibXConnector1.IsDataEditing = True Then
                If Not txtinvce_no.Text.Trim = "" Then
                    If NumeroDocumento(xcbo_type_code.currValue, txtinvce_no.Text) = Val(txtinvce_no.Text) Then
                        txtinvce_no.Text = ""
                        Throw New ApplicationException("Este Numero de documento ya existe para este tipo de documento! ")
                    End If
                End If
            End If

        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXNavigator1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibXNavigator1.Load
        Conf = New SGT.Inventario.Common.Configuration
        ScDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibXScDefault").ToString)
        Transf = CType(System.Configuration.ConfigurationSettings.AppSettings.Get("LibxTransfCXC"), Boolean)
        If Transf = False Then
            btnTransf.Enabled = False
            btnTransf.Visible = False
        End If
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try
            Me.xcbo_type_code.Focus()
            Me.XTextBox1.Text = FindSucursal()
            Me.LibXLookup1.ExecuteFind()
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub txtitbis_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtitbis.GotFocus
        Dim Descuento As Decimal
        Dim Monto As Decimal
        Dim Itbis As Decimal

        Try
            If LibXConnector1.IsDataEditing = True Then
                If Me.txtitbis.Text.Trim = "" Then
                    If Me.txtdescuento.Text.Trim <> "" Then Descuento = CDbl(Me.txtdescuento.Text.Trim)
                    If Me.txttotal_amount.Text.Trim <> "" Then Monto = CDbl(Me.txttotal_amount.Text.Trim)
                    If Me.txtitbis.Text.Trim <> "" Then Itbis = CDbl(Me.txtitbis.Text.Trim)

                    Me.txtitbis.Text = CalcularItbis(Monto - Descuento)
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub btnTransf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransf.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            EnviarVentas()
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub EnviarVentas()
        Dim wsSGF1 As WSSGF1.WSSGF1

        Dim oDataSet As DataSet
        Dim oTableccinvcem As DataTable
        Dim oTableccinvcem1 As DataTable
        Dim Odesc As Decimal
        Dim oRemote As DataTable
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim mLastDate As DateTime

        Try
            '// ccimvcem
            oTableccinvcem = LibX.Data.Manager.GetDataTable("select * from ccinvcem where invce_status not in(0,3) and cust_code " & _
                                                            "in(select cust_code from cccustm where web_transf = 1) and type_code in('FPV','FSG','FCT')")

            If oTableccinvcem.Rows.Count <= 0 Then
                Throw New ApplicationException("No hay informaciones pendiente de transferir")
            End If

            For Each oRow1 As DataRow In oTableccinvcem.Rows
                oTableccinvcem1 = LibX.Data.Manager.GetDataTable("select * from ccinvcem where invce_serial = " & oRow1!invce_serial)

                oTableccinvcem1.TableName = "ccinvcem"

                '// DataSet
                oDataSet = New DataSet("dsSGF1")

                '// Tablas
                ''oTableccinvcem1.Rows(0)!cargo_desc = LibX.Data.Manager.GetScalar("select isnull(disc_balance,0) from ccopend where invce_serial = " & oRow1!invce_serial)
                oTableccinvcem1.Rows(0)!type_code = "FCT"

                oDataSet.Tables.Add(oTableccinvcem1)

                wsSGF1 = New WSSGF1.WSSGF1

                oRemote = LibX.Data.Manager.GetDataTable("select * from scremote where estatus = 1")

                If oRemote Is Nothing Then
                    Throw New ApplicationException("No hay estaciones remotas configuradas!")
                End If

                If oRemote.Rows.Count <= 0 Then
                    Throw New ApplicationException("No hay estaciones remotas configuradas!")
                End If

                For Each oRow As DataRow In oRemote.Rows
                    wsSGF1.Url = oRow!url.ToString.Trim
                    wsSGF1.Credentials = System.Net.CredentialCache.DefaultCredentials

                    If wsSGF1.InsertarVentas(oDataSet) Then
                    End If
                Next
                mLastDate = LibX.Data.Manager.GetScalar("select getdate()")
                xUpdate = New LibX.Data.XUpdateStmt("ccinvcem")
                xUpdate.FieldsSet("invce_status") = 3
                xUpdate.Fields("invce_serial") = oRow1!invce_serial
                xUpdate.Fields("suc_code") = oRow1!suc_code
                xUpdate.Execute()

                xUpdate = New LibX.Data.XUpdateStmt("ccopend")
                xUpdate.FieldsSet("balance") = 0
                xUpdate.FieldsSet("last_pay_date") = mLastDate
                xUpdate.Fields("invce_serial") = oRow1!invce_serial
                xUpdate.Fields("suc_code") = oRow1!suc_code
                xUpdate.Execute()

                xUpdate = New LibX.Data.XUpdateStmt("cccustm")
                xUpdate.FieldsSet("balance") = 0
                xUpdate.Fields("cust_code") = oRow1!cust_code
                xUpdate.Execute()
            Next

        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Function FindSucursal() As Integer
        Dim oSucursal As Integer
        Dim SelectStmt As String

        SelectStmt = "select suc_code from cgsucursal where suc_default = 1 "
        oSucursal = LibX.Data.Manager.GetScalar(SelectStmt)

        Return oSucursal
    End Function

    Private Sub xdtp_invce_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xdtp_invce_date.ValueChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                If xdtp_invce_date.Value > LibX.Data.Manager.GetScalar("select getdate()") Then
                    xdtp_invce_date.Value = LibX.Data.Manager.GetScalar("select getdate()")
                    Throw New ApplicationException("la fecha no debe ser mayor que la fecha del dia!")
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class
