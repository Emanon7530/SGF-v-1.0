Imports SGT.Caja
Imports LibX
Imports SGT.Caja.Entidades
Imports SGT.Inventario.Entidades
Imports System.Configuration.ConfigurationSettings
Public Class i_sfcobrm01
    Inherits System.Windows.Forms.Form
    Dim oDocumento As Documento
    Dim WhDefault As Integer
    Dim ScDefault As Integer
    Dim mContracto As String
    Dim mCodigo As Integer
    Dim mName As String
    Dim oCaja As Caja
    Dim oCajera As Cajera
    Dim oCajaAbierta As CajaAbierta
    Dim mContrato As String
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As LibX.XTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents xtx_estado As LibX.LibXCombo
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents xlk_caja_code As LibX.LibXLookup
    Friend WithEvents lblcaja_name As System.Windows.Forms.Label
    Friend WithEvents xlk_caje_code As LibX.LibXLookup
    Friend WithEvents lblcaje_name As System.Windows.Forms.Label
    Friend WithEvents xlk_tarf_code As LibX.LibXLookup
    Friend WithEvents xtxt_caje_code As LibX.XTextBox
    Friend WithEvents xtxt_caja_code As LibX.XTextBox
    Friend WithEvents xdt_cobr_date As LibX.LibxDateTimePicker
    Friend WithEvents ctxtMonEfe As LibX.XTextBox
    Friend WithEvents ctxtMonTarjeta As LibX.XTextBox
    Friend WithEvents ctxtMonChe As LibX.XTextBox
    Friend WithEvents xlk_type_code As LibX.LibXLookup
    Friend WithEvents lbltype_desc As System.Windows.Forms.Label
    Friend WithEvents xtxt_type_code As LibX.XTextBox
    Friend WithEvents xtl_dev As LibX.XTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblmae_nombre As System.Windows.Forms.Label
    Friend WithEvents lkl_estafe As LibX.LibXLookup
    Friend WithEvents xdx_ftfactm As LibX.LibXDbSourceTable
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
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents ftfactm As System.Data.DataTable
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn43 As System.Data.DataColumn
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
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents xtxMontoPagar As LibX.XTextBox
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents xtx_phone As LibX.XMaskEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblFtime As System.Windows.Forms.Label
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblFtime = New System.Windows.Forms.Label
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
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.DataColumn61 = New System.Data.DataColumn
        Me.DataColumn62 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataTable1 = New System.Data.DataTable
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
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.xtx_phone = New LibX.XMaskEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.xtxMontoPagar = New LibX.XTextBox
        Me.lkl_estafe = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.xdx_ftfactm = New LibX.LibXDbSourceTable
        Me.lblmae_nombre = New System.Windows.Forms.Label
        Me.xtl_dev = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.xdt_cobr_date = New LibX.LibxDateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ctxtMonEfe = New LibX.XTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.ctxtMonTarjeta = New LibX.XTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.ctxtMonChe = New LibX.XTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.xlk_type_code = New LibX.LibXLookup
        Me.lbltype_desc = New System.Windows.Forms.Label
        Me.xtxt_type_code = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.xlk_caje_code = New LibX.LibXLookup
        Me.lblcaje_name = New System.Windows.Forms.Label
        Me.xtxt_caje_code = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.xlk_caja_code = New LibX.LibXLookup
        Me.lblcaja_name = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.xtx_estado = New LibX.LibXCombo
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox2 = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.xtxt_caja_code = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.xlk_tarf_code = New LibX.LibXLookup
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFtime)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.xtx_phone)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xtxMontoPagar)
        Me.GroupBox1.Controls.Add(Me.lkl_estafe)
        Me.GroupBox1.Controls.Add(Me.lblmae_nombre)
        Me.GroupBox1.Controls.Add(Me.xtl_dev)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xdt_cobr_date)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.xlk_type_code)
        Me.GroupBox1.Controls.Add(Me.lbltype_desc)
        Me.GroupBox1.Controls.Add(Me.xtxt_type_code)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.xlk_caje_code)
        Me.GroupBox1.Controls.Add(Me.lblcaje_name)
        Me.GroupBox1.Controls.Add(Me.xtxt_caje_code)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.xlk_caja_code)
        Me.GroupBox1.Controls.Add(Me.lblcaja_name)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xtx_estado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xtxt_caja_code)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 224)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblFtime
        '
        Me.lblFtime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFtime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_time"))
        Me.lblFtime.Location = New System.Drawing.Point(208, 16)
        Me.lblFtime.Name = "lblFtime"
        Me.lblFtime.Size = New System.Drawing.Size(80, 23)
        Me.lblFtime.TabIndex = 34
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftfactm, Me.DataTable1})
        '
        'ftfactm
        '
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn36})
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
        Me.DataColumn19.MaxLength = 40
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
        Me.DataColumn28.ColumnName = "init_serial"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "fact_inddomicilio"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "address"
        Me.DataColumn30.MaxLength = 200
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "seg_amount"
        Me.DataColumn31.DataType = GetType(System.Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "prov_code"
        Me.DataColumn32.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "fact_impresa"
        Me.DataColumn33.DataType = GetType(System.Int32)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "fact_ncf"
        Me.DataColumn34.MaxLength = 40
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "cust_serial"
        Me.DataColumn35.DataType = GetType(System.Int32)
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "init_serial1"
        Me.DataColumn57.DataType = GetType(System.Int32)
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "efectivo"
        Me.DataColumn58.DataType = GetType(System.Decimal)
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "tarjeta"
        Me.DataColumn59.DataType = GetType(System.Decimal)
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "cheque"
        Me.DataColumn60.DataType = GetType(System.Decimal)
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "chk_code"
        Me.DataColumn61.DataType = GetType(System.Int32)
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "fact_time"
        Me.DataColumn62.MaxLength = 10
        '
        'DataColumn36
        '
        Me.DataColumn36.AllowDBNull = False
        Me.DataColumn36.ColumnName = "suc_code"
        Me.DataColumn36.DataType = GetType(System.Int32)
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56})
        Me.DataTable1.TableName = "cjtranrv"
        '
        'DataColumn43
        '
        Me.DataColumn43.AllowDBNull = False
        Me.DataColumn43.ColumnName = "ftserial_no"
        Me.DataColumn43.DataType = GetType(System.Int32)
        '
        'DataColumn44
        '
        Me.DataColumn44.AllowDBNull = False
        Me.DataColumn44.ColumnName = "init_serial"
        Me.DataColumn44.DataType = GetType(System.Int32)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "efectivo"
        Me.DataColumn45.DataType = GetType(System.Decimal)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "tarjeta"
        Me.DataColumn46.DataType = GetType(System.Decimal)
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "credito"
        Me.DataColumn47.DataType = GetType(System.Decimal)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "notacredito"
        Me.DataColumn48.DataType = GetType(System.Decimal)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "cheque"
        Me.DataColumn49.DataType = GetType(System.Decimal)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "seguro"
        Me.DataColumn50.DataType = GetType(System.Decimal)
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "cust_code"
        Me.DataColumn51.DataType = GetType(System.Int32)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "tarj_code"
        Me.DataColumn52.DataType = GetType(System.Int32)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "ncr_code"
        Me.DataColumn53.DataType = GetType(System.Int32)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "chk_code"
        Me.DataColumn54.DataType = GetType(System.Int32)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "tart_code"
        Me.DataColumn55.DataType = GetType(System.Int32)
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "vuelto"
        Me.DataColumn56.DataType = GetType(System.Decimal)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(168, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 16)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Hora:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(22, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 16)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Cliente:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.bus_name"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(73, 159)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(391, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 2
        Me.XTextBox2.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(22, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Detalle:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_nota"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(74, 181)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(584, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 3
        Me.XTextBox1.Text = ""
        '
        'xtx_phone
        '
        Me.xtx_phone.AcceptsReturn = True
        Me.xtx_phone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtx_phone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ftfactm, "phone"))
        Me.xtx_phone.EditInitialValue = Nothing
        Me.xtx_phone.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtx_phone.FieldDescription = ""
        Me.xtx_phone.FindInitialValue = Nothing
        Me.xtx_phone.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtx_phone.IgnoreRequiered = False
        Me.xtx_phone.Location = New System.Drawing.Point(74, 136)
        Me.xtx_phone.Masked = MaskedTextBox.Mask.None
        Me.xtx_phone.Name = "xtx_phone"
        Me.xtx_phone.NewInitialValue = Nothing
        Me.xtx_phone.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtx_phone.Requiered = False
        Me.xtx_phone.Size = New System.Drawing.Size(128, 20)
        Me.xtx_phone.StatusBarPanelDescripcion = Nothing
        Me.xtx_phone.TabIndex = 0
        Me.xtx_phone.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(282, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Monto:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxMontoPagar
        '
        Me.xtxMontoPagar.AcceptsReturn = True
        Me.xtxMontoPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxMontoPagar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_total"))
        Me.xtxMontoPagar.EditInitialValue = Nothing
        Me.xtxMontoPagar.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxMontoPagar.FieldDescription = ""
        Me.xtxMontoPagar.FindInitialValue = Nothing
        Me.xtxMontoPagar.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxMontoPagar.IgnoreRequiered = False
        Me.xtxMontoPagar.Location = New System.Drawing.Point(330, 136)
        Me.xtxMontoPagar.Name = "xtxMontoPagar"
        Me.xtxMontoPagar.NewInitialValue = Nothing
        Me.xtxMontoPagar.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxMontoPagar.Requiered = False
        Me.xtxMontoPagar.Size = New System.Drawing.Size(134, 20)
        Me.xtxMontoPagar.StatusBarPanelDescripcion = Nothing
        Me.xtxMontoPagar.TabIndex = 1
        Me.xtxMontoPagar.Text = ""
        Me.xtxMontoPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lkl_estafe
        '
        Me.lkl_estafe.AlternateFieldSearch = Nothing
        Me.lkl_estafe.BeginCheck = False
        Me.lkl_estafe.CheckText = Nothing
        Me.lkl_estafe.ComboMode = False
        Me.lkl_estafe.DataMember = Nothing
        Me.lkl_estafe.DataSource = Me.LibXConnector1
        Me.lkl_estafe.DestParameters = New String() {"dev_type=mae_code", "lblmae_nombre=mae_nombre"}
        Me.lkl_estafe.FilterField = "mae_nombre"
        Me.lkl_estafe.IgnoreFindInBrowseMode = False
        Me.lkl_estafe.isCanceled = False
        Me.lkl_estafe.Location = New System.Drawing.Point(450, 112)
        Me.lkl_estafe.LookCaption = "Tipos de Estafetas"
        Me.lkl_estafe.Name = "lkl_estafe"
        Me.lkl_estafe.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkl_estafe.ShowFilter = True
        Me.lkl_estafe.ShowMessageNotFound = True
        Me.lkl_estafe.ShowWarning = False
        Me.lkl_estafe.Size = New System.Drawing.Size(16, 20)
        Me.lkl_estafe.SizesColumns = Nothing
        Me.lkl_estafe.SizesColumnsTab = Nothing
        Me.lkl_estafe.SqlString = New String() {"select * from sfmaead order by orden"}
        Me.lkl_estafe.SQLTab = Nothing
        Me.lkl_estafe.SrcParameters = New String() {"dev_type=mae_code"}
        Me.lkl_estafe.TabIndex = 7
        Me.lkl_estafe.TableName = "sfmaead"
        Me.lkl_estafe.TabStop = False
        Me.lkl_estafe.UseCopyConnection = False
        Me.lkl_estafe.UseRowRetrieveEvents = False
        Me.lkl_estafe.UseTab = False
        Me.lkl_estafe.VisParameters = New String() {"Codigo=mae_code", "Estafeta=mae_nombre", "Formato=mae_format", "Cuenta=cust_code"}
        Me.lkl_estafe.WhereCondition = ""
        Me.lkl_estafe.WhereParameters = Nothing
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
        Me.LibXConnector1.ReportName = "r_pvestaf01.rpt"
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.xdx_ftfactm})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
        '
        'xdx_ftfactm
        '
        Me.xdx_ftfactm.AllowDelete = True
        Me.xdx_ftfactm.AllowEdit = True
        Me.xdx_ftfactm.AllowNew = True
        Me.xdx_ftfactm.AutoIncrementSerial = False
        Me.xdx_ftfactm.CustomDbUpdate = False
        Me.xdx_ftfactm.DeleteOrder = 0
        Me.xdx_ftfactm.FillOnQuery = True
        Me.xdx_ftfactm.FillOnRowChange = False
        Me.xdx_ftfactm.HeaderIsOnGrid = False
        Me.xdx_ftfactm.InnerJon = True
        Me.xdx_ftfactm.InsertOrder = 0
        Me.xdx_ftfactm.IsDetail = False
        Me.xdx_ftfactm.KeyFields = Nothing
        Me.xdx_ftfactm.LineColName = Nothing
        Me.xdx_ftfactm.MasterDetailRelation = Nothing
        Me.xdx_ftfactm.MasterTableName = Nothing
        Me.xdx_ftfactm.SerialColumnName = "ftserial_no"
        Me.xdx_ftfactm.Sort = Nothing
        Me.xdx_ftfactm.Source = New String() {"SELECT", "ftfactm.*,", "cjtranrv.efectivo,", "cjtranrv.tarjeta,", "cjtranrv.cheque,", "cjtranrv.chk_code", "from ftfactm ", "left outer join cjtranrv  ", "on  ftfactm.ftserial_no = cjtranrv.ftserial_no ", "where ftfactm.type_code ='EST'"}
        Me.xdx_ftfactm.TableName = "ftfactm"
        Me.xdx_ftfactm.UpdateOrder = 0
        Me.xdx_ftfactm.UseRowRetrieve = False
        '
        'lblmae_nombre
        '
        Me.lblmae_nombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblmae_nombre.Location = New System.Drawing.Point(130, 112)
        Me.lblmae_nombre.Name = "lblmae_nombre"
        Me.lblmae_nombre.Size = New System.Drawing.Size(320, 20)
        Me.lblmae_nombre.TabIndex = 25
        '
        'xtl_dev
        '
        Me.xtl_dev.AcceptsReturn = True
        Me.xtl_dev.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtl_dev.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.dev_type"))
        Me.xtl_dev.EditInitialValue = Nothing
        Me.xtl_dev.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtl_dev.FieldDescription = ""
        Me.xtl_dev.FindInitialValue = Nothing
        Me.xtl_dev.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtl_dev.IgnoreRequiered = False
        Me.xtl_dev.Location = New System.Drawing.Point(74, 112)
        Me.xtl_dev.Name = "xtl_dev"
        Me.xtl_dev.NewInitialValue = Nothing
        Me.xtl_dev.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtl_dev.Requiered = False
        Me.xtl_dev.Size = New System.Drawing.Size(48, 20)
        Me.xtl_dev.StatusBarPanelDescripcion = Nothing
        Me.xtl_dev.TabIndex = 3
        Me.xtl_dev.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(16, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Estafeta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xdt_cobr_date
        '
        Me.xdt_cobr_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_cobr_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.fact_date"))
        Me.xdt_cobr_date.EditInitialValue = Nothing
        Me.xdt_cobr_date.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdt_cobr_date.FieldDescription = ""
        Me.xdt_cobr_date.FindInitialValue = Nothing
        Me.xdt_cobr_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_cobr_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_cobr_date.IgnoreRequiered = False
        Me.xdt_cobr_date.Location = New System.Drawing.Point(74, 16)
        Me.xdt_cobr_date.Name = "xdt_cobr_date"
        Me.xdt_cobr_date.NewInitialValue = Nothing
        Me.xdt_cobr_date.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdt_cobr_date.Requiered = False
        Me.xdt_cobr_date.Size = New System.Drawing.Size(86, 20)
        Me.xdt_cobr_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_cobr_date.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ctxtMonEfe)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ctxtMonTarjeta)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.ctxtMonChe)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(480, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 128)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forma de Pago"
        '
        'ctxtMonEfe
        '
        Me.ctxtMonEfe.AcceptsReturn = True
        Me.ctxtMonEfe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.efectivo"))
        Me.ctxtMonEfe.EditInitialValue = Nothing
        Me.ctxtMonEfe.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.ctxtMonEfe.Enabled = False
        Me.ctxtMonEfe.FieldDescription = ""
        Me.ctxtMonEfe.FindInitialValue = Nothing
        Me.ctxtMonEfe.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.ctxtMonEfe.IgnoreRequiered = False
        Me.ctxtMonEfe.Location = New System.Drawing.Point(72, 24)
        Me.ctxtMonEfe.Name = "ctxtMonEfe"
        Me.ctxtMonEfe.NewInitialValue = Nothing
        Me.ctxtMonEfe.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.ctxtMonEfe.Requiered = False
        Me.ctxtMonEfe.Size = New System.Drawing.Size(112, 20)
        Me.ctxtMonEfe.StatusBarPanelDescripcion = Nothing
        Me.ctxtMonEfe.TabIndex = 0
        Me.ctxtMonEfe.Text = ""
        Me.ctxtMonEfe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(16, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Efectivo:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ctxtMonTarjeta
        '
        Me.ctxtMonTarjeta.AcceptsReturn = True
        Me.ctxtMonTarjeta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.tarjeta"))
        Me.ctxtMonTarjeta.EditInitialValue = Nothing
        Me.ctxtMonTarjeta.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.ctxtMonTarjeta.Enabled = False
        Me.ctxtMonTarjeta.FieldDescription = ""
        Me.ctxtMonTarjeta.FindInitialValue = Nothing
        Me.ctxtMonTarjeta.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.ctxtMonTarjeta.IgnoreRequiered = False
        Me.ctxtMonTarjeta.Location = New System.Drawing.Point(72, 48)
        Me.ctxtMonTarjeta.Name = "ctxtMonTarjeta"
        Me.ctxtMonTarjeta.NewInitialValue = Nothing
        Me.ctxtMonTarjeta.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.ctxtMonTarjeta.Requiered = False
        Me.ctxtMonTarjeta.Size = New System.Drawing.Size(112, 20)
        Me.ctxtMonTarjeta.StatusBarPanelDescripcion = Nothing
        Me.ctxtMonTarjeta.TabIndex = 1
        Me.ctxtMonTarjeta.Text = ""
        Me.ctxtMonTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(21, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Trajeta:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ctxtMonChe
        '
        Me.ctxtMonChe.AcceptsReturn = True
        Me.ctxtMonChe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.cheque"))
        Me.ctxtMonChe.EditInitialValue = Nothing
        Me.ctxtMonChe.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.ctxtMonChe.Enabled = False
        Me.ctxtMonChe.FieldDescription = ""
        Me.ctxtMonChe.FindInitialValue = Nothing
        Me.ctxtMonChe.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.ctxtMonChe.IgnoreRequiered = False
        Me.ctxtMonChe.Location = New System.Drawing.Point(72, 72)
        Me.ctxtMonChe.Name = "ctxtMonChe"
        Me.ctxtMonChe.NewInitialValue = Nothing
        Me.ctxtMonChe.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.ctxtMonChe.Requiered = False
        Me.ctxtMonChe.Size = New System.Drawing.Size(112, 20)
        Me.ctxtMonChe.StatusBarPanelDescripcion = Nothing
        Me.ctxtMonChe.TabIndex = 2
        Me.ctxtMonChe.Text = ""
        Me.ctxtMonChe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(17, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 16)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Cheque:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_type_code
        '
        Me.xlk_type_code.AlternateFieldSearch = Nothing
        Me.xlk_type_code.BeginCheck = False
        Me.xlk_type_code.CheckText = Nothing
        Me.xlk_type_code.ComboMode = False
        Me.xlk_type_code.DataMember = Nothing
        Me.xlk_type_code.DataSource = Me.LibXConnector1
        Me.xlk_type_code.DestParameters = New String() {"type_code=type_code", "lbltype_desc=type_name"}
        Me.xlk_type_code.FilterField = "type_name"
        Me.xlk_type_code.IgnoreFindInBrowseMode = False
        Me.xlk_type_code.isCanceled = False
        Me.xlk_type_code.Location = New System.Drawing.Point(450, 88)
        Me.xlk_type_code.LookCaption = "Tipo de Documentos"
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
        Me.xlk_type_code.TabIndex = 5
        Me.xlk_type_code.TableName = "ivtypem"
        Me.xlk_type_code.TabStop = False
        Me.xlk_type_code.UseCopyConnection = False
        Me.xlk_type_code.UseRowRetrieveEvents = False
        Me.xlk_type_code.UseTab = False
        Me.xlk_type_code.VisParameters = New String() {"Codigo=type_code", "Estafeta=type_name"}
        Me.xlk_type_code.WhereCondition = "type_code ='EST'"
        Me.xlk_type_code.WhereParameters = Nothing
        '
        'lbltype_desc
        '
        Me.lbltype_desc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltype_desc.Location = New System.Drawing.Point(130, 88)
        Me.lbltype_desc.Name = "lbltype_desc"
        Me.lbltype_desc.Size = New System.Drawing.Size(320, 20)
        Me.lbltype_desc.TabIndex = 22
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
        Me.xtxt_type_code.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_type_code.IgnoreRequiered = False
        Me.xtxt_type_code.Location = New System.Drawing.Point(74, 88)
        Me.xtxt_type_code.Name = "xtxt_type_code"
        Me.xtxt_type_code.NewInitialValue = Nothing
        Me.xtxt_type_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_type_code.Requiered = False
        Me.xtxt_type_code.Size = New System.Drawing.Size(48, 20)
        Me.xtxt_type_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_type_code.TabIndex = 2
        Me.xtxt_type_code.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(0, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Documento:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_caje_code
        '
        Me.xlk_caje_code.AlternateFieldSearch = Nothing
        Me.xlk_caje_code.BeginCheck = False
        Me.xlk_caje_code.CheckText = Nothing
        Me.xlk_caje_code.ComboMode = False
        Me.xlk_caje_code.DataMember = Nothing
        Me.xlk_caje_code.DataSource = Me.LibXConnector1
        Me.xlk_caje_code.DestParameters = New String() {"caje_code=vend_code", "lblcaje_name=vend_name"}
        Me.xlk_caje_code.FilterField = Nothing
        Me.xlk_caje_code.IgnoreFindInBrowseMode = False
        Me.xlk_caje_code.isCanceled = False
        Me.xlk_caje_code.Location = New System.Drawing.Point(450, 64)
        Me.xlk_caje_code.LookCaption = "Cajeras"
        Me.xlk_caje_code.Name = "xlk_caje_code"
        Me.xlk_caje_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_caje_code.ShowFilter = True
        Me.xlk_caje_code.ShowMessageNotFound = True
        Me.xlk_caje_code.ShowWarning = False
        Me.xlk_caje_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_caje_code.SizesColumns = Nothing
        Me.xlk_caje_code.SizesColumnsTab = Nothing
        Me.xlk_caje_code.SqlString = Nothing
        Me.xlk_caje_code.SQLTab = Nothing
        Me.xlk_caje_code.SrcParameters = New String() {"caje_code=vend_code"}
        Me.xlk_caje_code.TabIndex = 3
        Me.xlk_caje_code.TableName = "ftvendm"
        Me.xlk_caje_code.TabStop = False
        Me.xlk_caje_code.UseCopyConnection = False
        Me.xlk_caje_code.UseRowRetrieveEvents = False
        Me.xlk_caje_code.UseTab = False
        Me.xlk_caje_code.VisParameters = New String() {"Codigo=vend_code", "Cajera=vend_name"}
        Me.xlk_caje_code.WhereCondition = ""
        Me.xlk_caje_code.WhereParameters = Nothing
        '
        'lblcaje_name
        '
        Me.lblcaje_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcaje_name.Location = New System.Drawing.Point(130, 64)
        Me.lblcaje_name.Name = "lblcaje_name"
        Me.lblcaje_name.Size = New System.Drawing.Size(320, 20)
        Me.lblcaje_name.TabIndex = 18
        '
        'xtxt_caje_code
        '
        Me.xtxt_caje_code.AcceptsReturn = True
        Me.xtxt_caje_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_caje_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.caje_code"))
        Me.xtxt_caje_code.EditInitialValue = Nothing
        Me.xtxt_caje_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_caje_code.FieldDescription = ""
        Me.xtxt_caje_code.FindInitialValue = Nothing
        Me.xtxt_caje_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_caje_code.IgnoreRequiered = False
        Me.xtxt_caje_code.Location = New System.Drawing.Point(74, 64)
        Me.xtxt_caje_code.Name = "xtxt_caje_code"
        Me.xtxt_caje_code.NewInitialValue = Nothing
        Me.xtxt_caje_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_caje_code.Requiered = False
        Me.xtxt_caje_code.Size = New System.Drawing.Size(48, 20)
        Me.xtxt_caje_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_caje_code.TabIndex = 1
        Me.xtxt_caje_code.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(24, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Cajera:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_caja_code
        '
        Me.xlk_caja_code.AlternateFieldSearch = Nothing
        Me.xlk_caja_code.BeginCheck = False
        Me.xlk_caja_code.CheckText = Nothing
        Me.xlk_caja_code.ComboMode = False
        Me.xlk_caja_code.DataMember = Nothing
        Me.xlk_caja_code.DataSource = Me.LibXConnector1
        Me.xlk_caja_code.DestParameters = New String() {"caja_code=caja_code", "lblcaja_name=caja_name"}
        Me.xlk_caja_code.FilterField = Nothing
        Me.xlk_caja_code.IgnoreFindInBrowseMode = False
        Me.xlk_caja_code.isCanceled = False
        Me.xlk_caja_code.Location = New System.Drawing.Point(450, 40)
        Me.xlk_caja_code.LookCaption = "Cajas"
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
        Me.xlk_caja_code.TabIndex = 1
        Me.xlk_caja_code.TableName = "cjcajam"
        Me.xlk_caja_code.TabStop = False
        Me.xlk_caja_code.UseCopyConnection = False
        Me.xlk_caja_code.UseRowRetrieveEvents = False
        Me.xlk_caja_code.UseTab = False
        Me.xlk_caja_code.VisParameters = New String() {"Codigo=caja_code", "Cliente=caja_name"}
        Me.xlk_caja_code.WhereCondition = ""
        Me.xlk_caja_code.WhereParameters = Nothing
        '
        'lblcaja_name
        '
        Me.lblcaja_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcaja_name.Location = New System.Drawing.Point(130, 40)
        Me.lblcaja_name.Name = "lblcaja_name"
        Me.lblcaja_name.Size = New System.Drawing.Size(320, 20)
        Me.lblcaja_name.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(26, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(298, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Estado:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtx_estado
        '
        Me.xtx_estado.AllowDefaultSort = True
        Me.xtx_estado.bound = True
        Me.xtx_estado.currValue = Nothing
        Me.xtx_estado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.fact_status"))
        Me.xtx_estado.DefaultWhereString = Nothing
        Me.xtx_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xtx_estado.EditInitialValue = Nothing
        Me.xtx_estado.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtx_estado.FieldDescription = ""
        Me.xtx_estado.FindInitialValue = Nothing
        Me.xtx_estado.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtx_estado.IgnoreRequiered = False
        Me.xtx_estado.Items.AddRange(New Object() {"2-Cobrado", "1-Pendiente"})
        Me.xtx_estado.Location = New System.Drawing.Point(346, 16)
        Me.xtx_estado.LookupKeyDisplayFields = Nothing
        Me.xtx_estado.LookupKeyField = Nothing
        Me.xtx_estado.LookupTableName = Nothing
        Me.xtx_estado.Name = "xtx_estado"
        Me.xtx_estado.NewInitialValue = Nothing
        Me.xtx_estado.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtx_estado.Requiered = True
        Me.xtx_estado.Required = False
        Me.xtx_estado.Size = New System.Drawing.Size(120, 21)
        Me.xtx_estado.SqlString = Nothing
        Me.xtx_estado.StatusBarPanelDescripcion = Nothing
        Me.xtx_estado.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(14, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Contrato:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_number"))
        Me.TextBox2.EditInitialValue = Nothing
        Me.TextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox2.FieldDescription = ""
        Me.TextBox2.FindInitialValue = Nothing
        Me.TextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.IgnoreRequiered = False
        Me.TextBox2.Location = New System.Drawing.Point(552, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.NewInitialValue = Nothing
        Me.TextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox2.Requiered = False
        Me.TextBox2.Size = New System.Drawing.Size(112, 20)
        Me.TextBox2.StatusBarPanelDescripcion = Nothing
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(496, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Número:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_caja_code
        '
        Me.xtxt_caja_code.AcceptsReturn = True
        Me.xtxt_caja_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_caja_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.caja_code"))
        Me.xtxt_caja_code.EditInitialValue = Nothing
        Me.xtxt_caja_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_caja_code.FieldDescription = ""
        Me.xtxt_caja_code.FindInitialValue = Nothing
        Me.xtxt_caja_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_caja_code.IgnoreRequiered = False
        Me.xtxt_caja_code.Location = New System.Drawing.Point(74, 40)
        Me.xtxt_caja_code.Name = "xtxt_caja_code"
        Me.xtxt_caja_code.NewInitialValue = Nothing
        Me.xtxt_caja_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_caja_code.Requiered = False
        Me.xtxt_caja_code.Size = New System.Drawing.Size(48, 20)
        Me.xtxt_caja_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_caja_code.TabIndex = 0
        Me.xtxt_caja_code.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(34, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Caja:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_tarf_code
        '
        Me.xlk_tarf_code.AlternateFieldSearch = Nothing
        Me.xlk_tarf_code.BeginCheck = False
        Me.xlk_tarf_code.CheckText = Nothing
        Me.xlk_tarf_code.ComboMode = False
        Me.xlk_tarf_code.DataMember = Nothing
        Me.xlk_tarf_code.DataSource = Me.LibXConnector1
        Me.xlk_tarf_code.DestParameters = New String() {"tarf_code=tarf_code", "tarf_name=tarf_name", "cobr_amount=tarf_valor"}
        Me.xlk_tarf_code.FilterField = Nothing
        Me.xlk_tarf_code.IgnoreFindInBrowseMode = False
        Me.xlk_tarf_code.isCanceled = False
        Me.xlk_tarf_code.Location = New System.Drawing.Point(400, 288)
        Me.xlk_tarf_code.LookCaption = "Formato de Estafetas"
        Me.xlk_tarf_code.Name = "xlk_tarf_code"
        Me.xlk_tarf_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_tarf_code.ShowFilter = True
        Me.xlk_tarf_code.ShowMessageNotFound = True
        Me.xlk_tarf_code.ShowWarning = False
        Me.xlk_tarf_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_tarf_code.SizesColumns = Nothing
        Me.xlk_tarf_code.SizesColumnsTab = Nothing
        Me.xlk_tarf_code.SqlString = Nothing
        Me.xlk_tarf_code.SQLTab = Nothing
        Me.xlk_tarf_code.SrcParameters = New String() {"tarf_code=tarf_code"}
        Me.xlk_tarf_code.TabIndex = 3
        Me.xlk_tarf_code.TableName = "sftarfm"
        Me.xlk_tarf_code.TabStop = False
        Me.xlk_tarf_code.UseCopyConnection = False
        Me.xlk_tarf_code.UseRowRetrieveEvents = False
        Me.xlk_tarf_code.UseTab = False
        Me.xlk_tarf_code.VisParameters = New String() {"Codigo=tarf_code", "Nombre=tarf_name", "Valor=tarf_valor"}
        Me.xlk_tarf_code.WhereCondition = Nothing
        Me.xlk_tarf_code.WhereParameters = Nothing
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtl_dev
        Me.LibXNavigator1.FirstControlInFindMode = Nothing
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtl_dev
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(690, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'i_sfcobrm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 280)
        Me.Controls.Add(Me.xlk_tarf_code)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_sfcobrm01"
        Me.Text = "Cobro de Estafeta"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.AcceptedAction = LibxConnectionActions.Add _
            Or e.AcceptedAction = LibxConnectionActions.Edit Then
                CobrarDocumento(LibXConnector1.CurrentDataRow!ftserial_no)
                Me.Close()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            '// Mostrar el total
            If LibXConnector1.IsEditing = False And LibXConnector1.HasRecords = True Then
                If e.row!fact_status = 1 Then
                    LibXConnector1.AllowDelete = True
                    LibXConnector1.AllowEdit = True
                Else
                    LibXConnector1.AllowDelete = False
                    LibXConnector1.AllowEdit = False
                End If
                LibXNavigator1.UpdateState()
                ''CalcularNeto()
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub i_ftfactm01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '//SI LA CAJA NO A SIDO SELECCIONADA SELECCIONARLA
            oCajera = New Cajera(oCajaAbierta.CajeraCode)
            oCajaAbierta = New CajaAbierta
            
            If Not LibXConnector1.Parameters Is Nothing Then
                If CType(LibXConnector1.Parameters.Value, Integer) > 0 Then
                    oCajaAbierta.Serial = CType(LibXConnector1.Parameters.Value, Integer)
                    If oCajaAbierta.Load = False Then
                        Throw New ApplicationException("Las operaciones para este parametros no existen!")
                    End If
                Else
                    '// Si es un vendedor mostrar la lista de cajas abiertas 
                    LibX.LibXRunner.Run("i_cjopen", "CAJ", True)
                End If
            End If

            If CajaAbierta.CajeraCode <= 0 Then
                Me.Close()
                Exit Sub
            End If
            ''End If
            oCaja = New Caja(CajaAbierta.CajaCode)
            Me.xtxt_caja_code.Text = oCaja.Code
            Me.xtxt_caja_code.NewInitialValue = oCaja.Code

            Me.xtxt_caje_code.Text = oCajera.Code
            Me.xtxt_caje_code.NewInitialValue = oCajera.Code
            xtxt_caje_code.Text = oCajera.Code

            oDocumento = New Documento("EST")

            WhDefault = AppSettings.Get("LibxWhDefault")
            ScDefault = AppSettings.Get("LibxScDefault")

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub
    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        If (e.isEditing = True AndAlso e.isDataEditing = False) Or e.action = LibxConnectionActions.Cancel Then
            Me.xtx_phone.Text = ""
        End If
    End Sub
    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try

            Me.xtxt_caja_code.Text = CajaAbierta.CajaCode
            Me.xtxt_caje_code.Text = CajaAbierta.CajeraCode
            xdt_cobr_date.Value = CajaAbierta.Fecha
            lblFtime.Text = DateTime.Now.ToShortTimeString()
            Me.xtxt_type_code.Text = "EST"
            Me.xtx_estado.currValue = 1
            'Me.xtxContrato.Text = ""
            Me.xlk_caja_code.ExecuteFind()
            Me.xlk_caje_code.ExecuteFind()
            Me.xlk_type_code.ExecuteFind()
            Me.lkl_estafe.ExecuteLookup()
            Me.xtx_phone.Focus()

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.Row!fact_total = 0 Or LibX.IsNull(e.UpdatingArgs.Row!fact_total) Then
                Throw New ApplicationException("Debe especificar el valor a pagar")
            End If
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                e.UpdatingArgs.Row!type_code = "EST"
                'e.UpdatingArgs.Row!fact_number = oDocumento.GenerateNumber("EST", WhDefault)
                If xdt_cobr_date.Value = "" Then
                    xdt_cobr_date.EditInitialValue = CajaAbierta.Fecha
                End If
                Me.xtx_estado.currValue = 2
                e.UpdatingArgs.Row!fact_cond = 1
                e.UpdatingArgs.Row!whse_code = LibX.User.WhDefault
                e.UpdatingArgs.Row!vend_code = CajaAbierta.CajeraCode
                e.UpdatingArgs.Row!cust_code = mCodigo
                e.UpdatingArgs.Row!descto = 0
                e.UpdatingArgs.Row!itbis = 0
                e.UpdatingArgs.Row!fact_inddomicilio = 0
                e.UpdatingArgs.Row!phone = mContrato
                e.UpdatingArgs.Row!suc_code = LibX.User.Sucursal
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub lkl_estafe_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lkl_estafe.BeforeExecuteQuery
        Try
            'e.aditionalWhere = "mae_code = '" & Me.xtl_dev.Text.Trim & "'"

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Function CobrarDocumento(ByVal pserial_no As Integer) As Boolean
        Dim oUpdate As LibX.Data.XUpdateStmt
        Try
            Dim op As New LibxPrgParams
            '// Cambiar la caja y la cajera a la caja actual
            oUpdate = New LibX.Data.XUpdateStmt("ftfactm")

            oUpdate.FieldsSet("fact_status") = 1
            oUpdate.FieldsSet("caja_code") = CajaAbierta.CajaCode
            oUpdate.FieldsSet("caje_code") = CajaAbierta.CajeraCode
            oUpdate.FieldsSet("fact_date") = CajaAbierta.Fecha
            oUpdate.Fields("ftserial_no") = pserial_no

            oUpdate.Execute()
            oUpdate.Dispose()

            '// buscar el documento
            LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & pserial_no.ToString.Trim)

            op.IsFromOther = True
            op.initMode = LibxInitModes.Edit
            op.WhereToExecute = "ftfactm.ftserial_no = " & pserial_no.ToString.Trim
            App.CurrentPrgParams = op

            LibX.LibXRunner.Run("i_cjfact01", "CAJ", True)

            '// refrescar el documento
            LibXConnector1.CurrentDataRow.Row.RejectChanges()
            LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & pserial_no.ToString.Trim)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub lkl_estafe_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkl_estafe.AfterSetValues

        Try
            If e.dataFound = False Then
                Exit Sub
            End If
            Me.xtx_phone.Focus()
            If LibXConnector1.IsDataEditing = True Then
                mCodigo = e.row!cust_code
                If xtl_dev.Text = "COD" Then
                    Me.xtx_phone.Masked = MaskedTextBox.Mask.PhoneWithArea
                End If
                If xtl_dev.Text = "TRM" Then
                    Me.xtx_phone.Masked = MaskedTextBox.Mask.PhoneWithArea
                End If
                If xtl_dev.Text = "CDE" Then
                    Me.xtx_phone.Masked = MaskedTextBox.Mask.Digit
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub xtxContrato_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtx_phone.Validating
        Try
            If LibXConnector1.IsDataEditing = True Then
                mContrato = Me.xtx_phone.Text
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub lkl_estafe_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lkl_estafe.Validating
        Try

            If LibXConnector1.IsDataEditing = True Then
                If Me.xtxt_type_code.Text.Trim = "" Then
                    Me.lkl_estafe.ExecuteLookup()
                End If
            End If
            Me.xtx_phone.Focus()
        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Add(ex, True)
        End Try

    End Sub
End Class
