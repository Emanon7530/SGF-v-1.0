Imports LibX
Imports SGT.Facturacion
Public Class i_ftdevm01
    Inherits System.Windows.Forms.Form
    Dim oDoc As SGT.Facturacion.Entidades.Documento
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents STftfactm As LibX.LibXDbSourceTable
    Friend WithEvents STfactd As LibX.LibXDbSourceTable
    Friend WithEvents cust_name As LibX.XTextBox
    Friend WithEvents vend_name As LibX.XTextBox
    Friend WithEvents lkp_item_code As LibX.LibXLookup
    Friend WithEvents DataSet1 As System.Data.DataSet
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtClinombre As LibX.XTextBox
    Friend WithEvents rdbContado As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCredito As System.Windows.Forms.RadioButton
    Friend WithEvents GridColQty As LibX.XEditTextBoxColumn
    Friend WithEvents LibXGridDetalle As LibX.LibXGrid
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents GColprice As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gColdscto As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gColImporte As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gColitem_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gColExist As LibX.XEditTextBoxColumn
    Friend WithEvents lkCliente As LibX.LibXLookup
    Friend WithEvents btnCli As System.Windows.Forms.Button
    Friend WithEvents txtDec As LibX.XTextBox
    Friend WithEvents txtTotal As LibX.XTextBox
    Friend WithEvents txtMontoBruto As LibX.XTextBox
    Friend WithEvents gColitem_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents gColwhse_code As LibX.XEditTextBoxColumn
    Friend WithEvents gColIbis As LibX.XEditTextBoxColumn
    Friend WithEvents txtITbis As LibX.XTextBox
    Friend WithEvents txtCliCodigo As LibX.XTextBox
    Friend WithEvents gColCosto As LibX.XEditTextBoxColumn
    Friend WithEvents lbx_fact_status As LibX.LibXCombo
    Friend WithEvents cbo_price As LibX.LibxCheckBox
    Friend WithEvents Disc_days As LibX.XTextBox
    Friend WithEvents Due_days As LibX.XTextBox
    Friend WithEvents Disc_pct As LibX.XTextBox
    Friend WithEvents txtfact_number As LibX.XTextBox
    Friend WithEvents txtvend_code As LibX.XTextBox
    Friend WithEvents xlk_vend_code As LibX.LibXLookup
    Friend WithEvents term_name As LibX.XTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents xlk_term_code As LibX.LibXLookup
    Friend WithEvents xtxt_term_code As LibX.XTextBox
    Friend WithEvents ftfactd As System.Data.DataTable
    Friend WithEvents gbx_Condicion As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_item_name As LibX.XTextBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnSerializar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtfact_afect As LibX.XTextBox
    Friend WithEvents xlk_fact_afect As LibX.LibXLookup
    Friend WithEvents txtftserial_afect As LibX.XTextBox
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
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents BtnEtiquitas As System.Windows.Forms.Button
    Friend WithEvents xcbo_TipoDevolucion As LibX.LibXCombo
    Friend WithEvents rdb_CompraCR As System.Windows.Forms.RadioButton
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
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
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.ftfactd = New System.Data.DataTable
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
        Me.DataColumn33 = New System.Data.DataColumn
        Me.STftfactm = New LibX.LibXDbSourceTable
        Me.STfactd = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xlk_fact_afect = New LibX.LibXLookup
        Me.xcbo_TipoDevolucion = New LibX.LibXCombo
        Me.xlk_term_code = New LibX.LibXLookup
        Me.Label6 = New System.Windows.Forms.Label
        Me.term_name = New LibX.XTextBox
        Me.btnCli = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.gbx_Condicion = New System.Windows.Forms.GroupBox
        Me.rdbContado = New System.Windows.Forms.RadioButton
        Me.rdbCredito = New System.Windows.Forms.RadioButton
        Me.rdb_CompraCR = New System.Windows.Forms.RadioButton
        Me.DateTimePicker1 = New LibX.LibxDateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbo_price = New LibX.LibxCheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Disc_days = New LibX.XTextBox
        Me.Due_days = New LibX.XTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Disc_pct = New LibX.XTextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.lkCliente = New LibX.LibXLookup
        Me.lbx_fact_status = New LibX.LibXCombo
        Me.cust_name = New LibX.XTextBox
        Me.txtCliCodigo = New LibX.XTextBox
        Me.txtfact_number = New LibX.XTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMontoBruto = New LibX.XTextBox
        Me.txtDec = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtITbis = New LibX.XTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtTotal = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtClinombre = New LibX.XTextBox
        Me.xtxt_term_code = New LibX.XTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtfact_afect = New LibX.XTextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.txtftserial_afect = New LibX.XTextBox
        Me.btnLoad = New System.Windows.Forms.Button
        Me.vend_name = New LibX.XTextBox
        Me.txtvend_code = New LibX.XTextBox
        Me.xlk_vend_code = New LibX.LibXLookup
        Me.Label16 = New System.Windows.Forms.Label
        Me.LibXGridDetalle = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColitem_code = New LibX.XDataGridTextButtonColumn
        Me.lkp_item_code = New LibX.LibXLookup
        Me.gColwhse_code = New LibX.XEditTextBoxColumn
        Me.gColitem_name = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GridColQty = New LibX.XEditTextBoxColumn
        Me.GColprice = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColdscto = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColCosto = New LibX.XEditTextBoxColumn
        Me.gColExist = New LibX.XEditTextBoxColumn
        Me.gColIbis = New LibX.XEditTextBoxColumn
        Me.gColImporte = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txt_item_name = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnSerializar = New System.Windows.Forms.Button
        Me.BtnEtiquitas = New System.Windows.Forms.Button
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.DataColumn41 = New System.Data.DataColumn
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbx_Condicion.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(818, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = True
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "ftfactm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.STftfactm, Me.STfactd})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.ftfactd})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn32, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "ftfactm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "ftserial_no"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "whse_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "dev_type"
        Me.DataColumn3.MaxLength = 3
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "cotiz_serial"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "term_code"
        Me.DataColumn5.MaxLength = 5
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "addr_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "vend_code"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "fact_number"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "fact_date"
        Me.DataColumn9.DataType = GetType(System.DateTime)
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "fact_total"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "descto"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "itbis"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "userid"
        Me.DataColumn13.MaxLength = 20
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "fact_status"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "date_created"
        Me.DataColumn15.DataType = GetType(System.DateTime)
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "type_code"
        Me.DataColumn16.MaxLength = 3
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "cust_code"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "fact_cond"
        Me.DataColumn18.DataType = GetType(System.Int16)
        '
        'DataColumn32
        '
        Me.DataColumn32.AllowDBNull = False
        Me.DataColumn32.ColumnName = "bus_name"
        Me.DataColumn32.MaxLength = 40
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "fact_nota"
        Me.DataColumn34.MaxLength = 80
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "ftserial_afect"
        Me.DataColumn35.DataType = GetType(System.Int32)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "pay_adelant"
        Me.DataColumn36.DataType = GetType(System.Int32)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "phone"
        Me.DataColumn37.MaxLength = 8
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "fact_afect"
        Me.DataColumn38.DataType = GetType(System.Int32)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "pay_mora"
        Me.DataColumn39.DataType = GetType(System.Decimal)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "porc_comision"
        Me.DataColumn40.DataType = GetType(System.Decimal)
        '
        'ftfactd
        '
        Me.ftfactd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn33})
        Me.ftfactd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no", "line_no"}, True)})
        Me.ftfactd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn19, Me.DataColumn20}
        Me.ftfactd.TableName = "ftfactd"
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "ftserial_no"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.AutoIncrement = True
        Me.DataColumn20.AutoIncrementSeed = CType(1, Long)
        Me.DataColumn20.ColumnName = "line_no"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.AllowDBNull = False
        Me.DataColumn21.ColumnName = "item_code"
        Me.DataColumn21.MaxLength = 15
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "whse_code"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "item_name"
        Me.DataColumn23.MaxLength = 100
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.ColumnName = "qty"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "price"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "dscto"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        Me.DataColumn26.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "factor"
        Me.DataColumn27.DataType = GetType(System.Decimal)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "itbis"
        Me.DataColumn28.DataType = GetType(System.Decimal)
        Me.DataColumn28.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "costo"
        Me.DataColumn29.DataType = GetType(System.Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "unit_code"
        Me.DataColumn30.MaxLength = 5
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "Importe"
        Me.DataColumn31.DataType = GetType(System.Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "exist"
        Me.DataColumn33.DataType = GetType(System.Decimal)
        '
        'STftfactm
        '
        Me.STftfactm.AllowDelete = True
        Me.STftfactm.AllowEdit = True
        Me.STftfactm.AllowNew = True
        Me.STftfactm.AutoIncrementSerial = False
        Me.STftfactm.CustomDbUpdate = False
        Me.STftfactm.DeleteOrder = 0
        Me.STftfactm.FillOnQuery = True
        Me.STftfactm.FillOnRowChange = False
        Me.STftfactm.HeaderIsOnGrid = False
        Me.STftfactm.InsertOrder = 0
        Me.STftfactm.IsDetail = False
        Me.STftfactm.KeyFields = Nothing
        Me.STftfactm.MasterDetailRelation = Nothing
        Me.STftfactm.MasterTableName = Nothing
        Me.STftfactm.SerialColumnName = "ftserial_no"
        Me.STftfactm.Sort = Nothing
        Me.STftfactm.Source = New String() {"select ftfactm.ftserial_no,", "ftfactm.whse_code,   ", "ftfactm.dev_type, ", "ftfactm.cotiz_serial, ", "ftfactm.term_code, ", "ftfactm.addr_code,   ", "ftfactm.vend_code,   ", "ftfactm.fact_number, ", "ftfactm.fact_date,", "ftfactm.fact_total,     ", "ftfactm.descto,         ", "ftfactm.itbis,          ", "ftfactm.userid,               ", "ftfactm.fact_status,", "ftfactm.date_created,", "ftfactm.type_code, ", "ftfactm.cust_code,   ", "ftfactm.fact_cond, ", "ftfactm.bus_name,                                 ", "ftfactm.fact_nota,", "ftfactm.ftserial_afect,", "ftfactm.pay_adelant,", "ftfactm.fact_ncf,", "ftfactm.phone ,ftfactaf.fact_number fact_afect,", "ftfactm.pay_mora, ftfactm.porc_comision", "from ftfactm ", "left outer join ftfactm ftfactaf ", "on ftfactm.ftserial_afect = ftfactaf.ftserial_no"}
        Me.STftfactm.TableName = "ftfactm"
        Me.STftfactm.UpdateOrder = 0
        Me.STftfactm.UseRowRetrieve = False
        '
        'STfactd
        '
        Me.STfactd.AllowDelete = True
        Me.STfactd.AllowEdit = True
        Me.STfactd.AllowNew = True
        Me.STfactd.AutoIncrementSerial = True
        Me.STfactd.CustomDbUpdate = False
        Me.STfactd.DeleteOrder = 0
        Me.STfactd.FillOnQuery = True
        Me.STfactd.FillOnRowChange = True
        Me.STfactd.HeaderIsOnGrid = False
        Me.STfactd.InsertOrder = 0
        Me.STfactd.IsDetail = True
        Me.STfactd.KeyFields = "ftserial_no,line_no"
        Me.STfactd.MasterDetailRelation = New String() {"ftserial_no=ftserial_no"}
        Me.STfactd.MasterTableName = Nothing
        Me.STfactd.SerialColumnName = ""
        Me.STfactd.Sort = Nothing
        Me.STfactd.Source = New String() {"select ftfactd.ftserial_no,line_no,ftfactd.item_code,whse_code,", "item_name,qty,price,dscto,factor,itbis,costo,ftfactd.unit_code", "from ftfactd inner join ivitemm ", "on ftfactd.item_code=ivitemm.item_code"}
        Me.STfactd.TableName = "ftfactd"
        Me.STfactd.UpdateOrder = 0
        Me.STfactd.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xlk_fact_afect)
        Me.GroupBox1.Controls.Add(Me.xcbo_TipoDevolucion)
        Me.GroupBox1.Controls.Add(Me.xlk_term_code)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.term_name)
        Me.GroupBox1.Controls.Add(Me.btnCli)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.gbx_Condicion)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lkCliente)
        Me.GroupBox1.Controls.Add(Me.lbx_fact_status)
        Me.GroupBox1.Controls.Add(Me.cust_name)
        Me.GroupBox1.Controls.Add(Me.txtCliCodigo)
        Me.GroupBox1.Controls.Add(Me.txtfact_number)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMontoBruto)
        Me.GroupBox1.Controls.Add(Me.txtDec)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtITbis)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtClinombre)
        Me.GroupBox1.Controls.Add(Me.xtxt_term_code)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtfact_afect)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.txtftserial_afect)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'xlk_fact_afect
        '
        Me.xlk_fact_afect.CheckText = "Documentos a Crédito"
        Me.xlk_fact_afect.DataMember = Nothing
        Me.xlk_fact_afect.DataSource = Me.LibXConnector1
        Me.xlk_fact_afect.DestParameters = New String() {"txtfact_afect=fact_number", "ftserial_afect=ftserial_no", "bus_name=bus_name", "cust_code=cust_code"}
        Me.xlk_fact_afect.FilterField = "bus_name"
        Me.xlk_fact_afect.IgnoreFindInBrowseMode = True
        Me.xlk_fact_afect.Location = New System.Drawing.Point(400, 16)
        Me.xlk_fact_afect.LookCaption = Nothing
        Me.xlk_fact_afect.Name = "xlk_fact_afect"
        Me.xlk_fact_afect.ShowMessageNotFound = True
        Me.xlk_fact_afect.ShowWarning = True
        Me.xlk_fact_afect.Size = New System.Drawing.Size(16, 20)
        Me.xlk_fact_afect.SizesColumns = New String() {"bus_name=350", "estatus=101", "condicion=101"}
        Me.xlk_fact_afect.SizesColumnsTab = Nothing
        Me.xlk_fact_afect.SqlString = New String() {"select ftserial_no,fact_number,bus_name,cust_code ,fact_cond,", "fact_nota,fact_date,type_code,case when fact_cond = 1 then 'Contado' else 'Credit" & _
        "o' end Condicion,", "case fact_status when 1 then 'En almacen'", "when 2 then 'En Caja'", "when 3 then 'Despachada'", "when 4 then  'NC Aplicada'", "when 5 then 'Devuelta'", "when 0 then 'Anulada' end Estatus", "from ftfactm", "where type_code = 'FCT'", "and fact_status not in (0,2,5)"}
        Me.xlk_fact_afect.SQLTab = New String() {"select ivitemm.item_name [Nombre del Producto],", "ftfactd.qty Cantidad, ftfactd.price Precio, ftfactd.dscto Descuento, ", "ftfactd.itbis Itbis", "from ftfactd inner join ivitemm", "on ftfactd.item_code = ivitemm.item_code"}
        Me.xlk_fact_afect.SrcParameters = New String() {"fact_afect=fact_number"}
        Me.xlk_fact_afect.TabIndex = 24
        Me.xlk_fact_afect.TableName = "ftfactm"
        Me.xlk_fact_afect.UseCopyConnection = False
        Me.xlk_fact_afect.UseRowRetrieveEvents = False
        Me.xlk_fact_afect.UseTab = True
        Me.xlk_fact_afect.VisParameters = New String() {"Número=fact_number", "Fecha=fact_date", "Cliente=bus_name", "Condicion=Condicion", "Estatus=Estatus"}
        Me.xlk_fact_afect.WhereCondition = Nothing
        Me.xlk_fact_afect.WhereParameters = "ftfactd.ftserial_no=?ftserial_no"
        '
        'xcbo_TipoDevolucion
        '
        Me.xcbo_TipoDevolucion.AllowDefaultSort = True
        Me.xcbo_TipoDevolucion.bound = True
        Me.xcbo_TipoDevolucion.currValue = Nothing
        Me.xcbo_TipoDevolucion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.dev_type"))
        Me.xcbo_TipoDevolucion.DefaultWhereString = Nothing
        Me.xcbo_TipoDevolucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_TipoDevolucion.EditInitialValue = Nothing
        Me.xcbo_TipoDevolucion.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_TipoDevolucion.FindInitialValue = Nothing
        Me.xcbo_TipoDevolucion.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_TipoDevolucion.IgnoreRequiered = False
        Me.xcbo_TipoDevolucion.Location = New System.Drawing.Point(80, 72)
        Me.xcbo_TipoDevolucion.LookupKeyDisplayFields = "dev_name"
        Me.xcbo_TipoDevolucion.LookupKeyField = "dev_type"
        Me.xcbo_TipoDevolucion.LookupTableName = "ftdevolt"
        Me.xcbo_TipoDevolucion.Name = "xcbo_TipoDevolucion"
        Me.xcbo_TipoDevolucion.NewInitialValue = Nothing
        Me.xcbo_TipoDevolucion.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_TipoDevolucion.Requiered = False
        Me.xcbo_TipoDevolucion.Required = False
        Me.xcbo_TipoDevolucion.Size = New System.Drawing.Size(336, 21)
        Me.xcbo_TipoDevolucion.SqlString = Nothing
        Me.xcbo_TipoDevolucion.TabIndex = 4
        '
        'xlk_term_code
        '
        Me.xlk_term_code.CheckText = Nothing
        Me.xlk_term_code.DataMember = Nothing
        Me.xlk_term_code.DataSource = Me.LibXConnector1
        Me.xlk_term_code.DestParameters = New String() {"term_code=term_code", "term_name=term_name", "disc_pct=disc_pct", "due_days=due_days", "disc_days=disc_days"}
        Me.xlk_term_code.FilterField = Nothing
        Me.xlk_term_code.IgnoreFindInBrowseMode = False
        Me.xlk_term_code.Location = New System.Drawing.Point(400, 144)
        Me.xlk_term_code.LookCaption = Nothing
        Me.xlk_term_code.Name = "xlk_term_code"
        Me.xlk_term_code.ShowMessageNotFound = True
        Me.xlk_term_code.ShowWarning = False
        Me.xlk_term_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_term_code.SizesColumns = Nothing
        Me.xlk_term_code.SizesColumnsTab = Nothing
        Me.xlk_term_code.SqlString = Nothing
        Me.xlk_term_code.SQLTab = Nothing
        Me.xlk_term_code.SrcParameters = New String() {"term_code=term_code"}
        Me.xlk_term_code.TabIndex = 15
        Me.xlk_term_code.TableName = "cctermm"
        Me.xlk_term_code.UseCopyConnection = False
        Me.xlk_term_code.UseRowRetrieveEvents = False
        Me.xlk_term_code.UseTab = False
        Me.xlk_term_code.VisParameters = New String() {"Código=term_code", "Descripción=term_name", "% Descuento=disc_pct", "Vencimiento=due_days"}
        Me.xlk_term_code.WhereCondition = Nothing
        Me.xlk_term_code.WhereParameters = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(15, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Termino:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'term_name
        '
        Me.term_name.EditInitialValue = Nothing
        Me.term_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.term_name.FindInitialValue = Nothing
        Me.term_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.term_name.IgnoreRequiered = False
        Me.term_name.Location = New System.Drawing.Point(144, 144)
        Me.term_name.Name = "term_name"
        Me.term_name.NewInitialValue = Nothing
        Me.term_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.term_name.ReadOnly = True
        Me.term_name.Requiered = False
        Me.term_name.Size = New System.Drawing.Size(256, 20)
        Me.term_name.TabIndex = 14
        Me.term_name.TabStop = False
        Me.term_name.Text = ""
        '
        'btnCli
        '
        Me.btnCli.Location = New System.Drawing.Point(392, 96)
        Me.btnCli.Name = "btnCli"
        Me.btnCli.Size = New System.Drawing.Size(24, 20)
        Me.btnCli.TabIndex = 11
        Me.btnCli.Text = "..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(6, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "A Nombre:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gbx_Condicion
        '
        Me.gbx_Condicion.Controls.Add(Me.rdbContado)
        Me.gbx_Condicion.Controls.Add(Me.rdbCredito)
        Me.gbx_Condicion.Controls.Add(Me.rdb_CompraCR)
        Me.gbx_Condicion.Enabled = False
        Me.gbx_Condicion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbx_Condicion.Location = New System.Drawing.Point(80, 36)
        Me.gbx_Condicion.Name = "gbx_Condicion"
        Me.gbx_Condicion.Size = New System.Drawing.Size(336, 32)
        Me.gbx_Condicion.TabIndex = 3
        Me.gbx_Condicion.TabStop = False
        Me.gbx_Condicion.Text = "Condición de venta"
        '
        'rdbContado
        '
        Me.rdbContado.Checked = True
        Me.rdbContado.Location = New System.Drawing.Point(8, 12)
        Me.rdbContado.Name = "rdbContado"
        Me.rdbContado.Size = New System.Drawing.Size(80, 16)
        Me.rdbContado.TabIndex = 0
        Me.rdbContado.TabStop = True
        Me.rdbContado.Text = "EFECTIVO"
        '
        'rdbCredito
        '
        Me.rdbCredito.Location = New System.Drawing.Point(92, 12)
        Me.rdbCredito.Name = "rdbCredito"
        Me.rdbCredito.Size = New System.Drawing.Size(112, 16)
        Me.rdbCredito.TabIndex = 1
        Me.rdbCredito.Text = "NOTA CREDITO"
        '
        'rdb_CompraCR
        '
        Me.rdb_CompraCR.Location = New System.Drawing.Point(208, 11)
        Me.rdb_CompraCR.Name = "rdb_CompraCR"
        Me.rdb_CompraCR.Size = New System.Drawing.Size(120, 16)
        Me.rdb_CompraCR.TabIndex = 2
        Me.rdb_CompraCR.Text = "DEV. A CREDITO"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.fact_date"))
        Me.DateTimePicker1.EditInitialValue = Nothing
        Me.DateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.DateTimePicker1.FindInitialValue = Nothing
        Me.DateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.IgnoreRequiered = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(496, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.NewInitialValue = "now"
        Me.DateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.DateTimePicker1.Requiered = False
        Me.DateTimePicker1.Size = New System.Drawing.Size(136, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbo_price)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Disc_days)
        Me.GroupBox2.Controls.Add(Me.Due_days)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Disc_pct)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(640, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 120)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Condición:"
        '
        'cbo_price
        '
        Me.cbo_price.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbo_price.EditInitialValue = Nothing
        Me.cbo_price.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.cbo_price.FindInitialValue = Nothing
        Me.cbo_price.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cbo_price.IgnoreRequiered = False
        Me.cbo_price.KeepEnabled = False
        Me.cbo_price.Location = New System.Drawing.Point(14, 93)
        Me.cbo_price.Name = "cbo_price"
        Me.cbo_price.NewInitialValue = Nothing
        Me.cbo_price.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.cbo_price.ReadOnly = True
        Me.cbo_price.Requiered = False
        Me.cbo_price.Size = New System.Drawing.Size(104, 16)
        Me.cbo_price.TabIndex = 3
        Me.cbo_price.Text = "Precio x Mayor:"
        Me.cbo_price.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.cbo_price.ThreeState = True
        Me.cbo_price.value = Nothing
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(8, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Dias Descuento:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Disc_days
        '
        Me.Disc_days.EditInitialValue = Nothing
        Me.Disc_days.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Disc_days.FindInitialValue = Nothing
        Me.Disc_days.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Disc_days.IgnoreRequiered = False
        Me.Disc_days.Location = New System.Drawing.Point(104, 21)
        Me.Disc_days.Name = "Disc_days"
        Me.Disc_days.NewInitialValue = Nothing
        Me.Disc_days.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Disc_days.ReadOnly = True
        Me.Disc_days.Requiered = False
        Me.Disc_days.Size = New System.Drawing.Size(40, 20)
        Me.Disc_days.TabIndex = 4
        Me.Disc_days.TabStop = False
        Me.Disc_days.Text = ""
        '
        'Due_days
        '
        Me.Due_days.EditInitialValue = Nothing
        Me.Due_days.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Due_days.FindInitialValue = Nothing
        Me.Due_days.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Due_days.IgnoreRequiered = False
        Me.Due_days.Location = New System.Drawing.Point(104, 45)
        Me.Due_days.Name = "Due_days"
        Me.Due_days.NewInitialValue = Nothing
        Me.Due_days.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Due_days.ReadOnly = True
        Me.Due_days.Requiered = False
        Me.Due_days.Size = New System.Drawing.Size(40, 20)
        Me.Due_days.TabIndex = 5
        Me.Due_days.TabStop = False
        Me.Due_days.Text = ""
        '
        'Label15
        '
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(8, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 16)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Días Vencimiento:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Disc_pct
        '
        Me.Disc_pct.EditInitialValue = Nothing
        Me.Disc_pct.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Disc_pct.FindInitialValue = Nothing
        Me.Disc_pct.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Disc_pct.IgnoreRequiered = False
        Me.Disc_pct.Location = New System.Drawing.Point(104, 69)
        Me.Disc_pct.Name = "Disc_pct"
        Me.Disc_pct.NewInitialValue = Nothing
        Me.Disc_pct.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Disc_pct.ReadOnly = True
        Me.Disc_pct.Requiered = False
        Me.Disc_pct.Size = New System.Drawing.Size(40, 20)
        Me.Disc_pct.TabIndex = 6
        Me.Disc_pct.TabStop = False
        Me.Disc_pct.Text = ""
        '
        'Label17
        '
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Location = New System.Drawing.Point(8, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 16)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "% Descuento:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lkCliente
        '
        Me.lkCliente.CheckText = Nothing
        Me.lkCliente.DataMember = Nothing
        Me.lkCliente.DataSource = Me.LibXConnector1
        Me.lkCliente.DestParameters = New String() {"cust_code=cust_code", "cust_name=cust_name", "cbo_price=cust_pricemajor"}
        Me.lkCliente.FilterField = "cust_name"
        Me.lkCliente.IgnoreFindInBrowseMode = False
        Me.lkCliente.Location = New System.Drawing.Point(400, 120)
        Me.lkCliente.LookCaption = "Clientes"
        Me.lkCliente.Name = "lkCliente"
        Me.lkCliente.ShowMessageNotFound = True
        Me.lkCliente.ShowWarning = True
        Me.lkCliente.Size = New System.Drawing.Size(16, 20)
        Me.lkCliente.SizesColumns = New String() {"cust_name=450"}
        Me.lkCliente.SizesColumnsTab = Nothing
        Me.lkCliente.SqlString = New String() {"select cccustm.cust_code,cust_name,cctermm.term_code,due_days,disc_days,disc_pct," & _
        "cust_pricemajor", "from cccustm inner join cctermm on cccustm.term_code = cctermm.term_code"}
        Me.lkCliente.SQLTab = Nothing
        Me.lkCliente.SrcParameters = New String() {"cust_code=cust_code"}
        Me.lkCliente.TabIndex = 8
        Me.lkCliente.TableName = "cccustm"
        Me.lkCliente.UseCopyConnection = False
        Me.lkCliente.UseRowRetrieveEvents = False
        Me.lkCliente.UseTab = False
        Me.lkCliente.VisParameters = New String() {"Código=cust_code", "Nombre=cust_name"}
        Me.lkCliente.WhereCondition = Nothing
        Me.lkCliente.WhereParameters = Nothing
        '
        'lbx_fact_status
        '
        Me.lbx_fact_status.AllowDefaultSort = True
        Me.lbx_fact_status.bound = True
        Me.lbx_fact_status.currValue = Nothing
        Me.lbx_fact_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.fact_status"))
        Me.lbx_fact_status.DefaultWhereString = Nothing
        Me.lbx_fact_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lbx_fact_status.EditInitialValue = Nothing
        Me.lbx_fact_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.lbx_fact_status.FindInitialValue = Nothing
        Me.lbx_fact_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lbx_fact_status.IgnoreRequiered = False
        Me.lbx_fact_status.Items.AddRange(New Object() {"1-En almacen", "2-En Caja", "3-Despachada", "4-NC Aplicada", "0-Anulada"})
        Me.lbx_fact_status.Location = New System.Drawing.Point(496, 16)
        Me.lbx_fact_status.LookupKeyDisplayFields = Nothing
        Me.lbx_fact_status.LookupKeyField = Nothing
        Me.lbx_fact_status.LookupTableName = Nothing
        Me.lbx_fact_status.Name = "lbx_fact_status"
        Me.lbx_fact_status.NewInitialValue = Nothing
        Me.lbx_fact_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.lbx_fact_status.Requiered = False
        Me.lbx_fact_status.Required = False
        Me.lbx_fact_status.Size = New System.Drawing.Size(136, 21)
        Me.lbx_fact_status.SqlString = Nothing
        Me.lbx_fact_status.TabIndex = 5
        Me.lbx_fact_status.TabStop = False
        '
        'cust_name
        '
        Me.cust_name.EditInitialValue = Nothing
        Me.cust_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cust_name.FindInitialValue = Nothing
        Me.cust_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cust_name.IgnoreRequiered = False
        Me.cust_name.Location = New System.Drawing.Point(144, 120)
        Me.cust_name.Name = "cust_name"
        Me.cust_name.NewInitialValue = Nothing
        Me.cust_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cust_name.ReadOnly = True
        Me.cust_name.Requiered = False
        Me.cust_name.Size = New System.Drawing.Size(256, 20)
        Me.cust_name.TabIndex = 7
        Me.cust_name.TabStop = False
        Me.cust_name.Text = ""
        '
        'txtCliCodigo
        '
        Me.txtCliCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.cust_code"))
        Me.txtCliCodigo.EditInitialValue = Nothing
        Me.txtCliCodigo.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCliCodigo.FindInitialValue = Nothing
        Me.txtCliCodigo.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCliCodigo.IgnoreRequiered = False
        Me.txtCliCodigo.Location = New System.Drawing.Point(80, 120)
        Me.txtCliCodigo.Name = "txtCliCodigo"
        Me.txtCliCodigo.NewInitialValue = Nothing
        Me.txtCliCodigo.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCliCodigo.Requiered = False
        Me.txtCliCodigo.Size = New System.Drawing.Size(56, 20)
        Me.txtCliCodigo.TabIndex = 7
        Me.txtCliCodigo.Text = ""
        '
        'txtfact_number
        '
        Me.txtfact_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_number"))
        Me.txtfact_number.EditInitialValue = Nothing
        Me.txtfact_number.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtfact_number.FindInitialValue = Nothing
        Me.txtfact_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtfact_number.IgnoreRequiered = True
        Me.txtfact_number.Location = New System.Drawing.Point(80, 16)
        Me.txtfact_number.Name = "txtfact_number"
        Me.txtfact_number.NewInitialValue = Nothing
        Me.txtfact_number.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtfact_number.Requiered = False
        Me.txtfact_number.TabIndex = 1
        Me.txtfact_number.TabStop = False
        Me.txtfact_number.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(440, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Estatus:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(446, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMontoBruto
        '
        Me.txtMontoBruto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_total"))
        Me.txtMontoBruto.EditInitialValue = Nothing
        Me.txtMontoBruto.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtMontoBruto.FindInitialValue = Nothing
        Me.txtMontoBruto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMontoBruto.IgnoreRequiered = False
        Me.txtMontoBruto.Location = New System.Drawing.Point(496, 64)
        Me.txtMontoBruto.Name = "txtMontoBruto"
        Me.txtMontoBruto.NewInitialValue = Nothing
        Me.txtMontoBruto.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtMontoBruto.Requiered = False
        Me.txtMontoBruto.Size = New System.Drawing.Size(136, 20)
        Me.txtMontoBruto.TabIndex = 10
        Me.txtMontoBruto.TabStop = False
        Me.txtMontoBruto.Text = ""
        Me.txtMontoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDec
        '
        Me.txtDec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.descto"))
        Me.txtDec.EditInitialValue = Nothing
        Me.txtDec.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtDec.FindInitialValue = Nothing
        Me.txtDec.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtDec.IgnoreRequiered = False
        Me.txtDec.Location = New System.Drawing.Point(496, 88)
        Me.txtDec.Name = "txtDec"
        Me.txtDec.NewInitialValue = Nothing
        Me.txtDec.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtDec.Requiered = False
        Me.txtDec.Size = New System.Drawing.Size(136, 20)
        Me.txtDec.TabIndex = 11
        Me.txtDec.TabStop = False
        Me.txtDec.Text = ""
        Me.txtDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(424, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Descuento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtITbis
        '
        Me.txtITbis.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.itbis"))
        Me.txtITbis.EditInitialValue = Nothing
        Me.txtITbis.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtITbis.FindInitialValue = Nothing
        Me.txtITbis.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtITbis.IgnoreRequiered = False
        Me.txtITbis.Location = New System.Drawing.Point(496, 112)
        Me.txtITbis.Name = "txtITbis"
        Me.txtITbis.NewInitialValue = Nothing
        Me.txtITbis.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtITbis.Requiered = False
        Me.txtITbis.Size = New System.Drawing.Size(136, 20)
        Me.txtITbis.TabIndex = 12
        Me.txtITbis.TabStop = False
        Me.txtITbis.Text = ""
        Me.txtITbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(457, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 16)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Itbis:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTotal
        '
        Me.txtTotal.EditInitialValue = Nothing
        Me.txtTotal.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTotal.FindInitialValue = Nothing
        Me.txtTotal.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Blue
        Me.txtTotal.IgnoreRequiered = False
        Me.txtTotal.Location = New System.Drawing.Point(496, 136)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.NewInitialValue = Nothing
        Me.txtTotal.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Requiered = False
        Me.txtTotal.Size = New System.Drawing.Size(136, 24)
        Me.txtTotal.TabIndex = 13
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = ""
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(425, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Total Neto:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(416, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Monto Bruto:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(21, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cliente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtClinombre
        '
        Me.txtClinombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClinombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.bus_name"))
        Me.txtClinombre.EditInitialValue = Nothing
        Me.txtClinombre.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtClinombre.FindInitialValue = Nothing
        Me.txtClinombre.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtClinombre.IgnoreRequiered = False
        Me.txtClinombre.Location = New System.Drawing.Point(80, 96)
        Me.txtClinombre.Name = "txtClinombre"
        Me.txtClinombre.NewInitialValue = Nothing
        Me.txtClinombre.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtClinombre.Requiered = False
        Me.txtClinombre.Size = New System.Drawing.Size(312, 20)
        Me.txtClinombre.TabIndex = 6
        Me.txtClinombre.Text = ""
        '
        'xtxt_term_code
        '
        Me.xtxt_term_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.term_code"))
        Me.xtxt_term_code.EditInitialValue = Nothing
        Me.xtxt_term_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_term_code.FindInitialValue = Nothing
        Me.xtxt_term_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_term_code.IgnoreRequiered = False
        Me.xtxt_term_code.Location = New System.Drawing.Point(80, 144)
        Me.xtxt_term_code.Name = "xtxt_term_code"
        Me.xtxt_term_code.NewInitialValue = Nothing
        Me.xtxt_term_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_term_code.ReadOnly = True
        Me.xtxt_term_code.Requiered = False
        Me.xtxt_term_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_term_code.TabIndex = 8
        Me.xtxt_term_code.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(23, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 16)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Motivo:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(240, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Factura No.:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtfact_afect
        '
        Me.txtfact_afect.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_afect"))
        Me.txtfact_afect.EditInitialValue = Nothing
        Me.txtfact_afect.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtfact_afect.FindInitialValue = Nothing
        Me.txtfact_afect.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtfact_afect.IgnoreRequiered = True
        Me.txtfact_afect.Location = New System.Drawing.Point(312, 16)
        Me.txtfact_afect.Name = "txtfact_afect"
        Me.txtfact_afect.NewInitialValue = Nothing
        Me.txtfact_afect.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtfact_afect.Requiered = False
        Me.txtfact_afect.Size = New System.Drawing.Size(88, 20)
        Me.txtfact_afect.TabIndex = 2
        Me.txtfact_afect.TabStop = False
        Me.txtfact_afect.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label18.Location = New System.Drawing.Point(33, 168)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 16)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Nota:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_nota"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(80, 168)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(552, 20)
        Me.XTextBox1.TabIndex = 6
        Me.XTextBox1.Text = ""
        '
        'txtftserial_afect
        '
        Me.txtftserial_afect.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.ftserial_afect"))
        Me.txtftserial_afect.EditInitialValue = Nothing
        Me.txtftserial_afect.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtftserial_afect.FindInitialValue = Nothing
        Me.txtftserial_afect.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtftserial_afect.IgnoreRequiered = False
        Me.txtftserial_afect.Location = New System.Drawing.Point(663, 97)
        Me.txtftserial_afect.Name = "txtftserial_afect"
        Me.txtftserial_afect.NewInitialValue = Nothing
        Me.txtftserial_afect.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtftserial_afect.ReadOnly = True
        Me.txtftserial_afect.Requiered = False
        Me.txtftserial_afect.Size = New System.Drawing.Size(48, 20)
        Me.txtftserial_afect.TabIndex = 25
        Me.txtftserial_afect.Text = ""
        '
        'btnLoad
        '
        Me.btnLoad.Enabled = False
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoad.Location = New System.Drawing.Point(104, 592)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 32)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "Completa"
        '
        'vend_name
        '
        Me.vend_name.EditInitialValue = Nothing
        Me.vend_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.vend_name.FindInitialValue = Nothing
        Me.vend_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.vend_name.IgnoreRequiered = False
        Me.vend_name.Location = New System.Drawing.Point(152, 32)
        Me.vend_name.Name = "vend_name"
        Me.vend_name.NewInitialValue = Nothing
        Me.vend_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.vend_name.ReadOnly = True
        Me.vend_name.Requiered = False
        Me.vend_name.Size = New System.Drawing.Size(256, 20)
        Me.vend_name.TabIndex = 3
        Me.vend_name.TabStop = False
        Me.vend_name.Text = ""
        '
        'txtvend_code
        '
        Me.txtvend_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.vend_code"))
        Me.txtvend_code.EditInitialValue = Nothing
        Me.txtvend_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtvend_code.FindInitialValue = Nothing
        Me.txtvend_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtvend_code.IgnoreRequiered = False
        Me.txtvend_code.Location = New System.Drawing.Point(88, 32)
        Me.txtvend_code.Name = "txtvend_code"
        Me.txtvend_code.NewInitialValue = Nothing
        Me.txtvend_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtvend_code.Requiered = False
        Me.txtvend_code.Size = New System.Drawing.Size(56, 20)
        Me.txtvend_code.TabIndex = 2
        Me.txtvend_code.Text = ""
        '
        'xlk_vend_code
        '
        Me.xlk_vend_code.CheckText = Nothing
        Me.xlk_vend_code.DataMember = Nothing
        Me.xlk_vend_code.DataSource = Me.LibXConnector1
        Me.xlk_vend_code.DestParameters = New String() {"vend_code=vend_code", "vend_name=vend_name"}
        Me.xlk_vend_code.FilterField = Nothing
        Me.xlk_vend_code.IgnoreFindInBrowseMode = False
        Me.xlk_vend_code.Location = New System.Drawing.Point(408, 32)
        Me.xlk_vend_code.LookCaption = "Vendedores"
        Me.xlk_vend_code.Name = "xlk_vend_code"
        Me.xlk_vend_code.ShowMessageNotFound = True
        Me.xlk_vend_code.ShowWarning = False
        Me.xlk_vend_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_vend_code.SizesColumns = Nothing
        Me.xlk_vend_code.SizesColumnsTab = Nothing
        Me.xlk_vend_code.SqlString = Nothing
        Me.xlk_vend_code.SQLTab = Nothing
        Me.xlk_vend_code.SrcParameters = New String() {"vend_code=vend_code"}
        Me.xlk_vend_code.TabIndex = 4
        Me.xlk_vend_code.TableName = "ftvendm"
        Me.xlk_vend_code.UseCopyConnection = False
        Me.xlk_vend_code.UseRowRetrieveEvents = False
        Me.xlk_vend_code.UseTab = False
        Me.xlk_vend_code.VisParameters = New String() {"Código=vend_code", "Nombre=vend_name"}
        Me.xlk_vend_code.WhereCondition = Nothing
        Me.xlk_vend_code.WhereParameters = Nothing
        '
        'Label16
        '
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Location = New System.Drawing.Point(24, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 16)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Vendedor:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXGridDetalle
        '
        Me.LibXGridDetalle.AllowSorting = False
        Me.LibXGridDetalle.AutoAdjustLastColumn = True
        Me.LibXGridDetalle.AutoSearch = False
        Me.LibXGridDetalle.BackgroundColor = System.Drawing.Color.White
        Me.LibXGridDetalle.CaptionText = "Articulos"
        Me.LibXGridDetalle.ContextMenu = Me.ContextMenu1
        Me.LibXGridDetalle.DataMember = "ftfactd"
        Me.LibXGridDetalle.DataSource = Me.DataSet1
        Me.LibXGridDetalle.FullRowSelect = False
        Me.LibXGridDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGridDetalle.IsReadOnly = False
        Me.LibXGridDetalle.Location = New System.Drawing.Point(8, 264)
        Me.LibXGridDetalle.Name = "LibXGridDetalle"
        Me.LibXGridDetalle.ReadOnly = True
        Me.LibXGridDetalle.searchText = ""
        Me.LibXGridDetalle.showFooterBar = True
        Me.LibXGridDetalle.Size = New System.Drawing.Size(800, 256)
        Me.LibXGridDetalle.TabIndex = 1
        Me.LibXGridDetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGridDetalle.UseAutoFillLines = True
        Me.LibXGridDetalle.UseHandCursor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Borrar esta linea"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Refrescar"
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGridDetalle
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColitem_code, Me.gColwhse_code, Me.gColitem_name, Me.GridColQty, Me.GColprice, Me.gColdscto, Me.gColCosto, Me.gColExist, Me.gColIbis, Me.gColImporte})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ftfactd"
        '
        'gColitem_code
        '
        Me.gColitem_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColitem_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColitem_code.executeFindDuringFill = False
        Me.gColitem_code.Format = ""
        Me.gColitem_code.FormatInfo = Nothing
        Me.gColitem_code.HeaderText = "Producto"
        Me.gColitem_code.isReadOnly = False
        Me.gColitem_code.Lookup = Me.lkp_item_code
        Me.gColitem_code.MappingName = "item_code"
        Me.gColitem_code.MaxLength = 32767
        Me.gColitem_code.UseCustomCellFormat = False
        Me.gColitem_code.Width = 130
        '
        'lkp_item_code
        '
        Me.lkp_item_code.CheckText = ""
        Me.lkp_item_code.DataMember = Nothing
        Me.lkp_item_code.DataSource = Me.LibXConnector1
        Me.lkp_item_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "costo=costo", "whse_code=whse_code", "price=price", "dscto=dscto", "itbis=itbis"}
        Me.lkp_item_code.FilterField = "item_name"
        Me.lkp_item_code.IgnoreFindInBrowseMode = False
        Me.lkp_item_code.Location = New System.Drawing.Point(456, 208)
        Me.lkp_item_code.LookCaption = "Productos"
        Me.lkp_item_code.Name = "lkp_item_code"
        Me.lkp_item_code.ShowMessageNotFound = True
        Me.lkp_item_code.ShowWarning = True
        Me.lkp_item_code.Size = New System.Drawing.Size(16, 20)
        Me.lkp_item_code.SizesColumns = Nothing
        Me.lkp_item_code.SizesColumnsTab = Nothing
        Me.lkp_item_code.SqlString = New String() {"select ftfactd.item_code,ftfactd.whse_code,ivitemm.item_name,", "       ftfactd.qty,ftfactd.price,ftfactd.costo,ftfactd.dscto,ftfactd.itbis ", "from ftfactd inner join ivitemm on ivitemm.item_code = ftfactd.item_code"}
        Me.lkp_item_code.SQLTab = Nothing
        Me.lkp_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.lkp_item_code.TabIndex = 3
        Me.lkp_item_code.TableName = "ivitemv"
        Me.lkp_item_code.UseCopyConnection = False
        Me.lkp_item_code.UseRowRetrieveEvents = False
        Me.lkp_item_code.UseTab = False
        Me.lkp_item_code.VisParameters = New String() {"Código=item_code", "Descripción=item_name", "Cantidad=qty", "Precio Venta=price"}
        Me.lkp_item_code.WhereCondition = Nothing
        Me.lkp_item_code.WhereParameters = Nothing
        '
        'gColwhse_code
        '
        Me.gColwhse_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColwhse_code.Format = ""
        Me.gColwhse_code.FormatInfo = Nothing
        Me.gColwhse_code.ImageList = Nothing
        Me.gColwhse_code.isReadOnly = False
        Me.gColwhse_code.MappingName = "whse_code"
        Me.gColwhse_code.MaxLength = 32767
        Me.gColwhse_code.ReadOnly = True
        Me.gColwhse_code.UseCustomCellFormat = False
        Me.gColwhse_code.Width = 0
        '
        'gColitem_name
        '
        Me.gColitem_name.Format = ""
        Me.gColitem_name.FormatInfo = Nothing
        Me.gColitem_name.HeaderText = "Descripción"
        Me.gColitem_name.MappingName = "item_name"
        Me.gColitem_name.ReadOnly = True
        Me.gColitem_name.Width = 260
        '
        'GridColQty
        '
        Me.GridColQty.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.GridColQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.GridColQty.Format = "##,###,##0"
        Me.GridColQty.FormatInfo = Nothing
        Me.GridColQty.HeaderText = "Cantidadi"
        Me.GridColQty.ImageList = Nothing
        Me.GridColQty.isReadOnly = False
        Me.GridColQty.MappingName = "qty"
        Me.GridColQty.MaxLength = 32767
        Me.GridColQty.UseCustomCellFormat = False
        Me.GridColQty.Width = 65
        '
        'GColprice
        '
        Me.GColprice.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.GColprice.Format = "##,###,##0.00"
        Me.GColprice.FormatInfo = Nothing
        Me.GColprice.HeaderText = "Precioi"
        Me.GColprice.MappingName = "price"
        Me.GColprice.Width = 65
        '
        'gColdscto
        '
        Me.gColdscto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColdscto.Format = "##,###,##0.00"
        Me.gColdscto.FormatInfo = Nothing
        Me.gColdscto.HeaderText = "Descuentoi"
        Me.gColdscto.MappingName = "dscto"
        Me.gColdscto.Width = 65
        '
        'gColCosto
        '
        Me.gColCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColCosto.Format = ""
        Me.gColCosto.FormatInfo = Nothing
        Me.gColCosto.ImageList = Nothing
        Me.gColCosto.isReadOnly = False
        Me.gColCosto.MappingName = "costo"
        Me.gColCosto.MaxLength = 32767
        Me.gColCosto.ReadOnly = True
        Me.gColCosto.UseCustomCellFormat = False
        Me.gColCosto.Width = 0
        '
        'gColExist
        '
        Me.gColExist.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColExist.Format = ""
        Me.gColExist.FormatInfo = Nothing
        Me.gColExist.ImageList = Nothing
        Me.gColExist.isReadOnly = False
        Me.gColExist.MappingName = "exist"
        Me.gColExist.MaxLength = 32767
        Me.gColExist.ReadOnly = True
        Me.gColExist.UseCustomCellFormat = False
        Me.gColExist.Width = 0
        '
        'gColIbis
        '
        Me.gColIbis.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColIbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColIbis.Format = "##,###,##0.00"
        Me.gColIbis.FormatInfo = Nothing
        Me.gColIbis.HeaderText = "Itbisi"
        Me.gColIbis.ImageList = Nothing
        Me.gColIbis.isReadOnly = False
        Me.gColIbis.MappingName = "itbis"
        Me.gColIbis.MaxLength = 32767
        Me.gColIbis.ReadOnly = True
        Me.gColIbis.UseCustomCellFormat = False
        Me.gColIbis.Width = 65
        '
        'gColImporte
        '
        Me.gColImporte.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColImporte.Format = "##,###,##0.00"
        Me.gColImporte.FormatInfo = Nothing
        Me.gColImporte.HeaderText = "Importei"
        Me.gColImporte.MappingName = "Importe"
        Me.gColImporte.ReadOnly = True
        Me.gColImporte.Width = 85
        '
        'txt_item_name
        '
        Me.txt_item_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactd.item_name"))
        Me.txt_item_name.EditInitialValue = Nothing
        Me.txt_item_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txt_item_name.FindInitialValue = Nothing
        Me.txt_item_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txt_item_name.IgnoreRequiered = False
        Me.txt_item_name.Location = New System.Drawing.Point(96, 560)
        Me.txt_item_name.Name = "txt_item_name"
        Me.txt_item_name.NewInitialValue = Nothing
        Me.txt_item_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txt_item_name.ReadOnly = True
        Me.txt_item_name.Requiered = False
        Me.txt_item_name.Size = New System.Drawing.Size(680, 20)
        Me.txt_item_name.TabIndex = 8
        Me.txt_item_name.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(32, 560)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Producto:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnSerializar
        '
        Me.btnSerializar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSerializar.Location = New System.Drawing.Point(16, 592)
        Me.btnSerializar.Name = "btnSerializar"
        Me.btnSerializar.Size = New System.Drawing.Size(80, 32)
        Me.btnSerializar.TabIndex = 2
        Me.btnSerializar.Text = "Serializar"
        '
        'BtnEtiquitas
        '
        Me.BtnEtiquitas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEtiquitas.Location = New System.Drawing.Point(696, 592)
        Me.BtnEtiquitas.Name = "BtnEtiquitas"
        Me.BtnEtiquitas.Size = New System.Drawing.Size(75, 32)
        Me.BtnEtiquitas.TabIndex = 9
        Me.BtnEtiquitas.Text = "Etiquetas"
        '
        'XTextBox2
        '
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_ncf"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = True
        Me.XTextBox2.Location = New System.Drawing.Point(504, 32)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(296, 20)
        Me.XTextBox2.TabIndex = 11
        Me.XTextBox2.TabStop = False
        Me.XTextBox2.Text = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label19.Location = New System.Drawing.Point(448, 32)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 16)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "N. C. F.:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "fact_ncf"
        Me.DataColumn41.MaxLength = 20
        '
        'i_ftdevm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(818, 648)
        Me.Controls.Add(Me.XTextBox2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.BtnEtiquitas)
        Me.Controls.Add(Me.btnSerializar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_item_name)
        Me.Controls.Add(Me.vend_name)
        Me.Controls.Add(Me.txtvend_code)
        Me.Controls.Add(Me.LibXGridDetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.xlk_vend_code)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.lkp_item_code)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ftdevm01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Devolución de Facturas"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_Condicion.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim RecordUpdated As Integer = 0
    Dim mCli As Entidades.ParametroCliente
    Dim mConf As SGT.Inventario.Common.Configuration
    Dim mRowIvSetup As DataRow
    Dim oDocumento As SGT.Inventario.Entidades.Documento
    Dim oProducto As SGT.Inventario.Entidades.Articulo

    Dim mSerial As Integer
    Dim mPricemajor As Boolean

    Dim mFactNum As Integer
    Dim mCond As Integer
    Dim WhereStmt As String
    Dim WhDefault As Integer

    Private Sub i_ftfact01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mConf = New SGT.Inventario.Common.Configuration
            'LibXGridDetalle.footerOperations.add("Importe", "sum(Importe)")
            ftfactd.Columns("Importe").Expression = "(qty*price)-dscto+itbis"

            oDocumento = New SGT.Inventario.Entidades.Documento("DVF")
            oProducto = New SGT.Inventario.Entidades.Articulo
            WhDefault = Configuration.ConfigurationSettings.AppSettings.Get("LibXWhDefault")

            If Not LibXConnector1.Parameters Is Nothing Then
                If LibXConnector1.Parameters.Value.ToString.Length > 0 Then
                    WhereStmt = "ftfactm.ftserial_no = " & LibXConnector1.Parameters.Value.ToString
                    LibXConnector1.ExecuteFind(WhereStmt)
                End If
            End If

            oDoc = New SGT.Facturacion.Entidades.Documento

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Function PuedoDevolver(ByVal pserial_no As Integer, ByVal pitem_code As String) As Integer
        Dim SelectStmt As String
        Dim Vendido As Integer
        Dim Devuelto As Integer
        Try

            '// Buscando cuantos productos se vendienron en la factura
            SelectStmt = "select qty from ftfactd,ftfactm " & _
                         " where item_code = '" & pitem_code & "'" & _
                         "   and ftfactd.ftserial_no = " & pserial_no.ToString & _
                         "   and ftfactm.ftserial_no = ftfactd.ftserial_no " & _
                         "   and fact_status <> 0"

            Vendido = LibX.Data.Manager.GetScalar(SelectStmt)

            '// Buscar cuantos productos han sido devueltos
            SelectStmt = "select sum(qty) from ftfactd,ftfactm " & _
                         " where item_code = '" & pitem_code & "'" & _
                         "   and ftfactm.ftserial_afect = " & pserial_no.ToString & _
                         "   and ftfactm.ftserial_no = ftfactd.ftserial_no " & _
                         "   and fact_status <> 0"

            Devuelto = Val(LibX.Data.Manager.GetScalar(SelectStmt).ToString)

            Vendido = Vendido - Devuelto

            Return Vendido

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return 0

        End Try
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCli.Click
        Try
            Dim objForm As New Entidades.i_ftcustm01

            If mCli Is Nothing Then
                mCli = New Entidades.ParametroCliente
            End If

            mCli.Modalidad = LibXConnector1.State
            mCli.Company = Me.txtClinombre.Text
            objForm.Cli = mCli

            objForm.ShowDialog()

            If Not objForm.ok Then
                mCli = Nothing
            Else
                mCli.Company = objForm.Cli.Company
                Me.txtClinombre.Text = mCli.Company
                mCli.Contact = objForm.Cli.Contact
                mCli.Tel = objForm.Cli.Tel
                mCli.TelArea = objForm.Cli.TelArea
                mCli.Tel2 = objForm.Cli.Tel2
                mCli.Mail = objForm.Cli.Mail
                mCli.Address = objForm.Cli.Address
            End If
        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub
    Private Sub CalcularITBIS()
        Dim Itbis As Decimal
        Dim oParamItbis As SGT.Inventario.Entidades.Articulo.ParametrosCalcularItbis
        Try

            If Val(LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, Me.GridColQty)) <= 0 Then
                Exit Sub
            End If

            If Val(LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, Me.GColprice)) <= 0 Then
                Exit Sub
            End If

            oParamItbis = New SGT.Inventario.Entidades.Articulo.ParametrosCalcularItbis

            With oParamItbis
                .Producto = LibXGridDetalle.Item(LibXGridDetalle.CurrentRowIndex, 0)
                .Almacen = LibXGridDetalle.Item(LibXGridDetalle.CurrentRowIndex, 1)
                .Monto = (LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, Me.GridColQty) * _
                         LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, Me.GColprice)) - _
                         LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, Me.gColdscto)

            End With

            Itbis = oProducto.CalcularItbis(oParamItbis)

            LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.gColIbis, Itbis)

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub


    Private Sub LibXGridDetalle_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGridDetalle.CellValidate
        Dim SelectStmt As String
        Try
            '// Validar la cantidad
            If Me.GridColQty.Column = e.cell Then
                If IsNull(Me.gColitem_code.GetValue) Then
                    Exit Sub
                End If

                If IsNull(e.value) Then
                    e.hasErrors = True
                    Exit Sub
                End If

                Dim Precio As Integer = 0
                Dim Qty As Integer = e.value
                Dim QtySell As Integer

                SelectStmt = "select qty from ftfactd " & _
                           " where item_code = '" & LibXGridDetalle.GetValue(gColitem_code) & _
                           "'  and ftserial_no = " & txtftserial_afect.Text

                QtySell = PuedoDevolver(Val(txtftserial_afect.Text), LibXGridDetalle.GetValue(gColitem_code))
                'LibX.Data.Manager.GetScalar(SelectStmt)

                If QtySell <= 0 Then
                    LibXGridDetalle.EndEdit(Me.GridColQty, LibXGridDetalle.CurrentRowIndex, True)
                    Throw New ApplicationException("Este producto ya fue devuelto!")
                End If


                If Qty > QtySell Then
                    LibXGridDetalle.SetValue(GridColQty, QtySell)
                    Throw New ApplicationException("En esta factura solo se vendierón " & QtySell.ToString & " de este articulo")
                End If

                If Trim(Me.LibXGridDetalle.GetValue(GColprice)) <> "" Then
                    Precio = Me.LibXGridDetalle.GetValue(GColprice)
                End If
                CalcularITBIS()
            End If

            If Me.LibXGridDetalle.GetColNum(GColprice) = e.cell Then
                If IsNull(Me.gColitem_code.GetValue) Then
                    Exit Sub
                End If
                If IsNull(e.value) Then
                    e.hasErrors = True
                    Exit Sub
                End If
                CalcularITBIS()
            End If

            If Me.GridColQty.Column = e.cell Then
                If IsNull(Me.gColitem_code.GetValue) Then
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            e.hasErrors = True
            Log.Show(ex)
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

                oValue = Me.LibXGridDetalle.GetValue(i, Me.gColIbis)
                If Not IsNull(oValue) Then
                    itb = oValue
                End If

                oValue = Me.LibXGridDetalle.GetValue(i, Me.GridColQty)
                If Not IsNull(oValue) Then
                    oCant = oValue
                End If

                oValue = Me.LibXGridDetalle.GetValue(i, Me.GColprice)
                If Not IsNull(oValue) Then
                    oPrice = oValue
                End If
                oValue = Me.LibXGridDetalle.GetValue(i, gColdscto)
                If Not IsNull(oValue) Then
                    oDesc = oValue
                End If

                oValue = Me.gColCosto.GetValue(i)
                If Not IsNull(oValue) Then
                    costo = oValue
                End If

                tPrice = tPrice + oPrice
                tDesc = tDesc + oDesc
                TCant = TCant + oCant
                Titb = Titb + itb
                total += oCant * oPrice

                'If (oCant * oPrice) > 0 Then
                '    LibXGridDetalle.SetValue(i, gColImporte, (oCant * oPrice) - oDesc + itb)
                'End If
            Next

            Me.txtDec.Text = tDesc.ToString("###,###,##0.00")
            Me.txtTotal.Text = CDec(total - tDesc + Titb).ToString("###,###,##0.00")
            Me.txtITbis.Text = Titb.ToString("###,###,##0.00")
            Me.txtMontoBruto.Text = total.ToString("###,###,##0.00")

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub lkp_item_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkp_item_code.AfterSetValues
        Try

            If Not Me.LibXConnector1.IsEditing Then
                Exit Sub
            End If

            If e.dataFound = False Then
                Exit Sub
            End If

            txt_item_name.Text = e.row!item_name.ToString.Trim

        Catch ex As Exception
            Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try

            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                e.UpdatingArgs.Row!type_code = "DVF"
                e.UpdatingArgs.Row!fact_cond = 2 '// CREDITO
                e.UpdatingArgs.Row!fact_status = 2 ' "En Caja" 
                e.UpdatingArgs.Row!whse_code = WhDefault

                If Me.rdbContado.Checked Then
                    e.UpdatingArgs.Row!fact_cond = 1 '// Contado
                End If

                If Me.rdb_CompraCR.Checked = True Then
                    e.UpdatingArgs.Row!fact_cond = 3 '// Devolucion de Compra a Credito
                End If

                If LibX.IsNull(e.UpdatingArgs.Row!fact_date) Then
                    e.UpdatingArgs.Row!fact_date = LibX.Data.Manager.Connection.GetDate
                End If

                e.UpdatingArgs.Row!fact_number = oDocumento.GenerateNumber("DVF")
                e.UpdatingArgs.Row!fact_ncf = oDocumento.GenerateNCF("DVF", e.UpdatingArgs.Row!whse_code, SGT.Inventario.Entidades.Documento.TipoNCFEnum.ConValorFiscal)

                If e.UpdatingArgs.Row!fact_cond = 2 AndAlso LibX.IsNull(e.UpdatingArgs.Row!cust_code) Then
                    Throw New ApplicationException("Especifique un cliente registrado, o selecione cliente ocasinal")
                End If
            End If

        Catch ex As Exception
            Log.Add(ex, True)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred

        End Try
    End Sub

    Private Sub LibXConnector1_InsertedRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedRow
        Try
            Dim oS As LibX.Data.XInsertStmt

            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                mSerial = e.Serial

                If Not mCli Is Nothing And Me.rdbContado.Checked Then
                    oS = New LibX.Data.XInsertStmt("ftcustm")
                    oS!ftserial_no = mSerial
                    oS!cust_name = mCli.Contact
                    oS!company_name = mCli.Company
                    oS!area_code = mCli.TelArea
                    oS!phone = mCli.Tel
                    oS!phone1 = mCli.Tel2
                    oS!email = mCli.Mail
                    oS!address = mCli.Address
                    oS.Execute()
                End If

                'If mCond = 2 And rdb_CompraCR.Checked = True Then 'Credito
                '    AplicarPago(e.UpdatingArgs.Row)
                'End If
            End If

            RecordUpdated = 0
        Catch ex As Exception
            Log.Show(ex)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
        End Try
    End Sub

    Private Function AplicarPago(ByVal oRow As DataRow) As Boolean
        Dim xInsert As LibX.Data.XInsertStmt
        Dim oRowAplicar As DataRow
        Dim SelectStmt As String
        Dim mSerial As Integer
        Dim oDocumento As New SGT.Facturacion.Entidades.Documento
        Try
            SelectStmt = "select * from ftfactm " & _
                         " where ftserial_no = " & oRow!ftserial_afect.ToString

            oRowAplicar = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRowAplicar Is Nothing Then
                Throw New ApplicationException("No se encontró el documento a aplicar")
            End If

            SelectStmt = "select ccopend.* from ccopend " & _
                         " inner join ccinvcem " & _
                         "    on invce_no = " & oRowAplicar!fact_number.ToString & _
                         "   and type_code = '" & oRowAplicar!type_code.ToString.Trim & "'" & _
                         "   and ccopend.invce_serial = ccinvcem.invce_serial "

            oRowAplicar = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRowAplicar Is Nothing Then
                Throw New ApplicationException("No se encontró el documento a aplicar")
            End If

            xInsert = New LibX.Data.XInsertStmt("ccpaymd")

            xInsert.Fields("paym_serial") = oRow!ftserial_no
            xInsert.Fields("invce_serial") = oRowAplicar!invce_serial
            xInsert.Fields("line_no") = 1
            xInsert.Fields("due_date") = oRowAplicar!due_date
            xInsert.Fields("disc_amount") = 0
            xInsert.Fields("amount") = Val(oRow!fact_total.ToString.Trim) - Val(oRow!descto.ToString.Trim) + Val(oRow!itbis.ToString.Trim)
            xInsert.Fields("balance") = oRowAplicar!balance

            xInsert.Execute()

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False

        End Try
    End Function

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
                    Return True
                End If
            Next

            Return False

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return True
        End Try
    End Function

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try

            If e.Action = LibxConnectionActions.Edit Then
                If LibXConnector1.CurrentDataRow!fact_status = 3 Then '// Cobrada
                    e.Handled = True
                    Throw New ApplicationException("Este documento no puede ser modificado!")
                End If
            End If

            If e.Action = LibxConnectionActions.Add Or e.Action = LibxConnectionActions.Edit Then
                If mRowIvSetup Is Nothing Then
                    mRowIvSetup = LibX.Data.Manager.GetDataRow("Select * from ivsetup")
                    If mRowIvSetup Is Nothing Then
                        Throw New Exception("No se encuentra la configuración de inventario")
                    End If
                End If
            End If

            If e.Action = LibxConnectionActions.Accept And (e.AcceptedAction = LibxConnectionActions.Add Or e.AcceptedAction = LibxConnectionActions.Edit) Then
                If Me.rdbContado.Checked Then
                    '--> si es contado debe registrar toda la inf
                    If mCli Is Nothing Then
                        Exit Sub
                    End If
                    mCli.Company = Me.txtClinombre.Text

                    If Trim(mCli.Company) = "" Then
                        Throw New Exception("Debe completar la información del cliente")
                    End If

                    If Trim(mCli.Company) = "" Then
                        Throw New Exception("Debe completar la información del cliente")
                    End If
                End If
            End If

            If e.Action = LibxConnectionActions.Find Then
                rdbContado.Checked = False
                rdbCredito.Checked = False
                rdb_CompraCR.Checked = False
            End If

            If e.Action = LibxConnectionActions.Cancel Then
                txtTotal.Text = ""
            End If

        Catch ex As Exception
            Log.Add(ex, True)
        End Try
    End Sub

    Private Sub lkp_item_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lkp_item_code.BeforeExecuteQuery
        Try
            'Verifica que la existencia sea mayor que 0 y que el producto no este en estatus descontinuado.
            If LibXConnector1.IsDataEditing Then
                If txtftserial_afect.Text = "" Then
                    Throw New ApplicationException("Debe especificar la factura!")
                End If

                e.aditionalWhere = "ftfactd.ftserial_no = " & txtftserial_afect.Text
            End If

        Catch ex As Exception
            Log.Add(ex)
        End Try
    End Sub

    Private Sub lkCliente_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkCliente.AfterSetValues
        Try
            If Not LibXConnector1.IsDataEditing = True Then
                Exit Sub
            End If

            If e.dataFound = False Then
                Exit Sub
            End If

            xtxt_term_code.Text = e.row!term_code.ToString.Trim
            xlk_term_code.ExecuteFind()

            If rdbContado.Checked = True Then
                Disc_pct.Text = ""
                Due_days.Text = ""
                Disc_days.Text = ""
            Else
                Disc_pct.Text = e.row!Disc_pct.ToString.Trim
                Due_days.Text = e.row!Due_days.ToString.Trim
                Disc_days.Text = e.row!Disc_days.ToString.Trim
            End If

            If Not LibX.IsNull(e.row!cust_pricemajor) AndAlso e.row!cust_pricemajor = 1 Then
                cbo_price.Checked = True
            Else
                cbo_price.Checked = False
            End If

            If txtClinombre.Text.Length <= 0 Then
                txtClinombre.Text = e.row!cust_name
            End If

        Catch ex As Exception
            Log.Add(ex)
        End Try
    End Sub

    Private Sub lkCliente_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lkCliente.BeforeExecuteQuery
        e.aditionalWhere = "cccustm.cust_status <> 0 "
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try

            Me.DateTimePicker1.Value = LibX.Data.Manager.Connection.GetDate.ToString("d")
            e.row!whse_code = WhDefault

        Catch ex As Exception
            Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Dim SelecStmt As String
        Dim AxCrystalReport1 As LibX.ReportLib
        Try
            Me.Cursor = Cursors.WaitCursor
            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
                '// Tomar el Connection String del config
                AxCrystalReport1 = New LibX.ReportLib("FCT", "r_ftdevol01.rpt")

                With AxCrystalReport1
                    '// Recibir el SQL Query
                    .RetrieveSQLQuery()
                    SelecStmt = .SQLQuery
                    SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, "ftfactm.ftserial_no = " & LibXConnector1.CurrentDataRow!ftserial_no)
                    .SQLQuery = SelecStmt

                    '// Ejecutar el reporte
                    .Action = 1
                End With
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            e.AditionalWhere = "ftfactm.type_code = 'DVF' and ftfactm.whse_code = " & WhDefault.ToString
            WhereStmt = e.Where

            e.Sql = oDoc.PrepareSelectStmt(e.Sql)

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibxConnectionActions.Add Then
                mCli = Nothing
                Me.rdbContado.Checked = True
                lbx_fact_status.currValue = 1
                xcbo_TipoDevolucion.currValue = "CAM"
                txtfact_number.ReadOnly = True
                'gbx_Condicion.Enabled = False

                If LibX.User.VendedorID > 0 Then
                    txtvend_code.Text = LibX.User.VendedorID
                    xlk_vend_code.ExecuteFind()
                End If

                Dim ofrmTipo As New frmTipo
                ofrmTipo.ShowDialog(Me)

                If ofrmTipo.DialogResult = DialogResult.Cancel Then
                    e.Handled = True
                    Throw New ApplicationException("Devolucion Cancelada!")
                End If

                If ofrmTipo.TipoDevolucion = frmTipo.TipoDevolucionEnum.RMA Then
                    Me.xcbo_TipoDevolucion.SelectedValue = "RMA"
                Else
                    Me.xcbo_TipoDevolucion.SelectedValue = "CAM"
                End If
                LibXConnector1.CurrentDataRow!dev_type = Me.xcbo_TipoDevolucion.SelectedValue

                ofrmTipo = Nothing
            End If

            If e.Action = LibxConnectionActions.Find Then
                txtfact_number.ReadOnly = False
            End If

            If e.AcceptedAction = LibxConnectionActions.Add Then
                If Me.FaltaSerial(LibXConnector1.CurrentDataRow!ftserial_no) = True Then
                    Serializar(LibXConnector1.CurrentDataRow!ftserial_no)
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub AplicarInventario(ByVal pftserial_no As Integer)
        Dim oPostDoc As SGT.Facturacion.Operaciones.PosteoDocumento
        Dim oPostParam As SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

        Try

            oPostDoc = New SGT.Facturacion.Operaciones.PosteoDocumento
            oPostParam = New SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

            oPostParam.SerialNumero = pftserial_no
            oPostParam.UseTransaction = True
            oPostParam.AplicarInventario = True
            oPostParam.AplicarCXC = False
            oPostParam.ApliarComision = False
            oPostParam.UseTransaction = False

            oPostDoc.Aplicar(oPostParam)

        Catch ex As Exception
            Log.Add(ex)
        End Try

    End Sub
    Private Sub lkp_item_code_CreatedGridColumns(ByVal sender As Object, ByVal e As LibX.CreatedGridColumnsEventArgs) Handles lkp_item_code.CreatedGridColumns
        Try
            e.TStyle.GridColumnStyles.Item("item_name").Width = 300
            e.Grid.Parent.Width = e.Grid.Parent.Width + 300


        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub rdbCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCredito.CheckedChanged
        Try
            If LibXConnector1.IsEditing Then
                LibXConnector1.CurrentDataRow!fact_cond = 2
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub rdbContado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbContado.CheckedChanged
        Try
            If LibXConnector1.IsEditing Then
                LibXConnector1.CurrentDataRow!fact_cond = 1
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try
            gbx_Condicion.Enabled = e.isEditing
            btnSerializar.Enabled = (Not e.isDataEditing And LibXConnector1.HasRecords = True)
            btnLoad.Enabled = (e.isDataEditing And LibXConnector1.HasRecords = True)
            BtnEtiquitas.Enabled = (Not e.isDataEditing And LibXConnector1.HasRecords = True)

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
                    If LibXGridDetalle.GetValue(gColitem_code).ToString.Length <= 0 Then
                        lkp_item_code.ExecuteLookupGrid()
                    End If
                    Exit Sub
                End If

                If LibXGridDetalle.CurrentCell.ColumnNumber >= _
                LibXGridDetalle.TableStyles(0).GridColumnStyles.IndexOf(gColitem_name) Then
                    CalcularITBIS()
                    ActualizaTotal()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Try
            If LibXGridDetalle.CurrentRowIndex > -1 Then
                If MessageBox.Show("Seguro desea borrar este item?", "Borrar Linea", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    If ftfactd.Rows.Count > LibXGridDetalle.CurrentRowIndex Then
                        ftfactd.Rows.RemoveAt(LibXGridDetalle.CurrentRowIndex)
                    End If
                    ActualizaTotal()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub

    Private Function TieneSerie() As Boolean
        Dim SelectStmt As String
        Dim hasserial As Integer
        Try
            For Each oRow As DataRow In ftfactd.Rows
                SelectStmt = "select item_serial  from ivitemm " & _
                             "where item_code = '" & oRow!item_code.ToString.Trim & "'"

                hasserial = LibX.Data.Manager.GetScalar(SelectStmt)

                If hasserial = 1 Then
                    Return True
                    Exit Function
                End If
            Next

            Return False
        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Function


    Private Sub LibXConnector1_ValidatingControls(ByVal sender As Object, ByVal e As LibX.ValidatingControlsEventArgs) Handles LibXConnector1.ValidatingControls
        If IsNull(Me.DateTimePicker1.Value) Then
            Me.DateTimePicker1.Value = LibX.Data.Manager.Connection.GetDate
        End If
    End Sub

    Private Function LoadDocument(ByVal pftserial_no As Integer) As Boolean
        Dim SelectStmt As String
        Dim intQty As Integer
        Dim oTable As DataTable
        Try

            SelectStmt = "select ftfactd.*,ivitemm.item_name from ftfactd,ivitemm " & _
                         " where ftserial_no = " & pftserial_no.ToString & _
                         " and ftfactd.item_code = ivitemm.item_code "

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Throw New ApplicationException("Error buscando documento")
            End If

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("Este documento no tiene productos")
            End If

            ftfactd.Rows.Clear()
            For Each oRow As DataRow In oTable.Rows

                intQty = PuedoDevolver(oRow!ftserial_no, oRow!item_code.ToString)
                If intQty <= 0 Then
                    GoTo NEXT_REG
                End If

                Dim NewRow As DataRow = ftfactd.NewRow

                For Each oCol As DataColumn In oTable.Columns
                    If ftfactd.Columns.Contains(oCol.ColumnName) Then
                        NewRow.Item(oCol.ColumnName) = oRow.Item(oCol.ColumnName)
                    End If
                Next

                NewRow!ftserial_no = DBNull.Value
                NewRow!qty = intQty
                NewRow!costo = Val(oRow!costo.ToString)
                'NewRow!importe = (Val(oRow!qty.ToString) * Val(oRow!price.ToString)) _
                '                - Val(oRow!dscto.ToString) + Val(oRow!itbis.ToString)

                ftfactd.Rows.Add(NewRow)
                xlk_term_code.ExecuteFind()
NEXT_REG:

            Next

            ActualizaTotal()

            Return True

        Catch ex As Exception
            LibX.Log.Show(ex)
            Return False

        End Try
    End Function

    Private Function Serializar(ByVal pftserial_no As Integer) As Boolean
        Dim Param As LibX.LibxPrgParams
        Try
            If ftfactd.Rows.Count <= 0 Then
                Exit Function
            End If

            Param = New LibX.LibxPrgParams

            With Param
                If LibXConnector1.IsDataEditing Then
                    .Datos.Add("usetransaction", False)
                End If

                .Value = pftserial_no
                .Datos.Add("ftserial_no", pftserial_no)
                .Datos.Add("ftserial_afect", LibXConnector1.CurrentDataRow!ftserial_afect)
                .WhereToExecute = "ftserial_no = " & pftserial_no.ToString.Trim
                .initMode = LibxInitModes.Edit
            End With

            LibX.App.CurrentPrgParams = Param
            LibX.LibXRunner.Run("i_ftserial", "FCT", False)

            Return True

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False
        End Try

    End Function
    Private Sub btnSerializar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSerializar.Click

        Try
            Serializar(LibXConnector1.CurrentDataRow!ftserial_no)
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


    Private Sub lkp_item_code_BefeforeExecuteSqlFind(ByVal sender As Object, ByVal e As LibX.LookupFindEventArgs) Handles lkp_item_code.BefeforeExecuteSqlFind
        Try

            'Verifica que la existencia sea mayor que 0 y que el producto no este en estatus descontinuado.
            If LibXConnector1.IsDataEditing = True Then
                If txtftserial_afect.Text = "" Then
                    Throw New ApplicationException("Debe especificar la factura!")
                End If
                e.aditionalWhere = "ftfactd.ftserial_no = " & txtftserial_afect.Text
            End If

        Catch ex As Exception
            Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.AfterSaveDetail
        Try
            If LibXConnector1.State = LibxConnectorState.Insert Then
                '// Si existen producto con series, ya fueron serializados 
                '// aplicar inventario
                '//If TieneSerie() = True Then


                AplicarInventario(e.MasterRow!ftserial_no)
                '//End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
            e.Handled = True
        End Try
    End Sub


    Private Sub xlk_fact_afect_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_fact_afect.AfterSetValues
        Try

            If e.dataFound = False Then
                Exit Sub
            End If

            btnLoad.Enabled = True
            mCond = e.row!fact_cond

            rdbCredito.Enabled = False
            rdbContado.Enabled = False
            rdb_CompraCR.Enabled = False

            '// Contado OR Pago/Entrega
            If mCond = 1 Or mCond = 3 Then
                rdbCredito.Enabled = True
                rdbCredito.Checked = True
                rdbContado.Enabled = True
            End If

            '// Factura a Crédito
            If mCond = 2 Then
                '// Verificar si la factura esta o no saldada
                Dim oDoc As New SGT.CXC.Entidades.Factura
                Dim oCliente As New SGT.CXC.Entidades.Cliente

                oDoc.TipoDocumento = e.row!type_code
                oDoc.Numero = e.row!fact_number

                If oDoc.GetBalance() > 0 Or oCliente.GetBalance(e.row!cust_code) > 0 Then
                    rdb_CompraCR.Enabled = True
                    rdb_CompraCR.Checked = True
                Else
                    '// Verificar si el cliente tiene balance
                    rdbCredito.Checked = True
                    rdbCredito.Enabled = True
                End If

                oCliente = Nothing
                oDoc = Nothing
            End If

            If LibX.IsNull(e.row!cust_code) = True Then
                LibXConnector1.CurrentDataRow!cust_code = 16 '//CLIENTE OCASIONAL
                Me.txtCliCodigo.Text = 16 '// CLIENTE OCASIONAL
            End If

            lkCliente.ExecuteFind()

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try
            LoadDocument(Val(txtftserial_afect.Text))

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub xlk_fact_afect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xlk_fact_afect.Load

    End Sub

    Private Sub xlk_fact_afect_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_fact_afect.BeforeExecuteQuery
        If WhDefault > 0 Then
            e.aditionalWhere = "ftfactm.whse_code=" & WhDefault.ToString
        End If

    End Sub

    Private Sub BtnEtiquitas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEtiquitas.Click
        Dim SelecStmt As String
        Dim AxCrystalReport1 As LibX.ReportLib
        Try
            Me.Cursor = Cursors.WaitCursor
            '// Tomar el Connection String del config
            AxCrystalReport1 = New LibX.ReportLib("FCT", "r_ftetiq01.rpt")

            With AxCrystalReport1
                '// Recibir el SQL Query
                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, "ftseriem.ftserial_no = " & LibXConnector1.CurrentDataRow!ftserial_no)
                .SQLQuery = SelecStmt

                '// Ejecutar el reporte
                .Action = 1
            End With

        Catch ex As Exception
            LibX.Log.Add(ex, True)

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub rdb_CompraCR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_CompraCR.CheckedChanged
        Try
            If LibXConnector1.IsEditing Then
                LibXConnector1.CurrentDataRow!fact_cond = 3
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub xlk_fact_afect_CheckedChanged(ByVal sender As Object, ByVal e As LibX.CheckedChangedEventArgs) Handles xlk_fact_afect.CheckedChanged
        Try
            If e.CheckStatus = True Then
                e.Table.DefaultView.RowFilter = ("fact_cond = 2")
            Else
                e.Table.DefaultView.RowFilter = ("")
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If Not e.row Is Nothing Then
                If e.row!fact_cond = 1 Then
                    Me.rdbContado.Checked = True
                End If

                If e.row!fact_cond = 2 Then
                    Me.rdbCredito.Checked = True
                End If

                If e.row!fact_cond = 3 Then
                    Me.rdb_CompraCR.Checked = True
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class

