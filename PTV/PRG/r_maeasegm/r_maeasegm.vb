Imports LibX
Public Class r_maeasegm
    Inherits System.Windows.Forms.Form
    Dim WhDefault As Integer
    Dim oDoc As SGT.Facturacion.Entidades.Documento
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
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents ftfactm As System.Data.DataTable
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents asegr_code As System.Windows.Forms.TextBox
    Friend WithEvents asegr_name As System.Windows.Forms.Label
    Friend WithEvents xlk_asegr As LibX.LibXLookup
    Friend WithEvents plan_code As System.Windows.Forms.TextBox
    Friend WithEvents plan_name As System.Windows.Forms.Label
    Friend WithEvents xlk_plan_segr As LibX.LibXLookup
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtaseg_nombre As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
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
        Me.DataColumn50 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.asegr_code = New System.Windows.Forms.TextBox
        Me.asegr_name = New System.Windows.Forms.Label
        Me.xlk_asegr = New LibX.LibXLookup
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.plan_code = New System.Windows.Forms.TextBox
        Me.plan_name = New System.Windows.Forms.Label
        Me.xlk_plan_segr = New LibX.LibXLookup
        Me.Txtaseg_nombre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftfactm})
        '
        'ftfactm
        '
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50})
        Me.ftfactm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no", "suc_code"}, True)})
        Me.ftfactm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn16, Me.DataColumn48}
        Me.ftfactm.TableName = "ftfactm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "cia_name"
        Me.DataColumn1.MaxLength = 80
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "cia_codigo"
        Me.DataColumn2.MaxLength = 20
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "aseg_poliza"
        Me.DataColumn3.MaxLength = 20
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "segr_autorizacion"
        Me.DataColumn4.MaxLength = 40
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "empl_amount"
        Me.DataColumn5.DataType = GetType(System.Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "cia_amount"
        Me.DataColumn6.DataType = GetType(System.Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "cia_serial"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "segr_recetaunica"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "fact_number"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "fact_date"
        Me.DataColumn10.DataType = GetType(System.DateTime)
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "fact_total"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "type_code"
        Me.DataColumn12.MaxLength = 3
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "plan_serial"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.Caption = "fecha_ini"
        Me.DataColumn14.ColumnName = "fecha_ini"
        Me.DataColumn14.DataType = GetType(System.DateTime)
        '
        'DataColumn15
        '
        Me.DataColumn15.Caption = "fecha_fin"
        Me.DataColumn15.ColumnName = "fecha_fin"
        Me.DataColumn15.DataType = GetType(System.DateTime)
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.AutoIncrement = True
        Me.DataColumn16.ColumnName = "ftserial_no"
        Me.DataColumn16.DataType = GetType(System.Int32)
        Me.DataColumn16.ReadOnly = True
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "whse_code"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "dev_type"
        Me.DataColumn18.MaxLength = 3
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "cotiz_serial"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "term_code"
        Me.DataColumn20.MaxLength = 5
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "addr_code"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "vend_code"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "descto"
        Me.DataColumn23.DataType = GetType(System.Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "itbis"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "userid"
        Me.DataColumn25.MaxLength = 20
        '
        'DataColumn26
        '
        Me.DataColumn26.AllowDBNull = False
        Me.DataColumn26.ColumnName = "fact_status"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "date_created"
        Me.DataColumn27.DataType = GetType(System.DateTime)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "cust_code"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "fact_cond"
        Me.DataColumn29.DataType = GetType(System.Int16)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "bus_name"
        Me.DataColumn30.MaxLength = 40
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "fact_nota"
        Me.DataColumn31.MaxLength = 80
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "ftserial_afect"
        Me.DataColumn32.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "pay_adelant"
        Me.DataColumn33.DataType = GetType(System.Int32)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "phone"
        Me.DataColumn34.MaxLength = 13
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "pay_mora"
        Me.DataColumn35.DataType = GetType(System.Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "porc_comision"
        Me.DataColumn36.DataType = GetType(System.Decimal)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "caja_code"
        Me.DataColumn37.DataType = GetType(System.Int32)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "caje_code"
        Me.DataColumn38.DataType = GetType(System.Int32)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "init_serial"
        Me.DataColumn39.DataType = GetType(System.Int32)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "fact_inddomicilio"
        Me.DataColumn40.DataType = GetType(System.Int32)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "address"
        Me.DataColumn41.MaxLength = 200
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "seg_amount"
        Me.DataColumn42.DataType = GetType(System.Decimal)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "prov_code"
        Me.DataColumn43.DataType = GetType(System.Int32)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "fact_impresa"
        Me.DataColumn44.DataType = GetType(System.Int32)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "fact_ncf"
        Me.DataColumn45.MaxLength = 40
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "cust_serial"
        Me.DataColumn46.DataType = GetType(System.Int32)
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "fact_time"
        Me.DataColumn47.MaxLength = 10
        '
        'DataColumn48
        '
        Me.DataColumn48.AllowDBNull = False
        Me.DataColumn48.ColumnName = "suc_code"
        Me.DataColumn48.DataType = GetType(System.Int32)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "fact_create"
        Me.DataColumn49.DataType = GetType(System.DateTime)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "aseg_nombre"
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
        Me.GroupBox1.Location = New System.Drawing.Point(410, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 152)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(8, 82)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Cerrar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLimpiar.Location = New System.Drawing.Point(9, 48)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(72, 32)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEjecutar.Location = New System.Drawing.Point(9, 14)
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
        Me.Label5.Size = New System.Drawing.Size(506, 48)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "LISTADO DE ASEGURADOS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'asegr_code
        '
        Me.asegr_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.cia_serial"))
        Me.asegr_code.Location = New System.Drawing.Point(88, 72)
        Me.asegr_code.Name = "asegr_code"
        Me.asegr_code.Size = New System.Drawing.Size(56, 20)
        Me.asegr_code.TabIndex = 18
        Me.asegr_code.Text = ""
        '
        'asegr_name
        '
        Me.asegr_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.asegr_name.Location = New System.Drawing.Point(152, 72)
        Me.asegr_name.Name = "asegr_name"
        Me.asegr_name.Size = New System.Drawing.Size(232, 20)
        Me.asegr_name.TabIndex = 19
        '
        'xlk_asegr
        '
        Me.xlk_asegr.AlternateFieldSearch = Nothing
        Me.xlk_asegr.BeginCheck = False
        Me.xlk_asegr.CheckText = Nothing
        Me.xlk_asegr.ComboMode = False
        Me.xlk_asegr.DataMember = Nothing
        Me.xlk_asegr.DataSource = Me.LibXConnector1
        Me.xlk_asegr.DestParameters = New String() {"asegr_code=cia_serial", "asegr_name=cia_name"}
        Me.xlk_asegr.FilterField = Nothing
        Me.xlk_asegr.IgnoreFindInBrowseMode = False
        Me.xlk_asegr.isCanceled = False
        Me.xlk_asegr.Location = New System.Drawing.Point(384, 72)
        Me.xlk_asegr.LookCaption = "Aseguradoras"
        Me.xlk_asegr.Name = "xlk_asegr"
        Me.xlk_asegr.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_asegr.ShowFilter = True
        Me.xlk_asegr.ShowMessageNotFound = True
        Me.xlk_asegr.ShowWarning = False
        Me.xlk_asegr.Size = New System.Drawing.Size(16, 20)
        Me.xlk_asegr.SizesColumns = Nothing
        Me.xlk_asegr.SizesColumnsTab = Nothing
        Me.xlk_asegr.SqlString = Nothing
        Me.xlk_asegr.SQLTab = Nothing
        Me.xlk_asegr.SrcParameters = New String() {"cia_serial=cia_serial"}
        Me.xlk_asegr.TabIndex = 20
        Me.xlk_asegr.TableName = "sgciasm"
        Me.xlk_asegr.TabStop = False
        Me.xlk_asegr.UseCopyConnection = False
        Me.xlk_asegr.UseRowRetrieveEvents = False
        Me.xlk_asegr.UseTab = False
        Me.xlk_asegr.VisParameters = New String() {"Código=cia_serial", "Descripción=cia_name"}
        Me.xlk_asegr.WhereCondition = Nothing
        Me.xlk_asegr.WhereParameters = Nothing
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(24, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Seguro:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(34, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Plan:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'plan_code
        '
        Me.plan_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.plan_serial"))
        Me.plan_code.Location = New System.Drawing.Point(88, 96)
        Me.plan_code.Name = "plan_code"
        Me.plan_code.Size = New System.Drawing.Size(56, 20)
        Me.plan_code.TabIndex = 18
        Me.plan_code.Text = ""
        '
        'plan_name
        '
        Me.plan_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.plan_name.Location = New System.Drawing.Point(152, 96)
        Me.plan_name.Name = "plan_name"
        Me.plan_name.Size = New System.Drawing.Size(232, 20)
        Me.plan_name.TabIndex = 19
        '
        'xlk_plan_segr
        '
        Me.xlk_plan_segr.AlternateFieldSearch = Nothing
        Me.xlk_plan_segr.BeginCheck = False
        Me.xlk_plan_segr.CheckText = Nothing
        Me.xlk_plan_segr.ComboMode = False
        Me.xlk_plan_segr.DataMember = Nothing
        Me.xlk_plan_segr.DataSource = Me.LibXConnector1
        Me.xlk_plan_segr.DestParameters = New String() {"plan_code=plan_serial", "plan_name=plan_name"}
        Me.xlk_plan_segr.FilterField = Nothing
        Me.xlk_plan_segr.IgnoreFindInBrowseMode = False
        Me.xlk_plan_segr.isCanceled = False
        Me.xlk_plan_segr.Location = New System.Drawing.Point(384, 96)
        Me.xlk_plan_segr.LookCaption = "PLanes de Seguro"
        Me.xlk_plan_segr.Name = "xlk_plan_segr"
        Me.xlk_plan_segr.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_plan_segr.ShowFilter = True
        Me.xlk_plan_segr.ShowMessageNotFound = True
        Me.xlk_plan_segr.ShowWarning = False
        Me.xlk_plan_segr.Size = New System.Drawing.Size(16, 20)
        Me.xlk_plan_segr.SizesColumns = Nothing
        Me.xlk_plan_segr.SizesColumnsTab = Nothing
        Me.xlk_plan_segr.SqlString = Nothing
        Me.xlk_plan_segr.SQLTab = Nothing
        Me.xlk_plan_segr.SrcParameters = New String() {"plan_serial=plan_serial"}
        Me.xlk_plan_segr.TabIndex = 20
        Me.xlk_plan_segr.TableName = "sgplanm"
        Me.xlk_plan_segr.TabStop = False
        Me.xlk_plan_segr.UseCopyConnection = False
        Me.xlk_plan_segr.UseRowRetrieveEvents = False
        Me.xlk_plan_segr.UseTab = False
        Me.xlk_plan_segr.VisParameters = New String() {"Código=plan_serial", "Descripción=Plan_name"}
        Me.xlk_plan_segr.WhereCondition = ""
        Me.xlk_plan_segr.WhereParameters = ""
        '
        'Txtaseg_nombre
        '
        Me.Txtaseg_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.aseg_nombre"))
        Me.Txtaseg_nombre.Location = New System.Drawing.Point(88, 120)
        Me.Txtaseg_nombre.Name = "Txtaseg_nombre"
        Me.Txtaseg_nombre.Size = New System.Drawing.Size(296, 20)
        Me.Txtaseg_nombre.TabIndex = 22
        Me.Txtaseg_nombre.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(5, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Asegurado:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'r_maeasegm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(506, 216)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtaseg_nombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.asegr_code)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.plan_code)
        Me.Controls.Add(Me.xlk_asegr)
        Me.Controls.Add(Me.asegr_name)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.xlk_plan_segr)
        Me.Controls.Add(Me.plan_name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "r_maeasegm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes Asegurados"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
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
            Dim aSegr As Integer
            Dim pLan As Integer
            Dim wHse As Integer
            Dim sSegName As String
            Dim sWhere As String

            If Not IsNull(e.row!cia_serial) Then
                aSegr = e.row!cia_serial
            End If
            If Not IsNull(e.row!plan_serial) Then
                pLan = e.row!plan_serial
            End If
            If Not IsNull(e.row!whse_code) Then
                wHse = e.row!whse_code
            End If

            If Not IsNull(e.row!aseg_nombre) Then
                sSegName = e.row!aseg_nombre.ToString
            End If

            AxCrystalReport1 = New ReportLib("PTV", "r_maeasegm.rpt")


            With AxCrystalReport1
                sWhere = " 1=1 "

                If e.row!cia_serial.ToString.Trim <> "" Then
                    sWhere = String.Concat(sWhere, " and sgciasm.cia_serial = '", e.row!cia_serial.ToString & "'")
                End If

                If e.row!plan_serial.ToString.Trim <> "" Then
                    sWhere = String.Concat(sWhere, " and sgplanm.plan_serial = '", e.row!plan_serial.ToString & "'")
                End If
                If Trim(sSegName) <> "" Then
                    sWhere = String.Concat(sWhere, " and sgasegm.aseg_nombre like '", Trim(sSegName), "%'")
                End If
                .ParameterFields(0) = String.Concat("fecha_ini;", Trim(sFechaDesde), ";TRUE")
                .ParameterFields(1) = String.Concat("fecha_fin;", Trim(sFechaHasta), ";TRUE")

                '// Recibir el SQL Query
                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                .SQLQuery = SelecStmt

                '// Ejecutar el reporte
                .Action = 1
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

    Private Sub xlk_plan_segr_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_plan_segr.BeforeExecuteQuery
        Try
            If Me.asegr_code.Text.Length > 0 Then
                e.aditionalWhere = " sgplanm.cia_serial= " & Me.asegr_code.Text
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
