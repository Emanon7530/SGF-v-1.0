Imports LibX
Imports Microsoft.Office.Interop
Public Class r_ptvfact04
    Inherits System.Windows.Forms.Form
    Dim WhDefault As Integer
    Dim oDoc As SGT.Facturacion.Entidades.Documento
    Dim r607 As Excel.Application
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
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtwhse_code As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents lblwhse_name As System.Windows.Forms.Label
    Friend WithEvents Txt_almacen As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Fecha_Fin As LibX.LibxDateTimePicker
    Friend WithEvents Fecha_Ini As LibX.LibxDateTimePicker
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
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
    Friend WithEvents Txt_Tipo_venta As System.Windows.Forms.TextBox
    Friend WithEvents Lblventa_name As System.Windows.Forms.Label
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents LibXCombo2 As LibX.LibXCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo3 As LibX.LibXCombo
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents cust_name As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Comb_estado As LibX.LibXCombo
    Friend WithEvents F607 As System.Windows.Forms.RadioButton
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents F608 As System.Windows.Forms.RadioButton
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents cbo_anio As System.Windows.Forms.ComboBox
    Friend WithEvents chklst_mes As System.Windows.Forms.CheckedListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents rbt_abril2018 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_mayo2018 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
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
        Me.DataColumn49 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtwhse_code = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.lblwhse_name = New System.Windows.Forms.Label
        Me.Txt_almacen = New System.Windows.Forms.TextBox
        Me.Fecha_Fin = New LibX.LibxDateTimePicker
        Me.Fecha_Ini = New LibX.LibxDateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.F607 = New System.Windows.Forms.RadioButton
        Me.Txt_Tipo_venta = New System.Windows.Forms.TextBox
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.Lblventa_name = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.LibXCombo2 = New LibX.LibXCombo
        Me.Label3 = New System.Windows.Forms.Label
        Me.LibXCombo3 = New LibX.LibXCombo
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.cust_name = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Comb_estado = New LibX.LibXCombo
        Me.Label10 = New System.Windows.Forms.Label
        Me.F608 = New System.Windows.Forms.RadioButton
        Me.cbo_anio = New System.Windows.Forms.ComboBox
        Me.chklst_mes = New System.Windows.Forms.CheckedListBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.rbt_abril2018 = New System.Windows.Forms.RadioButton
        Me.rbt_mayo2018 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.LibXConnector1.HandledRowsFill = True
        Me.LibXConnector1.HandledUpdates = True
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = ""
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = ""
        Me.LibXConnector1.ReportObject = Nothing
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1})
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
        Me.DataSet1.Namespace = "ftfactm"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn14}
        Me.DataTable1.TableName = "ftfactm"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Fecha_ini"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Fecha_fin"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "fact_number"
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "fact_date"
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "fact_total"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "descto"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "itbis"
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "type_code"
        Me.DataColumn8.MaxLength = 3
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "fact_ncf"
        Me.DataColumn9.MaxLength = 40
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "cust_name"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "cust_rnc"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "whse_code"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "vend_code"
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.AutoIncrement = True
        Me.DataColumn14.ColumnName = "ftserial_no"
        Me.DataColumn14.DataType = GetType(System.Int32)
        Me.DataColumn14.ReadOnly = True
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "dev_type"
        Me.DataColumn15.MaxLength = 3
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "cotiz_serial"
        Me.DataColumn16.DataType = GetType(System.Int32)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "term_code"
        Me.DataColumn17.MaxLength = 5
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "addr_code"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "userid"
        Me.DataColumn19.MaxLength = 20
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "fact_status"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "date_created"
        Me.DataColumn21.DataType = GetType(System.DateTime)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "cust_code"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "fact_cond"
        Me.DataColumn23.DataType = GetType(System.Int16)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "bus_name"
        Me.DataColumn24.MaxLength = 100
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "fact_nota"
        Me.DataColumn25.MaxLength = 80
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "ftserial_afect"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "pay_adelant"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "phone"
        Me.DataColumn28.MaxLength = 13
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "pay_mora"
        Me.DataColumn29.DataType = GetType(System.Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "porc_comision"
        Me.DataColumn30.DataType = GetType(System.Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "caja_code"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "caje_code"
        Me.DataColumn32.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "init_serial"
        Me.DataColumn33.DataType = GetType(System.Int32)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "fact_inddomicilio"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "address"
        Me.DataColumn35.MaxLength = 200
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "seg_amount"
        Me.DataColumn36.DataType = GetType(System.Decimal)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "prov_code"
        Me.DataColumn37.DataType = GetType(System.Int32)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "fact_impresa"
        Me.DataColumn38.DataType = GetType(System.Int32)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "cust_serial"
        Me.DataColumn39.DataType = GetType(System.Int32)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "date_anulado"
        Me.DataColumn40.DataType = GetType(System.DateTime)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "fact_time"
        Me.DataColumn41.MaxLength = 12
        '
        'DataColumn42
        '
        Me.DataColumn42.AllowDBNull = False
        Me.DataColumn42.ColumnName = "suc_code"
        Me.DataColumn42.DataType = GetType(System.Int32)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "fact_create"
        Me.DataColumn43.DataType = GetType(System.DateTime)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "priceMayor"
        Me.DataColumn44.DataType = GetType(System.Int32)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "moneda"
        Me.DataColumn45.DataType = GetType(System.Int32)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "autoriza"
        Me.DataColumn46.DataType = GetType(System.Int32)
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "fact_tasa"
        Me.DataColumn47.DataType = GetType(System.Decimal)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "fact_conduce"
        Me.DataColumn48.DataType = GetType(System.DateTime)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "ncf_type"
        Me.DataColumn49.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ftfactm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(31, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha inicial:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(38, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = Nothing
        Me.LibXDbSourceTable2.TableName = Nothing
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.Location = New System.Drawing.Point(600, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 232)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(8, 104)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Cerrar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLimpiar.Location = New System.Drawing.Point(8, 56)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(72, 32)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEjecutar.Location = New System.Drawing.Point(9, 16)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(72, 32)
        Me.btnEjecutar.TabIndex = 0
        Me.btnEjecutar.Text = "Ejecutar"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(698, 48)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "LISTADO DE DOCUMENTOS "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtwhse_code
        '
        Me.txtwhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.whse_code"))
        Me.txtwhse_code.Location = New System.Drawing.Point(106, 113)
        Me.txtwhse_code.Name = "txtwhse_code"
        Me.txtwhse_code.Size = New System.Drawing.Size(56, 20)
        Me.txtwhse_code.TabIndex = 2
        Me.txtwhse_code.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(45, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Vendedor:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"Txt_almacen=vend_code", "lblwhse_name=vend_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(440, 112)
        Me.LibXLookup1.LookCaption = Nothing
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
        Me.LibXLookup1.SrcParameters = New String() {"vend_code=vend_code"}
        Me.LibXLookup1.TabIndex = 3
        Me.LibXLookup1.TableName = "ftvendm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=vend_code", "Descripción=vend_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'lblwhse_name
        '
        Me.lblwhse_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblwhse_name.Location = New System.Drawing.Point(162, 113)
        Me.lblwhse_name.Name = "lblwhse_name"
        Me.lblwhse_name.Size = New System.Drawing.Size(278, 20)
        Me.lblwhse_name.TabIndex = 19
        '
        'Txt_almacen
        '
        Me.Txt_almacen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.vend_code"))
        Me.Txt_almacen.Location = New System.Drawing.Point(106, 113)
        Me.Txt_almacen.Name = "Txt_almacen"
        Me.Txt_almacen.Size = New System.Drawing.Size(56, 20)
        Me.Txt_almacen.TabIndex = 38
        Me.Txt_almacen.Text = ""
        '
        'Fecha_Fin
        '
        Me.Fecha_Fin.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_Fin.EditInitialValue = Nothing
        Me.Fecha_Fin.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Fin.FieldDescription = ""
        Me.Fecha_Fin.FindInitialValue = "Now"
        Me.Fecha_Fin.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha_Fin.IgnoreRequiered = False
        Me.Fecha_Fin.Location = New System.Drawing.Point(106, 90)
        Me.Fecha_Fin.Name = "Fecha_Fin"
        Me.Fecha_Fin.NewInitialValue = Nothing
        Me.Fecha_Fin.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Fin.Requiered = False
        Me.Fecha_Fin.Size = New System.Drawing.Size(128, 20)
        Me.Fecha_Fin.StatusBarPanelDescripcion = Nothing
        Me.Fecha_Fin.TabIndex = 1
        '
        'Fecha_Ini
        '
        Me.Fecha_Ini.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_Ini.EditInitialValue = Nothing
        Me.Fecha_Ini.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Ini.FieldDescription = ""
        Me.Fecha_Ini.FindInitialValue = "Now"
        Me.Fecha_Ini.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Ini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha_Ini.IgnoreRequiered = False
        Me.Fecha_Ini.Location = New System.Drawing.Point(106, 66)
        Me.Fecha_Ini.Name = "Fecha_Ini"
        Me.Fecha_Ini.NewInitialValue = Nothing
        Me.Fecha_Ini.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Ini.Requiered = False
        Me.Fecha_Ini.Size = New System.Drawing.Size(128, 20)
        Me.Fecha_Ini.StatusBarPanelDescripcion = Nothing
        Me.Fecha_Ini.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(62, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Grupo:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(11, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Tipo Documento:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'F607
        '
        Me.F607.Checked = True
        Me.F607.Location = New System.Drawing.Point(248, 64)
        Me.F607.Name = "F607"
        Me.F607.Size = New System.Drawing.Size(208, 24)
        Me.F607.TabIndex = 39
        Me.F607.TabStop = True
        Me.F607.Text = "607 - Ventas de Bienes y Servicios"
        '
        'Txt_Tipo_venta
        '
        Me.Txt_Tipo_venta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.type_code"))
        Me.Txt_Tipo_venta.Location = New System.Drawing.Point(106, 158)
        Me.Txt_Tipo_venta.Name = "Txt_Tipo_venta"
        Me.Txt_Tipo_venta.Size = New System.Drawing.Size(56, 20)
        Me.Txt_Tipo_venta.TabIndex = 43
        Me.Txt_Tipo_venta.Text = ""
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"Txt_Tipo_venta=type_code", "Lblventa_name=type_name"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(440, 152)
        Me.LibXLookup2.LookCaption = Nothing
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup2.ShowFilter = True
        Me.LibXLookup2.ShowMessageNotFound = True
        Me.LibXLookup2.ShowWarning = False
        Me.LibXLookup2.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup2.SizesColumns = Nothing
        Me.LibXLookup2.SizesColumnsTab = Nothing
        Me.LibXLookup2.SqlString = Nothing
        Me.LibXLookup2.SQLTab = Nothing
        Me.LibXLookup2.SrcParameters = New String() {"type_code=type_code"}
        Me.LibXLookup2.TabIndex = 41
        Me.LibXLookup2.TableName = "ivtypem"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=type_code", "Descripción=type_name"}
        Me.LibXLookup2.WhereCondition = "type_code in ('FCT','DEV','NCC')"
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'Lblventa_name
        '
        Me.Lblventa_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblventa_name.Location = New System.Drawing.Point(162, 158)
        Me.Lblventa_name.Name = "Lblventa_name"
        Me.Lblventa_name.Size = New System.Drawing.Size(278, 20)
        Me.Lblventa_name.TabIndex = 42
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.moneda"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Items.AddRange(New Object() {"1-VETERINARIOS", "2-AGRICOLA"})
        Me.LibXCombo1.Location = New System.Drawing.Point(106, 181)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = Nothing
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(184, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 53
        '
        'LibXCombo2
        '
        Me.LibXCombo2.AllowDefaultSort = True
        Me.LibXCombo2.bound = True
        Me.LibXCombo2.currValue = Nothing
        Me.LibXCombo2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.fact_ncf"))
        Me.LibXCombo2.DefaultWhereString = Nothing
        Me.LibXCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo2.EditInitialValue = Nothing
        Me.LibXCombo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.FieldDescription = ""
        Me.LibXCombo2.FindInitialValue = Nothing
        Me.LibXCombo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.IgnoreRequiered = False
        Me.LibXCombo2.Items.AddRange(New Object() {"01-VALOR CREDITO FISCAL", "02-SIN VALOR CREDITO FISCAL", "15-GUBERNAMENTALES", "11-PROVEEDORES INFORMALES", "04-NOTA DE CREDITO", "03-NOTA DE DEBITO", "13-GASTOS MENORES", "14-REGIMEN ESP/TRIBUTACION"})
        Me.LibXCombo2.Location = New System.Drawing.Point(106, 205)
        Me.LibXCombo2.LookupKeyDisplayFields = Nothing
        Me.LibXCombo2.LookupKeyField = Nothing
        Me.LibXCombo2.LookupTableName = Nothing
        Me.LibXCombo2.Name = "LibXCombo2"
        Me.LibXCombo2.NewInitialValue = Nothing
        Me.LibXCombo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.Requiered = False
        Me.LibXCombo2.Required = False
        Me.LibXCombo2.Size = New System.Drawing.Size(184, 21)
        Me.LibXCombo2.SqlString = Nothing
        Me.LibXCombo2.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo2.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(25, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Comprobante:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibXCombo3
        '
        Me.LibXCombo3.AllowDefaultSort = True
        Me.LibXCombo3.bound = True
        Me.LibXCombo3.currValue = Nothing
        Me.LibXCombo3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.fact_cond"))
        Me.LibXCombo3.DefaultWhereString = Nothing
        Me.LibXCombo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo3.EditInitialValue = Nothing
        Me.LibXCombo3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo3.FieldDescription = ""
        Me.LibXCombo3.FindInitialValue = Nothing
        Me.LibXCombo3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo3.IgnoreRequiered = False
        Me.LibXCombo3.Items.AddRange(New Object() {"1-CONTADO", "2-CREDITO"})
        Me.LibXCombo3.Location = New System.Drawing.Point(107, 229)
        Me.LibXCombo3.LookupKeyDisplayFields = Nothing
        Me.LibXCombo3.LookupKeyField = Nothing
        Me.LibXCombo3.LookupTableName = Nothing
        Me.LibXCombo3.Name = "LibXCombo3"
        Me.LibXCombo3.NewInitialValue = Nothing
        Me.LibXCombo3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo3.Requiered = False
        Me.LibXCombo3.Required = False
        Me.LibXCombo3.Size = New System.Drawing.Size(184, 21)
        Me.LibXCombo3.SqlString = Nothing
        Me.LibXCombo3.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo3.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(43, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Condicion:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.cust_code"))
        Me.TextBox1.Location = New System.Drawing.Point(106, 136)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 20)
        Me.TextBox1.TabIndex = 62
        Me.TextBox1.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(58, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 16)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Cliente:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibXLookup3
        '
        Me.LibXLookup3.AlternateFieldSearch = Nothing
        Me.LibXLookup3.BeginCheck = False
        Me.LibXLookup3.CheckText = Nothing
        Me.LibXLookup3.ComboMode = False
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Me.LibXConnector1
        Me.LibXLookup3.DestParameters = New String() {"cust_code=cust_code", "cust_name=cust_name"}
        Me.LibXLookup3.FilterField = "cust_name"
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.isCanceled = False
        Me.LibXLookup3.Location = New System.Drawing.Point(440, 136)
        Me.LibXLookup3.LookCaption = Nothing
        Me.LibXLookup3.Name = "LibXLookup3"
        Me.LibXLookup3.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup3.ShowFilter = True
        Me.LibXLookup3.ShowMessageNotFound = True
        Me.LibXLookup3.ShowWarning = False
        Me.LibXLookup3.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup3.SizesColumns = Nothing
        Me.LibXLookup3.SizesColumnsTab = Nothing
        Me.LibXLookup3.SqlString = Nothing
        Me.LibXLookup3.SQLTab = Nothing
        Me.LibXLookup3.SrcParameters = New String() {"cust_code=cust_code"}
        Me.LibXLookup3.TabIndex = 59
        Me.LibXLookup3.TableName = "cccustm"
        Me.LibXLookup3.TabStop = False
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.UseTab = False
        Me.LibXLookup3.VisParameters = New String() {"Código=cust_code", "Nombre=cust_name"}
        Me.LibXLookup3.WhereCondition = "cust_status = 1"
        Me.LibXLookup3.WhereParameters = Nothing
        '
        'cust_name
        '
        Me.cust_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cust_name.Location = New System.Drawing.Point(162, 136)
        Me.cust_name.Name = "cust_name"
        Me.cust_name.Size = New System.Drawing.Size(278, 20)
        Me.cust_name.TabIndex = 60
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.whse_code"))
        Me.TextBox2.Location = New System.Drawing.Point(112, 136)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(48, 20)
        Me.TextBox2.TabIndex = 58
        Me.TextBox2.Text = ""
        '
        'Comb_estado
        '
        Me.Comb_estado.AllowDefaultSort = True
        Me.Comb_estado.bound = True
        Me.Comb_estado.currValue = Nothing
        Me.Comb_estado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.fact_status"))
        Me.Comb_estado.DefaultWhereString = Nothing
        Me.Comb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Comb_estado.EditInitialValue = "2"
        Me.Comb_estado.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Comb_estado.FieldDescription = ""
        Me.Comb_estado.FindInitialValue = "2"
        Me.Comb_estado.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Comb_estado.IgnoreRequiered = False
        Me.Comb_estado.Items.AddRange(New Object() {"2-COBRADO", "0-ANULADO"})
        Me.Comb_estado.Location = New System.Drawing.Point(107, 256)
        Me.Comb_estado.LookupKeyDisplayFields = Nothing
        Me.Comb_estado.LookupKeyField = Nothing
        Me.Comb_estado.LookupTableName = Nothing
        Me.Comb_estado.Name = "Comb_estado"
        Me.Comb_estado.NewInitialValue = "2"
        Me.Comb_estado.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Comb_estado.Requiered = False
        Me.Comb_estado.Required = False
        Me.Comb_estado.Size = New System.Drawing.Size(184, 21)
        Me.Comb_estado.SqlString = Nothing
        Me.Comb_estado.StatusBarPanelDescripcion = Nothing
        Me.Comb_estado.TabIndex = 64
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Location = New System.Drawing.Point(58, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 16)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Estado:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'F608
        '
        Me.F608.Location = New System.Drawing.Point(248, 88)
        Me.F608.Name = "F608"
        Me.F608.Size = New System.Drawing.Size(208, 24)
        Me.F608.TabIndex = 65
        Me.F608.Text = "608 - Comprobantes Nulos"
        '
        'cbo_anio
        '
        Me.cbo_anio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_anio.Location = New System.Drawing.Point(464, 64)
        Me.cbo_anio.Name = "cbo_anio"
        Me.cbo_anio.Size = New System.Drawing.Size(121, 21)
        Me.cbo_anio.TabIndex = 66
        '
        'chklst_mes
        '
        Me.chklst_mes.CheckOnClick = True
        Me.chklst_mes.Location = New System.Drawing.Point(464, 88)
        Me.chklst_mes.Name = "chklst_mes"
        Me.chklst_mes.Size = New System.Drawing.Size(120, 184)
        Me.chklst_mes.TabIndex = 67
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(464, 272)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 16)
        Me.Button2.TabIndex = 68
        Me.Button2.Text = "Todos"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar2.Location = New System.Drawing.Point(0, 333)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(698, 23)
        Me.ProgressBar2.TabIndex = 70
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 304)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(696, 23)
        Me.ProgressBar1.TabIndex = 71
        '
        'rbt_abril2018
        '
        Me.rbt_abril2018.Checked = True
        Me.rbt_abril2018.Location = New System.Drawing.Point(8, 16)
        Me.rbt_abril2018.Name = "rbt_abril2018"
        Me.rbt_abril2018.Size = New System.Drawing.Size(128, 24)
        Me.rbt_abril2018.TabIndex = 72
        Me.rbt_abril2018.TabStop = True
        Me.rbt_abril2018.Text = "Antes Abril 2018"
        '
        'rbt_mayo2018
        '
        Me.rbt_mayo2018.Location = New System.Drawing.Point(8, 40)
        Me.rbt_mayo2018.Name = "rbt_mayo2018"
        Me.rbt_mayo2018.Size = New System.Drawing.Size(128, 24)
        Me.rbt_mayo2018.TabIndex = 72
        Me.rbt_mayo2018.Text = "Despues Abril 2018"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbt_abril2018)
        Me.GroupBox2.Controls.Add(Me.rbt_mayo2018)
        Me.GroupBox2.Location = New System.Drawing.Point(304, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(144, 80)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Formato"
        '
        'r_ptvfact04
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(698, 356)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.chklst_mes)
        Me.Controls.Add(Me.cbo_anio)
        Me.Controls.Add(Me.F608)
        Me.Controls.Add(Me.Comb_estado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LibXLookup3)
        Me.Controls.Add(Me.cust_name)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LibXCombo3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LibXCombo2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LibXCombo1)
        Me.Controls.Add(Me.Txt_Tipo_venta)
        Me.Controls.Add(Me.LibXLookup2)
        Me.Controls.Add(Me.Lblventa_name)
        Me.Controls.Add(Me.F607)
        Me.Controls.Add(Me.Txt_almacen)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LibXLookup1)
        Me.Controls.Add(Me.lblwhse_name)
        Me.Controls.Add(Me.txtwhse_code)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Fecha_Fin)
        Me.Controls.Add(Me.Fecha_Ini)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "r_ptvfact04"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Documentos"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Generar606Abril2018(ByVal erow As DataRow)
        Dim AxCrystalReport1 As LibX.ReportLib
        Dim Archivo As String
        Dim rnc As String
        Dim sPer As String

        Try
            Dim SelecStmt As String
            Dim sFechaDesde As String
            Dim sFechaHasta As String
            Dim sWhere As String
            Dim oTable As DataTable

            If Not IsNull(Fecha_Ini.Value) Then
                sFechaDesde = CDate(Fecha_Ini.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(Fecha_Fin.Value) Then
                sFechaHasta = CDate(Fecha_Fin.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If F607.Checked = True And Me.F608.Checked = False Then

                'If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                '    sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
                'ElseIf Trim(sFechaDesde) <> "" Then
                '    sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date = '", Trim(sFechaDesde), "'")
                'ElseIf Trim(sFechaHasta) <> "" Then
                '    sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date = '", Trim(sFechaHasta), "'")
                'End If


                ProgressBar2.Value = 0
                ProgressBar2.Minimum = 0
                ProgressBar2.Maximum = chklst_mes.Items.Count()
                r607 = New Excel.Application

                For Each mes As String In chklst_mes.Items
                    If chklst_mes.GetItemChecked(chklst_mes.Items.IndexOf(mes)) = True Then
                        sWhere = " 1=1 "
                        sWhere = String.Concat(sWhere, " and year(vw_ftdevnccc.fact_date) = ", cbo_anio.Text)
                        sWhere = String.Concat(sWhere, " and month(vw_ftdevnccc.fact_date) = ", mes)

                        SelecStmt = "SELECT  isnull(len(vw_ftdevnccc.rnc),0) as rnctype,vw_ftdevnccc.rnc,vw_ftdevnccc.fact_ncf,vw_ftdevnccc.aft_ncf," & _
                                " vw_ftdevnccc.fact_date, isnull(vw_ftdevnccc.itbis,0) as itbis," & _
                                " isnull(vw_ftdevnccc.fact_total,0) as fact_total," & _
                                " vw_ftdevnccc.descto , vw_ftdevnccc.fact_status,vw_ftdevnccc.ncf_type " & _
                                " FROM vw_ftdevnccc   "

                        SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                        SelecStmt = SelecStmt & " order by vw_ftdevnccc.fact_ncf "

                        oTable = LibX.Data.Manager.GetDataTable(SelecStmt)

                        If oTable Is Nothing Then
                            Throw New ApplicationException("No hay transacciones para este periodo")
                        End If

                        ProgressBar2.Value += 1
                        If oTable.Rows.Count > 0 Then
                            rnc = LibX.Data.Manager.GetScalar("select comp_rnc from stinform")
                            ''sPer = CDate(Fecha_Fin.Value).Year.ToString("0000") ''& CDate(Fecha_Fin.Value).Month.ToString("00")
                            sPer = cbo_anio.Text & Val(mes).ToString("00")

                            Archivo = System.Configuration.ConfigurationSettings.AppSettings.Get("Libxt607042018").ToString.Trim

                            Dim newCulture As System.Globalization.CultureInfo
                            Dim OldCulture As System.Globalization.CultureInfo

                            OldCulture = System.Threading.Thread.CurrentThread.CurrentCulture
                            newCulture = New System.Globalization.CultureInfo( _
                                r607.LanguageSettings.LanguageID(Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDUI))
                            System.Threading.Thread.CurrentThread.CurrentCulture = newCulture

                            Dim x607Open As Excel.Workbooks = r607.Workbooks
                            Dim x607Add As Excel.Workbook = x607Open.Open(Archivo)
                            Dim x607Read As Excel.Sheets = x607Add.Worksheets
                            Dim x607Wrhite As Excel.Worksheet = x607Read(1)
                            x607Wrhite.Unprotect("6b5b7b3b1b3b1")
                            x607Add.Unprotect("6b5b7b3b1b3b1")
                            Dim fecha As DateTime
                            Dim fechaPago As DateTime

                            x607Wrhite.Range("C4").Value = rnc.ToString.Trim
                            x607Wrhite.Range("C5").Value = sPer
                            x607Wrhite.Range("C6").Value = oTable.Rows.Count
                            Dim serv As Integer
                            Dim amountg As Decimal = 0
                            Dim linea As Integer = 12

                            For Each oRow As DataRow In oTable.Rows
                                If Not LibX.IsNull(oRow!fact_ncf) Then

                                    If oRow!rnctype <> 0 And oRow!rnc.ToString.Trim <> "000000000" Then
                                        x607Wrhite.Range("B" & linea).Value = oRow!rnc.ToString.Trim
                                    End If

                                    If (orow!ncf_type) = 2 Then
                                        x607Wrhite.Range("C" & linea).Value = 3
                                    Else
                                        Select Case oRow!rnctype
                                            'Case 0
                                            '    x607Wrhite.Range("C" & linea).Value = 3
                                        Case 9
                                                x607Wrhite.Range("C" & linea).Value = 1
                                            Case 11
                                                x607Wrhite.Range("C" & linea).Value = 2
                                        End Select
                                    End If

                                    x607Wrhite.Range("D" & linea).Value = oRow!fact_ncf.ToString.Trim
                                    x607Wrhite.Range("E" & linea).Value = oRow!aft_ncf.ToString.Trim

                                    If Not IsNull(oRow!fact_date) Then
                                        fecha = oRow!fact_date
                                    End If

                                    If LibX.IsNull(oRow!itbis) Then
                                        oRow!itbis = 0.0
                                    End If

                                    x607Wrhite.Range("F" & linea).Value = fecha.Year.ToString("0000") & fecha.Month.ToString("00") & fecha.Day.ToString("00")
                                    x607Wrhite.Range("G" & linea).Value = oRow!itbis
                                    x607Wrhite.Range("H" & linea).Value = oRow!fact_total
                                    amountg = amountg + oRow!fact_total
                                    linea = linea + 1
                                End If
                            Next
                            x607Wrhite.Range("C7").Value = amountg
                            r607.Visible = False
                            x607Wrhite.SaveAs("C:\F606\Herramienta de Envio Formato 607" & sPer & Now.Hour & Now.Minute & ".xls")
                            r607.Quit()
                        End If
                    End If
                Next

                r607 = Nothing

            Else
                If Me.F608.Checked = True And Me.F607.Checked = False Then
                    sWhere = " 1=1 "
                    If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                        sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
                    ElseIf Trim(sFechaDesde) <> "" Then
                        sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date = '", Trim(sFechaDesde), "'")
                    ElseIf Trim(sFechaHasta) <> "" Then
                        sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date = '", Trim(sFechaHasta), "'")
                    End If

                    sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_status = 0 ")

                    'SelecStmt = "SELECT  isnull(len(vw_ftdevnccc.rnc_id),0) as rnctype,vw_ftdevnccc.rnc_id,vw_ftdevnccc.fact_ncf,vw_ftdevol.fact_ncf as aft_ncf," & _
                    '            " vw_ftdevnccc.fact_date, isnull(vw_ftdevnccc.itbis,0) as itbis," & _
                    '            " case vw_ftdevnccc.moneda when 2 then (isnull(vw_ftdevnccc.fact_total,0)*vw_ftdevnccc.fact_tasa) else isnull(vw_ftdevnccc.fact_total,0) end fact_total," & _
                    '            " vw_ftdevnccc.descto , vw_ftdevnccc.fact_status,vw_ftdevnccc.moneda " & _
                    '            " FROM vw_ftdevnccc   inner join ivtypem on vw_ftdevnccc.type_code = ivtypem.type_code " & _
                    '            " left join  vw_ftdevol on (vw_ftdevnccc.ftserial_afect =  vw_ftdevol.ftserial_no " & _
                    '            " or vw_ftdevnccc.factafet_no =  vw_ftdevol.fact_number ) " & _
                    '            " and  vw_ftdevnccc.cust_code=  vw_ftdevol.cust_code "

                    SelecStmt = "SELECT  isnull(len(vw_ftdevnccc.rnc),0) as rnctype,vw_ftdevnccc.rnc,vw_ftdevnccc.fact_ncf,vw_ftdevnccc.aft_ncf," & _
                        " vw_ftdevnccc.fact_date, isnull(vw_ftdevnccc.itbis,0) as itbis," & _
                        " isnull(vw_ftdevnccc.fact_total,0) as fact_total," & _
                        " vw_ftdevnccc.descto , vw_ftdevnccc.fact_status,vw_ftdevnccc.ncf_type " & _
                        " FROM vw_ftdevnccc   "

                    SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                    SelecStmt = SelecStmt & " order by vw_ftdevnccc.fact_ncf "

                    oTable = LibX.Data.Manager.GetDataTable(SelecStmt)

                    If oTable Is Nothing Then
                        Throw New ApplicationException("No hay transacciones para este periodo")
                    End If

                    rnc = LibX.Data.Manager.GetScalar("select comp_rnc from stinform")
                    sPer = CDate(Fecha_Fin.Value).Year.ToString("0000") ''& CDate(Fecha_Fin.Value).Month.ToString("00")

                    ''r607 = New Excel.Application
                    Archivo = System.Configuration.ConfigurationSettings.AppSettings.Get("Libxt608042018").ToString.Trim
                    Dim newCulture As System.Globalization.CultureInfo
                    Dim OldCulture As System.Globalization.CultureInfo

                    OldCulture = System.Threading.Thread.CurrentThread.CurrentCulture
                    newCulture = New System.Globalization.CultureInfo( _
                        r607.LanguageSettings.LanguageID(Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDUI))
                    System.Threading.Thread.CurrentThread.CurrentCulture = newCulture

                    Dim x607Open As Excel.Workbooks = r607.Workbooks
                    Dim x607Add As Excel.Workbook = x607Open.Open(Archivo)
                    Dim x607Read As Excel.Sheets = x607Add.Worksheets
                    Dim x607Wrhite As Excel.Worksheet = x607Read(1)
                    'x607Wrhite.Unprotect("6b5b7b3b1b3b1")
                    'x607Add.Unprotect("6b5b7b3b1b3b1")
                    Dim fecha As DateTime
                    Dim fechaPago As DateTime

                    x607Wrhite.Range("C5").Value = rnc.ToString.Trim
                    x607Wrhite.Range("C6").Value = sPer
                    x607Wrhite.Range("C7").Value = oTable.Rows.Count
                    Dim linea As Integer = 12
                    Dim serv As Integer
                    Dim amountg As Decimal

                    For Each oRow As DataRow In oTable.Rows
                        If Not LibX.IsNull(oRow!fact_ncf) Then
                            If Not IsNull(oRow!fact_date) Then
                                fecha = oRow!fact_date
                            End If
                            x607Wrhite.Range("B" & linea).Value = oRow!fact_ncf.ToString.Trim
                            x607Wrhite.Range("D" & linea).Value = fecha.Year.ToString("0000") & fecha.Month.ToString("00") & fecha.Day.ToString("00")
                            x607Wrhite.Range("E" & linea).Value = "01"
                            x607Wrhite.Range("F" & linea).Value = 0
                        End If
                        linea = linea + 1
                    Next
                    r607.Visible = True
                    x607Wrhite.SaveAs("C:\F606\Herramienta de Envio Formato 608" & sPer & Now.Hour & Now.Minute & ".xls")
                Else
                    If Me.F608.Checked = False And Me.F607.Checked = False Then
                        AxCrystalReport1 = New ReportLib("PTV", "r_pvfact04.rpt")

                        With AxCrystalReport1
                            sWhere = " 1=1 "

                            If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                                sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
                            ElseIf Trim(sFechaDesde) <> "" Then
                                sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date = '", Trim(sFechaDesde), "'")
                            ElseIf Trim(sFechaHasta) <> "" Then
                                sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date = '", Trim(sFechaHasta), "'")
                            End If

                            If erow!vend_code.ToString.Trim <> "" Then
                                sWhere = String.Concat(sWhere, " and vw_ftdevnccc.vend_code = ", erow!vend_code.ToString)
                            End If

                            If erow!type_code.ToString.Trim <> "" Then
                                sWhere = String.Concat(sWhere, " and vw_ftdevnccc.type_code = '", erow!type_code.ToString & "'")
                            End If

                            If erow!moneda.ToString.Trim <> "" Then
                                sWhere = String.Concat(sWhere, " and vw_ftdevnccc.moneda = '", erow!moneda.ToString & "'")
                            End If

                            If erow!fact_ncf.ToString.Trim <> "" Then
                                sWhere = String.Concat(sWhere, " and substring(vw_ftdevnccc.fact_ncf,10,2) = '", erow!fact_ncf.ToString & "'")
                            End If
                            If erow!fact_cond.ToString.Trim <> "" Then
                                sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_cond = ", erow!fact_cond.ToString)
                            End If
                            If Not IsNull(erow!cust_code) Then
                                sWhere = String.Concat(sWhere, " and vw_ftdevnccc.cust_code = ", erow!cust_code.ToString)
                            End If
                            If erow!fact_status.ToString.Trim <> "" Then
                                If erow!fact_status.ToString.Trim = 2 Then
                                    sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_status <> 0 ")
                                Else
                                    sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_status = ", erow!fact_status.ToString)
                                End If
                            End If


                            .ParameterFields(0) = String.Concat("Fecha_Ini;", Trim(sFechaDesde), ";TRUE")
                            .ParameterFields(1) = String.Concat("Fecha_Fin;", Trim(sFechaHasta), ";TRUE")

                            '// Recibir el SQL Query
                            .RetrieveSQLQuery()
                            SelecStmt = .SQLQuery
                            SelecStmt = LibX.MdlUtil.ReplaceWherePart(SelecStmt, sWhere)
                            'SelecStmt = oDoc.PrepareSelectStmt(SelecStmt)

                            .SQLQuery = SelecStmt

                            '// Ejecutar el reporte
                            .Action = 1
                        End With
                    End If
                End If
            End If
        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim AxCrystalReport1 As LibX.ReportLib
        Dim Archivo As String
        Dim rnc As String
        Dim sPer As String

        Try
            If rbt_mayo2018.Checked Then
                Generar606Mayo2018(e.row)
            Else
                Generar606Abril2018(e.row)
            End If

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Me.LibXConnector1.AcceptFind()
        Me.LibXConnector1.Find()
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        If Me.LibXConnector1.IsEditing Then
            Me.LibXConnector1.Cancel()
        End If
        Me.LibXConnector1.Find()
    End Sub

    Private Sub r_ftfact10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LibXConnector1.Find()
        oDoc = New SGT.Facturacion.Entidades.Documento

        WhDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxWhDefault")

        Dim intAnio As Int16 = 1998
        Dim intAnio1 As Int16 = 1998

        cbo_anio.Items.Clear()

        For intAnio1 = DateTime.Now.Year To intAnio Step -1
            cbo_anio.Items.Add(intAnio1.ToString("####"))
        Next

        For intAnio = 1 To 12
            chklst_mes.Items.Add(intAnio.ToString())
        Next

    End Sub

    Private Sub F607_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F607.CheckedChanged
        If Me.F607.Checked = True Then
            Me.F608.Checked = False
            Me.Comb_estado.SelectedValue = 2
        End If
    End Sub

    Private Sub F608_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F608.CheckedChanged
        If Me.F608.Checked = True Then
            Me.F607.Checked = False
            Me.Comb_estado.SelectedValue = 0
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For item As Integer = 0 To chklst_mes.Items.Count - 1
            chklst_mes.SetItemChecked(item, True)
        Next

    End Sub

    Private Sub Generar606Mayo2018(ByVal erow As DataRow)
        Dim AxCrystalReport1 As LibX.ReportLib
        Dim Archivo As String
        Dim rnc As String
        Dim sPer As String

        Try
            Dim SelecStmt As String
            Dim sFechaDesde As String
            Dim sFechaHasta As String
            Dim sWhere As String
            Dim oTable As DataTable

            If Not IsNull(Fecha_Ini.Value) Then
                sFechaDesde = CDate(Fecha_Ini.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(Fecha_Fin.Value) Then
                sFechaHasta = CDate(Fecha_Fin.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If F607.Checked = True And Me.F608.Checked = False Then

                'If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                '    sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
                'ElseIf Trim(sFechaDesde) <> "" Then
                '    sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date = '", Trim(sFechaDesde), "'")
                'ElseIf Trim(sFechaHasta) <> "" Then
                '    sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date = '", Trim(sFechaHasta), "'")
                'End If


                ProgressBar2.Value = 0
                ProgressBar2.Minimum = 0
                ProgressBar2.Maximum = chklst_mes.Items.Count()
                r607 = New Excel.Application

                For Each mes As String In chklst_mes.Items
                    If chklst_mes.GetItemChecked(chklst_mes.Items.IndexOf(mes)) = True Then
                        sWhere = " 1=1 "
                        sWhere = String.Concat(sWhere, " and year(vw_ftdevnccc.fact_date) = ", cbo_anio.Text)
                        sWhere = String.Concat(sWhere, " and month(vw_ftdevnccc.fact_date) = ", mes)

                        SelecStmt = "SELECT  * FROM vw_ftdevnccc   "

                        SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                        SelecStmt = SelecStmt & " order by vw_ftdevnccc.fact_ncf "

                        oTable = LibX.Data.Manager.GetDataTable(SelecStmt)

                        If oTable Is Nothing Then
                            Throw New ApplicationException("No hay transacciones para este periodo")
                        End If

                        ProgressBar2.Value += 1
                        If oTable.Rows.Count > 0 Then
                            rnc = LibX.Data.Manager.GetScalar("select comp_rnc from stinform")
                            ''sPer = CDate(Fecha_Fin.Value).Year.ToString("0000") ''& CDate(Fecha_Fin.Value).Month.ToString("00")
                            sPer = cbo_anio.Text & Val(mes).ToString("00")

                            Archivo = System.Configuration.ConfigurationSettings.AppSettings.Get("Libxt607052018").ToString.Trim

                            Dim newCulture As System.Globalization.CultureInfo
                            Dim OldCulture As System.Globalization.CultureInfo

                            OldCulture = System.Threading.Thread.CurrentThread.CurrentCulture
                            newCulture = New System.Globalization.CultureInfo( _
                                r607.LanguageSettings.LanguageID(Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDUI))
                            System.Threading.Thread.CurrentThread.CurrentCulture = newCulture

                            Dim x607Open As Excel.Workbooks = r607.Workbooks
                            Dim x607Add As Excel.Workbook = x607Open.Open(Archivo)
                            Dim x607Read As Excel.Sheets = x607Add.Worksheets
                            Dim x607Wrhite As Excel.Worksheet = x607Read(1)
                            x607Wrhite.Unprotect("6b5b7b3b1b3b1")
                            x607Add.Unprotect("6b5b7b3b1b3b1")
                            Dim fecha As DateTime
                            Dim fechaPago As DateTime

                            '// ENCABEZADO
                            x607Wrhite.Range("C4").Value = rnc.ToString.Trim '// RNC
                            x607Wrhite.Range("C5").Value = sPer              '// periodo
                            x607Wrhite.Range("C6").Value = oTable.Rows.Count '// cantidad

                            Dim serv As Integer
                            Dim amountg As Decimal = 0
                            Dim linea As Integer = 12

                            ProgressBar1.Maximum = oTable.Rows.Count
                            ProgressBar1.Minimum = 0
                            ProgressBar1.Value = 0

                            For Each oRow As DataRow In oTable.Rows

                                ProgressBar1.Value += 1

                                If Not LibX.IsNull(oRow!fact_ncf) Then

                                    '// RNC DE LA EMPRESA
                                    If oRow!rnc.Tostring() <> "0" Then
                                        x607Wrhite.Range("B" & linea).Value = oRow!rnc.ToString.Trim
                                    End If

                                    '// TIPO COMPROBANTE
                                    If (orow!ncf_type) = 2 Then
                                        x607Wrhite.Range("C" & linea).Value = 3
                                    Else
                                        Select Case oRow!rnc.ToString().Trim().Length()

                                            Case 0
                                                x607Wrhite.Range("C" & linea).Value = 3 '// pasaporte u otros

                                            Case 9
                                                x607Wrhite.Range("C" & linea).Value = 1 '// RNC

                                            Case 11
                                                x607Wrhite.Range("C" & linea).Value = 2 '// Cedula

                                            Case oRow!rnc.ToString().Trim() = "000000000"
                                                x607Wrhite.Range("C" & linea).Value = 3

                                        End Select
                                    End If

                                    '// COMPROBANTE FISCAL
                                    x607Wrhite.Range("D" & linea).Value = oRow!fact_ncf.ToString.Trim

                                    '// COMPROBANTE MODIFICADO
                                    x607Wrhite.Range("E" & linea).Value = oRow!aft_ncf.ToString.Trim

                                    If Not IsNull(oRow!fact_date) Then
                                        fecha = oRow!fact_date
                                    End If

                                    If LibX.IsNull(oRow!itbis) Then
                                        oRow!itbis = 0.0
                                    End If


                                    '// TIPO INGRESO
                                    x607Wrhite.Range("F" & linea).Value = oRow!tipo_ingreso.ToString()
                                    '// FECHA COMPROBANTE
                                    x607Wrhite.Range("G" & linea).Value = fecha.Year.ToString("0000") & fecha.Month.ToString("00") & fecha.Day.ToString("00")

                                    '// FECHA RETENCION
                                    '//x607Wrhite.Range("H" & linea).Value = fecha.Year.ToString("0000") & fecha.Month.ToString("00") & fecha.Day.ToString("00")

                                    '// MONTO FACTURADO
                                    x607Wrhite.Range("I" & linea).Value = oRow!fact_total

                                    '// ITBIS FACTURADO
                                    x607Wrhite.Range("J" & linea).Value = oRow!itbis

                                    '// ITBIS RETENIDO POR TERCEROS
                                    x607Wrhite.Range("K" & linea).Value = oRow!itbis

                                    '// EFECTIVO
                                    x607Wrhite.Range("R" & linea).Value = oRow!efectivo

                                    '// CHEQUE O TRANSFERENCIA
                                    x607Wrhite.Range("S" & linea).Value = oRow!cheque

                                    '// TARJETA
                                    x607Wrhite.Range("T" & linea).Value = oRow!tarjeta

                                    '// CREDITO
                                    x607Wrhite.Range("U" & linea).Value = oRow!credito

                                    amountg = amountg + oRow!fact_total
                                    linea = linea + 1
                                End If
                            Next
                            x607Wrhite.Range("C7").Value = amountg
                            r607.Visible = False
                            x607Wrhite.SaveAs("C:\F606\Herramienta de Envio Formato 607" & sPer & Now.Hour & Now.Minute & ".xls")
                            r607.Quit()
                        End If
                    End If
                Next

                r607 = Nothing

            Else
                If Me.F608.Checked = True And Me.F607.Checked = False Then
                    sWhere = " 1=1 "
                    If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                        sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
                    ElseIf Trim(sFechaDesde) <> "" Then
                        sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date = '", Trim(sFechaDesde), "'")
                    ElseIf Trim(sFechaHasta) <> "" Then
                        sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date = '", Trim(sFechaHasta), "'")
                    End If

                    sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_status = 0 ")

                    'SelecStmt = "SELECT  isnull(len(vw_ftdevnccc.rnc_id),0) as rnctype,vw_ftdevnccc.rnc_id,vw_ftdevnccc.fact_ncf,vw_ftdevol.fact_ncf as aft_ncf," & _
                    '            " vw_ftdevnccc.fact_date, isnull(vw_ftdevnccc.itbis,0) as itbis," & _
                    '            " case vw_ftdevnccc.moneda when 2 then (isnull(vw_ftdevnccc.fact_total,0)*vw_ftdevnccc.fact_tasa) else isnull(vw_ftdevnccc.fact_total,0) end fact_total," & _
                    '            " vw_ftdevnccc.descto , vw_ftdevnccc.fact_status,vw_ftdevnccc.moneda " & _
                    '            " FROM vw_ftdevnccc   inner join ivtypem on vw_ftdevnccc.type_code = ivtypem.type_code " & _
                    '            " left join  vw_ftdevol on (vw_ftdevnccc.ftserial_afect =  vw_ftdevol.ftserial_no " & _
                    '            " or vw_ftdevnccc.factafet_no =  vw_ftdevol.fact_number ) " & _
                    '            " and  vw_ftdevnccc.cust_code=  vw_ftdevol.cust_code "

                    SelecStmt = "SELECT  isnull(len(vw_ftdevnccc.rnc),0) as rnctype,vw_ftdevnccc.rnc,vw_ftdevnccc.fact_ncf,vw_ftdevnccc.aft_ncf," & _
                        " vw_ftdevnccc.fact_date, isnull(vw_ftdevnccc.itbis,0) as itbis," & _
                        " isnull(vw_ftdevnccc.fact_total,0) as fact_total," & _
                        " vw_ftdevnccc.descto , vw_ftdevnccc.fact_status,vw_ftdevnccc.ncf_type " & _
                        " FROM vw_ftdevnccc   "

                    SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                    SelecStmt = SelecStmt & " order by vw_ftdevnccc.fact_ncf "

                    oTable = LibX.Data.Manager.GetDataTable(SelecStmt)

                    If oTable Is Nothing Then
                        Throw New ApplicationException("No hay transacciones para este periodo")
                    End If

                    rnc = LibX.Data.Manager.GetScalar("select comp_rnc from stinform")
                    sPer = CDate(Fecha_Fin.Value).Year.ToString("0000") ''& CDate(Fecha_Fin.Value).Month.ToString("00")

                    ''r607 = New Excel.Application
                    Archivo = System.Configuration.ConfigurationSettings.AppSettings.Get("Libxt608052018").ToString.Trim
                    Dim newCulture As System.Globalization.CultureInfo
                    Dim OldCulture As System.Globalization.CultureInfo

                    OldCulture = System.Threading.Thread.CurrentThread.CurrentCulture
                    newCulture = New System.Globalization.CultureInfo( _
                        r607.LanguageSettings.LanguageID(Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDUI))
                    System.Threading.Thread.CurrentThread.CurrentCulture = newCulture

                    Dim x607Open As Excel.Workbooks = r607.Workbooks
                    Dim x607Add As Excel.Workbook = x607Open.Open(Archivo)
                    Dim x607Read As Excel.Sheets = x607Add.Worksheets
                    Dim x607Wrhite As Excel.Worksheet = x607Read(1)
                    'x607Wrhite.Unprotect("6b5b7b3b1b3b1")
                    'x607Add.Unprotect("6b5b7b3b1b3b1")
                    Dim fecha As DateTime
                    Dim fechaPago As DateTime

                    x607Wrhite.Range("C5").Value = rnc.ToString.Trim
                    x607Wrhite.Range("C6").Value = sPer
                    x607Wrhite.Range("C7").Value = oTable.Rows.Count
                    Dim linea As Integer = 12
                    Dim serv As Integer
                    Dim amountg As Decimal

                    For Each oRow As DataRow In oTable.Rows
                        If Not LibX.IsNull(oRow!fact_ncf) Then
                            If Not IsNull(oRow!fact_date) Then
                                fecha = oRow!fact_date
                            End If
                            x607Wrhite.Range("B" & linea).Value = oRow!fact_ncf.ToString.Trim
                            x607Wrhite.Range("D" & linea).Value = fecha.Year.ToString("0000") & fecha.Month.ToString("00") & fecha.Day.ToString("00")
                            x607Wrhite.Range("E" & linea).Value = "01"
                            x607Wrhite.Range("F" & linea).Value = 0
                        End If
                        linea = linea + 1
                    Next
                    r607.Visible = True
                    x607Wrhite.SaveAs("C:\F606\Herramienta de Envio Formato 608" & sPer & Now.Hour & Now.Minute & ".xls")
                Else
                    If Me.F608.Checked = False And Me.F607.Checked = False Then
                        AxCrystalReport1 = New ReportLib("PTV", "r_pvfact04.rpt")

                        With AxCrystalReport1
                            sWhere = " 1=1 "

                            If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                                sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
                            ElseIf Trim(sFechaDesde) <> "" Then
                                sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date = '", Trim(sFechaDesde), "'")
                            ElseIf Trim(sFechaHasta) <> "" Then
                                sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_date = '", Trim(sFechaHasta), "'")
                            End If

                            If erow!vend_code.ToString.Trim <> "" Then
                                sWhere = String.Concat(sWhere, " and vw_ftdevnccc.vend_code = ", erow!vend_code.ToString)
                            End If

                            If erow!type_code.ToString.Trim <> "" Then
                                sWhere = String.Concat(sWhere, " and vw_ftdevnccc.type_code = '", erow!type_code.ToString & "'")
                            End If

                            If erow!moneda.ToString.Trim <> "" Then
                                sWhere = String.Concat(sWhere, " and vw_ftdevnccc.moneda = '", erow!moneda.ToString & "'")
                            End If

                            If erow!fact_ncf.ToString.Trim <> "" Then
                                sWhere = String.Concat(sWhere, " and substring(vw_ftdevnccc.fact_ncf,10,2) = '", erow!fact_ncf.ToString & "'")
                            End If
                            If erow!fact_cond.ToString.Trim <> "" Then
                                sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_cond = ", erow!fact_cond.ToString)
                            End If
                            If Not IsNull(erow!cust_code) Then
                                sWhere = String.Concat(sWhere, " and vw_ftdevnccc.cust_code = ", erow!cust_code.ToString)
                            End If
                            If erow!fact_status.ToString.Trim <> "" Then
                                If erow!fact_status.ToString.Trim = 2 Then
                                    sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_status <> 0 ")
                                Else
                                    sWhere = String.Concat(sWhere, " and vw_ftdevnccc.fact_status = ", erow!fact_status.ToString)
                                End If
                            End If


                            .ParameterFields(0) = String.Concat("Fecha_Ini;", Trim(sFechaDesde), ";TRUE")
                            .ParameterFields(1) = String.Concat("Fecha_Fin;", Trim(sFechaHasta), ";TRUE")

                            '// Recibir el SQL Query
                            .RetrieveSQLQuery()
                            SelecStmt = .SQLQuery
                            SelecStmt = LibX.MdlUtil.ReplaceWherePart(SelecStmt, sWhere)
                            'SelecStmt = oDoc.PrepareSelectStmt(SelecStmt)

                            .SQLQuery = SelecStmt

                            '// Ejecutar el reporte
                            .Action = 1
                        End With
                    End If
                End If
            End If
        Catch ex As Exception
            Log.Add(ex, True)
        End Try
    End Sub
End Class
