Imports LibX
Public Class r_ptvfactncf02
    Inherits System.Windows.Forms.Form
    Dim WhDefault As Integer
    Dim oDoc As SGT.Facturacion.Entidades.Documento
    Dim sFechaDesde As String
    Dim sFechaHasta As String
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Fecha_Fin As LibX.LibxDateTimePicker
    Friend WithEvents Fecha_Ini As LibX.LibxDateTimePicker
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents LibXLookup4 As LibX.LibXLookup
    Friend WithEvents LibXLookup5 As LibX.LibXLookup
    Friend WithEvents caja_name As System.Windows.Forms.Label
    Friend WithEvents cajera_name As System.Windows.Forms.Label
    Friend WithEvents Chk_resumen As System.Windows.Forms.CheckBox
    Friend WithEvents venta_name As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblNcf As System.Windows.Forms.Label
    Friend WithEvents LibXLookup6 As LibX.LibXLookup
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
    Friend WithEvents Txt_tipo As System.Windows.Forms.TextBox
    Friend WithEvents Txt_caja As System.Windows.Forms.TextBox
    Friend WithEvents Txt_cajero As System.Windows.Forms.TextBox
    Friend WithEvents Txt_ncf As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents repventan As System.Data.DataTable
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
    Friend WithEvents DataColumn44 As System.Data.DataColumn
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
        Me.Label8 = New System.Windows.Forms.Label
        Me.Chk_resumen = New System.Windows.Forms.CheckBox
        Me.Txt_tipo = New System.Windows.Forms.TextBox
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.venta_name = New System.Windows.Forms.Label
        Me.Txt_caja = New System.Windows.Forms.TextBox
        Me.LibXLookup4 = New LibX.LibXLookup
        Me.caja_name = New System.Windows.Forms.Label
        Me.Txt_cajero = New System.Windows.Forms.TextBox
        Me.LibXLookup5 = New LibX.LibXLookup
        Me.cajera_name = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Txt_ncf = New System.Windows.Forms.TextBox
        Me.LblNcf = New System.Windows.Forms.Label
        Me.LibXLookup6 = New LibX.LibXLookup
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.repventan = New System.Data.DataTable
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
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.repventan, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXConnector1.DataMember = "repventav1"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable3})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.repventan})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn8}
        Me.DataTable1.TableName = "repventav1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "fecha_ini"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "fecha_fin"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "whse_code"
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "ncf_type"
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "type_code"
        Me.DataColumn5.MaxLength = 3
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "caja_code"
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "caje_code"
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "ftserial_no"
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
        Me.DataColumn10.ColumnName = "fact_inddomicilio"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "fact_number"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "fact_ncf"
        Me.DataColumn12.MaxLength = 40
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "bus_name"
        Me.DataColumn13.MaxLength = 100
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "cust_name"
        Me.DataColumn14.MaxLength = 100
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "rnc_id"
        Me.DataColumn15.MaxLength = 15
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "custname"
        Me.DataColumn16.MaxLength = 100
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "cust_rnc"
        Me.DataColumn17.MaxLength = 20
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "definicion"
        Me.DataColumn18.MaxLength = 40
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "fact_total"
        Me.DataColumn19.DataType = GetType(System.Decimal)
        Me.DataColumn19.ReadOnly = True
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "dscto"
        Me.DataColumn20.DataType = GetType(System.Decimal)
        Me.DataColumn20.ReadOnly = True
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "itbis"
        Me.DataColumn21.DataType = GetType(System.Decimal)
        Me.DataColumn21.ReadOnly = True
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "efectivo"
        Me.DataColumn22.DataType = GetType(System.Decimal)
        Me.DataColumn22.ReadOnly = True
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "tarjeta"
        Me.DataColumn23.DataType = GetType(System.Decimal)
        Me.DataColumn23.ReadOnly = True
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "credito"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        Me.DataColumn24.ReadOnly = True
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "notacredito"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        Me.DataColumn25.ReadOnly = True
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "cheque"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        Me.DataColumn26.ReadOnly = True
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "seguro"
        Me.DataColumn27.DataType = GetType(System.Decimal)
        Me.DataColumn27.ReadOnly = True
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "cust_code"
        Me.DataColumn28.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.TableName = "repventav1"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(4, 64)
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
        Me.Label2.Location = New System.Drawing.Point(11, 88)
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
        Me.GroupBox1.Location = New System.Drawing.Point(432, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 152)
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
        Me.Label5.Size = New System.Drawing.Size(538, 48)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "RESUMEN DE VENTAS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtwhse_code
        '
        Me.txtwhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "repventav1.whse_code"))
        Me.txtwhse_code.Location = New System.Drawing.Point(88, 112)
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
        Me.Label4.Location = New System.Drawing.Point(23, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Almacen:"
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
        Me.LibXLookup1.DestParameters = New String() {"whse_code=whse_code", "lblwhse_name=whse_name"}
        Me.LibXLookup1.Enabled = False
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(384, 112)
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
        Me.LibXLookup1.SrcParameters = New String() {"whse_code=whse_code"}
        Me.LibXLookup1.TabIndex = 3
        Me.LibXLookup1.TableName = "ivwhsem"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'lblwhse_name
        '
        Me.lblwhse_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblwhse_name.Location = New System.Drawing.Point(144, 112)
        Me.lblwhse_name.Name = "lblwhse_name"
        Me.lblwhse_name.Size = New System.Drawing.Size(240, 20)
        Me.lblwhse_name.TabIndex = 19
        '
        'Txt_almacen
        '
        Me.Txt_almacen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "repventav1.whse_code"))
        Me.Txt_almacen.Location = New System.Drawing.Point(88, 112)
        Me.Txt_almacen.Name = "Txt_almacen"
        Me.Txt_almacen.Size = New System.Drawing.Size(56, 20)
        Me.Txt_almacen.TabIndex = 38
        Me.Txt_almacen.Text = ""
        '
        'Fecha_Fin
        '
        Me.Fecha_Fin.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_Fin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "repventav1.fecha_fin"))
        Me.Fecha_Fin.EditInitialValue = Nothing
        Me.Fecha_Fin.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Fin.FieldDescription = ""
        Me.Fecha_Fin.FindInitialValue = ""
        Me.Fecha_Fin.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha_Fin.IgnoreRequiered = False
        Me.Fecha_Fin.Location = New System.Drawing.Point(88, 88)
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
        Me.Fecha_Ini.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "repventav1.fecha_ini"))
        Me.Fecha_Ini.EditInitialValue = ""
        Me.Fecha_Ini.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Ini.FieldDescription = ""
        Me.Fecha_Ini.FindInitialValue = ""
        Me.Fecha_Ini.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Ini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha_Ini.IgnoreRequiered = False
        Me.Fecha_Ini.Location = New System.Drawing.Point(88, 64)
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
        Me.Label7.Location = New System.Drawing.Point(40, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Caja.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(9, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Tipo Venta.:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(30, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Cajero.:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chk_resumen
        '
        Me.Chk_resumen.Checked = True
        Me.Chk_resumen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_resumen.Location = New System.Drawing.Point(249, 62)
        Me.Chk_resumen.Name = "Chk_resumen"
        Me.Chk_resumen.Size = New System.Drawing.Size(120, 24)
        Me.Chk_resumen.TabIndex = 39
        Me.Chk_resumen.Text = "Resumido x Dia"
        '
        'Txt_tipo
        '
        Me.Txt_tipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "repventav1.type_code"))
        Me.Txt_tipo.Location = New System.Drawing.Point(88, 161)
        Me.Txt_tipo.Name = "Txt_tipo"
        Me.Txt_tipo.Size = New System.Drawing.Size(56, 20)
        Me.Txt_tipo.TabIndex = 43
        Me.Txt_tipo.Text = ""
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"type_code=type_code", "venta_name=type_name"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(384, 161)
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
        Me.LibXLookup2.WhereCondition = "type_code in ('FPV','FSG','DEV')"
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'venta_name
        '
        Me.venta_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.venta_name.Location = New System.Drawing.Point(144, 161)
        Me.venta_name.Name = "venta_name"
        Me.venta_name.Size = New System.Drawing.Size(240, 20)
        Me.venta_name.TabIndex = 42
        '
        'Txt_caja
        '
        Me.Txt_caja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "repventav1.caja_code"))
        Me.Txt_caja.Location = New System.Drawing.Point(88, 185)
        Me.Txt_caja.Name = "Txt_caja"
        Me.Txt_caja.Size = New System.Drawing.Size(56, 20)
        Me.Txt_caja.TabIndex = 49
        Me.Txt_caja.Text = ""
        '
        'LibXLookup4
        '
        Me.LibXLookup4.AlternateFieldSearch = Nothing
        Me.LibXLookup4.BeginCheck = False
        Me.LibXLookup4.CheckText = Nothing
        Me.LibXLookup4.ComboMode = False
        Me.LibXLookup4.DataMember = Nothing
        Me.LibXLookup4.DataSource = Me.LibXConnector1
        Me.LibXLookup4.DestParameters = New String() {"caja_code=caja_code", "caja_name=caja_name"}
        Me.LibXLookup4.FilterField = Nothing
        Me.LibXLookup4.IgnoreFindInBrowseMode = False
        Me.LibXLookup4.isCanceled = False
        Me.LibXLookup4.Location = New System.Drawing.Point(384, 185)
        Me.LibXLookup4.LookCaption = "Caja"
        Me.LibXLookup4.Name = "LibXLookup4"
        Me.LibXLookup4.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup4.ShowFilter = True
        Me.LibXLookup4.ShowMessageNotFound = True
        Me.LibXLookup4.ShowWarning = False
        Me.LibXLookup4.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup4.SizesColumns = Nothing
        Me.LibXLookup4.SizesColumnsTab = Nothing
        Me.LibXLookup4.SqlString = Nothing
        Me.LibXLookup4.SQLTab = Nothing
        Me.LibXLookup4.SrcParameters = New String() {"caja_code=caja_code"}
        Me.LibXLookup4.TabIndex = 47
        Me.LibXLookup4.TableName = "cjcajam"
        Me.LibXLookup4.TabStop = False
        Me.LibXLookup4.UseCopyConnection = False
        Me.LibXLookup4.UseRowRetrieveEvents = False
        Me.LibXLookup4.UseTab = False
        Me.LibXLookup4.VisParameters = New String() {"Código=caja_code", "Descripción=caja_name"}
        Me.LibXLookup4.WhereCondition = Nothing
        Me.LibXLookup4.WhereParameters = Nothing
        '
        'caja_name
        '
        Me.caja_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.caja_name.Location = New System.Drawing.Point(144, 185)
        Me.caja_name.Name = "caja_name"
        Me.caja_name.Size = New System.Drawing.Size(240, 20)
        Me.caja_name.TabIndex = 48
        '
        'Txt_cajero
        '
        Me.Txt_cajero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "repventav1.caje_code"))
        Me.Txt_cajero.Location = New System.Drawing.Point(88, 209)
        Me.Txt_cajero.Name = "Txt_cajero"
        Me.Txt_cajero.Size = New System.Drawing.Size(56, 20)
        Me.Txt_cajero.TabIndex = 52
        Me.Txt_cajero.Text = ""
        '
        'LibXLookup5
        '
        Me.LibXLookup5.AlternateFieldSearch = Nothing
        Me.LibXLookup5.BeginCheck = False
        Me.LibXLookup5.CheckText = Nothing
        Me.LibXLookup5.ComboMode = False
        Me.LibXLookup5.DataMember = Nothing
        Me.LibXLookup5.DataSource = Me.LibXConnector1
        Me.LibXLookup5.DestParameters = New String() {"caje_code=vend_code", "cajera_name=vend_name"}
        Me.LibXLookup5.FilterField = Nothing
        Me.LibXLookup5.IgnoreFindInBrowseMode = False
        Me.LibXLookup5.isCanceled = False
        Me.LibXLookup5.Location = New System.Drawing.Point(384, 209)
        Me.LibXLookup5.LookCaption = Nothing
        Me.LibXLookup5.Name = "LibXLookup5"
        Me.LibXLookup5.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup5.ShowFilter = True
        Me.LibXLookup5.ShowMessageNotFound = True
        Me.LibXLookup5.ShowWarning = False
        Me.LibXLookup5.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup5.SizesColumns = Nothing
        Me.LibXLookup5.SizesColumnsTab = Nothing
        Me.LibXLookup5.SqlString = Nothing
        Me.LibXLookup5.SQLTab = Nothing
        Me.LibXLookup5.SrcParameters = New String() {"caje_code=vend_code"}
        Me.LibXLookup5.TabIndex = 50
        Me.LibXLookup5.TableName = "ftvendm"
        Me.LibXLookup5.TabStop = False
        Me.LibXLookup5.UseCopyConnection = False
        Me.LibXLookup5.UseRowRetrieveEvents = False
        Me.LibXLookup5.UseTab = False
        Me.LibXLookup5.VisParameters = New String() {"Código=vend_code", "Descripción=vend_name"}
        Me.LibXLookup5.WhereCondition = "vend_cargo = 1"
        Me.LibXLookup5.WhereParameters = Nothing
        '
        'cajera_name
        '
        Me.cajera_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cajera_name.Location = New System.Drawing.Point(144, 209)
        Me.cajera_name.Name = "cajera_name"
        Me.cajera_name.Size = New System.Drawing.Size(240, 20)
        Me.cajera_name.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(17, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "tipo de ncf:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt_ncf
        '
        Me.Txt_ncf.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "repventav1.ncf_type"))
        Me.Txt_ncf.Location = New System.Drawing.Point(88, 136)
        Me.Txt_ncf.Name = "Txt_ncf"
        Me.Txt_ncf.Size = New System.Drawing.Size(56, 20)
        Me.Txt_ncf.TabIndex = 54
        Me.Txt_ncf.Text = ""
        '
        'LblNcf
        '
        Me.LblNcf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNcf.Location = New System.Drawing.Point(144, 136)
        Me.LblNcf.Name = "LblNcf"
        Me.LblNcf.Size = New System.Drawing.Size(240, 20)
        Me.LblNcf.TabIndex = 55
        '
        'LibXLookup6
        '
        Me.LibXLookup6.AlternateFieldSearch = Nothing
        Me.LibXLookup6.BeginCheck = False
        Me.LibXLookup6.CheckText = Nothing
        Me.LibXLookup6.ComboMode = False
        Me.LibXLookup6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LibXLookup6.DataMember = Nothing
        Me.LibXLookup6.DataSource = Me.LibXConnector1
        Me.LibXLookup6.DestParameters = New String() {"ncf_type=ncf_type", "LblNcf=definicion"}
        Me.LibXLookup6.Enabled = False
        Me.LibXLookup6.FilterField = Nothing
        Me.LibXLookup6.IgnoreFindInBrowseMode = False
        Me.LibXLookup6.isCanceled = False
        Me.LibXLookup6.Location = New System.Drawing.Point(384, 136)
        Me.LibXLookup6.LookCaption = Nothing
        Me.LibXLookup6.Name = "LibXLookup6"
        Me.LibXLookup6.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup6.ShowFilter = True
        Me.LibXLookup6.ShowMessageNotFound = True
        Me.LibXLookup6.ShowWarning = False
        Me.LibXLookup6.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup6.SizesColumns = Nothing
        Me.LibXLookup6.SizesColumnsTab = Nothing
        Me.LibXLookup6.SqlString = Nothing
        Me.LibXLookup6.SQLTab = Nothing
        Me.LibXLookup6.SrcParameters = New String() {"ncf_type=ncf_type"}
        Me.LibXLookup6.TabIndex = 57
        Me.LibXLookup6.TableName = "ftncfm"
        Me.LibXLookup6.TabStop = False
        Me.LibXLookup6.UseCopyConnection = False
        Me.LibXLookup6.UseRowRetrieveEvents = False
        Me.LibXLookup6.UseTab = False
        Me.LibXLookup6.VisParameters = New String() {"Código=ncf_type", "Descripción=definicion"}
        Me.LibXLookup6.WhereCondition = Nothing
        Me.LibXLookup6.WhereParameters = Nothing
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 232)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(520, 23)
        Me.ProgressBar1.TabIndex = 58
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
        Me.LibXDbSourceTable3.IsDetail = False
        Me.LibXDbSourceTable3.KeyFields = Nothing
        Me.LibXDbSourceTable3.LineColName = Nothing
        Me.LibXDbSourceTable3.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable3.MasterTableName = Nothing
        Me.LibXDbSourceTable3.SerialColumnName = Nothing
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = Nothing
        Me.LibXDbSourceTable3.TableName = "repventan"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'repventan
        '
        Me.repventan.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44})
        Me.repventan.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"idrepvn"}, True)})
        Me.repventan.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn29}
        Me.repventan.TableName = "repventan"
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "idrepvn"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "fact_date"
        Me.DataColumn30.DataType = GetType(System.DateTime)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "fact_number"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "fact_ncf"
        Me.DataColumn32.MaxLength = 40
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "bus_name"
        Me.DataColumn33.MaxLength = 100
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "cust_name"
        Me.DataColumn34.MaxLength = 100
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "rnc_id"
        Me.DataColumn35.MaxLength = 15
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "ncf_type"
        Me.DataColumn36.DataType = GetType(System.Int32)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "definicion"
        Me.DataColumn37.MaxLength = 40
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "fact_total"
        Me.DataColumn38.DataType = GetType(System.Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "dscto"
        Me.DataColumn39.DataType = GetType(System.Decimal)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "itbis"
        Me.DataColumn40.DataType = GetType(System.Decimal)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "whse_code"
        Me.DataColumn41.DataType = GetType(System.Int32)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "type_code"
        Me.DataColumn42.MaxLength = 3
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "caja_code"
        Me.DataColumn43.DataType = GetType(System.Int32)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "caje_code"
        Me.DataColumn44.DataType = GetType(System.Int32)
        '
        'r_ptvfactncf02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(538, 264)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LibXLookup6)
        Me.Controls.Add(Me.LblNcf)
        Me.Controls.Add(Me.Txt_ncf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_cajero)
        Me.Controls.Add(Me.LibXLookup5)
        Me.Controls.Add(Me.cajera_name)
        Me.Controls.Add(Me.Txt_caja)
        Me.Controls.Add(Me.LibXLookup4)
        Me.Controls.Add(Me.caja_name)
        Me.Controls.Add(Me.Txt_tipo)
        Me.Controls.Add(Me.LibXLookup2)
        Me.Controls.Add(Me.venta_name)
        Me.Controls.Add(Me.Chk_resumen)
        Me.Controls.Add(Me.Txt_almacen)
        Me.Controls.Add(Me.Label8)
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
        Me.Name = "r_ptvfactncf02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen de Ventas"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.repventan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim AxCrystalReport1 As LibX.ReportLib
        Try
            Dim SelecStmt As String
            Dim sFechaDesde As String
            Dim sFechaHasta As String
            Dim sCond As String
            Dim sTipo As String
            Dim sTipoN As String
            Dim sType As String
            Dim sCaja As String
            Dim sCajero As String
            Dim sWhere As String
            Dim oTable As DataTable
            Dim oRepventan As DataTable
            Dim ID As Integer
            Dim visual As Integer

            If Not IsNull(Fecha_Ini.Value) Then
                sFechaDesde = CDate(Fecha_Ini.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(Fecha_Fin.Value) Then
                sFechaHasta = CDate(Fecha_Fin.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(e.row!whse_code) Then
                sTipo = e.row!whse_code.ToString
            End If

            If Not IsNull(e.row!ncf_type) Then
                sTipoN = e.row!ncf_type.ToString
            End If

            If Not IsNull(e.row!type_code) Then
                sTipo = e.row!type_code.ToString
            End If

            If Not IsNull(e.row!caja_code) Then
                sCaja = e.row!caja_code.ToString
            End If
            If Not IsNull(e.row!caje_code) Then
                sCajero = e.row!caje_code.ToString
            End If

            'If Me.Chk_resumen.Checked = False Then
            '    AxCrystalReport1 = New ReportLib("PTV", "r_pvfactncf04.rpt")
            'End If
            'Else
            '    AxCrystalReport1 = New ReportLib("PTV", "r_pvfactncf02.rpt")
            'End If
            With AxCrystalReport1
                sWhere = " 1=1 "
                If Me.Chk_resumen.Checked = True Then
                    imprimir()
                Else
                    SelecStmt = "delete from repventan where 1=1 "
                    oTable = LibX.Data.Manager.GetDataTable(SelecStmt)
                    SelecStmt = "select fact_date,fact_number,fact_ncf,bus_name,cust_name,rnc_id,ncf_type,definicion,fact_total," & _
                                "dscto,itbis,whse_code,type_code,caja_code ,caje_code  from repventav1 " & _
                                 " where fact_date between '" & _
                                Trim(sFechaDesde) & _
                                "' and '" & _
                                 Trim(sFechaHasta) & _
                                "'"
                    
                    SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                    SelecStmt = SelecStmt & " order by repventav1.fact_date "
                    oRepventan = LibX.Data.Manager.GetDataTable(SelecStmt)

                    ProgressBar1.Maximum = oRepventan.Rows.Count + 1
                    ProgressBar1.Minimum = 1
                    ProgressBar1.Value = 1

                    ID = 1
                    visual = 0
                    For Each oRow1 As DataRow In oRepventan.Rows
                        Dim Repvm As DataRow = repventan.NewRow
                        Repvm!fact_date = oRow1!fact_date
                        Repvm!fact_number = oRow1!fact_number
                        Repvm!fact_ncf = oRow1!fact_ncf
                        Repvm!bus_name = oRow1!bus_name
                        Repvm!cust_name = oRow1!cust_name
                        Repvm!rnc_id = oRow1!rnc_id
                        Repvm!ncf_type = oRow1!ncf_type
                        Repvm!definicion = oRow1!definicion
                        Repvm!fact_total = oRow1!fact_total
                        Repvm!dscto = oRow1!dscto
                        Repvm!itbis = oRow1!itbis
                        Repvm!whse_code = oRow1!whse_code
                        Repvm!type_code = oRow1!type_code
                        Repvm!caja_code = oRow1!caja_code
                        Repvm!caje_code = oRow1!caje_code
                        Repvm!idrepvn = ID

                        If Repvm!fact_number <> 0 Then
                            repventan.Rows.Add(Repvm)
                        End If
                        ID += 1
                        ProgressBar1.Value += 1

                        visual = Int(ProgressBar1.Value * 100 / ProgressBar1.Maximum)
                        Label3.Text = visual & "%"

                        Application.DoEvents()
                    Next
                    LibX.Data.Manager.Save(repventan)
                    If oRepventan.Rows.Count > 0 Then
                        imprimir()
                    End If
                    
                End If
             
            End With

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
    End Sub
    Private Sub imprimir()
        Dim oRep As LibX.ReportLib
        Dim SelecStmt As String
        Dim sFechaDesde As String
        Dim sFechaHasta As String
        Dim swhere As String
        Dim sWhse As String
        Dim sTipoN As String
        Dim sType As String
        Dim sCaja As String
        Dim sCajero As String
        Try
            If Not IsNull(Fecha_Ini.Value) Then
                sFechaDesde = CDate(Fecha_Ini.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(Fecha_Fin.Value) Then
                sFechaHasta = CDate(Fecha_Fin.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(Me.Txt_almacen.Text) Then
                sWhse = Me.Txt_almacen.Text
            End If
            If Not IsNull(Me.Txt_ncf.Text) Then
                sTipoN = Me.Txt_ncf.Text
            End If
            If Not IsNull(Me.Txt_caja.Text) Then
                sCaja = Me.Txt_caja.Text
            End If
            If Not IsNull(Me.Txt_cajero.Text) Then
                sCajero = Me.Txt_cajero.Text
            End If

            If Me.Chk_resumen.Checked = True Then
                oRep = New ReportLib("PTV", "r_pvfactncf02.rpt")
            Else
                oRep = New ReportLib("PTV", "r_pvfactncf04.rpt")
            End If

            With oRep
                swhere = "1=1"
                If Me.Chk_resumen.Checked = True Then
                    If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                        swhere = String.Concat(swhere, " and repventav1.fact_date between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
                    ElseIf Trim(sFechaDesde) <> "" Then
                        swhere = String.Concat(swhere, " and repventav1.fact_date = '", Trim(sFechaDesde), "'")
                    ElseIf Trim(sFechaHasta) <> "" Then
                        swhere = String.Concat(swhere, " and repventav1.fact_date = '", Trim(sFechaHasta), "'")
                    End If

                    If Trim(sWhse) <> "" Then
                        swhere = String.Concat(swhere, " and repventav1.whse_code = " & Trim(sWhse))
                    End If

                    If Trim(sTipoN) <> "" Then
                        swhere = String.Concat(swhere, " and repventav1.type_code = '", Trim(sTipoN), "'")
                    End If

                    If Trim(sCaja) <> "" Then
                        swhere = String.Concat(swhere, " and repventav1.caja_code = '", Trim(sCaja), "'")
                    End If

                    If Trim(sCajero) <> "" Then
                        swhere = String.Concat(swhere, " and repventav1.caje_code = '", Trim(sCajero), "'")
                    End If
                Else
                    'If Me.RdB_resumenmes.Checked = True Then
                    If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                        swhere = String.Concat(swhere, " and repventan.fact_date between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
                    ElseIf Trim(sFechaDesde) <> "" Then
                        swhere = String.Concat(swhere, " and repventan.fact_date = '", Trim(sFechaDesde), "'")
                    ElseIf Trim(sFechaHasta) <> "" Then
                        swhere = String.Concat(swhere, " and repventan.fact_date = '", Trim(sFechaHasta), "'")
                    End If

                    If Trim(sWhse) <> "" Then
                        swhere = String.Concat(swhere, " and repventan.whse_code = " & Trim(sWhse))
                    End If

                    If Trim(sTipoN) <> "" Then
                        swhere = String.Concat(swhere, " and repventan.type_code = '", Trim(sTipoN), "'")
                    End If

                    If Trim(sCaja) <> "" Then
                        swhere = String.Concat(swhere, " and repventan.caja_code = '", Trim(sCaja), "'")
                    End If

                    If Trim(sCajero) <> "" Then
                        swhere = String.Concat(swhere, " and repventan.caje_code = '", Trim(sCajero), "'")
                    End If
                End If

                .ParameterFields(0) = String.Concat("fecha_ini;", Trim(sFechaDesde), ";TRUE")
                .ParameterFields(1) = String.Concat("fecha_fin;", Trim(sFechaHasta), ";TRUE")

                '// Recibir el SQL Query
                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = LibX.MdlUtil.ReplaceWherePart(SelecStmt, swhere)
                'SelecStmt = oDoc.PrepareSelectStmt(SelecStmt)

                .SQLQuery = SelecStmt

                '// Ejecutar el reporte
                .Action = 1
            End With
            'Me.ProgressBar1.Maximum = 0
            'Me.ProgressBar1.Minimum = 0
            Me.Label3.Text = ""
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class
