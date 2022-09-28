Imports SGT.PuntodeVenta.Entidades
Imports SGT.Caja.Entidades
Imports SGT.CXC.Entidades

Public Class i_ptvfact04
    Inherits System.Windows.Forms.Form

    Dim WithEvents Label1 As System.Windows.Forms.Label
    Dim WithEvents Label4 As System.Windows.Forms.Label
    Dim WithEvents Label5 As System.Windows.Forms.Label
    Dim WithEvents Label7 As System.Windows.Forms.Label
    Dim WithEvents xcbo_Tipo As LibX.LibXCombo
    Dim WithEvents xtxt_address As LibX.XTextBox
    Dim WithEvents xtxt_telefono1 As LibX.XTextBox
    Dim WithEvents lbl_ciudad As System.Windows.Forms.Label
    Dim WithEvents xtxt_codigo As LibX.XMaskEdit
    Dim WithEvents Label13 As Label
    Dim WithEvents Label12 As Label
    Dim WithEvents lbl_Descuento As Label
    Dim WithEvents lbl_Cobertura As Label
    Dim WithEvents xlk_plan As LibX.LibXLookup
    Dim WithEvents xlk_compania As LibX.LibXLookup
    Dim WithEvents lbl_Compania As Label
    Dim WithEvents xtxt_plan As LibX.XTextBox
    Dim WithEvents xtxt_Compania As LibX.XTextBox
    Dim WithEvents Label10 As Label
    Dim WithEvents Label11 As Label
    Dim WithEvents lbl_Plan As Label
    Dim WithEvents Label9 As System.Windows.Forms.Label
    Dim WithEvents xlk_codigo As LibX.LibXLookup
    Dim WithEvents Label6 As System.Windows.Forms.Label
    Dim WithEvents XTextBox1 As LibX.XTextBox
    Dim WithEvents lbl_sector As System.Windows.Forms.Label
    Dim WithEvents Label8 As System.Windows.Forms.Label
    Dim WithEvents lbl_TipoDocumento As System.Windows.Forms.Label
    Dim WithEvents xlk_sector As LibX.LibXLookup
    Dim WithEvents xtxt_adicional2 As LibX.XTextBox
    Dim WithEvents xlk_ciudad As LibX.LibXLookup
    Dim WithEvents xtxt_sector As LibX.XTextBox
    Dim WithEvents xtxt_ciudad As LibX.XTextBox
    Dim WithEvents xtxt_nombre As LibX.XTextBox
    Dim WithEvents Label2 As System.Windows.Forms.Label
    Dim WithEvents Label3 As System.Windows.Forms.Label

    Dim WithEvents xlk_vend_code As LibX.LibXLookup
    Dim WithEvents lbl_mensajero As System.Windows.Forms.Label
    Dim WithEvents lbl_ult_domicilio As System.Windows.Forms.Label

    Dim mConfig As SGT.Inventario.Common.Configuration
    Dim mCaja As Caja
    Dim vCliente As SGT.CXC.Entidades.Cliente
    Dim oParamExcede As SGT.CXC.Entidades.Cliente.ParametrosExcedeLimite

    Dim mCliente As ClienteDomicilio
    Dim mExisteTarjeta As Boolean
    Dim mExistecliente As Boolean
    Dim mFacturarCredito As Boolean = False
    Dim mTotalFacturado As Decimal
    Dim mTotalDescuento As Decimal
    Dim mNuevo As Boolean = False

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
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents LBL_Title As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet

    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents xtxt_domi_cambio As LibX.XMaskEdit
    Friend WithEvents xcbo_pago As LibX.LibXCombo
    Friend WithEvents xtxt_tarj_numero As LibX.XTextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents xtxt_tarj_Vence As LibX.XMaskEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents xlk_tarjta As LibX.LibXLookup
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents xcbo_tarj_tipo As LibX.LibXCombo
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
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblRecargo As System.Windows.Forms.Label
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents xtxt_vendedor As LibX.XTextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents xtxt_rnc As LibX.XMaskEdit
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents xtxbal As System.Windows.Forms.Label
    Friend WithEvents xlxbal As System.Windows.Forms.Label
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
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
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.Label27 = New System.Windows.Forms.Label
        Me.xlxbal = New System.Windows.Forms.Label
        Me.xtxbal = New System.Windows.Forms.Label
        Me.xtxt_rnc = New LibX.XMaskEdit
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.lblRecargo = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.xcbo_tarj_tipo = New LibX.LibXCombo
        Me.xlk_tarjta = New LibX.LibXLookup
        Me.lblMessage = New System.Windows.Forms.Label
        Me.xcbo_pago = New LibX.LibXCombo
        Me.xtxt_codigo = New LibX.XMaskEdit
        Me.xlk_sector = New LibX.LibXLookup
        Me.xlk_ciudad = New LibX.LibXLookup
        Me.xlk_codigo = New LibX.LibXLookup
        Me.lbl_ciudad = New System.Windows.Forms.Label
        Me.xtxt_sector = New LibX.XTextBox
        Me.xtxt_ciudad = New LibX.XTextBox
        Me.xtxt_nombre = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbl_ult_domicilio = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.xlk_vend_code = New LibX.LibXLookup
        Me.lbl_mensajero = New System.Windows.Forms.Label
        Me.xtxt_address = New LibX.XTextBox
        Me.lbl_sector = New System.Windows.Forms.Label
        Me.xtxt_vendedor = New LibX.XTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.xtxt_domi_cambio = New LibX.XMaskEdit
        Me.xtxt_tarj_numero = New LibX.XTextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.xtxt_tarj_Vence = New LibX.XMaskEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.LBL_Title = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.xtxt_telefono1 = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no", "cust_code", "tarj_code"}, False), New System.Data.UniqueConstraint("Constraint2", New String() {"ftserial_no", "cust_code"}, False)})
        Me.DataTable1.TableName = "cccustm"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "ftserial_no"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "domi_date"
        Me.DataColumn2.DataType = GetType(System.DateTime)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "domi_cambio"
        Me.DataColumn3.DataType = GetType(System.Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "vend_mensaj"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "domi_estatus"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "domi_pago"
        Me.DataColumn6.MaxLength = 3
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.AutoIncrement = True
        Me.DataColumn7.ColumnName = "cust_code"
        Me.DataColumn7.DataType = GetType(System.Int32)
        Me.DataColumn7.ReadOnly = True
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "vend_code"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "cust_name"
        Me.DataColumn9.MaxLength = 100
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "csttype_code"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "term_code"
        Me.DataColumn11.MaxLength = 5
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "contact_name"
        Me.DataColumn12.MaxLength = 40
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "credit_limit"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "balance"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "cust_status"
        Me.DataColumn15.DataType = GetType(System.Int32)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "stop_abono"
        Me.DataColumn16.DataType = GetType(System.Int16)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "stop_cheque"
        Me.DataColumn17.DataType = GetType(System.Int16)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "stop_venct"
        Me.DataColumn18.DataType = GetType(System.Int16)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "day_benef"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "last_pay_date"
        Me.DataColumn20.DataType = GetType(System.DateTime)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "last_sell_date"
        Me.DataColumn21.DataType = GetType(System.DateTime)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "cust_default"
        Me.DataColumn22.DataType = GetType(System.Int16)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "cust_image"
        Me.DataColumn23.MaxLength = 5
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "rnc_id"
        Me.DataColumn24.MaxLength = 15
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "cust_pricemajor"
        Me.DataColumn25.DataType = GetType(System.Int16)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "cust_note"
        Me.DataColumn26.MaxLength = 2147483647
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "cust_phone"
        Me.DataColumn27.MaxLength = 15
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "cust_address"
        Me.DataColumn28.MaxLength = 200
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "cust_credito"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "cust_costo"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "city_code"
        Me.DataColumn31.MaxLength = 3
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "sector_code"
        Me.DataColumn32.MaxLength = 3
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "cust_create"
        Me.DataColumn33.DataType = GetType(System.DateTime)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "cust_cellphone"
        Me.DataColumn34.MaxLength = 15
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "cust_email"
        Me.DataColumn35.MaxLength = 40
        '
        'DataColumn36
        '
        Me.DataColumn36.AutoIncrement = True
        Me.DataColumn36.ColumnName = "tarj_code"
        Me.DataColumn36.DataType = GetType(System.Int32)
        Me.DataColumn36.ReadOnly = True
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "tarj_tipo"
        Me.DataColumn37.DataType = GetType(System.Int32)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "tarj_numero"
        Me.DataColumn38.MaxLength = 30
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "tarj_vence"
        Me.DataColumn39.MaxLength = 20
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "last_delivery"
        Me.DataColumn40.DataType = GetType(System.DateTime)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "chequera"
        Me.DataColumn41.DataType = GetType(System.Int32)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "acct_no"
        Me.DataColumn42.MaxLength = 10
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "representa"
        Me.DataColumn43.MaxLength = 40
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "ncf_type"
        Me.DataColumn44.DataType = GetType(System.Int32)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "web_transf"
        Me.DataColumn45.DataType = GetType(System.Int32)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "otro_dsct"
        Me.DataColumn46.DataType = GetType(System.Int32)
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "cust_apellidos"
        Me.DataColumn47.MaxLength = 40
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "contact_apellidos"
        Me.DataColumn48.MaxLength = 40
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
        Me.LibXDbSourceTable2.InnerJon = True
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = False
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = "cust_code"
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select " & Microsoft.VisualBasic.ChrW(9) & "ftdomim.ftserial_no,", "" & Microsoft.VisualBasic.ChrW(9) & "ftdomim.domi_date,", "" & Microsoft.VisualBasic.ChrW(9) & "ftdomim.domi_cambio,", "" & Microsoft.VisualBasic.ChrW(9) & "ftdomim.vend_mensaj,", "" & Microsoft.VisualBasic.ChrW(9) & "ftdomim.domi_estatus,", "" & Microsoft.VisualBasic.ChrW(9) & "ftdomim.domi_pago,", "" & Microsoft.VisualBasic.ChrW(9) & "cccustm.*,", "" & Microsoft.VisualBasic.ChrW(9) & "pvtarjeta.tarj_code,", "" & Microsoft.VisualBasic.ChrW(9) & "pvtarjeta.tarj_tipo,", "" & Microsoft.VisualBasic.ChrW(9) & "pvtarjeta.tarj_numero,", "" & Microsoft.VisualBasic.ChrW(9) & "pvtarjeta.tarj_vence", " from cccustm left outer join ftdomim", "on ftdomim.cust_code =cccustm.cust_code", "left outer join pvtarjeta", "on pvtarjeta.cust_code = cccustm.cust_code", "or pvtarjeta.tarj_code = ftdomim.tarj_code"}
        Me.LibXDbSourceTable2.TableName = "cccustm"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.xlxbal)
        Me.GroupBox1.Controls.Add(Me.xtxbal)
        Me.GroupBox1.Controls.Add(Me.xtxt_rnc)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.lblRecargo)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.xcbo_tarj_tipo)
        Me.GroupBox1.Controls.Add(Me.xlk_tarjta)
        Me.GroupBox1.Controls.Add(Me.lblMessage)
        Me.GroupBox1.Controls.Add(Me.xcbo_pago)
        Me.GroupBox1.Controls.Add(Me.xtxt_codigo)
        Me.GroupBox1.Controls.Add(Me.xlk_sector)
        Me.GroupBox1.Controls.Add(Me.xlk_ciudad)
        Me.GroupBox1.Controls.Add(Me.xlk_codigo)
        Me.GroupBox1.Controls.Add(Me.lbl_ciudad)
        Me.GroupBox1.Controls.Add(Me.xtxt_sector)
        Me.GroupBox1.Controls.Add(Me.xtxt_ciudad)
        Me.GroupBox1.Controls.Add(Me.xtxt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbl_ult_domicilio)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.xlk_vend_code)
        Me.GroupBox1.Controls.Add(Me.lbl_mensajero)
        Me.GroupBox1.Controls.Add(Me.xtxt_address)
        Me.GroupBox1.Controls.Add(Me.lbl_sector)
        Me.GroupBox1.Controls.Add(Me.xtxt_vendedor)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.xtxt_domi_cambio)
        Me.GroupBox1.Controls.Add(Me.xtxt_tarj_numero)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.xtxt_tarj_Vence)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 336)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.cust_apellidos"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(344, 56)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(200, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 25
        Me.XTextBox2.Text = ""
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label28.Location = New System.Drawing.Point(288, 56)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(53, 16)
        Me.Label28.TabIndex = 24
        Me.Label28.Text = "Apellidos:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cccustm.ncf_type"))
        Me.LibXCombo1.DefaultWhereString = "ncf_type in(1,15)"
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Enabled = False
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Location = New System.Drawing.Point(104, 288)
        Me.LibXCombo1.LookupKeyDisplayFields = "definicion"
        Me.LibXCombo1.LookupKeyField = "ncf_type"
        Me.LibXCombo1.LookupTableName = "ftncfm"
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(208, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 23
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label27.Location = New System.Drawing.Point(34, 288)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 16)
        Me.Label27.TabIndex = 22
        Me.Label27.Text = "Tipo Ncf.:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlxbal
        '
        Me.xlxbal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xlxbal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.xlxbal.ForeColor = System.Drawing.Color.Red
        Me.xlxbal.Location = New System.Drawing.Point(280, 216)
        Me.xlxbal.Name = "xlxbal"
        Me.xlxbal.Size = New System.Drawing.Size(88, 20)
        Me.xlxbal.TabIndex = 21
        Me.xlxbal.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.xlxbal.Visible = False
        '
        'xtxbal
        '
        Me.xtxbal.AutoSize = True
        Me.xtxbal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.xtxbal.ForeColor = System.Drawing.Color.Red
        Me.xtxbal.Location = New System.Drawing.Point(229, 216)
        Me.xtxbal.Name = "xtxbal"
        Me.xtxbal.Size = New System.Drawing.Size(48, 16)
        Me.xtxbal.TabIndex = 20
        Me.xtxbal.Text = "Disponi.:"
        Me.xtxbal.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.xtxbal.Visible = False
        '
        'xtxt_rnc
        '
        Me.xtxt_rnc.AcceptsReturn = True
        Me.xtxt_rnc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.rnc_id"))
        Me.xtxt_rnc.EditInitialValue = Nothing
        Me.xtxt_rnc.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_rnc.FieldDescription = ""
        Me.xtxt_rnc.FindInitialValue = Nothing
        Me.xtxt_rnc.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_rnc.IgnoreRequiered = False
        Me.xtxt_rnc.Location = New System.Drawing.Point(424, 32)
        Me.xtxt_rnc.Masked = MaskedTextBox.Mask.None
        Me.xtxt_rnc.Name = "xtxt_rnc"
        Me.xtxt_rnc.NewInitialValue = Nothing
        Me.xtxt_rnc.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_rnc.Requiered = False
        Me.xtxt_rnc.Size = New System.Drawing.Size(120, 20)
        Me.xtxt_rnc.StatusBarPanelDescripcion = Nothing
        Me.xtxt_rnc.TabIndex = 1
        Me.xtxt_rnc.Text = ""
        Me.xtxt_rnc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label26.Location = New System.Drawing.Point(344, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(67, 16)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "Cedula/Rnc:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label23.Location = New System.Drawing.Point(344, 240)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 16)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "Vencimiento:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRecargo
        '
        Me.lblRecargo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecargo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblRecargo.Location = New System.Drawing.Point(424, 264)
        Me.lblRecargo.Name = "lblRecargo"
        Me.lblRecargo.Size = New System.Drawing.Size(120, 20)
        Me.lblRecargo.TabIndex = 17
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label24.Location = New System.Drawing.Point(364, 264)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 16)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Recargo:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_tarj_tipo
        '
        Me.xcbo_tarj_tipo.AllowDefaultSort = True
        Me.xcbo_tarj_tipo.bound = True
        Me.xcbo_tarj_tipo.currValue = Nothing
        Me.xcbo_tarj_tipo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cccustm.tarj_tipo"))
        Me.xcbo_tarj_tipo.DefaultWhereString = Nothing
        Me.xcbo_tarj_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_tarj_tipo.EditInitialValue = Nothing
        Me.xcbo_tarj_tipo.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_tarj_tipo.FieldDescription = ""
        Me.xcbo_tarj_tipo.FindInitialValue = Nothing
        Me.xcbo_tarj_tipo.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_tarj_tipo.IgnoreRequiered = False
        Me.xcbo_tarj_tipo.Location = New System.Drawing.Point(104, 264)
        Me.xcbo_tarj_tipo.LookupKeyDisplayFields = "Nombre"
        Me.xcbo_tarj_tipo.LookupKeyField = "tart_code"
        Me.xcbo_tarj_tipo.LookupTableName = "pvtipotarm"
        Me.xcbo_tarj_tipo.Name = "xcbo_tarj_tipo"
        Me.xcbo_tarj_tipo.NewInitialValue = Nothing
        Me.xcbo_tarj_tipo.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_tarj_tipo.Requiered = False
        Me.xcbo_tarj_tipo.Required = False
        Me.xcbo_tarj_tipo.Size = New System.Drawing.Size(208, 21)
        Me.xcbo_tarj_tipo.SqlString = Nothing
        Me.xcbo_tarj_tipo.StatusBarPanelDescripcion = Nothing
        Me.xcbo_tarj_tipo.TabIndex = 9
        '
        'xlk_tarjta
        '
        Me.xlk_tarjta.AlternateFieldSearch = Nothing
        Me.xlk_tarjta.BeginCheck = False
        Me.xlk_tarjta.CheckText = Nothing
        Me.xlk_tarjta.ComboMode = False
        Me.xlk_tarjta.DataMember = Nothing
        Me.xlk_tarjta.DataSource = Me.LibXConnector1
        Me.xlk_tarjta.DestParameters = New String() {"tarj_code=tarj_code", "tarj_numero=tarj_numero", "tarj_vence=tarj_vence", "tarj_tipo=tarj_tipo"}
        Me.xlk_tarjta.FilterField = Nothing
        Me.xlk_tarjta.IgnoreFindInBrowseMode = False
        Me.xlk_tarjta.isCanceled = False
        Me.xlk_tarjta.Location = New System.Drawing.Point(296, 240)
        Me.xlk_tarjta.LookCaption = "Tarjetas de este Cliente"
        Me.xlk_tarjta.Name = "xlk_tarjta"
        Me.xlk_tarjta.PopupSize = New System.Drawing.Size(400, 300)
        Me.xlk_tarjta.ShowFilter = True
        Me.xlk_tarjta.ShowMessageNotFound = False
        Me.xlk_tarjta.ShowWarning = False
        Me.xlk_tarjta.Size = New System.Drawing.Size(16, 20)
        Me.xlk_tarjta.SizesColumns = New String() {"Nombre=150"}
        Me.xlk_tarjta.SizesColumnsTab = Nothing
        Me.xlk_tarjta.SqlString = New String() {"select pvtipotarm.Nombre,pvtarjeta.tarj_numero,pvtarjeta.tarj_vence,tarj_code,tar" & _
        "j_tipo", "from pvtarjeta inner join pvtipotarm", "on pvtarjeta.tarj_tipo = pvtipotarm.tart_code"}
        Me.xlk_tarjta.SQLTab = Nothing
        Me.xlk_tarjta.SrcParameters = New String() {"tarj_numero=tarj_numero"}
        Me.xlk_tarjta.TabIndex = 14
        Me.xlk_tarjta.TableName = "pvtarjeta"
        Me.xlk_tarjta.TabStop = False
        Me.xlk_tarjta.UseCopyConnection = False
        Me.xlk_tarjta.UseRowRetrieveEvents = False
        Me.xlk_tarjta.UseTab = False
        Me.xlk_tarjta.Visible = False
        Me.xlk_tarjta.VisParameters = New String() {"Tipo Tarjeta=Nombre", "Numero=tarj_numero", "Vence=tarj_vence"}
        Me.xlk_tarjta.WhereCondition = Nothing
        Me.xlk_tarjta.WhereParameters = Nothing
        '
        'lblMessage
        '
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblMessage.Location = New System.Drawing.Point(3, 317)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(562, 16)
        Me.lblMessage.TabIndex = 13
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'xcbo_pago
        '
        Me.xcbo_pago.AllowDefaultSort = True
        Me.xcbo_pago.bound = True
        Me.xcbo_pago.currValue = Nothing
        Me.xcbo_pago.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cccustm.domi_pago"))
        Me.xcbo_pago.DefaultWhereString = Nothing
        Me.xcbo_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_pago.EditInitialValue = ""
        Me.xcbo_pago.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_pago.FieldDescription = ""
        Me.xcbo_pago.FindInitialValue = ""
        Me.xcbo_pago.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_pago.IgnoreRequiered = False
        Me.xcbo_pago.Items.AddRange(New Object() {"EFE-EFECTIVO", "TAR-TARJETA", "CXC-CREDITO"})
        Me.xcbo_pago.Location = New System.Drawing.Point(104, 216)
        Me.xcbo_pago.LookupKeyDisplayFields = Nothing
        Me.xcbo_pago.LookupKeyField = ""
        Me.xcbo_pago.LookupTableName = Nothing
        Me.xcbo_pago.Name = "xcbo_pago"
        Me.xcbo_pago.NewInitialValue = " EFE"
        Me.xcbo_pago.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_pago.Requiered = True
        Me.xcbo_pago.Required = False
        Me.xcbo_pago.Size = New System.Drawing.Size(120, 21)
        Me.xcbo_pago.SqlString = Nothing
        Me.xcbo_pago.StatusBarPanelDescripcion = Nothing
        Me.xcbo_pago.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.xcbo_pago, "Indicar la forma de pago")
        '
        'xtxt_codigo
        '
        Me.xtxt_codigo.AcceptsReturn = True
        Me.xtxt_codigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.cust_phone"))
        Me.xtxt_codigo.EditInitialValue = Nothing
        Me.xtxt_codigo.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_codigo.FieldDescription = ""
        Me.xtxt_codigo.FindInitialValue = Nothing
        Me.xtxt_codigo.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_codigo.IgnoreRequiered = False
        Me.xtxt_codigo.Location = New System.Drawing.Point(104, 24)
        Me.xtxt_codigo.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.xtxt_codigo.Name = "xtxt_codigo"
        Me.xtxt_codigo.NewInitialValue = Nothing
        Me.xtxt_codigo.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_codigo.Requiered = False
        Me.xtxt_codigo.Size = New System.Drawing.Size(136, 29)
        Me.xtxt_codigo.StatusBarPanelDescripcion = Nothing
        Me.xtxt_codigo.TabIndex = 0
        Me.xtxt_codigo.Text = ""
        '
        'xlk_sector
        '
        Me.xlk_sector.AlternateFieldSearch = Nothing
        Me.xlk_sector.BeginCheck = False
        Me.xlk_sector.CheckText = Nothing
        Me.xlk_sector.ComboMode = False
        Me.xlk_sector.DataMember = "cccustm"
        Me.xlk_sector.DataSource = Me.LibXConnector1
        Me.xlk_sector.DestParameters = New String() {"sector_code=sector_code", "lbl_sector=sector_name"}
        Me.xlk_sector.FilterField = "sector_name"
        Me.xlk_sector.IgnoreFindInBrowseMode = False
        Me.xlk_sector.isCanceled = False
        Me.xlk_sector.Location = New System.Drawing.Point(528, 168)
        Me.xlk_sector.LookCaption = "Sectores"
        Me.xlk_sector.Name = "xlk_sector"
        Me.xlk_sector.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_sector.ShowFilter = True
        Me.xlk_sector.ShowMessageNotFound = True
        Me.xlk_sector.ShowWarning = False
        Me.xlk_sector.Size = New System.Drawing.Size(16, 20)
        Me.xlk_sector.SizesColumns = Nothing
        Me.xlk_sector.SizesColumnsTab = Nothing
        Me.xlk_sector.SqlString = Nothing
        Me.xlk_sector.SQLTab = Nothing
        Me.xlk_sector.SrcParameters = New String() {"sector_code=sector_code"}
        Me.xlk_sector.TabIndex = 11
        Me.xlk_sector.TableName = "ccsectorm"
        Me.xlk_sector.TabStop = False
        Me.xlk_sector.UseCopyConnection = False
        Me.xlk_sector.UseRowRetrieveEvents = False
        Me.xlk_sector.UseTab = False
        Me.xlk_sector.VisParameters = New String() {"Codigo=sector_code", "Sector=sector_name"}
        Me.xlk_sector.WhereCondition = Nothing
        Me.xlk_sector.WhereParameters = Nothing
        '
        'xlk_ciudad
        '
        Me.xlk_ciudad.AlternateFieldSearch = Nothing
        Me.xlk_ciudad.BeginCheck = False
        Me.xlk_ciudad.CheckText = Nothing
        Me.xlk_ciudad.ComboMode = False
        Me.xlk_ciudad.DataMember = "cccustm"
        Me.xlk_ciudad.DataSource = Me.LibXConnector1
        Me.xlk_ciudad.DestParameters = New String() {"city_code=city_code", "lbl_Ciudad=city_name"}
        Me.xlk_ciudad.FilterField = "city_name"
        Me.xlk_ciudad.IgnoreFindInBrowseMode = False
        Me.xlk_ciudad.isCanceled = False
        Me.xlk_ciudad.Location = New System.Drawing.Point(528, 144)
        Me.xlk_ciudad.LookCaption = "Ciudades"
        Me.xlk_ciudad.Name = "xlk_ciudad"
        Me.xlk_ciudad.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_ciudad.ShowFilter = True
        Me.xlk_ciudad.ShowMessageNotFound = False
        Me.xlk_ciudad.ShowWarning = False
        Me.xlk_ciudad.Size = New System.Drawing.Size(16, 20)
        Me.xlk_ciudad.SizesColumns = Nothing
        Me.xlk_ciudad.SizesColumnsTab = Nothing
        Me.xlk_ciudad.SqlString = Nothing
        Me.xlk_ciudad.SQLTab = Nothing
        Me.xlk_ciudad.SrcParameters = New String() {"city_code=city_code"}
        Me.xlk_ciudad.TabIndex = 10
        Me.xlk_ciudad.TableName = "cccity"
        Me.xlk_ciudad.TabStop = False
        Me.xlk_ciudad.UseCopyConnection = False
        Me.xlk_ciudad.UseRowRetrieveEvents = False
        Me.xlk_ciudad.UseTab = False
        Me.xlk_ciudad.VisParameters = New String() {"Codigo=city_code", "Ciudad=city_name"}
        Me.xlk_ciudad.WhereCondition = Nothing
        Me.xlk_ciudad.WhereParameters = Nothing
        '
        'xlk_codigo
        '
        Me.xlk_codigo.AlternateFieldSearch = Nothing
        Me.xlk_codigo.BeginCheck = False
        Me.xlk_codigo.CheckText = Nothing
        Me.xlk_codigo.ComboMode = False
        Me.xlk_codigo.DataMember = "cccustm"
        Me.xlk_codigo.DataSource = Me.LibXConnector1
        Me.xlk_codigo.DestParameters = New String() {"cust_code=cust_code", "cust_phone=cust_phone", "cust_name=cust_name", "cust_address=cust_address", "city_code=city_code", "sector_code=sector_code", "last_delivery=last_delivery", "rnc_id=rnc_id", "ncf_type=ncf_type", "cust_apellidos=cust_apellidos"}
        Me.xlk_codigo.FilterField = "cust_phone"
        Me.xlk_codigo.IgnoreFindInBrowseMode = True
        Me.xlk_codigo.isCanceled = False
        Me.xlk_codigo.Location = New System.Drawing.Point(240, 24)
        Me.xlk_codigo.LookCaption = "Clientes a Domicilio"
        Me.xlk_codigo.Name = "xlk_codigo"
        Me.xlk_codigo.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_codigo.ShowFilter = False
        Me.xlk_codigo.ShowMessageNotFound = False
        Me.xlk_codigo.ShowWarning = False
        Me.xlk_codigo.Size = New System.Drawing.Size(16, 20)
        Me.xlk_codigo.SizesColumns = New String() {"cust_phone=125", "cust_name=350"}
        Me.xlk_codigo.SizesColumnsTab = Nothing
        Me.xlk_codigo.SqlString = Nothing
        Me.xlk_codigo.SQLTab = Nothing
        Me.xlk_codigo.SrcParameters = New String() {"cust_phone=cust_phone"}
        Me.xlk_codigo.TabIndex = 9
        Me.xlk_codigo.TableName = "cccustm"
        Me.xlk_codigo.TabStop = False
        Me.xlk_codigo.UseCopyConnection = False
        Me.xlk_codigo.UseRowRetrieveEvents = False
        Me.xlk_codigo.UseTab = False
        Me.xlk_codigo.VisParameters = New String() {"Telefono=cust_phone", "Rnc=rnc_id", "Nombre=cust_name", "Apellidos=cust_apellidos", "Direccion=cust_address"}
        Me.xlk_codigo.WhereCondition = ""
        Me.xlk_codigo.WhereParameters = Nothing
        '
        'lbl_ciudad
        '
        Me.lbl_ciudad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ciudad.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_ciudad.Location = New System.Drawing.Point(168, 144)
        Me.lbl_ciudad.Name = "lbl_ciudad"
        Me.lbl_ciudad.Size = New System.Drawing.Size(360, 20)
        Me.lbl_ciudad.TabIndex = 8
        '
        'xtxt_sector
        '
        Me.xtxt_sector.AcceptsReturn = True
        Me.xtxt_sector.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.sector_code"))
        Me.xtxt_sector.EditInitialValue = Nothing
        Me.xtxt_sector.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_sector.FieldDescription = ""
        Me.xtxt_sector.FindInitialValue = Nothing
        Me.xtxt_sector.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_sector.IgnoreRequiered = False
        Me.xtxt_sector.Location = New System.Drawing.Point(104, 168)
        Me.xtxt_sector.Name = "xtxt_sector"
        Me.xtxt_sector.NewInitialValue = Nothing
        Me.xtxt_sector.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_sector.Requiered = False
        Me.xtxt_sector.Size = New System.Drawing.Size(64, 20)
        Me.xtxt_sector.StatusBarPanelDescripcion = Nothing
        Me.xtxt_sector.TabIndex = 5
        Me.xtxt_sector.Text = ""
        '
        'xtxt_ciudad
        '
        Me.xtxt_ciudad.AcceptsReturn = True
        Me.xtxt_ciudad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.city_code"))
        Me.xtxt_ciudad.EditInitialValue = Nothing
        Me.xtxt_ciudad.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_ciudad.FieldDescription = ""
        Me.xtxt_ciudad.FindInitialValue = Nothing
        Me.xtxt_ciudad.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_ciudad.IgnoreRequiered = False
        Me.xtxt_ciudad.Location = New System.Drawing.Point(104, 144)
        Me.xtxt_ciudad.Name = "xtxt_ciudad"
        Me.xtxt_ciudad.NewInitialValue = Nothing
        Me.xtxt_ciudad.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_ciudad.Requiered = False
        Me.xtxt_ciudad.Size = New System.Drawing.Size(64, 20)
        Me.xtxt_ciudad.StatusBarPanelDescripcion = Nothing
        Me.xtxt_ciudad.TabIndex = 4
        Me.xtxt_ciudad.Text = ""
        '
        'xtxt_nombre
        '
        Me.xtxt_nombre.AcceptsReturn = True
        Me.xtxt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.cust_name"))
        Me.xtxt_nombre.EditInitialValue = Nothing
        Me.xtxt_nombre.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_nombre.FieldDescription = ""
        Me.xtxt_nombre.FindInitialValue = Nothing
        Me.xtxt_nombre.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_nombre.IgnoreRequiered = False
        Me.xtxt_nombre.Location = New System.Drawing.Point(104, 56)
        Me.xtxt_nombre.Name = "xtxt_nombre"
        Me.xtxt_nombre.NewInitialValue = Nothing
        Me.xtxt_nombre.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_nombre.Requiered = True
        Me.xtxt_nombre.Size = New System.Drawing.Size(176, 20)
        Me.xtxt_nombre.StatusBarPanelDescripcion = Nothing
        Me.xtxt_nombre.TabIndex = 2
        Me.xtxt_nombre.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(43, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(36, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Dirección:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(48, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ciudad:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_ult_domicilio
        '
        Me.lbl_ult_domicilio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ult_domicilio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.last_delivery"))
        Me.lbl_ult_domicilio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_ult_domicilio.Location = New System.Drawing.Point(424, 288)
        Me.lbl_ult_domicilio.Name = "lbl_ult_domicilio"
        Me.lbl_ult_domicilio.Size = New System.Drawing.Size(120, 20)
        Me.lbl_ult_domicilio.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(51, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Sector:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(40, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Telefono:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_vend_code
        '
        Me.xlk_vend_code.AlternateFieldSearch = Nothing
        Me.xlk_vend_code.BeginCheck = False
        Me.xlk_vend_code.CheckText = Nothing
        Me.xlk_vend_code.ComboMode = False
        Me.xlk_vend_code.DataMember = "cccustm"
        Me.xlk_vend_code.DataSource = Me.LibXConnector1
        Me.xlk_vend_code.DestParameters = New String() {"vend_mensaj=vend_code", "lbl_mensajero=vend_name"}
        Me.xlk_vend_code.Enabled = False
        Me.xlk_vend_code.FilterField = "vend_name"
        Me.xlk_vend_code.IgnoreFindInBrowseMode = False
        Me.xlk_vend_code.isCanceled = False
        Me.xlk_vend_code.Location = New System.Drawing.Point(528, 192)
        Me.xlk_vend_code.LookCaption = "Mensajeros"
        Me.xlk_vend_code.Name = "xlk_vend_code"
        Me.xlk_vend_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_vend_code.ShowFilter = True
        Me.xlk_vend_code.ShowMessageNotFound = True
        Me.xlk_vend_code.ShowWarning = False
        Me.xlk_vend_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_vend_code.SizesColumns = Nothing
        Me.xlk_vend_code.SizesColumnsTab = Nothing
        Me.xlk_vend_code.SqlString = Nothing
        Me.xlk_vend_code.SQLTab = Nothing
        Me.xlk_vend_code.SrcParameters = New String() {"vend_mensaj=vend_code"}
        Me.xlk_vend_code.TabIndex = 11
        Me.xlk_vend_code.TableName = "ftvendm"
        Me.xlk_vend_code.TabStop = False
        Me.xlk_vend_code.UseCopyConnection = False
        Me.xlk_vend_code.UseRowRetrieveEvents = False
        Me.xlk_vend_code.UseTab = False
        Me.xlk_vend_code.VisParameters = New String() {"Codigo=vend_code", "Mensajero=vend_name"}
        Me.xlk_vend_code.WhereCondition = "vend_cargo=3"
        Me.xlk_vend_code.WhereParameters = Nothing
        '
        'lbl_mensajero
        '
        Me.lbl_mensajero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_mensajero.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_mensajero.Location = New System.Drawing.Point(168, 192)
        Me.lbl_mensajero.Name = "lbl_mensajero"
        Me.lbl_mensajero.Size = New System.Drawing.Size(360, 20)
        Me.lbl_mensajero.TabIndex = 8
        '
        'xtxt_address
        '
        Me.xtxt_address.AcceptsReturn = True
        Me.xtxt_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.cust_address"))
        Me.xtxt_address.EditInitialValue = Nothing
        Me.xtxt_address.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_address.FieldDescription = ""
        Me.xtxt_address.FindInitialValue = Nothing
        Me.xtxt_address.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_address.IgnoreRequiered = False
        Me.xtxt_address.Location = New System.Drawing.Point(104, 80)
        Me.xtxt_address.Multiline = True
        Me.xtxt_address.Name = "xtxt_address"
        Me.xtxt_address.NewInitialValue = Nothing
        Me.xtxt_address.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_address.Requiered = True
        Me.xtxt_address.Size = New System.Drawing.Size(440, 56)
        Me.xtxt_address.StatusBarPanelDescripcion = Nothing
        Me.xtxt_address.TabIndex = 3
        Me.xtxt_address.Text = ""
        '
        'lbl_sector
        '
        Me.lbl_sector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_sector.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_sector.Location = New System.Drawing.Point(168, 168)
        Me.lbl_sector.Name = "lbl_sector"
        Me.lbl_sector.Size = New System.Drawing.Size(360, 20)
        Me.lbl_sector.TabIndex = 8
        '
        'xtxt_vendedor
        '
        Me.xtxt_vendedor.AcceptsReturn = True
        Me.xtxt_vendedor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.vend_mensaj"))
        Me.xtxt_vendedor.EditInitialValue = Nothing
        Me.xtxt_vendedor.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_vendedor.Enabled = False
        Me.xtxt_vendedor.FieldDescription = ""
        Me.xtxt_vendedor.FindInitialValue = Nothing
        Me.xtxt_vendedor.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_vendedor.IgnoreRequiered = False
        Me.xtxt_vendedor.Location = New System.Drawing.Point(104, 192)
        Me.xtxt_vendedor.Name = "xtxt_vendedor"
        Me.xtxt_vendedor.NewInitialValue = Nothing
        Me.xtxt_vendedor.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_vendedor.Requiered = False
        Me.xtxt_vendedor.Size = New System.Drawing.Size(64, 20)
        Me.xtxt_vendedor.StatusBarPanelDescripcion = Nothing
        Me.xtxt_vendedor.TabIndex = 6
        Me.xtxt_vendedor.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(31, 192)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Mensajero:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Location = New System.Drawing.Point(368, 216)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Cambio:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Location = New System.Drawing.Point(21, 216)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Forma/Pago:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label18.Location = New System.Drawing.Point(328, 288)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 16)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Ultimo Domicilio:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_domi_cambio
        '
        Me.xtxt_domi_cambio.AcceptsReturn = True
        Me.xtxt_domi_cambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.domi_cambio"))
        Me.xtxt_domi_cambio.EditInitialValue = Nothing
        Me.xtxt_domi_cambio.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_domi_cambio.FieldDescription = ""
        Me.xtxt_domi_cambio.FindInitialValue = Nothing
        Me.xtxt_domi_cambio.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_domi_cambio.IgnoreRequiered = False
        Me.xtxt_domi_cambio.Location = New System.Drawing.Point(424, 216)
        Me.xtxt_domi_cambio.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxt_domi_cambio.Name = "xtxt_domi_cambio"
        Me.xtxt_domi_cambio.NewInitialValue = Nothing
        Me.xtxt_domi_cambio.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_domi_cambio.Requiered = False
        Me.xtxt_domi_cambio.Size = New System.Drawing.Size(120, 20)
        Me.xtxt_domi_cambio.StatusBarPanelDescripcion = Nothing
        Me.xtxt_domi_cambio.TabIndex = 10
        Me.xtxt_domi_cambio.Text = ""
        Me.xtxt_domi_cambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xtxt_tarj_numero
        '
        Me.xtxt_tarj_numero.AcceptsReturn = True
        Me.xtxt_tarj_numero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.tarj_numero"))
        Me.xtxt_tarj_numero.EditInitialValue = Nothing
        Me.xtxt_tarj_numero.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_tarj_numero.FieldDescription = ""
        Me.xtxt_tarj_numero.FindInitialValue = Nothing
        Me.xtxt_tarj_numero.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_tarj_numero.IgnoreRequiered = False
        Me.xtxt_tarj_numero.Location = New System.Drawing.Point(104, 240)
        Me.xtxt_tarj_numero.Name = "xtxt_tarj_numero"
        Me.xtxt_tarj_numero.NewInitialValue = Nothing
        Me.xtxt_tarj_numero.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_tarj_numero.Requiered = False
        Me.xtxt_tarj_numero.Size = New System.Drawing.Size(192, 20)
        Me.xtxt_tarj_numero.StatusBarPanelDescripcion = Nothing
        Me.xtxt_tarj_numero.TabIndex = 8
        Me.xtxt_tarj_numero.Text = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label20.Location = New System.Drawing.Point(5, 240)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 16)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Tarjeta Numero:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_tarj_Vence
        '
        Me.xtxt_tarj_Vence.AcceptsReturn = True
        Me.xtxt_tarj_Vence.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.tarj_vence"))
        Me.xtxt_tarj_Vence.EditInitialValue = Nothing
        Me.xtxt_tarj_Vence.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_tarj_Vence.FieldDescription = ""
        Me.xtxt_tarj_Vence.FindInitialValue = Nothing
        Me.xtxt_tarj_Vence.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_tarj_Vence.IgnoreRequiered = False
        Me.xtxt_tarj_Vence.Location = New System.Drawing.Point(424, 240)
        Me.xtxt_tarj_Vence.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxt_tarj_Vence.Name = "xtxt_tarj_Vence"
        Me.xtxt_tarj_Vence.NewInitialValue = Nothing
        Me.xtxt_tarj_Vence.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_tarj_Vence.Requiered = False
        Me.xtxt_tarj_Vence.Size = New System.Drawing.Size(120, 20)
        Me.xtxt_tarj_Vence.StatusBarPanelDescripcion = Nothing
        Me.xtxt_tarj_Vence.TabIndex = 11
        Me.xtxt_tarj_Vence.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Location = New System.Drawing.Point(184, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 16)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Vencimiento:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label22.Location = New System.Drawing.Point(8, 264)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 16)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Tipo de Tarjeta:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.cust_code"))
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label19.Location = New System.Drawing.Point(232, 304)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 20)
        Me.Label19.TabIndex = 12
        '
        'Label25
        '
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.tarj_code"))
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label25.Location = New System.Drawing.Point(320, 296)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 20)
        Me.Label25.TabIndex = 12
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.CausesValidation = False
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelar.Location = New System.Drawing.Point(504, 392)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancelar la operación y cerrar esta pantalla")
        '
        'LBL_Title
        '
        Me.LBL_Title.BackColor = System.Drawing.Color.White
        Me.LBL_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBL_Title.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LBL_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Title.ForeColor = System.Drawing.Color.Blue
        Me.LBL_Title.Location = New System.Drawing.Point(0, 0)
        Me.LBL_Title.Name = "LBL_Title"
        Me.LBL_Title.Size = New System.Drawing.Size(586, 48)
        Me.LBL_Title.TabIndex = 0
        Me.LBL_Title.Text = "CLIENTES A DOMICILIO"
        Me.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAceptar.Location = New System.Drawing.Point(424, 392)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(72, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar(F5)"
        Me.ToolTip1.SetToolTip(Me.btnAceptar, "Terminar de procesar los datos del domicilio")
        '
        'xtxt_telefono1
        '
        Me.xtxt_telefono1.AcceptsReturn = True
        Me.xtxt_telefono1.EditInitialValue = Nothing
        Me.xtxt_telefono1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono1.FieldDescription = ""
        Me.xtxt_telefono1.FindInitialValue = Nothing
        Me.xtxt_telefono1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono1.IgnoreRequiered = False
        Me.xtxt_telefono1.Location = New System.Drawing.Point(0, 0)
        Me.xtxt_telefono1.Name = "xtxt_telefono1"
        Me.xtxt_telefono1.NewInitialValue = Nothing
        Me.xtxt_telefono1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono1.Requiered = False
        Me.xtxt_telefono1.StatusBarPanelDescripcion = Nothing
        Me.xtxt_telefono1.TabIndex = 0
        Me.xtxt_telefono1.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.TabIndex = 0
        '
        'i_ptvfact04
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(586, 424)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.LBL_Title)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label19)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "i_ptvfact04"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clintes a Domicilios"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        If LibXConnector1.IsDataEditing = True Then
            LibXConnector1.Cancel()
        End If
        Me.Close()
    End Sub

    Private Sub xlk_codigo_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_codigo.AfterSetValues
        Try
            If LibXConnector1.IsDataEditing = True Then
                If e.dataFound = True Then
                    Me.xcbo_pago.SelectedValue = "EFE"
                    Me.xcbo_pago.currValue = "EFE"
                    Me.xcbo_pago.NewInitialValue = "EFE"
                    RefreshScreen(Me.xcbo_pago.SelectedValue)
                    Me.xlk_ciudad.ExecuteFind()
                    Me.xlk_sector.ExecuteFind()
                    Me.LibXCombo1.SelectedValue = e.row!ncf_type
                    If LibX.IsNull(e.row!cust_credito) = False _
                    AndAlso e.row!cust_credito = 1 Then
                        mFacturarCredito = True
                    Else
                        mFacturarCredito = False
                    End If
                End If
            End If
            If LibX.IsNull(e.row!cust_code) = False Then
                vCliente = New SGT.CXC.Entidades.Cliente(e.row!cust_code)
                If vCliente.VendeCredito = 1 Then
                    Me.xtxt_nombre.Enabled = False
                    Me.xtxt_address.Enabled = False
                    If Val(Me.xtxt_ciudad.Text) <> 0 Then
                        Me.xtxt_ciudad.Enabled = False
                        Me.xlk_ciudad.Enabled = False
                    Else
                        Me.xtxt_ciudad.Enabled = True
                        Me.xlk_ciudad.Enabled = True
                    End If
                    If Val(xtxt_sector.Text) <> 0 Then
                        Me.xtxt_sector.Enabled = False
                        Me.xlk_sector.Enabled = False
                    Else
                        Me.xtxt_sector.Enabled = True
                        Me.xlk_sector.Enabled = True
                    End If
                Else
                    Me.xtxt_nombre.Enabled = True
                    Me.xtxt_address.Enabled = True
                    Me.xtxt_rnc.Enabled = True
                    Me.xtxt_ciudad.Enabled = True
                    Me.xtxt_sector.Enabled = True
                    Me.xlk_ciudad.Enabled = True
                    Me.xlk_sector.Enabled = True
                End If
            End If

            If Me.xtxt_rnc.Text <> "" Then
                Me.LibXCombo1.Enabled = True
            Else
                Me.LibXCombo1.Enabled = False
            End If

            Me.btnAceptar.Enabled = True
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Clear_Form()
        Me.xtxt_telefono1.Text = String.Empty
        Me.xtxt_address.Text = String.Empty
        Me.xtxt_ciudad.Text = String.Empty
        Me.xtxt_domi_cambio.Text = String.Empty
        Me.xtxt_nombre.Text = String.Empty
        Me.xtxt_rnc.Text = String.Empty
        Me.xtxt_sector.Text = String.Empty
        Me.xtxt_tarj_numero.Text = String.Empty
        Me.xtxt_tarj_Vence.Text = String.Empty
    End Sub

    Private Sub xlk_codigo_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_codigo.BeforeSetValues
        Try
            If LibXConnector1.IsDataEditing = True Then
                mExistecliente = e.dataFound

                If e.dataFound = False Then
                    e.handled = True
                    Clear_Form()
                    Me.lblMessage.Text = "Cliente no existe, se agregara al sistema!"
                    Me.lblMessage.ForeColor = System.Drawing.Color.Red
                    mNuevo = True
                Else
                    Me.lblMessage.Text = String.Empty
                    mNuevo = False
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim dst, pdst As Decimal
        Dim dscnt As Integer
        Try

            mCaja = New Caja(CajaAbierta.CajaCode)
            oParamExcede = New SGT.CXC.Entidades.Cliente.ParametrosExcedeLimite

            If mCliente.Codigo > 0 Then
                vCliente = New SGT.CXC.Entidades.Cliente(mCliente.Codigo)
            End If

            If Me.xcbo_pago.SelectedValue.ToString.Trim = "" Then
                Throw New ApplicationException("Debe especificar la forma de pago!")
            End If

            If mCliente.FormaPago Is Nothing And Me.xcbo_pago.SelectedValue.ToString.Trim <> "" Then
                mCliente.FormaPago = Me.xcbo_pago.SelectedValue
            Else
                If Me.xcbo_pago.SelectedValue.ToString.Trim <> mCliente.FormaPago.ToString.Trim Then
                    mCliente.FormaPago = Me.xcbo_pago.SelectedValue
                End If
            End If

            If Not mCliente.FormaPago Is Nothing AndAlso mCliente.FormaPago.ToString.Trim <> "EFE" Then
                Me.xcbo_pago.SelectedValue = mCliente.FormaPago.ToString.Trim
                Me.xcbo_pago.NewInitialValue = mCliente.FormaPago.ToString.Trim
                xtxt_domi_cambio.Text = ""
            End If

            If mCliente.FormaPago Is Nothing Or Val(xtxt_domi_cambio.Text) > 0 Then
                Me.xcbo_pago.NewInitialValue = "EFE"
                Me.xcbo_pago.SelectedValue = "EFE"
            End If

            If Me.xcbo_pago.SelectedValue.ToString.Trim = "EFE" _
            AndAlso Me.xtxt_domi_cambio.Text.Trim <> "" And Val(Me.xtxt_domi_cambio.Text.Trim) > 0 Then
                If CDbl(Me.xtxt_domi_cambio.Text) < mTotalFacturado Then
                    Me.xtxt_domi_cambio.Text = ""
                    Throw New ApplicationException("El cambio es menor que el monto facturado, Total Facturado = " & mTotalFacturado.ToString("###,###,##0.00"))
                End If
            End If

            If Me.xcbo_pago.SelectedValue.ToString.Trim = "TAR" Then
                If xtxt_tarj_numero.Text.Trim = "" Then
                    Throw New ApplicationException("Debe especificar los datos de la tarjeta a cobrar!")
                End If

                If xcbo_tarj_tipo.Text.Trim = "" Then
                    Throw New ApplicationException("Debe seleccionar el tipo de tarjeta!")
                End If
            End If
            If Me.xcbo_pago.SelectedValue.ToString.Trim = "TAR" Then
                If Val(mTotalDescuento) > 0 And Val(mConfig.GetDSCTO) > 0 And Val(mConfig.GetDsctoTar) > 0 Then
                    dst = (mTotalFacturado * (mConfig.GetDsctoTar / 100))
                    dst = dst.ToString("###,###,###.##")
                    If mTotalDescuento > dst And mConfig.GetDsctoTar > 0 Then
                        pdst = mConfig.GetDsctoTar.ToString("###,###,###.##")
                        dscnt = MessageBox.Show("El descuento maximo permitido es un " & pdst & "% del monto de la factura", "Descuento", MessageBoxButtons.OK)
                        If dscnt = System.Windows.Forms.DialogResult.OK Then
                        End If
                    End If
                End If
            End If
            ''//RBA

            If Me.xcbo_pago.SelectedValue.ToString.Trim = "CXC" And mCaja.DescuentoCxc = False Then
                If mTotalDescuento > 0 Then
                    If mConfig.GetDSCTO > 0 Then
                        If mTotalDescuento < mConfig.GetDSCTO Then
                        Else
                            Throw New ApplicationException("Descuento no permitido para facturar Domicilio a credito")
                        End If
                    Else
                        Throw New ApplicationException("Descuento no permitido para facturar Domicilio a credito")
                    End If
                End If
            End If

            If mNuevo = False Then
                If vCliente.Estado = 2 Or vCliente.Estado = 0 Then
                    Throw New ApplicationException("Este cliente esta innativo o suspendido")
                End If
                With oParamExcede
                    .Cliente = vCliente.Codigo
                    .MontoAplicar = mTotalFacturado
                End With
                If Me.xcbo_pago.SelectedValue.ToString.Trim = "CXC" Then
                    If vCliente.ExcedeLimite(oParamExcede) = True Then
                        Throw New ApplicationException("Esta transacción excede el límite de crédito")
                    End If
                End If
            End If
            If Me.xtxt_rnc.Text <> "" Then
                Me.LibXCombo1.Enabled = True
            Else
                Me.LibXCombo1.Enabled = False
            End If
            '//DataSet1.AcceptChanges()
            If mCliente.Cambio > 0 And Me.xtxt_domi_cambio.Text = "" Or Val(Me.xtxt_domi_cambio.Text) = 0 Then
                mCliente.Cambio = 0
            End If
            LibXConnector1.Accept()
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Dim xInsert As LibX.Data.XInsertStmt
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim TarjSerial As Integer

        Try
            e.UpdatingArgs.Status = UpdateStatus.SkipCurrentRow

            If mCliente.Codigo > 0 Then
                vCliente = New SGT.CXC.Entidades.Cliente(mCliente.Codigo)
            End If

            If LibX.IsNull(LibXConnector1.CurrentDataRow!city_code) Then
                Throw New ApplicationException("Debe Indicr la ciudad del cliente")
            End If

            If e.UpdatingArgs.StatementType <> StatementType.Insert Then
                If Not LibX.IsNull(vCliente.Estado) Then
                    If (vCliente.Estado = 2 Or vCliente.Estado = 0) And vCliente.VendeCredito = 1 And xcbo_pago.currValue.ToString.Trim = "CXC" Then
                        Throw New ApplicationException("Este Cliente tiene el credito supendido!")
                    End If
                End If
                If mFacturarCredito = False And vCliente.VendeCredito = 0 And xcbo_pago.currValue.ToString.Trim = "CXC" Or (vCliente.LimiteCredito = 0 And xcbo_pago.currValue.ToString.Trim = "CXC") Then
                    Throw New ApplicationException("Este Cliente no tiene credito disponible!")
                End If

            End If

            If LibX.IsNull(LibXConnector1.CurrentDataRow!sector_code) Then
                Throw New ApplicationException("Debe Indicr el Sector del cliente")
            End If

            If ValidarSectorCiudad(LibXConnector1.CurrentDataRow!sector_code, LibXConnector1.CurrentDataRow!city_code) = 0 Then
                Me.xtxt_sector.Text = ""
                Me.lbl_sector.Text = ""
                Throw New ApplicationException("El Sector asignado no corresponde con la ciudad!")
            End If

            If mExistecliente = False Then
                '// CLIENTE
                xInsert = New LibX.Data.XInsertStmt("cccustm", "cust_code")
                xInsert.Fields("cust_phone") = LibXConnector1.CurrentDataRow!cust_phone
                xInsert.Fields("rnc_id") = LibXConnector1.CurrentDataRow!rnc_id
                xInsert.Fields("cust_name") = LibXConnector1.CurrentDataRow!cust_name
                xInsert.Fields("cust_apellidos") = LibXConnector1.CurrentDataRow!cust_apellidos
                xInsert.Fields("cust_address") = LibXConnector1.CurrentDataRow!cust_address
                xInsert.Fields("city_code") = LibXConnector1.CurrentDataRow!city_code
                xInsert.Fields("sector_code") = LibXConnector1.CurrentDataRow!sector_code
                xInsert.Fields("term_code") = "00-00"   '// Termino Contado
                xInsert.Fields("csttype_code") = 2      '// Domicilio
                xInsert.Fields("cust_credito") = 0      '// Domicilio
                xInsert.Fields("cust_status") = 1      '// Domicilio
                xInsert.Fields("ncf_type") = LibXConnector1.CurrentDataRow!ncf_type
                LibX.Data.Manager.LastSerialValue = xInsert.Execute()
                LibXConnector1.CurrentDataRow!cust_code = LibX.Data.Manager.LastSerialValue
            End If

            If mExistecliente = True Then
                '// CLIENTE
                xUpdate = New LibX.Data.XUpdateStmt("cccustm")
                xUpdate.FieldsSet("cust_phone") = LibXConnector1.CurrentDataRow!cust_phone
                xUpdate.FieldsSet("rnc_id") = LibXConnector1.CurrentDataRow!rnc_id
                xUpdate.FieldsSet("cust_name") = LibXConnector1.CurrentDataRow!cust_name
                xUpdate.FieldsSet("cust_apellidos") = LibXConnector1.CurrentDataRow!cust_apellidos
                xUpdate.FieldsSet("cust_address") = LibXConnector1.CurrentDataRow!cust_address
                xUpdate.FieldsSet("city_code") = LibXConnector1.CurrentDataRow!city_code
                xUpdate.FieldsSet("sector_code") = LibXConnector1.CurrentDataRow!sector_code
                xUpdate.FieldsSet("ncf_type") = LibXConnector1.CurrentDataRow!ncf_type
                xUpdate.Fields("cust_code") = LibXConnector1.CurrentDataRow!cust_code
                xUpdate.Execute()
            End If

            ''// TARJETA
            If xcbo_pago.currValue.ToString.Trim = "TAR" Then
                If mExisteTarjeta = False Then
                    xInsert = New LibX.Data.XInsertStmt("pvtarjeta", "tarj_code")
                    xInsert.Fields("tarj_numero") = Me.xtxt_tarj_numero.Text
                    xInsert.Fields("tarj_vence") = Me.xtxt_tarj_Vence.Text
                    xInsert.Fields("tarj_tipo") = Me.xcbo_tarj_tipo.currValue
                    xInsert.Fields("cust_code") = LibXConnector1.CurrentDataRow!cust_code
                    mCliente.TarjetaCodigo = xInsert.Execute()
                Else
                    xUpdate = New LibX.Data.XUpdateStmt("pvtarjeta")
                    xUpdate.FieldsSet("tarj_numero") = Me.xtxt_tarj_numero.Text
                    xUpdate.FieldsSet("tarj_vence") = Me.xtxt_tarj_Vence.Text
                    xUpdate.FieldsSet("tarj_tipo") = Me.xcbo_tarj_tipo.currValue
                    xUpdate.FieldsSet("cust_code") = LibXConnector1.CurrentDataRow!cust_code

                    xUpdate.Fields("tarj_code") = mCliente.TarjetaCodigo
                    xUpdate.Execute()
                End If
            End If

            With mCliente
                .Codigo = LibXConnector1.CurrentDataRow!cust_code
                .Nombre = LibXConnector1.CurrentDataRow!cust_name
                .Apellidos = LibXConnector1.CurrentDataRow!cust_apellidos.ToString.Trim
                .Direccion = LibXConnector1.CurrentDataRow!cust_address
                If LibX.IsNull(LibXConnector1.CurrentDataRow!cust_phone) = False Then .Telefono = LibXConnector1.CurrentDataRow!cust_phone
                If LibX.IsNull(LibXConnector1.CurrentDataRow!rnc_id) = False Then .Rnc = LibXConnector1.CurrentDataRow!rnc_id
                If LibX.IsNull(LibXConnector1.CurrentDataRow!city_code) = False Then .Ciudad = LibXConnector1.CurrentDataRow!city_code
                If LibX.IsNull(LibXConnector1.CurrentDataRow!sector_code) = False Then .Sector = LibXConnector1.CurrentDataRow!sector_code
                If LibX.IsNull(LibXConnector1.CurrentDataRow!domi_pago) = False Then .FormaPago = LibXConnector1.CurrentDataRow!domi_pago
                If LibX.IsNull(LibXConnector1.CurrentDataRow!vend_mensaj) = False Then .Mensajero = LibXConnector1.CurrentDataRow!vend_mensaj
                If LibX.IsNull(LibXConnector1.CurrentDataRow!domi_cambio) = False Then .Cambio = LibXConnector1.CurrentDataRow!domi_cambio
                If LibX.IsNull(Me.lbl_ciudad.Text) = False Then .NombreCiudad = Me.lbl_ciudad.Text
                If LibX.IsNull(Me.lbl_mensajero.Text) = False Then .NombreMensajero = Me.lbl_mensajero.Text
                If LibX.IsNull(.NombreSector = Me.lbl_sector.Text) = False Then .NombreSector = Me.lbl_sector.Text
                .TarjetaNumero = Me.xtxt_tarj_numero.Text
                If Me.lblRecargo.Text.Trim <> String.Empty Then
                    .TarjetaRecargo = Me.lblRecargo.Text
                Else
                    .TarjetaRecargo = 0
                End If

                If Not Me.xcbo_tarj_tipo.currValue Is DBNull.Value AndAlso Me.xcbo_tarj_tipo.currValue > 0 Then
                    .TarjetaTipo = Me.xcbo_tarj_tipo.currValue
                Else
                    .TarjetaTipo = 0
                End If

                .TarjetaTipoNombre = Me.xcbo_tarj_tipo.Text
                .TarjteaVencimineto = Me.xtxt_tarj_Vence.Text

            End With

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXCombo1_valueChanged(ByVal sender As System.Object, ByVal e As LibX.XComboSelectedEventArgs) Handles xcbo_pago.valueChanged
        Try
            If LibXConnector1.IsDataEditing = True AndAlso Not LibX.IsNull(e.value) Then
                RefreshScreen(e.value)
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub RefreshScreen(ByVal Tipo As String)
        xtxt_domi_cambio.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        xtxt_tarj_numero.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        xcbo_tarj_tipo.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        xtxt_tarj_Vence.NewState = LibX.IEditProperty.InitialStateEnum.Disabled

        xtxt_domi_cambio.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        xtxt_tarj_numero.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        xcbo_tarj_tipo.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        xtxt_tarj_Vence.EditState = LibX.IEditProperty.InitialStateEnum.Disabled

        xtxt_domi_cambio.Text = String.Empty
        xtxt_tarj_numero.Text = String.Empty
        xcbo_tarj_tipo.Text = String.Empty
        xtxt_tarj_Vence.Text = String.Empty

        Select Case Tipo
            Case "EFE"
                xtxt_domi_cambio.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
                xtxt_domi_cambio.EditState = LibX.IEditProperty.InitialStateEnum.Enabled

            Case "CHK"

            Case "CXC"

            Case "TAR"
                Me.xlk_tarjta.Enabled = True
                xtxt_tarj_numero.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
                xcbo_tarj_tipo.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
                xtxt_tarj_Vence.NewState = LibX.IEditProperty.InitialStateEnum.Enabled

                xtxt_tarj_numero.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
                xcbo_tarj_tipo.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
                xtxt_tarj_Vence.EditState = LibX.IEditProperty.InitialStateEnum.Enabled

        End Select

        Dim e1 As New LibX.XChangeStateEventArgs

        e1.aceptedAction = LibXConnector1.CurrentAction
        e1.action = LibXConnector1.CurrentAction
        e1.isDataEditing = LibXConnector1.IsDataEditing
        e1.isEditing = LibXConnector1.IsEditing
        e1.isInDataQuery = False
        e1.isMoving = False
        e1.state = LibXConnector1.State

        xtxt_domi_cambio.RefreshState(e1)
        xtxt_tarj_numero.RefreshState(e1)
        xcbo_tarj_tipo.RefreshState(e1)
        xtxt_tarj_Vence.RefreshState(e1)
    End Sub
    Private Sub xlk_tarjta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xlk_tarjta.Load
        mExisteTarjeta = False
        mExistecliente = False

        mCaja = New Caja(CajaAbierta.CajaCode)

    End Sub
    Private Sub xlk_tarjta_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_tarjta.AfterSetValues
        Try
            mExisteTarjeta = e.dataFound
            If e.dataFound = True Then
                xcbo_tarj_tipo.currValue = e.row!tarj_tipo
                mCliente.TarjetaCodigo = e.row!tarj_code
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub xlk_tarjta_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_tarjta.BeforeSetValues
        Try
            If e.dataFound = False Then
                e.handled = True
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub xcbo_tarj_tipo_valueChanged(ByVal sender As Object, ByVal e As LibX.XComboSelectedEventArgs) Handles xcbo_tarj_tipo.valueChanged
        Try

            If Not Me.xcbo_tarj_tipo.currValue Is DBNull.Value Then
                lblRecargo.Text = xcbo_tarj_tipo.GetCurrentRow!recargo.ToString.Trim
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Public Overloads Function ShowDialog(ByVal oCliente As ClienteDomicilio, ByVal TotalFacturado As Decimal, ByVal TotalDescuento As Decimal) As DialogResult
        mCliente = oCliente
        mTotalFacturado = TotalFacturado
        mTotalDescuento = TotalDescuento
        If mCliente.Codigo > 0 And Me.xtxt_codigo.Text <> "" Then
            vCliente = New SGT.CXC.Entidades.Cliente(mCliente.Codigo)
            If vCliente.VendeCredito = 1 Then
                Me.xtxt_nombre.Enabled = False
                Me.xtxt_address.Enabled = False
                If Val(Me.xtxt_ciudad.Text) <> 0 Then
                    Me.xtxt_ciudad.Enabled = False
                    Me.xlk_ciudad.Enabled = False
                Else
                    Me.xtxt_ciudad.Enabled = True
                    Me.xlk_ciudad.Enabled = True
                End If
                If Val(xtxt_sector.Text) <> 0 Then
                    Me.xtxt_sector.Enabled = False
                    Me.xlk_sector.Enabled = False
                Else
                    Me.xtxt_sector.Enabled = True
                    Me.xlk_sector.Enabled = True
                End If
                If Me.xtxt_rnc.Text <> "" Then
                    Me.LibXCombo1.Enabled = True
                Else
                    Me.LibXCombo1.Enabled = False
                End If
            Else
                Me.xtxt_nombre.Enabled = True
                Me.xtxt_address.Enabled = True
                Me.xtxt_rnc.Enabled = True
                Me.xtxt_ciudad.Enabled = True
                Me.xtxt_sector.Enabled = True
                Me.xlk_ciudad.Enabled = True
                Me.xlk_sector.Enabled = True
            End If
        End If
        If Me.xtxt_rnc.Text <> "" Then
            Me.LibXCombo1.Enabled = True
        End If
        Return MyBase.ShowDialog()
    End Function

    Private Sub xtxt_codigo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_codigo.Validating
        If LibXConnector1.IsDataEditing = True Then
            If Me.xtxt_codigo.Text.Trim = "" Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub i_ptvfact04_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim dst, pdst As Decimal
        Dim dscnt As Integer
        Try
            mCaja = New Caja(CajaAbierta.CajaCode)
            oParamExcede = New SGT.CXC.Entidades.Cliente.ParametrosExcedeLimite
            If mCliente.Codigo > 0 Then
                vCliente = New SGT.CXC.Entidades.Cliente(mCliente.Codigo)
            End If
            If LibXConnector1.IsDataEditing = True Then
                If e.KeyCode = Keys.F5 Then
                    LibXConnector1.Accept()
                    If Me.xcbo_pago.SelectedValue.ToString.Trim = "" Then
                        Throw New ApplicationException("Debe especificar la forma de pago!")
                    End If

                    If mCliente.FormaPago Is Nothing And Me.xcbo_pago.SelectedValue.ToString.Trim <> "" Then
                        mCliente.FormaPago = Me.xcbo_pago.SelectedValue
                    Else
                        If Me.xcbo_pago.SelectedValue.ToString.Trim <> mCliente.FormaPago.ToString.Trim Then
                            mCliente.FormaPago = Me.xcbo_pago.SelectedValue
                        End If
                    End If

                    If Not mCliente.FormaPago Is Nothing AndAlso mCliente.FormaPago.ToString.Trim <> "EFE" Then
                        Me.xcbo_pago.SelectedValue = mCliente.FormaPago.ToString.Trim
                        Me.xcbo_pago.NewInitialValue = mCliente.FormaPago.ToString.Trim
                        xtxt_domi_cambio.Text = 0
                    End If

                    If mCliente.FormaPago Is Nothing Or Val(xtxt_domi_cambio.Text) > 0 Then
                        Me.xcbo_pago.NewInitialValue = "EFE"
                        Me.xcbo_pago.SelectedValue = "EFE"
                    End If

                    If Me.xcbo_pago.SelectedValue.ToString.Trim = "EFE" _
                    AndAlso Me.xtxt_domi_cambio.Text.Trim <> "" And Val(Me.xtxt_domi_cambio.Text.Trim) > 0 Then
                        If CDbl(Me.xtxt_domi_cambio.Text) < mTotalFacturado Then
                            Me.xtxt_domi_cambio.Text = ""
                            Throw New ApplicationException("El cambio es menor que el monto facturado, Total Facturado = " & mTotalFacturado.ToString("###,###,##0.00"))
                        End If
                    End If

                    If Me.xcbo_pago.SelectedValue.ToString.Trim = "TAR" Then
                        If xtxt_tarj_numero.Text.Trim = "" Then
                            Throw New ApplicationException("Debe especificar los datos de la tarjeta a cobrar!")
                        End If

                        If xcbo_tarj_tipo.Text.Trim = "" Then
                            Throw New ApplicationException("Debe seleccionar el tipo de tarjeta!")
                        End If
                    End If
                    If Me.xcbo_pago.SelectedValue.ToString.Trim = "TAR" Then
                        If Val(mTotalDescuento) > 0 And Val(mConfig.GetDSCTO) > 0 And Val(mConfig.GetDsctoTar) > 0 Then
                            dst = (mTotalFacturado * (mConfig.GetDsctoTar / 100))
                            dst = dst.ToString("###,###,###.##")
                            If mTotalDescuento > dst And mConfig.GetDsctoTar > 0 Then
                                pdst = mConfig.GetDsctoTar.ToString("###,###,###.##")
                                dscnt = MessageBox.Show("El descuento maximo permitido es un " & pdst & "% del monto de la factura", "Descuento", MessageBoxButtons.OK)
                                If dscnt = System.Windows.Forms.DialogResult.OK Then
                                End If
                            End If
                        End If
                    End If
                    ''//RBA

                    If Me.xcbo_pago.SelectedValue.ToString.Trim = "CXC" And mCaja.DescuentoCxc = False Then
                        If mTotalDescuento > 0 Then
                            If mConfig.GetDSCTO > 0 Then
                                If mTotalDescuento < mConfig.GetDSCTO Then
                                Else
                                    Throw New ApplicationException("Descuento no permitido para facturar Domicilio a credito")
                                End If
                            Else
                                Throw New ApplicationException("Descuento no permitido para facturar Domicilio a credito")
                            End If
                        End If
                    End If

                    If vCliente.Estado = 2 Or vCliente.Estado = 0 Then
                        Throw New ApplicationException("Este cliente esta innativo o suspendido")
                    End If

                    With oParamExcede
                        .Cliente = vCliente.Codigo
                        .MontoAplicar = mTotalFacturado
                    End With
                    If vCliente.Estado = 2 Or vCliente.Estado = 3 Then
                        Throw New ApplicationException("Este cliente esta inativo o suspendigo")
                    End If
                    If Me.xcbo_pago.SelectedValue.ToString.Trim = "CXC" Then
                        If vCliente.ExcedeLimite(oParamExcede) = True Then
                            Throw New ApplicationException("Esta transacción excede el límite de crédito")
                        End If
                    End If
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            End If
            If Me.xtxt_rnc.Text <> "" Then
                Me.LibXCombo1.Enabled = True
            Else
                Me.LibXCombo1.Enabled = False
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xcbo_pago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xcbo_pago.SelectedIndexChanged
        Dim mDisponible As Decimal
        Try
            oParamExcede = New SGT.CXC.Entidades.Cliente.ParametrosExcedeLimite
            If LibXConnector1.IsDataEditing = True Then
                If TypeOf Me.xcbo_pago.SelectedValue Is String Then
                    If Me.xcbo_pago.SelectedValue <> "EFE" And Val(Me.xtxt_domi_cambio.Text) > 0 Then
                        Me.xcbo_pago.SelectedValue = "EFE"
                    Else
                        Me.xtxt_domi_cambio.Text = 0
                    End If
                    '''If Me.xcbo_pago.SelectedValue = "CXC" And mFacturarCredito = False Then
                    '''    Me.xcbo_pago.SelectedValue = -1
                    '''    Throw New ApplicationException("Este cliente no permite facturar a crédito!")
                    '''End If
                End If
                Me.xcbo_pago.NewInitialValue = mCliente.FormaPago
                Me.xcbo_pago.EditInitialValue = mCliente.FormaPago
                If TypeOf Me.xcbo_pago.SelectedValue Is String Then
                    If Me.xcbo_pago.SelectedValue = "CXC" Or mCliente.FormaPago = "CXC" Then
                        mDisponible = vCliente.LimiteCredito - vCliente.GetBalance(vCliente.Codigo)
                        Me.xlxbal.Text = Format(mDisponible, "###,##0.00")
                        Me.xlxbal.Visible = True
                        Me.xtxbal.Visible = True
                    Else
                        Me.xlxbal.Visible = False
                        Me.xtxbal.Visible = False
                    End If
                    If Me.xcbo_pago.SelectedValue = "CXC" Or mCliente.FormaPago = "CXC" Then
                        With oParamExcede
                            .Cliente = vCliente.Codigo
                            .MontoAplicar = mTotalFacturado
                        End With
                        If Me.xcbo_pago.SelectedValue.ToString.Trim = "CXC" Then
                            If vCliente.ExcedeLimite(oParamExcede) = True Then
                                Throw New ApplicationException("Esta transacción excede el límite de crédito")
                            End If
                        End If
                    End If
                End If
            End If
            If Me.xtxt_rnc.Text <> "" Then
                Me.LibXCombo1.Enabled = True
            Else
                Me.LibXCombo1.Enabled = False
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub xlk_sector_BeforeExecuteQuery(ByVal sender As System.Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_sector.BeforeExecuteQuery
        Try
            'If LibXConnector1.IsDataEditing = True Then
            If Me.xtxt_ciudad.Text.Trim <> "" Then
                e.aditionalWhere = " ccsectorm.city_code = " & Me.xtxt_ciudad.Text
                'Else
                ''    Throw New ApplicationException("Debe especificar una chequera antes!")
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If Not e.row Is Nothing Then
                mExistecliente = True

                If e.row!domi_pago Is DBNull.Value And (Not mCliente.FormaPago Is Nothing AndAlso mCliente.FormaPago.ToString.Trim <> "") Then
                    Me.xcbo_pago.SelectedValue = mCliente.FormaPago
                    Me.xcbo_pago.currValue = mCliente.FormaPago
                End If
                If Not mCliente.FormaPago Is Nothing AndAlso mCliente.FormaPago.ToString.Trim <> "EFE" Then
                    Me.xcbo_pago.SelectedValue = mCliente.FormaPago.ToString.Trim
                    Me.xcbo_pago.currValue = mCliente.FormaPago.ToString.Trim
                End If

                If e.row!domi_cambio Is DBNull.Value And mCliente.Cambio > 0 Then
                    Me.xtxt_domi_cambio.Text = mCliente.Cambio
                End If

                If Not e.row!tarj_code Is DBNull.Value And mCliente.FormaPago.ToString.Trim = "TAR" Then
                    mExisteTarjeta = True
                End If
            End If
            If Me.xtxt_rnc.Text <> "" Then
                Me.LibXCombo1.Enabled = True
            Else
                Me.LibXCombo1.Enabled = False
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub i_ptvfact04_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.xlk_ciudad.ExecuteFind()
        Me.xlk_sector.ExecuteFind()
        mConfig = New SGT.Inventario.Common.Configuration

    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibX.LibxConnectionActions.Edit Then
                If Not LibXConnector1.CurrentDataRow Is Nothing Then
                    With mCliente

                        RefreshScreen(mCliente.FormaPago.ToString.Trim)

                        If LibX.IsNull(.FormaPago) = False Then xcbo_pago.SelectedValue = .FormaPago
                        If LibX.IsNull(.Mensajero) = False Then xtxt_vendedor.Text = .Mensajero
                        If LibX.IsNull(.Cambio) = False Then xtxt_domi_cambio.Text = .Cambio
                        If LibX.IsNull(.TarjetaTipo) = False Then xcbo_tarj_tipo.SelectedValue = .TarjetaTipo
                        If LibX.IsNull(.TarjetaNumero) = False Then xtxt_tarj_numero.Text = .TarjetaNumero
                        If LibX.IsNull(.TarjteaVencimineto) = False Then xtxt_tarj_Vence.Text = .TarjteaVencimineto

                        'If LibX.IsNull(.NombreMensajero) = False Then Me.lbl_mensajero.Text = .NombreMensajero
                    End With
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Function ValidarSectorCiudad(ByVal mSector As Integer, ByVal mCity As Integer) As Integer
        Dim oRedSector As Integer
        Dim SelectStmt As String

        SelectStmt = "select sector_code from ccsectorm where city_code = " & mCity.ToString.Trim & _
                     " and sector_code = " & mSector.ToString.Trim

        oRedSector = LibX.Data.Manager.GetScalar(SelectStmt)

        Return oRedSector

    End Function
    Private Sub xlk_ciudad_BeforeExecuteQuery(ByVal sender As System.Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_sector.BeforeExecuteQuery
        Try
            If Me.xlk_ciudad.Text.Trim <> "" Then
                e.aditionalWhere = " ccsectorm.city_code = " & Me.xtxt_ciudad.Text
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        'If LibXConnector1.IsDataEditing = True Then
        If mCliente.Codigo <> 0 And mCliente.FormaPago <> "" And mCliente.Ftserial <> 0 Then
            'e.AditionalWhere = " ftdomim.domi_pago = '" & mCliente.FormaPago & "' And ftdomim.cust_code = " & mCliente.Codigo
            e.AditionalWhere = " ftdomim.ftserial_no = " & mCliente.Ftserial & " And ftdomim.cust_code = " & mCliente.Codigo
        End If
        'End If
    End Sub

End Class
