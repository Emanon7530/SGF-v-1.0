Imports SGT.Contabilidad.Entidades
Imports SGT.ControlBancario.Entidades
Imports SGT.Administracion.Entidades
Public Class i_cbdocs01
    Inherits System.Windows.Forms.Form
    Dim oDocumento As SGT.Contabilidad.Entidades.Documentos
    Dim oTransacion As SGT.ControlBancario.Entidades.TipoDocumento
    Dim oAplicar As SGT.CXP.Posteos.PostDocument
    Dim oParamValidar As SGT.Administracion.Entidades.Permission.ParametrosValidar
    Dim oAutorizar As SGT.Administracion.Entidades.Permission
    Dim oChequera As Chequera
    Dim Action As Integer
    Dim oAnoFiscal As SGT.Contabilidad.Entidades.AnoFiscal
    Dim oRowPrinter As DataRow
    Dim oPeriodo As Periodo
    Dim Cuenta As String
    Dim Acct_amt As Decimal
    Dim smSerial As Boolean = False
    Dim mItbisRetenido As Decimal
    Dim CuentaItbis As String
    Dim mIsrRetenido As Decimal
    Dim CuentaIsr As String
    Dim Mcodifica As Decimal

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
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblType_name As System.Windows.Forms.Label
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgc_acct_no As LibX.XDataGridTextButtonColumn
    Friend WithEvents dgc_tran_descr As LibX.XEditTextBoxColumn
    Friend WithEvents dgc_debit_amount As LibX.XEditTextBoxColumn
    Friend WithEvents dgc_credit_amount As LibX.XEditTextBoxColumn
    Friend WithEvents lblDiferencia As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents xdb_depto As LibX.XDataGridTextButtonColumn
    Friend WithEvents xlk_depto_code As LibX.LibXLookup
    Friend WithEvents LibXDbSourceTable5 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable6 As LibX.LibXDbSourceTable
    Friend WithEvents TextBox4 As LibX.XTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents xlk_chequera As LibX.LibXLookup
    Friend WithEvents xtxt_chequera_name As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents xtxt_amount As LibX.XMaskEdit
    Friend WithEvents xcbo_doc_status As LibX.LibXCombo
    Friend WithEvents xtxt_type_code As LibX.XTextBox
    Friend WithEvents xtxt_doc_numer As LibX.XTextBox
    Friend WithEvents xtxt_benef As LibX.XTextBox
    Friend WithEvents xtxt_chequera As LibX.XTextBox
    Friend WithEvents XLK_tran_type As LibX.LibXLookup
    Friend WithEvents xlk_acct_no As LibX.LibXLookup
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
    Friend WithEvents cbdocsm As System.Data.DataTable
    Friend WithEvents cbdocsd As System.Data.DataTable
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
    Friend WithEvents xdt_doc_date As LibX.LibxDateTimePicker
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents xtxsuc_name As System.Windows.Forms.Label
    Friend WithEvents xtxsuc_code As LibX.XTextBox
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents lblbalance As System.Windows.Forms.Label
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents lblYear As LibX.XMaskEdit
    Friend WithEvents lblNumber As LibX.XMaskEdit
    Friend WithEvents btnCajaChica As System.Windows.Forms.Button
    Friend WithEvents DataColumn31 As System.Data.DataColumn

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.cbdocsm = New System.Data.DataTable
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
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.cbdocsd = New System.Data.DataTable
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.LibXDbSourceTable6 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable5 = New LibX.LibXDbSourceTable
        Me.xtxt_chequera = New LibX.XTextBox
        Me.xtxt_type_code = New LibX.XTextBox
        Me.xtxt_benef = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCajaChica = New System.Windows.Forms.Button
        Me.lblNumber = New LibX.XMaskEdit
        Me.lblYear = New LibX.XMaskEdit
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.xtxsuc_code = New LibX.XTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.xtxsuc_name = New System.Windows.Forms.Label
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.xcbo_doc_status = New LibX.LibXCombo
        Me.xdt_doc_date = New LibX.LibxDateTimePicker
        Me.xlk_chequera = New LibX.LibXLookup
        Me.lblbalance = New System.Windows.Forms.Label
        Me.XLK_tran_type = New LibX.LibXLookup
        Me.lblType_name = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.xtxt_doc_numer = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TextBox4 = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.xtxt_amount = New LibX.XMaskEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.xtxt_chequera_name = New System.Windows.Forms.Label
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.dgc_acct_no = New LibX.XDataGridTextButtonColumn
        Me.xlk_acct_no = New LibX.LibXLookup
        Me.xdb_depto = New LibX.XDataGridTextButtonColumn
        Me.xlk_depto_code = New LibX.LibXLookup
        Me.dgc_tran_descr = New LibX.XEditTextBoxColumn
        Me.dgc_debit_amount = New LibX.XEditTextBoxColumn
        Me.dgc_credit_amount = New LibX.XEditTextBoxColumn
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblDiferencia = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbdocsm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbdocsd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_chequera
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_chequera
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(744, 24)
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
        Me.LibXConnector1.DataMember = "cbdocsm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = "CTB"
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = ""
        Me.LibXConnector1.ReportObject = Nothing
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable6, Me.LibXDbSourceTable5})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.cbdocsm, Me.cbdocsd})
        '
        'cbdocsm
        '
        Me.cbdocsm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn27, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31})
        Me.cbdocsm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"cbm_serial"}, True)})
        Me.cbdocsm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
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
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "tran_type"
        Me.DataColumn3.MaxLength = 3
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "doc_number"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "doc_date"
        Me.DataColumn5.DataType = GetType(System.DateTime)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "doc_status"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Benef"
        Me.DataColumn7.MaxLength = 60
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "doc_concept"
        Me.DataColumn8.MaxLength = 1500
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "amount"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "conc_serial"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "perdr_year"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "perdr_num"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "date_conc"
        Me.DataColumn13.DataType = GetType(System.DateTime)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "date_created"
        Me.DataColumn14.DataType = GetType(System.DateTime)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "userid"
        Me.DataColumn15.DataType = GetType(System.Int32)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "doc_origen"
        Me.DataColumn16.DataType = GetType(System.Int32)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "tranr_serial"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "suc_code"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "conc_transito"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "doc_transito"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "cbm_impreso"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'cbdocsd
        '
        Me.cbdocsd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn28})
        Me.cbdocsd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"cbm_serial", "line_no"}, True)})
        Me.cbdocsd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn18, Me.DataColumn19}
        Me.cbdocsd.TableName = "cbdocsd"
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "cbm_serial"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.AutoIncrement = True
        Me.DataColumn19.ColumnName = "line_no"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "acct_no"
        Me.DataColumn20.MaxLength = 20
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "dept_code"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "debit_credit"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "amount"
        Me.DataColumn23.DataType = GetType(System.Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "acct_name"
        Me.DataColumn24.MaxLength = 60
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "debit_amount"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "credit_amount"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.ColumnName = "suc_code"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'LibXDbSourceTable6
        '
        Me.LibXDbSourceTable6.AllowDelete = True
        Me.LibXDbSourceTable6.AllowEdit = True
        Me.LibXDbSourceTable6.AllowNew = True
        Me.LibXDbSourceTable6.AutoIncrementSerial = False
        Me.LibXDbSourceTable6.CustomDbUpdate = False
        Me.LibXDbSourceTable6.DeleteOrder = 0
        Me.LibXDbSourceTable6.FillOnQuery = True
        Me.LibXDbSourceTable6.FillOnRowChange = True
        Me.LibXDbSourceTable6.HeaderIsOnGrid = False
        Me.LibXDbSourceTable6.InnerJon = True
        Me.LibXDbSourceTable6.InsertOrder = 0
        Me.LibXDbSourceTable6.IsDetail = True
        Me.LibXDbSourceTable6.KeyFields = Nothing
        Me.LibXDbSourceTable6.LineColName = "line_no"
        Me.LibXDbSourceTable6.MasterDetailRelation = New String() {"cbm_serial=cbm_serial", "suc_code=suc_code"}
        Me.LibXDbSourceTable6.MasterTableName = Nothing
        Me.LibXDbSourceTable6.SerialColumnName = Nothing
        Me.LibXDbSourceTable6.Sort = Nothing
        Me.LibXDbSourceTable6.Source = New String() {"select cbdocsd.*,cgacctm.acct_name ", "from cbdocsd", "inner join cgacctm ", "on cgacctm.acct_no = cbdocsd.acct_no", "order by cbdocsd.line_no,cbdocsd.debit_credit"}
        Me.LibXDbSourceTable6.TableName = "cbdocsd"
        Me.LibXDbSourceTable6.UpdateOrder = 0
        Me.LibXDbSourceTable6.UseRowRetrieve = False
        '
        'LibXDbSourceTable5
        '
        Me.LibXDbSourceTable5.AllowDelete = True
        Me.LibXDbSourceTable5.AllowEdit = True
        Me.LibXDbSourceTable5.AllowNew = True
        Me.LibXDbSourceTable5.AutoIncrementSerial = False
        Me.LibXDbSourceTable5.CustomDbUpdate = False
        Me.LibXDbSourceTable5.DeleteOrder = 0
        Me.LibXDbSourceTable5.FillOnQuery = True
        Me.LibXDbSourceTable5.FillOnRowChange = False
        Me.LibXDbSourceTable5.HeaderIsOnGrid = False
        Me.LibXDbSourceTable5.InnerJon = True
        Me.LibXDbSourceTable5.InsertOrder = 0
        Me.LibXDbSourceTable5.IsDetail = False
        Me.LibXDbSourceTable5.KeyFields = Nothing
        Me.LibXDbSourceTable5.LineColName = Nothing
        Me.LibXDbSourceTable5.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable5.MasterTableName = Nothing
        Me.LibXDbSourceTable5.SerialColumnName = "cbm_serial"
        Me.LibXDbSourceTable5.Sort = Nothing
        Me.LibXDbSourceTable5.Source = Nothing
        Me.LibXDbSourceTable5.TableName = "cbdocsm"
        Me.LibXDbSourceTable5.UpdateOrder = 0
        Me.LibXDbSourceTable5.UseRowRetrieve = False
        '
        'xtxt_chequera
        '
        Me.xtxt_chequera.AcceptsReturn = True
        Me.xtxt_chequera.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbdocsm.chequera"))
        Me.xtxt_chequera.EditInitialValue = Nothing
        Me.xtxt_chequera.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chequera.FieldDescription = ""
        Me.xtxt_chequera.FindInitialValue = Nothing
        Me.xtxt_chequera.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chequera.IgnoreRequiered = False
        Me.xtxt_chequera.Location = New System.Drawing.Point(122, 35)
        Me.xtxt_chequera.Name = "xtxt_chequera"
        Me.xtxt_chequera.NewInitialValue = Nothing
        Me.xtxt_chequera.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chequera.Requiered = False
        Me.xtxt_chequera.Size = New System.Drawing.Size(40, 20)
        Me.xtxt_chequera.StatusBarPanelDescripcion = Nothing
        Me.xtxt_chequera.TabIndex = 2
        Me.xtxt_chequera.Text = ""
        '
        'xtxt_type_code
        '
        Me.xtxt_type_code.AcceptsReturn = True
        Me.xtxt_type_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbdocsm.tran_type"))
        Me.xtxt_type_code.EditInitialValue = Nothing
        Me.xtxt_type_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_code.FieldDescription = ""
        Me.xtxt_type_code.FindInitialValue = Nothing
        Me.xtxt_type_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_code.IgnoreRequiered = False
        Me.xtxt_type_code.Location = New System.Drawing.Point(122, 56)
        Me.xtxt_type_code.Name = "xtxt_type_code"
        Me.xtxt_type_code.NewInitialValue = Nothing
        Me.xtxt_type_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_code.Requiered = False
        Me.xtxt_type_code.Size = New System.Drawing.Size(40, 20)
        Me.xtxt_type_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_type_code.TabIndex = 4
        Me.xtxt_type_code.Text = ""
        '
        'xtxt_benef
        '
        Me.xtxt_benef.AcceptsReturn = True
        Me.xtxt_benef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_benef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbdocsm.Benef"))
        Me.xtxt_benef.EditInitialValue = Nothing
        Me.xtxt_benef.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_benef.FieldDescription = ""
        Me.xtxt_benef.FindInitialValue = Nothing
        Me.xtxt_benef.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_benef.IgnoreRequiered = False
        Me.xtxt_benef.Location = New System.Drawing.Point(122, 127)
        Me.xtxt_benef.Name = "xtxt_benef"
        Me.xtxt_benef.NewInitialValue = Nothing
        Me.xtxt_benef.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_benef.Requiered = False
        Me.xtxt_benef.Size = New System.Drawing.Size(360, 20)
        Me.xtxt_benef.StatusBarPanelDescripcion = Nothing
        Me.xtxt_benef.TabIndex = 8
        Me.xtxt_benef.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCajaChica)
        Me.GroupBox1.Controls.Add(Me.lblNumber)
        Me.GroupBox1.Controls.Add(Me.lblYear)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.xtxsuc_code)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.xtxsuc_name)
        Me.GroupBox1.Controls.Add(Me.LibxCheckBox1)
        Me.GroupBox1.Controls.Add(Me.xcbo_doc_status)
        Me.GroupBox1.Controls.Add(Me.xdt_doc_date)
        Me.GroupBox1.Controls.Add(Me.xlk_chequera)
        Me.GroupBox1.Controls.Add(Me.lblbalance)
        Me.GroupBox1.Controls.Add(Me.XLK_tran_type)
        Me.GroupBox1.Controls.Add(Me.lblType_name)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xtxt_type_code)
        Me.GroupBox1.Controls.Add(Me.xtxt_doc_numer)
        Me.GroupBox1.Controls.Add(Me.xtxt_benef)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.xtxt_chequera)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.xtxt_amount)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.xtxt_chequera_name)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 224)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnCajaChica
        '
        Me.btnCajaChica.Enabled = False
        Me.btnCajaChica.Location = New System.Drawing.Point(320, 80)
        Me.btnCajaChica.Name = "btnCajaChica"
        Me.btnCajaChica.Size = New System.Drawing.Size(80, 32)
        Me.btnCajaChica.TabIndex = 18
        Me.btnCajaChica.Text = "Reposision"
        '
        'lblNumber
        '
        Me.lblNumber.AcceptsReturn = True
        Me.lblNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbdocsm.perdr_num"))
        Me.lblNumber.EditInitialValue = Nothing
        Me.lblNumber.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.lblNumber.FieldDescription = ""
        Me.lblNumber.FindInitialValue = Nothing
        Me.lblNumber.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lblNumber.IgnoreRequiered = False
        Me.lblNumber.Location = New System.Drawing.Point(664, 16)
        Me.lblNumber.Masked = MaskedTextBox.Mask.Digit
        Me.lblNumber.MaxLength = 2
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.NewInitialValue = Nothing
        Me.lblNumber.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.lblNumber.Requiered = False
        Me.lblNumber.Size = New System.Drawing.Size(56, 20)
        Me.lblNumber.StatusBarPanelDescripcion = Nothing
        Me.lblNumber.TabIndex = 17
        Me.lblNumber.Text = ""
        Me.lblNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblYear
        '
        Me.lblYear.AcceptsReturn = True
        Me.lblYear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbdocsm.perdr_year"))
        Me.lblYear.EditInitialValue = Nothing
        Me.lblYear.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.lblYear.FieldDescription = ""
        Me.lblYear.FindInitialValue = Nothing
        Me.lblYear.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lblYear.IgnoreRequiered = False
        Me.lblYear.Location = New System.Drawing.Point(600, 16)
        Me.lblYear.Masked = MaskedTextBox.Mask.Digit
        Me.lblYear.MaxLength = 4
        Me.lblYear.Name = "lblYear"
        Me.lblYear.NewInitialValue = Nothing
        Me.lblYear.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.lblYear.Requiered = False
        Me.lblYear.Size = New System.Drawing.Size(56, 20)
        Me.lblYear.StatusBarPanelDescripcion = Nothing
        Me.lblYear.TabIndex = 16
        Me.lblYear.Text = ""
        Me.lblYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"suc_code=suc_code", "xtxsuc_name=suc_name"}
        Me.LibXLookup1.FilterField = "suc_name"
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(481, 14)
        Me.LibXLookup1.LookCaption = "Sucursales"
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.PopupSize = New System.Drawing.Size(600, 300)
        Me.LibXLookup1.ShowFilter = True
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.ShowWarning = False
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SizesColumns = New String() {"suc_name=300"}
        Me.LibXLookup1.SizesColumnsTab = Nothing
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"suc_code=suc_code"}
        Me.LibXLookup1.TabIndex = 1
        Me.LibXLookup1.TableName = "cgsucursal"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=suc_code", "Nombre=suc_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = ""
        '
        'xtxsuc_code
        '
        Me.xtxsuc_code.AcceptsReturn = True
        Me.xtxsuc_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbdocsm.suc_code"))
        Me.xtxsuc_code.EditInitialValue = Nothing
        Me.xtxsuc_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxsuc_code.FieldDescription = ""
        Me.xtxsuc_code.FindInitialValue = Nothing
        Me.xtxsuc_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxsuc_code.IgnoreRequiered = False
        Me.xtxsuc_code.Location = New System.Drawing.Point(122, 13)
        Me.xtxsuc_code.Name = "xtxsuc_code"
        Me.xtxsuc_code.NewInitialValue = Nothing
        Me.xtxsuc_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxsuc_code.Requiered = False
        Me.xtxsuc_code.Size = New System.Drawing.Size(40, 20)
        Me.xtxsuc_code.StatusBarPanelDescripcion = Nothing
        Me.xtxsuc_code.TabIndex = 0
        Me.xtxsuc_code.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(58, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Sucursal:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxsuc_name
        '
        Me.xtxsuc_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xtxsuc_name.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.xtxsuc_name.Location = New System.Drawing.Point(170, 13)
        Me.xtxsuc_name.Name = "xtxsuc_name"
        Me.xtxsuc_name.Size = New System.Drawing.Size(312, 20)
        Me.xtxsuc_name.TabIndex = 15
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "cbdocsm.conc_serial"))
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(600, 64)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = Nothing
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = False
        Me.LibxCheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox1.TabIndex = 11
        Me.LibxCheckBox1.Text = "Conciliado"
        Me.LibxCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'xcbo_doc_status
        '
        Me.xcbo_doc_status.AllowDefaultSort = True
        Me.xcbo_doc_status.bound = True
        Me.xcbo_doc_status.currValue = Nothing
        Me.xcbo_doc_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cbdocsm.doc_status"))
        Me.xcbo_doc_status.DefaultWhereString = Nothing
        Me.xcbo_doc_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_doc_status.EditInitialValue = Nothing
        Me.xcbo_doc_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_doc_status.FieldDescription = ""
        Me.xcbo_doc_status.FindInitialValue = Nothing
        Me.xcbo_doc_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_doc_status.IgnoreRequiered = False
        Me.xcbo_doc_status.Items.AddRange(New Object() {"1-Aplicado", "2-Pendiente", "0-Anulado"})
        Me.xcbo_doc_status.Location = New System.Drawing.Point(600, 88)
        Me.xcbo_doc_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_doc_status.LookupKeyField = Nothing
        Me.xcbo_doc_status.LookupTableName = Nothing
        Me.xcbo_doc_status.Name = "xcbo_doc_status"
        Me.xcbo_doc_status.NewInitialValue = "2"
        Me.xcbo_doc_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_doc_status.Requiered = False
        Me.xcbo_doc_status.Required = False
        Me.xcbo_doc_status.Size = New System.Drawing.Size(120, 21)
        Me.xcbo_doc_status.SqlString = Nothing
        Me.xcbo_doc_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_doc_status.TabIndex = 6
        '
        'xdt_doc_date
        '
        Me.xdt_doc_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_doc_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cbdocsm.doc_date"))
        Me.xdt_doc_date.EditInitialValue = Nothing
        Me.xdt_doc_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_doc_date.FieldDescription = ""
        Me.xdt_doc_date.FindInitialValue = Nothing
        Me.xdt_doc_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_doc_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_doc_date.IgnoreRequiered = False
        Me.xdt_doc_date.Location = New System.Drawing.Point(600, 112)
        Me.xdt_doc_date.Name = "xdt_doc_date"
        Me.xdt_doc_date.NewInitialValue = "now"
        Me.xdt_doc_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_doc_date.Requiered = False
        Me.xdt_doc_date.Size = New System.Drawing.Size(120, 20)
        Me.xdt_doc_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_doc_date.TabIndex = 10
        '
        'xlk_chequera
        '
        Me.xlk_chequera.AlternateFieldSearch = Nothing
        Me.xlk_chequera.BeginCheck = False
        Me.xlk_chequera.CheckText = Nothing
        Me.xlk_chequera.ComboMode = False
        Me.xlk_chequera.DataMember = Nothing
        Me.xlk_chequera.DataSource = Me.LibXConnector1
        Me.xlk_chequera.DestParameters = New String() {"chequera=chequera", "xtxt_chequera_name=descripcion", "lblbalance=balance_actual"}
        Me.xlk_chequera.FilterField = "descripcion"
        Me.xlk_chequera.IgnoreFindInBrowseMode = False
        Me.xlk_chequera.isCanceled = False
        Me.xlk_chequera.Location = New System.Drawing.Point(482, 35)
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
        Me.xlk_chequera.TabIndex = 3
        Me.xlk_chequera.TableName = "cpchequera"
        Me.xlk_chequera.TabStop = False
        Me.xlk_chequera.UseCopyConnection = False
        Me.xlk_chequera.UseRowRetrieveEvents = False
        Me.xlk_chequera.UseTab = False
        Me.xlk_chequera.VisParameters = New String() {"Chequera=chequera", "Nombre=descripcion", "Cuenta Banco=cuenta_banco", "Balance=balance_actual"}
        Me.xlk_chequera.WhereCondition = Nothing
        Me.xlk_chequera.WhereParameters = ""
        '
        'lblbalance
        '
        Me.lblbalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblbalance.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblbalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbalance.Location = New System.Drawing.Point(600, 40)
        Me.lblbalance.Name = "lblbalance"
        Me.lblbalance.Size = New System.Drawing.Size(120, 20)
        Me.lblbalance.TabIndex = 10
        Me.lblbalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'XLK_tran_type
        '
        Me.XLK_tran_type.AlternateFieldSearch = Nothing
        Me.XLK_tran_type.BeginCheck = False
        Me.XLK_tran_type.CheckText = Nothing
        Me.XLK_tran_type.ComboMode = False
        Me.XLK_tran_type.DataMember = Nothing
        Me.XLK_tran_type.DataSource = Me.LibXConnector1
        Me.XLK_tran_type.DestParameters = New String() {"tran_type=tran_type", "lblType_name=tran_descr"}
        Me.XLK_tran_type.FilterField = Nothing
        Me.XLK_tran_type.IgnoreFindInBrowseMode = False
        Me.XLK_tran_type.isCanceled = False
        Me.XLK_tran_type.Location = New System.Drawing.Point(482, 59)
        Me.XLK_tran_type.LookCaption = "Tipos de Documentos"
        Me.XLK_tran_type.Name = "XLK_tran_type"
        Me.XLK_tran_type.PopupSize = New System.Drawing.Size(0, 0)
        Me.XLK_tran_type.ShowFilter = True
        Me.XLK_tran_type.ShowMessageNotFound = True
        Me.XLK_tran_type.ShowWarning = False
        Me.XLK_tran_type.Size = New System.Drawing.Size(16, 20)
        Me.XLK_tran_type.SizesColumns = Nothing
        Me.XLK_tran_type.SizesColumnsTab = Nothing
        Me.XLK_tran_type.SqlString = New String() {"select distinct tran_type,tran_descr from cgtrntpm where (conciliable = 1 or tran" & _
        "_type ='SOL')"}
        Me.XLK_tran_type.SQLTab = Nothing
        Me.XLK_tran_type.SrcParameters = New String() {"tran_type=tran_type"}
        Me.XLK_tran_type.TabIndex = 5
        Me.XLK_tran_type.TableName = "cgtrntpm"
        Me.XLK_tran_type.TabStop = False
        Me.XLK_tran_type.UseCopyConnection = False
        Me.XLK_tran_type.UseRowRetrieveEvents = False
        Me.XLK_tran_type.UseTab = False
        Me.XLK_tran_type.VisParameters = New String() {"Documento=tran_type", "Descripción=tran_descr"}
        Me.XLK_tran_type.WhereCondition = ""
        Me.XLK_tran_type.WhereParameters = ""
        '
        'lblType_name
        '
        Me.lblType_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblType_name.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblType_name.Location = New System.Drawing.Point(170, 56)
        Me.lblType_name.Name = "lblType_name"
        Me.lblType_name.Size = New System.Drawing.Size(312, 20)
        Me.lblType_name.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(491, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha Documento:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_doc_numer
        '
        Me.xtxt_doc_numer.AcceptsReturn = True
        Me.xtxt_doc_numer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbdocsm.doc_number"))
        Me.xtxt_doc_numer.EditInitialValue = Nothing
        Me.xtxt_doc_numer.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_doc_numer.FieldDescription = ""
        Me.xtxt_doc_numer.FindInitialValue = Nothing
        Me.xtxt_doc_numer.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_doc_numer.IgnoreRequiered = True
        Me.xtxt_doc_numer.Location = New System.Drawing.Point(122, 80)
        Me.xtxt_doc_numer.Name = "xtxt_doc_numer"
        Me.xtxt_doc_numer.NewInitialValue = Nothing
        Me.xtxt_doc_numer.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_doc_numer.Requiered = False
        Me.xtxt_doc_numer.Size = New System.Drawing.Size(88, 20)
        Me.xtxt_doc_numer.StatusBarPanelDescripcion = Nothing
        Me.xtxt_doc_numer.TabIndex = 6
        Me.xtxt_doc_numer.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(544, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Balance:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(546, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Estatus:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(-3, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Número  Documento:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(16, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tipo  Documento:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(42, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Beneficiario:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(545, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 16)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Periodo:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox4
        '
        Me.TextBox4.AcceptsReturn = True
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbdocsm.doc_concept"))
        Me.TextBox4.EditInitialValue = Nothing
        Me.TextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.FieldDescription = ""
        Me.TextBox4.FindInitialValue = Nothing
        Me.TextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.IgnoreRequiered = False
        Me.TextBox4.Location = New System.Drawing.Point(122, 150)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.NewInitialValue = Nothing
        Me.TextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.Requiered = False
        Me.TextBox4.Size = New System.Drawing.Size(592, 56)
        Me.TextBox4.StatusBarPanelDescripcion = Nothing
        Me.TextBox4.TabIndex = 9
        Me.TextBox4.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(53, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Concepto:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(52, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Chequera:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_amount
        '
        Me.xtxt_amount.AcceptsReturn = True
        Me.xtxt_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbdocsm.amount"))
        Me.xtxt_amount.EditInitialValue = Nothing
        Me.xtxt_amount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_amount.FieldDescription = ""
        Me.xtxt_amount.FindInitialValue = Nothing
        Me.xtxt_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_amount.IgnoreRequiered = False
        Me.xtxt_amount.Location = New System.Drawing.Point(122, 104)
        Me.xtxt_amount.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxt_amount.Name = "xtxt_amount"
        Me.xtxt_amount.NewInitialValue = Nothing
        Me.xtxt_amount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_amount.Requiered = False
        Me.xtxt_amount.Size = New System.Drawing.Size(88, 20)
        Me.xtxt_amount.StatusBarPanelDescripcion = Nothing
        Me.xtxt_amount.TabIndex = 7
        Me.xtxt_amount.Text = ""
        Me.xtxt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(70, 107)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 16)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Monto:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_chequera_name
        '
        Me.xtxt_chequera_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xtxt_chequera_name.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.xtxt_chequera_name.Location = New System.Drawing.Point(170, 35)
        Me.xtxt_chequera_name.Name = "xtxt_chequera_name"
        Me.xtxt_chequera_name.Size = New System.Drawing.Size(312, 20)
        Me.xtxt_chequera_name.TabIndex = 4
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Codificacion Contable"
        Me.LibXGrid1.DataMember = "cbdocsd"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 258)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(728, 224)
        Me.LibXGrid1.TabIndex = 0
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgc_acct_no, Me.xdb_depto, Me.dgc_tran_descr, Me.dgc_debit_amount, Me.dgc_credit_amount})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cbdocsd"
        '
        'dgc_acct_no
        '
        Me.dgc_acct_no.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.dgc_acct_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.dgc_acct_no.executeFindDuringFill = False
        Me.dgc_acct_no.Format = ""
        Me.dgc_acct_no.FormatInfo = Nothing
        Me.dgc_acct_no.HeaderText = "Número Cuenta"
        Me.dgc_acct_no.isReadOnly = False
        Me.dgc_acct_no.Lookup = Me.xlk_acct_no
        Me.dgc_acct_no.MappingName = "acct_no"
        Me.dgc_acct_no.MaxLength = 32767
        Me.dgc_acct_no.TabStop = True
        Me.dgc_acct_no.UseCustomCellFormat = False
        Me.dgc_acct_no.Width = 150
        '
        'xlk_acct_no
        '
        Me.xlk_acct_no.AlternateFieldSearch = Nothing
        Me.xlk_acct_no.BeginCheck = False
        Me.xlk_acct_no.CheckText = Nothing
        Me.xlk_acct_no.ComboMode = False
        Me.xlk_acct_no.DataMember = Nothing
        Me.xlk_acct_no.DataSource = Me.LibXConnector1
        Me.xlk_acct_no.DestParameters = New String() {"acct_no=acct_no", "acct_name=acct_name", "debit_credit=acct_origen"}
        Me.xlk_acct_no.FilterField = "acct_name"
        Me.xlk_acct_no.IgnoreFindInBrowseMode = False
        Me.xlk_acct_no.isCanceled = False
        Me.xlk_acct_no.Location = New System.Drawing.Point(416, 507)
        Me.xlk_acct_no.LookCaption = "Cuentas Contables"
        Me.xlk_acct_no.Name = "xlk_acct_no"
        Me.xlk_acct_no.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_acct_no.ShowFilter = True
        Me.xlk_acct_no.ShowMessageNotFound = True
        Me.xlk_acct_no.ShowWarning = False
        Me.xlk_acct_no.Size = New System.Drawing.Size(16, 20)
        Me.xlk_acct_no.SizesColumns = Nothing
        Me.xlk_acct_no.SizesColumnsTab = Nothing
        Me.xlk_acct_no.SqlString = Nothing
        Me.xlk_acct_no.SQLTab = Nothing
        Me.xlk_acct_no.SrcParameters = New String() {"acct_no=acct_no"}
        Me.xlk_acct_no.TabIndex = 9
        Me.xlk_acct_no.TableName = "cgacctm"
        Me.xlk_acct_no.TabStop = False
        Me.xlk_acct_no.UseCopyConnection = False
        Me.xlk_acct_no.UseRowRetrieveEvents = False
        Me.xlk_acct_no.UseTab = False
        Me.xlk_acct_no.VisParameters = New String() {"Número Cuenta=acct_no", "Nombre Cuenta=acct_name"}
        Me.xlk_acct_no.WhereCondition = "acct_isctrl = 0"
        Me.xlk_acct_no.WhereParameters = Nothing
        '
        'xdb_depto
        '
        Me.xdb_depto.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.xdb_depto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdb_depto.executeFindDuringFill = False
        Me.xdb_depto.Format = ""
        Me.xdb_depto.FormatInfo = Nothing
        Me.xdb_depto.HeaderText = "Depto."
        Me.xdb_depto.isReadOnly = False
        Me.xdb_depto.Lookup = Me.xlk_depto_code
        Me.xdb_depto.MappingName = "dept_code"
        Me.xdb_depto.MaxLength = 32767
        Me.xdb_depto.TabStop = True
        Me.xdb_depto.UseCustomCellFormat = False
        Me.xdb_depto.Width = 70
        '
        'xlk_depto_code
        '
        Me.xlk_depto_code.AlternateFieldSearch = Nothing
        Me.xlk_depto_code.BeginCheck = False
        Me.xlk_depto_code.CheckText = Nothing
        Me.xlk_depto_code.ComboMode = False
        Me.xlk_depto_code.DataMember = Nothing
        Me.xlk_depto_code.DataSource = Me.LibXConnector1
        Me.xlk_depto_code.DestParameters = New String() {"dept_code=dept_code"}
        Me.xlk_depto_code.FilterField = Nothing
        Me.xlk_depto_code.IgnoreFindInBrowseMode = False
        Me.xlk_depto_code.isCanceled = False
        Me.xlk_depto_code.Location = New System.Drawing.Point(440, 168)
        Me.xlk_depto_code.LookCaption = Nothing
        Me.xlk_depto_code.Name = "xlk_depto_code"
        Me.xlk_depto_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_depto_code.ShowFilter = True
        Me.xlk_depto_code.ShowMessageNotFound = True
        Me.xlk_depto_code.ShowWarning = False
        Me.xlk_depto_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_depto_code.SizesColumns = Nothing
        Me.xlk_depto_code.SizesColumnsTab = Nothing
        Me.xlk_depto_code.SqlString = Nothing
        Me.xlk_depto_code.SQLTab = Nothing
        Me.xlk_depto_code.SrcParameters = New String() {"dept_code=dept_code"}
        Me.xlk_depto_code.TabIndex = 10
        Me.xlk_depto_code.TableName = "cgdeptm"
        Me.xlk_depto_code.TabStop = False
        Me.xlk_depto_code.UseCopyConnection = False
        Me.xlk_depto_code.UseRowRetrieveEvents = False
        Me.xlk_depto_code.UseTab = False
        Me.xlk_depto_code.VisParameters = New String() {"Código=dept_code", "Nombre=dept_name"}
        Me.xlk_depto_code.WhereCondition = Nothing
        Me.xlk_depto_code.WhereParameters = Nothing
        '
        'dgc_tran_descr
        '
        Me.dgc_tran_descr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.dgc_tran_descr.Format = ""
        Me.dgc_tran_descr.FormatInfo = Nothing
        Me.dgc_tran_descr.HeaderText = "Descripción"
        Me.dgc_tran_descr.ImageList = Nothing
        Me.dgc_tran_descr.isReadOnly = True
        Me.dgc_tran_descr.MappingName = "acct_name"
        Me.dgc_tran_descr.MaxLength = 32767
        Me.dgc_tran_descr.ReadOnly = True
        Me.dgc_tran_descr.TabStop = False
        Me.dgc_tran_descr.UseCustomCellFormat = False
        Me.dgc_tran_descr.Width = 250
        '
        'dgc_debit_amount
        '
        Me.dgc_debit_amount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgc_debit_amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.dgc_debit_amount.Format = "###,###,##0.00"
        Me.dgc_debit_amount.FormatInfo = Nothing
        Me.dgc_debit_amount.HeaderText = "Débitoi"
        Me.dgc_debit_amount.ImageList = Nothing
        Me.dgc_debit_amount.isReadOnly = False
        Me.dgc_debit_amount.MappingName = "debit_amount"
        Me.dgc_debit_amount.MaxLength = 32767
        Me.dgc_debit_amount.TabStop = True
        Me.dgc_debit_amount.UseCustomCellFormat = False
        Me.dgc_debit_amount.Width = 101
        '
        'dgc_credit_amount
        '
        Me.dgc_credit_amount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgc_credit_amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.dgc_credit_amount.Format = "###,###,##0.00"
        Me.dgc_credit_amount.FormatInfo = Nothing
        Me.dgc_credit_amount.HeaderText = "Créditoi"
        Me.dgc_credit_amount.ImageList = Nothing
        Me.dgc_credit_amount.isReadOnly = False
        Me.dgc_credit_amount.MappingName = "credit_amount"
        Me.dgc_credit_amount.MaxLength = 32767
        Me.dgc_credit_amount.TabStop = True
        Me.dgc_credit_amount.UseCustomCellFormat = False
        Me.dgc_credit_amount.Width = 101
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(104, 515)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(424, 20)
        Me.Label7.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(8, 515)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Nombre Cuenta:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDiferencia
        '
        Me.lblDiferencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiferencia.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblDiferencia.Location = New System.Drawing.Point(632, 515)
        Me.lblDiferencia.Name = "lblDiferencia"
        Me.lblDiferencia.Size = New System.Drawing.Size(104, 20)
        Me.lblDiferencia.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(560, 515)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Diferencia:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'i_cbdocs01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(744, 566)
        Me.Controls.Add(Me.xlk_acct_no)
        Me.Controls.Add(Me.xlk_depto_code)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblDiferencia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.KeyPreview = True
        Me.Name = "i_cbdocs01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Libro de Banco"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbdocsm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbdocsd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub i_cgjourm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            oParamValidar = New SGT.Administracion.Entidades.Permission.ParametrosValidar
            oAutorizar = New SGT.Administracion.Entidades.Permission

            LibXGrid1.footerOperations.add("debit_amount", "sum(debit_amount)")
            LibXGrid1.footerOperations.add("credit_amount", "sum(credit_amount)")
            ''LibXGrid1.footerOperations.add("acct_name", "sum(debit_amount)-sum(credit_amount)")

            oAnoFiscal = New SGT.Contabilidad.Entidades.AnoFiscal

            'oDocumento = New SGT.Contabilidad.Entidades.Documentos
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterLoadDetail(ByVal sender As Object, ByVal e As LibX.XbeforeLoadDetailEventArgs) Handles LibXConnector1.AfterLoadDetail
        Try

            For Each oRow As DataRow In DataSet1.Tables("cbdocsd").Rows
                If oRow!debit_credit = 1 Then
                    oRow!debit_amount = oRow!amount
                End If

                If oRow!debit_credit = -1 Then
                    oRow!credit_amount = oRow!amount
                End If
            Next

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingDetailRow
        Try

            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then

                '// DEBITO
                If Val(e.UpdatingArgs.Row!debit_amount.ToString) > 0 Then
                    e.UpdatingArgs.Row!amount = e.UpdatingArgs.Row!debit_amount
                    e.UpdatingArgs.Row!debit_credit = 1
                End If

                '//CREDITO
                If Val(e.UpdatingArgs.Row!credit_amount.ToString) > 0 Then
                    e.UpdatingArgs.Row!debit_credit = -1
                    e.UpdatingArgs.Row!amount = e.UpdatingArgs.Row!credit_amount
                End If
                If Val(e.UpdatingArgs.Row!credit_amount.ToString) = 0 And Val(e.UpdatingArgs.Row!debit_amount.ToString) = 0 Then
                    e.UpdatingArgs.Row!debit_credit = 1
                    e.UpdatingArgs.Row!amount = 0
                End If
            End If
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                If LibX.IsNull(e.UpdatingArgs.Row!acct_no) Then
                    e.UpdatingArgs.Status = UpdateStatus.SkipAllRemainingRows
                End If
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)
        End Try

    End Sub
    Private Sub SetFocusToGrid()
        Try
            If LibXGrid1.CurrentRowIndex > 0 _
            AndAlso LibXGrid1.GetValue(LibXGrid1.currentRowNum, Me.dgc_acct_no) = "" Then
                ''LibXGridDetalle.CurrentRowIndex = IIf(LibXGridDetalle.currentRowNum <= 0, 0, LibXGridDetalle.currentRowNum - 1)
                LibXGrid1.BeginEdit(dgc_acct_no, LibXGrid1.CurrentRowIndex)
            End If

            If LibXGrid1.getCurrentGridView.Count <= 0 Then
                LibXGrid1.Focus(2, 0)
            Else
                LibXGrid1.Focus(LibXGrid1.CurrentRowIndex, 1)
                LibXGrid1.BeginEdit(dgc_acct_no, 1)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
        Try
            If LibXConnector1.IsDataEditing = True Then
                If e.cell = dgc_tran_descr.Column Then
                    ''If LibXGrid1.GetValue(e.row, dgc_credit_amount).ToString.Trim <> "" Then
                    ''    SendKeys.Send("{TAB}")
                    ''End If
                End If

                Dim CurrentIndex As Integer = LibXGrid1.CurrentRowIndex
                If CurrentIndex = 0 Then
                    Me.dgc_acct_no.ReadOnly = True
                    Me.xdb_depto.ReadOnly = True
                    Me.dgc_credit_amount.ReadOnly = True
                    Me.dgc_debit_amount.ReadOnly = True
                    Me.dgc_tran_descr.ReadOnly = True
                    Me.xlk_acct_no.ShowLookup = False
                Else
                    Me.dgc_acct_no.ReadOnly = False
                    Me.xdb_depto.ReadOnly = True
                    Me.dgc_credit_amount.ReadOnly = False
                    Me.dgc_debit_amount.ReadOnly = False
                    Me.dgc_tran_descr.ReadOnly = False
                    Me.xlk_acct_no.ShowLookup = True
                End If

                If LibXGrid1.GetValue(e.row, dgc_acct_no) = "" Then
                    LibXGrid1.Focus(e.row, 0)
                    Exit Sub
                End If

                ''If LibXGrid1.GetValue(e.row, dgc_acct_no).ToString.Trim = "1120102" Then
                ''    If LibXGrid1.getCurrentGridView.Count > 0 Then
                ''        Me.dgc_acct_no.ReadOnly = True
                ''        Me.dgc_credit_amount.ReadOnly = True
                ''        Me.dgc_debit_amount.ReadOnly = True
                ''        Me.dgc_tran_descr.ReadOnly = True
                ''    End If
                ''    ''SetFocusToGrid()
                ''End If

                ''1120102:
                ''1120101:
                ''1120202:
                ''1120201:
                ''1120103:

                ''If IsNumeric(e.value.ToString.Trim) Then
                ''    If e.cell = dgc_debit_amount.Column Then
                ''        SendKeys.Send("{TAB}")
                ''    End If

                ''    If e.cell = dgc_credit_amount.Column Then
                ''        SendKeys.Send("{TAB}")
                ''    End If
                ''End If

                ''BalancearEntrada()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_SettingDefaultqueryValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultQueryValues) Handles LibXConnector1.SettingDefaultqueryValues
        Try
            xcbo_doc_status.currValue = 2

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try
            LibXConnector1.CurrentDataRow!doc_date = LibX.Data.Manager.GetScalar("select getdate()")
            Me.xtxsuc_code.Text = FindSucursal()
            Me.LibXLookup1.ExecuteFind()

            BuscarPeriodo(LibXConnector1.CurrentDataRow!doc_date)

        Catch ex As Exception
            LibX.Log.Add(ex)
        Finally

        End Try
    End Sub

    Private Function FindSucursal() As Integer
        Dim oSucursal As Integer
        Dim SelectStmt As String

        SelectStmt = "select suc_code from cgsucursal where suc_default = 1 "

        oSucursal = LibX.Data.Manager.GetScalar(SelectStmt)

        Return oSucursal

    End Function

    Private Sub BuscarPeriodo(ByVal pDate As DateTime)
        Try
            oPeriodo = oAnoFiscal.BuscarPeriodoPorFecha(pDate)

            If Not oPeriodo Is Nothing Then
                lblYear.Text = oPeriodo.year.ToString
                lblNumber.Text = oPeriodo.Number.ToString
            Else
                lblYear.Text = Year(Me.xdt_doc_date.Text)
                lblNumber.Text = Month(Me.xdt_doc_date.Text)
            End If

        Catch ex As Exception
            Throw ex

        Finally
            oPeriodo = Nothing
        End Try
    End Sub
    Private Function BalancearEntrada() As Decimal
        Dim TotalDebito As Decimal = 0
        Dim TotalCredito As Decimal = 0
        Dim Diferencia As Decimal = 0
        Try
            LibXGrid1.refreshFooter()
            TotalDebito = Val(LibXGrid1.GetFooterValue(dgc_debit_amount).ToString.Trim)
            TotalCredito = Val(LibXGrid1.GetFooterValue(dgc_credit_amount).ToString.Trim)

            Diferencia = TotalDebito - TotalCredito

            lblDiferencia.Text = Format("###,###,##0.00", Diferencia)

            Return Diferencia

        Catch ex As Exception
            Throw
        End Try

    End Function

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim oPeriodo As SGT.Contabilidad.Entidades.Periodo
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert _
          Or e.UpdatingArgs.StatementType = StatementType.Update Then
                If BalancearEntrada() <> 0 Then
                    Throw New ApplicationException("Entrada no balanceada")
                End If

                '// Datos
                If LibX.IsNull(e.UpdatingArgs.Row!doc_date) Then e.UpdatingArgs.Row!paym_date = LibX.Data.Manager.Connection.GetDate
                If LibXConnector1.CurrentDataRow!tran_type <> "SOL" Then
                    e.UpdatingArgs.Row!doc_status = 1
                Else
                    e.UpdatingArgs.Row!doc_status = 2
                End If

                oPeriodo = oAnoFiscal.BuscarPeriodoPorFecha(e.UpdatingArgs.Row!doc_date)
                If Not oPeriodo Is Nothing Then
                    e.UpdatingArgs.Row!perdr_year = Year(e.UpdatingArgs.Row!doc_date)
                    e.UpdatingArgs.Row!perdr_num = Month(e.UpdatingArgs.Row!doc_date)
                End If
            End If

            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                If oTransacion.AutoNumerable = True And Me.xtxt_doc_numer.Text = "" Then
                    e.UpdatingArgs.Row!doc_number = oTransacion.GenerateNumber(e.UpdatingArgs.Row!tran_type, e.UpdatingArgs.Row!chequera)
                End If
                e.UpdatingArgs.Row!cbm_impreso = 0
                e.UpdatingArgs.Row!date_created = LibX.Data.Manager.GetScalar("select getdate()")
                If LibX.IsNull(e.UpdatingArgs.Row!doc_number) Then
                    xtxt_amount.Focus()
                    Throw New ApplicationException("Debe especificar el numero de documento")
                End If
            End If

            If Val(xtxt_amount.Text) = 0 Then
                e.UpdatingArgs.Row!doc_status = 0
            End If

            ''If e.UpdatingArgs.StatementType = StatementType.Delete Then
            ''If e.UpdatingArgs.Row.Item("doc_status", DataRowVersion.Original) = 0 Then
            ''    e.UpdatingArgs.Status = UpdateStatus.SkipAllRemainingRows
            ''    '''AnularDocumento()
            ''End If
            ''End If

            ''If LibX.Data.Manager.Connection.IsIntransaction = True Then
            ''    LibX.Data.Manager.Connection.CommitTransaction()
            ''End If

        Catch ex As Exception
            LibX.Log.Add(ex)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
        End Try
    End Sub

    Private Sub xlk_chequera_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_chequera.AfterSetValues
        Try

            If e.dataFound = True Then
                oChequera = New Chequera(e.row!chequera)
                lblbalance.Text = Format(e.row!balance_actual, "##,###,##0.00")
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub xtxt_amount_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_amount.Validating
        Try
            If Me.xtxt_chequera.Text <> "" Then
                oChequera = New Chequera(Me.xtxt_chequera.Text)
            End If
            If Val(Me.xtxt_chequera.Text) > 0 And (Me.xtxt_type_code.Text = "CHQ" Or Me.xtxt_type_code.Text = "DPT" Or Me.xtxt_type_code.Text = "SOL") Then
                oTransacion = New SGT.ControlBancario.Entidades.TipoDocumento(Me.xtxt_type_code.Text, Me.xtxt_chequera.Text)

                If Me.LibXGrid1.getCurrentGridView.Count <= 0 And Val(Me.xtxt_amount.Text) > 0 Then
                    If Me.xtxt_amount.Text = "" Then
                        Me.xtxt_amount.Text = 0.0
                    End If
                    cbdocsd.Rows.Add(cbdocsd.NewRow)
                    LibXGrid1.SetValue(0, dgc_acct_no, oChequera.CuentaContable)
                    LibXGrid1.SetValue(0, xdb_depto, 0)
                    LibXGrid1.SetValue(0, dgc_tran_descr, oChequera.Nombre)
                    LibXGrid1.SetValue(0, dgc_credit_amount, Me.xtxt_amount.Text)
                    LibXGrid1.SetValue(0, dgc_debit_amount, 0)
                Else
                    If Me.LibXGrid1.getCurrentGridView.Count >= 0 And Val(Me.xtxt_amount.Text) > 0 Then
                        cbdocsd.Rows.Add(cbdocsd.NewRow)
                        LibXGrid1.SetValue(0, dgc_credit_amount, Me.xtxt_amount.Text)
                    End If
                End If
            End If
            If Val(Me.xtxt_chequera.Text) > 0 And Me.xtxt_type_code.Text = "DEP" Then
                oTransacion = New SGT.ControlBancario.Entidades.TipoDocumento(Me.xtxt_type_code.Text, Me.xtxt_chequera.Text)

                If Me.LibXGrid1.getCurrentGridView.Count <= 0 Then
                    If Me.xtxt_amount.Text = "" Then
                        Me.xtxt_amount.Text = 0.0
                    End If
                    cbdocsd.Rows.Add(cbdocsd.NewRow)
                    LibXGrid1.SetValue(0, dgc_acct_no, oChequera.CuentaContable)
                    LibXGrid1.SetValue(0, xdb_depto, 0)
                    LibXGrid1.SetValue(0, dgc_tran_descr, oChequera.Nombre)
                    LibXGrid1.SetValue(0, dgc_debit_amount, Me.xtxt_amount.Text)

                    cbdocsd.Rows.Add(cbdocsd.NewRow)
                    Dim acct As String = "1110102"
                    LibXGrid1.SetValue(1, dgc_acct_no, acct)
                    LibXGrid1.SetValue(1, xdb_depto, 0)
                    LibXGrid1.SetValue(1, dgc_tran_descr, LibX.Data.Manager.GetScalar("select acct_name from cgacctm where acct_no = '" & acct & "'"))
                    LibXGrid1.SetValue(1, dgc_credit_amount, Me.xtxt_amount.Text)
                End If
            End If
            LibXGrid1.refreshFooter()

        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If Not e.row Is Nothing Then
                If Not LibX.IsNull(LibXConnector1.CurrentDataRow!conc_serial) Then
                    If LibXConnector1.CurrentDataRow!conc_serial > 0 Then
                        LibXConnector1.AllowDelete = False
                        LibXConnector1.AllowEdit = True
                    End If
                Else
                    If e.row!doc_status.ToString.Trim = 0 Then
                        LibXConnector1.AllowDelete = False
                        LibXConnector1.AllowEdit = False
                    Else
                        If Not LibX.IsNull(LibXConnector1.CurrentDataRow!doc_origen) Then
                            LibXConnector1.AllowDelete = True
                            LibXConnector1.AllowEdit = True
                        Else
                            LibXConnector1.AllowDelete = True
                            LibXConnector1.AllowEdit = True
                        End If
                    End If
                End If
                If xcbo_doc_status.SelectedValue = 0 Then
                    LibXConnector1.AllowDelete = False
                    LibXConnector1.AllowEdit = False
                Else
                    LibXConnector1.AllowDelete = True
                    LibXConnector1.AllowEdit = True
                End If
            End If
            BalancearEntrada()
            LibXNavigator1.UpdateState()

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Dim oPost As SGT.CXP.Posteos.PostDocument
        Dim oPostParam As SGT.CXP.Posteos.PostDocument.ParametrosAplicar
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim oParamAplicar As SGT.ControlBancario.Entidades.Chequera.ParametrosAplicar
        Try

            If e.Action = LibX.LibxConnectionActions.Cancel Then
                Action = 9
                btnCajaChica.Enabled = False
                If Not LibX.IsNull(LibXConnector1.CurrentDataRow!cbm_serial.ToString.Trim) Then
                    updCuentacxpAn(LibXConnector1.CurrentDataRow!cbm_serial.ToString.Trim)
                Else
                    If Not LibX.IsNull(LibXConnector1.CurrentDataRow!doc_number.ToString.Trim) Then
                        updCuentacxpAn(LibXConnector1.CurrentDataRow!doc_number.ToString.Trim)
                    End If
                End If
            End If
            If e.Action = LibX.LibxConnectionActions.Add Then
                btnCajaChica.Enabled = True
                Action = 5
            Else
                Action = 0
                btnCajaChica.Enabled = False
            End If
            If e.Action = LibX.LibxConnectionActions.Delete Then
                If Not LibX.IsNull(LibXConnector1.CurrentDataRow!conc_serial) Then
                    If LibXConnector1.CurrentDataRow!conc_serial > 0 Then
                        Throw New ApplicationException("No se puede anular documento conciliado!")
                    End If
                End If
            End If

            If e.Action = LibX.LibxConnectionActions.Edit Then
                If (LibXConnector1.CurrentDataRow!cbm_impreso = 1 Or LibXConnector1.CurrentDataRow!tran_type <> "CHQ") Then
                    ActivactionEdit()
                    SetFocusToGrid()
                Else
                    InactivactionEdit()
                    SetFocusToGrid()
                End If
            Else
                InactivactionEdit()
            End If
            If e.Action = LibX.LibxConnectionActions.Delete Then
                ''oParamValidar.AccessKey = "AK"
                ''oAutorizar.PermisosAutorizados.Remove("AK")

                ''If oAutorizar.isAutorization(oParamValidar) = False Then
                ''    e.Handled = True
                ''    Throw New ApplicationException("Autorización Invalida")
                ''Else
                ''e.Handled = True
                If MessageBox.Show("Seguro desea anular este documento?", "Anular Documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    Exit Sub
                End If
                AnularDocumento()
                Exit Sub
            End If
            ''End If

            ''    '    If LibXConnector1.CurrentDataRow!tran_type <> "SOL" Then
            ''    '        oPost = New SGT.CXP.Posteos.PostDocument
            ''    '        oPostParam = New SGT.CXP.Posteos.PostDocument.ParametrosAplicar

            ''    '        With oPostParam
            ''    '            .Serial = LibXConnector1.CurrentDataRow!doc_origen
            ''    '            .TipoDocumento = LibXConnector1.CurrentDataRow!tran_type
            ''    '            .UseTransaction = True
            ''    '        End With
            ''    '        oPost.Anular(oPostParam)

            ''    '        xUpdate = New LibX.Data.XUpdateStmt("cbdocsm")
            ''    '        xUpdate.FieldsSet("doc_status") = 0
            ''    '        xUpdate.Fields("cbm_serial") = LibXConnector1.CurrentDataRow!cbm_serial
            ''    '        xUpdate.Execute()
            ''    '        LibXConnector1.ExecuteFind("cbm_serial = " & LibXConnector1.CurrentDataRow!cbm_serial.ToString.Trim)

            ''    '        If LibX.IsNull(LibXConnector1.CurrentDataRow!doc_origen) = False Then
            ''    '            xUpdate = New LibX.Data.XUpdateStmt("cppaymm")
            ''    '            xUpdate.FieldsSet("paym_status") = 0
            ''    '            xUpdate.Fields("paym_serial") = LibXConnector1.CurrentDataRow!doc_origen
            ''    '            xUpdate.Execute()
            ''    '        End If

            ''    '        ''//Actualizar la chequera
            ''    '        oParamAplicar = New SGT.ControlBancario.Entidades.Chequera.ParametrosAplicar
            ''    '        oParamAplicar.Chequera = LibXConnector1.CurrentDataRow!chequera
            ''    '        oParamAplicar.Monto = Val(LibXConnector1.CurrentDataRow!amount)
            ''    '        oParamAplicar.TipoDocumento = LibXConnector1.CurrentDataRow!tran_type
            ''    '        oChequera.Aplicar(oParamAplicar)
            ''    '    Else
            ''    '        If Not LibX.IsNull(LibXConnector1.CurrentDataRow!doc_origen) Then
            ''    '            xUpdate = New LibX.Data.XUpdateStmt("cppaymm")
            ''    '            xUpdate.FieldsSet("paym_status") = 2
            ''    '            xUpdate.Fields("paym_serial") = Val(LibXConnector1.CurrentDataRow!doc_origen)
            ''    '            xUpdate.Execute()
            ''    '            If BorrarSolicitud(LibXConnector1.CurrentDataRow!cbm_serial) = True Then
            ''    '                LibXConnector1.ExecuteFind("cbm_serial = " & LibXConnector1.CurrentDataRow!cbm_serial.ToString.Trim)
            ''    '            End If
            ''    '        End If
            ''    '    End If
            ''    '    ''//buscar y reversar las facturas
            ''    '    updCuentacxpAn(LibXConnector1.CurrentDataRow!cbm_serial.ToString.Trim)
            ''    'End If

            ''    'If e.Action = LibX.LibxConnectionActions.Delete _
            ''    '  AndAlso LibX.IsNull(LibXConnector1.CurrentDataRow!doc_origen) Then
            ''    '    oParamValidar.AccessKey = "AK"
            ''    '    oAutorizar.PermisosAutorizados.Remove("AK")

            ''    '    If oAutorizar.isAutorization(oParamValidar) = False Then
            ''    '        e.Handled = True
            ''    '        Throw New ApplicationException("Autorización Invalida")
            ''    '    End If
            ''    '    xUpdate = New LibX.Data.XUpdateStmt("cbdocsm")
            ''    '    xUpdate.FieldsSet("doc_status") = 0
            ''    '    xUpdate.Fields("cbm_serial") = LibXConnector1.CurrentDataRow!cbm_serial
            ''    '    xUpdate.Execute()
            ''    '    ''//buscar y reversar las facturas
            ''    '    updCuentacxpAn(LibXConnector1.CurrentDataRow!cbm_serial.ToString.Trim)
            ''End If

            ''If LibXConnector1.HasRecords = True And LibXConnector1.IsDataEditing = True Then
            ''    If e.Action = LibX.LibxConnectionActions.Edit Then
            ''        Me.xtxt_amount.Enabled = False
            ''        Me.xtxt_chequera.Enabled = False
            ''        Me.xtxt_type_code.Enabled = False
            ''        Me.xtxt_doc_numer.Enabled = False
            ''        Me.xtxt_amount.Enabled = False
            ''        Me.xtxt_benef.Enabled = False
            ''        Me.xdt_doc_date.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
            ''        Me.TextBox4.Enabled = False
            ''        LibXGrid1.Focus(1, 0)
            ''    End If
            ''    Me.xtxt_amount.Enabled = True
            ''    Me.xtxt_chequera.Enabled = True
            ''    Me.xtxt_type_code.Enabled = True
            ''    Me.xtxt_doc_numer.Enabled = True
            ''    Me.xtxt_amount.Enabled = True
            ''    Me.xtxt_benef.Enabled = True
            ''    Me.xdt_doc_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
            ''    Me.TextBox4.Enabled = True
            ''End If
            ''If e.Action = LibX.LibxConnectionActions.Edit Then
            ''    Me.xtxt_doc_numer.Enabled = False
            ''    Me.xtxt_type_code.Enabled = False
            ''End If

            ''If e.Action = LibX.LibxConnectionActions.Add Or e.Action = LibX.LibxConnectionActions.Find Then
            ''    Me.xtxt_amount.Enabled = True
            ''    Me.xtxt_chequera.Enabled = True
            ''    Me.xtxt_type_code.Enabled = True
            ''    Me.xtxt_doc_numer.Enabled = True
            ''    Me.xtxt_amount.Enabled = True
            ''    Me.xtxt_benef.Enabled = True
            ''    Me.xdt_doc_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
            '    Me.TextBox4.Enabled = True
            ''End If
            If e.Action = LibX.LibxConnectionActions.Add Then
                If Me.xtxt_type_code.Text = "CHQ" Or Me.xtxt_type_code.Text = "SOL" Then
                    btnCajaChica.Enabled = True
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Dim ParametrosEmision As Documentos.ParametrosEmitir
        Dim xUpdate As LibX.Data.XUpdateStmt

        Try

            If e.AcceptedAction = LibX.LibxConnectionActions.Add _
            Or e.AcceptedAction = LibX.LibxConnectionActions.Edit Then
                ParametrosEmision = New Documentos.ParametrosEmitir

                With ParametrosEmision
                    .Serial = LibXConnector1.CurrentDataRow!cbm_serial
                    .Chequera = LibXConnector1.CurrentDataRow!chequera
                    .Fecha = LibXConnector1.CurrentDataRow!doc_date
                    .Monto = LibXConnector1.CurrentDataRow!amount
                    .Numero = LibXConnector1.CurrentDataRow!doc_number
                    .TipoDocumento = LibXConnector1.CurrentDataRow!tran_type
                End With
                If Val(Me.xcbo_doc_status.currValue.ToString.Trim) = 1 Then
                    updCuentacxp()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub XLK_tran_type_AfterSetValues(ByVal sender As System.Object, ByVal e As LibX.LookupValuesEventArgs) Handles XLK_tran_type.AfterSetValues
        Try
            If LibXConnector1.IsDataEditing = True And Action = 5 Then ''And LibXConnector1.HasRecords = True Then
                oTransacion = New SGT.ControlBancario.Entidades.TipoDocumento(e.row!tran_type, Me.xtxt_chequera.Text)
                If Val(Me.xtxt_doc_numer.Text) > 0 Then
                    If oTransacion.AutoNumerable = True Then
                        If Me.xtxt_doc_numer.Text <> "" Then
                            If Me.xtxt_doc_numer.Text > oTransacion.Numero Then
                                Throw New ApplicationException("No puede digitar un numero mayor que la secuencia del documento para esta chequera!")
                            End If
                        End If
                    End If
                    If oTransacion.NumberExiste(Me.xtxt_type_code.Text, Me.xtxt_chequera.Text, Me.xtxt_doc_numer.Text) = True Then
                        Me.xtxt_doc_numer.Text = ""
                        Throw New ApplicationException("Este Numero de Documento existe para esta chequera Verifique!")
                    End If
                End If
                If oTransacion.AutoNumerable = True Then
                    xtxt_doc_numer.Enabled = False
                    xtxt_doc_numer.TabStop = False
                    xtxt_doc_numer.BackColor = System.Drawing.SystemColors.Control
                Else
                    xtxt_doc_numer.Enabled = True
                    xtxt_doc_numer.TabStop = True
                    xtxt_doc_numer.BackColor = System.Drawing.SystemColors.Window
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub XLK_tran_type_BeforeExecuteQuery(ByVal sender As System.Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles XLK_tran_type.BeforeExecuteQuery
        Try
            If LibXConnector1.IsDataEditing = True Then
                If Me.xtxt_chequera.Text.Trim <> "" Then
                    e.aditionalWhere = " cgtrntpm.chequera = " & Me.xtxt_chequera.Text
                Else
                    Throw New ApplicationException("Debe especificar una chequera antes!")
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Dim SelecStmt As String
        Dim AxCrystalReport1 As LibX.ReportLib
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim Archivo As String = ""
        Dim SelectStmt As String

        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
                ''Me.Cursor = Cursors.WaitCursor

                SelectStmt = "select * from sgfprinter where print_default = 0 "
                oRowPrinter = LibX.Data.Manager.GetDataRow(SelectStmt)

                If LibXConnector1.CurrentDataRow!tran_type <> "CHQ" And LibXConnector1.CurrentDataRow!tran_type <> "SOL" And _
                 LibXConnector1.CurrentDataRow!doc_status = 2 Then
                    xUpdate = New LibX.Data.XUpdateStmt("cbdocsm")
                    xUpdate.FieldsSet("doc_status") = 1
                    xUpdate.Fields("cbm_serial") = Val(LibXConnector1.CurrentDataRow!cbm_serial)
                    xUpdate.Execute()
                    Me.xcbo_doc_status.currValue = 1

                    '// Aplicar en chequera
                    Dim oParamAplicar As SGT.ControlBancario.Entidades.Chequera.ParametrosAplicar
                    oParamAplicar = New SGT.ControlBancario.Entidades.Chequera.ParametrosAplicar

                    oParamAplicar.Chequera = LibXConnector1.CurrentDataRow!chequera
                    oParamAplicar.Monto = Val(LibXConnector1.CurrentDataRow!amount)
                    oParamAplicar.TipoDocumento = LibXConnector1.CurrentDataRow!tran_type
                    oChequera.Aplicar(oParamAplicar)
                End If

                If LibX.IsNull(LibXConnector1.CurrentDataRow!chequera) = False Then
                    Archivo = AsignarImpresion(LibXConnector1.CurrentDataRow!chequera)
                End If

                If LibXConnector1.CurrentDataRow!tran_type <> "CHQ" Then
                    AxCrystalReport1 = New LibX.ReportLib("CTB", "r_cbdocsol.rpt")
                Else
                    If Archivo = "" Then
                        AxCrystalReport1 = New LibX.ReportLib("CTB", "r_Cheques.rpt")
                    Else
                        AxCrystalReport1 = New LibX.ReportLib("CTB", Archivo)
                    End If
                End If

                With AxCrystalReport1
                    '// Recibir el SQL Query
                    .PrinterName = oRowPrinter!print_name.ToString
                    .RetrieveSQLQuery()
                    SelecStmt = .SQLQuery
                    SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, "cbdocsm.cbm_serial = " & LibXConnector1.CurrentDataRow!cbm_serial)
                    .SQLQuery = SelecStmt
                    '// Ejecutar el reporte
                    .Action = 1

                End With
                If Val(LibXConnector1.CurrentDataRow!cbm_impreso) = 0 Then
                    cHqImpreso(LibXConnector1.CurrentDataRow!cbm_serial)
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Function AsignarImpresion(ByVal IDChequera As Integer) As String
        Try
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
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Function
    Private Function BorrarSolicitud(ByVal cbmSerial As Integer) As Boolean
        Try
            Dim Xdelete As LibX.Data.XDeleteStmt
            Dim mXdelete As LibX.Data.XDeleteStmt

            Xdelete = New LibX.Data.XDeleteStmt("cbdocsd")
            Xdelete.Fields("cbm_serial") = cbmSerial.ToString.Trim
            Xdelete.Execute()

            mXdelete = New LibX.Data.XDeleteStmt("cbdocsm")
            mXdelete.Fields("cbm_serial") = cbmSerial.ToString.Trim
            mXdelete.Execute()

            Return True
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Function
    Private Sub xtxt_doc_numer_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_doc_numer.Validating
        Try

            If Me.xtxt_doc_numer.Text <> "" And LibXConnector1.IsDataEditing = True Then
                btnCajaChica.Enabled = True
            End If
            If Me.xtxt_type_code.Text <> "" And Me.xtxt_chequera.Text <> "" Then
                oTransacion = New SGT.ControlBancario.Entidades.TipoDocumento(Me.xtxt_type_code.Text, Me.xtxt_chequera.Text)

                If LibXConnector1.IsDataEditing = True And Action = 5 Then
                    If oTransacion.AutoNumerable = True Then
                        If Me.xtxt_doc_numer.Text <> "" Then
                            If Me.xtxt_doc_numer.Text > oTransacion.Numero Then
                                Throw New ApplicationException("No puede digitar un numero mayor que la secuencia del documento para esta chequera!")
                            End If
                        End If
                    End If

                    If Me.xtxt_doc_numer.Text = "" And oTransacion.AutoNumerable = False Then
                        Me.xtxt_doc_numer.Text = ""
                        Throw New ApplicationException("Debe Digitar el numero del documento!")
                    End If
                    If oTransacion.AutoNumerable = False Then
                        If oTransacion.NumberExiste(Me.xtxt_type_code.Text, Me.xtxt_chequera.Text, Me.xtxt_doc_numer.Text) = True Then
                            Throw New ApplicationException("Este Numero de Documento existe para esta chequera Verifique!")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid1.CurrentRowChanged
        Try
            Dim CurrentIndex As Integer
            CurrentIndex = LibXGrid1.CurrentRowIndex
            If CurrentIndex = 0 Then
                Me.dgc_acct_no.ReadOnly = True
                Me.xdb_depto.ReadOnly = True
                Me.dgc_credit_amount.ReadOnly = True
                Me.dgc_debit_amount.ReadOnly = True
                Me.dgc_tran_descr.ReadOnly = True
                Me.xlk_acct_no.ShowLookup = False
            Else
                Me.dgc_acct_no.ReadOnly = False
                Me.xdb_depto.ReadOnly = True
                Me.dgc_credit_amount.ReadOnly = False
                Me.dgc_debit_amount.ReadOnly = False
                Me.dgc_tran_descr.ReadOnly = False
                Me.xlk_acct_no.ShowLookup = True
            End If

            LibXGrid1.refreshFooter()

            If Val(LibXGrid1.GetFooterValue(dgc_debit_amount).ToString.Trim) > 0 And _
                        Val(LibXGrid1.GetFooterValue(dgc_credit_amount).ToString.Trim) > 0 Then
                BalancearEntrada()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub cbdocsd_RowDeleted(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles cbdocsd.RowDeleted
        Try
            If LibXConnector1.IsDataEditing = True Then
                LibXGrid1.Focus(LibXGrid1.currentRowNum, 0)
                LibXGrid1.refreshFooter()
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub xdt_doc_date_CurrentValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles xdt_doc_date.CurrentValueChanged
        If LibXConnector1.IsDataEditing = True Then
            If LibX.IsNull(xdt_doc_date.Value) = False Then
                BuscarPeriodo(xdt_doc_date.Value)
            End If
        End If
    End Sub
    Private Sub xdt_doc_date_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xdt_doc_date.Validating
        Try
            oPeriodo = New Periodo

            If LibXConnector1.IsDataEditing = True Then
                If LibX.IsNull(xdt_doc_date.Value) = True Then
                    Exit Sub
                End If

                If oAnoFiscal.BuscarPeriodoPorFecha(xdt_doc_date.Value) Is Nothing Then
                    xdt_doc_date.Focus()
                    Throw (New ApplicationException("No hay periodo definido para esta fecha, Verifique!"))
                Else
                    oPeriodo = oAnoFiscal.BuscarPeriodoPorFecha(xdt_doc_date.Value)
                End If

                If oPeriodo.isOpen = False Then
                    xdt_doc_date.Focus()
                    Throw (New ApplicationException("El periodo para fecha establecida establecida esta cerrado, Verifique!"))
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub
    Private Function cHqImpreso(ByVal cbmSerial As Integer)
        Dim xUpdate As LibX.Data.XUpdateStmt
        Try

            xUpdate = New LibX.Data.XUpdateStmt("cbdocsm")
            xUpdate.FieldsSet("cbm_impreso") = 1
            xUpdate.Fields("cbm_serial") = cbmSerial
            xUpdate.Execute()
            xUpdate.Dispose()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Function

    Private Function updChequera(ByVal sChequera As Integer, ByVal sAmount As Decimal)
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim Balance As Decimal
        Try
            SelectStmt = String.Concat("select balance_actual from cpchequera ", _
                              " where chequera = ", sChequera.ToString)

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Or oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No se encontro la chequera")
            End If

            Balance = Val(oTable.Rows(0)!balance_actual.ToString.Trim)
            Balance = Balance + sAmount

            xUpdate = New LibX.Data.XUpdateStmt("cpchequera")
            xUpdate.FieldsSet("balance_actual") = Balance
            xUpdate.Fields("chequera") = sChequera
            xUpdate.Execute()
            xUpdate.Dispose()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCajaChica.Click
        Dim oParam As LibX.LibxPrgParams
        Dim FCT As New c_cpdocs05
        Dim CK As New c_cpdocs05.FacturaCK
        Try
            If Val(xtxt_chequera.Text) = 0 Then
                xtxt_chequera.Focus()
                Throw New ApplicationException("Debe indicar la chequera")
            End If
            If xtxt_type_code.Text = "" Then
                xtxt_type_code.Focus()
                Throw New ApplicationException("Debe indicar el tipo de documento")
            End If

            oParam = New LibX.LibxPrgParams

            FCT = New c_cpdocs05
            CK = New c_cpdocs05.FacturaCK

            If LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If


            With oParam
                .IsFromOther = True
                .AllowDelete = False
                .AllowEdit = True
                .AllowNew = False
                .AllowPrint = False
                .AllowQuery = False
                If Not LibX.IsNull(xtxt_doc_numer.Text) Then
                    .Datos.Add("serial", Val(xtxt_doc_numer.Text))
                Else
                    .Datos.Add("serial", 99999)
                End If
                .WhereToExecute = " cpinvcem.invce_status = 4 "
                LibX.App.CurrentPrgParams = oParam
                FCT.FacturaSelected = CK

                If FCT.ShowDialog(Me) = DialogResult.Yes Then
                    Acct_amt = CK.sMonto
                    Mcodifica = CK.sValor
                    Me.TextBox4.Text = CK.sConcepto
                    Me.xtxt_benef.Text = CK.Beneficiario
                    Cuenta = CK.AcctNo
                    mItbisRetenido = CK.mRetIbtis.ToString.Trim
                    If mItbisRetenido > 0 Then
                        CuentaItbis = CK.acct_Itbis.ToString.Trim
                    End If
                    mIsrRetenido = CK.mRestIsr.ToString.Trim
                    If mIsrRetenido > 0 Then
                        CuentaIsr = CK.acct_Isr.ToString.Trim
                    End If
                End If
            End With

            ''xtxt_amount.Enabled = False
            Me.xtxt_amount.Text = Format(Acct_amt, "##,###,##0.00")
            sCodifica()

            If Val(Acct_amt) > 0 Then
                sCodificaC()
            End If
            xtxt_benef.Focus()

            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If
        Catch ex As Exception
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If

            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Function sCodifica()
        Try
            If Me.xtxt_chequera.Text <> "" Then
                oChequera = New Chequera(Me.xtxt_chequera.Text)
            End If
            If Me.xtxt_chequera.Text <> "" And Me.xtxt_type_code.Text <> "" Then
                oTransacion = New SGT.ControlBancario.Entidades.TipoDocumento(Me.xtxt_type_code.Text, Me.xtxt_chequera.Text)

                cbdocsd.Rows.Add(cbdocsd.NewRow)
                LibXGrid1.SetValue(0, dgc_acct_no, oChequera.CuentaContable)
                LibXGrid1.SetValue(0, xdb_depto, 0)
                LibXGrid1.SetValue(0, dgc_tran_descr, oChequera.Nombre)
                LibXGrid1.SetValue(0, dgc_credit_amount, Acct_amt)
                LibXGrid1.SetValue(0, dgc_debit_amount, 0)
            End If

            LibXGrid1.refreshFooter()
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Function
    Private Function sCodificaC()
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim cntCuenta As Integer = 1
        Try

            If mItbisRetenido > 0 Then
                SelectStmt = "select * from cgacctm where acct_no = '" & CuentaItbis & "'"
                oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

                cbdocsd.Rows.Add(cbdocsd.NewRow)
                LibXGrid1.SetValue(cntCuenta, dgc_acct_no, oTable.Rows(0)!acct_no)
                LibXGrid1.SetValue(cntCuenta, xdb_depto, 0)
                LibXGrid1.SetValue(cntCuenta, dgc_tran_descr, oTable.Rows(0)!acct_name)
                LibXGrid1.SetValue(cntCuenta, dgc_credit_amount, mItbisRetenido)
                LibXGrid1.SetValue(cntCuenta, dgc_debit_amount, 0)
                cntCuenta = cntCuenta + 1
                LibXGrid1.refreshFooter()
            End If

            If mIsrRetenido > 0 Then
                SelectStmt = "select * from cgacctm where acct_no = '" & CuentaIsr & "'"
                oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

                cbdocsd.Rows.Add(cbdocsd.NewRow)
                LibXGrid1.SetValue(cntCuenta, dgc_acct_no, oTable.Rows(0)!acct_no)
                LibXGrid1.SetValue(cntCuenta, xdb_depto, 0)
                LibXGrid1.SetValue(cntCuenta, dgc_tran_descr, oTable.Rows(0)!acct_name)
                LibXGrid1.SetValue(cntCuenta, dgc_credit_amount, mIsrRetenido)
                LibXGrid1.SetValue(cntCuenta, dgc_debit_amount, 0)
                cntCuenta = cntCuenta + 1
                LibXGrid1.refreshFooter()
            End If

            SelectStmt = "select * from cgacctm where acct_no = '" & Cuenta & "'"
            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            cbdocsd.Rows.Add(cbdocsd.NewRow)
            LibXGrid1.SetValue(cntCuenta, dgc_acct_no, oTable.Rows(0)!acct_no)
            LibXGrid1.SetValue(cntCuenta, xdb_depto, 0)
            LibXGrid1.SetValue(cntCuenta, dgc_tran_descr, oTable.Rows(0)!acct_name)
            LibXGrid1.SetValue(cntCuenta, dgc_debit_amount, Mcodifica)
            LibXGrid1.SetValue(cntCuenta, dgc_credit_amount, 0)

            LibXGrid1.refreshFooter()

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Function

    Private Function updCuentacxp()
        Dim oTable As DataTable
        Dim xUpdate As LibX.Data.XUpdateStmt
        Try
            oTable = LibX.Data.Manager.GetDataTable("select * from cpinvcem where (cbm_serial = " & Val(xtxt_doc_numer.Text) & " or cbm_serial = 99999)")

            If oTable Is Nothing Then
                Throw New ApplicationException("Error en operacion")
            End If

            For Each oRow As DataRow In oTable.Rows
                xUpdate = New LibX.Data.XUpdateStmt("cpinvcem")
                If oRow!balance <= 0 Then
                    xUpdate.FieldsSet("invce_status") = 3
                End If
                xUpdate.FieldsSet("cbm_serial") = LibXConnector1.CurrentDataRow!cbm_serial.ToString.Trim
                xUpdate.Fields("invce_serial") = oRow!invce_serial
                xUpdate.Execute()
            Next

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Function
    Private Sub AnularDocumento()
        Dim oPost As SGT.CXP.Posteos.PostDocument
        Dim oPostParam As SGT.CXP.Posteos.PostDocument.ParametrosAplicar
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim oParamAplicar As SGT.ControlBancario.Entidades.Chequera.ParametrosAplicar
        Try
            oParamValidar.AccessKey = "AK"
            oAutorizar.PermisosAutorizados.Remove("AK")

            If oAutorizar.isAutorization(oParamValidar) = False Then
                Throw New ApplicationException("Autorización Invalida")
            End If

            If LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            If Not LibX.IsNull(LibXConnector1.CurrentDataRow!doc_origen) _
           AndAlso LibXConnector1.CurrentDataRow!doc_status.ToString.Trim <> 0 Then
                If LibXConnector1.CurrentDataRow!tran_type <> "SOL" Then
                    oPost = New SGT.CXP.Posteos.PostDocument
                    oPostParam = New SGT.CXP.Posteos.PostDocument.ParametrosAplicar

                    With oPostParam
                        .Serial = LibXConnector1.CurrentDataRow!doc_origen
                        .TipoDocumento = LibXConnector1.CurrentDataRow!tran_type
                        .UseTransaction = True
                    End With

                    oPost.Anular(oPostParam)

                    xUpdate = New LibX.Data.XUpdateStmt("cbdocsm")
                    xUpdate.FieldsSet("doc_status") = 0
                    xUpdate.FieldsSet("amount") = 0
                    xUpdate.Fields("cbm_serial") = LibXConnector1.CurrentDataRow!cbm_serial
                    xUpdate.Execute()

                    xUpdate = New LibX.Data.XUpdateStmt("cbdocsd")
                    xUpdate.FieldsSet("amount") = 0
                    xUpdate.Fields("cbm_serial") = LibXConnector1.CurrentDataRow!cbm_serial
                    xUpdate.Execute()

                    LibXConnector1.ExecuteFind("cbm_serial = " & LibXConnector1.CurrentDataRow!cbm_serial.ToString.Trim)

                    If LibX.IsNull(LibXConnector1.CurrentDataRow!doc_origen) = False Then
                        xUpdate = New LibX.Data.XUpdateStmt("cppaymm")
                        xUpdate.FieldsSet("paym_status") = 0
                        xUpdate.Fields("paym_serial") = LibXConnector1.CurrentDataRow!doc_origen
                        xUpdate.Execute()
                    End If

                    ''//Actualizar la chequera
                    oParamAplicar = New SGT.ControlBancario.Entidades.Chequera.ParametrosAplicar
                    oParamAplicar.Chequera = LibXConnector1.CurrentDataRow!chequera
                    oParamAplicar.Monto = Val(LibXConnector1.CurrentDataRow!amount)
                    oParamAplicar.TipoDocumento = LibXConnector1.CurrentDataRow!tran_type
                    oChequera.Aplicar(oParamAplicar)
                Else
                    If Not LibX.IsNull(LibXConnector1.CurrentDataRow!doc_origen) Then
                        xUpdate = New LibX.Data.XUpdateStmt("cppaymm")
                        xUpdate.FieldsSet("paym_status") = 2
                        xUpdate.Fields("paym_serial") = Val(LibXConnector1.CurrentDataRow!doc_origen)
                        xUpdate.Execute()
                        If BorrarSolicitud(LibXConnector1.CurrentDataRow!cbm_serial) = True Then
                            LibXConnector1.ExecuteFind("cbm_serial = " & LibXConnector1.CurrentDataRow!cbm_serial.ToString.Trim)
                        End If
                    End If
                End If
            Else
                If LibX.IsNull(LibXConnector1.CurrentDataRow!doc_origen) Then
                    xUpdate = New LibX.Data.XUpdateStmt("cbdocsm")
                    xUpdate.FieldsSet("doc_status") = 0
                    xUpdate.FieldsSet("amount") = 0
                    xUpdate.FieldsSet("doc_concept") = "ANULADO"
                    xUpdate.Fields("cbm_serial") = LibXConnector1.CurrentDataRow!cbm_serial
                    xUpdate.Execute()

                    xUpdate = New LibX.Data.XUpdateStmt("cbdocsd")
                    xUpdate.FieldsSet("amount") = 0
                    xUpdate.Fields("cbm_serial") = LibXConnector1.CurrentDataRow!cbm_serial
                    xUpdate.Execute()
                End If
            End If
            ''//buscar y reversar las facturas
            updCuentacxpAn(LibXConnector1.CurrentDataRow!cbm_serial.ToString.Trim)

            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If
            LibXNavigator1.UpdateState()

        Catch ex As Exception
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Function updCuentacxpAn(ByVal mSerial As Integer)
        Dim oTable As DataTable
        Dim xUpdate As LibX.Data.XUpdateStmt
        Try
            If LibX.IsNull(mSerial) AndAlso mSerial = 0 Then
                Exit Function
            End If
            oTable = LibX.Data.Manager.GetDataTable("select * from cpinvcem where cbm_serial = " & mSerial)

            If oTable Is Nothing Then
                Throw New ApplicationException("Error en operacion")
            End If

            For Each oRow As DataRow In oTable.Rows
                xUpdate = New LibX.Data.XUpdateStmt("cpinvcem")
                xUpdate.FieldsSet("invce_status") = 4
                xUpdate.FieldsSet("balance") = oRow!balance + oRow!amt
                xUpdate.FieldsSet("cbm_serial") = 0
                xUpdate.Fields("invce_serial") = oRow!invce_serial
                xUpdate.Execute()
            Next

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Function
    Private Function ActivactionEdit()
        Me.xtxt_amount.Enabled = False
        Me.xtxt_chequera.Enabled = False
        Me.xtxt_type_code.Enabled = False
        Me.xtxt_doc_numer.Enabled = False
        Me.xtxt_amount.Enabled = False
        Me.xtxt_benef.Enabled = False
        Me.xdt_doc_date.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox4.Enabled = False
        LibXGrid1.Focus(1, 0)
    End Function
    Private Function InactivactionEdit()
        Me.xtxt_amount.Enabled = True
        Me.xtxt_chequera.Enabled = True
        Me.xtxt_type_code.Enabled = True
        Me.xtxt_doc_numer.Enabled = True
        Me.xtxt_amount.Enabled = True
        Me.xtxt_benef.Enabled = True
        Me.xdt_doc_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.Enabled = True
    End Function
End Class
