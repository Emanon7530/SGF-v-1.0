Imports LibX
Public Class i_ftncfm01
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
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents xlk_type_code As LibX.LibXLookup
    Friend WithEvents type_name As LibX.XTextBox
    Friend WithEvents xlk_whse_code As LibX.LibXLookup
    Friend WithEvents whse_name As LibX.XTextBox
    Friend WithEvents xtxt_whse_code As LibX.XTextBox
    Friend WithEvents xtxt_type_code As LibX.XTextBox
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents xcbo_ncf_type As LibX.LibXCombo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents XTextBox4 As LibX.XTextBox
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.xcbo_ncf_type = New LibX.LibXCombo
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.xlk_type_code = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.type_name = New LibX.XTextBox
        Me.xlk_whse_code = New LibX.LibXLookup
        Me.whse_name = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.xtxt_whse_code = New LibX.XTextBox
        Me.xtxt_type_code = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.XTextBox3 = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.XTextBox4 = New LibX.XTextBox
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.xcbo_ncf_type)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.xlk_type_code)
        Me.GroupBox1.Controls.Add(Me.type_name)
        Me.GroupBox1.Controls.Add(Me.xlk_whse_code)
        Me.GroupBox1.Controls.Add(Me.whse_name)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xtxt_whse_code)
        Me.GroupBox1.Controls.Add(Me.xtxt_type_code)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.XTextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.XTextBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 256)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftncfm.definicion"))
        Me.Label7.Location = New System.Drawing.Point(344, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(304, 23)
        Me.Label7.TabIndex = 56
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
        Me.DataTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ncf_serial"}, True)})
        Me.DataTable2.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn16}
        Me.DataTable2.TableName = "ftncfm"
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.AutoIncrement = True
        Me.DataColumn16.ColumnName = "ncf_serial"
        Me.DataColumn16.DataType = GetType(System.Int32)
        Me.DataColumn16.ReadOnly = True
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.ColumnName = "whse_code"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "type_code"
        Me.DataColumn18.MaxLength = 3
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "ncf_type"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "ncf_literal"
        Me.DataColumn20.MaxLength = 80
        '
        'DataColumn21
        '
        Me.DataColumn21.AllowDBNull = False
        Me.DataColumn21.ColumnName = "ncf_inicial"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "ncf_final"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "ncf_actual"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "definicion"
        Me.DataColumn1.MaxLength = 40
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "ncf_dgii"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "suc_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'xcbo_ncf_type
        '
        Me.xcbo_ncf_type.AllowDefaultSort = True
        Me.xcbo_ncf_type.bound = True
        Me.xcbo_ncf_type.currValue = Nothing
        Me.xcbo_ncf_type.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftncfm.ncf_type"))
        Me.xcbo_ncf_type.DefaultWhereString = Nothing
        Me.xcbo_ncf_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_ncf_type.EditInitialValue = Nothing
        Me.xcbo_ncf_type.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_ncf_type.FieldDescription = ""
        Me.xcbo_ncf_type.FindInitialValue = Nothing
        Me.xcbo_ncf_type.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_ncf_type.IgnoreRequiered = False
        Me.xcbo_ncf_type.Items.AddRange(New Object() {"1-Valor Credito Fiscal", "2-Sin Valor Credito Fiscal", "3-Notas de débito ", "4-Notas de crédito ", "11-Proveedores informales           ", "12-Ingresos Unico", "13-Gastos menores   ", "14-Regimen Especiales               ", "15-Gubernamentales", ""})
        Me.xcbo_ncf_type.Location = New System.Drawing.Point(152, 64)
        Me.xcbo_ncf_type.LookupKeyDisplayFields = Nothing
        Me.xcbo_ncf_type.LookupKeyField = Nothing
        Me.xcbo_ncf_type.LookupTableName = Nothing
        Me.xcbo_ncf_type.Name = "xcbo_ncf_type"
        Me.xcbo_ncf_type.NewInitialValue = Nothing
        Me.xcbo_ncf_type.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_ncf_type.Requiered = False
        Me.xcbo_ncf_type.Required = False
        Me.xcbo_ncf_type.Size = New System.Drawing.Size(184, 21)
        Me.xcbo_ncf_type.SqlString = Nothing
        Me.xcbo_ncf_type.StatusBarPanelDescripcion = Nothing
        Me.xcbo_ncf_type.TabIndex = 2
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(49, 40)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(90, 16)
        Me.Label33.TabIndex = 55
        Me.Label33.Text = "Tipo Documento:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(88, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(51, 16)
        Me.Label32.TabIndex = 54
        Me.Label32.Text = "Almacen:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_type_code
        '
        Me.xlk_type_code.AlternateFieldSearch = Nothing
        Me.xlk_type_code.BeginCheck = False
        Me.xlk_type_code.CheckText = Nothing
        Me.xlk_type_code.ComboMode = False
        Me.xlk_type_code.DataMember = Nothing
        Me.xlk_type_code.DataSource = Me.LibXConnector1
        Me.xlk_type_code.DestParameters = New String() {"type_code=type_code", "type_name=type_name"}
        Me.xlk_type_code.FilterField = Nothing
        Me.xlk_type_code.IgnoreFindInBrowseMode = False
        Me.xlk_type_code.isCanceled = False
        Me.xlk_type_code.Location = New System.Drawing.Point(488, 40)
        Me.xlk_type_code.LookCaption = "Tipos de Documentos"
        Me.xlk_type_code.Name = "xlk_type_code"
        Me.xlk_type_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_type_code.ShowFilter = True
        Me.xlk_type_code.ShowMessageNotFound = True
        Me.xlk_type_code.ShowWarning = False
        Me.xlk_type_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_type_code.SizesColumns = Nothing
        Me.xlk_type_code.SizesColumnsTab = Nothing
        Me.xlk_type_code.SqlString = New String() {Nothing}
        Me.xlk_type_code.SQLTab = Nothing
        Me.xlk_type_code.SrcParameters = New String() {"type_code=type_code"}
        Me.xlk_type_code.TabIndex = 53
        Me.xlk_type_code.TableName = "ivtypem"
        Me.xlk_type_code.TabStop = False
        Me.xlk_type_code.UseCopyConnection = False
        Me.xlk_type_code.UseRowRetrieveEvents = False
        Me.xlk_type_code.UseTab = False
        Me.xlk_type_code.VisParameters = New String() {"Código=type_code", "Descripción=type_name"}
        Me.xlk_type_code.WhereCondition = Nothing
        Me.xlk_type_code.WhereParameters = Nothing
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = False
        Me.LibXConnector1.AllowNew = True
        Me.LibXConnector1.AllowPrint = False
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "ftncfm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
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
        Me.LibXDbSourceTable2.SerialColumnName = "ncf_serial"
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = Nothing
        Me.LibXDbSourceTable2.TableName = "ftncfm"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'type_name
        '
        Me.type_name.AcceptsReturn = True
        Me.type_name.EditInitialValue = Nothing
        Me.type_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.type_name.FieldDescription = ""
        Me.type_name.FindInitialValue = Nothing
        Me.type_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.type_name.IgnoreRequiered = False
        Me.type_name.Location = New System.Drawing.Point(208, 40)
        Me.type_name.Name = "type_name"
        Me.type_name.NewInitialValue = Nothing
        Me.type_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.type_name.ReadOnly = True
        Me.type_name.Requiered = False
        Me.type_name.Size = New System.Drawing.Size(280, 20)
        Me.type_name.StatusBarPanelDescripcion = Nothing
        Me.type_name.TabIndex = 52
        Me.type_name.TabStop = False
        Me.type_name.Text = ""
        '
        'xlk_whse_code
        '
        Me.xlk_whse_code.AlternateFieldSearch = Nothing
        Me.xlk_whse_code.BeginCheck = False
        Me.xlk_whse_code.CheckText = Nothing
        Me.xlk_whse_code.ComboMode = False
        Me.xlk_whse_code.DataMember = Nothing
        Me.xlk_whse_code.DataSource = Me.LibXConnector1
        Me.xlk_whse_code.DestParameters = New String() {"whse_code=whse_code", "whse_name=whse_name"}
        Me.xlk_whse_code.FilterField = Nothing
        Me.xlk_whse_code.IgnoreFindInBrowseMode = False
        Me.xlk_whse_code.isCanceled = False
        Me.xlk_whse_code.Location = New System.Drawing.Point(488, 16)
        Me.xlk_whse_code.LookCaption = "Almacenes"
        Me.xlk_whse_code.Name = "xlk_whse_code"
        Me.xlk_whse_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_whse_code.ShowFilter = True
        Me.xlk_whse_code.ShowMessageNotFound = True
        Me.xlk_whse_code.ShowWarning = False
        Me.xlk_whse_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_whse_code.SizesColumns = Nothing
        Me.xlk_whse_code.SizesColumnsTab = Nothing
        Me.xlk_whse_code.SqlString = Nothing
        Me.xlk_whse_code.SQLTab = Nothing
        Me.xlk_whse_code.SrcParameters = New String() {"whse_code=whse_code"}
        Me.xlk_whse_code.TabIndex = 51
        Me.xlk_whse_code.TableName = "ivwhsem"
        Me.xlk_whse_code.TabStop = False
        Me.xlk_whse_code.UseCopyConnection = False
        Me.xlk_whse_code.UseRowRetrieveEvents = False
        Me.xlk_whse_code.UseTab = False
        Me.xlk_whse_code.VisParameters = New String() {"Código=whse_code", "Almacen=whse_name"}
        Me.xlk_whse_code.WhereCondition = Nothing
        Me.xlk_whse_code.WhereParameters = Nothing
        '
        'whse_name
        '
        Me.whse_name.AcceptsReturn = True
        Me.whse_name.EditInitialValue = Nothing
        Me.whse_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.FieldDescription = ""
        Me.whse_name.FindInitialValue = Nothing
        Me.whse_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.IgnoreRequiered = False
        Me.whse_name.Location = New System.Drawing.Point(208, 16)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.NewInitialValue = Nothing
        Me.whse_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.ReadOnly = True
        Me.whse_name.Requiered = False
        Me.whse_name.Size = New System.Drawing.Size(280, 20)
        Me.whse_name.StatusBarPanelDescripcion = Nothing
        Me.whse_name.TabIndex = 50
        Me.whse_name.TabStop = False
        Me.whse_name.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(83, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Tipo NCF:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_whse_code
        '
        Me.xtxt_whse_code.AcceptsReturn = True
        Me.xtxt_whse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftncfm.whse_code"))
        Me.xtxt_whse_code.EditInitialValue = Nothing
        Me.xtxt_whse_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_whse_code.FieldDescription = ""
        Me.xtxt_whse_code.FindInitialValue = Nothing
        Me.xtxt_whse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_whse_code.IgnoreRequiered = False
        Me.xtxt_whse_code.Location = New System.Drawing.Point(152, 16)
        Me.xtxt_whse_code.Name = "xtxt_whse_code"
        Me.xtxt_whse_code.NewInitialValue = Nothing
        Me.xtxt_whse_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_whse_code.Requiered = False
        Me.xtxt_whse_code.Size = New System.Drawing.Size(48, 20)
        Me.xtxt_whse_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_whse_code.TabIndex = 0
        Me.xtxt_whse_code.Text = ""
        '
        'xtxt_type_code
        '
        Me.xtxt_type_code.AcceptsReturn = True
        Me.xtxt_type_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftncfm.type_code"))
        Me.xtxt_type_code.EditInitialValue = Nothing
        Me.xtxt_type_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_type_code.FieldDescription = ""
        Me.xtxt_type_code.FindInitialValue = Nothing
        Me.xtxt_type_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_code.IgnoreRequiered = False
        Me.xtxt_type_code.Location = New System.Drawing.Point(152, 40)
        Me.xtxt_type_code.Name = "xtxt_type_code"
        Me.xtxt_type_code.NewInitialValue = Nothing
        Me.xtxt_type_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_code.Requiered = False
        Me.xtxt_type_code.Size = New System.Drawing.Size(49, 20)
        Me.xtxt_type_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_type_code.TabIndex = 1
        Me.xtxt_type_code.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(101, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Literal:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftncfm.ncf_literal"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(152, 88)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(184, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 3
        Me.XTextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(66, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Rango Inicial:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftncfm.ncf_inicial"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(152, 112)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(184, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 4
        Me.XTextBox2.Text = ""
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftncfm.ncf_final"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(152, 136)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(184, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 5
        Me.XTextBox3.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(71, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Rango Final:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(56, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Ultimo Número:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(152, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox4
        '
        Me.XTextBox4.AcceptsReturn = True
        Me.XTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftncfm.ncf_actual"))
        Me.XTextBox4.EditInitialValue = Nothing
        Me.XTextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.FieldDescription = ""
        Me.XTextBox4.FindInitialValue = Nothing
        Me.XTextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.IgnoreRequiered = False
        Me.XTextBox4.Location = New System.Drawing.Point(152, 160)
        Me.XTextBox4.Name = "XTextBox4"
        Me.XTextBox4.NewInitialValue = Nothing
        Me.XTextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.Requiered = False
        Me.XTextBox4.Size = New System.Drawing.Size(184, 20)
        Me.XTextBox4.StatusBarPanelDescripcion = Nothing
        Me.XTextBox4.TabIndex = 11
        Me.XTextBox4.Text = ""
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
        Me.LibXDbSourceTable1.TableName = "ftcustm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Nothing
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_whse_code
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_whse_code
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(690, 24)
        Me.LibXNavigator1.TabIndex = 5
        '
        'i_ftncfm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 296)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "i_ftncfm01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "NUMERO COMPROBANTE FISCAL"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub xcbo_ncf_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xcbo_ncf_type.SelectedIndexChanged
        If LibXConnector1.IsDataEditing = True Then
            If Me.xcbo_ncf_type.SelectedValue = 1 Then
                Me.Label7.Text = "VALOR CREDITO FISCAL"
            End If
            If Me.xcbo_ncf_type.SelectedValue = 2 Then
                Me.Label7.Text = "SIN VALOR CREDITO FISCAL"
            End If
            If Me.xcbo_ncf_type.SelectedValue = 3 Then
                Me.Label7.Text = "NOTA DE DEBITO"
            End If
            If Me.xcbo_ncf_type.SelectedValue = 4 Then
                Me.Label7.Text = "NOTA DE CREDITO"
            End If
            If Me.xcbo_ncf_type.SelectedValue = 11 Then
                Me.Label7.Text = "PROVEEDORES INFORMALES"
            End If
            If Me.xcbo_ncf_type.SelectedValue = 12 Then
                Me.Label7.Text = "INGRESO UNICO"
            End If
            If Me.xcbo_ncf_type.SelectedValue = 13 Then
                Me.Label7.Text = "GASTOS MENORES"
            End If
            If Me.xcbo_ncf_type.SelectedValue = 14 Then
                Me.Label7.Text = "REGIMEN ESPECIALES"
            End If
            If Me.xcbo_ncf_type.SelectedValue = 15 Then
                Me.Label7.Text = "GUBERNAMENTALES"
            End If

        End If
    End Sub
    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                e.UpdatingArgs.Row!suc_code = 1
                e.UpdatingArgs.Row!ncf_dgii = 1
            End If
        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub i_ftncfm01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
