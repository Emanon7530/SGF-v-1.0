Imports System.Configuration.ConfigurationSettings
Imports SGT.Inventario.Entidades
Imports LibX
Imports SGT.Inventario.Operaciones

Public Class i_iventr02
    Inherits System.Windows.Forms.Form
    Dim mConfig As SGT.Inventario.Common.Configuration
    Dim mArticulo As SGT.Inventario.Entidades.Articulo
    Dim mAlmacen As SGT.Inventario.Entidades.Almacen
    Dim oDocumento As SGT.Inventario.Entidades.Documento
    Dim oBloqueo As SGT.Inventario.Entidades.Ivbloqueo
    Dim WhereStmt As String
    Dim mPrevPrice As Decimal
    Dim mUnid As String
    Dim Estado As Integer = 0
    Dim ScDefault As Integer
    Dim mGrabado As Decimal
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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox18 As LibX.XTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
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
    Friend WithEvents whse_name As LibX.XTextBox
    Friend WithEvents prov_name As LibX.XTextBox
    Friend WithEvents lk_prov_code As LibX.LibXLookup
    Friend WithEvents lk_whse_code As LibX.LibXLookup
    Friend WithEvents total_amount As LibX.XMaskEdit
    Friend WithEvents disc_amount As LibX.XMaskEdit
    Friend WithEvents itbis_amount As LibX.XMaskEdit
    Friend WithEvents tax_amount As LibX.XMaskEdit
    Friend WithEvents net_amount As LibX.XMaskEdit
    Friend WithEvents txtEntr_Number As LibX.XTextBox
    Friend WithEvents txtwhse_code As LibX.XTextBox
    Friend WithEvents lck_edit_price As LibX.LibxCheckBox
    Friend WithEvents xdt_item_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents xdt_Descr As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_Cantidad As LibX.XEditTextBoxColumn
    Friend WithEvents xck_ITBIS As LibX.LibxCheckBox
    Friend WithEvents xck_dscto As LibX.LibxCheckBox
    Friend WithEvents xck_impto As LibX.LibxCheckBox
    Friend WithEvents btnCostos As System.Windows.Forms.Button
    Friend WithEvents btnProductos As System.Windows.Forms.Button
    Friend WithEvents lk_item_code As LibX.LibXLookup
    Friend WithEvents xdtp_entr_date As LibX.LibxDateTimePicker
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents xtxtterm_name As LibX.XTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents xtxtterm_code As LibX.XTextBox
    Friend WithEvents xlk_term_code As LibX.LibXLookup
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents xdt_entr_status As LibX.LibXCombo
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
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents iventrdm As System.Data.DataTable
    Friend WithEvents iventrdd As System.Data.DataTable
    Friend WithEvents xdt_Oferta As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xdt_Costo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xdt_Itbis As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xdt_ISC As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xdt_Importe As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xdt_Descto As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xdt_Price As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents xck_Oferta As LibX.LibxCheckBox
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents Labelitem_name As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnVencimiento As System.Windows.Forms.Button
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents xlk_ordn_number As LibX.LibXLookup
    Friend WithEvents ordn_number As LibX.XTextBox
    Friend WithEvents txtprov_code As LibX.XTextBox
    Friend WithEvents xdt_UnitCode As LibX.XDataGridTextButtonColumn
    Friend WithEvents xlk_unit_code As LibX.LibXLookup
    Friend WithEvents xcbo_traer As LibX.LibxCheckBox
    Friend WithEvents btnReferencia As System.Windows.Forms.Button
    Friend WithEvents btnEtiquetas As System.Windows.Forms.Button
    Friend WithEvents xdt_Benef As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents txtordn_serial As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Labelexistencia As System.Windows.Forms.Label
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents xdt_Factor As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents prov_name1 As System.Windows.Forms.Label
    Friend WithEvents lbldatelast_purch As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents xtxt_Lote_no As LibX.XEditTextBoxColumn
    Friend WithEvents xtxt_vence_mes As LibX.XEditTextBoxColumn
    Friend WithEvents xtxt_vence_ano As LibX.XEditTextBoxColumn
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lbllast_sales As System.Windows.Forms.Label
    Friend WithEvents lblpromedio As System.Windows.Forms.Label
    Friend WithEvents lblcompras As System.Windows.Forms.Label
    Friend WithEvents lblventas As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.iventrdm = New System.Data.DataTable
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
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.iventrdd = New System.Data.DataTable
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
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.DataColumn61 = New System.Data.DataColumn
        Me.DataColumn62 = New System.Data.DataColumn
        Me.DataColumn63 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.txtEntr_Number = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xlk_ordn_number = New LibX.LibXLookup
        Me.XTextBox3 = New LibX.XTextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.xdt_entr_status = New LibX.LibXCombo
        Me.Label9 = New System.Windows.Forms.Label
        Me.ordn_number = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.xdtp_entr_date = New LibX.LibxDateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.xck_Oferta = New LibX.LibxCheckBox
        Me.xck_ITBIS = New LibX.LibxCheckBox
        Me.xck_dscto = New LibX.LibxCheckBox
        Me.xck_impto = New LibX.LibxCheckBox
        Me.lck_edit_price = New LibX.LibxCheckBox
        Me.xcbo_traer = New LibX.LibxCheckBox
        Me.lk_prov_code = New LibX.LibXLookup
        Me.lk_whse_code = New LibX.LibXLookup
        Me.txtwhse_code = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
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
        Me.total_amount = New LibX.XMaskEdit
        Me.disc_amount = New LibX.XMaskEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.itbis_amount = New LibX.XMaskEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.tax_amount = New LibX.XMaskEdit
        Me.net_amount = New LibX.XMaskEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.xtxtterm_name = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.xtxtterm_code = New LibX.XTextBox
        Me.xlk_term_code = New LibX.LibXLookup
        Me.txtordn_serial = New System.Windows.Forms.TextBox
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.xdt_item_code = New LibX.XDataGridTextButtonColumn
        Me.lk_item_code = New LibX.LibXLookup
        Me.xdt_Descr = New LibX.XEditTextBoxColumn
        Me.xdt_Cantidad = New LibX.XEditTextBoxColumn
        Me.xdt_UnitCode = New LibX.XDataGridTextButtonColumn
        Me.xlk_unit_code = New LibX.LibXLookup
        Me.xdt_Costo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_Oferta = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_Descto = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_Itbis = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_ISC = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_Price = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_Benef = New LibX.XEditTextBoxColumn
        Me.xdt_Importe = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_Factor = New LibX.XEditTextBoxColumn
        Me.xtxt_Lote_no = New LibX.XEditTextBoxColumn
        Me.xtxt_vence_mes = New LibX.XEditTextBoxColumn
        Me.xtxt_vence_ano = New LibX.XEditTextBoxColumn
        Me.btnProductos = New System.Windows.Forms.Button
        Me.btnCostos = New System.Windows.Forms.Button
        Me.btnReferencia = New System.Windows.Forms.Button
        Me.btnVencimiento = New System.Windows.Forms.Button
        Me.Labelitem_name = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.btnEtiquetas = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label18 = New System.Windows.Forms.Label
        Me.Labelexistencia = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.prov_name1 = New System.Windows.Forms.Label
        Me.lbldatelast_purch = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.lbllast_sales = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.lblpromedio = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.lblcompras = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.lblventas = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iventrdm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iventrdd, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXNavigator1.FirstControlInFindMode = Me.txtEntr_Number
        Me.LibXNavigator1.FirstControlInNewMode = Me.txtEntr_Number
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(1030, 24)
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
        Me.LibXConnector1.ModuleName = "INV"
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = "r_iventrd02.rpt"
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
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.iventrdm, Me.iventrdd})
        '
        'iventrdm
        '
        Me.iventrdm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn47, Me.DataColumn46, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn53, Me.DataColumn56})
        Me.iventrdm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"entr_serial"}, True)})
        Me.iventrdm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn2}
        Me.iventrdm.TableName = "iventrdm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "entr_number"
        Me.DataColumn1.MaxLength = 20
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.AutoIncrement = True
        Me.DataColumn2.ColumnName = "entr_serial"
        Me.DataColumn2.DataType = GetType(System.Int32)
        Me.DataColumn2.ReadOnly = True
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "type_code"
        Me.DataColumn3.MaxLength = 3
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "whse_code"
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
        Me.DataColumn6.ColumnName = "entr_date"
        Me.DataColumn6.DataType = GetType(System.DateTime)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "total_amount"
        Me.DataColumn7.DataType = GetType(System.Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "disc_amount"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "itbis_amount"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "aply_impto"
        Me.DataColumn10.DataType = GetType(System.Int16)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "impto_amount"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "aply_dscto"
        Me.DataColumn12.DataType = GetType(System.Int16)
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "entr_status"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "aply_itbis"
        Me.DataColumn14.DataType = GetType(System.Int16)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "edit_price"
        Me.DataColumn15.DataType = GetType(System.Int16)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "date_created"
        Me.DataColumn16.DataType = GetType(System.DateTime)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "userid"
        Me.DataColumn17.MaxLength = 20
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "apli_ofert"
        Me.DataColumn18.DataType = GetType(System.Int16)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "chk_numero"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "ord_numero"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "aply_orden"
        Me.DataColumn21.DataType = GetType(System.Int16)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "term_code"
        Me.DataColumn22.MaxLength = 5
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "mon_code"
        Me.DataColumn39.DataType = GetType(System.Int32)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "fob_amount"
        Me.DataColumn40.DataType = GetType(System.Decimal)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "gastos_gen"
        Me.DataColumn41.DataType = GetType(System.Decimal)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "gastos_aduana"
        Me.DataColumn42.DataType = GetType(System.Decimal)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "tasa"
        Me.DataColumn43.DataType = GetType(System.Decimal)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "entr_cond"
        Me.DataColumn44.DataType = GetType(System.Int32)
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "entr_ncf"
        Me.DataColumn47.MaxLength = 19
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "docs_ncf"
        Me.DataColumn46.MaxLength = 20
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "apply_FOB"
        Me.DataColumn49.DataType = GetType(System.Int32)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "apply_selectivo"
        Me.DataColumn50.DataType = GetType(System.Int32)
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "apply_gravamen"
        Me.DataColumn51.DataType = GetType(System.Int32)
        '
        'DataColumn53
        '
        Me.DataColumn53.AllowDBNull = False
        Me.DataColumn53.ColumnName = "suc_code"
        Me.DataColumn53.DataType = GetType(System.Int32)
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "isc"
        Me.DataColumn56.DataType = GetType(System.Decimal)
        '
        'iventrdd
        '
        Me.iventrdd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn45, Me.DataColumn48, Me.DataColumn52, Me.DataColumn54, Me.DataColumn55, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63})
        Me.iventrdd.TableName = "iventrdd"
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "entr_serial"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.ColumnName = "line_no"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "whse_code"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.AllowDBNull = False
        Me.DataColumn26.ColumnName = "item_code"
        Me.DataColumn26.MaxLength = 10
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "unit_code"
        Me.DataColumn27.MaxLength = 4
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.ColumnName = "qty"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "costo"
        Me.DataColumn29.DataType = GetType(System.Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "dscto"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "itbis"
        Me.DataColumn31.DataType = GetType(System.Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "impto"
        '
        'DataColumn33
        '
        Me.DataColumn33.AllowDBNull = False
        Me.DataColumn33.ColumnName = "price"
        Me.DataColumn33.DataType = GetType(System.Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.AllowDBNull = False
        Me.DataColumn34.ColumnName = "purch_unit_cost"
        Me.DataColumn34.DataType = GetType(System.Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "sales_price"
        Me.DataColumn35.DataType = GetType(System.Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "qty_oferta"
        Me.DataColumn36.DataType = GetType(System.Int32)
        '
        'DataColumn37
        '
        Me.DataColumn37.AllowDBNull = False
        Me.DataColumn37.ColumnName = "item_name"
        Me.DataColumn37.MaxLength = 100
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "Importe"
        Me.DataColumn38.DataType = GetType(System.Decimal)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "costrd"
        Me.DataColumn45.DataType = GetType(System.Decimal)
        '
        'DataColumn48
        '
        Me.DataColumn48.AllowDBNull = False
        Me.DataColumn48.ColumnName = "benef"
        Me.DataColumn48.DataType = GetType(System.Decimal)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "existencia"
        Me.DataColumn52.DataType = GetType(System.Int32)
        '
        'DataColumn54
        '
        Me.DataColumn54.AllowDBNull = False
        Me.DataColumn54.ColumnName = "suc_code"
        Me.DataColumn54.DataType = GetType(System.Int32)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "factor"
        Me.DataColumn55.DataType = GetType(System.Decimal)
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "datelast_purch"
        Me.DataColumn57.DataType = GetType(System.DateTime)
        '
        'DataColumn58
        '
        Me.DataColumn58.AllowDBNull = False
        Me.DataColumn58.ColumnName = "prov_code"
        Me.DataColumn58.DataType = GetType(System.Int32)
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "prov_name"
        Me.DataColumn59.MaxLength = 60
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "lote_no"
        Me.DataColumn60.MaxLength = 20
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "vence_mes"
        Me.DataColumn61.DataType = GetType(System.Int32)
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "vence_ano"
        Me.DataColumn62.DataType = GetType(System.Int32)
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "datelast_sales"
        Me.DataColumn63.DataType = GetType(System.DateTime)
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
        Me.LibXDbSourceTable1.Source = New String() {"select iventrdm.* from iventrdm ", "inner join ivtypem on iventrdm.type_code = ivtypem.type_code", "and ivtypem.type_local = 1"}
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
        Me.LibXDbSourceTable2.LineColName = "line_no"
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"entr_serial=entr_serial", "whse_code=whse_code", "suc_code=suc_code"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = ""
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select iventrdd.*,ivitemv1.item_name,ivitemv1.existencia,", "ivitemv1.datelast_purch, ivitemv1.prov_code,ivitemv1.datelast_sales,", "cpprovm.prov_name", "from iventrdd inner join ivitemv1", "on ivitemv1.item_code = iventrdd.item_code", "and ivitemv1.whse_code = iventrdd.whse_code", "left outer join cpprovm", "on cpprovm.prov_code = ivitemv1.prov_code", "order by iventrdd.entr_serial,iventrdd.line_no"}
        Me.LibXDbSourceTable2.TableName = "iventrdd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'txtEntr_Number
        '
        Me.txtEntr_Number.AcceptsReturn = True
        Me.txtEntr_Number.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEntr_Number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.entr_number"))
        Me.txtEntr_Number.EditInitialValue = Nothing
        Me.txtEntr_Number.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtEntr_Number.FieldDescription = ""
        Me.txtEntr_Number.FindInitialValue = Nothing
        Me.txtEntr_Number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtEntr_Number.IgnoreRequiered = False
        Me.txtEntr_Number.Location = New System.Drawing.Point(88, 24)
        Me.txtEntr_Number.Name = "txtEntr_Number"
        Me.txtEntr_Number.NewInitialValue = Nothing
        Me.txtEntr_Number.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtEntr_Number.Requiered = False
        Me.txtEntr_Number.Size = New System.Drawing.Size(176, 20)
        Me.txtEntr_Number.StatusBarPanelDescripcion = Nothing
        Me.txtEntr_Number.TabIndex = 0
        Me.txtEntr_Number.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xlk_ordn_number)
        Me.GroupBox1.Controls.Add(Me.XTextBox3)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.xdt_entr_status)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.ordn_number)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.xdtp_entr_date)
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
        Me.GroupBox1.Controls.Add(Me.disc_amount)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.itbis_amount)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.tax_amount)
        Me.GroupBox1.Controls.Add(Me.net_amount)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.xtxtterm_name)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.xtxtterm_code)
        Me.GroupBox1.Controls.Add(Me.xlk_term_code)
        Me.GroupBox1.Controls.Add(Me.txtordn_serial)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1016, 176)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'xlk_ordn_number
        '
        Me.xlk_ordn_number.AlternateFieldSearch = Nothing
        Me.xlk_ordn_number.BeginCheck = False
        Me.xlk_ordn_number.CheckText = Nothing
        Me.xlk_ordn_number.ComboMode = False
        Me.xlk_ordn_number.DataMember = Nothing
        Me.xlk_ordn_number.DataSource = Me.LibXConnector1
        Me.xlk_ordn_number.DestParameters = New String() {"ord_numero=ordn_number", "txtordn_serial=ordn_serial"}
        Me.xlk_ordn_number.FilterField = "prov_name"
        Me.xlk_ordn_number.IgnoreFindInBrowseMode = True
        Me.xlk_ordn_number.isCanceled = False
        Me.xlk_ordn_number.Location = New System.Drawing.Point(176, 144)
        Me.xlk_ordn_number.LookCaption = "Ordenes de Compra"
        Me.xlk_ordn_number.Name = "xlk_ordn_number"
        Me.xlk_ordn_number.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_ordn_number.ShowFilter = True
        Me.xlk_ordn_number.ShowMessageNotFound = True
        Me.xlk_ordn_number.ShowWarning = False
        Me.xlk_ordn_number.Size = New System.Drawing.Size(16, 20)
        Me.xlk_ordn_number.SizesColumns = Nothing
        Me.xlk_ordn_number.SizesColumnsTab = Nothing
        Me.xlk_ordn_number.SqlString = New String() {"select ordn_number,ordn_date,cpordnm.prov_code,prov_name,ordn_serial", " from cpordnm, cpprovm", "where cpordnm.prov_code = cpprovm.prov_code "}
        Me.xlk_ordn_number.SQLTab = Nothing
        Me.xlk_ordn_number.SrcParameters = New String() {"ordn_number=ordn_number"}
        Me.xlk_ordn_number.TabIndex = 99
        Me.xlk_ordn_number.TableName = "cpordnm"
        Me.xlk_ordn_number.TabStop = False
        Me.xlk_ordn_number.UseCopyConnection = False
        Me.xlk_ordn_number.UseRowRetrieveEvents = False
        Me.xlk_ordn_number.UseTab = False
        Me.xlk_ordn_number.VisParameters = New String() {"Orden No.=ordn_number", "Fecha=ordn_date", "Suplidor=prov_code", "Nombre=prov_name"}
        Me.xlk_ordn_number.WhereCondition = "ordn_status =2"
        Me.xlk_ordn_number.WhereParameters = Nothing
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.entr_ncf"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(88, 48)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(176, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 2
        Me.XTextBox3.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Location = New System.Drawing.Point(34, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 16)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "N. C. F.:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xdt_entr_status
        '
        Me.xdt_entr_status.AllowDefaultSort = True
        Me.xdt_entr_status.bound = True
        Me.xdt_entr_status.currValue = Nothing
        Me.xdt_entr_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "iventrdm.entr_status"))
        Me.xdt_entr_status.DefaultWhereString = Nothing
        Me.xdt_entr_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xdt_entr_status.EditInitialValue = Nothing
        Me.xdt_entr_status.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_entr_status.FieldDescription = ""
        Me.xdt_entr_status.FindInitialValue = "2"
        Me.xdt_entr_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_entr_status.IgnoreRequiered = False
        Me.xdt_entr_status.Items.AddRange(New Object() {"2-Pendiente Aplicar", "1-Aplicada", "5-EnModificacion"})
        Me.xdt_entr_status.Location = New System.Drawing.Point(440, 48)
        Me.xdt_entr_status.LookupKeyDisplayFields = Nothing
        Me.xdt_entr_status.LookupKeyField = Nothing
        Me.xdt_entr_status.LookupTableName = Nothing
        Me.xdt_entr_status.Name = "xdt_entr_status"
        Me.xdt_entr_status.NewInitialValue = "2"
        Me.xdt_entr_status.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_entr_status.Requiered = False
        Me.xdt_entr_status.Required = False
        Me.xdt_entr_status.Size = New System.Drawing.Size(136, 21)
        Me.xdt_entr_status.SqlString = Nothing
        Me.xdt_entr_status.StatusBarPanelDescripcion = Nothing
        Me.xdt_entr_status.TabIndex = 13
        Me.xdt_entr_status.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(32, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Orden #:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ordn_number
        '
        Me.ordn_number.AcceptsReturn = True
        Me.ordn_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.ord_numero"))
        Me.ordn_number.EditInitialValue = Nothing
        Me.ordn_number.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.ordn_number.FieldDescription = ""
        Me.ordn_number.FindInitialValue = Nothing
        Me.ordn_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.ordn_number.IgnoreRequiered = False
        Me.ordn_number.Location = New System.Drawing.Point(88, 144)
        Me.ordn_number.Name = "ordn_number"
        Me.ordn_number.NewInitialValue = Nothing
        Me.ordn_number.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.ordn_number.Requiered = False
        Me.ordn_number.Size = New System.Drawing.Size(88, 20)
        Me.ordn_number.StatusBarPanelDescripcion = Nothing
        Me.ordn_number.TabIndex = 6
        Me.ordn_number.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(384, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Cheque:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.chk_numero"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(440, 144)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(136, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 7
        Me.XTextBox1.Text = ""
        '
        'xdtp_entr_date
        '
        Me.xdtp_entr_date.CustomFormat = "dd/MM/yyyy"
        Me.xdtp_entr_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "iventrdm.entr_date"))
        Me.xdtp_entr_date.EditInitialValue = Nothing
        Me.xdtp_entr_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_entr_date.FieldDescription = ""
        Me.xdtp_entr_date.FindInitialValue = Nothing
        Me.xdtp_entr_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_entr_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdtp_entr_date.IgnoreRequiered = False
        Me.xdtp_entr_date.Location = New System.Drawing.Point(440, 24)
        Me.xdtp_entr_date.Name = "xdtp_entr_date"
        Me.xdtp_entr_date.NewInitialValue = "now"
        Me.xdtp_entr_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_entr_date.Requiered = False
        Me.xdtp_entr_date.Size = New System.Drawing.Size(136, 20)
        Me.xdtp_entr_date.StatusBarPanelDescripcion = Nothing
        Me.xdtp_entr_date.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.xck_Oferta)
        Me.GroupBox2.Controls.Add(Me.xck_ITBIS)
        Me.GroupBox2.Controls.Add(Me.xck_dscto)
        Me.GroupBox2.Controls.Add(Me.xck_impto)
        Me.GroupBox2.Controls.Add(Me.lck_edit_price)
        Me.GroupBox2.Controls.Add(Me.xcbo_traer)
        Me.GroupBox2.Location = New System.Drawing.Point(840, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(160, 120)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'xck_Oferta
        '
        Me.xck_Oferta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xck_Oferta.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "iventrdm.apli_ofert"))
        Me.xck_Oferta.EditInitialValue = Nothing
        Me.xck_Oferta.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_Oferta.FindInitialValue = Nothing
        Me.xck_Oferta.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_Oferta.IgnoreRequiered = False
        Me.xck_Oferta.KeepEnabled = False
        Me.xck_Oferta.Location = New System.Drawing.Point(8, 64)
        Me.xck_Oferta.Name = "xck_Oferta"
        Me.xck_Oferta.NewInitialValue = Nothing
        Me.xck_Oferta.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_Oferta.ReadOnly = False
        Me.xck_Oferta.Requiered = False
        Me.xck_Oferta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xck_Oferta.Size = New System.Drawing.Size(144, 16)
        Me.xck_Oferta.TabIndex = 3
        Me.xck_Oferta.Text = "Incluir Oferta"
        Me.xck_Oferta.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.xck_Oferta.ThreeState = True
        Me.xck_Oferta.value = Nothing
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
        Me.xck_ITBIS.Size = New System.Drawing.Size(144, 16)
        Me.xck_ITBIS.TabIndex = 0
        Me.xck_ITBIS.Text = "incluir ITBIS"
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
        Me.xck_dscto.Location = New System.Drawing.Point(8, 32)
        Me.xck_dscto.Name = "xck_dscto"
        Me.xck_dscto.NewInitialValue = Nothing
        Me.xck_dscto.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_dscto.ReadOnly = False
        Me.xck_dscto.Requiered = False
        Me.xck_dscto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xck_dscto.Size = New System.Drawing.Size(144, 16)
        Me.xck_dscto.TabIndex = 1
        Me.xck_dscto.Text = "Incluir Descuento"
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
        Me.xck_impto.Location = New System.Drawing.Point(8, 48)
        Me.xck_impto.Name = "xck_impto"
        Me.xck_impto.NewInitialValue = Nothing
        Me.xck_impto.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_impto.ReadOnly = False
        Me.xck_impto.Requiered = False
        Me.xck_impto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xck_impto.Size = New System.Drawing.Size(144, 16)
        Me.xck_impto.TabIndex = 2
        Me.xck_impto.Text = "Incluir Impuestos"
        Me.xck_impto.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.xck_impto.ThreeState = True
        Me.xck_impto.value = Nothing
        '
        'lck_edit_price
        '
        Me.lck_edit_price.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lck_edit_price.Checked = True
        Me.lck_edit_price.CheckState = System.Windows.Forms.CheckState.Checked
        Me.lck_edit_price.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "iventrdm.edit_price"))
        Me.lck_edit_price.EditInitialValue = Nothing
        Me.lck_edit_price.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lck_edit_price.FindInitialValue = Nothing
        Me.lck_edit_price.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lck_edit_price.IgnoreRequiered = False
        Me.lck_edit_price.KeepEnabled = False
        Me.lck_edit_price.Location = New System.Drawing.Point(8, 80)
        Me.lck_edit_price.Name = "lck_edit_price"
        Me.lck_edit_price.NewInitialValue = Nothing
        Me.lck_edit_price.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lck_edit_price.ReadOnly = False
        Me.lck_edit_price.Requiered = False
        Me.lck_edit_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lck_edit_price.Size = New System.Drawing.Size(144, 16)
        Me.lck_edit_price.TabIndex = 4
        Me.lck_edit_price.Text = "Editar Precio"
        Me.lck_edit_price.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lck_edit_price.ThreeState = True
        Me.lck_edit_price.value = 1
        '
        'xcbo_traer
        '
        Me.xcbo_traer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xcbo_traer.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "iventrdm.aply_orden"))
        Me.xcbo_traer.EditInitialValue = Nothing
        Me.xcbo_traer.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_traer.FindInitialValue = Nothing
        Me.xcbo_traer.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_traer.IgnoreRequiered = False
        Me.xcbo_traer.KeepEnabled = False
        Me.xcbo_traer.Location = New System.Drawing.Point(8, 96)
        Me.xcbo_traer.Name = "xcbo_traer"
        Me.xcbo_traer.NewInitialValue = Nothing
        Me.xcbo_traer.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_traer.ReadOnly = False
        Me.xcbo_traer.Requiered = False
        Me.xcbo_traer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xcbo_traer.Size = New System.Drawing.Size(144, 16)
        Me.xcbo_traer.TabIndex = 5
        Me.xcbo_traer.Text = "Traer Orden"
        Me.xcbo_traer.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.xcbo_traer.ThreeState = True
        Me.xcbo_traer.value = Nothing
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
        Me.lk_prov_code.FilterField = "prov_name"
        Me.lk_prov_code.IgnoreFindInBrowseMode = False
        Me.lk_prov_code.isCanceled = False
        Me.lk_prov_code.Location = New System.Drawing.Point(560, 72)
        Me.lk_prov_code.LookCaption = "Suplidores"
        Me.lk_prov_code.Name = "lk_prov_code"
        Me.lk_prov_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lk_prov_code.ShowFilter = True
        Me.lk_prov_code.ShowMessageNotFound = True
        Me.lk_prov_code.ShowWarning = False
        Me.lk_prov_code.Size = New System.Drawing.Size(16, 20)
        Me.lk_prov_code.SizesColumns = New String() {"prov_name=350"}
        Me.lk_prov_code.SizesColumnsTab = Nothing
        Me.lk_prov_code.SqlString = Nothing
        Me.lk_prov_code.SQLTab = Nothing
        Me.lk_prov_code.SrcParameters = New String() {"prov_code=prov_code"}
        Me.lk_prov_code.TabIndex = 14
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
        Me.lk_whse_code.FilterField = "whse_name"
        Me.lk_whse_code.IgnoreFindInBrowseMode = False
        Me.lk_whse_code.isCanceled = False
        Me.lk_whse_code.Location = New System.Drawing.Point(560, 120)
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
        Me.lk_whse_code.TabIndex = 13
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
        Me.txtwhse_code.Location = New System.Drawing.Point(88, 120)
        Me.txtwhse_code.Name = "txtwhse_code"
        Me.txtwhse_code.NewInitialValue = Nothing
        Me.txtwhse_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.Requiered = False
        Me.txtwhse_code.Size = New System.Drawing.Size(104, 20)
        Me.txtwhse_code.StatusBarPanelDescripcion = Nothing
        Me.txtwhse_code.TabIndex = 5
        Me.txtwhse_code.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(29, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Almacen:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 0
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
        Me.whse_name.Location = New System.Drawing.Point(200, 120)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.NewInitialValue = Nothing
        Me.whse_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.ReadOnly = True
        Me.whse_name.Requiered = False
        Me.whse_name.Size = New System.Drawing.Size(360, 20)
        Me.whse_name.StatusBarPanelDescripcion = Nothing
        Me.whse_name.TabIndex = 10
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
        Me.txtprov_code.Location = New System.Drawing.Point(88, 72)
        Me.txtprov_code.Name = "txtprov_code"
        Me.txtprov_code.NewInitialValue = Nothing
        Me.txtprov_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.Requiered = False
        Me.txtprov_code.Size = New System.Drawing.Size(104, 20)
        Me.txtprov_code.StatusBarPanelDescripcion = Nothing
        Me.txtprov_code.TabIndex = 3
        Me.txtprov_code.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(31, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 8
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
        Me.prov_name.Location = New System.Drawing.Point(200, 72)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.NewInitialValue = Nothing
        Me.prov_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.ReadOnly = True
        Me.prov_name.Requiered = False
        Me.prov_name.Size = New System.Drawing.Size(360, 20)
        Me.prov_name.StatusBarPanelDescripcion = Nothing
        Me.prov_name.TabIndex = 10
        Me.prov_name.TabStop = False
        Me.prov_name.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(390, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Fecha:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(840, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Usuario:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox17
        '
        Me.TextBox17.AcceptsReturn = True
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.userid"))
        Me.TextBox17.EditInitialValue = Nothing
        Me.TextBox17.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox17.FieldDescription = ""
        Me.TextBox17.FindInitialValue = Nothing
        Me.TextBox17.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox17.IgnoreRequiered = False
        Me.TextBox17.Location = New System.Drawing.Point(888, 144)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.NewInitialValue = Nothing
        Me.TextBox17.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox17.ReadOnly = True
        Me.TextBox17.Requiered = False
        Me.TextBox17.Size = New System.Drawing.Size(112, 20)
        Me.TextBox17.StatusBarPanelDescripcion = Nothing
        Me.TextBox17.TabIndex = 1
        Me.TextBox17.TabStop = False
        Me.TextBox17.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(625, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Creado:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox18
        '
        Me.TextBox18.AcceptsReturn = True
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.date_created"))
        Me.TextBox18.EditInitialValue = Nothing
        Me.TextBox18.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox18.FieldDescription = ""
        Me.TextBox18.FindInitialValue = Nothing
        Me.TextBox18.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox18.IgnoreRequiered = False
        Me.TextBox18.Location = New System.Drawing.Point(680, 145)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.NewInitialValue = Nothing
        Me.TextBox18.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox18.ReadOnly = True
        Me.TextBox18.Requiered = False
        Me.TextBox18.Size = New System.Drawing.Size(144, 20)
        Me.TextBox18.StatusBarPanelDescripcion = Nothing
        Me.TextBox18.TabIndex = 14
        Me.TextBox18.TabStop = False
        Me.TextBox18.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(384, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Estatus:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(600, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Monto Bruto:"
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
        Me.total_amount.Location = New System.Drawing.Point(680, 24)
        Me.total_amount.Masked = MaskedTextBox.Mask.Decimal
        Me.total_amount.Name = "total_amount"
        Me.total_amount.NewInitialValue = Nothing
        Me.total_amount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.total_amount.Requiered = False
        Me.total_amount.Size = New System.Drawing.Size(144, 20)
        Me.total_amount.StatusBarPanelDescripcion = Nothing
        Me.total_amount.TabIndex = 8
        Me.total_amount.Text = ""
        Me.total_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'disc_amount
        '
        Me.disc_amount.AcceptsReturn = True
        Me.disc_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.disc_amount"))
        Me.disc_amount.EditInitialValue = Nothing
        Me.disc_amount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.disc_amount.FieldDescription = ""
        Me.disc_amount.FindInitialValue = Nothing
        Me.disc_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.disc_amount.IgnoreRequiered = False
        Me.disc_amount.Location = New System.Drawing.Point(680, 48)
        Me.disc_amount.Masked = MaskedTextBox.Mask.Decimal
        Me.disc_amount.Name = "disc_amount"
        Me.disc_amount.NewInitialValue = Nothing
        Me.disc_amount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.disc_amount.Requiered = False
        Me.disc_amount.Size = New System.Drawing.Size(144, 20)
        Me.disc_amount.StatusBarPanelDescripcion = Nothing
        Me.disc_amount.TabIndex = 9
        Me.disc_amount.Text = ""
        Me.disc_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(608, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Descuento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'itbis_amount
        '
        Me.itbis_amount.AcceptsReturn = True
        Me.itbis_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.itbis_amount"))
        Me.itbis_amount.EditInitialValue = Nothing
        Me.itbis_amount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.itbis_amount.FieldDescription = ""
        Me.itbis_amount.FindInitialValue = Nothing
        Me.itbis_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.itbis_amount.IgnoreRequiered = False
        Me.itbis_amount.Location = New System.Drawing.Point(680, 72)
        Me.itbis_amount.Masked = MaskedTextBox.Mask.Decimal
        Me.itbis_amount.Name = "itbis_amount"
        Me.itbis_amount.NewInitialValue = Nothing
        Me.itbis_amount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.itbis_amount.Requiered = False
        Me.itbis_amount.Size = New System.Drawing.Size(144, 20)
        Me.itbis_amount.StatusBarPanelDescripcion = Nothing
        Me.itbis_amount.TabIndex = 10
        Me.itbis_amount.Text = ""
        Me.itbis_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(633, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "ITBIS:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(643, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "ISC:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tax_amount
        '
        Me.tax_amount.AcceptsReturn = True
        Me.tax_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.isc"))
        Me.tax_amount.EditInitialValue = Nothing
        Me.tax_amount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.tax_amount.FieldDescription = ""
        Me.tax_amount.FindInitialValue = Nothing
        Me.tax_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.tax_amount.IgnoreRequiered = False
        Me.tax_amount.Location = New System.Drawing.Point(680, 96)
        Me.tax_amount.Masked = MaskedTextBox.Mask.Decimal
        Me.tax_amount.Name = "tax_amount"
        Me.tax_amount.NewInitialValue = Nothing
        Me.tax_amount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.tax_amount.Requiered = False
        Me.tax_amount.Size = New System.Drawing.Size(144, 20)
        Me.tax_amount.StatusBarPanelDescripcion = Nothing
        Me.tax_amount.TabIndex = 11
        Me.tax_amount.Text = ""
        Me.tax_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.net_amount.Location = New System.Drawing.Point(680, 120)
        Me.net_amount.Masked = MaskedTextBox.Mask.Decimal
        Me.net_amount.Name = "net_amount"
        Me.net_amount.NewInitialValue = Nothing
        Me.net_amount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.net_amount.ReadOnly = True
        Me.net_amount.Requiered = False
        Me.net_amount.Size = New System.Drawing.Size(144, 22)
        Me.net_amount.StatusBarPanelDescripcion = Nothing
        Me.net_amount.TabIndex = 13
        Me.net_amount.TabStop = False
        Me.net_amount.Text = ""
        Me.net_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(609, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total Neto:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxtterm_name
        '
        Me.xtxtterm_name.AcceptsReturn = True
        Me.xtxtterm_name.EditInitialValue = Nothing
        Me.xtxtterm_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtterm_name.FieldDescription = ""
        Me.xtxtterm_name.FindInitialValue = Nothing
        Me.xtxtterm_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtterm_name.IgnoreRequiered = False
        Me.xtxtterm_name.Location = New System.Drawing.Point(200, 96)
        Me.xtxtterm_name.Name = "xtxtterm_name"
        Me.xtxtterm_name.NewInitialValue = Nothing
        Me.xtxtterm_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtterm_name.ReadOnly = True
        Me.xtxtterm_name.Requiered = False
        Me.xtxtterm_name.Size = New System.Drawing.Size(360, 20)
        Me.xtxtterm_name.StatusBarPanelDescripcion = Nothing
        Me.xtxtterm_name.TabIndex = 10
        Me.xtxtterm_name.TabStop = False
        Me.xtxtterm_name.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(31, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Término:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxtterm_code
        '
        Me.xtxtterm_code.AcceptsReturn = True
        Me.xtxtterm_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.term_code"))
        Me.xtxtterm_code.EditInitialValue = Nothing
        Me.xtxtterm_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtterm_code.FieldDescription = ""
        Me.xtxtterm_code.FindInitialValue = Nothing
        Me.xtxtterm_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtterm_code.IgnoreRequiered = False
        Me.xtxtterm_code.Location = New System.Drawing.Point(88, 96)
        Me.xtxtterm_code.Name = "xtxtterm_code"
        Me.xtxtterm_code.NewInitialValue = Nothing
        Me.xtxtterm_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtterm_code.Requiered = False
        Me.xtxtterm_code.Size = New System.Drawing.Size(104, 20)
        Me.xtxtterm_code.StatusBarPanelDescripcion = Nothing
        Me.xtxtterm_code.TabIndex = 4
        Me.xtxtterm_code.Text = ""
        '
        'xlk_term_code
        '
        Me.xlk_term_code.AlternateFieldSearch = Nothing
        Me.xlk_term_code.BeginCheck = False
        Me.xlk_term_code.CheckText = Nothing
        Me.xlk_term_code.ComboMode = False
        Me.xlk_term_code.DataMember = Nothing
        Me.xlk_term_code.DataSource = Me.LibXConnector1
        Me.xlk_term_code.DestParameters = New String() {"term_code=term_code", "xtxtterm_name=term_name"}
        Me.xlk_term_code.FilterField = "term_name"
        Me.xlk_term_code.IgnoreFindInBrowseMode = False
        Me.xlk_term_code.isCanceled = False
        Me.xlk_term_code.Location = New System.Drawing.Point(560, 96)
        Me.xlk_term_code.LookCaption = "Términos"
        Me.xlk_term_code.Name = "xlk_term_code"
        Me.xlk_term_code.PopupSize = New System.Drawing.Size(750, 400)
        Me.xlk_term_code.ShowFilter = True
        Me.xlk_term_code.ShowMessageNotFound = True
        Me.xlk_term_code.ShowWarning = False
        Me.xlk_term_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_term_code.SizesColumns = New String() {"term_name=350"}
        Me.xlk_term_code.SizesColumnsTab = Nothing
        Me.xlk_term_code.SqlString = Nothing
        Me.xlk_term_code.SQLTab = Nothing
        Me.xlk_term_code.SrcParameters = New String() {"term_code=term_code"}
        Me.xlk_term_code.TabIndex = 14
        Me.xlk_term_code.TableName = "cctermm"
        Me.xlk_term_code.TabStop = False
        Me.xlk_term_code.UseCopyConnection = False
        Me.xlk_term_code.UseRowRetrieveEvents = False
        Me.xlk_term_code.UseTab = False
        Me.xlk_term_code.VisParameters = New String() {"Término=term_code", "Nombre=term_name", "Días/Vencimiento=due_days", "% Descuentoi=disc_pct", "Días/Descuento=disc_days"}
        Me.xlk_term_code.WhereCondition = Nothing
        Me.xlk_term_code.WhereParameters = Nothing
        '
        'txtordn_serial
        '
        Me.txtordn_serial.Enabled = False
        Me.txtordn_serial.Location = New System.Drawing.Point(120, 144)
        Me.txtordn_serial.Name = "txtordn_serial"
        Me.txtordn_serial.Size = New System.Drawing.Size(56, 20)
        Me.txtordn_serial.TabIndex = 100
        Me.txtordn_serial.TabStop = False
        Me.txtordn_serial.Text = "TextBox1"
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AllowSorting = False
        Me.LibXGrid1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Articulos"
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.DataMember = "iventrdd"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 216)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(1016, 288)
        Me.LibXGrid1.TabIndex = 2
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = False
        Me.LibXGrid1.UseHandCursor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Por Codigo"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Por Codigo Barra"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Por Referencia Suplidor"
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.xdt_item_code, Me.xdt_Descr, Me.xdt_Cantidad, Me.xdt_UnitCode, Me.xdt_Costo, Me.xdt_Oferta, Me.xdt_Descto, Me.xdt_Itbis, Me.xdt_ISC, Me.xdt_Price, Me.xdt_Benef, Me.xdt_Importe, Me.xdt_Factor, Me.xtxt_Lote_no, Me.xtxt_vence_mes, Me.xtxt_vence_ano})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "iventrdd"
        '
        'xdt_item_code
        '
        Me.xdt_item_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.xdt_item_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
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
        Me.lk_item_code.BeginCheck = True
        Me.lk_item_code.CheckText = "Existencia en 0"
        Me.lk_item_code.ComboMode = False
        Me.lk_item_code.DataMember = Nothing
        Me.lk_item_code.DataSource = Me.LibXConnector1
        Me.lk_item_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "costo=purch_cost", "price=price", "existencia=existencia", "unit_code=purch_unit", "benef=benef", "datelast_purch=datelast_purch", "datelast_sales=datelast_sales"}
        Me.lk_item_code.FilterField = "item_name"
        Me.lk_item_code.IgnoreFindInBrowseMode = True
        Me.lk_item_code.isCanceled = False
        Me.lk_item_code.Location = New System.Drawing.Point(385, 222)
        Me.lk_item_code.LookCaption = "Productos"
        Me.lk_item_code.Name = "lk_item_code"
        Me.lk_item_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lk_item_code.ShowFilter = True
        Me.lk_item_code.ShowMessageNotFound = True
        Me.lk_item_code.ShowWarning = False
        Me.lk_item_code.Size = New System.Drawing.Size(16, 20)
        Me.lk_item_code.SizesColumns = New String() {"item_name=450"}
        Me.lk_item_code.SizesColumnsTab = Nothing
        Me.lk_item_code.SqlString = New String() {"select DISTINCT ivitemv1.item_code", ",ivitemv1.item_name", ",ivitemv1.whse_code", ",ivitemv1.purch_unit", ",isnull(ivitemv1.purch_cost,0) * isnull(ivunitd.factor,0) as purch_cost", ",ivitemv1.price", ",ivitemv1.existencia", ",ivitemv1.benef ", ",ivunitd.factor", ",ivitemv1.prov_code", ",datelast_purch", ",datelast_sales", ",dia", ",prov_name", "from ivitemv1 ", "left outer join ivunitd", "on ivunitd.unit_code = ivitemv1.purch_unit", "and ivunitd.item_code = ivitemv1.item_code", " LEFT OUTER JOIN ivcbarram", " ON ivcbarram.item_code = ivitemv1.item_code", "LEFT OUTER JOIN ivreferm", " ON ivreferm.item_code = ivitemv1.item_code", "LEFT OUTER JOIN cpprovm", " ON cpprovm.prov_code = ivitemv1.prov_code"}
        Me.lk_item_code.SQLTab = Nothing
        Me.lk_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.lk_item_code.TabIndex = 9
        Me.lk_item_code.TableName = "ivitemv1"
        Me.lk_item_code.TabStop = False
        Me.lk_item_code.UseCopyConnection = False
        Me.lk_item_code.UseRowRetrieveEvents = False
        Me.lk_item_code.UseTab = False
        Me.lk_item_code.VisParameters = New String() {"Descripción=item_name", "Costo=purch_cost", "Unidad=purch_unit", "Precio=price", "Existecia=existencia", "Beneficio=benef", "Dias_Compras=dia", "Proveedor=prov_name", "Código=item_code", "Compra=datelast_purch"}
        Me.lk_item_code.WhereCondition = "item_status =1"
        Me.lk_item_code.WhereParameters = "prov_code =?"
        '
        'xdt_Descr
        '
        Me.xdt_Descr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Descr.Format = ""
        Me.xdt_Descr.FormatInfo = Nothing
        Me.xdt_Descr.HeaderText = "Descripción"
        Me.xdt_Descr.ImageList = Nothing
        Me.xdt_Descr.isReadOnly = True
        Me.xdt_Descr.MappingName = "item_name"
        Me.xdt_Descr.MaxLength = 32767
        Me.xdt_Descr.ReadOnly = True
        Me.xdt_Descr.TabStop = True
        Me.xdt_Descr.UseCustomCellFormat = False
        Me.xdt_Descr.Width = 220
        '
        'xdt_Cantidad
        '
        Me.xdt_Cantidad.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_Cantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Cantidad.Format = "###,##0"
        Me.xdt_Cantidad.FormatInfo = Nothing
        Me.xdt_Cantidad.HeaderText = "Cantidadi"
        Me.xdt_Cantidad.ImageList = Nothing
        Me.xdt_Cantidad.isReadOnly = False
        Me.xdt_Cantidad.MappingName = "qty"
        Me.xdt_Cantidad.MaxLength = 32767
        Me.xdt_Cantidad.TabStop = True
        Me.xdt_Cantidad.UseCustomCellFormat = False
        Me.xdt_Cantidad.Width = 50
        '
        'xdt_UnitCode
        '
        Me.xdt_UnitCode.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.xdt_UnitCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_UnitCode.executeFindDuringFill = False
        Me.xdt_UnitCode.Format = ""
        Me.xdt_UnitCode.FormatInfo = Nothing
        Me.xdt_UnitCode.HeaderText = "Unidad"
        Me.xdt_UnitCode.isReadOnly = False
        Me.xdt_UnitCode.Lookup = Me.xlk_unit_code
        Me.xdt_UnitCode.MappingName = "unit_code"
        Me.xdt_UnitCode.MaxLength = 32767
        Me.xdt_UnitCode.TabStop = True
        Me.xdt_UnitCode.UseCustomCellFormat = False
        Me.xdt_UnitCode.Width = 65
        '
        'xlk_unit_code
        '
        Me.xlk_unit_code.AlternateFieldSearch = Nothing
        Me.xlk_unit_code.BeginCheck = False
        Me.xlk_unit_code.CheckText = Nothing
        Me.xlk_unit_code.ComboMode = False
        Me.xlk_unit_code.DataMember = Nothing
        Me.xlk_unit_code.DataSource = Me.LibXConnector1
        Me.xlk_unit_code.DestParameters = New String() {"unit_code=unit_code", "factor=factor"}
        Me.xlk_unit_code.FilterField = Nothing
        Me.xlk_unit_code.IgnoreFindInBrowseMode = True
        Me.xlk_unit_code.isCanceled = False
        Me.xlk_unit_code.Location = New System.Drawing.Point(456, 328)
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
        Me.xlk_unit_code.TabIndex = 16
        Me.xlk_unit_code.TableName = "ivunitv"
        Me.xlk_unit_code.TabStop = False
        Me.xlk_unit_code.UseCopyConnection = False
        Me.xlk_unit_code.UseRowRetrieveEvents = False
        Me.xlk_unit_code.UseTab = False
        Me.xlk_unit_code.VisParameters = New String() {"Codigo=unit_code", "Unidad=unit_name", "Factor=factor"}
        Me.xlk_unit_code.WhereCondition = "unit_type <> 0"
        Me.xlk_unit_code.WhereParameters = Nothing
        '
        'xdt_Costo
        '
        Me.xdt_Costo.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_Costo.Format = "###,##0.00"
        Me.xdt_Costo.FormatInfo = Nothing
        Me.xdt_Costo.HeaderText = "Costoi"
        Me.xdt_Costo.MappingName = "costo"
        Me.xdt_Costo.Width = 70
        '
        'xdt_Oferta
        '
        Me.xdt_Oferta.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_Oferta.Format = "#,##0"
        Me.xdt_Oferta.FormatInfo = Nothing
        Me.xdt_Oferta.HeaderText = "Ofertai"
        Me.xdt_Oferta.MappingName = "qty_oferta"
        Me.xdt_Oferta.Width = 55
        '
        'xdt_Descto
        '
        Me.xdt_Descto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_Descto.Format = "#,##0.00"
        Me.xdt_Descto.FormatInfo = Nothing
        Me.xdt_Descto.HeaderText = "Descuentoi"
        Me.xdt_Descto.MappingName = "dscto"
        Me.xdt_Descto.ReadOnly = True
        Me.xdt_Descto.Width = 65
        '
        'xdt_Itbis
        '
        Me.xdt_Itbis.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_Itbis.Format = "#,##0.00"
        Me.xdt_Itbis.FormatInfo = Nothing
        Me.xdt_Itbis.HeaderText = "ITBISi"
        Me.xdt_Itbis.MappingName = "itbis"
        Me.xdt_Itbis.ReadOnly = True
        Me.xdt_Itbis.Width = 55
        '
        'xdt_ISC
        '
        Me.xdt_ISC.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_ISC.Format = "#,##0.00"
        Me.xdt_ISC.FormatInfo = Nothing
        Me.xdt_ISC.MappingName = "impto"
        Me.xdt_ISC.ReadOnly = True
        Me.xdt_ISC.Width = 0
        '
        'xdt_Price
        '
        Me.xdt_Price.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_Price.Format = "##,##0.00"
        Me.xdt_Price.FormatInfo = Nothing
        Me.xdt_Price.HeaderText = "Precioi"
        Me.xdt_Price.MappingName = "price"
        Me.xdt_Price.ReadOnly = True
        Me.xdt_Price.Width = 70
        '
        'xdt_Benef
        '
        Me.xdt_Benef.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Benef.Format = ""
        Me.xdt_Benef.FormatInfo = Nothing
        Me.xdt_Benef.HeaderText = "% B."
        Me.xdt_Benef.ImageList = Nothing
        Me.xdt_Benef.isReadOnly = False
        Me.xdt_Benef.MappingName = "benef"
        Me.xdt_Benef.MaxLength = 32767
        Me.xdt_Benef.TabStop = True
        Me.xdt_Benef.UseCustomCellFormat = False
        Me.xdt_Benef.Width = 50
        '
        'xdt_Importe
        '
        Me.xdt_Importe.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_Importe.Format = "##,##0.00"
        Me.xdt_Importe.FormatInfo = Nothing
        Me.xdt_Importe.HeaderText = "Importei"
        Me.xdt_Importe.MappingName = "Importe"
        Me.xdt_Importe.ReadOnly = True
        Me.xdt_Importe.Width = 70
        '
        'xdt_Factor
        '
        Me.xdt_Factor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Factor.Format = ""
        Me.xdt_Factor.FormatInfo = Nothing
        Me.xdt_Factor.ImageList = Nothing
        Me.xdt_Factor.isReadOnly = False
        Me.xdt_Factor.MappingName = "factor"
        Me.xdt_Factor.MaxLength = 32767
        Me.xdt_Factor.TabStop = True
        Me.xdt_Factor.UseCustomCellFormat = False
        Me.xdt_Factor.Width = 0
        '
        'xtxt_Lote_no
        '
        Me.xtxt_Lote_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xtxt_Lote_no.Format = ""
        Me.xtxt_Lote_no.FormatInfo = Nothing
        Me.xtxt_Lote_no.HeaderText = "Lote"
        Me.xtxt_Lote_no.ImageList = Nothing
        Me.xtxt_Lote_no.isReadOnly = False
        Me.xtxt_Lote_no.MappingName = "lote_no"
        Me.xtxt_Lote_no.MaxLength = 32767
        Me.xtxt_Lote_no.TabStop = True
        Me.xtxt_Lote_no.UseCustomCellFormat = False
        Me.xtxt_Lote_no.Width = 50
        '
        'xtxt_vence_mes
        '
        Me.xtxt_vence_mes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xtxt_vence_mes.Format = ""
        Me.xtxt_vence_mes.FormatInfo = Nothing
        Me.xtxt_vence_mes.HeaderText = "Mes"
        Me.xtxt_vence_mes.ImageList = Nothing
        Me.xtxt_vence_mes.isReadOnly = False
        Me.xtxt_vence_mes.MappingName = "vence_mes"
        Me.xtxt_vence_mes.MaxLength = 32767
        Me.xtxt_vence_mes.TabStop = True
        Me.xtxt_vence_mes.UseCustomCellFormat = False
        Me.xtxt_vence_mes.Width = 40
        '
        'xtxt_vence_ano
        '
        Me.xtxt_vence_ano.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xtxt_vence_ano.Format = ""
        Me.xtxt_vence_ano.FormatInfo = Nothing
        Me.xtxt_vence_ano.HeaderText = "Año"
        Me.xtxt_vence_ano.ImageList = Nothing
        Me.xtxt_vence_ano.isReadOnly = False
        Me.xtxt_vence_ano.MappingName = "vence_ano"
        Me.xtxt_vence_ano.MaxLength = 32767
        Me.xtxt_vence_ano.TabStop = True
        Me.xtxt_vence_ano.UseCustomCellFormat = False
        Me.xtxt_vence_ano.Width = 40
        '
        'btnProductos
        '
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProductos.Location = New System.Drawing.Point(168, 592)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(72, 23)
        Me.btnProductos.TabIndex = 5
        Me.btnProductos.Text = "&Productos"
        '
        'btnCostos
        '
        Me.btnCostos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCostos.Location = New System.Drawing.Point(88, 592)
        Me.btnCostos.Name = "btnCostos"
        Me.btnCostos.Size = New System.Drawing.Size(72, 23)
        Me.btnCostos.TabIndex = 4
        Me.btnCostos.Text = "&Costos"
        '
        'btnReferencia
        '
        Me.btnReferencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReferencia.Location = New System.Drawing.Point(248, 592)
        Me.btnReferencia.Name = "btnReferencia"
        Me.btnReferencia.Size = New System.Drawing.Size(72, 23)
        Me.btnReferencia.TabIndex = 6
        Me.btnReferencia.Text = "Referencia"
        '
        'btnVencimiento
        '
        Me.btnVencimiento.Enabled = False
        Me.btnVencimiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVencimiento.Location = New System.Drawing.Point(8, 592)
        Me.btnVencimiento.Name = "btnVencimiento"
        Me.btnVencimiento.Size = New System.Drawing.Size(72, 23)
        Me.btnVencimiento.TabIndex = 3
        Me.btnVencimiento.Text = "Vencimiento"
        '
        'Labelitem_name
        '
        Me.Labelitem_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Labelitem_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdd.item_name"))
        Me.Labelitem_name.Location = New System.Drawing.Point(96, 533)
        Me.Labelitem_name.Name = "Labelitem_name"
        Me.Labelitem_name.Size = New System.Drawing.Size(360, 20)
        Me.Labelitem_name.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(32, 536)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 16)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Producto:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnEtiquetas
        '
        Me.btnEtiquetas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEtiquetas.Location = New System.Drawing.Point(328, 592)
        Me.btnEtiquetas.Name = "btnEtiquetas"
        Me.btnEtiquetas.Size = New System.Drawing.Size(72, 23)
        Me.btnEtiquetas.TabIndex = 7
        Me.btnEtiquetas.Text = "Etiqueta"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(680, 536)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 16)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Ventas del Mes"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Labelexistencia
        '
        Me.Labelexistencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Labelexistencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdd.existencia"))
        Me.Labelexistencia.Location = New System.Drawing.Point(584, 536)
        Me.Labelexistencia.Name = "Labelexistencia"
        Me.Labelexistencia.Size = New System.Drawing.Size(88, 20)
        Me.Labelexistencia.TabIndex = 18
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(24, 560)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 16)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Proveedor:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'prov_name1
        '
        Me.prov_name1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.prov_name1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdd.prov_name"))
        Me.prov_name1.Location = New System.Drawing.Point(96, 560)
        Me.prov_name1.Name = "prov_name1"
        Me.prov_name1.Size = New System.Drawing.Size(400, 20)
        Me.prov_name1.TabIndex = 21
        '
        'lbldatelast_purch
        '
        Me.lbldatelast_purch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldatelast_purch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.iventrdd, "datelast_purch"))
        Me.lbldatelast_purch.Location = New System.Drawing.Point(928, 560)
        Me.lbldatelast_purch.Name = "lbldatelast_purch"
        Me.lbldatelast_purch.Size = New System.Drawing.Size(88, 20)
        Me.lbldatelast_purch.TabIndex = 24
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(672, 560)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(93, 16)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "Compras del Mes"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(856, 536)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 16)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "Ult. Venta:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbllast_sales
        '
        Me.lbllast_sales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbllast_sales.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.iventrdd, "datelast_sales"))
        Me.lbllast_sales.Location = New System.Drawing.Point(928, 536)
        Me.lbllast_sales.Name = "lbllast_sales"
        Me.lbllast_sales.Size = New System.Drawing.Size(88, 20)
        Me.lbllast_sales.TabIndex = 28
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(512, 536)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 16)
        Me.Label24.TabIndex = 27
        Me.Label24.Text = "Existencia:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblpromedio
        '
        Me.lblpromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblpromedio.Location = New System.Drawing.Point(584, 560)
        Me.lblpromedio.Name = "lblpromedio"
        Me.lblpromedio.Size = New System.Drawing.Size(88, 20)
        Me.lblpromedio.TabIndex = 26
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(848, 560)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(68, 16)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "Ult. Compra:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblcompras
        '
        Me.lblcompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcompras.Location = New System.Drawing.Point(776, 560)
        Me.lblcompras.Name = "lblcompras"
        Me.lblcompras.Size = New System.Drawing.Size(64, 20)
        Me.lblcompras.TabIndex = 32
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(512, 560)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(56, 16)
        Me.Label28.TabIndex = 31
        Me.Label28.Text = "Promedio:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblventas
        '
        Me.lblventas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblventas.Location = New System.Drawing.Point(776, 536)
        Me.lblventas.Name = "lblventas"
        Me.lblventas.Size = New System.Drawing.Size(64, 20)
        Me.lblventas.TabIndex = 30
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdd.benef"))
        Me.Label19.Location = New System.Drawing.Point(464, 532)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 20)
        Me.Label19.TabIndex = 34
        '
        'i_iventr02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1030, 624)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.lblcompras)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.lblventas)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lbllast_sales)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.lblpromedio)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lbldatelast_purch)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.prov_name1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Labelexistencia)
        Me.Controls.Add(Me.btnEtiquetas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.xlk_unit_code)
        Me.Controls.Add(Me.Labelitem_name)
        Me.Controls.Add(Me.btnVencimiento)
        Me.Controls.Add(Me.btnReferencia)
        Me.Controls.Add(Me.lk_item_code)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.btnProductos)
        Me.Controls.Add(Me.btnCostos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "i_iventr02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Entrada de Almacén Locales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iventrdm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iventrdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid1.CurrentRowChanged
        Try
            If LibXConnector1.IsDataEditing = True _
            And LibXConnector1.CurrentAction <> LibX.LibxConnectionActions.Cancel Then
                '//LibXGrid1.refreshFooter()
                CalcularRubros(e.previousRow)
            End If
            'Me.Label19.Text = LibXGrid1.CurrentRowIndex + 1

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub total_amount_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles total_amount.Validating
        Try
            If LibXConnector1.IsDataEditing = True Then
                If Val(Me.total_amount.Text.Trim) <= 0 Then
                    Throw New ApplicationException("Monto inválido, por favor revisar!")
                End If

                CalcularNeto()
            End If
        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub iventrdd_RowDeleted(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles iventrdd.RowDeleted
        Try
            If LibXConnector1.IsDataEditing = True Then
                CalcularNeto()
                LibXGrid1.refreshFooter()
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub CalcularRubros(ByVal iRow As Integer)
        Dim Descuento As Decimal
        Try
            If LibXConnector1.IsDataEditing Then
                If iRow >= iventrdd.Rows.Count Then
                    Exit Sub
                End If

                If iventrdd.Rows(iRow).RowState = DataRowState.Deleted _
                Or iventrdd.Rows(iRow).RowState = DataRowState.Detached Then
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
                    Exit Sub
                End If

                If txtwhse_code.Text.Length <= 0 Then
                    Throw New ApplicationException("Debe especificar el almacén!")
                End If

                Dim oParam As New Articulo.ParametrosCostosLocales

                With oParam
                    .Producto = iventrdd.Rows(iRow)!item_code.ToString
                    .Almacen = CType(txtwhse_code.Text, Integer)
                    .Costo = Val(iventrdd.Rows(iRow)!costo.ToString)
                    .Cantidad = Val(iventrdd.Rows(iRow)!qty.ToString)
                    .Ofertas = Val(iventrdd.Rows(iRow)!qty_oferta.ToString)
                    .UnidadCompra = iventrdd.Rows(iRow)!unit_code.ToString
                    .Descuento = iventrdd.Rows(iRow)!dscto.ToString
                    .ISC = iventrdd.Rows(iRow)!impto.ToString

                    If LibX.IsNull(iventrdd.Rows(iRow)!benef) = False Then
                        .Beneficio = iventrdd.Rows(iRow)!benef
                    End If

                    .incluirOFERTA = xck_Oferta.Checked
                    .IncluirITBISUno = xck_ITBIS.Checked
                    .incluirISC = xck_impto.Checked
                    .IncluirDescuento = xck_dscto.Checked

                    If lck_edit_price.Checked = True Then
                        .Precio = iventrdd.Rows(iRow)!price
                    End If

                    .TotalFactura = Val(Me.total_amount.Text)
                    .Importe = Val(iventrdd.Rows(iRow)!importe.ToString)
                    '.Descuento = Val(Me.disc_amount.Text.Trim)
                    .TotalITBISUno = Val(Me.itbis_amount.Text.Trim)
                    '.TotalISC = Val(Me.tax_amount.Text.Trim)
                End With

                '// Importe = Qty * price
                If mArticulo.CalcularCostoLocal(oParam) = True Then
                    '// Iniciar Editar
                    iventrdd.Rows(iRow).BeginEdit()

                    If lck_edit_price.Checked = False Then
                        iventrdd.Rows(iRow)!price = Decimal.Round(oParam.ValoresRetorno.Precio, 0) '/ mConfig.GetTasaUS
                        iventrdd.Rows(iRow)!sales_price = Decimal.Round(oParam.ValoresRetorno.Precio, 0)
                    Else
                        iventrdd.Rows(iRow)!sales_price = Decimal.Round(iventrdd.Rows(iRow)!price, 0)
                    End If

                    iventrdd.Rows(iRow)!purch_unit_cost = Decimal.Round(oParam.ValoresRetorno.costo, 2) '/ mConfig.GetTasaUS
                    iventrdd.Rows(iRow)!dscto = Decimal.Round(oParam.ValoresRetorno.descuento, 2)
                    iventrdd.Rows(iRow)!itbis = Decimal.Round(oParam.ValoresRetorno.Itbis, 2)
                    iventrdd.Rows(iRow)!impto = Decimal.Round(oParam.ValoresRetorno.Impto, 2)
                    iventrdd.Rows(iRow)!benef = Decimal.Round(oParam.ValoresRetorno.Beneficio, 2)

                    '// Finalizar Editar
                    iventrdd.Rows(iRow).EndEdit()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub
    Private Function CalcularNeto() As Boolean
        Dim TotalAmount As Decimal
        Dim DiscAmount As Decimal
        Dim TaxAmount As Decimal
        Dim ItbisAmount As Decimal
        Dim Amount As Decimal
        Try
            If total_amount.Text.Length <= 0 Then
                Return True
            End If

            TotalAmount = CType(total_amount.Text, Decimal)

            If disc_amount.Text.Length > 0 Then
                DiscAmount = CType(disc_amount.Text, Decimal)
                xdt_Descto.ReadOnly = False
            Else
                DiscAmount = 0
                xdt_Descto.ReadOnly = True
            End If

            If tax_amount.Text.Length > 0 Then
                TaxAmount = CType(tax_amount.Text, Decimal)
                xdt_ISC.ReadOnly = False
            Else
                TaxAmount = 0
                xdt_ISC.ReadOnly = True
            End If

            If itbis_amount.Text.Length > 0 Then
                ItbisAmount = CType(itbis_amount.Text, Decimal)
                mGrabado = ItbisAmount / (mConfig.GetITBIS / 100)
                'xdt_Itbis.ReadOnly = False
            Else
                ItbisAmount = 0
                'xdt_Itbis.ReadOnly = True
            End If

            Amount = (TotalAmount + TaxAmount + ItbisAmount) - DiscAmount
            net_amount.Text = Format(Amount, "###,###,##0.00")

            Return True
        Catch ex As Exception
            LibX.Log.Show(ex)
            Return False
        End Try

    End Function

    Private Sub disc_amount_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles disc_amount.Validating
        CalcularNeto()
    End Sub

    Private Sub itbis_amount_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles itbis_amount.Validating
        CalcularNeto()
    End Sub

    Private Sub tax_amount_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles tax_amount.Validating
        CalcularNeto()
    End Sub

    Private Sub i_iventr02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: Calculo con % en el Grid
            '// Para que funcione el calculo de Porciento en el Grid, hay que cambiar el tipo 
            '// de datos de las columnas Descuento y ISC debe cambiarse a STRING
            mConfig = New SGT.Inventario.Common.Configuration

            iventrdd.Columns("item_code").MaxLength = 20
            '//iventrdd.Columns("Importe").Expression = "isnull(qty,0)*isnull(costo,0)"
            iventrdd.Columns("Importe").Expression = "qty*costo"
            'iventrdd.Columns("qty_oferta").DefaultValue = 0

            mArticulo = New SGT.Inventario.Entidades.Articulo
            mAlmacen = New SGT.Inventario.Entidades.Almacen
            oDocumento = New SGT.Inventario.Entidades.Documento("CRD")
            oBloqueo = New SGT.Inventario.Entidades.Ivbloqueo


            LibXGrid1.footerOperations.add("item_code", "count(item_code)")
            LibXGrid1.footerOperations.add("Importe", "sum(Importe)")
            LibXGrid1.footerOperations.add("itbis", "sum(itbis)")
            LibXGrid1.footerOperations.add("qty_oferta", "count(qty_oferta)", "qty_oferta > 0")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub
    Private Sub iventr01_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim SelSelectmt As String
        Try
            SelSelectmt = "delete from ivbloqueo where type_code ='CRD'"
            LibX.Data.Manager.ExecuteNonQuery(SelSelectmt)

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub lk_item_code_BeforeExecuteQuery(ByVal sender As System.Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lk_item_code.BeforeExecuteQuery
        Try
            If txtwhse_code.Text.Length > 0 Then
                e.aditionalWhere = "ivitemv1.whse_code = " & txtwhse_code.Text

                '// si se esta agregando o editando leer por el codigo de barra y la referencia del suplidor
                If LibXConnector1.IsDataEditing = True Then
                    If Len(LibXGrid1.GetValue(xdt_item_code).Trim) >= 8 And IsNumeric(LibXGrid1.GetValue(xdt_item_code).Trim) Then
                        e.SQL = e.SQL.Replace("ivitemv1.item_code =", "ivcbarram.barra =")
                    End If
                    If Len(LibXGrid1.GetValue(xdt_item_code).Trim) <> 6 And Len(LibXGrid1.GetValue(xdt_item_code).Trim) <> 8 And _
                       Len(LibXGrid1.GetValue(xdt_item_code).Trim) < 11 And IsNumeric(LibXGrid1.GetValue(xdt_item_code).Trim) Then
                        e.aditionalWhere = String.Concat(e.aditionalWhere, " and ivreferm.prov_code = " & txtprov_code.Text)
                        e.SQL = e.SQL.Replace("ivitemv1.item_code =", "ivreferm.refer =")
                    End If
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_RowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange
        If Not e.row Is Nothing Then

            If LibXConnector1.IsDataEditing = True Then
                CalcularNeto()
            End If
        End If
    End Sub

    'Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
    '    Dim SelecStmt As String
    '    Dim AxCrystalReport1 As LibX.ReportLib
    '    Try
    '        If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
    '            '// Tomar el Connection String del config
    '            AxCrystalReport1 = New LibX.ReportLib("INV", "r_iventrd02.rpt")
    '            WhereStmt = String.Concat("iventrdm.type_code = '", LibXConnector1.CurrentDataRow!type_code.ToString, "'", _
    '                                     " and iventrdm.entr_number = ", LibXConnector1.CurrentDataRow!entr_number.ToString)

    '            With AxCrystalReport1
    '                '// Recibir el SQL Query
    '                .RetrieveSQLQuery()
    '                SelecStmt = .SQLQuery
    '                SelecStmt = LibX.MdlUtil.ReplaceWherePart(SelecStmt, WhereStmt)
    '                .SQLQuery = SelecStmt

    '                '// Ejecutar el reporte
    '                .Action = 1
    '            End With
    '        End If

    '    Catch ex As Exception
    '        LibX.Log.Show(ex)

    '    End Try
    'End Sub

    Private Sub LibxCheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lck_edit_price.CheckedChanged
        If lck_edit_price.Checked = True Then
            xdt_Price.ReadOnly = False
            xdt_Benef.ReadOnly = True
            xdt_Benef.TextBox.BackColor = System.Drawing.Color.Gray
        Else
            xdt_Price.ReadOnly = True
            xdt_Benef.ReadOnly = False
        End If
    End Sub

    Private Sub btnCostos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCostos.Click
        Try
            If LibXGrid1.CurrentRowIndex <= -1 Then
                Exit Sub
            End If

            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, Me.xdt_item_code).Trim = "" Then
                Exit Sub
            End If

            Dim param As New LibX.LibxPrgParams

            With param
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowPrint = False
                .AllowQuery = False
                .WhereToExecute = "ivitemd.item_code = '" & LibXGrid1.GetCurrentRowView!item_code & _
                                "' and ivitemd.whse_code = " & Me.txtwhse_code.Text.Trim
                .IsFromOther = True
            End With

            LibX.App.CurrentPrgParams = param
            LibX.LibXRunner.Run("i_ivitem02", "INV", True)
            'LibXConnector1.ExecuteFind()

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub btnProductos_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductos.Click
        Try
            If LibXGrid1.CurrentRowIndex <= -1 Then
                Exit Sub
            End If

            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, Me.xdt_item_code).Trim = "" Then
                Exit Sub
            End If

            Dim param As New LibX.LibxPrgParams
            With param
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowPrint = False
                .AllowQuery = False
                .IsFromOther = True
                .WhereToExecute = "ivitemm.item_code = '" & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, Me.xdt_item_code).Trim & "'"
            End With

            LibX.App.CurrentPrgParams = param
            LibX.LibXRunner.Run("i_ivitem01", "INV", True)
            'LibXConnector1.ExecuteFind()

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Dim xUpdate As LibX.Data.XUpdateStmt

        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                e.UpdatingArgs.Row!type_code = "CRD" ' COMPRA EN DOLARES
                e.UpdatingArgs.Row!suc_code = LibX.User.Sucursal
                e.UpdatingArgs.Row!date_created = LibX.Data.Manager.GetScalar("select getdate()")
                e.UpdatingArgs.Row!impto_amount = mGrabado

                If Not e.UpdatingArgs.Row!ord_numero Is DBNull.Value Then
                    xUpdate = New LibX.Data.XUpdateStmt("cpordnm")

                    xUpdate.FieldsSet("ordn_status") = 3 '// APLICADA
                    xUpdate.Fields("ordn_number") = e.UpdatingArgs.Row!ord_numero
                    xUpdate.Execute()
                End If
            End If

            If e.UpdatingArgs.StatementType = StatementType.Delete Then
                If Not e.UpdatingArgs.Row.Item("ord_numero", DataRowVersion.Original) Is DBNull.Value Then
                    xUpdate = New LibX.Data.XUpdateStmt("cpordnm")

                    xUpdate.FieldsSet("ordn_status") = 2 '// PENDIENTE APLICAR
                    xUpdate.Fields("ordn_number") = e.UpdatingArgs.Row.Item("ord_numero", DataRowVersion.Original)
                    xUpdate.Execute()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        e.AditionalWhere = "iventrdm.type_code = 'CRD'"
        WhereStmt = e.Where
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            LibX.LibXRunner.Run("i_ivbrand01", "INV")
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            LibX.LibXRunner.Run("i_ivgroup01", "INV")

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            LibX.LibXRunner.Run("i_cpprovm01", "CXP")

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReferencia.Click

        Dim oParametro As LibX.LibxPrgParams
        Try
            oParametro = New LibX.LibxPrgParams
            If Not Me.LibXConnector1.Parameters Is Nothing Then
                oParametro.AllowEdit = Me.LibXConnector1.Parameters.AllowEdit
                oParametro.AllowQuery = Me.LibXConnector1.Parameters.AllowQuery
                oParametro.AllowPrint = Me.LibXConnector1.Parameters.AllowPrint
                oParametro.AllowDelete = Me.LibXConnector1.Parameters.AllowDelete
                oParametro.AllowNew = Me.LibXConnector1.Parameters.AllowNew
            End If

            If LibXGrid1.CurrentRowIndex <= -1 Then
                Exit Sub
            End If

            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, Me.xdt_item_code).Trim = "" Then
                Exit Sub
            End If

            With oParametro
                .IsFromOther = True
                .initMode = LibX.LibxInitModes.Edit
                .AllowNew = False
                .AllowDelete = False
            End With

            oParametro = New LibX.LibxPrgParams
            oParametro.WhereToExecute = "item_code = '" & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, Me.xdt_item_code) & "'"

            LibX.App.CurrentPrgParams = oParametro
            LibX.LibXRunner.Run("i_ivreferm02", "INV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            LibX.LibXRunner.Run("i_ivcobm01", "INV")

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVencimiento.Click
        Dim oParam As LibX.LibxPrgParams
        Try

            oParam = New LibX.LibxPrgParams
            oBloqueo = New SGT.Inventario.Entidades.Ivbloqueo
            With oParam
                .AllowDelete = True
                .AllowEdit = True
                .AllowNew = False
                .AllowQuery = False
                .IsFromOther = True
                '.initMode = LibxInitModes.Edit
                .WhereToExecute = "doc_serial = " & LibXConnector1.CurrentDataRow!entr_serial & " and type_code ='CRD'"
            End With
            If oBloqueo.BuscarBloqueo(LibXConnector1.CurrentDataRow!entr_serial, "CRD") = True Then
                Throw New ApplicationException("Este Documento esta en modificacion")
            Else
                oBloqueo.BloquearDocumento(LibXConnector1.CurrentDataRow!entr_serial, "CRD")
            End If

            LibX.App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("i_ivcmtod", "INV", True)

            oBloqueo.BorrarBloqueo(LibXConnector1.CurrentDataRow!entr_serial, "CRD")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub lk_prov_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lk_prov_code.AfterSetValues
        If e.dataFound = False Then
            txtprov_code.Focus()
            Exit Sub
        End If

        Try
            If LibXConnector1.IsDataEditing = True Then
                xtxtterm_code.Text = e.row!term_code
                xlk_term_code.ExecuteFind()

                If Me.txtEntr_Number.Text.Trim <> "" Then
                    If oDocumento.ExisteDocumento(e.row!prov_code, Me.txtEntr_Number.Text, "CRD") = True Then
                        Throw New ApplicationException("Existe este numero de factura para este suplidor!")
                    End If
                End If
            End If

        Catch ex As Exception
            e.handled = True
            Me.txtprov_code.Text = ""
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        xdt_entr_status.currValue = 2 'Pendiente Aplicar
        xdtp_entr_date.Value = LibX.Data.Manager.Connection.GetDate.ToShortDateString
        LibXConnector1.CurrentDataRow!entr_date = LibX.Data.Manager.Connection.GetDate
        Me.txtwhse_code.Text = LibX.User.WhDefault
        Me.lk_whse_code.ExecuteFind()

    End Sub
    Private Sub xck_ITBIS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xck_ITBIS.CheckedChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                If iventrdd.Rows.Count > 0 Then
                    Recalcular()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub xck_dscto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xck_dscto.CheckedChanged
        '// Si marco "Traspasar Descuento" debe
        '// detenerse en la columna descuento para
        '// para digitar el monto del descuento
        '// xdt_Descto.ReadOnly = Not xck_dscto.Checked

        Try
            If LibXConnector1.IsDataEditing = True Then
                If iventrdd.Rows.Count > 0 Then
                    Recalcular()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub xck_impto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xck_impto.CheckedChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                If iventrdd.Rows.Count > 0 Then
                    Recalcular()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub lk_item_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lk_item_code.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If
            If LibX.IsNull(e.row!factor) Then
                Throw New ApplicationException("Este producto tiene la unidad mal definida,Verifique")
            End If

            LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, xdt_Factor, e.row!factor)
            mPrevPrice = e.row!price
            Labelexistencia.Text = e.row!existencia.ToString()
            Labelitem_name.Text = e.row!item_name.ToString()
            prov_name1.Text = e.row!prov_name.ToString()

            If Not e.row!datelast_purch Is DBNull.Value Then
                lbldatelast_purch.Text = CDate(e.row!datelast_purch).ToString("dd/MM/yyyy")
            End If
            If Not e.row!datelast_sales Is DBNull.Value Then
                lbllast_sales.Text = CDate(e.row!datelast_sales).ToString("dd/MM/yyyy")
            End If

            ShowInfo(e.row!item_code.ToString())

        Catch ex As Exception
            LibX.Log.Show(ex)
            'Finally
            '''    lk_item_code.Dispose()
        End Try
    End Sub

    Private Sub ShowInfo(ByVal pitem_code As String)
        Dim oRow As DataRow

        oRow = LibX.Data.Manager.GetDataRow("SELECT * FROM ESTATISTICA_PRODUCTO WHERE ANO =" & _
                                            DateTime.Now.Year.ToString() + " AND Mes = " & _
                                            DateTime.Now.Month.ToString() + "AND item_code = '" & _
                                            pitem_code & "'")

        If Not oRow Is Nothing Then
            lblventas.Text = oRow!ventas.ToString()
            lblcompras.Text = oRow!compras.ToString()
        End If



    End Sub
    Private Sub Recalcular()
        Try

            For idxRow As Integer = 0 To LibXGrid1.getCurrentGridView.Count - 1
                CalcularRubros(idxRow)
            Next

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub disc_amount_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles disc_amount.Validated
        If LibXConnector1.IsDataEditing = True Then
            If Val(disc_amount.Text.Trim) > 0 Then
                'Me.xdt_Descto.ReadOnly = False
                Me.xck_dscto.Enabled = True
            Else
                'Me.xdt_Descto.ReadOnly = True
                Me.xck_dscto.Enabled = False
                Me.xck_dscto.Checked = False
            End If
        End If
    End Sub

    Private Sub itbis_amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itbis_amount.TextChanged
        If LibXConnector1.IsDataEditing = True Then
            If Val(itbis_amount.Text.Trim) > 0 Then
                'Me.xdt_Itbis.ReadOnly = False
                Me.xck_ITBIS.Enabled = True
            Else
                'Me.xdt_Itbis.ReadOnly = True
                Me.xck_ITBIS.Enabled = False
                Me.xck_ITBIS.Checked = False
            End If
        End If

    End Sub

    Private Sub tax_amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tax_amount.TextChanged
        If LibXConnector1.IsDataEditing = True Then
            If Val(tax_amount.Text.Trim) > 0 Then
                'Me.xdt_ISC.ReadOnly = False
                Me.xck_impto.Enabled = True
            Else
                'Me.xdt_ISC.ReadOnly = True
                Me.xck_impto.Enabled = False
                Me.xck_impto.Checked = False
            End If
        End If

    End Sub

    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
        Dim oValidarPrecio As Articulo.ParametrosPrecioValido
        Dim Descuento As Decimal
        Dim Monto As Decimal
        Try
            '''If Me.LibXGrid1.GetColNum(Me.xdt_Price) = e.cell Then
            '''    Exit Sub
            '''End If

            If Me.total_amount.Text.Length <= 0 Then
                e.hasErrors = True
                LibXGrid1.SetValue(e.row, Me.xdt_item_code, "")
                Throw New ApplicationException("Debe digitar el Monto de la factura antes de digitar los productos!")
            End If

            ''''// Validar cantidad
            '''If Me.xdt_item_code.Column = e.cell Then
            '''    If e.value.ToString.Trim = "" Then
            '''        e.hasErrors = True
            '''        Exit Sub
            '''    End If
            '''End If
            If e.cell = Me.xdt_item_code.Column Or e.cell = Me.xdt_Cantidad.Column Or e.cell = Me.xdt_UnitCode.Column Then
                If LibXGrid1.GetValue(e.row, xdt_item_code) = "" Then
                    LibXGrid1.Focus(e.row, 0)
                    Exit Sub
                End If
                If e.cell = Me.xdt_Cantidad.Column Then
                    If LibXGrid1.GetValue(e.row, xdt_Cantidad) = "" Then
                        LibXGrid1.Focus(e.row, 2)
                        Exit Sub
                    End If
                End If

                If LibX.IsNull(e.value) Then
                    e.hasErrors = True
                    Exit Sub
                End If
            End If

            '// Validar cantidad
            If Me.xdt_Cantidad.Column = e.cell Then
                If LibXGrid1.GetValue(e.row, Me.xdt_item_code).ToString.Trim = "" Then
                    LibXGrid1.Focus(e.row, 0)
                    Exit Sub
                End If

                If Val(e.value.ToString.Trim) <= 0 Then
                    e.hasErrors = True
                    Exit Sub
                End If

                mPrevPrice = Me.LibXGrid1.GetValue(e.row, Me.xdt_Price)
            End If

            If e.cell = Me.xdt_UnitCode.Column Then
                'If LibXGrid1.GetValue(e.row, xdt_Cantidad) = "" Then
                If LibX.IsNull(e.value) Then
                    LibXGrid1.Focus(e.row, e.cell)
                    Exit Sub
                End If
            End If

            'If LibX.IsNull(e.value) Then
            '    e.hasErrors = True
            '    Exit Sub
            'End If

            '// Validar costo
            If Me.LibXGrid1.GetColNum(Me.xdt_Costo) = e.cell Then
                If Val(e.value.ToString.Trim) <= 0 Then
                    e.hasErrors = True
                End If
                If Me.LibXGrid1.GetValue(e.row, Me.xdt_Price).ToString.Trim <> "" Then mPrevPrice = Me.LibXGrid1.GetValue(e.row, Me.xdt_Price)
            End If

            '// Validar Precio
            If Me.LibXGrid1.GetColNum(Me.xdt_Price) = e.cell Then
                If Val(e.value.ToString.Trim) <= 0 And LibXGrid1.GetValue(e.row, Me.xdt_item_code).ToString.Trim = "" Then
                    'Throw New Applibxconnetor1licationException("Precio inválido!")
                    MessageBox.Show("No hay unidad Asignada, Precio Invalido")
                    LibXGrid1.Focus(e.row, 0)
                End If

                If lck_edit_price.Checked = True Then
                    oValidarPrecio = New Articulo.ParametrosPrecioValido

                    oValidarPrecio.Producto = Me.LibXGrid1.GetValue(e.row, Me.xdt_item_code)
                    oValidarPrecio.Almacen = Me.txtwhse_code.Text
                    oValidarPrecio.Precio = e.value
                    oValidarPrecio.Unidad = Me.LibXGrid1.GetValue(Me.xdt_UnitCode)
                    oValidarPrecio.Costo = Me.LibXGrid1.GetValue(e.row, Me.xdt_Costo)

                    If mArticulo.isPrecioValido(oValidarPrecio) = False Then
                        Me.LibXGrid1.SetValue(e.row, Me.xdt_Price, mPrevPrice)
                        Throw New ApplicationException("Precio invalido!")
                    End If
                End If
            End If

        Catch ex As Exception
            e.hasErrors = True
            LibX.Log.Show(ex)
        End Try
    End Sub


    Private Function ValidarCostoyPrecio()

    End Function
    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            Dim ErrDistr As Boolean = False
            If (e.AcceptedAction = LibX.LibxConnectionActions.None) _
            And e.Action = LibX.LibxConnectionActions.Delete Then
                If LibXConnector1.CurrentDataRow!entr_status = 1 Then
                    e.Handled = True
                    If Anular() Then
                        LibX.Data.Manager.ExecuteNonQuery("update iventrdm set entr_status = 2 where entr_serial = " & LibXConnector1.CurrentDataRow!entr_serial.ToString())
                        LibXConnector1.ExecuteFind("entr_serial = " & LibXConnector1.CurrentDataRow!entr_serial.ToString)
                    End If
                End If
            End If

            If (e.AcceptedAction = LibX.LibxConnectionActions.Add _
            Or e.AcceptedAction = LibX.LibxConnectionActions.Edit) _
            And e.Action <> LibX.LibxConnectionActions.Cancel Then
                If LibXGrid1.getCurrentGridView.Count <= 0 Then
                    Exit Sub
                End If

                If Val(Me.total_amount.Text.Trim) <= 0 Then
                    Throw New ApplicationException("Monto Bruto inválido, por favor revisar!")
                End If

                '// Monto Bruto
                If CDbl(LibXGrid1.GetFooterValue(Me.xdt_Importe).ToString.Trim) <> CDbl(Me.total_amount.Text.Trim) Then
                    MessageBox.Show("Monto Bruto no esta bien distribuido!", "Distribucion Incrrecta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ErrDistr = True
                End If

                '// Descuento
                If ErrDistr = False AndAlso LibXGrid1.GetFooterValue(Me.xdt_Descto).ToString.Trim <> "" AndAlso Me.disc_amount.Text.Trim <> "" Then
                    If CDbl(LibXGrid1.GetFooterValue(Me.xdt_Descto).ToString.Trim) <> CDbl(Me.disc_amount.Text.Trim) Then
                        MessageBox.Show("Descuento no esta bien distribuido!", "Distribucion Incrrecta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        ErrDistr = True
                    End If
                End If

                '// ITBIS
                If ErrDistr = False AndAlso LibXGrid1.GetFooterValue(Me.xdt_Itbis).ToString.Trim <> "" AndAlso Me.itbis_amount.Text.Trim <> "" Then
                    If CDbl(LibXGrid1.GetFooterValue(Me.xdt_Itbis).ToString.Trim) <> CDbl(Me.itbis_amount.Text.Trim) Then
                        MessageBox.Show("ITBIS no esta bien distribuido!", "Distribucion Incrrecta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        ErrDistr = True
                    End If
                End If
                '// ITBIS
                If ErrDistr = False AndAlso LibXGrid1.GetFooterValue(Me.xdt_Itbis).ToString.Trim <> "" And Me.itbis_amount.Text.Trim = "" Then
                    If Val(LibXGrid1.GetFooterValue(Me.xdt_Itbis).ToString.Trim) > 0 And Val(Me.itbis_amount.Text.Trim) = 0 Then
                        MessageBox.Show("ITBIS no ha sido digitado!", "Digitacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        ErrDistr = True
                    End If
                End If

                '// ISC
                If Me.xck_impto.Checked = True And ErrDistr = False Then
                    If Val(LibXGrid1.GetFooterValue(Me.xdt_ISC).ToString.Trim) <> Val(Me.tax_amount.Text.Trim) Then
                        MessageBox.Show("ISC no esta bien distribuido!", "Distribucion Incrrecta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        ErrDistr = True
                    End If
                End If
            End If
            If e.Action = LibxConnectionActions.Cancel Then
                If Not LibX.IsNull(LibXConnector1.CurrentDataRow!entr_serial) Then
                    oBloqueo.BorrarBloqueo(LibXConnector1.CurrentDataRow!entr_serial, LibXConnector1.CurrentDataRow!type_code)
                End If
            End If
            If e.Action = LibxConnectionActions.Accept And e.AcceptedAction = LibxConnectionActions.Edit Then
                oBloqueo.BorrarBloqueo(LibXConnector1.CurrentDataRow!entr_serial, LibXConnector1.CurrentDataRow!type_code)
            End If
            If e.Action = LibxConnectionActions.Accept And e.AcceptedAction = LibxConnectionActions.Find Then

            End If

        Catch ex As Exception
            e.Handled = True
            LibX.Log.Show(ex)
        Finally
            xcbo_traer.Enabled = True
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        Dim SelSelectmt As String
        Try
            If LibXConnector1.CurrentAction = LibxConnectionActions.Edit _
            Or LibXConnector1.CurrentAction = LibxConnectionActions.Add Then
                For Each orow As DataRow In iventrdd.Select(Nothing, Nothing, DataViewRowState.CurrentRows)
                    If LibX.IsNull(orow!item_code) Then
                        orow.Delete()
                    Else
                        If orow!vence_ano.ToString.Trim <> String.Empty Then
                            If DateSerial(orow!vence_ano.ToString.Trim, orow!vence_mes.ToString.Trim, 1) <= DateSerial(DateTime.Now.Year, DateTime.Now.Month, 1) Then
                                Throw New ApplicationException("La fecha de vencimiento especificada ya se cumplió!" & vbCrLf & "Producto: " & orow!item_name.ToString.Trim)
                            End If
                        End If
                    End If
                Next
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try

            If LibXConnector1.IsEditing = False Then
                Me.CalcularNeto()
            End If

            Me.btnVencimiento.Enabled = (Not LibXConnector1.IsEditing And LibXConnector1.HasRecords = True)

            If LibXConnector1.HasRecords = True Then
                'Me.xck_dscto.Enabled = Val(e.row!disc_amount.ToString.Trim) > 0
                'Me.xdt_Descto.ReadOnly = Not Val(e.row!disc_amount.ToString.Trim) > 0

                'Me.xck_ITBIS.Enabled = Val(e.row!itbis_amount.ToString.Trim) > 0
                'Me.xdt_Itbis.ReadOnly = Not Val(e.row!itbis_amount.ToString.Trim) > 0

                'Me.xck_impto.Enabled = Val(e.row!impto_amount.ToString.Trim) > 0
                'Me.xdt_ISC.ReadOnly = Not Val(e.row!impto_amount.ToString.Trim) > 0
                'Me.btnEtiquetas.Enabled = Val(e.row!entr_status.ToString.Trim) <> 1
                'Me.btnVencimiento.Enabled = Val(e.row!entr_status.ToString.Trim) <> 1

                If Not LibX.IsNull(e.row!entr_status.ToString.Trim) Then   'APLICADA
                    If e.row!entr_status.ToString.Trim = "1" Then
                        LibXConnector1.AllowEdit = False
                        '//LibXConnector1.AllowDelete = False
                    Else
                        LibXConnector1.AllowEdit = True
                        '//LibXConnector1.AllowDelete = True
                    End If
                End If
                LibXNavigator1.UpdateState()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub xcbo_combo_BeforeLoadItems(ByVal sender As System.Object, ByVal e As LibX.LoadXComboItemsEventArgs)
        Try
            If LibXConnector1.IsDataEditing = True Then
                e.SqlString = "select * from ivunitv where item_code = '" & LibXGrid1.GetValue(xdt_item_code).Trim & "' and unit_type in (2,3) "
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xcbo_combo_valueChanged(ByVal sender As System.Object, ByVal e As LibX.XComboSelectedEventArgs)
        Dim Costo As Decimal
        Try
            If LibXConnector1.IsDataEditing = True AndAlso Not LibX.IsNull(e.value) Then
                Costo = mArticulo.GetCosto(Me.LibXGrid1.GetValue(xdt_item_code), e.value, txtwhse_code.Text)
                LibXGrid1.SetValue(xdt_Costo, Costo)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xlk_ordn_number_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_ordn_number.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            If Me.txtprov_code.Text.Length <= 0 Then
                Me.txtprov_code.Text = e.row!prov_code.ToString.Trim
                lk_prov_code.ExecuteFind()
            End If

            If xcbo_traer.Checked = True Then
                LoadItems(e.row!ordn_serial)
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LoadItems(ByVal Serial As Integer)
        Dim SelectStmt As String
        Dim oTable As DataTable

        SelectStmt = "select cpordnd.whse_code,cpordnd.item_code,qty,cpordnd.unit_code," & _
                     "cpordnd.costo,cpordnd.costo purch_unit_cost,isnull(cpordnd.itbis,0) itbis,price, " & _
                     " price as sales_price, (costo * qty) + isnull(itbis,0) as Importe,  " & _
                     " item_name,benef from cpordnd,ivitemd,ivitemm " & _
                     " where ordn_serial = " & Serial.ToString & _
                     "  and ivitemm.item_code = cpordnd.item_code " & _
                     "  and ivitemd.item_code = cpordnd.item_code " & _
                     "  and ivitemd.whse_code = cpordnd.whse_code " & _
                     "  and cpordnd.qty > 0 "

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt, "iventrdd", True)

        If oTable Is Nothing Then
            Throw New ApplicationException("Orden no tiene productos especificados")
        End If

        If oTable.Rows.Count <= 0 Then
            Throw New ApplicationException("Orden no tiene productos especificados")
        End If

        total_amount.Text = oTable.Compute("sum(Importe)-sum(itbis)", "1=1")
        itbis_amount.Text = oTable.Compute("sum(itbis)", "1=1")
        total_amount.Text = Format(oTable.Compute("sum(Importe)-sum(itbis)", "1=1"), "###,###,##0.00")
        itbis_amount.Text = Format(oTable.Compute("sum(itbis)", "1=1"), "###,###,##0.00")

        iventrdd.Rows.Clear()
        Dim oNewRow As DataRow

        For Each oRow As DataRow In oTable.Rows
            oNewRow = iventrdd.NewRow

            oNewRow.BeginEdit()
            For Each oCol As DataColumn In oRow.Table.Columns
                oNewRow.Item(oCol.ColumnName) = oRow.Item(oCol.ColumnName)
            Next
            oNewRow.EndEdit()
            iventrdd.Rows.Add(oNewRow)
        Next

        LibXGrid1.refreshFooter()
        CalcularNeto()

        'LibXGrid1.Refresh()
    End Sub

    Private Sub xlk_ordn_number_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_ordn_number.BeforeExecuteQuery
        Try
            If LibXConnector1.IsDataEditing = True And txtprov_code.Text.Trim <> "" Then
                e.aditionalWhere = "cpordnm.prov_code = " & txtprov_code.Text.Trim & " and ordn_status = 2"
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub lk_item_code_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lk_item_code.BeforeSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.IsDataEditing = True Then
                '// Validar si el producto existe y si es asi
                '// aumentar la cantidad de lo contrario continuar
                If ProductoExiste(e.row!item_code) = True Then
                    LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, xdt_item_code, "")
                    Throw New ApplicationException("Este producto esta registrado en la Linea   " & ProductoExistePocision(e.row!item_code))
                End If
            End If

        Catch ex As Exception
            e.handled = True
            LibXGrid1.Focus(LibXGrid1.CurrentRowIndex, 0)
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Function ProductoExiste(ByVal pitem_code As String) As Boolean
        Dim oRow As DataRow()
        Dim oSelect As String
        Dim Qty As Integer
        Try
            oRow = iventrdd.Select("item_code = '" & pitem_code.Trim & "'")

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
            For Each orow As DataRow In iventrdd.Select("item_code = '" & pitem_code.Trim & "'")
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
    Private Sub xlk_unit_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_unit_code.BeforeExecuteQuery
        Try
            e.aditionalWhere = "item_code = '" & LibXGrid1.GetValue(xdt_item_code) & "'"
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_ChangingState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangingState
        If e.state = LibX.LibxConnectorState.Insert _
        Or e.state = LibX.LibxConnectorState.Query Then
            Me.net_amount.Text = ""
        End If
    End Sub

    Private Sub xcbo_traer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xcbo_traer.CheckedChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                If xcbo_traer.Checked = True Then
                    If ordn_number.Text.Trim <> "" Then
                        Me.LoadItems(CType(Me.txtordn_serial.Text, Integer))
                    End If
                    xcbo_traer.Enabled = False
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xlk_unit_code_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_unit_code.BeforeSetValues
        Dim Costo As Decimal
        Dim Factor As Decimal
        Dim oArticulo As Articulo
        Dim oUnidad As UnidadMedida
        If e.dataFound = False Then
            Exit Sub
        End If

        Try
            '// Buscar el costo de la unidad que esta en el maestro
            '// y multiplicarlo por el factor de la unidad
            If LibXConnector1.IsDataEditing = True Then
                oArticulo = New Articulo(LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xdt_item_code))
                oUnidad = New UnidadMedida

                Costo = oArticulo.Costo * oUnidad.GetFactor(oArticulo.Codigo, e.row!unit_code)
                Factor = oUnidad.GetFactor(oArticulo.Codigo, e.row!unit_code)

                LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, xdt_Costo, Costo)
                LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, xdt_Factor, Factor)

                '// Limpiar el descuento
                LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, xdt_Descto, 0)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub ordn_number_ReadOnlyChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ordn_number.ReadOnlyChanged
        xlk_ordn_number.Enabled = Not ordn_number.ReadOnly
    End Sub

    Private Sub iventrdd_ColumnChanging(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles iventrdd.ColumnChanging
        If e.Column.ColumnName = "unit_code" Then
            mUnid = e.Row!unit_code.ToString.Trim
        End If
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try
            btnVencimiento.Enabled = (Not e.isDataEditing AndAlso LibXConnector1.HasRecords = True)
            btnEtiquetas.Enabled = (Not e.isDataEditing AndAlso LibXConnector1.HasRecords = True)
            'btnDisk.Enabled = (Not e.isEditing)

            btnCostos.Enabled = (e.isDataEditing)
            btnProductos.Enabled = (e.isDataEditing)
            btnReferencia.Enabled = (e.isDataEditing)
            '//Cambiar el estado para que no la apliquen si esta en ejecusion
            If e.action = LibX.LibxConnectionActions.Edit Then
                If EntradaAplicada(LibXConnector1.CurrentDataRow!entr_serial) = True Then
                    Throw New ApplicationException("Esta entrada Esta aplicada, Debe cancelar la accion!")
                Else
                End If
                If oBloqueo.BuscarBloqueo(LibXConnector1.CurrentDataRow!entr_serial, "CRD") = True Then
                    Throw New ApplicationException("Esta entrada la estan modificando en otro lado")
                Else
                    oBloqueo.BloquearDocumento(LibXConnector1.CurrentDataRow!entr_serial, "CRD")
                End If
            End If

            If (e.isEditing = True AndAlso e.isDataEditing = False) Or e.action = LibxConnectionActions.Cancel Then
                '//Si el documento esta sindo editado y se cancela que debuelva su esta pendiente
                If e.action = LibxConnectionActions.Cancel Then
                    If e.isDataEditing = True Then
                        oBloqueo.BorrarBloqueo(LibXConnector1.CurrentDataRow!entr_serial, "CRD")
                    End If
                End If
            End If
            If e.action = LibX.LibxConnectionActions.Cancel Then
                Me.GroupBox1.Enabled = True
                Me.LibXGrid1.Enabled = True
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
            If EntradaAplicada(LibXConnector1.CurrentDataRow!entr_serial) = True Then
                Me.GroupBox1.Enabled = False
                Me.LibXGrid1.Enabled = False
            End If
        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEtiquetas.Click
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim oNewTAble As DataTable
        Dim Numero As String
        Dim entrada As Integer

        Try
            SelectStmt = "select count(*)entr from ivetiqm where fact_no ='" & LibXConnector1.CurrentDataRow!entr_number & "'"
            entrada = LibX.Data.Manager.GetScalar(SelectStmt)

            If entrada > 0 Then
                Throw New ApplicationException("Estas Etiquetas ya han sido generada")
            End If

            ''inserta los productos en la tabla de etiquetas
            SelectStmt = " SELECT 0 etiq_no, iventrdd.whse_code almacen, " & _
                         " iventrdd.item_code , " & _
                         " iventrdd.costo,  " & _
                         " iventrdd.price as precio," & _
                         " isnull((SELECT top 1 ivitemd.price * FACTOR FROM IVUNITD WHERE ITEM_CODE=ivitemm.ITEM_CODE and unit_code = ivitemm.purch_unit),NULL) AS precio2," & _
                         " ivitemm.item_name as descripcion,  " & _
                         " ivitemm.abreviada as abreviada,   " & _
                         " iventrdm.entr_number as fact_no," & _
                         " iventrdm.entr_date as fecha_factura," & _
                         " iventrdm.prov_code,	" & _
                         " (case when asumir_emp=1 then iventrdd.qty else 1 end )+ isnull(iventrdd.qty_oferta,0) AS Cantidad," & _
                         " iventrdd.unit_code as unidad_compra," & _
                         " isnull((SELECT  top 1 unit_code FROM IVUNITD WHERE ITEM_CODE=ivitemm.ITEM_CODE and unit_code = ivitemm.unit_code),(SELECT  top 1 unit_code FROM IVUNITD WHERE ITEM_CODE=ivitemm.ITEM_CODE AND unit_code = ivitemm.purch_unit)) as unidad_venta ," & _
                         " ivitemd.existencia," & _
                         " ivitemm.group_code as grupo," & _
                         " ivitemm.sgroup_code as subgrp," & _
                         " 0 as estato," & _
                         " ivitemm.brand_code as marca," & _
                         " getdate() as fecha" & _
                         "  FROM iventrdm INNER JOIN iventrdd " & _
                         " ON iventrdm.entr_serial = iventrdd.entr_serial " & _
                         " INNER JOIN ivitemd " & _
                         " ON ivitemd.item_code = iventrdd.item_code " & _
                         " AND ivitemd.whse_code = iventrdd.whse_code " & _
                         " INNER JOIN ivitemm " & _
                         " ON ivitemm.item_code = ivitemd.item_code   " & _
                         " where iventrdm.entr_serial = " & LibXConnector1.CurrentDataRow!entr_serial & _
                         " and ivitemm.imprimir_etiq = 1 order by iventrdd.line_no "

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt, "ivetiqm", True)

            If oTable.Rows.Count > 0 Then
                oNewTAble = LibX.Data.Manager.GetNewDataTable("ivetiqm", True)
                For Each oRow As DataRow In oTable.Rows
                    Dim oNewRow As DataRow = oNewTAble.NewRow

                    oNewRow.ItemArray = oRow.ItemArray
                    oNewTAble.Rows.Add(oNewRow)
                Next

                LibX.Data.Manager.Save(oNewTAble)
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xck_Oferta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xck_Oferta.CheckedChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                If iventrdd.Rows.Count > 0 Then
                    Recalcular()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_InsertingDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingDetailRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then
                If LibX.IsNull(e.UpdatingArgs.Row!item_code) Then
                    e.UpdatingArgs.Status = UpdateStatus.SkipCurrentRow
                    e.UpdatingArgs.Row.AcceptChanges()
                End If
                If LibX.IsNull(e.UpdatingArgs.Row!line_no) Then
                    e.UpdatingArgs.Status = UpdateStatus.SkipCurrentRow
                    e.UpdatingArgs.Row.AcceptChanges()
                End If
                If LibX.IsNull(e.UpdatingArgs.Row!unit_code) Then
                    Throw New ApplicationException("No se puede grabar entrada con unidad en blanco!")
                End If
                If LibX.IsNull(e.UpdatingArgs.Row!qty) Then
                    Throw New ApplicationException("No se puede grabar entrada con cantidad en cero!")
                End If

            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub btnDisk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            LoadFromDisk()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub LoadFromDisk()
        Dim DataSet As DataSet
        Dim FileName As String
        Dim intSerial As Integer
        Dim intProvCode As Integer
        Dim XInsert As LibX.Data.XInsertStmt
        Dim oRowHeader As DataRow
        Try

            '// Buscar Archivo
            If OpenFileDialog1.ShowDialog(Me) = DialogResult.Cancel Then
                Exit Sub
            End If

            FileName = OpenFileDialog1.FileName.Trim

            '// INiciar Transaccion
            If LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            '// Pedir la ruta
            XInsert = New LibX.Data.XInsertStmt("iventrdm", "entr_serial")

            DataSet = New DataSet("dsSalida")
            '// FileName = "C:\tmp\SAL-9-20081223.xml"

            DataSet.ReadXml(FileName, XmlReadMode.ReadSchema)

            '// Insertar Cabecera
            oRowHeader = DataSet.Tables("ivdocsm").Rows(0)

            intProvCode = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxProvCode")

            If intProvCode = -1 Then
                Throw New ApplicationException("No se ha especificado el proveedor en el config file!")
            End If

            XInsert.Fields("entr_number") = oRowHeader!doc_number
            XInsert.Fields("entr_date") = oRowHeader!doc_date
            XInsert.Fields("prov_code") = intProvCode
            XInsert.Fields("type_code") = "CRD"
            XInsert.Fields("whse_code") = oRowHeader!whse_code
            XInsert.Fields("term_code") = oRowHeader!term_code
            XInsert.Fields("total_amount") = oRowHeader!total_amount
            XInsert.Fields("itbis_amount") = oRowHeader!itbis_amount
            XInsert.Fields("impto_amount") = oRowHeader!itbis_amount / (mConfig.GetITBIS / 100)
            XInsert.Fields("entr_status") = 2 '// Pendiente
            XInsert.Fields("date_created") = LibX.Data.Manager.Connection.GetDate
            XInsert.Fields("userid") = LibX.User.UserID
            XInsert.Fields("suc_code") = LibX.User.Sucursal

            intSerial = XInsert.Execute()

            For Each oRow As DataRow In DataSet.Tables("ivdocsd").Rows
                '// Pedir la ruta
                XInsert = New LibX.Data.XInsertStmt("iventrdd")

                '// Calcular Valores por Unidad
                Dim oParam As New Articulo.ParametrosCostosLocales

                With oParam
                    .Producto = oRow!item_code.ToString
                    .Almacen = oRow!whse_code
                    .Costo = Val(oRow!costo.ToString)
                    .Cantidad = Val(oRow!qty.ToString)
                    .Ofertas = 0
                    .UnidadCompra = oRow!unit_code.ToString
                    .Descuento = 0
                    .ISC = 0

                    .incluirOFERTA = False
                    .IncluirITBISUno = False
                    .incluirISC = False
                    .IncluirDescuento = False

                    .TotalFactura = Val(oRowHeader!total_amount.ToString.Trim)
                    .Importe = .Cantidad * .Costo

                    .TotalITBISUno = Val(oRowHeader!itbis_amount.ToString.Trim)
                    .Sucode = LibX.User.Sucursal
                End With

                '// Importe = Qty * price
                If mArticulo.CalcularCostoLocal(oParam) = True Then
                    '///////////////////////////////
                    XInsert.Fields("entr_serial") = intSerial

                    XInsert.Fields("item_code") = oRow!item_code
                    XInsert.Fields("line_no") = oRow!line_no
                    XInsert.Fields("whse_code") = oRow!whse_code
                    XInsert.Fields("unit_code") = oRow!unit_code
                    XInsert.Fields("qty") = oRow!qty
                    XInsert.Fields("costo") = oRow!costo
                    XInsert.Fields("purch_unit_cost") = Decimal.Round(oParam.ValoresRetorno.costo, 2)
                    XInsert.Fields("sales_price") = Decimal.Round(oParam.ValoresRetorno.Precio, 2)
                    XInsert.Fields("price") = oParam.ValoresRetorno.Precio
                    XInsert.Fields("itbis") = Decimal.Round(oParam.ValoresRetorno.Itbis, 2)
                    XInsert.Fields("factor") = LibX.Data.Manager.GetScalar("select factor from ivunitd where item_code = '" & oRow!item_code & "' and unit_code = '" & oRow!unit_code & "'")
                    XInsert.Fields("suc_code") = LibX.User.Sucursal

                    XInsert.Execute()
                End If
            Next

            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            LibXConnector1.ExecuteFind("entr_serial = " & intSerial.ToString)

        Catch ex As Exception
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
            Throw
        End Try

    End Sub
    Private Function EntradaAplicada(ByVal Serial As String) As Boolean
        Dim FindEstado As Integer
        Dim SelSelectmt As String
        Try
            SelSelectmt = "select entr_status from iventrdm where entr_serial = " & Serial
            FindEstado = LibX.Data.Manager.GetScalar(SelSelectmt)

            If FindEstado = 1 Then
                Return True
            End If
            Return False

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function

    Private Sub xdtp_entr_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xdtp_entr_date.ValueChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                If xdtp_entr_date.Value > LibX.Data.Manager.GetScalar("select getdate()") Then
                    xdtp_entr_date.Value = LibX.Data.Manager.GetScalar("select getdate()")
                    Throw New ApplicationException("La fecha no debe ser mayor a la fecha del dia!")
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub SalvarVencimiento()
        Dim oTable As DataTable
        Dim oTable1 As DataTable
        Dim WhereStmt As String
        Dim SelectStmt As String

        Try
            'If e.Action = LibX.LibxConnectionActions.Delete Then
            '    Dim XDelete As New LibX.Data.XDeleteStmt("ivvcmtod")

            '    e.Handled = True

            '    If MessageBox.Show("Desea borrar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then
            '        Exit Sub
            '    End If

            '    '// INICIAR TRANSACCION
            '    ''If LibX.Data.Manager.Connection.IsIntransaction = False Then
            '    ''    LibX.Data.Manager.Connection.BeginTransaction()
            '    ''End If

            '    XDelete.Parameters.Add("type_code", LibXConnector1.CurrentDataRow!type_code.ToString.Trim)
            '    XDelete.Parameters.Add("doc_serial", LibXConnector1.CurrentDataRow!doc_serial.ToString.Trim)
            '    XDelete.Execute()

            '    '// TERMINAR TRANSACCION
            '    ''If LibX.Data.Manager.Connection.IsIntransaction = True Then
            '    ''    LibX.Data.Manager.Connection.CommitTransaction()
            '    ''End If

            '    WhereStmt = "doc_serial = " & LibXConnector1.CurrentDataRow!doc_serial.ToString.Trim & _
            '                 " and type_code = '" & LibXConnector1.CurrentDataRow!type_code.ToString.Trim & "'"

            '    LibXConnector1.ExecuteFind(WhereStmt)

            '    Exit Sub
            'End If

            Select Case LibXConnector1.CurrentAction
                Case LibX.LibxConnectionActions.Accept

                    'e.Handled = True
                    SelectStmt = "select * from ivvcmtod where doc_serial = " & LibXConnector1.CurrentDataRow!entr_serial.ToString.Trim & _
                                 " and type_code = '" & LibXConnector1.CurrentDataRow!type_code.ToString.Trim & "'"

                    WhereStmt = "doc_serial = " & LibXConnector1.CurrentDataRow!entr_serial.ToString.Trim & _
                                 " and type_code = '" & LibXConnector1.CurrentDataRow!type_code.ToString.Trim & "'"
                    '" and line_no = {0}"

                    oTable = LibX.Data.Manager.GetDataTable(SelectStmt, "ivvcmtod", True)

                    Dim oNewRow As DataRow
                    Dim SelSelectmt As String

                    For Each oRow As DataRow In DataSet1.Tables("iventrdd").Select("vence_ano > 0 and vence_mes > 0")
                        Dim XUpdate As New LibX.Data.XUpdateStmt("ivvcmtod")
                        Dim oRov As DataRow()

                        If DateSerial(oRow!vence_ano.ToString.Trim, oRow!vence_mes.ToString.Trim, 1) <= DateSerial(DateTime.Now.Year, DateTime.Now.Month, 1) Then
                            If LibXConnector1.CurrentDataRow!type_code.ToString.Trim <> "DVI" Then
                                Throw New ApplicationException("La fecha de vencimiento especificada ya se cumplio!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
                            End If
                        End If

                        '// Vencimiento 1
                        If Math.Abs(Val(oRow!vence_ano.ToString.Trim)) > 0 _
                        And Math.Abs(Val(oRow!vence_mes.ToString.Trim)) > 0 Then
                            If Val(oRow!vence_mes.ToString.Trim) > 12 Then
                                Throw New ApplicationException("El mes a vencer debe estar entre 1 y 12!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
                            End If

                            If DateSerial(oRow!vence_ano.ToString.Trim, oRow!vence_mes.ToString.Trim, 1) <= DateSerial(DateTime.Now.Year, DateTime.Now.Month, 1) Then
                                Throw New ApplicationException("La fecha de vencimiento especificada ya se cumplió!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
                            End If
                        End If

                        SelSelectmt = " delete from ivvcmtod where item_code not in(select item_code from iventrdd where " & _
                                    " doc_serial = " & LibXConnector1.CurrentDataRow!entr_serial & ")" & _
                                      " and type_code = '" & LibXConnector1.CurrentDataRow!type_code.ToString.Trim & "'" & _
                                      " and doc_serial = " & LibXConnector1.CurrentDataRow!entr_serial.ToString()

                        LibX.Data.Manager.ExecuteNonQuery(SelSelectmt)

                        '// si es nuevo modificarlo                        
                        SelectStmt = "select * from ivvcmtod where doc_serial = " & LibXConnector1.CurrentDataRow!entr_serial.ToString.Trim & _
                                 " and type_code = '" & LibXConnector1.CurrentDataRow!type_code.ToString.Trim & "'"
                        oTable1 = LibX.Data.Manager.GetDataTable(SelectStmt, "ivvcmtod", True)

                        'If IsDBNull(oRow1!line_no) = True Then
                        oRov = oTable1.Select("item_code = '" & oRow!item_code & "'  and line_no = " & oRow!line_no & "")

                        'If oTable1.Rows.Count <= 0 Then
                        If oRov.Length <= 0 Then
                            oNewRow = oTable.NewRow
                            oNewRow!line_no = oRow!line_no 'oTable.Compute("count(line_no)", "1=1") + 1
                            oNewRow!unit_code = oRow!unit_code
                            oNewRow!purch_cost = oRow!purch_unit_cost
                            oNewRow!qty_onhand = oRow!existencia
                            oNewRow!qty = oRow!qty
                            oNewRow!vcmto_month = oRow!vence_mes
                            oNewRow!vcmto_year = oRow!vence_ano

                            oNewRow!doc_serial = oRow!entr_serial
                            oNewRow!type_code = LibXConnector1.CurrentDataRow!type_code
                            oNewRow!item_code = oRow!item_code
                            oNewRow!prov_code = LibXConnector1.CurrentDataRow!prov_code
                            oNewRow!whse_code = LibXConnector1.CurrentDataRow!whse_code
                            oTable.Rows.Add(oNewRow)
                        End If

                        'If oTable1.Rows.Count > 0 And oRow.RowState <> DataRowState.Unchanged Then
                        If oRov.Length > 0 Then '// And oRow.RowState <> DataRowState.Unchanged Then
                            XUpdate.FieldsSet("qty") = oRow!qty
                            XUpdate.FieldsSet("vcmto_month") = oRow!vence_mes
                            XUpdate.FieldsSet("vcmto_year") = oRow!vence_ano
                            XUpdate.FieldsSet("unit_code") = oRow!unit_code
                            XUpdate.FieldsSet("purch_cost") = oRow!purch_unit_cost
                            XUpdate.FieldsSet("qty_onhand") = oRow!existencia

                            XUpdate.FieldsSet("prov_code") = LibXConnector1.CurrentDataRow!prov_code
                            XUpdate.Fields("doc_serial") = oRow!entr_serial
                            XUpdate.Fields("line_no") = oRow!line_no
                            XUpdate.Execute()
                        End If

                        '// si es Eliminado
                        If oRow.RowState = DataRowState.Deleted Then
                            oNewRow = oTable.Select(String.Format(WhereStmt, oRow!Line_no))(0)
                            oNewRow.Delete()
                        End If

                        'If oRow.RowState <> DataRowState.Unchanged And oTable1.Rows.Count <= 0 Then
                        If oRow.RowState <> DataRowState.Unchanged And oRov.Length <= 0 Then
                            oNewRow!unit_code = oRow!unit_code
                            oNewRow!purch_cost = oRow!purch_unit_cost
                            oNewRow!qty_onhand = oRow!existencia
                            oNewRow!qty = oRow!qty
                            oNewRow!vcmto_month = oRow!vence_mes
                            oNewRow!vcmto_year = oRow!vence_ano
                            'oNewRow!qty1 = oRow!qty1
                            'oNewRow!vcmto_month1 = oRow!vcmto_month1
                            'oNewRow!vcmto_year1 = oRow!vcmto_year1
                            oNewRow!prov_code = LibXConnector1.CurrentDataRow!prov_code
                            oNewRow!whse_code = LibXConnector1.CurrentDataRow!whse_code
                            oNewRow.EndEdit()
                        End If
                    Next
                    '// INICIAR TRANSACCION
                    If LibX.Data.Manager.Connection.IsIntransaction = False Then
                        LibX.Data.Manager.Connection.BeginTransaction()
                    End If


                    LibX.Data.Manager.Save(oTable)

                    '// TERMINAR TRANSACCION
                    If LibX.Data.Manager.Connection.IsIntransaction = True Then
                        LibX.Data.Manager.Connection.CommitTransaction()
                    End If
            End Select

        Catch ex As Exception
            LibX.Log.Add(ex)
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
        End Try
    End Sub

    Private Function Anular() As Boolean
        Dim oParamPost As PostInventory.ParametrosAnular
        Dim oPost As PostInventory
        Dim SelectStmt As String
        Dim oiventrdd As DataTable
        Dim oiventrdm As DataTable
        Dim oArticulo As SGT.Inventario.Entidades.Articulo
        Dim oParam As SGT.Inventario.Entidades.Articulo.GetOnHandParameters
        Dim OnHand As Int16
        Dim XUpdate As LibX.Data.XUpdateStmt

        Try
            If MessageBox.Show("Seguro desea Anular estas entradas?", "ANULAR Entradas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Throw New ApplicationException("Operación Abortada!")
            End If

            Me.Cursor = Cursors.WaitCursor

            oParamPost = New PostInventory.ParametrosAnular
            oPost = New PostInventory

            With oParamPost
                .Serial = LibXConnector1.CurrentDataRow!entr_serial
                .TipoTransaccion = LibXConnector1.CurrentDataRow!type_code
            End With

            oPost.Anular(oParamPost)
            Return True
        Catch ex As Exception
            LibX.Log.Show(ex)
            Return False
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    Private Sub Postear()

        Dim oParamPost As PostInventory.ParametrosAplicar
        Dim oPost As PostInventory
        Dim SelectStmt As String
        Dim oiventrdd As DataTable
        Dim oiventrdm As DataTable
        Dim oArticulo As SGT.Inventario.Entidades.Articulo
        Dim oParam As SGT.Inventario.Entidades.Articulo.GetOnHandParameters
        Dim OnHand As Integer
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim oDocumento As SGT.Inventario.Entidades.Documento
        Dim sItem As String
        Dim oRow As DataRow


        Try
            If oBloqueo.BuscarBloqueo(LibXConnector1.CurrentDataRow!entr_serial, "CRD") = True Then
                Throw New ApplicationException("Esta entrada esta siendo modificada")
            End If

            If MessageBox.Show("Seguro desea aplicar estas entradas?", "Aplicar Entradas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Throw New ApplicationException("Operación Abortada!")
            End If

            Me.Cursor = Cursors.WaitCursor

            oParamPost = New PostInventory.ParametrosAplicar
            oPost = New PostInventory

            oArticulo = New SGT.Inventario.Entidades.Articulo
            oParam = New SGT.Inventario.Entidades.Articulo.GetOnHandParameters

            'For Each oRow As DataRow In DataSet1.Tables("iventrdd").Select("aplicar=1")

            '    '// Buscar los productos
            '    ''SelectStmt = String.Concat("select iventrdd.*,ivunitd.factor from iventrdd,ivunitd where iventrdd.item_code = ivunitd.item_code " & _
            '    ''                           " and iventrdd.unit_code = ivunitd.unit_code and entr_serial =", oRow!entr_serial.ToString)

            '    SelectStmt = String.Concat("select * from iventrdd where entr_serial =", oRow!entr_serial.ToString)
            '    oiventrdd = LibX.Data.Manager.GetDataTable(SelectStmt)


            oRow = LibXConnector1.CurrentDataRow.Row

            'If oiventrdd.Rows.Count <= 0 Then
            '    Throw New ApplicationException("No se encontró productos para esta entrada!")
            'End If

            '// Postear a inventario
            With oParamPost
                .DocDate = oRow!entr_date
                .Serial = oRow!entr_serial
                .Numero = oRow!entr_number.ToString.Trim
                .Referencia = oRow!prov_code.ToString.Trim
                .Comprobante = oRow!entr_ncf.ToString.Trim
                .TipoTransaccion = oRow!type_code.ToString.Trim
                .Tasa = Val(oRow!Tasa.ToString.Trim)
                .Termino = oRow!term_code.ToString.Trim
                .Proveedor = Val(oRow!prov_code.ToString.Trim)
                .UseTransaction = True
                .Monto = Val(oRow!total_amount.ToString.Trim)
                .Descuento = Val(oRow!disc_amount.ToString.Trim)
                .Impuesto = Val(oRow!itbis_amount.ToString.Trim)
                .SucCode = oRow!suc_code
                .WebTrasnf = False
                .Productos.Clear()

                For Each oRowd As DataRow In DataSet1.Tables("iventrdd").Rows
                    oParam.Producto = oRowd!item_code.ToString
                    oParam.WareHouse = Val(oRowd!whse_code.ToString)

                    OnHand = Val(oArticulo.GetOnHand(oParam).ToString)

                    'sItem = LibX.Data.Manager.GetScalar("select unit_code from ivunitd where item_code ='" & oRowd!item_code.ToString & "' and unit_code = '" & oRowd!unit_code.ToString.Trim & "'")
                    'If sItem = "" Then
                    '    Throw New ApplicationException("Hay productos con la unidad mal definida, Revisar!")
                    'End If

                    .Productos.Add(oRowd!item_code.ToString, Val(oRowd!whse_code.ToString.Trim), _
                    Val(oRowd!qty.ToString.Trim) + Val(oRowd!qty_oferta.ToString.Trim), _
                    oRowd!unit_code.ToString.Trim, Val(oRowd!costo.ToString.Trim), _
                    Val(oRowd!purch_unit_cost.ToString.Trim), Val(oRowd!impto.ToString.Trim), _
                    Val(oRowd!price.ToString), OnHand, oRowd!factor, oRowd!Benef)
                Next
            End With

            '// Aplicar Entrada y Generar Etiqueta
            oPost.AplicarConEtiqueta(oParamPost)

            '    DataSet1.Tables("iventrdd").Rows.Remove(oRow)
            'Next

        Catch ex As Exception
            LibX.Data.Manager.ExecuteNonQuery("update iventrdm set entr_status = 2 where entr_serial = " & LibXConnector1.CurrentDataRow!entr_serial.ToString())
            LibX.Log.Show(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.AcceptedAction = LibxConnectionActions.Add _
            Or e.AcceptedAction = LibxConnectionActions.Edit Then
                '// SALVAR VENCIMIENTO
                SalvarVencimiento()

                If LibXConnector1.CurrentDataRow!entr_status = 1 Then '// APLICADA
                    '// APLICAR
                    Postear()
                    LibXConnector1.ExecuteFind("entr_serial = " & LibXConnector1.CurrentDataRow!entr_serial.ToString)
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles LibXGrid1.Navigate

    End Sub
End Class
