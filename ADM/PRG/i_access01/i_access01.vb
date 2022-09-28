Public Class i_access01
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
    Friend WithEvents LibXShortNavigator1 As LibX.LibXShortNavigator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents LibXConnector2 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents XMaskEdit1 As LibX.XMaskEdit
    Friend WithEvents xtxt_descripcion As LibX.XTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents xtxt_accesskey As LibX.XTextBox
    Friend WithEvents xcbo_estatus As LibX.LibXCombo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xcbo_estatus = New LibX.LibXCombo
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.xtxt_descripcion = New LibX.XTextBox
        Me.XMaskEdit1 = New LibX.XMaskEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.xtxt_accesskey = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.Label6 = New System.Windows.Forms.Label
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector2 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xcbo_estatus)
        Me.GroupBox1.Controls.Add(Me.xtxt_descripcion)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xtxt_accesskey)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.XTextBox3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 176)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'xcbo_estatus
        '
        Me.xcbo_estatus.AllowDefaultSort = True
        Me.xcbo_estatus.bound = True
        Me.xcbo_estatus.currValue = Nothing
        Me.xcbo_estatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "scaccess.Estatus"))
        Me.xcbo_estatus.DefaultWhereString = Nothing
        Me.xcbo_estatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_estatus.EditInitialValue = Nothing
        Me.xcbo_estatus.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_estatus.FieldDescription = ""
        Me.xcbo_estatus.FindInitialValue = Nothing
        Me.xcbo_estatus.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_estatus.IgnoreRequiered = False
        Me.xcbo_estatus.Items.AddRange(New Object() {"1-Activo", "0-Inactivo"})
        Me.xcbo_estatus.Location = New System.Drawing.Point(320, 88)
        Me.xcbo_estatus.LookupKeyDisplayFields = Nothing
        Me.xcbo_estatus.LookupKeyField = Nothing
        Me.xcbo_estatus.LookupTableName = Nothing
        Me.xcbo_estatus.Name = "xcbo_estatus"
        Me.xcbo_estatus.NewInitialValue = Nothing
        Me.xcbo_estatus.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_estatus.Requiered = False
        Me.xcbo_estatus.Required = False
        Me.xcbo_estatus.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_estatus.SqlString = Nothing
        Me.xcbo_estatus.StatusBarPanelDescripcion = Nothing
        Me.xcbo_estatus.TabIndex = 5
        '
        'DataSet1
        '
        Me.LibXConnector2.SetDataGenerator(Me.DataSet1, Me.LibXConnector2)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector2.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"AccessID"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn3}
        Me.DataTable1.TableName = "scaccess"
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.AutoIncrement = True
        Me.DataColumn3.ColumnName = "AccessID"
        Me.DataColumn3.DataType = GetType(System.Int32)
        Me.DataColumn3.ReadOnly = True
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "Description"
        Me.DataColumn4.MaxLength = 50
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "Accesskey"
        Me.DataColumn5.MaxLength = 20
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Estatus"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Password"
        Me.DataColumn7.MaxLength = 50
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "accessType"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'xtxt_descripcion
        '
        Me.xtxt_descripcion.AcceptsReturn = True
        Me.xtxt_descripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "scaccess.Description"))
        Me.xtxt_descripcion.EditInitialValue = Nothing
        Me.xtxt_descripcion.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_descripcion.FieldDescription = ""
        Me.xtxt_descripcion.FindInitialValue = Nothing
        Me.xtxt_descripcion.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_descripcion.IgnoreRequiered = False
        Me.xtxt_descripcion.Location = New System.Drawing.Point(88, 40)
        Me.xtxt_descripcion.Name = "xtxt_descripcion"
        Me.xtxt_descripcion.NewInitialValue = Nothing
        Me.xtxt_descripcion.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_descripcion.Requiered = False
        Me.xtxt_descripcion.Size = New System.Drawing.Size(352, 20)
        Me.xtxt_descripcion.StatusBarPanelDescripcion = Nothing
        Me.xtxt_descripcion.TabIndex = 1
        Me.xtxt_descripcion.Text = ""
        '
        'XMaskEdit1
        '
        Me.XMaskEdit1.AcceptsReturn = True
        Me.XMaskEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "scaccess.AccessID"))
        Me.XMaskEdit1.EditInitialValue = Nothing
        Me.XMaskEdit1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XMaskEdit1.FieldDescription = ""
        Me.XMaskEdit1.FindInitialValue = Nothing
        Me.XMaskEdit1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.IgnoreRequiered = False
        Me.XMaskEdit1.Location = New System.Drawing.Point(88, 16)
        Me.XMaskEdit1.Masked = MaskedTextBox.Mask.None
        Me.XMaskEdit1.Name = "XMaskEdit1"
        Me.XMaskEdit1.NewInitialValue = Nothing
        Me.XMaskEdit1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XMaskEdit1.Requiered = False
        Me.XMaskEdit1.Size = New System.Drawing.Size(56, 20)
        Me.XMaskEdit1.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit1.TabIndex = 0
        Me.XMaskEdit1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(7, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Access ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Access Key:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_accesskey
        '
        Me.xtxt_accesskey.AcceptsReturn = True
        Me.xtxt_accesskey.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "scaccess.Accesskey"))
        Me.xtxt_accesskey.EditInitialValue = Nothing
        Me.xtxt_accesskey.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_accesskey.FieldDescription = ""
        Me.xtxt_accesskey.FindInitialValue = Nothing
        Me.xtxt_accesskey.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_accesskey.IgnoreRequiered = False
        Me.xtxt_accesskey.Location = New System.Drawing.Point(88, 64)
        Me.xtxt_accesskey.Name = "xtxt_accesskey"
        Me.xtxt_accesskey.NewInitialValue = Nothing
        Me.xtxt_accesskey.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_accesskey.Requiered = False
        Me.xtxt_accesskey.Size = New System.Drawing.Size(120, 20)
        Me.xtxt_accesskey.StatusBarPanelDescripcion = Nothing
        Me.xtxt_accesskey.TabIndex = 2
        Me.xtxt_accesskey.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(260, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Estatus:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "scaccess.Password"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(320, 64)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(120, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 3
        Me.XTextBox3.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(248, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Password:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "scaccess.Estatus"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Items.AddRange(New Object() {"1-User Defined", "2-System"})
        Me.LibXCombo1.Location = New System.Drawing.Point(88, 88)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = Nothing
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = "1"
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(120, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(45, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Tipo:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "groupid"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "groupname"
        Me.DataColumn2.MaxLength = 20
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector2
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_descripcion
        Me.LibXNavigator1.FirstControlInFindMode = Nothing
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_descripcion
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(688, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'LibXConnector2
        '
        Me.LibXConnector2.AllowDelete = True
        Me.LibXConnector2.AllowEdit = True
        Me.LibXConnector2.AllowNew = True
        Me.LibXConnector2.AllowPrint = True
        Me.LibXConnector2.AllowQuery = True
        Me.LibXConnector2.BOF = False
        Me.LibXConnector2.CanExecuteFind = True
        Me.LibXConnector2.DataMember = "scaccess"
        Me.LibXConnector2.DataSource = Me.DataSet1
        Me.LibXConnector2.EOF = False
        Me.LibXConnector2.HandledRowsFill = False
        Me.LibXConnector2.HandledUpdates = False
        Me.LibXConnector2.HasRecords = False
        Me.LibXConnector2.IsEditing = False
        Me.LibXConnector2.IsHeaderOnGrid = False
        Me.LibXConnector2.ModuleName = ""
        Me.LibXConnector2.OwnerForm = Me
        Me.LibXConnector2.Parameters = Nothing
        Me.LibXConnector2.RecordCount = 0
        Me.LibXConnector2.ReportMode = False
        Me.LibXConnector2.ReportName = ""
        Me.LibXConnector2.ShowWarningCancel = True
        Me.LibXConnector2.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable2})
        Me.LibXConnector2.State = LibX.LibxConnectorState.none
        Me.LibXConnector2.UpdatePrimaryKeyColumns = False
        Me.LibXConnector2.UseTransactions = True
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
        Me.LibXDbSourceTable2.SerialColumnName = "accessid"
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = Nothing
        Me.LibXDbSourceTable2.TableName = "scaccess"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'i_access01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 238)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "i_access01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Permisos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
