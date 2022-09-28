Imports LibX
Public Class i_ivadjus01
    Inherits System.Windows.Forms.Form
    Dim oDoc As SGT.Inventario.Entidades.Documento
    Dim ScDefault As Integer
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
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
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
    Friend WithEvents lkItem_code As LibX.LibXLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents LibXGridDetalle As LibX.LibXGrid
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
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
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents gColITem_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents gColitem_name As LibX.XEditTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents txtwhse_code As LibX.XTextBox
    Friend WithEvents txtwhse_name As LibX.XTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnProduct As System.Windows.Forms.Button
    Friend WithEvents btnCostos As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents xcbo_doc_status As LibX.LibXCombo
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents gColExist As LibX.XEditTextBoxColumn
    Friend WithEvents gColCosto As LibX.XEditTextBoxColumn
    Friend WithEvents gColQty As LibX.XEditTextBoxColumn
    Friend WithEvents gColwhse_code As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ButtonVencimientos As System.Windows.Forms.Button
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents gColImporte As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents ivdocsm As System.Data.DataTable
    Friend WithEvents ivdocsd As System.Data.DataTable
    Friend WithEvents gColUnit_code As LibX.XEditTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents xtxt_doc_number As LibX.XTextBox
    Friend WithEvents xtxt_doc_desc As LibX.XTextBox
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents gColFactor As LibX.XEditTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ivdocsm = New System.Data.DataTable
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
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.ivdocsd = New System.Data.DataTable
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
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.xtxt_doc_desc = New LibX.XTextBox
        Me.xtxt_doc_number = New LibX.XTextBox
        Me.txtwhse_code = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lkItem_code = New LibX.LibXLookup
        Me.Label8 = New System.Windows.Forms.Label
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.LibXGridDetalle = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColITem_code = New LibX.XDataGridTextButtonColumn
        Me.gColwhse_code = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColitem_name = New LibX.XEditTextBoxColumn
        Me.gColExist = New LibX.XEditTextBoxColumn
        Me.gColCosto = New LibX.XEditTextBoxColumn
        Me.gColUnit_code = New LibX.XEditTextBoxColumn
        Me.gColQty = New LibX.XEditTextBoxColumn
        Me.gColFactor = New LibX.XEditTextBoxColumn
        Me.gColImporte = New LibX.XEditTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.txtwhse_name = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.Label14 = New System.Windows.Forms.Label
        Me.xcbo_doc_status = New LibX.LibXCombo
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.btnProduct = New System.Windows.Forms.Button
        Me.btnCostos = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ButtonVencimientos = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivdocsm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivdocsd, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_doc_number
        Me.LibXNavigator1.FirstControlInNewMode = Me.txtwhse_code
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(866, 24)
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
        Me.LibXConnector1.DataMember = "ivdocsm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = "INV"
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = "r_ivadjust01.rpt"
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivdocsm, Me.ivdocsd})
        '
        'ivdocsm
        '
        Me.ivdocsm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn26, Me.DataColumn13, Me.DataColumn25, Me.DataColumn27, Me.DataColumn28, Me.DataColumn30})
        Me.ivdocsm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"doc_serial"}, True)})
        Me.ivdocsm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.ivdocsm.TableName = "ivdocsm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "doc_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "doc_type"
        Me.DataColumn2.MaxLength = 3
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "cust_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "whse_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "type_code"
        Me.DataColumn5.MaxLength = 3
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "doc_number"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "doc_date"
        Me.DataColumn7.DataType = GetType(System.DateTime)
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "doc_status"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "userid"
        Me.DataColumn9.MaxLength = 18
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "date_created"
        Me.DataColumn10.DataType = GetType(System.DateTime)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "nota"
        Me.DataColumn11.MaxLength = 80
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "total_amount"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "whse_dest"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "term_code"
        Me.DataColumn25.MaxLength = 5
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "doc_cond"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "itbis_amount"
        Me.DataColumn28.DataType = GetType(System.Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "suc_code"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'ivdocsd
        '
        Me.ivdocsd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn12, Me.DataColumn24, Me.DataColumn29, Me.DataColumn31, Me.DataColumn32})
        Me.ivdocsd.TableName = "ivdocsd"
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "doc_serial"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.AutoIncrement = True
        Me.DataColumn15.AutoIncrementSeed = CType(1, Long)
        Me.DataColumn15.ColumnName = "line_no"
        Me.DataColumn15.DataType = GetType(System.Int32)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "whse_code"
        Me.DataColumn16.DataType = GetType(System.Int32)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "item_code"
        Me.DataColumn17.MaxLength = 10
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "unit_code"
        Me.DataColumn18.MaxLength = 5
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "qty"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "price"
        Me.DataColumn20.DataType = GetType(System.Decimal)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "costo"
        Me.DataColumn21.DataType = GetType(System.Decimal)
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "bf_onhand"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "item_name"
        Me.DataColumn23.MaxLength = 100
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Importe"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "vencimiento"
        Me.DataColumn24.MaxLength = 20
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "itbis"
        Me.DataColumn29.DataType = GetType(System.Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.AllowDBNull = False
        Me.DataColumn31.ColumnName = "suc_code"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "factor"
        Me.DataColumn32.DataType = GetType(System.Decimal)
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
        Me.LibXDbSourceTable1.SerialColumnName = "doc_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ivdocsm"
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
        Me.LibXDbSourceTable2.FillOnRowChange = True
        Me.LibXDbSourceTable2.HeaderIsOnGrid = False
        Me.LibXDbSourceTable2.InnerJon = True
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"doc_serial=doc_serial", "suc_code=suc_code"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select ivdocsd.*,item_name ", "from ivdocsd,ivitemm ", "Where ivdocsd.item_code=ivitemm.item_code", "order by line_no"}
        Me.LibXDbSourceTable2.TableName = "ivdocsd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'xtxt_doc_desc
        '
        Me.xtxt_doc_desc.AcceptsReturn = True
        Me.xtxt_doc_desc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_doc_desc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsm.nota"))
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
        Me.xtxt_doc_desc.Size = New System.Drawing.Size(368, 40)
        Me.xtxt_doc_desc.StatusBarPanelDescripcion = Nothing
        Me.xtxt_doc_desc.TabIndex = 5
        Me.xtxt_doc_desc.Text = ""
        '
        'xtxt_doc_number
        '
        Me.xtxt_doc_number.AcceptsReturn = True
        Me.xtxt_doc_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsm.doc_number"))
        Me.xtxt_doc_number.EditInitialValue = Nothing
        Me.xtxt_doc_number.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_doc_number.FieldDescription = ""
        Me.xtxt_doc_number.FindInitialValue = Nothing
        Me.xtxt_doc_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_doc_number.IgnoreRequiered = True
        Me.xtxt_doc_number.Location = New System.Drawing.Point(96, 16)
        Me.xtxt_doc_number.Name = "xtxt_doc_number"
        Me.xtxt_doc_number.NewInitialValue = Nothing
        Me.xtxt_doc_number.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_doc_number.Requiered = False
        Me.xtxt_doc_number.Size = New System.Drawing.Size(96, 20)
        Me.xtxt_doc_number.StatusBarPanelDescripcion = Nothing
        Me.xtxt_doc_number.TabIndex = 1
        Me.xtxt_doc_number.Text = ""
        '
        'txtwhse_code
        '
        Me.txtwhse_code.AcceptsReturn = True
        Me.txtwhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsm.whse_code"))
        Me.txtwhse_code.EditInitialValue = Nothing
        Me.txtwhse_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.FieldDescription = ""
        Me.txtwhse_code.FindInitialValue = Nothing
        Me.txtwhse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.IgnoreRequiered = False
        Me.txtwhse_code.Location = New System.Drawing.Point(96, 40)
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
        Me.Label2.Location = New System.Drawing.Point(13, 88)
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
        Me.Label6.Location = New System.Drawing.Point(32, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Número:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lkItem_code
        '
        Me.lkItem_code.AlternateFieldSearch = Nothing
        Me.lkItem_code.BeginCheck = False
        Me.lkItem_code.CheckText = Nothing
        Me.lkItem_code.ComboMode = False
        Me.lkItem_code.DataMember = "ivdocsd"
        Me.lkItem_code.DataSource = Me.LibXConnector1
        Me.lkItem_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "costo=purch_cost", "price=price", "unit_code=unit_code", "benef=benef", "bf_onhand=existencia", "whse_code=whse_code"}
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
        Me.lkItem_code.SizesColumns = New String() {"item_name=175", "purch_cost=70", "unit_code=40", "price=75", "existencia=75", "whse_code=30", "benef=75", "item_code=75"}
        Me.lkItem_code.SizesColumnsTab = Nothing
        Me.lkItem_code.SqlString = New String() {"select DISTINCT  ivitemv1.item_code", ",substring(ivitemv1.item_name,1,75)item_name", ",ivitemv1.whse_code", ",ivitemv1.unit_code ", ",ivitemv1.purch_cost", ",ivitemv1.benef ", ",ivitemv1.price ", ",ivitemv1.existencia", ",ivitemv1.ubicacion,", "ivunitd.factor", "from ivitemv1 inner join ivunitd on ivunitd.item_code = ivitemv1.item_code ", "  and ivunitd.unit_code = ivitemv1.unit_code ", "LEFT OUTER JOIN ivcbarram ON ivcbarram.item_code = ivitemv1.item_code", "LEFT OUTER JOIN ivreferm ON ivreferm.item_code = ivitemv1.item_code"}
        Me.lkItem_code.SQLTab = Nothing
        Me.lkItem_code.SrcParameters = New String() {"item_code=item_code"}
        Me.lkItem_code.TabIndex = 6
        Me.lkItem_code.TableName = "ivitemv1"
        Me.lkItem_code.TabStop = False
        Me.lkItem_code.UseCopyConnection = False
        Me.lkItem_code.UseRowRetrieveEvents = False
        Me.lkItem_code.UseTab = False
        Me.lkItem_code.VisParameters = New String() {"Descripción=item_name", "Unidad=unit_code", "Costo=purch_cost", "Beneficio=benef", "Precio=price", "Existecia=existencia", "Almacen=whse_code", "Ubicacion=ubicacion", "Código=item_code"}
        Me.lkItem_code.WhereCondition = "item_status=1"
        Me.lkItem_code.WhereParameters = Nothing
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(632, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Fecha:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ivdocsm.doc_date"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Enabled = False
        Me.LibxDateTimePicker1.FieldDescription = ""
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = True
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(688, 16)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = "now"
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Requiered = False
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(120, 20)
        Me.LibxDateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker1.TabIndex = 6
        '
        'LibXGridDetalle
        '
        Me.LibXGridDetalle.AllowSorting = False
        Me.LibXGridDetalle.AutoAdjustLastColumn = True
        Me.LibXGridDetalle.AutoSearch = False
        Me.LibXGridDetalle.BackgroundColor = System.Drawing.Color.White
        Me.LibXGridDetalle.CaptionText = "Articulos"
        Me.LibXGridDetalle.DataMember = "ivdocsd"
        Me.LibXGridDetalle.DataSource = Me.DataSet1
        Me.LibXGridDetalle.FullRowSelect = False
        Me.LibXGridDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGridDetalle.IsReadOnly = False
        Me.LibXGridDetalle.Location = New System.Drawing.Point(8, 184)
        Me.LibXGridDetalle.Name = "LibXGridDetalle"
        Me.LibXGridDetalle.ReadOnly = True
        Me.LibXGridDetalle.RowHeaderWidth = 15
        Me.LibXGridDetalle.searchText = ""
        Me.LibXGridDetalle.showFooterBar = True
        Me.LibXGridDetalle.Size = New System.Drawing.Size(848, 320)
        Me.LibXGridDetalle.TabIndex = 2
        Me.LibXGridDetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGridDetalle.UseAutoFillLines = True
        Me.LibXGridDetalle.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGridDetalle
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColITem_code, Me.gColwhse_code, Me.gColitem_name, Me.gColExist, Me.gColCosto, Me.gColUnit_code, Me.gColQty, Me.gColFactor, Me.gColImporte})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivdocsd"
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
        'gColwhse_code
        '
        Me.gColwhse_code.Format = ""
        Me.gColwhse_code.FormatInfo = Nothing
        Me.gColwhse_code.HeaderText = "Almacén"
        Me.gColwhse_code.MappingName = "whse_code"
        Me.gColwhse_code.ReadOnly = True
        Me.gColwhse_code.Width = 0
        '
        'gColitem_name
        '
        Me.gColitem_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
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
        Me.gColitem_name.Width = 290
        '
        'gColExist
        '
        Me.gColExist.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColExist.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColExist.Format = "###,###"
        Me.gColExist.FormatInfo = Nothing
        Me.gColExist.HeaderText = "Existenciai"
        Me.gColExist.ImageList = Nothing
        Me.gColExist.isReadOnly = False
        Me.gColExist.MappingName = "bf_onhand"
        Me.gColExist.MaxLength = 32767
        Me.gColExist.ReadOnly = True
        Me.gColExist.TabStop = True
        Me.gColExist.UseCustomCellFormat = False
        Me.gColExist.Width = 75
        '
        'gColCosto
        '
        Me.gColCosto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColCosto.Format = "###,###.##"
        Me.gColCosto.FormatInfo = Nothing
        Me.gColCosto.HeaderText = "Costoi"
        Me.gColCosto.ImageList = Nothing
        Me.gColCosto.isReadOnly = False
        Me.gColCosto.MappingName = "costo"
        Me.gColCosto.MaxLength = 32767
        Me.gColCosto.ReadOnly = True
        Me.gColCosto.TabStop = True
        Me.gColCosto.UseCustomCellFormat = False
        Me.gColCosto.Width = 75
        '
        'gColUnit_code
        '
        Me.gColUnit_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColUnit_code.Format = ""
        Me.gColUnit_code.FormatInfo = Nothing
        Me.gColUnit_code.HeaderText = "Unidad"
        Me.gColUnit_code.ImageList = Nothing
        Me.gColUnit_code.isReadOnly = True
        Me.gColUnit_code.MappingName = "unit_code"
        Me.gColUnit_code.MaxLength = 32767
        Me.gColUnit_code.ReadOnly = True
        Me.gColUnit_code.TabStop = True
        Me.gColUnit_code.UseCustomCellFormat = False
        Me.gColUnit_code.Width = 85
        '
        'gColQty
        '
        Me.gColQty.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColQty.Format = "###,###.##"
        Me.gColQty.FormatInfo = Nothing
        Me.gColQty.HeaderText = "Ajustari"
        Me.gColQty.ImageList = Nothing
        Me.gColQty.isReadOnly = False
        Me.gColQty.MappingName = "qty"
        Me.gColQty.MaxLength = 32767
        Me.gColQty.TabStop = True
        Me.gColQty.UseCustomCellFormat = False
        Me.gColQty.Width = 75
        '
        'gColFactor
        '
        Me.gColFactor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColFactor.Format = ""
        Me.gColFactor.FormatInfo = Nothing
        Me.gColFactor.ImageList = Nothing
        Me.gColFactor.isReadOnly = True
        Me.gColFactor.MappingName = "factor"
        Me.gColFactor.MaxLength = 32767
        Me.gColFactor.ReadOnly = True
        Me.gColFactor.TabStop = True
        Me.gColFactor.UseCustomCellFormat = False
        Me.gColFactor.Width = 0
        '
        'gColImporte
        '
        Me.gColImporte.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColImporte.Format = "###,##0.00"
        Me.gColImporte.FormatInfo = Nothing
        Me.gColImporte.HeaderText = "Importei"
        Me.gColImporte.ImageList = Nothing
        Me.gColImporte.isReadOnly = True
        Me.gColImporte.MappingName = "Importe"
        Me.gColImporte.MaxLength = 32767
        Me.gColImporte.ReadOnly = True
        Me.gColImporte.TabStop = True
        Me.gColImporte.UseCustomCellFormat = False
        Me.gColImporte.Width = 101
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(29, 40)
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
        Me.LibXLookup3.Location = New System.Drawing.Point(448, 40)
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
        Me.LibXLookup3.TabIndex = 3
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
        Me.txtwhse_name.Location = New System.Drawing.Point(152, 40)
        Me.txtwhse_name.Name = "txtwhse_name"
        Me.txtwhse_name.NewInitialValue = Nothing
        Me.txtwhse_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_name.ReadOnly = True
        Me.txtwhse_name.Requiered = False
        Me.txtwhse_name.Size = New System.Drawing.Size(296, 20)
        Me.txtwhse_name.StatusBarPanelDescripcion = Nothing
        Me.txtwhse_name.TabIndex = 27
        Me.txtwhse_name.TabStop = False
        Me.txtwhse_name.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.xcbo_doc_status)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xtxt_doc_number)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xtxt_doc_desc)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.LibXLookup3)
        Me.GroupBox1.Controls.Add(Me.txtwhse_code)
        Me.GroupBox1.Controls.Add(Me.txtwhse_name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.XTextBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(840, 144)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ivdocsm.doc_type"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Location = New System.Drawing.Point(96, 64)
        Me.LibXCombo1.LookupKeyDisplayFields = "doc_name"
        Me.LibXCombo1.LookupKeyField = "doc_type"
        Me.LibXCombo1.LookupTableName = "ivdocst"
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(368, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(51, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 16)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Tipo:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_doc_status
        '
        Me.xcbo_doc_status.AllowDefaultSort = True
        Me.xcbo_doc_status.bound = True
        Me.xcbo_doc_status.currValue = Nothing
        Me.xcbo_doc_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ivdocsm.doc_status"))
        Me.xcbo_doc_status.DefaultWhereString = Nothing
        Me.xcbo_doc_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_doc_status.EditInitialValue = Nothing
        Me.xcbo_doc_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_doc_status.FieldDescription = ""
        Me.xcbo_doc_status.FindInitialValue = Nothing
        Me.xcbo_doc_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_doc_status.IgnoreRequiered = False
        Me.xcbo_doc_status.Items.AddRange(New Object() {"0 - Anulado", "1 - Aplicado", "2 - Pendiente de Aplicar"})
        Me.xcbo_doc_status.Location = New System.Drawing.Point(688, 40)
        Me.xcbo_doc_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_doc_status.LookupKeyField = Nothing
        Me.xcbo_doc_status.LookupTableName = Nothing
        Me.xcbo_doc_status.Name = "xcbo_doc_status"
        Me.xcbo_doc_status.NewInitialValue = Nothing
        Me.xcbo_doc_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_doc_status.Requiered = False
        Me.xcbo_doc_status.Required = False
        Me.xcbo_doc_status.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_doc_status.SqlString = Nothing
        Me.xcbo_doc_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_doc_status.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(626, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Estatus:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(625, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Usuario:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsm.userid"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = True
        Me.XTextBox2.Location = New System.Drawing.Point(688, 88)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox2.ReadOnly = True
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(120, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 1
        Me.XTextBox2.TabStop = False
        Me.XTextBox2.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(627, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Creado:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsm.date_created"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = True
        Me.XTextBox3.Location = New System.Drawing.Point(688, 112)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox3.ReadOnly = True
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(120, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 1
        Me.XTextBox3.TabStop = False
        Me.XTextBox3.Text = ""
        '
        'btnProduct
        '
        Me.btnProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProduct.Location = New System.Drawing.Point(88, 576)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.TabIndex = 4
        Me.btnProduct.Text = "Producto"
        '
        'btnCostos
        '
        Me.btnCostos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCostos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCostos.Location = New System.Drawing.Point(168, 576)
        Me.btnCostos.Name = "btnCostos"
        Me.btnCostos.TabIndex = 5
        Me.btnCostos.Text = "Costos"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(8, 552)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsd.item_name"))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(80, 552)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(592, 20)
        Me.Label4.TabIndex = 32
        '
        'ButtonVencimientos
        '
        Me.ButtonVencimientos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonVencimientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonVencimientos.Location = New System.Drawing.Point(8, 576)
        Me.ButtonVencimientos.Name = "ButtonVencimientos"
        Me.ButtonVencimientos.TabIndex = 3
        Me.ButtonVencimientos.Text = "Vencimientos"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsd.bf_onhand"))
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(776, 552)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(704, 552)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 16)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Existencia:"
        '
        'i_ivadjus01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(866, 624)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCostos)
        Me.Controls.Add(Me.btnProduct)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXGridDetalle)
        Me.Controls.Add(Me.lkItem_code)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.ButtonVencimientos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivadjus01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ajuste de Inventario"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivdocsm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivdocsd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try

            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                e.UpdatingArgs.Row!type_code = "ADJ"
                e.UpdatingArgs.Row!doc_status = 2 'pendiente de aplicar
                If LibXGridDetalle.getCurrentGridView.Count <= 0 Then
                    Throw New ApplicationException("No se puede guardar Ajuste sin detalle!")
                End If

                e.UpdatingArgs.Row!date_created = LibX.Data.Manager.GetScalar("select getdate()")

                If IsNull(e.UpdatingArgs.Row!doc_date) Then
                    e.UpdatingArgs.Row!doc_date = LibX.Data.Manager.Connection.GetDate
                End If
                If e.UpdatingArgs.Row!doc_type = 28 Then
                    e.UpdatingArgs.Row!doc_type = 26
                End If

                '--?
                'e.UpdatingArgs.Row!doc_type = DBNull.Value
                e.UpdatingArgs.Row!cust_code = DBNull.Value
                e.UpdatingArgs.Row!suc_code = ScDefault


                '// EXISTE UNA LIBRERIA PARA ESTOS FINES
                Dim intLast As Integer

                Dim doc As New SGT.Inventario.Entidades.Documento("ADJ")
                e.UpdatingArgs.Row!doc_number = doc.GenerateNumber("ADJ", e.UpdatingArgs.Row!whse_code)

            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            Log.Add(ex)

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
            End If
        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub
    Private Sub lkItem_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkItem_code.AfterSetValues
        Try

            If e.dataFound = False Then
                Exit Sub
            End If

            If Me.LibXConnector1.IsDataEditing = True Then
                LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.gColFactor, e.row!factor)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try
            LibxDateTimePicker1.Value = LibX.Data.Manager.Connection.GetDate.ToString("d")
            xcbo_doc_status.currValue = 2

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub LibXGridDetalle_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGridDetalle.CellValidate
        Try
            If e.cell = Me.gColITem_code.Column Then
                If e.value = "" Then
                    e.hasErrors = True
                    Exit Sub
                End If
            End If

            '// Validar la cantidad
            If Me.gColQty.Column = e.cell Then
                If LibXGridDetalle.GetValue(e.row, Me.gColITem_code) = "" Then
                    LibXGridDetalle.Focus(e.row, 0)
                    Exit Sub
                End If

                If IsNull(e.value) Then
                    e.hasErrors = True
                    Exit Sub
                End If

                If Val(e.value) = 0 Then
                    e.hasErrors = True
                    Throw New ApplicationException("Digite la cantidad a ajustar!")
                End If

                Dim Existe As Decimal = 0
                If LibXGridDetalle.GetValue(e.row, Me.gColExist) <> "" Then
                    Existe = LibXGridDetalle.GetValue(e.row, Me.gColExist)
                End If

                If (Existe + Val(e.value)) < 0 Then
                    e.hasErrors = True
                    LibXGridDetalle.SetValue(e.row, Me.gColQty, 0)
                    Throw New ApplicationException("No hay existencia suficiente para aplicar este ajuste!")
                End If
            End If

        Catch ex As Exception
            e.hasErrors = True
            Log.Add(ex, True)
        End Try
    End Sub
    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        'Dim SelecStmt As String
        'Try

        '    If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then

        '        Dim AxCrystalReport1 As New LibX.ReportLib
        '        With AxCrystalReport1
        '            .ReportFileName = MdlUtil.GetReportPath("INV", "r_ivadjust01.rpt")
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

        'Catch ex As Exception
        '    LibX.Log.Show(ex)

        'End Try
    End Sub

    Private Sub btnProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduct.Click
        Dim oParam As LibX.LibxPrgParams
        Try
            If LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColITem_code) = "" Then
                Exit Sub
            End If

            oParam = New LibX.LibxPrgParams
            With oParam
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowQuery = False
                .IsFromOther = True
                .WhereToExecute = "ivitemm.item_code = '" & LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColITem_code).Trim & "'"
            End With

            LibX.LibXRunner.Run("i_ivitem01", "INV")
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnCostos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCostos.Click
        Dim oParam As LibX.LibxPrgParams
        Try

            If LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColITem_code) = "" Then
                Exit Sub
            End If

            If LibXConnector1.CurrentDataRow!whse_code.ToString = "" Then
                Exit Sub
            End If

            oParam = New LibX.LibxPrgParams
            With oParam
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowQuery = False
                .IsFromOther = True
                .WhereToExecute = "ivitemd.item_code = '" & LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColITem_code).Trim & _
                                  "' and ivitemd.whse_code = '" & LibXConnector1.CurrentDataRow!whse_code.ToString
            End With

            LibX.LibXRunner.Run("i_ivitem02", "INV")
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try

            btnProduct.Enabled = e.isDataEditing And LibXConnector1.HasRecords
            btnCostos.Enabled = e.isDataEditing And LibXConnector1.HasRecords
            Me.ButtonVencimientos.Enabled = Not e.isDataEditing And LibXConnector1.HasRecords

            If e.action = LibxConnectionActions.Edit Then
                If Val(LibXConnector1.CurrentDataRow!doc_status.ToString.Trim) <> 2 Then
                    LibXConnector1.ShowWarningCancel = False
                    LibXConnector1.Cancel()
                    LibXConnector1.ShowWarningCancel = True
                    Throw New ApplicationException("Este documento no puede ser modificado")
                End If
            End If
            If e.action = LibxConnectionActions.Find Then
                xcbo_doc_status.currValue = 2
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVencimientos.Click
        Dim oParam As LibX.LibxPrgParams
        Try

            oParam = New LibX.LibxPrgParams
            With oParam
                .AllowDelete = True
                .AllowEdit = True
                .AllowNew = False
                .AllowQuery = False
                .IsFromOther = True
                .WhereToExecute = "doc_serial = " & LibXConnector1.CurrentDataRow!doc_serial & " and type_code ='ADJ'"
            End With

            LibX.App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("i_ivcmtod", "INV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGridDetalle_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGridDetalle.CurrentRowChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                If IsNull(Me.gColITem_code.GetValue) Then
                    LibXGridDetalle.Focus(e.row, 0)
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            e.AditionalWhere = "type_code='ADJ'"
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub i_ivadjus01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ScDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibXScDefault").ToString)
            Me.DataSet1.Tables("ivdocsd").Columns("Importe").Expression = "isnull(qty,0)*isnull(costo,0)"
            Me.LibXGridDetalle.footerOperations.add("Importe", "sum(Importe)")
            Me.LibXGridDetalle.footerOperations.add("item_code", "count(item_code)")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        Dim itemCode As String = ""

        Try

            For Each oRow As DataRow In ivdocsd.Rows
                If itemCode.Trim = oRow!item_code.ToString.Trim Then
                    Throw New ApplicationException("Tiene productos repetidos en este documento, verifique!")
                End If

                itemCode = oRow!item_code.ToString.Trim
            Next

        Catch ex As Exception
            e.Handled = True
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try

            If Not e.row Is Nothing Then
                If e.row!doc_status.ToString.Trim = "2" Then
                    LibXConnector1.AllowDelete = True
                    LibXConnector1.AllowEdit = True
                Else
                    LibXConnector1.AllowDelete = False
                    LibXConnector1.AllowEdit = False
                End If
                LibXNavigator1.UpdateState()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingDetailRow
        Try
            If e.UpdatingArgs.Row.RowState <> DataRowState.Deleted Then
                If IsNull(e.UpdatingArgs.Row!item_code) Then
                    e.UpdatingArgs.Status = UpdateStatus.SkipCurrentRow
                End If
                If LibX.IsNull(e.UpdatingArgs.Row!unit_code) Then
                    Throw New ApplicationException("No se puede grabar Ajuste con producto sin unidad!")
                End If
                If LibX.IsNull(e.UpdatingArgs.Row!qty) Then
                    Throw New ApplicationException("No se puede grabar Ajuste con producto sin cantidad!")
                End If
                If LibXGridDetalle.getCurrentGridView.Count < 0 Then
                    Throw New ApplicationException("No se puede grabar Ajuste sin detalle!")
                End If
            End If

        Catch ex As Exception
            Log.Add(ex)
        End Try

    End Sub

    Private Sub LibxDateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibxDateTimePicker1.ValueChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                If LibxDateTimePicker1.Value > LibX.Data.Manager.GetScalar("select getdate()") Then
                    LibxDateTimePicker1.Value = LibX.Data.Manager.GetScalar("select getdate()")
                    Throw New ApplicationException("La fecha no debe ser mayor a la fecha del dia!")
                End If
            End If
        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub
End Class
