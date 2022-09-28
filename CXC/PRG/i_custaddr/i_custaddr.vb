Public Class i_custaddr
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
    Friend WithEvents LibXNavigator1 As LibX.LibXShortNavigator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents cust_name As System.Windows.Forms.TextBox
    Friend WithEvents lk_cust_code As LibX.LibXLookup
    Friend WithEvents txtcust_code As System.Windows.Forms.TextBox
    Friend WithEvents xlk_city_code As LibX.LibXLookup
    Friend WithEvents city_name As System.Windows.Forms.TextBox
    Friend WithEvents state_name As System.Windows.Forms.TextBox
    Friend WithEvents sector_name As System.Windows.Forms.TextBox
    Friend WithEvents xlk_state_code As LibX.LibXLookup
    Friend WithEvents xlk_sector_code As LibX.LibXLookup
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXShortNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xlk_city_code = New LibX.LibXLookup
        Me.txtcust_code = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cust_name = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.city_name = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.state_name = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.sector_name = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.xlk_state_code = New LibX.LibXLookup
        Me.xlk_sector_code = New LibX.LibXLookup
        Me.lk_cust_code = New LibX.LibXLookup
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(448, 24)
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
        Me.LibXConnector1.DataMember = Nothing
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
        Me.LibXConnector1.ReportName = Nothing
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
        Me.LibXDbSourceTable1.KeyFields = ""
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "addr_code"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ccaddrm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xlk_city_code)
        Me.GroupBox1.Controls.Add(Me.txtcust_code)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cust_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.city_name)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.state_name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.sector_name)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox11)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox12)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBox14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBox15)
        Me.GroupBox1.Controls.Add(Me.xlk_state_code)
        Me.GroupBox1.Controls.Add(Me.xlk_sector_code)
        Me.GroupBox1.Controls.Add(Me.lk_cust_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 248)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'xlk_city_code
        '
        Me.xlk_city_code.CheckText = Nothing
        Me.xlk_city_code.DataMember = Nothing
        Me.xlk_city_code.DataSource = Me.LibXConnector1
        Me.xlk_city_code.DestParameters = New String() {"city_code=city_code", "city_name=city_name"}
        Me.xlk_city_code.FilterField = Nothing
        Me.xlk_city_code.IgnoreFindInBrowseMode = False
        Me.xlk_city_code.Location = New System.Drawing.Point(392, 96)
        Me.xlk_city_code.LookCaption = "Ciudades"
        Me.xlk_city_code.Name = "xlk_city_code"
        Me.xlk_city_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_city_code.ShowMessageNotFound = True
        Me.xlk_city_code.ShowWarning = False
        Me.xlk_city_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_city_code.SizesColumns = Nothing
        Me.xlk_city_code.SizesColumnsTab = Nothing
        Me.xlk_city_code.SqlString = Nothing
        Me.xlk_city_code.SQLTab = Nothing
        Me.xlk_city_code.SrcParameters = New String() {"city_code=city_code"}
        Me.xlk_city_code.TabIndex = 2
        Me.xlk_city_code.TableName = "cccity"
        Me.xlk_city_code.UseCopyConnection = False
        Me.xlk_city_code.UseRowRetrieveEvents = False
        Me.xlk_city_code.UseTab = False
        Me.xlk_city_code.VisParameters = New String() {"Código=city_code", "Nombre=city_name"}
        Me.xlk_city_code.WhereCondition = Nothing
        Me.xlk_city_code.WhereParameters = Nothing
        '
        'txtcust_code
        '
        Me.txtcust_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ccaddrm.cust_code"))
        Me.txtcust_code.Location = New System.Drawing.Point(72, 24)
        Me.txtcust_code.Name = "txtcust_code"
        Me.txtcust_code.ReadOnly = True
        Me.txtcust_code.Size = New System.Drawing.Size(48, 20)
        Me.txtcust_code.TabIndex = 1
        Me.txtcust_code.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cust_name
        '
        Me.cust_name.Location = New System.Drawing.Point(128, 24)
        Me.cust_name.Name = "cust_name"
        Me.cust_name.ReadOnly = True
        Me.cust_name.Size = New System.Drawing.Size(264, 20)
        Me.cust_name.TabIndex = 1
        Me.cust_name.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(19, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Número:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ccaddrm.addr_code"))
        Me.TextBox3.Location = New System.Drawing.Point(72, 48)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(48, 20)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(24, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ciudad:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ccaddrm.city_code"))
        Me.TextBox4.Location = New System.Drawing.Point(72, 96)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(48, 20)
        Me.TextBox4.TabIndex = 2
        Me.TextBox4.Text = ""
        '
        'city_name
        '
        Me.city_name.Location = New System.Drawing.Point(128, 96)
        Me.city_name.Name = "city_name"
        Me.city_name.ReadOnly = True
        Me.city_name.Size = New System.Drawing.Size(264, 20)
        Me.city_name.TabIndex = 1
        Me.city_name.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(13, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Provincia:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ccaddrm.state_code"))
        Me.TextBox6.Location = New System.Drawing.Point(72, 120)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(48, 20)
        Me.TextBox6.TabIndex = 3
        Me.TextBox6.Text = ""
        '
        'state_name
        '
        Me.state_name.Location = New System.Drawing.Point(128, 120)
        Me.state_name.Name = "state_name"
        Me.state_name.ReadOnly = True
        Me.state_name.Size = New System.Drawing.Size(264, 20)
        Me.state_name.TabIndex = 1
        Me.state_name.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(27, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sector:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ccaddrm.sector_code"))
        Me.TextBox8.Location = New System.Drawing.Point(72, 144)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(48, 20)
        Me.TextBox8.TabIndex = 4
        Me.TextBox8.Text = ""
        '
        'sector_name
        '
        Me.sector_name.Location = New System.Drawing.Point(128, 144)
        Me.sector_name.Name = "sector_name"
        Me.sector_name.ReadOnly = True
        Me.sector_name.Size = New System.Drawing.Size(264, 20)
        Me.sector_name.TabIndex = 1
        Me.sector_name.Text = ""
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ccaddrm.addr_name"))
        Me.TextBox10.Location = New System.Drawing.Point(72, 72)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(344, 20)
        Me.TextBox10.TabIndex = 1
        Me.TextBox10.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(19, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nombre:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ccaddrm.street"))
        Me.TextBox11.Location = New System.Drawing.Point(72, 168)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(344, 20)
        Me.TextBox11.TabIndex = 5
        Me.TextBox11.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(34, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Calle:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ccaddrm.numero"))
        Me.TextBox12.Location = New System.Drawing.Point(72, 192)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(48, 20)
        Me.TextBox12.TabIndex = 6
        Me.TextBox12.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(19, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Número:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(280, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Teléfono:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ccaddrm.phone"))
        Me.TextBox13.Location = New System.Drawing.Point(336, 192)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(80, 20)
        Me.TextBox13.TabIndex = 8
        Me.TextBox13.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(14, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Contacto:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ccaddrm.contact_name"))
        Me.TextBox14.Location = New System.Drawing.Point(72, 216)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(344, 20)
        Me.TextBox14.TabIndex = 9
        Me.TextBox14.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(128, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Código de area:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ccaddrm.area_code"))
        Me.TextBox15.Location = New System.Drawing.Point(224, 192)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(48, 20)
        Me.TextBox15.TabIndex = 7
        Me.TextBox15.Text = ""
        '
        'xlk_state_code
        '
        Me.xlk_state_code.CheckText = Nothing
        Me.xlk_state_code.DataMember = Nothing
        Me.xlk_state_code.DataSource = Me.LibXConnector1
        Me.xlk_state_code.DestParameters = New String() {"state_code=state_code", "state_name=state_name"}
        Me.xlk_state_code.FilterField = Nothing
        Me.xlk_state_code.IgnoreFindInBrowseMode = False
        Me.xlk_state_code.Location = New System.Drawing.Point(392, 120)
        Me.xlk_state_code.LookCaption = "Provincias"
        Me.xlk_state_code.Name = "xlk_state_code"
        Me.xlk_state_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_state_code.ShowMessageNotFound = True
        Me.xlk_state_code.ShowWarning = False
        Me.xlk_state_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_state_code.SizesColumns = Nothing
        Me.xlk_state_code.SizesColumnsTab = Nothing
        Me.xlk_state_code.SqlString = Nothing
        Me.xlk_state_code.SQLTab = Nothing
        Me.xlk_state_code.SrcParameters = New String() {"state_code=state_code"}
        Me.xlk_state_code.TabIndex = 2
        Me.xlk_state_code.TableName = "ccstate"
        Me.xlk_state_code.UseCopyConnection = False
        Me.xlk_state_code.UseRowRetrieveEvents = False
        Me.xlk_state_code.UseTab = False
        Me.xlk_state_code.VisParameters = New String() {"Código=state_code", "Nombre=state_name"}
        Me.xlk_state_code.WhereCondition = Nothing
        Me.xlk_state_code.WhereParameters = Nothing
        '
        'xlk_sector_code
        '
        Me.xlk_sector_code.CheckText = Nothing
        Me.xlk_sector_code.DataMember = Nothing
        Me.xlk_sector_code.DataSource = Me.LibXConnector1
        Me.xlk_sector_code.DestParameters = New String() {"sector_code=sector_code", "sector_name=sector_name"}
        Me.xlk_sector_code.FilterField = Nothing
        Me.xlk_sector_code.IgnoreFindInBrowseMode = False
        Me.xlk_sector_code.Location = New System.Drawing.Point(392, 144)
        Me.xlk_sector_code.LookCaption = "Sectores"
        Me.xlk_sector_code.Name = "xlk_sector_code"
        Me.xlk_sector_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_sector_code.ShowMessageNotFound = True
        Me.xlk_sector_code.ShowWarning = False
        Me.xlk_sector_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_sector_code.SizesColumns = Nothing
        Me.xlk_sector_code.SizesColumnsTab = Nothing
        Me.xlk_sector_code.SqlString = Nothing
        Me.xlk_sector_code.SQLTab = Nothing
        Me.xlk_sector_code.SrcParameters = New String() {"sector_code=sector_code"}
        Me.xlk_sector_code.TabIndex = 2
        Me.xlk_sector_code.TableName = "ccsectorm"
        Me.xlk_sector_code.UseCopyConnection = False
        Me.xlk_sector_code.UseRowRetrieveEvents = False
        Me.xlk_sector_code.UseTab = False
        Me.xlk_sector_code.VisParameters = New String() {"Sector=sector_code", "Nombre=sector_name"}
        Me.xlk_sector_code.WhereCondition = Nothing
        Me.xlk_sector_code.WhereParameters = Nothing
        '
        'lk_cust_code
        '
        Me.lk_cust_code.CheckText = Nothing
        Me.lk_cust_code.DataMember = Nothing
        Me.lk_cust_code.DataSource = Me.LibXConnector1
        Me.lk_cust_code.DestParameters = New String() {"cust_code=cust_code", "cust_name=cust_name"}
        Me.lk_cust_code.FilterField = Nothing
        Me.lk_cust_code.IgnoreFindInBrowseMode = False
        Me.lk_cust_code.Location = New System.Drawing.Point(392, 24)
        Me.lk_cust_code.LookCaption = "Clientes"
        Me.lk_cust_code.Name = "lk_cust_code"
        Me.lk_cust_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lk_cust_code.ShowMessageNotFound = True
        Me.lk_cust_code.ShowWarning = False
        Me.lk_cust_code.Size = New System.Drawing.Size(16, 20)
        Me.lk_cust_code.SizesColumns = Nothing
        Me.lk_cust_code.SizesColumnsTab = Nothing
        Me.lk_cust_code.SqlString = Nothing
        Me.lk_cust_code.SQLTab = Nothing
        Me.lk_cust_code.SrcParameters = New String() {"cust_code=cust_code"}
        Me.lk_cust_code.TabIndex = 2
        Me.lk_cust_code.TableName = "cccustm"
        Me.lk_cust_code.UseCopyConnection = False
        Me.lk_cust_code.UseRowRetrieveEvents = False
        Me.lk_cust_code.UseTab = False
        Me.lk_cust_code.VisParameters = New String() {"Código=cust_code", "Nombre=cust_name"}
        Me.lk_cust_code.WhereCondition = Nothing
        Me.lk_cust_code.WhereParameters = Nothing
        '
        'i_custaddr
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 309)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Name = "i_custaddr"
        Me.Text = "Direcciones"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub i_addrss01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FillItem()
        Try
            If Not LibXConnector1.Parameters Is Nothing Then
                If CType(LibXConnector1.Parameters.Value, String).Trim.Length > 0 Then
                    txtcust_code.Text = LibXConnector1.Parameters.Value
                    lk_cust_code.ExecuteFind()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        ' 
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction

    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try

            If e.Action = LibX.LibxConnectionActions.Add Then
                FillItem()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub


End Class
