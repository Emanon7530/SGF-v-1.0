Public Class i_sgferrorm01
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
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents XTextBox9 As LibX.XTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents xtxt_err_date As LibX.LibxDateTimePicker
    Friend WithEvents xtxt_Corr_date As LibX.LibxDateTimePicker
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents XTextBox4 As LibX.XTextBox
    Friend WithEvents XTextBox5 As LibX.XTextBox
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents xcbo_error_status As LibX.LibXCombo
    Friend WithEvents libxerror As System.Data.DataTable
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xcbo_error_status = New LibX.LibXCombo
        Me.DataSet1 = New System.Data.DataSet
        Me.libxerror = New System.Data.DataTable
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
        Me.XTextBox5 = New LibX.XTextBox
        Me.XTextBox4 = New LibX.XTextBox
        Me.XTextBox3 = New LibX.XTextBox
        Me.xtxt_Corr_date = New LibX.LibxDateTimePicker
        Me.xtxt_err_date = New LibX.LibxDateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.XTextBox9 = New LibX.XTextBox
        Me.XTextBox2 = New LibX.XTextBox
        Me.XTextBox1 = New LibX.XTextBox
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.libxerror, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xcbo_error_status)
        Me.GroupBox1.Controls.Add(Me.XTextBox5)
        Me.GroupBox1.Controls.Add(Me.XTextBox4)
        Me.GroupBox1.Controls.Add(Me.XTextBox3)
        Me.GroupBox1.Controls.Add(Me.xtxt_Corr_date)
        Me.GroupBox1.Controls.Add(Me.xtxt_err_date)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.XTextBox9)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(712, 336)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'xcbo_error_status
        '
        Me.xcbo_error_status.AllowDefaultSort = True
        Me.xcbo_error_status.bound = True
        Me.xcbo_error_status.currValue = Nothing
        Me.xcbo_error_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "libxerror.estado"))
        Me.xcbo_error_status.DefaultWhereString = Nothing
        Me.xcbo_error_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_error_status.EditInitialValue = Nothing
        Me.xcbo_error_status.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_error_status.FieldDescription = ""
        Me.xcbo_error_status.FindInitialValue = Nothing
        Me.xcbo_error_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_error_status.IgnoreRequiered = False
        Me.xcbo_error_status.Items.AddRange(New Object() {"2-Pendiente", "1-Corregido"})
        Me.xcbo_error_status.Location = New System.Drawing.Point(552, 72)
        Me.xcbo_error_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_error_status.LookupKeyField = Nothing
        Me.xcbo_error_status.LookupTableName = Nothing
        Me.xcbo_error_status.Name = "xcbo_error_status"
        Me.xcbo_error_status.NewInitialValue = Nothing
        Me.xcbo_error_status.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_error_status.Requiered = False
        Me.xcbo_error_status.Required = False
        Me.xcbo_error_status.Size = New System.Drawing.Size(88, 21)
        Me.xcbo_error_status.SqlString = Nothing
        Me.xcbo_error_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_error_status.TabIndex = 23
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.libxerror})
        '
        'libxerror
        '
        Me.libxerror.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10})
        Me.libxerror.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"error_id"}, True)})
        Me.libxerror.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.libxerror.TableName = "libxerror"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "error_id"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "program_name"
        Me.DataColumn2.MaxLength = 20
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "name_menu"
        Me.DataColumn3.MaxLength = 50
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "Error"
        Me.DataColumn4.MaxLength = 250
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "fecha_error"
        Me.DataColumn5.DataType = GetType(System.DateTime)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "Evento"
        Me.DataColumn6.MaxLength = 250
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "estado"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "fecha_corregido"
        Me.DataColumn8.DataType = GetType(System.DateTime)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "nota"
        Me.DataColumn9.MaxLength = 250
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "user_id"
        Me.DataColumn10.MaxLength = 20
        '
        'XTextBox5
        '
        Me.XTextBox5.AcceptsReturn = True
        Me.XTextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "libxerror.nota"))
        Me.XTextBox5.EditInitialValue = Nothing
        Me.XTextBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.FieldDescription = ""
        Me.XTextBox5.FindInitialValue = Nothing
        Me.XTextBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.IgnoreRequiered = False
        Me.XTextBox5.Location = New System.Drawing.Point(129, 252)
        Me.XTextBox5.Multiline = True
        Me.XTextBox5.Name = "XTextBox5"
        Me.XTextBox5.NewInitialValue = Nothing
        Me.XTextBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.Requiered = False
        Me.XTextBox5.Size = New System.Drawing.Size(320, 60)
        Me.XTextBox5.StatusBarPanelDescripcion = Nothing
        Me.XTextBox5.TabIndex = 22
        Me.XTextBox5.Text = ""
        '
        'XTextBox4
        '
        Me.XTextBox4.AcceptsReturn = True
        Me.XTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "libxerror.Evento"))
        Me.XTextBox4.EditInitialValue = Nothing
        Me.XTextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.FieldDescription = ""
        Me.XTextBox4.FindInitialValue = Nothing
        Me.XTextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.IgnoreRequiered = False
        Me.XTextBox4.Location = New System.Drawing.Point(129, 194)
        Me.XTextBox4.Multiline = True
        Me.XTextBox4.Name = "XTextBox4"
        Me.XTextBox4.NewInitialValue = Nothing
        Me.XTextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.Requiered = False
        Me.XTextBox4.Size = New System.Drawing.Size(320, 56)
        Me.XTextBox4.StatusBarPanelDescripcion = Nothing
        Me.XTextBox4.TabIndex = 21
        Me.XTextBox4.Text = ""
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "libxerror.Error"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(128, 96)
        Me.XTextBox3.Multiline = True
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(320, 96)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 20
        Me.XTextBox3.Text = ""
        '
        'xtxt_Corr_date
        '
        Me.xtxt_Corr_date.CustomFormat = "dd/MM/yyyy"
        Me.xtxt_Corr_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "libxerror.fecha_corregido"))
        Me.xtxt_Corr_date.EditInitialValue = Nothing
        Me.xtxt_Corr_date.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_Corr_date.Enabled = False
        Me.xtxt_Corr_date.FieldDescription = ""
        Me.xtxt_Corr_date.FindInitialValue = Nothing
        Me.xtxt_Corr_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Corr_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xtxt_Corr_date.IgnoreRequiered = False
        Me.xtxt_Corr_date.Location = New System.Drawing.Point(552, 96)
        Me.xtxt_Corr_date.Name = "xtxt_Corr_date"
        Me.xtxt_Corr_date.NewInitialValue = Nothing
        Me.xtxt_Corr_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Corr_date.Requiered = False
        Me.xtxt_Corr_date.Size = New System.Drawing.Size(88, 20)
        Me.xtxt_Corr_date.StatusBarPanelDescripcion = Nothing
        Me.xtxt_Corr_date.TabIndex = 19
        '
        'xtxt_err_date
        '
        Me.xtxt_err_date.CustomFormat = "dd/MM/yyyy"
        Me.xtxt_err_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "libxerror.fecha_error"))
        Me.xtxt_err_date.EditInitialValue = Nothing
        Me.xtxt_err_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_err_date.FieldDescription = ""
        Me.xtxt_err_date.FindInitialValue = Nothing
        Me.xtxt_err_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_err_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xtxt_err_date.IgnoreRequiered = False
        Me.xtxt_err_date.Location = New System.Drawing.Point(552, 48)
        Me.xtxt_err_date.Name = "xtxt_err_date"
        Me.xtxt_err_date.NewInitialValue = Nothing
        Me.xtxt_err_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_err_date.Requiered = False
        Me.xtxt_err_date.Size = New System.Drawing.Size(88, 20)
        Me.xtxt_err_date.StatusBarPanelDescripcion = Nothing
        Me.xtxt_err_date.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(480, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Tester:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(480, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Corregido:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(480, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Estado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(480, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Nota/Observacion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Evento del Error:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Error Generado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre del Menu:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre Programa:"
        '
        'XTextBox9
        '
        Me.XTextBox9.AcceptsReturn = True
        Me.XTextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "libxerror.user_id"))
        Me.XTextBox9.EditInitialValue = Nothing
        Me.XTextBox9.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.FieldDescription = ""
        Me.XTextBox9.FindInitialValue = Nothing
        Me.XTextBox9.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.IgnoreRequiered = False
        Me.XTextBox9.Location = New System.Drawing.Point(552, 120)
        Me.XTextBox9.Name = "XTextBox9"
        Me.XTextBox9.NewInitialValue = Nothing
        Me.XTextBox9.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.Requiered = False
        Me.XTextBox9.Size = New System.Drawing.Size(152, 20)
        Me.XTextBox9.StatusBarPanelDescripcion = Nothing
        Me.XTextBox9.TabIndex = 8
        Me.XTextBox9.Text = ""
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "libxerror.name_menu"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(128, 72)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(320, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 1
        Me.XTextBox2.Text = ""
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "libxerror.program_name"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(128, 48)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(144, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 0
        Me.XTextBox1.Text = ""
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
        Me.LibXConnector1.DataMember = "libxerror"
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
        Me.LibXDbSourceTable1.SerialColumnName = "error_id"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "libxerror"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(736, 24)
        Me.LibXNavigator1.TabIndex = 2
        '
        'i_sgferrorm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(736, 382)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "i_sgferrorm01"
        Me.Text = "Mantenimiento de Errores Generados"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.libxerror, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try

            Me.xtxt_err_date.Value = LibX.Data.Manager.Connection.GetDate()
            Me.xcbo_error_status.currValue = 2 '//Pendiente
            
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If LibXConnector1.HasRecords = True Then
                If Not e.row Is Nothing Then
                    If LibX.IsNull(e.row!estado) = False AndAlso e.row!estado = 1 Then '//Corregido
                        LibXConnector1.AllowDelete = False
                        LibXConnector1.AllowEdit = False
                    End If
                    If Me.xcbo_error_status.currValue = 1 Then
                        Me.xtxt_Corr_date.Value = LibX.Data.Manager.Connection.GetDate()
                    End If
                    LibXNavigator1.UpdateState()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try

            If e.Action = LibX.LibxConnectionActions.Find Or e.Action = LibX.LibxConnectionActions.Add Then
                Me.xcbo_error_status.currValue = 2 '//Pendiente
            End If
            If e.Action = LibX.LibxConnectionActions.Add Then
                Me.xtxt_Corr_date.Enabled = False
            End If
            If Me.xcbo_error_status.currValue = 1 Then
                Me.xtxt_Corr_date.Value = LibX.Data.Manager.Connection.GetDate()
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub



End Class
