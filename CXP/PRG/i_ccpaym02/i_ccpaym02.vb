Imports SGT.Inventario
Imports SGT.Inventario.Entidades
Imports SGT.CXC.Posteos
Imports SGT.Caja.Entidades
Imports SGT.Contabilidad.Entidades
Imports LibX
Imports SGT.PuntodeVenta.Entidades
Imports SGT.Facturacion.Entidades

Public Class i_ccpaym02
    Inherits System.Windows.Forms.Form
    Dim oDocument As SGT.Inventario.Entidades.Documento
    Dim oSdocumento As SGT.Contabilidad.Entidades.Documentos
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
    Friend WithEvents txtAmount As LibX.XTextBox
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
    Friend WithEvents XTextBox13 As LibX.XMaskEdit
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
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents ccinvcem As System.Data.DataTable
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ccinvcem = New System.Data.DataTable
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
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
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
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.xtxt_fact_nota = New LibX.XTextBox
        Me.txtcust_code = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
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
        Me.XTextBox13 = New LibX.XMaskEdit
        Me.Label23 = New System.Windows.Forms.Label
        Me.btnCheque = New System.Windows.Forms.Button
        Me.btnTarjeta = New System.Windows.Forms.Button
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
        Me.txtAmount = New LibX.XTextBox
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
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccinvcem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccpaymd, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXNavigator1.FirstControlInFindMode = Nothing
        Me.LibXNavigator1.FirstControlInNewMode = Me.txtcust_code
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(962, 24)
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
        Me.LibXConnector1.DataMember = "ccinvcem"
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
        Me.LibXConnector1.ReportName = "r_ccpaym02.rpt"
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ccinvcem, Me.ccpaymd})
        '
        'ccinvcem
        '
        Me.ccinvcem.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45})
        Me.ccinvcem.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"invce_serial", "suc_code"}, True)})
        Me.ccinvcem.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn22}
        Me.ccinvcem.TableName = "ccinvcem"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "invce_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "type_code"
        Me.DataColumn2.MaxLength = 3
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "invce_no"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "term_code"
        Me.DataColumn4.MaxLength = 5
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "cust_code"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "invce_date"
        Me.DataColumn6.DataType = GetType(System.DateTime)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "detail"
        Me.DataColumn7.MaxLength = 60
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "due_date"
        Me.DataColumn8.DataType = GetType(System.DateTime)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "amount"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "itbis"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "amount_grab"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "amount_excent"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "cargo_banc"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "cargo_desc"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "excento"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "impto"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "invce_status"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "total_amount"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "invce_ncf"
        Me.DataColumn19.MaxLength = 20
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "vend_code"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "chequera"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "suc_code"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn43
        '
        Me.DataColumn43.Caption = "cash_amount"
        Me.DataColumn43.ColumnName = "cash_amount"
        Me.DataColumn43.DataType = GetType(System.Decimal)
        '
        'DataColumn44
        '
        Me.DataColumn44.Caption = "card_amount"
        Me.DataColumn44.ColumnName = "card_amount"
        Me.DataColumn44.DataType = GetType(System.Decimal)
        '
        'DataColumn45
        '
        Me.DataColumn45.Caption = "check_amount"
        Me.DataColumn45.ColumnName = "check_amount"
        Me.DataColumn45.DataType = GetType(System.Decimal)
        '
        'ccpaymd
        '
        Me.ccpaymd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn46})
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
        Me.LibXDbSourceTable1.SerialColumnName = "invce_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ccinvcem"
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
        Me.LibXDbSourceTable2.LineColName = ""
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"paym_serial=invce_serial"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select ccpaymd.paym_serial,", "       ccpaymd.line_no,", "       ccpaymd.invce_serial,", "       ccinvcem.type_code,", "       ccinvcem.invce_no,", "       ccinvcem.invce_date,", "       ccinvcem.term_code,", "       ccinvcem.amount invce_amount,", "       ccinvcem.cargo_desc,", "       ccinvcem.total_amount,", "       ccopend.due_date,", "       datediff(day,ccinvcem.invce_date,", "                    ccopend.due_date) dias,", "       ccpaymd.disc_amount,", "       ccpaymd.balance,", "       ccpaymd.amount,", "       ccpaymd.pay_mora,", "      ccpaymd.itbis_amount,", "       ccpaymd.mod_type,", "      ccopend.disc_date,", "      ccpaymd.suc_code", "  from ccpaymd inner join ccinvcem", "    on ccpaymd.invce_serial = ccinvcem.invce_serial", " inner join ccopend ", "    on ccpaymd.invce_serial = ccopend.invce_serial"}
        Me.LibXDbSourceTable2.TableName = "ccpaymd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'xtxt_fact_nota
        '
        Me.xtxt_fact_nota.AcceptsReturn = True
        Me.xtxt_fact_nota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_fact_nota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.detail"))
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
        Me.xtxt_fact_nota.Size = New System.Drawing.Size(360, 64)
        Me.xtxt_fact_nota.StatusBarPanelDescripcion = Nothing
        Me.xtxt_fact_nota.TabIndex = 3
        Me.xtxt_fact_nota.Text = ""
        '
        'txtcust_code
        '
        Me.txtcust_code.AcceptsReturn = True
        Me.txtcust_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcust_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.cust_code"))
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
        Me.GroupBox1.Controls.Add(Me.txtAmount)
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
        Me.xlk_chequera.Location = New System.Drawing.Point(416, 88)
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
        Me.XTexChequera.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.chequera"))
        Me.XTexChequera.EditInitialValue = Nothing
        Me.XTexChequera.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTexChequera.FieldDescription = ""
        Me.XTexChequera.FindInitialValue = Nothing
        Me.XTexChequera.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTexChequera.IgnoreRequiered = False
        Me.XTexChequera.Location = New System.Drawing.Point(72, 88)
        Me.XTexChequera.Name = "XTexChequera"
        Me.XTexChequera.NewInitialValue = Nothing
        Me.XTexChequera.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTexChequera.Requiered = False
        Me.XTexChequera.Size = New System.Drawing.Size(64, 20)
        Me.XTexChequera.StatusBarPanelDescripcion = Nothing
        Me.XTexChequera.TabIndex = 52
        Me.XTexChequera.Text = ""
        '
        'xtxt_chequera_name
        '
        Me.xtxt_chequera_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xtxt_chequera_name.Location = New System.Drawing.Point(144, 88)
        Me.xtxt_chequera_name.Name = "xtxt_chequera_name"
        Me.xtxt_chequera_name.Size = New System.Drawing.Size(272, 20)
        Me.xtxt_chequera_name.TabIndex = 54
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(8, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 16)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Chequera:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XMaskEdit1
        '
        Me.XMaskEdit1.AcceptsReturn = True
        Me.XMaskEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.invce_ncf"))
        Me.XMaskEdit1.EditInitialValue = Nothing
        Me.XMaskEdit1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XMaskEdit1.Enabled = False
        Me.XMaskEdit1.FieldDescription = ""
        Me.XMaskEdit1.FindInitialValue = Nothing
        Me.XMaskEdit1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XMaskEdit1.IgnoreRequiered = False
        Me.XMaskEdit1.Location = New System.Drawing.Point(752, 16)
        Me.XMaskEdit1.Masked = MaskedTextBox.Mask.Decimal
        Me.XMaskEdit1.Name = "XMaskEdit1"
        Me.XMaskEdit1.NewInitialValue = Nothing
        Me.XMaskEdit1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.Requiered = False
        Me.XMaskEdit1.Size = New System.Drawing.Size(184, 26)
        Me.XMaskEdit1.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit1.TabIndex = 50
        Me.XMaskEdit1.Text = ""
        Me.XMaskEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(704, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 22)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Ncf:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_type_code
        '
        Me.xcbo_type_code.AllowDefaultSort = True
        Me.xcbo_type_code.bound = True
        Me.xcbo_type_code.currValue = Nothing
        Me.xcbo_type_code.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ccinvcem.type_code"))
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
        Me.xtxt_Balance1.Location = New System.Drawing.Point(327, 64)
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
        Me.Label10.Location = New System.Drawing.Point(215, 64)
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
        Me.GroupBox3.Controls.Add(Me.XTextBox13)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.btnCheque)
        Me.GroupBox3.Controls.Add(Me.btnTarjeta)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Location = New System.Drawing.Point(712, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(224, 120)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Forma de Pago"
        '
        'XTextBox11
        '
        Me.XTextBox11.AcceptsReturn = True
        Me.XTextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.cash_amount"))
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
        Me.XTextBox11.Size = New System.Drawing.Size(112, 26)
        Me.XTextBox11.StatusBarPanelDescripcion = Nothing
        Me.XTextBox11.TabIndex = 0
        Me.XTextBox11.Text = ""
        Me.XTextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'XTextBox12
        '
        Me.XTextBox12.AcceptsReturn = True
        Me.XTextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.card_amount"))
        Me.XTextBox12.EditInitialValue = Nothing
        Me.XTextBox12.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.FieldDescription = ""
        Me.XTextBox12.FindInitialValue = Nothing
        Me.XTextBox12.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTextBox12.IgnoreRequiered = False
        Me.XTextBox12.Location = New System.Drawing.Point(88, 48)
        Me.XTextBox12.Masked = MaskedTextBox.Mask.Decimal
        Me.XTextBox12.Name = "XTextBox12"
        Me.XTextBox12.NewInitialValue = Nothing
        Me.XTextBox12.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
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
        Me.Label21.TabIndex = 0
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
        Me.XTextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.check_amount"))
        Me.XTextBox13.EditInitialValue = Nothing
        Me.XTextBox13.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox13.FieldDescription = ""
        Me.XTextBox13.FindInitialValue = Nothing
        Me.XTextBox13.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTextBox13.IgnoreRequiered = False
        Me.XTextBox13.Location = New System.Drawing.Point(88, 80)
        Me.XTextBox13.Masked = MaskedTextBox.Mask.None
        Me.XTextBox13.Name = "XTextBox13"
        Me.XTextBox13.NewInitialValue = Nothing
        Me.XTextBox13.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox13.Requiered = False
        Me.XTextBox13.Size = New System.Drawing.Size(88, 26)
        Me.XTextBox13.StatusBarPanelDescripcion = Nothing
        Me.XTextBox13.TabIndex = 3
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
        Me.btnCheque.TabIndex = 4
        Me.btnCheque.Text = "..."
        '
        'btnTarjeta
        '
        Me.btnTarjeta.Enabled = False
        Me.btnTarjeta.Location = New System.Drawing.Point(176, 48)
        Me.btnTarjeta.Name = "btnTarjeta"
        Me.btnTarjeta.Size = New System.Drawing.Size(24, 20)
        Me.btnTarjeta.TabIndex = 2
        Me.btnTarjeta.Text = "..."
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(27, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(29, 16)
        Me.Label32.TabIndex = 39
        Me.Label32.Text = "Tipo:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPaym_number
        '
        Me.txtPaym_number.AcceptsReturn = True
        Me.txtPaym_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.invce_no"))
        Me.txtPaym_number.EditInitialValue = Nothing
        Me.txtPaym_number.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtPaym_number.FieldDescription = ""
        Me.txtPaym_number.FindInitialValue = Nothing
        Me.txtPaym_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPaym_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaym_number.IgnoreRequiered = True
        Me.txtPaym_number.Location = New System.Drawing.Point(557, 16)
        Me.txtPaym_number.Name = "txtPaym_number"
        Me.txtPaym_number.NewInitialValue = Nothing
        Me.txtPaym_number.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPaym_number.Requiered = False
        Me.txtPaym_number.Size = New System.Drawing.Size(136, 32)
        Me.txtPaym_number.StatusBarPanelDescripcion = Nothing
        Me.txtPaym_number.TabIndex = 4
        Me.txtPaym_number.Text = ""
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
        Me.xdtp_paym_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ccinvcem.invce_date"))
        Me.xdtp_paym_date.EditInitialValue = Nothing
        Me.xdtp_paym_date.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdtp_paym_date.FieldDescription = ""
        Me.xdtp_paym_date.FindInitialValue = Nothing
        Me.xdtp_paym_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_paym_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xdtp_paym_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdtp_paym_date.IgnoreRequiered = False
        Me.xdtp_paym_date.Location = New System.Drawing.Point(557, 96)
        Me.xdtp_paym_date.Name = "xdtp_paym_date"
        Me.xdtp_paym_date.NewInitialValue = "Now"
        Me.xdtp_paym_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_paym_date.Requiered = False
        Me.xdtp_paym_date.Size = New System.Drawing.Size(136, 32)
        Me.xdtp_paym_date.StatusBarPanelDescripcion = Nothing
        Me.xdtp_paym_date.TabIndex = 7
        '
        'xcbo_paym_status
        '
        Me.xcbo_paym_status.AllowDefaultSort = True
        Me.xcbo_paym_status.bound = True
        Me.xcbo_paym_status.currValue = Nothing
        Me.xcbo_paym_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ccinvcem.invce_status"))
        Me.xcbo_paym_status.DefaultWhereString = Nothing
        Me.xcbo_paym_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_paym_status.EditInitialValue = Nothing
        Me.xcbo_paym_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_paym_status.FieldDescription = ""
        Me.xcbo_paym_status.FindInitialValue = "1"
        Me.xcbo_paym_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_paym_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xcbo_paym_status.IgnoreRequiered = False
        Me.xcbo_paym_status.Items.AddRange(New Object() {"2-Pendiente", "0-Anulada", "1-Cobrada"})
        Me.xcbo_paym_status.Location = New System.Drawing.Point(557, 56)
        Me.xcbo_paym_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_paym_status.LookupKeyField = Nothing
        Me.xcbo_paym_status.LookupTableName = Nothing
        Me.xcbo_paym_status.Name = "xcbo_paym_status"
        Me.xcbo_paym_status.NewInitialValue = "1"
        Me.xcbo_paym_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_paym_status.Requiered = False
        Me.xcbo_paym_status.Required = False
        Me.xcbo_paym_status.Size = New System.Drawing.Size(136, 33)
        Me.xcbo_paym_status.SqlString = Nothing
        Me.xcbo_paym_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_paym_status.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(477, 16)
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
        Me.Label2.Location = New System.Drawing.Point(13, 40)
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
        Me.balance.Location = New System.Drawing.Point(72, 64)
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
        Me.Label3.Location = New System.Drawing.Point(8, 64)
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
        Me.Label4.Location = New System.Drawing.Point(490, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAmount
        '
        Me.txtAmount.AcceptsReturn = True
        Me.txtAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.amount"))
        Me.txtAmount.EditInitialValue = Nothing
        Me.txtAmount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAmount.FieldDescription = ""
        Me.txtAmount.FindInitialValue = Nothing
        Me.txtAmount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.IgnoreRequiered = False
        Me.txtAmount.Location = New System.Drawing.Point(552, 136)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.NewInitialValue = Nothing
        Me.txtAmount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAmount.Requiered = False
        Me.txtAmount.Size = New System.Drawing.Size(136, 32)
        Me.txtAmount.StatusBarPanelDescripcion = Nothing
        Me.txtAmount.TabIndex = 4
        Me.txtAmount.Text = ""
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(441, 136)
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
        Me.Label6.Location = New System.Drawing.Point(32, 128)
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
        Me.Label7.Location = New System.Drawing.Point(481, 56)
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
        Me.LibXGrid1.Location = New System.Drawing.Point(0, 216)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(944, 352)
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
        Me.btnVisualizar.TabIndex = 3
        Me.btnVisualizar.Text = "Visualizar"
        '
        'btnPagos
        '
        Me.btnPagos.Enabled = False
        Me.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPagos.Location = New System.Drawing.Point(88, 664)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Size = New System.Drawing.Size(75, 32)
        Me.btnPagos.TabIndex = 4
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
        Me.btnDistribucion.TabIndex = 7
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
        Me.btnRemoverPP.TabIndex = 5
        Me.btnRemoverPP.Text = "Remover Desc. x P. P."
        '
        'i_ccpaym02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(962, 720)
        Me.Controls.Add(Me.xlk_term_code)
        Me.Controls.Add(Me.Label11)
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
        Me.Name = "i_ccpaym02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Recibo de Ingresos"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccinvcem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccpaymd, System.ComponentModel.ISupportInitialize).EndInit()
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
            SelectStmt = "select count(*) from ccinvcem " & _
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
        Dim dias_dscto, dd As Integer
        Dim Termino As String

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
                    " 'CXC' mod_type," & _
                    " ccopend.disc_date" & _
                    " from ccinvcem " & _
                    " inner join ccopend " & _
                    " on ccinvcem.invce_serial = ccopend.invce_serial" & _
                    " and ccopend.balance <> 0" & _
                    " where ccinvcem.cust_code = " & pcust_code.ToString & _
                    " and ccopend.invce_serial not in(select invce_serial from ccpaymd " & _
                                                            " where  balance = ccopend.balance)" & _
                    " order by ccinvcem.invce_date,ccinvcem.invce_no "

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        If oTable Is Nothing Then
            Throw New ApplicationException("No se encontrarón documentos pendientes!")
        End If

        If oTable.Rows.Count <= 0 Then
            Throw New ApplicationException("No se encontrarón documentos pendientes!")
        End If

        SelectStmt = "select csttype_code from cccustm where cust_code =" & Me.txtcust_code.Text
        tIpo = Val(LibX.Data.Manager.GetScalar(SelectStmt).ToString.Trim)

        SelectStmt = "select term_code from cccustm where cust_code =" & Me.txtcust_code.Text
        Termino = LibX.Data.Manager.GetScalar(SelectStmt)

        oTable.TableName = "ccpaymd"

        lineno = 0

        ccpaymd.Rows.Clear()
        oTermino = New SGT.CXC.Entidades.Termino(Termino)
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

            'If oRow1!dias > dias_dscto And tIpo <> 4 Then
            '    oRow1!disc_amount = 0.0
            '    oRow!disc_amount = 0.0
            'Else
            oRow1!disc_amount = oRow!disc_amount
            ''oRow1!disc_amount = Format(oRow!disc_amount, "##,##0.00")
            'End If

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

        Me.LibXGrid1.refreshFooter()
        xtxt_Balance1.Text = Val(balance.Text.Trim) - Val(Me.LibXGrid1.GetFooterValue(gColDescto1).ToString.Trim)
        '// Calcular
        Calcular()
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
                '// Verificar si hay recibos pendentes de aplicar para este cliente
                ''If ExisteRecibosPendientes(e.row!cust_code) = True Then
                ''    Throw New ApplicationException("Existen recibos de pangos pendientes de aplicar para este cliente, verique!")
                ''End If

                '// Cargar las facturas pendientes de este cliente
                DocumentosPendientes(e.row!cust_code)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Dim XUpdate As LibX.Data.XUpdateStmt

        Try
            oDocument = New SGT.Inventario.Entidades.Documento(mTipoDocumento)

            If e.UpdatingArgs.StatementType = StatementType.Insert _
                Or e.UpdatingArgs.StatementType = StatementType.Update Then
                If ccpaymd.Select("amount>0").Length <= 0 Then
                    Throw New ApplicationException("Debe seleccionar los documentos a aplicar!")
                End If
                If (mTipoDocumento = "RSM" Or mTipoDocumento = "DCC") And Me.XTexChequera.Text = "" Then
                    Throw New ApplicationException("Debe Digitar una chequera!")
                End If

                '// Datos
                e.UpdatingArgs.Row!type_code = mTipoDocumento 'RECIBO DE INGRESO
                e.UpdatingArgs.Row!cargo_desc = Val(Me.LibXGrid1.GetFooterValue(gColDescto1).ToString.Trim)
                If LibX.IsNull(e.UpdatingArgs.Row!invce_date) = True OrElse e.UpdatingArgs.Row!invce_date = #12:00:00 AM# Then
                    e.UpdatingArgs.Row!invce_date = LibXConnector1.CurrentDataRow!invce_date = LibX.Data.Manager.Connection.GetDate
                End If
                e.UpdatingArgs.Row!itbis = 0
                e.UpdatingArgs.Row!suc_code = SCDefault
            End If

            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                If oDocument.AutoNumerar = True Then
                    If mTipoDocumento = "RSM" Or mTipoDocumento = "DCC" Or mTipoDocumento = "RPS" Then
                        e.UpdatingArgs.Row!invce_no = oSdocumento.GetNextNumber(mTipoDocumento)
                    Else
                        e.UpdatingArgs.Row!invce_no = oDocument.GenerateNumber(e.UpdatingArgs.Row!type_code, WhDefault)
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

                '''If mTipoDocumento = "RSM" Then 'RECLAMACION DE SEGURO MEDICOS
                '''    e.UpdatingArgs.Row!invce_ncf = oDocument.GenerateNCF("FPV", WhDefault, Documento.TipoNCFEnum.ConValorFiscal)
                '''End If
            End If

            If e.UpdatingArgs.StatementType = StatementType.Delete Then
                If e.UpdatingArgs.Row.Item("invce_status", DataRowVersion.Original) = 1 Then '// Cobrada Then
                    e.UpdatingArgs.Status = UpdateStatus.SkipAllRemainingRows
                    AnularDocumento(e.UpdatingArgs.Row)
                End If
            End If

            ''// actuliza estatus del cliente
            '//EstatusCliente(txtcust_code.Text)
        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)
            'Throw
        End Try
    End Sub

    Private Sub AnularDocumento(ByVal oRow As DataRow)

        'Dim oPost As SGT.Caja.Operaciones.Cobro
        'Dim oParam As SGT.Caja.Operaciones.Cobro.ParametrosAnular

        'Try
        '    oPost = New SGT.Caja.Operaciones.Cobro
        '    oParam = New SGT.Caja.Operaciones.Cobro.ParametrosAnular

        '    With oParam
        '        .Serial = oRow.Item("invce_serial", DataRowVersion.Original)
        '        .AfectaCXC = True
        '        .UserTransaction = False
        '    End With

        '    oPost.Anular(oParam)

        'Catch ex As Exception
        '    Throw

        'End Try
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
            xlk_cust_code.CheckText = "Balance mayor que 0"

            oParamValidar = New SGT.Administracion.Entidades.Permission.ParametrosValidar
            oAutorizar = New SGT.Administracion.Entidades.Permission
            ofctDocumento = New SGT.Facturacion.Entidades.Documento

            '// Validar Permisos de Usuario
            oParamValidar.UserID = LibX.User.UserID
            WhDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxWhDefault")
            SCDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxSCDefault")

            '// Mostrar los datos de la caja y la cajera
            'Me.LibXGrid1.getCurrentGridView.AllowDelete = False
            Me.LibXGrid1.getCurrentGridView.AllowNew = False

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
        Try

            '// APLICAR
            'If LibXConnector1.IsDataEditing = True And e.row > -1 Then
            If LibXConnector1.IsDataEditing = True Then

                '''If e.cell = Me.gColAplAmount.Column Then
                '''    If LibX.IsNull(e.value) Then
                '''        e.hasErrors = True
                '''        Exit Sub
                '''    End If

                '''    ''//permite elegir las facturas sin marcar el monto
                '''    If MontoDigitado = False Then
                '''        If txtAmount.Text.Length = 0 Then
                '''            txtAmount.Text = Me.LibXGrid1.GetValue(e.row, Me.gColBalance)
                '''        Else
                '''            mResta = txtAmount.Text
                '''            txtAmount.Text = mResta + Me.LibXGrid1.GetValue(e.row, Me.gColBalance)
                '''        End If

                '''        mResta = txtAmount.Text - Descto
                '''    End If

                '''    If mResta <= 0 And MontoDigitado = True Then
                '''        e.hasErrors = True
                '''        Throw New ApplicationException("Ya se aplicó el monto total!")
                '''    End If

                '''    If e.value = True Then
                '''        Me.gColAplAmount.ReadOnly = False
                '''        AsignarMonto(e.row)
                '''    Else
                '''        Me.gColAplAmount.ReadOnly = True
                '''        Me.LibXGrid1.SetValue(e.row, Me.gColAplAmount, 0)
                '''    End If
                '''End If

                '''If e.cell = Me.gColAplAmount.Column And _
                '''Me.LibXGrid1.GetValue(e.row, Me.gColAplicar) = True Then
                '''    If Val(Me.LibXGrid1.GetValue(e.row, Me.gColBalance)) < _
                '''    Val(Me.LibXGrid1.GetValue(e.row, Me.gColAplAmount)) Then
                '''        Throw New ApplicationException("No puede aplicar un monto mayor al valor del documento!")
                '''    End If

                '''    If Val(Me.LibXGrid1.GetValue(e.row, Me.gColAplAmount)) > _
                '''    mResta Then
                '''        Throw New ApplicationException("No puede aplicar un monto mayor que el valor restante!")
                '''    End If
                '''End If

                '''If e.cell = Me.gColDescto1.Column Then
                '''    Dim Descto As Decimal
                '''    Descto = Val(Me.LibXGrid1.GetValue(e.row, Me.gColDescto1))

                '''    If Val(Me.LibXGrid1.GetValue(e.row, Me.gColBalance)) < Descto Then
                '''        Throw New ApplicationException("No puede aplicar un descuento mayor al valor del documento!")
                '''    End If

                '''    Me.LibXGrid1.SetValue(e.row, Me.gColAplAmount, 0.0)
                '''    AsignarMonto(e.row)
                '''End If

                '''Calcular()

                'AsignarMonto(LibXGrid1.CurrentRowIndex)
            End If

        Catch ex As Exception
            e.hasErrors = True
            LibX.Log.Add(ex, True)
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

            '// Remover o Seleccionar el documento
            If LibXConnector1.IsDataEditing = True Then 'And e.row > -1 Then
                AsignarMonto(LibXGrid1.CurrentRowIndex)
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    '''Private Sub AsignarMonto(ByVal Row As Integer)
    '''    Dim Aplicar As Decimal
    '''    Dim DescuentoPP As Decimal
    '''    Dim Disc_Amount As Decimal
    '''    Try
    '''        DescuentoPP = Me.LibXGrid1.GetValue(Row, Me.gColDescto1)
    '''        Aplicar = Me.LibXGrid1.GetValue(Row, Me.gColBalance) - Me.LibXGrid1.GetValue(Row, Me.gColDescto1)

    '''        '// si se aplico reversar
    '''        If Val(Me.LibXGrid1.GetValue(Row, Me.gColAplAmount)) > 0 Then
    '''            Me.LibXGrid1.SetValue(Row, Me.gColAplAmount, 0.0)
    '''            Disc_Amount -= DescuentoPP

    '''            '// Si el monto del documento es menor que la parte a aplicar
    '''            '// asignar el monto del documento como monto a aplicar
    '''        ElseIf Me.LibXGrid1.GetValue(Row, Me.gColBalance) <= mResta Then
    '''            Me.LibXGrid1.SetValue(Row, Me.gColAplAmount, Aplicar)
    '''            Disc_Amount += DescuentoPP

    '''            '// Si el monto de documento es mayor que el monto restante
    '''            '// Asignar el monto restante
    '''        Else
    '''            If Aplicar > mResta Then
    '''                Me.LibXGrid1.SetValue(Row, Me.gColDescto1, 0)
    '''                Me.LibXGrid1.SetValue(Row, Me.gColAplAmount, mResta)
    '''            End If
    '''        End If

    '''        Calcular()
    '''        '//            CalcularNetoAPagar()
    '''    Catch ex As Exception
    '''        Throw
    '''    End Try
    '''End Sub
    '''Private Sub AsignarMonto(ByVal Row As Integer)
    '''    Dim Aplicar As Decimal
    '''    Dim DescuentoPP As Decimal
    '''    Dim Disc_Amount As Decimal
    '''    Try
    '''        DescuentoPP = Val(ccpaymd.Rows(Row)!disc_amount.ToString.Trim)
    '''        Aplicar = Val(ccpaymd.Rows(Row)!balance.ToString.Trim) - Val(ccpaymd.Rows(Row)!disc_amount.ToString.Trim)

    '''        '// si se aplico reversar
    '''        If Val(ccpaymd.Rows(Row)!Amount.ToString.Trim) > 0 Then

    '''            ccpaymd.Rows(Row).BeginEdit()
    '''            ccpaymd.Rows(Row)!Amount = DBNull.Value
    '''            Disc_Amount -= DescuentoPP

    '''            '// Si el monto del documento es menor que la parte a aplicar
    '''            '// asignar el monto del documento como monto a aplicar
    '''        ElseIf Val(ccpaymd.Rows(Row)!balance.ToString.Trim) <= mResta Then
    '''            ccpaymd.Rows(Row).BeginEdit()
    '''            ccpaymd.Rows(Row)!Amount = Aplicar
    '''            Disc_Amount += DescuentoPP

    '''            '// Si el monto de documento es mayor que el monto restante
    '''            '// Asignar el monto restante
    '''        Else
    '''            Aplicar = Format(Aplicar, "##,###,##0.00")
    '''            If Aplicar >= mResta Then
    '''                ccpaymd.Rows(Row).BeginEdit()
    '''                ccpaymd.Rows(Row)!Amount = mResta
    '''                'ccpaymd.Rows(Row)!disc_Amount = DBNull.Value
    '''            End If
    '''        End If

    '''        ccpaymd.Rows(Row).EndEdit()
    '''        Calcular()
    '''        '//            CalcularNetoAPagar()
    '''    Catch ex As Exception
    '''        Throw
    '''    End Try
    '''End Sub

    Private Function CalcularDescuento(ByVal Descuento As String, ByVal Monto As Decimal) As Decimal
        Try
            If Descuento = "" Then
                Descuento = 0
            End If

            If Descuento.EndsWith("%") Then
                Descuento = Descuento.Replace("%", "")
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

    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid1.CurrentRowChanged
        Try
            '''    If LibXConnector1.IsDataEditing = True And e.row > 0 Then
            '''        If LibX.IsNull(LibXGrid1.Item(e.row, 0)) Then
            '''            Me.gColAplAmount.ReadOnly = True
            '''            Exit Sub
            '''        End If

            '''        If LibXGrid1.Item(e.row, 0) = True Then
            '''            Me.gColAplAmount.ReadOnly = False
            '''        Else
            '''            Me.gColAplAmount.ReadOnly = True
            '''        End If
            '''    End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_InsertingDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingDetailRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then
                If LibX.IsNull(e.UpdatingArgs.Row!amount) Or LibX.IsNull(e.UpdatingArgs.Row!line_no) Then
                    e.UpdatingArgs.Status = UpdateStatus.SkipCurrentRow
                    e.UpdatingArgs.Row.AcceptChanges()
                End If
                e.UpdatingArgs.Row!type_code = mTipoDocumento
                e.UpdatingArgs.Row!mod_type = "CXC"
                e.UpdatingArgs.Row!suc_code = SCDefault
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)

        End Try
    End Sub

    Private Sub ccpaymd_RowChanged(ByVal sender As System.Object, ByVal e As System.Data.DataRowChangeEventArgs)
        Try
            ''''    If e.Action = DataRowAction.Add Then
            ''''        If Val(e.Row!amount.ToString) > 0 Then
            ''''            e.Row!Aplicar = 1
            ''''        End If
            ''''    End If


        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub txtAmount_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAmount.Validating
        Try
            If LibXConnector1.IsDataEditing = True Then
                'RemovarAplicar()
                mDigitado = True
                If txtAmount.Text.Length > 0 AndAlso CDbl(Me.txtAmount.Text.Trim) > Val(Me.balance.Text.Trim) Then
                    Throw New ApplicationException("Monto del recibo inváldo!")
                End If

                If txtAmount.Text.Length > 0 Then
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
            '''If e.UpdatingArgs.StatementType = StatementType.Insert Then

            ''''    oPago = New SGT.CXC.Posteos.PostDocument
            ''''    oParamPago = New SGT.CXC.Posteos.PostDocument.ParametrosPagos

            ''''    With oParamPago
            ''''        .Cliente = e.UpdatingArgs.Row!cust_code
            ''''        .Fecha = e.UpdatingArgs.Row!fact_date
            ''''        .Monto = e.UpdatingArgs.Row!fact_total
            ''''        .Numero = e.UpdatingArgs.Row!fact_number
            ''''        .Serial = e.UpdatingArgs.Row!ftserial_no
            ''''        .TipoDocumento = e.UpdatingArgs.Row!type_code
            ''''        .UseTransaction = False

            ''''        For Each oRow As DataRow In ccpaymd.Rows
            ''''            If oRow!Aplicar = 1 Then
            ''''                .Documentos.Add(oRow!invce_serial, oRow!type_code, _
            ''''                                oRow!invce_no, oRow!invce_date, _
            ''''                                oRow!amount, 0, 0, _
            ''''                                e.UpdatingArgs.Row!cust_code, "")
            ''''            End If
            ''''        Next
            ''''    End With

            ''''    oPago.ApliarPago(oParamPago)
            ''''End If

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
                txtAmount.Text = Val(balance.Text.Trim) - Val(LibXGrid1.GetFooterValue(Me.gColDescto1).ToString.Trim)
            Else
                RemovarAplicar()
            End If

            If mResta = 0 Then
                aplicado = Val(LibXGrid1.GetFooterValue(gColAplAmount).ToString.Trim)
                mResta = txtAmount.Text - aplicado
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
                    If mResta > (Val(orow!balance.Tostring.Trim) - Val(orow!disc_amount.Tostring.Trim)) Then
                        mResta -= Val(orow!balance.Tostring.Trim) - Val(orow!disc_amount.Tostring.Trim)
                        orow!amount = (Val(orow!balance.Tostring.Trim) - Val(orow!disc_amount.Tostring.Trim))
                        descto += Format(Val(orow!disc_amount.Tostring.Trim), "##,##0.000")

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
            '//            CalcularNetoAPagar()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        e.AditionalWhere = "ccinvcem.type_code IN ('RCB','DCC','NDC','RSM','RPS')" 'and ccinvcem.whse_code = " & WhDefault.ToString
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
            Aplicar = Val(ccpaymd.Rows(Row)!balance.ToString.Trim) - Format(Val(ccpaymd.Rows(Row)!disc_amount.ToString.Trim), "##,##0.000")

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
                    'cppaymd.Rows(Row)!disc_Amount = DBNull.Value
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
            xParamAdm.Parametros = xParam

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
                LibXConnector1.ExecuteFind("ccinvcem.invce_serial = " & LibXConnector1.CurrentDataRow!invce_serial.ToString.Trim)
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
                Else
                    LibXConnector1.AllowPrint = True
                    LibXConnector1.AllowEdit = False
                End If
            End If

            LibXNavigator1.UpdateState()
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub btnCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheque.Click
        Try
            'ShowPayMethod("CHK")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnTarjeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTarjeta.Click
        Try
            'ShowPayMethod("TAR")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub i_ptvrecib01_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If LibXConnector1.IsEditing = False And LibXConnector1.HasRecords = True Then
                If e.KeyCode = Keys.F9 Then
                    '// CobrarDocumento()
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
            '//            CalcularNetoAPagar()
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub
    Private Sub Calcular()
        Dim Aplicar As Decimal, Aplicado As Decimal, Resta As Decimal
        Dim Descto As Decimal
        Dim i As Integer

        Try
            If txtAmount.Text.Length > 0 Then
                Aplicar = CDbl(txtAmount.Text.Trim) - Descto
            End If

            Aplicado = 0
            mResta = 0

            For i = 0 To LibXGrid1.getCurrentGridView.Count - 1
                If LibXGrid1.GetValue(i, Me.gColAmount) <> "" Then
                    Aplicado += Val(LibXGrid1.GetValue(i, Me.gColAplAmount).ToString)
                End If
            Next

            If mDigitado = False And Aplicado <> 0 Then
                Me.txtAmount.Text = Format(Aplicado, "##,###,##0.00")
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
    ''Private Sub mnuAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAplicar.Click
    ''    Try
    ''        If LibXConnector1.IsDataEditing = True Then
    ''            AsignarMonto(LibXGrid1.CurrentRowIndex)
    ''        End If

    ''    Catch ex As Exception
    ''        LibX.Log.Add(ex, True)
    ''    End Try
    ''End Sub

    ''Private Sub mnuDesaplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDesaplicar.Click
    ''    Try
    ''        If LibXConnector1.IsDataEditing = True Then
    ''            AsignarMonto(LibXGrid1.CurrentRowIndex)
    ''        End If

    ''    Catch ex As Exception
    ''        LibX.Log.Add(ex, True)
    ''    End Try
    ''End Sub
    Private Sub btnIncluirPP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluirPP.Click
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
            Next
            Calcular()

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub gColDescto1_SetCellFormat(ByVal sender As Object, ByVal e As LibX.XDataGridFormatCellEventArgs) Handles gColDescto1.SetCellFormat
        Try
            ''If LibXConnector1.IsDataEditing = True Then
            ''    'If LibX.IsNull(ccpaymd.Rows(e.RowNumber)!due_date) = False AndAlso _
            ''    '     CType(ccpaymd.Rows(e.RowNumber)!due_date, Date) <= LibX.Data.Manager.Connection.GetDate Then
            ''    '    e.ForeColor = System.Drawing.Color.Red
            ''    'End If
            ''End If

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
                'mTipoDocumento = LibXConnector1.CurrentDataRow!type_code

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
    '''Private Sub LibXNavigator1_ActionClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.ActionClick
    '''    Try
    '''        If e.ButtonAction = XMsaComponents.XmsaButtons.Accept Then
    '''            If UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
    '''                LibX.Data.Manager.Connection.CommitTransaction()
    '''                inUseTransaction = False
    '''            End If
    '''        End If

    '''    Catch ex As Exception
    '''        LibX.Log.Add(ex)
    '''    End Try
    '''End Sub
    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        Dim SelectStmt As String
        Try

            If LibXConnector1.CurrentAction = LibxConnectionActions.Edit Then ''_
                '''Or LibXConnector1.CurrentAction = LibxConnectionActions.Add Then
                For i As Integer = 0 To ccpaymd.Rows.Count - 1
                    If ccpaymd.Rows(i).RowState <> DataRowState.Deleted AndAlso LibX.IsNull(ccpaymd.Rows(i)!amount) Then
                        ''DataSet1.Tables("ccpaymd").Rows(i).Delete()
                        ''ccpaymd.Rows(i).Delete()
                        '''For Each oRow As DataRow In cppaymd.Select()
                        '''    'oRow.Delete()
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

        Catch ex As Exception
            e.handled = True
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXNavigator1_ActionClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.ActionClick
        If e.ButtonAction = XMsaComponents.XmsaButtons.Delete Then
            Dim xDelete As LibX.Data.XDeleteStmt
            xDelete = New LibX.Data.XDeleteStmt("ccpaymd")
            xDelete.Fields("paym_serial") = LibXConnector1.CurrentDataRow!invce_serial
            xDelete.Execute()

            xDelete = New LibX.Data.XDeleteStmt("ccinvcem")
            xDelete.Fields("invce_serial") = LibXConnector1.CurrentDataRow!invce_serial
            xDelete.Execute()
        End If
    End Sub
End Class
