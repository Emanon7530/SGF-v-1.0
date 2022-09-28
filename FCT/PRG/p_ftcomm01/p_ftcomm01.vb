Imports System.Configuration.ConfigurationSettings
Imports SGT.Facturacion.Operaciones
Imports LibX
Public Class p_ftcomm01
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents btnUnmarkall As System.Windows.Forms.Button
    Friend WithEvents btnMarkAll As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents LibXGrid2 As LibX.LibXGrid
    Friend WithEvents XEditTextBoxColumn8 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn9 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn10 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn11 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents XdataGridTableStyle2 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn4 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn5 As LibX.XEditTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataView2 As System.Data.DataView
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
    Friend WithEvents XDataGridBoolColumn1 As LibX.XDataGridBoolColumn
    Friend WithEvents dbtFechaini As LibX.LibxDateTimePicker
    Friend WithEvents dbtFechaFin As LibX.LibxDateTimePicker
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents gColVend As LibX.XEditTextBoxColumn
    Friend WithEvents gColAplicaDet As LibX.XDataGridBoolColumn
    Friend WithEvents chkImpri As LibX.LibxCheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents xcbo_comm_status As LibX.LibXCombo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents vend_code As System.Windows.Forms.TextBox
    Friend WithEvents vend_name As System.Windows.Forms.TextBox
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents ftcomim As System.Data.DataTable
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ftcomim = New System.Data.DataTable
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.vend_code = New System.Windows.Forms.TextBox
        Me.xcbo_comm_status = New LibX.LibXCombo
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.dbtFechaini = New LibX.LibxDateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dbtFechaFin = New LibX.LibxDateTimePicker
        Me.chkImpri = New LibX.LibxCheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.vend_name = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.btnUnmarkall = New System.Windows.Forms.Button
        Me.btnMarkAll = New System.Windows.Forms.Button
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
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
        Me.gColVend = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn8 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn9 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn10 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn11 = New LibX.XEditTextBoxColumn
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.LibXGrid2 = New LibX.LibXGrid
        Me.DataView2 = New System.Data.DataView
        Me.XdataGridTableStyle2 = New LibX.XdataGridTableStyle
        Me.gColAplicaDet = New LibX.XDataGridBoolColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn4 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn5 = New LibX.XEditTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftcomim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.vend_code)
        Me.GroupBox1.Controls.Add(Me.xcbo_comm_status)
        Me.GroupBox1.Controls.Add(Me.LibxCheckBox1)
        Me.GroupBox1.Controls.Add(Me.dbtFechaini)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dbtFechaFin)
        Me.GroupBox1.Controls.Add(Me.chkImpri)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.vend_name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 72)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio"
        '
        'LibXLookup1
        '
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"vend_code=vend_code", "vend_name=vend_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.Location = New System.Drawing.Point(576, 40)
        Me.LibXLookup1.LookCaption = "Vendedores"
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"vend_code=vend_code"}
        Me.LibXLookup1.TabIndex = 9
        Me.LibXLookup1.TableName = "ftvendm"
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Codigo=vend_code", "Nombre=vend_name", "Comisión=porc_comision"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "ftcomim"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = True
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = True
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftcomim, Me.DataTable2})
        '
        'ftcomim
        '
        Me.ftcomim.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn1})
        Me.ftcomim.TableName = "ftcomim"
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.ColumnName = "vend_code"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "vend_name"
        Me.DataColumn18.MaxLength = 60
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "porc_comision"
        Me.DataColumn19.DataType = GetType(System.Decimal)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sales_total"
        Me.DataColumn20.DataType = GetType(System.Decimal)
        Me.DataColumn20.ReadOnly = True
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "comis_total"
        Me.DataColumn21.DataType = GetType(System.Decimal)
        Me.DataColumn21.ReadOnly = True
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Aplicar"
        Me.DataColumn1.DataType = GetType(System.Int16)
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.DataTable2.TableName = "ftcomid"
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "fact_number"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "fact_date"
        Me.DataColumn23.DataType = GetType(System.DateTime)
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.ColumnName = "fact_total"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "amount"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Aplicar"
        Me.DataColumn2.DataType = GetType(System.Int16)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "bus_name"
        Me.DataColumn3.MaxLength = 40
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "vend_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "ftserial_no"
        Me.DataColumn5.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.HeaderIsOnGrid = True
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select ftcomid.vend_code,ftvendm.vend_name,ftvendm.porc_comision,", "sum(ftfactm.fact_total) sales_total, ", "sum(ftcomid.amount) comis_total", "from ftcomid inner join ftvendm", "on ftcomid.vend_code = ftvendm.vend_code", "inner join ftfactm", "on ftcomid.ftserial_no = ftfactm.ftserial_no", "group by ftcomid.vend_code,ftvendm.vend_name,ftvendm.porc_comision"}
        Me.LibXDbSourceTable1.TableName = "ftcomim"
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
        Me.LibXDbSourceTable2.HeaderIsOnGrid = True
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = False
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"vend_code=vend_code"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select ftfactm.fact_number,ftfactm.fact_date,ftfactm.fact_total,", "ftcomid.amount,ftfactm.bus_name,ftfactm.vend_code,ftcomid.ftserial_no", "from ftfactm inner join ftcomid", "on ftfactm.ftserial_no = ftcomid.ftserial_no"}
        Me.LibXDbSourceTable2.TableName = "ftcomid"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'vend_code
        '
        Me.vend_code.Location = New System.Drawing.Point(264, 40)
        Me.vend_code.Name = "vend_code"
        Me.vend_code.Size = New System.Drawing.Size(40, 20)
        Me.vend_code.TabIndex = 8
        Me.vend_code.Text = ""
        '
        'xcbo_comm_status
        '
        Me.xcbo_comm_status.AllowDefaultSort = True
        Me.xcbo_comm_status.bound = True
        Me.xcbo_comm_status.currValue = Nothing
        Me.xcbo_comm_status.DefaultWhereString = Nothing
        Me.xcbo_comm_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_comm_status.EditInitialValue = Nothing
        Me.xcbo_comm_status.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_comm_status.FindInitialValue = Nothing
        Me.xcbo_comm_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_comm_status.IgnoreRequiered = False
        Me.xcbo_comm_status.Items.AddRange(New Object() {"2-Pendiente de pago", "3-Pagadas"})
        Me.xcbo_comm_status.Location = New System.Drawing.Point(264, 16)
        Me.xcbo_comm_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_comm_status.LookupKeyField = Nothing
        Me.xcbo_comm_status.LookupTableName = Nothing
        Me.xcbo_comm_status.Name = "xcbo_comm_status"
        Me.xcbo_comm_status.NewInitialValue = Nothing
        Me.xcbo_comm_status.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_comm_status.Requiered = False
        Me.xcbo_comm_status.Required = False
        Me.xcbo_comm_status.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_comm_status.SqlString = Nothing
        Me.xcbo_comm_status.TabIndex = 7
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(632, 16)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = Nothing
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = False
        Me.LibxCheckBox1.Size = New System.Drawing.Size(136, 16)
        Me.LibxCheckBox1.TabIndex = 6
        Me.LibxCheckBox1.Text = "Solo las pagas"
        Me.LibxCheckBox1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'dbtFechaini
        '
        Me.dbtFechaini.CustomFormat = "dd/MM/yyyy"
        Me.dbtFechaini.EditInitialValue = Nothing
        Me.dbtFechaini.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dbtFechaini.FindInitialValue = Nothing
        Me.dbtFechaini.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dbtFechaini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dbtFechaini.IgnoreRequiered = False
        Me.dbtFechaini.Location = New System.Drawing.Point(96, 16)
        Me.dbtFechaini.Name = "dbtFechaini"
        Me.dbtFechaini.NewInitialValue = Nothing
        Me.dbtFechaini.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dbtFechaini.Requiered = False
        Me.dbtFechaini.Size = New System.Drawing.Size(88, 20)
        Me.dbtFechaini.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Inicial:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dbtFechaFin
        '
        Me.dbtFechaFin.CustomFormat = "dd/MM/yyyy"
        Me.dbtFechaFin.EditInitialValue = Nothing
        Me.dbtFechaFin.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dbtFechaFin.FindInitialValue = Nothing
        Me.dbtFechaFin.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dbtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dbtFechaFin.IgnoreRequiered = False
        Me.dbtFechaFin.Location = New System.Drawing.Point(96, 40)
        Me.dbtFechaFin.Name = "dbtFechaFin"
        Me.dbtFechaFin.NewInitialValue = Nothing
        Me.dbtFechaFin.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dbtFechaFin.Requiered = False
        Me.dbtFechaFin.Size = New System.Drawing.Size(88, 20)
        Me.dbtFechaFin.TabIndex = 5
        '
        'chkImpri
        '
        Me.chkImpri.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkImpri.EditInitialValue = Nothing
        Me.chkImpri.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chkImpri.FindInitialValue = Nothing
        Me.chkImpri.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chkImpri.IgnoreRequiered = False
        Me.chkImpri.KeepEnabled = False
        Me.chkImpri.Location = New System.Drawing.Point(632, 40)
        Me.chkImpri.Name = "chkImpri"
        Me.chkImpri.NewInitialValue = Nothing
        Me.chkImpri.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chkImpri.ReadOnly = False
        Me.chkImpri.Requiered = False
        Me.chkImpri.Size = New System.Drawing.Size(136, 16)
        Me.chkImpri.TabIndex = 6
        Me.chkImpri.Text = "Imprimir Resumido?"
        Me.chkImpri.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.chkImpri.ThreeState = True
        Me.chkImpri.value = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(208, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Estatus:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(192, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Vendedor:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'vend_name
        '
        Me.vend_name.Location = New System.Drawing.Point(312, 40)
        Me.vend_name.Name = "vend_name"
        Me.vend_name.ReadOnly = True
        Me.vend_name.Size = New System.Drawing.Size(264, 20)
        Me.vend_name.TabIndex = 8
        Me.vend_name.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(400, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Condición:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Items.AddRange(New Object() {"2-Pendiente de pago", "3-Pagadas"})
        Me.LibXCombo1.Location = New System.Drawing.Point(472, 16)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = Nothing
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(121, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.TabIndex = 7
        '
        'btnUnmarkall
        '
        Me.btnUnmarkall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUnmarkall.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnmarkall.Location = New System.Drawing.Point(88, 480)
        Me.btnUnmarkall.Name = "btnUnmarkall"
        Me.btnUnmarkall.Size = New System.Drawing.Size(80, 32)
        Me.btnUnmarkall.TabIndex = 9
        Me.btnUnmarkall.Text = "Desmarcar Todos"
        '
        'btnMarkAll
        '
        Me.btnMarkAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMarkAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarkAll.Location = New System.Drawing.Point(8, 480)
        Me.btnMarkAll.Name = "btnMarkAll"
        Me.btnMarkAll.Size = New System.Drawing.Size(80, 32)
        Me.btnMarkAll.TabIndex = 8
        Me.btnMarkAll.Text = "Marcar Todos"
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(802, 24)
        Me.LibXNavigator1.TabIndex = 14
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AllowSorting = False
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = True
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Documentos por Aplicar"
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.DataMember = ""
        Me.LibXGrid1.DataSource = Me.DataView1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 104)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(784, 136)
        Me.LibXGrid1.TabIndex = 15
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem1, Me.MenuItem8, Me.MenuItem3, Me.MenuItem9, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7})
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Serializar"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.Text = "Enviar a Caja"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 2
        Me.MenuItem8.Text = "Anular"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 4
        Me.MenuItem9.Text = "Visualizar"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 5
        Me.MenuItem4.Text = "Marcar Todos"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 6
        Me.MenuItem5.Text = "Desmarcar Todos"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 7
        Me.MenuItem6.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 8
        Me.MenuItem7.Text = "Refrescar"
        '
        'DataView1
        '
        Me.DataView1.AllowDelete = False
        Me.DataView1.AllowNew = False
        Me.DataView1.Table = Me.ftcomim
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XDataGridBoolColumn1, Me.gColVend, Me.XEditTextBoxColumn8, Me.XEditTextBoxColumn9, Me.XEditTextBoxColumn10, Me.XEditTextBoxColumn11})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ftcomim"
        '
        'XDataGridBoolColumn1
        '
        Me.XDataGridBoolColumn1.FalseValue = CType(0, Short)
        Me.XDataGridBoolColumn1.HeaderText = "Aplicar"
        Me.XDataGridBoolColumn1.MappingName = "Aplicar"
        Me.XDataGridBoolColumn1.NullValue = 0
        Me.XDataGridBoolColumn1.TrueValue = CType(1, Short)
        Me.XDataGridBoolColumn1.UseCustomCellFormat = False
        Me.XDataGridBoolColumn1.Width = 50
        '
        'gColVend
        '
        Me.gColVend.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColVend.Format = ""
        Me.gColVend.FormatInfo = Nothing
        Me.gColVend.HeaderText = "Vendedor"
        Me.gColVend.ImageList = Nothing
        Me.gColVend.isReadOnly = False
        Me.gColVend.MappingName = "vend_code"
        Me.gColVend.MaxLength = 32767
        Me.gColVend.UseCustomCellFormat = False
        Me.gColVend.Width = 60
        '
        'XEditTextBoxColumn8
        '
        Me.XEditTextBoxColumn8.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn8.Format = ""
        Me.XEditTextBoxColumn8.FormatInfo = Nothing
        Me.XEditTextBoxColumn8.HeaderText = "Nombre"
        Me.XEditTextBoxColumn8.ImageList = Nothing
        Me.XEditTextBoxColumn8.isReadOnly = False
        Me.XEditTextBoxColumn8.MappingName = "vend_name"
        Me.XEditTextBoxColumn8.MaxLength = 32767
        Me.XEditTextBoxColumn8.UseCustomCellFormat = False
        Me.XEditTextBoxColumn8.Width = 350
        '
        'XEditTextBoxColumn9
        '
        Me.XEditTextBoxColumn9.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn9.Format = ""
        Me.XEditTextBoxColumn9.FormatInfo = Nothing
        Me.XEditTextBoxColumn9.HeaderText = "% Comisión"
        Me.XEditTextBoxColumn9.ImageList = Nothing
        Me.XEditTextBoxColumn9.isReadOnly = False
        Me.XEditTextBoxColumn9.MappingName = "porc_comision"
        Me.XEditTextBoxColumn9.MaxLength = 32767
        Me.XEditTextBoxColumn9.UseCustomCellFormat = False
        Me.XEditTextBoxColumn9.Width = 60
        '
        'XEditTextBoxColumn10
        '
        Me.XEditTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn10.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn10.Format = ""
        Me.XEditTextBoxColumn10.FormatInfo = Nothing
        Me.XEditTextBoxColumn10.HeaderText = "Total Vendido"
        Me.XEditTextBoxColumn10.ImageList = Nothing
        Me.XEditTextBoxColumn10.isReadOnly = False
        Me.XEditTextBoxColumn10.MappingName = "sales_total"
        Me.XEditTextBoxColumn10.MaxLength = 32767
        Me.XEditTextBoxColumn10.UseCustomCellFormat = False
        Me.XEditTextBoxColumn10.Width = 101
        '
        'XEditTextBoxColumn11
        '
        Me.XEditTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn11.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn11.Format = ""
        Me.XEditTextBoxColumn11.FormatInfo = Nothing
        Me.XEditTextBoxColumn11.HeaderText = "Comisión"
        Me.XEditTextBoxColumn11.ImageList = Nothing
        Me.XEditTextBoxColumn11.isReadOnly = False
        Me.XEditTextBoxColumn11.MappingName = "comis_total"
        Me.XEditTextBoxColumn11.MaxLength = 32767
        Me.XEditTextBoxColumn11.UseCustomCellFormat = False
        Me.XEditTextBoxColumn11.Width = 101
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Location = New System.Drawing.Point(592, 480)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 32)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refrescar"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(512, 480)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Anular"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(168, 480)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 32)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Visualizar"
        '
        'LibXGrid2
        '
        Me.LibXGrid2.AutoAdjustLastColumn = True
        Me.LibXGrid2.AutoSearch = False
        Me.LibXGrid2.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid2.CaptionText = "Facturas"
        Me.LibXGrid2.DataMember = ""
        Me.LibXGrid2.DataSource = Me.DataView2
        Me.LibXGrid2.FullRowSelect = False
        Me.LibXGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid2.IsReadOnly = False
        Me.LibXGrid2.Location = New System.Drawing.Point(8, 280)
        Me.LibXGrid2.Name = "LibXGrid2"
        Me.LibXGrid2.ReadOnly = True
        Me.LibXGrid2.searchText = ""
        Me.LibXGrid2.showFooterBar = True
        Me.LibXGrid2.Size = New System.Drawing.Size(776, 152)
        Me.LibXGrid2.TabIndex = 16
        Me.LibXGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle2})
        Me.LibXGrid2.UseAutoFillLines = True
        Me.LibXGrid2.UseHandCursor = False
        '
        'DataView2
        '
        Me.DataView2.AllowDelete = False
        Me.DataView2.AllowNew = False
        Me.DataView2.Table = Me.DataTable2
        '
        'XdataGridTableStyle2
        '
        Me.XdataGridTableStyle2.DataGrid = Me.LibXGrid2
        Me.XdataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColAplicaDet, Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn3, Me.XEditTextBoxColumn4, Me.XEditTextBoxColumn5})
        Me.XdataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle2.MappingName = "ftcomid"
        '
        'gColAplicaDet
        '
        Me.gColAplicaDet.FalseValue = CType(0, Short)
        Me.gColAplicaDet.HeaderText = "Aplicar"
        Me.gColAplicaDet.MappingName = "Aplicar"
        Me.gColAplicaDet.NullValue = 0
        Me.gColAplicaDet.TrueValue = CType(1, Short)
        Me.gColAplicaDet.UseCustomCellFormat = False
        Me.gColAplicaDet.Width = 50
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Número"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "fact_number"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 75
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Fecha"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "fact_date"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 75
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Cliente"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = False
        Me.XEditTextBoxColumn3.MappingName = "bus_name"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 350
        '
        'XEditTextBoxColumn4
        '
        Me.XEditTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn4.Format = ""
        Me.XEditTextBoxColumn4.FormatInfo = Nothing
        Me.XEditTextBoxColumn4.HeaderText = "Monto"
        Me.XEditTextBoxColumn4.ImageList = Nothing
        Me.XEditTextBoxColumn4.isReadOnly = False
        Me.XEditTextBoxColumn4.MappingName = "fact_total"
        Me.XEditTextBoxColumn4.MaxLength = 32767
        Me.XEditTextBoxColumn4.UseCustomCellFormat = False
        Me.XEditTextBoxColumn4.Width = 80
        '
        'XEditTextBoxColumn5
        '
        Me.XEditTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn5.Format = ""
        Me.XEditTextBoxColumn5.FormatInfo = Nothing
        Me.XEditTextBoxColumn5.HeaderText = "Comisión"
        Me.XEditTextBoxColumn5.ImageList = Nothing
        Me.XEditTextBoxColumn5.isReadOnly = False
        Me.XEditTextBoxColumn5.MappingName = "amount"
        Me.XEditTextBoxColumn5.MaxLength = 32767
        Me.XEditTextBoxColumn5.UseCustomCellFormat = False
        Me.XEditTextBoxColumn5.Width = 80
        '
        'p_ftcomm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(802, 527)
        Me.Controls.Add(Me.LibXGrid2)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.btnUnmarkall)
        Me.Controls.Add(Me.btnMarkAll)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "p_ftcomm01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pago de Comisiones"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftcomim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim mTable As DataTable

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.AcceptedAction = LibxConnectionActions.Find Then
                Dim sSql As String

                Dim sFechaDesde As String
                Dim sFechaHasta As String
                Dim sWhere As String

                sFechaDesde = CDate(dbtFechaini.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
                sFechaHasta = CDate(dbtFechaFin.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)


                sWhere = " 1=1 "
                If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                    sWhere = String.Concat(sWhere, " and ftfactm.fact_date between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
                ElseIf Trim(sFechaDesde) <> "" Then
                    sWhere = String.Concat(sWhere, " and ftfactm.fact_date = '", Trim(sFechaDesde), "'")
                ElseIf Trim(sFechaHasta) <> "" Then
                    sWhere = String.Concat(sWhere, " and ftfactm.fact_date = '", Trim(sFechaHasta), "'")
                End If

                If vend_code.Text.Trim.Length > 0 Then
                    sWhere = String.Concat(sWhere, " and ftfactm.vend_code = ", vend_code.Text)
                End If

                sWhere = String.Concat("fact_status = 3 and ftfactm.type_code = 'FCT' and ", sWhere)

                ''''sSql = String.Concat(" select ftfactm.fact_number,ftfactm.fact_date,ftfactm.fact_total,", _
                ''''                     "        ftcomid.amount,ftfactm.bus_name,ftfactm.vend_code,ftcomid.ftserial_no ", _
                ''''                     "  from ftfactm inner join ftcomid ", _
                ''''                     "       on ftfactm.ftserial_no = ftcomid.ftserial_no ", _
                ''''                     "  Where ftcomid.comm_serial is null and ", sWhere)

                sSql = String.Concat("SELECT ftfactm.fact_date,ftfactm.fact_number,ftfactm.vend_code,vend_name,", _
                                        " porc_comision,(fact_total - descto) Monto,((fact_total - descto) * porc_comision /100) Comision ", _
                                        " from  ftfactm inner join ftvendm ", _
                                        " on ftfactm.vend_code = ftvendm.vend_code ", _
                                        " where ftfactm.ftserial_no not in (select ftcomid.ftserial_no from ftcomid)", _
                                        " and ", sWhere)

                Dim oTable As DataTable
                mTable = LibX.Data.Manager.GetDataTable(sSql)

                oTable = Me.DataView2.Table

                For Each oRow As DataRow In mTable.Rows
                    oTable.ImportRow(oRow)
                Next

            End If

            If e.AcceptedAction = LibxConnectionActions.Edit Then

                PrintReport()

            End If



        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub PrintReport()
        Dim AxCrystalReport1 As LibX.ReportLib
        Try
            Dim SelecStmt As String
            Dim sFechaDesde As String
            Dim sFechaHasta As String
            Dim sCond As String
            Dim sWhere As String

            sFechaDesde = CDate(dbtFechaini.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            sFechaHasta = CDate(dbtFechaFin.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)

            AxCrystalReport1 = New LibX.ReportLib

            With AxCrystalReport1
                If Me.chkImpri.Checked Then
                    .ReportFileName = MdlUtil.GetReportPath("FCT", "r_ftcomm01.rpt")
                Else
                    .ReportFileName = MdlUtil.GetReportPath("FCT", "r_ftcomm01b.rpt")
                End If
                .Connect = Configuration.ConfigurationSettings.AppSettings.Get("LibXConnectReport")

                '// Pasar el Connection String a cada subreport
                For i As Int16 = 0 To .GetNSubreports - 1
                    .SubreportToChange = .GetNthSubreportName(i)
                    .Connect = Configuration.ConfigurationSettings.AppSettings.Get("LibXConnectReport")
                Next

                '// Localizarse en el reporte principal
                .SubreportToChange = ""

                sWhere = " 1=1 "
                If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                    sWhere = String.Concat(sWhere, " and ftfactm.fact_date between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
                ElseIf Trim(sFechaDesde) <> "" Then
                    sWhere = String.Concat(sWhere, " and ftfactm.fact_date = '", Trim(sFechaDesde), "'")
                ElseIf Trim(sFechaHasta) <> "" Then
                    sWhere = String.Concat(sWhere, " and ftfactm.fact_date = '", Trim(sFechaHasta), "'")
                End If

                If vend_code.Text.Trim.Length > 0 Then
                    sWhere = String.Concat(sWhere, " and ftfactm.vend_code = ", vend_code.Text)
                End If

                sWhere = String.Concat("fact_status = 3 and ftfactm.type_code = 'FCT' and ", sWhere)

                .ParameterFields(0) = String.Concat("fechaini;", Trim(sFechaDesde), ";TRUE")
                .ParameterFields(1) = String.Concat("fechafin;", Trim(sFechaHasta), ";TRUE")


                '// Recibir el SQL Query
                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                .SQLQuery = SelecStmt

                '// Ejecutar el reporte
                .WindowState = ReportLib.WindowsStates.Maximixed
                .Action = 1


            End With


        Catch ex As Exception
            Log.Show(ex)
        End Try

    End Sub



    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try

            If e.Action = LibX.LibxConnectionActions.Accept And e.AcceptedAction = LibX.LibxConnectionActions.Edit Then


                Dim intSe As Integer
                For Each orow As DataRowView In Me.DataView1
                    If Not IsNull(orow!aplicar) AndAlso orow!aplicar = 1 Then
                        Dim oS As New LibX.Data.XInsertStmt("ftcomim", "comm_serial")

                        oS!comm_Serial = 0
                        oS!comm_Date = LibX.Data.Manager.Connection.GetDate
                        oS!vend_code = orow!vend_code
                        oS!amount = orow!comis_total

                        intSe = oS.Execute()

                        For Each orow2 As DataRowView In Me.DataView2
                            If orow2!vend_code = orow!vend_code Then
                                If Not IsNull(orow2!aplicar) AndAlso orow2!aplicar = 1 Then
                                    Dim oS2 As New LibX.Data.XUpdateStmt("ftcomid")
                                    oS2!comm_Serial = intSe
                                    oS2!comm_status = 3 'Pagada
                                    oS2.Fields("vend_code") = orow2!vend_code
                                    oS2.Fields("ftserial_no") = orow2!ftserial_no

                                    oS2.Execute()
                                End If
                            End If

                        Next
                    End If
                Next
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
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

                'oPostParam.SerialNumero = oRow!ftserial_no
                'oPostParam.UseTransaction = True
                'oPostParam.AplicarInventario = True
                'oPostParam.AplicarCXC = False
                'oPostParam.ApliarComision = False

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
            oPostDoc = New SGT.Facturacion.Operaciones.PosteoDocumento
            oPostParam = New SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

            For Each oRow As DataRow In DataSet1.Tables("ftfactd").Select("Aplicar = 1")

                oPostParam.SerialNumero = oRow!ftserial_no
                'oPostParam.
                'oPostParam.AplicarCXC = False
                'oPostParam.ApliarComision = False
                'oPostParam.AplicarInventario = False

                oPostDoc.Anular(oPostParam)

                DataSet1.Tables("ftfactd").Rows.Remove(oRow)
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub


    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAll.Click
        For Each oRow As DataRowView In Me.DataView2
            oRow!Aplicar = 1
        Next
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnmarkall.Click
        For Each oRow As DataRowView In Me.DataView2
            oRow!Aplicar = 0
        Next
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim sSql As String

        Dim sFechaDesde As String
        Dim sFechaHasta As String
        Dim sWhere As String

        'sFechaDesde = CDate(dbtFechaini.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
        'sFechaHasta = CDate(dbtFechaFin.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)

        sFechaDesde = dbtFechaini.Value
        sFechaHasta = dbtFechaFin.Value

        e.DoFill = False

        sWhere = " 1=1 "
        If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
            sWhere = String.Concat(sWhere, " and ftfactm.fact_date between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
        ElseIf Trim(sFechaDesde) <> "" Then
            sWhere = String.Concat(sWhere, " and ftfactm.fact_date = '", Trim(sFechaDesde), "'")
        ElseIf Trim(sFechaHasta) <> "" Then
            sWhere = String.Concat(sWhere, " and ftfactm.fact_date = '", Trim(sFechaHasta), "'")
        End If

        If vend_code.Text.Trim.Length > 0 Then
            sWhere = String.Concat(sWhere, " and ftfactm.vend_code = ", vend_code.Text)
        End If

        sWhere = String.Concat("fact_status = 3 and ftfactm.type_code = 'FCT' and ", sWhere)

        ''''sSql = String.Concat(" select ftfactm.fact_number,ftfactm.fact_date,ftfactm.fact_total,", _
        ''''                     "        ftcomid.amount,ftfactm.bus_name,ftfactm.vend_code,ftcomid.ftserial_no ", _
        ''''                     "  from ftfactm inner join ftcomid ", _
        ''''                     "       on ftfactm.ftserial_no = ftcomid.ftserial_no ", _
        ''''                     "  Where ftcomid.comm_serial is null and ", sWhere)

        sSql = String.Concat("SELECT ftfactm.fact_date,ftfactm.fact_number,ftfactm.vend_code,vend_name,", _
                                " porc_comision,(fact_total - descto) sales_total,((fact_total - descto) * porc_comision /100) comis_total ", _
                                " from  ftfactm inner join ftvendm ", _
                                " on ftfactm.vend_code = ftvendm.vend_code ", _
                                " where ftfactm.ftserial_no not in (select ftcomid.ftserial_no from ftcomid)", _
                                " and ", sWhere)

        Dim oTable As DataTable
        mTable = LibX.Data.Manager.GetDataTable(sSql)

        oTable = Me.DataView1.Table

        For Each oRow As DataRow In mTable.Rows
            oTable.ImportRow(oRow)
        Next

    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        btnMarkAll.Enabled = e.isEditing And LibXConnector1.HasRecords
        btnUnmarkall.Enabled = e.isEditing And LibXConnector1.HasRecords
        '       btnRefresh.Enabled = Not e.isEditing And LibXConnector1.HasRecords
    End Sub


    Private Sub p_ftfact01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ftfactd.Columns("ftserial_no").AutoIncrement = False
        'ftfactm.Columns("ftserial_no").AutoIncrement = False
        'btnRefresh_Click(sender, e)
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


    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Button8_Click(sender, e)
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Button9_Click(sender, e)
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        'ftfactd.Rows(LibXGrid1.CurrentRowIndex).BeginEdit()
        'ftfactd.Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1
        'ftfactd.Rows(LibXGrid1.CurrentRowIndex).EndEdit()
        Aplicar()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'ftfactd.Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1
        Anular()
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Button1_Click(Nothing, Nothing)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.PrintReport()
        Exit Sub


        Dim xParam As LibX.LibxPrgParams
        Try
            xParam = New LibX.LibxPrgParams
            xParam.AllowDelete = False
            xParam.AllowEdit = False
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

    '''Desmarcar o marcar todos los de abajo si se marca o desmarca un vendedor
    Private Sub XDataGridBoolColumn1_BoolValueChanged(ByVal sender As Object, ByVal e As LibX.BoolValueChangedEventArgs) Handles XDataGridBoolColumn1.BoolValueChanged
        If Not Me.LibXConnector1.IsEditing Then
            Exit Sub
        End If

        Dim oRv As DataRowView
        If e.BoolValue Then
            For Each oRv In Me.DataView2
                oRv!aplicar = 1
            Next
        Else
            For Each oRv In Me.DataView2
                oRv!aplicar = 0
            Next
        End If
    End Sub


    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        e.Handled = True
    End Sub


    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid1.CurrentRowChanged

        DataView2.RowFilter = String.Concat("vend_code = ", gColVend.GetValue)

    End Sub

    Private Sub gColAplicaDet_BoolValueChanged(ByVal sender As Object, ByVal e As LibX.BoolValueChangedEventArgs) Handles gColAplicaDet.BoolValueChanged

        If Not Me.LibXConnector1.IsEditing Then
            Exit Sub
        End If
        Dim oRv As DataRowView
        Dim vend As Integer
        vend = e.dataRow!vend_code
        If e.BoolValue Then
            For Each oRv In Me.DataView1
                If oRv!vend_code = vend Then
                    oRv!aplicar = 1
                End If
            Next
        End If
    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
            Me.PrintReport()
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub LibXGrid2_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles LibXGrid2.Navigate

    End Sub

    Private Sub LibXConnector1_ChangingState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangingState

    End Sub
End Class
