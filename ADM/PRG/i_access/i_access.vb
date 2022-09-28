Public Class i_access
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
    Friend WithEvents vend_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents groupname As System.Windows.Forms.TextBox
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents xlk_progid As LibX.LibXLookup
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XDataGridTextButtonColumn1 As LibX.XDataGridTextButtonColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents txtgroupid As System.Windows.Forms.TextBox
    Friend WithEvents menu_name As System.Windows.Forms.TextBox
    Friend WithEvents txtmenu_code As System.Windows.Forms.TextBox
    Friend WithEvents txtuserid As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXShortNavigator1 = New LibX.LibXShortNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.vend_name = New System.Windows.Forms.TextBox
        Me.txtuserid = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.groupname = New System.Windows.Forms.TextBox
        Me.txtgroupid = New System.Windows.Forms.TextBox
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.menu_name = New System.Windows.Forms.TextBox
        Me.txtmenu_code = New System.Windows.Forms.TextBox
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.Label2 = New System.Windows.Forms.Label
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XDataGridTextButtonColumn1 = New LibX.XDataGridTextButtonColumn
        Me.xlk_progid = New LibX.LibXLookup
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibXShortNavigator1
        '
        Me.LibXShortNavigator1.BuildMenu = True
        Me.LibXShortNavigator1.Connector = Me.LibXConnector1
        Me.LibXShortNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXShortNavigator1.FirstControlInEditMode = Nothing
        Me.LibXShortNavigator1.FirstControlInFindMode = Nothing
        Me.LibXShortNavigator1.FirstControlInNewMode = Nothing
        Me.LibXShortNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXShortNavigator1.Name = "LibXShortNavigator1"
        Me.LibXShortNavigator1.Size = New System.Drawing.Size(400, 24)
        Me.LibXShortNavigator1.TabIndex = 0
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
        Me.LibXConnector1.DataMember = Nothing
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
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
        Me.LibXDbSourceTable1.Source = New String() {"select scaccess.accesid,scaccess.menu_code,scaccess.groupid,scaccess.userid", "from scaccess"}
        Me.LibXDbSourceTable1.TableName = "scgroups"
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
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"menu_code=menu_code", "groupid=groupid", "userid=userid"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = "accesid"
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select scaccess.*,stmenud.descr ", "from scaccess inner join stmenud on scaccess.progid = stmenud.progid"}
        Me.LibXDbSourceTable2.TableName = "scaccess"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.vend_name)
        Me.GroupBox1.Controls.Add(Me.txtuserid)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.groupname)
        Me.GroupBox1.Controls.Add(Me.txtgroupid)
        Me.GroupBox1.Controls.Add(Me.LibXLookup2)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.menu_name)
        Me.GroupBox1.Controls.Add(Me.txtmenu_code)
        Me.GroupBox1.Controls.Add(Me.LibXLookup3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 120)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(24, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "UserID:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'vend_name
        '
        Me.vend_name.Location = New System.Drawing.Point(136, 88)
        Me.vend_name.Name = "vend_name"
        Me.vend_name.ReadOnly = True
        Me.vend_name.Size = New System.Drawing.Size(224, 20)
        Me.vend_name.TabIndex = 6
        Me.vend_name.TabStop = False
        Me.vend_name.Text = ""
        '
        'txtuserid
        '
        Me.txtuserid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "scgroups.userid"))
        Me.txtuserid.Location = New System.Drawing.Point(72, 88)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(56, 20)
        Me.txtuserid.TabIndex = 3
        Me.txtuserid.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AccessID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "scgroups.accesid"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(72, 16)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox1.TabIndex = 0
        Me.XTextBox1.TabStop = False
        Me.XTextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(28, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Grupo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'groupname
        '
        Me.groupname.Location = New System.Drawing.Point(136, 64)
        Me.groupname.Name = "groupname"
        Me.groupname.ReadOnly = True
        Me.groupname.Size = New System.Drawing.Size(224, 20)
        Me.groupname.TabIndex = 6
        Me.groupname.TabStop = False
        Me.groupname.Text = ""
        '
        'txtgroupid
        '
        Me.txtgroupid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "scgroups.groupid"))
        Me.txtgroupid.Location = New System.Drawing.Point(72, 64)
        Me.txtgroupid.Name = "txtgroupid"
        Me.txtgroupid.Size = New System.Drawing.Size(56, 20)
        Me.txtgroupid.TabIndex = 5
        Me.txtgroupid.Text = ""
        '
        'LibXLookup2
        '
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"groupid=groupid", "groupname=groupname"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.Location = New System.Drawing.Point(360, 64)
        Me.LibXLookup2.LookCaption = Nothing
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.ShowMessageNotFound = True
        Me.LibXLookup2.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup2.SqlString = Nothing
        Me.LibXLookup2.SrcParameters = New String() {"groupid=groupid"}
        Me.LibXLookup2.TabIndex = 6
        Me.LibXLookup2.TableName = "scgroups"
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.VisParameters = New String() {"Código=groupid", "Nombre=groupname"}
        Me.LibXLookup2.WhereCondition = Nothing
        '
        'LibXLookup1
        '
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"userid=userid", "vend_name=vend_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.Location = New System.Drawing.Point(360, 88)
        Me.LibXLookup1.LookCaption = "Usuarios"
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SqlString = New String() {"select scusers.userid,scusers.username,ftvendm.vend_name", "from scusers inner join ftvendm on scusers.vend_code=ftvendm.vend_code"}
        Me.LibXLookup1.SrcParameters = New String() {"userid=userid"}
        Me.LibXLookup1.TabIndex = 6
        Me.LibXLookup1.TableName = "scusers"
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.VisParameters = New String() {"Código=userid", "User ID=username", "Nombre=vend_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        '
        'menu_name
        '
        Me.menu_name.Location = New System.Drawing.Point(136, 40)
        Me.menu_name.Name = "menu_name"
        Me.menu_name.ReadOnly = True
        Me.menu_name.Size = New System.Drawing.Size(224, 20)
        Me.menu_name.TabIndex = 6
        Me.menu_name.TabStop = False
        Me.menu_name.Text = ""
        '
        'txtmenu_code
        '
        Me.txtmenu_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "scgroups.menu_code"))
        Me.txtmenu_code.Location = New System.Drawing.Point(72, 40)
        Me.txtmenu_code.Name = "txtmenu_code"
        Me.txtmenu_code.Size = New System.Drawing.Size(56, 20)
        Me.txtmenu_code.TabIndex = 5
        Me.txtmenu_code.Text = ""
        '
        'LibXLookup3
        '
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Me.LibXConnector1
        Me.LibXLookup3.DestParameters = New String() {"menu_code=menu_code", "menu_name=descr"}
        Me.LibXLookup3.FilterField = Nothing
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.Location = New System.Drawing.Point(360, 40)
        Me.LibXLookup3.LookCaption = "Sistemas"
        Me.LibXLookup3.Name = "LibXLookup3"
        Me.LibXLookup3.ShowMessageNotFound = True
        Me.LibXLookup3.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup3.SqlString = Nothing
        Me.LibXLookup3.SrcParameters = New String() {"menu_code=menu_code"}
        Me.LibXLookup3.TabIndex = 6
        Me.LibXLookup3.TableName = "stmenue"
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.VisParameters = New String() {"Código=menu_code", "Nombre=descr"}
        Me.LibXLookup3.WhereCondition = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(19, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Sistema:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Opciones"
        Me.LibXGrid1.DataMember = "scaccess"
        Me.LibXGrid1.DataSource = Me.LibXConnector1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 160)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(384, 144)
        Me.LibXGrid1.TabIndex = 2
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XDataGridTextButtonColumn1, Me.XEditTextBoxColumn1})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "scaccess"
        '
        'XDataGridTextButtonColumn1
        '
        Me.XDataGridTextButtonColumn1.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.XDataGridTextButtonColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XDataGridTextButtonColumn1.executeFindDuringFill = True
        Me.XDataGridTextButtonColumn1.Format = ""
        Me.XDataGridTextButtonColumn1.FormatInfo = Nothing
        Me.XDataGridTextButtonColumn1.HeaderText = "Opción ID"
        Me.XDataGridTextButtonColumn1.isReadOnly = False
        Me.XDataGridTextButtonColumn1.Lookup = Me.xlk_progid
        Me.XDataGridTextButtonColumn1.MappingName = "progid"
        Me.XDataGridTextButtonColumn1.MaxLength = 32767
        Me.XDataGridTextButtonColumn1.UseCustomCellFormat = False
        Me.XDataGridTextButtonColumn1.Width = 75
        '
        'xlk_progid
        '
        Me.xlk_progid.DataMember = Nothing
        Me.xlk_progid.DataSource = Me.LibXConnector1
        Me.xlk_progid.DestParameters = New String() {"progid=progid", "descr=descr"}
        Me.xlk_progid.FilterField = Nothing
        Me.xlk_progid.IgnoreFindInBrowseMode = False
        Me.xlk_progid.Location = New System.Drawing.Point(240, 232)
        Me.xlk_progid.LookCaption = "Opciones"
        Me.xlk_progid.Name = "xlk_progid"
        Me.xlk_progid.ShowMessageNotFound = True
        Me.xlk_progid.Size = New System.Drawing.Size(16, 20)
        Me.xlk_progid.SqlString = Nothing
        Me.xlk_progid.SrcParameters = New String() {"progid=progid"}
        Me.xlk_progid.TabIndex = 3
        Me.xlk_progid.TableName = "stmenud"
        Me.xlk_progid.UseCopyConnection = False
        Me.xlk_progid.UseRowRetrieveEvents = False
        Me.xlk_progid.VisParameters = New String() {"Opción ID=progid", "Descripción=descr"}
        Me.xlk_progid.WhereCondition = Nothing
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Descripción"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "descr"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.ReadOnly = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 250
        '
        'i_access
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(400, 333)
        Me.Controls.Add(Me.xlk_progid)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXShortNavigator1)
        Me.Name = "i_access"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Accesos"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
