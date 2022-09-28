Public Class i_ptvciasgm01
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
    Friend WithEvents TextBox1 As LibX.XTextBox
    Friend WithEvents TextBox2 As LibX.XTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As LibX.XTextBox
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabCliente As System.Windows.Forms.Label
    Friend WithEvents xtx_estado As LibX.LibXCombo
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents lbl_sector As System.Windows.Forms.Label
    Friend WithEvents xlk_sector_code As LibX.LibXLookup
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents XTextBox9 As LibX.XTextBox
    Friend WithEvents lbl_ciudad As System.Windows.Forms.Label
    Friend WithEvents xlk_city_code As LibX.LibXLookup
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents xtxt_city_code As LibX.XTextBox
    Friend WithEvents xtxt_telefono As LibX.XMaskEdit
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents XMaskEdit1 As LibX.XTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.XMaskEdit1 = New LibX.XTextBox
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
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LabCliente = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.xtx_estado = New LibX.LibXCombo
        Me.Label5 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.xtxt_telefono = New LibX.XMaskEdit
        Me.TextBox2 = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox4 = New LibX.XTextBox
        Me.lbl_sector = New System.Windows.Forms.Label
        Me.xlk_sector_code = New LibX.LibXLookup
        Me.Label13 = New System.Windows.Forms.Label
        Me.XTextBox9 = New LibX.XTextBox
        Me.lbl_ciudad = New System.Windows.Forms.Label
        Me.xlk_city_code = New LibX.LibXLookup
        Me.Label11 = New System.Windows.Forms.Label
        Me.xtxt_city_code = New LibX.XTextBox
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit1)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.LabCliente)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xtx_estado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xtxt_telefono)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.lbl_sector)
        Me.GroupBox1.Controls.Add(Me.xlk_sector_code)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.XTextBox9)
        Me.GroupBox1.Controls.Add(Me.lbl_ciudad)
        Me.GroupBox1.Controls.Add(Me.xlk_city_code)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.xtxt_city_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 264)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(368, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Telefono;"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XMaskEdit1
        '
        Me.XMaskEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XMaskEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgciasm.cia_codigo"))
        Me.XMaskEdit1.EditInitialValue = Nothing
        Me.XMaskEdit1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.FieldDescription = ""
        Me.XMaskEdit1.FindInitialValue = Nothing
        Me.XMaskEdit1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.IgnoreRequiered = False
        Me.XMaskEdit1.Location = New System.Drawing.Point(120, 64)
        Me.XMaskEdit1.Name = "XMaskEdit1"
        Me.XMaskEdit1.NewInitialValue = Nothing
        Me.XMaskEdit1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.Requiered = False
        Me.XMaskEdit1.Size = New System.Drawing.Size(120, 20)
        Me.XMaskEdit1.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit1.TabIndex = 3
        Me.XMaskEdit1.Text = ""
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"cia_serial"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "sgciasm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "cia_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "cia_name"
        Me.DataColumn2.MaxLength = 80
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "cia_address"
        Me.DataColumn3.MaxLength = 200
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "cia_phone"
        Me.DataColumn4.MaxLength = 13
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "cust_code"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "cia_status"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "city_code"
        Me.DataColumn7.MaxLength = 3
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sector_code"
        Me.DataColumn8.MaxLength = 3
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "cia_codigo"
        Me.DataColumn9.MaxLength = 20
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"cust_code=cust_code", "LabCliente=cust_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.Location = New System.Drawing.Point(536, 208)
        Me.LibXLookup1.LookCaption = Nothing
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.ShowWarning = False
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SizesColumns = Nothing
        Me.LibXLookup1.SizesColumnsTab = Nothing
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"cust_code=cust_code"}
        Me.LibXLookup1.TabIndex = 11
        Me.LibXLookup1.TableName = "cccustm"
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Codigo=cust_code", "Cliente=cust_name"}
        Me.LibXLookup1.WhereCondition = "csttype_code =5"
        Me.LibXLookup1.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "sgciasm"
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
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "cia_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "sgciasm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LabCliente
        '
        Me.LabCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabCliente.Location = New System.Drawing.Point(192, 208)
        Me.LabCliente.Name = "LabCliente"
        Me.LabCliente.Size = New System.Drawing.Size(344, 20)
        Me.LabCliente.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(376, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Estado:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtx_estado
        '
        Me.xtx_estado.AllowDefaultSort = True
        Me.xtx_estado.bound = True
        Me.xtx_estado.currValue = Nothing
        Me.xtx_estado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "sgciasm.cia_status"))
        Me.xtx_estado.DefaultWhereString = Nothing
        Me.xtx_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xtx_estado.EditInitialValue = Nothing
        Me.xtx_estado.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtx_estado.FieldDescription = ""
        Me.xtx_estado.FindInitialValue = Nothing
        Me.xtx_estado.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtx_estado.IgnoreRequiered = False
        Me.xtx_estado.Items.AddRange(New Object() {"1-Activo", "2-Inativo"})
        Me.xtx_estado.Location = New System.Drawing.Point(432, 16)
        Me.xtx_estado.LookupKeyDisplayFields = Nothing
        Me.xtx_estado.LookupKeyField = Nothing
        Me.xtx_estado.LookupTableName = Nothing
        Me.xtx_estado.Name = "xtx_estado"
        Me.xtx_estado.NewInitialValue = Nothing
        Me.xtx_estado.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtx_estado.Requiered = False
        Me.xtx_estado.Required = False
        Me.xtx_estado.Size = New System.Drawing.Size(120, 21)
        Me.xtx_estado.SqlString = Nothing
        Me.xtx_estado.StatusBarPanelDescripcion = Nothing
        Me.xtx_estado.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(24, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Cuanta Credito:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox2
        '
        Me.XTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgciasm.cust_code"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(120, 208)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(64, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 8
        Me.XTextBox2.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(8, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Codigo Proveedor:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_telefono
        '
        Me.xtxt_telefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_telefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgciasm.cia_phone"))
        Me.xtxt_telefono.EditInitialValue = Nothing
        Me.xtxt_telefono.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono.FieldDescription = ""
        Me.xtxt_telefono.FindInitialValue = Nothing
        Me.xtxt_telefono.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono.IgnoreRequiered = False
        Me.xtxt_telefono.Location = New System.Drawing.Point(432, 64)
        Me.xtxt_telefono.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.xtxt_telefono.Name = "xtxt_telefono"
        Me.xtxt_telefono.NewInitialValue = Nothing
        Me.xtxt_telefono.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono.Requiered = False
        Me.xtxt_telefono.Size = New System.Drawing.Size(120, 20)
        Me.xtxt_telefono.StatusBarPanelDescripcion = Nothing
        Me.xtxt_telefono.TabIndex = 4
        Me.xtxt_telefono.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgciasm.cia_address"))
        Me.TextBox2.EditInitialValue = Nothing
        Me.TextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.FieldDescription = ""
        Me.TextBox2.FindInitialValue = Nothing
        Me.TextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.IgnoreRequiered = False
        Me.TextBox2.Location = New System.Drawing.Point(120, 88)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.NewInitialValue = Nothing
        Me.TextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.Requiered = False
        Me.TextBox2.Size = New System.Drawing.Size(432, 64)
        Me.TextBox2.StatusBarPanelDescripcion = Nothing
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(40, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgciasm.cia_serial"))
        Me.TextBox1.EditInitialValue = Nothing
        Me.TextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox1.FieldDescription = ""
        Me.TextBox1.FindInitialValue = Nothing
        Me.TextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox1.IgnoreRequiered = False
        Me.TextBox1.Location = New System.Drawing.Point(120, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.NewInitialValue = Nothing
        Me.TextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox1.Requiered = False
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.StatusBarPanelDescripcion = Nothing
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(64, 16)
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
        Me.Label3.Location = New System.Drawing.Point(59, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox4
        '
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgciasm.cia_name"))
        Me.TextBox4.EditInitialValue = Nothing
        Me.TextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.FieldDescription = ""
        Me.TextBox4.FindInitialValue = Nothing
        Me.TextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.IgnoreRequiered = False
        Me.TextBox4.Location = New System.Drawing.Point(120, 40)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.NewInitialValue = Nothing
        Me.TextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.Requiered = False
        Me.TextBox4.Size = New System.Drawing.Size(432, 20)
        Me.TextBox4.StatusBarPanelDescripcion = Nothing
        Me.TextBox4.TabIndex = 2
        Me.TextBox4.Text = ""
        '
        'lbl_sector
        '
        Me.lbl_sector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_sector.Location = New System.Drawing.Point(192, 184)
        Me.lbl_sector.Name = "lbl_sector"
        Me.lbl_sector.Size = New System.Drawing.Size(344, 20)
        Me.lbl_sector.TabIndex = 33
        '
        'xlk_sector_code
        '
        Me.xlk_sector_code.AlternateFieldSearch = Nothing
        Me.xlk_sector_code.CheckText = Nothing
        Me.xlk_sector_code.DataMember = Nothing
        Me.xlk_sector_code.DataSource = Me.LibXConnector1
        Me.xlk_sector_code.DestParameters = New String() {"city_code=city_code", "sector_code=sector_code", "lbl_sector=sector_name"}
        Me.xlk_sector_code.FilterField = Nothing
        Me.xlk_sector_code.IgnoreFindInBrowseMode = False
        Me.xlk_sector_code.Location = New System.Drawing.Point(536, 184)
        Me.xlk_sector_code.LookCaption = Nothing
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
        Me.xlk_sector_code.TabIndex = 32
        Me.xlk_sector_code.TableName = "ccsectorm"
        Me.xlk_sector_code.UseCopyConnection = False
        Me.xlk_sector_code.UseRowRetrieveEvents = False
        Me.xlk_sector_code.UseTab = False
        Me.xlk_sector_code.VisParameters = New String() {"Código=sector_code", "Sector=sector_name"}
        Me.xlk_sector_code.WhereCondition = ""
        Me.xlk_sector_code.WhereParameters = Nothing
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(67, 184)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 16)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Sector:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox9
        '
        Me.XTextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgciasm.sector_code"))
        Me.XTextBox9.EditInitialValue = Nothing
        Me.XTextBox9.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.FieldDescription = ""
        Me.XTextBox9.FindInitialValue = Nothing
        Me.XTextBox9.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.IgnoreRequiered = False
        Me.XTextBox9.Location = New System.Drawing.Point(120, 184)
        Me.XTextBox9.Name = "XTextBox9"
        Me.XTextBox9.NewInitialValue = Nothing
        Me.XTextBox9.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.Requiered = False
        Me.XTextBox9.Size = New System.Drawing.Size(64, 20)
        Me.XTextBox9.StatusBarPanelDescripcion = Nothing
        Me.XTextBox9.TabIndex = 7
        Me.XTextBox9.Text = ""
        '
        'lbl_ciudad
        '
        Me.lbl_ciudad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ciudad.Location = New System.Drawing.Point(192, 160)
        Me.lbl_ciudad.Name = "lbl_ciudad"
        Me.lbl_ciudad.Size = New System.Drawing.Size(344, 20)
        Me.lbl_ciudad.TabIndex = 29
        '
        'xlk_city_code
        '
        Me.xlk_city_code.AlternateFieldSearch = Nothing
        Me.xlk_city_code.CheckText = Nothing
        Me.xlk_city_code.DataMember = Nothing
        Me.xlk_city_code.DataSource = Me.LibXConnector1
        Me.xlk_city_code.DestParameters = New String() {"city_code=city_code", "lbl_ciudad=city_name"}
        Me.xlk_city_code.FilterField = "city_name"
        Me.xlk_city_code.IgnoreFindInBrowseMode = False
        Me.xlk_city_code.Location = New System.Drawing.Point(536, 160)
        Me.xlk_city_code.LookCaption = Nothing
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
        Me.xlk_city_code.TabIndex = 28
        Me.xlk_city_code.TableName = "cccity"
        Me.xlk_city_code.UseCopyConnection = False
        Me.xlk_city_code.UseRowRetrieveEvents = False
        Me.xlk_city_code.UseTab = False
        Me.xlk_city_code.VisParameters = New String() {"Código=city_code", "Ciudad=city_name"}
        Me.xlk_city_code.WhereCondition = ""
        Me.xlk_city_code.WhereParameters = Nothing
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(64, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Ciudad:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_city_code
        '
        Me.xtxt_city_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_city_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgciasm.city_code"))
        Me.xtxt_city_code.EditInitialValue = Nothing
        Me.xtxt_city_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_city_code.FieldDescription = ""
        Me.xtxt_city_code.FindInitialValue = Nothing
        Me.xtxt_city_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_city_code.IgnoreRequiered = False
        Me.xtxt_city_code.Location = New System.Drawing.Point(120, 160)
        Me.xtxt_city_code.Name = "xtxt_city_code"
        Me.xtxt_city_code.NewInitialValue = Nothing
        Me.xtxt_city_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_city_code.Requiered = False
        Me.xtxt_city_code.Size = New System.Drawing.Size(64, 20)
        Me.xtxt_city_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_city_code.TabIndex = 6
        Me.xtxt_city_code.Text = ""
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.TextBox2
        Me.LibXNavigator1.FirstControlInFindMode = Nothing
        Me.LibXNavigator1.FirstControlInNewMode = Nothing
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(690, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'i_ptvciasgm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 328)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ptvciasgm01"
        Me.Text = "Compañia de seguro medico"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub xlk_sector_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_sector_code.BeforeExecuteQuery
        Try

            If Me.xtxt_city_code.Text.Trim <> "" Then
                e.aditionalWhere = "city_code = '" & Me.xtxt_city_code.Text.Trim & "'"
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibX.LibxConnectionActions.Add Then
                xtx_estado.currValue = 1
            End If


            If e.AcceptedAction = LibX.LibxConnectionActions.Edit And _
               e.Action = LibX.LibxConnectionActions.Accept Then
                LibXConnector1.LoadDetail()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub
End Class
