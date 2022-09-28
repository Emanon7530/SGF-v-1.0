Imports LibX
Public Class r_ivcontrol
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
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents LibxDateTimePicker2 As LibX.LibxDateTimePicker
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents XTextBox4 As LibX.XTextBox
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents whse_name As System.Windows.Forms.TextBox
    Friend WithEvents grou_name As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
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
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.whse_name = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.LibxDateTimePicker2 = New LibX.LibxDateTimePicker
        Me.grou_name = New System.Windows.Forms.TextBox
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.Label1 = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.XTextBox4 = New LibX.XTextBox
        Me.DataColumn14 = New System.Data.DataColumn
        Me.TextBox1 = New System.Windows.Forms.TextBox
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = False
        Me.LibXConnector1.AllowNew = False
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "ivtranrm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = True
        Me.LibXConnector1.HandledUpdates = True
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
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"trane_number"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "ivtranrm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "trane_number"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "type_code"
        Me.DataColumn2.MaxLength = 3
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "doc_number"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "reference"
        Me.DataColumn4.MaxLength = 40
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Tasa"
        Me.DataColumn5.DataType = GetType(System.Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "doc_date"
        Me.DataColumn6.DataType = GetType(System.DateTime)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "tranr_status"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "doc_serial"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "group_code"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "item_code"
        Me.DataColumn10.MaxLength = 10
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "whse_code"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "fecha_ini"
        Me.DataColumn12.DataType = GetType(System.DateTime)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "fecha_fin"
        Me.DataColumn13.DataType = GetType(System.DateTime)
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
        Me.LibXDbSourceTable1.Source = New String() {"select ivitemm.group_code, ivtranrd.item_code, ivtranrd.whse_code", "from ivtranrd inner join ivitemm on ivtranrd.item_code = ivitemm.item_code"}
        Me.LibXDbSourceTable1.TableName = "ivtranrm"
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
        Me.LibXDbSourceTable2.TableName = Nothing
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.Location = New System.Drawing.Point(432, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 160)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(8, 80)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Cerrar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLimpiar.Location = New System.Drawing.Point(8, 47)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(72, 32)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEjecutar.Location = New System.Drawing.Point(8, 13)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(72, 32)
        Me.btnEjecutar.TabIndex = 0
        Me.btnEjecutar.Text = "Ejecutar"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(530, 48)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "PRODUCTOS CONTROLADOS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'whse_name
        '
        Me.whse_name.Location = New System.Drawing.Point(208, 112)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.ReadOnly = True
        Me.whse_name.Size = New System.Drawing.Size(200, 20)
        Me.whse_name.TabIndex = 26
        Me.whse_name.TabStop = False
        Me.whse_name.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(48, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Almacen:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(32, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Fecha Inicial"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"whse_code=whse_code", "whse_name=whse_name"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(408, 112)
        Me.LibXLookup2.LookCaption = "Almacen"
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup2.ShowFilter = True
        Me.LibXLookup2.ShowMessageNotFound = True
        Me.LibXLookup2.ShowWarning = False
        Me.LibXLookup2.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup2.SizesColumns = Nothing
        Me.LibXLookup2.SizesColumnsTab = Nothing
        Me.LibXLookup2.SqlString = Nothing
        Me.LibXLookup2.SQLTab = Nothing
        Me.LibXLookup2.SrcParameters = New String() {"whse_code=whse_code"}
        Me.LibXLookup2.TabIndex = 28
        Me.LibXLookup2.TableName = "ivwhsem"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"C�digo=whse_code", "Descripci�n=whse_name"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(32, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Fecha Final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(48, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Producto:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtranrm.fecha_ini"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.FieldDescription = ""
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = False
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(112, 64)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = Nothing
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Requiered = False
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.LibxDateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker1.TabIndex = 33
        '
        'LibxDateTimePicker2
        '
        Me.LibxDateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtranrm.fecha_fin"))
        Me.LibxDateTimePicker2.EditInitialValue = Nothing
        Me.LibxDateTimePicker2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker2.FieldDescription = ""
        Me.LibxDateTimePicker2.FindInitialValue = Nothing
        Me.LibxDateTimePicker2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker2.IgnoreRequiered = False
        Me.LibxDateTimePicker2.Location = New System.Drawing.Point(112, 88)
        Me.LibxDateTimePicker2.Name = "LibxDateTimePicker2"
        Me.LibxDateTimePicker2.NewInitialValue = Nothing
        Me.LibxDateTimePicker2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker2.Requiered = False
        Me.LibxDateTimePicker2.Size = New System.Drawing.Size(88, 20)
        Me.LibxDateTimePicker2.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker2.TabIndex = 34
        '
        'grou_name
        '
        Me.grou_name.Location = New System.Drawing.Point(208, 136)
        Me.grou_name.Name = "grou_name"
        Me.grou_name.ReadOnly = True
        Me.grou_name.Size = New System.Drawing.Size(200, 20)
        Me.grou_name.TabIndex = 35
        Me.grou_name.TabStop = False
        Me.grou_name.Text = ""
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"group_code=group_code", "grou_name=group_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(408, 136)
        Me.LibXLookup1.LookCaption = "Grupos"
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
        Me.LibXLookup1.SrcParameters = New String() {"group_code=group_code"}
        Me.LibXLookup1.TabIndex = 36
        Me.LibXLookup1.TableName = "ivgroupm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"C�digo=group_code", "Descripci�n=group_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(64, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Grupo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtranrm.whse_code"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(112, 112)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(88, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 40
        Me.XTextBox3.Text = ""
        '
        'XTextBox4
        '
        Me.XTextBox4.AcceptsReturn = True
        Me.XTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtranrm.group_code"))
        Me.XTextBox4.EditInitialValue = Nothing
        Me.XTextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.FieldDescription = ""
        Me.XTextBox4.FindInitialValue = Nothing
        Me.XTextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.IgnoreRequiered = False
        Me.XTextBox4.Location = New System.Drawing.Point(112, 136)
        Me.XTextBox4.Name = "XTextBox4"
        Me.XTextBox4.NewInitialValue = Nothing
        Me.XTextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.Requiered = False
        Me.XTextBox4.Size = New System.Drawing.Size(88, 20)
        Me.XTextBox4.StatusBarPanelDescripcion = Nothing
        Me.XTextBox4.TabIndex = 41
        Me.XTextBox4.Text = ""
        '
        'DataColumn14
        '
        Me.DataColumn14.Caption = "item_name"
        Me.DataColumn14.ColumnName = "item_name"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtranrm.item_name"))
        Me.TextBox1.Location = New System.Drawing.Point(112, 160)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(296, 20)
        Me.TextBox1.TabIndex = 42
        Me.TextBox1.Text = ""
        '
        'r_ivcontrol
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(530, 216)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.XTextBox4)
        Me.Controls.Add(Me.XTextBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LibXLookup1)
        Me.Controls.Add(Me.grou_name)
        Me.Controls.Add(Me.LibxDateTimePicker2)
        Me.Controls.Add(Me.LibxDateTimePicker1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.whse_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LibXLookup2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "r_ivcontrol"
        Me.Text = "Productos controlados"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim AxCrystalReport1 As LibX.ReportLib
        Try
            Dim SelecStmt As String
            Dim sFechaDesde As String
            Dim sFechaHasta As String
            Dim sWhere As String
            Dim sWh As String
            Dim sGr As String
            Dim sIt As String
            Dim ItemName As String

            If Not IsNull(e.row!fecha_ini) Then
                sFechaDesde = CDate(e.row!fecha_ini).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(e.row!fecha_fin) Then
                sFechaHasta = CDate(e.row!fecha_fin).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(e.row!group_code) Then
                sGr = e.row!group_code
            End If

            If Not IsNull(e.row!whse_code) Then
                sWh = e.row!whse_code
            End If

            If Not IsNull(e.row!item_name) Then
                ItemName = e.row!item_name.ToString
            End If

            'If Not IsNull(e.row!item_code) Then
            '    sIt = e.row!item_code
            'End If

            'If Chkdetallado.Checked = False Then
            AxCrystalReport1 = New LibX.ReportLib("INV", "r_ivcontrol.rpt")
            'Else
            '    AxCrystalReport1 = New LibX.ReportLib("INV", "r_ivcontrol.rpt")
            'End If

            With AxCrystalReport1
                sWhere = " 1=1 "
                If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                    sWhere = String.Concat(sWhere, " and doc_date between '", sFechaDesde, "' and '", sFechaHasta, "'")
                ElseIf Trim(sFechaDesde) <> "" Then
                    sWhere = String.Concat(sWhere, " and doc_date >= '", sFechaDesde, "'")
                ElseIf Trim(sFechaHasta) <> "" Then
                    sWhere = String.Concat(sWhere, " and doc_date <= '", sFechaHasta, "'")
                End If
                'If Chkdetallado.Checked = False Then

                If sWh <> "" Then
                    sWhere = String.Concat(sWhere, " and ivcontrolv.whse_code = ", sWh)
                End If

                If sGr <> "" Then
                    sWhere = String.Concat(sWhere, " and ivitemm.group_code = ", sGr)
                End If


                If Trim(ItemName) <> "" Then
                    sWhere = String.Concat(sWhere, " and ivitemm.item_name like '", Trim(ItemName), "%'")
                End If

                .ParameterFields(1) = String.Concat("Fecha_ini;", Trim(sFechaDesde), ";TRUE")
                .ParameterFields(2) = String.Concat("Fecha_fin;", Trim(sFechaHasta), ";TRUE")
                '// Recibir el SQL Query
                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                .SQLQuery = SelecStmt

                '// Ejecutar el reporte
                .Action = 1
            End With

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Me.LibXConnector1.AcceptFind()
        Me.LibXConnector1.Find()
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        If Me.LibXConnector1.IsEditing Then
            Me.LibXConnector1.Cancel()
        End If
        Me.LibXConnector1.Find()
    End Sub

    Private Sub r_ftfact10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LibXConnector1.Find()
    End Sub
End Class
