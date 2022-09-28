Imports LibX
Public Class r_ivranking
    Inherits System.Windows.Forms.Form
    Dim fQty As String
    Dim sFechaDesde As String
    Dim sFechaHasta As String
    Dim almacen As Integer
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents whse_name As System.Windows.Forms.Label
    Friend WithEvents group_name As System.Windows.Forms.Label
    Friend WithEvents sgroup_name As System.Windows.Forms.Label
    Friend WithEvents prov_name As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents XTextBox13 As LibX.XTextBox
    Friend WithEvents XTextBox14 As LibX.XTextBox
    Friend WithEvents ftventav As System.Data.DataTable
    Friend WithEvents iviranking As System.Data.DataTable
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
    Friend WithEvents fec_ini As LibX.LibxDateTimePicker
    Friend WithEvents fec_fin As LibX.LibxDateTimePicker
    Friend WithEvents LibXLookup0 As LibX.LibXLookup
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents ranking As System.Data.DataTable
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents CheckQty As System.Windows.Forms.CheckBox
    Friend WithEvents CheckValor As System.Windows.Forms.CheckBox
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents Chk_gen As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_rank As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_prom As System.Windows.Forms.CheckBox
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents xtxExistencia As LibX.XTextBox
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents xtxgrupo As LibX.XTextBox
    Friend WithEvents xtxsgrupo As LibX.XTextBox
    Friend WithEvents xtxsuplidor As LibX.XTextBox
    Friend WithEvents xtxalmacen As LibX.XTextBox
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents CheckGrupo As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ftventav = New System.Data.DataTable
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
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.iviranking = New System.Data.DataTable
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.ranking = New System.Data.DataTable
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
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.fec_ini = New LibX.LibxDateTimePicker
        Me.fec_fin = New LibX.LibxDateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.whse_name = New System.Windows.Forms.Label
        Me.group_name = New System.Windows.Forms.Label
        Me.sgroup_name = New System.Windows.Forms.Label
        Me.prov_name = New System.Windows.Forms.Label
        Me.LibXLookup0 = New LibX.LibXLookup
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.xtxalmacen = New LibX.XTextBox
        Me.xtxgrupo = New LibX.XTextBox
        Me.xtxsgrupo = New LibX.XTextBox
        Me.xtxsuplidor = New LibX.XTextBox
        Me.XTextBox13 = New LibX.XTextBox
        Me.XTextBox14 = New LibX.XTextBox
        Me.CheckQty = New System.Windows.Forms.CheckBox
        Me.CheckValor = New System.Windows.Forms.CheckBox
        Me.Chk_gen = New System.Windows.Forms.CheckBox
        Me.Chk_rank = New System.Windows.Forms.CheckBox
        Me.Chk_prom = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.xtxExistencia = New LibX.XTextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckGrupo = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftventav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iviranking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ranking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.LibXConnector1.DataMember = "ftventav"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = True
        Me.LibXConnector1.HandledUpdates = True
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2, Me.LibXDbSourceTable3})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftventav, Me.iviranking, Me.ranking})
        '
        'ftventav
        '
        Me.ftventav.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn39})
        Me.ftventav.TableName = "ftventav"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "fact_number"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "fact_date"
        Me.DataColumn2.DataType = GetType(System.DateTime)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "type_code"
        Me.DataColumn3.MaxLength = 3
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "cust_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "item_code"
        Me.DataColumn5.MaxLength = 10
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "whse_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "line_no"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "qty"
        Me.DataColumn8.DataType = GetType(System.Int32)
        Me.DataColumn8.ReadOnly = True
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "price"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "dscto"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "itbis"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "costo"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "group_code"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sgroup_code"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "prov_code"
        Me.DataColumn15.DataType = GetType(System.Int32)
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "benef"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.Caption = "fec_fin"
        Me.DataColumn26.ColumnName = "fec_fin"
        Me.DataColumn26.DataType = GetType(System.DateTime)
        '
        'DataColumn27
        '
        Me.DataColumn27.Caption = "fec_ini"
        Me.DataColumn27.ColumnName = "fec_ini"
        Me.DataColumn27.DataType = GetType(System.DateTime)
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.ColumnName = "unit_code"
        Me.DataColumn28.MaxLength = 4
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "existencia"
        Me.DataColumn39.MaxLength = 10
        '
        'iviranking
        '
        Me.iviranking.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn47, Me.DataColumn48, Me.DataColumn52})
        Me.iviranking.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"rank"}, True)})
        Me.iviranking.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn18}
        Me.iviranking.TableName = "iviranking"
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.ColumnName = "item_code"
        Me.DataColumn17.MaxLength = 10
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "rank"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "qty"
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
        Me.DataColumn21.ColumnName = "costo"
        Me.DataColumn21.DataType = GetType(System.Decimal)
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "valor"
        Me.DataColumn22.DataType = GetType(System.Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "prom"
        Me.DataColumn23.DataType = GetType(System.Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.ColumnName = "fec_ini"
        Me.DataColumn24.DataType = GetType(System.DateTime)
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "fec_fin"
        Me.DataColumn25.DataType = GetType(System.DateTime)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "prov_code"
        Me.DataColumn40.DataType = GetType(System.Int32)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "group_code"
        Me.DataColumn41.DataType = GetType(System.Int32)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "sgroup_code"
        Me.DataColumn42.DataType = GetType(System.Int32)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "whse_code"
        Me.DataColumn43.DataType = GetType(System.Int32)
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "existencia"
        Me.DataColumn47.DataType = GetType(System.Int32)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "datelast_sales"
        Me.DataColumn48.DataType = GetType(System.DateTime)
        '
        'DataColumn52
        '
        Me.DataColumn52.Caption = "fact_date"
        Me.DataColumn52.ColumnName = "fact_date"
        Me.DataColumn52.DataType = GetType(System.DateTime)
        '
        'ranking
        '
        Me.ranking.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51})
        Me.ranking.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"rank_id"}, True)})
        Me.ranking.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn37}
        Me.ranking.TableName = "ranking"
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "item_code"
        Me.DataColumn29.MaxLength = 10
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "whse_code"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.AllowDBNull = False
        Me.DataColumn31.ColumnName = "sqty"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.AllowDBNull = False
        Me.DataColumn32.ColumnName = "price"
        Me.DataColumn32.DataType = GetType(System.Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.AllowDBNull = False
        Me.DataColumn33.Caption = "costo1"
        Me.DataColumn33.ColumnName = "costo1"
        Me.DataColumn33.DataType = GetType(System.Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.AllowDBNull = False
        Me.DataColumn34.ColumnName = "costo2"
        Me.DataColumn34.DataType = GetType(System.Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.AllowDBNull = False
        Me.DataColumn35.ColumnName = "price2"
        Me.DataColumn35.DataType = GetType(System.Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.AllowDBNull = False
        Me.DataColumn36.ColumnName = "unit_code"
        Me.DataColumn36.MaxLength = 4
        '
        'DataColumn37
        '
        Me.DataColumn37.AllowDBNull = False
        Me.DataColumn37.ColumnName = "rank_id"
        Me.DataColumn37.DataType = GetType(System.Int32)
        '
        'DataColumn38
        '
        Me.DataColumn38.AllowDBNull = False
        Me.DataColumn38.ColumnName = "factor"
        Me.DataColumn38.DataType = GetType(System.Decimal)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "prov_code"
        Me.DataColumn44.DataType = GetType(System.Int32)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "group_code"
        Me.DataColumn45.DataType = GetType(System.Int32)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "sgroup_code"
        Me.DataColumn46.DataType = GetType(System.Int32)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "existencia"
        Me.DataColumn49.DataType = GetType(System.Int32)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "datelast_sales"
        Me.DataColumn50.DataType = GetType(System.DateTime)
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "fact_date"
        Me.DataColumn51.DataType = GetType(System.DateTime)
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
        Me.LibXDbSourceTable1.Source = New String() {"select ftventav.*,", "       ivitemm.group_code,", "       ivitemm.sgroup_code,", "       ivitemm.prov_code,", "       ivitemd.benef ", " from ftventav inner join ivitemm ", "   on ftventav.item_code = ivitemm.item_code", "inner join ivitemd ", "   on ivitemd.item_code = ivitemm.item_code", "order by ftventav.fact_number,ftventav.item_code"}
        Me.LibXDbSourceTable1.TableName = "ftventav"
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
        Me.LibXDbSourceTable2.TableName = "iviranking"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
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
        Me.LibXDbSourceTable3.TableName = "ranking"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(57, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha inicial:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(64, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fec_ini
        '
        Me.fec_ini.CustomFormat = "dd/MM/yyyy"
        Me.fec_ini.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftventav.fec_ini"))
        Me.fec_ini.EditInitialValue = Nothing
        Me.fec_ini.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fec_ini.FieldDescription = ""
        Me.fec_ini.FindInitialValue = ""
        Me.fec_ini.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fec_ini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fec_ini.IgnoreRequiered = False
        Me.fec_ini.Location = New System.Drawing.Point(136, 88)
        Me.fec_ini.Name = "fec_ini"
        Me.fec_ini.NewInitialValue = Nothing
        Me.fec_ini.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fec_ini.Requiered = False
        Me.fec_ini.Size = New System.Drawing.Size(128, 20)
        Me.fec_ini.StatusBarPanelDescripcion = Nothing
        Me.fec_ini.TabIndex = 0
        '
        'fec_fin
        '
        Me.fec_fin.CustomFormat = "dd/MM/yyyy"
        Me.fec_fin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftventav.fec_fin"))
        Me.fec_fin.EditInitialValue = Nothing
        Me.fec_fin.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fec_fin.FieldDescription = ""
        Me.fec_fin.FindInitialValue = ""
        Me.fec_fin.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fec_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fec_fin.IgnoreRequiered = False
        Me.fec_fin.Location = New System.Drawing.Point(136, 112)
        Me.fec_fin.Name = "fec_fin"
        Me.fec_fin.NewInitialValue = Nothing
        Me.fec_fin.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fec_fin.Requiered = False
        Me.fec_fin.Size = New System.Drawing.Size(128, 20)
        Me.fec_fin.StatusBarPanelDescripcion = Nothing
        Me.fec_fin.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.Location = New System.Drawing.Point(434, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 120)
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
        'btnLimpiar
        '
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLimpiar.Location = New System.Drawing.Point(8, 47)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(72, 32)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEjecutar.Location = New System.Drawing.Point(8, 13)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(72, 32)
        Me.btnEjecutar.TabIndex = 0
        Me.btnEjecutar.Text = "Ejecutar"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(530, 48)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "RANKING DE VENTAS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(76, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Almacen:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(88, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Grupo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(65, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Sub/Grupo:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(78, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Suplidor:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(80, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Ventas:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(56, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Participacion:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'whse_name
        '
        Me.whse_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.whse_name.Location = New System.Drawing.Point(176, 136)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.Size = New System.Drawing.Size(216, 20)
        Me.whse_name.TabIndex = 34
        '
        'group_name
        '
        Me.group_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.group_name.Location = New System.Drawing.Point(176, 160)
        Me.group_name.Name = "group_name"
        Me.group_name.Size = New System.Drawing.Size(216, 20)
        Me.group_name.TabIndex = 35
        '
        'sgroup_name
        '
        Me.sgroup_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sgroup_name.Location = New System.Drawing.Point(176, 184)
        Me.sgroup_name.Name = "sgroup_name"
        Me.sgroup_name.Size = New System.Drawing.Size(216, 20)
        Me.sgroup_name.TabIndex = 36
        '
        'prov_name
        '
        Me.prov_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.prov_name.Location = New System.Drawing.Point(176, 208)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.Size = New System.Drawing.Size(216, 20)
        Me.prov_name.TabIndex = 37
        '
        'LibXLookup0
        '
        Me.LibXLookup0.AlternateFieldSearch = Nothing
        Me.LibXLookup0.BeginCheck = False
        Me.LibXLookup0.CheckText = Nothing
        Me.LibXLookup0.ComboMode = False
        Me.LibXLookup0.DataMember = Nothing
        Me.LibXLookup0.DataSource = Me.LibXConnector1
        Me.LibXLookup0.DestParameters = New String() {"whse_code=whse_code", "whse_name=whse_name"}
        Me.LibXLookup0.FilterField = "whse_name"
        Me.LibXLookup0.IgnoreFindInBrowseMode = False
        Me.LibXLookup0.isCanceled = False
        Me.LibXLookup0.Location = New System.Drawing.Point(392, 136)
        Me.LibXLookup0.LookCaption = ""
        Me.LibXLookup0.Name = "LibXLookup0"
        Me.LibXLookup0.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup0.ShowFilter = True
        Me.LibXLookup0.ShowMessageNotFound = True
        Me.LibXLookup0.ShowWarning = False
        Me.LibXLookup0.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup0.SizesColumns = Nothing
        Me.LibXLookup0.SizesColumnsTab = Nothing
        Me.LibXLookup0.SqlString = Nothing
        Me.LibXLookup0.SQLTab = Nothing
        Me.LibXLookup0.SrcParameters = New String() {"whse_code=whse_code"}
        Me.LibXLookup0.TabIndex = 8
        Me.LibXLookup0.TableName = "ivwhsem"
        Me.LibXLookup0.TabStop = False
        Me.LibXLookup0.UseCopyConnection = False
        Me.LibXLookup0.UseRowRetrieveEvents = False
        Me.LibXLookup0.UseTab = False
        Me.LibXLookup0.VisParameters = New String() {"Almacén=whse_code", "Nombre=whse_name"}
        Me.LibXLookup0.WhereCondition = Nothing
        Me.LibXLookup0.WhereParameters = Nothing
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"group_code=group_code", "group_name=group_name"}
        Me.LibXLookup1.FilterField = "group_name"
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(392, 160)
        Me.LibXLookup1.LookCaption = ""
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup1.ShowFilter = True
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.ShowWarning = False
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SizesColumns = Nothing
        Me.LibXLookup1.SizesColumnsTab = Nothing
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"group_code=group_code"}
        Me.LibXLookup1.TabIndex = 9
        Me.LibXLookup1.TableName = "ivgroupm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=group_code", "Nombre=group_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"sgroup_code=sgroup_code", "sgroup_name=sgroup_name"}
        Me.LibXLookup2.FilterField = "sgroup_name"
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(392, 184)
        Me.LibXLookup2.LookCaption = ""
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup2.ShowFilter = True
        Me.LibXLookup2.ShowMessageNotFound = True
        Me.LibXLookup2.ShowWarning = False
        Me.LibXLookup2.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup2.SizesColumns = Nothing
        Me.LibXLookup2.SizesColumnsTab = Nothing
        Me.LibXLookup2.SqlString = Nothing
        Me.LibXLookup2.SQLTab = Nothing
        Me.LibXLookup2.SrcParameters = New String() {"sgroup_code=sgroup_code"}
        Me.LibXLookup2.TabIndex = 10
        Me.LibXLookup2.TableName = "ivsgroupm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=sgroup_code", "Nombre=sgroup_name"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'LibXLookup3
        '
        Me.LibXLookup3.AlternateFieldSearch = Nothing
        Me.LibXLookup3.BeginCheck = False
        Me.LibXLookup3.CheckText = Nothing
        Me.LibXLookup3.ComboMode = False
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Me.LibXConnector1
        Me.LibXLookup3.DestParameters = New String() {"prov_code=prov_code", "prov_name=prov_name"}
        Me.LibXLookup3.FilterField = "prov_name"
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.isCanceled = False
        Me.LibXLookup3.Location = New System.Drawing.Point(392, 208)
        Me.LibXLookup3.LookCaption = ""
        Me.LibXLookup3.Name = "LibXLookup3"
        Me.LibXLookup3.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup3.ShowFilter = True
        Me.LibXLookup3.ShowMessageNotFound = True
        Me.LibXLookup3.ShowWarning = False
        Me.LibXLookup3.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup3.SizesColumns = Nothing
        Me.LibXLookup3.SizesColumnsTab = Nothing
        Me.LibXLookup3.SqlString = Nothing
        Me.LibXLookup3.SQLTab = Nothing
        Me.LibXLookup3.SrcParameters = New String() {"prov_code=prov_code"}
        Me.LibXLookup3.TabIndex = 11
        Me.LibXLookup3.TableName = "cpprovm"
        Me.LibXLookup3.TabStop = False
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.UseTab = False
        Me.LibXLookup3.VisParameters = New String() {"Código=prov_code", "Nombre=prov_name"}
        Me.LibXLookup3.WhereCondition = Nothing
        Me.LibXLookup3.WhereParameters = Nothing
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 296)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(536, 23)
        Me.ProgressBar1.TabIndex = 42
        '
        'xtxalmacen
        '
        Me.xtxalmacen.AcceptsReturn = True
        Me.xtxalmacen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftventav.whse_code"))
        Me.xtxalmacen.EditInitialValue = Nothing
        Me.xtxalmacen.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxalmacen.FieldDescription = ""
        Me.xtxalmacen.FindInitialValue = Nothing
        Me.xtxalmacen.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxalmacen.IgnoreRequiered = False
        Me.xtxalmacen.Location = New System.Drawing.Point(136, 136)
        Me.xtxalmacen.Name = "xtxalmacen"
        Me.xtxalmacen.NewInitialValue = Nothing
        Me.xtxalmacen.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxalmacen.Requiered = False
        Me.xtxalmacen.Size = New System.Drawing.Size(40, 20)
        Me.xtxalmacen.StatusBarPanelDescripcion = Nothing
        Me.xtxalmacen.TabIndex = 2
        Me.xtxalmacen.Text = ""
        '
        'xtxgrupo
        '
        Me.xtxgrupo.AcceptsReturn = True
        Me.xtxgrupo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftventav.group_code"))
        Me.xtxgrupo.EditInitialValue = Nothing
        Me.xtxgrupo.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxgrupo.FieldDescription = ""
        Me.xtxgrupo.FindInitialValue = Nothing
        Me.xtxgrupo.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxgrupo.IgnoreRequiered = False
        Me.xtxgrupo.Location = New System.Drawing.Point(136, 160)
        Me.xtxgrupo.Name = "xtxgrupo"
        Me.xtxgrupo.NewInitialValue = Nothing
        Me.xtxgrupo.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxgrupo.Requiered = False
        Me.xtxgrupo.Size = New System.Drawing.Size(40, 20)
        Me.xtxgrupo.StatusBarPanelDescripcion = Nothing
        Me.xtxgrupo.TabIndex = 3
        Me.xtxgrupo.Text = ""
        '
        'xtxsgrupo
        '
        Me.xtxsgrupo.AcceptsReturn = True
        Me.xtxsgrupo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftventav.sgroup_code"))
        Me.xtxsgrupo.EditInitialValue = Nothing
        Me.xtxsgrupo.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxsgrupo.FieldDescription = ""
        Me.xtxsgrupo.FindInitialValue = Nothing
        Me.xtxsgrupo.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxsgrupo.IgnoreRequiered = False
        Me.xtxsgrupo.Location = New System.Drawing.Point(136, 184)
        Me.xtxsgrupo.Name = "xtxsgrupo"
        Me.xtxsgrupo.NewInitialValue = Nothing
        Me.xtxsgrupo.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxsgrupo.Requiered = False
        Me.xtxsgrupo.Size = New System.Drawing.Size(40, 20)
        Me.xtxsgrupo.StatusBarPanelDescripcion = Nothing
        Me.xtxsgrupo.TabIndex = 4
        Me.xtxsgrupo.Text = ""
        '
        'xtxsuplidor
        '
        Me.xtxsuplidor.AcceptsReturn = True
        Me.xtxsuplidor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftventav.prov_code"))
        Me.xtxsuplidor.EditInitialValue = Nothing
        Me.xtxsuplidor.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxsuplidor.FieldDescription = ""
        Me.xtxsuplidor.FindInitialValue = Nothing
        Me.xtxsuplidor.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxsuplidor.IgnoreRequiered = False
        Me.xtxsuplidor.Location = New System.Drawing.Point(136, 208)
        Me.xtxsuplidor.Name = "xtxsuplidor"
        Me.xtxsuplidor.NewInitialValue = Nothing
        Me.xtxsuplidor.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxsuplidor.Requiered = False
        Me.xtxsuplidor.Size = New System.Drawing.Size(40, 20)
        Me.xtxsuplidor.StatusBarPanelDescripcion = Nothing
        Me.xtxsuplidor.TabIndex = 5
        Me.xtxsuplidor.Text = ""
        '
        'XTextBox13
        '
        Me.XTextBox13.AcceptsReturn = True
        Me.XTextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftventav.qty"))
        Me.XTextBox13.EditInitialValue = Nothing
        Me.XTextBox13.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox13.FieldDescription = ""
        Me.XTextBox13.FindInitialValue = Nothing
        Me.XTextBox13.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox13.IgnoreRequiered = False
        Me.XTextBox13.Location = New System.Drawing.Point(136, 232)
        Me.XTextBox13.Name = "XTextBox13"
        Me.XTextBox13.NewInitialValue = Nothing
        Me.XTextBox13.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox13.Requiered = False
        Me.XTextBox13.Size = New System.Drawing.Size(40, 20)
        Me.XTextBox13.StatusBarPanelDescripcion = Nothing
        Me.XTextBox13.TabIndex = 6
        Me.XTextBox13.Text = ""
        '
        'XTextBox14
        '
        Me.XTextBox14.AcceptsReturn = True
        Me.XTextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftventav.benef"))
        Me.XTextBox14.EditInitialValue = Nothing
        Me.XTextBox14.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox14.FieldDescription = ""
        Me.XTextBox14.FindInitialValue = Nothing
        Me.XTextBox14.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox14.IgnoreRequiered = False
        Me.XTextBox14.Location = New System.Drawing.Point(136, 256)
        Me.XTextBox14.Name = "XTextBox14"
        Me.XTextBox14.NewInitialValue = Nothing
        Me.XTextBox14.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox14.Requiered = False
        Me.XTextBox14.Size = New System.Drawing.Size(40, 20)
        Me.XTextBox14.StatusBarPanelDescripcion = Nothing
        Me.XTextBox14.TabIndex = 7
        Me.XTextBox14.Text = ""
        '
        'CheckQty
        '
        Me.CheckQty.Checked = True
        Me.CheckQty.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckQty.Location = New System.Drawing.Point(288, 232)
        Me.CheckQty.Name = "CheckQty"
        Me.CheckQty.Size = New System.Drawing.Size(120, 24)
        Me.CheckQty.TabIndex = 55
        Me.CheckQty.Text = "Cantidad Ventas"
        '
        'CheckValor
        '
        Me.CheckValor.Location = New System.Drawing.Point(288, 256)
        Me.CheckValor.Name = "CheckValor"
        Me.CheckValor.Size = New System.Drawing.Size(120, 24)
        Me.CheckValor.TabIndex = 56
        Me.CheckValor.Text = "Valor Ventas"
        '
        'Chk_gen
        '
        Me.Chk_gen.Location = New System.Drawing.Point(272, 88)
        Me.Chk_gen.Name = "Chk_gen"
        Me.Chk_gen.Size = New System.Drawing.Size(120, 24)
        Me.Chk_gen.TabIndex = 57
        Me.Chk_gen.Text = "Generar Ranking"
        '
        'Chk_rank
        '
        Me.Chk_rank.Location = New System.Drawing.Point(184, 232)
        Me.Chk_rank.Name = "Chk_rank"
        Me.Chk_rank.Size = New System.Drawing.Size(120, 24)
        Me.Chk_rank.TabIndex = 55
        Me.Chk_rank.Text = "Ranking"
        '
        'Chk_prom
        '
        Me.Chk_prom.Location = New System.Drawing.Point(184, 256)
        Me.Chk_prom.Name = "Chk_prom"
        Me.Chk_prom.Size = New System.Drawing.Size(120, 24)
        Me.Chk_prom.TabIndex = 56
        Me.Chk_prom.Text = "Promedio"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(272, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 16)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Existencia"
        '
        'xtxExistencia
        '
        Me.xtxExistencia.AcceptsReturn = True
        Me.xtxExistencia.EditInitialValue = Nothing
        Me.xtxExistencia.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxExistencia.FieldDescription = ""
        Me.xtxExistencia.FindInitialValue = Nothing
        Me.xtxExistencia.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxExistencia.IgnoreRequiered = False
        Me.xtxExistencia.Location = New System.Drawing.Point(328, 112)
        Me.xtxExistencia.Name = "xtxExistencia"
        Me.xtxExistencia.NewInitialValue = Nothing
        Me.xtxExistencia.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxExistencia.Requiered = False
        Me.xtxExistencia.Size = New System.Drawing.Size(80, 20)
        Me.xtxExistencia.StatusBarPanelDescripcion = Nothing
        Me.xtxExistencia.TabIndex = 60
        Me.xtxExistencia.Text = ""
        Me.ToolTip1.SetToolTip(Me.xtxExistencia, "Dindicar <0; >0; =0; <> 0; >=0  ")
        '
        'CheckGrupo
        '
        Me.CheckGrupo.Location = New System.Drawing.Point(400, 240)
        Me.CheckGrupo.Name = "CheckGrupo"
        Me.CheckGrupo.Size = New System.Drawing.Size(96, 24)
        Me.CheckGrupo.TabIndex = 61
        Me.CheckGrupo.Text = "Grupos"
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(400, 264)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(96, 24)
        Me.CheckBox2.TabIndex = 62
        Me.CheckBox2.Text = "Suplidores"
        Me.CheckBox2.Visible = False
        '
        'r_ivranking
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(530, 344)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckGrupo)
        Me.Controls.Add(Me.xtxExistencia)
        Me.Controls.Add(Me.XTextBox14)
        Me.Controls.Add(Me.XTextBox13)
        Me.Controls.Add(Me.xtxsuplidor)
        Me.Controls.Add(Me.xtxsgrupo)
        Me.Controls.Add(Me.xtxgrupo)
        Me.Controls.Add(Me.xtxalmacen)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Chk_gen)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LibXLookup3)
        Me.Controls.Add(Me.LibXLookup2)
        Me.Controls.Add(Me.LibXLookup1)
        Me.Controls.Add(Me.LibXLookup0)
        Me.Controls.Add(Me.prov_name)
        Me.Controls.Add(Me.sgroup_name)
        Me.Controls.Add(Me.group_name)
        Me.Controls.Add(Me.whse_name)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fec_fin)
        Me.Controls.Add(Me.fec_ini)
        Me.Controls.Add(Me.CheckValor)
        Me.Controls.Add(Me.CheckQty)
        Me.Controls.Add(Me.Chk_rank)
        Me.Controls.Add(Me.Chk_prom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "r_ivranking"
        Me.Text = "Reporte de Ranking de Ventas"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftventav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iviranking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ranking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            Dim xSelect As LibX.Data.XSelecStmt
            Dim oRanking As DataTable
            Dim oTable As DataTable
            Dim oRowamount As DataRow
            Dim ID As Integer
            Dim SelecStmt As String
            Dim almacen As Integer
            Dim grupo As Integer
            Dim sgrupo As Integer
            Dim suplidor As Integer
            Dim ventas As Decimal
            Dim participa As Decimal
            Dim XUpdate As LibX.Data.XUpdateStmt

            Dim sWhere As String
            If Not IsNull(e.row!fec_ini) Then
                sFechaDesde = CDate(e.row!fec_ini).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(e.row!fec_fin) Then
                sFechaHasta = CDate(e.row!fec_fin).ToString(LibX.Data.Manager.GetSaveDateFormat)
            Else
                sFechaHasta = CDate(Now).ToString(LibX.Data.Manager.GetSaveDateFormat)
                Me.fec_fin.NewInitialValue = CDate(Now).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(e.row!whse_code) Then
                almacen = e.row!whse_code
            End If

            If Not IsNull(e.row!group_code) Then
                grupo = e.row!group_code
            End If
            If Not IsNull(e.row!sgroup_code) Then
                sgrupo = e.row!sgroup_code
            End If
            If Not IsNull(e.row!prov_code) Then
                suplidor = e.row!prov_code
            End If

            If Me.xtxExistencia.Text <> "" Then
                fQty = Me.xtxExistencia.Text
            End If

            If Not IsNull(e.row!qty) Then
                ventas = e.row!qty
            End If
            If Not IsNull(e.row!benef) Then
                participa = e.row!benef
            End If

            sWhere = " 1=1 "
            If Trim(grupo) <> 0 Then
                sWhere = String.Concat(sWhere, " and ivitemm.group_code = " & Trim(grupo))
            End If
            If Trim(sgrupo) <> 0 Then
                sWhere = String.Concat(sWhere, " and ivitemm.sgroup_code = " & Trim(sgrupo))
            End If
            If Trim(suplidor) <> 0 Then
                sWhere = String.Concat(sWhere, " and ivitemm.prov_code = " & Trim(suplidor))
            End If

            If Trim(participa) <> 0 Then
                sWhere = String.Concat(sWhere, " and ivitemd.benef <= '", Trim(participa), "'")
            End If
            If Trim(almacen) <> 0 Then
                sWhere = String.Concat(sWhere, " and ivitemd.whse_code = " & Trim(almacen))
            End If

            If LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If
            If Me.Chk_gen.Checked = False Then
                imprimir()
            Else
                SelecStmt = "delete from ranking where 1=1 "
                oTable = LibX.Data.Manager.GetDataTable(SelecStmt)

                If Trim(almacen) <> 0 Then
                    SelecStmt = "select distinct ivitemd.whse_code,ivitemm.item_code,0 sqty,avg(ivitemd.price)price,avg(ftventav.costo)purch_cost," & _
                                "0 costo2,0 price2,ivitemm.unit_code,group_code,sgroup_code,ivitemm.prov_code from ivitemm " & _
                                "inner join ivitemd on ivitemm.item_code = ivitemd.item_code and ivitemm.item_status = 1 " & _
                                "inner join ftventav on ivitemd.item_code = ftventav.item_code " & _
                                "where ftventav.fact_date between '" & _
                                Trim(sFechaDesde) & _
                                "' and '" & _
                                Trim(sFechaHasta) & _
                               "'" & _
                               "and ftventav.qty > 0"

                    SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                    SelecStmt = SelecStmt & "group by ivitemd.whse_code,ivitemm.item_code,ivitemm.unit_code,group_code,sgroup_code,ivitemm.prov_code" & _
                                            "  order by ivitemm.item_code "
                    oRanking = LibX.Data.Manager.GetDataTable(SelecStmt)

                Else
                    SelecStmt = "select distinct ivitemm.item_code,0 sqty,avg(ivitemd.price)price,avg(ftventav.costo)purch_cost," & _
                                "0 costo2,0 price2,ivitemm.unit_code,group_code,sgroup_code,ivitemm.prov_code from ivitemm " & _
                                "inner join ivitemd on ivitemm.item_code = ivitemd.item_code and ivitemm.item_status = 1 " & _
                                "inner join ftventav on ivitemd.item_code = ftventav.item_code " & _
                                "where ftventav.fact_date between '" & _
                                Trim(sFechaDesde) & _
                                "' and '" & _
                                Trim(sFechaHasta) & _
                                "'" & _
                                "and ftventav.qty > 0"

                    SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                    SelecStmt = SelecStmt & "group by ivitemm.item_code,ivitemm.unit_code,group_code,sgroup_code,ivitemm.prov_code" & _
                                            "  order by ivitemm.item_code "
                    oRanking = LibX.Data.Manager.GetDataTable(SelecStmt)

                End If

               
                ID = 1

                For Each oRow1 As DataRow In oRanking.Rows
                    Dim Rank As DataRow = ranking.NewRow
                    If Trim(almacen) <> 0 Then
                        Rank!whse_code = oRow1!whse_code
                    End If
                    Rank!item_code = oRow1!item_code
                    If LibX.IsNull(Me.fec_fin.Value) Then
                        Rank!sqty = QTyvendida(oRow1!item_code.ToString, Trim(almacen), CDate(Me.fec_ini.Value).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat), CDate(Now).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat), Val(oRow1!sqty.ToString))
                    Else
                        Rank!sqty = QTyvendida(oRow1!item_code.ToString, CDate(Me.fec_ini.Value).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat), CDate(Me.fec_fin.Value).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat), Val(oRow1!sqty.ToString), Trim(almacen))
                    End If
                    Rank!existencia = FindExistencia(oRow1!item_code)
                    Rank!price = oRow1!price
                    Rank!costo1 = oRow1!purch_cost
                    Rank!costo2 = oRow1!costo2
                    Rank!price2 = oRow1!price2
                    Rank!unit_code = oRow1!unit_code
                    Rank!prov_code = GetLastProv(oRow1!item_code)  'oRow1!prov_code
                    Rank!group_code = oRow1!group_code
                    Rank!sgroup_code = oRow1!sgroup_code

                    Rank!rank_id = ID

                    If Rank!item_code <> " " Then
                        ranking.Rows.Add(Rank)
                    End If
                    ID += 1
                Next

                LibX.Data.Manager.Save(ranking)

                If LibX.Data.Manager.Connection.IsIntransaction = True Then
                    LibX.Data.Manager.Connection.CommitTransaction()
                End If

                If ranking.Rows.Count = 0 Then
                    MessageBox.Show("No se han producido ventas para este periodo", "Ventas", MessageBoxButtons.OK)
                    Return
                End If

                SelecStmt = "update ranking set costo2 = sqty * costo1,price2 = sqty * price where 1=1 "
                oTable = LibX.Data.Manager.GetDataTable(SelecStmt)

                SelecStmt = "update ranking set sqty = sqty * -1, costo2 = costo2 * -1,price2 = price2 * -1 where sqty < 0 "
                oTable = LibX.Data.Manager.GetDataTable(SelecStmt)

                SelecStmt = "delete from ranking where sqty = 0 "
                oTable = LibX.Data.Manager.GetDataTable(SelecStmt)

                SelecStmt = "delete from iviranking where 1=1 "
                oTable = LibX.Data.Manager.GetDataTable(SelecStmt)

                SelecStmt = "select sum(costo2)total_costo,sum(price2)total_price,sum(sqty)total_cantidad from ranking where 1 =1 "
                oRowamount = LibX.Data.Manager.GetDataRow(SelecStmt)
                If Trim(almacen) <> 0 Then
                    SelecStmt = "select item_code,sqty,unit_code,costo1,price2,prov_code,group_code,sgroup_code,whse_code,existencia " & _
                                " from ranking where 1=1 "
                Else
                    SelecStmt = "select item_code,sqty,unit_code,costo1,price2,prov_code,group_code,sgroup_code,1 whse_code,existencia " & _
                                " from ranking where 1=1 "
                End If

                If Me.CheckQty.Checked = True And Me.CheckValor.Checked = False And Me.Chk_prom.Checked = False And Me.Chk_rank.Checked = False Then
                    SelecStmt = SelecStmt & " order by sqty desc "
                End If
                If Me.CheckQty.Checked = False And Me.CheckValor.Checked = True And Me.Chk_prom.Checked = False And Me.Chk_rank.Checked = False Then
                    SelecStmt = SelecStmt & " order by price2 desc "
                End If
                If Me.CheckQty.Checked = False And Me.CheckValor.Checked = False Then
                    SelecStmt = SelecStmt & " order by sqty desc "
                End If

                oTable = LibX.Data.Manager.GetDataTable(SelecStmt)

                ProgressBar1.Maximum = oTable.Rows.Count + 1
                ProgressBar1.Minimum = 1
                ProgressBar1.Value = 1

                ID = 1

                For Each oRow As DataRow In oTable.Rows
                    Dim oNewRow As DataRow = iviranking.NewRow
                    oNewRow!rank = ID
                    oNewRow!item_code = oRow!item_code
                    oNewRow!qty = oRow!sqty
                    oNewRow!costo = oRow!costo1
                    oNewRow!unit_code = oRow!unit_code
                    oNewRow!valor = oRow!price2
                    oNewRow!existencia = oRow!existencia
                    If Me.CheckQty.Checked = True Then
                        oNewRow!prom = Format((oRow!sqty / oRowamount!total_cantidad) * 100.0, "##0.00")
                    ElseIf Me.CheckValor.Checked = True Then
                        oNewRow!prom = Format((oRow!price2 / oRowamount!total_price) * 100.0, "##0.00")
                    Else
                        oNewRow!prom = Format((oRow!sqty / oRowamount!total_cantidad) * 100.0, "##0.00")
                    End If


                    If LibX.IsNull(Me.fec_fin.Value) Then
                        If CDate(Me.fec_ini.Value).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat) <> CDate(Now).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat) Then
                            oNewRow!fec_ini = CDate(Me.fec_ini.Value).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat)
                            oNewRow!fec_fin = CDate(Now).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat)
                        Else
                            oNewRow!fec_ini = CDate(Me.fec_ini.Value).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat)
                            oNewRow!fec_fin = CDate(Now).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat)
                        End If
                    Else
                        If CDate(Me.fec_ini.Value).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat) <> CDate(Me.fec_fin.Value).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat) Then
                            oNewRow!fec_ini = CDate(Me.fec_ini.Value).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat)
                            oNewRow!fec_fin = CDate(Me.fec_fin.Value).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat)
                        Else
                            oNewRow!fec_ini = CDate(Me.fec_ini.Value).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat)
                            oNewRow!fec_fin = CDate(Me.fec_fin.Value).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat)
                        End If
                    End If
                    oNewRow!prov_code = GetLastProv(oNewRow!item_code.ToString) ' oRow!prov_code
                    oNewRow!group_code = oRow!group_code
                    oNewRow!sgroup_code = oRow!sgroup_code
                    If Trim(almacen) <> 0 Then
                        oNewRow!whse_code = oRow!whse_code
                    Else
                        oNewRow!whse_code = oRow!whse_code
                    End If
                    If oNewRow!item_code <> " " Then
                        iviranking.Rows.Add(oNewRow)
                    End If
                    ProgressBar1.Value += 1
                    ID += 1
                Next

                If LibX.Data.Manager.Connection.IsIntransaction = False Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                End If

                LibX.Data.Manager.Save(iviranking)

                If LibX.Data.Manager.Connection.IsIntransaction = True Then
                    LibX.Data.Manager.Connection.CommitTransaction()
                End If

                If iviranking.Rows.Count > 0 Then
                    imprimir()
                End If
            End If

        Catch ex As Exception
            Log.Show(ex)
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
        End Try

    End Sub
    Private Sub imprimir()
        Dim oRep As LibX.ReportLib
        Dim SelecStmt As String
        Dim swhere As String
        Dim grupo As String
        Dim sgrupo As String
        Dim suplidor As String
        Dim almacen As String
        Try
            If CheckGrupo.Checked = True Then
                oRep = New LibX.ReportLib("FCT", "r_ivranking2.rpt")
            Else
                oRep = New LibX.ReportLib("FCT", "r_ivranking.rpt")
            End If

            swhere = "1=1"
            If Not IsNull(Me.xtxalmacen.Text) Then
                almacen = Me.xtxalmacen.Text
            End If
            If Not IsNull(Me.xtxsgrupo.Text) Then
                sgrupo = Me.xtxsgrupo.Text
            End If
            If Not IsNull(Me.xtxsgrupo.Text) Then
                grupo = Me.xtxsgrupo.Text
            End If
            If Not IsNull(Me.xtxsuplidor.Text) Then
                suplidor = Me.xtxsuplidor.Text
            End If

            With oRep
                .ParameterFields(0) = String.Concat("fec_ini;", Trim(sFechaDesde), ";TRUE")
                .ParameterFields(1) = String.Concat("fec_fin;", Trim(sFechaHasta), ";TRUE")

                If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" And Trim(sFechaDesde) <> Trim(sFechaHasta) Then
                    swhere = String.Concat(swhere, " and ivitemd.datelast_sales between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
                End If
                If Trim(sFechaDesde) = Trim(sFechaHasta) Then
                    swhere = String.Concat(swhere, " and ivitemd.datelast_sales  = '", Trim(sFechaDesde), "'")
                End If

                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = SelecStmt

                If Trim(fQty) <> "" Then
                    swhere = String.Concat(swhere, " and iviranking.existencia  " & Trim(fQty))
                End If
                If Trim(sgrupo) <> "" Then
                    swhere = String.Concat(swhere, " and iviranking.sgroup_code =  " & Trim(sgrupo))
                End If
                If Trim(grupo) <> "" Then
                    swhere = String.Concat(swhere, " and iviranking.group_code =  " & Trim(grupo))
                End If
                If Trim(suplidor) <> "" Then
                    swhere = String.Concat(swhere, " and iviranking.prov_code =  " & Trim(suplidor))
                End If
                If Trim(almacen) <> "" Then
                    swhere = String.Concat(swhere, " and ivitemd.whse_code =  " & Trim(almacen))
                End If

                SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, swhere)

                If Me.CheckQty.Checked = True And Me.CheckValor.Checked = False And Me.Chk_prom.Checked = False And Me.Chk_rank.Checked = False And Me.CheckGrupo.Checked = False Then
                    SelecStmt = SelecStmt & " order by qty desc "
                End If
                If Me.CheckQty.Checked = False And Me.CheckValor.Checked = True And Me.Chk_prom.Checked = False And Me.Chk_rank.Checked = False And Me.CheckGrupo.Checked = False Then
                    SelecStmt = SelecStmt & " order by valor desc "
                End If
                If Me.Chk_rank.Checked = True And Me.CheckValor.Checked = False And Me.Chk_prom.Checked = False And Me.CheckQty.Checked = False And Me.CheckGrupo.Checked = False Then
                    SelecStmt = SelecStmt & " order by rank "
                End If
                If Me.Chk_prom.Checked = True And Me.CheckValor.Checked = False And Me.CheckQty.Checked = False And Me.Chk_rank.Checked = False And Me.CheckGrupo.Checked = False Then
                    SelecStmt = SelecStmt & " order by prom desc "
                End If
                If Me.Chk_rank.Checked = False And Me.CheckValor.Checked = False And Me.Chk_prom.Checked = False And Me.CheckQty.Checked = False And Me.CheckGrupo.Checked = False Then
                    SelecStmt = SelecStmt & " order by item_name asc "
                End If
                ''If Me.CheckGrupo.Checked = True Then
                ''    SelecStmt = SelecStmt & " order by iviranking.group_code ASC"
                ''End If

                .SQLQuery = SelecStmt
                .Action = 1
            End With
            Me.ProgressBar1.Maximum = 0
            Me.ProgressBar1.Minimum = 0
            Me.Chk_rank.Checked = False
            Me.Chk_prom.Checked = False
            Me.CheckQty.Checked = False
            Me.CheckValor.Checked = False
            Me.Chk_gen.Checked = False
            Me.CheckGrupo.Checked = False
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Function QTyvendida(ByVal item_code As String, ByVal fecha As Date, ByVal fechaf As Date, ByVal qtyVta As Integer, ByVal fAlmacen As Integer) As Integer
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim sqty, sqty1 As Integer

        Try
            If fecha.ToString.Trim = fechaf.ToString.Trim Then
                If fAlmacen = 0 Then
                    SelectStmt = "select ftventav.item_code ,sum(qty)qty,ivunitd.factor" & _
                        " from ftventav inner join ivunitd " & _
                        " on ivunitd.unit_code = ftventav.unit_code" & _
                        " and ivunitd.item_code = ftventav.item_code" & _
                        " where ftventav.item_code = '" & item_code.Trim & "'" & _
                        " and ftventav.fact_date = '" & fecha.ToString(LibX.Data.Manager.GetSaveDateFormat) & "'" & _
                        " group by ftventav.item_code,ivunitd.factor "
                Else
                    SelectStmt = "select ftventav.item_code ,sum(qty)qty,ivunitd.factor" & _
                        " from ftventav inner join ivunitd " & _
                        " on ivunitd.unit_code = ftventav.unit_code" & _
                        " and ivunitd.item_code = ftventav.item_code" & _
                        " where ftventav.item_code = '" & item_code.Trim & "'" & _
                        " and ftventav.whse_code = " & fAlmacen & _
                        " and ftventav.fact_date = '" & fecha.ToString(LibX.Data.Manager.GetSaveDateFormat) & "'" & _
                        " group by ftventav.item_code,ivunitd.factor "
                End If
            Else
                If fAlmacen > 0 Then
                    SelectStmt = "select ftventav.item_code ,sum(qty)qty,ivunitd.factor" & _
                        " from ftventav inner join ivunitd " & _
                        " on ivunitd.unit_code = ftventav.unit_code" & _
                        " and ivunitd.item_code = ftventav.item_code" & _
                        " where ftventav.item_code = '" & item_code.Trim & "'" & _
                        " and ftventav.whse_code = " & fAlmacen & _
                        " and ftventav.fact_date between '" & fecha.ToString(LibX.Data.Manager.GetSaveDateFormat) & _
                        " 'and '" & fechaf.ToString(LibX.Data.Manager.GetSaveDateFormat) & "'" & _
                        " group by ftventav.item_code,ivunitd.factor "
                Else
                    SelectStmt = "select ftventav.item_code ,sum(qty)qty,ivunitd.factor" & _
                         " from ftventav inner join ivunitd " & _
                         " on ivunitd.unit_code = ftventav.unit_code" & _
                         " and ivunitd.item_code = ftventav.item_code" & _
                         " where ftventav.item_code = '" & item_code.Trim & "'" & _
                         " and ftventav.fact_date between '" & fecha.ToString(LibX.Data.Manager.GetSaveDateFormat) & _
                         " 'and '" & fechaf.ToString(LibX.Data.Manager.GetSaveDateFormat) & "'" & _
                         " group by ftventav.item_code,ivunitd.factor "
                End If
            End If
            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            For Each orow As DataRow In oTable.Rows
                sqty = (Val(orow!qty.ToString))
                If (Val(orow!qty.ToString)) < 0 Then
                    sqty = (Val(orow!qty.ToString) * -1)
                End If
                qtyVta += sqty.ToString * Val(orow!factor.ToString)

            Next

            Return qtyVta

        Catch ex As Exception
            LibX.Log.Show(ex)
            Return -1
        End Try
    End Function

    Private Function GetLastProv(ByVal pitem_code As String) As Integer
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim prov_code As Integer

        Try

            SelectStmt = "select TOP 1 prov_code " & _
            " from iventrdd " & _
            " inner join iventrdm " & _
            " on iventrdd.entr_serial = iventrdm.entr_serial " & _
            " where item_code = '" & pitem_code & "'" & _
            " order by entr_date desc "

            prov_code = LibX.Data.Manager.GetScalar(SelectStmt)

            Return prov_code

        Catch ex As Exception
            LibX.Log.Show(ex)
            Return -1
        End Try
    End Function
    Private Function FindExistencia(ByVal item_code As String) As Integer
        Dim exitQty As Integer
        If Trim(almacen) <> 0 Then
            exitQty = LibX.Data.Manager.GetScalar("select sum(existencia) from ivitemd where item_code ='" & item_code.Trim & "' and  whse_code=" & almacen)
        Else
            exitQty = LibX.Data.Manager.GetScalar("select sum(existencia) from ivitemd where item_code ='" & item_code.Trim & "'")
        End If
        Return exitQty
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Me.LibXConnector1.AcceptFind()
        Me.LibXConnector1.Find()
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        If Me.LibXConnector1.IsEditing Then
            Me.LibXConnector1.Cancel()
        End If
        Me.ProgressBar1.Maximum = 0
        Me.ProgressBar1.Minimum = 0
        Me.Chk_rank.Checked = False
        Me.Chk_prom.Checked = False
        Me.CheckQty.Checked = False
        Me.CheckValor.Checked = False
        Me.Chk_gen.Checked = False
        Me.CheckGrupo.Checked = False
        Me.LibXConnector1.Find()
    End Sub

    Private Sub r_ftfact10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LibXConnector1.Find()
        If Me.Chk_gen.Checked = True Then
            Me.Chk_prom.Enabled = False
            Me.Chk_rank.Enabled = False
            Me.CheckGrupo.Enabled = False
        End If

    End Sub

    Private Sub Chk_gen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_gen.CheckedChanged
        If Me.Chk_gen.Checked = True Then
            Me.Chk_prom.Enabled = False
            Me.Chk_rank.Enabled = False
            Me.CheckGrupo.Enabled = False
        Else
            Me.Chk_prom.Enabled = True
            Me.Chk_rank.Enabled = True
            Me.CheckGrupo.Enabled = True
        End If

    End Sub

    Private Sub Chk_rank_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_rank.CheckedChanged
        If Me.Chk_rank.Checked = True Then
            Me.Chk_prom.Enabled = False
            Me.CheckValor.Enabled = False
            Me.CheckQty.Enabled = False
            Me.CheckGrupo.Enabled = False
        Else
            Me.Chk_prom.Enabled = True
            Me.CheckValor.Enabled = True
            Me.CheckQty.Enabled = True
            Me.CheckGrupo.Enabled = True
        End If
    End Sub

    Private Sub Chk_prom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_prom.CheckedChanged
        If Me.Chk_prom.Checked = True Then
            Me.Chk_rank.Enabled = False
            Me.CheckValor.Enabled = False
            Me.CheckQty.Enabled = False
            Me.CheckGrupo.Enabled = False
        Else
            Me.Chk_rank.Enabled = True
            Me.CheckValor.Enabled = True
            Me.CheckQty.Enabled = True
            Me.CheckGrupo.Enabled = True
        End If
    End Sub

    Private Sub CheckQty_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckQty.CheckedChanged
        If Me.CheckQty.Checked = True Then
            Me.Chk_rank.Enabled = False
            Me.CheckValor.Enabled = False
            Me.Chk_prom.Enabled = False
            Me.CheckGrupo.Enabled = False
        Else
            If Me.Chk_gen.Checked = False Then
                Me.Chk_rank.Enabled = True
                Me.Chk_prom.Enabled = True
                Me.CheckGrupo.Enabled = True
            End If

            Me.CheckValor.Enabled = True
        End If
    End Sub

    Private Sub CheckValor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckValor.CheckedChanged
        If Me.CheckValor.Checked = True Then
            Me.Chk_rank.Enabled = False
            Me.Chk_prom.Enabled = False
            Me.CheckQty.Enabled = False
            Me.CheckGrupo.Enabled = False
        Else
            If Me.Chk_gen.Checked = False Then
                Me.Chk_rank.Enabled = True
                Me.Chk_prom.Enabled = True
                Me.CheckGrupo.Enabled = True
            End If
            Me.CheckQty.Enabled = True
        End If
    End Sub
    Private Sub CheckGrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckGrupo.CheckedChanged
        If Me.CheckGrupo.Checked = True Then
            Me.Chk_rank.Enabled = False
            Me.Chk_prom.Enabled = False
            Me.CheckQty.Enabled = False
            Me.CheckValor.Enabled = False
        Else
            If Me.Chk_gen.Checked = False Then
                Me.Chk_rank.Enabled = True
                Me.Chk_prom.Enabled = True
                Me.CheckValor.Enabled = True
            End If
            Me.CheckQty.Enabled = True
        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
