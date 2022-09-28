Public Class i_asign01
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
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents lblvend_name As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents gColitem_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents xlk_accesid As LibX.LibXLookup
    Friend WithEvents gColdescription As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents xtxt_username As LibX.XTextBox
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents gColaccesskey As LibX.XEditTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.xtxt_username = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblvend_name = New System.Windows.Forms.Label
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColitem_code = New LibX.XDataGridTextButtonColumn
        Me.xlk_accesid = New LibX.LibXLookup
        Me.gColdescription = New LibX.XEditTextBoxColumn
        Me.gColaccesskey = New LibX.XEditTextBoxColumn
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXConnector1.ModuleName = ""
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = ""
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = True
        Me.LibXConnector1.UseTransactions = True
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
        Me.DataTable1.TableName = "scusers"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "userID"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "username"
        Me.DataColumn2.MaxLength = 20
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "vend_name"
        Me.DataColumn3.MaxLength = 60
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.DataTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"UserID", "AccessID"}, True)})
        Me.DataTable2.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn4, Me.DataColumn5}
        Me.DataTable2.TableName = "scasignm"
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "UserID"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "AccessID"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "description"
        Me.DataColumn6.MaxLength = 50
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "accesskey"
        Me.DataColumn7.MaxLength = 20
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
        Me.LibXDbSourceTable1.InnerJon = False
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "userid"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"SELECT scusers.userID, scusers.username, ftvendm.vend_name", "from scusers", "inner join ftvendm", "on ftvendm.vend_code = scusers.vend_code"}
        Me.LibXDbSourceTable1.TableName = "scusers"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
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
        Me.LibXDbSourceTable2.FillOnRowChange = True
        Me.LibXDbSourceTable2.HeaderIsOnGrid = False
        Me.LibXDbSourceTable2.InnerJon = False
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"userid=userid"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select userid,scasignm.accessid,description,scasignm.accesskey", "from scasignm", "inner join scaccess", "on scaccess.accessid=scasignm.accessid"}
        Me.LibXDbSourceTable2.TableName = "scasignm"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.xtxt_username)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblvend_name)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"username=username", "userid=userid", "lblvend_name=vend_name"}
        Me.LibXLookup1.FilterField = "vend_name"
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(624, 24)
        Me.LibXLookup1.LookCaption = "Usuarios"
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.ShowWarning = False
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SizesColumns = Nothing
        Me.LibXLookup1.SizesColumnsTab = Nothing
        Me.LibXLookup1.SqlString = New String() {"select userid,username, vend_name", "from scusers", "inner join ftvendm", "on ftvendm.vend_code = scusers.vend_code"}
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"username=username"}
        Me.LibXLookup1.TabIndex = 2
        Me.LibXLookup1.TableName = "scusers"
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Usuario=username", "Nombre=vend_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'xtxt_username
        '
        Me.xtxt_username.AcceptsReturn = True
        Me.xtxt_username.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "scusers.username"))
        Me.xtxt_username.EditInitialValue = Nothing
        Me.xtxt_username.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_username.FieldDescription = ""
        Me.xtxt_username.FindInitialValue = Nothing
        Me.xtxt_username.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_username.IgnoreRequiered = False
        Me.xtxt_username.Location = New System.Drawing.Point(80, 24)
        Me.xtxt_username.Name = "xtxt_username"
        Me.xtxt_username.NewInitialValue = Nothing
        Me.xtxt_username.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_username.Requiered = False
        Me.xtxt_username.StatusBarPanelDescripcion = Nothing
        Me.xtxt_username.TabIndex = 1
        Me.xtxt_username.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblvend_name
        '
        Me.lblvend_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblvend_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "scusers.vend_name"))
        Me.lblvend_name.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblvend_name.Location = New System.Drawing.Point(192, 24)
        Me.lblvend_name.Name = "lblvend_name"
        Me.lblvend_name.Size = New System.Drawing.Size(424, 20)
        Me.lblvend_name.TabIndex = 0
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_username
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_username
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_username
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(688, 24)
        Me.LibXNavigator1.TabIndex = 1
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Permisos Asignados"
        Me.LibXGrid1.DataMember = "scasignm"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 104)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(672, 384)
        Me.LibXGrid1.TabIndex = 2
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColitem_code, Me.gColdescription, Me.gColaccesskey})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "scasignm"
        '
        'gColitem_code
        '
        Me.gColitem_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColitem_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColitem_code.executeFindDuringFill = False
        Me.gColitem_code.Format = ""
        Me.gColitem_code.FormatInfo = Nothing
        Me.gColitem_code.HeaderText = "Permiso ID"
        Me.gColitem_code.isReadOnly = False
        Me.gColitem_code.Lookup = Me.xlk_accesid
        Me.gColitem_code.MappingName = "AccessID"
        Me.gColitem_code.MaxLength = 32767
        Me.gColitem_code.TabStop = True
        Me.gColitem_code.UseCustomCellFormat = False
        Me.gColitem_code.Width = 101
        '
        'xlk_accesid
        '
        Me.xlk_accesid.AlternateFieldSearch = Nothing
        Me.xlk_accesid.CheckText = Nothing
        Me.xlk_accesid.ComboMode = False
        Me.xlk_accesid.DataMember = Nothing
        Me.xlk_accesid.DataSource = Me.LibXConnector1
        Me.xlk_accesid.DestParameters = New String() {"accessid=accessid", "description=description", "accesskey=accesskey"}
        Me.xlk_accesid.FilterField = Nothing
        Me.xlk_accesid.IgnoreFindInBrowseMode = True
        Me.xlk_accesid.isCanceled = False
        Me.xlk_accesid.Location = New System.Drawing.Point(408, 240)
        Me.xlk_accesid.LookCaption = ""
        Me.xlk_accesid.Name = "xlk_accesid"
        Me.xlk_accesid.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_accesid.ShowMessageNotFound = True
        Me.xlk_accesid.ShowWarning = False
        Me.xlk_accesid.Size = New System.Drawing.Size(16, 20)
        Me.xlk_accesid.SizesColumns = Nothing
        Me.xlk_accesid.SizesColumnsTab = Nothing
        Me.xlk_accesid.SqlString = Nothing
        Me.xlk_accesid.SQLTab = Nothing
        Me.xlk_accesid.SrcParameters = New String() {"accessid=accessid"}
        Me.xlk_accesid.TabIndex = 3
        Me.xlk_accesid.TableName = "scaccess"
        Me.xlk_accesid.UseCopyConnection = False
        Me.xlk_accesid.UseRowRetrieveEvents = False
        Me.xlk_accesid.UseTab = False
        Me.xlk_accesid.VisParameters = New String() {"Permiso ID=accessid", "Descripcion=description"}
        Me.xlk_accesid.WhereCondition = Nothing
        Me.xlk_accesid.WhereParameters = Nothing
        '
        'gColdescription
        '
        Me.gColdescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColdescription.Format = ""
        Me.gColdescription.FormatInfo = Nothing
        Me.gColdescription.HeaderText = "Descripcion"
        Me.gColdescription.ImageList = Nothing
        Me.gColdescription.isReadOnly = True
        Me.gColdescription.MappingName = "description"
        Me.gColdescription.MaxLength = 32767
        Me.gColdescription.ReadOnly = True
        Me.gColdescription.TabStop = True
        Me.gColdescription.UseCustomCellFormat = False
        Me.gColdescription.Width = 300
        '
        'gColaccesskey
        '
        Me.gColaccesskey.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColaccesskey.Format = ""
        Me.gColaccesskey.FormatInfo = Nothing
        Me.gColaccesskey.HeaderText = "Acess Key"
        Me.gColaccesskey.ImageList = Nothing
        Me.gColaccesskey.isReadOnly = True
        Me.gColaccesskey.MappingName = "accesskey"
        Me.gColaccesskey.MaxLength = 32767
        Me.gColaccesskey.ReadOnly = True
        Me.gColaccesskey.TabStop = True
        Me.gColaccesskey.UseCustomCellFormat = False
        Me.gColaccesskey.Width = 75
        '
        'i_asign01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 534)
        Me.Controls.Add(Me.xlk_accesid)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "i_asign01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Asignar Permisos"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
