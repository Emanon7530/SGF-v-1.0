Imports LibX
Public Class i_ftfact01
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
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents STftfactm As LibX.LibXDbSourceTable
    Friend WithEvents STfactd As LibX.LibXDbSourceTable
    Friend WithEvents cust_name As System.Windows.Forms.TextBox
    Friend WithEvents vend_name As System.Windows.Forms.TextBox
    Friend WithEvents lkp_item_code As LibX.LibXLookup
    Friend WithEvents DataSet1 As System.Data.DataSet
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents txtClinombre As System.Windows.Forms.TextBox
    Friend WithEvents rdbContado As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCredito As System.Windows.Forms.RadioButton
    Friend WithEvents GridColQty As LibX.XEditTextBoxColumn
    Friend WithEvents LibXGridDetalle As LibX.LibXGrid
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents GColprice As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gColdscto As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gColImporte As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gColitem_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gColExist As LibX.XEditTextBoxColumn
    Friend WithEvents lkCliente As LibX.LibXLookup
    Friend WithEvents btnCli As System.Windows.Forms.Button
    Friend WithEvents txtDec As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoBruto As System.Windows.Forms.TextBox
    Friend WithEvents gColitem_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents gColwhse_code As LibX.XEditTextBoxColumn
    Friend WithEvents gColIbis As LibX.XEditTextBoxColumn
    Friend WithEvents txtITbis As System.Windows.Forms.TextBox
    Friend WithEvents txtCliCodigo As System.Windows.Forms.TextBox
    Friend WithEvents gColCosto As LibX.XEditTextBoxColumn
    Friend WithEvents lbx_fact_status As LibX.LibXCombo
    Friend WithEvents cbo_price As LibX.LibxCheckBox
    Friend WithEvents Disc_days As System.Windows.Forms.TextBox
    Friend WithEvents Due_days As System.Windows.Forms.TextBox
    Friend WithEvents Disc_pct As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents txtfact_number As LibX.XTextBox
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents txtvend_code As System.Windows.Forms.TextBox
    Friend WithEvents xlk_vend_code As LibX.LibXLookup
    Friend WithEvents term_name As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents xlk_term_code As LibX.LibXLookup
    Friend WithEvents xtxt_term_code As System.Windows.Forms.TextBox
    Friend WithEvents ftfactm As System.Data.DataTable
    Friend WithEvents ftfactd As System.Data.DataTable
    Friend WithEvents gbx_Condicion As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_item_name As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(i_ftfact01))
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ftfactm = New System.Data.DataTable
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
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.ftfactd = New System.Data.DataTable
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
        Me.DataColumn33 = New System.Data.DataColumn
        Me.STftfactm = New LibX.LibXDbSourceTable
        Me.STfactd = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.xlk_term_code = New LibX.LibXLookup
        Me.Label6 = New System.Windows.Forms.Label
        Me.term_name = New System.Windows.Forms.TextBox
        Me.btnCli = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.gbx_Condicion = New System.Windows.Forms.GroupBox
        Me.rdbContado = New System.Windows.Forms.RadioButton
        Me.rdbCredito = New System.Windows.Forms.RadioButton
        Me.DateTimePicker1 = New LibX.LibxDateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbo_price = New LibX.LibxCheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Disc_days = New System.Windows.Forms.TextBox
        Me.Due_days = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Disc_pct = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.lkCliente = New LibX.LibXLookup
        Me.lbx_fact_status = New LibX.LibXCombo
        Me.cust_name = New System.Windows.Forms.TextBox
        Me.txtCliCodigo = New System.Windows.Forms.TextBox
        Me.txtfact_number = New LibX.XTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMontoBruto = New System.Windows.Forms.TextBox
        Me.txtDec = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtITbis = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtClinombre = New System.Windows.Forms.TextBox
        Me.xtxt_term_code = New System.Windows.Forms.TextBox
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.vend_name = New System.Windows.Forms.TextBox
        Me.txtvend_code = New System.Windows.Forms.TextBox
        Me.xlk_vend_code = New LibX.LibXLookup
        Me.Label16 = New System.Windows.Forms.Label
        Me.LibXGridDetalle = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColitem_code = New LibX.XDataGridTextButtonColumn
        Me.lkp_item_code = New LibX.LibXLookup
        Me.gColwhse_code = New LibX.XEditTextBoxColumn
        Me.gColitem_name = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GridColQty = New LibX.XEditTextBoxColumn
        Me.GColprice = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColCosto = New LibX.XEditTextBoxColumn
        Me.gColExist = New LibX.XEditTextBoxColumn
        Me.gColdscto = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColIbis = New LibX.XEditTextBoxColumn
        Me.gColImporte = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txt_item_name = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbx_Condicion.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(770, 24)
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
        Me.LibXConnector1.DataMember = "ftfactm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.STftfactm, Me.STfactd})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftfactm, Me.ftfactd})
        '
        'ftfactm
        '
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn32, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37})
        Me.ftfactm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no"}, True)})
        Me.ftfactm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.ftfactm.TableName = "ftfactm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "ftserial_no"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "whse_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "cotiz_serial"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "cust_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "term_code"
        Me.DataColumn5.MaxLength = 5
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "addr_code"
        Me.DataColumn6.MaxLength = 8
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "fttp_code"
        Me.DataColumn7.MaxLength = 3
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "vend_code"
        Me.DataColumn8.MaxLength = 4
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "fact_number"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "fact_date"
        Me.DataColumn10.DataType = GetType(System.DateTime)
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "fact_total"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "descto"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "itbis"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "total_comision"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "userid"
        Me.DataColumn15.MaxLength = 20
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "fact_status"
        Me.DataColumn16.DataType = GetType(System.Int32)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "date_created"
        Me.DataColumn17.DataType = GetType(System.DateTime)
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "type_code"
        Me.DataColumn18.MaxLength = 3
        '
        'DataColumn32
        '
        Me.DataColumn32.AllowDBNull = False
        Me.DataColumn32.ColumnName = "fact_cond"
        Me.DataColumn32.DataType = GetType(System.Int16)
        '
        'DataColumn34
        '
        Me.DataColumn34.AllowDBNull = False
        Me.DataColumn34.ColumnName = "bus_name"
        Me.DataColumn34.MaxLength = 40
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "dev_type"
        Me.DataColumn35.MaxLength = 3
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "fact_nota"
        Me.DataColumn36.MaxLength = 80
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "ftserial_afect"
        Me.DataColumn37.DataType = GetType(System.Int32)
        '
        'ftfactd
        '
        Me.ftfactd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn33})
        Me.ftfactd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no", "line_no"}, True)})
        Me.ftfactd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn19, Me.DataColumn20}
        Me.ftfactd.TableName = "ftfactd"
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "ftserial_no"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.AutoIncrement = True
        Me.DataColumn20.AutoIncrementSeed = CType(1, Long)
        Me.DataColumn20.ColumnName = "line_no"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.AllowDBNull = False
        Me.DataColumn21.ColumnName = "item_code"
        Me.DataColumn21.MaxLength = 15
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "whse_code"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "item_name"
        Me.DataColumn23.MaxLength = 100
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.ColumnName = "qty"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "price"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "dscto"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "factor"
        Me.DataColumn27.DataType = GetType(System.Decimal)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "itbis"
        Me.DataColumn28.DataType = GetType(System.Decimal)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "costo"
        Me.DataColumn29.DataType = GetType(System.Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "unit_code"
        Me.DataColumn30.MaxLength = 5
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "Importe"
        Me.DataColumn31.DataType = GetType(System.Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "exist"
        Me.DataColumn33.DataType = GetType(System.Decimal)
        '
        'STftfactm
        '
        Me.STftfactm.AllowDelete = True
        Me.STftfactm.AllowEdit = True
        Me.STftfactm.AllowNew = True
        Me.STftfactm.AutoIncrementSerial = False
        Me.STftfactm.CustomDbUpdate = False
        Me.STftfactm.DeleteOrder = 0
        Me.STftfactm.FillOnQuery = True
        Me.STftfactm.FillOnRowChange = False
        Me.STftfactm.HeaderIsOnGrid = False
        Me.STftfactm.InsertOrder = 0
        Me.STftfactm.IsDetail = False
        Me.STftfactm.KeyFields = Nothing
        Me.STftfactm.MasterDetailRelation = Nothing
        Me.STftfactm.MasterTableName = Nothing
        Me.STftfactm.SerialColumnName = "ftserial_no"
        Me.STftfactm.Sort = Nothing
        Me.STftfactm.Source = Nothing
        Me.STftfactm.TableName = "ftfactm"
        Me.STftfactm.UpdateOrder = 0
        Me.STftfactm.UseRowRetrieve = False
        '
        'STfactd
        '
        Me.STfactd.AllowDelete = True
        Me.STfactd.AllowEdit = True
        Me.STfactd.AllowNew = True
        Me.STfactd.AutoIncrementSerial = True
        Me.STfactd.CustomDbUpdate = False
        Me.STfactd.DeleteOrder = 0
        Me.STfactd.FillOnQuery = True
        Me.STfactd.FillOnRowChange = True
        Me.STfactd.HeaderIsOnGrid = False
        Me.STfactd.InsertOrder = 0
        Me.STfactd.IsDetail = True
        Me.STfactd.KeyFields = "ftserial_no,line_no"
        Me.STfactd.MasterDetailRelation = New String() {"ftserial_no=ftserial_no"}
        Me.STfactd.MasterTableName = Nothing
        Me.STfactd.SerialColumnName = ""
        Me.STfactd.Sort = Nothing
        Me.STfactd.Source = New String() {"select ftfactd.ftserial_no,line_no,ftfactd.item_code,whse_code,", "item_name,qty,price,dscto,factor,itbis,costo,ftfactd.unit_code", "from ftfactd inner join ivitemm ", "on ftfactd.item_code=ivitemm.item_code"}
        Me.STfactd.TableName = "ftfactd"
        Me.STfactd.UpdateOrder = 0
        Me.STfactd.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.xlk_term_code)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.term_name)
        Me.GroupBox1.Controls.Add(Me.btnCli)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.gbx_Condicion)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lkCliente)
        Me.GroupBox1.Controls.Add(Me.lbx_fact_status)
        Me.GroupBox1.Controls.Add(Me.cust_name)
        Me.GroupBox1.Controls.Add(Me.txtCliCodigo)
        Me.GroupBox1.Controls.Add(Me.txtfact_number)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMontoBruto)
        Me.GroupBox1.Controls.Add(Me.txtDec)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtITbis)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtClinombre)
        Me.GroupBox1.Controls.Add(Me.xtxt_term_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 168)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(440, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 16)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Button1"
        '
        'xlk_term_code
        '
        Me.xlk_term_code.DataMember = Nothing
        Me.xlk_term_code.DataSource = Me.LibXConnector1
        Me.xlk_term_code.DestParameters = New String() {"term_code=term_code", "term_name=term_name", "disc_pct=disc_pct", "due_days=due_days", "disc_days=disc_days"}
        Me.xlk_term_code.FilterField = Nothing
        Me.xlk_term_code.IgnoreFindInBrowseMode = False
        Me.xlk_term_code.Location = New System.Drawing.Point(400, 136)
        Me.xlk_term_code.LookCaption = Nothing
        Me.xlk_term_code.Name = "xlk_term_code"
        Me.xlk_term_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_term_code.SqlString = Nothing
        Me.xlk_term_code.SrcParameters = New String() {"term_code=term_code"}
        Me.xlk_term_code.TabIndex = 15
        Me.xlk_term_code.TableName = "cctermm"
        Me.xlk_term_code.UseCopyConnection = False
        Me.xlk_term_code.UseRowRetrieveEvents = False
        Me.xlk_term_code.VisParameters = New String() {"Código=term_code", "Descripción=term_name", "% Descuento=disc_pct", "Vencimiento=due_days"}
        Me.xlk_term_code.WhereCondition = Nothing
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(16, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Termino:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'term_name
        '
        Me.term_name.Location = New System.Drawing.Point(144, 136)
        Me.term_name.Name = "term_name"
        Me.term_name.ReadOnly = True
        Me.term_name.Size = New System.Drawing.Size(256, 20)
        Me.term_name.TabIndex = 14
        Me.term_name.TabStop = False
        Me.term_name.Text = ""
        '
        'btnCli
        '
        Me.btnCli.Location = New System.Drawing.Point(376, 111)
        Me.btnCli.Name = "btnCli"
        Me.btnCli.Size = New System.Drawing.Size(24, 23)
        Me.btnCli.TabIndex = 11
        Me.btnCli.Text = "..."
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(16, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "A Nombre:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gbx_Condicion
        '
        Me.gbx_Condicion.Controls.Add(Me.rdbContado)
        Me.gbx_Condicion.Controls.Add(Me.rdbCredito)
        Me.gbx_Condicion.Enabled = False
        Me.gbx_Condicion.Location = New System.Drawing.Point(16, 40)
        Me.gbx_Condicion.Name = "gbx_Condicion"
        Me.gbx_Condicion.Size = New System.Drawing.Size(384, 40)
        Me.gbx_Condicion.TabIndex = 4
        Me.gbx_Condicion.TabStop = False
        Me.gbx_Condicion.Text = "Condición de venta"
        '
        'rdbContado
        '
        Me.rdbContado.Checked = True
        Me.rdbContado.Location = New System.Drawing.Point(16, 16)
        Me.rdbContado.Name = "rdbContado"
        Me.rdbContado.Size = New System.Drawing.Size(72, 16)
        Me.rdbContado.TabIndex = 0
        Me.rdbContado.TabStop = True
        Me.rdbContado.Text = "Contado"
        '
        'rdbCredito
        '
        Me.rdbCredito.Location = New System.Drawing.Point(88, 16)
        Me.rdbCredito.Name = "rdbCredito"
        Me.rdbCredito.Size = New System.Drawing.Size(72, 16)
        Me.rdbCredito.TabIndex = 1
        Me.rdbCredito.Text = "Crédito"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.fact_date"))
        Me.DateTimePicker1.EditInitialValue = Nothing
        Me.DateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.DateTimePicker1.FindInitialValue = Nothing
        Me.DateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.IgnoreRequiered = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(504, 16)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.NewInitialValue = ""
        Me.DateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.DateTimePicker1.Requiered = False
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbo_price)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Disc_days)
        Me.GroupBox2.Controls.Add(Me.Due_days)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Disc_pct)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(592, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 128)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Condición:"
        '
        'cbo_price
        '
        Me.cbo_price.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbo_price.EditInitialValue = Nothing
        Me.cbo_price.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.cbo_price.FindInitialValue = Nothing
        Me.cbo_price.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cbo_price.IgnoreRequiered = False
        Me.cbo_price.KeepEnabled = False
        Me.cbo_price.Location = New System.Drawing.Point(13, 88)
        Me.cbo_price.Name = "cbo_price"
        Me.cbo_price.NewInitialValue = Nothing
        Me.cbo_price.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.cbo_price.ReadOnly = True
        Me.cbo_price.Requiered = False
        Me.cbo_price.Size = New System.Drawing.Size(104, 16)
        Me.cbo_price.TabIndex = 6
        Me.cbo_price.Text = "Precio x Mayor"
        Me.cbo_price.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.cbo_price.ThreeState = True
        Me.cbo_price.value = Nothing
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Dias Descuento:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Disc_days
        '
        Me.Disc_days.Location = New System.Drawing.Point(104, 16)
        Me.Disc_days.Name = "Disc_days"
        Me.Disc_days.ReadOnly = True
        Me.Disc_days.Size = New System.Drawing.Size(40, 20)
        Me.Disc_days.TabIndex = 1
        Me.Disc_days.TabStop = False
        Me.Disc_days.Text = ""
        '
        'Due_days
        '
        Me.Due_days.Location = New System.Drawing.Point(104, 40)
        Me.Due_days.Name = "Due_days"
        Me.Due_days.ReadOnly = True
        Me.Due_days.Size = New System.Drawing.Size(40, 20)
        Me.Due_days.TabIndex = 3
        Me.Due_days.TabStop = False
        Me.Due_days.Text = ""
        '
        'Label15
        '
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(8, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 16)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Días Vencimiento:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Disc_pct
        '
        Me.Disc_pct.Location = New System.Drawing.Point(104, 64)
        Me.Disc_pct.Name = "Disc_pct"
        Me.Disc_pct.ReadOnly = True
        Me.Disc_pct.Size = New System.Drawing.Size(40, 20)
        Me.Disc_pct.TabIndex = 5
        Me.Disc_pct.TabStop = False
        Me.Disc_pct.Text = ""
        '
        'Label17
        '
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Location = New System.Drawing.Point(16, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 16)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "% Descuento:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lkCliente
        '
        Me.lkCliente.DataMember = Nothing
        Me.lkCliente.DataSource = Me.LibXConnector1
        Me.lkCliente.DestParameters = New String() {"cust_code=cust_code", "cust_name=cust_name", "txtClinombre=cust_name", "cbo_price=cust_pricemajor"}
        Me.lkCliente.FilterField = Nothing
        Me.lkCliente.IgnoreFindInBrowseMode = False
        Me.lkCliente.Location = New System.Drawing.Point(400, 88)
        Me.lkCliente.LookCaption = "Clientes"
        Me.lkCliente.Name = "lkCliente"
        Me.lkCliente.Size = New System.Drawing.Size(16, 20)
        Me.lkCliente.SqlString = New String() {"select cust_code,cust_name,cctermm.term_code,due_days,disc_days,disc_pct,cust_pri" & _
        "cemajor", "from cccustm inner join cctermm on cccustm.term_code = cctermm.term_code"}
        Me.lkCliente.SrcParameters = New String() {"cust_code=cust_code"}
        Me.lkCliente.TabIndex = 8
        Me.lkCliente.TableName = "cccustm"
        Me.lkCliente.UseCopyConnection = False
        Me.lkCliente.UseRowRetrieveEvents = False
        Me.lkCliente.VisParameters = New String() {"Código=cust_code", "Nombre=cust_name"}
        Me.lkCliente.WhereCondition = Nothing
        '
        'lbx_fact_status
        '
        Me.lbx_fact_status.AllowDefaultSort = True
        Me.lbx_fact_status.bound = True
        Me.lbx_fact_status.currValue = Nothing
        Me.lbx_fact_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.fact_status"))
        Me.lbx_fact_status.DefaultWhereString = Nothing
        Me.lbx_fact_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lbx_fact_status.EditInitialValue = Nothing
        Me.lbx_fact_status.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lbx_fact_status.FindInitialValue = Nothing
        Me.lbx_fact_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lbx_fact_status.IgnoreRequiered = False
        Me.lbx_fact_status.Items.AddRange(New Object() {"1-En almacen", "2-En Caja", "3-Despachada", "4-Anulada"})
        Me.lbx_fact_status.Location = New System.Drawing.Point(296, 16)
        Me.lbx_fact_status.LookupKeyDisplayFields = Nothing
        Me.lbx_fact_status.LookupKeyField = Nothing
        Me.lbx_fact_status.LookupTableName = Nothing
        Me.lbx_fact_status.Name = "lbx_fact_status"
        Me.lbx_fact_status.NewInitialValue = Nothing
        Me.lbx_fact_status.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lbx_fact_status.Requiered = False
        Me.lbx_fact_status.Required = False
        Me.lbx_fact_status.Size = New System.Drawing.Size(104, 21)
        Me.lbx_fact_status.SqlString = Nothing
        Me.lbx_fact_status.TabIndex = 3
        Me.lbx_fact_status.TabStop = False
        '
        'cust_name
        '
        Me.cust_name.Location = New System.Drawing.Point(144, 88)
        Me.cust_name.Name = "cust_name"
        Me.cust_name.ReadOnly = True
        Me.cust_name.Size = New System.Drawing.Size(256, 20)
        Me.cust_name.TabIndex = 7
        Me.cust_name.TabStop = False
        Me.cust_name.Text = ""
        '
        'txtCliCodigo
        '
        Me.txtCliCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.cust_code"))
        Me.txtCliCodigo.Location = New System.Drawing.Point(80, 88)
        Me.txtCliCodigo.Name = "txtCliCodigo"
        Me.txtCliCodigo.ReadOnly = True
        Me.txtCliCodigo.Size = New System.Drawing.Size(56, 20)
        Me.txtCliCodigo.TabIndex = 6
        Me.txtCliCodigo.Text = ""
        '
        'txtfact_number
        '
        Me.txtfact_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_number"))
        Me.txtfact_number.EditInitialValue = Nothing
        Me.txtfact_number.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtfact_number.FindInitialValue = Nothing
        Me.txtfact_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtfact_number.IgnoreRequiered = True
        Me.txtfact_number.Location = New System.Drawing.Point(80, 16)
        Me.txtfact_number.Name = "txtfact_number"
        Me.txtfact_number.NewInitialValue = Nothing
        Me.txtfact_number.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtfact_number.Requiered = False
        Me.txtfact_number.TabIndex = 1
        Me.txtfact_number.TabStop = False
        Me.txtfact_number.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(240, 16)
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
        Me.Label2.Location = New System.Drawing.Point(446, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMontoBruto
        '
        Me.txtMontoBruto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_total"))
        Me.txtMontoBruto.Location = New System.Drawing.Point(496, 40)
        Me.txtMontoBruto.Name = "txtMontoBruto"
        Me.txtMontoBruto.ReadOnly = True
        Me.txtMontoBruto.Size = New System.Drawing.Size(88, 20)
        Me.txtMontoBruto.TabIndex = 19
        Me.txtMontoBruto.TabStop = False
        Me.txtMontoBruto.Text = ""
        Me.txtMontoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDec
        '
        Me.txtDec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.descto"))
        Me.txtDec.Location = New System.Drawing.Point(496, 88)
        Me.txtDec.Name = "txtDec"
        Me.txtDec.ReadOnly = True
        Me.txtDec.Size = New System.Drawing.Size(88, 20)
        Me.txtDec.TabIndex = 23
        Me.txtDec.TabStop = False
        Me.txtDec.Text = ""
        Me.txtDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(424, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Descuento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtITbis
        '
        Me.txtITbis.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.itbis"))
        Me.txtITbis.Location = New System.Drawing.Point(496, 64)
        Me.txtITbis.Name = "txtITbis"
        Me.txtITbis.ReadOnly = True
        Me.txtITbis.Size = New System.Drawing.Size(88, 20)
        Me.txtITbis.TabIndex = 21
        Me.txtITbis.TabStop = False
        Me.txtITbis.Text = ""
        Me.txtITbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(457, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 16)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Itbis:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Blue
        Me.txtTotal.Location = New System.Drawing.Point(496, 112)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(88, 24)
        Me.txtTotal.TabIndex = 25
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = ""
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(425, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Total Neto:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(416, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Monto Bruto:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(16, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cliente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cotización No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtClinombre
        '
        Me.txtClinombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClinombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.bus_name"))
        Me.txtClinombre.Location = New System.Drawing.Point(80, 112)
        Me.txtClinombre.Name = "txtClinombre"
        Me.txtClinombre.Size = New System.Drawing.Size(296, 20)
        Me.txtClinombre.TabIndex = 10
        Me.txtClinombre.Text = ""
        '
        'xtxt_term_code
        '
        Me.xtxt_term_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.term_code"))
        Me.xtxt_term_code.Location = New System.Drawing.Point(80, 136)
        Me.xtxt_term_code.Name = "xtxt_term_code"
        Me.xtxt_term_code.ReadOnly = True
        Me.xtxt_term_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_term_code.TabIndex = 13
        Me.xtxt_term_code.Text = ""
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(512, 24)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 22
        '
        'vend_name
        '
        Me.vend_name.Location = New System.Drawing.Point(152, 32)
        Me.vend_name.Name = "vend_name"
        Me.vend_name.ReadOnly = True
        Me.vend_name.Size = New System.Drawing.Size(256, 20)
        Me.vend_name.TabIndex = 3
        Me.vend_name.TabStop = False
        Me.vend_name.Text = ""
        '
        'txtvend_code
        '
        Me.txtvend_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.vend_code"))
        Me.txtvend_code.Location = New System.Drawing.Point(88, 32)
        Me.txtvend_code.Name = "txtvend_code"
        Me.txtvend_code.Size = New System.Drawing.Size(56, 20)
        Me.txtvend_code.TabIndex = 2
        Me.txtvend_code.Text = ""
        '
        'xlk_vend_code
        '
        Me.xlk_vend_code.DataMember = Nothing
        Me.xlk_vend_code.DataSource = Me.LibXConnector1
        Me.xlk_vend_code.DestParameters = New String() {"vend_code=vend_code", "vend_name=vend_name"}
        Me.xlk_vend_code.FilterField = Nothing
        Me.xlk_vend_code.IgnoreFindInBrowseMode = False
        Me.xlk_vend_code.Location = New System.Drawing.Point(408, 32)
        Me.xlk_vend_code.LookCaption = "Vendedores"
        Me.xlk_vend_code.Name = "xlk_vend_code"
        Me.xlk_vend_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_vend_code.SqlString = Nothing
        Me.xlk_vend_code.SrcParameters = New String() {"vend_code=vend_code"}
        Me.xlk_vend_code.TabIndex = 4
        Me.xlk_vend_code.TableName = "ftvendm"
        Me.xlk_vend_code.UseCopyConnection = False
        Me.xlk_vend_code.UseRowRetrieveEvents = False
        Me.xlk_vend_code.VisParameters = New String() {"Código=vend_code", "Nombre=vend_name"}
        Me.xlk_vend_code.WhereCondition = Nothing
        '
        'Label16
        '
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Location = New System.Drawing.Point(24, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 16)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Vendedor:"
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
        Me.LibXGridDetalle.DataMember = "ftfactd"
        Me.LibXGridDetalle.DataSource = Me.DataSet1
        Me.LibXGridDetalle.FullRowSelect = False
        Me.LibXGridDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGridDetalle.IsReadOnly = False
        Me.LibXGridDetalle.Location = New System.Drawing.Point(8, 232)
        Me.LibXGridDetalle.Name = "LibXGridDetalle"
        Me.LibXGridDetalle.ReadOnly = True
        Me.LibXGridDetalle.showFooterBar = True
        Me.LibXGridDetalle.Size = New System.Drawing.Size(752, 184)
        Me.LibXGridDetalle.TabIndex = 6
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
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColitem_code, Me.gColwhse_code, Me.gColitem_name, Me.GridColQty, Me.GColprice, Me.gColCosto, Me.gColExist, Me.gColdscto, Me.gColIbis, Me.gColImporte})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ftfactd"
        '
        'gColitem_code
        '
        Me.gColitem_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColitem_code.executeFindDuringFill = True
        Me.gColitem_code.Format = ""
        Me.gColitem_code.FormatInfo = Nothing
        Me.gColitem_code.HeaderText = "Producto"
        Me.gColitem_code.isReadOnly = False
        Me.gColitem_code.Lookup = Me.lkp_item_code
        Me.gColitem_code.MappingName = "item_code"
        Me.gColitem_code.UseCustomCellFormat = False
        Me.gColitem_code.Width = 110
        '
        'lkp_item_code
        '
        Me.lkp_item_code.DataMember = Nothing
        Me.lkp_item_code.DataSource = Me.LibXConnector1
        Me.lkp_item_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "costo=purch_cost", "whse_code=whse_code", "price=priceRD", "exist=existencia"}
        Me.lkp_item_code.FilterField = "item_name"
        Me.lkp_item_code.IgnoreFindInBrowseMode = False
        Me.lkp_item_code.Location = New System.Drawing.Point(456, 208)
        Me.lkp_item_code.LookCaption = "Productos"
        Me.lkp_item_code.Name = "lkp_item_code"
        Me.lkp_item_code.Size = New System.Drawing.Size(16, 20)
        Me.lkp_item_code.SqlString = New String() {Nothing}
        Me.lkp_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.lkp_item_code.TabIndex = 3
        Me.lkp_item_code.TableName = "ivitemv"
        Me.lkp_item_code.UseCopyConnection = False
        Me.lkp_item_code.UseRowRetrieveEvents = False
        Me.lkp_item_code.VisParameters = New String() {"Código=item_code", "Descripción=item_name", "Precio US=price", "Precio RD=priceRD", "Precio x Mayor=pricemayor", "Precio Mínimo=priceminor", "Existencia=existencia"}
        Me.lkp_item_code.WhereCondition = Nothing
        '
        'gColwhse_code
        '
        Me.gColwhse_code.Format = ""
        Me.gColwhse_code.FormatInfo = Nothing
        Me.gColwhse_code.ImageList = Nothing
        Me.gColwhse_code.isReadOnly = False
        Me.gColwhse_code.MappingName = "whse_code"
        Me.gColwhse_code.ReadOnly = True
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
        Me.gColitem_name.Width = 260
        '
        'GridColQty
        '
        Me.GridColQty.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.GridColQty.Format = "##,###,##0"
        Me.GridColQty.FormatInfo = Nothing
        Me.GridColQty.HeaderText = "Cantidad"
        Me.GridColQty.ImageList = Nothing
        Me.GridColQty.isReadOnly = False
        Me.GridColQty.MappingName = "qty"
        Me.GridColQty.UseCustomCellFormat = False
        Me.GridColQty.Width = 65
        '
        'GColprice
        '
        Me.GColprice.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.GColprice.Format = "##,###,##0.00"
        Me.GColprice.FormatInfo = Nothing
        Me.GColprice.HeaderText = "Precio"
        Me.GColprice.MappingName = "price"
        Me.GColprice.Width = 65
        '
        'gColCosto
        '
        Me.gColCosto.Format = ""
        Me.gColCosto.FormatInfo = Nothing
        Me.gColCosto.ImageList = Nothing
        Me.gColCosto.isReadOnly = False
        Me.gColCosto.MappingName = "costo"
        Me.gColCosto.ReadOnly = True
        Me.gColCosto.UseCustomCellFormat = False
        Me.gColCosto.Width = 0
        '
        'gColExist
        '
        Me.gColExist.Format = ""
        Me.gColExist.FormatInfo = Nothing
        Me.gColExist.ImageList = Nothing
        Me.gColExist.isReadOnly = False
        Me.gColExist.MappingName = "exist"
        Me.gColExist.ReadOnly = True
        Me.gColExist.UseCustomCellFormat = False
        Me.gColExist.Width = 0
        '
        'gColdscto
        '
        Me.gColdscto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColdscto.Format = "##,###,##0.00"
        Me.gColdscto.FormatInfo = Nothing
        Me.gColdscto.HeaderText = "Descuento"
        Me.gColdscto.MappingName = "dscto"
        Me.gColdscto.ReadOnly = True
        Me.gColdscto.Width = 65
        '
        'gColIbis
        '
        Me.gColIbis.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColIbis.Format = "##,###,##0.00"
        Me.gColIbis.FormatInfo = Nothing
        Me.gColIbis.HeaderText = "Itbis"
        Me.gColIbis.ImageList = Nothing
        Me.gColIbis.isReadOnly = False
        Me.gColIbis.MappingName = "itbis"
        Me.gColIbis.ReadOnly = True
        Me.gColIbis.UseCustomCellFormat = False
        Me.gColIbis.Width = 65
        '
        'gColImporte
        '
        Me.gColImporte.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColImporte.Format = "##,###,##0.00"
        Me.gColImporte.FormatInfo = Nothing
        Me.gColImporte.HeaderText = "Importe"
        Me.gColImporte.MappingName = "Importe"
        Me.gColImporte.ReadOnly = True
        Me.gColImporte.Width = 65
        '
        'txt_item_name
        '
        Me.txt_item_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactd.item_name"))
        Me.txt_item_name.Location = New System.Drawing.Point(80, 440)
        Me.txt_item_name.Name = "txt_item_name"
        Me.txt_item_name.ReadOnly = True
        Me.txt_item_name.Size = New System.Drawing.Size(680, 20)
        Me.txt_item_name.TabIndex = 8
        Me.txt_item_name.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(16, 440)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Producto:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'i_ftfact01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(770, 487)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_item_name)
        Me.Controls.Add(Me.vend_name)
        Me.Controls.Add(Me.txtvend_code)
        Me.Controls.Add(Me.LibXGridDetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.xlk_vend_code)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.lkp_item_code)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ftfact01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Facturación"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_Condicion.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim mCli As ClienteContado
    Dim mSerial As Integer
    Dim mPricemajor As Boolean
    Dim mRowIvSetup As DataRow
    Dim mConf As SGT.Inventario.Common.Configuration
    Dim mFactNum As Integer
    Dim moP As SGT.Inventario.Operaciones.PostInventory.ParametrosAplicar
    Dim WhereStmt As String

    Private Sub i_ftfact01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mConf = New SGT.Inventario.Common.Configuration
            ftfactd.Columns("Importe").Expression = "qty*price"
            LibXGridDetalle.footerOperations.add("Importe", "sum(Importe)")

            If Not LibXConnector1.Parameters Is Nothing Then
                If Not IsNull(LibXConnector1.Parameters.Value) Then
                    WhereStmt = "ftfactm.ftserial_no = " & LibXConnector1.Parameters.Value.ToString
                    LibXConnector1.ExecuteFind(WhereStmt)
                End If
            End If
        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCli.Click
        Try
            Dim objForm As New i_ftcustm01

            If mCli Is Nothing Then
                mCli = New ClienteContado
            End If
            mCli.Nombre = Me.txtClinombre.Text
            objForm.Cli = mCli

            objForm.ShowDialog()

            If Not objForm.ok Then
                mCli = Nothing
            Else
                mCli.Company = objForm.Cli.Company
                If Trim(Me.txtClinombre.Text) = "" Then
                    Me.txtClinombre.Text = mCli.Company
                End If
                mCli.Contacto = objForm.Cli.Contacto
                mCli.Tel = objForm.Cli.Tel
                mCli.TelArea = objForm.Cli.TelArea
            End If
        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGridDetalle_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGridDetalle.CellValidate
        Try

            '// Validar la cantidad
            If Me.GridColQty.Column = e.cell Then
                If IsNull(Me.gColitem_code.GetValue) Then
                    Exit Sub
                End If

                If IsNull(e.value) Then
                    e.hasErrors = True
                    Exit Sub
                End If

                Dim Existe As Decimal = 0
                If Trim(Me.gColExist.GetValue) <> "" Then
                    Existe = Me.gColExist.GetValue
                End If

                If e.value > Existe Then
                    Throw New Exception("La cantidad no puede se mayor que la existencia")
                End If

                Dim Precio As Integer = 0
                Dim Qty As Integer = e.value

                If Trim(Me.LibXGridDetalle.GetValue(GColprice)) <> "" Then
                    Precio = Me.LibXGridDetalle.GetValue(GColprice)
                End If

                LibXGridDetalle.SetValue(gColImporte, Precio * Qty)

                '                ActualizaTotal()
            End If


            If Me.LibXGridDetalle.GetColNum(GColprice) = e.cell Then
                If IsNull(Me.gColitem_code.GetValue) Then
                    Exit Sub
                End If
                If IsNull(e.value) Then
                    e.hasErrors = True
                    Exit Sub
                End If

                Dim Precio As Integer = e.value
                Dim Qty As Integer = 0

                If Trim(Me.GridColQty.GetValue) <> "" Then
                    qty = Me.GridColQty.GetValue
                End If

                Me.LibXGridDetalle.SetValue(Me.gColImporte, Precio * Qty)

                Dim oRow As DataRow
                Dim sSql As String
                Dim iCod As String = gColitem_code.GetValue
                Dim IWhse_code As Integer = Me.gColwhse_code.GetValue

                sSql = String.Concat("Select * from ivitemd where item_code = '", Trim(iCod), "' and Whse_code = ", IWhse_code)
                oRow = LibX.Data.Manager.GetDataRow(sSql)
                If oRow Is Nothing Then
                    'que mensaje?
                    Throw New Exception("No se encuetra un registro en ivitemd")
                End If

                If Me.rdbContado.Checked Then
                    'Válida que el precio no sea menor que el precio al por mayor
                    'precio al por mayor (ivitemd.price * (1 + (ivsetup.price_1/100) 
                    Dim precioPorMayor As Decimal = oRow!price - (oRow!price * (Me.mRowIvSetup!price_1 / 100))
                    preciopormayor *= oRow!tasa
                    If Precio < precioPorMayor Then
                        LibXGridDetalle.SetValue(GColprice, precioPorMayor)
                        Throw New Exception("El precio no debe ser menor que el precio al por mayor")
                    End If

                    If Me.mPricemajor Then
                        Dim precioMinimo As Decimal = oRow!price - (oRow!price * (Me.mRowIvSetup!price_2 / 100))
                        precioMinimo *= oRow!tasa
                        If Precio < precioMinimo Then
                            LibXGridDetalle.SetValue(GColprice, precioMinimo)
                            Throw New Exception("El precio no debe ser menor que el precio mínimo")
                        End If
                    End If
                Else
                    'Credito
                    If Me.mPricemajor Then
                        'Válida que el precio no sea menor que el precio minimo (ivitemd.price - (ivitemd.price * (ivsetup.price_2/100))
                        Dim precioMinimo As Decimal = oRow!price - (oRow!price * (Me.mRowIvSetup!price_2 / 100))
                        precioMinimo *= oRow!tasa
                        If Precio < precioMinimo Then
                            LibXGridDetalle.SetValue(GColprice, precioMinimo)
                            Throw New Exception("El precio no debe ser menor que el precio mínimo")
                        End If
                    Else
                        'valida que el precio no sea menor que el precio al por mayor (ivitemd.price * (1 + (ivsetup.price_1/100)
                        Dim precioPorMayor As Decimal = oRow!price - (oRow!price * (Me.mRowIvSetup!price_1 / 100))
                        precioPorMayor *= oRow!tasa
                        If Precio < precioPorMayor Then
                            LibXGridDetalle.SetValue(GColprice, precioPorMayor)
                            Throw New Exception("El precio no debe ser menor que el precio al por mayor")
                        End If
                    End If
                End If

                'ActualizaTotal()
            End If


            If Me.LibXGridDetalle.GetColNum(Me.gColdscto) = e.cell Then
                'ActualizaTotal()
            End If

            If Me.GridColQty.Column = e.cell Then
                If IsNull(Me.gColitem_code.GetValue) Then
                    Exit Sub
                End If

                If e.row = Me.LibXGridDetalle.getCurrentGridView.Count - 1 Then
                    Me.LibXGridDetalle.CurrentCell = New DataGridCell(e.row, LibXGridDetalle.GetColNum(Me.gColImporte))
                    SendKeys.Send("{TAB}")
                End If
            End If

        Catch ex As Exception
            e.hasErrors = True
            Log.Show(ex)
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
            Dim oCant As Integer
            Dim TCant As Integer = 0
            Dim Titb As Decimal = 0
            Dim itb As Decimal = 0
            Dim costo As Decimal
            Dim total As Decimal = 0

            moP = New SGT.Inventario.Operaciones.PostInventory.ParametrosAplicar

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
                oValue = Me.LibXGridDetalle.GetValue(i, gColdscto)
                If Not IsNull(oValue) Then
                    oDesc = oValue
                End If

                oValue = Me.gColCosto.GetValue(i)
                If Not IsNull(oValue) Then
                    costo = oValue
                End If

                tPrice = tPrice + oPrice
                tDesc = tDesc + oDesc
                TCant = TCant + oCant
                Titb = Titb + itb
                total += oCant * oPrice

                '''If (oCant * oPrice) > 0 Then
                '''    LibXGridDetalle.SetValue(gColImporte, oCant * oPrice)
                '''End If  sw

                If Val(GridColQty.GetValue(i)) > 0 Then
                    moP.Productos.Add(Me.gColitem_code.GetValue(i), Me.gColwhse_code.GetValue(i), GridColQty.GetValue(i), 0, 0, 0, oPrice, 0)
                End If
            Next

            Me.txtDec.Text = tDesc.ToString("###,###,##0.00")
            Me.txtTotal.Text = total.ToString("###,###,##0.00")
            Me.txtITbis.Text = Titb.ToString("###,###,##0.00")
            Me.txtMontoBruto.Text = CDec(total + tDesc - Titb).ToString("###,###,##0.00")

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub lkp_item_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkp_item_code.AfterSetValues
        Try

            If Not Me.LibXConnector1.IsEditing Then
                Exit Sub
            End If

            If e.dataFound = False Then
                Exit Sub
            End If

            txt_item_name.Text = e.row!item_name


            If cbo_price.Checked Then
                Dim pMayor As Decimal = 0

                pMayor = e.row!priceRD - (e.row!priceRD * (mConf.GetPriceMajor / 100))

                Me.LibXGridDetalle.SetValue(Me.GColprice, pMayor)

            End If

            If e.dataFound And Me.LibXConnector1.IsEditing Then
                Me.LibXGridDetalle.CurrentCell = New DataGridCell(Me.LibXGridDetalle.CurrentRowIndex, 1)
            End If

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub


    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then

                Dim intLast As Object
                Dim sSql As String

                e.UpdatingArgs.Row!type_code = "FCT"
                e.UpdatingArgs.Row!fact_cond = 2


                If TieneSerie() = True Then
                    e.UpdatingArgs.Row!fact_status = 1 ' "Pendiente de despacho" (1)  en la table ivfactm\
                Else
                    e.UpdatingArgs.Row!fact_status = 2 ' "Pendiente de cobro" (2)  en la table ivfactm\
                End If

                If Me.rdbContado.Checked Then
                    e.UpdatingArgs.Row!fact_cond = 1
                End If

                sSql = "select * from ivtypem" & _
                       " where type_code = 'FCT' "

                Dim oTable As DataTable = LibX.Data.Manager.GetDataTable(sSql, "ivtypem")
                If oTable Is Nothing OrElse oTable.Rows.Count = 0 Then
                    Throw New Exception("No existe el tipo de documento factura")
                End If

                Dim oRow As DataRow = oTable.Rows(0)
                intLast = 0
                If Not IsNull(oRow!last_number) Then
                    intLast = oRow!last_number
                End If

                intLast = intLast + 1
                oRow!last_number = intLast

                mFactNum = intLast

                LibX.Data.Manager.Save(oTable)
                If LibX.IsNull(e.UpdatingArgs.Row!fact_date) Then
                    e.UpdatingArgs.Row!fact_date = LibX.Data.Manager.Connection.GetDate
                End If

                e.UpdatingArgs.Row!fact_number = intLast

            End If

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertedDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedDetailRow

    End Sub

    Private Sub LibXConnector1_InsertedRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedRow
        Try
            Dim oS As LibX.Data.XInsertStmt

            If e.UpdatingArgs.StatementType = StatementType.Insert Then

                mSerial = e.Serial

                If Not mCli Is Nothing And Me.rdbContado.Checked Then
                    oS = New LibX.Data.XInsertStmt("ftcustm")
                    oS!ftserial_no = mSerial
                    oS!cust_name = mCli.Nombre
                    oS!company_name = mCli.Company
                    oS!area_code = mCli.TelArea
                    oS!phone = mCli.Tel
                    oS.Execute()
                End If
            End If

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            If e.Action = LibxConnectionActions.Print Then

            End If
            If e.Action = LibxConnectionActions.Edit Then
                If LibXConnector1.CurrentDataRow!fact_status <> 1 Then
                    e.Handled = True
                    Throw New ApplicationException("Este documento no puede ser modificado!")
                End If
            End If

            If e.Action = LibxConnectionActions.Add Or e.Action = LibxConnectionActions.Edit Then
                If mRowIvSetup Is Nothing Then
                    mRowIvSetup = LibX.Data.Manager.GetDataRow("Select * from ivsetup")
                    If mRowIvSetup Is Nothing Then
                        Throw New Exception("No se encuentra la configuración de inventario")
                    End If
                End If
            End If

            If e.Action = LibxConnectionActions.Accept And (e.AcceptedAction = LibxConnectionActions.Add Or e.AcceptedAction = LibxConnectionActions.Edit) Then
                If Me.rdbContado.Checked Then
                    '--> si es contado debe registrar toda la inf
                    If mCli Is Nothing Then
                        Exit Sub
                    End If
                    mCli.Nombre = Me.txtClinombre.Text

                    If Trim(mCli.Nombre) = "" Then
                        Throw New Exception("Debe completar la información del cliente")
                    End If

                    If Trim(mCli.Company) = "" Then
                        Throw New Exception("Debe completar la información del cliente")
                    End If
                End If
            End If
         Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub lkp_item_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lkp_item_code.BeforeExecuteQuery
        Try

            'Verifica que la existencia sea mayor que 0 y que el producto no este en estatus descontinuado.

            ' cual es el estatus descontinuado?

            'e.aditionalWhere =?




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

            xtxt_term_code.Text = e.row!term_code
            xlk_term_code.ExecuteFind()

            If rdbContado.Checked = True Then
                Disc_pct.Text = ""
                Due_days.Text = ""
                Disc_days.Text = ""
            Else
                Disc_pct.Text = e.row!Disc_pct
                Due_days.Text = e.row!Due_days
                Disc_days.Text = e.row!Disc_days
            End If

            If e.row!cust_pricemajor = 1 Then
                cbo_price.Checked = True
            Else
                cbo_price.Checked = False
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

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Dim SelecStmt As String
        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
                '// Tomar el Connection String del config
                With AxCrystalReport1
                    .Connect = Configuration.ConfigurationSettings.AppSettings.Get("LibXConnectReport")

                    '// Pasar el Connection String a cada subreport
                    For i As Int16 = 0 To .GetNSubreports - 1
                        .SubreportToChange = .GetNthSubreportName(i)
                        .Connect = Configuration.ConfigurationSettings.AppSettings.Get("LibXConnectReport")
                    Next

                    '// Localizarse en el reporte principal
                    .SubreportToChange = ""

                    '// Recibir el SQL Query
                    .RetrieveSQLQuery()
                    SelecStmt = .SQLQuery
                    SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, "ftfactm.ftserial_no = " & LibXConnector1.CurrentDataRow!ftserial_no)
                    .SQLQuery = SelecStmt

                    '// Ejecutar el reporte
                    .Action = 1
                End With
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        WhereStmt = e.Where
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibxConnectionActions.Add Then
                mCli = Nothing
                Me.rdbContado.Checked = True
                mPricemajor = False
                lbx_fact_status.currValue = 1
                txtfact_number.ReadOnly = True

                If LibX.User.VendedorID > 0 Then
                    txtvend_code.Text = LibX.User.VendedorID
                    xlk_vend_code.ExecuteFind()
                End If
            End If

            If e.Action = LibxConnectionActions.Find Then
                txtfact_number.ReadOnly = False
            End If

            If e.AcceptedAction = LibxConnectionActions.Add Then
                ftfactd.Rows.Clear()
                ftfactm.Rows.Clear()
                txtTotal.Text = ""
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub lkp_item_code_CreatedGridColumns(ByVal sender As Object, ByVal e As LibX.CreatedGridColumnsEventArgs) Handles lkp_item_code.CreatedGridColumns
        Try
            e.TStyle.GridColumnStyles.Item("item_name").Width = 300

            '''    '// Precio al Por Mayor
            '''    Dim oCol As DataColumn
            '''    oCol = e.Table.Columns.Add
            '''    oCol.ColumnName = "PriceMajor"
            '''    oCol.Expression = "PriceRD - (PriceRD*" & Decimal.Round((mConf.GetPriceMajor / 100), 2).ToString & ")"

            '''    Dim Grs As New DataGridTextBoxColumn    '= e.TStyle.GridColumnStyles.Add()
            '''    Grs.MappingName = "PriceMajor"
            '''    Grs.HeaderText = "Precio x Mayor"
            '''    Grs.Format = "##,###,##0.00"
            '''    Grs.Width = 75
            '''    Grs.Alignment = HorizontalAlignment.Right
            '''    e.TStyle.GridColumnStyles.Add(Grs)

            '''    '// Precio Minimo
            '''    Dim oCol1 As DataColumn
            '''    oCol1 = e.Table.Columns.Add
            '''    oCol1.ColumnName = "PriceMin"
            '''    oCol1.Expression = "PriceRD - (PriceRD*" & (mConf.PriceMinim / 100).ToString & ")"

            '''    Dim Grs1 As New DataGridTextBoxColumn  '= e.TStyle.GridColumnStyles.Add()
            '''    Grs1.MappingName = "PriceMin"
            '''    Grs1.HeaderText = "Precio Mínimo"
            '''    Grs1.Format = "##,###,##0.00"
            '''    Grs1.Width = 75
            '''    Grs1.Alignment = HorizontalAlignment.Right
            '''    e.TStyle.GridColumnStyles.Add(Grs1)

            e.Grid.Parent.Width = e.Grid.Parent.Width + 300
            'e.Grid.Parent.Height = e.Grid.Parent.Height + 100

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub rdbCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCredito.CheckedChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                xtxt_term_code.ReadOnly = False
                xlk_term_code.Enabled = True

                txtCliCodigo.ReadOnly = False
                lkCliente.Enabled = True
            End If

            If LibXConnector1.IsEditing Then
                LibXConnector1.CurrentDataRow!fact_cond = 2
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub rdbContado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbContado.CheckedChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                xtxt_term_code.Text = ""
                xtxt_term_code.ReadOnly = True
                'xlk_term_code.Clear(True)

                txtCliCodigo.Text = ""
                txtCliCodigo.ReadOnly = True
                'lkCliente.Clear(True)
            End If

            If LibXConnector1.IsEditing Then
                LibXConnector1.CurrentDataRow!fact_cond = 1
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        gbx_Condicion.Enabled = e.isEditing


    End Sub

    Private Sub LibXGridDetalle_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LibXGridDetalle.CurrentCellChanged
        Try
            If LibXConnector1.IsEditing = True Then
                '// Validar que no salga de la celda de producto sin código
                If LibXGridDetalle.CurrentCell.ColumnNumber = _
                LibXGridDetalle.TableStyles(0).GridColumnStyles.IndexOf(gColitem_name) Then
                    If LibXGridDetalle.GetValue(gColitem_code).ToString.Length <= 0 Then
                        lkp_item_code.ExecuteLookupGrid()
                    End If
                    Exit Sub
                End If

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
                    ftfactd.Rows.RemoveAt(LibXGridDetalle.CurrentRowIndex)
                    ActualizaTotal()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Function TieneSerie() As Boolean
        Dim SelectStmt As String
        Dim hasserial As Integer
        Try
            For Each oRow As DataRow In ftfactd.Rows
                SelectStmt = "select item_serial  from ivitemm " & _
                             "where item_code = '" & oRow!item_code.ToString.Trim & "'"

                hasserial = LibX.Data.Manager.GetScalar(SelectStmt)

                If hasserial = 1 Then
                    Return True
                    Exit Function
                End If
            Next

            Return False
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Function


    Private Sub LibXConnector1_ValidatingControls(ByVal sender As Object, ByVal e As LibX.ValidatingControlsEventArgs) Handles LibXConnector1.ValidatingControls
        If IsNull(Me.DateTimePicker1.Value) Then
            Me.DateTimePicker1.Value = LibX.Data.Manager.Connection.GetDate
        End If

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim S As String
        S = Me.LibXConnector1.CurrentDataRow!fact_status
        MsgBox(S)
    End Sub
End Class


Public Class ClienteContado
    Public Nombre As String
    Public Company As String
    Public Contacto As String
    Public TelArea As String
    Public Tel As String
End Class
