Public Class Form1
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents LibxDateTimePicker2 As LibX.LibxDateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents LibXCombo2 As LibX.LibXCombo
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup4 As LibX.LibXLookup
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XDataGridLinkColumn1 As LibX.XDataGridLinkColumn
    Friend WithEvents XDataGridLinkColumn2 As LibX.XDataGridLinkColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents XDataGridLinkColumn3 As LibX.XDataGridLinkColumn
    Friend WithEvents XDataGridLinkColumn4 As LibX.XDataGridLinkColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents XDataGridLinkColumn5 As LibX.XDataGridLinkColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents fecini As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
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
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents ftfactd As System.Data.DataTable
    Friend WithEvents ftfactm As System.Data.DataTable
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXCombo2 = New LibX.LibXCombo
        Me.DataSet1 = New System.Data.DataSet
        Me.ftfactd = New System.Data.DataTable
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
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.fecini = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LibxDateTimePicker2 = New LibX.LibxDateTimePicker
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.LibXLookup4 = New LibX.LibXLookup
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XDataGridLinkColumn1 = New LibX.XDataGridLinkColumn
        Me.XDataGridLinkColumn2 = New LibX.XDataGridLinkColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.XDataGridLinkColumn3 = New LibX.XDataGridLinkColumn
        Me.XDataGridLinkColumn4 = New LibX.XDataGridLinkColumn
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.XDataGridLinkColumn5 = New LibX.XDataGridLinkColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.ftfactm = New System.Data.DataTable
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
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LibXCombo2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LibXLookup2)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.LibXLookup3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.LibXLookup4)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.TextBox11)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio"
        '
        'LibXCombo2
        '
        Me.LibXCombo2.AllowDefaultSort = True
        Me.LibXCombo2.bound = True
        Me.LibXCombo2.currValue = Nothing
        Me.LibXCombo2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.fact_status"))
        Me.LibXCombo2.DefaultWhereString = Nothing
        Me.LibXCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo2.EditInitialValue = Nothing
        Me.LibXCombo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.FindInitialValue = Nothing
        Me.LibXCombo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.IgnoreRequiered = False
        Me.LibXCombo2.Location = New System.Drawing.Point(448, 40)
        Me.LibXCombo2.LookupKeyDisplayFields = Nothing
        Me.LibXCombo2.LookupKeyField = Nothing
        Me.LibXCombo2.LookupTableName = Nothing
        Me.LibXCombo2.Name = "LibXCombo2"
        Me.LibXCombo2.NewInitialValue = Nothing
        Me.LibXCombo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.Requiered = False
        Me.LibXCombo2.Required = False
        Me.LibXCombo2.Size = New System.Drawing.Size(121, 21)
        Me.LibXCombo2.SqlString = Nothing
        Me.LibXCombo2.TabIndex = 15
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftfactd, Me.ftfactm})
        '
        'ftfactd
        '
        Me.ftfactd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.fecini, Me.DataColumn31})
        Me.ftfactd.TableName = "ftfactd"
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "type_code"
        Me.DataColumn16.MaxLength = 3
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.ColumnName = "fact_number"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "fact_date"
        Me.DataColumn18.DataType = GetType(System.DateTime)
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "fact_status"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "phone"
        Me.DataColumn20.MaxLength = 8
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "cust_code"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "serie_number"
        Me.DataColumn22.MaxLength = 255
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "vend_code"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "item_code"
        Me.DataColumn24.MaxLength = 15
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "bus_name"
        Me.DataColumn25.MaxLength = 40
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "cust_name"
        Me.DataColumn26.MaxLength = 60
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "item_name"
        Me.DataColumn27.MaxLength = 100
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "price"
        Me.DataColumn28.DataType = GetType(System.Decimal)
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "fact_total"
        Me.DataColumn29.DataType = GetType(System.Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "fact_cond"
        Me.DataColumn30.DataType = GetType(System.Int16)
        '
        'fecini
        '
        Me.fecini.ColumnName = "FechaIni"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "FechaFin"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(576, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(72, 16)
        Me.RadioButton1.TabIndex = 14
        Me.RadioButton1.Text = "Contado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(64, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Documento:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.type_code"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Location = New System.Drawing.Point(136, 16)
        Me.LibXCombo1.LookupKeyDisplayFields = "type_name"
        Me.LibXCombo1.LookupKeyField = "type_code"
        Me.LibXCombo1.LookupTableName = "ivtypem"
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(432, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(400, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Fecha Final:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(56, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fecha Inicial:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibxDateTimePicker2
        '
        Me.LibxDateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.FechaFin"))
        Me.LibxDateTimePicker2.EditInitialValue = Nothing
        Me.LibxDateTimePicker2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker2.FindInitialValue = Nothing
        Me.LibxDateTimePicker2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker2.IgnoreRequiered = False
        Me.LibxDateTimePicker2.Location = New System.Drawing.Point(472, 136)
        Me.LibxDateTimePicker2.Name = "LibxDateTimePicker2"
        Me.LibxDateTimePicker2.NewInitialValue = Nothing
        Me.LibxDateTimePicker2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker2.Requiered = False
        Me.LibxDateTimePicker2.Size = New System.Drawing.Size(96, 20)
        Me.LibxDateTimePicker2.TabIndex = 9
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.FechaIni"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = False
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(136, 136)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = Nothing
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Requiered = False
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.LibxDateTimePicker1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(24, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cliente de Contado:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(40, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cliente a Cédito:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXLookup2
        '
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Nothing
        Me.LibXLookup2.DestParameters = Nothing
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.Location = New System.Drawing.Point(552, 112)
        Me.LibXLookup2.LookCaption = Nothing
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.ShowMessageNotFound = True
        Me.LibXLookup2.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup2.SqlString = Nothing
        Me.LibXLookup2.SrcParameters = Nothing
        Me.LibXLookup2.TabIndex = 5
        Me.LibXLookup2.TableName = Nothing
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.VisParameters = Nothing
        Me.LibXLookup2.WhereCondition = Nothing
        '
        'LibXLookup1
        '
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Nothing
        Me.LibXLookup1.DestParameters = Nothing
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.Location = New System.Drawing.Point(552, 88)
        Me.LibXLookup1.LookCaption = Nothing
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SrcParameters = Nothing
        Me.LibXLookup1.TabIndex = 4
        Me.LibXLookup1.TableName = Nothing
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.VisParameters = Nothing
        Me.LibXLookup1.WhereCondition = Nothing
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.bus_name"))
        Me.TextBox3.Location = New System.Drawing.Point(240, 112)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(312, 20)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.phone"))
        Me.TextBox4.Location = New System.Drawing.Point(136, 112)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(96, 20)
        Me.TextBox4.TabIndex = 2
        Me.TextBox4.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(200, 88)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(352, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.cust_code"))
        Me.TextBox1.Location = New System.Drawing.Point(136, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.item_name"))
        Me.TextBox5.Location = New System.Drawing.Point(288, 160)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(264, 20)
        Me.TextBox5.TabIndex = 3
        Me.TextBox5.Text = ""
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.item_code"))
        Me.TextBox6.Location = New System.Drawing.Point(136, 160)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(144, 20)
        Me.TextBox6.TabIndex = 2
        Me.TextBox6.Text = ""
        '
        'LibXLookup3
        '
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Nothing
        Me.LibXLookup3.DestParameters = Nothing
        Me.LibXLookup3.FilterField = Nothing
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.Location = New System.Drawing.Point(552, 160)
        Me.LibXLookup3.LookCaption = Nothing
        Me.LibXLookup3.Name = "LibXLookup3"
        Me.LibXLookup3.ShowMessageNotFound = True
        Me.LibXLookup3.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup3.SqlString = Nothing
        Me.LibXLookup3.SrcParameters = Nothing
        Me.LibXLookup3.TabIndex = 5
        Me.LibXLookup3.TableName = Nothing
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.VisParameters = Nothing
        Me.LibXLookup3.WhereCondition = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(72, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Producto:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(48, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Serie Número:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.serie_number"))
        Me.TextBox7.Location = New System.Drawing.Point(136, 184)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(184, 20)
        Me.TextBox7.TabIndex = 2
        Me.TextBox7.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(392, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Precio Venta:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.price"))
        Me.TextBox8.Location = New System.Drawing.Point(472, 184)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(96, 20)
        Me.TextBox8.TabIndex = 2
        Me.TextBox8.Text = ""
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(576, 48)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 16)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.Text = "Crédito"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(392, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Estatus:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_number"))
        Me.TextBox9.Location = New System.Drawing.Point(136, 40)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(96, 20)
        Me.TextBox9.TabIndex = 2
        Me.TextBox9.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(16, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Documento Número:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXLookup4
        '
        Me.LibXLookup4.DataMember = Nothing
        Me.LibXLookup4.DataSource = Nothing
        Me.LibXLookup4.DestParameters = Nothing
        Me.LibXLookup4.FilterField = Nothing
        Me.LibXLookup4.IgnoreFindInBrowseMode = False
        Me.LibXLookup4.Location = New System.Drawing.Point(552, 64)
        Me.LibXLookup4.LookCaption = Nothing
        Me.LibXLookup4.Name = "LibXLookup4"
        Me.LibXLookup4.ShowMessageNotFound = True
        Me.LibXLookup4.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup4.SqlString = Nothing
        Me.LibXLookup4.SrcParameters = Nothing
        Me.LibXLookup4.TabIndex = 4
        Me.LibXLookup4.TableName = Nothing
        Me.LibXLookup4.UseCopyConnection = False
        Me.LibXLookup4.UseRowRetrieveEvents = False
        Me.LibXLookup4.VisParameters = Nothing
        Me.LibXLookup4.WhereCondition = Nothing
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(200, 64)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(352, 20)
        Me.TextBox10.TabIndex = 1
        Me.TextBox10.Text = ""
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.vend_code"))
        Me.TextBox11.Location = New System.Drawing.Point(136, 64)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(56, 20)
        Me.TextBox11.TabIndex = 0
        Me.TextBox11.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(64, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Vendedor:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.LibXConnector1.DataMember = "ftfactm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
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
        Me.LibXDbSourceTable1.CustomDbUpdate = True
        Me.LibXDbSourceTable1.DeleteOrder = 0
        Me.LibXDbSourceTable1.FillOnQuery = True
        Me.LibXDbSourceTable1.FillOnRowChange = False
        Me.LibXDbSourceTable1.HeaderIsOnGrid = False
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select distinct ftfactm.type_code,ftfactm.fact_number,ftfactm.fact_date,", "ftfactm.fact_status, ftfactm.phone,ftfactm.cust_code,", "ftseriem.serie_number,ftfactm.vend_code,ftfactd.item_code,", "ftfactm.bus_name,cccustm.cust_name,", "ivitemm.item_name,ftfactd.price,ftfactm.fact_total,ftfactm.fact_cond", "from ftfactm left outer join ftfactd ", "on ftfactd.ftserial_no = ftfactm.ftserial_no", "left outer join ftseriem", "on ftfactd.ftserial_no = ftseriem.ftserial_no", "and ftfactd.line_no = ftseriem.line_no", "inner join ivitemm on ivitemm.item_code = ftfactd.item_code", "left outer join cccustm", "on cccustm.cust_code = ftfactm.cust_code"}
        Me.LibXDbSourceTable1.TableName = "ftfactm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LibXGrid1
        '
        Me.LibXGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = True
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.DataMember = "ftfactd"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = True
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 264)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(784, 216)
        Me.LibXGrid1.TabIndex = 1
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XDataGridLinkColumn1, Me.XDataGridLinkColumn2, Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn3, Me.XDataGridLinkColumn3, Me.XDataGridLinkColumn4, Me.DataGridBoolColumn1, Me.XDataGridLinkColumn5})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ftfactd"
        '
        'XDataGridLinkColumn1
        '
        Me.XDataGridLinkColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XDataGridLinkColumn1.Format = ""
        Me.XDataGridLinkColumn1.FormatInfo = Nothing
        Me.XDataGridLinkColumn1.HeaderText = "Tipo"
        Me.XDataGridLinkColumn1.ImageList = Nothing
        Me.XDataGridLinkColumn1.isReadOnly = False
        Me.XDataGridLinkColumn1.MappingName = "type_code"
        Me.XDataGridLinkColumn1.MaxLength = 32767
        Me.XDataGridLinkColumn1.UseCustomCellFormat = False
        Me.XDataGridLinkColumn1.Width = 35
        '
        'XDataGridLinkColumn2
        '
        Me.XDataGridLinkColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XDataGridLinkColumn2.Format = ""
        Me.XDataGridLinkColumn2.FormatInfo = Nothing
        Me.XDataGridLinkColumn2.HeaderText = "Número"
        Me.XDataGridLinkColumn2.ImageList = Nothing
        Me.XDataGridLinkColumn2.isReadOnly = False
        Me.XDataGridLinkColumn2.MappingName = "fact_number"
        Me.XDataGridLinkColumn2.MaxLength = 32767
        Me.XDataGridLinkColumn2.UseCustomCellFormat = False
        Me.XDataGridLinkColumn2.Width = 50
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Fecha"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "fact_date"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 60
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Vendedor"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "vend_code"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 50
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Teléfono"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = False
        Me.XEditTextBoxColumn3.MappingName = "phone"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 75
        '
        'XDataGridLinkColumn3
        '
        Me.XDataGridLinkColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XDataGridLinkColumn3.Format = ""
        Me.XDataGridLinkColumn3.FormatInfo = Nothing
        Me.XDataGridLinkColumn3.HeaderText = "No. Cte."
        Me.XDataGridLinkColumn3.ImageList = Nothing
        Me.XDataGridLinkColumn3.isReadOnly = False
        Me.XDataGridLinkColumn3.MappingName = "cust_code"
        Me.XDataGridLinkColumn3.MaxLength = 32767
        Me.XDataGridLinkColumn3.UseCustomCellFormat = False
        Me.XDataGridLinkColumn3.Width = 50
        '
        'XDataGridLinkColumn4
        '
        Me.XDataGridLinkColumn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XDataGridLinkColumn4.Format = ""
        Me.XDataGridLinkColumn4.FormatInfo = Nothing
        Me.XDataGridLinkColumn4.HeaderText = "Nombre del Cliente"
        Me.XDataGridLinkColumn4.ImageList = Nothing
        Me.XDataGridLinkColumn4.isReadOnly = False
        Me.XDataGridLinkColumn4.MappingName = "bus_name"
        Me.XDataGridLinkColumn4.MaxLength = 32767
        Me.XDataGridLinkColumn4.UseCustomCellFormat = False
        Me.XDataGridLinkColumn4.Width = 225
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "Crédito"
        Me.DataGridBoolColumn1.MappingName = "fact_cond"
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), Object)
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 50
        '
        'XDataGridLinkColumn5
        '
        Me.XDataGridLinkColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XDataGridLinkColumn5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XDataGridLinkColumn5.Format = ""
        Me.XDataGridLinkColumn5.FormatInfo = Nothing
        Me.XDataGridLinkColumn5.HeaderText = "Monto"
        Me.XDataGridLinkColumn5.ImageList = Nothing
        Me.XDataGridLinkColumn5.isReadOnly = False
        Me.XDataGridLinkColumn5.MappingName = "fact_total"
        Me.XDataGridLinkColumn5.MaxLength = 32767
        Me.XDataGridLinkColumn5.UseCustomCellFormat = False
        Me.XDataGridLinkColumn5.Width = 75
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Location = New System.Drawing.Point(680, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 216)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(8, 488)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Visualizar"
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(804, 24)
        Me.LibXNavigator1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(88, 488)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Pagos"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(168, 488)
        Me.Button3.Name = "Button3"
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Cliente"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(248, 488)
        Me.Button4.Name = "Button4"
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Forma Cobro"
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(328, 488)
        Me.Button5.Name = "Button5"
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Relacionado"
        '
        'ftfactm
        '
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn32, Me.DataColumn33})
        Me.ftfactm.TableName = "ftfactm"
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
        Me.DataColumn2.ColumnName = "fact_number"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "fact_date"
        Me.DataColumn3.DataType = GetType(System.DateTime)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "fact_status"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "phone"
        Me.DataColumn5.MaxLength = 8
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "cust_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "serie_number"
        Me.DataColumn7.MaxLength = 255
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "vend_code"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "item_code"
        Me.DataColumn9.MaxLength = 15
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "bus_name"
        Me.DataColumn10.MaxLength = 40
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "cust_name"
        Me.DataColumn11.MaxLength = 60
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "item_name"
        Me.DataColumn12.MaxLength = 100
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "price"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "fact_total"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "fact_cond"
        Me.DataColumn15.DataType = GetType(System.Int16)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "FechaIni"
        Me.DataColumn32.DataType = GetType(System.DateTime)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "FechaFin"
        Me.DataColumn33.DataType = GetType(System.DateTime)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(804, 526)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consultar Movimientos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try

            ftfactd.Rows.Clear()
            If LibXConnector1.HasRecords = True Then
                For Each orow As DataRow In ftfactm.Rows
                    Dim onewrow As DataRow = ftfactd.NewRow
                    onewrow.ItemArray = orow.ItemArray
                    ftfactd.Rows.Add(onewrow)
                Next
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteFill(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteFillEventArgs) Handles LibXConnector1.BeforeExecuteFill

    End Sub

    Private Sub LibXConnector1_RowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange

    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange

    End Sub
End Class
