Public Class i_stinfom01
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
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents TextBox2 As LibX.XTextBox
    Friend WithEvents TextBox3 As LibX.XTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As LibX.XTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As LibX.XTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
    Friend WithEvents stinform As System.Data.DataTable
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
    Friend WithEvents XMaskEdit1 As LibX.XMaskEdit
    Friend WithEvents XMaskEdit2 As LibX.XMaskEdit
    Friend WithEvents XMaskEdit3 As LibX.XMaskEdit
    Friend WithEvents xtxt_comp_id As LibX.XTextBox
    Friend WithEvents xtxt_comp_rnc As LibX.XTextBox
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents xlk_vend_code As LibX.LibXLookup
    Friend WithEvents xtxt_vend_name As LibX.XTextBox
    Friend WithEvents XMaskEdit4 As LibX.XMaskEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents XMaskEdit5 As LibX.XMaskEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents XMaskEdit6 As LibX.XMaskEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.XMaskEdit3 = New LibX.XMaskEdit
        Me.DataSet1 = New System.Data.DataSet
        Me.stinform = New System.Data.DataTable
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
        Me.XMaskEdit2 = New LibX.XMaskEdit
        Me.XMaskEdit1 = New LibX.XMaskEdit
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.xtxt_comp_id = New LibX.XTextBox
        Me.TextBox2 = New LibX.XTextBox
        Me.TextBox3 = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox7 = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox8 = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.xtxt_comp_rnc = New LibX.XTextBox
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.XTextBox1 = New LibX.XTextBox
        Me.xlk_vend_code = New LibX.LibXLookup
        Me.xtxt_vend_name = New LibX.XTextBox
        Me.XMaskEdit4 = New LibX.XMaskEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.XMaskEdit5 = New LibX.XMaskEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.XMaskEdit6 = New LibX.XMaskEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stinform, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit6)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xtxt_vend_name)
        Me.GroupBox1.Controls.Add(Me.xlk_vend_code)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit3)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit2)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit1)
        Me.GroupBox1.Controls.Add(Me.LibxCheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xtxt_comp_id)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.xtxt_comp_rnc)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 280)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'XMaskEdit3
        '
        Me.XMaskEdit3.AcceptsReturn = True
        Me.XMaskEdit3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "stinform.comp_fax"))
        Me.XMaskEdit3.EditInitialValue = Nothing
        Me.XMaskEdit3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit3.FieldDescription = ""
        Me.XMaskEdit3.FindInitialValue = Nothing
        Me.XMaskEdit3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit3.IgnoreRequiered = False
        Me.XMaskEdit3.Location = New System.Drawing.Point(160, 144)
        Me.XMaskEdit3.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.XMaskEdit3.Name = "XMaskEdit3"
        Me.XMaskEdit3.NewInitialValue = Nothing
        Me.XMaskEdit3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit3.Requiered = False
        Me.XMaskEdit3.Size = New System.Drawing.Size(136, 20)
        Me.XMaskEdit3.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit3.TabIndex = 6
        Me.XMaskEdit3.Text = ""
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.stinform})
        '
        'stinform
        '
        Me.stinform.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16})
        Me.stinform.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"comp_id"}, True)})
        Me.stinform.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.stinform.TableName = "stinform"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "comp_id"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "comp_main"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "comp_rnc"
        Me.DataColumn3.MaxLength = 20
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "comp_name"
        Me.DataColumn4.MaxLength = 60
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "comp_address"
        Me.DataColumn5.MaxLength = 60
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "comp_phone1"
        Me.DataColumn6.MaxLength = 8
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "comp_phone2"
        Me.DataColumn7.MaxLength = 8
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "comp_fax"
        Me.DataColumn8.MaxLength = 8
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "comp_email"
        Me.DataColumn9.MaxLength = 40
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "comp_website"
        Me.DataColumn10.MaxLength = 40
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "comp_logo"
        Me.DataColumn11.DataType = GetType(System.Byte())
        '
        'XMaskEdit2
        '
        Me.XMaskEdit2.AcceptsReturn = True
        Me.XMaskEdit2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "stinform.comp_phone2"))
        Me.XMaskEdit2.EditInitialValue = Nothing
        Me.XMaskEdit2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit2.FieldDescription = ""
        Me.XMaskEdit2.FindInitialValue = Nothing
        Me.XMaskEdit2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit2.IgnoreRequiered = False
        Me.XMaskEdit2.Location = New System.Drawing.Point(160, 120)
        Me.XMaskEdit2.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.XMaskEdit2.Name = "XMaskEdit2"
        Me.XMaskEdit2.NewInitialValue = Nothing
        Me.XMaskEdit2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit2.Requiered = False
        Me.XMaskEdit2.Size = New System.Drawing.Size(136, 20)
        Me.XMaskEdit2.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit2.TabIndex = 5
        Me.XMaskEdit2.Text = ""
        '
        'XMaskEdit1
        '
        Me.XMaskEdit1.AcceptsReturn = True
        Me.XMaskEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "stinform.comp_phone1"))
        Me.XMaskEdit1.EditInitialValue = Nothing
        Me.XMaskEdit1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.FieldDescription = ""
        Me.XMaskEdit1.FindInitialValue = Nothing
        Me.XMaskEdit1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.IgnoreRequiered = False
        Me.XMaskEdit1.Location = New System.Drawing.Point(160, 96)
        Me.XMaskEdit1.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.XMaskEdit1.Name = "XMaskEdit1"
        Me.XMaskEdit1.NewInitialValue = Nothing
        Me.XMaskEdit1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.Requiered = False
        Me.XMaskEdit1.Size = New System.Drawing.Size(136, 20)
        Me.XMaskEdit1.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit1.TabIndex = 4
        Me.XMaskEdit1.Text = ""
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "stinform.comp_main"))
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(392, 144)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = Nothing
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = False
        Me.LibxCheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox1.Size = New System.Drawing.Size(104, 16)
        Me.LibxCheckBox1.TabIndex = 9
        Me.LibxCheckBox1.Text = "Oficina Princpal"
        Me.LibxCheckBox1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(123, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_comp_id
        '
        Me.xtxt_comp_id.AcceptsReturn = True
        Me.xtxt_comp_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "stinform.comp_id"))
        Me.xtxt_comp_id.EditInitialValue = Nothing
        Me.xtxt_comp_id.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_comp_id.FieldDescription = ""
        Me.xtxt_comp_id.FindInitialValue = Nothing
        Me.xtxt_comp_id.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_comp_id.IgnoreRequiered = False
        Me.xtxt_comp_id.Location = New System.Drawing.Point(160, 24)
        Me.xtxt_comp_id.Name = "xtxt_comp_id"
        Me.xtxt_comp_id.NewInitialValue = Nothing
        Me.xtxt_comp_id.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_comp_id.Requiered = False
        Me.xtxt_comp_id.Size = New System.Drawing.Size(72, 20)
        Me.xtxt_comp_id.StatusBarPanelDescripcion = Nothing
        Me.xtxt_comp_id.TabIndex = 0
        Me.xtxt_comp_id.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "stinform.comp_name"))
        Me.TextBox2.EditInitialValue = Nothing
        Me.TextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.FieldDescription = ""
        Me.TextBox2.FindInitialValue = Nothing
        Me.TextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.IgnoreRequiered = False
        Me.TextBox2.Location = New System.Drawing.Point(160, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.NewInitialValue = Nothing
        Me.TextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.Requiered = False
        Me.TextBox2.Size = New System.Drawing.Size(432, 20)
        Me.TextBox2.StatusBarPanelDescripcion = Nothing
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.AcceptsReturn = True
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "stinform.comp_address"))
        Me.TextBox3.EditInitialValue = Nothing
        Me.TextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.FieldDescription = ""
        Me.TextBox3.FindInitialValue = Nothing
        Me.TextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.IgnoreRequiered = False
        Me.TextBox3.Location = New System.Drawing.Point(160, 72)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.NewInitialValue = Nothing
        Me.TextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.Requiered = False
        Me.TextBox3.Size = New System.Drawing.Size(432, 20)
        Me.TextBox3.StatusBarPanelDescripcion = Nothing
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(94, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(87, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Dirección:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(91, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Teléfono:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(91, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Teléfono:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox7
        '
        Me.TextBox7.AcceptsReturn = True
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "stinform.comp_email"))
        Me.TextBox7.EditInitialValue = Nothing
        Me.TextBox7.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox7.FieldDescription = ""
        Me.TextBox7.FindInitialValue = Nothing
        Me.TextBox7.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox7.IgnoreRequiered = False
        Me.TextBox7.Location = New System.Drawing.Point(392, 120)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.NewInitialValue = Nothing
        Me.TextBox7.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox7.Requiered = False
        Me.TextBox7.Size = New System.Drawing.Size(200, 20)
        Me.TextBox7.StatusBarPanelDescripcion = Nothing
        Me.TextBox7.TabIndex = 8
        Me.TextBox7.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(344, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Email:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox8
        '
        Me.TextBox8.AcceptsReturn = True
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "stinform.comp_website"))
        Me.TextBox8.EditInitialValue = Nothing
        Me.TextBox8.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox8.FieldDescription = ""
        Me.TextBox8.FindInitialValue = Nothing
        Me.TextBox8.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.Blue
        Me.TextBox8.IgnoreRequiered = False
        Me.TextBox8.Location = New System.Drawing.Point(392, 96)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.NewInitialValue = Nothing
        Me.TextBox8.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox8.Requiered = False
        Me.TextBox8.Size = New System.Drawing.Size(200, 20)
        Me.TextBox8.StatusBarPanelDescripcion = Nothing
        Me.TextBox8.TabIndex = 7
        Me.TextBox8.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(328, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "WebSite:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(72, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 16)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Fax Número:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(336, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "R. N. C."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_comp_rnc
        '
        Me.xtxt_comp_rnc.AcceptsReturn = True
        Me.xtxt_comp_rnc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "stinform.comp_rnc"))
        Me.xtxt_comp_rnc.EditInitialValue = Nothing
        Me.xtxt_comp_rnc.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_comp_rnc.FieldDescription = ""
        Me.xtxt_comp_rnc.FindInitialValue = Nothing
        Me.xtxt_comp_rnc.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_comp_rnc.IgnoreRequiered = False
        Me.xtxt_comp_rnc.Location = New System.Drawing.Point(392, 24)
        Me.xtxt_comp_rnc.Name = "xtxt_comp_rnc"
        Me.xtxt_comp_rnc.NewInitialValue = Nothing
        Me.xtxt_comp_rnc.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_comp_rnc.Requiered = False
        Me.xtxt_comp_rnc.Size = New System.Drawing.Size(200, 20)
        Me.xtxt_comp_rnc.StatusBarPanelDescripcion = Nothing
        Me.xtxt_comp_rnc.TabIndex = 1
        Me.xtxt_comp_rnc.Text = ""
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
        Me.LibXConnector1.DataMember = "stinform"
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
        Me.LibXDbSourceTable1.SerialColumnName = "comp_id"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "stinform"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "comp_area"
        Me.DataColumn12.MaxLength = 3
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "permiso_DNCD"
        Me.DataColumn13.MaxLength = 10
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "RegenteID"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "Cedula_regente"
        Me.DataColumn15.MaxLength = 20
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "excequatus_regente"
        Me.DataColumn16.MaxLength = 10
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_comp_rnc
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_comp_id
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_comp_rnc
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(688, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "stinform.RegenteID"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(160, 168)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(96, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 10
        Me.XTextBox1.Text = ""
        '
        'xlk_vend_code
        '
        Me.xlk_vend_code.AlternateFieldSearch = Nothing
        Me.xlk_vend_code.BeginCheck = False
        Me.xlk_vend_code.CheckText = Nothing
        Me.xlk_vend_code.ComboMode = False
        Me.xlk_vend_code.DataMember = Nothing
        Me.xlk_vend_code.DataSource = Me.LibXConnector1
        Me.xlk_vend_code.DestParameters = New String() {"RegenteID=vend_code", "xtxt_vend_name=vend_name"}
        Me.xlk_vend_code.FilterField = "vend_name"
        Me.xlk_vend_code.IgnoreFindInBrowseMode = False
        Me.xlk_vend_code.isCanceled = False
        Me.xlk_vend_code.Location = New System.Drawing.Point(576, 168)
        Me.xlk_vend_code.LookCaption = "Personal"
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
        Me.xlk_vend_code.SrcParameters = New String() {"RegenteID=vend_code"}
        Me.xlk_vend_code.TabIndex = 11
        Me.xlk_vend_code.TableName = "ftvendm"
        Me.xlk_vend_code.TabStop = False
        Me.xlk_vend_code.UseCopyConnection = False
        Me.xlk_vend_code.UseRowRetrieveEvents = False
        Me.xlk_vend_code.UseTab = False
        Me.xlk_vend_code.VisParameters = New String() {"Codigo=vend_code", "Nombre=vend_name"}
        Me.xlk_vend_code.WhereCondition = Nothing
        Me.xlk_vend_code.WhereParameters = Nothing
        '
        'xtxt_vend_name
        '
        Me.xtxt_vend_name.AcceptsReturn = True
        Me.xtxt_vend_name.EditInitialValue = Nothing
        Me.xtxt_vend_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_vend_name.FieldDescription = ""
        Me.xtxt_vend_name.FindInitialValue = Nothing
        Me.xtxt_vend_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_vend_name.IgnoreRequiered = False
        Me.xtxt_vend_name.Location = New System.Drawing.Point(264, 168)
        Me.xtxt_vend_name.Name = "xtxt_vend_name"
        Me.xtxt_vend_name.NewInitialValue = Nothing
        Me.xtxt_vend_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_vend_name.ReadOnly = True
        Me.xtxt_vend_name.Requiered = False
        Me.xtxt_vend_name.Size = New System.Drawing.Size(312, 20)
        Me.xtxt_vend_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_vend_name.TabIndex = 12
        Me.xtxt_vend_name.TabStop = False
        Me.xtxt_vend_name.Text = ""
        '
        'XMaskEdit4
        '
        Me.XMaskEdit4.AcceptsReturn = True
        Me.XMaskEdit4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "stinform.Cedula_regente"))
        Me.XMaskEdit4.EditInitialValue = Nothing
        Me.XMaskEdit4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit4.FieldDescription = ""
        Me.XMaskEdit4.FindInitialValue = Nothing
        Me.XMaskEdit4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit4.IgnoreRequiered = False
        Me.XMaskEdit4.Location = New System.Drawing.Point(160, 192)
        Me.XMaskEdit4.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.XMaskEdit4.Name = "XMaskEdit4"
        Me.XMaskEdit4.NewInitialValue = Nothing
        Me.XMaskEdit4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit4.Requiered = False
        Me.XMaskEdit4.Size = New System.Drawing.Size(136, 20)
        Me.XMaskEdit4.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit4.TabIndex = 14
        Me.XMaskEdit4.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(56, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Cedula Regente"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XMaskEdit5
        '
        Me.XMaskEdit5.AcceptsReturn = True
        Me.XMaskEdit5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "stinform.excequatus_regente"))
        Me.XMaskEdit5.EditInitialValue = Nothing
        Me.XMaskEdit5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit5.FieldDescription = ""
        Me.XMaskEdit5.FindInitialValue = Nothing
        Me.XMaskEdit5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit5.IgnoreRequiered = False
        Me.XMaskEdit5.Location = New System.Drawing.Point(400, 192)
        Me.XMaskEdit5.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.XMaskEdit5.Name = "XMaskEdit5"
        Me.XMaskEdit5.NewInitialValue = Nothing
        Me.XMaskEdit5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit5.Requiered = False
        Me.XMaskEdit5.Size = New System.Drawing.Size(192, 20)
        Me.XMaskEdit5.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit5.TabIndex = 16
        Me.XMaskEdit5.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(320, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Excequatus:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XMaskEdit6
        '
        Me.XMaskEdit6.AcceptsReturn = True
        Me.XMaskEdit6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "stinform.permiso_DNCD"))
        Me.XMaskEdit6.EditInitialValue = Nothing
        Me.XMaskEdit6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit6.FieldDescription = ""
        Me.XMaskEdit6.FindInitialValue = Nothing
        Me.XMaskEdit6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit6.IgnoreRequiered = False
        Me.XMaskEdit6.Location = New System.Drawing.Point(160, 216)
        Me.XMaskEdit6.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.XMaskEdit6.Name = "XMaskEdit6"
        Me.XMaskEdit6.NewInitialValue = Nothing
        Me.XMaskEdit6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit6.Requiered = False
        Me.XMaskEdit6.Size = New System.Drawing.Size(136, 20)
        Me.XMaskEdit6.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit6.TabIndex = 18
        Me.XMaskEdit6.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(101, 216)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 16)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "CIDC #"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(96, 168)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 16)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Regente"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'i_stinfom01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 334)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "i_stinfom01"
        Me.Text = "Datos de la Empresa"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stinform, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
