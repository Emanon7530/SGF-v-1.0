Public Class i_ptvfact06
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents xlk_item_code As LibX.LibXLookup
    Friend WithEvents xtxt_item_code As LibX.XTextBox
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents ftfactd3 As System.Data.DataTable
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
    Friend WithEvents lblfact_reposicion As System.Windows.Forms.Label
    Friend WithEvents lblitem_name As System.Windows.Forms.Label
    Friend WithEvents xtxt_dosis As LibX.XTextBox
    Friend WithEvents xtxt_dias As LibX.XTextBox
    Friend WithEvents xtxt_qty As LibX.XTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.xlk_item_code = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ftfactd3 = New System.Data.DataTable
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
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.lblfact_reposicion = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblitem_name = New System.Windows.Forms.Label
        Me.xtxt_item_code = New LibX.XTextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.xtxt_dosis = New LibX.XTextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.xtxt_dias = New LibX.XTextBox
        Me.xtxt_qty = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.lblMessage = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactd3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.xlk_item_code)
        Me.GroupBox3.Controls.Add(Me.lblfact_reposicion)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lblitem_name)
        Me.GroupBox3.Controls.Add(Me.xtxt_item_code)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.xtxt_dosis)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.xtxt_dias)
        Me.GroupBox3.Controls.Add(Me.xtxt_qty)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(552, 176)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'xlk_item_code
        '
        Me.xlk_item_code.AlternateFieldSearch = Nothing
        Me.xlk_item_code.BeginCheck = False
        Me.xlk_item_code.CheckText = Nothing
        Me.xlk_item_code.ComboMode = False
        Me.xlk_item_code.DataMember = Nothing
        Me.xlk_item_code.DataSource = Me.LibXConnector1
        Me.xlk_item_code.DestParameters = New String() {"item_code=item_code", "lblitem_name=item_name"}
        Me.xlk_item_code.FilterField = Nothing
        Me.xlk_item_code.IgnoreFindInBrowseMode = False
        Me.xlk_item_code.isCanceled = False
        Me.xlk_item_code.Location = New System.Drawing.Point(584, 72)
        Me.xlk_item_code.LookCaption = Nothing
        Me.xlk_item_code.Name = "xlk_item_code"
        Me.xlk_item_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_item_code.ShowFilter = True
        Me.xlk_item_code.ShowMessageNotFound = True
        Me.xlk_item_code.ShowWarning = False
        Me.xlk_item_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_item_code.SizesColumns = Nothing
        Me.xlk_item_code.SizesColumnsTab = Nothing
        Me.xlk_item_code.SqlString = Nothing
        Me.xlk_item_code.SQLTab = Nothing
        Me.xlk_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.xlk_item_code.TabIndex = 32
        Me.xlk_item_code.TableName = "ivitemm"
        Me.xlk_item_code.TabStop = False
        Me.xlk_item_code.UseCopyConnection = False
        Me.xlk_item_code.UseRowRetrieveEvents = False
        Me.xlk_item_code.UseTab = False
        Me.xlk_item_code.VisParameters = New String() {"Codigo=item_code", "Nombre=item_name"}
        Me.xlk_item_code.WhereCondition = Nothing
        Me.xlk_item_code.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "ftfactd3"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftfactd3})
        '
        'ftfactd3
        '
        Me.ftfactd3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13})
        Me.ftfactd3.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"fact3_serial"}, True)})
        Me.ftfactd3.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.ftfactd3.TableName = "ftfactd3"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "fact3_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "ftserial_no"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "item_code"
        Me.DataColumn3.MaxLength = 20
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "cust_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "fact_date"
        Me.DataColumn5.DataType = GetType(System.DateTime)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "qty"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "dosis"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "dias"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "uso_continuo"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "fact_date1"
        Me.DataColumn10.DataType = GetType(System.DateTime)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "cust_code1"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "unit_code"
        Me.DataColumn12.MaxLength = 4
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "factor"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'LibXDbSourceTable2
        '
        Me.LibXDbSourceTable2.AllowDelete = True
        Me.LibXDbSourceTable2.AllowEdit = True
        Me.LibXDbSourceTable2.AllowNew = True
        Me.LibXDbSourceTable2.AutoIncrementSerial = True
        Me.LibXDbSourceTable2.CustomDbUpdate = False
        Me.LibXDbSourceTable2.DeleteOrder = 0
        Me.LibXDbSourceTable2.FillOnQuery = True
        Me.LibXDbSourceTable2.FillOnRowChange = False
        Me.LibXDbSourceTable2.HeaderIsOnGrid = False
        Me.LibXDbSourceTable2.InnerJon = True
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = False
        Me.LibXDbSourceTable2.KeyFields = "fact3_serial"
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"SELECT ftfactd3.*,", "ftfactm.fact_date,", "ftfactm.cust_code,", "ftfactd.unit_code,", "ftfactd.factor", "from ftfactd3", "inner join ftfactd", "on ftfactd.item_code = ftfactd3.item_code", "and ftfactd.ftserial_no = ftfactd3.ftserial_no", "inner join ftfactm", "on ftfactm.ftserial_no = ftfactd.ftserial_no"}
        Me.LibXDbSourceTable2.TableName = "ftfactd3"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'lblfact_reposicion
        '
        Me.lblfact_reposicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblfact_reposicion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblfact_reposicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfact_reposicion.ForeColor = System.Drawing.Color.Blue
        Me.lblfact_reposicion.Location = New System.Drawing.Point(440, 128)
        Me.lblfact_reposicion.Name = "lblfact_reposicion"
        Me.lblfact_reposicion.Size = New System.Drawing.Size(104, 32)
        Me.lblfact_reposicion.TabIndex = 6
        Me.lblfact_reposicion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(71, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 16)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Dias:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(336, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 22)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Reposicion:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblitem_name
        '
        Me.lblitem_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblitem_name.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblitem_name.Location = New System.Drawing.Point(232, 24)
        Me.lblitem_name.Name = "lblitem_name"
        Me.lblitem_name.Size = New System.Drawing.Size(304, 20)
        Me.lblitem_name.TabIndex = 22
        '
        'xtxt_item_code
        '
        Me.xtxt_item_code.AcceptsReturn = True
        Me.xtxt_item_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactd3.item_code"))
        Me.xtxt_item_code.EditInitialValue = Nothing
        Me.xtxt_item_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_item_code.FieldDescription = ""
        Me.xtxt_item_code.FindInitialValue = Nothing
        Me.xtxt_item_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_item_code.IgnoreRequiered = False
        Me.xtxt_item_code.Location = New System.Drawing.Point(120, 24)
        Me.xtxt_item_code.Name = "xtxt_item_code"
        Me.xtxt_item_code.NewInitialValue = Nothing
        Me.xtxt_item_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_item_code.ReadOnly = True
        Me.xtxt_item_code.Requiered = False
        Me.xtxt_item_code.Size = New System.Drawing.Size(104, 20)
        Me.xtxt_item_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_item_code.TabIndex = 2
        Me.xtxt_item_code.TabStop = False
        Me.xtxt_item_code.Text = ""
        Me.xtxt_item_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label23.Location = New System.Drawing.Point(48, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 16)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Producto:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label24.Location = New System.Drawing.Point(48, 61)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 16)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "Cantidad:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_dosis
        '
        Me.xtxt_dosis.AcceptsReturn = True
        Me.xtxt_dosis.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ftfactd3, "dosis"))
        Me.xtxt_dosis.EditInitialValue = Nothing
        Me.xtxt_dosis.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_dosis.FieldDescription = ""
        Me.xtxt_dosis.FindInitialValue = Nothing
        Me.xtxt_dosis.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_dosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_dosis.IgnoreRequiered = False
        Me.xtxt_dosis.Location = New System.Drawing.Point(120, 88)
        Me.xtxt_dosis.Name = "xtxt_dosis"
        Me.xtxt_dosis.NewInitialValue = Nothing
        Me.xtxt_dosis.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_dosis.Requiered = True
        Me.xtxt_dosis.Size = New System.Drawing.Size(104, 32)
        Me.xtxt_dosis.StatusBarPanelDescripcion = Nothing
        Me.xtxt_dosis.TabIndex = 1
        Me.xtxt_dosis.Text = ""
        Me.xtxt_dosis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label25.Location = New System.Drawing.Point(32, 98)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(69, 16)
        Me.Label25.TabIndex = 19
        Me.Label25.Text = "Dosificación:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_dias
        '
        Me.xtxt_dias.AcceptsReturn = True
        Me.xtxt_dias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ftfactd3, "dias"))
        Me.xtxt_dias.EditInitialValue = Nothing
        Me.xtxt_dias.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_dias.FieldDescription = ""
        Me.xtxt_dias.FindInitialValue = Nothing
        Me.xtxt_dias.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_dias.IgnoreRequiered = False
        Me.xtxt_dias.Location = New System.Drawing.Point(120, 128)
        Me.xtxt_dias.Name = "xtxt_dias"
        Me.xtxt_dias.NewInitialValue = Nothing
        Me.xtxt_dias.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_dias.Requiered = True
        Me.xtxt_dias.Size = New System.Drawing.Size(104, 32)
        Me.xtxt_dias.StatusBarPanelDescripcion = Nothing
        Me.xtxt_dias.TabIndex = 2
        Me.xtxt_dias.Text = ""
        Me.xtxt_dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xtxt_qty
        '
        Me.xtxt_qty.AcceptsReturn = True
        Me.xtxt_qty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ftfactd3, "qty"))
        Me.xtxt_qty.EditInitialValue = Nothing
        Me.xtxt_qty.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_qty.FieldDescription = ""
        Me.xtxt_qty.FindInitialValue = Nothing
        Me.xtxt_qty.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_qty.IgnoreRequiered = False
        Me.xtxt_qty.Location = New System.Drawing.Point(120, 48)
        Me.xtxt_qty.Name = "xtxt_qty"
        Me.xtxt_qty.NewInitialValue = Nothing
        Me.xtxt_qty.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_qty.Requiered = True
        Me.xtxt_qty.Size = New System.Drawing.Size(104, 32)
        Me.xtxt_qty.StatusBarPanelDescripcion = Nothing
        Me.xtxt_qty.TabIndex = 0
        Me.xtxt_qty.Text = ""
        Me.xtxt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(570, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CAPTURA DE DOSIFICACION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(408, 248)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar(F5)"
        Me.ToolTip1.SetToolTip(Me.btnAceptar, "Terminar de procesar el seguro medico")
        Me.btnAceptar.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(488, 248)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancelar la operación y cerrar esta pantalla")
        '
        'lblMessage
        '
        Me.lblMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(8, 248)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(384, 23)
        Me.lblMessage.TabIndex = 4
        '
        'i_ptvfact06
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(570, 280)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "i_ptvfact06"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Captura de Dosificación"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactd3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim oSeguimiento As SGT.PuntodeVenta.Entidades.SeguimientoAsegurado

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If LibXConnector1.IsDataEditing = True Then
            LibXConnector1.Cancel()
        End If
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim Sqlstring As String
        Dim oTable As DataTable
        Try
            '// Validar dosis
            If ValidarMonto() = False Then
                Exit Sub
            End If

            '// Asignar Valores al parametro
            SetPropertyValue()

            '// guardar registro
            LibXConnector1.Accept()
            Me.DialogResult = DialogResult.OK

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub SetPropertyValue()
        Try
            oSeguimiento.Dias = Val(Me.xtxt_dias.Text.Trim)
            oSeguimiento.Dosis = Val(Me.xtxt_dosis.Text.Trim)
            oSeguimiento.Cantidad = Val(Me.xtxt_qty.Text.Trim)

            If oSeguimiento.Dias > 0 Then
                lblfact_reposicion.Text = oSeguimiento.Fecha.AddDays(oSeguimiento.Dias)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub
    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        EditarValores()
    End Sub
    Private Sub EditarValores()
        Try

            Me.xtxt_qty.Text = (oSeguimiento.Cantidad * oSeguimiento.Factor).ToString
            Me.xtxt_dias.Text = oSeguimiento.Dias.ToString
            Me.xtxt_dosis.Text = oSeguimiento.Dosis.ToString
            xtxt_item_code.Text = oSeguimiento.Producto.ToString
            xlk_item_code.ExecuteFind()

            If oSeguimiento.Codigo > 0 Then
                oSeguimiento.Estatus = SGT.PuntodeVenta.Entidades.SeguimientoAsegurado.EstatusEnum.Edited
            Else
                oSeguimiento.Estatus = SGT.PuntodeVenta.Entidades.SeguimientoAsegurado.EstatusEnum.Added
            End If
            Calculos()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub Calculos()
        Dim Total As Decimal
        Dim Cobertura As Decimal
        Dim Pagar As Decimal

        Try
            lblfact_reposicion.Text = oSeguimiento.Fecha.AddDays(oSeguimiento.Dias).ToString("dd/MM/yyyy")


        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xtxt_seg_amount_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Try
            Calculos()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibX.LibxConnectionActions.Add _
            Or e.Action = LibX.LibxConnectionActions.Edit Then
                Me.btnAceptar.Visible = True
                Me.xtxt_qty.Focus()
            End If
            If e.Action = LibX.LibxConnectionActions.Accept Then
                If ValidarMonto() = False Then
                    Me.lblMessage.Text = "Valor de la Cobertura no puede ser mayor al monto facturado!"
                    Exit Sub
                End If
            End If

            SetPropertyValue()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Public Overloads Function ShowDialog(ByVal pSeguimiento As SGT.PuntodeVenta.Entidades.SeguimientoAsegurado) As DialogResult
        oSeguimiento = pSeguimiento

        Return MyBase.ShowDialog
    End Function

    Private Sub i_ptvfact02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub i_ptvfact02_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If LibXConnector1.IsDataEditing = True Then
                If e.KeyCode = Keys.F5 Then
                    '// Validar Cobertura no sea mayor que monto facturado
                    ValidarMonto()

                    '// Asignar Valor
                    SetPropertyValue()

                    LibXConnector1.AcceptNew()
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Function ValidarMonto() As Boolean
        Dim dias As Integer
        Dim dosis As Integer
        Dim cantidad As Integer

        If Me.xtxt_dias.Text = "" Then
            Me.lblMessage.Text = "Debe especificar los dias de uso!"
            Return False
        End If

        If Me.xtxt_dosis.Text = "" Then
            Me.lblMessage.Text = "Debe especificar la dosis de uso!"
            Return False
        End If

        If Me.xtxt_qty.Text = "" Then
            Me.lblMessage.Text = "Debe especificar la cantidad despachada!"
            Return False
        End If

        dias = Val(Me.xtxt_dias.Text.Trim)
        dosis = Val(Me.xtxt_dosis.Text.Trim)
        cantidad = Val(Me.xtxt_qty.Text.Trim)

        If dias * dosis <> cantidad Then
            Me.lblMessage.Text = "La dosificación no coincide con la cantidad!"
            Return False
        End If

        Return True
    End Function

    Private Sub LibXConnector1_SettingDefaulteditValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultEditValues) Handles LibXConnector1.SettingDefaulteditValues
        EditarValores()

    End Sub
End Class
