Imports SGT.Inventario
Imports SGT.Inventario.Entidades
Imports SGT.CXC.Posteos
Imports SGT.Caja.Entidades
Imports SGT.Contabilidad.Entidades
Imports LibX
Imports SGT.PuntodeVenta.Entidades
Imports SGT.Facturacion.Entidades
Imports Microsoft.Office.Interop

Public Class i_ccpaym02
    Inherits System.Windows.Forms.Form
    Dim oDocument As SGT.Inventario.Entidades.Documento
    Dim oSdocumento As SGT.Contabilidad.Entidades.Documentos
    Dim oTransacion As SGT.ControlBancario.Entidades.TipoDocumento
    Dim mResta As Decimal
    Dim Accion As Integer
    Dim Porc_mora As Decimal
    Dim WhDefault As Integer
    Dim SCDefault As Integer
    Dim MontoDigitado As Boolean
    Dim oCaja As Caja
    Dim oCajera As Cajera
    Dim oCajaAbierta As CajaAbierta
    Dim mTipoDocumento As String = "RCB"
    Dim mDigitado As Boolean = False
    Dim mDigiterm As Boolean = False
    Dim mRemoverDesc As Boolean = False
    Dim oParamValidar As SGT.Administracion.Entidades.Permission.ParametrosValidar
    Dim oAutorizar As SGT.Administracion.Entidades.Permission
    Dim oTermino As SGT.CXC.Entidades.Termino
    Dim oNCF As i_ftfact04
    Dim ofctDocumento As SGT.Facturacion.Entidades.Documento
    Dim oBoton As Integer
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
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents balance As LibX.XTextBox
    Friend WithEvents xlk_cust_code As LibX.LibXLookup
    Friend WithEvents xdtp_paym_date As LibX.LibxDateTimePicker
    Friend WithEvents xcbo_paym_status As LibX.LibXCombo
    Friend WithEvents gColAplAmount As LibX.XEditTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gColAmount As LibX.XEditTextBoxColumn
    Friend WithEvents gColBalance As LibX.XEditTextBoxColumn
    Friend WithEvents txtPaym_number As LibX.XTextBox
    Friend WithEvents xed_Tipo As LibX.XEditTextBoxColumn
    Friend WithEvents xed_number As LibX.XEditTextBoxColumn
    Friend WithEvents btnPagos As System.Windows.Forms.Button
    Friend WithEvents gColItbis As LibX.XEditTextBoxColumn
    Friend WithEvents btnVisualizar As System.Windows.Forms.Button
    Friend WithEvents gColDescto1 As LibX.XEditTextBoxColumn
    Friend WithEvents btnDistribucion As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnCheque As System.Windows.Forms.Button
    Friend WithEvents gColtotal_amount As LibX.XEditTextBoxColumn
    Friend WithEvents XTextBox11 As LibX.XMaskEdit
    Friend WithEvents XTextBox12 As LibX.XMaskEdit
    Friend WithEvents xtxt_fact_nota As LibX.XTextBox
    Friend WithEvents btnTarjeta As System.Windows.Forms.Button
    Friend WithEvents cust_name As System.Windows.Forms.Label
    Friend WithEvents gColFecha As LibX.XEditTextBoxColumn
    Friend WithEvents gColVence As LibX.XEditTextBoxColumn
    Friend WithEvents gColDias As LibX.XEditTextBoxColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAplicarDesc As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRemoverDesc As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAplicar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDesaplicar As System.Windows.Forms.MenuItem
    Friend WithEvents xtxt_Balance1 As LibX.XTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblTermino As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPendiente As System.Windows.Forms.Label
    Friend WithEvents gColdesc_date As LibX.XEditTextBoxColumn
    Friend WithEvents btnIncluirPP As System.Windows.Forms.Button
    Friend WithEvents btnRemoverPP As System.Windows.Forms.Button
    Friend WithEvents xcbo_type_code As LibX.LibXCombo
    Friend WithEvents txtcust_code As LibX.XTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents XMaskEdit1 As LibX.XMaskEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents xtxt_chequera_name As System.Windows.Forms.Label
    Friend WithEvents xlk_chequera As LibX.LibXLookup
    Friend WithEvents XTexChequera As LibX.XTextBox
    Friend WithEvents gColterm_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents xlk_term_code As LibX.LibXLookup
    Friend WithEvents gColModulo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ccpaymd As System.Data.DataTable
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
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents chk_amount As LibX.XMaskEdit
    Friend WithEvents txtAmount As LibX.XMaskEdit
    Friend WithEvents xtxtdscto As LibX.XMaskEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents xtxaplicado As LibX.XMaskEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents DataColumn73 As System.Data.DataColumn
    Friend WithEvents DataColumn74 As System.Data.DataColumn
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents ccpaymm As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents btnFormulario As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents txtAnio As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ccpaymd = New System.Data.DataTable
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
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
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.ccpaymm = New System.Data.DataTable
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.DataColumn61 = New System.Data.DataColumn
        Me.DataColumn62 = New System.Data.DataColumn
        Me.DataColumn63 = New System.Data.DataColumn
        Me.DataColumn64 = New System.Data.DataColumn
        Me.DataColumn65 = New System.Data.DataColumn
        Me.DataColumn66 = New System.Data.DataColumn
        Me.DataColumn67 = New System.Data.DataColumn
        Me.DataColumn68 = New System.Data.DataColumn
        Me.DataColumn69 = New System.Data.DataColumn
        Me.DataColumn70 = New System.Data.DataColumn
        Me.DataColumn71 = New System.Data.DataColumn
        Me.DataColumn72 = New System.Data.DataColumn
        Me.DataColumn73 = New System.Data.DataColumn
        Me.DataColumn74 = New System.Data.DataColumn
        Me.DataColumn75 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.xtxt_fact_nota = New LibX.XTextBox
        Me.txtPaym_number = New LibX.XTextBox
        Me.txtcust_code = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtAnio = New System.Windows.Forms.TextBox
        Me.txtMes = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.xtxaplicado = New LibX.XMaskEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.xtxtdscto = New LibX.XMaskEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtAmount = New LibX.XMaskEdit
        Me.xlk_chequera = New LibX.LibXLookup
        Me.XTexChequera = New LibX.XTextBox
        Me.xtxt_chequera_name = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.XMaskEdit1 = New LibX.XMaskEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.xcbo_type_code = New LibX.LibXCombo
        Me.xtxt_Balance1 = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cust_name = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.XTextBox11 = New LibX.XMaskEdit
        Me.XTextBox12 = New LibX.XMaskEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.chk_amount = New LibX.XMaskEdit
        Me.Label23 = New System.Windows.Forms.Label
        Me.btnCheque = New System.Windows.Forms.Button
        Me.btnTarjeta = New System.Windows.Forms.Button
        Me.Label32 = New System.Windows.Forms.Label
        Me.xlk_cust_code = New LibX.LibXLookup
        Me.xdtp_paym_date = New LibX.LibxDateTimePicker
        Me.xcbo_paym_status = New LibX.LibXCombo
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.balance = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuAplicarDesc = New System.Windows.Forms.MenuItem
        Me.mnuRemoverDesc = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.mnuAplicar = New System.Windows.Forms.MenuItem
        Me.mnuDesaplicar = New System.Windows.Forms.MenuItem
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.xed_Tipo = New LibX.XEditTextBoxColumn
        Me.xed_number = New LibX.XEditTextBoxColumn
        Me.gColFecha = New LibX.XEditTextBoxColumn
        Me.gColVence = New LibX.XEditTextBoxColumn
        Me.gColterm_code = New LibX.XDataGridTextButtonColumn
        Me.xlk_term_code = New LibX.LibXLookup
        Me.gColDias = New LibX.XEditTextBoxColumn
        Me.gColAmount = New LibX.XEditTextBoxColumn
        Me.gColItbis = New LibX.XEditTextBoxColumn
        Me.gColtotal_amount = New LibX.XEditTextBoxColumn
        Me.gColBalance = New LibX.XEditTextBoxColumn
        Me.gColDescto1 = New LibX.XEditTextBoxColumn
        Me.gColAplAmount = New LibX.XEditTextBoxColumn
        Me.gColdesc_date = New LibX.XEditTextBoxColumn
        Me.gColModulo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnVisualizar = New System.Windows.Forms.Button
        Me.btnPagos = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnDistribucion = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblTermino = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtPendiente = New System.Windows.Forms.Label
        Me.btnIncluirPP = New System.Windows.Forms.Button
        Me.btnRemoverPP = New System.Windows.Forms.Button
        Me.btnFormulario = New System.Windows.Forms.Button
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccpaymd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccpaymm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_fact_nota
        Me.LibXNavigator1.FirstControlInFindMode = Me.txtPaym_number
        Me.LibXNavigator1.FirstControlInNewMode = Me.txtcust_code
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(962, 24)
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
        Me.LibXConnector1.DataMember = "ccpaymm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = "CXC"
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
        Me.LibXConnector1.UseTransactions = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ccpaymd, Me.ccpaymm})
        '
        'ccpaymd
        '
        Me.ccpaymd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn46, Me.DataColumn1})
        Me.ccpaymd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"paym_serial", "line_no"}, True)})
        Me.ccpaymd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn23, Me.DataColumn24}
        Me.ccpaymd.TableName = "ccpaymd"
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "paym_serial"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.AutoIncrement = True
        Me.DataColumn24.ColumnName = "line_no"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "invce_serial"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "type_code"
        Me.DataColumn26.MaxLength = 3
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "invce_no"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.ColumnName = "invce_date"
        Me.DataColumn28.DataType = GetType(System.DateTime)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "term_code"
        Me.DataColumn29.MaxLength = 5
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "invce_amount"
        Me.DataColumn30.DataType = GetType(System.Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "cargo_desc"
        Me.DataColumn31.DataType = GetType(System.Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "total_amount"
        Me.DataColumn32.DataType = GetType(System.Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "due_date"
        Me.DataColumn33.DataType = GetType(System.DateTime)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "dias"
        Me.DataColumn34.DataType = GetType(System.Int32)
        Me.DataColumn34.ReadOnly = True
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "disc_amount"
        Me.DataColumn35.DataType = GetType(System.Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "balance"
        Me.DataColumn36.DataType = GetType(System.Decimal)
        '
        'DataColumn37
        '
        Me.DataColumn37.AllowDBNull = False
        Me.DataColumn37.ColumnName = "amount"
        Me.DataColumn37.DataType = GetType(System.Decimal)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "pay_mora"
        Me.DataColumn38.DataType = GetType(System.Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "itbis_amount"
        Me.DataColumn39.DataType = GetType(System.Decimal)
        '
        'DataColumn40
        '
        Me.DataColumn40.AllowDBNull = False
        Me.DataColumn40.ColumnName = "mod_type"
        Me.DataColumn40.MaxLength = 3
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "disc_date"
        Me.DataColumn41.DataType = GetType(System.DateTime)
        '
        'DataColumn42
        '
        Me.DataColumn42.AllowDBNull = False
        Me.DataColumn42.ColumnName = "suc_code"
        Me.DataColumn42.DataType = GetType(System.Int32)
        '
        'DataColumn46
        '
        Me.DataColumn46.Caption = "Aplicar"
        Me.DataColumn46.ColumnName = "Aplicar"
        Me.DataColumn46.DataType = GetType(System.Int16)
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "paym_status"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'ccpaymm
        '
        Me.ccpaymm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72, Me.DataColumn73, Me.DataColumn74, Me.DataColumn75, Me.DataColumn2})
        Me.ccpaymm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"paym_serial"}, True)})
        Me.ccpaymm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn49}
        Me.ccpaymm.TableName = "ccpaymm"
        '
        'DataColumn49
        '
        Me.DataColumn49.AllowDBNull = False
        Me.DataColumn49.AutoIncrement = True
        Me.DataColumn49.ColumnName = "paym_serial"
        Me.DataColumn49.DataType = GetType(System.Int32)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "type_code"
        Me.DataColumn50.MaxLength = 3
        '
        'DataColumn51
        '
        Me.DataColumn51.AllowDBNull = False
        Me.DataColumn51.ColumnName = "paym_number"
        Me.DataColumn51.DataType = GetType(System.Int32)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "term_code"
        Me.DataColumn52.MaxLength = 5
        '
        'DataColumn53
        '
        Me.DataColumn53.AllowDBNull = False
        Me.DataColumn53.ColumnName = "cust_code"
        Me.DataColumn53.DataType = GetType(System.Int32)
        '
        'DataColumn54
        '
        Me.DataColumn54.AllowDBNull = False
        Me.DataColumn54.ColumnName = "invce_date"
        Me.DataColumn54.DataType = GetType(System.DateTime)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "detail"
        Me.DataColumn55.MaxLength = 60
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "due_date"
        Me.DataColumn56.DataType = GetType(System.DateTime)
        '
        'DataColumn57
        '
        Me.DataColumn57.AllowDBNull = False
        Me.DataColumn57.ColumnName = "amount"
        Me.DataColumn57.DataType = GetType(System.Decimal)
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "itbis"
        Me.DataColumn58.DataType = GetType(System.Decimal)
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "amount_grab"
        Me.DataColumn59.DataType = GetType(System.Decimal)
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "amount_excent"
        Me.DataColumn60.DataType = GetType(System.Decimal)
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "cargo_banc"
        Me.DataColumn61.DataType = GetType(System.Decimal)
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "cargo_desc"
        Me.DataColumn62.DataType = GetType(System.Decimal)
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "excento"
        Me.DataColumn63.DataType = GetType(System.Decimal)
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "impto"
        Me.DataColumn64.DataType = GetType(System.Decimal)
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "invce_status"
        Me.DataColumn65.DataType = GetType(System.Int32)
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "total_amount"
        Me.DataColumn66.DataType = GetType(System.Decimal)
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "invce_ncf"
        Me.DataColumn67.MaxLength = 20
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "vend_code"
        Me.DataColumn68.DataType = GetType(System.Int32)
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "chequera"
        Me.DataColumn69.DataType = GetType(System.Int32)
        '
        'DataColumn70
        '
        Me.DataColumn70.AllowDBNull = False
        Me.DataColumn70.ColumnName = "suc_code"
        Me.DataColumn70.DataType = GetType(System.Int32)
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "invce_datetran"
        Me.DataColumn71.DataType = GetType(System.DateTime)
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "invce_create"
        Me.DataColumn72.DataType = GetType(System.DateTime)
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "cash_amount"
        Me.DataColumn73.DataType = GetType(System.Decimal)
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "card_amount"
        Me.DataColumn74.DataType = GetType(System.Decimal)
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "check_amount"
        Me.DataColumn75.DataType = GetType(System.Decimal)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "invce_corte"
        Me.DataColumn2.DataType = GetType(System.DateTime)
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
        Me.LibXDbSourceTable1.KeyFields = "paym_serial"
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "paym_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select ccpaymm.*,ccinvcetran.cash_amount,ccinvcetran.card_amount,check_amount ", "from ccpaymm left join ccinvcetran on ccinvcetran.invce_serial = ccpaymm.paym_ser" & _
        "ial", "                    and ccinvcetran.type_code = ccpaymm.type_code"}
        Me.LibXDbSourceTable1.TableName = "ccpaymm"
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
        Me.LibXDbSourceTable2.KeyFields = "paym_serial,line_no"
        Me.LibXDbSourceTable2.LineColName = "line_no"
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"paym_serial=paym_serial"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select ccpaymm.paym_serial,", "       ccpaymd.line_no,", "       ccpaymd.invce_serial,", "       ccinvcem.type_code,", "       ccinvcem.invce_no,", "       ccinvcem.invce_date,", "       ccinvcem.term_code,", "       ccinvcem.amount invce_amount,", "       ccinvcem.cargo_desc,", "       ccinvcem.total_amount,", "       ccopend.due_date,", "       datediff(day,ccinvcem.invce_date,", "                    ccopend.due_date) dias,", "       ccpaymd.disc_amount,", "       ccpaymd.balance,", "       ccpaymd.amount,", "       ccpaymd.pay_mora,", "      ccpaymd.itbis_amount,", "      ccpaymd.mod_type,", "      ccopend.disc_date,", "      ccpaymd.suc_code,", "      ccpaymd.paym_status", "  from ccpaymd inner join ccinvcem", "    on ccpaymd.invce_serial = ccinvcem.invce_serial", " inner join ccopend  on ccpaymd.invce_serial = ccopend.invce_serial", " inner join ccpaymm on  ccpaymd.paym_serial  = ccpaymm.paym_serial", "order by ccpaymd.paym_serial,line_no"}
        Me.LibXDbSourceTable2.TableName = "ccpaymd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'xtxt_fact_nota
        '
        Me.xtxt_fact_nota.AcceptsReturn = True
        Me.xtxt_fact_nota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_fact_nota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccpaymm.detail"))
        Me.xtxt_fact_nota.EditInitialValue = Nothing
        Me.xtxt_fact_nota.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_fact_nota.FieldDescription = ""
        Me.xtxt_fact_nota.FindInitialValue = Nothing
        Me.xtxt_fact_nota.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_fact_nota.IgnoreRequiered = False
        Me.xtxt_fact_nota.Location = New System.Drawing.Point(72, 136)
        Me.xtxt_fact_nota.Multiline = True
        Me.xtxt_fact_nota.Name = "xtxt_fact_nota"
        Me.xtxt_fact_nota.NewInitialValue = Nothing
        Me.xtxt_fact_nota.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_fact_nota.Requiered = False
        Me.xtxt_fact_nota.Size = New System.Drawing.Size(360, 56)
        Me.xtxt_fact_nota.StatusBarPanelDescripcion = Nothing
        Me.xtxt_fact_nota.TabIndex = 3
        Me.xtxt_fact_nota.Text = ""
        '
        'txtPaym_number
        '
        Me.txtPaym_number.AcceptsReturn = True
        Me.txtPaym_number.AutoSize = False
        Me.txtPaym_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccpaymm.paym_number"))
        Me.txtPaym_number.EditInitialValue = Nothing
        Me.txtPaym_number.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtPaym_number.FieldDescription = ""
        Me.txtPaym_number.FindInitialValue = Nothing
        Me.txtPaym_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPaym_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaym_number.IgnoreRequiered = True
        Me.txtPaym_number.Location = New System.Drawing.Point(760, 16)
        Me.txtPaym_number.Name = "txtPaym_number"
        Me.txtPaym_number.NewInitialValue = Nothing
        Me.txtPaym_number.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPaym_number.Requiered = False
        Me.txtPaym_number.Size = New System.Drawing.Size(168, 32)
        Me.txtPaym_number.StatusBarPanelDescripcion = Nothing
        Me.txtPaym_number.TabIndex = 4
        Me.txtPaym_number.Text = ""
        Me.txtPaym_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcust_code
        '
        Me.txtcust_code.AcceptsReturn = True
        Me.txtcust_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcust_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccpaymm.cust_code"))
        Me.txtcust_code.EditInitialValue = Nothing
        Me.txtcust_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcust_code.FieldDescription = ""
        Me.txtcust_code.FindInitialValue = Nothing
        Me.txtcust_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcust_code.IgnoreRequiered = False
        Me.txtcust_code.Location = New System.Drawing.Point(72, 40)
        Me.txtcust_code.Name = "txtcust_code"
        Me.txtcust_code.NewInitialValue = Nothing
        Me.txtcust_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcust_code.Requiered = False
        Me.txtcust_code.Size = New System.Drawing.Size(64, 20)
        Me.txtcust_code.StatusBarPanelDescripcion = Nothing
        Me.txtcust_code.TabIndex = 1
        Me.txtcust_code.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtAnio)
        Me.GroupBox1.Controls.Add(Me.txtMes)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.xtxaplicado)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.xtxtdscto)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.xlk_chequera)
        Me.GroupBox1.Controls.Add(Me.XTexChequera)
        Me.GroupBox1.Controls.Add(Me.xtxt_chequera_name)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtcust_code)
        Me.GroupBox1.Controls.Add(Me.xcbo_type_code)
        Me.GroupBox1.Controls.Add(Me.xtxt_Balance1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cust_name)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.txtPaym_number)
        Me.GroupBox1.Controls.Add(Me.xlk_cust_code)
        Me.GroupBox1.Controls.Add(Me.xdtp_paym_date)
        Me.GroupBox1.Controls.Add(Me.xcbo_paym_status)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.balance)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xtxt_fact_nota)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(944, 208)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(104, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(7, 16)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "/"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(112, 64)
        Me.txtAnio.MaxLength = 4
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(64, 20)
        Me.txtAnio.TabIndex = 63
        Me.txtAnio.Text = ""
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(72, 64)
        Me.txtMes.MaxLength = 2
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(32, 20)
        Me.txtMes.TabIndex = 62
        Me.txtMes.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 16)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Mes/Ano:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxaplicado
        '
        Me.xtxaplicado.AcceptsReturn = True
        Me.xtxaplicado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccpaymm.amount"))
        Me.xtxaplicado.EditInitialValue = Nothing
        Me.xtxaplicado.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxaplicado.FieldDescription = ""
        Me.xtxaplicado.FindInitialValue = Nothing
        Me.xtxaplicado.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxaplicado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxaplicado.IgnoreRequiered = False
        Me.xtxaplicado.Location = New System.Drawing.Point(560, 96)
        Me.xtxaplicado.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxaplicado.Name = "xtxaplicado"
        Me.xtxaplicado.NewInitialValue = Nothing
        Me.xtxaplicado.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxaplicado.Requiered = False
        Me.xtxaplicado.Size = New System.Drawing.Size(144, 26)
        Me.xtxaplicado.StatusBarPanelDescripcion = Nothing
        Me.xtxaplicado.TabIndex = 5
        Me.xtxaplicado.Text = ""
        Me.xtxaplicado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(472, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 22)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Aplicado:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxtdscto
        '
        Me.xtxtdscto.AcceptsReturn = True
        Me.xtxtdscto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccpaymm.cargo_desc"))
        Me.xtxtdscto.EditInitialValue = Nothing
        Me.xtxtdscto.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtdscto.FieldDescription = ""
        Me.xtxtdscto.FindInitialValue = Nothing
        Me.xtxtdscto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtdscto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxtdscto.IgnoreRequiered = False
        Me.xtxtdscto.Location = New System.Drawing.Point(560, 128)
        Me.xtxtdscto.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxtdscto.Name = "xtxtdscto"
        Me.xtxtdscto.NewInitialValue = Nothing
        Me.xtxtdscto.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtdscto.Requiered = False
        Me.xtxtdscto.Size = New System.Drawing.Size(144, 26)
        Me.xtxtdscto.StatusBarPanelDescripcion = Nothing
        Me.xtxtdscto.TabIndex = 58
        Me.xtxtdscto.Text = ""
        Me.xtxtdscto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(457, 118)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 22)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Descuento:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAmount
        '
        Me.txtAmount.AcceptsReturn = True
        Me.txtAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccpaymm.total_amount"))
        Me.txtAmount.EditInitialValue = Nothing
        Me.txtAmount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAmount.Enabled = False
        Me.txtAmount.FieldDescription = ""
        Me.txtAmount.FindInitialValue = Nothing
        Me.txtAmount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.IgnoreRequiered = False
        Me.txtAmount.Location = New System.Drawing.Point(560, 160)
        Me.txtAmount.Masked = MaskedTextBox.Mask.Decimal
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.NewInitialValue = Nothing
        Me.txtAmount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAmount.Requiered = False
        Me.txtAmount.Size = New System.Drawing.Size(144, 26)
        Me.txtAmount.StatusBarPanelDescripcion = Nothing
        Me.txtAmount.TabIndex = 56
        Me.txtAmount.Text = ""
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xlk_chequera
        '
        Me.xlk_chequera.AlternateFieldSearch = Nothing
        Me.xlk_chequera.BeginCheck = False
        Me.xlk_chequera.CheckText = Nothing
        Me.xlk_chequera.ComboMode = False
        Me.xlk_chequera.DataMember = Nothing
        Me.xlk_chequera.DataSource = Me.LibXConnector1
        Me.xlk_chequera.DestParameters = New String() {"chequera=chequera", "xtxt_chequera_name=descripcion"}
        Me.xlk_chequera.FilterField = "descripcion"
        Me.xlk_chequera.IgnoreFindInBrowseMode = False
        Me.xlk_chequera.isCanceled = False
        Me.xlk_chequera.Location = New System.Drawing.Point(416, 112)
        Me.xlk_chequera.LookCaption = "Cuentas Bancarias"
        Me.xlk_chequera.Name = "xlk_chequera"
        Me.xlk_chequera.PopupSize = New System.Drawing.Size(600, 300)
        Me.xlk_chequera.ShowFilter = True
        Me.xlk_chequera.ShowMessageNotFound = True
        Me.xlk_chequera.ShowWarning = False
        Me.xlk_chequera.Size = New System.Drawing.Size(16, 20)
        Me.xlk_chequera.SizesColumns = New String() {"descripcion=300"}
        Me.xlk_chequera.SizesColumnsTab = Nothing
        Me.xlk_chequera.SqlString = Nothing
        Me.xlk_chequera.SQLTab = Nothing
        Me.xlk_chequera.SrcParameters = New String() {"chequera=chequera"}
        Me.xlk_chequera.TabIndex = 55
        Me.xlk_chequera.TableName = "cpchequera"
        Me.xlk_chequera.TabStop = False
        Me.xlk_chequera.UseCopyConnection = False
        Me.xlk_chequera.UseRowRetrieveEvents = False
        Me.xlk_chequera.UseTab = False
        Me.xlk_chequera.VisParameters = New String() {"Chequera=chequera", "Nombre=descripcion", "Cuenta Banco=cuenta_banco"}
        Me.xlk_chequera.WhereCondition = Nothing
        Me.xlk_chequera.WhereParameters = ""
        '
        'XTexChequera
        '
        Me.XTexChequera.AcceptsReturn = True
        Me.XTexChequera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTexChequera.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccpaymm.chequera"))
        Me.XTexChequera.EditInitialValue = Nothing
        Me.XTexChequera.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTexChequera.FieldDescription = ""
        Me.XTexChequera.FindInitialValue = Nothing
        Me.XTexChequera.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTexChequera.IgnoreRequiered = False
        Me.XTexChequera.Location = New System.Drawing.Point(72, 112)
        Me.XTexChequera.Name = "XTexChequera"
        Me.XTexChequera.NewInitialValue = Nothing
        Me.XTexChequera.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTexChequera.Requiered = False
        Me.XTexChequera.Size = New System.Drawing.Size(64, 20)
        Me.XTexChequera.StatusBarPanelDescripcion = Nothing
        Me.XTexChequera.TabIndex = 2
        Me.XTexChequera.Text = ""
        '
        'xtxt_chequera_name
        '
        Me.xtxt_chequera_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xtxt_chequera_name.Location = New System.Drawing.Point(144, 112)
        Me.xtxt_chequera_name.Name = "xtxt_chequera_name"
        Me.xtxt_chequera_name.Size = New System.Drawing.Size(272, 20)
        Me.xtxt_chequera_name.TabIndex = 54
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(2, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 16)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Chequera:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XMaskEdit1
        '
        Me.XMaskEdit1.AcceptsReturn = True
        Me.XMaskEdit1.AutoSize = False
        Me.XMaskEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccpaymm.invce_ncf"))
        Me.XMaskEdit1.EditInitialValue = Nothing
        Me.XMaskEdit1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XMaskEdit1.Enabled = False
        Me.XMaskEdit1.FieldDescription = ""
        Me.XMaskEdit1.FindInitialValue = Nothing
        Me.XMaskEdit1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XMaskEdit1.IgnoreRequiered = False
        Me.XMaskEdit1.Location = New System.Drawing.Point(760, 56)
        Me.XMaskEdit1.Masked = MaskedTextBox.Mask.Decimal
        Me.XMaskEdit1.Name = "XMaskEdit1"
        Me.XMaskEdit1.NewInitialValue = Nothing
        Me.XMaskEdit1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.Requiered = False
        Me.XMaskEdit1.Size = New System.Drawing.Size(168, 20)
        Me.XMaskEdit1.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit1.TabIndex = 50
        Me.XMaskEdit1.Text = ""
        Me.XMaskEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(720, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 16)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "NCF:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_type_code
        '
        Me.xcbo_type_code.AllowDefaultSort = True
        Me.xcbo_type_code.bound = True
        Me.xcbo_type_code.currValue = Nothing
        Me.xcbo_type_code.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ccpaymm.type_code"))
        Me.xcbo_type_code.DefaultWhereString = "Apply_cxc=1 AND type_code in ('RCB','NDC','DCC','RSM','RPS')"
        Me.xcbo_type_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_type_code.EditInitialValue = Nothing
        Me.xcbo_type_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_type_code.FieldDescription = ""
        Me.xcbo_type_code.FindInitialValue = Nothing
        Me.xcbo_type_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_type_code.IgnoreRequiered = False
        Me.xcbo_type_code.Location = New System.Drawing.Point(72, 16)
        Me.xcbo_type_code.LookupKeyDisplayFields = "type_name"
        Me.xcbo_type_code.LookupKeyField = "type_code"
        Me.xcbo_type_code.LookupTableName = "ivtypem"
        Me.xcbo_type_code.Name = "xcbo_type_code"
        Me.xcbo_type_code.NewInitialValue = ""
        Me.xcbo_type_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_type_code.Requiered = False
        Me.xcbo_type_code.Required = False
        Me.xcbo_type_code.Size = New System.Drawing.Size(360, 21)
        Me.xcbo_type_code.SqlString = Nothing
        Me.xcbo_type_code.StatusBarPanelDescripcion = Nothing
        Me.xcbo_type_code.TabIndex = 0
        '
        'xtxt_Balance1
        '
        Me.xtxt_Balance1.AcceptsReturn = True
        Me.xtxt_Balance1.EditInitialValue = Nothing
        Me.xtxt_Balance1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Balance1.FieldDescription = ""
        Me.xtxt_Balance1.FindInitialValue = Nothing
        Me.xtxt_Balance1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Balance1.IgnoreRequiered = False
        Me.xtxt_Balance1.Location = New System.Drawing.Point(328, 88)
        Me.xtxt_Balance1.Name = "xtxt_Balance1"
        Me.xtxt_Balance1.NewInitialValue = Nothing
        Me.xtxt_Balance1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Balance1.ReadOnly = True
        Me.xtxt_Balance1.Requiered = False
        Me.xtxt_Balance1.Size = New System.Drawing.Size(104, 20)
        Me.xtxt_Balance1.StatusBarPanelDescripcion = Nothing
        Me.xtxt_Balance1.TabIndex = 48
        Me.xtxt_Balance1.TabStop = False
        Me.xtxt_Balance1.Text = ""
        Me.xtxt_Balance1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(216, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Balance con Desc.:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cust_name
        '
        Me.cust_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cust_name.Location = New System.Drawing.Point(144, 40)
        Me.cust_name.Name = "cust_name"
        Me.cust_name.Size = New System.Drawing.Size(272, 20)
        Me.cust_name.TabIndex = 46
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.XTextBox11)
        Me.GroupBox3.Controls.Add(Me.XTextBox12)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.chk_amount)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.btnCheque)
        Me.GroupBox3.Controls.Add(Me.btnTarjeta)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Location = New System.Drawing.Point(712, 88)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(224, 96)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Forma de Pago"
        '
        'XTextBox11
        '
        Me.XTextBox11.AcceptsReturn = True
        Me.XTextBox11.AutoSize = False
        Me.XTextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccpaymm.cash_amount"))
        Me.XTextBox11.EditInitialValue = Nothing
        Me.XTextBox11.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox11.FieldDescription = ""
        Me.XTextBox11.FindInitialValue = Nothing
        Me.XTextBox11.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTextBox11.IgnoreRequiered = False
        Me.XTextBox11.Location = New System.Drawing.Point(88, 16)
        Me.XTextBox11.Masked = MaskedTextBox.Mask.Decimal
        Me.XTextBox11.Name = "XTextBox11"
        Me.XTextBox11.NewInitialValue = Nothing
        Me.XTextBox11.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox11.Requiered = False
        Me.XTextBox11.Size = New System.Drawing.Size(112, 20)
        Me.XTextBox11.StatusBarPanelDescripcion = Nothing
        Me.XTextBox11.TabIndex = 0
        Me.XTextBox11.Text = ""
        Me.XTextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'XTextBox12
        '
        Me.XTextBox12.AcceptsReturn = True
        Me.XTextBox12.AutoSize = False
        Me.XTextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccpaymm.card_amount"))
        Me.XTextBox12.EditInitialValue = Nothing
        Me.XTextBox12.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.FieldDescription = ""
        Me.XTextBox12.FindInitialValue = Nothing
        Me.XTextBox12.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTextBox12.IgnoreRequiered = False
        Me.XTextBox12.Location = New System.Drawing.Point(88, 40)
        Me.XTextBox12.Masked = MaskedTextBox.Mask.Decimal
        Me.XTextBox12.Name = "XTextBox12"
        Me.XTextBox12.NewInitialValue = Nothing
        Me.XTextBox12.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.Requiered = False
        Me.XTextBox12.Size = New System.Drawing.Size(88, 20)
        Me.XTextBox12.StatusBarPanelDescripcion = Nothing
        Me.XTextBox12.TabIndex = 1
        Me.XTextBox12.Text = ""
        Me.XTextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(32, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 16)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Efectivo:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(32, 40)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 16)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "Tarjeta:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chk_amount
        '
        Me.chk_amount.AcceptsReturn = True
        Me.chk_amount.AutoSize = False
        Me.chk_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccpaymm.check_amount"))
        Me.chk_amount.EditInitialValue = Nothing
        Me.chk_amount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_amount.FieldDescription = ""
        Me.chk_amount.FindInitialValue = Nothing
        Me.chk_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_amount.IgnoreRequiered = False
        Me.chk_amount.Location = New System.Drawing.Point(88, 64)
        Me.chk_amount.Masked = MaskedTextBox.Mask.None
        Me.chk_amount.Name = "chk_amount"
        Me.chk_amount.NewInitialValue = Nothing
        Me.chk_amount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_amount.Requiered = False
        Me.chk_amount.Size = New System.Drawing.Size(88, 20)
        Me.chk_amount.StatusBarPanelDescripcion = Nothing
        Me.chk_amount.TabIndex = 3
        Me.chk_amount.Text = ""
        Me.chk_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(32, 64)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 16)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Cheque:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCheque
        '
        Me.btnCheque.Location = New System.Drawing.Point(176, 64)
        Me.btnCheque.Name = "btnCheque"
        Me.btnCheque.Size = New System.Drawing.Size(24, 20)
        Me.btnCheque.TabIndex = 4
        Me.btnCheque.Text = "..."
        '
        'btnTarjeta
        '
        Me.btnTarjeta.Enabled = False
        Me.btnTarjeta.Location = New System.Drawing.Point(176, 40)
        Me.btnTarjeta.Name = "btnTarjeta"
        Me.btnTarjeta.Size = New System.Drawing.Size(24, 20)
        Me.btnTarjeta.TabIndex = 2
        Me.btnTarjeta.Text = "..."
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(30, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(29, 16)
        Me.Label32.TabIndex = 39
        Me.Label32.Text = "Tipo:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_cust_code
        '
        Me.xlk_cust_code.AlternateFieldSearch = Nothing
        Me.xlk_cust_code.BeginCheck = False
        Me.xlk_cust_code.CheckText = Nothing
        Me.xlk_cust_code.ComboMode = False
        Me.xlk_cust_code.DataMember = Nothing
        Me.xlk_cust_code.DataSource = Me.LibXConnector1
        Me.xlk_cust_code.DestParameters = New String() {"cust_code=cust_code", "cust_name=cust_name", "balance=balance"}
        Me.xlk_cust_code.FilterField = "cust_name"
        Me.xlk_cust_code.IgnoreFindInBrowseMode = False
        Me.xlk_cust_code.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.xlk_cust_code.isCanceled = False
        Me.xlk_cust_code.Location = New System.Drawing.Point(416, 40)
        Me.xlk_cust_code.LookCaption = "Clientes"
        Me.xlk_cust_code.Name = "xlk_cust_code"
        Me.xlk_cust_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_cust_code.ShowFilter = True
        Me.xlk_cust_code.ShowMessageNotFound = True
        Me.xlk_cust_code.ShowWarning = False
        Me.xlk_cust_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_cust_code.SizesColumns = New String() {"cust_name=500", "credit_limit=150"}
        Me.xlk_cust_code.SizesColumnsTab = Nothing
        Me.xlk_cust_code.SqlString = Nothing
        Me.xlk_cust_code.SQLTab = New String() {"select type_code Tipo, invce_no Número,", " invce_date Fecha, ccinvcem.due_date Vencimiento, ", "       ccinvcem.amount Monto, itbis Itbis, balance Balance", "from ccinvcem inner join ccopend", "on ccinvcem.invce_serial = ccopend.invce_serial", "and ccopend.balance <> 0"}
        Me.xlk_cust_code.SrcParameters = New String() {"cust_code=cust_code"}
        Me.xlk_cust_code.TabIndex = 2
        Me.xlk_cust_code.TableName = "cccustm"
        Me.xlk_cust_code.TabStop = False
        Me.xlk_cust_code.UseCopyConnection = False
        Me.xlk_cust_code.UseRowRetrieveEvents = False
        Me.xlk_cust_code.UseTab = True
        Me.xlk_cust_code.VisParameters = New String() {"Código=cust_code", "Nombre=cust_name", "Límite Crédito=credit_limit", "Balance=balance"}
        Me.xlk_cust_code.WhereCondition = "cust_credito = 1"
        Me.xlk_cust_code.WhereParameters = ""
        '
        'xdtp_paym_date
        '
        Me.xdtp_paym_date.CustomFormat = "dd/MM/yyyy"
        Me.xdtp_paym_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ccpaymm.invce_date"))
        Me.xdtp_paym_date.EditInitialValue = Nothing
        Me.xdtp_paym_date.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdtp_paym_date.FieldDescription = ""
        Me.xdtp_paym_date.FindInitialValue = Nothing
        Me.xdtp_paym_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_paym_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xdtp_paym_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdtp_paym_date.IgnoreRequiered = False
        Me.xdtp_paym_date.Location = New System.Drawing.Point(560, 56)
        Me.xdtp_paym_date.Name = "xdtp_paym_date"
        Me.xdtp_paym_date.NewInitialValue = "Now"
        Me.xdtp_paym_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_paym_date.Requiered = False
        Me.xdtp_paym_date.Size = New System.Drawing.Size(144, 32)
        Me.xdtp_paym_date.StatusBarPanelDescripcion = Nothing
        Me.xdtp_paym_date.TabIndex = 4
        '
        'xcbo_paym_status
        '
        Me.xcbo_paym_status.AllowDefaultSort = True
        Me.xcbo_paym_status.bound = True
        Me.xcbo_paym_status.currValue = Nothing
        Me.xcbo_paym_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ccpaymm.invce_status"))
        Me.xcbo_paym_status.DefaultWhereString = Nothing
        Me.xcbo_paym_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_paym_status.EditInitialValue = Nothing
        Me.xcbo_paym_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_paym_status.FieldDescription = ""
        Me.xcbo_paym_status.FindInitialValue = "2"
        Me.xcbo_paym_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_paym_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xcbo_paym_status.IgnoreRequiered = False
        Me.xcbo_paym_status.Items.AddRange(New Object() {"2-Pendiente", "0-Anulada", "3-Saldado"})
        Me.xcbo_paym_status.Location = New System.Drawing.Point(560, 16)
        Me.xcbo_paym_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_paym_status.LookupKeyField = Nothing
        Me.xcbo_paym_status.LookupTableName = Nothing
        Me.xcbo_paym_status.Name = "xcbo_paym_status"
        Me.xcbo_paym_status.NewInitialValue = "2"
        Me.xcbo_paym_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_paym_status.Requiered = False
        Me.xcbo_paym_status.Required = False
        Me.xcbo_paym_status.Size = New System.Drawing.Size(144, 33)
        Me.xcbo_paym_status.SqlString = Nothing
        Me.xcbo_paym_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_paym_status.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(712, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'balance
        '
        Me.balance.AcceptsReturn = True
        Me.balance.EditInitialValue = Nothing
        Me.balance.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.balance.FieldDescription = ""
        Me.balance.FindInitialValue = Nothing
        Me.balance.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.balance.IgnoreRequiered = False
        Me.balance.Location = New System.Drawing.Point(72, 88)
        Me.balance.Name = "balance"
        Me.balance.NewInitialValue = Nothing
        Me.balance.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.balance.ReadOnly = True
        Me.balance.Requiered = False
        Me.balance.StatusBarPanelDescripcion = Nothing
        Me.balance.TabIndex = 1
        Me.balance.TabStop = False
        Me.balance.Text = ""
        Me.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(11, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Balance:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(490, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(441, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Monto Pagar:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(28, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nota:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(484, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Estatus:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Documentos a Pagar"
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.DataMember = "ccpaymd"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = True
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 240)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(944, 328)
        Me.LibXGrid1.TabIndex = 0
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = False
        Me.LibXGrid1.UseHandCursor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAplicarDesc, Me.mnuRemoverDesc, Me.MenuItem3, Me.mnuAplicar, Me.mnuDesaplicar})
        '
        'mnuAplicarDesc
        '
        Me.mnuAplicarDesc.Index = 0
        Me.mnuAplicarDesc.Text = "Aplicar Desc. x P. P."
        '
        'mnuRemoverDesc
        '
        Me.mnuRemoverDesc.Index = 1
        Me.mnuRemoverDesc.Text = "Remover Desc. x P. P."
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "-"
        '
        'mnuAplicar
        '
        Me.mnuAplicar.Index = 3
        Me.mnuAplicar.Text = "Aplicar"
        '
        'mnuDesaplicar
        '
        Me.mnuDesaplicar.Index = 4
        Me.mnuDesaplicar.Text = "Desaplicar"
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.xed_Tipo, Me.xed_number, Me.gColFecha, Me.gColVence, Me.gColterm_code, Me.gColDias, Me.gColAmount, Me.gColItbis, Me.gColtotal_amount, Me.gColBalance, Me.gColDescto1, Me.gColAplAmount, Me.gColdesc_date, Me.gColModulo})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ccpaymd"
        '
        'xed_Tipo
        '
        Me.xed_Tipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xed_Tipo.Format = ""
        Me.xed_Tipo.FormatInfo = Nothing
        Me.xed_Tipo.HeaderText = "Tipo"
        Me.xed_Tipo.ImageList = Nothing
        Me.xed_Tipo.isReadOnly = True
        Me.xed_Tipo.MappingName = "type_code"
        Me.xed_Tipo.MaxLength = 32767
        Me.xed_Tipo.ReadOnly = True
        Me.xed_Tipo.TabStop = True
        Me.xed_Tipo.UseCustomCellFormat = False
        Me.xed_Tipo.Width = 55
        '
        'xed_number
        '
        Me.xed_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xed_number.Format = ""
        Me.xed_number.FormatInfo = Nothing
        Me.xed_number.HeaderText = "Número"
        Me.xed_number.ImageList = Nothing
        Me.xed_number.isReadOnly = True
        Me.xed_number.MappingName = "invce_no"
        Me.xed_number.MaxLength = 32767
        Me.xed_number.ReadOnly = True
        Me.xed_number.TabStop = True
        Me.xed_number.UseCustomCellFormat = False
        Me.xed_number.Width = 65
        '
        'gColFecha
        '
        Me.gColFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColFecha.Format = ""
        Me.gColFecha.FormatInfo = Nothing
        Me.gColFecha.HeaderText = "Fecha"
        Me.gColFecha.ImageList = Nothing
        Me.gColFecha.isReadOnly = True
        Me.gColFecha.MappingName = "invce_date"
        Me.gColFecha.MaxLength = 32767
        Me.gColFecha.ReadOnly = True
        Me.gColFecha.TabStop = True
        Me.gColFecha.UseCustomCellFormat = False
        Me.gColFecha.Width = 75
        '
        'gColVence
        '
        Me.gColVence.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColVence.Format = ""
        Me.gColVence.FormatInfo = Nothing
        Me.gColVence.HeaderText = "Vence"
        Me.gColVence.ImageList = Nothing
        Me.gColVence.isReadOnly = True
        Me.gColVence.MappingName = "due_date"
        Me.gColVence.MaxLength = 32767
        Me.gColVence.ReadOnly = True
        Me.gColVence.TabStop = True
        Me.gColVence.UseCustomCellFormat = False
        Me.gColVence.Width = 75
        '
        'gColterm_code
        '
        Me.gColterm_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColterm_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColterm_code.executeFindDuringFill = False
        Me.gColterm_code.Format = ""
        Me.gColterm_code.FormatInfo = Nothing
        Me.gColterm_code.HeaderText = "Termino"
        Me.gColterm_code.isReadOnly = False
        Me.gColterm_code.Lookup = Me.xlk_term_code
        Me.gColterm_code.MappingName = "term_code"
        Me.gColterm_code.MaxLength = 32767
        Me.gColterm_code.TabStop = True
        Me.gColterm_code.UseCustomCellFormat = False
        Me.gColterm_code.Width = 75
        '
        'xlk_term_code
        '
        Me.xlk_term_code.AlternateFieldSearch = Nothing
        Me.xlk_term_code.BeginCheck = False
        Me.xlk_term_code.CheckText = Nothing
        Me.xlk_term_code.ComboMode = False
        Me.xlk_term_code.DataMember = Nothing
        Me.xlk_term_code.DataSource = Me.LibXConnector1
        Me.xlk_term_code.DestParameters = New String() {"term_code=term_code"}
        Me.xlk_term_code.FilterField = "term_name"
        Me.xlk_term_code.IgnoreFindInBrowseMode = False
        Me.xlk_term_code.isCanceled = False
        Me.xlk_term_code.Location = New System.Drawing.Point(473, 350)
        Me.xlk_term_code.LookCaption = "Términos de Venta"
        Me.xlk_term_code.Name = "xlk_term_code"
        Me.xlk_term_code.PopupSize = New System.Drawing.Size(600, 300)
        Me.xlk_term_code.ShowFilter = True
        Me.xlk_term_code.ShowMessageNotFound = True
        Me.xlk_term_code.ShowWarning = False
        Me.xlk_term_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_term_code.SizesColumns = New String() {"descripcion=300"}
        Me.xlk_term_code.SizesColumnsTab = Nothing
        Me.xlk_term_code.SqlString = Nothing
        Me.xlk_term_code.SQLTab = Nothing
        Me.xlk_term_code.SrcParameters = New String() {"term_code=term_code"}
        Me.xlk_term_code.TabIndex = 56
        Me.xlk_term_code.TableName = "cctermm"
        Me.xlk_term_code.TabStop = False
        Me.xlk_term_code.UseCopyConnection = False
        Me.xlk_term_code.UseRowRetrieveEvents = False
        Me.xlk_term_code.UseTab = False
        Me.xlk_term_code.VisParameters = New String() {"Código=term_code", "Descripción=term_name", "% Descuento=disc_pct", "Días vencimiento=due_days", "Días Descuento=disc_days"}
        Me.xlk_term_code.WhereCondition = Nothing
        Me.xlk_term_code.WhereParameters = ""
        '
        'gColDias
        '
        Me.gColDias.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColDias.Format = "#,###"
        Me.gColDias.FormatInfo = Nothing
        Me.gColDias.HeaderText = "Días"
        Me.gColDias.ImageList = Nothing
        Me.gColDias.isReadOnly = True
        Me.gColDias.MappingName = "dias"
        Me.gColDias.MaxLength = 32767
        Me.gColDias.ReadOnly = True
        Me.gColDias.TabStop = True
        Me.gColDias.UseCustomCellFormat = False
        Me.gColDias.Width = 45
        '
        'gColAmount
        '
        Me.gColAmount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColAmount.Format = "##,###,###.00"
        Me.gColAmount.FormatInfo = Nothing
        Me.gColAmount.HeaderText = "Montoi"
        Me.gColAmount.ImageList = Nothing
        Me.gColAmount.isReadOnly = True
        Me.gColAmount.MappingName = "invce_amount"
        Me.gColAmount.MaxLength = 32767
        Me.gColAmount.ReadOnly = True
        Me.gColAmount.TabStop = True
        Me.gColAmount.UseCustomCellFormat = False
        Me.gColAmount.Width = 85
        '
        'gColItbis
        '
        Me.gColItbis.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColItbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColItbis.Format = "#,##0.00"
        Me.gColItbis.FormatInfo = Nothing
        Me.gColItbis.HeaderText = "ITBISi"
        Me.gColItbis.ImageList = Nothing
        Me.gColItbis.isReadOnly = True
        Me.gColItbis.MappingName = "itbis_amount"
        Me.gColItbis.MaxLength = 32767
        Me.gColItbis.ReadOnly = True
        Me.gColItbis.TabStop = True
        Me.gColItbis.UseCustomCellFormat = False
        Me.gColItbis.Width = 85
        '
        'gColtotal_amount
        '
        Me.gColtotal_amount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColtotal_amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColtotal_amount.Format = "###,##0.00"
        Me.gColtotal_amount.FormatInfo = Nothing
        Me.gColtotal_amount.HeaderText = "Monto Netoi"
        Me.gColtotal_amount.ImageList = Nothing
        Me.gColtotal_amount.isReadOnly = True
        Me.gColtotal_amount.MappingName = "total_amount"
        Me.gColtotal_amount.MaxLength = 32767
        Me.gColtotal_amount.ReadOnly = True
        Me.gColtotal_amount.TabStop = True
        Me.gColtotal_amount.UseCustomCellFormat = False
        Me.gColtotal_amount.Width = 85
        '
        'gColBalance
        '
        Me.gColBalance.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColBalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColBalance.Format = "##,###,###.00"
        Me.gColBalance.FormatInfo = Nothing
        Me.gColBalance.HeaderText = "Pendientei"
        Me.gColBalance.ImageList = Nothing
        Me.gColBalance.isReadOnly = False
        Me.gColBalance.MappingName = "balance"
        Me.gColBalance.MaxLength = 32767
        Me.gColBalance.ReadOnly = True
        Me.gColBalance.TabStop = True
        Me.gColBalance.UseCustomCellFormat = False
        Me.gColBalance.Width = 85
        '
        'gColDescto1
        '
        Me.gColDescto1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColDescto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColDescto1.Format = "##,##0.00"
        Me.gColDescto1.FormatInfo = Nothing
        Me.gColDescto1.HeaderText = "Desc. x P. P.i"
        Me.gColDescto1.ImageList = Nothing
        Me.gColDescto1.isReadOnly = True
        Me.gColDescto1.MappingName = "disc_amount"
        Me.gColDescto1.MaxLength = 20
        Me.gColDescto1.ReadOnly = True
        Me.gColDescto1.TabStop = True
        Me.gColDescto1.UseCustomCellFormat = True
        Me.gColDescto1.Width = 85
        '
        'gColAplAmount
        '
        Me.gColAplAmount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColAplAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColAplAmount.Format = "##,###,##0.00"
        Me.gColAplAmount.FormatInfo = Nothing
        Me.gColAplAmount.HeaderText = "Aplicado"
        Me.gColAplAmount.ImageList = Nothing
        Me.gColAplAmount.isReadOnly = False
        Me.gColAplAmount.MappingName = "amount"
        Me.gColAplAmount.MaxLength = 32767
        Me.gColAplAmount.NullText = "0"
        Me.gColAplAmount.ReadOnly = True
        Me.gColAplAmount.TabStop = True
        Me.gColAplAmount.UseCustomCellFormat = False
        Me.gColAplAmount.Width = 85
        '
        'gColdesc_date
        '
        Me.gColdesc_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColdesc_date.Format = "dd/MM/yyyy"
        Me.gColdesc_date.FormatInfo = Nothing
        Me.gColdesc_date.ImageList = Nothing
        Me.gColdesc_date.isReadOnly = False
        Me.gColdesc_date.MappingName = "disc_date"
        Me.gColdesc_date.MaxLength = 32767
        Me.gColdesc_date.TabStop = True
        Me.gColdesc_date.UseCustomCellFormat = False
        Me.gColdesc_date.Width = 0
        '
        'gColModulo
        '
        Me.gColModulo.Format = ""
        Me.gColModulo.FormatInfo = Nothing
        Me.gColModulo.MappingName = "mod_type"
        Me.gColModulo.Width = 0
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Enabled = False
        Me.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVisualizar.Location = New System.Drawing.Point(8, 664)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(75, 32)
        Me.btnVisualizar.TabIndex = 1
        Me.btnVisualizar.Text = "Visualizar"
        '
        'btnPagos
        '
        Me.btnPagos.Enabled = False
        Me.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPagos.Location = New System.Drawing.Point(88, 664)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Size = New System.Drawing.Size(75, 32)
        Me.btnPagos.TabIndex = 2
        Me.btnPagos.Text = "Pagos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(720, 624)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Pendiente por Aplicar:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnDistribucion
        '
        Me.btnDistribucion.Enabled = False
        Me.btnDistribucion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDistribucion.Location = New System.Drawing.Point(848, 664)
        Me.btnDistribucion.Name = "btnDistribucion"
        Me.btnDistribucion.Size = New System.Drawing.Size(96, 32)
        Me.btnDistribucion.TabIndex = 5
        Me.btnDistribucion.Text = "Distribuir Automático"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(24, 600)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Término:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTermino
        '
        Me.lblTermino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTermino.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccpaymd.term_code"))
        Me.lblTermino.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblTermino.Location = New System.Drawing.Point(128, 600)
        Me.lblTermino.Name = "lblTermino"
        Me.lblTermino.Size = New System.Drawing.Size(72, 20)
        Me.lblTermino.TabIndex = 7
        Me.lblTermino.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccpaymd.disc_date"))
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(128, 624)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 20)
        Me.Label12.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(24, 624)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 16)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Venc./Descuento:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPendiente
        '
        Me.txtPendiente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtPendiente.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtPendiente.Location = New System.Drawing.Point(848, 624)
        Me.txtPendiente.Name = "txtPendiente"
        Me.txtPendiente.Size = New System.Drawing.Size(96, 20)
        Me.txtPendiente.TabIndex = 7
        Me.txtPendiente.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnIncluirPP
        '
        Me.btnIncluirPP.Enabled = False
        Me.btnIncluirPP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIncluirPP.Location = New System.Drawing.Point(744, 664)
        Me.btnIncluirPP.Name = "btnIncluirPP"
        Me.btnIncluirPP.Size = New System.Drawing.Size(96, 32)
        Me.btnIncluirPP.TabIndex = 4
        Me.btnIncluirPP.Text = "Incluir Desc. x P. P."
        '
        'btnRemoverPP
        '
        Me.btnRemoverPP.Enabled = False
        Me.btnRemoverPP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemoverPP.Location = New System.Drawing.Point(640, 664)
        Me.btnRemoverPP.Name = "btnRemoverPP"
        Me.btnRemoverPP.Size = New System.Drawing.Size(96, 32)
        Me.btnRemoverPP.TabIndex = 3
        Me.btnRemoverPP.Text = "Remover Desc. x P. P."
        '
        'btnFormulario
        '
        Me.btnFormulario.Enabled = False
        Me.btnFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFormulario.Location = New System.Drawing.Point(176, 664)
        Me.btnFormulario.Name = "btnFormulario"
        Me.btnFormulario.Size = New System.Drawing.Size(128, 32)
        Me.btnFormulario.TabIndex = 57
        Me.btnFormulario.Text = "Llenar Formulario"
        '
        'i_ccpaym02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(962, 720)
        Me.Controls.Add(Me.btnFormulario)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.xlk_term_code)
        Me.Controls.Add(Me.btnPagos)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.btnDistribucion)
        Me.Controls.Add(Me.lblTermino)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPendiente)
        Me.Controls.Add(Me.btnIncluirPP)
        Me.Controls.Add(Me.btnRemoverPP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "i_ccpaym02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Recibo de Ingresos"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccpaymd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccpaymm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub EstatusCliente(ByVal Cliente)
        ''// actualiza el status del cliente
        Dim XUpdate As LibX.Data.XUpdateStmt
        Try
            XUpdate = New LibX.Data.XUpdateStmt("cccustm")
            XUpdate.FieldsSet("CUST_STATUS") = 2 '' estatus suspendido
            XUpdate.Fields("CUST_CODE") = Cliente
            XUpdate.Fields("STOP_ABONO") = 1
            XUpdate.Execute()

        Catch ex As Exception
            Throw
        End Try

    End Sub
    Private Function ExisteRecibosPendientes(ByVal pcust_code As Integer) As Boolean
        Dim SelectStmt As String
        Dim Existecxc As Integer
        Dim Existepv As Integer

        Try
            SelectStmt = "select count(*) from ccpaymm " & _
                        " where cust_code = " & pcust_code.ToString.Trim & _
                        "   and invce_status = 2 " & _
                        "   and type_code = '" & mTipoDocumento.Trim & "'"

            Existecxc = Val(LibX.Data.Manager.GetScalar(SelectStmt).ToString.Trim)

            SelectStmt = "select count(*) from ftfactm " & _
                        " where cust_code = " & pcust_code.ToString.Trim & _
                        "   and fact_status = 1 " & _
                        "   and type_code = '" & mTipoDocumento.Trim & "'"

            Existepv = Val(LibX.Data.Manager.GetScalar(SelectStmt).ToString.Trim)

            If Existecxc > 0 Or Existepv > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    Private Sub DocumentosPendientes(ByVal pcust_code As Integer)
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim lineno As Integer
        Dim pdscto, odscto As Decimal
        Dim tIpo As Integer
        Dim oTrodscnt As Integer
        Dim dias_dscto, dd As Integer
        Dim Termino As DataRow

        SelectStmt = "select ccinvcem.invce_serial," & _
                    " ccinvcem.type_code," & _
                    " ccinvcem.invce_no," & _
                    " ccinvcem.term_code," & _
                    " ccinvcem.invce_date," & _
                    " ccinvcem.amount invce_amount," & _
                    " isnull(ccinvcem.cargo_desc,0)cargo_desc," & _
                    " ccinvcem.total_amount," & _
                    " ccopend.disc_balance disc_amount," & _
                    " ccopend.due_date," & _
                    " datediff(day," & _
                    " ccopend.due_date,getdate()) dias," & _
                    " ccopend.balance," & _
                    " ccopend.itbis_balance," & _
                    " 'CXC' mod_type," & _
                    " ccopend.disc_date" & _
                    " from ccinvcem " & _
                    " inner join ccopend " & _
                    " on ccinvcem.invce_serial = ccopend.invce_serial" & _
                    " and ccopend.balance <> 0" & _
                    " where ccinvcem.cust_code = " & pcust_code.ToString & _
                    " and ccopend.invce_serial not in(select invce_serial from ccpaymd " & _
                    " where  amount = ccopend.balance and paym_status = 2)" & _
                    " order by ccinvcem.invce_date,ccinvcem.invce_no "

        '//" and invce_date <= '" & xdt_invce_corte.Value.ToString & _

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        If oTable Is Nothing Then
            Throw New ApplicationException("No se encontrarón documentos pendientes!")
        End If

        If oTable.Rows.Count <= 0 Then
            Throw New ApplicationException("No se encontrarón documentos pendientes!")
        End If

        SelectStmt = "select csttype_code from cccustm where cust_code =" & Me.txtcust_code.Text
        tIpo = Val(LibX.Data.Manager.GetScalar(SelectStmt).ToString.Trim)

        SelectStmt = "select term_code,isnull(otro_dsct,0)otro_dsct from cccustm where cust_code =" & Me.txtcust_code.Text
        Termino = LibX.Data.Manager.GetDataRow(SelectStmt)

        oTable.TableName = "ccpaymd"

        lineno = 0

        ccpaymd.Rows.Clear()
        oTermino = New SGT.CXC.Entidades.Termino(Termino!term_code)
        odscto = (oTermino.PorcDescuento / 100)
        dd = oTermino.DiasDescuento

        For Each oRow As DataRow In oTable.Rows
            Dim oRow1 As DataRow = ccpaymd.NewRow

            pdscto = odscto
            dias_dscto = dd
            lineno += 1
            oRow1!line_no = lineno
            oRow1!type_code = oRow!type_code
            oRow1!invce_no = oRow!invce_no
            oRow1!term_code = oRow!term_code
            oRow1!invce_serial = oRow!invce_serial
            oRow1!invce_date = oRow!invce_date
            oRow1!due_date = oRow!due_date
            oRow1!dias = oRow!dias
            oRow1!cargo_desc = oRow!cargo_desc
            oRow1!invce_amount = oRow!invce_amount
            oRow1!total_amount = oRow!total_amount
            If Termino!otro_dsct = 1 Then
                oRow1!disc_amount = oRow!cargo_desc
                If oRow1!disc_amount = 0 Then
                    oRow1!disc_amount = oRow!disc_amount
                End If
            Else
                oRow1!disc_amount = oRow!disc_amount
            End If
            oRow1!itbis_amount = oRow!itbis_balance
            oRow1!disc_date = oRow!disc_date
            oRow1!mod_type = oRow!mod_type
            oRow1!balance = oRow!balance

            ccpaymd.Rows.Add(oRow1)
        Next

        btnPagos.Enabled = ccpaymd.Rows.Count > 0
        btnDistribucion.Enabled = ccpaymd.Rows.Count > 0
        btnRemoverPP.Enabled = ccpaymd.Rows.Count > 0
        btnIncluirPP.Enabled = ccpaymd.Rows.Count > 0
        Me.btnFormulario.Enabled = ccpaymd.Rows.Count > 0

        Me.LibXGrid1.refreshFooter()
        xtxt_Balance1.Text = Val(balance.Text.Trim) - Val(Me.LibXGrid1.GetFooterValue(gColDescto1).ToString.Trim)
        '// Calcular
        Calcular()
    End Sub
    Private Sub xtxaplicado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles xtxaplicado.KeyPress
        Try
            If LibXConnector1.IsDataEditing = True Then
                If Val(xtxaplicado.Text.Trim) > 0 Then
                    mDigitado = True
                Else
                    mDigitado = False
                End If

                Me.btnDistribucion.Enabled = mDigitado
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try
            Me.xcbo_type_code.Focus()
            Me.xcbo_paym_status.currValue = 2 'Pendiente de aplicar

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xlk_cust_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_cust_code.AfterSetValues
        Try

            If e.dataFound = False Then
                Exit Sub
            End If
            If LibXConnector1.State = LibX.LibxConnectorState.Insert Then
                '// Cargar las facturas pendientes de este cliente
                If LibXConnector1.IsDataEditing = True Then
                    DocumentosPendientes(e.row!cust_code)
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Dim XUpdate As LibX.Data.XUpdateStmt

        Try
            oDocument = New SGT.Inventario.Entidades.Documento(mTipoDocumento)
            If Me.XTexChequera.Text <> "" And e.UpdatingArgs.StatementType <> StatementType.Delete Then
                oTransacion = New SGT.ControlBancario.Entidades.TipoDocumento(mTipoDocumento, e.UpdatingArgs.Row!chequera)
            End If

            If e.UpdatingArgs.StatementType = StatementType.Insert _
                Or e.UpdatingArgs.StatementType = StatementType.Update Then
                If ccpaymd.Select("amount>0").Length <= 0 Then
                    Throw New ApplicationException("Debe seleccionar los documentos a aplicar!")
                End If
                If (mTipoDocumento = "RSM" Or mTipoDocumento = "DCC") And Me.XTexChequera.Text = "" Then
                    Throw New ApplicationException("Debe Digitar una chequera!")
                End If
                If CDbl(Me.xtxaplicado.Text) < CDbl(Me.txtAmount.Text) Then
                    Throw New ApplicationException("El monto aplicado no puede ser menor que el monto a pagar!")
                End If


                '// Datos
                e.UpdatingArgs.Row!type_code = mTipoDocumento 'RECIBO DE INGRESO
                e.UpdatingArgs.Row!cargo_desc = Val(Me.LibXGrid1.GetFooterValue(gColDescto1).ToString.Trim)
                If LibX.IsNull(e.UpdatingArgs.Row!invce_date) = True OrElse e.UpdatingArgs.Row!invce_date = #12:00:00 AM# Then
                    e.UpdatingArgs.Row!invce_date = LibXConnector1.CurrentDataRow!invce_date = LibX.Data.Manager.Connection.GetDate
                End If
                e.UpdatingArgs.Row!itbis = 0
                e.UpdatingArgs.Row!suc_code = LibX.User.Sucursal
                e.UpdatingArgs.Row!invce_create = LibX.Data.Manager.GetScalar("select getdate()")
            End If

            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                If oDocument.AutoNumerar = True Then
                    If mTipoDocumento = "RSM" Then
                        e.UpdatingArgs.Row!paym_number = 99 & oDocument.GenerateNumber(mTipoDocumento, WhDefault) & 99
                        e.UpdatingArgs.Row!vend_code = 1
                    Else
                        If mTipoDocumento = "DCC" Then ''Or mTipoDocumento = "RPS" Then
                            e.UpdatingArgs.Row!paym_number = oTransacion.GenerateNumber(mTipoDocumento, e.UpdatingArgs.Row!chequera)
                        Else
                            e.UpdatingArgs.Row!paym_number = oDocument.GenerateNumber(e.UpdatingArgs.Row!type_code, WhDefault)
                        End If
                    End If
                End If

                If LibX.IsNull(LibXConnector1.CurrentDataRow!invce_ncf) AndAlso oDocument.GenerarNCF = True Then

                    Dim oParametroNCF As ParametrosCreditoFiscal = New SGT.Facturacion.Entidades.ParametrosCreditoFiscal
                    Dim blnSuccess As Boolean = False

                    oParametroNCF.Almacen = WhDefault
                    If Not LibX.IsNull(LibXConnector1.CurrentDataRow!cust_code) Then
                        oParametroNCF.Cliente = LibXConnector1.CurrentDataRow!cust_code
                    End If
                    If mTipoDocumento = "RSM" Then
                        oParametroNCF.TipoDocumento = "FPV"
                    End If

                    oParametroNCF.TipoNcf = LibX.Data.Manager.GetScalar("select isnull(ncf_type,0) from cccustm where cust_code = " & oParametroNCF.Cliente)
                    If oParametroNCF.TipoNcf = 0 Then
                        oParametroNCF.TipoNcf = 1
                    End If

                    blnSuccess = ofctDocumento.AplicarCreditoFiscal(oParametroNCF)
                    If blnSuccess = True Then
                        If Not oParametroNCF.Retorno.NCF Is Nothing Then
                            e.UpdatingArgs.Row!invce_ncf = oParametroNCF.Retorno.NCF
                        End If
                    End If
                End If
            End If

            If e.UpdatingArgs.StatementType = StatementType.Delete Then
                e.UpdatingArgs.Status = UpdateStatus.SkipAllRemainingRows
                ''AnularDocumento(e.UpdatingArgs.Row)
                'End If
            End If

            ''// actuliza estatus del cliente
            '//EstatusCliente(txtcust_code.Text)
        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)
            'Throw
        End Try
    End Sub

    Private Sub i_ccpaym01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            oDocument = New SGT.Inventario.Entidades.Documento(mTipoDocumento)

            oSdocumento = New SGT.Contabilidad.Entidades.Documentos

            Me.xcbo_type_code.NewInitialValue = mTipoDocumento

            Porc_mora = LibX.Data.Manager.GetScalar("select percent_charge from ivsetup")

            LibXGrid1.footerOperations.add("invce_no", "count(invce_no)")
            LibXGrid1.footerOperations.add("Aplicar", "count(type_code)")
            LibXGrid1.footerOperations.add("amount", "sum(amount)")
            LibXGrid1.footerOperations.add("disc_amount", "sum(disc_amount)", "amount<>0")
            LibXGrid1.footerOperations.add("balance", "sum(balance)")

            '// buscar el almacen por defecto
            xlk_cust_code.BeginCheck = True
            xlk_cust_code.CheckText = "Balance mayor que 0"

            oParamValidar = New SGT.Administracion.Entidades.Permission.ParametrosValidar
            oAutorizar = New SGT.Administracion.Entidades.Permission
            ofctDocumento = New SGT.Facturacion.Entidades.Documento

            '// Validar Permisos de Usuario
            oParamValidar.UserID = LibX.User.UserID
            WhDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxWhDefault")
            SCDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxSCDefault")

            '// Mostrar los datos de la caja y la cajera
            Me.LibXGrid1.getCurrentGridView.AllowNew = False

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub xlk_term_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_term_code.AfterSetValues
        Dim Descuento As Decimal
        Dim Balance As Decimal
        If e.dataFound = False Then
            Exit Sub
        End If
        Try

            Balance = Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColBalance) - Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColItbis)
            Descuento = Decimal.Round(Balance * (Val(e.row!disc_pct.ToString.Trim) / 100), 2)
            LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, gColDescto1, Descuento)
            LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, gColAplAmount, Decimal.Zero)
            mDigiterm = True

            '// Remover o Seleccionar el documento
            If LibXConnector1.IsDataEditing = True Then 'And e.row > -1 Then
                AsignarMonto(LibXGrid1.CurrentRowIndex)
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_InsertingDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingDetailRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then
                If LibX.IsNull(e.UpdatingArgs.Row!amount) OrElse Val(e.UpdatingArgs.Row!amount.ToString.Trim) = 0 Then
                    e.UpdatingArgs.Status = UpdateStatus.SkipCurrentRow
                Else
                    e.UpdatingArgs.Row!type_code = mTipoDocumento
                    e.UpdatingArgs.Row!mod_type = "CXC"
                    e.UpdatingArgs.Row!paym_status = 2
                    e.UpdatingArgs.Row!suc_code = LibX.User.Sucursal
                End If
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)

        End Try
    End Sub

    Private Sub ccpaymd_RowChanged(ByVal sender As System.Object, ByVal e As System.Data.DataRowChangeEventArgs)
        Try
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub xtxaplicado_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Try
            If LibXConnector1.IsDataEditing = True Then
                If xtxaplicado.Text.Length > 0 AndAlso CDbl(Me.xtxaplicado.Text.Trim) > Val(Me.balance.Text.Trim) Then
                    Throw New ApplicationException("Monto del recibo inváldo!")
                End If

                If xtxaplicado.Text.Length > 0 Then
                    Calcular()
                    If Val(LibXGrid1.GetFooterValue(Me.gColAplAmount).ToString.Trim) > 0 And Accion <> 4 Then
                        DocumentosPendientes(LibXConnector1.CurrentDataRow!cust_code)
                    End If
                End If

            End If

        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultqueryValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultQueryValues) Handles LibXConnector1.SettingDefaultqueryValues
        Try
            Me.xcbo_type_code.NewInitialValue = "RCB"
            Me.xcbo_paym_status.currValue = 2
            txtPaym_number.Enabled = True
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertedRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedRow
        Dim oPago As SGT.CXC.Posteos.PostDocument
        Dim oParamPago As SGT.CXC.Posteos.PostDocument.ParametrosPagos

        Try
        Catch ex As Exception
            LibX.Log.Add(ex)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
        End Try
    End Sub

    Private Sub btnDistribucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDistribucion.Click
        Dim RowIndex As Integer = 0
        Dim descto As Decimal
        Dim aplicado As Decimal
        Try
            If txtAmount.Text.Length = 0 Then
                xtxaplicado.Text = Val(balance.Text.Trim)
                txtAmount.Text = Val(balance.Text.Trim) - Val(LibXGrid1.GetFooterValue(Me.gColDescto1).ToString.Trim)
            Else
                RemovarAplicar()
            End If

            If mResta = 0 Then
                aplicado = Val(LibXGrid1.GetFooterValue(gColAplAmount).ToString.Trim)
                'mResta = txtAmount.Text - aplicado
                mResta = CDbl(xtxaplicado.Text) - aplicado
            End If

            '// Aplicar Nota de Credito
            For Each orow As DataRow In ccpaymd.Select("balance < 0")
                orow.BeginEdit()
                orow!amount = (Val(orow!balance.Tostring.Trim) - Val(orow!disc_amount.Tostring.Trim))
                mResta -= Val(orow!Balance.Tostring.Trim) - Val(orow!disc_amount.Tostring.Trim)
                orow.EndEdit()
            Next

            '// Aplicar Facturas
            For Each orow As DataRow In ccpaymd.Select("balance > 0", "due_date")
                If Val(orow!amount.Tostring.Trim) = 0 Then
                    orow.BeginEdit()

                    If (txtAnio.Text = CDate(orow!invce_date).Year And _
                        txtMes.Text = CDate(orow!invce_date).Month) _
                        Or txtAnio.Text.Trim() = String.Empty And txtMes.Text.Trim() = String.Empty Then

                        If mResta > Val(orow!balance.Tostring.Trim) Then
                            mResta -= Val(orow!balance.Tostring.Trim)
                            orow!amount = Val(orow!balance.Tostring.Trim)
                            If mRemoverDesc = False Then
                                descto += Format(Val(orow!disc_amount.Tostring.Trim), "##,##0.000")
                            End If
                        Else
                            orow!amount = mResta
                            orow!disc_amount = 0
                            mResta = 0
                        End If
                    End If

                    orow.EndEdit()

                    If mResta = 0 Then
                        Exit For
                    End If
                End If
            Next
            Calcular()
            mRemoverDesc = False

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        e.AditionalWhere = "ccpaymm.type_code IN ('RCB','DCC','NDC','RSM','RPS')" 'and ccinvcem.whse_code = " & WhDefault.ToString
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try
            If e.isDataEditing = True And e.action = LibxConnectionActions.Edit Then
                mTipoDocumento = LibXConnector1.CurrentDataRow!type_code
                Me.xcbo_type_code.SelectedValue = LibXConnector1.CurrentDataRow!type_code
            End If
            btnVisualizar.Enabled = (LibXConnector1.HasRecords)
            btnPagos.Enabled = (LibXConnector1.HasRecords)
            btnDistribucion.Enabled = e.isDataEditing And LibXConnector1.HasRecords
            btnIncluirPP.Enabled = e.isDataEditing And LibXConnector1.HasRecords
            btnRemoverPP.Enabled = e.isDataEditing And LibXConnector1.HasRecords
            btnFormulario.Enabled = LibXConnector1.HasRecords

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub AsignarMonto(ByVal Row As Integer)
        Dim Aplicar As Decimal
        Dim DescuentoPP As Decimal
        Dim Disc_Amount As Decimal
        Dim Monto As Decimal

        Try
            DescuentoPP = Format(Val(ccpaymd.Rows(Row)!disc_amount.ToString.Trim), "##,##0.000")
            Aplicar = Val(ccpaymd.Rows(Row)!balance.ToString.Trim) ''- Format(Val(ccpaymd.Rows(Row)!disc_amount.ToString.Trim), "##,##0.000")

            '// si se aplico reversar
            If Val(ccpaymd.Rows(Row)!Amount.ToString.Trim) <> 0 Then
                If mDigitado = False Then
                    Monto = CDbl(Me.txtAmount.Text.Trim) - Val(ccpaymd.Rows(Row)!Amount.ToString.Trim)
                    Me.txtAmount.Text = Format(Monto, "##,###,##0.00")
                End If

                ccpaymd.Rows(Row).BeginEdit()
                ccpaymd.Rows(Row)!Amount = DBNull.Value
                Disc_Amount -= DescuentoPP
                '// Si el monto del documento es menor que la parte a aplicar
                '// asignar el monto del documento como monto a aplicar
            ElseIf Val(ccpaymd.Rows(Row)!balance.ToString.Trim) <= mResta Or mDigitado = False Then
                If mDigitado = False Then
                    Monto = Val(Me.txtAmount.Text.Trim) + Aplicar
                    Me.txtAmount.Text = Format(Monto, "##,###,##0.00")
                End If

                ccpaymd.Rows(Row).BeginEdit()
                ccpaymd.Rows(Row)!Amount = Aplicar
                Disc_Amount += DescuentoPP

                '// Si el monto de documento es mayor que el monto restante
                '// Asignar el monto restante
            Else
                If Aplicar >= mResta Then
                    ccpaymd.Rows(Row).BeginEdit()
                    ccpaymd.Rows(Row)!Amount = mResta
                End If
            End If

            ccpaymd.Rows(Row).EndEdit()
            Calcular()

        Catch ex As Exception
            'Throw
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagos.Click
        Dim oParam As LibX.LibxPrgParams
        Dim WhereStmt As String
        Try
            oParam = New LibX.LibxPrgParams
            oParam.WhereToExecute = "ccinvcem.type_code = '" & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xed_Tipo).ToString & "'" & _
                                    " and ccinvcem.invce_no = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xed_number).ToString
            LibX.App.CurrentPrgParams = oParam

            LibX.LibXRunner.Run("c_ccdocs01", "CXC", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LimpiarMora()
        For Each oRow As DataRow In ccpaymd.Rows
            oRow!pay_mora = 0
        Next
    End Sub

    Private Sub xlk_cust_code_CheckedChanged(ByVal sender As Object, ByVal e As LibX.CheckedChangedEventArgs) Handles xlk_cust_code.CheckedChanged
        If e.CheckStatus = True Then
            e.Table.DefaultView.RowFilter = "balance > 0"
        Else
            e.Table.DefaultView.RowFilter = ""
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        Dim xParam As LibX.LibxPrgParams
        Dim xParamAdm As SGT.Administracion.Entidades.Program.ParametrosVizualizar
        Dim xProgram As SGT.Administracion.Entidades.Program
        Try
            If DataSet1.Tables(0).Rows.Count <= 0 Then
                Exit Sub
            End If

            xParam = New LibX.LibxPrgParams
            xParamAdm = New SGT.Administracion.Entidades.Program.ParametrosVizualizar
            xProgram = New SGT.Administracion.Entidades.Program

            xParam.AllowDelete = False
            xParam.AllowEdit = False
            xParam.AllowNew = False
            xParam.AllowPrint = False
            xParam.AllowQuery = False
            xParam.initMode = LibxInitModes.Query
            xParam.WhereToExecute = "ccinvcem.invce_no = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xed_number) & " AND ccinvcem.type_code = '" & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xed_Tipo) & "'"
            xParam.Value = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xed_number)  'TIPO
            LibX.App.CurrentPrgParams = xParam

            Me.Cursor = Cursors.WaitCursor

            xParamAdm.TipoDocumento = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 1)
            '// xParamAdm.Parametros = xParam

            xProgram.Visualizar(xParamAdm)

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub gColAplicar_BoolValueChanged(ByVal sender As System.Object, ByVal e As LibX.BoolValueChangedEventArgs)
        If LibXConnector1.IsDataEditing = True Then
            If e.BoolValue = False Then
                LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.gColAplAmount, 0)
            End If
        End If
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Dim Descto As Decimal

        Try
            Accion = e.Action
            If e.AcceptedAction = LibxConnectionActions.Add _
            Or e.AcceptedAction = LibxConnectionActions.Edit Then
                LibXConnector1.ExecuteFind("ccpaymm.paym_serial = " & LibXConnector1.CurrentDataRow!paym_serial.ToString.Trim)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LibXGrid1.DoubleClick
        Try
            If LibXConnector1.IsDataEditing = True Then
                AsignarMonto(LibXGrid1.CurrentRowIndex)
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If Not e.row Is Nothing Then
                If Val(e.row!invce_status) = 2 Then '// Pendiente
                    LibXConnector1.AllowPrint = True
                    LibXConnector1.AllowEdit = True
                    LibXConnector1.AllowDelete = True
                Else
                    LibXConnector1.AllowPrint = True
                    LibXConnector1.AllowEdit = False
                    LibXConnector1.AllowDelete = False
                End If
            End If


            LibXNavigator1.UpdateState()
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub btnCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheque.Click
        '//ShowPayMethod("CHK")
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams
            With oParam
                .IsFromOther = True
                .AllowDelete = False
                .AllowEdit = True
                .AllowNew = True
                .AllowPrint = False
                .AllowQuery = False
                Me.Cursor = Cursors.WaitCursor
                If LibXConnector1.CurrentDataRow!type_code.ToString.Trim = "RSM" And Val(chk_amount.Text) > 0 Then
                    .WhereToExecute = "ccinvcetran.paym_serial = " & LibXConnector1.CurrentDataRow!paym_serial.ToString & _
                              " and ccinvcetran.type_code = 'RSM' "
                    LibX.App.CurrentPrgParams = oParam
                    LibX.LibXRunner.Run("c_cjpaym01", "CXC", True)
                End If
            End With

        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnTarjeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTarjeta.Click
        Try
            '//ShowPayMethod("TAR")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub i_ptvrecib01_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If LibXConnector1.IsEditing = False And LibXConnector1.HasRecords = True Then
                If e.KeyCode = Keys.F9 Then
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            If e.AcceptedAction = LibxConnectionActions.Add _
                AndAlso e.Action <> LibxConnectionActions.Cancel Then
                If LibX.IsNull(LibXConnector1.CurrentDataRow!invce_date) = True Then
                    LibXConnector1.CurrentDataRow!invce_date = LibX.Data.Manager.Connection.GetDate
                End If
            End If
            If e.Action = LibxConnectionActions.Find Then
                Me.xcbo_paym_status.currValue = 2
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRemoverDesc.Click
        Try
            Me.LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.gColDescto1, 0.0)

            '// Se asigna 1 para que al ejecutar el metodo AsignarMonto
            '// y este limpie el valor
            Me.LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.gColAplAmount, 0)
            Calcular()
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAplicarDesc.Click
        CalcularDescPP(LibXGrid1.CurrentRowIndex)
    End Sub

    Private Sub CalcularDescPP(ByVal RowIdx As Integer)
        Dim Descuento As Decimal
        Try
            oTermino = New SGT.CXC.Entidades.Termino(ccpaymd.Rows(RowIdx)!term_code.ToString.Trim)
            Descuento = oTermino.CalcularDescuento(ccpaymd.Rows(RowIdx)!balance.ToString.Trim)
            Me.LibXGrid1.SetValue(RowIdx, Me.gColDescto1, Descuento)

            '// Se asigna 1 para que al ejecutar el metodo AsignarMonto
            '// y este limpie el valor
            Me.LibXGrid1.SetValue(RowIdx, Me.gColAplAmount, 0)
            Calcular()
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub
    Private Sub Calcular()
        Dim Aplicar As Decimal, Aplicado As Decimal, Resta As Decimal
        Dim Descto As Decimal
        Dim i As Integer
        Dim dias_dscto As Integer
        Dim oDesct As Decimal
        Dim sTerm As String
        Dim pdscto As Decimal

        Try
            If oDesct = 0 Then
                sTerm = LibX.Data.Manager.GetScalar("select term_code from cccustm where cust_code = " & Me.txtcust_code.Text)
                oTermino = New SGT.CXC.Entidades.Termino(sTerm)
                pdscto = (oTermino.PorcDescuento / 100)
                dias_dscto = oTermino.DiasDescuento
            End If
            If txtAmount.Text.Length > 0 Then
                Aplicar = CDbl(txtAmount.Text.Trim) - Descto
            End If

            Aplicado = 0
            mResta = 0

            For i = 0 To LibXGrid1.getCurrentGridView.Count - 1
                If LibXGrid1.GetValue(i, Me.gColAmount) <> "" Then
                    If mDigitado = False Then
                        If Val(LibXGrid1.GetValue(i, Me.gColAplAmount).ToString) > 0 Then
                            Aplicado += Val(LibXGrid1.GetValue(i, Me.gColAplAmount).ToString)
                            Descto += Val(LibXGrid1.GetValue(i, Me.gColDescto1).ToString)
                        End If
                    Else
                        Aplicado += Val(LibXGrid1.GetValue(i, Me.gColAplAmount).ToString)
                        Descto += Val(LibXGrid1.GetValue(i, Me.gColAplAmount).ToString * pdscto)
                    End If
                    If Val(LibXGrid1.GetValue(i, Me.gColAplAmount).ToString) > 0 And mDigiterm = False Then
                        If mRemoverDesc = False Then
                            LibXGrid1.SetValue(i, Me.gColDescto1, Val(LibXGrid1.GetValue(i, Me.gColAplAmount).ToString * pdscto))
                        End If
                        LibXGrid1.SetValue(i, Me.gColAplAmount, Val(LibXGrid1.GetValue(i, Me.gColAplAmount).ToString))
                    End If
                    If Aplicar > 0 Then
                        mResta = Aplicar - Aplicado
                    Else
                        Aplicar = Aplicado
                    End If
                    If Val(LibXGrid1.GetValue(i, Me.gColAplAmount).ToString) > 0 Then
                        Me.xtxtdscto.Text = Format(Descto, "##,###,##0.00")
                        Me.txtAmount.Text = Format(Aplicar - Descto, "##,###,##0.00")
                    End If
                    Me.LibXGrid1.refreshFooter()
                    If mDigitado = True Then
                        txtPendiente.Text = Format(mResta, "##,###,##0.00")
                    End If
                End If

            Next
            mDigiterm = False

            '''Me.xtxtdscto.Text = Format(Descto, "##,###,##0.00")
            If Val(Me.txtAmount.Text) < 0 Then
                Me.xtxaplicado.Text = Format(Aplicado, "##,###,##0.00")
                Me.xtxtdscto.Text = Format(Descto, "##,###,##0.00")
                Me.txtAmount.Text = Format(Aplicado - Descto, "##,###,##0.00")
            End If

            If mDigitado = False And Aplicado <> 0 Then
                Me.txtAmount.Text = Format(Aplicado - Descto, "##,###,##0.00")
                Me.xtxaplicado.Text = Format(Aplicado, "##,###,##0.00")
                Me.xtxtdscto.Text = Format(Descto, "##,###,##0.00")
            End If

            If Aplicar > 0 Then
                mResta = Aplicar - Aplicado
            Else
                Aplicar = Aplicado
            End If


            Me.LibXGrid1.refreshFooter()
            If mDigitado = True Then
                txtPendiente.Text = Format(mResta, "##,###,##0.00")
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Dim SelecStmt As String
        Dim WhereStmt As String
        Dim AxCrystalReport1 As LibX.ReportLib
        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
                '// Tomar el Connection String del config
                AxCrystalReport1 = New LibX.ReportLib("CXC", "r_ccpaym02.rpt")
                WhereStmt = String.Concat("ccpaymm.type_code = '", LibXConnector1.CurrentDataRow!type_code.ToString, "'", _
                                         " and ccpaymm.paym_number = ", LibXConnector1.CurrentDataRow!paym_number.ToString, _
                                         " and ccpaymm.paym_serial = ", LibXConnector1.CurrentDataRow!paym_serial.ToString)

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

    Private Sub btnIncluirPP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluirPP.Click
        Dim oDesct As Decimal
        Dim sTerm As String
        Dim pdscto As Decimal
        If Accion <> 4 Then
            DocumentosPendientes(txtcust_code.Text)
            mRemoverDesc = False
        Else
            sTerm = LibX.Data.Manager.GetScalar("select term_code from cccustm where cust_code = " & Me.txtcust_code.Text)
            oTermino = New SGT.CXC.Entidades.Termino(sTerm)
            pdscto = (oTermino.PorcDescuento / 100)
            For RowIdx As Integer = 0 To LibXGrid1.getCurrentGridView.Count - 1
                ''LibXGrid1.SetValue(RowIdx, gColDescto1, )
                LibXGrid1.SetValue(RowIdx, Me.gColDescto1, Val(LibXGrid1.GetValue(RowIdx, Me.gColAplAmount).ToString * pdscto))

                '// Se asigna 1 para que al ejecutar el metodo AsignarMonto
                '// y este limpie el valor
                ''LibXGrid1.SetValue(RowIdx, gColAplAmount, 0)
                LibXGrid1.SetValue(RowIdx, Me.gColAplAmount, Val(LibXGrid1.GetValue(RowIdx, Me.gColAplAmount).ToString))
                mRemoverDesc = False
            Next
            Calcular()
        End If

    End Sub

    Private Sub btnRemoverPP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoverPP.Click
        Try
            For RowIdx As Integer = 0 To LibXGrid1.getCurrentGridView.Count - 1
                LibXGrid1.SetValue(RowIdx, gColDescto1, 0)

                '// Se asigna 1 para que al ejecutar el metodo AsignarMonto
                '// y este limpie el valor
                LibXGrid1.SetValue(RowIdx, gColAplAmount, 0)
                'xtxaplicado.Text = 0
                xtxtdscto.Text = 0
                txtAmount.Text = 0
                mRemoverDesc = True
            Next
            Calcular()

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub txtcust_code_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Try
            If LibXConnector1.IsDataEditing = True Then
                If Me.txtcust_code.Text.Length = 0 Then
                    Throw New ApplicationException("Debe especificar el cliente antes de continuar!")
                End If
            End If
        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub RemovarAplicar()
        For RowIdx As Integer = 0 To LibXGrid1.getCurrentGridView.Count - 1
            '// Se asigna 1 para que al ejecutar el metodo AsignarMonto
            '// y este limpie el valor
            LibXGrid1.SetValue(RowIdx, gColAplAmount, 0)
        Next
        mResta = 0
        Calcular()

    End Sub

    Private Sub xcbo_type_code_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xcbo_type_code.SelectedIndexChanged
        Try
            If LibXConnector1.IsDataEditing = True And Not Me.xcbo_type_code.SelectedValue Is Nothing Then

                If mTipoDocumento.Trim <> "" Then
                    oDocument = New SGT.Inventario.Entidades.Documento(mTipoDocumento)

                    If Not LibX.IsNull(Me.xcbo_type_code.SelectedValue) Then
                        mTipoDocumento = Me.xcbo_type_code.SelectedValue
                    End If

                    Me.xcbo_type_code.NewInitialValue = mTipoDocumento
                    Me.txtPaym_number.Enabled = (oDocument.AutoNumerar = False)
                End If

                If mTipoDocumento = "RSM" Or mTipoDocumento = "DCC" Then
                    Me.xlk_chequera.Enabled = True
                    Me.XTexChequera.Enabled = True
                Else
                    Me.xlk_chequera.Enabled = False
                    Me.XTexChequera.Enabled = True
                    Me.XTexChequera.Text = ""
                    Me.xtxt_chequera_name.Text = ""
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        Dim SelectStmt As String
        Try

            If LibXConnector1.CurrentAction = LibxConnectionActions.Edit Then ''_
                For i As Integer = 0 To ccpaymd.Rows.Count - 1
                    If ccpaymd.Rows(i).RowState <> DataRowState.Deleted AndAlso LibX.IsNull(ccpaymd.Rows(i)!amount) Then
                        SelectStmt = "delete ccpaymd where paym_serial = " & ccpaymd.Rows(i)!paym_serial.ToString.Trim & " and line_no = " & ccpaymd.Rows(i)!line_no.ToString.Trim
                        LibX.Data.Manager.GetScalar(SelectStmt)
                    End If
                Next
            End If

        Catch ex As Exception
            e.Handled = True
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub ccpaymd_RowDeleted(ByVal sender As System.Object, ByVal e As System.Data.DataRowChangeEventArgs)

        Try
            Calcular()
            LibXGrid1.Focus(LibXGrid1.currentRowNum, 0)
            LibXGrid1.refreshFooter()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub xlk_cust_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_cust_code.BeforeExecuteQuery
        Try
            If LibXConnector1.IsDataEditing = True Then
                If mTipoDocumento = "RCB" Then
                    mTipoDocumento = xcbo_type_code.currValue()
                End If

                If mTipoDocumento = "RCB" Then
                    e.aditionalWhere = "cccustm.csttype_code not in(4,5) "
                End If

                If mTipoDocumento = "RSM" Then
                    e.aditionalWhere = "cccustm.csttype_code = 5 "
                End If

                If mTipoDocumento = "DCC" Then
                    e.aditionalWhere = "cccustm.csttype_code = 4 "
                End If
            End If

        Catch ex As Exception
            e.handled = True
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXNavigator1_ActionClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.ActionClick
        Dim xUpdate As LibX.Data.XUpdateStmt
        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Delete Then
                If LibX.Data.Manager.Connection.IsIntransaction = False Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                End If

                xUpdate = New LibX.Data.XUpdateStmt("ccpaymm")
                xUpdate.FieldsSet("invce_status") = 0
                xUpdate.Fields("paym_serial") = LibXConnector1.CurrentDataRow!paym_serial
                xUpdate.Execute()

                xUpdate = New LibX.Data.XUpdateStmt("ccpaymd")
                xUpdate.FieldsSet("paym_status") = 0
                xUpdate.Fields("paym_serial") = LibXConnector1.CurrentDataRow!paym_serial
                xUpdate.Execute()

                If LibX.Data.Manager.Connection.IsIntransaction = True Then
                    LibX.Data.Manager.Connection.CommitTransaction()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
        End Try
    End Sub
    Private Sub xdtp_paym_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xdtp_paym_date.ValueChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                If xdtp_paym_date.Value > LibX.Data.Manager.GetScalar("select getdate()") Then
                    xdtp_paym_date.Value = LibX.Data.Manager.GetScalar("select getdate()")
                    Throw New ApplicationException("La fecha no debe ser mayor que la fecha del dia!")
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub xtxaplicado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xtxaplicado.TextChanged
        If Val(Me.xtxaplicado.Text) > 0 Then
            If Me.xtxtdscto.Text = "" Then
                Me.xtxtdscto.Text = 0
            End If
            Me.txtAmount.Text = CDbl(Me.xtxaplicado.Text) - CDbl(Me.xtxtdscto.Text)
            Me.txtPendiente.Text = Me.xtxaplicado.Text
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormulario.Click
        Dim fhumano As Excel.Application
        Dim Archivo As String
        Dim rnc As String
        Dim sPer As String
        Dim oTable As DataTable
        Dim SelecStmt As String
        Dim sFechaDesde As String
        Dim sFechaHasta As String
        Dim sprov As String
        Dim sTipo As String
        Dim sSuc As String
        Dim sWhere As String

        Try
            SelecStmt = " select * from vw_seguroform where paym_serial =" & LibXConnector1.CurrentDataRow!paym_serial
            ''SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)

            oTable = LibX.Data.Manager.GetDataTable(SelecStmt)

            If oTable Is Nothing Then
                Throw New ApplicationException("No hay transacciones para este periodo")
            End If

            ''rnc = LibX.Data.Manager.GetScalar("select comp_rnc from stinform")

            fhumano = New Excel.Application
            Archivo = System.Configuration.ConfigurationSettings.AppSettings.Get("LSeguro").ToString.Trim
            Dim xfhumanoOpen As Excel.Workbooks = fhumano.Workbooks
            Dim xfhumanoAdd As Excel.Workbook = xfhumanoOpen.Open(Archivo)
            Dim xfhumanoRead As Excel.Sheets = xfhumanoAdd.Worksheets
            Dim xfhumanoWrhite As Excel.Worksheet = xfhumanoRead(1)
            xfhumanoWrhite.Unprotect("REDSOFT")
            ''xfhumanoAdd.Unprotect("REDSOFT")
            Dim fecha As DateTime
            Dim fechaPago As DateTime

            xfhumanoWrhite.Range("B4").Value = oTable.Rows(0)!cia_codigo
            xfhumanoWrhite.Range("D4").Value = oTable.Rows(0)!comp_nombre

            Dim linea As Integer = 8
            Dim sQty As Integer = oTable.Rows.Count

            For Each oRow As DataRow In oTable.Rows
                xfhumanoWrhite.Range("A" & linea).Value = oRow!segr_autorizacion
                xfhumanoWrhite.Range("B" & linea).Value = oRow!fecha_servicio
                xfhumanoWrhite.Range("C" & linea).Value = oRow!aseg_poliza
                xfhumanoWrhite.Range("D" & linea).Value = oRow!aseg_nombre
                xfhumanoWrhite.Range("E" & linea).Value = oRow!aseg_cedula
                xfhumanoWrhite.Range("F" & linea).Value = oRow!fact_total
                xfhumanoWrhite.Range("G" & linea).Value = oRow!cia_amount
                xfhumanoWrhite.Range("H" & linea).Value = oRow!empl_amount
                xfhumanoWrhite.Range("I" & linea).Value = oRow!fact_number
                xfhumanoWrhite.Range("J" & linea).Value = oRow!fact_date
                xfhumanoWrhite.Range("K" & linea).Value = oRow!tipo_servicio
                xfhumanoWrhite.Range("L" & linea).Value = oRow!sub_servicio
                xfhumanoWrhite.Range("M" & linea).Value = oRow!invce_ncf
                xfhumanoWrhite.Range("N" & linea).Value = oRow!invce_date
                If (oRow!tipo_ncf).ToString.Trim = "01" Then
                    xfhumanoWrhite.Range("O" & linea).Value = "CREDITO FISCAL"
                End If
                If (oRow!tipo_ncf).ToString.Trim = "02" Then
                    xfhumanoWrhite.Range("O" & linea).Value = "CONSUMIDOR FINAL"
                End If
                If (oRow!tipo_ncf).ToString.Trim = "15" Then
                    xfhumanoWrhite.Range("O" & linea).Value = "GUBERNAMENTAL"
                End If
                xfhumanoWrhite.Range("P" & linea).Value = ""
                xfhumanoWrhite.Range("Q" & linea).Value = ""
                xfhumanoWrhite.Range("R" & linea).Value = ""
                xfhumanoWrhite.Range("S" & linea).Value = ""
                xfhumanoWrhite.Range("T" & linea).Value = ""

                linea = linea + 1
            Next
            xfhumanoWrhite.Range("J2").Value = sQty
            fhumano.Visible = True
            xfhumanoWrhite.SaveAs("C:\FHUMANO\" & "DN-" & oTable.Rows(0)!cia_codigo & GetFileName() & ".xls")

            'xfhumanoWrhite.SaveAs("C:\FHUMANO\" & oTable.Rows(0)!cia_codigo & oTable.Rows(0)!invce_date & ".xls")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Function GetFileName() As String
        Dim FileName As String

        'FileName = "DN-" & LibXConnector1.CurrentDataRow!paym_number.ToString.Trim & "-" & _
        FileName = "-" & _
                   CType(LibXConnector1.CurrentDataRow!invce_date, Date).Year.ToString.Trim & _
                   CType(LibXConnector1.CurrentDataRow!invce_date, Date).Month.ToString.Trim & _
                   CType(LibXConnector1.CurrentDataRow!invce_date, Date).Day.ToString.Trim

        Return FileName
    End Function

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub xtxtdscto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xtxtdscto.TextChanged

    End Sub

    Private Sub LibxDateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If txtcust_code.Text.Trim <> String.Empty Then
                DocumentosPendientes(txtcust_code.Text)
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
