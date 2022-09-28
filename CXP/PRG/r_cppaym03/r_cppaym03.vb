Imports LibX
Public Class r_cppaym03
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
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txttype_code As System.Windows.Forms.TextBox
    Friend WithEvents Txttype_name As System.Windows.Forms.TextBox
    Friend WithEvents Lbltype_code As LibX.LibXLookup
    Friend WithEvents fecHasta As LibX.LibxDateTimePicker
    Friend WithEvents Fecha_ini As LibX.LibxDateTimePicker
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
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents xtxsuccode As System.Windows.Forms.TextBox
    Friend WithEvents xtxsuc_name As System.Windows.Forms.TextBox
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
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
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.xtxsuccode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Txttype_code = New System.Windows.Forms.TextBox
        Me.Txttype_name = New System.Windows.Forms.TextBox
        Me.Lbltype_code = New LibX.LibXLookup
        Me.xtxsuc_name = New System.Windows.Forms.TextBox
        Me.fecHasta = New LibX.LibxDateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Fecha_ini = New LibX.LibxDateTimePicker
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.LibXLookup1 = New LibX.LibXLookup
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
        Me.LibXConnector1.DataMember = "cpinvcem"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = True
        Me.LibXConnector1.HandledUpdates = True
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = ""
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = ""
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"invce_serial"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn7}
        Me.DataTable1.TableName = "cpinvcem"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Fecha_ini"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Fecha_fin"
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "prov_code"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "type_prov"
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "type_code"
        Me.DataColumn5.MaxLength = 3
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "balance"
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.AutoIncrement = True
        Me.DataColumn7.ColumnName = "invce_serial"
        Me.DataColumn7.DataType = GetType(System.Int32)
        Me.DataColumn7.ReadOnly = True
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "term_code"
        Me.DataColumn8.MaxLength = 5
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "doc_no"
        Me.DataColumn9.MaxLength = 20
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "invce_desc"
        Me.DataColumn10.MaxLength = 60
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "doc_date"
        Me.DataColumn11.DataType = GetType(System.DateTime)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "disc_date"
        Me.DataColumn12.DataType = GetType(System.DateTime)
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "amount"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "disc_pct"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "due_date"
        Me.DataColumn15.DataType = GetType(System.DateTime)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "disc_amount"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "isc_amount"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "itbis"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "excento"
        Me.DataColumn19.DataType = GetType(System.Decimal)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "impto"
        Me.DataColumn20.DataType = GetType(System.Decimal)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "invce_status"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "date_created"
        Me.DataColumn22.DataType = GetType(System.DateTime)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "userid"
        Me.DataColumn23.MaxLength = 20
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "invce_ncf"
        Me.DataColumn24.MaxLength = 20
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "dev_serial"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "entr_serial"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "suc_code"
        Me.DataColumn27.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.TableName = "cpinvcem"
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
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.Location = New System.Drawing.Point(440, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 136)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(8, 96)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Cerrar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLimpiar.Location = New System.Drawing.Point(8, 56)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(72, 32)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEjecutar.Location = New System.Drawing.Point(8, 16)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(72, 32)
        Me.btnEjecutar.TabIndex = 0
        Me.btnEjecutar.Text = "Ejecutar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(16, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tipo Suplidor :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "DIARIO DE FACTURAS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(37, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sucursal:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'xtxsuccode
        '
        Me.xtxsuccode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.suc_code"))
        Me.xtxsuccode.Location = New System.Drawing.Point(96, 136)
        Me.xtxsuccode.Name = "xtxsuccode"
        Me.xtxsuccode.Size = New System.Drawing.Size(64, 20)
        Me.xtxsuccode.TabIndex = 13
        Me.xtxsuccode.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Balance :"
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cpinvcem.type_prov"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Location = New System.Drawing.Point(95, 160)
        Me.LibXCombo1.LookupKeyDisplayFields = "type_name"
        Me.LibXCombo1.LookupKeyField = "type_prov"
        Me.LibXCombo1.LookupTableName = "cptypep"
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(160, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 19
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.balance"))
        Me.TextBox1.Location = New System.Drawing.Point(95, 208)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(30, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Tipo Doc. :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txttype_code
        '
        Me.Txttype_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.type_code"))
        Me.Txttype_code.Location = New System.Drawing.Point(95, 184)
        Me.Txttype_code.Name = "Txttype_code"
        Me.Txttype_code.Size = New System.Drawing.Size(64, 20)
        Me.Txttype_code.TabIndex = 22
        Me.Txttype_code.Text = ""
        '
        'Txttype_name
        '
        Me.Txttype_name.Location = New System.Drawing.Point(160, 184)
        Me.Txttype_name.Name = "Txttype_name"
        Me.Txttype_name.ReadOnly = True
        Me.Txttype_name.Size = New System.Drawing.Size(232, 20)
        Me.Txttype_name.TabIndex = 23
        Me.Txttype_name.Text = ""
        '
        'Lbltype_code
        '
        Me.Lbltype_code.AlternateFieldSearch = Nothing
        Me.Lbltype_code.BeginCheck = False
        Me.Lbltype_code.CheckText = Nothing
        Me.Lbltype_code.ComboMode = False
        Me.Lbltype_code.DataMember = Nothing
        Me.Lbltype_code.DataSource = Me.LibXConnector1
        Me.Lbltype_code.DestParameters = New String() {"Txttype_code=type_code", "Txttype_name=type_name"}
        Me.Lbltype_code.FilterField = Nothing
        Me.Lbltype_code.IgnoreFindInBrowseMode = False
        Me.Lbltype_code.isCanceled = False
        Me.Lbltype_code.Location = New System.Drawing.Point(394, 184)
        Me.Lbltype_code.LookCaption = Nothing
        Me.Lbltype_code.Name = "Lbltype_code"
        Me.Lbltype_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.Lbltype_code.ShowFilter = True
        Me.Lbltype_code.ShowMessageNotFound = True
        Me.Lbltype_code.ShowWarning = False
        Me.Lbltype_code.Size = New System.Drawing.Size(16, 20)
        Me.Lbltype_code.SizesColumns = Nothing
        Me.Lbltype_code.SizesColumnsTab = Nothing
        Me.Lbltype_code.SqlString = New String() {"select * from ivtypem", "where type_code = 'CRD'"}
        Me.Lbltype_code.SQLTab = Nothing
        Me.Lbltype_code.SrcParameters = New String() {"type_code=type_code"}
        Me.Lbltype_code.TabIndex = 24
        Me.Lbltype_code.TableName = "ivtypem"
        Me.Lbltype_code.TabStop = False
        Me.Lbltype_code.UseCopyConnection = False
        Me.Lbltype_code.UseRowRetrieveEvents = False
        Me.Lbltype_code.UseTab = False
        Me.Lbltype_code.VisParameters = New String() {"Código=type_code", "Nombre=type_name"}
        Me.Lbltype_code.WhereCondition = Nothing
        Me.Lbltype_code.WhereParameters = Nothing
        '
        'xtxsuc_name
        '
        Me.xtxsuc_name.Location = New System.Drawing.Point(162, 136)
        Me.xtxsuc_name.Name = "xtxsuc_name"
        Me.xtxsuc_name.ReadOnly = True
        Me.xtxsuc_name.Size = New System.Drawing.Size(232, 20)
        Me.xtxsuc_name.TabIndex = 25
        Me.xtxsuc_name.Text = ""
        '
        'fecHasta
        '
        Me.fecHasta.CustomFormat = "dd/MM/yyyy"
        Me.fecHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cpinvcem.Fecha_fin"))
        Me.fecHasta.EditInitialValue = Nothing
        Me.fecHasta.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecHasta.FieldDescription = ""
        Me.fecHasta.FindInitialValue = "now"
        Me.fecHasta.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecHasta.IgnoreRequiered = False
        Me.fecHasta.Location = New System.Drawing.Point(96, 88)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.NewInitialValue = Nothing
        Me.fecHasta.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecHasta.Requiered = False
        Me.fecHasta.Size = New System.Drawing.Size(121, 20)
        Me.fecHasta.StatusBarPanelDescripcion = Nothing
        Me.fecHasta.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Fecha Inicial :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Fecha Final :"
        '
        'Fecha_ini
        '
        Me.Fecha_ini.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_ini.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cpinvcem.Fecha_ini"))
        Me.Fecha_ini.EditInitialValue = Nothing
        Me.Fecha_ini.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_ini.FieldDescription = ""
        Me.Fecha_ini.FindInitialValue = ""
        Me.Fecha_ini.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_ini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha_ini.IgnoreRequiered = False
        Me.Fecha_ini.Location = New System.Drawing.Point(96, 64)
        Me.Fecha_ini.Name = "Fecha_ini"
        Me.Fecha_ini.NewInitialValue = Nothing
        Me.Fecha_ini.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_ini.Requiered = False
        Me.Fecha_ini.Size = New System.Drawing.Size(121, 20)
        Me.Fecha_ini.StatusBarPanelDescripcion = Nothing
        Me.Fecha_ini.TabIndex = 31
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"prov_code=prov_code", "TextBox2=prov_name"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(392, 112)
        Me.LibXLookup2.LookCaption = Nothing
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
        Me.LibXLookup2.SrcParameters = New String() {"prov_code=prov_code"}
        Me.LibXLookup2.TabIndex = 35
        Me.LibXLookup2.TableName = "cpprovm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=prov_code", "Nombre=prov_name"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(160, 112)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(232, 20)
        Me.TextBox2.TabIndex = 34
        Me.TextBox2.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(40, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Suplidor :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.prov_code"))
        Me.TextBox3.Location = New System.Drawing.Point(96, 112)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(64, 20)
        Me.TextBox3.TabIndex = 33
        Me.TextBox3.Text = ""
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"suc_code=suc_code", "xtxsuc_name=suc_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(392, 136)
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
        Me.LibXLookup1.SrcParameters = New String() {"suc_code=suc_code"}
        Me.LibXLookup1.TabIndex = 36
        Me.LibXLookup1.TableName = "cgsucursal"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=suc_code", "Nombre=suc_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'r_cppaym03
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(530, 248)
        Me.Controls.Add(Me.LibXLookup1)
        Me.Controls.Add(Me.LibXLookup2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Fecha_ini)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fecHasta)
        Me.Controls.Add(Me.xtxsuc_name)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txttype_code)
        Me.Controls.Add(Me.Txttype_name)
        Me.Controls.Add(Me.Lbltype_code)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LibXCombo1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.xtxsuccode)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "r_cppaym03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Diario de Facturas"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim AxCrystalReport1 As LibX.ReportLib
        Dim SelecStmt As String
        Dim sFechaDesde As String
        Dim sFechaHasta As String
        Dim sProvee As String
        Dim sTipo As String
        Dim sType As String
        Dim sWhere As String
        Dim sBala As String

        Try

            If Not IsNull(e.row!Fecha_ini) Then
                sFechaDesde = CDate(e.row!Fecha_ini).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(e.row!Fecha_fin) Then
                sFechaHasta = CDate(e.row!Fecha_fin).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(e.row!prov_code) Then
                sProvee = e.row!prov_code.ToString
            End If

            If Not IsNull(e.row!type_prov) Then
                sTipo = e.row!type_prov.ToString
            End If

            If Not IsNull(e.row!type_code) Then
                sType = e.row!type_code.ToString
            End If

            If Not IsNull(e.row!balance) Then
                sBala = e.row!balance.ToString
            End If

            AxCrystalReport1 = New ReportLib("CXP", "r_cppaym03.rpt")

            With AxCrystalReport1
                sWhere = " 1=1 "

                If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                    sWhere = String.Concat(sWhere, " and cpinvcem.doc_date between '", Trim(sFechaDesde), "'and'", Trim(sFechaHasta), "'")
                ElseIf Trim(sFechaDesde) <> "" Then
                    sWhere = String.Concat(sWhere, " and cpinvcem.doc_date = '", Trim(sFechaDesde), "'")
                ElseIf Trim(sFechaHasta) <> "" Then
                    sWhere = String.Concat(sWhere, " and cpinvcem.doc_date = '", Trim(sFechaHasta), "'")
                End If

                'If Trim(Txtprov_code.Text) <> "" Then
                '    sWhere = String.Concat(sWhere, " and cpprovm.prov_code = '", Trim(e.row!prov_code.ToString))
                'End If

                If Not IsNull(e.row!prov_code) Then
                    sWhere = String.Concat(sWhere, " and cpprovm.prov_code = ", Trim(e.row!prov_code.ToString))
                End If


                If Not IsNull(e.row!type_prov) Then
                    sWhere = String.Concat(sWhere, " and cptypep.type_prov = ", Trim(e.row!type_prov.ToString))
                End If

                If Not IsNull(e.row!type_code) Then
                    sWhere = String.Concat(sWhere, " and ivtypem.type_code = '", Trim(e.row!type_code.ToString), "'")
                End If

                If Trim(sBala) <> "" Then
                    sWhere = String.Concat(sWhere, " and cpprovm.balance  ", Trim(sBala))
                End If



                .ParameterFields(1) = String.Concat("Fecha_ini;", Trim(sFechaDesde), ";TRUE")
                .ParameterFields(2) = String.Concat("fecha_fin;", Trim(sFechaHasta), ";true")
                '''.ParameterFields(2) = String.Concat("Cliente1;", cust_code1.Text, ";TRUE")
                '''.ParameterFields(3) = String.Concat("Cliente2;", cust_code2.Text, ";TRUE")

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

    Private Sub LibxDateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
