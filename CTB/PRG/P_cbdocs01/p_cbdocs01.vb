Imports SGT.Contabilidad.Entidades
Public Class p_cbdocs01
    Inherits System.Windows.Forms.Form
    Dim oDocumento As SGT.Contabilidad.Entidades.Documentos
    Dim oChequera As SGT.ControlBancario.Entidades.Chequera
    Dim oOrigen As SGT.Inventario.Entidades.Documento
    Dim Bce_banco_mov As Decimal
    Dim Bce_diferencia As Decimal
    Dim AddConc As Integer

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
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents LibXDbSourceTable5 As LibX.LibXDbSourceTable
    Friend WithEvents xlk_chequera As LibX.LibXLookup
    Friend WithEvents xtxt_chequera_name As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents xtxt_chequera As LibX.XTextBox
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents xlk_doc_number As LibX.LibXLookup
    Friend WithEvents XDataGridTextButtonColumn1 As LibX.XDataGridTextButtonColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents gcoltran_type As LibX.XDataGridTextButtonColumn
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents xdt_FechaCorte As LibX.LibxDateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents xtxt_conc_serial As LibX.XTextBox
    Friend WithEvents btnVisualizar As System.Windows.Forms.Button
    Friend WithEvents gcolcbm_serial As LibX.XEditTextBoxColumn
    Friend WithEvents cbdocsm As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
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
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents xdg_Aplicar As LibX.XDataGridBoolColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnMarkAll As System.Windows.Forms.Button
    Friend WithEvents btnUnMarkAll As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents xtxt_bce_banco As LibX.XTextBox
    Friend WithEvents xtxt_bce_segun_bco As LibX.XTextBox
    Friend WithEvents gcolamount As LibX.XEditTextBoxColumn
    Friend WithEvents xtxt_bce_libro As LibX.XTextBox
    Friend WithEvents xtxt_Diferencia As LibX.XTextBox
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents gColMonto As LibX.XEditTextBoxColumn
    Friend WithEvents Xcbo_tran_type As LibX.LibXCombo
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents xtxt_doc_number As LibX.XTextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents xdg_Documentos As LibX.LibXGrid
    Friend WithEvents xgp_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents xcbo_conc_status As LibX.LibXCombo
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.xcbo_conc_status = New LibX.LibXCombo
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.cbdocsm = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
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
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable5 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.xtxt_bce_banco = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.xtxt_Diferencia = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.xtxt_bce_segun_bco = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.xtxt_bce_libro = New LibX.XTextBox
        Me.btnLoad = New System.Windows.Forms.Button
        Me.xdt_FechaCorte = New LibX.LibxDateTimePicker
        Me.xlk_chequera = New LibX.LibXLookup
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.xtxt_chequera = New LibX.XTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.xtxt_chequera_name = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.xtxt_conc_serial = New LibX.XTextBox
        Me.xdg_Documentos = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.xdg_Aplicar = New LibX.XDataGridBoolColumn
        Me.gcoltran_type = New LibX.XDataGridTextButtonColumn
        Me.XDataGridTextButtonColumn1 = New LibX.XDataGridTextButtonColumn
        Me.xlk_doc_number = New LibX.LibXLookup
        Me.gcolcbm_serial = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.gColMonto = New LibX.XEditTextBoxColumn
        Me.gcolamount = New LibX.XEditTextBoxColumn
        Me.btnVisualizar = New System.Windows.Forms.Button
        Me.btnMarkAll = New System.Windows.Forms.Button
        Me.btnUnMarkAll = New System.Windows.Forms.Button
        Me.xgp_Filtro = New System.Windows.Forms.GroupBox
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.xtxt_doc_number = New LibX.XTextBox
        Me.Xcbo_tran_type = New LibX.LibXCombo
        Me.Label8 = New System.Windows.Forms.Label
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.DataView1 = New System.Data.DataView
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbdocsm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.xdg_Documentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xgp_Filtro.SuspendLayout()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xcbo_conc_status
        '
        Me.xcbo_conc_status.AllowDefaultSort = True
        Me.xcbo_conc_status.bound = True
        Me.xcbo_conc_status.currValue = Nothing
        Me.xcbo_conc_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cbconcm.conc_status"))
        Me.xcbo_conc_status.DefaultWhereString = Nothing
        Me.xcbo_conc_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_conc_status.EditInitialValue = Nothing
        Me.xcbo_conc_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_conc_status.FieldDescription = ""
        Me.xcbo_conc_status.FindInitialValue = "2"
        Me.xcbo_conc_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_conc_status.IgnoreRequiered = False
        Me.xcbo_conc_status.Items.AddRange(New Object() {"1-Cerrada", "2-Pendiente", "0-Anulado"})
        Me.xcbo_conc_status.Location = New System.Drawing.Point(328, 16)
        Me.xcbo_conc_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_conc_status.LookupKeyField = Nothing
        Me.xcbo_conc_status.LookupTableName = Nothing
        Me.xcbo_conc_status.Name = "xcbo_conc_status"
        Me.xcbo_conc_status.NewInitialValue = "2"
        Me.xcbo_conc_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_conc_status.Requiered = False
        Me.xcbo_conc_status.Required = False
        Me.xcbo_conc_status.Size = New System.Drawing.Size(112, 21)
        Me.xcbo_conc_status.SqlString = Nothing
        Me.xcbo_conc_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_conc_status.TabIndex = 3
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.cbdocsm})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn26, Me.DataColumn27, Me.DataColumn29, Me.DataColumn16, Me.DataColumn17, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"conc_serial"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn3}
        Me.DataTable1.TableName = "cbconcm"
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.AutoIncrement = True
        Me.DataColumn3.ColumnName = "conc_serial"
        Me.DataColumn3.DataType = GetType(System.Int32)
        Me.DataColumn3.ReadOnly = True
        '
        'DataColumn26
        '
        Me.DataColumn26.AllowDBNull = False
        Me.DataColumn26.ColumnName = "conc_date"
        Me.DataColumn26.DataType = GetType(System.DateTime)
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "chequera"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "conc_status"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "Saldo_ant"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "Saldo_Banco"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "Saldo_Libro"
        Me.DataColumn23.DataType = GetType(System.Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "Saldo_cerrado"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "Saldo_conciliado"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        '
        'cbdocsm
        '
        Me.cbdocsm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn28, Me.DataColumn30, Me.DataColumn31})
        Me.cbdocsm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"doc_number", "tran_type", "chequera", "suc_code"}, True)})
        Me.cbdocsm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn4, Me.DataColumn2, Me.DataColumn28}
        Me.cbdocsm.TableName = "cbdocsm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "cbm_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "chequera"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "tran_type"
        Me.DataColumn4.MaxLength = 3
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "doc_number"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "doc_date"
        Me.DataColumn6.DataType = GetType(System.DateTime)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "doc_status"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Benef"
        Me.DataColumn8.MaxLength = 60
        Me.DataColumn8.ReadOnly = True
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "doc_concept"
        Me.DataColumn9.MaxLength = 3000
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "amount"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        Me.DataColumn10.ReadOnly = True
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "conc_serial"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "perdr_year"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "perdr_num"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "date_conc"
        Me.DataColumn14.DataType = GetType(System.DateTime)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "date_created"
        Me.DataColumn15.DataType = GetType(System.DateTime)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "userid"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "doc_origen"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "tranr_serial"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "Aplicar"
        Me.DataColumn21.DataType = GetType(System.Int16)
        Me.DataColumn21.DefaultValue = CType(0, Short)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "Monto"
        Me.DataColumn22.DataType = GetType(System.Decimal)
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.ColumnName = "suc_code"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "conc_transito"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "doc_transito"
        Me.DataColumn31.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.TableName = Nothing
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(744, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = True
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "cbconcm"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable3, Me.LibXDbSourceTable5})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
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
        Me.LibXDbSourceTable3.SerialColumnName = "conc_serial"
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = Nothing
        Me.LibXDbSourceTable3.TableName = "cbconcm"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'LibXDbSourceTable5
        '
        Me.LibXDbSourceTable5.AllowDelete = True
        Me.LibXDbSourceTable5.AllowEdit = True
        Me.LibXDbSourceTable5.AllowNew = True
        Me.LibXDbSourceTable5.AutoIncrementSerial = False
        Me.LibXDbSourceTable5.CustomDbUpdate = True
        Me.LibXDbSourceTable5.DeleteOrder = 0
        Me.LibXDbSourceTable5.FillOnQuery = True
        Me.LibXDbSourceTable5.FillOnRowChange = True
        Me.LibXDbSourceTable5.HeaderIsOnGrid = False
        Me.LibXDbSourceTable5.InnerJon = True
        Me.LibXDbSourceTable5.InsertOrder = 0
        Me.LibXDbSourceTable5.IsDetail = True
        Me.LibXDbSourceTable5.KeyFields = Nothing
        Me.LibXDbSourceTable5.LineColName = Nothing
        Me.LibXDbSourceTable5.MasterDetailRelation = New String() {"conc_serial=conc_serial"}
        Me.LibXDbSourceTable5.MasterTableName = Nothing
        Me.LibXDbSourceTable5.SerialColumnName = Nothing
        Me.LibXDbSourceTable5.Sort = Nothing
        Me.LibXDbSourceTable5.Source = New String() {"select cbm_serial  ", ",chequera    ", ",tran_type ", ",doc_number  ", ",doc_date                                               ", ",doc_status  ", ",case doc_status when 0 then '*** ANULADO ***' else benef end benef", ",doc_concept                                                                     " & _
        "", ",case doc_status when 0 then 0 else amount end amount", ",conc_serial ", ",perdr_year  ", ",perdr_num   ", ",date_conc                                              ", ",date_created                                           ", ",userid      ", ",doc_origen  ", ",tranr_serial", ",suc_code  ", ",conc_transito", ",doc_transito", "from cbdocsm"}
        Me.LibXDbSourceTable5.TableName = "cbdocsm"
        Me.LibXDbSourceTable5.UpdateOrder = 0
        Me.LibXDbSourceTable5.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.xtxt_bce_banco)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xtxt_Diferencia)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xtxt_bce_segun_bco)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xtxt_bce_libro)
        Me.GroupBox1.Controls.Add(Me.btnLoad)
        Me.GroupBox1.Controls.Add(Me.xcbo_conc_status)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaCorte)
        Me.GroupBox1.Controls.Add(Me.xlk_chequera)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xtxt_chequera)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.xtxt_chequera_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xtxt_conc_serial)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 144)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(392, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Balance en Banco:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_bce_banco
        '
        Me.xtxt_bce_banco.AcceptsReturn = True
        Me.xtxt_bce_banco.AutoSize = False
        Me.xtxt_bce_banco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbconcm.Saldo_conciliado"))
        Me.xtxt_bce_banco.EditInitialValue = Nothing
        Me.xtxt_bce_banco.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_bce_banco.FieldDescription = ""
        Me.xtxt_bce_banco.FindInitialValue = Nothing
        Me.xtxt_bce_banco.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_bce_banco.IgnoreRequiered = False
        Me.xtxt_bce_banco.Location = New System.Drawing.Point(503, 88)
        Me.xtxt_bce_banco.Name = "xtxt_bce_banco"
        Me.xtxt_bce_banco.NewInitialValue = Nothing
        Me.xtxt_bce_banco.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_bce_banco.ReadOnly = True
        Me.xtxt_bce_banco.Requiered = False
        Me.xtxt_bce_banco.Size = New System.Drawing.Size(112, 20)
        Me.xtxt_bce_banco.StatusBarPanelDescripcion = Nothing
        Me.xtxt_bce_banco.TabIndex = 19
        Me.xtxt_bce_banco.Text = ""
        Me.xtxt_bce_banco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(431, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Diferencia:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_Diferencia
        '
        Me.xtxt_Diferencia.AcceptsReturn = True
        Me.xtxt_Diferencia.EditInitialValue = Nothing
        Me.xtxt_Diferencia.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_Diferencia.FieldDescription = ""
        Me.xtxt_Diferencia.FindInitialValue = Nothing
        Me.xtxt_Diferencia.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Diferencia.IgnoreRequiered = False
        Me.xtxt_Diferencia.Location = New System.Drawing.Point(503, 112)
        Me.xtxt_Diferencia.Name = "xtxt_Diferencia"
        Me.xtxt_Diferencia.NewInitialValue = Nothing
        Me.xtxt_Diferencia.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_Diferencia.ReadOnly = True
        Me.xtxt_Diferencia.Requiered = False
        Me.xtxt_Diferencia.Size = New System.Drawing.Size(112, 20)
        Me.xtxt_Diferencia.StatusBarPanelDescripcion = Nothing
        Me.xtxt_Diferencia.TabIndex = 4
        Me.xtxt_Diferencia.Text = ""
        Me.xtxt_Diferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(1, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Bce. Segun Banco:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_bce_segun_bco
        '
        Me.xtxt_bce_segun_bco.AcceptsReturn = True
        Me.xtxt_bce_segun_bco.AutoSize = False
        Me.xtxt_bce_segun_bco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbconcm.Saldo_Banco"))
        Me.xtxt_bce_segun_bco.EditInitialValue = Nothing
        Me.xtxt_bce_segun_bco.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_bce_segun_bco.FieldDescription = ""
        Me.xtxt_bce_segun_bco.FindInitialValue = Nothing
        Me.xtxt_bce_segun_bco.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_bce_segun_bco.IgnoreRequiered = False
        Me.xtxt_bce_segun_bco.Location = New System.Drawing.Point(112, 64)
        Me.xtxt_bce_segun_bco.Name = "xtxt_bce_segun_bco"
        Me.xtxt_bce_segun_bco.NewInitialValue = Nothing
        Me.xtxt_bce_segun_bco.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_bce_segun_bco.Requiered = False
        Me.xtxt_bce_segun_bco.Size = New System.Drawing.Size(112, 20)
        Me.xtxt_bce_segun_bco.StatusBarPanelDescripcion = Nothing
        Me.xtxt_bce_segun_bco.TabIndex = 3
        Me.xtxt_bce_segun_bco.Text = ""
        Me.xtxt_bce_segun_bco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(399, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Bce. Segun Libro:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_bce_libro
        '
        Me.xtxt_bce_libro.AcceptsReturn = True
        Me.xtxt_bce_libro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbconcm.Saldo_Libro"))
        Me.xtxt_bce_libro.EditInitialValue = Nothing
        Me.xtxt_bce_libro.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_bce_libro.FieldDescription = ""
        Me.xtxt_bce_libro.FindInitialValue = Nothing
        Me.xtxt_bce_libro.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_bce_libro.IgnoreRequiered = False
        Me.xtxt_bce_libro.Location = New System.Drawing.Point(503, 64)
        Me.xtxt_bce_libro.Name = "xtxt_bce_libro"
        Me.xtxt_bce_libro.NewInitialValue = Nothing
        Me.xtxt_bce_libro.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_bce_libro.Requiered = False
        Me.xtxt_bce_libro.Size = New System.Drawing.Size(112, 20)
        Me.xtxt_bce_libro.StatusBarPanelDescripcion = Nothing
        Me.xtxt_bce_libro.TabIndex = 13
        Me.xtxt_bce_libro.Text = ""
        Me.xtxt_bce_libro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnLoad
        '
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoad.Location = New System.Drawing.Point(648, 96)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 40)
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "Cargar"
        '
        'xdt_FechaCorte
        '
        Me.xdt_FechaCorte.CustomFormat = "yyyy/mm/dd"
        Me.xdt_FechaCorte.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cbconcm.conc_date"))
        Me.xdt_FechaCorte.EditInitialValue = Nothing
        Me.xdt_FechaCorte.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaCorte.FieldDescription = ""
        Me.xdt_FechaCorte.FindInitialValue = Nothing
        Me.xdt_FechaCorte.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaCorte.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaCorte.IgnoreRequiered = False
        Me.xdt_FechaCorte.Location = New System.Drawing.Point(112, 16)
        Me.xdt_FechaCorte.Name = "xdt_FechaCorte"
        Me.xdt_FechaCorte.NewInitialValue = "now"
        Me.xdt_FechaCorte.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaCorte.Requiered = False
        Me.xdt_FechaCorte.Size = New System.Drawing.Size(112, 20)
        Me.xdt_FechaCorte.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaCorte.TabIndex = 2
        '
        'xlk_chequera
        '
        Me.xlk_chequera.AlternateFieldSearch = Nothing
        Me.xlk_chequera.BeginCheck = False
        Me.xlk_chequera.CheckText = Nothing
        Me.xlk_chequera.ComboMode = False
        Me.xlk_chequera.DataMember = Nothing
        Me.xlk_chequera.DataSource = Me.LibXConnector1
        Me.xlk_chequera.DestParameters = New String() {"chequera=chequera", "xtxt_chequera_name=descripcion"}
        Me.xlk_chequera.FilterField = "descripcion"
        Me.xlk_chequera.IgnoreFindInBrowseMode = False
        Me.xlk_chequera.isCanceled = False
        Me.xlk_chequera.Location = New System.Drawing.Point(600, 39)
        Me.xlk_chequera.LookCaption = "Cuentas Bancarias"
        Me.xlk_chequera.Name = "xlk_chequera"
        Me.xlk_chequera.PopupSize = New System.Drawing.Size(600, 300)
        Me.xlk_chequera.ShowFilter = True
        Me.xlk_chequera.ShowMessageNotFound = True
        Me.xlk_chequera.ShowWarning = False
        Me.xlk_chequera.Size = New System.Drawing.Size(16, 20)
        Me.xlk_chequera.SizesColumns = New String() {"descripcion=300"}
        Me.xlk_chequera.SizesColumnsTab = Nothing
        Me.xlk_chequera.SqlString = Nothing
        Me.xlk_chequera.SQLTab = Nothing
        Me.xlk_chequera.SrcParameters = New String() {"chequera=chequera"}
        Me.xlk_chequera.TabIndex = 12
        Me.xlk_chequera.TableName = "cpchequera"
        Me.xlk_chequera.TabStop = False
        Me.xlk_chequera.UseCopyConnection = False
        Me.xlk_chequera.UseRowRetrieveEvents = False
        Me.xlk_chequera.UseTab = False
        Me.xlk_chequera.VisParameters = New String() {"Chequera=chequera", "Nombre=descripcion", "Cuenta Banco=cuenta_banco"}
        Me.xlk_chequera.WhereCondition = Nothing
        Me.xlk_chequera.WhereParameters = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(32, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha Corte:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(272, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Estatus:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_chequera
        '
        Me.xtxt_chequera.AcceptsReturn = True
        Me.xtxt_chequera.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbconcm.chequera"))
        Me.xtxt_chequera.EditInitialValue = Nothing
        Me.xtxt_chequera.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_chequera.FieldDescription = ""
        Me.xtxt_chequera.FindInitialValue = Nothing
        Me.xtxt_chequera.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chequera.IgnoreRequiered = False
        Me.xtxt_chequera.Location = New System.Drawing.Point(112, 40)
        Me.xtxt_chequera.Name = "xtxt_chequera"
        Me.xtxt_chequera.NewInitialValue = Nothing
        Me.xtxt_chequera.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chequera.Requiered = False
        Me.xtxt_chequera.Size = New System.Drawing.Size(112, 20)
        Me.xtxt_chequera.StatusBarPanelDescripcion = Nothing
        Me.xtxt_chequera.TabIndex = 1
        Me.xtxt_chequera.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(45, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Chequera:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"tran_type=tran_type"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(584, 40)
        Me.LibXLookup1.LookCaption = "Tipos de Documentos"
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
        Me.LibXLookup1.SrcParameters = New String() {"tran_type=tran_type"}
        Me.LibXLookup1.TabIndex = 5
        Me.LibXLookup1.TableName = "cgtrntpm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Documento=tran_type", "Descripción=tran_descr"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'xtxt_chequera_name
        '
        Me.xtxt_chequera_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xtxt_chequera_name.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.xtxt_chequera_name.Location = New System.Drawing.Point(226, 40)
        Me.xtxt_chequera_name.Name = "xtxt_chequera_name"
        Me.xtxt_chequera_name.Size = New System.Drawing.Size(376, 20)
        Me.xtxt_chequera_name.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(448, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Número:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_conc_serial
        '
        Me.xtxt_conc_serial.AcceptsReturn = True
        Me.xtxt_conc_serial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbconcm.conc_serial"))
        Me.xtxt_conc_serial.EditInitialValue = Nothing
        Me.xtxt_conc_serial.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_conc_serial.FieldDescription = ""
        Me.xtxt_conc_serial.FindInitialValue = Nothing
        Me.xtxt_conc_serial.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_conc_serial.IgnoreRequiered = False
        Me.xtxt_conc_serial.Location = New System.Drawing.Point(503, 16)
        Me.xtxt_conc_serial.Name = "xtxt_conc_serial"
        Me.xtxt_conc_serial.NewInitialValue = Nothing
        Me.xtxt_conc_serial.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_conc_serial.Requiered = False
        Me.xtxt_conc_serial.Size = New System.Drawing.Size(112, 20)
        Me.xtxt_conc_serial.StatusBarPanelDescripcion = Nothing
        Me.xtxt_conc_serial.TabIndex = 0
        Me.xtxt_conc_serial.Text = ""
        '
        'xdg_Documentos
        '
        Me.xdg_Documentos.AllowSorting = False
        Me.xdg_Documentos.AutoAdjustLastColumn = True
        Me.xdg_Documentos.AutoSearch = False
        Me.xdg_Documentos.BackgroundColor = System.Drawing.Color.White
        Me.xdg_Documentos.CaptionText = "Documentos a Conciliar (Doble click para marcar y desmarcar)"
        Me.xdg_Documentos.DataMember = "cbdocsm"
        Me.xdg_Documentos.DataSource = Me.DataSet1
        Me.xdg_Documentos.FullRowSelect = False
        Me.xdg_Documentos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.xdg_Documentos.IsReadOnly = False
        Me.xdg_Documentos.Location = New System.Drawing.Point(0, 240)
        Me.xdg_Documentos.Name = "xdg_Documentos"
        Me.xdg_Documentos.ReadOnly = True
        Me.xdg_Documentos.searchText = ""
        Me.xdg_Documentos.showFooterBar = True
        Me.xdg_Documentos.Size = New System.Drawing.Size(728, 248)
        Me.xdg_Documentos.TabIndex = 0
        Me.xdg_Documentos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.xdg_Documentos.UseAutoFillLines = True
        Me.xdg_Documentos.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.xdg_Documentos
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.xdg_Aplicar, Me.gcoltran_type, Me.XDataGridTextButtonColumn1, Me.gcolcbm_serial, Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn2, Me.gColMonto, Me.gcolamount})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cbdocsm"
        '
        'xdg_Aplicar
        '
        Me.xdg_Aplicar.FalseValue = CType(0, Short)
        Me.xdg_Aplicar.HeaderText = "Conciliar"
        Me.xdg_Aplicar.MappingName = "Aplicar"
        Me.xdg_Aplicar.NullValue = 0
        Me.xdg_Aplicar.TrueValue = CType(1, Short)
        Me.xdg_Aplicar.UseCustomCellFormat = False
        Me.xdg_Aplicar.Width = 48
        '
        'gcoltran_type
        '
        Me.gcoltran_type.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gcoltran_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcoltran_type.executeFindDuringFill = False
        Me.gcoltran_type.Format = ""
        Me.gcoltran_type.FormatInfo = Nothing
        Me.gcoltran_type.HeaderText = "Documento"
        Me.gcoltran_type.isReadOnly = True
        Me.gcoltran_type.Lookup = Me.LibXLookup1
        Me.gcoltran_type.MappingName = "tran_type"
        Me.gcoltran_type.MaxLength = 32767
        Me.gcoltran_type.ReadOnly = True
        Me.gcoltran_type.TabStop = True
        Me.gcoltran_type.UseCustomCellFormat = False
        Me.gcoltran_type.Width = 75
        '
        'XDataGridTextButtonColumn1
        '
        Me.XDataGridTextButtonColumn1.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.XDataGridTextButtonColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XDataGridTextButtonColumn1.executeFindDuringFill = False
        Me.XDataGridTextButtonColumn1.Format = ""
        Me.XDataGridTextButtonColumn1.FormatInfo = Nothing
        Me.XDataGridTextButtonColumn1.HeaderText = "Número"
        Me.XDataGridTextButtonColumn1.isReadOnly = True
        Me.XDataGridTextButtonColumn1.Lookup = Me.xlk_doc_number
        Me.XDataGridTextButtonColumn1.MappingName = "doc_number"
        Me.XDataGridTextButtonColumn1.MaxLength = 32767
        Me.XDataGridTextButtonColumn1.ReadOnly = True
        Me.XDataGridTextButtonColumn1.TabStop = True
        Me.XDataGridTextButtonColumn1.UseCustomCellFormat = False
        Me.XDataGridTextButtonColumn1.Width = 101
        '
        'xlk_doc_number
        '
        Me.xlk_doc_number.AlternateFieldSearch = Nothing
        Me.xlk_doc_number.BeginCheck = False
        Me.xlk_doc_number.CheckText = Nothing
        Me.xlk_doc_number.ComboMode = False
        Me.xlk_doc_number.DataMember = Nothing
        Me.xlk_doc_number.DataSource = Me.LibXConnector1
        Me.xlk_doc_number.DestParameters = New String() {"benef=benef", "doc_date=doc_date", "amount=amount", "doc_number=doc_number", "cbm_serial=cbm_serial"}
        Me.xlk_doc_number.FilterField = Nothing
        Me.xlk_doc_number.IgnoreFindInBrowseMode = False
        Me.xlk_doc_number.isCanceled = False
        Me.xlk_doc_number.Location = New System.Drawing.Point(264, 216)
        Me.xlk_doc_number.LookCaption = "Documentos por Conciliar"
        Me.xlk_doc_number.Name = "xlk_doc_number"
        Me.xlk_doc_number.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_doc_number.ShowFilter = True
        Me.xlk_doc_number.ShowMessageNotFound = True
        Me.xlk_doc_number.ShowWarning = False
        Me.xlk_doc_number.Size = New System.Drawing.Size(16, 20)
        Me.xlk_doc_number.SizesColumns = New String() {"benef=300"}
        Me.xlk_doc_number.SizesColumnsTab = Nothing
        Me.xlk_doc_number.SqlString = Nothing
        Me.xlk_doc_number.SQLTab = Nothing
        Me.xlk_doc_number.SrcParameters = New String() {"doc_number=doc_number"}
        Me.xlk_doc_number.TabIndex = 11
        Me.xlk_doc_number.TableName = "cbdocsm"
        Me.xlk_doc_number.TabStop = False
        Me.xlk_doc_number.UseCopyConnection = False
        Me.xlk_doc_number.UseRowRetrieveEvents = False
        Me.xlk_doc_number.UseTab = False
        Me.xlk_doc_number.VisParameters = New String() {"Numero=doc_number", "Fecha=doc_date", "Beneficiario=benef", "Monto=amount"}
        Me.xlk_doc_number.WhereCondition = "conc_serial is null"
        Me.xlk_doc_number.WhereParameters = Nothing
        '
        'gcolcbm_serial
        '
        Me.gcolcbm_serial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolcbm_serial.Format = ""
        Me.gcolcbm_serial.FormatInfo = Nothing
        Me.gcolcbm_serial.ImageList = Nothing
        Me.gcolcbm_serial.isReadOnly = True
        Me.gcolcbm_serial.MappingName = "cbm_serial"
        Me.gcolcbm_serial.MaxLength = 32767
        Me.gcolcbm_serial.ReadOnly = True
        Me.gcolcbm_serial.TabStop = True
        Me.gcolcbm_serial.UseCustomCellFormat = False
        Me.gcolcbm_serial.Width = 0
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Fecha"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = True
        Me.XEditTextBoxColumn1.MappingName = "doc_date"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.ReadOnly = True
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 101
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Beneficiario"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = True
        Me.XEditTextBoxColumn2.MappingName = "Benef"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.ReadOnly = True
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 260
        '
        'gColMonto
        '
        Me.gColMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColMonto.Format = ""
        Me.gColMonto.FormatInfo = Nothing
        Me.gColMonto.ImageList = Nothing
        Me.gColMonto.isReadOnly = False
        Me.gColMonto.MappingName = "Monto"
        Me.gColMonto.MaxLength = 32767
        Me.gColMonto.TabStop = True
        Me.gColMonto.UseCustomCellFormat = False
        Me.gColMonto.Width = 0
        '
        'gcolamount
        '
        Me.gcolamount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gcolamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolamount.Format = "#,###,##0.00"
        Me.gcolamount.FormatInfo = Nothing
        Me.gcolamount.HeaderText = "Montoi"
        Me.gcolamount.ImageList = Nothing
        Me.gcolamount.isReadOnly = True
        Me.gcolamount.MappingName = "amount"
        Me.gcolamount.MaxLength = 32767
        Me.gcolamount.ReadOnly = True
        Me.gcolamount.TabStop = True
        Me.gcolamount.UseCustomCellFormat = False
        Me.gcolamount.Width = 101
        '
        'btnVisualizar
        '
        Me.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVisualizar.Location = New System.Drawing.Point(8, 512)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(80, 40)
        Me.btnVisualizar.TabIndex = 12
        Me.btnVisualizar.Text = "Visualizar"
        '
        'btnMarkAll
        '
        Me.btnMarkAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarkAll.Location = New System.Drawing.Point(96, 512)
        Me.btnMarkAll.Name = "btnMarkAll"
        Me.btnMarkAll.Size = New System.Drawing.Size(80, 40)
        Me.btnMarkAll.TabIndex = 13
        Me.btnMarkAll.Text = "Marcar Todos"
        '
        'btnUnMarkAll
        '
        Me.btnUnMarkAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnMarkAll.Location = New System.Drawing.Point(184, 512)
        Me.btnUnMarkAll.Name = "btnUnMarkAll"
        Me.btnUnMarkAll.Size = New System.Drawing.Size(80, 40)
        Me.btnUnMarkAll.TabIndex = 14
        Me.btnUnMarkAll.Text = "Desmarcar Todos"
        '
        'xgp_Filtro
        '
        Me.xgp_Filtro.Controls.Add(Me.btnRefresh)
        Me.xgp_Filtro.Controls.Add(Me.Label9)
        Me.xgp_Filtro.Controls.Add(Me.xtxt_doc_number)
        Me.xgp_Filtro.Controls.Add(Me.Xcbo_tran_type)
        Me.xgp_Filtro.Controls.Add(Me.Label8)
        Me.xgp_Filtro.Location = New System.Drawing.Point(8, 184)
        Me.xgp_Filtro.Name = "xgp_Filtro"
        Me.xgp_Filtro.Size = New System.Drawing.Size(728, 48)
        Me.xgp_Filtro.TabIndex = 15
        Me.xgp_Filtro.TabStop = False
        Me.xgp_Filtro.Text = "Filtrar"
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Location = New System.Drawing.Point(648, 16)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 24)
        Me.btnRefresh.TabIndex = 8
        Me.btnRefresh.Text = "Refrescar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(392, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Numero Documento:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_doc_number
        '
        Me.xtxt_doc_number.AcceptsReturn = True
        Me.xtxt_doc_number.EditInitialValue = Nothing
        Me.xtxt_doc_number.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_doc_number.FieldDescription = ""
        Me.xtxt_doc_number.FindInitialValue = Nothing
        Me.xtxt_doc_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_doc_number.IgnoreRequiered = False
        Me.xtxt_doc_number.Location = New System.Drawing.Point(512, 16)
        Me.xtxt_doc_number.Name = "xtxt_doc_number"
        Me.xtxt_doc_number.NewInitialValue = Nothing
        Me.xtxt_doc_number.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_doc_number.Requiered = False
        Me.xtxt_doc_number.Size = New System.Drawing.Size(112, 20)
        Me.xtxt_doc_number.StatusBarPanelDescripcion = Nothing
        Me.xtxt_doc_number.TabIndex = 6
        Me.xtxt_doc_number.Text = ""
        '
        'Xcbo_tran_type
        '
        Me.Xcbo_tran_type.AllowDefaultSort = True
        Me.Xcbo_tran_type.bound = True
        Me.Xcbo_tran_type.currValue = Nothing
        Me.Xcbo_tran_type.DefaultWhereString = "conciliable=1"
        Me.Xcbo_tran_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Xcbo_tran_type.EditInitialValue = Nothing
        Me.Xcbo_tran_type.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.Xcbo_tran_type.FieldDescription = ""
        Me.Xcbo_tran_type.FindInitialValue = Nothing
        Me.Xcbo_tran_type.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xcbo_tran_type.IgnoreRequiered = False
        Me.Xcbo_tran_type.Location = New System.Drawing.Point(112, 16)
        Me.Xcbo_tran_type.LookupKeyDisplayFields = "tran_descr"
        Me.Xcbo_tran_type.LookupKeyField = "tran_type"
        Me.Xcbo_tran_type.LookupTableName = "cgtrntpm"
        Me.Xcbo_tran_type.Name = "Xcbo_tran_type"
        Me.Xcbo_tran_type.NewInitialValue = "2"
        Me.Xcbo_tran_type.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.Xcbo_tran_type.Requiered = False
        Me.Xcbo_tran_type.Required = False
        Me.Xcbo_tran_type.Size = New System.Drawing.Size(264, 21)
        Me.Xcbo_tran_type.SqlString = Nothing
        Me.Xcbo_tran_type.StatusBarPanelDescripcion = Nothing
        Me.Xcbo_tran_type.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(8, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Tipo Documento:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem3})
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "Marcar Todos"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "Desmarcar Todos"
        '
        'DataView1
        '
        Me.DataView1.Table = Me.cbdocsm
        '
        'p_cbdocs01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(744, 582)
        Me.Controls.Add(Me.xgp_Filtro)
        Me.Controls.Add(Me.btnUnMarkAll)
        Me.Controls.Add(Me.btnMarkAll)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.xlk_doc_number)
        Me.Controls.Add(Me.xdg_Documentos)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.KeyPreview = True
        Me.Name = "p_cbdocs01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Conciliar Documentos"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbdocsm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.xdg_Documentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xgp_Filtro.ResumeLayout(False)
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub i_cgjourm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            xdg_Documentos.footerOperations.add("Aplicar", "count(doc_number)", "aplicar=1")
            xdg_Documentos.footerOperations.add("doc_number", "count(doc_number)")
            xdg_Documentos.footerOperations.add("amount", "sum(Monto)", "aplicar=1")

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub xlk_doc_number_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_doc_number.BeforeExecuteQuery
        Try
            e.aditionalWhere = "tran_type = '" & xdg_Documentos.GetValue(xdg_Documentos.CurrentRowIndex, gcoltran_type) & "' and chequera = " & Me.xtxt_chequera.Text.Trim

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.AfterSaveDetail
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim conTrn As Integer
        Try

            xUpdate = New LibX.Data.XUpdateStmt("cbdocsm")

            For Each oRow As DataRow In cbdocsm.Rows
                If oRow.RowState = DataRowState.Deleted Then
                    xUpdate.FieldsSet("conc_serial") = DBNull.Value
                    conTrn = FindDocConf(oRow!cbm_serial, Me.xtxt_chequera.Text)
                    If conTrn = 0 Then
                        xUpdate.FieldsSet("conc_transito") = e.MasterRow!conc_serial
                    End If
                    xUpdate.FieldsSet("doc_transito") = 1
                End If

                If oRow!aplicar = 1 Then
                    xUpdate.FieldsSet("conc_serial") = e.MasterRow!conc_serial
                    xUpdate.FieldsSet("doc_transito") = DBNull.Value
                    conTrn = FindDocConf(oRow!cbm_serial, Me.xtxt_chequera.Text)
                    If conTrn = 0 Then
                        xUpdate.FieldsSet("conc_transito") = DBNull.Value
                    Else
                        xUpdate.FieldsSet("conc_transito") = conTrn
                    End If
                End If

                If oRow!aplicar = 0 Then
                    xUpdate.FieldsSet("conc_serial") = DBNull.Value
                    conTrn = FindDocConf(oRow!cbm_serial, Me.xtxt_chequera.Text)
                    If conTrn = 0 Then
                        xUpdate.FieldsSet("conc_transito") = e.MasterRow!conc_serial
                    Else
                        xUpdate.FieldsSet("conc_transito") = conTrn
                    End If
                    xUpdate.FieldsSet("doc_transito") = 1
                End If

                xUpdate.Fields("cbm_serial") = oRow.Item("cbm_serial", DataRowVersion.Original)
                xUpdate.Execute()
            Next

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim SQLQuery As String
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                e.UpdatingArgs.Row!saldo_ant = Format(BuscarBalAnterior(Me.xtxt_chequera.Text), "##,###,##0.00")
            End If

            If e.UpdatingArgs.StatementType = StatementType.Delete Then
                SQLQuery = "update cbdocsm set conc_serial = 0 " & _
                           " where conc_serial = " & e.UpdatingArgs.Row.Item("conc_serial", DataRowVersion.Original).ToString.Trim

                LibX.Data.Manager.ExecuteNonQuery(SQLQuery)
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        CargarDocumentos()
        If LibXConnector1.CurrentAction = LibX.LibxConnectionActions.Add Then
            Marcar(1)
        End If
        CalcularBceBanco()
    End Sub

    Private Sub CargarDocumentos()
        Dim SelectStmt As String
        Dim XSelectStmt As LibX.Data.XSelecStmt
        Dim oTable As DataTable
        Try

            If Me.xtxt_chequera.Text.Trim = "" Then
                Me.xtxt_chequera.Focus()
                Exit Sub
            End If

            If Me.xdt_FechaCorte.Value.ToString.Trim = "" Then
                Me.xdt_FechaCorte.Focus()
                Exit Sub
            End If
            SelectStmt = "select cbm_serial " & _
                        " ,cbdocsm.chequera    " & _
                        " ,cbdocsm.tran_type  " & _
                        " ,doc_number  " & _
                        " ,doc_date  " & _
                        " ,doc_status  " & _
                        " ,case doc_status when 0 then '*** ANULADO ***' else benef end benef " & _
                        " ,doc_concept " & _
                        " ,case doc_status when 0 then 0 else amount end amount" & _
                        " ,conc_serial " & _
                        " ,perdr_year  " & _
                        " ,perdr_num   " & _
                        " ,date_conc  " & _
                        " ,date_created " & _
                        " ,userid      " & _
                        " ,doc_origen  " & _
                        " ,tranr_serial " & _
                        " ,case doc_status when 0 then 0 else (amount * cgtrntpm.origen) end Monto " & _
                        " ,cbdocsm.suc_code " & _
                        " from cbdocsm, ivtypem, cgtrntpm " & _
                        " where cbdocsm.chequera = " & Me.xtxt_chequera.Text & _
                        "   and ivtypem.type_code = cbdocsm.tran_type " & _
                        "   and cgtrntpm.chequera = cbdocsm.chequera " & _
                        "   and cgtrntpm.tran_type = cbdocsm.tran_type " & _
                        "   and cgtrntpm.conciliable = 1 " & _
                        "   and doc_date <= '" & CDate(xdt_FechaCorte.Value).ToString(LibX.Data.Manager.GetSaveDateFormat) & "'"

            If Me.xtxt_conc_serial.Text.Trim <> "" Then
                SelectStmt = SelectStmt.Trim & " and (conc_serial = " & Me.xtxt_conc_serial.Text.Trim & " or conc_serial is null or conc_serial = 0 )"
            Else
                SelectStmt = SelectStmt.Trim & " and (conc_serial is null or conc_serial = 0 )"
            End If

            SelectStmt = SelectStmt.Trim & _
                        " ORDER BY cbdocsm.doc_number,cbdocsm.tran_type,cbdocsm.chequera,cbdocsm.suc_code "

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt, "cbdocsm", True)

            If oTable Is Nothing Then
                Exit Sub
            End If

            '// si hay documentos activar el boton visualizar
            Me.btnVisualizar.Enabled = (oTable.Rows.Count > 0)

            If oTable.Rows.Count <= 0 Then
                Exit Sub
            End If

            oTable.PrimaryKey = New DataColumn() {oTable.Columns("doc_number"), oTable.Columns("tran_type"), oTable.Columns("chequera"), oTable.Columns("suc_code")}

            DataSet1.Tables("cbdocsm").Rows.Clear()
            DataSet1.Merge(oTable, True, MissingSchemaAction.AddWithKey)

            For Each oRow As DataRow In DataSet1.Tables("cbdocsm").Rows

                If oRow!conc_serial Is DBNull.Value Then
                    oRow!Aplicar = 0
                Else
                    oRow!Aplicar = 1
                End If
            Next

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            
            CalcularBceBanco()

            If LibXConnector1.HasRecords = True Then
                If LibXConnector1.CurrentDataRow!conc_status = 1 Then
                    LibXConnector1.AllowEdit = False
                Else
                    LibXConnector1.AllowEdit = True
                End If
            End If
            Me.btnLoad.Enabled = LibXConnector1.IsDataEditing
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ChangingState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangingState
        Try
            If e.action = LibX.LibxConnectionActions.Add Then
                AddConc = 1
            Else
                AddConc = 0
            End If

            Me.btnLoad.Enabled = e.isDataEditing
            Me.btnMarkAll.Enabled = e.isDataEditing
            Me.btnUnMarkAll.Enabled = e.isDataEditing

            If e.action = LibX.LibxConnectionActions.Find Then
                Me.xcbo_conc_status.SelectedValue = 2
            End If

            xgp_Filtro.Enabled = e.isDataEditing

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        Dim Param As LibX.LibxPrgParams
        Try
            Param = New LibX.LibxPrgParams

            Param.AllowDelete = False
            Param.AllowEdit = False
            Param.AllowNew = False
            Param.AllowQuery = False
            Param.initMode = LibX.LibxInitModes.none
            Param.WhereToExecute = "cbdocsm.cbm_serial = " & xdg_Documentos.GetValue(xdg_Documentos.currentRowNum, gcolcbm_serial).Trim

            LibX.App.CurrentPrgParams = Param
            LibX.LibXRunner.Run("i_cbdocs01", "CTB", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xdg_Documentos_CurrentRowChanged(ByVal sender As System.Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles xdg_Documentos.CurrentRowChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                '// si hay documentos activar el boton visualizar
                Me.btnVisualizar.Enabled = (xdg_Documentos.getCurrentGridView.Count > 0)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnMarkAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAll.Click
        Dim Balance As Decimal = 0.0
        Dim Disferencia As Decimal = 0.0
        For Each oRow As DataRow In DataSet1.Tables("cbdocsm").Rows
            oOrigen = New SGT.Inventario.Entidades.Documento(oRow!tran_type)
            oRow!Aplicar = 1
            Balance = CDbl(Me.xtxt_bce_segun_bco.Text)
            Disferencia = CDbl(Me.xtxt_bce_libro.Text) - (Balance * oOrigen.Origen)
            Me.xtxt_bce_banco.Text = Balance
            Me.xtxt_Diferencia.Text = Disferencia
        Next
    End Sub

    Private Sub btnUnMarkAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnMarkAll.Click
        Dim Balance As Decimal = 0.0
        Dim Disferencia As Decimal = 0.0
        Me.xtxt_bce_segun_bco.Text = CDbl(Me.xtxt_bce_segun_bco.Text)
        Balance = CDbl(Me.xtxt_bce_segun_bco.Text)

        For Each oRow As DataRow In DataSet1.Tables("cbdocsm").Rows
            oOrigen = New SGT.Inventario.Entidades.Documento(oRow!tran_type)
            oRow!Aplicar = 0
            Balance = Balance + oRow!amount
            Disferencia = CDbl(xtxt_bce_libro.Text) - (Balance * oOrigen.Origen)
            Me.xtxt_Diferencia.Text = Disferencia
            Me.xtxt_bce_banco.Text = Balance
        Next
    End Sub
    Private Sub Marcar(ByVal intvalor As Integer)
        For Each orow As DataRow In cbdocsm.Rows
            If orow.RowState <> DataRowState.Deleted Then
                orow!Aplicar = intvalor
            End If
        Next
    End Sub
    Private Sub CalcularBceBanco()
        Dim Monto As Decimal = 0.0
        Dim Balance As Decimal = 0.0
        Dim Balance2 As Decimal = 0.0
        Dim Disferencia As Decimal = 0.0
        Dim montoTransito As Decimal = 0.0

        xdg_Documentos.refreshFooter()

        If Me.xtxt_bce_segun_bco.Text <> String.Empty Then
            Balance = CDbl(Me.xtxt_bce_banco.Text)
        End If
        If xtxt_bce_banco.Text <> String.Empty Then
            Balance2 = CDbl(Me.xtxt_bce_libro.Text)
        End If

        If Not LibX.IsNull(xdg_Documentos.GetFooterValue(gcolamount)) Then
            Monto = xdg_Documentos.GetFooterValue(gcolamount)
        End If

        If xtxt_bce_libro.Text <> String.Empty Then
            Disferencia = Balance2 - Balance
            Me.xtxt_Diferencia.Text = Format(Disferencia, "###,###,##0.00")
        End If

    End Sub

    Private Sub xlx_chequera_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_chequera.Validating
        Try
            If Me.xtxt_chequera.Text = "" Then
                Throw New ApplicationException("Debe indicar una chequera")
            End If
        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xtxt_bce_segun_bco_validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_bce_segun_bco.Validating
        Try
           
            If Me.xtxt_bce_segun_bco.Text = String.Empty Then
                Throw New ApplicationException("Debe digitar el balance segun banco")
            End If
        Catch ex As Exception
            'e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub XTextBox2_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_bce_segun_bco.Validating
        Dim montoTransito As Decimal = 0.0
        Dim Bce_segun_banco As Decimal = 0.0
        Dim Bce_segun_libro As Decimal = 0.0
        Dim Disferencia As Decimal = 0.0
        Try
            If LibXConnector1.CurrentAction = LibX.LibxConnectionActions.Add Or LibXConnector1.CurrentAction = LibX.LibxConnectionActions.Edit Then

                If Me.xtxt_chequera.Text <> String.Empty Then
                    oChequera = New SGT.ControlBancario.Entidades.Chequera(Me.xtxt_chequera.Text)
                    Bce_segun_libro = CDbl(Me.xtxt_bce_libro.Text)
                    Me.xtxt_bce_banco.Enabled = True
                Else
                    Me.xtxt_chequera.Focus()
                    Me.xtxt_chequera.Text = String.Empty
                    Me.xtxt_bce_banco.Enabled = False
                End If

                If Me.xtxt_bce_segun_bco.Text <> String.Empty Then
                    Bce_segun_banco = (CDbl(Me.xtxt_bce_segun_bco.Text) + montoTransito)
                    Me.xtxt_bce_banco.Text = Format(Bce_segun_banco, "###,###,##0.00")

                End If

                'Bce_segun_libro = Not LibX.IsNull(CDbl(Me.xtxt_bce_libro.Text))

                If Bce_segun_banco > 0 Then
                    Disferencia = Bce_segun_banco - Bce_segun_libro
                    Me.xtxt_Diferencia.Text = Format(Disferencia, "###,###,##0.00")
                End If

                If LibXConnector1.CurrentAction = LibX.LibxConnectionActions.Edit Then
                    Marcar(1)
                End If
            End If

        Catch ex As Exception
            'e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xdg_Aplicar_BoolValueChanged(ByVal sender As Object, ByVal e As LibX.BoolValueChangedEventArgs) Handles xdg_Aplicar.BoolValueChanged
        Dim Bce_Slibro As Decimal
        Try
            Bce_banco_mov = CDbl(Me.xtxt_bce_banco.Text)
            Bce_Slibro = CDbl(Me.xtxt_bce_libro.Text)
            If xdg_Documentos.EndEdit(xdg_Aplicar, xdg_Documentos.CurrentRowIndex, True) Then
                cbdocsm.Rows(xdg_Documentos.CurrentRowIndex).BeginEdit()
                cbdocsm.Rows(xdg_Documentos.CurrentRowIndex)!Aplicar = IIf(e.BoolValue, 1, 0)
                cbdocsm.Rows(xdg_Documentos.CurrentRowIndex).EndEdit()
                oOrigen = New SGT.Inventario.Entidades.Documento(cbdocsm.Rows(xdg_Documentos.CurrentRowIndex)!tran_type)

                If cbdocsm.Rows(xdg_Documentos.CurrentRowIndex)!Aplicar = 0 Then
                    Bce_banco_mov = Bce_banco_mov + (cbdocsm.Rows(xdg_Documentos.CurrentRowIndex)!amount * oOrigen.Origen)
                    Me.xtxt_bce_banco.Text = Format(Bce_banco_mov, "###,###,##0.00")
                    Bce_diferencia = Bce_banco_mov - Bce_Slibro
                    Me.xtxt_Diferencia.Text = Format(Bce_diferencia, "###,###,##0.00")
                Else
                    Bce_banco_mov = Bce_banco_mov - (cbdocsm.Rows(xdg_Documentos.CurrentRowIndex)!amount * oOrigen.Origen)
                    Me.xtxt_bce_banco.Text = Format(Bce_banco_mov, "###,###,##0.00")
                    Bce_diferencia = Bce_banco_mov - Bce_Slibro
                    Me.xtxt_Diferencia.Text = Format(Bce_diferencia, "###,###,##0.00")
                End If

                CalcularBceBanco()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaulteditValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultEditValues) Handles LibXConnector1.SettingDefaulteditValues
        BuscarBalance()
        CargarDocumentos()
        CalcularBceBanco()
        Me.Xcbo_tran_type.LoadDbItems(True)
        Me.xcbo_conc_status.SelectedValue = 2

    End Sub

    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        Try
            If LibXConnector1.CurrentAction = LibX.LibxConnectionActions.Delete Then
                e.Handled = True
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick

        Dim cFecha, eFecha As String
        Dim fConcil, cEdate As String
        Dim SelecStmt As String
        Dim sWhere As String

        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
                Dim oReport As New LibX.ReportLib("CTB", "r_cbconc02.rpt")
                eFecha = FindConcilAnt(LibXConnector1.CurrentDataRow!conc_serial.ToString.Trim, LibXConnector1.CurrentDataRow!chequera.ToString.Trim)
                cFecha = Year(eFecha) & "-" & Month(eFecha) & "-" & CType(eFecha, Date).ToString("dd")

                cEdate = LibXConnector1.CurrentDataRow!conc_date
                fConcil = Year(cEdate) & "-" & Month(cEdate) & "-" & CType(cEdate, Date).ToString("dd")

                With oReport
                    sWhere = " 1=1 "
                    .ParameterFields(1) = String.Concat("@Serial;", LibXConnector1.CurrentDataRow!conc_serial.ToString.Trim, ";TRUE")
                    .ParameterFields(2) = String.Concat("@Fdate;", cFecha, ";TRUE")
                    .ParameterFields(3) = String.Concat("@fConc;", fConcil, ";TRUE")
                    .ParameterFields(4) = String.Concat("@Chequera;", Me.xtxt_chequera.Text, ";TRUE")
                    .RetrieveSQLQuery()
                    SelecStmt = .SQLQuery
                    SelecStmt = LibX.ConcatWherePart(SelecStmt, sWhere)
                    .SQLQuery = SelecStmt
                    .Action = 1
                End With
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        Finally
            '//oReport = Nothing
        End Try
    End Sub

    Private Sub xdg_Documentos_CellValidate(ByVal sender As System.Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles xdg_Documentos.CellValidate
        Try
            If e.cell = xdg_Documentos.GetColNum(xdg_Aplicar) Then
                CalcularBceBanco()
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub xlk_chequera_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_chequera.AfterSetValues
        Try
            If LibXConnector1.IsDataEditing = True Then
                If AddConc = 1 Then
                    If BuscarConcilPendiente(Me.xtxt_chequera.Text) = True Then
                        Throw New ApplicationException("Hay conciliacion pendiente para esta chequera")
                    End If
                End If
                BuscarBalance()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub BuscarBalance()
        Dim mFecha As String

        Dim balanceLibro As Decimal
        Try
            If Me.xtxt_chequera.Text.Trim = String.Empty Then
                Exit Sub
            End If

            oChequera = New SGT.ControlBancario.Entidades.Chequera(Me.xtxt_chequera.Text)
            balanceLibro = oChequera.GetBalanceByDate(oChequera.Codigo, Me.xdt_FechaCorte.Value)
            xtxt_bce_libro.Text = Format(balanceLibro, "###,###,##0.00")

            If balanceLibro = 0 Then
                Throw New ApplicationException("No se encontro movimiento par aesta fecha")
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub xdt_FechaCorte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xdt_FechaCorte.ValueChanged
        If LibXConnector1.IsDataEditing = True Then
            BuscarBalance()
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If LibXConnector1.IsDataEditing = True Then
            BuscarBalance()
        End If
        xdg_Documentos.getCurrentGridView.RowFilter = ""

        If Xcbo_tran_type.currValue.ToString.Trim <> String.Empty Then
            xdg_Documentos.getCurrentGridView.RowFilter = "tran_type = '" & Me.Xcbo_tran_type.currValue.ToString.Trim & "'"
        End If

        If Me.xtxt_doc_number.Text.Trim <> String.Empty Then
            xdg_Documentos.getCurrentGridView.RowFilter = "doc_number = " & Me.xtxt_doc_number.Text.Trim
        End If
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Me.Xcbo_tran_type.LoadDbItems(True)
        Me.xtxt_bce_banco.Text = String.Empty
        Me.xtxt_Diferencia.Text = String.Empty
        Me.xtxt_doc_number.Text = String.Empty
        Me.xcbo_conc_status.SelectedValue = 2
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        btnMarkAll_Click(sender, e)
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        btnUnMarkAll_Click(sender, e)
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnRefresh_Click(sender, e)
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnLoad_Click(sender, e)
    End Sub
    Private Function BuscarBalAnterior(ByVal cHquera As Integer) As Decimal
        Dim bAlAnt As Decimal
        Try
            bAlAnt = LibX.Data.Manager.GetScalar("select isnull(balance_ult_concil,0) from cpchequera where chequera = " & cHquera)
            Return bAlAnt
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
    Private Function BuscarConcilPendiente(ByVal cHquera As Integer) As Boolean
        Dim concStatus As Integer
        Try
            concStatus = LibX.Data.Manager.GetScalar("select count(*) from cbconcm where conc_status = 2 and chequera = " & cHquera)

            If concStatus > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
    Private Function FindConcilAnt(ByVal Cserial As Integer, ByVal sChequera As Integer) As DateTime
        Dim coNc As DateTime
        Try
            coNc = LibX.Data.Manager.GetScalar("select max(conc_date) from cbconcm where conc_serial < " & Cserial & " and chequera = " & sChequera.ToString.Trim)
            If coNc = Nothing Then
                coNc = LibX.Data.Manager.GetScalar("select min(doc_date) from cbdocsm where month(doc_date) =" & Month(LibXConnector1.CurrentDataRow!conc_date.ToString.Trim) & _
                                                          " and year(doc_date) =" & Year(LibXConnector1.CurrentDataRow!conc_date.ToString.Trim) & " and chequera = " & sChequera.ToString.Trim)
            End If
            Return coNc
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
    Private Function FindDocConf(ByVal Cserial As Integer, ByVal sChequera As Integer) As Integer
        Dim coNc As Integer
        Try
            coNc = LibX.Data.Manager.GetScalar("select isnull(conc_transito,0) from cbdocsm where cbm_serial = " & Cserial & " and chequera = " & sChequera.ToString.Trim)

            Return coNc

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function

End Class
