Imports LibX
Public Class p_ivcierr01
    Inherits System.Windows.Forms.Form
    Dim OinvConta As Boolean

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents fecHasta As LibX.LibxDateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents xdbivitemd As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents xdbivcierrm As LibX.LibXDbSourceTable
    Friend WithEvents ivcierrm As System.Data.DataTable
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLastClose As System.Windows.Forms.Label
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
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
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents Chk_Contabil As LibX.LibxCheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.xdbivitemd = New LibX.LibXDbSourceTable
        Me.xdbivcierrm = New LibX.LibXDbSourceTable
        Me.DataSet1 = New System.Data.DataSet
        Me.ivcierrm = New System.Data.DataTable
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
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
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.fecHasta = New LibX.LibxDateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblLastClose = New System.Windows.Forms.Label
        Me.Chk_Contabil = New LibX.LibxCheckBox
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivcierrm, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXConnector1.DataMember = ""
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.xdbivitemd, Me.xdbivcierrm})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'xdbivitemd
        '
        Me.xdbivitemd.AllowDelete = True
        Me.xdbivitemd.AllowEdit = True
        Me.xdbivitemd.AllowNew = True
        Me.xdbivitemd.AutoIncrementSerial = False
        Me.xdbivitemd.CustomDbUpdate = False
        Me.xdbivitemd.DeleteOrder = 0
        Me.xdbivitemd.FillOnQuery = True
        Me.xdbivitemd.FillOnRowChange = False
        Me.xdbivitemd.HeaderIsOnGrid = False
        Me.xdbivitemd.InnerJon = True
        Me.xdbivitemd.InsertOrder = 0
        Me.xdbivitemd.IsDetail = False
        Me.xdbivitemd.KeyFields = Nothing
        Me.xdbivitemd.LineColName = Nothing
        Me.xdbivitemd.MasterDetailRelation = Nothing
        Me.xdbivitemd.MasterTableName = Nothing
        Me.xdbivitemd.SerialColumnName = Nothing
        Me.xdbivitemd.Sort = Nothing
        Me.xdbivitemd.Source = Nothing
        Me.xdbivitemd.TableName = "ivitemd"
        Me.xdbivitemd.UpdateOrder = 0
        Me.xdbivitemd.UseRowRetrieve = False
        '
        'xdbivcierrm
        '
        Me.xdbivcierrm.AllowDelete = True
        Me.xdbivcierrm.AllowEdit = True
        Me.xdbivcierrm.AllowNew = True
        Me.xdbivcierrm.AutoIncrementSerial = False
        Me.xdbivcierrm.CustomDbUpdate = False
        Me.xdbivcierrm.DeleteOrder = 0
        Me.xdbivcierrm.FillOnQuery = True
        Me.xdbivcierrm.FillOnRowChange = False
        Me.xdbivcierrm.HeaderIsOnGrid = False
        Me.xdbivcierrm.InnerJon = True
        Me.xdbivcierrm.InsertOrder = 0
        Me.xdbivcierrm.IsDetail = False
        Me.xdbivcierrm.KeyFields = Nothing
        Me.xdbivcierrm.LineColName = Nothing
        Me.xdbivcierrm.MasterDetailRelation = Nothing
        Me.xdbivcierrm.MasterTableName = Nothing
        Me.xdbivcierrm.SerialColumnName = Nothing
        Me.xdbivcierrm.Sort = Nothing
        Me.xdbivcierrm.Source = Nothing
        Me.xdbivcierrm.TableName = "ivcierrm"
        Me.xdbivcierrm.UpdateOrder = 0
        Me.xdbivcierrm.UseRowRetrieve = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivcierrm, Me.DataTable1})
        '
        'ivcierrm
        '
        Me.ivcierrm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn41, Me.DataColumn42})
        Me.ivcierrm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"whse_code", "item_code", "cierr_date"}, True)})
        Me.ivcierrm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn23, Me.DataColumn24, Me.DataColumn25}
        Me.ivcierrm.TableName = "ivcierrm"
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "whse_code"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.ColumnName = "item_code"
        Me.DataColumn24.MaxLength = 10
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "cierr_date"
        Me.DataColumn25.DataType = GetType(System.DateTime)
        '
        'DataColumn26
        '
        Me.DataColumn26.AllowDBNull = False
        Me.DataColumn26.ColumnName = "onhand"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "cost"
        Me.DataColumn41.DataType = GetType(System.Decimal)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "price"
        Me.DataColumn42.DataType = GetType(System.Decimal)
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"whse_code", "item_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2}
        Me.DataTable1.TableName = "ivitemd"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "whse_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "item_code"
        Me.DataColumn2.MaxLength = 10
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "purch_cost"
        Me.DataColumn3.DataType = GetType(System.Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "porc_isc"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "last_cost"
        Me.DataColumn5.DataType = GetType(System.Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "avg_cost"
        Me.DataColumn6.DataType = GetType(System.Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "loc_row"
        Me.DataColumn7.MaxLength = 20
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "loc_col"
        Me.DataColumn8.MaxLength = 20
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "estante"
        Me.DataColumn9.MaxLength = 20
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "price"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "benef"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "BackOrder"
        Me.DataColumn12.DataType = GetType(System.Int16)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "existencia"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "datelast_purch"
        Me.DataColumn14.DataType = GetType(System.DateTime)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "datelast_sales"
        Me.DataColumn15.DataType = GetType(System.DateTime)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "taxable"
        Me.DataColumn16.DataType = GetType(System.Int16)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "rounded"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "Rorder_point"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "existencia_min"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "exitencia_max"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "cant_pedida"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "cant_recibida"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "numero_orden"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "frizado_inv"
        Me.DataColumn28.DataType = GetType(System.Int16)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "aplica_dscnt"
        Me.DataColumn29.DataType = GetType(System.Int16)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "fecha_frizado"
        Me.DataColumn30.DataType = GetType(System.DateTime)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "limite_frizado"
        Me.DataColumn31.DataType = GetType(System.DateTime)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "fecha_conteo"
        Me.DataColumn32.DataType = GetType(System.DateTime)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "ultima_trans"
        Me.DataColumn33.DataType = GetType(System.Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "vencimiento"
        Me.DataColumn34.DataType = GetType(System.Int16)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "disc_pct"
        Me.DataColumn35.DataType = GetType(System.Decimal)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(104, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha de Cierre:"
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
        'fecHasta
        '
        Me.fecHasta.CustomFormat = "dd/MM/yyyy"
        Me.fecHasta.EditInitialValue = Nothing
        Me.fecHasta.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecHasta.FieldDescription = ""
        Me.fecHasta.FindInitialValue = "Now"
        Me.fecHasta.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecHasta.IgnoreRequiered = False
        Me.fecHasta.Location = New System.Drawing.Point(200, 88)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.NewInitialValue = Nothing
        Me.fecHasta.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecHasta.Requiered = False
        Me.fecHasta.Size = New System.Drawing.Size(96, 20)
        Me.fecHasta.StatusBarPanelDescripcion = Nothing
        Me.fecHasta.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(440, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 120)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(8, 84)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Cerrar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLimpiar.Location = New System.Drawing.Point(8, 49)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(72, 32)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Imprimir"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEjecutar.Location = New System.Drawing.Point(8, 14)
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
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "CIERRE DE INVENTARIO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(8, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 48)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Progreso"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 16)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(408, 23)
        Me.ProgressBar1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(120, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ultimo cierre:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLastClose
        '
        Me.lblLastClose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastClose.Location = New System.Drawing.Point(200, 64)
        Me.lblLastClose.Name = "lblLastClose"
        Me.lblLastClose.Size = New System.Drawing.Size(96, 20)
        Me.lblLastClose.TabIndex = 11
        '
        'Chk_Contabil
        '
        Me.Chk_Contabil.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Chk_Contabil.EditInitialValue = Nothing
        Me.Chk_Contabil.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Chk_Contabil.FindInitialValue = Nothing
        Me.Chk_Contabil.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Chk_Contabil.IgnoreRequiered = False
        Me.Chk_Contabil.KeepEnabled = False
        Me.Chk_Contabil.Location = New System.Drawing.Point(312, 56)
        Me.Chk_Contabil.Name = "Chk_Contabil"
        Me.Chk_Contabil.NewInitialValue = Nothing
        Me.Chk_Contabil.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Chk_Contabil.ReadOnly = False
        Me.Chk_Contabil.Requiered = False
        Me.Chk_Contabil.Size = New System.Drawing.Size(120, 24)
        Me.Chk_Contabil.TabIndex = 3
        Me.Chk_Contabil.Text = "Actualizar Periodo"
        Me.Chk_Contabil.ThreeState = True
        Me.Chk_Contabil.value = Nothing
        '
        'p_ivcierr01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(530, 200)
        Me.Controls.Add(Me.lblLastClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fecHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chk_Contabil)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "p_ivcierr01"
        Me.Text = "Cierre de Inventario"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivcierrm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim xSelect As LibX.Data.XSelecStmt
        Dim oTable As DataTable

        Try

            e.DoFill = False

            If Me.fecHasta.Value.ToString.Trim.Length <= 0 Then
                Throw New ApplicationException("Debe especificar la fecha de cierre")
            End If

            If Not IsDate(Me.fecHasta.Value) Then
                Throw New ApplicationException("Debe especificar una fecha v�lida")
            End If

            If CType(fecHasta.Value, Date) > LibX.Data.Manager.Connection.GetDate Then
                Throw New ApplicationException("La Fecha no puede ser mayor a la fecha del d�a")
            End If

            xSelect = New LibX.Data.XSelecStmt("ivcierrm")
            xSelect.Parameters.Add("cierr_date", CType(Me.fecHasta.Value, Date))

            oTable = xSelect.GetTable

            xSelect.Dispose()

            If oTable.Rows.Count > 0 Then
                Throw New ApplicationException("Existe un cierre para esta fecha!")
            End If

            If MessageBox.Show("Seguro desea cerrar inventario?", "Cierre de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If

            xSelect = New LibX.Data.XSelecStmt("ivitemd", "SELECT * FROM ivitemd ")

            oTable = xSelect.GetTable(False)
            xSelect.Dispose()

            ProgressBar1.Maximum = oTable.Rows.Count + 1
            ProgressBar1.Minimum = 1

            If LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            For Each oRow As DataRow In oTable.Rows
                Dim oNewRow As DataRow = ivcierrm.NewRow

                oNewRow!item_code = oRow!item_code
                oNewRow!whse_code = oRow!whse_code
                oNewRow!cierr_date = Me.fecHasta.Value
                oNewRow!onhand = oRow!existencia
                oNewRow!cost = oRow!purch_cost
                oNewRow!price = oRow!price

                ivcierrm.Rows.Add(oNewRow)

                ProgressBar1.Value += 1
            Next

            LibX.Data.Manager.Save(ivcierrm)

            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If
            MessageBox.Show("Cierre realizado exitosamente!", "Cierre inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If Me.Chk_Contabil.Checked = True Then
                ValorInvCerrado(Me.fecHasta.Value)
            End If

            ProgressBar1.Maximum = 0
            ProgressBar1.Minimum = 0

        Catch ex As Exception
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
            Log.Show(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Me.LibXConnector1.AcceptFind()
        Me.LibXConnector1.Find()
        Me.fecHasta.Value = LibX.Data.Manager.Connection.GetDate

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Dim oRep As LibX.ReportLib
        Try
            oRep = New LibX.ReportLib("INV", "r_ivcierr01.rpt")
            With oRep
                .ParameterFields(1) = "FechaCierre;" & Me.fecHasta.Value & ";TRUE"
                .Action = 1
            End With
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub r_ftfact10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LibXConnector1.Find()
        OinvConta = CType(System.Configuration.ConfigurationSettings.AppSettings.Get("LibxInvConta"), Boolean)
        If OinvConta = False Then
            Me.Chk_Contabil.Visible = False
        End If
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibxConnectionActions.Find Then
                showLastClose()
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub ShowLastClose()
        Dim SelectStmt As String
        Dim DateClose As String
        Try

            SelectStmt = "select max(cierr_date) from ivcierrm"

            DateClose = LibX.Data.Manager.GetScalar(SelectStmt).ToString

            If DateClose.Trim.Length > 0 Then
                lblLastClose.Text = CType(DateClose, Date).ToShortDateString
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub
    Private Sub ValorInvCerrado(ByVal DateClose As DateTime)
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim SelectStmt As String
        Dim ValorInv As Decimal
        Dim oAnio As Integer
        Dim oMes As Integer
        Dim oDia As Integer
        Dim oFecha As String
        Try
            oFecha = Format(DateClose, "yyyy-MM-dd")
            SelectStmt = "select sum(onhand*cost) from ivcierrm where cierr_date ='" & oFecha & "'"
            ValorInv = LibX.Data.Manager.GetScalar(SelectStmt).ToString

            XUpdate = New LibX.Data.XUpdateStmt("cgperdd")
            XUpdate.FieldsSet("ic_balance") = ValorInv.ToString
            XUpdate.Fields("perdr_year") = Year(DateClose)
            XUpdate.Fields("perdr_num") = Month(DateClose)
            XUpdate.Execute()

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub

End Class
