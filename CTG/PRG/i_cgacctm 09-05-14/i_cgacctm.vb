Public Class i_cgacctm
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
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As LibX.XTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As LibX.XTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
    Friend WithEvents txtacct_name As LibX.XTextBox
    Friend WithEvents rdb_Debito As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Credito As System.Windows.Forms.RadioButton
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents txtNivel As LibX.XTextBox
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents lblAno As System.Windows.Forms.Label
    Friend WithEvents xcbo_acct_type As LibX.LibXCombo
    Friend WithEvents xlk_acct_control As LibX.LibXLookup
    Friend WithEvents xtxAcct_no As LibX.XTextBox
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents ButtonMov As System.Windows.Forms.Button
    Friend WithEvents btnMov As System.Windows.Forms.Button
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataTable3 = New System.Data.DataTable
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.lblAno = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNivel = New LibX.XTextBox
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.xlk_acct_control = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.rdb_Debito = New System.Windows.Forms.RadioButton
        Me.xcbo_acct_type = New LibX.LibXCombo
        Me.xtxAcct_no = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.rdb_Credito = New System.Windows.Forms.RadioButton
        Me.TextBox3 = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtacct_name = New LibX.XTextBox
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.btnMov = New System.Windows.Forms.Button
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable3})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn19})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"acct_no"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "cgacctm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "acct_no"
        Me.DataColumn1.MaxLength = 20
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "acct_type"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "acct_name"
        Me.DataColumn3.MaxLength = 60
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "acct_origen"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "acct_contrl"
        Me.DataColumn5.MaxLength = 20
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "acct_nivel"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "acct_detl"
        Me.DataColumn7.MaxLength = 1
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "acct_isctrl"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn8, Me.DataColumn9})
        Me.DataTable3.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"perdr_num", "perdr_year"}, True)})
        Me.DataTable3.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn21, Me.DataColumn22}
        Me.DataTable3.TableName = "cgmovacct"
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
        Me.DataColumn21.ColumnName = "perdr_num"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "perdr_year"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "initial"
        Me.DataColumn23.DataType = GetType(System.Decimal)
        Me.DataColumn23.ReadOnly = True
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "debit_amount"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        Me.DataColumn24.ReadOnly = True
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "credit_amount"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        Me.DataColumn25.ReadOnly = True
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "balance"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        Me.DataColumn26.ReadOnly = True
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "from_date"
        Me.DataColumn8.DataType = GetType(System.DateTime)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "thru_date"
        Me.DataColumn9.DataType = GetType(System.DateTime)
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
        Me.LibXDbSourceTable1.SerialColumnName = ""
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cgacctm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtNivel)
        Me.GroupBox1.Controls.Add(Me.LibxCheckBox1)
        Me.GroupBox1.Controls.Add(Me.xlk_acct_control)
        Me.GroupBox1.Controls.Add(Me.rdb_Debito)
        Me.GroupBox1.Controls.Add(Me.xcbo_acct_type)
        Me.GroupBox1.Controls.Add(Me.xtxAcct_no)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.rdb_Credito)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtacct_name)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 160)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPeriodo)
        Me.GroupBox2.Controls.Add(Me.lblAno)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(514, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(160, 144)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información Actual:"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblPeriodo.Location = New System.Drawing.Point(112, 19)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(40, 20)
        Me.lblPeriodo.TabIndex = 11
        '
        'lblAno
        '
        Me.lblAno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAno.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblAno.Location = New System.Drawing.Point(56, 19)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(48, 20)
        Me.lblAno.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgmovacct.balance"))
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(56, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 20)
        Me.Label15.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgmovacct.credit_amount"))
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(56, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 20)
        Me.Label14.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgmovacct.debit_amount"))
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(56, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 20)
        Me.Label13.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgmovacct.initial"))
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(56, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 20)
        Me.Label12.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(4, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Balance:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(8, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Credito:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(12, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Debito:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(16, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Inicial:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(6, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Periodo:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNivel
        '
        Me.txtNivel.AcceptsReturn = True
        Me.txtNivel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgacctm.acct_nivel"))
        Me.txtNivel.EditInitialValue = Nothing
        Me.txtNivel.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtNivel.FieldDescription = ""
        Me.txtNivel.FindInitialValue = Nothing
        Me.txtNivel.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtNivel.IgnoreRequiered = False
        Me.txtNivel.Location = New System.Drawing.Point(424, 72)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.NewInitialValue = Nothing
        Me.txtNivel.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtNivel.Requiered = False
        Me.txtNivel.Size = New System.Drawing.Size(72, 20)
        Me.txtNivel.StatusBarPanelDescripcion = Nothing
        Me.txtNivel.TabIndex = 3
        Me.txtNivel.Text = ""
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "cgacctm.acct_isctrl"))
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(332, 96)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = Nothing
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = False
        Me.LibxCheckBox1.Size = New System.Drawing.Size(104, 16)
        Me.LibxCheckBox1.TabIndex = 6
        Me.LibxCheckBox1.Text = "Cuenta Control?"
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'xlk_acct_control
        '
        Me.xlk_acct_control.AlternateFieldSearch = Nothing
        Me.xlk_acct_control.BeginCheck = False
        Me.xlk_acct_control.CheckText = Nothing
        Me.xlk_acct_control.ComboMode = False
        Me.xlk_acct_control.DataMember = Nothing
        Me.xlk_acct_control.DataSource = Me.LibXConnector1
        Me.xlk_acct_control.DestParameters = New String() {"acct_contrl=acct_no", "txtacct_name=acct_name"}
        Me.xlk_acct_control.FilterField = "acct_name"
        Me.xlk_acct_control.IgnoreFindInBrowseMode = False
        Me.xlk_acct_control.isCanceled = False
        Me.xlk_acct_control.Location = New System.Drawing.Point(480, 120)
        Me.xlk_acct_control.LookCaption = Nothing
        Me.xlk_acct_control.Name = "xlk_acct_control"
        Me.xlk_acct_control.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_acct_control.ShowFilter = True
        Me.xlk_acct_control.ShowMessageNotFound = True
        Me.xlk_acct_control.ShowWarning = False
        Me.xlk_acct_control.Size = New System.Drawing.Size(16, 20)
        Me.xlk_acct_control.SizesColumns = Nothing
        Me.xlk_acct_control.SizesColumnsTab = Nothing
        Me.xlk_acct_control.SqlString = New String() {"select * from cgacctm"}
        Me.xlk_acct_control.SQLTab = Nothing
        Me.xlk_acct_control.SrcParameters = New String() {"acct_contrl=acct_no"}
        Me.xlk_acct_control.TabIndex = 7
        Me.xlk_acct_control.TableName = "cgacctm"
        Me.xlk_acct_control.TabStop = False
        Me.xlk_acct_control.UseCopyConnection = False
        Me.xlk_acct_control.UseRowRetrieveEvents = False
        Me.xlk_acct_control.UseTab = False
        Me.xlk_acct_control.VisParameters = New String() {"Número de Cuenta=acct_no", "Nombre=acct_name"}
        Me.xlk_acct_control.WhereCondition = "acct_isctrl = 1"
        Me.xlk_acct_control.WhereParameters = Nothing
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = True
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "cgacctm"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable3})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
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
        Me.LibXDbSourceTable3.SerialColumnName = Nothing
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = Nothing
        Me.LibXDbSourceTable3.TableName = "cgmovacct"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'rdb_Debito
        '
        Me.rdb_Debito.Location = New System.Drawing.Point(112, 96)
        Me.rdb_Debito.Name = "rdb_Debito"
        Me.rdb_Debito.Size = New System.Drawing.Size(64, 16)
        Me.rdb_Debito.TabIndex = 4
        Me.rdb_Debito.Text = "Débito"
        '
        'xcbo_acct_type
        '
        Me.xcbo_acct_type.AllowDefaultSort = True
        Me.xcbo_acct_type.bound = True
        Me.xcbo_acct_type.currValue = Nothing
        Me.xcbo_acct_type.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cgacctm.acct_type"))
        Me.xcbo_acct_type.DefaultWhereString = Nothing
        Me.xcbo_acct_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_acct_type.EditInitialValue = Nothing
        Me.xcbo_acct_type.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_acct_type.FieldDescription = ""
        Me.xcbo_acct_type.FindInitialValue = Nothing
        Me.xcbo_acct_type.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_acct_type.IgnoreRequiered = False
        Me.xcbo_acct_type.Location = New System.Drawing.Point(112, 72)
        Me.xcbo_acct_type.LookupKeyDisplayFields = "type_descr"
        Me.xcbo_acct_type.LookupKeyField = "acct_type"
        Me.xcbo_acct_type.LookupTableName = "cgacctpm"
        Me.xcbo_acct_type.Name = "xcbo_acct_type"
        Me.xcbo_acct_type.NewInitialValue = Nothing
        Me.xcbo_acct_type.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_acct_type.Requiered = True
        Me.xcbo_acct_type.Required = True
        Me.xcbo_acct_type.Size = New System.Drawing.Size(176, 21)
        Me.xcbo_acct_type.SqlString = Nothing
        Me.xcbo_acct_type.StatusBarPanelDescripcion = Nothing
        Me.xcbo_acct_type.TabIndex = 2
        '
        'xtxAcct_no
        '
        Me.xtxAcct_no.AcceptsReturn = True
        Me.xtxAcct_no.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgacctm.acct_no"))
        Me.xtxAcct_no.EditInitialValue = Nothing
        Me.xtxAcct_no.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxAcct_no.FieldDescription = ""
        Me.xtxAcct_no.FindInitialValue = Nothing
        Me.xtxAcct_no.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxAcct_no.IgnoreRequiered = False
        Me.xtxAcct_no.Location = New System.Drawing.Point(112, 24)
        Me.xtxAcct_no.Name = "xtxAcct_no"
        Me.xtxAcct_no.NewInitialValue = Nothing
        Me.xtxAcct_no.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxAcct_no.Requiered = False
        Me.xtxAcct_no.Size = New System.Drawing.Size(96, 20)
        Me.xtxAcct_no.StatusBarPanelDescripcion = Nothing
        Me.xtxAcct_no.TabIndex = 0
        Me.xtxAcct_no.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(20, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número Cuenta:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgacctm.acct_name"))
        Me.TextBox2.EditInitialValue = Nothing
        Me.TextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.FieldDescription = ""
        Me.TextBox2.FindInitialValue = Nothing
        Me.TextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.IgnoreRequiered = False
        Me.TextBox2.Location = New System.Drawing.Point(112, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.NewInitialValue = Nothing
        Me.TextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.Requiered = False
        Me.TextBox2.Size = New System.Drawing.Size(384, 20)
        Me.TextBox2.StatusBarPanelDescripcion = Nothing
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(59, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(22, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo de Cuenta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(384, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nivel:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(66, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Origen:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'rdb_Credito
        '
        Me.rdb_Credito.Location = New System.Drawing.Point(192, 96)
        Me.rdb_Credito.Name = "rdb_Credito"
        Me.rdb_Credito.Size = New System.Drawing.Size(64, 16)
        Me.rdb_Credito.TabIndex = 5
        Me.rdb_Credito.Text = "Crédito"
        '
        'TextBox3
        '
        Me.TextBox3.AcceptsReturn = True
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgacctm.acct_contrl"))
        Me.TextBox3.EditInitialValue = Nothing
        Me.TextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.FieldDescription = ""
        Me.TextBox3.FindInitialValue = Nothing
        Me.TextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.IgnoreRequiered = False
        Me.TextBox3.Location = New System.Drawing.Point(112, 120)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.NewInitialValue = Nothing
        Me.TextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.Requiered = False
        Me.TextBox3.Size = New System.Drawing.Size(96, 20)
        Me.TextBox3.StatusBarPanelDescripcion = Nothing
        Me.TextBox3.TabIndex = 7
        Me.TextBox3.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(24, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cuenta Control:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtacct_name
        '
        Me.txtacct_name.AcceptsReturn = True
        Me.txtacct_name.EditInitialValue = Nothing
        Me.txtacct_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtacct_name.FieldDescription = ""
        Me.txtacct_name.FindInitialValue = Nothing
        Me.txtacct_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtacct_name.IgnoreRequiered = False
        Me.txtacct_name.Location = New System.Drawing.Point(216, 120)
        Me.txtacct_name.Name = "txtacct_name"
        Me.txtacct_name.NewInitialValue = Nothing
        Me.txtacct_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtacct_name.ReadOnly = True
        Me.txtacct_name.Requiered = False
        Me.txtacct_name.Size = New System.Drawing.Size(264, 20)
        Me.txtacct_name.StatusBarPanelDescripcion = Nothing
        Me.txtacct_name.TabIndex = 1
        Me.txtacct_name.TabStop = False
        Me.txtacct_name.Text = ""
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(704, 24)
        Me.LibXNavigator1.TabIndex = 1
        '
        'btnMov
        '
        Me.btnMov.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMov.Location = New System.Drawing.Point(8, 200)
        Me.btnMov.Name = "btnMov"
        Me.btnMov.Size = New System.Drawing.Size(80, 32)
        Me.btnMov.TabIndex = 4
        Me.btnMov.Text = "Movimientos"
        '
        'i_cgacctm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 262)
        Me.Controls.Add(Me.btnMov)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "i_cgacctm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Catalogo de cuentas"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim mWhere As String
    Dim oPeriodo As SGT.Contabilidad.Entidades.Periodo
    Dim oAnoFiscal As SGT.Contabilidad.Entidades.AnoFiscal
    Dim oCuenta As SGT.Contabilidad.Entidades.Cuenta

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As System.Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            If e.Action = LibX.LibxConnectionActions.Add Then
                rdb_Credito.Enabled = True
                rdb_Debito.Enabled = True
                txtNivel.Enabled = False
            End If

                If e.Action = LibX.LibxConnectionActions.Find Then
                    rdb_Credito.Checked = False
                    rdb_Debito.Checked = False
                End If

                If e.AcceptedAction = LibX.LibxConnectionActions.Find Then
                    If rdb_Credito.Checked = True Then
                        LibXConnector1.CurrentDataRow!acct_origen = -1
                    End If

                    If rdb_Debito.Checked = True Then
                        LibXConnector1.CurrentDataRow!acct_origen = 1
                    End If
                End If
                If e.Action = LibX.LibxConnectionActions.Edit Then
                    Me.xtxAcct_no.Enabled = False
                Else
                    Me.xtxAcct_no.Enabled = True
                End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As System.Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then
                If rdb_Debito.Checked = True Then
                    e.UpdatingArgs.Row!acct_origen = 1
                End If

                If rdb_Credito.Checked = True Then
                    e.UpdatingArgs.Row!acct_origen = -1
                End If
                If Not LibX.IsNull(e.UpdatingArgs.Row!acct_contrl) Then
                    If ConsultarTipo(e.UpdatingArgs.Row!acct_contrl) = False Then
                        e.UpdatingArgs.Row!acct_nivel = Actualizar(e.UpdatingArgs.Row!acct_contrl)
                        'Else
                        '    e.UpdatingArgs.Row!acct_nivel = 1
                    End If
                End If
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub LibXConnector1_ChangeState(ByVal sender As System.Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try
            If LibXConnector1.IsEditing = True And LibXConnector1.HasRecords = True Then
                If Not LibX.IsNull(LibXConnector1.CurrentDataRow!acct_no) Then
                    If ConsultarMovimientos(LibXConnector1.CurrentDataRow!acct_no) = False Then
                        rdb_Credito.Enabled = e.isEditing
                        rdb_Debito.Enabled = e.isEditing
                        LibxCheckBox1.Enabled = e.isEditing
                        xcbo_acct_type.Enabled = e.isEditing
                        xlk_acct_control.Enabled = True
                        TextBox3.Enabled = True
                    Else
                        rdb_Credito.Enabled = False
                        rdb_Debito.Enabled = False
                        LibxCheckBox1.Enabled = False
                        xcbo_acct_type.Enabled = False
                        xcbo_acct_type.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
                        xlk_acct_control.Enabled = False
                        TextBox3.Enabled = False
                    End If
                End If
            Else
                rdb_Credito.Enabled = e.isEditing
                rdb_Debito.Enabled = e.isEditing
                LibxCheckBox1.Enabled = e.isEditing
                xcbo_acct_type.Enabled = e.isEditing
                xlk_acct_control.Enabled = True
                TextBox3.Enabled = True
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub rdb_Debito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rdb_Debito.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(27) Then
            rdb_Debito.Checked = False
        End If
    End Sub
    Private Sub rdb_Credito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rdb_Credito.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(27) Then
            rdb_Credito.Checked = False
        End If
    End Sub

    Private Sub LibXConnector1_RowChange(ByVal sender As System.Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange
        Try
            If Not LibXConnector1.CurrentDataRow Is Nothing Then
                If LibXConnector1.CurrentDataRow!acct_origen.ToString.Trim = "1" Then
                    rdb_Debito.Checked = True
                End If

                If LibXConnector1.CurrentDataRow!acct_origen.ToString.Trim = "-1" Then
                    rdb_Credito.Checked = True
                End If
                If LibXConnector1.CurrentDataRow!acct_origen.ToString.Trim = "0" Then
                    rdb_Credito.Checked = False
                    rdb_Debito.Checked = False
                End If
            End If

            If LibXConnector1.IsEditing = False And LibXConnector1.HasRecords = True Then
                If ConsultarMovimientos(LibXConnector1.CurrentDataRow!acct_no.ToString.Trim) = True Then
                    LibXConnector1.AllowDelete = False
                Else
                    LibXConnector1.AllowDelete = True
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As System.Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        mWhere = e.Where
    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Dim oReport As LibX.ReportLib
        Dim SelecStmt As String
        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
                oReport = New LibX.ReportLib("CTG", "r_acctrp01.rpt")
                With oReport
                    .RetrieveSQLQuery()
                    SelecStmt = .SQLQuery
                    'SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, mWhere)
                    .SQLQuery = SelecStmt

                    '// Ejecutar el reporte
                    .Action = 1
                End With
            End If
            If e.ButtonAction = XMsaComponents.XmsaButtons.Next _
            Or (e.ButtonAction = XMsaComponents.XmsaButtons.Prev) _
            Or (e.ButtonAction = XMsaComponents.XmsaButtons.First) _
            Or (e.ButtonAction = XMsaComponents.XmsaButtons.Last) Then
                Me.xlk_acct_control.ExecuteFind()
            End If
            If LibXConnector1.HasRecords = True Then
                If ConsultarMovimientos(LibXConnector1.CurrentDataRow!acct_no.ToString.Trim) = True Then
                    Me.btnMov.Enabled = True
                Else
                    Me.btnMov.Enabled = False
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

#Region "Metodos"
    Private Function Actualizar(ByVal pacct_no As String) As Integer
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim XSelect As LibX.Data.XSelecStmt
        Dim oRow As DataRow
        Dim Nivel As Integer
        Try
            XUpdate = New LibX.Data.XUpdateStmt("cgacctm")
            XSelect = New LibX.Data.XSelecStmt("cgacctm")

            XSelect.Parameters.Add("acct_no", pacct_no)
            oRow = XSelect.GetDataRow()

            If oRow Is Nothing Then
                Throw New ApplicationException("No se encontró la cuenta padre")
            End If

            'XUpdate.FieldsSet("acct_detl") = 0
            XUpdate.FieldsSet("acct_isctrl") = 1
            XUpdate.Fields("acct_no") = pacct_no
            XUpdate.Execute()

            Nivel = Val(oRow!acct_nivel.ToString.Trim) + 1

            Return Nivel

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Function
#End Region

    Private Sub i_cgacctm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oPeriodo = New SGT.Contabilidad.Entidades.Periodo
        oCuenta = New SGT.Contabilidad.Entidades.Cuenta
        oAnoFiscal = New SGT.Contabilidad.Entidades.AnoFiscal

        oPeriodo = oAnoFiscal.BuscarPeriodoActual

        lblAno.Text = oPeriodo.year.ToString
        lblPeriodo.Text = oPeriodo.Number.ToString
        '''LibXGrid1.footerOperations.add("perdr_num", "count(perdr_num)")
        ''''LibXGrid1.footerOperations.add("initial", "sum(initial)")
        '''LibXGrid1.footerOperations.add("debit_amount", "sum(debit_amount)")
        '''LibXGrid1.footerOperations.add("credit_amount", "sum(credit_amount)")
        ''''LibXGrid1.footerOperations.add("balance", "sum(balance)")
    End Sub

    ''Private Sub LibXConnector1_BeforeLoadDetail(ByVal sender As System.Object, ByVal e As LibX.XbeforeLoadDetailEventArgs) Handles LibXConnector1.BeforeLoadDetail
    ''    e.AditionalWhere = "cgacctd.perdr_year = " & oPeriodo.year.ToString
    ''End Sub
    Private Sub LibXLookup1_BeforeExecuteQuery(ByVal sender As System.Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_acct_control.BeforeExecuteQuery
        Try
            If LibXConnector1.IsDataEditing = True Then
                If LibX.IsNull(xcbo_acct_type.currValue) = False Then
                    e.aditionalWhere = "acct_type = " & LibXConnector1.CurrentDataRow!acct_type.ToString.Trim
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Function ConsultarMovimientos(ByVal pacct_no As String) As Boolean
        Dim XSelect As LibX.Data.XSelecStmt
        Dim oRow As DataRow
        Dim Find As Boolean
        Try

            XSelect = New LibX.Data.XSelecStmt("cgacctd")

            XSelect.Parameters.Add("acct_no", pacct_no)
            oRow = XSelect.GetDataRow()

            If oRow Is Nothing Then
                Find = False
            Else
                Find = True
            End If

            Return Find

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Function
    Private Function ConsultarTipo(ByVal pacct_no As String) As Boolean
        Dim XSelect As LibX.Data.XSelecStmt
        Dim oRow As DataRow
        Dim Find As Boolean
        Try

            XSelect = New LibX.Data.XSelecStmt("cgacctm")

            XSelect.Parameters.Add("acct_no", pacct_no)
            oRow = XSelect.GetDataRow()

            If LibX.IsNull(oRow!acct_isctrl) Or oRow!acct_isctrl = 0 Then
                Find = False
            Else
                Find = True
            End If

            Return Find

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Function

    Private Sub LibXConnector1_InsertedRow(ByVal sender As System.Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedRow
        If e.UpdatingArgs.StatementType = StatementType.Insert _
                      Or e.UpdatingArgs.StatementType = StatementType.Update Then
            If LibX.IsNull(e.UpdatingArgs.Row!acct_no) Then
                e.UpdatingArgs.Row.AcceptChanges()
            End If
        End If
    End Sub

    Private Sub btnMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMov.Click
        Dim oParam As LibX.LibxPrgParams

        Dim WhereStmt As String
        Try
            oParam = New LibX.LibxPrgParams

            oParam.WhereToExecute = "cgacctd.acct_no = " & LibXConnector1.CurrentDataRow!acct_no.ToString
            LibX.App.CurrentPrgParams = oParam

            LibX.LibXRunner.Run("c_cgacctm", "CTG", True)
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xlk_acct_control_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_acct_control.AfterSetValues
        'If LibXConnector1.IsDataEditing = True Then
        Me.txtNivel.Text = e.row!acct_nivel + 1
        'End If
    End Sub

    Private Sub rdb_Debito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Debito.CheckedChanged
        If rdb_Debito.Checked = True Then
            rdb_Credito.Checked = False
        End If
    End Sub

    Private Sub rdb_Credito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Credito.CheckedChanged
        If rdb_Credito.Checked = True Then
            rdb_Debito.Checked = False
        End If
    End Sub
End Class


