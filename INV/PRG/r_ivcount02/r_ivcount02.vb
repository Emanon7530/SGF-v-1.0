Imports LibX
Imports SGT.Inventario.Entidades.Documento
Public Class r_ivcount02
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
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents whse_name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnUnmarkall As System.Windows.Forms.Button
    Friend WithEvents btnMarkAll As System.Windows.Forms.Button
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox2 As LibX.LibxCheckBox
    Friend WithEvents ivcounte As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents chk_byPage As System.Windows.Forms.CheckBox
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents xcbo_doc_status As LibX.LibXCombo
    Friend WithEvents xdt_count_date As LibX.LibxDateTimePicker
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gColcount_number As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gcolpageno As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ButtonVisualizar As System.Windows.Forms.Button
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents gColAplicar As LibX.XDataGridBoolColumn
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents xlk_whse_code As LibX.LibXLookup
    Friend WithEvents txt_whse_code As System.Windows.Forms.TextBox
    Friend WithEvents txt_pageNo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ivcounte = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.DataView1 = New System.Data.DataView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.xdt_count_date = New LibX.LibxDateTimePicker
        Me.xcbo_doc_status = New LibX.LibXCombo
        Me.Label4 = New System.Windows.Forms.Label
        Me.chk_byPage = New System.Windows.Forms.CheckBox
        Me.xlk_whse_code = New LibX.LibXLookup
        Me.Label3 = New System.Windows.Forms.Label
        Me.whse_name = New System.Windows.Forms.TextBox
        Me.txt_whse_code = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_pageNo = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.LibxCheckBox2 = New LibX.LibxCheckBox
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.btnUnmarkall = New System.Windows.Forms.Button
        Me.btnMarkAll = New System.Windows.Forms.Button
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColAplicar = New LibX.XDataGridBoolColumn
        Me.gColcount_number = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gcolpageno = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.ButtonVisualizar = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivcounte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = False
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "ivcounte"
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
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable3})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivcounte})
        '
        'ivcounte
        '
        Me.ivcounte.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn9, Me.DataColumn8, Me.DataColumn10})
        Me.ivcounte.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"count_number", "pageno"}, True)})
        Me.ivcounte.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn7}
        Me.ivcounte.TableName = "ivcounte"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "count_number"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "prov_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "whse_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "count_date"
        Me.DataColumn4.DataType = GetType(System.DateTime)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "count_desc"
        Me.DataColumn5.MaxLength = 60
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "count_status"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "pageno"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Aplicar"
        Me.DataColumn9.DataType = GetType(System.Int16)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "userid"
        Me.DataColumn8.MaxLength = 20
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "status_name"
        Me.DataColumn10.MaxLength = 11
        Me.DataColumn10.ReadOnly = True
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
        Me.LibXDbSourceTable3.SerialColumnName = "count_number"
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = New String() {"select DISTINCT ivcounte.*,ivcountd.pageno, ivcountd.count_status ,", "case ivcountd.count_status ", "" & Microsoft.VisualBasic.ChrW(9) & "when 0 then 'Generarda' ", "" & Microsoft.VisualBasic.ChrW(9) & "when 1 then 'Editada'", "" & Microsoft.VisualBasic.ChrW(9) & "when 2 then 'Impresa'", "" & Microsoft.VisualBasic.ChrW(9) & "when 3 then 'Aplicada'", "" & Microsoft.VisualBasic.ChrW(9) & "else 'No/Definido'", "end status_name", "from ivcounte inner join ivcountd", "on ivcounte.count_number = ivcountd.count_number"}
        Me.LibXDbSourceTable3.TableName = "ivcounte"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(8, 523)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 48)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Progreso"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 16)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(424, 23)
        Me.ProgressBar1.TabIndex = 11
        '
        'DataView1
        '
        Me.DataView1.Table = Me.ivcounte
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.xdt_count_date)
        Me.GroupBox3.Controls.Add(Me.xcbo_doc_status)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.chk_byPage)
        Me.GroupBox3.Controls.Add(Me.xlk_whse_code)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.whse_name)
        Me.GroupBox3.Controls.Add(Me.txt_whse_code)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txt_pageNo)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.LibxCheckBox1)
        Me.GroupBox3.Controls.Add(Me.LibxCheckBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 104)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Criterio"
        '
        'xdt_count_date
        '
        Me.xdt_count_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_count_date.EditInitialValue = Nothing
        Me.xdt_count_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_count_date.FieldDescription = ""
        Me.xdt_count_date.FindInitialValue = Nothing
        Me.xdt_count_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_count_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_count_date.IgnoreRequiered = False
        Me.xdt_count_date.Location = New System.Drawing.Point(400, 24)
        Me.xdt_count_date.Name = "xdt_count_date"
        Me.xdt_count_date.NewInitialValue = Nothing
        Me.xdt_count_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_count_date.Requiered = False
        Me.xdt_count_date.Size = New System.Drawing.Size(104, 20)
        Me.xdt_count_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_count_date.TabIndex = 41
        '
        'xcbo_doc_status
        '
        Me.xcbo_doc_status.AllowDefaultSort = False
        Me.xcbo_doc_status.bound = True
        Me.xcbo_doc_status.currValue = Nothing
        Me.xcbo_doc_status.DefaultWhereString = Nothing
        Me.xcbo_doc_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_doc_status.EditInitialValue = Nothing
        Me.xcbo_doc_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_doc_status.FieldDescription = ""
        Me.xcbo_doc_status.FindInitialValue = Nothing
        Me.xcbo_doc_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_doc_status.IgnoreRequiered = False
        Me.xcbo_doc_status.Items.AddRange(New Object() {"0 - Generada", "1 - Editada", "2 - Impresa", "3 - Aplicada"})
        Me.xcbo_doc_status.Location = New System.Drawing.Point(112, 48)
        Me.xcbo_doc_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_doc_status.LookupKeyField = Nothing
        Me.xcbo_doc_status.LookupTableName = Nothing
        Me.xcbo_doc_status.Name = "xcbo_doc_status"
        Me.xcbo_doc_status.NewInitialValue = Nothing
        Me.xcbo_doc_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_doc_status.Requiered = False
        Me.xcbo_doc_status.Required = False
        Me.xcbo_doc_status.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_doc_status.SqlString = Nothing
        Me.xcbo_doc_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_doc_status.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(56, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Estatus:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_byPage
        '
        Me.chk_byPage.Checked = True
        Me.chk_byPage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_byPage.Location = New System.Drawing.Point(176, 24)
        Me.chk_byPage.Name = "chk_byPage"
        Me.chk_byPage.Size = New System.Drawing.Size(112, 16)
        Me.chk_byPage.TabIndex = 35
        Me.chk_byPage.Text = "Listar por Página"
        '
        'xlk_whse_code
        '
        Me.xlk_whse_code.AlternateFieldSearch = Nothing
        Me.xlk_whse_code.CheckText = Nothing
        Me.xlk_whse_code.ComboMode = False
        Me.xlk_whse_code.DataMember = Nothing
        Me.xlk_whse_code.DataSource = Me.LibXConnector1
        Me.xlk_whse_code.DestParameters = New String() {"txt_whse_code=whse_code", "whse_name=whse_name"}
        Me.xlk_whse_code.FilterField = Nothing
        Me.xlk_whse_code.IgnoreFindInBrowseMode = False
        Me.xlk_whse_code.isCanceled = False
        Me.xlk_whse_code.Location = New System.Drawing.Point(488, 72)
        Me.xlk_whse_code.LookCaption = "Almacenes"
        Me.xlk_whse_code.Name = "xlk_whse_code"
        Me.xlk_whse_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_whse_code.ShowMessageNotFound = True
        Me.xlk_whse_code.ShowWarning = False
        Me.xlk_whse_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_whse_code.SizesColumns = Nothing
        Me.xlk_whse_code.SizesColumnsTab = Nothing
        Me.xlk_whse_code.SqlString = Nothing
        Me.xlk_whse_code.SQLTab = Nothing
        Me.xlk_whse_code.SrcParameters = New String() {"txt_whse_code=whse_code"}
        Me.xlk_whse_code.TabIndex = 34
        Me.xlk_whse_code.TableName = "ivwhsem"
        Me.xlk_whse_code.UseCopyConnection = False
        Me.xlk_whse_code.UseRowRetrieveEvents = False
        Me.xlk_whse_code.UseTab = False
        Me.xlk_whse_code.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.xlk_whse_code.WhereCondition = Nothing
        Me.xlk_whse_code.WhereParameters = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(48, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Almacén:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'whse_name
        '
        Me.whse_name.Location = New System.Drawing.Point(176, 72)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.ReadOnly = True
        Me.whse_name.Size = New System.Drawing.Size(312, 20)
        Me.whse_name.TabIndex = 33
        Me.whse_name.Text = ""
        '
        'txt_whse_code
        '
        Me.txt_whse_code.AcceptsReturn = True
        Me.txt_whse_code.Location = New System.Drawing.Point(112, 72)
        Me.txt_whse_code.Name = "txt_whse_code"
        Me.txt_whse_code.Size = New System.Drawing.Size(56, 20)
        Me.txt_whse_code.TabIndex = 32
        Me.txt_whse_code.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(304, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Página Número:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Conteo Número:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_pageNo
        '
        Me.txt_pageNo.Location = New System.Drawing.Point(400, 48)
        Me.txt_pageNo.Name = "txt_pageNo"
        Me.txt_pageNo.Size = New System.Drawing.Size(104, 20)
        Me.txt_pageNo.TabIndex = 27
        Me.txt_pageNo.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(112, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(56, 20)
        Me.TextBox3.TabIndex = 26
        Me.TextBox3.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(280, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Fecha de Inventario:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(48, 312)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = Nothing
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = False
        Me.LibxCheckBox1.Size = New System.Drawing.Size(120, 24)
        Me.LibxCheckBox1.TabIndex = 23
        Me.LibxCheckBox1.Text = "Frizar Existencia"
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'LibxCheckBox2
        '
        Me.LibxCheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox2.EditInitialValue = Nothing
        Me.LibxCheckBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.FindInitialValue = Nothing
        Me.LibxCheckBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.IgnoreRequiered = False
        Me.LibxCheckBox2.KeepEnabled = False
        Me.LibxCheckBox2.Location = New System.Drawing.Point(48, 312)
        Me.LibxCheckBox2.Name = "LibxCheckBox2"
        Me.LibxCheckBox2.NewInitialValue = Nothing
        Me.LibxCheckBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.ReadOnly = False
        Me.LibxCheckBox2.Requiered = False
        Me.LibxCheckBox2.Size = New System.Drawing.Size(120, 24)
        Me.LibxCheckBox2.TabIndex = 23
        Me.LibxCheckBox2.Text = "Frizar Existencia"
        Me.LibxCheckBox2.ThreeState = True
        Me.LibxCheckBox2.value = Nothing
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEjecutar.Location = New System.Drawing.Point(728, 536)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(72, 33)
        Me.btnEjecutar.TabIndex = 1
        Me.btnEjecutar.Text = "Imprimir"
        '
        'btnUnmarkall
        '
        Me.btnUnmarkall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUnmarkall.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnmarkall.Location = New System.Drawing.Point(544, 536)
        Me.btnUnmarkall.Name = "btnUnmarkall"
        Me.btnUnmarkall.Size = New System.Drawing.Size(80, 32)
        Me.btnUnmarkall.TabIndex = 27
        Me.btnUnmarkall.Text = "Desmarcar Todos"
        '
        'btnMarkAll
        '
        Me.btnMarkAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMarkAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarkAll.Location = New System.Drawing.Point(456, 536)
        Me.btnMarkAll.Name = "btnMarkAll"
        Me.btnMarkAll.Size = New System.Drawing.Size(80, 32)
        Me.btnMarkAll.TabIndex = 26
        Me.btnMarkAll.Text = "Marcar Todos"
        '
        'LibXGrid1
        '
        Me.LibXGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = True
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Hojas de Conteo a Procesar"
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.DataMember = "ivcounte"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 120)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(792, 376)
        Me.LibXGrid1.TabIndex = 28
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Marcar Todos"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Desmarcar Todos"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Visualizar"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "Refrescar"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 5
        Me.MenuItem6.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 6
        Me.MenuItem7.Text = "Imprimir"
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColAplicar, Me.gColcount_number, Me.gcolpageno, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivcounte"
        '
        'gColAplicar
        '
        Me.gColAplicar.FalseValue = CType(0, Short)
        Me.gColAplicar.HeaderText = "Aplicar"
        Me.gColAplicar.MappingName = "Aplicar"
        Me.gColAplicar.NullValue = 0
        Me.gColAplicar.TrueValue = CType(1, Short)
        Me.gColAplicar.UseCustomCellFormat = False
        Me.gColAplicar.Width = 45
        '
        'gColcount_number
        '
        Me.gColcount_number.Format = ""
        Me.gColcount_number.FormatInfo = Nothing
        Me.gColcount_number.HeaderText = "Hoja Conteo"
        Me.gColcount_number.MappingName = "count_number"
        Me.gColcount_number.Width = 75
        '
        'gcolpageno
        '
        Me.gcolpageno.Format = ""
        Me.gcolpageno.FormatInfo = Nothing
        Me.gcolpageno.HeaderText = "Página No."
        Me.gcolpageno.MappingName = "pageno"
        Me.gcolpageno.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Fecha Conteo"
        Me.DataGridTextBoxColumn3.MappingName = "count_date"
        Me.DataGridTextBoxColumn3.Width = 81
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn4.MappingName = "count_desc"
        Me.DataGridTextBoxColumn4.Width = 300
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Estatus"
        Me.DataGridTextBoxColumn5.MappingName = "status_name"
        Me.DataGridTextBoxColumn5.Width = 81
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Usuario"
        Me.DataGridTextBoxColumn6.MappingName = "userid"
        Me.DataGridTextBoxColumn6.Width = 81
        '
        'ButtonVisualizar
        '
        Me.ButtonVisualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonVisualizar.Location = New System.Drawing.Point(632, 536)
        Me.ButtonVisualizar.Name = "ButtonVisualizar"
        Me.ButtonVisualizar.Size = New System.Drawing.Size(72, 33)
        Me.ButtonVisualizar.TabIndex = 1
        Me.ButtonVisualizar.Text = "Visualizar"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Location = New System.Drawing.Point(728, 80)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(72, 33)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        '
        'r_ivcount02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(810, 584)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.btnUnmarkall)
        Me.Controls.Add(Me.btnMarkAll)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.ButtonVisualizar)
        Me.Controls.Add(Me.btnRefresh)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "r_ivcount02"
        Me.Text = "Listado de Diferencia"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivcounte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        '0 - Generada
        '1 - Editada
        '2 - Impresa
        '3 - Aplicada

        Dim sqlArray As String

        sqlArray = e.Sql

        If chk_byPage.Checked = False Then
            sqlArray = sqlArray.Replace("ivcountd.pageno", "0 pageno")
        Else
            sqlArray = sqlArray.Replace("0 pageno", "ivcountd.pageno")
        End If

        e.Sql = sqlArray
        e.AditionalWhere = "ivcountd.count_status in (1,2)" 'Editada, Impresa, Aplicada

    End Sub

    Private Sub imprimir()
        Dim oRep As LibX.ReportLib
        Dim SQLStmt As String
        Dim sqlwhere As String
        Dim sWhse As Integer
        Dim sqlwherePage As String
        Dim FechaCorte As Date
        Dim i As Integer
        Dim UpdateStmt As String = ""
        Dim UpdateWhr As String = ""
        Dim oRows() As DataRow
        Try
            oRep = New LibX.ReportLib("INV", "r_ivcount02.rpt")
            FechaCorte = CType(Me.xdt_count_date.Value, Date)

            With oRep

                sqlwhere = "ivcounte.count_number in ("
                sqlwherePage = "ivcountd.pageno in ("

                '// Construir la cadena para impresion
                oRows = ivcounte.Select("Aplicar=1")
                i = oRows.Length
                If txt_whse_code.Text = "" Then
                    sWhse = 1
                Else
                    sWhse = Val(txt_whse_code.Text)
                End If

                For Each oRow As DataRow In oRows
                    i -= 1
                    sqlwhere = sqlwhere.Trim & oRow!count_number.ToString
                    sqlwherePage = sqlwherePage.Trim & oRow!pageno.ToString

                    If i > 0 Then
                        sqlwhere = sqlwhere & ","
                        sqlwherePage = sqlwherePage & ","
                    End If
                Next

                sqlwhere = sqlwhere & ") "
                sqlwherePage = sqlwherePage & ") and ivcountd.whse_code =" & sWhse

                .RetrieveSQLQuery()
                SQLStmt = .SQLQuery
                SQLStmt = LibX.ConcatWherePart(SQLStmt, "(isnull(ivcountd.count_qty,0)-isnull(ivcountd.qty_on_hand,0)) <> 0")
                SQLStmt = LibX.ConcatWherePart(SQLStmt, sqlwhere)

                If Me.chk_byPage.Checked = True Then
                    SQLStmt = LibX.ConcatWherePart(SQLStmt, sqlwherePage)
                End If

                '// devolver
                .SQLQuery = SQLStmt
                .ParameterFields(1) = "pFechaCorte;" & FechaCorte.ToString("dd/MM/yyyy") & ";TRUE"
                .Action = 1

                '// Construir la cadena para actualizacion
                oRows = ivcounte.Select("Aplicar=1 and count_status = " & Val(EstatusHojaConteoEnum.Editada).ToString)
                i = oRows.Length
                If i > 0 Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                End If

                For Each oRow As DataRow In oRows
                    '------------

                    UpdateStmt = "Update ivcountd set count_status = " & Val(EstatusHojaConteoEnum.Impresa).ToString
                    UpdateStmt = LibX.ConcatWherePart(UpdateStmt, "count_number = " & orow!count_number.ToString.Trim)

                    If Me.chk_byPage.Checked = True Then
                        UpdateStmt = LibX.ConcatWherePart(UpdateStmt, "pageno = " & orow!pageno.ToString.Trim)
                    End If

                    LibX.Data.Manager.ExecuteNonQuery(UpdateStmt)
                Next

                If i > 0 Then
                    LibX.Data.Manager.Connection.CommitTransaction()
                End If

            End With

            LibXConnector1.ReQuery()

        Catch ex As Exception
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If

            LibX.Log.Show(ex)
        End Try
    End Sub


    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction

        If e.Action = LibX.LibxConnectionActions.Edit Then
            LibXGrid1.ReadOnly = False
            For Each orow As DataRow In ivcounte.Rows
                If LibX.IsNull(orow!Aplicar) = True Then
                    orow!Aplicar = 0
                End If
            Next
        End If

    End Sub

    Private Sub r_ivonhnd01_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Limpiar()
    End Sub

    Private Sub Limpiar()
        'Try
        '    If ivitemr.Rows.Count > 0 Then
        '        For Each orow As DataRow In ivitemr.Rows
        '            orow.Delete()
        '        Next
        '    End If

        '    LibX.Data.Manager.Save(ivitemr)

        'Catch ex As Exception
        '    LibX.Log.Show(ex)
        'End Try

    End Sub


    Private Sub btnMarkAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAll.Click
        For Each oRow As DataRow In DataSet1.Tables("ivcounte").Rows
            oRow!Aplicar = 1
        Next

        btnEjecutar.Enabled = True

    End Sub

    Private Sub btnUnmarkall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnmarkall.Click
        For Each oRow As DataRow In DataSet1.Tables("ivcounte").Rows
            oRow!Aplicar = 0
        Next

        btnEjecutar.Enabled = False
    End Sub

    Private Sub btnEjecutar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        imprimir()

    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As System.Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs)
        Dim SelecStmt As String
        Try
            Dim AxCrystalReport1 As New LibX.ReportLib("INV", "r_ivcount02.rpt")

            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
                With AxCrystalReport1
                    .RetrieveSQLQuery()
                    SelecStmt = .SQLQuery
                    SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, "ivcounte.count_number = " & LibXConnector1.CurrentDataRow!count_number)
                    .SQLQuery = SelecStmt

                    .WindowState = ReportLib.WindowsStates.Maximixed
                    .Action = 1
                End With
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try

    End Sub


    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        btnMarkAll.Enabled = e.isEditing And LibXConnector1.HasRecords
        btnUnmarkall.Enabled = e.isEditing And LibXConnector1.HasRecords
        btnEjecutar.Enabled = e.isEditing And LibXConnector1.HasRecords
        ButtonVisualizar.Enabled = LibXConnector1.HasRecords

        If e.isEditing Then
            btnEjecutar.Enabled = Not e.isEditing
        End If

    End Sub

    Private Sub LibXGrid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibXGrid1.Click

        If LibXConnector1.IsDataEditing Then
            btnEjecutar.Enabled = True
        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_byPage.CheckedChanged
        If LibXConnector1.HasRecords = True Then
            LibXConnector1.ReQuery()
        End If
    End Sub

    Private Sub r_ivcount02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.xcbo_doc_status.LoadDbItems(True)
            Me.xcbo_doc_status.currValue = 1 '// Editada

            '// Refrescar Informacion
            btnRefresh_Click_1(sender, e)

        Catch ex As Exception
            LibX.Log.Show(ex, True)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVisualizar.Click
        Dim ProgParam As LibX.LibxPrgParams
        Try
            ProgParam = New LibX.LibxPrgParams
            With ProgParam
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowPrint = False
                .AllowQuery = False
                .IsFromOther = True
                .initMode = LibX.LibxInitModes.Query
                .WhereToExecute = "ivcounte.count_number = " & LibXGrid1.GetValue(gColcount_number).ToString

                If Me.chk_byPage.Checked = True Then
                    .WhereToExecute = .WhereToExecute.Trim & " and ivcountd.pageno = " & LibXGrid1.GetValue(gcolpageno).ToString
                End If

            End With

            LibX.App.CurrentPrgParams = ProgParam
            LibX.LibXRunner.Run("i_ivcount01", "INV", True)

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LibXConnector1.ReQuery()
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        btnMarkAll_Click(sender, e)
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        btnUnmarkall_Click(sender, e)

    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        btnRefresh_Click(sender, e)
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        DataSet1.Tables("ivcounte").Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1
        If LibXConnector1.IsDataEditing = True Then
            LibXConnector1.AcceptEdit()
        End If
        imprimir()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Button1_Click(Nothing, Nothing)
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub btnRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            LibXConnector1.AcceptFind()
            If LibXConnector1.HasRecords = True Then
                LibXConnector1.Edit()
            Else
                LibXConnector1.Find()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
End Class
