Imports SGT.Contabilidad.Entidades
Imports LibX
Public Class r_tranr05
    Inherits System.Windows.Forms.Form
    Dim oPeriodo As Periodo
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPerdr_year As System.Windows.Forms.TextBox
    Friend WithEvents txtperdr_num As System.Windows.Forms.TextBox
    Friend WithEvents xdt_FechaInicial As LibX.LibxDateTimePicker
    Friend WithEvents xdt_FechaFinal As LibX.LibxDateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents xcbo_tran_type As LibX.LibXCombo
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents xtxSuc_name As System.Windows.Forms.Label
    Friend WithEvents xtxSuc_code As LibX.XTextBox
    Friend WithEvents labacct_no As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataColumn7 = New System.Data.DataColumn
        Me.xtxSuc_name = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.xtxSuc_code = New LibX.XTextBox
        Me.xcbo_tran_type = New LibX.LibXCombo
        Me.Label6 = New System.Windows.Forms.Label
        Me.xdt_FechaFinal = New LibX.LibxDateTimePicker
        Me.xdt_FechaInicial = New LibX.LibxDateTimePicker
        Me.txtPerdr_year = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtperdr_num = New System.Windows.Forms.TextBox
        Me.btnIniciar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.labacct_no = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Text = "MOVIMIENTOS POR CUENTAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXLookup2)
        Me.GroupBox1.Controls.Add(Me.labacct_no)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.xtxSuc_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xtxSuc_code)
        Me.GroupBox1.Controls.Add(Me.xcbo_tran_type)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaFinal)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaInicial)
        Me.GroupBox1.Controls.Add(Me.txtPerdr_year)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtperdr_num)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 168)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"suc_code=suc_code", "xtxSuc_name=suc_name"}
        Me.LibXLookup1.FilterField = "suc_name"
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(426, 121)
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
        Me.LibXLookup1.TabIndex = 26
        Me.LibXLookup1.TableName = "cgsucursal"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Cuenta=suc_code", "Nombre=suc_name"}
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
        Me.LibXConnector1.DataMember = "cgacctd"
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
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.DataTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"acct_no", "perdr_num", "perdr_year"}, True)})
        Me.DataTable2.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn11, Me.DataColumn12, Me.DataColumn13}
        Me.DataTable2.TableName = "cgacctd"
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "acct_no"
        Me.DataColumn11.MaxLength = 20
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "perdr_num"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "perdr_year"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "debit_amount"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "dept_code"
        Me.DataColumn15.DataType = GetType(System.Int32)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "credit_amount"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "balance"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "initial"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "tran_type"
        Me.DataColumn1.ColumnName = "tran_type"
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "tranr_serial"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "line_no"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "tranr_detail"
        Me.DataColumn4.MaxLength = 40
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "debit_credit"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "amount"
        Me.DataColumn6.DataType = GetType(System.Decimal)
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
        Me.LibXDbSourceTable1.InnerJon = False
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select cgtranrd.*,cgacctd.initial from cgtranrd", "inner join cgacctd on cgacctd.acct_no=cgtranrd.acct_no"}
        Me.LibXDbSourceTable1.TableName = "cgacctd"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "suc_code"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'xtxSuc_name
        '
        Me.xtxSuc_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xtxSuc_name.Location = New System.Drawing.Point(176, 120)
        Me.xtxSuc_name.Name = "xtxSuc_name"
        Me.xtxSuc_name.Size = New System.Drawing.Size(248, 20)
        Me.xtxSuc_name.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(48, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Sucursal:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxSuc_code
        '
        Me.xtxSuc_code.AcceptsReturn = True
        Me.xtxSuc_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgacctd.suc_code"))
        Me.xtxSuc_code.EditInitialValue = Nothing
        Me.xtxSuc_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxSuc_code.FieldDescription = ""
        Me.xtxSuc_code.FindInitialValue = Nothing
        Me.xtxSuc_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxSuc_code.IgnoreRequiered = False
        Me.xtxSuc_code.Location = New System.Drawing.Point(104, 120)
        Me.xtxSuc_code.Name = "xtxSuc_code"
        Me.xtxSuc_code.NewInitialValue = Nothing
        Me.xtxSuc_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxSuc_code.Requiered = False
        Me.xtxSuc_code.Size = New System.Drawing.Size(72, 20)
        Me.xtxSuc_code.StatusBarPanelDescripcion = Nothing
        Me.xtxSuc_code.TabIndex = 23
        Me.xtxSuc_code.Text = ""
        '
        'xcbo_tran_type
        '
        Me.xcbo_tran_type.AllowDefaultSort = True
        Me.xcbo_tran_type.bound = True
        Me.xcbo_tran_type.currValue = Nothing
        Me.xcbo_tran_type.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cgacctd.tran_type"))
        Me.xcbo_tran_type.DefaultWhereString = Nothing
        Me.xcbo_tran_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_tran_type.EditInitialValue = Nothing
        Me.xcbo_tran_type.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_tran_type.FieldDescription = ""
        Me.xcbo_tran_type.FindInitialValue = Nothing
        Me.xcbo_tran_type.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_tran_type.IgnoreRequiered = False
        Me.xcbo_tran_type.Location = New System.Drawing.Point(104, 96)
        Me.xcbo_tran_type.LookupKeyDisplayFields = "tran_descr"
        Me.xcbo_tran_type.LookupKeyField = "tran_type"
        Me.xcbo_tran_type.LookupTableName = "cgtrntpm"
        Me.xcbo_tran_type.Name = "xcbo_tran_type"
        Me.xcbo_tran_type.NewInitialValue = Nothing
        Me.xcbo_tran_type.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_tran_type.Requiered = False
        Me.xcbo_tran_type.Required = False
        Me.xcbo_tran_type.Size = New System.Drawing.Size(336, 21)
        Me.xcbo_tran_type.SqlString = Nothing
        Me.xcbo_tran_type.StatusBarPanelDescripcion = Nothing
        Me.xcbo_tran_type.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(9, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Tipo Documento:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xdt_FechaFinal
        '
        Me.xdt_FechaFinal.CustomFormat = "dd/MM/yyyy"
        Me.xdt_FechaFinal.EditInitialValue = Nothing
        Me.xdt_FechaFinal.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.FieldDescription = ""
        Me.xdt_FechaFinal.FindInitialValue = Nothing
        Me.xdt_FechaFinal.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaFinal.IgnoreRequiered = False
        Me.xdt_FechaFinal.Location = New System.Drawing.Point(104, 72)
        Me.xdt_FechaFinal.Name = "xdt_FechaFinal"
        Me.xdt_FechaFinal.NewInitialValue = Nothing
        Me.xdt_FechaFinal.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.Requiered = False
        Me.xdt_FechaFinal.Size = New System.Drawing.Size(88, 20)
        Me.xdt_FechaFinal.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaFinal.TabIndex = 20
        '
        'xdt_FechaInicial
        '
        Me.xdt_FechaInicial.CustomFormat = "dd/MM/yyyy"
        Me.xdt_FechaInicial.EditInitialValue = Nothing
        Me.xdt_FechaInicial.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicial.FieldDescription = ""
        Me.xdt_FechaInicial.FindInitialValue = Nothing
        Me.xdt_FechaInicial.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaInicial.IgnoreRequiered = False
        Me.xdt_FechaInicial.Location = New System.Drawing.Point(104, 48)
        Me.xdt_FechaInicial.Name = "xdt_FechaInicial"
        Me.xdt_FechaInicial.NewInitialValue = Nothing
        Me.xdt_FechaInicial.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicial.Requiered = False
        Me.xdt_FechaInicial.Size = New System.Drawing.Size(88, 20)
        Me.xdt_FechaInicial.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaInicial.TabIndex = 19
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
        Me.Label2.Location = New System.Drawing.Point(18, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Periodo Actual:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(28, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha Inicial:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(32, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha Final:"
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
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 255)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(560, 23)
        Me.ProgressBar1.TabIndex = 13
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"acct_no=acct_no", "labacct_no=acct_name"}
        Me.LibXLookup2.FilterField = "acct_name"
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(425, 144)
        Me.LibXLookup2.LookCaption = "Cuentas"
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
        Me.LibXLookup2.SrcParameters = New String() {"acct_no=acct_no"}
        Me.LibXLookup2.TabIndex = 30
        Me.LibXLookup2.TableName = "cgacctm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Cuenta=acct_no", "Nombre=acct_name"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'labacct_no
        '
        Me.labacct_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labacct_no.Location = New System.Drawing.Point(176, 144)
        Me.labacct_no.Name = "labacct_no"
        Me.labacct_no.Size = New System.Drawing.Size(248, 20)
        Me.labacct_no.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(55, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Cuenta:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgacctd.acct_no"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(104, 144)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(72, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 27
        Me.XTextBox2.Text = ""
        '
        'r_tranr05
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 278)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Name = "r_tranr05"
        Me.Text = "Movimientos por Cuentas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
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
        Try
            Me.LibXConnector1.AcceptFind()
            Me.LibXConnector1.Find()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("Seguro desea cerrar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim oReport As LibX.ReportLib
        Dim SQLString As String
        Dim WhereString As String
        Dim Scuenta As String
        Dim SacctNo As String
        Try

            If txtperdr_num.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgtranrm.perdr_num = " & txtperdr_num.Text)
            End If

            If txtPerdr_year.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgtranrm.perdr_year= " & txtPerdr_year.Text)
            End If

            If xcbo_tran_type.SelectedValue.ToString.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgtranrm.tran_type = " & xcbo_tran_type.SelectedValue & "'")
            End If

            If Not LibX.IsNull(e.row!acct_no) Then
                SacctNo = e.row!acct_no.ToString
            End If

            If SacctNo <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgtranrd.acct_no = " & SacctNo)
            End If

            If Val(Me.xtxSuc_code.Text) > 0 Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgtranrm.suc_code = " & Val(Me.xtxSuc_code.Text))
            End If


            ''WhereString = LibX.ConcatWherePart(WhereString, "cgtranrm.tran_date between '" & _
            ''                                CDate(xdt_FechaInicial.Value).ToString(LibX.Data.Manager.GetSaveDateFormat) & _
            ''                                "' and '" & CDate(xdt_FechaFinal.Value).ToString(LibX.Data.Manager.GetSaveDateFormat) & "'")

            oReport = New LibX.ReportLib("CTG", "r_tranrp05.rpt")

            oReport.RetrieveSQLQuery()
            SQLString = oReport.SQLQuery
            SQLString = LibX.ConcatWherePart(SQLString, WhereString)
            oReport.SQLQuery = SQLString

            oReport.ParameterFields(0) = String.Concat("p_FechaInicial;", Trim(xdt_FechaInicial.Value), ";TRUE")
            oReport.ParameterFields(1) = String.Concat("p_FechaFinal;", Trim(xdt_FechaFinal.Value), ";TRUE")

            oReport.Action = 1

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xdt_FechaInicial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xdt_FechaInicial.ValueChanged

        Try

            oPeriodo = New Periodo

            oPeriodo = oAnoFiscal.BuscarPeriodoPorFecha(Me.xdt_FechaInicial.Text)
            If oPeriodo.year = Nothing Then
                Throw New ApplicationException("No existen periodo para este año!")
            End If

            LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year
            LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number

            txtPerdr_year.Text = oPeriodo.year.ToString
            txtperdr_num.Text = oPeriodo.Number.ToString
            xdt_FechaFinal.Text = oPeriodo.Thru

            LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year.ToString
            LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number.ToString

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class
