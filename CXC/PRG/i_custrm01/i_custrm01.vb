Imports SGT.Administracion.Entidades

Public Class i_custrm01
    Inherits System.Windows.Forms.Form
    'Dim oPermission As SGT.Administracion.Entidades.Permission
    Dim strstmp As String
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
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents btnTipos As System.Windows.Forms.Button
    Friend WithEvents btnTerminos As System.Windows.Forms.Button
    Friend WithEvents btnMovimientos As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
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
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents xcbo_cust_status As LibX.LibXCombo
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As LibX.XTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As LibX.XTextBox
    Friend WithEvents csttype_name As LibX.XTextBox
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As LibX.XTextBox
    Friend WithEvents term_name As LibX.XTextBox
    Friend WithEvents vend_name As LibX.XTextBox
    Friend WithEvents TextBox9 As LibX.XTextBox
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox2 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox3 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox4 As LibX.LibxCheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As LibX.XTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As LibX.XTextBox
    Friend WithEvents TextBox14 As LibX.XTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents disc_days As LibX.XTextBox
    Friend WithEvents disc_pct As LibX.XTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents due_days As LibX.XTextBox
    Friend WithEvents TextBox15 As LibX.XTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    'Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents rtb_Nota As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox5 As LibX.XTextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtcredit_limit As LibX.XTextBox
    Friend WithEvents LibxCheckBox5 As LibX.LibxCheckBox
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents xck_cust_costo As LibX.LibxCheckBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents txtcity_code As LibX.XTextBox
    Friend WithEvents txtcity_name As LibX.XTextBox
    Friend WithEvents txtsector_code As LibX.XTextBox
    Friend WithEvents txtsector_name As LibX.XTextBox
    Friend WithEvents xlk_sector As LibX.LibXLookup
    Friend WithEvents xlk_city As LibX.LibXLookup
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents dtpdateCreate As LibX.LibxDateTimePicker
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents xtxt_cust_code As LibX.XTextBox
    Friend WithEvents xtxt_cust_name As LibX.XTextBox
    Friend WithEvents xtxt_phone As LibX.XMaskEdit
    Friend WithEvents xtxt_celular As LibX.XMaskEdit
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents Txt_bal As LibX.XTextBox
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents acct_desc As LibX.XTextBox
    Friend WithEvents xlk_acct_no As LibX.LibXLookup
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents LibxCheckBox6 As LibX.LibxCheckBox
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents LibxCheckBox7 As LibX.LibxCheckBox
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents XTextBox4 As LibX.XTextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
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
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.xtxt_cust_name = New LibX.XTextBox
        Me.xtxt_cust_code = New LibX.XTextBox
        Me.btnTipos = New System.Windows.Forms.Button
        Me.btnTerminos = New System.Windows.Forms.Button
        Me.btnMovimientos = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.XTextBox4 = New LibX.XTextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.xlk_acct_no = New LibX.LibXLookup
        Me.Label37 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.acct_desc = New LibX.XTextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.xtxt_celular = New LibX.XMaskEdit
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.dtpdateCreate = New LibX.LibxDateTimePicker
        Me.xlk_sector = New LibX.LibXLookup
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtsector_code = New LibX.XTextBox
        Me.txtsector_name = New LibX.XTextBox
        Me.xlk_city = New LibX.LibXLookup
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtcity_code = New LibX.XTextBox
        Me.txtcity_name = New LibX.XTextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.TextBox5 = New LibX.XTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.xcbo_cust_status = New LibX.LibXCombo
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox3 = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox4 = New LibX.XTextBox
        Me.csttype_name = New LibX.XTextBox
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox6 = New LibX.XTextBox
        Me.term_name = New LibX.XTextBox
        Me.vend_name = New LibX.XTextBox
        Me.TextBox9 = New LibX.XTextBox
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LibxCheckBox7 = New LibX.LibxCheckBox
        Me.LibxCheckBox6 = New LibX.LibxCheckBox
        Me.xck_cust_costo = New LibX.LibxCheckBox
        Me.LibxCheckBox5 = New LibX.LibxCheckBox
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.LibxCheckBox2 = New LibX.LibxCheckBox
        Me.LibxCheckBox3 = New LibX.LibxCheckBox
        Me.LibxCheckBox4 = New LibX.LibxCheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtcredit_limit = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Txt_bal = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox12 = New LibX.XTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox13 = New LibX.XTextBox
        Me.TextBox14 = New LibX.XTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.disc_days = New LibX.XTextBox
        Me.disc_pct = New LibX.XTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.due_days = New LibX.XTextBox
        Me.TextBox15 = New LibX.XTextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.xtxt_phone = New LibX.XMaskEdit
        Me.Label31 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.rtb_Nota = New System.Windows.Forms.RichTextBox
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_cust_name
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_cust_code
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_cust_name
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(746, 24)
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
        Me.LibXConnector1.DataMember = "cccustm"
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
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"cust_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "cccustm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "cust_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "vend_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "cust_name"
        Me.DataColumn3.MaxLength = 100
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "csttype_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "term_code"
        Me.DataColumn5.MaxLength = 5
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "contact_name"
        Me.DataColumn6.MaxLength = 40
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "credit_limit"
        Me.DataColumn7.DataType = GetType(System.Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "balance"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "cust_status"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "stop_abono"
        Me.DataColumn10.DataType = GetType(System.Int16)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "stop_cheque"
        Me.DataColumn11.DataType = GetType(System.Int16)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "stop_venct"
        Me.DataColumn12.DataType = GetType(System.Int16)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "day_benef"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "last_pay_date"
        Me.DataColumn14.DataType = GetType(System.DateTime)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "last_sell_date"
        Me.DataColumn15.DataType = GetType(System.DateTime)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "cust_default"
        Me.DataColumn16.DataType = GetType(System.Int16)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "cust_image"
        Me.DataColumn17.MaxLength = 5
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "rnc_id"
        Me.DataColumn18.MaxLength = 15
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "cust_pricemajor"
        Me.DataColumn19.DataType = GetType(System.Int16)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "cust_address"
        Me.DataColumn27.MaxLength = 200
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.ColumnName = "cust_phone"
        Me.DataColumn28.MaxLength = 15
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "cust_note"
        Me.DataColumn29.MaxLength = 2147483647
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "cust_credito"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "cust_costo"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "city_code"
        Me.DataColumn32.MaxLength = 3
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "sector_code"
        Me.DataColumn33.MaxLength = 3
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "cust_create"
        Me.DataColumn34.DataType = GetType(System.DateTime)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "cust_cellphone"
        Me.DataColumn35.MaxLength = 15
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "cust_email"
        Me.DataColumn36.MaxLength = 40
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "last_delivery"
        Me.DataColumn37.DataType = GetType(System.DateTime)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "chequera"
        Me.DataColumn38.DataType = GetType(System.Int32)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "acct_no"
        Me.DataColumn39.MaxLength = 10
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "ncf_type"
        Me.DataColumn40.DataType = GetType(System.Int32)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "web_transf"
        Me.DataColumn41.DataType = GetType(System.Int32)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "otro_dsct"
        Me.DataColumn42.DataType = GetType(System.Int32)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "cuat_apellidos"
        Me.DataColumn43.MaxLength = 40
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "contact_apellidos"
        Me.DataColumn44.MaxLength = 40
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "cust_apellidos"
        Me.DataColumn45.MaxLength = 40
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26})
        Me.DataTable2.TableName = "cccustv"
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "cust_code"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "a0a30a"
        Me.DataColumn21.DataType = GetType(System.Decimal)
        Me.DataColumn21.ReadOnly = True
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "a31a60"
        Me.DataColumn22.DataType = GetType(System.Decimal)
        Me.DataColumn22.ReadOnly = True
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "a61a90"
        Me.DataColumn23.DataType = GetType(System.Decimal)
        Me.DataColumn23.ReadOnly = True
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "a91"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        Me.DataColumn24.ReadOnly = True
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "Vencido"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        Me.DataColumn25.ReadOnly = True
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "NoVencido"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        Me.DataColumn26.ReadOnly = True
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
        Me.LibXDbSourceTable1.SerialColumnName = "cust_code"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cccustm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LibXDbSourceTable2
        '
        Me.LibXDbSourceTable2.AllowDelete = True
        Me.LibXDbSourceTable2.AllowEdit = True
        Me.LibXDbSourceTable2.AllowNew = True
        Me.LibXDbSourceTable2.AutoIncrementSerial = False
        Me.LibXDbSourceTable2.CustomDbUpdate = True
        Me.LibXDbSourceTable2.DeleteOrder = 0
        Me.LibXDbSourceTable2.FillOnQuery = True
        Me.LibXDbSourceTable2.FillOnRowChange = True
        Me.LibXDbSourceTable2.HeaderIsOnGrid = False
        Me.LibXDbSourceTable2.InnerJon = False
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"cust_code=cust_code"}
        Me.LibXDbSourceTable2.MasterTableName = ""
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select cust_code,sum(a0a30a) a0a30a,sum(a31a60) a31a60,sum(a61a90) a61a90,", "sum(a91) a91,sum(vencido) vencido,sum(novencido) novencido", " from cccustv", "group by cust_code"}
        Me.LibXDbSourceTable2.TableName = "cccustv"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'xtxt_cust_name
        '
        Me.xtxt_cust_name.AcceptsReturn = True
        Me.xtxt_cust_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_cust_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.cust_name"))
        Me.xtxt_cust_name.EditInitialValue = Nothing
        Me.xtxt_cust_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cust_name.FieldDescription = ""
        Me.xtxt_cust_name.FindInitialValue = Nothing
        Me.xtxt_cust_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cust_name.IgnoreRequiered = False
        Me.xtxt_cust_name.Location = New System.Drawing.Point(120, 40)
        Me.xtxt_cust_name.Name = "xtxt_cust_name"
        Me.xtxt_cust_name.NewInitialValue = Nothing
        Me.xtxt_cust_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cust_name.Requiered = False
        Me.xtxt_cust_name.Size = New System.Drawing.Size(160, 20)
        Me.xtxt_cust_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_cust_name.TabIndex = 1
        Me.xtxt_cust_name.Text = ""
        '
        'xtxt_cust_code
        '
        Me.xtxt_cust_code.AcceptsReturn = True
        Me.xtxt_cust_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.cust_code"))
        Me.xtxt_cust_code.EditInitialValue = Nothing
        Me.xtxt_cust_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_cust_code.FieldDescription = ""
        Me.xtxt_cust_code.FindInitialValue = Nothing
        Me.xtxt_cust_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cust_code.IgnoreRequiered = False
        Me.xtxt_cust_code.Location = New System.Drawing.Point(120, 16)
        Me.xtxt_cust_code.Name = "xtxt_cust_code"
        Me.xtxt_cust_code.NewInitialValue = Nothing
        Me.xtxt_cust_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_cust_code.Requiered = False
        Me.xtxt_cust_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_cust_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_cust_code.TabIndex = 0
        Me.xtxt_cust_code.Text = ""
        '
        'btnTipos
        '
        Me.btnTipos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTipos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTipos.Location = New System.Drawing.Point(8, 504)
        Me.btnTipos.Name = "btnTipos"
        Me.btnTipos.TabIndex = 60
        Me.btnTipos.Text = "Tipos"
        '
        'btnTerminos
        '
        Me.btnTerminos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTerminos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTerminos.Location = New System.Drawing.Point(88, 504)
        Me.btnTerminos.Name = "btnTerminos"
        Me.btnTerminos.TabIndex = 61
        Me.btnTerminos.Text = "Términos"
        '
        'btnMovimientos
        '
        Me.btnMovimientos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMovimientos.Enabled = False
        Me.btnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMovimientos.Location = New System.Drawing.Point(168, 504)
        Me.btnMovimientos.Name = "btnMovimientos"
        Me.btnMovimientos.TabIndex = 62
        Me.btnMovimientos.Text = "Movimientos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 415)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(728, 72)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saldo por Antiguedad"
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustv.a0a30a"))
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label18.Location = New System.Drawing.Point(8, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 20)
        Me.Label18.TabIndex = 1
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "0 a 30"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustv.a31a60"))
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label19.Location = New System.Drawing.Point(117, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 20)
        Me.Label19.TabIndex = 1
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(117, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 16)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "31 a 60"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustv.a61a90"))
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Location = New System.Drawing.Point(229, 40)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 20)
        Me.Label21.TabIndex = 1
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(229, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 16)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "61 a 90"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(341, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(100, 16)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "90 o más"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustv.a91"))
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label24.Location = New System.Drawing.Point(341, 40)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(100, 20)
        Me.Label24.TabIndex = 1
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(453, 24)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(100, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Vencido"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(565, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(100, 16)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "No Vencido"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustv.NoVencido"))
        Me.Label28.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label28.Location = New System.Drawing.Point(565, 40)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(100, 20)
        Me.Label28.TabIndex = 1
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(456, 24)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(100, 16)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "0 a 30"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label30
        '
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label30.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustv.Vencido"))
        Me.Label30.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label30.Location = New System.Drawing.Point(453, 40)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(100, 20)
        Me.Label30.TabIndex = 1
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(728, 384)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(720, 358)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Generales"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.XTextBox4)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.XTextBox3)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.xlk_acct_no)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.acct_desc)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.xtxt_celular)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.dtpdateCreate)
        Me.GroupBox1.Controls.Add(Me.xlk_sector)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.txtsector_code)
        Me.GroupBox1.Controls.Add(Me.txtsector_name)
        Me.GroupBox1.Controls.Add(Me.xlk_city)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.txtcity_code)
        Me.GroupBox1.Controls.Add(Me.txtcity_name)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.xcbo_cust_status)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.xtxt_cust_code)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xtxt_cust_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.csttype_name)
        Me.GroupBox1.Controls.Add(Me.LibXLookup2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.term_name)
        Me.GroupBox1.Controls.Add(Me.vend_name)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.LibXLookup3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtcredit_limit)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Txt_bal)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.TextBox14)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.disc_days)
        Me.GroupBox1.Controls.Add(Me.disc_pct)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.due_days)
        Me.GroupBox1.Controls.Add(Me.TextBox15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.xtxt_phone)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 358)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'XTextBox4
        '
        Me.XTextBox4.AcceptsReturn = True
        Me.XTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.contact_apellidos"))
        Me.XTextBox4.EditInitialValue = Nothing
        Me.XTextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.FieldDescription = ""
        Me.XTextBox4.FindInitialValue = Nothing
        Me.XTextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.IgnoreRequiered = False
        Me.XTextBox4.Location = New System.Drawing.Point(336, 64)
        Me.XTextBox4.Name = "XTextBox4"
        Me.XTextBox4.NewInitialValue = Nothing
        Me.XTextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.Requiered = False
        Me.XTextBox4.Size = New System.Drawing.Size(168, 20)
        Me.XTextBox4.StatusBarPanelDescripcion = Nothing
        Me.XTextBox4.TabIndex = 4
        Me.XTextBox4.Text = ""
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(280, 64)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(53, 16)
        Me.Label40.TabIndex = 64
        Me.Label40.Text = "Apellidos:"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.cust_apellidos"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(336, 40)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(168, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 2
        Me.XTextBox3.Text = ""
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(280, 40)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(53, 16)
        Me.Label39.TabIndex = 62
        Me.Label39.Text = "Apellidos:"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label38.Location = New System.Drawing.Point(440, 328)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(49, 16)
        Me.Label38.TabIndex = 61
        Me.Label38.Text = "Tipo Ncf:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cccustm.ncf_type"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Location = New System.Drawing.Point(528, 330)
        Me.LibXCombo1.LookupKeyDisplayFields = "definicion"
        Me.LibXCombo1.LookupKeyField = "ncf_type"
        Me.LibXCombo1.LookupTableName = "ftncfm"
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = "2"
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(184, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 18
        '
        'xlk_acct_no
        '
        Me.xlk_acct_no.AlternateFieldSearch = Nothing
        Me.xlk_acct_no.BeginCheck = False
        Me.xlk_acct_no.CheckText = Nothing
        Me.xlk_acct_no.ComboMode = False
        Me.xlk_acct_no.DataMember = Nothing
        Me.xlk_acct_no.DataSource = Me.LibXConnector1
        Me.xlk_acct_no.DestParameters = New String() {"acct_no=acct_no", "acct_desc=acct_name"}
        Me.xlk_acct_no.FilterField = "acct_name"
        Me.xlk_acct_no.IgnoreFindInBrowseMode = False
        Me.xlk_acct_no.isCanceled = False
        Me.xlk_acct_no.Location = New System.Drawing.Point(496, 304)
        Me.xlk_acct_no.LookCaption = "Cuentas Contables"
        Me.xlk_acct_no.Name = "xlk_acct_no"
        Me.xlk_acct_no.PopupSize = New System.Drawing.Size(500, 300)
        Me.xlk_acct_no.ShowFilter = True
        Me.xlk_acct_no.ShowMessageNotFound = True
        Me.xlk_acct_no.ShowWarning = False
        Me.xlk_acct_no.Size = New System.Drawing.Size(16, 20)
        Me.xlk_acct_no.SizesColumns = Nothing
        Me.xlk_acct_no.SizesColumnsTab = Nothing
        Me.xlk_acct_no.SqlString = Nothing
        Me.xlk_acct_no.SQLTab = Nothing
        Me.xlk_acct_no.SrcParameters = New String() {"acct_no=acct_no"}
        Me.xlk_acct_no.TabIndex = 59
        Me.xlk_acct_no.TableName = "cgacctm"
        Me.xlk_acct_no.TabStop = False
        Me.xlk_acct_no.UseCopyConnection = False
        Me.xlk_acct_no.UseRowRetrieveEvents = False
        Me.xlk_acct_no.UseTab = False
        Me.xlk_acct_no.VisParameters = New String() {"Código=acct_no", "Descripción=acct_name"}
        Me.xlk_acct_no.WhereCondition = "acct_isctrl = 0 and acct_type = 1"
        Me.xlk_acct_no.WhereParameters = ""
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(16, 304)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(92, 16)
        Me.Label37.TabIndex = 57
        Me.Label37.Text = "Cuenta Contable:"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.acct_no"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(120, 304)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = True
        Me.XTextBox2.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 11
        Me.XTextBox2.Text = ""
        '
        'acct_desc
        '
        Me.acct_desc.AcceptsReturn = True
        Me.acct_desc.EditInitialValue = Nothing
        Me.acct_desc.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.acct_desc.FieldDescription = ""
        Me.acct_desc.FindInitialValue = Nothing
        Me.acct_desc.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.acct_desc.IgnoreRequiered = False
        Me.acct_desc.Location = New System.Drawing.Point(176, 304)
        Me.acct_desc.Name = "acct_desc"
        Me.acct_desc.NewInitialValue = Nothing
        Me.acct_desc.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.acct_desc.ReadOnly = True
        Me.acct_desc.Requiered = False
        Me.acct_desc.Size = New System.Drawing.Size(320, 20)
        Me.acct_desc.StatusBarPanelDescripcion = Nothing
        Me.acct_desc.TabIndex = 58
        Me.acct_desc.TabStop = False
        Me.acct_desc.Text = ""
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(72, 328)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(42, 16)
        Me.Label36.TabIndex = 55
        Me.Label36.Text = "Correo:"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.cust_email"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTextBox1.ForeColor = System.Drawing.Color.Blue
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(120, 328)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 12
        Me.XTextBox1.Text = ""
        '
        'xtxt_celular
        '
        Me.xtxt_celular.AcceptsReturn = True
        Me.xtxt_celular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_celular.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.cust_cellphone"))
        Me.xtxt_celular.EditInitialValue = Nothing
        Me.xtxt_celular.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_celular.FieldDescription = ""
        Me.xtxt_celular.FindInitialValue = Nothing
        Me.xtxt_celular.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_celular.IgnoreRequiered = False
        Me.xtxt_celular.Location = New System.Drawing.Point(600, 186)
        Me.xtxt_celular.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.xtxt_celular.Name = "xtxt_celular"
        Me.xtxt_celular.NewInitialValue = Nothing
        Me.xtxt_celular.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_celular.Requiered = False
        Me.xtxt_celular.Size = New System.Drawing.Size(112, 20)
        Me.xtxt_celular.StatusBarPanelDescripcion = Nothing
        Me.xtxt_celular.TabIndex = 15
        Me.xtxt_celular.Text = ""
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label35.Location = New System.Drawing.Point(548, 186)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(43, 16)
        Me.Label35.TabIndex = 53
        Me.Label35.Text = "Celular:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label34.Location = New System.Drawing.Point(504, 306)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(87, 16)
        Me.Label34.TabIndex = 51
        Me.Label34.Text = "Fecha Creación:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtpdateCreate
        '
        Me.dtpdateCreate.CustomFormat = "dd/MM/yyyy"
        Me.dtpdateCreate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cccustm.cust_create"))
        Me.dtpdateCreate.EditInitialValue = Nothing
        Me.dtpdateCreate.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.dtpdateCreate.Enabled = False
        Me.dtpdateCreate.FieldDescription = ""
        Me.dtpdateCreate.FindInitialValue = Nothing
        Me.dtpdateCreate.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dtpdateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdateCreate.IgnoreRequiered = False
        Me.dtpdateCreate.Location = New System.Drawing.Point(600, 306)
        Me.dtpdateCreate.Name = "dtpdateCreate"
        Me.dtpdateCreate.NewInitialValue = "now"
        Me.dtpdateCreate.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.dtpdateCreate.Requiered = False
        Me.dtpdateCreate.Size = New System.Drawing.Size(112, 20)
        Me.dtpdateCreate.StatusBarPanelDescripcion = Nothing
        Me.dtpdateCreate.TabIndex = 17
        '
        'xlk_sector
        '
        Me.xlk_sector.AlternateFieldSearch = Nothing
        Me.xlk_sector.BeginCheck = False
        Me.xlk_sector.CheckText = Nothing
        Me.xlk_sector.ComboMode = False
        Me.xlk_sector.DataMember = Nothing
        Me.xlk_sector.DataSource = Me.LibXConnector1
        Me.xlk_sector.DestParameters = New String() {"txtsector_code=sector_code", "txtsector_name=sector_name"}
        Me.xlk_sector.FilterField = Nothing
        Me.xlk_sector.IgnoreFindInBrowseMode = False
        Me.xlk_sector.isCanceled = False
        Me.xlk_sector.Location = New System.Drawing.Point(504, 160)
        Me.xlk_sector.LookCaption = Nothing
        Me.xlk_sector.Name = "xlk_sector"
        Me.xlk_sector.PopupSize = New System.Drawing.Size(500, 300)
        Me.xlk_sector.ShowFilter = True
        Me.xlk_sector.ShowMessageNotFound = True
        Me.xlk_sector.ShowWarning = False
        Me.xlk_sector.Size = New System.Drawing.Size(16, 20)
        Me.xlk_sector.SizesColumns = Nothing
        Me.xlk_sector.SizesColumnsTab = Nothing
        Me.xlk_sector.SqlString = New String() {Nothing}
        Me.xlk_sector.SQLTab = Nothing
        Me.xlk_sector.SrcParameters = New String() {"sector_code=sector_code"}
        Me.xlk_sector.TabIndex = 49
        Me.xlk_sector.TableName = "ccsectorm"
        Me.xlk_sector.TabStop = False
        Me.xlk_sector.UseCopyConnection = False
        Me.xlk_sector.UseRowRetrieveEvents = False
        Me.xlk_sector.UseTab = False
        Me.xlk_sector.VisParameters = New String() {"Código=sector_code", "Descripción=sector_name"}
        Me.xlk_sector.WhereCondition = Nothing
        Me.xlk_sector.WhereParameters = Nothing
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(64, 160)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(40, 16)
        Me.Label33.TabIndex = 47
        Me.Label33.Text = "Sector:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtsector_code
        '
        Me.txtsector_code.AcceptsReturn = True
        Me.txtsector_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.sector_code"))
        Me.txtsector_code.EditInitialValue = Nothing
        Me.txtsector_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsector_code.FieldDescription = ""
        Me.txtsector_code.FindInitialValue = Nothing
        Me.txtsector_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsector_code.IgnoreRequiered = False
        Me.txtsector_code.Location = New System.Drawing.Point(120, 160)
        Me.txtsector_code.Name = "txtsector_code"
        Me.txtsector_code.NewInitialValue = Nothing
        Me.txtsector_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsector_code.Requiered = False
        Me.txtsector_code.Size = New System.Drawing.Size(56, 20)
        Me.txtsector_code.StatusBarPanelDescripcion = Nothing
        Me.txtsector_code.TabIndex = 7
        Me.txtsector_code.Text = ""
        '
        'txtsector_name
        '
        Me.txtsector_name.AcceptsReturn = True
        Me.txtsector_name.EditInitialValue = Nothing
        Me.txtsector_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsector_name.FieldDescription = ""
        Me.txtsector_name.FindInitialValue = Nothing
        Me.txtsector_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsector_name.IgnoreRequiered = False
        Me.txtsector_name.Location = New System.Drawing.Point(176, 160)
        Me.txtsector_name.Name = "txtsector_name"
        Me.txtsector_name.NewInitialValue = Nothing
        Me.txtsector_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsector_name.ReadOnly = True
        Me.txtsector_name.Requiered = False
        Me.txtsector_name.Size = New System.Drawing.Size(328, 20)
        Me.txtsector_name.StatusBarPanelDescripcion = Nothing
        Me.txtsector_name.TabIndex = 48
        Me.txtsector_name.TabStop = False
        Me.txtsector_name.Text = ""
        '
        'xlk_city
        '
        Me.xlk_city.AlternateFieldSearch = Nothing
        Me.xlk_city.BeginCheck = False
        Me.xlk_city.CheckText = Nothing
        Me.xlk_city.ComboMode = False
        Me.xlk_city.DataMember = Nothing
        Me.xlk_city.DataSource = Me.LibXConnector1
        Me.xlk_city.DestParameters = New String() {"txtcity_code=city_code", "txtcity_name=city_name"}
        Me.xlk_city.FilterField = ""
        Me.xlk_city.IgnoreFindInBrowseMode = False
        Me.xlk_city.isCanceled = False
        Me.xlk_city.Location = New System.Drawing.Point(504, 136)
        Me.xlk_city.LookCaption = Nothing
        Me.xlk_city.Name = "xlk_city"
        Me.xlk_city.PopupSize = New System.Drawing.Size(500, 300)
        Me.xlk_city.ShowFilter = True
        Me.xlk_city.ShowMessageNotFound = True
        Me.xlk_city.ShowWarning = False
        Me.xlk_city.Size = New System.Drawing.Size(16, 20)
        Me.xlk_city.SizesColumns = Nothing
        Me.xlk_city.SizesColumnsTab = Nothing
        Me.xlk_city.SqlString = Nothing
        Me.xlk_city.SQLTab = Nothing
        Me.xlk_city.SrcParameters = New String() {"city_code=city_code"}
        Me.xlk_city.TabIndex = 45
        Me.xlk_city.TableName = "cccity"
        Me.xlk_city.TabStop = False
        Me.xlk_city.UseCopyConnection = False
        Me.xlk_city.UseRowRetrieveEvents = False
        Me.xlk_city.UseTab = False
        Me.xlk_city.VisParameters = New String() {"Código=city_code", "Descripción=city_name"}
        Me.xlk_city.WhereCondition = Nothing
        Me.xlk_city.WhereParameters = Nothing
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(64, 136)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(43, 16)
        Me.Label32.TabIndex = 43
        Me.Label32.Text = "Ciudad:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtcity_code
        '
        Me.txtcity_code.AcceptsReturn = True
        Me.txtcity_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.city_code"))
        Me.txtcity_code.EditInitialValue = Nothing
        Me.txtcity_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcity_code.FieldDescription = ""
        Me.txtcity_code.FindInitialValue = Nothing
        Me.txtcity_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcity_code.IgnoreRequiered = False
        Me.txtcity_code.Location = New System.Drawing.Point(120, 136)
        Me.txtcity_code.Name = "txtcity_code"
        Me.txtcity_code.NewInitialValue = Nothing
        Me.txtcity_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcity_code.Requiered = False
        Me.txtcity_code.Size = New System.Drawing.Size(56, 20)
        Me.txtcity_code.StatusBarPanelDescripcion = Nothing
        Me.txtcity_code.TabIndex = 6
        Me.txtcity_code.Text = ""
        '
        'txtcity_name
        '
        Me.txtcity_name.AcceptsReturn = True
        Me.txtcity_name.EditInitialValue = Nothing
        Me.txtcity_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcity_name.FieldDescription = ""
        Me.txtcity_name.FindInitialValue = Nothing
        Me.txtcity_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcity_name.IgnoreRequiered = False
        Me.txtcity_name.Location = New System.Drawing.Point(176, 136)
        Me.txtcity_name.Name = "txtcity_name"
        Me.txtcity_name.NewInitialValue = Nothing
        Me.txtcity_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcity_name.ReadOnly = True
        Me.txtcity_name.Requiered = False
        Me.txtcity_name.Size = New System.Drawing.Size(328, 20)
        Me.txtcity_name.StatusBarPanelDescripcion = Nothing
        Me.txtcity_name.TabIndex = 44
        Me.txtcity_name.TabStop = False
        Me.txtcity_name.Text = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label26.Location = New System.Drawing.Point(8, 88)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(101, 16)
        Me.Label26.TabIndex = 41
        Me.Label26.Text = "Dirección Principal:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox5
        '
        Me.TextBox5.AcceptsReturn = True
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.cust_address"))
        Me.TextBox5.EditInitialValue = Nothing
        Me.TextBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox5.FieldDescription = ""
        Me.TextBox5.FindInitialValue = Nothing
        Me.TextBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox5.IgnoreRequiered = False
        Me.TextBox5.Location = New System.Drawing.Point(120, 88)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.NewInitialValue = Nothing
        Me.TextBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox5.Requiered = False
        Me.TextBox5.Size = New System.Drawing.Size(384, 40)
        Me.TextBox5.StatusBarPanelDescripcion = Nothing
        Me.TextBox5.TabIndex = 5
        Me.TextBox5.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(176, 232)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 16)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "% de Descuento:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 232)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 16)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Días de descuento:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(288, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Estatus:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_cust_status
        '
        Me.xcbo_cust_status.AllowDefaultSort = True
        Me.xcbo_cust_status.bound = True
        Me.xcbo_cust_status.currValue = Nothing
        Me.xcbo_cust_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cccustm.cust_status"))
        Me.xcbo_cust_status.DefaultWhereString = Nothing
        Me.xcbo_cust_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_cust_status.EditInitialValue = Nothing
        Me.xcbo_cust_status.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_cust_status.FieldDescription = ""
        Me.xcbo_cust_status.FindInitialValue = Nothing
        Me.xcbo_cust_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_cust_status.IgnoreRequiered = False
        Me.xcbo_cust_status.Items.AddRange(New Object() {"0-Inactivo", "1-Activo", "2-Suspendido"})
        Me.xcbo_cust_status.Location = New System.Drawing.Point(336, 16)
        Me.xcbo_cust_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_cust_status.LookupKeyField = Nothing
        Me.xcbo_cust_status.LookupTableName = Nothing
        Me.xcbo_cust_status.Name = "xcbo_cust_status"
        Me.xcbo_cust_status.NewInitialValue = "1"
        Me.xcbo_cust_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_cust_status.Requiered = False
        Me.xcbo_cust_status.Required = False
        Me.xcbo_cust_status.Size = New System.Drawing.Size(128, 21)
        Me.xcbo_cust_status.SqlString = Nothing
        Me.xcbo_cust_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_cust_status.TabIndex = 11
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"TextBox4=csttype_code", "csttype_name=csttype_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(504, 184)
        Me.LibXLookup1.LookCaption = Nothing
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.PopupSize = New System.Drawing.Size(500, 300)
        Me.LibXLookup1.ShowFilter = True
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.ShowWarning = False
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SizesColumns = Nothing
        Me.LibXLookup1.SizesColumnsTab = Nothing
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"csttype_code=csttype_code"}
        Me.LibXLookup1.TabIndex = 19
        Me.LibXLookup1.TableName = "cccsttpm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=csttype_code", "Descripción=csttype_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Código:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox3
        '
        Me.TextBox3.AcceptsReturn = True
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.contact_name"))
        Me.TextBox3.EditInitialValue = Nothing
        Me.TextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.FieldDescription = ""
        Me.TextBox3.FindInitialValue = Nothing
        Me.TextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.IgnoreRequiered = False
        Me.TextBox3.Location = New System.Drawing.Point(120, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.NewInitialValue = Nothing
        Me.TextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.Requiered = False
        Me.TextBox3.Size = New System.Drawing.Size(160, 20)
        Me.TextBox3.StatusBarPanelDescripcion = Nothing
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Contacto:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Tipo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox4
        '
        Me.TextBox4.AcceptsReturn = True
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.csttype_code"))
        Me.TextBox4.EditInitialValue = Nothing
        Me.TextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.FieldDescription = ""
        Me.TextBox4.FindInitialValue = Nothing
        Me.TextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.IgnoreRequiered = False
        Me.TextBox4.Location = New System.Drawing.Point(120, 184)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.NewInitialValue = Nothing
        Me.TextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.Requiered = False
        Me.TextBox4.Size = New System.Drawing.Size(56, 20)
        Me.TextBox4.StatusBarPanelDescripcion = Nothing
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.Text = ""
        '
        'csttype_name
        '
        Me.csttype_name.AcceptsReturn = True
        Me.csttype_name.EditInitialValue = Nothing
        Me.csttype_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.csttype_name.FieldDescription = ""
        Me.csttype_name.FindInitialValue = Nothing
        Me.csttype_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.csttype_name.IgnoreRequiered = False
        Me.csttype_name.Location = New System.Drawing.Point(176, 184)
        Me.csttype_name.Name = "csttype_name"
        Me.csttype_name.NewInitialValue = Nothing
        Me.csttype_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.csttype_name.ReadOnly = True
        Me.csttype_name.Requiered = False
        Me.csttype_name.Size = New System.Drawing.Size(328, 20)
        Me.csttype_name.StatusBarPanelDescripcion = Nothing
        Me.csttype_name.TabIndex = 16
        Me.csttype_name.TabStop = False
        Me.csttype_name.Text = ""
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
        Me.LibXLookup2.Location = New System.Drawing.Point(504, 208)
        Me.LibXLookup2.LookCaption = "Términos de venta"
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.PopupSize = New System.Drawing.Size(600, 400)
        Me.LibXLookup2.ShowFilter = True
        Me.LibXLookup2.ShowMessageNotFound = True
        Me.LibXLookup2.ShowWarning = False
        Me.LibXLookup2.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup2.SizesColumns = New String() {"term_name=200"}
        Me.LibXLookup2.SizesColumnsTab = Nothing
        Me.LibXLookup2.SqlString = Nothing
        Me.LibXLookup2.SQLTab = Nothing
        Me.LibXLookup2.SrcParameters = New String() {"term_code=term_code"}
        Me.LibXLookup2.TabIndex = 20
        Me.LibXLookup2.TableName = "cctermm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=term_code", "Descripción=term_name", "% de descuento=disc_pct", "Días de descuento=disc_days", "Días de Vencimiento=due_days"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Terminos:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox6
        '
        Me.TextBox6.AcceptsReturn = True
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.term_code"))
        Me.TextBox6.EditInitialValue = Nothing
        Me.TextBox6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox6.FieldDescription = ""
        Me.TextBox6.FindInitialValue = Nothing
        Me.TextBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox6.IgnoreRequiered = False
        Me.TextBox6.Location = New System.Drawing.Point(120, 208)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.NewInitialValue = Nothing
        Me.TextBox6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox6.Requiered = False
        Me.TextBox6.Size = New System.Drawing.Size(56, 20)
        Me.TextBox6.StatusBarPanelDescripcion = Nothing
        Me.TextBox6.TabIndex = 9
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
        Me.term_name.Location = New System.Drawing.Point(176, 208)
        Me.term_name.Name = "term_name"
        Me.term_name.NewInitialValue = Nothing
        Me.term_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.term_name.ReadOnly = True
        Me.term_name.Requiered = False
        Me.term_name.Size = New System.Drawing.Size(328, 20)
        Me.term_name.StatusBarPanelDescripcion = Nothing
        Me.term_name.TabIndex = 18
        Me.term_name.TabStop = False
        Me.term_name.Text = ""
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
        Me.vend_name.Location = New System.Drawing.Point(176, 256)
        Me.vend_name.Name = "vend_name"
        Me.vend_name.NewInitialValue = Nothing
        Me.vend_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.vend_name.ReadOnly = True
        Me.vend_name.Requiered = False
        Me.vend_name.Size = New System.Drawing.Size(328, 20)
        Me.vend_name.StatusBarPanelDescripcion = Nothing
        Me.vend_name.TabIndex = 32
        Me.vend_name.TabStop = False
        Me.vend_name.Text = ""
        '
        'TextBox9
        '
        Me.TextBox9.AcceptsReturn = True
        Me.TextBox9.CausesValidation = False
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.vend_code"))
        Me.TextBox9.EditInitialValue = Nothing
        Me.TextBox9.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox9.FieldDescription = ""
        Me.TextBox9.FindInitialValue = Nothing
        Me.TextBox9.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox9.HideSelection = False
        Me.TextBox9.IgnoreRequiered = True
        Me.TextBox9.Location = New System.Drawing.Point(120, 256)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.NewInitialValue = ""
        Me.TextBox9.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox9.Requiered = False
        Me.TextBox9.Size = New System.Drawing.Size(56, 20)
        Me.TextBox9.StatusBarPanelDescripcion = Nothing
        Me.TextBox9.TabIndex = 9
        Me.TextBox9.Text = ""
        '
        'LibXLookup3
        '
        Me.LibXLookup3.AlternateFieldSearch = Nothing
        Me.LibXLookup3.BeginCheck = False
        Me.LibXLookup3.CheckText = Nothing
        Me.LibXLookup3.ComboMode = False
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Me.LibXConnector1
        Me.LibXLookup3.DestParameters = New String() {"vend_code=vend_code", "vend_name=vend_name"}
        Me.LibXLookup3.FilterField = Nothing
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.isCanceled = False
        Me.LibXLookup3.Location = New System.Drawing.Point(504, 256)
        Me.LibXLookup3.LookCaption = "Vendedores"
        Me.LibXLookup3.Name = "LibXLookup3"
        Me.LibXLookup3.PopupSize = New System.Drawing.Size(600, 400)
        Me.LibXLookup3.ShowFilter = True
        Me.LibXLookup3.ShowMessageNotFound = True
        Me.LibXLookup3.ShowWarning = False
        Me.LibXLookup3.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup3.SizesColumns = Nothing
        Me.LibXLookup3.SizesColumnsTab = Nothing
        Me.LibXLookup3.SqlString = Nothing
        Me.LibXLookup3.SQLTab = Nothing
        Me.LibXLookup3.SrcParameters = New String() {"vend_code=vend_code"}
        Me.LibXLookup3.TabIndex = 33
        Me.LibXLookup3.TableName = "ftvendm"
        Me.LibXLookup3.TabStop = False
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.UseTab = False
        Me.LibXLookup3.VisParameters = New String() {"Código=vend_code", "Nombre=vend_name"}
        Me.LibXLookup3.WhereCondition = Nothing
        Me.LibXLookup3.WhereParameters = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Vendedor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LibxCheckBox7)
        Me.GroupBox3.Controls.Add(Me.LibxCheckBox6)
        Me.GroupBox3.Controls.Add(Me.xck_cust_costo)
        Me.GroupBox3.Controls.Add(Me.LibxCheckBox5)
        Me.GroupBox3.Controls.Add(Me.LibxCheckBox1)
        Me.GroupBox3.Controls.Add(Me.LibxCheckBox2)
        Me.GroupBox3.Controls.Add(Me.LibxCheckBox3)
        Me.GroupBox3.Controls.Add(Me.LibxCheckBox4)
        Me.GroupBox3.Location = New System.Drawing.Point(520, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 148)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'LibxCheckBox7
        '
        Me.LibxCheckBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox7.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "cccustm.otro_dsct"))
        Me.LibxCheckBox7.EditInitialValue = Nothing
        Me.LibxCheckBox7.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox7.FindInitialValue = Nothing
        Me.LibxCheckBox7.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LibxCheckBox7.IgnoreRequiered = False
        Me.LibxCheckBox7.KeepEnabled = False
        Me.LibxCheckBox7.Location = New System.Drawing.Point(8, 128)
        Me.LibxCheckBox7.Name = "LibxCheckBox7"
        Me.LibxCheckBox7.NewInitialValue = Nothing
        Me.LibxCheckBox7.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox7.ReadOnly = False
        Me.LibxCheckBox7.Requiered = False
        Me.LibxCheckBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox7.Size = New System.Drawing.Size(176, 16)
        Me.LibxCheckBox7.TabIndex = 7
        Me.LibxCheckBox7.Text = "Aplica Otro Descuento"
        Me.LibxCheckBox7.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox7.ThreeState = True
        Me.LibxCheckBox7.value = Nothing
        '
        'LibxCheckBox6
        '
        Me.LibxCheckBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "cccustm.web_transf"))
        Me.LibxCheckBox6.EditInitialValue = Nothing
        Me.LibxCheckBox6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox6.FindInitialValue = Nothing
        Me.LibxCheckBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LibxCheckBox6.IgnoreRequiered = False
        Me.LibxCheckBox6.KeepEnabled = False
        Me.LibxCheckBox6.Location = New System.Drawing.Point(8, 112)
        Me.LibxCheckBox6.Name = "LibxCheckBox6"
        Me.LibxCheckBox6.NewInitialValue = Nothing
        Me.LibxCheckBox6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox6.ReadOnly = False
        Me.LibxCheckBox6.Requiered = False
        Me.LibxCheckBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox6.Size = New System.Drawing.Size(176, 16)
        Me.LibxCheckBox6.TabIndex = 6
        Me.LibxCheckBox6.Text = "Acepta Transferencia"
        Me.LibxCheckBox6.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox6.ThreeState = True
        Me.LibxCheckBox6.value = Nothing
        '
        'xck_cust_costo
        '
        Me.xck_cust_costo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xck_cust_costo.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "cccustm.cust_costo"))
        Me.xck_cust_costo.EditInitialValue = Nothing
        Me.xck_cust_costo.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_cust_costo.FindInitialValue = Nothing
        Me.xck_cust_costo.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_cust_costo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.xck_cust_costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xck_cust_costo.ForeColor = System.Drawing.Color.Red
        Me.xck_cust_costo.IgnoreRequiered = False
        Me.xck_cust_costo.KeepEnabled = False
        Me.xck_cust_costo.Location = New System.Drawing.Point(8, 96)
        Me.xck_cust_costo.Name = "xck_cust_costo"
        Me.xck_cust_costo.NewInitialValue = "0"
        Me.xck_cust_costo.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_cust_costo.ReadOnly = False
        Me.xck_cust_costo.Requiered = False
        Me.xck_cust_costo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xck_cust_costo.Size = New System.Drawing.Size(176, 16)
        Me.xck_cust_costo.TabIndex = 5
        Me.xck_cust_costo.Text = "Facturar al Costo"
        Me.xck_cust_costo.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.xck_cust_costo.ThreeState = True
        Me.xck_cust_costo.value = Nothing
        '
        'LibxCheckBox5
        '
        Me.LibxCheckBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "cccustm.cust_credito"))
        Me.LibxCheckBox5.EditInitialValue = Nothing
        Me.LibxCheckBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.FindInitialValue = Nothing
        Me.LibxCheckBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LibxCheckBox5.IgnoreRequiered = False
        Me.LibxCheckBox5.KeepEnabled = False
        Me.LibxCheckBox5.Location = New System.Drawing.Point(8, 80)
        Me.LibxCheckBox5.Name = "LibxCheckBox5"
        Me.LibxCheckBox5.NewInitialValue = Nothing
        Me.LibxCheckBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.ReadOnly = False
        Me.LibxCheckBox5.Requiered = False
        Me.LibxCheckBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox5.Size = New System.Drawing.Size(176, 16)
        Me.LibxCheckBox5.TabIndex = 4
        Me.LibxCheckBox5.Text = "Vender a Crédito"
        Me.LibxCheckBox5.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox5.ThreeState = True
        Me.LibxCheckBox5.value = Nothing
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "cccustm.stop_abono"))
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(8, 16)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = Nothing
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = False
        Me.LibxCheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox1.Size = New System.Drawing.Size(176, 16)
        Me.LibxCheckBox1.TabIndex = 0
        Me.LibxCheckBox1.Text = "Suspender venta x abono"
        Me.LibxCheckBox1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'LibxCheckBox2
        '
        Me.LibxCheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "cccustm.stop_cheque"))
        Me.LibxCheckBox2.EditInitialValue = Nothing
        Me.LibxCheckBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.FindInitialValue = Nothing
        Me.LibxCheckBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LibxCheckBox2.IgnoreRequiered = False
        Me.LibxCheckBox2.KeepEnabled = False
        Me.LibxCheckBox2.Location = New System.Drawing.Point(8, 64)
        Me.LibxCheckBox2.Name = "LibxCheckBox2"
        Me.LibxCheckBox2.NewInitialValue = Nothing
        Me.LibxCheckBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.ReadOnly = False
        Me.LibxCheckBox2.Requiered = False
        Me.LibxCheckBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox2.Size = New System.Drawing.Size(176, 16)
        Me.LibxCheckBox2.TabIndex = 3
        Me.LibxCheckBox2.Text = "Suspender venta x Ck devuelto"
        Me.LibxCheckBox2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox2.ThreeState = True
        Me.LibxCheckBox2.value = Nothing
        '
        'LibxCheckBox3
        '
        Me.LibxCheckBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "cccustm.stop_venct"))
        Me.LibxCheckBox3.EditInitialValue = Nothing
        Me.LibxCheckBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.FindInitialValue = Nothing
        Me.LibxCheckBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LibxCheckBox3.IgnoreRequiered = False
        Me.LibxCheckBox3.KeepEnabled = False
        Me.LibxCheckBox3.Location = New System.Drawing.Point(8, 32)
        Me.LibxCheckBox3.Name = "LibxCheckBox3"
        Me.LibxCheckBox3.NewInitialValue = Nothing
        Me.LibxCheckBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.ReadOnly = False
        Me.LibxCheckBox3.Requiered = False
        Me.LibxCheckBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox3.Size = New System.Drawing.Size(176, 16)
        Me.LibxCheckBox3.TabIndex = 1
        Me.LibxCheckBox3.Text = "Suspender venta x vencimiento"
        Me.LibxCheckBox3.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox3.ThreeState = True
        Me.LibxCheckBox3.value = Nothing
        '
        'LibxCheckBox4
        '
        Me.LibxCheckBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "cccustm.cust_pricemajor"))
        Me.LibxCheckBox4.EditInitialValue = Nothing
        Me.LibxCheckBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.FindInitialValue = Nothing
        Me.LibxCheckBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LibxCheckBox4.IgnoreRequiered = False
        Me.LibxCheckBox4.KeepEnabled = False
        Me.LibxCheckBox4.Location = New System.Drawing.Point(8, 48)
        Me.LibxCheckBox4.Name = "LibxCheckBox4"
        Me.LibxCheckBox4.NewInitialValue = Nothing
        Me.LibxCheckBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.ReadOnly = False
        Me.LibxCheckBox4.Requiered = False
        Me.LibxCheckBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox4.Size = New System.Drawing.Size(176, 16)
        Me.LibxCheckBox4.TabIndex = 2
        Me.LibxCheckBox4.Text = "Usar Precio x mayor"
        Me.LibxCheckBox4.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox4.ThreeState = True
        Me.LibxCheckBox4.value = Nothing
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(8, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Límite de Crédito:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtcredit_limit
        '
        Me.txtcredit_limit.AcceptsReturn = True
        Me.txtcredit_limit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.credit_limit"))
        Me.txtcredit_limit.EditInitialValue = Nothing
        Me.txtcredit_limit.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcredit_limit.FieldDescription = ""
        Me.txtcredit_limit.FindInitialValue = Nothing
        Me.txtcredit_limit.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcredit_limit.IgnoreRequiered = False
        Me.txtcredit_limit.Location = New System.Drawing.Point(120, 280)
        Me.txtcredit_limit.Name = "txtcredit_limit"
        Me.txtcredit_limit.NewInitialValue = Nothing
        Me.txtcredit_limit.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcredit_limit.Requiered = False
        Me.txtcredit_limit.Size = New System.Drawing.Size(120, 20)
        Me.txtcredit_limit.StatusBarPanelDescripcion = Nothing
        Me.txtcredit_limit.TabIndex = 10
        Me.txtcredit_limit.Text = ""
        Me.txtcredit_limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(288, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Balance:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txt_bal
        '
        Me.Txt_bal.AcceptsReturn = True
        Me.Txt_bal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.balance"))
        Me.Txt_bal.EditInitialValue = Nothing
        Me.Txt_bal.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.Txt_bal.FieldDescription = ""
        Me.Txt_bal.FindInitialValue = Nothing
        Me.Txt_bal.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Txt_bal.IgnoreRequiered = False
        Me.Txt_bal.Location = New System.Drawing.Point(344, 280)
        Me.Txt_bal.Name = "Txt_bal"
        Me.Txt_bal.NewInitialValue = "0.00"
        Me.Txt_bal.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.Txt_bal.Requiered = False
        Me.Txt_bal.Size = New System.Drawing.Size(120, 20)
        Me.Txt_bal.StatusBarPanelDescripcion = Nothing
        Me.Txt_bal.TabIndex = 11
        Me.Txt_bal.TabStop = False
        Me.Txt_bal.Text = ""
        Me.Txt_bal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(506, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 16)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Días de gracias:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox12
        '
        Me.TextBox12.AcceptsReturn = True
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.day_benef"))
        Me.TextBox12.EditInitialValue = Nothing
        Me.TextBox12.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox12.FieldDescription = ""
        Me.TextBox12.FindInitialValue = Nothing
        Me.TextBox12.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox12.IgnoreRequiered = False
        Me.TextBox12.Location = New System.Drawing.Point(600, 234)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.NewInitialValue = Nothing
        Me.TextBox12.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox12.Requiered = False
        Me.TextBox12.Size = New System.Drawing.Size(48, 20)
        Me.TextBox12.StatusBarPanelDescripcion = Nothing
        Me.TextBox12.TabIndex = 17
        Me.TextBox12.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(522, 258)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 16)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Ultimo Pago:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox13
        '
        Me.TextBox13.AcceptsReturn = True
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.last_pay_date"))
        Me.TextBox13.EditInitialValue = Nothing
        Me.TextBox13.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox13.Enabled = False
        Me.TextBox13.FieldDescription = ""
        Me.TextBox13.FindInitialValue = Nothing
        Me.TextBox13.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox13.IgnoreRequiered = False
        Me.TextBox13.Location = New System.Drawing.Point(600, 258)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.NewInitialValue = Nothing
        Me.TextBox13.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Requiered = False
        Me.TextBox13.Size = New System.Drawing.Size(112, 20)
        Me.TextBox13.StatusBarPanelDescripcion = Nothing
        Me.TextBox13.TabIndex = 35
        Me.TextBox13.TabStop = False
        Me.TextBox13.Text = ""
        '
        'TextBox14
        '
        Me.TextBox14.AcceptsReturn = True
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.last_sell_date"))
        Me.TextBox14.EditInitialValue = Nothing
        Me.TextBox14.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox14.Enabled = False
        Me.TextBox14.FieldDescription = ""
        Me.TextBox14.FindInitialValue = Nothing
        Me.TextBox14.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox14.IgnoreRequiered = False
        Me.TextBox14.Location = New System.Drawing.Point(600, 282)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.NewInitialValue = Nothing
        Me.TextBox14.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Requiered = False
        Me.TextBox14.Size = New System.Drawing.Size(112, 20)
        Me.TextBox14.StatusBarPanelDescripcion = Nothing
        Me.TextBox14.TabIndex = 36
        Me.TextBox14.TabStop = False
        Me.TextBox14.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(519, 282)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Ultima Venta:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.disc_days.Location = New System.Drawing.Point(120, 232)
        Me.disc_days.Name = "disc_days"
        Me.disc_days.NewInitialValue = Nothing
        Me.disc_days.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.disc_days.ReadOnly = True
        Me.disc_days.Requiered = False
        Me.disc_days.Size = New System.Drawing.Size(56, 20)
        Me.disc_days.StatusBarPanelDescripcion = Nothing
        Me.disc_days.TabIndex = 8
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
        Me.disc_pct.Location = New System.Drawing.Point(272, 232)
        Me.disc_pct.Name = "disc_pct"
        Me.disc_pct.NewInitialValue = Nothing
        Me.disc_pct.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.disc_pct.ReadOnly = True
        Me.disc_pct.Requiered = False
        Me.disc_pct.Size = New System.Drawing.Size(40, 20)
        Me.disc_pct.StatusBarPanelDescripcion = Nothing
        Me.disc_pct.TabIndex = 27
        Me.disc_pct.TabStop = False
        Me.disc_pct.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(320, 232)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 16)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Días vencimiento:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.due_days.Location = New System.Drawing.Point(424, 232)
        Me.due_days.Name = "due_days"
        Me.due_days.NewInitialValue = Nothing
        Me.due_days.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.due_days.ReadOnly = True
        Me.due_days.Requiered = False
        Me.due_days.Size = New System.Drawing.Size(40, 20)
        Me.due_days.StatusBarPanelDescripcion = Nothing
        Me.due_days.TabIndex = 29
        Me.due_days.TabStop = False
        Me.due_days.Text = ""
        '
        'TextBox15
        '
        Me.TextBox15.AcceptsReturn = True
        Me.TextBox15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.rnc_id"))
        Me.TextBox15.EditInitialValue = Nothing
        Me.TextBox15.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox15.FieldDescription = ""
        Me.TextBox15.FindInitialValue = Nothing
        Me.TextBox15.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox15.IgnoreRequiered = False
        Me.TextBox15.Location = New System.Drawing.Point(600, 210)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.NewInitialValue = Nothing
        Me.TextBox15.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox15.Requiered = False
        Me.TextBox15.Size = New System.Drawing.Size(112, 20)
        Me.TextBox15.StatusBarPanelDescripcion = Nothing
        Me.TextBox15.TabIndex = 16
        Me.TextBox15.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Location = New System.Drawing.Point(511, 210)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 16)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "RNC o Cédula:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_phone
        '
        Me.xtxt_phone.AcceptsReturn = True
        Me.xtxt_phone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_phone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.cust_phone"))
        Me.xtxt_phone.EditInitialValue = Nothing
        Me.xtxt_phone.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_phone.FieldDescription = ""
        Me.xtxt_phone.FindInitialValue = Nothing
        Me.xtxt_phone.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_phone.IgnoreRequiered = False
        Me.xtxt_phone.Location = New System.Drawing.Point(600, 162)
        Me.xtxt_phone.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.xtxt_phone.Name = "xtxt_phone"
        Me.xtxt_phone.NewInitialValue = Nothing
        Me.xtxt_phone.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_phone.Requiered = False
        Me.xtxt_phone.Size = New System.Drawing.Size(112, 20)
        Me.xtxt_phone.StatusBarPanelDescripcion = Nothing
        Me.xtxt_phone.TabIndex = 14
        Me.xtxt_phone.Text = ""
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label31.Location = New System.Drawing.Point(540, 162)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(51, 16)
        Me.Label31.TabIndex = 22
        Me.Label31.Text = "Teléfono:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.rtb_Nota)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(720, 358)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Seguimientos"
        '
        'rtb_Nota
        '
        Me.rtb_Nota.ContextMenu = Me.ContextMenu1
        Me.rtb_Nota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.cust_note"))
        Me.rtb_Nota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtb_Nota.Location = New System.Drawing.Point(0, 0)
        Me.rtb_Nota.Name = "rtb_Nota"
        Me.rtb_Nota.Size = New System.Drawing.Size(720, 358)
        Me.rtb_Nota.TabIndex = 0
        Me.rtb_Nota.Text = ""
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem1})
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Nuevo Seguimiento"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.Text = "Limpiar"
        '
        'i_custrm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(746, 536)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnTipos)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.btnTerminos)
        Me.Controls.Add(Me.btnMovimientos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_custrm01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Clientes"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Credit_Limit As Decimal
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams
            oParam.Value = LibXConnector1.CurrentDataRow!cust_code
            oParam.WhereToExecute = "cust_code = " & LibXConnector1.CurrentDataRow!cust_code.ToString
            oParam.IsFromOther = True
            LibX.App.CurrentPrgParams = oParam

            LibX.LibXRunner.Run("i_custaddr", "CXC")

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTipos.Click
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams
            oParam.IsFromOther = True
            LibX.LibXRunner.Run("i_cccsttpm01", "CXC", True)

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminos.Click
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams
            oParam.IsFromOther = True
            LibX.LibXRunner.Run("i_ccterm01", "CXC", True)

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams
            oParam.IsFromOther = True
            LibX.LibXRunner.Run("i_ftvend01", "FCT")

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub i_custrm01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'oPermission = New SGT.Administracion.Entidades.Permission

        dtpdateCreate.Value = Now
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        btnMovimientos.Enabled = Not LibXConnector1.IsEditing And LibXConnector1.HasRecords = True
        Dim program As SGT.Administracion.Entidades.Permiso
        Try
            program = New SGT.Administracion.Entidades.Permiso(LibX.User.UserID, "i_custrm01")
            LibXConnector1.AllowNew = program.Agregar
            LibXConnector1.AllowEdit = program.Editar
            LibXConnector1.AllowDelete = program.Borrar
            LibXConnector1.AllowQuery = program.Buscar
            LibXConnector1.AllowPrint = program.Imprimir

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibX.LibxConnectionActions.Find Then
                Me.xcbo_cust_status.currValue = 1
            End If
            If e.Action = LibX.LibxConnectionActions.Add Then
                Me.Txt_bal.Text = 0.0
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub btnMovimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMovimientos.Click
        Dim oParam As LibX.LibxPrgParams

        Dim WhereStmt As String
        Try
            oParam = New LibX.LibxPrgParams

            oParam.WhereToExecute = "ccinvcem.cust_code = " & LibXConnector1.CurrentDataRow!cust_code.ToString
            LibX.App.CurrentPrgParams = oParam

            LibX.LibXRunner.Run("c_ccdocs01", "CXC", True)
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub TextBox10_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcredit_limit.Validated
        Try
            If LibXConnector1.IsDataEditing = True Then
                'If Credit_Limit <> Val(Me.txtcredit_limit.Text.Trim) Then
                '    If oPermission.isAutorization(Permission.TipoAutorizacionEnum.VerCostos) = False Then
                '        txtcredit_limit.Text = Credit_Limit
                '        Throw New ApplicationException("Autorización Inválida!")
                '    End If
                '    Credit_Limit = Val(Me.txtcredit_limit.Text.Trim)
                'End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub txtcredit_limit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcredit_limit.GotFocus
        Credit_Limit = Val(txtcredit_limit.Text)
    End Sub

    Private Sub LibxCheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xck_cust_costo.CheckedChanged
        Try
            If LibXConnector1.IsDataEditing = True And xck_cust_costo.Checked = True Then
                'If oPermission.isAutorization(Permission.TipoAutorizacionEnum.VerCostos) = False Then
                '    Me.xck_cust_costo.Checked = False
                '    Throw New ApplicationException("Autorización Inválida!")
                'End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub xlk_sector_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_sector.BeforeExecuteQuery
        Try
            If txtcity_code.Text.Length > 0 Then
                e.aditionalWhere = "city_code ='" & Me.txtcity_code.Text & "'"
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)

        End Try

    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert _
                Or e.UpdatingArgs.StatementType = StatementType.Update Then
                If LibXCombo1.SelectedValue <> 2 And Len(TextBox15.Text) <> 9 AndAlso Len(TextBox15.Text) <> 11 Then
                    Throw New ApplicationException("El rnc debe ser de 9 o de 11 digito sin guiones!")
                End If
            End If
        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub LibXCombo1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LibXCombo1.Validating
        If LibXCombo1.SelectedValue <> 2 Then
            TextBox15.Focus()
        End If
    End Sub
End Class
