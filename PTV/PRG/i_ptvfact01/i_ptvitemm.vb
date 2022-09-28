Public Class i_ptvitemm
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents LibXGrid2 As LibX.LibXGrid
    Friend WithEvents LibXGrid3 As LibX.LibXGrid
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
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
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents XdataGridTableStyle2 As LibX.XdataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents XdataGridTableStyle3 As LibX.XdataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LibXGrid1 = New LibX.LibXGrid
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
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataTable3 = New System.Data.DataTable
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.LibXGrid2 = New LibX.LibXGrid
        Me.XdataGridTableStyle3 = New LibX.XdataGridTableStyle
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.LibXGrid3 = New LibX.LibXGrid
        Me.XdataGridTableStyle2 = New LibX.XdataGridTableStyle
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(64, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(760, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "codigo, nombre, referencia"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar "
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AllowSorting = False
        Me.LibXGrid1.AlternatingBackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = True
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.DataMember = "ivitemv1"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = True
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 40)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(816, 272)
        Me.LibXGrid1.TabIndex = 2
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
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
        Me.LibXConnector1.DataMember = "ivitemv1"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = True
        Me.LibXConnector1.ModuleName = ""
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = ""
        Me.LibXConnector1.ReportObject = Nothing
        Me.LibXConnector1.RequeryData = True
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2, Me.LibXDbSourceTable3})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2, Me.DataTable3})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26})
        Me.DataTable1.TableName = "ivitemv1"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "whse_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "item_code"
        Me.DataColumn2.MaxLength = 10
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "item_name"
        Me.DataColumn3.MaxLength = 100
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "purch_unit"
        Me.DataColumn4.MaxLength = 5
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "purch_cost"
        Me.DataColumn5.DataType = GetType(System.Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "unit_code"
        Me.DataColumn6.MaxLength = 4
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "price"
        Me.DataColumn7.DataType = GetType(System.Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "existencia"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "benef"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "prov_code"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "brand_code"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "taxable"
        Me.DataColumn12.DataType = GetType(System.Int16)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "taxable2"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Ubicacion"
        Me.DataColumn14.MaxLength = 82
        Me.DataColumn14.ReadOnly = True
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "aplica_dscnt"
        Me.DataColumn15.DataType = GetType(System.Int16)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "datelast_purch"
        Me.DataColumn16.DataType = GetType(System.DateTime)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "dia"
        Me.DataColumn17.DataType = GetType(System.Int32)
        Me.DataColumn17.ReadOnly = True
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "precioitbis"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        Me.DataColumn18.ReadOnly = True
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "item_status"
        Me.DataColumn19.MaxLength = 20
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "prd_controlado"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "disc_pct"
        Me.DataColumn21.DataType = GetType(System.Decimal)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "sustancias"
        Me.DataColumn22.MaxLength = 300
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "asumir_emp"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "last_cost"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "existencia_min"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "exitencia_max"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35})
        Me.DataTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"item_code"}, True)})
        Me.DataTable2.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn27}
        Me.DataTable2.TableName = "ivreferm"
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "item_code"
        Me.DataColumn27.MaxLength = 10
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.ColumnName = "item_name"
        Me.DataColumn28.MaxLength = 100
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "existencia"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "unit_code"
        Me.DataColumn30.MaxLength = 4
        '
        'DataColumn31
        '
        Me.DataColumn31.AllowDBNull = False
        Me.DataColumn31.ColumnName = "item_code1"
        Me.DataColumn31.MaxLength = 10
        '
        'DataColumn32
        '
        Me.DataColumn32.AllowDBNull = False
        Me.DataColumn32.ColumnName = "purch_cost"
        Me.DataColumn32.DataType = GetType(System.Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.AllowDBNull = False
        Me.DataColumn33.ColumnName = "price"
        Me.DataColumn33.DataType = GetType(System.Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "prov_name"
        Me.DataColumn34.MaxLength = 60
        '
        'DataColumn35
        '
        Me.DataColumn35.AllowDBNull = False
        Me.DataColumn35.ColumnName = "main_code"
        Me.DataColumn35.MaxLength = 10
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41})
        Me.DataTable3.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"item_code"}, True)})
        Me.DataTable3.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn36}
        Me.DataTable3.TableName = "ivunitd"
        '
        'DataColumn36
        '
        Me.DataColumn36.AllowDBNull = False
        Me.DataColumn36.ColumnName = "item_code"
        Me.DataColumn36.MaxLength = 10
        '
        'DataColumn37
        '
        Me.DataColumn37.AllowDBNull = False
        Me.DataColumn37.ColumnName = "unit_name"
        Me.DataColumn37.MaxLength = 30
        '
        'DataColumn38
        '
        Me.DataColumn38.AllowDBNull = False
        Me.DataColumn38.ColumnName = "factor"
        Me.DataColumn38.DataType = GetType(System.Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "tipo"
        Me.DataColumn39.MaxLength = 12
        Me.DataColumn39.ReadOnly = True
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "total_cost"
        Me.DataColumn40.DataType = GetType(System.Decimal)
        Me.DataColumn40.ReadOnly = True
        '
        'DataColumn41
        '
        Me.DataColumn41.AllowDBNull = False
        Me.DataColumn41.ColumnName = "unit_code"
        Me.DataColumn41.MaxLength = 4
        '
        'LibXDbSourceTable1
        '
        Me.LibXDbSourceTable1.AllowDelete = False
        Me.LibXDbSourceTable1.AllowEdit = False
        Me.LibXDbSourceTable1.AllowNew = False
        Me.LibXDbSourceTable1.AutoIncrementSerial = False
        Me.LibXDbSourceTable1.CustomDbUpdate = False
        Me.LibXDbSourceTable1.DeleteOrder = 0
        Me.LibXDbSourceTable1.FillOnQuery = True
        Me.LibXDbSourceTable1.FillOnRowChange = True
        Me.LibXDbSourceTable1.HeaderIsOnGrid = True
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
        Me.LibXDbSourceTable1.TableName = "ivitemv1"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LibXDbSourceTable2
        '
        Me.LibXDbSourceTable2.AllowDelete = False
        Me.LibXDbSourceTable2.AllowEdit = False
        Me.LibXDbSourceTable2.AllowNew = False
        Me.LibXDbSourceTable2.AutoIncrementSerial = False
        Me.LibXDbSourceTable2.CustomDbUpdate = False
        Me.LibXDbSourceTable2.DeleteOrder = 0
        Me.LibXDbSourceTable2.FillOnQuery = True
        Me.LibXDbSourceTable2.FillOnRowChange = True
        Me.LibXDbSourceTable2.HeaderIsOnGrid = True
        Me.LibXDbSourceTable2.InnerJon = True
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = "item_code"
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"main_code=item_code"}
        Me.LibXDbSourceTable2.MasterTableName = "ivitemv1"
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select rf.item_code, im.item_name, existencia, unit_code, im.item_code as main_co" & _
        "de, ", "im.purch_cost, im.price, cp.prov_name", "from ivreferm rf", "inner join ivitemv1 im", "on im.item_code = rf.item_code", "inner join cpprovm cp", "on cp.prov_code = rf.prov_code"}
        Me.LibXDbSourceTable2.TableName = "ivreferm"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'LibXDbSourceTable3
        '
        Me.LibXDbSourceTable3.AllowDelete = False
        Me.LibXDbSourceTable3.AllowEdit = False
        Me.LibXDbSourceTable3.AllowNew = False
        Me.LibXDbSourceTable3.AutoIncrementSerial = False
        Me.LibXDbSourceTable3.CustomDbUpdate = False
        Me.LibXDbSourceTable3.DeleteOrder = 0
        Me.LibXDbSourceTable3.FillOnQuery = True
        Me.LibXDbSourceTable3.FillOnRowChange = True
        Me.LibXDbSourceTable3.HeaderIsOnGrid = True
        Me.LibXDbSourceTable3.InnerJon = False
        Me.LibXDbSourceTable3.InsertOrder = 0
        Me.LibXDbSourceTable3.IsDetail = True
        Me.LibXDbSourceTable3.KeyFields = "item_code"
        Me.LibXDbSourceTable3.LineColName = Nothing
        Me.LibXDbSourceTable3.MasterDetailRelation = New String() {"item_code=item_code"}
        Me.LibXDbSourceTable3.MasterTableName = "ivitemv1"
        Me.LibXDbSourceTable3.SerialColumnName = Nothing
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = New String() {"select ud.item_code, ud.unit_code, um.unit_name,ud.factor, case when unit_type = " & _
        "1 ", "" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "then 'Compra' ", "" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "when unit_type = 2", "" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "then 'Venta'", "" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "else", "" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "'Compra/Venta' end tipo,", "purch_cost*ud.factor total_cost", "from ivunitd ud", "inner join ivunitm um", "on um.unit_code = ud.unit_code", "inner join ivitemv1 im", "on im.item_code = ud.item_code"}
        Me.LibXDbSourceTable3.TableName = "ivunitd"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridBoolColumn1})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivitemv1"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridTextBoxColumn1.MappingName = "item_code"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 50
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridTextBoxColumn2.MappingName = "item_name"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 250
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Unidad"
        Me.DataGridTextBoxColumn3.MappingName = "unit_code"
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 65
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = "##,##0.00"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Precio."
        Me.DataGridTextBoxColumn4.MappingName = "price"
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn5.Format = "##,##0.00"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Precio+ITBIS."
        Me.DataGridTextBoxColumn5.MappingName = "precioitbis"
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = "##,##0"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Existencia."
        Me.DataGridTextBoxColumn6.MappingName = "existencia"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Ult. Compra"
        Me.DataGridTextBoxColumn7.MappingName = "dia"
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "Controlado"
        Me.DataGridBoolColumn1.MappingName = "prd_controlado"
        Me.DataGridBoolColumn1.NullValue = "0"
        Me.DataGridBoolColumn1.ReadOnly = True
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 75
        '
        'LibXGrid2
        '
        Me.LibXGrid2.AutoAdjustLastColumn = True
        Me.LibXGrid2.AutoSearch = False
        Me.LibXGrid2.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid2.DataMember = "ivunitd"
        Me.LibXGrid2.DataSource = Me.DataSet1
        Me.LibXGrid2.FullRowSelect = True
        Me.LibXGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid2.IsReadOnly = False
        Me.LibXGrid2.Location = New System.Drawing.Point(8, 320)
        Me.LibXGrid2.Name = "LibXGrid2"
        Me.LibXGrid2.ReadOnly = True
        Me.LibXGrid2.searchText = ""
        Me.LibXGrid2.showFooterBar = False
        Me.LibXGrid2.Size = New System.Drawing.Size(288, 144)
        Me.LibXGrid2.TabIndex = 3
        Me.LibXGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle3})
        Me.LibXGrid2.UseAutoFillLines = True
        Me.LibXGrid2.UseHandCursor = False
        '
        'XdataGridTableStyle3
        '
        Me.XdataGridTableStyle3.DataGrid = Me.LibXGrid2
        Me.XdataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19})
        Me.XdataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle3.MappingName = "ivunitd"
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Unidad"
        Me.DataGridTextBoxColumn16.MappingName = "unit_name"
        Me.DataGridTextBoxColumn16.ReadOnly = True
        Me.DataGridTextBoxColumn16.Width = 75
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Tipo"
        Me.DataGridTextBoxColumn17.MappingName = "tipo"
        Me.DataGridTextBoxColumn17.ReadOnly = True
        Me.DataGridTextBoxColumn17.Width = 75
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = "##0"
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "Factor"
        Me.DataGridTextBoxColumn18.MappingName = "factor"
        Me.DataGridTextBoxColumn18.ReadOnly = True
        Me.DataGridTextBoxColumn18.Width = 50
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn19.Format = "##,##0.00"
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Costo."
        Me.DataGridTextBoxColumn19.MappingName = "total_cost"
        Me.DataGridTextBoxColumn19.Width = 75
        '
        'LibXGrid3
        '
        Me.LibXGrid3.AutoAdjustLastColumn = True
        Me.LibXGrid3.AutoSearch = False
        Me.LibXGrid3.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid3.DataMember = "ivreferm"
        Me.LibXGrid3.DataSource = Me.LibXConnector1
        Me.LibXGrid3.FullRowSelect = True
        Me.LibXGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid3.IsReadOnly = True
        Me.LibXGrid3.Location = New System.Drawing.Point(304, 320)
        Me.LibXGrid3.Name = "LibXGrid3"
        Me.LibXGrid3.ReadOnly = True
        Me.LibXGrid3.searchText = ""
        Me.LibXGrid3.showFooterBar = False
        Me.LibXGrid3.Size = New System.Drawing.Size(520, 144)
        Me.LibXGrid3.TabIndex = 4
        Me.LibXGrid3.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle2})
        Me.LibXGrid3.UseAutoFillLines = True
        Me.LibXGrid3.UseHandCursor = False
        '
        'XdataGridTableStyle2
        '
        Me.XdataGridTableStyle2.DataGrid = Me.LibXGrid3
        Me.XdataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14})
        Me.XdataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle2.MappingName = "ivreferm"
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Codigo"
        Me.DataGridTextBoxColumn8.MappingName = "item_code"
        Me.DataGridTextBoxColumn8.Width = 50
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Producto"
        Me.DataGridTextBoxColumn9.MappingName = "item_name"
        Me.DataGridTextBoxColumn9.Width = 150
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Exist."
        Me.DataGridTextBoxColumn10.MappingName = "existencia"
        Me.DataGridTextBoxColumn10.Width = 50
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Unidad"
        Me.DataGridTextBoxColumn11.MappingName = "unit_code"
        Me.DataGridTextBoxColumn11.Width = 50
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn13.Format = "##,##0.00"
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Precio"
        Me.DataGridTextBoxColumn13.MappingName = "price"
        Me.DataGridTextBoxColumn13.Width = 50
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Proveedor"
        Me.DataGridTextBoxColumn14.MappingName = "prov_name"
        Me.DataGridTextBoxColumn14.Width = 75
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(8, 472)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(56, 24)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.Text = "Todos"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(72, 472)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.Text = "Con Existencia"
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(176, 472)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.Text = "Sin Existencia"
        '
        'i_ptvitemm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(832, 510)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.LibXGrid3)
        Me.Controls.Add(Me.LibXGrid2)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton3)
        Me.Name = "i_ptvitemm"
        Me.Text = "Productos"
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        LibXConnector1.ExecuteFind("existencia<=0")
    End Sub

    Private Sub i_ptvitemm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LibXConnector1.ExecuteFind()

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        LibXConnector1.ExecuteFind("1=1")
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        LibXConnector1.ExecuteFind("existencia>0")
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        LibXConnector1.LoadDetail(e.row, LibXConnector1.Sources.Item(2))

    End Sub
End Class
