Public Class i_ivunitm02
    Inherits System.Windows.Forms.Form
    Dim mLastKeyPressedInGrid As Windows.Forms.Keys

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
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents xcbo_unit_type As LibX.LibXCombo
    Friend WithEvents LibXShortNavigator1 As LibX.LibXShortNavigator
    Friend WithEvents gcolUnit_type As LibX.XDataGridComboBoxColumn
    Friend WithEvents gcolfactor As LibX.XEditTextBoxColumn
    Friend WithEvents gColUnit_Name As LibX.XEditTextBoxColumn
    Friend WithEvents gColunit_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents xlk_unit_code As LibX.LibXLookup
    Friend WithEvents btnUnit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents ivunitd As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataTable1 As System.Data.DataTable
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
    Friend WithEvents gcolCosto As LibX.XEditTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.DataSet1 = New System.Data.DataSet
        Me.ivunitd = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataTable1 = New System.Data.DataTable
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.xcbo_unit_type = New LibX.LibXCombo
        Me.Label2 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColunit_code = New LibX.XDataGridTextButtonColumn
        Me.xlk_unit_code = New LibX.LibXLookup
        Me.gColUnit_Name = New LibX.XEditTextBoxColumn
        Me.gcolUnit_type = New LibX.XDataGridComboBoxColumn
        Me.gcolfactor = New LibX.XEditTextBoxColumn
        Me.gcolCosto = New LibX.XEditTextBoxColumn
        Me.LibXShortNavigator1 = New LibX.LibXShortNavigator
        Me.btnUnit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivunitd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.xcbo_unit_type)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 96)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ivitemm.factor"))
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(432, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 8
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
        Me.LibXConnector1.DataMember = Nothing
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
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
        Me.LibXDbSourceTable1.Source = New String() {"SELECT ivitemm.*,unit_name,factor", "from ivitemm inner join ivunitm ", "on ivitemm.purch_unit = ivunitm.unit_code"}
        Me.LibXDbSourceTable1.TableName = "ivitemm"
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
        Me.LibXDbSourceTable2.FillOnRowChange = True
        Me.LibXDbSourceTable2.HeaderIsOnGrid = False
        Me.LibXDbSourceTable2.InnerJon = True
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"item_code=item_code"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select ivunitd.*,ivunitm.unit_name, (ivitemd.purch_cost*ivunitd.factor) costo", "from ivunitd ", "inner join ivunitm", "on ivunitd.unit_code = ivunitm.unit_code", "inner join ivitemd", "on ivitemd.item_code = ivunitd.item_code"}
        Me.LibXDbSourceTable2.TableName = "ivunitd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivunitd, Me.DataTable1})
        '
        'ivunitd
        '
        Me.ivunitd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.ivunitd.TableName = "ivunitd"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "unit_code"
        Me.DataColumn1.MaxLength = 4
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
        Me.DataColumn3.ColumnName = "factor"
        Me.DataColumn3.DataType = GetType(System.Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "unit_type"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "unit_min"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "unit_name"
        Me.DataColumn6.MaxLength = 30
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "costo"
        Me.DataColumn7.DataType = GetType(System.Decimal)
        Me.DataColumn7.ReadOnly = True
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35})
        Me.DataTable1.TableName = "ivitemm"
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "item_code"
        Me.DataColumn8.MaxLength = 10
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "item_serie"
        Me.DataColumn9.MaxLength = 40
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "item_name"
        Me.DataColumn10.MaxLength = 100
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "abreviada"
        Me.DataColumn11.MaxLength = 40
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "unit_code"
        Me.DataColumn12.MaxLength = 4
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "prov_code"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "brand_code"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sgroup_code"
        Me.DataColumn15.DataType = GetType(System.Int32)
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "group_code"
        Me.DataColumn16.DataType = GetType(System.Int32)
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.ColumnName = "purch_unit"
        Me.DataColumn17.MaxLength = 5
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "taxable"
        Me.DataColumn18.DataType = GetType(System.Int16)
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "item_status"
        Me.DataColumn19.MaxLength = 20
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "item_created"
        Me.DataColumn20.DataType = GetType(System.DateTime)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "item_serial"
        Me.DataColumn21.DataType = GetType(System.Int16)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "userid"
        Me.DataColumn22.MaxLength = 20
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "total_onhand"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "imprimir_etiq"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "asumir_emp"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sugerir_compra"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "Referencia"
        Me.DataColumn27.MaxLength = 20
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "Aplicar_Vcmto"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "sustancias"
        Me.DataColumn29.MaxLength = 300
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "prd_controlado"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "item_update"
        Me.DataColumn31.DataType = GetType(System.DateTime)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "item_comm"
        Me.DataColumn32.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "item_type"
        Me.DataColumn33.DataType = GetType(System.Int32)
        '
        'DataColumn34
        '
        Me.DataColumn34.AllowDBNull = False
        Me.DataColumn34.ColumnName = "unit_name"
        Me.DataColumn34.MaxLength = 30
        '
        'DataColumn35
        '
        Me.DataColumn35.AllowDBNull = False
        Me.DataColumn35.ColumnName = "factor"
        Me.DataColumn35.DataType = GetType(System.Decimal)
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ivitemm.purch_unit"))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(112, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(16, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Unidad Compra:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ivitemm.item_name"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(112, 40)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(376, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 3
        Me.XTextBox2.Text = ""
        '
        'xcbo_unit_type
        '
        Me.xcbo_unit_type.AllowDefaultSort = True
        Me.xcbo_unit_type.bound = True
        Me.xcbo_unit_type.currValue = Nothing
        Me.xcbo_unit_type.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LibXConnector1, "ivunitd.unit_type"))
        Me.xcbo_unit_type.DefaultWhereString = Nothing
        Me.xcbo_unit_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_unit_type.EditInitialValue = Nothing
        Me.xcbo_unit_type.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_unit_type.FieldDescription = ""
        Me.xcbo_unit_type.FindInitialValue = Nothing
        Me.xcbo_unit_type.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_unit_type.IgnoreRequiered = False
        Me.xcbo_unit_type.Items.AddRange(New Object() {"1-Venta", "2-Compra", "3-Compra y Venta"})
        Me.xcbo_unit_type.Location = New System.Drawing.Point(560, 16)
        Me.xcbo_unit_type.LookupKeyDisplayFields = ""
        Me.xcbo_unit_type.LookupKeyField = ""
        Me.xcbo_unit_type.LookupTableName = ""
        Me.xcbo_unit_type.Name = "xcbo_unit_type"
        Me.xcbo_unit_type.NewInitialValue = Nothing
        Me.xcbo_unit_type.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_unit_type.Requiered = False
        Me.xcbo_unit_type.Required = False
        Me.xcbo_unit_type.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_unit_type.SqlString = Nothing
        Me.xcbo_unit_type.StatusBarPanelDescripcion = Nothing
        Me.xcbo_unit_type.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(24, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ivitemm.item_code"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(112, 16)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 1
        Me.XTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ivitemm.unit_name"))
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(176, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(248, 20)
        Me.Label5.TabIndex = 7
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Unidades de Compra y Venta"
        Me.LibXGrid1.DataMember = "ivunitd"
        Me.LibXGrid1.DataSource = Me.LibXConnector1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 136)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(592, 256)
        Me.LibXGrid1.TabIndex = 13
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColunit_code, Me.gColUnit_Name, Me.gcolUnit_type, Me.gcolfactor, Me.gcolCosto})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivunitd"
        '
        'gColunit_code
        '
        Me.gColunit_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColunit_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColunit_code.executeFindDuringFill = False
        Me.gColunit_code.Format = ""
        Me.gColunit_code.FormatInfo = Nothing
        Me.gColunit_code.HeaderText = "Unidad"
        Me.gColunit_code.isReadOnly = False
        Me.gColunit_code.Lookup = Me.xlk_unit_code
        Me.gColunit_code.MappingName = "unit_code"
        Me.gColunit_code.MaxLength = 32767
        Me.gColunit_code.TabStop = True
        Me.gColunit_code.UseCustomCellFormat = False
        Me.gColunit_code.Width = 75
        '
        'xlk_unit_code
        '
        Me.xlk_unit_code.AlternateFieldSearch = Nothing
        Me.xlk_unit_code.BeginCheck = False
        Me.xlk_unit_code.CheckText = Nothing
        Me.xlk_unit_code.ComboMode = False
        Me.xlk_unit_code.DataMember = Nothing
        Me.xlk_unit_code.DataSource = Me.LibXConnector1
        Me.xlk_unit_code.DestParameters = New String() {"unit_code=unit_code", "unit_name=unit_name", "factor=factor"}
        Me.xlk_unit_code.FilterField = "unit_name"
        Me.xlk_unit_code.IgnoreFindInBrowseMode = True
        Me.xlk_unit_code.isCanceled = False
        Me.xlk_unit_code.Location = New System.Drawing.Point(360, 168)
        Me.xlk_unit_code.LookCaption = "Unidades de Medidas"
        Me.xlk_unit_code.Name = "xlk_unit_code"
        Me.xlk_unit_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_unit_code.ShowFilter = True
        Me.xlk_unit_code.ShowMessageNotFound = True
        Me.xlk_unit_code.ShowWarning = False
        Me.xlk_unit_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_unit_code.SizesColumns = New String() {"unit_name=250"}
        Me.xlk_unit_code.SizesColumnsTab = Nothing
        Me.xlk_unit_code.SqlString = Nothing
        Me.xlk_unit_code.SQLTab = Nothing
        Me.xlk_unit_code.SrcParameters = New String() {"unit_code=unit_code"}
        Me.xlk_unit_code.TabIndex = 15
        Me.xlk_unit_code.TableName = "ivunitm"
        Me.xlk_unit_code.TabStop = False
        Me.xlk_unit_code.UseCopyConnection = False
        Me.xlk_unit_code.UseRowRetrieveEvents = False
        Me.xlk_unit_code.UseTab = False
        Me.xlk_unit_code.VisParameters = New String() {"Código=unit_code", "Descripcion=unit_name", "Factor=factor"}
        Me.xlk_unit_code.WhereCondition = Nothing
        Me.xlk_unit_code.WhereParameters = Nothing
        '
        'gColUnit_Name
        '
        Me.gColUnit_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColUnit_Name.Format = ""
        Me.gColUnit_Name.FormatInfo = Nothing
        Me.gColUnit_Name.HeaderText = "Unidad Medida"
        Me.gColUnit_Name.ImageList = Nothing
        Me.gColUnit_Name.isReadOnly = False
        Me.gColUnit_Name.MappingName = "unit_name"
        Me.gColUnit_Name.MaxLength = 32767
        Me.gColUnit_Name.TabStop = True
        Me.gColUnit_Name.UseCustomCellFormat = False
        Me.gColUnit_Name.Width = 200
        '
        'gcolUnit_type
        '
        Me.gcolUnit_type.ComboBox = Me.xcbo_unit_type
        Me.gcolUnit_type.Format = ""
        Me.gcolUnit_type.FormatInfo = Nothing
        Me.gcolUnit_type.HeaderText = "Tipo de Unidad"
        Me.gcolUnit_type.isReadOnly = False
        Me.gcolUnit_type.MappingName = "unit_type"
        Me.gcolUnit_type.Width = 110
        '
        'gcolfactor
        '
        Me.gcolfactor.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gcolfactor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolfactor.Format = ""
        Me.gcolfactor.FormatInfo = Nothing
        Me.gcolfactor.HeaderText = "Factor x Unidadi"
        Me.gcolfactor.ImageList = Nothing
        Me.gcolfactor.isReadOnly = False
        Me.gcolfactor.MappingName = "factor"
        Me.gcolfactor.MaxLength = 32767
        Me.gcolfactor.TabStop = True
        Me.gcolfactor.UseCustomCellFormat = False
        Me.gcolfactor.Width = 75
        '
        'gcolCosto
        '
        Me.gcolCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolCosto.Format = "###,##0.00"
        Me.gcolCosto.FormatInfo = Nothing
        Me.gcolCosto.HeaderText = "Costo"
        Me.gcolCosto.ImageList = Nothing
        Me.gcolCosto.isReadOnly = True
        Me.gcolCosto.MappingName = "costo"
        Me.gcolCosto.MaxLength = 32767
        Me.gcolCosto.ReadOnly = True
        Me.gcolCosto.TabStop = False
        Me.gcolCosto.UseCustomCellFormat = False
        Me.gcolCosto.Width = 75
        '
        'LibXShortNavigator1
        '
        Me.LibXShortNavigator1.BuildMenu = True
        Me.LibXShortNavigator1.Connector = Me.LibXConnector1
        Me.LibXShortNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXShortNavigator1.FirstControlInEditMode = Nothing
        Me.LibXShortNavigator1.FirstControlInFindMode = Nothing
        Me.LibXShortNavigator1.FirstControlInNewMode = Nothing
        Me.LibXShortNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXShortNavigator1.Name = "LibXShortNavigator1"
        Me.LibXShortNavigator1.Size = New System.Drawing.Size(610, 24)
        Me.LibXShortNavigator1.TabIndex = 14
        '
        'btnUnit
        '
        Me.btnUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnit.Location = New System.Drawing.Point(8, 408)
        Me.btnUnit.Name = "btnUnit"
        Me.btnUnit.TabIndex = 16
        Me.btnUnit.Text = "Unidades"
        '
        'i_ivunitm02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(610, 456)
        Me.Controls.Add(Me.btnUnit)
        Me.Controls.Add(Me.xlk_unit_code)
        Me.Controls.Add(Me.LibXShortNavigator1)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivunitm02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Asignar Unidades de Compra y Venta"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivunitd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnit.Click
        Try
            LibX.LibXRunner.Run("i_ivunitm01", "INV")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xlk_unit_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_unit_code.BeforeExecuteQuery
        Try
            e.aditionalWhere = "Factor <= " & LibXConnector1.CurrentDataRow!factor.ToString.Trim
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub LibXGrid1_CellKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LibXGrid1.CellKeyPress
        Dim SelectStmt As String
        Try
            If LibXConnector1.IsDataEditing = True Then
                mLastKeyPressedInGrid = e.KeyCode
                If e.KeyCode = Keys.Delete Then

                    SelectStmt = "insert into ivunitdd select * from ivunitd where item_code ='" & LibXConnector1.CurrentDataRow!item_code.ToString.Trim & "'" & _
                             " and unit_code = '" & LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColunit_code) & "'" & _
                             " and item_code in(select item_code from ivtranrd where unit_code = '" & LibXGrid1.SetValue(LibXGrid1.currentRowNum, gColunit_code) & "')"
                    LibX.Data.Manager.GetScalar(SelectStmt)
                    LibXGrid1.Refresh()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        e.UpdatingArgs.Row.AcceptChanges()
        e.Handled = True
    End Sub
    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
        Try
            If Me.gcolfactor.Column = e.cell Then
                If (LibXGrid1.GetValue(e.row, Me.gcolfactor).ToString.Trim = "" Or LibXGrid1.GetValue(e.row, Me.gcolfactor).ToString.Trim = 0) Then
                    Throw New ApplicationException("Debe Digitar el factor de esta unidad que debe ser mayor de 0!")
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            e.hasErrors = True
            LibX.Log.Show(ex)
        End Try
    End Sub

End Class
