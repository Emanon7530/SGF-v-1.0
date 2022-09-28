Imports SGT.Administracion.Entidades
Public Class i_cpprovm01
    Inherits System.Windows.Forms.Form
    Dim oDocumento As SGT.Inventario.Entidades.Articulo

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents TextBox3 As LibX.XTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As LibX.XTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As LibX.XTextBox
    Friend WithEvents TextBox14 As LibX.XTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents term_name As LibX.XTextBox
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As LibX.XTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnTerminos As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents disc_days As LibX.XTextBox
    Friend WithEvents disc_pct As LibX.XTextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents due_days As LibX.XTextBox
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents txtpov_code As LibX.XTextBox
    Friend WithEvents btnMov As System.Windows.Forms.Button
    Friend WithEvents tipo As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents rnc As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tipo_name As LibX.XTextBox
    Friend WithEvents TextBox9 As LibX.XTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
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
    Friend WithEvents xtxt_contact_phone As LibX.XMaskEdit
    Friend WithEvents xtxt_fax As LibX.XMaskEdit
    Friend WithEvents xtxt_credit_limit As LibX.XMaskEdit
    Friend WithEvents xtxt_balance As LibX.XMaskEdit
    Friend WithEvents xtxt_phone As LibX.XMaskEdit
    Friend WithEvents xtxt_prov_code As LibX.XTextBox
    Friend WithEvents xtxt_prov_name As LibX.XTextBox
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents xchk_stop_pay As LibX.LibxCheckBox
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents XMaskEdit1 As LibX.XMaskEdit
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents xtxt_ban_name As LibX.XTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents xlk_ban_code As LibX.LibXLookup
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents xtxt_acct_name As LibX.XTextBox
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents xlk_acct_no As LibX.LibXLookup
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents XMaskEdit2 As LibX.XMaskEdit
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents XMaskEdit3 As LibX.XMaskEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents XMaskEdit4 As LibX.XMaskEdit
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XDataGridComboBoxColumn1 As LibX.XDataGridComboBoxColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents LibXCombo2 As LibX.LibXCombo
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents XDataGridComboBoxColumn2 As LibX.XDataGridComboBoxColumn
    Friend WithEvents LibXCombo3 As LibX.LibXCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
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
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.xtxt_prov_code = New LibX.XTextBox
        Me.xtxt_prov_name = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.XMaskEdit4 = New LibX.XMaskEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.XMaskEdit3 = New LibX.XMaskEdit
        Me.Label20 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.XMaskEdit2 = New LibX.XMaskEdit
        Me.xtxt_acct_name = New LibX.XTextBox
        Me.XTextBox3 = New LibX.XTextBox
        Me.xlk_acct_no = New LibX.LibXLookup
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.xtxt_contact_phone = New LibX.XMaskEdit
        Me.tipo_name = New LibX.XTextBox
        Me.TextBox9 = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.xtxt_fax = New LibX.XMaskEdit
        Me.rnc = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.tipo = New System.Windows.Forms.Label
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.Label17 = New System.Windows.Forms.Label
        Me.due_days = New LibX.XTextBox
        Me.xchk_stop_pay = New LibX.LibxCheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox3 = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox6 = New LibX.XTextBox
        Me.term_name = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.xtxt_credit_limit = New LibX.XMaskEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.xtxt_balance = New LibX.XMaskEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox13 = New LibX.XTextBox
        Me.TextBox14 = New LibX.XTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox4 = New LibX.XTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.xtxt_phone = New LibX.XMaskEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.disc_days = New LibX.XTextBox
        Me.disc_pct = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.XMaskEdit1 = New LibX.XMaskEdit
        Me.XTextBox1 = New LibX.XTextBox
        Me.xtxt_ban_name = New LibX.XTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.xlk_ban_code = New LibX.LibXLookup
        Me.txtpov_code = New LibX.XTextBox
        Me.btnTerminos = New System.Windows.Forms.Button
        Me.btnMov = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XDataGridComboBoxColumn1 = New LibX.XDataGridComboBoxColumn
        Me.LibXCombo2 = New LibX.LibXCombo
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.XDataGridComboBoxColumn2 = New LibX.XDataGridComboBoxColumn
        Me.LibXCombo3 = New LibX.LibXCombo
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_prov_code
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_prov_code
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_prov_name
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(714, 24)
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
        Me.LibXConnector1.DataMember = "cpprovm"
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
        Me.LibXConnector1.ReportName = Nothing
        Me.LibXConnector1.ReportObject = Nothing
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn7, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"prov_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "cpprovm"
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
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "address2"
        Me.DataColumn12.MaxLength = 40
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "credit_limit"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "balance"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "stop_pay"
        Me.DataColumn15.DataType = GetType(System.Int16)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "aply_disc"
        Me.DataColumn16.DataType = GetType(System.Int16)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "backorder"
        Me.DataColumn17.DataType = GetType(System.Int16)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "date_created"
        Me.DataColumn18.DataType = GetType(System.DateTime)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "userid"
        Me.DataColumn19.MaxLength = 20
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "city_code"
        Me.DataColumn20.MaxLength = 3
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sector_code"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "contact_phne"
        Me.DataColumn7.MaxLength = 20
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "ban_code"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "cuenta_bancaria"
        Me.DataColumn23.MaxLength = 20
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "last_purch_date"
        Me.DataColumn24.DataType = GetType(System.DateTime)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "last_pay_date"
        Me.DataColumn25.DataType = GetType(System.DateTime)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "acct_no"
        Me.DataColumn26.MaxLength = 20
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "contact_apellidos"
        Me.DataColumn27.MaxLength = 40
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "localidad"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "itbis"
        Me.DataColumn29.DataType = GetType(System.Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "isr"
        Me.DataColumn30.DataType = GetType(System.Decimal)
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34})
        Me.DataTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"prov_code", "term_code"}, True)})
        Me.DataTable2.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn31, Me.DataColumn32}
        Me.DataTable2.TableName = "cpprovd"
        '
        'DataColumn31
        '
        Me.DataColumn31.AllowDBNull = False
        Me.DataColumn31.ColumnName = "prov_code"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.AllowDBNull = False
        Me.DataColumn32.ColumnName = "term_code"
        Me.DataColumn32.MaxLength = 5
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "orden"
        Me.DataColumn33.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.KeyFields = ""
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = ""
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cpprovm"
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
        Me.LibXDbSourceTable2.KeyFields = "prov_code,term_code"
        Me.LibXDbSourceTable2.LineColName = "orden"
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"prov_code=prov_code"}
        Me.LibXDbSourceTable2.MasterTableName = "cpprovm"
        Me.LibXDbSourceTable2.SerialColumnName = ""
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = Nothing
        Me.LibXDbSourceTable2.TableName = "cpprovd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'xtxt_prov_code
        '
        Me.xtxt_prov_code.AcceptsReturn = True
        Me.xtxt_prov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.prov_code"))
        Me.xtxt_prov_code.EditInitialValue = Nothing
        Me.xtxt_prov_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_prov_code.FieldDescription = ""
        Me.xtxt_prov_code.FindInitialValue = Nothing
        Me.xtxt_prov_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_code.IgnoreRequiered = False
        Me.xtxt_prov_code.Location = New System.Drawing.Point(120, 24)
        Me.xtxt_prov_code.Name = "xtxt_prov_code"
        Me.xtxt_prov_code.NewInitialValue = Nothing
        Me.xtxt_prov_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_prov_code.Requiered = False
        Me.xtxt_prov_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_prov_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_prov_code.TabIndex = 0
        Me.xtxt_prov_code.Text = ""
        '
        'xtxt_prov_name
        '
        Me.xtxt_prov_name.AcceptsReturn = True
        Me.xtxt_prov_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_prov_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.prov_name"))
        Me.xtxt_prov_name.EditInitialValue = Nothing
        Me.xtxt_prov_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_name.FieldDescription = ""
        Me.xtxt_prov_name.FindInitialValue = Nothing
        Me.xtxt_prov_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_name.IgnoreRequiered = False
        Me.xtxt_prov_name.Location = New System.Drawing.Point(120, 48)
        Me.xtxt_prov_name.Name = "xtxt_prov_name"
        Me.xtxt_prov_name.NewInitialValue = Nothing
        Me.xtxt_prov_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_name.Requiered = False
        Me.xtxt_prov_name.Size = New System.Drawing.Size(360, 20)
        Me.xtxt_prov_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_prov_name.TabIndex = 1
        Me.xtxt_prov_name.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit4)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit3)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit2)
        Me.GroupBox1.Controls.Add(Me.xtxt_acct_name)
        Me.GroupBox1.Controls.Add(Me.XTextBox3)
        Me.GroupBox1.Controls.Add(Me.xlk_acct_no)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.xtxt_contact_phone)
        Me.GroupBox1.Controls.Add(Me.xtxt_prov_code)
        Me.GroupBox1.Controls.Add(Me.tipo_name)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xtxt_fax)
        Me.GroupBox1.Controls.Add(Me.rnc)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.tipo)
        Me.GroupBox1.Controls.Add(Me.LibXLookup2)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.due_days)
        Me.GroupBox1.Controls.Add(Me.xchk_stop_pay)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xtxt_prov_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.term_name)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.xtxt_credit_limit)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.xtxt_balance)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.TextBox14)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.xtxt_phone)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.disc_days)
        Me.GroupBox1.Controls.Add(Me.disc_pct)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit1)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.xtxt_ban_name)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.xlk_ban_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 320)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label22.Location = New System.Drawing.Point(496, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(87, 16)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "Retension Isr %:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XMaskEdit4
        '
        Me.XMaskEdit4.AcceptsReturn = True
        Me.XMaskEdit4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.isr"))
        Me.XMaskEdit4.EditInitialValue = Nothing
        Me.XMaskEdit4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit4.FieldDescription = ""
        Me.XMaskEdit4.FindInitialValue = Nothing
        Me.XMaskEdit4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit4.IgnoreRequiered = False
        Me.XMaskEdit4.Location = New System.Drawing.Point(592, 120)
        Me.XMaskEdit4.Masked = MaskedTextBox.Mask.Decimal
        Me.XMaskEdit4.Name = "XMaskEdit4"
        Me.XMaskEdit4.NewInitialValue = Nothing
        Me.XMaskEdit4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit4.Requiered = False
        Me.XMaskEdit4.Size = New System.Drawing.Size(96, 20)
        Me.XMaskEdit4.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit4.TabIndex = 48
        Me.XMaskEdit4.Text = ""
        Me.XMaskEdit4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Location = New System.Drawing.Point(488, 96)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(95, 16)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "Retension Itbis %:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XMaskEdit3
        '
        Me.XMaskEdit3.AcceptsReturn = True
        Me.XMaskEdit3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.itbis"))
        Me.XMaskEdit3.EditInitialValue = Nothing
        Me.XMaskEdit3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit3.FieldDescription = ""
        Me.XMaskEdit3.FindInitialValue = Nothing
        Me.XMaskEdit3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit3.IgnoreRequiered = False
        Me.XMaskEdit3.Location = New System.Drawing.Point(592, 96)
        Me.XMaskEdit3.Masked = MaskedTextBox.Mask.Decimal
        Me.XMaskEdit3.Name = "XMaskEdit3"
        Me.XMaskEdit3.NewInitialValue = Nothing
        Me.XMaskEdit3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit3.Requiered = False
        Me.XMaskEdit3.Size = New System.Drawing.Size(96, 20)
        Me.XMaskEdit3.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit3.TabIndex = 46
        Me.XMaskEdit3.Text = ""
        Me.XMaskEdit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label20.Location = New System.Drawing.Point(272, 72)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 16)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Localidad:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cpprovm.localidad"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Items.AddRange(New Object() {"1-LOCAL", "2-INTERNACIONAL"})
        Me.LibXCombo1.Location = New System.Drawing.Point(336, 72)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = Nothing
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(144, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 44
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.contact_apellidos"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(336, 144)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(144, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 42
        Me.XTextBox2.Text = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label19.Location = New System.Drawing.Point(280, 144)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 16)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Apellidos:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XMaskEdit2
        '
        Me.XMaskEdit2.AcceptsReturn = True
        Me.XMaskEdit2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.rnc_id"))
        Me.XMaskEdit2.EditInitialValue = Nothing
        Me.XMaskEdit2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit2.FieldDescription = ""
        Me.XMaskEdit2.FindInitialValue = Nothing
        Me.XMaskEdit2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit2.IgnoreRequiered = False
        Me.XMaskEdit2.Location = New System.Drawing.Point(120, 72)
        Me.XMaskEdit2.Masked = MaskedTextBox.Mask.Digit
        Me.XMaskEdit2.MaxLength = 11
        Me.XMaskEdit2.Name = "XMaskEdit2"
        Me.XMaskEdit2.NewInitialValue = Nothing
        Me.XMaskEdit2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit2.Requiered = False
        Me.XMaskEdit2.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit2.TabIndex = 2
        Me.XMaskEdit2.Text = ""
        '
        'xtxt_acct_name
        '
        Me.xtxt_acct_name.AcceptsReturn = True
        Me.xtxt_acct_name.EditInitialValue = Nothing
        Me.xtxt_acct_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_acct_name.FieldDescription = ""
        Me.xtxt_acct_name.FindInitialValue = Nothing
        Me.xtxt_acct_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_acct_name.IgnoreRequiered = False
        Me.xtxt_acct_name.Location = New System.Drawing.Point(240, 240)
        Me.xtxt_acct_name.Name = "xtxt_acct_name"
        Me.xtxt_acct_name.NewInitialValue = Nothing
        Me.xtxt_acct_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_acct_name.ReadOnly = True
        Me.xtxt_acct_name.Requiered = False
        Me.xtxt_acct_name.Size = New System.Drawing.Size(224, 20)
        Me.xtxt_acct_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_acct_name.TabIndex = 41
        Me.xtxt_acct_name.TabStop = False
        Me.xtxt_acct_name.Text = ""
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.acct_no"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(120, 240)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(112, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 8
        Me.XTextBox3.Text = ""
        '
        'xlk_acct_no
        '
        Me.xlk_acct_no.AlternateFieldSearch = Nothing
        Me.xlk_acct_no.BeginCheck = False
        Me.xlk_acct_no.CheckText = Nothing
        Me.xlk_acct_no.ComboMode = False
        Me.xlk_acct_no.DataMember = Nothing
        Me.xlk_acct_no.DataSource = Me.LibXConnector1
        Me.xlk_acct_no.DestParameters = New String() {"acct_no=acct_no", "xtxt_acct_name=acct_name"}
        Me.xlk_acct_no.FilterField = "acct_name"
        Me.xlk_acct_no.IgnoreFindInBrowseMode = False
        Me.xlk_acct_no.isCanceled = False
        Me.xlk_acct_no.Location = New System.Drawing.Point(464, 240)
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
        Me.xlk_acct_no.TabIndex = 40
        Me.xlk_acct_no.TableName = "cgacctm"
        Me.xlk_acct_no.TabStop = False
        Me.xlk_acct_no.UseCopyConnection = False
        Me.xlk_acct_no.UseRowRetrieveEvents = False
        Me.xlk_acct_no.UseTab = False
        Me.xlk_acct_no.VisParameters = New String() {"Código=acct_no", "Descripción=acct_name"}
        Me.xlk_acct_no.WhereCondition = ""
        Me.xlk_acct_no.WhereParameters = Nothing
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label18.Location = New System.Drawing.Point(16, 240)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 16)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Cuenta Contable:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(504, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 16)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Tel. Contacto:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_contact_phone
        '
        Me.xtxt_contact_phone.AcceptsReturn = True
        Me.xtxt_contact_phone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.contact_phne"))
        Me.xtxt_contact_phone.EditInitialValue = Nothing
        Me.xtxt_contact_phone.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_contact_phone.FieldDescription = ""
        Me.xtxt_contact_phone.FindInitialValue = Nothing
        Me.xtxt_contact_phone.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_contact_phone.IgnoreRequiered = False
        Me.xtxt_contact_phone.Location = New System.Drawing.Point(592, 144)
        Me.xtxt_contact_phone.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.xtxt_contact_phone.Name = "xtxt_contact_phone"
        Me.xtxt_contact_phone.NewInitialValue = Nothing
        Me.xtxt_contact_phone.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_contact_phone.Requiered = False
        Me.xtxt_contact_phone.Size = New System.Drawing.Size(96, 20)
        Me.xtxt_contact_phone.StatusBarPanelDescripcion = Nothing
        Me.xtxt_contact_phone.TabIndex = 13
        Me.xtxt_contact_phone.Text = ""
        '
        'tipo_name
        '
        Me.tipo_name.AcceptsReturn = True
        Me.tipo_name.EditInitialValue = Nothing
        Me.tipo_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.tipo_name.FieldDescription = ""
        Me.tipo_name.FindInitialValue = Nothing
        Me.tipo_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.tipo_name.IgnoreRequiered = False
        Me.tipo_name.Location = New System.Drawing.Point(184, 168)
        Me.tipo_name.Name = "tipo_name"
        Me.tipo_name.NewInitialValue = Nothing
        Me.tipo_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.tipo_name.ReadOnly = True
        Me.tipo_name.Requiered = False
        Me.tipo_name.Size = New System.Drawing.Size(280, 20)
        Me.tipo_name.StatusBarPanelDescripcion = Nothing
        Me.tipo_name.TabIndex = 35
        Me.tipo_name.TabStop = False
        Me.tipo_name.Text = ""
        '
        'TextBox9
        '
        Me.TextBox9.AcceptsReturn = True
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.prov_type"))
        Me.TextBox9.EditInitialValue = Nothing
        Me.TextBox9.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox9.FieldDescription = ""
        Me.TextBox9.FindInitialValue = Nothing
        Me.TextBox9.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox9.IgnoreRequiered = False
        Me.TextBox9.Location = New System.Drawing.Point(120, 168)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.NewInitialValue = Nothing
        Me.TextBox9.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox9.Requiered = False
        Me.TextBox9.Size = New System.Drawing.Size(56, 20)
        Me.TextBox9.StatusBarPanelDescripcion = Nothing
        Me.TextBox9.TabIndex = 5
        Me.TextBox9.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(552, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Fax:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_fax
        '
        Me.xtxt_fax.AcceptsReturn = True
        Me.xtxt_fax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.fax"))
        Me.xtxt_fax.EditInitialValue = Nothing
        Me.xtxt_fax.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_fax.FieldDescription = ""
        Me.xtxt_fax.FindInitialValue = Nothing
        Me.xtxt_fax.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_fax.IgnoreRequiered = False
        Me.xtxt_fax.Location = New System.Drawing.Point(592, 72)
        Me.xtxt_fax.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.xtxt_fax.Name = "xtxt_fax"
        Me.xtxt_fax.NewInitialValue = Nothing
        Me.xtxt_fax.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_fax.Requiered = False
        Me.xtxt_fax.Size = New System.Drawing.Size(96, 20)
        Me.xtxt_fax.StatusBarPanelDescripcion = Nothing
        Me.xtxt_fax.TabIndex = 12
        Me.xtxt_fax.Text = ""
        '
        'rnc
        '
        Me.rnc.AutoSize = True
        Me.rnc.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rnc.Location = New System.Drawing.Point(62, 72)
        Me.rnc.Name = "rnc"
        Me.rnc.Size = New System.Drawing.Size(47, 16)
        Me.rnc.TabIndex = 30
        Me.rnc.Text = "R. N. C.:"
        Me.rnc.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"prov_type=type_prov", "tipo_name=type_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(464, 168)
        Me.LibXLookup1.LookCaption = "Tipos de Suplidores"
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
        Me.LibXLookup1.SrcParameters = New String() {"prov_type=type_prov"}
        Me.LibXLookup1.TabIndex = 29
        Me.LibXLookup1.TableName = "cptypep"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=type_prov", "Descripción=type_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'tipo
        '
        Me.tipo.AutoSize = True
        Me.tipo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.tipo.Location = New System.Drawing.Point(35, 168)
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(74, 16)
        Me.tipo.TabIndex = 27
        Me.tipo.Text = "Tipo Suplidor:"
        Me.tipo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"term_code=term_code", "term_name=term_name", "disc_days=disc_days", "disc_pct=disc_pct", "due_days=due_days"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(464, 192)
        Me.LibXLookup2.LookCaption = "Términos de venta"
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
        Me.LibXLookup2.SrcParameters = New String() {"term_code=term_code"}
        Me.LibXLookup2.TabIndex = 11
        Me.LibXLookup2.TableName = "cctermm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=term_code", "Descripción=term_name", "% de descuento=disc_pct", "Días de descuento=disc_days", "Días de Vencimiento=due_days"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Location = New System.Drawing.Point(320, 217)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 16)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Días vencimiento:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'due_days
        '
        Me.due_days.AcceptsReturn = True
        Me.due_days.EditInitialValue = Nothing
        Me.due_days.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.due_days.FieldDescription = ""
        Me.due_days.FindInitialValue = Nothing
        Me.due_days.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.due_days.IgnoreRequiered = False
        Me.due_days.Location = New System.Drawing.Point(429, 216)
        Me.due_days.Name = "due_days"
        Me.due_days.NewInitialValue = Nothing
        Me.due_days.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.due_days.ReadOnly = True
        Me.due_days.Requiered = False
        Me.due_days.Size = New System.Drawing.Size(48, 20)
        Me.due_days.StatusBarPanelDescripcion = Nothing
        Me.due_days.TabIndex = 16
        Me.due_days.TabStop = False
        Me.due_days.Text = ""
        '
        'xchk_stop_pay
        '
        Me.xchk_stop_pay.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xchk_stop_pay.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "cpprovm.stop_pay"))
        Me.xchk_stop_pay.EditInitialValue = Nothing
        Me.xchk_stop_pay.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xchk_stop_pay.FindInitialValue = Nothing
        Me.xchk_stop_pay.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xchk_stop_pay.IgnoreRequiered = False
        Me.xchk_stop_pay.KeepEnabled = False
        Me.xchk_stop_pay.Location = New System.Drawing.Point(592, 24)
        Me.xchk_stop_pay.Name = "xchk_stop_pay"
        Me.xchk_stop_pay.NewInitialValue = Nothing
        Me.xchk_stop_pay.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xchk_stop_pay.ReadOnly = False
        Me.xchk_stop_pay.Requiered = False
        Me.xchk_stop_pay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xchk_stop_pay.Size = New System.Drawing.Size(96, 16)
        Me.xchk_stop_pay.TabIndex = 10
        Me.xchk_stop_pay.Text = "Detener Pago"
        Me.xchk_stop_pay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xchk_stop_pay.ThreeState = True
        Me.xchk_stop_pay.value = Nothing
        Me.xchk_stop_pay.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(66, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(61, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox3
        '
        Me.TextBox3.AcceptsReturn = True
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.contact_name"))
        Me.TextBox3.EditInitialValue = Nothing
        Me.TextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.FieldDescription = ""
        Me.TextBox3.FindInitialValue = Nothing
        Me.TextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.IgnoreRequiered = False
        Me.TextBox3.Location = New System.Drawing.Point(120, 144)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.NewInitialValue = Nothing
        Me.TextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.Requiered = False
        Me.TextBox3.Size = New System.Drawing.Size(160, 20)
        Me.TextBox3.StatusBarPanelDescripcion = Nothing
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(56, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contacto:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(54, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Terminos:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox6
        '
        Me.TextBox6.AcceptsReturn = True
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.term_code"))
        Me.TextBox6.EditInitialValue = Nothing
        Me.TextBox6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox6.FieldDescription = ""
        Me.TextBox6.FindInitialValue = Nothing
        Me.TextBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox6.IgnoreRequiered = False
        Me.TextBox6.Location = New System.Drawing.Point(120, 192)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.NewInitialValue = Nothing
        Me.TextBox6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox6.Requiered = False
        Me.TextBox6.Size = New System.Drawing.Size(56, 20)
        Me.TextBox6.StatusBarPanelDescripcion = Nothing
        Me.TextBox6.TabIndex = 6
        Me.TextBox6.Text = ""
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
        Me.term_name.Location = New System.Drawing.Point(184, 192)
        Me.term_name.Name = "term_name"
        Me.term_name.NewInitialValue = Nothing
        Me.term_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.term_name.ReadOnly = True
        Me.term_name.Requiered = False
        Me.term_name.Size = New System.Drawing.Size(280, 20)
        Me.term_name.StatusBarPanelDescripcion = Nothing
        Me.term_name.TabIndex = 1
        Me.term_name.TabStop = False
        Me.term_name.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(488, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Limite de Crédito:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_credit_limit
        '
        Me.xtxt_credit_limit.AcceptsReturn = True
        Me.xtxt_credit_limit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.credit_limit"))
        Me.xtxt_credit_limit.EditInitialValue = Nothing
        Me.xtxt_credit_limit.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_credit_limit.FieldDescription = ""
        Me.xtxt_credit_limit.FindInitialValue = Nothing
        Me.xtxt_credit_limit.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_credit_limit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_credit_limit.IgnoreRequiered = False
        Me.xtxt_credit_limit.Location = New System.Drawing.Point(592, 240)
        Me.xtxt_credit_limit.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxt_credit_limit.Name = "xtxt_credit_limit"
        Me.xtxt_credit_limit.NewInitialValue = Nothing
        Me.xtxt_credit_limit.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_credit_limit.Requiered = False
        Me.xtxt_credit_limit.Size = New System.Drawing.Size(96, 29)
        Me.xtxt_credit_limit.StatusBarPanelDescripcion = Nothing
        Me.xtxt_credit_limit.TabIndex = 14
        Me.xtxt_credit_limit.Text = ""
        Me.xtxt_credit_limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(528, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Balance:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_balance
        '
        Me.xtxt_balance.AcceptsReturn = True
        Me.xtxt_balance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.balance"))
        Me.xtxt_balance.EditInitialValue = Nothing
        Me.xtxt_balance.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_balance.FieldDescription = ""
        Me.xtxt_balance.FindInitialValue = Nothing
        Me.xtxt_balance.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_balance.IgnoreRequiered = False
        Me.xtxt_balance.Location = New System.Drawing.Point(592, 280)
        Me.xtxt_balance.Masked = MaskedTextBox.Mask.None
        Me.xtxt_balance.Name = "xtxt_balance"
        Me.xtxt_balance.NewInitialValue = Nothing
        Me.xtxt_balance.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_balance.Requiered = False
        Me.xtxt_balance.Size = New System.Drawing.Size(96, 29)
        Me.xtxt_balance.StatusBarPanelDescripcion = Nothing
        Me.xtxt_balance.TabIndex = 15
        Me.xtxt_balance.TabStop = False
        Me.xtxt_balance.Text = ""
        Me.xtxt_balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(512, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Ultimo Pago:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox13
        '
        Me.TextBox13.AcceptsReturn = True
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.last_pay_date"))
        Me.TextBox13.EditInitialValue = Nothing
        Me.TextBox13.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox13.FieldDescription = ""
        Me.TextBox13.FindInitialValue = Nothing
        Me.TextBox13.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox13.IgnoreRequiered = False
        Me.TextBox13.Location = New System.Drawing.Point(592, 168)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.NewInitialValue = Nothing
        Me.TextBox13.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Requiered = False
        Me.TextBox13.Size = New System.Drawing.Size(96, 20)
        Me.TextBox13.StatusBarPanelDescripcion = Nothing
        Me.TextBox13.TabIndex = 11
        Me.TextBox13.TabStop = False
        Me.TextBox13.Text = ""
        '
        'TextBox14
        '
        Me.TextBox14.AcceptsReturn = True
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.last_purch_date"))
        Me.TextBox14.EditInitialValue = Nothing
        Me.TextBox14.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox14.FieldDescription = ""
        Me.TextBox14.FindInitialValue = Nothing
        Me.TextBox14.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox14.IgnoreRequiered = False
        Me.TextBox14.Location = New System.Drawing.Point(592, 192)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.NewInitialValue = Nothing
        Me.TextBox14.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Requiered = False
        Me.TextBox14.Size = New System.Drawing.Size(96, 20)
        Me.TextBox14.StatusBarPanelDescripcion = Nothing
        Me.TextBox14.TabIndex = 12
        Me.TextBox14.TabStop = False
        Me.TextBox14.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(496, 192)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Ultima Compra:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(54, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dirección:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox4
        '
        Me.TextBox4.AcceptsReturn = True
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.address1"))
        Me.TextBox4.EditInitialValue = Nothing
        Me.TextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.FieldDescription = ""
        Me.TextBox4.FindInitialValue = Nothing
        Me.TextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.IgnoreRequiered = False
        Me.TextBox4.Location = New System.Drawing.Point(120, 96)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.NewInitialValue = Nothing
        Me.TextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.Requiered = False
        Me.TextBox4.Size = New System.Drawing.Size(360, 40)
        Me.TextBox4.StatusBarPanelDescripcion = Nothing
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(528, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Teléfono:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_phone
        '
        Me.xtxt_phone.AcceptsReturn = True
        Me.xtxt_phone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.phone"))
        Me.xtxt_phone.EditInitialValue = Nothing
        Me.xtxt_phone.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_phone.FieldDescription = ""
        Me.xtxt_phone.FindInitialValue = Nothing
        Me.xtxt_phone.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_phone.IgnoreRequiered = False
        Me.xtxt_phone.Location = New System.Drawing.Point(592, 48)
        Me.xtxt_phone.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.xtxt_phone.Name = "xtxt_phone"
        Me.xtxt_phone.NewInitialValue = Nothing
        Me.xtxt_phone.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_phone.Requiered = False
        Me.xtxt_phone.Size = New System.Drawing.Size(96, 20)
        Me.xtxt_phone.StatusBarPanelDescripcion = Nothing
        Me.xtxt_phone.TabIndex = 11
        Me.xtxt_phone.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(19, 216)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 16)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "% de Descuento:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Location = New System.Drawing.Point(184, 216)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 16)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Días descuento:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'disc_days
        '
        Me.disc_days.AcceptsReturn = True
        Me.disc_days.EditInitialValue = Nothing
        Me.disc_days.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.disc_days.FieldDescription = ""
        Me.disc_days.FindInitialValue = Nothing
        Me.disc_days.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.disc_days.IgnoreRequiered = False
        Me.disc_days.Location = New System.Drawing.Point(272, 216)
        Me.disc_days.Name = "disc_days"
        Me.disc_days.NewInitialValue = Nothing
        Me.disc_days.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.disc_days.ReadOnly = True
        Me.disc_days.Requiered = False
        Me.disc_days.Size = New System.Drawing.Size(48, 20)
        Me.disc_days.StatusBarPanelDescripcion = Nothing
        Me.disc_days.TabIndex = 17
        Me.disc_days.TabStop = False
        Me.disc_days.Text = ""
        '
        'disc_pct
        '
        Me.disc_pct.AcceptsReturn = True
        Me.disc_pct.EditInitialValue = Nothing
        Me.disc_pct.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.disc_pct.FieldDescription = ""
        Me.disc_pct.FindInitialValue = Nothing
        Me.disc_pct.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.disc_pct.IgnoreRequiered = False
        Me.disc_pct.Location = New System.Drawing.Point(120, 216)
        Me.disc_pct.Name = "disc_pct"
        Me.disc_pct.NewInitialValue = Nothing
        Me.disc_pct.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.disc_pct.ReadOnly = True
        Me.disc_pct.Requiered = False
        Me.disc_pct.Size = New System.Drawing.Size(56, 20)
        Me.disc_pct.StatusBarPanelDescripcion = Nothing
        Me.disc_pct.TabIndex = 7
        Me.disc_pct.TabStop = False
        Me.disc_pct.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(16, 288)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Cuenta Bancaria:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XMaskEdit1
        '
        Me.XMaskEdit1.AcceptsReturn = True
        Me.XMaskEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.cuenta_bancaria"))
        Me.XMaskEdit1.EditInitialValue = Nothing
        Me.XMaskEdit1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.FieldDescription = ""
        Me.XMaskEdit1.FindInitialValue = Nothing
        Me.XMaskEdit1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.IgnoreRequiered = False
        Me.XMaskEdit1.Location = New System.Drawing.Point(120, 288)
        Me.XMaskEdit1.Masked = MaskedTextBox.Mask.None
        Me.XMaskEdit1.Name = "XMaskEdit1"
        Me.XMaskEdit1.NewInitialValue = Nothing
        Me.XMaskEdit1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.Requiered = False
        Me.XMaskEdit1.Size = New System.Drawing.Size(360, 20)
        Me.XMaskEdit1.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit1.TabIndex = 10
        Me.XMaskEdit1.Text = ""
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.ban_code"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(120, 264)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 9
        Me.XTextBox1.Text = ""
        '
        'xtxt_ban_name
        '
        Me.xtxt_ban_name.AcceptsReturn = True
        Me.xtxt_ban_name.EditInitialValue = Nothing
        Me.xtxt_ban_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_ban_name.FieldDescription = ""
        Me.xtxt_ban_name.FindInitialValue = Nothing
        Me.xtxt_ban_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_ban_name.IgnoreRequiered = False
        Me.xtxt_ban_name.Location = New System.Drawing.Point(184, 264)
        Me.xtxt_ban_name.Name = "xtxt_ban_name"
        Me.xtxt_ban_name.NewInitialValue = Nothing
        Me.xtxt_ban_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_ban_name.ReadOnly = True
        Me.xtxt_ban_name.Requiered = False
        Me.xtxt_ban_name.Size = New System.Drawing.Size(280, 20)
        Me.xtxt_ban_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_ban_name.TabIndex = 1
        Me.xtxt_ban_name.TabStop = False
        Me.xtxt_ban_name.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(72, 264)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 16)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Banco:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_ban_code
        '
        Me.xlk_ban_code.AlternateFieldSearch = Nothing
        Me.xlk_ban_code.BeginCheck = False
        Me.xlk_ban_code.CheckText = Nothing
        Me.xlk_ban_code.ComboMode = False
        Me.xlk_ban_code.DataMember = Nothing
        Me.xlk_ban_code.DataSource = Me.LibXConnector1
        Me.xlk_ban_code.DestParameters = New String() {"ban_code=ban_code", "xtxt_ban_name=ban_name"}
        Me.xlk_ban_code.FilterField = "ban_name"
        Me.xlk_ban_code.IgnoreFindInBrowseMode = False
        Me.xlk_ban_code.isCanceled = False
        Me.xlk_ban_code.Location = New System.Drawing.Point(464, 264)
        Me.xlk_ban_code.LookCaption = "Entidades Financieras"
        Me.xlk_ban_code.Name = "xlk_ban_code"
        Me.xlk_ban_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_ban_code.ShowFilter = True
        Me.xlk_ban_code.ShowMessageNotFound = True
        Me.xlk_ban_code.ShowWarning = False
        Me.xlk_ban_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_ban_code.SizesColumns = Nothing
        Me.xlk_ban_code.SizesColumnsTab = Nothing
        Me.xlk_ban_code.SqlString = Nothing
        Me.xlk_ban_code.SQLTab = Nothing
        Me.xlk_ban_code.SrcParameters = New String() {"ban_code=ban_code"}
        Me.xlk_ban_code.TabIndex = 11
        Me.xlk_ban_code.TableName = "ftbanco"
        Me.xlk_ban_code.TabStop = False
        Me.xlk_ban_code.UseCopyConnection = False
        Me.xlk_ban_code.UseRowRetrieveEvents = False
        Me.xlk_ban_code.UseTab = False
        Me.xlk_ban_code.VisParameters = New String() {"Banco=ban_code", "Nombre=ban_name"}
        Me.xlk_ban_code.WhereCondition = Nothing
        Me.xlk_ban_code.WhereParameters = Nothing
        '
        'txtpov_code
        '
        Me.txtpov_code.AcceptsReturn = True
        Me.txtpov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.prov_code"))
        Me.txtpov_code.EditInitialValue = Nothing
        Me.txtpov_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtpov_code.FieldDescription = ""
        Me.txtpov_code.FindInitialValue = Nothing
        Me.txtpov_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtpov_code.IgnoreRequiered = False
        Me.txtpov_code.Location = New System.Drawing.Point(128, 24)
        Me.txtpov_code.Name = "txtpov_code"
        Me.txtpov_code.NewInitialValue = Nothing
        Me.txtpov_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtpov_code.Requiered = False
        Me.txtpov_code.Size = New System.Drawing.Size(56, 20)
        Me.txtpov_code.StatusBarPanelDescripcion = Nothing
        Me.txtpov_code.TabIndex = 1
        Me.txtpov_code.Text = ""
        '
        'btnTerminos
        '
        Me.btnTerminos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTerminos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTerminos.Location = New System.Drawing.Point(8, 544)
        Me.btnTerminos.Name = "btnTerminos"
        Me.btnTerminos.TabIndex = 2
        Me.btnTerminos.Text = "Términos"
        '
        'btnMov
        '
        Me.btnMov.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMov.Enabled = False
        Me.btnMov.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMov.Location = New System.Drawing.Point(184, 544)
        Me.btnMov.Name = "btnMov"
        Me.btnMov.TabIndex = 4
        Me.btnMov.Text = "Movimientos"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(96, 544)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Tipos"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(272, 544)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Division"
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Terminos de Devoluciones"
        Me.LibXGrid1.DataMember = "cpprovd"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 360)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(696, 152)
        Me.LibXGrid1.TabIndex = 6
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XDataGridComboBoxColumn2, Me.XDataGridComboBoxColumn1, Me.XEditTextBoxColumn1})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cpprovd"
        '
        'XDataGridComboBoxColumn1
        '
        Me.XDataGridComboBoxColumn1.ComboBox = Me.LibXCombo2
        Me.XDataGridComboBoxColumn1.Format = ""
        Me.XDataGridComboBoxColumn1.FormatInfo = Nothing
        Me.XDataGridComboBoxColumn1.HeaderText = "Termino"
        Me.XDataGridComboBoxColumn1.isReadOnly = False
        Me.XDataGridComboBoxColumn1.MappingName = "term_code"
        Me.XDataGridComboBoxColumn1.Width = 225
        '
        'LibXCombo2
        '
        Me.LibXCombo2.AllowDefaultSort = True
        Me.LibXCombo2.bound = True
        Me.LibXCombo2.currValue = Nothing
        Me.LibXCombo2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cpprovd.term_code"))
        Me.LibXCombo2.DefaultWhereString = Nothing
        Me.LibXCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo2.EditInitialValue = Nothing
        Me.LibXCombo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.FieldDescription = ""
        Me.LibXCombo2.FindInitialValue = Nothing
        Me.LibXCombo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.IgnoreRequiered = False
        Me.LibXCombo2.Location = New System.Drawing.Point(440, 376)
        Me.LibXCombo2.LookupKeyDisplayFields = "term_name"
        Me.LibXCombo2.LookupKeyField = "term_code"
        Me.LibXCombo2.LookupTableName = "cptermm"
        Me.LibXCombo2.Name = "LibXCombo2"
        Me.LibXCombo2.NewInitialValue = Nothing
        Me.LibXCombo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.Requiered = False
        Me.LibXCombo2.Required = False
        Me.LibXCombo2.Size = New System.Drawing.Size(121, 21)
        Me.LibXCombo2.SqlString = Nothing
        Me.LibXCombo2.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo2.TabIndex = 7
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Orden"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "orden"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 50
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "brand_code"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'XDataGridComboBoxColumn2
        '
        Me.XDataGridComboBoxColumn2.ComboBox = Me.LibXCombo3
        Me.XDataGridComboBoxColumn2.Format = ""
        Me.XDataGridComboBoxColumn2.FormatInfo = Nothing
        Me.XDataGridComboBoxColumn2.HeaderText = "Marca"
        Me.XDataGridComboBoxColumn2.isReadOnly = False
        Me.XDataGridComboBoxColumn2.MappingName = "brand_code"
        Me.XDataGridComboBoxColumn2.Width = 225
        '
        'LibXCombo3
        '
        Me.LibXCombo3.AllowDefaultSort = True
        Me.LibXCombo3.bound = True
        Me.LibXCombo3.currValue = Nothing
        Me.LibXCombo3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cpprovd.brand_code"))
        Me.LibXCombo3.DefaultWhereString = Nothing
        Me.LibXCombo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo3.EditInitialValue = Nothing
        Me.LibXCombo3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo3.FieldDescription = ""
        Me.LibXCombo3.FindInitialValue = Nothing
        Me.LibXCombo3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo3.IgnoreRequiered = False
        Me.LibXCombo3.Location = New System.Drawing.Point(400, 392)
        Me.LibXCombo3.LookupKeyDisplayFields = "brand_name"
        Me.LibXCombo3.LookupKeyField = "brand_code"
        Me.LibXCombo3.LookupTableName = "ivbrandm"
        Me.LibXCombo3.Name = "LibXCombo3"
        Me.LibXCombo3.NewInitialValue = Nothing
        Me.LibXCombo3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo3.Requiered = False
        Me.LibXCombo3.Required = False
        Me.LibXCombo3.Size = New System.Drawing.Size(121, 21)
        Me.LibXCombo3.SqlString = Nothing
        Me.LibXCombo3.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo3.TabIndex = 8
        '
        'i_cpprovm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(714, 576)
        Me.Controls.Add(Me.LibXCombo3)
        Me.Controls.Add(Me.LibXCombo2)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.btnTerminos)
        Me.Controls.Add(Me.btnMov)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_cpprovm01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Suplidores"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oParam As SGT.Administracion.Entidades.Program.RunID
        Dim oProgm As SGT.Administracion.Entidades.Program

        Try
            oParam = New Program.RunID
            oProgm = New Program

            With oParam
                .ProgID = 6
                .Modal = True
            End With

            oProgm.RunOption(oParam)

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminos.Click
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams

            With oParam
                .IsFromOther = True
            End With

            LibX.LibXRunner.Run("i_ccterm01", "CXC", True)

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oParam As SGT.Administracion.Entidades.Program.RunID
        Dim oProgm As SGT.Administracion.Entidades.Program

        Try
            oParam = New Program.RunID
            oProgm = New Program

            With oParam
                .ProgID = 7
                .Modal = True
            End With

            oProgm.RunOption(oParam)

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try

            If e.Action = LibX.LibxConnectionActions.Add Then
                txtpov_code.Enabled = False
            End If

            If e.Action = LibX.LibxConnectionActions.Edit Then
                txtpov_code.Enabled = False
            End If

            If e.Action = LibX.LibxConnectionActions.Find Then
                txtpov_code.Enabled = True
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMov.Click
        Dim oParam As LibX.LibxPrgParams

        Dim WhereStmt As String
        Try
            oParam = New LibX.LibxPrgParams

            oParam.WhereToExecute = "cpinvcem.prov_code = " & LibXConnector1.CurrentDataRow!prov_code.ToString
            LibX.App.CurrentPrgParams = oParam

            LibX.LibXRunner.Run("c_cpdocs01", "CXP", True)
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_RowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange
        Try
            If Val(xtxt_balance.Text.Trim) >= Val(xtxt_credit_limit.Text.Trim) Then
                xtxt_balance.ForeColor = Drawing.Color.Red
            Else
                xtxt_balance.ForeColor = Drawing.Color.Blue
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try
            btnMov.Enabled = (e.isEditing = False And LibXConnector1.HasRecords = True)
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams

            With oParam
                .IsFromOther = True
            End With

            LibX.LibXRunner.Run("i_cptypem01", "CXP", True)

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams

            With oParam
                .IsFromOther = True
            End With

            LibX.LibXRunner.Run("i_cpdivisionm01", "CXP", True)

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                ''Dim intLast As Integer = oDocumento.GetNextCodeProv()
                'Dim intLast As Integer = 0
                ''e.UpdatingArgs.Row!prov_code = intLast
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub i_cpprovm01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oDocumento = New SGT.Inventario.Entidades.Articulo
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click

    End Sub

    Private Sub LibXConnector1_InsertingDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingDetailRow
        Try
            If e.UpdatingArgs.Row!term_code.ToString.Trim = "" Then

                e.Handled = True
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
End Class
