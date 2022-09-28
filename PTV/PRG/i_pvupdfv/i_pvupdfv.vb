Public Class i_pvupdfv
    Inherits System.Windows.Forms.Form
    Dim mValor As Decimal
    Dim indUdate As Boolean = True
    Dim oParamValidar As SGT.Administracion.Entidades.Permission.ParametrosValidar
    Dim oAutorizar As SGT.Administracion.Entidades.Permission
    Dim oAutorizado As Boolean = False
    Dim mResta As Decimal
    Dim sFechaDesde As String
    Dim sFechaHasta As String
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
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents Fecha_Fin As LibX.LibxDateTimePicker
    Friend WithEvents Fecha_Ini As LibX.LibxDateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents gColType_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents gColFact_date As LibX.XDataGridTextButtonColumn
    Friend WithEvents gColFact_number As LibX.XDataGridTextButtonColumn
    Friend WithEvents gColfact_total As LibX.XDataGridTextButtonColumn
    Friend WithEvents gColdescto As LibX.XDataGridTextButtonColumn
    Friend WithEvents gColItbis As LibX.XDataGridTextButtonColumn
    Friend WithEvents gColftserial_no As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gColFact_ncf As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents Dtbftfactm As LibX.LibXDbSourceTable
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents btnUnmarkall As System.Windows.Forms.Button
    Friend WithEvents btnMarkAll As System.Windows.Forms.Button
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
    Friend WithEvents ftfactm As System.Data.DataTable
    Friend WithEvents gColAplicar As LibX.XDataGridBoolColumn
    Friend WithEvents Caja As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents xlxcaja As System.Windows.Forms.Label
    Friend WithEvents xlxcejera As System.Windows.Forms.Label
    Friend WithEvents xkl_caja As LibX.LibXLookup
    Friend WithEvents xkl_cajera As LibX.LibXLookup
    Friend WithEvents xtxtcaja As LibX.XTextBox
    Friend WithEvents xtxtcajera As LibX.XTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents xtxValor As LibX.XTextBox
    Friend WithEvents btnDistribucion As System.Windows.Forms.Button
    Friend WithEvents gColTotal As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents btnTransf As System.Windows.Forms.Button
    Friend WithEvents Dtbftfactmm As LibX.LibXDbSourceTable
    Friend WithEvents ftfactmm As System.Data.DataTable
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
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
    Friend WithEvents DataColumn76 As System.Data.DataColumn
    Friend WithEvents DataColumn77 As System.Data.DataColumn
    Friend WithEvents DataColumn78 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.DataSet1 = New System.Data.DataSet
        Me.ftfactm = New System.Data.DataTable
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
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
        Me.ftfactmm = New System.Data.DataTable
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
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
        Me.DataColumn76 = New System.Data.DataColumn
        Me.DataColumn77 = New System.Data.DataColumn
        Me.DataColumn78 = New System.Data.DataColumn
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColAplicar = New LibX.XDataGridBoolColumn
        Me.gColFact_number = New LibX.XDataGridTextButtonColumn
        Me.gColFact_date = New LibX.XDataGridTextButtonColumn
        Me.gColType_code = New LibX.XDataGridTextButtonColumn
        Me.gColfact_total = New LibX.XDataGridTextButtonColumn
        Me.gColdescto = New LibX.XDataGridTextButtonColumn
        Me.gColItbis = New LibX.XDataGridTextButtonColumn
        Me.gColFact_ncf = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColftserial_no = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColTotal = New LibX.XEditTextBoxColumn
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.Dtbftfactm = New LibX.LibXDbSourceTable
        Me.Dtbftfactmm = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xtxValor = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.xkl_cajera = New LibX.LibXLookup
        Me.xkl_caja = New LibX.LibXLookup
        Me.xlxcejera = New System.Windows.Forms.Label
        Me.xlxcaja = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Caja = New System.Windows.Forms.Label
        Me.xtxtcajera = New LibX.XTextBox
        Me.xtxtcaja = New LibX.XTextBox
        Me.Fecha_Fin = New LibX.LibxDateTimePicker
        Me.Fecha_Ini = New LibX.LibxDateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.btnUnmarkall = New System.Windows.Forms.Button
        Me.btnMarkAll = New System.Windows.Forms.Button
        Me.btnDistribucion = New System.Windows.Forms.Button
        Me.btnTransf = New System.Windows.Forms.Button
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactmm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Listado de Facturas"
        Me.LibXGrid1.DataMember = "ftfactm"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 88)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(784, 360)
        Me.LibXGrid1.TabIndex = 0
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = True
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftfactm, Me.ftfactmm})
        '
        'ftfactm
        '
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34})
        Me.ftfactm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no"}, True)})
        Me.ftfactm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn37}
        Me.ftfactm.TableName = "ftfactm"
        '
        'DataColumn37
        '
        Me.DataColumn37.AllowDBNull = False
        Me.DataColumn37.AutoIncrement = True
        Me.DataColumn37.ColumnName = "ftserial_no"
        Me.DataColumn37.DataType = GetType(System.Int32)
        Me.DataColumn37.ReadOnly = True
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "fact_number"
        Me.DataColumn38.DataType = GetType(System.Int32)
        '
        'DataColumn39
        '
        Me.DataColumn39.AllowDBNull = False
        Me.DataColumn39.ColumnName = "type_code"
        Me.DataColumn39.MaxLength = 3
        '
        'DataColumn40
        '
        Me.DataColumn40.AllowDBNull = False
        Me.DataColumn40.ColumnName = "fact_date"
        Me.DataColumn40.DataType = GetType(System.DateTime)
        '
        'DataColumn41
        '
        Me.DataColumn41.AllowDBNull = False
        Me.DataColumn41.ColumnName = "fact_total"
        Me.DataColumn41.DataType = GetType(System.Decimal)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "descto"
        Me.DataColumn42.DataType = GetType(System.Decimal)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "fact_ncf"
        Me.DataColumn43.MaxLength = 40
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "fecha_ini"
        Me.DataColumn1.ColumnName = "fecha_ini"
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "fecha_fin"
        Me.DataColumn2.ColumnName = "fecha_fin"
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "Aplicar"
        Me.DataColumn3.ColumnName = "aplicar"
        Me.DataColumn3.DataType = GetType(System.Int16)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "itbis"
        Me.DataColumn4.DataType = GetType(System.Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "whse_code"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "dev_type"
        Me.DataColumn6.MaxLength = 3
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "cotiz_serial"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "term_code"
        Me.DataColumn8.MaxLength = 5
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "addr_code"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "vend_code"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "userid"
        Me.DataColumn11.MaxLength = 20
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "fact_status"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "date_created"
        Me.DataColumn13.DataType = GetType(System.DateTime)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "cust_code"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "fact_cond"
        Me.DataColumn15.DataType = GetType(System.Int16)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "bus_name"
        Me.DataColumn16.MaxLength = 100
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "fact_nota"
        Me.DataColumn17.MaxLength = 80
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "ftserial_afect"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "pay_adelant"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "phone"
        Me.DataColumn20.MaxLength = 13
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "pay_mora"
        Me.DataColumn21.DataType = GetType(System.Decimal)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "porc_comision"
        Me.DataColumn22.DataType = GetType(System.Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "caja_code"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "caje_code"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "init_serial"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "fact_inddomicilio"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "address"
        Me.DataColumn27.MaxLength = 200
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "seg_amount"
        Me.DataColumn28.DataType = GetType(System.Decimal)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "prov_code"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "fact_impresa"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "cust_serial"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "fact_time"
        Me.DataColumn32.MaxLength = 10
        '
        'DataColumn33
        '
        Me.DataColumn33.AllowDBNull = False
        Me.DataColumn33.ColumnName = "suc_code"
        Me.DataColumn33.DataType = GetType(System.Int32)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "neto"
        Me.DataColumn34.DataType = GetType(System.Int32)
        Me.DataColumn34.ReadOnly = True
        '
        'ftfactmm
        '
        Me.ftfactmm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn35, Me.DataColumn36, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72, Me.DataColumn73, Me.DataColumn74, Me.DataColumn75, Me.DataColumn76, Me.DataColumn77, Me.DataColumn78})
        Me.ftfactmm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no"}, True)})
        Me.ftfactmm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn35}
        Me.ftfactmm.TableName = "ftfactmm"
        '
        'DataColumn35
        '
        Me.DataColumn35.AllowDBNull = False
        Me.DataColumn35.ColumnName = "ftserial_no"
        Me.DataColumn35.DataType = GetType(System.Int32)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "whse_code"
        Me.DataColumn36.DataType = GetType(System.Int32)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "dev_type"
        Me.DataColumn44.MaxLength = 3
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "cotiz_serial"
        Me.DataColumn45.DataType = GetType(System.Int32)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "term_code"
        Me.DataColumn46.MaxLength = 5
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "addr_code"
        Me.DataColumn47.DataType = GetType(System.Int32)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "vend_code"
        Me.DataColumn48.DataType = GetType(System.Int32)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "fact_number"
        Me.DataColumn49.DataType = GetType(System.Int32)
        '
        'DataColumn50
        '
        Me.DataColumn50.AllowDBNull = False
        Me.DataColumn50.ColumnName = "fact_date"
        Me.DataColumn50.DataType = GetType(System.DateTime)
        '
        'DataColumn51
        '
        Me.DataColumn51.AllowDBNull = False
        Me.DataColumn51.ColumnName = "fact_total"
        Me.DataColumn51.DataType = GetType(System.Decimal)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "descto"
        Me.DataColumn52.DataType = GetType(System.Decimal)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "itbis"
        Me.DataColumn53.DataType = GetType(System.Decimal)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "userid"
        Me.DataColumn54.MaxLength = 20
        '
        'DataColumn55
        '
        Me.DataColumn55.AllowDBNull = False
        Me.DataColumn55.ColumnName = "fact_status"
        Me.DataColumn55.DataType = GetType(System.Int32)
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "date_created"
        Me.DataColumn56.DataType = GetType(System.DateTime)
        '
        'DataColumn57
        '
        Me.DataColumn57.AllowDBNull = False
        Me.DataColumn57.ColumnName = "type_code"
        Me.DataColumn57.MaxLength = 3
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "cust_code"
        Me.DataColumn58.DataType = GetType(System.Int32)
        '
        'DataColumn59
        '
        Me.DataColumn59.AllowDBNull = False
        Me.DataColumn59.ColumnName = "fact_cond"
        Me.DataColumn59.DataType = GetType(System.Int16)
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "bus_name"
        Me.DataColumn60.MaxLength = 100
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "fact_nota"
        Me.DataColumn61.MaxLength = 80
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "ftserial_afect"
        Me.DataColumn62.DataType = GetType(System.Int32)
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "pay_adelant"
        Me.DataColumn63.DataType = GetType(System.Int32)
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "phone"
        Me.DataColumn64.MaxLength = 13
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "pay_mora"
        Me.DataColumn65.DataType = GetType(System.Decimal)
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "porc_comision"
        Me.DataColumn66.DataType = GetType(System.Decimal)
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "caja_code"
        Me.DataColumn67.DataType = GetType(System.Int32)
        '
        'DataColumn68
        '
        Me.DataColumn68.AllowDBNull = False
        Me.DataColumn68.ColumnName = "caje_code"
        Me.DataColumn68.DataType = GetType(System.Int32)
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "init_serial"
        Me.DataColumn69.DataType = GetType(System.Int32)
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "fact_inddomicilio"
        Me.DataColumn70.DataType = GetType(System.Int32)
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "address"
        Me.DataColumn71.MaxLength = 200
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "seg_amount"
        Me.DataColumn72.DataType = GetType(System.Decimal)
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "prov_code"
        Me.DataColumn73.DataType = GetType(System.Int32)
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "fact_impresa"
        Me.DataColumn74.DataType = GetType(System.Int32)
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "fact_ncf"
        Me.DataColumn75.MaxLength = 40
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "cust_serial"
        Me.DataColumn76.DataType = GetType(System.Int32)
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "fact_time"
        Me.DataColumn77.MaxLength = 10
        '
        'DataColumn78
        '
        Me.DataColumn78.AllowDBNull = False
        Me.DataColumn78.ColumnName = "suc_code"
        Me.DataColumn78.DataType = GetType(System.Int32)
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColAplicar, Me.gColFact_number, Me.gColFact_date, Me.gColType_code, Me.gColfact_total, Me.gColdescto, Me.gColItbis, Me.gColFact_ncf, Me.gColftserial_no, Me.gColTotal})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ftfactm"
        '
        'gColAplicar
        '
        Me.gColAplicar.FalseValue = CType(0, Short)
        Me.gColAplicar.HeaderText = "Marcar"
        Me.gColAplicar.MappingName = "aplicar"
        Me.gColAplicar.NullValue = 0
        Me.gColAplicar.TrueValue = CType(1, Short)
        Me.gColAplicar.UseCustomCellFormat = False
        Me.gColAplicar.Width = 40
        '
        'gColFact_number
        '
        Me.gColFact_number.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColFact_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColFact_number.executeFindDuringFill = True
        Me.gColFact_number.Format = ""
        Me.gColFact_number.FormatInfo = Nothing
        Me.gColFact_number.HeaderText = "Numero"
        Me.gColFact_number.isReadOnly = False
        Me.gColFact_number.MappingName = "fact_number"
        Me.gColFact_number.MaxLength = 32767
        Me.gColFact_number.ReadOnly = True
        Me.gColFact_number.TabStop = True
        Me.gColFact_number.UseCustomCellFormat = False
        Me.gColFact_number.Width = 75
        '
        'gColFact_date
        '
        Me.gColFact_date.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColFact_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColFact_date.executeFindDuringFill = True
        Me.gColFact_date.Format = ""
        Me.gColFact_date.FormatInfo = Nothing
        Me.gColFact_date.HeaderText = "Fecha"
        Me.gColFact_date.isReadOnly = False
        Me.gColFact_date.MappingName = "fact_date"
        Me.gColFact_date.MaxLength = 32767
        Me.gColFact_date.ReadOnly = True
        Me.gColFact_date.TabStop = True
        Me.gColFact_date.UseCustomCellFormat = False
        Me.gColFact_date.Width = 80
        '
        'gColType_code
        '
        Me.gColType_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColType_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColType_code.executeFindDuringFill = True
        Me.gColType_code.Format = ""
        Me.gColType_code.FormatInfo = Nothing
        Me.gColType_code.HeaderText = "Tipo"
        Me.gColType_code.isReadOnly = False
        Me.gColType_code.MappingName = "type_code"
        Me.gColType_code.MaxLength = 32767
        Me.gColType_code.ReadOnly = True
        Me.gColType_code.TabStop = True
        Me.gColType_code.UseCustomCellFormat = False
        Me.gColType_code.Width = 40
        '
        'gColfact_total
        '
        Me.gColfact_total.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColfact_total.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColfact_total.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColfact_total.executeFindDuringFill = True
        Me.gColfact_total.Format = "##,###,##0.00"
        Me.gColfact_total.FormatInfo = Nothing
        Me.gColfact_total.HeaderText = "Monto"
        Me.gColfact_total.isReadOnly = False
        Me.gColfact_total.MappingName = "fact_total"
        Me.gColfact_total.MaxLength = 32767
        Me.gColfact_total.TabStop = True
        Me.gColfact_total.UseCustomCellFormat = False
        Me.gColfact_total.Width = 120
        '
        'gColdescto
        '
        Me.gColdescto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColdescto.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColdescto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColdescto.executeFindDuringFill = True
        Me.gColdescto.Format = "##,###,##0.00"
        Me.gColdescto.FormatInfo = Nothing
        Me.gColdescto.HeaderText = "Descuento"
        Me.gColdescto.isReadOnly = False
        Me.gColdescto.MappingName = "descto"
        Me.gColdescto.MaxLength = 32767
        Me.gColdescto.TabStop = True
        Me.gColdescto.UseCustomCellFormat = False
        Me.gColdescto.Width = 90
        '
        'gColItbis
        '
        Me.gColItbis.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColItbis.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColItbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColItbis.executeFindDuringFill = True
        Me.gColItbis.Format = "##,###,##0.00"
        Me.gColItbis.FormatInfo = Nothing
        Me.gColItbis.HeaderText = "Itbis"
        Me.gColItbis.isReadOnly = False
        Me.gColItbis.MappingName = "itbis"
        Me.gColItbis.MaxLength = 32767
        Me.gColItbis.TabStop = True
        Me.gColItbis.UseCustomCellFormat = False
        Me.gColItbis.Width = 90
        '
        'gColFact_ncf
        '
        Me.gColFact_ncf.Format = ""
        Me.gColFact_ncf.FormatInfo = Nothing
        Me.gColFact_ncf.HeaderText = "N c f "
        Me.gColFact_ncf.MappingName = "fact_ncf"
        Me.gColFact_ncf.ReadOnly = True
        Me.gColFact_ncf.Width = 120
        '
        'gColftserial_no
        '
        Me.gColftserial_no.Format = ""
        Me.gColftserial_no.FormatInfo = Nothing
        Me.gColftserial_no.MappingName = "ftserial_no"
        Me.gColftserial_no.ReadOnly = True
        Me.gColftserial_no.Width = 0
        '
        'gColTotal
        '
        Me.gColTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColTotal.Format = "##,##0.00"
        Me.gColTotal.FormatInfo = Nothing
        Me.gColTotal.HeaderText = "Aplicado"
        Me.gColTotal.ImageList = Nothing
        Me.gColTotal.isReadOnly = False
        Me.gColTotal.MappingName = "seg_amount"
        Me.gColTotal.MaxLength = 32767
        Me.gColTotal.TabStop = True
        Me.gColTotal.UseCustomCellFormat = False
        Me.gColTotal.Width = 75
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = False
        Me.LibXConnector1.AllowNew = False
        Me.LibXConnector1.AllowPrint = False
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
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = ""
        Me.LibXConnector1.ReportObject = Nothing
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.Dtbftfactm, Me.Dtbftfactmm})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
        '
        'Dtbftfactm
        '
        Me.Dtbftfactm.AllowDelete = True
        Me.Dtbftfactm.AllowEdit = True
        Me.Dtbftfactm.AllowNew = True
        Me.Dtbftfactm.AutoIncrementSerial = False
        Me.Dtbftfactm.CustomDbUpdate = False
        Me.Dtbftfactm.DeleteOrder = 0
        Me.Dtbftfactm.FillOnQuery = True
        Me.Dtbftfactm.FillOnRowChange = False
        Me.Dtbftfactm.HeaderIsOnGrid = False
        Me.Dtbftfactm.InnerJon = True
        Me.Dtbftfactm.InsertOrder = 0
        Me.Dtbftfactm.IsDetail = True
        Me.Dtbftfactm.KeyFields = Nothing
        Me.Dtbftfactm.LineColName = Nothing
        Me.Dtbftfactm.MasterDetailRelation = New String() {Nothing}
        Me.Dtbftfactm.MasterTableName = Nothing
        Me.Dtbftfactm.SerialColumnName = Nothing
        Me.Dtbftfactm.Sort = Nothing
        Me.Dtbftfactm.Source = New String() {"select ftfactm.*,0 neto  from ftfactm inner join cjtranrm on ", "                     cjtranrm.ftserial_no = ftfactm.ftserial_no ", "         and pay_adelant is null and substring(fact_ncf,11,1) ='2'", "         and pay_method ='EFE'  and ftfactm.type_code ='FPV'", "         and (ftfactm.seg_amount is null  or ftfactm.seg_amount =0)", "order by fact_total desc"}
        Me.Dtbftfactm.TableName = "ftfactm"
        Me.Dtbftfactm.UpdateOrder = 0
        Me.Dtbftfactm.UseRowRetrieve = False
        '
        'Dtbftfactmm
        '
        Me.Dtbftfactmm.AllowDelete = True
        Me.Dtbftfactmm.AllowEdit = True
        Me.Dtbftfactmm.AllowNew = True
        Me.Dtbftfactmm.AutoIncrementSerial = False
        Me.Dtbftfactmm.CustomDbUpdate = False
        Me.Dtbftfactmm.DeleteOrder = 0
        Me.Dtbftfactmm.FillOnQuery = True
        Me.Dtbftfactmm.FillOnRowChange = False
        Me.Dtbftfactmm.HeaderIsOnGrid = False
        Me.Dtbftfactmm.InnerJon = True
        Me.Dtbftfactmm.InsertOrder = 0
        Me.Dtbftfactmm.IsDetail = False
        Me.Dtbftfactmm.KeyFields = Nothing
        Me.Dtbftfactmm.LineColName = Nothing
        Me.Dtbftfactmm.MasterDetailRelation = Nothing
        Me.Dtbftfactmm.MasterTableName = Nothing
        Me.Dtbftfactmm.SerialColumnName = Nothing
        Me.Dtbftfactmm.Sort = Nothing
        Me.Dtbftfactmm.Source = Nothing
        Me.Dtbftfactmm.TableName = "ftfactmm"
        Me.Dtbftfactmm.UpdateOrder = 0
        Me.Dtbftfactmm.UseRowRetrieve = False
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
        Me.LibXDbSourceTable2.FillOnRowChange = False
        Me.LibXDbSourceTable2.HeaderIsOnGrid = False
        Me.LibXDbSourceTable2.InnerJon = True
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = False
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = Nothing
        Me.LibXDbSourceTable2.TableName = Nothing
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xtxValor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xkl_cajera)
        Me.GroupBox1.Controls.Add(Me.xkl_caja)
        Me.GroupBox1.Controls.Add(Me.xlxcejera)
        Me.GroupBox1.Controls.Add(Me.xlxcaja)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Caja)
        Me.GroupBox1.Controls.Add(Me.xtxtcajera)
        Me.GroupBox1.Controls.Add(Me.xtxtcaja)
        Me.GroupBox1.Controls.Add(Me.Fecha_Fin)
        Me.GroupBox1.Controls.Add(Me.Fecha_Ini)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 56)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'xtxValor
        '
        Me.xtxValor.AcceptsReturn = True
        Me.xtxValor.EditInitialValue = Nothing
        Me.xtxValor.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxValor.FieldDescription = ""
        Me.xtxValor.FindInitialValue = Nothing
        Me.xtxValor.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxValor.IgnoreRequiered = False
        Me.xtxValor.Location = New System.Drawing.Point(639, 32)
        Me.xtxValor.Name = "xtxValor"
        Me.xtxValor.NewInitialValue = Nothing
        Me.xtxValor.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxValor.Requiered = False
        Me.xtxValor.Size = New System.Drawing.Size(120, 20)
        Me.xtxValor.StatusBarPanelDescripcion = Nothing
        Me.xtxValor.TabIndex = 19
        Me.xtxValor.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(559, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Valor Elegido:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'xkl_cajera
        '
        Me.xkl_cajera.AlternateFieldSearch = Nothing
        Me.xkl_cajera.BeginCheck = False
        Me.xkl_cajera.CheckText = Nothing
        Me.xkl_cajera.ComboMode = False
        Me.xkl_cajera.DataMember = Nothing
        Me.xkl_cajera.DataSource = Me.LibXConnector1
        Me.xkl_cajera.DestParameters = New String() {"caje_code=vend_code", "xlxcejera=vend_name"}
        Me.xkl_cajera.FilterField = "vend_name"
        Me.xkl_cajera.IgnoreFindInBrowseMode = False
        Me.xkl_cajera.isCanceled = False
        Me.xkl_cajera.Location = New System.Drawing.Point(496, 32)
        Me.xkl_cajera.LookCaption = ""
        Me.xkl_cajera.Name = "xkl_cajera"
        Me.xkl_cajera.PopupSize = New System.Drawing.Size(0, 0)
        Me.xkl_cajera.ShowFilter = True
        Me.xkl_cajera.ShowMessageNotFound = True
        Me.xkl_cajera.ShowWarning = False
        Me.xkl_cajera.Size = New System.Drawing.Size(16, 20)
        Me.xkl_cajera.SizesColumns = Nothing
        Me.xkl_cajera.SizesColumnsTab = Nothing
        Me.xkl_cajera.SqlString = Nothing
        Me.xkl_cajera.SQLTab = Nothing
        Me.xkl_cajera.SrcParameters = New String() {"caje_code=vend_code"}
        Me.xkl_cajera.TabIndex = 17
        Me.xkl_cajera.TableName = "ftvendm"
        Me.xkl_cajera.TabStop = False
        Me.xkl_cajera.UseCopyConnection = False
        Me.xkl_cajera.UseRowRetrieveEvents = False
        Me.xkl_cajera.UseTab = False
        Me.xkl_cajera.VisParameters = New String() {"Cajera=vend_code", "Monbre=vend_name"}
        Me.xkl_cajera.WhereCondition = "vend_indcajera = 1"
        Me.xkl_cajera.WhereParameters = Nothing
        '
        'xkl_caja
        '
        Me.xkl_caja.AlternateFieldSearch = Nothing
        Me.xkl_caja.BeginCheck = False
        Me.xkl_caja.CheckText = Nothing
        Me.xkl_caja.ComboMode = False
        Me.xkl_caja.DataMember = Nothing
        Me.xkl_caja.DataSource = Me.LibXConnector1
        Me.xkl_caja.DestParameters = New String() {"caja_code=caja_code", "xlxcaja=caja_name"}
        Me.xkl_caja.FilterField = "caja_name"
        Me.xkl_caja.IgnoreFindInBrowseMode = False
        Me.xkl_caja.isCanceled = False
        Me.xkl_caja.Location = New System.Drawing.Point(496, 8)
        Me.xkl_caja.LookCaption = ""
        Me.xkl_caja.Name = "xkl_caja"
        Me.xkl_caja.PopupSize = New System.Drawing.Size(0, 0)
        Me.xkl_caja.ShowFilter = True
        Me.xkl_caja.ShowMessageNotFound = True
        Me.xkl_caja.ShowWarning = False
        Me.xkl_caja.Size = New System.Drawing.Size(16, 20)
        Me.xkl_caja.SizesColumns = Nothing
        Me.xkl_caja.SizesColumnsTab = Nothing
        Me.xkl_caja.SqlString = Nothing
        Me.xkl_caja.SQLTab = Nothing
        Me.xkl_caja.SrcParameters = New String() {"caja_code=caja_code"}
        Me.xkl_caja.TabIndex = 16
        Me.xkl_caja.TableName = "cjcajam"
        Me.xkl_caja.TabStop = False
        Me.xkl_caja.UseCopyConnection = False
        Me.xkl_caja.UseRowRetrieveEvents = False
        Me.xkl_caja.UseTab = False
        Me.xkl_caja.VisParameters = New String() {"Caja=caja_code", "Nombre=caja_name"}
        Me.xkl_caja.WhereCondition = Nothing
        Me.xkl_caja.WhereParameters = Nothing
        '
        'xlxcejera
        '
        Me.xlxcejera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xlxcejera.Location = New System.Drawing.Point(282, 32)
        Me.xlxcejera.Name = "xlxcejera"
        Me.xlxcejera.Size = New System.Drawing.Size(214, 20)
        Me.xlxcejera.TabIndex = 15
        '
        'xlxcaja
        '
        Me.xlxcaja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xlxcaja.Location = New System.Drawing.Point(282, 8)
        Me.xlxcaja.Name = "xlxcaja"
        Me.xlxcaja.Size = New System.Drawing.Size(214, 20)
        Me.xlxcaja.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(184, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Cajera:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Caja
        '
        Me.Caja.AutoSize = True
        Me.Caja.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Caja.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Caja.Location = New System.Drawing.Point(194, 11)
        Me.Caja.Name = "Caja"
        Me.Caja.Size = New System.Drawing.Size(31, 16)
        Me.Caja.TabIndex = 12
        Me.Caja.Text = "Caja:"
        Me.Caja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'xtxtcajera
        '
        Me.xtxtcajera.AcceptsReturn = True
        Me.xtxtcajera.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.caje_code"))
        Me.xtxtcajera.EditInitialValue = Nothing
        Me.xtxtcajera.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtcajera.FieldDescription = ""
        Me.xtxtcajera.FindInitialValue = Nothing
        Me.xtxtcajera.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtcajera.IgnoreRequiered = False
        Me.xtxtcajera.Location = New System.Drawing.Point(232, 32)
        Me.xtxtcajera.Name = "xtxtcajera"
        Me.xtxtcajera.NewInitialValue = Nothing
        Me.xtxtcajera.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtcajera.Requiered = False
        Me.xtxtcajera.Size = New System.Drawing.Size(50, 20)
        Me.xtxtcajera.StatusBarPanelDescripcion = Nothing
        Me.xtxtcajera.TabIndex = 11
        Me.xtxtcajera.Text = ""
        '
        'xtxtcaja
        '
        Me.xtxtcaja.AcceptsReturn = True
        Me.xtxtcaja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.caja_code"))
        Me.xtxtcaja.EditInitialValue = Nothing
        Me.xtxtcaja.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtcaja.FieldDescription = ""
        Me.xtxtcaja.FindInitialValue = Nothing
        Me.xtxtcaja.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtcaja.IgnoreRequiered = False
        Me.xtxtcaja.Location = New System.Drawing.Point(232, 11)
        Me.xtxtcaja.Name = "xtxtcaja"
        Me.xtxtcaja.NewInitialValue = Nothing
        Me.xtxtcaja.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtcaja.Requiered = False
        Me.xtxtcaja.Size = New System.Drawing.Size(50, 20)
        Me.xtxtcaja.StatusBarPanelDescripcion = Nothing
        Me.xtxtcaja.TabIndex = 10
        Me.xtxtcaja.Text = ""
        '
        'Fecha_Fin
        '
        Me.Fecha_Fin.CustomFormat = "yyyy/MM/dd"
        Me.Fecha_Fin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.fecha_fin"))
        Me.Fecha_Fin.EditInitialValue = Nothing
        Me.Fecha_Fin.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Fin.FieldDescription = ""
        Me.Fecha_Fin.FindInitialValue = ""
        Me.Fecha_Fin.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha_Fin.IgnoreRequiered = False
        Me.Fecha_Fin.Location = New System.Drawing.Point(88, 32)
        Me.Fecha_Fin.Name = "Fecha_Fin"
        Me.Fecha_Fin.NewInitialValue = Nothing
        Me.Fecha_Fin.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Fin.Requiered = False
        Me.Fecha_Fin.Size = New System.Drawing.Size(88, 20)
        Me.Fecha_Fin.StatusBarPanelDescripcion = Nothing
        Me.Fecha_Fin.TabIndex = 6
        '
        'Fecha_Ini
        '
        Me.Fecha_Ini.CustomFormat = "yyyy/MM/dd"
        Me.Fecha_Ini.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.fecha_ini"))
        Me.Fecha_Ini.EditInitialValue = Nothing
        Me.Fecha_Ini.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Ini.FieldDescription = ""
        Me.Fecha_Ini.FindInitialValue = ""
        Me.Fecha_Ini.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Ini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha_Ini.IgnoreRequiered = False
        Me.Fecha_Ini.Location = New System.Drawing.Point(88, 8)
        Me.Fecha_Ini.Name = "Fecha_Ini"
        Me.Fecha_Ini.NewInitialValue = Nothing
        Me.Fecha_Ini.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Ini.Requiered = False
        Me.Fecha_Ini.Size = New System.Drawing.Size(88, 20)
        Me.Fecha_Ini.StatusBarPanelDescripcion = Nothing
        Me.Fecha_Ini.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(16, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha inicial:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(834, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'btnUnmarkall
        '
        Me.btnUnmarkall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUnmarkall.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnmarkall.Location = New System.Drawing.Point(88, 504)
        Me.btnUnmarkall.Name = "btnUnmarkall"
        Me.btnUnmarkall.Size = New System.Drawing.Size(80, 32)
        Me.btnUnmarkall.TabIndex = 10
        Me.btnUnmarkall.Text = "Desmarcar Todos"
        '
        'btnMarkAll
        '
        Me.btnMarkAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMarkAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarkAll.Location = New System.Drawing.Point(8, 504)
        Me.btnMarkAll.Name = "btnMarkAll"
        Me.btnMarkAll.Size = New System.Drawing.Size(80, 32)
        Me.btnMarkAll.TabIndex = 9
        Me.btnMarkAll.Text = "Marcar Todos"
        '
        'btnDistribucion
        '
        Me.btnDistribucion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDistribucion.Location = New System.Drawing.Point(696, 472)
        Me.btnDistribucion.Name = "btnDistribucion"
        Me.btnDistribucion.Size = New System.Drawing.Size(96, 32)
        Me.btnDistribucion.TabIndex = 11
        Me.btnDistribucion.Text = "Distribuir"
        '
        'btnTransf
        '
        Me.btnTransf.Enabled = False
        Me.btnTransf.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransf.Location = New System.Drawing.Point(560, 472)
        Me.btnTransf.Name = "btnTransf"
        Me.btnTransf.Size = New System.Drawing.Size(96, 32)
        Me.btnTransf.TabIndex = 12
        Me.btnTransf.Text = "Trasferir"
        '
        'i_pvupdfv
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(834, 544)
        Me.Controls.Add(Me.btnTransf)
        Me.Controls.Add(Me.btnDistribucion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.btnMarkAll)
        Me.Controls.Add(Me.btnUnmarkall)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_pvupdfv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Disctribucion Ncf"
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactmm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
        Try
            '''If e.cell = LibXGrid1.GetColNum(xdt_existencia) Then
            '''    If Val(e.value.Trim) = 0 Then
            '''        Exit Sub
            '''    End If

            '''    ''''If Math.Abs(Val(LibXGrid1.GetValue(e.row, xdt_existencia))) < Math.Abs(Val(e.value.Trim)) Then
            '''    '        LibXGrid1.SetValue(e.row, xdt_existencia, Val(LibXGrid1.GetValue(e.row, xdt_existencia)))
            '''    '        e.value = LibXGrid1.GetValue(e.row, xdt_existencia)
            '''    '    End If

            '''    'End If
            '''    'If e.cell = LibXGrid1.GetColNum(xdt_año_vence) Then
            '''    '    If Val(e.value.Trim) = 0 Then
            '''    '        LibXGrid1.Focus(e.row, 9)
            '''    '        Exit Sub
            '''    '    End If

            '''    '    If Val(LibXGrid1.GetValue(e.row, xdt_existencia)) = Val(LibXGrid1.GetValue(e.row, xdt_existencia)) Then
            '''    '        LibXGrid1.Focus(e.row, 9)
            '''    '        Exit Sub
            '''    '    End If
            '''End If

        Catch ex As Exception
            e.hasErrors = True
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub gColAplicar_BoolValueChanged(ByVal sender As System.Object, ByVal e As LibX.BoolValueChangedEventArgs) Handles gColAplicar.BoolValueChanged
        Try
            If Val(Me.xtxValor.Text) < 0 Then
                Me.xtxValor.Text = 0
                mValor = 0
            End If

            If LibXGrid1.EndEdit(gColAplicar, LibXGrid1.CurrentRowIndex, True) Then
                ftfactm.Rows(LibXGrid1.CurrentRowIndex).BeginEdit()
                ftfactm.Rows(LibXGrid1.CurrentRowIndex)!Aplicar = IIf(e.BoolValue, 1, 0)
                ftfactm.Rows(LibXGrid1.CurrentRowIndex).EndEdit()

                If ftfactm.Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 0 Then
                    mValor = mValor - ftfactm.Rows(LibXGrid1.CurrentRowIndex)!fact_total
                    Me.xtxValor.Text = mValor.ToString("###,###,##0.00")
                Else
                    mValor = mValor + ftfactm.Rows(LibXGrid1.CurrentRowIndex)!fact_total
                    Me.xtxValor.Text = mValor.ToString("###,###,##0.00")
                End If
                '''If Val(Me.xtxValor.Text) > 0 Then
                '''    Label4.Visible = True
                '''    Me.xtxValor.Visible = True
                '''Else
                '''    Label4.Visible = False
                '''    Me.xtxValor.Visible = False
                '''End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        Try
            ''For Each oRow As DataRow In ftfactm.Select("existencia =0")
            ''    oRow.Delete=
            ''Next

        Catch ex As Exception
            e.Handled = True
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        If e.Action = LibX.LibxConnectionActions.Find _
        Or e.AcceptedAction = LibX.LibxConnectionActions.Find Then
            LibXGrid1.ReadOnly = True
        End If
        If e.Action = LibX.LibxConnectionActions.Cancel Then
            Me.xtxValor.Text = 0
        End If

        If e.Action = LibX.LibxConnectionActions.Edit Then
            LibXGrid1.ReadOnly = False
        End If

    End Sub
    Private Sub i_ivcmtod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LibXGrid1.footerOperations.add("fact_number", "count(fact_number)")
        LibXGrid1.footerOperations.add("fact_total", "sum(fact_total)")
        LibXGrid1.footerOperations.add("seg_amount", "sum(seg_amount)")
        '''If Val(Me.xtxValor.Text) > 0 Then
        '''    Label4.Visible = True
        '''    Me.xtxValor.Visible = True
        '''Else
        '''    Label4.Visible = False
        '''    Me.xtxValor.Visible = False
        '''End If
    End Sub
    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibX.LibxConnectionActions.Edit And e.AcceptedAction <> LibX.LibxConnectionActions.Cancel Then
                Me.LibXGrid1.Focus(0, 0)
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub LibXConnector1_RowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange
        Try
            If LibXConnector1.HasRecords = True Then
                If Not e.row Is Nothing Then
                    LibXConnector1.AllowDelete = False
                    LibXConnector1.AllowNew = False
                    LibXConnector1.AllowPrint = False
                    LibXConnector1.AllowEdit = False
                    btnMarkAll.Enabled = LibXConnector1.IsEditing And LibXConnector1.HasRecords
                    btnUnmarkall.Enabled = LibXConnector1.IsEditing And LibXConnector1.HasRecords
                    LibXNavigator1.UpdateState()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_BeforeLoadDetail(ByVal sender As Object, ByVal e As LibX.XbeforeLoadDetailEventArgs) Handles LibXConnector1.BeforeLoadDetail
        e.Sql = e.Sql & " order by fact_number,fact_date,fact_ncf"
    End Sub
    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery

        If Fecha_Ini.Value <> "" Then
            sFechaDesde = CDate(Fecha_Ini.Value).ToString("yyyy/MM/dd")
        End If

        If Fecha_Fin.Value <> "" Then
            sFechaHasta = CDate(Fecha_Fin.Value).ToString("yyyy/MM/dd")
        End If
        If sFechaDesde <> "" And sFechaHasta = "" Then
            e.AditionalWhere = "ftfactm.fact_date = '" & sFechaDesde & "'"
        End If
        If Me.Fecha_Ini.Value <> "" And Me.Fecha_Fin.Value <> "" Then
            e.AditionalWhere = "ftfactm.fact_date between '" & sFechaDesde & "' and '" & sFechaHasta & "'"
        End If
        If Me.xtxtcaja.Text <> "" Then
            e.AditionalWhere = e.AditionalWhere & " and caja_code = " & Me.xtxtcaja.Text
        End If
        If Me.xtxtcajera.Text <> "" Then
            e.AditionalWhere = e.AditionalWhere & " and caje_code = " & Me.xtxtcajera.Text
        End If

    End Sub
    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        btnMarkAll.Enabled = e.isEditing And LibXConnector1.HasRecords
        btnUnmarkall.Enabled = e.isEditing And LibXConnector1.HasRecords

    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAll.Click
        Me.xtxValor.Text = 0
        mValor = 0
        For Each oRow As DataRow In DataSet1.Tables("ftfactm").Rows
            oRow!Aplicar = 1
            If oRow!Aplicar = 1 Then
                mValor = mValor + oRow!fact_total
                Me.xtxValor.Text = mValor.ToString("###,###,##0.00")
                '''If Val(Me.xtxValor.Text) > 0 Then
                '''    Label4.Visible = True
                '''    Me.xtxValor.Visible = True
                '''Else
                '''    Label4.Visible = False
                '''    Me.xtxValor.Visible = False
                '''End If
            End If
        Next
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnmarkall.Click
        Me.xtxValor.Text = 0
        mValor = 0
        For Each oRow As DataRow In DataSet1.Tables("ftfactm").Rows
            oRow!Aplicar = 0
            If oRow!Aplicar = 0 Then
                mValor = mValor - oRow!fact_total
                Me.xtxValor.Text = mValor.ToString("###,###,##0.00")
                '''If Val(Me.xtxValor.Text) > 0 Then
                '''    Label4.Visible = True
                '''    Me.xtxValor.Visible = True
                '''Else
                '''    Label4.Visible = False
                '''    Me.xtxValor.Visible = False
                '''End If
            End If
        Next
    End Sub

    Private Sub LibXConnector1_InsertedDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedDetailRow
        Try
            If e.UpdatingArgs.StatementType.Insert Or StatementType.Update Then
                Dim XUpdate As LibX.Data.XUpdateStmt
                XUpdate = New LibX.Data.XUpdateStmt("ftfactm")

                If LibX.IsNull(e.UpdatingArgs.Row!aplicar) Then
                    e.UpdatingArgs.Row!aplicar = 0
                End If

                If e.UpdatingArgs.Row!aplicar = 0 Then
                    e.UpdatingArgs.Status = UpdateStatus.SkipCurrentRow
                    e.UpdatingArgs.Row.AcceptChanges()
                Else
                    ''If e.UpdatingArgs.Row!aplicar = 1 Then
                    XUpdate.FieldsSet("pay_adelant") = 9
                    XUpdate.FieldsSet("seg_amount") = 0
                    XUpdate.Fields("ftserial_no") = e.UpdatingArgs.Row!ftserial_no
                    XUpdate.Execute()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        Finally
            btnTransf.Enabled = True
        End Try
    End Sub

    Private Sub LibXConnector1_InsertedRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedRow
        oParamValidar = New SGT.Administracion.Entidades.Permission.ParametrosValidar
        oAutorizar = New SGT.Administracion.Entidades.Permission
        If oAutorizado = False Then
            oParamValidar.AccessKey = "AK"
            oAutorizar.PermisosAutorizados.Remove("AK")
            oAutorizado = True
            If oAutorizar.isAutorization(oParamValidar) = False Then
                Throw New ApplicationException("Autorización Invalida")
            End If
        End If
    End Sub

    Private Sub btnDistribucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDistribucion.Click
        Dim RowIndex As Integer = 0
        Dim descto As Decimal
        Dim aplicado As Decimal
        Dim Xncf As String
        Try
            '''If xtxValor.Text.Length = 0 Then
            '''    xtxValor.Text = Val(fact_total.Text.Trim) - Val(LibXGrid1.GetFooterValue(Me.gColDescto1).ToString.Trim)
            '''    Me.txtneto.Text = Val(Me.xtxValor.Text) - Val(Me.xtxdscto.Text)
            '''Else
            '''    RemovarAplicar=
            '''End If

            If mResta = 0 Then
                aplicado = Val(LibXGrid1.GetFooterValue(gColTotal).ToString.Trim)
                mResta = xtxValor.Text - aplicado
            End If

            ''''// Aplicar Nota de Credito
            '''For Each orow As DataRow In ftfactm.Select("fact_total < 0")
            '''    orow.BeginEdit=
            '''    orow!neto = (Val(orow!fact_total.Tostring.Trim) - Val(orow!disc_neto.Tostring.Trim))
            '''    mResta -= Val(orow!fact_total.Tostring.Trim) - Val(orow!disc_neto.Tostring.Trim)
            '''    orow.EndEdit=
            '''Next
            Xncf = LibX.Data.Manager.GetScalar("select ncf_literal from ftncfm where type_code = 'FPV'" & _
                                                   "and ncf_type = 2")
            '// Aplicar Facturas
            For Each orow As DataRow In ftfactm.Select("fact_total > 0", "fact_total desc")
                If Val(orow!seg_amount.ToString.Trim) = 0 Then
                    orow.BeginEdit()
                    If mResta > Val(orow!fact_total.ToString.Trim) Then
                        mResta -= Val(orow!fact_total.ToString.Trim)
                        orow!seg_amount = Val(orow!fact_total.ToString.Trim)
                        orow!Aplicar = 1
                        ''descto += Val(orow!disc_neto.ToString.Trim)
                        ''gDescto = descto
                        Dim oNewRow As DataRow = ftfactmm.NewRow
                        oNewRow!ftserial_no = orow!ftserial_no
                        oNewRow!whse_code = orow!whse_code
                        oNewRow!dev_type = orow!dev_type
                        oNewRow!cotiz_serial = orow!cotiz_serial
                        oNewRow!term_code = orow!term_code
                        oNewRow!addr_code = orow!addr_code
                        oNewRow!vend_code = orow!vend_code
                        oNewRow!fact_number = orow!fact_number
                        oNewRow!fact_date = orow!fact_date
                        oNewRow!fact_total = orow!fact_total
                        oNewRow!descto = orow!descto
                        oNewRow!itbis = orow!itbis
                        oNewRow!userid = orow!userid
                        oNewRow!fact_status = orow!fact_status
                        oNewRow!date_created = orow!date_created
                        oNewRow!type_code = orow!type_code
                        oNewRow!cust_code = orow!cust_code
                        oNewRow!fact_cond = orow!fact_cond
                        oNewRow!bus_name = orow!bus_name
                        oNewRow!fact_nota = orow!fact_nota
                        oNewRow!ftserial_afect = orow!ftserial_afect
                        oNewRow!pay_adelant = orow!pay_adelant
                        oNewRow!phone = orow!phone
                        oNewRow!pay_mora = orow!pay_mora
                        oNewRow!porc_comision = orow!porc_comision
                        oNewRow!caja_code = orow!caja_code
                        oNewRow!caje_code = orow!caje_code
                        oNewRow!init_serial = orow!init_serial
                        oNewRow!fact_inddomicilio = orow!fact_inddomicilio
                        oNewRow!address = orow!address
                        oNewRow!seg_amount = orow!seg_amount
                        oNewRow!prov_code = orow!prov_code
                        oNewRow!fact_impresa = orow!fact_impresa
                        If orow!type_code <> "DEV" Then
                            If LibX.IsNull(orow!fact_ncf) Then
                                oNewRow!fact_ncf = Xncf & GenerarNcf().ToString("00000000")
                            Else
                                If Mid(orow!fact_ncf, 11, 1) = "2" Then
                                    oNewRow!fact_ncf = Xncf & GenerarNcf().ToString("00000000")
                                Else
                                    oNewRow!fact_ncf = orow!fact_ncf
                                End If
                            End If
                        Else
                            oNewRow!fact_ncf = orow!fact_ncf
                        End If
                        oNewRow!cust_serial = orow!cust_serial
                        oNewRow!fact_time = orow!fact_time
                        oNewRow!suc_code = orow!suc_code

                        ftfactmm.Rows.Add(oNewRow)
                    Else
                        orow!seg_amount = mResta
                        mResta = 0
                    End If
                    orow.EndEdit()
                    If mResta = 0 Then
                        Exit For
                    End If
                End If
            Next
            LibX.Data.Manager.Save(ftfactmm)

            Calcular()
            Me.btnTransf.Enabled = True

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub
    Private Sub Calcular()
        Dim Aplicar As Decimal, Aplicado As Decimal, Resta As Decimal
        Dim Descto As Decimal, Descuento As Decimal
        Dim i As Integer
        Try

            If xtxValor.Text.Length > 0 Then
                Aplicar = CDbl(xtxValor.Text.Trim) - Descto
            End If

            Aplicado = 0
            mResta = 0

            For i = 0 To ftfactm.Rows.Count - 1
                If LibXGrid1.GetValue(i, Me.gColTotal) <> "" Then
                    Aplicado += Val(LibXGrid1.GetValue(i, Me.gColTotal).ToString)
                    '''mAplicado = Aplicado
                End If
            Next
            '''If Me.xtxdscto.Text = "" Then
            '''    Me.xtxdscto.Text = 0.0
            '''End If

            If Aplicar > 0 Then
                mResta = Aplicar - Aplicado
            Else
                Aplicar = Aplicado
            End If

            Me.LibXGrid1.refreshFooter()
            ''txtPendiente.Text = Format(mResta, "##,###,##0.00")
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub AlmacenarVentas()

        Dim oDataSet As DataSet

        Dim oTableftfactm As DataTable
        Dim oTableCpinvcem1 As DataTable
        Dim SelSelect As String
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim Xncf As String
        Try

            '// ftfactm
            If sFechaDesde = "" Or sFechaHasta = "" Then
                Throw New ApplicationException("Debe especificar una fecha correcta para la separacion de las informaciones")
            End If
            SelSelect = "select * from ftfactm where ftfactm.fact_date between '" & sFechaDesde & "'" & _
                                                             " and  '" & sFechaHasta & "' and ftfactm.ftserial_no not in(select ftserial_no from wv_ft)" & _
                                                             " and ftfactm.fact_status  in (0,2)" & _
                                                             " and ftfactm.ftserial_no not in(select ftserial_no from ftfactmm) and ftfactm.type_code not in('RCE','RCB')" & _
                                                             " order by ftfactm.fact_ncf,ftfactm.fact_date desc"

            oTableftfactm = LibX.Data.Manager.GetDataTable(SelSelect)

            If oTableftfactm.Rows.Count <= 0 Then
                Throw New ApplicationException("No hay informaciones pendiente de transferir")
            End If
            Xncf = LibX.Data.Manager.GetScalar("select ncf_literal from ftncfm where type_code = 'FPV'" & _
                                       "and ncf_type = 2")

            For Each oRow As DataRow In oTableftfactm.Rows
                Dim oNewRow As DataRow = ftfactmm.NewRow
                oNewRow!ftserial_no = oRow!ftserial_no
                oNewRow!whse_code = oRow!whse_code
                oNewRow!dev_type = oRow!dev_type
                oNewRow!cotiz_serial = oRow!cotiz_serial
                oNewRow!term_code = oRow!term_code
                oNewRow!addr_code = oRow!addr_code
                oNewRow!vend_code = oRow!vend_code
                oNewRow!fact_number = oRow!fact_number
                oNewRow!fact_date = oRow!fact_date
                oNewRow!fact_total = oRow!fact_total
                oNewRow!descto = oRow!descto
                oNewRow!itbis = oRow!itbis
                oNewRow!userid = oRow!userid
                oNewRow!fact_status = oRow!fact_status
                oNewRow!date_created = oRow!date_created
                oNewRow!type_code = oRow!type_code
                oNewRow!cust_code = oRow!cust_code
                oNewRow!fact_cond = oRow!fact_cond
                oNewRow!bus_name = oRow!bus_name
                oNewRow!fact_nota = oRow!fact_nota
                oNewRow!ftserial_afect = oRow!ftserial_afect
                oNewRow!pay_adelant = oRow!pay_adelant
                oNewRow!phone = oRow!phone
                oNewRow!pay_mora = oRow!pay_mora
                oNewRow!porc_comision = oRow!porc_comision
                oNewRow!caja_code = oRow!caja_code
                oNewRow!caje_code = oRow!caje_code
                oNewRow!init_serial = oRow!init_serial
                oNewRow!fact_inddomicilio = oRow!fact_inddomicilio
                oNewRow!address = oRow!address
                oNewRow!seg_amount = oRow!seg_amount
                oNewRow!prov_code = oRow!prov_code
                oNewRow!fact_impresa = oRow!fact_impresa
                If oRow!type_code <> "DEV" Then
                    If LibX.IsNull(oRow!fact_ncf) Then
                        oNewRow!fact_ncf = Xncf & GenerarNcf().ToString("00000000")
                    Else
                        If Mid(oRow!fact_ncf, 11, 1) = "2" Then
                            oNewRow!fact_ncf = Xncf & GenerarNcf().ToString("00000000")
                        Else
                            oNewRow!fact_ncf = oRow!fact_ncf
                        End If
                    End If
                Else
                    oNewRow!fact_ncf = oRow!fact_ncf
                End If
                oNewRow!cust_serial = oRow!cust_serial
                oNewRow!fact_time = oRow!fact_time
                oNewRow!suc_code = oRow!suc_code

                ftfactmm.Rows.Add(oNewRow)
            Next
            LibX.Data.Manager.Save(ftfactmm)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnTransf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransf.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            AlmacenarVentas()
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            btnTransf.Enabled = False
        End Try
    End Sub
    Public Function GenerarNcf() As Integer
        Dim SelectStmt As String
        Dim xUpdateStmt As LibX.Data.XUpdateStmt

        Dim UltNumero As Integer

        SelectStmt = "select isnull(ncf,0) from cgsucursal where suc_code = 1 "

        UltNumero = LibX.Data.Manager.GetScalar(SelectStmt)

        UltNumero += 1

        '// Actualizar el Numero
        xUpdateStmt = New LibX.Data.XUpdateStmt("cgsucursal")
        xUpdateStmt.FieldsSet("ncf") = UltNumero
        xUpdateStmt.Fields("suc_code") = 1
        xUpdateStmt.Execute()
        xUpdateStmt.Dispose()

        Return UltNumero

    End Function
End Class
