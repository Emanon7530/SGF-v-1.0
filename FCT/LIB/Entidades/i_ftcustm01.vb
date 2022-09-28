Imports LibX
Public Class i_ftcustm01
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCompany As LibX.XTextBox
    Friend WithEvents txtContacto As LibX.XTextBox
    Friend WithEvents txtTelArea As LibX.XTextBox
    Friend WithEvents txtTel As LibX.XTextBox
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents txtPhone1 As LibX.XTextBox
    Friend WithEvents xlk_phone As LibX.LibXLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As LibX.XTextBox
    Friend WithEvents txtEmail As LibX.XTextBox
    Friend WithEvents txtPhone2 As LibX.XTextBox
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
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
    Friend WithEvents txtcity_code As LibX.XTextBox
    Friend WithEvents txtsector_code As LibX.XTextBox
    Friend WithEvents xlk_sector As LibX.LibXLookup
    Friend WithEvents txtsector_name As LibX.XTextBox
    Friend WithEvents xlk_city As LibX.LibXLookup
    Friend WithEvents txtcity_name As LibX.XTextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPhone1 = New LibX.XTextBox
        Me.xlk_phone = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
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
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.txtCompany = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtContacto = New LibX.XTextBox
        Me.txtTelArea = New LibX.XTextBox
        Me.txtTel = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAddress = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtEmail = New LibX.XTextBox
        Me.txtPhone2 = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtcity_code = New LibX.XTextBox
        Me.txtsector_code = New LibX.XTextBox
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.xlk_sector = New LibX.LibXLookup
        Me.txtsector_name = New LibX.XTextBox
        Me.xlk_city = New LibX.LibXLookup
        Me.txtcity_name = New LibX.XTextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.Label8 = New System.Windows.Forms.Label
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
        Me.GroupBox1.Controls.Add(Me.txtPhone1)
        Me.GroupBox1.Controls.Add(Me.xlk_phone)
        Me.GroupBox1.Controls.Add(Me.txtCompany)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtContacto)
        Me.GroupBox1.Controls.Add(Me.txtTelArea)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtPhone2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtcity_code)
        Me.GroupBox1.Controls.Add(Me.txtsector_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 256)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtPhone1
        '
        Me.txtPhone1.EditInitialValue = Nothing
        Me.txtPhone1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPhone1.Enabled = False
        Me.txtPhone1.FindInitialValue = Nothing
        Me.txtPhone1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPhone1.IgnoreRequiered = False
        Me.txtPhone1.Location = New System.Drawing.Point(192, 192)
        Me.txtPhone1.Name = "txtPhone1"
        Me.txtPhone1.NewInitialValue = Nothing
        Me.txtPhone1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPhone1.ReadOnly = True
        Me.txtPhone1.Requiered = False
        Me.txtPhone1.Size = New System.Drawing.Size(104, 20)
        Me.txtPhone1.TabIndex = 11
        Me.txtPhone1.TabStop = False
        Me.txtPhone1.Text = ""
        '
        'xlk_phone
        '
        Me.xlk_phone.CheckText = Nothing
        Me.xlk_phone.DataMember = Nothing
        Me.xlk_phone.DataSource = Me.LibXConnector1
        Me.xlk_phone.DestParameters = New String() {"txtPhone1=phone"}
        Me.xlk_phone.FilterField = Nothing
        Me.xlk_phone.IgnoreFindInBrowseMode = False
        Me.xlk_phone.Location = New System.Drawing.Point(240, 16)
        Me.xlk_phone.LookCaption = Nothing
        Me.xlk_phone.Name = "xlk_phone"
        Me.xlk_phone.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_phone.ShowMessageNotFound = True
        Me.xlk_phone.ShowWarning = False
        Me.xlk_phone.Size = New System.Drawing.Size(16, 20)
        Me.xlk_phone.SizesColumns = Nothing
        Me.xlk_phone.SizesColumnsTab = Nothing
        Me.xlk_phone.SqlString = Nothing
        Me.xlk_phone.SQLTab = Nothing
        Me.xlk_phone.SrcParameters = New String() {"txtPhone1=phone"}
        Me.xlk_phone.TabIndex = 2
        Me.xlk_phone.TableName = "ftcustm"
        Me.xlk_phone.UseCopyConnection = False
        Me.xlk_phone.UseRowRetrieveEvents = False
        Me.xlk_phone.UseTab = False
        Me.xlk_phone.VisParameters = New String() {"Teléfono=phone", "Company=company_name", "Nombre=cust_name", ""}
        Me.xlk_phone.WhereCondition = Nothing
        Me.xlk_phone.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "ftcustm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = True
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = Nothing
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportName = Nothing
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"phone"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn5}
        Me.DataTable1.TableName = "ftcustm"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "cust_name"
        Me.DataColumn1.MaxLength = 40
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "company_name"
        Me.DataColumn2.MaxLength = 40
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "area_code"
        Me.DataColumn3.MaxLength = 3
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "address"
        Me.DataColumn4.MaxLength = 60
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "phone"
        Me.DataColumn5.MaxLength = 8
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "email"
        Me.DataColumn6.MaxLength = 20
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "phone1"
        Me.DataColumn7.MaxLength = 8
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "ftserial_no"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sector_code"
        Me.DataColumn9.MaxLength = 3
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "city_code"
        Me.DataColumn10.MaxLength = 3
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
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = Nothing
        Me.LibXDbSourceTable2.TableName = "ftcustm"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'txtCompany
        '
        Me.txtCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompany.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcustm.company_name"))
        Me.txtCompany.EditInitialValue = Nothing
        Me.txtCompany.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCompany.FindInitialValue = Nothing
        Me.txtCompany.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCompany.IgnoreRequiered = False
        Me.txtCompany.Location = New System.Drawing.Point(136, 40)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.NewInitialValue = Nothing
        Me.txtCompany.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCompany.Requiered = False
        Me.txtCompany.Size = New System.Drawing.Size(352, 20)
        Me.txtCompany.TabIndex = 1
        Me.txtCompany.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(22, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Compañía Nombre:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(74, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contacto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(17, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Telefono(999-9999):"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtContacto
        '
        Me.txtContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContacto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcustm.cust_name"))
        Me.txtContacto.EditInitialValue = Nothing
        Me.txtContacto.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtContacto.FindInitialValue = Nothing
        Me.txtContacto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtContacto.IgnoreRequiered = False
        Me.txtContacto.Location = New System.Drawing.Point(136, 64)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.NewInitialValue = Nothing
        Me.txtContacto.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtContacto.Requiered = False
        Me.txtContacto.Size = New System.Drawing.Size(352, 20)
        Me.txtContacto.TabIndex = 2
        Me.txtContacto.Text = ""
        '
        'txtTelArea
        '
        Me.txtTelArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelArea.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcustm.area_code"))
        Me.txtTelArea.EditInitialValue = Nothing
        Me.txtTelArea.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTelArea.FindInitialValue = Nothing
        Me.txtTelArea.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTelArea.IgnoreRequiered = False
        Me.txtTelArea.Location = New System.Drawing.Point(136, 192)
        Me.txtTelArea.Name = "txtTelArea"
        Me.txtTelArea.NewInitialValue = Nothing
        Me.txtTelArea.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTelArea.Requiered = False
        Me.txtTelArea.Size = New System.Drawing.Size(48, 20)
        Me.txtTelArea.TabIndex = 4
        Me.txtTelArea.Text = ""
        '
        'txtTel
        '
        Me.txtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcustm.phone"))
        Me.txtTel.EditInitialValue = Nothing
        Me.txtTel.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTel.FindInitialValue = Nothing
        Me.txtTel.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTel.IgnoreRequiered = False
        Me.txtTel.Location = New System.Drawing.Point(136, 16)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.NewInitialValue = Nothing
        Me.txtTel.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTel.Requiered = False
        Me.txtTel.TabIndex = 0
        Me.txtTel.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(93, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Area:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAddress
        '
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcustm.address"))
        Me.txtAddress.EditInitialValue = Nothing
        Me.txtAddress.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAddress.FindInitialValue = Nothing
        Me.txtAddress.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAddress.IgnoreRequiered = False
        Me.txtAddress.Location = New System.Drawing.Point(136, 88)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.NewInitialValue = Nothing
        Me.txtAddress.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAddress.Requiered = False
        Me.txtAddress.Size = New System.Drawing.Size(352, 56)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(69, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Dirección:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(88, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Email:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcustm.email"))
        Me.txtEmail.EditInitialValue = Nothing
        Me.txtEmail.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtEmail.FindInitialValue = Nothing
        Me.txtEmail.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtEmail.IgnoreRequiered = False
        Me.txtEmail.Location = New System.Drawing.Point(136, 216)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.NewInitialValue = Nothing
        Me.txtEmail.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtEmail.Requiered = False
        Me.txtEmail.Size = New System.Drawing.Size(160, 20)
        Me.txtEmail.TabIndex = 6
        Me.txtEmail.Text = ""
        '
        'txtPhone2
        '
        Me.txtPhone2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPhone2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcustm.phone1"))
        Me.txtPhone2.EditInitialValue = Nothing
        Me.txtPhone2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPhone2.FindInitialValue = Nothing
        Me.txtPhone2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPhone2.IgnoreRequiered = False
        Me.txtPhone2.Location = New System.Drawing.Point(384, 192)
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.NewInitialValue = Nothing
        Me.txtPhone2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPhone2.Requiered = False
        Me.txtPhone2.Size = New System.Drawing.Size(104, 20)
        Me.txtPhone2.TabIndex = 5
        Me.txtPhone2.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(328, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Telefono:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtcity_code
        '
        Me.txtcity_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcustm.city_code"))
        Me.txtcity_code.EditInitialValue = Nothing
        Me.txtcity_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcity_code.FindInitialValue = Nothing
        Me.txtcity_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcity_code.IgnoreRequiered = False
        Me.txtcity_code.Location = New System.Drawing.Point(136, 147)
        Me.txtcity_code.Name = "txtcity_code"
        Me.txtcity_code.NewInitialValue = Nothing
        Me.txtcity_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcity_code.Requiered = False
        Me.txtcity_code.Size = New System.Drawing.Size(48, 20)
        Me.txtcity_code.TabIndex = 5
        Me.txtcity_code.Text = ""
        '
        'txtsector_code
        '
        Me.txtsector_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcustm.sector_code"))
        Me.txtsector_code.EditInitialValue = Nothing
        Me.txtsector_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsector_code.FindInitialValue = Nothing
        Me.txtsector_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsector_code.IgnoreRequiered = False
        Me.txtsector_code.Location = New System.Drawing.Point(136, 170)
        Me.txtsector_code.Name = "txtsector_code"
        Me.txtsector_code.NewInitialValue = Nothing
        Me.txtsector_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsector_code.Requiered = False
        Me.txtsector_code.Size = New System.Drawing.Size(49, 20)
        Me.txtsector_code.TabIndex = 6
        Me.txtsector_code.Text = ""
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
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ftcustm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'xlk_sector
        '
        Me.xlk_sector.CheckText = Nothing
        Me.xlk_sector.DataMember = Nothing
        Me.xlk_sector.DataSource = Me.LibXConnector1
        Me.xlk_sector.DestParameters = New String() {"txtsector_code=sector_code", "txtsector_name=sector_name"}
        Me.xlk_sector.FilterField = Nothing
        Me.xlk_sector.IgnoreFindInBrowseMode = False
        Me.xlk_sector.Location = New System.Drawing.Point(472, 171)
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
        Me.xlk_sector.UseCopyConnection = False
        Me.xlk_sector.UseRowRetrieveEvents = False
        Me.xlk_sector.UseTab = False
        Me.xlk_sector.VisParameters = New String() {"Código=sector_code", "Descripción=sector_name"}
        Me.xlk_sector.WhereCondition = Nothing
        Me.xlk_sector.WhereParameters = Nothing
        '
        'txtsector_name
        '
        Me.txtsector_name.EditInitialValue = Nothing
        Me.txtsector_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsector_name.FindInitialValue = Nothing
        Me.txtsector_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsector_name.IgnoreRequiered = False
        Me.txtsector_name.Location = New System.Drawing.Point(192, 170)
        Me.txtsector_name.Name = "txtsector_name"
        Me.txtsector_name.NewInitialValue = Nothing
        Me.txtsector_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsector_name.ReadOnly = True
        Me.txtsector_name.Requiered = False
        Me.txtsector_name.Size = New System.Drawing.Size(280, 20)
        Me.txtsector_name.TabIndex = 52
        Me.txtsector_name.TabStop = False
        Me.txtsector_name.Text = ""
        '
        'xlk_city
        '
        Me.xlk_city.CheckText = Nothing
        Me.xlk_city.DataMember = Nothing
        Me.xlk_city.DataSource = Me.LibXConnector1
        Me.xlk_city.DestParameters = New String() {"txtcity_code=city_code", "txtcity_name=city_name"}
        Me.xlk_city.FilterField = Nothing
        Me.xlk_city.IgnoreFindInBrowseMode = False
        Me.xlk_city.Location = New System.Drawing.Point(472, 148)
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
        Me.xlk_city.UseCopyConnection = False
        Me.xlk_city.UseRowRetrieveEvents = False
        Me.xlk_city.UseTab = False
        Me.xlk_city.VisParameters = New String() {"Código=city_code", "Descripción=city_name"}
        Me.xlk_city.WhereCondition = Nothing
        Me.xlk_city.WhereParameters = Nothing
        '
        'txtcity_name
        '
        Me.txtcity_name.EditInitialValue = Nothing
        Me.txtcity_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcity_name.FindInitialValue = Nothing
        Me.txtcity_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcity_name.IgnoreRequiered = False
        Me.txtcity_name.Location = New System.Drawing.Point(192, 147)
        Me.txtcity_name.Name = "txtcity_name"
        Me.txtcity_name.NewInitialValue = Nothing
        Me.txtcity_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcity_name.ReadOnly = True
        Me.txtcity_name.Requiered = False
        Me.txtcity_name.Size = New System.Drawing.Size(280, 20)
        Me.txtcity_name.TabIndex = 50
        Me.txtcity_name.TabStop = False
        Me.txtcity_name.Text = ""
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(81, 152)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(43, 16)
        Me.Label32.TabIndex = 54
        Me.Label32.Text = "Ciudad:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(84, 168)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(40, 16)
        Me.Label33.TabIndex = 55
        Me.Label33.Text = "Sector:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Nothing
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Nothing
        Me.LibXNavigator1.FirstControlInFindMode = Nothing
        Me.LibXNavigator1.FirstControlInNewMode = Nothing
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(690, 24)
        Me.LibXNavigator1.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(0, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(690, 48)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "CLIENTE A DOMICILIO"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'i_ftcustm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 360)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "i_ftcustm01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Clientes a Domicilio"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Cli As New ParametroCliente
    Public ok As Boolean


    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            If Me.txtTel.Text.Length <= 0 Then
                Throw New ApplicationException("Debe especificar un No. de teléfono!")
            End If

            If Me.txtCompany.Text.Length <= 0 And Me.txtContacto.Text.Length <= 0 Then
                Throw New ApplicationException("Debe especificar un nombre para identificarlo")
            End If

            Cli.Company = Me.txtCompany.Text
            Cli.Contact = Me.txtContacto.Text
            Cli.Tel = Me.txtTel.Text
            Cli.TelArea = Me.txtTelArea.Text
            Cli.Address = Me.txtAddress.Text
            Cli.Tel2 = Me.txtPhone2.Text
            Cli.Mail = Me.txtEmail.Text

            ok = True
            If Cli.Modalidad = LibxConnectorState.Insert Then
                LibXConnector1.AcceptNew()
            End If

            If Cli.Modalidad = LibxConnectorState.Insert Then
                LibXConnector1.AcceptEdit()
            End If

            Me.Close()

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub i_ftcustm01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            xlk_phone.ShowMessageNotFound = False

            If Cli.Modalidad = LibxConnectorState.Insert Then
                LibXConnector1.AddNew()
                xlk_phone.Enabled = True
            End If

            If Cli.Modalidad = LibxConnectorState.Edit Then
                LibXConnector1.ExecuteFind("phone = '" & Cli.Tel.ToString & "'")
                If LibXConnector1.HasRecords = True Then
                    LibXConnector1.Edit()
                    xlk_phone.Enabled = True
                Else
                    Cli.Modalidad = LibxConnectorState.Insert
                End If
            End If

            If Cli.Modalidad = LibxConnectorState.View Then
                LibXConnector1.ExecuteFind("phone = '" & Cli.Tel.ToString & "'")
                btnAccept.Enabled = False
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibxConnectionActions.Add Then
                If Cli.Company.Length > 0 Then
                    Me.txtCompany.Text = Cli.Company
                    Me.txtContacto.Text = Cli.Contact
                    Me.txtTel.Text = Cli.Tel
                    Me.txtTelArea.Text = Cli.TelArea
                    Me.txtAddress.Text = Cli.Address
                    Me.txtPhone2.Text = Cli.Tel2
                    Me.txtEmail.Text = Cli.Mail
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXLookup1_AfterSetValues(ByVal sender As System.Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_phone.AfterSetValues
        Try
            If e.dataFound = False Then
                Cli.Found = False
                e.handled = True
                Exit Sub
            End If
            Cli.Found = True
            Me.txtCompany.Text = e.row!company_name.ToString
            Me.txtContacto.Text = e.row!cust_name.ToString
            Me.txtTel.Text = e.row!phone.ToString
            Me.txtTelArea.Text = e.row!area_code.ToString
            Me.txtAddress.Text = e.row!address.ToString
            Me.txtPhone2.Text = e.row!phone1.ToString
            Me.txtEmail.Text = e.row!Email.ToString

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub txtTel_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTel.Leave
        Try
            If txtTel.Text.Length > 0 Then
                txtPhone1.Text = txtTel.Text
                xlk_phone.ExecuteFind()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xlk_phone_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_phone.BeforeSetValues
        Try
            If e.dataFound = False Then
                Cli.Modalidad = LibxConnectorState.Insert
                e.handled = True
                Exit Sub
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ok = False
    End Sub
End Class
