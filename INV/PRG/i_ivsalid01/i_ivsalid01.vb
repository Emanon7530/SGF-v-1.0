Imports LibX
Imports SGT.Inventario.Entidades

Public Class i_ivsalid01
    Inherits System.Windows.Forms.Form
    Dim oDoc As SGT.Inventario.Entidades.Documento
    Dim mUnid As String
    Dim WhDefault As Integer
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
    Friend WithEvents lkItem_code As LibX.LibXLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents LibXGridDetalle As LibX.LibXGrid
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
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
    Friend WithEvents xcbo_doc_status As LibX.LibXCombo
    Friend WithEvents lkCliente As LibX.LibXLookup
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtClinombre As System.Windows.Forms.TextBox
    Friend WithEvents XTextBox5 As LibX.XTextBox
    Friend WithEvents gColCosto As LibX.XEditTextBoxColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ivdocsm As System.Data.DataTable
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
    Friend WithEvents ivdocsd As System.Data.DataTable
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
    Friend WithEvents gcolPrice As LibX.XEditTextBoxColumn
    Friend WithEvents gcolImporte As LibX.XEditTextBoxColumn
    Friend WithEvents Importe As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents gColQty As LibX.XEditTextBoxColumn
    Friend WithEvents xtxt_total_amt As LibX.XTextBox
    Friend WithEvents gColWhse_code As LibX.XEditTextBoxColumn
    Friend WithEvents ButtonVencimiento As System.Windows.Forms.Button
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents gcolunit_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents xlk_unit_code As LibX.LibXLookup
    Friend WithEvents xtxt_dev_number As LibX.XTextBox
    Friend WithEvents xtxt_doc_desc As LibX.XTextBox
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents gColVencimiento As LibX.XEditTextBoxColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblVencimiento As System.Windows.Forms.Label
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gColItbis As LibX.XEditTextBoxColumn
    Friend WithEvents xtxt_itbis_amount As LibX.XTextBox
    Friend WithEvents xtxt_net_amount As LibX.XTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnDisk As System.Windows.Forms.Button
    Friend WithEvents xlk_term_code As LibX.LibXLookup
    Friend WithEvents txtterm_name As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents xtxt_term_code As LibX.XTextBox
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents gColExist As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents gColFactor As LibX.XEditTextBoxColumn
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblentrada As System.Windows.Forms.Label
    Friend WithEvents DataColumn32 As System.Data.DataColumn
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
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.ivdocsd = New System.Data.DataTable
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
        Me.Importe = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.xtxt_doc_desc = New LibX.XTextBox
        Me.xtxt_dev_number = New LibX.XTextBox
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
        Me.gColVencimiento = New LibX.XEditTextBoxColumn
        Me.gColCosto = New LibX.XEditTextBoxColumn
        Me.gColExist = New LibX.XEditTextBoxColumn
        Me.gcolPrice = New LibX.XEditTextBoxColumn
        Me.gColItbis = New LibX.XEditTextBoxColumn
        Me.gColFactor = New LibX.XEditTextBoxColumn
        Me.gcolImporte = New LibX.XEditTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.txtwhse_name = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xtxt_term_code = New LibX.XTextBox
        Me.xlk_term_code = New LibX.LibXLookup
        Me.txtterm_name = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.xtxt_net_amount = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.xtxt_itbis_amount = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.XTextBox5 = New LibX.XTextBox
        Me.lkCliente = New LibX.LibXLookup
        Me.txtClinombre = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.xcbo_doc_status = New LibX.LibXCombo
        Me.Label5 = New System.Windows.Forms.Label
        Me.xtxt_total_amt = New LibX.XTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnProduct = New System.Windows.Forms.Button
        Me.btnCostos = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.ButtonVencimiento = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblVencimiento = New System.Windows.Forms.Label
        Me.btnDisk = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.lblentrada = New System.Windows.Forms.Label
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
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_dev_number
        Me.LibXNavigator1.FirstControlInNewMode = Me.txtwhse_code
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(850, 24)
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
        Me.LibXConnector1.ReportName = "r_ivsalid01.rpt"
        Me.LibXConnector1.RequeryData = True
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivdocsm, Me.ivdocsd})
        '
        'ivdocsm
        '
        Me.ivdocsm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn22, Me.DataColumn23, Me.DataColumn25, Me.DataColumn26, Me.DataColumn28, Me.DataColumn29})
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
        Me.DataColumn2.DataType = GetType(System.Int32)
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
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "total_amount"
        Me.DataColumn22.DataType = GetType(System.Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "whse_dest"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "doc_cond"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "itbis_amount"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "term_code"
        Me.DataColumn28.MaxLength = 5
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "suc_code"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'ivdocsd
        '
        Me.ivdocsd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.Importe, Me.DataColumn24, Me.DataColumn27, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32})
        Me.ivdocsd.TableName = "ivdocsd"
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "doc_serial"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.AutoIncrement = True
        Me.DataColumn13.AutoIncrementSeed = CType(1, Long)
        Me.DataColumn13.ColumnName = "line_no"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "whse_code"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "item_code"
        Me.DataColumn15.MaxLength = 10
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "unit_code"
        Me.DataColumn16.MaxLength = 4
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.ColumnName = "qty"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "price"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "costo"
        Me.DataColumn19.DataType = GetType(System.Decimal)
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "bf_onhand"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.AllowDBNull = False
        Me.DataColumn21.ColumnName = "item_name"
        Me.DataColumn21.MaxLength = 100
        '
        'Importe
        '
        Me.Importe.ColumnName = "Importe"
        Me.Importe.DataType = GetType(System.Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "vencimiento"
        Me.DataColumn24.MaxLength = 20
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "itbis"
        Me.DataColumn27.DataType = GetType(System.Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "suc_code"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "factor"
        Me.DataColumn31.DataType = GetType(System.Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.Caption = "Entrada"
        Me.DataColumn32.ColumnName = "Entrada"
        Me.DataColumn32.DataType = GetType(System.Int32)
        Me.DataColumn32.ReadOnly = True
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
        Me.LibXDbSourceTable2.Source = New String() {"select ivdocsd.*,item_name ", "from ivdocsd,ivitemm ", "Where ivdocsd.item_code=ivitemm.item_code"}
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
        Me.xtxt_doc_desc.Location = New System.Drawing.Point(96, 136)
        Me.xtxt_doc_desc.Multiline = True
        Me.xtxt_doc_desc.Name = "xtxt_doc_desc"
        Me.xtxt_doc_desc.NewInitialValue = Nothing
        Me.xtxt_doc_desc.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_doc_desc.Requiered = False
        Me.xtxt_doc_desc.Size = New System.Drawing.Size(352, 48)
        Me.xtxt_doc_desc.StatusBarPanelDescripcion = Nothing
        Me.xtxt_doc_desc.TabIndex = 5
        Me.xtxt_doc_desc.Text = ""
        '
        'xtxt_dev_number
        '
        Me.xtxt_dev_number.AcceptsReturn = True
        Me.xtxt_dev_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsm.doc_number"))
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
        Me.Label2.Location = New System.Drawing.Point(16, 136)
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
        Me.lkItem_code.SizesColumns = New String() {"item_name=450"}
        Me.lkItem_code.SizesColumnsTab = Nothing
        Me.lkItem_code.SqlString = New String() {"select DISTINCT  ivitemv1.item_code", ",ivitemv1.item_name", ",ivitemv1.whse_code", ",ivitemv1.unit_code", ",purch_cost", ",price ", ",ivitemv1.existencia", ",ivitemv1.benef ", ",ivunitd.factor", "from ivitemv1 ", "left outer join ivunitd", "on ivunitd.unit_code = ivitemv1.unit_code", "and ivunitd.item_code = ivitemv1.item_code", " LEFT OUTER JOIN ivcbarram", " ON ivcbarram.item_code = ivitemv1.item_code", "LEFT OUTER JOIN ivreferm", " ON ivreferm.item_code = ivitemv1.item_code", "order by ivitemv1.item_name"}
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
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ivdocsm.doc_date"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxDateTimePicker1.FieldDescription = ""
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = True
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(616, 16)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = "now"
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
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
        Me.LibXGridDetalle.Location = New System.Drawing.Point(8, 232)
        Me.LibXGridDetalle.Name = "LibXGridDetalle"
        Me.LibXGridDetalle.ReadOnly = True
        Me.LibXGridDetalle.RowHeaderWidth = 15
        Me.LibXGridDetalle.searchText = ""
        Me.LibXGridDetalle.showFooterBar = True
        Me.LibXGridDetalle.Size = New System.Drawing.Size(832, 312)
        Me.LibXGridDetalle.TabIndex = 2
        Me.LibXGridDetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGridDetalle.UseAutoFillLines = True
        Me.LibXGridDetalle.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGridDetalle
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColITem_code, Me.gColWhse_code, Me.gColitem_name, Me.gColQty, Me.gcolunit_code, Me.gColVencimiento, Me.gColCosto, Me.gColExist, Me.gcolPrice, Me.gColItbis, Me.gColFactor, Me.gcolImporte})
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
        Me.gcolunit_code.isReadOnly = True
        Me.gcolunit_code.Lookup = Me.xlk_unit_code
        Me.gcolunit_code.MappingName = "unit_code"
        Me.gcolunit_code.MaxLength = 32767
        Me.gcolunit_code.ReadOnly = True
        Me.gcolunit_code.TabStop = False
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
        'gColVencimiento
        '
        Me.gColVencimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColVencimiento.Format = ""
        Me.gColVencimiento.FormatInfo = Nothing
        Me.gColVencimiento.HeaderText = "Vencimiento"
        Me.gColVencimiento.ImageList = Nothing
        Me.gColVencimiento.isReadOnly = True
        Me.gColVencimiento.MappingName = "vencimiento"
        Me.gColVencimiento.MaxLength = 32767
        Me.gColVencimiento.ReadOnly = True
        Me.gColVencimiento.TabStop = True
        Me.gColVencimiento.UseCustomCellFormat = False
        Me.gColVencimiento.Width = 0
        '
        'gColCosto
        '
        Me.gColCosto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColCosto.Format = "#,###,##0.00"
        Me.gColCosto.FormatInfo = Nothing
        Me.gColCosto.HeaderText = "Costo RDi"
        Me.gColCosto.ImageList = Nothing
        Me.gColCosto.isReadOnly = True
        Me.gColCosto.MappingName = "costo"
        Me.gColCosto.MaxLength = 32767
        Me.gColCosto.ReadOnly = True
        Me.gColCosto.TabStop = True
        Me.gColCosto.UseCustomCellFormat = False
        Me.gColCosto.Width = 75
        '
        'gColExist
        '
        Me.gColExist.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColExist.Format = "#,###,##0"
        Me.gColExist.FormatInfo = Nothing
        Me.gColExist.HeaderText = "existencia"
        Me.gColExist.ImageList = Nothing
        Me.gColExist.isReadOnly = False
        Me.gColExist.MappingName = "bf_onhand"
        Me.gColExist.MaxLength = 32767
        Me.gColExist.ReadOnly = True
        Me.gColExist.TabStop = True
        Me.gColExist.UseCustomCellFormat = False
        Me.gColExist.Width = 0
        '
        'gcolPrice
        '
        Me.gcolPrice.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gcolPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolPrice.Format = ""
        Me.gcolPrice.FormatInfo = Nothing
        Me.gcolPrice.HeaderText = "Precioi"
        Me.gcolPrice.ImageList = Nothing
        Me.gcolPrice.isReadOnly = False
        Me.gcolPrice.MappingName = "price"
        Me.gcolPrice.MaxLength = 32767
        Me.gcolPrice.ReadOnly = True
        Me.gcolPrice.TabStop = True
        Me.gcolPrice.UseCustomCellFormat = False
        Me.gcolPrice.Width = 75
        '
        'gColItbis
        '
        Me.gColItbis.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColItbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColItbis.Format = "###,###.##"
        Me.gColItbis.FormatInfo = Nothing
        Me.gColItbis.HeaderText = "Itbisi"
        Me.gColItbis.ImageList = Nothing
        Me.gColItbis.isReadOnly = True
        Me.gColItbis.MappingName = "itbis"
        Me.gColItbis.MaxLength = 32767
        Me.gColItbis.ReadOnly = True
        Me.gColItbis.TabStop = True
        Me.gColItbis.UseCustomCellFormat = False
        Me.gColItbis.Width = 75
        '
        'gColFactor
        '
        Me.gColFactor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColFactor.Format = ""
        Me.gColFactor.FormatInfo = Nothing
        Me.gColFactor.ImageList = Nothing
        Me.gColFactor.isReadOnly = False
        Me.gColFactor.MappingName = "factor"
        Me.gColFactor.MaxLength = 32767
        Me.gColFactor.TabStop = True
        Me.gColFactor.UseCustomCellFormat = False
        Me.gColFactor.Width = 0
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
        Me.Label1.Location = New System.Drawing.Point(32, 40)
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
        Me.LibXLookup3.Location = New System.Drawing.Point(432, 40)
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
        Me.txtwhse_name.Location = New System.Drawing.Point(152, 40)
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
        Me.GroupBox1.Controls.Add(Me.xtxt_term_code)
        Me.GroupBox1.Controls.Add(Me.xlk_term_code)
        Me.GroupBox1.Controls.Add(Me.txtterm_name)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.xtxt_net_amount)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.xtxt_itbis_amount)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.xlk_unit_code)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.XTextBox5)
        Me.GroupBox1.Controls.Add(Me.lkCliente)
        Me.GroupBox1.Controls.Add(Me.txtClinombre)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.xcbo_doc_status)
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
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(832, 192)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'xtxt_term_code
        '
        Me.xtxt_term_code.AcceptsReturn = True
        Me.xtxt_term_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsm.term_code"))
        Me.xtxt_term_code.EditInitialValue = Nothing
        Me.xtxt_term_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_term_code.FieldDescription = ""
        Me.xtxt_term_code.FindInitialValue = Nothing
        Me.xtxt_term_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_term_code.IgnoreRequiered = True
        Me.xtxt_term_code.Location = New System.Drawing.Point(96, 112)
        Me.xtxt_term_code.Name = "xtxt_term_code"
        Me.xtxt_term_code.NewInitialValue = Nothing
        Me.xtxt_term_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_term_code.Requiered = False
        Me.xtxt_term_code.Size = New System.Drawing.Size(48, 20)
        Me.xtxt_term_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_term_code.TabIndex = 38
        Me.xtxt_term_code.Text = ""
        '
        'xlk_term_code
        '
        Me.xlk_term_code.AlternateFieldSearch = Nothing
        Me.xlk_term_code.BeginCheck = False
        Me.xlk_term_code.CheckText = Nothing
        Me.xlk_term_code.ComboMode = False
        Me.xlk_term_code.DataMember = Nothing
        Me.xlk_term_code.DataSource = Me.LibXConnector1
        Me.xlk_term_code.DestParameters = New String() {"term_code=term_code", "txtterm_name=term_name"}
        Me.xlk_term_code.FilterField = Nothing
        Me.xlk_term_code.IgnoreFindInBrowseMode = False
        Me.xlk_term_code.isCanceled = False
        Me.xlk_term_code.Location = New System.Drawing.Point(432, 112)
        Me.xlk_term_code.LookCaption = "Terminos"
        Me.xlk_term_code.Name = "xlk_term_code"
        Me.xlk_term_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_term_code.ShowFilter = True
        Me.xlk_term_code.ShowMessageNotFound = True
        Me.xlk_term_code.ShowWarning = False
        Me.xlk_term_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_term_code.SizesColumns = Nothing
        Me.xlk_term_code.SizesColumnsTab = Nothing
        Me.xlk_term_code.SqlString = New String() {Nothing}
        Me.xlk_term_code.SQLTab = Nothing
        Me.xlk_term_code.SrcParameters = New String() {"term_code=term_code"}
        Me.xlk_term_code.TabIndex = 41
        Me.xlk_term_code.TableName = "cctermm"
        Me.xlk_term_code.TabStop = False
        Me.xlk_term_code.UseCopyConnection = False
        Me.xlk_term_code.UseRowRetrieveEvents = False
        Me.xlk_term_code.UseTab = False
        Me.xlk_term_code.VisParameters = New String() {"Código=term_code", "Nombre=term_name"}
        Me.xlk_term_code.WhereCondition = Nothing
        Me.xlk_term_code.WhereParameters = Nothing
        '
        'txtterm_name
        '
        Me.txtterm_name.Location = New System.Drawing.Point(152, 112)
        Me.txtterm_name.Name = "txtterm_name"
        Me.txtterm_name.ReadOnly = True
        Me.txtterm_name.Size = New System.Drawing.Size(280, 20)
        Me.txtterm_name.TabIndex = 40
        Me.txtterm_name.TabStop = False
        Me.txtterm_name.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Location = New System.Drawing.Point(34, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 16)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Termino:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_net_amount
        '
        Me.xtxt_net_amount.AcceptsReturn = True
        Me.xtxt_net_amount.EditInitialValue = Nothing
        Me.xtxt_net_amount.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_net_amount.FieldDescription = ""
        Me.xtxt_net_amount.FindInitialValue = Nothing
        Me.xtxt_net_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_net_amount.IgnoreRequiered = True
        Me.xtxt_net_amount.Location = New System.Drawing.Point(616, 112)
        Me.xtxt_net_amount.Name = "xtxt_net_amount"
        Me.xtxt_net_amount.NewInitialValue = Nothing
        Me.xtxt_net_amount.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_net_amount.ReadOnly = True
        Me.xtxt_net_amount.Requiered = False
        Me.xtxt_net_amount.Size = New System.Drawing.Size(120, 20)
        Me.xtxt_net_amount.StatusBarPanelDescripcion = Nothing
        Me.xtxt_net_amount.TabIndex = 36
        Me.xtxt_net_amount.TabStop = False
        Me.xtxt_net_amount.Text = ""
        Me.xtxt_net_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(538, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 16)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Monto Neto:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_itbis_amount
        '
        Me.xtxt_itbis_amount.AcceptsReturn = True
        Me.xtxt_itbis_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsm.itbis_amount"))
        Me.xtxt_itbis_amount.EditInitialValue = Nothing
        Me.xtxt_itbis_amount.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_itbis_amount.FieldDescription = ""
        Me.xtxt_itbis_amount.FindInitialValue = Nothing
        Me.xtxt_itbis_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_itbis_amount.IgnoreRequiered = True
        Me.xtxt_itbis_amount.Location = New System.Drawing.Point(616, 88)
        Me.xtxt_itbis_amount.Name = "xtxt_itbis_amount"
        Me.xtxt_itbis_amount.NewInitialValue = Nothing
        Me.xtxt_itbis_amount.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_itbis_amount.ReadOnly = True
        Me.xtxt_itbis_amount.Requiered = False
        Me.xtxt_itbis_amount.Size = New System.Drawing.Size(120, 20)
        Me.xtxt_itbis_amount.StatusBarPanelDescripcion = Nothing
        Me.xtxt_itbis_amount.TabIndex = 34
        Me.xtxt_itbis_amount.TabStop = False
        Me.xtxt_itbis_amount.Text = ""
        Me.xtxt_itbis_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(576, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 16)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Itbis:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.LibXCombo1.Size = New System.Drawing.Size(352, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 3
        '
        'XTextBox5
        '
        Me.XTextBox5.AcceptsReturn = True
        Me.XTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsm.cust_code"))
        Me.XTextBox5.EditInitialValue = Nothing
        Me.XTextBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.FieldDescription = ""
        Me.XTextBox5.FindInitialValue = Nothing
        Me.XTextBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.IgnoreRequiered = True
        Me.XTextBox5.Location = New System.Drawing.Point(96, 88)
        Me.XTextBox5.Name = "XTextBox5"
        Me.XTextBox5.NewInitialValue = Nothing
        Me.XTextBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.Requiered = False
        Me.XTextBox5.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox5.StatusBarPanelDescripcion = Nothing
        Me.XTextBox5.TabIndex = 4
        Me.XTextBox5.Text = ""
        '
        'lkCliente
        '
        Me.lkCliente.AlternateFieldSearch = Nothing
        Me.lkCliente.BeginCheck = False
        Me.lkCliente.CheckText = Nothing
        Me.lkCliente.ComboMode = False
        Me.lkCliente.DataMember = Nothing
        Me.lkCliente.DataSource = Me.LibXConnector1
        Me.lkCliente.DestParameters = New String() {"cust_code=cust_code", "txtClinombre=cust_name"}
        Me.lkCliente.FilterField = Nothing
        Me.lkCliente.IgnoreFindInBrowseMode = False
        Me.lkCliente.isCanceled = False
        Me.lkCliente.Location = New System.Drawing.Point(432, 88)
        Me.lkCliente.LookCaption = "Clientes"
        Me.lkCliente.Name = "lkCliente"
        Me.lkCliente.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkCliente.ShowFilter = True
        Me.lkCliente.ShowMessageNotFound = True
        Me.lkCliente.ShowWarning = False
        Me.lkCliente.Size = New System.Drawing.Size(16, 20)
        Me.lkCliente.SizesColumns = Nothing
        Me.lkCliente.SizesColumnsTab = Nothing
        Me.lkCliente.SqlString = New String() {"select cust_code,cust_name,cctermm.term_code,due_days,disc_days,disc_pct,cust_pri" & _
        "cemajor", "from cccustm inner join cctermm on cccustm.term_code = cctermm.term_code"}
        Me.lkCliente.SQLTab = Nothing
        Me.lkCliente.SrcParameters = New String() {"cust_code=cust_code"}
        Me.lkCliente.TabIndex = 30
        Me.lkCliente.TableName = "cccustm"
        Me.lkCliente.TabStop = False
        Me.lkCliente.UseCopyConnection = False
        Me.lkCliente.UseRowRetrieveEvents = False
        Me.lkCliente.UseTab = False
        Me.lkCliente.VisParameters = New String() {"Código=cust_code", "Nombre=cust_name"}
        Me.lkCliente.WhereCondition = "csttype_code = 7"
        Me.lkCliente.WhereParameters = Nothing
        '
        'txtClinombre
        '
        Me.txtClinombre.Location = New System.Drawing.Point(152, 88)
        Me.txtClinombre.Name = "txtClinombre"
        Me.txtClinombre.ReadOnly = True
        Me.txtClinombre.Size = New System.Drawing.Size(280, 20)
        Me.txtClinombre.TabIndex = 29
        Me.txtClinombre.TabStop = False
        Me.txtClinombre.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(40, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 16)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Cliente:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.xcbo_doc_status.FindInitialValue = "2"
        Me.xcbo_doc_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_doc_status.IgnoreRequiered = False
        Me.xcbo_doc_status.Items.AddRange(New Object() {"0 - Anulado", "1 - Aplicado", "2 - Pendiente de Aplicar"})
        Me.xcbo_doc_status.Location = New System.Drawing.Point(616, 40)
        Me.xcbo_doc_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_doc_status.LookupKeyField = Nothing
        Me.xcbo_doc_status.LookupTableName = Nothing
        Me.xcbo_doc_status.Name = "xcbo_doc_status"
        Me.xcbo_doc_status.NewInitialValue = "2"
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
        Me.xtxt_total_amt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsm.total_amount"))
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(54, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 16)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Tipo:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnProduct
        '
        Me.btnProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProduct.Location = New System.Drawing.Point(88, 648)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.TabIndex = 4
        Me.btnProduct.Text = "Producto"
        '
        'btnCostos
        '
        Me.btnCostos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCostos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCostos.Location = New System.Drawing.Point(168, 648)
        Me.btnCostos.Name = "btnCostos"
        Me.btnCostos.TabIndex = 5
        Me.btnCostos.Text = "Costos"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(8, 600)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsd.item_name"))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(80, 600)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(432, 20)
        Me.Label4.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(616, 600)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 16)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Existencia:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsd.bf_onhand"))
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(688, 600)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 20)
        Me.Label12.TabIndex = 32
        '
        'ButtonVencimiento
        '
        Me.ButtonVencimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonVencimiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonVencimiento.Location = New System.Drawing.Point(8, 648)
        Me.ButtonVencimiento.Name = "ButtonVencimiento"
        Me.ButtonVencimiento.TabIndex = 33
        Me.ButtonVencimiento.Text = "Vencimientos"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(8, 624)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 16)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Vencimiento"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVencimiento
        '
        Me.lblVencimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVencimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsd.vencimiento"))
        Me.lblVencimiento.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblVencimiento.Location = New System.Drawing.Point(80, 624)
        Me.lblVencimiento.Name = "lblVencimiento"
        Me.lblVencimiento.Size = New System.Drawing.Size(72, 20)
        Me.lblVencimiento.TabIndex = 35
        '
        'btnDisk
        '
        Me.btnDisk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDisk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDisk.Location = New System.Drawing.Point(768, 648)
        Me.btnDisk.Name = "btnDisk"
        Me.btnDisk.TabIndex = 36
        Me.btnDisk.Text = "A Disco"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Location = New System.Drawing.Point(576, 624)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 16)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Existencia Entrada:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblentrada
        '
        Me.lblentrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblentrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblentrada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsd.Entrada"))
        Me.lblentrada.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblentrada.Location = New System.Drawing.Point(688, 624)
        Me.lblentrada.Name = "lblentrada"
        Me.lblentrada.Size = New System.Drawing.Size(72, 20)
        Me.lblentrada.TabIndex = 38
        '
        'i_ivsalid01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(850, 680)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblentrada)
        Me.Controls.Add(Me.btnDisk)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblVencimiento)
        Me.Controls.Add(Me.ButtonVencimiento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCostos)
        Me.Controls.Add(Me.btnProduct)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXGridDetalle)
        Me.Controls.Add(Me.lkItem_code)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivsalid01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Salida de Inventario"
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
                e.UpdatingArgs.Row!type_code = "SAL"
                e.UpdatingArgs.Row!doc_status = 2 'pendiente de aplicar
                e.UpdatingArgs.Row!suc_code = LibX.User.Sucursal
                If Me.txtwhse_code.Text = "" Then
                    Throw New Exception("Debe indicar el almacen")
                End If

                e.UpdatingArgs.Row!date_created = LibX.Data.Manager.Connection.GetDate

                If IsNull(e.UpdatingArgs.Row!doc_date) Then
                    e.UpdatingArgs.Row!doc_date = LibX.Data.Manager.Connection.GetDate
                End If

                '--?
                Dim intLast As Integer

                Dim doc As New SGT.Inventario.Entidades.Documento("SAL")
                e.UpdatingArgs.Row!doc_number = doc.GenerateNumber("SAL", e.UpdatingArgs.Row!whse_code.ToString)
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
                'e.SQL = e.SQL
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
        ''''    If Not IsNull(e.row!doc_status) Then
        ''''        Me.LibXConnector1.AllowEdit = True
        ''''        Me.LibXConnector1.AllowDelete = True

        ''''        If Trim(e.row!doc_status) = "1" Then
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
            xcbo_doc_status.currValue = 2
            Me.txtwhse_code.Text = LibX.User.WhDefault
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

                Dim Existe As Decimal = 0
                ''If Trim(Me.gColExist.GetValue) <> "" Then
                ''    If ValidarCantidad() = False Then
                ''        Throw New Exception("La cantidad no puede ser mayor que la existencia")
                ''    End If
                ''    Existe = Me.gColExist.GetValue
                ''End If

                ''If e.value > Existe Then
                ''    Throw New Exception("La cantidad no puede ser mayor que la existencia")
                ''End If

                Dim valor As Integer = 0
                Dim Qty As Integer = e.value

                If Trim(Me.LibXGridDetalle.GetValue(Me.gcolPrice)) <> "" Then
                    valor = Me.LibXGridDetalle.GetValue(gcolPrice)
                End If
                If Trim(Me.LibXGridDetalle.GetValue(Me.gColITem_code)) = "" Then
                    lblentrada.Text = ""
                End If

                'LibXGridDetalle.SetValue(gcolImporte, valor * Qty)
                'Calcular()
            End If

            If Me.gcolPrice.Column = e.cell Then

                Dim valor As Integer = 0
                Dim Qty As Integer = e.value

                If Trim(Me.LibXGridDetalle.GetValue(Me.gcolPrice)) <> "" Then
                    valor = Me.LibXGridDetalle.GetValue(gcolPrice)
                End If

                'LibXGridDetalle.SetValue(gcolImporte, valor * Qty)
                'Calcular()
            End If

            If Me.gColITem_code.Column = e.cell Then
                If IsNull(e.value) Then
                    e.hasErrors = True
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            e.hasErrors = True
            Log.Show(ex)
        Finally
            CalcularITBIS()
            ActualizaTotal()
        End Try
    End Sub

    Private Sub Calcular()
        Dim Total As Decimal = 0
        Try

            Total = ivdocsd.Compute("sum(Importe)", "")

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
            Me.ButtonVencimiento.Enabled = Not e.isDataEditing And LibXConnector1.HasRecords
            Me.btnDisk.Enabled = Not e.isDataEditing And LibXConnector1.HasRecords

            If e.action = LibxConnectionActions.Edit Then
                If Val(LibXConnector1.CurrentDataRow!doc_status.ToString.Trim) <> 2 Then
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

                lblentrada.Text = FindCantidaEntada(e.row!item_code.ToString.Trim)
                'Me.LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.gcolunit_code, e.row!unit_code)
                Me.LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.gcolunit_code, e.row!unit_code)
                Me.LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.gcolPrice, e.row!price)
                Me.LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.gColCosto, e.row!purch_cost)
                Me.LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.gColFactor, e.row!factor)
                Vence = GetVencimiento(e.row!item_code.ToString.Trim)
                lblVencimiento.Text = Vence
                Me.LibXGridDetalle.SetValue(Me.gColVencimiento, Vence)
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
            ''If FindCompExistencia(e.UpdatingArgs.Row!qty, e.UpdatingArgs.Row!item_code, e.UpdatingArgs.Row!whse_code, e.UpdatingArgs.Row!unit_code) = False Then
            ''    Throw New XException("Hay productos con la cantidad mayor que la existencia, Verifique")
            ''End If

            e.UpdatingArgs.Row!whse_code = Val(txtwhse_code.Text)
        Catch ex As Exception
            Log.Add(ex)
        End Try
    End Sub

    Private Sub i_ivsalid01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ScDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibXScDefault").ToString)
            DataSet1.Tables("ivdocsd").Columns("Importe").Expression = "isnull(qty,0)*isnull(costo,0)"
            LibXGridDetalle.footerOperations.add("importe", "sum(importe)")
            LibXGridDetalle.footerOperations.add("itbis", "sum(itbis)")
            WhDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibXWhDefault").ToString)

            '//ivdocsd.Columns("importe").Expression = "isnull(qty,0)*isnull(costo,0)"
        Catch ex As Exception
            Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            e.AditionalWhere = "type_code='SAL'"
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub ButtonVencimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVencimiento.Click
        Dim oParam As LibX.LibxPrgParams
        Try

            oParam = New LibX.LibxPrgParams
            With oParam
                .AllowDelete = True
                .AllowEdit = True
                .AllowNew = False
                .AllowQuery = False
                .IsFromOther = True
                '.initMode = LibxInitModes.Edit
                .WhereToExecute = "doc_serial = " & LibXConnector1.CurrentDataRow!doc_serial & " and type_code ='SAL'"
            End With

            LibX.App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("i_ivcmtod", "INV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        ''Dim itemCode As String = ""

        Try

            For Each oRow As DataRow In ivdocsd.Rows
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
                    If e.row!doc_status <> 2 Then '// Pendiente de Aplicar
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
                oParam.UnidadOrigen = LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gcolunit_code)

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
                Costo = LibX.Data.Manager.GetScalar(" select purch_cost from ivitemv1 where item_code = '" & oParam.Producto & "'")
                Costo = Costo * oParam.Retorno.Factor
                LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, gColCosto, Costo)
                LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, gColFactor, Factor)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            CalcularITBIS()
            ActualizaTotal()
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

    Private Sub ivdocsd_ColumnChanging(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles ivdocsd.ColumnChanging
        If e.Column.ColumnName = "unit_code" Then
            mUnid = e.Row!unit_code.ToString.Trim
        End If

    End Sub

    Private Sub LibXConnector1_SettingDefaulteditValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultEditValues) Handles LibXConnector1.SettingDefaulteditValues
        Try
            If LibXConnector1.IsDataEditing = True Then

                For Each oRow As DataRow In Me.ivdocsd.Rows
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
            oRow = ivdocsd.Select("item_code = '" & pitem_code.Trim & "'")

            If oRow.Length <= 0 Then
                Return False
            End If

            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
    Private Function FindCompExistencia(ByVal Qty As Integer, ByVal pitem_code As String, ByVal whse As Integer, ByVal Unid As String) As Boolean
        Dim Existe As Integer
        Dim factor As Decimal
        Try
            Existe = LibX.Data.Manager.GetScalar("select existencia from ivitemd where item_code ='" & pitem_code & "'and " & _
                                       " whse_code = " & whse)
            If Existe <= 0 Then
                Return False
            End If

            factor = LibX.Data.Manager.GetScalar("select factor from ivunitd where item_code ='" & pitem_code & "'" & _
                                       " and unit_code = '" & Unid & "'")
            If factor <= 0 Then
                Return False
            End If

            If Existe / factor < Qty Then
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

            If Val(LibXGridDetalle.GetValue(Index, Me.gcolPrice)) <= 0 Then
                Exit Sub
            End If

            oParamItbis = New SGT.Inventario.Entidades.Articulo.ParametrosCalcularItbis

            oProducto = New SGT.Inventario.Entidades.Articulo

            Qty = Val(LibXGridDetalle.GetValue(Index, Me.gColQty).ToString)
            Price = Val(LibXGridDetalle.GetValue(Index, Me.gcolPrice).ToString)
            'Descto = Val(LibXGridDetalle.GetValue(Index, Me.gColCosto).ToString)
            Descto = Price - Val(LibXGridDetalle.GetValue(Index, Me.gColCosto).ToString)


            With oParamItbis
                .Producto = LibXGridDetalle.Item(Index, 0)
                .Almacen = LibXGridDetalle.Item(Index, 1)
                .Monto = (Qty * Price) - Descto
            End With

            Itbis = oProducto.CalcularItbis(oParamItbis)

            LibXGridDetalle.SetValue(Index, Me.gColItbis, Itbis)

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

                oValue = Me.LibXGridDetalle.GetValue(i, Me.gColItbis)
                If Not IsNull(oValue) Then
                    itb = oValue
                End If

                oValue = Me.LibXGridDetalle.GetValue(i, Me.gColQty)
                If Not IsNull(oValue) Then
                    oCant = oValue
                End If

                oValue = Me.LibXGridDetalle.GetValue(i, Me.gcolPrice)
                If Not IsNull(oValue) Then
                    oPrice = oValue
                End If

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
            Me.xtxt_itbis_amount.Text = Titb.ToString("###,###,##0.00")
            Me.xtxt_net_amount.Text = CDec(total + Titb).ToString("###,###,##0.00")

        Catch ex As Exception
            Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        If e.AcceptedAction = LibxConnectionActions.Add Or e.AcceptedAction = LibxConnectionActions.Edit Then
            ActualizaTotal()
        End If

    End Sub

    Private Sub ftfactd_RowDeleted(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles ivdocsd.RowDeleted
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

    Private Sub btnDisk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisk.Click
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

        TempDirectory = System.Configuration.ConfigurationSettings.AppSettings("Libxtemp")

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
                xtxt_term_code.Text = e.row!term_code.ToString.Trim
                Me.xlk_term_code.ExecuteFind()
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Public Function FindCantidaEntada(ByVal sItem As String) As Integer
        Dim esQty As Integer
        Dim XSelect As LibX.Data.XSelecStmt
        Try
            esQty = LibX.Data.Manager.GetScalar("select isnull(sum(entrada),0)as qty " & _
                                    " from vw_iventrdp where item_code ='" & sItem.ToString.Trim & "'")

            Return esQty

        Catch ex As Exception
            LibX.Log.Add(ex)
        Finally

        End Try
    End Function

End Class

