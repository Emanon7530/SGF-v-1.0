Imports LibX
Public Class r_ftmes
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents fecIni As LibX.LibxDateTimePicker
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents fecHasta As LibX.LibxDateTimePicker
    Friend WithEvents DataSet1 As System.Data.DataSet
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents XTextBox4 As LibX.XTextBox
    Friend WithEvents XTextBox5 As LibX.XTextBox
    Friend WithEvents XTextBox6 As LibX.XTextBox
    Friend WithEvents XTextBox7 As LibX.XTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents LibXLookup4 As LibX.LibXLookup
    Friend WithEvents LibXLookup5 As LibX.LibXLookup
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
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.fecIni = New LibX.LibxDateTimePicker
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.fecHasta = New LibX.LibxDateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.XTextBox4 = New LibX.XTextBox
        Me.XTextBox5 = New LibX.XTextBox
        Me.XTextBox6 = New LibX.XTextBox
        Me.XTextBox7 = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.LibXLookup4 = New LibX.LibXLookup
        Me.LibXLookup5 = New LibX.LibXLookup
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "ftfactm"
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
        Me.DataColumn3.ColumnName = "cotiz_serial"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "term_code"
        Me.DataColumn4.MaxLength = 5
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "addr_code"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "vend_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "fact_number"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "fact_date"
        Me.DataColumn8.DataType = GetType(System.DateTime)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "fact_total"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "descto"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "itbis"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "total_comision"
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
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "bus_name"
        Me.DataColumn19.MaxLength = 40
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "fecfin"
        Me.DataColumn20.DataType = GetType(System.DateTime)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "fecini"
        Me.DataColumn21.DataType = GetType(System.DateTime)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "dev_type"
        Me.DataColumn22.MaxLength = 3
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "fact_nota"
        Me.DataColumn23.MaxLength = 80
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "ftserial_afect"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "pay_adelant"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "phone"
        Me.DataColumn26.MaxLength = 8
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "pay_mora"
        Me.DataColumn27.DataType = GetType(System.Decimal)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "porc_comision"
        Me.DataColumn28.DataType = GetType(System.Decimal)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "fact_ncf"
        Me.DataColumn29.MaxLength = 20
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "caja_code"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "caje_code"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "init_serial"
        Me.DataColumn32.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "fact_inddomicilio"
        Me.DataColumn33.DataType = GetType(System.Int32)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "address"
        Me.DataColumn34.MaxLength = 200
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "seg_amount"
        Me.DataColumn35.DataType = GetType(System.Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "prov_code"
        Me.DataColumn36.DataType = GetType(System.Int32)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "fact_impresa"
        Me.DataColumn37.DataType = GetType(System.Int32)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "cust_serial"
        Me.DataColumn38.DataType = GetType(System.Int32)
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
        Me.Label1.Location = New System.Drawing.Point(48, 88)
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
        Me.Label2.Location = New System.Drawing.Point(55, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fecIni
        '
        Me.fecIni.CustomFormat = "dd/MM/yyyy"
        Me.fecIni.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.fecini"))
        Me.fecIni.EditInitialValue = Nothing
        Me.fecIni.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecIni.FieldDescription = ""
        Me.fecIni.FindInitialValue = "Now"
        Me.fecIni.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecIni.IgnoreRequiered = False
        Me.fecIni.Location = New System.Drawing.Point(128, 88)
        Me.fecIni.Name = "fecIni"
        Me.fecIni.NewInitialValue = Nothing
        Me.fecIni.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecIni.Requiered = False
        Me.fecIni.Size = New System.Drawing.Size(88, 20)
        Me.fecIni.StatusBarPanelDescripcion = Nothing
        Me.fecIni.TabIndex = 10
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
        'fecHasta
        '
        Me.fecHasta.CustomFormat = "dd/MM/yyyy"
        Me.fecHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.fecfin"))
        Me.fecHasta.EditInitialValue = Nothing
        Me.fecHasta.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecHasta.FieldDescription = ""
        Me.fecHasta.FindInitialValue = "Now"
        Me.fecHasta.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecHasta.IgnoreRequiered = False
        Me.fecHasta.Location = New System.Drawing.Point(128, 112)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.NewInitialValue = Nothing
        Me.fecHasta.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecHasta.Requiered = False
        Me.fecHasta.Size = New System.Drawing.Size(88, 20)
        Me.fecHasta.StatusBarPanelDescripcion = Nothing
        Me.fecHasta.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.Location = New System.Drawing.Point(434, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 120)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(8, 80)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Cerrar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLimpiar.Location = New System.Drawing.Point(8, 47)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(72, 32)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEjecutar.Location = New System.Drawing.Point(8, 13)
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
        Me.Label5.Size = New System.Drawing.Size(530, 48)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "BENEFICIO POR MES"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(87, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Caja:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(128, 136)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 20
        Me.XTextBox3.Text = " "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(67, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Almacen:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(79, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Grupo:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(56, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Sub Grupo:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(69, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Suplidor:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'XTextBox4
        '
        Me.XTextBox4.AcceptsReturn = True
        Me.XTextBox4.EditInitialValue = Nothing
        Me.XTextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.FieldDescription = ""
        Me.XTextBox4.FindInitialValue = Nothing
        Me.XTextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.IgnoreRequiered = False
        Me.XTextBox4.Location = New System.Drawing.Point(128, 160)
        Me.XTextBox4.Name = "XTextBox4"
        Me.XTextBox4.NewInitialValue = Nothing
        Me.XTextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.Requiered = False
        Me.XTextBox4.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox4.StatusBarPanelDescripcion = Nothing
        Me.XTextBox4.TabIndex = 25
        Me.XTextBox4.Text = " "
        '
        'XTextBox5
        '
        Me.XTextBox5.AcceptsReturn = True
        Me.XTextBox5.EditInitialValue = Nothing
        Me.XTextBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.FieldDescription = ""
        Me.XTextBox5.FindInitialValue = Nothing
        Me.XTextBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.IgnoreRequiered = False
        Me.XTextBox5.Location = New System.Drawing.Point(128, 184)
        Me.XTextBox5.Name = "XTextBox5"
        Me.XTextBox5.NewInitialValue = Nothing
        Me.XTextBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.Requiered = False
        Me.XTextBox5.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox5.StatusBarPanelDescripcion = Nothing
        Me.XTextBox5.TabIndex = 26
        Me.XTextBox5.Text = " "
        '
        'XTextBox6
        '
        Me.XTextBox6.AcceptsReturn = True
        Me.XTextBox6.EditInitialValue = Nothing
        Me.XTextBox6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.FieldDescription = ""
        Me.XTextBox6.FindInitialValue = Nothing
        Me.XTextBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.IgnoreRequiered = False
        Me.XTextBox6.Location = New System.Drawing.Point(128, 208)
        Me.XTextBox6.Name = "XTextBox6"
        Me.XTextBox6.NewInitialValue = Nothing
        Me.XTextBox6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.Requiered = False
        Me.XTextBox6.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox6.StatusBarPanelDescripcion = Nothing
        Me.XTextBox6.TabIndex = 27
        Me.XTextBox6.Text = " "
        '
        'XTextBox7
        '
        Me.XTextBox7.AcceptsReturn = True
        Me.XTextBox7.EditInitialValue = Nothing
        Me.XTextBox7.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox7.FieldDescription = ""
        Me.XTextBox7.FindInitialValue = Nothing
        Me.XTextBox7.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox7.IgnoreRequiered = False
        Me.XTextBox7.Location = New System.Drawing.Point(128, 232)
        Me.XTextBox7.Name = "XTextBox7"
        Me.XTextBox7.NewInitialValue = Nothing
        Me.XTextBox7.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox7.Requiered = False
        Me.XTextBox7.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox7.StatusBarPanelDescripcion = Nothing
        Me.XTextBox7.TabIndex = 28
        Me.XTextBox7.Text = " "
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(176, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(200, 20)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = " "
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(176, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 20)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = " "
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(176, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(200, 20)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = " "
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(176, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(200, 20)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = " "
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(176, 232)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(200, 20)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = " "
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Nothing
        Me.LibXLookup1.DestParameters = Nothing
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(376, 136)
        Me.LibXLookup1.LookCaption = ""
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
        Me.LibXLookup1.SrcParameters = Nothing
        Me.LibXLookup1.TabIndex = 34
        Me.LibXLookup1.TableName = Nothing
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = Nothing
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Nothing
        Me.LibXLookup2.DestParameters = Nothing
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(376, 160)
        Me.LibXLookup2.LookCaption = ""
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
        Me.LibXLookup2.SrcParameters = Nothing
        Me.LibXLookup2.TabIndex = 35
        Me.LibXLookup2.TableName = Nothing
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = Nothing
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'LibXLookup3
        '
        Me.LibXLookup3.AlternateFieldSearch = Nothing
        Me.LibXLookup3.CheckText = Nothing
        Me.LibXLookup3.ComboMode = False
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Nothing
        Me.LibXLookup3.DestParameters = Nothing
        Me.LibXLookup3.FilterField = Nothing
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.isCanceled = False
        Me.LibXLookup3.Location = New System.Drawing.Point(376, 184)
        Me.LibXLookup3.LookCaption = ""
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
        Me.LibXLookup3.SrcParameters = Nothing
        Me.LibXLookup3.TabIndex = 36
        Me.LibXLookup3.TableName = Nothing
        Me.LibXLookup3.TabStop = False
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.UseTab = False
        Me.LibXLookup3.VisParameters = Nothing
        Me.LibXLookup3.WhereCondition = Nothing
        Me.LibXLookup3.WhereParameters = Nothing
        '
        'LibXLookup4
        '
        Me.LibXLookup4.AlternateFieldSearch = Nothing
        Me.LibXLookup4.CheckText = Nothing
        Me.LibXLookup4.ComboMode = False
        Me.LibXLookup4.DataMember = Nothing
        Me.LibXLookup4.DataSource = Nothing
        Me.LibXLookup4.DestParameters = Nothing
        Me.LibXLookup4.FilterField = Nothing
        Me.LibXLookup4.IgnoreFindInBrowseMode = False
        Me.LibXLookup4.isCanceled = False
        Me.LibXLookup4.Location = New System.Drawing.Point(376, 208)
        Me.LibXLookup4.LookCaption = ""
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
        Me.LibXLookup4.SrcParameters = Nothing
        Me.LibXLookup4.TabIndex = 37
        Me.LibXLookup4.TableName = Nothing
        Me.LibXLookup4.TabStop = False
        Me.LibXLookup4.UseCopyConnection = False
        Me.LibXLookup4.UseRowRetrieveEvents = False
        Me.LibXLookup4.UseTab = False
        Me.LibXLookup4.VisParameters = Nothing
        Me.LibXLookup4.WhereCondition = Nothing
        Me.LibXLookup4.WhereParameters = Nothing
        '
        'LibXLookup5
        '
        Me.LibXLookup5.AlternateFieldSearch = Nothing
        Me.LibXLookup5.CheckText = Nothing
        Me.LibXLookup5.ComboMode = False
        Me.LibXLookup5.DataMember = Nothing
        Me.LibXLookup5.DataSource = Nothing
        Me.LibXLookup5.DestParameters = Nothing
        Me.LibXLookup5.FilterField = Nothing
        Me.LibXLookup5.IgnoreFindInBrowseMode = False
        Me.LibXLookup5.isCanceled = False
        Me.LibXLookup5.Location = New System.Drawing.Point(376, 232)
        Me.LibXLookup5.LookCaption = ""
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
        Me.LibXLookup5.SrcParameters = Nothing
        Me.LibXLookup5.TabIndex = 38
        Me.LibXLookup5.TableName = Nothing
        Me.LibXLookup5.TabStop = False
        Me.LibXLookup5.UseCopyConnection = False
        Me.LibXLookup5.UseRowRetrieveEvents = False
        Me.LibXLookup5.UseTab = False
        Me.LibXLookup5.VisParameters = Nothing
        Me.LibXLookup5.WhereCondition = Nothing
        Me.LibXLookup5.WhereParameters = Nothing
        '
        'r_ftmes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(530, 280)
        Me.Controls.Add(Me.LibXLookup5)
        Me.Controls.Add(Me.LibXLookup4)
        Me.Controls.Add(Me.LibXLookup3)
        Me.Controls.Add(Me.LibXLookup2)
        Me.Controls.Add(Me.LibXLookup1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.XTextBox7)
        Me.Controls.Add(Me.XTextBox6)
        Me.Controls.Add(Me.XTextBox5)
        Me.Controls.Add(Me.XTextBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.XTextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fecHasta)
        Me.Controls.Add(Me.fecIni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "r_ftmes"
        Me.Text = "Reporte de beneficio por mes"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
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
            Dim a—o_ini As Integer
            Dim mEs_ini As Integer
            Dim a—o_fin As Integer
            Dim mEs_fin As Integer
            Dim sCond As String
            Dim sWhere As String

            If Not IsNull(e.row!fecini) Then
                'sFechaDesde = CDate(e.row!fecini).ToString(LibX.Data.Manager.GetSaveDateFormat)
                sFechaDesde = Format(e.row!fecini.ToString)
                a—o_ini = Year(sFechaDesde)
                mEs_ini = Month(sFechaDesde)
                'sFechaDesde = e.row!fecini.ToString
            End If

            If Not IsNull(e.row!fecfin) Then
                'sFechaHasta = CDate(e.row!fecfin).ToString(LibX.Data.Manager.GetSaveDateFormat)
                sFechaHasta = Format(e.row!fecfin.ToString)
                a—o_fin = Year(sFechaHasta)
                mEs_fin = Month(sFechaHasta)
                'sFechaHasta = e.row!fecfin.ToString
            End If

            If Not IsNull(e.row!fact_cond) Then
                sCond = e.row!fact_cond
            End If


            AxCrystalReport1 = New LibX.ReportLib("FCT", "r_ftmes.rpt")

            With AxCrystalReport1
                sWhere = " 1=1 "
                If a—o_ini = a—o_fin Then
                    If Trim(a—o_ini) <> "" And Trim(a—o_fin) <> "" Then
                        sWhere = String.Concat(sWhere, " and ftvtabenef.A—O between '", Trim(a—o_ini), "' and '", Trim(a—o_fin), "'")
                    ElseIf Trim(a—o_ini) <> "" Then
                        sWhere = String.Concat(sWhere, " and ftvtabenef.A—O = '", Trim(a—o_ini), "'")
                    ElseIf Trim(a—o_fin) <> "" Then
                        sWhere = String.Concat(sWhere, " and ftvtabenef.MES = '", Trim(a—o_fin), "'")
                    End If
                    If Trim(mEs_ini) <> "" And Trim(mEs_fin) <> "" Then
                        sWhere = String.Concat(sWhere, " and ftvtabenef.MES between '", Trim(mEs_ini), "' and '", Trim(mEs_fin), "'")
                    ElseIf Trim(mEs_ini) <> "" Then
                        sWhere = String.Concat(sWhere, " and ftvtabenef.MES = '", Trim(mEs_ini), "'")
                    ElseIf Trim(mEs_fin) <> "" Then
                        sWhere = String.Concat(sWhere, " and ftvtabenef.MES = '", Trim(mEs_fin), "'")
                    End If
                Else
                    If Trim(a—o_ini) <> "" Then
                        sWhere = String.Concat(sWhere, " and ftvtabenef.A—O = '", Trim(a—o_ini), "'")
                    End If
                    If Trim(mEs_ini) <> "" Then
                        sWhere = String.Concat(sWhere, " and ftvtabenef.mes between '", Trim(mEs_ini), "' and '", Trim(12), "'")
                    End If
                    If Trim(a—o_fin) <> "" Then
                        sWhere = String.Concat(sWhere, " or ftvtabenef.aÒo = '", Trim(a—o_fin), "'")
                    End If
                    If Trim(mEs_ini) <> "" Then
                        sWhere = String.Concat(sWhere, " and ftvtabenef.MES between '", Trim(1), "' and '", Trim(mEs_fin), "'")
                    End If
                End If

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
        'Me.xtxt_whse_code.Text = System.Configuration.ConfigurationSettings.AppSettings.Get("Libxwhdefault")
        'Me.xlk_whse_code.ExecuteFind()

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub
End Class
