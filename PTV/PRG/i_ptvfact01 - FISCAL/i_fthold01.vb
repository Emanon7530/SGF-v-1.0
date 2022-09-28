Imports SGT.Caja.Entidades
Imports SGT.Caja.Operaciones

Imports System.Data.SqlClient
Imports LibXPrintFiscal.Helpers
Imports LibXPrintFiscal.Interfaces
Imports LibXPrintFiscal.Repositorios
Imports LibxPrintFiscalSGF
Imports LibxPrintFiscalSGF.Modelos
Imports EpsonFPHostControlX
Imports AxEpsonFPHostControlX
Imports LibxPrintFiscalFactura

Public Class i_fthold01
    Inherits System.Windows.Forms.Form

    Dim mFontofactura As SGT.PuntodeVenta.Entidades.MontoFactura
    Dim oDocumento As SGT.Inventario.Entidades.Documento
    Dim oParametroNCF As SGT.Facturacion.Entidades.ParametrosCreditoFiscal
    Dim ofctDocumento As SGT.Facturacion.Entidades.Documento
    Dim oBloqueoDocumento As SGT.PuntodeVenta.Entidades.BloqueoFactua
    Private Epson = New AxEpsonFPHostControl
    Dim oElejir As Boolean = False
    Dim oAtion As Boolean = False
    Dim WhDefaultNo As Integer
    Dim dbOPenn As Object
    Dim oMachine As String

    Public Class sFactura
        Public Serial As Integer
        Public Type As String
        Public Is_Domi As Integer
        Public Status As Integer
        Public dCambio As Decimal
        Public dCliente As Integer
        Public MontoFacturado As Decimal
        Public MontoNeto As Decimal
        Public MontoBruto As Decimal
    End Class

    Dim mFactura As sFactura

    Public Property FacturaSelected() As sFactura
        Get
            Return mFactura
        End Get
        Set(ByVal Value As sFactura)
            mFactura = Value
        End Set
    End Property

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Controls.Add(Epson)
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
    Friend WithEvents XEditTextBoxColumn4 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn5 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents xcbo_caje_code As LibX.LibXCombo
    Friend WithEvents xcbo_caja_code As LibX.LibXCombo
    Friend WithEvents xcbo_vend_code As LibX.LibXCombo
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn6 As LibX.XEditTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents gColftserial_no As LibX.XEditTextBoxColumn
    Friend WithEvents btnAccept As System.Windows.Forms.Button
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
    Friend WithEvents xcbo_domicilio As LibX.LibXCombo
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents xtxCambio As System.Windows.Forms.Label
    Friend WithEvents gColCambio As LibX.XEditTextBoxColumn
    Friend WithEvents xtxVuelto As System.Windows.Forms.Label
    Friend WithEvents gColUnid As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents gColCust_code As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(i_fthold01))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.xcbo_domicilio = New LibX.LibXCombo
        Me.xcbo_caje_code = New LibX.LibXCombo
        Me.xcbo_caja_code = New LibX.LibXCombo
        Me.xcbo_vend_code = New LibX.LibXCombo
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
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
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
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
        Me.gColtypeCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gColCliente = New LibX.XEditTextBoxColumn
        Me.gColSector_name = New System.Windows.Forms.DataGridTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn4 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn5 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn6 = New LibX.XEditTextBoxColumn
        Me.gColftserial_no = New LibX.XEditTextBoxColumn
        Me.gColDomisi = New LibX.XEditTextBoxColumn
        Me.gColStatus = New LibX.XEditTextBoxColumn
        Me.gColCambio = New LibX.XEditTextBoxColumn
        Me.gColCust_code = New LibX.XEditTextBoxColumn
        Me.btnAccept = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
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
        Me.DataView1 = New System.Data.DataView
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.xtxCambio = New System.Windows.Forms.Label
        Me.xtxVuelto = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xcbo_domicilio)
        Me.GroupBox1.Controls.Add(Me.xcbo_caje_code)
        Me.GroupBox1.Controls.Add(Me.xcbo_caja_code)
        Me.GroupBox1.Controls.Add(Me.xcbo_vend_code)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(888, 72)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Tipo Espera:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_domicilio
        '
        Me.xcbo_domicilio.AllowDefaultSort = True
        Me.xcbo_domicilio.bound = True
        Me.xcbo_domicilio.currValue = Nothing
        Me.xcbo_domicilio.DefaultWhereString = "fact_inddomicilio=1"
        Me.xcbo_domicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_domicilio.EditInitialValue = Nothing
        Me.xcbo_domicilio.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_domicilio.FieldDescription = ""
        Me.xcbo_domicilio.FindInitialValue = Nothing
        Me.xcbo_domicilio.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_domicilio.IgnoreRequiered = False
        Me.xcbo_domicilio.Items.AddRange(New Object() {"0-FACTURA", "1-DOMICILIO"})
        Me.xcbo_domicilio.Location = New System.Drawing.Point(88, 40)
        Me.xcbo_domicilio.LookupKeyDisplayFields = "DOMICILIO"
        Me.xcbo_domicilio.LookupKeyField = "inddomicilio"
        Me.xcbo_domicilio.LookupTableName = "ftfactm"
        Me.xcbo_domicilio.Name = "xcbo_domicilio"
        Me.xcbo_domicilio.NewInitialValue = Nothing
        Me.xcbo_domicilio.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_domicilio.Requiered = False
        Me.xcbo_domicilio.Required = False
        Me.xcbo_domicilio.Size = New System.Drawing.Size(336, 21)
        Me.xcbo_domicilio.SqlString = Nothing
        Me.xcbo_domicilio.StatusBarPanelDescripcion = Nothing
        Me.xcbo_domicilio.TabIndex = 13
        '
        'xcbo_caje_code
        '
        Me.xcbo_caje_code.AllowDefaultSort = True
        Me.xcbo_caje_code.bound = True
        Me.xcbo_caje_code.currValue = Nothing
        Me.xcbo_caje_code.DefaultWhereString = "(vend_cargo = 1)"
        Me.xcbo_caje_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_caje_code.EditInitialValue = Nothing
        Me.xcbo_caje_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caje_code.FieldDescription = ""
        Me.xcbo_caje_code.FindInitialValue = Nothing
        Me.xcbo_caje_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caje_code.IgnoreRequiered = False
        Me.xcbo_caje_code.Location = New System.Drawing.Point(488, 40)
        Me.xcbo_caje_code.LookupKeyDisplayFields = "vend_name"
        Me.xcbo_caje_code.LookupKeyField = "vend_code"
        Me.xcbo_caje_code.LookupTableName = "ftvendm"
        Me.xcbo_caje_code.Name = "xcbo_caje_code"
        Me.xcbo_caje_code.NewInitialValue = Nothing
        Me.xcbo_caje_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caje_code.Requiered = False
        Me.xcbo_caje_code.Required = False
        Me.xcbo_caje_code.Size = New System.Drawing.Size(328, 21)
        Me.xcbo_caje_code.SqlString = Nothing
        Me.xcbo_caje_code.StatusBarPanelDescripcion = Nothing
        Me.xcbo_caje_code.TabIndex = 12
        '
        'xcbo_caja_code
        '
        Me.xcbo_caja_code.AllowDefaultSort = True
        Me.xcbo_caja_code.bound = True
        Me.xcbo_caja_code.currValue = Nothing
        Me.xcbo_caja_code.DefaultWhereString = Nothing
        Me.xcbo_caja_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_caja_code.EditInitialValue = Nothing
        Me.xcbo_caja_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caja_code.FieldDescription = ""
        Me.xcbo_caja_code.FindInitialValue = Nothing
        Me.xcbo_caja_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caja_code.IgnoreRequiered = False
        Me.xcbo_caja_code.Location = New System.Drawing.Point(488, 16)
        Me.xcbo_caja_code.LookupKeyDisplayFields = "caja_name"
        Me.xcbo_caja_code.LookupKeyField = "caja_code"
        Me.xcbo_caja_code.LookupTableName = "cjcajam"
        Me.xcbo_caja_code.Name = "xcbo_caja_code"
        Me.xcbo_caja_code.NewInitialValue = Nothing
        Me.xcbo_caja_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caja_code.Requiered = False
        Me.xcbo_caja_code.Required = False
        Me.xcbo_caja_code.Size = New System.Drawing.Size(328, 21)
        Me.xcbo_caja_code.SqlString = Nothing
        Me.xcbo_caja_code.StatusBarPanelDescripcion = Nothing
        Me.xcbo_caja_code.TabIndex = 11
        '
        'xcbo_vend_code
        '
        Me.xcbo_vend_code.AllowDefaultSort = True
        Me.xcbo_vend_code.bound = True
        Me.xcbo_vend_code.currValue = Nothing
        Me.xcbo_vend_code.DefaultWhereString = "vend_cargo=2"
        Me.xcbo_vend_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_vend_code.EditInitialValue = Nothing
        Me.xcbo_vend_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_code.FieldDescription = ""
        Me.xcbo_vend_code.FindInitialValue = Nothing
        Me.xcbo_vend_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_code.IgnoreRequiered = False
        Me.xcbo_vend_code.Location = New System.Drawing.Point(88, 16)
        Me.xcbo_vend_code.LookupKeyDisplayFields = "vend_name"
        Me.xcbo_vend_code.LookupKeyField = "vend_code"
        Me.xcbo_vend_code.LookupTableName = "ftvendm"
        Me.xcbo_vend_code.Name = "xcbo_vend_code"
        Me.xcbo_vend_code.NewInitialValue = Nothing
        Me.xcbo_vend_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_code.Requiered = False
        Me.xcbo_vend_code.Required = False
        Me.xcbo_vend_code.Size = New System.Drawing.Size(336, 21)
        Me.xcbo_vend_code.SqlString = Nothing
        Me.xcbo_vend_code.StatusBarPanelDescripcion = Nothing
        Me.xcbo_vend_code.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(440, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Cajera:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(448, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Caja:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(24, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Vendedor:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn49, Me.DataColumn50})
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
        Me.DataColumn18.ColumnName = "fact_time"
        Me.DataColumn18.MaxLength = 10
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
        Me.DataColumn47.ColumnName = "domi_cambio"
        Me.DataColumn47.DataType = GetType(System.Decimal)
        Me.DataColumn47.ReadOnly = True
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "cust_code"
        Me.DataColumn49.DataType = GetType(System.Int32)
        Me.DataColumn49.ReadOnly = True
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "Domiforma"
        Me.DataColumn50.MaxLength = 8
        Me.DataColumn50.ReadOnly = True
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn48})
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
        'DataColumn48
        '
        Me.DataColumn48.AllowDBNull = False
        Me.DataColumn48.ColumnName = "unit_code"
        Me.DataColumn48.MaxLength = 4
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
        Me.LibXGrid1.DataMember = "ftfactm"
        Me.LibXGrid1.DataSource = Me.LibXConnector1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = True
        Me.LibXGrid1.Location = New System.Drawing.Point(0, 80)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(976, 272)
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
        Me.LibXConnector1.IsHeaderOnGrid = True
        Me.LibXConnector1.ModuleName = ""
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = ""
        Me.LibXConnector1.ReportObject = Nothing
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
        Me.LibXDbSourceTable1.SerialColumnName = "ftserial_no"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select ftfactm.ftserial_no,whse_code,cust_serial,ftfactm.type_code ,[type_name],f" & _
        "act_date,", "substring(bus_name,1,40)bus_name,fact_time, ", "caja_name, cjcajeram.vend_name caje_name,isnull(fact_inddomicilio,0)fact_inddomic" & _
        "ilio", ",ftfactm.caja_code,ftfactm.caje_code,ftfactm.vend_code,  ", "ftvendm.vend_name,sctorcity.sector_name,fact_ncf,fact_status,", "case WHEN isnull(ftfactm.fact_inddomicilio,0) =1 then 'DOMICILIO'  ", "     when ftfactm.type_code = 'FSG' then 'SEGURO' ", "     when ftfactm.type_code = 'DEV' then 'DEVOLUCIO' else 'FACTURA' ", "      end Domitipo,", "case WHEN ftdomim.domi_pago = 'EFE' then 'EFECTIVO'  ", "     when ftdomim.domi_pago = 'TAR' then 'TARJETA' ", "     when ftdomim.domi_pago = 'CXC' then 'CREDITO' ", "      end Domiforma,isnull(ftdomim.domi_cambio,0)domi_cambio,", "      isnull(ftfactm.cust_code,0) cust_code", "from ftfactm ", "inner join cjcajam", "on ftfactm.caja_code = cjcajam.caja_code", "and ftfactm.fact_number is null", "and ftfactm.ftserial_no in(select ftserial_no from ftfactd)", "or ftfactm.type_code in('FTS')", "inner join ftvendm cjcajeram", "on ftfactm.caje_code = cjcajeram.vend_code", "inner join ftvendm", "on ftfactm.vend_code = ftvendm.vend_code", "left join sctorcity", "on ftfactm.cust_code =sctorcity.cust_code", "inner join ivtypem", "on ftfactm.type_code = ivtypem.type_code", "left outer join ftdomim", "on ftdomim.ftserial_no =ftfactm.ftserial_no"}
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
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XEditTextBoxColumn2, Me.gColHora, Me.gColtypeCode, Me.gColCliente, Me.gColSector_name, Me.XEditTextBoxColumn3, Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn4, Me.XEditTextBoxColumn5, Me.XEditTextBoxColumn6, Me.gColftserial_no, Me.gColDomisi, Me.gColStatus, Me.gColCambio, Me.gColCust_code})
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
        Me.XEditTextBoxColumn2.Width = 75
        '
        'gColHora
        '
        Me.gColHora.Format = ""
        Me.gColHora.FormatInfo = Nothing
        Me.gColHora.HeaderText = "Hora"
        Me.gColHora.MappingName = "fact_time"
        Me.gColHora.Width = 70
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
        Me.gColSector_name.Width = 120
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Facturado"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = False
        Me.XEditTextBoxColumn3.MappingName = "Domitipo"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.TabStop = True
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 75
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Forma Pago"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "Domiforma"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 75
        '
        'XEditTextBoxColumn4
        '
        Me.XEditTextBoxColumn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn4.Format = ""
        Me.XEditTextBoxColumn4.FormatInfo = Nothing
        Me.XEditTextBoxColumn4.HeaderText = "Caja"
        Me.XEditTextBoxColumn4.ImageList = Nothing
        Me.XEditTextBoxColumn4.isReadOnly = False
        Me.XEditTextBoxColumn4.MappingName = "caja_name"
        Me.XEditTextBoxColumn4.MaxLength = 32767
        Me.XEditTextBoxColumn4.TabStop = True
        Me.XEditTextBoxColumn4.UseCustomCellFormat = False
        Me.XEditTextBoxColumn4.Width = 60
        '
        'XEditTextBoxColumn5
        '
        Me.XEditTextBoxColumn5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn5.Format = ""
        Me.XEditTextBoxColumn5.FormatInfo = Nothing
        Me.XEditTextBoxColumn5.HeaderText = "Cajera"
        Me.XEditTextBoxColumn5.ImageList = Nothing
        Me.XEditTextBoxColumn5.isReadOnly = False
        Me.XEditTextBoxColumn5.MappingName = "caje_name"
        Me.XEditTextBoxColumn5.MaxLength = 32767
        Me.XEditTextBoxColumn5.TabStop = True
        Me.XEditTextBoxColumn5.UseCustomCellFormat = False
        Me.XEditTextBoxColumn5.Width = 75
        '
        'XEditTextBoxColumn6
        '
        Me.XEditTextBoxColumn6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn6.Format = ""
        Me.XEditTextBoxColumn6.FormatInfo = Nothing
        Me.XEditTextBoxColumn6.HeaderText = "Vendedor"
        Me.XEditTextBoxColumn6.ImageList = Nothing
        Me.XEditTextBoxColumn6.isReadOnly = False
        Me.XEditTextBoxColumn6.MappingName = "vend_name"
        Me.XEditTextBoxColumn6.MaxLength = 32767
        Me.XEditTextBoxColumn6.TabStop = True
        Me.XEditTextBoxColumn6.UseCustomCellFormat = False
        Me.XEditTextBoxColumn6.Width = 150
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
        'gColCust_code
        '
        Me.gColCust_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColCust_code.Format = ""
        Me.gColCust_code.FormatInfo = Nothing
        Me.gColCust_code.ImageList = Nothing
        Me.gColCust_code.isReadOnly = False
        Me.gColCust_code.MappingName = "cust_code"
        Me.gColCust_code.MaxLength = 32767
        Me.gColCust_code.TabStop = True
        Me.gColCust_code.UseCustomCellFormat = False
        Me.gColCust_code.Width = 0
        '
        'btnAccept
        '
        Me.btnAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAccept.Location = New System.Drawing.Point(776, 560)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.TabIndex = 2
        Me.btnAccept.Text = "Aceptar(F5)"
        Me.ToolTip1.SetToolTip(Me.btnAccept, "Elegir el documento seleccionado")
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(856, 560)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Cancelar la operación y cerrar esta pantalla")
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(899, 56)
        Me.Button4.Name = "Button4"
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Refrescar"
        Me.ToolTip1.SetToolTip(Me.Button4, "Refrescar en pantalla todos los documentos enviados a la caja")
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(899, 32)
        Me.Button5.Name = "Button5"
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Todos"
        Me.ToolTip1.SetToolTip(Me.Button5, "Visualizar todos los documentos pendientes por cobrar de esta caja")
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(899, 8)
        Me.Button6.Name = "Button6"
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Vendedor"
        Me.ToolTip1.SetToolTip(Me.Button6, "Visualizar todos los documentos pendientes por cobrar de un vendedor")
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
        Me.LibXGrid2.Size = New System.Drawing.Size(624, 144)
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
        Me.PicCobro.Location = New System.Drawing.Point(648, 392)
        Me.PicCobro.Name = "PicCobro"
        Me.PicCobro.Size = New System.Drawing.Size(280, 144)
        Me.PicCobro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCobro.TabIndex = 5
        Me.PicCobro.TabStop = False
        '
        'picEspera
        '
        Me.picEspera.Image = CType(resources.GetObject("picEspera.Image"), System.Drawing.Image)
        Me.picEspera.Location = New System.Drawing.Point(648, 392)
        Me.picEspera.Name = "picEspera"
        Me.picEspera.Size = New System.Drawing.Size(328, 144)
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
        Me.Label2.Location = New System.Drawing.Point(344, 552)
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
        Me.xtxTotalFacturado.Location = New System.Drawing.Point(480, 536)
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
        'DataView1
        '
        Me.DataView1.AllowDelete = False
        Me.DataView1.AllowNew = False
        Me.DataView1.Table = Me.ftfactm
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(144, 552)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 22)
        Me.Label3.TabIndex = 10
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
        Me.xtxCambio.Size = New System.Drawing.Size(88, 25)
        Me.xtxCambio.TabIndex = 11
        Me.xtxCambio.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.xtxCambio.Visible = False
        '
        'xtxVuelto
        '
        Me.xtxVuelto.BackColor = System.Drawing.SystemColors.Control
        Me.xtxVuelto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xtxVuelto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.xtxVuelto.ForeColor = System.Drawing.Color.Red
        Me.xtxVuelto.Location = New System.Drawing.Point(648, 552)
        Me.xtxVuelto.Name = "xtxVuelto"
        Me.xtxVuelto.Size = New System.Drawing.Size(88, 24)
        Me.xtxVuelto.TabIndex = 12
        Me.xtxVuelto.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.xtxVuelto.Visible = False
        '
        'i_fthold01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(994, 590)
        Me.ControlBox = False
        Me.Controls.Add(Me.xtxVuelto)
        Me.Controls.Add(Me.xtxCambio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.xtxTotalFacturado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picEspera)
        Me.Controls.Add(Me.PicCobro)
        Me.Controls.Add(Me.LibXGrid2)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "i_fthold01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Documentos en Espera"
        Me.GroupBox1.ResumeLayout(False)
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
        Dim mFactura As New sFactura

        ofctDocumento = New SGT.Facturacion.Entidades.Documento

        xcbo_vend_code.LoadDbItems(True)
        xcbo_caja_code.LoadDbItems(True)
        xcbo_caje_code.LoadDbItems(True)
        xcbo_domicilio.LoadDbItems(True)

        xcbo_caja_code.currValue = LibXConnector1.Parameters.Datos.Item("caja_code")
        xcbo_caje_code.currValue = LibXConnector1.Parameters.Datos.Item("caje_code")

        If Not LibXConnector1.Parameters Is Nothing Then
            oAtion = LibXConnector1.Parameters.Datos.Item("cobro")
            WhDefaultNo = LibXConnector1.Parameters.Datos.Item("WhDefaultNo")
        End If

        dbOPenn = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxConnectFiscal")
        oMachine = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxCaja")

    End Sub

    Private Sub RefreshGridHeader()

        Me.LibXGrid1.footerOperations.add("type_name", "count(type_name)")
        Me.LibXGrid1.getCurrentGridView.AllowDelete = False
        Me.LibXGrid1.getCurrentGridView.AllowEdit = False
        Me.LibXGrid1.getCurrentGridView.AllowNew = False

        '// Ejecuta 
        LibXConnector1.ReQuery()
        LibXGrid1.Focus()

    End Sub
    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            Dim SQL As String
            Dim sWhere As String
            Dim cmd As OleDb.OleDbCommand
            sWhere = LibX.ConcatWherePart(sWhere, "ftfactm.whse_code = " & LibXConnector1.Parameters.Datos.Item("whse_code"))
            sWhere = LibX.ConcatWherePart(sWhere, "ftfactm.caja_code = " & LibXConnector1.Parameters.Datos.Item("caja_code"))
            sWhere = LibX.ConcatWherePart(sWhere, "ftfactm.caje_code = " & LibXConnector1.Parameters.Datos.Item("caje_code"))
            sWhere = LibX.ConcatWherePart(sWhere, "ftfactm.fact_status = 1 ")

            If Trim(e.Where) <> String.Empty Then
                sWhere = LibX.ConcatWherePart(sWhere, e.Where)
            End If

            '// Limpiar las tablas
            Me.DataSet1.Tables("ftfactm").Rows.Clear()
            Me.DataSet1.Tables("ftfactd").Rows.Clear()

            '// Documentos pendiente por cobrar
            SQL = LibX.ConcatWherePart(Join(Me.LibXDbSourceTable1.Source, " "), sWhere)
            SQL = String.Concat(SQL, " ORDER BY ftfactm.ftserial_no")

            cmd = LibX.Data.Manager.Connection.CreateCommand
            cmd.CommandText = SQL

            Dim oAd As New OleDb.OleDbDataAdapter(cmd)
            oAd.Fill(Me.DataSet1.Tables("ftfactm"))

            RefreshDetail()
            SelectRow()
            If mFactura.Is_Domi = 1 And mFactura.dCambio > 0 Then
                Me.xtxCambio.Visible = True
                Me.Label3.Visible = True
                Me.xtxVuelto.Visible = True
                Me.xtxCambio.Text = mFactura.dCambio
                Me.xtxVuelto.Text = Format(mFactura.dCambio - mFactura.MontoFacturado, "###,###,##0.00")
            Else
                Me.xtxCambio.Visible = False
                Me.Label3.Visible = False
                Me.xtxVuelto.Visible = False
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        If e.Action = LibX.LibxConnectionActions.Find Then
            DataSet1.Tables(0).Rows.Clear()
        End If

        If e.AcceptedAction = LibX.LibxConnectionActions.Find Then
            Me.xcbo_vend_code.Enabled = True
            Me.xcbo_caje_code.Enabled = True
            Me.xcbo_caja_code.Enabled = True
            Me.xcbo_domicilio.Enabled = True
        End If

        '// refrescar el detalle despues de abrir la pantalla
        RefreshDetail()
    End Sub

    Private Sub xcbo_vend_code_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xcbo_vend_code.SelectedIndexChanged
        Try
            SetFilter()
        Finally
        End Try
    End Sub

    Private Sub SetFilter()
        Dim Filter As String = "1=1"

        If Not TypeOf xcbo_vend_code.currValue Is DataRowView AndAlso _
             Not xcbo_vend_code.currValue Is DBNull.Value AndAlso _
            xcbo_vend_code.currValue > 0 Then
            Filter &= " and vend_code = " & xcbo_vend_code.currValue.ToString.Trim
        End If

        If Not TypeOf Me.xcbo_caja_code.currValue Is DataRowView AndAlso _
             Not xcbo_caja_code.currValue Is DBNull.Value AndAlso _
            xcbo_caja_code.currValue > 0 Then
            Filter &= " and caja_code= " & xcbo_caja_code.currValue.ToString.Trim
        End If

        If Not TypeOf Me.xcbo_domicilio.currValue Is DataRowView AndAlso _
             Not xcbo_domicilio.currValue Is DBNull.Value AndAlso _
            Not LibX.IsNull(xcbo_domicilio.currValue) Then
            Filter &= " and fact_inddomicilio = " & xcbo_domicilio.currValue.ToString.Trim
        End If

        If Not TypeOf Me.xcbo_caje_code.currValue Is DataRowView AndAlso _
             Not xcbo_caje_code.currValue Is DBNull.Value AndAlso _
            xcbo_caje_code.currValue > 0 Then
            Filter &= " and caje_code= " & xcbo_caje_code.currValue.ToString.Trim
        End If

        Me.LibXGrid1.getCurrentGridView.RowFilter = Filter

        RefreshDetail()
    End Sub
    Private Sub xcbo_caje_code_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles xcbo_caje_code.SelectedIndexChanged
        Try
            xcbo_caje_code.FindInitialValue = LibXConnector1.Parameters.Datos.Item("caje_code")
            SetFilter()
        Finally
        End Try
    End Sub

    Private Sub xcbo_domicilio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xcbo_domicilio.SelectedIndexChanged
        Try
            SetFilter()
        Finally
        End Try
    End Sub
    Private Sub xcbo_caja_code_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles xcbo_caja_code.SelectedIndexChanged
        Try
            xcbo_caja_code.FindInitialValue = LibXConnector1.Parameters.Datos.Item("caja_code")
            SetFilter()
        Finally
        End Try
    End Sub

    Private Sub txt_fact_nota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetFilter()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        Try

            SelectRow()

            mFontofactura = New SGT.PuntodeVenta.Entidades.MontoFactura(mFactura.Serial)
            oBloqueoDocumento = New SGT.PuntodeVenta.Entidades.BloqueoFactua
            If mFontofactura.MontoNeto <> mFontofactura.MontoFactura Then
                Dim XUpdate As New LibX.Data.XUpdateStmt("ftfactm")
                XUpdate.FieldsSet("fact_total") = mFontofactura.MontoBruto
                XUpdate.Fields("ftserial_no") = mFactura.Serial
                XUpdate.Execute()
            End If
            If mFactura.Is_Domi = 1 And mFactura.Status = 1 And oAtion = True Then
                If oBloqueoDocumento.BuscarBloqueo(mFactura.Serial, mFactura.Type) = True Then
                    Throw New ApplicationException("Este Documento lo estan modificando o cobrando!")
                Else
                    oBloqueoDocumento.BloquearDocumento(mFactura.Serial, mFactura.Type)
                End If
            End If

            If mFontofactura.Isomovimiento(mFactura.Type, mFactura.Serial) = True Or mFactura.Status = 3 Then
                If mFactura.Is_Domi = 1 And mFactura.Status <> 3 And oAtion = True Then
                    If Val(Me.xtxVuelto.Text) < 0 Then
                        Throw New ApplicationException("El Cambio de este Domicilio es menor que el monto facturado!")
                    End If
                    If OpenPrinter() Then
                        If PedirMensajero() = True Then
                            SetPrinted(mFactura.Serial)
                            Me.Close()
                        End If
                    Else
                        ShowErrorMessage("Impresora no esta lista", "Impresora no esta lista para imprimir. Favor Revisar")
                    End If
                Else
                    Me.DialogResult = DialogResult.Yes
                    Me.Close()
                End If
            Else
                If mFactura.Status <> 3 Then
                    ShowErrorMessage("", "Esta Factura no actualizo existencia, modifiquela o eliminela!")
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            oBloqueoDocumento.BorrarBloqueo(mFactura.Serial, mFactura.Type)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LibXConnector1.Delete()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SelectRow()
        If LibXGrid1.CurrentRowIndex > -1 Then
            mFactura.Serial = Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColftserial_no)
            mFactura.dCambio = Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColCambio)
            mFactura.Type = Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColtypeCode)
            mFactura.Is_Domi = Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColDomisi)
            mFactura.dCliente = Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColCust_code)
            mFactura.Status = Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColStatus)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If LibXConnector1.Parameters.Datos.Contains("vend_code") Then
            Me.xcbo_vend_code.currValue = LibXConnector1.Parameters.Datos.Item("vend_code")
        End If
        Me.SetFilter()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.xcbo_caja_code.currValue = -1
        Me.xcbo_caje_code.currValue = -1
        Me.xcbo_vend_code.currValue = -1
        Me.xcbo_domicilio.currValue = -1
        SetFilter()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SetFilter()
    End Sub
    Private Sub LibXGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LibXGrid1.DoubleClick
        Try
            SelectRow()

            mFontofactura = New SGT.PuntodeVenta.Entidades.MontoFactura(mFactura.Serial)
            oBloqueoDocumento = New SGT.PuntodeVenta.Entidades.BloqueoFactua

            If mFontofactura.MontoNeto <> mFontofactura.MontoFactura Then
                Dim XUpdate As New LibX.Data.XUpdateStmt("ftfactm")
                XUpdate.FieldsSet("fact_total") = mFontofactura.MontoBruto
                XUpdate.Fields("ftserial_no") = mFactura.Serial
                XUpdate.Execute()
            End If

            If mFactura.Is_Domi = 1 And mFactura.Status = 1 Then
                If oBloqueoDocumento.BuscarBloqueo(mFactura.Serial, mFactura.Type) = True Then
                    Throw New ApplicationException("Este Documento lo estan modificando o cobrando!")
                Else
                    oBloqueoDocumento.BloquearDocumento(mFactura.Serial, mFactura.Type)
                End If
            End If

            If mFontofactura.Isomovimiento(mFactura.Type, mFactura.Serial) = True Or mFactura.Status = 3 Then
                If mFactura.Is_Domi = 1 And mFactura.Status <> 3 And oAtion = True Then
                    If Val(Me.xtxVuelto.Text) < 0 Then
                        Throw New ApplicationException("El Cambio de este Domicilio es menor que el monto facturado!")
                    End If
                    If OpenPrinter() Then
                        If PedirMensajero() = True Then
                            SetPrinted(mFactura.Serial)
                            Me.Close()
                        End If
                    Else
                        ShowErrorMessage("Imprimiendo....", "Impresora no esta lista para imprimir. Favor Revisar")
                    End If
                Else
                    Me.DialogResult = DialogResult.Yes
                    Me.Close()
                End If
            Else
                If mFactura.Status <> 3 Then
                    Throw New ApplicationException("Esta Factura no actualizo existencia, modifiquela o eliminela!")
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            oBloqueoDocumento.BorrarBloqueo(mFactura.Serial, mFactura.Type)
        End Try
    End Sub
    Private Sub i_fthold01_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If LibXConnector1.HasRecords = True Then
                If e.KeyCode = Keys.F5 Then
                    oElejir = True
                    SelectRow()
                    mFontofactura = New SGT.PuntodeVenta.Entidades.MontoFactura(mFactura.Serial)
                    oBloqueoDocumento = New SGT.PuntodeVenta.Entidades.BloqueoFactua
                    If mFontofactura.MontoNeto <> mFontofactura.MontoFactura Then
                        Dim XUpdate As New LibX.Data.XUpdateStmt("ftfactm")
                        XUpdate.FieldsSet("fact_total") = mFontofactura.MontoBruto
                        XUpdate.Fields("ftserial_no") = mFactura.Serial
                        XUpdate.Execute()
                    End If
                    If mFactura.Is_Domi = 1 And mFactura.Status = 1 Then
                        If oBloqueoDocumento.BuscarBloqueo(mFactura.Serial, mFactura.Type) = True Then
                            Throw New ApplicationException("Este Documento lo estan modificando o cobrando!")
                        Else
                            oBloqueoDocumento.BloquearDocumento(mFactura.Serial, mFactura.Type)
                        End If
                    End If

                    If mFontofactura.Isomovimiento(mFactura.Type, mFactura.Serial) = True Or mFactura.Status = 3 Then
                        If mFactura.Is_Domi = 1 And mFactura.Status <> 3 And oAtion = True Then
                            If Val(Me.xtxVuelto.Text) < 0 Then
                                Throw New ApplicationException("El Cambio de este Domicilio es menor que el monto facturado!")
                            End If

                            If OpenPrinter() Then
                                If PedirMensajero() = True Then
                                    SetPrinted(mFactura.Serial)
                                    Me.Close()
                                End If

                            Else
                                ShowErrorMessage("Imprimiendo.....", "Impresora no esta lista para imprimir. Favor Revisar")
                            End If
                        Else
                            Me.DialogResult = DialogResult.Yes
                            Me.Close()
                        End If
                    Else
                        If mFactura.Status <> 3 Then
                            Throw New ApplicationException("Esta Factura no actualizo existencia, modifiquela o eliminela!")
                        End If
                    End If
                End If
            End If


        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally
            If oElejir = True Then
                oBloqueoDocumento.BorrarBloqueo(mFactura.Serial, mFactura.Type)
            End If
        End Try
    End Sub
    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid1.CurrentRowChanged

        Me.LibXGrid2.CaptionText = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColCliente)
        RefreshDetail()
        SelectRow()

        If mFactura.Is_Domi = 1 And mFactura.dCambio > 0 Then
            Me.xtxCambio.Visible = True
            Me.Label3.Visible = True
            Me.xtxVuelto.Visible = True
            Me.xtxCambio.Text = mFactura.dCambio
            Me.xtxVuelto.Text = Format(mFactura.dCambio - mFactura.MontoFacturado, "###,###,##0.00")
        Else
            Me.xtxCambio.Visible = False
            Me.Label3.Visible = False
            Me.xtxVuelto.Visible = False
        End If

    End Sub
    Private Sub RefreshDetail()

        Me.xtxTotalFacturado.Text = String.Empty
        If LibXGrid1.CurrentRowIndex > -1 AndAlso ftfactm.Rows.Count > 0 Then
            Me.LibXConnector1.LoadDetail(LibXGrid1.GetCurrentRowView.Row, Me.LibXDbSourceTable2)
            mFontofactura = New SGT.PuntodeVenta.Entidades.MontoFactura(Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColftserial_no))
            mFactura.MontoNeto = Format(mFontofactura.MontoNeto, "###,###,##0.00")
            mFactura.MontoFacturado = Format(mFontofactura.MontoFactura, "###,###,##0.00")
            mFactura.MontoBruto = Format(mFontofactura.MontoBruto, "###,###,##0.00")
            Me.xtxTotalFacturado.Text = Format(mFactura.MontoFacturado, "###,###,##0.00")
        Else
            Me.LibXConnector1.ClearDetail()
        End If
    End Sub
    Private Sub LibXGrid1_CellKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LibXGrid1.CellKeyPress
        Try
            If LibXConnector1.HasRecords = True Then
                If e.KeyCode = Keys.F5 _
                Or e.KeyCode = Keys.Enter Then

                    SelectRow()
                    mFontofactura = New SGT.PuntodeVenta.Entidades.MontoFactura(mFactura.Serial)
                    oBloqueoDocumento = New SGT.PuntodeVenta.Entidades.BloqueoFactua
                    If mFontofactura.MontoNeto <> mFontofactura.MontoFactura Then
                        Dim XUpdate As New LibX.Data.XUpdateStmt("ftfactm")
                        XUpdate.FieldsSet("fact_total") = mFontofactura.MontoBruto
                        XUpdate.Fields("ftserial_no") = mFactura.Serial
                        XUpdate.Execute()
                    End If

                    If mFactura.Is_Domi = 1 And mFactura.Status = 1 Then
                        If oBloqueoDocumento.BuscarBloqueo(mFactura.Serial, mFactura.Type) = True Then
                            Throw New ApplicationException("Este Documento lo estan modificando o cobrando!")
                        Else
                            oBloqueoDocumento.BloquearDocumento(mFactura.Serial, mFactura.Type)
                        End If
                    End If

                    If mFontofactura.Isomovimiento(mFactura.Type, mFactura.Serial) = True Or mFactura.Status = 3 Then
                        If mFactura.Is_Domi = 1 And mFactura.Status <> 3 And oAtion = True Then
                            If Val(Me.xtxVuelto.Text) < 0 Then
                                Throw New ApplicationException("El Cambio de este Domicilio es menor que el monto facturado!")
                            End If

                            If OpenPrinter() Then
                                If PedirMensajero() = True Then
                                    SetPrinted(mFactura.Serial)
                                    Me.Close()
                                End If
                            Else
                                ShowErrorMessage("Imprimiendo.....", "Impresora no esta lista para imprimir. Favor Revisar")
                            End If
                        Else
                            Me.DialogResult = DialogResult.Yes
                            Me.Close()
                        End If
                    Else
                        If mFactura.Status <> 3 Then
                            Throw New ApplicationException("Esta Factura no actualizo existencia, modifiquela o eliminela!")
                        End If
                    End If
                    oBloqueoDocumento.BorrarBloqueo(mFactura.Serial, mFactura.Type)
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        Finally

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
        Dim cIASerial As Integer
        Dim AxCrystalReport1 As LibX.ReportLib

        Try
            oMensajero = New i_pvmensj01
            oDocumento = New SGT.Inventario.Entidades.Documento(mFactura.Type)
            oParametroNCF = New SGT.Facturacion.Entidades.ParametrosCreditoFiscal

            If mFactura.Type = "FSG" Then
                cIASerial = LibX.Data.Manager.GetScalar("select cia_serial from ftsegrm where ftserial_no = " & mFactura.Serial)
                mFactura.dCliente = LibX.Data.Manager.GetScalar("select cust_code from sgciasm where cia_serial = " & cIASerial)
            End If

            vCliente = New SGT.CXC.Entidades.Cliente(mFactura.dCliente)

            oBloqueoDocumento = New SGT.PuntodeVenta.Entidades.BloqueoFactua

            If oMensajero.ShowDialog(mFactura.Serial) = DialogResult.Yes Then
                blnSuccess = True

                If vCliente.Ncf > 0 Then
                    oParametroNCF.TipoNcf = vCliente.Ncf
                End If

                If WhDefaultNo = 1 Then
                    oParametroNCF.Almacen = WhDefaultNo
                Else
                    oParametroNCF.Almacen = LibXConnector1.CurrentDataRow!whse_code
                End If
                oParametroNCF.Cstype = vCliente.TipoCliente
                oParametroNCF.TipoDocumento = mFactura.Type
                If mFactura.dCliente > 0 Then
                    oParametroNCF.Cliente = mFactura.dCliente
                    oParametroNCF.ClienteRegistrado = True
                Else
                    If Not LibX.IsNull(LibXConnector1.CurrentDataRow!cust_serial) AndAlso LibXConnector1.CurrentDataRow!cust_serial > 0 Then
                        oParametroNCF.Cliente = LibXConnector1.CurrentDataRow!cust_serial
                        oParametroNCF.ClienteRegistrado = False
                    End If
                End If
                If oDocumento.GenerarNCF = True Then
                    If ofctDocumento.AplicarCreditoFiscal(oParametroNCF) = True Then
                        If LibX.Data.Manager.Connection.IsIntransaction = False Then
                            LibX.Data.Manager.Connection.BeginTransaction()
                        End If

                        Dim XUpdate As New LibX.Data.XUpdateStmt("ftfactm")
                        If WhDefaultNo = 1 Then
                            mNumero = oDocumento.GenerateNumber(mFactura.Type, WhDefaultNo)
                        Else
                            mNumero = oDocumento.GenerateNumber(mFactura.Type, LibXConnector1.CurrentDataRow!whse_code)
                        End If
                        XUpdate.FieldsSet("fact_number") = mNumero
                        XUpdate.FieldsSet("fact_status") = 4 'Domicilio Pendiente

                        If Val(oParametroNCF.Retorno.Cliente) > 0 Then
                            XUpdate.FieldsSet("cust_serial") = oParametroNCF.Retorno.Cliente
                        Else
                            If mFactura.dCliente > 0 Then
                                XUpdate.FieldsSet("cust_serial") = mFactura.dCliente
                            End If
                        End If

                        If oParametroNCF.Retorno.NCF <> Nothing Then
                            XUpdate.FieldsSet("fact_ncf") = oParametroNCF.Retorno.NCF
                        End If

                        XUpdate.Fields("ftserial_no") = mFactura.Serial
                        XUpdate.Execute()

                        Dim mXUpdate As New LibX.Data.XUpdateStmt("ivtranrm")
                        mXUpdate.FieldsSet("doc_number") = mNumero
                        mXUpdate.Fields("type_code") = mFactura.Type
                        mXUpdate.Fields("doc_serial") = mFactura.Serial
                        mXUpdate.Execute()

                    Else
                        Throw New ApplicationException("Proceso abortado!")
                    End If
                Else
                    Dim XUpdate As New LibX.Data.XUpdateStmt("ftfactm")
                    mNumero = oDocumento.GenerateNumber(mFactura.Type, LibXConnector1.CurrentDataRow!whse_code)
                    XUpdate.FieldsSet("fact_number") = mNumero
                    XUpdate.FieldsSet("fact_status") = 4 'Domicilio Pendiente
                    XUpdate.Fields("ftserial_no") = mFactura.Serial
                    XUpdate.Execute()

                    Dim mXUpdate As New LibX.Data.XUpdateStmt("ivtranrm")
                    mXUpdate.FieldsSet("doc_number") = mNumero
                    mXUpdate.Fields("type_code") = mFactura.Type
                    mXUpdate.Fields("doc_serial") = mFactura.Serial
                    mXUpdate.Execute()
                End If

                '// Verifica si puerto esta disponible
                If OpenPrinter() Then

                    Dim PrinFisic As ImpresoraFisica = ValidatePrinterStatus()

                    '// Verifica el status de la impresora
                    If PrinFisic.IsSucess AndAlso PrinFisic.ReturnCode = 0 Then

                        Dim Fact As Factura
                        Fact = SGT.Caja.Operaciones.clsCobroFiscal.FillData(mFactura.Serial)

                        If SendToPrinterEpson(Fact) Then
                            SetPrinted(mFactura.Serial)
                        End If

                    Else
                        ShowErrorMessage("Imprimiendo....", String.Format("Impresora no esta lista. Error Code: {0}", PrinFisic.ReturnCode))
                    End If
                Else
                    ShowErrorMessage("Imprimiendo....", "El Puerto de la impresora no esta disponible para usar")

                End If

                If LibX.Data.Manager.Connection.IsIntransaction = True Then
                    LibX.Data.Manager.Connection.CommitTransaction()
                End If

                oBloqueoDocumento.BorrarBloqueo(mFactura.Serial, mFactura.Type)

                LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & LibXConnector1.CurrentDataRow!ftserial_no.ToString.Trim)

                Return True

            Else
                Return False
            End If

            LibXConnector1.RefreshSources()

            Return blnSuccess
        Catch ex As Exception
            LibX.Log.Add(ex, True)
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
        Finally
            oBloqueoDocumento.BorrarBloqueo(mFactura.Serial, mFactura.Type)
        End Try
    End Function

    Private Function CreateFactory() As IPrintFiscal
        Dim Connected As Boolean = False

        'Note: To use Redsoft Open Connection
        Dim dbconn As SqlConnection = New SqlConnection(dbOPenn)

        'Note: CajaId From AppSettings
        Dim cajaSetiada As String = oMachine.ToString.Trim

        Dim _dbHandler As IDbHandler = New PrintDbHandler(dbconn)

        Dim factory As PrinterFactory = _
        New PrinterFactory( _
        New ParametroRepository(_dbHandler), _
        New ImpresoraRepository(_dbHandler), _
        New ExtensionRepository(_dbHandler), _
        New TipoPagoRepository(_dbHandler))

        'Pasando Dependencia por una propiedad
        factory.ErrorRetorno = New ErrorRetornoRepository(_dbHandler)

        Dim print As IPrintFiscal = New ImpresionFiscalEpson(factory, Epson, 1, cajaSetiada)

        Return print

    End Function


    Private Sub CancelarFactura()
        Dim printer As IPrintFiscal = CreateFactory()
        printer.CancelarImpresionFiscal()
    End Sub

    Private Function ValidatePrinterStatus() As ImpresoraFisica
        Dim printer As IPrintFiscal = CreateFactory()

        Return printer.ValidaPrinterStatus()

    End Function

    Private Function OpenPrinter() As Boolean

        Dim Connected As Boolean = False

        'Note: To use Redsoft Open Connection
        Dim dbconn As SqlConnection = New SqlConnection(dbOPenn)

        Dim _dbHandler As IDbHandler = New PrintDbHandler(dbconn)

        Dim factory As PrinterFactory = _
        New PrinterFactory( _
        New ParametroRepository(_dbHandler), _
        New ImpresoraRepository(_dbHandler), _
        New ExtensionRepository(_dbHandler), _
        New TipoPagoRepository(_dbHandler))

        'Pasando Dependencia por una propiedad
        factory.ErrorRetorno = New ErrorRetornoRepository(_dbHandler)

        Dim print As IPrintFiscal = New ImpresionFiscalEpson(factory, Epson, 1, "")

        Try
            'Connected = print.Connect(Puerto.COM1, Velocidad.br9600)
            Connected = print.Connect(oMachine.ToString.Trim())
        Catch ex As Exception
            Throw New Exception("Impresora no esta lista para imprimir. Favor Revisar")
        Finally
            'print.Disconnect()
        End Try

        Return Connected

    End Function

    Private Function SendToPrinterEpson(ByVal FacturaToPrint As Factura) As Boolean

        Dim ImpresionSatisfactoria As Boolean = True
        Dim Continuo As Boolean = True

        'Note: CajaId From AppSettings
        Dim cajaSetiada As String = oMachine.ToString.Trim

        'Note: Redsoft Open Connection
        Dim dbconn As SqlConnection = New SqlConnection(dbOPenn)
        Dim _dbHandler As IDbHandler = New PrintDbHandler(dbconn)

        Dim factory As PrinterFactory = _
        New PrinterFactory( _
        New ParametroRepository(_dbHandler), _
        New ImpresoraRepository(_dbHandler), _
        New ExtensionRepository(_dbHandler), _
        New TipoPagoRepository(_dbHandler))

        'Pasando Dependencia por una propiedad
        factory.ErrorRetorno = New ErrorRetornoRepository(_dbHandler)

        Dim fisicaPrinter As ImpresoraFisica = New ImpresoraFisica

        Dim print As IPrintFiscal = New ImpresionFiscalEpson(factory, Epson, 1, cajaSetiada)

        Try
            'Connect the Printer;
            'Continuo = print.Connect(Puerto.COM1, Velocidad.br9600)
            Continuo = print.Connect(oMachine.ToString.Trim())

            If Not Continuo Then
                print.Disconnect()
                ShowErrorMessage("Imprimiendo...", "Ocurrio un error abriendo el puerto de la impresora")
            End If

            fisicaPrinter = print.CreditoFiscal(FacturaToPrint)

            If Not fisicaPrinter.IsSucess Then
                ImpresionSatisfactoria = False
                MessageBox.Show(String.Format("Ocurrio un error imprimiendo. Codigo: {0} - Descripcion: {2} - Status: {1}", _
                                                        fisicaPrinter.ReturnCode, _
                                                        fisicaPrinter.PrinterStatus, _
                                                        fisicaPrinter.ErrorDescription), _
                                "Imprimiendo...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

                '// Cancela la impresion luego de un fallo
                print.CancelarImpresionFiscal()

            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
            Throw ex
        Finally
            print.Disconnect()
        End Try

        Return ImpresionSatisfactoria

    End Function

    Private Sub SetPrinted(ByVal pftserial_no As Integer)
        Dim XUpdate As LibX.Data.XUpdateStmt

        XUpdate = New LibX.Data.XUpdateStmt("ftfactm")
        XUpdate.FieldsSet("fact_impresa") = 1
        XUpdate.Fields("ftserial_no") = pftserial_no
        XUpdate.Execute()
    End Sub


    Private Function SendToPrinterEpsonNoFiscal(ByVal DocPrint As String()) As Boolean

        Dim ImpresionSatisfactoria As Boolean = True
        Dim Continuo As Boolean = True

        Dim fisicaPrinter As ImpresoraFisica = New ImpresoraFisica

        Dim print As IPrintFiscal = CreateFactory()

        Try
            'Connect the Printer;
            'Continuo = print.Connect(Puerto.COM1, Velocidad.br9600)
            Continuo = print.Connect(oMachine.ToString.Trim())

            If Not Continuo Then
                print.Disconnect()
                ShowErrorMessage("Imprimiendo...", "Ocurrio un error abriendo el puerto de la impresora")
            End If

            fisicaPrinter = print.DocumentoNoFiscal(DocPrint)

            If Not fisicaPrinter.IsSucess Then
                ImpresionSatisfactoria = False
                MessageBox.Show(String.Format("Ocurrio un error imprimiendo. Codigo: {0} - Descripcion: {2} - Status: {1}", _
                                                        fisicaPrinter.ReturnCode, _
                                                        fisicaPrinter.PrinterStatus, _
                                                        fisicaPrinter.ErrorDescription), _
                                "Imprimiendo....", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                print.CancelarImpresionFiscal()
                print.Disconnect()

            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
            Throw ex
        Finally
            print.Disconnect()
        End Try

        Return ImpresionSatisfactoria

    End Function


    Private Sub ShowErrorMessage(ByVal title As String, ByVal message As String)
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    End Sub


End Class
