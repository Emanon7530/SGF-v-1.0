Imports SGT.Inventario
Imports SGT.Inventario.Entidades
Imports SGT.CXC.Posteos
Imports SGT.Caja.Entidades
Imports LibX
Imports SGT.PuntodeVenta.Entidades

Public Class i_ptvrecib01
    Inherits System.Windows.Forms.Form
    Dim oDocument As Documento
    Dim Accion As Integer
    Dim mResta As Decimal
    Dim Porc_mora As Decimal
    Dim WhDefault As Integer
    Dim MontoDigitado As Boolean
    Dim oCaja As Caja
    Dim oCajera As Cajera
    Dim oCajaAbierta As CajaAbierta
    Dim oDocumento As SGT.Inventario.Entidades.Documento
    Dim mTipoDocumento As String = "RCB"
    Dim oParamValidar As SGT.Administracion.Entidades.Permission.ParametrosValidar
    Dim oAutorizar As SGT.Administracion.Entidades.Permission
    Dim oTermino As SGT.CXC.Entidades.Termino
    Dim oBoton As Integer
    Dim mDigitado As Boolean = False
    Dim mApli As Decimal
    Dim mCobrar As Decimal
    Dim pdscto As Decimal
    Dim Descuenxtxaplicadoto As String

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
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents balance As LibX.XTextBox
    Friend WithEvents xlk_cust_code As LibX.LibXLookup
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents xdtp_paym_date As LibX.LibxDateTimePicker
    Friend WithEvents xcbo_paym_status As LibX.LibXCombo
    Friend WithEvents gColAplAmount As LibX.XEditTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gColAmount As LibX.XEditTextBoxColumn
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
    Friend WithEvents ccpaymd As System.Data.DataTable
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents gColBalance As LibX.XEditTextBoxColumn
    Friend WithEvents txtPaym_number As LibX.XTextBox
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents xed_Tipo As LibX.XEditTextBoxColumn
    Friend WithEvents xed_number As LibX.XEditTextBoxColumn
    Friend WithEvents btnPagos As System.Windows.Forms.Button
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents gColItbis As LibX.XEditTextBoxColumn
    Friend WithEvents btnVisualizar As System.Windows.Forms.Button
    Friend WithEvents gColDescto1 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents txtcust_code As LibX.XTextBox
    Friend WithEvents btnDistribucion As System.Windows.Forms.Button
    Friend WithEvents xlk_caje_code As LibX.LibXLookup
    Friend WithEvents xlk_caja_code As LibX.LibXLookup
    Friend WithEvents labecaje_name As System.Windows.Forms.Label
    Friend WithEvents xtxt_caje_code As LibX.XTextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents labelcaja_name As System.Windows.Forms.Label
    Friend WithEvents xtxt_caja_code As LibX.XTextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents XTextBox13 As LibX.XMaskEdit
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnCheque As System.Windows.Forms.Button
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents gColtotal_amount As LibX.XEditTextBoxColumn
    Friend WithEvents XTextBox11 As LibX.XMaskEdit
    Friend WithEvents XTextBox12 As LibX.XMaskEdit
    Friend WithEvents xtxt_fact_nota As LibX.XTextBox
    Friend WithEvents btnTarjeta As System.Windows.Forms.Button
    Friend WithEvents cust_name As System.Windows.Forms.Label
    Friend WithEvents gColFecha As LibX.XEditTextBoxColumn
    Friend WithEvents gColVence As LibX.XEditTextBoxColumn
    Friend WithEvents gColDias As LibX.XEditTextBoxColumn
    Friend WithEvents gColDescuento As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAplicarDesc As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRemoverDesc As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAplicar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDesaplicar As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents xtxt_Balance1 As LibX.XTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblTermino As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPendiente As System.Windows.Forms.Label
    Friend WithEvents gColterm_code As LibX.XEditTextBoxColumn
    Friend WithEvents gColdesc_date As LibX.XEditTextBoxColumn
    Friend WithEvents btnIncluirPP As System.Windows.Forms.Button
    Friend WithEvents btnRemoverPP As System.Windows.Forms.Button
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
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
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
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
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents xtxdscto As LibX.XTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents ftfactm As System.Data.DataTable
    Friend WithEvents txtAmount As LibX.XTextBox
    Friend WithEvents xtxaplicado As LibX.XTextBox
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ccpaymd = New System.Data.DataTable
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
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.DataColumn61 = New System.Data.DataColumn
        Me.DataColumn62 = New System.Data.DataColumn
        Me.DataColumn68 = New System.Data.DataColumn
        Me.DataColumn69 = New System.Data.DataColumn
        Me.DataColumn70 = New System.Data.DataColumn
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
        Me.DataColumn22 = New System.Data.DataColumn
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
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
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
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn63 = New System.Data.DataColumn
        Me.DataColumn64 = New System.Data.DataColumn
        Me.DataColumn65 = New System.Data.DataColumn
        Me.DataColumn66 = New System.Data.DataColumn
        Me.DataColumn67 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.DataColumn71 = New System.Data.DataColumn
        Me.xtxt_fact_nota = New LibX.XTextBox
        Me.xtxt_caja_code = New LibX.XTextBox
        Me.txtcust_code = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtAmount = New LibX.XTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.xtxdscto = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.xtxt_Balance1 = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cust_name = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.XTextBox11 = New LibX.XMaskEdit
        Me.XTextBox12 = New LibX.XMaskEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.XTextBox13 = New LibX.XMaskEdit
        Me.Label23 = New System.Windows.Forms.Label
        Me.btnCheque = New System.Windows.Forms.Button
        Me.btnTarjeta = New System.Windows.Forms.Button
        Me.xlk_caje_code = New LibX.LibXLookup
        Me.xlk_caja_code = New LibX.LibXLookup
        Me.labecaje_name = New System.Windows.Forms.Label
        Me.xtxt_caje_code = New LibX.XTextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.labelcaja_name = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtPaym_number = New LibX.XTextBox
        Me.xlk_cust_code = New LibX.LibXLookup
        Me.xdtp_paym_date = New LibX.LibxDateTimePicker
        Me.xcbo_paym_status = New LibX.LibXCombo
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.balance = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.xtxaplicado = New LibX.XTextBox
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
        Me.gColDias = New LibX.XEditTextBoxColumn
        Me.gColAmount = New LibX.XEditTextBoxColumn
        Me.gColDescuento = New LibX.XEditTextBoxColumn
        Me.gColItbis = New LibX.XEditTextBoxColumn
        Me.gColtotal_amount = New LibX.XEditTextBoxColumn
        Me.gColBalance = New LibX.XEditTextBoxColumn
        Me.gColDescto1 = New LibX.XEditTextBoxColumn
        Me.gColAplAmount = New LibX.XEditTextBoxColumn
        Me.gColterm_code = New LibX.XEditTextBoxColumn
        Me.gColdesc_date = New LibX.XEditTextBoxColumn
        Me.DataView1 = New System.Data.DataView
        Me.btnVisualizar = New System.Windows.Forms.Button
        Me.btnPagos = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnDistribucion = New System.Windows.Forms.Button
        Me.btnAplicar = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblTermino = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtPendiente = New System.Windows.Forms.Label
        Me.btnIncluirPP = New System.Windows.Forms.Button
        Me.btnRemoverPP = New System.Windows.Forms.Button
        Me.DataColumn72 = New System.Data.DataColumn
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccpaymd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_fact_nota
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_caja_code
        Me.LibXNavigator1.FirstControlInNewMode = Nothing
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(962, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = True
        Me.LibXConnector1.AllowEdit = False
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
        Me.LibXConnector1.ModuleName = "PTV"
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = "r_pvrecib01.rpt"
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ccpaymd, Me.ftfactm})
        '
        'ccpaymd
        '
        Me.ccpaymd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn38, Me.DataColumn41, Me.DataColumn23, Me.DataColumn55, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70})
        Me.ccpaymd.TableName = "ccpaymd"
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "paym_serial"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.AutoIncrement = True
        Me.DataColumn11.AutoIncrementSeed = CType(1, Long)
        Me.DataColumn11.ColumnName = "line_no"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "invce_serial"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "invce_no"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "invce_date"
        Me.DataColumn14.DataType = GetType(System.DateTime)
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "invce_amount"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "due_date"
        Me.DataColumn16.DataType = GetType(System.DateTime)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "dias"
        Me.DataColumn17.DataType = GetType(System.Int32)
        Me.DataColumn17.ReadOnly = True
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "balance"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "amount"
        Me.DataColumn19.DataType = GetType(System.Decimal)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "Aplicar"
        Me.DataColumn20.DataType = GetType(System.Int16)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "type_code"
        Me.DataColumn21.MaxLength = 3
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "pay_mora"
        Me.DataColumn38.DataType = GetType(System.Decimal)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "itbis_amount"
        Me.DataColumn41.DataType = GetType(System.Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "disc_amount"
        Me.DataColumn23.DataType = GetType(System.Decimal)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "total_amount"
        Me.DataColumn55.DataType = GetType(System.Decimal)
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "cargo_desc"
        Me.DataColumn60.DataType = GetType(System.Decimal)
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "term_code"
        Me.DataColumn61.MaxLength = 5
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "disc_date"
        Me.DataColumn62.DataType = GetType(System.DateTime)
        '
        'DataColumn68
        '
        Me.DataColumn68.AllowDBNull = False
        Me.DataColumn68.ColumnName = "suc_code"
        Me.DataColumn68.DataType = GetType(System.Int32)
        '
        'DataColumn69
        '
        Me.DataColumn69.AllowDBNull = False
        Me.DataColumn69.ColumnName = "mod_type"
        Me.DataColumn69.MaxLength = 3
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "paym_status"
        Me.DataColumn70.DataType = GetType(System.Int32)
        '
        'ftfactm
        '
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn22, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn39, Me.DataColumn40, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn71, Me.DataColumn72})
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
        Me.DataColumn8.ColumnName = "fact_number"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "fact_date"
        Me.DataColumn9.DataType = GetType(System.DateTime)
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "fact_total"
        Me.DataColumn22.DataType = GetType(System.Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "descto"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "itbis"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "userid"
        Me.DataColumn26.MaxLength = 20
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "fact_status"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "date_created"
        Me.DataColumn28.DataType = GetType(System.DateTime)
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "type_code"
        Me.DataColumn29.MaxLength = 3
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "cust_code"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.AllowDBNull = False
        Me.DataColumn31.ColumnName = "fact_cond"
        Me.DataColumn31.DataType = GetType(System.Int16)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "bus_name"
        Me.DataColumn32.MaxLength = 100
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "fact_nota"
        Me.DataColumn33.MaxLength = 80
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "ftserial_afect"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "pay_adelant"
        Me.DataColumn35.DataType = GetType(System.Int32)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "phone"
        Me.DataColumn36.MaxLength = 13
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "pay_mora"
        Me.DataColumn37.DataType = GetType(System.Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "porc_comision"
        Me.DataColumn39.DataType = GetType(System.Decimal)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "fact_ncf"
        Me.DataColumn40.MaxLength = 40
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "caja_code"
        Me.DataColumn42.DataType = GetType(System.Int32)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "caje_code"
        Me.DataColumn43.DataType = GetType(System.Int32)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "init_serial"
        Me.DataColumn44.DataType = GetType(System.Int32)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "fact_inddomicilio"
        Me.DataColumn45.DataType = GetType(System.Int32)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "address"
        Me.DataColumn46.MaxLength = 200
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "seg_amount"
        Me.DataColumn47.DataType = GetType(System.Decimal)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "prov_code"
        Me.DataColumn48.DataType = GetType(System.Int32)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "fact_impresa"
        Me.DataColumn49.DataType = GetType(System.Int32)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "cust_serial"
        Me.DataColumn50.DataType = GetType(System.Int32)
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "flete_amount"
        Me.DataColumn51.DataType = GetType(System.Decimal)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "orden_numero"
        Me.DataColumn52.MaxLength = 20
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "fact_costo"
        Me.DataColumn53.DataType = GetType(System.Int32)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "fact_mayor"
        Me.DataColumn54.DataType = GetType(System.Int32)
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "init_serial1"
        Me.DataColumn56.DataType = GetType(System.Int32)
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "efectivo"
        Me.DataColumn57.DataType = GetType(System.Decimal)
        Me.DataColumn57.ReadOnly = True
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "tarjeta"
        Me.DataColumn58.DataType = GetType(System.Decimal)
        Me.DataColumn58.ReadOnly = True
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "cheque"
        Me.DataColumn59.DataType = GetType(System.Decimal)
        Me.DataColumn59.ReadOnly = True
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "chk_code"
        Me.DataColumn63.DataType = GetType(System.Int32)
        Me.DataColumn63.ReadOnly = True
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "fact_time"
        Me.DataColumn64.MaxLength = 12
        '
        'DataColumn65
        '
        Me.DataColumn65.AllowDBNull = False
        Me.DataColumn65.ColumnName = "suc_code"
        Me.DataColumn65.DataType = GetType(System.Int32)
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "fact_create"
        Me.DataColumn66.DataType = GetType(System.DateTime)
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "fact_neto"
        Me.DataColumn67.DataType = GetType(System.Decimal)
        Me.DataColumn67.ReadOnly = True
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
        Me.LibXDbSourceTable1.InnerJon = False
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "ftserial_no"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"SELECT", "ftfactm.*,", "(ftfactm.fact_total - isnull(ftfactm.descto,0)) fact_neto,", "cjtranrv.init_serial,", "cjtranrv.efectivo,", "cjtranrv.tarjeta,", "cjtranrv.cheque,", "cjtranrv.chk_code,", "ftfactm.ncf_type" & Microsoft.VisualBasic.ChrW(9), "from ftfactm ", "left outer join cjtranrv  ", "on  ftfactm.ftserial_no = cjtranrv.ftserial_no "}
        Me.LibXDbSourceTable1.TableName = "ftfactm"
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
        Me.LibXDbSourceTable2.InnerJon = False
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"paym_serial=ftserial_no"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select ccpaymd.paym_serial,", "       ccpaymd.line_no,", "       ccpaymd.suc_code,", "       ccpaymd.invce_serial,", "       ccinvcem.type_code,", "       ccinvcem.invce_no,", "       ccinvcem.invce_date,", "       ccinvcem.term_code,", "       ccinvcem.amount invce_amount,", "       ccinvcem.cargo_desc,", "       ccinvcem.total_amount,", "       ccopend.due_date,", "       datediff(day,ccinvcem.invce_date,", "                    ccopend.due_date) dias,", "       ccpaymd.disc_amount,", "       ccpaymd.balance,", "       ccpaymd.amount,", "       ccpaymd.pay_mora,", "      ccpaymd.itbis_amount,", "      ccopend.disc_date,", "      ccpaymd.mod_type,", "      ccpaymd.paym_status", "  from ccpaymd inner join ccinvcem", "    on ccpaymd.invce_serial = ccinvcem.invce_serial", " inner join ccopend ", "    on ccpaymd.invce_serial = ccopend.invce_serial", "where mod_type ='PTV'"}
        Me.LibXDbSourceTable2.TableName = "ccpaymd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "ncf_type"
        Me.DataColumn71.DataType = GetType(System.Int32)
        '
        'xtxt_fact_nota
        '
        Me.xtxt_fact_nota.AcceptsReturn = True
        Me.xtxt_fact_nota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_nota"))
        Me.xtxt_fact_nota.EditInitialValue = Nothing
        Me.xtxt_fact_nota.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_fact_nota.FieldDescription = ""
        Me.xtxt_fact_nota.FindInitialValue = Nothing
        Me.xtxt_fact_nota.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_fact_nota.IgnoreRequiered = False
        Me.xtxt_fact_nota.Location = New System.Drawing.Point(72, 112)
        Me.xtxt_fact_nota.Multiline = True
        Me.xtxt_fact_nota.Name = "xtxt_fact_nota"
        Me.xtxt_fact_nota.NewInitialValue = Nothing
        Me.xtxt_fact_nota.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_fact_nota.Requiered = False
        Me.xtxt_fact_nota.Size = New System.Drawing.Size(392, 64)
        Me.xtxt_fact_nota.StatusBarPanelDescripcion = Nothing
        Me.xtxt_fact_nota.TabIndex = 3
        Me.xtxt_fact_nota.Text = ""
        '
        'xtxt_caja_code
        '
        Me.xtxt_caja_code.AcceptsReturn = True
        Me.xtxt_caja_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.caja_code"))
        Me.xtxt_caja_code.EditInitialValue = Nothing
        Me.xtxt_caja_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_caja_code.FieldDescription = "Digite el codigo de la caja"
        Me.xtxt_caja_code.FindInitialValue = Nothing
        Me.xtxt_caja_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_caja_code.IgnoreRequiered = False
        Me.xtxt_caja_code.Location = New System.Drawing.Point(72, 16)
        Me.xtxt_caja_code.Name = "xtxt_caja_code"
        Me.xtxt_caja_code.NewInitialValue = Nothing
        Me.xtxt_caja_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_caja_code.Requiered = False
        Me.xtxt_caja_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_caja_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_caja_code.TabIndex = 0
        Me.xtxt_caja_code.Text = ""
        '
        'txtcust_code
        '
        Me.txtcust_code.AcceptsReturn = True
        Me.txtcust_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.cust_code"))
        Me.txtcust_code.EditInitialValue = Nothing
        Me.txtcust_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcust_code.FieldDescription = ""
        Me.txtcust_code.FindInitialValue = Nothing
        Me.txtcust_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcust_code.IgnoreRequiered = False
        Me.txtcust_code.Location = New System.Drawing.Point(72, 64)
        Me.txtcust_code.Name = "txtcust_code"
        Me.txtcust_code.NewInitialValue = Nothing
        Me.txtcust_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcust_code.Requiered = False
        Me.txtcust_code.Size = New System.Drawing.Size(56, 20)
        Me.txtcust_code.StatusBarPanelDescripcion = Nothing
        Me.txtcust_code.TabIndex = 0
        Me.txtcust_code.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.xtxdscto)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.xtxt_Balance1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cust_name)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.xlk_caje_code)
        Me.GroupBox1.Controls.Add(Me.xlk_caja_code)
        Me.GroupBox1.Controls.Add(Me.labecaje_name)
        Me.GroupBox1.Controls.Add(Me.xtxt_caje_code)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.labelcaja_name)
        Me.GroupBox1.Controls.Add(Me.xtxt_caja_code)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.txtPaym_number)
        Me.GroupBox1.Controls.Add(Me.xlk_cust_code)
        Me.GroupBox1.Controls.Add(Me.xdtp_paym_date)
        Me.GroupBox1.Controls.Add(Me.xcbo_paym_status)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcust_code)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.balance)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xtxaplicado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xtxt_fact_nota)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(944, 184)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtAmount
        '
        Me.txtAmount.AcceptsReturn = True
        Me.txtAmount.EditInitialValue = Nothing
        Me.txtAmount.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtAmount.Enabled = False
        Me.txtAmount.FieldDescription = ""
        Me.txtAmount.FindInitialValue = Nothing
        Me.txtAmount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.IgnoreRequiered = False
        Me.txtAmount.Location = New System.Drawing.Point(584, 136)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.NewInitialValue = Nothing
        Me.txtAmount.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtAmount.Requiered = False
        Me.txtAmount.Size = New System.Drawing.Size(136, 32)
        Me.txtAmount.StatusBarPanelDescripcion = Nothing
        Me.txtAmount.TabIndex = 52
        Me.txtAmount.Text = ""
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(501, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 22)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "A Cobrar:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxdscto
        '
        Me.xtxdscto.AcceptsReturn = True
        Me.xtxdscto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.descto"))
        Me.xtxdscto.EditInitialValue = Nothing
        Me.xtxdscto.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxdscto.FieldDescription = ""
        Me.xtxdscto.FindInitialValue = Nothing
        Me.xtxdscto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxdscto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxdscto.IgnoreRequiered = False
        Me.xtxdscto.Location = New System.Drawing.Point(584, 112)
        Me.xtxdscto.Name = "xtxdscto"
        Me.xtxdscto.NewInitialValue = Nothing
        Me.xtxdscto.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxdscto.Requiered = False
        Me.xtxdscto.Size = New System.Drawing.Size(136, 23)
        Me.xtxdscto.StatusBarPanelDescripcion = Nothing
        Me.xtxdscto.TabIndex = 50
        Me.xtxdscto.Text = ""
        Me.xtxdscto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(488, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 22)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Descuento:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.xtxt_Balance1.Location = New System.Drawing.Point(360, 88)
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
        Me.Label10.Location = New System.Drawing.Point(248, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Balance con Desc.:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cust_name
        '
        Me.cust_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cust_name.Location = New System.Drawing.Point(136, 64)
        Me.cust_name.Name = "cust_name"
        Me.cust_name.Size = New System.Drawing.Size(312, 20)
        Me.cust_name.TabIndex = 46
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.XTextBox11)
        Me.GroupBox3.Controls.Add(Me.XTextBox12)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.XTextBox13)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.btnCheque)
        Me.GroupBox3.Controls.Add(Me.btnTarjeta)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Location = New System.Drawing.Point(728, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(208, 120)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Forma de Pago"
        '
        'XTextBox11
        '
        Me.XTextBox11.AcceptsReturn = True
        Me.XTextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.efectivo"))
        Me.XTextBox11.EditInitialValue = Nothing
        Me.XTextBox11.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox11.FieldDescription = ""
        Me.XTextBox11.FindInitialValue = Nothing
        Me.XTextBox11.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTextBox11.IgnoreRequiered = False
        Me.XTextBox11.Location = New System.Drawing.Point(88, 16)
        Me.XTextBox11.Masked = MaskedTextBox.Mask.Decimal
        Me.XTextBox11.Name = "XTextBox11"
        Me.XTextBox11.NewInitialValue = Nothing
        Me.XTextBox11.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox11.Requiered = False
        Me.XTextBox11.Size = New System.Drawing.Size(112, 23)
        Me.XTextBox11.StatusBarPanelDescripcion = Nothing
        Me.XTextBox11.TabIndex = 0
        Me.XTextBox11.Text = ""
        Me.XTextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'XTextBox12
        '
        Me.XTextBox12.AcceptsReturn = True
        Me.XTextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.tarjeta"))
        Me.XTextBox12.EditInitialValue = Nothing
        Me.XTextBox12.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox12.FieldDescription = ""
        Me.XTextBox12.FindInitialValue = Nothing
        Me.XTextBox12.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTextBox12.IgnoreRequiered = False
        Me.XTextBox12.Location = New System.Drawing.Point(88, 48)
        Me.XTextBox12.Masked = MaskedTextBox.Mask.Decimal
        Me.XTextBox12.Name = "XTextBox12"
        Me.XTextBox12.NewInitialValue = Nothing
        Me.XTextBox12.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox12.Requiered = False
        Me.XTextBox12.Size = New System.Drawing.Size(88, 26)
        Me.XTextBox12.StatusBarPanelDescripcion = Nothing
        Me.XTextBox12.TabIndex = 1
        Me.XTextBox12.Text = ""
        Me.XTextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(7, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 22)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "Efectivo:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(14, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 22)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "Tarjeta:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox13
        '
        Me.XTextBox13.AcceptsReturn = True
        Me.XTextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.cheque"))
        Me.XTextBox13.EditInitialValue = Nothing
        Me.XTextBox13.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox13.FieldDescription = ""
        Me.XTextBox13.FindInitialValue = Nothing
        Me.XTextBox13.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTextBox13.IgnoreRequiered = False
        Me.XTextBox13.Location = New System.Drawing.Point(88, 80)
        Me.XTextBox13.Masked = MaskedTextBox.Mask.None
        Me.XTextBox13.Name = "XTextBox13"
        Me.XTextBox13.NewInitialValue = Nothing
        Me.XTextBox13.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox13.Requiered = False
        Me.XTextBox13.Size = New System.Drawing.Size(88, 26)
        Me.XTextBox13.StatusBarPanelDescripcion = Nothing
        Me.XTextBox13.TabIndex = 2
        Me.XTextBox13.Text = ""
        Me.XTextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 80)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 22)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Cheque:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCheque
        '
        Me.btnCheque.Enabled = False
        Me.btnCheque.Location = New System.Drawing.Point(176, 80)
        Me.btnCheque.Name = "btnCheque"
        Me.btnCheque.Size = New System.Drawing.Size(24, 20)
        Me.btnCheque.TabIndex = 3
        Me.btnCheque.Text = "..."
        '
        'btnTarjeta
        '
        Me.btnTarjeta.Enabled = False
        Me.btnTarjeta.Location = New System.Drawing.Point(176, 48)
        Me.btnTarjeta.Name = "btnTarjeta"
        Me.btnTarjeta.Size = New System.Drawing.Size(24, 20)
        Me.btnTarjeta.TabIndex = 3
        Me.btnTarjeta.Text = "..."
        '
        'xlk_caje_code
        '
        Me.xlk_caje_code.AlternateFieldSearch = Nothing
        Me.xlk_caje_code.BeginCheck = False
        Me.xlk_caje_code.CheckText = Nothing
        Me.xlk_caje_code.ComboMode = False
        Me.xlk_caje_code.DataMember = Nothing
        Me.xlk_caje_code.DataSource = Me.LibXConnector1
        Me.xlk_caje_code.DestParameters = New String() {"caje_code=vend_code", "labecaje_name=vend_name"}
        Me.xlk_caje_code.FilterField = "vend_name"
        Me.xlk_caje_code.IgnoreFindInBrowseMode = False
        Me.xlk_caje_code.isCanceled = False
        Me.xlk_caje_code.Location = New System.Drawing.Point(448, 40)
        Me.xlk_caje_code.LookCaption = "Cajeras"
        Me.xlk_caje_code.Name = "xlk_caje_code"
        Me.xlk_caje_code.PopupSize = New System.Drawing.Size(400, 300)
        Me.xlk_caje_code.ShowFilter = True
        Me.xlk_caje_code.ShowMessageNotFound = True
        Me.xlk_caje_code.ShowWarning = False
        Me.xlk_caje_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_caje_code.SizesColumns = Nothing
        Me.xlk_caje_code.SizesColumnsTab = Nothing
        Me.xlk_caje_code.SqlString = Nothing
        Me.xlk_caje_code.SQLTab = Nothing
        Me.xlk_caje_code.SrcParameters = New String() {"caje_code=vend_code"}
        Me.xlk_caje_code.TabIndex = 44
        Me.xlk_caje_code.TableName = "ftvendm"
        Me.xlk_caje_code.TabStop = False
        Me.xlk_caje_code.UseCopyConnection = False
        Me.xlk_caje_code.UseRowRetrieveEvents = False
        Me.xlk_caje_code.UseTab = False
        Me.xlk_caje_code.VisParameters = New String() {"Código=vend_code", "Nombre=vend_name"}
        Me.xlk_caje_code.WhereCondition = "vend_cargo = 1"
        Me.xlk_caje_code.WhereParameters = Nothing
        '
        'xlk_caja_code
        '
        Me.xlk_caja_code.AlternateFieldSearch = Nothing
        Me.xlk_caja_code.BeginCheck = False
        Me.xlk_caja_code.CheckText = Nothing
        Me.xlk_caja_code.ComboMode = False
        Me.xlk_caja_code.DataMember = Nothing
        Me.xlk_caja_code.DataSource = Me.LibXConnector1
        Me.xlk_caja_code.DestParameters = New String() {"caja_code=caja_code", "labelcaja_name=caja_name"}
        Me.xlk_caja_code.FilterField = "caja_name"
        Me.xlk_caja_code.IgnoreFindInBrowseMode = False
        Me.xlk_caja_code.isCanceled = False
        Me.xlk_caja_code.Location = New System.Drawing.Point(448, 16)
        Me.xlk_caja_code.LookCaption = "Listado de Cajas"
        Me.xlk_caja_code.Name = "xlk_caja_code"
        Me.xlk_caja_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_caja_code.ShowFilter = True
        Me.xlk_caja_code.ShowMessageNotFound = True
        Me.xlk_caja_code.ShowWarning = False
        Me.xlk_caja_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_caja_code.SizesColumns = Nothing
        Me.xlk_caja_code.SizesColumnsTab = Nothing
        Me.xlk_caja_code.SqlString = Nothing
        Me.xlk_caja_code.SQLTab = Nothing
        Me.xlk_caja_code.SrcParameters = New String() {"caja_code=caja_code"}
        Me.xlk_caja_code.TabIndex = 43
        Me.xlk_caja_code.TableName = "cjcajam"
        Me.xlk_caja_code.TabStop = False
        Me.xlk_caja_code.UseCopyConnection = False
        Me.xlk_caja_code.UseRowRetrieveEvents = False
        Me.xlk_caja_code.UseTab = False
        Me.xlk_caja_code.VisParameters = New String() {"Código=caja_code", "Nombre=caja_name"}
        Me.xlk_caja_code.WhereCondition = Nothing
        Me.xlk_caja_code.WhereParameters = Nothing
        '
        'labecaje_name
        '
        Me.labecaje_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labecaje_name.Location = New System.Drawing.Point(136, 40)
        Me.labecaje_name.Name = "labecaje_name"
        Me.labecaje_name.Size = New System.Drawing.Size(312, 20)
        Me.labecaje_name.TabIndex = 42
        '
        'xtxt_caje_code
        '
        Me.xtxt_caje_code.AcceptsReturn = True
        Me.xtxt_caje_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.caje_code"))
        Me.xtxt_caje_code.EditInitialValue = Nothing
        Me.xtxt_caje_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_caje_code.FieldDescription = "Digite el codigo de la cajera"
        Me.xtxt_caje_code.FindInitialValue = Nothing
        Me.xtxt_caje_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_caje_code.IgnoreRequiered = False
        Me.xtxt_caje_code.Location = New System.Drawing.Point(72, 40)
        Me.xtxt_caje_code.Name = "xtxt_caje_code"
        Me.xtxt_caje_code.NewInitialValue = Nothing
        Me.xtxt_caje_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_caje_code.Requiered = False
        Me.xtxt_caje_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_caje_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_caje_code.TabIndex = 1
        Me.xtxt_caje_code.Text = ""
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(15, 40)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(41, 16)
        Me.Label34.TabIndex = 41
        Me.Label34.Text = "Cajera:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'labelcaja_name
        '
        Me.labelcaja_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelcaja_name.Location = New System.Drawing.Point(136, 16)
        Me.labelcaja_name.Name = "labelcaja_name"
        Me.labelcaja_name.Size = New System.Drawing.Size(312, 20)
        Me.labelcaja_name.TabIndex = 40
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(25, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(31, 16)
        Me.Label32.TabIndex = 39
        Me.Label32.Text = "Caja:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPaym_number
        '
        Me.txtPaym_number.AcceptsReturn = True
        Me.txtPaym_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_number"))
        Me.txtPaym_number.EditInitialValue = Nothing
        Me.txtPaym_number.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtPaym_number.FieldDescription = ""
        Me.txtPaym_number.FindInitialValue = Nothing
        Me.txtPaym_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPaym_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaym_number.IgnoreRequiered = True
        Me.txtPaym_number.Location = New System.Drawing.Point(584, 16)
        Me.txtPaym_number.Name = "txtPaym_number"
        Me.txtPaym_number.NewInitialValue = Nothing
        Me.txtPaym_number.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtPaym_number.Requiered = False
        Me.txtPaym_number.Size = New System.Drawing.Size(136, 26)
        Me.txtPaym_number.StatusBarPanelDescripcion = Nothing
        Me.txtPaym_number.TabIndex = 4
        Me.txtPaym_number.Text = ""
        '
        'xlk_cust_code
        '
        Me.xlk_cust_code.AlternateFieldSearch = Nothing
        Me.xlk_cust_code.BeginCheck = True
        Me.xlk_cust_code.CheckText = Nothing
        Me.xlk_cust_code.ComboMode = False
        Me.xlk_cust_code.DataMember = "ftfactm"
        Me.xlk_cust_code.DataSource = Me.LibXConnector1
        Me.xlk_cust_code.DestParameters = New String() {"cust_code=cust_code", "cust_name=cust_name", "balance=balance"}
        Me.xlk_cust_code.FilterField = "cust_name"
        Me.xlk_cust_code.IgnoreFindInBrowseMode = False
        Me.xlk_cust_code.isCanceled = False
        Me.xlk_cust_code.Location = New System.Drawing.Point(448, 64)
        Me.xlk_cust_code.LookCaption = "Clientes"
        Me.xlk_cust_code.Name = "xlk_cust_code"
        Me.xlk_cust_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_cust_code.ShowFilter = True
        Me.xlk_cust_code.ShowMessageNotFound = False
        Me.xlk_cust_code.ShowWarning = False
        Me.xlk_cust_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_cust_code.SizesColumns = New String() {"cust_name=500", "credit_limit=150"}
        Me.xlk_cust_code.SizesColumnsTab = Nothing
        Me.xlk_cust_code.SqlString = Nothing
        Me.xlk_cust_code.SQLTab = New String() {"select type_code Tipo, invce_no Número,", "       invce_date Fecha, ccinvcem.due_date Vencimiento, ", "       ccinvcem.amount Monto, itbis Itbis, balance Balance", "from ccinvcem inner join ccopend", "on ccinvcem.invce_serial = ccopend.invce_serial", "and ccopend.balance <> 0"}
        Me.xlk_cust_code.SrcParameters = New String() {"cust_code=cust_code"}
        Me.xlk_cust_code.TabIndex = 5
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
        Me.xdtp_paym_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.fact_date"))
        Me.xdtp_paym_date.EditInitialValue = Nothing
        Me.xdtp_paym_date.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdtp_paym_date.FieldDescription = ""
        Me.xdtp_paym_date.FindInitialValue = Nothing
        Me.xdtp_paym_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_paym_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xdtp_paym_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdtp_paym_date.IgnoreRequiered = False
        Me.xdtp_paym_date.Location = New System.Drawing.Point(584, 45)
        Me.xdtp_paym_date.Name = "xdtp_paym_date"
        Me.xdtp_paym_date.NewInitialValue = "Now"
        Me.xdtp_paym_date.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdtp_paym_date.Requiered = False
        Me.xdtp_paym_date.Size = New System.Drawing.Size(136, 32)
        Me.xdtp_paym_date.StatusBarPanelDescripcion = Nothing
        Me.xdtp_paym_date.TabIndex = 9
        '
        'xcbo_paym_status
        '
        Me.xcbo_paym_status.AllowDefaultSort = True
        Me.xcbo_paym_status.bound = True
        Me.xcbo_paym_status.currValue = Nothing
        Me.xcbo_paym_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.fact_status"))
        Me.xcbo_paym_status.DefaultWhereString = Nothing
        Me.xcbo_paym_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_paym_status.EditInitialValue = Nothing
        Me.xcbo_paym_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_paym_status.FieldDescription = ""
        Me.xcbo_paym_status.FindInitialValue = "1"
        Me.xcbo_paym_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_paym_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xcbo_paym_status.IgnoreRequiered = False
        Me.xcbo_paym_status.Items.AddRange(New Object() {"0-Anulada", "1-Pendiente", "2-Cobrada"})
        Me.xcbo_paym_status.Location = New System.Drawing.Point(816, 16)
        Me.xcbo_paym_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_paym_status.LookupKeyField = Nothing
        Me.xcbo_paym_status.LookupTableName = Nothing
        Me.xcbo_paym_status.Name = "xcbo_paym_status"
        Me.xcbo_paym_status.NewInitialValue = "1"
        Me.xcbo_paym_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_paym_status.Requiered = False
        Me.xcbo_paym_status.Required = False
        Me.xcbo_paym_status.Size = New System.Drawing.Size(120, 33)
        Me.xcbo_paym_status.SqlString = Nothing
        Me.xcbo_paym_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_paym_status.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(508, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(13, 64)
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
        Me.Label3.Location = New System.Drawing.Point(8, 88)
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
        Me.Label4.Location = New System.Drawing.Point(521, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxaplicado
        '
        Me.xtxaplicado.AcceptsReturn = True
        Me.xtxaplicado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ftfactm, "fact_total"))
        Me.xtxaplicado.EditInitialValue = Nothing
        Me.xtxaplicado.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxaplicado.FieldDescription = ""
        Me.xtxaplicado.FindInitialValue = Nothing
        Me.xtxaplicado.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxaplicado.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxaplicado.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.xtxaplicado.IgnoreRequiered = False
        Me.xtxaplicado.Location = New System.Drawing.Point(584, 79)
        Me.xtxaplicado.Name = "xtxaplicado"
        Me.xtxaplicado.NewInitialValue = Nothing
        Me.xtxaplicado.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxaplicado.Requiered = False
        Me.xtxaplicado.Size = New System.Drawing.Size(136, 32)
        Me.xtxaplicado.StatusBarPanelDescripcion = Nothing
        Me.xtxaplicado.TabIndex = 1
        Me.xtxaplicado.Text = ""
        Me.xtxaplicado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(503, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Aplicado:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(25, 112)
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
        Me.Label7.Location = New System.Drawing.Point(744, 24)
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
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 216)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(944, 352)
        Me.LibXGrid1.TabIndex = 0
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.TabStop = False
        Me.LibXGrid1.UseAutoFillLines = True
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
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.xed_Tipo, Me.xed_number, Me.gColFecha, Me.gColVence, Me.gColDias, Me.gColAmount, Me.gColDescuento, Me.gColItbis, Me.gColtotal_amount, Me.gColBalance, Me.gColDescto1, Me.gColAplAmount, Me.gColterm_code, Me.gColdesc_date})
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
        'gColDescuento
        '
        Me.gColDescuento.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColDescuento.Format = "#,###0.00"
        Me.gColDescuento.FormatInfo = Nothing
        Me.gColDescuento.HeaderText = "Descuentoi"
        Me.gColDescuento.ImageList = Nothing
        Me.gColDescuento.isReadOnly = True
        Me.gColDescuento.MappingName = "cargo_desc"
        Me.gColDescuento.MaxLength = 32767
        Me.gColDescuento.ReadOnly = True
        Me.gColDescuento.TabStop = True
        Me.gColDescuento.UseCustomCellFormat = False
        Me.gColDescuento.Width = 75
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
        Me.gColDescto1.Format = "#,###0.00"
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
        Me.gColAplAmount.HeaderText = "Aplicadoi"
        Me.gColAplAmount.ImageList = Nothing
        Me.gColAplAmount.isReadOnly = False
        Me.gColAplAmount.MappingName = "amount"
        Me.gColAplAmount.MaxLength = 32767
        Me.gColAplAmount.ReadOnly = True
        Me.gColAplAmount.TabStop = True
        Me.gColAplAmount.UseCustomCellFormat = False
        Me.gColAplAmount.Width = 85
        '
        'gColterm_code
        '
        Me.gColterm_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColterm_code.Format = ""
        Me.gColterm_code.FormatInfo = Nothing
        Me.gColterm_code.ImageList = Nothing
        Me.gColterm_code.isReadOnly = False
        Me.gColterm_code.MappingName = "term_code"
        Me.gColterm_code.MaxLength = 32767
        Me.gColterm_code.TabStop = True
        Me.gColterm_code.UseCustomCellFormat = False
        Me.gColterm_code.Width = 0
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
        'DataView1
        '
        Me.DataView1.AllowDelete = False
        Me.DataView1.AllowNew = False
        '
        'btnVisualizar
        '
        Me.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVisualizar.Location = New System.Drawing.Point(96, 664)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(75, 32)
        Me.btnVisualizar.TabIndex = 4
        Me.btnVisualizar.Text = "Visualizar"
        '
        'btnPagos
        '
        Me.btnPagos.Enabled = False
        Me.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPagos.Location = New System.Drawing.Point(176, 664)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Size = New System.Drawing.Size(75, 32)
        Me.btnPagos.TabIndex = 5
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
        Me.btnDistribucion.TabIndex = 6
        Me.btnDistribucion.Text = "Distribuir Automático"
        '
        'btnAplicar
        '
        Me.btnAplicar.Enabled = False
        Me.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAplicar.Location = New System.Drawing.Point(16, 664)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(75, 32)
        Me.btnAplicar.TabIndex = 3
        Me.btnAplicar.Text = "Cobrar (F9)"
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
        Me.btnIncluirPP.TabIndex = 6
        Me.btnIncluirPP.Text = "Incluir Desc. x P. P."
        '
        'btnRemoverPP
        '
        Me.btnRemoverPP.Enabled = False
        Me.btnRemoverPP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemoverPP.Location = New System.Drawing.Point(640, 664)
        Me.btnRemoverPP.Name = "btnRemoverPP"
        Me.btnRemoverPP.Size = New System.Drawing.Size(96, 32)
        Me.btnRemoverPP.TabIndex = 6
        Me.btnRemoverPP.Text = "Remover Desc. x P. P."
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "ncf_type1"
        Me.DataColumn72.DataType = GetType(System.Int32)
        '
        'i_ptvrecib01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(962, 720)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnPagos)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.btnDistribucion)
        Me.Controls.Add(Me.lblTermino)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtPendiente)
        Me.Controls.Add(Me.btnIncluirPP)
        Me.Controls.Add(Me.btnRemoverPP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "i_ptvrecib01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Recibos de Cobros"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccpaymd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
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
        Dim Existepv As Integer
        Dim Existecxc As Integer

        Try

            SelectStmt = "select count(*) from ftfactm " & _
                        " where cust_code = " & pcust_code.ToString.Trim & _
                        "   and fact_status = 1 " & _
                        "   and type_code = '" & mTipoDocumento.Trim & "'"

            Existepv = Val(LibX.Data.Manager.GetScalar(SelectStmt).ToString.Trim)

            SelectStmt = "select count(*) from ccinvcem " & _
                        " where cust_code = " & pcust_code.ToString.Trim & _
                        "   and invce_status = 2 " & _
                        "   and type_code = '" & mTipoDocumento.Trim & "'"

            Existecxc = Val(LibX.Data.Manager.GetScalar(SelectStmt).ToString.Trim)


            If Existepv > 0 Or Existecxc > 0 Then
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
        Dim dias_dscto As Integer

        Try
            SelectStmt = "select ccinvcem.invce_serial," & _
                        " ccinvcem.type_code," & _
                        " ccinvcem.invce_no," & _
                        " ccinvcem.term_code," & _
                        " ccinvcem.invce_date," & _
                        " ccinvcem.amount invce_amount," & _
                        " ccinvcem.cargo_desc," & _
                        " ccinvcem.total_amount," & _
                        " ccopend.disc_balance disc_amount," & _
                        " ccopend.due_date," & _
                        " datediff(day," & _
                        " ccopend.due_date,getdate()) dias," & _
                        " ccopend.balance," & _
                        " ccopend.itbis_balance," & _
                        " ccopend.disc_date" & _
                        " from ccinvcem " & _
                        " inner join ccopend " & _
                        " on ccinvcem.invce_serial = ccopend.invce_serial" & _
                        " and ccopend.balance <> 0" & _
                        " where ccinvcem.cust_code = " & pcust_code.ToString & _
                        " order by ccinvcem.invce_date,ccinvcem.invce_no "

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Throw New ApplicationException("No se encontrarón documentos pendientes!")
            End If

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No se encontrarón documentos pendientes!")
            End If

            oTable.TableName = "ccpaymd"

            lineno = 0

            If LibXConnector1.CurrentAction = LibxConnectionActions.Add Then
                ccpaymd.Rows.Clear()
            End If

            For Each oRow As DataRow In oTable.Rows
                '// Verificar si existe
                If LibXConnector1.CurrentAction = LibxConnectionActions.Edit Then
                    If ccpaymd.Select("type_code ='" & oRow!type_code.ToString.Trim & "' and invce_no = " & oRow!invce_no.ToString.Trim).Length > 0 Then
                        GoTo next_Row
                    End If
                End If

                Dim oRow1 As DataRow = ccpaymd.NewRow
                oTermino = New SGT.CXC.Entidades.Termino(oRow!term_code)
                pdscto = (oTermino.PorcDescuento / 100)
                dias_dscto = oTermino.DiasDescuento

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
                If oRow1!dias > dias_dscto Then
                    If oBoton = 0 Then
                        oRow1!disc_amount = 0.0
                        oRow!disc_amount = 0.0
                    Else
                        oRow1!disc_amount = oRow!balance * pdscto
                    End If
                Else
                    oRow1!disc_amount = oRow!balance * pdscto
                End If
                oRow1!itbis_amount = oRow!itbis_balance
                oRow1!disc_date = oRow!disc_date
                oRow1!balance = oRow!balance

                ccpaymd.Rows.Add(oRow1)
next_Row:
            Next

            btnPagos.Enabled = ccpaymd.Rows.Count > 0
            btnRemoverPP.Enabled = ccpaymd.Rows.Count > 0
            btnIncluirPP.Enabled = ccpaymd.Rows.Count > 0
            Me.LibXGrid1.refreshFooter()

            xtxt_Balance1.Text = Val(balance.Text.Trim) - Val(Me.LibXGrid1.GetFooterValue(gColDescto1).ToString.Trim)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try
            xcbo_paym_status.currValue = 1 'Val(EstatusDocumentosEnum.Pendiente) 'Pendiente de aplicar
            xdtp_paym_date.Value = oCajaAbierta.Fecha

            Me.xtxt_caja_code.Text = oCaja.Code
            Me.labelcaja_name.Text = oCaja.Name

            Me.xtxt_caje_code.Text = oCajera.Code
            Me.labecaje_name.Text = oCajera.Name

            mDigitado = False
            txtPendiente.Text = "0.00"

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xlk_cust_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_cust_code.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If
            If e.row!balance < 0 Then
                Me.balance.Text = 0
            End If

            If LibXConnector1.State = LibX.LibxConnectorState.Insert _
            Or LibXConnector1.State = LibX.LibxConnectorState.Edit Then
                '// Verificar si hay recibos pendentes de aplicar para este cliente
                If ExisteRecibosPendientes(e.row!cust_code) = True Then
                    Throw New ApplicationException("Existen recibos de pangos pendientes de aplicar para este cliente, verique!")
                End If
                If LibXGrid1.getCurrentGridView.Count = 0 Then
                    '// Cargar las facturas pendientes de este cliente
                    DocumentosPendientes(e.row!cust_code)
                    Me.xtxaplicado.Text = 0
                    Me.xtxaplicado.Focus()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)

        End Try
    End Sub
    Private Sub RemovarAplicar()
        For RowIdx As Integer = 0 To LibXGrid1.getCurrentGridView.Count - 2
            '// Se asigna 1 para que al ejecutar el metodo AsignarMonto
            '// y este limpie el valor
            LibXGrid1.SetValue(RowIdx, gColAplAmount, 0)
        Next
        LibXGrid1.Focus(0, 0)
        mResta = 0
        Calcular()

        Dim CurrentIndex As Integer
        CurrentIndex = LibXGrid1.CurrentRowIndex
        If CurrentIndex > 0 Then LibXGrid1.CurrentRowIndex = CurrentIndex
        If Val(LibXGrid1.GetValue(LibXGrid1.currentRowNum, Me.gColAplAmount).ToString) > 0 Then
            LibXGrid1.Focus(CurrentIndex, 0)
        End If
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim dife As Decimal
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                If ccpaymd.Select("amount>0").Length <= 0 Then
                    Throw New ApplicationException("Debe seleccionar los documentos a aplicar!")
                End If

                dife = Format((mApli - CDbl(Me.xtxdscto.Text)), "###,###,##0.00") - Format(CDbl(Me.txtAmount.Text), "##,###,##0.00")
                If dife > 1 Then
                    Throw New ApplicationException("El valor del recibo no coincide con los documentos aplicados!")
                End If
                If CDbl(Me.txtAmount.Text) = 0 Then
                    Me.txtAmount.Text = Format(mCobrar, "###,###0.00")
                End If
                '// Datos
                e.UpdatingArgs.Row!type_code = mTipoDocumento 'RECIBO DE INGRESO
                e.UpdatingArgs.Row!fact_cond = 1
                e.UpdatingArgs.Row!bus_name = cust_name.Text
                '// e.UpdatingArgs.Row!fact_number = oDocument.GenerateNumber(mTipoDocumento, WhDefault)
                e.UpdatingArgs.Row!fact_total = mApli
                e.UpdatingArgs.Row!itbis = 0
                e.UpdatingArgs.Row!whse_code = LibX.User.WhDefault
                e.UpdatingArgs.Row!suc_code = LibX.User.Sucursal
                e.UpdatingArgs.Row!init_serial = oCajaAbierta.Serial
                e.UpdatingArgs.Row!vend_code = oCajaAbierta.CajeraCode
            End If

            If e.UpdatingArgs.StatementType = StatementType.Delete Then
                If e.UpdatingArgs.Row.Item("fact_status", DataRowVersion.Original) = EstatusDocumentosEnum.Cobrada Then
                    e.UpdatingArgs.Status = UpdateStatus.SkipAllRemainingRows
                    AnularDocumento(e.UpdatingArgs.Row)
                End If
            End If

            ''// actuliza estatus del cliente
            '//EstatusCliente(txtcust_code.Text)
        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            'LibX.Log.Add(ex, True)
            Throw
        End Try
    End Sub

    Private Sub AnularDocumento(ByVal oRow As DataRow)
        Dim oPost As SGT.Caja.Operaciones.Cobro
        Dim oParam As SGT.Caja.Operaciones.Cobro.ParametrosAnular

        Try
            oPost = New SGT.Caja.Operaciones.Cobro
            oParam = New SGT.Caja.Operaciones.Cobro.ParametrosAnular

            With oParam
                .Serial = oRow.Item("ftserial_no", DataRowVersion.Original)
                .AfectaCXC = True
                .UserTransaction = False
            End With

            oPost.Anular(oParam)

        Catch ex As Exception
            Throw

        End Try
    End Sub
    Private Sub i_ccpaym01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sCajaaa As Integer
        Try
            '// buscar el personal correspondiente para este usuario
            ''//sCajaaa = LibX.Data.Manager.GetScalar("select vend_code from cjinitm where caja_code = 1 and init_status =1 and suc_code =1")
            sCajaaa = oCajaAbierta.CajeraCode
            oCajera = New Cajera(sCajaaa)
            oCajaAbierta = New CajaAbierta

            '// si este usuario no es una cajera no permitir trabajar en recibos
            ''If oCajera.esCajera = False Then
            ''    Throw New ApplicationException("Debe especificar una cajera para iniciar una caja!")
            ''End If

            '// si no hay cajas abiertas no permitir trabajar
            If oCajaAbierta.HayCajasAbiertas = False Then
                Throw New ApplicationException("Debe iniciar una caja para realizar las operaciones del dia!")
            End If

            '// Si se envia el codigo de la caja para trabajar
            If Not LibXConnector1.Parameters Is Nothing Then
                If CType(LibXConnector1.Parameters.Value, Integer) > 0 Then
                    oCajaAbierta.Serial = CType(LibXConnector1.Parameters.Value, Integer)
                    If oCajaAbierta.Load = False Then
                        Throw New ApplicationException("Las operaciones para este parametros no existen!")
                    End If
                Else
                    '// Si es un vendedor mostrar la lista de cajas abiertas 
                    LibX.LibXRunner.Run("i_cjopen", "CAJ", True)
                End If
            Else
                '// Si es un vendedor mostrar la lista de cajas abiertas 
                LibX.LibXRunner.Run("i_cjopen", "CAJ", True)
            End If

            Me.Text &= " - [" & "CAJERA - " & oCajaAbierta.Fecha.ToString("dd/MM/yyyy") & "]"

            If CajaAbierta.CajeraCode <= 0 Then
                Me.Close()
                Exit Sub
            End If

            oDocument = New Documento(mTipoDocumento)

            Porc_mora = LibX.Data.Manager.GetScalar("select percent_charge from ivsetup")

            LibXGrid1.footerOperations.add("Aplicar", "count(type_code)")
            LibXGrid1.footerOperations.add("amount", "sum(amount)")
            LibXGrid1.footerOperations.add("disc_amount", "sum(disc_amount)", "amount<>0")
            LibXGrid1.footerOperations.add("balance", "sum(balance)")

            '// buscar el almacen por defecto
            WhDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibXWhDefault").ToString)
            xlk_cust_code.CheckText = "Balance mayor que 0"

            oCaja = New Caja(CajaAbierta.CajaCode)
            oParamValidar = New SGT.Administracion.Entidades.Permission.ParametrosValidar
            oAutorizar = New SGT.Administracion.Entidades.Permission

            '// Validar Permisos de Usuario
            oParamValidar.UserID = LibX.User.UserID

            '// Mostrar los datos de la caja y la cajera
            Me.xtxt_caja_code.Text = oCaja.Code
            Me.xtxt_caja_code.NewInitialValue = oCaja.Code
            Me.labelcaja_name.Text = oCaja.Name

            Me.xtxt_caje_code.Text = oCajera.Code
            Me.xtxt_caje_code.NewInitialValue = oCajera.Code
            Me.labecaje_name.Text = oCajera.Name

            Me.LibXGrid1.getCurrentGridView.AllowNew = False
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    ''Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
    ''    Try

    ''        '// APLICAR
    ''        If LibXConnector1.IsDataEditing = True And e.row > -1 Then
    ''        End If

    ''    Catch ex As Exception
    ''        e.hasErrors = True
    ''        LibX.Log.Add(ex, True)
    ''    End Try
    ''End Sub
    Private Sub AsignarMonto(ByVal Row As Integer)
        Dim Aplicar As Decimal
        Dim DescuentoPP As Decimal
        Dim Disc_Amount As Decimal
        Try
            DescuentoPP = Val(ccpaymd.Rows(Row)!disc_amount.ToString.Trim)
            Aplicar = Val(ccpaymd.Rows(Row)!balance.ToString.Trim) - Val(ccpaymd.Rows(Row)!disc_amount.ToString.Trim)

            '// si se aplico reversar
            If Val(ccpaymd.Rows(Row)!Amount.ToString.Trim) > 0 Then
                If mDigitado = False Then
                    Me.xtxaplicado.Text = CDbl(Me.xtxaplicado.Text.Trim) - CDbl(ccpaymd.Rows(Row)!Amount.ToString.Trim)
                    Me.txtAmount.Text = CDbl(Me.txtAmount.Text.Trim) - CDbl(ccpaymd.Rows(Row)!Amount.ToString.Trim)
                End If

                ccpaymd.Rows(Row).BeginEdit()
                ccpaymd.Rows(Row)!Amount = DBNull.Value
                Disc_Amount -= DescuentoPP

                '// Si el monto del documento es menor que la parte a aplicar
                '// asignar el monto del documento como monto a aplicar
            ElseIf Val(ccpaymd.Rows(Row)!balance.ToString.Trim) <= mResta Or mDigitado = False Then
                If mDigitado = False And Me.txtAmount.Text.Trim <> "" Then
                    If Me.xtxdscto.Text = "" Then
                        Me.xtxdscto.Text = 0
                    End If

                    Me.txtAmount.Text = Format(CDbl(Me.txtAmount.Text.Trim) + Aplicar, "###,###,##0.00")
                    Me.xtxdscto.Text = CDbl(Me.xtxdscto.Text.Trim) + DescuentoPP
                    Me.xtxaplicado.Text = CDbl(Me.txtAmount.Text.Trim) ''+ CDbl(Me.xtxdscto.Text.Trim)
                    'Else
                    '    Me.txtAmount.Text = Format(Aplicar - DescuentoPP, "###,###,##0.00")
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
                    If DescuentoPP > 0 Then
                        DescuentoPP = mResta * pdscto
                        ccpaymd.Rows(Row)!disc_Amount = DescuentoPP
                    Else
                        DescuentoPP = 0
                        ccpaymd.Rows(Row)!disc_Amount = DescuentoPP
                    End If
                End If
            End If

            If Not LibX.IsNull(ccpaymd.Rows(Row)!Amount) Then
                If xtxaplicado.Text = 0 And ccpaymd.Rows(Row)!Amount > 0 Then
                    xtxaplicado.Text = ccpaymd.Rows(Row)!Amount
                    xtxaplicado.Enabled = False
                End If
            Else
                xtxaplicado.Enabled = True
            End If

            ccpaymd.Rows(Row).EndEdit()
            Calcular()
            
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Function CalcularDescuento(ByVal Descuento As String, ByVal Monto As Decimal) As Decimal
        Try
            If Descuento = "" Then
                Descuento = 0
            End If

            If Descuento.EndsWith("%") Then
                Descuento = Descuenxtxaplicadoto.Replace("%", "")
                Descuento = (Monto * Convert.ToDecimal(Descuento) / 100).ToString
            Else
                Descuento = Descuento
            End If

            If CDbl(Descuento.Trim) >= CDbl(Me.txtAmount.Text.Trim) Then
                Descuento = 0
            End If

            Return Descuento
        Catch ex As Exception
            Throw
        End Try
    End Function
    Private Sub LibXConnector1_InsertingDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingDetailRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                If LibX.IsNull(e.UpdatingArgs.Row!amount) OrElse Val(e.UpdatingArgs.Row!amount.ToString.Trim) = 0 Then
                    e.UpdatingArgs.Status = UpdateStatus.SkipCurrentRow
                Else
                    e.UpdatingArgs.Row!itbis_amount = IIf(LibX.IsNull(e.UpdatingArgs.Row!itbis_amount), 0, e.UpdatingArgs.Row!itbis_amount)
                    e.UpdatingArgs.Row!itbis_amount = e.UpdatingArgs.Row!itbis_amount * (e.UpdatingArgs.Row!amount / e.UpdatingArgs.Row!balance)
                    e.UpdatingArgs.Row!type_code = mTipoDocumento
                End If
                e.UpdatingArgs.Row!mod_type = "PTV"
                e.UpdatingArgs.Row!paym_status = 2
                e.UpdatingArgs.Row!suc_code = LibX.User.Sucursal
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)

        End Try
    End Sub

    Private Sub Calcular()
        Dim Aplicar As Decimal, Aplicado As Decimal, Resta As Decimal
        Dim Descto As Decimal
        Dim i As Integer

        Try

            If xtxaplicado.Text.Length > 0 Then
                Aplicar = CDbl(xtxaplicado.Text.Trim) ''- Descto
                mCobrar = CDbl(xtxaplicado.Text.Trim)
            End If
            If Aplicar < 0 Then
                txtAmount.Text = ""
                Aplicar = 0
                mCobrar = 0
                xtxdscto.Text = ""
                xtxaplicado.Text = ""
            End If

            Aplicado = 0
            mResta = 0

            For i = 0 To ccpaymd.Rows.Count - 1
                If LibXGrid1.GetValue(i, Me.gColAmount) <> "" Then
                    Aplicado += Val(LibXGrid1.GetValue(i, Me.gColAplAmount).ToString)
                    Descto += Val(LibXGrid1.GetValue(i, Me.gColDescto1).ToString)
                    If Val(LibXGrid1.GetValue(i, Me.gColAplAmount).ToString) > 0 Then
                        Me.xtxdscto.Text = Format(Descto, "##,##0.00")
                        ''Me.xtxaplicado.Text = Format(Aplicado + Descto, "###,###,##0.00")
                        ''Me.xtxaplicado.Text = Format(Aplicado, "###,###,##0.00")
                        ''If Me.txtAmount.Text = "" Then
                        ''    Me.txtAmount.Text = Format(Aplicado, "###,###,##0.00")
                        ''End If
                        Me.txtAmount.Text = Format(Aplicado - Descto, "###,###,##0.00")
                        mApli = CDec(Me.xtxaplicado.Text)
                    End If
                End If
            Next

            If Aplicar > 0 Then
                mResta = Aplicar - Aplicado
            Else
                Aplicar = Aplicado
            End If
            If Aplicado = 0 And Descto = 0 Then
                Me.txtAmount.Text = 0.0
            End If

            Me.LibXGrid1.refreshFooter()
            txtPendiente.Text = Format(mResta, "##,###,##0.00")
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub txtAmount_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxaplicado.Validating
        Try
            If LibX.IsNull(LibXGrid1.GetFooterValue(Me.gColAplAmount)) AndAlso Val(LibXGrid1.GetFooterValue(Me.gColAplAmount).ToString.Trim) = 0 Then
                RemovarAplicar()
                Calcular()
            End If
            If LibXConnector1.IsDataEditing = True Then
                If txtAmount.Text.Length > 0 AndAlso CDbl(Me.txtAmount.Text.Trim) > CDbl(Me.balance.Text.Trim) Then
                    Throw New ApplicationException("Monto del recibo inváldo!")
                End If

                ''If txtAmount.Text.Length > 0 Then
                ''    ''Calcular()
                ''    If Val(LibXGrid1.GetFooterValue(Me.gColAplAmount).ToString.Trim) > 0 And Accion <> 4 Then
                ''        DocumentosPendientes(LibXConnector1.CurrentDataRow!cust_code)
                ''    End If
                ''End If
            End If

        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultqueryValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultQueryValues) Handles LibXConnector1.SettingDefaultqueryValues
        Try
            txtPaym_number.Enabled = True
            txtcust_code.Focus()
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertedRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedRow
        Dim oPago As SGT.CXC.Posteos.PostDocument
        Dim oParamPago As SGT.CXC.Posteos.PostDocument.ParametrosPagos

        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
            End If

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
                txtAmount.Text = CDbl(balance.Text.Trim) - CDbl(LibXGrid1.GetFooterValue(Me.gColDescto1).ToString.Trim)
            Else
                RemovarAplicar()
            End If

            If mResta = 0 Then
                aplicado = CDbl(LibXGrid1.GetFooterValue(gColAplAmount).ToString.Trim)
                mResta = txtAmount.Text - aplicado
            End If

            '// Aplicar Nota de Credito
            For Each orow As DataRow In ccpaymd.Select("balance < 0")
                orow.BeginEdit()
                orow!amount = (CDbl(orow!balance.Tostring.Trim) - CDbl(orow!disc_amount.Tostring.Trim))
                mResta -= Val(orow!Balance.Tostring.Trim) - CDbl(orow!disc_amount.Tostring.Trim)
                orow.EndEdit()
            Next

            '// Aplicar Facturas
            For Each orow As DataRow In ccpaymd.Select("balance > 0", "due_date")
                If Val(orow!amount.Tostring.Trim) = 0 Then
                    orow.BeginEdit()
                    If mResta > (Val(orow!balance.Tostring.Trim) - Val(orow!disc_amount.Tostring.Trim)) Then
                        mResta -= Val(orow!balance.Tostring.Trim) - Val(orow!disc_amount.Tostring.Trim)
                        orow!amount = (Val(orow!balance.Tostring.Trim) - Val(orow!disc_amount.Tostring.Trim))
                        descto += Val(orow!disc_amount.Tostring.Trim)
                    Else
                        orow!amount = mResta
                        orow!disc_amount = 0
                        mResta = 0
                    End If
                    orow.EndEdit()
                    If mResta = 0 Then
                        Exit For
                    End If
                End If
            Next

            Calcular()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        e.AditionalWhere = "ftfactm.type_code='" & mTipoDocumento.Trim & "' and ftfactm.whse_code = " & WhDefault.ToString
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click
        Try
            CobrarDocumento(LibXConnector1.CurrentDataRow!ftserial_no)
            Me.Close()
            Exit Sub
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub CobrarDocumento(ByVal p_serial_no As Integer)
        Dim XDelete As LibX.Data.XDeleteStmt
        Try
            Dim op As New LibxPrgParams

            op.IsFromOther = True
            op.initMode = LibxInitModes.Edit
            op.WhereToExecute = "ftfactm.ftserial_no = " & p_serial_no.ToString.Trim
            op.Value = p_serial_no
            App.CurrentPrgParams = op

            LibX.LibXRunner.Run("i_cjfact01", "CAJ", True)

            LibXConnector1.CurrentDataRow.Row.RejectChanges()
            LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & p_serial_no.ToString.Trim)

            If LibXConnector1.CurrentDataRow.Row!fact_status = Val(EstatusDocumentosEnum.Pendiente) Then
                '// Borrar Detalle
                XDelete = New LibX.Data.XDeleteStmt("ccpaymd")
                XDelete.Fields("paym_serial") = p_serial_no
                XDelete.Fields("type_code") = LibXConnector1.CurrentDataRow.Row!type_code.ToString.Trim
                XDelete.Execute()

                '// Borrar Cabecera
                XDelete = New LibX.Data.XDeleteStmt("ftfactm")
                XDelete.Fields("ftserial_no") = p_serial_no
                XDelete.Execute()

                XDelete.Dispose()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try
            If (e.isEditing = True AndAlso e.isDataEditing = False) Or e.action = LibxConnectionActions.Cancel Then
                Me.txtAmount.Text = ""
            End If

            btnAplicar.Enabled = (e.isEditing = False AndAlso LibXConnector1.HasRecords = True AndAlso LibXConnector1.CurrentDataRow!fact_status = 1) 'Val(EstatusDocumentosEnum.Pendiente))
            ''//btnVisualizar.Enabled = (LibXConnector1.HasRecords)
            btnPagos.Enabled = (LibXConnector1.HasRecords)
            btnIncluirPP.Enabled = e.isDataEditing And LibXConnector1.HasRecords
            btnRemoverPP.Enabled = e.isDataEditing And LibXConnector1.HasRecords
            txtcust_code.Focus()

        Catch ex As Exception
            LibX.Log.Add(ex)
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
        Dim ftSerial As Integer
        Try
            xParam = New LibX.LibxPrgParams
            xParam.AllowDelete = False
            xParam.AllowEdit = False
            xParam.AllowNew = False
            xParam.AllowPrint = False
            xParam.AllowQuery = False
            xParam.initMode = LibX.LibxInitModes.none

            LibX.App.CurrentPrgParams = xParam
            ftSerial = LibX.Data.Manager.GetScalar("select ftserial_no from ftfactm where fact_number =" & LibXGrid1.GetValue(LibXGrid1.currentRowNum, 1) & " and type_code ='" & LibXGrid1.GetValue(LibXGrid1.currentRowNum, 0) & "'")
            If ftSerial = 0 And (LibXGrid1.GetValue(LibXGrid1.currentRowNum, 0) = "FPV" Or LibXGrid1.GetValue(LibXGrid1.currentRowNum, 1) = "FSG" Or LibXGrid1.GetValue(LibXGrid1.currentRowNum, 0) = "DEV") Then
                Throw New ApplicationException("Esta factura es transferida")
            End If
            If (LibXGrid1.GetValue(LibXGrid1.currentRowNum, 0) = "FPV" Or LibXGrid1.GetValue(LibXGrid1.currentRowNum, 0) = "FSG" Or LibXGrid1.GetValue(LibXGrid1.currentRowNum, 0) = "DEV") Then
                xParam.WhereToExecute = "ftfactm.ftserial_no = " & ftSerial
                xParam.Datos.Add("ftserial_no", ftSerial)
                xParam.Datos.Add("type_code", ccpaymd.Rows(LibXGrid1.currentRowNum)!type_code.ToString)
                xParam.Value = ftSerial
                LibX.LibXRunner.Run("i_ptvfind", "PTV", True)
            End If
            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 1) = "DEV" Then
                ftSerial = LibX.Data.Manager.GetScalar("select ftserial_no from ftfactm where fact_number =" & LibXGrid1.GetValue(LibXGrid1.currentRowNum, 1) & " and type_code ='DEV'")
                xParam.Datos.Add("ftserial_no", ftSerial)
                xParam.Value = ftSerial
                LibX.LibXRunner.Run("i_ftdevm01", "FCT", True)
            Else
                If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "CDC" Or LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "NCC" Or LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "NDC" Then
                    xParam.WhereToExecute = "ccinvcem.invce_serial = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0)
                    LibX.LibXRunner.Run("i_ccinvce01", "CXC", True)
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    ''Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
    ''    Dim xParam As LibX.LibxPrgParams
    ''    Dim xParamAdm As SGT.Administracion.Entidades.Program.ParametrosVizualizar
    ''    Dim xProgram As SGT.Administracion.Entidades.Program
    ''    Try
    ''        If DataSet1.Tables(0).Rows.Count <= 0 Then
    ''            Exit Sub
    ''        End If

    ''        xParam = New LibX.LibxPrgParams
    ''        xParamAdm = New SGT.Administracion.Entidades.Program.ParametrosVizualizar
    ''        xProgram = New SGT.Administracion.Entidades.Program

    ''        xParam.AllowDelete = False
    ''        xParam.AllowEdit = False
    ''        xParam.AllowNew = False
    ''        xParam.AllowPrint = False
    ''        xParam.AllowQuery = False
    ''        xParam.initMode = LibxInitModes.Query
    ''        xParam.WhereToExecute = "ftfactm.fact_number = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xed_number) & " AND ftfactm.type_code = '" & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xed_Tipo) & "'"
    ''        xParam.Value = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xed_number)  'TIPO
    ''        LibX.App.CurrentPrgParams = xParam

    ''        'Me.Cursor = Cursors.WaitCursor

    ''        xParamAdm.TipoDocumento = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 1)
    ''        xParamAdm.Parametros = xParam

    ''        xProgram.Visualizar(xParamAdm)

    ''        'Me.Cursor = Cursors.Default

    ''    Catch ex As Exception
    ''        LibX.Log.Add(ex)
    ''    End Try
    ''End Sub
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
                Dim Serial As Integer
                '// Refrescar

                If LibX.IsNull(LibXConnector1.CurrentDataRow!ftserial_no) = False Then
                    Serial = LibXConnector1.CurrentDataRow!ftserial_no
                Else
                    Serial = LibX.Data.Manager.LastSerialValue
                End If

                LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & Serial.ToString.Trim)

                '// Cobrar
                CobrarDocumento(Serial)
                Me.Close()

                '// Refrescar
                LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & Serial.ToString.Trim)
            End If
            If e.Action = LibxConnectionActions.Print Then
                ''oDocumento = New SGT.Inventario.Entidades.Documento(LibXConnector1.CurrentDataRow!type_code.ToString.Trim)
                ''If oDocumento.AutoImprimir = True Then
                LibXConnector1.ReportObject.Destination = Crystal.DestinationConstants.crptToPrinter '// Imprimir Directo
                ''End If
            End If
            If e.Action = LibxConnectionActions.Add Then
                txtAmount.Text = String.Empty
            End If
            txtcust_code.Focus()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub ShowPayMethod(ByVal Tipo As String)
        Try
            Dim oParam As New LibX.LibxPrgParams

            With oParam
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowPrint = False
                .Value = Tipo
                .WhereToExecute = "cjtranrm.ftserial_no  =" & LibXConnector1.CurrentDataRow!ftserial_no.ToString & " and pay_method = '" & Tipo & "'"
                .IsFromOther = True
            End With

            LibX.App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("c_cjpaym01", "CAJ", True)

        Catch ex As Exception
            Throw
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
                If Val(e.row!fact_status) = EstatusDocumentosEnum.Pendiente Then
                    LibXConnector1.AllowPrint = False
                    LibXConnector1.AllowEdit = True
                Else
                    LibXConnector1.AllowPrint = True
                    LibXConnector1.AllowEdit = False
                    LibXConnector1.AllowDelete = False
                End If
            End If
            If LibXConnector1.HasRecords = True Then
                If LibX.IsNull(LibXConnector1.CurrentDataRow!descto) Then
                    Me.txtAmount.Text = LibXConnector1.CurrentDataRow!fact_total
                Else
                    Me.txtAmount.Text = (LibXConnector1.CurrentDataRow!fact_total - LibXConnector1.CurrentDataRow!descto)
                End If
            End If

            LibXNavigator1.UpdateState()
            Me.txtcust_code.Focus()

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub btnCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheque.Click
        Try
            ShowPayMethod("CHK")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnTarjeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTarjeta.Click
        Try
            ShowPayMethod("TAR")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub i_ptvrecib01_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If LibXConnector1.IsEditing = False And LibXConnector1.HasRecords = True Then
                If e.KeyCode = Keys.F9 Then
                    CobrarDocumento(LibXConnector1.CurrentDataRow!ftserial_no)
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            Accion = e.Action
            If e.AcceptedAction = LibxConnectionActions.Add _
                AndAlso e.Action <> LibxConnectionActions.Cancel Then
                If LibX.IsNull(LibXConnector1.CurrentDataRow!fact_date) = True Then
                    LibXConnector1.CurrentDataRow!fact_date = oCajaAbierta.Fecha
                End If
            End If
            If e.Action = LibxConnectionActions.Print Then
                LibXConnector1.ReportObject.Destination = Crystal.DestinationConstants.crptToPrinter '// Imprimir Directo
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
            Me.xtxdscto.Text = ccpaymd.Rows(RowIdx)!disc_balance.ToString.Trim
            '// Se asigna 1 para que al ejecutar el metodo AsignarMonto
            '// y este limpie el valor
            Me.LibXGrid1.SetValue(RowIdx, Me.gColAplAmount, 0)
            Calcular()
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub
    Private Sub mnuAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAplicar.Click
        Try
            If LibXConnector1.IsDataEditing = True Then
                AsignarMonto(LibXGrid1.CurrentRowIndex)
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub mnuDesaplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDesaplicar.Click
        Try
            If LibXConnector1.IsDataEditing = True Then
                AsignarMonto(LibXGrid1.CurrentRowIndex)
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub btnIncluirPP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluirPP.Click
        oBoton = btnIncluirPP.CausesValidation
        txtAmount.Text = String.Empty
        xtxdscto.Text = String.Empty
        xtxaplicado.Text = String.Empty
        If Accion <> 4 Then
            DocumentosPendientes(txtcust_code.Text)
        End If

    End Sub

    Private Sub btnRemoverPP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoverPP.Click
        Try
            For RowIdx As Integer = 0 To LibXGrid1.getCurrentGridView.Count - 1
                LibXGrid1.SetValue(RowIdx, gColDescto1, 0)
                '// Se asigna 1 para que al ejecutar el metodo AsignarMonto
                '// y este limpie el valor
                LibXGrid1.SetValue(RowIdx, gColAplAmount, 0)
                'AsignarMonto(RowIdx)
            Next
            txtAmount.Text = String.Empty
            xtxdscto.Text = String.Empty
            xtxaplicado.Text = String.Empty
            Calcular()

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub gColDescto1_SetCellFormat(ByVal sender As Object, ByVal e As LibX.XDataGridFormatCellEventArgs) Handles gColDescto1.SetCellFormat
        Try
            If LibXConnector1.IsDataEditing = True Then
                If LibX.IsNull(ccpaymd.Rows(e.RowNumber)!due_date) = False AndAlso _
                CType(ccpaymd.Rows(e.RowNumber)!due_date, Date) <= LibX.Data.Manager.Connection.GetDate Then
                    e.ForeColor = System.Drawing.Color.Red
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub txtcust_code_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtcust_code.Validating
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

    Private Sub LibXConnector1_SettingDefaulteditValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultEditValues) Handles LibXConnector1.SettingDefaulteditValues
        Try
            '// Cargar las facturas pendientes de este cliente
            DocumentosPendientes(LibXConnector1.CurrentDataRow!cust_code)
            Me.xtxaplicado.Text = 0
            Me.txtcust_code.Focus()
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles xtxaplicado.KeyPress
        Try
            If LibXConnector1.IsDataEditing = True Then
                If xtxaplicado.Text.Trim <> "" Then
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
    Private Sub xtxt_descuento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxdscto.Validating
        Dim MontoBruto As Decimal
        Dim MontoNeto As Decimal
        Dim Descuento As Decimal
        Dim Porc_Descuento As Integer
        Dim Descto As Decimal
        Try

            If Me.xtxaplicado.Text.Trim = "" Then
                If Val(Me.xtxdscto.Text.Trim) > 0 Then
                    e.Cancel = True
                End If

                Exit Sub
            End If

            If Me.xtxdscto.Text.Trim = "" Then
                Exit Sub
            End If

            MontoBruto = CDbl(xtxaplicado.Text)
            If xtxdscto.Text.EndsWith("%") Then
                Porc_Descuento = Val(Me.xtxdscto.Text.Substring(0, xtxdscto.Text.IndexOf("%")).Trim)
                pdscto = (Porc_Descuento / 100)
                Descuento = MontoBruto * (Porc_Descuento / 100)
                Me.xtxdscto.Text = Descuento.ToString("###,##0.00")
            Else
                Descuento = Me.xtxdscto.Text
            End If

            Descto = CDbl(Me.xtxdscto.Text)

            If (Descuento > MontoBruto) Then
                Throw New ApplicationException("Descuento no puede ser mayor q el monto total del documento!")
            End If

            '//EMR
            If Descuento > 0 And MontoBruto > 0 Then
                If (Descuento / MontoBruto) >= 0.75 Then
                    Throw New ApplicationException("Descuento muy alto para este documento!")
                End If
            End If

            If Descuento > 0 And MontoBruto > 0 Then
                If (Descuento / MontoBruto) > (oCajera.Porc_Descuento / 100) Then
                    oParamValidar.AccessKey = "AD"
                    oAutorizar.PermisosAutorizados.Remove("AD")

                    If oAutorizar.isAutorization(oParamValidar) = False Or (Descuento / MontoBruto) > (oAutorizar.PorcientoDescuento / 100) Then
                        Throw New ApplicationException("Autorización Invalida o descuento no permitido")
                    End If
                    '//Me.xtxt_descuento.ForeColor = System.Drawing.Color.Red
                Else
                    '//Me.xtxt_descuento.ForeColor = System.Drawing.Color.Black
                End If
            End If

            If LibXConnector1.CurrentAction <> LibxConnectionActions.Cancel AndAlso LibXConnector1.IsDataEditing = True Then
                ''mResta = CDec(txtAmount.Text) + CDec(xtxdscto.Text)
                Distribuye_descuento(Descto)
                ''// Aplicar Facturas
                ''    For Each oRow As DataRow In ccpaymd.Select("amount > 0")
                ''        oRow!amount = 0
                ''    Next
                ''    For Each orow As DataRow In ccpaymd.Select("balance > 0 and disc_amount > 0")
                ''        orow.BeginEdit()
                ''        If mResta > Val(orow!balance.ToString.Trim) Then
                ''            orow!amount = Val(orow!balance.ToString.Trim)
                ''            mResta -= Val(orow!amount.ToString.Trim)
                ''        Else
                ''            orow!amount = mResta
                ''            mResta = 0
                ''        End If

                ''        orow.EndEdit()
                ''        If mResta = 0 Then
                ''            Exit For
                ''        End If
                ''        'End If
                ''    Next
                Calcular()
            End If

        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
            Me.xtxdscto.Text = 0
        End Try
    End Sub
    Private Sub Distribuye_descuento(ByVal MontoDescuento As Decimal)
        Dim MontoBruto As Decimal

        Dim DescuentoAplicado As Decimal = 0
        Dim MontoAplicado As Decimal = 0

        Dim PorcDescuentoDigi As Decimal
        Try
            If Val(Me.xtxdscto.Text.Trim) > 0 Then
                MontoDescuento = CType(Me.xtxdscto.Text, Decimal)
                MontoBruto = CType(Me.xtxaplicado.Text, Decimal)

                For i As Integer = 0 To ccpaymd.Rows.Count - 1
                    If Not LibX.IsNull(ccpaymd.Rows(i)!amount) And ccpaymd.Rows(i)!disc_amount = 0 Then
                        '// calcular el descuento que le corresponde segun lo digitado
                        PorcDescuentoDigi = Decimal.Round(MontoDescuento / MontoBruto, 5)
                        PorcDescuentoDigi = Decimal.Round((Val(ccpaymd.Rows(i)!amount) * PorcDescuentoDigi), 6)

                        DescuentoAplicado += PorcDescuentoDigi
                        ccpaymd.Rows(i)!disc_amount = PorcDescuentoDigi
                        ''ccpaymd.Rows(i)!amount = ccpaymd.Rows(i)!amount + PorcDescuentoDigi
                    End If
                Next
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class
