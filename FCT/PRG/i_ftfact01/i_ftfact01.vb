Imports LibX
Imports SGT.Facturacion.Entidades
Imports SGT
Public Class i_ftfact01
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtClinombre As LibX.XTextBox
    Friend WithEvents rdbContado As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCredito As System.Windows.Forms.RadioButton
    Friend WithEvents GridColQty As LibX.XEditTextBoxColumn
    Friend WithEvents LibXGridDetalle As LibX.LibXGrid
    Friend WithEvents gColdscto As LibX.XEditTextBoxColumn
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
    Friend WithEvents gColCosto As LibX.XEditTextBoxColumn
    Friend WithEvents lbx_fact_status As LibX.LibXCombo
    Friend WithEvents cbo_price As LibX.LibxCheckBox
    Friend WithEvents Disc_days As LibX.XTextBox
    Friend WithEvents Due_days As LibX.XTextBox
    Friend WithEvents Disc_pct As LibX.XTextBox
    Friend WithEvents txtfact_number As LibX.XTextBox
    Friend WithEvents txtvend_code As LibX.XTextBox
    Friend WithEvents xlk_vend_code As LibX.LibXLookup
    Friend WithEvents gbx_Condicion As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_item_name As LibX.XTextBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents gColPriceList As LibX.XEditTextBoxColumn
    Friend WithEvents gcolPriceMayor As LibX.XEditTextBoxColumn
    Friend WithEvents gColPriceMinor As LibX.XEditTextBoxColumn
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtcotiz_serial As System.Windows.Forms.TextBox
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
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
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents ftfactm As System.Data.DataTable
    Friend WithEvents ftfactd As System.Data.DataTable
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents btnAutorizar As System.Windows.Forms.Button
    Friend WithEvents btnCostos As System.Windows.Forms.Button
    Friend WithEvents mnuCostos As System.Windows.Forms.MenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents balance As LibX.XTextBox
    Friend WithEvents Credit_Limit As LibX.XTextBox
    Friend WithEvents txtCliCodigo As LibX.XTextBox
    Friend WithEvents vencido As LibX.XTextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GColprice As System.Windows.Forms.DataGridTextBoxColumn 'LibX.XEditTextBoxColumn
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents xcust_phone As LibX.XTextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnPendiente As System.Windows.Forms.Button
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents xlk_afect_serial As LibX.LibXLookup
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents btnComision As System.Windows.Forms.Button
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents chk_generarNCF As System.Windows.Forms.CheckBox
    Friend WithEvents chk_costo As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents xtxt_priceList As LibX.XTextBox
    Friend WithEvents xtxt_PriceMinor As LibX.XTextBox
    Friend WithEvents xtxt_priceMajor As LibX.XTextBox
    Friend WithEvents rdbPagoEntrega As System.Windows.Forms.RadioButton
    Friend WithEvents XTextBoxNCF As LibX.XTextBox
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ftfactm = New System.Data.DataTable
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
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.ftfactd = New System.Data.DataTable
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
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
        Me.STftfactm = New LibX.LibXDbSourceTable
        Me.STfactd = New LibX.LibXDbSourceTable
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.txtfact_number = New LibX.XTextBox
        Me.txtClinombre = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.txtCliCodigo = New LibX.XTextBox
        Me.Credit_Limit = New LibX.XTextBox
        Me.balance = New LibX.XTextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtcotiz_serial = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cust_name = New LibX.XTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMontoBruto = New LibX.XTextBox
        Me.txtDec = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtITbis = New LibX.XTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtTotal = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.vencido = New LibX.XTextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.xcust_phone = New LibX.XTextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.xlk_afect_serial = New LibX.LibXLookup
        Me.btnCli = New System.Windows.Forms.Button
        Me.gbx_Condicion = New System.Windows.Forms.GroupBox
        Me.rdbPagoEntrega = New System.Windows.Forms.RadioButton
        Me.rdbContado = New System.Windows.Forms.RadioButton
        Me.rdbCredito = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chk_costo = New System.Windows.Forms.CheckBox
        Me.chk_generarNCF = New System.Windows.Forms.CheckBox
        Me.cbo_price = New LibX.LibxCheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Disc_days = New LibX.XTextBox
        Me.Due_days = New LibX.XTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Disc_pct = New LibX.XTextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.lkCliente = New LibX.LibXLookup
        Me.lbx_fact_status = New LibX.LibXCombo
        Me.Label7 = New System.Windows.Forms.Label
        Me.vend_name = New LibX.XTextBox
        Me.txtvend_code = New LibX.XTextBox
        Me.xlk_vend_code = New LibX.LibXLookup
        Me.Label16 = New System.Windows.Forms.Label
        Me.LibXGridDetalle = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.mnuCostos = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColitem_code = New LibX.XDataGridTextButtonColumn
        Me.lkp_item_code = New LibX.LibXLookup
        Me.gColwhse_code = New LibX.XEditTextBoxColumn
        Me.gColitem_name = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GridColQty = New LibX.XEditTextBoxColumn
        Me.GColprice = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColCosto = New LibX.XEditTextBoxColumn
        Me.gColExist = New LibX.XEditTextBoxColumn
        Me.gColdscto = New LibX.XEditTextBoxColumn
        Me.gColIbis = New LibX.XEditTextBoxColumn
        Me.gColPriceList = New LibX.XEditTextBoxColumn
        Me.gcolPriceMayor = New LibX.XEditTextBoxColumn
        Me.gColPriceMinor = New LibX.XEditTextBoxColumn
        Me.gColImporte = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txt_item_name = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnAutorizar = New System.Windows.Forms.Button
        Me.btnCostos = New System.Windows.Forms.Button
        Me.btnPendiente = New System.Windows.Forms.Button
        Me.btnComision = New System.Windows.Forms.Button
        Me.XTextBoxNCF = New LibX.XTextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.xtxt_priceList = New LibX.XTextBox
        Me.xtxt_PriceMinor = New LibX.XTextBox
        Me.xtxt_priceMajor = New LibX.XTextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXNavigator1.FirstControlInFindMode = Me.txtfact_number
        Me.LibXNavigator1.FirstControlInNewMode = Me.txtClinombre
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(930, 24)
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
        Me.LibXConnector1.DataMember = "ftfactm"
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
        Me.LibXConnector1.ReportName = Nothing
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.STftfactm, Me.STfactd})
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
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftfactm, Me.ftfactd})
        '
        'ftfactm
        '
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53})
        Me.ftfactm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no"}, True)})
        Me.ftfactm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.ftfactm.TableName = "ftfactm"
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
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "bus_name"
        Me.DataColumn19.MaxLength = 40
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "fact_nota"
        Me.DataColumn20.MaxLength = 80
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "ftserial_afect"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "pay_adelant"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "phone"
        Me.DataColumn23.MaxLength = 13
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "cotiz_number"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "PriceMayor"
        Me.DataColumn43.DataType = GetType(System.Int16)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "pay_mora"
        Me.DataColumn44.DataType = GetType(System.Decimal)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "porc_comision"
        Me.DataColumn45.DataType = GetType(System.Decimal)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "fact_ncf"
        Me.DataColumn46.MaxLength = 20
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "GenerarNCF"
        Me.DataColumn47.DataType = GetType(System.Int16)
        '
        'ftfactd
        '
        Me.ftfactd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42})
        Me.ftfactd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no", "line_no"}, True)})
        Me.ftfactd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn25, Me.DataColumn26}
        Me.ftfactd.TableName = "ftfactd"
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "ftserial_no"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.AllowDBNull = False
        Me.DataColumn26.AutoIncrement = True
        Me.DataColumn26.AutoIncrementSeed = CType(1, Long)
        Me.DataColumn26.ColumnName = "line_no"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "item_code"
        Me.DataColumn27.MaxLength = 15
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.ColumnName = "whse_code"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "item_name"
        Me.DataColumn29.MaxLength = 100
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "qty"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "price"
        Me.DataColumn31.DataType = GetType(System.Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "dscto"
        Me.DataColumn32.DataType = GetType(System.Decimal)
        Me.DataColumn32.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "factor"
        Me.DataColumn33.DataType = GetType(System.Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "itbis"
        Me.DataColumn34.DataType = GetType(System.Decimal)
        Me.DataColumn34.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "costo"
        Me.DataColumn35.DataType = GetType(System.Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "unit_code"
        Me.DataColumn36.MaxLength = 5
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "Importe"
        Me.DataColumn37.DataType = GetType(System.Decimal)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "exist"
        Me.DataColumn38.DataType = GetType(System.Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "PriceList"
        Me.DataColumn39.DataType = GetType(System.Decimal)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "priceRD"
        Me.DataColumn40.DataType = GetType(System.Decimal)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "pricemayor"
        Me.DataColumn41.DataType = GetType(System.Decimal)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "priceminor"
        Me.DataColumn42.DataType = GetType(System.Decimal)
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
        Me.STftfactm.InnerJon = True
        Me.STftfactm.InsertOrder = 0
        Me.STftfactm.IsDetail = False
        Me.STftfactm.KeyFields = Nothing
        Me.STftfactm.LineColName = Nothing
        Me.STftfactm.MasterDetailRelation = Nothing
        Me.STftfactm.MasterTableName = Nothing
        Me.STftfactm.SerialColumnName = "ftserial_no"
        Me.STftfactm.Sort = Nothing
        Me.STftfactm.Source = New String() {"select ftfactm.*,", "ftcotizm.cotiz_number  from ftfactm", "left outer join ftcotizm on ftfactm.cotiz_serial = ftcotizm.cotiz_serial", "order by ftfactm.ftserial_no"}
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
        Me.STfactd.InnerJon = True
        Me.STfactd.InsertOrder = 0
        Me.STfactd.IsDetail = True
        Me.STfactd.KeyFields = "ftserial_no,line_no"
        Me.STfactd.LineColName = Nothing
        Me.STfactd.MasterDetailRelation = New String() {"ftserial_no=ftserial_no"}
        Me.STfactd.MasterTableName = Nothing
        Me.STfactd.SerialColumnName = ""
        Me.STfactd.Sort = Nothing
        Me.STfactd.Source = New String() {"select ftfactd.ftserial_no,line_no,ftfactd.item_code,ftfactd.whse_code,", "ivitemv1.item_name,qty,ftfactd.price,dscto,factor,itbis,ftfactd.costo,ftfactd.unit" & _
        "_code", "from ftfactd", "inner join ivitemv1", "on ftfactd.item_code = ivitemv1.item_code", "and ftfactd.whse_code = ivitemv1.whse_code"}
        Me.STfactd.TableName = "ftfactd"
        Me.STfactd.UpdateOrder = 0
        Me.STfactd.UseRowRetrieve = False
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "caja_code"
        Me.DataColumn48.DataType = GetType(System.Int32)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "caje_code"
        Me.DataColumn49.DataType = GetType(System.Int32)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "fact_inddomicilio"
        Me.DataColumn50.DataType = GetType(System.Int32)
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "address"
        Me.DataColumn51.MaxLength = 200
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "seg_amount"
        Me.DataColumn52.DataType = GetType(System.Decimal)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "prov_code"
        Me.DataColumn53.DataType = GetType(System.Int32)
        '
        'txtfact_number
        '
        Me.txtfact_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_number"))
        Me.txtfact_number.EditInitialValue = Nothing
        Me.txtfact_number.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtfact_number.FieldDescription = ""
        Me.txtfact_number.FindInitialValue = Nothing
        Me.txtfact_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtfact_number.IgnoreRequiered = True
        Me.txtfact_number.Location = New System.Drawing.Point(96, 20)
        Me.txtfact_number.Name = "txtfact_number"
        Me.txtfact_number.NewInitialValue = Nothing
        Me.txtfact_number.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtfact_number.Requiered = False
        Me.txtfact_number.StatusBarPanelDescripcion = Nothing
        Me.txtfact_number.TabIndex = 0
        Me.txtfact_number.TabStop = False
        Me.txtfact_number.Text = ""
        '
        'txtClinombre
        '
        Me.txtClinombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClinombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.bus_name"))
        Me.txtClinombre.EditInitialValue = Nothing
        Me.txtClinombre.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtClinombre.FieldDescription = ""
        Me.txtClinombre.FindInitialValue = Nothing
        Me.txtClinombre.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtClinombre.IgnoreRequiered = False
        Me.txtClinombre.Location = New System.Drawing.Point(96, 68)
        Me.txtClinombre.Name = "txtClinombre"
        Me.txtClinombre.NewInitialValue = Nothing
        Me.txtClinombre.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtClinombre.Requiered = False
        Me.txtClinombre.Size = New System.Drawing.Size(376, 20)
        Me.txtClinombre.StatusBarPanelDescripcion = Nothing
        Me.txtClinombre.TabIndex = 4
        Me.txtClinombre.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtCliCodigo)
        Me.GroupBox1.Controls.Add(Me.Credit_Limit)
        Me.GroupBox1.Controls.Add(Me.balance)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtcotiz_serial)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cust_name)
        Me.GroupBox1.Controls.Add(Me.txtfact_number)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMontoBruto)
        Me.GroupBox1.Controls.Add(Me.txtDec)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtITbis)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtClinombre)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.vencido)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.xcust_phone)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.xlk_afect_serial)
        Me.GroupBox1.Controls.Add(Me.btnCli)
        Me.GroupBox1.Controls.Add(Me.gbx_Condicion)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lkCliente)
        Me.GroupBox1.Controls.Add(Me.lbx_fact_status)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(916, 200)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.fact_date"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.FieldDescription = ""
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = False
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(608, 40)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = "now"
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Requiered = False
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(120, 20)
        Me.LibxDateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker1.TabIndex = 32
        '
        'txtCliCodigo
        '
        Me.txtCliCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.cust_code"))
        Me.txtCliCodigo.EditInitialValue = Nothing
        Me.txtCliCodigo.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCliCodigo.FieldDescription = ""
        Me.txtCliCodigo.FindInitialValue = Nothing
        Me.txtCliCodigo.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCliCodigo.IgnoreRequiered = False
        Me.txtCliCodigo.Location = New System.Drawing.Point(96, 92)
        Me.txtCliCodigo.Name = "txtCliCodigo"
        Me.txtCliCodigo.NewInitialValue = Nothing
        Me.txtCliCodigo.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCliCodigo.Requiered = False
        Me.txtCliCodigo.Size = New System.Drawing.Size(56, 20)
        Me.txtCliCodigo.StatusBarPanelDescripcion = Nothing
        Me.txtCliCodigo.TabIndex = 6
        Me.txtCliCodigo.Text = ""
        '
        'Credit_Limit
        '
        Me.Credit_Limit.EditInitialValue = Nothing
        Me.Credit_Limit.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Credit_Limit.FieldDescription = ""
        Me.Credit_Limit.FindInitialValue = Nothing
        Me.Credit_Limit.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Credit_Limit.IgnoreRequiered = False
        Me.Credit_Limit.Location = New System.Drawing.Point(333, 116)
        Me.Credit_Limit.Name = "Credit_Limit"
        Me.Credit_Limit.NewInitialValue = Nothing
        Me.Credit_Limit.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Credit_Limit.ReadOnly = True
        Me.Credit_Limit.Requiered = False
        Me.Credit_Limit.Size = New System.Drawing.Size(163, 20)
        Me.Credit_Limit.StatusBarPanelDescripcion = Nothing
        Me.Credit_Limit.TabIndex = 31
        Me.Credit_Limit.TabStop = False
        Me.Credit_Limit.Text = ""
        '
        'balance
        '
        Me.balance.EditInitialValue = Nothing
        Me.balance.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.balance.FieldDescription = ""
        Me.balance.FindInitialValue = Nothing
        Me.balance.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.balance.IgnoreRequiered = False
        Me.balance.Location = New System.Drawing.Point(96, 117)
        Me.balance.Name = "balance"
        Me.balance.NewInitialValue = Nothing
        Me.balance.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.balance.ReadOnly = True
        Me.balance.Requiered = False
        Me.balance.Size = New System.Drawing.Size(120, 20)
        Me.balance.StatusBarPanelDescripcion = Nothing
        Me.balance.TabIndex = 30
        Me.balance.TabStop = False
        Me.balance.Text = ""
        Me.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label18.Location = New System.Drawing.Point(40, 118)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 16)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Balance:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(232, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Límite de Crédito:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtcotiz_serial
        '
        Me.txtcotiz_serial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.cotiz_serial"))
        Me.txtcotiz_serial.Location = New System.Drawing.Point(232, 40)
        Me.txtcotiz_serial.Name = "txtcotiz_serial"
        Me.txtcotiz_serial.Size = New System.Drawing.Size(16, 20)
        Me.txtcotiz_serial.TabIndex = 27
        Me.txtcotiz_serial.TabStop = False
        Me.txtcotiz_serial.Text = ""
        Me.txtcotiz_serial.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(31, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "A Nombre:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cust_name
        '
        Me.cust_name.EditInitialValue = Nothing
        Me.cust_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cust_name.FieldDescription = ""
        Me.cust_name.FindInitialValue = Nothing
        Me.cust_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cust_name.IgnoreRequiered = False
        Me.cust_name.Location = New System.Drawing.Point(160, 92)
        Me.cust_name.Name = "cust_name"
        Me.cust_name.NewInitialValue = Nothing
        Me.cust_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cust_name.ReadOnly = True
        Me.cust_name.Requiered = False
        Me.cust_name.Size = New System.Drawing.Size(312, 20)
        Me.cust_name.StatusBarPanelDescripcion = Nothing
        Me.cust_name.TabIndex = 7
        Me.cust_name.TabStop = False
        Me.cust_name.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(280, 47)
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
        Me.Label2.Location = New System.Drawing.Point(557, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMontoBruto
        '
        Me.txtMontoBruto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_total"))
        Me.txtMontoBruto.EditInitialValue = Nothing
        Me.txtMontoBruto.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtMontoBruto.FieldDescription = ""
        Me.txtMontoBruto.FindInitialValue = Nothing
        Me.txtMontoBruto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMontoBruto.IgnoreRequiered = False
        Me.txtMontoBruto.Location = New System.Drawing.Point(608, 64)
        Me.txtMontoBruto.Name = "txtMontoBruto"
        Me.txtMontoBruto.NewInitialValue = Nothing
        Me.txtMontoBruto.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtMontoBruto.Requiered = False
        Me.txtMontoBruto.Size = New System.Drawing.Size(120, 20)
        Me.txtMontoBruto.StatusBarPanelDescripcion = Nothing
        Me.txtMontoBruto.TabIndex = 9
        Me.txtMontoBruto.TabStop = False
        Me.txtMontoBruto.Text = ""
        Me.txtMontoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDec
        '
        Me.txtDec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.descto"))
        Me.txtDec.EditInitialValue = Nothing
        Me.txtDec.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtDec.FieldDescription = ""
        Me.txtDec.FindInitialValue = Nothing
        Me.txtDec.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtDec.IgnoreRequiered = False
        Me.txtDec.Location = New System.Drawing.Point(608, 88)
        Me.txtDec.Name = "txtDec"
        Me.txtDec.NewInitialValue = Nothing
        Me.txtDec.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtDec.Requiered = False
        Me.txtDec.Size = New System.Drawing.Size(120, 20)
        Me.txtDec.StatusBarPanelDescripcion = Nothing
        Me.txtDec.TabIndex = 23
        Me.txtDec.TabStop = False
        Me.txtDec.Text = ""
        Me.txtDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(535, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Descuento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtITbis
        '
        Me.txtITbis.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.itbis"))
        Me.txtITbis.EditInitialValue = Nothing
        Me.txtITbis.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtITbis.FieldDescription = ""
        Me.txtITbis.FindInitialValue = Nothing
        Me.txtITbis.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtITbis.IgnoreRequiered = False
        Me.txtITbis.Location = New System.Drawing.Point(608, 112)
        Me.txtITbis.Name = "txtITbis"
        Me.txtITbis.NewInitialValue = Nothing
        Me.txtITbis.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtITbis.Requiered = False
        Me.txtITbis.Size = New System.Drawing.Size(120, 20)
        Me.txtITbis.StatusBarPanelDescripcion = Nothing
        Me.txtITbis.TabIndex = 21
        Me.txtITbis.TabStop = False
        Me.txtITbis.Text = ""
        Me.txtITbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(568, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 16)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Itbis:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTotal
        '
        Me.txtTotal.EditInitialValue = Nothing
        Me.txtTotal.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTotal.FieldDescription = ""
        Me.txtTotal.FindInitialValue = Nothing
        Me.txtTotal.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Blue
        Me.txtTotal.IgnoreRequiered = False
        Me.txtTotal.Location = New System.Drawing.Point(608, 136)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.NewInitialValue = Nothing
        Me.txtTotal.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Requiered = False
        Me.txtTotal.Size = New System.Drawing.Size(120, 24)
        Me.txtTotal.StatusBarPanelDescripcion = Nothing
        Me.txtTotal.TabIndex = 25
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = ""
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(527, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Monto Bruto:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(46, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cliente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(26, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Factura No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.cotiz_number"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = True
        Me.XTextBox1.Location = New System.Drawing.Point(96, 44)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(80, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 1
        Me.XTextBox1.TabStop = False
        Me.XTextBox1.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(8, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Cotización No.:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(56, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Nota:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox2
        '
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_nota"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(96, 168)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(808, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 9
        Me.XTextBox2.Text = ""
        '
        'vencido
        '
        Me.vencido.EditInitialValue = Nothing
        Me.vencido.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.vencido.FieldDescription = ""
        Me.vencido.FindInitialValue = Nothing
        Me.vencido.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.vencido.IgnoreRequiered = False
        Me.vencido.Location = New System.Drawing.Point(96, 142)
        Me.vencido.Name = "vencido"
        Me.vencido.NewInitialValue = Nothing
        Me.vencido.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.vencido.ReadOnly = True
        Me.vencido.Requiered = False
        Me.vencido.Size = New System.Drawing.Size(120, 20)
        Me.vencido.StatusBarPanelDescripcion = Nothing
        Me.vencido.TabIndex = 30
        Me.vencido.TabStop = False
        Me.vencido.Text = ""
        Me.vencido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label19.Location = New System.Drawing.Point(8, 144)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 16)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Monto Vencido:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcust_phone
        '
        Me.xcust_phone.EditInitialValue = Nothing
        Me.xcust_phone.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcust_phone.FieldDescription = ""
        Me.xcust_phone.FindInitialValue = Nothing
        Me.xcust_phone.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcust_phone.IgnoreRequiered = False
        Me.xcust_phone.Location = New System.Drawing.Point(333, 142)
        Me.xcust_phone.Name = "xcust_phone"
        Me.xcust_phone.NewInitialValue = Nothing
        Me.xcust_phone.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcust_phone.ReadOnly = True
        Me.xcust_phone.Requiered = False
        Me.xcust_phone.Size = New System.Drawing.Size(163, 20)
        Me.xcust_phone.StatusBarPanelDescripcion = Nothing
        Me.xcust_phone.TabIndex = 31
        Me.xcust_phone.TabStop = False
        Me.xcust_phone.Text = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label20.Location = New System.Drawing.Point(272, 144)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 16)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Teléfono:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_afect_serial
        '
        Me.xlk_afect_serial.AlternateFieldSearch = Nothing
        Me.xlk_afect_serial.CheckText = Nothing
        Me.xlk_afect_serial.DataMember = Nothing
        Me.xlk_afect_serial.DataSource = Me.LibXConnector1
        Me.xlk_afect_serial.DestParameters = New String() {"cotiz_serial=cotiz_serial", "cotiz_number=cotiz_number"}
        Me.xlk_afect_serial.FilterField = Nothing
        Me.xlk_afect_serial.IgnoreFindInBrowseMode = False
        Me.xlk_afect_serial.isCanceled = False
        Me.xlk_afect_serial.Location = New System.Drawing.Point(179, 44)
        Me.xlk_afect_serial.LookCaption = Nothing
        Me.xlk_afect_serial.Name = "xlk_afect_serial"
        Me.xlk_afect_serial.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_afect_serial.ShowMessageNotFound = True
        Me.xlk_afect_serial.ShowWarning = False
        Me.xlk_afect_serial.Size = New System.Drawing.Size(16, 20)
        Me.xlk_afect_serial.SizesColumns = New String() {"cust_name=450"}
        Me.xlk_afect_serial.SizesColumnsTab = Nothing
        Me.xlk_afect_serial.SqlString = Nothing
        Me.xlk_afect_serial.SQLTab = Nothing
        Me.xlk_afect_serial.SrcParameters = New String() {"cotiz_number=cotiz_number"}
        Me.xlk_afect_serial.TabIndex = 2
        Me.xlk_afect_serial.TableName = "ftcotizm"
        Me.xlk_afect_serial.UseCopyConnection = False
        Me.xlk_afect_serial.UseRowRetrieveEvents = False
        Me.xlk_afect_serial.UseTab = False
        Me.xlk_afect_serial.VisParameters = New String() {"Número=cotiz_number", "Fecha=cotiz_date", "Cliente=cust_name", "Telefono=phone", "Monto=cotiz_amount"}
        Me.xlk_afect_serial.WhereCondition = Nothing
        Me.xlk_afect_serial.WhereParameters = Nothing
        '
        'btnCli
        '
        Me.btnCli.Location = New System.Drawing.Point(472, 68)
        Me.btnCli.Name = "btnCli"
        Me.btnCli.Size = New System.Drawing.Size(24, 20)
        Me.btnCli.TabIndex = 5
        Me.btnCli.Text = "..."
        '
        'gbx_Condicion
        '
        Me.gbx_Condicion.Controls.Add(Me.rdbPagoEntrega)
        Me.gbx_Condicion.Controls.Add(Me.rdbContado)
        Me.gbx_Condicion.Controls.Add(Me.rdbCredito)
        Me.gbx_Condicion.Enabled = False
        Me.gbx_Condicion.Location = New System.Drawing.Point(224, 8)
        Me.gbx_Condicion.Name = "gbx_Condicion"
        Me.gbx_Condicion.Size = New System.Drawing.Size(272, 32)
        Me.gbx_Condicion.TabIndex = 0
        Me.gbx_Condicion.TabStop = False
        Me.gbx_Condicion.Text = "Condición de venta"
        '
        'rdbPagoEntrega
        '
        Me.rdbPagoEntrega.Location = New System.Drawing.Point(165, 11)
        Me.rdbPagoEntrega.Name = "rdbPagoEntrega"
        Me.rdbPagoEntrega.Size = New System.Drawing.Size(94, 16)
        Me.rdbPagoEntrega.TabIndex = 2
        Me.rdbPagoEntrega.Text = "Pago/Entrega"
        '
        'rdbContado
        '
        Me.rdbContado.Checked = True
        Me.rdbContado.Location = New System.Drawing.Point(8, 12)
        Me.rdbContado.Name = "rdbContado"
        Me.rdbContado.Size = New System.Drawing.Size(72, 16)
        Me.rdbContado.TabIndex = 0
        Me.rdbContado.TabStop = True
        Me.rdbContado.Text = "Contado"
        '
        'rdbCredito
        '
        Me.rdbCredito.Location = New System.Drawing.Point(88, 12)
        Me.rdbCredito.Name = "rdbCredito"
        Me.rdbCredito.Size = New System.Drawing.Size(72, 16)
        Me.rdbCredito.TabIndex = 1
        Me.rdbCredito.Text = "Crédito"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_costo)
        Me.GroupBox2.Controls.Add(Me.chk_generarNCF)
        Me.GroupBox2.Controls.Add(Me.cbo_price)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Disc_days)
        Me.GroupBox2.Controls.Add(Me.Due_days)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Disc_pct)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(752, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 152)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Condición:"
        '
        'chk_costo
        '
        Me.chk_costo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ftfactm, "GenerarNCF"))
        Me.chk_costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_costo.ForeColor = System.Drawing.Color.Red
        Me.chk_costo.Location = New System.Drawing.Point(13, 127)
        Me.chk_costo.Name = "chk_costo"
        Me.chk_costo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_costo.Size = New System.Drawing.Size(104, 16)
        Me.chk_costo.TabIndex = 6
        Me.chk_costo.Text = ":Al Costo"
        Me.chk_costo.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'chk_generarNCF
        '
        Me.chk_generarNCF.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ftfactm, "GenerarNCF"))
        Me.chk_generarNCF.Location = New System.Drawing.Point(13, 107)
        Me.chk_generarNCF.Name = "chk_generarNCF"
        Me.chk_generarNCF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_generarNCF.Size = New System.Drawing.Size(104, 16)
        Me.chk_generarNCF.TabIndex = 5
        Me.chk_generarNCF.Text = ":Generar NCF"
        Me.chk_generarNCF.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cbo_price
        '
        Me.cbo_price.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbo_price.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ftfactm.PriceMayor"))
        Me.cbo_price.EditInitialValue = Nothing
        Me.cbo_price.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.cbo_price.FindInitialValue = Nothing
        Me.cbo_price.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cbo_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_price.ForeColor = System.Drawing.Color.Red
        Me.cbo_price.IgnoreRequiered = False
        Me.cbo_price.KeepEnabled = False
        Me.cbo_price.Location = New System.Drawing.Point(14, 88)
        Me.cbo_price.Name = "cbo_price"
        Me.cbo_price.NewInitialValue = Nothing
        Me.cbo_price.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cbo_price.ReadOnly = True
        Me.cbo_price.Requiered = False
        Me.cbo_price.Size = New System.Drawing.Size(104, 16)
        Me.cbo_price.TabIndex = 0
        Me.cbo_price.Text = "Precio x Mayor"
        Me.cbo_price.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.cbo_price.ThreeState = True
        Me.cbo_price.value = Nothing
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(8, 16)
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
        Me.Disc_days.FieldDescription = ""
        Me.Disc_days.FindInitialValue = Nothing
        Me.Disc_days.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Disc_days.IgnoreRequiered = False
        Me.Disc_days.Location = New System.Drawing.Point(104, 16)
        Me.Disc_days.Name = "Disc_days"
        Me.Disc_days.NewInitialValue = Nothing
        Me.Disc_days.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Disc_days.ReadOnly = True
        Me.Disc_days.Requiered = False
        Me.Disc_days.Size = New System.Drawing.Size(40, 20)
        Me.Disc_days.StatusBarPanelDescripcion = Nothing
        Me.Disc_days.TabIndex = 0
        Me.Disc_days.TabStop = False
        Me.Disc_days.Text = ""
        '
        'Due_days
        '
        Me.Due_days.EditInitialValue = Nothing
        Me.Due_days.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Due_days.FieldDescription = ""
        Me.Due_days.FindInitialValue = Nothing
        Me.Due_days.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Due_days.IgnoreRequiered = False
        Me.Due_days.Location = New System.Drawing.Point(104, 40)
        Me.Due_days.Name = "Due_days"
        Me.Due_days.NewInitialValue = Nothing
        Me.Due_days.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Due_days.ReadOnly = True
        Me.Due_days.Requiered = False
        Me.Due_days.Size = New System.Drawing.Size(40, 20)
        Me.Due_days.StatusBarPanelDescripcion = Nothing
        Me.Due_days.TabIndex = 1
        Me.Due_days.TabStop = False
        Me.Due_days.Text = ""
        '
        'Label15
        '
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(8, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 16)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Días Vencimiento:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Disc_pct
        '
        Me.Disc_pct.EditInitialValue = Nothing
        Me.Disc_pct.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Disc_pct.FieldDescription = ""
        Me.Disc_pct.FindInitialValue = Nothing
        Me.Disc_pct.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Disc_pct.IgnoreRequiered = False
        Me.Disc_pct.Location = New System.Drawing.Point(104, 64)
        Me.Disc_pct.Name = "Disc_pct"
        Me.Disc_pct.NewInitialValue = Nothing
        Me.Disc_pct.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Disc_pct.ReadOnly = True
        Me.Disc_pct.Requiered = False
        Me.Disc_pct.Size = New System.Drawing.Size(40, 20)
        Me.Disc_pct.StatusBarPanelDescripcion = Nothing
        Me.Disc_pct.TabIndex = 2
        Me.Disc_pct.TabStop = False
        Me.Disc_pct.Text = ""
        '
        'Label17
        '
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Location = New System.Drawing.Point(16, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 16)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "% Descuento:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lkCliente
        '
        Me.lkCliente.AlternateFieldSearch = Nothing
        Me.lkCliente.CheckText = Nothing
        Me.lkCliente.DataMember = Nothing
        Me.lkCliente.DataSource = Me.LibXConnector1
        Me.lkCliente.DestParameters = New String() {"cust_code=cust_code", "cust_name=cust_name", "credit_limit=credit_limit", "xcust_phone=cust_phone"}
        Me.lkCliente.FilterField = "cust_name"
        Me.lkCliente.IgnoreFindInBrowseMode = False
        Me.lkCliente.isCanceled = False
        Me.lkCliente.Location = New System.Drawing.Point(480, 92)
        Me.lkCliente.LookCaption = "Clientes"
        Me.lkCliente.Name = "lkCliente"
        Me.lkCliente.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkCliente.ShowMessageNotFound = True
        Me.lkCliente.ShowWarning = True
        Me.lkCliente.Size = New System.Drawing.Size(16, 20)
        Me.lkCliente.SizesColumns = New String() {"cust_name=450"}
        Me.lkCliente.SizesColumnsTab = Nothing
        Me.lkCliente.SqlString = New String() {Nothing}
        Me.lkCliente.SQLTab = Nothing
        Me.lkCliente.SrcParameters = New String() {"cust_code=cust_code"}
        Me.lkCliente.TabIndex = 8
        Me.lkCliente.TableName = "cccustv1"
        Me.lkCliente.UseCopyConnection = False
        Me.lkCliente.UseRowRetrieveEvents = False
        Me.lkCliente.UseTab = False
        Me.lkCliente.VisParameters = New String() {"Código=cust_code", "Nombre=cust_name", "Teléfono=cust_phone"}
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
        Me.lbx_fact_status.FieldDescription = ""
        Me.lbx_fact_status.FindInitialValue = Nothing
        Me.lbx_fact_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lbx_fact_status.IgnoreRequiered = False
        Me.lbx_fact_status.Items.AddRange(New Object() {"1-En almacen", "2-En Caja", "3-Despachada", "4-Pendiente Autorización", "5-Devuelta", "0-Anulada"})
        Me.lbx_fact_status.Location = New System.Drawing.Point(336, 44)
        Me.lbx_fact_status.LookupKeyDisplayFields = Nothing
        Me.lbx_fact_status.LookupKeyField = Nothing
        Me.lbx_fact_status.LookupTableName = Nothing
        Me.lbx_fact_status.Name = "lbx_fact_status"
        Me.lbx_fact_status.NewInitialValue = Nothing
        Me.lbx_fact_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.lbx_fact_status.Requiered = False
        Me.lbx_fact_status.Required = False
        Me.lbx_fact_status.Size = New System.Drawing.Size(160, 21)
        Me.lbx_fact_status.SqlString = Nothing
        Me.lbx_fact_status.StatusBarPanelDescripcion = Nothing
        Me.lbx_fact_status.TabIndex = 3
        Me.lbx_fact_status.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(516, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Total Neto:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'vend_name
        '
        Me.vend_name.EditInitialValue = Nothing
        Me.vend_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.vend_name.FieldDescription = ""
        Me.vend_name.FindInitialValue = Nothing
        Me.vend_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.vend_name.IgnoreRequiered = False
        Me.vend_name.Location = New System.Drawing.Point(168, 32)
        Me.vend_name.Name = "vend_name"
        Me.vend_name.NewInitialValue = Nothing
        Me.vend_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.vend_name.ReadOnly = True
        Me.vend_name.Requiered = False
        Me.vend_name.Size = New System.Drawing.Size(320, 20)
        Me.vend_name.StatusBarPanelDescripcion = Nothing
        Me.vend_name.TabIndex = 3
        Me.vend_name.TabStop = False
        Me.vend_name.Text = ""
        '
        'txtvend_code
        '
        Me.txtvend_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.vend_code"))
        Me.txtvend_code.EditInitialValue = Nothing
        Me.txtvend_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtvend_code.FieldDescription = ""
        Me.txtvend_code.FindInitialValue = Nothing
        Me.txtvend_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtvend_code.IgnoreRequiered = False
        Me.txtvend_code.Location = New System.Drawing.Point(104, 32)
        Me.txtvend_code.Name = "txtvend_code"
        Me.txtvend_code.NewInitialValue = Nothing
        Me.txtvend_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtvend_code.Requiered = False
        Me.txtvend_code.Size = New System.Drawing.Size(56, 20)
        Me.txtvend_code.StatusBarPanelDescripcion = Nothing
        Me.txtvend_code.TabIndex = 1
        Me.txtvend_code.Text = ""
        '
        'xlk_vend_code
        '
        Me.xlk_vend_code.AlternateFieldSearch = Nothing
        Me.xlk_vend_code.CheckText = Nothing
        Me.xlk_vend_code.DataMember = Nothing
        Me.xlk_vend_code.DataSource = Me.LibXConnector1
        Me.xlk_vend_code.DestParameters = New String() {"vend_code=vend_code", "vend_name=vend_name", "porc_comision=porc_comision"}
        Me.xlk_vend_code.FilterField = Nothing
        Me.xlk_vend_code.IgnoreFindInBrowseMode = False
        Me.xlk_vend_code.isCanceled = False
        Me.xlk_vend_code.Location = New System.Drawing.Point(488, 32)
        Me.xlk_vend_code.LookCaption = "Vendedores"
        Me.xlk_vend_code.Name = "xlk_vend_code"
        Me.xlk_vend_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_vend_code.ShowMessageNotFound = True
        Me.xlk_vend_code.ShowWarning = False
        Me.xlk_vend_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_vend_code.SizesColumns = Nothing
        Me.xlk_vend_code.SizesColumnsTab = Nothing
        Me.xlk_vend_code.SqlString = Nothing
        Me.xlk_vend_code.SQLTab = Nothing
        Me.xlk_vend_code.SrcParameters = New String() {"vend_code=vend_code"}
        Me.xlk_vend_code.TabIndex = 3
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
        Me.Label16.Location = New System.Drawing.Point(40, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 16)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Vendedor:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXGridDetalle
        '
        Me.LibXGridDetalle.AllowSorting = False
        Me.LibXGridDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.LibXGridDetalle.Size = New System.Drawing.Size(916, 256)
        Me.LibXGridDetalle.TabIndex = 2
        Me.LibXGridDetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGridDetalle.UseAutoFillLines = True
        Me.LibXGridDetalle.UseHandCursor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.mnuCostos, Me.MenuItem4, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Borrar esta linea"
        '
        'mnuCostos
        '
        Me.mnuCostos.Index = 1
        Me.mnuCostos.Text = "Costos"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 3
        Me.MenuItem2.Text = "Refrescar"
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGridDetalle
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColitem_code, Me.gColwhse_code, Me.gColitem_name, Me.GridColQty, Me.GColprice, Me.gColCosto, Me.gColExist, Me.gColdscto, Me.gColIbis, Me.gColPriceList, Me.gcolPriceMayor, Me.gColPriceMinor, Me.gColImporte})
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
        Me.gColitem_code.TabStop = True
        Me.gColitem_code.UseCustomCellFormat = False
        Me.gColitem_code.Width = 125
        '
        'lkp_item_code
        '
        Me.lkp_item_code.AlternateFieldSearch = Nothing
        Me.lkp_item_code.CheckText = Nothing
        Me.lkp_item_code.DataMember = Nothing
        Me.lkp_item_code.DataSource = Me.LibXConnector1
        Me.lkp_item_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "whse_code=whse_code", "price=priceRD", "exist=existencia", "pricelist=priceRD", "pricemayor=pricemayor", "priceminor=priceminor"}
        Me.lkp_item_code.FilterField = "item_name"
        Me.lkp_item_code.IgnoreFindInBrowseMode = True
        Me.lkp_item_code.isCanceled = False
        Me.lkp_item_code.Location = New System.Drawing.Point(456, 208)
        Me.lkp_item_code.LookCaption = "Productos"
        Me.lkp_item_code.Name = "lkp_item_code"
        Me.lkp_item_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkp_item_code.ShowMessageNotFound = True
        Me.lkp_item_code.ShowWarning = True
        Me.lkp_item_code.Size = New System.Drawing.Size(16, 20)
        Me.lkp_item_code.SizesColumns = New String() {"item_name=450"}
        Me.lkp_item_code.SizesColumnsTab = New String() {"Almacen=300", "Producto=300"}
        Me.lkp_item_code.SqlString = New String() {Nothing}
        Me.lkp_item_code.SQLTab = New String() {"select whse_name Almacen,item_name Producto,existencia Existencia,", "priceRD [Precio Lista],priceminor [Precio Mínimo],", "pricemayor [Precio x Mayor] from ivwhsem", "inner join ivitemv1 on ivitemv1.whse_code = ivwhsem.whse_code"}
        Me.lkp_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.lkp_item_code.TabIndex = 3
        Me.lkp_item_code.TableName = "ivitemv1"
        Me.lkp_item_code.UseCopyConnection = False
        Me.lkp_item_code.UseRowRetrieveEvents = False
        Me.lkp_item_code.UseTab = True
        Me.lkp_item_code.VisParameters = New String() {"Código=item_code", "Descripción=item_name", "Precio US=price", "Precio Lista=priceRD", "Precio Mínimo=priceminor", "Precio x Mayor=pricemayor", "Existencia=existencia"}
        Me.lkp_item_code.WhereCondition = Nothing
        Me.lkp_item_code.WhereParameters = "ivitemv1.item_code='?item_code'"
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
        Me.gColwhse_code.TabStop = True
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
        Me.gColitem_name.Width = 325
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
        Me.GridColQty.TabStop = True
        Me.GridColQty.UseCustomCellFormat = False
        Me.GridColQty.Width = 81
        '
        'GColprice
        '
        Me.GColprice.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.GColprice.Format = "##,###,##0.00"
        Me.GColprice.FormatInfo = Nothing
        Me.GColprice.HeaderText = "Precioi"
        Me.GColprice.MappingName = "price"
        Me.GColprice.Width = 81
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
        Me.gColCosto.TabStop = True
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
        Me.gColExist.TabStop = True
        Me.gColExist.UseCustomCellFormat = False
        Me.gColExist.Width = 0
        '
        'gColdscto
        '
        Me.gColdscto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColdscto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColdscto.Format = "##,###,##0.00"
        Me.gColdscto.FormatInfo = Nothing
        Me.gColdscto.HeaderText = "Descuentoi"
        Me.gColdscto.ImageList = Nothing
        Me.gColdscto.isReadOnly = False
        Me.gColdscto.MappingName = "dscto"
        Me.gColdscto.MaxLength = 32767
        Me.gColdscto.TabStop = True
        Me.gColdscto.UseCustomCellFormat = False
        Me.gColdscto.Width = 81
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
        Me.gColIbis.TabStop = True
        Me.gColIbis.UseCustomCellFormat = False
        Me.gColIbis.Width = 81
        '
        'gColPriceList
        '
        Me.gColPriceList.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColPriceList.Format = ""
        Me.gColPriceList.FormatInfo = Nothing
        Me.gColPriceList.ImageList = Nothing
        Me.gColPriceList.isReadOnly = False
        Me.gColPriceList.MappingName = "PriceList"
        Me.gColPriceList.MaxLength = 32767
        Me.gColPriceList.ReadOnly = True
        Me.gColPriceList.TabStop = True
        Me.gColPriceList.UseCustomCellFormat = False
        Me.gColPriceList.Width = 0
        '
        'gcolPriceMayor
        '
        Me.gcolPriceMayor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolPriceMayor.Format = ""
        Me.gcolPriceMayor.FormatInfo = Nothing
        Me.gcolPriceMayor.ImageList = Nothing
        Me.gcolPriceMayor.isReadOnly = False
        Me.gcolPriceMayor.MappingName = "pricemayor"
        Me.gcolPriceMayor.MaxLength = 32767
        Me.gcolPriceMayor.ReadOnly = True
        Me.gcolPriceMayor.TabStop = True
        Me.gcolPriceMayor.UseCustomCellFormat = False
        Me.gcolPriceMayor.Width = 0
        '
        'gColPriceMinor
        '
        Me.gColPriceMinor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColPriceMinor.Format = ""
        Me.gColPriceMinor.FormatInfo = Nothing
        Me.gColPriceMinor.ImageList = Nothing
        Me.gColPriceMinor.isReadOnly = False
        Me.gColPriceMinor.MappingName = "priceminor"
        Me.gColPriceMinor.MaxLength = 32767
        Me.gColPriceMinor.ReadOnly = True
        Me.gColPriceMinor.TabStop = True
        Me.gColPriceMinor.UseCustomCellFormat = False
        Me.gColPriceMinor.Width = 0
        '
        'gColImporte
        '
        Me.gColImporte.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColImporte.Format = "##,###,##0.00"
        Me.gColImporte.FormatInfo = Nothing
        Me.gColImporte.HeaderText = "Importei"
        Me.gColImporte.MappingName = "Importe"
        Me.gColImporte.ReadOnly = True
        Me.gColImporte.Width = 81
        '
        'txt_item_name
        '
        Me.txt_item_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_item_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactd.item_name"))
        Me.txt_item_name.EditInitialValue = Nothing
        Me.txt_item_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txt_item_name.FieldDescription = ""
        Me.txt_item_name.FindInitialValue = Nothing
        Me.txt_item_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txt_item_name.IgnoreRequiered = False
        Me.txt_item_name.Location = New System.Drawing.Point(8, 592)
        Me.txt_item_name.Name = "txt_item_name"
        Me.txt_item_name.NewInitialValue = Nothing
        Me.txt_item_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txt_item_name.ReadOnly = True
        Me.txt_item_name.Requiered = False
        Me.txt_item_name.Size = New System.Drawing.Size(624, 20)
        Me.txt_item_name.StatusBarPanelDescripcion = Nothing
        Me.txt_item_name.TabIndex = 8
        Me.txt_item_name.Text = ""
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(0, 576)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Producto:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnAutorizar
        '
        Me.btnAutorizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAutorizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAutorizar.Location = New System.Drawing.Point(8, 620)
        Me.btnAutorizar.Name = "btnAutorizar"
        Me.btnAutorizar.Size = New System.Drawing.Size(75, 32)
        Me.btnAutorizar.TabIndex = 9
        Me.btnAutorizar.Text = "Autorización Desactivada"
        '
        'btnCostos
        '
        Me.btnCostos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCostos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCostos.Location = New System.Drawing.Point(88, 620)
        Me.btnCostos.Name = "btnCostos"
        Me.btnCostos.Size = New System.Drawing.Size(75, 32)
        Me.btnCostos.TabIndex = 9
        Me.btnCostos.Text = "Costos"
        '
        'btnPendiente
        '
        Me.btnPendiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPendiente.Location = New System.Drawing.Point(168, 620)
        Me.btnPendiente.Name = "btnPendiente"
        Me.btnPendiente.Size = New System.Drawing.Size(75, 32)
        Me.btnPendiente.TabIndex = 10
        Me.btnPendiente.Text = "Pendiente Autorización"
        '
        'btnComision
        '
        Me.btnComision.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnComision.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComision.Location = New System.Drawing.Point(720, 620)
        Me.btnComision.Name = "btnComision"
        Me.btnComision.Size = New System.Drawing.Size(75, 32)
        Me.btnComision.TabIndex = 11
        Me.btnComision.Text = "Cambiar % Comisión"
        '
        'XTextBoxNCF
        '
        Me.XTextBoxNCF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_ncf"))
        Me.XTextBoxNCF.EditInitialValue = Nothing
        Me.XTextBoxNCF.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBoxNCF.FieldDescription = ""
        Me.XTextBoxNCF.FindInitialValue = Nothing
        Me.XTextBoxNCF.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBoxNCF.IgnoreRequiered = False
        Me.XTextBoxNCF.Location = New System.Drawing.Point(616, 32)
        Me.XTextBoxNCF.Name = "XTextBoxNCF"
        Me.XTextBoxNCF.NewInitialValue = Nothing
        Me.XTextBoxNCF.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBoxNCF.Requiered = False
        Me.XTextBoxNCF.Size = New System.Drawing.Size(304, 20)
        Me.XTextBoxNCF.StatusBarPanelDescripcion = Nothing
        Me.XTextBoxNCF.TabIndex = 13
        Me.XTextBoxNCF.Text = ""
        '
        'Label21
        '
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Location = New System.Drawing.Point(552, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 16)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "N. C. F.:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_priceList
        '
        Me.xtxt_priceList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.xtxt_priceList.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactd.PriceList"))
        Me.xtxt_priceList.EditInitialValue = Nothing
        Me.xtxt_priceList.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_priceList.FieldDescription = ""
        Me.xtxt_priceList.FindInitialValue = Nothing
        Me.xtxt_priceList.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_priceList.IgnoreRequiered = False
        Me.xtxt_priceList.Location = New System.Drawing.Point(640, 592)
        Me.xtxt_priceList.Name = "xtxt_priceList"
        Me.xtxt_priceList.NewInitialValue = Nothing
        Me.xtxt_priceList.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_priceList.ReadOnly = True
        Me.xtxt_priceList.Requiered = False
        Me.xtxt_priceList.Size = New System.Drawing.Size(91, 20)
        Me.xtxt_priceList.StatusBarPanelDescripcion = Nothing
        Me.xtxt_priceList.TabIndex = 14
        Me.xtxt_priceList.Text = ""
        Me.xtxt_priceList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xtxt_PriceMinor
        '
        Me.xtxt_PriceMinor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.xtxt_PriceMinor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactd.priceminor"))
        Me.xtxt_PriceMinor.EditInitialValue = Nothing
        Me.xtxt_PriceMinor.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_PriceMinor.FieldDescription = ""
        Me.xtxt_PriceMinor.FindInitialValue = Nothing
        Me.xtxt_PriceMinor.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_PriceMinor.IgnoreRequiered = False
        Me.xtxt_PriceMinor.Location = New System.Drawing.Point(736, 592)
        Me.xtxt_PriceMinor.Name = "xtxt_PriceMinor"
        Me.xtxt_PriceMinor.NewInitialValue = Nothing
        Me.xtxt_PriceMinor.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_PriceMinor.ReadOnly = True
        Me.xtxt_PriceMinor.Requiered = False
        Me.xtxt_PriceMinor.Size = New System.Drawing.Size(91, 20)
        Me.xtxt_PriceMinor.StatusBarPanelDescripcion = Nothing
        Me.xtxt_PriceMinor.TabIndex = 15
        Me.xtxt_PriceMinor.Text = ""
        Me.xtxt_PriceMinor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xtxt_priceMajor
        '
        Me.xtxt_priceMajor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.xtxt_priceMajor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactd.pricemayor"))
        Me.xtxt_priceMajor.EditInitialValue = Nothing
        Me.xtxt_priceMajor.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_priceMajor.FieldDescription = ""
        Me.xtxt_priceMajor.FindInitialValue = Nothing
        Me.xtxt_priceMajor.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_priceMajor.IgnoreRequiered = False
        Me.xtxt_priceMajor.Location = New System.Drawing.Point(832, 592)
        Me.xtxt_priceMajor.Name = "xtxt_priceMajor"
        Me.xtxt_priceMajor.NewInitialValue = Nothing
        Me.xtxt_priceMajor.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_priceMajor.ReadOnly = True
        Me.xtxt_priceMajor.Requiered = False
        Me.xtxt_priceMajor.Size = New System.Drawing.Size(91, 20)
        Me.xtxt_priceMajor.StatusBarPanelDescripcion = Nothing
        Me.xtxt_priceMajor.TabIndex = 16
        Me.xtxt_priceMajor.Text = ""
        Me.xtxt_priceMajor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label22.Location = New System.Drawing.Point(664, 576)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(63, 16)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "Precio Lista"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label23.Location = New System.Drawing.Point(744, 576)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(76, 16)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "Precio Mínimo"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label24.Location = New System.Drawing.Point(840, 576)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 16)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "Precio x Mayor"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'i_ftfact01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(930, 664)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.xtxt_priceMajor)
        Me.Controls.Add(Me.xtxt_PriceMinor)
        Me.Controls.Add(Me.xtxt_priceList)
        Me.Controls.Add(Me.XTextBoxNCF)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_item_name)
        Me.Controls.Add(Me.vend_name)
        Me.Controls.Add(Me.txtvend_code)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.btnComision)
        Me.Controls.Add(Me.btnPendiente)
        Me.Controls.Add(Me.btnAutorizar)
        Me.Controls.Add(Me.LibXGridDetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.xlk_vend_code)
        Me.Controls.Add(Me.lkp_item_code)
        Me.Controls.Add(Me.btnCostos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ftfact01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Facturación"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_Condicion.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim mAutorizando As Boolean = False
    Dim mSerial As Integer
    Dim mPricemajor As Boolean
    Dim mPurchCost As Boolean
    Dim mStopVenct As Boolean
    Dim mStopAbono As Boolean
    Dim mRowIvSetup As DataRow
    Dim mFactNum As Integer
    Dim mTipoNCF As Inventario.Entidades.Documento.TipoNCFEnum
    Dim WhereStmt As String
    Dim WhDefault As Integer
    Dim PorcDescuento As Integer
    Dim oDocumento As SGT.Inventario.Entidades.Documento
    Dim mCli As SGT.Facturacion.Entidades.ParametroCliente
    Dim mConf As SGT.Inventario.Common.Configuration
    Dim oPermission As SGT.Administracion.Entidades.Permission
    Dim oProducto As SGT.Inventario.Entidades.Articulo
    Dim strValidUser As String
    Dim mValidUser As Boolean = False
    Dim mTipoDocumento As String

    Private Sub i_ftfact01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mConf = New SGT.Inventario.Common.Configuration
            oDoc = New SGT.Facturacion.Entidades.Documento

            mTipoDocumento = "FCT"

            oDocumento = New SGT.Inventario.Entidades.Documento(mTipoDocumento)
            oPermission = New SGT.Administracion.Entidades.Permission
            oProducto = New SGT.Inventario.Entidades.Articulo
            Dim Users As String()

            ftfactm.Columns("ftserial_no").AutoIncrement = False

            ftfactd.Columns("Importe").Expression = "(qty*price)-dscto+itbis"
            ftfactd.Columns("pricelist").ReadOnly = False
            ftfactd.Columns("pricemayor").ReadOnly = False
            ftfactd.Columns("priceminor").ReadOnly = False

            LibXGridDetalle.footerOperations.add("item_code", "count(item_code)")

            Users = Split(Configuration.ConfigurationSettings.AppSettings.Get("LibxAllowUser"), ",")

            For Each oUser As String In Users
                If LibX.User.UserID.ToLower.Trim = oUser.ToLower.Trim Then
                    mValidUser = True
                End If
            Next

            WhDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibXWhDefault").ToString)

            If Not LibXConnector1.Parameters Is Nothing Then
                If LibXConnector1.Parameters.Value.ToString.Length > 0 Then
                    WhereStmt = "ftfactm.ftserial_no = " & LibXConnector1.Parameters.Value.ToString
                    LibXConnector1.ExecuteFind(WhereStmt)
                End If
            End If

            lkp_item_code.CheckText = "Existencia mayor de 0"

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCli.Click
        Try
            Dim objForm As New i_ftcustm01

            If mCli Is Nothing Then
                mCli = New ParametroCliente
            End If

            mCli.Modalidad = LibXConnector1.State
            mCli.Company = Me.txtClinombre.Text
            mCli.Tel = LibXConnector1.CurrentDataRow!phone.ToString

            objForm.Cli = mCli

            objForm.ShowDialog()

            If Not objForm.ok Then
                mCli = Nothing
            Else
                lkCliente.Clear(True)
                txtCliCodigo.Enabled = False
                lkCliente.Enabled = False

                mCli.Company = objForm.Cli.Company
                Me.txtClinombre.Text = mCli.Company
                mCli.Contact = objForm.Cli.Contact
                mCli.Tel = objForm.Cli.Tel
                mCli.TelArea = objForm.Cli.TelArea
                mCli.Address = objForm.Cli.Address
                mCli.Mail = objForm.Cli.Mail
                mCli.Tel2 = objForm.Cli.Tel2
            End If
        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGridDetalle_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGridDetalle.CellValidate
        Try

            '// CANTIDAD
            If Me.GridColQty.Column = e.cell Then
                If IsNull(Me.gColitem_code.GetValue) Then
                    Exit Sub
                End If

                If IsNull(e.value) Then
                    e.hasErrors = True
                    Exit Sub
                End If

                Dim oRow As DataRow
                Dim sSql As String
                Dim iCod As String = gColitem_code.GetValue.ToString
                Dim IWhse_code As Integer = Val(Me.gColwhse_code.GetValue.ToString)

                sSql = String.Concat("Select * from ivitemd where item_code = '", Trim(iCod), "' and Whse_code = ", IWhse_code)
                oRow = LibX.Data.Manager.GetDataRow(sSql)

                If oRow Is Nothing Then
                    Throw New Exception("No se encuetra un registro en ivitemd")
                End If

                Dim Existe As Decimal = Val(oRow!existencia.ToString)

                Me.gColExist.SetValue(Existe)

                If e.value > Existe Then
                    Me.GridColQty.SetValue(Existe)
                    Throw New Exception("La cantidad no puede se mayor que la existencia")
                End If

                Dim Precio As Integer = 0
                Dim Qty As Integer = e.value

                If Trim(Me.LibXGridDetalle.GetValue(GColprice)) <> "" Then
                    Precio = Me.LibXGridDetalle.GetValue(GColprice)
                End If
            End If

            '// DESCUENTO
            If Me.gColdscto.Column = e.cell Then
                Dim descto As Decimal
                Dim Importe As Decimal

                descto = Val(e.value.ToString)
                Importe = Me.LibXGridDetalle.GetValue(GColprice) * Me.LibXGridDetalle.GetValue(GridColQty)

                If descto >= Importe Then
                    Me.gColdscto.SetValue(0)
                    Throw New ApplicationException("Descuento no puede ser mayor o igual que el importe")
                End If

                If descto > 0 Then
                    If mAutorizando = False Then
                        If oPermission.isAutorization(SGT.Administracion.Entidades.Permission.TipoAutorizacionEnum.Descuento) = False Then
                            Me.gColdscto.SetValue(0)
                            Throw New ApplicationException("Autorizción inválida!")
                        End If
                    End If

                    PorcDescuento = oPermission.PorcientoDescuento
                    If (descto / Importe) > (PorcDescuento / 100) Then
                        Me.gColdscto.SetValue(0)
                        Throw New ApplicationException("El descuento no puede exceder de un " & PorcDescuento.ToString.Trim & "%")
                    End If
                End If
            End If

            '// PRECIO
            If Me.LibXGridDetalle.GetColNum(GColprice) = e.cell Then
                If IsNull(Me.gColitem_code.GetValue) Then
                    Exit Sub
                End If
                If IsNull(e.value) Then
                    e.hasErrors = True
                    Exit Sub
                End If

                Dim Precio As Integer = e.value
                Dim Qty As Integer = 0

                If Trim(Me.GridColQty.GetValue) <> "" Then
                    qty = Me.GridColQty.GetValue
                End If

                '// SI ES DE CONTADO
                If Me.rdbContado.Checked Or Me.rdbPagoEntrega.Checked = True Then
                    '// SI A ESTE CLIENTE SE FACTURA AL POR MAYOR, ASIGNAR UN PRECIO MAYOR O IGUAL AL PRECIO AL POR MAYOR
                    If Me.mPricemajor Then
                        Dim precioPorMayor As Decimal = LibXGridDetalle.GetValue(gcolPriceMayor)   '- (oRow!price * (Me.mRowIvSetup!price_2 / 100))
                        If Precio < precioPorMayor Then
                            LibXGridDetalle.SetValue(GColprice, precioPorMayor)
                            Throw New Exception("El precio no debe ser menor que el precio por mayor")
                        End If
                    Else
                        'Válida que el precio no sea menor que el precio al por mayor
                        'precio al por mayor (ivitemd.price * (1 + (ivsetup.price_1/100) 
                        Dim precioMinimo As Decimal = LibXGridDetalle.GetValue(gColPriceMinor)
                        If Precio < precioMinimo Then
                            LibXGridDetalle.SetValue(GColprice, precioMinimo)
                            Throw New Exception("El precio no debe ser menor que el precio mínimo")
                        End If
                    End If
                Else
                    'Credito
                    If Me.mPricemajor Then
                        'Válida que el precio no sea menor que el precio minimo (ivitemd.price - (ivitemd.price * (ivsetup.price_2/100))
                        Dim precioPorMayor As Decimal = LibXGridDetalle.GetValue(gcolPriceMayor)
                        If Precio < precioPorMayor Then
                            LibXGridDetalle.SetValue(GColprice, precioPorMayor)
                            Throw New Exception("El precio no debe ser menor que el precio por mayor")
                        End If
                    Else
                        'valida que el precio no sea menor que el precio al por mayor (ivitemd.price * (1 + (ivsetup.price_1/100)
                        Dim precioMinimo As Decimal = LibXGridDetalle.GetValue(gColPriceMinor)
                        If Precio < precioMinimo Then
                            LibXGridDetalle.SetValue(GColprice, precioMinimo)
                            Throw New Exception("El precio no debe ser menor que el precio mínimo")
                        End If
                    End If
                End If
                'CalcularITBIS()

            End If

            '// CANTIDAD
            If Me.GridColQty.Column = e.cell Then
                If IsNull(Me.gColitem_code.GetValue) Then
                    Exit Sub
                End If
                'CalcularITBIS()

                LibXGridDetalle.SelectNextControl(Me.LibXGridDetalle, True, False, False, True)

                If e.row = Me.LibXGridDetalle.getCurrentGridView.Count - 1 Then
                    SendKeys.Send("{TAB}")
                End If
            End If


            If Me.gColdscto.Column = e.cell Then
                'CalcularITBIS()

            End If
        Catch ex As Exception
            e.hasErrors = True
            Log.Add(ex, True)

        Finally
            CalcularITBIS()
            ActualizaTotal()
        End Try
    End Sub

    Private Sub CalcularITBIS(Optional ByVal Index As Integer = -1)
        Dim Itbis As Decimal
        Dim Qty As Integer
        Dim Price As Decimal
        Dim Descto As Decimal

        Dim oParamItbis As SGT.Inventario.Entidades.Articulo.ParametrosCalcularItbis
        Try

            If Index = -1 Then
                Index = LibXGridDetalle.CurrentRowIndex
            End If

            If Val(LibXGridDetalle.GetValue(Index, Me.GridColQty)) <= 0 Then
                Exit Sub
            End If

            If Val(LibXGridDetalle.GetValue(Index, Me.GColprice)) <= 0 Then
                Exit Sub
            End If

            oParamItbis = New SGT.Inventario.Entidades.Articulo.ParametrosCalcularItbis

            Qty = Val(LibXGridDetalle.GetValue(Index, Me.GridColQty).ToString)
            Price = Val(LibXGridDetalle.GetValue(Index, Me.GColprice).ToString)
            Descto = Val(LibXGridDetalle.GetValue(Index, Me.gColdscto).ToString)

            With oParamItbis
                .Producto = LibXGridDetalle.Item(Index, 0)
                .Almacen = LibXGridDetalle.Item(Index, 1)
                .Monto = (Qty * Price) - Descto
            End With

            Itbis = oProducto.CalcularItbis(oParamItbis)

            LibXGridDetalle.SetValue(Index, Me.gColIbis, Itbis)

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

                '// CALCULAR ITBIS
                If LibXConnector1.IsDataEditing = True Then
                    If Me.LibXGridDetalle.GetValue(i, gColitem_code) <> "" Then
                        'CalcularITBIS(i)
                    End If
                End If

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

                'Me.LibXGridDetalle.SetValue(i, Me.gColImporte, (oCant * oPrice) - oDesc)

            Next

            Me.txtDec.Text = tDesc.ToString("###,###,##0.00")
            Me.txtTotal.Text = CDec(total - tDesc + Titb).ToString("###,###,##0.00")
            Me.txtITbis.Text = Titb.ToString("###,###,##0.00")
            Me.txtMontoBruto.Text = CDec(total).ToString("###,###,##0.00")

        Catch ex As Exception
            Log.Add(ex, True)
        End Try
    End Sub

    Private Sub lkp_item_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkp_item_code.AfterSetValues
        Dim WhereStmt As String
        Try

            If Not Me.LibXConnector1.IsEditing Then
                Exit Sub
            End If

            If e.dataFound = False Then
                Exit Sub
            End If

            txt_item_name.Text = e.row!item_name.ToString.Trim
            xtxt_priceList.Text = Format(Val(e.row!priceRD.ToString.Trim), "###,##0.00")
            xtxt_priceMajor.Text = Format(Val(e.row!pricemayor.ToString.Trim), "###,##0.00")
            xtxt_PriceMinor.Text = Format(Val(e.row!priceminor.ToString.Trim), "###,##0.00")

            '// si se vende al por mayor, especificar el precio minimo
            If cbo_price.Checked Then
                Dim pMinor As Decimal = 0

                pMinor = Val(e.row!priceminor.ToString.Trim)

                Me.LibXGridDetalle.SetValue(Me.GColprice, pMinor)
            End If

            '// si se vende al costo, especificar el costo
            If mPurchCost = True Then
                Dim pCost As Decimal = 0
                pCost = Val(e.row!purch_cost.ToString.Trim) * Val(e.row!Tasa.ToString.Trim)

                Me.LibXGridDetalle.SetValue(Me.GColprice, pCost)
            End If

            Me.LibXGridDetalle.SetValue(Me.gColCosto, Val(e.row!purch_cost.ToString.Trim) * Val(e.row!Tasa.ToString.Trim))

        Catch ex As Exception
            Log.Add(ex, True)
        End Try
    End Sub


    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Dim XUpdate As LibX.Data.XUpdateStmt
        Try

            '// si se esta actualizando verificar si es un peedido
            '// interno y actualizarlo a modificado
            If e.UpdatingArgs.StatementType = StatementType.Update Then

                If oDocumento.ExistePedido(e.UpdatingArgs.Row!fact_number) = True Then
                    XUpdate = New LibX.Data.XUpdateStmt("iventrdm")

                    XUpdate.FieldsSet("entr_status") = 3 'MODIFICADO
                    XUpdate.Fields("type_code") = "PDI"
                    XUpdate.Fields("entr_number") = e.UpdatingArgs.Row!fact_number

                    XUpdate.Execute()
                    XUpdate.Dispose()
                End If
            End If

            '// SI SE ESTA ACTUALIZANDO O INSERTANDO
            If e.UpdatingArgs.StatementType <> StatementType.Delete Then

                '// VOLVER A CALCULAR EL TOTAL GENERAL POR ULTIMA VEZ
                '// PARA EVITAR QUE SE QUEDE ALGUN VALOR FUERA
                'CalcularITBIS()
                'ActualizaTotal()

                '// SI NO SE ASIGNO FECHA ASIGNAR LA FECHA DEL DIA
                If LibX.IsNull(e.UpdatingArgs.Row!fact_date) Then
                    e.UpdatingArgs.Row!fact_date = LibX.Data.Manager.Connection.GetDate
                End If

                '// si se especificó un documento a credito y no se especificó cliente
                '// generar un mensaje de error
                If Me.rdbCredito.Checked = True Then
                    If LibX.IsNull(LibXConnector1.CurrentDataRow!cust_code) Then
                        Throw New ApplicationException("Debe esepcificar el código del cliente")
                    End If
                End If

                '// SI EL DOCUMENTO ES CONTADO EL TIPO DEBE SER 1
                '// DE LO CONTRARIO 2
                If Me.rdbContado.Checked Then
                    e.UpdatingArgs.Row!fact_cond = 1
                ElseIf Me.rdbPagoEntrega.Checked = True Then
                    e.UpdatingArgs.Row!fact_cond = 3
                Else
                    e.UpdatingArgs.Row!fact_cond = 2
                End If

                '// si es contado y se especificó un cliente de contado
                '// ACTUALIZAR ESTA INFORMACIóN
                If Me.rdbContado.Checked Or Me.rdbPagoEntrega.Checked Then
                    '--> si es contado debe registrar toda la inf
                    If Not mCli Is Nothing Then
                        mCli.Contact = Me.txtClinombre.Text
                        If Trim(mCli.Contact) = "" Then
                            Throw New Exception("Debe completar la información del cliente")
                        End If

                        If Trim(mCli.Company) = "" Then
                            Throw New Exception("Debe completar la información del cliente")
                        End If

                        e.UpdatingArgs.Row!phone = mCli.Tel
                    End If
                End If
            End If


            '// SI SE ESTA INSERTANDO ASIGNAR EL TIPO DE DOCUMENTO
            '// GENERAR EL NUMERO DEL DOCUMENTO
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                Dim intLast As Object
                Dim sSql As String

                e.UpdatingArgs.Row!type_code = mTipoDocumento

                If mTipoNCF = Inventario.Entidades.Documento.TipoNCFEnum.None Then
                    e.UpdatingArgs.Row!fact_number = oDocumento.GenerateNumber("FCN", WhDefault)
                Else
                    e.UpdatingArgs.Row!fact_number = oDocumento.GenerateNumber(mTipoDocumento, WhDefault)
                End If

                ''// GENERAR UN NCF
                'e.UpdatingArgs.Row!fact_ncf = oDocumento.GenerateNCF(mTipoDocumento, e.UpdatingArgs.Row!whse_code, mTipoNCF)
            End If

            '// SI SE ESTA BORRANDO Y EL ESTATUS ES COBRADA, ANULAR EL DOCUMENTO, NO BORRARLO
            If e.UpdatingArgs.StatementType = StatementType.Delete Then
                If e.UpdatingArgs.Row.Item("fact_status", DataRowVersion.Original) = 3 Then '//cobrada
                    e.UpdatingArgs.Status = UpdateStatus.SkipAllRemainingRows
                    AnularDocumento(e.UpdatingArgs.Row)
                End If
            End If

        Catch ex As Exception
            Log.Add(ex, True)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred

        End Try
    End Sub

    Private Sub AnularDocumento(ByVal oRow As DataRow)
        Dim oPost As SGT.Facturacion.Operaciones.PosteoDocumento
        Dim oParam As SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

        Try
            oPost = New SGT.Facturacion.Operaciones.PosteoDocumento
            oParam = New SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

            With oParam
                .SerialNumero = oRow.Item("ftserial_no", DataRowVersion.Original)
                .ApliarComision = True
                .AplicarCXC = True
                .AplicarInventario = True
                .Completo = True
                .UseTransaction = False
            End With

            oPost.Anular(oParam)

        Catch ex As Exception
            LibX.Log.Add(ex, True)

        End Try
    End Sub

    Private Sub AplicarInventario(ByVal pftserial_no As Integer)
        Dim oPostDoc As SGT.Facturacion.Operaciones.PosteoDocumento
        Dim oPostParam As SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

        Try

            oPostDoc = New SGT.Facturacion.Operaciones.PosteoDocumento
            oPostParam = New SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

            oPostParam.SerialNumero = pftserial_no  'LibXConnector1.CurrentDataRow!ftserial_no
            oPostParam.UseTransaction = True
            oPostParam.AplicarInventario = True
            oPostParam.AplicarCXC = False
            oPostParam.ApliarComision = True

            oPostDoc.Aplicar(oPostParam)

        Catch ex As Exception
            Log.Add(ex, True)
        End Try

    End Sub

    Private Sub LibXConnector1_InsertedRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedRow
        Try

            'If e.UpdatingArgs.StatementType = StatementType.Update Then
            mSerial = e.Serial
            If Not mCli Is Nothing And (Me.rdbContado.Checked Or Me.rdbPagoEntrega.Checked) Then
                If mCli.Company.ToString.Length <= 0 Then
                    Exit Sub
                End If

                If mCli.Tel.ToString.Length <= 0 Then
                    Exit Sub
                End If

                If mCli.Modalidad = LibxConnectorState.Edit Then
                    Dim oS As LibX.Data.XUpdateStmt
                    oS = New LibX.Data.XUpdateStmt("ftcustm")

                    os.FieldsSet("address") = mCli.Address
                    os.FieldsSet("email") = mCli.Mail
                    os.FieldsSet("Phone1") = mCli.Tel2
                    oS.FieldsSet("cust_name") = mCli.Contact
                    oS.FieldsSet("company_name") = mCli.Company
                    oS.FieldsSet("area_code") = mCli.TelArea
                    oS.Fields("phone") = mCli.Tel

                    oS.Execute()
                End If

                If mCli.Modalidad = LibxConnectorState.Insert Then
                    If mCli.Found = False Then
                        Dim oS As LibX.Data.XInsertStmt
                        oS = New LibX.Data.XInsertStmt("ftcustm")
                        oS!cust_name = mCli.Contact
                        oS!company_name = mCli.Company
                        oS!area_code = mCli.TelArea
                        oS!phone = mCli.Tel
                        oS!phone1 = mCli.Tel2
                        oS!email = mCli.Mail
                        oS!address = mCli.Address

                        oS.Execute()
                        os.Dispose()
                    Else
                        Dim oS As LibX.Data.XUpdateStmt
                        oS = New LibX.Data.XUpdateStmt("ftcustm")

                        oS.FieldsSet("cust_name") = mCli.Contact
                        oS.FieldsSet("company_name") = mCli.Company
                        oS.FieldsSet("area_code") = mCli.TelArea
                        oS.FieldsSet("phone1") = mCli.Tel2
                        oS.FieldsSet("email") = mCli.Mail
                        oS.FieldsSet("address") = mCli.Address
                        oS.Fields("phone") = mCli.Tel

                        oS.Execute()
                        os.Dispose()
                    End If
                End If
            End If

        Catch ex As Exception
            Log.Add(ex, True)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
        End Try
    End Sub

    Private Function ValidaLimite() As Boolean
        Dim LimiteDisp As Double
        Dim Limite, dBalance As Double
        Dim Total As Double
        Try
            If txtTotal.Text.Length > 0 Then
                Total = txtTotal.Text
            Else
                Total = 0
            End If

            If Credit_Limit.Text.Length > 0 Then
                Limite = Credit_Limit.Text
            Else
                Limite = 0
            End If

            If balance.Text.Length > 0 Then
                dBalance = balance.Text
            Else
                dBalance = 0
            End If

            If Total <= 0 Then
                Return False
            End If

            If Limite <= 0 AndAlso LibXConnector1.CurrentDataRow!fact_cond.ToString.Trim = "2" Then
                Throw New ApplicationException("NO se ha establecido un límite de crédito para este cliente")
            End If

            LimiteDisp = Limite - dBalance

            If LimiteDisp <= 0 Then
                Throw New ApplicationException("Este cliente no tiene crédito disponible, Límite de crédito agotado")
            End If

            If Total > LimiteDisp Then
                If MessageBox.Show("Esta factura excede el limite de credito disponible de este cliente" & _
                    vbCrLf & "Su crédito disponible es de " & Format(LimiteDisp, "###,###.##") & _
                    vbCrLf & "Desea continuar?", _
                    "Excede Límite de Crédito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return False
                End If
            End If

            Return True

        Catch ex As Exception
            LibX.Log.Show(ex)
            Return False

        End Try
    End Function

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            If Not LibXConnector1.CurrentDataRow Is Nothing Then
                If (e.AcceptedAction = LibxConnectionActions.Add OrElse _
                e.AcceptedAction = LibxConnectionActions.Edit) _
                AndAlso LibXConnector1.CurrentDataRow!fact_cond.ToString.Trim = "2" Then
                    If ValidaLimite() = False Then
                        e.Handled = True
                        Exit Sub
                    End If
                End If
            End If

            If e.Action = LibxConnectionActions.Cancel Then
                txtTotal.Text = ""
                balance.Text = ""
                vencido.Text = ""
                Credit_Limit.Text = ""
            End If

            If e.Action = LibxConnectionActions.Edit Then
                If LibXConnector1.CurrentDataRow!fact_status.ToString.Trim <> "1" _
                And LibXConnector1.CurrentDataRow!fact_status.ToString.Trim <> "4" Then
                    e.Handled = True
                    Throw New ApplicationException("Este documento no puede ser modificado!")
                End If

                If HasSerie(LibXConnector1.CurrentDataRow!ftserial_no) = True Then
                    e.Handled = True
                    Throw New ApplicationException("Este documento no puede ser modificado, ya fue serializado!")
                End If
            End If

            '''If e.Action = LibxConnectionActions.Delete Then
            '''    If LibXConnector1.CurrentDataRow!fact_status <> 1 Then
            '''        e.Handled = True
            '''        Throw New ApplicationException("Este documento no puede ser Eliminado!")
            '''    End If
            '''End If

            If e.Action = LibxConnectionActions.Add Or e.Action = LibxConnectionActions.Edit Then
                If mRowIvSetup Is Nothing Then
                    mRowIvSetup = LibX.Data.Manager.GetDataRow("Select * from ivsetup")
                    If mRowIvSetup Is Nothing Then
                        Throw New Exception("No se encuentra la configuración de inventario")
                    End If
                End If
            End If

            If e.Action = LibxConnectionActions.Find Then
                rdbContado.Checked = False
                rdbCredito.Checked = False
                rdbPagoEntrega.Checked = False
            End If

            If e.AcceptedAction = LibxConnectionActions.Add Or e.AcceptedAction = LibxConnectionActions.Edit Then
                ActualizaTotal()
            End If

            If e.Action = LibxConnectionActions.Add Then
                Dim oTipoNCF As New frmTipo
                If oTipoNCF.ShowDialog = DialogResult.OK Then
                    mTipoNCF = oTipoNCF.TipoNCF
                Else
                    Throw New ApplicationException("No selecciono el tipo de NCF!!!")
                End If

                oTipoNCF = Nothing
            End If
            ''If e.Action = LibxConnectionActions.Edit AndAlso lbx_fact_status.currValue <> 4 Then
            ''    IniciarPendiente()
            ''End If

        Catch ex As Exception
            e.Handled = True
            Log.Add(ex, True)

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

            balance.Text = Format(Val(e.row!balance.ToString), "###,###,###.00")
            vencido.Text = Format(Val(e.row!vencido.ToString), "###,###,###.00")

            '// SI NO ES UN DOCUMENTO PENDIENTE DE AUTORIZACION
            If mAutorizando = False Then

                '// SI TIENE EL INDICADOR DE SUSPENDER VENTA A CREDITO POR MONTO VENCIDO
                '// ACTIVADO Y TIENE MONTO VENCIDO, FACTURAR COMO UN DOCUMENTO PENDIENTE DE AUTORIZAR
                If e.row!stop_venct.ToString.Trim = "1" _
                AndAlso Val(e.row!vencido.ToString.Trim) > 0 _
                AndAlso rdbCredito.Checked = True Then
                    Dim Mensaje As String = "Este Cliente tiene la venta a crédito suspendidas por que tiene " & vbCrLf & _
                                            "facturas vencidas pendientes de pago." & vbCrLf & _
                                            "Desea autorizar esta venta?"

                    If MessageBox.Show(Mensaje, "Venta Suspendida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        If oPermission.isAutorization(SGT.Administracion.Entidades.Permission.TipoAutorizacionEnum.VentasVencimiento) = False Then
                            Throw New ApplicationException("Autorizción inválida!")
                        End If
                    Else
                        Throw New ApplicationException("No se puede realizar esta venta")
                    End If
                    'vencido.BackColor = System.Drawing.Color.Red
                End If

                '// SI EL CLIENTE ESTA EN ESTATUS SUSPENDIDO, CREAR DOCUMENTO PENDIENTE DE AUTORIZACION
                If e.row!cust_status.ToString.Trim = "2" Then
                    Dim Mensaje As String = "Este Cliente tiene la venta a crédito suspendidas!" & vbCrLf & _
                                            "Desea autorizar esta venta?"

                    If MessageBox.Show(Mensaje, "Venta Suspendida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        If oPermission.isAutorization(SGT.Administracion.Entidades.Permission.TipoAutorizacionEnum.VentasVencimiento) = False Then
                            Throw New ApplicationException("Autorizción inválida!")
                        End If
                    Else
                        Throw New ApplicationException("No se puede realizar esta venta")
                    End If
                    'vencido.BackColor = System.Drawing.Color.Red
                End If
            End If

            LibXConnector1.CurrentDataRow!term_code = e.row!term_code

            If rdbContado.Checked = True Or rdbPagoEntrega.Checked = True Then
                Disc_pct.Text = ""
                Due_days.Text = ""
                Disc_days.Text = ""
            Else
                Disc_pct.Text = e.row!Disc_pct.ToString.Trim
                Due_days.Text = e.row!Due_days.ToString.Trim
                Disc_days.Text = e.row!Disc_days.ToString.Trim
            End If

            '// SI SE FACTURA AL POR MAYOR
            If e.row!cust_pricemajor.ToString.Trim = "1" Then
                mPricemajor = True
                cbo_price.Checked = True
                cbo_price.Refresh()
            Else
                If mPricemajor = True Then
                    ResetPrice()
                End If

                mPricemajor = False
                cbo_price.Checked = False
                cbo_price.Refresh()
            End If

            '// SI A ESTE CLIENTE SE LE FACTURA AL COSTO
            If e.row!cust_costo.ToString.Trim = "1" Then
                mPurchCost = True
            Else
                mPurchCost = False
            End If

            Me.chk_costo.Checked = mPurchCost
            Me.GColprice.ReadOnly = mPurchCost
            'Me.gColdscto.ReadOnly = mPurchCost

            'If txtClinombre.Text.Length <= 0 Then
            txtClinombre.Text = e.row!cust_name.ToString.Trim
            txtClinombre.Enabled = False
            btnCli.Enabled = False
            mCli = Nothing
            'End If

        Catch ex As Exception
            Log.Add(ex, True)
            txtCliCodigo.Text = ""
            lkCliente.ExecuteFind()
        End Try
    End Sub

    Private Sub ResetPrice()
        Try

            For Each orow As DataRow In ftfactd.Rows
                orow!price = orow!pricelist
            Next

            LibXGridDetalle.Refresh()
            ActualizaTotal()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub lkCliente_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lkCliente.BeforeExecuteQuery
        Try
            e.aditionalWhere = "cccustv1.cust_status <> 0 "
        Catch ex As Exception
            Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try

            e.row!whse_code = WhDefault

        Catch ex As Exception
            Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Dim SelecStmt As String
        Dim AxCrystalReport1 As LibX.ReportLib
        Try
            Me.Cursor = Cursors.WaitCursor
            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then

                '''// Tomar el Connection String del config
                ''If LibXConnector1.CurrentDataRow!fact_cond.ToString.Trim = "2" _
                ''And XTextBoxNCF.Text.Trim = "" Then
                ''    Dim XUpdate As LibX.Data.XUpdateStmt
                ''    Dim NCF As String

                ''    NCF = oDocumento.GenerateNCF(mTipoDocumento, WhDefault, Inventario.Entidades.Documento.TipoNCFEnum.ConValorFiscal)

                ''    XTextBoxNCF.Text = NCF
                ''    XUpdate = New LibX.Data.XUpdateStmt("ftfactm")
                ''    XUpdate.FieldsSet("fact_ncf") = NCF
                ''    XUpdate.Fields("ftserial_no") = LibXConnector1.CurrentDataRow!ftserial_no
                ''    XUpdate.Execute()

                ''    XUpdate = Nothing
                ''End If

                AxCrystalReport1 = New LibX.ReportLib(mTipoDocumento, "r_ftfact01.rpt")

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
            If LibXConnector1.Parameters Is Nothing OrElse _
                LibXConnector1.Parameters.Value.ToString.Length <= 0 Then
                e.AditionalWhere = "ftfactm.type_code = 'FCT' and ftfactm.whse_code = " & WhDefault.ToString
            Else
                e.AditionalWhere = "ftfactm.type_code = 'FCT' "
            End If

            WhereStmt = e.Where

            If Not e.Sql Is Nothing Then
                e.Sql = oDoc.PrepareSelectStmt(e.Sql)
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)

        End Try

    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibX.LibxConnectionActions.Add Then
                mCli = Nothing
                mPurchCost = False
                mPricemajor = False
                mStopVenct = False
                mStopAbono = False
                cbo_price.Checked = False
                txtvend_code.ReadOnly = False
                xlk_vend_code.Enabled = True

                Me.rdbContado.Checked = True
                txtfact_number.ReadOnly = True
                txtCliCodigo.Enabled = True
                txtClinombre.Enabled = True
                btnCli.Enabled = True

                lbx_fact_status.currValue = 1
                LibXConnector1.CurrentDataRow!fact_cond = 1 '// cONTADO
                LibXConnector1.CurrentDataRow!fact_date = LibX.Data.Manager.Connection.GetDate
                LibxDateTimePicker1.Value = LibX.Data.Manager.Connection.GetDate
                LibXConnector1.CurrentDataRow!TYPE_CODE = mTipoDocumento
                txtTotal.Text = ""

                If LibX.User.VendedorID > 0 Then
                    txtvend_code.Text = LibX.User.VendedorID
                    xlk_vend_code.ExecuteFind()
                End If

            End If

            If e.Action = LibxConnectionActions.Find Then
                txtvend_code.Text = LibX.User.VendedorID
                txtfact_number.ReadOnly = False

                If mValidUser = False Then
                    txtvend_code.ReadOnly = True
                    xlk_vend_code.Enabled = False
                    xlk_vend_code.ExecuteFind()
                End If
                txtTotal.Text = ""
            End If

            If e.AcceptedAction = LibxConnectionActions.Add Then
                If mTipoNCF <> Inventario.Entidades.Documento.TipoNCFEnum.None Then 'Contado
                    Dim XUpdate As LibX.Data.XUpdateStmt
                    Dim NCF As String

                    NCF = oDocumento.GenerateNCF(mTipoDocumento, WhDefault, mTipoNCF)

                    XUpdate = New LibX.Data.XUpdateStmt("ftfactm")
                    XUpdate.FieldsSet("fact_ncf") = NCF
                    XUpdate.Fields("ftserial_no") = LibXConnector1.CurrentDataRow!ftserial_no
                    XUpdate.Execute()

                    XUpdate = Nothing
                End If

                If TieneSerie() = False AndAlso lbx_fact_status.currValue <> 4 Then
                    AplicarInventario(LibXConnector1.CurrentDataRow!ftserial_no)
                End If

                FinalizarAutorizacion()
                ftfactd.Rows.Clear()
                ftfactm.Rows.Clear()
                LibXNavigator1.UpdateState()

                txtTotal.Text = ""
                balance.Text = ""
                Credit_Limit.Text = ""
                cust_name.Text = ""
                btnPendiente.ForeColor = System.Drawing.Color.Black
            End If

            If e.AcceptedAction = LibxConnectionActions.Find _
            Or e.Action = LibxConnectionActions.MoveFirst _
            Or e.Action = LibxConnectionActions.MoveLast _
            Or e.Action = LibxConnectionActions.MoveNext _
            Or e.Action = LibxConnectionActions.MovePrev Then
                'LibxDateTimePicker1.Value = LibXConnector1.CurrentDataRow!fact_date
            End If



        Catch ex As Exception
            e.Handled = True
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub lkp_item_code_CreatedGridColumns(ByVal sender As Object, ByVal e As LibX.CreatedGridColumnsEventArgs) Handles lkp_item_code.CreatedGridColumns
        Try
            'e.TStyle.GridColumnStyles.Item("item_name").Width = 450

            'e.Grid.Parent.Width = e.Grid.Parent.Width + 300

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub rdbCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCredito.CheckedChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                txtClinombre.Enabled = False
                btnCli.Enabled = False
                txtClinombre.Text = ""

                lkCliente.Clear(True)
                txtCliCodigo.Enabled = True
                lkCliente.Enabled = True
                balance.Text = ""
                vencido.Text = ""
            End If

            If LibXConnector1.IsEditing Then
                LibXConnector1.CurrentDataRow!fact_cond = 2
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub rdbContado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbContado.CheckedChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                txtClinombre.Enabled = True
                btnCli.Enabled = True
                txtClinombre.Text = ""

            End If

            If LibXConnector1.IsEditing Then
                LibXConnector1.CurrentDataRow!fact_cond = 1
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try
            gbx_Condicion.Enabled = e.isEditing
            btnCli.Enabled = (e.isEditing Or LibXConnector1.HasRecords = True)
            btnAutorizar.Enabled = (e.isDataEditing)
            btnPendiente.Enabled = (e.isDataEditing)
            btnCostos.Enabled = (e.isEditing Or LibXConnector1.HasRecords = True)
            mnuCostos.Enabled = (e.isEditing Or LibXConnector1.HasRecords = True)

            If Not LibX.User.UserID Is Nothing Then
                btnComision.Enabled = (e.isEditing = False And LibXConnector1.HasRecords = True And mValidUser = True)
            Else
                btnComision.Enabled = False
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
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

            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)

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
            LibX.Log.Add(ex, True)

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

    Private Sub LibXConnector1_RowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange
        Try
            If Not LibXConnector1.CurrentDataRow Is Nothing Then
                If LibXConnector1.CurrentDataRow!fact_cond = 1 Then '// Contado
                    rdbContado.Checked = True
                End If

                If LibXConnector1.CurrentDataRow!fact_cond = 2 Then '// Credito
                    rdbCredito.Checked = True
                End If

                If LibXConnector1.CurrentDataRow!fact_cond = 3 Then '// Credito
                    rdbPagoEntrega.Checked = True
                End If
            End If

            If LibXConnector1.CurrentAction = LibxConnectionActions.None Then
                LibxDateTimePicker1.Value = LibXConnector1.CurrentDataRow!fact_date
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
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

    Private Sub LibXLookup1_AfterSetValues(ByVal sender As System.Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_afect_serial.AfterSetValues
        Try

            If e.dataFound = False Then
                Exit Sub
            End If

            txtCliCodigo.Text = e.row!cust_code.ToString
            txtClinombre.Text = e.row!cust_name.ToString
            lkCliente.ExecuteFind()

            LoadProducts()

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LoadProducts()
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim oRow1 As DataRow
        Dim Qty As Integer
        Dim oProducto As SGT.Inventario.Entidades.Articulo
        Dim Productos() As String = {""}
        Dim Producto As String
        Try

            oProducto = New SGT.Inventario.Entidades.Articulo

            SelectStmt = "select ftcotizd.*,ivitemv1.item_name,pricerd,pricemayor,priceminor from ftcotizd " & _
                         " inner join ivitemv1 on ivitemv1.item_code = ftcotizd.item_code " & _
                         " and ivitemv1.whse_code = ftcotizd.whse_code " & _
                         " where cotiz_serial = " & txtcotiz_serial.Text

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Throw New ApplicationException("Error buscando productos de la cotización")
            End If

            If oTable.Rows.Count < 0 Then
                Throw New ApplicationException("Esta cotización no tiene productos")
            End If

            ftfactd.Rows.Clear()
            For Each oRow As DataRow In oTable.Rows
                Qty = ValidarExistencia(Val(oRow!qty.ToString), oRow!item_code.ToString, Val(oRow!whse_code.ToString))
                oRow1 = ftfactd.NewRow

                If Val(oRow!Qty.ToString) > Qty Then
                    oRow1!Qty = Qty
                Else
                    oRow1!QTY = oRow!Qty
                End If

                oRow1!item_code = oRow!item_code
                oRow1!item_name = oRow!item_name
                oRow1!unit_code = oRow!UNIT_CODE
                oRow1!whse_code = oRow!whse_code

                oRow1!price = oRow!price
                oRow1!dscto = 0 'oRow!dscto
                oRow1!itbis = oRow!itbis
                oRow1!costo = oProducto.GetCostoRD(oRow!item_code.ToString, Val(oRow!whse_code.ToString))
                oRow1!pricerd = oRow!pricerd
                oRow1!pricelist = oRow!pricerd
                oRow1!pricemayor = oRow!pricemayor
                oRow1!priceminor = oRow!priceminor

                If Val(oRow1!QTY.ToString) > 0 Then
                    ftfactd.Rows.Add(oRow1)
                Else
                    ReDim Preserve Productos(Productos.Length)
                    Productos(Productos.Length - 1) = (Productos.Length - 1).ToString & ") " & _
                                                      oRow!item_name.ToString.Trim & ", Quedan " & _
                                                      Qty.ToString & ", Cotizaron " & oRow!Qty.ToString

                    'MessageBox.Show("No hay existencia para el producto " & oRow!item_name.ToString, "No hay existencia", MessageBoxButtons.OK)
                End If
                'lkp_item_code.ExecuteFind()
            Next

            If Productos.Length > 1 OrElse Productos(0).Trim <> "" Then
                Producto = Join(Productos, vbCrLf)
                MessageBox.Show(Producto, "Productos sin existencia")
            End If

            ActualizaTotal()

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCostos.Click, mnuCostos.Click
        Try
            If mAutorizando = False Then
                If oPermission.isAutorization(SGT.Administracion.Entidades.Permission.TipoAutorizacionEnum.VerCostos) = False Then
                    Throw New ApplicationException("Autorizción inválida!")
                End If
            End If

            If LibXGridDetalle.CurrentRowIndex <= -1 Then
                Throw New ApplicationException("Parece no haber producto seleccionado!")
            End If

            If LibXGridDetalle.Item(LibXGridDetalle.CurrentRowIndex, 0).ToString.Trim = "" Then
                Throw New ApplicationException("Debe seleccionar un producto!")
            End If

            Dim param As New LibX.LibxPrgParams
            param.WhereToExecute = "ivitemd.item_code = '" & LibXGridDetalle.Item(LibXGridDetalle.CurrentRowIndex, 0).ToString.Trim & "'"
            param.AllowDelete = False
            param.AllowEdit = False
            param.AllowNew = False
            param.AllowQuery = False

            LibX.App.CurrentPrgParams = param
            LibX.LibXRunner.Run("i_ivitem02", "INV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutorizar.Click
        Try
            If btnAutorizar.ForeColor.Equals(System.Drawing.Color.Red) Then
                FinalizarAutorizacion()
            Else
                IniciarAutorizacion()
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub
    Private Sub FinalizarAutorizacion()
        mAutorizando = False
        btnAutorizar.ForeColor = System.Drawing.Color.Black
        btnAutorizar.Text = "Autorización Desactivada"
    End Sub
    Private Sub IniciarAutorizacion()
        Try
            If oPermission.isAutorization(SGT.Administracion.Entidades.Permission.TipoAutorizacionEnum.Todas) = False Then
                Throw New ApplicationException("Autorizción inválida!")
            End If

            mAutorizando = True
            btnAutorizar.ForeColor = System.Drawing.Color.Red
            btnAutorizar.Text = "Autorización Activada ..."
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Function ValidarExistencia(ByVal Qty As Integer, ByVal ItemCode As String, ByVal wh As Integer) As Integer
        Dim sSQL As String
        Dim oRow As DataRow
        Try
            sSQL = String.Concat("Select * from ivitemd where item_code = '", Trim(ItemCode), "' and Whse_code = ", wh.ToString)
            oRow = LibX.Data.Manager.GetDataRow(sSQL)

            If oRow Is Nothing Then
                'que mensaje?
                Throw New Exception("No se encuetra un registro en ivitemd")
            End If

            Dim Existe As Decimal = Val(oRow!existencia.ToString)

            Return Existe

        Catch ex As Exception
            LibX.Log.Show(ex)
            Return -1

        End Try
    End Function


    Private Sub txtClinombre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClinombre.Leave
        Try

            If LibXConnector1.IsDataEditing = False Then
                Exit Sub
            End If

            txtCliCodigo.Enabled = Not (txtClinombre.Text.Length > 0)
            lkCliente.Enabled = Not (txtClinombre.Text.Length > 0)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Function HasSerie(ByVal pftserial_no As Integer) As Boolean
        Dim SelectStmt As String
        Dim Xselect As LibX.Data.XSelecStmt
        Dim iCnt As Integer
        Dim oTable As DataTable

        Try
            SelectStmt = "select count(*) from ivseriem " & _
                         " where  ftserial_no = " & pftserial_no.ToString

            Xselect = New LibX.Data.XSelecStmt("ivseriem", SelectStmt)

            iCnt = Xselect.GetScalar

            If iCnt > 0 Then
                Return True
            End If

            Return False

        Catch ex As Exception
            LibX.Log.Show(ex)
            Return False
        End Try
    End Function

    Private Sub cbo_price_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_price.CheckedChanged
        Try
            If LibXConnector1.IsDataEditing = True AndAlso cbo_price.Checked = True And mPricemajor = False Then
                If oPermission.isAutorization(SGT.Administracion.Entidades.Permission.TipoAutorizacionEnum.Todas) = False Then
                    Me.mPricemajor = False
                    cbo_price.Checked = False
                    Throw New ApplicationException("Autorizción inválida!")
                Else
                    Me.mPricemajor = True
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If Not LibXConnector1.CurrentDataRow Is Nothing Then
                If Not LibX.IsNull(LibXConnector1.CurrentDataRow!fact_date) Then
                    LibxDateTimePicker1.Value = LibXConnector1.CurrentDataRow!fact_date
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub lkp_item_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lkp_item_code.BeforeExecuteQuery
        e.aditionalWhere = "whse_code = " & WhDefault.ToString

    End Sub

    Private Sub btnPendiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPendiente.Click
        Try
            IniciarPendiente()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Function IniciarPendiente() As Boolean
        If MessageBox.Show("Este documento será puesto pendiente de autorización" & vbCrLf & _
                           "No podrá ser cobrado, ni despachado hasta tanto pase" & vbCrLf & _
                           "por Autorización" & vbCrLf & vbCrLf & _
                           "Desea contiar?", "Pendiente de Autorización", MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

            lbx_fact_status.currValue = 4
            mAutorizando = True
            btnPendiente.ForeColor = System.Drawing.Color.Red
            Return True
        End If

        Return False
    End Function

    Private Sub XTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XTextBox1.TextChanged

    End Sub

    Private Sub LibXLookup1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xlk_afect_serial.Load

    End Sub

    Private Sub xlk_afect_serial_CreatedGridColumns(ByVal sender As Object, ByVal e As LibX.CreatedGridColumnsEventArgs) Handles xlk_afect_serial.CreatedGridColumns
        Try
            'e.TStyle.GridColumnStyles.Item("cust_name").Width = 450

            'e.Grid.Parent.Width = e.Grid.Parent.Width + 300

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub


    Private Sub lkp_item_code_CheckedChanged(ByVal sender As Object, ByVal e As LibX.CheckedChangedEventArgs) Handles lkp_item_code.CheckedChanged
        Try
            If e.CheckStatus = True Then
                e.Table.DefaultView.RowFilter = ("existencia > 0")
            Else
                e.Table.DefaultView.RowFilter = ("")
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXGridDetalle_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles LibXGridDetalle.Navigate

    End Sub

    Private Sub LibXGridDetalle_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LibXGridDetalle.LostFocus
    End Sub

    Private Sub LibXConnector1_InsertingDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingDetailRow
        If e.UpdatingArgs.StatementType = StatementType.Insert _
        Or e.UpdatingArgs.StatementType = StatementType.Update Then
            If LibX.IsNull(e.UpdatingArgs.Row!item_code) Then
                e.UpdatingArgs.Row.AcceptChanges()
            End If
        End If
    End Sub

    Private Sub xlk_vend_code_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xlk_vend_code.Load

    End Sub

    Private Sub xlk_vend_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_vend_code.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.IsDataEditing = True Then
                LibXConnector1.CurrentDataRow!porc_comision = e.row!porc_comision
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComision.Click
        Dim oCambio As New i_ftfact01a

        oCambio.Serial = LibXConnector1.CurrentDataRow!ftserial_no
        If oCambio.ShowDialog() = DialogResult.OK Then
            MessageBox.Show("% de Comisión actualizado")
        End If
    End Sub

    Private Sub lkCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkCliente.Load

    End Sub

    Private Sub chk_costo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_costo.CheckedChanged
        Try
            If LibXConnector1.IsDataEditing = True And chk_costo.Checked = False And Me.mPurchCost = False Then
                If oPermission.isAutorization(SGT.Administracion.Entidades.Permission.TipoAutorizacionEnum.VerCostos) = False Then
                    Me.mPurchCost = False
                    chk_costo.Checked = False
                    Throw New ApplicationException("Autorizción inválida!")
                Else
                    Me.mPurchCost = True
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXGridDetalle_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGridDetalle.CurrentRowChanged

    End Sub

    Private Sub LibXGridDetalle_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LibXGridDetalle.Validating

    End Sub

    Private Sub LibXGridDetalle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LibXGridDetalle.KeyPress

    End Sub

    Private Sub ftfactd_RowDeleting(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles ftfactd.RowDeleting

    End Sub

    Private Sub ftfactd_RowDeleted(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles ftfactd.RowDeleted
        Try
            If e.Action = DataRowAction.Delete Then
                ActualizaTotal()
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub rdbPagoEntrega_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPagoEntrega.CheckedChanged
        Try
            If LibXConnector1.IsEditing Then
                LibXConnector1.CurrentDataRow!fact_cond = 3
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub
End Class


