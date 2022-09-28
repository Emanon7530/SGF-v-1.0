Public Class i_adbanco01
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
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents xtxt_ban_code As LibX.XMaskEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents xtxt_ban_name As LibX.XTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents XMaskEdit1 As LibX.XMaskEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents XMaskEdit2 As LibX.XMaskEdit
    Friend WithEvents xlk_sector As LibX.LibXLookup
    Friend WithEvents txtsector_name As LibX.XTextBox
    Friend WithEvents xlk_city As LibX.LibXLookup
    Friend WithEvents txtcity_name As LibX.XTextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents XMaskEdit3 As LibX.XMaskEdit
    Friend WithEvents XMaskEdit4 As LibX.XMaskEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.xtxt_ban_code = New LibX.XMaskEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.xtxt_ban_name = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.XMaskEdit1 = New LibX.XMaskEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.XMaskEdit2 = New LibX.XMaskEdit
        Me.xlk_sector = New LibX.LibXLookup
        Me.txtsector_name = New LibX.XTextBox
        Me.xlk_city = New LibX.LibXLookup
        Me.txtcity_name = New LibX.XTextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.XMaskEdit3 = New LibX.XMaskEdit
        Me.XMaskEdit4 = New LibX.XMaskEdit
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.xlk_sector)
        Me.GroupBox1.Controls.Add(Me.txtsector_name)
        Me.GroupBox1.Controls.Add(Me.xlk_city)
        Me.GroupBox1.Controls.Add(Me.txtcity_name)
        Me.GroupBox1.Controls.Add(Me.xtxt_ban_name)
        Me.GroupBox1.Controls.Add(Me.xtxt_ban_code)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit2)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit3)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit4)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 320)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_ban_name
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_ban_name
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_ban_name
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(682, 24)
        Me.LibXNavigator1.TabIndex = 0
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
        Me.LibXConnector1.DataMember = "ftbanco"
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
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
        Me.LibXDbSourceTable1.SerialColumnName = "ban_code"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ftbanco"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.DataTable1.TableName = "ftbanco"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "ban_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "ban_name"
        Me.DataColumn2.MaxLength = 40
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "address"
        Me.DataColumn3.MaxLength = 80
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "city_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sector_code"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "phone"
        Me.DataColumn6.MaxLength = 20
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "phone1"
        Me.DataColumn7.MaxLength = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(25, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_ban_code
        '
        Me.xtxt_ban_code.AcceptsReturn = True
        Me.xtxt_ban_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftbanco.ban_code"))
        Me.xtxt_ban_code.EditInitialValue = Nothing
        Me.xtxt_ban_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_ban_code.FieldDescription = ""
        Me.xtxt_ban_code.FindInitialValue = Nothing
        Me.xtxt_ban_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_ban_code.IgnoreRequiered = False
        Me.xtxt_ban_code.Location = New System.Drawing.Point(80, 16)
        Me.xtxt_ban_code.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxt_ban_code.Name = "xtxt_ban_code"
        Me.xtxt_ban_code.NewInitialValue = Nothing
        Me.xtxt_ban_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_ban_code.Requiered = False
        Me.xtxt_ban_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_ban_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_ban_code.TabIndex = 0
        Me.xtxt_ban_code.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_ban_name
        '
        Me.xtxt_ban_name.AcceptsReturn = True
        Me.xtxt_ban_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftbanco.ban_name"))
        Me.xtxt_ban_name.EditInitialValue = Nothing
        Me.xtxt_ban_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_ban_name.FieldDescription = ""
        Me.xtxt_ban_name.FindInitialValue = Nothing
        Me.xtxt_ban_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_ban_name.IgnoreRequiered = False
        Me.xtxt_ban_name.Location = New System.Drawing.Point(80, 40)
        Me.xtxt_ban_name.Name = "xtxt_ban_name"
        Me.xtxt_ban_name.NewInitialValue = Nothing
        Me.xtxt_ban_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_ban_name.Requiered = False
        Me.xtxt_ban_name.Size = New System.Drawing.Size(376, 20)
        Me.xtxt_ban_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_ban_name.TabIndex = 1
        Me.xtxt_ban_name.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(9, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Dirección:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftbanco.address"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(80, 64)
        Me.XTextBox1.Multiline = True
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(376, 72)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 2
        Me.XTextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(13, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Telefono:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XMaskEdit1
        '
        Me.XMaskEdit1.AcceptsReturn = True
        Me.XMaskEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftbanco.phone"))
        Me.XMaskEdit1.EditInitialValue = Nothing
        Me.XMaskEdit1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.FieldDescription = ""
        Me.XMaskEdit1.FindInitialValue = Nothing
        Me.XMaskEdit1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.IgnoreRequiered = False
        Me.XMaskEdit1.Location = New System.Drawing.Point(80, 192)
        Me.XMaskEdit1.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.XMaskEdit1.Name = "XMaskEdit1"
        Me.XMaskEdit1.NewInitialValue = Nothing
        Me.XMaskEdit1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.Requiered = False
        Me.XMaskEdit1.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit1.TabIndex = 5
        Me.XMaskEdit1.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(296, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Telefono:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XMaskEdit2
        '
        Me.XMaskEdit2.AcceptsReturn = True
        Me.XMaskEdit2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftbanco.phone1"))
        Me.XMaskEdit2.EditInitialValue = Nothing
        Me.XMaskEdit2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit2.FieldDescription = ""
        Me.XMaskEdit2.FindInitialValue = Nothing
        Me.XMaskEdit2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit2.IgnoreRequiered = False
        Me.XMaskEdit2.Location = New System.Drawing.Point(360, 192)
        Me.XMaskEdit2.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.XMaskEdit2.Name = "XMaskEdit2"
        Me.XMaskEdit2.NewInitialValue = Nothing
        Me.XMaskEdit2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit2.Requiered = False
        Me.XMaskEdit2.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit2.TabIndex = 6
        Me.XMaskEdit2.Text = ""
        '
        'xlk_sector
        '
        Me.xlk_sector.AlternateFieldSearch = Nothing
        Me.xlk_sector.CheckText = Nothing
        Me.xlk_sector.ComboMode = False
        Me.xlk_sector.DataMember = Nothing
        Me.xlk_sector.DataSource = Me.LibXConnector1
        Me.xlk_sector.DestParameters = New String() {"txtsector_code=sector_code", "txtsector_name=sector_name"}
        Me.xlk_sector.FilterField = Nothing
        Me.xlk_sector.IgnoreFindInBrowseMode = False
        Me.xlk_sector.isCanceled = False
        Me.xlk_sector.Location = New System.Drawing.Point(440, 168)
        Me.xlk_sector.LookCaption = Nothing
        Me.xlk_sector.Name = "xlk_sector"
        Me.xlk_sector.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_sector.ShowMessageNotFound = True
        Me.xlk_sector.ShowWarning = False
        Me.xlk_sector.Size = New System.Drawing.Size(16, 20)
        Me.xlk_sector.SizesColumns = Nothing
        Me.xlk_sector.SizesColumnsTab = Nothing
        Me.xlk_sector.SqlString = New String() {Nothing}
        Me.xlk_sector.SQLTab = Nothing
        Me.xlk_sector.SrcParameters = New String() {"sector_code=sector_code"}
        Me.xlk_sector.TabIndex = 53
        Me.xlk_sector.TableName = "ccsectorm"
        Me.xlk_sector.TabStop = False
        Me.xlk_sector.UseCopyConnection = False
        Me.xlk_sector.UseRowRetrieveEvents = False
        Me.xlk_sector.UseTab = False
        Me.xlk_sector.VisParameters = New String() {"Código=sector_code", "Descripción=sector_name"}
        Me.xlk_sector.WhereCondition = Nothing
        Me.xlk_sector.WhereParameters = Nothing
        '
        'txtsector_name
        '
        Me.txtsector_name.AcceptsReturn = True
        Me.txtsector_name.EditInitialValue = Nothing
        Me.txtsector_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsector_name.FieldDescription = ""
        Me.txtsector_name.FindInitialValue = Nothing
        Me.txtsector_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsector_name.IgnoreRequiered = False
        Me.txtsector_name.Location = New System.Drawing.Point(144, 168)
        Me.txtsector_name.Name = "txtsector_name"
        Me.txtsector_name.NewInitialValue = Nothing
        Me.txtsector_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsector_name.ReadOnly = True
        Me.txtsector_name.Requiered = False
        Me.txtsector_name.Size = New System.Drawing.Size(296, 20)
        Me.txtsector_name.StatusBarPanelDescripcion = Nothing
        Me.txtsector_name.TabIndex = 52
        Me.txtsector_name.TabStop = False
        Me.txtsector_name.Text = ""
        '
        'xlk_city
        '
        Me.xlk_city.AlternateFieldSearch = Nothing
        Me.xlk_city.CheckText = Nothing
        Me.xlk_city.ComboMode = False
        Me.xlk_city.DataMember = Nothing
        Me.xlk_city.DataSource = Me.LibXConnector1
        Me.xlk_city.DestParameters = New String() {"txtcity_code=city_code", "txtcity_name=city_name"}
        Me.xlk_city.FilterField = Nothing
        Me.xlk_city.IgnoreFindInBrowseMode = False
        Me.xlk_city.isCanceled = False
        Me.xlk_city.Location = New System.Drawing.Point(440, 144)
        Me.xlk_city.LookCaption = Nothing
        Me.xlk_city.Name = "xlk_city"
        Me.xlk_city.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_city.ShowMessageNotFound = True
        Me.xlk_city.ShowWarning = False
        Me.xlk_city.Size = New System.Drawing.Size(16, 20)
        Me.xlk_city.SizesColumns = Nothing
        Me.xlk_city.SizesColumnsTab = Nothing
        Me.xlk_city.SqlString = Nothing
        Me.xlk_city.SQLTab = Nothing
        Me.xlk_city.SrcParameters = New String() {"city_code=city_code"}
        Me.xlk_city.TabIndex = 51
        Me.xlk_city.TableName = "cccity"
        Me.xlk_city.TabStop = False
        Me.xlk_city.UseCopyConnection = False
        Me.xlk_city.UseRowRetrieveEvents = False
        Me.xlk_city.UseTab = False
        Me.xlk_city.VisParameters = New String() {"Código=city_code", "Descripción=city_name"}
        Me.xlk_city.WhereCondition = Nothing
        Me.xlk_city.WhereParameters = Nothing
        '
        'txtcity_name
        '
        Me.txtcity_name.AcceptsReturn = True
        Me.txtcity_name.EditInitialValue = Nothing
        Me.txtcity_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcity_name.FieldDescription = ""
        Me.txtcity_name.FindInitialValue = Nothing
        Me.txtcity_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcity_name.IgnoreRequiered = False
        Me.txtcity_name.Location = New System.Drawing.Point(144, 144)
        Me.txtcity_name.Name = "txtcity_name"
        Me.txtcity_name.NewInitialValue = Nothing
        Me.txtcity_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcity_name.ReadOnly = True
        Me.txtcity_name.Requiered = False
        Me.txtcity_name.Size = New System.Drawing.Size(296, 20)
        Me.txtcity_name.StatusBarPanelDescripcion = Nothing
        Me.txtcity_name.TabIndex = 50
        Me.txtcity_name.TabStop = False
        Me.txtcity_name.Text = ""
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(24, 164)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(40, 16)
        Me.Label33.TabIndex = 55
        Me.Label33.Text = "Sector:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(21, 140)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(43, 16)
        Me.Label32.TabIndex = 54
        Me.Label32.Text = "Ciudad:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XMaskEdit3
        '
        Me.XMaskEdit3.AcceptsReturn = True
        Me.XMaskEdit3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftbanco.city_code"))
        Me.XMaskEdit3.EditInitialValue = Nothing
        Me.XMaskEdit3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit3.FieldDescription = ""
        Me.XMaskEdit3.FindInitialValue = Nothing
        Me.XMaskEdit3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit3.IgnoreRequiered = False
        Me.XMaskEdit3.Location = New System.Drawing.Point(80, 144)
        Me.XMaskEdit3.Masked = MaskedTextBox.Mask.Decimal
        Me.XMaskEdit3.Name = "XMaskEdit3"
        Me.XMaskEdit3.NewInitialValue = Nothing
        Me.XMaskEdit3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit3.Requiered = False
        Me.XMaskEdit3.Size = New System.Drawing.Size(56, 20)
        Me.XMaskEdit3.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit3.TabIndex = 3
        Me.XMaskEdit3.Text = ""
        '
        'XMaskEdit4
        '
        Me.XMaskEdit4.AcceptsReturn = True
        Me.XMaskEdit4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftbanco.sector_code"))
        Me.XMaskEdit4.EditInitialValue = Nothing
        Me.XMaskEdit4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit4.FieldDescription = ""
        Me.XMaskEdit4.FindInitialValue = Nothing
        Me.XMaskEdit4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit4.IgnoreRequiered = False
        Me.XMaskEdit4.Location = New System.Drawing.Point(80, 168)
        Me.XMaskEdit4.Masked = MaskedTextBox.Mask.Decimal
        Me.XMaskEdit4.Name = "XMaskEdit4"
        Me.XMaskEdit4.NewInitialValue = Nothing
        Me.XMaskEdit4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit4.Requiered = False
        Me.XMaskEdit4.Size = New System.Drawing.Size(56, 20)
        Me.XMaskEdit4.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit4.TabIndex = 4
        Me.XMaskEdit4.Text = ""
        '
        'i_adbanco01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(682, 383)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_adbanco01"
        Me.Text = "Bancos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
