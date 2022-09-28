Public Class i_ivgroup01
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As LibX.XTextBox
    Friend WithEvents TextBox2 As LibX.XTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As LibX.XTextBox
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents prov_name As LibX.XTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents XTxtLast_number As LibX.XTextBox
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_stockable As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox2 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox3 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox4 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox5 As LibX.LibxCheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents XTextBox3 As LibX.XTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.TextBox2 = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.prov_name = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox4 = New LibX.XTextBox
        Me.XTxtLast_number = New LibX.XTextBox
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chk_stockable = New LibX.LibxCheckBox
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.LibxCheckBox2 = New LibX.LibxCheckBox
        Me.LibxCheckBox3 = New LibX.LibxCheckBox
        Me.LibxCheckBox4 = New LibX.LibxCheckBox
        Me.LibxCheckBox5 = New LibX.LibxCheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.prov_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.XTxtLast_number)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.XTextBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 176)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"group_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "ivgroupm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "group_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "group_name"
        Me.DataColumn2.MaxLength = 30
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "prov_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "last_number"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "incluido"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "oferta"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(280, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ultimo Numero:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.LibXLookup1.Location = New System.Drawing.Point(456, 72)
        Me.LibXLookup1.LookCaption = "Suplidores"
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
        Me.LibXLookup1.TabIndex = 4
        Me.LibXLookup1.TableName = "cpprovm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=prov_code", "Suplidor=prov_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "ivgroupm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
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
        Me.LibXConnector1.UseTransactions = False
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
        Me.LibXDbSourceTable1.KeyFields = ""
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "group_code"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ivgroupm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "taxable"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "porc_benef"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "rounded"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "allow_discount"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "stockable"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "allow_discart"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "porc_discount"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "allow_consign"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "allow_label"
        Me.DataColumn15.DataType = GetType(System.Int32)
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivgroupm.group_name"))
        Me.TextBox2.EditInitialValue = Nothing
        Me.TextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.FieldDescription = ""
        Me.TextBox2.FindInitialValue = Nothing
        Me.TextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.IgnoreRequiered = False
        Me.TextBox2.Location = New System.Drawing.Point(128, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.NewInitialValue = Nothing
        Me.TextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.Requiered = False
        Me.TextBox2.Size = New System.Drawing.Size(344, 20)
        Me.TextBox2.StatusBarPanelDescripcion = Nothing
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivgroupm.group_code"))
        Me.TextBox1.EditInitialValue = Nothing
        Me.TextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox1.FieldDescription = ""
        Me.TextBox1.FindInitialValue = Nothing
        Me.TextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox1.IgnoreRequiered = False
        Me.TextBox1.Location = New System.Drawing.Point(128, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.NewInitialValue = Nothing
        Me.TextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox1.Requiered = False
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.StatusBarPanelDescripcion = Nothing
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'prov_name
        '
        Me.prov_name.AcceptsReturn = True
        Me.prov_name.EditInitialValue = Nothing
        Me.prov_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.FieldDescription = ""
        Me.prov_name.FindInitialValue = Nothing
        Me.prov_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.IgnoreRequiered = False
        Me.prov_name.Location = New System.Drawing.Point(200, 72)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.NewInitialValue = Nothing
        Me.prov_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.ReadOnly = True
        Me.prov_name.Requiered = False
        Me.prov_name.Size = New System.Drawing.Size(256, 20)
        Me.prov_name.StatusBarPanelDescripcion = Nothing
        Me.prov_name.TabIndex = 3
        Me.prov_name.Text = ""
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(16, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Suplidor:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox4
        '
        Me.TextBox4.AcceptsReturn = True
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivgroupm.prov_code"))
        Me.TextBox4.EditInitialValue = Nothing
        Me.TextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.FieldDescription = ""
        Me.TextBox4.FindInitialValue = Nothing
        Me.TextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.IgnoreRequiered = False
        Me.TextBox4.Location = New System.Drawing.Point(128, 72)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.NewInitialValue = Nothing
        Me.TextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.Requiered = False
        Me.TextBox4.Size = New System.Drawing.Size(64, 20)
        Me.TextBox4.StatusBarPanelDescripcion = Nothing
        Me.TextBox4.TabIndex = 2
        Me.TextBox4.Text = ""
        '
        'XTxtLast_number
        '
        Me.XTxtLast_number.AcceptsReturn = True
        Me.XTxtLast_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivgroupm.last_number"))
        Me.XTxtLast_number.EditInitialValue = Nothing
        Me.XTxtLast_number.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTxtLast_number.FieldDescription = ""
        Me.XTxtLast_number.FindInitialValue = Nothing
        Me.XTxtLast_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTxtLast_number.IgnoreRequiered = False
        Me.XTxtLast_number.Location = New System.Drawing.Point(384, 24)
        Me.XTxtLast_number.Name = "XTxtLast_number"
        Me.XTxtLast_number.NewInitialValue = "0"
        Me.XTxtLast_number.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTxtLast_number.ReadOnly = True
        Me.XTxtLast_number.Requiered = False
        Me.XTxtLast_number.Size = New System.Drawing.Size(88, 20)
        Me.XTxtLast_number.StatusBarPanelDescripcion = Nothing
        Me.XTxtLast_number.TabIndex = 3
        Me.XTxtLast_number.Text = ""
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Nothing
        Me.LibXNavigator1.FirstControlInFindMode = Nothing
        Me.LibXNavigator1.FirstControlInNewMode = Nothing
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(698, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_stockable)
        Me.GroupBox2.Controls.Add(Me.LibxCheckBox1)
        Me.GroupBox2.Controls.Add(Me.LibxCheckBox2)
        Me.GroupBox2.Controls.Add(Me.LibxCheckBox3)
        Me.GroupBox2.Controls.Add(Me.LibxCheckBox4)
        Me.GroupBox2.Controls.Add(Me.LibxCheckBox5)
        Me.GroupBox2.Location = New System.Drawing.Point(504, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 176)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parametros"
        '
        'chk_stockable
        '
        Me.chk_stockable.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.chk_stockable.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivgroupm.stockable"))
        Me.chk_stockable.EditInitialValue = Nothing
        Me.chk_stockable.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_stockable.FindInitialValue = Nothing
        Me.chk_stockable.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_stockable.IgnoreRequiered = False
        Me.chk_stockable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk_stockable.KeepEnabled = False
        Me.chk_stockable.Location = New System.Drawing.Point(16, 24)
        Me.chk_stockable.Name = "chk_stockable"
        Me.chk_stockable.NewInitialValue = "1"
        Me.chk_stockable.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_stockable.ReadOnly = False
        Me.chk_stockable.Requiered = False
        Me.chk_stockable.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_stockable.Size = New System.Drawing.Size(152, 24)
        Me.chk_stockable.TabIndex = 6
        Me.chk_stockable.Text = "Almacenable"
        Me.chk_stockable.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.chk_stockable.ThreeState = True
        Me.chk_stockable.value = Nothing
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivgroupm.taxable"))
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(16, 48)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = "1"
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = False
        Me.LibxCheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox1.Size = New System.Drawing.Size(152, 24)
        Me.LibxCheckBox1.TabIndex = 6
        Me.LibxCheckBox1.Text = "Aplica ITBIS"
        Me.LibxCheckBox1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'LibxCheckBox2
        '
        Me.LibxCheckBox2.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivgroupm.taxable"))
        Me.LibxCheckBox2.EditInitialValue = Nothing
        Me.LibxCheckBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.FindInitialValue = Nothing
        Me.LibxCheckBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.IgnoreRequiered = False
        Me.LibxCheckBox2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LibxCheckBox2.KeepEnabled = False
        Me.LibxCheckBox2.Location = New System.Drawing.Point(16, 72)
        Me.LibxCheckBox2.Name = "LibxCheckBox2"
        Me.LibxCheckBox2.NewInitialValue = "1"
        Me.LibxCheckBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.ReadOnly = False
        Me.LibxCheckBox2.Requiered = False
        Me.LibxCheckBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox2.Size = New System.Drawing.Size(152, 24)
        Me.LibxCheckBox2.TabIndex = 6
        Me.LibxCheckBox2.Text = "Aplica Descuentos"
        Me.LibxCheckBox2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox2.ThreeState = True
        Me.LibxCheckBox2.value = Nothing
        '
        'LibxCheckBox3
        '
        Me.LibxCheckBox3.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivgroupm.allow_discart"))
        Me.LibxCheckBox3.EditInitialValue = Nothing
        Me.LibxCheckBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.FindInitialValue = Nothing
        Me.LibxCheckBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.IgnoreRequiered = False
        Me.LibxCheckBox3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LibxCheckBox3.KeepEnabled = False
        Me.LibxCheckBox3.Location = New System.Drawing.Point(16, 96)
        Me.LibxCheckBox3.Name = "LibxCheckBox3"
        Me.LibxCheckBox3.NewInitialValue = "1"
        Me.LibxCheckBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.ReadOnly = False
        Me.LibxCheckBox3.Requiered = False
        Me.LibxCheckBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox3.Size = New System.Drawing.Size(152, 24)
        Me.LibxCheckBox3.TabIndex = 6
        Me.LibxCheckBox3.Text = "Aplica Vencimientos"
        Me.LibxCheckBox3.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox3.ThreeState = True
        Me.LibxCheckBox3.value = Nothing
        '
        'LibxCheckBox4
        '
        Me.LibxCheckBox4.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivgroupm.allow_consign"))
        Me.LibxCheckBox4.EditInitialValue = Nothing
        Me.LibxCheckBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.FindInitialValue = Nothing
        Me.LibxCheckBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.IgnoreRequiered = False
        Me.LibxCheckBox4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LibxCheckBox4.KeepEnabled = False
        Me.LibxCheckBox4.Location = New System.Drawing.Point(16, 120)
        Me.LibxCheckBox4.Name = "LibxCheckBox4"
        Me.LibxCheckBox4.NewInitialValue = "1"
        Me.LibxCheckBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.ReadOnly = False
        Me.LibxCheckBox4.Requiered = False
        Me.LibxCheckBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox4.Size = New System.Drawing.Size(152, 24)
        Me.LibxCheckBox4.TabIndex = 6
        Me.LibxCheckBox4.Text = "Consignación"
        Me.LibxCheckBox4.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox4.ThreeState = True
        Me.LibxCheckBox4.value = Nothing
        '
        'LibxCheckBox5
        '
        Me.LibxCheckBox5.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivgroupm.allow_label"))
        Me.LibxCheckBox5.EditInitialValue = Nothing
        Me.LibxCheckBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.FindInitialValue = Nothing
        Me.LibxCheckBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.IgnoreRequiered = False
        Me.LibxCheckBox5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LibxCheckBox5.KeepEnabled = False
        Me.LibxCheckBox5.Location = New System.Drawing.Point(16, 144)
        Me.LibxCheckBox5.Name = "LibxCheckBox5"
        Me.LibxCheckBox5.NewInitialValue = "1"
        Me.LibxCheckBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.ReadOnly = False
        Me.LibxCheckBox5.Requiered = False
        Me.LibxCheckBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox5.Size = New System.Drawing.Size(152, 24)
        Me.LibxCheckBox5.TabIndex = 6
        Me.LibxCheckBox5.Text = "Imprime Etiqueta"
        Me.LibxCheckBox5.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox5.ThreeState = True
        Me.LibxCheckBox5.value = Nothing
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(16, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "% Beneficio:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivgroupm.porc_benef"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(128, 96)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(64, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 2
        Me.XTextBox1.Text = ""
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(296, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Redondeo:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivgroupm.rounded"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(408, 96)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(64, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 2
        Me.XTextBox2.Text = ""
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(16, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "% Descuento:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivgroupm.porc_discount"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(128, 120)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(64, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 2
        Me.XTextBox3.Text = ""
        '
        'i_ivgroup01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(698, 240)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivgroup01"
        Me.Text = "Mantenimiento de grupos de productos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                e.UpdatingArgs.Row!last_number = 0
            End If

            If e.UpdatingArgs.StatementType = StatementType.Update Then
                If LibX.IsNull(e.UpdatingArgs.Row!last_number) = True Then
                    e.UpdatingArgs.Row!last_number = 0
                End If
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Show(ex)
        End Try
    End Sub

End Class
