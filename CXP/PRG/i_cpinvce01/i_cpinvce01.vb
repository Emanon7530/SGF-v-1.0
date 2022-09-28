Imports SGT.Inventario
Imports SGT.CXP.Entidades
Imports SGT.Contabilidad.Entidades

Public Class i_cpinvce01
    Inherits System.Windows.Forms.Form
    Dim oDocumento As Entidades.Documento
    Dim Conf As SGT.Inventario.Common.Configuration
    Dim oParamValidar As SGT.Administracion.Entidades.Permission.ParametrosValidar
    Dim oAutorizar As SGT.Administracion.Entidades.Permission
    Dim mMoneda As SGT.Inventario.Entidades.Documento.MonedaEnum
    Dim oTransacion As SGT.Inventario.Entidades.Documento
    Dim oSuplidor As SGT.CXP.Entidades.Suplidor
    Dim mSucursalAfacturar As Integer
    Dim Transf As Boolean = False
    Dim mTipo As String
    Dim oAlm As Integer
    Dim mMsn As Boolean
    Dim oAnoFiscal As SGT.Contabilidad.Entidades.AnoFiscal
    Dim oPeriodo As SGT.Contabilidad.Entidades.Periodo
    Dim oCodif As SGT.Contabilidad.Entidades.Codificacion

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As LibX.XTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents xlk_type_code As LibX.LibXLookup
    Friend WithEvents type_name As LibX.XTextBox
    Friend WithEvents txtinvce_no As LibX.XTextBox
    Friend WithEvents term_name As LibX.XTextBox
    Friend WithEvents xlk_term_code As LibX.LibXLookup
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents xcbo_invce_status As LibX.LibXCombo
    Friend WithEvents xdtp_due_date As LibX.LibxDateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnDetalle As System.Windows.Forms.Button
    Friend WithEvents btnTermino As System.Windows.Forms.Button
    Friend WithEvents lnk_Cliente As System.Windows.Forms.LinkLabel
    Friend WithEvents disc_days As LibX.XTextBox
    Friend WithEvents due_days As LibX.XTextBox
    Friend WithEvents disc_pct As LibX.XTextBox
    Friend WithEvents xdtp_invce_date As LibX.LibxDateTimePicker
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents txttotal_amount As LibX.XTextBox
    Friend WithEvents txtitbis As LibX.XTextBox
    Friend WithEvents txtamount As LibX.XTextBox
    Friend WithEvents txtExcento As LibX.XTextBox
    Friend WithEvents txtGrabado As LibX.XTextBox
    Friend WithEvents TextBox2 As LibX.XTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtterm_code As LibX.XTextBox
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents btnMov As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents xtxt_discamount As LibX.XTextBox
    Friend WithEvents xtxt_type_code As LibX.XTextBox
    Friend WithEvents xtxt_invce_ncf As LibX.XTextBox
    Friend WithEvents xtxsuc_code As LibX.XTextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents sucname As LibX.XTextBox
    Friend WithEvents klk_suc_code As LibX.LibXLookup
    Friend WithEvents btndevol As System.Windows.Forms.Button
    Friend WithEvents btnTransf As System.Windows.Forms.Button
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents xtxacct_no As LibX.XTextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtitbisRetenido As LibX.XTextBox
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents dgc_acct_no As LibX.XDataGridTextButtonColumn
    Friend WithEvents xdb_depto As LibX.XEditTextBoxColumn
    Friend WithEvents dgc_tran_descr As LibX.XEditTextBoxColumn
    Friend WithEvents dgc_debit_amount As LibX.XEditTextBoxColumn
    Friend WithEvents dgc_credit_amount As LibX.XEditTextBoxColumn
    Friend WithEvents xlk_acct_no As LibX.LibXLookup
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents cpinvced As System.Data.DataTable
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
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
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents xtmtotal As LibX.XTextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo2 As LibX.LibXCombo
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents xtxTasa As LibX.XTextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents txtprov_code As LibX.XTextBox
    Friend WithEvents lkp_prov_code As LibX.LibXLookup
    Friend WithEvents xtxprov_name As LibX.XTextBox
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents xtx_isr As LibX.XTextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(i_cpinvce01))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xtx_isr = New LibX.XTextBox
        Me.DataSet1 = New System.Data.DataSet
        Me.cpinvced = New System.Data.DataTable
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
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.Label28 = New System.Windows.Forms.Label
        Me.lkp_prov_code = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.txtprov_code = New LibX.XTextBox
        Me.xtxTasa = New LibX.XTextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.LibXCombo2 = New LibX.LibXCombo
        Me.xtmtotal = New LibX.XTextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtitbisRetenido = New LibX.XTextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.xtxacct_no = New LibX.XTextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.btnTransf = New System.Windows.Forms.Button
        Me.klk_suc_code = New LibX.LibXLookup
        Me.xtxsuc_code = New LibX.XTextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.sucname = New LibX.XTextBox
        Me.lnk_Cliente = New System.Windows.Forms.LinkLabel
        Me.xdtp_due_date = New LibX.LibxDateTimePicker
        Me.xcbo_invce_status = New LibX.LibXCombo
        Me.xlk_type_code = New LibX.LibXLookup
        Me.xdtp_invce_date = New LibX.LibxDateTimePicker
        Me.xtxt_type_code = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.type_name = New LibX.XTextBox
        Me.txtinvce_no = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.term_name = New LibX.XTextBox
        Me.txtterm_code = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.xtxprov_name = New LibX.XTextBox
        Me.TextBox8 = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txttotal_amount = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.xlk_term_code = New LibX.LibXLookup
        Me.Label10 = New System.Windows.Forms.Label
        Me.disc_days = New LibX.XTextBox
        Me.due_days = New LibX.XTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.disc_pct = New LibX.XTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtitbis = New LibX.XTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtamount = New LibX.XTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtExcento = New LibX.XTextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtGrabado = New LibX.XTextBox
        Me.TextBox2 = New LibX.XTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.xtxt_invce_ncf = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.xtxt_discamount = New LibX.XTextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.btndevol = New System.Windows.Forms.Button
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.btnDetalle = New System.Windows.Forms.Button
        Me.btnTermino = New System.Windows.Forms.Button
        Me.btnMov = New System.Windows.Forms.Button
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.dgc_acct_no = New LibX.XDataGridTextButtonColumn
        Me.xlk_acct_no = New LibX.LibXLookup
        Me.xdb_depto = New LibX.XEditTextBoxColumn
        Me.dgc_tran_descr = New LibX.XEditTextBoxColumn
        Me.dgc_debit_amount = New LibX.XEditTextBoxColumn
        Me.dgc_credit_amount = New LibX.XEditTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpinvced, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xtx_isr)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.lkp_prov_code)
        Me.GroupBox1.Controls.Add(Me.txtprov_code)
        Me.GroupBox1.Controls.Add(Me.xtxTasa)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.LibXCombo2)
        Me.GroupBox1.Controls.Add(Me.xtmtotal)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.txtitbisRetenido)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.xtxacct_no)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.btnTransf)
        Me.GroupBox1.Controls.Add(Me.klk_suc_code)
        Me.GroupBox1.Controls.Add(Me.xtxsuc_code)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.sucname)
        Me.GroupBox1.Controls.Add(Me.lnk_Cliente)
        Me.GroupBox1.Controls.Add(Me.xdtp_due_date)
        Me.GroupBox1.Controls.Add(Me.xcbo_invce_status)
        Me.GroupBox1.Controls.Add(Me.xlk_type_code)
        Me.GroupBox1.Controls.Add(Me.xdtp_invce_date)
        Me.GroupBox1.Controls.Add(Me.xtxt_type_code)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.type_name)
        Me.GroupBox1.Controls.Add(Me.txtinvce_no)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.term_name)
        Me.GroupBox1.Controls.Add(Me.txtterm_code)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xtxprov_name)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txttotal_amount)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.xlk_term_code)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.disc_days)
        Me.GroupBox1.Controls.Add(Me.due_days)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.disc_pct)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtitbis)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtamount)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtExcento)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtGrabado)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.xtxt_invce_ncf)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xtxt_discamount)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.btndevol)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 336)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'xtx_isr
        '
        Me.xtx_isr.AcceptsReturn = True
        Me.xtx_isr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.isr_retenido"))
        Me.xtx_isr.EditInitialValue = Nothing
        Me.xtx_isr.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtx_isr.FieldDescription = ""
        Me.xtx_isr.FindInitialValue = Nothing
        Me.xtx_isr.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtx_isr.IgnoreRequiered = False
        Me.xtx_isr.Location = New System.Drawing.Point(664, 200)
        Me.xtx_isr.Name = "xtx_isr"
        Me.xtx_isr.NewInitialValue = Nothing
        Me.xtx_isr.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtx_isr.Requiered = False
        Me.xtx_isr.Size = New System.Drawing.Size(112, 20)
        Me.xtx_isr.StatusBarPanelDescripcion = Nothing
        Me.xtx_isr.TabIndex = 67
        Me.xtx_isr.Text = ""
        Me.xtx_isr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.cpinvced, Me.DataTable1})
        '
        'cpinvced
        '
        Me.cpinvced.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39})
        Me.cpinvced.TableName = "cpinvced"
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "invce_serial"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.AllowDBNull = False
        Me.DataColumn31.ColumnName = "line_no"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.AllowDBNull = False
        Me.DataColumn32.ColumnName = "acct_no"
        Me.DataColumn32.MaxLength = 20
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "dept_code"
        Me.DataColumn33.DataType = GetType(System.Int32)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "debit_credit"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "amount"
        Me.DataColumn35.DataType = GetType(System.Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "suc_code"
        Me.DataColumn36.DataType = GetType(System.Int32)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "acct_name"
        Me.DataColumn37.MaxLength = 60
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "debit_amount"
        Me.DataColumn38.DataType = GetType(System.Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "credit_amount"
        Me.DataColumn39.DataType = GetType(System.Decimal)
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"invce_serial"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "cpinvcem"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "invce_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "term_code"
        Me.DataColumn2.MaxLength = 5
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "prov_code"
        Me.DataColumn3.MaxLength = 20
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "type_code"
        Me.DataColumn4.MaxLength = 3
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "doc_no"
        Me.DataColumn5.MaxLength = 20
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "invce_desc"
        Me.DataColumn6.MaxLength = 60
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "doc_date"
        Me.DataColumn7.DataType = GetType(System.DateTime)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "disc_date"
        Me.DataColumn8.DataType = GetType(System.DateTime)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "amount"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "disc_pct"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "due_date"
        Me.DataColumn11.DataType = GetType(System.DateTime)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "disc_amount"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "isc_amount"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "itbis"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "excento"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "impto"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "invce_status"
        Me.DataColumn17.DataType = GetType(System.Int32)
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
        Me.DataColumn20.ColumnName = "invce_ncf"
        Me.DataColumn20.MaxLength = 20
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "dev_serial"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "entr_serial"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "suc_code"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "invce_service"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "acct_no"
        Me.DataColumn25.MaxLength = 15
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "invce_datetran"
        Me.DataColumn26.DataType = GetType(System.DateTime)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "itbis_retenido"
        Me.DataColumn27.DataType = GetType(System.Decimal)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "tasaUS"
        Me.DataColumn28.DataType = GetType(System.Decimal)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "invce_ncfafect"
        Me.DataColumn29.MaxLength = 19
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "fecha_pago"
        Me.DataColumn40.DataType = GetType(System.DateTime)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "invce_cond"
        Me.DataColumn41.DataType = GetType(System.Int32)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "cbm_serial"
        Me.DataColumn42.DataType = GetType(System.Int32)
        '
        'DataColumn43
        '
        Me.DataColumn43.Caption = "mtotal"
        Me.DataColumn43.ColumnName = "mtotal"
        Me.DataColumn43.DataType = GetType(System.Decimal)
        Me.DataColumn43.ReadOnly = True
        '
        'DataColumn44
        '
        Me.DataColumn44.Caption = "mapagar"
        Me.DataColumn44.ColumnName = "mapagar"
        Me.DataColumn44.DataType = GetType(System.Decimal)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "amt"
        Me.DataColumn45.DataType = GetType(System.Decimal)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "balance"
        Me.DataColumn46.DataType = GetType(System.Decimal)
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "isr_retenido"
        Me.DataColumn47.DataType = GetType(System.Decimal)
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label28.Location = New System.Drawing.Point(586, 200)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(68, 16)
        Me.Label28.TabIndex = 68
        Me.Label28.Text = "Isr Retenido:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lkp_prov_code
        '
        Me.lkp_prov_code.AlternateFieldSearch = Nothing
        Me.lkp_prov_code.BeginCheck = False
        Me.lkp_prov_code.CheckText = Nothing
        Me.lkp_prov_code.ComboMode = False
        Me.lkp_prov_code.DataMember = Nothing
        Me.lkp_prov_code.DataSource = Me.LibXConnector1
        Me.lkp_prov_code.DestParameters = New String() {"txtprov_code=prov_code", "xtxprov_name=prov_name", "acct_no=acct_no", "txtterm_code=term_code"}
        Me.lkp_prov_code.FilterField = "prov_name"
        Me.lkp_prov_code.IgnoreFindInBrowseMode = False
        Me.lkp_prov_code.isCanceled = False
        Me.lkp_prov_code.Location = New System.Drawing.Point(544, 96)
        Me.lkp_prov_code.LookCaption = ""
        Me.lkp_prov_code.Name = "lkp_prov_code"
        Me.lkp_prov_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkp_prov_code.ShowFilter = True
        Me.lkp_prov_code.ShowMessageNotFound = True
        Me.lkp_prov_code.ShowWarning = False
        Me.lkp_prov_code.Size = New System.Drawing.Size(16, 20)
        Me.lkp_prov_code.SizesColumns = New String() {"prov_code=100", "prov_name=200", "contact_name=200"}
        Me.lkp_prov_code.SizesColumnsTab = Nothing
        Me.lkp_prov_code.SqlString = Nothing
        Me.lkp_prov_code.SQLTab = Nothing
        Me.lkp_prov_code.SrcParameters = New String() {"txtprov_code=prov_code"}
        Me.lkp_prov_code.TabIndex = 66
        Me.lkp_prov_code.TableName = "cpprovm"
        Me.lkp_prov_code.TabStop = False
        Me.lkp_prov_code.UseCopyConnection = False
        Me.lkp_prov_code.UseRowRetrieveEvents = False
        Me.lkp_prov_code.UseTab = False
        Me.lkp_prov_code.VisParameters = New String() {"Código=prov_code", "Nombre=prov_name", "Contacto=contact_name"}
        Me.lkp_prov_code.WhereCondition = Nothing
        Me.lkp_prov_code.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "cpinvcem"
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
        Me.LibXConnector1.ReportName = "r_cpinvce01.rpt"
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
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
        Me.LibXDbSourceTable1.InnerJon = False
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "invce_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select cpinvcem.*,(cpinvcem.amount-cpinvcem.disc_amount+cpinvcem.itbis )as mtotal" & _
        "   from cpinvcem "}
        Me.LibXDbSourceTable1.TableName = "cpinvcem"
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
        Me.LibXDbSourceTable2.InnerJon = False
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = "line_no"
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"invce_serial=invce_serial"}
        Me.LibXDbSourceTable2.MasterTableName = ""
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select cpinvced.*,cgacctm.acct_name ", "from cpinvced", "inner join cgacctm ", "on cgacctm.acct_no = cpinvced.acct_no", "order by cpinvced.line_no,cpinvced.debit_credit"}
        Me.LibXDbSourceTable2.TableName = "cpinvced"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'txtprov_code
        '
        Me.txtprov_code.AcceptsReturn = True
        Me.txtprov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.prov_code"))
        Me.txtprov_code.EditInitialValue = Nothing
        Me.txtprov_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.FieldDescription = ""
        Me.txtprov_code.FindInitialValue = Nothing
        Me.txtprov_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.IgnoreRequiered = False
        Me.txtprov_code.Location = New System.Drawing.Point(128, 96)
        Me.txtprov_code.Name = "txtprov_code"
        Me.txtprov_code.NewInitialValue = Nothing
        Me.txtprov_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.Requiered = False
        Me.txtprov_code.Size = New System.Drawing.Size(96, 20)
        Me.txtprov_code.StatusBarPanelDescripcion = Nothing
        Me.txtprov_code.TabIndex = 4
        Me.txtprov_code.Text = ""
        '
        'xtxTasa
        '
        Me.xtxTasa.AcceptsReturn = True
        Me.xtxTasa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.tasaUS"))
        Me.xtxTasa.EditInitialValue = Nothing
        Me.xtxTasa.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxTasa.FieldDescription = ""
        Me.xtxTasa.FindInitialValue = Nothing
        Me.xtxTasa.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxTasa.IgnoreRequiered = False
        Me.xtxTasa.Location = New System.Drawing.Point(400, 240)
        Me.xtxTasa.Name = "xtxTasa"
        Me.xtxTasa.NewInitialValue = Nothing
        Me.xtxTasa.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxTasa.Requiered = False
        Me.xtxTasa.Size = New System.Drawing.Size(160, 20)
        Me.xtxTasa.StatusBarPanelDescripcion = Nothing
        Me.xtxTasa.TabIndex = 63
        Me.xtxTasa.Text = ""
        Me.xtxTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label27.Location = New System.Drawing.Point(352, 240)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(29, 16)
        Me.Label27.TabIndex = 62
        Me.Label27.Text = "Tasa"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label25.Location = New System.Drawing.Point(48, 240)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(70, 16)
        Me.Label25.TabIndex = 61
        Me.Label25.Text = "Forma Pago:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo2
        '
        Me.LibXCombo2.AllowDefaultSort = True
        Me.LibXCombo2.bound = True
        Me.LibXCombo2.currValue = Nothing
        Me.LibXCombo2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cpinvcem.invce_cond"))
        Me.LibXCombo2.DefaultWhereString = Nothing
        Me.LibXCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo2.EditInitialValue = Nothing
        Me.LibXCombo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.FieldDescription = ""
        Me.LibXCombo2.FindInitialValue = Nothing
        Me.LibXCombo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.IgnoreRequiered = False
        Me.LibXCombo2.Items.AddRange(New Object() {"1-REPOSICION Y/O SERVICIOS", "2-INVENTARIO DE MERCANCIA"})
        Me.LibXCombo2.Location = New System.Drawing.Point(128, 240)
        Me.LibXCombo2.LookupKeyDisplayFields = ""
        Me.LibXCombo2.LookupKeyField = ""
        Me.LibXCombo2.LookupTableName = ""
        Me.LibXCombo2.Name = "LibXCombo2"
        Me.LibXCombo2.NewInitialValue = ""
        Me.LibXCombo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.Requiered = False
        Me.LibXCombo2.Required = True
        Me.LibXCombo2.Size = New System.Drawing.Size(136, 21)
        Me.LibXCombo2.SqlString = Nothing
        Me.LibXCombo2.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo2.TabIndex = 18
        '
        'xtmtotal
        '
        Me.xtmtotal.AcceptsReturn = True
        Me.xtmtotal.BackColor = System.Drawing.SystemColors.Control
        Me.xtmtotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.mtotal"))
        Me.xtmtotal.EditInitialValue = Nothing
        Me.xtmtotal.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtmtotal.FieldDescription = ""
        Me.xtmtotal.FindInitialValue = Nothing
        Me.xtmtotal.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtmtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtmtotal.IgnoreRequiered = False
        Me.xtmtotal.Location = New System.Drawing.Point(664, 152)
        Me.xtmtotal.Name = "xtmtotal"
        Me.xtmtotal.NewInitialValue = Nothing
        Me.xtmtotal.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtmtotal.Requiered = False
        Me.xtmtotal.Size = New System.Drawing.Size(112, 20)
        Me.xtmtotal.StatusBarPanelDescripcion = Nothing
        Me.xtmtotal.TabIndex = 59
        Me.xtmtotal.TabStop = False
        Me.xtmtotal.Text = ""
        Me.xtmtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label24.Location = New System.Drawing.Point(587, 160)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 16)
        Me.Label24.TabIndex = 58
        Me.Label24.Text = "Monto Total:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cpinvcem.fecha_pago"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.FieldDescription = ""
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = False
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(664, 56)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = "NOW"
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Requiered = False
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(112, 20)
        Me.LibxDateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker1.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label18.Location = New System.Drawing.Point(586, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 16)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Fecha Pago:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.invce_ncfafect"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(400, 144)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(160, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 7
        Me.XTextBox1.Text = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label26.Location = New System.Drawing.Point(320, 144)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(78, 16)
        Me.Label26.TabIndex = 55
        Me.Label26.Text = "NCF Afectado:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtitbisRetenido
        '
        Me.txtitbisRetenido.AcceptsReturn = True
        Me.txtitbisRetenido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.itbis_retenido"))
        Me.txtitbisRetenido.EditInitialValue = Nothing
        Me.txtitbisRetenido.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtitbisRetenido.FieldDescription = ""
        Me.txtitbisRetenido.FindInitialValue = Nothing
        Me.txtitbisRetenido.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtitbisRetenido.IgnoreRequiered = False
        Me.txtitbisRetenido.Location = New System.Drawing.Point(664, 176)
        Me.txtitbisRetenido.Name = "txtitbisRetenido"
        Me.txtitbisRetenido.NewInitialValue = Nothing
        Me.txtitbisRetenido.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtitbisRetenido.Requiered = False
        Me.txtitbisRetenido.Size = New System.Drawing.Size(112, 20)
        Me.txtitbisRetenido.StatusBarPanelDescripcion = Nothing
        Me.txtitbisRetenido.TabIndex = 15
        Me.txtitbisRetenido.Text = ""
        Me.txtitbisRetenido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label23.Location = New System.Drawing.Point(577, 176)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 16)
        Me.Label23.TabIndex = 51
        Me.Label23.Text = "Itbis Retenido:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label22.Location = New System.Drawing.Point(352, 72)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 16)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "Cuenta:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"acct_no=acct_no"}
        Me.LibXLookup1.FilterField = "acct_name"
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(544, 72)
        Me.LibXLookup1.LookCaption = "Cuentas Contables"
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
        Me.LibXLookup1.SrcParameters = New String() {"acct_no=acct_no"}
        Me.LibXLookup1.TabIndex = 49
        Me.LibXLookup1.TableName = "cgacctm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=acct_no", "Descripción=acct_name"}
        Me.LibXLookup1.WhereCondition = "acct_type = 6"
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'xtxacct_no
        '
        Me.xtxacct_no.AcceptsReturn = True
        Me.xtxacct_no.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.acct_no"))
        Me.xtxacct_no.EditInitialValue = Nothing
        Me.xtxacct_no.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxacct_no.FieldDescription = ""
        Me.xtxacct_no.FindInitialValue = Nothing
        Me.xtxacct_no.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxacct_no.IgnoreRequiered = False
        Me.xtxacct_no.Location = New System.Drawing.Point(400, 72)
        Me.xtxacct_no.Name = "xtxacct_no"
        Me.xtxacct_no.NewInitialValue = Nothing
        Me.xtxacct_no.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxacct_no.Requiered = False
        Me.xtxacct_no.Size = New System.Drawing.Size(144, 20)
        Me.xtxacct_no.StatusBarPanelDescripcion = Nothing
        Me.xtxacct_no.TabIndex = 3
        Me.xtxacct_no.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Location = New System.Drawing.Point(42, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 16)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "Tipo Servicio:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cpinvcem.invce_service"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Location = New System.Drawing.Point(128, 72)
        Me.LibXCombo1.LookupKeyDisplayFields = "service_name"
        Me.LibXCombo1.LookupKeyField = "service_code"
        Me.LibXCombo1.LookupTableName = "cpservices"
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = "9"
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(136, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 2
        '
        'btnTransf
        '
        Me.btnTransf.Image = CType(resources.GetObject("btnTransf.Image"), System.Drawing.Image)
        Me.btnTransf.Location = New System.Drawing.Point(22, 16)
        Me.btnTransf.Name = "btnTransf"
        Me.btnTransf.Size = New System.Drawing.Size(32, 23)
        Me.btnTransf.TabIndex = 45
        '
        'klk_suc_code
        '
        Me.klk_suc_code.AlternateFieldSearch = Nothing
        Me.klk_suc_code.BeginCheck = False
        Me.klk_suc_code.CheckText = Nothing
        Me.klk_suc_code.ComboMode = False
        Me.klk_suc_code.DataMember = Nothing
        Me.klk_suc_code.DataSource = Me.LibXConnector1
        Me.klk_suc_code.DestParameters = New String() {"suc_code=suc_code", "sucname=suc_name"}
        Me.klk_suc_code.FilterField = "suc_name"
        Me.klk_suc_code.IgnoreFindInBrowseMode = False
        Me.klk_suc_code.isCanceled = False
        Me.klk_suc_code.Location = New System.Drawing.Point(544, 24)
        Me.klk_suc_code.LookCaption = "Sucursales"
        Me.klk_suc_code.Name = "klk_suc_code"
        Me.klk_suc_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.klk_suc_code.ShowFilter = True
        Me.klk_suc_code.ShowMessageNotFound = True
        Me.klk_suc_code.ShowWarning = False
        Me.klk_suc_code.Size = New System.Drawing.Size(16, 20)
        Me.klk_suc_code.SizesColumns = Nothing
        Me.klk_suc_code.SizesColumnsTab = Nothing
        Me.klk_suc_code.SqlString = Nothing
        Me.klk_suc_code.SQLTab = Nothing
        Me.klk_suc_code.SrcParameters = New String() {"suc_code=suc_code"}
        Me.klk_suc_code.TabIndex = 44
        Me.klk_suc_code.TableName = "cgsucursal"
        Me.klk_suc_code.TabStop = False
        Me.klk_suc_code.UseCopyConnection = False
        Me.klk_suc_code.UseRowRetrieveEvents = False
        Me.klk_suc_code.UseTab = False
        Me.klk_suc_code.VisParameters = New String() {"Código=suc_code", "Descripción=suc_name"}
        Me.klk_suc_code.WhereCondition = ""
        Me.klk_suc_code.WhereParameters = Nothing
        '
        'xtxsuc_code
        '
        Me.xtxsuc_code.AcceptsReturn = True
        Me.xtxsuc_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxsuc_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.suc_code"))
        Me.xtxsuc_code.EditInitialValue = Nothing
        Me.xtxsuc_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxsuc_code.FieldDescription = ""
        Me.xtxsuc_code.FindInitialValue = Nothing
        Me.xtxsuc_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxsuc_code.IgnoreRequiered = False
        Me.xtxsuc_code.Location = New System.Drawing.Point(128, 22)
        Me.xtxsuc_code.Name = "xtxsuc_code"
        Me.xtxsuc_code.NewInitialValue = Nothing
        Me.xtxsuc_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxsuc_code.Requiered = False
        Me.xtxsuc_code.Size = New System.Drawing.Size(96, 20)
        Me.xtxsuc_code.StatusBarPanelDescripcion = Nothing
        Me.xtxsuc_code.TabIndex = 0
        Me.xtxsuc_code.Text = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label20.Location = New System.Drawing.Point(63, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 16)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Sucursal:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'sucname
        '
        Me.sucname.AcceptsReturn = True
        Me.sucname.EditInitialValue = Nothing
        Me.sucname.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.sucname.FieldDescription = ""
        Me.sucname.FindInitialValue = Nothing
        Me.sucname.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.sucname.IgnoreRequiered = False
        Me.sucname.Location = New System.Drawing.Point(232, 22)
        Me.sucname.Name = "sucname"
        Me.sucname.NewInitialValue = Nothing
        Me.sucname.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.sucname.ReadOnly = True
        Me.sucname.Requiered = False
        Me.sucname.Size = New System.Drawing.Size(312, 20)
        Me.sucname.StatusBarPanelDescripcion = Nothing
        Me.sucname.TabIndex = 43
        Me.sucname.TabStop = False
        Me.sucname.Text = ""
        '
        'lnk_Cliente
        '
        Me.lnk_Cliente.AutoSize = True
        Me.lnk_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lnk_Cliente.Location = New System.Drawing.Point(65, 95)
        Me.lnk_Cliente.Name = "lnk_Cliente"
        Me.lnk_Cliente.Size = New System.Drawing.Size(49, 16)
        Me.lnk_Cliente.TabIndex = 40
        Me.lnk_Cliente.TabStop = True
        Me.lnk_Cliente.Text = "Suplidor:"
        Me.lnk_Cliente.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xdtp_due_date
        '
        Me.xdtp_due_date.CustomFormat = "dd/MM/yyyy"
        Me.xdtp_due_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cpinvcem.due_date"))
        Me.xdtp_due_date.EditInitialValue = Nothing
        Me.xdtp_due_date.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdtp_due_date.FieldDescription = ""
        Me.xdtp_due_date.FindInitialValue = Nothing
        Me.xdtp_due_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_due_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdtp_due_date.IgnoreRequiered = False
        Me.xdtp_due_date.Location = New System.Drawing.Point(128, 216)
        Me.xdtp_due_date.Name = "xdtp_due_date"
        Me.xdtp_due_date.NewInitialValue = Nothing
        Me.xdtp_due_date.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdtp_due_date.Requiered = False
        Me.xdtp_due_date.Size = New System.Drawing.Size(136, 20)
        Me.xdtp_due_date.StatusBarPanelDescripcion = Nothing
        Me.xdtp_due_date.TabIndex = 5
        Me.xdtp_due_date.TabStop = False
        '
        'xcbo_invce_status
        '
        Me.xcbo_invce_status.AllowDefaultSort = True
        Me.xcbo_invce_status.bound = True
        Me.xcbo_invce_status.currValue = Nothing
        Me.xcbo_invce_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cpinvcem.invce_status"))
        Me.xcbo_invce_status.DefaultWhereString = Nothing
        Me.xcbo_invce_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_invce_status.EditInitialValue = Nothing
        Me.xcbo_invce_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_invce_status.FieldDescription = ""
        Me.xcbo_invce_status.FindInitialValue = Nothing
        Me.xcbo_invce_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_invce_status.IgnoreRequiered = False
        Me.xcbo_invce_status.Items.AddRange(New Object() {"0-Anulada", "1-Aplicada", "2-Pendiente de aplicar", "3-Saldado", "4-Reposicion"})
        Me.xcbo_invce_status.Location = New System.Drawing.Point(400, 120)
        Me.xcbo_invce_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_invce_status.LookupKeyField = Nothing
        Me.xcbo_invce_status.LookupTableName = Nothing
        Me.xcbo_invce_status.Name = "xcbo_invce_status"
        Me.xcbo_invce_status.NewInitialValue = "2"
        Me.xcbo_invce_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_invce_status.Requiered = False
        Me.xcbo_invce_status.Required = False
        Me.xcbo_invce_status.Size = New System.Drawing.Size(160, 21)
        Me.xcbo_invce_status.SqlString = Nothing
        Me.xcbo_invce_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_invce_status.TabIndex = 6
        '
        'xlk_type_code
        '
        Me.xlk_type_code.AlternateFieldSearch = Nothing
        Me.xlk_type_code.BeginCheck = False
        Me.xlk_type_code.CheckText = Nothing
        Me.xlk_type_code.ComboMode = False
        Me.xlk_type_code.DataMember = Nothing
        Me.xlk_type_code.DataSource = Me.LibXConnector1
        Me.xlk_type_code.DestParameters = New String() {"type_code=type_code", "type_name=type_name"}
        Me.xlk_type_code.FilterField = "type_name"
        Me.xlk_type_code.IgnoreFindInBrowseMode = False
        Me.xlk_type_code.isCanceled = False
        Me.xlk_type_code.Location = New System.Drawing.Point(544, 48)
        Me.xlk_type_code.LookCaption = "Tipos de Documentos"
        Me.xlk_type_code.Name = "xlk_type_code"
        Me.xlk_type_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_type_code.ShowFilter = True
        Me.xlk_type_code.ShowMessageNotFound = True
        Me.xlk_type_code.ShowWarning = False
        Me.xlk_type_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_type_code.SizesColumns = Nothing
        Me.xlk_type_code.SizesColumnsTab = Nothing
        Me.xlk_type_code.SqlString = Nothing
        Me.xlk_type_code.SQLTab = Nothing
        Me.xlk_type_code.SrcParameters = New String() {"type_code=type_code"}
        Me.xlk_type_code.TabIndex = 4
        Me.xlk_type_code.TableName = "ivtypem"
        Me.xlk_type_code.TabStop = False
        Me.xlk_type_code.UseCopyConnection = False
        Me.xlk_type_code.UseRowRetrieveEvents = False
        Me.xlk_type_code.UseTab = False
        Me.xlk_type_code.VisParameters = New String() {"Código=type_code", "Descripción=type_name"}
        Me.xlk_type_code.WhereCondition = "apply_cxp = 1 and (afect_other = 0  or afect_other is null)"
        Me.xlk_type_code.WhereParameters = Nothing
        '
        'xdtp_invce_date
        '
        Me.xdtp_invce_date.Checked = False
        Me.xdtp_invce_date.CustomFormat = "dd/MM/yyyy"
        Me.xdtp_invce_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cpinvcem.doc_date"))
        Me.xdtp_invce_date.EditInitialValue = Nothing
        Me.xdtp_invce_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_invce_date.FieldDescription = ""
        Me.xdtp_invce_date.FindInitialValue = Nothing
        Me.xdtp_invce_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_invce_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdtp_invce_date.IgnoreRequiered = False
        Me.xdtp_invce_date.Location = New System.Drawing.Point(664, 32)
        Me.xdtp_invce_date.Name = "xdtp_invce_date"
        Me.xdtp_invce_date.NewInitialValue = "NOW"
        Me.xdtp_invce_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_invce_date.Requiered = False
        Me.xdtp_invce_date.Size = New System.Drawing.Size(112, 20)
        Me.xdtp_invce_date.StatusBarPanelDescripcion = Nothing
        Me.xdtp_invce_date.TabIndex = 10
        '
        'xtxt_type_code
        '
        Me.xtxt_type_code.AcceptsReturn = True
        Me.xtxt_type_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_type_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.type_code"))
        Me.xtxt_type_code.EditInitialValue = Nothing
        Me.xtxt_type_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_type_code.FieldDescription = ""
        Me.xtxt_type_code.FindInitialValue = Nothing
        Me.xtxt_type_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_code.IgnoreRequiered = False
        Me.xtxt_type_code.Location = New System.Drawing.Point(128, 48)
        Me.xtxt_type_code.Name = "xtxt_type_code"
        Me.xtxt_type_code.NewInitialValue = Nothing
        Me.xtxt_type_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_code.Requiered = False
        Me.xtxt_type_code.Size = New System.Drawing.Size(96, 20)
        Me.xtxt_type_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_type_code.TabIndex = 1
        Me.xtxt_type_code.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(10, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Documento:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'type_name
        '
        Me.type_name.AcceptsReturn = True
        Me.type_name.EditInitialValue = Nothing
        Me.type_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.type_name.FieldDescription = ""
        Me.type_name.FindInitialValue = Nothing
        Me.type_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.type_name.IgnoreRequiered = False
        Me.type_name.Location = New System.Drawing.Point(232, 48)
        Me.type_name.Name = "type_name"
        Me.type_name.NewInitialValue = Nothing
        Me.type_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.type_name.ReadOnly = True
        Me.type_name.Requiered = False
        Me.type_name.Size = New System.Drawing.Size(312, 20)
        Me.type_name.StatusBarPanelDescripcion = Nothing
        Me.type_name.TabIndex = 1
        Me.type_name.TabStop = False
        Me.type_name.Text = ""
        '
        'txtinvce_no
        '
        Me.txtinvce_no.AcceptsReturn = True
        Me.txtinvce_no.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.doc_no"))
        Me.txtinvce_no.EditInitialValue = Nothing
        Me.txtinvce_no.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtinvce_no.FieldDescription = ""
        Me.txtinvce_no.FindInitialValue = Nothing
        Me.txtinvce_no.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtinvce_no.IgnoreRequiered = False
        Me.txtinvce_no.Location = New System.Drawing.Point(128, 119)
        Me.txtinvce_no.Name = "txtinvce_no"
        Me.txtinvce_no.NewInitialValue = Nothing
        Me.txtinvce_no.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtinvce_no.Requiered = False
        Me.txtinvce_no.Size = New System.Drawing.Size(136, 20)
        Me.txtinvce_no.StatusBarPanelDescripcion = Nothing
        Me.txtinvce_no.TabIndex = 5
        Me.txtinvce_no.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(66, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Número:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(615, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.term_name.Location = New System.Drawing.Point(192, 167)
        Me.term_name.Name = "term_name"
        Me.term_name.NewInitialValue = Nothing
        Me.term_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.term_name.ReadOnly = True
        Me.term_name.Requiered = False
        Me.term_name.Size = New System.Drawing.Size(352, 20)
        Me.term_name.StatusBarPanelDescripcion = Nothing
        Me.term_name.TabIndex = 1
        Me.term_name.TabStop = False
        Me.term_name.Text = ""
        '
        'txtterm_code
        '
        Me.txtterm_code.AcceptsReturn = True
        Me.txtterm_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.term_code"))
        Me.txtterm_code.EditInitialValue = Nothing
        Me.txtterm_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtterm_code.FieldDescription = ""
        Me.txtterm_code.FindInitialValue = Nothing
        Me.txtterm_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtterm_code.IgnoreRequiered = False
        Me.txtterm_code.Location = New System.Drawing.Point(128, 167)
        Me.txtterm_code.Name = "txtterm_code"
        Me.txtterm_code.NewInitialValue = Nothing
        Me.txtterm_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtterm_code.Requiered = False
        Me.txtterm_code.Size = New System.Drawing.Size(56, 20)
        Me.txtterm_code.StatusBarPanelDescripcion = Nothing
        Me.txtterm_code.TabIndex = 8
        Me.txtterm_code.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(65, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Término:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxprov_name
        '
        Me.xtxprov_name.AcceptsReturn = True
        Me.xtxprov_name.EditInitialValue = Nothing
        Me.xtxprov_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxprov_name.FieldDescription = ""
        Me.xtxprov_name.FindInitialValue = Nothing
        Me.xtxprov_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxprov_name.IgnoreRequiered = False
        Me.xtxprov_name.Location = New System.Drawing.Point(232, 95)
        Me.xtxprov_name.Name = "xtxprov_name"
        Me.xtxprov_name.NewInitialValue = Nothing
        Me.xtxprov_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxprov_name.ReadOnly = True
        Me.xtxprov_name.Requiered = False
        Me.xtxprov_name.Size = New System.Drawing.Size(312, 20)
        Me.xtxprov_name.StatusBarPanelDescripcion = Nothing
        Me.xtxprov_name.TabIndex = 1
        Me.xtxprov_name.TabStop = False
        Me.xtxprov_name.Text = ""
        '
        'TextBox8
        '
        Me.TextBox8.AcceptsReturn = True
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.invce_desc"))
        Me.TextBox8.EditInitialValue = Nothing
        Me.TextBox8.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox8.FieldDescription = ""
        Me.TextBox8.FindInitialValue = Nothing
        Me.TextBox8.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox8.IgnoreRequiered = False
        Me.TextBox8.Location = New System.Drawing.Point(128, 264)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.NewInitialValue = Nothing
        Me.TextBox8.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox8.Requiered = False
        Me.TextBox8.Size = New System.Drawing.Size(432, 64)
        Me.TextBox8.StatusBarPanelDescripcion = Nothing
        Me.TextBox8.TabIndex = 9
        Me.TextBox8.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(56, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Concepto:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(8, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Fecha Vencimiento:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(585, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Monto Bruto:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txttotal_amount
        '
        Me.txttotal_amount.AcceptsReturn = True
        Me.txttotal_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.amount"))
        Me.txttotal_amount.EditInitialValue = Nothing
        Me.txttotal_amount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txttotal_amount.FieldDescription = ""
        Me.txttotal_amount.FindInitialValue = Nothing
        Me.txttotal_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txttotal_amount.IgnoreRequiered = False
        Me.txttotal_amount.Location = New System.Drawing.Point(664, 80)
        Me.txttotal_amount.Name = "txttotal_amount"
        Me.txttotal_amount.NewInitialValue = Nothing
        Me.txttotal_amount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txttotal_amount.Requiered = False
        Me.txttotal_amount.Size = New System.Drawing.Size(112, 20)
        Me.txttotal_amount.StatusBarPanelDescripcion = Nothing
        Me.txttotal_amount.TabIndex = 12
        Me.txttotal_amount.Text = ""
        Me.txttotal_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(352, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Estatus:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_term_code
        '
        Me.xlk_term_code.AlternateFieldSearch = Nothing
        Me.xlk_term_code.BeginCheck = False
        Me.xlk_term_code.CheckText = Nothing
        Me.xlk_term_code.ComboMode = False
        Me.xlk_term_code.DataMember = Nothing
        Me.xlk_term_code.DataSource = Me.LibXConnector1
        Me.xlk_term_code.DestParameters = New String() {"term_code=term_code", "term_name=term_name", "disc_days=disc_days", "due_days=due_days", "disc_pct=disc_pct"}
        Me.xlk_term_code.FilterField = "term_name"
        Me.xlk_term_code.IgnoreFindInBrowseMode = False
        Me.xlk_term_code.isCanceled = False
        Me.xlk_term_code.Location = New System.Drawing.Point(544, 168)
        Me.xlk_term_code.LookCaption = "Términos de Venta"
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
        Me.xlk_term_code.TabIndex = 4
        Me.xlk_term_code.TableName = "cctermm"
        Me.xlk_term_code.TabStop = False
        Me.xlk_term_code.UseCopyConnection = False
        Me.xlk_term_code.UseRowRetrieveEvents = False
        Me.xlk_term_code.UseTab = False
        Me.xlk_term_code.VisParameters = New String() {"Código=term_code", "Descripción=term_name", "% Descuento=disc_pct", "Días vencimiento=due_days", "Días Descuento=disc_days"}
        Me.xlk_term_code.WhereCondition = Nothing
        Me.xlk_term_code.WhereParameters = Nothing
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(13, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Días de descuento:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.disc_days.Location = New System.Drawing.Point(128, 191)
        Me.disc_days.Name = "disc_days"
        Me.disc_days.NewInitialValue = Nothing
        Me.disc_days.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.disc_days.ReadOnly = True
        Me.disc_days.Requiered = False
        Me.disc_days.Size = New System.Drawing.Size(136, 20)
        Me.disc_days.StatusBarPanelDescripcion = Nothing
        Me.disc_days.TabIndex = 7
        Me.disc_days.TabStop = False
        Me.disc_days.Text = ""
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
        Me.due_days.Location = New System.Drawing.Point(400, 192)
        Me.due_days.Name = "due_days"
        Me.due_days.NewInitialValue = Nothing
        Me.due_days.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.due_days.ReadOnly = True
        Me.due_days.Requiered = False
        Me.due_days.Size = New System.Drawing.Size(160, 20)
        Me.due_days.StatusBarPanelDescripcion = Nothing
        Me.due_days.TabIndex = 1
        Me.due_days.TabStop = False
        Me.due_days.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(280, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Días de Vencimiento:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.disc_pct.Location = New System.Drawing.Point(400, 216)
        Me.disc_pct.Name = "disc_pct"
        Me.disc_pct.NewInitialValue = Nothing
        Me.disc_pct.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.disc_pct.ReadOnly = True
        Me.disc_pct.Requiered = False
        Me.disc_pct.Size = New System.Drawing.Size(160, 20)
        Me.disc_pct.StatusBarPanelDescripcion = Nothing
        Me.disc_pct.TabIndex = 8
        Me.disc_pct.TabStop = False
        Me.disc_pct.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(304, 216)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "% de descuento:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtitbis
        '
        Me.txtitbis.AcceptsReturn = True
        Me.txtitbis.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.itbis"))
        Me.txtitbis.EditInitialValue = Nothing
        Me.txtitbis.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtitbis.FieldDescription = ""
        Me.txtitbis.FindInitialValue = Nothing
        Me.txtitbis.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtitbis.IgnoreRequiered = False
        Me.txtitbis.Location = New System.Drawing.Point(664, 128)
        Me.txtitbis.Name = "txtitbis"
        Me.txtitbis.NewInitialValue = Nothing
        Me.txtitbis.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtitbis.Requiered = False
        Me.txtitbis.Size = New System.Drawing.Size(112, 20)
        Me.txtitbis.StatusBarPanelDescripcion = Nothing
        Me.txtitbis.TabIndex = 14
        Me.txtitbis.Text = ""
        Me.txtitbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(626, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Itbis:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtamount
        '
        Me.txtamount.AcceptsReturn = True
        Me.txtamount.BackColor = System.Drawing.SystemColors.Control
        Me.txtamount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.balance"))
        Me.txtamount.EditInitialValue = Nothing
        Me.txtamount.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtamount.FieldDescription = ""
        Me.txtamount.FindInitialValue = Nothing
        Me.txtamount.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.IgnoreRequiered = False
        Me.txtamount.Location = New System.Drawing.Point(664, 224)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.NewInitialValue = Nothing
        Me.txtamount.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtamount.Requiered = False
        Me.txtamount.Size = New System.Drawing.Size(112, 20)
        Me.txtamount.StatusBarPanelDescripcion = Nothing
        Me.txtamount.TabIndex = 16
        Me.txtamount.TabStop = False
        Me.txtamount.Text = ""
        Me.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(573, 224)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Monto a Pagar:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Location = New System.Drawing.Point(571, 248)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Monto Excento:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtExcento
        '
        Me.txtExcento.AcceptsReturn = True
        Me.txtExcento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.excento"))
        Me.txtExcento.EditInitialValue = Nothing
        Me.txtExcento.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtExcento.FieldDescription = ""
        Me.txtExcento.FindInitialValue = Nothing
        Me.txtExcento.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtExcento.IgnoreRequiered = False
        Me.txtExcento.Location = New System.Drawing.Point(664, 248)
        Me.txtExcento.Name = "txtExcento"
        Me.txtExcento.NewInitialValue = Nothing
        Me.txtExcento.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtExcento.Requiered = False
        Me.txtExcento.Size = New System.Drawing.Size(112, 20)
        Me.txtExcento.StatusBarPanelDescripcion = Nothing
        Me.txtExcento.TabIndex = 15
        Me.txtExcento.TabStop = False
        Me.txtExcento.Text = ""
        Me.txtExcento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Location = New System.Drawing.Point(568, 272)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Monto Grabado:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtGrabado
        '
        Me.txtGrabado.AcceptsReturn = True
        Me.txtGrabado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.impto"))
        Me.txtGrabado.EditInitialValue = Nothing
        Me.txtGrabado.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtGrabado.FieldDescription = ""
        Me.txtGrabado.FindInitialValue = Nothing
        Me.txtGrabado.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtGrabado.IgnoreRequiered = False
        Me.txtGrabado.Location = New System.Drawing.Point(664, 272)
        Me.txtGrabado.Name = "txtGrabado"
        Me.txtGrabado.NewInitialValue = Nothing
        Me.txtGrabado.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtGrabado.Requiered = False
        Me.txtGrabado.Size = New System.Drawing.Size(112, 20)
        Me.txtGrabado.StatusBarPanelDescripcion = Nothing
        Me.txtGrabado.TabIndex = 16
        Me.txtGrabado.TabStop = False
        Me.txtGrabado.Text = ""
        Me.txtGrabado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.userid"))
        Me.TextBox2.EditInitialValue = Nothing
        Me.TextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox2.FieldDescription = ""
        Me.TextBox2.FindInitialValue = Nothing
        Me.TextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.IgnoreRequiered = False
        Me.TextBox2.Location = New System.Drawing.Point(664, 296)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.NewInitialValue = Nothing
        Me.TextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox2.Requiered = False
        Me.TextBox2.Size = New System.Drawing.Size(112, 20)
        Me.TextBox2.StatusBarPanelDescripcion = Nothing
        Me.TextBox2.TabIndex = 17
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(608, 296)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Usuario:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_invce_ncf
        '
        Me.xtxt_invce_ncf.AcceptsReturn = True
        Me.xtxt_invce_ncf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_invce_ncf.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.invce_ncf"))
        Me.xtxt_invce_ncf.EditInitialValue = Nothing
        Me.xtxt_invce_ncf.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_invce_ncf.FieldDescription = ""
        Me.xtxt_invce_ncf.FindInitialValue = Nothing
        Me.xtxt_invce_ncf.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_invce_ncf.IgnoreRequiered = False
        Me.xtxt_invce_ncf.Location = New System.Drawing.Point(128, 143)
        Me.xtxt_invce_ncf.Name = "xtxt_invce_ncf"
        Me.xtxt_invce_ncf.NewInitialValue = Nothing
        Me.xtxt_invce_ncf.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_invce_ncf.Requiered = False
        Me.xtxt_invce_ncf.Size = New System.Drawing.Size(136, 20)
        Me.xtxt_invce_ncf.StatusBarPanelDescripcion = Nothing
        Me.xtxt_invce_ncf.TabIndex = 6
        Me.xtxt_invce_ncf.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(83, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "NCF:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_discamount
        '
        Me.xtxt_discamount.AcceptsReturn = True
        Me.xtxt_discamount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.disc_amount"))
        Me.xtxt_discamount.EditInitialValue = Nothing
        Me.xtxt_discamount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_discamount.FieldDescription = ""
        Me.xtxt_discamount.FindInitialValue = Nothing
        Me.xtxt_discamount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_discamount.IgnoreRequiered = False
        Me.xtxt_discamount.Location = New System.Drawing.Point(664, 104)
        Me.xtxt_discamount.Name = "xtxt_discamount"
        Me.xtxt_discamount.NewInitialValue = Nothing
        Me.xtxt_discamount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_discamount.Requiered = False
        Me.xtxt_discamount.Size = New System.Drawing.Size(88, 20)
        Me.xtxt_discamount.StatusBarPanelDescripcion = Nothing
        Me.xtxt_discamount.TabIndex = 13
        Me.xtxt_discamount.Text = ""
        Me.xtxt_discamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label19.Location = New System.Drawing.Point(593, 104)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 16)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Descuento:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btndevol
        '
        Me.btndevol.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btndevol.Enabled = False
        Me.btndevol.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btndevol.Location = New System.Drawing.Point(752, 104)
        Me.btndevol.Name = "btndevol"
        Me.btndevol.Size = New System.Drawing.Size(24, 23)
        Me.btndevol.TabIndex = 5
        Me.btndevol.Text = "..."
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Nothing
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_type_code
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_type_code
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(802, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'btnDetalle
        '
        Me.btnDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDetalle.Location = New System.Drawing.Point(88, 552)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.TabIndex = 3
        Me.btnDetalle.Text = "Detalle"
        Me.btnDetalle.Visible = False
        '
        'btnTermino
        '
        Me.btnTermino.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTermino.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTermino.Location = New System.Drawing.Point(8, 552)
        Me.btnTermino.Name = "btnTermino"
        Me.btnTermino.TabIndex = 2
        Me.btnTermino.Text = "Términos"
        '
        'btnMov
        '
        Me.btnMov.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMov.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMov.Location = New System.Drawing.Point(168, 552)
        Me.btnMov.Name = "btnMov"
        Me.btnMov.TabIndex = 4
        Me.btnMov.Text = "Movimientos"
        Me.btnMov.Visible = False
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Codificacion Contable"
        Me.LibXGrid1.DataMember = "cpinvced"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 376)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(784, 124)
        Me.LibXGrid1.TabIndex = 0
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = False
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgc_acct_no, Me.xdb_depto, Me.dgc_tran_descr, Me.dgc_debit_amount, Me.dgc_credit_amount})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cpinvced"
        '
        'dgc_acct_no
        '
        Me.dgc_acct_no.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.dgc_acct_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.dgc_acct_no.executeFindDuringFill = False
        Me.dgc_acct_no.Format = ""
        Me.dgc_acct_no.FormatInfo = Nothing
        Me.dgc_acct_no.HeaderText = "Numero Cuenta"
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
        Me.xlk_acct_no.Location = New System.Drawing.Point(400, 496)
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
        Me.xlk_acct_no.TabIndex = 6
        Me.xlk_acct_no.TableName = "cgacctm"
        Me.xlk_acct_no.TabStop = False
        Me.xlk_acct_no.UseCopyConnection = False
        Me.xlk_acct_no.UseRowRetrieveEvents = False
        Me.xlk_acct_no.UseTab = False
        Me.xlk_acct_no.VisParameters = New String() {"Número Cuenta=acct_no", "Nombre Cuenta=acct_name"}
        Me.xlk_acct_no.WhereCondition = "acct_isctrl = 0 and acct_no not in(select cuenta_conta from cpchequera)"
        Me.xlk_acct_no.WhereParameters = Nothing
        '
        'xdb_depto
        '
        Me.xdb_depto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdb_depto.Format = ""
        Me.xdb_depto.FormatInfo = Nothing
        Me.xdb_depto.HeaderText = "Depto."
        Me.xdb_depto.ImageList = Nothing
        Me.xdb_depto.isReadOnly = False
        Me.xdb_depto.MappingName = "dept_code"
        Me.xdb_depto.MaxLength = 32767
        Me.xdb_depto.TabStop = True
        Me.xdb_depto.UseCustomCellFormat = False
        Me.xdb_depto.Width = 70
        '
        'dgc_tran_descr
        '
        Me.dgc_tran_descr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.dgc_tran_descr.Format = ""
        Me.dgc_tran_descr.FormatInfo = Nothing
        Me.dgc_tran_descr.HeaderText = "Cuenta Nombre"
        Me.dgc_tran_descr.ImageList = Nothing
        Me.dgc_tran_descr.isReadOnly = False
        Me.dgc_tran_descr.MappingName = "acct_name"
        Me.dgc_tran_descr.MaxLength = 32767
        Me.dgc_tran_descr.TabStop = False
        Me.dgc_tran_descr.UseCustomCellFormat = False
        Me.dgc_tran_descr.Width = 275
        '
        'dgc_debit_amount
        '
        Me.dgc_debit_amount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgc_debit_amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.dgc_debit_amount.Format = "##,###,##0.00"
        Me.dgc_debit_amount.FormatInfo = Nothing
        Me.dgc_debit_amount.HeaderText = "Debito"
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
        Me.dgc_credit_amount.Format = "##,###,##0.00"
        Me.dgc_credit_amount.FormatInfo = Nothing
        Me.dgc_credit_amount.HeaderText = "Credito"
        Me.dgc_credit_amount.ImageList = Nothing
        Me.dgc_credit_amount.isReadOnly = False
        Me.dgc_credit_amount.MappingName = "credit_amount"
        Me.dgc_credit_amount.MaxLength = 32767
        Me.dgc_credit_amount.TabStop = True
        Me.dgc_credit_amount.UseCustomCellFormat = False
        Me.dgc_credit_amount.Width = 101
        '
        'i_cpinvce01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(802, 592)
        Me.Controls.Add(Me.xlk_acct_no)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.btnMov)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnTermino)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "i_cpinvce01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Movimientos de Cuentas x Pagar"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpinvced, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub xlk_type_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_type_code.BeforeExecuteQuery
        Try
            e.aditionalWhere = "apply_cxp = 1"
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub xlk_type_code_BeforeFind(ByVal sender As Object, ByVal e As LibX.LookupFindEventArgs) Handles xlk_type_code.BeforeFind
        Try
            e.aditionalWhere = "apply_cxp = 1"
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub xlk_term_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_term_code.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If
            If LibXConnector1.IsDataEditing = True Then
                If Val(e.row!due_days.ToString) > 0 AndAlso xdtp_invce_date.Value.ToString.Length > 0 Then
                    xdtp_due_date.Value = CType(xdtp_invce_date.Value, Date).AddDays(Val(e.row!due_days.ToString))
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try
            Me.xtxsuc_code.Text = FindSucursal()
            Me.klk_suc_code.ExecuteFind()
            Me.TextBox2.Text = LibX.User.UserID
            Me.xtxTasa.Text = Conf.GetTasaUS
            Me.xcbo_invce_status.Enabled = True

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub TextBox10_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txttotal_amount.Validating
        Try
            If LibXConnector1.IsDataEditing = True Then
                'CalcularITBIS()
                CalcularNeto()
            End If

        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub CalcularNeto()
        Dim TotalAmount As Decimal
        Dim ItbisAmount As Decimal
        Dim Amount As Decimal
        Dim DiscAmount As Decimal
        Dim porcItbis As Decimal
        Dim iTbisRetenido As Decimal
        Dim iSrRetenido As Decimal

        Dim ExcentoAmount As Decimal
        Dim GrabadoAmount As Decimal
        Dim AmountRD As Decimal
        Dim mTotal As Decimal

        Dim Conf As SGT.Inventario.Common.Configuration
        Try

            Conf = New SGT.Inventario.Common.Configuration
            If Me.txtprov_code.Text <> String.Empty Then

                oSuplidor = New SGT.CXP.Entidades.Suplidor(Me.txtprov_code.Text)

                If txttotal_amount.Text.Trim = "" Then Exit Sub

                TotalAmount = CDbl(txttotal_amount.Text)

                If txtitbis.Text.Trim <> "" Then
                    ItbisAmount = CDbl(txtitbis.Text)
                End If

                If xtxt_discamount.Text.Trim <> "" Then
                    DiscAmount = CDbl(xtxt_discamount.Text)
                End If

                If txtitbis.Text.Trim <> "" And oSuplidor.RetIbis > 0 Then
                    iTbisRetenido = ItbisAmount * (oSuplidor.RetIbis.ToString.Trim / 100)
                End If
                If oSuplidor.RetIsR > 0 Then
                    iSrRetenido = TotalAmount * (oSuplidor.RetIsR.ToString.Trim / 100)
                End If
            End If
            mTotal = ((TotalAmount - DiscAmount) + ItbisAmount)
            Amount = mTotal - iTbisRetenido - iSrRetenido

            porcItbis = Conf.GetITBIS

            GrabadoAmount = ItbisAmount / (porcItbis / 100)
            ExcentoAmount = (TotalAmount - DiscAmount) - GrabadoAmount

            xtmtotal.Text = Format(mTotal, "##,###,##0.00")
            txtamount.Text = Format(Amount, "##,###,##0.00")
            txtitbisRetenido.Text = Format(iTbisRetenido, "##,###,##0.00")
            xtx_isr.Text = Format(iSrRetenido, "##,###,##0.00")
            txtExcento.Text = Format(ExcentoAmount, "##,###,##0.00")
            txtGrabado.Text = Format(GrabadoAmount, "##,###,##0.00")

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Function CalcularITBIS() As Decimal
        Dim TotalAmount As Decimal
        Dim ItbisAmount As Decimal
        Dim Amount As Decimal
        Dim DiscAmount As Decimal
        Dim porcItbis As Decimal

        Dim ExcentoAmount As Decimal
        Dim GrabadoAmount As Decimal
        Try

            If txttotal_amount.Text.Trim = "" Then Exit Function

            TotalAmount = CDbl(txttotal_amount.Text)

            If txtitbis.Text.Trim <> "" Then
                ItbisAmount = CDbl(txtitbis.Text)
            End If

            If xtxt_discamount.Text.Trim <> "" Then
                DiscAmount = CDbl(xtxt_discamount.Text)
            End If

            Amount = (TotalAmount - DiscAmount)

            porcItbis = Conf.GetITBIS

            ItbisAmount = Amount * (Conf.GetITBIS / 100)

            If ItbisAmount < 0 Then
                ItbisAmount = 0
            End If

            Return ItbisAmount

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
    Private Sub CalcularDESC()
        Dim TotalAmount As Decimal
        Dim ItbisAmount As Decimal
        Dim Amount As Decimal
        Dim DiscAmount As Decimal
        Dim porc As Decimal

        Dim ExcentoAmount As Decimal
        Dim GrabadoAmount As Decimal
        Try
            If txttotal_amount.Text.Trim = "" Then Exit Sub
            If disc_pct.Text.Trim = "" Then Exit Sub

            porc = Val(disc_pct.Text.Trim)

            TotalAmount = CDbl(txttotal_amount.Text)

            DiscAmount = TotalAmount * (porc / 100)

            Me.xtxt_discamount.Text = DiscAmount

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub txtitbis_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtitbis.Validating

        Try

            If Me.txtprov_code.Text <> String.Empty Then

                If LibXConnector1.IsDataEditing = True Then
                    ''If Me.txtitbis.Text.Trim <> "" Then
                    ''    If Val(Me.txtitbis.Text.Trim) > CalcularITBIS() Then
                    ''        Throw New ApplicationException("Itbis no puede ser mayor que " & CalcularITBIS().ToString("##,##0.00"))
                    ''    End If
                    ''End If
                    CalcularNeto()
                End If
                ''If Me.xtxacct_no.Text = "" Then Me.xtxacct_no.Text = "1110201"

                Dim grid_rows As Integer = Me.LibXGrid1.getCurrentGridView.Count
                Dim ids As Integer

                'Borrar todos los registros del grid si existen
                grid_rows -= 1
                For ids = 0 To grid_rows
                    Me.LibXGrid1.getCurrentGridView.Item(grid_rows - ids).Delete()
                Next

                Dim oProveedor As DataTable
                oProveedor = LibX.Data.Manager.GetDataTable("select * from cpprovm where prov_code ='" & Me.txtprov_code.Text & "'")

                Dim acc_no As String

                If oProveedor.Rows.Count > 0 AndAlso Not LibX.IsNull(oProveedor.Rows(0)!acct_no) AndAlso oProveedor.Rows(0)!acct_no <> String.Empty Then
                    acc_no = oProveedor.Rows(0)!acct_no
                    CodificarCuenta(acc_no)
                    CodificarItbis()
                Else
                    '' Show Message
                End If


            Else
                    '' SHow a MEssage
                End If

        Catch ex As Exception
            ''Me.txtitbis.Text = CalcularITBIS().ToString
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub


    Private Sub CodificarItbis()

        Dim oCuentas As DataTable
        Dim oTable As DataTable

        Dim debito As Decimal
        Dim credito As Decimal

        Dim m_nombreCuenta As String = String.Empty

        If Me.xtxt_type_code.Text <> String.Empty Then
            oCuentas = LibX.Data.Manager.GetDataTable("select * from cuentascodificacion where type_code = '" & Me.xtxt_type_code.Text & "'")
            If oCuentas Is Nothing Then
                Exit Sub
            End If
        End If

        Dim cuentasRows As DataRow

        For Each cuentasRows In oCuentas.Rows

            Select Case cuentasRows!orig_valor

                Case SGT.Contabilidad.Entidades.Codificacion.OrigenValorEnum.Impuesto

                    Dim Impuesto = CDec(Me.txtitbis.Text)

                    If Impuesto > 0 Then

                        oTable = LibX.Data.Manager.GetDataTable("select * from cgacctm where acct_no ='" & cuentasRows!acct_no & "'")
                        Dim m_indice As Integer = LibXGrid1.getCurrentGridView.Count()

                        If (oTable.Rows.Count > 0) Then
                            m_nombreCuenta = oTable.Rows(0)!acct_name

                            cpinvced.Rows.Add(cpinvced.NewRow)
                            LibXGrid1.SetValue(m_indice, dgc_acct_no, cuentasRows!acct_no)
                            LibXGrid1.SetValue(m_indice, xdb_depto, 0)
                            LibXGrid1.SetValue(m_indice, dgc_tran_descr, m_nombreCuenta)
                        End If

                        If oTable.Rows(0)!acct_origen = -1 Then
                            debito = Impuesto
                            LibXGrid1.SetValue(m_indice, dgc_debit_amount, debito)
                            LibXGrid1.SetValue(m_indice, dgc_credit_amount, 0)
                        Else
                            credito = Impuesto
                            LibXGrid1.SetValue(m_indice, dgc_credit_amount, credito)
                            LibXGrid1.SetValue(m_indice, dgc_debit_amount, 0)
                        End If

                        LibXGrid1.refreshFooter()

                    End If


                Case SGT.Contabilidad.Entidades.Codificacion.OrigenValorEnum.Descuento

                    Dim Descuento = CDec(Me.xtxt_discamount.Text)

                    If Descuento > 0 Then

                        oTable = LibX.Data.Manager.GetDataTable("select * from cgacctm where acct_no ='" & cuentasRows!acct_no & "'")

                        Dim m_indice As Integer = LibXGrid1.getCurrentGridView.Count()

                        If (oTable.Rows.Count > 0) Then
                            m_nombreCuenta = oTable.Rows(0)!acct_name

                            cpinvced.Rows.Add(cpinvced.NewRow)
                            LibXGrid1.SetValue(m_indice, dgc_acct_no, cuentasRows!acct_no)
                            LibXGrid1.SetValue(m_indice, xdb_depto, 0)
                            LibXGrid1.SetValue(m_indice, dgc_tran_descr, m_nombreCuenta)
                        End If

                        If oTable.Rows(0)!acct_origen = -1 Then
                            debito = Descuento
                            LibXGrid1.SetValue(m_indice, dgc_debit_amount, debito)
                            LibXGrid1.SetValue(m_indice, dgc_credit_amount, 0)
                        Else
                            credito = Descuento
                            LibXGrid1.SetValue(m_indice, dgc_credit_amount, credito)
                            LibXGrid1.SetValue(m_indice, dgc_debit_amount, 0)
                        End If

                        LibXGrid1.refreshFooter()
                    End If

            End Select
        Next


    End Sub

    Private Sub CodificarCuenta(ByVal acc_no As String)

        Dim debito As Decimal
        Dim credito As Decimal
        Dim oTbale As DataTable

        Try
            oTbale = LibX.Data.Manager.GetDataTable("select * from cgacctm where acct_no ='" & acc_no & "'")

            If Me.xtxt_type_code.Text <> String.Empty Then

                If Me.LibXGrid1.getCurrentGridView.Count <= 0 And Val(Me.txttotal_amount.Text) > 0 Then
                    If Me.txttotal_amount.Text = String.Empty Then
                        Me.txttotal_amount.Text = 0.0
                    End If
                    If Me.xtxt_discamount.Text = String.Empty Then
                        Me.xtxt_discamount.Text = "0.0"
                    End If

                    If Me.txtitbis.Text = String.Empty Then
                        Me.txtitbis.Text = "0.0"
                    End If

                    cpinvced.Rows.Add(cpinvced.NewRow)
                    LibXGrid1.SetValue(0, dgc_acct_no, acc_no)
                    LibXGrid1.SetValue(0, xdb_depto, 0)
                    LibXGrid1.SetValue(0, dgc_tran_descr, oTbale.Rows(0)!acct_name)

                    If oTbale.Rows(0)!acct_origen = 1 Then
                        debito = CDec(Me.txttotal_amount.Text) - CDec(Me.xtxt_discamount.Text) + CDec(Me.txtitbis.Text)
                        LibXGrid1.SetValue(0, dgc_debit_amount, debito)
                        LibXGrid1.SetValue(0, dgc_credit_amount, 0)
                    Else
                        credito = CDec(Me.txttotal_amount.Text) - CDec(Me.xtxt_discamount.Text) + CDec(Me.txtitbis.Text)
                        LibXGrid1.SetValue(0, dgc_credit_amount, credito)
                        LibXGrid1.SetValue(0, dgc_debit_amount, 0)
                    End If
                Else
                    If oTbale.Rows(0)!acct_origen = 1 Then
                        debito = CDec(Me.txttotal_amount.Text) + CDec(Me.txtitbis.Text)
                        LibXGrid1.SetValue(0, dgc_debit_amount, debito)
                        LibXGrid1.SetValue(0, dgc_credit_amount, 0)
                    Else
                        credito = CDec(Me.txttotal_amount.Text) + CDec(Me.txtitbis.Text)
                        LibXGrid1.SetValue(0, dgc_credit_amount, credito)
                        LibXGrid1.SetValue(0, dgc_debit_amount, 0)
                    End If

                End If
            End If

            LibXGrid1.refreshFooter()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub xlk_cust_code_AfterSetValues(ByVal sender As System.Object, ByVal e As LibX.LookupValuesEventArgs)
        Try

            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.IsDataEditing = True And oDocumento.Entrada = True Then
                If e.row!term_code.ToString.Trim <> "" Then
                    txtterm_code.Text = e.row!term_code.ToString
                    xlk_term_code.ExecuteFind()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub btnTermino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTermino.Click
        Dim oParam As LibX.LibxPrgParams
        Try
            Me.Cursor = Cursors.WaitCursor
            LibX.LibXRunner.Run("i_ccterm01", "CXC", True)
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams
            With oParam
                .IsFromOther = True
                .Value = ""
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowPrint = True
                .AllowQuery = False

                Me.Cursor = Cursors.WaitCursor
                If Val(LibXConnector1.CurrentDataRow!entr_serial.ToString.Trim) > 0 Then
                    .WhereToExecute = "iventrdm.entr_serial = " & LibXConnector1.CurrentDataRow!entr_serial.ToString
                    LibX.App.CurrentPrgParams = oParam
                    LibX.LibXRunner.Run("i_iventr02", "INV", True)
                ElseIf Val(LibXConnector1.CurrentDataRow!dev_serial.ToString.Trim) > 0 Then
                    .WhereToExecute = "ivdevolm.dev_serial = " & LibXConnector1.CurrentDataRow!dev_serial.ToString
                    LibX.App.CurrentPrgParams = oParam
                    LibX.LibXRunner.Run("i_ivdevm01", "INV", True)
                Else
                    Throw New ApplicationException("Documento no tiene detalle!")
                End If
            End With

        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub btnMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMov.Click
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams
            With oParam
                .IsFromOther = True
                .Value = ""
                .WhereToExecute = "cpinvcem.invce_serial = " & LibXConnector1.CurrentDataRow!invce_serial.ToString
            End With

            LibX.App.CurrentPrgParams = oParam

            Me.Cursor = Cursors.WaitCursor
            LibX.LibXRunner.Run("c_cpdocs01", "CXP", True)
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try
            btnDetalle.Enabled = Not e.isDataEditing And LibXConnector1.HasRecords
            btnMov.Enabled = Not e.isDataEditing And LibXConnector1.HasRecords
            If Val(Me.txttotal_amount.Text) > 0 Then
                Me.btndevol.Enabled = True
            Else
                Me.btndevol.Enabled = False
            End If
            If e.action <> LibX.LibxConnectionActions.Find Then
                CalcularNeto()
            End If
            If e.action = LibX.LibxConnectionActions.Edit Then
                If Me.xcbo_invce_status.SelectedValue = 1 Or Me.xcbo_invce_status.SelectedValue = 3 Then
                    ActivactionOFF()
                Else
                    ActivactionON()
                End If
            End If

            If e.action = LibX.LibxConnectionActions.Add Then
                txtamount.Text = String.Empty
                Me.xtxsuc_code.Text = FindSucursal()
                Me.klk_suc_code.ExecuteFind()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_RowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange
        Try
            If Val(Me.txttotal_amount.Text) > 0 Then
                Me.btndevol.Enabled = True
            Else
                Me.btndevol.Enabled = False
            End If

            CalcularNeto()

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_SettingDefaultqueryValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultQueryValues) Handles LibXConnector1.SettingDefaultqueryValues
        Try
            xcbo_invce_status.currValue = 2
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub lnk_Cliente_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnk_Cliente.LinkClicked
        Dim oParam As LibX.LibxPrgParams
        Try
            If LibXConnector1.CurrentDataRow!prov_code.ToString.Trim = "" Then
                Exit Sub
            End If

            oParam = New LibX.LibxPrgParams
            With oParam
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowPrint = True
                .AllowQuery = False
                .IsFromOther = True
                .Value = ""
                .WhereToExecute = "cpprovm.prov_code = " & LibXConnector1.CurrentDataRow!prov_code.ToString
            End With

            LibX.App.CurrentPrgParams = oParam

            Me.Cursor = Cursors.WaitCursor
            LibX.LibXRunner.Run("i_cpprovm01", "CXP", True)
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Dim oDevoinv As DataRow
        Dim SelectStmt As String

        Try
            If xdtp_invce_date.Text.Trim = "" Then
                xdtp_invce_date.Value = LibX.Data.Manager.Connection.GetDate.ToString("d")
            End If

            If e.UpdatingArgs.StatementType = StatementType.Insert AndAlso e.UpdatingArgs.StatementType = StatementType.Update Then
                If Me.LibXCombo2.SelectedValue = 1 And mTipo <> "FPI" And xcbo_invce_status.SelectedValue = 2 Then
                    e.UpdatingArgs.Row!invce_status = 4
                End If
                If due_days.Text.Trim <> "" Then
                    e.UpdatingArgs.Row!due_date = DateAdd(DateInterval.Day, Val(due_days.Text.Trim), e.UpdatingArgs.Row!doc_date)
                End If
                If disc_days.Text.Trim <> "" Then
                    e.UpdatingArgs.Row!disc_date = DateAdd(DateInterval.Day, Val(disc_days.Text.Trim), e.UpdatingArgs.Row!doc_date)
                End If
            End If

            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                e.UpdatingArgs.Row!date_created = LibX.Data.Manager.GetScalar("select getdate()")
                If oDocumento.AutoNumerar = True Then
                    If mTipo = "FPI" Then
                        oAlm = LibX.Data.Manager.GetScalar("select whse_code from cgsucursal where suc_code =" & Me.xtxsuc_code.Text)
                        e.UpdatingArgs.Row!doc_no = oDocumento.GenerateNumber(mTipo, FindSucursal())
                        e.UpdatingArgs.Row!invce_ncf = oDocumento.GenerateNCF(mTipo, oAlm, Entidades.Documento.TipoNCFEnum.ProveedoresInformales)
                        e.UpdatingArgs.Row!invce_status = 1
                    End If
                End If
                If mTipo = "FPI" Then
                    e.UpdatingArgs.Row!invce_status = 4
                End If
            End If

            If Val(e.UpdatingArgs.Row!due_date.ToString) > 0 AndAlso xdtp_invce_date.Value.ToString.Length > 0 Then
                e.UpdatingArgs.Row!due_date = CType(xdtp_invce_date.Value, Date).AddDays(Val(e.UpdatingArgs.Row!due_date.ToString))
            End If
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                If LibX.IsNull(Me.LibXCombo2.SelectedValue) Then
                    LibXCombo2.Focus()
                    Throw New ApplicationException("Debe Indicar la forma de pago")
                End If

                If Me.LibXCombo2.SelectedValue = 1 And mTipo <> "FPI" Then
                    e.UpdatingArgs.Row!invce_status = 4
                Else
                    If mTipo <> "FPI" Then
                        e.UpdatingArgs.Row!invce_status = 2
                    End If
                End If
            End If
            If txtinvce_no.Text = "" Then
                txtinvce_no.Focus()
                Throw New ApplicationException("Debe Indicar el numero del documento")
            End If
            If txtitbis.Text = "" Then
                e.UpdatingArgs.Row!itbis = 0
            End If
        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex)

        End Try
    End Sub
    Private Sub txtitbisRetenido_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtitbisRetenido.Validating
        Try
            If LibXConnector1.IsDataEditing = True Then
                CalcularNeto()
            End If

        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try

    End Sub
    Private Sub xtxt_discamount_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_discamount.Validating
        Try
            If LibXConnector1.IsDataEditing = True Then
                CalcularNeto()
            End If

        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try

    End Sub
    ''Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
    ''    Try

    ''        If Not e.row Is Nothing Then
    ''            If e.row!invce_status = 1 Or e.row!invce_status = 3 Or e.row!invce_status = 0 Then  '// Aplicado, Saldado O Anulado
    ''                Me.LibXConnector1.AllowEdit = False
    ''                Me.LibXConnector1.AllowDelete = False
    ''            Else
    ''                Me.LibXConnector1.AllowEdit = True
    ''                Me.LibXConnector1.AllowDelete = True
    ''            End If

    ''            LibXNavigator1.UpdateState()
    ''            CalcularNeto()
    ''        End If

    ''    Catch ex As Exception
    ''        LibX.Log.Add(ex, True)
    ''    End Try
    ''End Sub
    Private Sub txtitbis_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtitbis.GotFocus
        Try
            If LibXConnector1.IsDataEditing = True AndAlso Me.txtitbis.Text.Trim = "" Then
                ''Me.txtitbis.Text = CalcularITBIS()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub cpinvced_RowDeleted(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles cpinvced.RowDeleted
        Try
            If LibXConnector1.IsDataEditing = True Then
                ''CalcularNeto()
                LibXGrid1.Focus(LibXGrid1.currentRowNum, 0)
                LibXGrid1.refreshFooter()
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub xlk_type_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_type_code.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            oDocumento = New Entidades.Documento(e.row!type_code)

            If oDocumento.AutoNumerar = True Then
                If e.row!type_code = "FPI" Then
                    mTipo = e.row!type_code
                    Me.txtinvce_no.Enabled = False
                    Me.xtxt_invce_ncf.Enabled = False
                    Me.txtinvce_no.Text = 0
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub i_cpinvce01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Conf = New SGT.Inventario.Common.Configuration
        oParamValidar = New SGT.Administracion.Entidades.Permission.ParametrosValidar
        oAutorizar = New SGT.Administracion.Entidades.Permission
        Transf = CType(System.Configuration.ConfigurationSettings.AppSettings.Get("LibxTransfCXP"), Boolean)
        Me.btnTransf.Visible = Transf
        Me.btnTransf.Enabled = Transf

        LibXGrid1.footerOperations.add("debit_amount", "sum(debit_amount)")
        LibXGrid1.footerOperations.add("credit_amount", "sum(credit_amount)")
        LibXGrid1.footerOperations.add("acct_name", "sum(debit_amount)-sum(credit_amount)")

        If Not LibXConnector1.Parameters Is Nothing Then
            If LibXConnector1.Parameters.Datos.Count > 0 Then
                If LibXConnector1.Parameters.Datos.Contains("prov_code") Then
                    Me.txtprov_code.Text = LibXConnector1.Parameters.Datos.Item("prov_code")
                    Me.lkp_prov_code.ExecuteFind()
                End If

                Me.xlk_type_code.Text = "NCR"
                Me.xlk_type_code.ExecuteFind()



            End If
        End If
    End Sub
    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            ''If e.Action = LibX.LibxConnectionActions.Find Then
            ''    Me.txtamount.Text = String.Empty
            ''End If
            ''If e.Action = LibX.LibxConnectionActions.Edit Then
            ''    oParamValidar.AccessKey = "ED"
            ''    oAutorizar.PermisosAutorizados.Remove("ED")

            ''    If oAutorizar.isAutorization(oParamValidar) = False Then
            ''        Throw New ApplicationException("Autorización Invalida ")
            ''    End If
            ''End If
            ''If e.Action = LibX.LibxConnectionActions.Add Then
            ''    Dim oTipoNCF As New frmTipo

            ''    If oTipoNCF.ShowDialog = DialogResult.OK Then
            ''        mMoneda = oTipoNCF.Moneda
            ''        If mMoneda = SGT.Inventario.Entidades.Documento.MonedaEnum.RD Then
            ''            Me.xtmoneda.Text = "PESO    "
            ''            Me.xtmoneda.ForeColor = System.Drawing.Color.Blue
            ''            mSucursalAfacturar = 1
            ''        Else
            ''            Me.xtmoneda.Text = "DOLLARES"
            ''            Me.xtmoneda.ForeColor = System.Drawing.Color.Blue
            ''            mSucursalAfacturar = 2
            ''        End If
            ''    Else
            ''        Throw New ApplicationException("No selecciono el tipo de Moneda!!!")
            ''    End If

            ''    oTipoNCF = Nothing
            ''End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub txtinvce_no_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtinvce_no.Validating
        Try
            Dim oValidar As SGT.CXP.Entidades.NumeroRepetido
            oValidar = New SGT.CXP.Entidades.NumeroRepetido
            If LibXConnector1.IsDataEditing = True AndAlso Me.txtinvce_no.Text <> "" Then
                If oValidar.NumberExiste(Me.xtxt_type_code.Text, Me.txtprov_code.Text, Me.txtinvce_no.Text) = True Then
                    Me.txtinvce_no.Text = ""
                    Throw New ApplicationException("Este numero de documento ya existe verifique!")
                End If
            End If
        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub btndevol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndevol.Click
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams
            With oParam
                .IsFromOther = True
                .Value = Me.txtinvce_no.Text
                .Datos.Add("xtxnc", Me.txttotal_amount.Text)

                .AllowDelete = False
                .AllowEdit = True
                .AllowNew = False
                .AllowPrint = False
                .AllowQuery = False
                Me.Cursor = Cursors.WaitCursor
                If Val(LibXConnector1.CurrentDataRow!prov_code.ToString.Trim) > 0 And LibXConnector1.CurrentDataRow!type_code.ToString.Trim = "NCR" And Val(txttotal_amount.Text) > 0 Then
                    .WhereToExecute = "cpinvcem.prov_code = " & LibXConnector1.CurrentDataRow!prov_code.ToString & _
                              " and cpinvcem.type_code = 'DVI' and cpinvcem.invce_status = 2 "
                    LibX.App.CurrentPrgParams = oParam
                    LibX.LibXRunner.Run("c_cpdocs05", "CXP", True)
                End If
            End With

        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Function FindSucursal() As Integer
        Dim oSucursal As Integer
        Dim SelectStmt As String

        SelectStmt = "select suc_code from cgsucursal where suc_default = 1 "
        oSucursal = LibX.Data.Manager.GetScalar(SelectStmt)

        Return oSucursal
    End Function

    Private Sub txttotal_amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotal_amount.TextChanged
        If Val(Me.txttotal_amount.Text) > 0 Then
            Me.btndevol.Enabled = True
        Else
            Me.btndevol.Enabled = False
        End If
    End Sub

    Private Sub btnTransf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransf.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            EnviarCompras()
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub EnviarCompras()
        Dim wsSGF1 As WSSGF1.WSSGF1

        Dim oDataSet As DataSet

        Dim oTableCpinvcem As DataTable
        Dim oTableCpinvcem1 As DataTable
        Dim oRemote As DataTable
        Dim xUpdate As LibX.Data.XUpdateStmt

        Try

            '// cpimvcem
            oTableCpinvcem = LibX.Data.Manager.GetDataTable("select * from cpinvcem where invce_status not in(0,3)")

            If oTableCpinvcem.Rows.Count <= 0 Then
                Throw New ApplicationException("No hay informaciones pendiente de transferir")
            End If


            For Each oRow1 As DataRow In oTableCpinvcem.Rows
                oTableCpinvcem1 = LibX.Data.Manager.GetDataTable("select * from cpinvcem where invce_serial = " & oRow1!invce_serial)

                oTableCpinvcem1.TableName = "cpinvcem"

                '// DataSet
                oDataSet = New DataSet("dsSGF1")

                '// Tablas
                oTableCpinvcem1.Rows(0)!invce_serial = 0
                If oRemote Is Nothing Then
                    Throw New ApplicationException("No hay estaciones remotas configuradas!")
                End If

                If oRemote.Rows.Count <= 0 Then
                    Throw New ApplicationException("No hay estaciones remotas configuradas!")
                End If

                For Each oRow As DataRow In oRemote.Rows
                    wsSGF1.Url = oRow!url.ToString.Trim
                    wsSGF1.Credentials = System.Net.CredentialCache.DefaultCredentials

                    If wsSGF1.InsertarCompra(oDataSet) Then
                    End If
                Next
                xUpdate = New LibX.Data.XUpdateStmt("cpinvcem")
                xUpdate.FieldsSet("invce_status") = 3
                xUpdate.Fields("invce_serial") = oRow1!invce_serial
                xUpdate.Fields("suc_code") = oRow1!suc_code
                xUpdate.Execute()
            Next

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub LibXConnector1_AfterLoadDetail(ByVal sender As Object, ByVal e As LibX.XbeforeLoadDetailEventArgs) Handles LibXConnector1.AfterLoadDetail
        Try

            For Each oRow As DataRow In DataSet1.Tables("cpinvced").Rows
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
                ''If Not LibX.IsNull(e.UpdatingArgs.Row!acct_no) Then
                ''    If e.UpdatingArgs.Row!debit_amount = 0 And e.UpdatingArgs.Row!credit_amount = 0 Then
                ''        Throw New ApplicationException("Debe digitar el debito/credito de las cuentas")
                ''    End If
                ''End If
                e.UpdatingArgs.Row!suc_code = xtxsuc_code.Text
                If BalancearEntrada() <> 0 Then
                    Throw New ApplicationException("La entrada esta descuadrada, Verifique!")
                End If
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)
        End Try

    End Sub
    Private Sub txttotal_amount_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txttotal_amount.Validating
        '    Dim debito As Decimal
        '    Dim credito As Decimal
        '    Dim oTbale As DataTable

        '    Try
        '        If Me.xtxacct_no.Text = "" Then Me.xtxacct_no.Text = "1110201"
        '        oTbale = LibX.Data.Manager.GetDataTable("select * from cgacctm where acct_no ='" & xtxacct_no.Text & "'")

        '        If Me.xtxt_type_code.Text <> "" Then

        '            If Me.LibXGrid1.getCurrentGridView.Count <= 0 And Val(Me.txttotal_amount.Text) > 0 Then
        '                If Me.txttotal_amount.Text = "" Then
        '                    Me.txttotal_amount.Text = 0.0
        '                End If
        '                If Me.txtitbis.Text = "" Then
        '                    Me.txtitbis.Text = "0.0"
        '                End If
        '                cpinvced.Rows.Add(cpinvced.NewRow)
        '                LibXGrid1.SetValue(0, dgc_acct_no, xtxacct_no.Text)
        '                LibXGrid1.SetValue(0, xdb_depto, 0)
        '                LibXGrid1.SetValue(0, dgc_tran_descr, oTbale.Rows(0)!acct_name)
        '                If oTbale.Rows(0)!acct_origen = 1 Then
        '                    debito = CDec(Me.txttotal_amount.Text) + CDec(Me.txtitbis.Text)
        '                    LibXGrid1.SetValue(0, dgc_debit_amount, 0)
        '                    LibXGrid1.SetValue(0, dgc_credit_amount, debito)
        '                Else
        '                    credito = CDec(Me.txttotal_amount.Text) + CDec(Me.txtitbis.Text)
        '                    LibXGrid1.SetValue(0, dgc_credit_amount, credito)
        '                    LibXGrid1.SetValue(0, dgc_debit_amount, 0)
        '                End If
        '            Else
        '                If oTbale.Rows(0)!acct_origen = 1 Then
        '                    debito = CDec(Me.txttotal_amount.Text) + CDec(Me.txtitbis.Text)
        '                    LibXGrid1.SetValue(0, dgc_debit_amount, 0)
        '                    LibXGrid1.SetValue(0, dgc_credit_amount, debito)
        '                Else
        '                    credito = CDec(Me.txttotal_amount.Text) + CDec(Me.txtitbis.Text)
        '                    LibXGrid1.SetValue(0, dgc_credit_amount, credito)
        '                    LibXGrid1.SetValue(0, dgc_debit_amount, 0)
        '                End If
        '            End If
        '        End If

        '        LibXGrid1.refreshFooter()

        '    Catch ex As Exception
        '        e.Cancel = True
        '        LibX.Log.Add(ex)
        '    End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams
            With oParam
                .IsFromOther = True
                .Value = ""
                .WhereToExecute = "cpinvcem.invce_serial = " & LibXConnector1.CurrentDataRow!invce_serial.ToString
            End With

            LibX.App.CurrentPrgParams = oParam

            Me.Cursor = Cursors.WaitCursor
            LibX.LibXRunner.Run("r_iventr606", "INV", True)
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub LibXCombo2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LibXCombo2.Validating
        ''Dim oTbale As DataTable
        ''Dim debito As Decimal
        ''Dim credito As Decimal
        ''Dim acct_cc As String = "1110201"

        ''Try
        ''    oTbale = LibX.Data.Manager.GetDataTable("select * from cgacctm where acct_no ='" & acct_cc & "'")

        ''    If Me.xtxt_type_code.Text <> "" And xtxacct_no.Text <> "" Then

        ''        If Me.LibXGrid1.getCurrentGridView.Count = 1 And Val(Me.txttotal_amount.Text) > 0 And Me.LibXCombo2.SelectedValue = 1 Then
        ''            If Me.txttotal_amount.Text = "" Then
        ''                Me.txttotal_amount.Text = 0.0
        ''            End If
        ''            If Me.txtitbis.Text = "" Then
        ''                Me.txtitbis.Text = "0.0"
        ''            End If
        ''            cpinvced.Rows.Add(cpinvced.NewRow)
        ''            LibXGrid1.SetValue(1, dgc_acct_no, acct_cc)
        ''            LibXGrid1.SetValue(1, xdb_depto, 0)
        ''            LibXGrid1.SetValue(1, dgc_tran_descr, oTbale.Rows(0)!acct_name)
        ''            credito = CDec(Me.txttotal_amount.Text) + CDec(Me.txtitbis.Text)
        ''            LibXGrid1.SetValue(1, dgc_credit_amount, 0)
        ''            LibXGrid1.SetValue(1, dgc_debit_amount, credito)
        ''        Else
        ''            If oTbale.Rows(0)!acct_origen = 1 Then
        ''                debito = CDec(Me.txttotal_amount.Text) + CDec(Me.txtitbis.Text)
        ''                LibXGrid1.SetValue(1, dgc_debit_amount, debito)
        ''                LibXGrid1.SetValue(1, dgc_credit_amount, 0)
        ''            Else
        ''                credito = CDec(Me.txttotal_amount.Text) + CDec(Me.txtitbis.Text)
        ''                LibXGrid1.SetValue(1, dgc_credit_amount, 0)
        ''                LibXGrid1.SetValue(1, dgc_debit_amount, credito)
        ''            End If
        ''        End If
        ''    End If
        ''    LibXGrid1.refreshFooter()

        ''Catch ex As Exception
        ''    LibX.Log.Show(ex)
        ''End Try

    End Sub
    Private Sub xlk_acct_no_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_acct_no.AfterSetValues

        Try

            If Not Me.LibXConnector1.IsEditing Then
                Exit Sub
            End If

            If e.dataFound = False Then
                Exit Sub
            End If

            Me.LibXGrid1.SetValue(Me.dgc_debit_amount, 0)
            Me.LibXGrid1.SetValue(Me.dgc_credit_amount, 0)

            LibXGrid1.refreshFooter()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub
    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
        Try
            If LibXConnector1.IsDataEditing = True Then
                If e.cell = dgc_tran_descr.Column Then
                    Dim t_valor As String = LibXGrid1.GetValue(e.row, dgc_credit_amount).ToString.Trim
                    If t_valor <> String.Empty AndAlso t_valor > 0 Then
                        SendKeys.Send("{TAB}")
                    End If
                End If

                If IsNumeric(e.value.ToString.Trim) Then
                    If e.cell = dgc_debit_amount.Column Then
                        If LibXGrid1.GetValue(e.row, dgc_debit_amount).ToString.Trim > 0 Then
                            SendKeys.Send("{TAB}")
                        End If
                    End If

                    ''If e.cell = dgc_credit_amount.Column Then
                    ''    SendKeys.Send("{TAB}")
                    ''End If
                End If
                LibXGrid1.refreshFooter()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub xtxt_invce_ncf_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_invce_ncf.Validating
        Dim ncf As String
        Dim cnt As Integer
        Dim prov As Integer
        Try
            If LibXConnector1.IsDataEditing = True Then
                ncf = Me.xtxt_invce_ncf.Text
                If Me.txtprov_code.Text <> "" Then
                    prov = Me.txtprov_code.Text
                    If Me.xtxt_invce_ncf.Text <> "" Then
                        cnt = LibX.Data.Manager.GetScalar("select count(*) from cpinvcem where invce_ncf ='" & ncf & "' and prov_code =" & prov)
                        If cnt > 0 Then
                            Me.xtxt_invce_ncf.Focus()
                            Me.xtxt_invce_ncf.Text = ""
                            Throw New ApplicationException("Este comprobante ya esta registrado!")
                        End If
                    End If
                End If
            Else
                Me.txtprov_code.Focus()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub ActivactionOFF()
        Me.xtxt_type_code.Enabled = False
        Me.xtxsuc_code.Enabled = False
        Me.LibXCombo1.Enabled = False
        Me.xdtp_due_date.Enabled = False
        Me.xlk_acct_no.Enabled = False
        Me.xlk_term_code.Enabled = False
        Me.xtxt_invce_ncf.Enabled = True
        Me.xtxprov_name.Enabled = False
        Me.xtmtotal.Enabled = False
        Me.xtxt_discamount.Enabled = False
        Me.xtxTasa.Enabled = False
        Me.txtitbis.Enabled = False
        Me.txtitbisRetenido.Enabled = False
        Me.txtprov_code.Enabled = False
        Me.txttotal_amount.Enabled = False
        Me.TextBox8.Enabled = False
        Me.txtinvce_no.Enabled = True
        xdtp_invce_date.Enabled = True
    End Sub
    Private Sub ActivactionON()
        Me.txtinvce_no.Enabled = True
        Me.xtxt_type_code.Enabled = True
        Me.xtxsuc_code.Enabled = True
        Me.LibXCombo1.Enabled = True
        Me.xdtp_due_date.Enabled = True
        Me.xlk_acct_no.Enabled = True
        Me.xlk_term_code.Enabled = True
        Me.xtxt_invce_ncf.Enabled = True
        Me.xtxprov_name.Enabled = True
        Me.xtmtotal.Enabled = False
        Me.xtxt_discamount.Enabled = True
        Me.xtxTasa.Enabled = True
        Me.txtitbis.Enabled = True
        Me.txtitbisRetenido.Enabled = True
        Me.txtprov_code.Enabled = True
        Me.txttotal_amount.Enabled = True
        Me.TextBox8.Enabled = True
    End Sub
    Private Function BalancearEntrada() As Decimal
        Dim TotalDebito As Decimal = 0
        Dim TotalCredito As Decimal = 0
        Dim Diferencia As Decimal = 0
        Try

            TotalDebito = Val(LibXGrid1.footerTable.Rows(0).Item("debit_amount").ToString.Trim)
            TotalCredito = Val(LibXGrid1.footerTable.Rows(0).Item("credit_amount").ToString.Trim)

            Diferencia = TotalDebito - TotalCredito

            Return Diferencia

        Catch ex As Exception
            Throw
        End Try

    End Function

    Private Sub xdtp_invce_date_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles xdtp_invce_date.KeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                If LibXConnector1.IsEditing And LibXConnector1.CurrentAction = LibX.LibxConnectionActions.Find Then
                    Me.xdtp_invce_date.Value = DBNull.Value
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub xdtp_invce_date_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xdtp_invce_date.Validating
        'Try
        '    oPeriodo = New SGT.Contabilidad.Entidades.Periodo
        '    oAnoFiscal = New SGT.Contabilidad.Entidades.AnoFiscal

        '    If LibXConnector1.IsDataEditing = True Then
        '        If LibX.IsNull(xdtp_invce_date.Value) = True Then
        '            Exit Sub
        '        End If

        '        If oAnoFiscal.BuscarPeriodoPorFecha(xdtp_invce_date.Value) Is Nothing Then
        '            xdtp_invce_date.Focus()
        '            Throw (New ApplicationException("No hay periodo definido para esta fecha, Verifique!"))
        '        Else
        '            oPeriodo = oAnoFiscal.BuscarPeriodoPorFecha(xdtp_invce_date.Value)
        '        End If

        '        If oPeriodo.isOpen = False Then
        '            xdtp_invce_date.Focus()
        '            Throw (New ApplicationException("El periodo para fecha establecida establecida esta cerrado, Verifique!"))
        '        End If
        '    End If
        'Catch ex As Exception
        '    LibX.Log.Show(ex)
        'End Try

    End Sub

    Private Sub xdtp_invce_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xdtp_invce_date.ValueChanged

    End Sub

    Private Sub LibxDateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibxDateTimePicker1.ValueChanged

    End Sub
End Class
