Imports System.Configuration.ConfigurationSettings
Imports SGT
Imports SGT.Inventario
Imports SGT.Inventario.Entidades
Imports SGT.administracion.entidades


Public Class i_ivitem01
    Inherits System.Windows.Forms.Form
    Dim WhereStmt As String
    Dim mConf As SGT.Inventario.Common.Configuration
    Dim mFactorCompra As Integer
    Dim Transf As Boolean = False
    Dim Old_unitCode As String
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.LinkLabel
    Friend WithEvents TextBox8 As LibX.XTextBox
    Friend WithEvents Label6 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label7 As System.Windows.Forms.LinkLabel
    Friend WithEvents TextBox11 As LibX.XTextBox
    Friend WithEvents TextBox13 As LibX.XTextBox
    Friend WithEvents Label8 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label9 As System.Windows.Forms.LinkLabel
    Friend WithEvents TextBox15 As LibX.XTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents group_name As LibX.XTextBox
    Friend WithEvents lkp_sgroup_code As LibX.LibXLookup
    Friend WithEvents Lkp_group_code As LibX.LibXLookup
    Friend WithEvents sgroup_name As LibX.XTextBox
    Friend WithEvents lkp_prov_code As LibX.LibXLookup
    Friend WithEvents prov_name As LibX.XTextBox
    Friend WithEvents lkp_unit_code As LibX.LibXLookup
    Friend WithEvents lkp_brand_code As LibX.LibXLookup
    Friend WithEvents brand_name As LibX.XTextBox
    Friend WithEvents unit_name As LibX.XTextBox
    Friend WithEvents unit_purch As LibX.XTextBox
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents btnGroup As System.Windows.Forms.Button
    Friend WithEvents btnSGroup As System.Windows.Forms.Button
    Friend WithEvents btnBrand As System.Windows.Forms.Button
    Friend WithEvents btnUnit As System.Windows.Forms.Button
    Friend WithEvents btnWareHouse As System.Windows.Forms.Button
    Friend WithEvents txtItemCode As LibX.XTextBox
    Friend WithEvents TextBox4 As LibX.XTextBox
    Friend WithEvents XDataGridLinkColumn1 As LibX.XDataGridLinkColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents xcbo_item_status As LibX.LibXCombo
    Friend WithEvents txtUserID As LibX.XTextBox
    Friend WithEvents txtDateCreated As LibX.XTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents xchk_pagaITBIS As LibX.LibxCheckBox
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents xck_imprimirEtiq As LibX.LibxCheckBox
    Friend WithEvents xck_AsumirEmpaque As LibX.LibxCheckBox
    Friend WithEvents xck_sugerirCompra As LibX.LibxCheckBox
    Friend WithEvents xck_vencimiento As LibX.LibxCheckBox
    Friend WithEvents BtnCodigoBarra As System.Windows.Forms.Button
    Friend WithEvents btnReferencia As System.Windows.Forms.Button
    Friend WithEvents TextBoxitem_name As LibX.XTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents XTXT_abreviada As LibX.XTextBox
    Friend WithEvents xtxt_group_code As LibX.XTextBox
    Friend WithEvents xlk_purch_unit As LibX.LibXLookup
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
    Friend WithEvents btnTransf As System.Windows.Forms.Button
    Friend WithEvents LibxCheckBox2 As LibX.LibxCheckBox
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents txtDateupdate As LibX.XTextBox
    Friend WithEvents btnHojear As System.Windows.Forms.Button
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents LibxCheckBox3 As LibX.LibxCheckBox
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Private WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblVendido As System.Windows.Forms.Label
    Friend WithEvents lblcomprado As System.Windows.Forms.Label
    Friend WithEvents lblDevuelto As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblAjustes As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblVencido As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable4 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable4 As System.Data.DataTable
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
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents DataTable5 As System.Data.DataTable
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents lnk_datelast_sales As LibX.XDataGridTextButtonColumn
    Friend WithEvents lnk_datelast_purch As LibX.XDataGridLinkColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents LibXDbSourceTable5 As LibX.LibXDbSourceTable
    Friend WithEvents LibXGrid2 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle2 As LibX.XdataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents LibXDbSourceTable6 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable6 As System.Data.DataTable
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents DataColumn73 As System.Data.DataColumn
    Friend WithEvents LibXGrid3 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle3 As LibX.XdataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents btnMOvimiento As System.Windows.Forms.Button
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn74 As System.Data.DataColumn
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents DataColumn76 As System.Data.DataColumn
    Friend WithEvents DataColumn77 As System.Data.DataColumn
    Friend WithEvents XTextBox4 As LibX.XTextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Public WithEvents xlk_item_sustit As LibX.LibXLookup
    Friend WithEvents xtxt_item_sust_name As LibX.XTextBox
    Friend WithEvents DataColumn78 As System.Data.DataColumn
    Public WithEvents xlk_princ_code As LibX.LibXLookup
    Friend WithEvents xtxt_princ_name As LibX.XTextBox
    Friend WithEvents XTextBox5 As LibX.XTextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(i_ivitem01))
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
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn76 = New System.Data.DataColumn
        Me.DataColumn77 = New System.Data.DataColumn
        Me.DataColumn78 = New System.Data.DataColumn
        Me.DataTable3 = New System.Data.DataTable
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn63 = New System.Data.DataColumn
        Me.DataTable4 = New System.Data.DataTable
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataTable5 = New System.Data.DataTable
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.DataColumn61 = New System.Data.DataColumn
        Me.DataColumn62 = New System.Data.DataColumn
        Me.DataTable6 = New System.Data.DataTable
        Me.DataColumn67 = New System.Data.DataColumn
        Me.DataColumn68 = New System.Data.DataColumn
        Me.DataColumn69 = New System.Data.DataColumn
        Me.DataColumn70 = New System.Data.DataColumn
        Me.DataColumn71 = New System.Data.DataColumn
        Me.DataColumn72 = New System.Data.DataColumn
        Me.DataColumn73 = New System.Data.DataColumn
        Me.DataColumn66 = New System.Data.DataColumn
        Me.DataColumn74 = New System.Data.DataColumn
        Me.DataColumn75 = New System.Data.DataColumn
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn64 = New System.Data.DataColumn
        Me.DataColumn65 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable4 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable5 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable6 = New LibX.LibXDbSourceTable
        Me.TextBoxitem_name = New LibX.XTextBox
        Me.txtItemCode = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.xlk_princ_code = New LibX.LibXLookup
        Me.xtxt_princ_name = New LibX.XTextBox
        Me.XTextBox5 = New LibX.XTextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.xlk_item_sustit = New LibX.LibXLookup
        Me.xtxt_item_sust_name = New LibX.XTextBox
        Me.XTextBox4 = New LibX.XTextBox
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtDateupdate = New LibX.XTextBox
        Me.btnTransf = New System.Windows.Forms.Button
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LibxCheckBox3 = New LibX.LibxCheckBox
        Me.LibxCheckBox2 = New LibX.LibxCheckBox
        Me.xck_imprimirEtiq = New LibX.LibxCheckBox
        Me.xck_AsumirEmpaque = New LibX.LibxCheckBox
        Me.xck_sugerirCompra = New LibX.LibxCheckBox
        Me.xchk_pagaITBIS = New LibX.LibxCheckBox
        Me.xck_vencimiento = New LibX.LibxCheckBox
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.TextBox4 = New LibX.XTextBox
        Me.xtxt_group_code = New LibX.XTextBox
        Me.xlk_purch_unit = New LibX.LibXLookup
        Me.lkp_unit_code = New LibX.LibXLookup
        Me.lkp_brand_code = New LibX.LibXLookup
        Me.lkp_prov_code = New LibX.LibXLookup
        Me.lkp_sgroup_code = New LibX.LibXLookup
        Me.Lkp_group_code = New LibX.LibXLookup
        Me.xcbo_item_status = New LibX.LibXCombo
        Me.group_name = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.LinkLabel
        Me.Label4 = New System.Windows.Forms.LinkLabel
        Me.XTXT_abreviada = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.sgroup_name = New LibX.XTextBox
        Me.TextBox8 = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.LinkLabel
        Me.prov_name = New LibX.XTextBox
        Me.brand_name = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.LinkLabel
        Me.TextBox11 = New LibX.XTextBox
        Me.unit_name = New LibX.XTextBox
        Me.TextBox13 = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.LinkLabel
        Me.Label9 = New System.Windows.Forms.LinkLabel
        Me.unit_purch = New LibX.XTextBox
        Me.TextBox15 = New LibX.XTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtUserID = New LibX.XTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtDateCreated = New LibX.XTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnHojear = New System.Windows.Forms.Button
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XDataGridLinkColumn1 = New LibX.XDataGridLinkColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.lnk_datelast_sales = New LibX.XDataGridTextButtonColumn
        Me.lnk_datelast_purch = New LibX.XDataGridLinkColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnGroup = New System.Windows.Forms.Button
        Me.btnWareHouse = New System.Windows.Forms.Button
        Me.btnSGroup = New System.Windows.Forms.Button
        Me.btnBrand = New System.Windows.Forms.Button
        Me.btnUnit = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnCodigoBarra = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnReferencia = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblAjustes = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.lblVencido = New System.Windows.Forms.Label
        Me.lblDevuelto = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.lblcomprado = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.lblVendido = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.btnMOvimiento = New System.Windows.Forms.Button
        Me.LibXGrid2 = New LibX.LibXGrid
        Me.XdataGridTableStyle2 = New LibX.XdataGridTableStyle
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.LibXGrid3 = New LibX.LibXGrid
        Me.XdataGridTableStyle3 = New LibX.XdataGridTableStyle
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.LibXGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.TextBoxitem_name
        Me.LibXNavigator1.FirstControlInFindMode = Me.txtItemCode
        Me.LibXNavigator1.FirstControlInNewMode = Me.TextBoxitem_name
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(962, 24)
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
        Me.LibXConnector1.DataMember = "ivitemm"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2, Me.LibXDbSourceTable3, Me.LibXDbSourceTable4, Me.LibXDbSourceTable5, Me.LibXDbSourceTable6})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable3, Me.DataTable4, Me.DataTable5, Me.DataTable6, Me.DataTable2})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn29, Me.DataColumn20, Me.DataColumn26, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn76, Me.DataColumn77, Me.DataColumn78})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"item_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "ivitemm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "item_code"
        Me.DataColumn1.MaxLength = 10
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "item_serie"
        Me.DataColumn2.MaxLength = 40
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "item_name"
        Me.DataColumn3.MaxLength = 100
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "abreviada"
        Me.DataColumn4.MaxLength = 40
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "unit_code"
        Me.DataColumn5.MaxLength = 4
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "prov_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "brand_code"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sgroup_code"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "group_code"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "purch_unit"
        Me.DataColumn10.MaxLength = 5
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "taxable"
        Me.DataColumn11.DataType = GetType(System.Int16)
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "item_status"
        Me.DataColumn12.MaxLength = 20
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "item_created"
        Me.DataColumn13.DataType = GetType(System.DateTime)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "item_serial"
        Me.DataColumn14.DataType = GetType(System.Int16)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "userid"
        Me.DataColumn15.MaxLength = 20
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "total_onhand"
        Me.DataColumn16.DataType = GetType(System.Int32)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "imprimir_etiq"
        Me.DataColumn17.DataType = GetType(System.Int16)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "asumir_emp"
        Me.DataColumn18.DataType = GetType(System.Int16)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "sugerir_compra"
        Me.DataColumn19.DataType = GetType(System.Int16)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "Referencia"
        Me.DataColumn29.MaxLength = 20
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "Aplicar_Vcmto"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sustancias"
        Me.DataColumn26.MaxLength = 300
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "item_comm"
        Me.DataColumn37.DataType = GetType(System.Int32)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "prd_controlado"
        Me.DataColumn38.DataType = GetType(System.Int32)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "item_modifcad"
        Me.DataColumn39.DataType = GetType(System.DateTime)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "item_update"
        Me.DataColumn40.DataType = GetType(System.DateTime)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "item_type"
        Me.DataColumn41.DataType = GetType(System.Int32)
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "itbis_scala"
        Me.DataColumn76.DataType = GetType(System.Int32)
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "item_sustit"
        Me.DataColumn77.MaxLength = 10
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "princ_code"
        Me.DataColumn78.DataType = GetType(System.Int32)
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn27, Me.DataColumn28, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn42, Me.DataColumn43, Me.DataColumn54, Me.DataColumn63})
        Me.DataTable3.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"item_code", "whse_code"}, True)})
        Me.DataTable3.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn27, Me.DataColumn28}
        Me.DataTable3.TableName = "ivitemv"
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "item_code"
        Me.DataColumn27.MaxLength = 10
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.ColumnName = "whse_code"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "whse_name"
        Me.DataColumn30.MaxLength = 30
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "Ubicacion"
        Me.DataColumn31.MaxLength = 82
        Me.DataColumn31.ReadOnly = True
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "existencia"
        Me.DataColumn32.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.AllowDBNull = False
        Me.DataColumn33.ColumnName = "purch_cost"
        Me.DataColumn33.DataType = GetType(System.Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.AllowDBNull = False
        Me.DataColumn34.ColumnName = "price"
        Me.DataColumn34.DataType = GetType(System.Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "ITBIS"
        Me.DataColumn35.DataType = GetType(System.Decimal)
        Me.DataColumn35.ReadOnly = True
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "precioitbis"
        Me.DataColumn36.DataType = GetType(System.Decimal)
        Me.DataColumn36.ReadOnly = True
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "datelast_sales"
        Me.DataColumn42.DataType = GetType(System.DateTime)
        '
        'DataColumn43
        '
        Me.DataColumn43.AllowDBNull = False
        Me.DataColumn43.ColumnName = "benef"
        Me.DataColumn43.DataType = GetType(System.Decimal)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "datelast_purch"
        Me.DataColumn54.DataType = GetType(System.DateTime)
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "total_cost"
        Me.DataColumn63.DataType = GetType(System.Decimal)
        Me.DataColumn63.ReadOnly = True
        '
        'DataTable4
        '
        Me.DataTable4.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53})
        Me.DataTable4.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"item_code", "whse_code"}, True)})
        Me.DataTable4.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn45, Me.DataColumn44}
        Me.DataTable4.TableName = "ESTATISTICA_PRODUCTO"
        '
        'DataColumn44
        '
        Me.DataColumn44.AllowDBNull = False
        Me.DataColumn44.ColumnName = "whse_code"
        Me.DataColumn44.DataType = GetType(System.Int32)
        '
        'DataColumn45
        '
        Me.DataColumn45.AllowDBNull = False
        Me.DataColumn45.ColumnName = "item_code"
        Me.DataColumn45.MaxLength = 10
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "Mes"
        Me.DataColumn46.DataType = GetType(System.Int32)
        Me.DataColumn46.ReadOnly = True
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "ano"
        Me.DataColumn47.DataType = GetType(System.Int32)
        Me.DataColumn47.ReadOnly = True
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "Ventas"
        Me.DataColumn48.DataType = GetType(System.Int32)
        Me.DataColumn48.ReadOnly = True
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "Compras"
        Me.DataColumn49.DataType = GetType(System.Int32)
        Me.DataColumn49.ReadOnly = True
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "DevFact"
        Me.DataColumn50.DataType = GetType(System.Int32)
        Me.DataColumn50.ReadOnly = True
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "Vencimiento"
        Me.DataColumn51.DataType = GetType(System.Int32)
        Me.DataColumn51.ReadOnly = True
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "DevInv"
        Me.DataColumn52.DataType = GetType(System.Int32)
        Me.DataColumn52.ReadOnly = True
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "Ajustes"
        Me.DataColumn53.DataType = GetType(System.Int32)
        Me.DataColumn53.ReadOnly = True
        '
        'DataTable5
        '
        Me.DataTable5.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62})
        Me.DataTable5.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"item_code", "whse_code"}, True)})
        Me.DataTable5.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn56, Me.DataColumn55}
        Me.DataTable5.TableName = "ESTATISTICA_PRODUCTO1"
        '
        'DataColumn55
        '
        Me.DataColumn55.AllowDBNull = False
        Me.DataColumn55.ColumnName = "whse_code"
        Me.DataColumn55.DataType = GetType(System.Int32)
        '
        'DataColumn56
        '
        Me.DataColumn56.AllowDBNull = False
        Me.DataColumn56.ColumnName = "item_code"
        Me.DataColumn56.MaxLength = 10
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "ventas"
        Me.DataColumn57.DataType = GetType(System.Int32)
        Me.DataColumn57.ReadOnly = True
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "Compras"
        Me.DataColumn58.DataType = GetType(System.Int32)
        Me.DataColumn58.ReadOnly = True
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "DevFact"
        Me.DataColumn59.DataType = GetType(System.Int32)
        Me.DataColumn59.ReadOnly = True
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "Vencimiento"
        Me.DataColumn60.DataType = GetType(System.Int32)
        Me.DataColumn60.ReadOnly = True
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "DevInv"
        Me.DataColumn61.DataType = GetType(System.Int32)
        Me.DataColumn61.ReadOnly = True
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "Ajustes"
        Me.DataColumn62.DataType = GetType(System.Int32)
        Me.DataColumn62.ReadOnly = True
        '
        'DataTable6
        '
        Me.DataTable6.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72, Me.DataColumn73, Me.DataColumn66, Me.DataColumn74, Me.DataColumn75})
        Me.DataTable6.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"item_code"}, True)})
        Me.DataTable6.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn67}
        Me.DataTable6.TableName = "ivreferm"
        '
        'DataColumn67
        '
        Me.DataColumn67.AllowDBNull = False
        Me.DataColumn67.ColumnName = "item_code"
        Me.DataColumn67.MaxLength = 10
        '
        'DataColumn68
        '
        Me.DataColumn68.AllowDBNull = False
        Me.DataColumn68.ColumnName = "item_name"
        Me.DataColumn68.MaxLength = 100
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "existencia"
        Me.DataColumn69.DataType = GetType(System.Int32)
        '
        'DataColumn70
        '
        Me.DataColumn70.AllowDBNull = False
        Me.DataColumn70.ColumnName = "unit_code"
        Me.DataColumn70.MaxLength = 4
        '
        'DataColumn71
        '
        Me.DataColumn71.AllowDBNull = False
        Me.DataColumn71.ColumnName = "purch_cost"
        Me.DataColumn71.DataType = GetType(System.Decimal)
        '
        'DataColumn72
        '
        Me.DataColumn72.AllowDBNull = False
        Me.DataColumn72.ColumnName = "price"
        Me.DataColumn72.DataType = GetType(System.Decimal)
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "prov_name"
        Me.DataColumn73.MaxLength = 60
        '
        'DataColumn66
        '
        Me.DataColumn66.AllowDBNull = False
        Me.DataColumn66.ColumnName = "refer"
        Me.DataColumn66.MaxLength = 15
        '
        'DataColumn74
        '
        Me.DataColumn74.AllowDBNull = False
        Me.DataColumn74.ColumnName = "purch_unit"
        Me.DataColumn74.MaxLength = 5
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "brand_name"
        Me.DataColumn75.MaxLength = 30
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn64, Me.DataColumn65})
        Me.DataTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"item_code", "unit_code"}, True)})
        Me.DataTable2.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn21, Me.DataColumn64}
        Me.DataTable2.TableName = "ivunitd"
        '
        'DataColumn21
        '
        Me.DataColumn21.AllowDBNull = False
        Me.DataColumn21.ColumnName = "item_code"
        Me.DataColumn21.MaxLength = 10
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "unit_name"
        Me.DataColumn22.MaxLength = 30
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "factor"
        Me.DataColumn23.DataType = GetType(System.Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "tipo"
        Me.DataColumn24.MaxLength = 12
        Me.DataColumn24.ReadOnly = True
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "total_cost"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        Me.DataColumn25.ReadOnly = True
        '
        'DataColumn64
        '
        Me.DataColumn64.AllowDBNull = False
        Me.DataColumn64.ColumnName = "unit_code"
        Me.DataColumn64.MaxLength = 4
        '
        'DataColumn65
        '
        Me.DataColumn65.AllowDBNull = False
        Me.DataColumn65.ColumnName = "unit_type"
        Me.DataColumn65.DataType = GetType(System.Int32)
        '
        'LibXDbSourceTable1
        '
        Me.LibXDbSourceTable1.AllowDelete = False
        Me.LibXDbSourceTable1.AllowEdit = True
        Me.LibXDbSourceTable1.AllowNew = True
        Me.LibXDbSourceTable1.AutoIncrementSerial = False
        Me.LibXDbSourceTable1.CustomDbUpdate = False
        Me.LibXDbSourceTable1.DeleteOrder = 1
        Me.LibXDbSourceTable1.FillOnQuery = True
        Me.LibXDbSourceTable1.FillOnRowChange = False
        Me.LibXDbSourceTable1.HeaderIsOnGrid = False
        Me.LibXDbSourceTable1.InnerJon = True
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = "item_code"
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = New String() {Nothing}
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ivitemm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LibXDbSourceTable2
        '
        Me.LibXDbSourceTable2.AllowDelete = False
        Me.LibXDbSourceTable2.AllowEdit = False
        Me.LibXDbSourceTable2.AllowNew = False
        Me.LibXDbSourceTable2.AutoIncrementSerial = False
        Me.LibXDbSourceTable2.CustomDbUpdate = True
        Me.LibXDbSourceTable2.DeleteOrder = 0
        Me.LibXDbSourceTable2.FillOnQuery = True
        Me.LibXDbSourceTable2.FillOnRowChange = True
        Me.LibXDbSourceTable2.HeaderIsOnGrid = False
        Me.LibXDbSourceTable2.InnerJon = False
        Me.LibXDbSourceTable2.InsertOrder = 1
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = "item_code,whse_code"
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"item_code=item_code"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select *, (isnull(existencia,0)*isnull(purch_cost,0)) total_cost", "from ivitemv"}
        Me.LibXDbSourceTable2.TableName = "ivitemv"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'LibXDbSourceTable3
        '
        Me.LibXDbSourceTable3.AllowDelete = False
        Me.LibXDbSourceTable3.AllowEdit = False
        Me.LibXDbSourceTable3.AllowNew = False
        Me.LibXDbSourceTable3.AutoIncrementSerial = False
        Me.LibXDbSourceTable3.CustomDbUpdate = True
        Me.LibXDbSourceTable3.DeleteOrder = 0
        Me.LibXDbSourceTable3.FillOnQuery = True
        Me.LibXDbSourceTable3.FillOnRowChange = False
        Me.LibXDbSourceTable3.HeaderIsOnGrid = False
        Me.LibXDbSourceTable3.InnerJon = False
        Me.LibXDbSourceTable3.InsertOrder = 0
        Me.LibXDbSourceTable3.IsDetail = True
        Me.LibXDbSourceTable3.KeyFields = "item_code,whse_code"
        Me.LibXDbSourceTable3.LineColName = Nothing
        Me.LibXDbSourceTable3.MasterDetailRelation = New String() {"item_code=item_code"}
        Me.LibXDbSourceTable3.MasterTableName = Nothing
        Me.LibXDbSourceTable3.SerialColumnName = Nothing
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = New String() {"SELECT whse_code, item_code, ", "SUM(ventas) ventas,", "SUM(compras) Compras,", "SUM(DevFact) DevFact,", "SUM(Vencimiento) Vencimiento,", "SUM(DevInv) DevInv,", "SUM(Ajustes) Ajustes", " FROM ESTATISTICA_PRODUCTO", "WHERE mes = month(getdate())", "AND ano = year(getdate())", "GROUP BY whse_code, item_code"}
        Me.LibXDbSourceTable3.TableName = "ESTATISTICA_PRODUCTO"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'LibXDbSourceTable4
        '
        Me.LibXDbSourceTable4.AllowDelete = False
        Me.LibXDbSourceTable4.AllowEdit = False
        Me.LibXDbSourceTable4.AllowNew = False
        Me.LibXDbSourceTable4.AutoIncrementSerial = False
        Me.LibXDbSourceTable4.CustomDbUpdate = True
        Me.LibXDbSourceTable4.DeleteOrder = 0
        Me.LibXDbSourceTable4.FillOnQuery = True
        Me.LibXDbSourceTable4.FillOnRowChange = False
        Me.LibXDbSourceTable4.HeaderIsOnGrid = False
        Me.LibXDbSourceTable4.InnerJon = False
        Me.LibXDbSourceTable4.InsertOrder = 0
        Me.LibXDbSourceTable4.IsDetail = True
        Me.LibXDbSourceTable4.KeyFields = "item_code,whse_code"
        Me.LibXDbSourceTable4.LineColName = Nothing
        Me.LibXDbSourceTable4.MasterDetailRelation = New String() {"item_code=item_code"}
        Me.LibXDbSourceTable4.MasterTableName = Nothing
        Me.LibXDbSourceTable4.SerialColumnName = Nothing
        Me.LibXDbSourceTable4.Sort = Nothing
        Me.LibXDbSourceTable4.Source = New String() {"SELECT whse_code, item_code, ", "SUM(ventas) ventas,", "SUM(compras) Compras,", "SUM(DevFact) DevFact,", "SUM(Vencimiento) Vencimiento,", "SUM(DevInv) DevInv,", "SUM(Ajustes) Ajustes", " FROM ESTATISTICA_PRODUCTO ESTATISTICA_PRODUCTO1", "GROUP BY whse_code, item_code"}
        Me.LibXDbSourceTable4.TableName = "ESTATISTICA_PRODUCTO1"
        Me.LibXDbSourceTable4.UpdateOrder = 0
        Me.LibXDbSourceTable4.UseRowRetrieve = False
        '
        'LibXDbSourceTable5
        '
        Me.LibXDbSourceTable5.AllowDelete = False
        Me.LibXDbSourceTable5.AllowEdit = False
        Me.LibXDbSourceTable5.AllowNew = False
        Me.LibXDbSourceTable5.AutoIncrementSerial = False
        Me.LibXDbSourceTable5.CustomDbUpdate = True
        Me.LibXDbSourceTable5.DeleteOrder = 0
        Me.LibXDbSourceTable5.FillOnQuery = True
        Me.LibXDbSourceTable5.FillOnRowChange = True
        Me.LibXDbSourceTable5.HeaderIsOnGrid = False
        Me.LibXDbSourceTable5.InnerJon = False
        Me.LibXDbSourceTable5.InsertOrder = 0
        Me.LibXDbSourceTable5.IsDetail = True
        Me.LibXDbSourceTable5.KeyFields = "item_code,unit_code"
        Me.LibXDbSourceTable5.LineColName = Nothing
        Me.LibXDbSourceTable5.MasterDetailRelation = New String() {"item_code=item_code"}
        Me.LibXDbSourceTable5.MasterTableName = "ivitemm"
        Me.LibXDbSourceTable5.SerialColumnName = Nothing
        Me.LibXDbSourceTable5.Sort = Nothing
        Me.LibXDbSourceTable5.Source = New String() {"select ud.item_code, ud.unit_code, um.unit_name,unit_type,ud.factor, case when un" & _
        "it_type = 1 ", "" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "then 'Compra' ", "" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "when unit_type = 2", "" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "then 'Venta'", "" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "else", "" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "'Compra/Venta' end tipo,", "purch_cost*ud.factor total_cost", "from ivunitd ud", "inner join ivunitm um", "on um.unit_code = ud.unit_code", "inner join ivitemv1 im", "on im.item_code = ud.item_code"}
        Me.LibXDbSourceTable5.TableName = "ivunitd"
        Me.LibXDbSourceTable5.UpdateOrder = 0
        Me.LibXDbSourceTable5.UseRowRetrieve = False
        '
        'LibXDbSourceTable6
        '
        Me.LibXDbSourceTable6.AllowDelete = False
        Me.LibXDbSourceTable6.AllowEdit = False
        Me.LibXDbSourceTable6.AllowNew = False
        Me.LibXDbSourceTable6.AutoIncrementSerial = False
        Me.LibXDbSourceTable6.CustomDbUpdate = True
        Me.LibXDbSourceTable6.DeleteOrder = 0
        Me.LibXDbSourceTable6.FillOnQuery = True
        Me.LibXDbSourceTable6.FillOnRowChange = True
        Me.LibXDbSourceTable6.HeaderIsOnGrid = False
        Me.LibXDbSourceTable6.InnerJon = False
        Me.LibXDbSourceTable6.InsertOrder = 0
        Me.LibXDbSourceTable6.IsDetail = True
        Me.LibXDbSourceTable6.KeyFields = "item_code"
        Me.LibXDbSourceTable6.LineColName = Nothing
        Me.LibXDbSourceTable6.MasterDetailRelation = New String() {"item_code=item_code"}
        Me.LibXDbSourceTable6.MasterTableName = "ivitemm"
        Me.LibXDbSourceTable6.SerialColumnName = Nothing
        Me.LibXDbSourceTable6.Sort = Nothing
        Me.LibXDbSourceTable6.Source = New String() {"SELECT * FROM ivreferv ivreferm"}
        Me.LibXDbSourceTable6.TableName = "ivreferm"
        Me.LibXDbSourceTable6.UpdateOrder = 0
        Me.LibXDbSourceTable6.UseRowRetrieve = False
        '
        'TextBoxitem_name
        '
        Me.TextBoxitem_name.AcceptsReturn = True
        Me.TextBoxitem_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxitem_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.item_name"))
        Me.TextBoxitem_name.EditInitialValue = Nothing
        Me.TextBoxitem_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBoxitem_name.FieldDescription = ""
        Me.TextBoxitem_name.FindInitialValue = Nothing
        Me.TextBoxitem_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBoxitem_name.IgnoreRequiered = False
        Me.TextBoxitem_name.Location = New System.Drawing.Point(120, 40)
        Me.TextBoxitem_name.Name = "TextBoxitem_name"
        Me.TextBoxitem_name.NewInitialValue = Nothing
        Me.TextBoxitem_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBoxitem_name.Requiered = False
        Me.TextBoxitem_name.Size = New System.Drawing.Size(376, 20)
        Me.TextBoxitem_name.StatusBarPanelDescripcion = Nothing
        Me.TextBoxitem_name.TabIndex = 1
        Me.TextBoxitem_name.Text = ""
        '
        'txtItemCode
        '
        Me.txtItemCode.AcceptsReturn = True
        Me.txtItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.item_code"))
        Me.txtItemCode.EditInitialValue = Nothing
        Me.txtItemCode.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtItemCode.FieldDescription = ""
        Me.txtItemCode.FindInitialValue = Nothing
        Me.txtItemCode.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtItemCode.IgnoreRequiered = False
        Me.txtItemCode.Location = New System.Drawing.Point(120, 16)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.NewInitialValue = Nothing
        Me.txtItemCode.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtItemCode.Requiered = False
        Me.txtItemCode.Size = New System.Drawing.Size(112, 20)
        Me.txtItemCode.StatusBarPanelDescripcion = Nothing
        Me.txtItemCode.TabIndex = 0
        Me.txtItemCode.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.xlk_princ_code)
        Me.GroupBox1.Controls.Add(Me.xtxt_princ_name)
        Me.GroupBox1.Controls.Add(Me.XTextBox5)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.xlk_item_sustit)
        Me.GroupBox1.Controls.Add(Me.xtxt_item_sust_name)
        Me.GroupBox1.Controls.Add(Me.XTextBox4)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtDateupdate)
        Me.GroupBox1.Controls.Add(Me.btnTransf)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.xtxt_group_code)
        Me.GroupBox1.Controls.Add(Me.xlk_purch_unit)
        Me.GroupBox1.Controls.Add(Me.lkp_unit_code)
        Me.GroupBox1.Controls.Add(Me.lkp_brand_code)
        Me.GroupBox1.Controls.Add(Me.lkp_prov_code)
        Me.GroupBox1.Controls.Add(Me.lkp_sgroup_code)
        Me.GroupBox1.Controls.Add(Me.Lkp_group_code)
        Me.GroupBox1.Controls.Add(Me.xcbo_item_status)
        Me.GroupBox1.Controls.Add(Me.group_name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.XTXT_abreviada)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxitem_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtItemCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.sgroup_name)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.prov_name)
        Me.GroupBox1.Controls.Add(Me.brand_name)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox11)
        Me.GroupBox1.Controls.Add(Me.unit_name)
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.unit_purch)
        Me.GroupBox1.Controls.Add(Me.TextBox15)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtUserID)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtDateCreated)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 320)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label33.Location = New System.Drawing.Point(56, 256)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(51, 16)
        Me.Label33.TabIndex = 40
        Me.Label33.Text = "Principio:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'xlk_princ_code
        '
        Me.xlk_princ_code.AlternateFieldSearch = Nothing
        Me.xlk_princ_code.BeginCheck = False
        Me.xlk_princ_code.CheckText = Nothing
        Me.xlk_princ_code.ComboMode = False
        Me.xlk_princ_code.DataMember = Nothing
        Me.xlk_princ_code.DataSource = Me.LibXConnector1
        Me.xlk_princ_code.DestParameters = New String() {"princ_code=princ_code", "xtxt_princ_name=princ_name"}
        Me.xlk_princ_code.FilterField = "princ_name"
        Me.xlk_princ_code.IgnoreFindInBrowseMode = False
        Me.xlk_princ_code.isCanceled = False
        Me.xlk_princ_code.Location = New System.Drawing.Point(480, 256)
        Me.xlk_princ_code.LookCaption = "Principios activos"
        Me.xlk_princ_code.Name = "xlk_princ_code"
        Me.xlk_princ_code.PopupSize = New System.Drawing.Size(400, 300)
        Me.xlk_princ_code.ShowFilter = True
        Me.xlk_princ_code.ShowMessageNotFound = True
        Me.xlk_princ_code.ShowWarning = False
        Me.xlk_princ_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_princ_code.SizesColumns = Nothing
        Me.xlk_princ_code.SizesColumnsTab = Nothing
        Me.xlk_princ_code.SqlString = Nothing
        Me.xlk_princ_code.SQLTab = Nothing
        Me.xlk_princ_code.SrcParameters = New String() {"princ_code=princ_code"}
        Me.xlk_princ_code.TabIndex = 39
        Me.xlk_princ_code.TableName = "ivprincm"
        Me.xlk_princ_code.TabStop = False
        Me.xlk_princ_code.UseCopyConnection = False
        Me.xlk_princ_code.UseRowRetrieveEvents = False
        Me.xlk_princ_code.UseTab = False
        Me.xlk_princ_code.VisParameters = New String() {"Código=princ_code", "Descripción=princ_name"}
        Me.xlk_princ_code.WhereCondition = Nothing
        Me.xlk_princ_code.WhereParameters = Nothing
        '
        'xtxt_princ_name
        '
        Me.xtxt_princ_name.AcceptsReturn = True
        Me.xtxt_princ_name.EditInitialValue = Nothing
        Me.xtxt_princ_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_princ_name.FieldDescription = ""
        Me.xtxt_princ_name.FindInitialValue = Nothing
        Me.xtxt_princ_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_princ_name.IgnoreRequiered = False
        Me.xtxt_princ_name.Location = New System.Drawing.Point(184, 256)
        Me.xtxt_princ_name.Name = "xtxt_princ_name"
        Me.xtxt_princ_name.NewInitialValue = Nothing
        Me.xtxt_princ_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_princ_name.ReadOnly = True
        Me.xtxt_princ_name.Requiered = False
        Me.xtxt_princ_name.Size = New System.Drawing.Size(296, 20)
        Me.xtxt_princ_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_princ_name.TabIndex = 38
        Me.xtxt_princ_name.TabStop = False
        Me.xtxt_princ_name.Text = ""
        '
        'XTextBox5
        '
        Me.XTextBox5.AcceptsReturn = True
        Me.XTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.princ_code"))
        Me.XTextBox5.EditInitialValue = Nothing
        Me.XTextBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.FieldDescription = ""
        Me.XTextBox5.FindInitialValue = Nothing
        Me.XTextBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.IgnoreRequiered = False
        Me.XTextBox5.Location = New System.Drawing.Point(120, 256)
        Me.XTextBox5.Name = "XTextBox5"
        Me.XTextBox5.NewInitialValue = Nothing
        Me.XTextBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.Requiered = False
        Me.XTextBox5.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox5.StatusBarPanelDescripcion = Nothing
        Me.XTextBox5.TabIndex = 37
        Me.XTextBox5.Text = ""
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label32.Location = New System.Drawing.Point(56, 232)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(51, 16)
        Me.Label32.TabIndex = 36
        Me.Label32.Text = "Sustituto:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_item_sustit
        '
        Me.xlk_item_sustit.AlternateFieldSearch = Nothing
        Me.xlk_item_sustit.BeginCheck = False
        Me.xlk_item_sustit.CheckText = Nothing
        Me.xlk_item_sustit.ComboMode = False
        Me.xlk_item_sustit.DataMember = Nothing
        Me.xlk_item_sustit.DataSource = Me.LibXConnector1
        Me.xlk_item_sustit.DestParameters = New String() {"item_sustit=item_code", "xtxt_item_sust_name=item_name"}
        Me.xlk_item_sustit.FilterField = "item_name"
        Me.xlk_item_sustit.IgnoreFindInBrowseMode = False
        Me.xlk_item_sustit.isCanceled = False
        Me.xlk_item_sustit.Location = New System.Drawing.Point(480, 232)
        Me.xlk_item_sustit.LookCaption = "Susitutos"
        Me.xlk_item_sustit.Name = "xlk_item_sustit"
        Me.xlk_item_sustit.PopupSize = New System.Drawing.Size(600, 300)
        Me.xlk_item_sustit.ShowFilter = True
        Me.xlk_item_sustit.ShowMessageNotFound = True
        Me.xlk_item_sustit.ShowWarning = False
        Me.xlk_item_sustit.Size = New System.Drawing.Size(16, 20)
        Me.xlk_item_sustit.SizesColumns = Nothing
        Me.xlk_item_sustit.SizesColumnsTab = Nothing
        Me.xlk_item_sustit.SqlString = New String() {"SELECT ivitemm.item_code, ", "ivitemm.item_name,", "princ_name, ", "prov_name", "FROM ivitemm", "LEFT OUTER JOIN ivprincm", "ON ivprincm.princ_code = ivitemm.princ_code", "LEFT OUTER JOIN cpprovm", "ON cpprovm.prov_code = ivitemm.prov_code"}
        Me.xlk_item_sustit.SQLTab = Nothing
        Me.xlk_item_sustit.SrcParameters = New String() {"item_sustit=item_code"}
        Me.xlk_item_sustit.TabIndex = 35
        Me.xlk_item_sustit.TableName = "ivitemm"
        Me.xlk_item_sustit.TabStop = False
        Me.xlk_item_sustit.UseCopyConnection = False
        Me.xlk_item_sustit.UseRowRetrieveEvents = False
        Me.xlk_item_sustit.UseTab = False
        Me.xlk_item_sustit.VisParameters = New String() {"Código=item_code", "Descripción=item_name", "Principio=princ_name", "Suplidor=prov_name"}
        Me.xlk_item_sustit.WhereCondition = Nothing
        Me.xlk_item_sustit.WhereParameters = Nothing
        '
        'xtxt_item_sust_name
        '
        Me.xtxt_item_sust_name.AcceptsReturn = True
        Me.xtxt_item_sust_name.EditInitialValue = Nothing
        Me.xtxt_item_sust_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_item_sust_name.FieldDescription = ""
        Me.xtxt_item_sust_name.FindInitialValue = Nothing
        Me.xtxt_item_sust_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_item_sust_name.IgnoreRequiered = False
        Me.xtxt_item_sust_name.Location = New System.Drawing.Point(232, 232)
        Me.xtxt_item_sust_name.Name = "xtxt_item_sust_name"
        Me.xtxt_item_sust_name.NewInitialValue = Nothing
        Me.xtxt_item_sust_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_item_sust_name.ReadOnly = True
        Me.xtxt_item_sust_name.Requiered = False
        Me.xtxt_item_sust_name.Size = New System.Drawing.Size(248, 20)
        Me.xtxt_item_sust_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_item_sust_name.TabIndex = 34
        Me.xtxt_item_sust_name.TabStop = False
        Me.xtxt_item_sust_name.Text = ""
        '
        'XTextBox4
        '
        Me.XTextBox4.AcceptsReturn = True
        Me.XTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.item_sustit"))
        Me.XTextBox4.EditInitialValue = Nothing
        Me.XTextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.FieldDescription = ""
        Me.XTextBox4.FindInitialValue = Nothing
        Me.XTextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.IgnoreRequiered = False
        Me.XTextBox4.Location = New System.Drawing.Point(120, 232)
        Me.XTextBox4.Name = "XTextBox4"
        Me.XTextBox4.NewInitialValue = Nothing
        Me.XTextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.Requiered = False
        Me.XTextBox4.Size = New System.Drawing.Size(104, 20)
        Me.XTextBox4.StatusBarPanelDescripcion = Nothing
        Me.XTextBox4.TabIndex = 33
        Me.XTextBox4.Text = ""
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ivitemm.item_type"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Items.AddRange(New Object() {"1-ETICO", "2-GENERICO"})
        Me.LibXCombo1.Location = New System.Drawing.Point(576, 216)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = Nothing
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(160, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 31
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Location = New System.Drawing.Point(536, 216)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 16)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Tipo:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(504, 288)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 16)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Modificado:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDateupdate
        '
        Me.txtDateupdate.AcceptsReturn = True
        Me.txtDateupdate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.item_update"))
        Me.txtDateupdate.EditInitialValue = Nothing
        Me.txtDateupdate.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtDateupdate.FieldDescription = ""
        Me.txtDateupdate.FindInitialValue = Nothing
        Me.txtDateupdate.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtDateupdate.IgnoreRequiered = False
        Me.txtDateupdate.Location = New System.Drawing.Point(576, 288)
        Me.txtDateupdate.Name = "txtDateupdate"
        Me.txtDateupdate.NewInitialValue = Nothing
        Me.txtDateupdate.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtDateupdate.ReadOnly = True
        Me.txtDateupdate.Requiered = False
        Me.txtDateupdate.Size = New System.Drawing.Size(160, 20)
        Me.txtDateupdate.StatusBarPanelDescripcion = Nothing
        Me.txtDateupdate.TabIndex = 30
        Me.txtDateupdate.TabStop = False
        Me.txtDateupdate.Text = ""
        '
        'btnTransf
        '
        Me.btnTransf.Image = CType(resources.GetObject("btnTransf.Image"), System.Drawing.Image)
        Me.btnTransf.Location = New System.Drawing.Point(8, 16)
        Me.btnTransf.Name = "btnTransf"
        Me.btnTransf.Size = New System.Drawing.Size(32, 23)
        Me.btnTransf.TabIndex = 28
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.sustancias"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(120, 280)
        Me.XTextBox2.Multiline = True
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(376, 32)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 27
        Me.XTextBox2.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(42, 280)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 16)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Sustancias:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.Referencia"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(392, 16)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(104, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 9
        Me.XTextBox1.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(304, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 16)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Codigo Alterno:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LibxCheckBox3)
        Me.GroupBox2.Controls.Add(Me.LibxCheckBox2)
        Me.GroupBox2.Controls.Add(Me.xck_imprimirEtiq)
        Me.GroupBox2.Controls.Add(Me.xck_AsumirEmpaque)
        Me.GroupBox2.Controls.Add(Me.xck_sugerirCompra)
        Me.GroupBox2.Controls.Add(Me.xchk_pagaITBIS)
        Me.GroupBox2.Controls.Add(Me.xck_vencimiento)
        Me.GroupBox2.Controls.Add(Me.LibxCheckBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(568, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 152)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'LibxCheckBox3
        '
        Me.LibxCheckBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivitemm.item_serial"))
        Me.LibxCheckBox3.EditInitialValue = Nothing
        Me.LibxCheckBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.FindInitialValue = Nothing
        Me.LibxCheckBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.IgnoreRequiered = False
        Me.LibxCheckBox3.KeepEnabled = False
        Me.LibxCheckBox3.Location = New System.Drawing.Point(8, 128)
        Me.LibxCheckBox3.Name = "LibxCheckBox3"
        Me.LibxCheckBox3.NewInitialValue = "1"
        Me.LibxCheckBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.ReadOnly = False
        Me.LibxCheckBox3.Requiered = False
        Me.LibxCheckBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox3.Size = New System.Drawing.Size(144, 16)
        Me.LibxCheckBox3.TabIndex = 6
        Me.LibxCheckBox3.Text = "Consignación"
        Me.LibxCheckBox3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox3.ThreeState = True
        Me.LibxCheckBox3.value = Nothing
        '
        'LibxCheckBox2
        '
        Me.LibxCheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivitemm.prd_controlado"))
        Me.LibxCheckBox2.EditInitialValue = Nothing
        Me.LibxCheckBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.FindInitialValue = Nothing
        Me.LibxCheckBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.IgnoreRequiered = False
        Me.LibxCheckBox2.KeepEnabled = False
        Me.LibxCheckBox2.Location = New System.Drawing.Point(8, 111)
        Me.LibxCheckBox2.Name = "LibxCheckBox2"
        Me.LibxCheckBox2.NewInitialValue = "1"
        Me.LibxCheckBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.ReadOnly = False
        Me.LibxCheckBox2.Requiered = False
        Me.LibxCheckBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox2.Size = New System.Drawing.Size(144, 16)
        Me.LibxCheckBox2.TabIndex = 5
        Me.LibxCheckBox2.Text = "Controlado"
        Me.LibxCheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox2.ThreeState = True
        Me.LibxCheckBox2.value = Nothing
        '
        'xck_imprimirEtiq
        '
        Me.xck_imprimirEtiq.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xck_imprimirEtiq.Checked = True
        Me.xck_imprimirEtiq.CheckState = System.Windows.Forms.CheckState.Checked
        Me.xck_imprimirEtiq.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivitemm.imprimir_etiq"))
        Me.xck_imprimirEtiq.EditInitialValue = Nothing
        Me.xck_imprimirEtiq.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_imprimirEtiq.FindInitialValue = Nothing
        Me.xck_imprimirEtiq.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_imprimirEtiq.IgnoreRequiered = False
        Me.xck_imprimirEtiq.KeepEnabled = False
        Me.xck_imprimirEtiq.Location = New System.Drawing.Point(8, 15)
        Me.xck_imprimirEtiq.Name = "xck_imprimirEtiq"
        Me.xck_imprimirEtiq.NewInitialValue = "1"
        Me.xck_imprimirEtiq.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_imprimirEtiq.ReadOnly = False
        Me.xck_imprimirEtiq.Requiered = False
        Me.xck_imprimirEtiq.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xck_imprimirEtiq.Size = New System.Drawing.Size(144, 16)
        Me.xck_imprimirEtiq.TabIndex = 0
        Me.xck_imprimirEtiq.Text = "Imprimir Etiqueta"
        Me.xck_imprimirEtiq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xck_imprimirEtiq.ThreeState = True
        Me.xck_imprimirEtiq.value = 1
        '
        'xck_AsumirEmpaque
        '
        Me.xck_AsumirEmpaque.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xck_AsumirEmpaque.Checked = True
        Me.xck_AsumirEmpaque.CheckState = System.Windows.Forms.CheckState.Checked
        Me.xck_AsumirEmpaque.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivitemm.asumir_emp"))
        Me.xck_AsumirEmpaque.EditInitialValue = Nothing
        Me.xck_AsumirEmpaque.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_AsumirEmpaque.FindInitialValue = Nothing
        Me.xck_AsumirEmpaque.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_AsumirEmpaque.IgnoreRequiered = False
        Me.xck_AsumirEmpaque.KeepEnabled = False
        Me.xck_AsumirEmpaque.Location = New System.Drawing.Point(8, 31)
        Me.xck_AsumirEmpaque.Name = "xck_AsumirEmpaque"
        Me.xck_AsumirEmpaque.NewInitialValue = "1"
        Me.xck_AsumirEmpaque.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_AsumirEmpaque.ReadOnly = False
        Me.xck_AsumirEmpaque.Requiered = False
        Me.xck_AsumirEmpaque.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xck_AsumirEmpaque.Size = New System.Drawing.Size(144, 16)
        Me.xck_AsumirEmpaque.TabIndex = 1
        Me.xck_AsumirEmpaque.Text = "Asumir Empaque"
        Me.xck_AsumirEmpaque.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xck_AsumirEmpaque.ThreeState = True
        Me.xck_AsumirEmpaque.value = 1
        '
        'xck_sugerirCompra
        '
        Me.xck_sugerirCompra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xck_sugerirCompra.Checked = True
        Me.xck_sugerirCompra.CheckState = System.Windows.Forms.CheckState.Checked
        Me.xck_sugerirCompra.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivitemm.sugerir_compra"))
        Me.xck_sugerirCompra.EditInitialValue = Nothing
        Me.xck_sugerirCompra.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_sugerirCompra.FindInitialValue = Nothing
        Me.xck_sugerirCompra.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_sugerirCompra.IgnoreRequiered = False
        Me.xck_sugerirCompra.KeepEnabled = False
        Me.xck_sugerirCompra.Location = New System.Drawing.Point(8, 47)
        Me.xck_sugerirCompra.Name = "xck_sugerirCompra"
        Me.xck_sugerirCompra.NewInitialValue = "1"
        Me.xck_sugerirCompra.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_sugerirCompra.ReadOnly = False
        Me.xck_sugerirCompra.Requiered = False
        Me.xck_sugerirCompra.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xck_sugerirCompra.Size = New System.Drawing.Size(144, 16)
        Me.xck_sugerirCompra.TabIndex = 2
        Me.xck_sugerirCompra.Text = "Sugerir en Compra"
        Me.xck_sugerirCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xck_sugerirCompra.ThreeState = True
        Me.xck_sugerirCompra.value = 1
        '
        'xchk_pagaITBIS
        '
        Me.xchk_pagaITBIS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xchk_pagaITBIS.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivitemm.taxable"))
        Me.xchk_pagaITBIS.EditInitialValue = Nothing
        Me.xchk_pagaITBIS.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xchk_pagaITBIS.FindInitialValue = Nothing
        Me.xchk_pagaITBIS.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xchk_pagaITBIS.IgnoreRequiered = False
        Me.xchk_pagaITBIS.KeepEnabled = False
        Me.xchk_pagaITBIS.Location = New System.Drawing.Point(8, 63)
        Me.xchk_pagaITBIS.Name = "xchk_pagaITBIS"
        Me.xchk_pagaITBIS.NewInitialValue = Nothing
        Me.xchk_pagaITBIS.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xchk_pagaITBIS.ReadOnly = False
        Me.xchk_pagaITBIS.Requiered = False
        Me.xchk_pagaITBIS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xchk_pagaITBIS.Size = New System.Drawing.Size(144, 16)
        Me.xchk_pagaITBIS.TabIndex = 3
        Me.xchk_pagaITBIS.Text = "Paga ITBIS"
        Me.xchk_pagaITBIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xchk_pagaITBIS.ThreeState = True
        Me.xchk_pagaITBIS.value = Nothing
        '
        'xck_vencimiento
        '
        Me.xck_vencimiento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xck_vencimiento.Checked = True
        Me.xck_vencimiento.CheckState = System.Windows.Forms.CheckState.Checked
        Me.xck_vencimiento.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivitemm.Aplicar_Vcmto"))
        Me.xck_vencimiento.EditInitialValue = Nothing
        Me.xck_vencimiento.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_vencimiento.FindInitialValue = Nothing
        Me.xck_vencimiento.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_vencimiento.IgnoreRequiered = False
        Me.xck_vencimiento.KeepEnabled = False
        Me.xck_vencimiento.Location = New System.Drawing.Point(8, 79)
        Me.xck_vencimiento.Name = "xck_vencimiento"
        Me.xck_vencimiento.NewInitialValue = "1"
        Me.xck_vencimiento.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_vencimiento.ReadOnly = False
        Me.xck_vencimiento.Requiered = False
        Me.xck_vencimiento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xck_vencimiento.Size = New System.Drawing.Size(144, 16)
        Me.xck_vencimiento.TabIndex = 4
        Me.xck_vencimiento.Text = "Vencimiento"
        Me.xck_vencimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xck_vencimiento.ThreeState = True
        Me.xck_vencimiento.value = 1
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivitemm.item_comm"))
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(8, 95)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = "1"
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = False
        Me.LibxCheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox1.Size = New System.Drawing.Size(144, 16)
        Me.LibxCheckBox1.TabIndex = 4
        Me.LibxCheckBox1.Text = "Paga Comisión"
        Me.LibxCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'TextBox4
        '
        Me.TextBox4.AcceptsReturn = True
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.sgroup_code"))
        Me.TextBox4.EditInitialValue = Nothing
        Me.TextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.FieldDescription = ""
        Me.TextBox4.FindInitialValue = Nothing
        Me.TextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.IgnoreRequiered = False
        Me.TextBox4.Location = New System.Drawing.Point(120, 112)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.NewInitialValue = Nothing
        Me.TextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.Requiered = False
        Me.TextBox4.Size = New System.Drawing.Size(56, 20)
        Me.TextBox4.StatusBarPanelDescripcion = Nothing
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Text = ""
        '
        'xtxt_group_code
        '
        Me.xtxt_group_code.AcceptsReturn = True
        Me.xtxt_group_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.group_code"))
        Me.xtxt_group_code.EditInitialValue = Nothing
        Me.xtxt_group_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_group_code.FieldDescription = ""
        Me.xtxt_group_code.FindInitialValue = Nothing
        Me.xtxt_group_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_group_code.IgnoreRequiered = False
        Me.xtxt_group_code.Location = New System.Drawing.Point(120, 88)
        Me.xtxt_group_code.Name = "xtxt_group_code"
        Me.xtxt_group_code.NewInitialValue = Nothing
        Me.xtxt_group_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_group_code.Requiered = False
        Me.xtxt_group_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_group_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_group_code.TabIndex = 3
        Me.xtxt_group_code.Text = ""
        '
        'xlk_purch_unit
        '
        Me.xlk_purch_unit.AlternateFieldSearch = Nothing
        Me.xlk_purch_unit.BeginCheck = False
        Me.xlk_purch_unit.CheckText = Nothing
        Me.xlk_purch_unit.ComboMode = False
        Me.xlk_purch_unit.DataMember = Nothing
        Me.xlk_purch_unit.DataSource = Me.LibXConnector1
        Me.xlk_purch_unit.DestParameters = New String() {"purch_unit=unit_code", "unit_purch=unit_name"}
        Me.xlk_purch_unit.FilterField = "unit_name"
        Me.xlk_purch_unit.IgnoreFindInBrowseMode = False
        Me.xlk_purch_unit.isCanceled = False
        Me.xlk_purch_unit.Location = New System.Drawing.Point(480, 184)
        Me.xlk_purch_unit.LookCaption = "Unidades de Compras"
        Me.xlk_purch_unit.Name = "xlk_purch_unit"
        Me.xlk_purch_unit.PopupSize = New System.Drawing.Size(400, 300)
        Me.xlk_purch_unit.ShowFilter = True
        Me.xlk_purch_unit.ShowMessageNotFound = False
        Me.xlk_purch_unit.ShowWarning = False
        Me.xlk_purch_unit.Size = New System.Drawing.Size(16, 20)
        Me.xlk_purch_unit.SizesColumns = Nothing
        Me.xlk_purch_unit.SizesColumnsTab = Nothing
        Me.xlk_purch_unit.SqlString = Nothing
        Me.xlk_purch_unit.SQLTab = Nothing
        Me.xlk_purch_unit.SrcParameters = New String() {"purch_unit=unit_code"}
        Me.xlk_purch_unit.TabIndex = 17
        Me.xlk_purch_unit.TableName = "ivunitm"
        Me.xlk_purch_unit.TabStop = False
        Me.xlk_purch_unit.UseCopyConnection = False
        Me.xlk_purch_unit.UseRowRetrieveEvents = False
        Me.xlk_purch_unit.UseTab = False
        Me.xlk_purch_unit.VisParameters = New String() {"Código=unit_code", "Descripción=unit_name", "Factor=factor"}
        Me.xlk_purch_unit.WhereCondition = Nothing
        Me.xlk_purch_unit.WhereParameters = Nothing
        '
        'lkp_unit_code
        '
        Me.lkp_unit_code.AlternateFieldSearch = Nothing
        Me.lkp_unit_code.BeginCheck = False
        Me.lkp_unit_code.CheckText = Nothing
        Me.lkp_unit_code.ComboMode = False
        Me.lkp_unit_code.DataMember = Nothing
        Me.lkp_unit_code.DataSource = Me.LibXConnector1
        Me.lkp_unit_code.DestParameters = New String() {"unit_code=unit_code", "unit_name=unit_name"}
        Me.lkp_unit_code.FilterField = "unit_name"
        Me.lkp_unit_code.IgnoreFindInBrowseMode = False
        Me.lkp_unit_code.isCanceled = False
        Me.lkp_unit_code.Location = New System.Drawing.Point(480, 208)
        Me.lkp_unit_code.LookCaption = "Unidades de Compra"
        Me.lkp_unit_code.Name = "lkp_unit_code"
        Me.lkp_unit_code.PopupSize = New System.Drawing.Size(400, 300)
        Me.lkp_unit_code.ShowFilter = True
        Me.lkp_unit_code.ShowMessageNotFound = True
        Me.lkp_unit_code.ShowWarning = False
        Me.lkp_unit_code.Size = New System.Drawing.Size(16, 20)
        Me.lkp_unit_code.SizesColumns = Nothing
        Me.lkp_unit_code.SizesColumnsTab = Nothing
        Me.lkp_unit_code.SqlString = Nothing
        Me.lkp_unit_code.SQLTab = Nothing
        Me.lkp_unit_code.SrcParameters = New String() {"unit_code=unit_code"}
        Me.lkp_unit_code.TabIndex = 16
        Me.lkp_unit_code.TableName = "ivunitm"
        Me.lkp_unit_code.TabStop = False
        Me.lkp_unit_code.UseCopyConnection = False
        Me.lkp_unit_code.UseRowRetrieveEvents = False
        Me.lkp_unit_code.UseTab = False
        Me.lkp_unit_code.VisParameters = New String() {"Código=unit_code", "Descripción=unit_name"}
        Me.lkp_unit_code.WhereCondition = Nothing
        Me.lkp_unit_code.WhereParameters = Nothing
        '
        'lkp_brand_code
        '
        Me.lkp_brand_code.AlternateFieldSearch = Nothing
        Me.lkp_brand_code.BeginCheck = False
        Me.lkp_brand_code.CheckText = Nothing
        Me.lkp_brand_code.ComboMode = False
        Me.lkp_brand_code.DataMember = Nothing
        Me.lkp_brand_code.DataSource = Me.LibXConnector1
        Me.lkp_brand_code.DestParameters = New String() {"brand_code=brand_code", "brand_name=brand_name"}
        Me.lkp_brand_code.FilterField = "brand_name"
        Me.lkp_brand_code.IgnoreFindInBrowseMode = False
        Me.lkp_brand_code.isCanceled = False
        Me.lkp_brand_code.Location = New System.Drawing.Point(480, 160)
        Me.lkp_brand_code.LookCaption = "Marcas"
        Me.lkp_brand_code.Name = "lkp_brand_code"
        Me.lkp_brand_code.PopupSize = New System.Drawing.Size(400, 300)
        Me.lkp_brand_code.ShowFilter = True
        Me.lkp_brand_code.ShowMessageNotFound = True
        Me.lkp_brand_code.ShowWarning = False
        Me.lkp_brand_code.Size = New System.Drawing.Size(16, 20)
        Me.lkp_brand_code.SizesColumns = Nothing
        Me.lkp_brand_code.SizesColumnsTab = Nothing
        Me.lkp_brand_code.SqlString = Nothing
        Me.lkp_brand_code.SQLTab = Nothing
        Me.lkp_brand_code.SrcParameters = New String() {"brand_code=brand_code"}
        Me.lkp_brand_code.TabIndex = 15
        Me.lkp_brand_code.TableName = "ivbrandm"
        Me.lkp_brand_code.TabStop = False
        Me.lkp_brand_code.UseCopyConnection = False
        Me.lkp_brand_code.UseRowRetrieveEvents = False
        Me.lkp_brand_code.UseTab = False
        Me.lkp_brand_code.VisParameters = New String() {"Código=brand_code", "Descripción=brand_name"}
        Me.lkp_brand_code.WhereCondition = Nothing
        Me.lkp_brand_code.WhereParameters = Nothing
        '
        'lkp_prov_code
        '
        Me.lkp_prov_code.AlternateFieldSearch = Nothing
        Me.lkp_prov_code.BeginCheck = False
        Me.lkp_prov_code.CheckText = Nothing
        Me.lkp_prov_code.ComboMode = False
        Me.lkp_prov_code.DataMember = Nothing
        Me.lkp_prov_code.DataSource = Me.LibXConnector1
        Me.lkp_prov_code.DestParameters = New String() {"prov_code=prov_code", "prov_name=prov_name"}
        Me.lkp_prov_code.FilterField = "prov_name"
        Me.lkp_prov_code.IgnoreFindInBrowseMode = False
        Me.lkp_prov_code.isCanceled = False
        Me.lkp_prov_code.Location = New System.Drawing.Point(480, 136)
        Me.lkp_prov_code.LookCaption = "Suplidores"
        Me.lkp_prov_code.Name = "lkp_prov_code"
        Me.lkp_prov_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkp_prov_code.ShowFilter = True
        Me.lkp_prov_code.ShowMessageNotFound = True
        Me.lkp_prov_code.ShowWarning = False
        Me.lkp_prov_code.Size = New System.Drawing.Size(16, 20)
        Me.lkp_prov_code.SizesColumns = New String() {"prov_name=350"}
        Me.lkp_prov_code.SizesColumnsTab = Nothing
        Me.lkp_prov_code.SqlString = Nothing
        Me.lkp_prov_code.SQLTab = Nothing
        Me.lkp_prov_code.SrcParameters = New String() {"prov_code=prov_code"}
        Me.lkp_prov_code.TabIndex = 14
        Me.lkp_prov_code.TableName = "cpprovm"
        Me.lkp_prov_code.TabStop = False
        Me.lkp_prov_code.UseCopyConnection = False
        Me.lkp_prov_code.UseRowRetrieveEvents = False
        Me.lkp_prov_code.UseTab = False
        Me.lkp_prov_code.VisParameters = New String() {"Código=prov_code", "Nombre=prov_name", "Contacto=contact_name"}
        Me.lkp_prov_code.WhereCondition = Nothing
        Me.lkp_prov_code.WhereParameters = Nothing
        '
        'lkp_sgroup_code
        '
        Me.lkp_sgroup_code.AlternateFieldSearch = Nothing
        Me.lkp_sgroup_code.BeginCheck = False
        Me.lkp_sgroup_code.CheckText = Nothing
        Me.lkp_sgroup_code.ComboMode = False
        Me.lkp_sgroup_code.DataMember = Nothing
        Me.lkp_sgroup_code.DataSource = Me.LibXConnector1
        Me.lkp_sgroup_code.DestParameters = New String() {"sgroup_code=sgroup_code", "sgroup_name=sgroup_name"}
        Me.lkp_sgroup_code.FilterField = "sgroup_name"
        Me.lkp_sgroup_code.IgnoreFindInBrowseMode = False
        Me.lkp_sgroup_code.isCanceled = False
        Me.lkp_sgroup_code.Location = New System.Drawing.Point(480, 112)
        Me.lkp_sgroup_code.LookCaption = "Subgrupos"
        Me.lkp_sgroup_code.Name = "lkp_sgroup_code"
        Me.lkp_sgroup_code.PopupSize = New System.Drawing.Size(400, 300)
        Me.lkp_sgroup_code.ShowFilter = True
        Me.lkp_sgroup_code.ShowMessageNotFound = True
        Me.lkp_sgroup_code.ShowWarning = False
        Me.lkp_sgroup_code.Size = New System.Drawing.Size(16, 20)
        Me.lkp_sgroup_code.SizesColumns = Nothing
        Me.lkp_sgroup_code.SizesColumnsTab = Nothing
        Me.lkp_sgroup_code.SqlString = Nothing
        Me.lkp_sgroup_code.SQLTab = Nothing
        Me.lkp_sgroup_code.SrcParameters = New String() {"sgroup_code=sgroup_code"}
        Me.lkp_sgroup_code.TabIndex = 13
        Me.lkp_sgroup_code.TableName = "ivsgroupm"
        Me.lkp_sgroup_code.TabStop = False
        Me.lkp_sgroup_code.UseCopyConnection = False
        Me.lkp_sgroup_code.UseRowRetrieveEvents = False
        Me.lkp_sgroup_code.UseTab = False
        Me.lkp_sgroup_code.VisParameters = New String() {"Código=sgroup_code", "Descripción=sgroup_name"}
        Me.lkp_sgroup_code.WhereCondition = Nothing
        Me.lkp_sgroup_code.WhereParameters = Nothing
        '
        'Lkp_group_code
        '
        Me.Lkp_group_code.AlternateFieldSearch = Nothing
        Me.Lkp_group_code.BeginCheck = False
        Me.Lkp_group_code.CheckText = Nothing
        Me.Lkp_group_code.ComboMode = False
        Me.Lkp_group_code.DataMember = ""
        Me.Lkp_group_code.DataSource = Me.LibXConnector1
        Me.Lkp_group_code.DestParameters = New String() {"group_code=group_code", "group_name=group_name"}
        Me.Lkp_group_code.FilterField = "group_name"
        Me.Lkp_group_code.IgnoreFindInBrowseMode = False
        Me.Lkp_group_code.isCanceled = False
        Me.Lkp_group_code.Location = New System.Drawing.Point(480, 88)
        Me.Lkp_group_code.LookCaption = "Grupos"
        Me.Lkp_group_code.Name = "Lkp_group_code"
        Me.Lkp_group_code.PopupSize = New System.Drawing.Size(400, 300)
        Me.Lkp_group_code.ShowFilter = True
        Me.Lkp_group_code.ShowMessageNotFound = True
        Me.Lkp_group_code.ShowWarning = False
        Me.Lkp_group_code.Size = New System.Drawing.Size(16, 20)
        Me.Lkp_group_code.SizesColumns = Nothing
        Me.Lkp_group_code.SizesColumnsTab = Nothing
        Me.Lkp_group_code.SqlString = Nothing
        Me.Lkp_group_code.SQLTab = Nothing
        Me.Lkp_group_code.SrcParameters = New String() {"group_code=group_code"}
        Me.Lkp_group_code.TabIndex = 12
        Me.Lkp_group_code.TableName = "ivgroupm"
        Me.Lkp_group_code.TabStop = False
        Me.Lkp_group_code.UseCopyConnection = False
        Me.Lkp_group_code.UseRowRetrieveEvents = False
        Me.Lkp_group_code.UseTab = False
        Me.Lkp_group_code.VisParameters = New String() {"Código=group_code", "Descripción=group_name"}
        Me.Lkp_group_code.WhereCondition = Nothing
        Me.Lkp_group_code.WhereParameters = Nothing
        '
        'xcbo_item_status
        '
        Me.xcbo_item_status.AllowDefaultSort = True
        Me.xcbo_item_status.bound = True
        Me.xcbo_item_status.currValue = Nothing
        Me.xcbo_item_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ivitemm.item_status"))
        Me.xcbo_item_status.DefaultWhereString = Nothing
        Me.xcbo_item_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_item_status.EditInitialValue = Nothing
        Me.xcbo_item_status.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_item_status.FieldDescription = ""
        Me.xcbo_item_status.FindInitialValue = Nothing
        Me.xcbo_item_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_item_status.IgnoreRequiered = False
        Me.xcbo_item_status.Items.AddRange(New Object() {"1-ACTIVO", "2-INATIVO", "3-DDESCONTINUADO"})
        Me.xcbo_item_status.Location = New System.Drawing.Point(392, 64)
        Me.xcbo_item_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_item_status.LookupKeyField = Nothing
        Me.xcbo_item_status.LookupTableName = Nothing
        Me.xcbo_item_status.Name = "xcbo_item_status"
        Me.xcbo_item_status.NewInitialValue = Nothing
        Me.xcbo_item_status.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_item_status.Requiered = False
        Me.xcbo_item_status.Required = False
        Me.xcbo_item_status.Size = New System.Drawing.Size(104, 21)
        Me.xcbo_item_status.SqlString = Nothing
        Me.xcbo_item_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_item_status.TabIndex = 11
        '
        'group_name
        '
        Me.group_name.AcceptsReturn = True
        Me.group_name.EditInitialValue = Nothing
        Me.group_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.group_name.FieldDescription = ""
        Me.group_name.FindInitialValue = Nothing
        Me.group_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.group_name.IgnoreRequiered = False
        Me.group_name.Location = New System.Drawing.Point(184, 88)
        Me.group_name.Name = "group_name"
        Me.group_name.NewInitialValue = Nothing
        Me.group_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.group_name.ReadOnly = True
        Me.group_name.Requiered = False
        Me.group_name.Size = New System.Drawing.Size(296, 20)
        Me.group_name.StatusBarPanelDescripcion = Nothing
        Me.group_name.TabIndex = 10
        Me.group_name.TabStop = False
        Me.group_name.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(51, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.TabStop = True
        Me.Label5.Text = "Subgrupo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(68, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.TabStop = True
        Me.Label4.Text = "Grupo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTXT_abreviada
        '
        Me.XTXT_abreviada.AcceptsReturn = True
        Me.XTXT_abreviada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTXT_abreviada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.abreviada"))
        Me.XTXT_abreviada.EditInitialValue = Nothing
        Me.XTXT_abreviada.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTXT_abreviada.FieldDescription = ""
        Me.XTXT_abreviada.FindInitialValue = Nothing
        Me.XTXT_abreviada.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTXT_abreviada.IgnoreRequiered = False
        Me.XTXT_abreviada.Location = New System.Drawing.Point(120, 64)
        Me.XTXT_abreviada.Name = "XTXT_abreviada"
        Me.XTXT_abreviada.NewInitialValue = Nothing
        Me.XTXT_abreviada.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTXT_abreviada.Requiered = False
        Me.XTXT_abreviada.Size = New System.Drawing.Size(216, 20)
        Me.XTXT_abreviada.StatusBarPanelDescripcion = Nothing
        Me.XTXT_abreviada.TabIndex = 2
        Me.XTXT_abreviada.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(49, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Abreviada:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(40, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(64, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'sgroup_name
        '
        Me.sgroup_name.AcceptsReturn = True
        Me.sgroup_name.EditInitialValue = Nothing
        Me.sgroup_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.sgroup_name.FieldDescription = ""
        Me.sgroup_name.FindInitialValue = Nothing
        Me.sgroup_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.sgroup_name.IgnoreRequiered = False
        Me.sgroup_name.Location = New System.Drawing.Point(184, 112)
        Me.sgroup_name.Name = "sgroup_name"
        Me.sgroup_name.NewInitialValue = Nothing
        Me.sgroup_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.sgroup_name.ReadOnly = True
        Me.sgroup_name.Requiered = False
        Me.sgroup_name.Size = New System.Drawing.Size(296, 20)
        Me.sgroup_name.StatusBarPanelDescripcion = Nothing
        Me.sgroup_name.TabIndex = 10
        Me.sgroup_name.TabStop = False
        Me.sgroup_name.Text = ""
        '
        'TextBox8
        '
        Me.TextBox8.AcceptsReturn = True
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.TextBox8.EditInitialValue = Nothing
        Me.TextBox8.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox8.FieldDescription = ""
        Me.TextBox8.FindInitialValue = Nothing
        Me.TextBox8.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox8.IgnoreRequiered = False
        Me.TextBox8.Location = New System.Drawing.Point(120, 136)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.NewInitialValue = Nothing
        Me.TextBox8.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox8.Requiered = False
        Me.TextBox8.Size = New System.Drawing.Size(56, 20)
        Me.TextBox8.StatusBarPanelDescripcion = Nothing
        Me.TextBox8.TabIndex = 5
        Me.TextBox8.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(58, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.TabStop = True
        Me.Label6.Text = "Suplidor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.prov_name.Location = New System.Drawing.Point(184, 136)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.NewInitialValue = Nothing
        Me.prov_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.ReadOnly = True
        Me.prov_name.Requiered = False
        Me.prov_name.Size = New System.Drawing.Size(296, 20)
        Me.prov_name.StatusBarPanelDescripcion = Nothing
        Me.prov_name.TabIndex = 10
        Me.prov_name.TabStop = False
        Me.prov_name.Text = ""
        '
        'brand_name
        '
        Me.brand_name.AcceptsReturn = True
        Me.brand_name.EditInitialValue = Nothing
        Me.brand_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.brand_name.FieldDescription = ""
        Me.brand_name.FindInitialValue = Nothing
        Me.brand_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.brand_name.IgnoreRequiered = False
        Me.brand_name.Location = New System.Drawing.Point(184, 160)
        Me.brand_name.Name = "brand_name"
        Me.brand_name.NewInitialValue = Nothing
        Me.brand_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.brand_name.ReadOnly = True
        Me.brand_name.Requiered = False
        Me.brand_name.Size = New System.Drawing.Size(296, 20)
        Me.brand_name.StatusBarPanelDescripcion = Nothing
        Me.brand_name.TabIndex = 10
        Me.brand_name.TabStop = False
        Me.brand_name.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(68, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.TabStop = True
        Me.Label7.Text = "Marca:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox11
        '
        Me.TextBox11.AcceptsReturn = True
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.brand_code"))
        Me.TextBox11.EditInitialValue = Nothing
        Me.TextBox11.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox11.FieldDescription = ""
        Me.TextBox11.FindInitialValue = Nothing
        Me.TextBox11.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox11.IgnoreRequiered = False
        Me.TextBox11.Location = New System.Drawing.Point(120, 160)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.NewInitialValue = Nothing
        Me.TextBox11.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox11.Requiered = False
        Me.TextBox11.Size = New System.Drawing.Size(56, 20)
        Me.TextBox11.StatusBarPanelDescripcion = Nothing
        Me.TextBox11.TabIndex = 6
        Me.TextBox11.Text = ""
        '
        'unit_name
        '
        Me.unit_name.AcceptsReturn = True
        Me.unit_name.EditInitialValue = Nothing
        Me.unit_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.unit_name.FieldDescription = ""
        Me.unit_name.FindInitialValue = Nothing
        Me.unit_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.unit_name.IgnoreRequiered = False
        Me.unit_name.Location = New System.Drawing.Point(184, 208)
        Me.unit_name.Name = "unit_name"
        Me.unit_name.NewInitialValue = Nothing
        Me.unit_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.unit_name.ReadOnly = True
        Me.unit_name.Requiered = False
        Me.unit_name.Size = New System.Drawing.Size(296, 20)
        Me.unit_name.StatusBarPanelDescripcion = Nothing
        Me.unit_name.TabIndex = 10
        Me.unit_name.TabStop = False
        Me.unit_name.Text = ""
        '
        'TextBox13
        '
        Me.TextBox13.AcceptsReturn = True
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.purch_unit"))
        Me.TextBox13.EditInitialValue = Nothing
        Me.TextBox13.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox13.FieldDescription = ""
        Me.TextBox13.FindInitialValue = Nothing
        Me.TextBox13.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox13.IgnoreRequiered = False
        Me.TextBox13.Location = New System.Drawing.Point(120, 184)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.NewInitialValue = Nothing
        Me.TextBox13.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox13.Requiered = False
        Me.TextBox13.Size = New System.Drawing.Size(56, 20)
        Me.TextBox13.StatusBarPanelDescripcion = Nothing
        Me.TextBox13.TabIndex = 7
        Me.TextBox13.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(20, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.TabStop = True
        Me.Label8.Text = "Unidad Compra:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(31, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.TabStop = True
        Me.Label9.Text = "Unidad Venta:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'unit_purch
        '
        Me.unit_purch.AcceptsReturn = True
        Me.unit_purch.EditInitialValue = Nothing
        Me.unit_purch.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.unit_purch.FieldDescription = ""
        Me.unit_purch.FindInitialValue = Nothing
        Me.unit_purch.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.unit_purch.IgnoreRequiered = False
        Me.unit_purch.Location = New System.Drawing.Point(184, 184)
        Me.unit_purch.Name = "unit_purch"
        Me.unit_purch.NewInitialValue = Nothing
        Me.unit_purch.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.unit_purch.ReadOnly = True
        Me.unit_purch.Requiered = False
        Me.unit_purch.Size = New System.Drawing.Size(296, 20)
        Me.unit_purch.StatusBarPanelDescripcion = Nothing
        Me.unit_purch.TabIndex = 10
        Me.unit_purch.TabStop = False
        Me.unit_purch.Text = ""
        '
        'TextBox15
        '
        Me.TextBox15.AcceptsReturn = True
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.unit_code"))
        Me.TextBox15.EditInitialValue = Nothing
        Me.TextBox15.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox15.FieldDescription = ""
        Me.TextBox15.FindInitialValue = Nothing
        Me.TextBox15.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox15.IgnoreRequiered = False
        Me.TextBox15.Location = New System.Drawing.Point(120, 208)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.NewInitialValue = Nothing
        Me.TextBox15.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox15.Requiered = False
        Me.TextBox15.Size = New System.Drawing.Size(56, 20)
        Me.TextBox15.StatusBarPanelDescripcion = Nothing
        Me.TextBox15.TabIndex = 8
        Me.TextBox15.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(520, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Usuario:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtUserID
        '
        Me.txtUserID.AcceptsReturn = True
        Me.txtUserID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.userid"))
        Me.txtUserID.EditInitialValue = Nothing
        Me.txtUserID.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtUserID.FieldDescription = ""
        Me.txtUserID.FindInitialValue = Nothing
        Me.txtUserID.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtUserID.IgnoreRequiered = False
        Me.txtUserID.Location = New System.Drawing.Point(576, 240)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.NewInitialValue = Nothing
        Me.txtUserID.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Requiered = False
        Me.txtUserID.Size = New System.Drawing.Size(160, 20)
        Me.txtUserID.StatusBarPanelDescripcion = Nothing
        Me.txtUserID.TabIndex = 12
        Me.txtUserID.TabStop = False
        Me.txtUserID.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(528, 264)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Creado:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDateCreated
        '
        Me.txtDateCreated.AcceptsReturn = True
        Me.txtDateCreated.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.item_created"))
        Me.txtDateCreated.EditInitialValue = Nothing
        Me.txtDateCreated.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtDateCreated.FieldDescription = ""
        Me.txtDateCreated.FindInitialValue = Nothing
        Me.txtDateCreated.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtDateCreated.IgnoreRequiered = False
        Me.txtDateCreated.Location = New System.Drawing.Point(576, 264)
        Me.txtDateCreated.Name = "txtDateCreated"
        Me.txtDateCreated.NewInitialValue = Nothing
        Me.txtDateCreated.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtDateCreated.ReadOnly = True
        Me.txtDateCreated.Requiered = False
        Me.txtDateCreated.Size = New System.Drawing.Size(160, 20)
        Me.txtDateCreated.StatusBarPanelDescripcion = Nothing
        Me.txtDateCreated.TabIndex = 13
        Me.txtDateCreated.TabStop = False
        Me.txtDateCreated.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(344, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 16)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Estatus:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnHojear
        '
        Me.btnHojear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHojear.Location = New System.Drawing.Point(488, 616)
        Me.btnHojear.Name = "btnHojear"
        Me.btnHojear.TabIndex = 14
        Me.btnHojear.Text = "Hojear"
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Almacenes"
        Me.LibXGrid1.DataMember = "ivitemv"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = True
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 360)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(944, 88)
        Me.LibXGrid1.TabIndex = 0
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = False
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XDataGridLinkColumn1, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn1, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn2, Me.lnk_datelast_sales, Me.lnk_datelast_purch, Me.DataGridTextBoxColumn6})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivitemv"
        '
        'XDataGridLinkColumn1
        '
        Me.XDataGridLinkColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XDataGridLinkColumn1.Format = ""
        Me.XDataGridLinkColumn1.FormatInfo = Nothing
        Me.XDataGridLinkColumn1.HeaderText = "Almacén"
        Me.XDataGridLinkColumn1.ImageList = Nothing
        Me.XDataGridLinkColumn1.isReadOnly = False
        Me.XDataGridLinkColumn1.MappingName = "whse_code"
        Me.XDataGridLinkColumn1.MaxLength = 32767
        Me.XDataGridLinkColumn1.TabStop = True
        Me.XDataGridLinkColumn1.UseCustomCellFormat = False
        Me.XDataGridLinkColumn1.Width = 60
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Descripción"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "whse_name"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 150
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Ubicación"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "Ubicacion"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn1.Format = "##,###,##0.00"
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Existenciai"
        Me.DataGridTextBoxColumn1.MappingName = "existencia"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 85
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.Format = "##,###,##0.00"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Costoi"
        Me.DataGridTextBoxColumn3.MappingName = "purch_cost"
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 85
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn5.Format = "##,###,##0.00"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Precioi"
        Me.DataGridTextBoxColumn5.MappingName = "price"
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 80
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = "##,###,##0.00"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Precio + ITBISi"
        Me.DataGridTextBoxColumn4.MappingName = "precioitbis"
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 80
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "%"
        Me.DataGridTextBoxColumn2.MappingName = "benef"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 50
        '
        'lnk_datelast_sales
        '
        Me.lnk_datelast_sales.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.lnk_datelast_sales.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.lnk_datelast_sales.executeFindDuringFill = True
        Me.lnk_datelast_sales.Format = "dd/MM/yyyy"
        Me.lnk_datelast_sales.FormatInfo = Nothing
        Me.lnk_datelast_sales.HeaderText = "Ult. Venta"
        Me.lnk_datelast_sales.isReadOnly = False
        Me.lnk_datelast_sales.MappingName = "datelast_sales"
        Me.lnk_datelast_sales.MaxLength = 32767
        Me.lnk_datelast_sales.ReadOnly = True
        Me.lnk_datelast_sales.TabStop = True
        Me.lnk_datelast_sales.UseCustomCellFormat = False
        Me.lnk_datelast_sales.Width = 70
        '
        'lnk_datelast_purch
        '
        Me.lnk_datelast_purch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.lnk_datelast_purch.Format = "dd/MM/yyyy"
        Me.lnk_datelast_purch.FormatInfo = Nothing
        Me.lnk_datelast_purch.HeaderText = "Ult. Compra"
        Me.lnk_datelast_purch.ImageList = Nothing
        Me.lnk_datelast_purch.isReadOnly = False
        Me.lnk_datelast_purch.MappingName = "datelast_purch"
        Me.lnk_datelast_purch.MaxLength = 32767
        Me.lnk_datelast_purch.ReadOnly = True
        Me.lnk_datelast_purch.TabStop = True
        Me.lnk_datelast_purch.UseCustomCellFormat = False
        Me.lnk_datelast_purch.Width = 70
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = "###,##0.00"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Costo Total"
        Me.DataGridTextBoxColumn6.MappingName = "total_cost"
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'btnGroup
        '
        Me.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGroup.Location = New System.Drawing.Point(88, 616)
        Me.btnGroup.Name = "btnGroup"
        Me.btnGroup.TabIndex = 5
        Me.btnGroup.Text = "Grupos"
        '
        'btnWareHouse
        '
        Me.btnWareHouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWareHouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWareHouse.Location = New System.Drawing.Point(800, 360)
        Me.btnWareHouse.Name = "btnWareHouse"
        Me.btnWareHouse.Size = New System.Drawing.Size(75, 21)
        Me.btnWareHouse.TabIndex = 3
        Me.btnWareHouse.Text = "Agregar"
        '
        'btnSGroup
        '
        Me.btnSGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSGroup.Location = New System.Drawing.Point(168, 616)
        Me.btnSGroup.Name = "btnSGroup"
        Me.btnSGroup.TabIndex = 6
        Me.btnSGroup.Text = "Subgrupos"
        '
        'btnBrand
        '
        Me.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrand.Location = New System.Drawing.Point(248, 616)
        Me.btnBrand.Name = "btnBrand"
        Me.btnBrand.TabIndex = 7
        Me.btnBrand.Text = "Marcas"
        '
        'btnUnit
        '
        Me.btnUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnit.Location = New System.Drawing.Point(308, 472)
        Me.btnUnit.Name = "btnUnit"
        Me.btnUnit.Size = New System.Drawing.Size(75, 21)
        Me.btnUnit.TabIndex = 8
        Me.btnUnit.Text = "Agregar"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(8, 616)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Almacén"
        '
        'BtnCodigoBarra
        '
        Me.BtnCodigoBarra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCodigoBarra.Location = New System.Drawing.Point(328, 616)
        Me.BtnCodigoBarra.Name = "BtnCodigoBarra"
        Me.BtnCodigoBarra.TabIndex = 9
        Me.BtnCodigoBarra.Text = "Cod. Barra"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(408, 616)
        Me.Button3.Name = "Button3"
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Suplidores"
        '
        'btnReferencia
        '
        Me.btnReferencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReferencia.Location = New System.Drawing.Point(844, 472)
        Me.btnReferencia.Name = "btnReferencia"
        Me.btnReferencia.Size = New System.Drawing.Size(75, 21)
        Me.btnReferencia.TabIndex = 11
        Me.btnReferencia.Text = "Agregar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblAjustes)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.lblVencido)
        Me.GroupBox3.Controls.Add(Me.lblDevuelto)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.lblcomprado)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.lblVendido)
        Me.GroupBox3.Location = New System.Drawing.Point(760, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 152)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estadisticas del Mes"
        '
        'lblAjustes
        '
        Me.lblAjustes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAjustes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable4, "Ajustes"))
        Me.lblAjustes.Location = New System.Drawing.Point(88, 120)
        Me.lblAjustes.Name = "lblAjustes"
        Me.lblAjustes.Size = New System.Drawing.Size(88, 20)
        Me.lblAjustes.TabIndex = 7
        Me.lblAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(17, 96)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(54, 16)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Vencidos:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(26, 120)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 16)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Ajustes:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVencido
        '
        Me.lblVencido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVencido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable4, "Vencimiento"))
        Me.lblVencido.Location = New System.Drawing.Point(88, 96)
        Me.lblVencido.Name = "lblVencido"
        Me.lblVencido.Size = New System.Drawing.Size(88, 20)
        Me.lblVencido.TabIndex = 6
        Me.lblVencido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDevuelto
        '
        Me.lblDevuelto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDevuelto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable4, "DevInv"))
        Me.lblDevuelto.Location = New System.Drawing.Point(88, 72)
        Me.lblDevuelto.Name = "lblDevuelto"
        Me.lblDevuelto.Size = New System.Drawing.Size(88, 20)
        Me.lblDevuelto.TabIndex = 3
        Me.lblDevuelto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(22, 72)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 16)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Devuelto"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcomprado
        '
        Me.lblcomprado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcomprado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable4, "Compras"))
        Me.lblcomprado.Location = New System.Drawing.Point(88, 48)
        Me.lblcomprado.Name = "lblcomprado"
        Me.lblcomprado.Size = New System.Drawing.Size(88, 20)
        Me.lblcomprado.TabIndex = 1
        Me.lblcomprado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Vendidos:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 16)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Comprados"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVendido
        '
        Me.lblVendido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVendido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable4, "Ventas"))
        Me.lblVendido.Location = New System.Drawing.Point(88, 24)
        Me.lblVendido.Name = "lblVendido"
        Me.lblVendido.Size = New System.Drawing.Size(88, 20)
        Me.lblVendido.TabIndex = 0
        Me.lblVendido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Location = New System.Drawing.Point(760, 184)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(192, 168)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Estadisticas Generales"
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable5, "Ajustes"))
        Me.Label19.Location = New System.Drawing.Point(88, 120)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 20)
        Me.Label19.TabIndex = 7
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(17, 96)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 16)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Vencidos:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(26, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 16)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Ajustes:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable5, "Vencimiento"))
        Me.Label25.Location = New System.Drawing.Point(88, 96)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 20)
        Me.Label25.TabIndex = 6
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label26.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable5, "DevInv"))
        Me.Label26.Location = New System.Drawing.Point(88, 72)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(88, 20)
        Me.Label26.TabIndex = 3
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(22, 72)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 16)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Devuelto"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable5, "Compras"))
        Me.Label28.Location = New System.Drawing.Point(88, 48)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(88, 20)
        Me.Label28.TabIndex = 1
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(16, 24)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(55, 16)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Vendidos:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(8, 48)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(63, 16)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Comprados"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label31.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable5, "ventas"))
        Me.Label31.Location = New System.Drawing.Point(88, 24)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 20)
        Me.Label31.TabIndex = 0
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnMOvimiento
        '
        Me.btnMOvimiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMOvimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMOvimiento.Location = New System.Drawing.Point(877, 360)
        Me.btnMOvimiento.Name = "btnMOvimiento"
        Me.btnMOvimiento.Size = New System.Drawing.Size(75, 21)
        Me.btnMOvimiento.TabIndex = 14
        Me.btnMOvimiento.Text = "Movimiento"
        '
        'LibXGrid2
        '
        Me.LibXGrid2.AutoAdjustLastColumn = True
        Me.LibXGrid2.AutoSearch = False
        Me.LibXGrid2.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid2.CaptionText = "Unidades"
        Me.LibXGrid2.DataMember = "ivunitd"
        Me.LibXGrid2.DataSource = Me.DataSet1
        Me.LibXGrid2.FullRowSelect = False
        Me.LibXGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid2.IsReadOnly = False
        Me.LibXGrid2.Location = New System.Drawing.Point(8, 472)
        Me.LibXGrid2.Name = "LibXGrid2"
        Me.LibXGrid2.ReadOnly = True
        Me.LibXGrid2.searchText = ""
        Me.LibXGrid2.showFooterBar = False
        Me.LibXGrid2.Size = New System.Drawing.Size(376, 128)
        Me.LibXGrid2.TabIndex = 16
        Me.LibXGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle2})
        Me.LibXGrid2.UseAutoFillLines = False
        Me.LibXGrid2.UseHandCursor = False
        '
        'XdataGridTableStyle2
        '
        Me.XdataGridTableStyle2.DataGrid = Me.LibXGrid2
        Me.XdataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11})
        Me.XdataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle2.MappingName = "ivunitd"
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Codigo"
        Me.DataGridTextBoxColumn7.MappingName = "unit_code"
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 50
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Unidad"
        Me.DataGridTextBoxColumn8.MappingName = "unit_name"
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 95
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Tipo"
        Me.DataGridTextBoxColumn9.MappingName = "tipo"
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Factor"
        Me.DataGridTextBoxColumn10.MappingName = "factor"
        Me.DataGridTextBoxColumn10.ReadOnly = True
        Me.DataGridTextBoxColumn10.Width = 50
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn11.Format = "##,##0.00"
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Costo Total."
        Me.DataGridTextBoxColumn11.MappingName = "total_cost"
        Me.DataGridTextBoxColumn11.ReadOnly = True
        Me.DataGridTextBoxColumn11.Width = 55
        '
        'LibXGrid3
        '
        Me.LibXGrid3.AutoAdjustLastColumn = True
        Me.LibXGrid3.AutoSearch = False
        Me.LibXGrid3.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid3.CaptionText = "Referencia"
        Me.LibXGrid3.DataMember = "ivreferm"
        Me.LibXGrid3.DataSource = Me.DataSet1
        Me.LibXGrid3.FullRowSelect = False
        Me.LibXGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid3.IsReadOnly = False
        Me.LibXGrid3.Location = New System.Drawing.Point(392, 472)
        Me.LibXGrid3.Name = "LibXGrid3"
        Me.LibXGrid3.ReadOnly = True
        Me.LibXGrid3.searchText = ""
        Me.LibXGrid3.showFooterBar = False
        Me.LibXGrid3.Size = New System.Drawing.Size(528, 128)
        Me.LibXGrid3.TabIndex = 17
        Me.LibXGrid3.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle3})
        Me.LibXGrid3.UseAutoFillLines = False
        Me.LibXGrid3.UseHandCursor = False
        '
        'XdataGridTableStyle3
        '
        Me.XdataGridTableStyle3.DataGrid = Me.LibXGrid3
        Me.XdataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18})
        Me.XdataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle3.MappingName = "ivreferm"
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Codigo"
        Me.DataGridTextBoxColumn12.MappingName = "refer"
        Me.DataGridTextBoxColumn12.ReadOnly = True
        Me.DataGridTextBoxColumn12.Width = 50
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Producto"
        Me.DataGridTextBoxColumn13.MappingName = "item_name"
        Me.DataGridTextBoxColumn13.ReadOnly = True
        Me.DataGridTextBoxColumn13.Width = 125
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn14.Format = "#,##0"
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Existencia."
        Me.DataGridTextBoxColumn14.MappingName = "existencia"
        Me.DataGridTextBoxColumn14.ReadOnly = True
        Me.DataGridTextBoxColumn14.Width = 50
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Unidad."
        Me.DataGridTextBoxColumn15.MappingName = "unit_code"
        Me.DataGridTextBoxColumn15.ReadOnly = True
        Me.DataGridTextBoxColumn15.Width = 50
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn16.Format = "#,##0.00"
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Costo."
        Me.DataGridTextBoxColumn16.MappingName = "purch_cost"
        Me.DataGridTextBoxColumn16.ReadOnly = True
        Me.DataGridTextBoxColumn16.Width = 50
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn17.Format = "#,##0.00"
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Precio."
        Me.DataGridTextBoxColumn17.MappingName = "price"
        Me.DataGridTextBoxColumn17.ReadOnly = True
        Me.DataGridTextBoxColumn17.Width = 50
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "Laboratorio"
        Me.DataGridTextBoxColumn18.MappingName = "brand_name"
        Me.DataGridTextBoxColumn18.ReadOnly = True
        Me.DataGridTextBoxColumn18.Width = 75
        '
        'i_ivitem01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(962, 569)
        Me.Controls.Add(Me.btnWareHouse)
        Me.Controls.Add(Me.btnMOvimiento)
        Me.Controls.Add(Me.btnReferencia)
        Me.Controls.Add(Me.btnUnit)
        Me.Controls.Add(Me.LibXGrid3)
        Me.Controls.Add(Me.LibXGrid2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnCodigoBarra)
        Me.Controls.Add(Me.btnGroup)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.btnSGroup)
        Me.Controls.Add(Me.btnBrand)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnHojear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivitem01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Mantenimiento de Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.LibXGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGroup.Click, Label4.Click
        Dim oParamProg As LibX.LibxPrgParams
        Try
            If Not Me.LibXConnector1.Parameters Is Nothing Then
                oParamProg = New LibX.LibxPrgParams
                oParamProg.AllowDelete = Me.LibXConnector1.Parameters.AllowDelete
                oParamProg.AllowEdit = Me.LibXConnector1.Parameters.AllowEdit
                oParamProg.AllowNew = Me.LibXConnector1.Parameters.AllowNew
                oParamProg.AllowQuery = Me.LibXConnector1.Parameters.AllowQuery
                oParamProg.AllowPrint = Me.LibXConnector1.Parameters.AllowPrint
                oParamProg.IsFromOther = True

                LibX.App.CurrentPrgParams = oParamProg
            End If

            LibX.LibXRunner.Run("i_ivgroup01", "INV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnWareHouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWareHouse.Click
        ShowCosto(LibXConnector1.State)
    End Sub
    Private Sub ShowCosto(ByVal pMode As LibX.LibxConnectorState)
        Try
            Dim param As New LibX.LibxPrgParams
            param.Value = txtItemCode.Text

            If Not Me.LibXConnector1.Parameters Is Nothing Then
                param.AllowDelete = Me.LibXConnector1.Parameters.AllowDelete
                param.AllowEdit = Me.LibXConnector1.Parameters.AllowEdit
                param.AllowNew = Me.LibXConnector1.Parameters.AllowNew
                param.AllowQuery = Me.LibXConnector1.Parameters.AllowQuery
                param.AllowPrint = Me.LibXConnector1.Parameters.AllowPrint
                param.IsFromOther = True
            End If

            Select Case pMode
                Case LibX.LibxConnectorState.Insert
                    param.initMode = LibX.LibxInitModes.Insert
                    param.Datos.Add("ITBIS", xchk_pagaITBIS.Checked)

                Case LibX.LibxConnectorState.Edit
                    param.initMode = LibX.LibxInitModes.Edit

                Case LibX.LibxConnectorState.Query
                    param.WhereToExecute = "ivitemd.item_code = '" & txtItemCode.Text.Trim & "' and ivitemd.whse_code = " & LibXGrid1(LibXGrid1.CurrentCell.RowNumber, 0)
                    param.initMode = LibX.LibxInitModes.Query

                Case LibX.LibxConnectorState.View
                    param.Datos.Add("ITBIS", xchk_pagaITBIS.Checked)
                    If DataSet1.Tables("ivitemv").Rows.Count > 0 Then
                        param.WhereToExecute = "ivitemd.item_code = '" & txtItemCode.Text.Trim & "' and ivitemd.whse_code = " & LibXGrid1(LibXGrid1.CurrentCell.RowNumber, 0)
                    End If
                    param.initMode = LibX.LibxInitModes.none

            End Select

            LibX.App.CurrentPrgParams = param
            LibX.LibXRunner.Run("i_ivitem02", "INV", True)
            LibXConnector1.LoadDetail()

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub
    Private Sub btnSGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSGroup.Click, Label5.Click
        Dim oParamProg As LibX.LibxPrgParams
        Try
            If Not Me.LibXConnector1.Parameters Is Nothing Then
                oParamProg = New LibX.LibxPrgParams
                oParamProg.AllowDelete = Me.LibXConnector1.Parameters.AllowDelete
                oParamProg.AllowEdit = Me.LibXConnector1.Parameters.AllowEdit
                oParamProg.AllowNew = Me.LibXConnector1.Parameters.AllowNew
                oParamProg.AllowQuery = Me.LibXConnector1.Parameters.AllowQuery
                oParamProg.AllowPrint = Me.LibXConnector1.Parameters.AllowPrint
                oParamProg.IsFromOther = True

                LibX.App.CurrentPrgParams = oParamProg
            End If

            LibX.LibXRunner.Run("i_ivsgroup01", "INV", True)
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub btnBrand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrand.Click
        Dim oParamProg As LibX.LibxPrgParams
        Try
            If Not Me.LibXConnector1.Parameters Is Nothing Then
                oParamProg = New LibX.LibxPrgParams
                oParamProg.AllowDelete = Me.LibXConnector1.Parameters.AllowDelete
                oParamProg.AllowEdit = Me.LibXConnector1.Parameters.AllowEdit
                oParamProg.AllowNew = Me.LibXConnector1.Parameters.AllowNew
                oParamProg.AllowQuery = Me.LibXConnector1.Parameters.AllowQuery
                oParamProg.AllowPrint = Me.LibXConnector1.Parameters.AllowPrint
                oParamProg.IsFromOther = True

                LibX.App.CurrentPrgParams = oParamProg
            End If

            LibX.LibXRunner.Run("i_ivbrand01", "INV", True)
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub btnUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnit.Click, Label8.Click, Label9.Click
        Dim oParametro As LibX.LibxPrgParams
        Try
            oParametro = New LibX.LibxPrgParams
            oParametro.WhereToExecute = "ivitemm.item_code = '" & Me.txtItemCode.Text.Trim & "'"

            If Not Me.LibXConnector1.Parameters Is Nothing Then
                oParametro.AllowEdit = Me.LibXConnector1.Parameters.AllowEdit
                oParametro.AllowQuery = Me.LibXConnector1.Parameters.AllowQuery
                oParametro.AllowPrint = Me.LibXConnector1.Parameters.AllowPrint
                oParametro.IsFromOther = True
            End If

            oParametro.AllowDelete = False
            oParametro.AllowNew = False

            LibX.App.CurrentPrgParams = oParametro

            LibX.LibXRunner.Run("i_ivunitm02", "INV", True)
        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            LibXConnector1.MoveNext()
            LibXConnector1.MovePrevious()
        End Try
    End Sub


    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Dim program As SGT.Administracion.Entidades .Permiso
        Try

            program = New SGT.Administracion.Entidades.Permiso(LibX.User.UserID, "i_ivitem01")
            LibXConnector1.AllowNew = program.Agregar
            LibXConnector1.AllowEdit = program.Editar
            LibXConnector1.AllowDelete = program.Borrar
            LibXConnector1.AllowQuery = program.Buscar
            LibXConnector1.AllowPrint = program.Imprimir

            btnWareHouse.Enabled = Not LibXConnector1.IsEditing And LibXConnector1.HasRecords = True
            btnUnit.Enabled = Not LibXConnector1.IsEditing And LibXConnector1.HasRecords = True
            BtnCodigoBarra.Enabled = Not LibXConnector1.IsEditing And LibXConnector1.HasRecords = True
            btnReferencia.Enabled = Not LibXConnector1.IsEditing And LibXConnector1.HasRecords = True
            btnTransf.Enabled = Not LibXConnector1.IsEditing And LibXConnector1.HasRecords = True
            btnMOvimiento.Enabled = Not LibXConnector1.IsEditing And LibXConnector1.HasRecords = True

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub XDataGridLinkColumn1_LinkeClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles XDataGridLinkColumn1.LinkeClicked
        Try
            If LibXGrid1.CurrentCell.RowNumber > -1 AndAlso Not LibX.IsNull(LibXGrid1(LibXGrid1.CurrentCell.RowNumber, 0)) Then
                Dim param As New LibX.LibxPrgParams
                param.Value = txtItemCode.Text
                param.WhereToExecute = "ivitemd.item_code = '" & txtItemCode.Text.Trim & "' and ivitemd.whse_code = " & LibXGrid1(LibXGrid1.CurrentCell.RowNumber, 0)
                param.initMode = LibX.LibxInitModes.Query
                LibX.App.CurrentPrgParams = param
                LibX.LibXRunner.Run("i_ivitem02", "INV", True)

            End If
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oParamProg As LibX.LibxPrgParams
        Try
            If Not Me.LibXConnector1.Parameters Is Nothing Then
                oParamProg = New LibX.LibxPrgParams
                oParamProg.AllowDelete = Me.LibXConnector1.Parameters.AllowDelete
                oParamProg.AllowEdit = Me.LibXConnector1.Parameters.AllowEdit
                oParamProg.AllowNew = Me.LibXConnector1.Parameters.AllowNew
                oParamProg.AllowQuery = Me.LibXConnector1.Parameters.AllowQuery
                oParamProg.AllowPrint = Me.LibXConnector1.Parameters.AllowPrint
                oParamProg.IsFromOther = True

                LibX.App.CurrentPrgParams = oParamProg
            End If

            LibX.LibXRunner.Run("i_ivwhsem01", "INV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub i_ivitem01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim WhereStmt As String

            mConf = New SGT.Inventario.Common.Configuration

            LibXGrid1.footerOperations.add("total_cost", "sum(total_cost)")
            LibXGrid1.footerOperations.add("existencia", "sum(existencia)")
            LibXGrid1.footerOperations.add("whse_code", "count(whse_code)")
            Me.DataSet1.Tables("ivitemm").Columns("item_code").AllowDBNull = True

            txtUserID.Text = LibX.User.UserID
            txtDateCreated.Text = LibX.Data.Manager.Connection.GetDate
            Transf = CType(System.Configuration.ConfigurationSettings.AppSettings.Get("LibxTransf"), Boolean)
            Me.btnTransf.Visible = Transf
            Me.btnTransf.Enabled = Transf

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Dim SelecStmt As String
        Dim LibxReport As LibX.ReportLib
        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
                '// Tomar el Connection String del config
                LibxReport = New LibX.ReportLib("INV", "r_ivitem02.rpt")

                With LibxReport
                    '// Recibir el SQL Query
                    .RetrieveSQLQuery()
                    SelecStmt = .SQLQuery
                    SelecStmt = LibX.MdlUtil.ReplaceWherePart(SelecStmt, WhereStmt)
                    .SQLQuery = SelecStmt
                    .WindowShowPrintSetupBtn = True

                    '// Ejecutar el reporte
                    .Action = 1
                End With
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            If Not e.Where Is Nothing Then
                WhereStmt = e.Where
            End If
            e.Sql = e.Sql & " order by ivitemm.item_name"
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub


    Private Sub LibXGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LibXGrid1.DoubleClick
        Try
            If LibXGrid1.CurrentRowIndex > -1 AndAlso Not LibX.IsNull(LibXGrid1(LibXGrid1.CurrentCell.RowNumber, 0)) Then
                Dim param As New LibX.LibxPrgParams

                param.Value = txtItemCode.Text
                param.WhereToExecute = "ivitemd.item_code = '" & txtItemCode.Text.Trim & "' and ivitemd.whse_code = " & LibXGrid1(LibXGrid1.CurrentCell.RowNumber, 0)
                LibX.App.CurrentPrgParams = param
                LibX.LibXRunner.Run("i_ivitem02", "INV", True)
                LibXConnector1.LoadDetail()
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If Me.xck_AsumirEmpaque.Checked = False Then
                Me.xck_AsumirEmpaque.Checked = True
            End If
            If Me.xck_imprimirEtiq.Checked = False Then
                Me.xck_imprimirEtiq.Checked = True
            End If
            If Me.xck_sugerirCompra.Checked = False Then
                Me.xck_sugerirCompra.Checked = True
            End If
            If Me.xck_vencimiento.Checked = False Then
                Me.xck_vencimiento.Checked = True
            End If

            If e.Action = LibX.LibxConnectionActions.Add Then
                xcbo_item_status.currValue = 1
            End If

            If e.AcceptedAction = LibX.LibxConnectionActions.Add And _
            e.Action = LibX.LibxConnectionActions.Accept Then
                ShowCosto(LibX.LibxConnectorState.Insert)
            End If

            If e.AcceptedAction = LibX.LibxConnectionActions.Edit And _
            e.Action = LibX.LibxConnectionActions.Accept Then
                LibXConnector1.LoadDetail()
            End If


        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow

        Dim oEntidad As Articulo
        Try

            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                oEntidad = New Articulo
                e.UpdatingArgs.Row!item_code = oEntidad.GetNextCode(e.UpdatingArgs.Row!group_code)
                txtItemCode.Text = e.UpdatingArgs.Row!item_code.ToString.Trim
            End If
            If e.UpdatingArgs.StatementType = StatementType.Update Then
                Me.txtDateupdate.Text = LibX.Data.Manager.Connection.GetDate
                e.UpdatingArgs.Row!item_update = LibX.Data.Manager.Connection.GetDate
            End If
            If Me.xck_AsumirEmpaque.Checked = False Then
                Me.xck_AsumirEmpaque.Checked = True
            End If
            If Me.xck_imprimirEtiq.Checked = False Then
                Me.xck_imprimirEtiq.Checked = True
            End If
            If Me.xck_sugerirCompra.Checked = False Then
                Me.xck_sugerirCompra.Checked = True
            End If
            If Me.xck_vencimiento.Checked = False Then
                Me.xck_vencimiento.Checked = True
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
        Finally
            oEntidad = Nothing
        End Try
    End Sub

    Private Sub InsertUnit(ByVal pitem_code As String)
        Dim XSelect As New LibX.Data.XSelecStmt("ivunitd")
        Dim XInsert As New LibX.Data.XInsertStmt("ivunitd")
        Dim XDelete As New LibX.Data.XDeleteStmt("ivunitd")
        Dim oNewRow As DataRow
        Dim sUnit As String
        Dim nn As Integer

        XSelect.Parameters.Add("item_code", pitem_code)
        XSelect.Parameters.Add("unit_code", "")

        XInsert.Parameters.Add("item_code", pitem_code)
        XInsert.Parameters.Add("unit_code", "")
        XInsert.Parameters.Add("unit_type", -1)
        XInsert.Parameters.Add("factor", -1)

        For Each oRow As DataRow In DataSet1.Tables("ivunitd").Rows
            XSelect.Parameters("item_code").Value = pitem_code
            XSelect.Parameters("unit_code").Value = oRow!unit_code

            oNewRow = XSelect.GetDataRow

            '''If TextBox15.Text <> oRow!unit_code And TextBox13.Text <> oRow!unit_code Then
            '''    XDelete.Fields("item_code") = pitem_code
            '''    XDelete.Fields("unit_code") = oRow!unit_code
            '''    XDelete.Execute()
            '''    Old_unitCode = oRow!unit_code
            '''End If
            '''If TextBox15.Text = oRow!unit_code And Old_unitCode = "" Then
            '''    XDelete.Fields("item_code") = pitem_code
            '''    XDelete.Fields("factor") = 1
            '''    XDelete.Execute()
            '''End If

            If oNewRow Is Nothing Then
                If TextBox15.Text = oRow!unit_code Then
                    XInsert.Parameters("item_code").Value = pitem_code
                    XInsert.Parameters("unit_code").Value = oRow!unit_code
                    XInsert.Parameters("unit_type").Value = oRow!unit_type
                    XInsert.Parameters("factor").Value = oRow!factor '// ASIGNAR FACTOR 

                    XInsert.Execute()
                Else
                    If TextBox13.Text <> TextBox15.Text Then
                        XInsert.Parameters("item_code").Value = pitem_code
                        XInsert.Parameters("unit_code").Value = oRow!unit_code
                        XInsert.Parameters("unit_type").Value = oRow!unit_type
                        XInsert.Parameters("factor").Value = oRow!factor '// ASIGNAR FACTOR 

                        XInsert.Execute()
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCodigoBarra.Click
        Dim oParametro As LibX.LibxPrgParams
        Try
            oParametro = New LibX.LibxPrgParams

            If Not Me.LibXConnector1.Parameters Is Nothing Then
                oParametro.AllowEdit = Me.LibXConnector1.Parameters.AllowEdit
                oParametro.AllowQuery = Me.LibXConnector1.Parameters.AllowQuery
                oParametro.AllowPrint = False
                oParametro.AllowDelete = Me.LibXConnector1.Parameters.AllowDelete
                oParametro.AllowNew = False

                oParametro.IsFromOther = True
            End If

            With oParametro
                .IsFromOther = True
                .initMode = LibX.LibxInitModes.Insert
                .AllowNew = False
                .AllowDelete = False
                .Value = Me.txtItemCode.Text
                .WhereToExecute = " ivitemm.item_code = '" & Me.txtItemCode.Text.Trim & "'"
            End With

            LibX.App.CurrentPrgParams = oParametro
            LibX.LibXRunner.Run("i_ivcobm03", "INV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click, Label6.Click
        Dim oParamProg As LibX.LibxPrgParams
        Try
            If Not Me.LibXConnector1.Parameters Is Nothing Then
                oParamProg = New LibX.LibxPrgParams
                oParamProg.AllowDelete = Me.LibXConnector1.Parameters.AllowDelete
                oParamProg.AllowEdit = Me.LibXConnector1.Parameters.AllowEdit
                oParamProg.AllowNew = Me.LibXConnector1.Parameters.AllowNew
                oParamProg.AllowQuery = Me.LibXConnector1.Parameters.AllowQuery
                oParamProg.AllowPrint = Me.LibXConnector1.Parameters.AllowPrint
                oParamProg.IsFromOther = True

                LibX.App.CurrentPrgParams = oParamProg
            End If

            LibX.LibXRunner.Run("i_cpprovm01", "CXP", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    'Beltran

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReferencia.Click
        Dim oParametro As LibX.LibxPrgParams
        Try
            oParametro = New LibX.LibxPrgParams
            If Not Me.LibXConnector1.Parameters Is Nothing Then
                oParametro.AllowEdit = Me.LibXConnector1.Parameters.AllowEdit
                oParametro.AllowQuery = Me.LibXConnector1.Parameters.AllowQuery
                oParametro.AllowPrint = Me.LibXConnector1.Parameters.AllowPrint
                oParametro.AllowDelete = Me.LibXConnector1.Parameters.AllowDelete
                oParametro.AllowNew = Me.LibXConnector1.Parameters.AllowNew
            End If

            With oParametro
                .IsFromOther = True
                .initMode = LibX.LibxInitModes.Edit
                .AllowNew = False
                .AllowDelete = True
                .Value = Me.txtItemCode.Text
                .WhereToExecute = " ivitemm.item_code = '" & Me.txtItemCode.Text.Trim & "'"
            End With

            LibX.App.CurrentPrgParams = oParametro
            LibX.LibXRunner.Run("i_ivreferm02", "INV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_InsertedRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedRow
        Dim oParam As Entidades.Articulo.ParametrosAplicarItbis
        Dim oProducto As Entidades.Articulo
        Try
            InsertUnit(txtItemCode.Text)

            If e.UpdatingArgs.StatementType = StatementType.Update Then
                Me.txtDateupdate.Text = LibX.Data.Manager.Connection.GetDate
                e.UpdatingArgs.Row!item_update = LibX.Data.Manager.Connection.GetDate
                oParam = New Entidades.Articulo.ParametrosAplicarItbis
                oProducto = New Entidades.Articulo

                With oParam
                    .Producto = e.UpdatingArgs.Row!item_code
                    .PagaITBISUNO = Val(e.UpdatingArgs.Row!Taxable.ToString.Trim)
                    .PagaITBISDOS = Val(e.UpdatingArgs.Row!Taxable.ToString.Trim)
                End With

                oProducto.AplicarITBIS(oParam)

            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        Finally
            oParam = Nothing
            oProducto = Nothing
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Me.xck_AsumirEmpaque.Checked = True
        Me.xck_imprimirEtiq.Checked = True
        Me.xck_sugerirCompra.Checked = True
        Me.xck_vencimiento.Checked = True

        If Not LibX.User.UserID Is Nothing Then
            Me.txtUserID.Text = LibX.User.UserID.ToString.Trim
        End If

        Me.txtDateCreated.Text = LibX.Data.Manager.Connection.GetDate

        DataSet1.Tables("ivunitd").Rows.Clear()

        txtItemCode.Focus()
    End Sub

    Private Sub LibXLookup6_AfterSetValues(ByVal sender As System.Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_purch_unit.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.IsDataEditing = True Then
                Dim oRows As DataRow() = DataSet1.Tables("ivunitd").Select("unit_code = '" & e.row!unit_code.ToString.Trim & "'")

                If oRows.Length <= 0 Then
                    Dim oRow As DataRow = DataSet1.Tables("ivunitd").NewRow
                    oRow!unit_code = e.row!unit_code
                    oRow!unit_type = 3 '// COMPRA
                    oRow!factor = e.row!factor
                    mFactorCompra = Val(e.row!factor.ToString.Trim)

                    DataSet1.Tables("ivunitd").Rows.Add(oRow)
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub lkp_unit_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkp_unit_code.AfterSetValues

        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.IsDataEditing = True Then

                Dim oRows As DataRow() = DataSet1.Tables("ivunitd").Select("unit_code = '" & e.row!unit_code.ToString.Trim & "'")
                If oRows.Length <= 0 Then
                    Dim oRow As DataRow = DataSet1.Tables("ivunitd").NewRow
                    oRow!unit_code = e.row!unit_code
                    oRow!unit_type = 3 '// COMPRA
                    oRow!factor = e.row!factor

                    DataSet1.Tables("ivunitd").Rows.Add(oRow)
                End If

            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        If e.AcceptedAction = LibX.LibxConnectionActions.Find Then
            DataSet1.Tables("ivunitd").Rows.Clear()
        End If

    End Sub

    Private Sub LibXConnector1_RowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange
        Try
            DataSet1.Tables("ivunitd").Rows.Clear()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub TextBox3_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XTXT_abreviada.GotFocus
        Try
            If LibXConnector1.IsDataEditing = True Then
                If Me.XTXT_abreviada.Text.Trim = "" And Me.TextBoxitem_name.Text.Length > 0 Then
                    Me.XTXT_abreviada.Text = Me.TextBoxitem_name.Text.Substring(0, IIf(Me.TextBoxitem_name.Text.Length > 30, 30, Me.TextBoxitem_name.Text.Length))
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub lkp_sgroup_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lkp_sgroup_code.BeforeExecuteQuery
        Try
            If LibXConnector1.IsDataEditing = True AndAlso Me.xtxt_group_code.Text.Trim <> "" Then
                e.aditionalWhere = "group_code = " & Me.xtxt_group_code.Text.Trim
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub EntviarProducto()
        Dim wsSGF1 As WSSGF1.WSSGF1

        Dim oDataSet As DataSet

        Dim oTableIvitemm As DataTable
        Dim oTableivitemd As DataTable
        Dim oTableivreferm As DataTable
        Dim oTableivcbarram As DataTable
        Dim oTableivunitd As DataTable
        Dim oRemote As DataTable

        Try

            '// ivitemm
            oTableIvitemm = LibX.Data.Manager.GetDataTable("select * from ivitemm where item_code ='" & Me.txtItemCode.Text.Trim & "'", "ivitemm")
            '// ivitemd
            oTableivitemd = LibX.Data.Manager.GetDataTable("select * from ivitemd where item_code ='" & Me.txtItemCode.Text.Trim & "' and whse_code = " & LibX.User.WhDefault, "ivitemd")
            '// ivreferm
            oTableivreferm = LibX.Data.Manager.GetDataTable("select * from ivreferm where item_code ='" & Me.txtItemCode.Text.Trim & "'", "ivreferm")
            '// ivcbarram
            oTableivcbarram = LibX.Data.Manager.GetDataTable("select * from ivcbarram where item_code ='" & Me.txtItemCode.Text.Trim & "'", "ivcbarram")
            '// ivunitd
            oTableivunitd = LibX.Data.Manager.GetDataTable("select * from ivunitd where item_code ='" & Me.txtItemCode.Text.Trim & "'", "ivunitd")


            '// DataSet
            oDataSet = New DataSet("dsSGF1")
            '// Tablas
            oDataSet.Tables.Add(oTableIvitemm)
            oDataSet.Tables.Add(oTableivitemd)
            oDataSet.Tables.Add(oTableivreferm)
            oDataSet.Tables.Add(oTableivcbarram)
            oDataSet.Tables.Add(oTableivunitd)

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
                If wsSGF1.InsertarMaestro(oDataSet) Then
                End If
            Next

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnTransf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransf.Click
        '// enviar
        Try
            Me.Cursor = Cursors.WaitCursor
            EntviarProducto()
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub btnHojear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHojear.Click
        Dim _View As New i_ivitem03
        _View.DataSource = DataSet1.Tables(0).DefaultView
        Me.SuspendLayout()

        If _View.ShowDialog() = DialogResult.OK Then
            LibXConnector1.MoveFirst()

            Do
                If LibXConnector1.CurrentDataRow!item_code = _View.SelecedCode Then
                    Exit Do
                End If

                LibXConnector1.MoveNext()
            Loop
        End If
        Me.ResumeLayout(False)
    End Sub

    Private Sub LibXConnector1_AfterLoadDetail(ByVal sender As Object, ByVal e As LibX.XbeforeLoadDetailEventArgs) Handles LibXConnector1.AfterLoadDetail

    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        If LibXConnector1.HasRecords Then
            LibXConnector1.LoadDetail(e.row, LibXConnector1.Sources.Item(2))
            LibXConnector1.LoadDetail(e.row, LibXConnector1.Sources.Item(3))
        End If

    End Sub

    Private Sub LibXConnector1_SettingDefaultqueryValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultQueryValues) Handles LibXConnector1.SettingDefaultqueryValues
        Me.xck_AsumirEmpaque.CheckState = CheckState.Indeterminate
        Me.xck_imprimirEtiq.CheckState = CheckState.Indeterminate
        Me.xck_sugerirCompra.CheckState = CheckState.Indeterminate
        Me.xck_vencimiento.CheckState = CheckState.Indeterminate
    End Sub

    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        If e.TableInfo.TableName = "ESTATISTICA_PRODUCTO" _
        Or e.TableInfo.TableName = "ESTATISTICA_PRODUCTO1" Then
            e.Handled = True
        End If

    End Sub

    Private Sub lnk_datelast_purch_LinkeClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnk_datelast_purch.LinkeClicked

    End Sub

    Private Sub LibXGrid1_columnDblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LibXGrid1.columnDblClick

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMOvimiento.Click
        Dim oParam As LibX.LibxPrgParams
        Dim WhereStmt As String
        Dim c_ivdocs As c_ivdocs01
        Try
            oParam = New LibX.LibxPrgParams
            c_ivdocs = New c_ivdocs01
            WhereStmt = "ivtranrd.item_code = '" & txtItemCode.Text & _
                        "' and ivtranrd.whse_code = " & LibXGrid1.GetValue(LibXGrid1.currentRowNum, 0).ToString

            oParam.Datos.Add("where", WhereStmt)

            LibX.App.CurrentPrgParams = oParam

            c_ivdocs.ShowDialog()

            c_ivdocs = Nothing

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGrid2_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles LibXGrid2.Navigate

    End Sub

    Private Sub LibXGrid2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LibXGrid2.DoubleClick
        btnUnit_Click(sender, e)
    End Sub

    Private Sub Label4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Label4.LinkClicked

    End Sub

    Private Sub xlk_item_sustit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xlk_item_sustit.Load

    End Sub

    Private Sub xlk_item_sustit_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_item_sustit.BeforeExecuteQuery
        If LibX.IsNull(xtxt_item_sust_name) Then
            e.aditionalWhere = "item_code <> '" & LibXConnector1.CurrentDataRow!item_code.ToString() & "'"
        End If

    End Sub
End Class

