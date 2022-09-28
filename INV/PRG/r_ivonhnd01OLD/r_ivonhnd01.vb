Imports LibX
Public Class r_ivonhnd01
    Inherits System.Windows.Forms.Form

    Dim OinvConta As Boolean
    Dim sWhse As Integer

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
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLastClose As System.Windows.Forms.Label
    Friend WithEvents group_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents chk_cero As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup4 As LibX.LibXLookup
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup6 As LibX.LibXLookup
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
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
    Friend WithEvents groupcode As System.Windows.Forms.TextBox
    Friend WithEvents provcode As System.Windows.Forms.TextBox
    Friend WithEvents itemcode As System.Windows.Forms.TextBox
    Friend WithEvents Chk_contabil As System.Windows.Forms.CheckBox
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LblWhse_code As System.Windows.Forms.Label
    Friend WithEvents TxtWhse_name As System.Windows.Forms.TextBox
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents TxtWhse_code As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents TxtSgroup_code As System.Windows.Forms.TextBox
    Friend WithEvents TxtSgroup_name As System.Windows.Forms.TextBox
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblLastClose = New System.Windows.Forms.Label
        Me.chk_cero = New System.Windows.Forms.CheckBox
        Me.TxtSgroup_code = New System.Windows.Forms.TextBox
        Me.groupcode = New System.Windows.Forms.TextBox
        Me.TxtSgroup_name = New System.Windows.Forms.TextBox
        Me.group_name = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.provcode = New System.Windows.Forms.TextBox
        Me.prov_name = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.LibXLookup4 = New LibX.LibXLookup
        Me.itemcode = New System.Windows.Forms.TextBox
        Me.txtitem_name = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.LibXLookup6 = New LibX.LibXLookup
        Me.Chk_contabil = New System.Windows.Forms.CheckBox
        Me.LblWhse_code = New System.Windows.Forms.Label
        Me.TxtWhse_name = New System.Windows.Forms.TextBox
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.TxtWhse_code = New System.Windows.Forms.TextBox
        Me.LibXLookup2 = New LibX.LibXLookup
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivitemm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivitemr, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataColumn15.Caption = "whse_code"
        Me.DataColumn15.ColumnName = "whse_code"
        '
        'ivitemr
        '
        Me.ivitemr.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
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
        "", "from ivitemm"}
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
        Me.Label2.Location = New System.Drawing.Point(8, 59)
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
        Me.fecHasta.Location = New System.Drawing.Point(104, 56)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.NewInitialValue = Nothing
        Me.fecHasta.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecHasta.Requiered = False
        Me.fecHasta.Size = New System.Drawing.Size(96, 20)
        Me.fecHasta.StatusBarPanelDescripcion = Nothing
        Me.fecHasta.TabIndex = 6
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
        Me.GroupBox1.Size = New System.Drawing.Size(88, 128)
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
        Me.chk_cero.Checked = True
        Me.chk_cero.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_cero.Location = New System.Drawing.Point(152, 200)
        Me.chk_cero.Name = "chk_cero"
        Me.chk_cero.Size = New System.Drawing.Size(168, 16)
        Me.chk_cero.TabIndex = 12
        Me.chk_cero.Text = "Existencia >0"
        '
        'TxtSgroup_code
        '
        Me.TxtSgroup_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.sgroup_code"))
        Me.TxtSgroup_code.Location = New System.Drawing.Point(104, 152)
        Me.TxtSgroup_code.Name = "TxtSgroup_code"
        Me.TxtSgroup_code.Size = New System.Drawing.Size(48, 20)
        Me.TxtSgroup_code.TabIndex = 4
        Me.TxtSgroup_code.Text = ""
        '
        'groupcode
        '
        Me.groupcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.group_code"))
        Me.groupcode.Location = New System.Drawing.Point(104, 128)
        Me.groupcode.Name = "groupcode"
        Me.groupcode.Size = New System.Drawing.Size(48, 20)
        Me.groupcode.TabIndex = 3
        Me.groupcode.Text = ""
        '
        'TxtSgroup_name
        '
        Me.TxtSgroup_name.Location = New System.Drawing.Point(160, 152)
        Me.TxtSgroup_name.Name = "TxtSgroup_name"
        Me.TxtSgroup_name.ReadOnly = True
        Me.TxtSgroup_name.Size = New System.Drawing.Size(248, 20)
        Me.TxtSgroup_name.TabIndex = 13
        Me.TxtSgroup_name.TabStop = False
        Me.TxtSgroup_name.Text = ""
        '
        'group_name
        '
        Me.group_name.Location = New System.Drawing.Point(160, 128)
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
        Me.Label3.Location = New System.Drawing.Point(41, 152)
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
        Me.Label4.Location = New System.Drawing.Point(58, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Grupo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.LibXLookup3.Location = New System.Drawing.Point(408, 128)
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
        Me.provcode.Location = New System.Drawing.Point(104, 104)
        Me.provcode.Name = "provcode"
        Me.provcode.Size = New System.Drawing.Size(48, 20)
        Me.provcode.TabIndex = 2
        Me.provcode.Text = ""
        '
        'prov_name
        '
        Me.prov_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.prov_name.Location = New System.Drawing.Point(160, 104)
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
        Me.Label7.Location = New System.Drawing.Point(48, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Suplidor:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.LibXLookup4.FilterField = Nothing
        Me.LibXLookup4.IgnoreFindInBrowseMode = False
        Me.LibXLookup4.isCanceled = False
        Me.LibXLookup4.Location = New System.Drawing.Point(408, 104)
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
        Me.LibXLookup4.TabIndex = 21
        Me.LibXLookup4.TableName = "cpprovm"
        Me.LibXLookup4.TabStop = False
        Me.LibXLookup4.UseCopyConnection = False
        Me.LibXLookup4.UseRowRetrieveEvents = False
        Me.LibXLookup4.UseTab = False
        Me.LibXLookup4.VisParameters = New String() {"Código=prov_code", "Descripción=prov_name"}
        Me.LibXLookup4.WhereCondition = Nothing
        Me.LibXLookup4.WhereParameters = Nothing
        '
        'itemcode
        '
        Me.itemcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.item_code"))
        Me.itemcode.Location = New System.Drawing.Point(104, 176)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.Size = New System.Drawing.Size(48, 20)
        Me.itemcode.TabIndex = 5
        Me.itemcode.Text = ""
        '
        'txtitem_name
        '
        Me.txtitem_name.Location = New System.Drawing.Point(160, 176)
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
        Me.Label9.Location = New System.Drawing.Point(44, 176)
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
        Me.LibXLookup6.Location = New System.Drawing.Point(408, 176)
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
        'Chk_contabil
        '
        Me.Chk_contabil.Location = New System.Drawing.Point(152, 216)
        Me.Chk_contabil.Name = "Chk_contabil"
        Me.Chk_contabil.Size = New System.Drawing.Size(128, 16)
        Me.Chk_contabil.TabIndex = 31
        Me.Chk_contabil.Text = "Inventario Contabliidad"
        Me.Chk_contabil.Visible = False
        '
        'LblWhse_code
        '
        Me.LblWhse_code.AutoSize = True
        Me.LblWhse_code.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LblWhse_code.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblWhse_code.Location = New System.Drawing.Point(47, 82)
        Me.LblWhse_code.Name = "LblWhse_code"
        Me.LblWhse_code.Size = New System.Drawing.Size(51, 16)
        Me.LblWhse_code.TabIndex = 32
        Me.LblWhse_code.Text = "Almacen:"
        Me.LblWhse_code.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtWhse_name
        '
        Me.TxtWhse_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.TxtWhse_name.Location = New System.Drawing.Point(160, 80)
        Me.TxtWhse_name.Name = "TxtWhse_name"
        Me.TxtWhse_name.ReadOnly = True
        Me.TxtWhse_name.Size = New System.Drawing.Size(248, 20)
        Me.TxtWhse_name.TabIndex = 33
        Me.TxtWhse_name.TabStop = False
        Me.TxtWhse_name.Text = ""
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"Txtwhse_code=whse_code", "TxtWhse_name=whse_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(408, 80)
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
        Me.LibXLookup1.SrcParameters = New String() {"Txtwhse_code=whse_code"}
        Me.LibXLookup1.TabIndex = 34
        Me.LibXLookup1.TableName = "ivwhsem"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'TxtWhse_code
        '
        Me.TxtWhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.whse_code"))
        Me.TxtWhse_code.Location = New System.Drawing.Point(104, 80)
        Me.TxtWhse_code.Name = "TxtWhse_code"
        Me.TxtWhse_code.Size = New System.Drawing.Size(48, 20)
        Me.TxtWhse_code.TabIndex = 1
        Me.TxtWhse_code.Tag = ""
        Me.TxtWhse_code.Text = ""
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"TxtSgroup_code=sgroup_code", "TxtSgroup_name=sgroup_name"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(408, 152)
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
        Me.LibXLookup2.SrcParameters = New String() {"TxtSgroup_code=sgroup_code"}
        Me.LibXLookup2.TabIndex = 35
        Me.LibXLookup2.TableName = "ivsgroupm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=sgroup_code", "Descripción=sgroup_name"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'r_ivonhnd01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(530, 240)
        Me.Controls.Add(Me.LibXLookup2)
        Me.Controls.Add(Me.TxtWhse_code)
        Me.Controls.Add(Me.LibXLookup1)
        Me.Controls.Add(Me.TxtWhse_name)
        Me.Controls.Add(Me.LblWhse_code)
        Me.Controls.Add(Me.Chk_contabil)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.txtitem_name)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.provcode)
        Me.Controls.Add(Me.prov_name)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtSgroup_code)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.groupcode)
        Me.Controls.Add(Me.TxtSgroup_name)
        Me.Controls.Add(Me.group_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chk_cero)
        Me.Controls.Add(Me.LibXLookup6)
        Me.Controls.Add(Me.LibXLookup4)
        Me.Controls.Add(Me.lblLastClose)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fecHasta)
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
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Dim sWhse As Integer
    Dim sProv As String
    Dim sGroup As String
    Dim sSgroup As String
    Dim sProd As String
    Dim sWhere As String

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        ReporteMovimientos(e)
    End Sub


    Private Sub ReporteMovimientos(ByVal e As LibX.XBeforeExecuteQueryEventArgs)

        Dim xSelect As LibX.Data.XSelecStmt
        Dim oTable As DataTable
        Dim fecha_ini As Object
        Dim SelectStmt As String
        Dim ID As Integer
        Dim oReport As LibX.ReportLib
        Dim Ffin As String
        Try

            e.DoFill = False

            If Me.fecHasta.Value.ToString.Trim.Length <= 0 Then
                Throw New ApplicationException("Debe especificar la fecha de cierre")
            End If

            If Not IsDate(Me.fecHasta.Value) Then
                Throw New ApplicationException("Debe especificar una fecha válida")
            End If

            If CType(fecHasta.Value, Date) > LibX.Data.Manager.Connection.GetDate Then
                Throw New ApplicationException("La Fecha no puede ser mayor a la fecha del día")
            End If

            If Not LibX.IsNull(e.row!whse_code) Then
                sWhse = e.row!whse_code.ToString
            End If

            If Not LibX.IsNull(e.row!prov_code) Then
                sProv = e.row!prov_code.ToString
            End If

            If Not LibX.IsNull(e.row!group_code) Then
                sGroup = e.row!group_code.ToString
            End If

            If Not LibX.IsNull(e.row!sgroup_code) Then
                sSgroup = e.row!sgroup_code.ToString
            End If

            If Not LibX.IsNull(e.row!item_code) Then
                sProd = e.row!item_code.ToString
            End If

            Ffin = CDate(Me.fecHasta.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)


            oReport = New LibX.ReportLib("INV", "r_ivonhnd01.rpt")

            With oReport

                .ParameterFields(1) = String.Concat("@FechaF;", Ffin, ";true")

                If Me.chk_cero.Checked = True Then
                    .ParameterFields(2) = String.Concat("@mayormenor;", True, ";true")
                Else
                    .ParameterFields(2) = String.Concat("@mayormenor;", False, ";true")
                End If
                If Trim(sWhse) <> "" Then
                    .ParameterFields(3) = String.Concat("@almacen;", sWhse, ";true")
                Else
                    .ParameterFields(3) = String.Concat("@almacen;", "-10", ";true")
                End If

                If Trim(sProv) <> "" Then
                    .ParameterFields(4) = String.Concat("@suplidor;", sProv, ";true")
                Else
                    .ParameterFields(4) = String.Concat("@suplidor;", "-10", ";true")
                End If

                If Trim(sGroup) <> "" Then
                    .ParameterFields(5) = String.Concat("@grupo;", sGroup, ";true")
                Else
                    .ParameterFields(5) = String.Concat("@grupo;", "-10", ";true")
                End If

                If Trim(sSgroup) <> "" Then
                    .ParameterFields(6) = String.Concat("@sugrupo;", sSgroup, ";true")
                Else
                    .ParameterFields(6) = String.Concat("@sugrupo;", "-10", ";true")
                End If

                If Trim(sProd) <> "" Then
                    .ParameterFields(7) = String.Concat("@producto;", sProd, ";true")
                Else
                    .ParameterFields(7) = String.Concat("@producto;", "-10", ";true")
                End If


                .RetrieveSQLQuery()
                .Action = 1

            End With
        Catch ex As Exception
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
            LibX.Log.Show(ex)
        End Try


    End Sub
    'Private Sub imprimir()
    '    Dim oRep As LibX.ReportLib
    '    Dim SelectStmt As String
    '    Try

    '        If chk_cero.Checked = True Then
    '            '//resumido
    '            oRep = New LibX.ReportLib("INV", "r_ivonhnd00.rpt")
    '        Else
    '            '//detallado
    '            oRep = New LibX.ReportLib("INV", "r_ivonhnd01.rpt")
    '        End If
    '        sWhere = " 1=1 "
    '        'If Trim(almacen) <> "" Then
    '        '    sWhere = String.Concat(sWhere, " and ivitemd.whse_code = ", Trim(almacen))
    '        'End If
    '        If Trim(sProv) <> "" Then
    '            sWhere = String.Concat(sWhere, " and ivitemm.prov_code = ", Trim(sProv))
    '        End If
    '        If Trim(sGroup) <> "" Then
    '            sWhere = String.Concat(sWhere, " and ivitemm.group_code = ", Trim(sGroup))
    '        End If
    '        If Trim(sSgroup) <> "" Then
    '            sWhere = String.Concat(sWhere, " and ivitemm.sgroup_code = ", Trim(sSgroup))
    '        End If
    '        If Trim(sProd) <> "" Then
    '            sWhere = String.Concat(sWhere, " and ivitemm.item_code = ", Trim(sProd))
    '        End If
    '        If Me.chk_cero.Checked = False Then
    '            sWhere = String.Concat(sWhere, " and ivitemr.onhand >0 ")
    '        End If

    '        With oRep
    '            Me.fecHasta.Value = LibX.Data.Manager.GetScalar("select max(fecha) from ivitemr")
    '            .ParameterFields(1) = "FechaCierre;" & Me.fecHasta.Value & ";TRUE"
    '            .RetrieveSQLQuery()
    '            SelectStmt = .SQLQuery
    '            SelectStmt = LibX.MdlUtil.ReplaceWherePart(SelectStmt, sWhere)
    '            .SQLQuery = SelectStmt
    '            .Action = 1
    '        End With

    '        Me.ProgressBar1.Maximum = 0
    '        Me.ProgressBar1.Minimum = 0

    '    Catch ex As Exception
    '        LibX.Log.Show(ex)
    '    End Try
    'End Sub

    'Private Function AplicarMovimientos(ByVal iTemcode As String, ByVal fAlmacen As Integer, ByVal fEcha As Date, ByVal fEchaf As Date, ByVal eXistencia As Integer) As Integer
    '    Dim SelectStmt As String
    '    Dim oTable As DataTable
    '    Dim iDias As Integer
    '    Try
    '        fEcha = FechaCierreMasUnDia(fEcha)
    '        If fAlmacen <> 0 Then
    '            SelectStmt = "select sum(qty*factor*doc_input) qty  from vitranrvv where item_code ='" & iTemcode.Trim & "'" & _
    '                         " and vitranrvv.whse_code = " & fAlmacen & _
    '                         " and vitranrvv.doc_date between '" & fEcha.ToString(LibX.Data.Manager.GetSaveDateFormat) & _
    '                         "' and '" & fEchaf.ToString(LibX.Data.Manager.GetSaveDateFormat) & "'" & _
    '                         " group by vitranrvv.item_code "
    '        Else
    '            SelectStmt = "select sum(qty*factor*doc_input) qty  from vitranrvv where item_code ='" & iTemcode.Trim & "'" & _
    '                         " and vitranrvv.doc_date between '" & fEcha.ToString(LibX.Data.Manager.GetSaveDateFormat) & _
    '                         "' and '" & fEchaf.ToString(LibX.Data.Manager.GetSaveDateFormat) & "'" & _
    '                        " group by vitranrvv.item_code "

    '        End If

    '        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)
    '        If Not oTable Is Nothing Then
    '            For Each orow As DataRow In oTable.Rows
    '                eXistencia += Val(orow!qty.ToString)
    '            Next
    '        End If

    '        Return eXistencia

    '    Catch ex As Exception
    '        LibX.Log.Show(ex)
    '        Return -1
    '    End Try
    'End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Me.LibXConnector1.AcceptFind()
        Me.LibXConnector1.Find()
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
            If e.Action = LibxConnectionActions.Find Then
                ShowLastClose()
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub ShowLastClose()
        Dim SelectStmt As String
        Dim DateClose As String
        Try

            SelectStmt = "select max(doc_date) from ivnocierrm"
            DateClose = LibX.Data.Manager.GetScalar(SelectStmt).ToString
            If DateClose = "" Then
                lblLastClose.Text = "NULL"
            Else
                lblLastClose.Text = CType(DateClose, Date).ToShortDateString
                fecHasta.Value = lblLastClose.Text
            End If


        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub r_ivonhnd01_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Limpiar()
    End Sub

    'Private Sub Limpiar()
    '    Dim DeleteStmt As String
    '    Try
    '        DeleteStmt = "delete from ivitemr where 1=1"
    '        LibX.Data.Manager.ExecuteNonQuery(DeleteStmt)
    '        'DeleteStmt = "delete from ivnocierrm where 1=1"
    '        LibX.Data.Manager.ExecuteNonQuery(DeleteStmt)
    '    Finally
    '        ivitemr.Rows.Clear()
    '    End Try
    'End Sub

    'Private Sub fecHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecHasta.ValueChanged
    '    Try
    '        If Me.fecHasta.Value > Now Then
    '            Me.fecHasta.Value = CDate(Now).ToString(LibX.Data.Manager.GetSaveDateFormat)
    '            Throw New ApplicationException("La fecha no puede ser mayor que la fecha del dia!")
    '        End If
    '    Catch ex As Exception
    '        LibX.Log.Show(ex)
    '    End Try
    'End Sub

    Private Sub Chk_resumen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.chk_cero.Checked = True Then
            Me.Label5.Text = "LISTADO DE EXISTENCIA CANTIDAD MAYOR QUE CERO"
        Else
            Me.Label5.Text = "LISTADO DE EXISTENCIA CON CANTIDAD EN NEGATIVO"
        End If
    End Sub
    'Private Sub ValorInvCerrado(ByVal DateClose As DateTime)
    '    Dim XUpdate As LibX.Data.XUpdateStmt
    '    Dim SelectStmt As String
    '    Dim ValorInv As Decimal
    '    Dim oAnio As Integer
    '    Dim oMes As Integer
    '    Dim oDia As Integer
    '    Dim oFecha As String
    '    Try
    '        oFecha = Format(DateClose, "yyyy-MM-dd")
    '        SelectStmt = "select sum(onhand*costus) from ivitemr "
    '        ValorInv = LibX.Data.Manager.GetScalar(SelectStmt).ToString

    '        XUpdate = New LibX.Data.XUpdateStmt("cgperdd")
    '        XUpdate.FieldsSet("ic_balance") = ValorInv.ToString
    '        XUpdate.Fields("perdr_year") = Year(DateClose)
    '        XUpdate.Fields("perdr_num") = Month(DateClose)
    '        XUpdate.Execute()

    '    Catch ex As Exception
    '        LibX.Log.Add(ex)
    '    End Try
    'End Sub

    Private Function FechaCierreMasUnDia(ByVal Fecha As DateTime) As DateTime
        Dim iDias As Integer
        iDias = DateDiff(DateInterval.Day, Fecha, Fecha) + 1
        Return DateAdd(DateInterval.Day, iDias, Fecha)
    End Function


End Class
