Public Class i_cjinit01
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents caja_name As System.Windows.Forms.TextBox
    Friend WithEvents vend_name As System.Windows.Forms.TextBox
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXShortNavigator1 As LibX.LibXShortNavigator
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents xcbo_init_status As LibX.LibXCombo
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents xdt_init_date As LibX.LibxDateTimePicker
    Friend WithEvents xtxt_caja_code As System.Windows.Forms.TextBox
    Friend WithEvents xtxt_caje_code As System.Windows.Forms.TextBox
    Friend WithEvents xlk_caja_code As LibX.LibXLookup
    Friend WithEvents xlk_caje_code As LibX.LibXLookup
    Friend WithEvents txtEfeini As System.Windows.Forms.TextBox
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
    Friend WithEvents btndesglose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xcbo_init_status = New LibX.LibXCombo
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.xdt_init_date = New LibX.LibxDateTimePicker
        Me.xlk_caja_code = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.Label4 = New System.Windows.Forms.Label
        Me.xtxt_caja_code = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.caja_name = New System.Windows.Forms.TextBox
        Me.xtxt_caje_code = New System.Windows.Forms.TextBox
        Me.vend_name = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtEfeini = New System.Windows.Forms.TextBox
        Me.xlk_caje_code = New LibX.LibXLookup
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.LibXShortNavigator1 = New LibX.LibXShortNavigator
        Me.btndesglose = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xcbo_init_status)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xdt_init_date)
        Me.GroupBox1.Controls.Add(Me.xlk_caja_code)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xtxt_caja_code)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.caja_name)
        Me.GroupBox1.Controls.Add(Me.xtxt_caje_code)
        Me.GroupBox1.Controls.Add(Me.vend_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEfeini)
        Me.GroupBox1.Controls.Add(Me.xlk_caje_code)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 128)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'xcbo_init_status
        '
        Me.xcbo_init_status.AllowDefaultSort = True
        Me.xcbo_init_status.bound = True
        Me.xcbo_init_status.currValue = Nothing
        Me.xcbo_init_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cjinitm.init_status"))
        Me.xcbo_init_status.DefaultWhereString = Nothing
        Me.xcbo_init_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_init_status.EditInitialValue = Nothing
        Me.xcbo_init_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_init_status.FieldDescription = ""
        Me.xcbo_init_status.FindInitialValue = Nothing
        Me.xcbo_init_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_init_status.IgnoreRequiered = False
        Me.xcbo_init_status.Items.AddRange(New Object() {"1-Abierta", "2-Cerrada", "3-Pendiente de Cuadre"})
        Me.xcbo_init_status.Location = New System.Drawing.Point(72, 96)
        Me.xcbo_init_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_init_status.LookupKeyField = Nothing
        Me.xcbo_init_status.LookupTableName = Nothing
        Me.xcbo_init_status.Name = "xcbo_init_status"
        Me.xcbo_init_status.NewInitialValue = "1"
        Me.xcbo_init_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_init_status.Requiered = False
        Me.xcbo_init_status.Required = False
        Me.xcbo_init_status.Size = New System.Drawing.Size(88, 21)
        Me.xcbo_init_status.SqlString = Nothing
        Me.xcbo_init_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_init_status.TabIndex = 4
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"init_serial"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "cjinitm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "init_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "vend_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "caja_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "init_date"
        Me.DataColumn4.DataType = GetType(System.DateTime)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "cash_amount"
        Me.DataColumn5.DataType = GetType(System.Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "init_status"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "close_date"
        Me.DataColumn7.DataType = GetType(System.DateTime)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "no_cierre"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "ncf"
        Me.DataColumn9.MaxLength = 19
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "suc_code"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(16, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Estatus:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xdt_init_date
        '
        Me.xdt_init_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_init_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cjinitm.init_date"))
        Me.xdt_init_date.EditInitialValue = Nothing
        Me.xdt_init_date.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdt_init_date.Enabled = False
        Me.xdt_init_date.FieldDescription = ""
        Me.xdt_init_date.FindInitialValue = Nothing
        Me.xdt_init_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_init_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_init_date.IgnoreRequiered = False
        Me.xdt_init_date.Location = New System.Drawing.Point(72, 72)
        Me.xdt_init_date.Name = "xdt_init_date"
        Me.xdt_init_date.NewInitialValue = "now"
        Me.xdt_init_date.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdt_init_date.Requiered = False
        Me.xdt_init_date.Size = New System.Drawing.Size(88, 20)
        Me.xdt_init_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_init_date.TabIndex = 2
        '
        'xlk_caja_code
        '
        Me.xlk_caja_code.AlternateFieldSearch = Nothing
        Me.xlk_caja_code.BeginCheck = False
        Me.xlk_caja_code.CheckText = Nothing
        Me.xlk_caja_code.ComboMode = False
        Me.xlk_caja_code.DataMember = Nothing
        Me.xlk_caja_code.DataSource = Me.LibXConnector1
        Me.xlk_caja_code.DestParameters = New String() {"caja_code=caja_code", "caja_name=caja_name"}
        Me.xlk_caja_code.FilterField = Nothing
        Me.xlk_caja_code.IgnoreFindInBrowseMode = False
        Me.xlk_caja_code.isCanceled = False
        Me.xlk_caja_code.Location = New System.Drawing.Point(392, 24)
        Me.xlk_caja_code.LookCaption = "Cajas"
        Me.xlk_caja_code.Name = "xlk_caja_code"
        Me.xlk_caja_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_caja_code.ShowFilter = True
        Me.xlk_caja_code.ShowMessageNotFound = True
        Me.xlk_caja_code.ShowWarning = False
        Me.xlk_caja_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_caja_code.SizesColumns = Nothing
        Me.xlk_caja_code.SizesColumnsTab = Nothing
        Me.xlk_caja_code.SqlString = Nothing
        Me.xlk_caja_code.SQLTab = Nothing
        Me.xlk_caja_code.SrcParameters = New String() {"caja_code=caja_code"}
        Me.xlk_caja_code.TabIndex = 4
        Me.xlk_caja_code.TableName = "cjcajam"
        Me.xlk_caja_code.TabStop = False
        Me.xlk_caja_code.UseCopyConnection = False
        Me.xlk_caja_code.UseRowRetrieveEvents = False
        Me.xlk_caja_code.UseTab = False
        Me.xlk_caja_code.VisParameters = New String() {"Código=caja_code", "Nombre=caja_name"}
        Me.xlk_caja_code.WhereCondition = Nothing
        Me.xlk_caja_code.WhereParameters = Nothing
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = True
        Me.LibXConnector1.AllowEdit = False
        Me.LibXConnector1.AllowNew = True
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "cjinitm"
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
        Me.LibXDbSourceTable1.SerialColumnName = "init_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cjinitm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(232, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Efectivo Inicial:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_caja_code
        '
        Me.xtxt_caja_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjinitm.caja_code"))
        Me.xtxt_caja_code.Location = New System.Drawing.Point(72, 24)
        Me.xtxt_caja_code.Name = "xtxt_caja_code"
        Me.xtxt_caja_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_caja_code.TabIndex = 0
        Me.xtxt_caja_code.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(30, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Caja:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'caja_name
        '
        Me.caja_name.Location = New System.Drawing.Point(136, 24)
        Me.caja_name.Name = "caja_name"
        Me.caja_name.ReadOnly = True
        Me.caja_name.Size = New System.Drawing.Size(256, 20)
        Me.caja_name.TabIndex = 1
        Me.caja_name.TabStop = False
        Me.caja_name.Text = ""
        '
        'xtxt_caje_code
        '
        Me.xtxt_caje_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjinitm.vend_code"))
        Me.xtxt_caje_code.Location = New System.Drawing.Point(72, 48)
        Me.xtxt_caje_code.Name = "xtxt_caje_code"
        Me.xtxt_caje_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_caje_code.TabIndex = 1
        Me.xtxt_caje_code.Text = ""
        '
        'vend_name
        '
        Me.vend_name.Location = New System.Drawing.Point(136, 48)
        Me.vend_name.Name = "vend_name"
        Me.vend_name.ReadOnly = True
        Me.vend_name.Size = New System.Drawing.Size(256, 20)
        Me.vend_name.TabIndex = 1
        Me.vend_name.TabStop = False
        Me.vend_name.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(20, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cajera:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(22, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtEfeini
        '
        Me.txtEfeini.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjinitm.cash_amount"))
        Me.txtEfeini.Location = New System.Drawing.Point(320, 72)
        Me.txtEfeini.Name = "txtEfeini"
        Me.txtEfeini.Size = New System.Drawing.Size(88, 20)
        Me.txtEfeini.TabIndex = 3
        Me.txtEfeini.Text = ""
        Me.txtEfeini.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xlk_caje_code
        '
        Me.xlk_caje_code.AlternateFieldSearch = Nothing
        Me.xlk_caje_code.BeginCheck = False
        Me.xlk_caje_code.CheckText = Nothing
        Me.xlk_caje_code.ComboMode = False
        Me.xlk_caje_code.DataMember = Nothing
        Me.xlk_caje_code.DataSource = Me.LibXConnector1
        Me.xlk_caje_code.DestParameters = New String() {"vend_code=vend_code", "vend_name=vend_name", "cash_amount=efe_ini"}
        Me.xlk_caje_code.FilterField = Nothing
        Me.xlk_caje_code.IgnoreFindInBrowseMode = False
        Me.xlk_caje_code.isCanceled = False
        Me.xlk_caje_code.Location = New System.Drawing.Point(392, 48)
        Me.xlk_caje_code.LookCaption = "Cajeras"
        Me.xlk_caje_code.Name = "xlk_caje_code"
        Me.xlk_caje_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_caje_code.ShowFilter = True
        Me.xlk_caje_code.ShowMessageNotFound = True
        Me.xlk_caje_code.ShowWarning = False
        Me.xlk_caje_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_caje_code.SizesColumns = Nothing
        Me.xlk_caje_code.SizesColumnsTab = Nothing
        Me.xlk_caje_code.SqlString = Nothing
        Me.xlk_caje_code.SQLTab = Nothing
        Me.xlk_caje_code.SrcParameters = New String() {"vend_code=vend_code"}
        Me.xlk_caje_code.TabIndex = 4
        Me.xlk_caje_code.TableName = "ftvendm"
        Me.xlk_caje_code.TabStop = False
        Me.xlk_caje_code.UseCopyConnection = False
        Me.xlk_caje_code.UseRowRetrieveEvents = False
        Me.xlk_caje_code.UseTab = False
        Me.xlk_caje_code.VisParameters = New String() {"Código=vend_code", "Nombre=vend_name"}
        Me.xlk_caje_code.WhereCondition = "vend_cargo = 1"
        Me.xlk_caje_code.WhereParameters = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(264, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Cerrada:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjinitm.close_date"))
        Me.TextBox2.Location = New System.Drawing.Point(320, 96)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(88, 20)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = ""
        '
        'LibXShortNavigator1
        '
        Me.LibXShortNavigator1.BuildMenu = True
        Me.LibXShortNavigator1.Connector = Me.LibXConnector1
        Me.LibXShortNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXShortNavigator1.FirstControlInEditMode = Nothing
        Me.LibXShortNavigator1.FirstControlInFindMode = Nothing
        Me.LibXShortNavigator1.FirstControlInNewMode = Nothing
        Me.LibXShortNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXShortNavigator1.Name = "LibXShortNavigator1"
        Me.LibXShortNavigator1.Size = New System.Drawing.Size(458, 24)
        Me.LibXShortNavigator1.TabIndex = 0
        '
        'btndesglose
        '
        Me.btndesglose.Location = New System.Drawing.Point(296, 160)
        Me.btndesglose.Name = "btndesglose"
        Me.btndesglose.Size = New System.Drawing.Size(112, 32)
        Me.btndesglose.TabIndex = 2
        Me.btndesglose.Text = "Desglose Moneda"
        '
        'i_cjinit01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(458, 224)
        Me.Controls.Add(Me.btndesglose)
        Me.Controls.Add(Me.LibXShortNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_cjinit01"
        Me.Text = "Iniciar Caja"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try

            If Not LibXConnector1.Parameters Is Nothing Then
                If LibXConnector1.Parameters.Datos.Count > 0 Then
                    Me.xtxt_caje_code.Text = LibXConnector1.Parameters.Datos.Item("caje_code")
                    Me.xtxt_caje_code.Enabled = False

                    Me.xdt_init_date.Value = LibXConnector1.Parameters.Datos.Item("init_date")
                    Me.xtxt_caja_code.Text = LibXConnector1.Parameters.Datos.Item("caja_code")
                    Me.xlk_caja_code.ExecuteFind()
                    Me.xlk_caje_code.ExecuteFind()
                End If
            Else
                Me.xdt_init_date.Value = FindFechaSever()
            End If
            Me.xcbo_init_status.currValue = 1 '//Abierta

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If LibXConnector1.IsDataEditing = True Then
                If LibX.IsNull(LibXConnector1.CurrentDataRow!init_status) = False _
                   AndAlso LibXConnector1.CurrentDataRow!init_status = 2 Then
                    LibXConnector1.AllowDelete = False
                    LibXConnector1.AllowEdit = False
                Else
                    LibXConnector1.AllowDelete = True
                    LibXConnector1.AllowEdit = True
                    If LibXConnector1.CurrentDataRow!init_status = 3 Then
                        Me.xcbo_init_status.currValue = 1
                    End If
                End If
                LibXShortNavigator1.UpdateState()
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert _
                Or e.UpdatingArgs.StatementType = StatementType.Update Then
                If e.UpdatingArgs.Row!init_date > Now Then
                    Throw New ApplicationException("La fecha de inicio no puede ser mayor que hoy")
                End If
                If LibX.IsNull(txtEfeini.Text) Then
                    e.UpdatingArgs.Row!cash_amount = 0
                End If
                e.UpdatingArgs.Row!suc_code = LibXConnector1.Parameters.Datos.Item("suc_code")
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
        Me.Close()
    End Sub
    Public Function FindFechaSever() As DateTime
        Dim Serverdate As DateTime
        Dim XSelect As LibX.Data.XSelecStmt
        Try
            Serverdate = LibX.Data.Manager.GetScalar("select getdate()")

            Return Serverdate

        Catch ex As Exception
            LibX.Log.Add(ex)
        Finally

        End Try
    End Function

    Private Sub btndesglose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndesglose.Click
        Dim oParametro As LibX.LibxPrgParams
        Try
            oParametro = New LibX.LibxPrgParams

            With oParametro
                .IsFromOther = True
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = True
                ''.initMode = LibX.LibxInitModes.none
                .initMode = LibX.LibxInitModes.Insert
                .WhereToExecute = "init_serial = 2"
            End With

            LibX.App.CurrentPrgParams = oParametro
            LibX.LibXRunner.Run("i_cjdesglo", "CAJ", True)
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub i_cjinit01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
