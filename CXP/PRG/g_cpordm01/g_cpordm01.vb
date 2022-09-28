Imports LibX
Public Class g_cpordm01
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents xdbivitemd As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents group_name As LibX.XTextBox
    Friend WithEvents sgroup_name As LibX.XTextBox
    Friend WithEvents brand_name As LibX.XTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCountNo As System.Windows.Forms.Label
    Friend WithEvents whse_name As LibX.XTextBox
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents prov_name As LibX.XTextBox
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents ivitemm As System.Data.DataTable
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents cpordnm As System.Data.DataTable
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
    Friend WithEvents cpordnd As System.Data.DataTable
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents xdt_ordn_number As LibX.LibxDateTimePicker
    Friend WithEvents txtprov_code As LibX.XTextBox
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents txtPeriodo As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtordn_serial As LibX.XTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtord_desc As LibX.XTextBox
    Friend WithEvents chk_SaveGen As System.Windows.Forms.CheckBox
    Friend WithEvents LibXDbSourceTable4 As LibX.LibXDbSourceTable
    Friend WithEvents cpordng As System.Data.DataTable
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents txtgroup_code As LibX.XTextBox
    Friend WithEvents txtsgroup_code As LibX.XTextBox
    Friend WithEvents txtbrand_code As LibX.XTextBox
    Friend WithEvents txtwhse_code As LibX.XTextBox
    Friend WithEvents txtMinima As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxima As System.Windows.Forms.TextBox
    Friend WithEvents xlk_group_code As LibX.LibXLookup
    Friend WithEvents xlk_sgroup_code As LibX.LibXLookup
    Friend WithEvents xlk_brand_code As LibX.LibXLookup
    Friend WithEvents xlk_whse_code As LibX.LibXLookup
    Friend WithEvents xlk_prov_code As LibX.LibXLookup
    Friend WithEvents xlk_ordn_serial As LibX.LibXLookup
    Friend WithEvents xcbo_referencias As System.Windows.Forms.CheckBox
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable5 As LibX.LibXDbSourceTable
    Friend WithEvents cpordtmp As System.Data.DataTable
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
    Friend WithEvents exiqty As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn74 As System.Data.DataColumn
    Friend WithEvents Chk_RD As System.Windows.Forms.CheckBox
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents Chk_US As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ivitemm = New System.Data.DataTable
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.DataColumn61 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn62 = New System.Data.DataColumn
        Me.DataColumn75 = New System.Data.DataColumn
        Me.cpordnm = New System.Data.DataTable
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
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn71 = New System.Data.DataColumn
        Me.DataColumn74 = New System.Data.DataColumn
        Me.cpordnd = New System.Data.DataTable
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn72 = New System.Data.DataColumn
        Me.cpordng = New System.Data.DataTable
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.cpordtmp = New System.Data.DataTable
        Me.DataColumn63 = New System.Data.DataColumn
        Me.DataColumn64 = New System.Data.DataColumn
        Me.DataColumn65 = New System.Data.DataColumn
        Me.DataColumn66 = New System.Data.DataColumn
        Me.DataColumn67 = New System.Data.DataColumn
        Me.DataColumn68 = New System.Data.DataColumn
        Me.DataColumn69 = New System.Data.DataColumn
        Me.DataColumn70 = New System.Data.DataColumn
        Me.DataColumn73 = New System.Data.DataColumn
        Me.xdbivitemd = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable4 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable5 = New LibX.LibXDbSourceTable
        Me.Label2 = New System.Windows.Forms.Label
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtgroup_code = New LibX.XTextBox
        Me.group_name = New LibX.XTextBox
        Me.xlk_group_code = New LibX.LibXLookup
        Me.txtsgroup_code = New LibX.XTextBox
        Me.sgroup_name = New LibX.XTextBox
        Me.xlk_sgroup_code = New LibX.LibXLookup
        Me.xlk_brand_code = New LibX.LibXLookup
        Me.txtbrand_code = New LibX.XTextBox
        Me.brand_name = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.xlk_whse_code = New LibX.LibXLookup
        Me.txtwhse_code = New LibX.XTextBox
        Me.whse_name = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblCountNo = New System.Windows.Forms.Label
        Me.xlk_prov_code = New LibX.LibXLookup
        Me.txtprov_code = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.prov_name = New LibX.XTextBox
        Me.txtMinima = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtMaxima = New System.Windows.Forms.TextBox
        Me.txtPeriodo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.xdt_ordn_number = New LibX.LibxDateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.xlk_ordn_serial = New LibX.LibXLookup
        Me.txtordn_serial = New LibX.XTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtord_desc = New LibX.XTextBox
        Me.chk_SaveGen = New System.Windows.Forms.CheckBox
        Me.xcbo_referencias = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.exiqty = New System.Windows.Forms.TextBox
        Me.Chk_RD = New System.Windows.Forms.CheckBox
        Me.Chk_US = New System.Windows.Forms.CheckBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivitemm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpordnm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpordnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpordng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpordtmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = False
        Me.LibXConnector1.AllowNew = False
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "ivitemm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = True
        Me.LibXConnector1.HandledUpdates = True
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
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.xdbivitemd, Me.LibXDbSourceTable1, Me.LibXDbSourceTable3, Me.LibXDbSourceTable4, Me.LibXDbSourceTable5})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivitemm, Me.cpordnm, Me.cpordnd, Me.cpordng, Me.cpordtmp})
        '
        'ivitemm
        '
        Me.ivitemm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn35, Me.DataColumn36, Me.DataColumn25, Me.DataColumn26, Me.DataColumn29, Me.DataColumn28, Me.DataColumn30, Me.DataColumn34, Me.DataColumn42, Me.DataColumn60, Me.DataColumn61, Me.DataColumn27, Me.DataColumn62, Me.DataColumn75})
        Me.ivitemm.TableName = "ivitemm"
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
        Me.DataColumn22.ColumnName = "item_name"
        Me.DataColumn22.MaxLength = 100
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "group_code"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sgroup_code"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "brand_code"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "loc_row"
        Me.DataColumn32.MaxLength = 20
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "loc_col"
        Me.DataColumn33.MaxLength = 20
        '
        'DataColumn35
        '
        Me.DataColumn35.AllowDBNull = False
        Me.DataColumn35.ColumnName = "whse_code"
        Me.DataColumn35.DataType = GetType(System.Int32)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "existencia"
        Me.DataColumn36.DataType = GetType(System.Decimal)
        Me.DataColumn36.ReadOnly = True
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "prov_code"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "frizado_inv"
        Me.DataColumn26.DataType = GetType(System.Int16)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "estante"
        Me.DataColumn29.MaxLength = 20
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "existencia_min"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "exitencia_max"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "rorder_point"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'DataColumn42
        '
        Me.DataColumn42.AllowDBNull = False
        Me.DataColumn42.ColumnName = "purch_cost"
        Me.DataColumn42.DataType = GetType(System.Decimal)
        '
        'DataColumn60
        '
        Me.DataColumn60.AutoIncrement = True
        Me.DataColumn60.ColumnName = "ref_code"
        Me.DataColumn60.DataType = GetType(System.Int32)
        Me.DataColumn60.ReadOnly = True
        '
        'DataColumn61
        '
        Me.DataColumn61.AllowDBNull = False
        Me.DataColumn61.ColumnName = "purch_unit"
        Me.DataColumn61.MaxLength = 5
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "unit_code"
        Me.DataColumn27.MaxLength = 4
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "datelast_sales"
        Me.DataColumn62.DataType = GetType(System.DateTime)
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "costUS"
        Me.DataColumn75.DataType = GetType(System.Decimal)
        '
        'cpordnm
        '
        Me.cpordnm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn40, Me.DataColumn43, Me.DataColumn71, Me.DataColumn74})
        Me.cpordnm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ordn_serial"}, True)})
        Me.cpordnm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.cpordnm.TableName = "cpordnm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "ordn_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "type_code"
        Me.DataColumn2.MaxLength = 3
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "prov_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "ordn_date"
        Me.DataColumn4.DataType = GetType(System.DateTime)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "ordn_number"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ordn_note"
        Me.DataColumn6.MaxLength = 60
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "ordn_status"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "total_amount"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "whse_code"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "total_itbis"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "maximo"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "minimo"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "reorden"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "periodo"
        Me.DataColumn40.DataType = GetType(System.Int32)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "no_cotizacion"
        Me.DataColumn43.DataType = GetType(System.Int32)
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "suc_code"
        Me.DataColumn71.DataType = GetType(System.Int32)
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "moneda"
        Me.DataColumn74.DataType = GetType(System.Int32)
        '
        'cpordnd
        '
        Me.cpordnd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn41, Me.DataColumn44, Me.DataColumn45, Me.DataColumn59, Me.DataColumn72})
        Me.cpordnd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ordn_serial", "whse_code", "item_code"}, True)})
        Me.cpordnd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn14, Me.DataColumn15, Me.DataColumn16}
        Me.cpordnd.TableName = "cpordnd"
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "ordn_serial"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "whse_code"
        Me.DataColumn15.DataType = GetType(System.Int32)
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "item_code"
        Me.DataColumn16.MaxLength = 10
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "Qty"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "price"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "itbis"
        Me.DataColumn19.DataType = GetType(System.Decimal)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "promedio"
        Me.DataColumn20.DataType = GetType(System.Decimal)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "sugerida"
        Me.DataColumn37.DataType = GetType(System.Decimal)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "diasventa"
        Me.DataColumn38.DataType = GetType(System.Int32)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "reorden"
        Me.DataColumn39.DataType = GetType(System.Decimal)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "unit_code"
        Me.DataColumn41.MaxLength = 4
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "costo"
        Me.DataColumn44.DataType = GetType(System.Decimal)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "Existencia"
        Me.DataColumn45.DataType = GetType(System.Decimal)
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "ref_code"
        Me.DataColumn59.DataType = GetType(System.Int32)
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "suc_code"
        Me.DataColumn72.DataType = GetType(System.Int32)
        '
        'cpordng
        '
        Me.cpordng.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn51})
        Me.cpordng.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ordn_serial"}, True)})
        Me.cpordng.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn46}
        Me.cpordng.TableName = "cpordng"
        '
        'DataColumn46
        '
        Me.DataColumn46.AllowDBNull = False
        Me.DataColumn46.AutoIncrement = True
        Me.DataColumn46.ColumnName = "ordn_serial"
        Me.DataColumn46.DataType = GetType(System.Int32)
        Me.DataColumn46.ReadOnly = True
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "ordn_desc"
        Me.DataColumn47.MaxLength = 200
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "prov_code"
        Me.DataColumn48.DataType = GetType(System.Int32)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "ordn_date"
        Me.DataColumn49.DataType = GetType(System.DateTime)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "group_code"
        Me.DataColumn50.DataType = GetType(System.Int32)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "brand_code"
        Me.DataColumn52.DataType = GetType(System.Int32)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "whse_code"
        Me.DataColumn53.DataType = GetType(System.Int32)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "min_onhand"
        Me.DataColumn54.DataType = GetType(System.Int32)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "max_onhand"
        Me.DataColumn55.DataType = GetType(System.Int32)
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "periodo"
        Me.DataColumn56.DataType = GetType(System.Int32)
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "last_date"
        Me.DataColumn57.DataType = GetType(System.DateTime)
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "sgroup_code"
        Me.DataColumn58.DataType = GetType(System.Int32)
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "use_refer"
        Me.DataColumn51.DataType = GetType(System.Int32)
        '
        'cpordtmp
        '
        Me.cpordtmp.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn73})
        Me.cpordtmp.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"cpd_serial"}, True)})
        Me.cpordtmp.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn70}
        Me.cpordtmp.TableName = "cpordtmp"
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "item_code"
        Me.DataColumn63.MaxLength = 10
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "purch_cost"
        Me.DataColumn64.DataType = GetType(System.Decimal)
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "purch_unit"
        Me.DataColumn65.MaxLength = 4
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "datelast_sales"
        Me.DataColumn66.DataType = GetType(System.DateTime)
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "unit_code"
        Me.DataColumn67.MaxLength = 4
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "existencia"
        Me.DataColumn68.DataType = GetType(System.Decimal)
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "whse_code"
        Me.DataColumn69.DataType = GetType(System.Int32)
        '
        'DataColumn70
        '
        Me.DataColumn70.AllowDBNull = False
        Me.DataColumn70.AutoIncrement = True
        Me.DataColumn70.ColumnName = "cpd_serial"
        Me.DataColumn70.DataType = GetType(System.Int32)
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "suc_code"
        Me.DataColumn73.DataType = GetType(System.Int32)
        '
        'xdbivitemd
        '
        Me.xdbivitemd.AllowDelete = True
        Me.xdbivitemd.AllowEdit = True
        Me.xdbivitemd.AllowNew = True
        Me.xdbivitemd.AutoIncrementSerial = False
        Me.xdbivitemd.CustomDbUpdate = False
        Me.xdbivitemd.DeleteOrder = 0
        Me.xdbivitemd.FillOnQuery = True
        Me.xdbivitemd.FillOnRowChange = False
        Me.xdbivitemd.HeaderIsOnGrid = False
        Me.xdbivitemd.InnerJon = True
        Me.xdbivitemd.InsertOrder = 0
        Me.xdbivitemd.IsDetail = False
        Me.xdbivitemd.KeyFields = Nothing
        Me.xdbivitemd.LineColName = Nothing
        Me.xdbivitemd.MasterDetailRelation = Nothing
        Me.xdbivitemd.MasterTableName = Nothing
        Me.xdbivitemd.SerialColumnName = "ref_code"
        Me.xdbivitemd.Sort = Nothing
        Me.xdbivitemd.Source = New String() {"select ivitemm.prov_code,ivitemm.item_code,item_name,group_code,sgroup_code,brand" & _
        "_code,", " ivitemd.loc_row,loc_col,estante,whse_code,cast(existencia as decimal(18,2))exist" & _
        "encia,frizado_inv,ivitemm.purch_unit,purch_cost,", "existencia_min,exitencia_max,rorder_point, ivreferm.ref_code,ivitemm.unit_code", ",datelast_sales", "from ivitemm inner join ivitemd ", "on ivitemm.item_code = ivitemd.item_code", "left outer join ivreferm ", "on ivitemm.item_code = ivreferm.item_code ", "  and  ivitemm.prov_code = ivreferm.prov_code", "where datelast_sales is not null", "    and ivitemm.item_status = 1"}
        Me.xdbivitemd.TableName = "ivitemm"
        Me.xdbivitemd.UpdateOrder = 0
        Me.xdbivitemd.UseRowRetrieve = False
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
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cpordnm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LibXDbSourceTable3
        '
        Me.LibXDbSourceTable3.AllowDelete = True
        Me.LibXDbSourceTable3.AllowEdit = True
        Me.LibXDbSourceTable3.AllowNew = True
        Me.LibXDbSourceTable3.AutoIncrementSerial = False
        Me.LibXDbSourceTable3.CustomDbUpdate = False
        Me.LibXDbSourceTable3.DeleteOrder = 0
        Me.LibXDbSourceTable3.FillOnQuery = True
        Me.LibXDbSourceTable3.FillOnRowChange = False
        Me.LibXDbSourceTable3.HeaderIsOnGrid = False
        Me.LibXDbSourceTable3.InnerJon = True
        Me.LibXDbSourceTable3.InsertOrder = 0
        Me.LibXDbSourceTable3.IsDetail = False
        Me.LibXDbSourceTable3.KeyFields = Nothing
        Me.LibXDbSourceTable3.LineColName = Nothing
        Me.LibXDbSourceTable3.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable3.MasterTableName = Nothing
        Me.LibXDbSourceTable3.SerialColumnName = Nothing
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = Nothing
        Me.LibXDbSourceTable3.TableName = "cpordnd"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'LibXDbSourceTable4
        '
        Me.LibXDbSourceTable4.AllowDelete = True
        Me.LibXDbSourceTable4.AllowEdit = True
        Me.LibXDbSourceTable4.AllowNew = True
        Me.LibXDbSourceTable4.AutoIncrementSerial = False
        Me.LibXDbSourceTable4.CustomDbUpdate = False
        Me.LibXDbSourceTable4.DeleteOrder = 0
        Me.LibXDbSourceTable4.FillOnQuery = True
        Me.LibXDbSourceTable4.FillOnRowChange = False
        Me.LibXDbSourceTable4.HeaderIsOnGrid = False
        Me.LibXDbSourceTable4.InnerJon = True
        Me.LibXDbSourceTable4.InsertOrder = 0
        Me.LibXDbSourceTable4.IsDetail = False
        Me.LibXDbSourceTable4.KeyFields = Nothing
        Me.LibXDbSourceTable4.LineColName = Nothing
        Me.LibXDbSourceTable4.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable4.MasterTableName = Nothing
        Me.LibXDbSourceTable4.SerialColumnName = Nothing
        Me.LibXDbSourceTable4.Sort = Nothing
        Me.LibXDbSourceTable4.Source = Nothing
        Me.LibXDbSourceTable4.TableName = "cpordng"
        Me.LibXDbSourceTable4.UpdateOrder = 0
        Me.LibXDbSourceTable4.UseRowRetrieve = False
        '
        'LibXDbSourceTable5
        '
        Me.LibXDbSourceTable5.AllowDelete = True
        Me.LibXDbSourceTable5.AllowEdit = True
        Me.LibXDbSourceTable5.AllowNew = True
        Me.LibXDbSourceTable5.AutoIncrementSerial = False
        Me.LibXDbSourceTable5.CustomDbUpdate = False
        Me.LibXDbSourceTable5.DeleteOrder = 0
        Me.LibXDbSourceTable5.FillOnQuery = True
        Me.LibXDbSourceTable5.FillOnRowChange = False
        Me.LibXDbSourceTable5.HeaderIsOnGrid = False
        Me.LibXDbSourceTable5.InnerJon = True
        Me.LibXDbSourceTable5.InsertOrder = 0
        Me.LibXDbSourceTable5.IsDetail = False
        Me.LibXDbSourceTable5.KeyFields = Nothing
        Me.LibXDbSourceTable5.LineColName = Nothing
        Me.LibXDbSourceTable5.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable5.MasterTableName = Nothing
        Me.LibXDbSourceTable5.SerialColumnName = ""
        Me.LibXDbSourceTable5.Sort = Nothing
        Me.LibXDbSourceTable5.Source = Nothing
        Me.LibXDbSourceTable5.TableName = "cpordtmp"
        Me.LibXDbSourceTable5.UpdateOrder = 0
        Me.LibXDbSourceTable5.UseRowRetrieve = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(64, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sub-grupo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(496, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 112)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(8, 80)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Cerrar"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEjecutar.Location = New System.Drawing.Point(8, 14)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(72, 32)
        Me.btnEjecutar.TabIndex = 0
        Me.btnEjecutar.Text = "Generar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnImprimir.Location = New System.Drawing.Point(8, 48)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(72, 32)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(594, 48)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "GENERAR ORDENES DE COMPRA"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(8, 360)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 48)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Progreso"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 19)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(560, 23)
        Me.ProgressBar1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(80, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Grupo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(80, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Marca:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtgroup_code
        '
        Me.txtgroup_code.AcceptsReturn = True
        Me.txtgroup_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtgroup_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.group_code"))
        Me.txtgroup_code.EditInitialValue = Nothing
        Me.txtgroup_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtgroup_code.FieldDescription = ""
        Me.txtgroup_code.FindInitialValue = Nothing
        Me.txtgroup_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtgroup_code.IgnoreRequiered = False
        Me.txtgroup_code.Location = New System.Drawing.Point(128, 168)
        Me.txtgroup_code.Name = "txtgroup_code"
        Me.txtgroup_code.NewInitialValue = Nothing
        Me.txtgroup_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtgroup_code.Requiered = False
        Me.txtgroup_code.Size = New System.Drawing.Size(48, 20)
        Me.txtgroup_code.StatusBarPanelDescripcion = Nothing
        Me.txtgroup_code.TabIndex = 4
        Me.txtgroup_code.Text = ""
        '
        'group_name
        '
        Me.group_name.AcceptsReturn = True
        Me.group_name.EditInitialValue = Nothing
        Me.group_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.group_name.FieldDescription = ""
        Me.group_name.FindInitialValue = Nothing
        Me.group_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.group_name.IgnoreRequiered = False
        Me.group_name.Location = New System.Drawing.Point(184, 168)
        Me.group_name.Name = "group_name"
        Me.group_name.NewInitialValue = Nothing
        Me.group_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.group_name.ReadOnly = True
        Me.group_name.Requiered = False
        Me.group_name.Size = New System.Drawing.Size(288, 20)
        Me.group_name.StatusBarPanelDescripcion = Nothing
        Me.group_name.TabIndex = 1
        Me.group_name.TabStop = False
        Me.group_name.Text = ""
        '
        'xlk_group_code
        '
        Me.xlk_group_code.AlternateFieldSearch = Nothing
        Me.xlk_group_code.BeginCheck = False
        Me.xlk_group_code.CheckText = Nothing
        Me.xlk_group_code.ComboMode = False
        Me.xlk_group_code.DataMember = Nothing
        Me.xlk_group_code.DataSource = Me.LibXConnector1
        Me.xlk_group_code.DestParameters = New String() {"group_code=group_code", "group_name=group_name"}
        Me.xlk_group_code.FilterField = "group_name"
        Me.xlk_group_code.IgnoreFindInBrowseMode = False
        Me.xlk_group_code.isCanceled = False
        Me.xlk_group_code.Location = New System.Drawing.Point(472, 168)
        Me.xlk_group_code.LookCaption = "Grupos"
        Me.xlk_group_code.Name = "xlk_group_code"
        Me.xlk_group_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_group_code.ShowFilter = True
        Me.xlk_group_code.ShowMessageNotFound = True
        Me.xlk_group_code.ShowWarning = False
        Me.xlk_group_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_group_code.SizesColumns = Nothing
        Me.xlk_group_code.SizesColumnsTab = Nothing
        Me.xlk_group_code.SqlString = Nothing
        Me.xlk_group_code.SQLTab = Nothing
        Me.xlk_group_code.SrcParameters = New String() {"group_code=group_code"}
        Me.xlk_group_code.TabIndex = 14
        Me.xlk_group_code.TableName = "ivgroupm"
        Me.xlk_group_code.TabStop = False
        Me.xlk_group_code.UseCopyConnection = False
        Me.xlk_group_code.UseRowRetrieveEvents = False
        Me.xlk_group_code.UseTab = False
        Me.xlk_group_code.VisParameters = New String() {"Código=group_code", "Descripción=group_name"}
        Me.xlk_group_code.WhereCondition = Nothing
        Me.xlk_group_code.WhereParameters = Nothing
        '
        'txtsgroup_code
        '
        Me.txtsgroup_code.AcceptsReturn = True
        Me.txtsgroup_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsgroup_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.sgroup_code"))
        Me.txtsgroup_code.EditInitialValue = Nothing
        Me.txtsgroup_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsgroup_code.FieldDescription = ""
        Me.txtsgroup_code.FindInitialValue = Nothing
        Me.txtsgroup_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsgroup_code.IgnoreRequiered = False
        Me.txtsgroup_code.Location = New System.Drawing.Point(128, 192)
        Me.txtsgroup_code.Name = "txtsgroup_code"
        Me.txtsgroup_code.NewInitialValue = Nothing
        Me.txtsgroup_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsgroup_code.Requiered = False
        Me.txtsgroup_code.Size = New System.Drawing.Size(48, 20)
        Me.txtsgroup_code.StatusBarPanelDescripcion = Nothing
        Me.txtsgroup_code.TabIndex = 5
        Me.txtsgroup_code.Text = ""
        '
        'sgroup_name
        '
        Me.sgroup_name.AcceptsReturn = True
        Me.sgroup_name.EditInitialValue = Nothing
        Me.sgroup_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.sgroup_name.FieldDescription = ""
        Me.sgroup_name.FindInitialValue = Nothing
        Me.sgroup_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.sgroup_name.IgnoreRequiered = False
        Me.sgroup_name.Location = New System.Drawing.Point(184, 192)
        Me.sgroup_name.Name = "sgroup_name"
        Me.sgroup_name.NewInitialValue = Nothing
        Me.sgroup_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.sgroup_name.ReadOnly = True
        Me.sgroup_name.Requiered = False
        Me.sgroup_name.Size = New System.Drawing.Size(288, 20)
        Me.sgroup_name.StatusBarPanelDescripcion = Nothing
        Me.sgroup_name.TabIndex = 12
        Me.sgroup_name.TabStop = False
        Me.sgroup_name.Text = ""
        '
        'xlk_sgroup_code
        '
        Me.xlk_sgroup_code.AlternateFieldSearch = Nothing
        Me.xlk_sgroup_code.BeginCheck = False
        Me.xlk_sgroup_code.CheckText = Nothing
        Me.xlk_sgroup_code.ComboMode = False
        Me.xlk_sgroup_code.DataMember = Nothing
        Me.xlk_sgroup_code.DataSource = Me.LibXConnector1
        Me.xlk_sgroup_code.DestParameters = New String() {"sgroup_code=sgroup_code", "sgroup_name=sgroup_name"}
        Me.xlk_sgroup_code.FilterField = "sgroup_name"
        Me.xlk_sgroup_code.IgnoreFindInBrowseMode = False
        Me.xlk_sgroup_code.isCanceled = False
        Me.xlk_sgroup_code.Location = New System.Drawing.Point(472, 192)
        Me.xlk_sgroup_code.LookCaption = "Sub Grupos"
        Me.xlk_sgroup_code.Name = "xlk_sgroup_code"
        Me.xlk_sgroup_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_sgroup_code.ShowFilter = True
        Me.xlk_sgroup_code.ShowMessageNotFound = True
        Me.xlk_sgroup_code.ShowWarning = False
        Me.xlk_sgroup_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_sgroup_code.SizesColumns = Nothing
        Me.xlk_sgroup_code.SizesColumnsTab = Nothing
        Me.xlk_sgroup_code.SqlString = Nothing
        Me.xlk_sgroup_code.SQLTab = Nothing
        Me.xlk_sgroup_code.SrcParameters = New String() {"sgroup_code=sgroup_code"}
        Me.xlk_sgroup_code.TabIndex = 14
        Me.xlk_sgroup_code.TableName = "ivsgroupm"
        Me.xlk_sgroup_code.TabStop = False
        Me.xlk_sgroup_code.UseCopyConnection = False
        Me.xlk_sgroup_code.UseRowRetrieveEvents = False
        Me.xlk_sgroup_code.UseTab = False
        Me.xlk_sgroup_code.VisParameters = New String() {"Código=sgroup_code", "Descripción=sgroup_name"}
        Me.xlk_sgroup_code.WhereCondition = Nothing
        Me.xlk_sgroup_code.WhereParameters = Nothing
        '
        'xlk_brand_code
        '
        Me.xlk_brand_code.AlternateFieldSearch = Nothing
        Me.xlk_brand_code.BeginCheck = False
        Me.xlk_brand_code.CheckText = Nothing
        Me.xlk_brand_code.ComboMode = False
        Me.xlk_brand_code.DataMember = Nothing
        Me.xlk_brand_code.DataSource = Me.LibXConnector1
        Me.xlk_brand_code.DestParameters = New String() {"brand_code=brand_code", "brand_name=brand_name"}
        Me.xlk_brand_code.FilterField = "brand_name"
        Me.xlk_brand_code.IgnoreFindInBrowseMode = False
        Me.xlk_brand_code.isCanceled = False
        Me.xlk_brand_code.Location = New System.Drawing.Point(472, 216)
        Me.xlk_brand_code.LookCaption = "Marcas"
        Me.xlk_brand_code.Name = "xlk_brand_code"
        Me.xlk_brand_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_brand_code.ShowFilter = True
        Me.xlk_brand_code.ShowMessageNotFound = True
        Me.xlk_brand_code.ShowWarning = False
        Me.xlk_brand_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_brand_code.SizesColumns = Nothing
        Me.xlk_brand_code.SizesColumnsTab = Nothing
        Me.xlk_brand_code.SqlString = Nothing
        Me.xlk_brand_code.SQLTab = Nothing
        Me.xlk_brand_code.SrcParameters = New String() {"brand_code=brand_code"}
        Me.xlk_brand_code.TabIndex = 14
        Me.xlk_brand_code.TableName = "ivbrandm"
        Me.xlk_brand_code.TabStop = False
        Me.xlk_brand_code.UseCopyConnection = False
        Me.xlk_brand_code.UseRowRetrieveEvents = False
        Me.xlk_brand_code.UseTab = False
        Me.xlk_brand_code.VisParameters = New String() {"Código=brand_code", "Descripción=brand_name"}
        Me.xlk_brand_code.WhereCondition = Nothing
        Me.xlk_brand_code.WhereParameters = Nothing
        '
        'txtbrand_code
        '
        Me.txtbrand_code.AcceptsReturn = True
        Me.txtbrand_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbrand_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.brand_code"))
        Me.txtbrand_code.EditInitialValue = Nothing
        Me.txtbrand_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtbrand_code.FieldDescription = ""
        Me.txtbrand_code.FindInitialValue = Nothing
        Me.txtbrand_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtbrand_code.IgnoreRequiered = False
        Me.txtbrand_code.Location = New System.Drawing.Point(128, 216)
        Me.txtbrand_code.Name = "txtbrand_code"
        Me.txtbrand_code.NewInitialValue = Nothing
        Me.txtbrand_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtbrand_code.Requiered = False
        Me.txtbrand_code.Size = New System.Drawing.Size(48, 20)
        Me.txtbrand_code.StatusBarPanelDescripcion = Nothing
        Me.txtbrand_code.TabIndex = 6
        Me.txtbrand_code.Text = ""
        '
        'brand_name
        '
        Me.brand_name.AcceptsReturn = True
        Me.brand_name.EditInitialValue = Nothing
        Me.brand_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.brand_name.FieldDescription = ""
        Me.brand_name.FindInitialValue = Nothing
        Me.brand_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.brand_name.IgnoreRequiered = False
        Me.brand_name.Location = New System.Drawing.Point(184, 216)
        Me.brand_name.Name = "brand_name"
        Me.brand_name.NewInitialValue = Nothing
        Me.brand_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.brand_name.ReadOnly = True
        Me.brand_name.Requiered = False
        Me.brand_name.Size = New System.Drawing.Size(288, 20)
        Me.brand_name.StatusBarPanelDescripcion = Nothing
        Me.brand_name.TabIndex = 12
        Me.brand_name.TabStop = False
        Me.brand_name.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(72, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Almacén:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.xlk_whse_code.Location = New System.Drawing.Point(472, 240)
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
        Me.xlk_whse_code.TabIndex = 14
        Me.xlk_whse_code.TableName = "ivwhsem"
        Me.xlk_whse_code.TabStop = False
        Me.xlk_whse_code.UseCopyConnection = False
        Me.xlk_whse_code.UseRowRetrieveEvents = False
        Me.xlk_whse_code.UseTab = False
        Me.xlk_whse_code.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.xlk_whse_code.WhereCondition = Nothing
        Me.xlk_whse_code.WhereParameters = Nothing
        '
        'txtwhse_code
        '
        Me.txtwhse_code.AcceptsReturn = True
        Me.txtwhse_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtwhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.whse_code"))
        Me.txtwhse_code.EditInitialValue = Nothing
        Me.txtwhse_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.FieldDescription = ""
        Me.txtwhse_code.FindInitialValue = Nothing
        Me.txtwhse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.IgnoreRequiered = False
        Me.txtwhse_code.Location = New System.Drawing.Point(128, 240)
        Me.txtwhse_code.Name = "txtwhse_code"
        Me.txtwhse_code.NewInitialValue = Nothing
        Me.txtwhse_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.Requiered = False
        Me.txtwhse_code.Size = New System.Drawing.Size(48, 20)
        Me.txtwhse_code.StatusBarPanelDescripcion = Nothing
        Me.txtwhse_code.TabIndex = 7
        Me.txtwhse_code.Text = ""
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
        Me.whse_name.Location = New System.Drawing.Point(184, 240)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.NewInitialValue = Nothing
        Me.whse_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.ReadOnly = True
        Me.whse_name.Requiered = False
        Me.whse_name.Size = New System.Drawing.Size(288, 20)
        Me.whse_name.StatusBarPanelDescripcion = Nothing
        Me.whse_name.TabIndex = 12
        Me.whse_name.TabStop = False
        Me.whse_name.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(40, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Orden Número:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCountNo
        '
        Me.lblCountNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCountNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountNo.Location = New System.Drawing.Point(128, 96)
        Me.lblCountNo.Name = "lblCountNo"
        Me.lblCountNo.Size = New System.Drawing.Size(96, 20)
        Me.lblCountNo.TabIndex = 11
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
        Me.xlk_prov_code.Location = New System.Drawing.Point(472, 144)
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
        Me.xlk_prov_code.TabIndex = 18
        Me.xlk_prov_code.TableName = "cpprovm"
        Me.xlk_prov_code.TabStop = False
        Me.xlk_prov_code.UseCopyConnection = False
        Me.xlk_prov_code.UseRowRetrieveEvents = False
        Me.xlk_prov_code.UseTab = False
        Me.xlk_prov_code.VisParameters = New String() {"Código=prov_code", "Nombre=prov_name"}
        Me.xlk_prov_code.WhereCondition = Nothing
        Me.xlk_prov_code.WhereParameters = Nothing
        '
        'txtprov_code
        '
        Me.txtprov_code.AcceptsReturn = True
        Me.txtprov_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtprov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.txtprov_code.EditInitialValue = Nothing
        Me.txtprov_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.FieldDescription = ""
        Me.txtprov_code.FindInitialValue = Nothing
        Me.txtprov_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.IgnoreRequiered = False
        Me.txtprov_code.Location = New System.Drawing.Point(128, 144)
        Me.txtprov_code.Name = "txtprov_code"
        Me.txtprov_code.NewInitialValue = Nothing
        Me.txtprov_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.Requiered = False
        Me.txtprov_code.Size = New System.Drawing.Size(48, 20)
        Me.txtprov_code.StatusBarPanelDescripcion = Nothing
        Me.txtprov_code.TabIndex = 3
        Me.txtprov_code.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(72, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Suplidor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.prov_name.Location = New System.Drawing.Point(184, 144)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.NewInitialValue = Nothing
        Me.prov_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.ReadOnly = True
        Me.prov_name.Requiered = False
        Me.prov_name.Size = New System.Drawing.Size(288, 20)
        Me.prov_name.StatusBarPanelDescripcion = Nothing
        Me.prov_name.TabIndex = 16
        Me.prov_name.TabStop = False
        Me.prov_name.Text = ""
        '
        'txtMinima
        '
        Me.txtMinima.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpordnm.maximo"))
        Me.txtMinima.Location = New System.Drawing.Point(128, 331)
        Me.txtMinima.Name = "txtMinima"
        Me.txtMinima.Size = New System.Drawing.Size(96, 20)
        Me.txtMinima.TabIndex = 9
        Me.txtMinima.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Exisencia Maxima de:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Exstencia Mínima de:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(40, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Fecha Inicio:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMaxima
        '
        Me.txtMaxima.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpordnm.minimo"))
        Me.txtMaxima.Location = New System.Drawing.Point(128, 307)
        Me.txtMaxima.Name = "txtMaxima"
        Me.txtMaxima.Size = New System.Drawing.Size(96, 20)
        Me.txtMaxima.TabIndex = 8
        Me.txtMaxima.Text = ""
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Location = New System.Drawing.Point(400, 120)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Size = New System.Drawing.Size(88, 20)
        Me.txtPeriodo.TabIndex = 19
        Me.txtPeriodo.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(312, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Periodo (Días):"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xdt_ordn_number
        '
        Me.xdt_ordn_number.CustomFormat = "dd/MM/yyyy"
        Me.xdt_ordn_number.EditInitialValue = Nothing
        Me.xdt_ordn_number.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_ordn_number.FieldDescription = ""
        Me.xdt_ordn_number.FindInitialValue = Nothing
        Me.xdt_ordn_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_ordn_number.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_ordn_number.IgnoreRequiered = False
        Me.xdt_ordn_number.Location = New System.Drawing.Point(128, 120)
        Me.xdt_ordn_number.Name = "xdt_ordn_number"
        Me.xdt_ordn_number.NewInitialValue = Nothing
        Me.xdt_ordn_number.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_ordn_number.Requiered = False
        Me.xdt_ordn_number.Size = New System.Drawing.Size(96, 20)
        Me.xdt_ordn_number.StatusBarPanelDescripcion = Nothing
        Me.xdt_ordn_number.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(480, 8)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        '
        'xlk_ordn_serial
        '
        Me.xlk_ordn_serial.AlternateFieldSearch = Nothing
        Me.xlk_ordn_serial.BeginCheck = False
        Me.xlk_ordn_serial.CheckText = Nothing
        Me.xlk_ordn_serial.ComboMode = False
        Me.xlk_ordn_serial.DataMember = Nothing
        Me.xlk_ordn_serial.DataSource = Me.LibXConnector1
        Me.xlk_ordn_serial.DestParameters = New String() {"txtordn_serial=ordn_serial", "txtord_desc=ordn_desc"}
        Me.xlk_ordn_serial.FilterField = Nothing
        Me.xlk_ordn_serial.IgnoreFindInBrowseMode = False
        Me.xlk_ordn_serial.isCanceled = False
        Me.xlk_ordn_serial.Location = New System.Drawing.Point(472, 56)
        Me.xlk_ordn_serial.LookCaption = "Generaciones"
        Me.xlk_ordn_serial.Name = "xlk_ordn_serial"
        Me.xlk_ordn_serial.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_ordn_serial.ShowFilter = True
        Me.xlk_ordn_serial.ShowMessageNotFound = True
        Me.xlk_ordn_serial.ShowWarning = False
        Me.xlk_ordn_serial.Size = New System.Drawing.Size(16, 20)
        Me.xlk_ordn_serial.SizesColumns = New String() {"ordn_desc=600"}
        Me.xlk_ordn_serial.SizesColumnsTab = Nothing
        Me.xlk_ordn_serial.SqlString = Nothing
        Me.xlk_ordn_serial.SQLTab = Nothing
        Me.xlk_ordn_serial.SrcParameters = New String() {"txtordn_serial=ordn_serial"}
        Me.xlk_ordn_serial.TabIndex = 26
        Me.xlk_ordn_serial.TableName = "cpordng"
        Me.xlk_ordn_serial.TabStop = False
        Me.xlk_ordn_serial.UseCopyConnection = False
        Me.xlk_ordn_serial.UseRowRetrieveEvents = False
        Me.xlk_ordn_serial.UseTab = False
        Me.xlk_ordn_serial.VisParameters = New String() {"Codigo=ordn_serial", "Descripcion=ordn_desc", "Ult./Generacion=last_date"}
        Me.xlk_ordn_serial.WhereCondition = Nothing
        Me.xlk_ordn_serial.WhereParameters = Nothing
        '
        'txtordn_serial
        '
        Me.txtordn_serial.AcceptsReturn = True
        Me.txtordn_serial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtordn_serial.EditInitialValue = Nothing
        Me.txtordn_serial.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtordn_serial.FieldDescription = ""
        Me.txtordn_serial.FindInitialValue = Nothing
        Me.txtordn_serial.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtordn_serial.IgnoreRequiered = False
        Me.txtordn_serial.Location = New System.Drawing.Point(128, 56)
        Me.txtordn_serial.Name = "txtordn_serial"
        Me.txtordn_serial.NewInitialValue = Nothing
        Me.txtordn_serial.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtordn_serial.Requiered = False
        Me.txtordn_serial.Size = New System.Drawing.Size(48, 20)
        Me.txtordn_serial.StatusBarPanelDescripcion = Nothing
        Me.txtordn_serial.TabIndex = 1
        Me.txtordn_serial.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Location = New System.Drawing.Point(40, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Generaciones:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtord_desc
        '
        Me.txtord_desc.AcceptsReturn = True
        Me.txtord_desc.EditInitialValue = Nothing
        Me.txtord_desc.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtord_desc.FieldDescription = ""
        Me.txtord_desc.FindInitialValue = Nothing
        Me.txtord_desc.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtord_desc.IgnoreRequiered = False
        Me.txtord_desc.Location = New System.Drawing.Point(184, 56)
        Me.txtord_desc.Name = "txtord_desc"
        Me.txtord_desc.NewInitialValue = Nothing
        Me.txtord_desc.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtord_desc.ReadOnly = True
        Me.txtord_desc.Requiered = False
        Me.txtord_desc.Size = New System.Drawing.Size(288, 20)
        Me.txtord_desc.StatusBarPanelDescripcion = Nothing
        Me.txtord_desc.TabIndex = 24
        Me.txtord_desc.TabStop = False
        Me.txtord_desc.Text = ""
        '
        'chk_SaveGen
        '
        Me.chk_SaveGen.Location = New System.Drawing.Point(8, 88)
        Me.chk_SaveGen.Name = "chk_SaveGen"
        Me.chk_SaveGen.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_SaveGen.Size = New System.Drawing.Size(8, 16)
        Me.chk_SaveGen.TabIndex = 10
        Me.chk_SaveGen.Text = "?Guardar generación"
        Me.chk_SaveGen.Visible = False
        '
        'xcbo_referencias
        '
        Me.xcbo_referencias.Location = New System.Drawing.Point(336, 312)
        Me.xcbo_referencias.Name = "xcbo_referencias"
        Me.xcbo_referencias.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xcbo_referencias.Size = New System.Drawing.Size(136, 16)
        Me.xcbo_referencias.TabIndex = 11
        Me.xcbo_referencias.Text = "?Utilizar Referencias"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(304, 288)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 16)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Existencia:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'exiqty
        '
        Me.exiqty.Location = New System.Drawing.Point(376, 288)
        Me.exiqty.Name = "exiqty"
        Me.exiqty.Size = New System.Drawing.Size(96, 20)
        Me.exiqty.TabIndex = 28
        Me.exiqty.Text = ""
        '
        'Chk_RD
        '
        Me.Chk_RD.Checked = True
        Me.Chk_RD.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_RD.Location = New System.Drawing.Point(321, 96)
        Me.Chk_RD.Name = "Chk_RD"
        Me.Chk_RD.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Chk_RD.Size = New System.Drawing.Size(72, 16)
        Me.Chk_RD.TabIndex = 29
        Me.Chk_RD.Text = "PesoRD"
        '
        'Chk_US
        '
        Me.Chk_US.Enabled = False
        Me.Chk_US.Location = New System.Drawing.Point(400, 96)
        Me.Chk_US.Name = "Chk_US"
        Me.Chk_US.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Chk_US.Size = New System.Drawing.Size(88, 16)
        Me.Chk_US.TabIndex = 30
        Me.Chk_US.Text = "DollaresUS"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpordnm.minimo"))
        Me.TextBox1.Location = New System.Drawing.Point(128, 264)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(344, 20)
        Me.TextBox1.TabIndex = 31
        Me.TextBox1.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label14.Location = New System.Drawing.Point(67, 264)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 16)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Producto:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(72, 290)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(152, 16)
        Me.CheckBox1.TabIndex = 33
        Me.CheckBox1.Text = "?Utilizaz Maximo y Minimo"
        '
        'g_cpordm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(594, 416)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Chk_US)
        Me.Controls.Add(Me.Chk_RD)
        Me.Controls.Add(Me.exiqty)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.xcbo_referencias)
        Me.Controls.Add(Me.chk_SaveGen)
        Me.Controls.Add(Me.xlk_ordn_serial)
        Me.Controls.Add(Me.txtordn_serial)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtord_desc)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.xdt_ordn_number)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.xlk_prov_code)
        Me.Controls.Add(Me.txtprov_code)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.prov_name)
        Me.Controls.Add(Me.txtgroup_code)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.group_name)
        Me.Controls.Add(Me.txtsgroup_code)
        Me.Controls.Add(Me.sgroup_name)
        Me.Controls.Add(Me.txtbrand_code)
        Me.Controls.Add(Me.brand_name)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtwhse_code)
        Me.Controls.Add(Me.whse_name)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtMinima)
        Me.Controls.Add(Me.txtMaxima)
        Me.Controls.Add(Me.txtPeriodo)
        Me.Controls.Add(Me.xlk_group_code)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.xlk_sgroup_code)
        Me.Controls.Add(Me.xlk_brand_code)
        Me.Controls.Add(Me.xlk_whse_code)
        Me.Controls.Add(Me.lblCountNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "g_cpordm01"
        Me.Text = "Generar Ordenes de Compra"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivitemm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpordnm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpordnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpordng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpordtmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim xSelect As LibX.Data.XSelecStmt
        Dim SelectStmt As String
        Dim WhereStmt As String
        Dim oTable As DataTable
        Dim oDato As DataTable
        Dim oDoc As SGT.Inventario.Entidades.Documento
        Dim ConteoNo As Integer
        Dim Serial, Cnt As Integer
        Dim Costo As Decimal
        Dim DiasTranscurridos As Integer
        Dim VentasPromedio As Decimal
        Dim CantidadSugerida As Decimal
        Dim CantidadSugerida1 As Decimal
        Dim DiasVentas As Decimal
        Dim oParametroCalcularPromedio As SGT.CXP.Entidades.ParametrosCalcularPromedio
        Dim oParametroCantidadSegerir As SGT.CXP.Entidades.ParametrosCalcularSugerencia
        Dim oOrdenCompra As SGT.CXP.Entidades.OrdenesCompra
        Dim oUnidad As SGT.Inventario.Entidades.UnidadMedida
        Dim oParam As SGT.Inventario.Entidades.UnidadMedida.ParametroConvertirValor
        Dim oParamCant As SGT.Inventario.Entidades.UnidadMedida.ParametroConvertir
        Try
            e.DoFill = False

            If Val(txtPeriodo.Text.Trim) <= 0 Then
                txtPeriodo.Focus()
                Throw New ApplicationException("Debe especificar el periodo a cubrir!")
            End If

            If Val(txtprov_code.Text.Trim) <= 0 Then
                txtprov_code.Focus()
                Throw New ApplicationException("Debe especificar el Suplidor!")
            End If

            '// si utilizar referencias
            If xcbo_referencias.Checked = True Then
                e.Where = e.Where.Replace("ivitemm.prov_code = " & Me.txtprov_code.Text.Trim, _
                                          "(ivitemm.prov_code = " & Me.txtprov_code.Text.Trim & _
                                          " or ivreferm.prov_code = " & Me.txtprov_code.Text.Trim & ")")

            End If
            e.Where = e.Where.Replace("ivitemm.whse_code", "ivitemd.whse_code")
            If exiqty.Text <> "" Then
                e.Sql = LibX.ConcatWherePart(e.Sql, " ivitemd.existencia " & exiqty.Text)
            End If
            SelectStmt = LibX.ConcatWherePart(e.Sql, e.Where)

            xSelect = New LibX.Data.XSelecStmt("ivitemm", SelectStmt)
            oTable = xSelect.GetTable(True)

            xSelect.Dispose()

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No existen registros con esa condición!")
            End If

            ''/Entrar los productos que cumplen la condicion 
            ''/en una tabla intermedio para luego clacificarlo
            Cnt = 1
            Limpiar()
            For Each sRow As DataRow In oTable.Rows
                Dim oRowIn As DataRow = cpordtmp.NewRow
                oRowIn!cpd_serial = Cnt
                oRowIn!item_code = sRow!item_code
                oRowIn!purch_unit = sRow!purch_unit
                oRowIn!unit_code = sRow!unit_code
                oRowIn!whse_code = sRow!whse_code
                If Me.Chk_RD.Checked = True Then
                    oRowIn!purch_cost = sRow!purch_cost
                Else
                    If Me.Chk_US.Checked = True Then
                        oRowIn!purch_cost = sRow!costus
                    End If
                    End If
                    oRowIn!datelast_sales = sRow!datelast_sales
                    oRowIn!existencia = sRow!existencia
                    oRowIn!suc_code = FindSucursal()

                    cpordtmp.Rows.Add(oRowIn)
                    Cnt = Cnt + 1
            Next

            If cpordtmp.Rows.Count > 0 Then
                LibX.Data.Manager.Save(cpordtmp)
            End If
            SelectStmt = ("select distinct item_code,purch_cost,purch_unit,datelast_sales,unit_code,existencia,whse_code from cpordtmp")
            SelectStmt = LibX.ConcatWherePart(SelectStmt, "1=1")

            xSelect = New LibX.Data.XSelecStmt("cpordtmp", SelectStmt)
            oDato = xSelect.GetTable(True)
            xSelect.Dispose()


            If MessageBox.Show("Iniciar la generación?", "Generar Orden de Compras", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If

            ProgressBar1.Maximum = oDato.Rows.Count + 1
            ProgressBar1.Minimum = 1

            '''LibX.Data.Manager.Connection.BeginTransaction()

            oDoc = New SGT.Inventario.Entidades.Documento("ORD")
            ConteoNo = oDoc.GenerateNumber("ORD", 1)

            lblCountNo.Text = ConteoNo.ToString
            Dim oNewRow1 As DataRow

            oNewRow1 = cpordnm.NewRow

            oNewRow1!ordn_number = ConteoNo
            oNewRow1!ordn_date = xdt_ordn_number.Value
            oNewRow1!type_code = "ORD"
            oNewRow1!prov_code = txtprov_code.Text
            oNewRow1!whse_code = 1
            oNewRow1!periodo = txtPeriodo.Text
            oNewRow1!ordn_note = "ORDEN GENERADA AUTOMATICAMENTE PARA EL " & CType(xdt_ordn_number.Value, Date).ToString("dd/MM/yyyy")

            oNewRow1!ordn_status = 1 'Generada
            oNewRow1!suc_code = FindSucursal()
            If Me.Chk_RD.Checked = True Then
                oNewRow1!moneda = 1
            Else
                If Me.Chk_US.Checked = True Then
                    oNewRow1!moneda = 2
                End If
            End If

            cpordnm.Rows.Add(oNewRow1)
            LibX.Data.Manager.Save(cpordnm, "ordn_serial")

            Serial = oNewRow1!ordn_serial

            oParametroCalcularPromedio = New SGT.CXP.Entidades.ParametrosCalcularPromedio
            oParametroCantidadSegerir = New SGT.CXP.Entidades.ParametrosCalcularSugerencia
            oOrdenCompra = New SGT.CXP.Entidades.OrdenesCompra
            oUnidad = New SGT.Inventario.Entidades.UnidadMedida
            oParam = New SGT.Inventario.Entidades.UnidadMedida.ParametroConvertirValor
            oParamCant = New SGT.Inventario.Entidades.UnidadMedida.ParametroConvertir

            For Each oRow As DataRow In oDato.Rows

                '// si esta en otra orden no incluir en esta
                If oOrdenCompra.estaOrdenando(orow!item_code) = True Then
                    GoTo next_product
                End If

                '// Agregar
                Dim oNewRow As DataRow = cpordnd.NewRow

                With oParametroCalcularPromedio
                    .FechaInicio = xdt_ordn_number.Value
                    .Periodo = CType(txtPeriodo.Text, Integer)
                    .Producto = oRow!item_code
                End With

                '// Ventas Promedio por dias
                VentasPromedio = oOrdenCompra.CalcularVentaPromedio(oParametroCalcularPromedio)

                '// si no tubo movimientos
                'If VentasPromedio = 0 Then
                '    GoTo next_product
                'End If

                With oParametroCantidadSegerir
                    .FechaInicio = xdt_ordn_number.Value
                    .Periodo = CType(txtPeriodo.Text, Integer)
                    .Producto = oRow!item_code
                    .TipoCalculo = SGT.CXP.Entidades.TipoCalculoEnum.PorEstadisticas
                End With

                '// Cantidad a Sugerir Por Estadisticas
                CantidadSugerida = oOrdenCompra.CalcularCantidadSugerida(oParametroCantidadSegerir)

                '// Cantidad a Sugerir Por Maximo/Minimo
                oParametroCantidadSegerir.TipoCalculo = SGT.CXP.Entidades.TipoCalculoEnum.PorMaximoMinimo
                CantidadSugerida1 = oOrdenCompra.CalcularCantidadSugerida(oParametroCantidadSegerir)

                '// Cantidad de Dias Transcurridos desde la ultima venta
                'DiasVentas = oOrdenCompra.CalcularUltimaVenta(oRow!item_code)
                If Val(oRow!datelast_sales) = Val(DateTime.Now) Then
                    DiasVentas = 1
                Else
                    DiasTranscurridos = DateDiff(DateInterval.Day, CType(oRow!datelast_sales, Date), DateTime.Now)
                    DiasVentas = DiasTranscurridos
                End If
                '// Costo por empaque de compra
                With oParam
                    .Producto = orow!item_code
                    .UnidadDestino = orow!purch_unit
                    .UnidadOrigen = orow!unit_code
                    .Valor = orow!purch_cost
                End With

                oUnidad.ConvertirValor(oParam)

                '// Convertir la Existencia
                If LibX.IsNull(orow!existencia) = False Then
                    With oParamCant
                        .Cantidad = orow!existencia
                        .Producto = orow!item_code
                        .UnidadOrigen = orow!unit_code
                        .UnidadDestino = orow!purch_unit
                    End With

                    oUnidad.ConvertirUnidad(oParamCant)

                    ''oNewRow!existencia = Decimal.Round(oParamCant.Retorno.Cantidad, 2)
                    oNewRow!existencia = FindExistencia(orow!item_code)
                End If

                '// Convertir la unidad sujerida
                If CantidadSugerida > 0 Then
                    With oParamCant
                        .Cantidad = CantidadSugerida
                        .Producto = orow!item_code
                        .UnidadOrigen = orow!unit_code
                        .UnidadDestino = orow!purch_unit
                    End With

                    oUnidad.ConvertirUnidad(oParamCant)

                    If oParamCant.Retorno.Cantidad > 0 Then
                        If oParamCant.Retorno.Cantidad < 1 Then
                            CantidadSugerida = 1
                        Else
                            CantidadSugerida = oParamCant.Retorno.Cantidad
                        End If
                    End If
                End If

                oNewRow!ordn_serial = Serial
                oNewRow!item_code = oRow!item_code
                oNewRow!unit_code = oRow!purch_unit
                oNewRow!whse_code = oRow!whse_code
                oNewRow!ref_code = 0
                oNewRow!qty = 0
                oNewRow!costo = oRow!purch_cost * oParam.Retorno.Factor
                oNewRow!promedio = Decimal.Round(VentasPromedio, 2)
                oNewRow!sugerida = Decimal.Round(CantidadSugerida, 2)
                oNewRow!diasventa = DiasVentas
                oNewRow!reorden = CantidadSugerida1
                oNewRow!suc_code = FindSucursal()

                cpordnd.Rows.Add(oNewRow)
                ProgressBar1.Value += 1
next_product:
            Next

            If cpordnd.Rows.Count > 0 Then
                LibX.Data.Manager.Save(cpordnd)
            Else
                Throw New ApplicationException("Todos los productos seleccionados en esta orden ya estan ordenados en otra orden, no se genero la orden!")
            End If

            If chk_SaveGen.Checked = True Then
                Dim GenerationTitle As String
                GenerationTitle = prov_name.Text

                GenerationTitle = InputBox("Descripcion de esta generación?", "Guardar Criterio", GenerationTitle)
                If GenerationTitle.Trim = "" Then
                    MessageBox.Show("Digite una descripción de esta generación", "No se guardo generación!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Else
                    Dim oRow As DataRow = cpordng.NewRow

                    orow!ordn_desc = GenerationTitle
                    oRow!prov_code = txtprov_code.Text
                    orow!ordn_date = xdt_ordn_number.Value
                    If txtgroup_code.Text.Trim <> "" Then
                        orow!group_code = txtgroup_code.Text
                    End If

                    If txtsgroup_code.Text.Trim <> "" Then
                        orow!sgroup_code = txtsgroup_code.Text
                    End If

                    If txtbrand_code.Text.Trim <> "" Then
                        orow!brand_code = txtbrand_code.Text
                    End If

                    If txtwhse_code.Text.Trim <> "" Then
                        orow!whse_code = txtwhse_code.Text
                    End If

                    If txtMaxima.Text.Trim <> "" Then
                        orow!max_onhand = txtMaxima.Text
                    End If

                    If txtMinima.Text.Trim <> "" Then
                        orow!min_onhand = txtMinima.Text
                    End If

                    If txtPeriodo.Text.Trim <> "" Then
                        orow!periodo = txtPeriodo.Text
                    End If

                    orow!last_date = DateTime.Now

                    If Me.xcbo_referencias.Checked = True Then
                        orow!use_refer = 1
                    End If

                    cpordng.Rows.Add(orow)
                    LibX.Data.Manager.Save(cpordng, "ordn_serial")
                End If
            End If

            '''LibX.Data.Manager.Connection.CommitTransaction()

            MessageBox.Show("Generación Exitosa!", "Generar Orden de Compra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnImprimir.Enabled = True

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click

        Me.LibXConnector1.AcceptFind()
        Me.LibXConnector1.Find()
        ProgressBar1.Maximum = 1
        ProgressBar1.Minimum = 1
        '''Me.fecHasta.Value = LibX.Data.Manager.Connection.GetDate

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LibXConnector1.Cancel()
        LibXConnector1.Find()
    End Sub

    Private Sub r_ftfact10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LibXConnector1.Find()
    End Sub


    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    '    Dim oRep As LibX.ReportLib
    '    Dim SelectStmt As String
    '    Try
    '        oRep = New LibX.ReportLib("INV", "r_ivcount01.rpt")
    '        With oRep
    '            .RetrieveSQLQuery()
    '            SelectStmt = .SQLQuery
    '            SelectStmt = LibX.ConcatWherePart(SelectStmt, "ivcounte.count_number = " & lblCountNo.Text)
    '            .SQLQuery = SelectStmt
    '            '''.ParameterFields(1) = "FechaCierre;" & Me.fecHasta.Value & ";TRUE"
    '            .Action = 1
    '        End With
    '    Catch ex As Exception
    '        LibX.Log.Show(ex)
    '    End Try
    'End Sub

    Private Sub xlk_ordn_serial_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_ordn_serial.AfterSetValues
        Try

            If e.dataFound = False Then
                Exit Sub
            End If

            Me.txtprov_code.Text = e.row!prov_code
            Me.txtgroup_code.Text = e.row!group_code
            Me.txtsgroup_code.Text = e.row!sgroup_code
            Me.txtbrand_code.Text = e.row!brand_code
            Me.txtwhse_code.Text = e.row!whse_code
            txtPeriodo = e.row!periodo
            Me.txtMinima.Text = e.row!min_onhand
            Me.txtMaxima.Text = e.row!max_onhand

            xlk_brand_code.ExecuteFind()
            xlk_group_code.ExecuteFind()
            xlk_prov_code.ExecuteFind()
            xlk_sgroup_code.ExecuteFind()
            xlk_whse_code.ExecuteFind()

            If e.row!use_refer.ToString.Trim = "1" Then
                Me.xcbo_referencias.Checked = True
            Else
                Me.xcbo_referencias.Checked = False
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub Limpiar()
        Dim DeleteStmt As String
        Try
            DeleteStmt = "truncate table cpordtmp "
            LibX.Data.Manager.ExecuteNonQuery(DeleteStmt)

        Finally
            cpordtmp.Rows.Clear()
        End Try

    End Sub
    Private Function FindSucursal() As Integer
        Dim oSucursal As Integer
        Dim SelectStmt As String

        SelectStmt = "select suc_code from cgsucursal where suc_default = 1 "
        oSucursal = LibX.Data.Manager.GetScalar(SelectStmt)

        Return oSucursal
    End Function
    Private Function FindExistencia(ByVal sMitem As String) As Integer
        Dim mCantidad As Integer

        mCantidad = LibX.Data.Manager.GetScalar("select sum(existencia) from cpordtmp where item_code  = '" & sMitem & "'")

        Return mCantidad
    End Function

    Private Sub Chk_RD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_RD.CheckedChanged
        If Me.Chk_RD.Checked = True Then
            Me.Chk_US.Checked = False
        End If
    End Sub

    Private Sub Ch_US_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_US.CheckedChanged
        If Me.Chk_US.Checked = True Then
            Me.Chk_RD.Checked = False
        End If
    End Sub
End Class
