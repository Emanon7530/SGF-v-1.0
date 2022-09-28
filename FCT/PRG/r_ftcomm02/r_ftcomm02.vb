Imports LibX
Public Class r_ftcomm02
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chk_resumido As System.Windows.Forms.CheckBox
    Friend WithEvents prov_name As System.Windows.Forms.TextBox
    Friend WithEvents vend_name As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents ftfactm As System.Data.DataTable
    Friend WithEvents txtvend_code As System.Windows.Forms.TextBox
    Friend WithEvents txtprov_code As System.Windows.Forms.TextBox
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
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataColumn39 = New System.Data.DataColumn
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
        Me.txtvend_code = New System.Windows.Forms.TextBox
        Me.txtprov_code = New System.Windows.Forms.TextBox
        Me.vend_name = New System.Windows.Forms.TextBox
        Me.prov_name = New System.Windows.Forms.TextBox
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.chk_resumido = New System.Windows.Forms.CheckBox
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
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39})
        Me.ftfactm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no"}, True)})
        Me.ftfactm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn5}
        Me.ftfactm.TableName = "ftfactm"
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
        Me.DataColumn3.ColumnName = "Vend_code"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Prov_code"
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.AutoIncrement = True
        Me.DataColumn5.ColumnName = "ftserial_no"
        Me.DataColumn5.DataType = GetType(System.Int32)
        Me.DataColumn5.ReadOnly = True
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "whse_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "dev_type"
        Me.DataColumn7.MaxLength = 3
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "cotiz_serial"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "term_code"
        Me.DataColumn9.MaxLength = 5
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "addr_code"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "fact_number"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "fact_date"
        Me.DataColumn12.DataType = GetType(System.DateTime)
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "fact_total"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "descto"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "itbis"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "userid"
        Me.DataColumn16.MaxLength = 20
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.ColumnName = "fact_status"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "date_created"
        Me.DataColumn18.DataType = GetType(System.DateTime)
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "type_code"
        Me.DataColumn19.MaxLength = 3
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "cust_code"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.AllowDBNull = False
        Me.DataColumn21.ColumnName = "fact_cond"
        Me.DataColumn21.DataType = GetType(System.Int16)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "bus_name"
        Me.DataColumn22.MaxLength = 100
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
        Me.DataColumn26.MaxLength = 13
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
        Me.DataColumn29.ColumnName = "caja_code"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "caje_code"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "init_serial"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "fact_inddomicilio"
        Me.DataColumn32.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "address"
        Me.DataColumn33.MaxLength = 200
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "seg_amount"
        Me.DataColumn34.DataType = GetType(System.Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "fact_impresa"
        Me.DataColumn35.DataType = GetType(System.Int32)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "fact_ncf"
        Me.DataColumn36.MaxLength = 40
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "cust_serial"
        Me.DataColumn37.DataType = GetType(System.Int32)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "fact_time"
        Me.DataColumn38.MaxLength = 10
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
        'DataColumn39
        '
        Me.DataColumn39.AllowDBNull = False
        Me.DataColumn39.ColumnName = "suc_code"
        Me.DataColumn39.DataType = GetType(System.Int32)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(24, 72)
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
        Me.Label2.Location = New System.Drawing.Point(31, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fecIni
        '
        Me.fecIni.CustomFormat = "dd/MM/yyyy"
        Me.fecIni.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.Fecha_ini"))
        Me.fecIni.EditInitialValue = Nothing
        Me.fecIni.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecIni.FieldDescription = ""
        Me.fecIni.FindInitialValue = ""
        Me.fecIni.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecIni.IgnoreRequiered = False
        Me.fecIni.Location = New System.Drawing.Point(104, 72)
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
        Me.fecHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.Fecha_fin"))
        Me.fecHasta.EditInitialValue = Nothing
        Me.fecHasta.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecHasta.FieldDescription = ""
        Me.fecHasta.FindInitialValue = ""
        Me.fecHasta.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecHasta.IgnoreRequiered = False
        Me.fecHasta.Location = New System.Drawing.Point(104, 96)
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
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.Location = New System.Drawing.Point(416, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 128)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(8, 83)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Cerrar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLimpiar.Location = New System.Drawing.Point(8, 48)
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
        Me.Label5.Size = New System.Drawing.Size(512, 48)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "LISTADO DE COMISIONES"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtvend_code
        '
        Me.txtvend_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.Vend_code"))
        Me.txtvend_code.Location = New System.Drawing.Point(104, 120)
        Me.txtvend_code.Name = "txtvend_code"
        Me.txtvend_code.Size = New System.Drawing.Size(48, 20)
        Me.txtvend_code.TabIndex = 17
        Me.txtvend_code.Text = ""
        '
        'txtprov_code
        '
        Me.txtprov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.Prov_code"))
        Me.txtprov_code.Location = New System.Drawing.Point(104, 144)
        Me.txtprov_code.Name = "txtprov_code"
        Me.txtprov_code.Size = New System.Drawing.Size(48, 20)
        Me.txtprov_code.TabIndex = 17
        Me.txtprov_code.Text = ""
        '
        'vend_name
        '
        Me.vend_name.Location = New System.Drawing.Point(160, 120)
        Me.vend_name.Name = "vend_name"
        Me.vend_name.ReadOnly = True
        Me.vend_name.Size = New System.Drawing.Size(224, 20)
        Me.vend_name.TabIndex = 18
        Me.vend_name.Text = ""
        '
        'prov_name
        '
        Me.prov_name.Location = New System.Drawing.Point(160, 144)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.ReadOnly = True
        Me.prov_name.Size = New System.Drawing.Size(224, 20)
        Me.prov_name.TabIndex = 18
        Me.prov_name.Text = ""
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"txtvend_code=vend_code", "vend_name=vend_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(384, 120)
        Me.LibXLookup1.LookCaption = "Vendedores"
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
        Me.LibXLookup1.SrcParameters = New String() {"txtvend_code=vend_code"}
        Me.LibXLookup1.TabIndex = 19
        Me.LibXLookup1.TableName = "ftvendm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"C�digo=vend_code", "Nombre=vend_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"txtprov_code=prov_code", "prov_name=prov_name"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(384, 144)
        Me.LibXLookup2.LookCaption = "Vendedores"
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
        Me.LibXLookup2.SrcParameters = New String() {"txtprov_code=prov_code"}
        Me.LibXLookup2.TabIndex = 19
        Me.LibXLookup2.TableName = "cpprovm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"C�digo=prov_code", "Nombre=prov_name"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(37, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Vendedor:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(41, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Suplidor:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_resumido
        '
        Me.chk_resumido.Checked = True
        Me.chk_resumido.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_resumido.Location = New System.Drawing.Point(272, 72)
        Me.chk_resumido.Name = "chk_resumido"
        Me.chk_resumido.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_resumido.Size = New System.Drawing.Size(120, 16)
        Me.chk_resumido.TabIndex = 21
        Me.chk_resumido.Text = "Imprimir Resumido"
        '
        'r_ftcomm02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 189)
        Me.Controls.Add(Me.chk_resumido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LibXLookup1)
        Me.Controls.Add(Me.vend_name)
        Me.Controls.Add(Me.txtvend_code)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fecHasta)
        Me.Controls.Add(Me.fecIni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtprov_code)
        Me.Controls.Add(Me.prov_name)
        Me.Controls.Add(Me.LibXLookup2)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.Name = "r_ftcomm02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Comisiones"
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
            Dim sWhere As String
            Dim sVendedor As String
            Dim sProveedor As String


            If Not IsNull(fecIni.Value) Then
                sFechaDesde = CDate(fecIni.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            Else
                sFechaDesde = CDate(LibX.Data.Manager.Connection.GetDate).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(fecHasta.Value) Then
                sFechaHasta = CDate(fecHasta.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            Else
                sFechaHasta = CDate(LibX.Data.Manager.Connection.GetDate).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(e.row!vend_code) Then
                sVendedor = (e.row!vend_code)
            End If

            If Not IsNull(e.row!prov_code) Then
                sProveedor = e.row!prov_code
            Else

            End If


            If chk_resumido.Checked = True Then
                AxCrystalReport1 = New LibX.ReportLib("FCT", "r_ftcomm01.rpt")
            Else
                AxCrystalReport1 = New LibX.ReportLib("FCT", "r_ftcomm02.rpt")
            End If

            'AxCrystalReport1 = New LibX.ReportLib("FCT", "r_ftcomm01.rpt")

            With AxCrystalReport1

                sWhere = " 1=1 "
                If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                    sWhere = String.Concat(sWhere, " and pagocomision.fact_date between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
                ElseIf Trim(sFechaDesde) <> "" Then
                    sWhere = String.Concat(sWhere, " and pagocomision.fact_date = '", Trim(sFechaDesde), "'")
                ElseIf Trim(sFechaHasta) <> "" Then
                    sWhere = String.Concat(sWhere, " and pagocomision.fact_date = '", Trim(sFechaHasta), "'")
                End If


                If Trim(sVendedor) <> "" Then
                    sWhere = String.Concat(sWhere, " and pagocomision.vend_code = ", Trim(sVendedor))
                End If

                If Trim(sProveedor) <> "" Then
                    sWhere = String.Concat(sWhere, " and pagocomision.prov_code = ", Trim(sProveedor))
                End If

                If chk_resumido.Checked = False Then
                    sWhere = String.Concat(sWhere, " and pagocomision.item_comm = ", 1)
                End If
                'If e.row!vend_code.ToString.Trim <> "" Then
                '    sWhere = String.Concat(sWhere, " and ftvendm.vend_code = ", e.row!vend_code.ToString)
                'End If
                'If e.row!prov_code.ToString.Trim <> "" Then
                '    sWhere = String.Concat(sWhere, " and ivitemm.prov_code = ", e.row!prov_code.ToString)
                'End If

                .ParameterFields(0) = String.Concat("Fecha_ini;", Trim(sFechaDesde), ";TRUE")
                .ParameterFields(1) = String.Concat("Fecha_fin;", Trim(sFechaHasta), ";TRUE")
                '''.ParameterFields(2) = String.Concat("@Vend;", sVendedor, ";TRUE")
                '''.ParameterFields(3) = String.Concat("@prov;", sProveedor, ";TRUE")

                ''''// Vendedores
                '''.ParameterFields(2) = String.Concat("VendedorInicial;", vend_code1.Text, ";TRUE")
                '''.ParameterFields(3) = String.Concat("VendedorFinal;", vend_code2.Text, ";TRUE")

                '// Recibir el SQL Query
                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                .SQLQuery = SelecStmt
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
    End Sub
End Class
