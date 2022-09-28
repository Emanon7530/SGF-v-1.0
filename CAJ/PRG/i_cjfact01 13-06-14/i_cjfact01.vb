Imports LibX
Imports System.Configuration.ConfigurationSettings
Imports SGT.Caja.Entidades
Imports SGT.Facturacion.Entidades

Public Class i_cjfact01
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents txtCajaNombre As Windows.Forms.Label
    Friend WithEvents txtCajeraNombre As Windows.Forms.Label
    Friend WithEvents txtCliNombre As Windows.Forms.Label
    Friend WithEvents txtNumeroDoc As Windows.Forms.Label
    Friend WithEvents txtVendNombre As Windows.Forms.Label
    Friend WithEvents txtMontoBruto As LibX.XTextBox
    Friend WithEvents txtDesc As LibX.XTextBox
    Friend WithEvents txtIBIS As LibX.XTextBox
    Friend WithEvents txtNeto As LibX.XTextBox
    Friend WithEvents currDate As LibX.LibxDateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtMonEfe As LibX.XMaskEdit
    Friend WithEvents txtMonTarjeta As LibX.XMaskEdit
    Friend WithEvents txtMonNota As LibX.XMaskEdit
    Friend WithEvents txtMonCxC As LibX.XMaskEdit
    Friend WithEvents txtNumChe As LibX.XTextBox
    Friend WithEvents txtTotalPagado As System.Windows.Forms.Label
    Friend WithEvents txtDevuelta As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtMonChe As LibX.XMaskEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents xlk_cust_code As LibX.LibXLookup
    Friend WithEvents txtcust_code As LibX.XTextBox
    Friend WithEvents txtbus_name As LibX.XTextBox
    Friend WithEvents txtinvce_no As LibX.XTextBox
    Friend WithEvents txtinvce_name As LibX.XTextBox
    Friend WithEvents xlk_invce_no As LibX.LibXLookup
    Friend WithEvents balance As LibX.XTextBox
    Friend WithEvents xcbo_ban_cheque As LibX.LibXCombo
    Friend WithEvents txtinvce_Serial As LibX.XTextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TabCheque As System.Windows.Forms.TabPage
    Friend WithEvents TabNC As System.Windows.Forms.TabPage
    Friend WithEvents TabCredito As System.Windows.Forms.TabPage
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As LibX.XTextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents xdt_fecha As LibX.LibxDateTimePicker
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents xtxt_phone2 As LibX.XTextBox
    Friend WithEvents xtxt_phone1 As LibX.XTextBox
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
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
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable4 As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents LibXDbSourceTable5 As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents xtxt_credit_limit As LibX.XTextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents xtxt_balance As LibX.XTextBox
    Friend WithEvents ftfactm As System.Data.DataTable
    Friend WithEvents pvtarjeta As System.Data.DataTable
    Friend WithEvents cjncrm As System.Data.DataTable
    Friend WithEvents cjchkm As System.Data.DataTable
    Friend WithEvents cjtranrv As System.Data.DataTable
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents xtxt_nc_amount As LibX.XTextBox
    Friend WithEvents xdt_nc_date As LibX.LibxDateTimePicker
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents xtxt_chk_benef As LibX.XTextBox
    Friend WithEvents xtxt_chk_amount As LibX.XTextBox
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents LibXDbSourceTable6 As LibX.LibXDbSourceTable
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ftdomim As System.Data.DataTable
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn73 As System.Data.DataColumn
    Friend WithEvents xtxt_ncr_code As LibX.XTextBox
    Friend WithEvents TabTarjeta As System.Windows.Forms.TabPage
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents xcbo_tart_code As LibX.LibXCombo
    Friend WithEvents xtxt_seg_amount As LibX.XTextBox
    Friend WithEvents DataColumn74 As System.Data.DataColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents DataColumn76 As System.Data.DataColumn
    Friend WithEvents DataColumn77 As System.Data.DataColumn
    Friend WithEvents DataColumn78 As System.Data.DataColumn
    Friend WithEvents DataColumn79 As System.Data.DataColumn
    Friend WithEvents cust_address As Windows.Forms.Label
    Friend WithEvents xtxt_type_name As Windows.Forms.Label
    Friend WithEvents xcbo_vend_mensj As LibX.LibXCombo
    Friend WithEvents DataColumn80 As System.Data.DataColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents xlxtype_code As System.Windows.Forms.Label
    Friend WithEvents DataColumn81 As System.Data.DataColumn
    Friend WithEvents DataColumn82 As System.Data.DataColumn
    Friend WithEvents DataColumn83 As System.Data.DataColumn
    Friend WithEvents DataColumn84 As System.Data.DataColumn
    Friend WithEvents DataColumn85 As System.Data.DataColumn
    Friend WithEvents DataColumn86 As System.Data.DataColumn
    Friend WithEvents xtxncf_type As LibX.XTextBox
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(i_cjfact01))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xlxtype_code = New System.Windows.Forms.Label
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
        Me.DataColumn73 = New System.Data.DataColumn
        Me.DataColumn74 = New System.Data.DataColumn
        Me.DataColumn76 = New System.Data.DataColumn
        Me.DataColumn79 = New System.Data.DataColumn
        Me.DataColumn80 = New System.Data.DataColumn
        Me.DataColumn82 = New System.Data.DataColumn
        Me.pvtarjeta = New System.Data.DataTable
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn83 = New System.Data.DataColumn
        Me.cjncrm = New System.Data.DataTable
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn84 = New System.Data.DataColumn
        Me.DataColumn85 = New System.Data.DataColumn
        Me.cjchkm = New System.Data.DataTable
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.DataColumn86 = New System.Data.DataColumn
        Me.cjtranrv = New System.Data.DataTable
        Me.DataColumn61 = New System.Data.DataColumn
        Me.DataColumn62 = New System.Data.DataColumn
        Me.DataColumn63 = New System.Data.DataColumn
        Me.DataColumn64 = New System.Data.DataColumn
        Me.DataColumn65 = New System.Data.DataColumn
        Me.DataColumn66 = New System.Data.DataColumn
        Me.DataColumn67 = New System.Data.DataColumn
        Me.DataColumn68 = New System.Data.DataColumn
        Me.DataColumn69 = New System.Data.DataColumn
        Me.DataColumn70 = New System.Data.DataColumn
        Me.DataColumn71 = New System.Data.DataColumn
        Me.DataColumn72 = New System.Data.DataColumn
        Me.DataColumn77 = New System.Data.DataColumn
        Me.DataColumn78 = New System.Data.DataColumn
        Me.ftdomim = New System.Data.DataTable
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn75 = New System.Data.DataColumn
        Me.DataColumn81 = New System.Data.DataColumn
        Me.cust_address = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.xtxt_type_name = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.xtxt_seg_amount = New LibX.XTextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.currDate = New LibX.LibxDateTimePicker
        Me.txtCliNombre = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNumeroDoc = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMontoBruto = New LibX.XTextBox
        Me.txtDesc = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtIBIS = New LibX.XTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtNeto = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtVendNombre = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable4 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable5 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable6 = New LibX.LibXDbSourceTable
        Me.txtCajaNombre = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtCajeraNombre = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtMonEfe = New LibX.XMaskEdit
        Me.txtMonTarjeta = New LibX.XMaskEdit
        Me.txtMonNota = New LibX.XMaskEdit
        Me.txtMonCxC = New LibX.XMaskEdit
        Me.txtTotalPagado = New System.Windows.Forms.Label
        Me.txtDevuelta = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtMonChe = New LibX.XMaskEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.xlk_cust_code = New LibX.LibXLookup
        Me.xlk_invce_no = New LibX.LibXLookup
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNumChe = New LibX.XTextBox
        Me.txtinvce_no = New LibX.XTextBox
        Me.txtinvce_name = New LibX.XTextBox
        Me.txtcust_code = New LibX.XTextBox
        Me.txtbus_name = New LibX.XTextBox
        Me.xcbo_ban_cheque = New LibX.LibXCombo
        Me.txtinvce_Serial = New LibX.XTextBox
        Me.balance = New LibX.XTextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabTarjeta = New System.Windows.Forms.TabPage
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.xcbo_tart_code = New LibX.LibXCombo
        Me.Label33 = New System.Windows.Forms.Label
        Me.TabNC = New System.Windows.Forms.TabPage
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.xdt_nc_date = New LibX.LibxDateTimePicker
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.xtxt_nc_amount = New LibX.XTextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.xtxt_ncr_code = New LibX.XTextBox
        Me.TabCheque = New System.Windows.Forms.TabPage
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.xtxt_chk_benef = New LibX.XTextBox
        Me.xdt_fecha = New LibX.LibxDateTimePicker
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.xtxt_chk_amount = New LibX.XTextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.TabCredito = New System.Windows.Forms.TabPage
        Me.xtxncf_type = New LibX.XTextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.xtxt_phone2 = New LibX.XTextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.xtxt_phone1 = New LibX.XTextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtaddress = New LibX.XTextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.xtxt_credit_limit = New LibX.XTextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.xtxt_balance = New LibX.XTextBox
        Me.btnAccept = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.xcbo_vend_mensj = New LibX.LibXCombo
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pvtarjeta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cjncrm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cjchkm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cjtranrv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftdomim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabTarjeta.SuspendLayout()
        Me.TabNC.SuspendLayout()
        Me.TabCheque.SuspendLayout()
        Me.TabCredito.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xlxtype_code)
        Me.GroupBox1.Controls.Add(Me.cust_address)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.xtxt_type_name)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Controls.Add(Me.xtxt_seg_amount)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.currDate)
        Me.GroupBox1.Controls.Add(Me.txtCliNombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNumeroDoc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMontoBruto)
        Me.GroupBox1.Controls.Add(Me.txtDesc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtIBIS)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtNeto)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtVendNombre)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(704, 152)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Documento"
        '
        'xlxtype_code
        '
        Me.xlxtype_code.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xlxtype_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.type_code"))
        Me.xlxtype_code.Location = New System.Drawing.Point(104, 24)
        Me.xlxtype_code.Name = "xlxtype_code"
        Me.xlxtype_code.Size = New System.Drawing.Size(80, 20)
        Me.xlxtype_code.TabIndex = 24
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftfactm, Me.pvtarjeta, Me.cjncrm, Me.cjchkm, Me.cjtranrv, Me.ftdomim})
        '
        'ftfactm
        '
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn73, Me.DataColumn74, Me.DataColumn76, Me.DataColumn79, Me.DataColumn80, Me.DataColumn82})
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
        Me.DataColumn2.ColumnName = "cust_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "ftserial_afect"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "caja_name"
        Me.DataColumn4.MaxLength = 20
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "caje_name"
        Me.DataColumn5.MaxLength = 60
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "type_name"
        Me.DataColumn6.MaxLength = 30
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "fact_number"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "fact_date"
        Me.DataColumn8.DataType = GetType(System.DateTime)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "vend_name"
        Me.DataColumn9.MaxLength = 60
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "bus_name"
        Me.DataColumn10.MaxLength = 40
        Me.DataColumn10.ReadOnly = True
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "address"
        Me.DataColumn11.MaxLength = 200
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "fact_total"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "descto"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "itbis"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "seg_amount"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "net_amount"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        Me.DataColumn16.ReadOnly = True
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.ColumnName = "type_code"
        Me.DataColumn17.MaxLength = 3
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "fact_inddomicilio"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn73
        '
        Me.DataColumn73.AllowDBNull = False
        Me.DataColumn73.ColumnName = "fact_cond"
        Me.DataColumn73.DataType = GetType(System.Int16)
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "plan_serial"
        Me.DataColumn74.DataType = GetType(System.Int32)
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "fact_ncf"
        Me.DataColumn76.MaxLength = 40
        '
        'DataColumn79
        '
        Me.DataColumn79.ColumnName = "whse_code"
        Me.DataColumn79.DataType = GetType(System.Int32)
        '
        'DataColumn80
        '
        Me.DataColumn80.ColumnName = "cia_serial"
        Me.DataColumn80.DataType = GetType(System.Int32)
        '
        'DataColumn82
        '
        Me.DataColumn82.AllowDBNull = False
        Me.DataColumn82.ColumnName = "suc_code"
        Me.DataColumn82.DataType = GetType(System.Int32)
        '
        'pvtarjeta
        '
        Me.pvtarjeta.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn58, Me.DataColumn21, Me.DataColumn22, Me.DataColumn83})
        Me.pvtarjeta.TableName = "pvtarjeta"
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "ftserial_no"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "amount"
        Me.DataColumn30.DataType = GetType(System.Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.AllowDBNull = False
        Me.DataColumn31.AutoIncrement = True
        Me.DataColumn31.ColumnName = "tarj_code"
        Me.DataColumn31.DataType = GetType(System.Int32)
        Me.DataColumn31.ReadOnly = True
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "tarj_numero"
        Me.DataColumn32.MaxLength = 30
        '
        'DataColumn34
        '
        Me.DataColumn34.AllowDBNull = False
        Me.DataColumn34.ColumnName = "tarj_tipo"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'DataColumn35
        '
        Me.DataColumn35.AllowDBNull = False
        Me.DataColumn35.ColumnName = "cust_code"
        Me.DataColumn35.DataType = GetType(System.Int32)
        '
        'DataColumn36
        '
        Me.DataColumn36.AllowDBNull = False
        Me.DataColumn36.ColumnName = "nombre"
        Me.DataColumn36.MaxLength = 50
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "ban_name"
        Me.DataColumn37.MaxLength = 40
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "ban_code"
        Me.DataColumn58.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.AllowDBNull = False
        Me.DataColumn21.ColumnName = "cust_code1"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "tarj_vence"
        Me.DataColumn22.MaxLength = 20
        '
        'DataColumn83
        '
        Me.DataColumn83.AllowDBNull = False
        Me.DataColumn83.ColumnName = "suc_code"
        Me.DataColumn83.DataType = GetType(System.Int32)
        '
        'cjncrm
        '
        Me.cjncrm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn59, Me.DataColumn19, Me.DataColumn20, Me.DataColumn84, Me.DataColumn85})
        Me.cjncrm.TableName = "cjncrm"
        '
        'DataColumn38
        '
        Me.DataColumn38.AllowDBNull = False
        Me.DataColumn38.ColumnName = "ftserial_no"
        Me.DataColumn38.DataType = GetType(System.Int32)
        '
        'DataColumn39
        '
        Me.DataColumn39.AllowDBNull = False
        Me.DataColumn39.ColumnName = "amount"
        Me.DataColumn39.DataType = GetType(System.Decimal)
        '
        'DataColumn40
        '
        Me.DataColumn40.AllowDBNull = False
        Me.DataColumn40.AutoIncrement = True
        Me.DataColumn40.ColumnName = "ncr_code"
        Me.DataColumn40.DataType = GetType(System.Int32)
        Me.DataColumn40.ReadOnly = True
        '
        'DataColumn41
        '
        Me.DataColumn41.AllowDBNull = False
        Me.DataColumn41.ColumnName = "type_code"
        Me.DataColumn41.MaxLength = 3
        '
        'DataColumn44
        '
        Me.DataColumn44.AllowDBNull = False
        Me.DataColumn44.ColumnName = "ncr_date"
        Me.DataColumn44.DataType = GetType(System.DateTime)
        '
        'DataColumn45
        '
        Me.DataColumn45.AllowDBNull = False
        Me.DataColumn45.ColumnName = "ncr_amount"
        Me.DataColumn45.DataType = GetType(System.Decimal)
        '
        'DataColumn46
        '
        Me.DataColumn46.AllowDBNull = False
        Me.DataColumn46.ColumnName = "ncr_balance"
        Me.DataColumn46.DataType = GetType(System.Decimal)
        '
        'DataColumn47
        '
        Me.DataColumn47.AllowDBNull = False
        Me.DataColumn47.ColumnName = "ftserial_no1"
        Me.DataColumn47.DataType = GetType(System.Int32)
        '
        'DataColumn48
        '
        Me.DataColumn48.AllowDBNull = False
        Me.DataColumn48.ColumnName = "ncr_estatus"
        Me.DataColumn48.DataType = GetType(System.Int32)
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "bus_name"
        Me.DataColumn59.MaxLength = 60
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "ncr_number"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "ncr_ncf"
        Me.DataColumn20.MaxLength = 20
        '
        'DataColumn84
        '
        Me.DataColumn84.AllowDBNull = False
        Me.DataColumn84.ColumnName = "suc_code"
        Me.DataColumn84.DataType = GetType(System.Int32)
        '
        'DataColumn85
        '
        Me.DataColumn85.AllowDBNull = False
        Me.DataColumn85.ColumnName = "suc_code1"
        Me.DataColumn85.DataType = GetType(System.Int32)
        '
        'cjchkm
        '
        Me.cjchkm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn60, Me.DataColumn86})
        Me.cjchkm.TableName = "cjchkm"
        '
        'DataColumn49
        '
        Me.DataColumn49.AllowDBNull = False
        Me.DataColumn49.ColumnName = "ftserial_no"
        Me.DataColumn49.DataType = GetType(System.Int32)
        '
        'DataColumn50
        '
        Me.DataColumn50.AllowDBNull = False
        Me.DataColumn50.ColumnName = "amount"
        Me.DataColumn50.DataType = GetType(System.Decimal)
        '
        'DataColumn51
        '
        Me.DataColumn51.AllowDBNull = False
        Me.DataColumn51.AutoIncrement = True
        Me.DataColumn51.ColumnName = "chk_code"
        Me.DataColumn51.DataType = GetType(System.Int32)
        Me.DataColumn51.ReadOnly = True
        '
        'DataColumn52
        '
        Me.DataColumn52.AllowDBNull = False
        Me.DataColumn52.ColumnName = "chk_date"
        Me.DataColumn52.DataType = GetType(System.DateTime)
        '
        'DataColumn53
        '
        Me.DataColumn53.AllowDBNull = False
        Me.DataColumn53.ColumnName = "chk_amount"
        Me.DataColumn53.DataType = GetType(System.Decimal)
        '
        'DataColumn54
        '
        Me.DataColumn54.AllowDBNull = False
        Me.DataColumn54.ColumnName = "ban_code"
        Me.DataColumn54.DataType = GetType(System.Int32)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "chk_benef"
        Me.DataColumn55.MaxLength = 80
        '
        'DataColumn56
        '
        Me.DataColumn56.AllowDBNull = False
        Me.DataColumn56.ColumnName = "chk_estatus"
        Me.DataColumn56.DataType = GetType(System.Int32)
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "cust_code"
        Me.DataColumn57.DataType = GetType(System.Int32)
        '
        'DataColumn60
        '
        Me.DataColumn60.AllowDBNull = False
        Me.DataColumn60.ColumnName = "chk_number"
        Me.DataColumn60.DataType = GetType(System.Int32)
        '
        'DataColumn86
        '
        Me.DataColumn86.AllowDBNull = False
        Me.DataColumn86.ColumnName = "suc_code"
        Me.DataColumn86.DataType = GetType(System.Int32)
        '
        'cjtranrv
        '
        Me.cjtranrv.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72, Me.DataColumn77, Me.DataColumn78})
        Me.cjtranrv.TableName = "cjtranrv"
        '
        'DataColumn61
        '
        Me.DataColumn61.AllowDBNull = False
        Me.DataColumn61.ColumnName = "ftserial_no"
        Me.DataColumn61.DataType = GetType(System.Int32)
        '
        'DataColumn62
        '
        Me.DataColumn62.AllowDBNull = False
        Me.DataColumn62.ColumnName = "init_serial"
        Me.DataColumn62.DataType = GetType(System.Int32)
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "efectivo"
        Me.DataColumn63.DataType = GetType(System.Decimal)
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "tarjeta"
        Me.DataColumn64.DataType = GetType(System.Decimal)
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "credito"
        Me.DataColumn65.DataType = GetType(System.Decimal)
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "notacredito"
        Me.DataColumn66.DataType = GetType(System.Decimal)
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "cheque"
        Me.DataColumn67.DataType = GetType(System.Decimal)
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "seguro"
        Me.DataColumn68.DataType = GetType(System.Decimal)
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "cust_code"
        Me.DataColumn69.DataType = GetType(System.Int32)
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "tarj_code"
        Me.DataColumn70.DataType = GetType(System.Int32)
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "ncr_code"
        Me.DataColumn71.DataType = GetType(System.Int32)
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "chk_code"
        Me.DataColumn72.DataType = GetType(System.Int32)
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "vuelto"
        Me.DataColumn77.DataType = GetType(System.Decimal)
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "tart_code"
        Me.DataColumn78.DataType = GetType(System.Int32)
        '
        'ftdomim
        '
        Me.ftdomim.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn33, Me.DataColumn42, Me.DataColumn43, Me.DataColumn75, Me.DataColumn81})
        Me.ftdomim.TableName = "ftdomim"
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "ftserial_no"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.ColumnName = "cust_code"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "domi_date"
        Me.DataColumn25.DataType = GetType(System.DateTime)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "domi_cambio"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "vend_mensaj"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.ColumnName = "domi_estatus"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "domi_pago"
        Me.DataColumn33.MaxLength = 3
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "tarj_code"
        Me.DataColumn42.DataType = GetType(System.Int32)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "vend_name"
        Me.DataColumn43.MaxLength = 60
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "tarj_tipo"
        Me.DataColumn75.DataType = GetType(System.Int32)
        '
        'DataColumn81
        '
        Me.DataColumn81.AllowDBNull = False
        Me.DataColumn81.ColumnName = "suc_code"
        Me.DataColumn81.DataType = GetType(System.Int32)
        '
        'cust_address
        '
        Me.cust_address.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cust_address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.address"))
        Me.cust_address.Location = New System.Drawing.Point(104, 120)
        Me.cust_address.Name = "cust_address"
        Me.cust_address.Size = New System.Drawing.Size(352, 20)
        Me.cust_address.TabIndex = 23
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label43.Location = New System.Drawing.Point(34, 120)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(55, 16)
        Me.Label43.TabIndex = 22
        Me.Label43.Text = "Dirección:"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_type_name
        '
        Me.xtxt_type_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xtxt_type_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.type_name"))
        Me.xtxt_type_name.Location = New System.Drawing.Point(184, 24)
        Me.xtxt_type_name.Name = "xtxt_type_name"
        Me.xtxt_type_name.Size = New System.Drawing.Size(272, 20)
        Me.xtxt_type_name.TabIndex = 21
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label42.Location = New System.Drawing.Point(24, 24)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(65, 16)
        Me.Label42.TabIndex = 20
        Me.Label42.Text = "Documento:"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_seg_amount
        '
        Me.xtxt_seg_amount.AcceptsReturn = True
        Me.xtxt_seg_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.seg_amount"))
        Me.xtxt_seg_amount.EditInitialValue = Nothing
        Me.xtxt_seg_amount.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_seg_amount.FieldDescription = ""
        Me.xtxt_seg_amount.FindInitialValue = Nothing
        Me.xtxt_seg_amount.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_seg_amount.IgnoreRequiered = False
        Me.xtxt_seg_amount.Location = New System.Drawing.Point(600, 88)
        Me.xtxt_seg_amount.Name = "xtxt_seg_amount"
        Me.xtxt_seg_amount.NewInitialValue = Nothing
        Me.xtxt_seg_amount.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_seg_amount.ReadOnly = True
        Me.xtxt_seg_amount.Requiered = False
        Me.xtxt_seg_amount.Size = New System.Drawing.Size(96, 20)
        Me.xtxt_seg_amount.StatusBarPanelDescripcion = Nothing
        Me.xtxt_seg_amount.TabIndex = 19
        Me.xtxt_seg_amount.TabStop = False
        Me.xtxt_seg_amount.Text = ""
        Me.xtxt_seg_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label41.Location = New System.Drawing.Point(505, 88)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(83, 16)
        Me.Label41.TabIndex = 18
        Me.Label41.Text = "Seguro Médico:"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'currDate
        '
        Me.currDate.CustomFormat = "dd/MM/yyyy"
        Me.currDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.fact_date"))
        Me.currDate.EditInitialValue = Nothing
        Me.currDate.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.currDate.FieldDescription = ""
        Me.currDate.FindInitialValue = Nothing
        Me.currDate.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.currDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.currDate.IgnoreRequiered = False
        Me.currDate.Location = New System.Drawing.Point(360, 48)
        Me.currDate.Name = "currDate"
        Me.currDate.NewInitialValue = Nothing
        Me.currDate.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.currDate.Requiered = False
        Me.currDate.Size = New System.Drawing.Size(96, 20)
        Me.currDate.StatusBarPanelDescripcion = Nothing
        Me.currDate.TabIndex = 17
        Me.currDate.TabStop = False
        '
        'txtCliNombre
        '
        Me.txtCliNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCliNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.bus_name"))
        Me.txtCliNombre.Location = New System.Drawing.Point(104, 96)
        Me.txtCliNombre.Name = "txtCliNombre"
        Me.txtCliNombre.Size = New System.Drawing.Size(352, 20)
        Me.txtCliNombre.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(46, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cliente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNumeroDoc
        '
        Me.txtNumeroDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtNumeroDoc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_number"))
        Me.txtNumeroDoc.Location = New System.Drawing.Point(104, 48)
        Me.txtNumeroDoc.Name = "txtNumeroDoc"
        Me.txtNumeroDoc.Size = New System.Drawing.Size(80, 20)
        Me.txtNumeroDoc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(41, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(312, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMontoBruto
        '
        Me.txtMontoBruto.AcceptsReturn = True
        Me.txtMontoBruto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_total"))
        Me.txtMontoBruto.EditInitialValue = Nothing
        Me.txtMontoBruto.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtMontoBruto.FieldDescription = ""
        Me.txtMontoBruto.FindInitialValue = Nothing
        Me.txtMontoBruto.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtMontoBruto.IgnoreRequiered = False
        Me.txtMontoBruto.Location = New System.Drawing.Point(600, 16)
        Me.txtMontoBruto.Name = "txtMontoBruto"
        Me.txtMontoBruto.NewInitialValue = Nothing
        Me.txtMontoBruto.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtMontoBruto.ReadOnly = True
        Me.txtMontoBruto.Requiered = False
        Me.txtMontoBruto.Size = New System.Drawing.Size(96, 20)
        Me.txtMontoBruto.StatusBarPanelDescripcion = Nothing
        Me.txtMontoBruto.TabIndex = 1
        Me.txtMontoBruto.TabStop = False
        Me.txtMontoBruto.Text = ""
        Me.txtMontoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc
        '
        Me.txtDesc.AcceptsReturn = True
        Me.txtDesc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.descto"))
        Me.txtDesc.EditInitialValue = Nothing
        Me.txtDesc.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtDesc.FieldDescription = ""
        Me.txtDesc.FindInitialValue = Nothing
        Me.txtDesc.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtDesc.IgnoreRequiered = False
        Me.txtDesc.Location = New System.Drawing.Point(600, 40)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.NewInitialValue = Nothing
        Me.txtDesc.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtDesc.ReadOnly = True
        Me.txtDesc.Requiered = False
        Me.txtDesc.Size = New System.Drawing.Size(96, 20)
        Me.txtDesc.StatusBarPanelDescripcion = Nothing
        Me.txtDesc.TabIndex = 1
        Me.txtDesc.TabStop = False
        Me.txtDesc.Text = ""
        Me.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(527, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Descuento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtIBIS
        '
        Me.txtIBIS.AcceptsReturn = True
        Me.txtIBIS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.itbis"))
        Me.txtIBIS.EditInitialValue = Nothing
        Me.txtIBIS.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtIBIS.FieldDescription = ""
        Me.txtIBIS.FindInitialValue = Nothing
        Me.txtIBIS.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtIBIS.IgnoreRequiered = False
        Me.txtIBIS.Location = New System.Drawing.Point(600, 64)
        Me.txtIBIS.Name = "txtIBIS"
        Me.txtIBIS.NewInitialValue = Nothing
        Me.txtIBIS.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtIBIS.ReadOnly = True
        Me.txtIBIS.Requiered = False
        Me.txtIBIS.Size = New System.Drawing.Size(96, 20)
        Me.txtIBIS.StatusBarPanelDescripcion = Nothing
        Me.txtIBIS.TabIndex = 1
        Me.txtIBIS.TabStop = False
        Me.txtIBIS.Text = ""
        Me.txtIBIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(560, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Itbis:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNeto
        '
        Me.txtNeto.AcceptsReturn = True
        Me.txtNeto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.net_amount"))
        Me.txtNeto.EditInitialValue = Nothing
        Me.txtNeto.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtNeto.FieldDescription = ""
        Me.txtNeto.FindInitialValue = Nothing
        Me.txtNeto.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNeto.ForeColor = System.Drawing.Color.Blue
        Me.txtNeto.IgnoreRequiered = False
        Me.txtNeto.Location = New System.Drawing.Point(600, 112)
        Me.txtNeto.Name = "txtNeto"
        Me.txtNeto.NewInitialValue = Nothing
        Me.txtNeto.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtNeto.ReadOnly = True
        Me.txtNeto.Requiered = False
        Me.txtNeto.Size = New System.Drawing.Size(96, 26)
        Me.txtNeto.StatusBarPanelDescripcion = Nothing
        Me.txtNeto.TabIndex = 1
        Me.txtNeto.TabStop = False
        Me.txtNeto.Text = ""
        Me.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(498, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total Neto:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(519, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Monto Bruto:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtVendNombre
        '
        Me.txtVendNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtVendNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.vend_name"))
        Me.txtVendNombre.Location = New System.Drawing.Point(104, 72)
        Me.txtVendNombre.Name = "txtVendNombre"
        Me.txtVendNombre.Size = New System.Drawing.Size(352, 20)
        Me.txtVendNombre.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Location = New System.Drawing.Point(33, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 16)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Vendedor:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = False
        Me.LibXConnector1.AllowNew = False
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "ftfactm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = True
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = "PTV"
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = "r_pvfact01.rpt"
        Me.LibXConnector1.RequeryData = True
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2, Me.LibXDbSourceTable3, Me.LibXDbSourceTable4, Me.LibXDbSourceTable5, Me.LibXDbSourceTable6})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
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
        Me.LibXDbSourceTable1.KeyFields = "ftserial_no"
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "ftserial_no"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select ftfactm.ftserial_no,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.whse_code,", "ftfactm.suc_code,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.type_code,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.fact_inddomicilio,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.cust_code,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.ftserial_afect,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.fact_cond,", "" & Microsoft.VisualBasic.ChrW(9) & "cjcajam.caja_name,", "" & Microsoft.VisualBasic.ChrW(9) & "cjcajem.vend_name caje_name,", "" & Microsoft.VisualBasic.ChrW(9) & "ivtypem.[type_name],", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.fact_number,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.fact_date,", "" & Microsoft.VisualBasic.ChrW(9) & "ftvendm.vend_name,", "" & Microsoft.VisualBasic.ChrW(9) & "substring(bus_name,1,40)bus_name,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.address,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.fact_total,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.descto,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.itbis,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.seg_amount,", "" & Microsoft.VisualBasic.ChrW(9) & "ftsegrm.plan_serial,", "" & Microsoft.VisualBasic.ChrW(9) & "ftsegrm.cia_serial,", "" & Microsoft.VisualBasic.ChrW(9) & "(isnull(ftfactm.fact_total,0) - ", "" & Microsoft.VisualBasic.ChrW(9) & "isnull(ftfactm.descto,0) - ", "" & Microsoft.VisualBasic.ChrW(9) & "isnull(ftfactm.seg_amount,0) + ", "" & Microsoft.VisualBasic.ChrW(9) & "isnull(ftfactm.itbis,0)) net_amount,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.fact_ncf", "from ftfactm", "inner join ivtypem", "on ivtypem.type_code = ftfactm.type_code ", "left outer join cjcajam", "on cjcajam.caja_code = ftfactm.caja_code", "left outer join ftvendm cjcajem", "on cjcajem.vend_code = ftfactm.caje_code", "left outer join ftvendm", "on ftvendm.vend_code = ftfactm.vend_code", "left outer join ftsegrm", "on ftsegrm.ftserial_no = ftfactm.ftserial_no"}
        Me.LibXDbSourceTable1.TableName = "ftfactm"
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
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"ftserial_no=ftserial_no"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = Nothing
        Me.LibXDbSourceTable2.TableName = "cjtranrv"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
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
        Me.LibXDbSourceTable3.FillOnRowChange = True
        Me.LibXDbSourceTable3.HeaderIsOnGrid = False
        Me.LibXDbSourceTable3.InnerJon = False
        Me.LibXDbSourceTable3.InsertOrder = 0
        Me.LibXDbSourceTable3.IsDetail = True
        Me.LibXDbSourceTable3.KeyFields = Nothing
        Me.LibXDbSourceTable3.LineColName = Nothing
        Me.LibXDbSourceTable3.MasterDetailRelation = New String() {"ftserial_no=ftserial_no", "suc_code=suc_code"}
        Me.LibXDbSourceTable3.MasterTableName = Nothing
        Me.LibXDbSourceTable3.SerialColumnName = "tarj_code"
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = New String() {"select cjtranrm.ftserial_no,", "               cjtranrm.suc_code,", "" & Microsoft.VisualBasic.ChrW(9) & "cjtranrm.amount,", "" & Microsoft.VisualBasic.ChrW(9) & "pvtarjeta.*,", "" & Microsoft.VisualBasic.ChrW(9) & "pvtipotarm.ban_code,", "" & Microsoft.VisualBasic.ChrW(9) & "pvtipotarm.cust_code,", "" & Microsoft.VisualBasic.ChrW(9) & "pvtipotarm.nombre,", "" & Microsoft.VisualBasic.ChrW(9) & "ftbanco.ban_name", "from cjtranrm", "inner join pvtarjeta", "on pvtarjeta.tarj_code = cjtranrm.tarj_code", "inner join pvtipotarm", "on pvtipotarm.tart_code = pvtarjeta.tarj_tipo", "left outer join ftbanco", "on ftbanco.ban_code = pvtipotarm.ban_code"}
        Me.LibXDbSourceTable3.TableName = "pvtarjeta"
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
        Me.LibXDbSourceTable4.InnerJon = False
        Me.LibXDbSourceTable4.InsertOrder = 0
        Me.LibXDbSourceTable4.IsDetail = True
        Me.LibXDbSourceTable4.KeyFields = Nothing
        Me.LibXDbSourceTable4.LineColName = Nothing
        Me.LibXDbSourceTable4.MasterDetailRelation = New String() {"ftserial_no=ftserial_no", "suc_code=suc_code"}
        Me.LibXDbSourceTable4.MasterTableName = Nothing
        Me.LibXDbSourceTable4.SerialColumnName = "ncr_code"
        Me.LibXDbSourceTable4.Sort = Nothing
        Me.LibXDbSourceTable4.Source = New String() {"select cjtranrm.ftserial_no,", "                cjtranrm.suc_code,", "" & Microsoft.VisualBasic.ChrW(9) & "cjtranrm.amount,", "" & Microsoft.VisualBasic.ChrW(9) & "cjncrm.*", "from cjtranrm", "inner join cjncrm", "on cjncrm.ncr_code = cjtranrm.ncr_code"}
        Me.LibXDbSourceTable4.TableName = "cjncrm"
        Me.LibXDbSourceTable4.UpdateOrder = 0
        Me.LibXDbSourceTable4.UseRowRetrieve = False
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
        Me.LibXDbSourceTable5.FillOnRowChange = True
        Me.LibXDbSourceTable5.HeaderIsOnGrid = False
        Me.LibXDbSourceTable5.InnerJon = False
        Me.LibXDbSourceTable5.InsertOrder = 0
        Me.LibXDbSourceTable5.IsDetail = True
        Me.LibXDbSourceTable5.KeyFields = Nothing
        Me.LibXDbSourceTable5.LineColName = Nothing
        Me.LibXDbSourceTable5.MasterDetailRelation = New String() {"ftserial_no=ftserial_no", "suc_code=suc_code"}
        Me.LibXDbSourceTable5.MasterTableName = Nothing
        Me.LibXDbSourceTable5.SerialColumnName = "chk_code"
        Me.LibXDbSourceTable5.Sort = Nothing
        Me.LibXDbSourceTable5.Source = New String() {"select cjtranrm.ftserial_no,", "                cjtranrm.suc_code,", "" & Microsoft.VisualBasic.ChrW(9) & "cjtranrm.amount,", "" & Microsoft.VisualBasic.ChrW(9) & "cjchkm.*", "from cjtranrm", "inner join cjchkm", "on cjchkm.chk_code = cjtranrm.chk_code"}
        Me.LibXDbSourceTable5.TableName = "cjchkm"
        Me.LibXDbSourceTable5.UpdateOrder = 0
        Me.LibXDbSourceTable5.UseRowRetrieve = False
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
        Me.LibXDbSourceTable6.InnerJon = False
        Me.LibXDbSourceTable6.InsertOrder = 0
        Me.LibXDbSourceTable6.IsDetail = True
        Me.LibXDbSourceTable6.KeyFields = Nothing
        Me.LibXDbSourceTable6.LineColName = Nothing
        Me.LibXDbSourceTable6.MasterDetailRelation = New String() {"ftserial_no=ftserial_no", "suc_code=suc_code"}
        Me.LibXDbSourceTable6.MasterTableName = Nothing
        Me.LibXDbSourceTable6.SerialColumnName = Nothing
        Me.LibXDbSourceTable6.Sort = Nothing
        Me.LibXDbSourceTable6.Source = New String() {"select ftdomim.*,vend_name,tarj_tipo ", "from ftdomim", "left outer join ftvendm", "on ftvendm.vend_code = ftdomim.vend_mensaj", "left outer join pvtarjeta", "on pvtarjeta.tarj_code = ftdomim.tarj_code"}
        Me.LibXDbSourceTable6.TableName = "ftdomim"
        Me.LibXDbSourceTable6.UpdateOrder = 0
        Me.LibXDbSourceTable6.UseRowRetrieve = False
        '
        'txtCajaNombre
        '
        Me.txtCajaNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCajaNombre.Location = New System.Drawing.Point(112, 8)
        Me.txtCajaNombre.Name = "txtCajaNombre"
        Me.txtCajaNombre.Size = New System.Drawing.Size(232, 20)
        Me.txtCajaNombre.TabIndex = 19
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label18.Location = New System.Drawing.Point(72, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 16)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Caja:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Location = New System.Drawing.Point(368, 8)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 16)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Cajera:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCajeraNombre
        '
        Me.txtCajeraNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCajeraNombre.Location = New System.Drawing.Point(416, 8)
        Me.txtCajeraNombre.Name = "txtCajeraNombre"
        Me.txtCajeraNombre.Size = New System.Drawing.Size(296, 20)
        Me.txtCajeraNombre.TabIndex = 19
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtMonEfe)
        Me.GroupBox4.Controls.Add(Me.txtMonTarjeta)
        Me.GroupBox4.Controls.Add(Me.txtMonNota)
        Me.GroupBox4.Controls.Add(Me.txtMonCxC)
        Me.GroupBox4.Controls.Add(Me.txtTotalPagado)
        Me.GroupBox4.Controls.Add(Me.txtDevuelta)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txtMonChe)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox4.Location = New System.Drawing.Point(8, 192)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(248, 240)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Forma de Pago"
        '
        'Label10
        '
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(48, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Efectivo:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(12, 176)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 24)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Total pagado:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMonEfe
        '
        Me.txtMonEfe.AcceptsReturn = True
        Me.txtMonEfe.AcceptsTab = True
        Me.txtMonEfe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjtranrv.efectivo"))
        Me.txtMonEfe.EditInitialValue = Nothing
        Me.txtMonEfe.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMonEfe.FieldDescription = ""
        Me.txtMonEfe.FindInitialValue = Nothing
        Me.txtMonEfe.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMonEfe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonEfe.IgnoreRequiered = False
        Me.txtMonEfe.Location = New System.Drawing.Point(120, 16)
        Me.txtMonEfe.Masked = MaskedTextBox.Mask.Decimal
        Me.txtMonEfe.Name = "txtMonEfe"
        Me.txtMonEfe.NewInitialValue = Nothing
        Me.txtMonEfe.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMonEfe.Requiered = False
        Me.txtMonEfe.Size = New System.Drawing.Size(120, 26)
        Me.txtMonEfe.StatusBarPanelDescripcion = Nothing
        Me.txtMonEfe.TabIndex = 0
        Me.txtMonEfe.Text = ""
        Me.txtMonEfe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonTarjeta
        '
        Me.txtMonTarjeta.AcceptsReturn = True
        Me.txtMonTarjeta.AcceptsTab = True
        Me.txtMonTarjeta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjtranrv.tarjeta"))
        Me.txtMonTarjeta.EditInitialValue = Nothing
        Me.txtMonTarjeta.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMonTarjeta.FieldDescription = ""
        Me.txtMonTarjeta.FindInitialValue = Nothing
        Me.txtMonTarjeta.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMonTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonTarjeta.IgnoreRequiered = False
        Me.txtMonTarjeta.Location = New System.Drawing.Point(120, 48)
        Me.txtMonTarjeta.Masked = MaskedTextBox.Mask.Decimal
        Me.txtMonTarjeta.Name = "txtMonTarjeta"
        Me.txtMonTarjeta.NewInitialValue = Nothing
        Me.txtMonTarjeta.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMonTarjeta.Requiered = False
        Me.txtMonTarjeta.Size = New System.Drawing.Size(120, 26)
        Me.txtMonTarjeta.StatusBarPanelDescripcion = Nothing
        Me.txtMonTarjeta.TabIndex = 1
        Me.txtMonTarjeta.Text = ""
        Me.txtMonTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonNota
        '
        Me.txtMonNota.AcceptsReturn = True
        Me.txtMonNota.AcceptsTab = True
        Me.txtMonNota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjtranrv.notacredito"))
        Me.txtMonNota.EditInitialValue = Nothing
        Me.txtMonNota.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMonNota.FieldDescription = ""
        Me.txtMonNota.FindInitialValue = Nothing
        Me.txtMonNota.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMonNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonNota.IgnoreRequiered = False
        Me.txtMonNota.Location = New System.Drawing.Point(120, 112)
        Me.txtMonNota.Masked = MaskedTextBox.Mask.Decimal
        Me.txtMonNota.Name = "txtMonNota"
        Me.txtMonNota.NewInitialValue = Nothing
        Me.txtMonNota.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMonNota.Requiered = False
        Me.txtMonNota.Size = New System.Drawing.Size(120, 26)
        Me.txtMonNota.StatusBarPanelDescripcion = Nothing
        Me.txtMonNota.TabIndex = 3
        Me.txtMonNota.Text = ""
        Me.txtMonNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonCxC
        '
        Me.txtMonCxC.AcceptsReturn = True
        Me.txtMonCxC.AcceptsTab = True
        Me.txtMonCxC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjtranrv.credito"))
        Me.txtMonCxC.EditInitialValue = Nothing
        Me.txtMonCxC.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMonCxC.FieldDescription = ""
        Me.txtMonCxC.FindInitialValue = Nothing
        Me.txtMonCxC.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMonCxC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonCxC.IgnoreRequiered = False
        Me.txtMonCxC.Location = New System.Drawing.Point(120, 144)
        Me.txtMonCxC.Masked = MaskedTextBox.Mask.Decimal
        Me.txtMonCxC.Name = "txtMonCxC"
        Me.txtMonCxC.NewInitialValue = Nothing
        Me.txtMonCxC.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMonCxC.Requiered = False
        Me.txtMonCxC.Size = New System.Drawing.Size(120, 26)
        Me.txtMonCxC.StatusBarPanelDescripcion = Nothing
        Me.txtMonCxC.TabIndex = 4
        Me.txtMonCxC.Text = ""
        Me.txtMonCxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalPagado
        '
        Me.txtTotalPagado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTotalPagado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtTotalPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalPagado.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalPagado.Location = New System.Drawing.Point(120, 176)
        Me.txtTotalPagado.Name = "txtTotalPagado"
        Me.txtTotalPagado.Size = New System.Drawing.Size(120, 26)
        Me.txtTotalPagado.TabIndex = 23
        Me.txtTotalPagado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDevuelta
        '
        Me.txtDevuelta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtDevuelta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cjtranrv, "vuelto"))
        Me.txtDevuelta.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtDevuelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtDevuelta.ForeColor = System.Drawing.Color.Red
        Me.txtDevuelta.Location = New System.Drawing.Point(120, 208)
        Me.txtDevuelta.Name = "txtDevuelta"
        Me.txtDevuelta.Size = New System.Drawing.Size(120, 26)
        Me.txtDevuelta.TabIndex = 25
        Me.txtDevuelta.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label20
        '
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(12, 208)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 16)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Devuelta:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMonChe
        '
        Me.txtMonChe.AcceptsReturn = True
        Me.txtMonChe.AcceptsTab = True
        Me.txtMonChe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjtranrv.cheque"))
        Me.txtMonChe.EditInitialValue = Nothing
        Me.txtMonChe.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMonChe.FieldDescription = ""
        Me.txtMonChe.FindInitialValue = Nothing
        Me.txtMonChe.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMonChe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonChe.IgnoreRequiered = False
        Me.txtMonChe.Location = New System.Drawing.Point(120, 80)
        Me.txtMonChe.Masked = MaskedTextBox.Mask.Decimal
        Me.txtMonChe.Name = "txtMonChe"
        Me.txtMonChe.NewInitialValue = Nothing
        Me.txtMonChe.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtMonChe.Requiered = False
        Me.txtMonChe.Size = New System.Drawing.Size(120, 26)
        Me.txtMonChe.StatusBarPanelDescripcion = Nothing
        Me.txtMonChe.TabIndex = 2
        Me.txtMonChe.Text = ""
        Me.txtMonChe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(12, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Tarjeta:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(48, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Cheque:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 16)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Nota Crédito:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label22
        '
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(56, 144)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 16)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "Crédito:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_cust_code
        '
        Me.xlk_cust_code.AlternateFieldSearch = Nothing
        Me.xlk_cust_code.BeginCheck = False
        Me.xlk_cust_code.CheckText = Nothing
        Me.xlk_cust_code.ComboMode = False
        Me.xlk_cust_code.DataMember = "ftfactm"
        Me.xlk_cust_code.DataSource = Me.LibXConnector1
        Me.xlk_cust_code.DestParameters = New String() {"cust_code=cust_code", "txtbus_name=cust_name", "txtaddress=cust_address", "xtxt_phone1=cust_phone", "xtxt_phone2=cust_cellphone", "xtxt_balance=balance", "xtxt_credit_limit=credit_limit", "xtxncf_type=ncf_type"}
        Me.xlk_cust_code.FilterField = "cust_name"
        Me.xlk_cust_code.IgnoreFindInBrowseMode = False
        Me.xlk_cust_code.isCanceled = False
        Me.xlk_cust_code.Location = New System.Drawing.Point(200, 8)
        Me.xlk_cust_code.LookCaption = "Clientes"
        Me.xlk_cust_code.Name = "xlk_cust_code"
        Me.xlk_cust_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_cust_code.ShowFilter = True
        Me.xlk_cust_code.ShowMessageNotFound = False
        Me.xlk_cust_code.ShowWarning = False
        Me.xlk_cust_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_cust_code.SizesColumns = New String() {"cust_name=350"}
        Me.xlk_cust_code.SizesColumnsTab = Nothing
        Me.xlk_cust_code.SqlString = Nothing
        Me.xlk_cust_code.SQLTab = Nothing
        Me.xlk_cust_code.SrcParameters = New String() {"cust_code=cust_code"}
        Me.xlk_cust_code.TabIndex = 21
        Me.xlk_cust_code.TableName = "cccustm"
        Me.xlk_cust_code.TabStop = False
        Me.xlk_cust_code.UseCopyConnection = False
        Me.xlk_cust_code.UseRowRetrieveEvents = False
        Me.xlk_cust_code.UseTab = False
        Me.xlk_cust_code.Visible = False
        Me.xlk_cust_code.VisParameters = New String() {"Código=cust_code", "Nombre=cust_name", "Límite de Crédito=credit_limit", "Balance=Balance"}
        Me.xlk_cust_code.WhereCondition = ""
        Me.xlk_cust_code.WhereParameters = Nothing
        '
        'xlk_invce_no
        '
        Me.xlk_invce_no.AlternateFieldSearch = Nothing
        Me.xlk_invce_no.BeginCheck = False
        Me.xlk_invce_no.CheckText = Nothing
        Me.xlk_invce_no.ComboMode = False
        Me.xlk_invce_no.DataMember = "cjncrm"
        Me.xlk_invce_no.DataSource = Me.LibXConnector1
        Me.xlk_invce_no.DestParameters = New String() {"ncr_code=ncr_code", "ncr_number=ncr_number", "type_code=type_code", "ncr_date=ncr_date", "bus_name=bus_name", "ncr_amount=ncr_amount", "ncr_balance=ncr_balance", "ncr_estatus=ncr_estatus"}
        Me.xlk_invce_no.FilterField = "bus_name"
        Me.xlk_invce_no.IgnoreFindInBrowseMode = False
        Me.xlk_invce_no.isCanceled = False
        Me.xlk_invce_no.Location = New System.Drawing.Point(184, 8)
        Me.xlk_invce_no.LookCaption = "Notas de Crédito"
        Me.xlk_invce_no.Name = "xlk_invce_no"
        Me.xlk_invce_no.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_invce_no.ShowFilter = True
        Me.xlk_invce_no.ShowMessageNotFound = True
        Me.xlk_invce_no.ShowWarning = False
        Me.xlk_invce_no.Size = New System.Drawing.Size(16, 20)
        Me.xlk_invce_no.SizesColumns = New String() {"bus_name=200"}
        Me.xlk_invce_no.SizesColumnsTab = Nothing
        Me.xlk_invce_no.SqlString = New String() {Nothing}
        Me.xlk_invce_no.SQLTab = Nothing
        Me.xlk_invce_no.SrcParameters = New String() {"ncr_number=ncr_number"}
        Me.xlk_invce_no.TabIndex = 16
        Me.xlk_invce_no.TableName = "cjncrm"
        Me.xlk_invce_no.TabStop = False
        Me.xlk_invce_no.UseCopyConnection = False
        Me.xlk_invce_no.UseRowRetrieveEvents = False
        Me.xlk_invce_no.UseTab = False
        Me.xlk_invce_no.Visible = False
        Me.xlk_invce_no.VisParameters = New String() {"Número=ncr_number", "Fecha=ncr_date", "Cliente=bus_name", "Monto Original=ncr_amount", "Balance=ncr_balance"}
        Me.xlk_invce_no.WhereCondition = "ncr_estatus = 1"
        Me.xlk_invce_no.WhereParameters = Nothing
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(40, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 16)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Banco:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(8, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cheque No.:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNumChe
        '
        Me.txtNumChe.AcceptsReturn = True
        Me.txtNumChe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjchkm.chk_number"))
        Me.txtNumChe.EditInitialValue = Nothing
        Me.txtNumChe.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtNumChe.FieldDescription = ""
        Me.txtNumChe.FindInitialValue = Nothing
        Me.txtNumChe.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtNumChe.IgnoreRequiered = False
        Me.txtNumChe.Location = New System.Drawing.Point(88, 8)
        Me.txtNumChe.Name = "txtNumChe"
        Me.txtNumChe.NewInitialValue = Nothing
        Me.txtNumChe.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtNumChe.Requiered = False
        Me.txtNumChe.Size = New System.Drawing.Size(144, 20)
        Me.txtNumChe.StatusBarPanelDescripcion = Nothing
        Me.txtNumChe.TabIndex = 0
        Me.txtNumChe.Text = ""
        '
        'txtinvce_no
        '
        Me.txtinvce_no.AcceptsReturn = True
        Me.txtinvce_no.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjncrm.ncr_number"))
        Me.txtinvce_no.EditInitialValue = Nothing
        Me.txtinvce_no.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtinvce_no.FieldDescription = ""
        Me.txtinvce_no.FindInitialValue = Nothing
        Me.txtinvce_no.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtinvce_no.IgnoreRequiered = False
        Me.txtinvce_no.Location = New System.Drawing.Point(88, 8)
        Me.txtinvce_no.Name = "txtinvce_no"
        Me.txtinvce_no.NewInitialValue = Nothing
        Me.txtinvce_no.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtinvce_no.Requiered = False
        Me.txtinvce_no.Size = New System.Drawing.Size(96, 20)
        Me.txtinvce_no.StatusBarPanelDescripcion = Nothing
        Me.txtinvce_no.TabIndex = 0
        Me.txtinvce_no.Text = ""
        '
        'txtinvce_name
        '
        Me.txtinvce_name.AcceptsReturn = True
        Me.txtinvce_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjncrm.bus_name"))
        Me.txtinvce_name.EditInitialValue = Nothing
        Me.txtinvce_name.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtinvce_name.FieldDescription = ""
        Me.txtinvce_name.FindInitialValue = Nothing
        Me.txtinvce_name.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtinvce_name.IgnoreRequiered = False
        Me.txtinvce_name.Location = New System.Drawing.Point(88, 32)
        Me.txtinvce_name.Name = "txtinvce_name"
        Me.txtinvce_name.NewInitialValue = Nothing
        Me.txtinvce_name.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtinvce_name.ReadOnly = True
        Me.txtinvce_name.Requiered = False
        Me.txtinvce_name.Size = New System.Drawing.Size(344, 20)
        Me.txtinvce_name.StatusBarPanelDescripcion = Nothing
        Me.txtinvce_name.TabIndex = 15
        Me.txtinvce_name.TabStop = False
        Me.txtinvce_name.Text = ""
        '
        'txtcust_code
        '
        Me.txtcust_code.AcceptsReturn = True
        Me.txtcust_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.cust_code"))
        Me.txtcust_code.EditInitialValue = Nothing
        Me.txtcust_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcust_code.FieldDescription = ""
        Me.txtcust_code.FindInitialValue = Nothing
        Me.txtcust_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcust_code.IgnoreRequiered = False
        Me.txtcust_code.Location = New System.Drawing.Point(88, 8)
        Me.txtcust_code.Name = "txtcust_code"
        Me.txtcust_code.NewInitialValue = Nothing
        Me.txtcust_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcust_code.Requiered = False
        Me.txtcust_code.Size = New System.Drawing.Size(112, 20)
        Me.txtcust_code.StatusBarPanelDescripcion = Nothing
        Me.txtcust_code.TabIndex = 19
        Me.txtcust_code.Text = ""
        '
        'txtbus_name
        '
        Me.txtbus_name.AcceptsReturn = True
        Me.txtbus_name.EditInitialValue = Nothing
        Me.txtbus_name.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtbus_name.FieldDescription = ""
        Me.txtbus_name.FindInitialValue = Nothing
        Me.txtbus_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtbus_name.IgnoreRequiered = False
        Me.txtbus_name.Location = New System.Drawing.Point(88, 32)
        Me.txtbus_name.Name = "txtbus_name"
        Me.txtbus_name.NewInitialValue = Nothing
        Me.txtbus_name.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtbus_name.ReadOnly = True
        Me.txtbus_name.Requiered = False
        Me.txtbus_name.Size = New System.Drawing.Size(344, 20)
        Me.txtbus_name.StatusBarPanelDescripcion = Nothing
        Me.txtbus_name.TabIndex = 20
        Me.txtbus_name.TabStop = False
        Me.txtbus_name.Text = ""
        '
        'xcbo_ban_cheque
        '
        Me.xcbo_ban_cheque.AllowDefaultSort = True
        Me.xcbo_ban_cheque.bound = True
        Me.xcbo_ban_cheque.currValue = Nothing
        Me.xcbo_ban_cheque.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cjchkm.ban_code"))
        Me.xcbo_ban_cheque.DefaultWhereString = Nothing
        Me.xcbo_ban_cheque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_ban_cheque.EditInitialValue = Nothing
        Me.xcbo_ban_cheque.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_ban_cheque.FieldDescription = ""
        Me.xcbo_ban_cheque.FindInitialValue = Nothing
        Me.xcbo_ban_cheque.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_ban_cheque.IgnoreRequiered = False
        Me.xcbo_ban_cheque.Location = New System.Drawing.Point(88, 56)
        Me.xcbo_ban_cheque.LookupKeyDisplayFields = "ban_name"
        Me.xcbo_ban_cheque.LookupKeyField = "ban_code"
        Me.xcbo_ban_cheque.LookupTableName = "ftbanco"
        Me.xcbo_ban_cheque.Name = "xcbo_ban_cheque"
        Me.xcbo_ban_cheque.NewInitialValue = Nothing
        Me.xcbo_ban_cheque.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_ban_cheque.Requiered = False
        Me.xcbo_ban_cheque.Required = False
        Me.xcbo_ban_cheque.Size = New System.Drawing.Size(344, 21)
        Me.xcbo_ban_cheque.SqlString = Nothing
        Me.xcbo_ban_cheque.StatusBarPanelDescripcion = Nothing
        Me.xcbo_ban_cheque.TabIndex = 3
        '
        'txtinvce_Serial
        '
        Me.txtinvce_Serial.AcceptsReturn = True
        Me.txtinvce_Serial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjncrm.ncr_code"))
        Me.txtinvce_Serial.EditInitialValue = Nothing
        Me.txtinvce_Serial.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtinvce_Serial.FieldDescription = ""
        Me.txtinvce_Serial.FindInitialValue = Nothing
        Me.txtinvce_Serial.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtinvce_Serial.IgnoreRequiered = False
        Me.txtinvce_Serial.Location = New System.Drawing.Point(216, 32)
        Me.txtinvce_Serial.Name = "txtinvce_Serial"
        Me.txtinvce_Serial.NewInitialValue = Nothing
        Me.txtinvce_Serial.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtinvce_Serial.ReadOnly = True
        Me.txtinvce_Serial.Requiered = False
        Me.txtinvce_Serial.Size = New System.Drawing.Size(32, 20)
        Me.txtinvce_Serial.StatusBarPanelDescripcion = Nothing
        Me.txtinvce_Serial.TabIndex = 18
        Me.txtinvce_Serial.Text = ""
        '
        'balance
        '
        Me.balance.AcceptsReturn = True
        Me.balance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjncrm.ncr_balance"))
        Me.balance.EditInitialValue = Nothing
        Me.balance.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.balance.FieldDescription = ""
        Me.balance.FindInitialValue = Nothing
        Me.balance.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.balance.IgnoreRequiered = False
        Me.balance.Location = New System.Drawing.Point(88, 56)
        Me.balance.Name = "balance"
        Me.balance.NewInitialValue = Nothing
        Me.balance.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.balance.ReadOnly = True
        Me.balance.Requiered = False
        Me.balance.Size = New System.Drawing.Size(112, 20)
        Me.balance.StatusBarPanelDescripcion = Nothing
        Me.balance.TabIndex = 17
        Me.balance.TabStop = False
        Me.balance.Text = ""
        Me.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabTarjeta)
        Me.TabControl1.Controls.Add(Me.TabNC)
        Me.TabControl1.Controls.Add(Me.TabCheque)
        Me.TabControl1.Controls.Add(Me.TabCredito)
        Me.TabControl1.Location = New System.Drawing.Point(264, 192)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(448, 160)
        Me.TabControl1.TabIndex = 6
        '
        'TabTarjeta
        '
        Me.TabTarjeta.Controls.Add(Me.PictureBox1)
        Me.TabTarjeta.Controls.Add(Me.xcbo_tart_code)
        Me.TabTarjeta.Controls.Add(Me.Label33)
        Me.TabTarjeta.Location = New System.Drawing.Point(4, 22)
        Me.TabTarjeta.Name = "TabTarjeta"
        Me.TabTarjeta.Size = New System.Drawing.Size(440, 134)
        Me.TabTarjeta.TabIndex = 4
        Me.TabTarjeta.Text = "Tarjeta"
        Me.ToolTip1.SetToolTip(Me.TabTarjeta, "Tipo de tarjeta de credito")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(304, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'xcbo_tart_code
        '
        Me.xcbo_tart_code.AllowDefaultSort = True
        Me.xcbo_tart_code.bound = True
        Me.xcbo_tart_code.currValue = Nothing
        Me.xcbo_tart_code.DefaultWhereString = Nothing
        Me.xcbo_tart_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_tart_code.EditInitialValue = Nothing
        Me.xcbo_tart_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_tart_code.FieldDescription = ""
        Me.xcbo_tart_code.FindInitialValue = Nothing
        Me.xcbo_tart_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_tart_code.IgnoreRequiered = False
        Me.xcbo_tart_code.Location = New System.Drawing.Point(104, 8)
        Me.xcbo_tart_code.LookupKeyDisplayFields = "Nombre"
        Me.xcbo_tart_code.LookupKeyField = "tart_code"
        Me.xcbo_tart_code.LookupTableName = "pvtipotarm"
        Me.xcbo_tart_code.Name = "xcbo_tart_code"
        Me.xcbo_tart_code.NewInitialValue = Nothing
        Me.xcbo_tart_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_tart_code.Requiered = False
        Me.xcbo_tart_code.Required = False
        Me.xcbo_tart_code.Size = New System.Drawing.Size(192, 21)
        Me.xcbo_tart_code.SqlString = Nothing
        Me.xcbo_tart_code.StatusBarPanelDescripcion = Nothing
        Me.xcbo_tart_code.TabIndex = 0
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label33.Location = New System.Drawing.Point(8, 8)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(83, 16)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Tipo de Tarjeta:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TabNC
        '
        Me.TabNC.Controls.Add(Me.PictureBox3)
        Me.TabNC.Controls.Add(Me.xdt_nc_date)
        Me.TabNC.Controls.Add(Me.Label27)
        Me.TabNC.Controls.Add(Me.Label26)
        Me.TabNC.Controls.Add(Me.Label25)
        Me.TabNC.Controls.Add(Me.xlk_invce_no)
        Me.TabNC.Controls.Add(Me.txtinvce_no)
        Me.TabNC.Controls.Add(Me.txtinvce_name)
        Me.TabNC.Controls.Add(Me.balance)
        Me.TabNC.Controls.Add(Me.Label34)
        Me.TabNC.Controls.Add(Me.xtxt_nc_amount)
        Me.TabNC.Controls.Add(Me.Label35)
        Me.TabNC.Controls.Add(Me.txtinvce_Serial)
        Me.TabNC.Controls.Add(Me.xtxt_ncr_code)
        Me.TabNC.ImageIndex = 2
        Me.TabNC.Location = New System.Drawing.Point(4, 22)
        Me.TabNC.Name = "TabNC"
        Me.TabNC.Size = New System.Drawing.Size(440, 134)
        Me.TabNC.TabIndex = 2
        Me.TabNC.Text = "Notas de Cédito"
        Me.ToolTip1.SetToolTip(Me.TabNC, "Datos de la nota de credito")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(320, 80)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(112, 48)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'xdt_nc_date
        '
        Me.xdt_nc_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_nc_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cjncrm.ncr_date"))
        Me.xdt_nc_date.EditInitialValue = Nothing
        Me.xdt_nc_date.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdt_nc_date.FieldDescription = ""
        Me.xdt_nc_date.FindInitialValue = Nothing
        Me.xdt_nc_date.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdt_nc_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_nc_date.IgnoreRequiered = False
        Me.xdt_nc_date.Location = New System.Drawing.Point(320, 8)
        Me.xdt_nc_date.Name = "xdt_nc_date"
        Me.xdt_nc_date.NewInitialValue = Nothing
        Me.xdt_nc_date.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdt_nc_date.Requiered = False
        Me.xdt_nc_date.Size = New System.Drawing.Size(112, 20)
        Me.xdt_nc_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_nc_date.TabIndex = 1
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label27.Location = New System.Drawing.Point(32, 56)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 16)
        Me.Label27.TabIndex = 21
        Me.Label27.Text = "Balance:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label26.Location = New System.Drawing.Point(24, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(58, 16)
        Me.Label26.TabIndex = 20
        Me.Label26.Text = "A Nombre:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label25.Location = New System.Drawing.Point(8, 8)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 16)
        Me.Label25.TabIndex = 19
        Me.Label25.Text = "Nota Crédito:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label34.Location = New System.Drawing.Point(272, 8)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(39, 16)
        Me.Label34.TabIndex = 19
        Me.Label34.Text = "Fecha:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_nc_amount
        '
        Me.xtxt_nc_amount.AcceptsReturn = True
        Me.xtxt_nc_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjncrm.ncr_amount"))
        Me.xtxt_nc_amount.EditInitialValue = Nothing
        Me.xtxt_nc_amount.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_nc_amount.FieldDescription = ""
        Me.xtxt_nc_amount.FindInitialValue = Nothing
        Me.xtxt_nc_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_nc_amount.IgnoreRequiered = False
        Me.xtxt_nc_amount.Location = New System.Drawing.Point(320, 56)
        Me.xtxt_nc_amount.Name = "xtxt_nc_amount"
        Me.xtxt_nc_amount.NewInitialValue = Nothing
        Me.xtxt_nc_amount.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_nc_amount.ReadOnly = True
        Me.xtxt_nc_amount.Requiered = False
        Me.xtxt_nc_amount.Size = New System.Drawing.Size(112, 20)
        Me.xtxt_nc_amount.StatusBarPanelDescripcion = Nothing
        Me.xtxt_nc_amount.TabIndex = 17
        Me.xtxt_nc_amount.TabStop = False
        Me.xtxt_nc_amount.Text = ""
        Me.xtxt_nc_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label35.Location = New System.Drawing.Point(232, 56)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(81, 16)
        Me.Label35.TabIndex = 21
        Me.Label35.Text = "Monto Original:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_ncr_code
        '
        Me.xtxt_ncr_code.AcceptsReturn = True
        Me.xtxt_ncr_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjncrm.ncr_code"))
        Me.xtxt_ncr_code.EditInitialValue = Nothing
        Me.xtxt_ncr_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_ncr_code.FieldDescription = ""
        Me.xtxt_ncr_code.FindInitialValue = Nothing
        Me.xtxt_ncr_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_ncr_code.IgnoreRequiered = False
        Me.xtxt_ncr_code.Location = New System.Drawing.Point(88, 80)
        Me.xtxt_ncr_code.Name = "xtxt_ncr_code"
        Me.xtxt_ncr_code.NewInitialValue = Nothing
        Me.xtxt_ncr_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_ncr_code.ReadOnly = True
        Me.xtxt_ncr_code.Requiered = False
        Me.xtxt_ncr_code.Size = New System.Drawing.Size(112, 20)
        Me.xtxt_ncr_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_ncr_code.TabIndex = 17
        Me.xtxt_ncr_code.TabStop = False
        Me.xtxt_ncr_code.Text = ""
        Me.xtxt_ncr_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabCheque
        '
        Me.TabCheque.Controls.Add(Me.PictureBox2)
        Me.TabCheque.Controls.Add(Me.xtxt_chk_benef)
        Me.TabCheque.Controls.Add(Me.xdt_fecha)
        Me.TabCheque.Controls.Add(Me.Label24)
        Me.TabCheque.Controls.Add(Me.Label5)
        Me.TabCheque.Controls.Add(Me.xcbo_ban_cheque)
        Me.TabCheque.Controls.Add(Me.Label15)
        Me.TabCheque.Controls.Add(Me.txtNumChe)
        Me.TabCheque.Controls.Add(Me.Label36)
        Me.TabCheque.Controls.Add(Me.xtxt_chk_amount)
        Me.TabCheque.Controls.Add(Me.Label37)
        Me.TabCheque.ImageIndex = 1
        Me.TabCheque.Location = New System.Drawing.Point(4, 22)
        Me.TabCheque.Name = "TabCheque"
        Me.TabCheque.Size = New System.Drawing.Size(440, 134)
        Me.TabCheque.TabIndex = 1
        Me.TabCheque.Text = "Cheques"
        Me.ToolTip1.SetToolTip(Me.TabCheque, "Datos del cheque")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(288, 80)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(144, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'xtxt_chk_benef
        '
        Me.xtxt_chk_benef.AcceptsReturn = True
        Me.xtxt_chk_benef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_chk_benef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjchkm.chk_benef"))
        Me.xtxt_chk_benef.EditInitialValue = Nothing
        Me.xtxt_chk_benef.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chk_benef.FieldDescription = ""
        Me.xtxt_chk_benef.FindInitialValue = Nothing
        Me.xtxt_chk_benef.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chk_benef.IgnoreRequiered = False
        Me.xtxt_chk_benef.Location = New System.Drawing.Point(88, 32)
        Me.xtxt_chk_benef.Name = "xtxt_chk_benef"
        Me.xtxt_chk_benef.NewInitialValue = Nothing
        Me.xtxt_chk_benef.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chk_benef.Requiered = False
        Me.xtxt_chk_benef.Size = New System.Drawing.Size(344, 20)
        Me.xtxt_chk_benef.StatusBarPanelDescripcion = Nothing
        Me.xtxt_chk_benef.TabIndex = 2
        Me.xtxt_chk_benef.Text = ""
        '
        'xdt_fecha
        '
        Me.xdt_fecha.CustomFormat = "dd/MM/yyyy"
        Me.xdt_fecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cjchkm.chk_date"))
        Me.xdt_fecha.EditInitialValue = Nothing
        Me.xdt_fecha.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_fecha.FieldDescription = ""
        Me.xdt_fecha.FindInitialValue = Nothing
        Me.xdt_fecha.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_fecha.IgnoreRequiered = False
        Me.xdt_fecha.Location = New System.Drawing.Point(320, 8)
        Me.xdt_fecha.Name = "xdt_fecha"
        Me.xdt_fecha.NewInitialValue = Nothing
        Me.xdt_fecha.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_fecha.Requiered = False
        Me.xdt_fecha.Size = New System.Drawing.Size(112, 20)
        Me.xdt_fecha.StatusBarPanelDescripcion = Nothing
        Me.xdt_fecha.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label24.Location = New System.Drawing.Point(232, 8)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 16)
        Me.Label24.TabIndex = 27
        Me.Label24.Text = "Fecha Cheque:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label36.Location = New System.Drawing.Point(8, 32)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(67, 16)
        Me.Label36.TabIndex = 23
        Me.Label36.Text = "Beneficiario:"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_chk_amount
        '
        Me.xtxt_chk_amount.AcceptsReturn = True
        Me.xtxt_chk_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjchkm.chk_amount"))
        Me.xtxt_chk_amount.EditInitialValue = Nothing
        Me.xtxt_chk_amount.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_chk_amount.FieldDescription = ""
        Me.xtxt_chk_amount.FindInitialValue = Nothing
        Me.xtxt_chk_amount.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_chk_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_chk_amount.IgnoreRequiered = False
        Me.xtxt_chk_amount.Location = New System.Drawing.Point(88, 80)
        Me.xtxt_chk_amount.Name = "xtxt_chk_amount"
        Me.xtxt_chk_amount.NewInitialValue = Nothing
        Me.xtxt_chk_amount.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_chk_amount.Requiered = False
        Me.xtxt_chk_amount.Size = New System.Drawing.Size(144, 41)
        Me.xtxt_chk_amount.StatusBarPanelDescripcion = Nothing
        Me.xtxt_chk_amount.TabIndex = 4
        Me.xtxt_chk_amount.Text = ""
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(24, 88)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(56, 22)
        Me.Label37.TabIndex = 10
        Me.Label37.Text = "Monto:"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TabCredito
        '
        Me.TabCredito.Controls.Add(Me.xtxncf_type)
        Me.TabCredito.Controls.Add(Me.Label32)
        Me.TabCredito.Controls.Add(Me.xtxt_phone2)
        Me.TabCredito.Controls.Add(Me.Label31)
        Me.TabCredito.Controls.Add(Me.xtxt_phone1)
        Me.TabCredito.Controls.Add(Me.Label30)
        Me.TabCredito.Controls.Add(Me.txtaddress)
        Me.TabCredito.Controls.Add(Me.Label29)
        Me.TabCredito.Controls.Add(Me.Label28)
        Me.TabCredito.Controls.Add(Me.txtbus_name)
        Me.TabCredito.Controls.Add(Me.txtcust_code)
        Me.TabCredito.Controls.Add(Me.Label38)
        Me.TabCredito.Controls.Add(Me.xtxt_credit_limit)
        Me.TabCredito.Controls.Add(Me.Label39)
        Me.TabCredito.Controls.Add(Me.xtxt_balance)
        Me.TabCredito.Controls.Add(Me.xlk_cust_code)
        Me.TabCredito.Location = New System.Drawing.Point(4, 22)
        Me.TabCredito.Name = "TabCredito"
        Me.TabCredito.Size = New System.Drawing.Size(440, 134)
        Me.TabCredito.TabIndex = 3
        Me.TabCredito.Text = "Clientes a Crédito"
        Me.ToolTip1.SetToolTip(Me.TabCredito, "Datos del cliente de credito")
        '
        'xtxncf_type
        '
        Me.xtxncf_type.AcceptsReturn = True
        Me.xtxncf_type.BackColor = System.Drawing.SystemColors.Control
        Me.xtxncf_type.EditInitialValue = Nothing
        Me.xtxncf_type.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxncf_type.FieldDescription = ""
        Me.xtxncf_type.FindInitialValue = Nothing
        Me.xtxncf_type.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxncf_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxncf_type.IgnoreRequiered = False
        Me.xtxncf_type.Location = New System.Drawing.Point(64, 96)
        Me.xtxncf_type.Name = "xtxncf_type"
        Me.xtxncf_type.NewInitialValue = Nothing
        Me.xtxncf_type.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxncf_type.Requiered = False
        Me.xtxncf_type.Size = New System.Drawing.Size(8, 41)
        Me.xtxncf_type.StatusBarPanelDescripcion = Nothing
        Me.xtxncf_type.TabIndex = 30
        Me.xtxncf_type.Text = ""
        Me.xtxncf_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.xtxncf_type.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label32.Location = New System.Drawing.Point(264, 80)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(43, 16)
        Me.Label32.TabIndex = 28
        Me.Label32.Text = "Celular:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_phone2
        '
        Me.xtxt_phone2.AcceptsReturn = True
        Me.xtxt_phone2.BackColor = System.Drawing.SystemColors.Control
        Me.xtxt_phone2.EditInitialValue = Nothing
        Me.xtxt_phone2.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_phone2.FieldDescription = ""
        Me.xtxt_phone2.FindInitialValue = Nothing
        Me.xtxt_phone2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_phone2.IgnoreRequiered = False
        Me.xtxt_phone2.Location = New System.Drawing.Point(320, 80)
        Me.xtxt_phone2.Name = "xtxt_phone2"
        Me.xtxt_phone2.NewInitialValue = Nothing
        Me.xtxt_phone2.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_phone2.Requiered = False
        Me.xtxt_phone2.Size = New System.Drawing.Size(112, 20)
        Me.xtxt_phone2.StatusBarPanelDescripcion = Nothing
        Me.xtxt_phone2.TabIndex = 29
        Me.xtxt_phone2.Text = ""
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label31.Location = New System.Drawing.Point(256, 8)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(51, 16)
        Me.Label31.TabIndex = 26
        Me.Label31.Text = "Telefono:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_phone1
        '
        Me.xtxt_phone1.AcceptsReturn = True
        Me.xtxt_phone1.BackColor = System.Drawing.SystemColors.Control
        Me.xtxt_phone1.EditInitialValue = Nothing
        Me.xtxt_phone1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_phone1.FieldDescription = ""
        Me.xtxt_phone1.FindInitialValue = Nothing
        Me.xtxt_phone1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_phone1.IgnoreRequiered = False
        Me.xtxt_phone1.Location = New System.Drawing.Point(320, 8)
        Me.xtxt_phone1.Name = "xtxt_phone1"
        Me.xtxt_phone1.NewInitialValue = Nothing
        Me.xtxt_phone1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_phone1.Requiered = False
        Me.xtxt_phone1.Size = New System.Drawing.Size(112, 20)
        Me.xtxt_phone1.StatusBarPanelDescripcion = Nothing
        Me.xtxt_phone1.TabIndex = 27
        Me.xtxt_phone1.Text = ""
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label30.Location = New System.Drawing.Point(16, 56)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(55, 16)
        Me.Label30.TabIndex = 25
        Me.Label30.Text = "Dirección:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtaddress
        '
        Me.txtaddress.AcceptsReturn = True
        Me.txtaddress.EditInitialValue = Nothing
        Me.txtaddress.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtaddress.FieldDescription = ""
        Me.txtaddress.FindInitialValue = Nothing
        Me.txtaddress.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtaddress.IgnoreRequiered = False
        Me.txtaddress.Location = New System.Drawing.Point(88, 56)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.NewInitialValue = Nothing
        Me.txtaddress.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtaddress.ReadOnly = True
        Me.txtaddress.Requiered = False
        Me.txtaddress.Size = New System.Drawing.Size(344, 20)
        Me.txtaddress.StatusBarPanelDescripcion = Nothing
        Me.txtaddress.TabIndex = 24
        Me.txtaddress.TabStop = False
        Me.txtaddress.Text = ""
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label29.Location = New System.Drawing.Point(24, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 16)
        Me.Label29.TabIndex = 23
        Me.Label29.Text = "Nombre:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label28.Location = New System.Drawing.Point(32, 8)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(43, 16)
        Me.Label28.TabIndex = 22
        Me.Label28.Text = "Cliente:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label38.Location = New System.Drawing.Point(232, 104)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(77, 16)
        Me.Label38.TabIndex = 28
        Me.Label38.Text = "Limite Credito:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_credit_limit
        '
        Me.xtxt_credit_limit.AcceptsReturn = True
        Me.xtxt_credit_limit.BackColor = System.Drawing.SystemColors.Control
        Me.xtxt_credit_limit.EditInitialValue = Nothing
        Me.xtxt_credit_limit.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_credit_limit.FieldDescription = ""
        Me.xtxt_credit_limit.FindInitialValue = Nothing
        Me.xtxt_credit_limit.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_credit_limit.IgnoreRequiered = False
        Me.xtxt_credit_limit.Location = New System.Drawing.Point(320, 104)
        Me.xtxt_credit_limit.Name = "xtxt_credit_limit"
        Me.xtxt_credit_limit.NewInitialValue = Nothing
        Me.xtxt_credit_limit.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_credit_limit.Requiered = False
        Me.xtxt_credit_limit.Size = New System.Drawing.Size(112, 20)
        Me.xtxt_credit_limit.StatusBarPanelDescripcion = Nothing
        Me.xtxt_credit_limit.TabIndex = 29
        Me.xtxt_credit_limit.Text = ""
        Me.xtxt_credit_limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label39.Location = New System.Drawing.Point(24, 80)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(48, 16)
        Me.Label39.TabIndex = 26
        Me.Label39.Text = "Balance:"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_balance
        '
        Me.xtxt_balance.AcceptsReturn = True
        Me.xtxt_balance.BackColor = System.Drawing.SystemColors.Control
        Me.xtxt_balance.EditInitialValue = Nothing
        Me.xtxt_balance.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_balance.FieldDescription = ""
        Me.xtxt_balance.FindInitialValue = Nothing
        Me.xtxt_balance.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_balance.IgnoreRequiered = False
        Me.xtxt_balance.Location = New System.Drawing.Point(88, 80)
        Me.xtxt_balance.Name = "xtxt_balance"
        Me.xtxt_balance.NewInitialValue = Nothing
        Me.xtxt_balance.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_balance.Requiered = False
        Me.xtxt_balance.Size = New System.Drawing.Size(128, 41)
        Me.xtxt_balance.StatusBarPanelDescripcion = Nothing
        Me.xtxt_balance.TabIndex = 27
        Me.xtxt_balance.Text = ""
        Me.xtxt_balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAccept
        '
        Me.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAccept.Location = New System.Drawing.Point(528, 440)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(88, 32)
        Me.btnAccept.TabIndex = 27
        Me.btnAccept.Text = "Aceptar(F5)"
        Me.ToolTip1.SetToolTip(Me.btnAccept, "Cobrar el documento")
        '
        'btnCancel
        '
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(624, 440)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Cerrar"
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Cancelar el cobro del documento")
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimir.Location = New System.Drawing.Point(8, 440)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(88, 32)
        Me.btnImprimir.TabIndex = 27
        Me.btnImprimir.Text = "NCF"
        Me.btnImprimir.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.xcbo_vend_mensj)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.LibxDateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(264, 360)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 72)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Domicilio"
        '
        'xcbo_vend_mensj
        '
        Me.xcbo_vend_mensj.AllowDefaultSort = True
        Me.xcbo_vend_mensj.bound = True
        Me.xcbo_vend_mensj.currValue = Nothing
        Me.xcbo_vend_mensj.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftdomim.vend_mensaj"))
        Me.xcbo_vend_mensj.DefaultWhereString = "vend_cargo = 3 and vend_estatus = 1"
        Me.xcbo_vend_mensj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_vend_mensj.EditInitialValue = Nothing
        Me.xcbo_vend_mensj.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_mensj.FieldDescription = ""
        Me.xcbo_vend_mensj.FindInitialValue = Nothing
        Me.xcbo_vend_mensj.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_mensj.IgnoreRequiered = False
        Me.xcbo_vend_mensj.Location = New System.Drawing.Point(88, 16)
        Me.xcbo_vend_mensj.LookupKeyDisplayFields = "vend_name"
        Me.xcbo_vend_mensj.LookupKeyField = "vend_code"
        Me.xcbo_vend_mensj.LookupTableName = "ftvendm"
        Me.xcbo_vend_mensj.Name = "xcbo_vend_mensj"
        Me.xcbo_vend_mensj.NewInitialValue = Nothing
        Me.xcbo_vend_mensj.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_mensj.Requiered = False
        Me.xcbo_vend_mensj.Required = False
        Me.xcbo_vend_mensj.Size = New System.Drawing.Size(352, 21)
        Me.xcbo_vend_mensj.SqlString = Nothing
        Me.xcbo_vend_mensj.StatusBarPanelDescripcion = Nothing
        Me.xcbo_vend_mensj.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(240, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 16)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Cambio:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftdomim.domi_cambio"))
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.Blue
        Me.Label23.Location = New System.Drawing.Point(328, 40)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(112, 26)
        Me.Label23.TabIndex = 25
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftdomim.domi_date"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxDateTimePicker1.FieldDescription = ""
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = False
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(88, 40)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = Nothing
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxDateTimePicker1.Requiered = False
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.LibxDateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker1.TabIndex = 19
        Me.LibxDateTimePicker1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(37, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Fecha:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(16, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Mensajero:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'i_cjfact01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(722, 488)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.txtCajaNombre)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtCajeraNombre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnImprimir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "i_cjfact01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cobrar Documentos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pvtarjeta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cjncrm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cjchkm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cjtranrv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftdomim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabTarjeta.ResumeLayout(False)
        Me.TabNC.ResumeLayout(False)
        Me.TabCheque.ResumeLayout(False)
        Me.TabCredito.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim miCond As Integer
    Dim oParamValidar As SGT.Administracion.Entidades.Permission.ParametrosValidar
    Dim oAutorizar As SGT.Administracion.Entidades.Permission
    Dim mConf As SGT.Inventario.Common.Configuration
    Dim oDocumento As SGT.Inventario.Entidades.Documento
    Dim WhereStmt As String
    Dim iFacID As Integer
    Dim iCaj As Integer
    Dim mEnter(4) As Boolean
    Dim mPrevValue(4) As Decimal
    Dim mPagos() As String
    Dim mPagosControls As Hashtable
    Dim oNCF As i_ftfact04
    Dim cashDrowerOpen As Boolean
    Dim mAquinaCaja As String
    Dim ncfType As Integer
    Dim nCf As String
    Dim WhDefaultNo As Integer
    Dim ofctDocumento As SGT.Facturacion.Entidades.Documento

    Dim mCaja As Caja
    Private Sub i_cjfact01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MaquinaAutorizadas() As String

        Try
            ftfactm.Columns("ftserial_no").AutoIncrement = False

            oParamValidar = New SGT.Administracion.Entidades.Permission.ParametrosValidar
            oAutorizar = New SGT.Administracion.Entidades.Permission
            mConf = New SGT.Inventario.Common.Configuration
            mPagos = Split(String.Concat(Me.txtMonEfe.Name, " ", Me.txtMonTarjeta.Name, " ", Me.txtMonChe.Name, " ", Me.txtMonNota.Name, " ", Me.txtMonCxC.Name))
            ofctDocumento = New SGT.Facturacion.Entidades.Documento
            EnabledCHK(False)
            EnabledCXC(False)
            EnabledNC(False)
            EnabledTAR(False)
            cashDrowerOpen = CType(System.Configuration.ConfigurationSettings.AppSettings.Get("LibXCashDrower"), Boolean)
            MaquinaAutorizadas = Split(System.Configuration.ConfigurationSettings.AppSettings.Get("LibxCaja"), ",")
            WhDefaultNo = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibxWhDefaultNo").ToString)
            For Each mAquinaCaja In MaquinaAutorizadas
                If mAquinaCaja.ToLower = System.Environment.MachineName.ToLower Then
                End If
            Next

        Catch ex As Exception
            Log.Show(ex)
            Me.LibXConnector1.Cancel()
        End Try

    End Sub

    Private Sub CalcularVuelto()
        Try
            Dim dev As Decimal
            Dim total As Decimal
            Dim monto As Decimal

            If Me.txtNeto.Text.Trim.Length > 0 Then
                total = Me.txtNeto.Text
            End If

            If Trim(txtTotalPagado.Text) <> "" Then
                monto = txtTotalPagado.Text
            End If

            dev = monto - total

            If dev < 0 Then
                dev = 0
            End If

            Me.txtDevuelta.Text = dev.ToString("###,###,###.00")

        Catch ex As Exception
            Log.Show(ex)
        End Try

    End Sub

    Private Sub CheckTotal()
        Dim efe As Decimal
        Dim che As Decimal
        Dim tar As Decimal
        Dim cxc As Decimal
        Dim nota As Decimal
        Dim tot As Decimal
        Dim car As Decimal
        Dim dst, pdst As Decimal
        Dim dscnt As String

        Try
            mCaja = New Caja(CajaAbierta.CajaCode)

            If Trim(Me.txtMonEfe.Text) <> "" Then
                efe = CType(Me.txtMonEfe.Text, Decimal).ToString("###,###,##0.##")
            End If

            If Trim(Me.txtMonChe.Text) <> "" Then
                che = CType(Me.txtMonChe.Text, Decimal).ToString("###,###,###.##")
                If che > CType(Me.txtNeto.Text, Decimal).ToString("###,###,###.##") Then
                    Me.txtMonChe.Text = ""
                    che = 0
                    Me.txtMonEfe.Focus()
                    Throw New ApplicationException("El monto del cheque no puede ser mayor que el monto neto")
                End If
            End If

            If Trim(Me.txtMonCxC.Text) <> "" Then
                cxc = CType(Me.txtMonCxC.Text, Decimal).ToString("###,###,###.##")
                If mCaja.DescuentoCxc = False Then
                    If cxc > CType(Me.txtNeto.Text, Decimal).ToString("###,###,###.##") Then
                        Me.txtMonCxC.Text = ""
                        cxc = 0
                        Me.txtMonEfe.Focus()
                        Throw New ApplicationException("El monto del credito no puede ser mayor que el monto neto")
                    End If
                    If Val(Me.txtDesc.Text) > 0 And Val(cxc) > 0 And LibXConnector1.CurrentDataRow!type_code = "FPV" Then
                        oParamValidar.AccessKey = "AD"
                        oAutorizar.PermisosAutorizados.Remove("AD")

                        If oAutorizar.isAutorization(oParamValidar) = False Then
                            Me.txtMonTarjeta.Text = ""
                            Throw New ApplicationException("Autorización Invalida o descuento no permitido ")
                        End If
                    End If
                    ''If Val(Me.txtDesc.Text) > 0 And Val(cxc) > 0 And Val(mConf.GetDSCTO) <= 0 And LibXConnector1.CurrentDataRow!type_code = "FPV" Then
                    ''    Me.txtMonCxC.Text = ""
                    ''    cxc = 0
                    ''    Me.txtMonEfe.Focus()
                    ''    Throw New ApplicationException("Debe verificar el descuento antes, que no esta permitido para CXC")
                    ''End If
                    ''If Val(Me.txtDesc.Text) > 0 And Val(cxc) > 0 And Val(mConf.GetDSCTO) > 0 And LibXConnector1.CurrentDataRow!type_code = "FPV" Then
                    ''    Me.txtMonCxC.Text = ""
                    ''    Me.txtMonEfe.Focus()
                    ''    Throw New ApplicationException("Debe verificar el descuento antes, que no esta permitido para CXC")
                    ''End If
                End If
            End If

            If Trim(Me.txtMonNota.Text) <> "" Then
                nota = CType(Me.txtMonNota.Text, Decimal).ToString("###,###,###.##")
                If nota > CType(Me.txtNeto.Text, Decimal).ToString("###,###,###.##") Then
                    Me.txtMonNota.Text = ""
                    nota = 0
                    Me.txtMonEfe.Focus()
                    Throw New ApplicationException("El monto nota de credito no puede ser mayor que el monto neto")
                End If
            End If

            If Trim(Me.txtMonTarjeta.Text) <> "" Then
                tar = CType(Me.txtMonTarjeta.Text, Decimal).ToString("###,###,###.##")
                If tar > CType(Me.txtNeto.Text, Decimal).ToString("###,###,###.##") Then
                    Me.txtMonTarjeta.Text = ""
                    tar = 0
                    Me.txtMonEfe.Focus()
                    Throw New ApplicationException("El monto tarjeta no puede ser mayor que el monto neto")
                End If
                If Val(Me.txtDesc.Text) > 0 And Val(tar) > 0 And Val(mConf.GetDsctoTar) > 0 And LibXConnector1.CurrentDataRow!type_code = "FPV" Then
                    dst = (Me.txtMontoBruto.Text * (mConf.GetDsctoTar / 100))
                    dst = dst.ToString("###,###,###.##")
                    If Me.txtDesc.Text > dst And mConf.GetDsctoTar > 0 Then
                        Me.txtMonTarjeta.Text = ""
                        pdst = mConf.GetDsctoTar.ToString("###,###,###.##")
                        dscnt = MessageBox.Show("El descuento maximo permitido es un " & pdst & "% del monto de la factura", "Autorizar Descuento", MessageBoxButtons.YesNo)
                        If dscnt = System.Windows.Forms.DialogResult.Yes Then
                            oParamValidar.AccessKey = "AD"
                            oAutorizar.PermisosAutorizados.Remove("AD")

                            If oAutorizar.isAutorization(oParamValidar) = False Then
                                Me.txtMonTarjeta.Text = ""
                                Throw New ApplicationException("Autorización Invalida o descuento no permitido ")
                            End If
                        Else
                            Me.txtMonTarjeta.Text = ""
                            Throw New ApplicationException("El descuento no debe ser mayor que " & pdst & "% del monto de la factura")
                        End If
                    End If
                End If
                If Val(Me.txtDesc.Text) > 0 And Val(tar) > 0 And Val(mConf.GetDsctoTar) <= 0 And LibXConnector1.CurrentDataRow!type_code = "FPV" Then
                    If Me.txtDesc.Text > 0 Then
                        dscnt = MessageBox.Show("Debe verificar el descuento antes, que no esta permitido para TAR", "Autorizar Descuento", MessageBoxButtons.YesNo)
                        If dscnt = System.Windows.Forms.DialogResult.Yes Then
                            oParamValidar.AccessKey = "AD"
                            oAutorizar.PermisosAutorizados.Remove("AD")

                            If oAutorizar.isAutorization(oParamValidar) = False Then
                                Me.txtMonTarjeta.Text = ""
                                Throw New ApplicationException("Autorización Invalida o descuento no permitido ")
                            End If
                        Else
                            Me.txtMonTarjeta.Text = ""
                            Throw New ApplicationException("Debe verificar el descuento antes, que no esta permitido para TAR")
                        End If
                    End If
                End If
            End If

            '-->tar = tar * mConf ??
            If tar > 0 Then
                Dim ch As Decimal = 0
                ch = mConf.GetCharge
                car = (tar * (ch / 100)) + tar
            End If
            ''//Ramiro

            tot = efe + che + tar + nota + cxc

            Me.TabCheque.Enabled = (che > 0)
            Me.TabCredito.Enabled = (cxc > 0)
            Me.TabNC.Enabled = (nota > 0)
            Me.TabTarjeta.Enabled = (tar > 0)

            Me.txtMonChe.Text = che.ToString("###,###,###.##")
            Me.txtMonTarjeta.Text = tar.ToString("###,###,###.##")
            Me.txtMonNota.Text = nota.ToString("###,###,###.##")
            Me.txtMonCxC.Text = cxc.ToString("###,###,###.##")
            Me.txtTotalPagado.Text = tot.ToString("###,###,###.00")

            If LibXConnector1.CurrentDataRow!type_code = "DEV" Then
                Me.EnabledNC(False)
            Else
                Me.EnabledNC(Me.TabNC.Enabled)
            End If
            Me.EnabledCHK(Me.TabCheque.Enabled)
            txtNumChe.Focus()
            Me.EnabledCXC(Me.TabCredito.Enabled)
            txtcust_code.Focus()
            Me.EnabledTAR(Me.TabTarjeta.Enabled)
            xcbo_tart_code.Focus()

            CalcularVuelto()

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub AplicarCobro()
        Dim xInsert As LibX.Data.XInsertStmt

        Dim oCobro As SGT.Caja.Operaciones.Cobro
        Dim oParam As SGT.Caja.Operaciones.Cobro.ParametrosCobrar

        Try
            oCobro = New SGT.Caja.Operaciones.Cobro
            oParam = New SGT.Caja.Operaciones.Cobro.ParametrosCobrar

            Dim sSql As String
            Dim ft As String
            Dim iFt As Integer
            Dim Efectivo As Decimal
            Dim Vuelto As Decimal
            Dim monto As Decimal
            Dim PlanSeguro As Integer

            Dim Mneto As Decimal
            Dim Mefectivo As Decimal
            Dim Mcredito As Decimal
            Dim Mcheque As Decimal
            Dim Mtarjeta As Decimal
            Dim MnotaCredito As Decimal
            Dim Mtotal As Decimal
            Dim NcfAnt As Integer
            Dim Msg As String


            Mneto = txtNeto.Text
            Mtotal = txtTotalPagado.Text

            If Me.txtMonEfe.Text.Trim.Length > 0 Then
                Dim oForma As New Transaccion.FormaPago
                Efectivo = txtMonEfe.Text
                Mefectivo = Efectivo

                If txtDevuelta.Text.Trim.Length > 0 Then
                    Vuelto = txtDevuelta.Text
                Else
                    Vuelto = 0
                End If

                Efectivo -= Vuelto

                oForma.Tipo = Transaccion.TipoFormaPagoEnum.Efectivo
                oForma.Monto = Efectivo
                oforma.Aditional = Vuelto
                oParam.FormasPago.Add(oForma)
            End If

            If Me.txtMonChe.Text.Trim.Length > 0 Then
                Dim oForma As New Transaccion.FormaPago
                oforma.Tipo = Transaccion.TipoFormaPagoEnum.Cheque
                oForma.Monto = txtMonChe.Text
                Mcheque = txtMonChe.Text
                oforma.Referencia = Me.txtNumChe.Text.Trim
                oforma.Fecha = Me.xdt_fecha.Value
                oforma.Banco = Me.xcbo_ban_cheque.currValue
                oforma.Aditional = Me.xtxt_chk_benef.Text.Trim
                oParam.FormasPago.Add(oforma)
                'txtNumChe.Focus()
            End If

            If Me.txtMonCxC.Text.Trim.Length > 0 Then
                Dim oForma As New Transaccion.FormaPago
                oforma.Tipo = Transaccion.TipoFormaPagoEnum.CXC
                oForma.Referencia = Me.txtcust_code.Text
                oForma.Monto = txtMonCxC.Text
                Mcredito = txtMonCxC.Text
                oforma.Aditional = ""
                oParam.FormasPago.Add(oForma)
                'txtcust_code.Focus()
            End If

            If Me.txtMonNota.Text.Trim.Length > 0 Then
                Dim oForma As New Transaccion.FormaPago
                oforma.Tipo = Transaccion.TipoFormaPagoEnum.NC
                oForma.Referencia = xtxt_ncr_code.Text
                oForma.Monto = txtMonNota.Text
                MnotaCredito = txtMonNota.Text
                oforma.Aditional = ""
                oParam.FormasPago.Add(oforma)
                'txtinvce_no.Focus()
            End If

            If Me.txtMonTarjeta.Text.Trim.Length > 0 Then
                Dim oForma As New Transaccion.FormaPago
                oforma.Tipo = Transaccion.TipoFormaPagoEnum.Tarjeta
                oForma.Monto = txtMonTarjeta.Text
                Mtarjeta = txtMonTarjeta.Text
                oforma.Aditional = Me.xcbo_tart_code.currValue
                oParam.FormasPago.Add(oforma)
                'xcbo_tart_code.Focus()
            End If

            If Me.xtxt_seg_amount.Text.Trim.Length > 0 Then
                Dim oForma As New Transaccion.FormaPago
                oforma.Tipo = Transaccion.TipoFormaPagoEnum.Seguro
                oForma.Monto = xtxt_seg_amount.Text
                If LibXConnector1.CurrentDataRow!type_code.ToString.Trim = "DEV" And Me.xtxt_seg_amount.Text.Trim.Length > 0 Then
                    PlanSeguro = Val(LibX.Data.Manager.GetScalar("select plan_serial from ftsegrm where ftserial_no = " & LibXConnector1.CurrentDataRow!ftserial_afect.ToString.Trim).ToString.Trim)
                    oforma.Referencia = Val(LibX.Data.Manager.GetScalar("select cust_code from sgplanm where plan_serial = " & PlanSeguro).ToString.Trim)
                Else
                    If Not LibX.IsNull(LibXConnector1.CurrentDataRow!plan_serial.ToString.Trim) Then
                        oforma.Referencia = Val(LibX.Data.Manager.GetScalar("select cust_code from sgplanm where plan_serial = " & LibXConnector1.CurrentDataRow!plan_serial.ToString.Trim).ToString.Trim)
                    End If
                End If
                oParam.FormasPago.Add(oforma)
            End If

            oParam.Cuadre = CajaAbierta.Serial
            oParam.Caja = CajaAbierta.CajaCode
            oParam.Cajera = CajaAbierta.CajeraCode
            oParam.DocSerial = Val(LibXConnector1.CurrentDataRow!ftserial_no.ToString)
            oParam.SucCode = Val(LibXConnector1.CurrentDataRow!suc_code.ToString)
            oParam.UseTransaccion = True

            '// Si es nulo y esto genera NCF 
            '//If oDocumento.AfectaOtrosDocumentos = False _
            '//AndAlso LibX.IsNull(LibXConnector1.CurrentDataRow!fact_ncf) _
            If LibX.IsNull(LibXConnector1.CurrentDataRow!fact_ncf) _
            AndAlso oDocumento.GenerarNCF = True Then

                Dim oParametroNCF As ParametrosCreditoFiscal = New SGT.Facturacion.Entidades.ParametrosCreditoFiscal
                Dim blnSuccess As Boolean = False
                If WhDefaultNo = 1 Then
                    oParametroNCF.Almacen = WhDefaultNo
                Else
                    oParametroNCF.Almacen = LibXConnector1.CurrentDataRow!whse_code
                End If

                If Not LibX.IsNull(LibXConnector1.CurrentDataRow!cust_code) Then
                    oParametroNCF.Cliente = LibXConnector1.CurrentDataRow!cust_code
                    oParametroNCF.ClienteRegistrado = True
                Else
                    oParametroNCF.ClienteRegistrado = False
                End If
                oParametroNCF.TipoDocumento = LibXConnector1.CurrentDataRow!type_code
                If ncfType > 0 Then
                    oParametroNCF.TipoNcf = ncfType
                    ''Else
                    ''    oParametroNCF.TipoNcf = 1
                End If
                If LibXConnector1.CurrentDataRow!type_code = "DEV" And Not LibX.IsNull(LibXConnector1.CurrentDataRow!ftserial_afect) Then
                    nCf = LibX.Data.Manager.GetScalar("select isnull(fact_ncf,0) from ftfactm where ftserial_no = " & LibXConnector1.CurrentDataRow!ftserial_afect)
                    If Len(nCf) <> 19 Then
                        NcfAnt = 2
                    Else
                        NcfAnt = LibX.Data.Manager.GetScalar("select isnull(substring(fact_ncf,11,1),0) from ftfactm where ftserial_no = " & LibXConnector1.CurrentDataRow!ftserial_afect)
                    End If
                    If NcfAnt = Nothing Or NcfAnt = 0 Or NcfAnt = -1 Then
                        NcfAnt = 2
                    End If
                Else
                    NcfAnt = 2
                End If
                If LibXConnector1.CurrentDataRow!type_code = "DEV" And NcfAnt <> "2" Then
                    oDocumento = New SGT.Inventario.Entidades.Documento(LibXConnector1.CurrentDataRow!type_code)
                    oParametroNCF.Retorno.NCF = oDocumento.GenerateNCF(LibXConnector1.CurrentDataRow!type_code, LibXConnector1.CurrentDataRow!whse_code, SGT.Inventario.Entidades.Documento.TipoNCFEnum.NotasCredito)
                    blnSuccess = True
                Else
                    If LibXConnector1.CurrentDataRow!type_code <> "DEV" Then
                        blnSuccess = ofctDocumento.AplicarCreditoFiscal(oParametroNCF)
                        If blnSuccess = False Then
                            '''Msg = MessageBox.Show("comprobante", "Autorizar Descuento", MessageBoxButtons.YesNo)
                            '''If Msg = System.Windows.Forms.DialogResult.Yes Then
                            '''    blnSuccess = ofctDocumento.AplicarCreditoFiscal(oParametroNCF)
                            '''    oParametroNCF.Retorno.NCF = oDocumento.GenerateNCF(LibXConnector1.CurrentDataRow!type_code, LibXConnector1.CurrentDataRow!whse_code, SGT.Inventario.Entidades.Documento.TipoNCFEnum.SinValorFiscal)
                            '''    blnSuccess = True
                            '''Else
                            Throw New ApplicationException("Proceso abortado!")
                            '''End If
                        End If
                    End If
                End If

                If blnSuccess = True Then
                    If Not oParametroNCF.Retorno.NCF Is Nothing Then
                        Dim XUpdate As New LibX.Data.XUpdateStmt("ftfactm")
                        If oParametroNCF.Retorno.Cliente > 0 Then XUpdate.FieldsSet("cust_serial") = oParametroNCF.Retorno.Cliente
                        If Not oParametroNCF.Retorno.NCF Is Nothing Then If Len(oParametroNCF.Retorno.NCF) <> 19 Then oParametroNCF.Retorno.NCF = Nothing Else XUpdate.FieldsSet("fact_ncf") = oParametroNCF.Retorno.NCF
                        If (Not oParametroNCF.Retorno.CustCode.ToString Is Nothing) Then If oParametroNCF.Retorno.CustCode <> 0 Then XUpdate.FieldsSet("cust_code") = oParametroNCF.Retorno.CustCode Else XUpdate.FieldsSet("cust_code") = LibXConnector1.CurrentDataRow!cust_code

                        XUpdate.Fields("ftserial_no") = LibXConnector1.CurrentDataRow!ftserial_no
                        XUpdate.Execute()
                    End If
                End If
            End If
            If Mefectivo > 0 And (Mcheque > 0 Or Mcredito > 0) Then
                If Mneto <> Mtotal Then
                    Throw New ApplicationException("Debe revisar la distribucion")
                End If
            End If

            oCobro.Aplicar(oParam)

            '// Abrir Cash Drawer
            If cashDrowerOpen = True Then
                If Efectivo > 0 Then
                    Open_CashDrawer(mAquinaCaja)
                End If
            End If

            If (LibX.IsNull(LibXConnector1.CurrentDataRow!fact_inddomicilio) = False _
                AndAlso LibXConnector1.CurrentDataRow!fact_inddomicilio = 1) Then
                If LibX.IsNull(xcbo_vend_mensj.SelectedValue) = False Then
                    Dim xUpdate As LibX.Data.XUpdateStmt
                    xUpdate = New LibX.Data.XUpdateStmt("ftdomim")

                    XUpdate.FieldsSet("vend_mensaj") = xcbo_vend_mensj.SelectedValue
                    XUpdate.Fields("ftserial_no") = oParam.DocSerial

                    XUpdate.Execute()
                End If
            End If
        Catch ex As Exception
            ''Log.Show(ex)
            Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Dim Pagado As Decimal
        Dim Neto As Decimal
        Dim monto As Decimal
        Dim vuelto As Decimal
        Dim efectivo As Decimal

        Try
            If e.AcceptedAction = LibxConnectionActions.Edit _
            And e.Action <> LibxConnectionActions.Cancel Then
                If txtTotalPagado.Text.Trim.Length > 0 Then
                    Pagado = txtTotalPagado.Text
                End If

                If txtNeto.Text.Trim.Length > 0 Then
                    Neto = txtNeto.Text
                End If

                If txtDevuelta.Text.Trim.Length > 0 Then
                    vuelto = txtDevuelta.Text
                End If

                If txtMonEfe.Text.Trim.Length > 0 Then
                    efectivo = txtMonEfe.Text
                End If

                If efectivo <= 0 And vuelto > 0 Then
                    Throw New ApplicationException("Cantidad excede el monto a pagar!")
                End If

                If (Pagado - vuelto) <> Neto Then
                    Throw New ApplicationException("Cantidad no salda el monto del documento")
                End If

                If (Not LibX.IsNull(LibXConnector1.CurrentDataRow!fact_inddomicilio) _
                AndAlso LibXConnector1.CurrentDataRow!fact_inddomicilio = 1) Then
                    If LibX.IsNull(xcbo_vend_mensj.SelectedValue) Then
                        xcbo_vend_mensj.Focus()
                        Throw New ApplicationException("Debe especificar el Mensajero")
                    End If
                End If

                If txtMonCxC.Text.Trim.Length > 0 Then
                    monto = txtMonCxC.Text
                    If txtcust_code.Text.Trim.Length <= 0 Then
                        Throw New ApplicationException("Debe especificar el cliente a crédito")
                    End If
                End If

                If txtMonChe.Text.Trim.Length > 0 Then
                    monto = txtMonChe.Text
                    If txtNumChe.Text.Trim.Length <= 0 Then
                        Throw New ApplicationException("Debe especificar el número del cheque")
                    End If

                    If monto > CType(xtxt_chk_amount.Text, Decimal) Then
                        Throw New ApplicationException("Monto pagado en cheque no corresponde con el valor del cheque!")
                    End If
                End If

                If txtMonNota.Text.Trim.Length > 0 Then
                    monto = txtMonNota.Text

                    If txtinvce_no.Text.Trim.Length <= 0 And oDocumento.AfectaOtrosDocumentos = False Then
                        Throw New ApplicationException("Debe especificar el número de la nota de crédito")
                    End If

                    If oDocumento.AfectaOtrosDocumentos = False Then
                        If monto > CType(balance.Text, Decimal) Then
                            Throw New ApplicationException("Balance en nota de crédito no corresponde con la cantidad pagada")
                        End If
                    End If
                End If

                If Me.txtMonTarjeta.Text.Trim.Length > 0 Then
                    monto = txtMonTarjeta.Text
                    If LibX.IsNull(Me.xcbo_tart_code.currValue) OrElse Me.xcbo_tart_code.currValue <= 0 Then
                        Throw New ApplicationException("Debe especificar el Tipo de Tarjeta")
                    End If
                End If

                '// Cobrar Documento
                AplicarCobro()

                oDocumento = New SGT.Inventario.Entidades.Documento(LibXConnector1.CurrentDataRow!type_code)

                If LibXConnector1.CurrentDataRow!type_code = "FPV" Then
                    If Me.txtMonTarjeta.Text.Trim.Length > 0 And oDocumento.AutoImpTar = False Then
                        oDocumento.AutoImprimir = False
                    End If
                    If Me.txtMonEfe.Text.Trim.Length > 0 And oDocumento.AutoImpEfe = False Then
                        oDocumento.AutoImprimir = False
                    End If
                    If Me.txtMonCxC.Text.Trim.Length > 0 And oDocumento.AutoImpCxc = False Then
                        oDocumento.AutoImprimir = False
                    End If
                    If Me.txtMonChe.Text.Trim.Length > 0 And oDocumento.AutoImpChq = False Then
                        oDocumento.AutoImprimir = False
                    End If
                End If

                If oDocumento.AutoImprimir = True AndAlso _
                (LibX.IsNull(LibXConnector1.CurrentDataRow!fact_inddomicilio) _
                    OrElse LibXConnector1.CurrentDataRow!fact_inddomicilio = 0) Then
                    Select Case LibXConnector1.CurrentDataRow!type_code.ToString.Trim
                        Case "RCB"
                            LibXConnector1.ModuleName = "PTV"
                            LibXConnector1.ReportName = "r_pvrecib01.rpt"
                        Case "RCE"
                            LibXConnector1.ModuleName = "CXC"
                            LibXConnector1.ReportName = "r_ccpaym01.rpt"
                        Case "EST"
                            LibXConnector1.ModuleName = "PTV"
                            LibXConnector1.ReportName = "r_pvestaf01.rpt"
                        Case "FTS"
                            LibXConnector1.ModuleName = "PTV"
                            LibXConnector1.ReportName = "r_pvfservi01.rpt"
                    End Select

                    If oDocumento.SoloDomicilio = True Then
                        If oDocumento.CantCopiasDOM > 0 And LibXConnector1.CurrentDataRow!fact_inddomicilio = 1 Then
                            LibXConnector1.ReportObject.Copias = oDocumento.CantCopiasDOM   '// Imprimir Copia
                        End If
                    Else
                        If Me.txtMonTarjeta.Text.Trim.Length > 0 Then
                            LibXConnector1.ReportObject.Copias = oDocumento.CantCopiasTAR   '// Imprimir Copia
                        End If
                        If Me.txtMonEfe.Text.Trim.Length > 0 Then
                            LibXConnector1.ReportObject.Copias = oDocumento.CantCopiasEFE   '// Imprimir Copia
                        End If
                        If Me.txtMonCxC.Text.Trim.Length > 0 Then
                            LibXConnector1.ReportObject.Copias = oDocumento.CantCopiasCXC    '// Imprimir Copia
                        End If
                        If Me.txtMonChe.Text.Trim.Length > 0 Then
                            LibXConnector1.ReportObject.Copias = oDocumento.CantCopiasCHK     '// Imprimir Copia
                        End If

                        LibXConnector1.ReportObject.Destination = Crystal.DestinationConstants.crptToPrinter '// Imprimir Directo
                        LibXConnector1.Print()
                        SetPrinted(LibXConnector1.CurrentDataRow!ftserial_no)
                    End If
                End If
            End If
        Catch ex As Exception
            Log.Add(ex)
        End Try

    End Sub
    Private Sub SetPrinted(ByVal pftserial_no As Integer)
        Dim XUpdate As LibX.Data.XUpdateStmt

        XUpdate = New LibX.Data.XUpdateStmt("ftfactm")
        XUpdate.FieldsSet("fact_impresa") = 1
        XUpdate.Fields("ftserial_no") = pftserial_no
        XUpdate.Execute()

    End Sub
    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        Try
            If LibXConnector1.IsDataEditing = True Then
                LibXConnector1.AcceptEdit()
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xlk_invce_no_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_invce_no.BeforeExecuteQuery
        Try
            e.aditionalWhere = "type_code ='NCR' and ncr_estatus = 1"

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            If LibXConnector1.IsDataEditing = True Then
                LibXConnector1.Cancel()
            End If

            Me.DialogResult = DialogResult.Cancel
            Me.Close()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub EnabledTAR(ByVal Enabled As Boolean)
        Dim e As LibX.XChangeStateEventArgs
        If Me.txtMonTarjeta.Text.Trim <> "" AndAlso Me.xcbo_tart_code.Text.Trim <> "" Then
            Exit Sub
        End If

        Try
            e = New LibX.XChangeStateEventArgs

            If Enabled = True Then
                Me.TabControl1.SelectedTab = Me.TabTarjeta
                e.state = LibxConnectorState.Edit
                e.action = LibxConnectionActions.Edit
                xcbo_tart_code.LoadDbItems(True)
            Else
                e.state = LibxConnectorState.none
                e.action = LibxConnectionActions.None
                Me.xcbo_tart_code.currValue = -1
            End If

            e.isDataEditing = Enabled
            e.isEditing = Enabled
            e.isInDataQuery = False
            e.isLoadingForm = False
            e.isMoving = False

            Me.xcbo_tart_code.RefreshState(e)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub EnabledNC(ByVal Enabled As Boolean)
        Dim e As LibX.XChangeStateEventArgs
        Try
            If Me.txtMonNota.Text.Trim <> "" AndAlso Me.txtinvce_no.Text.Trim <> "" Then
                Exit Sub
            End If

            e = New LibX.XChangeStateEventArgs

            If Enabled = True Then
                Me.TabControl1.SelectedTab = Me.TabNC
                e.state = LibxConnectorState.Edit
                e.action = LibxConnectionActions.Edit
            Else
                e.state = LibxConnectorState.none
                e.action = LibxConnectionActions.None

                Me.txtinvce_no.Text = ""
                Me.txtinvce_Serial.Text = ""
                Me.txtinvce_name.Text = ""
                Me.xdt_nc_date.Value = DBNull.Value
                Me.xlk_invce_no.Clear(False)
            End If

            e.isDataEditing = Enabled
            e.isEditing = Enabled
            e.isInDataQuery = False
            e.isLoadingForm = False
            e.isMoving = False

            Me.xdt_nc_date.RefreshState(e)
            Me.txtinvce_no.RefreshState(e)
            Me.txtinvce_Serial.RefreshState(e)
            Me.txtinvce_name.RefreshState(e)
            Me.xlk_invce_no.Enabled = Enabled
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub EnabledCHK(ByVal Enabled As Boolean)
        Dim e As LibX.XChangeStateEventArgs

        If Me.txtMonChe.Text.Trim <> "" AndAlso Me.txtNumChe.Text.Trim <> "" Then
            Exit Sub
        End If

        Try
            e = New LibX.XChangeStateEventArgs

            If Enabled = True Then
                Me.TabControl1.SelectedTab = Me.TabCheque
                e.state = LibxConnectorState.Edit
                e.action = LibxConnectionActions.Edit
                Me.xtxt_chk_amount.Text = Me.txtMonChe.Text
            Else
                e.state = LibxConnectorState.none
                e.action = LibxConnectionActions.None

                Me.txtNumChe.Text = ""
                Me.xtxt_chk_amount.Text = ""
                Me.xtxt_chk_benef.Text = ""
                Me.xdt_fecha.Value = DBNull.Value
                Me.xcbo_ban_cheque.currValue = -1
            End If

            e.isDataEditing = Enabled
            e.isEditing = Enabled
            e.isInDataQuery = False
            e.isLoadingForm = False
            e.isMoving = False

            Me.txtNumChe.RefreshState(e)
            Me.xtxt_chk_amount.RefreshState(e)
            Me.xtxt_chk_benef.RefreshState(e)
            Me.xdt_fecha.RefreshState(e)
            Me.xcbo_ban_cheque.RefreshState(e)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub EnabledCXC(ByVal Enabled As Boolean)
        Dim e As LibX.XChangeStateEventArgs
        If Me.txtMonCxC.Text.Trim <> "" AndAlso Me.txtcust_code.Text.Trim <> "" Then
            Exit Sub
        End If

        Try
            e = New LibX.XChangeStateEventArgs

            If Enabled = True Then
                Me.TabControl1.SelectedTab = Me.TabCredito
                e.state = LibxConnectorState.Edit
                e.action = LibxConnectionActions.Edit
                Me.xlk_cust_code.Enabled = True
            Else
                e.state = LibxConnectorState.none
                e.action = LibxConnectionActions.None
                Me.xlk_cust_code.Clear(False)
                Me.txtcust_code.Text = ""
            End If

            e.isDataEditing = Enabled
            e.isEditing = Enabled
            e.isInDataQuery = False
            e.isLoadingForm = False
            e.isMoving = False

            Me.txtcust_code.RefreshState(e)
            Me.txtbus_name.RefreshState(e)
            Me.txtaddress.RefreshState(e)
            Me.xtxt_balance.RefreshState(e)
            Me.xtxt_credit_limit.RefreshState(e)
            Me.xtxt_phone1.RefreshState(e)
            Me.xtxt_phone2.RefreshState(e)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaulteditValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultEditValues) Handles LibXConnector1.SettingDefaulteditValues
        Dim e1 As LibX.XChangeStateEventArgs

        Try

            '//SI LA CAJA NO A SIDO SELECCIONADA SELECCIONARLA
            If CajaAbierta.CajeraCode <= 0 Then
                LibX.LibXRunner.Run("i_cjopen", "CAJ", True)

                If CajaAbierta.CajeraCode <= 0 Then
                    Me.Close()
                    Exit Sub
                End If
            End If

            e1 = New LibX.XChangeStateEventArgs

            e1.isDataEditing = False
            e1.isEditing = False
            e1.isInDataQuery = False
            e1.isLoadingForm = False
            e1.isMoving = False

            txtCajaNombre.Text = CajaAbierta.CajaName
            txtCajeraNombre.Text = CajaAbierta.CajeraName

            '// Definir el tipo de documento
            oDocumento = New SGT.Inventario.Entidades.Documento(LibXConnector1.CurrentDataRow!type_code)

            '// Devoluciones
            If oDocumento.AfectaOtrosDocumentos = True Then
                txtMonChe.EditState = IEditProperty.InitialStateEnum.Disabled
                txtMonChe.RefreshState(e1)
                txtMonTarjeta.EditState = IEditProperty.InitialStateEnum.Disabled
                txtMonTarjeta.RefreshState(e1)

                txtMonCxC.Enabled = True
                txtMonEfe.Enabled = True
                txtMonNota.Enabled = True
            End If

            Me.GroupBox2.Visible = (Not LibX.IsNull(LibXConnector1.CurrentDataRow!fact_inddomicilio) _
                                    AndAlso LibXConnector1.CurrentDataRow!fact_inddomicilio = 1)

            '// Domicilio
            If (Not LibX.IsNull(LibXConnector1.CurrentDataRow!fact_inddomicilio) _
            AndAlso LibXConnector1.CurrentDataRow!fact_inddomicilio = 1) Then
                txtMonChe.EditState = IEditProperty.InitialStateEnum.Disabled
                txtMonChe.RefreshState(e1)

                txtMonCxC.EditState = IEditProperty.InitialStateEnum.Disabled
                txtMonCxC.RefreshState(e1)

                txtMonEfe.EditState = IEditProperty.InitialStateEnum.Disabled
                txtMonEfe.RefreshState(e1)

                txtMonTarjeta.EditState = IEditProperty.InitialStateEnum.Disabled
                txtMonTarjeta.RefreshState(e1)

                txtMonNota.EditState = IEditProperty.InitialStateEnum.Disabled
                txtMonNota.RefreshState(e1)

                '// Cliente
                If LibX.IsNull(LibXConnector1.CurrentDataRow!cust_code) = False Then
                    Me.txtcust_code.Text = LibXConnector1.CurrentDataRow!cust_code.ToString.Trim
                    Me.xlk_cust_code.ExecuteFind()
                End If
            End If

            '// Recibo de Ingresos y Egresos
            If LibXConnector1.CurrentDataRow!type_code.ToString.Trim = "RCE" _
            Or LibXConnector1.CurrentDataRow!type_code.ToString.Trim = "REF" Then
                txtMonChe.EditState = IEditProperty.InitialStateEnum.Disabled
                txtMonChe.RefreshState(e1)

                txtMonCxC.EditState = IEditProperty.InitialStateEnum.Disabled
                txtMonCxC.RefreshState(e1)

                txtMonEfe.EditState = IEditProperty.InitialStateEnum.Disabled
                txtMonEfe.RefreshState(e1)

                txtMonTarjeta.EditState = IEditProperty.InitialStateEnum.Disabled
                txtMonTarjeta.RefreshState(e1)

                txtMonNota.EditState = IEditProperty.InitialStateEnum.Disabled
                txtMonNota.RefreshState(e1)
            End If

            If LibXConnector1.CurrentDataRow!type_code.ToString.Trim = "RCB" Then
                txtMonCxC.EditState = IEditProperty.InitialStateEnum.Disabled
                txtMonCxC.RefreshState(e1)

                txtMonNota.EditState = IEditProperty.InitialStateEnum.Disabled
                txtMonNota.RefreshState(e1)
            End If
            If LibXConnector1.CurrentDataRow!type_code.ToString.Trim = "EST" Then
                txtMonCxC.EditState = IEditProperty.InitialStateEnum.Disabled
                txtMonCxC.RefreshState(e1)

                txtMonNota.EditState = IEditProperty.InitialStateEnum.Disabled
                txtMonNota.RefreshState(e1)
            End If

            ''''// Si es nulo y esto genera NCF 
            '''If oDocumento.AfectaOtrosDocumentos = False _
            '''AndAlso LibX.IsNull(LibXConnector1.CurrentDataRow!fact_ncf) _
            '''AndAlso oDocumento.GenerarNCF = True Then

            '''    Dim oParametroNCF As ParametrosCreditoFiscal = New SGT.Facturacion.Entidades.ParametrosCreditoFiscal
            '''    Dim blnSuccess As Boolean = False

            '''    oParametroNCF.Almacen = LibXConnector1.CurrentDataRow!whse_code
            '''    If LibXConnector1.CurrentDataRow!type_code.ToString.Trim = "FSG" Then
            '''        oParametroNCF.Cliente = LibXConnector1.CurrentDataRow!cia_serial

            '''        blnSuccess = ofctDocumento.AplicarCreditoFiscalSeguro(oParametroNCF)
            '''    Else
            '''        oParametroNCF.TipoDocumento = LibXConnector1.CurrentDataRow!type_code

            '''        blnSuccess = ofctDocumento.AplicarCreditoFiscal(oParametroNCF)
            '''    End If

            '''    If blnSuccess = True Then
            '''        If Not oParametroNCF.Retorno.NCF Is Nothing Then
            '''            Dim XUpdate As New LibX.Data.XUpdateStmt("ftfactm")
            '''            If oParametroNCF.Retorno.Cliente > 0 Then XUpdate.FieldsSet("cust_serial") = oParametroNCF.Retorno.Cliente
            '''            If Not oParametroNCF.Retorno.NCF Is Nothing Then XUpdate.FieldsSet("fact_ncf") = oParametroNCF.Retorno.NCF

            '''            XUpdate.Fields("ftserial_no") = LibXConnector1.CurrentDataRow!ftserial_no
            '''            XUpdate.Execute()
            '''        End If
            '''    End If
            '''End If

            '// si es a domicilio desplegar la informacion recopilada
            If Not LibX.IsNull(LibXConnector1.CurrentDataRow!fact_inddomicilio) _
            AndAlso LibXConnector1.CurrentDataRow!fact_inddomicilio = 1 Then
                Select Case Me.ftdomim.Rows(0)!domi_pago.ToString.Trim
                    Case "EFE"
                        If LibX.IsNull(Me.ftdomim.Rows(0)!domi_cambio) = False Then
                            Me.txtMonEfe.Text = CDec(Me.ftdomim.Rows(0)!domi_cambio).ToString("###,###,##0.00")
                        Else
                            txtMonEfe.Text = txtNeto.Text
                        End If
                        mEnter(mPagos.IndexOf(mPagos, Me.txtMonEfe.Name)) = True

                    Case "TAR"
                        Me.txtMonTarjeta.Text = CDec(txtNeto.Text).ToString("###,###,##0.00")
                        mEnter(mPagos.IndexOf(mPagos, Me.txtMonTarjeta.Name)) = True

                        Me.xcbo_tart_code.LoadDbItems(True)
                        If Not LibX.IsNull(Me.ftdomim.Rows(0)!tarj_tipo) Then Me.xcbo_tart_code.currValue = Me.ftdomim.Rows(0)!tarj_tipo

                    Case "CXC"
                        txtMonCxC.Text = txtNeto.Text
                        Me.txtcust_code.Text = LibXConnector1.CurrentDataRow!cust_code.ToString.Trim
                        Me.xlk_cust_code.ExecuteFind()
                        Me.TabControl1.SelectedTab = Me.TabCredito
                        mEnter(mPagos.IndexOf(mPagos, Me.txtMonCxC.Name)) = True

                End Select

            ElseIf LibXConnector1.CurrentDataRow!fact_cond = 1 Then
                txtMonEfe.Text = txtNeto.Text
                mEnter(mPagos.IndexOf(mPagos, Me.txtMonEfe.Name)) = True

            ElseIf LibXConnector1.CurrentDataRow!fact_cond = 3 Then
                Me.txtMonNota.Text = txtNeto.Text
                Me.txtcust_code.Text = LibXConnector1.CurrentDataRow!cust_code.ToString.Trim
                Me.xlk_cust_code.ExecuteFind()
                Me.TabControl1.SelectedTab = Me.TabCredito
                mEnter(mPagos.IndexOf(mPagos, Me.txtMonNota.Name)) = True

            Else
                txtMonCxC.Text = txtNeto.Text
                Me.txtcust_code.Text = LibXConnector1.CurrentDataRow!cust_code.ToString.Trim
                Me.xlk_cust_code.ExecuteFind()
                Me.TabControl1.SelectedTab = Me.TabCredito
                mEnter(mPagos.IndexOf(mPagos, Me.txtMonCxC.Name)) = True
            End If
            CheckTotal()

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub GeneralKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMonEfe.KeyDown, _
                                                                                                            txtMonTarjeta.KeyDown, _
                                                                                                            txtMonChe.KeyDown, _
                                                                                                            txtMonCxC.KeyDown, _
                                                                                                            txtMonNota.KeyDown


        If sender.readonly = True Then
            Exit Sub
        End If

        If (e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Tab) And sender.text.trim.length > 0 Then
            mEnter(mPagos.IndexOf(mPagos, sender.name)) = True
            mPrevValue(mPagos.IndexOf(mPagos, sender.name)) = CDbl(sender.text.trim)
        End If

        If e.KeyCode = Keys.Up Then
            If mPrevValue(mPagos.IndexOf(mPagos, sender.Name)) > 0 AndAlso sender.text.trim.length > 0 Then
                sender.Text = mPrevValue(mPagos.IndexOf(mPagos, sender.Name))
            Else
                sender.text = ""
            End If

            Select Case sender.name
                Case Me.txtMonEfe.Name
                    If LibXConnector1.CurrentDataRow!type_code.ToString.Trim = "RCB" Then
                        Me.txtMonChe.Focus()
                    Else
                        Me.txtMonCxC.Focus()
                    End If

                Case Me.txtMonTarjeta.Name
                    Me.txtMonEfe.Focus()
                Case Me.txtMonChe.Name
                    Me.txtMonTarjeta.Focus()
                Case Me.txtMonNota.Name
                    Me.txtMonChe.Focus()
                Case Me.txtMonCxC.Name
                    Me.txtMonNota.Focus()
            End Select
        End If

        If e.KeyCode = Keys.Down Then
            If mPrevValue(mPagos.IndexOf(mPagos, sender.Name)) > 0 AndAlso sender.text.trim.length > 0 Then
                sender.Text = mPrevValue(mPagos.IndexOf(mPagos, sender.Name))
            Else
                sender.text = ""
            End If

            Select Case sender.name
                Case Me.txtMonEfe.Name
                    Me.txtMonTarjeta.Focus()
                Case Me.txtMonTarjeta.Name
                    Me.txtMonChe.Focus()
                Case Me.txtMonChe.Name
                    If LibXConnector1.CurrentDataRow!type_code.ToString.Trim = "RCB" Then
                        Me.txtMonEfe.Focus()
                    Else
                        Me.txtMonNota.Focus()
                    End If

                Case Me.txtMonNota.Name
                    Me.txtMonCxC.Focus()
                Case Me.txtMonCxC.Name
                    Me.txtMonEfe.Focus()
            End Select
        End If

    End Sub

    Private Sub GeneralEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonEfe.Enter, _
                                                                                        txtMonTarjeta.Enter, _
                                                                                        txtMonChe.Enter, _
                                                                                        txtMonCxC.Enter, _
                                                                                        txtMonNota.Enter
        Dim Neto As Decimal = 0
        Dim Pagado As Decimal = 0
        Dim PrevValue As Decimal = 0

        Try
            If sender.ReadOnly = True Then
                Exit Sub
            End If

            If Val(txtNeto.Text.Trim) > 0 Then
                Neto = txtNeto.Text
            End If

            If Val(txtTotalPagado.Text.Trim) > 0 Then
                Pagado = txtTotalPagado.Text
            End If

            If Neto > Pagado Then
                sender.Text = ((Neto - Pagado) + Val(sender.Text.trim)).ToString("###,##0.00")
            End If

            sender.SelectAll()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub GeneralValidating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMonEfe.Validating, _
                                                                                            txtMonTarjeta.Validating, _
                                                                                            txtMonChe.Validating, _
                                                                                            txtMonCxC.Validating, _
                                                                                            txtMonNota.Validating
        Try
            If sender.readonly = True Then
                Exit Sub
            End If

            CheckTotal()

        Catch ex As Exception
            Log.Show(ex)
        End Try

    End Sub

    Private Sub GeneralLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonEfe.Leave, _
                                                                                            txtMonTarjeta.Leave, _
                                                                                            txtMonChe.Leave, _
                                                                                            txtMonCxC.Leave, _
                                                                                            txtMonNota.Leave

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LibXConnector1.MoveNext()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim oParametroNCF As ParametrosCreditoFiscal = New SGT.Facturacion.Entidades.ParametrosCreditoFiscal

            If WhDefaultNo = 1 Then
                oParametroNCF.Almacen = WhDefaultNo
            Else
                oParametroNCF.Almacen = LibXConnector1.CurrentDataRow!whse_code
            End If

            oParametroNCF.TipoDocumento = LibXConnector1.CurrentDataRow!type_code
            If Not LibX.IsNull(LibXConnector1.CurrentDataRow!cust_serial) AndAlso LibXConnector1.CurrentDataRow!cust_serial > 0 Then
                oParametroNCF.Cliente = LibXConnector1.CurrentDataRow!cust_serial
                oParametroNCF.ClienteRegistrado = False
            Else
                If Not LibX.IsNull(LibXConnector1.CurrentDataRow!cust_code) AndAlso LibXConnector1.CurrentDataRow!cust_code > 0 Then
                    oParametroNCF.Cliente = LibXConnector1.CurrentDataRow!cust_code
                    oParametroNCF.ClienteRegistrado = True
                End If
            End If

            If ofctDocumento.AplicarCreditoFiscal(oParametroNCF) = True Then
                Dim XUpdate As New LibX.Data.XUpdateStmt("ftfactm")
                XUpdate.FieldsSet("cust_serial") = oParametroNCF.Retorno.Cliente
                XUpdate.FieldsSet("fact_ncf") = oParametroNCF.Retorno.NCF
                XUpdate.FieldsSet("cust_code") = oParametroNCF.Retorno.CustCode

                XUpdate.Fields("ftserial_no") = LibXConnector1.CurrentDataRow!ftserial_no
                XUpdate.Execute()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub i_cjfact01_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim trj As Decimal
        Dim cxc As Decimal
        Dim chk As Decimal
        Dim nc As Decimal
        Dim efe As Decimal
        Dim pago As Decimal

        Try
            If e.KeyCode = Keys.F5 Then
                If Me.txtTotalPagado.Text.Trim.Length > 0 Then
                    pago = Me.txtTotalPagado.Text
                Else
                    pago = 0
                End If

                If Me.txtMonTarjeta.Text.Trim.Length > 0 Then
                    trj = Me.txtMonTarjeta.Text
                Else
                    trj = 0
                End If

                If Me.txtMonChe.Text.Trim.Length > 0 Then
                    chk = Me.txtMonChe.Text
                Else
                    chk = 0
                End If

                If Me.txtMonEfe.Text.Trim.Length > 0 Then
                    efe = Me.txtMonEfe.Text
                Else
                    efe = 0
                End If

                If Me.txtMonNota.Text.Trim.Length > 0 Then
                    nc = Me.txtMonNota.Text
                Else
                    nc = 0
                End If

                If Me.txtMonCxC.Text.Trim.Length > 0 Then
                    cxc = Me.txtMonCxC.Text
                Else
                    cxc = 0
                End If

                If (efe + trj + chk + nc + cxc) <> pago Then
                    Throw New ApplicationException("Cantidad no salda el monto del documento")
                Else
                    LibXConnector1.Accept()
                    Me.Close()
                End If
            End If

            If e.KeyCode = Keys.F6 Then
                LibXConnector1.Cancel()
                If LibXConnector1.CurrentAction = LibxConnectionActions.Cancel Then
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub BuscarNC()
        Dim SelectStmt As String
        Dim oRow As DataRow
        Try
            If Me.txtinvce_no.Text.Trim = "" Then
                Exit Sub
            End If

            SelectStmt = "Select * from cjncrm " & _
                         " where ncr_number = " & Me.txtinvce_no.Text & _
                         "   and type_code = 'NCR'"

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Me.txtinvce_no.Text = ""
                Me.xdt_nc_date.Value = DBNull.Value
                Me.txtinvce_name.Text = ""
                Me.balance.Text = ""
                Me.xtxt_nc_amount.Text = ""
                xtxt_ncr_code.Text = ""
            Else
                If oRow!ncr_balance <= 0 Then
                    Throw New ApplicationException("Esta nota de credito esta saldada")
                End If
                xtxt_ncr_code.Text = oRow!ncr_code.ToString.Trim
                Me.txtinvce_no.Text = oRow!ncr_number.ToString.Trim
                Me.xdt_nc_date.Value = oRow!ncr_date
                Me.txtinvce_name.Text = oRow!bus_name.ToString.Trim
                Me.balance.Text = CDec(oRow!ncr_balance).ToString("###,###,##0.00")
                Me.xtxt_nc_amount.Text = CDec(oRow!ncr_amount).ToString("###,###,##0.00")
                If CDec(oRow!ncr_balance) <= Me.txtMonNota.Text Then
                    Me.txtMonNota.Text = CDec(oRow!ncr_balance).ToString("###,###,##0.00")
                End If

                'CheckTotal()
                Me.txtMonEfe.Focus()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub txtinvce_no_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtinvce_no.Leave
        Try
            If LibXConnector1.IsEditing = True Then
                BuscarNC()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xlk_cust_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_cust_code.BeforeExecuteQuery
        Try
            If Val(txtMonCxC.Text.Trim) > 0 Then
                e.aditionalWhere = "cust_credito = 1 and cust_status = 1 " '// Cliente Credito
            End If

            'If oDocumento.AfectaOtrosDocumentos = True Then
            '    e.aditionalWhere = "csttype_code = 2 and cust_credito = 1" '// Cliente Dominicio
            'End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub xlk_cust_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_cust_code.AfterSetValues
        ncfType = Val(e.row!ncf_type.ToString.Trim)
    End Sub

End Class
    