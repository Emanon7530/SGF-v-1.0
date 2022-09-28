Imports SGT.Inventario
Imports SGT.Inventario.Entidades

Public Class i_ivvcmto02
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
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents xdtp_entr_date As LibX.LibxDateTimePicker
    Friend WithEvents lk_prov_code As LibX.LibXLookup
    Friend WithEvents lk_whse_code As LibX.LibXLookup
    Friend WithEvents txtwhse_code As LibX.XTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEntr_Number As LibX.XTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents whse_name As LibX.XTextBox
    Friend WithEvents TextBox8 As LibX.XTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents prov_name As LibX.XTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents xlk_item_code As LibX.LibXLookup
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents xdt_item_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents xdt_item_name As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_qty As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_mes As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_Ano As LibX.XEditTextBoxColumn
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents xdt_unit_code As LibX.XDataGridComboBoxColumn
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents xdt_entr_status As LibX.LibXCombo
    Friend WithEvents xdb_iventrdm As LibX.LibXDbSourceTable
    Friend WithEvents xdb_ivvcmtom As LibX.LibXDbSourceTable
    Friend WithEvents xdt_Mes1 As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_ano1 As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_qty1 As LibX.XEditTextBoxColumn
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
    Friend WithEvents ivvcmtom As System.Data.DataTable
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
        Me.ivvcmtom = New System.Data.DataTable
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.xdt_item_code = New LibX.XDataGridTextButtonColumn
        Me.xlk_item_code = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.xdb_iventrdm = New LibX.LibXDbSourceTable
        Me.xdb_ivvcmtom = New LibX.LibXDbSourceTable
        Me.xdt_item_name = New LibX.XEditTextBoxColumn
        Me.xdt_unit_code = New LibX.XDataGridComboBoxColumn
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.xdt_qty = New LibX.XEditTextBoxColumn
        Me.xdt_mes = New LibX.XEditTextBoxColumn
        Me.xdt_Ano = New LibX.XEditTextBoxColumn
        Me.xdt_qty1 = New LibX.XEditTextBoxColumn
        Me.xdt_Mes1 = New LibX.XEditTextBoxColumn
        Me.xdt_ano1 = New LibX.XEditTextBoxColumn
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xdt_entr_status = New LibX.LibXCombo
        Me.xdtp_entr_date = New LibX.LibxDateTimePicker
        Me.lk_prov_code = New LibX.LibXLookup
        Me.lk_whse_code = New LibX.LibXLookup
        Me.txtwhse_code = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtEntr_Number = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.whse_name = New LibX.XTextBox
        Me.TextBox8 = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.prov_name = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivvcmtom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.DataMember = ""
        Me.LibXGrid1.DataSource = Me.ivvcmtom
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(0, 168)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(792, 256)
        Me.LibXGrid1.TabIndex = 0
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.ivvcmtom})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"entr_serial"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn2}
        Me.DataTable1.TableName = "iventrdm"
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
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "entr_ncf"
        Me.DataColumn23.MaxLength = 19
        '
        'ivvcmtom
        '
        Me.ivvcmtom.TableName = "ivvcmtom"
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.xdt_item_code, Me.xdt_item_name, Me.xdt_unit_code, Me.xdt_qty, Me.xdt_mes, Me.xdt_Ano, Me.xdt_qty1, Me.xdt_Mes1, Me.xdt_ano1})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivvcmtom"
        '
        'xdt_item_code
        '
        Me.xdt_item_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.xdt_item_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_item_code.executeFindDuringFill = False
        Me.xdt_item_code.Format = ""
        Me.xdt_item_code.FormatInfo = Nothing
        Me.xdt_item_code.HeaderText = "Producto"
        Me.xdt_item_code.isReadOnly = True
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
        Me.xlk_item_code.CheckText = Nothing
        Me.xlk_item_code.ComboMode = False
        Me.xlk_item_code.DataMember = Nothing
        Me.xlk_item_code.DataSource = Me.LibXConnector1
        Me.xlk_item_code.DestParameters = New String() {"item_code=item_code", "whse_code=whse_code", "item_name=item_name", "qty=qty", "unit_code=unit_code", "purch_cost=purch_unit_cost", ""}
        Me.xlk_item_code.FilterField = "item_name"
        Me.xlk_item_code.IgnoreFindInBrowseMode = False
        Me.xlk_item_code.isCanceled = False
        Me.xlk_item_code.Location = New System.Drawing.Point(616, 256)
        Me.xlk_item_code.LookCaption = "Productos "
        Me.xlk_item_code.Name = "xlk_item_code"
        Me.xlk_item_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_item_code.ShowFilter = True
        Me.xlk_item_code.ShowMessageNotFound = True
        Me.xlk_item_code.ShowWarning = False
        Me.xlk_item_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_item_code.SizesColumns = New String() {"item_code=150", "item_name=300", "unit_code=150"}
        Me.xlk_item_code.SizesColumnsTab = Nothing
        Me.xlk_item_code.SqlString = New String() {"select entr_serial,whse_code,iventrdd.item_code,", "iventrdd.unit_code,qty,qty_oferta,item_name,", "unit_name,purch_unit_cost", "from iventrdd", "inner join ivitemm", "on iventrdd.item_code = ivitemm.item_code", "and ivitemm.aplicar_vcmto = 1", "", "inner join ivunitm", "on iventrdd.unit_code = ivunitm.unit_code"}
        Me.xlk_item_code.SQLTab = Nothing
        Me.xlk_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.xlk_item_code.TabIndex = 4
        Me.xlk_item_code.TableName = "ivitemv"
        Me.xlk_item_code.TabStop = False
        Me.xlk_item_code.UseCopyConnection = False
        Me.xlk_item_code.UseRowRetrieveEvents = False
        Me.xlk_item_code.UseTab = False
        Me.xlk_item_code.VisParameters = New String() {"Producto=item_code", "Descripción=item_name", "Cantiad=qty", "Unidad=unit_name", "Oferta=qty_oferta"}
        Me.xlk_item_code.WhereCondition = "item_status =1 and existencia > 0"
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
        Me.LibXConnector1.DataMember = "iventrdm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.xdb_iventrdm, Me.xdb_ivvcmtom})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = True
        Me.LibXConnector1.UseTransactions = True
        '
        'xdb_iventrdm
        '
        Me.xdb_iventrdm.AllowDelete = True
        Me.xdb_iventrdm.AllowEdit = True
        Me.xdb_iventrdm.AllowNew = True
        Me.xdb_iventrdm.AutoIncrementSerial = False
        Me.xdb_iventrdm.CustomDbUpdate = True
        Me.xdb_iventrdm.DeleteOrder = 0
        Me.xdb_iventrdm.FillOnQuery = True
        Me.xdb_iventrdm.FillOnRowChange = False
        Me.xdb_iventrdm.HeaderIsOnGrid = False
        Me.xdb_iventrdm.InnerJon = True
        Me.xdb_iventrdm.InsertOrder = 0
        Me.xdb_iventrdm.IsDetail = False
        Me.xdb_iventrdm.KeyFields = Nothing
        Me.xdb_iventrdm.LineColName = Nothing
        Me.xdb_iventrdm.MasterDetailRelation = Nothing
        Me.xdb_iventrdm.MasterTableName = Nothing
        Me.xdb_iventrdm.SerialColumnName = "entr_serial"
        Me.xdb_iventrdm.Sort = Nothing
        Me.xdb_iventrdm.Source = Nothing
        Me.xdb_iventrdm.TableName = "iventrdm"
        Me.xdb_iventrdm.UpdateOrder = 0
        Me.xdb_iventrdm.UseRowRetrieve = False
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
        Me.xdb_ivvcmtom.FillOnRowChange = True
        Me.xdb_ivvcmtom.HeaderIsOnGrid = False
        Me.xdb_ivvcmtom.InnerJon = True
        Me.xdb_ivvcmtom.InsertOrder = 0
        Me.xdb_ivvcmtom.IsDetail = True
        Me.xdb_ivvcmtom.KeyFields = Nothing
        Me.xdb_ivvcmtom.LineColName = Nothing
        Me.xdb_ivvcmtom.MasterDetailRelation = New String() {"doc_serial=entr_serial"}
        Me.xdb_ivvcmtom.MasterTableName = Nothing
        Me.xdb_ivvcmtom.SerialColumnName = ""
        Me.xdb_ivvcmtom.Sort = Nothing
        Me.xdb_ivvcmtom.Source = New String() {"select ivvcmtom.*", ",ivitemm.item_name", "from ivvcmtom", "inner join ivitemm", "on ivitemm.item_code = ivvcmtom.item_code", "and ivitemm.aplicar_vcmto = 1"}
        Me.xdb_ivvcmtom.TableName = "ivvcmtom"
        Me.xdb_ivvcmtom.UpdateOrder = 0
        Me.xdb_ivvcmtom.UseRowRetrieve = False
        '
        'xdt_item_name
        '
        Me.xdt_item_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_item_name.Format = ""
        Me.xdt_item_name.FormatInfo = Nothing
        Me.xdt_item_name.HeaderText = "Descripción"
        Me.xdt_item_name.ImageList = Nothing
        Me.xdt_item_name.isReadOnly = True
        Me.xdt_item_name.MappingName = "item_name"
        Me.xdt_item_name.MaxLength = 32767
        Me.xdt_item_name.TabStop = True
        Me.xdt_item_name.UseCustomCellFormat = False
        Me.xdt_item_name.Width = 200
        '
        'xdt_unit_code
        '
        Me.xdt_unit_code.ComboBox = Me.LibXCombo1
        Me.xdt_unit_code.Format = ""
        Me.xdt_unit_code.FormatInfo = Nothing
        Me.xdt_unit_code.HeaderText = "Unidad"
        Me.xdt_unit_code.isReadOnly = False
        Me.xdt_unit_code.MappingName = "unit_code"
        Me.xdt_unit_code.Width = 101
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ivvcmtom.unit_code"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Location = New System.Drawing.Point(288, 240)
        Me.LibXCombo1.LookupKeyDisplayFields = "unit_name"
        Me.LibXCombo1.LookupKeyField = "unit_code"
        Me.LibXCombo1.LookupTableName = "ivunitm"
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(121, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 5
        '
        'xdt_qty
        '
        Me.xdt_qty.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_qty.Format = ""
        Me.xdt_qty.FormatInfo = Nothing
        Me.xdt_qty.HeaderText = "Cantidadi"
        Me.xdt_qty.ImageList = Nothing
        Me.xdt_qty.isReadOnly = False
        Me.xdt_qty.MappingName = "qty1"
        Me.xdt_qty.MaxLength = 32767
        Me.xdt_qty.TabStop = True
        Me.xdt_qty.UseCustomCellFormat = False
        Me.xdt_qty.Width = 55
        '
        'xdt_mes
        '
        Me.xdt_mes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_mes.Format = ""
        Me.xdt_mes.FormatInfo = Nothing
        Me.xdt_mes.HeaderText = "Mes"
        Me.xdt_mes.ImageList = Nothing
        Me.xdt_mes.isReadOnly = False
        Me.xdt_mes.MappingName = "vcmto_month1"
        Me.xdt_mes.MaxLength = 32767
        Me.xdt_mes.TabStop = True
        Me.xdt_mes.UseCustomCellFormat = False
        Me.xdt_mes.Width = 55
        '
        'xdt_Ano
        '
        Me.xdt_Ano.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Ano.Format = ""
        Me.xdt_Ano.FormatInfo = Nothing
        Me.xdt_Ano.HeaderText = "Año"
        Me.xdt_Ano.ImageList = Nothing
        Me.xdt_Ano.isReadOnly = False
        Me.xdt_Ano.MappingName = "vcmto_year1"
        Me.xdt_Ano.MaxLength = 32767
        Me.xdt_Ano.TabStop = True
        Me.xdt_Ano.UseCustomCellFormat = False
        Me.xdt_Ano.Width = 55
        '
        'xdt_qty1
        '
        Me.xdt_qty1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_qty1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_qty1.Format = ""
        Me.xdt_qty1.FormatInfo = Nothing
        Me.xdt_qty1.HeaderText = "Cantidadi"
        Me.xdt_qty1.ImageList = Nothing
        Me.xdt_qty1.isReadOnly = False
        Me.xdt_qty1.MappingName = "qty2"
        Me.xdt_qty1.MaxLength = 32767
        Me.xdt_qty1.TabStop = True
        Me.xdt_qty1.UseCustomCellFormat = False
        Me.xdt_qty1.Width = 55
        '
        'xdt_Mes1
        '
        Me.xdt_Mes1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Mes1.Format = ""
        Me.xdt_Mes1.FormatInfo = Nothing
        Me.xdt_Mes1.HeaderText = "Mes"
        Me.xdt_Mes1.ImageList = Nothing
        Me.xdt_Mes1.isReadOnly = False
        Me.xdt_Mes1.MappingName = "vcmto_month2"
        Me.xdt_Mes1.MaxLength = 32767
        Me.xdt_Mes1.TabStop = True
        Me.xdt_Mes1.UseCustomCellFormat = False
        Me.xdt_Mes1.Width = 55
        '
        'xdt_ano1
        '
        Me.xdt_ano1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_ano1.Format = ""
        Me.xdt_ano1.FormatInfo = Nothing
        Me.xdt_ano1.HeaderText = "Año"
        Me.xdt_ano1.ImageList = Nothing
        Me.xdt_ano1.isReadOnly = False
        Me.xdt_ano1.MappingName = "vcmto_year2"
        Me.xdt_ano1.MaxLength = 32767
        Me.xdt_ano1.TabStop = True
        Me.xdt_ano1.UseCustomCellFormat = False
        Me.xdt_ano1.Width = 55
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(810, 24)
        Me.LibXNavigator1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xdt_entr_status)
        Me.GroupBox1.Controls.Add(Me.xdtp_entr_date)
        Me.GroupBox1.Controls.Add(Me.lk_prov_code)
        Me.GroupBox1.Controls.Add(Me.lk_whse_code)
        Me.GroupBox1.Controls.Add(Me.txtwhse_code)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtEntr_Number)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.whse_name)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.prov_name)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 128)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
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
        Me.xdt_entr_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdt_entr_status.FieldDescription = ""
        Me.xdt_entr_status.FindInitialValue = Nothing
        Me.xdt_entr_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_entr_status.IgnoreRequiered = False
        Me.xdt_entr_status.Items.AddRange(New Object() {"0-Anulada", "1-Pendiente Aplicar", "2-Aplicada"})
        Me.xdt_entr_status.Location = New System.Drawing.Point(424, 48)
        Me.xdt_entr_status.LookupKeyDisplayFields = Nothing
        Me.xdt_entr_status.LookupKeyField = Nothing
        Me.xdt_entr_status.LookupTableName = Nothing
        Me.xdt_entr_status.Name = "xdt_entr_status"
        Me.xdt_entr_status.NewInitialValue = Nothing
        Me.xdt_entr_status.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_entr_status.Requiered = False
        Me.xdt_entr_status.Required = False
        Me.xdt_entr_status.Size = New System.Drawing.Size(176, 21)
        Me.xdt_entr_status.SqlString = Nothing
        Me.xdt_entr_status.StatusBarPanelDescripcion = Nothing
        Me.xdt_entr_status.TabIndex = 49
        '
        'xdtp_entr_date
        '
        Me.xdtp_entr_date.CustomFormat = "dd/MM/yyyy"
        Me.xdtp_entr_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "iventrdm.entr_date"))
        Me.xdtp_entr_date.EditInitialValue = Nothing
        Me.xdtp_entr_date.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdtp_entr_date.FieldDescription = ""
        Me.xdtp_entr_date.FindInitialValue = Nothing
        Me.xdtp_entr_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_entr_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdtp_entr_date.IgnoreRequiered = False
        Me.xdtp_entr_date.Location = New System.Drawing.Point(112, 48)
        Me.xdtp_entr_date.Name = "xdtp_entr_date"
        Me.xdtp_entr_date.NewInitialValue = Nothing
        Me.xdtp_entr_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_entr_date.Requiered = False
        Me.xdtp_entr_date.Size = New System.Drawing.Size(104, 20)
        Me.xdtp_entr_date.StatusBarPanelDescripcion = Nothing
        Me.xdtp_entr_date.TabIndex = 1
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
        Me.lk_prov_code.FilterField = Nothing
        Me.lk_prov_code.IgnoreFindInBrowseMode = False
        Me.lk_prov_code.isCanceled = False
        Me.lk_prov_code.Location = New System.Drawing.Point(584, 72)
        Me.lk_prov_code.LookCaption = "Suplidores"
        Me.lk_prov_code.Name = "lk_prov_code"
        Me.lk_prov_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lk_prov_code.ShowFilter = True
        Me.lk_prov_code.ShowMessageNotFound = True
        Me.lk_prov_code.ShowWarning = False
        Me.lk_prov_code.Size = New System.Drawing.Size(16, 20)
        Me.lk_prov_code.SizesColumns = Nothing
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
        Me.lk_whse_code.FilterField = Nothing
        Me.lk_whse_code.IgnoreFindInBrowseMode = False
        Me.lk_whse_code.isCanceled = False
        Me.lk_whse_code.Location = New System.Drawing.Point(584, 96)
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
        Me.txtwhse_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtwhse_code.FieldDescription = ""
        Me.txtwhse_code.FindInitialValue = Nothing
        Me.txtwhse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.IgnoreRequiered = False
        Me.txtwhse_code.Location = New System.Drawing.Point(112, 96)
        Me.txtwhse_code.Name = "txtwhse_code"
        Me.txtwhse_code.NewInitialValue = Nothing
        Me.txtwhse_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.Requiered = False
        Me.txtwhse_code.Size = New System.Drawing.Size(104, 20)
        Me.txtwhse_code.StatusBarPanelDescripcion = Nothing
        Me.txtwhse_code.TabIndex = 4
        Me.txtwhse_code.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(56, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Almacen"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtEntr_Number
        '
        Me.txtEntr_Number.AcceptsReturn = True
        Me.txtEntr_Number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.entr_number"))
        Me.txtEntr_Number.EditInitialValue = Nothing
        Me.txtEntr_Number.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtEntr_Number.FieldDescription = ""
        Me.txtEntr_Number.FindInitialValue = Nothing
        Me.txtEntr_Number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtEntr_Number.IgnoreRequiered = False
        Me.txtEntr_Number.Location = New System.Drawing.Point(112, 24)
        Me.txtEntr_Number.Name = "txtEntr_Number"
        Me.txtEntr_Number.NewInitialValue = Nothing
        Me.txtEntr_Number.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtEntr_Number.Requiered = False
        Me.txtEntr_Number.Size = New System.Drawing.Size(104, 20)
        Me.txtEntr_Number.StatusBarPanelDescripcion = Nothing
        Me.txtEntr_Number.TabIndex = 0
        Me.txtEntr_Number.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(40, 24)
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
        Me.whse_name.Location = New System.Drawing.Point(224, 96)
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
        'TextBox8
        '
        Me.TextBox8.AcceptsReturn = True
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.prov_code"))
        Me.TextBox8.EditInitialValue = Nothing
        Me.TextBox8.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox8.FieldDescription = ""
        Me.TextBox8.FindInitialValue = Nothing
        Me.TextBox8.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox8.IgnoreRequiered = False
        Me.TextBox8.Location = New System.Drawing.Point(112, 72)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.NewInitialValue = Nothing
        Me.TextBox8.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox8.Requiered = False
        Me.TextBox8.Size = New System.Drawing.Size(104, 20)
        Me.TextBox8.StatusBarPanelDescripcion = Nothing
        Me.TextBox8.TabIndex = 2
        Me.TextBox8.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(56, 72)
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
        Me.prov_name.Location = New System.Drawing.Point(224, 72)
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
        Me.Label10.Location = New System.Drawing.Point(64, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Fecha:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(368, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Estatus:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'i_ivvcmto02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(810, 488)
        Me.Controls.Add(Me.xlk_item_code)
        Me.Controls.Add(Me.LibXCombo1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.LibXGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivvcmto02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Captura de Vencimientos"
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivvcmtom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub xlk_item_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_item_code.BeforeExecuteQuery
        e.aditionalWhere = "iventrdd.entr_serial = " & LibXConnector1.CurrentDataRow!entr_serial.ToString

    End Sub

    Private Sub i_ivcmtod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '        LibXGrid1.footerOperations.add("item_code", "count(item_code)", "")

    End Sub

    Private Sub LibXCombo1_valueChanged(ByVal sender As Object, ByVal e As LibX.XComboSelectedEventArgs) Handles LibXCombo1.valueChanged
        Dim oParam As UnidadMedida.ParametroConvertir
        Dim oUnidad As UnidadMedida
        Dim Factor As Integer
        Dim Cantidad As Integer

        If LibXConnector1.IsEditing = True Then
            Exit Sub
        End If

        Try
            oParam = New UnidadMedida.ParametroConvertir
            oUnidad = New UnidadMedida

            With oParam
                .Cantidad = LibXGrid1.GetValue(Me.xdt_qty1)
                .UnidadDestino = e.value
                .UnidadOrigen = Me.DataSet1.Tables("ivvcmtom").Rows(LibXGrid1.CurrentRowIndex)!unit_code
            End With

            oUnidad.ConvertirUnidad(oParam)

            LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.xdt_qty1, oParam.Retorno.Cantidad)

            Factor = oUnidad.GetFactor(LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.xdt_item_code), e.value)
            Cantidad = LibXGrid1.GetValue(Me.xdt_qty1)

            Cantidad = Cantidad * Factor

            'LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.xdt_qty_onhand, Cantidad)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
        Try

            If LibXConnector1.IsDataEditing = True Then
                '// Validar el Mes
                If Me.xdt_mes.Column = e.cell Then
                    If Val(e.value.ToString.Trim) < 1 OrElse LibXGrid1.GetValue(e.row, Me.xdt_mes) > 12 Then
                        Throw New ApplicationException("Mes inválido, debe estar entre 1 y 12!")
                    End If
                End If

                '// Validar el Ano
                If Me.xdt_Ano.Column = e.cell Then
                    If Val(e.value.ToString.Trim) < DateTime.Now.Year Then
                        Throw New ApplicationException("Año inválido!")
                    End If
                End If

                '// Validar el Mes
                If Me.xdt_Mes1.Column = e.cell Then
                    If Val(LibXGrid1.GetValue(e.row, Me.xdt_qty1).ToString.Trim) > 0 AndAlso (Val(e.value.ToString.Trim) < 1 OrElse Val(e.value.ToString.Trim) > 12) Then
                        Throw New ApplicationException("Mes inválido, debe estar entre 1 y 12!")
                    End If
                End If

                '// Validar el Ano
                If Me.xdt_ano1.Column = e.cell Then
                    If Val(LibXGrid1.GetValue(e.row, Me.xdt_qty1).ToString.Trim) > 0 AndAlso Val(e.value.ToString.Trim) < DateTime.Now.Year Then
                        Throw New ApplicationException("Año inválido!")
                    End If
                End If

            End If
        Catch ex As Exception
            e.hasErrors = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LoadItems()
        Dim oTable As DataTable
        Dim SelectStmt As String

        SelectStmt = "select ivvcmtom.vcmto_serial " & _
                    ",iventrdd.entr_serial doc_serial " & _
                    ",iventrdd.item_code " & _
                    ",iventrdd.unit_code " & _
                    ",iventrdd.whse_code " & _
                    ",iventrdd.qty qty1 " & _
                    ",vcmto_month1 " & _
                    ",vcmto_year1 " & _
                    ",qty_onhand1 " & _
                    ",qty2 " & _
                    ",vcmto_month2 " & _
                    ",vcmto_year2 " & _
                    ",qty_onhand2 " & _
                    ",ivitemm.item_name " & _
                    "        from iventrdd  " & _
                    "inner join ivitemm " & _
                    "on ivitemm.item_code = iventrdd.item_code " & _
                    "and ivitemm.aplicar_vcmto = 1 " & _
                    "left outer join ivvcmtom " & _
                    "on ivvcmtom.doc_serial = iventrdd.entr_serial " & _
                    "and ivvcmtom.item_code = iventrdd.item_code " & _
                    "and ivvcmtom.whse_code = iventrdd.whse_code " & _
                    " where iventrdd.entr_serial = " & LibXConnector1.CurrentDataRow!entr_serial.ToString.Trim

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        If oTable Is Nothing Then
            Exit Sub
        End If

        If oTable.Rows.Count <= 0 Then
            Exit Sub
        End If

        Me.ivvcmtom.Rows.Clear()
        For Each oRow As DataRow In oTable.Rows
            Me.ivvcmtom.LoadDataRow(oRow.ItemArray, False)
        Next

        Exit Sub
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibX.LibxConnectionActions.Edit Then
                If Me.ivvcmtom.Rows.Count <= 0 Then
                    LoadItems()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingDetailRow
        Dim ifactor As Integer
        Dim oUnidad As SGT.Inventario.Entidades.UnidadMedida
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then
                oUnidad = New SGT.Inventario.Entidades.UnidadMedida

                ifactor = oUnidad.GetFactor(e.UpdatingArgs.Row!item_code, e.UpdatingArgs.Row!unit_code)

                e.UpdatingArgs.Row!qty_onhand1 = Val(e.UpdatingArgs.Row!qty1.ToString.Trim) * ifactor
                e.UpdatingArgs.Row!qty_onhand2 = Val(e.UpdatingArgs.Row!qty2.ToString.Trim) * ifactor
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)
        End Try
    End Sub
End Class
