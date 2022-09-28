Public Class i_ivcmted
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
    Friend WithEvents xdt_existencia As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xdt_mes_vence As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xdt_año_vence As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents xdt_prov_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents xlk_prov_code As LibX.LibXLookup
    Friend WithEvents xdt_item_code As LibX.XEditTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
    Friend WithEvents xdt_unit_code As LibX.XEditTextBoxColumn
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
    Friend WithEvents ivvcmted As System.Data.DataTable
    Friend WithEvents cpprovm As System.Data.DataTable
    Friend WithEvents Dtbcpprovm As LibX.LibXDbSourceTable
    Friend WithEvents Dtbivvcmted As LibX.LibXDbSourceTable
    Friend WithEvents lblItem_name As LibX.XTextBox
    Friend WithEvents xlk_item_code As LibX.LibXLookup
    Friend WithEvents xtxItem_code As LibX.XTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.DataSet1 = New System.Data.DataSet
        Me.ivvcmted = New System.Data.DataTable
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
        Me.cpprovm = New System.Data.DataTable
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
        Me.DataColumn35 = New System.Data.DataColumn
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.xdt_item_code = New LibX.XEditTextBoxColumn
        Me.xdt_item_name = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_existencia = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_unit_code = New LibX.XEditTextBoxColumn
        Me.xdt_mes_vence = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_año_vence = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xdt_prov_code = New LibX.XDataGridTextButtonColumn
        Me.xlk_prov_code = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.Dtbcpprovm = New LibX.LibXDbSourceTable
        Me.Dtbivvcmted = New LibX.LibXDbSourceTable
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.xtxItem_code = New LibX.XTextBox
        Me.lblItem_name = New LibX.XTextBox
        Me.xlk_item_code = New LibX.LibXLookup
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivvcmted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpprovm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Listado de vencimiento"
        Me.LibXGrid1.DataMember = "ivvcmted"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 88)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(896, 360)
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
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivvcmted, Me.cpprovm})
        '
        'ivvcmted
        '
        Me.ivvcmted.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21})
        Me.ivvcmted.TableName = "ivvcmted"
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "item_code"
        Me.DataColumn12.MaxLength = 10
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "whse_code"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "Mes"
        Me.DataColumn14.MaxLength = 2
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "Ano"
        Me.DataColumn15.MaxLength = 4
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "Existencia"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "unit_code"
        Me.DataColumn17.MaxLength = 5
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "prov_code"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "FechaVencimiento"
        Me.DataColumn19.DataType = GetType(System.DateTime)
        Me.DataColumn19.ReadOnly = True
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "item_name"
        Me.DataColumn20.MaxLength = 100
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "prov_name"
        Me.DataColumn21.MaxLength = 60
        '
        'cpprovm
        '
        Me.cpprovm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35})
        Me.cpprovm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"prov_code"}, True)})
        Me.cpprovm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.cpprovm.TableName = "cpprovm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "prov_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "prov_type"
        Me.DataColumn2.MaxLength = 6
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "term_code"
        Me.DataColumn3.MaxLength = 5
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "rnc_id"
        Me.DataColumn4.MaxLength = 18
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "prov_name"
        Me.DataColumn5.MaxLength = 60
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "contact_name"
        Me.DataColumn6.MaxLength = 40
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "contact_phne"
        Me.DataColumn7.MaxLength = 20
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "area_code"
        Me.DataColumn8.MaxLength = 3
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "phone"
        Me.DataColumn9.MaxLength = 20
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "fax"
        Me.DataColumn10.MaxLength = 20
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "address1"
        Me.DataColumn11.MaxLength = 40
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "address2"
        Me.DataColumn22.MaxLength = 40
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "credit_limit"
        Me.DataColumn23.DataType = GetType(System.Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "balance"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "stop_pay"
        Me.DataColumn25.DataType = GetType(System.Int16)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "aply_disc"
        Me.DataColumn26.DataType = GetType(System.Int16)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "backorder"
        Me.DataColumn27.DataType = GetType(System.Int16)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "date_created"
        Me.DataColumn28.DataType = GetType(System.DateTime)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "userid"
        Me.DataColumn29.MaxLength = 20
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "city_code"
        Me.DataColumn30.MaxLength = 3
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "sector_code"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "acct_no"
        Me.DataColumn32.MaxLength = 20
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "cuenta_bancaria"
        Me.DataColumn33.MaxLength = 20
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "last_pay_date"
        Me.DataColumn34.DataType = GetType(System.DateTime)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "last_purch_date"
        Me.DataColumn35.DataType = GetType(System.DateTime)
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.xdt_item_code, Me.xdt_item_name, Me.xdt_existencia, Me.xdt_unit_code, Me.xdt_mes_vence, Me.xdt_año_vence, Me.xdt_prov_code, Me.XEditTextBoxColumn1})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivvcmted"
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
        'xdt_existencia
        '
        Me.xdt_existencia.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_existencia.Format = "####0.00"
        Me.xdt_existencia.FormatInfo = Nothing
        Me.xdt_existencia.HeaderText = "Cantidadi"
        Me.xdt_existencia.MappingName = "Existencia"
        Me.xdt_existencia.Width = 75
        '
        'xdt_unit_code
        '
        Me.xdt_unit_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_unit_code.Format = ""
        Me.xdt_unit_code.FormatInfo = Nothing
        Me.xdt_unit_code.HeaderText = "Unidad"
        Me.xdt_unit_code.ImageList = Nothing
        Me.xdt_unit_code.isReadOnly = False
        Me.xdt_unit_code.MappingName = "unit_code"
        Me.xdt_unit_code.MaxLength = 32767
        Me.xdt_unit_code.TabStop = True
        Me.xdt_unit_code.UseCustomCellFormat = False
        Me.xdt_unit_code.Width = 75
        '
        'xdt_mes_vence
        '
        Me.xdt_mes_vence.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_mes_vence.Format = "##"
        Me.xdt_mes_vence.FormatInfo = Nothing
        Me.xdt_mes_vence.HeaderText = "Mesi"
        Me.xdt_mes_vence.MappingName = "Mes"
        Me.xdt_mes_vence.Width = 60
        '
        'xdt_año_vence
        '
        Me.xdt_año_vence.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_año_vence.Format = "####"
        Me.xdt_año_vence.FormatInfo = Nothing
        Me.xdt_año_vence.HeaderText = "Añoi"
        Me.xdt_año_vence.MappingName = "Ano"
        Me.xdt_año_vence.Width = 60
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
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = False
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "ivvcmted"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.Dtbcpprovm, Me.Dtbivvcmted})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
        '
        'Dtbcpprovm
        '
        Me.Dtbcpprovm.AllowDelete = True
        Me.Dtbcpprovm.AllowEdit = True
        Me.Dtbcpprovm.AllowNew = True
        Me.Dtbcpprovm.AutoIncrementSerial = False
        Me.Dtbcpprovm.CustomDbUpdate = True
        Me.Dtbcpprovm.DeleteOrder = 0
        Me.Dtbcpprovm.FillOnQuery = True
        Me.Dtbcpprovm.FillOnRowChange = False
        Me.Dtbcpprovm.HeaderIsOnGrid = False
        Me.Dtbcpprovm.InnerJon = True
        Me.Dtbcpprovm.InsertOrder = 0
        Me.Dtbcpprovm.IsDetail = False
        Me.Dtbcpprovm.KeyFields = Nothing
        Me.Dtbcpprovm.LineColName = Nothing
        Me.Dtbcpprovm.MasterDetailRelation = Nothing
        Me.Dtbcpprovm.MasterTableName = Nothing
        Me.Dtbcpprovm.SerialColumnName = Nothing
        Me.Dtbcpprovm.Sort = Nothing
        Me.Dtbcpprovm.Source = New String() {"select distinct cpprovm.prov_code,cpprovm.prov_name", "from cpprovm inner join ivvcmted on cpprovm.prov_code=ivvcmted.prov_code"}
        Me.Dtbcpprovm.TableName = "cpprovm"
        Me.Dtbcpprovm.UpdateOrder = 0
        Me.Dtbcpprovm.UseRowRetrieve = False
        '
        'Dtbivvcmted
        '
        Me.Dtbivvcmted.AllowDelete = True
        Me.Dtbivvcmted.AllowEdit = True
        Me.Dtbivvcmted.AllowNew = True
        Me.Dtbivvcmted.AutoIncrementSerial = False
        Me.Dtbivvcmted.CustomDbUpdate = False
        Me.Dtbivvcmted.DeleteOrder = 0
        Me.Dtbivvcmted.FillOnQuery = True
        Me.Dtbivvcmted.FillOnRowChange = False
        Me.Dtbivvcmted.HeaderIsOnGrid = False
        Me.Dtbivvcmted.InnerJon = True
        Me.Dtbivvcmted.InsertOrder = 0
        Me.Dtbivvcmted.IsDetail = True
        Me.Dtbivvcmted.KeyFields = Nothing
        Me.Dtbivvcmted.LineColName = Nothing
        Me.Dtbivvcmted.MasterDetailRelation = New String() {"item_code=item_code"}
        Me.Dtbivvcmted.MasterTableName = Nothing
        Me.Dtbivvcmted.SerialColumnName = Nothing
        Me.Dtbivvcmted.Sort = Nothing
        Me.Dtbivvcmted.Source = New String() {"select ivvcmted.*,ivitemm.item_name,cpprovm.prov_name from ivvcmted", "inner join ivitemm on ivvcmted.item_code=ivitemm.item_code", "left join cpprovm on ivvcmted.prov_code=cpprovm.prov_code", "order by ivvcmted.prov_code,ivvcmted.item_code"}
        Me.Dtbivvcmted.TableName = "ivvcmted"
        Me.Dtbivvcmted.UpdateOrder = 0
        Me.Dtbivvcmted.UseRowRetrieve = False
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
        Me.XEditTextBoxColumn1.Width = 200
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
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxItem_code
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxItem_code
        Me.LibXNavigator1.FirstControlInNewMode = Nothing
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(914, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'xtxItem_code
        '
        Me.xtxItem_code.AcceptsReturn = True
        Me.xtxItem_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivvcmted.item_code"))
        Me.xtxItem_code.EditInitialValue = Nothing
        Me.xtxItem_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxItem_code.FieldDescription = ""
        Me.xtxItem_code.FindInitialValue = Nothing
        Me.xtxItem_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxItem_code.IgnoreRequiered = False
        Me.xtxItem_code.Location = New System.Drawing.Point(72, 24)
        Me.xtxItem_code.Name = "xtxItem_code"
        Me.xtxItem_code.NewInitialValue = Nothing
        Me.xtxItem_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxItem_code.Requiered = False
        Me.xtxItem_code.Size = New System.Drawing.Size(96, 20)
        Me.xtxItem_code.StatusBarPanelDescripcion = Nothing
        Me.xtxItem_code.TabIndex = 0
        Me.xtxItem_code.Text = ""
        '
        'lblItem_name
        '
        Me.lblItem_name.AcceptsReturn = True
        Me.lblItem_name.EditInitialValue = Nothing
        Me.lblItem_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lblItem_name.FieldDescription = ""
        Me.lblItem_name.FindInitialValue = Nothing
        Me.lblItem_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lblItem_name.IgnoreRequiered = False
        Me.lblItem_name.Location = New System.Drawing.Point(168, 24)
        Me.lblItem_name.Name = "lblItem_name"
        Me.lblItem_name.NewInitialValue = Nothing
        Me.lblItem_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lblItem_name.ReadOnly = True
        Me.lblItem_name.Requiered = False
        Me.lblItem_name.Size = New System.Drawing.Size(360, 20)
        Me.lblItem_name.StatusBarPanelDescripcion = Nothing
        Me.lblItem_name.TabIndex = 28
        Me.lblItem_name.TabStop = False
        Me.lblItem_name.Text = ""
        '
        'xlk_item_code
        '
        Me.xlk_item_code.AlternateFieldSearch = Nothing
        Me.xlk_item_code.BeginCheck = False
        Me.xlk_item_code.CheckText = Nothing
        Me.xlk_item_code.ComboMode = False
        Me.xlk_item_code.DataMember = Nothing
        Me.xlk_item_code.DataSource = Me.LibXConnector1
        Me.xlk_item_code.DestParameters = New String() {"xtxItem_code=item_code", "lblitem_name=item_name"}
        Me.xlk_item_code.FilterField = Nothing
        Me.xlk_item_code.IgnoreFindInBrowseMode = False
        Me.xlk_item_code.isCanceled = False
        Me.xlk_item_code.Location = New System.Drawing.Point(528, 24)
        Me.xlk_item_code.LookCaption = "Productos"
        Me.xlk_item_code.Name = "xlk_item_code"
        Me.xlk_item_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_item_code.ShowFilter = True
        Me.xlk_item_code.ShowMessageNotFound = True
        Me.xlk_item_code.ShowWarning = False
        Me.xlk_item_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_item_code.SizesColumns = Nothing
        Me.xlk_item_code.SizesColumnsTab = Nothing
        Me.xlk_item_code.SqlString = Nothing
        Me.xlk_item_code.SQLTab = Nothing
        Me.xlk_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.xlk_item_code.TabIndex = 1
        Me.xlk_item_code.TableName = "ivitemm"
        Me.xlk_item_code.TabStop = False
        Me.xlk_item_code.UseCopyConnection = False
        Me.xlk_item_code.UseRowRetrieveEvents = False
        Me.xlk_item_code.UseTab = False
        Me.xlk_item_code.VisParameters = New String() {"Código=item_code", "Nombre=item_name"}
        Me.xlk_item_code.WhereCondition = Nothing
        Me.xlk_item_code.WhereParameters = Nothing
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(16, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Producto:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblItem_name)
        Me.GroupBox1.Controls.Add(Me.xtxItem_code)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xlk_item_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(896, 56)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'i_ivcmted
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(914, 496)
        Me.Controls.Add(Me.xlk_prov_code)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.LibXGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivcmted"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Edicion de Vencimientos"
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivvcmted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpprovm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
        Try
            If e.cell = LibXGrid1.GetColNum(xdt_existencia) Then
                If Val(e.value.Trim) = 0 Then
                    Exit Sub
                End If

                If Math.Abs(Val(LibXGrid1.GetValue(e.row, xdt_existencia))) < Math.Abs(Val(e.value.Trim)) Then
                    LibXGrid1.SetValue(e.row, xdt_existencia, Val(LibXGrid1.GetValue(e.row, xdt_existencia)))
                    e.value = LibXGrid1.GetValue(e.row, xdt_existencia)
                End If

            End If
            If e.cell = LibXGrid1.GetColNum(xdt_año_vence) Then
                If Val(e.value.Trim) = 0 Then
                    LibXGrid1.Focus(e.row, 9)
                    Exit Sub
                End If

                If Val(LibXGrid1.GetValue(e.row, xdt_existencia)) = Val(LibXGrid1.GetValue(e.row, xdt_existencia)) Then
                    LibXGrid1.Focus(e.row, 9)
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            e.hasErrors = True
            LibX.Log.Show(ex)
        End Try
    End Sub
    
    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        Try
            ''For Each oRow As DataRow In ivvcmted.Select("existencia =0")
            ''    oRow.Delete()
            ''Next

        Catch ex As Exception
            e.Handled = True
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        '''If e.Action = LibX.LibxConnectionActions.Accept And Me.xtxItem_code.Text = "" Then
        '''    Throw New ApplicationException("Tiene que indicar un producto!")
        '''End If

        '''If e.AcceptedAction = LibX.LibxConnectionActions.Accept And Me.xtxItem_code.Text = "" Then
        '''    Throw New ApplicationException("Tiene que indicar un producto!")
        '''End If

       
    End Sub


    Private Sub i_ivcmtod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.LibXGrid1.getCurrentGridView.AllowNew = False

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
                    LibXConnector1.AllowDelete = False
                    LibXConnector1.AllowNew = False
                    LibXConnector1.AllowEdit = True
                    LibXNavigator1.UpdateState()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeLoadDetail(ByVal sender As Object, ByVal e As LibX.XbeforeLoadDetailEventArgs) Handles LibXConnector1.BeforeLoadDetail
        e.Sql = e.Sql & " order by prov_code,item_code "
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        If Me.xtxItem_code.Text <> "" Then
            e.AditionalWhere = "ivvcmted.item_code = '" & Me.xtxItem_code.Text & "'"
        End If
        ''e.Sql = e.Sql & " order by ivvcmted.item_code,ivvcmted.prov_code, ivvcmted.existencia"
    End Sub

End Class
