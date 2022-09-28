Public Class i_cgconf01
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
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents LibxCXC As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents LibXLookup4 As LibX.LibXLookup
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents lblacct_utilidades As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents TextBox27 As LibX.XTextBox
    Friend WithEvents lblacct_anticipos As System.Windows.Forms.Label
    Friend WithEvents TextBox28 As LibX.XTextBox
    Friend WithEvents lblacct_superavit As System.Windows.Forms.Label
    Friend WithEvents lblacct_utilidades_ant As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As LibX.XTextBox
    Friend WithEvents TextBox2 As LibX.XTextBox
    Friend WithEvents lblacct_retenciones As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LibXLookup5 As LibX.LibXLookup
    Friend WithEvents xlk_cuenta_cargo As LibX.LibXLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As LibX.XTextBox
    Friend WithEvents lblacct_cargo_name As System.Windows.Forms.Label
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents xtxt_acct_utilidades As LibX.XTextBox
    Friend WithEvents xlk_acct_utilidades_ant As LibX.LibXLookup
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibxCXC = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.xtxt_acct_utilidades = New LibX.XTextBox
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXLookup4 = New LibX.LibXLookup
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.xlk_acct_utilidades_ant = New LibX.LibXLookup
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.lblacct_utilidades = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.TextBox27 = New LibX.XTextBox
        Me.lblacct_anticipos = New System.Windows.Forms.Label
        Me.TextBox28 = New LibX.XTextBox
        Me.lblacct_superavit = New System.Windows.Forms.Label
        Me.lblacct_utilidades_ant = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New LibX.XTextBox
        Me.TextBox2 = New LibX.XTextBox
        Me.lblacct_retenciones = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXLookup5 = New LibX.LibXLookup
        Me.xlk_cuenta_cargo = New LibX.LibXLookup
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox3 = New LibX.XTextBox
        Me.lblacct_cargo_name = New System.Windows.Forms.Label
        CType(Me.LibxCXC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibxCXC
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_acct_utilidades
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_acct_utilidades
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_acct_utilidades
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(690, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'LibxCXC
        '
        Me.LibxCXC.AllowDelete = False
        Me.LibxCXC.AllowEdit = True
        Me.LibxCXC.AllowNew = True
        Me.LibxCXC.AllowPrint = True
        Me.LibxCXC.AllowQuery = True
        Me.LibxCXC.BOF = False
        Me.LibxCXC.CanExecuteFind = True
        Me.LibxCXC.DataMember = "cgconfm"
        Me.LibxCXC.DataSource = Me.DataSet1
        Me.LibxCXC.EOF = False
        Me.LibxCXC.HandledRowsFill = False
        Me.LibxCXC.HandledUpdates = False
        Me.LibxCXC.HasRecords = False
        Me.LibxCXC.IsEditing = False
        Me.LibxCXC.IsHeaderOnGrid = False
        Me.LibxCXC.ModuleName = ""
        Me.LibxCXC.OwnerForm = Me
        Me.LibxCXC.Parameters = Nothing
        Me.LibxCXC.RecordCount = 0
        Me.LibxCXC.ReportMode = False
        Me.LibxCXC.ReportName = ""
        Me.LibxCXC.ReportObject = Nothing
        Me.LibxCXC.RequeryData = False
        Me.LibxCXC.ShowWarningCancel = True
        Me.LibxCXC.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1})
        Me.LibxCXC.State = LibX.LibxConnectorState.none
        Me.LibxCXC.UpdatePrimaryKeyColumns = False
        Me.LibxCXC.UseTransactions = True
        '
        'DataSet1
        '
        Me.LibxCXC.SetDataGenerator(Me.DataSet1, Me.LibxCXC)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibxCXC.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn1})
        Me.DataTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"conf_serial"}, True)})
        Me.DataTable2.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn10}
        Me.DataTable2.TableName = "cgconfm"
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.AutoIncrement = True
        Me.DataColumn10.ColumnName = "conf_serial"
        Me.DataColumn10.DataType = GetType(System.Int32)
        Me.DataColumn10.ReadOnly = True
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "acct_utilidades"
        Me.DataColumn11.MaxLength = 10
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "acct_superavit"
        Me.DataColumn12.MaxLength = 10
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "acct_anticipos"
        Me.DataColumn13.MaxLength = 10
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "acct_utilidades_ant"
        Me.DataColumn14.MaxLength = 10
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "acct_retenciones"
        Me.DataColumn15.MaxLength = 10
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "acct_cargos"
        Me.DataColumn1.MaxLength = 18
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
        Me.LibXDbSourceTable1.SerialColumnName = "conf_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cgconfm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'xtxt_acct_utilidades
        '
        Me.xtxt_acct_utilidades.AcceptsReturn = True
        Me.xtxt_acct_utilidades.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgconfm.acct_utilidades"))
        Me.xtxt_acct_utilidades.EditInitialValue = Nothing
        Me.xtxt_acct_utilidades.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_acct_utilidades.FieldDescription = ""
        Me.xtxt_acct_utilidades.FindInitialValue = Nothing
        Me.xtxt_acct_utilidades.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_acct_utilidades.IgnoreRequiered = False
        Me.xtxt_acct_utilidades.Location = New System.Drawing.Point(129, 24)
        Me.xtxt_acct_utilidades.Name = "xtxt_acct_utilidades"
        Me.xtxt_acct_utilidades.NewInitialValue = Nothing
        Me.xtxt_acct_utilidades.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_acct_utilidades.Requiered = False
        Me.xtxt_acct_utilidades.Size = New System.Drawing.Size(128, 20)
        Me.xtxt_acct_utilidades.StatusBarPanelDescripcion = Nothing
        Me.xtxt_acct_utilidades.TabIndex = 0
        Me.xtxt_acct_utilidades.Text = ""
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
        Me.LibXDbSourceTable3.SerialColumnName = "conf_serial"
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = Nothing
        Me.LibXDbSourceTable3.TableName = "cgcpcnfm"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
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
        Me.LibXDbSourceTable2.FillOnRowChange = False
        Me.LibXDbSourceTable2.HeaderIsOnGrid = False
        Me.LibXDbSourceTable2.InnerJon = True
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = False
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = Nothing
        Me.LibXDbSourceTable2.TableName = "cgcpcnfm"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'LibXLookup4
        '
        Me.LibXLookup4.AlternateFieldSearch = Nothing
        Me.LibXLookup4.BeginCheck = False
        Me.LibXLookup4.CheckText = Nothing
        Me.LibXLookup4.ComboMode = False
        Me.LibXLookup4.DataMember = Nothing
        Me.LibXLookup4.DataSource = Me.LibxCXC
        Me.LibXLookup4.DestParameters = New String() {"acct_superavit=acct_no", "lblacct_superavit=acct_name"}
        Me.LibXLookup4.FilterField = "acct_name"
        Me.LibXLookup4.IgnoreFindInBrowseMode = False
        Me.LibXLookup4.isCanceled = False
        Me.LibXLookup4.Location = New System.Drawing.Point(583, 96)
        Me.LibXLookup4.LookCaption = Nothing
        Me.LibXLookup4.Name = "LibXLookup4"
        Me.LibXLookup4.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup4.ShowFilter = True
        Me.LibXLookup4.ShowMessageNotFound = True
        Me.LibXLookup4.ShowWarning = False
        Me.LibXLookup4.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup4.SizesColumns = Nothing
        Me.LibXLookup4.SizesColumnsTab = Nothing
        Me.LibXLookup4.SqlString = Nothing
        Me.LibXLookup4.SQLTab = Nothing
        Me.LibXLookup4.SrcParameters = New String() {"acct_superavit=acct_no"}
        Me.LibXLookup4.TabIndex = 58
        Me.LibXLookup4.TableName = "cgacctm"
        Me.LibXLookup4.TabStop = False
        Me.LibXLookup4.UseCopyConnection = False
        Me.LibXLookup4.UseRowRetrieveEvents = False
        Me.LibXLookup4.UseTab = False
        Me.LibXLookup4.VisParameters = New String() {"Cuenta Numero=acct_no", "Nombre Cuenta=acct_name"}
        Me.LibXLookup4.WhereCondition = Nothing
        Me.LibXLookup4.WhereParameters = Nothing
        '
        'LibXLookup3
        '
        Me.LibXLookup3.AlternateFieldSearch = Nothing
        Me.LibXLookup3.BeginCheck = False
        Me.LibXLookup3.CheckText = Nothing
        Me.LibXLookup3.ComboMode = False
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Me.LibxCXC
        Me.LibXLookup3.DestParameters = New String() {"acct_anticipos=acct_no", "lblacct_anticipos=acct_name"}
        Me.LibXLookup3.FilterField = "acct_name"
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.isCanceled = False
        Me.LibXLookup3.Location = New System.Drawing.Point(583, 72)
        Me.LibXLookup3.LookCaption = Nothing
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
        Me.LibXLookup3.SrcParameters = New String() {"acct_anticipos=acct_no"}
        Me.LibXLookup3.TabIndex = 57
        Me.LibXLookup3.TableName = "cgacctm"
        Me.LibXLookup3.TabStop = False
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.UseTab = False
        Me.LibXLookup3.VisParameters = New String() {"Cuenta Numero=acct_no", "Nombre Cuenta=acct_name"}
        Me.LibXLookup3.WhereCondition = Nothing
        Me.LibXLookup3.WhereParameters = Nothing
        '
        'xlk_acct_utilidades_ant
        '
        Me.xlk_acct_utilidades_ant.AlternateFieldSearch = Nothing
        Me.xlk_acct_utilidades_ant.BeginCheck = False
        Me.xlk_acct_utilidades_ant.CheckText = Nothing
        Me.xlk_acct_utilidades_ant.ComboMode = False
        Me.xlk_acct_utilidades_ant.DataMember = Nothing
        Me.xlk_acct_utilidades_ant.DataSource = Me.LibxCXC
        Me.xlk_acct_utilidades_ant.DestParameters = New String() {"acct_utilidades_ant=acct_no", "lblacct_utilidades_ant=acct_name"}
        Me.xlk_acct_utilidades_ant.FilterField = "acct_name"
        Me.xlk_acct_utilidades_ant.IgnoreFindInBrowseMode = False
        Me.xlk_acct_utilidades_ant.isCanceled = False
        Me.xlk_acct_utilidades_ant.Location = New System.Drawing.Point(583, 48)
        Me.xlk_acct_utilidades_ant.LookCaption = Nothing
        Me.xlk_acct_utilidades_ant.Name = "xlk_acct_utilidades_ant"
        Me.xlk_acct_utilidades_ant.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_acct_utilidades_ant.ShowFilter = True
        Me.xlk_acct_utilidades_ant.ShowMessageNotFound = True
        Me.xlk_acct_utilidades_ant.ShowWarning = False
        Me.xlk_acct_utilidades_ant.Size = New System.Drawing.Size(16, 20)
        Me.xlk_acct_utilidades_ant.SizesColumns = Nothing
        Me.xlk_acct_utilidades_ant.SizesColumnsTab = Nothing
        Me.xlk_acct_utilidades_ant.SqlString = Nothing
        Me.xlk_acct_utilidades_ant.SQLTab = Nothing
        Me.xlk_acct_utilidades_ant.SrcParameters = New String() {"acct_utilidades_ant=acct_no"}
        Me.xlk_acct_utilidades_ant.TabIndex = 56
        Me.xlk_acct_utilidades_ant.TableName = "cgacctm"
        Me.xlk_acct_utilidades_ant.TabStop = False
        Me.xlk_acct_utilidades_ant.UseCopyConnection = False
        Me.xlk_acct_utilidades_ant.UseRowRetrieveEvents = False
        Me.xlk_acct_utilidades_ant.UseTab = False
        Me.xlk_acct_utilidades_ant.VisParameters = New String() {"Cuenta Numero=acct_no", "Nombre Cuenta=acct_name"}
        Me.xlk_acct_utilidades_ant.WhereCondition = Nothing
        Me.xlk_acct_utilidades_ant.WhereParameters = Nothing
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibxCXC
        Me.LibXLookup1.DestParameters = New String() {"acct_utilidades=acct_no", "lblacct_utilidades=acct_name"}
        Me.LibXLookup1.FilterField = "acct_name"
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(583, 24)
        Me.LibXLookup1.LookCaption = Nothing
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
        Me.LibXLookup1.SrcParameters = New String() {"acct_utilidades=acct_no"}
        Me.LibXLookup1.TabIndex = 55
        Me.LibXLookup1.TableName = "cgacctm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Cuenta Numero=acct_no", "Nombre Cuenta=acct_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'lblacct_utilidades
        '
        Me.lblacct_utilidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblacct_utilidades.Location = New System.Drawing.Point(262, 24)
        Me.lblacct_utilidades.Name = "lblacct_utilidades"
        Me.lblacct_utilidades.Size = New System.Drawing.Size(320, 20)
        Me.lblacct_utilidades.TabIndex = 47
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(62, 80)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(53, 16)
        Me.Label50.TabIndex = 42
        Me.Label50.Text = "Anticipos:"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(62, 104)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(55, 16)
        Me.Label51.TabIndex = 43
        Me.Label51.Text = "Superavit:"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(62, 32)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(57, 16)
        Me.Label52.TabIndex = 40
        Me.Label52.Text = "Utilidades:"
        '
        'TextBox27
        '
        Me.TextBox27.AcceptsReturn = True
        Me.TextBox27.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgconfm.acct_anticipos"))
        Me.TextBox27.EditInitialValue = Nothing
        Me.TextBox27.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox27.FieldDescription = ""
        Me.TextBox27.FindInitialValue = Nothing
        Me.TextBox27.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox27.IgnoreRequiered = False
        Me.TextBox27.Location = New System.Drawing.Point(129, 72)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.NewInitialValue = Nothing
        Me.TextBox27.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox27.Requiered = False
        Me.TextBox27.Size = New System.Drawing.Size(128, 20)
        Me.TextBox27.StatusBarPanelDescripcion = Nothing
        Me.TextBox27.TabIndex = 2
        Me.TextBox27.Text = ""
        '
        'lblacct_anticipos
        '
        Me.lblacct_anticipos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblacct_anticipos.Location = New System.Drawing.Point(262, 72)
        Me.lblacct_anticipos.Name = "lblacct_anticipos"
        Me.lblacct_anticipos.Size = New System.Drawing.Size(320, 20)
        Me.lblacct_anticipos.TabIndex = 45
        '
        'TextBox28
        '
        Me.TextBox28.AcceptsReturn = True
        Me.TextBox28.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgconfm.acct_superavit"))
        Me.TextBox28.EditInitialValue = Nothing
        Me.TextBox28.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox28.FieldDescription = ""
        Me.TextBox28.FindInitialValue = Nothing
        Me.TextBox28.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox28.IgnoreRequiered = False
        Me.TextBox28.Location = New System.Drawing.Point(129, 96)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.NewInitialValue = Nothing
        Me.TextBox28.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox28.Requiered = False
        Me.TextBox28.Size = New System.Drawing.Size(128, 20)
        Me.TextBox28.StatusBarPanelDescripcion = Nothing
        Me.TextBox28.TabIndex = 3
        Me.TextBox28.Text = ""
        '
        'lblacct_superavit
        '
        Me.lblacct_superavit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblacct_superavit.Location = New System.Drawing.Point(262, 96)
        Me.lblacct_superavit.Name = "lblacct_superavit"
        Me.lblacct_superavit.Size = New System.Drawing.Size(320, 20)
        Me.lblacct_superavit.TabIndex = 48
        '
        'lblacct_utilidades_ant
        '
        Me.lblacct_utilidades_ant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblacct_utilidades_ant.Location = New System.Drawing.Point(262, 48)
        Me.lblacct_utilidades_ant.Name = "lblacct_utilidades_ant"
        Me.lblacct_utilidades_ant.Size = New System.Drawing.Size(320, 20)
        Me.lblacct_utilidades_ant.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Utilidades Anterior:"
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgconfm.acct_utilidades_ant"))
        Me.TextBox1.EditInitialValue = Nothing
        Me.TextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox1.FieldDescription = ""
        Me.TextBox1.FindInitialValue = Nothing
        Me.TextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox1.IgnoreRequiered = False
        Me.TextBox1.Location = New System.Drawing.Point(129, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.NewInitialValue = Nothing
        Me.TextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox1.Requiered = False
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.StatusBarPanelDescripcion = Nothing
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgconfm.acct_retenciones"))
        Me.TextBox2.EditInitialValue = Nothing
        Me.TextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.FieldDescription = ""
        Me.TextBox2.FindInitialValue = Nothing
        Me.TextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.IgnoreRequiered = False
        Me.TextBox2.Location = New System.Drawing.Point(129, 120)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.NewInitialValue = Nothing
        Me.TextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.Requiered = False
        Me.TextBox2.Size = New System.Drawing.Size(128, 20)
        Me.TextBox2.StatusBarPanelDescripcion = Nothing
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = ""
        '
        'lblacct_retenciones
        '
        Me.lblacct_retenciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblacct_retenciones.Location = New System.Drawing.Point(262, 120)
        Me.lblacct_retenciones.Name = "lblacct_retenciones"
        Me.lblacct_retenciones.Size = New System.Drawing.Size(320, 20)
        Me.lblacct_retenciones.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Retenciones:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXLookup5)
        Me.GroupBox1.Controls.Add(Me.LibXLookup4)
        Me.GroupBox1.Controls.Add(Me.LibXLookup3)
        Me.GroupBox1.Controls.Add(Me.xlk_acct_utilidades_ant)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.xtxt_acct_utilidades)
        Me.GroupBox1.Controls.Add(Me.lblacct_utilidades)
        Me.GroupBox1.Controls.Add(Me.Label50)
        Me.GroupBox1.Controls.Add(Me.Label51)
        Me.GroupBox1.Controls.Add(Me.Label52)
        Me.GroupBox1.Controls.Add(Me.TextBox27)
        Me.GroupBox1.Controls.Add(Me.lblacct_anticipos)
        Me.GroupBox1.Controls.Add(Me.TextBox28)
        Me.GroupBox1.Controls.Add(Me.lblacct_superavit)
        Me.GroupBox1.Controls.Add(Me.lblacct_utilidades_ant)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.lblacct_retenciones)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xlk_cuenta_cargo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.lblacct_cargo_name)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 184)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'LibXLookup5
        '
        Me.LibXLookup5.AlternateFieldSearch = Nothing
        Me.LibXLookup5.BeginCheck = False
        Me.LibXLookup5.CheckText = Nothing
        Me.LibXLookup5.ComboMode = False
        Me.LibXLookup5.DataMember = Nothing
        Me.LibXLookup5.DataSource = Me.LibxCXC
        Me.LibXLookup5.DestParameters = New String() {"acct_retenciones=acct_no", "lblacct_retenciones=acct_name"}
        Me.LibXLookup5.FilterField = "acct_name"
        Me.LibXLookup5.IgnoreFindInBrowseMode = False
        Me.LibXLookup5.isCanceled = False
        Me.LibXLookup5.Location = New System.Drawing.Point(583, 120)
        Me.LibXLookup5.LookCaption = Nothing
        Me.LibXLookup5.Name = "LibXLookup5"
        Me.LibXLookup5.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup5.ShowFilter = True
        Me.LibXLookup5.ShowMessageNotFound = True
        Me.LibXLookup5.ShowWarning = False
        Me.LibXLookup5.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup5.SizesColumns = Nothing
        Me.LibXLookup5.SizesColumnsTab = Nothing
        Me.LibXLookup5.SqlString = Nothing
        Me.LibXLookup5.SQLTab = Nothing
        Me.LibXLookup5.SrcParameters = New String() {"acct_retenciones=acct_no"}
        Me.LibXLookup5.TabIndex = 59
        Me.LibXLookup5.TableName = "cgacctm"
        Me.LibXLookup5.TabStop = False
        Me.LibXLookup5.UseCopyConnection = False
        Me.LibXLookup5.UseRowRetrieveEvents = False
        Me.LibXLookup5.UseTab = False
        Me.LibXLookup5.VisParameters = New String() {"Cuenta Numero=acct_no", "Nombre Cuenta=acct_name"}
        Me.LibXLookup5.WhereCondition = Nothing
        Me.LibXLookup5.WhereParameters = Nothing
        '
        'xlk_cuenta_cargo
        '
        Me.xlk_cuenta_cargo.AlternateFieldSearch = Nothing
        Me.xlk_cuenta_cargo.BeginCheck = False
        Me.xlk_cuenta_cargo.CheckText = Nothing
        Me.xlk_cuenta_cargo.ComboMode = False
        Me.xlk_cuenta_cargo.DataMember = Nothing
        Me.xlk_cuenta_cargo.DataSource = Me.LibxCXC
        Me.xlk_cuenta_cargo.DestParameters = New String() {"acct_cargos=acct_no", "lblacct_cargo_name=acct_name"}
        Me.xlk_cuenta_cargo.FilterField = "acct_name"
        Me.xlk_cuenta_cargo.IgnoreFindInBrowseMode = False
        Me.xlk_cuenta_cargo.isCanceled = False
        Me.xlk_cuenta_cargo.Location = New System.Drawing.Point(583, 144)
        Me.xlk_cuenta_cargo.LookCaption = Nothing
        Me.xlk_cuenta_cargo.Name = "xlk_cuenta_cargo"
        Me.xlk_cuenta_cargo.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_cuenta_cargo.ShowFilter = True
        Me.xlk_cuenta_cargo.ShowMessageNotFound = True
        Me.xlk_cuenta_cargo.ShowWarning = False
        Me.xlk_cuenta_cargo.Size = New System.Drawing.Size(16, 20)
        Me.xlk_cuenta_cargo.SizesColumns = Nothing
        Me.xlk_cuenta_cargo.SizesColumnsTab = Nothing
        Me.xlk_cuenta_cargo.SqlString = Nothing
        Me.xlk_cuenta_cargo.SQLTab = Nothing
        Me.xlk_cuenta_cargo.SrcParameters = New String() {"acct_cargos=acct_no"}
        Me.xlk_cuenta_cargo.TabIndex = 59
        Me.xlk_cuenta_cargo.TableName = "cgacctm"
        Me.xlk_cuenta_cargo.TabStop = False
        Me.xlk_cuenta_cargo.UseCopyConnection = False
        Me.xlk_cuenta_cargo.UseRowRetrieveEvents = False
        Me.xlk_cuenta_cargo.UseTab = False
        Me.xlk_cuenta_cargo.VisParameters = New String() {"Cuenta Numero=acct_no", "Nombre Cuenta=acct_name"}
        Me.xlk_cuenta_cargo.WhereCondition = Nothing
        Me.xlk_cuenta_cargo.WhereParameters = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Cargos financieros:"
        '
        'TextBox3
        '
        Me.TextBox3.AcceptsReturn = True
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgconfm.acct_cargos"))
        Me.TextBox3.EditInitialValue = Nothing
        Me.TextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.FieldDescription = ""
        Me.TextBox3.FindInitialValue = Nothing
        Me.TextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.IgnoreRequiered = False
        Me.TextBox3.Location = New System.Drawing.Point(129, 144)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.NewInitialValue = Nothing
        Me.TextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.Requiered = False
        Me.TextBox3.Size = New System.Drawing.Size(128, 20)
        Me.TextBox3.StatusBarPanelDescripcion = Nothing
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.Text = ""
        '
        'lblacct_cargo_name
        '
        Me.lblacct_cargo_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblacct_cargo_name.Location = New System.Drawing.Point(262, 144)
        Me.lblacct_cargo_name.Name = "lblacct_cargo_name"
        Me.lblacct_cargo_name.Size = New System.Drawing.Size(320, 20)
        Me.lblacct_cargo_name.TabIndex = 49
        '
        'i_cgconf01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 240)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_cgconf01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Configuración"
        CType(Me.LibxCXC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub i_cgconf01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.RefreshReg()
    End Sub

    Private Sub RefreshReg()
        Try
            Me.LibxCXC.ExecuteFind()

            If LibxCXC.HasRecords = False Then
                LibxCXC.AllowNew = True
                LibXNavigator1.UpdateState()
            Else
                LibxCXC.AllowNew = False
                LibXNavigator1.UpdateState()
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibxCXC_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibxCXC.ExecutedAction
        If e.AcceptedAction = LibX.LibxConnectionActions.Add _
        Or e.AcceptedAction = LibX.LibxConnectionActions.Edit Then
            Me.RefreshReg()
        End If
    End Sub

    Private Sub Label50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label50.Click

    End Sub
End Class
