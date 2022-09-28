Imports System.Configuration.ConfigurationSettings
Imports SGT.Caja.Entidades
Imports LibX
Imports SGT.PuntodeVenta.Entidades
Public Class p_cjfact01
    Inherits System.Windows.Forms.Form
    Dim oPermission As SGT.Administracion.Entidades.Permission
    Dim oCaja As Caja
    Dim oCajera As Cajera
    Dim oCajaAbierta As CajaAbierta

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents btnCobrar As System.Windows.Forms.Button
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents btnRefrescar As System.Windows.Forms.Button
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblCaja As System.Windows.Forms.Label
    Friend WithEvents lblCajera As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents XdataGridTableStyle2 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn8 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn9 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn10 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn11 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn12 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn13 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn14 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn15 As LibX.XEditTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ftfactm As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents ftfactd As System.Data.DataTable
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents gcolSerial As LibX.XEditTextBoxColumn
    Friend WithEvents XdataGridTableStyle3 As LibX.XdataGridTableStyle
    Friend WithEvents XGrd_Documentos As LibX.LibXGrid
    Friend WithEvents XGrd_Productos As LibX.LibXGrid
    Friend WithEvents XGrd_Domicilios As LibX.LibXGrid
    Friend WithEvents btnPreparar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents gColtype_code As LibX.XEditTextBoxColumn
    Friend WithEvents gColfact_number As LibX.XEditTextBoxColumn
    Friend WithEvents gColfact_date As LibX.XEditTextBoxColumn
    Friend WithEvents gColvend_name As LibX.XEditTextBoxColumn
    Friend WithEvents gColbus_name As LibX.XEditTextBoxColumn
    Friend WithEvents gColfact_inddomicilio As LibX.XDataGridBoolColumn
    Friend WithEvents gColnet_amount As LibX.XEditTextBoxColumn
    Friend WithEvents chk_domicilio As System.Windows.Forms.CheckBox
    Friend WithEvents lblDomicilio As System.Windows.Forms.Label
    Friend WithEvents chk_estafeta As System.Windows.Forms.CheckBox
    Friend WithEvents lblEstafeta As System.Windows.Forms.Label
    Friend WithEvents chk_facturas As System.Windows.Forms.CheckBox
    Friend WithEvents lblFacturas As System.Windows.Forms.Label
    Friend WithEvents chk_recibos As System.Windows.Forms.CheckBox
    Friend WithEvents chk_devoluciones As System.Windows.Forms.CheckBox
    Friend WithEvents lbldevoluciones As System.Windows.Forms.Label
    Friend WithEvents lblrecibos As System.Windows.Forms.Label
    Friend WithEvents gDtype_code As LibX.XEditTextBoxColumn
    Friend WithEvents gdfact_number As LibX.XEditTextBoxColumn
    Friend WithEvents gdfact_date As LibX.XEditTextBoxColumn
    Friend WithEvents gdvend_name As LibX.XEditTextBoxColumn
    Friend WithEvents gdbus_name As LibX.XEditTextBoxColumn
    Friend WithEvents gdnet_amount As LibX.XEditTextBoxColumn
    Friend WithEvents gddomi_cambio As LibX.XEditTextBoxColumn
    Friend WithEvents gddomi_date As LibX.XEditTextBoxColumn
    Friend WithEvents tabDomicilio As System.Windows.Forms.TabPage
    Friend WithEvents TabPendiente As System.Windows.Forms.TabPage
    Friend WithEvents xcbo_vend_code As LibX.LibXCombo
    Friend WithEvents xdt_fact_date As LibX.LibxDateTimePicker
    Friend WithEvents xcbo_caja_code As LibX.LibXCombo
    Friend WithEvents xcbo_caje_code As LibX.LibXCombo
    Friend WithEvents xcbo_type_code As LibX.LibXCombo
    Friend WithEvents xcbo_vend_mensaj As LibX.LibXCombo
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(p_cjfact01))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xcbo_vend_code = New LibX.LibXCombo
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
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.ftfactd = New System.Data.DataTable
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
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.xdt_fact_date = New LibX.LibxDateTimePicker
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.xcbo_caja_code = New LibX.LibXCombo
        Me.Label7 = New System.Windows.Forms.Label
        Me.xcbo_caje_code = New LibX.LibXCombo
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.xcbo_type_code = New LibX.LibXCombo
        Me.xcbo_vend_mensaj = New LibX.LibXCombo
        Me.lblCaja = New System.Windows.Forms.Label
        Me.lblCajera = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chk_domicilio = New System.Windows.Forms.CheckBox
        Me.lblDomicilio = New System.Windows.Forms.Label
        Me.chk_estafeta = New System.Windows.Forms.CheckBox
        Me.lblEstafeta = New System.Windows.Forms.Label
        Me.chk_devoluciones = New System.Windows.Forms.CheckBox
        Me.chk_facturas = New System.Windows.Forms.CheckBox
        Me.lbldevoluciones = New System.Windows.Forms.Label
        Me.lblFacturas = New System.Windows.Forms.Label
        Me.chk_recibos = New System.Windows.Forms.CheckBox
        Me.lblrecibos = New System.Windows.Forms.Label
        Me.btnRefrescar = New System.Windows.Forms.Button
        Me.btnCobrar = New System.Windows.Forms.Button
        Me.XGrd_Documentos = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColtype_code = New LibX.XEditTextBoxColumn
        Me.gColfact_number = New LibX.XEditTextBoxColumn
        Me.gColfact_date = New LibX.XEditTextBoxColumn
        Me.gColvend_name = New LibX.XEditTextBoxColumn
        Me.gColbus_name = New LibX.XEditTextBoxColumn
        Me.gColfact_inddomicilio = New LibX.XDataGridBoolColumn
        Me.gColnet_amount = New LibX.XEditTextBoxColumn
        Me.gcolSerial = New LibX.XEditTextBoxColumn
        Me.DataView1 = New System.Data.DataView
        Me.btnView = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.XGrd_Productos = New LibX.LibXGrid
        Me.XdataGridTableStyle2 = New LibX.XdataGridTableStyle
        Me.XEditTextBoxColumn8 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn9 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn10 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn11 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn12 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn13 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn14 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn15 = New LibX.XEditTextBoxColumn
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPendiente = New System.Windows.Forms.TabPage
        Me.tabDomicilio = New System.Windows.Forms.TabPage
        Me.XGrd_Domicilios = New LibX.LibXGrid
        Me.XdataGridTableStyle3 = New LibX.XdataGridTableStyle
        Me.gDtype_code = New LibX.XEditTextBoxColumn
        Me.gdfact_number = New LibX.XEditTextBoxColumn
        Me.gdfact_date = New LibX.XEditTextBoxColumn
        Me.gdvend_name = New LibX.XEditTextBoxColumn
        Me.gdbus_name = New LibX.XEditTextBoxColumn
        Me.gdnet_amount = New LibX.XEditTextBoxColumn
        Me.gddomi_cambio = New LibX.XEditTextBoxColumn
        Me.gddomi_date = New LibX.XEditTextBoxColumn
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnPreparar = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.XGrd_Documentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XGrd_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPendiente.SuspendLayout()
        Me.tabDomicilio.SuspendLayout()
        CType(Me.XGrd_Domicilios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xcbo_vend_code)
        Me.GroupBox1.Controls.Add(Me.xdt_fact_date)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xcbo_caja_code)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.xcbo_caje_code)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.xcbo_type_code)
        Me.GroupBox1.Controls.Add(Me.xcbo_vend_mensaj)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 96)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio"
        '
        'xcbo_vend_code
        '
        Me.xcbo_vend_code.AllowDefaultSort = True
        Me.xcbo_vend_code.bound = True
        Me.xcbo_vend_code.currValue = Nothing
        Me.xcbo_vend_code.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "ftfactm.vend_code"))
        Me.xcbo_vend_code.DefaultWhereString = "vend_cargo = 2"
        Me.xcbo_vend_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_vend_code.EditInitialValue = Nothing
        Me.xcbo_vend_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_code.FieldDescription = ""
        Me.xcbo_vend_code.FindInitialValue = Nothing
        Me.xcbo_vend_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_code.IgnoreRequiered = False
        Me.xcbo_vend_code.Location = New System.Drawing.Point(80, 16)
        Me.xcbo_vend_code.LookupKeyDisplayFields = "vend_name"
        Me.xcbo_vend_code.LookupKeyField = "vend_code"
        Me.xcbo_vend_code.LookupTableName = "ftvendm"
        Me.xcbo_vend_code.Name = "xcbo_vend_code"
        Me.xcbo_vend_code.NewInitialValue = Nothing
        Me.xcbo_vend_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_code.Requiered = False
        Me.xcbo_vend_code.Required = False
        Me.xcbo_vend_code.Size = New System.Drawing.Size(280, 21)
        Me.xcbo_vend_code.SqlString = Nothing
        Me.xcbo_vend_code.StatusBarPanelDescripcion = Nothing
        Me.xcbo_vend_code.TabIndex = 6
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftfactm, Me.ftfactd, Me.DataTable1})
        '
        'ftfactm
        '
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn19, Me.DataColumn20, Me.DataColumn31})
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
        Me.DataColumn2.ColumnName = "type_code"
        Me.DataColumn2.MaxLength = 3
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "fact_date"
        Me.DataColumn3.DataType = GetType(System.DateTime)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "vend_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "vend_name"
        Me.DataColumn5.MaxLength = 60
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "bus_name"
        Me.DataColumn6.MaxLength = 100
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "fact_inddomicilio"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "net_amount"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        Me.DataColumn8.ReadOnly = True
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "fact_number"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "Column1"
        Me.DataColumn20.DataType = GetType(System.Decimal)
        Me.DataColumn20.ReadOnly = True
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "fact_total"
        Me.DataColumn31.DataType = GetType(System.Decimal)
        Me.DataColumn31.ReadOnly = True
        '
        'ftfactd
        '
        Me.ftfactd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18})
        Me.ftfactd.TableName = "ftfactd"
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "ftserial_no"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "line_no"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "item_code"
        Me.DataColumn11.MaxLength = 10
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "item_name"
        Me.DataColumn12.MaxLength = 100
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "qty"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "unit_code"
        Me.DataColumn14.MaxLength = 5
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "price"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "dscto"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "itbis"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "net_amount"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        Me.DataColumn18.ReadOnly = True
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30})
        Me.DataTable1.TableName = "ftdomim"
        '
        'DataColumn21
        '
        Me.DataColumn21.AllowDBNull = False
        Me.DataColumn21.AutoIncrement = True
        Me.DataColumn21.ColumnName = "ftserial_no"
        Me.DataColumn21.DataType = GetType(System.Int32)
        Me.DataColumn21.ReadOnly = True
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "type_code"
        Me.DataColumn22.MaxLength = 3
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "fact_number"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.ColumnName = "fact_date"
        Me.DataColumn24.DataType = GetType(System.DateTime)
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "vend_mensaj"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "vend_name"
        Me.DataColumn26.MaxLength = 60
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "bus_name"
        Me.DataColumn27.MaxLength = 100
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "net_amount"
        Me.DataColumn28.DataType = GetType(System.Decimal)
        Me.DataColumn28.ReadOnly = True
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "domi_cambio"
        Me.DataColumn29.DataType = GetType(System.Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "domi_date"
        Me.DataColumn30.DataType = GetType(System.DateTime)
        '
        'xdt_fact_date
        '
        Me.xdt_fact_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_fact_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LibXConnector1, "ftfactm.fact_date"))
        Me.xdt_fact_date.EditInitialValue = Nothing
        Me.xdt_fact_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_fact_date.FieldDescription = ""
        Me.xdt_fact_date.FindInitialValue = "Now"
        Me.xdt_fact_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_fact_date.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.xdt_fact_date.IgnoreRequiered = False
        Me.xdt_fact_date.Location = New System.Drawing.Point(80, 64)
        Me.xdt_fact_date.Name = "xdt_fact_date"
        Me.xdt_fact_date.NewInitialValue = Nothing
        Me.xdt_fact_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_fact_date.Requiered = False
        Me.xdt_fact_date.Size = New System.Drawing.Size(104, 20)
        Me.xdt_fact_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_fact_date.TabIndex = 5
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
        Me.LibXConnector1.DataMember = Nothing
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = True
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2, Me.LibXDbSourceTable3})
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
        Me.LibXDbSourceTable1.InnerJon = True
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "ftserial_no"
        Me.LibXDbSourceTable1.Sort = "ftserial_no"
        Me.LibXDbSourceTable1.Source = New String() {"select ftfactm.ftserial_no,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.fact_number,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.type_code,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.fact_date,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.vend_code,", "" & Microsoft.VisualBasic.ChrW(9) & "ftvendm.vend_name,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.bus_name,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.fact_inddomicilio,", "" & Microsoft.VisualBasic.ChrW(9) & "(((isnull(ftfactm.fact_total,0) + ", "" & Microsoft.VisualBasic.ChrW(9) & "isnull(ftfactm.descto,0)) + ", "" & Microsoft.VisualBasic.ChrW(9) & "isnull(ftfactm.itbis,0)) - ", "" & Microsoft.VisualBasic.ChrW(9) & "isnull(ftfactm.seg_amount,0)) fact_total", "from ftfactm", "left outer join ftvendm", "on ftfactm.vend_code = ftvendm.vend_code"}
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
        Me.LibXDbSourceTable2.FillOnRowChange = False
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
        Me.LibXDbSourceTable2.Source = New String() {"select ftfactd.ftserial_no,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactd.line_no,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactd.item_code,", "" & Microsoft.VisualBasic.ChrW(9) & "ivitemm.item_name,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactd.qty,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactd.unit_code,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactd.price,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactd.dscto,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactd.itbis,", "" & Microsoft.VisualBasic.ChrW(9) & "((isnull(ftfactd.qty,0) * isnull(ftfactd.price,0)) ", "" & Microsoft.VisualBasic.ChrW(9) & "- isnull(ftfactd.dscto,0) + isnull(ftfactd.itbis,0)) net_amount", "from ftfactd inner join ivitemm", "on ftfactd.item_code = ivitemm.item_code", "order by ftfactd.ftserial_no,ftfactd.line_no"}
        Me.LibXDbSourceTable2.TableName = "ftfactd"
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
        Me.LibXDbSourceTable3.FillOnRowChange = False
        Me.LibXDbSourceTable3.HeaderIsOnGrid = False
        Me.LibXDbSourceTable3.InnerJon = True
        Me.LibXDbSourceTable3.InsertOrder = 0
        Me.LibXDbSourceTable3.IsDetail = True
        Me.LibXDbSourceTable3.KeyFields = Nothing
        Me.LibXDbSourceTable3.LineColName = Nothing
        Me.LibXDbSourceTable3.MasterDetailRelation = New String() {"ftserial_no=ftserial_no"}
        Me.LibXDbSourceTable3.MasterTableName = Nothing
        Me.LibXDbSourceTable3.SerialColumnName = Nothing
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = New String() {"select ftfactm.ftserial_no,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.type_code,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.fact_number,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.fact_date,", "" & Microsoft.VisualBasic.ChrW(9) & "ftdomim.vend_mensaj,", "" & Microsoft.VisualBasic.ChrW(9) & "ftvendm.vend_name,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.bus_name,", "" & Microsoft.VisualBasic.ChrW(9) & "(((isnull(ftfactm.fact_total,0) + ", "" & Microsoft.VisualBasic.ChrW(9) & "isnull(ftfactm.descto,0)) + ", "" & Microsoft.VisualBasic.ChrW(9) & "isnull(ftfactm.itbis,0)) - ", "" & Microsoft.VisualBasic.ChrW(9) & "isnull(ftfactm.seg_amount,0)) net_amount,", "" & Microsoft.VisualBasic.ChrW(9) & "ftdomim.domi_cambio,", "" & Microsoft.VisualBasic.ChrW(9) & "ftdomim.domi_date", "from ftfactm", "inner join ftdomim", "on ftdomim.ftserial_no = ftfactm.ftserial_no", "left outer join ftvendm", "on ftdomim.vend_mensaj = ftvendm.vend_code"}
        Me.LibXDbSourceTable3.TableName = "ftdomim"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(29, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Vendedor:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mensajero:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_caja_code
        '
        Me.xcbo_caja_code.AllowDefaultSort = True
        Me.xcbo_caja_code.bound = True
        Me.xcbo_caja_code.currValue = Nothing
        Me.xcbo_caja_code.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "ftfactm.vend_code"))
        Me.xcbo_caja_code.DefaultWhereString = Nothing
        Me.xcbo_caja_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_caja_code.EditInitialValue = Nothing
        Me.xcbo_caja_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caja_code.FieldDescription = ""
        Me.xcbo_caja_code.FindInitialValue = Nothing
        Me.xcbo_caja_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caja_code.IgnoreRequiered = False
        Me.xcbo_caja_code.Location = New System.Drawing.Point(448, 16)
        Me.xcbo_caja_code.LookupKeyDisplayFields = "caja_name"
        Me.xcbo_caja_code.LookupKeyField = "caja_code"
        Me.xcbo_caja_code.LookupTableName = "cjcajam"
        Me.xcbo_caja_code.Name = "xcbo_caja_code"
        Me.xcbo_caja_code.NewInitialValue = Nothing
        Me.xcbo_caja_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caja_code.Requiered = False
        Me.xcbo_caja_code.Required = False
        Me.xcbo_caja_code.Size = New System.Drawing.Size(320, 21)
        Me.xcbo_caja_code.SqlString = Nothing
        Me.xcbo_caja_code.StatusBarPanelDescripcion = Nothing
        Me.xcbo_caja_code.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(398, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Cajera:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_caje_code
        '
        Me.xcbo_caje_code.AllowDefaultSort = True
        Me.xcbo_caje_code.bound = True
        Me.xcbo_caje_code.currValue = Nothing
        Me.xcbo_caje_code.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "ftfactm.vend_code"))
        Me.xcbo_caje_code.DefaultWhereString = "vend_cargo = 1"
        Me.xcbo_caje_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_caje_code.EditInitialValue = Nothing
        Me.xcbo_caje_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caje_code.FieldDescription = ""
        Me.xcbo_caje_code.FindInitialValue = Nothing
        Me.xcbo_caje_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caje_code.IgnoreRequiered = False
        Me.xcbo_caje_code.Location = New System.Drawing.Point(448, 40)
        Me.xcbo_caje_code.LookupKeyDisplayFields = "vend_name"
        Me.xcbo_caje_code.LookupKeyField = "vend_code"
        Me.xcbo_caje_code.LookupTableName = "ftvendm"
        Me.xcbo_caje_code.Name = "xcbo_caje_code"
        Me.xcbo_caje_code.NewInitialValue = Nothing
        Me.xcbo_caje_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caje_code.Requiered = False
        Me.xcbo_caje_code.Required = False
        Me.xcbo_caje_code.Size = New System.Drawing.Size(320, 21)
        Me.xcbo_caje_code.SqlString = Nothing
        Me.xcbo_caje_code.StatusBarPanelDescripcion = Nothing
        Me.xcbo_caje_code.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(408, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Caja:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(349, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 16)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Tipo Documento:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_type_code
        '
        Me.xcbo_type_code.AllowDefaultSort = True
        Me.xcbo_type_code.bound = True
        Me.xcbo_type_code.currValue = Nothing
        Me.xcbo_type_code.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "ftfactm.vend_code"))
        Me.xcbo_type_code.DefaultWhereString = "apply_pos=1"
        Me.xcbo_type_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_type_code.EditInitialValue = Nothing
        Me.xcbo_type_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_type_code.FieldDescription = ""
        Me.xcbo_type_code.FindInitialValue = Nothing
        Me.xcbo_type_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_type_code.IgnoreRequiered = False
        Me.xcbo_type_code.Location = New System.Drawing.Point(448, 64)
        Me.xcbo_type_code.LookupKeyDisplayFields = "type_name"
        Me.xcbo_type_code.LookupKeyField = "type_code"
        Me.xcbo_type_code.LookupTableName = "ivtypem"
        Me.xcbo_type_code.Name = "xcbo_type_code"
        Me.xcbo_type_code.NewInitialValue = Nothing
        Me.xcbo_type_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_type_code.Requiered = False
        Me.xcbo_type_code.Required = False
        Me.xcbo_type_code.Size = New System.Drawing.Size(320, 21)
        Me.xcbo_type_code.SqlString = Nothing
        Me.xcbo_type_code.StatusBarPanelDescripcion = Nothing
        Me.xcbo_type_code.TabIndex = 6
        '
        'xcbo_vend_mensaj
        '
        Me.xcbo_vend_mensaj.AllowDefaultSort = True
        Me.xcbo_vend_mensaj.bound = True
        Me.xcbo_vend_mensaj.currValue = Nothing
        Me.xcbo_vend_mensaj.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "ftfactm.vend_code"))
        Me.xcbo_vend_mensaj.DefaultWhereString = "vend_cargo = 3"
        Me.xcbo_vend_mensaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_vend_mensaj.EditInitialValue = Nothing
        Me.xcbo_vend_mensaj.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_mensaj.FieldDescription = ""
        Me.xcbo_vend_mensaj.FindInitialValue = Nothing
        Me.xcbo_vend_mensaj.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_mensaj.IgnoreRequiered = False
        Me.xcbo_vend_mensaj.Location = New System.Drawing.Point(80, 40)
        Me.xcbo_vend_mensaj.LookupKeyDisplayFields = "vend_name"
        Me.xcbo_vend_mensaj.LookupKeyField = "vend_code"
        Me.xcbo_vend_mensaj.LookupTableName = "ftvendm"
        Me.xcbo_vend_mensaj.Name = "xcbo_vend_mensaj"
        Me.xcbo_vend_mensaj.NewInitialValue = Nothing
        Me.xcbo_vend_mensaj.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_mensaj.Requiered = False
        Me.xcbo_vend_mensaj.Required = False
        Me.xcbo_vend_mensaj.Size = New System.Drawing.Size(280, 21)
        Me.xcbo_vend_mensaj.SqlString = Nothing
        Me.xcbo_vend_mensaj.StatusBarPanelDescripcion = Nothing
        Me.xcbo_vend_mensaj.TabIndex = 6
        '
        'lblCaja
        '
        Me.lblCaja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCaja.Location = New System.Drawing.Point(88, 16)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(280, 20)
        Me.lblCaja.TabIndex = 6
        '
        'lblCajera
        '
        Me.lblCajera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCajera.Location = New System.Drawing.Point(456, 16)
        Me.lblCajera.Name = "lblCajera"
        Me.lblCajera.Size = New System.Drawing.Size(328, 20)
        Me.lblCajera.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(40, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Caja:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(400, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cajera:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.chk_domicilio)
        Me.GroupBox2.Controls.Add(Me.lblDomicilio)
        Me.GroupBox2.Controls.Add(Me.chk_estafeta)
        Me.GroupBox2.Controls.Add(Me.lblEstafeta)
        Me.GroupBox2.Controls.Add(Me.chk_devoluciones)
        Me.GroupBox2.Controls.Add(Me.chk_facturas)
        Me.GroupBox2.Controls.Add(Me.lbldevoluciones)
        Me.GroupBox2.Controls.Add(Me.lblFacturas)
        Me.GroupBox2.Controls.Add(Me.chk_recibos)
        Me.GroupBox2.Controls.Add(Me.lblrecibos)
        Me.GroupBox2.Controls.Add(Me.btnRefrescar)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(792, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 128)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Leyenda"
        '
        'chk_domicilio
        '
        Me.chk_domicilio.Location = New System.Drawing.Point(8, 96)
        Me.chk_domicilio.Name = "chk_domicilio"
        Me.chk_domicilio.Size = New System.Drawing.Size(72, 16)
        Me.chk_domicilio.TabIndex = 12
        Me.chk_domicilio.Text = "Domicilio"
        '
        'lblDomicilio
        '
        Me.lblDomicilio.BackColor = System.Drawing.Color.Thistle
        Me.lblDomicilio.Location = New System.Drawing.Point(8, 112)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(72, 8)
        Me.lblDomicilio.TabIndex = 11
        '
        'chk_estafeta
        '
        Me.chk_estafeta.Location = New System.Drawing.Point(104, 56)
        Me.chk_estafeta.Name = "chk_estafeta"
        Me.chk_estafeta.Size = New System.Drawing.Size(80, 16)
        Me.chk_estafeta.TabIndex = 10
        Me.chk_estafeta.Text = "Estafetas"
        '
        'lblEstafeta
        '
        Me.lblEstafeta.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblEstafeta.Location = New System.Drawing.Point(104, 72)
        Me.lblEstafeta.Name = "lblEstafeta"
        Me.lblEstafeta.Size = New System.Drawing.Size(80, 8)
        Me.lblEstafeta.TabIndex = 9
        '
        'chk_devoluciones
        '
        Me.chk_devoluciones.Location = New System.Drawing.Point(104, 16)
        Me.chk_devoluciones.Name = "chk_devoluciones"
        Me.chk_devoluciones.Size = New System.Drawing.Size(80, 16)
        Me.chk_devoluciones.TabIndex = 8
        Me.chk_devoluciones.Text = "Devoluciones"
        '
        'chk_facturas
        '
        Me.chk_facturas.Location = New System.Drawing.Point(8, 16)
        Me.chk_facturas.Name = "chk_facturas"
        Me.chk_facturas.Size = New System.Drawing.Size(72, 16)
        Me.chk_facturas.TabIndex = 7
        Me.chk_facturas.Text = "Facturas"
        '
        'lbldevoluciones
        '
        Me.lbldevoluciones.BackColor = System.Drawing.Color.NavajoWhite
        Me.lbldevoluciones.Location = New System.Drawing.Point(104, 32)
        Me.lbldevoluciones.Name = "lbldevoluciones"
        Me.lbldevoluciones.Size = New System.Drawing.Size(80, 8)
        Me.lbldevoluciones.TabIndex = 6
        '
        'lblFacturas
        '
        Me.lblFacturas.BackColor = System.Drawing.Color.Cyan
        Me.lblFacturas.Location = New System.Drawing.Point(8, 32)
        Me.lblFacturas.Name = "lblFacturas"
        Me.lblFacturas.Size = New System.Drawing.Size(72, 8)
        Me.lblFacturas.TabIndex = 4
        '
        'chk_recibos
        '
        Me.chk_recibos.Location = New System.Drawing.Point(8, 56)
        Me.chk_recibos.Name = "chk_recibos"
        Me.chk_recibos.Size = New System.Drawing.Size(72, 16)
        Me.chk_recibos.TabIndex = 8
        Me.chk_recibos.Text = "Recibos"
        '
        'lblrecibos
        '
        Me.lblrecibos.BackColor = System.Drawing.Color.LightPink
        Me.lblrecibos.Location = New System.Drawing.Point(8, 72)
        Me.lblrecibos.Name = "lblrecibos"
        Me.lblrecibos.Size = New System.Drawing.Size(72, 8)
        Me.lblrecibos.TabIndex = 6
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefrescar.Location = New System.Drawing.Point(104, 88)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(80, 32)
        Me.btnRefrescar.TabIndex = 16
        Me.btnRefrescar.Text = "Refrescar"
        '
        'btnCobrar
        '
        Me.btnCobrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCobrar.Location = New System.Drawing.Point(744, 464)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(80, 32)
        Me.btnCobrar.TabIndex = 16
        Me.btnCobrar.Text = "Cobrar"
        '
        'XGrd_Documentos
        '
        Me.XGrd_Documentos.AllowSorting = False
        Me.XGrd_Documentos.AutoAdjustLastColumn = True
        Me.XGrd_Documentos.AutoSearch = True
        Me.XGrd_Documentos.BackgroundColor = System.Drawing.Color.White
        Me.XGrd_Documentos.CaptionText = "Documentos por Cobrar"
        Me.XGrd_Documentos.CaptionVisible = False
        Me.XGrd_Documentos.ContextMenu = Me.ContextMenu1
        Me.XGrd_Documentos.DataMember = "ftfactm"
        Me.XGrd_Documentos.DataSource = Me.LibXConnector1
        Me.XGrd_Documentos.FullRowSelect = True
        Me.XGrd_Documentos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XGrd_Documentos.IsReadOnly = True
        Me.XGrd_Documentos.Location = New System.Drawing.Point(0, 0)
        Me.XGrd_Documentos.Name = "XGrd_Documentos"
        Me.XGrd_Documentos.ReadOnly = True
        Me.XGrd_Documentos.searchText = ""
        Me.XGrd_Documentos.showFooterBar = True
        Me.XGrd_Documentos.Size = New System.Drawing.Size(968, 264)
        Me.XGrd_Documentos.TabIndex = 15
        Me.XGrd_Documentos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.XGrd_Documentos.UseAutoFillLines = True
        Me.XGrd_Documentos.UseHandCursor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem5, Me.MenuItem3, Me.MenuItem4, Me.MenuItem6, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Cobrar"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Text = "Anular"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Visualizar"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 4
        Me.MenuItem6.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 5
        Me.MenuItem2.Text = "Refrescar"
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.XdataGridTableStyle1.DataGrid = Me.XGrd_Documentos
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColtype_code, Me.gColfact_number, Me.gColfact_date, Me.gColvend_name, Me.gColbus_name, Me.gColfact_inddomicilio, Me.gColnet_amount, Me.gcolSerial})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ftfactm"
        '
        'gColtype_code
        '
        Me.gColtype_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColtype_code.Format = ""
        Me.gColtype_code.FormatInfo = Nothing
        Me.gColtype_code.HeaderText = "Tipo"
        Me.gColtype_code.ImageList = Nothing
        Me.gColtype_code.isReadOnly = False
        Me.gColtype_code.MappingName = "type_code"
        Me.gColtype_code.MaxLength = 32767
        Me.gColtype_code.TabStop = True
        Me.gColtype_code.UseCustomCellFormat = True
        Me.gColtype_code.Width = 75
        '
        'gColfact_number
        '
        Me.gColfact_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColfact_number.Format = ""
        Me.gColfact_number.FormatInfo = Nothing
        Me.gColfact_number.HeaderText = "Número"
        Me.gColfact_number.ImageList = Nothing
        Me.gColfact_number.isReadOnly = False
        Me.gColfact_number.MappingName = "fact_number"
        Me.gColfact_number.MaxLength = 32767
        Me.gColfact_number.TabStop = True
        Me.gColfact_number.UseCustomCellFormat = True
        Me.gColfact_number.Width = 75
        '
        'gColfact_date
        '
        Me.gColfact_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColfact_date.Format = ""
        Me.gColfact_date.FormatInfo = Nothing
        Me.gColfact_date.HeaderText = "Fecha"
        Me.gColfact_date.ImageList = Nothing
        Me.gColfact_date.isReadOnly = False
        Me.gColfact_date.MappingName = "fact_date"
        Me.gColfact_date.MaxLength = 32767
        Me.gColfact_date.TabStop = True
        Me.gColfact_date.UseCustomCellFormat = True
        Me.gColfact_date.Width = 75
        '
        'gColvend_name
        '
        Me.gColvend_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColvend_name.Format = ""
        Me.gColvend_name.FormatInfo = Nothing
        Me.gColvend_name.HeaderText = "Vendedor"
        Me.gColvend_name.ImageList = Nothing
        Me.gColvend_name.isReadOnly = False
        Me.gColvend_name.MappingName = "vend_name"
        Me.gColvend_name.MaxLength = 32767
        Me.gColvend_name.TabStop = True
        Me.gColvend_name.UseCustomCellFormat = True
        Me.gColvend_name.Width = 300
        '
        'gColbus_name
        '
        Me.gColbus_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColbus_name.Format = ""
        Me.gColbus_name.FormatInfo = Nothing
        Me.gColbus_name.HeaderText = "Cliente"
        Me.gColbus_name.ImageList = Nothing
        Me.gColbus_name.isReadOnly = False
        Me.gColbus_name.MappingName = "bus_name"
        Me.gColbus_name.MaxLength = 32767
        Me.gColbus_name.TabStop = True
        Me.gColbus_name.UseCustomCellFormat = True
        Me.gColbus_name.Width = 250
        '
        'gColfact_inddomicilio
        '
        Me.gColfact_inddomicilio.FalseValue = CType(0, Short)
        Me.gColfact_inddomicilio.HeaderText = "Domicilio?"
        Me.gColfact_inddomicilio.MappingName = "fact_inddomicilio"
        Me.gColfact_inddomicilio.NullValue = 0
        Me.gColfact_inddomicilio.TrueValue = CType(1, Short)
        Me.gColfact_inddomicilio.UseCustomCellFormat = True
        Me.gColfact_inddomicilio.Width = 60
        '
        'gColnet_amount
        '
        Me.gColnet_amount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColnet_amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColnet_amount.Format = "###,##0.00"
        Me.gColnet_amount.FormatInfo = Nothing
        Me.gColnet_amount.HeaderText = "Montoi"
        Me.gColnet_amount.ImageList = Nothing
        Me.gColnet_amount.isReadOnly = False
        Me.gColnet_amount.MappingName = "net_amount"
        Me.gColnet_amount.MaxLength = 32767
        Me.gColnet_amount.TabStop = True
        Me.gColnet_amount.UseCustomCellFormat = True
        Me.gColnet_amount.Width = 90
        '
        'gcolSerial
        '
        Me.gcolSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolSerial.Format = ""
        Me.gcolSerial.FormatInfo = Nothing
        Me.gcolSerial.ImageList = Nothing
        Me.gcolSerial.isReadOnly = False
        Me.gcolSerial.MappingName = "ftserial_no"
        Me.gcolSerial.MaxLength = 32767
        Me.gcolSerial.TabStop = True
        Me.gcolSerial.UseCustomCellFormat = False
        Me.gcolSerial.Width = 0
        '
        'DataView1
        '
        Me.DataView1.AllowDelete = False
        Me.DataView1.AllowNew = False
        Me.DataView1.Table = Me.ftfactm
        '
        'btnView
        '
        Me.btnView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Location = New System.Drawing.Point(8, 464)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(80, 32)
        Me.btnView.TabIndex = 16
        Me.btnView.Text = "Visualizar"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(824, 464)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Anular"
        '
        'Timer1
        '
        Me.Timer1.Interval = 15000
        '
        'XGrd_Productos
        '
        Me.XGrd_Productos.AllowSorting = False
        Me.XGrd_Productos.AutoAdjustLastColumn = True
        Me.XGrd_Productos.AutoSearch = False
        Me.XGrd_Productos.BackgroundColor = System.Drawing.Color.White
        Me.XGrd_Productos.CaptionText = "Productos"
        Me.XGrd_Productos.DataMember = "ftfactd"
        Me.XGrd_Productos.DataSource = Me.LibXConnector1
        Me.XGrd_Productos.FullRowSelect = False
        Me.XGrd_Productos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XGrd_Productos.IsReadOnly = True
        Me.XGrd_Productos.Location = New System.Drawing.Point(8, 504)
        Me.XGrd_Productos.Name = "XGrd_Productos"
        Me.XGrd_Productos.ReadOnly = True
        Me.XGrd_Productos.searchText = ""
        Me.XGrd_Productos.showFooterBar = False
        Me.XGrd_Productos.Size = New System.Drawing.Size(976, 192)
        Me.XGrd_Productos.TabIndex = 17
        Me.XGrd_Productos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle2})
        Me.XGrd_Productos.UseAutoFillLines = True
        Me.XGrd_Productos.UseHandCursor = False
        '
        'XdataGridTableStyle2
        '
        Me.XdataGridTableStyle2.DataGrid = Me.XGrd_Productos
        Me.XdataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XEditTextBoxColumn8, Me.XEditTextBoxColumn9, Me.XEditTextBoxColumn10, Me.XEditTextBoxColumn11, Me.XEditTextBoxColumn12, Me.XEditTextBoxColumn13, Me.XEditTextBoxColumn14, Me.XEditTextBoxColumn15})
        Me.XdataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle2.MappingName = "ftfactd"
        '
        'XEditTextBoxColumn8
        '
        Me.XEditTextBoxColumn8.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn8.Format = ""
        Me.XEditTextBoxColumn8.FormatInfo = Nothing
        Me.XEditTextBoxColumn8.HeaderText = "Producto"
        Me.XEditTextBoxColumn8.ImageList = Nothing
        Me.XEditTextBoxColumn8.isReadOnly = False
        Me.XEditTextBoxColumn8.MappingName = "item_code"
        Me.XEditTextBoxColumn8.MaxLength = 32767
        Me.XEditTextBoxColumn8.TabStop = True
        Me.XEditTextBoxColumn8.UseCustomCellFormat = False
        Me.XEditTextBoxColumn8.Width = 90
        '
        'XEditTextBoxColumn9
        '
        Me.XEditTextBoxColumn9.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn9.Format = ""
        Me.XEditTextBoxColumn9.FormatInfo = Nothing
        Me.XEditTextBoxColumn9.HeaderText = "Descripción"
        Me.XEditTextBoxColumn9.ImageList = Nothing
        Me.XEditTextBoxColumn9.isReadOnly = False
        Me.XEditTextBoxColumn9.MappingName = "item_name"
        Me.XEditTextBoxColumn9.MaxLength = 32767
        Me.XEditTextBoxColumn9.TabStop = True
        Me.XEditTextBoxColumn9.UseCustomCellFormat = False
        Me.XEditTextBoxColumn9.Width = 325
        '
        'XEditTextBoxColumn10
        '
        Me.XEditTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn10.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn10.Format = "###,###"
        Me.XEditTextBoxColumn10.FormatInfo = Nothing
        Me.XEditTextBoxColumn10.HeaderText = "Cantidadi"
        Me.XEditTextBoxColumn10.ImageList = Nothing
        Me.XEditTextBoxColumn10.isReadOnly = False
        Me.XEditTextBoxColumn10.MappingName = "qty"
        Me.XEditTextBoxColumn10.MaxLength = 32767
        Me.XEditTextBoxColumn10.TabStop = True
        Me.XEditTextBoxColumn10.UseCustomCellFormat = False
        Me.XEditTextBoxColumn10.Width = 75
        '
        'XEditTextBoxColumn11
        '
        Me.XEditTextBoxColumn11.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn11.Format = ""
        Me.XEditTextBoxColumn11.FormatInfo = Nothing
        Me.XEditTextBoxColumn11.HeaderText = "Unidad"
        Me.XEditTextBoxColumn11.ImageList = Nothing
        Me.XEditTextBoxColumn11.isReadOnly = False
        Me.XEditTextBoxColumn11.MappingName = "unit_code"
        Me.XEditTextBoxColumn11.MaxLength = 32767
        Me.XEditTextBoxColumn11.TabStop = True
        Me.XEditTextBoxColumn11.UseCustomCellFormat = False
        Me.XEditTextBoxColumn11.Width = 90
        '
        'XEditTextBoxColumn12
        '
        Me.XEditTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn12.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn12.Format = "###,##0.00"
        Me.XEditTextBoxColumn12.FormatInfo = Nothing
        Me.XEditTextBoxColumn12.HeaderText = "Precioi"
        Me.XEditTextBoxColumn12.ImageList = Nothing
        Me.XEditTextBoxColumn12.isReadOnly = False
        Me.XEditTextBoxColumn12.MappingName = "price"
        Me.XEditTextBoxColumn12.MaxLength = 32767
        Me.XEditTextBoxColumn12.TabStop = True
        Me.XEditTextBoxColumn12.UseCustomCellFormat = False
        Me.XEditTextBoxColumn12.Width = 85
        '
        'XEditTextBoxColumn13
        '
        Me.XEditTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn13.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn13.Format = "###,##0.00"
        Me.XEditTextBoxColumn13.FormatInfo = Nothing
        Me.XEditTextBoxColumn13.HeaderText = "Descuentoi"
        Me.XEditTextBoxColumn13.ImageList = Nothing
        Me.XEditTextBoxColumn13.isReadOnly = False
        Me.XEditTextBoxColumn13.MappingName = "dscto"
        Me.XEditTextBoxColumn13.MaxLength = 32767
        Me.XEditTextBoxColumn13.TabStop = True
        Me.XEditTextBoxColumn13.UseCustomCellFormat = False
        Me.XEditTextBoxColumn13.Width = 85
        '
        'XEditTextBoxColumn14
        '
        Me.XEditTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn14.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn14.Format = "###,##0.00"
        Me.XEditTextBoxColumn14.FormatInfo = Nothing
        Me.XEditTextBoxColumn14.HeaderText = "ITBISi"
        Me.XEditTextBoxColumn14.ImageList = Nothing
        Me.XEditTextBoxColumn14.isReadOnly = False
        Me.XEditTextBoxColumn14.MappingName = "itbis"
        Me.XEditTextBoxColumn14.MaxLength = 32767
        Me.XEditTextBoxColumn14.TabStop = True
        Me.XEditTextBoxColumn14.UseCustomCellFormat = False
        Me.XEditTextBoxColumn14.Width = 85
        '
        'XEditTextBoxColumn15
        '
        Me.XEditTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn15.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn15.Format = "###,##0.00"
        Me.XEditTextBoxColumn15.FormatInfo = Nothing
        Me.XEditTextBoxColumn15.HeaderText = "Importei"
        Me.XEditTextBoxColumn15.ImageList = Nothing
        Me.XEditTextBoxColumn15.isReadOnly = False
        Me.XEditTextBoxColumn15.MappingName = "net_amount"
        Me.XEditTextBoxColumn15.MaxLength = 32767
        Me.XEditTextBoxColumn15.TabStop = True
        Me.XEditTextBoxColumn15.UseCustomCellFormat = False
        Me.XEditTextBoxColumn15.Width = 85
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPendiente)
        Me.TabControl1.Controls.Add(Me.tabDomicilio)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(8, 144)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(976, 312)
        Me.TabControl1.TabIndex = 18
        '
        'TabPendiente
        '
        Me.TabPendiente.Controls.Add(Me.XGrd_Documentos)
        Me.TabPendiente.ImageIndex = 0
        Me.TabPendiente.Location = New System.Drawing.Point(4, 23)
        Me.TabPendiente.Name = "TabPendiente"
        Me.TabPendiente.Size = New System.Drawing.Size(968, 285)
        Me.TabPendiente.TabIndex = 0
        Me.TabPendiente.Text = "Documentos Por Cobrar"
        '
        'tabDomicilio
        '
        Me.tabDomicilio.Controls.Add(Me.XGrd_Domicilios)
        Me.tabDomicilio.ImageIndex = 1
        Me.tabDomicilio.Location = New System.Drawing.Point(4, 23)
        Me.tabDomicilio.Name = "tabDomicilio"
        Me.tabDomicilio.Size = New System.Drawing.Size(968, 285)
        Me.tabDomicilio.TabIndex = 1
        Me.tabDomicilio.Text = "Domicilios pendientes"
        '
        'XGrd_Domicilios
        '
        Me.XGrd_Domicilios.AutoAdjustLastColumn = True
        Me.XGrd_Domicilios.AutoSearch = False
        Me.XGrd_Domicilios.BackgroundColor = System.Drawing.Color.White
        Me.XGrd_Domicilios.CaptionVisible = False
        Me.XGrd_Domicilios.DataMember = "ftdomim"
        Me.XGrd_Domicilios.DataSource = Me.LibXConnector1
        Me.XGrd_Domicilios.FullRowSelect = True
        Me.XGrd_Domicilios.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XGrd_Domicilios.IsReadOnly = True
        Me.XGrd_Domicilios.Location = New System.Drawing.Point(0, 0)
        Me.XGrd_Domicilios.Name = "XGrd_Domicilios"
        Me.XGrd_Domicilios.ReadOnly = True
        Me.XGrd_Domicilios.searchText = ""
        Me.XGrd_Domicilios.showFooterBar = True
        Me.XGrd_Domicilios.Size = New System.Drawing.Size(968, 264)
        Me.XGrd_Domicilios.TabIndex = 0
        Me.XGrd_Domicilios.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle3})
        Me.XGrd_Domicilios.UseAutoFillLines = True
        Me.XGrd_Domicilios.UseHandCursor = False
        '
        'XdataGridTableStyle3
        '
        Me.XdataGridTableStyle3.DataGrid = Me.XGrd_Domicilios
        Me.XdataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gDtype_code, Me.gdfact_number, Me.gdfact_date, Me.gdvend_name, Me.gdbus_name, Me.gdnet_amount, Me.gddomi_cambio, Me.gddomi_date})
        Me.XdataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle3.MappingName = "ftdomim"
        '
        'gDtype_code
        '
        Me.gDtype_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gDtype_code.Format = ""
        Me.gDtype_code.FormatInfo = Nothing
        Me.gDtype_code.HeaderText = "Tipo"
        Me.gDtype_code.ImageList = Nothing
        Me.gDtype_code.isReadOnly = False
        Me.gDtype_code.MappingName = "type_code"
        Me.gDtype_code.MaxLength = 32767
        Me.gDtype_code.TabStop = True
        Me.gDtype_code.UseCustomCellFormat = False
        Me.gDtype_code.Width = 75
        '
        'gdfact_number
        '
        Me.gdfact_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gdfact_number.Format = ""
        Me.gdfact_number.FormatInfo = Nothing
        Me.gdfact_number.HeaderText = "Número"
        Me.gdfact_number.ImageList = Nothing
        Me.gdfact_number.isReadOnly = False
        Me.gdfact_number.MappingName = "fact_number"
        Me.gdfact_number.MaxLength = 32767
        Me.gdfact_number.TabStop = True
        Me.gdfact_number.UseCustomCellFormat = False
        Me.gdfact_number.Width = 75
        '
        'gdfact_date
        '
        Me.gdfact_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gdfact_date.Format = ""
        Me.gdfact_date.FormatInfo = Nothing
        Me.gdfact_date.HeaderText = "Fecha"
        Me.gdfact_date.ImageList = Nothing
        Me.gdfact_date.isReadOnly = False
        Me.gdfact_date.MappingName = "fact_date"
        Me.gdfact_date.MaxLength = 32767
        Me.gdfact_date.TabStop = True
        Me.gdfact_date.UseCustomCellFormat = False
        Me.gdfact_date.Width = 75
        '
        'gdvend_name
        '
        Me.gdvend_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gdvend_name.Format = ""
        Me.gdvend_name.FormatInfo = Nothing
        Me.gdvend_name.HeaderText = "Mensajero"
        Me.gdvend_name.ImageList = Nothing
        Me.gdvend_name.isReadOnly = False
        Me.gdvend_name.MappingName = "vend_name"
        Me.gdvend_name.MaxLength = 32767
        Me.gdvend_name.TabStop = True
        Me.gdvend_name.UseCustomCellFormat = False
        Me.gdvend_name.Width = 200
        '
        'gdbus_name
        '
        Me.gdbus_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gdbus_name.Format = ""
        Me.gdbus_name.FormatInfo = Nothing
        Me.gdbus_name.HeaderText = "Cliente"
        Me.gdbus_name.ImageList = Nothing
        Me.gdbus_name.isReadOnly = False
        Me.gdbus_name.MappingName = "bus_name"
        Me.gdbus_name.MaxLength = 32767
        Me.gdbus_name.TabStop = True
        Me.gdbus_name.UseCustomCellFormat = False
        Me.gdbus_name.Width = 200
        '
        'gdnet_amount
        '
        Me.gdnet_amount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gdnet_amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gdnet_amount.Format = "###,##0.00"
        Me.gdnet_amount.FormatInfo = Nothing
        Me.gdnet_amount.HeaderText = "Montoi"
        Me.gdnet_amount.ImageList = Nothing
        Me.gdnet_amount.isReadOnly = False
        Me.gdnet_amount.MappingName = "net_amount"
        Me.gdnet_amount.MaxLength = 32767
        Me.gdnet_amount.TabStop = True
        Me.gdnet_amount.UseCustomCellFormat = False
        Me.gdnet_amount.Width = 95
        '
        'gddomi_cambio
        '
        Me.gddomi_cambio.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gddomi_cambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gddomi_cambio.Format = "###,##0.00"
        Me.gddomi_cambio.FormatInfo = Nothing
        Me.gddomi_cambio.HeaderText = "Cambioi"
        Me.gddomi_cambio.ImageList = Nothing
        Me.gddomi_cambio.isReadOnly = False
        Me.gddomi_cambio.MappingName = "domi_cambio"
        Me.gddomi_cambio.MaxLength = 32767
        Me.gddomi_cambio.TabStop = True
        Me.gddomi_cambio.UseCustomCellFormat = False
        Me.gddomi_cambio.Width = 95
        '
        'gddomi_date
        '
        Me.gddomi_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gddomi_date.Format = "dd/MM/yy hh:mm:ss"
        Me.gddomi_date.FormatInfo = Nothing
        Me.gddomi_date.HeaderText = "Fecha/Hora"
        Me.gddomi_date.ImageList = Nothing
        Me.gddomi_date.isReadOnly = False
        Me.gddomi_date.MappingName = "domi_date"
        Me.gddomi_date.MaxLength = 32767
        Me.gddomi_date.TabStop = True
        Me.gddomi_date.UseCustomCellFormat = False
        Me.gddomi_date.Width = 75
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.RoyalBlue
        '
        'btnPreparar
        '
        Me.btnPreparar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPreparar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPreparar.Location = New System.Drawing.Point(904, 464)
        Me.btnPreparar.Name = "btnPreparar"
        Me.btnPreparar.Size = New System.Drawing.Size(80, 32)
        Me.btnPreparar.TabIndex = 19
        Me.btnPreparar.Text = "Preparar"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(88, 464)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 32)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Facturar"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(168, 464)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 32)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Recibos Ingresos"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(248, 464)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 32)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Estafetas"
        '
        'p_cjfact01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(994, 728)
        Me.Controls.Add(Me.btnPreparar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.XGrd_Productos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCaja)
        Me.Controls.Add(Me.lblCajera)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "p_cjfact01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cobro de Facturas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.XGrd_Documentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XGrd_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPendiente.ResumeLayout(False)
        Me.tabDomicilio.ResumeLayout(False)
        CType(Me.XGrd_Domicilios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim WhDefault As Integer

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            Dim SQL As String
            Dim sWhere As String
            Dim cmd As OleDb.OleDbCommand
            Dim oTable As DataTable
            Dim oRow2 As DataRow

            sWhere = LibX.ConcatWherePart(sWhere, "ftfactm.whse_code = " & WhDefault.ToString)
            sWhere = LibX.ConcatWherePart(sWhere, "ftfactm.caja_code= " & oCaja.Code.ToString)
            sWhere = LibX.ConcatWherePart(sWhere, "ftfactm.caje_code= " & oCajera.Code.ToString)
            sWhere = LibX.ConcatWherePart(sWhere, "ftfactm.fact_status = " & Val(EstatusDocumentosEnum.Pendiente).ToString)

            If Trim(e.Where) <> "" Then
                sWhere = LibX.ConcatWherePart(sWhere, e.Where)
            End If

            '// Limpiar las tablas
            Me.DataSet1.Tables("ftfactm").Rows.Clear()
            Me.DataSet1.Tables("ftfactd").Rows.Clear()
            Me.DataSet1.Tables("ftdomim").Rows.Clear()

            '// Documentos pendiente por cobrar
            SQL = LibX.ConcatWherePart(Join(Me.LibXDbSourceTable1.Source, " "), sWhere)
            SQL = String.Concat(SQL, " ORDER BY ftfactm.ftserial_no")

            cmd = LibX.Data.Manager.Connection.CreateCommand
            cmd.CommandText = SQL

            Dim oAd As New OleDb.OleDbDataAdapter(cmd)
            oAd.Fill(Me.DataSet1.Tables("ftfactm"))

            '// Domicilio pendientes por preparar
            sWhere = ""
            sWhere = LibX.ConcatWherePart(sWhere, "ftfactm.whse_code = " & WhDefault.ToString)
            sWhere = LibX.ConcatWherePart(sWhere, "ftfactm.caja_code= " & oCaja.Code.ToString)
            sWhere = LibX.ConcatWherePart(sWhere, "ftfactm.caje_code= " & oCajera.Code.ToString)
            sWhere = LibX.ConcatWherePart(sWhere, "ftfactm.fact_status = " & Val(EstatusDocumentosEnum.DomicilioPendiente).ToString)

            If Trim(e.Where) <> "" Then
                sWhere = LibX.ConcatWherePart(sWhere, e.Where)
            End If

            SQL = LibX.ConcatWherePart(Join(Me.LibXDbSourceTable3.Source, " "), sWhere)
            SQL = String.Concat(SQL, " ORDER BY ftfactm.ftserial_no")

            cmd = LibX.Data.Manager.Connection.CreateCommand
            cmd.CommandText = SQL

            oAd = New OleDb.OleDbDataAdapter(cmd)
            oAd.Fill(Me.DataSet1.Tables("ftdomim"))

            '// cargar los  productos
            If ftfactm.Rows.Count > 0 Then
                LoadItems(ftfactm.Rows(0)!ftserial_no)
            Else
                If DataSet1.Tables("ftdomim").Rows.Count > 0 Then
                    LoadItems(DataSet1.Tables("ftdomim").Rows(0)!ftserial_no)
                    TabControl1.SelectedTab = tabDomicilio
                End If
            End If

        Catch ex As Exception
            Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LoadItems(ByVal Serial As Integer)
        Dim SelectStmt As String
        Dim cmd As OleDb.OleDbCommand
        Try
            SelectStmt = Join(Me.LibXDbSourceTable2.Source, " ")
            SelectStmt = LibX.ConcatWherePart(SelectStmt, " ftfactd.ftserial_no = " & Serial.ToString)

            cmd = LibX.Data.Manager.Connection.CreateCommand
            cmd.CommandText = SelectStmt

            Dim oAd As New OleDb.OleDbDataAdapter(cmd)

            Me.DataSet1.Tables("ftfactd").Rows.Clear()
            oAd.Fill(Me.DataSet1.Tables("ftfactd"))
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnCobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCobrar.Click
        Try
            Dim oValue As Object
            oValue = XGrd_Documentos.GetValue(Me.gcolSerial)

            If oValue Is Nothing Then
                Exit Sub
            End If

            Dim op As New LibxPrgParams
            op.IsFromOther = True
            op.initMode = LibxInitModes.Edit
            op.WhereToExecute = "ftfactm.ftserial_no = " & DataSet1.Tables("ftfactm").Rows(XGrd_Documentos.CurrentRowIndex)!ftserial_no.ToString
            App.CurrentPrgParams = op

            LibX.LibXRunner.Run("i_cjfact01", "CAJ", True)

            DataSet1.Tables("ftfactm").Rows.Remove(DataSet1.Tables("ftfactm").Rows(XGrd_Documentos.CurrentRowIndex))

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            If e.Action = LibxConnectionActions.Find Then
                DataSet1.Tables(0).Rows.Clear()
                Timer1.Enabled = False
            End If

            If e.AcceptedAction = LibxConnectionActions.Find Then
                Timer1.Enabled = True
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)

        End Try
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        btnCobrar_Click(sender, e)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefrescar.Click
        Try
            LibXConnector1.AcceptFind()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Button1_Click(sender, e)
    End Sub

    Private Sub p_cjfact01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.xcbo_caja_code.LoadDbItems(True)
            Me.xcbo_caje_code.LoadDbItems(True)
            Me.xcbo_type_code.LoadDbItems(True)
            Me.xcbo_vend_code.LoadDbItems(True)
            Me.xcbo_vend_mensaj.LoadDbItems(True)

            Me.XGrd_Documentos.getCurrentGridView.AllowDelete = False
            Me.XGrd_Documentos.getCurrentGridView.AllowEdit = False
            Me.XGrd_Documentos.getCurrentGridView.AllowNew = False

            Me.XGrd_Domicilios.getCurrentGridView.AllowDelete = False
            Me.XGrd_Domicilios.getCurrentGridView.AllowEdit = False
            Me.XGrd_Domicilios.getCurrentGridView.AllowNew = False

            Me.XGrd_Productos.getCurrentGridView.AllowDelete = False
            Me.XGrd_Productos.getCurrentGridView.AllowEdit = False
            Me.XGrd_Productos.getCurrentGridView.AllowNew = False

            '// Buscar la cajera segun el vendedor Logeado
            LibX.User.VendedorID = 1

            oCajera = New Cajera(LibX.User.VendedorID)
            oCajaAbierta = New CajaAbierta

            '// si es una cajera buscar la caja abierta para esta cajera
            If oCajera.esCajera = True Then
                If oCajaAbierta.GetAbiertaByCajeraID(oCajera.Code) = False Then
                    Dim oParam As New LibX.LibxPrgParams

                    oParam.AllowDelete = False
                    oParam.AllowEdit = False
                    oParam.AllowNew = False
                    oParam.AllowQuery = False

                    oParam.IsFromOther = True
                    oParam.initMode = LibxInitModes.Insert
                    oParam.Datos.Add("caje_code", oCajera.Code)
                    oParam.Datos.Add("init_date", DateTime.Now)
                    LibX.App.CurrentPrgParams = oParam

                    LibX.LibXRunner.Run("i_cjinit01", "CAJ", True)

                    If oCajaAbierta.GetAbiertaByCajeraID(oCajera.Code) = False Then
                        Throw New ApplicationException("Debe iniciar una caja para realizar las operaciones del dia!")
                    End If
                End If
            Else
                '// Si es un vendedor mostrar la lista de cajas abiertas 
                Throw New ApplicationException("Este  usuario no esta registrado como cajera, no puede utilizar este programa!")
            End If

            If CajaAbierta.CajeraCode <= 0 Then
                Me.Close()
                Exit Sub
            End If

            oCaja = New Caja(CajaAbierta.CajaCode)

            '// Mostrar los datos de la caja y la cajera
            Me.lblCaja.Text = oCaja.Name
            Me.lblCajera.Text = oCajera.Name
            Me.xdt_fact_date.Value = DBNull.Value
            Me.xcbo_caja_code.currValue = oCaja.Code
            Me.xcbo_caje_code.currValue = oCajera.Code

            '// buscar el almacen por defecto
            WhDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibXWhDefault").ToString)

            XGrd_Documentos.footerOperations.add("type_code", "count(type_code)", "1=1")
            XGrd_Domicilios.footerOperations.add("type_code", "count(type_code)", "1=1")

            LibXConnector1.AcceptFind()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub ApplyFilter()
        Dim Filter As String = "1=1"
        Try

            If chk_facturas.Checked = True Then
                Filter &= " and type_code = 'FPV'"
            End If

            If chk_devoluciones.Checked = True Then
                Filter &= " and type_code = 'DVF'"
            End If

            If chk_domicilio.Checked = True Then
                Filter &= " and fact_inddomicilio = 1"
            End If

            If chk_recibos.Checked = True Then
                Filter &= " and type_code = 'RCB'"
            End If

            XGrd_Documentos.getCurrentGridView.RowFilter = Filter
        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub

    Private Sub XEditTextBoxColumn1_SetCellFormat(ByVal sender As System.Object, ByVal e As LibX.XDataGridFormatCellEventArgs) Handles gColtype_code.SetCellFormat, _
                                                                                                                                        gColbus_name.SetCellFormat, _
                                                                                                                                        gColfact_date.SetCellFormat, _
                                                                                                                                        gColfact_inddomicilio.SetCellFormat, _
                                                                                                                                        gColnet_amount.SetCellFormat, _
                                                                                                                                        gColvend_name.SetCellFormat, _
                                                                                                                                        gColfact_number.SetCellFormat, _
                                                                                                                                        gColnet_amount.SetCellFormat

        Try
            If XGrd_Documentos.GetValue(e.RowNumber, 0) = "FPV" Then
                e.BackColor = lblFacturas.BackColor
            End If

            If XGrd_Documentos.GetValue(e.RowNumber, 0) = "DEV" Then
                e.BackColor = lbldevoluciones.BackColor
            End If

            If XGrd_Documentos.GetValue(e.RowNumber, 0) = "RCB" Then
                e.BackColor = lblrecibos.BackColor
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub chk_Contado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_facturas.CheckedChanged
        Try
            ApplyFilter()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub chk_Credito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_devoluciones.CheckedChanged
        Try
            ApplyFilter()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub chk_devoluc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_recibos.CheckedChanged
        Try
            ApplyFilter()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim xParam As LibX.LibxPrgParams
        Dim xParamAdm As SGT.Administracion.Entidades.Program.ParametrosVizualizar
        Dim xProgram As SGT.Administracion.Entidades.Program
        Try
            If DataSet1.Tables(0).Rows.Count <= 0 Then
                Exit Sub
            End If

            xParam = New LibX.LibxPrgParams
            xParamAdm = New SGT.Administracion.Entidades.Program.ParametrosVizualizar
            xProgram = New SGT.Administracion.Entidades.Program

            xParam.AllowDelete = False
            xParam.AllowEdit = False
            xParam.AllowNew = False
            xParam.AllowPrint = False
            xParam.AllowQuery = False
            xParam.initMode = LibxInitModes.Query
            xParam.WhereToExecute = "ftfactm.ftserial_no = " & XGrd_Documentos.GetValue(XGrd_Documentos.CurrentRowIndex, 6)
            xParam.Value = XGrd_Documentos.GetValue(XGrd_Documentos.CurrentRowIndex, 6)
            LibX.App.CurrentPrgParams = xParam

            Me.Cursor = Cursors.WaitCursor
            Timer1.Enabled = False

            xParamAdm.TipoDocumento = XGrd_Documentos.GetValue(XGrd_Documentos.CurrentRowIndex, 0)
            xParamAdm.Parametros = xParam

            xProgram.Visualizar(xParamAdm)

            '''Select Case XGrd_Documentos.GetValue(XGrd_Documentos.CurrentRowIndex, 0)
            '''    Case "FCT"
            '''        LibX.LibXRunner.Run("i_ftfact01", "FCT", True)
            '''    Case "FTS"
            '''        LibX.LibXRunner.Run("i_ftfact02", "FCT", True)
            '''    Case "DVF"
            '''        LibX.LibXRunner.Run("i_ftdevm01", "FCT", True)
            '''    Case "RCB"
            '''        LibX.LibXRunner.Run("i_ccpaym02", "CXC", True)
            '''    Case "RCE"
            '''        LibX.LibXRunner.Run("i_ccpaym01", "CXC", True)
            '''End Select

            Me.Cursor = Cursors.Default
            Timer1.Enabled = True

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        btnView_Click(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Anular()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Anular()
        Dim oPostDoc As SGT.Facturacion.Operaciones.PosteoDocumento
        Dim oPostParam As SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

        Try
            If MessageBox.Show("Seguro desea anular este documento", "Anular Documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If

            'If oPermission.isAutorization(SGT.Administracion.Entidades.Permission.TipoAutorizacionEnum.AnularDocumento) = False Then
            '    Throw New ApplicationException("No esta autorizado a anular documentos")
            'End If

            oPostDoc = New SGT.Facturacion.Operaciones.PosteoDocumento
            oPostParam = New SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

            Dim oRow As DataRow = DataSet1.Tables("ftfactm").Rows(XGrd_Documentos.CurrentRowIndex)

            oPostParam.SerialNumero = oRow!ftserial_no
            oPostParam.AplicarCXC = False
            oPostParam.ApliarComision = False
            oPostParam.AplicarInventario = True

            oPostDoc.Anular(oPostParam)

            DataSet1.Tables("ftfactm").Rows.Remove(oRow)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Try
            Anular()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Button1_Click(sender, e)

            'If DataSet1.Tables("ftdomim").Rows.Count > 0 Then
            '    tabDomicilio.Font = New Font(TabPendiente.Font, FontStyle.Bold)
            'Else
            '    tabDomicilio.Font = New Font(TabPendiente.Font, FontStyle.Regular)
            'End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub p_cjfact01_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Timer1.Enabled = False
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0
                Me.btnCobrar.Enabled = True
                Me.btnPreparar.Enabled = False
                Me.xcbo_vend_mensaj.Enabled = False
            Case 1
                Me.btnCobrar.Enabled = False
                Me.btnPreparar.Enabled = True
                Me.xcbo_vend_mensaj.Enabled = True
        End Select
    End Sub

    Private Sub XGrd_Documentos_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles XGrd_Documentos.CurrentRowChanged
        Try
            If e.row > -1 Then
                LoadItems(ftfactm.Rows(XGrd_Documentos.CurrentRowIndex)!ftserial_no)
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnPreparar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreparar.Click
        Dim XUpdate As LibX.Data.XUpdateStmt
        Try
            XUpdate = New LibX.Data.XUpdateStmt("ftfactm")
            XUpdate.FieldsSet("fact_status") = Val(EstatusDocumentosEnum.Pendiente)
            XUpdate.Fields("ftserial_no") = DataSet1.Tables("ftdomim").Rows(XGrd_Domicilios.CurrentRowIndex)!ftserial_no

            XUpdate.Execute()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xcbo_vend_code_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xcbo_vend_code.SelectedIndexChanged
        setfilter()
    End Sub

    Private Sub SetFilter()
        Dim strFilter As String = "1=1"

    End Sub

End Class
