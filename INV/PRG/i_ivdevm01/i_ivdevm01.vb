Imports SGT.Inventario.Entidades

Public Class i_ivdevm01
    Inherits System.Windows.Forms.Form
    Dim mArticulos As SGT.Inventario.Entidades.Articulo
    Dim mConfig As SGT.Inventario.Common.Configuration
    Dim mUnid As String
    Dim mFactor As Decimal
    Dim dIsponible As Decimal
    Dim oDocumento As SGT.Inventario.Entidades.Documento
    Dim m_strDocumento As String = "DVI"
    Dim ScDefault As Integer
    Dim sFactor As Integer

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As LibX.XTextBox
    Friend WithEvents TextBox12 As LibX.XTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lkp_item_code As LibX.LibXLookup
    Friend WithEvents STivdevolm As LibX.LibXDbSourceTable
    Friend WithEvents STivdevold As LibX.LibXDbSourceTable
    Friend WithEvents prov_name As LibX.XTextBox
    Friend WithEvents whse_name As LibX.XTextBox
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents xlk_prov_code As LibX.LibXLookup
    Friend WithEvents xlk_whse_code As LibX.LibXLookup
    Friend WithEvents ButtonVencimiento As System.Windows.Forms.Button
    Friend WithEvents xdt_dev_date As LibX.LibxDateTimePicker
    Friend WithEvents xcbo_dev_status As LibX.LibXCombo
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
    Friend WithEvents ivdevolm As System.Data.DataTable
    Friend WithEvents ivdevold As System.Data.DataTable
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents gColitem_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents gColitem_name As LibX.XEditTextBoxColumn
    Friend WithEvents gColQty As LibX.XEditTextBoxColumn
    Friend WithEvents gColCosto As LibX.XEditTextBoxColumn
    Friend WithEvents gColItbis As LibX.XEditTextBoxColumn
    Friend WithEvents gColImporte As LibX.XEditTextBoxColumn
    Friend WithEvents txtwhse_code As LibX.XTextBox
    Friend WithEvents gColFactor As LibX.XEditTextBoxColumn
    Friend WithEvents gColentr_serial As LibX.XEditTextBoxColumn
    Friend WithEvents gColFechaFact As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents txtprov_code As LibX.XTextBox
    Friend WithEvents labelitem_name As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents gColentr_number As LibX.XDataGridTextButtonColumn
    Friend WithEvents xlk_entr_number As LibX.LibXLookup
    Friend WithEvents xcbo_dev_type As LibX.LibXCombo
    Friend WithEvents txtdev_number As LibX.XTextBox
    Friend WithEvents txttotal_amount As LibX.XTextBox
    Friend WithEvents txtitbis_amount As LibX.XTextBox
    Friend WithEvents xtxtneto_amount As LibX.XTextBox
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents gcolexistencia As LibX.XEditTextBoxColumn
    Friend WithEvents gcolqty_comp As LibX.XEditTextBoxColumn
    Friend WithEvents gColUnit As LibX.XDataGridTextButtonColumn
    Friend WithEvents xlk_unit_code As LibX.LibXLookup
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents gColTaxable As LibX.XEditTextBoxColumn
    Friend WithEvents lblexistencia As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents gColdscto As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ivdevolm = New System.Data.DataTable
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
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.ivdevold = New System.Data.DataTable
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
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.txtprov_code = New LibX.XTextBox
        Me.txtdev_number = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.xcbo_dev_type = New LibX.LibXCombo
        Me.xtxtneto_amount = New LibX.XTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.xdt_dev_date = New LibX.LibxDateTimePicker
        Me.xcbo_dev_status = New LibX.LibXCombo
        Me.prov_name = New LibX.XTextBox
        Me.whse_name = New LibX.XTextBox
        Me.txtwhse_code = New LibX.XTextBox
        Me.txttotal_amount = New LibX.XTextBox
        Me.TextBox10 = New LibX.XTextBox
        Me.txtitbis_amount = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.xlk_prov_code = New LibX.LibXLookup
        Me.xlk_whse_code = New LibX.LibXLookup
        Me.Label16 = New System.Windows.Forms.Label
        Me.lkp_item_code = New LibX.LibXLookup
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColitem_code = New LibX.XDataGridTextButtonColumn
        Me.gColitem_name = New LibX.XEditTextBoxColumn
        Me.gColentr_number = New LibX.XDataGridTextButtonColumn
        Me.xlk_entr_number = New LibX.LibXLookup
        Me.gColFechaFact = New LibX.XEditTextBoxColumn
        Me.gColQty = New LibX.XEditTextBoxColumn
        Me.gColUnit = New LibX.XDataGridTextButtonColumn
        Me.xlk_unit_code = New LibX.LibXLookup
        Me.gColCosto = New LibX.XEditTextBoxColumn
        Me.gColdscto = New LibX.XEditTextBoxColumn
        Me.gColItbis = New LibX.XEditTextBoxColumn
        Me.gColFactor = New LibX.XEditTextBoxColumn
        Me.gColentr_serial = New LibX.XEditTextBoxColumn
        Me.gcolexistencia = New LibX.XEditTextBoxColumn
        Me.gcolqty_comp = New LibX.XEditTextBoxColumn
        Me.gColTaxable = New LibX.XEditTextBoxColumn
        Me.gColImporte = New LibX.XEditTextBoxColumn
        Me.STivdevolm = New LibX.LibXDbSourceTable
        Me.STivdevold = New LibX.LibXDbSourceTable
        Me.ButtonVencimiento = New System.Windows.Forms.Button
        Me.labelitem_name = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lblexistencia = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.lblCantidad = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivdevolm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivdevold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.txtprov_code
        Me.LibXNavigator1.FirstControlInFindMode = Me.txtdev_number
        Me.LibXNavigator1.FirstControlInNewMode = Me.txtprov_code
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(1010, 24)
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
        Me.LibXConnector1.DataMember = "ivdevolm"
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
        Me.LibXConnector1.ReportName = "r_ivdevol01.rpt"
        Me.LibXConnector1.RequeryData = False
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
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivdevolm, Me.ivdevold})
        '
        'ivdevolm
        '
        Me.ivdevolm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn32, Me.DataColumn33, Me.DataColumn38})
        Me.ivdevolm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"dev_serial"}, True)})
        Me.ivdevolm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.ivdevolm.TableName = "ivdevolm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "dev_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "whse_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "type_code"
        Me.DataColumn3.MaxLength = 3
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "dev_number"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "prov_code"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "dev_date"
        Me.DataColumn6.DataType = GetType(System.DateTime)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "amount"
        Me.DataColumn7.DataType = GetType(System.Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "dev_status"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "nc_number"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "nc_amount"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "date_created"
        Me.DataColumn11.DataType = GetType(System.DateTime)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "userid"
        Me.DataColumn12.MaxLength = 20
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "dev_ncf"
        Me.DataColumn13.MaxLength = 19
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "entr_serial"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "factura"
        Me.DataColumn15.DataType = GetType(System.Int32)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "dev_type"
        Me.DataColumn16.MaxLength = 3
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "itbis_amount"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "nc_date"
        Me.DataColumn32.DataType = GetType(System.DateTime)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "prov_fecha"
        Me.DataColumn33.DataType = GetType(System.DateTime)
        '
        'DataColumn38
        '
        Me.DataColumn38.AllowDBNull = False
        Me.DataColumn38.ColumnName = "suc_code"
        Me.DataColumn38.DataType = GetType(System.Int32)
        '
        'ivdevold
        '
        Me.ivdevold.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37})
        Me.ivdevold.TableName = "ivdevold"
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "dev_serial"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "line_no"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "unit_code"
        Me.DataColumn20.MaxLength = 4
        '
        'DataColumn21
        '
        Me.DataColumn21.AllowDBNull = False
        Me.DataColumn21.ColumnName = "item_code"
        Me.DataColumn21.MaxLength = 10
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "whse_code"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "qty"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.ColumnName = "costo"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "factor"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "itbis"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "item_name"
        Me.DataColumn27.MaxLength = 100
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "Importe"
        Me.DataColumn28.DataType = GetType(System.Decimal)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "entr_serial"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "entr_number"
        Me.DataColumn30.MaxLength = 20
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "entr_date"
        Me.DataColumn31.DataType = GetType(System.DateTime)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "existencia"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "qty_comp"
        Me.DataColumn35.DataType = GetType(System.Int32)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "taxable"
        Me.DataColumn36.DataType = GetType(System.Int16)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "dscto"
        Me.DataColumn37.DataType = GetType(System.Decimal)
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
        Me.LibXDbSourceTable1.KeyFields = ""
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "dev_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ivdevolm"
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
        Me.LibXDbSourceTable2.LineColName = "line_no"
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"dev_serial=dev_serial", "whse_code=whse_code"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select ivdevold.*,ivitemm.item_name, iventrdm.entr_number,", "iventrdm.entr_date, ivitemd.existencia, iventrdd.qty qty_comp,", "ivitemd.taxable  ", "from ivdevold ", "inner join ivitemm", "on ivitemm.item_code = ivdevold.item_code", "inner join ivitemd", "on ivitemd.item_code = ivdevold.item_code", "and ivitemd.whse_code = ivdevold.whse_code", "left outer join iventrdm", "on ivdevold.entr_serial = iventrdm.entr_serial", "left outer join iventrdd", "on iventrdd.entr_serial = iventrdm.entr_serial", "and iventrdd.item_code = ivdevold.item_code", "and iventrdd.whse_code = ivdevold.whse_code"}
        Me.LibXDbSourceTable2.TableName = "ivdevold"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'txtprov_code
        '
        Me.txtprov_code.AcceptsReturn = True
        Me.txtprov_code.BackColor = System.Drawing.SystemColors.Window
        Me.txtprov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdevolm.prov_code"))
        Me.txtprov_code.EditInitialValue = Nothing
        Me.txtprov_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.FieldDescription = ""
        Me.txtprov_code.FindInitialValue = Nothing
        Me.txtprov_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.IgnoreRequiered = False
        Me.txtprov_code.Location = New System.Drawing.Point(88, 40)
        Me.txtprov_code.Name = "txtprov_code"
        Me.txtprov_code.NewInitialValue = Nothing
        Me.txtprov_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.Requiered = False
        Me.txtprov_code.Size = New System.Drawing.Size(80, 20)
        Me.txtprov_code.StatusBarPanelDescripcion = Nothing
        Me.txtprov_code.TabIndex = 1
        Me.txtprov_code.Text = ""
        '
        'txtdev_number
        '
        Me.txtdev_number.AcceptsReturn = True
        Me.txtdev_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdevolm.dev_number"))
        Me.txtdev_number.EditInitialValue = Nothing
        Me.txtdev_number.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtdev_number.FieldDescription = ""
        Me.txtdev_number.FindInitialValue = Nothing
        Me.txtdev_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtdev_number.IgnoreRequiered = False
        Me.txtdev_number.Location = New System.Drawing.Point(88, 16)
        Me.txtdev_number.Name = "txtdev_number"
        Me.txtdev_number.NewInitialValue = Nothing
        Me.txtdev_number.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtdev_number.Requiered = False
        Me.txtdev_number.Size = New System.Drawing.Size(80, 20)
        Me.txtdev_number.StatusBarPanelDescripcion = Nothing
        Me.txtdev_number.TabIndex = 0
        Me.txtdev_number.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.xcbo_dev_type)
        Me.GroupBox1.Controls.Add(Me.xtxtneto_amount)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.xdt_dev_date)
        Me.GroupBox1.Controls.Add(Me.xcbo_dev_status)
        Me.GroupBox1.Controls.Add(Me.txtdev_number)
        Me.GroupBox1.Controls.Add(Me.txtprov_code)
        Me.GroupBox1.Controls.Add(Me.prov_name)
        Me.GroupBox1.Controls.Add(Me.whse_name)
        Me.GroupBox1.Controls.Add(Me.txtwhse_code)
        Me.GroupBox1.Controls.Add(Me.txttotal_amount)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.txtitbis_amount)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.xlk_prov_code)
        Me.GroupBox1.Controls.Add(Me.xlk_whse_code)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lkp_item_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(992, 144)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ivdevolm.nc_date"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.FieldDescription = ""
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = False
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(472, 112)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = Nothing
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Requiered = False
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.LibxDateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker1.TabIndex = 5
        '
        'xcbo_dev_type
        '
        Me.xcbo_dev_type.AllowDefaultSort = True
        Me.xcbo_dev_type.bound = True
        Me.xcbo_dev_type.currValue = Nothing
        Me.xcbo_dev_type.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ivdevolm.dev_type"))
        Me.xcbo_dev_type.DefaultWhereString = Nothing
        Me.xcbo_dev_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_dev_type.EditInitialValue = Nothing
        Me.xcbo_dev_type.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_dev_type.FieldDescription = ""
        Me.xcbo_dev_type.FindInitialValue = Nothing
        Me.xcbo_dev_type.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_dev_type.IgnoreRequiered = False
        Me.xcbo_dev_type.Location = New System.Drawing.Point(88, 88)
        Me.xcbo_dev_type.LookupKeyDisplayFields = "dev_name"
        Me.xcbo_dev_type.LookupKeyField = "dev_type"
        Me.xcbo_dev_type.LookupTableName = "ftdevolt"
        Me.xcbo_dev_type.Name = "xcbo_dev_type"
        Me.xcbo_dev_type.NewInitialValue = Nothing
        Me.xcbo_dev_type.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_dev_type.Requiered = True
        Me.xcbo_dev_type.Required = True
        Me.xcbo_dev_type.Size = New System.Drawing.Size(240, 21)
        Me.xcbo_dev_type.SqlString = Nothing
        Me.xcbo_dev_type.StatusBarPanelDescripcion = Nothing
        Me.xcbo_dev_type.TabIndex = 3
        '
        'xtxtneto_amount
        '
        Me.xtxtneto_amount.AcceptsReturn = True
        Me.xtxtneto_amount.EditInitialValue = Nothing
        Me.xtxtneto_amount.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxtneto_amount.FieldDescription = ""
        Me.xtxtneto_amount.FindInitialValue = Nothing
        Me.xtxtneto_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtneto_amount.IgnoreRequiered = False
        Me.xtxtneto_amount.Location = New System.Drawing.Point(720, 112)
        Me.xtxtneto_amount.Name = "xtxtneto_amount"
        Me.xtxtneto_amount.NewInitialValue = Nothing
        Me.xtxtneto_amount.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxtneto_amount.ReadOnly = True
        Me.xtxtneto_amount.Requiered = False
        Me.xtxtneto_amount.Size = New System.Drawing.Size(112, 20)
        Me.xtxtneto_amount.StatusBarPanelDescripcion = Nothing
        Me.xtxtneto_amount.TabIndex = 10
        Me.xtxtneto_amount.Text = ""
        Me.xtxtneto_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(680, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 16)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Neto:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(400, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "N/C Fecha:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xdt_dev_date
        '
        Me.xdt_dev_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_dev_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ivdevolm.dev_date"))
        Me.xdt_dev_date.EditInitialValue = Nothing
        Me.xdt_dev_date.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdt_dev_date.Enabled = False
        Me.xdt_dev_date.FieldDescription = ""
        Me.xdt_dev_date.FindInitialValue = Nothing
        Me.xdt_dev_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_dev_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_dev_date.IgnoreRequiered = False
        Me.xdt_dev_date.Location = New System.Drawing.Point(720, 16)
        Me.xdt_dev_date.Name = "xdt_dev_date"
        Me.xdt_dev_date.NewInitialValue = "now"
        Me.xdt_dev_date.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdt_dev_date.Requiered = False
        Me.xdt_dev_date.Size = New System.Drawing.Size(112, 20)
        Me.xdt_dev_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_dev_date.TabIndex = 6
        Me.xdt_dev_date.TabStop = False
        '
        'xcbo_dev_status
        '
        Me.xcbo_dev_status.AllowDefaultSort = True
        Me.xcbo_dev_status.bound = True
        Me.xcbo_dev_status.currValue = Nothing
        Me.xcbo_dev_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ivdevolm.dev_status"))
        Me.xcbo_dev_status.DefaultWhereString = Nothing
        Me.xcbo_dev_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_dev_status.EditInitialValue = Nothing
        Me.xcbo_dev_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_dev_status.FieldDescription = ""
        Me.xcbo_dev_status.FindInitialValue = Nothing
        Me.xcbo_dev_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_dev_status.IgnoreRequiered = False
        Me.xcbo_dev_status.Items.AddRange(New Object() {"0-Anulada", "1-Aplicada", "2-Pendiente de aplicar"})
        Me.xcbo_dev_status.Location = New System.Drawing.Point(720, 40)
        Me.xcbo_dev_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_dev_status.LookupKeyField = Nothing
        Me.xcbo_dev_status.LookupTableName = Nothing
        Me.xcbo_dev_status.Name = "xcbo_dev_status"
        Me.xcbo_dev_status.NewInitialValue = "2"
        Me.xcbo_dev_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_dev_status.Requiered = False
        Me.xcbo_dev_status.Required = False
        Me.xcbo_dev_status.Size = New System.Drawing.Size(112, 21)
        Me.xcbo_dev_status.SqlString = Nothing
        Me.xcbo_dev_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_dev_status.TabIndex = 7
        '
        'prov_name
        '
        Me.prov_name.AcceptsReturn = True
        Me.prov_name.EditInitialValue = Nothing
        Me.prov_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.FieldDescription = ""
        Me.prov_name.FindInitialValue = Nothing
        Me.prov_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.IgnoreRequiered = False
        Me.prov_name.Location = New System.Drawing.Point(176, 40)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.NewInitialValue = Nothing
        Me.prov_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.ReadOnly = True
        Me.prov_name.Requiered = False
        Me.prov_name.Size = New System.Drawing.Size(384, 20)
        Me.prov_name.StatusBarPanelDescripcion = Nothing
        Me.prov_name.TabIndex = 1
        Me.prov_name.TabStop = False
        Me.prov_name.Text = ""
        '
        'whse_name
        '
        Me.whse_name.AcceptsReturn = True
        Me.whse_name.EditInitialValue = Nothing
        Me.whse_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.FieldDescription = ""
        Me.whse_name.FindInitialValue = Nothing
        Me.whse_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.IgnoreRequiered = False
        Me.whse_name.Location = New System.Drawing.Point(176, 64)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.NewInitialValue = Nothing
        Me.whse_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.ReadOnly = True
        Me.whse_name.Requiered = False
        Me.whse_name.Size = New System.Drawing.Size(384, 20)
        Me.whse_name.StatusBarPanelDescripcion = Nothing
        Me.whse_name.TabIndex = 1
        Me.whse_name.TabStop = False
        Me.whse_name.Text = ""
        '
        'txtwhse_code
        '
        Me.txtwhse_code.AcceptsReturn = True
        Me.txtwhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdevolm.whse_code"))
        Me.txtwhse_code.EditInitialValue = Nothing
        Me.txtwhse_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.FieldDescription = ""
        Me.txtwhse_code.FindInitialValue = Nothing
        Me.txtwhse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.IgnoreRequiered = False
        Me.txtwhse_code.Location = New System.Drawing.Point(88, 64)
        Me.txtwhse_code.Name = "txtwhse_code"
        Me.txtwhse_code.NewInitialValue = Nothing
        Me.txtwhse_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.Requiered = False
        Me.txtwhse_code.Size = New System.Drawing.Size(80, 20)
        Me.txtwhse_code.StatusBarPanelDescripcion = Nothing
        Me.txtwhse_code.TabIndex = 2
        Me.txtwhse_code.Text = ""
        '
        'txttotal_amount
        '
        Me.txttotal_amount.AcceptsReturn = True
        Me.txttotal_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdevolm.amount"))
        Me.txttotal_amount.EditInitialValue = Nothing
        Me.txttotal_amount.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txttotal_amount.FieldDescription = ""
        Me.txttotal_amount.FindInitialValue = Nothing
        Me.txttotal_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txttotal_amount.IgnoreRequiered = False
        Me.txttotal_amount.Location = New System.Drawing.Point(720, 64)
        Me.txttotal_amount.Name = "txttotal_amount"
        Me.txttotal_amount.NewInitialValue = Nothing
        Me.txttotal_amount.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txttotal_amount.Requiered = False
        Me.txttotal_amount.Size = New System.Drawing.Size(112, 20)
        Me.txttotal_amount.StatusBarPanelDescripcion = Nothing
        Me.txttotal_amount.TabIndex = 8
        Me.txttotal_amount.Text = ""
        Me.txttotal_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox10
        '
        Me.TextBox10.AcceptsReturn = True
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdevolm.nc_number"))
        Me.TextBox10.EditInitialValue = Nothing
        Me.TextBox10.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox10.FieldDescription = ""
        Me.TextBox10.FindInitialValue = Nothing
        Me.TextBox10.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox10.IgnoreRequiered = False
        Me.TextBox10.Location = New System.Drawing.Point(88, 112)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.NewInitialValue = Nothing
        Me.TextBox10.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox10.Requiered = False
        Me.TextBox10.Size = New System.Drawing.Size(80, 20)
        Me.TextBox10.StatusBarPanelDescripcion = Nothing
        Me.TextBox10.TabIndex = 4
        Me.TextBox10.Text = ""
        '
        'txtitbis_amount
        '
        Me.txtitbis_amount.AcceptsReturn = True
        Me.txtitbis_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdevolm.itbis_amount"))
        Me.txtitbis_amount.EditInitialValue = Nothing
        Me.txtitbis_amount.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtitbis_amount.FieldDescription = ""
        Me.txtitbis_amount.FindInitialValue = Nothing
        Me.txtitbis_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtitbis_amount.IgnoreRequiered = False
        Me.txtitbis_amount.Location = New System.Drawing.Point(720, 88)
        Me.txtitbis_amount.Name = "txtitbis_amount"
        Me.txtitbis_amount.NewInitialValue = Nothing
        Me.txtitbis_amount.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtitbis_amount.Requiered = False
        Me.txtitbis_amount.Size = New System.Drawing.Size(112, 20)
        Me.txtitbis_amount.StatusBarPanelDescripcion = Nothing
        Me.txtitbis_amount.TabIndex = 9
        Me.txtitbis_amount.Text = ""
        Me.txtitbis_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(27, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(34, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Motivo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(26, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Suplidor:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(24, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Almacen:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(672, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(672, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Monto:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(666, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Estatus:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(8, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "NC Número:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(675, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "ITBIS:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_prov_code
        '
        Me.xlk_prov_code.AlternateFieldSearch = Nothing
        Me.xlk_prov_code.BeginCheck = False
        Me.xlk_prov_code.CheckText = Nothing
        Me.xlk_prov_code.ComboMode = False
        Me.xlk_prov_code.DataMember = Nothing
        Me.xlk_prov_code.DataSource = Me.LibXConnector1
        Me.xlk_prov_code.DestParameters = New String() {"prov_code=prov_code", "prov_name=prov_name"}
        Me.xlk_prov_code.FilterField = "prov_name"
        Me.xlk_prov_code.IgnoreFindInBrowseMode = False
        Me.xlk_prov_code.isCanceled = False
        Me.xlk_prov_code.Location = New System.Drawing.Point(560, 40)
        Me.xlk_prov_code.LookCaption = "Suplidores"
        Me.xlk_prov_code.Name = "xlk_prov_code"
        Me.xlk_prov_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_prov_code.ShowFilter = True
        Me.xlk_prov_code.ShowMessageNotFound = True
        Me.xlk_prov_code.ShowWarning = False
        Me.xlk_prov_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_prov_code.SizesColumns = Nothing
        Me.xlk_prov_code.SizesColumnsTab = Nothing
        Me.xlk_prov_code.SqlString = Nothing
        Me.xlk_prov_code.SQLTab = Nothing
        Me.xlk_prov_code.SrcParameters = New String() {"prov_code=prov_code"}
        Me.xlk_prov_code.TabIndex = 3
        Me.xlk_prov_code.TableName = "cpprovm"
        Me.xlk_prov_code.TabStop = False
        Me.xlk_prov_code.UseCopyConnection = False
        Me.xlk_prov_code.UseRowRetrieveEvents = False
        Me.xlk_prov_code.UseTab = False
        Me.xlk_prov_code.VisParameters = New String() {"Código=prov_code", "Suplidores=prov_name"}
        Me.xlk_prov_code.WhereCondition = Nothing
        Me.xlk_prov_code.WhereParameters = Nothing
        '
        'xlk_whse_code
        '
        Me.xlk_whse_code.AlternateFieldSearch = Nothing
        Me.xlk_whse_code.BeginCheck = False
        Me.xlk_whse_code.CheckText = Nothing
        Me.xlk_whse_code.ComboMode = False
        Me.xlk_whse_code.DataMember = Nothing
        Me.xlk_whse_code.DataSource = Me.LibXConnector1
        Me.xlk_whse_code.DestParameters = New String() {"whse_code=whse_code", "whse_name=whse_name"}
        Me.xlk_whse_code.FilterField = "whse_name"
        Me.xlk_whse_code.IgnoreFindInBrowseMode = False
        Me.xlk_whse_code.isCanceled = False
        Me.xlk_whse_code.Location = New System.Drawing.Point(560, 64)
        Me.xlk_whse_code.LookCaption = "Almacenes"
        Me.xlk_whse_code.Name = "xlk_whse_code"
        Me.xlk_whse_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_whse_code.ShowFilter = True
        Me.xlk_whse_code.ShowMessageNotFound = True
        Me.xlk_whse_code.ShowWarning = False
        Me.xlk_whse_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_whse_code.SizesColumns = Nothing
        Me.xlk_whse_code.SizesColumnsTab = Nothing
        Me.xlk_whse_code.SqlString = Nothing
        Me.xlk_whse_code.SQLTab = Nothing
        Me.xlk_whse_code.SrcParameters = New String() {"whse_code=whse_code"}
        Me.xlk_whse_code.TabIndex = 3
        Me.xlk_whse_code.TableName = "ivwhsem"
        Me.xlk_whse_code.TabStop = False
        Me.xlk_whse_code.UseCopyConnection = False
        Me.xlk_whse_code.UseRowRetrieveEvents = False
        Me.xlk_whse_code.UseTab = False
        Me.xlk_whse_code.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.xlk_whse_code.WhereCondition = Nothing
        Me.xlk_whse_code.WhereParameters = Nothing
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Location = New System.Drawing.Point(672, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Fecha:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lkp_item_code
        '
        Me.lkp_item_code.AlternateFieldSearch = Nothing
        Me.lkp_item_code.BeginCheck = False
        Me.lkp_item_code.CheckText = Nothing
        Me.lkp_item_code.ComboMode = False
        Me.lkp_item_code.DataMember = "ivdevold"
        Me.lkp_item_code.DataSource = Me.LibXConnector1
        Me.lkp_item_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "costo=costo", "price=price", "unit_code=unit_code", "benef=benef", "bf_onhand=existencia", "whse_code=whse_code", "taxable=taxable"}
        Me.lkp_item_code.FilterField = "item_name"
        Me.lkp_item_code.IgnoreFindInBrowseMode = True
        Me.lkp_item_code.isCanceled = False
        Me.lkp_item_code.Location = New System.Drawing.Point(424, 72)
        Me.lkp_item_code.LookCaption = "Productos"
        Me.lkp_item_code.Name = "lkp_item_code"
        Me.lkp_item_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkp_item_code.ShowFilter = True
        Me.lkp_item_code.ShowMessageNotFound = True
        Me.lkp_item_code.ShowWarning = False
        Me.lkp_item_code.Size = New System.Drawing.Size(16, 20)
        Me.lkp_item_code.SizesColumns = New String() {"item_name=350", "entr_number=70", "unit_code=60"}
        Me.lkp_item_code.SizesColumnsTab = Nothing
        Me.lkp_item_code.SqlString = New String() {"select DISTINCT  ivitemv1.item_code", ",ivitemv1.item_name", ",ivitemv1.whse_code", ",ivitemv1.purch_unit unit_code", ",isnull(ivitemv1.purch_cost,0) * isnull(ivunitd.factor,0) as costo", ",ivitemv1.price", ",ivitemv1.existencia", ",ivitemv1.benef ", ",cpprovm.prov_name", ",ivitemv1.taxable", ",ivunitd.factor", "from ivitemv1 ", "left outer join ivunitd", "on ivunitd.unit_code = ivitemv1.purch_unit", "and ivunitd.item_code = ivitemv1.item_code", "left outer join ivcbarram", "on ivcbarram.item_code = ivitemv1.item_code", "inner join cpprovm", "on cpprovm.prov_code = ivitemv1.prov_code", "LEFT OUTER JOIN ivreferm", " ON ivreferm.item_code = ivitemv1.item_code", "order by ivitemv1.item_name"}
        Me.lkp_item_code.SQLTab = Nothing
        Me.lkp_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.lkp_item_code.TabIndex = 5
        Me.lkp_item_code.TableName = "ivitemm"
        Me.lkp_item_code.TabStop = False
        Me.lkp_item_code.UseCopyConnection = False
        Me.lkp_item_code.UseRowRetrieveEvents = False
        Me.lkp_item_code.UseTab = False
        Me.lkp_item_code.VisParameters = New String() {"Descripción=item_name", "Unidad=unit_code", "Costo=costo", "Código=item_code", "Existencia=existencia", "Suplidor=prov_name"}
        Me.lkp_item_code.WhereCondition = "item_status =1"
        Me.lkp_item_code.WhereParameters = Nothing
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Productos"
        Me.LibXGrid1.DataMember = "ivdevold"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 176)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(992, 344)
        Me.LibXGrid1.TabIndex = 2
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColitem_code, Me.gColitem_name, Me.gColentr_number, Me.gColFechaFact, Me.gColQty, Me.gColUnit, Me.gColCosto, Me.gColdscto, Me.gColItbis, Me.gColFactor, Me.gColentr_serial, Me.gcolexistencia, Me.gcolqty_comp, Me.gColTaxable, Me.gColImporte})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivdevold"
        '
        'gColitem_code
        '
        Me.gColitem_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColitem_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.gColitem_code.executeFindDuringFill = False
        Me.gColitem_code.Format = ""
        Me.gColitem_code.FormatInfo = Nothing
        Me.gColitem_code.HeaderText = "Producto"
        Me.gColitem_code.isReadOnly = False
        Me.gColitem_code.Lookup = Me.lkp_item_code
        Me.gColitem_code.MappingName = "item_code"
        Me.gColitem_code.MaxLength = 32767
        Me.gColitem_code.TabStop = True
        Me.gColitem_code.UseCustomCellFormat = False
        Me.gColitem_code.Width = 95
        '
        'gColitem_name
        '
        Me.gColitem_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColitem_name.Format = ""
        Me.gColitem_name.FormatInfo = Nothing
        Me.gColitem_name.HeaderText = "Descripción"
        Me.gColitem_name.ImageList = Nothing
        Me.gColitem_name.isReadOnly = True
        Me.gColitem_name.MappingName = "item_name"
        Me.gColitem_name.MaxLength = 32767
        Me.gColitem_name.ReadOnly = True
        Me.gColitem_name.TabStop = True
        Me.gColitem_name.UseCustomCellFormat = False
        Me.gColitem_name.Width = 200
        '
        'gColentr_number
        '
        Me.gColentr_number.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColentr_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColentr_number.executeFindDuringFill = False
        Me.gColentr_number.Format = ""
        Me.gColentr_number.FormatInfo = Nothing
        Me.gColentr_number.HeaderText = "Factura/Compra"
        Me.gColentr_number.isReadOnly = False
        Me.gColentr_number.Lookup = Me.xlk_entr_number
        Me.gColentr_number.MappingName = "entr_number"
        Me.gColentr_number.MaxLength = 32767
        Me.gColentr_number.TabStop = True
        Me.gColentr_number.UseCustomCellFormat = False
        Me.gColentr_number.Width = 101
        '
        'xlk_entr_number
        '
        Me.xlk_entr_number.AlternateFieldSearch = Nothing
        Me.xlk_entr_number.BeginCheck = False
        Me.xlk_entr_number.CheckText = Nothing
        Me.xlk_entr_number.ComboMode = False
        Me.xlk_entr_number.DataMember = Nothing
        Me.xlk_entr_number.DataSource = Me.LibXConnector1
        Me.xlk_entr_number.DestParameters = New String() {"entr_number=entr_number", "entr_date=entr_date", "entr_serial=entr_serial"}
        Me.xlk_entr_number.FilterField = Nothing
        Me.xlk_entr_number.IgnoreFindInBrowseMode = False
        Me.xlk_entr_number.isCanceled = False
        Me.xlk_entr_number.Location = New System.Drawing.Point(720, 296)
        Me.xlk_entr_number.LookCaption = Nothing
        Me.xlk_entr_number.Name = "xlk_entr_number"
        Me.xlk_entr_number.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_entr_number.ShowFilter = True
        Me.xlk_entr_number.ShowMessageNotFound = False
        Me.xlk_entr_number.ShowWarning = False
        Me.xlk_entr_number.Size = New System.Drawing.Size(16, 20)
        Me.xlk_entr_number.SizesColumns = New String() {Nothing}
        Me.xlk_entr_number.SizesColumnsTab = Nothing
        Me.xlk_entr_number.SqlString = New String() {"select TOP 10 iventrdd.item_code,", "iventrdm.entr_serial,", "iventrdm.entr_number,", "iventrdm.entr_date,", "cpprovm.prov_code,", "cpprovm.prov_name,", "iventrdd.qty,", "iventrdd.costo,", "iventrdd.dscto,", "iventrdd.itbis,", "iventrdd.unit_code", "from iventrdm ", "inner join iventrdd", "on iventrdm.entr_serial = iventrdd.entr_serial", "and iventrdm.entr_status = 1", "", "inner join cpprovm", "on iventrdm.prov_code = cpprovm.prov_code", "order by iventrdm.entr_date DESC"}
        Me.xlk_entr_number.SQLTab = Nothing
        Me.xlk_entr_number.SrcParameters = New String() {"entr_number=entr_number"}
        Me.xlk_entr_number.TabIndex = 9
        Me.xlk_entr_number.TableName = "iventrdm"
        Me.xlk_entr_number.TabStop = False
        Me.xlk_entr_number.UseCopyConnection = False
        Me.xlk_entr_number.UseRowRetrieveEvents = False
        Me.xlk_entr_number.UseTab = False
        Me.xlk_entr_number.VisParameters = New String() {"Factura/Compra=entr_number", "Fecha/Compra=entr_date", "Suplidor=prov_name", "Cantidad=qty", "Unidad=unit_code", "Costo=costo"}
        Me.xlk_entr_number.WhereCondition = Nothing
        Me.xlk_entr_number.WhereParameters = Nothing
        '
        'gColFechaFact
        '
        Me.gColFechaFact.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColFechaFact.Format = ""
        Me.gColFechaFact.FormatInfo = Nothing
        Me.gColFechaFact.HeaderText = "Fecha/Compra"
        Me.gColFechaFact.ImageList = Nothing
        Me.gColFechaFact.isReadOnly = True
        Me.gColFechaFact.MappingName = "entr_date"
        Me.gColFechaFact.MaxLength = 32767
        Me.gColFechaFact.ReadOnly = True
        Me.gColFechaFact.TabStop = True
        Me.gColFechaFact.UseCustomCellFormat = False
        Me.gColFechaFact.Width = 101
        '
        'gColQty
        '
        Me.gColQty.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColQty.Format = "###,##0"
        Me.gColQty.FormatInfo = Nothing
        Me.gColQty.HeaderText = "Cantidadi"
        Me.gColQty.ImageList = Nothing
        Me.gColQty.isReadOnly = False
        Me.gColQty.MappingName = "qty"
        Me.gColQty.MaxLength = 32767
        Me.gColQty.TabStop = True
        Me.gColQty.UseCustomCellFormat = False
        Me.gColQty.Width = 65
        '
        'gColUnit
        '
        Me.gColUnit.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColUnit.executeFindDuringFill = False
        Me.gColUnit.Format = ""
        Me.gColUnit.FormatInfo = Nothing
        Me.gColUnit.HeaderText = "Unidad"
        Me.gColUnit.isReadOnly = False
        Me.gColUnit.Lookup = Me.xlk_unit_code
        Me.gColUnit.MappingName = "unit_code"
        Me.gColUnit.MaxLength = 32767
        Me.gColUnit.TabStop = True
        Me.gColUnit.UseCustomCellFormat = False
        Me.gColUnit.Width = 60
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
        Me.xlk_unit_code.Location = New System.Drawing.Point(497, 330)
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
        Me.xlk_unit_code.TabIndex = 17
        Me.xlk_unit_code.TableName = "ivunitv"
        Me.xlk_unit_code.TabStop = False
        Me.xlk_unit_code.UseCopyConnection = False
        Me.xlk_unit_code.UseRowRetrieveEvents = False
        Me.xlk_unit_code.UseTab = False
        Me.xlk_unit_code.VisParameters = New String() {"Codigo=unit_code", "Unidad=unit_name", "Factor=factor"}
        Me.xlk_unit_code.WhereCondition = Nothing
        Me.xlk_unit_code.WhereParameters = Nothing
        '
        'gColCosto
        '
        Me.gColCosto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColCosto.Format = "###,##0.00"
        Me.gColCosto.FormatInfo = Nothing
        Me.gColCosto.HeaderText = "Costoi"
        Me.gColCosto.ImageList = Nothing
        Me.gColCosto.isReadOnly = True
        Me.gColCosto.MappingName = "costo"
        Me.gColCosto.MaxLength = 32767
        Me.gColCosto.ReadOnly = True
        Me.gColCosto.TabStop = True
        Me.gColCosto.UseCustomCellFormat = False
        Me.gColCosto.Width = 85
        '
        'gColdscto
        '
        Me.gColdscto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColdscto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColdscto.Format = "###,##0.00"
        Me.gColdscto.FormatInfo = Nothing
        Me.gColdscto.HeaderText = "Descuento"
        Me.gColdscto.ImageList = Nothing
        Me.gColdscto.isReadOnly = False
        Me.gColdscto.MappingName = "dscto"
        Me.gColdscto.MaxLength = 32767
        Me.gColdscto.TabStop = True
        Me.gColdscto.UseCustomCellFormat = False
        Me.gColdscto.Width = 60
        '
        'gColItbis
        '
        Me.gColItbis.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColItbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColItbis.Format = ""
        Me.gColItbis.FormatInfo = Nothing
        Me.gColItbis.HeaderText = "ITBISi"
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
        Me.gColFactor.ReadOnly = True
        Me.gColFactor.TabStop = True
        Me.gColFactor.UseCustomCellFormat = False
        Me.gColFactor.Width = 0
        '
        'gColentr_serial
        '
        Me.gColentr_serial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColentr_serial.Format = ""
        Me.gColentr_serial.FormatInfo = Nothing
        Me.gColentr_serial.HeaderText = "Serial"
        Me.gColentr_serial.ImageList = Nothing
        Me.gColentr_serial.isReadOnly = False
        Me.gColentr_serial.MappingName = "entr_serial"
        Me.gColentr_serial.MaxLength = 32767
        Me.gColentr_serial.TabStop = True
        Me.gColentr_serial.UseCustomCellFormat = False
        Me.gColentr_serial.Width = 0
        '
        'gcolexistencia
        '
        Me.gcolexistencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolexistencia.Format = ""
        Me.gcolexistencia.FormatInfo = Nothing
        Me.gcolexistencia.ImageList = Nothing
        Me.gcolexistencia.isReadOnly = False
        Me.gcolexistencia.MappingName = "existencia"
        Me.gcolexistencia.MaxLength = 32767
        Me.gcolexistencia.TabStop = True
        Me.gcolexistencia.UseCustomCellFormat = False
        Me.gcolexistencia.Width = 0
        '
        'gcolqty_comp
        '
        Me.gcolqty_comp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolqty_comp.Format = ""
        Me.gcolqty_comp.FormatInfo = Nothing
        Me.gcolqty_comp.ImageList = Nothing
        Me.gcolqty_comp.isReadOnly = False
        Me.gcolqty_comp.MappingName = "qty_comp"
        Me.gcolqty_comp.MaxLength = 32767
        Me.gcolqty_comp.TabStop = True
        Me.gcolqty_comp.UseCustomCellFormat = False
        Me.gcolqty_comp.Width = 0
        '
        'gColTaxable
        '
        Me.gColTaxable.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColTaxable.Format = ""
        Me.gColTaxable.FormatInfo = Nothing
        Me.gColTaxable.HeaderText = "Taxable"
        Me.gColTaxable.ImageList = Nothing
        Me.gColTaxable.isReadOnly = True
        Me.gColTaxable.MappingName = "taxable"
        Me.gColTaxable.MaxLength = 32767
        Me.gColTaxable.ReadOnly = True
        Me.gColTaxable.TabStop = True
        Me.gColTaxable.UseCustomCellFormat = False
        Me.gColTaxable.Width = 0
        '
        'gColImporte
        '
        Me.gColImporte.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColImporte.Format = "###,##0.00"
        Me.gColImporte.FormatInfo = Nothing
        Me.gColImporte.HeaderText = "Importei"
        Me.gColImporte.ImageList = Nothing
        Me.gColImporte.isReadOnly = False
        Me.gColImporte.MappingName = "Importe"
        Me.gColImporte.MaxLength = 32767
        Me.gColImporte.ReadOnly = True
        Me.gColImporte.TabStop = True
        Me.gColImporte.UseCustomCellFormat = False
        Me.gColImporte.Width = 90
        '
        'STivdevolm
        '
        Me.STivdevolm.AllowDelete = True
        Me.STivdevolm.AllowEdit = True
        Me.STivdevolm.AllowNew = True
        Me.STivdevolm.AutoIncrementSerial = False
        Me.STivdevolm.CustomDbUpdate = False
        Me.STivdevolm.DeleteOrder = 0
        Me.STivdevolm.FillOnQuery = True
        Me.STivdevolm.FillOnRowChange = False
        Me.STivdevolm.HeaderIsOnGrid = False
        Me.STivdevolm.InnerJon = True
        Me.STivdevolm.InsertOrder = 0
        Me.STivdevolm.IsDetail = False
        Me.STivdevolm.KeyFields = "dev_serial"
        Me.STivdevolm.LineColName = Nothing
        Me.STivdevolm.MasterDetailRelation = Nothing
        Me.STivdevolm.MasterTableName = Nothing
        Me.STivdevolm.SerialColumnName = Nothing
        Me.STivdevolm.Sort = Nothing
        Me.STivdevolm.Source = Nothing
        Me.STivdevolm.TableName = "ivdevolm"
        Me.STivdevolm.UpdateOrder = 0
        Me.STivdevolm.UseRowRetrieve = False
        '
        'STivdevold
        '
        Me.STivdevold.AllowDelete = True
        Me.STivdevold.AllowEdit = True
        Me.STivdevold.AllowNew = True
        Me.STivdevold.AutoIncrementSerial = False
        Me.STivdevold.CustomDbUpdate = False
        Me.STivdevold.DeleteOrder = 0
        Me.STivdevold.FillOnQuery = True
        Me.STivdevold.FillOnRowChange = True
        Me.STivdevold.HeaderIsOnGrid = False
        Me.STivdevold.InnerJon = True
        Me.STivdevold.InsertOrder = 0
        Me.STivdevold.IsDetail = True
        Me.STivdevold.KeyFields = "dev_serial,line_no"
        Me.STivdevold.LineColName = Nothing
        Me.STivdevold.MasterDetailRelation = New String() {"dev_serial=dev_serial"}
        Me.STivdevold.MasterTableName = Nothing
        Me.STivdevold.SerialColumnName = Nothing
        Me.STivdevold.Sort = Nothing
        Me.STivdevold.Source = Nothing
        Me.STivdevold.TableName = "ivdevold"
        Me.STivdevold.UpdateOrder = 0
        Me.STivdevold.UseRowRetrieve = False
        '
        'ButtonVencimiento
        '
        Me.ButtonVencimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonVencimiento.Enabled = False
        Me.ButtonVencimiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonVencimiento.Location = New System.Drawing.Point(16, 632)
        Me.ButtonVencimiento.Name = "ButtonVencimiento"
        Me.ButtonVencimiento.TabIndex = 3
        Me.ButtonVencimiento.Text = "Vencimiento"
        '
        'labelitem_name
        '
        Me.labelitem_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelitem_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdevold.item_name"))
        Me.labelitem_name.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.labelitem_name.Location = New System.Drawing.Point(112, 560)
        Me.labelitem_name.Name = "labelitem_name"
        Me.labelitem_name.Size = New System.Drawing.Size(392, 20)
        Me.labelitem_name.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(48, 560)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Producto:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(760, 568)
        Me.Label13.Name = "Label13"
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Existencia:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 584)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 16)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Factura/Compra:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(280, 584)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 16)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Fecha/Compra:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdevold.entr_number"))
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label19.Location = New System.Drawing.Point(112, 584)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 20)
        Me.Label19.TabIndex = 5
        '
        'lblexistencia
        '
        Me.lblexistencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblexistencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdevold.existencia"))
        Me.lblexistencia.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblexistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexistencia.Location = New System.Drawing.Point(872, 560)
        Me.lblexistencia.Name = "lblexistencia"
        Me.lblexistencia.Size = New System.Drawing.Size(128, 40)
        Me.lblexistencia.TabIndex = 7
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdevold.entr_date"))
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Location = New System.Drawing.Point(376, 584)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(128, 20)
        Me.Label21.TabIndex = 8
        '
        'lblCantidad
        '
        Me.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCantidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivdevold.qty_comp"))
        Me.lblCantidad.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(640, 560)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(96, 20)
        Me.lblCantidad.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(520, 560)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 16)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Cantidad/Comprada:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'i_ivdevm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1010, 680)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.xlk_unit_code)
        Me.Controls.Add(Me.xlk_entr_number)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lblexistencia)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.labelitem_name)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.ButtonVencimiento)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "i_ivdevm01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Devolución de Inventario"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivdevolm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivdevold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub lkp_item_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lkp_item_code.BeforeExecuteQuery
        Try
            If Not LibXConnector1.CurrentDataRow Is Nothing Then
                If txtprov_code.Text.Trim = "" Then
                    Throw New ApplicationException("Digite el codigo del suplidor!")
                End If

                If LibXConnector1.CurrentDataRow!whse_code.ToString.Length > 0 Then
                    e.aditionalWhere = " ivitemv1.whse_code = " & LibXConnector1.CurrentDataRow!whse_code.ToString.Trim
                End If
                If LibXConnector1.IsDataEditing = True Then
                    If Len(LibXGrid1.GetValue(gColitem_code).Trim) > 8 And IsNumeric(LibXGrid1.GetValue(gColitem_code).Trim) Then
                        e.SQL = e.SQL.Replace("ivitemv1.item_code =", "ivcbarram.barra =")
                    End If
                End If
            End If

        Catch ex As Exception
            e.handled = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub i_ivdevm01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ScDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibXScDefault").ToString)
            ivdevold.Columns("Importe").Expression = "((isnull(qty,0)*isnull(costo,0))-isnull(dscto,0))+isnull(itbis,0)"
            LibXGrid1.footerOperations.add("Importe", "sum(Importe)")
            LibXGrid1.footerOperations.add("itbis", "sum(itbis)")

            mArticulos = New SGT.Inventario.Entidades.Articulo
            oDocumento = New SGT.Inventario.Entidades.Documento(m_strDocumento)
            mConfig = New SGT.Inventario.Common.Configuration

        Catch ex As Exception
            LibX.Log.Show(ex)
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
                .WhereToExecute = "doc_serial = " & LibXConnector1.CurrentDataRow!dev_serial.ToString.Trim & " and type_code ='" & m_strDocumento & "'"
            End With

            LibX.App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("i_ivcmtod", "INV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                e.UpdatingArgs.Row!type_code = m_strDocumento
                e.UpdatingArgs.Row!suc_code = ScDefault
                e.UpdatingArgs.Row!dev_number = oDocumento.GenerateNumber(m_strDocumento, e.UpdatingArgs.Row!whse_code)
                'preguntar a ramiro por el ftcond
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try
            xdt_dev_date.Value = LibX.Data.Manager.Connection.GetDate
            LibXConnector1.CurrentDataRow!dev_date = LibX.Data.Manager.Connection.GetDate
            xcbo_dev_status.currValue = 2 '// Pendiente de Aplicar

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xcbo_unit_code_BeforeLoadItems(ByVal sender As System.Object, ByVal e As LibX.LoadXComboItemsEventArgs)
        Try

            If LibXConnector1.IsDataEditing = True Then
                e.SqlString = "select * from ivunitv where item_code = '" & LibXGrid1.GetValue(gColitem_code).Trim & "'"
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub lkp_item_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkp_item_code.AfterSetValues
        Try

            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.IsDataEditing = True Then
                Dim Existencia As Integer = Val(e.row!existencia.ToString.Trim)
                Me.lblexistencia.Text = Existencia.ToString("##,##0")

                LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.gcolexistencia, Existencia)
                LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.gColUnit, e.row!unit_code)
                LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.gColCosto, e.row!costo)
                LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.gColFactor, e.row!factor)
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub xlk_entr_number_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_entr_number.BeforeExecuteQuery
        Try
            If Not LibXConnector1.CurrentDataRow Is Nothing Then
                If txtprov_code.Text.Trim = "" Then
                    Throw New ApplicationException("Digite el codigo del suplidor!")
                End If

                e.aditionalWhere = " iventrdm.prov_code = " & txtprov_code.Text.Trim

                If LibXGrid1.GetValue(gColitem_code).Trim <> "" Then
                    e.aditionalWhere = e.aditionalWhere & " and iventrdd.item_code = '" & LibXGrid1.GetValue(gColitem_code).Trim & "'"
                End If
            End If

        Catch ex As Exception
            e.handled = True
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub Calcular()
        Dim TotalAmount As Decimal
        Dim ItbisAmount As Decimal
        Dim NetoAmount As Decimal

        Try
            TotalAmount = Val(ivdevold.Compute("sum(Importe)", "").ToString.Trim)
            ItbisAmount = Val(ivdevold.Compute("sum(Itbis)", "").ToString.Trim)
            NetoAmount = Val(ivdevold.Compute("sum(Importe)", "").ToString.Trim)
            TotalAmount -= ItbisAmount

            Me.txttotal_amount.Text = Format(TotalAmount, "###,###,##0.00")
            Me.txtitbis_amount.Text = Format(ItbisAmount, "###,###,##0.00")
            Me.xtxtneto_amount.Text = Format(NetoAmount, "###,###,##0.00")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        Dim ItemCode As String = ""
        Dim Factura As String = ""
        Dim Fecha As Date
        Try

            For Each oRow As DataRow In ivdevold.Rows
                If oRow.RowState <> DataRowState.Deleted Then
                    If ItemCode.Trim = oRow!item_code.ToString.Trim _
                    And Factura.Trim = oRow!entr_number.ToString.Trim Then
                        Throw New ApplicationException("Existen productos repetidos en esta devolucion para una misma factura!")
                    End If

                    '// Si esta en blanco no tomar en cuenta
                    If LibX.IsNull(oRow!item_code) = True Then
                        oRow.AcceptChanges()
                    End If

                    ItemCode = oRow!item_code.ToString.Trim
                    Factura = oRow!entr_number.ToString.Trim
                End If
            Next

        Catch ex As Exception
            e.Handled = True
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid1.CurrentRowChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                Calcular()
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try
            ButtonVencimiento.Enabled = (Not e.isDataEditing AndAlso LibXConnector1.HasRecords = True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try

            Me.ButtonVencimiento.Enabled = (Not LibXConnector1.IsEditing And LibXConnector1.HasRecords = True)

            If LibXConnector1.IsEditing = False AndAlso LibXConnector1.HasRecords = True Then
                Calcular()

                If e.row!dev_status = 1 Then
                    LibXConnector1.AllowDelete = False
                    LibXConnector1.AllowEdit = False
                Else
                    LibXConnector1.AllowDelete = True
                    LibXConnector1.AllowEdit = True
                End If
                LibXNavigator1.UpdateState()

            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
        Try

            If LibXConnector1.IsDataEditing = True Then
                If e.cell = LibXGrid1.GetColNum(gColitem_code) Then
                    If e.value.Trim = "" Then
                        e.hasErrors = True
                        Exit Sub
                    End If
                End If

                If LibXGrid1.GetValue(e.row, gColitem_code) = "" Then
                    LibXGrid1.Focus(e.row, 0)
                    Exit Sub
                End If

                'If e.cell = LibXGrid1.GetColNum(gColQty) _
                'Or e.cell = LibXGrid1.GetColNum(gColUnit) Then
                If e.cell = LibXGrid1.GetColNum(gColQty) Then
                    If e.cell = LibXGrid1.GetColNum(gColQty) Then
                        If Val(e.value.Trim) <= 0 Then
                            e.hasErrors = True
                            Exit Sub
                        End If
                    End If

                    If e.cell = LibXGrid1.GetColNum(gColUnit) Then
                        If e.value.Trim = "" Then
                            e.hasErrors = True
                            Exit Sub
                        End If
                    End If

                    'If ValidarCantidad() = False Then
                    '    If LibXGrid1.GetValue(e.row, gcolqty_comp).Trim <> "" Then
                    '        LibXGrid1.SetValue(e.row, gColQty, LibXGrid1.GetValue(e.row, gcolqty_comp))
                    '    Else
                    '        LibXGrid1.SetValue(e.row, gColQty, LibXGrid1.GetValue(e.row, gcolexistencia))
                    '    End If
                    '    If LibXGrid1.GetValue(e.row, gColentr_number).Trim = "" Then
                    '        mFactor = Getunidaminventa(LibXGrid1.SetValue(e.row, gColitem_code).Trim, LibXGrid1.SetValue(e.row, gColUnit).Trim)
                    '    End If
                    '    If mFactor >= 1 Then
                    '        dIsponible = LibXGrid1.GetValue(e.row, gcolexistencia).Trim / mFactor
                    '    Else
                    '        dIsponible = LibXGrid1.SetValue(e.row, gColQty)
                    '    End If
                    '    e.hasErrors = True
                    '    Throw New ApplicationException("La cantidad no puede ser mayor que la existencia actual" & vbCrLf & "Existencia = " & dIsponible & " " & LibXGrid1.SetValue(e.row, gColUnit).Trim)
                    'End If
                End If
                If e.cell = LibXGrid1.GetColNum(gColUnit) Then
                    If ValidarCantidad() = False Then
                        If LibXGrid1.GetValue(e.row, gcolqty_comp).Trim <> "" Then
                            LibXGrid1.SetValue(e.row, gColQty, LibXGrid1.GetValue(e.row, gcolqty_comp))
                        Else
                            LibXGrid1.SetValue(e.row, gColQty, LibXGrid1.GetValue(e.row, gcolexistencia))
                        End If
                        If LibXGrid1.GetValue(e.row, gColentr_number).Trim = "" Then
                            mFactor = Getunidaminventa(LibXGrid1.SetValue(e.row, gColitem_code).Trim, LibXGrid1.SetValue(e.row, gColUnit).Trim)
                        End If
                        If mFactor >= 1 Then
                            dIsponible = LibXGrid1.GetValue(e.row, gcolexistencia).Trim / mFactor
                        Else
                            dIsponible = LibXGrid1.SetValue(e.row, gColQty)
                        End If
                        e.hasErrors = True
                        Throw New ApplicationException("La cantidad no puede ser mayor que la existencia actual" & vbCrLf & "Existencia = " & dIsponible & " " & LibXGrid1.SetValue(e.row, gColUnit).Trim)
                    End If
                End If

                If e.cell = Me.gColCosto.Column Or e.cell = Me.gColItbis.Column Or e.cell = Me.gColQty.Column Then
                    '// Calcular el ITBIS
                    If LibXGrid1.GetValue(e.row, gColCosto).Trim <> "" AndAlso LibXGrid1.GetValue(e.row, gColQty).Trim <> "" Then
                        Dim Costo As Decimal = CDec(LibXGrid1.GetValue(e.row, gColCosto)) * CDec(LibXGrid1.GetValue(e.row, gColQty))
                        If LibXGrid1.GetValue(e.row, gColTaxable).Trim = "1" Then
                            Dim ITBIS As Decimal = Costo * (mConfig.GetITBIS / 100)
                            LibXGrid1.SetValue(e.row, gColItbis, ITBIS)
                        End If
                    End If
                End If

            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
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

            If LibXGrid1.getCurrentGridView.Count <= 0 Then
                Return True
            End If

            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColQty) = "" Then
                Return True
            End If

            Dim oUnidad As New SGT.Inventario.Entidades.UnidadMedida
            Dim oUnidadParam As New SGT.Inventario.Entidades.UnidadMedida.ParametroConvertirUnidadMinima
            '// Validar Cantidad
            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColentr_serial).ToString.Trim <> "" Then
                SelectStmt = "select * from iventrdd " & _
                             " where entr_serial = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColentr_serial).ToString.Trim & _
                             " and item_code = '" & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColitem_code).ToString.Trim & "'"

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
            Cantidad = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColQty)
            Unidad = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColUnit)
            Precio = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColCosto)

            oUnidadParam.Producto = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColitem_code)
            oUnidadParam.UnidadOrigen = Unidad
            oUnidadParam.Cantidad = Cantidad

            oUnidad.ConvertirUnidadMinima(oUnidadParam)
            sFactor = oUnidad.GetFactor(oUnidadParam.Producto, LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColUnit))

            Existencia = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gcolexistencia)

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

    Private Sub xlk_unit_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_unit_code.BeforeExecuteQuery
        Try
            If LibXGrid1.CurrentRowIndex > -1 Then
                e.aditionalWhere = "item_code = '" & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColitem_code) & "'"
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub xlk_unit_code_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_unit_code.BeforeSetValues
        Dim Costo As Decimal
        Dim Factor As Decimal
        Dim oUnidad As UnidadMedida
        Dim oProducto As SGT.Inventario.Entidades.Articulo
        Dim oParam As UnidadMedida.ParametroConvertirValor
        Dim Unidad As String

        If e.dataFound = False Then
            Exit Sub
        End If

        Try
            If LibXConnector1.IsDataEditing = True Then
                oUnidad = New UnidadMedida
                oProducto = New SGT.Inventario.Entidades.Articulo(LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColitem_code), Me.txtwhse_code.Text)

                Costo = oProducto.Costo
                Factor = oUnidad.GetFactor(oProducto.Codigo, e.row!unit_code)
                Costo = Costo * Factor

                '// Calcular el Costo
                LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, gColCosto, Costo)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub


    Private Sub iventrdd_ColumnChanging(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles ivdevold.ColumnChanging
        If e.Column.ColumnName = "unit_code" Then
            mUnid = e.Row!unit_code.ToString.Trim
        End If
    End Sub

    Private Sub SetFocusToGrid(ByVal RowIndex As Integer)
        LibXGrid1.CurrentCell = New DataGridCell(RowIndex, 0)
        LibXGrid1.Focus()
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.AcceptedAction = LibX.LibxConnectionActions.Add Or e.AcceptedAction = LibX.LibxConnectionActions.Edit Then
                Calcular()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Function GetCantidadDevolver(ByVal item_code As String, ByVal entr_serial As Integer) As Integer
        Dim Selectstmt As String
        Dim Comprada As Integer
        Dim Devuelta As Integer
        Dim Cantidad As Integer

        Selectstmt = "SELECT isnull(iventrdd.qty,0)*ivunitd.factor " & _
                     " from iventrdd inner join ivunitd " & _
                     " on ivunitd.item_code = iventrdd.item_code " & _
                     " where iventrdd.entr_serial = " & entr_serial.ToString.Trim & _
                     " and iventrdd.item_code = '" & item_code.Trim & "'"

        Comprada = Val(LibX.Data.Manager.GetScalar(Selectstmt).ToString.Trim)

        Selectstmt = "SELECT sum(isnull(ivdevold.qty,0)*ivunitd.factor) " & _
                     " from ivdevold inner join ivunitd " & _
                     " on ivunitd.item_code = ivdevold.item_code " & _
                     " where ivdevold.entr_serial = " & entr_serial.ToString.Trim & _
                     " and ivdevold.item_code = '" & item_code.Trim & "'"

        Devuelta = Val(LibX.Data.Manager.GetScalar(Selectstmt).ToString.Trim)

        Cantidad = Comprada - Devuelta

        Return Cantidad

    End Function
    Private Function Getunidaminventa(ByVal item_code As String, ByVal unit_code As String) As String
        Dim Selectstmt As String
        Dim Factor As Decimal
        Dim Unidad As String

        Selectstmt = "SELECT  unit_code from ivitemm where item_code = '" & item_code.Trim & "'"
        Unidad = (LibX.Data.Manager.GetScalar(Selectstmt).ToString.Trim)

        Selectstmt = "SELECT factor from ivunitd where item_code = '" & item_code.Trim & "'" & _
                                            " and unit_code = '" & Unidad.Trim & "'"

        Factor = (LibX.Data.Manager.GetScalar(Selectstmt).ToString.Trim)
        If Factor = 1 And unit_code.Trim <> Unidad Then
            Selectstmt = "SELECT  purch_unit from ivitemm where item_code = '" & item_code.Trim & "'"
            Unidad = (LibX.Data.Manager.GetScalar(Selectstmt).ToString.Trim)

            Selectstmt = "SELECT factor from ivunitd where item_code = '" & item_code.Trim & "'" & _
                                                " and unit_code = '" & unit_code.Trim & "'"

            Factor = (LibX.Data.Manager.GetScalar(Selectstmt).ToString.Trim)
        End If

        Return Factor

    End Function

    Private Sub LibXGrid1_CellKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LibXGrid1.CellKeyPress
        Try

            If Me.LibXConnector1.IsDataEditing = True Then
                If e.KeyCode = Keys.Escape Then
                    LibXGrid1.Focus(LibXGrid1.CurrentRowIndex, 0)
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub xlk_entr_number_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_entr_number.AfterSetValues
        Dim existencia As Decimal

        If e.dataFound = False Then
            Exit Sub
        End If

        If LibXConnector1.IsDataEditing = True Then
            existencia = GetCantidadDevolver(e.row!item_code, e.row!entr_serial)
            Me.lblCantidad.Text = existencia.ToString("##,##0")

            LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.gcolexistencia, existencia)
            LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.gColUnit, e.row!unit_code)
            LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.gColCosto, e.row!costo)
            LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.gColdscto, e.row!dscto)
        End If
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            e.AditionalWhere = "type_code = '" & m_strDocumento.Trim & "'"

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles LibXGrid1.Navigate

    End Sub
End Class
