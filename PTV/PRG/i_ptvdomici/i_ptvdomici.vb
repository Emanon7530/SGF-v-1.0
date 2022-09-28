Imports LibX
Imports SGT.Caja.Entidades
Imports SGT.Inventario.Entidades
Imports SGT.Facturacion.Entidades
Imports SGT.PuntodeVenta.Entidades
Imports System.Drawing.Printing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class i_ptvdomici
    Inherits System.Windows.Forms.Form
    Dim mFontofactura As SGT.PuntodeVenta.Entidades.MontoFactura
    Dim oDocumento As SGT.Inventario.Entidades.Documento
    Dim oParametroNCF As SGT.Facturacion.Entidades.ParametrosCreditoFiscal
    Dim ofctDocumento As SGT.Facturacion.Entidades.Documento
    Dim oDomicilio As SGT.PuntodeVenta.Entidades.MontoFactura
    Dim oCaja As Caja
    Dim oCajera As Cajera
    Dim oCajaAbierta As CajaAbierta
    Dim mVendedor As Cajera
    Dim oProducto As SGT.Inventario.Entidades.Articulo
    Dim oSeguro As SGT.PuntodeVenta.Entidades.SegurosMedicos
    Dim oBloqueoDocumento As SGT.PuntodeVenta.Entidades.BloqueoFactua
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
    Dim oParamRunning As SGT.Administracion.Entidades.Program.ParametroRunning
    Dim oProgram As SGT.Administracion.Entidades.Program
    Dim mMachine As SGT.Administracion.Entidades.Program.Autentication
    Dim mConfig As SGT.Inventario.Common.Configuration
    Dim _XtControl_serial As Integer
    Dim mCaja As Boolean = False
    Dim mLastKeyPressedInGrid As Windows.Forms.Keys
    Dim MaquinaAutorizada As String
    Dim isDomicilio As Boolean
    Dim mControlado As Integer
    Dim mDsctoManual As Boolean = False
    Dim ncfType As Integer
    Dim WhDefaultNo As Integer

    Public Class Factura
        Public Serial As Integer
        Public Cliente As Integer
        Public Type As String
        Public Is_Domi As Integer
        Public mCambio As Decimal
        Public Status As Integer
        Public MontoFacturado As Decimal
        Public MontoNeto As Decimal
        Public MontoBruto As Decimal
    End Class

    Dim oFactura As Factura

    Public Property FacturaSelected() As Factura
        Get
            Return oFactura
        End Get
        Set(ByVal Value As Factura)
            oFactura = Value
        End Set
    End Property
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
            End If
        Next

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
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents gColftserial_no As LibX.XEditTextBoxColumn
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents LibXGrid2 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle2 As LibX.XdataGridTableStyle
    Friend WithEvents gcolItem_code As LibX.XEditTextBoxColumn
    Friend WithEvents gColitem_name As LibX.XEditTextBoxColumn
    Friend WithEvents gcolqty As LibX.XEditTextBoxColumn
    Friend WithEvents gcolPrice As LibX.XEditTextBoxColumn
    Friend WithEvents ftfactm As System.Data.DataTable
    Friend WithEvents PicCobro As System.Windows.Forms.PictureBox
    Friend WithEvents picEspera As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents xtxTotalFacturado As LibX.XTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents gColtypeCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents gColCliente As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents gColHora As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents gColSector_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
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
    Friend WithEvents gColDomisi As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents gColStatus As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnCobrar As System.Windows.Forms.Button
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents gColcust_code As LibX.XEditTextBoxColumn
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents xtxCambio As System.Windows.Forms.Label
    Friend WithEvents xtxVuelto As System.Windows.Forms.Label
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents gColCambio As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents gColUnid As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn7 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn8 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn9 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents xcbo_domicilio As LibX.LibXCombo
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents XEditTextBoxColumn4 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(i_ptvdomici))
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
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
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
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.gColHora = New System.Windows.Forms.DataGridTextBoxColumn
        Me.XEditTextBoxColumn7 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn8 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn9 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.gColtypeCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColCliente = New LibX.XEditTextBoxColumn
        Me.gColSector_name = New System.Windows.Forms.DataGridTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.gColftserial_no = New LibX.XEditTextBoxColumn
        Me.gColDomisi = New LibX.XEditTextBoxColumn
        Me.gColStatus = New LibX.XEditTextBoxColumn
        Me.gColcust_code = New LibX.XEditTextBoxColumn
        Me.gColCambio = New LibX.XEditTextBoxColumn
        Me.btnCancel = New System.Windows.Forms.Button
        Me.LibXGrid2 = New LibX.LibXGrid
        Me.XdataGridTableStyle2 = New LibX.XdataGridTableStyle
        Me.gcolItem_code = New LibX.XEditTextBoxColumn
        Me.gColitem_name = New LibX.XEditTextBoxColumn
        Me.gcolqty = New LibX.XEditTextBoxColumn
        Me.gColUnid = New LibX.XEditTextBoxColumn
        Me.gcolPrice = New LibX.XEditTextBoxColumn
        Me.PicCobro = New System.Windows.Forms.PictureBox
        Me.picEspera = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.xtxTotalFacturado = New LibX.XTextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCobrar = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.DataView1 = New System.Data.DataView
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.xtxCambio = New System.Windows.Forms.Label
        Me.xtxVuelto = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.xcbo_domicilio = New LibX.LibXCombo
        Me.btnView = New System.Windows.Forms.Button
        Me.XEditTextBoxColumn4 = New LibX.XEditTextBoxColumn
        Me.DataColumn58 = New System.Data.DataColumn
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftfactm, Me.DataTable2, Me.DataTable1})
        '
        'ftfactm
        '
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58})
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
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "type_name"
        Me.DataColumn2.MaxLength = 30
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "fact_date"
        Me.DataColumn3.DataType = GetType(System.DateTime)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "fact_nota"
        Me.DataColumn4.MaxLength = 80
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "caja_name"
        Me.DataColumn5.MaxLength = 20
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "vend_name"
        Me.DataColumn6.MaxLength = 60
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "caja_code"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "caje_code"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "vend_code"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "caje_name"
        Me.DataColumn10.MaxLength = 60
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "type_code"
        Me.DataColumn16.MaxLength = 3
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "bus_name"
        Me.DataColumn17.MaxLength = 40
        Me.DataColumn17.ReadOnly = True
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "fact_time"
        Me.DataColumn18.MaxLength = 30
        Me.DataColumn18.ReadOnly = True
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "factura"
        Me.DataColumn19.MaxLength = 9
        Me.DataColumn19.ReadOnly = True
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "fact_inddomicilio"
        Me.DataColumn20.DataType = GetType(System.Int32)
        Me.DataColumn20.ReadOnly = True
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sector_name"
        Me.DataColumn21.MaxLength = 30
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "whse_code"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "cust_serial"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "fact_ncf"
        Me.DataColumn42.MaxLength = 40
        '
        'DataColumn43
        '
        Me.DataColumn43.AllowDBNull = False
        Me.DataColumn43.ColumnName = "fact_status"
        Me.DataColumn43.DataType = GetType(System.Int32)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "domicilio"
        Me.DataColumn44.MaxLength = 9
        Me.DataColumn44.ReadOnly = True
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "Domitipo"
        Me.DataColumn45.MaxLength = 9
        Me.DataColumn45.ReadOnly = True
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "Column1"
        Me.DataColumn46.DataType = GetType(System.Int32)
        Me.DataColumn46.ReadOnly = True
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "cust_code"
        Me.DataColumn47.DataType = GetType(System.Int32)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "tarj_numero"
        Me.DataColumn48.MaxLength = 30
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "domi_cambio"
        Me.DataColumn49.DataType = GetType(System.Decimal)
        Me.DataColumn49.ReadOnly = True
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "EstadoDomicilio"
        Me.DataColumn51.MaxLength = 12
        Me.DataColumn51.ReadOnly = True
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "prep_time"
        Me.DataColumn52.DataType = GetType(System.DateTime)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "envio_time"
        Me.DataColumn53.DataType = GetType(System.DateTime)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "cobrado_time"
        Me.DataColumn54.DataType = GetType(System.DateTime)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "prepara_time"
        Me.DataColumn55.MaxLength = 30
        Me.DataColumn55.ReadOnly = True
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "enviado_time"
        Me.DataColumn56.MaxLength = 30
        Me.DataColumn56.ReadOnly = True
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "cobradod_time"
        Me.DataColumn57.MaxLength = 30
        Me.DataColumn57.ReadOnly = True
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn50})
        Me.DataTable2.TableName = "ftfactd"
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "ftserial_no"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "item_code"
        Me.DataColumn12.MaxLength = 10
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "item_name"
        Me.DataColumn13.MaxLength = 100
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "qty"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "price"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn50
        '
        Me.DataColumn50.AllowDBNull = False
        Me.DataColumn50.ColumnName = "unit_code"
        Me.DataColumn50.MaxLength = 4
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41})
        Me.DataTable1.TableName = "ftfactmm"
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.AutoIncrement = True
        Me.DataColumn24.ColumnName = "ftserial_no"
        Me.DataColumn24.DataType = GetType(System.Int32)
        Me.DataColumn24.ReadOnly = True
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "whse_code"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "cust_serial"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "type_code"
        Me.DataColumn27.MaxLength = 3
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.ColumnName = "type_name"
        Me.DataColumn28.MaxLength = 30
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "fact_date"
        Me.DataColumn29.DataType = GetType(System.DateTime)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "bus_name"
        Me.DataColumn30.MaxLength = 40
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "fact_time"
        Me.DataColumn31.MaxLength = 10
        '
        'DataColumn32
        '
        Me.DataColumn32.AllowDBNull = False
        Me.DataColumn32.ColumnName = "caja_name"
        Me.DataColumn32.MaxLength = 20
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "caje_name"
        Me.DataColumn33.MaxLength = 60
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "fact_inddomicilio"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "caja_code"
        Me.DataColumn35.DataType = GetType(System.Int32)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "caje_code"
        Me.DataColumn36.DataType = GetType(System.Int32)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "vend_code"
        Me.DataColumn37.DataType = GetType(System.Int32)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "vend_name"
        Me.DataColumn38.MaxLength = 60
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "sector_name"
        Me.DataColumn39.MaxLength = 30
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "fact_ncf"
        Me.DataColumn40.MaxLength = 40
        '
        'DataColumn41
        '
        Me.DataColumn41.AllowDBNull = False
        Me.DataColumn41.ColumnName = "fact_status"
        Me.DataColumn41.DataType = GetType(System.Int32)
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = True
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Documentos"
        Me.LibXGrid1.CaptionVisible = False
        Me.LibXGrid1.DataMember = "ftfactm"
        Me.LibXGrid1.DataSource = Me.LibXConnector1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = True
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 27)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(1016, 360)
        Me.LibXGrid1.TabIndex = 0
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
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
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = New String() {Nothing}
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "ftserial_no"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"", "select ftfactm.ftserial_no,whse_code,cust_serial,ftfactm.type_code ,[type_name],f" & _
        "act_date,", "substring(bus_name,1,40)bus_name,CONVERT(VARCHAR,domi_date,8) as fact_time,", "CONVERT(VARCHAR,domi_preparado,8) as prepara_time, ", "CONVERT(VARCHAR,domi_envio,8) as enviado_time,CONVERT(VARCHAR,domi_cobrado,8) as " & _
        "cobradod_time, ", "ftfactm.cust_code,", "caja_name, cjcajeram.vend_name caje_name,isnull(fact_inddomicilio,0)fact_inddomic" & _
        "ilio", ",ftfactm.caja_code,ftfactm.caje_code,ftfactm.vend_code,  ", "ftvendm.vend_name,sctorcity.sector_name,fact_ncf,fact_status,", "case WHEN isnull(ftfactm.fact_inddomicilio,0) =1 then 'DOMICILIO'  ", "     when ftfactm.type_code = 'FSG' then 'SEGURO'", "     when ftfactm.type_code = 'DEV' then 'DEVOLUCIO' else 'FACTURA'  ", "      end Domitipo,ftdomitar.tarj_numero,isnull(ftdomimseg.domi_cambio,0) domi_ca" & _
        "mbio,", "case WHEN ftfactm.fact_status = 5 then 'POR PREPARAR'  ", "     when ftfactm.fact_status = 4 then 'POR COBRAR'  ", "     when ftfactm.fact_status = 2 then 'COBRADO'  ", "     else 'PREPADRADO' end EstadoDomicilio,", "case WHEN ftdomimseg.domi_pago = 'EFE' then 'EFECTIVO'", "     WHEN ftdomimseg.domi_pago = 'CXC' then 'CREDITO'", "     else 'TARJETA' end condicion", "from ftfactm ", "inner join cjcajam on ftfactm.caja_code = cjcajam.caja_code", "       and ftfactm.ftserial_no in(select ftserial_no from ftfactd)", "inner join ftvendm cjcajeram on ftfactm.caje_code = cjcajeram.vend_code", "inner join ftvendm on ftfactm.vend_code = ftvendm.vend_code", "left outer join sctorcity on ftfactm.cust_code =sctorcity.cust_code", "inner join ivtypem on ftfactm.type_code = ivtypem.type_code", "left outer join ftdomitar on ftfactm.ftserial_no =ftdomitar.ftserial_no", "inner join ftdomimseg on ftfactm.ftserial_no =ftdomimseg.ftserial_no", "where ftfactm.type_code in('FPV','FSG','FTS','DEV')", "      and ftfactm.fact_inddomicilio = 1  and ftfactm.fact_status in(1,2,4,5)", ""}
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
        Me.LibXDbSourceTable2.InnerJon = True
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"ftserial_no=ftserial_no"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select ftserial_no,ftfactd.item_code,item_name,ftfactd.unit_code,qty,price", "from ftfactd", "inner join ivitemm", "on ivitemm.item_code = ftfactd.item_code", "", ""}
        Me.LibXDbSourceTable2.TableName = "ftfactd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XEditTextBoxColumn2, Me.gColHora, Me.XEditTextBoxColumn7, Me.XEditTextBoxColumn8, Me.XEditTextBoxColumn9, Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn4, Me.gColtypeCode, Me.gColCliente, Me.gColSector_name, Me.XEditTextBoxColumn3, Me.gColftserial_no, Me.gColDomisi, Me.gColStatus, Me.gColcust_code, Me.gColCambio})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ftfactm"
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Fecha"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "fact_date"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 70
        '
        'gColHora
        '
        Me.gColHora.Format = ""
        Me.gColHora.FormatInfo = Nothing
        Me.gColHora.HeaderText = "Facturado"
        Me.gColHora.MappingName = "fact_time"
        Me.gColHora.Width = 60
        '
        'XEditTextBoxColumn7
        '
        Me.XEditTextBoxColumn7.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn7.Format = ""
        Me.XEditTextBoxColumn7.FormatInfo = Nothing
        Me.XEditTextBoxColumn7.HeaderText = "Preparado"
        Me.XEditTextBoxColumn7.ImageList = Nothing
        Me.XEditTextBoxColumn7.isReadOnly = False
        Me.XEditTextBoxColumn7.MappingName = "prepara_time"
        Me.XEditTextBoxColumn7.MaxLength = 32767
        Me.XEditTextBoxColumn7.TabStop = True
        Me.XEditTextBoxColumn7.UseCustomCellFormat = False
        Me.XEditTextBoxColumn7.Width = 60
        '
        'XEditTextBoxColumn8
        '
        Me.XEditTextBoxColumn8.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn8.Format = ""
        Me.XEditTextBoxColumn8.FormatInfo = Nothing
        Me.XEditTextBoxColumn8.HeaderText = "Enviado"
        Me.XEditTextBoxColumn8.ImageList = Nothing
        Me.XEditTextBoxColumn8.isReadOnly = False
        Me.XEditTextBoxColumn8.MappingName = "enviado_time"
        Me.XEditTextBoxColumn8.MaxLength = 32767
        Me.XEditTextBoxColumn8.TabStop = True
        Me.XEditTextBoxColumn8.UseCustomCellFormat = False
        Me.XEditTextBoxColumn8.Width = 60
        '
        'XEditTextBoxColumn9
        '
        Me.XEditTextBoxColumn9.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn9.Format = ""
        Me.XEditTextBoxColumn9.FormatInfo = Nothing
        Me.XEditTextBoxColumn9.HeaderText = "Cobrado"
        Me.XEditTextBoxColumn9.ImageList = Nothing
        Me.XEditTextBoxColumn9.isReadOnly = False
        Me.XEditTextBoxColumn9.MappingName = "cobradod_time"
        Me.XEditTextBoxColumn9.MaxLength = 32767
        Me.XEditTextBoxColumn9.TabStop = True
        Me.XEditTextBoxColumn9.UseCustomCellFormat = False
        Me.XEditTextBoxColumn9.Width = 60
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Estado Domicilio"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "EstadoDomicilio"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 110
        '
        'gColtypeCode
        '
        Me.gColtypeCode.Format = ""
        Me.gColtypeCode.FormatInfo = Nothing
        Me.gColtypeCode.HeaderText = "Tipo"
        Me.gColtypeCode.MappingName = "type_code"
        Me.gColtypeCode.Width = 30
        '
        'gColCliente
        '
        Me.gColCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColCliente.Format = ""
        Me.gColCliente.FormatInfo = Nothing
        Me.gColCliente.HeaderText = "Cliente"
        Me.gColCliente.ImageList = Nothing
        Me.gColCliente.isReadOnly = False
        Me.gColCliente.MappingName = "bus_name"
        Me.gColCliente.MaxLength = 32767
        Me.gColCliente.TabStop = True
        Me.gColCliente.UseCustomCellFormat = False
        Me.gColCliente.Width = 200
        '
        'gColSector_name
        '
        Me.gColSector_name.Format = ""
        Me.gColSector_name.FormatInfo = Nothing
        Me.gColSector_name.HeaderText = "Sector"
        Me.gColSector_name.MappingName = "sector_name"
        Me.gColSector_name.Width = 140
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Facturado"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = False
        Me.XEditTextBoxColumn3.MappingName = "vend_name"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.TabStop = True
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 75
        '
        'gColftserial_no
        '
        Me.gColftserial_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColftserial_no.Format = ""
        Me.gColftserial_no.FormatInfo = Nothing
        Me.gColftserial_no.ImageList = Nothing
        Me.gColftserial_no.isReadOnly = False
        Me.gColftserial_no.MappingName = "ftserial_no"
        Me.gColftserial_no.MaxLength = 32767
        Me.gColftserial_no.TabStop = True
        Me.gColftserial_no.UseCustomCellFormat = False
        Me.gColftserial_no.Width = 0
        '
        'gColDomisi
        '
        Me.gColDomisi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColDomisi.Format = ""
        Me.gColDomisi.FormatInfo = Nothing
        Me.gColDomisi.ImageList = Nothing
        Me.gColDomisi.isReadOnly = False
        Me.gColDomisi.MappingName = "fact_inddomicilio"
        Me.gColDomisi.MaxLength = 32767
        Me.gColDomisi.ReadOnly = True
        Me.gColDomisi.TabStop = True
        Me.gColDomisi.UseCustomCellFormat = False
        Me.gColDomisi.Width = 0
        '
        'gColStatus
        '
        Me.gColStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColStatus.Format = ""
        Me.gColStatus.FormatInfo = Nothing
        Me.gColStatus.ImageList = Nothing
        Me.gColStatus.isReadOnly = False
        Me.gColStatus.MappingName = "fact_status"
        Me.gColStatus.MaxLength = 32767
        Me.gColStatus.TabStop = True
        Me.gColStatus.UseCustomCellFormat = False
        Me.gColStatus.Width = 0
        '
        'gColcust_code
        '
        Me.gColcust_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColcust_code.Format = ""
        Me.gColcust_code.FormatInfo = Nothing
        Me.gColcust_code.ImageList = Nothing
        Me.gColcust_code.isReadOnly = False
        Me.gColcust_code.MappingName = "cust_code"
        Me.gColcust_code.MaxLength = 32767
        Me.gColcust_code.TabStop = True
        Me.gColcust_code.UseCustomCellFormat = False
        Me.gColcust_code.Width = 0
        '
        'gColCambio
        '
        Me.gColCambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColCambio.Format = ""
        Me.gColCambio.FormatInfo = Nothing
        Me.gColCambio.ImageList = Nothing
        Me.gColCambio.isReadOnly = False
        Me.gColCambio.MappingName = "domi_cambio"
        Me.gColCambio.MaxLength = 32767
        Me.gColCambio.TabStop = True
        Me.gColCambio.UseCustomCellFormat = False
        Me.gColCambio.Width = 0
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(838, 594)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 32)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cerrar"
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Cancelar la operación y cerrar esta pantalla")
        '
        'LibXGrid2
        '
        Me.LibXGrid2.AutoAdjustLastColumn = True
        Me.LibXGrid2.AutoSearch = False
        Me.LibXGrid2.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid2.DataMember = "ftfactd"
        Me.LibXGrid2.DataSource = Me.LibXConnector1
        Me.LibXGrid2.FullRowSelect = False
        Me.LibXGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid2.IsReadOnly = True
        Me.LibXGrid2.Location = New System.Drawing.Point(8, 392)
        Me.LibXGrid2.Name = "LibXGrid2"
        Me.LibXGrid2.ReadOnly = True
        Me.LibXGrid2.searchText = ""
        Me.LibXGrid2.showFooterBar = False
        Me.LibXGrid2.Size = New System.Drawing.Size(616, 144)
        Me.LibXGrid2.TabIndex = 4
        Me.LibXGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle2})
        Me.LibXGrid2.UseAutoFillLines = True
        Me.LibXGrid2.UseHandCursor = False
        '
        'XdataGridTableStyle2
        '
        Me.XdataGridTableStyle2.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.XdataGridTableStyle2.DataGrid = Me.LibXGrid2
        Me.XdataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gcolItem_code, Me.gColitem_name, Me.gcolqty, Me.gColUnid, Me.gcolPrice})
        Me.XdataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle2.MappingName = "ftfactd"
        '
        'gcolItem_code
        '
        Me.gcolItem_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolItem_code.Format = ""
        Me.gcolItem_code.FormatInfo = Nothing
        Me.gcolItem_code.HeaderText = "Producto"
        Me.gcolItem_code.ImageList = Nothing
        Me.gcolItem_code.isReadOnly = True
        Me.gcolItem_code.MappingName = "item_code"
        Me.gcolItem_code.MaxLength = 32767
        Me.gcolItem_code.ReadOnly = True
        Me.gcolItem_code.TabStop = True
        Me.gcolItem_code.UseCustomCellFormat = False
        Me.gcolItem_code.Width = 60
        '
        'gColitem_name
        '
        Me.gColitem_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColitem_name.Format = ""
        Me.gColitem_name.FormatInfo = Nothing
        Me.gColitem_name.HeaderText = "Descripción"
        Me.gColitem_name.ImageList = Nothing
        Me.gColitem_name.isReadOnly = False
        Me.gColitem_name.MappingName = "item_name"
        Me.gColitem_name.MaxLength = 32767
        Me.gColitem_name.TabStop = True
        Me.gColitem_name.UseCustomCellFormat = False
        Me.gColitem_name.Width = 320
        '
        'gcolqty
        '
        Me.gcolqty.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gcolqty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolqty.Format = "###,###"
        Me.gcolqty.FormatInfo = Nothing
        Me.gcolqty.HeaderText = "Cantidadi"
        Me.gcolqty.ImageList = Nothing
        Me.gcolqty.isReadOnly = False
        Me.gcolqty.MappingName = "qty"
        Me.gcolqty.MaxLength = 32767
        Me.gcolqty.TabStop = True
        Me.gcolqty.UseCustomCellFormat = False
        Me.gcolqty.Width = 75
        '
        'gColUnid
        '
        Me.gColUnid.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColUnid.Format = ""
        Me.gColUnid.FormatInfo = Nothing
        Me.gColUnid.HeaderText = "Unidad"
        Me.gColUnid.ImageList = Nothing
        Me.gColUnid.isReadOnly = False
        Me.gColUnid.MappingName = "unit_code"
        Me.gColUnid.MaxLength = 32767
        Me.gColUnid.TabStop = True
        Me.gColUnid.UseCustomCellFormat = False
        Me.gColUnid.Width = 40
        '
        'gcolPrice
        '
        Me.gcolPrice.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gcolPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolPrice.Format = "#,###,##0.00"
        Me.gcolPrice.FormatInfo = Nothing
        Me.gcolPrice.HeaderText = "Precioi"
        Me.gcolPrice.ImageList = Nothing
        Me.gcolPrice.isReadOnly = False
        Me.gcolPrice.MappingName = "price"
        Me.gcolPrice.MaxLength = 32767
        Me.gcolPrice.TabStop = True
        Me.gcolPrice.UseCustomCellFormat = False
        Me.gcolPrice.Width = 80
        '
        'PicCobro
        '
        Me.PicCobro.Image = CType(resources.GetObject("PicCobro.Image"), System.Drawing.Image)
        Me.PicCobro.Location = New System.Drawing.Point(736, 392)
        Me.PicCobro.Name = "PicCobro"
        Me.PicCobro.Size = New System.Drawing.Size(280, 144)
        Me.PicCobro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCobro.TabIndex = 5
        Me.PicCobro.TabStop = False
        '
        'picEspera
        '
        Me.picEspera.Image = CType(resources.GetObject("picEspera.Image"), System.Drawing.Image)
        Me.picEspera.Location = New System.Drawing.Point(632, 392)
        Me.picEspera.Name = "picEspera"
        Me.picEspera.Size = New System.Drawing.Size(384, 144)
        Me.picEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEspera.TabIndex = 6
        Me.picEspera.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(336, 552)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total Facturado:"
        '
        'xtxTotalFacturado
        '
        Me.xtxTotalFacturado.AcceptsReturn = True
        Me.xtxTotalFacturado.BackColor = System.Drawing.SystemColors.HighlightText
        Me.xtxTotalFacturado.EditInitialValue = Nothing
        Me.xtxTotalFacturado.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxTotalFacturado.FieldDescription = ""
        Me.xtxTotalFacturado.FindInitialValue = Nothing
        Me.xtxTotalFacturado.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxTotalFacturado.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxTotalFacturado.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.xtxTotalFacturado.IgnoreRequiered = False
        Me.xtxTotalFacturado.Location = New System.Drawing.Point(472, 536)
        Me.xtxTotalFacturado.Name = "xtxTotalFacturado"
        Me.xtxTotalFacturado.NewInitialValue = Nothing
        Me.xtxTotalFacturado.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxTotalFacturado.Requiered = False
        Me.xtxTotalFacturado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xtxTotalFacturado.Size = New System.Drawing.Size(152, 39)
        Me.xtxTotalFacturado.StatusBarPanelDescripcion = Nothing
        Me.xtxTotalFacturado.TabIndex = 9
        Me.xtxTotalFacturado.Text = ""
        '
        'btnCobrar
        '
        Me.btnCobrar.AccessibleDescription = ""
        Me.btnCobrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCobrar.Location = New System.Drawing.Point(8, 594)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(96, 32)
        Me.btnCobrar.TabIndex = 25
        Me.btnCobrar.Text = "Preparar"
        Me.ToolTip1.SetToolTip(Me.btnCobrar, "Cobrar documentos Pendiente enviado a caja")
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(544, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "Refrescar"
        Me.ToolTip1.SetToolTip(Me.Button4, "Refrescar en pantalla todos los documentos enviados a la caja")
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(624, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "Todos"
        Me.ToolTip1.SetToolTip(Me.Button5, "Visualizar todos los documentos pendientes por cobrar de esta caja")
        '
        'DataView1
        '
        Me.DataView1.AllowDelete = False
        Me.DataView1.AllowNew = False
        Me.DataView1.Table = Me.ftfactm
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Location = New System.Drawing.Point(740, 594)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(96, 32)
        Me.btnBuscar.TabIndex = 34
        Me.btnBuscar.Text = "Buscar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(136, 552)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 22)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Cambio:"
        Me.Label3.Visible = False
        '
        'xtxCambio
        '
        Me.xtxCambio.BackColor = System.Drawing.SystemColors.Control
        Me.xtxCambio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xtxCambio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.xtxCambio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.xtxCambio.Location = New System.Drawing.Point(216, 552)
        Me.xtxCambio.Name = "xtxCambio"
        Me.xtxCambio.Size = New System.Drawing.Size(104, 22)
        Me.xtxCambio.TabIndex = 36
        Me.xtxCambio.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.xtxCambio.Visible = False
        '
        'xtxVuelto
        '
        Me.xtxVuelto.BackColor = System.Drawing.SystemColors.Control
        Me.xtxVuelto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xtxVuelto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.xtxVuelto.ForeColor = System.Drawing.Color.Red
        Me.xtxVuelto.Location = New System.Drawing.Point(632, 552)
        Me.xtxVuelto.Name = "xtxVuelto"
        Me.xtxVuelto.Size = New System.Drawing.Size(104, 22)
        Me.xtxVuelto.TabIndex = 37
        Me.xtxVuelto.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.xtxVuelto.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(14, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Estado:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_domicilio
        '
        Me.xcbo_domicilio.AllowDefaultSort = True
        Me.xcbo_domicilio.bound = True
        Me.xcbo_domicilio.currValue = Nothing
        Me.xcbo_domicilio.DefaultWhereString = Nothing
        Me.xcbo_domicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_domicilio.EditInitialValue = "5"
        Me.xcbo_domicilio.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_domicilio.FieldDescription = ""
        Me.xcbo_domicilio.FindInitialValue = "5"
        Me.xcbo_domicilio.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_domicilio.IgnoreRequiered = False
        Me.xcbo_domicilio.Items.AddRange(New Object() {"1-POR ENVIAR", "2-COBRADO", "4-POR COBRAR", "5-POR PREPARAR", ""})
        Me.xcbo_domicilio.Location = New System.Drawing.Point(88, 5)
        Me.xcbo_domicilio.LookupKeyDisplayFields = "EstadoDomicilio"
        Me.xcbo_domicilio.LookupKeyField = "EstadoDomicilio"
        Me.xcbo_domicilio.LookupTableName = "ftfactm"
        Me.xcbo_domicilio.Name = "xcbo_domicilio"
        Me.xcbo_domicilio.NewInitialValue = "5"
        Me.xcbo_domicilio.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_domicilio.Requiered = False
        Me.xcbo_domicilio.Required = False
        Me.xcbo_domicilio.Size = New System.Drawing.Size(256, 21)
        Me.xcbo_domicilio.SqlString = ""
        Me.xcbo_domicilio.StatusBarPanelDescripcion = Nothing
        Me.xcbo_domicilio.TabIndex = 39
        '
        'btnView
        '
        Me.btnView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnView.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Location = New System.Drawing.Point(168, 600)
        Me.btnView.Name = "btnView"
        Me.btnView.TabIndex = 42
        Me.btnView.Text = "Visualizar"
        Me.btnView.Visible = False
        '
        'XEditTextBoxColumn4
        '
        Me.XEditTextBoxColumn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn4.Format = ""
        Me.XEditTextBoxColumn4.FormatInfo = Nothing
        Me.XEditTextBoxColumn4.HeaderText = "Condicion"
        Me.XEditTextBoxColumn4.ImageList = Nothing
        Me.XEditTextBoxColumn4.isReadOnly = False
        Me.XEditTextBoxColumn4.MappingName = "condicion"
        Me.XEditTextBoxColumn4.MaxLength = 32767
        Me.XEditTextBoxColumn4.TabStop = True
        Me.XEditTextBoxColumn4.UseCustomCellFormat = False
        Me.XEditTextBoxColumn4.Width = 65
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "condicion"
        Me.DataColumn58.MaxLength = 8
        Me.DataColumn58.ReadOnly = True
        '
        'i_ptvdomici
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1026, 632)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.xcbo_domicilio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.xtxVuelto)
        Me.Controls.Add(Me.xtxCambio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.xtxTotalFacturado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picEspera)
        Me.Controls.Add(Me.PicCobro)
        Me.Controls.Add(Me.LibXGrid2)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "i_ptvdomici"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitoreo de Domicilio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub i_fthold01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ofctDocumento = New SGT.Facturacion.Entidades.Documento

        ''xcbo_vend_code.LoadDbItems(True)
        ''xcbo_caja_code.LoadDbItems(True)
        ''xcbo_caje_code.LoadDbItems(True)
        xcbo_domicilio.LoadDbItems(True)
        xcbo_domicilio.SelectedValue = 5

        WhDefaultNo = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibxWhDefaultNo").ToString)
        ''xcbo_caja_code.currValue = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibxDefaultCaja").ToString)
        ''xcbo_caje_code.currValue = LibX.User.UserID

        'RefreshGridHeader()

        Timer1.Enabled = True
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
                End If
            End If

            '// Boton Abrir Caja
            ''Me.btnOpenCash.Enabled = mCaja

            '// Buscar cajas abiertas
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
                oParam.Datos.Add("init_date", DateTime.Now)
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
                If hasCajas = False Then
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
                    .Program = "i_ptvhold01"
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
                        ''If AbrirCaja() = True Then
                        ''    'oProgram.ProgramStopping(oParamRunning)
                        ''Else
                        ''    Throw New ApplicationException("Necesita la intervension de un supervisor para iniciar esta maquina como cajera!")
                        ''End If
                    Else
                        Throw New ApplicationException("Necesita la intervension de un supervisor para iniciar esta maquina como cajera!")
                    End If
                End If
            End If

            '// hablilitar los botones si es caja
            ''Me.btnIngresos.Enabled = mCaja
            ''Me.btnestafetas.Enabled = mCaja
            ''Me.btnEgresos.Enabled = mCaja
            ''Me.btnCobrar.Enabled = mCaja
            ''Me.btnDomicilios.Enabled = mCaja

            '// Mostrar Caja y Cajera
            '//ShowCajaInfo()

            '// Validar Permisos de Usuario
            oParamValidar.UserID = LibX.User.UserID

            '// buscar el almacen por defecto
            Me.LibXGrid1.footerOperations.add("type_code", "count(type_code)")
            Me.LibXGrid1.getCurrentGridView.AllowDelete = False
            Me.LibXGrid1.getCurrentGridView.AllowEdit = False

            Me.LibXGrid1.getCurrentGridView.AllowNew = False
            RefreshGridHeader()
            
        Catch ex As Exception
            LibX.Log.Show(ex)
            Application.Exit()
            If CloseProgram = True Then
                Me.Close()
            End If
        End Try
    End Sub
    Private Sub RefreshGridHeader()
        Try
            'If Not LibXConnector1.Parameters Is Nothing Then
            '    If LibXConnector1.Parameters.Datos.Count > 0 Then
            '        'LibXConnector1.Find()
            '        If LibXConnector1.Parameters.Datos.Contains("caja_code") Then
            '            Me.xcbo_caja_code.currValue = LibXConnector1.Parameters.Datos.Item("caja_code")
            '        End If

            '        If LibXConnector1.Parameters.Datos.Contains("caje_code") Then
            '            Me.xcbo_caje_code.currValue = LibXConnector1.Parameters.Datos.Item("caje_code")
            '        End If

            '        If LibXConnector1.Parameters.Datos.Contains("vend_code") Then
            '            Me.xcbo_vend_code.currValue = LibXConnector1.Parameters.Datos.Item("vend_code")
            '        End If

            '        ''If LibXConnector1.Parameters.Datos.Contains("domicilio") Then
            '        ''    Me.xcbo_domicilio.currValue = LibXConnector1.Parameters.Datos.Item("domicilio")
            '        ''End If
            '    End If
            'End If

            '// Ejecuta 
            Dim CurrentIndex As Integer

            CurrentIndex = LibXGrid1.CurrentRowIndex
            LibXConnector1.ExecuteFind("fact_status in(1,2,4,5)")
            If CurrentIndex > 0 Then LibXGrid1.CurrentRowIndex = CurrentIndex

            SelectRow()
            RefreshDetail()

            ''LibXGrid1.Focus(CurrentIndex, 0)

            If oFactura.Is_Domi = 1 And oFactura.mCambio > 0 Then
                Me.xtxCambio.Visible = True
                Me.Label3.Visible = True
                Me.xtxVuelto.Visible = True
                Me.xtxCambio.Text = oFactura.mCambio
                Me.xtxVuelto.Text = Format(oFactura.mCambio - oFactura.MontoFacturado, "###,###,##0.00")
            Else
                Me.xtxCambio.Visible = False
                Me.Label3.Visible = False
                Me.xtxVuelto.Visible = False
            End If


        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery

        Dim fDate As String
        Dim sfDate As String
        Dim cmd As OleDb.OleDbCommand
        Try
            '// Limpiar las tablas
            Me.DataSet1.Tables("ftfactm").Rows.Clear()
            Me.DataSet1.Tables("ftfactd").Rows.Clear()
            fDate = LibX.Data.Manager.GetScalar("select getdate()-5")
            fDate = CDate(fDate).ToString(LibX.Data.Manager.GetSaveDateFormat)
            e.AditionalWhere = "fact_date >= '" & fDate & "'"
            RefreshDetail()

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            If e.Action = LibX.LibxConnectionActions.Find Then
                DataSet1.Tables(0).Rows.Clear()
            End If

            If e.AcceptedAction = LibX.LibxConnectionActions.Find Then
                ''Me.xcbo_vend_code.Enabled = True
                ''Me.xcbo_caje_code.Enabled = True
                ''Me.xcbo_caja_code.Enabled = True
                Me.xcbo_domicilio.Enabled = True
            End If

            btnCobrar.Enabled = LibXConnector1.HasRecords
            ''btnanular.Enabled = LibXConnector1.HasRecords

            '// refrescar el detalle despues de abrir la pantalla
            RefreshDetail()
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub xcbo_vend_code_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            SetFilter()
        Finally
        End Try
    End Sub

    Private Sub SetFilter()
        Dim Filter As String = "1=1"
        Try
            ''If Not TypeOf xcbo_vend_code.currValue Is DataRowView AndAlso _
            ''     Not xcbo_vend_code.currValue Is DBNull.Value AndAlso _
            ''    xcbo_vend_code.currValue > 0 Then
            ''    Filter &= " and vend_code = " & xcbo_vend_code.currValue.ToString.Trim
            ''End If

            ''If Not TypeOf Me.xcbo_caja_code.currValue Is DataRowView AndAlso _
            ''     Not xcbo_caja_code.currValue Is DBNull.Value AndAlso _
            ''    xcbo_caja_code.currValue > 0 Then
            ''    Filter &= " and caja_code= " & xcbo_caja_code.currValue.ToString.Trim
            ''End If

            If Not TypeOf Me.xcbo_domicilio.currValue Is DataRowView AndAlso _
                 Not xcbo_domicilio.currValue Is DBNull.Value AndAlso _
                Not LibX.IsNull(xcbo_domicilio.currValue) Then
                Filter &= " and fact_status = " & xcbo_domicilio.currValue.ToString.Trim
            End If

            ''If Not TypeOf Me.xcbo_caje_code.currValue Is DataRowView AndAlso _
            ''     Not xcbo_caje_code.currValue Is DBNull.Value AndAlso _
            ''    xcbo_caje_code.currValue > 0 Then
            ''    Filter &= " and caje_code= " & xcbo_caje_code.currValue.ToString.Trim
            ''End If

            Me.LibXGrid1.getCurrentGridView.RowFilter = Filter

            RefreshDetail()

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub xcbo_caje_code_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            SetFilter()
        Finally
        End Try
    End Sub

    Private Sub xcbo_domicilio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            SetFilter()
        Finally
        End Try
    End Sub
    Private Sub xcbo_caja_code_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            SetFilter()
        Finally
        End Try
    End Sub

    Private Sub txt_fact_nota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetFilter()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Timer1.Enabled = False

            SelectRow()
            mFontofactura = New SGT.PuntodeVenta.Entidades.MontoFactura(oFactura.Serial)
            PrepararDomicilio()

        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            oBloqueoDocumento.BorrarBloqueo(oFactura.Serial, oFactura.Type)
            RefreshGridHeader()
            Timer1.Enabled = True
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LibXConnector1.Delete()
    End Sub
    Private Sub i_fthold01_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim close As String
        Dim XUpdate As LibX.Data.XUpdateStmt
        Try
            oProgram = New SGT.Administracion.Entidades.Program
            ''If mCaja = True Then
            ''    oProgram.ProgramStopping(oParamRunning)
            ''    close = MessageBox.Show("Sacar la caja para el Cuadre", "PREPARAR PARA CUADRE", MessageBoxButtons.YesNo)
            ''    If close = System.Windows.Forms.DialogResult.Yes Then
            ''        If ValidarFacturaPendiente(oCajaAbierta.Serial) = True And oCaja.Domicilio = True Then
            ''            Throw New ApplicationException("TIENE DOMICILIO PENDIENTE, NO SE PUEDE SERRAR PARA CUADRE")
            ''        End If
            ''        oParamValidar.AccessKey = "AC"
            ''        oAutorizar.PermisosAutorizados.Remove("AC")
            ''        If oAutorizar.isAutorization(oParamValidar) = False Then
            ''            Throw New ApplicationException("Autorización Invalida")
            ''        Else
            ''            XUpdate = New LibX.Data.XUpdateStmt("cjinitm")
            ''            XUpdate.FieldsSet("init_status") = 3
            ''            XUpdate.Fields("init_serial") = oCajaAbierta.Serial
            ''            XUpdate.Execute()
            ''        End If
            ''    End If
            ''End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim close As String
        Try
            Me.DialogResult = DialogResult.Cancel
            close = MessageBox.Show("Esta seguro que desea cerrar la caja ?", "", MessageBoxButtons.YesNo)
            If close = System.Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub SelectRow()
        Try
            If LibXGrid1.CurrentRowIndex > -1 Then
                ''AndAlso ftfactm.Rows.Count > 0 Then
                oFactura = New Factura
                If Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColcust_code).ToString.Trim <> "" Then oFactura.Cliente = Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColcust_code)
                oFactura.Serial = Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColftserial_no)
                oFactura.Type = Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColtypeCode)
                oFactura.Is_Domi = Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColDomisi)
                oFactura.mCambio = Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColCambio)
                oFactura.Status = Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColStatus)
            Else
                oFactura = New Factura
                oFactura.Serial = 0
                oFactura.Type = 0
                oFactura.Is_Domi = 0
                oFactura.Status = 0
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If LibXConnector1.Parameters.Datos.Contains("vend_code") Then
                ''Me.xcbo_vend_code.currValue = LibXConnector1.Parameters.Datos.Item("vend_code")
            End If
            Me.SetFilter()

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ''Me.xcbo_caja_code.currValue = -1
            ''Me.xcbo_caje_code.currValue = -1
            ''Me.xcbo_vend_code.currValue = -1
            ''Me.xcbo_domicilio.currValue = -1
            ''SetFilter()

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RefreshGridHeader()
    End Sub

    Private Sub LibXGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LibXGrid1.DoubleClick
        Try
            Timer1.Enabled = False

            SelectRow()
            oBloqueoDocumento = New SGT.PuntodeVenta.Entidades.BloqueoFactua
            If oFactura.Serial <> 0 Then
                mFontofactura = New SGT.PuntodeVenta.Entidades.MontoFactura(oFactura.Serial)
                PrepararDomicilio()
                If mFontofactura.MontoNeto <> mFontofactura.MontoFactura Then
                    Dim XUpdate As New LibX.Data.XUpdateStmt("ftfactm")
                    XUpdate.FieldsSet("fact_total") = mFontofactura.MontoBruto
                    XUpdate.Fields("ftserial_no") = oFactura.Serial
                    XUpdate.Execute()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            oBloqueoDocumento.BorrarBloqueo(oFactura.Serial, oFactura.Type)
            RefreshGridHeader()
            Timer1.Enabled = True
        End Try
    End Sub
    Private Sub i_fthold01_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Timer1.Enabled = False

            If LibXConnector1.HasRecords = True Then
                If e.KeyCode = Keys.F5 Then
                    SelectRow()
                    mFontofactura = New SGT.PuntodeVenta.Entidades.MontoFactura(oFactura.Serial)
                    PrepararDomicilio()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            oBloqueoDocumento.BorrarBloqueo(oFactura.Serial, oFactura.Type)
            RefreshGridHeader()
            Timer1.Enabled = True
        End Try
    End Sub
    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid1.CurrentRowChanged
        Try
            Me.LibXGrid2.CaptionText = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColCliente)
            SelectRow()
            RefreshDetail()

            If oFactura.Is_Domi = 1 And oFactura.mCambio > 0 Then
                Me.xtxCambio.Visible = True
                Me.Label3.Visible = True
                Me.xtxVuelto.Visible = True
                Me.xtxCambio.Text = oFactura.mCambio
                Me.xtxVuelto.Text = Format(oFactura.mCambio - oFactura.MontoFacturado, "###,###,##0.00")
            Else
                Me.xtxCambio.Visible = False
                Me.Label3.Visible = False
                Me.xtxVuelto.Visible = False
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub RefreshDetail()
        Try
            Me.xtxTotalFacturado.Text = ""
            If LibXGrid1.CurrentRowIndex > -1 AndAlso ftfactm.Rows.Count > 0 Then
                Me.LibXConnector1.LoadDetail(LibXGrid1.GetCurrentRowView.Row, Me.LibXDbSourceTable2)
                mFontofactura = New SGT.PuntodeVenta.Entidades.MontoFactura(Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColftserial_no))
                oFactura.MontoNeto = Format(mFontofactura.MontoNeto, "###,###,##0.00")
                oFactura.MontoFacturado = Format(mFontofactura.MontoFactura, "###,###,##0.00")
                oFactura.MontoBruto = Format(mFontofactura.MontoBruto, "###,###,##0.00")
                Me.xtxTotalFacturado.Text = Format(oFactura.MontoFacturado, "###,###,##0.00")
            Else
                Me.LibXConnector1.ClearDetail()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub LibXGrid1_CellKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LibXGrid1.CellKeyPress
        Try

            If LibXConnector1.HasRecords = True Then
                If e.KeyCode = Keys.F5 _
                Or e.KeyCode = Keys.Enter Then

                    oBloqueoDocumento = New SGT.PuntodeVenta.Entidades.BloqueoFactua

                    SelectRow()
                    mFontofactura = New SGT.PuntodeVenta.Entidades.MontoFactura(oFactura.Serial)
                    PrepararDomicilio()
                    ''    If oFactura.Serial <> 0 Then
                    ''        If mFontofactura.MontoNeto <> mFontofactura.MontoFactura Then
                    ''            Dim XUpdate As New LibX.Data.XUpdateStmt("ftfactm")
                    ''            XUpdate.FieldsSet("fact_total") = mFontofactura.MontoBruto
                    ''            XUpdate.Fields("ftserial_no") = oFactura.Serial
                    ''            XUpdate.Execute()
                    ''        End If
                    ''        If mFontofactura.Isomovimiento(oFactura.Type, oFactura.Serial) = True Or oFactura.Status = 3 Then
                    ''            If oFactura.Is_Domi = 1 And oFactura.Status <> 3 Then
                    ''                If oBloqueoDocumento.BuscarBloqueo(oFactura.Serial, oFactura.Type) = True Then
                    ''                    Throw New ApplicationException("Este Documento lo estan Modificando o cobrando!")
                    ''                Else
                    ''                    If Val(Me.xtxVuelto.Text) < 0 Then
                    ''                        Throw New ApplicationException("El Cambio de este Domicilio es menor que el monto facturado!")
                    ''                    End If
                    ''                    If PedirMensajero() = True Then
                    ''                        SetPrinted(oFactura.Serial)
                    ''                    End If
                    ''                End If
                    ''            Else
                    ''                If oBloqueoDocumento.BuscarBloqueo(oFactura.Serial, oFactura.Type) = True Then
                    ''                    Throw New ApplicationException("Este Documento lo estan Modificando o cobrando!")
                    ''                Else
                    ''                    If oFactura.Serial <> 0 Then
                    ''                        CobrarDocumento(oFactura.Serial, oFactura.Type)
                    ''                    End If
                    ''                End If
                    ''            End If
                    ''        Else
                    ''            If oFactura.Status <> 3 Then
                    ''                Throw New ApplicationException("Esta Factura no actualizo existencia, modifiquela o eliminela!")
                    ''            End If
                    ''        End If
                    ''    End If
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            RefreshGridHeader()
            Timer1.Enabled = True
        End Try
    End Sub

    Private Function PedirMensajero() As Boolean
        Dim oMensajero As i_pvmensj01
        Dim oParametroNCF As SGT.Facturacion.Entidades.ParametrosCreditoFiscal
        Dim vCliente As SGT.CXC.Entidades.Cliente
        Dim blnSuccess As Boolean = False
        Dim SelecStmt As String
        Dim WhereStmt As String
        Dim mNumero As Integer
        Dim AxCrystalReport1 As LibX.ReportLib

        Try
            If oBloqueoDocumento.BuscarBloqueo(oFactura.Serial, oFactura.Type) = False Then
                oBloqueoDocumento.BloquearDocumento(oFactura.Serial, oFactura.Type)
            End If

            vCliente = New SGT.CXC.Entidades.Cliente(oFactura.Cliente)

            oMensajero = New i_pvmensj01
            oDocumento = New SGT.Inventario.Entidades.Documento(oFactura.Type)
            oParametroNCF = New SGT.Facturacion.Entidades.ParametrosCreditoFiscal
            oBloqueoDocumento = New SGT.PuntodeVenta.Entidades.BloqueoFactua

            If oMensajero.ShowDialog(oFactura.Serial) = DialogResult.Yes Then
                blnSuccess = True

                oParametroNCF.Almacen = LibXConnector1.CurrentDataRow!whse_code
                oParametroNCF.TipoDocumento = oFactura.Type

                ''If oFactura.Cliente > 0 Then
                If vCliente.Codigo > 0 Then
                    ''oParametroNCF.Cliente = oFactura.Cliente
                    oParametroNCF.Cliente = vCliente.Codigo
                End If
                ''ncfType = LibX.Data.Manager.GetScalar("select isnull(ncf_type,0) from cccustm where cust_code =" & vCliente.Codigo)
                If vCliente.Ncf > 0 Then
                    oParametroNCF.TipoNcf = vCliente.Ncf
                    ''Else
                    ''    oParametroNCF.TipoNcf = 1
                End If
                If oDocumento.GenerarNCF = True Then
                    If ofctDocumento.AplicarCreditoFiscal(oParametroNCF) = True Then
                        Dim XUpdate As New LibX.Data.XUpdateStmt("ftfactm")
                        If WhDefaultNo = 1 Then
                            mNumero = oDocumento.GenerateNumber(oFactura.Type, WhDefaultNo)
                        Else
                            mNumero = oDocumento.GenerateNumber(oFactura.Type, LibXConnector1.CurrentDataRow!whse_code)
                        End If
                        XUpdate.FieldsSet("fact_number") = mNumero
                        XUpdate.FieldsSet("fact_status") = 4
                        If Val(oParametroNCF.Retorno.Cliente) > 0 Then
                            XUpdate.FieldsSet("cust_serial") = oParametroNCF.Retorno.Cliente
                        End If
                        If oParametroNCF.Retorno.NCF <> Nothing Then
                            XUpdate.FieldsSet("fact_ncf") = oParametroNCF.Retorno.NCF
                        End If
                        XUpdate.Fields("ftserial_no") = oFactura.Serial
                        XUpdate.Execute()

                        Dim mXUpdate As New LibX.Data.XUpdateStmt("ivtranrm")
                        mXUpdate.FieldsSet("doc_number") = mNumero
                        mXUpdate.Fields("doc_serial") = oFactura.Serial
                        mXUpdate.Execute()
                    End If
                Else
                    Dim XUpdate As New LibX.Data.XUpdateStmt("ftfactm")
                    If WhDefaultNo = 1 Then
                        mNumero = oDocumento.GenerateNumber(oFactura.Type, WhDefaultNo)
                    Else
                        mNumero = oDocumento.GenerateNumber(oFactura.Type, LibXConnector1.CurrentDataRow!whse_code)
                    End If
                    XUpdate.FieldsSet("fact_number") = mNumero
                    XUpdate.FieldsSet("fact_status") = 4 'Domicilio Pendiente
                    XUpdate.Fields("ftserial_no") = oFactura.Serial
                    XUpdate.Execute()

                    Dim mXUpdate As New LibX.Data.XUpdateStmt("ivtranrm")
                    mXUpdate.FieldsSet("doc_number") = mNumero
                    mXUpdate.Fields("type_code") = oFactura.Type
                    mXUpdate.Fields("doc_serial") = oFactura.Serial
                    mXUpdate.Execute()
                End If

                If mNumero > 0 Then
                    If FindCambio(oFactura.Serial) = True Then
                        Open_CashDrawer(MaquinaAutorizada)
                    End If

                    '// Tomar el Connection String del config
                    AxCrystalReport1 = New LibX.ReportLib("PTV", "r_pvfact01.rpt")
                    WhereStmt = String.Concat("ftfactm.ftserial_no = " & oFactura.Serial)

                    With AxCrystalReport1
                        '// Recibir el SQL Query
                        .RetrieveSQLQuery()
                        SelecStmt = .SQLQuery
                        SelecStmt = LibX.MdlUtil.ReplaceWherePart(SelecStmt, WhereStmt)
                        .SQLQuery = SelecStmt

                        '// Ejecutar el reporte
                        .Copias = oDocumento.CantCopiasDOM  '// Imprimir con Copias
                        .Destination = Crystal.DestinationConstants.crptToPrinter '// Imprimir Directo
                        .Action = 1
                    End With
                End If
                '// marcar como impreso

                blnSuccess = True
            Else
                blnSuccess = False
            End If

            Return blnSuccess
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        Finally
            oBloqueoDocumento.BorrarBloqueo(oFactura.Serial, oFactura.Type)
            RefreshGridHeader()
        End Try
    End Function
    Private Function PrepararDomicilio()
        If oFactura.Status = 5 Then
            Dim XUpdate As New LibX.Data.XUpdateStmt("ftfactm")
            XUpdate.FieldsSet("fact_status") = 1 'Domicilio Pendiente
            XUpdate.Fields("ftserial_no") = oFactura.Serial
            XUpdate.Execute()
        End If

    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            RefreshGridHeader()

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Function CobrarDocumento(ByVal pserial_no As Integer, ByVal typeCode As String) As Boolean
        Dim oUpdate As LibX.Data.XUpdateStmt
        Dim mFontofactura As SGT.PuntodeVenta.Entidades.MontoFactura
        Dim op As New LibxPrgParams
        Try
            Timer1.Enabled = False
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
            ''LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & pserial_no.ToString.Trim)
            If oBloqueoDocumento.BuscarBloqueo(pserial_no, typeCode) = False Then
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
                If oFactura.Type = "DEV" Then
                    oParamValidar.AccessKey = "CD"
                    oAutorizar.PermisosAutorizados.Remove("CD")

                    If oAutorizar.isAutorization(oParamValidar) = False Then
                        oBloqueoDocumento.BorrarBloqueo(pserial_no, typeCode)
                        Throw New ApplicationException("Autorización Invalida")
                    End If
                End If
            End If

            op.IsFromOther = True
            op.initMode = LibxInitModes.Edit
            op.WhereToExecute = "ftfactm.ftserial_no = " & pserial_no.ToString.Trim
            App.CurrentPrgParams = op

            LibX.LibXRunner.Run("i_cjfact01", "CAJ", True)

            '// refrescar el documento
            ''LibXConnector1.CurrentDataRow.Row.RejectChanges()
            ''LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & pserial_no.ToString.Trim)

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        Finally
            oBloqueoDocumento.BorrarBloqueo(pserial_no, typeCode)
            RefreshGridHeader()
            Timer1.Enabled = True
        End Try
    End Function
    Private Function ValidarEstadoCaja(ByVal InitSerial As Integer) As Boolean
        Dim oRedEstado As Integer
        Dim SelectStmt As String
        Try
            SelectStmt = "select init_status from cjinitm where init_serial = " & InitSerial.ToString.Trim

            oRedEstado = LibX.Data.Manager.GetScalar(SelectStmt)
            If oRedEstado <> 1 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Function
    Private Function FindCambio(ByVal ftSerial As Integer) As Boolean
        Dim oCambio As Decimal
        Dim SelectStmt As String
        Try
            SelectStmt = "select isnull(domi_cambio,0) from ftdomim where ftserial_no = " & ftSerial.ToString.Trim

            oCambio = LibX.Data.Manager.GetScalar(SelectStmt)

            If oCambio > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Function

    Private Sub btnCobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCobrar.Click
        Try
            Timer1.Enabled = False
            oBloqueoDocumento = New SGT.PuntodeVenta.Entidades.BloqueoFactua

            SelectRow()
            mFontofactura = New SGT.PuntodeVenta.Entidades.MontoFactura(oFactura.Serial)
            PrepararDomicilio()

            ''If oFactura.Serial <> 0 Then
            ''    If mFontofactura.MontoNeto <> mFontofactura.MontoFactura Then
            ''        Dim XUpdate As New LibX.Data.XUpdateStmt("ftfactm")
            ''        XUpdate.FieldsSet("fact_total") = mFontofactura.MontoBruto
            ''        XUpdate.Fields("ftserial_no") = oFactura.Serial
            ''        XUpdate.Execute()
            ''    End If
            ''    If mFontofactura.Isomovimiento(oFactura.Type, oFactura.Serial) = True Or oFactura.Status = 3 Then
            ''        If oFactura.Is_Domi = 1 And oFactura.Status <> 3 Then
            ''            If oBloqueoDocumento.BuscarBloqueo(oFactura.Serial, oFactura.Type) = True Then
            ''                Throw New ApplicationException("Este Documento lo estan Modificando o cobrando!")
            ''            Else
            ''                If Val(Me.xtxVuelto.Text) < 0 Then
            ''                    Throw New ApplicationException("El Cambio de este Domicilio es menor que el monto facturado!")
            ''                End If
            ''                If PedirMensajero() = True Then
            ''                    SetPrinted(oFactura.Serial)
            ''                End If
            ''            End If
            ''        Else
            ''            If oBloqueoDocumento.BuscarBloqueo(oFactura.Serial, oFactura.Type) = True Then
            ''                Throw New ApplicationException("Este Documento lo estan Modificando o cobrando!")
            ''            Else
            ''                If oFactura.Serial <> 0 Then
            ''                    CobrarDocumento(oFactura.Serial, oFactura.Type)
            ''                End If
            ''            End If
            ''        End If
            ''    Else
            ''        If oFactura.Status <> 3 Then
            ''            Throw New ApplicationException("Esta Factura no actualizo existencia, modifiquela o eliminela!")
            ''        End If
            ''    End If
            ''End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            oBloqueoDocumento.BorrarBloqueo(oFactura.Serial, oFactura.Type)
            RefreshGridHeader()
            Timer1.Enabled = True
        End Try
    End Sub
    Private Sub btnEgresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oParam As LibX.LibxPrgParams
        Try
            Timer1.Enabled = False

            oParam = New LibX.LibxPrgParams
            oParam.Value = oCajaAbierta.Serial
            oParam.initMode = LibxInitModes.Insert

            LibX.App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("i_ccpaym01", "CXC", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            Timer1.Enabled = True

        End Try
    End Sub
    Private Sub btnIngresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oParam As LibX.LibxPrgParams
        Try
            Timer1.Enabled = False

            oParam = New LibX.LibxPrgParams
            oParam.Value = oCajaAbierta.Serial
            oParam.Datos.Add("caje_code", oCajaAbierta.CajeraCode)
            oParam.initMode = LibxInitModes.Insert

            LibX.App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("i_ptvrecib01", "PTV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            Timer1.Enabled = True

        End Try
    End Sub

    Private Sub btnestafetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oParam As LibX.LibxPrgParams
        Try
            Timer1.Enabled = False

            oParam = New LibX.LibxPrgParams
            oParam.Value = oCajaAbierta.Serial
            oParam.Datos.Add("caje_code", oCajaAbierta.CajeraCode)
            oParam.initMode = LibxInitModes.Insert

            LibX.App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("i_sfcobrm01", "PTV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            Timer1.Enabled = True

        End Try
    End Sub

    Private Sub btnOpenCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Timer1.Enabled = False
            oParamValidar.AccessKey = "AN"
            oAutorizar.PermisosAutorizados.Remove("AN")

            If oAutorizar.isAutorization(oParamValidar) = False Then
                Throw New ApplicationException("Autorización Invalida")
            End If
            If oFactura.Status <> Val(EstatusDocumentosEnum.enEspera) Then  '// HOLD 
                AnularDocumento()
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            RefreshGridHeader()
            Timer1.Enabled = True
        End Try

    End Sub
    Private Sub AnularDocumento()
        Dim oPost As SGT.Facturacion.Operaciones.PosteoDocumento
        Dim oParam As SGT.Facturacion.Operaciones.PosteoDocumento.Parametros
        Dim Xdelete As LibX.Data.XDeleteStmt

        Try
            oPost = New SGT.Facturacion.Operaciones.PosteoDocumento
            oParam = New SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

            SelectRow()
            With oParam
                .SerialNumero = oFactura.Serial
                .ApliarComision = True
                .AplicarCXC = True
                .AplicarInventario = True
                .Completo = True
                .UseTransaction = False
                .InitSerial = oCajaAbierta.Serial
            End With

            oPost.Anular(oParam)

        Catch ex As Exception
            Throw

        End Try
    End Sub
    Private Sub SetPrinted(ByVal pftserial_no As Integer)
        Dim XUpdate As LibX.Data.XUpdateStmt
        Try
            XUpdate = New LibX.Data.XUpdateStmt("ftfactm")
            XUpdate.FieldsSet("fact_impresa") = 1
            XUpdate.Fields("ftserial_no") = pftserial_no
            XUpdate.Execute()

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
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
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim oParam As New LibX.LibxPrgParams
        Try
            Timer1.Enabled = False
            With oParam
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowPrint = True
                .AllowQuery = True
                .IsFromOther = True
                .initMode = LibxInitModes.Query

                If oCajaAbierta.CajaCode > 0 Then
                    .Datos.Add("caja_code", oCajaAbierta.CajaCode)
                End If

                If oCajaAbierta.CajeraCode > 0 Then
                    .Datos.Add("caje_code", oCajaAbierta.CajeraCode)
                End If
            End With
            App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("i_ptvfind", "PTV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            RefreshGridHeader()
            Timer1.Enabled = True
        End Try
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        RefreshGridHeader()
    End Sub
    Private Sub xcbo_domicilio_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xcbo_domicilio.SelectedIndexChanged
        Try
            SetFilter()
        Finally
        End Try
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.xcbo_domicilio.currValue = -1
        SetFilter()
    End Sub
    Private Sub btnView_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim xParam As LibX.LibxPrgParams
        Try
            xParam = New LibX.LibxPrgParams
            xParam.AllowDelete = False
            xParam.AllowEdit = False
            xParam.AllowNew = False
            xParam.AllowPrint = False
            xParam.AllowQuery = False
            xParam.initMode = LibX.LibxInitModes.none

            LibX.App.CurrentPrgParams = xParam
            xParam.WhereToExecute = "ftserial_no = " & oFactura.Serial
            LibX.LibXRunner.Run("i_ptvfact01", "PTV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

End Class
