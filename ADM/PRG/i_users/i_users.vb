Public Class i_users
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents vend_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents xtxt_UserName As LibX.XTextBox
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents xtxt_UserID As LibX.XTextBox
    Friend WithEvents xtxt_Password As LibX.XTextBox
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lkl_suc_code As LibX.LibXLookup
    Friend WithEvents suc_name As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataColumn6 = New System.Data.DataColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.vend_name = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.xtxt_UserName = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.xtxt_UserID = New LibX.XTextBox
        Me.xtxt_Password = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.Label4 = New System.Windows.Forms.Label
        Me.suc_name = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.lkl_suc_code = New LibX.LibXLookup
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.LibXConnector1.DataMember = "scusers"
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
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn5, Me.DataColumn4, Me.DataColumn6})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"userid"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "scusers"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "userid"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "groupid"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "vend_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "passwrd"
        Me.DataColumn5.MaxLength = 20
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "username"
        Me.DataColumn4.MaxLength = 8
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
        Me.LibXDbSourceTable1.SerialColumnName = "userid"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "scusers"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "suc_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.suc_name)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.lkl_suc_code)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.vend_name)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xtxt_UserName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xtxt_UserID)
        Me.GroupBox1.Controls.Add(Me.xtxt_Password)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 184)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(30, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Personal:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'vend_name
        '
        Me.vend_name.Location = New System.Drawing.Point(160, 88)
        Me.vend_name.Name = "vend_name"
        Me.vend_name.ReadOnly = True
        Me.vend_name.Size = New System.Drawing.Size(376, 20)
        Me.vend_name.TabIndex = 6
        Me.vend_name.TabStop = False
        Me.vend_name.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "scusers.vend_code"))
        Me.TextBox1.Location = New System.Drawing.Point(96, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(18, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "User Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_UserName
        '
        Me.xtxt_UserName.AcceptsReturn = True
        Me.xtxt_UserName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "scusers.username"))
        Me.xtxt_UserName.EditInitialValue = Nothing
        Me.xtxt_UserName.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_UserName.FieldDescription = ""
        Me.xtxt_UserName.FindInitialValue = Nothing
        Me.xtxt_UserName.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_UserName.IgnoreRequiered = False
        Me.xtxt_UserName.Location = New System.Drawing.Point(96, 40)
        Me.xtxt_UserName.Name = "xtxt_UserName"
        Me.xtxt_UserName.NewInitialValue = Nothing
        Me.xtxt_UserName.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_UserName.Requiered = False
        Me.xtxt_UserName.Size = New System.Drawing.Size(192, 20)
        Me.xtxt_UserName.StatusBarPanelDescripcion = Nothing
        Me.xtxt_UserName.TabIndex = 1
        Me.xtxt_UserName.TabStop = False
        Me.xtxt_UserName.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(36, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_UserID
        '
        Me.xtxt_UserID.AcceptsReturn = True
        Me.xtxt_UserID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "scusers.userid"))
        Me.xtxt_UserID.EditInitialValue = Nothing
        Me.xtxt_UserID.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_UserID.FieldDescription = ""
        Me.xtxt_UserID.FindInitialValue = Nothing
        Me.xtxt_UserID.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_UserID.IgnoreRequiered = False
        Me.xtxt_UserID.Location = New System.Drawing.Point(96, 16)
        Me.xtxt_UserID.Name = "xtxt_UserID"
        Me.xtxt_UserID.NewInitialValue = Nothing
        Me.xtxt_UserID.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_UserID.Requiered = False
        Me.xtxt_UserID.Size = New System.Drawing.Size(48, 20)
        Me.xtxt_UserID.StatusBarPanelDescripcion = Nothing
        Me.xtxt_UserID.TabIndex = 0
        Me.xtxt_UserID.TabStop = False
        Me.xtxt_UserID.Text = ""
        '
        'xtxt_Password
        '
        Me.xtxt_Password.AcceptsReturn = True
        Me.xtxt_Password.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "scusers.passwrd"))
        Me.xtxt_Password.EditInitialValue = Nothing
        Me.xtxt_Password.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Password.FieldDescription = ""
        Me.xtxt_Password.FindInitialValue = Nothing
        Me.xtxt_Password.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Password.IgnoreRequiered = False
        Me.xtxt_Password.Location = New System.Drawing.Point(96, 64)
        Me.xtxt_Password.Name = "xtxt_Password"
        Me.xtxt_Password.NewInitialValue = Nothing
        Me.xtxt_Password.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Password.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.xtxt_Password.Requiered = False
        Me.xtxt_Password.Size = New System.Drawing.Size(192, 20)
        Me.xtxt_Password.StatusBarPanelDescripcion = Nothing
        Me.xtxt_Password.TabIndex = 2
        Me.xtxt_Password.TabStop = False
        Me.xtxt_Password.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(25, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Password:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"vend_name=vend_name", "vend_code=vend_code"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(536, 88)
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
        Me.LibXLookup1.SrcParameters = New String() {"vend_code=vend_code"}
        Me.LibXLookup1.TabIndex = 6
        Me.LibXLookup1.TableName = "ftvendm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=vend_code", "Nombre=vend_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_Password
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_UserID
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_UserName
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(688, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(31, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Sucursal:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'suc_name
        '
        Me.suc_name.Location = New System.Drawing.Point(160, 112)
        Me.suc_name.Name = "suc_name"
        Me.suc_name.ReadOnly = True
        Me.suc_name.Size = New System.Drawing.Size(376, 20)
        Me.suc_name.TabIndex = 10
        Me.suc_name.TabStop = False
        Me.suc_name.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "scusers.suc_code"))
        Me.TextBox3.Location = New System.Drawing.Point(96, 112)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(56, 20)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = ""
        '
        'lkl_suc_code
        '
        Me.lkl_suc_code.AlternateFieldSearch = Nothing
        Me.lkl_suc_code.BeginCheck = False
        Me.lkl_suc_code.CheckText = Nothing
        Me.lkl_suc_code.ComboMode = False
        Me.lkl_suc_code.DataMember = Nothing
        Me.lkl_suc_code.DataSource = Me.LibXConnector1
        Me.lkl_suc_code.DestParameters = New String() {"suc_code=suc_code", "suc_name=suc_name"}
        Me.lkl_suc_code.FilterField = Nothing
        Me.lkl_suc_code.IgnoreFindInBrowseMode = False
        Me.lkl_suc_code.isCanceled = False
        Me.lkl_suc_code.Location = New System.Drawing.Point(536, 112)
        Me.lkl_suc_code.LookCaption = Nothing
        Me.lkl_suc_code.Name = "lkl_suc_code"
        Me.lkl_suc_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkl_suc_code.ShowFilter = True
        Me.lkl_suc_code.ShowMessageNotFound = True
        Me.lkl_suc_code.ShowWarning = False
        Me.lkl_suc_code.Size = New System.Drawing.Size(16, 20)
        Me.lkl_suc_code.SizesColumns = Nothing
        Me.lkl_suc_code.SizesColumnsTab = Nothing
        Me.lkl_suc_code.SqlString = Nothing
        Me.lkl_suc_code.SQLTab = Nothing
        Me.lkl_suc_code.SrcParameters = New String() {"suc_code=suc_code"}
        Me.lkl_suc_code.TabIndex = 9
        Me.lkl_suc_code.TableName = "cgsucursal"
        Me.lkl_suc_code.TabStop = False
        Me.lkl_suc_code.UseCopyConnection = False
        Me.lkl_suc_code.UseRowRetrieveEvents = False
        Me.lkl_suc_code.UseTab = False
        Me.lkl_suc_code.VisParameters = New String() {"Código=suc_code", "Nombre=suc_name"}
        Me.lkl_suc_code.WhereCondition = Nothing
        Me.lkl_suc_code.WhereParameters = Nothing
        '
        'i_users
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 245)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "i_users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Usuarios"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If Not e.row Is Nothing Then
                If e.row!username.ToString.ToLower.Trim = "UserAdmin".ToLower Then
                    LibXConnector1.AllowDelete = False
                    LibXConnector1.AllowEdit = False
                End If
                LibXNavigator1.UpdateState()
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

End Class
