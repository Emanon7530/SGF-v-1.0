Imports LibX
Public Class r_ivonhnd01
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
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLastClose As System.Windows.Forms.Label
    Friend WithEvents group_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents chk_cero As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup6 As LibX.LibXLookup
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents sgroup_name As System.Windows.Forms.TextBox
    Friend WithEvents prov_name As System.Windows.Forms.TextBox
    Friend WithEvents txtitem_name As System.Windows.Forms.TextBox
    Friend WithEvents ivitemm As System.Data.DataTable
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents ivitemr As System.Data.DataTable
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents Chk_resumen As System.Windows.Forms.CheckBox
    Friend WithEvents sgroupcpde As System.Windows.Forms.TextBox
    Friend WithEvents groupcode As System.Windows.Forms.TextBox
    Friend WithEvents provcode As System.Windows.Forms.TextBox
    Friend WithEvents itemcode As System.Windows.Forms.TextBox
    Friend WithEvents Chk_contabil As System.Windows.Forms.CheckBox
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents whse_name As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents Chk_exist As System.Windows.Forms.CheckBox
    Friend WithEvents LibXLookup4 As LibX.LibXLookup
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ivitemm = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.ivitemr = New System.Data.DataTable
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
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.Label2 = New System.Windows.Forms.Label
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.fecHasta = New LibX.LibxDateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblLastClose = New System.Windows.Forms.Label
        Me.chk_cero = New System.Windows.Forms.CheckBox
        Me.sgroupcpde = New System.Windows.Forms.TextBox
        Me.groupcode = New System.Windows.Forms.TextBox
        Me.sgroup_name = New System.Windows.Forms.TextBox
        Me.group_name = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.provcode = New System.Windows.Forms.TextBox
        Me.prov_name = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.itemcode = New System.Windows.Forms.TextBox
        Me.txtitem_name = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.LibXLookup6 = New LibX.LibXLookup
        Me.Chk_resumen = New System.Windows.Forms.CheckBox
        Me.Chk_contabil = New System.Windows.Forms.CheckBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.whse_name = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.Chk_exist = New System.Windows.Forms.CheckBox
        Me.LibXLookup4 = New LibX.LibXLookup
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivitemm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivitemr, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXConnector1.DataMember = "ivitemm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = True
        Me.LibXConnector1.HandledUpdates = True
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable3})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivitemm, Me.ivitemr})
        '
        'ivitemm
        '
        Me.ivitemm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn15})
        Me.ivitemm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"item_code"}, True)})
        Me.ivitemm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn4}
        Me.ivitemm.TableName = "ivitemm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "prov_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "group_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sgroup_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "item_code"
        Me.DataColumn4.MaxLength = 10
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "whse_code"
        Me.DataColumn15.DataType = GetType(System.Int32)
        '
        'ivitemr
        '
        Me.ivitemr.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18})
        Me.ivitemr.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"itemid", "item_code"}, True)})
        Me.ivitemr.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn7}
        Me.ivitemr.TableName = "ivitemr"
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "itemid"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "whse_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "item_code"
        Me.DataColumn7.MaxLength = 10
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "item_name"
        Me.DataColumn8.MaxLength = 120
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "unidads"
        Me.DataColumn9.MaxLength = 5
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "onhand"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "costus"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "priceus"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "ubicac"
        Me.DataColumn13.MaxLength = 30
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "fecha"
        Me.DataColumn14.DataType = GetType(System.DateTime)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "costRD"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "priceRD"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "tasaUS"
        Me.DataColumn18.DataType = GetType(System.Decimal)
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
        Me.LibXDbSourceTable1.Source = New String() {"select ivitemm.prov_code,ivitemm.group_code,ivitemm.sgroup_code,ivitemm.item_code" & _
        ",ivitemd.whse_code", "from ivitemm inner join ivitemd on ivitemd.item_code = ivitemm.item_code"}
        Me.LibXDbSourceTable1.TableName = "ivitemm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
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
        Me.LibXDbSourceTable3.TableName = "ivitemr"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(12, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha de Corte:"
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
        Me.fecHasta.Location = New System.Drawing.Point(104, 202)
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
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(440, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 250)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(8, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Imprimir"
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(8, 48)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Cerrar"
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
        Me.Label5.Text = "LISTADO DE EXISTENCIA"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(8, 248)
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
        Me.Label1.Location = New System.Drawing.Point(248, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ultimo cierre:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLastClose
        '
        Me.lblLastClose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastClose.Location = New System.Drawing.Point(328, 56)
        Me.lblLastClose.Name = "lblLastClose"
        Me.lblLastClose.Size = New System.Drawing.Size(96, 20)
        Me.lblLastClose.TabIndex = 11
        '
        'chk_cero
        '
        Me.chk_cero.Location = New System.Drawing.Point(208, 202)
        Me.chk_cero.Name = "chk_cero"
        Me.chk_cero.Size = New System.Drawing.Size(168, 16)
        Me.chk_cero.TabIndex = 12
        Me.chk_cero.Text = "Incluir productos en negativo"
        '
        'sgroupcpde
        '
        Me.sgroupcpde.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.sgroup_code"))
        Me.sgroupcpde.Location = New System.Drawing.Point(104, 128)
        Me.sgroupcpde.Name = "sgroupcpde"
        Me.sgroupcpde.Size = New System.Drawing.Size(48, 20)
        Me.sgroupcpde.TabIndex = 13
        Me.sgroupcpde.Text = ""
        '
        'groupcode
        '
        Me.groupcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.group_code"))
        Me.groupcode.Location = New System.Drawing.Point(104, 104)
        Me.groupcode.Name = "groupcode"
        Me.groupcode.Size = New System.Drawing.Size(48, 20)
        Me.groupcode.TabIndex = 13
        Me.groupcode.Text = ""
        '
        'sgroup_name
        '
        Me.sgroup_name.Location = New System.Drawing.Point(160, 128)
        Me.sgroup_name.Name = "sgroup_name"
        Me.sgroup_name.ReadOnly = True
        Me.sgroup_name.Size = New System.Drawing.Size(248, 20)
        Me.sgroup_name.TabIndex = 13
        Me.sgroup_name.TabStop = False
        Me.sgroup_name.Text = ""
        '
        'group_name
        '
        Me.group_name.Location = New System.Drawing.Point(160, 104)
        Me.group_name.Name = "group_name"
        Me.group_name.ReadOnly = True
        Me.group_name.Size = New System.Drawing.Size(248, 20)
        Me.group_name.TabIndex = 13
        Me.group_name.TabStop = False
        Me.group_name.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(41, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Subgrupo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(58, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Grupo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"sgroup_code=sgroup_code", "sgroup_name=sgroup_name"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(408, 128)
        Me.LibXLookup2.LookCaption = "Marcas"
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
        Me.LibXLookup2.SrcParameters = New String() {"sgroup_code=sgroup_name"}
        Me.LibXLookup2.TabIndex = 14
        Me.LibXLookup2.TableName = "ivsgroupm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=sgroup_code", "Descripción=sgroup_name"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'LibXLookup3
        '
        Me.LibXLookup3.AlternateFieldSearch = Nothing
        Me.LibXLookup3.BeginCheck = False
        Me.LibXLookup3.CheckText = Nothing
        Me.LibXLookup3.ComboMode = False
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Me.LibXConnector1
        Me.LibXLookup3.DestParameters = New String() {"group_code=group_code", "group_name=group_name"}
        Me.LibXLookup3.FilterField = Nothing
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.isCanceled = False
        Me.LibXLookup3.Location = New System.Drawing.Point(408, 104)
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
        Me.LibXLookup3.SrcParameters = New String() {"group_code=group_code"}
        Me.LibXLookup3.TabIndex = 14
        Me.LibXLookup3.TableName = "ivgroupm"
        Me.LibXLookup3.TabStop = False
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.UseTab = False
        Me.LibXLookup3.VisParameters = New String() {"Código=group_code", "Descripción=group_name"}
        Me.LibXLookup3.WhereCondition = Nothing
        Me.LibXLookup3.WhereParameters = Nothing
        '
        'provcode
        '
        Me.provcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.provcode.Location = New System.Drawing.Point(104, 80)
        Me.provcode.Name = "provcode"
        Me.provcode.Size = New System.Drawing.Size(48, 20)
        Me.provcode.TabIndex = 19
        Me.provcode.Text = ""
        '
        'prov_name
        '
        Me.prov_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.prov_name.Location = New System.Drawing.Point(160, 80)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.ReadOnly = True
        Me.prov_name.Size = New System.Drawing.Size(248, 20)
        Me.prov_name.TabIndex = 17
        Me.prov_name.TabStop = False
        Me.prov_name.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(48, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Suplidor:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'itemcode
        '
        Me.itemcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.item_code"))
        Me.itemcode.Location = New System.Drawing.Point(104, 152)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.Size = New System.Drawing.Size(48, 20)
        Me.itemcode.TabIndex = 27
        Me.itemcode.Text = ""
        '
        'txtitem_name
        '
        Me.txtitem_name.Location = New System.Drawing.Point(160, 152)
        Me.txtitem_name.Name = "txtitem_name"
        Me.txtitem_name.ReadOnly = True
        Me.txtitem_name.Size = New System.Drawing.Size(248, 20)
        Me.txtitem_name.TabIndex = 25
        Me.txtitem_name.TabStop = False
        Me.txtitem_name.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(44, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 16)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Producto:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibXLookup6
        '
        Me.LibXLookup6.AlternateFieldSearch = Nothing
        Me.LibXLookup6.BeginCheck = False
        Me.LibXLookup6.CheckText = Nothing
        Me.LibXLookup6.ComboMode = False
        Me.LibXLookup6.DataMember = Nothing
        Me.LibXLookup6.DataSource = Me.LibXConnector1
        Me.LibXLookup6.DestParameters = New String() {"item_code=item_code", "txtitem_name=item_name"}
        Me.LibXLookup6.FilterField = Nothing
        Me.LibXLookup6.IgnoreFindInBrowseMode = False
        Me.LibXLookup6.isCanceled = False
        Me.LibXLookup6.Location = New System.Drawing.Point(408, 152)
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
        Me.LibXLookup6.SrcParameters = New String() {"item_code=item_code"}
        Me.LibXLookup6.TabIndex = 29
        Me.LibXLookup6.TableName = "ivitemm"
        Me.LibXLookup6.TabStop = False
        Me.LibXLookup6.UseCopyConnection = False
        Me.LibXLookup6.UseRowRetrieveEvents = False
        Me.LibXLookup6.UseTab = False
        Me.LibXLookup6.VisParameters = New String() {"Código=item_code", "Descripción=item_name"}
        Me.LibXLookup6.WhereCondition = Nothing
        Me.LibXLookup6.WhereParameters = Nothing
        '
        'Chk_resumen
        '
        Me.Chk_resumen.Checked = True
        Me.Chk_resumen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_resumen.Location = New System.Drawing.Point(208, 218)
        Me.Chk_resumen.Name = "Chk_resumen"
        Me.Chk_resumen.Size = New System.Drawing.Size(80, 16)
        Me.Chk_resumen.TabIndex = 30
        Me.Chk_resumen.Text = "Resumido"
        '
        'Chk_contabil
        '
        Me.Chk_contabil.Location = New System.Drawing.Point(288, 218)
        Me.Chk_contabil.Name = "Chk_contabil"
        Me.Chk_contabil.Size = New System.Drawing.Size(128, 16)
        Me.Chk_contabil.TabIndex = 31
        Me.Chk_contabil.Text = "Inventario Contabliidad"
        Me.Chk_contabil.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.whse_code"))
        Me.TextBox1.Location = New System.Drawing.Point(104, 176)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(48, 20)
        Me.TextBox1.TabIndex = 34
        Me.TextBox1.Text = ""
        '
        'whse_name
        '
        Me.whse_name.Location = New System.Drawing.Point(160, 176)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.ReadOnly = True
        Me.whse_name.Size = New System.Drawing.Size(248, 20)
        Me.whse_name.TabIndex = 33
        Me.whse_name.TabStop = False
        Me.whse_name.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(48, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Almacen:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"whse_code=whse_code", "whse_name=whse_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(408, 176)
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
        Me.LibXLookup1.TabIndex = 35
        Me.LibXLookup1.TableName = "ivwhsem"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'Chk_exist
        '
        Me.Chk_exist.Location = New System.Drawing.Point(208, 233)
        Me.Chk_exist.Name = "Chk_exist"
        Me.Chk_exist.Size = New System.Drawing.Size(104, 16)
        Me.Chk_exist.TabIndex = 37
        Me.Chk_exist.Text = "Solo Existencia"
        '
        'LibXLookup4
        '
        Me.LibXLookup4.AlternateFieldSearch = Nothing
        Me.LibXLookup4.BeginCheck = False
        Me.LibXLookup4.CheckText = Nothing
        Me.LibXLookup4.ComboMode = False
        Me.LibXLookup4.DataMember = Nothing
        Me.LibXLookup4.DataSource = Me.LibXConnector1
        Me.LibXLookup4.DestParameters = New String() {"provcode=prov_code", "prov_name=prov_name"}
        Me.LibXLookup4.FilterField = "prov_name"
        Me.LibXLookup4.IgnoreFindInBrowseMode = False
        Me.LibXLookup4.isCanceled = False
        Me.LibXLookup4.Location = New System.Drawing.Point(408, 80)
        Me.LibXLookup4.LookCaption = Nothing
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
        Me.LibXLookup4.SrcParameters = New String() {"provcode=prov_code"}
        Me.LibXLookup4.TabIndex = 38
        Me.LibXLookup4.TableName = "cpprovm"
        Me.LibXLookup4.TabStop = False
        Me.LibXLookup4.UseCopyConnection = False
        Me.LibXLookup4.UseRowRetrieveEvents = False
        Me.LibXLookup4.UseTab = False
        Me.LibXLookup4.VisParameters = New String() {"Código=prov_code", "Descripción=prov_name"}
        Me.LibXLookup4.WhereCondition = Nothing
        Me.LibXLookup4.WhereParameters = Nothing
        '
        'r_ivonhnd01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(530, 304)
        Me.Controls.Add(Me.LibXLookup4)
        Me.Controls.Add(Me.Chk_exist)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.whse_name)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LibXLookup1)
        Me.Controls.Add(Me.Chk_contabil)
        Me.Controls.Add(Me.Chk_resumen)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.txtitem_name)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.provcode)
        Me.Controls.Add(Me.prov_name)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.sgroupcpde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.groupcode)
        Me.Controls.Add(Me.sgroup_name)
        Me.Controls.Add(Me.group_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chk_cero)
        Me.Controls.Add(Me.LibXLookup6)
        Me.Controls.Add(Me.lblLastClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fecHasta)
        Me.Controls.Add(Me.LibXLookup2)
        Me.Controls.Add(Me.LibXLookup3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "r_ivonhnd01"
        Me.Text = "Listado de Existencia a una fecha"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivitemm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivitemr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sProv As String
    Dim sGroup As String
    Dim sSgroup As String
    Dim sProd As String
    Dim sWhere As String

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim xSelect As LibX.Data.XSelecStmt
        Dim oTable As DataTable
        Dim fecha_ini As Object
        Dim SelectStmt As String
        Dim ID As Integer
        Dim wHse As String
        Dim sDia, sMes, sAnio As Integer
        Dim sFecha As String
        Dim mTasa As Decimal
        Try

            e.DoFill = False

            If Not IsDate(Me.fecHasta.Value) Then
                Throw New ApplicationException("Debe especificar una fecha válida")
            End If

            If CType(fecHasta.Value, Date) > LibX.Data.Manager.Connection.GetDate Then
                Throw New ApplicationException("La Fecha no puede ser mayor a la fecha del día")
            End If

            If Not LibX.IsNull(e.row!prov_code) Then
                sProv = e.row!prov_code.ToString
            End If

            If Not LibX.IsNull(e.row!sgroup_code) Then
                sSgroup = e.row!sgroup_code.ToString
            End If

            If Not LibX.IsNull(e.row!item_code) Then
                sProd = e.row!item_code.ToString
            End If

            If Not LibX.IsNull(e.row!group_code) Then
                sGroup = e.row!group_code.ToString
            End If
            If TextBox1.Text <> "" Then
                wHse = e.row!whse_code
            End If
            sFecha = Now.Day.ToString("00") & "/" & Now.Month.ToString("00") & "/" & Now.Year.ToString("0000")

            sWhere = " 1=1 "

            If Trim(sProv) <> "" Then
                sWhere = String.Concat(sWhere, " and vw_ivitemd.prov_code = ", Trim(sProv))
            End If

            If Trim(sGroup) <> "" Then
                sWhere = String.Concat(sWhere, " and vw_ivitemd.group_code = ", Trim(sGroup))
            End If

            If Trim(sSgroup) <> "" Then
                sWhere = String.Concat(sWhere, " and vw_ivitemd.sgroup_code = ", Trim(sSgroup))
            End If

            If Trim(sProd) <> "" Then
                sWhere = String.Concat(sWhere, " and vw_ivitemd.item_code = ", Trim(sProd))
            End If

            If Trim(wHse) <> "" Then
                sWhere = String.Concat(sWhere, " and vw_ivitemd.whse_code = ", Trim(wHse))
            End If

            SelectStmt = "SELECT vw_ivitemd.whse_code,vw_ivitemd.item_code,vw_ivitemd.item_name,vw_ivitemd.purch_cost costRD,vw_ivitemd.unit_code," & _
                         " vw_ivitemd.existencia onhand,group_code FROM vw_ivitemd "

            SelectStmt = LibX.MdlUtil.ReplaceWherePart(SelectStmt, sWhere)
            xSelect = New LibX.Data.XSelecStmt("vw_ivitemd", SelectStmt)

            oTable = xSelect.GetTable(False)
            xSelect.Dispose()

            ''If LibX.Data.Manager.Connection.IsIntransaction = False Then
            ''    LibX.Data.Manager.Connection.BeginTransaction()
            ''End If
            Limpiar()

            ProgressBar1.Maximum = oTable.Rows.Count + 1
            ProgressBar1.Minimum = 1
            ProgressBar1.Value = 1

            ID = 1
            For Each oRow As DataRow In oTable.Rows
                Dim oNewRow As DataRow = ivitemr.NewRow

                oNewRow!itemid = ID
                oNewRow!fecha = fecHasta.Value
                oNewRow!item_code = oRow!item_code
                oNewRow!whse_code = oRow!whse_code
                oNewRow!item_name = oRow!item_name
                oNewRow!unidads = oRow!unit_code
                
                If fecha_ini <> Nothing Then
                    If fecha_ini = Me.fecHasta.Value Then
                        oNewRow!onhand = oRow!onhand
                        oNewRow!costus = oRow!costRD
                    Else
                        oNewRow!onhand = AplicarMovimientos(oRow!item_code.ToString, CDate(fecha_ini), CDate(Me.fecHasta.Value), oRow!onhand.ToString)
                        oNewRow!costus = CostosMovimientos(oRow!item_code.ToString, CDate(fecha_ini), CDate(Me.fecHasta.Value), oRow!costRD)
                    End If
                Else
                    If fecha_ini = Nothing And Me.fecHasta.Value = sFecha Then
                        oNewRow!onhand = oRow!onhand
                        oNewRow!costus = oRow!costRD
                    Else
                        oNewRow!onhand = AplicarMovimientos(oRow!item_code.ToString, CDate(Me.fecHasta.Value), CDate(Now), oRow!onhand.ToString)
                        oNewRow!costus = CostosMovimientos(oRow!item_code.ToString, CDate(Me.fecHasta.Value), CDate(Now), oRow!costRD)
                    End If
                End If

                If oNewRow!item_code <> " " Then
                    ivitemr.Rows.Add(oNewRow)
                End If

                ProgressBar1.Value += 1
                ID = ID + 1
            Next

            LibX.Data.Manager.Save(ivitemr)

            ''If LibX.Data.Manager.Connection.IsIntransaction = True Then
            ''    LibX.Data.Manager.Connection.CommitTransaction()
            ''End If

            If ivitemr.Rows.Count > 0 Then
                If chk_cero.Checked = True Then
                    ValorInvCerrado(Me.fecHasta.Value)
                End If
                imprimir()
            End If

        Catch ex As Exception
            ''If LibX.Data.Manager.Connection.IsIntransaction = True Then
            ''    LibX.Data.Manager.Connection.RollBackTransaction()
            ''End If
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Function AplicarMovimientos(ByVal iTemcode As String, ByVal fEcha As Date, ByVal fEchaf As Date, ByVal eXistencia As Integer) As Integer
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim iDias As Integer
        Try
            iDias = DateDiff(DateInterval.Day, fEcha, fEcha) + 1
            fEcha = DateAdd(DateInterval.Day, iDias, fEcha)

            SelectStmt = "select sum(qty*factor*(doc_input*-1)) qty  from vitranrvv where item_code ='" & iTemcode.Trim & "'" & _
                         " and vitranrvv.doc_date between '" & fEcha.ToString(LibX.Data.Manager.GetSaveDateFormat) & _
                         "' and '" & fEchaf.ToString(LibX.Data.Manager.GetSaveDateFormat) & "'" & _
                         " group by vitranrvv.item_code "
            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If Not oTable Is Nothing Then
                For Each orow As DataRow In oTable.Rows
                    eXistencia += Val(orow!qty.ToString)
                Next
            End If

            Return eXistencia

        Catch ex As Exception
            LibX.Log.Show(ex)
            Return -1
        End Try
    End Function
    Private Function CostosMovimientos(ByVal iTemcode As String, ByVal fEcha As Date, ByVal fEchaf As Date, ByVal costo As Decimal) As Decimal
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim iDias As Integer
        Dim mCostos As Decimal
        Try
            iDias = DateDiff(DateInterval.Day, fEcha, fEcha) + 1
            fEcha = DateAdd(DateInterval.Day, iDias, fEcha)

            SelectStmt = "select avg(costo) costo  from vitranrvv where item_code ='" & iTemcode.Trim & "'" & _
                         " and vitranrvv.doc_date between '" & fEcha.ToString(LibX.Data.Manager.GetSaveDateFormat) & _
                         "' and '" & fEchaf.ToString(LibX.Data.Manager.GetSaveDateFormat) & "' and type_code in('FCT','CUS','CRD','FSG')" & _
                         " group by vitranrvv.item_code "

            mCostos = LibX.Data.Manager.GetScalar(SelectStmt)

            If mCostos = Nothing Or mCostos = 0 Then
                SelectStmt = "select purch_cost  from ivitemv1 where item_code ='" & iTemcode.Trim & "'" & _
                                         " and whse_code = 1"

                mCostos = LibX.Data.Manager.GetScalar(SelectStmt)
            End If

            Return mCostos

        Catch ex As Exception
            LibX.Log.Show(ex)
            Return -1
        End Try
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Me.LibXConnector1.AcceptFind()
        Me.LibXConnector1.Find()
    End Sub

    Private Sub imprimir()
        Dim oRep As LibX.ReportLib
        Dim SelectStmt As String
        Try

            If Chk_exist.Checked = True Then
                oRep = New LibX.ReportLib("INV", "r_ivonhnd02.rpt")
            Else
                If Chk_resumen.Checked = True Then
                    '//resumido
                    oRep = New LibX.ReportLib("INV", "r_ivonhnd00.rpt")
                Else
                    '//detallado
                    oRep = New LibX.ReportLib("INV", "r_ivonhnd01.rpt")
                End If
            End If
            sWhere = " 1=1 "
            If Trim(sProv) <> "" Then
                sWhere = String.Concat(sWhere, " and vw_ivitemd.prov_code = ", Trim(sProv))
            End If
            If Trim(sGroup) <> "" Then
                sWhere = String.Concat(sWhere, " and vw_ivitemd.group_code = ", Trim(sGroup))
            End If
            If Trim(sSgroup) <> "" Then
                sWhere = String.Concat(sWhere, " and vw_ivitemd.sgroup_code = ", Trim(sSgroup))
            End If
            If Trim(sProd) <> "" Then
                sWhere = String.Concat(sWhere, " and vw_ivitemd.item_code = ", Trim(sProd))
            End If
            If Me.chk_cero.Checked = False And Chk_exist.Checked = False Then
                sWhere = String.Concat(sWhere, " and ivitemr.onhand >0 ")
            End If

            With oRep
                Me.fecHasta.Value = LibX.Data.Manager.GetScalar("select max(fecha) from ivitemr")
                .ParameterFields(1) = "FechaCierre;" & Me.fecHasta.Value & ";TRUE"
                .RetrieveSQLQuery()
                SelectStmt = .SQLQuery
                SelectStmt = LibX.MdlUtil.ReplaceWherePart(SelectStmt, sWhere)
                .SQLQuery = SelectStmt
                .Action = 1
            End With

            Me.ProgressBar1.Maximum = 0
            Me.ProgressBar1.Minimum = 0

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub r_ftfact10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LibXConnector1.Find()
        OinvConta = CType(System.Configuration.ConfigurationSettings.AppSettings.Get("LibxInvConta"), Boolean)
        If OinvConta = False Then
            Me.Chk_contabil.Visible = False
        End If
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            '''If e.Action = LibxConnectionActions.Find Then
            '''    ShowLastClose()
            '''End If
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
            lblLastClose.Text = CType(DateClose, Date).ToShortDateString
            fecHasta.Value = lblLastClose.Text

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub r_ivonhnd01_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Limpiar()
    End Sub

    Private Sub Limpiar()
        Dim DeleteStmt As String
        Try
            DeleteStmt = "truncate table ivitemr"
            LibX.Data.Manager.ExecuteNonQuery(DeleteStmt)
        Finally
            ivitemr.Rows.Clear()
        End Try
    End Sub

    Private Sub fecHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecHasta.ValueChanged
        Try
            If Me.fecHasta.Value > Now Then
                Me.fecHasta.Value = CDate(Now).ToString(LibX.Data.Manager.GetSaveDateFormat)
                Throw New ApplicationException("La fecha no puede ser mayor que la fecha del dia!")
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Chk_resumen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_resumen.CheckedChanged
        If Me.Chk_resumen.Checked = False Then
            Me.Label5.Text = "LISTADO DE EXISTENCIA DETALLADO"
        Else
            Me.Label5.Text = "LISTADO DE EXISTENCIA RESUMIDO"
        End If
        If Me.Chk_resumen.Checked = True Then
            Me.Chk_exist.Checked = False
        End If
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
            SelectStmt = "select sum(onhand*costus) from ivitemr "
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        imprimir()
    End Sub

    Private Sub Chk_exist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_exist.CheckedChanged
        If Me.Chk_exist.Checked = True Then
            Chk_resumen.Checked = False
        End If
    End Sub

    Private Sub prov_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prov_name.TextChanged

    End Sub
End Class
