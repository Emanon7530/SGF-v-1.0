
Imports SGT.Inventario.Entidades
Imports SGT.Facturacion.Entidades
Imports LibX
Public Class i_ftfact11
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call2


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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents DateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtClinombre As LibX.XTextBox
    Friend WithEvents GridColQty As LibX.XEditTextBoxColumn
    Friend WithEvents LibXGridDetalle As LibX.LibXGrid
    Friend WithEvents GColprice As LibX.XEditTextBoxColumn
    Friend WithEvents gColdscto As LibX.XEditTextBoxColumn
    Friend WithEvents gColImporte As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gColitem_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lkCliente As LibX.LibXLookup
    Friend WithEvents gColitem_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents gColwhse_code As LibX.XEditTextBoxColumn
    Friend WithEvents gColIbis As LibX.XEditTextBoxColumn
    Friend WithEvents txtCliCodigo As LibX.XTextBox
    Friend WithEvents lbx_fact_status As LibX.LibXCombo
    Friend WithEvents txtcotiz_number As LibX.XTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_item_name As LibX.XTextBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents STftcotizm As LibX.LibXDbSourceTable
    Friend WithEvents STftcotizd As LibX.LibXDbSourceTable
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
    Friend WithEvents ftcotizm As System.Data.DataTable
    Friend WithEvents ftcotizd As System.Data.DataTable
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents XTextBox1 As LibX.XTextBox
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
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents TextBox1 As LibX.XTextBox
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents XMaskEdit1 As LibX.XMaskEdit
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents gColUnit_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents xlk_unit_code As LibX.LibXLookup
    Friend WithEvents xlk_item_code As LibX.LibXLookup
    Friend WithEvents xtxt_Descto As LibX.XMaskEdit
    Friend WithEvents xtxt_MontoBruto As LibX.XMaskEdit
    Friend WithEvents xtxt_Itbis As LibX.XMaskEdit
    Friend WithEvents xtxt_MontoNeto As LibX.XMaskEdit
    Friend WithEvents XMaskEdit2 As LibX.XMaskEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ftcotizm = New System.Data.DataTable
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
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.ftcotizd = New System.Data.DataTable
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
        Me.DataColumn30 = New System.Data.DataColumn
        Me.STftcotizm = New LibX.LibXDbSourceTable
        Me.STftcotizd = New LibX.LibXDbSourceTable
        Me.txtCliCodigo = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.xtxt_Descto = New LibX.XMaskEdit
        Me.XMaskEdit1 = New LibX.XMaskEdit
        Me.TextBox1 = New LibX.XTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcotiz_number = New LibX.XTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtClinombre = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New LibX.LibxDateTimePicker
        Me.lkCliente = New LibX.LibXLookup
        Me.lbx_fact_status = New LibX.LibXCombo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.XMaskEdit2 = New LibX.XMaskEdit
        Me.xtxt_MontoBruto = New LibX.XMaskEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.xtxt_Itbis = New LibX.XMaskEdit
        Me.xtxt_MontoNeto = New LibX.XMaskEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.LibXGridDetalle = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColitem_code = New LibX.XDataGridTextButtonColumn
        Me.xlk_item_code = New LibX.LibXLookup
        Me.gColwhse_code = New LibX.XEditTextBoxColumn
        Me.gColitem_name = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GridColQty = New LibX.XEditTextBoxColumn
        Me.gColUnit_code = New LibX.XDataGridTextButtonColumn
        Me.xlk_unit_code = New LibX.LibXLookup
        Me.GColprice = New LibX.XEditTextBoxColumn
        Me.gColdscto = New LibX.XEditTextBoxColumn
        Me.gColIbis = New LibX.XEditTextBoxColumn
        Me.gColImporte = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txt_item_name = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftcotizm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftcotizd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.txtCliCodigo
        Me.LibXNavigator1.FirstControlInFindMode = Me.txtCliCodigo
        Me.LibXNavigator1.FirstControlInNewMode = Me.txtCliCodigo
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(874, 24)
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
        Me.LibXConnector1.DataMember = "ftcotizm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = "FCT"
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = "r_ftcotiz01.rpt"
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.STftcotizm, Me.STftcotizd})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftcotizm, Me.ftcotizd})
        '
        'ftcotizm
        '
        Me.ftcotizm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn29, Me.DataColumn28, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33})
        Me.ftcotizm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"cotiz_serial"}, True)})
        Me.ftcotizm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.ftcotizm.TableName = "ftcotizm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "cotiz_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "cust_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "term_code"
        Me.DataColumn3.MaxLength = 5
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "cotiz_number"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "cotiz_date"
        Me.DataColumn5.DataType = GetType(System.DateTime)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "cust_name"
        Me.DataColumn6.MaxLength = 100
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "cust_address"
        Me.DataColumn7.MaxLength = 200
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
        Me.DataColumn10.ColumnName = "due_days"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "cotiz_note"
        Me.DataColumn11.MaxLength = 100
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "cotz_status"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "type_code"
        Me.DataColumn13.MaxLength = 3
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "cotiz_amount"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "price_type"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.ColumnName = "vend_code"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "phone1"
        Me.DataColumn31.MaxLength = 12
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "descuento"
        Me.DataColumn32.DataType = GetType(System.Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "itbis"
        Me.DataColumn33.DataType = GetType(System.Decimal)
        '
        'ftcotizd
        '
        Me.ftcotizd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn30})
        Me.ftcotizd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"cotiz_serial", "line_no"}, True)})
        Me.ftcotizd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn16, Me.DataColumn17}
        Me.ftcotizd.TableName = "ftcotizd"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "Importe"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "cotiz_serial"
        Me.DataColumn16.DataType = GetType(System.Int32)
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.AutoIncrementSeed = CType(1, Long)
        Me.DataColumn17.ColumnName = "line_no"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "item_code"
        Me.DataColumn18.MaxLength = 10
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "whse_code"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "item_name"
        Me.DataColumn20.MaxLength = 100
        '
        'DataColumn21
        '
        Me.DataColumn21.AllowDBNull = False
        Me.DataColumn21.ColumnName = "qty"
        Me.DataColumn21.DataType = GetType(System.Decimal)
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "price"
        Me.DataColumn22.DataType = GetType(System.Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "unit_code"
        Me.DataColumn23.MaxLength = 5
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "itbis"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        Me.DataColumn24.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn25
        '
        Me.DataColumn25.Caption = "PriceList"
        Me.DataColumn25.ColumnName = "priceLista"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "PriceMajor"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "PriceMinim"
        Me.DataColumn27.DataType = GetType(System.Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "dscto"
        Me.DataColumn30.DataType = GetType(System.Decimal)
        Me.DataColumn30.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'STftcotizm
        '
        Me.STftcotizm.AllowDelete = True
        Me.STftcotizm.AllowEdit = True
        Me.STftcotizm.AllowNew = True
        Me.STftcotizm.AutoIncrementSerial = False
        Me.STftcotizm.CustomDbUpdate = False
        Me.STftcotizm.DeleteOrder = 0
        Me.STftcotizm.FillOnQuery = True
        Me.STftcotizm.FillOnRowChange = False
        Me.STftcotizm.HeaderIsOnGrid = False
        Me.STftcotizm.InnerJon = True
        Me.STftcotizm.InsertOrder = 0
        Me.STftcotizm.IsDetail = False
        Me.STftcotizm.KeyFields = Nothing
        Me.STftcotizm.LineColName = Nothing
        Me.STftcotizm.MasterDetailRelation = Nothing
        Me.STftcotizm.MasterTableName = Nothing
        Me.STftcotizm.SerialColumnName = "cotiz_serial"
        Me.STftcotizm.Sort = Nothing
        Me.STftcotizm.Source = Nothing
        Me.STftcotizm.TableName = "ftcotizm"
        Me.STftcotizm.UpdateOrder = 0
        Me.STftcotizm.UseRowRetrieve = False
        '
        'STftcotizd
        '
        Me.STftcotizd.AllowDelete = True
        Me.STftcotizd.AllowEdit = True
        Me.STftcotizd.AllowNew = True
        Me.STftcotizd.AutoIncrementSerial = True
        Me.STftcotizd.CustomDbUpdate = False
        Me.STftcotizd.DeleteOrder = 0
        Me.STftcotizd.FillOnQuery = True
        Me.STftcotizd.FillOnRowChange = True
        Me.STftcotizd.HeaderIsOnGrid = False
        Me.STftcotizd.InnerJon = True
        Me.STftcotizd.InsertOrder = 0
        Me.STftcotizd.IsDetail = True
        Me.STftcotizd.KeyFields = "cotiz_serial,line_no"
        Me.STftcotizd.LineColName = Nothing
        Me.STftcotizd.MasterDetailRelation = New String() {"cotiz_serial=cotiz_serial"}
        Me.STftcotizd.MasterTableName = Nothing
        Me.STftcotizd.SerialColumnName = ""
        Me.STftcotizd.Sort = Nothing
        Me.STftcotizd.Source = New String() {"select ftcotizd.*,item_name", "from ftcotizd inner join ivitemm ", "on ftcotizd.item_code=ivitemm.item_code"}
        Me.STftcotizd.TableName = "ftcotizd"
        Me.STftcotizd.UpdateOrder = 0
        Me.STftcotizd.UseRowRetrieve = False
        '
        'txtCliCodigo
        '
        Me.txtCliCodigo.AcceptsReturn = True
        Me.txtCliCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcotizm.cust_code"))
        Me.txtCliCodigo.EditInitialValue = Nothing
        Me.txtCliCodigo.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCliCodigo.FieldDescription = ""
        Me.txtCliCodigo.FindInitialValue = Nothing
        Me.txtCliCodigo.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCliCodigo.IgnoreRequiered = False
        Me.txtCliCodigo.Location = New System.Drawing.Point(96, 40)
        Me.txtCliCodigo.Name = "txtCliCodigo"
        Me.txtCliCodigo.NewInitialValue = Nothing
        Me.txtCliCodigo.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCliCodigo.Requiered = False
        Me.txtCliCodigo.Size = New System.Drawing.Size(88, 20)
        Me.txtCliCodigo.StatusBarPanelDescripcion = Nothing
        Me.txtCliCodigo.TabIndex = 1
        Me.txtCliCodigo.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.xtxt_Descto)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCliCodigo)
        Me.GroupBox1.Controls.Add(Me.txtcotiz_number)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtClinombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.lkCliente)
        Me.GroupBox1.Controls.Add(Me.lbx_fact_status)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit2)
        Me.GroupBox1.Controls.Add(Me.xtxt_MontoBruto)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.xtxt_Itbis)
        Me.GroupBox1.Controls.Add(Me.xtxt_MontoNeto)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(856, 232)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(600, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 22)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Descuento:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_Descto
        '
        Me.xtxt_Descto.AcceptsReturn = True
        Me.xtxt_Descto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcotizm.descuento"))
        Me.xtxt_Descto.EditInitialValue = Nothing
        Me.xtxt_Descto.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Descto.FieldDescription = ""
        Me.xtxt_Descto.FindInitialValue = Nothing
        Me.xtxt_Descto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Descto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_Descto.IgnoreRequiered = False
        Me.xtxt_Descto.Location = New System.Drawing.Point(704, 120)
        Me.xtxt_Descto.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxt_Descto.Name = "xtxt_Descto"
        Me.xtxt_Descto.NewInitialValue = Nothing
        Me.xtxt_Descto.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Descto.Requiered = False
        Me.xtxt_Descto.Size = New System.Drawing.Size(136, 29)
        Me.xtxt_Descto.StatusBarPanelDescripcion = Nothing
        Me.xtxt_Descto.TabIndex = 10
        Me.xtxt_Descto.Text = ""
        Me.xtxt_Descto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'XMaskEdit1
        '
        Me.XMaskEdit1.AcceptsReturn = True
        Me.XMaskEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcotizm.phone"))
        Me.XMaskEdit1.EditInitialValue = Nothing
        Me.XMaskEdit1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.FieldDescription = ""
        Me.XMaskEdit1.FindInitialValue = Nothing
        Me.XMaskEdit1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.IgnoreRequiered = False
        Me.XMaskEdit1.Location = New System.Drawing.Point(96, 152)
        Me.XMaskEdit1.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.XMaskEdit1.Name = "XMaskEdit1"
        Me.XMaskEdit1.NewInitialValue = Nothing
        Me.XMaskEdit1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.Requiered = False
        Me.XMaskEdit1.Size = New System.Drawing.Size(152, 20)
        Me.XMaskEdit1.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit1.TabIndex = 4
        Me.XMaskEdit1.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcotizm.due_days"))
        Me.TextBox1.EditInitialValue = Nothing
        Me.TextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox1.FieldDescription = ""
        Me.TextBox1.FindInitialValue = Nothing
        Me.TextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox1.IgnoreRequiered = False
        Me.TextBox1.Location = New System.Drawing.Point(704, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.NewInitialValue = Nothing
        Me.TextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox1.Requiered = False
        Me.TextBox1.Size = New System.Drawing.Size(40, 20)
        Me.TextBox1.StatusBarPanelDescripcion = Nothing
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(593, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 16)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Días Vencimiento:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcotizm.cotiz_note"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(96, 176)
        Me.XTextBox1.Multiline = True
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(440, 48)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 6
        Me.XTextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(49, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Nota:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtcotiz_number
        '
        Me.txtcotiz_number.AcceptsReturn = True
        Me.txtcotiz_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcotizm.cotiz_number"))
        Me.txtcotiz_number.EditInitialValue = Nothing
        Me.txtcotiz_number.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtcotiz_number.FieldDescription = ""
        Me.txtcotiz_number.FindInitialValue = Nothing
        Me.txtcotiz_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcotiz_number.IgnoreRequiered = True
        Me.txtcotiz_number.Location = New System.Drawing.Point(96, 16)
        Me.txtcotiz_number.Name = "txtcotiz_number"
        Me.txtcotiz_number.NewInitialValue = Nothing
        Me.txtcotiz_number.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtcotiz_number.Requiered = False
        Me.txtcotiz_number.StatusBarPanelDescripcion = Nothing
        Me.txtcotiz_number.TabIndex = 0
        Me.txtcotiz_number.TabStop = False
        Me.txtcotiz_number.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(644, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Estatus:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(650, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(592, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 22)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Monto Total:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtClinombre
        '
        Me.txtClinombre.AcceptsReturn = True
        Me.txtClinombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClinombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcotizm.cust_name"))
        Me.txtClinombre.EditInitialValue = Nothing
        Me.txtClinombre.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtClinombre.FieldDescription = ""
        Me.txtClinombre.FindInitialValue = Nothing
        Me.txtClinombre.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtClinombre.IgnoreRequiered = False
        Me.txtClinombre.Location = New System.Drawing.Point(96, 64)
        Me.txtClinombre.Name = "txtClinombre"
        Me.txtClinombre.NewInitialValue = Nothing
        Me.txtClinombre.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtClinombre.Requiered = False
        Me.txtClinombre.Size = New System.Drawing.Size(440, 20)
        Me.txtClinombre.StatusBarPanelDescripcion = Nothing
        Me.txtClinombre.TabIndex = 2
        Me.txtClinombre.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(22, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "A Nombre:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftcotizm.cotiz_date"))
        Me.DateTimePicker1.EditInitialValue = Nothing
        Me.DateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.DateTimePicker1.FieldDescription = ""
        Me.DateTimePicker1.FindInitialValue = Nothing
        Me.DateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.IgnoreRequiered = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(704, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.NewInitialValue = ""
        Me.DateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.DateTimePicker1.Requiered = False
        Me.DateTimePicker1.Size = New System.Drawing.Size(136, 20)
        Me.DateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.DateTimePicker1.TabIndex = 8
        '
        'lkCliente
        '
        Me.lkCliente.AlternateFieldSearch = Nothing
        Me.lkCliente.BeginCheck = False
        Me.lkCliente.CheckText = Nothing
        Me.lkCliente.ComboMode = False
        Me.lkCliente.DataMember = Nothing
        Me.lkCliente.DataSource = Me.LibXConnector1
        Me.lkCliente.DestParameters = New String() {"cust_code=cust_code", "cust_name=cust_name", "phone=cust_phone", "cust_address=cust_address", "phone1=cust_cellphone"}
        Me.lkCliente.FilterField = "cust_name"
        Me.lkCliente.IgnoreFindInBrowseMode = False
        Me.lkCliente.isCanceled = False
        Me.lkCliente.Location = New System.Drawing.Point(184, 40)
        Me.lkCliente.LookCaption = "Clientes"
        Me.lkCliente.Name = "lkCliente"
        Me.lkCliente.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkCliente.ShowFilter = True
        Me.lkCliente.ShowMessageNotFound = True
        Me.lkCliente.ShowWarning = True
        Me.lkCliente.Size = New System.Drawing.Size(16, 20)
        Me.lkCliente.SizesColumns = New String() {"cust_name=450"}
        Me.lkCliente.SizesColumnsTab = Nothing
        Me.lkCliente.SqlString = Nothing
        Me.lkCliente.SQLTab = Nothing
        Me.lkCliente.SrcParameters = New String() {"cust_code=cust_code"}
        Me.lkCliente.TabIndex = 8
        Me.lkCliente.TableName = "cccustm"
        Me.lkCliente.TabStop = False
        Me.lkCliente.UseCopyConnection = False
        Me.lkCliente.UseRowRetrieveEvents = False
        Me.lkCliente.UseTab = False
        Me.lkCliente.VisParameters = New String() {"Código=cust_code", "Nombre=cust_name"}
        Me.lkCliente.WhereCondition = Nothing
        Me.lkCliente.WhereParameters = Nothing
        '
        'lbx_fact_status
        '
        Me.lbx_fact_status.AllowDefaultSort = True
        Me.lbx_fact_status.bound = True
        Me.lbx_fact_status.currValue = Nothing
        Me.lbx_fact_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftcotizm.cotz_status"))
        Me.lbx_fact_status.DefaultWhereString = Nothing
        Me.lbx_fact_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lbx_fact_status.EditInitialValue = Nothing
        Me.lbx_fact_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.lbx_fact_status.FieldDescription = ""
        Me.lbx_fact_status.FindInitialValue = Nothing
        Me.lbx_fact_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lbx_fact_status.IgnoreRequiered = False
        Me.lbx_fact_status.Items.AddRange(New Object() {"1-Vigente", "2-Vencida"})
        Me.lbx_fact_status.Location = New System.Drawing.Point(704, 16)
        Me.lbx_fact_status.LookupKeyDisplayFields = Nothing
        Me.lbx_fact_status.LookupKeyField = Nothing
        Me.lbx_fact_status.LookupTableName = Nothing
        Me.lbx_fact_status.Name = "lbx_fact_status"
        Me.lbx_fact_status.NewInitialValue = "1"
        Me.lbx_fact_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.lbx_fact_status.Requiered = False
        Me.lbx_fact_status.Required = False
        Me.lbx_fact_status.Size = New System.Drawing.Size(136, 21)
        Me.lbx_fact_status.SqlString = Nothing
        Me.lbx_fact_status.StatusBarPanelDescripcion = Nothing
        Me.lbx_fact_status.TabIndex = 7
        Me.lbx_fact_status.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(37, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cliente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(32, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcotizm.cust_address"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(96, 88)
        Me.XTextBox2.Multiline = True
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(440, 56)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 3
        Me.XTextBox2.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(25, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Direccion:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(29, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Telefono:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(320, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Telefono:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XMaskEdit2
        '
        Me.XMaskEdit2.AcceptsReturn = True
        Me.XMaskEdit2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcotizm.phone1"))
        Me.XMaskEdit2.EditInitialValue = Nothing
        Me.XMaskEdit2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit2.FieldDescription = ""
        Me.XMaskEdit2.FindInitialValue = Nothing
        Me.XMaskEdit2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit2.IgnoreRequiered = False
        Me.XMaskEdit2.Location = New System.Drawing.Point(384, 152)
        Me.XMaskEdit2.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.XMaskEdit2.Name = "XMaskEdit2"
        Me.XMaskEdit2.NewInitialValue = Nothing
        Me.XMaskEdit2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit2.Requiered = False
        Me.XMaskEdit2.Size = New System.Drawing.Size(152, 20)
        Me.XMaskEdit2.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit2.TabIndex = 5
        Me.XMaskEdit2.Text = ""
        '
        'xtxt_MontoBruto
        '
        Me.xtxt_MontoBruto.AcceptsReturn = True
        Me.xtxt_MontoBruto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcotizm.cotiz_amount"))
        Me.xtxt_MontoBruto.EditInitialValue = Nothing
        Me.xtxt_MontoBruto.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_MontoBruto.FieldDescription = ""
        Me.xtxt_MontoBruto.FindInitialValue = Nothing
        Me.xtxt_MontoBruto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_MontoBruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_MontoBruto.IgnoreRequiered = False
        Me.xtxt_MontoBruto.Location = New System.Drawing.Point(704, 88)
        Me.xtxt_MontoBruto.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxt_MontoBruto.Name = "xtxt_MontoBruto"
        Me.xtxt_MontoBruto.NewInitialValue = Nothing
        Me.xtxt_MontoBruto.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_MontoBruto.ReadOnly = True
        Me.xtxt_MontoBruto.Requiered = False
        Me.xtxt_MontoBruto.Size = New System.Drawing.Size(136, 29)
        Me.xtxt_MontoBruto.StatusBarPanelDescripcion = Nothing
        Me.xtxt_MontoBruto.TabIndex = 20
        Me.xtxt_MontoBruto.Text = ""
        Me.xtxt_MontoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(648, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 22)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Itbis:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_Itbis
        '
        Me.xtxt_Itbis.AcceptsReturn = True
        Me.xtxt_Itbis.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcotizm.itbis"))
        Me.xtxt_Itbis.EditInitialValue = Nothing
        Me.xtxt_Itbis.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_Itbis.FieldDescription = ""
        Me.xtxt_Itbis.FindInitialValue = Nothing
        Me.xtxt_Itbis.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_Itbis.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_Itbis.IgnoreRequiered = False
        Me.xtxt_Itbis.Location = New System.Drawing.Point(704, 152)
        Me.xtxt_Itbis.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxt_Itbis.Name = "xtxt_Itbis"
        Me.xtxt_Itbis.NewInitialValue = Nothing
        Me.xtxt_Itbis.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_Itbis.Requiered = False
        Me.xtxt_Itbis.Size = New System.Drawing.Size(136, 29)
        Me.xtxt_Itbis.StatusBarPanelDescripcion = Nothing
        Me.xtxt_Itbis.TabIndex = 11
        Me.xtxt_Itbis.Text = ""
        Me.xtxt_Itbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xtxt_MontoNeto
        '
        Me.xtxt_MontoNeto.AcceptsReturn = True
        Me.xtxt_MontoNeto.EditInitialValue = Nothing
        Me.xtxt_MontoNeto.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_MontoNeto.FieldDescription = ""
        Me.xtxt_MontoNeto.FindInitialValue = Nothing
        Me.xtxt_MontoNeto.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_MontoNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_MontoNeto.IgnoreRequiered = False
        Me.xtxt_MontoNeto.Location = New System.Drawing.Point(704, 184)
        Me.xtxt_MontoNeto.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxt_MontoNeto.Name = "xtxt_MontoNeto"
        Me.xtxt_MontoNeto.NewInitialValue = Nothing
        Me.xtxt_MontoNeto.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_MontoNeto.ReadOnly = True
        Me.xtxt_MontoNeto.Requiered = False
        Me.xtxt_MontoNeto.Size = New System.Drawing.Size(136, 29)
        Me.xtxt_MontoNeto.StatusBarPanelDescripcion = Nothing
        Me.xtxt_MontoNeto.TabIndex = 33
        Me.xtxt_MontoNeto.TabStop = False
        Me.xtxt_MontoNeto.Text = ""
        Me.xtxt_MontoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(590, 184)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 22)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Monto Neto:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXGridDetalle
        '
        Me.LibXGridDetalle.AllowSorting = False
        Me.LibXGridDetalle.AutoAdjustLastColumn = True
        Me.LibXGridDetalle.AutoSearch = False
        Me.LibXGridDetalle.BackgroundColor = System.Drawing.Color.White
        Me.LibXGridDetalle.CaptionText = "Articulos"
        Me.LibXGridDetalle.ContextMenu = Me.ContextMenu1
        Me.LibXGridDetalle.DataMember = "ftcotizd"
        Me.LibXGridDetalle.DataSource = Me.DataSet1
        Me.LibXGridDetalle.FullRowSelect = False
        Me.LibXGridDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGridDetalle.IsReadOnly = False
        Me.LibXGridDetalle.Location = New System.Drawing.Point(0, 272)
        Me.LibXGridDetalle.Name = "LibXGridDetalle"
        Me.LibXGridDetalle.ReadOnly = True
        Me.LibXGridDetalle.searchText = ""
        Me.LibXGridDetalle.showFooterBar = True
        Me.LibXGridDetalle.Size = New System.Drawing.Size(856, 240)
        Me.LibXGridDetalle.TabIndex = 2
        Me.LibXGridDetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGridDetalle.UseAutoFillLines = True
        Me.LibXGridDetalle.UseHandCursor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Borrar esta linea"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Refrescar"
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGridDetalle
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColitem_code, Me.gColwhse_code, Me.gColitem_name, Me.GridColQty, Me.gColUnit_code, Me.GColprice, Me.gColdscto, Me.gColIbis, Me.gColImporte})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ftcotizd"
        '
        'gColitem_code
        '
        Me.gColitem_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColitem_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColitem_code.executeFindDuringFill = False
        Me.gColitem_code.Format = ""
        Me.gColitem_code.FormatInfo = Nothing
        Me.gColitem_code.HeaderText = "Producto"
        Me.gColitem_code.isReadOnly = False
        Me.gColitem_code.Lookup = Me.xlk_item_code
        Me.gColitem_code.MappingName = "item_code"
        Me.gColitem_code.MaxLength = 32767
        Me.gColitem_code.TabStop = True
        Me.gColitem_code.UseCustomCellFormat = False
        Me.gColitem_code.Width = 110
        '
        'xlk_item_code
        '
        Me.xlk_item_code.AlternateFieldSearch = "barra"
        Me.xlk_item_code.BeginCheck = False
        Me.xlk_item_code.CheckText = "Existencia mayor  que Cero (> 0)"
        Me.xlk_item_code.ComboMode = False
        Me.xlk_item_code.DataMember = Nothing
        Me.xlk_item_code.DataSource = Me.LibXConnector1
        Me.xlk_item_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "unit_code=unit_code", "existencia=existencia", "costo=purch_cost", "prov_name=prov_name", "ubicacion=ubicacion", "aplica_dscnt=aplica_dscnt", "whse_code=whse_code"}
        Me.xlk_item_code.FilterField = "item_name"
        Me.xlk_item_code.IgnoreFindInBrowseMode = True
        Me.xlk_item_code.isCanceled = False
        Me.xlk_item_code.Location = New System.Drawing.Point(437, 298)
        Me.xlk_item_code.LookCaption = "Productos"
        Me.xlk_item_code.Name = "xlk_item_code"
        Me.xlk_item_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_item_code.ShowFilter = True
        Me.xlk_item_code.ShowMessageNotFound = True
        Me.xlk_item_code.ShowWarning = False
        Me.xlk_item_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_item_code.SizesColumns = New String() {"item_name=400"}
        Me.xlk_item_code.SizesColumnsTab = Nothing
        Me.xlk_item_code.SqlString = New String() {"SELECT DISTINCT ivitemv1.item_code,", "ivitemv1.whse_code,", "item_name,", "ivitemv1.unit_code,", "price,", "existencia,", "ivitemv1.prov_code,", "purch_cost,", "ubicacion,", "cpprovm.prov_name,", "aplica_dscnt,", "0 dscto,", "precioitbis", "FROM ivitemv1", "LEFT OUTER JOIN ivcbarram", "ON ivcbarram.item_code = ivitemv1.item_code", "AND (ivitemv1.unit_code = ivcbarram.unit_code OR ivcbarram.unit_code is null)", "INNER JOIN cpprovm", "ON cpprovm.prov_code = ivitemv1.prov_code"}
        Me.xlk_item_code.SQLTab = Nothing
        Me.xlk_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.xlk_item_code.TabIndex = 21
        Me.xlk_item_code.TableName = "ivitemv1"
        Me.xlk_item_code.TabStop = False
        Me.xlk_item_code.UseCopyConnection = False
        Me.xlk_item_code.UseRowRetrieveEvents = False
        Me.xlk_item_code.UseTab = False
        Me.xlk_item_code.VisParameters = New String() {"Nombre=item_name", "Unidad=unit_code", "Precio=price", "Precio+ITBIS=precioitbis", "Existencia=existencia", "Ubicacion=Ubicacion", "Producto=item_code"}
        Me.xlk_item_code.WhereCondition = Nothing
        Me.xlk_item_code.WhereParameters = Nothing
        '
        'gColwhse_code
        '
        Me.gColwhse_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColwhse_code.Format = ""
        Me.gColwhse_code.FormatInfo = Nothing
        Me.gColwhse_code.ImageList = Nothing
        Me.gColwhse_code.isReadOnly = False
        Me.gColwhse_code.MappingName = "whse_code"
        Me.gColwhse_code.MaxLength = 32767
        Me.gColwhse_code.ReadOnly = True
        Me.gColwhse_code.TabStop = True
        Me.gColwhse_code.UseCustomCellFormat = False
        Me.gColwhse_code.Width = 0
        '
        'gColitem_name
        '
        Me.gColitem_name.Format = ""
        Me.gColitem_name.FormatInfo = Nothing
        Me.gColitem_name.HeaderText = "Descripción"
        Me.gColitem_name.MappingName = "item_name"
        Me.gColitem_name.ReadOnly = True
        Me.gColitem_name.Width = 225
        '
        'GridColQty
        '
        Me.GridColQty.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.GridColQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.GridColQty.Format = "##,###.#0"
        Me.GridColQty.FormatInfo = Nothing
        Me.GridColQty.HeaderText = "Cantidadi"
        Me.GridColQty.ImageList = Nothing
        Me.GridColQty.isReadOnly = False
        Me.GridColQty.MappingName = "qty"
        Me.GridColQty.MaxLength = 32767
        Me.GridColQty.TabStop = True
        Me.GridColQty.UseCustomCellFormat = False
        Me.GridColQty.Width = 75
        '
        'gColUnit_code
        '
        Me.gColUnit_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColUnit_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColUnit_code.executeFindDuringFill = False
        Me.gColUnit_code.Format = ""
        Me.gColUnit_code.FormatInfo = Nothing
        Me.gColUnit_code.HeaderText = "Unidad"
        Me.gColUnit_code.isReadOnly = False
        Me.gColUnit_code.Lookup = Me.xlk_unit_code
        Me.gColUnit_code.MappingName = "unit_code"
        Me.gColUnit_code.MaxLength = 32767
        Me.gColUnit_code.TabStop = True
        Me.gColUnit_code.UseCustomCellFormat = False
        Me.gColUnit_code.Width = 75
        '
        'xlk_unit_code
        '
        Me.xlk_unit_code.AlternateFieldSearch = Nothing
        Me.xlk_unit_code.BeginCheck = False
        Me.xlk_unit_code.CheckText = Nothing
        Me.xlk_unit_code.ComboMode = False
        Me.xlk_unit_code.DataMember = Nothing
        Me.xlk_unit_code.DataSource = Me.LibXConnector1
        Me.xlk_unit_code.DestParameters = New String() {"unit_code=unit_code"}
        Me.xlk_unit_code.FilterField = Nothing
        Me.xlk_unit_code.IgnoreFindInBrowseMode = True
        Me.xlk_unit_code.isCanceled = False
        Me.xlk_unit_code.Location = New System.Drawing.Point(429, 290)
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
        Me.xlk_unit_code.TabIndex = 20
        Me.xlk_unit_code.TableName = "ivunitv"
        Me.xlk_unit_code.TabStop = False
        Me.xlk_unit_code.UseCopyConnection = False
        Me.xlk_unit_code.UseRowRetrieveEvents = False
        Me.xlk_unit_code.UseTab = False
        Me.xlk_unit_code.VisParameters = New String() {"Codigo=unit_code", "Unidad=unit_name", "Factor=factor"}
        Me.xlk_unit_code.WhereCondition = "unit_type in (1,3)"
        Me.xlk_unit_code.WhereParameters = Nothing
        '
        'GColprice
        '
        Me.GColprice.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.GColprice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.GColprice.Format = "##,###,##0.00"
        Me.GColprice.FormatInfo = Nothing
        Me.GColprice.HeaderText = "Precioi"
        Me.GColprice.ImageList = Nothing
        Me.GColprice.isReadOnly = False
        Me.GColprice.MappingName = "price"
        Me.GColprice.MaxLength = 32767
        Me.GColprice.TabStop = True
        Me.GColprice.UseCustomCellFormat = False
        Me.GColprice.Width = 80
        '
        'gColdscto
        '
        Me.gColdscto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColdscto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColdscto.Format = "##,###,##0.00"
        Me.gColdscto.FormatInfo = Nothing
        Me.gColdscto.HeaderText = "Descuentoi"
        Me.gColdscto.ImageList = Nothing
        Me.gColdscto.isReadOnly = False
        Me.gColdscto.MappingName = "dscto"
        Me.gColdscto.MaxLength = 32767
        Me.gColdscto.TabStop = True
        Me.gColdscto.UseCustomCellFormat = False
        Me.gColdscto.Width = 75
        '
        'gColIbis
        '
        Me.gColIbis.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColIbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColIbis.Format = "##,###,##0.00"
        Me.gColIbis.FormatInfo = Nothing
        Me.gColIbis.HeaderText = "Itbisi"
        Me.gColIbis.ImageList = Nothing
        Me.gColIbis.isReadOnly = False
        Me.gColIbis.MappingName = "itbis"
        Me.gColIbis.MaxLength = 32767
        Me.gColIbis.ReadOnly = True
        Me.gColIbis.TabStop = True
        Me.gColIbis.UseCustomCellFormat = False
        Me.gColIbis.Width = 80
        '
        'gColImporte
        '
        Me.gColImporte.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColImporte.Format = "##,###,##0.00"
        Me.gColImporte.FormatInfo = Nothing
        Me.gColImporte.HeaderText = "Importei"
        Me.gColImporte.MappingName = "Importe"
        Me.gColImporte.ReadOnly = True
        Me.gColImporte.Width = 75
        '
        'txt_item_name
        '
        Me.txt_item_name.AcceptsReturn = True
        Me.txt_item_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftcotizd.item_name"))
        Me.txt_item_name.EditInitialValue = Nothing
        Me.txt_item_name.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txt_item_name.FieldDescription = ""
        Me.txt_item_name.FindInitialValue = Nothing
        Me.txt_item_name.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txt_item_name.IgnoreRequiered = False
        Me.txt_item_name.Location = New System.Drawing.Point(72, 544)
        Me.txt_item_name.Name = "txt_item_name"
        Me.txt_item_name.NewInitialValue = Nothing
        Me.txt_item_name.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txt_item_name.ReadOnly = True
        Me.txt_item_name.Requiered = False
        Me.txt_item_name.Size = New System.Drawing.Size(680, 20)
        Me.txt_item_name.StatusBarPanelDescripcion = Nothing
        Me.txt_item_name.TabIndex = 8
        Me.txt_item_name.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(8, 544)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Producto:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'i_ftfact11
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(874, 600)
        Me.Controls.Add(Me.xlk_item_code)
        Me.Controls.Add(Me.xlk_unit_code)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_item_name)
        Me.Controls.Add(Me.LibXGridDetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ftfact11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cotizaciones"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftcotizm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftcotizd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim mAutorizando As Boolean = False
    '//Dim mCli As ParametroCliente
    Dim mSerial As Integer
    Dim mPricemajor As Boolean
    Dim mRowIvSetup As DataRow
    Dim mConf As SGT.Inventario.Common.Configuration
    Dim mFactNum As Integer
    Dim WhereStmt As String
    Dim oDocumento As SGT.Inventario.Entidades.Documento
    Dim oProducto As SGT.Inventario.Entidades.Articulo
    Dim mlineNo As Integer
    Dim PorcDescuento As Integer
    Dim oPermission As SGT.Administracion.Entidades.Permission
    Dim mUnid As String
    Dim oCalItbis As SGT.Inventario.Entidades.Articulo.ParametrosCalcularItbis

    Private Sub i_ftfact01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mConf = New SGT.Inventario.Common.Configuration
            oProducto = New SGT.Inventario.Entidades.Articulo
            oPermission = New SGT.Administracion.Entidades.Permission

            ftcotizd.Columns("Importe").Expression = "(isnull(qty,0)*isnull(price,0))-isnull(dscto,0)+isnull(itbis,0)"
            LibXGridDetalle.footerOperations.add("qty", "count(qty)")
            LibXGridDetalle.footerOperations.add("dscto", "sum(dscto)")
            LibXGridDetalle.footerOperations.add("itbis", "sum(itbis)")
            LibXGridDetalle.footerOperations.add("Importe", "sum(Importe)")

            If Not LibXConnector1.Parameters Is Nothing Then
                If LibXConnector1.Parameters.Value.ToString.Length > 0 Then
                    WhereStmt = "ftcotizm.cotiz_serial = " & LibXConnector1.Parameters.Value.ToString
                    LibXConnector1.ExecuteFind(WhereStmt)
                End If
            End If
            oDocumento = New SGT.Inventario.Entidades.Documento("COT")
            Me.xlk_item_code.CheckText = "Existencia mayor de 0"

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub
    Private Sub xlk_unit_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_unit_code.BeforeExecuteQuery
        Try
            e.aditionalWhere = "item_code = '" & LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColitem_code) & "'"
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub
    Private Sub ftfactd_ColumnChanging(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles ftcotizd.ColumnChanging
        Try
            If e.Column.ColumnName = "unit_code" Then
                mUnid = e.Row!unit_code.ToString.Trim
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub xlk_unit_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_unit_code.AfterSetValues
        Try
            If e.dataFound = False Then
                LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, gColUnit_code, mUnid)
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub xlk_unit_code_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_unit_code.BeforeSetValues
        Dim Costo As Decimal
        Dim Factor As Decimal
        Dim oUnidad As UnidadMedida
        Dim oParam As UnidadMedida.ParametroConvertirValor
        Dim Unidad As String

        If e.dataFound = False Then
            Exit Sub
        End If

        Try
            If LibXConnector1.IsDataEditing = True And mUnid.Trim <> "" Then
                oUnidad = New UnidadMedida
                oParam = New UnidadMedida.ParametroConvertirValor
                oParam.Valor = LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, GColprice)
                oParam.Producto = LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, gColitem_code)
                oParam.UnidadDestino = e.row!unit_code.ToString.Trim
                oParam.UnidadOrigen = mUnid

                oUnidad.ConvertirValor(oParam)

                LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, GColprice, oParam.Retorno.Valor)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub
    Private Sub xlk_item_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_item_code.AfterSetValues
        Try

            If e.dataFound = False Then
                Exit Sub
            End If

            If Me.LibXConnector1.IsDataEditing = True Then
                If oDocumento.AplicarPrecio = True Then
                    LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.GColprice, e.row!price)
                Else
                    LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.GColprice, e.row!purch_cost)
                End If

                If LibX.IsNull(e.row!dscto) = False AndAlso CDec(e.row!dscto) > 0 Then
                    LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.gColdscto, e.row!dscto)
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub


    Private Sub LibXGridDetalle_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGridDetalle.CellValidate
        Try

            If Me.GridColQty.Column = e.cell Then
                '// CANTIDAD
                If IsNull(Me.gColitem_code.GetValue) Then
                    Me.LibXGridDetalle.Focus(e.row, 0)
                    Exit Sub
                End If

                If IsNull(e.value) Then
                    e.hasErrors = True
                    Exit Sub
                End If

                Dim oRow As DataRow
                Dim sSql As String
                Dim IWhse_code As Integer = Val(Me.gColwhse_code.GetValue.ToString)


                Dim Precio As Decimal = 0
                Dim Qty As Integer = e.value

                If Trim(Me.LibXGridDetalle.GetValue(GColprice)) <> "" Then
                    Precio = Me.LibXGridDetalle.GetValue(GColprice)
                End If
            End If

            '// DESCUENTO
            If Me.gColdscto.Column = e.cell Then
                If IsNull(Me.gColitem_code.GetValue) Then
                    Me.LibXGridDetalle.Focus(e.row, 0)
                    Exit Sub
                End If

                Dim descto As Decimal
                Dim Importe As Decimal

                descto = Val(e.value.ToString)
                Importe = Me.LibXGridDetalle.GetValue(GColprice) * Me.LibXGridDetalle.GetValue(GridColQty)

                If descto >= Importe Then
                    Me.gColdscto.SetValue(0)
                    Throw New ApplicationException("Descuento no puede ser mayor o igual que el importe")
                End If
            End If

            '// PRECIO
            If Me.LibXGridDetalle.GetColNum(GColprice) = e.cell Then
                If IsNull(Me.gColitem_code.GetValue) Then
                    Me.LibXGridDetalle.Focus(e.row, 0)
                    Exit Sub
                End If

                If IsNull(e.value) Then
                    e.hasErrors = True
                    Exit Sub
                End If

                Dim Precio As Decimal = e.value
                Dim Qty As Decimal = 0

                If Trim(Me.GridColQty.GetValue) <> "" Then
                    qty = Me.GridColQty.GetValue
                End If
            End If

            '// CANTIDAD
            If Me.GridColQty.Column = e.cell Then
                If IsNull(Me.gColitem_code.GetValue) Then
                    Me.LibXGridDetalle.Focus(e.row, 0)
                    Exit Sub
                End If

                LibXGridDetalle.SelectNextControl(Me.LibXGridDetalle, True, False, False, True)

                If e.row = Me.LibXGridDetalle.getCurrentGridView.Count - 1 Then
                    SendKeys.Send("{TAB}")
                End If
            End If

        Catch ex As Exception
            e.hasErrors = True
            Log.Add(ex, True)

        Finally
            CalcularITBIS()
            ActualizaTotal()
        End Try
    End Sub

    Private Sub CalcularITBIS(Optional ByVal Index As Integer = -1)
        Dim Itbis As Decimal
        Dim Qty As Decimal
        Dim Price As Decimal
        Dim Descto As Decimal

        Try

            If Index = -1 Then
                Index = LibXGridDetalle.CurrentRowIndex
            End If

            If Val(LibXGridDetalle.GetValue(Index, Me.GridColQty)) <= 0 Then
                Exit Sub
            End If
            If Val(LibXGridDetalle.GetValue(Index, Me.GColprice)) <= 0 Then
                Exit Sub
            End If
            oCalItbis = New SGT.Inventario.Entidades.Articulo.ParametrosCalcularItbis
            Qty = Val(LibXGridDetalle.GetValue(Index, Me.GridColQty).ToString)
            Price = Val(LibXGridDetalle.GetValue(Index, Me.GColprice).ToString)
            Descto = Val(LibXGridDetalle.GetValue(Index, Me.gColdscto).ToString)

            With oCalItbis
                .Producto = LibXGridDetalle.Item(Index, 0)
                .Almacen = LibXGridDetalle.Item(Index, 1)
                .Monto = (Qty * Price) - Descto
            End With

            Itbis = oProducto.CalcularItbis(oCalItbis)

            LibXGridDetalle.SetValue(Index, Me.gColIbis, Itbis)

        Catch ex As Exception
            LibX.Log.Add(ex, True)

        End Try
    End Sub

    Private Sub ActualizaTotal()
        Try
            Dim i As Integer
            Dim tPrice As Decimal = 0
            Dim tDesc As Decimal
            Dim oPrice As Decimal
            Dim oDesc As Decimal
            Dim oValue As Object
            Dim oCant As Decimal
            Dim TCant As Decimal = 0
            Dim Titb As Decimal = 0
            Dim itb As Decimal = 0
            Dim costo As Decimal
            Dim total As Decimal = 0

            For i = 0 To Me.LibXGridDetalle.getCurrentGridView.Count - 1
                oPrice = 0
                oDesc = 0
                oCant = 0
                itb = 0
                costo = 0

                oValue = Me.LibXGridDetalle.GetValue(i, Me.gColIbis)
                If Not IsNull(oValue) Then
                    itb = oValue
                End If

                oValue = Me.LibXGridDetalle.GetValue(i, Me.GridColQty)
                If Not IsNull(oValue) Then
                    oCant = oValue
                End If

                oValue = Me.LibXGridDetalle.GetValue(i, Me.GColprice)
                If Not IsNull(oValue) Then
                    oPrice = oValue
                End If

                oValue = Me.LibXGridDetalle.GetValue(i, Me.gColdscto)
                If Not IsNull(oValue) Then
                    oDesc = oValue
                End If

                tPrice = tPrice + oPrice
                tDesc = tDesc + oDesc
                TCant = TCant + oCant
                Titb = Titb + itb
                total += oCant * oPrice
            Next

            Me.xtxt_MontoBruto.Text = CDec(total).ToString("###,###,##0.00")
            Me.xtxt_Descto.Text = tDesc.ToString("###,###,##0.00")
            Me.xtxt_Itbis.Text = Titb.ToString("###,###,##0.00")
            Me.xtxt_MontoNeto.Text = CDec(total - tDesc + Titb).ToString("###,###,##0.00")

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub lkp_item_code_AfterSetValues(ByVal sender As System.Object, ByVal e As LibX.LookupValuesEventArgs)
        Try

            If Not Me.LibXConnector1.IsEditing Then
                Exit Sub
            End If

            If e.dataFound = False Then
                Exit Sub
            End If

            txt_item_name.Text = e.row!item_name

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub


    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                Dim intLast As Object
                Dim sSql As String

                ActualizaTotal()

                e.UpdatingArgs.Row!type_code = "COT"
                e.UpdatingArgs.Row!cotz_status = 1 ' "Pendiente de despacho" (1)  en la table ivfactm\
                e.UpdatingArgs.Row!cotiz_number = oDocumento.GenerateNumber("COT")
            End If

        Catch ex As Exception
            Log.Show(ex)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
        End Try
    End Sub

    Private Sub Distribuye_descuento(Optional ByVal PorcDescuento As Integer = 0, Optional ByVal PorcCobertura As Integer = 0)
        Dim MontoDescuento As Decimal
        Dim MontoSeguro As Decimal
        Dim MontoBruto As Decimal
        Try
            If Val(Me.xtxt_Descto.Text.Trim) > 0 Then
                MontoDescuento = CType(Me.xtxt_Descto.Text, Decimal)
                MontoSeguro = Val(ftcotizd.Compute("sum(importe)", "1=1").ToString.Trim)
                MontoBruto = Val(ftcotizd.Compute("sum(importe)", "1=1").ToString.Trim)

                For Each oRow As DataRow In ftcotizd.Rows
                    '// Descuento del producto = Total de descuento * (Porciento entre el monto de productos q aplican para descuento)
                    oRow!Dscto = MontoDescuento * (Val(oRow!Importe.tostring.Trim) / MontoBruto)

                    If LibX.IsNull(orow!itbis) = False AndAlso Val(orow!itbis.tostring.Trim) > 0 Then
                        oCalItbis = New SGT.Inventario.Entidades.Articulo.ParametrosCalcularItbis

                        With oCalItbis
                            .Almacen = Val(oRow!whse_code.tostring.Trim)
                            .Producto = orow!item_code
                            .Monto = (Val(orow!price.tostring.Trim) * _
                                      Val(orow!qty.tostring.Trim)) - _
                                      Val(orow!dscto.tostring.Trim)
                        End With

                        orow!itbis = oProducto.CalcularItbis(oCalItbis)
                    End If
                Next
            Else
                For Each oRow As DataRow In ftcotizd.Rows
                    oRow!Dscto = DBNull.Value
                Next
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            If e.Action = LibxConnectionActions.Add Or e.Action = LibxConnectionActions.Edit Then
                mlineNo = 0
                If mRowIvSetup Is Nothing Then
                    mRowIvSetup = LibX.Data.Manager.GetDataRow("Select * from ivsetup")
                    If mRowIvSetup Is Nothing Then
                        Throw New Exception("No se encuentra la configuración de inventario")
                    End If
                End If
            End If
        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub lkCliente_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkCliente.AfterSetValues
        Try
            If Not LibXConnector1.IsDataEditing = True Then
                Exit Sub
            End If

            If e.dataFound = False Then
                Exit Sub
            End If
        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub lkCliente_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lkCliente.BeforeExecuteQuery
        e.aditionalWhere = "cccustm.cust_status <> 0 "
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try

            Me.DateTimePicker1.Value = LibX.Data.Manager.Connection.GetDate.ToString("d")

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    ''Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
    ''    Dim SelecStmt As String
    ''    Dim AxCrystalReport1 As LibX.ReportLib

    ''    Try
    ''        Me.Cursor = Cursors.Default
    ''        If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
    ''            '// Tomar el Connection String del config
    ''            AxCrystalReport1 = New LibX.ReportLib("FCT", "r_ftcotiz01.rpt")

    ''            With AxCrystalReport1
    ''                '// Recibir el SQL Query
    ''                .RetrieveSQLQuery()
    ''                SelecStmt = .SQLQuery
    ''                SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, "ftcotizm.cotiz_serial = " & LibXConnector1.CurrentDataRow!cotiz_serial)
    ''                .SQLQuery = SelecStmt

    ''                '// Ejecutar el reporte
    ''                .Action = 1
    ''            End With
    ''        End If

    ''    Catch ex As Exception
    ''        LibX.Log.Add(ex, True)

    ''    Finally
    ''        Me.Cursor = Cursors.Default
    ''        AxCrystalReport1 = Nothing
    ''    End Try
    ''End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            Dim scratch As String
            e.AditionalWhere = "type_code='COT'"
            WhereStmt = e.Where
            scratch = e.Sql
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub lkp_item_code_CreatedGridColumns(ByVal sender As System.Object, ByVal e As LibX.CreatedGridColumnsEventArgs)
        Try
            e.TStyle.GridColumnStyles.Item("item_name").Width = 300

            e.Grid.Parent.Width = e.Grid.Parent.Width + 300

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub LibXGridDetalle_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LibXGridDetalle.CurrentCellChanged
        Try
            If LibXConnector1.IsEditing = True Then
                If LibXGridDetalle.CurrentCell.ColumnNumber >= _
                LibXGridDetalle.TableStyles(0).GridColumnStyles.IndexOf(gColitem_name) Then
                    ActualizaTotal()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Try
            If LibXGridDetalle.CurrentRowIndex > -1 Then
                If MessageBox.Show("Seguro desea borrar este item?", "Borrar Linea", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    If ftcotizd.Rows.Count > LibXGridDetalle.CurrentRowIndex Then
                        ftcotizd.Rows.RemoveAt(LibXGridDetalle.CurrentRowIndex)
                    End If
                    ActualizaTotal()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_ValidatingControls(ByVal sender As Object, ByVal e As LibX.ValidatingControlsEventArgs) Handles LibXConnector1.ValidatingControls
        If IsNull(Me.DateTimePicker1.Value) Then
            Me.DateTimePicker1.Value = LibX.Data.Manager.Connection.GetDate.ToString("d")
        End If
    End Sub

    Private Sub rbt_Lista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If LibXConnector1.IsEditing = True Then
                If Not LibXConnector1.CurrentDataRow Is Nothing Then
                    LibXConnector1.CurrentDataRow!price_type = 1
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub rbt_porMayor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If LibXConnector1.IsEditing = True Then
                If Not LibXConnector1.CurrentDataRow Is Nothing Then
                    LibXConnector1.CurrentDataRow!price_type = 2
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub rbt_Minimo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If LibXConnector1.IsEditing = True Then
                If Not LibXConnector1.CurrentDataRow Is Nothing Then
                    LibXConnector1.CurrentDataRow!price_type = 3
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterLoadDetail(ByVal sender As Object, ByVal e As LibX.XbeforeLoadDetailEventArgs) Handles LibXConnector1.AfterLoadDetail
        Try
            If Not LibXConnector1.IsEditing Then
                ActualizaTotal()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        Try
            For Each oRow As DataRow In ftcotizd.Rows
                If oRow.RowState <> DataRowState.Deleted Then
                    If LibX.IsNull(oRow!line_no) Then
                        oRow!line_no = Val(ftcotizd.Compute("max(line_no)", "").ToString.Trim) + 1
                    End If
                End If
            Next

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub lkp_item_code_CheckedChanged(ByVal sender As System.Object, ByVal e As LibX.CheckedChangedEventArgs)
        If e.CheckStatus = True Then
            e.Table.DefaultView.RowFilter = "existencia > 0"
        Else
            e.Table.DefaultView.RowFilter = ""
        End If
    End Sub

    Private Sub xtxt_Descto_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles xtxt_Descto.Validated
        Try

            If LibXConnector1.CurrentAction <> LibxConnectionActions.Cancel AndAlso LibXConnector1.IsDataEditing = True Then
                Distribuye_descuento()
                ActualizaTotal()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub xtxt_Descto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_Descto.Validating
        Dim MontoBruto As Decimal
        Dim Descuento As Decimal
        Dim Porc_Descuento As Integer
        Try

            If Me.xtxt_MontoBruto.Text.Trim = "" Then
                If Val(Me.xtxt_Descto.Text.Trim) > 0 Then
                    e.Cancel = True
                End If

                Exit Sub
            End If

            If Me.xtxt_Descto.Text.Trim = "" Then
                Exit Sub
            End If

            MontoBruto = Val(ftcotizd.Compute("sum(importe)", "1=1").ToString.Trim) + Val(ftcotizd.Compute("sum(dscto)", "1=1").ToString.Trim)

            If MontoBruto <= 0 Then
                Throw New ApplicationException("No hay productos que apliquen para descuento!")
                Exit Sub
            End If

            If xtxt_Descto.Text.EndsWith("%") Then
                Porc_Descuento = Val(Me.xtxt_Descto.Text.Substring(0, xtxt_Descto.Text.IndexOf("%")).Trim)
                Descuento = MontoBruto * (Porc_Descuento / 100)
                Me.xtxt_Descto.Text = Descuento
            Else
                Descuento = Me.xtxt_Descto.Text
            End If

            If (Descuento > MontoBruto) Then
                Throw New ApplicationException("Descuento no puede ser mayor q el monto total del documento!")
            End If

            '//EMR
            If (Descuento / MontoBruto) >= 0.75 Then
                Throw New ApplicationException("Descuento muy alto para este documento!")
            End If

        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
            Me.xtxt_Descto.Text = ""
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            Dim fEcha As DateTime
            If LibXConnector1.HasRecords = True Then
                If Not e.row Is Nothing Then
                    fEcha = LibX.Data.Manager.Connection.GetDate.ToString("d")
                    If LibX.IsNull(e.row!cotz_status) = False AndAlso e.row!cotz_status = 1 And _
                                                LibXConnector1.CurrentDataRow!cotiz_date <> fEcha Then
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
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class


