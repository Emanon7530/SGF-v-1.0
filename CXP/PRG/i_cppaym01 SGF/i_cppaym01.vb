Imports SGT.Inventario
Imports SGT.Inventario.Entidades
Imports SGT.ControlBancario.Entidades
Imports LibX
Public Class i_cppaym01
    Inherits System.Windows.Forms.Form
    Dim oDocument As SGT.ControlBancario.Entidades.TipoDocumento
    Dim oParamValidar As SGT.Administracion.Entidades.Permission.ParametrosValidar
    Dim oAutorizar As SGT.Administracion.Entidades.Permission
    Dim oChequera As Chequera
    Dim mResta As Decimal
    Dim Porc_mora As Decimal
    Dim toTalAplicado As Decimal
    Dim WhDefault As Integer
    Dim mDigitado As Boolean = False
    Dim UseTransaction As Boolean = False
    Dim inUseTransaction As Boolean = False
    Dim oRowPrinter As DataRow
    Dim concepto As String
    Dim crDetalle As Boolean = False

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
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As LibX.XTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents balance As LibX.XTextBox
    Friend WithEvents xlk_cust_code As LibX.LibXLookup
    Friend WithEvents xdtp_paym_date As LibX.LibxDateTimePicker
    Friend WithEvents xcbo_paym_status As LibX.LibXCombo
    Friend WithEvents gColAplAmount As LibX.XEditTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPendiente As LibX.XTextBox
    Friend WithEvents gColAmount As LibX.XEditTextBoxColumn
    Friend WithEvents txtAmount As LibX.XMaskEdit
    Friend WithEvents gColBalance As LibX.XEditTextBoxColumn
    Friend WithEvents txtPaym_number As LibX.XTextBox
    Friend WithEvents xed_Tipo As LibX.XEditTextBoxColumn
    Friend WithEvents xed_number As LibX.XEditTextBoxColumn
    Friend WithEvents btnPagos As System.Windows.Forms.Button
    Friend WithEvents prov_name As LibX.XTextBox
    Friend WithEvents xtxt_prov_code As LibX.XTextBox
    Friend WithEvents xtxt_type_name As LibX.XTextBox
    Friend WithEvents xtxt_type_code As LibX.XTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents xtxt_chequera As LibX.XTextBox
    Friend WithEvents xtxt_chequera_name As LibX.XTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents xlk_chequera As LibX.LibXLookup
    Friend WithEvents XTextBox5 As LibX.XTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents XTextBox6 As LibX.XTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents gColItbis As LibX.XEditTextBoxColumn
    Friend WithEvents gColdoc_date As LibX.XEditTextBoxColumn
    Friend WithEvents gColdue_date As LibX.XEditTextBoxColumn
    Friend WithEvents gColDias As LibX.XEditTextBoxColumn
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
    Friend WithEvents gColdisc_amount As LibX.XEditTextBoxColumn
    Friend WithEvents cppaymm As System.Data.DataTable
    Friend WithEvents cppaymd As System.Data.DataTable
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents xtxt_cuentabancaria As LibX.XTextBox
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents gColdisc_date As LibX.XEditTextBoxColumn
    Friend WithEvents btnDistribuir As System.Windows.Forms.Button
    Friend WithEvents btnRemDesc As System.Windows.Forms.Button
    Friend WithEvents btnAddDesc As System.Windows.Forms.Button
    Friend WithEvents gColterm_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents xlk_term_code As LibX.LibXLookup
    Friend WithEvents xlk_type_code As LibX.LibXLookup
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents xtxConcepto As LibX.XTextBox
    Friend WithEvents btnimpck As System.Windows.Forms.Button
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents suc_name As LibX.XTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents klk_suc_code As LibX.LibXLookup
    Friend WithEvents xtxsuc_code As LibX.XTextBox
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.cppaymm = New System.Data.DataTable
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
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.cppaymd = New System.Data.DataTable
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
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.DataColumn36 = New System.Data.DataColumn
        Me.xtxt_chequera = New LibX.XTextBox
        Me.xtxt_type_code = New LibX.XTextBox
        Me.txtAmount = New LibX.XMaskEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xtxsuc_code = New LibX.XTextBox
        Me.suc_name = New LibX.XTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.klk_suc_code = New LibX.LibXLookup
        Me.Label14 = New System.Windows.Forms.Label
        Me.xtxConcepto = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.txtPaym_number = New LibX.XTextBox
        Me.xlk_cust_code = New LibX.LibXLookup
        Me.xdtp_paym_date = New LibX.LibxDateTimePicker
        Me.xcbo_paym_status = New LibX.LibXCombo
        Me.prov_name = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.xtxt_prov_code = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.balance = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.xtxt_type_name = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.xlk_type_code = New LibX.LibXLookup
        Me.xtxt_chequera_name = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.xlk_chequera = New LibX.LibXLookup
        Me.XTextBox5 = New LibX.XTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.XTextBox6 = New LibX.XTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.xtxt_cuentabancaria = New LibX.XTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TextBox7 = New LibX.XTextBox
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.xed_Tipo = New LibX.XEditTextBoxColumn
        Me.xed_number = New LibX.XEditTextBoxColumn
        Me.gColterm_code = New LibX.XDataGridTextButtonColumn
        Me.xlk_term_code = New LibX.LibXLookup
        Me.gColdoc_date = New LibX.XEditTextBoxColumn
        Me.gColdue_date = New LibX.XEditTextBoxColumn
        Me.gColDias = New LibX.XEditTextBoxColumn
        Me.gColItbis = New LibX.XEditTextBoxColumn
        Me.gColAmount = New LibX.XEditTextBoxColumn
        Me.gColBalance = New LibX.XEditTextBoxColumn
        Me.gColdisc_amount = New LibX.XEditTextBoxColumn
        Me.gColdisc_date = New LibX.XEditTextBoxColumn
        Me.gColAplAmount = New LibX.XEditTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnPagos = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPendiente = New LibX.XTextBox
        Me.btnDistribuir = New System.Windows.Forms.Button
        Me.btnRemDesc = New System.Windows.Forms.Button
        Me.btnAddDesc = New System.Windows.Forms.Button
        Me.btnimpck = New System.Windows.Forms.Button
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cppaymm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cppaymd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Nothing
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_chequera
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_chequera
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(914, 24)
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
        Me.LibXConnector1.DataMember = "cppaymm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = "CXP"
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = "r_cppaym01.rpt"
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Nothing)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.cppaymm, Me.cppaymd})
        '
        'cppaymm
        '
        Me.cppaymm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn28, Me.DataColumn29, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn37, Me.DataColumn36})
        Me.cppaymm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"paym_serial"}, True)})
        Me.cppaymm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.cppaymm.TableName = "cppaymm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "paym_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
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
        Me.DataColumn3.ColumnName = "prov_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "paym_number"
        Me.DataColumn4.MaxLength = 20
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "paym_date"
        Me.DataColumn5.DataType = GetType(System.DateTime)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "chequera"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "amount"
        Me.DataColumn7.DataType = GetType(System.Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "detail"
        Me.DataColumn8.MaxLength = 2000
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "paym_status"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "ftserial_no"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "cuentabancaria"
        Me.DataColumn11.MaxLength = 50
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "whse_code"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "date_created"
        Me.DataColumn13.DataType = GetType(System.DateTime)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "userid"
        Me.DataColumn14.MaxLength = 50
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "dev_serial"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "dev_number"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "solicitud"
        Me.DataColumn32.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "impreso"
        Me.DataColumn33.DataType = GetType(System.Int32)
        '
        'DataColumn34
        '
        Me.DataColumn34.AllowDBNull = False
        Me.DataColumn34.ColumnName = "suc_code"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "paym_datetran"
        Me.DataColumn37.DataType = GetType(System.DateTime)
        '
        'cppaymd
        '
        Me.cppaymd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn30, Me.DataColumn31, Me.DataColumn35})
        Me.cppaymd.TableName = "cppaymd"
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "paym_serial"
        Me.DataColumn15.DataType = GetType(System.Int32)
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "line_no"
        Me.DataColumn16.DataType = GetType(System.Int32)
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.ColumnName = "invce_serial"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "type_code"
        Me.DataColumn18.MaxLength = 3
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "doc_no"
        Me.DataColumn19.MaxLength = 20
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "doc_date"
        Me.DataColumn20.DataType = GetType(System.DateTime)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "invce_amount"
        Me.DataColumn21.DataType = GetType(System.Decimal)
        Me.DataColumn21.ReadOnly = True
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "due_date"
        Me.DataColumn22.DataType = GetType(System.DateTime)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "dias"
        Me.DataColumn23.DataType = GetType(System.Int32)
        Me.DataColumn23.ReadOnly = True
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.ColumnName = "itbis"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "disc_amount"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.AllowDBNull = False
        Me.DataColumn26.ColumnName = "balance"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "amount"
        Me.DataColumn27.DataType = GetType(System.Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "term_code"
        Me.DataColumn30.MaxLength = 6
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "disc_date"
        Me.DataColumn31.DataType = GetType(System.DateTime)
        '
        'DataColumn35
        '
        Me.DataColumn35.AllowDBNull = False
        Me.DataColumn35.ColumnName = "suc_code"
        Me.DataColumn35.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.SerialColumnName = "paym_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select cppaymm.*,", "ivdevolm.dev_number", "from cppaymm", "left outer join ivdevolm ", "on ivdevolm.dev_serial = cppaymm.dev_serial"}
        Me.LibXDbSourceTable1.TableName = "cppaymm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LibXDbSourceTable2
        '
        Me.LibXDbSourceTable2.AllowDelete = True
        Me.LibXDbSourceTable2.AllowEdit = True
        Me.LibXDbSourceTable2.AllowNew = False
        Me.LibXDbSourceTable2.AutoIncrementSerial = False
        Me.LibXDbSourceTable2.CustomDbUpdate = False
        Me.LibXDbSourceTable2.DeleteOrder = 0
        Me.LibXDbSourceTable2.FillOnQuery = True
        Me.LibXDbSourceTable2.FillOnRowChange = True
        Me.LibXDbSourceTable2.HeaderIsOnGrid = False
        Me.LibXDbSourceTable2.InnerJon = True
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = ""
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"paym_serial=paym_serial"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select cppaymd.paym_serial,", "       cppaymd.line_no,", "       cppaymd.suc_code,", "       cppaymd.invce_serial,", "       cpinvcem.type_code,", "       cpinvcem.doc_no,", "       cpinvcem.doc_date,", "       cppaymd.term_code,", "       isnull(cpinvcem.amount,0)-", "       isnull(cpinvcem.disc_amount,0)+", "       isnull(cpinvcem.itbis,0) invce_amount,", "       cpopend.due_date,", "       cpopend.disc_date,", "       datediff(day,cpinvcem.doc_date,", "                    cpopend.due_date) dias,", "       cppaymd.itbis,", "       cppaymd.disc_amount,", "       cppaymd.balance,", "       cppaymd.amount", "  from cppaymd inner join cpinvcem", "    on cppaymd.invce_serial = cpinvcem.invce_serial", " inner join cpopend ", "    on cppaymd.invce_serial = cpopend.invce_serial"}
        Me.LibXDbSourceTable2.TableName = "cppaymd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "tasaUS"
        Me.DataColumn36.DataType = GetType(System.Decimal)
        '
        'xtxt_chequera
        '
        Me.xtxt_chequera.AcceptsReturn = True
        Me.xtxt_chequera.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cppaymm.chequera"))
        Me.xtxt_chequera.EditInitialValue = Nothing
        Me.xtxt_chequera.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chequera.FieldDescription = ""
        Me.xtxt_chequera.FindInitialValue = Nothing
        Me.xtxt_chequera.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chequera.IgnoreRequiered = False
        Me.xtxt_chequera.Location = New System.Drawing.Point(120, 39)
        Me.xtxt_chequera.Name = "xtxt_chequera"
        Me.xtxt_chequera.NewInitialValue = Nothing
        Me.xtxt_chequera.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chequera.Requiered = False
        Me.xtxt_chequera.Size = New System.Drawing.Size(72, 20)
        Me.xtxt_chequera.StatusBarPanelDescripcion = Nothing
        Me.xtxt_chequera.TabIndex = 0
        Me.xtxt_chequera.Text = ""
        '
        'xtxt_type_code
        '
        Me.xtxt_type_code.AcceptsReturn = True
        Me.xtxt_type_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cppaymm.type_code"))
        Me.xtxt_type_code.EditInitialValue = Nothing
        Me.xtxt_type_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_code.FieldDescription = ""
        Me.xtxt_type_code.FindInitialValue = Nothing
        Me.xtxt_type_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_code.IgnoreRequiered = False
        Me.xtxt_type_code.Location = New System.Drawing.Point(120, 64)
        Me.xtxt_type_code.Name = "xtxt_type_code"
        Me.xtxt_type_code.NewInitialValue = Nothing
        Me.xtxt_type_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_code.Requiered = False
        Me.xtxt_type_code.Size = New System.Drawing.Size(72, 20)
        Me.xtxt_type_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_type_code.TabIndex = 2
        Me.xtxt_type_code.Text = ""
        '
        'txtAmount
        '
        Me.txtAmount.AcceptsReturn = True
        Me.txtAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cppaymm.amount"))
        Me.txtAmount.EditInitialValue = Nothing
        Me.txtAmount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAmount.FieldDescription = ""
        Me.txtAmount.FindInitialValue = Nothing
        Me.txtAmount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAmount.IgnoreRequiered = False
        Me.txtAmount.Location = New System.Drawing.Point(408, 112)
        Me.txtAmount.Masked = MaskedTextBox.Mask.Decimal
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.NewInitialValue = Nothing
        Me.txtAmount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAmount.Requiered = False
        Me.txtAmount.Size = New System.Drawing.Size(112, 20)
        Me.txtAmount.StatusBarPanelDescripcion = Nothing
        Me.txtAmount.TabIndex = 7
        Me.txtAmount.Text = ""
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xtxsuc_code)
        Me.GroupBox1.Controls.Add(Me.suc_name)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.klk_suc_code)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.xtxConcepto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.txtPaym_number)
        Me.GroupBox1.Controls.Add(Me.xlk_cust_code)
        Me.GroupBox1.Controls.Add(Me.xdtp_paym_date)
        Me.GroupBox1.Controls.Add(Me.xcbo_paym_status)
        Me.GroupBox1.Controls.Add(Me.prov_name)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xtxt_prov_code)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.balance)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.xtxt_type_name)
        Me.GroupBox1.Controls.Add(Me.xtxt_type_code)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.xlk_type_code)
        Me.GroupBox1.Controls.Add(Me.xtxt_chequera)
        Me.GroupBox1.Controls.Add(Me.xtxt_chequera_name)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.xlk_chequera)
        Me.GroupBox1.Controls.Add(Me.XTextBox5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.XTextBox6)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.xtxt_cuentabancaria)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(896, 184)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'xtxsuc_code
        '
        Me.xtxsuc_code.AcceptsReturn = True
        Me.xtxsuc_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cppaymm.suc_code"))
        Me.xtxsuc_code.EditInitialValue = Nothing
        Me.xtxsuc_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxsuc_code.FieldDescription = ""
        Me.xtxsuc_code.FindInitialValue = Nothing
        Me.xtxsuc_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxsuc_code.IgnoreRequiered = False
        Me.xtxsuc_code.Location = New System.Drawing.Point(120, 13)
        Me.xtxsuc_code.Name = "xtxsuc_code"
        Me.xtxsuc_code.NewInitialValue = Nothing
        Me.xtxsuc_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxsuc_code.Requiered = False
        Me.xtxsuc_code.Size = New System.Drawing.Size(72, 20)
        Me.xtxsuc_code.StatusBarPanelDescripcion = Nothing
        Me.xtxsuc_code.TabIndex = 18
        Me.xtxsuc_code.Text = ""
        '
        'suc_name
        '
        Me.suc_name.AcceptsReturn = True
        Me.suc_name.EditInitialValue = Nothing
        Me.suc_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.suc_name.FieldDescription = ""
        Me.suc_name.FindInitialValue = Nothing
        Me.suc_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.suc_name.IgnoreRequiered = False
        Me.suc_name.Location = New System.Drawing.Point(200, 13)
        Me.suc_name.Name = "suc_name"
        Me.suc_name.NewInitialValue = Nothing
        Me.suc_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.suc_name.ReadOnly = True
        Me.suc_name.Requiered = False
        Me.suc_name.Size = New System.Drawing.Size(304, 20)
        Me.suc_name.StatusBarPanelDescripcion = Nothing
        Me.suc_name.TabIndex = 20
        Me.suc_name.TabStop = False
        Me.suc_name.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(62, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 16)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Sucursal:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'klk_suc_code
        '
        Me.klk_suc_code.AlternateFieldSearch = Nothing
        Me.klk_suc_code.BeginCheck = False
        Me.klk_suc_code.CheckText = Nothing
        Me.klk_suc_code.ComboMode = False
        Me.klk_suc_code.DataMember = Nothing
        Me.klk_suc_code.DataSource = Me.LibXConnector1
        Me.klk_suc_code.DestParameters = New String() {"suc_code=suc_code", "suc_name=suc_name"}
        Me.klk_suc_code.FilterField = "suc_name"
        Me.klk_suc_code.IgnoreFindInBrowseMode = False
        Me.klk_suc_code.isCanceled = False
        Me.klk_suc_code.Location = New System.Drawing.Point(504, 13)
        Me.klk_suc_code.LookCaption = "Sucursales"
        Me.klk_suc_code.Name = "klk_suc_code"
        Me.klk_suc_code.PopupSize = New System.Drawing.Size(600, 300)
        Me.klk_suc_code.ShowFilter = True
        Me.klk_suc_code.ShowMessageNotFound = True
        Me.klk_suc_code.ShowWarning = False
        Me.klk_suc_code.Size = New System.Drawing.Size(16, 20)
        Me.klk_suc_code.SizesColumns = New String() {"suc_name=300"}
        Me.klk_suc_code.SizesColumnsTab = Nothing
        Me.klk_suc_code.SqlString = Nothing
        Me.klk_suc_code.SQLTab = Nothing
        Me.klk_suc_code.SrcParameters = New String() {"suc_code=suc_code"}
        Me.klk_suc_code.TabIndex = 19
        Me.klk_suc_code.TableName = "cgsucursal"
        Me.klk_suc_code.TabStop = False
        Me.klk_suc_code.UseCopyConnection = False
        Me.klk_suc_code.UseRowRetrieveEvents = False
        Me.klk_suc_code.UseTab = False
        Me.klk_suc_code.VisParameters = New String() {"Sucursal=suc_code", "Nombre=suc_name"}
        Me.klk_suc_code.WhereCondition = Nothing
        Me.klk_suc_code.WhereParameters = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(40, 160)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 16)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Concepto Ck:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxConcepto
        '
        Me.xtxConcepto.AcceptsReturn = True
        Me.xtxConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxConcepto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cppaymm.detail"))
        Me.xtxConcepto.EditInitialValue = Nothing
        Me.xtxConcepto.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxConcepto.FieldDescription = ""
        Me.xtxConcepto.FindInitialValue = Nothing
        Me.xtxConcepto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxConcepto.IgnoreRequiered = False
        Me.xtxConcepto.Location = New System.Drawing.Point(120, 159)
        Me.xtxConcepto.Name = "xtxConcepto"
        Me.xtxConcepto.NewInitialValue = Nothing
        Me.xtxConcepto.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxConcepto.Requiered = False
        Me.xtxConcepto.Size = New System.Drawing.Size(680, 20)
        Me.xtxConcepto.StatusBarPanelDescripcion = Nothing
        Me.xtxConcepto.TabIndex = 15
        Me.xtxConcepto.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(200, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Solicitud No:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cppaymm.solicitud"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox1.Enabled = False
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(272, 112)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(72, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 13
        Me.XTextBox1.Text = ""
        '
        'txtPaym_number
        '
        Me.txtPaym_number.AcceptsReturn = True
        Me.txtPaym_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cppaymm.paym_number"))
        Me.txtPaym_number.EditInitialValue = Nothing
        Me.txtPaym_number.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtPaym_number.FieldDescription = ""
        Me.txtPaym_number.FindInitialValue = Nothing
        Me.txtPaym_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPaym_number.IgnoreRequiered = True
        Me.txtPaym_number.Location = New System.Drawing.Point(120, 112)
        Me.txtPaym_number.Name = "txtPaym_number"
        Me.txtPaym_number.NewInitialValue = Nothing
        Me.txtPaym_number.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPaym_number.Requiered = False
        Me.txtPaym_number.Size = New System.Drawing.Size(72, 20)
        Me.txtPaym_number.StatusBarPanelDescripcion = Nothing
        Me.txtPaym_number.TabIndex = 6
        Me.txtPaym_number.Text = ""
        '
        'xlk_cust_code
        '
        Me.xlk_cust_code.AlternateFieldSearch = Nothing
        Me.xlk_cust_code.BeginCheck = False
        Me.xlk_cust_code.CheckText = Nothing
        Me.xlk_cust_code.ComboMode = False
        Me.xlk_cust_code.DataMember = Nothing
        Me.xlk_cust_code.DataSource = Me.LibXConnector1
        Me.xlk_cust_code.DestParameters = New String() {"prov_code=prov_code", "prov_name=prov_name", "balance=balance"}
        Me.xlk_cust_code.FilterField = "prov_name"
        Me.xlk_cust_code.IgnoreFindInBrowseMode = False
        Me.xlk_cust_code.isCanceled = False
        Me.xlk_cust_code.Location = New System.Drawing.Point(504, 88)
        Me.xlk_cust_code.LookCaption = "Clientes"
        Me.xlk_cust_code.Name = "xlk_cust_code"
        Me.xlk_cust_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_cust_code.ShowFilter = True
        Me.xlk_cust_code.ShowMessageNotFound = True
        Me.xlk_cust_code.ShowWarning = False
        Me.xlk_cust_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_cust_code.SizesColumns = Nothing
        Me.xlk_cust_code.SizesColumnsTab = Nothing
        Me.xlk_cust_code.SqlString = Nothing
        Me.xlk_cust_code.SQLTab = Nothing
        Me.xlk_cust_code.SrcParameters = New String() {"prov_code=prov_code"}
        Me.xlk_cust_code.TabIndex = 5
        Me.xlk_cust_code.TableName = "cpprovm"
        Me.xlk_cust_code.TabStop = False
        Me.xlk_cust_code.UseCopyConnection = False
        Me.xlk_cust_code.UseRowRetrieveEvents = False
        Me.xlk_cust_code.UseTab = False
        Me.xlk_cust_code.VisParameters = New String() {"Código=prov_code", "Nombre=prov_name", "Límite Crédito=credit_limit", "Balance=balance"}
        Me.xlk_cust_code.WhereCondition = Nothing
        Me.xlk_cust_code.WhereParameters = Nothing
        '
        'xdtp_paym_date
        '
        Me.xdtp_paym_date.CustomFormat = "dd/MM/yyyy"
        Me.xdtp_paym_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cppaymm.paym_date"))
        Me.xdtp_paym_date.EditInitialValue = Nothing
        Me.xdtp_paym_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_paym_date.FieldDescription = ""
        Me.xdtp_paym_date.FindInitialValue = Nothing
        Me.xdtp_paym_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_paym_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdtp_paym_date.IgnoreRequiered = False
        Me.xdtp_paym_date.Location = New System.Drawing.Point(713, 88)
        Me.xdtp_paym_date.Name = "xdtp_paym_date"
        Me.xdtp_paym_date.NewInitialValue = "Now"
        Me.xdtp_paym_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_paym_date.Requiered = False
        Me.xdtp_paym_date.Size = New System.Drawing.Size(135, 20)
        Me.xdtp_paym_date.StatusBarPanelDescripcion = Nothing
        Me.xdtp_paym_date.TabIndex = 10
        '
        'xcbo_paym_status
        '
        Me.xcbo_paym_status.AllowDefaultSort = True
        Me.xcbo_paym_status.bound = True
        Me.xcbo_paym_status.currValue = Nothing
        Me.xcbo_paym_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cppaymm.paym_status"))
        Me.xcbo_paym_status.DefaultWhereString = Nothing
        Me.xcbo_paym_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_paym_status.EditInitialValue = Nothing
        Me.xcbo_paym_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_paym_status.FieldDescription = ""
        Me.xcbo_paym_status.FindInitialValue = Nothing
        Me.xcbo_paym_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_paym_status.IgnoreRequiered = False
        Me.xcbo_paym_status.Items.AddRange(New Object() {"1-Aplicado", "2-Pendiente de aplicar", "0-Anulado"})
        Me.xcbo_paym_status.Location = New System.Drawing.Point(713, 16)
        Me.xcbo_paym_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_paym_status.LookupKeyField = Nothing
        Me.xcbo_paym_status.LookupTableName = Nothing
        Me.xcbo_paym_status.Name = "xcbo_paym_status"
        Me.xcbo_paym_status.NewInitialValue = "2"
        Me.xcbo_paym_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_paym_status.Requiered = False
        Me.xcbo_paym_status.Required = False
        Me.xcbo_paym_status.Size = New System.Drawing.Size(135, 21)
        Me.xcbo_paym_status.SqlString = Nothing
        Me.xcbo_paym_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_paym_status.TabIndex = 11
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
        Me.prov_name.Location = New System.Drawing.Point(200, 88)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.NewInitialValue = Nothing
        Me.prov_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.ReadOnly = True
        Me.prov_name.Requiered = False
        Me.prov_name.Size = New System.Drawing.Size(304, 20)
        Me.prov_name.StatusBarPanelDescripcion = Nothing
        Me.prov_name.TabIndex = 2
        Me.prov_name.TabStop = False
        Me.prov_name.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(65, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_prov_code
        '
        Me.xtxt_prov_code.AcceptsReturn = True
        Me.xtxt_prov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cppaymm.prov_code"))
        Me.xtxt_prov_code.EditInitialValue = Nothing
        Me.xtxt_prov_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_code.FieldDescription = ""
        Me.xtxt_prov_code.FindInitialValue = Nothing
        Me.xtxt_prov_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_code.IgnoreRequiered = False
        Me.xtxt_prov_code.Location = New System.Drawing.Point(120, 88)
        Me.xtxt_prov_code.Name = "xtxt_prov_code"
        Me.xtxt_prov_code.NewInitialValue = Nothing
        Me.xtxt_prov_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_code.Requiered = False
        Me.xtxt_prov_code.Size = New System.Drawing.Size(72, 20)
        Me.xtxt_prov_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_prov_code.TabIndex = 4
        Me.xtxt_prov_code.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(53, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Proveedor:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'balance
        '
        Me.balance.AcceptsReturn = True
        Me.balance.EditInitialValue = Nothing
        Me.balance.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.balance.FieldDescription = ""
        Me.balance.FindInitialValue = Nothing
        Me.balance.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.balance.IgnoreRequiered = False
        Me.balance.Location = New System.Drawing.Point(713, 64)
        Me.balance.Name = "balance"
        Me.balance.NewInitialValue = Nothing
        Me.balance.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.balance.ReadOnly = True
        Me.balance.Requiered = False
        Me.balance.Size = New System.Drawing.Size(135, 20)
        Me.balance.StatusBarPanelDescripcion = Nothing
        Me.balance.TabIndex = 9
        Me.balance.TabStop = False
        Me.balance.Text = ""
        Me.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(647, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Balance:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(656, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(352, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Monto:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(650, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Estatus:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_type_name
        '
        Me.xtxt_type_name.AcceptsReturn = True
        Me.xtxt_type_name.EditInitialValue = Nothing
        Me.xtxt_type_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_name.FieldDescription = ""
        Me.xtxt_type_name.FindInitialValue = Nothing
        Me.xtxt_type_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_name.IgnoreRequiered = False
        Me.xtxt_type_name.Location = New System.Drawing.Point(200, 64)
        Me.xtxt_type_name.Name = "xtxt_type_name"
        Me.xtxt_type_name.NewInitialValue = Nothing
        Me.xtxt_type_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_name.ReadOnly = True
        Me.xtxt_type_name.Requiered = False
        Me.xtxt_type_name.Size = New System.Drawing.Size(304, 20)
        Me.xtxt_type_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_type_name.TabIndex = 2
        Me.xtxt_type_name.TabStop = False
        Me.xtxt_type_name.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(23, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Tipo Documento:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_type_code
        '
        Me.xlk_type_code.AlternateFieldSearch = Nothing
        Me.xlk_type_code.BeginCheck = False
        Me.xlk_type_code.CheckText = Nothing
        Me.xlk_type_code.ComboMode = False
        Me.xlk_type_code.DataMember = Nothing
        Me.xlk_type_code.DataSource = Me.LibXConnector1
        Me.xlk_type_code.DestParameters = New String() {"type_code=tran_type", "xtxt_type_name=tran_descr"}
        Me.xlk_type_code.FilterField = "tran_descr"
        Me.xlk_type_code.IgnoreFindInBrowseMode = False
        Me.xlk_type_code.isCanceled = False
        Me.xlk_type_code.Location = New System.Drawing.Point(504, 64)
        Me.xlk_type_code.LookCaption = "Tipos Documentos"
        Me.xlk_type_code.Name = "xlk_type_code"
        Me.xlk_type_code.PopupSize = New System.Drawing.Size(400, 350)
        Me.xlk_type_code.ShowFilter = True
        Me.xlk_type_code.ShowMessageNotFound = True
        Me.xlk_type_code.ShowWarning = False
        Me.xlk_type_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_type_code.SizesColumns = Nothing
        Me.xlk_type_code.SizesColumnsTab = Nothing
        Me.xlk_type_code.SqlString = Nothing
        Me.xlk_type_code.SQLTab = Nothing
        Me.xlk_type_code.SrcParameters = New String() {"type_code=tran_type"}
        Me.xlk_type_code.TabIndex = 3
        Me.xlk_type_code.TableName = "cgtrntpm"
        Me.xlk_type_code.TabStop = False
        Me.xlk_type_code.UseCopyConnection = False
        Me.xlk_type_code.UseRowRetrieveEvents = False
        Me.xlk_type_code.UseTab = False
        Me.xlk_type_code.VisParameters = New String() {"Código=tran_type", "Documento=tran_descr"}
        Me.xlk_type_code.WhereCondition = "tran_type in('SOL','CHQ','DPT','PEF')"
        Me.xlk_type_code.WhereParameters = ""
        '
        'xtxt_chequera_name
        '
        Me.xtxt_chequera_name.AcceptsReturn = True
        Me.xtxt_chequera_name.EditInitialValue = Nothing
        Me.xtxt_chequera_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chequera_name.FieldDescription = ""
        Me.xtxt_chequera_name.FindInitialValue = Nothing
        Me.xtxt_chequera_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chequera_name.IgnoreRequiered = False
        Me.xtxt_chequera_name.Location = New System.Drawing.Point(200, 39)
        Me.xtxt_chequera_name.Name = "xtxt_chequera_name"
        Me.xtxt_chequera_name.NewInitialValue = Nothing
        Me.xtxt_chequera_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chequera_name.ReadOnly = True
        Me.xtxt_chequera_name.Requiered = False
        Me.xtxt_chequera_name.Size = New System.Drawing.Size(304, 20)
        Me.xtxt_chequera_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_chequera_name.TabIndex = 2
        Me.xtxt_chequera_name.TabStop = False
        Me.xtxt_chequera_name.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(56, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Chequera:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.xlk_chequera.Location = New System.Drawing.Point(504, 39)
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
        Me.xlk_chequera.TabIndex = 1
        Me.xlk_chequera.TableName = "cpchequera"
        Me.xlk_chequera.TabStop = False
        Me.xlk_chequera.UseCopyConnection = False
        Me.xlk_chequera.UseRowRetrieveEvents = False
        Me.xlk_chequera.UseTab = False
        Me.xlk_chequera.VisParameters = New String() {"Chequera=chequera", "Nombre=descripcion", "Cuenta Banco=cuenta_banco"}
        Me.xlk_chequera.WhereCondition = Nothing
        Me.xlk_chequera.WhereParameters = ""
        '
        'XTextBox5
        '
        Me.XTextBox5.AcceptsReturn = True
        Me.XTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cppaymm.userid"))
        Me.XTextBox5.EditInitialValue = Nothing
        Me.XTextBox5.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox5.FieldDescription = ""
        Me.XTextBox5.FindInitialValue = Nothing
        Me.XTextBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.IgnoreRequiered = False
        Me.XTextBox5.Location = New System.Drawing.Point(713, 112)
        Me.XTextBox5.Name = "XTextBox5"
        Me.XTextBox5.NewInitialValue = Nothing
        Me.XTextBox5.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox5.ReadOnly = True
        Me.XTextBox5.Requiered = False
        Me.XTextBox5.Size = New System.Drawing.Size(135, 20)
        Me.XTextBox5.StatusBarPanelDescripcion = Nothing
        Me.XTextBox5.TabIndex = 7
        Me.XTextBox5.TabStop = False
        Me.XTextBox5.Text = ""
        Me.XTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(649, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Usuario:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox6
        '
        Me.XTextBox6.AcceptsReturn = True
        Me.XTextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cppaymm.date_created"))
        Me.XTextBox6.EditInitialValue = Nothing
        Me.XTextBox6.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox6.FieldDescription = ""
        Me.XTextBox6.FindInitialValue = Nothing
        Me.XTextBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.IgnoreRequiered = False
        Me.XTextBox6.Location = New System.Drawing.Point(713, 40)
        Me.XTextBox6.Name = "XTextBox6"
        Me.XTextBox6.NewInitialValue = Nothing
        Me.XTextBox6.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox6.ReadOnly = True
        Me.XTextBox6.Requiered = False
        Me.XTextBox6.Size = New System.Drawing.Size(71, 20)
        Me.XTextBox6.StatusBarPanelDescripcion = Nothing
        Me.XTextBox6.TabIndex = 8
        Me.XTextBox6.TabStop = False
        Me.XTextBox6.Text = ""
        Me.XTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(651, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Creado:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_cuentabancaria
        '
        Me.xtxt_cuentabancaria.AcceptsReturn = True
        Me.xtxt_cuentabancaria.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cppaymm.cuentabancaria"))
        Me.xtxt_cuentabancaria.EditInitialValue = Nothing
        Me.xtxt_cuentabancaria.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cuentabancaria.FieldDescription = ""
        Me.xtxt_cuentabancaria.FindInitialValue = Nothing
        Me.xtxt_cuentabancaria.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cuentabancaria.IgnoreRequiered = False
        Me.xtxt_cuentabancaria.Location = New System.Drawing.Point(120, 136)
        Me.xtxt_cuentabancaria.Name = "xtxt_cuentabancaria"
        Me.xtxt_cuentabancaria.NewInitialValue = Nothing
        Me.xtxt_cuentabancaria.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cuentabancaria.Requiered = False
        Me.xtxt_cuentabancaria.Size = New System.Drawing.Size(128, 20)
        Me.xtxt_cuentabancaria.StatusBarPanelDescripcion = Nothing
        Me.xtxt_cuentabancaria.TabIndex = 12
        Me.xtxt_cuentabancaria.Text = ""
        Me.xtxt_cuentabancaria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(8, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Cuenta a Depositar:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox7
        '
        Me.TextBox7.AcceptsReturn = True
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cppaymm.detail"))
        Me.TextBox7.EditInitialValue = Nothing
        Me.TextBox7.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox7.FieldDescription = ""
        Me.TextBox7.FindInitialValue = Nothing
        Me.TextBox7.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox7.IgnoreRequiered = False
        Me.TextBox7.Location = New System.Drawing.Point(240, 352)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.NewInitialValue = Nothing
        Me.TextBox7.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox7.Requiered = False
        Me.TextBox7.Size = New System.Drawing.Size(400, 40)
        Me.TextBox7.StatusBarPanelDescripcion = Nothing
        Me.TextBox7.TabIndex = 10
        Me.TextBox7.Text = ""
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Documentos aplicar"
        Me.LibXGrid1.DataMember = "cppaymd"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 219)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(896, 256)
        Me.LibXGrid1.TabIndex = 0
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.xed_Tipo, Me.xed_number, Me.gColterm_code, Me.gColdoc_date, Me.gColdue_date, Me.gColDias, Me.gColItbis, Me.gColAmount, Me.gColBalance, Me.gColdisc_amount, Me.gColdisc_date, Me.gColAplAmount})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cppaymd"
        '
        'xed_Tipo
        '
        Me.xed_Tipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xed_Tipo.Format = ""
        Me.xed_Tipo.FormatInfo = Nothing
        Me.xed_Tipo.HeaderText = "Tipo"
        Me.xed_Tipo.ImageList = Nothing
        Me.xed_Tipo.isReadOnly = True
        Me.xed_Tipo.MappingName = "type_code"
        Me.xed_Tipo.MaxLength = 32767
        Me.xed_Tipo.ReadOnly = True
        Me.xed_Tipo.TabStop = True
        Me.xed_Tipo.UseCustomCellFormat = True
        Me.xed_Tipo.Width = 45
        '
        'xed_number
        '
        Me.xed_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xed_number.Format = ""
        Me.xed_number.FormatInfo = Nothing
        Me.xed_number.HeaderText = "Número"
        Me.xed_number.ImageList = Nothing
        Me.xed_number.isReadOnly = True
        Me.xed_number.MappingName = "doc_no"
        Me.xed_number.MaxLength = 32767
        Me.xed_number.ReadOnly = True
        Me.xed_number.TabStop = True
        Me.xed_number.UseCustomCellFormat = True
        Me.xed_number.Width = 80
        '
        'gColterm_code
        '
        Me.gColterm_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColterm_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColterm_code.executeFindDuringFill = False
        Me.gColterm_code.Format = ""
        Me.gColterm_code.FormatInfo = Nothing
        Me.gColterm_code.HeaderText = "Termino"
        Me.gColterm_code.isReadOnly = False
        Me.gColterm_code.Lookup = Me.xlk_term_code
        Me.gColterm_code.MappingName = "term_code"
        Me.gColterm_code.MaxLength = 32767
        Me.gColterm_code.TabStop = True
        Me.gColterm_code.UseCustomCellFormat = False
        Me.gColterm_code.Width = 55
        '
        'xlk_term_code
        '
        Me.xlk_term_code.AlternateFieldSearch = Nothing
        Me.xlk_term_code.BeginCheck = False
        Me.xlk_term_code.CheckText = Nothing
        Me.xlk_term_code.ComboMode = False
        Me.xlk_term_code.DataMember = Nothing
        Me.xlk_term_code.DataSource = Me.LibXConnector1
        Me.xlk_term_code.DestParameters = New String() {"term_code=term_code"}
        Me.xlk_term_code.FilterField = "term_name"
        Me.xlk_term_code.IgnoreFindInBrowseMode = False
        Me.xlk_term_code.isCanceled = False
        Me.xlk_term_code.Location = New System.Drawing.Point(449, 302)
        Me.xlk_term_code.LookCaption = "Términos de Venta"
        Me.xlk_term_code.Name = "xlk_term_code"
        Me.xlk_term_code.PopupSize = New System.Drawing.Size(500, 400)
        Me.xlk_term_code.ShowFilter = True
        Me.xlk_term_code.ShowMessageNotFound = True
        Me.xlk_term_code.ShowWarning = False
        Me.xlk_term_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_term_code.SizesColumns = Nothing
        Me.xlk_term_code.SizesColumnsTab = Nothing
        Me.xlk_term_code.SqlString = Nothing
        Me.xlk_term_code.SQLTab = Nothing
        Me.xlk_term_code.SrcParameters = New String() {"term_code=term_code"}
        Me.xlk_term_code.TabIndex = 7
        Me.xlk_term_code.TableName = "cctermm"
        Me.xlk_term_code.TabStop = False
        Me.xlk_term_code.UseCopyConnection = False
        Me.xlk_term_code.UseRowRetrieveEvents = False
        Me.xlk_term_code.UseTab = False
        Me.xlk_term_code.VisParameters = New String() {"Código=term_code", "Descripción=term_name", "% Descuento=disc_pct", "Días vencimiento=due_days", "Días Descuento=disc_days"}
        Me.xlk_term_code.WhereCondition = Nothing
        Me.xlk_term_code.WhereParameters = Nothing
        '
        'gColdoc_date
        '
        Me.gColdoc_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColdoc_date.Format = ""
        Me.gColdoc_date.FormatInfo = Nothing
        Me.gColdoc_date.HeaderText = "Fecha"
        Me.gColdoc_date.ImageList = Nothing
        Me.gColdoc_date.isReadOnly = True
        Me.gColdoc_date.MappingName = "doc_date"
        Me.gColdoc_date.MaxLength = 32767
        Me.gColdoc_date.ReadOnly = True
        Me.gColdoc_date.TabStop = True
        Me.gColdoc_date.UseCustomCellFormat = True
        Me.gColdoc_date.Width = 85
        '
        'gColdue_date
        '
        Me.gColdue_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColdue_date.Format = ""
        Me.gColdue_date.FormatInfo = Nothing
        Me.gColdue_date.HeaderText = "Vence"
        Me.gColdue_date.ImageList = Nothing
        Me.gColdue_date.isReadOnly = True
        Me.gColdue_date.MappingName = "due_date"
        Me.gColdue_date.MaxLength = 32767
        Me.gColdue_date.ReadOnly = True
        Me.gColdue_date.TabStop = True
        Me.gColdue_date.UseCustomCellFormat = True
        Me.gColdue_date.Width = 85
        '
        'gColDias
        '
        Me.gColDias.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColDias.Format = "#,###"
        Me.gColDias.FormatInfo = Nothing
        Me.gColDias.HeaderText = "Días"
        Me.gColDias.ImageList = Nothing
        Me.gColDias.isReadOnly = True
        Me.gColDias.MappingName = "dias"
        Me.gColDias.MaxLength = 32767
        Me.gColDias.ReadOnly = True
        Me.gColDias.TabStop = True
        Me.gColDias.UseCustomCellFormat = True
        Me.gColDias.Width = 45
        '
        'gColItbis
        '
        Me.gColItbis.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColItbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColItbis.Format = "###,###,###.00"
        Me.gColItbis.FormatInfo = Nothing
        Me.gColItbis.HeaderText = "ITBISi"
        Me.gColItbis.ImageList = Nothing
        Me.gColItbis.isReadOnly = True
        Me.gColItbis.MappingName = "itbis"
        Me.gColItbis.MaxLength = 32767
        Me.gColItbis.ReadOnly = True
        Me.gColItbis.TabStop = True
        Me.gColItbis.UseCustomCellFormat = True
        Me.gColItbis.Width = 75
        '
        'gColAmount
        '
        Me.gColAmount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColAmount.Format = "###,###,###.00"
        Me.gColAmount.FormatInfo = Nothing
        Me.gColAmount.HeaderText = "Montoi"
        Me.gColAmount.ImageList = Nothing
        Me.gColAmount.isReadOnly = True
        Me.gColAmount.MappingName = "invce_amount"
        Me.gColAmount.MaxLength = 32767
        Me.gColAmount.ReadOnly = True
        Me.gColAmount.TabStop = True
        Me.gColAmount.UseCustomCellFormat = True
        Me.gColAmount.Width = 95
        '
        'gColBalance
        '
        Me.gColBalance.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColBalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColBalance.Format = "###,###,###.00"
        Me.gColBalance.FormatInfo = Nothing
        Me.gColBalance.HeaderText = "Pendientei"
        Me.gColBalance.ImageList = Nothing
        Me.gColBalance.isReadOnly = True
        Me.gColBalance.MappingName = "balance"
        Me.gColBalance.MaxLength = 32767
        Me.gColBalance.ReadOnly = True
        Me.gColBalance.TabStop = True
        Me.gColBalance.UseCustomCellFormat = True
        Me.gColBalance.Width = 95
        '
        'gColdisc_amount
        '
        Me.gColdisc_amount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColdisc_amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColdisc_amount.Format = "###,###,###.00"
        Me.gColdisc_amount.FormatInfo = Nothing
        Me.gColdisc_amount.HeaderText = "Desc. P x Pi"
        Me.gColdisc_amount.ImageList = Nothing
        Me.gColdisc_amount.isReadOnly = False
        Me.gColdisc_amount.MappingName = "disc_amount"
        Me.gColdisc_amount.MaxLength = 32767
        Me.gColdisc_amount.TabStop = True
        Me.gColdisc_amount.UseCustomCellFormat = True
        Me.gColdisc_amount.Width = 75
        '
        'gColdisc_date
        '
        Me.gColdisc_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColdisc_date.Format = ""
        Me.gColdisc_date.FormatInfo = Nothing
        Me.gColdisc_date.HeaderText = "Vencimiento Descuento"
        Me.gColdisc_date.ImageList = Nothing
        Me.gColdisc_date.isReadOnly = True
        Me.gColdisc_date.MappingName = "disc_date"
        Me.gColdisc_date.MaxLength = 32767
        Me.gColdisc_date.ReadOnly = True
        Me.gColdisc_date.TabStop = True
        Me.gColdisc_date.UseCustomCellFormat = True
        Me.gColdisc_date.Width = 0
        '
        'gColAplAmount
        '
        Me.gColAplAmount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColAplAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColAplAmount.Format = "###,###,###.00"
        Me.gColAplAmount.FormatInfo = Nothing
        Me.gColAplAmount.HeaderText = "Aplicadoi"
        Me.gColAplAmount.ImageList = Nothing
        Me.gColAplAmount.isReadOnly = True
        Me.gColAplAmount.MappingName = "amount"
        Me.gColAplAmount.MaxLength = 32767
        Me.gColAplAmount.ReadOnly = True
        Me.gColAplAmount.TabStop = True
        Me.gColAplAmount.UseCustomCellFormat = True
        Me.gColAplAmount.Width = 95
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(8, 545)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Visualizar"
        '
        'btnPagos
        '
        Me.btnPagos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPagos.Enabled = False
        Me.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPagos.Location = New System.Drawing.Point(88, 545)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Size = New System.Drawing.Size(75, 32)
        Me.btnPagos.TabIndex = 4
        Me.btnPagos.Text = "Pagos"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(672, 520)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Pendiente por Aplicar:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPendiente
        '
        Me.txtPendiente.AcceptsReturn = True
        Me.txtPendiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPendiente.EditInitialValue = Nothing
        Me.txtPendiente.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPendiente.FieldDescription = ""
        Me.txtPendiente.FindInitialValue = Nothing
        Me.txtPendiente.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPendiente.IgnoreRequiered = False
        Me.txtPendiente.Location = New System.Drawing.Point(800, 520)
        Me.txtPendiente.Name = "txtPendiente"
        Me.txtPendiente.NewInitialValue = Nothing
        Me.txtPendiente.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPendiente.ReadOnly = True
        Me.txtPendiente.Requiered = False
        Me.txtPendiente.StatusBarPanelDescripcion = Nothing
        Me.txtPendiente.TabIndex = 6
        Me.txtPendiente.Text = ""
        Me.txtPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDistribuir
        '
        Me.btnDistribuir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDistribuir.Enabled = False
        Me.btnDistribuir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDistribuir.Location = New System.Drawing.Point(800, 544)
        Me.btnDistribuir.Name = "btnDistribuir"
        Me.btnDistribuir.Size = New System.Drawing.Size(96, 32)
        Me.btnDistribuir.TabIndex = 5
        Me.btnDistribuir.Text = "Distribuir Automático"
        '
        'btnRemDesc
        '
        Me.btnRemDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemDesc.Enabled = False
        Me.btnRemDesc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemDesc.Location = New System.Drawing.Point(712, 544)
        Me.btnRemDesc.Name = "btnRemDesc"
        Me.btnRemDesc.Size = New System.Drawing.Size(80, 32)
        Me.btnRemDesc.TabIndex = 3
        Me.btnRemDesc.Text = "Remover Desc. x P. P."
        '
        'btnAddDesc
        '
        Me.btnAddDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddDesc.Enabled = False
        Me.btnAddDesc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddDesc.Location = New System.Drawing.Point(624, 544)
        Me.btnAddDesc.Name = "btnAddDesc"
        Me.btnAddDesc.Size = New System.Drawing.Size(80, 32)
        Me.btnAddDesc.TabIndex = 3
        Me.btnAddDesc.Text = "Agregar Desc. x P. P."
        '
        'btnimpck
        '
        Me.btnimpck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnimpck.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnimpck.Location = New System.Drawing.Point(528, 544)
        Me.btnimpck.Name = "btnimpck"
        Me.btnimpck.Size = New System.Drawing.Size(80, 32)
        Me.btnimpck.TabIndex = 15
        Me.btnimpck.Text = "Impresion CK"
        '
        'i_cppaym01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(914, 600)
        Me.Controls.Add(Me.btnimpck)
        Me.Controls.Add(Me.txtPendiente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnPagos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.btnDistribuir)
        Me.Controls.Add(Me.btnRemDesc)
        Me.Controls.Add(Me.btnAddDesc)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.xlk_term_code)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_cppaym01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Registrar Transacciones"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cppaymm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cppaymd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function TieneRecibos(ByVal provCode As Integer) As Boolean
        Dim SelectStmt As String
        Dim Existen As Integer

        SelectStmt = "Select count(*) from cppaymm " & _
                     " where prov_code = " & provCode.ToString.Trim & _
                     " and paym_status = 2" '// Pendente Aplicar

        Existen = LibX.Data.Manager.GetScalar(SelectStmt)

        If Existen > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub DocumentosPendientes(ByVal pprov_code As Integer, ByVal suCursal As Integer)
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim lineno As Integer
        Try
            SelectStmt = "select cpinvcem.invce_serial," & _
                        " cpinvcem.type_code," & _
                        " cpinvcem.doc_no," & _
                        " cpinvcem.suc_code," & _
                        " cpinvcem.doc_date," & _
                        " cpinvcem.term_code," & _
                        " isnull(cpinvcem.amount,0)-isnull(cpinvcem.disc_amount,0)+isnull(cpinvcem.itbis,0) invce_amount," & _
                        " (isnull(cpinvcem.itbis,0) * ivtypem.origen) itbis," & _
                        " cpopend.disc_amount," & _
                        " isnull(cpopend.due_date,getdate())due_date," & _
                        " isnull(cpopend.disc_date,getdate())disc_date," & _
                        " datediff(day," & _
                        " isnull(cpopend.due_date,getdate()),getdate()) dias," & _
                        " cpopend.balance" & _
                        " from cpinvcem " & _
                        " inner join cpopend " & _
                        " on cpinvcem.invce_serial = cpopend.invce_serial" & _
                        " and cpopend.balance <> 0" & _
                        " inner join ivtypem " & _
                        " on ivtypem.type_code = cpinvcem.type_code " & _
                        " where cpinvcem.prov_code = " & pprov_code.ToString & _
                        " and cpinvcem.suc_code = " & suCursal.ToString & _
                        " and (cpinvcem.invce_service = 9 or cpinvcem.invce_service is null) " & _
                        " order by cpinvcem.invce_serial "

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Throw New ApplicationException("No se encontrarón documentos pendientes!")
            End If

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No se encontrarón documentos pendientes!")
            End If

            oTable.TableName = "cppaymd"

            lineno = 0

            cppaymd.Rows.Clear()
            For Each oRow As DataRow In oTable.Rows
                Dim oRow1 As DataRow = cppaymd.NewRow

                lineno += 1
                oRow1!line_no = lineno
                oRow1!type_code = oRow!type_code
                oRow1!doc_no = oRow!doc_no
                oRow1!suc_code = oRow!suc_code
                oRow1!term_code = oRow!term_code
                oRow1!invce_serial = oRow!invce_serial
                oRow1!doc_date = oRow!doc_date
                oRow1!due_date = oRow!due_date
                oRow1!disc_date = oRow!disc_date
                oRow1!dias = oRow!dias
                oRow1!itbis = oRow!itbis
                oRow1!invce_amount = oRow!invce_amount
                oRow1!disc_amount = oRow!disc_amount
                oRow1!balance = oRow!balance

                cppaymd.Rows.Add(oRow1)
            Next

            'Me.LibXGrid1.getCurrentGridView.AllowDelete = False
            Me.LibXGrid1.getCurrentGridView.AllowNew = False
            Me.LibXGrid1.refreshFooter()

            btnPagos.Enabled = cppaymd.Rows.Count > 0
            btnAddDesc.Enabled = cppaymd.Rows.Count > 0
            btnRemDesc.Enabled = cppaymd.Rows.Count > 0

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub xlk_cust_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_cust_code.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            balance.Text = Val(e.row!balance.ToString.Trim).ToString("###,###,##0.00")

            If LibXConnector1.State = LibX.LibxConnectorState.Insert Then
                If TieneRecibos(e.row!prov_code) = True Then
                    Throw New ApplicationException("Este Supldior tiene documentos pendientes por aplicar, Verifique!")
                End If
                xdtp_paym_date.Value = LibX.Data.Manager.Connection.GetDate
            End If
            If LibXConnector1.IsDataEditing = True Then
                DocumentosPendientes(e.row!prov_code, xtxsuc_code.Text)
            End If

        Catch ex As Exception
            e.handled = True
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Function FindSucursal() As Integer
        Dim oSucursal As Integer
        Dim SelectStmt As String
        SelectStmt = "select suc_code from cgsucursal where suc_default = 1 "
        oSucursal = LibX.Data.Manager.GetScalar(SelectStmt)
        Return oSucursal
    End Function
    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Dim XUpdate As LibX.Data.XUpdateStmt
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Or e.UpdatingArgs.StatementType = StatementType.Update Then
                '// Datos
                If LibX.IsNull(e.UpdatingArgs.Row!paym_date) Then e.UpdatingArgs.Row!paym_date = LibX.Data.Manager.Connection.GetDate

                e.UpdatingArgs.Row!whse_code = WhDefault
                e.UpdatingArgs.Row!impreso = 0
                e.UpdatingArgs.Row!date_created = LibX.Data.Manager.GetScalar("select getdate()")
                e.UpdatingArgs.Row!detail = Find_Factura()

                If LibX.IsNull(e.UpdatingArgs.Row!amount) _
                OrElse Val(e.UpdatingArgs.Row!amount) <= 0 Then
                    Throw New ApplicationException("Monto del Documento inválido!!")
                End If
                If Me.txtAmount.Text <> toTalAplicado Then
                    Throw New ApplicationException("El monto del documento no coincide con el total aplicado!")
                End If

                '//Auto numeracion
                If oDocument.AutoNumerable = True Then
                    If LibX.IsNull(e.UpdatingArgs.Row!paym_number) = False Then
                        If e.UpdatingArgs.Row!paym_number > oDocument.Numero Then
                            Throw New ApplicationException("No puede digitar un numero mayor que la secuencia del documento para esta chequera!")
                        End If
                    Else
                        e.UpdatingArgs.Row!paym_number = oDocument.GenerateNumber(e.UpdatingArgs.Row!type_code, e.UpdatingArgs.Row!chequera)
                    End If
                Else
                    If LibX.IsNull(e.UpdatingArgs.Row!paym_number) = True Then
                        Throw New ApplicationException("Debe especificar el No. de documento!")
                    End If
                End If
            End If

            If e.UpdatingArgs.StatementType = StatementType.Delete Then
                If e.UpdatingArgs.Row.Item("paym_status", DataRowVersion.Original) = 3 Then
                    e.UpdatingArgs.Status = UpdateStatus.SkipAllRemainingRows
                    AnularDocumento(e.UpdatingArgs.Row)
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
        End Try
    End Sub
    Private Sub AnularDocumento(ByVal oRow As DataRow)
        Dim oPost As SGT.Caja.Operaciones.Cobro
        Dim oParam As SGT.Caja.Operaciones.Cobro.ParametrosAnular

        Try
            oPost = New SGT.Caja.Operaciones.Cobro
            oParam = New SGT.Caja.Operaciones.Cobro.ParametrosAnular

            With oParam
                .Serial = oRow.Item("paym_serial", DataRowVersion.Original)
                .AfectaCXC = True
                .UserTransaction = False
            End With

            oPost.Anular(oParam)

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub
    Private Sub i_ccpaym01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            oParamValidar = New SGT.Administracion.Entidades.Permission.ParametrosValidar
            oAutorizar = New SGT.Administracion.Entidades.Permission

            Porc_mora = LibX.Data.Manager.GetScalar("select charge from ivsetup")

            LibXGrid1.footerOperations.add("type_code", "count(type_code)")
            LibXGrid1.footerOperations.add("amount", "sum(amount)")
            LibXGrid1.footerOperations.add("dias", "count(dias)", "dias > 0")
            LibXGrid1.footerOperations.add("disc_amount", "sum(disc_amount)")
            LibXGrid1.footerOperations.add("invce_amount", "sum(invce_amount)")
            LibXGrid1.footerOperations.add("balance", "sum(balance)")

            WhDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibXWhDefault")
            xlk_cust_code.BeginCheck = True
            xlk_cust_code.CheckText = "Balance mayor que 0"

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
        Dim MontoAplicar As Decimal
        Dim MontoPendiente As Decimal
        Dim MontoDescuento As Decimal

        Try
            If LibXConnector1.IsDataEditing = True Then
                '// Monto Aplicar no puede ser mayor que monto pendiete
                MontoAplicar = Val(Me.LibXGrid1.GetValue(e.row, Me.gColAplAmount).Trim)
                MontoPendiente = Val(Me.LibXGrid1.GetValue(e.row, Me.gColBalance).Trim) - Val(Me.LibXGrid1.GetValue(e.row, Me.gColdisc_amount).Trim)
                MontoDescuento = Val(Me.LibXGrid1.GetValue(e.row, Me.gColdisc_amount).Trim)

                '// Descuento
                If e.cell = Me.gColdisc_amount.Column Then
                    If Math.Abs(MontoDescuento) > Math.Abs(Val(Me.LibXGrid1.GetValue(e.row, Me.gColBalance).Trim)) Then
                        e.hasErrors = True
                        Throw New ApplicationException("El descuento no puede ser mayor que el monto del documento!")
                    End If

                    LibXGrid1.SetValue(e.row, Me.gColAplAmount, MontoPendiente)

                    If Me.LibXGrid1.GetValue(e.row, Me.xed_Tipo).Trim = "NCR" And MontoDescuento > 0 Then
                        e.hasErrors = True
                        Throw New ApplicationException("El descuento no puede ser mayor que el monto del documento!")
                    Else
                        If Me.LibXGrid1.GetValue(e.row, Me.xed_Tipo).Trim <> "NCR" And MontoDescuento < 0 Then
                            e.hasErrors = True
                            Throw New ApplicationException("El descuento no puede ser negativo!")
                        End If
                    End If

                End If

                '// Monto Aplicado
                If e.cell = Me.gColAplAmount.Column Then
                    If MontoAplicar > 0 Then
                        If Math.Abs(MontoAplicar) > Math.Abs(MontoPendiente) Then
                            e.hasErrors = True
                            Throw New ApplicationException("Monto a aplicar no puede ser mayor que monto pendiente!")
                        End If
                    End If
                End If

                '// 
                LibXGrid1.EndEdit(gColAplAmount, e.row, False)
                Calcular()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub AsignarMonto(ByVal Row As Integer)
        Dim Aplicar As Decimal
        Dim DescuentoPP As Decimal
        Dim Disc_Amount As Decimal
        Dim Monto As Decimal
        Dim crd, ncr As String

        Try
            DescuentoPP = Val(cppaymd.Rows(Row)!disc_amount.ToString.Trim)
            Aplicar = Val(cppaymd.Rows(Row)!balance.ToString.Trim) - Val(cppaymd.Rows(Row)!disc_amount.ToString.Trim)

            '// si se aplico reversar
            If Val(cppaymd.Rows(Row)!Amount.ToString.Trim) <> 0 Then
                If mDigitado = False Then
                    Monto = CDbl(Me.txtAmount.Text.Trim) - Val(cppaymd.Rows(Row)!Amount.ToString.Trim)
                    Me.txtAmount.Text = Format(Monto, "##,###,##0.00")
                End If

                cppaymd.Rows(Row).BeginEdit()
                cppaymd.Rows(Row)!Amount = DBNull.Value
                Disc_Amount -= DescuentoPP

                '// Si el monto del documento es menor que la parte a aplicar
                '// asignar el monto del documento como monto a aplicar
            ElseIf Val(cppaymd.Rows(Row)!balance.ToString.Trim) <= mResta Or mDigitado = False Then
                If mDigitado = False Then
                    Monto = Val(Me.txtAmount.Text.Trim) + Aplicar
                    Me.txtAmount.Text = Format(Monto, "##,###,##0.00")
                End If

                cppaymd.Rows(Row).BeginEdit()
                cppaymd.Rows(Row)!Amount = Aplicar
                Disc_Amount += DescuentoPP

                '// Si el monto de documento es mayor que el monto restante
                '// Asignar el monto restante
            Else
                If Aplicar >= mResta Then
                    cppaymd.Rows(Row).BeginEdit()
                    cppaymd.Rows(Row)!Amount = mResta
                End If
            End If

            cppaymd.Rows(Row).EndEdit()
            Calcular()
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub LibXConnector1_InsertingDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingDetailRow
        Dim xUpdate As LibX.Data.XUpdateStmt
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then
                If LibX.IsNull(e.UpdatingArgs.Row!amount) Or LibX.IsNull(e.UpdatingArgs.Row!line_no) Then
                    e.UpdatingArgs.Status = UpdateStatus.SkipCurrentRow
                    e.UpdatingArgs.Row.AcceptChanges()
                End If

                If IsNull(xdtp_paym_date.Value) Then
                    xdtp_paym_date.Value = LibX.Data.Manager.Connection.GetDate.ToString("d")
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
        End Try
    End Sub
    Private Sub Calcular()
        Dim Aplicar As Decimal, Aplicado As Decimal, Resta As Decimal
        Dim Descto As Decimal
        Dim i As Integer

        Try
            If txtAmount.Text.Length > 0 Then
                Aplicar = CDbl(txtAmount.Text.Trim) - Descto
            End If

            Aplicado = 0
            mResta = 0

            For i = 0 To cppaymd.Rows.Count - 1
                If LibXGrid1.GetValue(i, Me.gColAmount) <> "" Then
                    Aplicado += Val(LibXGrid1.GetValue(i, Me.gColAplAmount).ToString)
                End If
            Next

            toTalAplicado = Format(Aplicado, "##,###,##0.00")
            If mDigitado = False And Aplicado <> 0 Then
                Me.txtAmount.Text = Format(Aplicado, "##,###,##0.00")
            End If

            If Aplicar > 0 Then
                mResta = Aplicar - Aplicado
            Else
                Aplicar = Aplicado
            End If

            Me.LibXGrid1.refreshFooter()
            If mDigitado = True Then
                txtPendiente.Text = Format(mResta, "##,###,##0.00")
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub txtAmount_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAmount.Validating
        Dim SelectStmt As String
        Try
            If LibXConnector1.IsDataEditing = True Then
                If mDigitado = True Then
                    mResta = CDbl(txtAmount.Text)
                    Me.txtPendiente.Text = mResta.ToString("###,###.##")
                Else
                    mResta = 0.0
                    Me.txtPendiente.Text = mResta.ToString("###,###.##")
                End If
            End If

            If LibXConnector1.IsDataEditing = True And LibXConnector1.CurrentAction = LibxConnectionActions.Edit Then
                UseTransaction = True
                If UseTransaction = True And inUseTransaction = False Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                    inUseTransaction = True
                    '''// Si se esta editando el documento y se va a cambiar el monto 
                    '''// que borre el detalle para insertarlo nuevamente
                    For Each oRow As DataRow In cppaymd.Select()
                        SelectStmt = "delete cppaymd where paym_serial = " & oRow!paym_serial.ToString.Trim
                        LibX.Data.Manager.GetScalar(SelectStmt)
                    Next
                End If

                If txtAmount.Text <> "" Then
                    Me.txtAmount.Text = ""
                    Me.xtxConcepto.Text = ""
                    mDigitado = False
                    DocumentosPendientes(xtxt_prov_code.Text.Trim, xtxsuc_code.Text)
                End If

                Calcular()

                If mResta < 0 Then
                    DocumentosPendientes(xtxt_prov_code.Text.Trim, xtxsuc_code.Text)
                    Calcular()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_SettingDefaultqueryValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultQueryValues) Handles LibXConnector1.SettingDefaultqueryValues
        Try
            If LibXConnector1.IsDataEditing = True Then
                xdtp_paym_date.Value = LibX.Data.Manager.Connection.GetDate.ToString("d")
            End If
            xcbo_paym_status.currValue = 2
            txtPaym_number.Enabled = True
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDistribuir.Click
        Dim RowIndex As Integer = 0
        Dim descto As Decimal
        Dim aplicado As Decimal
        Try
            If txtAmount.Text.Length = 0 Then
                txtAmount.Text = Format(Val(LibXGrid1.GetFooterValue(Me.gColBalance).ToString.Trim) - Val(LibXGrid1.GetFooterValue(Me.gColdisc_amount).ToString.Trim), "###,###,##0.00")
            Else
                RemovarAplicar()
            End If

            If mResta = 0 Then
                aplicado = Val(LibXGrid1.GetFooterValue(gColAplAmount).ToString.Trim)
                mResta = txtAmount.Text - aplicado
            End If

            '// Aplicar Nota de Credito
            For Each orow As DataRow In cppaymd.Select("balance < 0")
                orow.BeginEdit()
                orow!amount = (Val(orow!balance.Tostring.Trim) - Val(orow!disc_amount.Tostring.Trim))
                mResta -= Val(orow!Balance.Tostring.Trim) - Val(orow!disc_amount.Tostring.Trim)
                orow.EndEdit()
            Next

            '// Aplicar Facturas
            For Each orow As DataRow In cppaymd.Select("balance > 0", "due_date")
                If Val(orow!amount.Tostring.Trim) = 0 Then
                    orow.BeginEdit()
                    If mResta > (Val(orow!balance.Tostring.Trim) - Val(orow!disc_amount.Tostring.Trim)) Then
                        mResta -= Val(orow!balance.Tostring.Trim) - Val(orow!disc_amount.Tostring.Trim)
                        orow!amount = (Val(orow!balance.Tostring.Trim) - Val(orow!disc_amount.Tostring.Trim))
                        descto += Val(orow!disc_amount.Tostring.Trim)
                    Else
                        orow!amount = mResta
                        mResta = 0
                    End If
                    orow.EndEdit()
                    If mResta = 0 Then
                        Exit For
                    End If
                End If
            Next

            Calcular()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub
    Private Sub RemovarAplicar()
        For RowIdx As Integer = 0 To LibXGrid1.getCurrentGridView.Count - 1
            '// Se asigna 1 para que al ejecutar el metodo AsignarMonto
            '// y este limpie el valor
            LibXGrid1.SetValue(RowIdx, gColAplAmount, 0)
        Next
        mResta = 0
        Calcular()

    End Sub
    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        e.AditionalWhere = "cppaymm.whse_code = " & WhDefault.ToString
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagos.Click
        Dim oParam As LibX.LibxPrgParams
        Dim WhereStmt As String
        Try
            oParam = New LibX.LibxPrgParams
            oParam.WhereToExecute = "cpinvcem.type_code = '" & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xed_Tipo).ToString & "'" & _
                                    " and cpinvcem.doc_no = '" & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xed_number).ToString & "'"
            LibX.App.CurrentPrgParams = oParam

            LibX.LibXRunner.Run("c_cpdocs01", "CXP", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub xlk_cust_code_CreatedGridColumns(ByVal sender As Object, ByVal e As LibX.CreatedGridColumnsEventArgs) Handles xlk_cust_code.CreatedGridColumns
        Try
            e.TStyle.GridColumnStyles.Item("prov_name").Width = 500
            e.TStyle.GridColumnStyles.Item("credit_limit").Width = 150
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub xlk_cust_code_CheckedChanged(ByVal sender As Object, ByVal e As LibX.CheckedChangedEventArgs) Handles xlk_cust_code.CheckedChanged
        If e.CheckStatus = True Then
            e.Table.DefaultView.RowFilter = "balance > 0"
        Else
            e.Table.DefaultView.RowFilter = ""
        End If
    End Sub
    Private Sub xlk_type_code_AfterSetValues(ByVal sender As System.Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_type_code.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.IsDataEditing = True Then
                oDocument = New TipoDocumento(e.row!tran_type, e.row!chequera)

                If oDocument.AutoNumerable = True And e.row!tran_type <> "CHQ" Then
                    txtPaym_number.Enabled = False
                    txtPaym_number.TabStop = False
                    txtPaym_number.BackColor = System.Drawing.SystemColors.Control
                Else
                    txtPaym_number.Enabled = True
                    txtPaym_number.TabStop = True
                    txtPaym_number.BackColor = System.Drawing.SystemColors.Window
                End If

                ''// CHEQUES
                If e.row!tran_type = "CHQ" Then
                    Me.xtxt_cuentabancaria.Enabled = False
                    Me.xtxt_cuentabancaria.TabStop = False
                    Me.xtxt_cuentabancaria.BackColor = System.Drawing.SystemColors.Control
                End If

                ''// NOTA DE DEBITO
                If e.row!tran_type = "NDB" Then
                    Me.xtxt_cuentabancaria.TabStop = False
                    Me.xtxt_cuentabancaria.Enabled = False
                    Me.xtxt_cuentabancaria.BackColor = System.Drawing.SystemColors.Control
                End If

                ''// DEPOSITO
                If e.row!tran_type = "DEP" Then
                    Me.xtxt_cuentabancaria.TabStop = True
                    Me.xtxt_cuentabancaria.Enabled = True
                    Me.xtxt_cuentabancaria.BackColor = System.Drawing.SystemColors.Window
                End If
                If e.row!tran_type = "DPT" Then
                    Me.xtxt_cuentabancaria.TabStop = True
                    Me.xtxt_cuentabancaria.Enabled = True
                    Me.xtxt_cuentabancaria.BackColor = System.Drawing.SystemColors.Window
                End If
                ''// SOLICITUD
                If e.row!tran_type = "SOL" Then
                    Me.xtxt_cuentabancaria.TabStop = True
                    Me.xtxt_cuentabancaria.Enabled = True
                    Me.xtxt_cuentabancaria.BackColor = System.Drawing.SystemColors.Window
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub LibXGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LibXGrid1.DoubleClick
        Try

            If LibXConnector1.IsEditing = True Then
                AsignarMonto(LibXGrid1.CurrentRowIndex)
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub xlk_dev_serial_BeforeExecuteQuery(ByVal sender As System.Object, ByVal e As LibX.BeforeExecuteQueryEventArgs)
        Try
            If LibXConnector1.IsDataEditing = True Then
                If Me.xtxt_prov_code.Text.Trim <> "" Then
                    e.aditionalWhere = "prov_code = " & Me.xtxt_prov_code.Text.Trim
                Else
                    Throw New ApplicationException("Debe especificar el suplidor antes!")
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub gColdisc_amount_SetCellFormat(ByVal sender As Object, ByVal e As LibX.XDataGridFormatCellEventArgs) Handles gColdisc_amount.SetCellFormat
        Try
            If LibXConnector1.IsDataEditing = True Then
                If LibXGrid1.GetValue(e.RowNumber, gColdisc_date).Trim <> "" Then
                    If CDate(LibXGrid1.GetValue(e.RowNumber, gColdisc_date)) < LibX.Data.Manager.Connection.GetDate Then
                        e.ForeColor = System.Drawing.Color.Red
                    End If
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub xed_number_SetCellFormat(ByVal sender As System.Object, ByVal e As LibX.XDataGridFormatCellEventArgs) Handles xed_number.SetCellFormat, xed_Tipo.SetCellFormat, gColAmount.SetCellFormat, gColBalance.SetCellFormat, gColDias.SetCellFormat, gColdisc_date.SetCellFormat, gColdisc_amount.SetCellFormat, gColdoc_date.SetCellFormat, gColdue_date.SetCellFormat, gColItbis.SetCellFormat
        Try
            If LibXConnector1.IsDataEditing = True Then
                If LibXGrid1.GetValue(e.RowNumber, gColdue_date).Trim <> "" Then
                    If CDate(LibXGrid1.GetValue(e.RowNumber, gColdue_date)) < LibX.Data.Manager.Connection.GetDate Then
                        e.ForeColor = System.Drawing.Color.Red
                    End If
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        mDigitado = False
        txtPendiente.Text = "0.00"
        mResta = 0.0
        Me.xtxsuc_code.Text = FindSucursal()
        Me.klk_suc_code.ExecuteFind()
        xdtp_paym_date.Value = LibX.Data.Manager.Connection.GetDate.ToString("d")
        LibXConnector1.CurrentDataRow!paym_date = LibX.Data.Manager.Connection.GetDate
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemDesc.Click
        Try
            For Each oRow As DataRow In cppaymd.Rows
                oRow!disc_amount = DBNull.Value
                oRow!amount = DBNull.Value
            Next

            Calcular()

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDesc.Click
        Try
            DocumentosPendientes(xtxt_prov_code.Text.Trim, xtxsuc_code.Text)
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub LibXNavigator1_ActionClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.ActionClick
        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Accept Then
                If UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                    LibX.Data.Manager.Connection.CommitTransaction()
                    inUseTransaction = False
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If Not e.row Is Nothing Then
                If e.row!paym_status <> 2 Then  '// Aplicado o Anulado
                    LibXConnector1.AllowDelete = False
                    LibXConnector1.AllowEdit = False
                Else
                    LibXConnector1.AllowDelete = True
                    LibXConnector1.AllowEdit = True
                End If
                LibXNavigator1.UpdateState()
            End If
            If LibXConnector1.CurrentAction = LibxConnectionActions.Cancel Then
                If LibXConnector1.AllowEdit = True Then
                    If UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                        LibX.Data.Manager.Connection.RollBackTransaction()
                        inUseTransaction = False
                        cppaymm.Rows.Clear()
                        Me.xtxt_chequera_name.Text = ""
                        Me.xtxt_type_name.Text = ""
                        Me.balance.Text = ""
                        Me.prov_name.Text = ""
                    End If
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_ChangingState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangingState
        Try
            btnPagos.Enabled = False
            btnAddDesc.Enabled = False
            btnRemDesc.Enabled = False
            ''Me.btnimpck.Enabled = (Not e.isEditing AndAlso LibXConnector1.HasRecords = True AndAlso LibXConnector1.CurrentDataRow!type_code = "CHQ" _
            ''AndAlso LibXConnector1.CurrentDataRow!impreso = 0 AndAlso LibXConnector1.CurrentDataRow!paym_number > 0)
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub xlk_term_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_term_code.AfterSetValues
        Dim Descuento As Decimal
        Dim Balance As Decimal
        If e.dataFound = False Then
            Exit Sub
        End If
        Try

            Balance = Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColBalance) - Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColItbis)
            Descuento = Decimal.Round(Balance * (Val(e.row!disc_pct.ToString.Trim) / 100), 2)
            LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, gColdisc_amount, Descuento)
            LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, gColAplAmount, Decimal.Zero)

            '// Remover o Seleccionar el documento
            AsignarMonto(LibXGrid1.CurrentRowIndex)

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        Try
            If LibXConnector1.IsDataEditing = True Then
                If txtAmount.Text.Trim <> "" Then
                    mDigitado = True
                Else
                    mDigitado = False
                End If

                Me.btnDistribuir.Enabled = mDigitado
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try

            If e.AcceptedAction = LibxConnectionActions.Add _
            Or e.AcceptedAction = LibxConnectionActions.Edit Then
                Me.LibXGrid1.getCurrentGridView.AllowDelete = True
                Me.LibXGrid1.getCurrentGridView.AllowNew = True
                concepto = ""
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub xlk_chequera_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_chequera.AfterSetValues
        Try
            If LibXConnector1.IsDataEditing = True Then
                If e.dataFound = True Then
                    oChequera = New Chequera(e.row!chequera)
                    If LibX.IsNull(LibXConnector1.CurrentDataRow!type_code) = False Then
                        oDocument = New SGT.ControlBancario.Entidades.TipoDocumento(LibXConnector1.CurrentDataRow!type_code, e.row!chequera)
                    End If
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub xlk_type_code_BeforeExecuteQuery(ByVal sender As System.Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_type_code.BeforeExecuteQuery
        Try
            If Me.xtxt_chequera.Text.Trim <> "" Then
                e.aditionalWhere = " cgtrntpm.chequera = " & Me.xtxt_chequera.Text & " and cgtrntpm.tran_type not in ('DEP','DCC','ED')"
            Else
                Throw New ApplicationException("Debe especificar una chequera antes!")
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub txtPaym_number_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPaym_number.Validating
        Try
            If LibXConnector1.IsDataEditing = True Then
                If oDocument.AutoNumerable = False Then
                    If Me.xtxt_type_code.Text <> "" And Me.xtxt_chequera.Text <> "" And Me.txtPaym_number.Text <> "" Then
                        If oDocument.NumberExiste(Me.xtxt_type_code.Text, Me.xtxt_chequera.Text, Me.txtPaym_number.Text) = True Then
                            Throw New ApplicationException("Este Numero de Documento existe para esta chequera Verifique!")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            'e.Cancel = True 
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        Dim SelectStmt As String
        Try
            If LibXConnector1.CurrentAction = LibxConnectionActions.Edit Then
                For i As Integer = 0 To cppaymd.Rows.Count - 1
                    If cppaymd.Rows(i).RowState <> DataRowState.Deleted AndAlso LibX.IsNull(cppaymd.Rows(i)!amount) And Not LibX.IsNull(cppaymd.Rows(i)!paym_serial.ToString.Trim) Then
                        SelectStmt = "delete cppaymd where paym_serial = " & cppaymd.Rows(i)!paym_serial.ToString.Trim & " and line_no = " & cppaymd.Rows(i)!line_no.ToString.Trim
                        LibX.Data.Manager.GetScalar(SelectStmt)
                    End If
                Next
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaulteditValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultEditValues) Handles LibXConnector1.SettingDefaulteditValues
        Try
            oDocument = New TipoDocumento(LibXConnector1.CurrentDataRow!type_code, LibXConnector1.CurrentDataRow!chequera)
            LibXConnector1.CurrentDataRow!paym_date = LibX.Data.Manager.Connection.GetDate
            ''mDigitado = True
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            If (e.AcceptedAction = LibxConnectionActions.Add _
            Or e.AcceptedAction = LibxConnectionActions.Edit) And e.Action <> LibxConnectionActions.Cancel Then
                If DataSet1.Tables("cppaymd").Select("amount <> 0").Length <= 0 Then
                    Throw New ApplicationException("Debe especificar los documentos a pagar!")
                End If
            End If
            If e.Action = LibxConnectionActions.Edit Then
                Me.xtxConcepto.Enabled = True
            End If

        Catch ex As Exception
            e.Handled = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub ImpresionCk()
        Dim SelecStmt As String
        Dim AxCrystalReport1 As LibX.ReportLib
        Dim Archivo As String = ""
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim oTable As DataTable
        Dim neW_Number As Integer
        Dim CurrenSerial As Integer
        Dim mOnto As Decimal
        Dim SelectStmt As String
        Dim oParamAplicar As SGT.ControlBancario.Entidades.Chequera.ParametrosAplicar

        Try
            SelectStmt = "select * from sgfprinter where print_default = 0 "
            oRowPrinter = LibX.Data.Manager.GetDataRow(SelectStmt)

            oChequera = New Chequera(LibXConnector1.CurrentDataRow!chequera)
            Me.Cursor = Cursors.WaitCursor
            CurrenSerial = LibXConnector1.CurrentDataRow!paym_serial
            mOnto = LibXConnector1.CurrentDataRow!amount

            If LibX.IsNull(oChequera.Banco) = False Then
                Archivo = AsignarImpresion(oChequera.Codigo)
            End If

            If LibXConnector1.CurrentDataRow!impreso = 1 Then
                oParamValidar.AccessKey = "RK"
                oAutorizar.PermisosAutorizados.Remove("RK")

                If oAutorizar.isAutorization(oParamValidar) = False Then
                    ''e.Handled = True
                    Throw New ApplicationException("Autorización Invalida")
                End If
            End If
            If LibXConnector1.CurrentDataRow!type_code = "CHQ" Then
                xUpdate = New LibX.Data.XUpdateStmt("cppaymm")
                xUpdate.FieldsSet("impreso") = 1
                xUpdate.Fields("paym_serial") = CurrenSerial
                xUpdate.Execute()
            End If

            If Archivo = "" Then
                AxCrystalReport1 = New LibX.ReportLib("CXP", "r_cpcheques.rpt")
            Else
                AxCrystalReport1 = New LibX.ReportLib("CXP", Archivo)
            End If

            With AxCrystalReport1
                '// Recibir el SQL Query
                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, "vw_cpimpck.paym_serial = " & CurrenSerial)
                .SQLQuery = SelecStmt
                '''If LibXConnector1.CurrentDataRow!type_code = "CHQ" Then
                '''    .PrinterName = oRowPrinter!print_name.ToString
                '''    .Destination = 1
                '''End If

                '// Ejecutar el reporte
                .Action = 1

            End With

        Catch ex As Exception
            If UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
            LibX.Log.Show(ex)
        Finally
            Me.Cursor = Cursors.Default
            ''RefreshGrid()
        End Try

    End Sub

    Private Function AsignarImpresion(ByVal IDChequera As Integer) As String
        Dim Archivo As String
        Dim SelectStmt As String
        Dim oRow As DataRow

        SelectStmt = "select cheque_format from cpchequera " & _
                     "where cpchequera.chequera = " & IDChequera.ToString.Trim

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oRow Is Nothing Then
            Return ""
        End If

        If LibX.IsNull(oRow!cheque_format) = True Then
            Return ""
        End If

        Archivo = oRow!cheque_format.ToString.Trim

        Return Archivo
    End Function

    Private Sub btnimpck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimpck.Click
        ImpresionCk()
    End Sub
    Public Function Find_Factura() As String
        Dim rEtorno As String
        Dim dOCno As DataRow

        For Each oRow As DataRow In DataSet1.Tables("cppaymd").Rows
            If Not LibX.IsNull(oRow!amount) Then
                dOCno = LibX.Data.Manager.GetDataRow("select doc_no,type_code from cpinvcem where invce_serial = " & oRow!invce_serial)
                If rEtorno = "" Then
                    rEtorno = dOCno!type_code & "-" & dOCno!doc_no
                Else
                    rEtorno = rEtorno & ";" & dOCno!type_code & "-" & dOCno!doc_no
                End If
            End If
        Next
        Return rEtorno
    End Function

    Private Sub xdtp_paym_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xdtp_paym_date.ValueChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                If xdtp_paym_date.Value > LibX.Data.Manager.GetScalar("select getdate()") Then
                    xdtp_paym_date.Value = LibX.Data.Manager.GetScalar("select getdate()")
                    Throw New ApplicationException("La fecha no debe ser mayor a la fecha del dia")
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

End Class
