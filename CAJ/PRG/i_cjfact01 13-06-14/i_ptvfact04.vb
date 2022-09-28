

Public Class i_ptvfact04
    Inherits System.Windows.Forms.Form

    Dim WithEvents Label1 As System.Windows.Forms.Label
    Dim WithEvents Label7 As System.Windows.Forms.Label
    Dim WithEvents xcbo_Tipo As LibX.LibXCombo
    Dim WithEvents xtxt_telefono1 As LibX.XTextBox
    Dim WithEvents xtxt_codigo As LibX.XMaskEdit
    Dim WithEvents Label13 As Label
    Dim WithEvents Label12 As Label
    Dim WithEvents lbl_Descuento As Label
    Dim WithEvents lbl_Cobertura As Label
    Dim WithEvents xlk_plan As LibX.LibXLookup
    Dim WithEvents xlk_compania As LibX.LibXLookup
    Dim WithEvents lbl_Compania As Label
    Dim WithEvents xtxt_plan As LibX.XTextBox
    Dim WithEvents xtxt_Compania As LibX.XTextBox
    Dim WithEvents Label10 As Label
    Dim WithEvents Label11 As Label
    Dim WithEvents lbl_Plan As Label
    Dim WithEvents Label9 As System.Windows.Forms.Label
    Dim WithEvents xlk_codigo As LibX.LibXLookup
    Dim WithEvents XTextBox1 As LibX.XTextBox
    Dim WithEvents Label8 As System.Windows.Forms.Label
    Dim WithEvents lbl_TipoDocumento As System.Windows.Forms.Label
    Dim WithEvents xtxt_adicional2 As LibX.XTextBox
    Dim WithEvents xtxt_nombre As LibX.XTextBox
    Dim WithEvents Label2 As System.Windows.Forms.Label
    Dim WithEvents Label3 As System.Windows.Forms.Label


    Dim mExisteTarjeta As Boolean
    Dim mExistecliente As Boolean

    Dim mSerial As Integer
    Public ReadOnly Property Serial() As Integer
        Get
            Return mSerial
        End Get
    End Property

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents LBL_Title As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet

    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
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
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents xcbo_ncf_type As LibX.LibXCombo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents XMaskEdit1 As LibX.XMaskEdit
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(i_ptvfact04))
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
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblMessage = New System.Windows.Forms.Label
        Me.xcbo_ncf_type = New LibX.LibXCombo
        Me.xtxt_codigo = New LibX.XMaskEdit
        Me.xlk_codigo = New LibX.LibXLookup
        Me.xtxt_nombre = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.XMaskEdit1 = New LibX.XMaskEdit
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.LBL_Title = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.xtxt_telefono1 = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
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
        Me.LibXConnector1.DataMember = "ftcustm"
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
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"cust_serial"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "ftcustm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "cust_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "cust_name"
        Me.DataColumn2.MaxLength = 40
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "company_name"
        Me.DataColumn3.MaxLength = 40
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "area_code"
        Me.DataColumn4.MaxLength = 3
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "phone"
        Me.DataColumn5.MaxLength = 13
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "address"
        Me.DataColumn6.MaxLength = 60
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "email"
        Me.DataColumn7.MaxLength = 200
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "phone1"
        Me.DataColumn8.MaxLength = 13
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
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "ult_domicilio"
        Me.DataColumn11.DataType = GetType(System.DateTime)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "vend_code"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "cust_rnc"
        Me.DataColumn13.MaxLength = 20
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "domi_cambio"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "domi_pago"
        Me.DataColumn15.MaxLength = 3
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "ncf_type"
        Me.DataColumn16.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.SerialColumnName = "cust_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ftcustm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.lblMessage)
        Me.GroupBox1.Controls.Add(Me.xcbo_ncf_type)
        Me.GroupBox1.Controls.Add(Me.xtxt_codigo)
        Me.GroupBox1.Controls.Add(Me.xlk_codigo)
        Me.GroupBox1.Controls.Add(Me.xtxt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 216)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(440, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblMessage.Location = New System.Drawing.Point(3, 197)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(450, 16)
        Me.lblMessage.TabIndex = 13
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'xcbo_ncf_type
        '
        Me.xcbo_ncf_type.AllowDefaultSort = True
        Me.xcbo_ncf_type.bound = True
        Me.xcbo_ncf_type.currValue = Nothing
        Me.xcbo_ncf_type.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftcustm.ncf_type"))
        Me.xcbo_ncf_type.DefaultWhereString = Nothing
        Me.xcbo_ncf_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_ncf_type.EditInitialValue = Nothing
        Me.xcbo_ncf_type.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_ncf_type.FieldDescription = ""
        Me.xcbo_ncf_type.FindInitialValue = Nothing
        Me.xcbo_ncf_type.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_ncf_type.IgnoreRequiered = False
        Me.xcbo_ncf_type.Items.AddRange(New Object() {"1-VALOR CREDITO FISCAL", "3-GUBERNAMENTALl", "4-ZONA FRANCA"})
        Me.xcbo_ncf_type.Location = New System.Drawing.Point(72, 72)
        Me.xcbo_ncf_type.LookupKeyDisplayFields = Nothing
        Me.xcbo_ncf_type.LookupKeyField = Nothing
        Me.xcbo_ncf_type.LookupTableName = Nothing
        Me.xcbo_ncf_type.Name = "xcbo_ncf_type"
        Me.xcbo_ncf_type.NewInitialValue = "1"
        Me.xcbo_ncf_type.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_ncf_type.Requiered = False
        Me.xcbo_ncf_type.Required = False
        Me.xcbo_ncf_type.Size = New System.Drawing.Size(160, 21)
        Me.xcbo_ncf_type.SqlString = Nothing
        Me.xcbo_ncf_type.StatusBarPanelDescripcion = Nothing
        Me.xcbo_ncf_type.TabIndex = 2
        '
        'xtxt_codigo
        '
        Me.xtxt_codigo.AcceptsReturn = True
        Me.xtxt_codigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcustm.cust_rnc"))
        Me.xtxt_codigo.EditInitialValue = Nothing
        Me.xtxt_codigo.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_codigo.FieldDescription = ""
        Me.xtxt_codigo.FindInitialValue = Nothing
        Me.xtxt_codigo.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_codigo.IgnoreRequiered = False
        Me.xtxt_codigo.Location = New System.Drawing.Point(72, 24)
        Me.xtxt_codigo.Masked = MaskedTextBox.Mask.None
        Me.xtxt_codigo.Name = "xtxt_codigo"
        Me.xtxt_codigo.NewInitialValue = Nothing
        Me.xtxt_codigo.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_codigo.Requiered = False
        Me.xtxt_codigo.Size = New System.Drawing.Size(112, 20)
        Me.xtxt_codigo.StatusBarPanelDescripcion = Nothing
        Me.xtxt_codigo.TabIndex = 0
        Me.xtxt_codigo.Text = ""
        '
        'xlk_codigo
        '
        Me.xlk_codigo.AlternateFieldSearch = Nothing
        Me.xlk_codigo.CheckText = Nothing
        Me.xlk_codigo.ComboMode = False
        Me.xlk_codigo.DataMember = "ftcustm"
        Me.xlk_codigo.DataSource = Me.LibXConnector1
        Me.xlk_codigo.DestParameters = New String() {"cust_serial=cust_serial", "cust_rnc=cust_rnc", "cust_name=cust_name", "phone=phone"}
        Me.xlk_codigo.FilterField = ""
        Me.xlk_codigo.IgnoreFindInBrowseMode = True
        Me.xlk_codigo.isCanceled = False
        Me.xlk_codigo.Location = New System.Drawing.Point(184, 24)
        Me.xlk_codigo.LookCaption = "CLIENTES CREDITO FISCAL"
        Me.xlk_codigo.Name = "xlk_codigo"
        Me.xlk_codigo.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_codigo.ShowMessageNotFound = False
        Me.xlk_codigo.ShowWarning = False
        Me.xlk_codigo.Size = New System.Drawing.Size(16, 20)
        Me.xlk_codigo.SizesColumns = New String() {"cust_name=350"}
        Me.xlk_codigo.SizesColumnsTab = Nothing
        Me.xlk_codigo.SqlString = Nothing
        Me.xlk_codigo.SQLTab = Nothing
        Me.xlk_codigo.SrcParameters = New String() {"cust_rnc=cust_rnc"}
        Me.xlk_codigo.TabIndex = 9
        Me.xlk_codigo.TableName = "ftcustm"
        Me.xlk_codigo.TabStop = False
        Me.xlk_codigo.UseCopyConnection = False
        Me.xlk_codigo.UseRowRetrieveEvents = False
        Me.xlk_codigo.UseTab = False
        Me.xlk_codigo.Visible = False
        Me.xlk_codigo.VisParameters = New String() {"RNC=cust_rnc", "Nombre=cust_name", "phone=phone"}
        Me.xlk_codigo.WhereCondition = Nothing
        Me.xlk_codigo.WhereParameters = Nothing
        '
        'xtxt_nombre
        '
        Me.xtxt_nombre.AcceptsReturn = True
        Me.xtxt_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcustm.cust_name"))
        Me.xtxt_nombre.EditInitialValue = Nothing
        Me.xtxt_nombre.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_nombre.FieldDescription = ""
        Me.xtxt_nombre.FindInitialValue = Nothing
        Me.xtxt_nombre.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_nombre.IgnoreRequiered = False
        Me.xtxt_nombre.Location = New System.Drawing.Point(72, 48)
        Me.xtxt_nombre.Name = "xtxt_nombre"
        Me.xtxt_nombre.NewInitialValue = Nothing
        Me.xtxt_nombre.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_nombre.Requiered = False
        Me.xtxt_nombre.Size = New System.Drawing.Size(376, 20)
        Me.xtxt_nombre.StatusBarPanelDescripcion = Nothing
        Me.xtxt_nombre.TabIndex = 1
        Me.xtxt_nombre.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(16, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(32, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "RNC:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Location = New System.Drawing.Point(8, 72)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Tipo NCF:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(256, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Telefono:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XMaskEdit1
        '
        Me.XMaskEdit1.AcceptsReturn = True
        Me.XMaskEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcustm.phone"))
        Me.XMaskEdit1.EditInitialValue = Nothing
        Me.XMaskEdit1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.FieldDescription = ""
        Me.XMaskEdit1.FindInitialValue = Nothing
        Me.XMaskEdit1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.IgnoreRequiered = False
        Me.XMaskEdit1.Location = New System.Drawing.Point(312, 72)
        Me.XMaskEdit1.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.XMaskEdit1.Name = "XMaskEdit1"
        Me.XMaskEdit1.NewInitialValue = Nothing
        Me.XMaskEdit1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.Requiered = False
        Me.XMaskEdit1.Size = New System.Drawing.Size(136, 20)
        Me.XMaskEdit1.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit1.TabIndex = 3
        Me.XMaskEdit1.Text = ""
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcustm.cust_serial"))
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label19.Location = New System.Drawing.Point(232, 304)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 20)
        Me.Label19.TabIndex = 12
        '
        'Label25
        '
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcustm.cust_serial"))
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label25.Location = New System.Drawing.Point(320, 296)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 20)
        Me.Label25.TabIndex = 12
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.CausesValidation = False
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelar.Location = New System.Drawing.Point(392, 280)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cerrar"
        '
        'LBL_Title
        '
        Me.LBL_Title.BackColor = System.Drawing.Color.White
        Me.LBL_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBL_Title.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LBL_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Title.ForeColor = System.Drawing.Color.Blue
        Me.LBL_Title.Location = New System.Drawing.Point(0, 0)
        Me.LBL_Title.Name = "LBL_Title"
        Me.LBL_Title.Size = New System.Drawing.Size(474, 48)
        Me.LBL_Title.TabIndex = 0
        Me.LBL_Title.Text = "FACTURA CON VALOR FISCAL"
        Me.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAceptar.Location = New System.Drawing.Point(312, 280)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(72, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        '
        'xtxt_telefono1
        '
        Me.xtxt_telefono1.AcceptsReturn = True
        Me.xtxt_telefono1.EditInitialValue = Nothing
        Me.xtxt_telefono1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono1.FieldDescription = ""
        Me.xtxt_telefono1.FindInitialValue = Nothing
        Me.xtxt_telefono1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono1.IgnoreRequiered = False
        Me.xtxt_telefono1.Location = New System.Drawing.Point(0, 0)
        Me.xtxt_telefono1.Name = "xtxt_telefono1"
        Me.xtxt_telefono1.NewInitialValue = Nothing
        Me.xtxt_telefono1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono1.Requiered = False
        Me.xtxt_telefono1.StatusBarPanelDescripcion = Nothing
        Me.xtxt_telefono1.TabIndex = 0
        Me.xtxt_telefono1.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.TabIndex = 0
        '
        'i_ptvfact04
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(474, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.LBL_Title)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label19)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "i_ptvfact04"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACTURA CON VALOR FISCAL"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        If LibXConnector1.IsDataEditing = True Then
            LibXConnector1.Cancel()
        End If
        Me.Close()
    End Sub


    Private Sub xlk_codigo_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_codigo.AfterSetValues
        Try
            mExistecliente = e.dataFound
            If LibXConnector1.IsDataEditing = True Then
                If e.dataFound = True Then
                    'LibXConnector1.Edit()
                End If
            End If
            Me.btnAceptar.Enabled = True
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xlk_codigo_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_codigo.BeforeSetValues
        Try
            If LibXConnector1.IsDataEditing = True Then
                If e.dataFound = False Then
                    e.handled = True
                    Me.lblMessage.Text = "Cliente no existe, se agregara al sistema!"
                    Me.lblMessage.ForeColor = System.Drawing.Color.Red
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            LibXConnector1.Accept()
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Dim xInsert As LibX.Data.XInsertStmt
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim TarjSerial As Integer

        Try
            e.UpdatingArgs.Status = UpdateStatus.SkipCurrentRow

            If mExistecliente = False Then
                '// CLIENTE
                xInsert = New LibX.Data.XInsertStmt("ftcustm", "cust_serial")
                xInsert.Fields("cust_rnc") = LibXConnector1.CurrentDataRow!cust_rnc
                xInsert.Fields("cust_name") = LibXConnector1.CurrentDataRow!cust_name
                xInsert.Fields("ncf_type") = LibXConnector1.CurrentDataRow!ncf_type
                xInsert.Fields("phone") = LibXConnector1.CurrentDataRow!phone
                mSerial = xInsert.Execute()
                LibX.Data.Manager.LastSerialValue = mSerial
                LibXConnector1.CurrentDataRow!cust_serial = mSerial
            End If

            If mExistecliente = True Then
                '// CLIENTE
                xUpdate = New LibX.Data.XUpdateStmt("ftcustm")
                xUpdate.FieldsSet("cust_rnc") = LibXConnector1.CurrentDataRow!cust_rnc
                xUpdate.FieldsSet("cust_name") = LibXConnector1.CurrentDataRow!cust_name
                xUpdate.FieldsSet("ncf_type") = LibXConnector1.CurrentDataRow!ncf_type
                xUpdate.FieldsSet("phone") = LibXConnector1.CurrentDataRow!phone
                xUpdate.Fields("cust_serial") = LibXConnector1.CurrentDataRow!cust_serial
                mSerial = LibXConnector1.CurrentDataRow!cust_serial
                xUpdate.Execute()
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex)
        End Try
    End Sub


    Public Overloads Function ShowDialog() As DialogResult
        Return MyBase.ShowDialog()
    End Function

    Private Sub xtxt_codigo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_codigo.Validating
        If LibXConnector1.IsDataEditing = True Then
            If Me.xtxt_codigo.Text.Trim = "" Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub i_ptvfact04_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If LibXConnector1.IsDataEditing = True Then
                If e.KeyCode = Keys.F5 Then
                    LibXConnector1.Accept()
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class
