Imports SGT.Caja.Entidades
Imports SGT.Inventario.Entidades
Imports SGT.Facturacion.Entidades
Imports SGT.PuntodeVenta.Entidades
Imports LibX
Imports System.Drawing.Printing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

'/// Usadas por el modulo Fiscal
Imports System.Data.SqlClient
Imports LibXPrintFiscal.Helpers
Imports LibXPrintFiscal.Interfaces
Imports LibXPrintFiscal.Repositorios
Imports LibxPrintFiscalSGF
Imports LibxPrintFiscalSGF.Modelos
Imports EpsonFPHostControlX
Imports AxEpsonFPHostControlX
Imports LibxPrintFiscalFactura
'/// Usadas por el modulo Fiscal

Public Class i_ptvfact01
    Inherits System.Windows.Forms.Form
    Dim oCaja As Caja
    Dim oCajera As Cajera
    Dim oCajaAbierta As CajaAbierta
    Dim mVendedor As Cajera
    Dim oProducto As SGT.Inventario.Entidades.Articulo
    Dim oDocumento As SGT.Inventario.Entidades.Documento
    Dim oSeguro As SGT.PuntodeVenta.Entidades.SegurosMedicos
    Dim oBloqueoDocumento As SGT.PuntodeVenta.Entidades.BloqueoFactua
    Dim WhDefault As Integer
    Dim ScDefault As Integer
    Dim WhDefaultNo As Integer
    Dim CajaDefault As Integer
    Dim oClienteDomicilio As ClienteDomicilio
    Dim oClienteAsegurado As ClienteAsegurado
    Dim oClienteCredito As ClienteCredito
    Dim oAutorizacion As AutorizacionSeguro
    Dim oDevolucion As Devolucion
    Dim opvDocumento As SGT.PuntodeVenta.Entidades.Documentos
    Dim mUnid As String
    Dim oParamValidar As SGT.Administracion.Entidades.Permission.ParametrosValidar
    Dim oAutorizar As SGT.Administracion.Entidades.Permission
    Dim oCalItbis As SGT.Inventario.Entidades.Articulo.ParametrosCalcularItbis
    Dim oCalcularDscto As SGT.Inventario.Entidades.Articulo.ParametrosCalculardescuentos
    Dim ofctDocumento As SGT.Facturacion.Entidades.Documento
    Dim oParametroNCF As SGT.Facturacion.Entidades.ParametrosCreditoFiscal
    Dim oParamRunning As SGT.Administracion.Entidades.Program.ParametroRunning
    Dim oProgram As SGT.Administracion.Entidades.Program
    Dim mMachine As SGT.Administracion.Entidades.Program.Autentication
    Dim mConfig As SGT.Inventario.Common.Configuration
    Dim _XtControl_serial As Integer
    Dim mCaja As Boolean = False
    Dim mLastKeyPressedInGrid As Windows.Forms.Keys
    Dim MaquinaAutorizada As String
    Dim isDomicilio As Boolean
    Dim isClienteAntes As Boolean
    Dim isVendm As Boolean
    Dim mControlado As Integer
    Dim mDsctoManual As Boolean = False
    Dim mBruto As Decimal
    Dim mPolizaAsegurado As String
    Dim mTotalSeguro As Decimal = 0
    Dim mTotalFacturadoSeguro As Decimal
    Dim vCliente As SGT.CXC.Entidades.Cliente
    Dim oParamExcede As SGT.CXC.Entidades.Cliente.ParametrosExcedeLimite
    Dim mIsedit As Boolean = False
    Dim mExit As Boolean
    Dim _Exist As Boolean = False
    Dim Aumento As Integer
    Dim mDescuentoDado As Decimal

    'Epson Library
    Private Epson = New AxEpsonFPHostControl
    Dim dbOPenn As Object


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        '// Validar la maquina
        Dim MaquinaAutorizadas() As String

        '// buscar las maquinas autorizadas como caja
        MaquinaAutorizadas = Split(System.Configuration.ConfigurationSettings.AppSettings.Get("LibxCaja"), ",")

        '// Desactivar el Login para el sistema
        LibX.Data.Manager.IsAuthenticated = True
        LibX.Data.Manager.ValidateUser = False

        '// Verificar si este equipo esta entre los equipos autorizados
        '// como caja
        For Each MaquinaAutorizada In MaquinaAutorizadas
            If MaquinaAutorizada.ToLower = System.Environment.MachineName.ToLower Then
                LibX.Data.Manager.IsAuthenticated = False
                LibX.Data.Manager.ValidateUser = True
                mCaja = True
            Else
                mCaja = False
            End If
        Next

        Me.Controls.Add(Epson)

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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents XTextBox5 As LibX.XTextBox
    Friend WithEvents XTextBox11 As LibX.XMaskEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents XTextBox12 As LibX.XMaskEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents XTextBox13 As LibX.XTextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents XTextBox14 As LibX.XTextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents XTextBox15 As LibX.XTextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents labelcaja_name As System.Windows.Forms.Label
    Friend WithEvents labelvend_name As System.Windows.Forms.Label
    Friend WithEvents xlk_caja_code As LibX.LibXLookup
    Friend WithEvents xlk_vend_code As LibX.LibXLookup
    Friend WithEvents labecaje_name As System.Windows.Forms.Label
    Friend WithEvents xlk_item_code As LibX.LibXLookup
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents xcbo_fact_status As LibX.LibXCombo
    Friend WithEvents xtxt_caje_code As LibX.XTextBox
    Friend WithEvents xtxt_caja_code As LibX.XTextBox
    Friend WithEvents xdt_fact_date As LibX.LibxDateTimePicker
    Friend WithEvents gColitem_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents gColitem_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gColQty As LibX.XEditTextBoxColumn
    Friend WithEvents gColPrecio As LibX.XEditTextBoxColumn
    Friend WithEvents gColDescuento As LibX.XEditTextBoxColumn
    Friend WithEvents gColItbis As LibX.XEditTextBoxColumn
    Friend WithEvents gColImporte As LibX.XEditTextBoxColumn
    Friend WithEvents gColUnit_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents xlk_unit_code As LibX.LibXLookup
    Friend WithEvents xtxt_fact_total As LibX.XTextBox
    Friend WithEvents btnCobrar As System.Windows.Forms.Button
    Friend WithEvents xtxt_descuento As LibX.XTextBox
    Friend WithEvents xtxt_itbis As LibX.XTextBox
    Friend WithEvents xtxt_MontoNeto As LibX.XTextBox
    Friend WithEvents lbllocalizacion As System.Windows.Forms.Label
    Friend WithEvents lblexistencia As System.Windows.Forms.Label
    Friend WithEvents gColVencimiento As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gColCosto As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents gColexistencia As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xlk_type_code As LibX.LibXLookup
    Friend WithEvents lbltype_name As System.Windows.Forms.Label
    Friend WithEvents lblitem_name As System.Windows.Forms.Label
    Friend WithEvents txtftserial_afect As LibX.XTextBox
    Friend WithEvents xchk_domicilio As LibX.LibxCheckBox
    Friend WithEvents xlk_caje_code As LibX.LibXLookup
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
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents ftfactm As System.Data.DataTable
    Friend WithEvents ftfactd As System.Data.DataTable
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents xtxt_bus_name As LibX.XTextBox
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents btnSeguro As System.Windows.Forms.Button
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents xtxt_seg_amount As LibX.XTextBox
    Friend WithEvents xdt_ftfactm As LibX.LibXDbSourceTable
    Friend WithEvents xdt_ftfactd As LibX.LibXDbSourceTable
    Friend WithEvents xdt_ftsegrm As LibX.LibXDbSourceTable
    Friend WithEvents ftsegrm As System.Data.DataTable
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn81 As System.Data.DataColumn
    Friend WithEvents DataColumn82 As System.Data.DataColumn
    Friend WithEvents btnSetHold As System.Windows.Forms.Button
    Friend WithEvents btnFreeHold As System.Windows.Forms.Button
    Friend WithEvents xtxt_vend_code As LibX.XTextBox
    Friend WithEvents btnCheque As System.Windows.Forms.Button
    Friend WithEvents btnCredito As System.Windows.Forms.Button
    Friend WithEvents btnNC As System.Windows.Forms.Button
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents DataColumn86 As System.Data.DataColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEgresos As System.Windows.Forms.Button
    Friend WithEvents lbl_AditionalInformation As System.Windows.Forms.RichTextBox
    Friend WithEvents xtxt_type_code As LibX.XTextBox
    Friend WithEvents lblVencimiento As System.Windows.Forms.Label
    Friend WithEvents lblprov_name As System.Windows.Forms.Label
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents gColprov_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gColubicacion As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataColumn88 As System.Data.DataColumn
    Friend WithEvents btnDomicilios As System.Windows.Forms.Button
    Friend WithEvents DataColumn89 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents gColaplica_dscnt As LibX.XEditTextBoxColumn
    Friend WithEvents btnTarjeta As System.Windows.Forms.Button
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents xchk_fact_impresa As LibX.LibxCheckBox
    Friend WithEvents btnIngresos As System.Windows.Forms.Button
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents gColdesc_pct As LibX.XEditTextBoxColumn
    Friend WithEvents btnOpenCash As System.Windows.Forms.Button
    Friend WithEvents btnestafetas As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents xtxfacttime As System.Windows.Forms.Label
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents xkl_cliente As LibX.LibXLookup
    Friend WithEvents gColFactor As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataColumn73 As System.Data.DataColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents xtxresponsable As LibX.XTextBox
    Friend WithEvents lblresponsable As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents DataColumn74 As System.Data.DataColumn
    Friend WithEvents DataColumn76 As System.Data.DataColumn
    Friend WithEvents DataColumn77 As System.Data.DataColumn
    Friend WithEvents DataColumn78 As System.Data.DataColumn
    Friend WithEvents xtxsusta As System.Windows.Forms.Label
    Friend WithEvents DataColumn79 As System.Data.DataColumn
    Friend WithEvents DataColumn80 As System.Data.DataColumn
    Friend WithEvents btnExistencia As System.Windows.Forms.Button
    Friend WithEvents XMaskEdit1 As LibX.XMaskEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataColumn83 As System.Data.DataColumn
    Friend WithEvents btnCancelarImpresion As System.Windows.Forms.Button
    Friend WithEvents XDataGridButtonColumn1 As LibX.XDataGridButtonColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
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
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn75 = New System.Data.DataColumn
        Me.DataColumn82 = New System.Data.DataColumn
        Me.DataColumn86 = New System.Data.DataColumn
        Me.DataColumn65 = New System.Data.DataColumn
        Me.DataColumn66 = New System.Data.DataColumn
        Me.DataColumn68 = New System.Data.DataColumn
        Me.DataColumn70 = New System.Data.DataColumn
        Me.DataColumn76 = New System.Data.DataColumn
        Me.DataColumn78 = New System.Data.DataColumn
        Me.DataColumn83 = New System.Data.DataColumn
        Me.ftfactd = New System.Data.DataTable
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn88 = New System.Data.DataColumn
        Me.DataColumn67 = New System.Data.DataColumn
        Me.DataColumn69 = New System.Data.DataColumn
        Me.DataColumn71 = New System.Data.DataColumn
        Me.DataColumn72 = New System.Data.DataColumn
        Me.DataColumn73 = New System.Data.DataColumn
        Me.DataColumn74 = New System.Data.DataColumn
        Me.DataColumn79 = New System.Data.DataColumn
        Me.ftsegrm = New System.Data.DataTable
        Me.DataColumn57 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.DataColumn61 = New System.Data.DataColumn
        Me.DataColumn62 = New System.Data.DataColumn
        Me.DataColumn63 = New System.Data.DataColumn
        Me.DataColumn64 = New System.Data.DataColumn
        Me.DataColumn81 = New System.Data.DataColumn
        Me.DataColumn89 = New System.Data.DataColumn
        Me.DataColumn77 = New System.Data.DataColumn
        Me.DataColumn80 = New System.Data.DataColumn
        Me.xdt_ftfactm = New LibX.LibXDbSourceTable
        Me.xdt_ftfactd = New LibX.LibXDbSourceTable
        Me.xdt_ftsegrm = New LibX.LibXDbSourceTable
        Me.xtxt_caja_code = New LibX.XTextBox
        Me.DataSet1 = New System.Data.DataSet
        Me.xtxt_type_code = New LibX.XTextBox
        Me.xtxt_bus_name = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.XTextBox1 = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblresponsable = New System.Windows.Forms.Label
        Me.xtxresponsable = New LibX.XTextBox
        Me.xkl_cliente = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.xtxfacttime = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.XMaskEdit1 = New LibX.XMaskEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnTarjeta = New System.Windows.Forms.Button
        Me.XTextBox11 = New LibX.XMaskEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.XTextBox12 = New LibX.XMaskEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.XTextBox13 = New LibX.XTextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.XTextBox14 = New LibX.XTextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.XTextBox15 = New LibX.XTextBox
        Me.btnCheque = New System.Windows.Forms.Button
        Me.btnCredito = New System.Windows.Forms.Button
        Me.btnNC = New System.Windows.Forms.Button
        Me.Label25 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_AditionalInformation = New System.Windows.Forms.RichTextBox
        Me.btnCustomer = New System.Windows.Forms.Button
        Me.xlk_caje_code = New LibX.LibXLookup
        Me.xlk_type_code = New LibX.LibXLookup
        Me.lbltype_name = New System.Windows.Forms.Label
        Me.xlk_vend_code = New LibX.LibXLookup
        Me.xlk_caja_code = New LibX.LibXLookup
        Me.xchk_domicilio = New LibX.LibxCheckBox
        Me.labecaje_name = New System.Windows.Forms.Label
        Me.xtxt_caje_code = New LibX.XTextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.labelcaja_name = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.labelvend_name = New System.Windows.Forms.Label
        Me.xtxt_fact_total = New LibX.XTextBox
        Me.xdt_fact_date = New LibX.LibxDateTimePicker
        Me.XTextBox5 = New LibX.XTextBox
        Me.xcbo_fact_status = New LibX.LibXCombo
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.xtxt_descuento = New LibX.XTextBox
        Me.xtxt_itbis = New LibX.XTextBox
        Me.xtxt_MontoNeto = New LibX.XTextBox
        Me.xtxt_vend_code = New LibX.XTextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtftserial_afect = New LibX.XTextBox
        Me.btnSeguro = New System.Windows.Forms.Button
        Me.xtxt_seg_amount = New LibX.XTextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.xchk_fact_impresa = New LibX.LibxCheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColitem_code = New LibX.XDataGridTextButtonColumn
        Me.xlk_item_code = New LibX.LibXLookup
        Me.gColitem_name = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColprov_name = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColubicacion = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColQty = New LibX.XEditTextBoxColumn
        Me.gColUnit_code = New LibX.XDataGridTextButtonColumn
        Me.xlk_unit_code = New LibX.LibXLookup
        Me.gColFactor = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColPrecio = New LibX.XEditTextBoxColumn
        Me.gColdesc_pct = New LibX.XEditTextBoxColumn
        Me.gColDescuento = New LibX.XEditTextBoxColumn
        Me.gColItbis = New LibX.XEditTextBoxColumn
        Me.gColVencimiento = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColexistencia = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColCosto = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColaplica_dscnt = New LibX.XEditTextBoxColumn
        Me.gColImporte = New LibX.XEditTextBoxColumn
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblitem_name = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.lbllocalizacion = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.lblexistencia = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.lblVencimiento = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.lblprov_name = New System.Windows.Forms.Label
        Me.btnCobrar = New System.Windows.Forms.Button
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.btnSetHold = New System.Windows.Forms.Button
        Me.btnFreeHold = New System.Windows.Forms.Button
        Me.btnEgresos = New System.Windows.Forms.Button
        Me.btnDomicilios = New System.Windows.Forms.Button
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.btnIngresos = New System.Windows.Forms.Button
        Me.btnExistencia = New System.Windows.Forms.Button
        Me.btnOpenCash = New System.Windows.Forms.Button
        Me.btnestafetas = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCancelarImpresion = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.xtxsusta = New System.Windows.Forms.Label
        Me.XDataGridButtonColumn1 = New LibX.XDataGridButtonColumn
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftsegrm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ftfactm
        '
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn29, Me.DataColumn56, Me.DataColumn55, Me.DataColumn75, Me.DataColumn82, Me.DataColumn86, Me.DataColumn65, Me.DataColumn66, Me.DataColumn68, Me.DataColumn70, Me.DataColumn76, Me.DataColumn78, Me.DataColumn83})
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
        Me.DataColumn3.ColumnName = "dev_type"
        Me.DataColumn3.MaxLength = 3
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "cotiz_serial"
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
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "vend_code"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "fact_number"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "fact_date"
        Me.DataColumn9.DataType = GetType(System.DateTime)
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "fact_total"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "descto"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "itbis"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "userid"
        Me.DataColumn13.MaxLength = 20
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "fact_status"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "date_created"
        Me.DataColumn15.DataType = GetType(System.DateTime)
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "type_code"
        Me.DataColumn16.MaxLength = 3
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "cust_code"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "fact_cond"
        Me.DataColumn18.DataType = GetType(System.Int16)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "bus_name"
        Me.DataColumn19.MaxLength = 100
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "fact_nota"
        Me.DataColumn20.MaxLength = 80
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "ftserial_afect"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "pay_adelant"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "phone"
        Me.DataColumn23.MaxLength = 13
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "pay_mora"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "porc_comision"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "caja_code"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "caje_code"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "fact_inddomicilio"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "init_serial"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "efectivo"
        Me.DataColumn31.DataType = GetType(System.Decimal)
        Me.DataColumn31.ReadOnly = True
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "tarjeta"
        Me.DataColumn32.DataType = GetType(System.Decimal)
        Me.DataColumn32.ReadOnly = True
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "credito"
        Me.DataColumn33.DataType = GetType(System.Decimal)
        Me.DataColumn33.ReadOnly = True
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "notacredito"
        Me.DataColumn34.DataType = GetType(System.Decimal)
        Me.DataColumn34.ReadOnly = True
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "cheque"
        Me.DataColumn35.DataType = GetType(System.Decimal)
        Me.DataColumn35.ReadOnly = True
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "reference"
        Me.DataColumn36.MaxLength = 20
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "ban_code"
        Me.DataColumn37.MaxLength = 18
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "seguro"
        Me.DataColumn38.DataType = GetType(System.Decimal)
        Me.DataColumn38.ReadOnly = True
        '
        'DataColumn29
        '
        Me.DataColumn29.AutoIncrement = True
        Me.DataColumn29.ColumnName = "afect_serial"
        Me.DataColumn29.DataType = GetType(System.Int32)
        Me.DataColumn29.ReadOnly = True
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "afect_number"
        Me.DataColumn56.DataType = GetType(System.Int32)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "address"
        Me.DataColumn55.MaxLength = 200
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "aseg_poliza"
        Me.DataColumn75.MaxLength = 20
        '
        'DataColumn82
        '
        Me.DataColumn82.ColumnName = "seg_amount"
        Me.DataColumn82.DataType = GetType(System.Decimal)
        '
        'DataColumn86
        '
        Me.DataColumn86.ColumnName = "prov_code"
        Me.DataColumn86.DataType = GetType(System.Int32)
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "fact_impresa"
        Me.DataColumn65.DataType = GetType(System.Int32)
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "fact_ncf"
        Me.DataColumn66.MaxLength = 40
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "cust_serial"
        Me.DataColumn68.DataType = GetType(System.Int32)
        '
        'DataColumn70
        '
        Me.DataColumn70.Caption = "fact_time"
        Me.DataColumn70.ColumnName = "fact_time"
        Me.DataColumn70.MaxLength = 10
        '
        'DataColumn76
        '
        Me.DataColumn76.AllowDBNull = False
        Me.DataColumn76.ColumnName = "suc_code"
        Me.DataColumn76.DataType = GetType(System.Int32)
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "fact_create"
        Me.DataColumn78.DataType = GetType(System.DateTime)
        '
        'DataColumn83
        '
        Me.DataColumn83.ColumnName = "vuelto"
        Me.DataColumn83.DataType = GetType(System.Decimal)
        Me.DataColumn83.ReadOnly = True
        '
        'ftfactd
        '
        Me.ftfactd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn58, Me.DataColumn53, Me.DataColumn54, Me.DataColumn88, Me.DataColumn67, Me.DataColumn69, Me.DataColumn71, Me.DataColumn72, Me.DataColumn73, Me.DataColumn74, Me.DataColumn79})
        Me.ftfactd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no", "line_no"}, True)})
        Me.ftfactd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn39, Me.DataColumn40}
        Me.ftfactd.TableName = "ftfactd"
        '
        'DataColumn39
        '
        Me.DataColumn39.AllowDBNull = False
        Me.DataColumn39.ColumnName = "ftserial_no"
        Me.DataColumn39.DataType = GetType(System.Int32)
        '
        'DataColumn40
        '
        Me.DataColumn40.AllowDBNull = False
        Me.DataColumn40.ColumnName = "line_no"
        Me.DataColumn40.DataType = GetType(System.Int32)
        '
        'DataColumn41
        '
        Me.DataColumn41.AllowDBNull = False
        Me.DataColumn41.ColumnName = "unit_code"
        Me.DataColumn41.MaxLength = 4
        '
        'DataColumn42
        '
        Me.DataColumn42.AllowDBNull = False
        Me.DataColumn42.ColumnName = "item_code"
        Me.DataColumn42.MaxLength = 10
        '
        'DataColumn43
        '
        Me.DataColumn43.AllowDBNull = False
        Me.DataColumn43.ColumnName = "whse_code"
        Me.DataColumn43.DataType = GetType(System.Int32)
        '
        'DataColumn44
        '
        Me.DataColumn44.AllowDBNull = False
        Me.DataColumn44.ColumnName = "qty"
        Me.DataColumn44.DataType = GetType(System.Int32)
        '
        'DataColumn45
        '
        Me.DataColumn45.AllowDBNull = False
        Me.DataColumn45.ColumnName = "price"
        Me.DataColumn45.DataType = GetType(System.Decimal)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "dscto"
        Me.DataColumn46.DataType = GetType(System.Decimal)
        '
        'DataColumn47
        '
        Me.DataColumn47.AllowDBNull = False
        Me.DataColumn47.ColumnName = "factor"
        Me.DataColumn47.DataType = GetType(System.Decimal)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "itbis"
        Me.DataColumn48.DataType = GetType(System.Decimal)
        '
        'DataColumn49
        '
        Me.DataColumn49.AllowDBNull = False
        Me.DataColumn49.ColumnName = "costo"
        Me.DataColumn49.DataType = GetType(System.Decimal)
        '
        'DataColumn50
        '
        Me.DataColumn50.AllowDBNull = False
        Me.DataColumn50.ColumnName = "item_name"
        Me.DataColumn50.MaxLength = 100
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "Importe"
        Me.DataColumn51.DataType = GetType(System.Decimal)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "existencia"
        Me.DataColumn52.DataType = GetType(System.Int32)
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "ind_cobertura"
        Me.DataColumn58.DataType = GetType(System.Int16)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "ubicacion"
        Me.DataColumn53.MaxLength = 82
        Me.DataColumn53.ReadOnly = True
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "prov_name"
        Me.DataColumn54.MaxLength = 60
        '
        'DataColumn88
        '
        Me.DataColumn88.ColumnName = "Vencimiento"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "aplica_dscnt"
        Me.DataColumn67.DataType = GetType(System.Int16)
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "disc_pct"
        Me.DataColumn69.DataType = GetType(System.Decimal)
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "prd_controlado"
        Me.DataColumn71.DataType = GetType(System.Int32)
        '
        'DataColumn72
        '
        Me.DataColumn72.Caption = "Sustancias"
        Me.DataColumn72.ColumnName = "sustancias"
        Me.DataColumn72.MaxLength = 100
        '
        'DataColumn73
        '
        Me.DataColumn73.Caption = "net_amt"
        Me.DataColumn73.ColumnName = "net_amt"
        Me.DataColumn73.DataType = GetType(System.Decimal)
        '
        'DataColumn74
        '
        Me.DataColumn74.AllowDBNull = False
        Me.DataColumn74.ColumnName = "suc_code"
        Me.DataColumn74.DataType = GetType(System.Int32)
        '
        'DataColumn79
        '
        Me.DataColumn79.ColumnName = "brand_name"
        Me.DataColumn79.MaxLength = 30
        '
        'ftsegrm
        '
        Me.ftsegrm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn57, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn81, Me.DataColumn89, Me.DataColumn77, Me.DataColumn80})
        Me.ftsegrm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no", "aseg_poliza"}, True)})
        Me.ftsegrm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn60, Me.DataColumn61}
        Me.ftsegrm.TableName = "ftsegrm"
        '
        'DataColumn57
        '
        Me.DataColumn57.AllowDBNull = False
        Me.DataColumn57.ColumnName = "cia_serial"
        Me.DataColumn57.DataType = GetType(System.Int32)
        '
        'DataColumn59
        '
        Me.DataColumn59.AllowDBNull = False
        Me.DataColumn59.ColumnName = "plan_serial"
        Me.DataColumn59.DataType = GetType(System.Int32)
        '
        'DataColumn60
        '
        Me.DataColumn60.AllowDBNull = False
        Me.DataColumn60.ColumnName = "ftserial_no"
        Me.DataColumn60.DataType = GetType(System.Int32)
        '
        'DataColumn61
        '
        Me.DataColumn61.AllowDBNull = False
        Me.DataColumn61.ColumnName = "aseg_poliza"
        Me.DataColumn61.MaxLength = 20
        '
        'DataColumn62
        '
        Me.DataColumn62.AllowDBNull = False
        Me.DataColumn62.ColumnName = "segr_autorizacion"
        Me.DataColumn62.MaxLength = 40
        '
        'DataColumn63
        '
        Me.DataColumn63.AllowDBNull = False
        Me.DataColumn63.ColumnName = "empl_amount"
        Me.DataColumn63.DataType = GetType(System.Decimal)
        '
        'DataColumn64
        '
        Me.DataColumn64.AllowDBNull = False
        Me.DataColumn64.ColumnName = "cia_amount"
        Me.DataColumn64.DataType = GetType(System.Decimal)
        '
        'DataColumn81
        '
        Me.DataColumn81.ColumnName = "total_amount"
        Me.DataColumn81.DataType = GetType(System.Decimal)
        Me.DataColumn81.ReadOnly = True
        '
        'DataColumn89
        '
        Me.DataColumn89.AllowDBNull = False
        Me.DataColumn89.ColumnName = "segr_recetaunica"
        Me.DataColumn89.DataType = GetType(System.Int32)
        '
        'DataColumn77
        '
        Me.DataColumn77.AllowDBNull = False
        Me.DataColumn77.ColumnName = "suc_code"
        Me.DataColumn77.DataType = GetType(System.Int32)
        '
        'DataColumn80
        '
        Me.DataColumn80.ColumnName = "clini_code"
        Me.DataColumn80.DataType = GetType(System.Int32)
        '
        'xdt_ftfactm
        '
        Me.xdt_ftfactm.AllowDelete = True
        Me.xdt_ftfactm.AllowEdit = True
        Me.xdt_ftfactm.AllowNew = True
        Me.xdt_ftfactm.AutoIncrementSerial = False
        Me.xdt_ftfactm.CustomDbUpdate = False
        Me.xdt_ftfactm.DeleteOrder = 0
        Me.xdt_ftfactm.FillOnQuery = True
        Me.xdt_ftfactm.FillOnRowChange = False
        Me.xdt_ftfactm.HeaderIsOnGrid = False
        Me.xdt_ftfactm.InnerJon = True
        Me.xdt_ftfactm.InsertOrder = 0
        Me.xdt_ftfactm.IsDetail = False
        Me.xdt_ftfactm.KeyFields = Nothing
        Me.xdt_ftfactm.LineColName = Nothing
        Me.xdt_ftfactm.MasterDetailRelation = Nothing
        Me.xdt_ftfactm.MasterTableName = Nothing
        Me.xdt_ftfactm.SerialColumnName = "ftserial_no"
        Me.xdt_ftfactm.Sort = Nothing
        Me.xdt_ftfactm.Source = New String() {"SELECT", "ftfactm.ftserial_no,", "ftfactm.whse_code,", "ftfactm.suc_code,", "ftfactm.dev_type,", "ftfactm.cotiz_serial,", "ftfactm.term_code,", "ftfactm.addr_code,", "ftfactm.vend_code,", "ftfactm.fact_number,", "ftfactm.fact_date,", "ftfactm.fact_create,", "ftfactm.fact_total,", "ftfactm.descto,", "ftfactm.itbis,", "ftfactm.userid,", "ftfactm.fact_status,", "ftfactm.date_created,", "ftfactm.type_code,", "ftfactm.cust_code,", "ftfactm.fact_cond,", "ftfactm.bus_name,", "ftfactm.address,", "ftfactm.fact_nota,", "ftfactm.ftserial_afect,", "ftfactm.pay_adelant,", "ftfactm.phone,", "ftfactm.pay_mora,", "ftfactm.porc_comision,", "ftfactm.caja_code,", "ftfactm.caje_code,", "ftfactm.fact_inddomicilio,", "ftfactm.fact_impresa,", "ftfactm.fact_ncf,", "cjtranrv.init_serial,", "cjtranrv.efectivo,", "cjtranrv.vuelto,", "cjtranrv.tarjeta,", "cjtranrv.credito,", "cjtranrv.notacredito,", "cjtranrv.cheque,", "cjtranrv.seguro,", "ftafectm.ftserial_no afect_serial,", "ftafectm.fact_number afect_number,", "ftsegrm.aseg_poliza,", "ftfactm.seg_amount,", "ftfactm.prov_code,", "ftfactm.cust_serial,", "ftfactm.fact_time", "from ftfactm ", "WITH (HOLDLOCK, ROWLOCK) ", "left outer join cjtranrv  ", "on  ftfactm.ftserial_no = cjtranrv.ftserial_no ", "left outer join ftfactm ftafectm", "on ftfactm.ftserial_afect = ftafectm.ftserial_no", "left outer join ftsegrm", "on ftfactm.ftserial_no = ftsegrm.ftserial_no", "  where ftfactm.type_code in('FPV','FSG','FTS','DEV')", "  and (ftfactm.ftserial_no in(select ftserial_no from ftfactd)", "   or ftfactm.ftserial_no in(select ftserial_no from ftfactd1))"}
        Me.xdt_ftfactm.TableName = "ftfactm"
        Me.xdt_ftfactm.UpdateOrder = 0
        Me.xdt_ftfactm.UseRowRetrieve = False
        '
        'xdt_ftfactd
        '
        Me.xdt_ftfactd.AllowDelete = True
        Me.xdt_ftfactd.AllowEdit = True
        Me.xdt_ftfactd.AllowNew = True
        Me.xdt_ftfactd.AutoIncrementSerial = False
        Me.xdt_ftfactd.CustomDbUpdate = False
        Me.xdt_ftfactd.DeleteOrder = 0
        Me.xdt_ftfactd.FillOnQuery = True
        Me.xdt_ftfactd.FillOnRowChange = True
        Me.xdt_ftfactd.HeaderIsOnGrid = False
        Me.xdt_ftfactd.InnerJon = True
        Me.xdt_ftfactd.InsertOrder = 0
        Me.xdt_ftfactd.IsDetail = True
        Me.xdt_ftfactd.KeyFields = Nothing
        Me.xdt_ftfactd.LineColName = "line_no"
        Me.xdt_ftfactd.MasterDetailRelation = New String() {"ftserial_no=ftserial_no", "whse_code=whse_code", "suc_code=suc_code"}
        Me.xdt_ftfactd.MasterTableName = Nothing
        Me.xdt_ftfactd.SerialColumnName = Nothing
        Me.xdt_ftfactd.Sort = Nothing
        Me.xdt_ftfactd.Source = New String() {"select ftfactd.*,", "ivitemv1.item_name,", "ivitemv1.existencia,", "ivitemv1.ubicacion,", "cpprovm.prov_name,", "ivbrandm.brand_name,", "aplica_dscnt,", "ivitemv1.disc_pct,", "ivitemv1.prd_controlado", "from ftfactd ", "inner join ivitemv1", "on ivitemv1.item_code = ftfactd.item_code", "and ivitemv1.whse_code = ftfactd.whse_code", "inner join cpprovm", "on ivitemv1.prov_code = cpprovm.prov_code", "left outer join ivbrandm ", "on ivitemv1.brand_code = ivbrandm.brand_code"}
        Me.xdt_ftfactd.TableName = "ftfactd"
        Me.xdt_ftfactd.UpdateOrder = 0
        Me.xdt_ftfactd.UseRowRetrieve = False
        '
        'xdt_ftsegrm
        '
        Me.xdt_ftsegrm.AllowDelete = True
        Me.xdt_ftsegrm.AllowEdit = True
        Me.xdt_ftsegrm.AllowNew = True
        Me.xdt_ftsegrm.AutoIncrementSerial = False
        Me.xdt_ftsegrm.CustomDbUpdate = False
        Me.xdt_ftsegrm.DeleteOrder = 0
        Me.xdt_ftsegrm.FillOnQuery = True
        Me.xdt_ftsegrm.FillOnRowChange = True
        Me.xdt_ftsegrm.HeaderIsOnGrid = False
        Me.xdt_ftsegrm.InnerJon = False
        Me.xdt_ftsegrm.InsertOrder = 0
        Me.xdt_ftsegrm.IsDetail = True
        Me.xdt_ftsegrm.KeyFields = Nothing
        Me.xdt_ftsegrm.LineColName = Nothing
        Me.xdt_ftsegrm.MasterDetailRelation = New String() {"ftserial_no=ftserial_no", "suc_code=suc_code"}
        Me.xdt_ftsegrm.MasterTableName = Nothing
        Me.xdt_ftsegrm.SerialColumnName = Nothing
        Me.xdt_ftsegrm.Sort = Nothing
        Me.xdt_ftsegrm.Source = New String() {"select ftsegrm.cia_serial, ftsegrm.plan_serial,ftsegrm.ftserial_no, segr_recetaun" & _
        "ica,", "ftsegrm.aseg_poliza, segr_autorizacion, empl_amount,cia_amount,", "(isnull(fact_total,0) - isnull(descto,0) + isnull(itbis,0)) total_amount,ftfactm." & _
        "suc_code,", "ftsegrm.clini_code from ftsegrm inner join ftfactm", "on ftsegrm.ftserial_no = ftfactm.ftserial_no and ftfactm.suc_code=ftsegrm.suc_cod" & _
        "e"}
        Me.xdt_ftsegrm.TableName = "ftsegrm"
        Me.xdt_ftsegrm.UpdateOrder = 0
        Me.xdt_ftsegrm.UseRowRetrieve = False
        '
        'xtxt_caja_code
        '
        Me.xtxt_caja_code.AcceptsReturn = True
        Me.xtxt_caja_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.caja_code"))
        Me.xtxt_caja_code.EditInitialValue = Nothing
        Me.xtxt_caja_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_caja_code.FieldDescription = "Digite el codigo de la caja"
        Me.xtxt_caja_code.FindInitialValue = Nothing
        Me.xtxt_caja_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_caja_code.IgnoreRequiered = False
        Me.xtxt_caja_code.Location = New System.Drawing.Point(96, 16)
        Me.xtxt_caja_code.Name = "xtxt_caja_code"
        Me.xtxt_caja_code.NewInitialValue = Nothing
        Me.xtxt_caja_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_caja_code.Requiered = False
        Me.xtxt_caja_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_caja_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_caja_code.TabIndex = 0
        Me.xtxt_caja_code.Text = ""
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftfactm, Me.ftfactd, Me.ftsegrm})
        '
        'xtxt_type_code
        '
        Me.xtxt_type_code.AcceptsReturn = True
        Me.xtxt_type_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_type_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.type_code"))
        Me.xtxt_type_code.EditInitialValue = Nothing
        Me.xtxt_type_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_type_code.FieldDescription = ""
        Me.xtxt_type_code.FindInitialValue = Nothing
        Me.xtxt_type_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_code.IgnoreRequiered = False
        Me.xtxt_type_code.Location = New System.Drawing.Point(96, 88)
        Me.xtxt_type_code.Name = "xtxt_type_code"
        Me.xtxt_type_code.NewInitialValue = Nothing
        Me.xtxt_type_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_code.Requiered = False
        Me.xtxt_type_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_type_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_type_code.TabIndex = 3
        Me.xtxt_type_code.Text = ""
        '
        'xtxt_bus_name
        '
        Me.xtxt_bus_name.AcceptsReturn = True
        Me.xtxt_bus_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_bus_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.bus_name"))
        Me.xtxt_bus_name.EditInitialValue = Nothing
        Me.xtxt_bus_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_bus_name.FieldDescription = ""
        Me.xtxt_bus_name.FindInitialValue = Nothing
        Me.xtxt_bus_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_bus_name.IgnoreRequiered = False
        Me.xtxt_bus_name.Location = New System.Drawing.Point(96, 112)
        Me.xtxt_bus_name.Name = "xtxt_bus_name"
        Me.xtxt_bus_name.NewInitialValue = Nothing
        Me.xtxt_bus_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_bus_name.Requiered = False
        Me.xtxt_bus_name.Size = New System.Drawing.Size(360, 20)
        Me.xtxt_bus_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_bus_name.TabIndex = 4
        Me.xtxt_bus_name.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblresponsable)
        Me.GroupBox1.Controls.Add(Me.xtxresponsable)
        Me.GroupBox1.Controls.Add(Me.xkl_cliente)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xtxfacttime)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnCustomer)
        Me.GroupBox1.Controls.Add(Me.xtxt_bus_name)
        Me.GroupBox1.Controls.Add(Me.xlk_caje_code)
        Me.GroupBox1.Controls.Add(Me.xlk_type_code)
        Me.GroupBox1.Controls.Add(Me.lbltype_name)
        Me.GroupBox1.Controls.Add(Me.xtxt_type_code)
        Me.GroupBox1.Controls.Add(Me.xlk_vend_code)
        Me.GroupBox1.Controls.Add(Me.xlk_caja_code)
        Me.GroupBox1.Controls.Add(Me.xchk_domicilio)
        Me.GroupBox1.Controls.Add(Me.labecaje_name)
        Me.GroupBox1.Controls.Add(Me.xtxt_caje_code)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.labelcaja_name)
        Me.GroupBox1.Controls.Add(Me.xtxt_caja_code)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.labelvend_name)
        Me.GroupBox1.Controls.Add(Me.xtxt_fact_total)
        Me.GroupBox1.Controls.Add(Me.xdt_fact_date)
        Me.GroupBox1.Controls.Add(Me.XTextBox5)
        Me.GroupBox1.Controls.Add(Me.xcbo_fact_status)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.xtxt_descuento)
        Me.GroupBox1.Controls.Add(Me.xtxt_itbis)
        Me.GroupBox1.Controls.Add(Me.xtxt_MontoNeto)
        Me.GroupBox1.Controls.Add(Me.xtxt_vend_code)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.txtftserial_afect)
        Me.GroupBox1.Controls.Add(Me.btnSeguro)
        Me.GroupBox1.Controls.Add(Me.xtxt_seg_amount)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xchk_fact_impresa)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(992, 272)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_ncf"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(616, 40)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(154, 22)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 64
        Me.XTextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(563, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "# NCF:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblresponsable
        '
        Me.lblresponsable.AutoSize = True
        Me.lblresponsable.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblresponsable.Location = New System.Drawing.Point(15, 134)
        Me.lblresponsable.Name = "lblresponsable"
        Me.lblresponsable.Size = New System.Drawing.Size(74, 16)
        Me.lblresponsable.TabIndex = 61
        Me.lblresponsable.Text = "Responsable:"
        Me.lblresponsable.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxresponsable
        '
        Me.xtxresponsable.AcceptsReturn = True
        Me.xtxresponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxresponsable.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.address"))
        Me.xtxresponsable.EditInitialValue = Nothing
        Me.xtxresponsable.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxresponsable.FieldDescription = ""
        Me.xtxresponsable.FindInitialValue = Nothing
        Me.xtxresponsable.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxresponsable.IgnoreRequiered = False
        Me.xtxresponsable.Location = New System.Drawing.Point(96, 132)
        Me.xtxresponsable.Name = "xtxresponsable"
        Me.xtxresponsable.NewInitialValue = Nothing
        Me.xtxresponsable.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxresponsable.Requiered = False
        Me.xtxresponsable.Size = New System.Drawing.Size(384, 20)
        Me.xtxresponsable.StatusBarPanelDescripcion = Nothing
        Me.xtxresponsable.TabIndex = 60
        Me.xtxresponsable.Text = ""
        '
        'xkl_cliente
        '
        Me.xkl_cliente.AlternateFieldSearch = Nothing
        Me.xkl_cliente.BeginCheck = False
        Me.xkl_cliente.CheckText = Nothing
        Me.xkl_cliente.ComboMode = False
        Me.xkl_cliente.DataMember = Nothing
        Me.xkl_cliente.DataSource = Me.LibXConnector1
        Me.xkl_cliente.DestParameters = New String() {"cust_code=cust_code", "xtxt_bus_name=cust_name"}
        Me.xkl_cliente.FilterField = "cust_name"
        Me.xkl_cliente.IgnoreFindInBrowseMode = False
        Me.xkl_cliente.isCanceled = False
        Me.xkl_cliente.Location = New System.Drawing.Point(480, 112)
        Me.xkl_cliente.LookCaption = "Clientes"
        Me.xkl_cliente.Name = "xkl_cliente"
        Me.xkl_cliente.PopupSize = New System.Drawing.Size(400, 300)
        Me.xkl_cliente.ShowFilter = True
        Me.xkl_cliente.ShowMessageNotFound = True
        Me.xkl_cliente.ShowWarning = False
        Me.xkl_cliente.Size = New System.Drawing.Size(16, 20)
        Me.xkl_cliente.SizesColumns = Nothing
        Me.xkl_cliente.SizesColumnsTab = Nothing
        Me.xkl_cliente.SqlString = Nothing
        Me.xkl_cliente.SQLTab = Nothing
        Me.xkl_cliente.SrcParameters = New String() {"cust_code=cust_code"}
        Me.xkl_cliente.TabIndex = 59
        Me.xkl_cliente.TableName = "cccustm"
        Me.xkl_cliente.TabStop = False
        Me.xkl_cliente.UseCopyConnection = False
        Me.xkl_cliente.UseRowRetrieveEvents = False
        Me.xkl_cliente.UseTab = False
        Me.xkl_cliente.Visible = False
        Me.xkl_cliente.VisParameters = New String() {"Código=cust_code", "Nombre=cust_name"}
        Me.xkl_cliente.WhereCondition = ""
        Me.xkl_cliente.WhereParameters = Nothing
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = False
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
        Me.LibXConnector1.ModuleName = "PTV"
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = "r_pvfact01.rpt"
        Me.LibXConnector1.RequeryData = True
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.xdt_ftfactm, Me.xdt_ftfactd, Me.xdt_ftsegrm})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(808, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 22)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Hora:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxfacttime
        '
        Me.xtxfacttime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xtxfacttime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_time"))
        Me.xtxfacttime.Enabled = False
        Me.xtxfacttime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxfacttime.Location = New System.Drawing.Point(864, 64)
        Me.xtxfacttime.Name = "xtxfacttime"
        Me.xtxfacttime.Size = New System.Drawing.Size(120, 23)
        Me.xtxfacttime.TabIndex = 57
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.XMaskEdit1)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.btnTarjeta)
        Me.GroupBox3.Controls.Add(Me.XTextBox11)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.XTextBox12)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.XTextBox13)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.XTextBox14)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.XTextBox15)
        Me.GroupBox3.Controls.Add(Me.btnCheque)
        Me.GroupBox3.Controls.Add(Me.btnCredito)
        Me.GroupBox3.Controls.Add(Me.btnNC)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Location = New System.Drawing.Point(784, 88)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 176)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Forma de Pago"
        '
        'XMaskEdit1
        '
        Me.XMaskEdit1.AcceptsReturn = True
        Me.XMaskEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.vuelto"))
        Me.XMaskEdit1.EditInitialValue = Nothing
        Me.XMaskEdit1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XMaskEdit1.FieldDescription = ""
        Me.XMaskEdit1.FindInitialValue = Nothing
        Me.XMaskEdit1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XMaskEdit1.ForeColor = System.Drawing.Color.Red
        Me.XMaskEdit1.IgnoreRequiered = False
        Me.XMaskEdit1.Location = New System.Drawing.Point(80, 149)
        Me.XMaskEdit1.Masked = MaskedTextBox.Mask.Decimal
        Me.XMaskEdit1.Name = "XMaskEdit1"
        Me.XMaskEdit1.NewInitialValue = Nothing
        Me.XMaskEdit1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XMaskEdit1.Requiered = False
        Me.XMaskEdit1.Size = New System.Drawing.Size(112, 23)
        Me.XMaskEdit1.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit1.TabIndex = 24
        Me.XMaskEdit1.Text = ""
        Me.XMaskEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 22)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Vuelto:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnTarjeta
        '
        Me.btnTarjeta.Enabled = False
        Me.btnTarjeta.Location = New System.Drawing.Point(168, 43)
        Me.btnTarjeta.Name = "btnTarjeta"
        Me.btnTarjeta.Size = New System.Drawing.Size(24, 20)
        Me.btnTarjeta.TabIndex = 23
        Me.btnTarjeta.Text = "..."
        '
        'XTextBox11
        '
        Me.XTextBox11.AcceptsReturn = True
        Me.XTextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.efectivo"))
        Me.XTextBox11.EditInitialValue = Nothing
        Me.XTextBox11.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox11.FieldDescription = ""
        Me.XTextBox11.FindInitialValue = Nothing
        Me.XTextBox11.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTextBox11.IgnoreRequiered = False
        Me.XTextBox11.Location = New System.Drawing.Point(80, 16)
        Me.XTextBox11.Masked = MaskedTextBox.Mask.Decimal
        Me.XTextBox11.Name = "XTextBox11"
        Me.XTextBox11.NewInitialValue = Nothing
        Me.XTextBox11.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox11.Requiered = False
        Me.XTextBox11.Size = New System.Drawing.Size(112, 23)
        Me.XTextBox11.StatusBarPanelDescripcion = Nothing
        Me.XTextBox11.TabIndex = 0
        Me.XTextBox11.Text = ""
        Me.XTextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(3, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 22)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "Efectivo:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox12
        '
        Me.XTextBox12.AcceptsReturn = True
        Me.XTextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.tarjeta"))
        Me.XTextBox12.EditInitialValue = Nothing
        Me.XTextBox12.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox12.FieldDescription = ""
        Me.XTextBox12.FindInitialValue = Nothing
        Me.XTextBox12.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTextBox12.IgnoreRequiered = False
        Me.XTextBox12.Location = New System.Drawing.Point(80, 42)
        Me.XTextBox12.Masked = MaskedTextBox.Mask.Decimal
        Me.XTextBox12.Name = "XTextBox12"
        Me.XTextBox12.NewInitialValue = Nothing
        Me.XTextBox12.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox12.Requiered = False
        Me.XTextBox12.Size = New System.Drawing.Size(88, 23)
        Me.XTextBox12.StatusBarPanelDescripcion = Nothing
        Me.XTextBox12.TabIndex = 1
        Me.XTextBox12.Text = ""
        Me.XTextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(10, 42)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 22)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "Tarjeta:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox13
        '
        Me.XTextBox13.AcceptsReturn = True
        Me.XTextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.cheque"))
        Me.XTextBox13.EditInitialValue = Nothing
        Me.XTextBox13.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox13.FieldDescription = ""
        Me.XTextBox13.FindInitialValue = Nothing
        Me.XTextBox13.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTextBox13.IgnoreRequiered = False
        Me.XTextBox13.Location = New System.Drawing.Point(80, 68)
        Me.XTextBox13.Name = "XTextBox13"
        Me.XTextBox13.NewInitialValue = Nothing
        Me.XTextBox13.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox13.Requiered = False
        Me.XTextBox13.Size = New System.Drawing.Size(88, 23)
        Me.XTextBox13.StatusBarPanelDescripcion = Nothing
        Me.XTextBox13.TabIndex = 2
        Me.XTextBox13.Text = ""
        Me.XTextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(4, 68)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 22)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Cheque:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox14
        '
        Me.XTextBox14.AcceptsReturn = True
        Me.XTextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.credito"))
        Me.XTextBox14.EditInitialValue = Nothing
        Me.XTextBox14.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox14.FieldDescription = ""
        Me.XTextBox14.FindInitialValue = Nothing
        Me.XTextBox14.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTextBox14.IgnoreRequiered = False
        Me.XTextBox14.Location = New System.Drawing.Point(80, 95)
        Me.XTextBox14.Name = "XTextBox14"
        Me.XTextBox14.NewInitialValue = Nothing
        Me.XTextBox14.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox14.Requiered = False
        Me.XTextBox14.Size = New System.Drawing.Size(88, 23)
        Me.XTextBox14.StatusBarPanelDescripcion = Nothing
        Me.XTextBox14.TabIndex = 3
        Me.XTextBox14.Text = ""
        Me.XTextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 95)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 22)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "Crédito:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox15
        '
        Me.XTextBox15.AcceptsReturn = True
        Me.XTextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.notacredito"))
        Me.XTextBox15.EditInitialValue = Nothing
        Me.XTextBox15.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox15.FieldDescription = ""
        Me.XTextBox15.FindInitialValue = Nothing
        Me.XTextBox15.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTextBox15.IgnoreRequiered = False
        Me.XTextBox15.Location = New System.Drawing.Point(80, 122)
        Me.XTextBox15.Name = "XTextBox15"
        Me.XTextBox15.NewInitialValue = Nothing
        Me.XTextBox15.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox15.Requiered = False
        Me.XTextBox15.Size = New System.Drawing.Size(88, 23)
        Me.XTextBox15.StatusBarPanelDescripcion = Nothing
        Me.XTextBox15.TabIndex = 4
        Me.XTextBox15.Text = ""
        Me.XTextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCheque
        '
        Me.btnCheque.Enabled = False
        Me.btnCheque.Location = New System.Drawing.Point(168, 71)
        Me.btnCheque.Name = "btnCheque"
        Me.btnCheque.Size = New System.Drawing.Size(24, 20)
        Me.btnCheque.TabIndex = 22
        Me.btnCheque.Text = "..."
        '
        'btnCredito
        '
        Me.btnCredito.Enabled = False
        Me.btnCredito.Location = New System.Drawing.Point(168, 98)
        Me.btnCredito.Name = "btnCredito"
        Me.btnCredito.Size = New System.Drawing.Size(24, 20)
        Me.btnCredito.TabIndex = 22
        Me.btnCredito.Text = "..."
        '
        'btnNC
        '
        Me.btnNC.Enabled = False
        Me.btnNC.Location = New System.Drawing.Point(168, 125)
        Me.btnNC.Name = "btnNC"
        Me.btnNC.Size = New System.Drawing.Size(24, 20)
        Me.btnNC.TabIndex = 22
        Me.btnNC.Text = "..."
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(5, 122)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(67, 22)
        Me.Label25.TabIndex = 19
        Me.Label25.Text = "Nota/Cr:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_AditionalInformation)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(8, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 96)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información Adicional"
        '
        'lbl_AditionalInformation
        '
        Me.lbl_AditionalInformation.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_AditionalInformation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_AditionalInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_AditionalInformation.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.lbl_AditionalInformation.ForeColor = System.Drawing.Color.Black
        Me.lbl_AditionalInformation.Location = New System.Drawing.Point(3, 16)
        Me.lbl_AditionalInformation.Name = "lbl_AditionalInformation"
        Me.lbl_AditionalInformation.ReadOnly = True
        Me.lbl_AditionalInformation.Size = New System.Drawing.Size(466, 77)
        Me.lbl_AditionalInformation.TabIndex = 0
        Me.lbl_AditionalInformation.Text = ""
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(456, 110)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(24, 20)
        Me.btnCustomer.TabIndex = 52
        Me.btnCustomer.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnCustomer, "Editar Informacion del cliente")
        '
        'xlk_caje_code
        '
        Me.xlk_caje_code.AlternateFieldSearch = Nothing
        Me.xlk_caje_code.BeginCheck = False
        Me.xlk_caje_code.CheckText = Nothing
        Me.xlk_caje_code.ComboMode = False
        Me.xlk_caje_code.DataMember = Nothing
        Me.xlk_caje_code.DataSource = Me.LibXConnector1
        Me.xlk_caje_code.DestParameters = New String() {"caje_code=vend_code", "labecaje_name=vend_name"}
        Me.xlk_caje_code.FilterField = "vend_name"
        Me.xlk_caje_code.IgnoreFindInBrowseMode = False
        Me.xlk_caje_code.isCanceled = False
        Me.xlk_caje_code.Location = New System.Drawing.Point(464, 40)
        Me.xlk_caje_code.LookCaption = "Cajeras"
        Me.xlk_caje_code.Name = "xlk_caje_code"
        Me.xlk_caje_code.PopupSize = New System.Drawing.Size(400, 300)
        Me.xlk_caje_code.ShowFilter = True
        Me.xlk_caje_code.ShowMessageNotFound = True
        Me.xlk_caje_code.ShowWarning = False
        Me.xlk_caje_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_caje_code.SizesColumns = Nothing
        Me.xlk_caje_code.SizesColumnsTab = Nothing
        Me.xlk_caje_code.SqlString = Nothing
        Me.xlk_caje_code.SQLTab = Nothing
        Me.xlk_caje_code.SrcParameters = New String() {"caje_code=vend_code"}
        Me.xlk_caje_code.TabIndex = 36
        Me.xlk_caje_code.TableName = "ftvendm"
        Me.xlk_caje_code.TabStop = False
        Me.xlk_caje_code.UseCopyConnection = False
        Me.xlk_caje_code.UseRowRetrieveEvents = False
        Me.xlk_caje_code.UseTab = False
        Me.xlk_caje_code.VisParameters = New String() {"Código=vend_code", "Nombre=vend_name"}
        Me.xlk_caje_code.WhereCondition = "vend_cargo  = 1"
        Me.xlk_caje_code.WhereParameters = Nothing
        '
        'xlk_type_code
        '
        Me.xlk_type_code.AlternateFieldSearch = Nothing
        Me.xlk_type_code.BeginCheck = False
        Me.xlk_type_code.CheckText = Nothing
        Me.xlk_type_code.ComboMode = False
        Me.xlk_type_code.DataMember = Nothing
        Me.xlk_type_code.DataSource = Me.LibXConnector1
        Me.xlk_type_code.DestParameters = New String() {"type_code=type_code", "lbltype_name=type_name"}
        Me.xlk_type_code.FilterField = "type_name"
        Me.xlk_type_code.IgnoreFindInBrowseMode = False
        Me.xlk_type_code.isCanceled = False
        Me.xlk_type_code.Location = New System.Drawing.Point(464, 88)
        Me.xlk_type_code.LookCaption = "Tipos de Documentos"
        Me.xlk_type_code.Name = "xlk_type_code"
        Me.xlk_type_code.PopupSize = New System.Drawing.Size(400, 300)
        Me.xlk_type_code.ShowFilter = True
        Me.xlk_type_code.ShowMessageNotFound = True
        Me.xlk_type_code.ShowWarning = False
        Me.xlk_type_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_type_code.SizesColumns = New String() {"type_name=250"}
        Me.xlk_type_code.SizesColumnsTab = Nothing
        Me.xlk_type_code.SqlString = New String() {"SELECT TYPE_CODE,TYPE_NAME FROM IVTYPEM", "ORDER BY display_order"}
        Me.xlk_type_code.SQLTab = Nothing
        Me.xlk_type_code.SrcParameters = New String() {"type_code=type_code"}
        Me.xlk_type_code.TabIndex = 31
        Me.xlk_type_code.TableName = "ivtypem"
        Me.xlk_type_code.TabStop = False
        Me.xlk_type_code.UseCopyConnection = False
        Me.xlk_type_code.UseRowRetrieveEvents = False
        Me.xlk_type_code.UseTab = False
        Me.xlk_type_code.VisParameters = New String() {"Documento=type_name", "Código=type_code"}
        Me.xlk_type_code.WhereCondition = "apply_pos = 1"
        Me.xlk_type_code.WhereParameters = Nothing
        '
        'lbltype_name
        '
        Me.lbltype_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltype_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltype_name.ForeColor = System.Drawing.Color.Blue
        Me.lbltype_name.Location = New System.Drawing.Point(160, 88)
        Me.lbltype_name.Name = "lbltype_name"
        Me.lbltype_name.Size = New System.Drawing.Size(304, 20)
        Me.lbltype_name.TabIndex = 30
        '
        'xlk_vend_code
        '
        Me.xlk_vend_code.AlternateFieldSearch = Nothing
        Me.xlk_vend_code.BeginCheck = False
        Me.xlk_vend_code.CheckText = Nothing
        Me.xlk_vend_code.ComboMode = False
        Me.xlk_vend_code.DataMember = Nothing
        Me.xlk_vend_code.DataSource = Me.LibXConnector1
        Me.xlk_vend_code.DestParameters = New String() {"vend_code=vend_code", "labelvend_name=vend_name"}
        Me.xlk_vend_code.FilterField = "vend_name"
        Me.xlk_vend_code.IgnoreFindInBrowseMode = False
        Me.xlk_vend_code.isCanceled = False
        Me.xlk_vend_code.Location = New System.Drawing.Point(464, 64)
        Me.xlk_vend_code.LookCaption = "Vendedores"
        Me.xlk_vend_code.Name = "xlk_vend_code"
        Me.xlk_vend_code.PopupSize = New System.Drawing.Size(400, 300)
        Me.xlk_vend_code.ShowFilter = True
        Me.xlk_vend_code.ShowMessageNotFound = True
        Me.xlk_vend_code.ShowWarning = False
        Me.xlk_vend_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_vend_code.SizesColumns = Nothing
        Me.xlk_vend_code.SizesColumnsTab = Nothing
        Me.xlk_vend_code.SqlString = Nothing
        Me.xlk_vend_code.SQLTab = Nothing
        Me.xlk_vend_code.SrcParameters = New String() {"vend_code=vend_code"}
        Me.xlk_vend_code.TabIndex = 25
        Me.xlk_vend_code.TableName = "ftvendm"
        Me.xlk_vend_code.TabStop = False
        Me.xlk_vend_code.UseCopyConnection = False
        Me.xlk_vend_code.UseRowRetrieveEvents = False
        Me.xlk_vend_code.UseTab = False
        Me.xlk_vend_code.VisParameters = New String() {"Código=vend_code", "Nombre=vend_name"}
        Me.xlk_vend_code.WhereCondition = "vend_cargo <> 3"
        Me.xlk_vend_code.WhereParameters = Nothing
        '
        'xlk_caja_code
        '
        Me.xlk_caja_code.AlternateFieldSearch = Nothing
        Me.xlk_caja_code.BeginCheck = False
        Me.xlk_caja_code.CheckText = Nothing
        Me.xlk_caja_code.ComboMode = False
        Me.xlk_caja_code.DataMember = Nothing
        Me.xlk_caja_code.DataSource = Me.LibXConnector1
        Me.xlk_caja_code.DestParameters = New String() {"caja_code=caja_code", "labelcaja_name=caja_name"}
        Me.xlk_caja_code.FilterField = "caja_name"
        Me.xlk_caja_code.IgnoreFindInBrowseMode = False
        Me.xlk_caja_code.isCanceled = False
        Me.xlk_caja_code.Location = New System.Drawing.Point(464, 16)
        Me.xlk_caja_code.LookCaption = "Listado de Cajas"
        Me.xlk_caja_code.Name = "xlk_caja_code"
        Me.xlk_caja_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_caja_code.ShowFilter = True
        Me.xlk_caja_code.ShowMessageNotFound = True
        Me.xlk_caja_code.ShowWarning = False
        Me.xlk_caja_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_caja_code.SizesColumns = Nothing
        Me.xlk_caja_code.SizesColumnsTab = Nothing
        Me.xlk_caja_code.SqlString = Nothing
        Me.xlk_caja_code.SQLTab = Nothing
        Me.xlk_caja_code.SrcParameters = New String() {"caja_code=caja_code"}
        Me.xlk_caja_code.TabIndex = 24
        Me.xlk_caja_code.TableName = "cjcajam"
        Me.xlk_caja_code.TabStop = False
        Me.xlk_caja_code.UseCopyConnection = False
        Me.xlk_caja_code.UseRowRetrieveEvents = False
        Me.xlk_caja_code.UseTab = False
        Me.xlk_caja_code.VisParameters = New String() {"Código=caja_code", "Nombre=caja_name"}
        Me.xlk_caja_code.WhereCondition = Nothing
        Me.xlk_caja_code.WhereParameters = Nothing
        '
        'xchk_domicilio
        '
        Me.xchk_domicilio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xchk_domicilio.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ftfactm.fact_inddomicilio"))
        Me.xchk_domicilio.EditInitialValue = Nothing
        Me.xchk_domicilio.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xchk_domicilio.FindInitialValue = Nothing
        Me.xchk_domicilio.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xchk_domicilio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.xchk_domicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xchk_domicilio.IgnoreRequiered = False
        Me.xchk_domicilio.KeepEnabled = False
        Me.xchk_domicilio.Location = New System.Drawing.Point(616, 68)
        Me.xchk_domicilio.Name = "xchk_domicilio"
        Me.xchk_domicilio.NewInitialValue = Nothing
        Me.xchk_domicilio.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xchk_domicilio.ReadOnly = False
        Me.xchk_domicilio.Requiered = False
        Me.xchk_domicilio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xchk_domicilio.Size = New System.Drawing.Size(95, 16)
        Me.xchk_domicilio.TabIndex = 6
        Me.xchk_domicilio.Text = "Domicilio"
        Me.xchk_domicilio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xchk_domicilio.ThreeState = True
        Me.ToolTip1.SetToolTip(Me.xchk_domicilio, "Datos del domicilio")
        Me.xchk_domicilio.value = Nothing
        '
        'labecaje_name
        '
        Me.labecaje_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labecaje_name.Location = New System.Drawing.Point(160, 40)
        Me.labecaje_name.Name = "labecaje_name"
        Me.labecaje_name.Size = New System.Drawing.Size(304, 20)
        Me.labecaje_name.TabIndex = 22
        '
        'xtxt_caje_code
        '
        Me.xtxt_caje_code.AcceptsReturn = True
        Me.xtxt_caje_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.caje_code"))
        Me.xtxt_caje_code.EditInitialValue = Nothing
        Me.xtxt_caje_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_caje_code.FieldDescription = "Digite el codigo de la cajera"
        Me.xtxt_caje_code.FindInitialValue = Nothing
        Me.xtxt_caje_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_caje_code.IgnoreRequiered = False
        Me.xtxt_caje_code.Location = New System.Drawing.Point(96, 40)
        Me.xtxt_caje_code.Name = "xtxt_caje_code"
        Me.xtxt_caje_code.NewInitialValue = Nothing
        Me.xtxt_caje_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_caje_code.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.xtxt_caje_code.Requiered = False
        Me.xtxt_caje_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_caje_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_caje_code.TabIndex = 1
        Me.xtxt_caje_code.Text = ""
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label34.Location = New System.Drawing.Point(45, 40)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(41, 16)
        Me.Label34.TabIndex = 20
        Me.Label34.Text = "Cajera:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'labelcaja_name
        '
        Me.labelcaja_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelcaja_name.Location = New System.Drawing.Point(160, 16)
        Me.labelcaja_name.Name = "labelcaja_name"
        Me.labelcaja_name.Size = New System.Drawing.Size(304, 20)
        Me.labelcaja_name.TabIndex = 19
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label32.Location = New System.Drawing.Point(55, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(31, 16)
        Me.Label32.TabIndex = 17
        Me.Label32.Text = "Caja:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'labelvend_name
        '
        Me.labelvend_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelvend_name.Location = New System.Drawing.Point(160, 64)
        Me.labelvend_name.Name = "labelvend_name"
        Me.labelvend_name.Size = New System.Drawing.Size(304, 20)
        Me.labelvend_name.TabIndex = 16
        '
        'xtxt_fact_total
        '
        Me.xtxt_fact_total.AcceptsReturn = True
        Me.xtxt_fact_total.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_total"))
        Me.xtxt_fact_total.EditInitialValue = Nothing
        Me.xtxt_fact_total.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_fact_total.FieldDescription = ""
        Me.xtxt_fact_total.FindInitialValue = Nothing
        Me.xtxt_fact_total.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_fact_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_fact_total.IgnoreRequiered = False
        Me.xtxt_fact_total.Location = New System.Drawing.Point(616, 90)
        Me.xtxt_fact_total.Name = "xtxt_fact_total"
        Me.xtxt_fact_total.NewInitialValue = Nothing
        Me.xtxt_fact_total.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_fact_total.Requiered = False
        Me.xtxt_fact_total.Size = New System.Drawing.Size(154, 27)
        Me.xtxt_fact_total.StatusBarPanelDescripcion = Nothing
        Me.xtxt_fact_total.TabIndex = 10
        Me.xtxt_fact_total.Text = ""
        Me.xtxt_fact_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xdt_fact_date
        '
        Me.xdt_fact_date.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.xdt_fact_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_fact_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.fact_date"))
        Me.xdt_fact_date.EditInitialValue = Nothing
        Me.xdt_fact_date.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdt_fact_date.FieldDescription = ""
        Me.xdt_fact_date.FindInitialValue = ""
        Me.xdt_fact_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_fact_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_fact_date.IgnoreRequiered = False
        Me.xdt_fact_date.Location = New System.Drawing.Point(864, 40)
        Me.xdt_fact_date.Name = "xdt_fact_date"
        Me.xdt_fact_date.NewInitialValue = "now"
        Me.xdt_fact_date.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdt_fact_date.Requiered = False
        Me.xdt_fact_date.Size = New System.Drawing.Size(120, 20)
        Me.xdt_fact_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_fact_date.TabIndex = 9
        '
        'XTextBox5
        '
        Me.XTextBox5.AcceptsReturn = True
        Me.XTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_number"))
        Me.XTextBox5.EditInitialValue = Nothing
        Me.XTextBox5.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox5.FieldDescription = ""
        Me.XTextBox5.FindInitialValue = Nothing
        Me.XTextBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.IgnoreRequiered = False
        Me.XTextBox5.Location = New System.Drawing.Point(616, 16)
        Me.XTextBox5.Name = "XTextBox5"
        Me.XTextBox5.NewInitialValue = Nothing
        Me.XTextBox5.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox5.Requiered = False
        Me.XTextBox5.Size = New System.Drawing.Size(154, 20)
        Me.XTextBox5.StatusBarPanelDescripcion = Nothing
        Me.XTextBox5.TabIndex = 7
        Me.XTextBox5.Text = ""
        '
        'xcbo_fact_status
        '
        Me.xcbo_fact_status.AllowDefaultSort = True
        Me.xcbo_fact_status.bound = True
        Me.xcbo_fact_status.currValue = Nothing
        Me.xcbo_fact_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.fact_status"))
        Me.xcbo_fact_status.DefaultWhereString = Nothing
        Me.xcbo_fact_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_fact_status.EditInitialValue = Nothing
        Me.xcbo_fact_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_fact_status.FieldDescription = ""
        Me.xcbo_fact_status.FindInitialValue = "1"
        Me.xcbo_fact_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_fact_status.IgnoreRequiered = False
        Me.xcbo_fact_status.Items.AddRange(New Object() {"0-Anulada", "1-Pendiente", "2-Cobrada", "3-en Espera", "4-Domicilio Pendiente"})
        Me.xcbo_fact_status.Location = New System.Drawing.Point(864, 16)
        Me.xcbo_fact_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_fact_status.LookupKeyField = Nothing
        Me.xcbo_fact_status.LookupTableName = Nothing
        Me.xcbo_fact_status.Name = "xcbo_fact_status"
        Me.xcbo_fact_status.NewInitialValue = "1"
        Me.xcbo_fact_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_fact_status.Requiered = False
        Me.xcbo_fact_status.Required = False
        Me.xcbo_fact_status.Size = New System.Drawing.Size(120, 21)
        Me.xcbo_fact_status.SqlString = Nothing
        Me.xcbo_fact_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_fact_status.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(515, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 22)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Descuento:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(791, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 22)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Estatus:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(504, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Monto Bruto:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(496, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 22)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "# Documento:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(552, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 22)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "ITBIS:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(512, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 22)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Neto Pagar:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(38, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 16)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Nombre:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_descuento
        '
        Me.xtxt_descuento.AcceptsReturn = True
        Me.xtxt_descuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.descto"))
        Me.xtxt_descuento.EditInitialValue = Nothing
        Me.xtxt_descuento.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_descuento.FieldDescription = ""
        Me.xtxt_descuento.FindInitialValue = Nothing
        Me.xtxt_descuento.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_descuento.IgnoreRequiered = False
        Me.xtxt_descuento.Location = New System.Drawing.Point(616, 121)
        Me.xtxt_descuento.Name = "xtxt_descuento"
        Me.xtxt_descuento.NewInitialValue = Nothing
        Me.xtxt_descuento.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_descuento.Requiered = False
        Me.xtxt_descuento.Size = New System.Drawing.Size(154, 27)
        Me.xtxt_descuento.StatusBarPanelDescripcion = Nothing
        Me.xtxt_descuento.TabIndex = 11
        Me.xtxt_descuento.Text = ""
        Me.xtxt_descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xtxt_itbis
        '
        Me.xtxt_itbis.AcceptsReturn = True
        Me.xtxt_itbis.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.itbis"))
        Me.xtxt_itbis.EditInitialValue = Nothing
        Me.xtxt_itbis.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_itbis.FieldDescription = ""
        Me.xtxt_itbis.FindInitialValue = Nothing
        Me.xtxt_itbis.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_itbis.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_itbis.IgnoreRequiered = False
        Me.xtxt_itbis.Location = New System.Drawing.Point(616, 152)
        Me.xtxt_itbis.Name = "xtxt_itbis"
        Me.xtxt_itbis.NewInitialValue = Nothing
        Me.xtxt_itbis.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_itbis.Requiered = False
        Me.xtxt_itbis.Size = New System.Drawing.Size(154, 27)
        Me.xtxt_itbis.StatusBarPanelDescripcion = Nothing
        Me.xtxt_itbis.TabIndex = 12
        Me.xtxt_itbis.Text = ""
        Me.xtxt_itbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xtxt_MontoNeto
        '
        Me.xtxt_MontoNeto.AcceptsReturn = True
        Me.xtxt_MontoNeto.EditInitialValue = Nothing
        Me.xtxt_MontoNeto.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_MontoNeto.FieldDescription = ""
        Me.xtxt_MontoNeto.FindInitialValue = Nothing
        Me.xtxt_MontoNeto.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_MontoNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_MontoNeto.ForeColor = System.Drawing.Color.Blue
        Me.xtxt_MontoNeto.IgnoreRequiered = False
        Me.xtxt_MontoNeto.Location = New System.Drawing.Point(616, 211)
        Me.xtxt_MontoNeto.Name = "xtxt_MontoNeto"
        Me.xtxt_MontoNeto.NewInitialValue = Nothing
        Me.xtxt_MontoNeto.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_MontoNeto.Requiered = False
        Me.xtxt_MontoNeto.Size = New System.Drawing.Size(154, 35)
        Me.xtxt_MontoNeto.StatusBarPanelDescripcion = Nothing
        Me.xtxt_MontoNeto.TabIndex = 14
        Me.xtxt_MontoNeto.TabStop = False
        Me.xtxt_MontoNeto.Text = ""
        Me.xtxt_MontoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xtxt_vend_code
        '
        Me.xtxt_vend_code.AcceptsReturn = True
        Me.xtxt_vend_code.AcceptsTab = True
        Me.xtxt_vend_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.vend_code"))
        Me.xtxt_vend_code.EditInitialValue = ""
        Me.xtxt_vend_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_vend_code.FieldDescription = ""
        Me.xtxt_vend_code.FindInitialValue = Nothing
        Me.xtxt_vend_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_vend_code.IgnoreRequiered = False
        Me.xtxt_vend_code.Location = New System.Drawing.Point(96, 64)
        Me.xtxt_vend_code.Name = "xtxt_vend_code"
        Me.xtxt_vend_code.NewInitialValue = Nothing
        Me.xtxt_vend_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_vend_code.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.xtxt_vend_code.Requiered = False
        Me.xtxt_vend_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_vend_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_vend_code.TabIndex = 2
        Me.xtxt_vend_code.Text = ""
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label29.Location = New System.Drawing.Point(30, 64)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(56, 16)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "Vendedor:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtftserial_afect
        '
        Me.txtftserial_afect.AcceptsReturn = True
        Me.txtftserial_afect.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.ftserial_afect"))
        Me.txtftserial_afect.EditInitialValue = Nothing
        Me.txtftserial_afect.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtftserial_afect.FieldDescription = ""
        Me.txtftserial_afect.FindInitialValue = Nothing
        Me.txtftserial_afect.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtftserial_afect.IgnoreRequiered = False
        Me.txtftserial_afect.Location = New System.Drawing.Point(904, 176)
        Me.txtftserial_afect.Name = "txtftserial_afect"
        Me.txtftserial_afect.NewInitialValue = Nothing
        Me.txtftserial_afect.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtftserial_afect.ReadOnly = True
        Me.txtftserial_afect.Requiered = False
        Me.txtftserial_afect.Size = New System.Drawing.Size(48, 20)
        Me.txtftserial_afect.StatusBarPanelDescripcion = Nothing
        Me.txtftserial_afect.TabIndex = 35
        Me.txtftserial_afect.TabStop = False
        Me.txtftserial_afect.Text = ""
        '
        'btnSeguro
        '
        Me.btnSeguro.Location = New System.Drawing.Point(616, 182)
        Me.btnSeguro.Name = "btnSeguro"
        Me.btnSeguro.Size = New System.Drawing.Size(24, 24)
        Me.btnSeguro.TabIndex = 22
        Me.btnSeguro.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnSeguro, "Informacion de autorizacion de seguros")
        '
        'xtxt_seg_amount
        '
        Me.xtxt_seg_amount.AcceptsReturn = True
        Me.xtxt_seg_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.seg_amount"))
        Me.xtxt_seg_amount.EditInitialValue = Nothing
        Me.xtxt_seg_amount.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_seg_amount.FieldDescription = ""
        Me.xtxt_seg_amount.FindInitialValue = Nothing
        Me.xtxt_seg_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_seg_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_seg_amount.IgnoreRequiered = False
        Me.xtxt_seg_amount.Location = New System.Drawing.Point(642, 182)
        Me.xtxt_seg_amount.Name = "xtxt_seg_amount"
        Me.xtxt_seg_amount.NewInitialValue = Nothing
        Me.xtxt_seg_amount.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_seg_amount.Requiered = False
        Me.xtxt_seg_amount.Size = New System.Drawing.Size(128, 27)
        Me.xtxt_seg_amount.StatusBarPanelDescripcion = Nothing
        Me.xtxt_seg_amount.TabIndex = 13
        Me.xtxt_seg_amount.Text = ""
        Me.xtxt_seg_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(538, 182)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(66, 22)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "Seguro:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(8, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo de Venta:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xchk_fact_impresa
        '
        Me.xchk_fact_impresa.CheckAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.xchk_fact_impresa.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ftfactm.fact_impresa"))
        Me.xchk_fact_impresa.EditInitialValue = Nothing
        Me.xchk_fact_impresa.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xchk_fact_impresa.FindInitialValue = Nothing
        Me.xchk_fact_impresa.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xchk_fact_impresa.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.xchk_fact_impresa.IgnoreRequiered = False
        Me.xchk_fact_impresa.KeepEnabled = False
        Me.xchk_fact_impresa.Location = New System.Drawing.Point(728, 68)
        Me.xchk_fact_impresa.Name = "xchk_fact_impresa"
        Me.xchk_fact_impresa.NewInitialValue = Nothing
        Me.xchk_fact_impresa.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xchk_fact_impresa.ReadOnly = False
        Me.xchk_fact_impresa.Requiered = False
        Me.xchk_fact_impresa.Size = New System.Drawing.Size(64, 16)
        Me.xchk_fact_impresa.TabIndex = 54
        Me.xchk_fact_impresa.Text = "Impreso"
        Me.xchk_fact_impresa.ThreeState = True
        Me.xchk_fact_impresa.value = Nothing
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(800, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 22)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Fecha:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Productos"
        Me.LibXGrid1.DataMember = "ftfactd"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 312)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(992, 256)
        Me.LibXGrid1.TabIndex = 2
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColitem_code, Me.gColitem_name, Me.gColprov_name, Me.gColubicacion, Me.gColQty, Me.gColUnit_code, Me.gColFactor, Me.gColPrecio, Me.gColdesc_pct, Me.gColDescuento, Me.gColItbis, Me.gColVencimiento, Me.gColexistencia, Me.gColCosto, Me.gColaplica_dscnt, Me.gColImporte, Me.XDataGridButtonColumn1})
        Me.XdataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ftfactd"
        '
        'gColitem_code
        '
        Me.gColitem_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColitem_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.gColitem_code.executeFindDuringFill = False
        Me.gColitem_code.Format = ""
        Me.gColitem_code.FormatInfo = Nothing
        Me.gColitem_code.HeaderText = "PRODUCTO"
        Me.gColitem_code.isReadOnly = False
        Me.gColitem_code.Lookup = Me.xlk_item_code
        Me.gColitem_code.MappingName = "item_code"
        Me.gColitem_code.MaxLength = 32767
        Me.gColitem_code.TabStop = True
        Me.gColitem_code.UseCustomCellFormat = False
        Me.gColitem_code.Width = 125
        '
        'xlk_item_code
        '
        Me.xlk_item_code.AlternateFieldSearch = " barra"
        Me.xlk_item_code.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xlk_item_code.BackColor = System.Drawing.Color.Brown
        Me.xlk_item_code.BeginCheck = False
        Me.xlk_item_code.CheckText = "Existencia mayor  que Cero (> 0)"
        Me.xlk_item_code.ComboMode = False
        Me.xlk_item_code.Cursor = System.Windows.Forms.Cursors.Default
        Me.xlk_item_code.DataMember = Nothing
        Me.xlk_item_code.DataSource = Me.LibXConnector1
        Me.xlk_item_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "unit_code=unit_code", "factor=factor", "existencia=existencia", "costo=purch_cost", "prov_name=prov_name", "brand_name=brand_name", "sustancias=sustancias", "ubicacion=ubicacion", "aplica_dscnt=aplica_dscnt", "disc_pct=disc_pct", "prd_controlado=prd_controlado"}
        Me.xlk_item_code.FilterField = "item_name"
        Me.xlk_item_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xlk_item_code.ForeColor = System.Drawing.Color.Brown
        Me.xlk_item_code.IgnoreFindInBrowseMode = True
        Me.xlk_item_code.isCanceled = False
        Me.xlk_item_code.Location = New System.Drawing.Point(312, 320)
        Me.xlk_item_code.LookCaption = "Productos"
        Me.xlk_item_code.Name = "xlk_item_code"
        Me.xlk_item_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_item_code.ShowFilter = True
        Me.xlk_item_code.ShowMessageNotFound = True
        Me.xlk_item_code.ShowWarning = True
        Me.xlk_item_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_item_code.SizesColumns = New String() {"item_name=300", "unit_code=50"}
        Me.xlk_item_code.SizesColumnsTab = Nothing
        Me.xlk_item_code.SqlString = New String() {"SELECT DISTINCT ivitemv1.item_code,item_name,ivitemv1.unit_code,", "                             ivunitd.factor,price,existencia,ivitemv1.prov_code,", "                            purch_cost,ubicacion,cpprovm.prov_name,brand_name,", "                           aplica_dscnt,0 dscto,precioitbis,disc_pct,", "                           isnull(prd_controlado,0)prd_controlado,sustancias", "FROM ivitemv1 ", "INNER JOIN cpprovm ON cpprovm.prov_code = ivitemv1.prov_code", "LEFT OUTER JOIN ivcbarram ON ivcbarram.item_code = ivitemv1.item_code", "LEFT OUTER JOIN ivbrandm  on ivitemv1.brand_code = ivbrandm.brand_code", "INNER JOIN ivunitd on ivitemv1.item_code = ivunitd.item_code", "             and  ivunitd.unit_code = ivitemv1.unit_code    order by ivitemv1.ite" & _
        "m_name"}
        Me.xlk_item_code.SQLTab = Nothing
        Me.xlk_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.xlk_item_code.TabIndex = 16
        Me.xlk_item_code.TableName = "ivitemv1"
        Me.xlk_item_code.TabStop = False
        Me.xlk_item_code.UseCopyConnection = False
        Me.xlk_item_code.UseRowRetrieveEvents = False
        Me.xlk_item_code.UseTab = False
        Me.xlk_item_code.VisParameters = New String() {"Nombre=item_name", "Unidad=unit_code", "Precio=price", "Precio+ITBIS=precioitbis", "Existencia=existencia", "Controlado=prd_controlado", "Ubicacion=Ubicacion", "Producto=item_code"}
        Me.xlk_item_code.WhereCondition = "item_status = 1"
        Me.xlk_item_code.WhereParameters = Nothing
        '
        'gColitem_name
        '
        Me.gColitem_name.Format = ""
        Me.gColitem_name.FormatInfo = Nothing
        Me.gColitem_name.HeaderText = "DESCRIPCION"
        Me.gColitem_name.MappingName = "item_name"
        Me.gColitem_name.ReadOnly = True
        Me.gColitem_name.Width = 250
        '
        'gColprov_name
        '
        Me.gColprov_name.Format = ""
        Me.gColprov_name.FormatInfo = Nothing
        Me.gColprov_name.HeaderText = "Proveedor"
        Me.gColprov_name.MappingName = "prov_name"
        Me.gColprov_name.ReadOnly = True
        Me.gColprov_name.Width = 0
        '
        'gColubicacion
        '
        Me.gColubicacion.Format = ""
        Me.gColubicacion.FormatInfo = Nothing
        Me.gColubicacion.HeaderText = "Ubicacion"
        Me.gColubicacion.MappingName = "ubicacion"
        Me.gColubicacion.Width = 0
        '
        'gColQty
        '
        Me.gColQty.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColQty.Format = "#####"
        Me.gColQty.FormatInfo = Nothing
        Me.gColQty.HeaderText = "CANTIDADi"
        Me.gColQty.ImageList = Nothing
        Me.gColQty.isReadOnly = False
        Me.gColQty.MappingName = "qty"
        Me.gColQty.MaxLength = 32767
        Me.gColQty.TabStop = True
        Me.gColQty.UseCustomCellFormat = False
        Me.gColQty.Width = 65
        '
        'gColUnit_code
        '
        Me.gColUnit_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColUnit_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.gColUnit_code.executeFindDuringFill = False
        Me.gColUnit_code.Format = ""
        Me.gColUnit_code.FormatInfo = Nothing
        Me.gColUnit_code.HeaderText = "UNIDAD"
        Me.gColUnit_code.isReadOnly = False
        Me.gColUnit_code.Lookup = Me.xlk_unit_code
        Me.gColUnit_code.MappingName = "unit_code"
        Me.gColUnit_code.MaxLength = 32767
        Me.gColUnit_code.TabStop = True
        Me.gColUnit_code.UseCustomCellFormat = False
        Me.gColUnit_code.Width = 75
        '
        'xlk_unit_code
        '
        Me.xlk_unit_code.AlternateFieldSearch = Nothing
        Me.xlk_unit_code.BeginCheck = False
        Me.xlk_unit_code.CheckText = Nothing
        Me.xlk_unit_code.ComboMode = False
        Me.xlk_unit_code.DataMember = Nothing
        Me.xlk_unit_code.DataSource = Me.LibXConnector1
        Me.xlk_unit_code.DestParameters = New String() {"unit_code=unit_code", "factor=factor"}
        Me.xlk_unit_code.FilterField = "unit_code"
        Me.xlk_unit_code.IgnoreFindInBrowseMode = True
        Me.xlk_unit_code.isCanceled = False
        Me.xlk_unit_code.Location = New System.Drawing.Point(635, 380)
        Me.xlk_unit_code.LookCaption = "Unidades de Venta"
        Me.xlk_unit_code.Name = "xlk_unit_code"
        Me.xlk_unit_code.PopupSize = New System.Drawing.Size(450, 300)
        Me.xlk_unit_code.ShowFilter = True
        Me.xlk_unit_code.ShowMessageNotFound = True
        Me.xlk_unit_code.ShowWarning = False
        Me.xlk_unit_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_unit_code.SizesColumns = New String() {"unit_name=250"}
        Me.xlk_unit_code.SizesColumnsTab = Nothing
        Me.xlk_unit_code.SqlString = Nothing
        Me.xlk_unit_code.SQLTab = Nothing
        Me.xlk_unit_code.SrcParameters = New String() {"unit_code=unit_code"}
        Me.xlk_unit_code.TabIndex = 19
        Me.xlk_unit_code.TableName = "ivunitv"
        Me.xlk_unit_code.TabStop = False
        Me.xlk_unit_code.UseCopyConnection = False
        Me.xlk_unit_code.UseRowRetrieveEvents = False
        Me.xlk_unit_code.UseTab = False
        Me.xlk_unit_code.VisParameters = New String() {"Codigo=unit_code", "Unidad=unit_name", "Factor=factor"}
        Me.xlk_unit_code.WhereCondition = "unit_type in (1,3)"
        Me.xlk_unit_code.WhereParameters = Nothing
        '
        'gColFactor
        '
        Me.gColFactor.Format = "###.00"
        Me.gColFactor.FormatInfo = Nothing
        Me.gColFactor.MappingName = "factor"
        Me.gColFactor.Width = 0
        '
        'gColPrecio
        '
        Me.gColPrecio.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColPrecio.Format = "##,###,##0.00"
        Me.gColPrecio.FormatInfo = Nothing
        Me.gColPrecio.HeaderText = "PRECIOi"
        Me.gColPrecio.ImageList = Nothing
        Me.gColPrecio.isReadOnly = False
        Me.gColPrecio.MappingName = "price"
        Me.gColPrecio.MaxLength = 32767
        Me.gColPrecio.ReadOnly = True
        Me.gColPrecio.TabStop = True
        Me.gColPrecio.UseCustomCellFormat = False
        Me.gColPrecio.Width = 90
        '
        'gColdesc_pct
        '
        Me.gColdesc_pct.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColdesc_pct.Format = ""
        Me.gColdesc_pct.FormatInfo = Nothing
        Me.gColdesc_pct.HeaderText = "% DESC"
        Me.gColdesc_pct.ImageList = Nothing
        Me.gColdesc_pct.isReadOnly = True
        Me.gColdesc_pct.MappingName = "disc_pct"
        Me.gColdesc_pct.MaxLength = 32767
        Me.gColdesc_pct.ReadOnly = True
        Me.gColdesc_pct.TabStop = True
        Me.gColdesc_pct.UseCustomCellFormat = False
        Me.gColdesc_pct.Width = 0
        '
        'gColDescuento
        '
        Me.gColDescuento.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColDescuento.Format = "##,###.00"
        Me.gColDescuento.FormatInfo = Nothing
        Me.gColDescuento.HeaderText = "DESCUENTOi"
        Me.gColDescuento.ImageList = Nothing
        Me.gColDescuento.isReadOnly = False
        Me.gColDescuento.MappingName = "dscto"
        Me.gColDescuento.MaxLength = 32767
        Me.gColDescuento.TabStop = True
        Me.gColDescuento.UseCustomCellFormat = False
        Me.gColDescuento.Width = 90
        '
        'gColItbis
        '
        Me.gColItbis.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColItbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColItbis.Format = "##,###.00"
        Me.gColItbis.FormatInfo = Nothing
        Me.gColItbis.HeaderText = "ITBISi"
        Me.gColItbis.ImageList = Nothing
        Me.gColItbis.isReadOnly = True
        Me.gColItbis.MappingName = "itbis"
        Me.gColItbis.MaxLength = 32767
        Me.gColItbis.ReadOnly = True
        Me.gColItbis.TabStop = True
        Me.gColItbis.UseCustomCellFormat = False
        Me.gColItbis.Width = 90
        '
        'gColVencimiento
        '
        Me.gColVencimiento.Format = ""
        Me.gColVencimiento.FormatInfo = Nothing
        Me.gColVencimiento.MappingName = "vencimiento"
        Me.gColVencimiento.ReadOnly = True
        Me.gColVencimiento.Width = 0
        '
        'gColexistencia
        '
        Me.gColexistencia.Format = ""
        Me.gColexistencia.FormatInfo = Nothing
        Me.gColexistencia.MappingName = "existencia"
        Me.gColexistencia.ReadOnly = True
        Me.gColexistencia.Width = 0
        '
        'gColCosto
        '
        Me.gColCosto.Format = ""
        Me.gColCosto.FormatInfo = Nothing
        Me.gColCosto.MappingName = "costo"
        Me.gColCosto.Width = 0
        '
        'gColaplica_dscnt
        '
        Me.gColaplica_dscnt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColaplica_dscnt.Format = ""
        Me.gColaplica_dscnt.FormatInfo = Nothing
        Me.gColaplica_dscnt.HeaderText = "Aplica Descuento"
        Me.gColaplica_dscnt.ImageList = Nothing
        Me.gColaplica_dscnt.isReadOnly = True
        Me.gColaplica_dscnt.MappingName = "aplica_dscnt"
        Me.gColaplica_dscnt.MaxLength = 32767
        Me.gColaplica_dscnt.ReadOnly = True
        Me.gColaplica_dscnt.TabStop = True
        Me.gColaplica_dscnt.UseCustomCellFormat = False
        Me.gColaplica_dscnt.Width = 0
        '
        'gColImporte
        '
        Me.gColImporte.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColImporte.Format = "#######0.00"
        Me.gColImporte.FormatInfo = Nothing
        Me.gColImporte.HeaderText = "IMPORTEi"
        Me.gColImporte.ImageList = Nothing
        Me.gColImporte.isReadOnly = True
        Me.gColImporte.MappingName = "importe"
        Me.gColImporte.MaxLength = 32767
        Me.gColImporte.ReadOnly = True
        Me.gColImporte.TabStop = True
        Me.gColImporte.UseCustomCellFormat = False
        Me.gColImporte.Width = 90
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 624)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 16)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Marca:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblitem_name
        '
        Me.lblitem_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblitem_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblitem_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactd.brand_name"))
        Me.lblitem_name.Location = New System.Drawing.Point(72, 624)
        Me.lblitem_name.Name = "lblitem_name"
        Me.lblitem_name.Size = New System.Drawing.Size(136, 20)
        Me.lblitem_name.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(522, 624)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 16)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Localicación:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbllocalizacion
        '
        Me.lbllocalizacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbllocalizacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbllocalizacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactd.ubicacion"))
        Me.lbllocalizacion.Location = New System.Drawing.Point(600, 624)
        Me.lbllocalizacion.Name = "lbllocalizacion"
        Me.lbllocalizacion.Size = New System.Drawing.Size(128, 20)
        Me.lbllocalizacion.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(744, 624)
        Me.Label20.Name = "Label20"
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Existencia:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblexistencia
        '
        Me.lblexistencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblexistencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblexistencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactd.existencia"))
        Me.lblexistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexistencia.ForeColor = System.Drawing.Color.Blue
        Me.lblexistencia.Location = New System.Drawing.Point(856, 624)
        Me.lblexistencia.Name = "lblexistencia"
        Me.lblexistencia.Size = New System.Drawing.Size(144, 40)
        Me.lblexistencia.TabIndex = 10
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(488, 648)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(104, 16)
        Me.Label35.TabIndex = 13
        Me.Label35.Text = "Fecha/Vencimiento:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVencimiento
        '
        Me.lblVencimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVencimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactd.Vencimiento"))
        Me.lblVencimiento.Location = New System.Drawing.Point(600, 648)
        Me.lblVencimiento.Name = "lblVencimiento"
        Me.lblVencimiento.Size = New System.Drawing.Size(128, 20)
        Me.lblVencimiento.TabIndex = 12
        '
        'Label37
        '
        Me.Label37.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(8, 648)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(49, 16)
        Me.Label37.TabIndex = 15
        Me.Label37.Text = "Suplidor:"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblprov_name
        '
        Me.lblprov_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblprov_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblprov_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactd.prov_name"))
        Me.lblprov_name.Location = New System.Drawing.Point(72, 648)
        Me.lblprov_name.Name = "lblprov_name"
        Me.lblprov_name.Size = New System.Drawing.Size(392, 20)
        Me.lblprov_name.TabIndex = 14
        '
        'btnCobrar
        '
        Me.btnCobrar.AccessibleDescription = ""
        Me.btnCobrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCobrar.Location = New System.Drawing.Point(8, 680)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(96, 32)
        Me.btnCobrar.TabIndex = 18
        Me.btnCobrar.Text = "Cobrar (F9)"
        Me.ToolTip1.SetToolTip(Me.btnCobrar, "Cobrar documentos Pendiente enviado a caja")
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Cobrar"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Enviar a Hold"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Traer de Hold"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "Recibo Ingreso"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 5
        Me.MenuItem6.Text = "Estafetas"
        '
        'btnSetHold
        '
        Me.btnSetHold.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSetHold.Enabled = False
        Me.btnSetHold.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSetHold.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSetHold.ImageIndex = 0
        Me.btnSetHold.Location = New System.Drawing.Point(384, 584)
        Me.btnSetHold.Name = "btnSetHold"
        Me.btnSetHold.Size = New System.Drawing.Size(96, 32)
        Me.btnSetHold.TabIndex = 23
        Me.btnSetHold.Text = "Poner en Espera"
        Me.ToolTip1.SetToolTip(Me.btnSetHold, "Poner documentos en espera")
        Me.btnSetHold.Visible = False
        '
        'btnFreeHold
        '
        Me.btnFreeHold.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFreeHold.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFreeHold.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnFreeHold.ImageIndex = 1
        Me.btnFreeHold.Location = New System.Drawing.Point(320, 680)
        Me.btnFreeHold.Name = "btnFreeHold"
        Me.btnFreeHold.Size = New System.Drawing.Size(96, 32)
        Me.btnFreeHold.TabIndex = 24
        Me.btnFreeHold.Text = "Llamar Espera(F11)"
        Me.ToolTip1.SetToolTip(Me.btnFreeHold, "Llamar documento de espera")
        '
        'btnEgresos
        '
        Me.btnEgresos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEgresos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEgresos.Location = New System.Drawing.Point(424, 680)
        Me.btnEgresos.Name = "btnEgresos"
        Me.btnEgresos.Size = New System.Drawing.Size(96, 32)
        Me.btnEgresos.TabIndex = 24
        Me.btnEgresos.Text = "Egresos"
        Me.ToolTip1.SetToolTip(Me.btnEgresos, "Recibos de egresos")
        '
        'btnDomicilios
        '
        Me.btnDomicilios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDomicilios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDomicilios.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDomicilios.ImageIndex = 2
        Me.btnDomicilios.Location = New System.Drawing.Point(112, 680)
        Me.btnDomicilios.Name = "btnDomicilios"
        Me.btnDomicilios.Size = New System.Drawing.Size(96, 32)
        Me.btnDomicilios.TabIndex = 24
        Me.btnDomicilios.Text = "Cobrar Domicilios(F8)"
        Me.ToolTip1.SetToolTip(Me.btnDomicilios, "Cobrar domicilios recibidos")
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Nothing
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_caja_code
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_type_code
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(1010, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'btnIngresos
        '
        Me.btnIngresos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIngresos.Location = New System.Drawing.Point(528, 680)
        Me.btnIngresos.Name = "btnIngresos"
        Me.btnIngresos.Size = New System.Drawing.Size(96, 32)
        Me.btnIngresos.TabIndex = 24
        Me.btnIngresos.Text = "Ingresos"
        Me.ToolTip1.SetToolTip(Me.btnIngresos, "Recibos de ingreso")
        '
        'btnExistencia
        '
        Me.btnExistencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExistencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExistencia.Location = New System.Drawing.Point(904, 680)
        Me.btnExistencia.Name = "btnExistencia"
        Me.btnExistencia.Size = New System.Drawing.Size(96, 32)
        Me.btnExistencia.TabIndex = 24
        Me.btnExistencia.Text = "Consulta"
        Me.ToolTip1.SetToolTip(Me.btnExistencia, "Vencimiento de productos")
        '
        'btnOpenCash
        '
        Me.btnOpenCash.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOpenCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOpenCash.Location = New System.Drawing.Point(800, 680)
        Me.btnOpenCash.Name = "btnOpenCash"
        Me.btnOpenCash.Size = New System.Drawing.Size(96, 32)
        Me.btnOpenCash.TabIndex = 25
        Me.btnOpenCash.Text = "Abrir Cajón"
        Me.ToolTip1.SetToolTip(Me.btnOpenCash, "Abrir la gaveta de caja con autorización")
        '
        'btnestafetas
        '
        Me.btnestafetas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnestafetas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnestafetas.Location = New System.Drawing.Point(632, 680)
        Me.btnestafetas.Name = "btnestafetas"
        Me.btnestafetas.Size = New System.Drawing.Size(96, 32)
        Me.btnestafetas.TabIndex = 26
        Me.btnestafetas.Text = "Estafetas"
        Me.ToolTip1.SetToolTip(Me.btnestafetas, "Estafeta de pago")
        '
        'btnCancelarImpresion
        '
        Me.btnCancelarImpresion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarImpresion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelarImpresion.Location = New System.Drawing.Point(216, 680)
        Me.btnCancelarImpresion.Name = "btnCancelarImpresion"
        Me.btnCancelarImpresion.Size = New System.Drawing.Size(96, 32)
        Me.btnCancelarImpresion.TabIndex = 29
        Me.btnCancelarImpresion.Text = "Cancelar Impresion"
        Me.ToolTip1.SetToolTip(Me.btnCancelarImpresion, "Cancelar Impresion")
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(40, 576)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Visible = False
        '
        'xtxsusta
        '
        Me.xtxsusta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactd.sustancias"))
        Me.xtxsusta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxsusta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.xtxsusta.Location = New System.Drawing.Point(208, 625)
        Me.xtxsusta.Name = "xtxsusta"
        Me.xtxsusta.Size = New System.Drawing.Size(264, 16)
        Me.xtxsusta.TabIndex = 28
        '
        'XDataGridButtonColumn1
        '
        Me.XDataGridButtonColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XDataGridButtonColumn1.Format = ""
        Me.XDataGridButtonColumn1.FormatInfo = Nothing
        Me.XDataGridButtonColumn1.HeaderText = "..."
        Me.XDataGridButtonColumn1.MappingName = "brand_name"
        Me.XDataGridButtonColumn1.MaxLength = 32767
        Me.XDataGridButtonColumn1.Width = 25
        '
        'i_ptvfact01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1010, 728)
        Me.ContextMenu = Me.ContextMenu1
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelarImpresion)
        Me.Controls.Add(Me.xtxsusta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnestafetas)
        Me.Controls.Add(Me.btnOpenCash)
        Me.Controls.Add(Me.btnFreeHold)
        Me.Controls.Add(Me.btnSetHold)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblprov_name)
        Me.Controls.Add(Me.lblVencimiento)
        Me.Controls.Add(Me.lblexistencia)
        Me.Controls.Add(Me.lbllocalizacion)
        Me.Controls.Add(Me.lblitem_name)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.btnEgresos)
        Me.Controls.Add(Me.btnDomicilios)
        Me.Controls.Add(Me.btnIngresos)
        Me.Controls.Add(Me.btnExistencia)
        Me.Controls.Add(Me.xlk_unit_code)
        Me.Controls.Add(Me.xlk_item_code)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "i_ptvfact01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SGF Punto de Venta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftsegrm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub xlk_item_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_item_code.AfterSetValues
        Try

            If e.dataFound = False Then
                Exit Sub
            End If

            Me.lblexistencia.Text = Format(e.row!existencia, "###,##0")
            ''Me.lblitem_name.Text = e.row!item_name.ToString.Trim
            Me.lblitem_name.Text = e.row!brand_name.ToString.Trim
            Me.lblprov_name.Text = e.row!prov_name.ToString.Trim
            Me.lbllocalizacion.Text = e.row!ubicacion.ToString.Trim
            Me.GetVencimiento(e.row!item_code.ToString.Trim)
            Me.xtxsusta.Text = e.row!sustancias.ToString.Trim

            If Me.LibXConnector1.IsDataEditing = True Then
                'If oDocumento.AplicarPrecio = True Then
                LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.gColPrecio, e.row!price)
                'Else
                '    LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.gColPrecio, e.row!purch_cost)
                'End If
                If LibX.IsNull(e.row!dscto) = False AndAlso CDec(e.row!dscto) > 0 Then
                    LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.gColDescuento, e.row!dscto)
                End If
                mExit = False
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction

        Try
            '// Al salvar si no es en HOLD rebajar de inventario
            oCajera = New Cajera(LibX.User.VendedorID)
            If e.AcceptedAction = LibxConnectionActions.Add _
            Or e.AcceptedAction = LibxConnectionActions.Edit Then
                If Val(Me.xcbo_fact_status.currValue.ToString.Trim) <> Val(EstatusDocumentosEnum.enEspera) Then   'HOLD Then

                    '// si es un documento pendiente o domicilio pendiente
                    If Val(Me.xcbo_fact_status.currValue.ToString.Trim) = Val(EstatusDocumentosEnum.Pendiente) _
                    Or Val(Me.xcbo_fact_status.currValue.ToString.Trim) = Val(EstatusDocumentosEnum.DomicilioPendiente) Then
                        '// Rebajar Inventario
                        AplicarInventario(LibXConnector1.CurrentDataRow!ftserial_no)
                    End If

                    '// si es cajera y NO es un domicilio que lo cobro
                    ''If oCajera.esCajera = True AndAlso mCaja = True AndAlso _
                    If mCaja = True AndAlso _
                    (LibX.IsNull(LibXConnector1.CurrentDataRow!fact_inddomicilio) = True _
                    OrElse LibXConnector1.CurrentDataRow!fact_inddomicilio = 0) Then
                        If ValidarEstadoCaja(oCajaAbierta.Serial) = False Then
                            Throw New ApplicationException("Esta caja ha sido cerrada y no puede cobrar, Debe cancelar la accion!")
                        End If
                        CobrarDocumento(LibXConnector1.CurrentDataRow!ftserial_no, LibXConnector1.CurrentDataRow!type_code)
                    End If

                    '// Si es una cajera y es un domicilio llamar la funcion de impresion                    
                    If (LibX.IsNull(LibXConnector1.CurrentDataRow!fact_inddomicilio) = False _
                    AndAlso LibXConnector1.CurrentDataRow!fact_inddomicilio = 1) _
                    AndAlso isDomicilio = False Then
                        Select Case oDocumento.SoloDomicilio
                            Case oDocumento.SoloDomicilio = True
                                If oDocumento.CantCopiasDOM > 0 And LibXConnector1.CurrentDataRow!fact_inddomicilio = 1 Then
                                    LibXConnector1.ReportObject.Copias = oDocumento.CantCopiasDOM   '// Imprimir Directo
                                End If
                            Case oDocumento.SoloDomicilio = False
                                If oDocumento.CantCopiasEFE > 0 Then
                                    LibXConnector1.ReportObject.Copias = oDocumento.CantCopiasEFE   '// Imprimir Directo
                                End If
                        End Select
                        LibXConnector1.ReportObject.Destination = Crystal.DestinationConstants.crptToPrinter '// Imprimir Directo
                        LibXConnector1.Print()

                        '// marcar como impreso
                        If Not LibX.IsNull(LibXConnector1.CurrentDataRow!fact_number) Then
                            SetPrinted(LibXConnector1.CurrentDataRow!ftserial_no)
                        End If

                        '// refrescar
                        LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & LibXConnector1.CurrentDataRow!ftserial_no.ToString.Trim)
                    End If
                End If

                '// desabilitar el boton de poner en espera
                Me.btnSetHold.Enabled = False

                '// Despues de salvar un registro desabilitar el edit y delete, que para 
                '// poder editar y borrar que haya q buscar el regitro otra vez
                LibXConnector1.AllowDelete = False
                LibXConnector1.AllowEdit = False
                LibXNavigator1.UpdateState()
            End If

            If e.Action = LibX.LibxConnectionActions.Add Then
                mIsedit = False
                '// Mostrar Información Caja y Cajera
                ShowCajaInfo()
                If Me.xtxt_type_code.Text = "" Then
                    Me.xtxt_type_code.Enabled = True
                    Me.xlk_type_code.Enabled = True
                    Me.xtxt_descuento.Enabled = True
                Else
                    Me.xtxt_type_code.Enabled = False
                    Me.xlk_type_code.Enabled = False
                End If

                '// Ir al Detalle
                SetFocusToGrid()
            End If
            If e.Action = LibX.LibxConnectionActions.Edit Then
                mIsedit = True
            End If
            If e.Action = LibxConnectionActions.Accept Then
                CalcularNeto()
            End If
            If e.Action = LibxConnectionActions.Cancel Then
                Me.GroupBox1.Enabled = True
                Me.GroupBox2.Enabled = True
                Me.GroupBox3.Enabled = True
                Me.LibXGrid1.Enabled = True
                Me.xtxt_type_code.Enabled = True
                Me.xlk_type_code.Enabled = True
                Me.xtxt_bus_name.Enabled = True
            End If

            mDsctoManual = False

        Catch ex As Exception
            e.Handled = True
            LibX.Log.Add(ex)
            If ValidarEstadoCaja(oCajaAbierta.Serial) = False Then
                Me.GroupBox1.Enabled = False
                Me.GroupBox2.Enabled = False
                Me.GroupBox3.Enabled = False
                Me.LibXGrid1.Enabled = False
            End If
        End Try

    End Sub
    Private Sub SetPrinted(ByVal pftserial_no As Integer)
        Dim XUpdate As LibX.Data.XUpdateStmt

        XUpdate = New LibX.Data.XUpdateStmt("ftfactm")
        XUpdate.FieldsSet("fact_impresa") = 1
        XUpdate.Fields("ftserial_no") = pftserial_no
        XUpdate.Execute()

    End Sub
    Public Function FindFechaSever() As DateTime
        Dim Serverdate As DateTime
        Dim XSelect As LibX.Data.XSelecStmt
        Try
            Serverdate = LibX.Data.Manager.GetScalar("select getdate()")

            Return Serverdate

        Catch ex As Exception
            LibX.Log.Add(ex)
        Finally

        End Try
    End Function

    Private Function ValidarEstadoCaja(ByVal InitSerial As Integer) As Boolean
        Dim oRedEstado As Integer
        Dim SelectStmt As String

        SelectStmt = "select init_status from cjinitm where init_serial = " & InitSerial.ToString.Trim

        oRedEstado = LibX.Data.Manager.GetScalar(SelectStmt)
        If oRedEstado <> 1 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Function ValidarFacturaPendiente(ByVal InitSerial As Integer) As Boolean
        Dim oPendiente As Integer
        Dim SelectStmt As String
        SelectStmt = "select count(*) from ftfactm where fact_status in(4) and init_serial = " & InitSerial.ToString.Trim
        oPendiente = LibX.Data.Manager.GetScalar(SelectStmt)
        If oPendiente > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function CuentaSeguroDomicici(ByVal CiaSerial As Integer) As Integer
        Dim Codigo As Integer
        Dim SelectStmt As String
        SelectStmt = "select cust_code from sgciasm where cia_serial = " & CiaSerial.ToString.Trim
        Codigo = LibX.Data.Manager.GetScalar(SelectStmt)

        Return Codigo
    End Function
    Private Function ValidarDocumento(ByVal fSerial As Integer) As Boolean
        Dim oRedEstado As Integer
        Dim SelectStmt As String

        SelectStmt = "select isnull(fact_number,0) from ftfactm where ftserial_no = " & fSerial.ToString.Trim

        oRedEstado = LibX.Data.Manager.GetScalar(SelectStmt)

        If oRedEstado = 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub LibXConnector1_InsertingDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingDetailRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert _
                Or e.UpdatingArgs.StatementType = StatementType.Update Then
                If LibX.IsNull(e.UpdatingArgs.Row!item_code) Then
                    e.UpdatingArgs.Status = UpdateStatus.SkipCurrentRow
                    e.UpdatingArgs.Row.AcceptChanges()
                End If
                If LibX.IsNull(e.UpdatingArgs.Row!unit_code) Then
                    Throw New ApplicationException("No se puede grabar Factura con producto sin unidad!")
                End If
                If LibX.IsNull(e.UpdatingArgs.Row!qty) Then
                    Throw New ApplicationException("No se puede grabar factura con producto sin cantidad!")
                End If
                If LibXGrid1.getCurrentGridView.Count < 0 Then
                    Throw New ApplicationException("No se puede grabar factura sin detalle!")
                End If
                If e.UpdatingArgs.Row!qty < 0 Then
                    Throw New ApplicationException("No se puede grabar factura con cantidad negativa!")
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub i_ptvfact01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim hasCajas As Boolean = False
        Dim CloseProgram As Boolean = False
        Try

            oProgram = New SGT.Administracion.Entidades.Program
            mMachine = New SGT.Administracion.Entidades.Program.Autentication

            mMachine.Machine = System.Environment.MachineName

            If oProgram.BuildAutentication(mMachine) = False Then
                If MessageBox.Show("ESTE PROGRAMA ESTA PROTEGIDO CONTRA" & _
                                    vbCrLf & "COPIA NO AUTORIZADA, NECESITA" & _
                                    vbCrLf & "LA INTERVENSION DEL AUTOR, REDSOFT, S. A." & _
                                    vbCrLf & "TEL. 809-540-0547.", _
                                    "Copia no autorizada", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Question) = DialogResult.OK Then
                    Me.Close()
                    Exit Sub
                End If
            End If
            '// buscar el almacen por defecto
            WhDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibXWhDefault").ToString)
            WhDefaultNo = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibxWhDefaultNo").ToString)
            ScDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibXScDefault").ToString)
            CajaDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibxDefaultCaja").ToString)
            isDomicilio = CType(System.Configuration.ConfigurationSettings.AppSettings.Get("LibXPreparaDomicilio"), Boolean)
            isClienteAntes = CType(System.Configuration.ConfigurationSettings.AppSettings.Get("LibxIndicarCliente"), Boolean)
            isVendm = CType(System.Configuration.ConfigurationSettings.AppSettings.Get("LibxIndVendm"), Boolean)

            ftfactd.Columns("Ubicacion").ReadOnly = False

            '// Boton Abrir Caja
            Me.btnOpenCash.Enabled = mCaja
            If mCaja = False Then
                If LibX.User.WhDefault = 0 Then
                    LibX.User.WhDefault = WhDefault
                End If
                If LibX.User.Sucursal = 0 Then
                    LibX.User.Sucursal = ScDefault
                End If
            End If


            '// Buscar cajas abiertas`
            oCajaAbierta = New CajaAbierta

            If LibX.User.VendedorID > 0 Then
                oCajera = New Cajera(LibX.User.VendedorID)
                hasCajas = oCajaAbierta.HayCajasAbiertas(oCajera.Code, LibX.User.Sucursal)
            Else
                hasCajas = oCajaAbierta.HayCajasAbiertas()
            End If

            '// si no hay cajas abiertas
            If hasCajas = False Then
                If oCajera.esCajera = False Then
                    Throw New ApplicationException("Debe especificar una cajera para iniciar una caja!")
                End If

                Dim oParam As New LibX.LibxPrgParams
                oParam.AllowDelete = False
                oParam.AllowEdit = False
                oParam.AllowNew = False
                oParam.AllowQuery = False

                oParam.IsFromOther = True
                oParam.initMode = LibxInitModes.Insert

                oParam.Datos.Add("caje_code", LibX.User.VendedorID)
                oParam.Datos.Add("init_date", FindFechaSever())
                oParam.Datos.Add("caja_code", CajaDefault)
                oParam.Datos.Add("suc_code", LibX.User.Sucursal)
                LibX.App.CurrentPrgParams = oParam

                LibX.LibXRunner.Run("i_cjinit01", "CAJ", True)

                If oCajaAbierta.GetAbiertaByCajeraID(LibX.User.VendedorID, LibX.User.Sucursal) = False Then
                    CloseProgram = True
                    Throw New ApplicationException("Debe iniciar una caja para realizar las operaciones del dia!")
                End If

                Me.Text &= " - [" & "CAJERA - " & oCajaAbierta.Fecha.ToString("dd/MM/yyyy") & "]"
            Else
                Dim oParam As New LibX.LibxPrgParams
                If Not oCajera Is Nothing Then oparam.Value = oCajera.Code
                oParam.Datos.Add("ScDefault", LibX.User.Sucursal)
                '// Si es un vendedor mostrar la lista de cajas abiertas 
                LibX.App.CurrentPrgParams = oParam
                LibX.LibXRunner.Run("i_cjopen", "CAJ", True)
                If hasCajas = False And mCaja = False Then
                    Me.Text &= " - [" & "VENDEDOR - " & oCajaAbierta.Fecha.ToString("dd/MM/yyyy") & "]"
                Else
                    Me.Text &= " - [" & "CAJA - " & oCajaAbierta.Fecha.ToString("dd/MM/yyyy") & "]"
                End If
            End If

            If CajaAbierta.CajeraCode <= 0 Then
                Me.Close()
                Exit Sub
            End If

            oProducto = New SGT.Inventario.Entidades.Articulo
            oSeguro = New SGT.PuntodeVenta.Entidades.SegurosMedicos
            opvDocumento = New SGT.PuntodeVenta.Entidades.Documentos
            ofctDocumento = New SGT.Facturacion.Entidades.Documento

            oCaja = New Caja(CajaAbierta.CajaCode)
            mVendedor = New Cajera
            oClienteDomicilio = New ClienteDomicilio
            oClienteAsegurado = New ClienteAsegurado
            oClienteCredito = New ClienteCredito
            oAutorizacion = New AutorizacionSeguro
            oDevolucion = New Devolucion
            oParamValidar = New SGT.Administracion.Entidades.Permission.ParametrosValidar
            oAutorizar = New SGT.Administracion.Entidades.Permission
            mConfig = New SGT.Inventario.Common.Configuration

            '// verificar que no haya otra maquina con este usuario ejecutando la caja
            If Not oCajera Is Nothing AndAlso oCajera.esCajera = True Then
                oParamRunning = New SGT.Administracion.Entidades.Program.ParametroRunning
                oProgram = New SGT.Administracion.Entidades.Program
                With oParamRunning
                    .Caja = oCajaAbierta.CajaCode
                    .Cajera = oCajaAbierta.CajeraCode
                    .Fecha = oCajaAbierta.Fecha
                    .Program = "i_ptvfact01"
                    .UserName = LibX.User.UserName
                    .Machine = System.Environment.MachineName
                End With

                _XtControl_serial = oProgram.ProgramRunning(oParamRunning)

                If _XtControl_serial = -1 Then
                    If MessageBox.Show("Ya existe otra maquina abierta como cajera" & _
                    vbCrLf & "necesita la intervensión del supervisor" & vbCrLf & _
                    vbCrLf & "Desea Abrir esta maquina como cajera?", _
                    "Existe otra maquina abierta como cajera", _
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                        If AbrirCaja() = True Then
                            'oProgram.ProgramStopping(oParamRunning)
                        Else
                            Throw New ApplicationException("Necesita la intervension de un supervisor para iniciar esta maquina como cajera!")
                        End If
                    Else
                        Throw New ApplicationException("Necesita la intervension de un supervisor para iniciar esta maquina como cajera!")
                    End If
                End If
            End If

            '// hablilitar los botones si es caja
            Me.btnIngresos.Enabled = mCaja
            Me.btnestafetas.Enabled = mCaja
            Me.btnEgresos.Enabled = mCaja
            Me.btnCobrar.Enabled = mCaja
            Me.btnDomicilios.Enabled = mCaja

            '// Mostrar Caja y Cajera
            ShowCajaInfo()

            '// Validar Permisos de Usuario
            oParamValidar.UserID = LibX.User.UserID

            '// Agrear una columna calculada llamada Importe a la tabla ftfactd
            Me.DataSet1.Tables("ftfactd").Columns("Importe").Expression = "((qty*price) - isnull(dscto,0)) + isnull(itbis,0)"
            Me.DataSet1.Tables("ftfactd").Columns("net_amt").Expression = "(qty*price) "

            '// Quitar el serial a las columna seriales
            Me.DataSet1.Tables("ftfactm").Columns("afect_serial").AutoIncrement = False
            Me.DataSet1.Tables("ftfactm").Columns("afect_serial").ReadOnly = False

            '// Operaciones del grid
            Me.LibXGrid1.footerOperations.add("item_code", "count(item_code)", "1=1")
            Me.LibXGrid1.footerOperations.add("Importe", "sum(Importe)", "1=1")
            Me.LibXGrid1.footerOperations.add("itbis", "sum(itbis)", "1=1")
            Me.LibXGrid1.footerOperations.add("dscto", "sum(dscto)", "1=1")

            '// la fecha
            Me.DataSet1.Tables("ftfactm").Columns("fact_date").AllowDBNull = True

            '// CApturar los eventos de KeyPress del grid
            RemoveHandler LibXGrid1.CellKeyPress, AddressOf i_ptvfact01_KeyUp
            AddHandler LibXGrid1.CellKeyPress, AddressOf i_ptvfact01_KeyUp


            '// Conexion usada por la libreria Fiscal
            dbOPenn = Configuration.ConfigurationSettings.AppSettings.Get("LibxConnectFiscal").ToString


        Catch ex As Exception
            LibX.Log.Show(ex)
            Application.Exit()
            If CloseProgram = True Then
                Me.Close()
            End If
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Dim CloseProgram As Boolean = False
        Try
            If oCajaAbierta.HayCajasAbiertas = False Then
                CloseProgram = True
                Throw New ApplicationException("Debe iniciar una caja para realizar las operaciones del dia!")
            End If

            If mCaja = True And oCaja.Vender = True Then
                LibXConnector1.AllowNew = False
                LibXGrid1.Enabled = False
                Throw New ApplicationException("Esta caja no puede facturar!")
            End If

            Me.gColitem_code.ReadOnly = False
            Me.gColitem_code.isReadOnly = False
            mLastKeyPressedInGrid = Nothing

            '// Limpiar permisos Autorizados
            oAutorizar.PermisosAutorizados.Clear()

            Me.xcbo_fact_status.currValue = Val(EstatusDocumentosEnum.Pendiente)  '// Pendiente
            Me.xdt_fact_date.Value = CajaAbierta.Fecha
            Me.xtxfacttime.Text = DateTime.Now.ToShortTimeString()
            Me.btnCustomer.Enabled = False

            ftsegrm.Rows.Clear()

            Me.lbl_AditionalInformation.Text = ""
            Me.xtxt_MontoNeto.Text = ""

            oDevolucion = New Devolucion
            oClienteAsegurado = New ClienteAsegurado
            oClienteDomicilio = New ClienteDomicilio
            oClienteCredito = New ClienteCredito
            oAutorizacion = New AutorizacionSeguro

            If isVendm = True Then
                Me.xtxt_vend_code.Text = 1
                Me.xlk_vend_code.ExecuteFind()
                Me.xtxt_type_code.Text = "FPV"
                Me.xlk_type_code.ExecuteFind()
            Else
                If PedirVendedor() = False Then
                    LibXConnector1.ShowWarningCancel = False
                    LibXConnector1.Cancel()
                    LibXConnector1.ShowWarningCancel = True
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
            If CloseProgram = True Then
                Me.Close()
            End If
        End Try
    End Sub

    Private Sub xlk_unit_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_unit_code.BeforeExecuteQuery
        Try
            mUnid = LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColUnit_code)
            e.aditionalWhere = "item_code = '" & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColitem_code) & "'"
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub xlk_unit_code_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_unit_code.BeforeSetValues
        Dim Costo As Decimal
        Dim Factor As Decimal
        Dim oUnidad As UnidadMedida
        Dim oParam As UnidadMedida.ParametroConvertirValor
        Dim Unidad As String
        Dim Descuento As Decimal
        Dim Importe As Decimal
        Dim Cantidad As Integer

        If e.dataFound = False Then
            Exit Sub
        End If

        Try
            If LibXConnector1.IsDataEditing = True And mUnid.Trim <> "" Then
                oUnidad = New UnidadMedida
                oParam = New UnidadMedida.ParametroConvertirValor

                oParam.Valor = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColPrecio)
                oParam.Producto = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColitem_code)
                oParam.UnidadDestino = e.row!unit_code.ToString.Trim
                oParam.UnidadOrigen = mUnid

                oUnidad.ConvertirValor(oParam)
                Factor = e.row!factor
                LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, gColPrecio, oParam.Retorno.Valor)
                If mConfig.GetDSCTO > 0 And Me.xtxt_type_code.Text.Trim = "FPV" Then
                    oCalcularDscto = New SGT.Inventario.Entidades.Articulo.ParametrosCalculardescuentos

                    With oCalcularDscto
                        .Almacen = WhDefault
                        .Producto = LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColitem_code)
                        .Monto = (Val(LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColPrecio)) * _
                                  Val(LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColQty)))
                    End With

                    Descuento = oProducto.CalcularDscto(oCalcularDscto)
                    LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColDescuento, Descuento)

                End If
                mUnid = String.Empty
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
        Dim itbis As Decimal
        Dim Descuento As Decimal
        Try
            If LibXConnector1.IsDataEditing = True Then
                If mLastKeyPressedInGrid = Keys.Down And e.row = LibXGrid1.getCurrentGridView.Count - 1 Then
                    e.hasErrors = True
                    Exit Sub
                End If

                ''If LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColitem_code).Trim <> "" Then
                ''    Me.gColitem_code.ReadOnly = True
                ''    Me.gColitem_code.isReadOnly = True
                ''    Me.xlk_item_code.Enabled = False
                ''Else
                ''    Me.gColitem_code.ReadOnly = False
                ''    Me.gColitem_code.isReadOnly = False
                ''    Me.xlk_item_code.Enabled = True
                ''End If

                If e.cell = Me.gColitem_code.Column AndAlso LibXGrid1.GetValue(e.row, gColitem_code).Trim = "" Then
                    LibXGrid1.Focus(e.row, 0)
                    LibXGrid1.EndEdit(gColitem_code, e.row, True)
                    If mLastKeyPressedInGrid = Keys.Enter Then
                        e.hasErrors = True
                        Exit Sub
                    End If
                End If

                If e.cell = Me.gColPrecio.Column Or e.cell = Me.gColQty.Column Or e.cell = Me.gColDescuento.Column Then
                    If LibXGrid1.GetValue(e.row, gColitem_code) = "" Then
                        LibXGrid1.Focus(e.row, 0)
                        Exit Sub
                    End If

                    If mConfig.GetDSCTO > 0 And Me.xtxt_type_code.Text.Trim = "FPV" Then
                        If Val(LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColQty)) > 0 Then
                            oCalcularDscto = New SGT.inventario.entidades.Articulo.ParametrosCalculardescuentos
                            With oCalcularDscto
                                .Almacen = WhDefault
                                .Producto = LibXGrid1.GetValue(e.row, gColitem_code)
                                .Monto = (Val(LibXGrid1.GetValue(e.row, gColPrecio)) * _
                                          Val(LibXGrid1.GetValue(e.row, gColQty)))
                            End With
                            Descuento = oProducto.CalcularDscto(oCalcularDscto)
                            LibXGrid1.SetValue(e.row, gColDescuento, Descuento)
                        End If
                    End If

                    oCalItbis = New SGT.Inventario.Entidades.Articulo.ParametrosCalcularItbis
                    With oCalItbis
                        .Almacen = WhDefault
                        .Producto = LibXGrid1.GetValue(e.row, gColitem_code)
                        .Monto = (Val(LibXGrid1.GetValue(e.row, gColPrecio)) * _
                                  Val(LibXGrid1.GetValue(e.row, gColQty))) - _
                                  Val(LibXGrid1.GetValue(e.row, gColDescuento))
                    End With
                    itbis = Convert.ToDecimal(Math.Round(oProducto.CalcularItbis(oCalItbis), 2))
                    LibXGrid1.SetValue(e.row, gColItbis, itbis)
                End If

                If e.cell = Me.gColQty.Column Or e.cell = Me.gColUnit_code.Column Then
                    If LibXGrid1.GetValue(e.row, gColitem_code) = "" Then
                        LibXGrid1.Focus(e.row, 0)
                        Exit Sub
                    End If
                    If e.cell = Me.gColUnit_code.Column Then
                        If LibXGrid1.GetValue(e.row, gColQty) = "" Then
                            LibXGrid1.Focus(e.row, 2)
                            Exit Sub
                        End If
                    End If

                    If LibX.IsNull(e.value) Then
                        e.hasErrors = True
                        Exit Sub
                    End If

                    If (oDocumento.AfectaOtrosDocumentos = False OrElse oDevolucion.Serial > 0) Then
                        If ValidarCantidad() = False Then
                            Dim Mensaje As String
                            'Me.LibXGrid1.SetValue(e.row, Me.gColQty, LibXGrid1.GetValue(e.row, Me.gColexistencia))
                            If oDocumento.Entrada = True And Me.xtxt_type_code.Text.Trim = "DEV" Then
                                Mensaje = "Esta cantidad excede la cantidad vendida en la factura!"
                            End If
                            If oDocumento.Entrada = False And Me.xtxt_type_code.Text.Trim <> "DEV" Then
                                Mensaje = "No hay existencia suficiente para despachar esta cantidad!"
                            End If
                            Throw New ApplicationException(Mensaje)
                        End If
                    End If
                    If e.cell = Me.gColQty.Column Then
                        SendKeys.Send("{TAB}")
                    End If
                    ''// Saltar Unidad y Descuento
                    If e.cell = Me.gColUnit_code.Column Then
                        SendKeys.Send("{TAB}")
                    End If
                End If

                ''// Validar el descuento
                If e.cell = Me.gColDescuento.Column Then
                    Dim Importe As Decimal

                    Descuento = Val(e.value)

                    If Descuento > 0 Then
                        Importe = Decimal.Round(Val(LibXGrid1.GetValue(e.row, gColPrecio)) * Val(LibXGrid1.GetValue(e.row, gColQty)), 2)

                        If Descuento >= Importe Then
                            Throw New ApplicationException("Descuento no puede ser mayor que el Importe!")
                        End If

                        If (Descuento / Importe) >= 0.3 Then
                            LibXGrid1.SetValue(e.row, gColDescuento, 0)
                            Throw New ApplicationException("Descuento muy alto para este producto!")
                        End If

                        If Val(LibXGrid1.GetValue(e.row, gColdesc_pct).ToString.Trim) > 0 _
                        AndAlso (Descuento / Importe) >= Val(LibXGrid1.GetValue(e.row, gColdesc_pct).ToString.Trim) Then
                            LibXGrid1.SetValue(e.row, gColDescuento, 0)
                            Throw New ApplicationException("Este producto solo aplica para un " & LibXGrid1.GetValue(e.row, gColdesc_pct).ToString.Trim & "% de descuento")
                        End If
                        '// Limpiar permisos Autorizados
                        oAutorizar.PermisosAutorizados.Clear()
                        If (Descuento / Importe) > (oCajera.Porc_Descuento / 100) And Me.xtxt_type_code.Text.Trim <> "DEV" Then
                            ''//EMR

                            oParamValidar.AccessKey = "AD"
                            oAutorizar.PermisosAutorizados.Remove("AD")

                            If oAutorizar.isAutorization(oParamValidar) = False Or (Descuento / Importe) > (oAutorizar.PorcientoDescuento / 100) Then
                                Throw New ApplicationException("Autorización Invalida o descuento no permitido ")
                            End If

                            Me.xtxt_descuento.ForeColor = System.Drawing.Color.Red
                        Else
                            Me.xtxt_descuento.ForeColor = System.Drawing.Color.Black
                        End If
                    End If
                End If

                If e.cell = Me.gColQty.Column Then
                    If Val(e.value) <= 0 Then
                        Throw New ApplicationException("La cantidad debe ser mayor que 0 y menor que la existencia del producto!")
                    End If
                End If

                If e.cell = Me.gColUnit_code.Column Then
                    If e.value.ToString.Trim = "" Then
                        Throw New ApplicationException("La unidad no puede ser nula!")
                    End If
                End If
            End If

        Catch ex As Exception
            e.hasErrors = True
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Function ValidarCantidad() As Boolean
        If LibXGrid1.getCurrentGridView.Count <= 0 Then
            Return True
        End If

        If LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColQty) = "" Then
            Return True
        End If

        If oDocumento.Entrada = True Then
            Dim Cantidad As Integer
            Dim Facturado As Integer
            Dim Unidad As String
            Dim Existencia As Integer
            Dim Result As Boolean = True
            Dim Precio As Decimal
            Dim Descuento As Decimal

            Dim oUnidad As New SGT.Inventario.Entidades.UnidadMedida
            Dim oUnidadParam As New SGT.Inventario.Entidades.UnidadMedida.ParametroConvertirUnidadMinima

            Cantidad = Val(LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColQty).ToString.Trim)
            Unidad = LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColUnit_code).ToString.Trim
            Precio = Val(LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColPrecio).ToString.Trim)
            '//Descuento = Val(LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, Me.gColDescuento).ToString.Trim)

            '// Traer el descuento por unidad del documento
            'Descuento = GetDescuento(oDevolucion.Serial, _
            '                        LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColitem_code))

            'Descuento = Descuento * Cantidad
            If oDevolucion.Serial > 0 Then
                Descuento = CalcularDescuentoDevolver(oDevolucion.Serial, LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColitem_code), _
                                                      Cantidad, Unidad)
            End If
            LibXGrid1.SetValue(LibXGrid1.currentRowNum, Me.gColDescuento, Descuento)


            oUnidadParam.Producto = LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColitem_code)
            oUnidadParam.UnidadOrigen = Unidad
            oUnidadParam.Cantidad = Cantidad
            oUnidadParam.TipoDocumento = xtxt_type_code.Text

            oUnidad.ConvertirUnidadMinima(oUnidadParam)

            Existencia = Val(LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColexistencia).ToString.Trim)

            If oDevolucion.Serial > 0 Then
                Facturado = FindQtyFacturado(oDevolucion.Serial, LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColitem_code))
                If oUnidadParam.Retorno.Cantidad > Facturado Then
                    LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColQty, Facturado)
                    LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColUnit_code, oUnidadParam.Retorno.Unidad)
                    LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColFactor, oUnidadParam.Retorno.Factor)
                    Me.xlk_unit_code.ExecuteFindGrid(Me.LibXGrid1, Me.gColUnit_code.getColumnNumber, oUnidadParam.Retorno.Unidad)

                    Result = False
                End If
                LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColFactor, oUnidadParam.Retorno.Factor)
            End If
            If oUnidadParam.Retorno.Cantidad > Existencia Then
                LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColQty, Existencia)
                LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColUnit_code, oUnidadParam.Retorno.Unidad)
                Me.xlk_unit_code.ExecuteFindGrid(Me.LibXGrid1, Me.gColUnit_code.getColumnNumber, oUnidadParam.Retorno.Unidad)

                Result = False
            End If

            Return Result
        Else
            Return ValidarExistenciaFactura()
        End If
    End Function

    Private Function CalcularDescuentoDevolver(ByVal ftserial_no As Integer, ByVal item_code As String, ByVal qty As Integer, ByVal unidad As String)
        Dim Descuento As Decimal
        Dim DescuentoUnidad As Decimal

        Dim strUnidad As String
        Dim iCantidad As Integer
        Dim oUnidad As New SGT.Inventario.Entidades.UnidadMedida
        Dim oUnidadParam As New SGT.Inventario.Entidades.UnidadMedida.ParametroConvertirUnidadMinima


        Dim oRow As DataRow

        Dim SelectStmt As String

        SelectStmt = "select qty, unit_code, isnull(dscto,0) dscto from ftfactd " & _
                     " where ftserial_no = " & ftserial_no.ToString & _
                     "   and item_code = '" & item_code.Trim & "'"

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oRow Is Nothing Then
            Return 0
        End If

        If oRow!dscto = 0 Then
            Return 0
        End If

        Descuento = oRow!dscto

        strUnidad = oRow!unit_code
        iCantidad = oRow!qty

        '// convertir la unidad vendidad a unidad minima
        oUnidadParam.Producto = item_code
        oUnidadParam.UnidadOrigen = strUnidad
        oUnidadParam.Cantidad = iCantidad

        oUnidad.ConvertirUnidadMinima(oUnidadParam)

        '// calcular desuento por unidad
        DescuentoUnidad = Format(Descuento / oUnidadParam.Retorno.Cantidad, "##,##0.00")

        '// convertir la unidad a devolver a unidad minima
        oUnidadParam.Producto = item_code
        oUnidadParam.UnidadOrigen = unidad
        oUnidadParam.Cantidad = qty

        oUnidad.ConvertirUnidadMinima(oUnidadParam)

        '// calcular desuento a devolver
        DescuentoUnidad = Format(DescuentoUnidad * oUnidadParam.Retorno.Cantidad, "##,##0.00")

        Return DescuentoUnidad
    End Function
    Private Function FindQtyFacturado(ByVal mSerial As Integer, ByVal mItem As String) As Integer
        Dim dCantidad As Integer
        dCantidad = LibX.Data.Manager.GetScalar("select qty from ftfactd where ftserial_no =" & mSerial.ToString & " and item_code ='" & mItem & "'")
        Return dCantidad
    End Function
    Private Function ValidarExistenciaFactura() As Boolean
        Dim Cantidad As Integer
        Dim Unidad As String
        Dim Existencia As Integer
        Dim Result As Boolean = True
        Dim Precio As Decimal
        Dim Descuento As Decimal
        Dim itbis As Decimal

        Dim Costo As Decimal
        Dim Factor As Decimal
        Dim oParam As UnidadMedida.ParametroConvertirValor
        Dim Importe As Decimal

        Try
            If mConfig.FacturaSinExistencia = True Then
                _Exist = True
                Return True
            End If
            _Exist = False
            oAutorizar = New SGT.Administracion.Entidades.Permission

            Dim oUnidad As New SGT.Inventario.Entidades.UnidadMedida
            Dim oUnidadParam As New SGT.Inventario.Entidades.UnidadMedida.ParametroConvertirUnidadMinima

            Cantidad = Val(LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColQty).ToString.Trim)
            Unidad = LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColUnit_code).ToString.Trim
            Precio = Val(LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColPrecio).ToString.Trim)
            Descuento = Val(LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColDescuento).ToString.Trim)

            oUnidadParam.Producto = LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColitem_code)
            oUnidadParam.UnidadOrigen = Unidad
            oUnidadParam.Cantidad = Cantidad

            oUnidad.ConvertirUnidadMinima(oUnidadParam)

            Existencia = Val(LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColexistencia).ToString.Trim)

            If Aumento < Cantidad Then
                mExit = False
            End If

            If oDocumento.AfectaOtrosDocumentos = False OrElse (Not oDevolucion Is Nothing AndAlso oDevolucion.Serial > 0) Then
                If oUnidadParam.Retorno.Cantidad > Existencia And mExit = False Then
                    oParamValidar.AccessKey = Nothing
                    oParamValidar.AccessKey = "VE" '// vender sin existencia
                    If oAutorizar.isAutorization(oParamValidar) = False Then
                        oParam = New UnidadMedida.ParametroConvertirValor

                        oParam.Valor = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColPrecio)
                        oParam.Producto = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColitem_code)
                        oParam.UnidadDestino = oUnidadParam.Retorno.Unidad
                        If mUnid <> "" Then
                            oParam.UnidadOrigen = mUnid
                        Else
                            oParam.UnidadOrigen = oUnidadParam.Retorno.Unidad
                        End If

                        oUnidad.ConvertirValor(oParam)
                        LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, gColPrecio, oParam.Retorno.Valor)
                        LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColQty, Cantidad)
                        LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColUnit_code, oUnidadParam.Retorno.Unidad)
                        Result = False
                    Else
                        _Exist = True
                        mExit = True
                        Aumento = oUnidadParam.Retorno.Cantidad
                    End If
                Else
                    _Exist = True
                End If
            End If

            Return Result

        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Function AbrirCaja() As Boolean
        oParamValidar.AccessKey = "AC" '// Abrir Cajad
        Return oAutorizar.isAutorization(oParamValidar)
    End Function

    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid1.CurrentRowChanged
        Try
            If LibXConnector1.CurrentAction <> LibxConnectionActions.Cancel Then
                If LibXConnector1.IsDataEditing = True And mIsedit = True Then
                    If FindEstadoEspera(LibXConnector1.CurrentDataRow!ftserial_no) = Val(EstatusDocumentosEnum.enEspera) Then
                        Me.btnSetHold.Enabled = (ftfactd.Rows.Count > 0)
                    Else
                        Me.btnSetHold.Enabled = False
                    End If
                Else
                    Me.btnSetHold.Enabled = (ftfactd.Rows.Count > 0)
                End If
                btnCustomer.Enabled = (ftfactd.Rows.Count > 0)
                If _Exist = True Or oDevolucion.Serial > 0 Then
                    CalcularNeto()
                End If

                LibXGrid1.refreshFooter()
            Else
                If LibXConnector1.CurrentAction <> LibxConnectionActions.Cancel Then
                    Me.btnSetHold.Enabled = False
                    If LibXGrid1.GetValue(e.row, gColitem_code) <> "" Then
                        GetVencimiento(LibXGrid1.GetValue(e.row, gColitem_code))
                    End If
                End If
            End If
            Me.Label2.Text = LibXGrid1.CurrentRowIndex + 1

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try

            If oClienteDomicilio.FormaPago = "CXC" Then
                vCliente = New SGT.CXC.Entidades.Cliente(oClienteDomicilio.Codigo)
            End If

            oParamExcede = New SGT.CXC.Entidades.Cliente.ParametrosExcedeLimite

            '// SI ESTA INSERTANDO DOCUMENTOS
            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then
                If LibXGrid1.getCurrentGridView.Count <= 0 Then
                    Throw New ApplicationException("No se puede guardar factura sin detalle!")
                End If
                If Not LibX.IsNull(LibXConnector1.CurrentDataRow!ftserial_no) Then
                    If ValidarDocumento(LibXConnector1.CurrentDataRow!ftserial_no) = True Then
                        Throw New ApplicationException("ESTE DOCUMENTO ESTA COBRADO!")
                    End If
                End If
                '/CalcularNeto()
                '/e.UpdatingArgs.Row!fact_total = Me.xtxt_fact_total.Text

                '// Si es un domicilio validar el monto de devuelto
                If (LibX.IsNull(LibXConnector1.CurrentDataRow!fact_inddomicilio) = False _
                    AndAlso LibXConnector1.CurrentDataRow!fact_inddomicilio = 1) Then
                    If oClienteDomicilio.Cambio > 0 AndAlso oClienteDomicilio.Cambio < Val(Me.xtxt_MontoNeto.Text.Trim) Then
                        Throw New ApplicationException("El cambio del domicilio es menor que el monto de la factura!")
                    End If
                    If oClienteDomicilio.FormaPago = "CXC" Then
                        With oParamExcede
                            .Cliente = oClienteDomicilio.Codigo
                            .MontoAplicar = CDbl(Me.xtxt_MontoNeto.Text)
                        End With
                        If vCliente.ExcedeLimite(oParamExcede) = True Then
                            Throw New ApplicationException("Esta transacción excede el límite de crédito")
                        End If
                    End If
                End If

                '// Si es nulo y esto genera NCF y es una cajera entonces pedir datos para NCF
                If oDocumento.AfectaOtrosDocumentos = False AndAlso LibX.IsNull(e.UpdatingArgs.Row!fact_ncf) AndAlso _
                (Not LibX.IsNull(LibXConnector1.CurrentDataRow!fact_inddomicilio) AndAlso LibXConnector1.CurrentDataRow!fact_inddomicilio = 1 And isDomicilio = False) _
                AndAlso oDocumento.GenerarNCF = True AndAlso e.UpdatingArgs.Row!fact_status <> Val(EstatusDocumentosEnum.enEspera) Then
                    oParametroNCF = New SGT.Facturacion.Entidades.ParametrosCreditoFiscal
                    vCliente = New SGT.CXC.Entidades.Cliente(oClienteDomicilio.Codigo)

                    'oParametroNCF.Serial = e.UpdatingArgs.Row!ftserial_no
                    If WhDefaultNo = 1 Then
                        oParametroNCF.Almacen = WhDefaultNo
                    Else
                        oParametroNCF.Almacen = WhDefault
                    End If

                    'If e.UpdatingArgs.Row!type_code.ToString.Trim = "FSG" Then
                    '    oParametroNCF.Cliente = oAutorizacion.Compania

                    '    If ofctDocumento.AplicarCreditoFiscalSeguro(oParametroNCF) = True Then
                    '        If oParametroNCF.Retorno.Cliente > 0 Then e.UpdatingArgs.Row!cust_serial = oParametroNCF.Retorno.Cliente
                    '        If Not oParametroNCF.Retorno.NCF Is Nothing Then e.UpdatingArgs.Row!fact_ncf = oParametroNCF.Retorno.NCF
                    '    End If
                    'Else
                    oParametroNCF.TipoDocumento = e.UpdatingArgs.Row!type_code
                    oParametroNCF.TipoNcf = vCliente.Ncf
                    oParametroNCF.Cliente = vCliente.Codigo
                    If ofctDocumento.AplicarCreditoFiscal(oParametroNCF) = True Then
                        If oParametroNCF.Retorno.Cliente > 0 Then e.UpdatingArgs.Row!cust_serial = oParametroNCF.Retorno.Cliente
                        If Not oParametroNCF.Retorno.NCF Is Nothing Then e.UpdatingArgs.Row!fact_ncf = oParametroNCF.Retorno.NCF
                    End If
                    'End If
                End If
            End If

            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                If e.UpdatingArgs.Row!fact_time = "" Then
                    e.UpdatingArgs.Row!fact_time = DateTime.Now.ToShortTimeString()
                End If
                '// si se esta enviando a hold no guardar informacion de autorizacion
                If oDocumento.AfectaSeguroMedico = True And LibXConnector1.CurrentDataRow!type_code <> "DEV" Then
                    '// PEDIR AUTORIZACION
                    If oAutorizacion.Autorizacion.Trim = "" AndAlso e.UpdatingArgs.Row!fact_status <> Val(EstatusDocumentosEnum.enEspera) Then
                        If CapturarAutorizacion() = False Then
                            Throw New ApplicationException("Debe registrar los datos de la autorización")
                        End If
                    End If
                    e.UpdatingArgs.Row!seg_amount = oAutorizacion.MontoCobertura
                End If

                '// Si es domicilio, Generar una numeracion

                If e.UpdatingArgs.Row!fact_status = Val(EstatusDocumentosEnum.DomicilioPendiente) And isDomicilio = False Then
                    ''//Para que la numeracion de los documentos se maneje desde un solo almacen
                    If WhDefaultNo = 1 Then
                        e.UpdatingArgs.Row!fact_number = oDocumento.GenerateNumber(e.UpdatingArgs.Row!type_code, WhDefaultNo)
                    Else
                        e.UpdatingArgs.Row!fact_number = oDocumento.GenerateNumber(e.UpdatingArgs.Row!type_code, WhDefault)
                    End If
                    e.UpdatingArgs.Row!init_serial = oCajaAbierta.Serial
                End If
                If e.UpdatingArgs.Row!fact_status = Val(EstatusDocumentosEnum.Pendiente) And isDomicilio = True Then
                    e.UpdatingArgs.Row!init_serial = oCajaAbierta.Serial
                End If

                If e.UpdatingArgs.Row!fact_total < 0 Then
                    Throw New ApplicationException("No se puede grabar documento con valor negativo")
                End If

                e.UpdatingArgs.Row!whse_code = LibX.User.WhDefault
                e.UpdatingArgs.Row!suc_code = LibX.User.Sucursal
                e.UpdatingArgs.Row!fact_create = LibX.Data.Manager.GetScalar("select getdate()")
                If oClienteDomicilio.FormaPago = "CXC" Then
                    e.UpdatingArgs.Row!fact_cond = 2 'TODO Condicion verificar
                Else
                    e.UpdatingArgs.Row!fact_cond = 1 'TODO Condicion verificar
                End If

                If oDocumento.AfectaOtrosDocumentos = True Then
                    e.UpdatingArgs.Row!fact_cond = Val(oDevolucion.Condicion)
                    If oDevolucion.Serial > 0 Then e.UpdatingArgs.Row!ftserial_afect = oDevolucion.Serial
                    If Not oDevolucion.Motivo Is Nothing Then e.UpdatingArgs.Row!dev_type = oDevolucion.Motivo
                    If Not oDevolucion.Observacion Is Nothing Then e.UpdatingArgs.Row!fact_nota = oDevolucion.Observacion
                    If oDevolucion.Cliente > 0 Then e.UpdatingArgs.Row!cust_code = oDevolucion.Cliente
                    'If oDevolucion.MontoSeguro > 0 Then e.UpdatingArgs.Row!seg_amount = oDevolucion.MontoSeguro
                End If

                If oClienteDomicilio.Codigo > 0 Then e.UpdatingArgs.Row!cust_code = oClienteDomicilio.Codigo

                If LibX.IsNull(e.UpdatingArgs.Row!fact_date) Then e.UpdatingArgs.Row!fact_date = CajaAbierta.Fecha
                If Me.xtxt_type_code.Text = "DEV" And mTotalSeguro > 0 Then
                    If Me.xtxt_fact_total.Text = mTotalFacturadoSeguro And LibXConnector1.CurrentDataRow!seg_amount <> mTotalSeguro Then
                        e.UpdatingArgs.Row!seg_amount = mTotalSeguro
                    End If
                End If
            End If

            '// SI ESTA ACTUALIZANDO, (SOLO ACTUALIZA DOCUMENTOS DE HOLD)
            If e.UpdatingArgs.StatementType = StatementType.Update Then
                '// si se esta enviando a hold no guardar informacion de autorizacion
                If oDocumento.AfectaSeguroMedico = True And LibXConnector1.CurrentDataRow!type_code <> "DEV" Then
                    '// PEDIR AUTORIZACION
                    If e.UpdatingArgs.Row!fact_status <> Val(EstatusDocumentosEnum.enEspera) Then
                        If CapturarAutorizacion() = False Then
                            Throw New ApplicationException("Debe registrar los datos de la autorización")
                        End If
                    End If
                    e.UpdatingArgs.Row!seg_amount = oAutorizacion.MontoCobertura
                End If

                '// Si es domicilio y no se ha asignado el numero, generarlo
                If e.UpdatingArgs.Row!fact_status = Val(EstatusDocumentosEnum.DomicilioPendiente) And LibX.IsNull(e.UpdatingArgs.Row!fact_number) And isDomicilio = False Then
                    If WhDefaultNo = 1 Then
                        e.UpdatingArgs.Row!fact_number = oDocumento.GenerateNumber(e.UpdatingArgs.Row!type_code, WhDefaultNo)
                    Else
                        e.UpdatingArgs.Row!fact_number = oDocumento.GenerateNumber(e.UpdatingArgs.Row!type_code, WhDefault)
                    End If
                    e.UpdatingArgs.Row!init_serial = oCajaAbierta.Serial
                End If

                e.UpdatingArgs.Row!fact_nota = DBNull.Value
                e.UpdatingArgs.Row!whse_code = LibX.User.WhDefault
                e.UpdatingArgs.Row!suc_code = LibX.User.Sucursal
                If oClienteDomicilio.FormaPago = "CXC" Then
                    e.UpdatingArgs.Row!fact_cond = 2 'TODO Condicion verificar
                Else
                    e.UpdatingArgs.Row!fact_cond = 1 'TODO Condicion verificar
                End If

                If oDocumento.AfectaOtrosDocumentos = True And oDevolucion.Serial > 0 Then
                    e.UpdatingArgs.Row!fact_cond = Val(oDevolucion.Condicion)
                    e.UpdatingArgs.Row!ftserial_afect = oDevolucion.Serial
                    e.UpdatingArgs.Row!dev_type = oDevolucion.Motivo
                    'If oDevolucion.MontoSeguro > 0 Then e.UpdatingArgs.Row!seg_amount = oDevolucion.MontoSeguro                    
                    'e.UpdatingArgs.Row!fact_nota = oDevolucion.Observacion
                End If

                If oClienteDomicilio.Codigo > 0 Then e.UpdatingArgs.Row!cust_code = oClienteDomicilio.Codigo
                If LibX.IsNull(e.UpdatingArgs.Row!fact_date) Then e.UpdatingArgs.Row!fact_date = CajaAbierta.Fecha
            End If

            '// SI SE ESTA BORRANDO ANULAR EL DOCUMENTO, NO BORRARLO
            If e.UpdatingArgs.StatementType = StatementType.Delete Then
                If e.UpdatingArgs.Row.Item("fact_status", DataRowVersion.Original) <> Val(EstatusDocumentosEnum.enEspera) Then  '// HOLD 
                    e.UpdatingArgs.Status = UpdateStatus.SkipAllRemainingRows
                    AnularDocumento(e.UpdatingArgs.Row)
                End If
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub EliminarDominicio(ByVal pftserial_no As Integer)
        Dim Xdelete As LibX.Data.XDeleteStmt

        Xdelete = New LibX.Data.XDeleteStmt("ftdomim")
        Xdelete.Fields("ftserial_no") = pftserial_no
        Xdelete.Execute()

    End Sub

    Private Function GetDescuento(ByVal p_ftserial As Integer, ByVal p_item_code As String) As Decimal
        Dim Desc As Decimal
        Dim SelectStmt As String

        SelectStmt = "select ISNULL(dscto,0)/qty from ftfactd " & _
                     " where ftserial_no = " & p_ftserial.ToString.Trim & _
                     "   and ftfactd.item_code = '" & p_item_code.ToString.Trim & "'"

        Desc = LibX.Data.Manager.GetScalar(SelectStmt)

        Return Desc
    End Function

    Private Sub CalcularNeto()
        Dim MontoBruto As Decimal = 0.0
        Dim Descuento As Decimal = 0.0
        Dim Itbis As Decimal = 0.0
        Dim MontoNeto As Decimal = 0.0
        Dim MontoSeguro As Decimal = 0.0

        Try
            If Me.ftfactd.Rows.Count <= 0 Then
                Exit Sub
            End If

            MontoBruto = Val(ftfactd.Compute("sum(Importe)", "1=1").ToString.Trim) _
                       + Val(ftfactd.Compute("sum(dscto)", "1=1").ToString.Trim) _
                       - Val(ftfactd.Compute("sum(itbis)", "1=1").ToString.Trim)

            Itbis = Val(ftfactd.Compute("sum(itbis)", "1=1").ToString.Trim)

            'xtxt_fact_total.Text = MontoBruto.ToString("###,##0.00")
            mBruto = Val(ftfactd.Compute("sum(net_amt)", "1=1").ToString.Trim)
            xtxt_fact_total.Text = mBruto.ToString("###,##0.00")


            '// Calcular el Seguro
            If LibXConnector1.IsDataEditing = True AndAlso oDocumento.AfectaSeguroMedico = True Then
                If Me.xtxt_type_code.Text = "DEV" And mPolizaAsegurado <> Nothing Then
                    CalcularSeguro()
                Else
                    If Me.xtxt_type_code.Text <> "DEV" Then
                        CalcularSeguro()
                    End If
                End If
                If Val(Me.xtxt_seg_amount.Text) > 0 Then
                    Me.btnSeguro.Enabled = False ''True
                End If
            End If

            '// Descuento
            Descuento = Val(ftfactd.Compute("sum(dscto)", "1=1").ToString.Trim)
            If Descuento < 0 Then
                Descuento = 0
            End If

            '// Seguro
            If Me.xtxt_seg_amount.Text.Trim <> "" Then
                MontoSeguro = CDbl(Me.xtxt_seg_amount.Text)
            End If

            MontoNeto = ((MontoBruto - Descuento) + Itbis) - MontoSeguro

            Me.xtxt_descuento.Text = Descuento.ToString("###,###,##0.00")
            Me.xtxt_MontoNeto.Text = MontoNeto.ToString("###,###,##0.00")
            Me.xtxt_itbis.Text = Itbis.ToString("###,###,##0.00")

        Catch ex As Exception
            'Throw
        End Try
    End Sub
    Private Sub CalcularSeguro()
        Try
            Dim oParamSeguro As New SGT.PuntodeVenta.Entidades.ParametroCalcular
            Dim oSeguro As New SGT.PuntodeVenta.Entidades.SegurosMedicos

            Dim MontoSeguro As Decimal

            If ftfactd.Rows.Count > 0 Then
                MontoSeguro = Val(ftfactd.Compute("sum(importe)", "1=1").ToString.Trim) _
                            + Val(ftfactd.Compute("sum(dscto)", "1=1").ToString.Trim)

                ''If oAutorizacion.MontoCobertura > 0 Then
                ''    oParamSeguro.Retorno.Valor_Cobertura = oAutorizacion.MontoCobertura
                ''End If

                oParamSeguro.Monto = MontoSeguro
                oParamSeguro.Poliza = oClienteAsegurado.Poliza
                oParamSeguro.Compania = oClienteAsegurado.CompaniaID

                '// Calcular
                If oSeguro.CalcularCobertura(oParamSeguro) = True Then
                    Me.xtxt_seg_amount.Text = oParamSeguro.Retorno.Valor_Cobertura.ToString("###,###,##0.00")
                    LibXConnector1.CurrentDataRow!seg_amount = oAutorizacion.MontoCobertura

                    If oParamSeguro.Retorno.Valor_Descuento > 0 Then
                        Me.xtxt_descuento.Text = 0
                        Distribuye_descuento()

                        Me.xtxt_descuento.Text = oParamSeguro.Retorno.Valor_Descuento.ToString("###,###,##0.00")
                        Distribuye_descuento(oParamSeguro.Retorno.Porc_Descuento, oParamSeguro.Retorno.Porc_Cobertura)
                    End If
                Else
                    Me.xtxt_descuento.Text = 0
                    Distribuye_descuento()
                End If
            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub btnCobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCobrar.Click
        Dim oParam As LibX.LibxPrgParams
        Dim oHold As i_fthold01
        Dim oFactura As i_fthold01.sFactura

        Try
            oBloqueoDocumento = New SGT.PuntodeVenta.Entidades.BloqueoFactua

            oParam = New LibX.LibxPrgParams
            oHold = New i_fthold01
            oFactura = New i_fthold01.sFactura

            With oParam
                If WhDefault > 0 Then
                    .Datos.Add("whse_code", LibX.User.WhDefault)
                End If
                If oCajaAbierta.CajaCode > 0 Then
                    .Datos.Add("caja_code", oCajaAbierta.CajaCode)
                End If

                If oCajaAbierta.CajeraCode > 0 Then
                    .Datos.Add("caje_code", oCajaAbierta.CajeraCode)
                End If

                If oCajaAbierta.CajeraCode > 0 Then
                    .Datos.Add("domicilio", 0)
                End If
                If oCajaAbierta.CajeraCode > 0 Then
                    .Datos.Add("cobro", 1)
                End If
                If WhDefaultNo = 1 Then
                    .Datos.Add("WhDefaultNo", WhDefaultNo)
                End If

                .WhereToExecute = "ftfactm.type_code in  ('FPV','FSG','RCE','DEV','FTS','EST') and ftfactm.fact_status = " & Val(EstatusDocumentosEnum.Pendiente).ToString & " and ftfactm.whse_code = " & WhDefault
            End With

            LibX.App.CurrentPrgParams = oParam
            oHold.FacturaSelected = oFactura

            oHold.Text = "Documentos Pendientes por Cobrar"
            oHold.PicCobro.Visible = True
            oHold.picEspera.Visible = False
            If oHold.ShowDialog(Me) = DialogResult.Yes Then
                '// LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & oFactura.Serial.ToString)
                If oFactura.Serial > 0 Then
                    If ValidarEstadoCaja(oCajaAbierta.Serial) = False Then
                        Throw New ApplicationException("Esta caja ha sido cerrada y no puede cobrar")
                    End If
                    '//    If LibXConnector1.HasRecords = True Then
                    '//Si el documento se va a cobrar verificar que no se este editando
                    If oBloqueoDocumento.BuscarBloqueo(oFactura.Serial, oFactura.Type) = True Then
                        Throw New ApplicationException("Este Documento lo estan modificando o cobrando!")
                    Else
                        CobrarDocumento(oFactura.Serial, oFactura.Type)
                    End If
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Function CobrarDocumento(ByVal pserial_no As Integer, ByVal typeCode As String) As Boolean
        Dim oUpdate As LibX.Data.XUpdateStmt
        Dim mFontofactura As SGT.PuntodeVenta.Entidades.MontoFactura
        Dim op As New LibxPrgParams
        Try
            '// Cambiar la caja y la cajera a la caja actual
            oUpdate = New LibX.Data.XUpdateStmt("ftfactm")

            oUpdate.FieldsSet("caja_code") = oCajaAbierta.CajaCode
            oUpdate.FieldsSet("caje_code") = oCajaAbierta.CajeraCode
            oUpdate.FieldsSet("fact_date") = oCajaAbierta.Fecha
            oUpdate.Fields("ftserial_no") = pserial_no

            oUpdate.Execute()
            oUpdate.Dispose()

            oBloqueoDocumento = New SGT.PuntodeVenta.Entidades.BloqueoFactua
            mFontofactura = New SGT.PuntodeVenta.Entidades.MontoFactura(pserial_no)

            oDocumento = New SGT.Inventario.Entidades.Documento(typeCode)

            '// buscar el documento
            LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & pserial_no.ToString.Trim & " and ftfactm.suc_code = " & LibX.User.Sucursal)
            If oBloqueoDocumento.BuscarBloqueo(LibXConnector1.CurrentDataRow!ftserial_no, LibXConnector1.CurrentDataRow!type_code) = False Then
                oBloqueoDocumento.BloquearDocumento(pserial_no, typeCode)
            End If

            If mFontofactura.MontoNeto <> mFontofactura.MontoFactura Then
                Dim XUpdate As New LibX.Data.XUpdateStmt("ftfactm")
                XUpdate.FieldsSet("fact_total") = mFontofactura.MontoBruto
                XUpdate.Fields("ftserial_no") = pserial_no.ToString.Trim
                XUpdate.Execute()
            End If

            '// Si es una devolucion
            If oDocumento.AfectaOtrosDocumentos = True Then
                '// Cobrar Devoluciones
                oParamValidar.AccessKey = "CD"
                oAutorizar.PermisosAutorizados.Remove("CD")

                If oAutorizar.isAutorization(oParamValidar) = False Then
                    Throw New ApplicationException("Autorización Invalida")
                End If
            End If

            op.IsFromOther = True
            op.initMode = LibxInitModes.Edit
            op.WhereToExecute = "ftfactm.ftserial_no = " & pserial_no.ToString.Trim & " and ftfactm.suc_code = " & LibX.User.Sucursal
            App.CurrentPrgParams = op

            LibX.LibXRunner.Run("i_cjfact01", "CAJ", True)

            '// refrescar el documento
            LibXConnector1.CurrentDataRow.Row.RejectChanges()
            LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & pserial_no.ToString.Trim & " and ftfactm.suc_code = " & LibX.User.Sucursal)

        Catch ex As Exception
            Throw
        Finally
            oBloqueoDocumento.BorrarBloqueo(pserial_no, typeCode)
        End Try
    End Function

    Private Sub AnularDocumento(ByVal oRow As DataRow)
        Dim oPost As SGT.Facturacion.Operaciones.PosteoDocumento
        Dim oParam As SGT.Facturacion.Operaciones.PosteoDocumento.Parametros
        Dim Xupdate As LibX.Data.XUpdateStmt

        Try
            oPost = New SGT.Facturacion.Operaciones.PosteoDocumento
            oParam = New SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

            With oParam
                .SerialNumero = oRow.Item("ftserial_no", DataRowVersion.Original)
                .ApliarComision = True
                .AplicarCXC = True
                .AplicarInventario = True
                .Completo = True
                .UseTransaction = False
                .initCaja = oCajaAbierta.CajaCode
                .InitCaje = oCajaAbierta.CajeraCode
                .InitSerial = oCajaAbierta.Serial
            End With

            oPost.Anular(oParam)

        Catch ex As Exception
            Throw

        End Try
    End Sub

    Private Sub AplicarInventario(ByVal pftserial_no As Integer)
        Dim oPostDoc As SGT.Facturacion.Operaciones.PosteoDocumento
        Dim oPostParam As SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

        Try
            oPostDoc = New SGT.Facturacion.Operaciones.PosteoDocumento
            oPostParam = New SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

            oPostParam.SerialNumero = pftserial_no
            oPostParam.UseTransaction = True
            oPostParam.AplicarInventario = True
            oPostParam.AplicarCXC = False
            oPostParam.ApliarComision = True

            oPostDoc.Aplicar(oPostParam)

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub i_ptvfact01_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Try

            '// Si se esta registrando un documento y ya se especificaron productos
            '// puede grabar y cobrar o poner en hold
            If e.KeyCode = Keys.F9 Then
                '''If oCajera.esCajera = True AndAlso mCaja = True Then
                If mCaja = True Then
                    '// Guardar los datos
                    btnCobrar_Click(sender, New EventArgs)
                End If
            End If
            If e.KeyCode = Keys.F8 Then
                ''If oCajera.esCajera = True AndAlso mCaja = True Then
                If mCaja = True Then
                    '// Guardar los Domicilio pendientes
                    btnDomicilios_Click(sender, New EventArgs)
                End If
            End If

            '//llevar el cursor al descuento 

            If LibXConnector1.HasRecords = True AndAlso _
            LibXConnector1.IsDataEditing = False AndAlso _
            (Me.xcbo_fact_status.currValue.ToString.Trim = Val(EstatusDocumentosEnum.Pendiente).ToString _
            OrElse Me.xcbo_fact_status.currValue.ToString.Trim = Val(EstatusDocumentosEnum.DomicilioPendiente).ToString) Then
                '// F10 = Poner en Hold
                If e.KeyCode = Keys.F10 Then
                    Me.btnSetHold_Click(sender, New EventArgs)
                End If
            End If
            '// F11 = Traer registros en Hold 
            If e.KeyCode = Keys.F11 Then
                If LibXConnector1.IsDataEditing = False Then
                    Me.btnFreeHold_Click(sender, New EventArgs)
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xtxt_descuento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_descuento.Validating
        Dim MontoBruto As Decimal
        Dim Descuento As Decimal
        Dim Porc_Descuento As Integer
        Dim PorcVend As Decimal
        Try

            If Me.xtxt_fact_total.Text.Trim = "" Then
                If Val(Me.xtxt_descuento.Text.Trim) > 0 Then
                    e.Cancel = True
                End If

                Exit Sub
            End If

            If Me.xtxt_descuento.Text.Trim = "" Then
                Exit Sub
            End If

            MontoBruto = Val(ftfactd.Compute("sum(importe)", "aplica_dscnt=1").ToString.Trim) - _
                         Val(ftfactd.Compute("sum(itbis)", "aplica_dscnt=1").ToString.Trim) + _
                         Val(ftfactd.Compute("sum(dscto)", "aplica_dscnt=1").ToString.Trim)

            If MontoBruto <= 0 Then
                Throw New ApplicationException("No hay productos que apliquen para descuento!")
                Exit Sub
            End If

            If xtxt_descuento.Text.EndsWith("%") Then
                Porc_Descuento = Val(Me.xtxt_descuento.Text.Substring(0, xtxt_descuento.Text.IndexOf("%")).Trim)
                mDescuentoDado = Porc_Descuento
                Descuento = Decimal.Round(MontoBruto * (Porc_Descuento / 100), 3)
                Me.xtxt_descuento.Text = Descuento
            Else
                Descuento = Me.xtxt_descuento.Text
            End If

            If (Descuento > MontoBruto) Then
                Throw New ApplicationException("Descuento no puede ser mayor q el monto total del documento!")
            End If

            '//EMR
            If (Descuento / MontoBruto) >= 0.75 Then
                Throw New ApplicationException("Descuento muy alto para este documento!")
            End If
            '// Limpiar permisos Autorizados
            oAutorizar.PermisosAutorizados.Clear()

            If (Descuento / MontoBruto) > (oCajera.Porc_Descuento / 100) And Me.xtxt_type_code.Text.Trim <> "DEV" Then
                oParamValidar.AccessKey = "AD"
                oAutorizar.PermisosAutorizados.Remove("AD")

                If oAutorizar.isAutorization(oParamValidar) = False Or (Descuento / MontoBruto) > (oAutorizar.PorcientoDescuento / 100) Then
                    Me.xtxt_descuento.Text = 0
                    Descuento = 0
                    Throw New ApplicationException("Autorización Invalida o descuento no permitido")
                End If
                '//Me.xtxt_descuento.ForeColor = System.Drawing.Color.Red
            Else
            '//Me.xtxt_descuento.ForeColor = System.Drawing.Color.Black
            End If

        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
            Me.xtxt_descuento.Text = ""
        End Try
    End Sub

    Private Sub xlk_type_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_type_code.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            oDocumento = New SGT.Inventario.Entidades.Documento(e.row!type_code.ToString.Trim)

            If LibXConnector1.IsDataEditing = True Then
                Me.xchk_domicilio.ReadOnly = False
                Me.xchk_domicilio.Enabled = True

                Me.xtxt_descuento.Enabled = True
                Me.xtxt_descuento.BackColor = System.Drawing.SystemColors.Window
                Me.gColDescuento.ReadOnly = False
                Me.gColDescuento.isReadOnly = False
                Me.xtxt_bus_name.Enabled = True
                Me.btnSeguro.Enabled = False

                ftsegrm.Rows.Clear()

                '// Domicilios
                If oDocumento.AfectaDomicilio = False Then
                    Me.xchk_domicilio.ReadOnly = True
                    Me.xchk_domicilio.Enabled = False
                End If

                '// Devolucion
                If oDocumento.AfectaOtrosDocumentos = True Then
                    '// No permitir descuentos en el detalle
                    Me.xtxt_descuento.Enabled = False
                    Me.xtxt_descuento.BackColor = System.Drawing.SystemColors.Control
                    Me.gColDescuento.ReadOnly = True
                    Me.gColDescuento.isReadOnly = True
                End If

                '// Afecta seguro medico
                If oDocumento.AfectaSeguroMedico = True Then
                    '// No permitir descuentos en el detalle
                    Me.xtxt_descuento.Enabled = False
                    Me.xtxt_descuento.BackColor = System.Drawing.SystemColors.Control
                    Me.gColDescuento.ReadOnly = True
                    Me.gColDescuento.isReadOnly = True

                    '// Boton de Capturar Autorizacion
                    If Val(Me.xtxt_seg_amount.Text) > 0 Then
                        Me.btnSeguro.Enabled = False ''true
                    End If
                Else
                    Me.xtxt_seg_amount.Text = ""
                End If

                If oDocumento.AutoImprimir = True Then
                    LibXConnector1.ReportObject.Destination = Crystal.DestinationConstants.crptToPrinter '// Imprimir Directo
                End If
            End If
            If Me.xtxt_type_code.Text <> "" And LibXConnector1.IsDataEditing = True Then
                Me.xtxt_type_code.Enabled = False
                Me.xlk_type_code.Enabled = False
            Else
                Me.xtxt_type_code.Enabled = True
                Me.xlk_type_code.Enabled = True
            End If
            If Me.xtxt_type_code.Text = "DEV" Or Me.xtxt_type_code.Text = "FSG" Then
                Me.xtxt_descuento.Enabled = False
            Else
                Me.xtxt_descuento.Enabled = True
            End If
            If Me.xtxt_type_code.Text = "DEV" Or Me.xtxt_type_code.Text = "FSG" Then
                Me.gColDescuento.isReadOnly = True
                Me.gColDescuento.ReadOnly = True
            Else
                Me.gColDescuento.isReadOnly = False
                Me.gColDescuento.ReadOnly = False
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub xlk_Cliente_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xkl_cliente.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Function PedirCliente() As Boolean
        Dim Retorno As Boolean = True
        Dim oParam As LibX.LibxPrgParams
        Try
            If Not oDocumento Is Nothing Then
                If Me.xchk_domicilio.Checked = True Then
                    Retorno = ClienteDomicilio(LibxConnectorState.Edit)
                Else
                    If oDocumento.AfectaOtrosDocumentos = True Then
                        Dim oFact03 As New i_ptvfact03

                        oParam = New LibX.LibxPrgParams

                        If LibX.IsNull(LibXConnector1.CurrentDataRow!ftserial_no) = False Then
                            oParam.WhereToExecute = "ftfactm.ftserial_no = " & LibXConnector1.CurrentDataRow!ftserial_no.ToString.Trim
                            oParam.initMode = LibxInitModes.Edit
                        Else
                            oParam.initMode = LibxInitModes.Insert
                        End If

                        LibX.App.CurrentPrgParams = oParam

                        If oFact03.ShowDialog(oDevolucion) = DialogResult.OK Then
                            If Val(LibXConnector1.CurrentDataRow!ftserial_no.ToString.Trim) > 0 Then
                                Me.lbl_AditionalInformation.Text = opvDocumento.GetAditionalInformation(Documentos.TiposDocumentosEnum.Devoluciones, LibXConnector1.CurrentDataRow!ftserial_no)
                            Else
                                Me.lbl_AditionalInformation.Text = IIf(oDevolucion.TipoDocumento Is Nothing, "", "TIPO: " & oDevolucion.TipoDocumento) & _
                                                                    IIf(oDevolucion.NumeroDocumento <= 0, "", ", NUMERO:" & oDevolucion.NumeroDocumento.ToString.Trim & vbCrLf) & _
                                                                    IIf(oDevolucion.FechaDocumento = #12:00:00 AM#, "", "FECHA: " & oDevolucion.FechaDocumento.ToString("dd/MM/yyyy")) & _
                                                                    IIf(oDevolucion.ValorDocumento <= 0, "", ", MONTO:" & oDevolucion.ValorDocumento.ToString("###,##0.00") & vbCrLf) & _
                                                                    IIf(oDevolucion.MontoSeguro <= 0, "", ", SEGURO:" & oDevolucion.MontoSeguro.ToString("###,##0.00") & vbCrLf) & _
                                                                    "MOTIVO:" & oDevolucion.NombreMotivo.Trim & vbCrLf & _
                                                                    "CLIENTE: " & oDevolucion.NombreCliente.ToString.Trim
                            End If
                            Me.xtxt_bus_name.Text = oDevolucion.NombreCliente.ToString.Trim
                            ''If Val(LibXConnector1.CurrentDataRow!ftserial_no.ToString.Trim) > 0 Then
                            If oDevolucion.Poliza.ToString.Trim <> "" Then
                                mPolizaAsegurado = oDevolucion.Poliza.ToString.Trim
                                mTotalSeguro = oDevolucion.MontoSeguro
                                mTotalFacturadoSeguro = oDevolucion.ValorDocumento
                            Else
                                mTotalSeguro = 0
                            End If
                            ''End If
                            Retorno = True
                        Else
                            Retorno = False
                        End If
                    End If

                    If oDocumento.AfectaSeguroMedico = True And LibXConnector1.CurrentDataRow!type_code = "DEV" And Not LibX.IsNull(mPolizaAsegurado) Then
                        oClienteAsegurado.Poliza = oDevolucion.Poliza.ToString.Trim
                        oClienteAsegurado.Load()
                    Else
                        If oDocumento.AfectaSeguroMedico = True And LibXConnector1.CurrentDataRow!type_code <> "DEV" Then
                            Dim oFact05 As New i_ptvfact05

                            oParam = New LibX.LibxPrgParams
                            If oClienteAsegurado.Poliza.Trim = "" Then
                                oParam.initMode = LibxInitModes.Insert
                            Else
                                oParam.WhereToExecute = "sgasegm.aseg_poliza = '" & oClienteAsegurado.Poliza.Trim & "'"
                                oParam.initMode = LibxInitModes.Edit
                            End If

                            LibX.App.CurrentPrgParams = oParam

                            If oFact05.ShowDialog(oClienteAsegurado) = DialogResult.OK Then
                                If oClienteAsegurado.Apellidos <> "" Then
                                    Me.xtxt_bus_name.Text = oClienteAsegurado.Nombre.Trim & " " & oClienteAsegurado.Apellidos.Trim
                                Else
                                    Me.xtxt_bus_name.Text = oClienteAsegurado.Nombre.Trim
                                End If
                                Me.lbl_AditionalInformation.Text = opvDocumento.GetAditionalInformation(Documentos.TiposDocumentosEnum.SegurosMedicos, oClienteAsegurado.Poliza)
                                Me.xtxt_bus_name.Enabled = False
                                Retorno = True
                            Else
                                Retorno = False
                            End If
                        End If
                    End If
                End If
            End If

            Me.btnCustomer.Enabled = Retorno
            Return Retorno

        Catch ex As Exception
            Throw
        End Try
    End Function
    ''Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
    ''    Try
    ''        If Not LibX.IsNull(xdt_fact_date.Value) Then
    ''            e.AditionalWhere = String.Concat(e.AditionalWhere, "ftfactm.fact_date = '" & Me.xdt_fact_date.Value) & "'"
    ''        End If
    ''        If Not LibX.IsNull(Me.xtxt_caja_code.Text) Then
    ''            e.AditionalWhere = String.Concat(e.AditionalWhere, "ftfactm.caja_code = " & Me.xtxt_caja_code.Text)
    ''        End If
    ''        If Not LibX.IsNull(Me.xtxt_caja_code.Text) Then
    ''            e.AditionalWhere = String.Concat(e.AditionalWhere, "ftfactm.caje_code = " & Me.xtxt_caje_code.Text)
    ''        End If
    ''        If Not LibX.IsNull(Me.xcbo_fact_status.SelectedValue) Then
    ''            e.AditionalWhere = String.Concat(e.AditionalWhere, "ftfactm.fact_status = " & Me.xcbo_fact_status.SelectedValue)
    ''        End If
    ''        e.Sql = LibX.ConcatWherePart(Join(Me.xdt_ftfactm.Source, " "), e.AditionalWhere)
    ''        e.Sql = String.Concat(e.Sql, " ORDER BY ftfactm.ftserial_no")
    ''    Catch ex As Exception
    ''        LibX.Log.Add(ex, True)
    ''    End Try
    ''End Sub

    Private Sub xlk_item_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_item_code.BeforeExecuteQuery
        Try
            If LibXConnector1.IsDataEditing = True Then
                If oDocumento.AfectaOtrosDocumentos = True AndAlso oDevolucion.Serial > 0 Then
                    e.SQL = "select DISTINCT ftfactd.item_code,ftfactd.suc_code, " & _
                            "item_name, ftfactd.unit_code,ftfactd.factor, " & _
                            "ftfactd.price, dbo.uf_PendienteDevolver(ftfactd.ftserial_no,ftfactd.item_code,{0}) existencia, " & _
                            "ubicacion, ivitemv1.prov_code, aplica_dscnt,isnull(prd_controlado,0)prd_controlado ," & _
                            "costo purch_cost, prov_name,brand_name, ftfactd.dscto, ftfactd.price+ftfactd.itbis precioitbis,0 disc_pct,sustancias from ivitemv1" & _
                            " inner join ftfactd on ivitemv1.item_code = ftfactd.item_code " & _
                            " and ivitemv1.whse_code = ftfactd.whse_code " & _
                            " and dbo.uf_PendienteDevolver(ftfactd.ftserial_no,ftfactd.item_code,{0}) > 0 " & _
                            " left outer join cpprovm " & _
                            " on cpprovm.prov_code = ivitemv1.prov_code" & _
                            " left outer join ivbrandm " & _
                            " on ivbrandm.brand_code = ivitemv1.brand_code" & _
                            " left outer join ivcbarram " & _
                            " on ivcbarram.item_code = ivitemv1.item_code" & _
                            " AND ivitemv1.unit_code = ivcbarram.unit_code "

                    e.SQL = LibX.ConcatWherePart(e.SQL, e.wherePart)
                    e.aditionalWhere = "ftfactd.ftserial_no = " & oDevolucion.Serial.ToString
                    e.SQL = String.Format(e.SQL, IIf(LibXConnector1.CurrentAction = LibxConnectionActions.Edit, _
                                                    LibXConnector1.CurrentDataRow!ftserial_no, -1))
                Else
                    e.aditionalWhere = "ivitemv1.whse_code = " & LibX.User.WhDefault.ToString

                    If LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColitem_code).Trim = "" Then
                        e.handled = True
                        Exit Sub
                    End If

                End If

                If Len(LibXGrid1.GetValue(gColitem_code).Trim) >= 8 And IsNumeric(LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColitem_code).Trim) Then
                    e.SQL = e.SQL.Replace("ivitemv1.item_code = '", "ivcbarram.barra = '")
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub xchk_domicilio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xchk_domicilio.CheckedChanged
        Try
            If LibXConnector1.IsDataEditing = True _
            AndAlso (LibXConnector1.CurrentAction = LibxConnectionActions.Add _
            OrElse LibXConnector1.CurrentAction = LibxConnectionActions.Edit) Then
                If Me.xtxt_type_code.Text <> "FSG" Then
                    If Me.xchk_domicilio.Checked = True Then
                        Me.xtxt_bus_name.Enabled = False
                        Me.btnCustomer.Enabled = ClienteDomicilio(LibxConnectorState.Insert)
                        Me.xchk_domicilio.Refresh()
                        Me.LibXGrid1.Focus()
                    Else
                        Me.xcbo_fact_status.currValue = Val(EstatusDocumentosEnum.Pendiente)  '// Pendiente
                        Me.xtxt_bus_name.Enabled = True
                        oClienteDomicilio = Nothing
                        oClienteDomicilio = New ClienteDomicilio
                        Me.xtxt_bus_name.Text = String.Empty
                        lbl_AditionalInformation.Text = String.Empty
                        btnCustomer.Enabled = False
                    End If
                End If
            Else
                Me.xchk_domicilio.Checked = True
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Function ClienteDomicilio(ByVal pModo As LibX.LibxConnectorState, Optional ByVal pphone As String = "") As Boolean
        Dim oParamProgram As New LibX.LibxPrgParams
        Dim oFact04 As i_ptvfact04
        Dim Retorno As Boolean = False
        Dim TotalFacturado As Decimal
        Dim TotalDescuento As Decimal

        Try
            If Me.xchk_domicilio.Checked = False Then
                Me.xtxt_bus_name.Enabled = True
                Return False
            End If

            oParamProgram.AllowDelete = False
            oParamProgram.AllowEdit = True
            oParamProgram.AllowNew = True
            oParamProgram.AllowQuery = True
            oParamProgram.IsFromOther = True
            oParamProgram.initMode = pModo

            If oClienteDomicilio.Ftserial.ToString = 0 And oClienteDomicilio.Codigo > 0 And pModo = LibxConnectorState.Insert Then
                oClienteDomicilio.Codigo = 0
            End If

            If oClienteDomicilio.Codigo <= 0 Then
                oParamProgram.initMode = LibxInitModes.Insert
            Else
                oParamProgram.initMode = LibxInitModes.Edit
                If LibX.IsNull(LibXConnector1.CurrentDataRow!ftserial_no.ToString.Trim) Then
                    oParamProgram.WhereToExecute = "cccustm.cust_code = " & _
                    oClienteDomicilio.Codigo.ToString.Trim() '& " and pvtarjeta.tarj_code = " & oClienteDomicilio.TarjetaCodigo.ToString()\
                Else
                    oParamProgram.WhereToExecute = "cccustm.cust_code = " & _
                   oClienteDomicilio.Codigo.ToString.Trim() & " and ftdomim.ftserial_no = " & oClienteDomicilio.Ftserial.ToString()
                End If
            End If

            oFact04 = New i_ptvfact04

            LibX.App.CurrentPrgParams = oParamProgram

            If xtxt_MontoNeto.Text.Trim <> "" Then
                TotalFacturado = CDbl(Me.xtxt_MontoNeto.Text)
            End If
            If xtxt_descuento.Text.Trim <> "" Then
                TotalDescuento = CDbl(Me.xtxt_descuento.Text)
            End If

            If oFact04.ShowDialog(oClienteDomicilio, TotalFacturado, TotalDescuento) = DialogResult.OK Then

                If isDomicilio = True Then
                    Me.xcbo_fact_status.currValue = Val(EstatusDocumentosEnum.Pendiente)
                Else
                    Me.xcbo_fact_status.currValue = Val(EstatusDocumentosEnum.DomicilioPendiente)
                End If

                If oClienteDomicilio.Apellidos.Trim <> "" Then
                    Me.xtxt_bus_name.Text = oClienteDomicilio.Nombre & " " & oClienteDomicilio.Apellidos.Trim
                Else
                    Me.xtxt_bus_name.Text = oClienteDomicilio.Nombre
                End If
                ''If oClienteDomicilio.FormaPago = "CXC" Then
                ''    Me.lblresponsable.Visible = True
                ''    Me.xtxresponsable.Visible = True
                ''Else
                ''    Me.lblresponsable.Visible = False
                ''    Me.xtxresponsable.Visible = False
                ''End If
                Me.lbl_AditionalInformation.Text = opvDocumento.GetAditionalInformation(Documentos.TiposDocumentosEnum.Domicilio, oClienteDomicilio.Codigo)
                'Me.xchk_domicilio.Enabled = False
                Retorno = True
            Else
                Me.xcbo_fact_status.currValue = Val(EstatusDocumentosEnum.Pendiente)
                'Me.xchk_domicilio.Checked = False
                Retorno = (oClienteDomicilio.Codigo > 0)
            End If

            Me.xchk_domicilio.Checked = Retorno
            Return Retorno
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Function CapturarAutorizacion() As Boolean
        Dim oParamProgram As LibX.LibxPrgParams
        Dim optvfact02 As i_ptvfact02
        Dim blnSucess As Boolean = False
        Try
            If LibXConnector1.CurrentDataRow Is Nothing Then
                Exit Function
            End If

            oParamProgram = New LibX.LibxPrgParams
            optvfact02 = New i_ptvfact02

            With oParamProgram
                .IsFromOther = True
                If Me.LibXConnector1.CurrentAction = LibxConnectionActions.Add Then
                    .initMode = LibxInitModes.Insert
                Else
                    .initMode = LibxInitModes.Edit
                    .WhereToExecute = "ftsegrm.ftserial_no = " & LibXConnector1.CurrentDataRow!ftserial_no.ToString.Trim
                End If
            End With

            oAutorizacion.Plan = oClienteAsegurado.PlanID
            oAutorizacion.Compania = oClienteAsegurado.CompaniaID
            oAutorizacion.Poliza = oClienteAsegurado.Poliza
            oAutorizacion.TotalFacturado = Val(ftfactd.Compute("sum(Importe)", "1=1").ToString.Trim)
            If Me.xtxt_seg_amount.Text.Trim <> "" Then
                oAutorizacion.MontoCobertura = CDbl(Me.xtxt_seg_amount.Text.Trim)
            End If

            LibX.App.CurrentPrgParams = oParamProgram

            '// Capturar Autorizacion
            If optvfact02.ShowDialog(oAutorizacion) = DialogResult.OK Then
                If oAutorizacion.Autorizacion.Trim <> "" Then
                    Me.xtxt_seg_amount.Text = oAutorizacion.MontoCobertura
                    LibXConnector1.CurrentDataRow!seg_amount = oAutorizacion.MontoCobertura

                    CalcularNeto()
                    blnSucess = True
                End If
            End If

            Return blnSucess

        Catch ex As Exception
            Throw
        End Try
    End Function
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeguro.Click
        Try
            If LibXConnector1.IsDataEditing = True And LibXConnector1.CurrentDataRow!type_code <> "DEV" Then
                CapturarAutorizacion()
            Else
                If LibXConnector1.HasRecords = False Then
                    Exit Sub
                End If

                Dim oParamProgram As LibX.LibxPrgParams
                Dim optvfact02 As i_ptvfact02

                oParamProgram = New LibX.LibxPrgParams
                oParamProgram.WhereToExecute = "ftsegrm.ftserial_no = " & LibXConnector1.CurrentDataRow!ftserial_no.ToString.Trim
                oParamProgram.IsFromOther = True

                optvfact02 = New i_ptvfact02

                LibX.App.CurrentPrgParams = oParamProgram

                optvfact02.ShowDialog(oAutorizacion)
                If oAutorizacion.Autorizacion.Trim <> "" Then
                    Me.xtxt_seg_amount.Text = oAutorizacion.MontoCobertura
                    LibXConnector1.CurrentDataRow!seg_amount = oAutorizacion.MontoCobertura
                    CalcularNeto()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub Distribuye_descuento(Optional ByVal PorcDescuento As Integer = 0, Optional ByVal PorcCobertura As Integer = 0)
        Dim MontoDescuento As Decimal

        Dim DescuentoAplicado As Decimal = 0
        Dim MontoAplicado As Decimal = 0
        Dim CntItem, i As Integer
        Dim MontoSeguro As Decimal = 0
        Dim MontoBruto As Decimal = 0
        Dim PorcDescuentoProd As Decimal
        Dim PorcDescuentoDigi As Decimal
        Try
            If Val(Me.xtxt_descuento.Text.Trim) > 0 Then
                MontoDescuento = CType(Me.xtxt_descuento.Text, Decimal)

                For Each oRow As DataRow In ftfactd.Select("aplica_dscnt=1", "disc_pct DESC")
                    MontoBruto += Val(orow!qty.tostring.Trim) * Val(orow!price.tostring.Trim)
                Next

                For Each oRow As DataRow In ftfactd.Select("aplica_dscnt=1", "disc_pct DESC")
                    CntItem = ftfactd.Rows.Count
                    '//If LibX.IsNull(orow!aplica_dscnt) = False AndAlso orow!aplica_dscnt = 1 Then

                    '// si tiene un porciento asignado calcular el descuento por el 
                    '// porciento asignado
                    If LibX.IsNull(orow!dIsc_pct) = False Then
                        PorcDescuentoProd = Decimal.Round(Val(orow!disc_pct.tostring.Trim) / 100, 6)
                    End If

                    '// calcular el descuento que le corresponde segun lo digitado
                    PorcDescuentoDigi = Decimal.Round(MontoDescuento / MontoBruto, 2)
                    '//End If

                    PorcDescuentoProd = ((Val(oRow!qty.tostring.Trim) * Val(oRow!price.tostring.Trim))) * PorcDescuentoProd
                    PorcDescuentoDigi = ((Val(oRow!qty.tostring.Trim) * Val(oRow!price.tostring.Trim))) * PorcDescuentoDigi

                    MontoAplicado += ((Val(oRow!qty.tostring.Trim) * Val(oRow!price.tostring.Trim)))
                    DescuentoAplicado += PorcDescuentoProd

                    If PorcDescuentoProd > PorcDescuentoDigi Then
                        oRow!Dscto = PorcDescuentoDigi
                    Else
                        If PorcDescuentoProd > 0 Then
                            oRow!Dscto = Redondeo(PorcDescuentoProd, 2)
                        Else
                            oRow!Dscto = Redondeo(PorcDescuentoDigi, 2)
                        End If
                    End If

                    If LibX.IsNull(orow!itbis) = False AndAlso Val(orow!itbis.tostring.Trim) > 0 Then
                        oCalItbis = New SGT.Inventario.Entidades.Articulo.ParametrosCalcularItbis

                        With oCalItbis
                            .Almacen = WhDefault
                            .Producto = orow!item_code
                            .Dscto = Val(orow!dscto.tostring.Trim)
                            .Precio = Val(orow!price.tostring.Trim)
                            .Qty = Val(orow!qty.tostring.Trim)
                            .Monto = (Val(orow!price.tostring.Trim) * _
                                      Val(orow!qty.tostring.Trim)) - _
                                      Val(orow!dscto.tostring.Trim)
                        End With

                        orow!itbis = Convert.ToDecimal(Math.Round(oProducto.CalcularItbis(oCalItbis), 2))
                    End If
                    '//End If
                    i = i + 1

                    ''If i = CntItem And oRow!qty > 1 Then
                    If oRow!qty > 1 Then
                        oRow!Dscto = Redondeo(PorcDescuentoDigi - ((oRow!qty / 100) / CntItem), 2)
                    End If
                Next
            Else
                For Each oRow As DataRow In ftfactd.Rows
                    oRow!Dscto = DBNull.Value

                    If LibX.IsNull(orow!itbis) = False AndAlso Val(orow!itbis.tostring.Trim) > 0 Then
                        oCalItbis = New SGT.Inventario.Entidades.Articulo.ParametrosCalcularItbis

                        With oCalItbis
                            .Almacen = WhDefault
                            .Producto = orow!item_code
                            .Monto = (Val(orow!price.tostring.Trim) * _
                                      Val(orow!qty.tostring.Trim)) - _
                                      Val(orow!dscto.tostring.Trim)
                        End With

                        orow!itbis = oProducto.CalcularItbis(oCalItbis)
                    End If
                Next
            End If
            LibXGrid1.refreshFooter()
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Function Redondeo(ByVal Numero, ByVal Decimales)
        Redondeo = Int(Numero * 10 ^ Decimales + 1 / 2) / 10 ^ Decimales
    End Function
    Private Sub xtxt_descuento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles xtxt_descuento.Validated
        Try
            If LibXConnector1.CurrentAction <> LibxConnectionActions.Cancel AndAlso LibXConnector1.IsDataEditing = True Then
                Distribuye_descuento()
                If _Exist = True Or oDevolucion.Serial > 0 Then
                    CalcularNeto()
                End If
                mDsctoManual = True
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try

            'If e.isDataEditing = False And LibXConnector1.HasRecords = True Then
            '    If Val(LibXConnector1.CurrentDataRow!fact_status.ToString.Trim) = Val(EstatusDocumentosEnum.Pendiente) _
            '    Or Val(LibXConnector1.CurrentDataRow!fact_status.ToString.Trim) = Val(EstatusDocumentosEnum.DomicilioPendiente) _
            '    Or Val(LibXConnector1.CurrentDataRow!fact_status.ToString.Trim) = Val(EstatusDocumentosEnum.enEspera) Then
            '        LibXConnector1.AllowDelete = True
            '        If Val(LibXConnector1.CurrentDataRow!fact_impresa.ToString.Trim) <> 1 Then
            '            LibXConnector1.AllowEdit = True
            '        Else
            '            LibXConnector1.AllowEdit = False
            '        End If
            '    Else
            '        LibXConnector1.AllowDelete = False
            '        LibXConnector1.AllowEdit = False
            '    End If
            '    LibXNavigator1.UpdateState()
            'End If

            If e.action = LibxConnectionActions.Edit Then
                oBloqueoDocumento = New SGT.PuntodeVenta.Entidades.BloqueoFactua

                If Val(LibXConnector1.CurrentDataRow!fact_status.ToString.Trim) = Val(EstatusDocumentosEnum.Cobrada) _
                Or Val(LibXConnector1.CurrentDataRow!fact_status.ToString.Trim) = Val(EstatusDocumentosEnum.Anulada) Then
                    LibXConnector1.ShowWarningCancel = False
                    LibXConnector1.Cancel()
                    LibXConnector1.ShowWarningCancel = True
                    Throw New ApplicationException("Este documento no puede ser modificado!")
                End If
            End If

            '//para evitar que lo puedan cobrar o modificar en otro lado
            If e.action = LibxConnectionActions.Edit And e.isEditing = True Then
                If oBloqueoDocumento.BuscarBloqueo(LibXConnector1.CurrentDataRow!ftserial_no, LibXConnector1.CurrentDataRow!type_code) = True Then
                    Throw New ApplicationException("Este Documento lo estan modificando o cobrando!")
                Else
                    oBloqueoDocumento.BloquearDocumento(LibXConnector1.CurrentDataRow!ftserial_no, LibXConnector1.CurrentDataRow!type_code)
                End If
            End If

            If (e.isEditing = True AndAlso e.isDataEditing = False) Or e.action = LibxConnectionActions.Cancel Then
                Me.xtxt_MontoNeto.Text = ""
            End If

            Me.btnCheque.Enabled = (Not e.isEditing AndAlso LibXConnector1.HasRecords = True)
            Me.btnCredito.Enabled = (Not e.isEditing AndAlso LibXConnector1.HasRecords = True)
            Me.btnNC.Enabled = (Not e.isEditing AndAlso LibXConnector1.HasRecords = True)
            Me.btnTarjeta.Enabled = (Not e.isEditing AndAlso LibXConnector1.HasRecords = True)
            'Me.btnExistencia.Enabled = (e.isDataEditing = False And LibXConnector1.HasRecords = True)

            If Not oCajera Is Nothing Then
                Me.btnDomicilios.Enabled = (Not e.isEditing AndAlso mCaja = True)
                Me.btnCobrar.Enabled = (Not e.isEditing AndAlso mCaja = True)
            End If

            If e.isDataEditing = True Then
                Me.btnSetHold.Enabled = False
            End If
            If e.action = LibxConnectionActions.Find Then
                ''ShowCajaInfo()
                Me.xtxt_caja_code.Text = oCajaAbierta.CajaCode
                Me.xlk_caja_code.ExecuteFind()

                Me.xtxt_caje_code.Text = oCajaAbierta.CajeraCode
                Me.xlk_caje_code.ExecuteFind()
            End If

            btnCustomer.Enabled = (e.isDataEditing)
            btnSeguro.Enabled = False ''(e.isDataEditing)

            Me.btnFreeHold.Enabled = Not e.isEditing

            If e.action = LibxConnectionActions.Find Then
                Me.lbl_AditionalInformation.Text = ""
            End If
            'If e.action = LibxConnectionActions.Add Or e.action = LibxConnectionActions.Edit Then
            '    Me.xtxt_MontoNeto.Enabled = False
            'Else
            '    Me.xtxt_MontoNeto.Enabled = True
            'End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub ftfactd_ColumnChanging(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles ftfactd.ColumnChanging

        Try
            ''If e.Column.ColumnName = "unit_code" Then
            ''    mUnid = e.Row!unit_code.ToString.Trim
            ''End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub


    Private Sub xlk_unit_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_unit_code.AfterSetValues
        Try
            If e.dataFound = False Then
                LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColUnit_code, mUnid)
            Else
                '// calcular con el nuevo valor
                SendKeys.Send("{TAB}")
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub btnSetHold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetHold.Click
        Dim Holdtitle As String
        Dim type_code As String
        Dim vend_code As Integer
        Try
            Holdtitle = InputBox("Digite la descripcion del documento", "Poner en Espera", labelvend_name.Text.Trim)

            If Holdtitle.Trim <> "" Then
                LibXConnector1.CurrentDataRow!fact_nota = Holdtitle
                LibXConnector1.CurrentDataRow!fact_status = Val(EstatusDocumentosEnum.enEspera)   '// en Espera
                Me.xcbo_fact_status.currValue = Val(EstatusDocumentosEnum.enEspera)  '// en Espera

                vend_code = Val(Me.xtxt_vend_code.Text.Trim)
                LibXConnector1.Accept()

                Me.btnSetHold.Enabled = False

                LibXConnector1.AddNew()
                Me.xtxt_vend_code.Text = vend_code
                Me.xlk_vend_code.ExecuteFind()
                Me.xtxt_type_code.Focus()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnFreeHold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreeHold.Click
        Dim oParam As LibX.LibxPrgParams
        Dim oHold As i_fthold01
        Dim oFactura As i_fthold01.sFactura

        Try

            oParam = New LibX.LibxPrgParams
            oHold = New i_fthold01
            oFactura = New i_fthold01.sFactura

            With oParam
                If WhDefault > 0 Then
                    .Datos.Add("whse_code", LibX.User.WhDefault)
                End If

                If oCajaAbierta.CajaCode > 0 Then
                    .Datos.Add("caja_code", oCajaAbierta.CajaCode)
                End If

                If oCajaAbierta.CajeraCode > 0 Then
                    .Datos.Add("caje_code", oCajaAbierta.CajeraCode)
                End If

                If Me.xtxt_vend_code.Text.Trim <> "" Then
                    .Datos.Add("vend_code", Me.xtxt_vend_code.Text)
                End If

                If oCajaAbierta.CajeraCode > 0 Then
                    .Datos.Add("cobro", 0)
                End If

                .WhereToExecute = "ftfactm.type_code in  ('FPV','FSG','RCE','DEV','EST','FTS') and ftfactm.fact_status = " & Val(EstatusDocumentosEnum.Pendiente).ToString.Trim & " and ftfactm.whse_code = " & WhDefault
            End With

            LibX.App.CurrentPrgParams = oParam
            oHold.FacturaSelected = oFactura
            oHold.PicCobro.Visible = False
            oHold.picEspera.Visible = True

            If oHold.ShowDialog() = DialogResult.Yes Then
                LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & oFactura.Serial.ToString)
                'If LibXConnector1.HasRecords = True Then
                '    LibXConnector1.Edit()
                'End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaulteditValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultEditValues) Handles LibXConnector1.SettingDefaulteditValues
        Dim CloseProgram As Boolean = False
        Dim EditBloquin As Boolean = False
        Try
            If oCajaAbierta.HayCajasAbiertas = False Then
                CloseProgram = True
                Throw New ApplicationException("Debe iniciar una caja para realizar las operaciones del dia!")
            End If
            ''If LibXConnector1.IsDataEditing = True And LibXConnector1.IsEditing = True And LibXConnector1.HasRecords = True Then
            ''    If oBloqueoDocumento.BuscarBloqueo(LibXConnector1.CurrentDataRow!ftserial_no, LibXConnector1.CurrentDataRow!type_code) = False Then
            ''        oBloqueoDocumento.BloquearDocumento(LibXConnector1.CurrentDataRow!ftserial_no, LibXConnector1.CurrentDataRow!type_code)
            ''        EditBloquin = True
            ''    End If
            ''End If

            '// Limpiar permisos Autorizados
            oAutorizar.PermisosAutorizados.Clear()

            '// si esta llamando un documento de espera y es un domicilio
            '// cambiar el estatus a Domicilio Pendiente de lo contrario
            '// cambiar el estatus a Pendiente
            If LibXConnector1.CurrentDataRow!fact_status = Val(EstatusDocumentosEnum.enEspera) Then
                '// Si es un domicilio
                If Val(LibXConnector1.CurrentDataRow!fact_inddomicilio.ToString.Trim) = 1 And isDomicilio = False Then
                    LibXConnector1.CurrentDataRow!fact_status = Val(EstatusDocumentosEnum.DomicilioPendiente)
                    Me.xcbo_fact_status.currValue = Val(EstatusDocumentosEnum.DomicilioPendiente)
                Else
                    LibXConnector1.CurrentDataRow!fact_status = Val(EstatusDocumentosEnum.Pendiente)
                    Me.xcbo_fact_status.currValue = Val(EstatusDocumentosEnum.Pendiente)
                End If
            End If

            '//Me.xcbo_fact_status.currValue = Val(EstatusDocumentosEnum.Pendiente)  '//Pendiente
            If oDocumento.AfectaOtrosDocumentos = True AndAlso Val(Me.LibXConnector1.CurrentDataRow!ftserial_afect.ToString.Trim) > 0 Then
                oDevolucion.LoadPorFactura(Me.LibXConnector1.CurrentDataRow!ftserial_no)
                '//oDevolucion.Load()
            End If

            If LibX.IsNull(LibXConnector1.CurrentDataRow!cust_code) = False Then
                '// oClienteDomicilio.Codigo = Me.LibXConnector1.CurrentDataRow!cust_code
                oClienteDomicilio.LoadbyFactura(Me.LibXConnector1.CurrentDataRow!ftserial_no)
            End If

            If oDocumento.AfectaSeguroMedico = True AndAlso LibX.IsNull(Me.LibXConnector1.CurrentDataRow!aseg_poliza) = False Then
                oClienteAsegurado.Poliza = Me.LibXConnector1.CurrentDataRow!aseg_poliza
                oClienteAsegurado.Load()

                oAutorizacion.Factura = Me.LibXConnector1.CurrentDataRow!ftserial_no
                oAutorizacion.Load()
            End If

            oAutorizar = New SGT.Administracion.Entidades.Permission

            'If oCajera.esCajera = False Then
            '''If PedirVendedor() = False Then
            '''    LibXConnector1.ShowWarningCancel = False
            '''    LibXConnector1.Cancel()
            '''    LibXConnector1.ShowWarningCancel = True
            '''End If
            If isVendm = True Then
                Me.xtxt_vend_code.Text = 1
                Me.xlk_vend_code.ExecuteFind()
                Me.xtxt_type_code.Text = "FPV"
                Me.xlk_type_code.ExecuteFind()
            Else
                If LibXConnector1.IsDataEditing = True And LibXConnector1.IsEditing = True And LibXConnector1.HasRecords = True And EditBloquin = True Then
                    ''Else
                    ''    If PedirVendedor() = False Then
                    ''        LibXConnector1.ShowWarningCancel = False
                    ''        LibXConnector1.Cancel()
                    ''        LibXConnector1.ShowWarningCancel = True
                    ''    End If
                End If
            End If

            ''If LibXConnector1.IsDataEditing = True And LibXConnector1.IsEditing = True And LibXConnector1.HasRecords = True And EditBloquin = True Then
            ''    oBloqueoDocumento.BorrarBloqueo(LibXConnector1.CurrentDataRow!ftserial_no, LibXConnector1.CurrentDataRow!type_code)
            ''End If

            '// entrar al detalle
            SetFocusToGrid()

        Catch ex As Exception
            LibX.Log.Show(ex)
            If CloseProgram = True Then
                Me.Close()
            End If
        End Try
    End Sub

    Private Sub ShowPayMethod(ByVal Tipo As String)
        Try
            Dim oParam As New LibX.LibxPrgParams

            With oParam
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowPrint = False
                .Value = Tipo
                .WhereToExecute = "cjtranrm.ftserial_no  =" & LibXConnector1.CurrentDataRow!ftserial_no.ToString & " and pay_method = '" & Tipo & "'"
                .IsFromOther = True
            End With

            LibX.App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("c_cjpaym01", "CAJ", True)

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Function ShowCustomer(ByVal Tipo As String) As Boolean
        Try
            Dim oParam As New LibX.LibxPrgParams
            Dim ofact03 As New i_ptvfact03
            Dim Codigo As String = ""
            Dim opvDocumento As New SGT.PuntodeVenta.Entidades.Documentos
            With oParam
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowPrint = False
                .Value = Tipo

                If Me.xchk_domicilio.Checked = True Then
                    If LibXConnector1.CurrentDataRow!phone.ToString.Trim <> "" Then
                        .WhereToExecute = "ftcustm.phone = '" & LibXConnector1.CurrentDataRow!phone.ToString.Trim & "'"
                    End If
                Else
                    If oDocumento.RequiereCliente = True Then
                        If Val(LibXConnector1.CurrentDataRow!cust_code.ToString.Trim) > 0 Then
                            .WhereToExecute = "cccustm.cust_code = " & LibXConnector1.CurrentDataRow!cust_code.ToString.Trim
                        End If
                    End If

                    If oDocumento.RequiereSuplidor = True Then
                        If Val(LibXConnector1.CurrentDataRow!prov_code.ToString.Trim) > 0 Then
                            .WhereToExecute = "cpprovm.prov_code = " & LibXConnector1.CurrentDataRow!prov_code.ToString.Trim
                        End If
                    End If

                    If oDocumento.AfectaOtrosDocumentos = True Then
                        If Val(LibXConnector1.CurrentDataRow!ftserial_afect.ToString.Trim) > 0 Then
                            .WhereToExecute = "ftfactm.ftserial_no = " & LibXConnector1.CurrentDataRow!ftserial_afect.ToString.Trim
                        End If
                    End If

                    If oDocumento.AfectaSeguroMedico = True Then
                        If LibXConnector1.CurrentDataRow!aseg_poliza.ToString.Trim <> "" Then
                            .WhereToExecute = "ftsegrm.aseg_poliza =  '" & LibXConnector1.CurrentDataRow!aseg_poliza.ToString.Trim & "'"
                        End If
                    End If
                End If

                If Codigo.Trim <> "" Then
                    If LibXConnector1.IsDataEditing = True Then
                        .initMode = LibxInitModes.Edit
                    End If
                Else
                    .initMode = LibxInitModes.Insert
                End If

                .IsFromOther = True
            End With

            LibX.App.CurrentPrgParams = oParam

            If ofact03.ShowDialog(Me) = DialogResult.Yes Then
            Else
                Return False
            End If
            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function

    Private Sub btnCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheque.Click
        Try
            ShowPayMethod("CHK")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredito.Click
        Try
            ShowPayMethod("CXC")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnNC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNC.Click
        Try
            ShowPayMethod("NC")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Dim mTipo As String
        Try
            'Me.btnExistencia.Enabled = (LibXConnector1.IsDataEditing = False And LibXConnector1.HasRecords = True)

            If Not e.row Is Nothing Then
                If LibXConnector1.IsDataEditing = False And LibXConnector1.HasRecords = True Then
                    If e.row!fact_status = Val(EstatusDocumentosEnum.Pendiente) _
                       Or e.row!fact_status = Val(EstatusDocumentosEnum.enEspera) Then
                        If LibX.IsNull(e.row!fact_number.ToString.Trim) = True Then
                            LibXConnector1.AllowEdit = True
                            LibXConnector1.AllowDelete = True
                        Else
                            LibXConnector1.AllowEdit = False
                            LibXConnector1.AllowDelete = False
                        End If
                    Else
                        LibXConnector1.AllowDelete = False
                        LibXConnector1.AllowEdit = False
                    End If
                    If Not LibX.IsNull(LibXConnector1.CurrentDataRow!fact_number) Then
                        LibXConnector1.AllowPrint = True
                    Else
                        LibXConnector1.AllowPrint = False
                    End If
                    If Not LibX.IsNull(LibXConnector1.CurrentDataRow!type_code) Then
                        mTipo = LibXConnector1.CurrentDataRow!type_code
                        If mTipo = "EST" Then
                            LibXConnector1.AllowDelete = False
                            LibXConnector1.AllowEdit = False
                        End If
                    End If
                    LibXNavigator1.UpdateState()
                End If

                Me.btnCheque.Enabled = (Not IsNull(e.row!cheque) AndAlso e.row!cheque > 0)
                Me.btnCredito.Enabled = (Not IsNull(e.row!credito) AndAlso e.row!credito > 0)
                Me.btnTarjeta.Enabled = (Not IsNull(e.row!tarjeta) AndAlso e.row!tarjeta > 0)
                Me.btnNC.Enabled = (Not IsNull(e.row!notacredito) AndAlso e.row!notacredito > 0)

                '// Mostrar el total
                If LibXConnector1.IsEditing = False And LibXConnector1.HasRecords = True Then
                    ShowInfo()
                    CalcularNeto()
                End If

                If LibXConnector1.HasRecords = False Then
                    Me.lbl_AditionalInformation.Text = ""
                End If

                btnSetHold.Enabled = (LibXConnector1.IsDataEditing = True AndAlso ftfactd.Rows.Count > 0)
            Else
                Me.lbl_AditionalInformation.Text = ""
                Me.xtxt_MontoNeto.Text = ""
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub gColIndCobertura_BoolValueChanged(ByVal sender As System.Object, ByVal e As LibX.BoolValueChangedEventArgs)
        Try
            If LibXConnector1.IsDataEditing Then
                ftfactd.Rows(LibXGrid1.currentRowNum).EndEdit()
                CalcularNeto()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertedRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedRow
        Dim XInsert As LibX.Data.XInsertStmt
        Dim XDelete As LibX.Data.XDeleteStmt
        Dim dst, pdst As Decimal
        Dim dscnt As String
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then

                '//Validar que el domicisio no se grabe con el cambio menor que el monto facturado
                If oClienteDomicilio.Cambio > 0 And oClienteDomicilio.Cambio < Me.xtxt_MontoNeto.Text And LibX.IsNull(Me.xchk_domicilio.Text) Then
                    Throw New ApplicationException("El cambio del domicilio no puede ser mayor que el valor a pagar!")
                End If
                '//Validar que el descuento de la tarjeta en los domicilio no sea mayor 
                '//que el descuento permitido
                If oClienteDomicilio.FormaPago = "TAR" Then
                    If Val(Me.xtxt_descuento.Text) > 0 And (Val(mConfig.GetDSCTO) > 0 Or Val(mConfig.GetDsctoTar) > 0) Then
                        'CalcularNeto()
                        dst = (xtxt_fact_total.Text * (mConfig.GetDsctoTar / 100))
                        dst = dst.ToString("###,###,###.##")
                        If Me.xtxt_descuento.Text > dst And mConfig.GetDsctoTar > 0 Then
                            pdst = mConfig.GetDsctoTar.ToString("###,###,###.##")
                            dscnt = MessageBox.Show("El descuento maximo permitido es un " & pdst & "% del monto de la factura", "Autorizar Descuento", MessageBoxButtons.YesNo)
                            If dscnt = System.Windows.Forms.DialogResult.Yes Then
                                oParamValidar.AccessKey = "AD"
                                oAutorizar.PermisosAutorizados.Remove("AD")

                                If oAutorizar.isAutorization(oParamValidar) = False Then
                                    Throw New ApplicationException("Autorización Invalida o descuento no permitido ")
                                End If
                            Else
                                Throw New ApplicationException("El descuento no debe ser mayor que " & pdst & "% del monto de la factura")
                            End If
                        End If
                        'If Me.xtxt_descuento.Text > dst And mConfig.GetDsctoTar > 0 Then
                        '    pdst = mConfig.GetDsctoTar.ToString("###,###,###.##")
                        '    Throw New ApplicationException("El descuento maximo permitido es un " & pdst & "% del monto de la factura")
                        'End If
                    End If
                End If
                '//Validar que en los domicilio no le permita dar descuento cuando sea credito
                If oClienteDomicilio.FormaPago = "CXC" Then
                    If xtxt_descuento.Text > 0 And mConfig.GetDSCTO > 0 Then
                        Throw New ApplicationException("Debe verificar el descuento antes, que no esta permitido para CXC")
                    End If
                End If

                If e.UpdatingArgs.StatementType = StatementType.Insert _
                Or e.UpdatingArgs.StatementType = StatementType.Update Then
                    '// SEGRO MEDICO
                    If e.UpdatingArgs.StatementType = StatementType.Insert Then
                        If oClienteDomicilio.Codigo > 0 AndAlso LibX.IsNull(e.UpdatingArgs.Row!fact_inddomicilio) = True Then
                            e.UpdatingArgs.Row!fact_inddomicilio = 1
                        End If
                    End If

                    '// si se esta enviando a hold no guardar informacion de autorizacion
                    If oDocumento.AfectaSeguroMedico = True Then
                        '// Asignar el No. de Serial
                        If oClienteAsegurado.Poliza.Trim <> "" Then
                            Dim oRow As DataRow = ftsegrm.NewRow
                            ftsegrm.Rows.Add(oRow)

                            If e.UpdatingArgs.StatementType = StatementType.Update Then
                                oRow.AcceptChanges()
                                ftsegrm.Rows(0).BeginEdit()
                                ftsegrm.Rows(0)!ftserial_no = e.UpdatingArgs.Row!ftserial_no
                            Else
                                ftsegrm.Rows(0).BeginEdit()
                                ftsegrm.Rows(0)!ftserial_no = LibX.Data.Manager.LastSerialValue
                            End If

                            ftsegrm.Rows(0)!aseg_poliza = oClienteAsegurado.Poliza
                            ftsegrm.Rows(0)!segr_autorizacion = oAutorizacion.Autorizacion
                            ftsegrm.Rows(0)!empl_amount = oAutorizacion.MontoPagar
                            ftsegrm.Rows(0)!cia_amount = oAutorizacion.MontoCobertura
                            ftsegrm.Rows(0)!cia_serial = oClienteAsegurado.CompaniaID
                            ftsegrm.Rows(0)!plan_serial = oClienteAsegurado.PlanID
                            ftsegrm.Rows(0)!segr_recetaunica = oAutorizacion.RecetaUnica
                            ftsegrm.Rows(0)!suc_code = LibX.User.Sucursal
                            ftsegrm.Rows(0)!clini_code = oClienteAsegurado.Clinica
                            ftsegrm.Rows(0).EndEdit()

                            LibX.Data.Manager.Save(ftsegrm)
                        End If
                    End If
                    'End If

                    ''// DOMICILIO
                    'If e.UpdatingArgs.StatementType = StatementType.Insert _
                    'Or e.UpdatingArgs.StatementType = StatementType.Update Then
                    If (Not LibX.IsNull(e.UpdatingArgs.Row!fact_inddomicilio) And e.UpdatingArgs.Row!fact_inddomicilio <> 0) AndAlso e.UpdatingArgs.Row!fact_inddomicilio = 1 _
                    And e.UpdatingArgs.Row!type_code <> "FSG" Then
                        XInsert = New LibX.Data.XInsertStmt("ftdomim")

                        '// Eliminar el que existe
                        If e.UpdatingArgs.StatementType = StatementType.Update Then
                            XDelete = New LibX.Data.XDeleteStmt("ftdomim")
                            XDelete.Fields("ftserial_no") = e.UpdatingArgs.Row!ftserial_no
                            XDelete.Execute()

                            XInsert.Fields("ftserial_no") = e.UpdatingArgs.Row!ftserial_no
                        Else
                            XInsert.Fields("ftserial_no") = LibX.Data.Manager.LastSerialValue
                        End If

                        XInsert.Fields("cust_code") = oClienteDomicilio.Codigo
                        XInsert.Fields("domi_date") = LibX.Data.Manager.Connection.GetDate
                        XInsert.Fields("domi_estatus") = 2 '// pendiente de cobro

                        If oClienteDomicilio.Cambio > 0 Then XInsert.Fields("domi_cambio") = oClienteDomicilio.Cambio
                        If oClienteDomicilio.Mensajero > 0 Then XInsert.Fields("vend_mensaj") = oClienteDomicilio.Mensajero
                        If oClienteDomicilio.FormaPago.Trim <> "" Then XInsert.Fields("domi_pago") = oClienteDomicilio.FormaPago.Trim
                        If oClienteDomicilio.TarjetaCodigo > 0 Then XInsert.Fields("tarj_code") = oClienteDomicilio.TarjetaCodigo
                        XInsert.Fields("suc_code") = LibX.User.Sucursal
                        XInsert.Execute()
                    End If
                End If
                'If Not LibX.IsNull(e.UpdatingArgs.Row!fact_inddomicilio) AndAlso e.UpdatingArgs.Row!fact_inddomicilio = 1 _
                If e.UpdatingArgs.Row!fact_inddomicilio = 1 And e.UpdatingArgs.Row!type_code = "FSG" Then
                    XInsert = New LibX.Data.XInsertStmt("ftdomim")

                    '// Eliminar el que existe
                    If e.UpdatingArgs.StatementType = StatementType.Update Then
                        XDelete = New LibX.Data.XDeleteStmt("ftdomim")
                        XDelete.Fields("ftserial_no") = e.UpdatingArgs.Row!ftserial_no
                        XDelete.Execute()

                        XInsert.Fields("ftserial_no") = e.UpdatingArgs.Row!ftserial_no
                    Else
                        XInsert.Fields("ftserial_no") = LibX.Data.Manager.LastSerialValue
                    End If
                    XInsert.Fields("cust_code") = CuentaSeguroDomicici(oClienteAsegurado.CompaniaID)
                    XInsert.Fields("domi_date") = LibX.Data.Manager.Connection.GetDate
                    XInsert.Fields("domi_estatus") = 2 '// pendiente de cobro
                    XInsert.Fields("domi_cambio") = oAutorizacion.MontoPagar
                    XInsert.Fields("vend_mensaj") = ""
                    XInsert.Fields("domi_pago") = "EFE"
                    XInsert.Fields("tarj_code") = ""
                    XInsert.Fields("suc_code") = LibX.User.Sucursal
                    XInsert.Execute()
                End If
            End If
        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        Try
            PedirCliente()
            SetFocusToGrid()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnEgresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEgresos.Click
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams
            oParam.Value = oCajaAbierta.Serial
            oParam.initMode = LibxInitModes.Insert

            LibX.App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("i_ccpaym01", "CXC")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xlk_item_code_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_item_code.BeforeSetValues

        Dim oParamSeg As SGT.PuntodeVenta.Entidades.ParametroCobertura
        Dim mesg As Integer

        Try
            '// si es seguro medico verificar si esta cubierto por 
            '// el seguro

            If e.dataFound = True Then

                '// Validar si el producto existe y si es asi
                '// aumentar la cantidad de lo contrario continuar
                If ProductoExiste(e.row!item_code) = True Then
                    LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColitem_code, "")
                    Throw New ApplicationException("Este producto ya esta registrado en esta factura!")
                End If

                If e.row!prd_controlado = 1 Then
                    mesg = MessageBox.Show("Ojo...: Este producto es controlado", MessageBoxButtons.OK)
                    If mesg = System.Windows.Forms.DialogResult.OK Then

                    End If
                End If

                If oDocumento.AfectaSeguroMedico = True Then
                    oParamSeg = New SGT.PuntodeVenta.Entidades.ParametroCobertura

                    With oParamSeg
                        .Producto = e.row!item_code
                        .Plan = oClienteAsegurado.PlanID
                        .Compania = oClienteAsegurado.CompaniaID
                    End With

                    If oSeguro.TieneCobretura(oParamSeg) = False Then
                        Throw New ApplicationException("Este producto no esta incluido en la cobertura de su Plan!")
                    End If
                End If
            End If

        Catch ex As Exception
            e.handled = True
            LibXGrid1.Focus(LibXGrid1.CurrentRowIndex, 0)
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Function ProductoExiste(ByVal pitem_code As String) As Boolean
        Dim oRow As DataRow()
        Dim Qty As Integer
        Try
            oRow = ftfactd.Select("item_code = '" & pitem_code.Trim & "'")

            If oRow.Length <= 0 Then
                Return False
            End If

            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
    Private Function FindEstadoEspera(ByVal ftSerial As Integer) As Integer
        Dim mEstado As Integer
        Try
            mEstado = LibX.Data.Manager.GetScalar("select fact_status from ftfactm where ftserial_no = " & ftSerial)

            Return mEstado

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
    Private Sub xtxt_type_code_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_type_code.Validating
        Try

            If LibXConnector1.IsDataEditing = True Then
                If Me.xtxt_type_code.Text.Trim = "" Then
                    Me.xlk_type_code.ExecuteLookup()
                    If isClienteAntes = True Then
                        Me.xkl_cliente.ExecuteLookup()
                    End If
                    If xlk_type_code.DataFound = False Then
                        e.Cancel = True
                        Exit Sub
                    End If
                    SendKeys.Send("{TAB}")
                End If
            End If
        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub SetFocusToGrid()
        Try
            If LibXGrid1.CurrentRowIndex > 0 _
            AndAlso LibXGrid1.GetValue(LibXGrid1.currentRowNum, Me.gColitem_code) = "" Then
                LibXGrid1.CurrentRowIndex = IIf(LibXGrid1.currentRowNum <= 0, 0, LibXGrid1.currentRowNum - 1)
            End If

            If LibXGrid1.getCurrentGridView.Count <= 0 Then
                LibXGrid1.Focus(0, 0)
            Else
                LibXGrid1.Focus(LibXGrid1.CurrentRowIndex, 0)
                LibXGrid1.BeginEdit(gColitem_code, LibXGrid1.CurrentRowIndex)
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub xtxt_type_code_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles xtxt_type_code.GotFocus
        Try
            If LibXConnector1.IsDataEditing = True Then
                If Me.xtxt_type_code.Text.Trim = "" _
                And Me.xlk_type_code.DataFound = False _
                And Me.xlk_type_code.isCanceled = False Then
                    SendKeys.Send("{TAB}")
                End If
            Else
                If Me.xtxt_type_code.Text.Trim <> "" Then
                    Me.xtxt_type_code.Enabled = False
                    Me.xlk_type_code.Enabled = False
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub xtxt_type_code_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles xtxt_type_code.Validated
        Try

            If LibXConnector1.IsDataEditing = True And LibXConnector1.CurrentAction = LibxConnectionActions.Add Then
                '// Pedir los datos del cliente
                If PedirCliente() = False Then
                    'Me.xtxt_type_code.Focus()
                    Me.xtxt_type_code.Text = ""
                    Me.lbltype_name.Text = ""
                    LibXConnector1.ShowWarningCancel = False
                    LibXConnector1.Cancel()
                    Exit Sub
                End If
                SetFocusToGrid()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub i_ptvfact01_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Tab And e.Control = True Then
                e.Handled = True

                If Me.ActiveControl Is LibXGrid1 Then
                    MessageBox.Show("salir")
                    Me.xtxt_descuento.Focus()
                Else
                    SetFocusToGrid()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub GetVencimiento(ByVal Producto As String)
        Try
            Dim oProducto As New SGT.Inventario.Entidades.Articulo

            Me.lblVencimiento.Text = oProducto.GetVencimiento(Producto)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub xlk_item_code_CheckedChanged(ByVal sender As Object, ByVal e As LibX.CheckedChangedEventArgs) Handles xlk_item_code.CheckedChanged
        Try
            If e.CheckStatus = True Then
                e.Table.DefaultView.RowFilter = "existencia >0"
            Else
                e.Table.DefaultView.RowFilter = ""
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail

        Try
            If LibXConnector1.CurrentAction = LibxConnectionActions.Edit _
            Or LibXConnector1.CurrentAction = LibxConnectionActions.Add Then
                For i As Integer = 0 To ftfactd.Rows.Count - 1
                    If ftfactd.Rows(i).RowState <> DataRowState.Deleted AndAlso LibX.IsNull(ftfactd.Rows(i)!item_code) Then
                        ftfactd.Rows(i).Delete()
                    End If
                Next
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub btnDomicilios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDomicilios.Click
        Dim oParam As LibX.LibxPrgParams
        Dim oHold As i_ftdomim01
        Dim oFactura As i_ftdomim01.Factura

        Try
            oParam = New LibX.LibxPrgParams
            oHold = New i_ftdomim01
            oFactura = New i_ftdomim01.Factura
            oBloqueoDocumento = New SGT.PuntodeVenta.Entidades.BloqueoFactua

            With oParam

                If oCajaAbierta.CajaCode > 0 Then
                    .Datos.Add("caja_code", oCajaAbierta.CajaCode)
                End If

                If oCajaAbierta.CajeraCode > 0 Then
                    .Datos.Add("caje_code", oCajaAbierta.CajeraCode)
                End If

                If Me.xtxt_vend_code.Text.Trim <> "" Then
                    .Datos.Add("vend_code", Me.xtxt_vend_code.Text)
                End If

                .WhereToExecute = "ftfactm.fact_status = " & Val(EstatusDocumentosEnum.DomicilioPendiente).ToString & " and ftfactm.whse_code = " & LibX.User.WhDefault
            End With

            LibX.App.CurrentPrgParams = oParam
            oHold.FacturaSelected = oFactura

            If oHold.ShowDialog() = DialogResult.Yes Then
                If ValidarEstadoCaja(oCajaAbierta.Serial) = False Then
                    Throw New ApplicationException("Esta caja ha sido cerrada y no puede cobrar!")
                End If
                '//Si el documento se va a cobrar verificar que no se este editando
                If oBloqueoDocumento.BuscarBloqueo(oFactura.Serial, oFactura.Type) = True Then
                    Throw New ApplicationException("Este Documento lo estan Modificando o cobrando!")
                Else
                    CobrarDocumento(oFactura.Serial, oFactura.Type)
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub ftfactd_RowDeleted(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles ftfactd.RowDeleted
        Try
            If LibXConnector1.IsDataEditing = True Then
                CalcularNeto()
                LibXGrid1.Focus(LibXGrid1.currentRowNum, 0)
                LibXGrid1.refreshFooter()
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub LibXGrid1_CellKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LibXGrid1.CellKeyPress

        If e.KeyData = Keys.Control + Keys.X Then
            '''xtxt_descuento_Click(sender, New EventArgs)
            Me.xtxt_descuento.Focus()
        End If

        If e.KeyCode = Keys.F7 And LibXConnector1.IsDataEditing = True Then
            '//Indicer que el documentos es a Domicilio
            xchk_domicilio.Checked = True
        End If
        '    End If
        'Catch ex As Exception
        '    LibX.Log.Show(ex)
        'End Try
    End Sub

    Private Function AutorizaDescuento() As Boolean
        Dim oAuto As SGT.Administracion.Entidades.Permission
        Dim MontoDescuento As Decimal
        Dim MontoBruto As Decimal
        Try
            For Each oRow As DataRow In ftfactd.Select("aplica_dscnt=1")
                MontoBruto += oRow!qty * oRow!price
            Next

            MontoDescuento = ftfactd.Compute("sum(dscto)", "aplica_dscnt=1")

            oAuto = New SGT.Administracion.Entidades.Permission

            '''If (MontoDescuento / MontoBruto) > (oCajera.Porc_Descuento / 100) Then
            '''    'Return oAuto.isAutorization(SGT.Administracion.Entidades.Permission.TipoAutorizacionEnum.Descuento)
            '''End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Function

    Private Sub ShowInfo()

        Me.lbl_AditionalInformation.Text = ""

        If oDocumento.AfectaOtrosDocumentos = True Then
            Me.lbl_AditionalInformation.Text = opvDocumento.GetAditionalInformation(Documentos.TiposDocumentosEnum.Devoluciones, LibXConnector1.CurrentDataRow!ftserial_no)
            Exit Sub
        End If

        If oDocumento.AfectaSeguroMedico = True AndAlso LibX.IsNull(LibXConnector1.CurrentDataRow!aseg_poliza) = False Then
            Me.lbl_AditionalInformation.Text = opvDocumento.GetAditionalInformation(Documentos.TiposDocumentosEnum.SegurosMedicos, LibXConnector1.CurrentDataRow!aseg_poliza)
            Exit Sub
        End If

        If Not LibX.IsNull(LibXConnector1.CurrentDataRow!cust_code) AndAlso _
           Not LibX.IsNull(LibXConnector1.CurrentDataRow!fact_inddomicilio) AndAlso _
           LibXConnector1.CurrentDataRow!fact_inddomicilio = 1 Then
            oClienteDomicilio.Codigo = LibXConnector1.CurrentDataRow!cust_code
            Me.lbl_AditionalInformation.Text = oClienteDomicilio.GetAditionalInformation(LibXConnector1.CurrentDataRow!ftserial_no)
            Exit Sub
        End If

        If Not LibX.IsNull(LibXConnector1.CurrentDataRow!cust_code) Then
            oClienteCredito.Codigo = LibXConnector1.CurrentDataRow!cust_code
            Me.lbl_AditionalInformation.Text = oClienteCredito.GetAditionalInformation()
            Exit Sub
        End If

    End Sub

    Private Function PedirVendedor() As Boolean
        Dim oVendedor As i_ptvvend01
        Dim blnSuccess As Boolean = False
        Try
            oVendedor = New i_ptvvend01

            If oVendedor.ShowDialog(mVendedor) = DialogResult.Yes Then
                Me.xtxt_vend_code.Text = mVendedor.Code.ToString
                Me.xlk_vend_code.ExecuteFind()

                blnSuccess = True
                LibX.User.VendedorID = mVendedor.Code
                oCajera = New Cajera(mVendedor.Code)
            End If

            If Me.xchk_domicilio.Checked = True Then
                Me.xtxt_bus_name.Enabled = False
            Else
                Me.xtxt_bus_name.Enabled = True
            End If

            Return blnSuccess

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Function

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            '// Anular Documento
            oBloqueoDocumento = New SGT.PuntodeVenta.Entidades.BloqueoFactua

            If e.Action = LibxConnectionActions.Delete Then
                If ValidarDocumento(LibXConnector1.CurrentDataRow!ftserial_no) = True Then
                    Throw New ApplicationException("Este Documento no se puede Anular, ESTA COBRADO!")
                End If
                If Not LibX.IsNull(LibXConnector1.CurrentDataRow!ftserial_no) Then
                    If oBloqueoDocumento.BuscarBloqueo(LibXConnector1.CurrentDataRow!ftserial_no, LibXConnector1.CurrentDataRow!type_code) = True Then
                        Throw New ApplicationException("Este Documento lo estan Modificando o cobrando!")
                    End If
                End If
                oParamValidar.AccessKey = "AN"
                oAutorizar.PermisosAutorizados.Remove("AN")

                If oAutorizar.isAutorization(oParamValidar) = False Then
                    e.Handled = True
                    Throw New ApplicationException("Autorización Invalida")
                End If
                If Val(Me.xcbo_fact_status.currValue.ToString.Trim) = Val(EstatusDocumentosEnum.enEspera) Then   'HOLD Then
                    EliminarDominicio(LibXConnector1.CurrentDataRow!ftserial_no)
                End If
            End If

            If e.Action = LibxConnectionActions.Print Then
                If oDocumento.AutoImprimir = True Then
                    LibXConnector1.ReportObject.Destination = Crystal.DestinationConstants.crptToPrinter '// Imprimir Directo
                End If
            End If
            If e.Action = LibxConnectionActions.Edit And e.AcceptedAction = LibxConnectionActions.None Then
                If ValidarDocumento(LibXConnector1.CurrentDataRow!ftserial_no) = True Then
                    Throw New ApplicationException("Este Documento no se puede Editar, ESTA COBRADO!")
                End If
                If oBloqueoDocumento.BuscarBloqueo(LibXConnector1.CurrentDataRow!ftserial_no, LibXConnector1.CurrentDataRow!type_code) = True Then
                    Throw New ApplicationException("Este Documento lo estan Modificando o cobrando!")
                End If
            End If

            If e.Action = LibxConnectionActions.Cancel Then
                If Not LibX.IsNull(LibXConnector1.CurrentDataRow!ftserial_no) Then
                    oBloqueoDocumento.BorrarBloqueo(LibXConnector1.CurrentDataRow!ftserial_no, LibXConnector1.CurrentDataRow!type_code)
                End If
            End If
            If e.Action = LibxConnectionActions.Accept And e.AcceptedAction = LibxConnectionActions.Edit Then
                oBloqueoDocumento.BorrarBloqueo(LibXConnector1.CurrentDataRow!ftserial_no, LibXConnector1.CurrentDataRow!type_code)
            End If
            ''If e.Action = LibxConnectionActions.Add Then
            ''    If Me.lblresponsable.Visible = True Or Me.xtxresponsable.Visible = True Then
            ''        Me.lblresponsable.Visible = False
            ''        Me.xtxresponsable.Visible = False
            ''    End If
            ''Else
            ''    If e.Action = LibxConnectionActions.Find Then
            ''        Me.lblresponsable.Visible = True
            ''        Me.xtxresponsable.Visible = True
            ''    End If
            ''End If

            ''If e.Action = LibxConnectionActions.Edit Then
            ''    oParamValidar.AccessKey = "ED"
            ''    oAutorizar.PermisosAutorizados.Remove("ED")

            ''    If oAutorizar.isAutorization(oParamValidar) = False Then
            ''        e.Handled = True
            ''        Throw New ApplicationException("Autorización Invalida")
            ''    End If

            ''End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        Finally
            If e.Action = LibxConnectionActions.Accept And e.AcceptedAction = LibxConnectionActions.Edit Then
                oBloqueoDocumento.BorrarBloqueo(LibXConnector1.CurrentDataRow!ftserial_no, LibXConnector1.CurrentDataRow!type_code)
            End If
        End Try
    End Sub

    Private Sub btnTarjeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTarjeta.Click
        Try
            ShowPayMethod("TAR")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub ShowCajaInfo()
        '// Mostrar los datos de la caja y la cajera
        Me.xtxt_caja_code.Text = oCajaAbierta.CajaCode
        Me.xlk_caja_code.ExecuteFind()

        Me.xtxt_caje_code.Text = oCajaAbierta.CajeraCode
        Me.xlk_caje_code.ExecuteFind()
    End Sub

    Private Sub i_ptvfact01_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim close As String
        Dim XUpdate As LibX.Data.XUpdateStmt
        Try
            oProgram = New SGT.Administracion.Entidades.Program
            ''If Not oCajera Is Nothing AndAlso oCajera.esCajera = True AndAlso mCaja = True Then
            If mCaja = True Then
                oProgram.ProgramStopping(oParamRunning)
                close = MessageBox.Show("Sacar la caja para el Cuadre", "PREPARAR PARA CUADRE", MessageBoxButtons.YesNo)
                If close = System.Windows.Forms.DialogResult.Yes Then
                    If ValidarFacturaPendiente(oCajaAbierta.Serial) = True And oCaja.Domicilio = True Then
                        Throw New ApplicationException("TIENE DOMICILIO PENDIENTE, NO SE PUEDE SERRAR PARA CUADRE")
                    End If
                    oParamValidar.AccessKey = "AC"
                    oAutorizar.PermisosAutorizados.Remove("AC")
                    If oAutorizar.isAutorization(oParamValidar) = False Then
                        Throw New ApplicationException("Autorización Invalida")
                    Else
                        XUpdate = New LibX.Data.XUpdateStmt("cjinitm")
                        XUpdate.FieldsSet("init_status") = 3
                        XUpdate.Fields("init_serial") = oCajaAbierta.Serial
                        XUpdate.Execute()
                    End If
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnIngresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresos.Click
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams
            oParam.Value = oCajaAbierta.Serial
            oParam.Datos.Add("caje_code", oCajaAbierta.CajeraCode)
            oParam.initMode = LibxInitModes.Insert

            LibX.App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("i_ptvrecib01", "PTV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub btnestafetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnestafetas.Click
        Dim oParam As LibX.LibxPrgParams
        Try
            oParam = New LibX.LibxPrgParams
            oParam.Value = oCajaAbierta.Serial
            ''oParam.Datos.Add("caje_code", oCajaAbierta.CajeraCode)
            oParam.initMode = LibxInitModes.Insert

            LibX.App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("i_sfcobrm01", "PTV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnExistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExistencia.Click
        Dim oParam As LibX.LibxPrgParams
        Try

            oParam = New LibX.LibxPrgParams
            With oParam
                .WhereToExecute = "ivitemv1.item_code = '" & LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColitem_code) & "'" ''and ivitemv1.whse_code <> " & WhDefault
            End With

            LibX.App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("c_whsemq", "PTV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultqueryValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultQueryValues) Handles LibXConnector1.SettingDefaultqueryValues
        Me.xdt_fact_date.Value = oCajaAbierta.Fecha
        ShowCajaInfo()
    End Sub

    Private Sub xdt_fact_date_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles xdt_fact_date.KeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                If LibXConnector1.IsEditing And LibXConnector1.CurrentAction = LibxConnectionActions.Find Then
                    Me.xdt_fact_date.Value = DBNull.Value
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        '''Dim ReportDoc As ReportDocument  '// r_pvfact01
        '''Dim LogInfo As TableLogOnInfo
        '''Dim ConnInfo As CrystalDecisions.Shared.ConnectionInfo
        '''Dim p_ftserial_no As Integer

        '''Dim crParameterDiscreteValue As ParameterDiscreteValue
        '''Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        '''Dim crParameterFieldLocation As ParameterFieldDefinition
        '''Dim crParameterValues As ParameterValues


        '''Try
        '''    If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
        '''        ReportDoc = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        '''        ReportDoc.Load(LibX.GetReportPath("PTV", "r_pvfact01.rpt"), CrystalDecisions.[Shared].OpenReportMethod.OpenReportByTempCopy)
        '''        p_ftserial_no = CType(LibXConnector1.CurrentDataRow!ftserial_no, Integer)

        '''        ''For Each oTable As CrystalDecisions.CrystalReports.Engine.Table In ReportDoc.Database.Tables
        '''        ''    LogInfo = oTable.LogOnInfo
        '''        ''    ConnInfo = LogInfo.ConnectionInfo

        '''        ''    ConnInfo.DatabaseName = "sgf"
        '''        ''    ConnInfo.Password = "sa"
        '''        ''    ConnInfo.UserID = "sa"
        '''        ''    ConnInfo.ServerName = "DNCDLAP1"

        '''        ''    LogInfo.ConnectionInfo = ConnInfo
        '''        ''    oTable.ApplyLogOnInfo(LogInfo)
        '''        ''Next

        '''        crParameterFieldDefinitions = ReportDoc.DataDefinition.ParameterFields

        '''        ' Add a parameter value - START
        '''        crParameterFieldLocation = crParameterFieldDefinitions.Item("p_ftserial_no")
        '''        crParameterValues = crParameterFieldLocation.CurrentValues
        '''        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        '''        crParameterDiscreteValue.Value = p_ftserial_no
        '''        crParameterValues.Add(crParameterDiscreteValue)
        '''        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)
        '''        ' Add a parameter value - END

        '''        ReportDoc.PrintOptions.PrinterName = PrinterSettings.InstalledPrinters(0)
        '''        ReportDoc.SetDatabaseLogon("sa", "sa", "DNCDLAP1", "sgf")
        '''        '//ReportDoc.SetParameterValue("p_ftserial_no", p_ftserial_no.ToString)

        '''        ReportDoc.ExportToDisk(ExportFormatType.RichText, "c:\reporte.txt") '// (1, False, 1, 1)

        '''    End If

        '''Catch ex As Exception
        '''    LibX.Log.Show(ex)
        '''End Try
    End Sub

    Private Sub LibXGrid1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles LibXGrid1.Enter
        Try
            If LibXConnector1.IsDataEditing = True Then
                Me.LibXGrid1.Focus(LibXGrid1.currentRowNum, 0)
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xtxt_descuento_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles xtxt_descuento.Enter
        Try
            If LibXConnector1.IsDataEditing = True Then
                xtxt_descuento.Select(0, xtxt_descuento.Text.Length)
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXNavigator1_ActionClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.ActionClick
        Dim Descuento As Decimal
        Dim Cantidad As Integer
        Dim Unidad As String
        Dim Existencia As Integer
        Dim Result As Boolean = True
        Dim Precio As Decimal
        Dim ErrDistr As Boolean = False

        Dim oUnidad As New SGT.Inventario.Entidades.UnidadMedida
        Dim oUnidadParam As New SGT.Inventario.Entidades.UnidadMedida.ParametroConvertirUnidadMinima

        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Accept _
            AndAlso (LibXConnector1.CurrentAction = LibxConnectionActions.Add _
            OrElse LibXConnector1.CurrentAction = LibxConnectionActions.Edit) Then

                If LibXGrid1.getCurrentGridView.Count > 0 Then
                    If Not LibX.IsNull(LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColexistencia)) _
                                                And Not LibX.IsNull(LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColQty)) Then

                        Existencia = Val(LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColexistencia).ToString.Trim)


                        If LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColQty) = 0 Then
                            Throw New ApplicationException("No se puede grabar el documento con productos en cero(0)")
                        End If

                        If LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColitem_code) = "" And LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColQty) > 0 Then
                            Throw New ApplicationException("Hay una linea sin codigo, VERIFIQUE Y eliminela!")
                        End If

                        If LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColQty) > 0 And _
                            LibX.IsNull(LibXGrid1.SetValue(LibXGrid1.currentRowNum, Me.gColImporte)).ToString.Trim Then
                            Throw New ApplicationException("Verifique la existencia y facture bien los productos!")
                        Else
                            If ValidarMontoUnidades() = False Then
                                Throw New ApplicationException("Este Documento tiene error con la cantidad o la unidad facturada Verifique!")
                            End If
                            CalcularNeto()
                        End If
                    End If
                End If
                ''If LibXConnector1.CurrentAction = LibxConnectionActions.Add Then
                ''    If Me.lblresponsable.Visible = True Or Me.xtxresponsable.Visible = True Then
                ''        Me.lblresponsable.Visible = False
                ''        Me.xtxresponsable.Visible = False
                ''    End If
                ''End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub btnOpenCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenCash.Click
        '//EMR
        Try
            oParamValidar.AccessKey = "OC"
            oAutorizar.PermisosAutorizados.Remove("OC")

            If oAutorizar.isAutorization(oParamValidar) = False Then
                Throw New ApplicationException("Autorización Invalida")
            End If

            Open_CashDrawer(MaquinaAutorizada)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xlk_item_code_CreatingGridColumns(ByVal sender As Object, ByVal e As LibX.CreatingGridColumnsEventArgs) Handles xlk_item_code.CreatingGridColumns
        If e.handled = True Then
        End If
    End Sub
    Private Function ValidarMontoUnidades() As Boolean
        Dim mUnidad As String
        Dim montoCalculado As Decimal = 0.0
        Dim Descuento As Decimal
        Dim Importe As Decimal
        Dim Cantidad As Integer

        Dim oUnidad As UnidadMedida
        Dim oParam As UnidadMedida.ParametroConvertirValor
        Try
            If LibXConnector1.IsDataEditing = True Then
                oUnidad = New UnidadMedida
                oParam = New UnidadMedida.ParametroConvertirValor

                For Each oRow As DataRow In ftfactd.Select(1 = 1)
                    mUnidad = oUnidad.ConfirmarUnidad(LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColitem_code), LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColUnit_code))
                    If mUnidad = "" Then
                        Return False
                        Exit For
                    End If
                    oParam.Valor = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColPrecio)
                    oParam.Producto = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColitem_code)
                    oParam.UnidadDestino = mUnidad
                    oParam.UnidadOrigen = mUnidad

                    oUnidad.ConvertirValor(oParam)

                    LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColPrecio, Format(oParam.Retorno.Valor, "##,###,##0.00"))

                    If mConfig.GetDSCTO > 0 And Me.xtxt_type_code.Text.Trim = "FPV" And mDsctoManual = False Then
                        oCalcularDscto = New SGT.Inventario.Entidades.Articulo.ParametrosCalculardescuentos

                        With oCalcularDscto
                            .Almacen = WhDefault
                            .Producto = LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColitem_code)
                            .Monto = (Val(LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColPrecio)) * _
                                      Val(LibXGrid1.GetValue(LibXGrid1.currentRowNum, gColQty)))
                        End With

                        Descuento = oProducto.CalcularDscto(oCalcularDscto)

                        LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColDescuento, Format(Descuento, "##,###,##0.00"))
                    End If

                    montoCalculado = Val(ftfactd.Compute("sum(Importe)", "1=1").ToString.Trim) _
                                           + Val(ftfactd.Compute("sum(dscto)", "1=1").ToString.Trim) _
                                           - Val(ftfactd.Compute("sum(itbis)", "1=1").ToString.Trim)
                Next
                montoCalculado = Format(montoCalculado, "##,###,##0.00")
                If LibX.IsNull(Me.xtxt_fact_total.Text) Then
                    Me.xtxt_fact_total.Text = 0.0
                End If
                If Me.xtxt_fact_total.Text <> montoCalculado Then
                    Return False
                Else
                    Return True
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Function

    Private Sub xtxt_descuento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xtxt_descuento.TextChanged
        Dim dst, pdst As Decimal
        Dim dscnt As String
        Try
            If oClienteDomicilio.FormaPago = "TAR" Then
                If xtxt_descuento.Text.EndsWith("%") Then
                    pdst = Val(Me.xtxt_descuento.Text.Substring(0, xtxt_descuento.Text.IndexOf("%")).Trim)
                    If pdst > mConfig.GetDsctoTar Then
                        dst = Decimal.Round(xtxt_fact_total.Text * (mConfig.GetDsctoTar / 100), 3)
                        Me.xtxt_descuento.Text = dst
                        Distribuye_descuento(mConfig.GetDsctoTar)
                    End If
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Function LibxRound(ByVal value As Object, ByVal digits As Integer) As Decimal

        Dim m_value As Decimal = 0.0

        Try
            m_value = Decimal.Parse(value)

            m_value = Math.Round(m_value, digits)
        Catch ex As Exception

        End Try

        Return m_value
    End Function


    Private Function CreateFactory() As IPrintFiscal
        Dim Connected As Boolean = False

        'Note: To use Redsoft Open Connection
        Dim dbconn As SqlConnection = New SqlConnection(dbOPenn)

        Dim _dbHandler As IDbHandler = New PrintDbHandler(dbconn)

        Dim oCaja = mMachine.Machine

        Dim factory As PrinterFactory = _
        New PrinterFactory( _
        New ParametroRepository(_dbHandler), _
        New ImpresoraRepository(_dbHandler), _
        New ExtensionRepository(_dbHandler), _
        New TipoPagoRepository(_dbHandler))

        'Pasando Dependencia por una propiedad
        factory.ErrorRetorno = New ErrorRetornoRepository(_dbHandler)

        Dim print As IPrintFiscal = New ImpresionFiscalEpson(factory, Epson, 1, oCaja)

        Return print

    End Function

    Private Sub CancelarFactura()
        Dim printer As IPrintFiscal = CreateFactory()
        printer.CancelarImpresionFiscal()
    End Sub


    Private Function ValidatePrinterStatus() As ImpresoraFisica

        Dim printer As IPrintFiscal = CreateFactory()

        Dim printFisic As ImpresoraFisica

        Return printer.ValidaPrinterStatus()

    End Function

    Private Function OpenPrinter() As Boolean

        Dim Connected As Boolean = False

        Dim print As IPrintFiscal = CreateFactory()

        Try
            Connected = print.Connect(Puerto.COM1, Velocidad.br9600)
        Catch ex As Exception
            Throw New Exception("Impresora no esta lista para imprimir. Favor Revisar")
        End Try

        Return Connected

    End Function


    Private Sub btnCancelarImpresion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarImpresion.Click
        Try
            If OpenPrinter() Then
                Dim PrinFisic As ImpresoraFisica = ValidatePrinterStatus()
                If PrinFisic.IsSucess AndAlso PrinFisic.ReturnCode = 0 Then
                    Try
                        CancelarFactura()
                    Catch ex As Exception

                    End Try
                Else
                    MessageBox.Show("Impresora no esta lista. verificar Conexion. ", _
                                    "Impresora no esta lista", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            Else
                MessageBox.Show("El Puerto de la impresora no esta disponible para usar.", _
                                "Impresora no esta lista", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            Log.Add(ex)
        End Try

    End Sub

End Class
