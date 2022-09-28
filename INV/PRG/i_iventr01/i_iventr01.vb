Imports System.Configuration.ConfigurationSettings
Imports SGT.Inventario.Entidades
Public Class i_iventr01
    Inherits System.Windows.Forms.Form
    Dim mConfig As SGT.Inventario.Common.Configuration
    Dim mArticulo As SGT.Inventario.Entidades.Articulo
    Dim WhereStmt As String

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
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox17 As LibX.XTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents iventrdd As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataTable1 As System.Data.DataTable
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
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents lk_item_code As LibX.LibXLookup
    Friend WithEvents price As System.Data.DataColumn
    Friend WithEvents whse_name As LibX.XTextBox
    Friend WithEvents prov_name As LibX.XTextBox
    Friend WithEvents lk_prov_code As LibX.LibXLookup
    Friend WithEvents lk_whse_code As LibX.LibXLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents type_name As LibX.XTextBox
    Friend WithEvents total_amount As LibX.XTextBox
    Friend WithEvents net_amount As LibX.XTextBox
    Friend WithEvents txtEntr_Number As LibX.XTextBox
    Friend WithEvents txtwhse_code As LibX.XTextBox
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents xdt_Price As LibX.XEditTextBoxColumn
    Friend WithEvents lck_edit_price As LibX.LibxCheckBox
    Friend WithEvents xdt_item_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents xdt_Descr As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_Cantidad As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_Costo As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_Importe As LibX.XEditTextBoxColumn
    Friend WithEvents xck_ITBIS As LibX.LibxCheckBox
    Friend WithEvents xck_dscto As LibX.LibxCheckBox
    Friend WithEvents xck_impto As LibX.LibxCheckBox
    Friend WithEvents btnSerializar As System.Windows.Forms.Button
    Friend WithEvents btnCostos As System.Windows.Forms.Button
    Friend WithEvents btnProductos As System.Windows.Forms.Button
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents xdt_CostoRD As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_priceRD As LibX.XEditTextBoxColumn
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents txtTasa As LibX.XTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFOB As LibX.XTextBox
    Friend WithEvents charge_amt As LibX.XTextBox
    Friend WithEvents fob_amount As LibX.XTextBox
    Friend WithEvents adu_amount As LibX.XTextBox
    Friend WithEvents txtAduana As LibX.XTextBox
    Friend WithEvents txttype_code As LibX.XTextBox
    Friend WithEvents xlk_type_code As LibX.LibXLookup
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents txtprov_code As LibX.XTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox18 As LibX.XTextBox
    Friend WithEvents xdt_entr_date As LibX.LibxDateTimePicker
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rbt_Contado As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_Credito As System.Windows.Forms.RadioButton
    Friend WithEvents cbx_entr_status As LibX.LibXCombo
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.iventrdd = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
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
        Me.price = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataTable1 = New System.Data.DataTable
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
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbx_entr_status = New LibX.LibXCombo
        Me.rbt_Credito = New System.Windows.Forms.RadioButton
        Me.rbt_Contado = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.xdt_entr_date = New LibX.LibxDateTimePicker
        Me.txtFOB = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTasa = New LibX.XTextBox
        Me.lck_edit_price = New LibX.LibxCheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.xck_ITBIS = New LibX.LibxCheckBox
        Me.xck_dscto = New LibX.LibxCheckBox
        Me.xck_impto = New LibX.LibxCheckBox
        Me.lk_prov_code = New LibX.LibXLookup
        Me.lk_whse_code = New LibX.LibXLookup
        Me.txtwhse_code = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtEntr_Number = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.whse_name = New LibX.XTextBox
        Me.txtprov_code = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.prov_name = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox17 = New LibX.XTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBox18 = New LibX.XTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.total_amount = New LibX.XTextBox
        Me.charge_amt = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.fob_amount = New LibX.XTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.adu_amount = New LibX.XTextBox
        Me.net_amount = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txttype_code = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.xlk_type_code = New LibX.LibXLookup
        Me.type_name = New LibX.XTextBox
        Me.txtAduana = New LibX.XTextBox
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.xdt_item_code = New LibX.XDataGridTextButtonColumn
        Me.lk_item_code = New LibX.LibXLookup
        Me.xdt_Descr = New LibX.XEditTextBoxColumn
        Me.xdt_Cantidad = New LibX.XEditTextBoxColumn
        Me.xdt_Costo = New LibX.XEditTextBoxColumn
        Me.xdt_CostoRD = New LibX.XEditTextBoxColumn
        Me.xdt_Price = New LibX.XEditTextBoxColumn
        Me.xdt_priceRD = New LibX.XEditTextBoxColumn
        Me.xdt_Importe = New LibX.XEditTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnSerializar = New System.Windows.Forms.Button
        Me.btnProductos = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.btnSetup = New System.Windows.Forms.Button
        Me.btnCostos = New System.Windows.Forms.Button
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iventrdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(786, 24)
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
        Me.LibXConnector1.DataMember = "iventrdm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.iventrdd, Me.DataTable1})
        '
        'iventrdd
        '
        Me.iventrdd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.price, Me.DataColumn33, Me.DataColumn32, Me.DataColumn34, Me.DataColumn36, Me.DataColumn38})
        Me.iventrdd.TableName = "iventrdd"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Importe"
        Me.DataColumn1.DataType = GetType(System.Decimal)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "entr_number"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.AutoIncrement = True
        Me.DataColumn23.AutoIncrementSeed = CType(1, Long)
        Me.DataColumn23.ColumnName = "line_no"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "whse_code"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "item_code"
        Me.DataColumn25.MaxLength = 15
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "unit_code"
        Me.DataColumn26.MaxLength = 5
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "qty"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.ColumnName = "costo"
        Me.DataColumn28.DataType = GetType(System.Decimal)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "dscto"
        Me.DataColumn29.DataType = GetType(System.Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "itbis"
        Me.DataColumn30.DataType = GetType(System.Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "impto"
        Me.DataColumn31.DataType = GetType(System.Decimal)
        '
        'price
        '
        Me.price.AllowDBNull = False
        Me.price.ColumnName = "price"
        Me.price.DataType = GetType(System.Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.AllowDBNull = False
        Me.DataColumn33.ColumnName = "item_name"
        Me.DataColumn33.MaxLength = 100
        '
        'DataColumn32
        '
        Me.DataColumn32.AllowDBNull = False
        Me.DataColumn32.ColumnName = "purch_unit_cost"
        Me.DataColumn32.DataType = GetType(System.Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "sales_price"
        Me.DataColumn34.DataType = GetType(System.Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "costrd"
        Me.DataColumn36.DataType = GetType(System.Decimal)
        '
        'DataColumn38
        '
        Me.DataColumn38.AllowDBNull = False
        Me.DataColumn38.ColumnName = "entr_serial"
        Me.DataColumn38.DataType = GetType(System.Int32)
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn35, Me.DataColumn37, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"entr_number", "prov_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn2, Me.DataColumn6}
        Me.DataTable1.TableName = "iventrdm"
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "entr_number"
        Me.DataColumn2.MaxLength = 20
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "mon_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "type_code"
        Me.DataColumn4.MaxLength = 3
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "whse_code"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "prov_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "entr_date"
        Me.DataColumn7.DataType = GetType(System.DateTime)
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "total_amount"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "fob_amount"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "gastos_gen"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "gastos_aduana"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "tasa"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "disc_amount"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "itbis_amount"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "aply_impto"
        Me.DataColumn15.DataType = GetType(System.Int16)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "impto_amount"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "aply_dscto"
        Me.DataColumn17.DataType = GetType(System.Int16)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "entr_status"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "aply_itbis"
        Me.DataColumn19.DataType = GetType(System.Int16)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "date_created"
        Me.DataColumn20.DataType = GetType(System.DateTime)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "userid"
        Me.DataColumn21.MaxLength = 20
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "edit_price"
        Me.DataColumn35.DataType = GetType(System.Int16)
        '
        'DataColumn37
        '
        Me.DataColumn37.AllowDBNull = False
        Me.DataColumn37.AutoIncrement = True
        Me.DataColumn37.ColumnName = "entr_serial"
        Me.DataColumn37.DataType = GetType(System.Int32)
        Me.DataColumn37.ReadOnly = True
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "entr_cond"
        Me.DataColumn39.DataType = GetType(System.Int32)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "apli_ofert"
        Me.DataColumn40.DataType = GetType(System.Int16)
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
        Me.LibXDbSourceTable1.SerialColumnName = "entr_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select iventrdm.* from iventrdm ", "inner join ivtypem on iventrdm.type_code = ivtypem.type_code", "and ivtypem.type_local = 0"}
        Me.LibXDbSourceTable1.TableName = "iventrdm"
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
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"entr_serial=entr_serial", "whse_code=whse_code"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = ""
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select iventrdd.*,ivitemm.item_name", "from iventrdd inner join ivitemm", "on iventrdd.item_code = ivitemm.item_code"}
        Me.LibXDbSourceTable2.TableName = "iventrdd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbx_entr_status)
        Me.GroupBox1.Controls.Add(Me.rbt_Credito)
        Me.GroupBox1.Controls.Add(Me.rbt_Contado)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.xdt_entr_date)
        Me.GroupBox1.Controls.Add(Me.txtFOB)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTasa)
        Me.GroupBox1.Controls.Add(Me.lck_edit_price)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lk_prov_code)
        Me.GroupBox1.Controls.Add(Me.lk_whse_code)
        Me.GroupBox1.Controls.Add(Me.txtwhse_code)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtEntr_Number)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.whse_name)
        Me.GroupBox1.Controls.Add(Me.txtprov_code)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.prov_name)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBox17)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TextBox18)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.total_amount)
        Me.GroupBox1.Controls.Add(Me.charge_amt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.fob_amount)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.adu_amount)
        Me.GroupBox1.Controls.Add(Me.net_amount)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txttype_code)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.xlk_type_code)
        Me.GroupBox1.Controls.Add(Me.type_name)
        Me.GroupBox1.Controls.Add(Me.txtAduana)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 168)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cbx_entr_status
        '
        Me.cbx_entr_status.AllowDefaultSort = True
        Me.cbx_entr_status.bound = True
        Me.cbx_entr_status.currValue = Nothing
        Me.cbx_entr_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "iventrdm.entr_status"))
        Me.cbx_entr_status.DefaultWhereString = Nothing
        Me.cbx_entr_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_entr_status.EditInitialValue = Nothing
        Me.cbx_entr_status.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cbx_entr_status.FieldDescription = ""
        Me.cbx_entr_status.FindInitialValue = Nothing
        Me.cbx_entr_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cbx_entr_status.IgnoreRequiered = False
        Me.cbx_entr_status.Items.AddRange(New Object() {"1-Aplicada", "2-Pendiente de aplicar", "3-Anulada"})
        Me.cbx_entr_status.Location = New System.Drawing.Point(264, 40)
        Me.cbx_entr_status.LookupKeyDisplayFields = Nothing
        Me.cbx_entr_status.LookupKeyField = Nothing
        Me.cbx_entr_status.LookupTableName = Nothing
        Me.cbx_entr_status.Name = "cbx_entr_status"
        Me.cbx_entr_status.NewInitialValue = Nothing
        Me.cbx_entr_status.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cbx_entr_status.Requiered = False
        Me.cbx_entr_status.Required = False
        Me.cbx_entr_status.Size = New System.Drawing.Size(121, 21)
        Me.cbx_entr_status.SqlString = Nothing
        Me.cbx_entr_status.StatusBarPanelDescripcion = Nothing
        Me.cbx_entr_status.TabIndex = 41
        '
        'rbt_Credito
        '
        Me.rbt_Credito.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbt_Credito.Location = New System.Drawing.Point(160, 136)
        Me.rbt_Credito.Name = "rbt_Credito"
        Me.rbt_Credito.Size = New System.Drawing.Size(64, 24)
        Me.rbt_Credito.TabIndex = 40
        Me.rbt_Credito.Text = "Crédito"
        '
        'rbt_Contado
        '
        Me.rbt_Contado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbt_Contado.Location = New System.Drawing.Point(80, 136)
        Me.rbt_Contado.Name = "rbt_Contado"
        Me.rbt_Contado.Size = New System.Drawing.Size(72, 24)
        Me.rbt_Contado.TabIndex = 39
        Me.rbt_Contado.Text = "Contado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(8, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Condición:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xdt_entr_date
        '
        Me.xdt_entr_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_entr_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "iventrdm.entr_date"))
        Me.xdt_entr_date.EditInitialValue = Nothing
        Me.xdt_entr_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_entr_date.FieldDescription = ""
        Me.xdt_entr_date.FindInitialValue = Nothing
        Me.xdt_entr_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_entr_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_entr_date.IgnoreRequiered = False
        Me.xdt_entr_date.Location = New System.Drawing.Point(80, 88)
        Me.xdt_entr_date.Name = "xdt_entr_date"
        Me.xdt_entr_date.NewInitialValue = Nothing
        Me.xdt_entr_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_entr_date.Requiered = False
        Me.xdt_entr_date.Size = New System.Drawing.Size(88, 20)
        Me.xdt_entr_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_entr_date.TabIndex = 9
        '
        'txtFOB
        '
        Me.txtFOB.AcceptsReturn = True
        Me.txtFOB.EditInitialValue = Nothing
        Me.txtFOB.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtFOB.FieldDescription = ""
        Me.txtFOB.FindInitialValue = Nothing
        Me.txtFOB.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtFOB.IgnoreRequiered = False
        Me.txtFOB.Location = New System.Drawing.Point(533, 40)
        Me.txtFOB.Name = "txtFOB"
        Me.txtFOB.NewInitialValue = Nothing
        Me.txtFOB.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtFOB.ReadOnly = True
        Me.txtFOB.Requiered = False
        Me.txtFOB.Size = New System.Drawing.Size(71, 20)
        Me.txtFOB.StatusBarPanelDescripcion = Nothing
        Me.txtFOB.TabIndex = 34
        Me.txtFOB.Text = ""
        Me.txtFOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(220, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 16)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Tasa:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTasa
        '
        Me.txtTasa.AcceptsReturn = True
        Me.txtTasa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.tasa"))
        Me.txtTasa.EditInitialValue = Nothing
        Me.txtTasa.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTasa.FieldDescription = ""
        Me.txtTasa.FindInitialValue = Nothing
        Me.txtTasa.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTasa.IgnoreRequiered = False
        Me.txtTasa.Location = New System.Drawing.Point(264, 88)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.NewInitialValue = Nothing
        Me.txtTasa.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTasa.ReadOnly = True
        Me.txtTasa.Requiered = False
        Me.txtTasa.Size = New System.Drawing.Size(120, 20)
        Me.txtTasa.StatusBarPanelDescripcion = Nothing
        Me.txtTasa.TabIndex = 37
        Me.txtTasa.Text = ""
        '
        'lck_edit_price
        '
        Me.lck_edit_price.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lck_edit_price.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "iventrdm.edit_price"))
        Me.lck_edit_price.EditInitialValue = Nothing
        Me.lck_edit_price.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lck_edit_price.FindInitialValue = Nothing
        Me.lck_edit_price.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lck_edit_price.IgnoreRequiered = False
        Me.lck_edit_price.KeepEnabled = False
        Me.lck_edit_price.Location = New System.Drawing.Point(632, 16)
        Me.lck_edit_price.Name = "lck_edit_price"
        Me.lck_edit_price.NewInitialValue = Nothing
        Me.lck_edit_price.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lck_edit_price.ReadOnly = False
        Me.lck_edit_price.Requiered = False
        Me.lck_edit_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lck_edit_price.Size = New System.Drawing.Size(120, 16)
        Me.lck_edit_price.TabIndex = 19
        Me.lck_edit_price.Text = "Editar Precio"
        Me.lck_edit_price.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lck_edit_price.ThreeState = True
        Me.lck_edit_price.value = Nothing
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.xck_ITBIS)
        Me.GroupBox2.Controls.Add(Me.xck_dscto)
        Me.GroupBox2.Controls.Add(Me.xck_impto)
        Me.GroupBox2.Location = New System.Drawing.Point(624, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 72)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Incluir"
        '
        'xck_ITBIS
        '
        Me.xck_ITBIS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xck_ITBIS.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "iventrdm.aply_itbis"))
        Me.xck_ITBIS.EditInitialValue = Nothing
        Me.xck_ITBIS.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_ITBIS.FindInitialValue = Nothing
        Me.xck_ITBIS.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_ITBIS.IgnoreRequiered = False
        Me.xck_ITBIS.KeepEnabled = False
        Me.xck_ITBIS.Location = New System.Drawing.Point(8, 16)
        Me.xck_ITBIS.Name = "xck_ITBIS"
        Me.xck_ITBIS.NewInitialValue = Nothing
        Me.xck_ITBIS.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_ITBIS.ReadOnly = False
        Me.xck_ITBIS.Requiered = False
        Me.xck_ITBIS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xck_ITBIS.Size = New System.Drawing.Size(120, 16)
        Me.xck_ITBIS.TabIndex = 0
        Me.xck_ITBIS.Text = "FOB"
        Me.xck_ITBIS.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.xck_ITBIS.ThreeState = True
        Me.xck_ITBIS.value = Nothing
        '
        'xck_dscto
        '
        Me.xck_dscto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xck_dscto.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "iventrdm.aply_dscto"))
        Me.xck_dscto.EditInitialValue = Nothing
        Me.xck_dscto.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_dscto.FindInitialValue = Nothing
        Me.xck_dscto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_dscto.IgnoreRequiered = False
        Me.xck_dscto.KeepEnabled = False
        Me.xck_dscto.Location = New System.Drawing.Point(8, 48)
        Me.xck_dscto.Name = "xck_dscto"
        Me.xck_dscto.NewInitialValue = Nothing
        Me.xck_dscto.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_dscto.ReadOnly = False
        Me.xck_dscto.Requiered = False
        Me.xck_dscto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xck_dscto.Size = New System.Drawing.Size(120, 16)
        Me.xck_dscto.TabIndex = 2
        Me.xck_dscto.Text = "Gastos Generales"
        Me.xck_dscto.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.xck_dscto.ThreeState = True
        Me.xck_dscto.value = Nothing
        '
        'xck_impto
        '
        Me.xck_impto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xck_impto.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "iventrdm.aply_impto"))
        Me.xck_impto.EditInitialValue = Nothing
        Me.xck_impto.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_impto.FindInitialValue = Nothing
        Me.xck_impto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_impto.IgnoreRequiered = False
        Me.xck_impto.KeepEnabled = False
        Me.xck_impto.Location = New System.Drawing.Point(8, 32)
        Me.xck_impto.Name = "xck_impto"
        Me.xck_impto.NewInitialValue = Nothing
        Me.xck_impto.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_impto.ReadOnly = False
        Me.xck_impto.Requiered = False
        Me.xck_impto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xck_impto.Size = New System.Drawing.Size(120, 16)
        Me.xck_impto.TabIndex = 1
        Me.xck_impto.Text = "Gastos Aduanales"
        Me.xck_impto.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.xck_impto.ThreeState = True
        Me.xck_impto.value = Nothing
        '
        'lk_prov_code
        '
        Me.lk_prov_code.AlternateFieldSearch = Nothing
        Me.lk_prov_code.BeginCheck = False
        Me.lk_prov_code.CheckText = Nothing
        Me.lk_prov_code.ComboMode = False
        Me.lk_prov_code.DataMember = Nothing
        Me.lk_prov_code.DataSource = Me.LibXConnector1
        Me.lk_prov_code.DestParameters = New String() {"prov_code=prov_code", "prov_name=prov_name"}
        Me.lk_prov_code.FilterField = ""
        Me.lk_prov_code.IgnoreFindInBrowseMode = False
        Me.lk_prov_code.isCanceled = False
        Me.lk_prov_code.Location = New System.Drawing.Point(368, 64)
        Me.lk_prov_code.LookCaption = "Suplidores"
        Me.lk_prov_code.Name = "lk_prov_code"
        Me.lk_prov_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lk_prov_code.ShowFilter = True
        Me.lk_prov_code.ShowMessageNotFound = True
        Me.lk_prov_code.ShowWarning = False
        Me.lk_prov_code.Size = New System.Drawing.Size(16, 20)
        Me.lk_prov_code.SizesColumns = Nothing
        Me.lk_prov_code.SizesColumnsTab = Nothing
        Me.lk_prov_code.SqlString = Nothing
        Me.lk_prov_code.SQLTab = Nothing
        Me.lk_prov_code.SrcParameters = New String() {"prov_code=prov_code"}
        Me.lk_prov_code.TabIndex = 25
        Me.lk_prov_code.TableName = "cpprovm"
        Me.lk_prov_code.TabStop = False
        Me.lk_prov_code.UseCopyConnection = False
        Me.lk_prov_code.UseRowRetrieveEvents = False
        Me.lk_prov_code.UseTab = False
        Me.lk_prov_code.VisParameters = New String() {"Código=prov_code", "Nombre=prov_name", "Contacto=contact_name"}
        Me.lk_prov_code.WhereCondition = Nothing
        Me.lk_prov_code.WhereParameters = Nothing
        '
        'lk_whse_code
        '
        Me.lk_whse_code.AlternateFieldSearch = Nothing
        Me.lk_whse_code.BeginCheck = False
        Me.lk_whse_code.CheckText = Nothing
        Me.lk_whse_code.ComboMode = False
        Me.lk_whse_code.DataMember = Nothing
        Me.lk_whse_code.DataSource = Me.LibXConnector1
        Me.lk_whse_code.DestParameters = New String() {"whse_code=whse_code", "whse_name=whse_name"}
        Me.lk_whse_code.FilterField = Nothing
        Me.lk_whse_code.IgnoreFindInBrowseMode = False
        Me.lk_whse_code.isCanceled = False
        Me.lk_whse_code.Location = New System.Drawing.Point(368, 112)
        Me.lk_whse_code.LookCaption = "Almacenes"
        Me.lk_whse_code.Name = "lk_whse_code"
        Me.lk_whse_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lk_whse_code.ShowFilter = True
        Me.lk_whse_code.ShowMessageNotFound = True
        Me.lk_whse_code.ShowWarning = False
        Me.lk_whse_code.Size = New System.Drawing.Size(16, 20)
        Me.lk_whse_code.SizesColumns = Nothing
        Me.lk_whse_code.SizesColumnsTab = Nothing
        Me.lk_whse_code.SqlString = Nothing
        Me.lk_whse_code.SQLTab = Nothing
        Me.lk_whse_code.SrcParameters = New String() {"whse_code=whse_code"}
        Me.lk_whse_code.TabIndex = 26
        Me.lk_whse_code.TableName = "ivwhsem"
        Me.lk_whse_code.TabStop = False
        Me.lk_whse_code.UseCopyConnection = False
        Me.lk_whse_code.UseRowRetrieveEvents = False
        Me.lk_whse_code.UseTab = False
        Me.lk_whse_code.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.lk_whse_code.WhereCondition = Nothing
        Me.lk_whse_code.WhereParameters = Nothing
        '
        'txtwhse_code
        '
        Me.txtwhse_code.AcceptsReturn = True
        Me.txtwhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.whse_code"))
        Me.txtwhse_code.EditInitialValue = Nothing
        Me.txtwhse_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.FieldDescription = ""
        Me.txtwhse_code.FindInitialValue = Nothing
        Me.txtwhse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.IgnoreRequiered = False
        Me.txtwhse_code.Location = New System.Drawing.Point(80, 112)
        Me.txtwhse_code.Name = "txtwhse_code"
        Me.txtwhse_code.NewInitialValue = Nothing
        Me.txtwhse_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.Requiered = False
        Me.txtwhse_code.Size = New System.Drawing.Size(56, 20)
        Me.txtwhse_code.StatusBarPanelDescripcion = Nothing
        Me.txtwhse_code.TabIndex = 11
        Me.txtwhse_code.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(24, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Almacén:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtEntr_Number
        '
        Me.txtEntr_Number.AcceptsReturn = True
        Me.txtEntr_Number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.entr_number"))
        Me.txtEntr_Number.EditInitialValue = Nothing
        Me.txtEntr_Number.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtEntr_Number.FieldDescription = ""
        Me.txtEntr_Number.FindInitialValue = Nothing
        Me.txtEntr_Number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtEntr_Number.IgnoreRequiered = False
        Me.txtEntr_Number.Location = New System.Drawing.Point(80, 40)
        Me.txtEntr_Number.Name = "txtEntr_Number"
        Me.txtEntr_Number.NewInitialValue = Nothing
        Me.txtEntr_Number.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtEntr_Number.Requiered = False
        Me.txtEntr_Number.Size = New System.Drawing.Size(88, 20)
        Me.txtEntr_Number.StatusBarPanelDescripcion = Nothing
        Me.txtEntr_Number.TabIndex = 3
        Me.txtEntr_Number.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Factura No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.whse_name.Location = New System.Drawing.Point(144, 112)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.NewInitialValue = Nothing
        Me.whse_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.ReadOnly = True
        Me.whse_name.Requiered = False
        Me.whse_name.Size = New System.Drawing.Size(224, 20)
        Me.whse_name.StatusBarPanelDescripcion = Nothing
        Me.whse_name.TabIndex = 24
        Me.whse_name.TabStop = False
        Me.whse_name.Text = ""
        '
        'txtprov_code
        '
        Me.txtprov_code.AcceptsReturn = True
        Me.txtprov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.prov_code"))
        Me.txtprov_code.EditInitialValue = Nothing
        Me.txtprov_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.FieldDescription = ""
        Me.txtprov_code.FindInitialValue = Nothing
        Me.txtprov_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.IgnoreRequiered = False
        Me.txtprov_code.Location = New System.Drawing.Point(80, 64)
        Me.txtprov_code.Name = "txtprov_code"
        Me.txtprov_code.NewInitialValue = Nothing
        Me.txtprov_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.Requiered = False
        Me.txtprov_code.Size = New System.Drawing.Size(56, 20)
        Me.txtprov_code.StatusBarPanelDescripcion = Nothing
        Me.txtprov_code.TabIndex = 7
        Me.txtprov_code.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(26, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Suplidor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.prov_name.Location = New System.Drawing.Point(144, 64)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.NewInitialValue = Nothing
        Me.prov_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.ReadOnly = True
        Me.prov_name.Requiered = False
        Me.prov_name.Size = New System.Drawing.Size(224, 20)
        Me.prov_name.StatusBarPanelDescripcion = Nothing
        Me.prov_name.TabIndex = 23
        Me.prov_name.TabStop = False
        Me.prov_name.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(36, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Fecha:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(616, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Usuario:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox17
        '
        Me.TextBox17.AcceptsReturn = True
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.userid"))
        Me.TextBox17.EditInitialValue = Nothing
        Me.TextBox17.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox17.FieldDescription = ""
        Me.TextBox17.FindInitialValue = Nothing
        Me.TextBox17.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox17.IgnoreRequiered = False
        Me.TextBox17.Location = New System.Drawing.Point(664, 112)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.NewInitialValue = Nothing
        Me.TextBox17.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox17.ReadOnly = True
        Me.TextBox17.Requiered = False
        Me.TextBox17.Size = New System.Drawing.Size(96, 20)
        Me.TextBox17.StatusBarPanelDescripcion = Nothing
        Me.TextBox17.TabIndex = 31
        Me.TextBox17.TabStop = False
        Me.TextBox17.Text = ""
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(616, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 16)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Creado:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox18
        '
        Me.TextBox18.AcceptsReturn = True
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.date_created"))
        Me.TextBox18.EditInitialValue = Nothing
        Me.TextBox18.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox18.FieldDescription = ""
        Me.TextBox18.FindInitialValue = Nothing
        Me.TextBox18.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox18.IgnoreRequiered = False
        Me.TextBox18.Location = New System.Drawing.Point(664, 136)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.NewInitialValue = Nothing
        Me.TextBox18.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox18.ReadOnly = True
        Me.TextBox18.Requiered = False
        Me.TextBox18.Size = New System.Drawing.Size(96, 20)
        Me.TextBox18.StatusBarPanelDescripcion = Nothing
        Me.TextBox18.TabIndex = 33
        Me.TextBox18.TabStop = False
        Me.TextBox18.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(208, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 16)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Estatus:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(408, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Monto Bruto US:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'total_amount
        '
        Me.total_amount.AcceptsReturn = True
        Me.total_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.total_amount"))
        Me.total_amount.EditInitialValue = Nothing
        Me.total_amount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.total_amount.FieldDescription = ""
        Me.total_amount.FindInitialValue = Nothing
        Me.total_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.total_amount.IgnoreRequiered = False
        Me.total_amount.Location = New System.Drawing.Point(504, 16)
        Me.total_amount.Name = "total_amount"
        Me.total_amount.NewInitialValue = Nothing
        Me.total_amount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.total_amount.Requiered = False
        Me.total_amount.StatusBarPanelDescripcion = Nothing
        Me.total_amount.TabIndex = 12
        Me.total_amount.Text = ""
        Me.total_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'charge_amt
        '
        Me.charge_amt.AcceptsReturn = True
        Me.charge_amt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.gastos_gen"))
        Me.charge_amt.EditInitialValue = Nothing
        Me.charge_amt.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.charge_amt.FieldDescription = ""
        Me.charge_amt.FindInitialValue = Nothing
        Me.charge_amt.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.charge_amt.IgnoreRequiered = False
        Me.charge_amt.Location = New System.Drawing.Point(504, 88)
        Me.charge_amt.Name = "charge_amt"
        Me.charge_amt.NewInitialValue = Nothing
        Me.charge_amt.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.charge_amt.Requiered = False
        Me.charge_amt.StatusBarPanelDescripcion = Nothing
        Me.charge_amt.TabIndex = 18
        Me.charge_amt.Text = ""
        Me.charge_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(397, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Gastos Generales:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'fob_amount
        '
        Me.fob_amount.AcceptsReturn = True
        Me.fob_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.fob_amount"))
        Me.fob_amount.EditInitialValue = Nothing
        Me.fob_amount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fob_amount.FieldDescription = ""
        Me.fob_amount.FindInitialValue = Nothing
        Me.fob_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fob_amount.IgnoreRequiered = False
        Me.fob_amount.Location = New System.Drawing.Point(504, 40)
        Me.fob_amount.Name = "fob_amount"
        Me.fob_amount.NewInitialValue = Nothing
        Me.fob_amount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fob_amount.Requiered = False
        Me.fob_amount.Size = New System.Drawing.Size(24, 20)
        Me.fob_amount.StatusBarPanelDescripcion = Nothing
        Me.fob_amount.TabIndex = 14
        Me.fob_amount.Text = ""
        Me.fob_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(424, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "% Flete FOB:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(384, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 16)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "% Gastos Aduanales:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'adu_amount
        '
        Me.adu_amount.AcceptsReturn = True
        Me.adu_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.gastos_aduana"))
        Me.adu_amount.EditInitialValue = Nothing
        Me.adu_amount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.adu_amount.FieldDescription = ""
        Me.adu_amount.FindInitialValue = Nothing
        Me.adu_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.adu_amount.IgnoreRequiered = False
        Me.adu_amount.Location = New System.Drawing.Point(504, 64)
        Me.adu_amount.Name = "adu_amount"
        Me.adu_amount.NewInitialValue = Nothing
        Me.adu_amount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.adu_amount.Requiered = False
        Me.adu_amount.Size = New System.Drawing.Size(24, 20)
        Me.adu_amount.StatusBarPanelDescripcion = Nothing
        Me.adu_amount.TabIndex = 16
        Me.adu_amount.Text = ""
        Me.adu_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'net_amount
        '
        Me.net_amount.AcceptsReturn = True
        Me.net_amount.EditInitialValue = Nothing
        Me.net_amount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.net_amount.FieldDescription = ""
        Me.net_amount.FindInitialValue = Nothing
        Me.net_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.net_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.net_amount.ForeColor = System.Drawing.Color.Blue
        Me.net_amount.IgnoreRequiered = False
        Me.net_amount.Location = New System.Drawing.Point(504, 112)
        Me.net_amount.Name = "net_amount"
        Me.net_amount.NewInitialValue = Nothing
        Me.net_amount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.net_amount.ReadOnly = True
        Me.net_amount.Requiered = False
        Me.net_amount.StatusBarPanelDescripcion = Nothing
        Me.net_amount.TabIndex = 29
        Me.net_amount.TabStop = False
        Me.net_amount.Text = ""
        Me.net_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(418, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Total Neto US:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txttype_code
        '
        Me.txttype_code.AcceptsReturn = True
        Me.txttype_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttype_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.type_code"))
        Me.txttype_code.EditInitialValue = Nothing
        Me.txttype_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txttype_code.FieldDescription = ""
        Me.txttype_code.FindInitialValue = Nothing
        Me.txttype_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txttype_code.IgnoreRequiered = False
        Me.txttype_code.Location = New System.Drawing.Point(80, 16)
        Me.txttype_code.Name = "txttype_code"
        Me.txttype_code.NewInitialValue = Nothing
        Me.txttype_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txttype_code.Requiered = False
        Me.txttype_code.Size = New System.Drawing.Size(56, 20)
        Me.txttype_code.StatusBarPanelDescripcion = Nothing
        Me.txttype_code.TabIndex = 1
        Me.txttype_code.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(10, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Documento:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_type_code
        '
        Me.xlk_type_code.AlternateFieldSearch = Nothing
        Me.xlk_type_code.BeginCheck = False
        Me.xlk_type_code.CheckText = Nothing
        Me.xlk_type_code.ComboMode = False
        Me.xlk_type_code.DataMember = Nothing
        Me.xlk_type_code.DataSource = Me.LibXConnector1
        Me.xlk_type_code.DestParameters = New String() {"type_code=type_code", "type_name=type_name"}
        Me.xlk_type_code.FilterField = Nothing
        Me.xlk_type_code.IgnoreFindInBrowseMode = False
        Me.xlk_type_code.isCanceled = False
        Me.xlk_type_code.Location = New System.Drawing.Point(368, 16)
        Me.xlk_type_code.LookCaption = "Tipos de Documntos"
        Me.xlk_type_code.Name = "xlk_type_code"
        Me.xlk_type_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_type_code.ShowFilter = True
        Me.xlk_type_code.ShowMessageNotFound = True
        Me.xlk_type_code.ShowWarning = False
        Me.xlk_type_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_type_code.SizesColumns = Nothing
        Me.xlk_type_code.SizesColumnsTab = Nothing
        Me.xlk_type_code.SqlString = Nothing
        Me.xlk_type_code.SQLTab = Nothing
        Me.xlk_type_code.SrcParameters = New String() {"type_code=type_code"}
        Me.xlk_type_code.TabIndex = 22
        Me.xlk_type_code.TableName = "ivtypem"
        Me.xlk_type_code.TabStop = False
        Me.xlk_type_code.UseCopyConnection = False
        Me.xlk_type_code.UseRowRetrieveEvents = False
        Me.xlk_type_code.UseTab = False
        Me.xlk_type_code.VisParameters = New String() {"Código=type_code", "Descripción=type_name"}
        Me.xlk_type_code.WhereCondition = ""
        Me.xlk_type_code.WhereParameters = Nothing
        '
        'type_name
        '
        Me.type_name.AcceptsReturn = True
        Me.type_name.EditInitialValue = Nothing
        Me.type_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.type_name.FieldDescription = ""
        Me.type_name.FindInitialValue = Nothing
        Me.type_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.type_name.IgnoreRequiered = False
        Me.type_name.Location = New System.Drawing.Point(144, 16)
        Me.type_name.Name = "type_name"
        Me.type_name.NewInitialValue = Nothing
        Me.type_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.type_name.ReadOnly = True
        Me.type_name.Requiered = False
        Me.type_name.Size = New System.Drawing.Size(224, 20)
        Me.type_name.StatusBarPanelDescripcion = Nothing
        Me.type_name.TabIndex = 21
        Me.type_name.TabStop = False
        Me.type_name.Text = ""
        '
        'txtAduana
        '
        Me.txtAduana.AcceptsReturn = True
        Me.txtAduana.EditInitialValue = Nothing
        Me.txtAduana.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAduana.FieldDescription = ""
        Me.txtAduana.FindInitialValue = Nothing
        Me.txtAduana.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAduana.IgnoreRequiered = False
        Me.txtAduana.Location = New System.Drawing.Point(533, 64)
        Me.txtAduana.Name = "txtAduana"
        Me.txtAduana.NewInitialValue = Nothing
        Me.txtAduana.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAduana.ReadOnly = True
        Me.txtAduana.Requiered = False
        Me.txtAduana.Size = New System.Drawing.Size(71, 20)
        Me.txtAduana.StatusBarPanelDescripcion = Nothing
        Me.txtAduana.TabIndex = 35
        Me.txtAduana.Text = ""
        Me.txtAduana.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Articulos"
        Me.LibXGrid1.DataMember = "iventrdd"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 208)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(768, 184)
        Me.LibXGrid1.TabIndex = 2
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.xdt_item_code, Me.xdt_Descr, Me.xdt_Cantidad, Me.xdt_Costo, Me.xdt_CostoRD, Me.xdt_Price, Me.xdt_priceRD, Me.xdt_Importe})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "iventrdd"
        '
        'xdt_item_code
        '
        Me.xdt_item_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.xdt_item_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_item_code.executeFindDuringFill = False
        Me.xdt_item_code.Format = ""
        Me.xdt_item_code.FormatInfo = Nothing
        Me.xdt_item_code.HeaderText = "Articulo"
        Me.xdt_item_code.isReadOnly = False
        Me.xdt_item_code.Lookup = Me.lk_item_code
        Me.xdt_item_code.MappingName = "item_code"
        Me.xdt_item_code.MaxLength = 32767
        Me.xdt_item_code.TabStop = True
        Me.xdt_item_code.UseCustomCellFormat = False
        Me.xdt_item_code.Width = 75
        '
        'lk_item_code
        '
        Me.lk_item_code.AlternateFieldSearch = Nothing
        Me.lk_item_code.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lk_item_code.BeginCheck = False
        Me.lk_item_code.CheckText = Nothing
        Me.lk_item_code.ComboMode = False
        Me.lk_item_code.DataMember = Nothing
        Me.lk_item_code.DataSource = Me.LibXConnector1
        Me.lk_item_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "costo=purch_cost", "whse_code=whse_code", "price=price"}
        Me.lk_item_code.FilterField = "item_name"
        Me.lk_item_code.IgnoreFindInBrowseMode = False
        Me.lk_item_code.isCanceled = False
        Me.lk_item_code.Location = New System.Drawing.Point(368, 400)
        Me.lk_item_code.LookCaption = "Productos"
        Me.lk_item_code.Name = "lk_item_code"
        Me.lk_item_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lk_item_code.ShowFilter = True
        Me.lk_item_code.ShowMessageNotFound = True
        Me.lk_item_code.ShowWarning = False
        Me.lk_item_code.Size = New System.Drawing.Size(16, 20)
        Me.lk_item_code.SizesColumns = Nothing
        Me.lk_item_code.SizesColumnsTab = Nothing
        Me.lk_item_code.SqlString = New String() {"select ivitemm.item_code,ivitemm.item_name,", "ivitemd.whse_code,ivitemm.purch_unit,", "ivitemd.purch_cost,ivitemd.price,ivitemd.existencia ", "from ivitemm inner join ivitemd", "on ivitemm.item_code=ivitemd.item_code"}
        Me.lk_item_code.SQLTab = Nothing
        Me.lk_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.lk_item_code.TabIndex = 4
        Me.lk_item_code.TableName = "ivitemm"
        Me.lk_item_code.TabStop = False
        Me.lk_item_code.UseCopyConnection = False
        Me.lk_item_code.UseRowRetrieveEvents = False
        Me.lk_item_code.UseTab = False
        Me.lk_item_code.VisParameters = New String() {"Código=item_code", "Descripción=item_name", "Almacén=whse_code", "Costo=purch_cost", "Unidad=purch_unit", "Precio=price", "Existecia=existencia"}
        Me.lk_item_code.WhereCondition = Nothing
        Me.lk_item_code.WhereParameters = Nothing
        '
        'xdt_Descr
        '
        Me.xdt_Descr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Descr.Format = ""
        Me.xdt_Descr.FormatInfo = Nothing
        Me.xdt_Descr.HeaderText = "Descripción"
        Me.xdt_Descr.ImageList = Nothing
        Me.xdt_Descr.isReadOnly = False
        Me.xdt_Descr.MappingName = "item_name"
        Me.xdt_Descr.MaxLength = 32767
        Me.xdt_Descr.ReadOnly = True
        Me.xdt_Descr.TabStop = True
        Me.xdt_Descr.UseCustomCellFormat = False
        Me.xdt_Descr.Width = 200
        '
        'xdt_Cantidad
        '
        Me.xdt_Cantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Cantidad.Format = "##,##0"
        Me.xdt_Cantidad.FormatInfo = Nothing
        Me.xdt_Cantidad.HeaderText = "Cantidad"
        Me.xdt_Cantidad.ImageList = Nothing
        Me.xdt_Cantidad.isReadOnly = False
        Me.xdt_Cantidad.MappingName = "qty"
        Me.xdt_Cantidad.MaxLength = 32767
        Me.xdt_Cantidad.TabStop = True
        Me.xdt_Cantidad.UseCustomCellFormat = False
        Me.xdt_Cantidad.Width = 75
        '
        'xdt_Costo
        '
        Me.xdt_Costo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Costo.Format = "##,###,##0.00"
        Me.xdt_Costo.FormatInfo = Nothing
        Me.xdt_Costo.HeaderText = "Costo US"
        Me.xdt_Costo.ImageList = Nothing
        Me.xdt_Costo.isReadOnly = False
        Me.xdt_Costo.MappingName = "costo"
        Me.xdt_Costo.MaxLength = 32767
        Me.xdt_Costo.TabStop = True
        Me.xdt_Costo.UseCustomCellFormat = False
        Me.xdt_Costo.Width = 75
        '
        'xdt_CostoRD
        '
        Me.xdt_CostoRD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_CostoRD.Format = "##,###,##0.00"
        Me.xdt_CostoRD.FormatInfo = Nothing
        Me.xdt_CostoRD.HeaderText = "Costo RD"
        Me.xdt_CostoRD.ImageList = Nothing
        Me.xdt_CostoRD.isReadOnly = False
        Me.xdt_CostoRD.MappingName = "costrd"
        Me.xdt_CostoRD.MaxLength = 32767
        Me.xdt_CostoRD.ReadOnly = True
        Me.xdt_CostoRD.TabStop = True
        Me.xdt_CostoRD.UseCustomCellFormat = False
        Me.xdt_CostoRD.Width = 75
        '
        'xdt_Price
        '
        Me.xdt_Price.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Price.Format = "##,###,##0.00"
        Me.xdt_Price.FormatInfo = Nothing
        Me.xdt_Price.HeaderText = "Precio US"
        Me.xdt_Price.ImageList = Nothing
        Me.xdt_Price.isReadOnly = False
        Me.xdt_Price.MappingName = "price"
        Me.xdt_Price.MaxLength = 32767
        Me.xdt_Price.ReadOnly = True
        Me.xdt_Price.TabStop = True
        Me.xdt_Price.UseCustomCellFormat = False
        Me.xdt_Price.Width = 75
        '
        'xdt_priceRD
        '
        Me.xdt_priceRD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_priceRD.Format = "##,###,##0.00"
        Me.xdt_priceRD.FormatInfo = Nothing
        Me.xdt_priceRD.HeaderText = "Precio RD"
        Me.xdt_priceRD.ImageList = Nothing
        Me.xdt_priceRD.isReadOnly = False
        Me.xdt_priceRD.MappingName = "sales_price"
        Me.xdt_priceRD.MaxLength = 32767
        Me.xdt_priceRD.ReadOnly = True
        Me.xdt_priceRD.TabStop = True
        Me.xdt_priceRD.UseCustomCellFormat = False
        Me.xdt_priceRD.Width = 75
        '
        'xdt_Importe
        '
        Me.xdt_Importe.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Importe.Format = "##,###,##0.00"
        Me.xdt_Importe.FormatInfo = Nothing
        Me.xdt_Importe.HeaderText = "Importe"
        Me.xdt_Importe.ImageList = Nothing
        Me.xdt_Importe.isReadOnly = False
        Me.xdt_Importe.MappingName = "Importe"
        Me.xdt_Importe.MaxLength = 32767
        Me.xdt_Importe.ReadOnly = True
        Me.xdt_Importe.TabStop = True
        Me.xdt_Importe.UseCustomCellFormat = False
        Me.xdt_Importe.Width = 75
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(408, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&Grupos"
        '
        'btnSerializar
        '
        Me.btnSerializar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSerializar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSerializar.Location = New System.Drawing.Point(8, 440)
        Me.btnSerializar.Name = "btnSerializar"
        Me.btnSerializar.Size = New System.Drawing.Size(75, 31)
        Me.btnSerializar.TabIndex = 3
        Me.btnSerializar.Text = "&Serializado"
        '
        'btnProductos
        '
        Me.btnProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProductos.Location = New System.Drawing.Point(168, 440)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(75, 31)
        Me.btnProductos.TabIndex = 5
        Me.btnProductos.Text = "&Productos"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(248, 440)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 31)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "&Marcas"
        '
        'btnSetup
        '
        Me.btnSetup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSetup.Location = New System.Drawing.Point(328, 440)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(75, 31)
        Me.btnSetup.TabIndex = 8
        Me.btnSetup.Text = "&Tasa"
        '
        'btnCostos
        '
        Me.btnCostos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCostos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCostos.Location = New System.Drawing.Point(88, 440)
        Me.btnCostos.Name = "btnCostos"
        Me.btnCostos.Size = New System.Drawing.Size(75, 31)
        Me.btnCostos.TabIndex = 4
        Me.btnCostos.Text = "&Costos"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "entr_ncf"
        Me.DataColumn41.MaxLength = 20
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "docs_ncf"
        Me.DataColumn42.MaxLength = 20
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "term_code"
        Me.DataColumn43.MaxLength = 5
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "apply_FOB"
        Me.DataColumn44.DataType = GetType(System.Int32)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "apply_selectivo"
        Me.DataColumn45.DataType = GetType(System.Int32)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "apply_gravamen"
        Me.DataColumn46.DataType = GetType(System.Int32)
        '
        'i_iventr01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(786, 479)
        Me.Controls.Add(Me.lk_item_code)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.btnSerializar)
        Me.Controls.Add(Me.btnProductos)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnSetup)
        Me.Controls.Add(Me.btnCostos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "i_iventr01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Entrada de Almacén Internacionales"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iventrdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid1.CurrentRowChanged
        CalcularRubros(e.previousRow)
    End Sub

    Private Sub total_amount_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles total_amount.Validating
        If LibXConnector1.IsDataEditing Then
            CalcularNeto()
        End If
    End Sub

    Private Sub CalcularRubros(ByVal iRow As Integer)
        Try
            If LibXConnector1.IsDataEditing Then
                If iRow >= iventrdd.Rows.Count Then
                    Exit Sub
                End If

                If LibX.IsNull(iventrdd.Rows(iRow)!qty) Then
                    Exit Sub
                End If

                If LibX.IsNull(iventrdd.Rows(iRow)!costo) Then
                    Exit Sub
                End If

                If LibXConnector1.CurrentDataRow Is Nothing Then
                    Exit Sub
                End If

                If LibX.IsNull(LibXConnector1.CurrentDataRow!total_amount) Then
                    Throw New ApplicationException("Debe especificar el monto de la factura para calcular los costos y precios!")
                End If

                Dim oParam As New Articulo.ParametrosCostosIntern

                With oParam
                    .Producto = iventrdd.Rows(iRow)!item_code.ToString
                    .Almacen = CType(txtwhse_code.Text, Integer)
                    .TotalBruto = Val(LibXConnector1.CurrentDataRow!total_amount.ToString)

                    'GASTOS GENERALES
                    If LibXConnector1.CurrentDataRow!aply_dscto.ToString = "1" Then
                        .GastosGeneralesUS = Val(LibXConnector1.CurrentDataRow!gastos_gen.ToString)
                    Else
                        If Not LibX.IsNull(LibXConnector1.CurrentDataRow!gastos_gen) _
                        AndAlso LibXConnector1.CurrentDataRow!gastos_gen > 0 Then
                            .Retorno.MontoGastosUS = Val(LibXConnector1.CurrentDataRow!gastos_gen.ToString)
                        End If
                    End If

                    'GASTOS ADUANALES
                    If LibXConnector1.CurrentDataRow!aply_impto.ToString = "1" Then
                        .PorcientoGastosAduanales = Val(LibXConnector1.CurrentDataRow!gastos_aduana.ToString)
                    Else
                        If Not LibX.IsNull(LibXConnector1.CurrentDataRow!gastos_aduana) _
                        AndAlso LibXConnector1.CurrentDataRow!gastos_aduana > 0 Then
                            .Retorno.MontoAduanalesUS = Val(LibXConnector1.CurrentDataRow!gastos_aduana.ToString)
                        End If
                    End If

                    'FOB
                    If LibXConnector1.CurrentDataRow!aply_itbis.ToString = "1" Then
                        .PorcientoFOB = Val(LibXConnector1.CurrentDataRow!fob_amount.ToString)
                    Else
                        If Not LibX.IsNull(LibXConnector1.CurrentDataRow!fob_amount) _
                        AndAlso LibXConnector1.CurrentDataRow!fob_amount > 0 Then
                            .Retorno.MontoFOBUS = (LibXConnector1.CurrentDataRow!fob_amount.ToString)
                        End If
                    End If

                    .Cantidad = Val(iventrdd.Rows(iRow)!qty.ToString)
                    .CostoUS = Val(iventrdd.Rows(iRow)!costo.ToString)

                End With

                '// Importe = Qty * price
                If mArticulo.CalcularCostoIntern(oParam) = True Then
                    If lck_edit_price.Checked = False Then
                        iventrdd.Rows(iRow)!price = oParam.Retorno.PrecioUS
                    End If

                    iventrdd.Rows(iRow)!costrd = oParam.Retorno.CostoCompraRD
                    iventrdd.Rows(iRow)!sales_price = oParam.Retorno.PrecioRD
                    iventrdd.Rows(iRow)!purch_unit_cost = oParam.Retorno.CostoCompraUS
                    iventrdd.Rows(iRow)!impto = (oParam.Retorno.MontoAduanalesUS + _
                                                oParam.Retorno.MontoFOBUS + _
                                                oParam.Retorno.MontoGastosUS) / oParam.Cantidad
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub
    Private Function CalcularNeto() As Boolean
        Dim TotalAmount As Decimal
        Dim AmountFOB As Decimal
        Dim AmountGG As Decimal
        Dim AmountGA As Decimal

        Dim pAmountFOB As Decimal
        Dim pAmountGA As Decimal

        Dim Amount As Decimal
        Try
            If total_amount.Text.Length <= 0 Then
                total_amount.Focus()
                Throw New ApplicationException("Recuerde especificar el monto de la factura antes digitar los demas valores")
            End If

            TotalAmount = CType(total_amount.Text, Decimal)

            If fob_amount.Text.Length > 0 Then
                pAmountFOB = CType(fob_amount.Text, Decimal)
            End If

            If charge_amt.Text.Length > 0 Then
                AmountGG = CType(charge_amt.Text, Decimal)
            End If

            If adu_amount.Text.Length > 0 Then
                pAmountGA = CType(adu_amount.Text, Decimal)
            End If

            AmountFOB = TotalAmount * (pAmountFOB / 100)
            AmountGA = TotalAmount * (pAmountGA / 100)
            Amount = TotalAmount + AmountFOB + AmountGA + AmountGG

            txtFOB.Text = Format(AmountFOB, "n")
            txtAduana.Text = Format(AmountGA, "n")
            charge_amt.Text = Format(AmountGG, "n")
            net_amount.Text = Format(Amount, "n")

            Return True
        Catch ex As Exception
            LibX.Log.Show(ex)
            Return False
        End Try

    End Function

    Private Sub disc_amount_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles charge_amt.Validating
        If LibXConnector1.IsDataEditing Then
            CalcularNeto()
        End If
    End Sub

    Private Sub itbis_amount_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fob_amount.Validating
        If LibXConnector1.IsDataEditing Then
            CalcularNeto()
        End If
    End Sub

    Private Sub tax_amount_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles adu_amount.Validating
        If LibXConnector1.IsDataEditing Then
            CalcularNeto()
        End If
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If LibXConnector1.State = LibX.LibxConnectorState.Insert Then
                cbx_entr_status.currValue = 2
                xdt_entr_date.Value = LibX.Data.Manager.Connection.GetDate.ToShortDateString
                txtTasa.Text = mConfig.GetTasaUS

                txttype_code.Text = SGT.Inventario.Entidades.Documento.GetDollar
                LibXConnector1.CurrentDataRow!type_code = txttype_code.Text
                xlk_type_code.ExecuteFind()
                txtwhse_code.Text = SGT.Inventario.Entidades.Almacen.GetDefault()
                lk_whse_code.ExecuteFind()
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub txtEntr_Number_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEntr_Number.LostFocus

    End Sub

    Private Sub i_iventr02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mConfig = New SGT.Inventario.Common.Configuration
        iventrdd.Columns("Importe").Expression = "qty*costo"
        mArticulo = New SGT.Inventario.Entidades.Articulo

        LibXGrid1.footerOperations.add("Importe", "sum(Importe)")

    End Sub

    Private Sub lk_item_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lk_item_code.BeforeExecuteQuery
        If txtwhse_code.Text.Length > 0 Then
            e.aditionalWhere = "whse_code = " & txtwhse_code.Text
        End If

    End Sub
    Private Sub LibXLookup1_BeforeExecuteQuery(ByVal sender As System.Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_type_code.BeforeExecuteQuery
        e.aditionalWhere = " doc_input = 1 and type_local = 0"

    End Sub
    Private Sub LibXConnector1_RowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange
        If Not e.row Is Nothing Then
            If e.row!entr_cond.ToString = "1" Then
                rbt_Contado.Checked = True
            End If

            If e.row!entr_cond.ToString = "2" Then
                rbt_Credito.Checked = True
            End If

            If LibXConnector1.IsDataEditing Then

                CalcularNeto()
            End If
        End If
    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Dim SelecStmt As String
        Dim AxCrystalReport1 As LibX.ReportLib
        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
                '// Tomar el Connection String del config
                AxCrystalReport1 = New LibX.ReportLib("INV", "i_iventrd01.rpt")
                WhereStmt = String.Concat("iventrdm.type_code = '", LibXConnector1.CurrentDataRow!type_code.ToString, "'", _
                                         " and iventrdm.entr_number = ", LibXConnector1.CurrentDataRow!entr_number.ToString)
                With AxCrystalReport1
                    '// Recibir el SQL Query
                    .RetrieveSQLQuery()
                    SelecStmt = .SQLQuery
                    SelecStmt = LibX.MdlUtil.ReplaceWherePart(SelecStmt, WhereStmt)
                    .SQLQuery = SelecStmt

                    '// Ejecutar el reporte
                    .Action = 1
                End With
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibxCheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lck_edit_price.CheckedChanged
        If lck_edit_price.Checked = True Then
            xdt_Price.ReadOnly = False
        Else
            xdt_Price.ReadOnly = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSerializar.Click
        Try
            Dim ParamRunner As New LibX.LibxPrgParams
            ParamRunner.Value = LibXConnector1.CurrentDataRow!entr_serial
            LibX.App.CurrentPrgParams = ParamRunner
            LibX.LibXRunner.Run("i_ivserie01", "INV")

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        btnSerializar.Enabled = Not LibXConnector1.IsEditing And LibXConnector1.HasRecords = True
        btnCostos.Enabled = Not LibXConnector1.IsEditing And LibXConnector1.HasRecords = True
        btnProductos.Enabled = Not LibXConnector1.IsEditing And LibXConnector1.HasRecords = True
        rbt_Contado.Enabled = e.isEditing
        rbt_Credito.Enabled = e.isEditing

    End Sub

    Private Sub btnProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCostos.Click
        Try
            Dim param As New LibX.LibxPrgParams
            param.Datos.Add("where", "item_code = '" & _
                            LibXGrid1.GetCurrentRowView!item_code & _
                            "' and whse_code = " & _
                            LibXGrid1.GetCurrentRowView!whse_code)

            With param
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowPrint = False
                .AllowQuery = False
            End With

            LibX.App.CurrentPrgParams = param
            LibX.LibXRunner.Run("i_ivitem02", "INV")
            LibXConnector1.ExecuteFind()

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub btnProductos_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductos.Click
        Try
            Dim param As New LibX.LibxPrgParams
            param.Datos.Add("where", "item_code = '" & _
                            LibXGrid1.GetCurrentRowView!item_code & "'")

            With param
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowPrint = False
                .AllowQuery = False
            End With

            LibX.App.CurrentPrgParams = param
            LibX.LibXRunner.Run("i_ivitem01", "INV")
            LibXConnector1.ExecuteFind()

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetup.Click
        Try
            LibX.LibXRunner.Run("i_ivsetup", "INV")
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            If e.Action = LibX.LibxConnectionActions.Edit AndAlso LibXConnector1.CurrentDataRow!entr_status = 1 Then
                e.Handled = True
                Throw New ApplicationException("Una factura aplicada no puede ser alterdada!")
            End If

            If e.Action = LibX.LibxConnectionActions.Delete AndAlso LibXConnector1.CurrentDataRow!entr_status = 1 Then
                e.Handled = True
                Throw New ApplicationException("Una factura aplicada no puede ser Eliminada!")
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        If rbt_Contado.Checked = True Then
            e.UpdatingArgs.Row!entr_cond = 1
        End If

        If rbt_Credito.Checked = True Then
            e.UpdatingArgs.Row!entr_cond = 2
        End If

    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        e.AditionalWhere = "iventrdm.type_code = 'CUS'"
    End Sub

    Private Sub txtEntr_Number_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEntr_Number.Validating
        e.Cancel = (Not Validar())
    End Sub
    Private Function Validar() As Boolean

        Dim SelectStmt As String
        If txtprov_code.Text.Length <= 0 Then
            Return True
        End If

        If txtEntr_Number.Text.Length <= 0 Then
            Return True
        End If

        Try
            If LibXConnector1.State = LibX.LibxConnectorState.Insert Then
                If txtEntr_Number.Text.Length > 0 Then
                    SelectStmt = "select count(*) from iventrdm " & _
                                 " where entr_number = " & txtEntr_Number.Text.Trim & _
                                 "   and prov_code = " & txtprov_code.Text

                    If LibX.Data.Manager.GetScalar(SelectStmt) > 0 Then
                        Throw New ApplicationException("Existe una factura con ese número, verifique!")
                    End If
                End If
            End If

            Return True
        Catch ex As Exception
            LibX.Log.Show(ex)
            txtEntr_Number.Text = ""
            Return False

        End Try

    End Function

    Private Sub txtprov_code_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtprov_code.Validating
        Try
            e.Cancel = (Not Validar())
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            LibX.LibXRunner.Run("i_ivbrand01", "INV")
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            LibX.LibXRunner.Run("i_ivgroup01", "INV")
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub
    Private Sub lkp_item_code_CreatedGridColumns(ByVal sender As Object, ByVal e As LibX.CreatedGridColumnsEventArgs) Handles lk_item_code.CreatedGridColumns
        Try
            e.TStyle.GridColumnStyles.Item("item_name").Width = 450

            e.Grid.Parent.Width = e.Grid.Parent.Width + 500

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub rbt_Contado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_Contado.CheckedChanged
        If rbt_Contado.Checked = True Then
            LibXConnector1.CurrentDataRow!entr_cond = 1 'Contado
        End If
    End Sub

    Private Sub rbt_Credito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_Credito.CheckedChanged
        If rbt_Credito.Checked = True Then
            LibXConnector1.CurrentDataRow!entr_cond = 2 'Credito
        End If
    End Sub
End Class
