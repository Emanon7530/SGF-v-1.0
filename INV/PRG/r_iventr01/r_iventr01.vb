Imports LibX
Imports Microsoft.Office.Interop
Public Class r_iventr01
    Inherits System.Windows.Forms.Form
    Dim r606 As Excel.Application

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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents prov_name As System.Windows.Forms.TextBox
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents txtprov_code As System.Windows.Forms.TextBox
    Friend WithEvents Chk_Normal As System.Windows.Forms.CheckBox
    Friend WithEvents lk_suc_code As LibX.LibXLookup
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents suc_name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents fechaini As LibX.LibxDateTimePicker
    Friend WithEvents fechafin As LibX.LibxDateTimePicker
    Friend WithEvents Chk_606 As System.Windows.Forms.CheckBox
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
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtprov_code = New System.Windows.Forms.TextBox
        Me.prov_name = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.fechaini = New LibX.LibxDateTimePicker
        Me.fechafin = New LibX.LibxDateTimePicker
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.Chk_Normal = New System.Windows.Forms.CheckBox
        Me.lk_suc_code = New LibX.LibXLookup
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.suc_name = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Chk_606 = New System.Windows.Forms.CheckBox
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
        Me.LibXConnector1.DataMember = "cpinvcem"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.DataTable1.TableName = "cpinvcem"
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
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "prov_code"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "tipo"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "suc_code"
        Me.DataColumn5.ColumnName = "suc_code"
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
        Me.LibXDbSourceTable1.Source = New String() {"select cpinvcem.prov_code,cctermm.tipo ", "from cpinvcem", "inner join  cctermm", "on cpinvcem.term_code = cctermm.term_code"}
        Me.LibXDbSourceTable1.TableName = "cpinvcem"
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
        Me.Label5.Text = "DIARIO DE COMPRAS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtprov_code
        '
        Me.txtprov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.prov_code"))
        Me.txtprov_code.Location = New System.Drawing.Point(96, 112)
        Me.txtprov_code.Name = "txtprov_code"
        Me.txtprov_code.Size = New System.Drawing.Size(56, 20)
        Me.txtprov_code.TabIndex = 24
        Me.txtprov_code.Text = ""
        '
        'prov_name
        '
        Me.prov_name.Location = New System.Drawing.Point(152, 112)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.ReadOnly = True
        Me.prov_name.Size = New System.Drawing.Size(248, 20)
        Me.prov_name.TabIndex = 26
        Me.prov_name.TabStop = False
        Me.prov_name.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(43, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Suplidor:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(24, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Fecha Inicial"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(25, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Fecha Final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(8, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Tipo Docmento:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fechaini
        '
        Me.fechaini.CustomFormat = "dd/MM/yyyy"
        Me.fechaini.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cpinvcem.fecha_ini"))
        Me.fechaini.EditInitialValue = Nothing
        Me.fechaini.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fechaini.FieldDescription = ""
        Me.fechaini.FindInitialValue = Nothing
        Me.fechaini.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fechaini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechaini.IgnoreRequiered = False
        Me.fechaini.Location = New System.Drawing.Point(96, 64)
        Me.fechaini.Name = "fechaini"
        Me.fechaini.NewInitialValue = Nothing
        Me.fechaini.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fechaini.Requiered = False
        Me.fechaini.Size = New System.Drawing.Size(88, 20)
        Me.fechaini.StatusBarPanelDescripcion = Nothing
        Me.fechaini.TabIndex = 33
        '
        'fechafin
        '
        Me.fechafin.CustomFormat = "dd/MM/yyyy"
        Me.fechafin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cpinvcem.fecha_fin"))
        Me.fechafin.EditInitialValue = Nothing
        Me.fechafin.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fechafin.FieldDescription = ""
        Me.fechafin.FindInitialValue = Nothing
        Me.fechafin.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechafin.IgnoreRequiered = False
        Me.fechafin.Location = New System.Drawing.Point(96, 88)
        Me.fechafin.Name = "fechafin"
        Me.fechafin.NewInitialValue = Nothing
        Me.fechafin.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fechafin.Requiered = False
        Me.fechafin.Size = New System.Drawing.Size(88, 20)
        Me.fechafin.StatusBarPanelDescripcion = Nothing
        Me.fechafin.TabIndex = 34
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cpinvcem.tipo"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = ""
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Items.AddRange(New Object() {"1-CREDITO", "2-CONTADO"})
        Me.LibXCombo1.Location = New System.Drawing.Point(96, 160)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = ""
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(152, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 35
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"prov_code=prov_code", "prov_name=prov_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(400, 112)
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
        Me.LibXLookup1.SrcParameters = New String() {"prov_code=prov_code"}
        Me.LibXLookup1.TabIndex = 36
        Me.LibXLookup1.TableName = "cpprovm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Codigo=prov_code", "Descripcion=prov_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'Chk_Normal
        '
        Me.Chk_Normal.Checked = True
        Me.Chk_Normal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_Normal.Location = New System.Drawing.Point(216, 72)
        Me.Chk_Normal.Name = "Chk_Normal"
        Me.Chk_Normal.Size = New System.Drawing.Size(56, 24)
        Me.Chk_Normal.TabIndex = 37
        Me.Chk_Normal.Text = "Global"
        '
        'lk_suc_code
        '
        Me.lk_suc_code.AlternateFieldSearch = Nothing
        Me.lk_suc_code.BeginCheck = False
        Me.lk_suc_code.CheckText = Nothing
        Me.lk_suc_code.ComboMode = False
        Me.lk_suc_code.DataMember = Nothing
        Me.lk_suc_code.DataSource = Me.LibXConnector1
        Me.lk_suc_code.DestParameters = New String() {"suc_code=suc_code", "suc_name=suc_name"}
        Me.lk_suc_code.FilterField = Nothing
        Me.lk_suc_code.IgnoreFindInBrowseMode = False
        Me.lk_suc_code.isCanceled = False
        Me.lk_suc_code.Location = New System.Drawing.Point(400, 136)
        Me.lk_suc_code.LookCaption = Nothing
        Me.lk_suc_code.Name = "lk_suc_code"
        Me.lk_suc_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lk_suc_code.ShowFilter = True
        Me.lk_suc_code.ShowMessageNotFound = True
        Me.lk_suc_code.ShowWarning = False
        Me.lk_suc_code.Size = New System.Drawing.Size(16, 20)
        Me.lk_suc_code.SizesColumns = Nothing
        Me.lk_suc_code.SizesColumnsTab = Nothing
        Me.lk_suc_code.SqlString = Nothing
        Me.lk_suc_code.SQLTab = Nothing
        Me.lk_suc_code.SrcParameters = New String() {"suc_code=suc_code"}
        Me.lk_suc_code.TabIndex = 41
        Me.lk_suc_code.TableName = "cgsucursal"
        Me.lk_suc_code.TabStop = False
        Me.lk_suc_code.UseCopyConnection = False
        Me.lk_suc_code.UseRowRetrieveEvents = False
        Me.lk_suc_code.UseTab = False
        Me.lk_suc_code.VisParameters = New String() {"Codigo=suc_code", "Descripcion=suc_name"}
        Me.lk_suc_code.WhereCondition = Nothing
        Me.lk_suc_code.WhereParameters = Nothing
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.suc_code"))
        Me.TextBox1.Location = New System.Drawing.Point(96, 136)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 20)
        Me.TextBox1.TabIndex = 39
        Me.TextBox1.Text = ""
        '
        'suc_name
        '
        Me.suc_name.Location = New System.Drawing.Point(152, 136)
        Me.suc_name.Name = "suc_name"
        Me.suc_name.ReadOnly = True
        Me.suc_name.Size = New System.Drawing.Size(248, 20)
        Me.suc_name.TabIndex = 40
        Me.suc_name.TabStop = False
        Me.suc_name.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(40, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Sucursal:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chk_606
        '
        Me.Chk_606.Location = New System.Drawing.Point(304, 72)
        Me.Chk_606.Name = "Chk_606"
        Me.Chk_606.Size = New System.Drawing.Size(88, 24)
        Me.Chk_606.TabIndex = 42
        Me.Chk_606.Text = "Generar606"
        '
        'r_iventr01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(530, 232)
        Me.Controls.Add(Me.Chk_606)
        Me.Controls.Add(Me.lk_suc_code)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.suc_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chk_Normal)
        Me.Controls.Add(Me.LibXLookup1)
        Me.Controls.Add(Me.LibXCombo1)
        Me.Controls.Add(Me.fechafin)
        Me.Controls.Add(Me.fechaini)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtprov_code)
        Me.Controls.Add(Me.prov_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "r_iventr01"
        Me.Text = "Diario de compras"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim AxCrystalReport1 As LibX.ReportLib
        Dim Archivo As String
        Dim rnc As String
        Dim sPer As String

        Try
            Dim oTable As DataTable
            Dim SelecStmt As String
            Dim sFechaDesde As String
            Dim sFechaHasta As String
            Dim sprov As String
            Dim sTipo As String
            Dim sSuc As String
            Dim sWhere As String

            If Not IsNull(e.row!fecha_ini) Then
                sFechaDesde = CDate(e.row!fecha_ini).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(e.row!fecha_fin) Then
                sFechaHasta = CDate(e.row!fecha_fin).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(e.row!prov_code) Then
                sprov = e.row!prov_code
            End If

            If Not IsNull(e.row!tipo) Then
                sTipo = e.row!tipo
            End If

            If Not IsNull(e.row!suc_code) Then
                sSuc = e.row!suc_code
            End If

            If Chk_606.Checked = True Then
                sWhere = " 1=1 "
                If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                    sWhere = String.Concat(sWhere, " and doc_date between '", sFechaDesde, "' and '", sFechaHasta, "'")
                ElseIf Trim(sFechaDesde) <> "" Then
                    sWhere = String.Concat(sWhere, " and doc_date >= '", sFechaDesde, "'")
                ElseIf Trim(sFechaHasta) <> "" Then
                    sWhere = String.Concat(sWhere, " and doc_date <= '", sFechaHasta, "'")
                End If

                If sprov <> "" Then
                    sWhere = String.Concat(sWhere, " and cpprovm.prov_code = ", sprov)
                End If

                If sTipo <> "" Then
                    sWhere = String.Concat(sWhere, " and cctermm.tipo = ", sTipo)
                End If
                If sSuc <> "" Then
                    sWhere = String.Concat(sWhere, " and cpinvcem.suc_code = ", sSuc)
                End If

                sWhere = String.Concat(sWhere, " and cpinvcem.type_code <> 'CUS'")

                SelecStmt = " select cpprovm.rnc_id,cpinvcem.invce_service,cpservices.service_name," & _
                            " cpinvcem.invce_ncf,'A010010010100000000' as invce_ncfafect," & _
                            " cpinvcem.doc_date,'2012-12-31 00:00:00.000' as fecha_pago,cpinvcem.itbis," & _
                            " '0' as itbis_retenido,cpinvcem.amount " & _
                            "from cpinvcem inner join cpprovm on cpprovm.prov_code = cpinvcem.prov_code" & _
                            " inner join cpservices on cpservices.service_code = cpinvcem.invce_service "

                SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)

                oTable = LibX.Data.Manager.GetDataTable(SelecStmt)
                If oTable Is Nothing Then
                    Throw New ApplicationException("No hay transacciones para este periodo")
                End If

                rnc = LibX.Data.Manager.GetScalar("select comp_rnc from stinform")
                sPer = CDate(e.row!fecha_fin).Year.ToString("0000") & CDate(e.row!fecha_fin).Month.ToString("00")

                r606 = New Excel.Application
                Archivo = System.Configuration.ConfigurationSettings.AppSettings.Get("Libxt606").ToString.Trim

                Dim newCulture As System.Globalization.CultureInfo
                Dim OldCulture As System.Globalization.CultureInfo

                OldCulture = System.Threading.Thread.CurrentThread.CurrentCulture
                newCulture = New System.Globalization.CultureInfo( _
                    r606.LanguageSettings.LanguageID(Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDUI))
                System.Threading.Thread.CurrentThread.CurrentCulture = newCulture
                Dim x606Open As Excel.Workbooks = r606.Workbooks

                Dim x606Add As Excel.Workbook = x606Open.Open(Archivo)
                Dim args As Object = Archivo

                'x606Add.GetType().InvokeMember("Open", Reflection.BindingFlags.InvokeMethod, Nothing, x606Add, args, oldCI)

                Dim x606Read As Excel.Sheets = x606Add.Worksheets
                Dim x606Wrhite As Excel.Worksheet = x606Read(1)
                x606Wrhite.Unprotect("AAAABABBAAA2")
                x606Add.Unprotect("AAAABABBAAA2")
                Dim fecha As DateTime
                Dim fechaPago As DateTime

                x606Wrhite.Range("C4").Value = rnc
                x606Wrhite.Range("C5").Value = sPer
                x606Wrhite.Range("C6").Value = oTable.Rows.Count
                Dim linea As Integer = 12
                Dim serv As Integer
                Dim amountg As Decimal
                For Each oRow As DataRow In oTable.Rows
                    x606Wrhite.Range("B" & linea).Value = oRow!rnc_id
                    If Len(oTable.Rows(0)!rnc_id) = 9 Then
                        x606Wrhite.Range("C" & linea).Value = 1
                    Else
                        x606Wrhite.Range("C" & linea).Value = 2
                    End If
                    serv = oRow!invce_service
                    x606Wrhite.Range("D" & linea).Value = serv.ToString("00") & "-" & oRow!service_name
                    x606Wrhite.Range("E" & linea).Value = oRow!invce_ncf
                    x606Wrhite.Range("F" & linea).Value = oRow!invce_ncfafect
                    If Not IsNull(oRow!doc_date) Then
                        fecha = oRow!doc_date
                    End If
                    x606Wrhite.Range("G" & linea).Value = fecha.Year.ToString("0000") & fecha.Month.ToString("00")
                    x606Wrhite.Range("H" & linea).Value = fecha.Day.ToString("00")
                    If Not IsNull(oRow!fecha_pago) Then
                        fechaPago = oRow!fecha_pago
                        x606Wrhite.Range("I" & linea).Value = fechaPago.Year.ToString("0000") & fechaPago.Month.ToString("00")
                        x606Wrhite.Range("J" & linea).Value = fechaPago.Day.ToString("00")
                    End If
                    x606Wrhite.Range("K" & linea).Value = oRow!itbis
                    x606Wrhite.Range("L" & linea).Value = oRow!itbis_retenido
                    x606Wrhite.Range("M" & linea).Value = oRow!amount
                    linea = linea + 1
                    amountg = amountg + oRow!amount
                Next
                x606Wrhite.Range("C7").Value = amountg
                r606.Visible = True
                x606Wrhite.SaveAs("C:\F606\Herramienta de Envio Formato 606" & sPer & ".xls")
            Else

                If Me.Chk_Normal.Checked = True Then
                    AxCrystalReport1 = New LibX.ReportLib("INV", "r_iventr01.rpt")
                Else
                    AxCrystalReport1 = New LibX.ReportLib("INV", "r_iventr001.rpt")
                End If

                If Me.Chk_Normal.Checked = True Then
                    With AxCrystalReport1
                        sWhere = " 1=1 "
                        If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                            sWhere = String.Concat(sWhere, " and doc_date between '", sFechaDesde, "' and '", sFechaHasta, "'")
                        ElseIf Trim(sFechaDesde) <> "" Then
                            sWhere = String.Concat(sWhere, " and doc_date >= '", sFechaDesde, "'")
                        ElseIf Trim(sFechaHasta) <> "" Then
                            sWhere = String.Concat(sWhere, " and doc_date <= '", sFechaHasta, "'")
                        End If

                        If sprov <> "" Then
                            sWhere = String.Concat(sWhere, " and cpprovm.prov_code = ", sprov)
                        End If

                        If sTipo <> "" Then
                            sWhere = String.Concat(sWhere, " and cctermm.tipo = ", sTipo)
                        End If
                        If sSuc <> "" Then
                            sWhere = String.Concat(sWhere, " and repcomprasv.suc_code = ", sSuc)
                        End If

                        .ParameterFields(1) = String.Concat("Fecha_ini;", Trim(sFechaDesde), ";TRUE")
                        .ParameterFields(2) = String.Concat("Fecha_fin;", Trim(sFechaHasta), ";TRUE")
                        '// Recibir el SQL Query
                        .RetrieveSQLQuery()
                        SelecStmt = .SQLQuery
                        SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                        .SQLQuery = SelecStmt

                        '// Ejecutar el reporte
                        .Action = 1
                    End With
                Else

                    With AxCrystalReport1
                        sWhere = " 1=1 "
                        If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                            sWhere = String.Concat(sWhere, " and repcomprasv.doc_date between '", sFechaDesde, "' and '", sFechaHasta, "'")
                        ElseIf Trim(sFechaDesde) <> "" Then
                            sWhere = String.Concat(sWhere, " and repcomprasv.doc_date >= '", sFechaDesde, "'")
                        ElseIf Trim(sFechaHasta) <> "" Then
                            sWhere = String.Concat(sWhere, " and repcomprasv.doc_date <= '", sFechaHasta, "'")
                        End If

                        If sprov <> "" Then
                            sWhere = String.Concat(sWhere, " and repcomprasv.prov_code = ", sprov)
                        End If

                        If sTipo <> "" Then
                            sWhere = String.Concat(sWhere, " and repcomprasv.tipo = ", sTipo)
                        End If
                        If sSuc <> "" Then
                            sWhere = String.Concat(sWhere, " and repcomprasv.suc_code = ", sSuc)
                        End If

                        'sWhere = String.Concat(sWhere, " and len(repcomprasv.invce_ncf) >2  ")

                        .ParameterFields(1) = String.Concat("Fecha_ini;", Trim(sFechaDesde), ";TRUE")
                        .ParameterFields(2) = String.Concat("Fecha_fin;", Trim(sFechaHasta), ";TRUE")
                        '// Recibir el SQL Query
                        .RetrieveSQLQuery()
                        SelecStmt = .SQLQuery
                        SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                        .SQLQuery = SelecStmt

                        '// Ejecutar el reporte
                        .Action = 1
                    End With

                End If

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
    End Sub

    Private Sub LibXConnector1_SettingDefaultqueryValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultQueryValues) Handles LibXConnector1.SettingDefaultqueryValues

    End Sub
End Class
