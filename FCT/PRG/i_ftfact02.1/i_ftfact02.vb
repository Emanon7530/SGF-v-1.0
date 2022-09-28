Imports LibX
Imports SGT.Facturacion.Entidades
Public Class i_ftfact02
    Inherits System.Windows.Forms.Form
    Dim oDoc As SGT.Facturacion.Entidades.Documento
    Dim mCajaDefault As Integer
    Dim mCajeDefault As Integer
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
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents DateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents STftfactm As LibX.LibXDbSourceTable
    Friend WithEvents STfactd As LibX.LibXDbSourceTable
    Friend WithEvents cust_name As LibX.XTextBox
    Friend WithEvents vend_name As LibX.XTextBox
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents txtClinombre As LibX.XTextBox
    Friend WithEvents rdbContado As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCredito As System.Windows.Forms.RadioButton
    Friend WithEvents LibXGridDetalle As LibX.LibXGrid
    Friend WithEvents lkCliente As LibX.LibXLookup
    Friend WithEvents btnCli As System.Windows.Forms.Button
    Friend WithEvents txtMontoBruto As LibX.XTextBox
    Friend WithEvents txtCliCodigo As LibX.XTextBox
    Friend WithEvents lbx_fact_status As LibX.LibXCombo
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents txtfact_number As LibX.XTextBox
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents txtvend_code As LibX.XTextBox
    Friend WithEvents xlk_vend_code As LibX.LibXLookup
    Friend WithEvents term_name As LibX.XTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents xlk_term_code As LibX.LibXLookup
    Friend WithEvents xtxt_term_code As LibX.XTextBox
    Friend WithEvents ftfactm As System.Data.DataTable
    Friend WithEvents gbx_Condicion As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents ftfactd1 As System.Data.DataTable
    Friend WithEvents xetx_Price As LibX.XEditTextBoxColumn
    Friend WithEvents TextBox1 As LibX.XTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents gColItbis As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents gColImporte As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Itbis As LibX.XTextBox
    Friend WithEvents xtxNeto As LibX.XTextBox
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
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
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
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
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.ftfactd1 = New System.Data.DataTable
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.STftfactm = New LibX.LibXDbSourceTable
        Me.STfactd = New LibX.LibXDbSourceTable
        Me.DataColumn43 = New System.Data.DataColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xtxNeto = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Itbis = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox1 = New LibX.XTextBox
        Me.xlk_term_code = New LibX.LibXLookup
        Me.Label6 = New System.Windows.Forms.Label
        Me.term_name = New LibX.XTextBox
        Me.btnCli = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New LibX.LibxDateTimePicker
        Me.lkCliente = New LibX.LibXLookup
        Me.lbx_fact_status = New LibX.LibXCombo
        Me.cust_name = New LibX.XTextBox
        Me.txtCliCodigo = New LibX.XTextBox
        Me.txtfact_number = New LibX.XTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMontoBruto = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtClinombre = New LibX.XTextBox
        Me.xtxt_term_code = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.gbx_Condicion = New System.Windows.Forms.GroupBox
        Me.rdbContado = New System.Windows.Forms.RadioButton
        Me.rdbCredito = New System.Windows.Forms.RadioButton
        Me.vend_name = New LibX.XTextBox
        Me.txtvend_code = New LibX.XTextBox
        Me.xlk_vend_code = New LibX.LibXLookup
        Me.Label16 = New System.Windows.Forms.Label
        Me.LibXGridDetalle = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.xetx_Price = New LibX.XEditTextBoxColumn
        Me.gColItbis = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColImporte = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactd1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbx_Condicion.SuspendLayout()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(762, 24)
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
        Me.LibXConnector1.ModuleName = ""
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = ""
        Me.LibXConnector1.ReportObject = Nothing
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftfactm, Me.ftfactd1})
        '
        'ftfactm
        '
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn32, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn19, Me.DataColumn20, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn33, Me.DataColumn38, Me.DataColumn40, Me.DataColumn43})
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
        Me.DataColumn34.MaxLength = 100
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
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "pay_mora"
        Me.DataColumn22.DataType = GetType(System.Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "porc_comision"
        Me.DataColumn23.DataType = GetType(System.Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "fact_ncf"
        Me.DataColumn24.MaxLength = 40
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "caja_code"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "caje_code"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "init_serial"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "fact_inddomicilio"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "address"
        Me.DataColumn29.MaxLength = 200
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "seg_amount"
        Me.DataColumn30.DataType = GetType(System.Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "prov_code"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "fact_impresa"
        Me.DataColumn33.DataType = GetType(System.Int32)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "cust_serial"
        Me.DataColumn38.DataType = GetType(System.Int32)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "fact_time"
        Me.DataColumn40.MaxLength = 10
        '
        'ftfactd1
        '
        Me.ftfactd1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn41, Me.DataColumn42, Me.DataColumn44, Me.DataColumn21, Me.DataColumn39, Me.DataColumn60})
        Me.ftfactd1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no", "line_no"}, True)})
        Me.ftfactd1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn41, Me.DataColumn42}
        Me.ftfactd1.TableName = "ftfactd1"
        '
        'DataColumn41
        '
        Me.DataColumn41.AllowDBNull = False
        Me.DataColumn41.ColumnName = "ftserial_no"
        Me.DataColumn41.DataType = GetType(System.Int32)
        '
        'DataColumn42
        '
        Me.DataColumn42.AllowDBNull = False
        Me.DataColumn42.AutoIncrement = True
        Me.DataColumn42.AutoIncrementSeed = CType(1, Long)
        Me.DataColumn42.ColumnName = "line_no"
        Me.DataColumn42.DataType = GetType(System.Int32)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "price"
        Me.DataColumn44.DataType = GetType(System.Decimal)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "itbis"
        Me.DataColumn21.DataType = GetType(System.Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.Caption = "importe"
        Me.DataColumn39.ColumnName = "importe"
        Me.DataColumn39.DataType = GetType(System.Decimal)
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "descr"
        Me.DataColumn60.MaxLength = 40
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
        Me.STftfactm.InnerJon = True
        Me.STftfactm.InsertOrder = 0
        Me.STftfactm.IsDetail = False
        Me.STftfactm.KeyFields = Nothing
        Me.STftfactm.LineColName = Nothing
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
        Me.STfactd.InnerJon = True
        Me.STfactd.InsertOrder = 0
        Me.STfactd.IsDetail = True
        Me.STfactd.KeyFields = "ftserial_no,line_no"
        Me.STfactd.LineColName = Nothing
        Me.STfactd.MasterDetailRelation = New String() {"ftserial_no=ftserial_no"}
        Me.STfactd.MasterTableName = Nothing
        Me.STfactd.SerialColumnName = ""
        Me.STfactd.Sort = Nothing
        Me.STfactd.Source = Nothing
        Me.STfactd.TableName = "ftfactd1"
        Me.STfactd.UpdateOrder = 0
        Me.STfactd.UseRowRetrieve = False
        '
        'DataColumn43
        '
        Me.DataColumn43.AllowDBNull = False
        Me.DataColumn43.ColumnName = "suc_code"
        Me.DataColumn43.DataType = GetType(System.Int32)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xtxNeto)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Itbis)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.xlk_term_code)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.term_name)
        Me.GroupBox1.Controls.Add(Me.btnCli)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.lkCliente)
        Me.GroupBox1.Controls.Add(Me.lbx_fact_status)
        Me.GroupBox1.Controls.Add(Me.cust_name)
        Me.GroupBox1.Controls.Add(Me.txtCliCodigo)
        Me.GroupBox1.Controls.Add(Me.txtfact_number)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMontoBruto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtClinombre)
        Me.GroupBox1.Controls.Add(Me.xtxt_term_code)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.gbx_Condicion)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 192)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'xtxNeto
        '
        Me.xtxNeto.AcceptsReturn = True
        Me.xtxNeto.EditInitialValue = Nothing
        Me.xtxNeto.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxNeto.FieldDescription = ""
        Me.xtxNeto.FindInitialValue = Nothing
        Me.xtxNeto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxNeto.IgnoreRequiered = False
        Me.xtxNeto.Location = New System.Drawing.Point(536, 112)
        Me.xtxNeto.Name = "xtxNeto"
        Me.xtxNeto.NewInitialValue = Nothing
        Me.xtxNeto.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxNeto.ReadOnly = True
        Me.xtxNeto.Requiered = False
        Me.xtxNeto.Size = New System.Drawing.Size(120, 24)
        Me.xtxNeto.StatusBarPanelDescripcion = Nothing
        Me.xtxNeto.TabIndex = 26
        Me.xtxNeto.TabStop = False
        Me.xtxNeto.Text = ""
        Me.xtxNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(492, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 16)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Total:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Itbis
        '
        Me.Itbis.AcceptsReturn = True
        Me.Itbis.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.itbis"))
        Me.Itbis.EditInitialValue = Nothing
        Me.Itbis.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Itbis.FieldDescription = ""
        Me.Itbis.FindInitialValue = Nothing
        Me.Itbis.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Itbis.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Itbis.IgnoreRequiered = False
        Me.Itbis.Location = New System.Drawing.Point(536, 88)
        Me.Itbis.Name = "Itbis"
        Me.Itbis.NewInitialValue = Nothing
        Me.Itbis.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Itbis.ReadOnly = True
        Me.Itbis.Requiered = False
        Me.Itbis.Size = New System.Drawing.Size(120, 24)
        Me.Itbis.StatusBarPanelDescripcion = Nothing
        Me.Itbis.TabIndex = 24
        Me.Itbis.TabStop = False
        Me.Itbis.Text = ""
        Me.Itbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(497, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Itbis:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ftfactm, "fact_nota"))
        Me.TextBox1.EditInitialValue = Nothing
        Me.TextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox1.FieldDescription = ""
        Me.TextBox1.FindInitialValue = Nothing
        Me.TextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox1.IgnoreRequiered = False
        Me.TextBox1.Location = New System.Drawing.Point(80, 160)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.NewInitialValue = Nothing
        Me.TextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox1.Requiered = False
        Me.TextBox1.Size = New System.Drawing.Size(656, 24)
        Me.TextBox1.StatusBarPanelDescripcion = Nothing
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = ""
        '
        'xlk_term_code
        '
        Me.xlk_term_code.AlternateFieldSearch = Nothing
        Me.xlk_term_code.BeginCheck = False
        Me.xlk_term_code.CheckText = Nothing
        Me.xlk_term_code.ComboMode = False
        Me.xlk_term_code.DataMember = Nothing
        Me.xlk_term_code.DataSource = Me.LibXConnector1
        Me.xlk_term_code.DestParameters = New String() {"term_code=term_code", "term_name=term_name", "disc_pct=disc_pct", "due_days=due_days", "disc_days=disc_days"}
        Me.xlk_term_code.FilterField = Nothing
        Me.xlk_term_code.IgnoreFindInBrowseMode = False
        Me.xlk_term_code.isCanceled = False
        Me.xlk_term_code.Location = New System.Drawing.Point(400, 112)
        Me.xlk_term_code.LookCaption = Nothing
        Me.xlk_term_code.Name = "xlk_term_code"
        Me.xlk_term_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_term_code.ShowFilter = True
        Me.xlk_term_code.ShowMessageNotFound = True
        Me.xlk_term_code.ShowWarning = False
        Me.xlk_term_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_term_code.SizesColumns = Nothing
        Me.xlk_term_code.SizesColumnsTab = Nothing
        Me.xlk_term_code.SqlString = Nothing
        Me.xlk_term_code.SQLTab = Nothing
        Me.xlk_term_code.SrcParameters = New String() {"term_code=term_code"}
        Me.xlk_term_code.TabIndex = 11
        Me.xlk_term_code.TableName = "cctermm"
        Me.xlk_term_code.TabStop = False
        Me.xlk_term_code.UseCopyConnection = False
        Me.xlk_term_code.UseRowRetrieveEvents = False
        Me.xlk_term_code.UseTab = False
        Me.xlk_term_code.VisParameters = New String() {"Código=term_code", "Descripción=term_name", "% Descuento=disc_pct", "Vencimiento=due_days"}
        Me.xlk_term_code.WhereCondition = Nothing
        Me.xlk_term_code.WhereParameters = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(18, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Termino:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'term_name
        '
        Me.term_name.AcceptsReturn = True
        Me.term_name.EditInitialValue = Nothing
        Me.term_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.term_name.FieldDescription = ""
        Me.term_name.FindInitialValue = Nothing
        Me.term_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.term_name.IgnoreRequiered = False
        Me.term_name.Location = New System.Drawing.Point(144, 112)
        Me.term_name.Name = "term_name"
        Me.term_name.NewInitialValue = Nothing
        Me.term_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.term_name.ReadOnly = True
        Me.term_name.Requiered = False
        Me.term_name.Size = New System.Drawing.Size(256, 20)
        Me.term_name.StatusBarPanelDescripcion = Nothing
        Me.term_name.TabIndex = 10
        Me.term_name.TabStop = False
        Me.term_name.Text = ""
        '
        'btnCli
        '
        Me.btnCli.Location = New System.Drawing.Point(392, 64)
        Me.btnCli.Name = "btnCli"
        Me.btnCli.Size = New System.Drawing.Size(24, 20)
        Me.btnCli.TabIndex = 3
        Me.btnCli.Text = "..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(9, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "A Nombre:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.fact_date"))
        Me.DateTimePicker1.EditInitialValue = Nothing
        Me.DateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.DateTimePicker1.FieldDescription = ""
        Me.DateTimePicker1.FindInitialValue = Nothing
        Me.DateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.IgnoreRequiered = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(536, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.NewInitialValue = "now"
        Me.DateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.DateTimePicker1.Requiered = False
        Me.DateTimePicker1.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.DateTimePicker1.TabIndex = 19
        '
        'lkCliente
        '
        Me.lkCliente.AlternateFieldSearch = Nothing
        Me.lkCliente.BeginCheck = False
        Me.lkCliente.CheckText = Nothing
        Me.lkCliente.ComboMode = False
        Me.lkCliente.DataMember = Nothing
        Me.lkCliente.DataSource = Me.LibXConnector1
        Me.lkCliente.DestParameters = New String() {"cust_code=cust_code", "cust_name=cust_name", "cbo_price=cust_pricemajor"}
        Me.lkCliente.FilterField = "cust_name"
        Me.lkCliente.IgnoreFindInBrowseMode = False
        Me.lkCliente.isCanceled = False
        Me.lkCliente.Location = New System.Drawing.Point(400, 88)
        Me.lkCliente.LookCaption = "Clientes"
        Me.lkCliente.Name = "lkCliente"
        Me.lkCliente.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkCliente.ShowFilter = True
        Me.lkCliente.ShowMessageNotFound = True
        Me.lkCliente.ShowWarning = False
        Me.lkCliente.Size = New System.Drawing.Size(16, 20)
        Me.lkCliente.SizesColumns = New String() {"cust_name=450"}
        Me.lkCliente.SizesColumnsTab = Nothing
        Me.lkCliente.SqlString = New String() {"select cust_code,cust_name,cctermm.term_code,due_days,disc_days,disc_pct,cust_pri" & _
        "cemajor", "from cccustm inner join cctermm on cccustm.term_code = cctermm.term_code"}
        Me.lkCliente.SQLTab = Nothing
        Me.lkCliente.SrcParameters = New String() {"cust_code=cust_code"}
        Me.lkCliente.TabIndex = 7
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
        Me.lbx_fact_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.fact_status"))
        Me.lbx_fact_status.DefaultWhereString = Nothing
        Me.lbx_fact_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lbx_fact_status.EditInitialValue = Nothing
        Me.lbx_fact_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.lbx_fact_status.FieldDescription = ""
        Me.lbx_fact_status.FindInitialValue = Nothing
        Me.lbx_fact_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lbx_fact_status.IgnoreRequiered = False
        Me.lbx_fact_status.Items.AddRange(New Object() {"1-Pendiente", "2-Cobrado", "3-En espera", "4-Domicilio Pendiente", "0-Anulada"})
        Me.lbx_fact_status.Location = New System.Drawing.Point(536, 16)
        Me.lbx_fact_status.LookupKeyDisplayFields = Nothing
        Me.lbx_fact_status.LookupKeyField = Nothing
        Me.lbx_fact_status.LookupTableName = Nothing
        Me.lbx_fact_status.Name = "lbx_fact_status"
        Me.lbx_fact_status.NewInitialValue = Nothing
        Me.lbx_fact_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.lbx_fact_status.Requiered = False
        Me.lbx_fact_status.Required = False
        Me.lbx_fact_status.Size = New System.Drawing.Size(120, 21)
        Me.lbx_fact_status.SqlString = Nothing
        Me.lbx_fact_status.StatusBarPanelDescripcion = Nothing
        Me.lbx_fact_status.TabIndex = 17
        Me.lbx_fact_status.TabStop = False
        '
        'cust_name
        '
        Me.cust_name.AcceptsReturn = True
        Me.cust_name.EditInitialValue = Nothing
        Me.cust_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cust_name.FieldDescription = ""
        Me.cust_name.FindInitialValue = Nothing
        Me.cust_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cust_name.IgnoreRequiered = False
        Me.cust_name.Location = New System.Drawing.Point(144, 88)
        Me.cust_name.Name = "cust_name"
        Me.cust_name.NewInitialValue = Nothing
        Me.cust_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cust_name.ReadOnly = True
        Me.cust_name.Requiered = False
        Me.cust_name.Size = New System.Drawing.Size(256, 20)
        Me.cust_name.StatusBarPanelDescripcion = Nothing
        Me.cust_name.TabIndex = 6
        Me.cust_name.TabStop = False
        Me.cust_name.Text = ""
        '
        'txtCliCodigo
        '
        Me.txtCliCodigo.AcceptsReturn = True
        Me.txtCliCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.cust_code"))
        Me.txtCliCodigo.EditInitialValue = Nothing
        Me.txtCliCodigo.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCliCodigo.FieldDescription = ""
        Me.txtCliCodigo.FindInitialValue = Nothing
        Me.txtCliCodigo.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCliCodigo.IgnoreRequiered = False
        Me.txtCliCodigo.Location = New System.Drawing.Point(80, 88)
        Me.txtCliCodigo.Name = "txtCliCodigo"
        Me.txtCliCodigo.NewInitialValue = Nothing
        Me.txtCliCodigo.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCliCodigo.Requiered = False
        Me.txtCliCodigo.Size = New System.Drawing.Size(56, 20)
        Me.txtCliCodigo.StatusBarPanelDescripcion = Nothing
        Me.txtCliCodigo.TabIndex = 5
        Me.txtCliCodigo.Text = ""
        '
        'txtfact_number
        '
        Me.txtfact_number.AcceptsReturn = True
        Me.txtfact_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_number"))
        Me.txtfact_number.EditInitialValue = Nothing
        Me.txtfact_number.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtfact_number.FieldDescription = ""
        Me.txtfact_number.FindInitialValue = Nothing
        Me.txtfact_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtfact_number.IgnoreRequiered = True
        Me.txtfact_number.Location = New System.Drawing.Point(80, 40)
        Me.txtfact_number.Name = "txtfact_number"
        Me.txtfact_number.NewInitialValue = Nothing
        Me.txtfact_number.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtfact_number.Requiered = False
        Me.txtfact_number.Size = New System.Drawing.Size(104, 20)
        Me.txtfact_number.StatusBarPanelDescripcion = Nothing
        Me.txtfact_number.TabIndex = 15
        Me.txtfact_number.TabStop = False
        Me.txtfact_number.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(480, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 16)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Estatus:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(486, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMontoBruto
        '
        Me.txtMontoBruto.AcceptsReturn = True
        Me.txtMontoBruto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_total"))
        Me.txtMontoBruto.EditInitialValue = Nothing
        Me.txtMontoBruto.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMontoBruto.FieldDescription = ""
        Me.txtMontoBruto.FindInitialValue = Nothing
        Me.txtMontoBruto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMontoBruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoBruto.IgnoreRequiered = False
        Me.txtMontoBruto.Location = New System.Drawing.Point(536, 64)
        Me.txtMontoBruto.Name = "txtMontoBruto"
        Me.txtMontoBruto.NewInitialValue = Nothing
        Me.txtMontoBruto.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMontoBruto.ReadOnly = True
        Me.txtMontoBruto.Requiered = False
        Me.txtMontoBruto.Size = New System.Drawing.Size(120, 24)
        Me.txtMontoBruto.StatusBarPanelDescripcion = Nothing
        Me.txtMontoBruto.TabIndex = 21
        Me.txtMontoBruto.TabStop = False
        Me.txtMontoBruto.Text = ""
        Me.txtMontoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(486, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Monto:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(24, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cliente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(4, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Factura No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtClinombre
        '
        Me.txtClinombre.AcceptsReturn = True
        Me.txtClinombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClinombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.bus_name"))
        Me.txtClinombre.EditInitialValue = Nothing
        Me.txtClinombre.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtClinombre.FieldDescription = ""
        Me.txtClinombre.FindInitialValue = Nothing
        Me.txtClinombre.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtClinombre.IgnoreRequiered = False
        Me.txtClinombre.Location = New System.Drawing.Point(80, 64)
        Me.txtClinombre.Name = "txtClinombre"
        Me.txtClinombre.NewInitialValue = Nothing
        Me.txtClinombre.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtClinombre.Requiered = False
        Me.txtClinombre.Size = New System.Drawing.Size(312, 20)
        Me.txtClinombre.StatusBarPanelDescripcion = Nothing
        Me.txtClinombre.TabIndex = 2
        Me.txtClinombre.Text = ""
        '
        'xtxt_term_code
        '
        Me.xtxt_term_code.AcceptsReturn = True
        Me.xtxt_term_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.term_code"))
        Me.xtxt_term_code.EditInitialValue = Nothing
        Me.xtxt_term_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_term_code.FieldDescription = ""
        Me.xtxt_term_code.FindInitialValue = Nothing
        Me.xtxt_term_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_term_code.IgnoreRequiered = False
        Me.xtxt_term_code.Location = New System.Drawing.Point(80, 112)
        Me.xtxt_term_code.Name = "xtxt_term_code"
        Me.xtxt_term_code.NewInitialValue = Nothing
        Me.xtxt_term_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_term_code.ReadOnly = True
        Me.xtxt_term_code.Requiered = False
        Me.xtxt_term_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_term_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_term_code.TabIndex = 9
        Me.xtxt_term_code.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(36, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nota:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(21, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "N. C. F.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_ncf"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(80, 16)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(336, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 22
        Me.XTextBox1.Text = ""
        '
        'gbx_Condicion
        '
        Me.gbx_Condicion.Controls.Add(Me.rdbContado)
        Me.gbx_Condicion.Controls.Add(Me.rdbCredito)
        Me.gbx_Condicion.Enabled = False
        Me.gbx_Condicion.Location = New System.Drawing.Point(248, 32)
        Me.gbx_Condicion.Name = "gbx_Condicion"
        Me.gbx_Condicion.Size = New System.Drawing.Size(168, 32)
        Me.gbx_Condicion.TabIndex = 0
        Me.gbx_Condicion.TabStop = False
        Me.gbx_Condicion.Text = "Condición de venta"
        '
        'rdbContado
        '
        Me.rdbContado.Checked = True
        Me.rdbContado.Location = New System.Drawing.Point(8, 12)
        Me.rdbContado.Name = "rdbContado"
        Me.rdbContado.Size = New System.Drawing.Size(72, 16)
        Me.rdbContado.TabIndex = 0
        Me.rdbContado.TabStop = True
        Me.rdbContado.Text = "Contado"
        '
        'rdbCredito
        '
        Me.rdbCredito.Location = New System.Drawing.Point(88, 12)
        Me.rdbCredito.Name = "rdbCredito"
        Me.rdbCredito.Size = New System.Drawing.Size(72, 16)
        Me.rdbCredito.TabIndex = 1
        Me.rdbCredito.Text = "Crédito"
        '
        'vend_name
        '
        Me.vend_name.AcceptsReturn = True
        Me.vend_name.EditInitialValue = Nothing
        Me.vend_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.vend_name.FieldDescription = ""
        Me.vend_name.FindInitialValue = Nothing
        Me.vend_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.vend_name.IgnoreRequiered = False
        Me.vend_name.Location = New System.Drawing.Point(152, 32)
        Me.vend_name.Name = "vend_name"
        Me.vend_name.NewInitialValue = Nothing
        Me.vend_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.vend_name.ReadOnly = True
        Me.vend_name.Requiered = False
        Me.vend_name.Size = New System.Drawing.Size(256, 20)
        Me.vend_name.StatusBarPanelDescripcion = Nothing
        Me.vend_name.TabIndex = 3
        Me.vend_name.TabStop = False
        Me.vend_name.Text = ""
        '
        'txtvend_code
        '
        Me.txtvend_code.AcceptsReturn = True
        Me.txtvend_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.vend_code"))
        Me.txtvend_code.EditInitialValue = Nothing
        Me.txtvend_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtvend_code.FieldDescription = ""
        Me.txtvend_code.FindInitialValue = Nothing
        Me.txtvend_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtvend_code.IgnoreRequiered = False
        Me.txtvend_code.Location = New System.Drawing.Point(88, 32)
        Me.txtvend_code.Name = "txtvend_code"
        Me.txtvend_code.NewInitialValue = Nothing
        Me.txtvend_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtvend_code.Requiered = False
        Me.txtvend_code.Size = New System.Drawing.Size(56, 20)
        Me.txtvend_code.StatusBarPanelDescripcion = Nothing
        Me.txtvend_code.TabIndex = 2
        Me.txtvend_code.Text = ""
        '
        'xlk_vend_code
        '
        Me.xlk_vend_code.AlternateFieldSearch = Nothing
        Me.xlk_vend_code.BeginCheck = False
        Me.xlk_vend_code.CheckText = Nothing
        Me.xlk_vend_code.ComboMode = False
        Me.xlk_vend_code.DataMember = Nothing
        Me.xlk_vend_code.DataSource = Me.LibXConnector1
        Me.xlk_vend_code.DestParameters = New String() {"vend_code=vend_code", "vend_name=vend_name", "porc_comision=porc_comision"}
        Me.xlk_vend_code.FilterField = Nothing
        Me.xlk_vend_code.IgnoreFindInBrowseMode = False
        Me.xlk_vend_code.isCanceled = False
        Me.xlk_vend_code.Location = New System.Drawing.Point(408, 32)
        Me.xlk_vend_code.LookCaption = "Vendedores"
        Me.xlk_vend_code.Name = "xlk_vend_code"
        Me.xlk_vend_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_vend_code.ShowFilter = True
        Me.xlk_vend_code.ShowMessageNotFound = True
        Me.xlk_vend_code.ShowWarning = False
        Me.xlk_vend_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_vend_code.SizesColumns = Nothing
        Me.xlk_vend_code.SizesColumnsTab = Nothing
        Me.xlk_vend_code.SqlString = Nothing
        Me.xlk_vend_code.SQLTab = Nothing
        Me.xlk_vend_code.SrcParameters = New String() {"vend_code=vend_code"}
        Me.xlk_vend_code.TabIndex = 4
        Me.xlk_vend_code.TableName = "ftvendm"
        Me.xlk_vend_code.TabStop = False
        Me.xlk_vend_code.UseCopyConnection = False
        Me.xlk_vend_code.UseRowRetrieveEvents = False
        Me.xlk_vend_code.UseTab = False
        Me.xlk_vend_code.VisParameters = New String() {"Código=vend_code", "Nombre=vend_name"}
        Me.xlk_vend_code.WhereCondition = Nothing
        Me.xlk_vend_code.WhereParameters = Nothing
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
        Me.LibXGridDetalle.DataMember = "ftfactd1"
        Me.LibXGridDetalle.DataSource = Me.DataSet1
        Me.LibXGridDetalle.FullRowSelect = False
        Me.LibXGridDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGridDetalle.IsReadOnly = False
        Me.LibXGridDetalle.Location = New System.Drawing.Point(0, 256)
        Me.LibXGridDetalle.Name = "LibXGridDetalle"
        Me.LibXGridDetalle.ReadOnly = True
        Me.LibXGridDetalle.searchText = ""
        Me.LibXGridDetalle.showFooterBar = True
        Me.LibXGridDetalle.Size = New System.Drawing.Size(744, 208)
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
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn1, Me.xetx_Price, Me.gColItbis, Me.gColImporte})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ftfactd1"
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Descripción"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "descr"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 475
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Linea"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = True
        Me.XEditTextBoxColumn1.MappingName = "line_no"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.ReadOnly = True
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 0
        '
        'xetx_Price
        '
        Me.xetx_Price.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xetx_Price.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xetx_Price.Format = "##,###,###.00"
        Me.xetx_Price.FormatInfo = Nothing
        Me.xetx_Price.HeaderText = "Precio"
        Me.xetx_Price.ImageList = Nothing
        Me.xetx_Price.isReadOnly = False
        Me.xetx_Price.MappingName = "price"
        Me.xetx_Price.MaxLength = 32767
        Me.xetx_Price.TabStop = True
        Me.xetx_Price.UseCustomCellFormat = False
        Me.xetx_Price.Width = 75
        '
        'gColItbis
        '
        Me.gColItbis.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColItbis.Format = "###,###.00"
        Me.gColItbis.FormatInfo = Nothing
        Me.gColItbis.HeaderText = "Itbis"
        Me.gColItbis.MappingName = "itbis"
        Me.gColItbis.Width = 75
        '
        'gColImporte
        '
        Me.gColImporte.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColImporte.Format = "##,##,###.00"
        Me.gColImporte.FormatInfo = Nothing
        Me.gColImporte.HeaderText = "Importe"
        Me.gColImporte.MappingName = "importe"
        Me.gColImporte.NullText = "0"
        Me.gColImporte.ReadOnly = True
        Me.gColImporte.Width = 75
        '
        'i_ftfact02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(762, 520)
        Me.Controls.Add(Me.vend_name)
        Me.Controls.Add(Me.txtvend_code)
        Me.Controls.Add(Me.LibXGridDetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.xlk_vend_code)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ftfact02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Facturación de Servicios"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactd1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_Condicion.ResumeLayout(False)
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim mTipoNCF As SGT.Inventario.Entidades.Documento.TipoNCFEnum
    Dim mCli As ParametroCliente
    Dim mSerial As Integer
    Dim mPricemajor As Boolean
    Dim mRowIvSetup As DataRow
    Dim mConf As SGT.Inventario.Common.Configuration
    Dim mFactNum As Integer
    Dim WhereStmt As String
    Dim WhDefault As Integer
    Dim ScDefault As Integer
    Dim Accion As Integer
    Dim oDocumento As SGT.Inventario.Entidades.Documento
    Private Sub i_ftfact01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mConf = New SGT.Inventario.Common.Configuration
            Me.DataSet1.Tables("ftfactd1").Columns("Importe").Expression = "(price+itbis)"
            LibXGridDetalle.footerOperations.add("price", "sum(price)")
            LibXGridDetalle.footerOperations.add("itbis", "sum(itbis)")
            LibXGridDetalle.footerOperations.add("importe", "sum(importe)")
            xetx_Price.TextBox.CharacterCasing = CharacterCasing.Upper
            XEditTextBoxColumn2.TextBox.MaxLength = 40
            WhDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibXWhDefault")
            ScDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibXScDefault")

            If Not LibXConnector1.Parameters Is Nothing Then
                If LibXConnector1.Parameters.Value.ToString.Length > 0 Then
                    WhereStmt = "ftfactm.ftserial_no = " & LibXConnector1.Parameters.Value.ToString
                    LibXConnector1.ExecuteFind(WhereStmt)
                End If
            End If
            If Not Configuration.ConfigurationSettings.AppSettings.Get("LibxDefaultCaja") Is Nothing Then
                mCajaDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibxDefaultCaja").ToString)
            End If
            If Not Configuration.ConfigurationSettings.AppSettings.Get("LibxDefaultCajera") Is Nothing Then
                mCajeDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibxDefaultCajera").ToString)
            End If

            oDocumento = New SGT.Inventario.Entidades.Documento("FTS")
            oDoc = New SGT.Facturacion.Entidades.Documento


        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCli.Click
    '    Try
    '        Dim objForm As New i_ftcustm01

    '        If mCli Is Nothing Then
    '            mCli = New ParametroCliente
    '        End If

    '        mCli.Modalidad = LibXConnector1.State
    '        mCli.Company = Me.txtClinombre.Text
    '        mCli.Tel = LibXConnector1.CurrentDataRow!phone.ToString

    '        objForm.Cli = mCli

    '        objForm.ShowDialog()

    '        If Not objForm.ok Then
    '            mCli = Nothing
    '        Else
    '            mCli.Company = objForm.Cli.Company
    '            Me.txtClinombre.Text = mCli.Company
    '            mCli.Contact = objForm.Cli.Contact
    '            mCli.Tel = objForm.Cli.Tel
    '            mCli.TelArea = objForm.Cli.TelArea
    '            mCli.Tel2 = objForm.Cli.Tel2
    '            mCli.Mail = objForm.Cli.Mail
    '            mCli.Address = objForm.Cli.Address
    '        End If
    '    Catch ex As Exception
    '        Log.Show(ex)
    '    End Try
    'End Sub

    Private Sub ActualizaTotal()
        Try
            Dim i As Integer
            Dim tPrice As Decimal = 0
            Dim tItbis As Decimal = 0
            Dim MontoBruto As Decimal = 0.0
            Dim MontoNeto As Decimal = 0.0

            MontoBruto = Val(ftfactd1.Compute("sum(importe)", "1=1").ToString.Trim) _
                       - Val(ftfactd1.Compute("sum(itbis)", "1=1").ToString.Trim)

            tItbis = Val(ftfactd1.Compute("sum(itbis)", "1=1").ToString.Trim)
            Me.Itbis.Text = CDec(tItbis).ToString("###,##0.00")

            Me.txtMontoBruto.Text = CDec(MontoBruto).ToString("###,##0.00")
            MontoNeto = MontoBruto + tItbis
            Me.xtxNeto.Text = CDec(MontoNeto).ToString("###,##0.00")

        Catch ex As Exception
            Log.Show(ex)
        End Try


    End Sub


    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then

                Dim intLast As Object
                Dim sSql As String
                'oCajera = New Cajera(LibX.User.VendedorID)
                'oCaja = New Caja(CajaAbierta.CajaCode)
                ''// Buscar cajas abiertas
                'oCajaAbierta = New CajaAbierta

                ActualizaTotal()

                e.UpdatingArgs.Row!type_code = "FTS" '// FACTURACION DE SERVICIOS
                e.UpdatingArgs.Row!fact_cond = 2
                e.UpdatingArgs.Row!fact_status = 1 ' "Pendiente de cobro" (1)  en la table ftfactm\
                e.UpdatingArgs.Row!caja_code = mCajaDefault
                e.UpdatingArgs.Row!caje_code = mCajeDefault
                e.UpdatingArgs.Row!itbis = Me.Itbis.Text
                e.UpdatingArgs.Row!descto = 0
                e.UpdatingArgs.Row!fact_inddomicilio = 0
                e.UpdatingArgs.Row!whse_code = WhDefault
                e.UpdatingArgs.Row!suc_code = ScDefault
                If LibX.IsNull(e.UpdatingArgs.Row!fact_date) Then
                    e.UpdatingArgs.Row!fact_date = LibX.Data.Manager.Connection.GetDate
                End If

                If Not mCli Is Nothing Then
                    e.UpdatingArgs.Row!phone = mCli.Tel
                End If

                If Me.rdbContado.Checked Then
                    e.UpdatingArgs.Row!fact_cond = 1
                End If

                e.UpdatingArgs.Row!fact_number = oDocumento.GenerateNumber("FTS")
                If mTipoNCF <> SGT.Inventario.Entidades.Documento.TipoNCFEnum.None Then
                    e.UpdatingArgs.Row!fact_ncf = oDocumento.GenerateNCF("FPV", WhDefault, mTipoNCF)
                End If

            End If

        Catch ex As Exception
            Log.Add(ex)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred

        End Try
    End Sub

    Private Sub AplicarInventario()
        Dim oPostDoc As SGT.Facturacion.Operaciones.PosteoDocumento
        Dim oPostParam As SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

        Try

            oPostDoc = New SGT.Facturacion.Operaciones.PosteoDocumento
            oPostParam = New SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

            oPostParam.SerialNumero = LibXConnector1.CurrentDataRow!ftserial_no
            oPostParam.UseTransaction = True
            oPostParam.AplicarInventario = True
            oPostParam.AplicarCXC = False
            oPostParam.ApliarComision = False

            oPostDoc.Aplicar(oPostParam)

        Catch ex As Exception
            Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_InsertedRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedRow
        Try

            If e.UpdatingArgs.StatementType = StatementType.Update Then
                mSerial = e.Serial
                If Not mCli Is Nothing And Me.rdbContado.Checked Then
                    If mCli.Company.ToString.Length <= 0 Then
                        Exit Sub
                    End If

                    If mCli.Tel.ToString.Length <= 0 Then
                        Exit Sub
                    End If

                    Dim oS As LibX.Data.XUpdateStmt
                    oS = New LibX.Data.XUpdateStmt("ftcustm")

                    oS.FieldsSet("cust_name") = mCli.Contact
                    oS.FieldsSet("company_name") = mCli.Company
                    oS.FieldsSet("area_code") = mCli.TelArea
                    os.FieldsSet("phone1") = mCli.Tel2
                    os.FieldsSet("email") = mCli.Mail
                    os.FieldsSet("address") = mCli.Address

                    oS.Fields("phone") = mCli.Tel

                    oS.Execute()
                End If
            End If

            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                Dim oS As LibX.Data.XInsertStmt
                mSerial = e.Serial

                If Not mCli Is Nothing AndAlso mCli.Found = False AndAlso Me.rdbContado.Checked Then
                    oS = New LibX.Data.XInsertStmt("ftcustm")
                    oS!cust_name = mCli.Contact
                    oS!company_name = mCli.Company
                    oS!area_code = mCli.TelArea
                    oS!phone = mCli.Tel
                    os!phone1 = mCli.Tel2
                    os!email = mCli.Mail
                    os!address = mCli.Address
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
                If (LibXConnector1.CurrentDataRow!fact_status = 0 Or LibXConnector1.CurrentDataRow!fact_status > 2) Then
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
                    mCli.Contact = Me.txtClinombre.Text
                    rdbContado.Checked = True
                    txtClinombre.Text = "CONTADO"
                    txtvend_code.Text = 1


                    If Trim(mCli.Contact) = "" Then
                        Throw New Exception("Debe completar la información del cliente")
                    End If

                    If Trim(mCli.Company) = "" Then
                        Throw New Exception("Debe completar la información del cliente")
                    End If
                End If
            End If
            Accion = e.Action
            If e.Action = LibxConnectionActions.Accept Then
                ActualizaTotal()
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

            xtxt_term_code.Text = e.row!term_code
            xlk_term_code.ExecuteFind()

            If txtClinombre.Text.Length <= 0 Then
                txtClinombre.Text = e.row!cust_name
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
            rdbContado.Checked = True
            txtClinombre.Text = "CONTADO"
            txtvend_code.Text = 1

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Dim SelecStmt As String
        Dim AxCrystalReport1 As LibX.ReportLib

        Try
            Me.Cursor = Cursors.WaitCursor
            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
                '// Tomar el Connection String del config
                AxCrystalReport1 = New LibX.ReportLib("FCT", "r_ftfact03.rpt")

                With AxCrystalReport1
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

        Finally
            Me.Cursor = Cursors.Default
            AxCrystalReport1 = Nothing

        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            e.AditionalWhere = "type_code = 'FTS'"
            WhereStmt = e.Where

            e.Sql = oDoc.PrepareSelectStmt(e.Sql)

        Catch ex As Exception
            LibX.Log.Add(ex, True)

        End Try
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibxConnectionActions.Add Then
                mCli = Nothing
                Me.rdbContado.Checked = True
                mPricemajor = False
                lbx_fact_status.currValue = 1
                txtfact_number.ReadOnly = True

                rdbContado.Checked = True
                txtClinombre.Text = "CONTADO"
                txtvend_code.Text = 1

                If LibX.User.VendedorID > 0 Then
                    txtvend_code.Text = LibX.User.VendedorID
                    xlk_vend_code.ExecuteFind()
                End If
                mTipoNCF = SGT.Inventario.Entidades.Documento.TipoNCFEnum.None
                '''Dim oTipo As New frmTipo
                '''If oTipo.ShowDialog = DialogResult.OK Then
                '''    mTipoNCF = oTipo.TipoNCF
                '''End If
                LibXGridDetalle.Focus(0, 0)
            End If

            If e.Action = LibxConnectionActions.Find Then
                txtfact_number.ReadOnly = False
            End If

            'If e.AcceptedAction = LibxConnectionActions.Add Then
            '    If LibXConnector1.CurrentDataRow!fact_cond.ToString.Trim = "1" Then  'Contado
            '        Dim XUpdate As LibX.Data.XUpdateStmt
            '        Dim NCF As String

            '        NCF = oDocumento.GenerateNCF("FPV", WhDefault, mTipoNCF)

            '        XUpdate = New LibX.Data.XUpdateStmt("ftfactm")
            '        XUpdate.FieldsSet("fact_ncf") = NCF
            '        XUpdate.Fields("ftserial_no") = LibXConnector1.CurrentDataRow!ftserial_no
            '        XUpdate.Execute()

            '        XUpdate = Nothing
            '    End If
            'End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub lkp_item_code_CreatedGridColumns(ByVal sender As System.Object, ByVal e As LibX.CreatedGridColumnsEventArgs)
        Try
            e.TStyle.GridColumnStyles.Item("item_name").Width = 300

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
        btnCli.Enabled = (e.isEditing Or LibXConnector1.HasRecords = True)


    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Try
            If LibXGridDetalle.CurrentRowIndex > -1 Then
                If MessageBox.Show("Seguro desea borrar este item?", "Borrar Linea", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    If ftfactd1.Rows.Count > LibXGridDetalle.CurrentRowIndex Then
                        ftfactd1.Rows.RemoveAt(LibXGridDetalle.CurrentRowIndex)
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
            Me.DateTimePicker1.Value = LibX.Data.Manager.Connection.GetDate
        End If
    End Sub
    Private Sub LibXConnector1_RowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange
        Try
            If Not LibXConnector1.CurrentDataRow Is Nothing Then
                If LibXConnector1.CurrentDataRow!fact_cond = 1 Then '// Contado
                    rdbContado.Checked = True
                Else
                    rdbCredito.Checked = True
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub LibXConnector1_AfterLoadDetail(ByVal sender As Object, ByVal e As LibX.XbeforeLoadDetailEventArgs) Handles LibXConnector1.AfterLoadDetail
        '''Try
        '''    If Not LibXConnector1.IsEditing Then
        '''        ActualizaTotal()
        '''    End If

        '''Catch ex As Exception
        '''    LibX.Log.Add(ex, True)
        '''End Try

    End Sub
    Private Sub LibXGridDetalle_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGridDetalle.CellValidate
        Dim Itb As Decimal
        Dim Impte As Decimal
        Try
            If LibXConnector1.IsEditing Then
                If e.cell = Me.xetx_Price.Column Then
                    Itb = (e.value * mConf.GetITBIS) / 100
                    LibXGridDetalle.SetValue(e.row, Me.gColItbis, Itb)
                End If
                If e.cell = Me.xetx_Price.Column Then
                    Impte = (e.value + Itb)
                    LibXGridDetalle.SetValue(e.row, Me.gColImporte, Impte)
                End If
            End If
            ActualizaTotal()
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub xlk_vend_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_vend_code.AfterSetValues
        Try
            If LibXConnector1.IsDataEditing = True Then
                LibXConnector1.CurrentDataRow!porc_comision = e.row!porc_comision
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub LibXNavigator1_ActionClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.ActionClick
        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Accept _
            AndAlso (LibXConnector1.CurrentAction = LibxConnectionActions.Add _
            OrElse LibXConnector1.CurrentAction = LibxConnectionActions.Edit) Then
                ActualizaTotal()
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGridDetalle.CurrentRowChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                ActualizaTotal()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If LibXConnector1.IsEditing = False AndAlso LibXConnector1.HasRecords = True Then
                ActualizaTotal()

                If e.row!fact_status = 2 Then
                    LibXConnector1.AllowDelete = False
                    LibXConnector1.AllowEdit = False
                Else
                    LibXConnector1.AllowDelete = True
                    LibXConnector1.AllowEdit = True
                End If
                LibXNavigator1.UpdateState()

            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub txtvend_code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvend_code.TextChanged

    End Sub
End Class
