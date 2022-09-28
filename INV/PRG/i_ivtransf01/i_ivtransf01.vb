Imports LibX
Imports SGT.Inventario.Entidades
Imports SGT.Inventario.Entidades.Documento

Public Class i_ivtransf01
    Inherits System.Windows.Forms.Form
    Dim oDoc As SGT.Inventario.Entidades.Documento
    Dim ScDefault As Integer
    Dim sFactor As Decimal
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
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents XTextBox4 As LibX.XTextBox
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
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents lkItem_code As LibX.LibXLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
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
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents gColITem_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents gColitem_name As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents txtwhse_code As LibX.XTextBox
    Friend WithEvents txtwhse_name As LibX.XTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnProduct As System.Windows.Forms.Button
    Friend WithEvents btnCostos As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents xcbo_doc_status As LibX.LibXCombo
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents LibXGridDetalle As LibX.LibXGrid
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents ButtonVencimiento As System.Windows.Forms.Button
    Friend WithEvents gColCantidad As LibX.XEditTextBoxColumn
    Friend WithEvents gColImporte As LibX.XEditTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents gbx_Origen As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Desino As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents xlk_whse_dest As LibX.LibXLookup
    Friend WithEvents txtwhdest_name As LibX.XTextBox
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents lblitem_namedestino As System.Windows.Forms.Label
    Friend WithEvents gcolCosto As LibX.XEditTextBoxColumn
    Private WithEvents lblitem_nameorigen As System.Windows.Forms.Label
    Friend WithEvents lblcosto As System.Windows.Forms.Label
    Friend WithEvents lblunidad As System.Windows.Forms.Label
    Friend WithEvents lblexistencia As System.Windows.Forms.Label
    Friend WithEvents txtwhse_dest As LibX.XTextBox
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents ivdocsm As System.Data.DataTable
    Friend WithEvents ivdocsd As System.Data.DataTable
    Friend WithEvents gcolunit_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents xlk_unit_code As LibX.LibXLookup
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents gColVencimiento As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents gColfactor As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents gColdoc_serial As LibX.XEditTextBoxColumn
    Friend WithEvents gColExistencia As LibX.XEditTextBoxColumn
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
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
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
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.XTextBox4 = New LibX.XTextBox
        Me.lkItem_code = New LibX.LibXLookup
        Me.Label8 = New System.Windows.Forms.Label
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.LibXGridDetalle = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColdoc_serial = New LibX.XEditTextBoxColumn
        Me.gColITem_code = New LibX.XDataGridTextButtonColumn
        Me.gColitem_name = New LibX.XEditTextBoxColumn
        Me.gColVencimiento = New LibX.XEditTextBoxColumn
        Me.gColCantidad = New LibX.XEditTextBoxColumn
        Me.gcolunit_code = New LibX.XDataGridTextButtonColumn
        Me.xlk_unit_code = New LibX.LibXLookup
        Me.gcolCosto = New LibX.XEditTextBoxColumn
        Me.gColfactor = New LibX.XEditTextBoxColumn
        Me.gColImporte = New LibX.XEditTextBoxColumn
        Me.gColExistencia = New LibX.XEditTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.txtwhse_code = New LibX.XTextBox
        Me.txtwhse_name = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.xlk_whse_dest = New LibX.LibXLookup
        Me.txtwhse_dest = New LibX.XTextBox
        Me.txtwhdest_name = New LibX.XTextBox
        Me.xcbo_doc_status = New LibX.LibXCombo
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.btnProduct = New System.Windows.Forms.Button
        Me.btnCostos = New System.Windows.Forms.Button
        Me.lblitem_nameorigen = New System.Windows.Forms.Label
        Me.ButtonVencimiento = New System.Windows.Forms.Button
        Me.gbx_Origen = New System.Windows.Forms.GroupBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.gbx_Desino = New System.Windows.Forms.GroupBox
        Me.lblcosto = New System.Windows.Forms.Label
        Me.lblunidad = New System.Windows.Forms.Label
        Me.lblexistencia = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.lblitem_namedestino = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivdocsm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivdocsd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbx_Origen.SuspendLayout()
        Me.gbx_Desino.SuspendLayout()
        Me.SuspendLayout()
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(938, 24)
        Me.LibXNavigator1.TabIndex = 1
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
        Me.LibXConnector1.ModuleName = Nothing
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = Nothing
        Me.LibXConnector1.ReportObject = Nothing
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
        Me.ivdocsm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn27, Me.DataColumn28, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn38})
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
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "item_code"
        Me.DataColumn12.MaxLength = 15
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "qty"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "total_amount"
        Me.DataColumn27.DataType = GetType(System.Decimal)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "whse_dest"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "term_code"
        Me.DataColumn34.MaxLength = 5
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "doc_cond"
        Me.DataColumn35.DataType = GetType(System.Int32)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "itbis_amount"
        Me.DataColumn36.DataType = GetType(System.Decimal)
        '
        'DataColumn38
        '
        Me.DataColumn38.AllowDBNull = False
        Me.DataColumn38.ColumnName = "suc_code"
        Me.DataColumn38.DataType = GetType(System.Int32)
        '
        'ivdocsd
        '
        Me.ivdocsd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn37, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42})
        Me.ivdocsd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"doc_serial", "line_no", "suc_code"}, True)})
        Me.ivdocsd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn14, Me.DataColumn15, Me.DataColumn39}
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
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "existencia"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "whse_name"
        Me.DataColumn25.MaxLength = 30
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "importe"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "dest_item_name"
        Me.DataColumn29.MaxLength = 100
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "dest_existencia"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.AllowDBNull = False
        Me.DataColumn31.ColumnName = "dest_unit_code"
        Me.DataColumn31.MaxLength = 4
        '
        'DataColumn32
        '
        Me.DataColumn32.AllowDBNull = False
        Me.DataColumn32.ColumnName = "dest_purch_cost"
        Me.DataColumn32.DataType = GetType(System.Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.Caption = "vencimiento"
        Me.DataColumn33.ColumnName = "vencimiento"
        Me.DataColumn33.MaxLength = 20
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "itbis"
        Me.DataColumn37.DataType = GetType(System.Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.AllowDBNull = False
        Me.DataColumn39.ColumnName = "suc_code"
        Me.DataColumn39.DataType = GetType(System.Int32)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "factor"
        Me.DataColumn40.DataType = GetType(System.Decimal)
        '
        'DataColumn41
        '
        Me.DataColumn41.AllowDBNull = False
        Me.DataColumn41.ColumnName = "dest_whse_code"
        Me.DataColumn41.DataType = GetType(System.Int32)
        '
        'DataColumn42
        '
        Me.DataColumn42.AllowDBNull = False
        Me.DataColumn42.ColumnName = "dest_item_code"
        Me.DataColumn42.MaxLength = 10
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
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"doc_serial=doc_serial", "whse_code=whse_code", "suc_code=suc_code"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select distinct ivdocsd.*,", "item_name ,whse_name", "from ivdocsd,ivitemv1,ivwhsem ", "Where ivdocsd.item_code=ivitemv1.item_code", "and ivdocsd.whse_code = ivwhsem.whse_code"}
        Me.LibXDbSourceTable2.TableName = "ivdocsd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(56, 88)
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
        Me.Label6.Location = New System.Drawing.Point(77, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Número:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsm.doc_number"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = True
        Me.XTextBox1.Location = New System.Drawing.Point(136, 16)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(72, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 0
        Me.XTextBox1.Text = ""
        '
        'XTextBox4
        '
        Me.XTextBox4.AcceptsReturn = True
        Me.XTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsm.nota"))
        Me.XTextBox4.EditInitialValue = Nothing
        Me.XTextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.FieldDescription = ""
        Me.XTextBox4.FindInitialValue = Nothing
        Me.XTextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.IgnoreRequiered = False
        Me.XTextBox4.Location = New System.Drawing.Point(136, 88)
        Me.XTextBox4.Multiline = True
        Me.XTextBox4.Name = "XTextBox4"
        Me.XTextBox4.NewInitialValue = Nothing
        Me.XTextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.Requiered = False
        Me.XTextBox4.Size = New System.Drawing.Size(440, 48)
        Me.XTextBox4.StatusBarPanelDescripcion = Nothing
        Me.XTextBox4.TabIndex = 3
        Me.XTextBox4.Text = ""
        '
        'lkItem_code
        '
        Me.lkItem_code.AlternateFieldSearch = Nothing
        Me.lkItem_code.BeginCheck = False
        Me.lkItem_code.CheckText = Nothing
        Me.lkItem_code.ComboMode = False
        Me.lkItem_code.DataMember = "ivdocsd"
        Me.lkItem_code.DataSource = Me.LibXConnector1
        Me.lkItem_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "costo=purch_cost", "unit_code=unit_code", "price=price", "bf_onhand=existencia", "dest_item_name=dest_item_name", "dest_existencia=dest_existencia", "dest_unit_code=dest_unit_code", "dest_purch_cost=dest_purch_cost"}
        Me.lkItem_code.FilterField = "ivitemv1.item_name"
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
        Me.lkItem_code.SizesColumns = Nothing
        Me.lkItem_code.SizesColumnsTab = Nothing
        Me.lkItem_code.SqlString = New String() {"Select ", "ivitemv1.item_code,", "ivitemv1.item_name,", "ivitemv1.existencia,", "ivitemv1.unit_code,", "ivitemv1.purch_cost,", "ivitemv1.price,", "ivunitd.factor,", "ivitemv2.whse_code as dest_whse_code,", "ivitemv2.item_code as dest_item_code,", "ivitemv2.item_name as dest_item_name,", "ivitemv2.existencia as dest_existencia,", "ivitemv2.unit_code as dest_unit_code,", "ivitemv2.purch_cost as dest_purch_cost", " From ivitemv1 inner join ivitemv1 ivitemv2 ", "on ivitemv1.item_code = ivitemv2.item_code", "and ivitemv1.whse_code <> ivitemv2.whse_code ", "inner join ivunitd on ivitemv1.item_code = ivunitd.item_code", "        and ivitemv1.unit_code = ivunitd.unit_code"}
        Me.lkItem_code.SQLTab = Nothing
        Me.lkItem_code.SrcParameters = New String() {"item_code=item_code"}
        Me.lkItem_code.TabIndex = 6
        Me.lkItem_code.TableName = "ivitemv1"
        Me.lkItem_code.TabStop = False
        Me.lkItem_code.UseCopyConnection = False
        Me.lkItem_code.UseRowRetrieveEvents = False
        Me.lkItem_code.UseTab = False
        Me.lkItem_code.VisParameters = New String() {"Código=item_code", "Nombre=item_name", "Costo =purch_cost", "Existencia=existencia"}
        Me.lkItem_code.WhereCondition = "ivitemv1.item_status =1 and  ivitemv1.existencia >0"
        Me.lkItem_code.WhereParameters = Nothing
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(733, 16)
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
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(784, 16)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = "now"
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
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
        Me.LibXGridDetalle.Size = New System.Drawing.Size(920, 256)
        Me.LibXGridDetalle.TabIndex = 2
        Me.LibXGridDetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGridDetalle.UseAutoFillLines = True
        Me.LibXGridDetalle.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGridDetalle
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColdoc_serial, Me.gColITem_code, Me.gColitem_name, Me.gColVencimiento, Me.gColCantidad, Me.gcolunit_code, Me.gcolCosto, Me.gColfactor, Me.gColImporte, Me.gColExistencia})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivdocsd"
        Me.XdataGridTableStyle1.RowHeaderWidth = 15
        '
        'gColdoc_serial
        '
        Me.gColdoc_serial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColdoc_serial.Format = ""
        Me.gColdoc_serial.FormatInfo = Nothing
        Me.gColdoc_serial.ImageList = Nothing
        Me.gColdoc_serial.isReadOnly = False
        Me.gColdoc_serial.MappingName = "doc_serial"
        Me.gColdoc_serial.MaxLength = 32767
        Me.gColdoc_serial.TabStop = True
        Me.gColdoc_serial.UseCustomCellFormat = False
        Me.gColdoc_serial.Width = 0
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
        Me.gColITem_code.Width = 102
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
        Me.gColitem_name.Width = 300
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
        Me.gColVencimiento.Width = 101
        '
        'gColCantidad
        '
        Me.gColCantidad.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColCantidad.Format = "###,###"
        Me.gColCantidad.FormatInfo = Nothing
        Me.gColCantidad.HeaderText = "Cantidadi"
        Me.gColCantidad.ImageList = Nothing
        Me.gColCantidad.isReadOnly = False
        Me.gColCantidad.MappingName = "qty"
        Me.gColCantidad.MaxLength = 32767
        Me.gColCantidad.TabStop = True
        Me.gColCantidad.UseCustomCellFormat = False
        Me.gColCantidad.Width = 80
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
        Me.gcolunit_code.Width = 101
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
        Me.xlk_unit_code.FilterField = Nothing
        Me.xlk_unit_code.IgnoreFindInBrowseMode = True
        Me.xlk_unit_code.isCanceled = False
        Me.xlk_unit_code.Location = New System.Drawing.Point(461, 298)
        Me.xlk_unit_code.LookCaption = Nothing
        Me.xlk_unit_code.Name = "xlk_unit_code"
        Me.xlk_unit_code.PopupSize = New System.Drawing.Size(450, 300)
        Me.xlk_unit_code.ShowFilter = True
        Me.xlk_unit_code.ShowMessageNotFound = True
        Me.xlk_unit_code.ShowWarning = False
        Me.xlk_unit_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_unit_code.SizesColumns = New String() {"unit_name=250"}
        Me.xlk_unit_code.SizesColumnsTab = Nothing
        Me.xlk_unit_code.SqlString = Nothing
        Me.xlk_unit_code.SQLTab = Nothing
        Me.xlk_unit_code.SrcParameters = New String() {"unit_code=unit_code"}
        Me.xlk_unit_code.TabIndex = 35
        Me.xlk_unit_code.TableName = "ivunitv"
        Me.xlk_unit_code.TabStop = False
        Me.xlk_unit_code.UseCopyConnection = False
        Me.xlk_unit_code.UseRowRetrieveEvents = False
        Me.xlk_unit_code.UseTab = False
        Me.xlk_unit_code.VisParameters = New String() {"Codigo=unit_code", "Unidad=unit_name", "Factor=factor"}
        Me.xlk_unit_code.WhereCondition = Nothing
        Me.xlk_unit_code.WhereParameters = Nothing
        '
        'gcolCosto
        '
        Me.gcolCosto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gcolCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolCosto.Format = "###,##0.00"
        Me.gcolCosto.FormatInfo = Nothing
        Me.gcolCosto.HeaderText = "Costoi"
        Me.gcolCosto.ImageList = Nothing
        Me.gcolCosto.isReadOnly = False
        Me.gcolCosto.MappingName = "costo"
        Me.gcolCosto.MaxLength = 32767
        Me.gcolCosto.ReadOnly = True
        Me.gcolCosto.TabStop = True
        Me.gcolCosto.UseCustomCellFormat = False
        Me.gcolCosto.Width = 101
        '
        'gColfactor
        '
        Me.gColfactor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColfactor.Format = ""
        Me.gColfactor.FormatInfo = Nothing
        Me.gColfactor.ImageList = Nothing
        Me.gColfactor.isReadOnly = False
        Me.gColfactor.MappingName = "factor"
        Me.gColfactor.MaxLength = 32767
        Me.gColfactor.TabStop = True
        Me.gColfactor.UseCustomCellFormat = False
        Me.gColfactor.Width = 0
        '
        'gColImporte
        '
        Me.gColImporte.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColImporte.Format = "##,##0.00"
        Me.gColImporte.FormatInfo = Nothing
        Me.gColImporte.HeaderText = "Importei"
        Me.gColImporte.ImageList = Nothing
        Me.gColImporte.isReadOnly = True
        Me.gColImporte.MappingName = "importe"
        Me.gColImporte.MaxLength = 32767
        Me.gColImporte.TabStop = True
        Me.gColImporte.UseCustomCellFormat = False
        Me.gColImporte.Width = 101
        '
        'gColExistencia
        '
        Me.gColExistencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColExistencia.Format = ""
        Me.gColExistencia.FormatInfo = Nothing
        Me.gColExistencia.ImageList = Nothing
        Me.gColExistencia.isReadOnly = False
        Me.gColExistencia.MappingName = "existencia"
        Me.gColExistencia.MaxLength = 32767
        Me.gColExistencia.TabStop = True
        Me.gColExistencia.UseCustomCellFormat = False
        Me.gColExistencia.Width = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(36, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Almacén Origen:"
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
        Me.LibXLookup3.DestParameters = New String() {"whse_code=whse_code", "txtwhse_name=whse_name"}
        Me.LibXLookup3.FilterField = Nothing
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.isCanceled = False
        Me.LibXLookup3.Location = New System.Drawing.Point(560, 40)
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
        Me.txtwhse_code.Location = New System.Drawing.Point(136, 40)
        Me.txtwhse_code.Name = "txtwhse_code"
        Me.txtwhse_code.NewInitialValue = Nothing
        Me.txtwhse_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.Requiered = False
        Me.txtwhse_code.Size = New System.Drawing.Size(72, 20)
        Me.txtwhse_code.StatusBarPanelDescripcion = Nothing
        Me.txtwhse_code.TabIndex = 1
        Me.txtwhse_code.Text = ""
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
        Me.txtwhse_name.Location = New System.Drawing.Point(216, 40)
        Me.txtwhse_name.Name = "txtwhse_name"
        Me.txtwhse_name.NewInitialValue = Nothing
        Me.txtwhse_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_name.ReadOnly = True
        Me.txtwhse_name.Requiered = False
        Me.txtwhse_name.Size = New System.Drawing.Size(344, 20)
        Me.txtwhse_name.StatusBarPanelDescripcion = Nothing
        Me.txtwhse_name.TabIndex = 27
        Me.txtwhse_name.TabStop = False
        Me.txtwhse_name.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xlk_whse_dest)
        Me.GroupBox1.Controls.Add(Me.txtwhse_dest)
        Me.GroupBox1.Controls.Add(Me.txtwhdest_name)
        Me.GroupBox1.Controls.Add(Me.xcbo_doc_status)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.XTextBox4)
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
        Me.GroupBox1.Location = New System.Drawing.Point(11, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(917, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(32, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Almacén Destino:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_whse_dest
        '
        Me.xlk_whse_dest.AlternateFieldSearch = Nothing
        Me.xlk_whse_dest.BeginCheck = False
        Me.xlk_whse_dest.CheckText = Nothing
        Me.xlk_whse_dest.ComboMode = False
        Me.xlk_whse_dest.DataMember = Nothing
        Me.xlk_whse_dest.DataSource = Me.LibXConnector1
        Me.xlk_whse_dest.DestParameters = New String() {"whse_dest=whse_code", "txtwhdest_name=whse_name"}
        Me.xlk_whse_dest.FilterField = Nothing
        Me.xlk_whse_dest.IgnoreFindInBrowseMode = False
        Me.xlk_whse_dest.isCanceled = False
        Me.xlk_whse_dest.Location = New System.Drawing.Point(560, 64)
        Me.xlk_whse_dest.LookCaption = "Almacenes"
        Me.xlk_whse_dest.Name = "xlk_whse_dest"
        Me.xlk_whse_dest.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_whse_dest.ShowFilter = True
        Me.xlk_whse_dest.ShowMessageNotFound = True
        Me.xlk_whse_dest.ShowWarning = False
        Me.xlk_whse_dest.Size = New System.Drawing.Size(16, 20)
        Me.xlk_whse_dest.SizesColumns = Nothing
        Me.xlk_whse_dest.SizesColumnsTab = Nothing
        Me.xlk_whse_dest.SqlString = Nothing
        Me.xlk_whse_dest.SQLTab = Nothing
        Me.xlk_whse_dest.SrcParameters = New String() {"whse_dest=whse_code"}
        Me.xlk_whse_dest.TabIndex = 29
        Me.xlk_whse_dest.TableName = "ivwhsem"
        Me.xlk_whse_dest.TabStop = False
        Me.xlk_whse_dest.UseCopyConnection = False
        Me.xlk_whse_dest.UseRowRetrieveEvents = False
        Me.xlk_whse_dest.UseTab = False
        Me.xlk_whse_dest.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.xlk_whse_dest.WhereCondition = Nothing
        Me.xlk_whse_dest.WhereParameters = Nothing
        '
        'txtwhse_dest
        '
        Me.txtwhse_dest.AcceptsReturn = True
        Me.txtwhse_dest.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsm.whse_dest"))
        Me.txtwhse_dest.EditInitialValue = Nothing
        Me.txtwhse_dest.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_dest.FieldDescription = ""
        Me.txtwhse_dest.FindInitialValue = Nothing
        Me.txtwhse_dest.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_dest.IgnoreRequiered = False
        Me.txtwhse_dest.Location = New System.Drawing.Point(136, 64)
        Me.txtwhse_dest.Name = "txtwhse_dest"
        Me.txtwhse_dest.NewInitialValue = Nothing
        Me.txtwhse_dest.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_dest.Requiered = False
        Me.txtwhse_dest.Size = New System.Drawing.Size(72, 20)
        Me.txtwhse_dest.StatusBarPanelDescripcion = Nothing
        Me.txtwhse_dest.TabIndex = 2
        Me.txtwhse_dest.Text = ""
        '
        'txtwhdest_name
        '
        Me.txtwhdest_name.AcceptsReturn = True
        Me.txtwhdest_name.EditInitialValue = Nothing
        Me.txtwhdest_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhdest_name.FieldDescription = ""
        Me.txtwhdest_name.FindInitialValue = Nothing
        Me.txtwhdest_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhdest_name.IgnoreRequiered = False
        Me.txtwhdest_name.Location = New System.Drawing.Point(216, 64)
        Me.txtwhdest_name.Name = "txtwhdest_name"
        Me.txtwhdest_name.NewInitialValue = Nothing
        Me.txtwhdest_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhdest_name.ReadOnly = True
        Me.txtwhdest_name.Requiered = False
        Me.txtwhdest_name.Size = New System.Drawing.Size(344, 20)
        Me.txtwhdest_name.StatusBarPanelDescripcion = Nothing
        Me.txtwhdest_name.TabIndex = 31
        Me.txtwhdest_name.TabStop = False
        Me.txtwhdest_name.Text = ""
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
        Me.xcbo_doc_status.Location = New System.Drawing.Point(784, 40)
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
        Me.xcbo_doc_status.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(727, 40)
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
        Me.Label7.Location = New System.Drawing.Point(726, 64)
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
        Me.XTextBox2.Location = New System.Drawing.Point(784, 64)
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
        Me.Label9.Location = New System.Drawing.Point(728, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Creado:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label9.Visible = False
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
        Me.XTextBox3.Location = New System.Drawing.Point(784, 88)
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
        Me.XTextBox3.Visible = False
        '
        'btnProduct
        '
        Me.btnProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProduct.Location = New System.Drawing.Point(88, 600)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.TabIndex = 3
        Me.btnProduct.Text = "Producto"
        '
        'btnCostos
        '
        Me.btnCostos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCostos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCostos.Location = New System.Drawing.Point(168, 600)
        Me.btnCostos.Name = "btnCostos"
        Me.btnCostos.TabIndex = 4
        Me.btnCostos.Text = "Costos"
        '
        'lblitem_nameorigen
        '
        Me.lblitem_nameorigen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblitem_nameorigen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblitem_nameorigen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsd.item_name"))
        Me.lblitem_nameorigen.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblitem_nameorigen.Location = New System.Drawing.Point(80, 23)
        Me.lblitem_nameorigen.Name = "lblitem_nameorigen"
        Me.lblitem_nameorigen.Size = New System.Drawing.Size(368, 20)
        Me.lblitem_nameorigen.TabIndex = 32
        '
        'ButtonVencimiento
        '
        Me.ButtonVencimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonVencimiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonVencimiento.Location = New System.Drawing.Point(8, 600)
        Me.ButtonVencimiento.Name = "ButtonVencimiento"
        Me.ButtonVencimiento.TabIndex = 3
        Me.ButtonVencimiento.Text = "Vencimiento"
        '
        'gbx_Origen
        '
        Me.gbx_Origen.Controls.Add(Me.Label22)
        Me.gbx_Origen.Controls.Add(Me.Label21)
        Me.gbx_Origen.Controls.Add(Me.Label20)
        Me.gbx_Origen.Controls.Add(Me.Label13)
        Me.gbx_Origen.Controls.Add(Me.Label12)
        Me.gbx_Origen.Controls.Add(Me.Label11)
        Me.gbx_Origen.Controls.Add(Me.Label10)
        Me.gbx_Origen.Controls.Add(Me.lblitem_nameorigen)
        Me.gbx_Origen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Origen.Location = New System.Drawing.Point(8, 472)
        Me.gbx_Origen.Name = "gbx_Origen"
        Me.gbx_Origen.Size = New System.Drawing.Size(456, 80)
        Me.gbx_Origen.TabIndex = 33
        Me.gbx_Origen.TabStop = False
        Me.gbx_Origen.Text = "Almacen Origen"
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsd.costo"))
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label22.Location = New System.Drawing.Point(368, 47)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 20)
        Me.Label22.TabIndex = 39
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsd.unit_code"))
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Location = New System.Drawing.Point(224, 47)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 20)
        Me.Label21.TabIndex = 38
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsd.bf_onhand"))
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label20.Location = New System.Drawing.Point(80, 47)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 20)
        Me.Label20.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(320, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 16)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Costo"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(168, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 16)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Unidad"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(8, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 16)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Existencia:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(14, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 16)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Producto:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gbx_Desino
        '
        Me.gbx_Desino.Controls.Add(Me.lblcosto)
        Me.gbx_Desino.Controls.Add(Me.lblunidad)
        Me.gbx_Desino.Controls.Add(Me.lblexistencia)
        Me.gbx_Desino.Controls.Add(Me.Label18)
        Me.gbx_Desino.Controls.Add(Me.Label23)
        Me.gbx_Desino.Controls.Add(Me.Label24)
        Me.gbx_Desino.Controls.Add(Me.Label25)
        Me.gbx_Desino.Controls.Add(Me.lblitem_namedestino)
        Me.gbx_Desino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Desino.Location = New System.Drawing.Point(472, 472)
        Me.gbx_Desino.Name = "gbx_Desino"
        Me.gbx_Desino.Size = New System.Drawing.Size(456, 81)
        Me.gbx_Desino.TabIndex = 34
        Me.gbx_Desino.TabStop = False
        Me.gbx_Desino.Text = "Almacen Destino"
        '
        'lblcosto
        '
        Me.lblcosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcosto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsd.dest_purch_cost"))
        Me.lblcosto.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblcosto.Location = New System.Drawing.Point(368, 49)
        Me.lblcosto.Name = "lblcosto"
        Me.lblcosto.Size = New System.Drawing.Size(80, 20)
        Me.lblcosto.TabIndex = 39
        '
        'lblunidad
        '
        Me.lblunidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblunidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblunidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsd.dest_unit_code"))
        Me.lblunidad.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblunidad.Location = New System.Drawing.Point(224, 49)
        Me.lblunidad.Name = "lblunidad"
        Me.lblunidad.Size = New System.Drawing.Size(80, 20)
        Me.lblunidad.TabIndex = 38
        '
        'lblexistencia
        '
        Me.lblexistencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblexistencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblexistencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsd.dest_existencia"))
        Me.lblexistencia.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblexistencia.Location = New System.Drawing.Point(80, 49)
        Me.lblexistencia.Name = "lblexistencia"
        Me.lblexistencia.Size = New System.Drawing.Size(80, 20)
        Me.lblexistencia.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(320, 49)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 16)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Costo"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(168, 49)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(41, 16)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "Unidad"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label24.Location = New System.Drawing.Point(8, 49)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 16)
        Me.Label24.TabIndex = 33
        Me.Label24.Text = "Existencia:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label25.Location = New System.Drawing.Point(14, 25)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(55, 16)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "Producto:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblitem_namedestino
        '
        Me.lblitem_namedestino.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblitem_namedestino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblitem_namedestino.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdocsd.dest_item_name"))
        Me.lblitem_namedestino.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblitem_namedestino.Location = New System.Drawing.Point(80, 25)
        Me.lblitem_namedestino.Name = "lblitem_namedestino"
        Me.lblitem_namedestino.Size = New System.Drawing.Size(368, 20)
        Me.lblitem_namedestino.TabIndex = 32
        '
        'i_ivtransf01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(938, 640)
        Me.Controls.Add(Me.xlk_unit_code)
        Me.Controls.Add(Me.gbx_Desino)
        Me.Controls.Add(Me.gbx_Origen)
        Me.Controls.Add(Me.btnCostos)
        Me.Controls.Add(Me.btnProduct)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXGridDetalle)
        Me.Controls.Add(Me.lkItem_code)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.ButtonVencimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivtransf01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Transaferencia de Existencia Inventario"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivdocsm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivdocsd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_Origen.ResumeLayout(False)
        Me.gbx_Desino.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try

            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                e.UpdatingArgs.Row!type_code = "TRF"
                e.UpdatingArgs.Row!doc_status = 2 'pendiente de aplicar

                e.UpdatingArgs.Row!date_created = LibX.Data.Manager.Connection.GetDate

                If IsNull(e.UpdatingArgs.Row!doc_date) Then
                    e.UpdatingArgs.Row!doc_date = LibX.Data.Manager.Connection.GetDate
                End If

                '--?
                e.UpdatingArgs.Row!doc_type = DBNull.Value
                e.UpdatingArgs.Row!suc_code = ScDefault

                Dim intLast As Integer

                Dim doc As New SGT.Inventario.Entidades.Documento("TRF")
                e.UpdatingArgs.Row!doc_number = doc.GenerateNumber("TRF")

            End If

        Catch ex As Exception
            Log.Add(ex)
        End Try
    End Sub
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
                    Throw New ApplicationException("Este producto esta registrado en la Linea   " & ProductoExistePocision(e.row!item_code))
                End If
            End If

        Catch ex As Exception
            e.handled = True
            LibXGridDetalle.Focus(LibXGridDetalle.CurrentRowIndex, 0)
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub xlk_unit_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_unit_code.BeforeExecuteQuery
        Try
            e.aditionalWhere = "item_code = '" & LibXGridDetalle.GetValue(gColITem_code) & "'"
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub xlk_unit_code_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_unit_code.BeforeSetValues
        Dim Costo As Decimal
        Dim Factor As Decimal
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

                oParam.Valor = LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gcolCosto)
                oParam.Producto = LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColITem_code)
                oParam.UnidadDestino = e.row!unit_code
                oParam.UnidadOrigen = LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gcolunit_code)

                oUnidad.ConvertirValor(oParam)

                LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, gcolCosto, oParam.Retorno.Valor)
                LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, gColfactor, oParam.Retorno.Factor)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub lkItem_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lkItem_code.BeforeExecuteQuery
        Try
            If Trim(Me.txtwhse_code.Text) <> "" Then
                e.aditionalWhere = " ivitemv1.whse_code =" & Trim(Me.txtwhse_code.Text) & " and ivitemv2.whse_code = " & Trim(Me.txtwhse_dest.Text)
            End If

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_RowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange
        Try
            If e.row Is Nothing Then
                Exit Sub
            End If
            If Not IsNull(e.row!doc_status) Then
                Me.LibXConnector1.AllowEdit = True
                Me.LibXConnector1.AllowDelete = True

                If Trim(e.row!doc_status) = "1" Then
                    Me.LibXConnector1.AllowDelete = False
                    Me.LibXConnector1.AllowEdit = False
                End If
                Me.LibXNavigator1.UpdateState()
            End If

        Catch ex As Exception
            Log.Show(ex)
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

    Private Sub LibXGridDetalle_CellValidate(ByVal sender As System.Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGridDetalle.CellValidate
        Dim dIsponible As Integer
        Try
            '// Validar la cantidad

            If Me.gColCantidad.Column = e.cell Then
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

                If e.cell = LibXGridDetalle.GetColNum(gColCantidad) Then
                    If ValidarCantidad() = False Then
                        LibXGridDetalle.SetValue(e.row, gColCantidad, LibXGridDetalle.GetValue(e.row, gColExistencia))
                        If Not LibX.IsNull(LibXGridDetalle.GetValue(e.row, gColCantidad)) Then
                            If LibXGridDetalle.GetValue(e.row, gColfactor).Trim >= 1 Then
                                dIsponible = LibXGridDetalle.GetValue(e.row, gColExistencia).Trim / LibXGridDetalle.GetValue(e.row, gColfactor).Trim
                                e.hasErrors = True
                                Throw New ApplicationException("La cantidad no puede ser mayor que la existencia actual" & vbCrLf & "Existencia = " & dIsponible & " " & LibXGridDetalle.SetValue(e.row, gcolunit_code).Trim)
                            End If
                        Else
                            If Not LibX.IsNull(LibXGridDetalle.GetValue(e.row, gColCantidad)) Then
                                dIsponible = LibXGridDetalle.SetValue(e.row, gColCantidad)
                                e.hasErrors = True
                                Throw New ApplicationException("La cantidad no puede ser mayor que la existencia actual" & vbCrLf & "Existencia = " & dIsponible & " " & LibXGridDetalle.SetValue(e.row, gcolunit_code).Trim)
                            End If
                        End If
                    End If
                End If
            End If

            If Me.gColITem_code.Column = e.cell Then
                If IsNull(e.value) Then
                    e.hasErrors = True
                    Exit Sub
                End If

            End If

        Catch ex As Exception
            e.hasErrors = True
            Log.Add(ex)
        End Try
    End Sub
    Private Function ValidarCantidad() As Boolean
        Dim Cantidad As Integer
        Dim Unidad As String
        Dim Existencia As Integer
        Dim Result As Boolean = True
        Dim Precio As Decimal
        Dim oRow As DataRow
        Dim SelectStmt As String
        Dim CantidadComprada As Integer
        Try
            'If mConfig.FacturaSinExistencia = True Then
            '    Return True
            'End If

            If LibXGridDetalle.getCurrentGridView.Count <= 0 Then
                Return True
            End If

            If LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColCantidad) = "" Then
                Return True
            End If

            Dim oUnidad As New SGT.Inventario.Entidades.UnidadMedida
            Dim oUnidadParam As New SGT.Inventario.Entidades.UnidadMedida.ParametroConvertirUnidadMinima
            '// Validar Cantidad
            If LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColdoc_serial).ToString.Trim <> "" Then
                SelectStmt = "select * from ivdocsd " & _
                             " where doc_serial = " & LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColdoc_serial).ToString.Trim & _
                             " and item_code = '" & LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColITem_code).ToString.Trim & "'"

                oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

                If Not oRow Is Nothing Then
                    Cantidad = Val(oRow!qty.ToString.Trim)
                    Unidad = oRow!unit_code.ToString.Trim

                    oUnidadParam.Producto = oRow!item_code.ToString.Trim
                    oUnidadParam.UnidadOrigen = Unidad
                    oUnidadParam.Cantidad = Cantidad

                    oUnidad.ConvertirUnidadMinima(oUnidadParam)

                    CantidadComprada = oUnidadParam.Retorno.Cantidad
                End If
            End If

            '// Validar existencia
            Cantidad = LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColCantidad)
            Unidad = LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gcolunit_code)
            Precio = LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gcolCosto)

            oUnidadParam.Producto = LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColITem_code)
            oUnidadParam.UnidadOrigen = Unidad
            oUnidadParam.Cantidad = Cantidad

            oUnidad.ConvertirUnidadMinima(oUnidadParam)
            sFactor = oUnidad.GetFactor(oUnidadParam.Producto, LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gcolunit_code))

            Existencia = LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColExistencia)

            LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, gColfactor, sFactor)

            If oUnidadParam.Retorno.Cantidad > CantidadComprada AndAlso CantidadComprada > 0 Then
                Result = False
            End If

            If oUnidadParam.Retorno.Cantidad > Existencia Then
                Result = False
            End If

            Return Result

        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Dim SelecStmt As String
        Try

            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
                Dim AxCrystalReport1 As New LibX.ReportLib("INV", "r_ivtransf01.rpt")

                With AxCrystalReport1
                    .RetrieveSQLQuery()
                    SelecStmt = .SQLQuery
                    SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, "ivdocsm.doc_serial = " & LibXConnector1.CurrentDataRow!doc_serial)
                    .SQLQuery = SelecStmt

                    .Action = 1
                End With
            End If

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

            If e.action = LibxConnectionActions.Find Then
                xcbo_doc_status.currValue = 2
            End If
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVencimiento.Click
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
                .WhereToExecute = "doc_serial = " & LibXConnector1.CurrentDataRow!doc_serial & " and type_code ='TRF'"
            End With

            LibX.App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("i_ivcmtod", "INV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_InsertedDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedDetailRow
        Try
            If e.UpdatingArgs.Row.RowState <> DataRowState.Deleted Then
                If IsNull(e.UpdatingArgs.Row!item_code) Then
                    Throw New XException("Se ha dejado un código de producto en blanco")
                End If
                e.UpdatingArgs.Row!whse_code = Val(txtwhse_code.Text)
            End If

        Catch ex As Exception
            Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        e.AditionalWhere = " ivdocsm.type_code = 'TRF' "
    End Sub
    Private Sub i_ivtransf01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ScDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibXScDefault").ToString)
        Me.DataSet1.Tables("ivdocsd").Columns("Importe").Expression = "isnull(qty,0)*isnull(costo,0)"
        Me.LibXGridDetalle.footerOperations.add("Importe", "sum(Importe)")
        ''LibXNavigator1.FirstControlInNewMode = txtwhse_code

    End Sub

    Private Sub LibXLookup3_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles LibXLookup3.AfterSetValues
        Try
            If e.dataFound = True Then
                gbx_Origen.Text = e.row!whse_name
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub xlk_whse_dest_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_whse_dest.AfterSetValues
        Try
            If e.dataFound = True Then
                gbx_Desino.Text = e.row!whse_name
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub xlk_item_dest_AfterSetValues(ByVal sender As System.Object, ByVal e As LibX.LookupValuesEventArgs)
        Try
            If e.dataFound = False Then
                Throw New ApplicationException("Este producto no existe en el almacen destino" & vbCrLf & "Producto " & txtwhse_name.Text & vbCrLf & "Almacen: " & txtwhdest_name.Text)
            End If
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

                If LibX.IsNull(oRow!item_code) Then
                    oRow.AcceptChanges()
                End If
                itemCode = oRow!item_code.ToString.Trim
            Next

        Catch ex As Exception
            e.Handled = True
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub xlk_whse_dest_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_whse_dest.BeforeExecuteQuery
        Try
            If LibXConnector1.IsDataEditing = True Then
                If txtwhse_code.Text <> "" Then
                    e.aditionalWhere = "whse_code <> " & Me.txtwhse_code.Text
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Function ProductoExiste(ByVal pitem_code As String) As Boolean
        Dim oRow As DataRow()
        Dim oSelect As String
        Dim Qty As Integer
        Try
            oRow = ivdocsd.Select("item_code = '" & pitem_code.Trim & "'")

            If oRow.Length <= 0 Then
                Return False
            End If

            If oRow.Length <= 0 Then
                Return False
            End If

            Return True

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
    Private Function ProductoExistePocision(ByVal pitem_code As String) As Integer
        Dim oSelect As String
        Dim Linea As Integer
        Try
            For Each orow As DataRow In ivdocsd.Select("item_code = '" & pitem_code.Trim & "'")
                If LibX.IsNull(orow!line_no) Then
                    orow!line_no = 0
                End If
                If Not LibX.IsNull(orow!item_code) Then
                    Linea = orow!line_no
                End If
            Next
            Return Linea
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
    Private Sub LibXLookup3_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles LibXLookup3.BeforeExecuteQuery
        Try
            If LibXConnector1.IsDataEditing = True Then
                If txtwhse_dest.Text <> "" Then
                    e.aditionalWhere = "whse_code <> " & Me.txtwhse_dest.Text
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

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

    Private Sub lkItem_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkItem_code.AfterSetValues
        If e.dataFound = False Then
            Exit Sub
        End If
        Dim Vence As String
        Try
            If LibXConnector1.IsDataEditing = True Then
                Vence = GetVencimiento(e.row!item_code.ToString.Trim)
                Me.LibXGridDetalle.SetValue(Me.gColVencimiento, Vence)
                Me.LibXGridDetalle.SetValue(Me.gColfactor, e.row!factor)
                Me.LibXGridDetalle.SetValue(Me.gColExistencia, e.row!existencia)
            End If


        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXGridDetalle_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGridDetalle.CurrentRowChanged
        Try
            If LibXConnector1.CurrentAction <> LibxConnectionActions.Cancel Then
                If LibXConnector1.IsDataEditing = True Then
                    If LibXConnector1.HasRecords = True Then
                        If Not LibX.IsNull(LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColITem_code)) Then
                            findDestinwh(LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColITem_code), Me.txtwhse_dest.Text)
                        End If
                    End If
                    LibXGridDetalle.refreshFooter()

                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
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
    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If Not e.row Is Nothing Then
                If e.row!doc_status <> 2 Then '// Pendiente Aplicar
                    LibXConnector1.AllowEdit = False
                    LibXConnector1.AllowDelete = False
                Else
                    LibXConnector1.AllowEdit = True
                    LibXConnector1.AllowDelete = True
                End If
                If LibXConnector1.HasRecords = True Then
                    If Not LibX.IsNull(LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColITem_code)) Then
                        findDestinwh(LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColITem_code), Me.txtwhse_dest.Text)
                    End If
                End If
                LibXNavigator1.UpdateState()
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Function findDestinwh(ByVal Item As String, ByVal Wh As Integer) As Integer
        Dim wHrow As DataRow

        wHrow = LibX.Data.Manager.GetDataRow("select item_name,existencia,unit_code,purch_cost from ivitemv1 where item_code ='" & Item & "' And  whse_code = " & Wh)

        Me.lblitem_namedestino.Text = wHrow!item_name
        Me.lblexistencia.Text = wHrow!existencia
        Me.lblunidad.Text = wHrow!unit_code
        Me.lblcosto.Text = wHrow!purch_cost
    End Function
End Class
