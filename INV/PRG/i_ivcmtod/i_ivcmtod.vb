Public Class i_ivcmtod
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
    Friend WithEvents xdt_comprada As LibX.XEditTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lk_whse_code As LibX.LibXLookup
    Friend WithEvents txtwhse_code As LibX.XTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents whse_name As LibX.XTextBox
    Friend WithEvents xtxttype_name As LibX.XTextBox
    Friend WithEvents XTextBox5 As LibX.XTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents xdt_qty1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xdt_mes_vence1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xdt_año_vence1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xdb_ivvcmtom As LibX.LibXDbSourceTable
    Friend WithEvents xdb_ivvcmtod As LibX.LibXDbSourceTable
    Friend WithEvents xlk_type_code As LibX.LibXLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents xdt_prov_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents xlk_prov_code As LibX.LibXLookup
    Friend WithEvents xdt_item_code As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataTable2 = New System.Data.DataTable
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
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.xdt_item_code = New LibX.XEditTextBoxColumn
        Me.xdt_item_name = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_comprada = New LibX.XEditTextBoxColumn
        Me.xdt_qty = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_mes_vence = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_año_vence = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_qty1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_mes_vence1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_año_vence1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_prov_code = New LibX.XDataGridTextButtonColumn
        Me.xlk_prov_code = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.xdb_ivvcmtom = New LibX.LibXDbSourceTable
        Me.xdb_ivvcmtod = New LibX.LibXDbSourceTable
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.XTextBox1 = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.Label2 = New System.Windows.Forms.Label
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.xtxttype_name = New LibX.XTextBox
        Me.xlk_type_code = New LibX.LibXLookup
        Me.XTextBox5 = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lk_whse_code = New LibX.LibXLookup
        Me.txtwhse_code = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.whse_name = New LibX.XTextBox
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.DataMember = "ivvcmtdv"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(0, 144)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(1096, 344)
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
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.DataTable1.TableName = "ivvcmtov"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "doc_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "type_code"
        Me.DataColumn2.MaxLength = 3
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "whse_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "doc_number"
        Me.DataColumn4.MaxLength = 20
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "doc_date"
        Me.DataColumn5.DataType = GetType(System.DateTime)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "doc_status"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "prov_code"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24})
        Me.DataTable2.TableName = "ivvcmtdv"
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "doc_serial"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "type_code"
        Me.DataColumn9.MaxLength = 3
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "line_no"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "item_code"
        Me.DataColumn11.MaxLength = 10
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "item_name"
        Me.DataColumn12.MaxLength = 100
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "unit_code"
        Me.DataColumn13.MaxLength = 5
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "qty_onhand"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "purch_cost"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "qty"
        Me.DataColumn16.DataType = GetType(System.Int32)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "vcmto_month"
        Me.DataColumn17.MaxLength = 2
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "vcmto_year"
        Me.DataColumn18.MaxLength = 4
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "qty1"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "vcmto_month1"
        Me.DataColumn20.MaxLength = 2
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "vcmto_year1"
        Me.DataColumn21.MaxLength = 4
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "prov_code"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "prov_name"
        Me.DataColumn23.MaxLength = 60
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "whse_code"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.xdt_item_code, Me.xdt_item_name, Me.xdt_comprada, Me.xdt_qty, Me.xdt_mes_vence, Me.xdt_año_vence, Me.xdt_qty1, Me.xdt_mes_vence1, Me.xdt_año_vence1, Me.xdt_prov_code, Me.XEditTextBoxColumn1})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivvcmtdv"
        '
        'xdt_item_code
        '
        Me.xdt_item_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_item_code.Format = ""
        Me.xdt_item_code.FormatInfo = Nothing
        Me.xdt_item_code.HeaderText = "Producto"
        Me.xdt_item_code.ImageList = Nothing
        Me.xdt_item_code.isReadOnly = True
        Me.xdt_item_code.MappingName = "item_code"
        Me.xdt_item_code.MaxLength = 32767
        Me.xdt_item_code.ReadOnly = True
        Me.xdt_item_code.TabStop = True
        Me.xdt_item_code.UseCustomCellFormat = False
        Me.xdt_item_code.Width = 101
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
        'xdt_comprada
        '
        Me.xdt_comprada.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_comprada.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_comprada.Format = ""
        Me.xdt_comprada.FormatInfo = Nothing
        Me.xdt_comprada.HeaderText = "Compradai"
        Me.xdt_comprada.ImageList = Nothing
        Me.xdt_comprada.isReadOnly = True
        Me.xdt_comprada.MappingName = "qty_onhand"
        Me.xdt_comprada.MaxLength = 32767
        Me.xdt_comprada.ReadOnly = True
        Me.xdt_comprada.TabStop = True
        Me.xdt_comprada.UseCustomCellFormat = False
        Me.xdt_comprada.Width = 75
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
        'xdt_prov_code
        '
        Me.xdt_prov_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.xdt_prov_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_prov_code.executeFindDuringFill = False
        Me.xdt_prov_code.Format = ""
        Me.xdt_prov_code.FormatInfo = Nothing
        Me.xdt_prov_code.HeaderText = "Suplidor"
        Me.xdt_prov_code.isReadOnly = False
        Me.xdt_prov_code.Lookup = Me.xlk_prov_code
        Me.xdt_prov_code.MappingName = "prov_code"
        Me.xdt_prov_code.MaxLength = 32767
        Me.xdt_prov_code.TabStop = True
        Me.xdt_prov_code.UseCustomCellFormat = False
        Me.xdt_prov_code.Width = 60
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
        Me.xlk_prov_code.Location = New System.Drawing.Point(576, 312)
        Me.xlk_prov_code.LookCaption = "Suplidores"
        Me.xlk_prov_code.Name = "xlk_prov_code"
        Me.xlk_prov_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_prov_code.ShowFilter = True
        Me.xlk_prov_code.ShowMessageNotFound = True
        Me.xlk_prov_code.ShowWarning = False
        Me.xlk_prov_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_prov_code.SizesColumns = Nothing
        Me.xlk_prov_code.SizesColumnsTab = Nothing
        Me.xlk_prov_code.SqlString = New String() {Nothing}
        Me.xlk_prov_code.SQLTab = Nothing
        Me.xlk_prov_code.SrcParameters = New String() {"prov_code=prov_code"}
        Me.xlk_prov_code.TabIndex = 19
        Me.xlk_prov_code.TableName = "cpprovm"
        Me.xlk_prov_code.TabStop = False
        Me.xlk_prov_code.UseCopyConnection = False
        Me.xlk_prov_code.UseRowRetrieveEvents = False
        Me.xlk_prov_code.UseTab = False
        Me.xlk_prov_code.VisParameters = New String() {"Código=prov_code", "Suplidor=prov_name"}
        Me.xlk_prov_code.WhereCondition = Nothing
        Me.xlk_prov_code.WhereParameters = Nothing
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = True
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = False
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "ivvcmtov"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = True
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.xdb_ivvcmtom, Me.xdb_ivvcmtod})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = True
        Me.LibXConnector1.UseTransactions = False
        '
        'xdb_ivvcmtom
        '
        Me.xdb_ivvcmtom.AllowDelete = True
        Me.xdb_ivvcmtom.AllowEdit = True
        Me.xdb_ivvcmtom.AllowNew = True
        Me.xdb_ivvcmtom.AutoIncrementSerial = False
        Me.xdb_ivvcmtom.CustomDbUpdate = True
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
        Me.xdb_ivvcmtom.SerialColumnName = ""
        Me.xdb_ivvcmtom.Sort = ""
        Me.xdb_ivvcmtom.Source = Nothing
        Me.xdb_ivvcmtom.TableName = "ivvcmtov"
        Me.xdb_ivvcmtom.UpdateOrder = 0
        Me.xdb_ivvcmtom.UseRowRetrieve = False
        '
        'xdb_ivvcmtod
        '
        Me.xdb_ivvcmtod.AllowDelete = True
        Me.xdb_ivvcmtod.AllowEdit = True
        Me.xdb_ivvcmtod.AllowNew = True
        Me.xdb_ivvcmtod.AutoIncrementSerial = False
        Me.xdb_ivvcmtod.CustomDbUpdate = True
        Me.xdb_ivvcmtod.DeleteOrder = 0
        Me.xdb_ivvcmtod.FillOnQuery = True
        Me.xdb_ivvcmtod.FillOnRowChange = True
        Me.xdb_ivvcmtod.HeaderIsOnGrid = False
        Me.xdb_ivvcmtod.InnerJon = True
        Me.xdb_ivvcmtod.InsertOrder = 0
        Me.xdb_ivvcmtod.IsDetail = True
        Me.xdb_ivvcmtod.KeyFields = Nothing
        Me.xdb_ivvcmtod.LineColName = Nothing
        Me.xdb_ivvcmtod.MasterDetailRelation = New String() {"type_code=type_code", "doc_serial=doc_serial", "whse_code=whse_code"}
        Me.xdb_ivvcmtod.MasterTableName = Nothing
        Me.xdb_ivvcmtod.SerialColumnName = Nothing
        Me.xdb_ivvcmtod.Sort = ""
        Me.xdb_ivvcmtod.Source = Nothing
        Me.xdb_ivvcmtod.TableName = "ivvcmtdv"
        Me.xdb_ivvcmtod.UpdateOrder = 0
        Me.xdb_ivvcmtod.UseRowRetrieve = False
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Nombre"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = True
        Me.XEditTextBoxColumn1.MappingName = "prov_name"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.ReadOnly = True
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 75
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
        Me.LibXNavigator1.FirstControlInFindMode = Nothing
        Me.LibXNavigator1.FirstControlInNewMode = Nothing
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(1030, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xtxttype_name)
        Me.GroupBox1.Controls.Add(Me.xlk_type_code)
        Me.GroupBox1.Controls.Add(Me.XTextBox5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lk_whse_code)
        Me.GroupBox1.Controls.Add(Me.txtwhse_code)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.whse_name)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1096, 104)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivvcmtov.doc_number"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(128, 48)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(96, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 1
        Me.XTextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(66, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Numero:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ivvcmtov.doc_status"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Items.AddRange(New Object() {"2-Pendiente Aplicar", "1-Aplicado"})
        Me.LibXCombo1.Location = New System.Drawing.Point(728, 48)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = Nothing
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(121, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(674, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Estatus:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ivvcmtov.doc_date"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxDateTimePicker1.FieldDescription = ""
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = False
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(728, 24)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = Nothing
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxDateTimePicker1.Requiered = False
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(120, 20)
        Me.LibxDateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(680, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Fecha:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxttype_name
        '
        Me.xtxttype_name.AcceptsReturn = True
        Me.xtxttype_name.EditInitialValue = Nothing
        Me.xtxttype_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxttype_name.FieldDescription = ""
        Me.xtxttype_name.FindInitialValue = Nothing
        Me.xtxttype_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxttype_name.IgnoreRequiered = False
        Me.xtxttype_name.Location = New System.Drawing.Point(232, 24)
        Me.xtxttype_name.Name = "xtxttype_name"
        Me.xtxttype_name.NewInitialValue = Nothing
        Me.xtxttype_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxttype_name.ReadOnly = True
        Me.xtxttype_name.Requiered = False
        Me.xtxttype_name.Size = New System.Drawing.Size(360, 20)
        Me.xtxttype_name.StatusBarPanelDescripcion = Nothing
        Me.xtxttype_name.TabIndex = 28
        Me.xtxttype_name.TabStop = False
        Me.xtxttype_name.Text = ""
        '
        'xlk_type_code
        '
        Me.xlk_type_code.AlternateFieldSearch = Nothing
        Me.xlk_type_code.BeginCheck = False
        Me.xlk_type_code.CheckText = Nothing
        Me.xlk_type_code.ComboMode = False
        Me.xlk_type_code.DataMember = Nothing
        Me.xlk_type_code.DataSource = Me.LibXConnector1
        Me.xlk_type_code.DestParameters = New String() {"type_code=type_code", "xtxttype_name=type_name"}
        Me.xlk_type_code.FilterField = Nothing
        Me.xlk_type_code.IgnoreFindInBrowseMode = False
        Me.xlk_type_code.isCanceled = False
        Me.xlk_type_code.Location = New System.Drawing.Point(592, 24)
        Me.xlk_type_code.LookCaption = "Suplidores"
        Me.xlk_type_code.Name = "xlk_type_code"
        Me.xlk_type_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_type_code.ShowFilter = True
        Me.xlk_type_code.ShowMessageNotFound = True
        Me.xlk_type_code.ShowWarning = False
        Me.xlk_type_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_type_code.SizesColumns = Nothing
        Me.xlk_type_code.SizesColumnsTab = Nothing
        Me.xlk_type_code.SqlString = Nothing
        Me.xlk_type_code.SQLTab = Nothing
        Me.xlk_type_code.SrcParameters = New String() {"type_code=type_code"}
        Me.xlk_type_code.TabIndex = 29
        Me.xlk_type_code.TableName = "ivtypem"
        Me.xlk_type_code.TabStop = False
        Me.xlk_type_code.UseCopyConnection = False
        Me.xlk_type_code.UseRowRetrieveEvents = False
        Me.xlk_type_code.UseTab = False
        Me.xlk_type_code.VisParameters = New String() {"Código=type_code", "Nombre=type_name"}
        Me.xlk_type_code.WhereCondition = Nothing
        Me.xlk_type_code.WhereParameters = Nothing
        '
        'XTextBox5
        '
        Me.XTextBox5.AcceptsReturn = True
        Me.XTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivvcmtov.type_code"))
        Me.XTextBox5.EditInitialValue = Nothing
        Me.XTextBox5.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox5.FieldDescription = ""
        Me.XTextBox5.FindInitialValue = Nothing
        Me.XTextBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.IgnoreRequiered = False
        Me.XTextBox5.Location = New System.Drawing.Point(128, 24)
        Me.XTextBox5.Name = "XTextBox5"
        Me.XTextBox5.NewInitialValue = Nothing
        Me.XTextBox5.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox5.Requiered = False
        Me.XTextBox5.Size = New System.Drawing.Size(96, 20)
        Me.XTextBox5.StatusBarPanelDescripcion = Nothing
        Me.XTextBox5.TabIndex = 0
        Me.XTextBox5.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(24, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Tipo Documento:"
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
        Me.lk_whse_code.Location = New System.Drawing.Point(592, 72)
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
        Me.txtwhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivvcmtov.whse_code"))
        Me.txtwhse_code.EditInitialValue = Nothing
        Me.txtwhse_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtwhse_code.FieldDescription = ""
        Me.txtwhse_code.FindInitialValue = Nothing
        Me.txtwhse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.IgnoreRequiered = False
        Me.txtwhse_code.Location = New System.Drawing.Point(128, 72)
        Me.txtwhse_code.Name = "txtwhse_code"
        Me.txtwhse_code.NewInitialValue = Nothing
        Me.txtwhse_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtwhse_code.Requiered = False
        Me.txtwhse_code.Size = New System.Drawing.Size(96, 20)
        Me.txtwhse_code.StatusBarPanelDescripcion = Nothing
        Me.txtwhse_code.TabIndex = 2
        Me.txtwhse_code.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(63, 72)
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
        Me.whse_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.FieldDescription = ""
        Me.whse_name.FindInitialValue = Nothing
        Me.whse_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.IgnoreRequiered = False
        Me.whse_name.Location = New System.Drawing.Point(232, 72)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.NewInitialValue = Nothing
        Me.whse_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.ReadOnly = True
        Me.whse_name.Requiered = False
        Me.whse_name.Size = New System.Drawing.Size(360, 20)
        Me.whse_name.StatusBarPanelDescripcion = Nothing
        Me.whse_name.TabIndex = 22
        Me.whse_name.TabStop = False
        Me.whse_name.Text = ""
        '
        'i_ivcmtod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1030, 552)
        Me.Controls.Add(Me.xlk_prov_code)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.LibXGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivcmtod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Captura de Vencimientos"
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
        Try
            If e.cell = LibXGrid1.GetColNum(xdt_qty) Then
                If Val(e.value.Trim) = 0 Then
                    Exit Sub
                End If

                If Math.Abs(Val(LibXGrid1.GetValue(e.row, xdt_comprada))) < Math.Abs(Val(e.value.Trim)) Then
                    'If LibXGrid1.GetValue(e.row, Me.xdt_item_code).ToString.Trim = "" Then
                    LibXGrid1.SetValue(e.row, xdt_qty, Val(LibXGrid1.GetValue(e.row, xdt_comprada)))
                    e.value = LibXGrid1.GetValue(e.row, xdt_comprada)
                End If

                If Math.Abs(Val(LibXGrid1.GetValue(e.row, xdt_comprada))) <> (Math.Abs(Val(LibXGrid1.GetValue(e.row, xdt_qty))) + Math.Abs(Val(LibXGrid1.GetValue(e.row, xdt_qty1)))) Then
                    If Math.Abs(Val(LibXGrid1.GetValue(e.row, xdt_qty))) > 0 Then
                        LibXGrid1.SetValue(e.row, xdt_qty1, Math.Abs(Val(LibXGrid1.GetValue(xdt_comprada))) - Math.Abs(Val(LibXGrid1.GetValue(e.row, xdt_qty))))
                    End If
                End If
            End If

            ''If e.cell = LibXGrid1.GetColNum(xdt_mes_vence) Then
            ''    If Val(e.value.Trim) = 0 Then
            ''        e.hasErrors = True
            ''        Exit Sub
            ''    End If
            ''End If

            If e.cell = LibXGrid1.GetColNum(xdt_año_vence) Then
                If Val(e.value.Trim) = 0 Then
                    LibXGrid1.Focus(e.row, 9)
                    Exit Sub
                End If

                If Val(LibXGrid1.GetValue(e.row, xdt_qty)) = Val(LibXGrid1.GetValue(e.row, xdt_comprada)) Then
                    LibXGrid1.Focus(e.row, 9)
                    Exit Sub
                End If
                If Val(LibXGrid1.GetValue(xdt_qty1)) <= 0 Then
                    LibXGrid1.SetValue(e.row, xdt_qty, Math.Abs(Val(LibXGrid1.GetValue(e.row, xdt_comprada))))
                End If
            End If

            If e.cell = LibXGrid1.GetColNum(xdt_qty1) Then
                If Val(e.value.ToString.Trim) = 0 Then
                    LibXGrid1.Focus(e.row, 9)
                    Exit Sub
                End If
                If Val(LibXGrid1.GetValue(xdt_qty1)) <= 0 Then
                    LibXGrid1.SetValue(e.row, xdt_qty, Math.Abs(Val(LibXGrid1.GetValue(e.row, xdt_comprada))))
                End If
            End If

            If e.cell = LibXGrid1.GetColNum(xdt_año_vence1) Then
                If Val(LibXGrid1.GetValue(e.row, xdt_qty1)) > 0 AndAlso Val(e.value.Trim) = 0 Then
                    e.hasErrors = True
                    Exit Sub
                End If
            End If

            If e.cell = LibXGrid1.GetColNum(xdt_mes_vence1) Then
                If Val(LibXGrid1.GetValue(e.row, xdt_qty1)) > 0 AndAlso Val(e.value.Trim) = 0 Then
                    e.hasErrors = True
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            e.hasErrors = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Dim oTable As DataTable
        Dim oTable1 As DataTable
        Dim WhereStmt As String
        Dim SelectStmt As String

        Try
            If e.Action = LibX.LibxConnectionActions.Cancel Then
                Exit Sub
            End If

            If e.Action = LibX.LibxConnectionActions.Delete Then
                Dim XDelete As New LibX.Data.XDeleteStmt("ivvcmtod")

                e.Handled = True

                If MessageBox.Show("Desea borrar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then
                    Exit Sub
                End If

                '// INICIAR TRANSACCION
                ''If LibX.Data.Manager.Connection.IsIntransaction = False Then
                ''    LibX.Data.Manager.Connection.BeginTransaction()
                ''End If

                XDelete.Parameters.Add("type_code", LibXConnector1.CurrentDataRow!type_code.ToString.Trim)
                XDelete.Parameters.Add("doc_serial", LibXConnector1.CurrentDataRow!doc_serial.ToString.Trim)
                XDelete.Execute()

                '// TERMINAR TRANSACCION
                ''If LibX.Data.Manager.Connection.IsIntransaction = True Then
                ''    LibX.Data.Manager.Connection.CommitTransaction()
                ''End If

                WhereStmt = "doc_serial = " & LibXConnector1.CurrentDataRow!doc_serial.ToString.Trim & _
                             " and type_code = '" & LibXConnector1.CurrentDataRow!type_code.ToString.Trim & "'"

                LibXConnector1.ExecuteFind(WhereStmt)

                Exit Sub
            End If

            Select Case e.AcceptedAction
                Case LibX.LibxConnectionActions.Edit, LibX.LibxConnectionActions.Add

                    'e.Handled = True
                    SelectStmt = "select * from ivvcmtod where doc_serial = " & LibXConnector1.CurrentDataRow!doc_serial.ToString.Trim & _
                                 " and type_code = '" & LibXConnector1.CurrentDataRow!type_code.ToString.Trim & "'"

                    WhereStmt = "doc_serial = " & LibXConnector1.CurrentDataRow!doc_serial.ToString.Trim & _
                                 " and type_code = '" & LibXConnector1.CurrentDataRow!type_code.ToString.Trim & "'"
                    '" and line_no = {0}"

                    oTable = LibX.Data.Manager.GetDataTable(SelectStmt, "ivvcmtod", True)


                    Dim oNewRow As DataRow
                    Dim SelSelectmt As String

                    For Each oRow As DataRow In DataSet1.Tables("ivvcmtdv").Rows
                        Dim XUpdate As New LibX.Data.XUpdateStmt("ivvcmtod")
                        Dim oRov As DataRow()
                        'Dim oNewRow As DataRow = oTable.NewRow()
                        '// Vencimiento 1
                        If Math.Abs(Val(oRow!qty.ToString.Trim)) <= 0 Then
                            Throw New ApplicationException("cantidad a vencer debe ser 0!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
                        End If
                        If IsDBNull(oRow!prov_code) Then
                            Throw New ApplicationException("Especifique el suplidor del producto " & oRow!item_name.ToString.Trim)
                        End If

                        If Math.Abs(Val(oRow!qty.ToString.Trim)) > Math.Abs(Val(oRow!qty_onhand.ToString.Trim)) Then
                            Throw New ApplicationException("cantidad a vencer inválida no puede ser mayor q la cantidad comprada!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
                        End If

                        If Val(oRow!vcmto_month.ToString.Trim) <= 0 Then
                            Throw New ApplicationException("Debe especificar el mes de vencimiento!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
                        End If

                        If Val(oRow!vcmto_month.ToString.Trim) > 12 Then
                            Throw New ApplicationException("El mes a vencer debe estar entre 1 y 12!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
                        End If

                        If Val(oRow!vcmto_year.ToString.Trim) <= 0 Then
                            Throw New ApplicationException("Debe especificar el Año de vencimiento!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
                        End If

                        If Val(oRow!vcmto_year.ToString.Trim) < DateTime.Now.Year Then
                            Throw New ApplicationException("El Ano a vencer no debe ser menor que el año actual!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
                        End If

                        If DateSerial(oRow!vcmto_year.ToString.Trim, oRow!vcmto_month.ToString.Trim, 1) <= DateSerial(DateTime.Now.Year, DateTime.Now.Month, 1) Then
                            If LibXConnector1.CurrentDataRow!type_code.ToString.Trim <> "DVI" Then
                                Throw New ApplicationException("La fecha de vencimiento especificada ya se cumplio!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
                            End If
                        End If

                        '// Vencimiento 1
                        If Math.Abs(Val(oRow!qty1.ToString.Trim)) > 0 Then
                            If Math.Abs(Val(oRow!qty1.ToString.Trim)) > Math.Abs(Val(oRow!qty_onhand.ToString.Trim)) Then
                                Throw New ApplicationException("cantidad a vencer inválida no puede ser mayor q la cantidad comprada!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
                            End If

                            If Val(oRow!vcmto_month1.ToString.Trim) <= 0 Then
                                Throw New ApplicationException("Debe especificar el mes de vencimiento!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
                            End If

                            If Val(oRow!vcmto_month1.ToString.Trim) > 12 Then
                                Throw New ApplicationException("El mes a vencer debe estar entre 1 y 12!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
                            End If

                            If Val(oRow!vcmto_year1.ToString.Trim) <= 0 Then
                                Throw New ApplicationException("Debe especificar el Año de vencimiento!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
                            End If

                            If Val(oRow!vcmto_year1.ToString.Trim) < DateTime.Now.Year Then
                                Throw New ApplicationException("El Ano a vencer no debe ser menor que el año actual!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
                            End If

                            If DateSerial(oRow!vcmto_year1.ToString.Trim, oRow!vcmto_month1.ToString.Trim, 1) <= DateSerial(DateTime.Now.Year, DateTime.Now.Month, 1) Then
                                Throw New ApplicationException("La fecha de vencimiento especificada ya se cumplio!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
                            End If
                        End If

                        If Math.Abs(Val(oRow!qty.ToString.Trim)) + Math.Abs(Val(oRow!qty1.ToString.Trim)) <> Math.Abs(Val(oRow!qty_onhand.ToString.Trim)) Then
                            Throw New ApplicationException("Suma de las cantidades a vencer es diferente a la cantidad comprada!" & vbCrLf & "Producto: " & oRow!item_name.ToString.Trim)
                        End If

                        '// Si existe, modificarlo
                        'If IsDBNull(oRow!line_no) = False Then
                        '    oNewRow = oTable.Select(String.Format(WhereStmt, oRow!Line_no))(0)
                        '    oNewRow.BeginEdit()
                        'End If

                        SelSelectmt = " delete from ivvcmtod where item_code not in(select item_code from iventrdd where " & _
                                    " doc_serial = " & LibXConnector1.CurrentDataRow!doc_serial & ")" & _
                                      " and type_code = '" & LibXConnector1.CurrentDataRow!type_code.ToString.Trim & "'" & _
                                      " and doc_serial = " & LibXConnector1.CurrentDataRow!doc_serial

                        LibX.Data.Manager.ExecuteNonQuery(SelSelectmt)

                        '// si es nuevo modificarlo                        
                            SelectStmt = "select * from ivvcmtod where doc_serial = " & LibXConnector1.CurrentDataRow!doc_serial.ToString.Trim & _
                                     " and type_code = '" & LibXConnector1.CurrentDataRow!type_code.ToString.Trim & "'"
                            oTable1 = LibX.Data.Manager.GetDataTable(SelectStmt, "ivvcmtod", True)

                        'If IsDBNull(oRow1!line_no) = True Then
                        oRov = oTable1.Select("item_code = '" & oRow!item_code & "'  and line_no = " & oRow!line_no & "")

                        'If oTable1.Rows.Count <= 0 Then
                        If oRov.Length <= 0 Then
                            oNewRow = oTable.NewRow
                            oNewRow!line_no = oRow!line_no 'oTable.Compute("count(line_no)", "1=1") + 1
                            oNewRow!doc_serial = oRow!doc_serial
                            oNewRow!type_code = oRow!type_code
                            oNewRow!item_code = oRow!item_code
                            oNewRow!prov_code = oRow!prov_code
                            oNewRow!whse_code = oRow!whse_code
                            oTable.Rows.Add(oNewRow)
                        End If

                        'If oTable1.Rows.Count > 0 And oRow.RowState <> DataRowState.Unchanged Then
                        If oRov.Length > 0 And oRow.RowState <> DataRowState.Unchanged Then
                            XUpdate.FieldsSet("qty") = oRow!qty
                            XUpdate.FieldsSet("vcmto_month") = oRow!vcmto_month
                            XUpdate.FieldsSet("vcmto_year") = oRow!vcmto_year
                            XUpdate.FieldsSet("qty1") = oRow!qty1
                            XUpdate.FieldsSet("vcmto_month1") = oRow!vcmto_month1
                            XUpdate.FieldsSet("vcmto_year1") = oRow!vcmto_year1
                            XUpdate.FieldsSet("prov_code") = oRow!prov_code
                            XUpdate.Fields("doc_serial") = oRow!doc_serial
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
                            oNewRow!purch_cost = oRow!purch_cost
                            oNewRow!qty_onhand = oRow!qty_onhand
                            oNewRow!qty = oRow!qty
                            oNewRow!vcmto_month = oRow!vcmto_month
                            oNewRow!vcmto_year = oRow!vcmto_year
                            oNewRow!qty1 = oRow!qty1
                            oNewRow!vcmto_month1 = oRow!vcmto_month1
                            oNewRow!vcmto_year1 = oRow!vcmto_year1
                            oNewRow!prov_code = oRow!prov_code
                            oNewRow!whse_code = oRow!whse_code
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
            e.Handled = True
            LibX.Log.Add(ex)
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
        End Try
    End Sub

    Private Sub i_ivcmtod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LibXGrid1.getCurrentGridView.AllowNew = False

    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibX.LibxConnectionActions.Edit And e.AcceptedAction <> LibX.LibxConnectionActions.Cancel Then
                Me.LibXGrid1.Focus(0, 3)
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_RowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange
        Try
            If LibXConnector1.HasRecords = True Then
                If Not e.row Is Nothing Then
                    If (LibX.IsNull(e.row!doc_status) = False AndAlso e.row!doc_status = 1) Or (e.row!type_code = "FPV") Then '// Aplicado 
                        LibXConnector1.AllowDelete = False
                        LibXConnector1.AllowEdit = False
                    Else
                        LibXConnector1.AllowDelete = True
                        LibXConnector1.AllowEdit = True
                    End If
                    LibXNavigator1.UpdateState()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeLoadDetail(ByVal sender As Object, ByVal e As LibX.XbeforeLoadDetailEventArgs) Handles LibXConnector1.BeforeLoadDetail
        e.Sql = e.Sql & " order by doc_serial,line_no"
    End Sub
End Class
