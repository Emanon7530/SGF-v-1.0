Imports SGT.Contabilidad.Entidades
Public Class r_acctrp03
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPerdr_year As System.Windows.Forms.TextBox
    Friend WithEvents txtperdr_num As System.Windows.Forms.TextBox
    Friend WithEvents txtDept_code As System.Windows.Forms.TextBox
    Friend WithEvents lbldept_name As System.Windows.Forms.Label
    Friend WithEvents xlk_dept_code As LibX.LibXLookup
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaInicial As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentafinal As System.Windows.Forms.TextBox
    Friend WithEvents txtNivelInicial As System.Windows.Forms.TextBox
    Friend WithEvents txtNivelFinal As System.Windows.Forms.TextBox
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
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents xdt_FechaInicial As LibX.LibxDateTimePicker
    Friend WithEvents xdt_FechaFinal As LibX.LibxDateTimePicker
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents lblacct_namefinal As System.Windows.Forms.Label
    Friend WithEvents lblacct_nameinicial As System.Windows.Forms.Label
    Friend WithEvents xcbo_grupoinicial As LibX.LibXCombo
    Friend WithEvents xcbo_grupofinal As LibX.LibXCombo
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xcbo_grupofinal = New LibX.LibXCombo
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
        Me.xcbo_grupoinicial = New LibX.LibXCombo
        Me.xdt_FechaFinal = New LibX.LibxDateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtNivelFinal = New System.Windows.Forms.TextBox
        Me.txtNivelInicial = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataColumn18 = New System.Data.DataColumn
        Me.lblacct_namefinal = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCuentafinal = New System.Windows.Forms.TextBox
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.lblacct_nameinicial = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCuentaInicial = New System.Windows.Forms.TextBox
        Me.xdt_FechaInicial = New LibX.LibxDateTimePicker
        Me.xlk_dept_code = New LibX.LibXLookup
        Me.lbldept_name = New System.Windows.Forms.Label
        Me.txtPerdr_year = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtperdr_num = New System.Windows.Forms.TextBox
        Me.txtDept_code = New System.Windows.Forms.TextBox
        Me.btnIniciar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(560, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LISTADO DE CUENTAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXLookup3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.xcbo_grupofinal)
        Me.GroupBox1.Controls.Add(Me.xcbo_grupoinicial)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaFinal)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtNivelFinal)
        Me.GroupBox1.Controls.Add(Me.txtNivelInicial)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LibXLookup2)
        Me.GroupBox1.Controls.Add(Me.lblacct_namefinal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCuentafinal)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.lblacct_nameinicial)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCuentaInicial)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaInicial)
        Me.GroupBox1.Controls.Add(Me.xlk_dept_code)
        Me.GroupBox1.Controls.Add(Me.lbldept_name)
        Me.GroupBox1.Controls.Add(Me.txtPerdr_year)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtperdr_num)
        Me.GroupBox1.Controls.Add(Me.txtDept_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 256)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'xcbo_grupofinal
        '
        Me.xcbo_grupofinal.AllowDefaultSort = True
        Me.xcbo_grupofinal.bound = True
        Me.xcbo_grupofinal.currValue = Nothing
        Me.xcbo_grupofinal.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cgperdd.GrupoFinal"))
        Me.xcbo_grupofinal.DefaultWhereString = Nothing
        Me.xcbo_grupofinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_grupofinal.EditInitialValue = Nothing
        Me.xcbo_grupofinal.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_grupofinal.FieldDescription = ""
        Me.xcbo_grupofinal.FindInitialValue = Nothing
        Me.xcbo_grupofinal.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_grupofinal.IgnoreRequiered = False
        Me.xcbo_grupofinal.Location = New System.Drawing.Point(104, 165)
        Me.xcbo_grupofinal.LookupKeyDisplayFields = "type_descr"
        Me.xcbo_grupofinal.LookupKeyField = "acct_type"
        Me.xcbo_grupofinal.LookupTableName = "cgacctpm"
        Me.xcbo_grupofinal.Name = "xcbo_grupofinal"
        Me.xcbo_grupofinal.NewInitialValue = Nothing
        Me.xcbo_grupofinal.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_grupofinal.Requiered = False
        Me.xcbo_grupofinal.Required = False
        Me.xcbo_grupofinal.Size = New System.Drawing.Size(336, 21)
        Me.xcbo_grupofinal.SqlString = Nothing
        Me.xcbo_grupofinal.StatusBarPanelDescripcion = Nothing
        Me.xcbo_grupofinal.TabIndex = 43
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"perdr_year", "perdr_num"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn2, Me.DataColumn1}
        Me.DataTable1.TableName = "cgperdd"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.Caption = "perdr_num"
        Me.DataColumn1.ColumnName = "perdr_num"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "perdr_year"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "CuentaInicial"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "CuentaFinal"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "NivelInicial"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "NivelFinal"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "GrupoInicial"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "GrupoFinal"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "dept_code"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "FechaInicial"
        Me.DataColumn10.DataType = GetType(System.DateTime)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "FechaFinal"
        Me.DataColumn11.DataType = GetType(System.DateTime)
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
        'xcbo_grupoinicial
        '
        Me.xcbo_grupoinicial.AllowDefaultSort = True
        Me.xcbo_grupoinicial.bound = True
        Me.xcbo_grupoinicial.currValue = Nothing
        Me.xcbo_grupoinicial.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cgperdd.GrupoInicial"))
        Me.xcbo_grupoinicial.DefaultWhereString = Nothing
        Me.xcbo_grupoinicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_grupoinicial.EditInitialValue = Nothing
        Me.xcbo_grupoinicial.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_grupoinicial.FieldDescription = ""
        Me.xcbo_grupoinicial.FindInitialValue = Nothing
        Me.xcbo_grupoinicial.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_grupoinicial.IgnoreRequiered = False
        Me.xcbo_grupoinicial.Location = New System.Drawing.Point(104, 141)
        Me.xcbo_grupoinicial.LookupKeyDisplayFields = "type_descr"
        Me.xcbo_grupoinicial.LookupKeyField = "acct_type"
        Me.xcbo_grupoinicial.LookupTableName = "cgacctpm"
        Me.xcbo_grupoinicial.Name = "xcbo_grupoinicial"
        Me.xcbo_grupoinicial.NewInitialValue = Nothing
        Me.xcbo_grupoinicial.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_grupoinicial.Requiered = False
        Me.xcbo_grupoinicial.Required = False
        Me.xcbo_grupoinicial.Size = New System.Drawing.Size(336, 21)
        Me.xcbo_grupoinicial.SqlString = Nothing
        Me.xcbo_grupoinicial.StatusBarPanelDescripcion = Nothing
        Me.xcbo_grupoinicial.TabIndex = 42
        '
        'xdt_FechaFinal
        '
        Me.xdt_FechaFinal.CustomFormat = "dd/MM/yyyy"
        Me.xdt_FechaFinal.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cgperdd.FechaFinal"))
        Me.xdt_FechaFinal.EditInitialValue = Nothing
        Me.xdt_FechaFinal.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.FieldDescription = ""
        Me.xdt_FechaFinal.FindInitialValue = Nothing
        Me.xdt_FechaFinal.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaFinal.IgnoreRequiered = False
        Me.xdt_FechaFinal.Location = New System.Drawing.Point(336, 213)
        Me.xdt_FechaFinal.Name = "xdt_FechaFinal"
        Me.xdt_FechaFinal.NewInitialValue = Nothing
        Me.xdt_FechaFinal.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.Requiered = False
        Me.xdt_FechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.xdt_FechaFinal.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaFinal.TabIndex = 41
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(256, 213)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 16)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Fecha Final:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(28, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 16)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Grupo Final:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(23, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 16)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Grupo Inicial:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNivelFinal
        '
        Me.txtNivelFinal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgperdd.NivelFinal"))
        Me.txtNivelFinal.Location = New System.Drawing.Point(160, 117)
        Me.txtNivelFinal.Name = "txtNivelFinal"
        Me.txtNivelFinal.Size = New System.Drawing.Size(48, 20)
        Me.txtNivelFinal.TabIndex = 31
        Me.txtNivelFinal.Text = ""
        '
        'txtNivelInicial
        '
        Me.txtNivelInicial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgperdd.NivelInicial"))
        Me.txtNivelInicial.Location = New System.Drawing.Point(104, 117)
        Me.txtNivelInicial.Name = "txtNivelInicial"
        Me.txtNivelInicial.Size = New System.Drawing.Size(48, 20)
        Me.txtNivelInicial.TabIndex = 30
        Me.txtNivelInicial.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(61, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Nivel:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"cuentafinal=acct_no", "lblacct_namefinal=acct_name"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(424, 93)
        Me.LibXLookup2.LookCaption = Nothing
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup2.ShowFilter = True
        Me.LibXLookup2.ShowMessageNotFound = True
        Me.LibXLookup2.ShowWarning = False
        Me.LibXLookup2.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup2.SizesColumns = Nothing
        Me.LibXLookup2.SizesColumnsTab = Nothing
        Me.LibXLookup2.SqlString = Nothing
        Me.LibXLookup2.SQLTab = Nothing
        Me.LibXLookup2.SrcParameters = New String() {"acct_no=cuentafinal"}
        Me.LibXLookup2.TabIndex = 28
        Me.LibXLookup2.TableName = "cgacctm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=acct_no", "Nombre=acct_name"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "cgperdd"
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
        Me.LibXDbSourceTable1.TableName = "cgperdd"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "suc_code"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'lblacct_namefinal
        '
        Me.lblacct_namefinal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblacct_namefinal.Location = New System.Drawing.Point(216, 93)
        Me.lblacct_namefinal.Name = "lblacct_namefinal"
        Me.lblacct_namefinal.Size = New System.Drawing.Size(208, 20)
        Me.lblacct_namefinal.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(22, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Cuenta Final:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCuentafinal
        '
        Me.txtCuentafinal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgperdd.CuentaFinal"))
        Me.txtCuentafinal.Location = New System.Drawing.Point(104, 93)
        Me.txtCuentafinal.Name = "txtCuentafinal"
        Me.txtCuentafinal.Size = New System.Drawing.Size(104, 20)
        Me.txtCuentafinal.TabIndex = 26
        Me.txtCuentafinal.Text = ""
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"cuentainicial=acct_no", "lblacct_nameinicial=acct_name"}
        Me.LibXLookup1.FilterField = "acct_name"
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(424, 69)
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
        Me.LibXLookup1.SrcParameters = New String() {"cuentainicial=acct_no"}
        Me.LibXLookup1.TabIndex = 24
        Me.LibXLookup1.TableName = "cgacctm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=acct_no", "Nombre=acct_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'lblacct_nameinicial
        '
        Me.lblacct_nameinicial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblacct_nameinicial.Location = New System.Drawing.Point(216, 69)
        Me.lblacct_nameinicial.Name = "lblacct_nameinicial"
        Me.lblacct_nameinicial.Size = New System.Drawing.Size(208, 20)
        Me.lblacct_nameinicial.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(18, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Cuenta Inicial:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCuentaInicial
        '
        Me.txtCuentaInicial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgperdd.CuentaInicial"))
        Me.txtCuentaInicial.Location = New System.Drawing.Point(104, 69)
        Me.txtCuentaInicial.Name = "txtCuentaInicial"
        Me.txtCuentaInicial.Size = New System.Drawing.Size(104, 20)
        Me.txtCuentaInicial.TabIndex = 22
        Me.txtCuentaInicial.Text = ""
        '
        'xdt_FechaInicial
        '
        Me.xdt_FechaInicial.CustomFormat = "dd/MM/yyyy"
        Me.xdt_FechaInicial.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cgperdd.FechaInicial"))
        Me.xdt_FechaInicial.EditInitialValue = Nothing
        Me.xdt_FechaInicial.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicial.FieldDescription = ""
        Me.xdt_FechaInicial.FindInitialValue = Nothing
        Me.xdt_FechaInicial.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaInicial.IgnoreRequiered = False
        Me.xdt_FechaInicial.Location = New System.Drawing.Point(104, 213)
        Me.xdt_FechaInicial.Name = "xdt_FechaInicial"
        Me.xdt_FechaInicial.NewInitialValue = Nothing
        Me.xdt_FechaInicial.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicial.Requiered = False
        Me.xdt_FechaInicial.Size = New System.Drawing.Size(104, 20)
        Me.xdt_FechaInicial.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaInicial.TabIndex = 20
        '
        'xlk_dept_code
        '
        Me.xlk_dept_code.AlternateFieldSearch = Nothing
        Me.xlk_dept_code.BeginCheck = False
        Me.xlk_dept_code.CheckText = Nothing
        Me.xlk_dept_code.ComboMode = False
        Me.xlk_dept_code.DataMember = Nothing
        Me.xlk_dept_code.DataSource = Me.LibXConnector1
        Me.xlk_dept_code.DestParameters = New String() {"txtDept_code=dept_code", "lbldept_name=dept_name"}
        Me.xlk_dept_code.FilterField = Nothing
        Me.xlk_dept_code.IgnoreFindInBrowseMode = False
        Me.xlk_dept_code.isCanceled = False
        Me.xlk_dept_code.Location = New System.Drawing.Point(424, 189)
        Me.xlk_dept_code.LookCaption = Nothing
        Me.xlk_dept_code.Name = "xlk_dept_code"
        Me.xlk_dept_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_dept_code.ShowFilter = True
        Me.xlk_dept_code.ShowMessageNotFound = True
        Me.xlk_dept_code.ShowWarning = False
        Me.xlk_dept_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_dept_code.SizesColumns = Nothing
        Me.xlk_dept_code.SizesColumnsTab = Nothing
        Me.xlk_dept_code.SqlString = Nothing
        Me.xlk_dept_code.SQLTab = Nothing
        Me.xlk_dept_code.SrcParameters = New String() {"dept_code=txtDept_code"}
        Me.xlk_dept_code.TabIndex = 18
        Me.xlk_dept_code.TableName = "cgdeptm"
        Me.xlk_dept_code.TabStop = False
        Me.xlk_dept_code.UseCopyConnection = False
        Me.xlk_dept_code.UseRowRetrieveEvents = False
        Me.xlk_dept_code.UseTab = False
        Me.xlk_dept_code.VisParameters = New String() {"Código=dept_code", "Nombre=dept_name"}
        Me.xlk_dept_code.WhereCondition = Nothing
        Me.xlk_dept_code.WhereParameters = Nothing
        '
        'lbldept_name
        '
        Me.lbldept_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldept_name.Location = New System.Drawing.Point(160, 189)
        Me.lbldept_name.Name = "lbldept_name"
        Me.lbldept_name.Size = New System.Drawing.Size(264, 20)
        Me.lbldept_name.TabIndex = 16
        '
        'txtPerdr_year
        '
        Me.txtPerdr_year.Location = New System.Drawing.Point(104, 24)
        Me.txtPerdr_year.Name = "txtPerdr_year"
        Me.txtPerdr_year.Size = New System.Drawing.Size(48, 20)
        Me.txtPerdr_year.TabIndex = 15
        Me.txtPerdr_year.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(13, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Periodo Actual:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(15, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Departamento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(24, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha Inicial:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtperdr_num
        '
        Me.txtperdr_num.Location = New System.Drawing.Point(160, 24)
        Me.txtperdr_num.Name = "txtperdr_num"
        Me.txtperdr_num.Size = New System.Drawing.Size(48, 20)
        Me.txtperdr_num.TabIndex = 15
        Me.txtperdr_num.Text = ""
        '
        'txtDept_code
        '
        Me.txtDept_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgperdd.dept_code"))
        Me.txtDept_code.Location = New System.Drawing.Point(104, 189)
        Me.txtDept_code.Name = "txtDept_code"
        Me.txtDept_code.Size = New System.Drawing.Size(48, 20)
        Me.txtDept_code.TabIndex = 15
        Me.txtDept_code.Text = ""
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(480, 64)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.TabIndex = 2
        Me.btnIniciar.Text = "Iniciar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(480, 88)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 327)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(560, 23)
        Me.ProgressBar1.TabIndex = 13
        '
        'LibXLookup3
        '
        Me.LibXLookup3.AlternateFieldSearch = Nothing
        Me.LibXLookup3.BeginCheck = False
        Me.LibXLookup3.CheckText = Nothing
        Me.LibXLookup3.ComboMode = False
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Me.LibXConnector1
        Me.LibXLookup3.DestParameters = New String() {"suc_code=suc_code", "Label4=suc_name"}
        Me.LibXLookup3.FilterField = "suc_name"
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.isCanceled = False
        Me.LibXLookup3.Location = New System.Drawing.Point(424, 48)
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
        Me.LibXLookup3.SrcParameters = New String() {"suc_code=suc_code"}
        Me.LibXLookup3.TabIndex = 47
        Me.LibXLookup3.TableName = "cgsucursal"
        Me.LibXLookup3.TabStop = False
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.UseTab = False
        Me.LibXLookup3.VisParameters = New String() {"Código=suc_code", "Nombre=suc_name"}
        Me.LibXLookup3.WhereCondition = Nothing
        Me.LibXLookup3.WhereParameters = Nothing
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(216, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 20)
        Me.Label4.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(40, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Sucursal:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgperdd.suc_code"))
        Me.TextBox1.Location = New System.Drawing.Point(104, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(104, 20)
        Me.TextBox1.TabIndex = 45
        Me.TextBox1.Text = ""
        '
        'r_acctrp03
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 350)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Name = "r_acctrp03"
        Me.Text = "Listado de Cuentas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim oPeriodo As Periodo
    Dim WithEvents oAnoFiscal As AnoFiscal

    Private Sub p_acctpr01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            LibXConnector1.Find()

            oAnoFiscal = New AnoFiscal
            oPeriodo = oAnoFiscal.BuscarPeriodoActual

            txtperdr_num.Text = oPeriodo.Number.ToString
            txtPerdr_year.Text = oPeriodo.year.ToString

            LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year.ToString
            LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number.ToString


            xdt_FechaInicial.Value = oPeriodo.From
            xdt_FechaFinal.Value = oPeriodo.Thru

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        Dim oReport As LibX.ReportLib
        Dim SQLString As String
        Dim WhereString As String
        Try

            If txtperdr_num.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgacctd.perdr_num = " & txtperdr_num.Text)
            End If

            If txtPerdr_year.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgacctd.perdr_year= " & txtPerdr_year.Text)
            End If

            If txtDept_code.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgacctd.dept_code = " & txtDept_code.Text)
            End If

            If txtCuentaInicial.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgacctd.acct_no >= " & txtCuentaInicial.Text)
            End If

            If txtCuentafinal.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgacctd.acct_no <= " & txtCuentafinal.Text)
            End If

            If txtNivelInicial.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgacctm.acct_nivel >= " & txtNivelInicial.Text)
            End If

            If txtNivelFinal.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgacctm.acct_nivel <= " & txtNivelFinal.Text)
            End If

            If xcbo_grupoinicial.SelectedValue.ToString.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgacctm.acct_type >= " & xcbo_grupoinicial.SelectedValue.ToString)
            End If

            If xcbo_grupofinal.SelectedValue.ToString.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgacctm.acct_type <= " & xcbo_grupofinal.SelectedValue.ToString)
            End If
            If Val(TextBox1.Text) > 0 Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgacctd.suc_code = " & Val(TextBox1.Text))
            End If

            oReport = New LibX.ReportLib("CTG", "r_acctrp03.rpt")

            oReport.RetrieveSQLQuery()
            SQLString = oReport.SQLQuery
            SQLString = LibX.ConcatWherePart(SQLString, WhereString)
            oReport.SQLQuery = SQLString

            oReport.ParameterFields(1) = String.Concat("pFechaInicial;", Trim(xdt_FechaInicial.Value), ";TRUE")
            oReport.ParameterFields(2) = String.Concat("pFechaFinal;", Trim(xdt_FechaFinal.Value), ";TRUE")

            oReport.Action = 1

            '  btnIniciar.Enabled = False
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("Seguro desea cerrar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class
