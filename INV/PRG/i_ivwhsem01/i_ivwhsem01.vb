Public Class i_ivwhsem01
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
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As LibX.XTextBox
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As LibX.XTextBox
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents xtxt_whse_code As LibX.XMaskEdit
    Friend WithEvents xtxt_phone As LibX.XMaskEdit
    Friend WithEvents xtxt_phone1 As LibX.XMaskEdit
    Friend WithEvents xtxt_whse_name As LibX.XTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.xtxt_whse_name = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.xtxt_whse_code = New LibX.XMaskEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox4 = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.xtxt_phone = New LibX.XMaskEdit
        Me.xtxt_phone1 = New LibX.XMaskEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox6 = New LibX.XTextBox
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibxCheckBox1)
        Me.GroupBox1.Controls.Add(Me.xtxt_whse_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xtxt_whse_code)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xtxt_phone)
        Me.GroupBox1.Controls.Add(Me.xtxt_phone1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 184)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivwhsem.whse_default"))
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(416, 24)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = Nothing
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = False
        Me.LibxCheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox1.Size = New System.Drawing.Size(64, 16)
        Me.LibxCheckBox1.TabIndex = 1
        Me.LibxCheckBox1.Text = "Default"
        Me.LibxCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"whse_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "ivwhsem"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "whse_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "whse_name"
        Me.DataColumn2.MaxLength = 30
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "address"
        Me.DataColumn3.MaxLength = 60
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "whse_default"
        Me.DataColumn4.DataType = GetType(System.Int16)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "rnc"
        Me.DataColumn5.MaxLength = 20
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "phone"
        Me.DataColumn6.MaxLength = 12
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "phone1"
        Me.DataColumn7.MaxLength = 12
        '
        'xtxt_whse_name
        '
        Me.xtxt_whse_name.AcceptsReturn = True
        Me.xtxt_whse_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_whse_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivwhsem.whse_name"))
        Me.xtxt_whse_name.EditInitialValue = Nothing
        Me.xtxt_whse_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_whse_name.FieldDescription = ""
        Me.xtxt_whse_name.FindInitialValue = Nothing
        Me.xtxt_whse_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_whse_name.IgnoreRequiered = False
        Me.xtxt_whse_name.Location = New System.Drawing.Point(128, 48)
        Me.xtxt_whse_name.Name = "xtxt_whse_name"
        Me.xtxt_whse_name.NewInitialValue = Nothing
        Me.xtxt_whse_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_whse_name.Requiered = True
        Me.xtxt_whse_name.Size = New System.Drawing.Size(344, 20)
        Me.xtxt_whse_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_whse_name.TabIndex = 2
        Me.xtxt_whse_name.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(48, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_whse_code
        '
        Me.xtxt_whse_code.AcceptsReturn = True
        Me.xtxt_whse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivwhsem.whse_code"))
        Me.xtxt_whse_code.EditInitialValue = Nothing
        Me.xtxt_whse_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_whse_code.FieldDescription = ""
        Me.xtxt_whse_code.FindInitialValue = Nothing
        Me.xtxt_whse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_whse_code.IgnoreRequiered = False
        Me.xtxt_whse_code.Location = New System.Drawing.Point(128, 24)
        Me.xtxt_whse_code.Masked = MaskedTextBox.Mask.None
        Me.xtxt_whse_code.Name = "xtxt_whse_code"
        Me.xtxt_whse_code.NewInitialValue = Nothing
        Me.xtxt_whse_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_whse_code.Requiered = False
        Me.xtxt_whse_code.Size = New System.Drawing.Size(64, 20)
        Me.xtxt_whse_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_whse_code.TabIndex = 0
        Me.xtxt_whse_code.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(72, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(60, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dirección:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox4
        '
        Me.TextBox4.AcceptsReturn = True
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivwhsem.address"))
        Me.TextBox4.EditInitialValue = Nothing
        Me.TextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.FieldDescription = ""
        Me.TextBox4.FindInitialValue = Nothing
        Me.TextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.IgnoreRequiered = False
        Me.TextBox4.Location = New System.Drawing.Point(128, 96)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.NewInitialValue = Nothing
        Me.TextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.Requiered = True
        Me.TextBox4.Size = New System.Drawing.Size(344, 40)
        Me.TextBox4.StatusBarPanelDescripcion = Nothing
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(64, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Teléfono:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_phone
        '
        Me.xtxt_phone.AcceptsReturn = True
        Me.xtxt_phone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivwhsem.phone"))
        Me.xtxt_phone.EditInitialValue = Nothing
        Me.xtxt_phone.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_phone.FieldDescription = ""
        Me.xtxt_phone.FindInitialValue = Nothing
        Me.xtxt_phone.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_phone.IgnoreRequiered = False
        Me.xtxt_phone.Location = New System.Drawing.Point(128, 141)
        Me.xtxt_phone.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.xtxt_phone.Name = "xtxt_phone"
        Me.xtxt_phone.NewInitialValue = Nothing
        Me.xtxt_phone.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_phone.Requiered = True
        Me.xtxt_phone.Size = New System.Drawing.Size(120, 20)
        Me.xtxt_phone.StatusBarPanelDescripcion = Nothing
        Me.xtxt_phone.TabIndex = 5
        Me.xtxt_phone.Text = ""
        '
        'xtxt_phone1
        '
        Me.xtxt_phone1.AcceptsReturn = True
        Me.xtxt_phone1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivwhsem.phone1"))
        Me.xtxt_phone1.EditInitialValue = Nothing
        Me.xtxt_phone1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_phone1.FieldDescription = ""
        Me.xtxt_phone1.FindInitialValue = Nothing
        Me.xtxt_phone1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_phone1.IgnoreRequiered = False
        Me.xtxt_phone1.Location = New System.Drawing.Point(352, 141)
        Me.xtxt_phone1.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.xtxt_phone1.Name = "xtxt_phone1"
        Me.xtxt_phone1.NewInitialValue = Nothing
        Me.xtxt_phone1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_phone1.Requiered = True
        Me.xtxt_phone1.Size = New System.Drawing.Size(120, 20)
        Me.xtxt_phone1.StatusBarPanelDescripcion = Nothing
        Me.xtxt_phone1.TabIndex = 6
        Me.xtxt_phone1.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(296, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Teléfono:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(68, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "R. N. C.:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox6
        '
        Me.TextBox6.AcceptsReturn = True
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivwhsem.rnc"))
        Me.TextBox6.EditInitialValue = Nothing
        Me.TextBox6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox6.FieldDescription = ""
        Me.TextBox6.FindInitialValue = Nothing
        Me.TextBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox6.IgnoreRequiered = False
        Me.TextBox6.Location = New System.Drawing.Point(128, 72)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.NewInitialValue = Nothing
        Me.TextBox6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox6.Requiered = True
        Me.TextBox6.Size = New System.Drawing.Size(344, 20)
        Me.TextBox6.StatusBarPanelDescripcion = Nothing
        Me.TextBox6.TabIndex = 3
        Me.TextBox6.Text = ""
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
        Me.LibXConnector1.DataMember = "ivwhsem"
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
        Me.LibXConnector1.UseTransactions = False
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
        Me.LibXDbSourceTable1.KeyFields = "whse_code"
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "whse_code"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ivwhsem"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_whse_name
        Me.LibXNavigator1.FirstControlInFindMode = Nothing
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_whse_name
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(690, 24)
        Me.LibXNavigator1.TabIndex = 12
        '
        'i_ivwhsem01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 248)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivwhsem01"
        Me.Text = "Mantenimiento de Almacén"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
