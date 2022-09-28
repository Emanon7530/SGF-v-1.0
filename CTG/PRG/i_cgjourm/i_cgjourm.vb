Imports SGT.Contabilidad.Entidades
Public Class i_cgjourm
    Inherits System.Windows.Forms.Form
    Dim oDocumento As SGT.Contabilidad.Entidades.Documentos
    Enum DocumentoStatusEnum
        Anulada
        Aplicada
        Pendiente
        Reversada
    End Enum
    Dim oPeriodo As Periodo
    Dim oAnoFiscal As AnoFiscal
    Dim Transf As Boolean = False

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
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As LibX.XTextBox
    Friend WithEvents TextBox3 As LibX.XTextBox
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents LibXDbSourceTable4 As LibX.LibXDbSourceTable
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgc_acct_no As LibX.XDataGridTextButtonColumn
    Friend WithEvents dgc_tran_descr As LibX.XEditTextBoxColumn
    Friend WithEvents dgc_debit_amount As LibX.XEditTextBoxColumn
    Friend WithEvents dgc_credit_amount As LibX.XEditTextBoxColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblDateCreated As System.Windows.Forms.Label
    Friend WithEvents xcbo_orign_code As LibX.LibXCombo
    Friend WithEvents xcbo_tran_status As LibX.LibXCombo
    Friend WithEvents lblDiferencia As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents xdb_depto As LibX.XDataGridTextButtonColumn
    Friend WithEvents xlk_depto_code As LibX.LibXLookup
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents cgtranrd As System.Data.DataTable
    Friend WithEvents xlk_acct_no As LibX.LibXLookup
    Friend WithEvents xtxttran_type As LibX.XTextBox
    Friend WithEvents xdt_tran_date As LibX.LibxDateTimePicker
    Friend WithEvents cgtranrm As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents lblYear As LibX.XTextBox
    Friend WithEvents lblNumber As LibX.XTextBox
    Friend WithEvents lblType_name As System.Windows.Forms.Label
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents xtxsuc_name As System.Windows.Forms.Label
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents btnTransf As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(i_cgjourm))
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.cgtranrd = New System.Data.DataTable
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.cgtranrm = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable4 = New LibX.LibXDbSourceTable
        Me.xtxttran_type = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.XTextBox1 = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.xtxsuc_name = New System.Windows.Forms.Label
        Me.lblNumber = New LibX.XTextBox
        Me.lblYear = New LibX.XTextBox
        Me.lblDateCreated = New System.Windows.Forms.Label
        Me.xcbo_orign_code = New LibX.LibXCombo
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New LibX.XTextBox
        Me.TextBox3 = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.lblType_name = New System.Windows.Forms.Label
        Me.xcbo_tran_status = New LibX.LibXCombo
        Me.xdt_tran_date = New LibX.LibxDateTimePicker
        Me.btnTransf = New System.Windows.Forms.Button
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.dgc_acct_no = New LibX.XDataGridTextButtonColumn
        Me.xlk_acct_no = New LibX.LibXLookup
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
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
        CType(Me.cgtranrd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cgtranrm, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXDbSourceTable1.SerialColumnName = "tranr_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cgtranrm"
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
        Me.LibXDbSourceTable2.FillOnRowChange = True
        Me.LibXDbSourceTable2.HeaderIsOnGrid = False
        Me.LibXDbSourceTable2.InnerJon = True
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"tranr_serial=tranr_serial"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select cgtranrd.*,cgacctm.acct_name ", " from cgtranrd inner join cgacctm", "on cgtranrd.acct_no = cgacctm.acct_no"}
        Me.LibXDbSourceTable2.TableName = "cgtranrd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxttran_type
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxttran_type
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxttran_type
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(816, 24)
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
        Me.LibXConnector1.DataMember = "cgtranrm"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable3, Me.LibXDbSourceTable4})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.cgtranrd, Me.cgtranrm})
        '
        'cgtranrd
        '
        Me.cgtranrd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn23, Me.DataColumn25})
        Me.cgtranrd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"tranr_serial", "line_no", "acct_no"}, True)})
        Me.cgtranrd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn8, Me.DataColumn10, Me.DataColumn9}
        Me.cgtranrd.TableName = "cgtranrd"
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "tranr_serial"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "acct_no"
        Me.DataColumn9.MaxLength = 20
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "line_no"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "tranr_detail"
        Me.DataColumn11.MaxLength = 40
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "dept_code"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "debit_credit"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "amount"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "acct_name"
        Me.DataColumn15.MaxLength = 60
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "debit_amount"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "credit_amount"
        Me.DataColumn23.DataType = GetType(System.Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "suc_code"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'cgtranrm
        '
        Me.cgtranrm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn24})
        Me.cgtranrm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"tranr_serial"}, True)})
        Me.cgtranrm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.cgtranrm.TableName = "cgtranrm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "tranr_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "tran_type"
        Me.DataColumn2.MaxLength = 3
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "perdr_year"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "perdr_num"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "orign_code"
        Me.DataColumn5.MaxLength = 3
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "tran_number"
        Me.DataColumn6.MaxLength = 10
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "tran_date"
        Me.DataColumn7.DataType = GetType(System.DateTime)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "date_created"
        Me.DataColumn17.DataType = GetType(System.DateTime)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "tran_descr"
        Me.DataColumn18.MaxLength = 80
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "tran_status"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "userid"
        Me.DataColumn20.MaxLength = 18
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "tran_reverse"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "tran_refer"
        Me.DataColumn22.MaxLength = 60
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.ColumnName = "suc_code"
        Me.DataColumn24.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable3.SerialColumnName = "tranr_serial"
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = Nothing
        Me.LibXDbSourceTable3.TableName = "cgtranrm"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'LibXDbSourceTable4
        '
        Me.LibXDbSourceTable4.AllowDelete = True
        Me.LibXDbSourceTable4.AllowEdit = True
        Me.LibXDbSourceTable4.AllowNew = True
        Me.LibXDbSourceTable4.AutoIncrementSerial = False
        Me.LibXDbSourceTable4.CustomDbUpdate = False
        Me.LibXDbSourceTable4.DeleteOrder = 0
        Me.LibXDbSourceTable4.FillOnQuery = True
        Me.LibXDbSourceTable4.FillOnRowChange = True
        Me.LibXDbSourceTable4.HeaderIsOnGrid = False
        Me.LibXDbSourceTable4.InnerJon = True
        Me.LibXDbSourceTable4.InsertOrder = 0
        Me.LibXDbSourceTable4.IsDetail = True
        Me.LibXDbSourceTable4.KeyFields = Nothing
        Me.LibXDbSourceTable4.LineColName = Nothing
        Me.LibXDbSourceTable4.MasterDetailRelation = New String() {"tranr_serial=tranr_serial", "suc_code=suc_code"}
        Me.LibXDbSourceTable4.MasterTableName = Nothing
        Me.LibXDbSourceTable4.SerialColumnName = Nothing
        Me.LibXDbSourceTable4.Sort = Nothing
        Me.LibXDbSourceTable4.Source = New String() {"select cgtranrd.*,cgacctm.acct_name ", "from cgtranrd", "inner join cgacctm ", "on cgacctm.acct_no = cgtranrd.acct_no", "order by cgtranrd.debit_credit DESC"}
        Me.LibXDbSourceTable4.TableName = "cgtranrd"
        Me.LibXDbSourceTable4.UpdateOrder = 0
        Me.LibXDbSourceTable4.UseRowRetrieve = False
        '
        'xtxttran_type
        '
        Me.xtxttran_type.AcceptsReturn = True
        Me.xtxttran_type.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.tran_type"))
        Me.xtxttran_type.EditInitialValue = Nothing
        Me.xtxttran_type.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxttran_type.FieldDescription = ""
        Me.xtxttran_type.FindInitialValue = Nothing
        Me.xtxttran_type.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxttran_type.IgnoreRequiered = False
        Me.xtxttran_type.Location = New System.Drawing.Point(128, 64)
        Me.xtxttran_type.Name = "xtxttran_type"
        Me.xtxttran_type.NewInitialValue = "ED"
        Me.xtxttran_type.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxttran_type.Requiered = False
        Me.xtxttran_type.Size = New System.Drawing.Size(48, 20)
        Me.xtxttran_type.StatusBarPanelDescripcion = Nothing
        Me.xtxttran_type.TabIndex = 2
        Me.xtxttran_type.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LibXLookup2)
        Me.GroupBox1.Controls.Add(Me.xtxsuc_name)
        Me.GroupBox1.Controls.Add(Me.lblNumber)
        Me.GroupBox1.Controls.Add(Me.lblYear)
        Me.GroupBox1.Controls.Add(Me.lblDateCreated)
        Me.GroupBox1.Controls.Add(Me.xcbo_orign_code)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xtxttran_type)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lblUser)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.lblType_name)
        Me.GroupBox1.Controls.Add(Me.xcbo_tran_status)
        Me.GroupBox1.Controls.Add(Me.xdt_tran_date)
        Me.GroupBox1.Controls.Add(Me.btnTransf)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 144)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.suc_code"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(128, 40)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = "ED"
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 13
        Me.XTextBox1.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(72, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Division:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"suc_code=suc_code", "xtxsuc_name=suc_name"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(498, 40)
        Me.LibXLookup2.LookCaption = "Sucursales"
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup2.ShowFilter = True
        Me.LibXLookup2.ShowMessageNotFound = True
        Me.LibXLookup2.ShowWarning = False
        Me.LibXLookup2.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup2.SizesColumns = Nothing
        Me.LibXLookup2.SizesColumnsTab = Nothing
        Me.LibXLookup2.SqlString = Nothing
        Me.LibXLookup2.SQLTab = Nothing
        Me.LibXLookup2.SrcParameters = New String() {"suc_code=suc_code"}
        Me.LibXLookup2.TabIndex = 16
        Me.LibXLookup2.TableName = "cgsucursal"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=suc_code", "Nomnre=suc_name"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'xtxsuc_name
        '
        Me.xtxsuc_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xtxsuc_name.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.xtxsuc_name.Location = New System.Drawing.Point(176, 40)
        Me.xtxsuc_name.Name = "xtxsuc_name"
        Me.xtxsuc_name.Size = New System.Drawing.Size(328, 20)
        Me.xtxsuc_name.TabIndex = 15
        '
        'lblNumber
        '
        Me.lblNumber.AcceptsReturn = True
        Me.lblNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.perdr_year"))
        Me.lblNumber.EditInitialValue = Nothing
        Me.lblNumber.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.lblNumber.FieldDescription = ""
        Me.lblNumber.FindInitialValue = Nothing
        Me.lblNumber.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lblNumber.IgnoreRequiered = False
        Me.lblNumber.Location = New System.Drawing.Point(634, 16)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.NewInitialValue = Nothing
        Me.lblNumber.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.lblNumber.Requiered = False
        Me.lblNumber.Size = New System.Drawing.Size(56, 20)
        Me.lblNumber.StatusBarPanelDescripcion = Nothing
        Me.lblNumber.TabIndex = 12
        Me.lblNumber.Text = ""
        Me.lblNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblYear
        '
        Me.lblYear.AcceptsReturn = True
        Me.lblYear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.perdr_num"))
        Me.lblYear.EditInitialValue = Nothing
        Me.lblYear.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.lblYear.FieldDescription = ""
        Me.lblYear.FindInitialValue = Nothing
        Me.lblYear.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lblYear.IgnoreRequiered = False
        Me.lblYear.Location = New System.Drawing.Point(698, 16)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.NewInitialValue = Nothing
        Me.lblYear.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.lblYear.Requiered = False
        Me.lblYear.Size = New System.Drawing.Size(56, 20)
        Me.lblYear.StatusBarPanelDescripcion = Nothing
        Me.lblYear.TabIndex = 11
        Me.lblYear.Text = ""
        Me.lblYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDateCreated
        '
        Me.lblDateCreated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateCreated.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.date_created"))
        Me.lblDateCreated.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblDateCreated.Location = New System.Drawing.Point(634, 64)
        Me.lblDateCreated.Name = "lblDateCreated"
        Me.lblDateCreated.Size = New System.Drawing.Size(120, 20)
        Me.lblDateCreated.TabIndex = 10
        '
        'xcbo_orign_code
        '
        Me.xcbo_orign_code.AllowDefaultSort = True
        Me.xcbo_orign_code.bound = True
        Me.xcbo_orign_code.currValue = Nothing
        Me.xcbo_orign_code.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cgtranrm.orign_code"))
        Me.xcbo_orign_code.DefaultWhereString = Nothing
        Me.xcbo_orign_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_orign_code.EditInitialValue = Nothing
        Me.xcbo_orign_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_orign_code.FieldDescription = ""
        Me.xcbo_orign_code.FindInitialValue = Nothing
        Me.xcbo_orign_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_orign_code.IgnoreRequiered = False
        Me.xcbo_orign_code.Location = New System.Drawing.Point(128, 16)
        Me.xcbo_orign_code.LookupKeyDisplayFields = "orign_name"
        Me.xcbo_orign_code.LookupKeyField = "orign_code"
        Me.xcbo_orign_code.LookupTableName = "cgorignm"
        Me.xcbo_orign_code.Name = "xcbo_orign_code"
        Me.xcbo_orign_code.NewInitialValue = "CTG"
        Me.xcbo_orign_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_orign_code.Requiered = False
        Me.xcbo_orign_code.Required = False
        Me.xcbo_orign_code.Size = New System.Drawing.Size(384, 21)
        Me.xcbo_orign_code.SqlString = Nothing
        Me.xcbo_orign_code.StatusBarPanelDescripcion = Nothing
        Me.xcbo_orign_code.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(79, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Origen:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(578, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Usuario:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(248, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha Documento:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.tran_number"))
        Me.TextBox2.EditInitialValue = Nothing
        Me.TextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox2.FieldDescription = ""
        Me.TextBox2.FindInitialValue = Nothing
        Me.TextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.IgnoreRequiered = False
        Me.TextBox2.Location = New System.Drawing.Point(128, 88)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.NewInitialValue = Nothing
        Me.TextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox2.Requiered = False
        Me.TextBox2.Size = New System.Drawing.Size(48, 20)
        Me.TextBox2.StatusBarPanelDescripcion = Nothing
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.AcceptsReturn = True
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.tran_descr"))
        Me.TextBox3.EditInitialValue = Nothing
        Me.TextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.FieldDescription = ""
        Me.TextBox3.FindInitialValue = Nothing
        Me.TextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.IgnoreRequiered = False
        Me.TextBox3.Location = New System.Drawing.Point(128, 112)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.NewInitialValue = Nothing
        Me.TextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.Requiered = False
        Me.TextBox3.Size = New System.Drawing.Size(352, 20)
        Me.TextBox3.StatusBarPanelDescripcion = Nothing
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(540, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Digitado:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(579, 40)
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
        Me.Label4.Location = New System.Drawing.Point(8, 88)
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
        Me.Label5.Location = New System.Drawing.Point(27, 64)
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
        Me.Label6.Location = New System.Drawing.Point(53, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Descripción:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(578, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 16)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Periodo:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUser
        '
        Me.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.userid"))
        Me.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblUser.Location = New System.Drawing.Point(634, 88)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(120, 20)
        Me.lblUser.TabIndex = 7
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"tran_type=type_code", "lblType_name=type_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(498, 64)
        Me.LibXLookup1.LookCaption = "Tipos de Entradas"
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
        Me.LibXLookup1.SrcParameters = New String() {"tran_type=type_code"}
        Me.LibXLookup1.TabIndex = 5
        Me.LibXLookup1.TableName = "ivtypem"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Documento=type_code", "Descripción=type_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'lblType_name
        '
        Me.lblType_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblType_name.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblType_name.Location = New System.Drawing.Point(176, 64)
        Me.lblType_name.Name = "lblType_name"
        Me.lblType_name.Size = New System.Drawing.Size(328, 20)
        Me.lblType_name.TabIndex = 4
        '
        'xcbo_tran_status
        '
        Me.xcbo_tran_status.AllowDefaultSort = True
        Me.xcbo_tran_status.bound = True
        Me.xcbo_tran_status.currValue = Nothing
        Me.xcbo_tran_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cgtranrm.tran_status"))
        Me.xcbo_tran_status.DefaultWhereString = Nothing
        Me.xcbo_tran_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_tran_status.EditInitialValue = Nothing
        Me.xcbo_tran_status.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_tran_status.FieldDescription = ""
        Me.xcbo_tran_status.FindInitialValue = Nothing
        Me.xcbo_tran_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_tran_status.IgnoreRequiered = False
        Me.xcbo_tran_status.Items.AddRange(New Object() {"1-Aplicada", "2-Pendiente", "3-Reversada", "4-Transferida"})
        Me.xcbo_tran_status.Location = New System.Drawing.Point(634, 40)
        Me.xcbo_tran_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_tran_status.LookupKeyField = Nothing
        Me.xcbo_tran_status.LookupTableName = Nothing
        Me.xcbo_tran_status.Name = "xcbo_tran_status"
        Me.xcbo_tran_status.NewInitialValue = "2"
        Me.xcbo_tran_status.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_tran_status.Requiered = False
        Me.xcbo_tran_status.Required = False
        Me.xcbo_tran_status.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_tran_status.SqlString = Nothing
        Me.xcbo_tran_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_tran_status.TabIndex = 1
        '
        'xdt_tran_date
        '
        Me.xdt_tran_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_tran_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cgtranrm.tran_date"))
        Me.xdt_tran_date.EditInitialValue = Nothing
        Me.xdt_tran_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_tran_date.FieldDescription = ""
        Me.xdt_tran_date.FindInitialValue = Nothing
        Me.xdt_tran_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_tran_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_tran_date.IgnoreRequiered = False
        Me.xdt_tran_date.Location = New System.Drawing.Point(360, 88)
        Me.xdt_tran_date.Name = "xdt_tran_date"
        Me.xdt_tran_date.NewInitialValue = ""
        Me.xdt_tran_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_tran_date.Requiered = False
        Me.xdt_tran_date.Size = New System.Drawing.Size(120, 20)
        Me.xdt_tran_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_tran_date.TabIndex = 0
        '
        'btnTransf
        '
        Me.btnTransf.Image = CType(resources.GetObject("btnTransf.Image"), System.Drawing.Image)
        Me.btnTransf.Location = New System.Drawing.Point(24, 16)
        Me.btnTransf.Name = "btnTransf"
        Me.btnTransf.Size = New System.Drawing.Size(32, 23)
        Me.btnTransf.TabIndex = 46
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.DataMember = "cgtranrd"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 182)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(792, 264)
        Me.LibXGrid1.TabIndex = 2
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgc_acct_no, Me.XEditTextBoxColumn1, Me.xdb_depto, Me.dgc_tran_descr, Me.dgc_debit_amount, Me.dgc_credit_amount})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cgtranrd"
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
        Me.xlk_acct_no.DestParameters = New String() {"acct_no=acct_no", "acct_name=acct_name"}
        Me.xlk_acct_no.FilterField = "acct_name"
        Me.xlk_acct_no.IgnoreFindInBrowseMode = False
        Me.xlk_acct_no.isCanceled = False
        Me.xlk_acct_no.Location = New System.Drawing.Point(416, 432)
        Me.xlk_acct_no.LookCaption = Nothing
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
        Me.xlk_acct_no.WhereCondition = "acct_isctrl <> 1"
        Me.xlk_acct_no.WhereParameters = Nothing
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Sucuresal"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "suc_code"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 75
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
        Me.dgc_tran_descr.TabStop = True
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
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrd.acct_name"))
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(104, 483)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(424, 20)
        Me.Label7.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(8, 483)
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
        Me.lblDiferencia.Location = New System.Drawing.Point(632, 483)
        Me.lblDiferencia.Name = "lblDiferencia"
        Me.lblDiferencia.Size = New System.Drawing.Size(104, 20)
        Me.lblDiferencia.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(560, 483)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Diferencia:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'i_cgjourm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(816, 558)
        Me.Controls.Add(Me.xlk_acct_no)
        Me.Controls.Add(Me.xlk_depto_code)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblDiferencia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.KeyPreview = True
        Me.Name = "i_cgjourm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Entrada de Diario"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cgtranrd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cgtranrm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub i_cgjourm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            LibXGrid1.footerOperations.add("debit_amount", "sum(debit_amount)")
            LibXGrid1.footerOperations.add("credit_amount", "sum(credit_amount)")
            LibXGrid1.footerOperations.add("tranr_detail", "sum(debit_amount)-sum(credit_amount)")
            oDocumento = New SGT.Contabilidad.Entidades.Documentos
            oAnoFiscal = New AnoFiscal
            Transf = CType(System.Configuration.ConfigurationSettings.AppSettings.Get("LibxTransfCXP"), Boolean)
            Me.btnTransf.Visible = Transf
            Me.btnTransf.Enabled = Transf

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterLoadDetail(ByVal sender As Object, ByVal e As LibX.XbeforeLoadDetailEventArgs) Handles LibXConnector1.AfterLoadDetail
        Try

            For Each oRow As DataRow In DataSet1.Tables("cgtranrd").Rows
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
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
        Try
            If LibXConnector1.IsDataEditing = True Then
                If e.cell = dgc_tran_descr.Column Then
                    If LibXGrid1.GetValue(e.row, dgc_credit_amount).ToString.Trim <> "" Then
                        SendKeys.Send("{TAB}")
                    End If
                End If

                If IsNumeric(e.value.ToString.Trim) Then
                    If e.cell = dgc_debit_amount.Column Then
                        SendKeys.Send("{TAB}")
                    End If

                    If e.cell = dgc_credit_amount.Column Then
                        SendKeys.Send("{TAB}")
                    End If
                End If

                BalancearEntrada()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try
            lblDateCreated.Text = LibX.Data.Manager.Connection.GetDate
            xcbo_orign_code.currValue = "CTG"
            xcbo_tran_status.currValue = Val(DocumentoStatusEnum.Pendiente)
            XTextBox1.Text = FindSucursal()
            LibXLookup2.ExecuteFind()

            oPeriodo = oAnoFiscal.BuscarPeriodoActual

            lblYear.Text = oPeriodo.year.ToString
            lblNumber.Text = oPeriodo.Number.ToString

            xdt_tran_date.Value = oPeriodo.Thru

        Catch ex As Exception
            LibX.Log.Add(ex)
        Finally
            oPeriodo = Nothing

        End Try
    End Sub
    Private Function FindSucursal() As Integer
        Dim oSucursal As Integer
        Dim SelectStmt As String

        SelectStmt = "select suc_code from cgsucursal where suc_default = 1 "

        oSucursal = LibX.Data.Manager.GetScalar(SelectStmt)

        Return oSucursal

    End Function


    Private Function BalancearEntrada() As Decimal
        Dim TotalDebito As Decimal = 0
        Dim TotalCredito As Decimal = 0
        Dim Diferencia As Decimal = 0
        Try

            TotalDebito = Val(LibXGrid1.footerTable.Rows(0).Item("debit_amount").ToString.Trim)
            TotalCredito = Val(LibXGrid1.footerTable.Rows(0).Item("credit_amount").ToString.Trim)

            Diferencia = TotalDebito - TotalCredito

            lblDiferencia.Text = Format("###,###,##0.00", Diferencia)


            Return Diferencia

        Catch ex As Exception
            Throw
        End Try

    End Function


    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then
                If BalancearEntrada() <> 0 Then
                    If MessageBox.Show("Documento No Balanceado, desea guardarlo?", "Documento No Balancedo", MessageBoxButtons.YesNo) = DialogResult.No Then
                        Throw New ApplicationException("Entrada no balanceada")
                    End If
                End If

                If e.UpdatingArgs.StatementType = StatementType.Insert Then
                    'e.UpdatingArgs.Row!tran_number = oDocumento.GetNextNumber(e.UpdatingArgs.Row!tran_type)
                    e.UpdatingArgs.Row!tran_number = e.UpdatingArgs.Row!perdr_num.ToString.Trim("00") & "-" & e.UpdatingArgs.Row!perdr_year
                End If
            End If

        Catch ex As Exception
            Throw
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
        End Try

    End Sub


    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            If e.Action = LibX.LibxConnectionActions.Edit Then
                If LibXConnector1.CurrentDataRow!tran_status = Val(DocumentoStatusEnum.Aplicada) Then
                    Throw (New ApplicationException("Este documento no puede ser modificado!"))
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Dim oReport As LibX.ReportLib
        Dim SQLString As String
        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
                oReport = New LibX.ReportLib("CTG", "r_tranrp01.rpt")
                oReport.RetrieveSQLQuery()

                SQLString = oReport.SQLQuery
                SQLString = LibX.ConcatWherePart(SQLString.Trim, " cgtranrm.tranr_serial = " & LibXConnector1.CurrentDataRow!tranr_serial.ToString)
                oReport.SQLQuery = SQLString

                oReport.Action = 1
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        Try
            For Each oRow As DataRow In cgtranrd.Rows
                If oRow.RowState <> DataRowState.Deleted Then
                    If LibX.IsNull(oRow!line_no) Then
                        oRow!line_no = Val(cgtranrd.Compute("max(line_no)", "").ToString.Trim) + 1
                    End If
                End If
            Next

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub xlk_acct_no_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_acct_no.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.IsDataEditing = True Then
                LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, 1, 1)
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles LibXGrid1.Navigate

    End Sub

    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid1.CurrentRowChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                LibXGrid1.refreshFooter()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If Not e.row Is Nothing Then
                If e.row!tran_status <> Val(DocumentoStatusEnum.Pendiente) _
                And e.row!tran_status <> Val(DocumentoStatusEnum.Reversada) Then
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

    Private Sub xdt_tran_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xdt_tran_date.ValueChanged
        Try
            oPeriodo = New Periodo
            If LibXConnector1.IsDataEditing = True Then
                oPeriodo = oAnoFiscal.BuscarPeriodoPorFecha(xdt_tran_date.Value)

                LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year
                LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number

                lblYear.Text = oPeriodo.year.ToString
                lblNumber.Text = oPeriodo.Number.ToString
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xdt_tran_date_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xdt_tran_date.Validating
        Try
            oPeriodo = New Periodo
            If LibXConnector1.IsDataEditing = True Then
                If LibX.IsNull(xdt_tran_date.Value) = True Then
                    Exit Sub
                End If

                If oPeriodo.isValid(xdt_tran_date.Value) = True Then
                    Exit Sub
                End If
                ''LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year
                ''LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number

                ''lblYear.Text = oPeriodo.year.ToString
                ''lblNumber.Text = oPeriodo.Number.ToString

                If MessageBox.Show("Esta fecha no corresponde al periodo actual, desea continuar con esta fecha?", "Fecha Fuera de Periodo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Throw New ApplicationException("Fecha fuera de periodo!")
                End If
            End If

        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnTransf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransf.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            EnviarEntradaDiario()
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub EnviarEntradaDiario()
        Dim wsSGF1 As WSSGF1.WSSGF1

        Dim oDataSet As DataSet

        Dim oTableCgtranrm As DataTable
        Dim oTableCgtranrm1 As DataTable
        Dim oTableCgtranrd As DataTable
        Dim oTableCgtranrd1 As DataTable
        Dim oRemote As DataTable
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim Number As String

        Try

            '// cpimvcem
            oTableCgtranrm = LibX.Data.Manager.GetDataTable("select * from cgtranrm where tran_status not in(4)")

            If oTablecgtranrm.Rows.Count <= 0 Then
                Throw New ApplicationException("No hay informaciones pendiente de transferir")
            End If


            For Each oRow1 As DataRow In oTableCgtranrm.Rows
                oTableCgtranrm1 = LibX.Data.Manager.GetDataTable("select * from cgtranrm where tranr_serial = " & oRow1!tranr_serial)
                oTableCgtranrm1.TableName = "cgtranrm"

                oTableCgtranrd1 = LibX.Data.Manager.GetDataTable("select * from cgtranrd where tranr_serial = " & oRow1!tranr_serial)
                oTableCgtranrd1.TableName = "cgtranrd"


                '// DataSet
                oDataSet = New DataSet("dsSGF1")

                '// Tablas
                oDataSet.Tables.Add(oTableCgtranrm1)
                oDataSet.Tables.Add(oTableCgtranrd1)

                wsSGF1 = New WSSGF1.WSSGF1

                oRemote = LibX.Data.Manager.GetDataTable("select * from scremote where estatus = 1")

                If oRemote Is Nothing Then
                    Throw New ApplicationException("No hay estaciones remotas configuradas!")
                End If

                If oRemote.Rows.Count <= 0 Then
                    Throw New ApplicationException("No hay estaciones remotas configuradas!")
                End If

                For Each oRow As DataRow In oRemote.Rows
                    wsSGF1.Url = oRow!url.ToString.Trim
                    wsSGF1.Credentials = System.Net.CredentialCache.DefaultCredentials

                    If wsSGF1.InsertarEntradaDiario(oDataSet) Then
                        Number = oDataSet.Tables(0).Rows(0)!tran_number
                    End If
                Next
                xUpdate = New LibX.Data.XUpdateStmt("cgtranrm")
                xUpdate.FieldsSet("tran_status") = 4
                xUpdate.Fields("tranr_serial") = oRow1!tranr_serial
                xUpdate.Fields("suc_code") = oRow1!suc_code
                xUpdate.Execute()
            Next

        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class
