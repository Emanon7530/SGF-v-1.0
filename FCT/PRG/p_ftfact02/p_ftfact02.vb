Imports System.Configuration.ConfigurationSettings
Imports SGT.Facturacion.Operaciones
Public Class p_ftfact02
    Inherits System.Windows.Forms.Form
    Dim oPermission As SGT.Administracion.Entidades.Permission

    Dim WhDefault As Integer
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn4 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn5 As LibX.XEditTextBoxColumn
    Friend WithEvents lbldevoluciones As System.Windows.Forms.Label
    Friend WithEvents lblFActuras As System.Windows.Forms.Label
    Friend WithEvents btnUnmarkall As System.Windows.Forms.Button
    Friend WithEvents btnMarkAll As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataView1 As System.Data.DataView
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
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents ftfactm As System.Data.DataTable
    Friend WithEvents ftfactd As System.Data.DataTable
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents XDataGridBoolColumn1 As LibX.XDataGridBoolColumn
    Friend WithEvents chk_Devoluciones As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Facturas As System.Windows.Forms.CheckBox
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn6 As LibX.XEditTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Timer1 As System.Timers.Timer
    Friend WithEvents btnAutorizar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ftfactm = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.ftfactd = New System.Data.DataTable
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.btnUnmarkall = New System.Windows.Forms.Button
        Me.btnMarkAll = New System.Windows.Forms.Button
        Me.btnAutorizar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chk_Devoluciones = New System.Windows.Forms.CheckBox
        Me.chk_Facturas = New System.Windows.Forms.CheckBox
        Me.lbldevoluciones = New System.Windows.Forms.Label
        Me.lblFActuras = New System.Windows.Forms.Label
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.DataView1 = New System.Data.DataView
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XDataGridBoolColumn1 = New LibX.XDataGridBoolColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn5 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn4 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn6 = New LibX.XEditTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Timers.Timer
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 80)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio"
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LibXConnector1, "ftfactm.fact_date"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = False
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(432, 16)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = Nothing
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Requiered = False
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.LibxDateTimePicker1.TabIndex = 5
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = False
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "ftfactm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = True
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftfactm, Me.ftfactd})
        '
        'ftfactm
        '
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn14, Me.DataColumn11, Me.DataColumn15})
        Me.ftfactm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no"}, True)})
        Me.ftfactm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn14}
        Me.ftfactm.TableName = "ftfactm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "fact_number"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "fact_date"
        Me.DataColumn2.DataType = GetType(System.DateTime)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "cust_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "bus_name"
        Me.DataColumn4.MaxLength = 40
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "fact_total"
        Me.DataColumn5.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.AutoIncrement = True
        Me.DataColumn14.ColumnName = "ftserial_no"
        Me.DataColumn14.DataType = GetType(System.Int32)
        Me.DataColumn14.ReadOnly = True
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Aplicar"
        Me.DataColumn11.DataType = GetType(System.Int16)
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "type_code"
        Me.DataColumn15.MaxLength = 3
        '
        'ftfactd
        '
        Me.ftfactd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn13, Me.DataColumn12, Me.DataColumn16})
        Me.ftfactd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no"}, True)})
        Me.ftfactd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn13}
        Me.ftfactd.TableName = "ftfactd"
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "fact_number"
        Me.DataColumn6.DataType = GetType(System.Int16)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "fact_date"
        Me.DataColumn7.DataType = GetType(System.DateTime)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "cust_code"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "bus_name"
        Me.DataColumn9.MaxLength = 40
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "fact_total"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.AutoIncrement = True
        Me.DataColumn13.ColumnName = "ftserial_no"
        Me.DataColumn13.DataType = GetType(System.Int32)
        Me.DataColumn13.ReadOnly = True
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Aplicar"
        Me.DataColumn12.DataType = GetType(System.Int16)
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "type_code"
        Me.DataColumn16.MaxLength = 3
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
        Me.LibXDbSourceTable1.Sort = "ftserial_no"
        Me.LibXDbSourceTable1.Source = New String() {"select ftserial_no,fact_number, fact_date,cust_code, bus_name, fact_total,type_co" & _
        "de", "from ftfactm"}
        Me.LibXDbSourceTable1.TableName = "ftfactm"
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
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = False
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select ftserial_no,fact_number, fact_date,cust_code, bus_name, fact_total,type_co" & _
        "de", "from ftfactm"}
        Me.LibXDbSourceTable2.TableName = "ftfactd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'LibXLookup1
        '
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Nothing
        Me.LibXLookup1.DestParameters = Nothing
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.Location = New System.Drawing.Point(528, 40)
        Me.LibXLookup1.LookCaption = Nothing
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = Nothing
        Me.LibXLookup1.TabIndex = 4
        Me.LibXLookup1.TableName = Nothing
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = Nothing
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(320, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Factura:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ftfactm.fact_number"))
        Me.TextBox1.Location = New System.Drawing.Point(128, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Factura:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ftfactm.cust_code"))
        Me.TextBox3.Location = New System.Drawing.Point(128, 40)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = ""
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(16, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cliente:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ftfactm.bus_name"))
        Me.TextBox4.Location = New System.Drawing.Point(232, 40)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(288, 20)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = ""
        '
        'btnUnmarkall
        '
        Me.btnUnmarkall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUnmarkall.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnmarkall.Location = New System.Drawing.Point(88, 392)
        Me.btnUnmarkall.Name = "btnUnmarkall"
        Me.btnUnmarkall.Size = New System.Drawing.Size(80, 32)
        Me.btnUnmarkall.TabIndex = 9
        Me.btnUnmarkall.Text = "Desmarcar Todos"
        '
        'btnMarkAll
        '
        Me.btnMarkAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMarkAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarkAll.Location = New System.Drawing.Point(8, 392)
        Me.btnMarkAll.Name = "btnMarkAll"
        Me.btnMarkAll.Size = New System.Drawing.Size(80, 32)
        Me.btnMarkAll.TabIndex = 8
        Me.btnMarkAll.Text = "Marcar Todos"
        '
        'btnAutorizar
        '
        Me.btnAutorizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAutorizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAutorizar.Location = New System.Drawing.Point(432, 392)
        Me.btnAutorizar.Name = "btnAutorizar"
        Me.btnAutorizar.Size = New System.Drawing.Size(80, 32)
        Me.btnAutorizar.TabIndex = 7
        Me.btnAutorizar.Text = "Autorizar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_Devoluciones)
        Me.GroupBox2.Controls.Add(Me.chk_Facturas)
        Me.GroupBox2.Controls.Add(Me.lbldevoluciones)
        Me.GroupBox2.Controls.Add(Me.lblFActuras)
        Me.GroupBox2.Location = New System.Drawing.Point(576, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(96, 80)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Leyenda"
        '
        'chk_Devoluciones
        '
        Me.chk_Devoluciones.Location = New System.Drawing.Point(8, 48)
        Me.chk_Devoluciones.Name = "chk_Devoluciones"
        Me.chk_Devoluciones.Size = New System.Drawing.Size(80, 16)
        Me.chk_Devoluciones.TabIndex = 8
        Me.chk_Devoluciones.Text = "Devoluciones"
        '
        'chk_Facturas
        '
        Me.chk_Facturas.Location = New System.Drawing.Point(8, 16)
        Me.chk_Facturas.Name = "chk_Facturas"
        Me.chk_Facturas.Size = New System.Drawing.Size(80, 16)
        Me.chk_Facturas.TabIndex = 7
        Me.chk_Facturas.Text = "Facturas"
        '
        'lbldevoluciones
        '
        Me.lbldevoluciones.BackColor = System.Drawing.Color.NavajoWhite
        Me.lbldevoluciones.Location = New System.Drawing.Point(8, 64)
        Me.lbldevoluciones.Name = "lbldevoluciones"
        Me.lbldevoluciones.Size = New System.Drawing.Size(56, 8)
        Me.lbldevoluciones.TabIndex = 6
        '
        'lblFActuras
        '
        Me.lblFActuras.BackColor = System.Drawing.Color.Cyan
        Me.lblFActuras.Location = New System.Drawing.Point(8, 32)
        Me.lblFActuras.Name = "lblFActuras"
        Me.lblFActuras.Size = New System.Drawing.Size(56, 8)
        Me.lblFActuras.TabIndex = 4
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(682, 24)
        Me.LibXNavigator1.TabIndex = 14
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AllowSorting = False
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = True
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Documentos pendientes de Autorización"
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.DataMember = ""
        Me.LibXGrid1.DataSource = Me.DataView1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 120)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(664, 248)
        Me.LibXGrid1.TabIndex = 15
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem8, Me.MenuItem3, Me.MenuItem9, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Autorizar"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        Me.MenuItem8.Text = "Anular"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 3
        Me.MenuItem9.Text = "Visualizar"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 4
        Me.MenuItem4.Text = "Marcar Todos"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 5
        Me.MenuItem5.Text = "Desmarcar Todos"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 6
        Me.MenuItem6.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 7
        Me.MenuItem7.Text = "Refrescar"
        '
        'DataView1
        '
        Me.DataView1.AllowDelete = False
        Me.DataView1.AllowNew = False
        Me.DataView1.Table = Me.ftfactd
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XDataGridBoolColumn1, Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn5, Me.XEditTextBoxColumn3, Me.XEditTextBoxColumn4, Me.XEditTextBoxColumn6, Me.DataGridTextBoxColumn1})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ftfactd"
        '
        'XDataGridBoolColumn1
        '
        Me.XDataGridBoolColumn1.FalseValue = CType(0, Short)
        Me.XDataGridBoolColumn1.HeaderText = "Aplicar"
        Me.XDataGridBoolColumn1.MappingName = "Aplicar"
        Me.XDataGridBoolColumn1.NullText = "0"
        Me.XDataGridBoolColumn1.NullValue = 0
        Me.XDataGridBoolColumn1.TrueValue = CType(1, Short)
        Me.XDataGridBoolColumn1.UseCustomCellFormat = True
        Me.XDataGridBoolColumn1.Width = 50
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Número"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = True
        Me.XEditTextBoxColumn1.MappingName = "fact_number"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.UseCustomCellFormat = True
        Me.XEditTextBoxColumn1.Width = 80
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Fecha"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = True
        Me.XEditTextBoxColumn2.MappingName = "fact_date"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.UseCustomCellFormat = True
        Me.XEditTextBoxColumn2.Width = 80
        '
        'XEditTextBoxColumn5
        '
        Me.XEditTextBoxColumn5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn5.Format = ""
        Me.XEditTextBoxColumn5.FormatInfo = Nothing
        Me.XEditTextBoxColumn5.HeaderText = "Cliente No."
        Me.XEditTextBoxColumn5.ImageList = Nothing
        Me.XEditTextBoxColumn5.isReadOnly = True
        Me.XEditTextBoxColumn5.MappingName = "cust_code"
        Me.XEditTextBoxColumn5.MaxLength = 32767
        Me.XEditTextBoxColumn5.UseCustomCellFormat = True
        Me.XEditTextBoxColumn5.Width = 75
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Cliente"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = True
        Me.XEditTextBoxColumn3.MappingName = "bus_name"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.UseCustomCellFormat = True
        Me.XEditTextBoxColumn3.Width = 250
        '
        'XEditTextBoxColumn4
        '
        Me.XEditTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn4.Format = "###,###,##0.00"
        Me.XEditTextBoxColumn4.FormatInfo = Nothing
        Me.XEditTextBoxColumn4.HeaderText = "Total."
        Me.XEditTextBoxColumn4.ImageList = Nothing
        Me.XEditTextBoxColumn4.isReadOnly = True
        Me.XEditTextBoxColumn4.MappingName = "fact_total"
        Me.XEditTextBoxColumn4.MaxLength = 32767
        Me.XEditTextBoxColumn4.UseCustomCellFormat = True
        Me.XEditTextBoxColumn4.Width = 80
        '
        'XEditTextBoxColumn6
        '
        Me.XEditTextBoxColumn6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn6.Format = ""
        Me.XEditTextBoxColumn6.FormatInfo = Nothing
        Me.XEditTextBoxColumn6.ImageList = Nothing
        Me.XEditTextBoxColumn6.isReadOnly = True
        Me.XEditTextBoxColumn6.MappingName = "type_code"
        Me.XEditTextBoxColumn6.MaxLength = 32767
        Me.XEditTextBoxColumn6.UseCustomCellFormat = True
        Me.XEditTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "ftserial_no"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Location = New System.Drawing.Point(592, 392)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 32)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refrescar"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(512, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Anular"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(168, 392)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 32)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Visualizar"
        '
        'Timer1
        '
        Me.Timer1.Interval = 30000
        Me.Timer1.SynchronizingObject = Me
        '
        'p_ftfact02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(682, 447)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnUnmarkall)
        Me.Controls.Add(Me.btnMarkAll)
        Me.Controls.Add(Me.btnAutorizar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "p_ftfact02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Autorización de Documentos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibX.LibxConnectionActions.Find Then
                DataSet1.Tables("ftfactm").Rows.Clear()
                DataSet1.Tables("ftfactd").Rows.Clear()
                Timer1.Enabled = False
            End If

            If e.AcceptedAction = LibX.LibxConnectionActions.Find Then
                For Each oRow As DataRow In DataSet1.Tables("ftfactm").Rows
                    Dim nRow As DataRow = DataSet1.Tables("ftfactd").NewRow
                    nRow.ItemArray = oRow.ItemArray
                    DataSet1.Tables("ftfactd").Rows.Add(nRow)
                Next
                Timer1.Enabled = True
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub XEditTextBoxColumn1_SetCellFormat(ByVal sender As Object, ByVal e As LibX.XDataGridFormatCellEventArgs) Handles XEditTextBoxColumn1.SetCellFormat, _
                                                                                                                                XEditTextBoxColumn2.SetCellFormat, _
                                                                                                                                XEditTextBoxColumn3.SetCellFormat, _
                                                                                                                                XEditTextBoxColumn4.SetCellFormat, _
                                                                                                                                XEditTextBoxColumn5.SetCellFormat, _
                                                                                                                                XDataGridBoolColumn1.SetCellFormat
        Try

            If Not LibX.IsNull(LibXGrid1.Item(e.RowNumber, 6)) _
            AndAlso LibXGrid1.Item(e.RowNumber, 6) = "FCT" Then
                e.BackColor = lblFActuras.BackColor
            Else
                e.BackColor = lbldevoluciones.BackColor
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            If e.Action = LibX.LibxConnectionActions.Find Then
                DataSet1.Tables(0).Rows.Clear()
                DataSet1.Tables(1).Rows.Clear()
                LibXGrid1.ReadOnly = True
            End If

            If e.Action = LibX.LibxConnectionActions.Edit Then
                LibXGrid1.ReadOnly = False
            End If

            If e.AcceptedAction = LibX.LibxConnectionActions.Edit And DataSet1.Tables("ftfactd").Select("Aplicar=1").Length > 0 Then
                If MessageBox.Show("Seguro desea aplicar estas entradas?", "Aplicar Entradas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    Aplicar()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Function FaltaSerial(ByVal pftserial_no As Integer) As Boolean
        Dim SelectStmt As String
        Dim Xselect As LibX.Data.XSelecStmt
        Dim iCnt As Integer
        Dim oTable As DataTable

        Try
            SelectStmt = "select ftserial_no,ftfactd.item_code,qty from ftfactd, ivitemm " & _
                         " where ftfactd.item_code =ivitemm.item_code " & _
                         "   and ivitemm.item_serial = 1" & _
                         "   and ftfactd.ftserial_no = " & pftserial_no.ToString

            Xselect = New LibX.Data.XSelecStmt("ftfactd", SelectStmt)

            oTable = Xselect.GetTable

            If oTable.Rows.Count <= 0 Then
                Return False
            End If

            For Each oRow As DataRow In oTable.Rows
                SelectStmt = "select count(*) from ivseriem " & _
                             " where item_code = '" & oRow!item_code.ToString.Trim & _
                             "'   and ftserial_no = " & oRow!ftserial_no

                Xselect = New LibX.Data.XSelecStmt("ivseriem", SelectStmt)

                iCnt = Xselect.GetScalar

                If iCnt < oRow!qty Then
                    Throw New ApplicationException("Falta serie!")
                End If
            Next

            Return False

        Catch ex As Exception
            LibX.Log.Show(ex)
            Return True
        End Try
    End Function

    Private Sub Aplicar()
        Dim oPostDoc As SGT.Facturacion.Operaciones.PosteoDocumento
        Dim oPostParam As PosteoDocumento.Parametros

        Try

            oPostDoc = New SGT.Facturacion.Operaciones.PosteoDocumento
            oPostParam = New SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

            For Each oRow As DataRow In DataSet1.Tables("ftfactd").Select("Aplicar = 1")

                If FaltaSerial(oRow!ftserial_no) Then
                    Exit Sub
                End If

                oPostParam.SerialNumero = oRow!ftserial_no
                oPostParam.UseTransaction = True
                oPostParam.AplicarInventario = True
                oPostParam.AplicarCXC = False
                oPostParam.ApliarComision = True

                oPostDoc.Aplicar(oPostParam)

                DataSet1.Tables("ftfactd").Rows.Remove(oRow)
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Anular()
        Dim oPostDoc As SGT.Facturacion.Operaciones.PosteoDocumento
        Dim oPostParam As SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

        Try

            If MessageBox.Show("Seguro desea Anular este documento?", "Anular Documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If

            If oPermission.isAutorization(SGT.Administracion.Entidades.Permission.TipoAutorizacionEnum.AnularDocumento) = False Then
                Throw New ApplicationException("No esta autorizado a anular documentos")
            End If

            oPostDoc = New SGT.Facturacion.Operaciones.PosteoDocumento
            oPostParam = New SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

            For Each oRow As DataRow In DataSet1.Tables("ftfactd").Select("Aplicar = 1")

                oPostParam.SerialNumero = oRow!ftserial_no
                oPostParam.AplicarCXC = False
                oPostParam.ApliarComision = True
                oPostParam.AplicarInventario = False

                oPostDoc.Anular(oPostParam)

                DataSet1.Tables("ftfactd").Rows.Remove(oRow)
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutorizar.Click
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim oPostDoc As SGT.Facturacion.Operaciones.PosteoDocumento
        Dim oPostParam As PosteoDocumento.Parametros

        Try

            oPostDoc = New SGT.Facturacion.Operaciones.PosteoDocumento
            oPostParam = New SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

            XUpdate = New LibX.Data.XUpdateStmt("ftfactm")
            XUpdate.FieldsSet("fact_status") = 0
            XUpdate.Fields("ftserial_no") = 0

            '// Autorizar documentos
            For Each oRow As DataRow In DataSet1.Tables("ftfactd").Select("Aplicar = 1")
                XUpdate.Fields("ftserial_no") = Val(oRow!ftserial_no.ToString.Trim)

                '// Si tiene serie, enviar a almacen
                If TieneSerie(Val(oRow!ftserial_no.ToString.Trim)) = True Then
                    XUpdate.FieldsSet("fact_status") = 1 '// En Almacen
                Else
                    XUpdate.FieldsSet("fact_status") = 2 '// En Caja

                    oPostParam.SerialNumero = oRow!ftserial_no
                    oPostParam.UseTransaction = True
                    oPostParam.AplicarInventario = True
                    oPostParam.AplicarCXC = False
                    oPostParam.ApliarComision = True

                    oPostDoc.Aplicar(oPostParam)
                End If

                XUpdate.Execute()

                '// Eliminar de la cola
                DataSet1.Tables("ftfactd").Rows.Remove(oRow)
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAll.Click
        Try
            For Each oRow As DataRow In DataSet1.Tables("ftfactd").Rows
                oRow!Aplicar = 1
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnmarkall.Click
        Try
            For Each oRow As DataRow In DataSet1.Tables("iventrdd").Rows
                oRow!Aplicar = 0
            Next
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        e.AditionalWhere = "fact_status = 4 "

    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try
            btnMarkAll.Enabled = e.isEditing And LibXConnector1.HasRecords
            btnUnmarkall.Enabled = e.isEditing And LibXConnector1.HasRecords
            '       btnRefresh.Enabled = Not e.isEditing And LibXConnector1.HasRecords

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub LibXGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles LibXGrid1.Navigate

    End Sub

    Private Sub p_ftfact01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ftfactd.Columns("ftserial_no").AutoIncrement = False
            ftfactm.Columns("ftserial_no").AutoIncrement = False
            btnRefresh_Click(sender, e)
            oPermission = New SGT.Administracion.Entidades.Permission

            WhDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibXWhDefault").ToString)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Dim SerialNo As Integer
        Try

            SerialNo = LibXGrid1.CurrentRowIndex

            LibXConnector1.GetDS().tables(0).clear()
            LibXConnector1.GetDS().tables(1).clear()

            LibXConnector1.AcceptFind()

            If SerialNo > 0 Then
                LibXGrid1.CurrentRowIndex = SerialNo
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        btnRefresh_Click(sender, e)
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button10_Click(sender, e)
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Button8_Click(sender, e)
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Button9_Click(sender, e)
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Try
            ftfactd.Rows(LibXGrid1.CurrentRowIndex).BeginEdit()
            ftfactd.Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1
            ftfactd.Rows(LibXGrid1.CurrentRowIndex).EndEdit()
            Button10_Click(sender, e)
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            DataSet1.Tables("ftfactd").Rows(LibXGrid1.CurrentRowIndex).BeginEdit()
            DataSet1.Tables("ftfactd").Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1
            DataSet1.Tables("ftfactd").Rows(LibXGrid1.CurrentRowIndex).EndEdit()
            Anular()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Button1_Click(Nothing, Nothing)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim xParam As LibX.LibxPrgParams
        Try
            xParam = New LibX.LibxPrgParams
            xParam.AllowDelete = False
            xParam.AllowEdit = True
            xParam.AllowNew = False
            xParam.AllowPrint = True
            xParam.AllowQuery = False

            xParam.Value = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 7)

            LibX.App.CurrentPrgParams = xParam

            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 6) = "FCT" Then
                LibX.LibXRunner.Run("i_ftfact01", "FCT")
            End If

            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 6) = "DVF" Then
                LibX.LibXRunner.Run("i_ftdevm01", "FCT")
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Timer1_Elapsed(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs) Handles Timer1.Elapsed
        Try
            If ftfactd.Rows.Count < 15 Then
                btnRefresh_Click(sender, e)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub p_ftfact01_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Timer1.Enabled = False
    End Sub

    Private Sub chk_Facturas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Facturas.CheckedChanged
        Try
            ApplyFilter()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub chk_Devoluciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Devoluciones.CheckedChanged
        Try
            ApplyFilter()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub ApplyFilter()
        Dim Filter As String = ""
        Try

            If chk_Facturas.Checked = True Then
                Filter = "type_code = 'FCT'"
            End If

            If chk_Devoluciones.Checked = True Then
                If Filter.Length = 0 Then
                    Filter = "type_code = 'DVF'"
                Else
                    Filter = Filter & " and type_code = 'DVF'"
                End If
            End If

            DataView1.RowFilter = Filter
        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub

    Private Function TieneSerie(ByVal pSerial As Integer) As Boolean
        Dim oDocumento As SGT.Facturacion.Entidades.Documento
        Try
            oDocumento = New SGT.Facturacion.Entidades.Documento

            If oDocumento.Serializar(pSerial) = True Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        Finally
            oDocumento = Nothing
        End Try
    End Function

End Class
