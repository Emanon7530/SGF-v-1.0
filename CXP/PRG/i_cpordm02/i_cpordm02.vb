Imports LibX
Imports SGT.Inventario.Entidades

Public Class i_cpordm02
    Inherits System.Windows.Forms.Form
    Dim oDoc As SGT.Inventario.Entidades.Documento
    Dim mUnid As String
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
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents lkItem_code As LibX.LibXLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents LibXGridDetalle As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents gColITem_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents gColitem_name As LibX.XEditTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents txtwhse_code As LibX.XTextBox
    Friend WithEvents txtwhse_name As LibX.XTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents xcbo_ordn_status As LibX.LibXCombo
    Friend WithEvents lkCliente As LibX.LibXLookup
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gColCosto As LibX.XEditTextBoxColumn
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gcolImporte As LibX.XEditTextBoxColumn
    Friend WithEvents gColQty As LibX.XEditTextBoxColumn
    Friend WithEvents xtxt_total_amt As LibX.XTextBox
    Friend WithEvents gColWhse_code As LibX.XEditTextBoxColumn
    Friend WithEvents gcolunit_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents xlk_unit_code As LibX.LibXLookup
    Friend WithEvents xtxt_dev_number As LibX.XTextBox
    Friend WithEvents xtxt_doc_desc As LibX.XTextBox
    Friend WithEvents gColExist As LibX.XEditTextBoxColumn
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents cpordnm As System.Data.DataTable
    Friend WithEvents cpordnd As System.Data.DataTable
    Friend WithEvents suplidor As LibX.XTextBox
    Friend WithEvents nsuplidor As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.cpordnm = New System.Data.DataTable
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.cpordnd = New System.Data.DataTable
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.xtxt_doc_desc = New LibX.XTextBox
        Me.xtxt_dev_number = New LibX.XTextBox
        Me.suplidor = New LibX.XTextBox
        Me.txtwhse_code = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lkItem_code = New LibX.LibXLookup
        Me.Label8 = New System.Windows.Forms.Label
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.LibXGridDetalle = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColITem_code = New LibX.XDataGridTextButtonColumn
        Me.gColWhse_code = New LibX.XEditTextBoxColumn
        Me.gColitem_name = New LibX.XEditTextBoxColumn
        Me.gColQty = New LibX.XEditTextBoxColumn
        Me.gcolunit_code = New LibX.XDataGridTextButtonColumn
        Me.xlk_unit_code = New LibX.LibXLookup
        Me.gColCosto = New LibX.XEditTextBoxColumn
        Me.gColExist = New LibX.XEditTextBoxColumn
        Me.gcolImporte = New LibX.XEditTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.txtwhse_name = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lkCliente = New LibX.LibXLookup
        Me.nsuplidor = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.xcbo_ordn_status = New LibX.LibXCombo
        Me.Label5 = New System.Windows.Forms.Label
        Me.xtxt_total_amt = New LibX.XTextBox
        Me.Label13 = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpordnm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpordnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_doc_desc
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_dev_number
        Me.LibXNavigator1.FirstControlInNewMode = Me.suplidor
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(762, 24)
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
        Me.LibXConnector1.DataMember = "cpordnm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = "CXP"
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = "r_cpordm03.rpt"
        Me.LibXConnector1.RequeryData = True
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.cpordnm, Me.cpordnd})
        '
        'cpordnm
        '
        Me.cpordnm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn2})
        Me.cpordnm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ordn_serial"}, True)})
        Me.cpordnm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn29}
        Me.cpordnm.TableName = "cpordnm"
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.AutoIncrement = True
        Me.DataColumn29.ColumnName = "ordn_serial"
        Me.DataColumn29.DataType = GetType(System.Int32)
        Me.DataColumn29.ReadOnly = True
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "type_code"
        Me.DataColumn30.MaxLength = 3
        '
        'DataColumn31
        '
        Me.DataColumn31.AllowDBNull = False
        Me.DataColumn31.ColumnName = "prov_code"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "ordn_date"
        Me.DataColumn32.DataType = GetType(System.DateTime)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "ordn_number"
        Me.DataColumn33.DataType = GetType(System.Int32)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "ordn_note"
        Me.DataColumn34.MaxLength = 60
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "ordn_status"
        Me.DataColumn35.DataType = GetType(System.Int32)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "total_amount"
        Me.DataColumn36.DataType = GetType(System.Decimal)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "whse_code"
        Me.DataColumn37.DataType = GetType(System.Int32)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "total_itbis"
        Me.DataColumn38.DataType = GetType(System.Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "maximo"
        Me.DataColumn39.DataType = GetType(System.Decimal)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "minimo"
        Me.DataColumn40.DataType = GetType(System.Decimal)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "reorden"
        Me.DataColumn41.DataType = GetType(System.Decimal)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "periodo"
        Me.DataColumn42.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "suc_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'cpordnd
        '
        Me.cpordnd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn1, Me.DataColumn3})
        Me.cpordnd.TableName = "cpordnd"
        '
        'DataColumn43
        '
        Me.DataColumn43.AllowDBNull = False
        Me.DataColumn43.ColumnName = "ordn_serial"
        Me.DataColumn43.DataType = GetType(System.Int32)
        '
        'DataColumn44
        '
        Me.DataColumn44.AllowDBNull = False
        Me.DataColumn44.ColumnName = "whse_code"
        Me.DataColumn44.DataType = GetType(System.Int32)
        '
        'DataColumn45
        '
        Me.DataColumn45.AllowDBNull = False
        Me.DataColumn45.ColumnName = "item_code"
        Me.DataColumn45.MaxLength = 10
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "ref_code"
        Me.DataColumn46.DataType = GetType(System.Int32)
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "Qty"
        Me.DataColumn47.DataType = GetType(System.Int32)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "costo"
        Me.DataColumn48.DataType = GetType(System.Decimal)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "itbis"
        Me.DataColumn49.DataType = GetType(System.Decimal)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "promedio"
        Me.DataColumn50.DataType = GetType(System.Decimal)
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "sugerida"
        Me.DataColumn51.DataType = GetType(System.Decimal)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "diasventa"
        Me.DataColumn52.DataType = GetType(System.Int32)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "reorden"
        Me.DataColumn53.DataType = GetType(System.Decimal)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "unit_code"
        Me.DataColumn54.MaxLength = 4
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "existencia"
        Me.DataColumn55.DataType = GetType(System.Decimal)
        '
        'DataColumn56
        '
        Me.DataColumn56.AllowDBNull = False
        Me.DataColumn56.ColumnName = "item_name"
        Me.DataColumn56.MaxLength = 100
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "Importe"
        Me.DataColumn1.ColumnName = "Importe"
        Me.DataColumn1.DataType = GetType(System.Decimal)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "suc_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.SerialColumnName = "ordn_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cpordnm"
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
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"ordn_serial=ordn_serial", "whse_code=whse_code"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select cpordnd.*,ivitemm.item_name ", "from cpordnd inner join ivitemm", "on cpordnd.item_code = ivitemm.item_code order by promedio desc"}
        Me.LibXDbSourceTable2.TableName = "cpordnd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'xtxt_doc_desc
        '
        Me.xtxt_doc_desc.AcceptsReturn = True
        Me.xtxt_doc_desc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_doc_desc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpordnm.ordn_note"))
        Me.xtxt_doc_desc.EditInitialValue = Nothing
        Me.xtxt_doc_desc.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_doc_desc.FieldDescription = ""
        Me.xtxt_doc_desc.FindInitialValue = Nothing
        Me.xtxt_doc_desc.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_doc_desc.IgnoreRequiered = False
        Me.xtxt_doc_desc.Location = New System.Drawing.Point(96, 88)
        Me.xtxt_doc_desc.Multiline = True
        Me.xtxt_doc_desc.Name = "xtxt_doc_desc"
        Me.xtxt_doc_desc.NewInitialValue = Nothing
        Me.xtxt_doc_desc.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_doc_desc.Requiered = False
        Me.xtxt_doc_desc.Size = New System.Drawing.Size(640, 48)
        Me.xtxt_doc_desc.StatusBarPanelDescripcion = Nothing
        Me.xtxt_doc_desc.TabIndex = 3
        Me.xtxt_doc_desc.Text = ""
        '
        'xtxt_dev_number
        '
        Me.xtxt_dev_number.AcceptsReturn = True
        Me.xtxt_dev_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpordnm.ordn_number"))
        Me.xtxt_dev_number.EditInitialValue = Nothing
        Me.xtxt_dev_number.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_dev_number.FieldDescription = ""
        Me.xtxt_dev_number.FindInitialValue = Nothing
        Me.xtxt_dev_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_dev_number.IgnoreRequiered = True
        Me.xtxt_dev_number.Location = New System.Drawing.Point(96, 16)
        Me.xtxt_dev_number.Name = "xtxt_dev_number"
        Me.xtxt_dev_number.NewInitialValue = Nothing
        Me.xtxt_dev_number.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_dev_number.Requiered = False
        Me.xtxt_dev_number.Size = New System.Drawing.Size(96, 20)
        Me.xtxt_dev_number.StatusBarPanelDescripcion = Nothing
        Me.xtxt_dev_number.TabIndex = 0
        Me.xtxt_dev_number.Text = ""
        '
        'suplidor
        '
        Me.suplidor.AcceptsReturn = True
        Me.suplidor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpordnm.prov_code"))
        Me.suplidor.EditInitialValue = Nothing
        Me.suplidor.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.suplidor.FieldDescription = ""
        Me.suplidor.FindInitialValue = Nothing
        Me.suplidor.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.suplidor.IgnoreRequiered = True
        Me.suplidor.Location = New System.Drawing.Point(96, 40)
        Me.suplidor.Name = "suplidor"
        Me.suplidor.NewInitialValue = Nothing
        Me.suplidor.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.suplidor.Requiered = False
        Me.suplidor.Size = New System.Drawing.Size(96, 20)
        Me.suplidor.StatusBarPanelDescripcion = Nothing
        Me.suplidor.TabIndex = 1
        Me.suplidor.Text = ""
        '
        'txtwhse_code
        '
        Me.txtwhse_code.AcceptsReturn = True
        Me.txtwhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpordnm.whse_code"))
        Me.txtwhse_code.EditInitialValue = Nothing
        Me.txtwhse_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.FieldDescription = ""
        Me.txtwhse_code.FindInitialValue = Nothing
        Me.txtwhse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.IgnoreRequiered = False
        Me.txtwhse_code.Location = New System.Drawing.Point(96, 64)
        Me.txtwhse_code.Name = "txtwhse_code"
        Me.txtwhse_code.NewInitialValue = Nothing
        Me.txtwhse_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.Requiered = False
        Me.txtwhse_code.Size = New System.Drawing.Size(48, 20)
        Me.txtwhse_code.StatusBarPanelDescripcion = Nothing
        Me.txtwhse_code.TabIndex = 2
        Me.txtwhse_code.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(16, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(35, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Número:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lkItem_code
        '
        Me.lkItem_code.AlternateFieldSearch = Nothing
        Me.lkItem_code.BeginCheck = False
        Me.lkItem_code.CheckText = Nothing
        Me.lkItem_code.ComboMode = False
        Me.lkItem_code.DataMember = "cpordnd"
        Me.lkItem_code.DataSource = Me.LibXConnector1
        Me.lkItem_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "costo=purch_cost", "price=price", "unit_code=unit_code", "benef=benef", "whse_code=whse_code"}
        Me.lkItem_code.FilterField = "item_name"
        Me.lkItem_code.IgnoreFindInBrowseMode = True
        Me.lkItem_code.isCanceled = False
        Me.lkItem_code.Location = New System.Drawing.Point(608, 80)
        Me.lkItem_code.LookCaption = Nothing
        Me.lkItem_code.Name = "lkItem_code"
        Me.lkItem_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkItem_code.ShowFilter = True
        Me.lkItem_code.ShowMessageNotFound = True
        Me.lkItem_code.ShowWarning = False
        Me.lkItem_code.Size = New System.Drawing.Size(16, 20)
        Me.lkItem_code.SizesColumns = New String() {"item_name=450"}
        Me.lkItem_code.SizesColumnsTab = Nothing
        Me.lkItem_code.SqlString = New String() {"select DISTINCT  ivitemv1.item_code", ",ivitemv1.item_name", ",ivitemv1.whse_code", ",ivitemv1.unit_code", ",purch_cost", ",price ", ",ivitemv1.existencia", ",ivitemv1.benef ", "from ivitemv1 ", "left outer join ivunitd", "on ivunitd.unit_code = ivitemv1.unit_code", "and ivunitd.item_code = ivitemv1.item_code", " LEFT OUTER JOIN ivcbarram", " ON ivcbarram.item_code = ivitemv1.item_code", "LEFT OUTER JOIN ivreferm", " ON ivreferm.item_code = ivitemv1.item_code", "order by ivitemv1.item_name"}
        Me.lkItem_code.SQLTab = Nothing
        Me.lkItem_code.SrcParameters = New String() {"item_code=item_code"}
        Me.lkItem_code.TabIndex = 6
        Me.lkItem_code.TableName = "ivitemv1"
        Me.lkItem_code.TabStop = False
        Me.lkItem_code.UseCopyConnection = False
        Me.lkItem_code.UseRowRetrieveEvents = False
        Me.lkItem_code.UseTab = False
        Me.lkItem_code.VisParameters = New String() {"Descripción=item_name", "Costo=purch_cost", "Unidad=unit_code", "Precio=price", "Existecia=existencia", "Beneficio=benef", "Código=item_code"}
        Me.lkItem_code.WhereCondition = "item_status =1"
        Me.lkItem_code.WhereParameters = Nothing
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(565, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Fecha:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cpordnm.ordn_date"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.FieldDescription = ""
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = True
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(616, 16)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = "now"
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Requiered = False
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(120, 20)
        Me.LibxDateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker1.TabIndex = 4
        '
        'LibXGridDetalle
        '
        Me.LibXGridDetalle.AllowSorting = False
        Me.LibXGridDetalle.AutoAdjustLastColumn = True
        Me.LibXGridDetalle.AutoSearch = False
        Me.LibXGridDetalle.BackgroundColor = System.Drawing.Color.White
        Me.LibXGridDetalle.CaptionText = "Articulos"
        Me.LibXGridDetalle.DataMember = "cpordnd"
        Me.LibXGridDetalle.DataSource = Me.DataSet1
        Me.LibXGridDetalle.FullRowSelect = False
        Me.LibXGridDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGridDetalle.IsReadOnly = False
        Me.LibXGridDetalle.Location = New System.Drawing.Point(8, 192)
        Me.LibXGridDetalle.Name = "LibXGridDetalle"
        Me.LibXGridDetalle.ReadOnly = True
        Me.LibXGridDetalle.RowHeaderWidth = 15
        Me.LibXGridDetalle.searchText = ""
        Me.LibXGridDetalle.showFooterBar = True
        Me.LibXGridDetalle.Size = New System.Drawing.Size(744, 312)
        Me.LibXGridDetalle.TabIndex = 6
        Me.LibXGridDetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGridDetalle.UseAutoFillLines = True
        Me.LibXGridDetalle.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGridDetalle
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColITem_code, Me.gColWhse_code, Me.gColitem_name, Me.gColQty, Me.gcolunit_code, Me.gColCosto, Me.gColExist, Me.gcolImporte})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cpordnd"
        Me.XdataGridTableStyle1.RowHeaderWidth = 15
        '
        'gColITem_code
        '
        Me.gColITem_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColITem_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColITem_code.executeFindDuringFill = False
        Me.gColITem_code.Format = ""
        Me.gColITem_code.FormatInfo = Nothing
        Me.gColITem_code.HeaderText = "Producto"
        Me.gColITem_code.isReadOnly = False
        Me.gColITem_code.Lookup = Me.lkItem_code
        Me.gColITem_code.MappingName = "item_code"
        Me.gColITem_code.MaxLength = 32767
        Me.gColITem_code.TabStop = True
        Me.gColITem_code.UseCustomCellFormat = False
        Me.gColITem_code.Width = 125
        '
        'gColWhse_code
        '
        Me.gColWhse_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColWhse_code.Format = ""
        Me.gColWhse_code.FormatInfo = Nothing
        Me.gColWhse_code.HeaderText = "Alm."
        Me.gColWhse_code.ImageList = Nothing
        Me.gColWhse_code.isReadOnly = False
        Me.gColWhse_code.MappingName = "whse_code"
        Me.gColWhse_code.MaxLength = 32767
        Me.gColWhse_code.TabStop = True
        Me.gColWhse_code.UseCustomCellFormat = False
        Me.gColWhse_code.Width = 0
        '
        'gColitem_name
        '
        Me.gColitem_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.gColitem_name.Format = ""
        Me.gColitem_name.FormatInfo = Nothing
        Me.gColitem_name.HeaderText = "Descripción"
        Me.gColitem_name.ImageList = Nothing
        Me.gColitem_name.isReadOnly = False
        Me.gColitem_name.MappingName = "item_name"
        Me.gColitem_name.MaxLength = 32767
        Me.gColitem_name.ReadOnly = True
        Me.gColitem_name.TabStop = True
        Me.gColitem_name.UseCustomCellFormat = False
        Me.gColitem_name.Width = 225
        '
        'gColQty
        '
        Me.gColQty.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColQty.Format = "###,###,##0"
        Me.gColQty.FormatInfo = Nothing
        Me.gColQty.HeaderText = "Cantidadi"
        Me.gColQty.ImageList = Nothing
        Me.gColQty.isReadOnly = False
        Me.gColQty.MappingName = "qty"
        Me.gColQty.MaxLength = 32767
        Me.gColQty.TabStop = True
        Me.gColQty.UseCustomCellFormat = False
        Me.gColQty.Width = 55
        '
        'gcolunit_code
        '
        Me.gcolunit_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gcolunit_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolunit_code.executeFindDuringFill = False
        Me.gcolunit_code.Format = ""
        Me.gcolunit_code.FormatInfo = Nothing
        Me.gcolunit_code.HeaderText = "Unidad"
        Me.gcolunit_code.isReadOnly = False
        Me.gcolunit_code.Lookup = Me.xlk_unit_code
        Me.gcolunit_code.MappingName = "unit_code"
        Me.gcolunit_code.MaxLength = 32767
        Me.gcolunit_code.TabStop = True
        Me.gcolunit_code.UseCustomCellFormat = False
        Me.gcolunit_code.Width = 85
        '
        'xlk_unit_code
        '
        Me.xlk_unit_code.AlternateFieldSearch = Nothing
        Me.xlk_unit_code.BeginCheck = False
        Me.xlk_unit_code.CheckText = Nothing
        Me.xlk_unit_code.ComboMode = False
        Me.xlk_unit_code.DataMember = Nothing
        Me.xlk_unit_code.DataSource = Me.LibXConnector1
        Me.xlk_unit_code.DestParameters = New String() {"unit_code=unit_code"}
        Me.xlk_unit_code.FilterField = "unit_name"
        Me.xlk_unit_code.IgnoreFindInBrowseMode = True
        Me.xlk_unit_code.isCanceled = False
        Me.xlk_unit_code.Location = New System.Drawing.Point(464, 120)
        Me.xlk_unit_code.LookCaption = Nothing
        Me.xlk_unit_code.Name = "xlk_unit_code"
        Me.xlk_unit_code.PopupSize = New System.Drawing.Size(400, 300)
        Me.xlk_unit_code.ShowFilter = True
        Me.xlk_unit_code.ShowMessageNotFound = True
        Me.xlk_unit_code.ShowWarning = False
        Me.xlk_unit_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_unit_code.SizesColumns = New String() {"unit_name=200"}
        Me.xlk_unit_code.SizesColumnsTab = Nothing
        Me.xlk_unit_code.SqlString = Nothing
        Me.xlk_unit_code.SQLTab = Nothing
        Me.xlk_unit_code.SrcParameters = New String() {"unit_code=unit_code"}
        Me.xlk_unit_code.TabIndex = 31
        Me.xlk_unit_code.TableName = "ivunitv"
        Me.xlk_unit_code.TabStop = False
        Me.xlk_unit_code.UseCopyConnection = False
        Me.xlk_unit_code.UseRowRetrieveEvents = False
        Me.xlk_unit_code.UseTab = False
        Me.xlk_unit_code.VisParameters = New String() {"Unidad=unit_code", "Descripcion=unit_name", "Factor=factor"}
        Me.xlk_unit_code.WhereCondition = Nothing
        Me.xlk_unit_code.WhereParameters = Nothing
        '
        'gColCosto
        '
        Me.gColCosto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColCosto.Format = "#,###,##0.00"
        Me.gColCosto.FormatInfo = Nothing
        Me.gColCosto.HeaderText = "Costo RDi"
        Me.gColCosto.ImageList = Nothing
        Me.gColCosto.isReadOnly = False
        Me.gColCosto.MappingName = "costo"
        Me.gColCosto.MaxLength = 32767
        Me.gColCosto.TabStop = True
        Me.gColCosto.UseCustomCellFormat = False
        Me.gColCosto.Width = 75
        '
        'gColExist
        '
        Me.gColExist.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColExist.Format = "#,###,##0"
        Me.gColExist.FormatInfo = Nothing
        Me.gColExist.HeaderText = "Existencia"
        Me.gColExist.ImageList = Nothing
        Me.gColExist.isReadOnly = True
        Me.gColExist.MappingName = "bf_onhand"
        Me.gColExist.MaxLength = 32767
        Me.gColExist.ReadOnly = True
        Me.gColExist.TabStop = False
        Me.gColExist.UseCustomCellFormat = False
        Me.gColExist.Width = 75
        '
        'gcolImporte
        '
        Me.gcolImporte.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gcolImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolImporte.Format = "###,##0.00"
        Me.gcolImporte.FormatInfo = Nothing
        Me.gcolImporte.HeaderText = "Importei"
        Me.gcolImporte.ImageList = Nothing
        Me.gcolImporte.isReadOnly = False
        Me.gcolImporte.MappingName = "Importe"
        Me.gcolImporte.MaxLength = 32767
        Me.gcolImporte.ReadOnly = True
        Me.gcolImporte.TabStop = True
        Me.gcolImporte.UseCustomCellFormat = False
        Me.gcolImporte.Width = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(32, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Almacén:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXLookup3
        '
        Me.LibXLookup3.AlternateFieldSearch = Nothing
        Me.LibXLookup3.BeginCheck = False
        Me.LibXLookup3.CheckText = Nothing
        Me.LibXLookup3.ComboMode = False
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Me.LibXConnector1
        Me.LibXLookup3.DestParameters = New String() {"txtwhse_code=whse_code", "txtwhse_name=whse_name"}
        Me.LibXLookup3.FilterField = Nothing
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.isCanceled = False
        Me.LibXLookup3.Location = New System.Drawing.Point(432, 64)
        Me.LibXLookup3.LookCaption = "Almacenes"
        Me.LibXLookup3.Name = "LibXLookup3"
        Me.LibXLookup3.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup3.ShowFilter = True
        Me.LibXLookup3.ShowMessageNotFound = True
        Me.LibXLookup3.ShowWarning = False
        Me.LibXLookup3.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup3.SizesColumns = Nothing
        Me.LibXLookup3.SizesColumnsTab = Nothing
        Me.LibXLookup3.SqlString = Nothing
        Me.LibXLookup3.SQLTab = Nothing
        Me.LibXLookup3.SrcParameters = New String() {"whse_code=whse_code"}
        Me.LibXLookup3.TabIndex = 2
        Me.LibXLookup3.TableName = "ivwhsem"
        Me.LibXLookup3.TabStop = False
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.UseTab = False
        Me.LibXLookup3.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.LibXLookup3.WhereCondition = Nothing
        Me.LibXLookup3.WhereParameters = Nothing
        '
        'txtwhse_name
        '
        Me.txtwhse_name.AcceptsReturn = True
        Me.txtwhse_name.EditInitialValue = Nothing
        Me.txtwhse_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_name.FieldDescription = ""
        Me.txtwhse_name.FindInitialValue = Nothing
        Me.txtwhse_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_name.IgnoreRequiered = False
        Me.txtwhse_name.Location = New System.Drawing.Point(152, 64)
        Me.txtwhse_name.Name = "txtwhse_name"
        Me.txtwhse_name.NewInitialValue = Nothing
        Me.txtwhse_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_name.ReadOnly = True
        Me.txtwhse_name.Requiered = False
        Me.txtwhse_name.Size = New System.Drawing.Size(280, 20)
        Me.txtwhse_name.StatusBarPanelDescripcion = Nothing
        Me.txtwhse_name.TabIndex = 27
        Me.txtwhse_name.TabStop = False
        Me.txtwhse_name.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xlk_unit_code)
        Me.GroupBox1.Controls.Add(Me.suplidor)
        Me.GroupBox1.Controls.Add(Me.lkCliente)
        Me.GroupBox1.Controls.Add(Me.nsuplidor)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.xcbo_ordn_status)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xtxt_dev_number)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xtxt_doc_desc)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.LibXLookup3)
        Me.GroupBox1.Controls.Add(Me.txtwhse_code)
        Me.GroupBox1.Controls.Add(Me.txtwhse_name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xtxt_total_amt)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 152)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lkCliente
        '
        Me.lkCliente.AlternateFieldSearch = Nothing
        Me.lkCliente.BeginCheck = False
        Me.lkCliente.CheckText = Nothing
        Me.lkCliente.ComboMode = False
        Me.lkCliente.DataMember = Nothing
        Me.lkCliente.DataSource = Me.LibXConnector1
        Me.lkCliente.DestParameters = New String() {"prov_code=prov_code", "nsuplidor=prov_name"}
        Me.lkCliente.FilterField = "prov_name"
        Me.lkCliente.IgnoreFindInBrowseMode = False
        Me.lkCliente.isCanceled = False
        Me.lkCliente.Location = New System.Drawing.Point(432, 40)
        Me.lkCliente.LookCaption = "Suplidores"
        Me.lkCliente.Name = "lkCliente"
        Me.lkCliente.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkCliente.ShowFilter = True
        Me.lkCliente.ShowMessageNotFound = True
        Me.lkCliente.ShowWarning = False
        Me.lkCliente.Size = New System.Drawing.Size(16, 20)
        Me.lkCliente.SizesColumns = Nothing
        Me.lkCliente.SizesColumnsTab = Nothing
        Me.lkCliente.SqlString = New String() {"select prov_code,prov_name,cctermm.term_code,due_days,disc_days,disc_pct", "from cpprovm inner join cctermm on cpprovm.term_code = cctermm.term_code"}
        Me.lkCliente.SQLTab = Nothing
        Me.lkCliente.SrcParameters = New String() {"prov_code=prov_code"}
        Me.lkCliente.TabIndex = 30
        Me.lkCliente.TableName = "cpprovm"
        Me.lkCliente.TabStop = False
        Me.lkCliente.UseCopyConnection = False
        Me.lkCliente.UseRowRetrieveEvents = False
        Me.lkCliente.UseTab = False
        Me.lkCliente.VisParameters = New String() {"Código=prov_code", "Nombre=prov_name"}
        Me.lkCliente.WhereCondition = ""
        Me.lkCliente.WhereParameters = Nothing
        '
        'nsuplidor
        '
        Me.nsuplidor.Location = New System.Drawing.Point(200, 40)
        Me.nsuplidor.Name = "nsuplidor"
        Me.nsuplidor.ReadOnly = True
        Me.nsuplidor.Size = New System.Drawing.Size(232, 20)
        Me.nsuplidor.TabIndex = 29
        Me.nsuplidor.TabStop = False
        Me.nsuplidor.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(35, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 16)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Suplidor:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_ordn_status
        '
        Me.xcbo_ordn_status.AllowDefaultSort = True
        Me.xcbo_ordn_status.bound = True
        Me.xcbo_ordn_status.currValue = Nothing
        Me.xcbo_ordn_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cpordnm.ordn_status"))
        Me.xcbo_ordn_status.DefaultWhereString = Nothing
        Me.xcbo_ordn_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_ordn_status.EditInitialValue = Nothing
        Me.xcbo_ordn_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_ordn_status.FieldDescription = ""
        Me.xcbo_ordn_status.FindInitialValue = "2"
        Me.xcbo_ordn_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_ordn_status.IgnoreRequiered = False
        Me.xcbo_ordn_status.Items.AddRange(New Object() {"0 - Anulado", "1 - Aplicado", "2 - Pendiente de Aplicar"})
        Me.xcbo_ordn_status.Location = New System.Drawing.Point(616, 40)
        Me.xcbo_ordn_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_ordn_status.LookupKeyField = Nothing
        Me.xcbo_ordn_status.LookupTableName = Nothing
        Me.xcbo_ordn_status.Name = "xcbo_ordn_status"
        Me.xcbo_ordn_status.NewInitialValue = "2"
        Me.xcbo_ordn_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_ordn_status.Requiered = False
        Me.xcbo_ordn_status.Required = False
        Me.xcbo_ordn_status.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_ordn_status.SqlString = Nothing
        Me.xcbo_ordn_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_ordn_status.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(559, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Estatus:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_total_amt
        '
        Me.xtxt_total_amt.AcceptsReturn = True
        Me.xtxt_total_amt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpordnm.total_amount"))
        Me.xtxt_total_amt.EditInitialValue = Nothing
        Me.xtxt_total_amt.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_total_amt.FieldDescription = ""
        Me.xtxt_total_amt.FindInitialValue = Nothing
        Me.xtxt_total_amt.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_total_amt.IgnoreRequiered = True
        Me.xtxt_total_amt.Location = New System.Drawing.Point(616, 64)
        Me.xtxt_total_amt.Name = "xtxt_total_amt"
        Me.xtxt_total_amt.NewInitialValue = Nothing
        Me.xtxt_total_amt.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_total_amt.ReadOnly = True
        Me.xtxt_total_amt.Requiered = False
        Me.xtxt_total_amt.Size = New System.Drawing.Size(120, 20)
        Me.xtxt_total_amt.StatusBarPanelDescripcion = Nothing
        Me.xtxt_total_amt.TabIndex = 1
        Me.xtxt_total_amt.TabStop = False
        Me.xtxt_total_amt.Text = ""
        Me.xtxt_total_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(571, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 16)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Total:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'i_cpordm02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(762, 560)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXGridDetalle)
        Me.Controls.Add(Me.lkItem_code)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_cpordm02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Orden de Compra Manual"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpordnm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpordnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try

            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                e.UpdatingArgs.Row!type_code = "ORD"
                e.UpdatingArgs.Row!ordn_status = 2 'pendiente de aplicar
                If Me.txtwhse_code.Text = "" Then
                    Throw New Exception("Debe indicar el almacen")
                End If

                ''e.UpdatingArgs.Row!date_created = LibX.Data.Manager.Connection.GetDate

                If IsNull(e.UpdatingArgs.Row!ordn_date) Then
                    e.UpdatingArgs.Row!ordn_date = LibX.Data.Manager.Connection.GetDate
                End If

                '--?
                Dim intLast As Integer

                Dim doc As New SGT.Inventario.Entidades.Documento("ORD")
                e.UpdatingArgs.Row!ordn_number = doc.GenerateNumber("ORD")
            End If

        Catch ex As Exception
            Log.Add(ex)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
        End Try
    End Sub

    Private Sub lkItem_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lkItem_code.BeforeExecuteQuery
        Try
            If Trim(Me.txtwhse_code.Text) <> "" Then
                e.aditionalWhere = String.Concat(" ivitemv1.whse_code ='", Trim(Me.txtwhse_code.Text), "'")
                'End If
                If LibXConnector1.IsDataEditing = True Then
                    If Len(LibXGridDetalle.GetValue(gColITem_code).Trim) > 8 And IsNumeric(LibXGridDetalle.GetValue(gColITem_code).Trim) Then
                        e.SQL = e.SQL.Replace("ivitemv1.item_code =", "ivcbarram.barra =")
                    End If
                End If
                e.SQL = e.SQL
            End If

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_RowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange
        ''''Try
        ''''    If e.row Is Nothing Then
        ''''        Exit Sub
        ''''    End If
        ''''    If Not IsNull(e.row!ordn_status) Then
        ''''        Me.LibXConnector1.AllowEdit = True
        ''''        Me.LibXConnector1.AllowDelete = True

        ''''        If Trim(e.row!ordn_status) = "1" Then
        ''''            Me.LibXConnector1.AllowDelete = False
        ''''            Me.LibXConnector1.AllowEdit = False
        ''''        End If
        ''''        Me.LibXNavigator1.UpdateState()
        ''''    End If

        ''''Catch ex As Exception
        ''''    Log.Show(ex)
        ''''End Try
        'If e.state = LibxConnectorState.View Then
        ''Calcular()
        'End If

    End Sub

    Private Sub LibXConnector1_InsertedRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then

            End If

        Catch ex As Exception
            Log.Show(ex)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try
            LibxDateTimePicker1.Value = LibX.Data.Manager.Connection.GetDate.ToString("d")
            xcbo_ordn_status.currValue = 2
            Me.txtwhse_code.Text = WhDefault
            Me.LibXLookup3.ExecuteFind()
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXGridDetalle_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGridDetalle.CellValidate
        Try
            '// Validar la cantidad
            If Me.gColQty.Column = e.cell Then
                If IsNull(Me.gColITem_code.GetValue) Then
                    Exit Sub
                End If

                If IsNull(e.value) Then
                    e.hasErrors = True
                    Exit Sub
                End If

                If e.value <= 0 Then
                    Throw New Exception("La cantidad debe ser mayor que 0")
                End If

                '''Dim Existe As Decimal = 0
                '''If Trim(Me.gColExist.GetValue) <> "" Then
                '''    If ValidarCantidad() = False Then
                '''        Throw New Exception("La cantidad no puede ser mayor que la existencia")
                '''    End If
                '''    Existe = Me.gColExist.GetValue
                '''End If

                '''If e.value > Existe Then
                '''    Throw New Exception("La cantidad no puede ser mayor que la existencia")
                '''End If

                Dim valor As Integer = 0
                Dim Qty As Integer = e.value

                '''If Trim(Me.LibXGridDetalle.GetValue(Me.gcolPrice)) <> "" Then
                '''    valor = Me.LibXGridDetalle.GetValue(gcolPrice)
                '''End If

                'LibXGridDetalle.SetValue(gcolImporte, valor * Qty)
                'Calcular()
            End If

            '''If Me.gcolPrice.Column = e.cell Then

            '''    Dim valor As Integer = 0
            '''    Dim Qty As Integer = e.value

            '''    If Trim(Me.LibXGridDetalle.GetValue(Me.gcolPrice)) <> "" Then
            '''        valor = Me.LibXGridDetalle.GetValue(gcolPrice)
            '''    End If

            '''    'LibXGridDetalle.SetValue(gcolImporte, valor * Qty)
            '''    'Calcular()
            '''End If

            If Me.gColITem_code.Column = e.cell Then
                If IsNull(e.value) Then
                    e.hasErrors = True
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            e.hasErrors = True
            Log.Add(ex)
        Finally
            CalcularITBIS()
            ActualizaTotal()
        End Try
    End Sub

    Private Sub Calcular()
        Dim Total As Decimal = 0
        Try

            Total = cpordnd.Compute("sum(Importe)", "")

            xtxt_total_amt.Text = Format(Total, "#,###,##0.00")
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        'Dim SelecStmt As String
        Try
            '    If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
            '        Dim AxCrystalReport1 As New LibX.ReportLib

            '        With AxCrystalReport1
            '            .ReportFileName = MdlUtil.GetReportPath("INV", "r_ivsalid01.rpt")
            '            .Connect = Configuration.ConfigurationSettings.AppSettings.Get("LibXConnectReport")

            '            For i As Int16 = 0 To .GetNSubreports - 1
            '                .SubreportToChange = .GetNthSubreportName(i)
            '                .Connect = Configuration.ConfigurationSettings.AppSettings.Get("LibXConnectReport")
            '            Next

            '            .SubreportToChange = ""

            '            .RetrieveSQLQuery()
            '            SelecStmt = .SQLQuery
            '            SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, "ivdocsm.doc_serial = " & LibXConnector1.CurrentDataRow!doc_serial)
            '            .SQLQuery = SelecStmt

            '            .WindowState = ReportLib.WindowsStates.Maximixed
            '            .Action = 1
            '        End With
            '    End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try

            '''btnProduct.Enabled = e.isDataEditing And LibXConnector1.HasRecords
            '''btnCostos.Enabled = e.isDataEditing And LibXConnector1.HasRecords
            '''Me.ButtonVencimiento.Enabled = Not e.isDataEditing And LibXConnector1.HasRecords
            '''Me.btnDisk.Enabled = Not e.isDataEditing And LibXConnector1.HasRecords

            If e.action = LibxConnectionActions.Edit Then
                If Val(LibXConnector1.CurrentDataRow!ordn_status.ToString.Trim) <> 2 Then
                    LibXConnector1.ShowWarningCancel = False
                    LibXConnector1.Cancel()
                    LibXConnector1.ShowWarningCancel = True
                    Throw New ApplicationException("Este documento no puede ser modificado")
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub lkItem_code_CreatedGridColumns(ByVal sender As Object, ByVal e As LibX.CreatedGridColumnsEventArgs) Handles lkItem_code.CreatedGridColumns
        Try

            e.Grid.Parent.Width = e.Grid.Parent.Width + 300
            e.TStyle.GridColumnStyles.Item("item_name").Width = 500

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub LibXGridDetalle_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LibXGridDetalle.CurrentCellChanged
        Try
            If LibXConnector1.IsEditing = True Then
                '// Validar que no salga de la celda de producto sin código
                If LibXGridDetalle.CurrentCell.ColumnNumber = _
                LibXGridDetalle.TableStyles(0).GridColumnStyles.IndexOf(gColitem_name) Then
                    If LibXGridDetalle.GetValue(gColITem_code).ToString.Length <= 0 Then
                        lkItem_code.ExecuteLookupGrid()
                    End If
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub


    Private Sub lkItem_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkItem_code.AfterSetValues
        Dim Vence As String

        Try
            If Not e.dataFound Then
                Exit Sub
            End If

            If Me.LibXConnector1.IsDataEditing = True Then
                'Me.LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.gcolunit_code, e.row!unit_code)
                Me.LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.gcolunit_code, e.row!unit_code)
                ''Me.LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.gcolPrice, e.row!price)
                Me.LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.gColCosto, e.row!purch_cost)
                '''Vence = GetVencimiento(e.row!item_code.ToString.Trim)
                '''lblVencimiento.Text = Vence
                '''Me.LibXGridDetalle.SetValue(Me.gColVencimiento, Vence)
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertedDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedDetailRow
        Try
            If e.UpdatingArgs.Row.RowState = DataRowState.Deleted Then
                Exit Sub
            End If

            If IsNull(e.UpdatingArgs.Row!item_code) Then
                Throw New XException("Se ha dejado un código de producto en blanco")
            End If

            e.UpdatingArgs.Row!whse_code = Val(txtwhse_code.Text)
        Catch ex As Exception
            Log.Add(ex)
        End Try
    End Sub

    Private Sub i_ivsalid01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DataSet1.Tables("cpordnd").Columns("Importe").Expression = "isnull(qty,0)*isnull(costo,0)"
            LibXGridDetalle.footerOperations.add("importe", "sum(importe)")
            LibXGridDetalle.footerOperations.add("itbis", "sum(itbis)")
            WhDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibXWhDefault").ToString)

            '//cpordnd.Columns("importe").Expression = "isnull(qty,0)*isnull(costo,0)"
        Catch ex As Exception
            Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            e.AditionalWhere = "type_code='ORD'"
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        ''Dim itemCode As String = ""

        Try

            For Each oRow As DataRow In cpordnd.Rows
                '''If itemCode.Trim = oRow!item_code.ToString.Trim Then
                '''    Throw New ApplicationException("Tiene productos repetidos en este documento, verifique!")
                '''End If

                '    ''If LibX.IsNull(oRow!item_code) = True Then
                '    ''    oRow.AcceptChanges()
                '    ''End If

                '    ''itemCode = oRow!item_code.ToString.Trim
            Next

        Catch ex As Exception
            e.Handled = True
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If LibXConnector1.IsEditing = False AndAlso LibXConnector1.HasRecords = True Then
                '//                Calcular()

                ActualizaTotal()
                If Not e.row Is Nothing Then
                    If e.row!ordn_status <> 2 Then '// Pendiente de Aplicar
                        LibXConnector1.AllowDelete = False
                        LibXConnector1.AllowEdit = False
                    Else
                        LibXConnector1.AllowDelete = True
                        LibXConnector1.AllowEdit = True
                    End If
                    LibXNavigator1.UpdateState()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXGridDetalle_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGridDetalle.CurrentRowChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                LibXGridDetalle.refreshFooter()
                '// Calcular()
                ActualizaTotal()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub xlk_unit_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_unit_code.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If


        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xlk_unit_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_unit_code.BeforeExecuteQuery
        Try
            '// si se esta agregando o editando leer por el codigo de barra

            If LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColITem_code).Trim <> "" Then
                e.aditionalWhere = "item_code = '" & LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColITem_code).Trim & "'"
            Else
                e.aditionalWhere = "1=1"
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xlk_unit_code_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_unit_code.BeforeSetValues
        Dim Costo As Decimal
        Dim Factor As Decimal
        Dim Cantidad As Integer
        Dim Existencia As Decimal
        Dim oUnidad As UnidadMedida
        Dim oParam As UnidadMedida.ParametroConvertirValor
        Dim Unidad As String

        If e.dataFound = False Then
            Exit Sub
        End If

        Try
            If LibXConnector1.IsDataEditing = True Then
                oUnidad = New UnidadMedida
                oParam = New UnidadMedida.ParametroConvertirValor

                oParam.Valor = LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColCosto)
                oParam.Producto = LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColITem_code)
                oParam.UnidadDestino = e.row!unit_code
                oParam.UnidadOrigen = mUnid

                oUnidad.ConvertirValor(oParam)

                Factor = oParam.Retorno.Factor
                Cantidad = Val(LibXGridDetalle.GetValue(LibXGridDetalle.currentRowNum, gColQty).ToString.Trim)
                Existencia = Val(LibXGridDetalle.GetValue(LibXGridDetalle.currentRowNum, gColExist).ToString.Trim)

                If Factor > 1 Then
                    Existencia = Existencia / Factor
                Else
                    Existencia = Existencia * Factor
                End If

                If Existencia < Cantidad Then
                    Throw New Exception("La cantidad no puede ser mayor que la existencia")
                End If
                LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, gColCosto, oParam.Retorno.Valor)
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub
    Private Function ValidarCantidad() As Boolean
        If LibXGridDetalle.getCurrentGridView.Count <= 0 Then
            Return True
        End If

        If LibXGridDetalle.GetValue(LibXGridDetalle.currentRowNum, gColQty) = "" Then
            Return True
        End If

        Dim Cantidad As Integer
        Dim Unidad As String
        Dim Existencia As Integer
        Dim Result As Boolean = True
        Dim Precio As Decimal
        Dim Descuento As Decimal

        Dim oUnidad As New SGT.Inventario.Entidades.UnidadMedida
        Dim oUnidadParam As New SGT.Inventario.Entidades.UnidadMedida.ParametroConvertirUnidadMinima

        Cantidad = Val(LibXGridDetalle.GetValue(LibXGridDetalle.currentRowNum, gColQty).ToString.Trim)
        Unidad = LibXGridDetalle.GetValue(LibXGridDetalle.currentRowNum, gcolunit_code).ToString.Trim
        Precio = Val(LibXGridDetalle.GetValue(LibXGridDetalle.currentRowNum, gColCosto).ToString.Trim)

        oUnidadParam.Producto = LibXGridDetalle.GetValue(LibXGridDetalle.currentRowNum, gColITem_code)
        oUnidadParam.UnidadOrigen = Unidad
        oUnidadParam.Cantidad = Cantidad

        oUnidad.ConvertirUnidadMinima(oUnidadParam)

        Existencia = Val(LibXGridDetalle.GetValue(LibXGridDetalle.currentRowNum, gColExist).ToString.Trim)

        If oUnidadParam.Retorno.Cantidad > Existencia Then
            LibXGridDetalle.SetValue(LibXGridDetalle.currentRowNum, gColQty, Existencia)
            'LibXGridDetalle.SetValue(LibXGridDetalle.currentRowNum, gcolunit_code, oUnidadParam.Retorno.Unidad)
            Me.xlk_unit_code.ExecuteFindGrid(Me.LibXGridDetalle, Me.gcolunit_code.getColumnNumber, oUnidadParam.Retorno.Unidad)
            Result = False
        End If

        Return Result
    End Function
    Private Sub lkItem_code_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkItem_code.BeforeSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.IsDataEditing = True Then
                '// Validar si el producto existe y si es asi
                '// aumentar la cantidad de lo contrario continuar
                If ProductoExiste(e.row!item_code) = True Then
                    LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, gColITem_code, "")
                    Throw New ApplicationException("Este producto ya esta registrado en esta factura!")
                End If

            End If

        Catch ex As Exception
            e.handled = True
            LibXGridDetalle.Focus(LibXGridDetalle.CurrentRowIndex, 0)
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub cpordnd_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs)
        If e.Column.ColumnName = "unit_code" Then
            mUnid = e.Row!unit_code.ToString.Trim
        End If

    End Sub

    Private Sub LibXConnector1_SettingDefaulteditValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultEditValues) Handles LibXConnector1.SettingDefaulteditValues
        Try
            If LibXConnector1.IsDataEditing = True Then

                For Each oRow As DataRow In Me.cpordnd.Rows
                    oRow.BeginEdit()
                    oRow!vencimiento = Me.GetVencimiento(oRow!item_code)
                    oRow.EndEdit()
                Next
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub
    Private Function ProductoExiste(ByVal pitem_code As String) As Boolean
        Dim oRow As DataRow()
        Dim Qty As Integer
        Try
            oRow = cpordnd.Select("item_code = '" & pitem_code.Trim & "'")

            If oRow.Length <= 0 Then
                Return False
            End If

            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function

    Private Function GetVencimiento(ByVal Producto As String) As String
        Dim Vence As String
        Try
            Dim oProducto As New SGT.Inventario.Entidades.Articulo

            Vence = oProducto.GetVencimiento(Producto)

            Return Vence
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub CalcularITBIS(Optional ByVal Index As Integer = -1)
        Dim Itbis As Decimal
        Dim Qty As Integer
        Dim Price As Decimal
        Dim Descto As Decimal
        Dim oProducto As SGT.Inventario.Entidades.Articulo
        Dim oParamItbis As SGT.Inventario.Entidades.Articulo.ParametrosCalcularItbis
        Try

            If Index = -1 Then
                Index = LibXGridDetalle.CurrentRowIndex
            End If

            If Val(LibXGridDetalle.GetValue(Index, Me.gColQty)) <= 0 Then
                Exit Sub
            End If

            '''If Val(LibXGridDetalle.GetValue(Index, Me.gcolPrice)) <= 0 Then
            '''    Exit Sub
            '''End If

            oParamItbis = New SGT.Inventario.Entidades.Articulo.ParametrosCalcularItbis

            oProducto = New SGT.Inventario.Entidades.Articulo

            Qty = Val(LibXGridDetalle.GetValue(Index, Me.gColQty).ToString)
            ''Price = Val(LibXGridDetalle.GetValue(Index, Me.gcolPrice).ToString)
            'Descto = Val(LibXGridDetalle.GetValue(Index, Me.gColCosto).ToString)
            Descto = Price - Val(LibXGridDetalle.GetValue(Index, Me.gColCosto).ToString)


            With oParamItbis
                .Producto = LibXGridDetalle.Item(Index, 0)
                .Almacen = LibXGridDetalle.Item(Index, 1)
                .Monto = (Qty * Price) - Descto
            End With

            Itbis = oProducto.CalcularItbis(oParamItbis)

            ''LibXGridDetalle.SetValue(Index, Me.gColItbis, Itbis)

        Catch ex As Exception
            LibX.Log.Add(ex, True)

        End Try
    End Sub

    Private Sub ActualizaTotal()
        Try
            Dim i As Integer
            Dim tPrice As Decimal = 0
            Dim tDesc As Decimal
            Dim oPrice As Decimal
            Dim oDesc As Decimal
            Dim oValue As Object
            Dim oCant As Integer
            Dim TCant As Integer = 0
            Dim Titb As Decimal = 0
            Dim itb As Decimal = 0
            Dim costo As Decimal
            Dim total As Decimal = 0

            For i = 0 To Me.LibXGridDetalle.getCurrentGridView.Count - 1
                oPrice = 0
                oDesc = 0
                oCant = 0
                itb = 0
                costo = 0

                ''oValue = Me.LibXGridDetalle.GetValue(i, Me.gColItbis)
                ''If Not IsNull(oValue) Then
                ''    itb = oValue
                ''End If

                oValue = Me.LibXGridDetalle.GetValue(i, Me.gColQty)
                If Not IsNull(oValue) Then
                    oCant = oValue
                End If

                ''oValue = Me.LibXGridDetalle.GetValue(i, Me.gcolPrice)
                ''If Not IsNull(oValue) Then
                ''    oPrice = oValue
                ''End If

                oValue = Me.LibXGridDetalle.GetValue(i, Me.gColCosto)
                If Not IsNull(oValue) Then
                    costo = oValue
                End If

                tPrice = tPrice + costo
                tDesc = tDesc + oDesc
                TCant = TCant + oCant
                Titb = Titb + itb
                total += oCant * costo

                'Me.LibXGridDetalle.SetValue(i, Me.gColImporte, (oCant * oPrice) - oDesc)

            Next

            Me.xtxt_total_amt.Text = CDec(total).ToString("###,###,##0.00")
            'Me.xtxt_itbis_amount.Text = Titb.ToString("###,###,##0.00")
            'Me.xtxt_net_amount.Text = CDec(total + Titb).ToString("###,###,##0.00")

        Catch ex As Exception
            Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        If e.AcceptedAction = LibxConnectionActions.Add Or e.AcceptedAction = LibxConnectionActions.Edit Then
            ActualizaTotal()
        End If

    End Sub

    Private Sub ftfactd_RowDeleted(ByVal sender As System.Object, ByVal e As System.Data.DataRowChangeEventArgs)
        Try
            If e.Action = DataRowAction.Delete Then
                ActualizaTotal()
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_AfterLoadDetail(ByVal sender As Object, ByVal e As LibX.XbeforeLoadDetailEventArgs) Handles LibXConnector1.AfterLoadDetail
        Try
            If Not LibXConnector1.IsEditing Then
                ActualizaTotal()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub btnDisk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            If SaveToDisk() = True Then
                MessageBox.Show("Salida guardada en disco", "Salvar a Disco", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Function SaveToDisk() As Boolean
        Dim TempDirectory As String

        TempDirectory = System.Configuration.ConfigurationSettings.AppSettings("LibxTempDir")

        If TempDirectory.Trim = "" Or TempDirectory.Trim = "-1" Then
            Throw New ApplicationException("No se ha configurador el Temp Directory!")
        End If
        LibXConnector1.ExecuteFind("doc_serial = " & LibXConnector1.CurrentDataRow!doc_serial.ToString.Trim)

        DataSet1.WriteXml(TempDirectory.Trim & "\" & GetFileName() & ".xml", XmlWriteMode.WriteSchema)

        Return True
    End Function
    Private Function GetFileName() As String
        Dim FileName As String

        FileName = "SAL-" & LibXConnector1.CurrentDataRow!doc_number.ToString.Trim & "-" & _
                   CType(LibXConnector1.CurrentDataRow!doc_date, Date).Year.ToString.Trim & _
                   CType(LibXConnector1.CurrentDataRow!doc_date, Date).Month.ToString.Trim & _
                   CType(LibXConnector1.CurrentDataRow!doc_date, Date).Day.ToString.Trim

        Return FileName
    End Function

    Private Sub lkCliente_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkCliente.AfterSetValues
        Try

            If LibXConnector1.IsDataEditing = True And e.dataFound = True Then
                ''xtxt_term_code.Text = e.row!term_code.ToString.Trim
                ''Me.xlk_term_code.ExecuteFind()
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class

