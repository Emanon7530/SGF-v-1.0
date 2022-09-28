Public Class i_ivvcmto01
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
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents xdt_item_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xdt_qty As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xdt_mes_vence As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xdt_año_vence As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lk_whse_code As LibX.LibXLookup
    Friend WithEvents txtwhse_code As LibX.XTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents whse_name As LibX.XTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents xdt_qty1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xdt_mes_vence1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xdt_año_vence1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xdb_ivvcmtom As LibX.LibXDbSourceTable
    Friend WithEvents xdb_ivvcmtod As LibX.LibXDbSourceTable
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataTable3 As System.Data.DataTable
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
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
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
    Friend WithEvents prov_name As LibX.XTextBox
    Friend WithEvents txtprov_code As LibX.XTextBox
    Friend WithEvents xlk_prov_code As LibX.LibXLookup
    Friend WithEvents xdt_doc_date As LibX.LibxDateTimePicker
    Friend WithEvents xdt_item_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents xlk_item_code As LibX.LibXLookup
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents xdt_unit_code As LibX.XEditTextBoxColumn
    Friend WithEvents xcbo_doc_status As LibX.LibXCombo
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents xdt_existencia As LibX.XEditTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblexistencia As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable3 = New System.Data.DataTable
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
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
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.xdt_item_code = New LibX.XDataGridTextButtonColumn
        Me.xlk_item_code = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.xdb_ivvcmtom = New LibX.LibXDbSourceTable
        Me.xdb_ivvcmtod = New LibX.LibXDbSourceTable
        Me.xdt_item_name = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_existencia = New LibX.XEditTextBoxColumn
        Me.xdt_unit_code = New LibX.XEditTextBoxColumn
        Me.xdt_qty = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_mes_vence = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_año_vence = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_qty1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_mes_vence1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_año_vence1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.txtprov_code = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xlk_prov_code = New LibX.LibXLookup
        Me.XTextBox1 = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.xcbo_doc_status = New LibX.LibXCombo
        Me.Label2 = New System.Windows.Forms.Label
        Me.xdt_doc_date = New LibX.LibxDateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.prov_name = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lk_whse_code = New LibX.LibXLookup
        Me.txtwhse_code = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.whse_name = New LibX.XTextBox
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
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.btnActualizar = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblexistencia = New System.Windows.Forms.Label
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Productos"
        Me.LibXGrid1.DataMember = "ivvcmtod"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 144)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(920, 328)
        Me.LibXGrid1.TabIndex = 2
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3, Me.DataTable1})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31})
        Me.DataTable3.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"doc_serial"}, True)})
        Me.DataTable3.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn25}
        Me.DataTable3.TableName = "ivvcmtom"
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.AutoIncrement = True
        Me.DataColumn25.ColumnName = "doc_serial"
        Me.DataColumn25.DataType = GetType(System.Int32)
        Me.DataColumn25.ReadOnly = True
        '
        'DataColumn26
        '
        Me.DataColumn26.AllowDBNull = False
        Me.DataColumn26.ColumnName = "type_code"
        Me.DataColumn26.MaxLength = 3
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "whse_code"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "doc_number"
        Me.DataColumn28.MaxLength = 20
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "doc_date"
        Me.DataColumn29.DataType = GetType(System.DateTime)
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "doc_status"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.AllowDBNull = False
        Me.DataColumn31.ColumnName = "prov_code"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17})
        Me.DataTable1.TableName = "ivvcmtod"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "doc_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
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
        Me.DataColumn3.ColumnName = "line_no"
        Me.DataColumn3.DataType = GetType(System.Int32)
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
        Me.DataColumn5.ColumnName = "item_code"
        Me.DataColumn5.MaxLength = 10
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "unit_code"
        Me.DataColumn6.MaxLength = 5
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "qty"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "purch_cost"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "qty_onhand"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "vcmto_month"
        Me.DataColumn10.MaxLength = 2
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "vcmto_year"
        Me.DataColumn11.MaxLength = 4
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "qty1"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "vcmto_month1"
        Me.DataColumn13.MaxLength = 2
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "vcmto_year1"
        Me.DataColumn14.MaxLength = 4
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
        Me.DataColumn16.ColumnName = "item_name"
        Me.DataColumn16.MaxLength = 100
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "existencia"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.xdt_item_code, Me.xdt_item_name, Me.xdt_existencia, Me.xdt_unit_code, Me.xdt_qty, Me.xdt_mes_vence, Me.xdt_año_vence, Me.xdt_qty1, Me.xdt_mes_vence1, Me.xdt_año_vence1})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivvcmtod"
        '
        'xdt_item_code
        '
        Me.xdt_item_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.xdt_item_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_item_code.executeFindDuringFill = False
        Me.xdt_item_code.Format = ""
        Me.xdt_item_code.FormatInfo = Nothing
        Me.xdt_item_code.HeaderText = "Producto"
        Me.xdt_item_code.isReadOnly = False
        Me.xdt_item_code.Lookup = Me.xlk_item_code
        Me.xdt_item_code.MappingName = "item_code"
        Me.xdt_item_code.MaxLength = 32767
        Me.xdt_item_code.TabStop = True
        Me.xdt_item_code.UseCustomCellFormat = False
        Me.xdt_item_code.Width = 101
        '
        'xlk_item_code
        '
        Me.xlk_item_code.AlternateFieldSearch = Nothing
        Me.xlk_item_code.BeginCheck = False
        Me.xlk_item_code.CheckText = "Existencia mayor  que Cero (> 0)"
        Me.xlk_item_code.ComboMode = False
        Me.xlk_item_code.Cursor = System.Windows.Forms.Cursors.Hand
        Me.xlk_item_code.DataMember = Nothing
        Me.xlk_item_code.DataSource = Me.LibXConnector1
        Me.xlk_item_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "qty_onhand=existencia"}
        Me.xlk_item_code.FilterField = "item_name"
        Me.xlk_item_code.IgnoreFindInBrowseMode = True
        Me.xlk_item_code.isCanceled = False
        Me.xlk_item_code.Location = New System.Drawing.Point(320, 256)
        Me.xlk_item_code.LookCaption = "Productos"
        Me.xlk_item_code.Name = "xlk_item_code"
        Me.xlk_item_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_item_code.ShowFilter = True
        Me.xlk_item_code.ShowMessageNotFound = True
        Me.xlk_item_code.ShowWarning = False
        Me.xlk_item_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_item_code.SizesColumns = New String() {"item_name=450"}
        Me.xlk_item_code.SizesColumnsTab = Nothing
        Me.xlk_item_code.SqlString = Nothing
        Me.xlk_item_code.SQLTab = Nothing
        Me.xlk_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.xlk_item_code.TabIndex = 3
        Me.xlk_item_code.TableName = "ivitemv1"
        Me.xlk_item_code.TabStop = False
        Me.xlk_item_code.UseCopyConnection = False
        Me.xlk_item_code.UseRowRetrieveEvents = False
        Me.xlk_item_code.UseTab = False
        Me.xlk_item_code.VisParameters = New String() {"Producto=item_code", "Descripcion=item_name", "Unidad/Compra=purch_unit", "Existencia=existencia"}
        Me.xlk_item_code.WhereCondition = Nothing
        Me.xlk_item_code.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "ivvcmtom"
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
        Me.LibXConnector1.RequeryData = True
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.xdb_ivvcmtom, Me.xdb_ivvcmtod})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
        '
        'xdb_ivvcmtom
        '
        Me.xdb_ivvcmtom.AllowDelete = True
        Me.xdb_ivvcmtom.AllowEdit = True
        Me.xdb_ivvcmtom.AllowNew = True
        Me.xdb_ivvcmtom.AutoIncrementSerial = False
        Me.xdb_ivvcmtom.CustomDbUpdate = False
        Me.xdb_ivvcmtom.DeleteOrder = 0
        Me.xdb_ivvcmtom.FillOnQuery = True
        Me.xdb_ivvcmtom.FillOnRowChange = False
        Me.xdb_ivvcmtom.HeaderIsOnGrid = False
        Me.xdb_ivvcmtom.InnerJon = True
        Me.xdb_ivvcmtom.InsertOrder = 0
        Me.xdb_ivvcmtom.IsDetail = False
        Me.xdb_ivvcmtom.KeyFields = Nothing
        Me.xdb_ivvcmtom.LineColName = Nothing
        Me.xdb_ivvcmtom.MasterDetailRelation = Nothing
        Me.xdb_ivvcmtom.MasterTableName = Nothing
        Me.xdb_ivvcmtom.SerialColumnName = "doc_serial"
        Me.xdb_ivvcmtom.Sort = Nothing
        Me.xdb_ivvcmtom.Source = Nothing
        Me.xdb_ivvcmtom.TableName = "ivvcmtom"
        Me.xdb_ivvcmtom.UpdateOrder = 0
        Me.xdb_ivvcmtom.UseRowRetrieve = False
        '
        'xdb_ivvcmtod
        '
        Me.xdb_ivvcmtod.AllowDelete = True
        Me.xdb_ivvcmtod.AllowEdit = True
        Me.xdb_ivvcmtod.AllowNew = True
        Me.xdb_ivvcmtod.AutoIncrementSerial = False
        Me.xdb_ivvcmtod.CustomDbUpdate = False
        Me.xdb_ivvcmtod.DeleteOrder = 0
        Me.xdb_ivvcmtod.FillOnQuery = True
        Me.xdb_ivvcmtod.FillOnRowChange = True
        Me.xdb_ivvcmtod.HeaderIsOnGrid = False
        Me.xdb_ivvcmtod.InnerJon = True
        Me.xdb_ivvcmtod.InsertOrder = 0
        Me.xdb_ivvcmtod.IsDetail = True
        Me.xdb_ivvcmtod.KeyFields = Nothing
        Me.xdb_ivvcmtod.LineColName = "line_no"
        Me.xdb_ivvcmtod.MasterDetailRelation = New String() {"doc_serial=doc_serial", "type_code=type_code", "whse_code=whse_code", "prov_code=prov_code"}
        Me.xdb_ivvcmtod.MasterTableName = Nothing
        Me.xdb_ivvcmtod.SerialColumnName = Nothing
        Me.xdb_ivvcmtod.Sort = Nothing
        Me.xdb_ivvcmtod.Source = New String() {"select ivvcmtod.*,ivitemm.item_name", "from ivvcmtod inner join ivitemm", "on ivitemm.item_code = ivvcmtod.item_code"}
        Me.xdb_ivvcmtod.TableName = "ivvcmtod"
        Me.xdb_ivvcmtod.UpdateOrder = 0
        Me.xdb_ivvcmtod.UseRowRetrieve = False
        '
        'xdt_item_name
        '
        Me.xdt_item_name.Format = ""
        Me.xdt_item_name.FormatInfo = Nothing
        Me.xdt_item_name.HeaderText = "Descripción"
        Me.xdt_item_name.MappingName = "item_name"
        Me.xdt_item_name.ReadOnly = True
        Me.xdt_item_name.Width = 250
        '
        'xdt_existencia
        '
        Me.xdt_existencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_existencia.Format = ""
        Me.xdt_existencia.FormatInfo = Nothing
        Me.xdt_existencia.HeaderText = "Existencia"
        Me.xdt_existencia.ImageList = Nothing
        Me.xdt_existencia.isReadOnly = True
        Me.xdt_existencia.MappingName = "qty_onhand"
        Me.xdt_existencia.MaxLength = 32767
        Me.xdt_existencia.ReadOnly = True
        Me.xdt_existencia.TabStop = True
        Me.xdt_existencia.UseCustomCellFormat = False
        Me.xdt_existencia.Width = 60
        '
        'xdt_unit_code
        '
        Me.xdt_unit_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_unit_code.Format = ""
        Me.xdt_unit_code.FormatInfo = Nothing
        Me.xdt_unit_code.HeaderText = "Unidad"
        Me.xdt_unit_code.ImageList = Nothing
        Me.xdt_unit_code.isReadOnly = True
        Me.xdt_unit_code.MappingName = "unit_code"
        Me.xdt_unit_code.MaxLength = 32767
        Me.xdt_unit_code.ReadOnly = True
        Me.xdt_unit_code.TabStop = True
        Me.xdt_unit_code.UseCustomCellFormat = False
        Me.xdt_unit_code.Width = 75
        '
        'xdt_qty
        '
        Me.xdt_qty.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_qty.Format = "####0.00"
        Me.xdt_qty.FormatInfo = Nothing
        Me.xdt_qty.HeaderText = "Cantidadi"
        Me.xdt_qty.MappingName = "qty"
        Me.xdt_qty.Width = 75
        '
        'xdt_mes_vence
        '
        Me.xdt_mes_vence.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_mes_vence.Format = "##"
        Me.xdt_mes_vence.FormatInfo = Nothing
        Me.xdt_mes_vence.HeaderText = "Mesi"
        Me.xdt_mes_vence.MappingName = "vcmto_month"
        Me.xdt_mes_vence.Width = 60
        '
        'xdt_año_vence
        '
        Me.xdt_año_vence.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_año_vence.Format = "####"
        Me.xdt_año_vence.FormatInfo = Nothing
        Me.xdt_año_vence.HeaderText = "Añoi"
        Me.xdt_año_vence.MappingName = "vcmto_year"
        Me.xdt_año_vence.Width = 60
        '
        'xdt_qty1
        '
        Me.xdt_qty1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_qty1.Format = "####0.00"
        Me.xdt_qty1.FormatInfo = Nothing
        Me.xdt_qty1.HeaderText = "Cantidadi"
        Me.xdt_qty1.MappingName = "qty1"
        Me.xdt_qty1.Width = 75
        '
        'xdt_mes_vence1
        '
        Me.xdt_mes_vence1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_mes_vence1.Format = "##"
        Me.xdt_mes_vence1.FormatInfo = Nothing
        Me.xdt_mes_vence1.HeaderText = "Mesi"
        Me.xdt_mes_vence1.MappingName = "vcmto_month1"
        Me.xdt_mes_vence1.Width = 60
        '
        'xdt_año_vence1
        '
        Me.xdt_año_vence1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_año_vence1.Format = "####"
        Me.xdt_año_vence1.FormatInfo = Nothing
        Me.xdt_año_vence1.HeaderText = "Añoi"
        Me.xdt_año_vence1.MappingName = "vcmto_year1"
        Me.xdt_año_vence1.Width = 60
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
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Nothing
        Me.LibXNavigator1.FirstControlInFindMode = Me.txtprov_code
        Me.LibXNavigator1.FirstControlInNewMode = Me.txtprov_code
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(938, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'txtprov_code
        '
        Me.txtprov_code.AcceptsReturn = True
        Me.txtprov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivvcmtom.prov_code"))
        Me.txtprov_code.EditInitialValue = Nothing
        Me.txtprov_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.FieldDescription = ""
        Me.txtprov_code.FindInitialValue = Nothing
        Me.txtprov_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.IgnoreRequiered = False
        Me.txtprov_code.Location = New System.Drawing.Point(96, 24)
        Me.txtprov_code.Name = "txtprov_code"
        Me.txtprov_code.NewInitialValue = Nothing
        Me.txtprov_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.Requiered = False
        Me.txtprov_code.Size = New System.Drawing.Size(96, 20)
        Me.txtprov_code.StatusBarPanelDescripcion = Nothing
        Me.txtprov_code.TabIndex = 0
        Me.txtprov_code.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xlk_prov_code)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xcbo_doc_status)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xdt_doc_date)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.prov_name)
        Me.GroupBox1.Controls.Add(Me.txtprov_code)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lk_whse_code)
        Me.GroupBox1.Controls.Add(Me.txtwhse_code)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.whse_name)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(920, 104)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
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
        Me.xlk_prov_code.Location = New System.Drawing.Point(560, 24)
        Me.xlk_prov_code.LookCaption = "Proveedores"
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
        Me.xlk_prov_code.TabIndex = 36
        Me.xlk_prov_code.TableName = "cpprovm"
        Me.xlk_prov_code.TabStop = False
        Me.xlk_prov_code.UseCopyConnection = False
        Me.xlk_prov_code.UseRowRetrieveEvents = False
        Me.xlk_prov_code.UseTab = False
        Me.xlk_prov_code.VisParameters = New String() {"Codigo=prov_code", "Nombre=prov_name"}
        Me.xlk_prov_code.WhereCondition = Nothing
        Me.xlk_prov_code.WhereParameters = Nothing
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivvcmtom.doc_number"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(96, 72)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(96, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 2
        Me.XTextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(33, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Numero:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_doc_status
        '
        Me.xcbo_doc_status.AllowDefaultSort = True
        Me.xcbo_doc_status.bound = True
        Me.xcbo_doc_status.currValue = Nothing
        Me.xcbo_doc_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ivvcmtom.doc_status"))
        Me.xcbo_doc_status.DefaultWhereString = Nothing
        Me.xcbo_doc_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_doc_status.EditInitialValue = Nothing
        Me.xcbo_doc_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_doc_status.FieldDescription = ""
        Me.xcbo_doc_status.FindInitialValue = Nothing
        Me.xcbo_doc_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_doc_status.IgnoreRequiered = False
        Me.xcbo_doc_status.Items.AddRange(New Object() {"1-Pendiente Aplicar", "2-Aplicado"})
        Me.xcbo_doc_status.Location = New System.Drawing.Point(648, 48)
        Me.xcbo_doc_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_doc_status.LookupKeyField = Nothing
        Me.xcbo_doc_status.LookupTableName = Nothing
        Me.xcbo_doc_status.Name = "xcbo_doc_status"
        Me.xcbo_doc_status.NewInitialValue = "1"
        Me.xcbo_doc_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_doc_status.Requiered = False
        Me.xcbo_doc_status.Required = False
        Me.xcbo_doc_status.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_doc_status.SqlString = Nothing
        Me.xcbo_doc_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_doc_status.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(586, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Estatus:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xdt_doc_date
        '
        Me.xdt_doc_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_doc_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ivvcmtom.doc_date"))
        Me.xdt_doc_date.EditInitialValue = Nothing
        Me.xdt_doc_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_doc_date.FieldDescription = ""
        Me.xdt_doc_date.FindInitialValue = Nothing
        Me.xdt_doc_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_doc_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_doc_date.IgnoreRequiered = False
        Me.xdt_doc_date.Location = New System.Drawing.Point(648, 24)
        Me.xdt_doc_date.Name = "xdt_doc_date"
        Me.xdt_doc_date.NewInitialValue = "today"
        Me.xdt_doc_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_doc_date.Requiered = False
        Me.xdt_doc_date.Size = New System.Drawing.Size(120, 20)
        Me.xdt_doc_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_doc_date.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(592, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Fecha:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'prov_name
        '
        Me.prov_name.AcceptsReturn = True
        Me.prov_name.EditInitialValue = Nothing
        Me.prov_name.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.prov_name.FieldDescription = ""
        Me.prov_name.FindInitialValue = Nothing
        Me.prov_name.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.prov_name.IgnoreRequiered = False
        Me.prov_name.Location = New System.Drawing.Point(200, 24)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.NewInitialValue = Nothing
        Me.prov_name.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.prov_name.ReadOnly = True
        Me.prov_name.Requiered = False
        Me.prov_name.Size = New System.Drawing.Size(360, 20)
        Me.prov_name.StatusBarPanelDescripcion = Nothing
        Me.prov_name.TabIndex = 28
        Me.prov_name.TabStop = False
        Me.prov_name.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(32, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Suplidor:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.lk_whse_code.FilterField = Nothing
        Me.lk_whse_code.IgnoreFindInBrowseMode = False
        Me.lk_whse_code.isCanceled = False
        Me.lk_whse_code.Location = New System.Drawing.Point(560, 48)
        Me.lk_whse_code.LookCaption = "Almacenes"
        Me.lk_whse_code.Name = "lk_whse_code"
        Me.lk_whse_code.PopupSize = New System.Drawing.Size(400, 400)
        Me.lk_whse_code.ShowFilter = True
        Me.lk_whse_code.ShowMessageNotFound = True
        Me.lk_whse_code.ShowWarning = False
        Me.lk_whse_code.Size = New System.Drawing.Size(16, 20)
        Me.lk_whse_code.SizesColumns = Nothing
        Me.lk_whse_code.SizesColumnsTab = Nothing
        Me.lk_whse_code.SqlString = Nothing
        Me.lk_whse_code.SQLTab = Nothing
        Me.lk_whse_code.SrcParameters = New String() {"whse_code=whse_code"}
        Me.lk_whse_code.TabIndex = 23
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
        Me.txtwhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivvcmtom.whse_code"))
        Me.txtwhse_code.EditInitialValue = Nothing
        Me.txtwhse_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.FieldDescription = ""
        Me.txtwhse_code.FindInitialValue = Nothing
        Me.txtwhse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.IgnoreRequiered = False
        Me.txtwhse_code.Location = New System.Drawing.Point(96, 48)
        Me.txtwhse_code.Name = "txtwhse_code"
        Me.txtwhse_code.NewInitialValue = Nothing
        Me.txtwhse_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.Requiered = False
        Me.txtwhse_code.Size = New System.Drawing.Size(96, 20)
        Me.txtwhse_code.StatusBarPanelDescripcion = Nothing
        Me.txtwhse_code.TabIndex = 1
        Me.txtwhse_code.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(30, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Almacen:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'whse_name
        '
        Me.whse_name.AcceptsReturn = True
        Me.whse_name.EditInitialValue = Nothing
        Me.whse_name.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.whse_name.FieldDescription = ""
        Me.whse_name.FindInitialValue = Nothing
        Me.whse_name.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.whse_name.IgnoreRequiered = False
        Me.whse_name.Location = New System.Drawing.Point(200, 48)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.NewInitialValue = Nothing
        Me.whse_name.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.whse_name.ReadOnly = True
        Me.whse_name.Requiered = False
        Me.whse_name.Size = New System.Drawing.Size(360, 20)
        Me.whse_name.StatusBarPanelDescripcion = Nothing
        Me.whse_name.TabIndex = 22
        Me.whse_name.TabStop = False
        Me.whse_name.Text = ""
        '
        'DataColumn32
        '
        Me.DataColumn32.AllowDBNull = False
        Me.DataColumn32.ColumnName = "doc_serial"
        Me.DataColumn32.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.AllowDBNull = False
        Me.DataColumn33.ColumnName = "type_code"
        Me.DataColumn33.MaxLength = 3
        '
        'DataColumn34
        '
        Me.DataColumn34.AllowDBNull = False
        Me.DataColumn34.ColumnName = "line_no"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "whse_code"
        Me.DataColumn35.DataType = GetType(System.Int32)
        '
        'DataColumn36
        '
        Me.DataColumn36.AllowDBNull = False
        Me.DataColumn36.ColumnName = "item_code"
        Me.DataColumn36.MaxLength = 20
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "unit_code"
        Me.DataColumn37.MaxLength = 5
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "qty"
        Me.DataColumn38.DataType = GetType(System.Int32)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "purch_cost"
        Me.DataColumn39.DataType = GetType(System.Decimal)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "qty_onhand"
        Me.DataColumn40.DataType = GetType(System.Int32)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "vcmto_month"
        Me.DataColumn41.MaxLength = 2
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "vcmto_year"
        Me.DataColumn42.MaxLength = 4
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "qty1"
        Me.DataColumn43.DataType = GetType(System.Int32)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "vcmto_month1"
        Me.DataColumn44.MaxLength = 2
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "vcmto_year1"
        Me.DataColumn45.MaxLength = 4
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "prov_code"
        Me.DataColumn46.DataType = GetType(System.Int32)
        '
        'DataColumn47
        '
        Me.DataColumn47.AllowDBNull = False
        Me.DataColumn47.ColumnName = "item_name"
        Me.DataColumn47.MaxLength = 100
        '
        'btnActualizar
        '
        Me.btnActualizar.Enabled = False
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnActualizar.Location = New System.Drawing.Point(8, 536)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.TabIndex = 3
        Me.btnActualizar.Text = "Actualizar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(8, 504)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Existencia:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblexistencia
        '
        Me.lblexistencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblexistencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivvcmtod.qty_onhand"))
        Me.lblexistencia.Location = New System.Drawing.Point(80, 504)
        Me.lblexistencia.Name = "lblexistencia"
        Me.lblexistencia.Size = New System.Drawing.Size(112, 23)
        Me.lblexistencia.TabIndex = 6
        Me.lblexistencia.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'i_ivvcmto01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(938, 584)
        Me.Controls.Add(Me.lblexistencia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.xlk_item_code)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.LibXGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivvcmto01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Captura de Vencimientos"
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Dim oArticulo As New SGT.Inventario.Entidades.Articulo
    Dim oDoc As SGT.Inventario.Entidades.Documento

    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
        Try

            If e.cell = LibXGrid1.GetColNum(xdt_qty) Then
                If LibXGrid1.GetValue(e.row, xdt_item_code).ToString.Trim = "" Then
                    LibXGrid1.Focus(e.row, 0)
                    Exit Sub
                End If

                If Val(e.value.Trim) <= 0 Then
                    Throw New ApplicationException("Cantidad invalida, verifique!")
                End If

                If Val(e.value.Trim) + Val(LibXGrid1.GetValue(e.row, xdt_qty1).ToString.Trim) _
                > LibXGrid1.GetValue(e.row, xdt_existencia) Then
                    Throw New ApplicationException("Cantidad No puede ser mayor que la existencia, verifique!")
                End If
            End If

            If e.cell = LibXGrid1.GetColNum(xdt_qty1) Then
                If LibXGrid1.GetValue(e.row, xdt_item_code).ToString.Trim = "" Then
                    LibXGrid1.Focus(e.row, 0)
                    Exit Sub
                End If

                If Val(e.value.Trim) < 0 Then
                    Throw New ApplicationException("Cantidad invalida, verifique!")
                End If

                If Val(e.value.Trim) + Val(LibXGrid1.GetValue(e.row, xdt_qty).ToString.Trim) _
                > LibXGrid1.GetValue(e.row, xdt_existencia) Then
                    Throw New ApplicationException("Cantidad No puede ser mayor que la existencia, verifique!")
                End If
            End If

            If e.cell = LibXGrid1.GetColNum(xdt_mes_vence) Then
                If LibXGrid1.GetValue(e.row, xdt_item_code).ToString.Trim = "" Then
                    LibXGrid1.Focus(e.row, 0)
                    Exit Sub
                End If

                If Val(e.value.Trim) <= 0 OrElse Val(e.value.Trim) > 12 Then
                    Throw New ApplicationException("Mes inválido, verifique!")
                    Exit Sub
                End If
            End If

            If e.cell = LibXGrid1.GetColNum(xdt_mes_vence1) Then
                If LibXGrid1.GetValue(e.row, xdt_item_code).ToString.Trim = "" Then
                    LibXGrid1.Focus(e.row, 0)
                    Exit Sub
                End If

                If Val(e.value.Trim) < 0 OrElse Val(e.value.Trim) > 12 Then
                    Throw New ApplicationException("Mes inválido, verifique!")
                    Exit Sub
                End If
            End If

            'If e.cell = LibXGrid1.GetColNum(xdt_año_vence) Then
            '    If Val(e.value.Trim) <= 0 Then
            '        e.hasErrors = True
            '        Exit Sub
            '    End If
            'End If

            'If e.cell = LibXGrid1.GetColNum(xdt_qty1) Then
            '    If Val(e.value.ToString.Trim) <= 0 Then
            '        LibXGrid1.Focus(e.row, 9)
            '        Exit Sub
            '    End If
            'End If

            'If e.cell = LibXGrid1.GetColNum(xdt_año_vence1) Then
            '    If Val(LibXGrid1.GetValue(xdt_qty1)) > 0 AndAlso Val(e.value.Trim) = 0 Then
            '        e.hasErrors = True
            '        Exit Sub
            '    End If
            'End If

            'If e.cell = LibXGrid1.GetColNum(xdt_mes_vence1) Then
            '    If Val(LibXGrid1.GetValue(xdt_qty1)) > 0 AndAlso Val(e.value.Trim) = 0 Then
            '        e.hasErrors = True
            '        Exit Sub
            '    End If
            'End If

        Catch ex As Exception
            e.hasErrors = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        'Dim oTable As DataTable
        'Dim WhereStmt As String
        'Dim SelectStmt As String

        'Try
        '    If e.Action = LibX.LibxConnectionActions.Cancel Then
        '        Exit Sub
        '    End If

        '    If e.Action = LibX.LibxConnectionActions.Delete Then
        '        Dim XDelete As New LibX.Data.XDeleteStmt("ivvcmtod")

        '        e.Handled = True

        '        If MessageBox.Show("Desea borrar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then
        '            Exit Sub
        '        End If

        '        '// INICIAR TRANSACCION
        '        LibX.Data.Manager.Connection.BeginTransaction()

        '        XDelete.Parameters.Add("type_code", LibXConnector1.CurrentDataRow!type_code.ToString.Trim)
        '        XDelete.Parameters.Add("doc_serial", LibXConnector1.CurrentDataRow!doc_serial.ToString.Trim)
        '        XDelete.Execute()

        '        '// TERMINAR TRANSACCION
        '        LibX.Data.Manager.Connection.CommitTransaction()

        '        WhereStmt = "doc_serial = " & LibXConnector1.CurrentDataRow!doc_serial.ToString.Trim & _
        '                     " and type_code = '" & LibXConnector1.CurrentDataRow!type_code.ToString.Trim & "'"

        '        LibXConnector1.ExecuteFind(WhereStmt)

        '        Exit Sub
        '    End If

        '    Select Case e.AcceptedAction
        '        Case LibX.LibxConnectionActions.Edit, LibX.LibxConnectionActions.Add

        '            'e.Handled = True
        '            SelectStmt = "select * from ivvcmtod where doc_serial = " & LibXConnector1.CurrentDataRow!doc_serial.ToString.Trim & _
        '                         " and type_code = '" & LibXConnector1.CurrentDataRow!type_code.ToString.Trim & "'"

        '            WhereStmt = "doc_serial = " & LibXConnector1.CurrentDataRow!doc_serial.ToString.Trim & _
        '                         " and type_code = '" & LibXConnector1.CurrentDataRow!type_code.ToString.Trim & "'" & _
        '                         " and line_no = {0}"

        '            oTable = LibX.Data.Manager.GetDataTable(SelectStmt, "ivvcmtod", True)

        '            Dim oNewRow As DataRow
        '            For Each oRow As DataRow In DataSet1.Tables("ivvcmtdv").Rows
        '                '// Vencimiento 1
        '                If Math.Abs(Val(oRow!qty.ToString.Trim)) <= 0 Then
        '                    Throw New ApplicationException("cantidad a vencer debe ser 0!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
        '                End If

        '                If IsDBNull(oRow!prov_code) Then
        '                    Throw New ApplicationException("Especifique el suplidor del producto " & oRow!item_name.ToString.Trim)
        '                End If

        '                If Math.Abs(Val(oRow!qty.ToString.Trim)) > Math.Abs(Val(oRow!qty_onhand.ToString.Trim)) Then
        '                    Throw New ApplicationException("cantidad a vencer inválida no puede ser mayor q la cantidad comprada!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
        '                End If

        '                If Val(oRow!vcmto_month.ToString.Trim) <= 0 Then
        '                    Throw New ApplicationException("Debe especificar el mes de vencimiento!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
        '                End If

        '                If Val(oRow!vcmto_month.ToString.Trim) > 12 Then
        '                    Throw New ApplicationException("El mes a vencer debe estar entre 1 y 12!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
        '                End If

        '                If Val(oRow!vcmto_year.ToString.Trim) <= 0 Then
        '                    Throw New ApplicationException("Debe especificar el Año de vencimiento!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
        '                End If

        '                If Val(oRow!vcmto_year.ToString.Trim) < DateTime.Now.Year Then
        '                    Throw New ApplicationException("El Ano a vencer no debe ser menor que el año actual!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
        '                End If

        '                If DateSerial(oRow!vcmto_year.ToString.Trim, oRow!vcmto_month.ToString.Trim, 1) <= DateSerial(DateTime.Now.Year, DateTime.Now.Month, 1) Then
        '                    Throw New ApplicationException("La fecha de vencimiento especificada ya se cumplio!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
        '                End If

        '                '// Vencimiento 1
        '                If Math.Abs(Val(oRow!qty1.ToString.Trim)) > 0 Then
        '                    If Math.Abs(Val(oRow!qty1.ToString.Trim)) > Math.Abs(Val(oRow!qty_onhand.ToString.Trim)) Then
        '                        Throw New ApplicationException("cantidad a vencer inválida no puede ser mayor q la cantidad comprada!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
        '                    End If

        '                    If Val(oRow!vcmto_month1.ToString.Trim) <= 0 Then
        '                        Throw New ApplicationException("Debe especificar el mes de vencimiento!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
        '                    End If

        '                    If Val(oRow!vcmto_month1.ToString.Trim) > 12 Then
        '                        Throw New ApplicationException("El mes a vencer debe estar entre 1 y 12!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
        '                    End If

        '                    If Val(oRow!vcmto_year1.ToString.Trim) <= 0 Then
        '                        Throw New ApplicationException("Debe especificar el Año de vencimiento!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
        '                    End If

        '                    If Val(oRow!vcmto_year1.ToString.Trim) < DateTime.Now.Year Then
        '                        Throw New ApplicationException("El Ano a vencer no debe ser menor que el año actual!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
        '                    End If

        '                    If DateSerial(oRow!vcmto_year1.ToString.Trim, oRow!vcmto_month1.ToString.Trim, 1) <= DateSerial(DateTime.Now.Year, DateTime.Now.Month, 1) Then
        '                        Throw New ApplicationException("La fecha de vencimiento especificada ya se cumplio!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
        '                    End If
        '                End If

        '                If Math.Abs(Val(oRow!qty.ToString.Trim)) + Math.Abs(Val(oRow!qty1.ToString.Trim)) <> Math.Abs(Val(oRow!qty_onhand.ToString.Trim)) Then
        '                    Throw New ApplicationException("Suma de las cantidades a vencer es diferente a la cantidad comprada!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
        '                End If

        '                '// Si existe, modificarlo
        '                If IsDBNull(oRow!line_no) = False Then
        '                    oNewRow = oTable.Select(String.Format(WhereStmt, oRow!Line_no))(0)
        '                    oNewRow.BeginEdit()
        '                End If

        '                '// si es nuevo modificarlo
        '                If IsDBNull(oRow!line_no) = True Then
        '                    oNewRow = oTable.NewRow
        '                    oNewRow!line_no = oTable.Compute("count(line_no)", "1=1") + 1
        '                    oNewRow!doc_serial = oRow!doc_serial
        '                    oNewRow!type_code = oRow!type_code
        '                    oNewRow!item_code = oRow!item_code
        '                    oNewRow!prov_code = oRow!prov_code
        '                    oNewRow!whse_code = oRow!whse_code
        '                    oTable.Rows.Add(oNewRow)
        '                End If

        '                '// si es Eliminado
        '                If oRow.RowState = DataRowState.Deleted Then
        '                    oNewRow = oTable.Select(String.Format(WhereStmt, oRow!Line_no))(0)
        '                    oNewRow.Delete()
        '                End If

        '                If oRow.RowState <> DataRowState.Unchanged Then
        '                    oNewRow!unit_code = oRow!unit_code
        '                    oNewRow!purch_cost = oRow!purch_cost
        '                    oNewRow!qty_onhand = oRow!qty_onhand
        '                    oNewRow!qty = oRow!qty
        '                    oNewRow!vcmto_month = oRow!vcmto_month
        '                    oNewRow!vcmto_year = oRow!vcmto_year
        '                    oNewRow!qty1 = oRow!qty1
        '                    oNewRow!vcmto_month1 = oRow!vcmto_month1
        '                    oNewRow!vcmto_year1 = oRow!vcmto_year1
        '                    oNewRow!prov_code = oRow!prov_code
        '                    oNewRow!whse_code = oRow!whse_code
        '                    oNewRow.EndEdit()
        '                End If
        '            Next
        '            '// INICIAR TRANSACCION
        '            LibX.Data.Manager.Connection.BeginTransaction()

        '            LibX.Data.Manager.Save(oTable)

        '            '// TERMINAR TRANSACCION
        '            LibX.Data.Manager.Connection.CommitTransaction()
        '    End Select

        'Catch ex As Exception
        '    e.Handled = True
        '    LibX.Log.Add(ex)
        'End Try
    End Sub

    Private Sub i_ivcmtod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            LibXGrid1.footerOperations.add("item_code", "count(item_code)")
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        ''Try
        ''    If e.Action = LibX.LibxConnectionActions.Edit And e.AcceptedAction <> LibX.LibxConnectionActions.Cancel Then
        ''        Me.LibXGrid1.Focus(0, 3)
        ''    End If

        ''Catch ex As Exception
        ''    LibX.Log.Add(ex, True)
        ''End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues

        Try
            Me.xdt_doc_date.Value = LibX.Data.Manager.Connection.GetDate
            LibXConnector1.CurrentDataRow!doc_date = LibX.Data.Manager.Connection.GetDate
            Me.txtwhse_code.Text = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxWhDefault")
            lk_whse_code.ExecuteFind()

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                If LibX.IsNull(e.UpdatingArgs.Row!doc_date) = True Then
                    e.UpdatingArgs.Row!doc_date = LibX.Data.Manager.Connection.GetDate
                End If
                e.UpdatingArgs.Row!type_code = "VEN"
                If LibX.IsNull(e.UpdatingArgs.Row!doc_number) = True Then
                    Dim doc As New SGT.Inventario.Entidades.Documento("VEN")
                    e.UpdatingArgs.Row!doc_number = doc.GenerateNumber("VEN", e.UpdatingArgs.Row!whse_code)
                End If
                If e.UpdatingArgs.Row!doc_status = 1 Then
                    btnActualizar.Enabled = True
                End If
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim oPost As New SGT.Inventario.Operaciones.PostInventory
        Try
            If MessageBox.Show("Seguro desea aplicar estos vencimientos?", "Aplicar Vencimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If

            oPost.AplicarVencimiento(LibXConnector1.CurrentDataRow!doc_serial, True, "VEN")

            xUpdate = New LibX.Data.XUpdateStmt("ivvcmtom")
            xUpdate.FieldsSet("doc_status") = 2 '// Aplicado
            xUpdate.Fields("doc_serial") = LibXConnector1.CurrentDataRow!doc_serial
            xUpdate.Execute()

            LibXConnector1.CurrentDataRow!doc_status = 2
            Me.xcbo_doc_status.currValue = 2

            '// Agregar y Editar
            Me.LibXConnector1.AllowEdit = False
            Me.LibXConnector1.AllowDelete = False
            Me.LibXNavigator1.UpdateState()
            Me.btnActualizar.Enabled = False

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            e.AditionalWhere = "type_code = 'VEN'"
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try

            If Not e.row Is Nothing Then
                If e.row!doc_status.ToString.Trim = "1" Then '// Pendiente
                    Me.btnActualizar.Enabled = True
                    Me.LibXConnector1.AllowDelete = True
                    Me.LibXConnector1.AllowEdit = True
                Else
                    Me.btnActualizar.Enabled = False
                    Me.LibXConnector1.AllowDelete = False
                    Me.LibXConnector1.AllowEdit = False
                End If
                LibXNavigator1.UpdateState()
            Else
                Me.btnActualizar.Enabled = False
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub xlk_item_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_item_code.AfterSetValues
        Dim oUnidad As SGT.Inventario.Entidades.UnidadMedida
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.IsDataEditing = True Then
                Me.lblexistencia.Text = Format(Val(e.row!existencia.ToString.Trim), "###,##0")
                '// Asignar la unidad minima de venta
                oUnidad = New SGT.Inventario.Entidades.UnidadMedida
                LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, xdt_unit_code, oUnidad.GetUnidadMinimaVenta(e.row!item_code))
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub xlk_item_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_item_code.BeforeExecuteQuery
        e.aditionalWhere = "ivitemv1.whse_code = " & txtwhse_code.Text.ToString

        '''If LibXGrid1.GetValue(LibXGrid1.currentRowNum, xdt_item_code).Trim = "" Then
        '''    e.handled = True
        '''    Exit Sub
        '''End If

        '''If Len(LibXGrid1.GetValue(xdt_item_code).Trim) >= 8 And IsNumeric(LibXGrid1.GetValue(LibXGrid1.currentRowNum, xdt_item_code).Trim) Then
        '''    e.SQL = e.SQL.Replace("ivitemv1.item_code =", "ivcbarram.barra =")
        '''End If
    End Sub
End Class
