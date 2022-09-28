Public Class i_ptvcomb01

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
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As LibX.LibxDateTimePicker
    Friend WithEvents dtpFechaIni As LibX.LibxDateTimePicker
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents pvcombmh As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents pvcombmd As System.Data.DataTable
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents LabelAlmacen As System.Windows.Forms.Label
    Friend WithEvents LabelTipoOrden As System.Windows.Forms.Label
    Friend WithEvents xlk_Almacen As LibX.LibXLookup
    Friend WithEvents xlk_Tipo_Orden As LibX.LibXLookup
    Friend WithEvents xlk_item_code As LibX.LibXLookup
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents xcbo_unit_code As LibX.LibXCombo
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XDataGridTextButtonColumn1 As LibX.XDataGridTextButtonColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents xdt_Cantidad As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_Oferta As LibX.XEditTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents txtAlmacen As LibX.XTextBox
    Friend WithEvents txtTipoOrden As LibX.XTextBox
    Friend WithEvents txtCombo_Code As LibX.XTextBox
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents xlk_Type_Code As LibX.LibXLookup
    Friend WithEvents xdt_unit_code As LibX.XDataGridComboBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xlk_Type_Code = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.pvcombmh = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.pvcombmd = New System.Data.DataTable
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.txtCombo_Code = New LibX.XTextBox
        Me.txtAlmacen = New LibX.XTextBox
        Me.txtTipoOrden = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.xlk_item_code = New LibX.LibXLookup
        Me.dtpFechaFin = New LibX.LibxDateTimePicker
        Me.dtpFechaIni = New LibX.LibxDateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.xlk_Almacen = New LibX.LibXLookup
        Me.LabelAlmacen = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.xlk_Tipo_Orden = New LibX.LibXLookup
        Me.LabelTipoOrden = New System.Windows.Forms.Label
        Me.xcbo_unit_code = New LibX.LibXCombo
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XDataGridTextButtonColumn1 = New LibX.XDataGridTextButtonColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.xdt_unit_code = New LibX.XDataGridComboBoxColumn
        Me.xdt_Cantidad = New LibX.XEditTextBoxColumn
        Me.xdt_Oferta = New LibX.XEditTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pvcombmh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pvcombmd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xlk_Type_Code)
        Me.GroupBox1.Controls.Add(Me.txtCombo_Code)
        Me.GroupBox1.Controls.Add(Me.txtAlmacen)
        Me.GroupBox1.Controls.Add(Me.txtTipoOrden)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.xlk_item_code)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.dtpFechaIni)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xlk_Almacen)
        Me.GroupBox1.Controls.Add(Me.LabelAlmacen)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xlk_Tipo_Orden)
        Me.GroupBox1.Controls.Add(Me.LabelTipoOrden)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'xlk_Type_Code
        '
        Me.xlk_Type_Code.CheckText = Nothing
        Me.xlk_Type_Code.DataMember = Nothing
        Me.xlk_Type_Code.DataSource = Me.LibXConnector1
        Me.xlk_Type_Code.DestParameters = New String() {"txtTipoOrden=type_code", "LabeTipoOrden=type_name"}
        Me.xlk_Type_Code.FilterField = "type_name"
        Me.xlk_Type_Code.IgnoreFindInBrowseMode = False
        Me.xlk_Type_Code.Location = New System.Drawing.Point(440, 64)
        Me.xlk_Type_Code.LookCaption = "Tipo Venta"
        Me.xlk_Type_Code.Name = "xlk_Type_Code"
        Me.xlk_Type_Code.ShowMessageNotFound = True
        Me.xlk_Type_Code.ShowWarning = False
        Me.xlk_Type_Code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_Type_Code.SizesColumns = Nothing
        Me.xlk_Type_Code.SizesColumnsTab = Nothing
        Me.xlk_Type_Code.SqlString = Nothing
        Me.xlk_Type_Code.SQLTab = Nothing
        Me.xlk_Type_Code.SrcParameters = New String() {"order_type=Type_code"}
        Me.xlk_Type_Code.TabIndex = 86
        Me.xlk_Type_Code.TableName = "ivtypem"
        Me.xlk_Type_Code.UseCopyConnection = False
        Me.xlk_Type_Code.UseRowRetrieveEvents = False
        Me.xlk_Type_Code.UseTab = False
        Me.xlk_Type_Code.VisParameters = New String() {"Tipo Orden=Type_code", "Descripcion=Type_name"}
        Me.xlk_Type_Code.WhereCondition = Nothing
        Me.xlk_Type_Code.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "pvcombmh"
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
        Me.LibXConnector1.ReportName = Nothing
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.pvcombmh, Me.pvcombmd})
        '
        'pvcombmh
        '
        Me.pvcombmh.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18})
        Me.pvcombmh.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"combo_code"}, True)})
        Me.pvcombmh.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.pvcombmh.TableName = "pvcombmh"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "combo_code"
        Me.DataColumn1.MaxLength = 15
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "combo_desc"
        Me.DataColumn2.MaxLength = 50
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "order_type"
        Me.DataColumn3.MaxLength = 3
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "whse_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "fecha_init"
        Me.DataColumn5.DataType = GetType(System.DateTime)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "fecha_fin"
        Me.DataColumn6.DataType = GetType(System.DateTime)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "valor"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.AutoIncrement = True
        Me.DataColumn17.ColumnName = "combo_serial"
        Me.DataColumn17.DataType = GetType(System.Int32)
        Me.DataColumn17.ReadOnly = True
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "Precio"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        '
        'pvcombmd
        '
        Me.pvcombmd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn19})
        Me.pvcombmd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"Combo_code"}, True)})
        Me.pvcombmd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn7}
        Me.pvcombmd.TableName = "pvcombmd"
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "Combo_code"
        Me.DataColumn7.MaxLength = 15
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "line_no"
        Me.DataColumn8.DataType = GetType(System.Int16)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "item_code"
        Me.DataColumn9.MaxLength = 10
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "cantidad"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "unit_code"
        Me.DataColumn11.MaxLength = 5
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "costo"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "precio"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "oferta"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "item_name"
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "combo_serial"
        Me.DataColumn19.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "combo_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "pvcombmh"
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
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = "line_no"
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"combo_serial=combo_serial"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = Nothing
        Me.LibXDbSourceTable2.TableName = "pvcombmd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'txtCombo_Code
        '
        Me.txtCombo_Code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvcombmh.combo_code"))
        Me.txtCombo_Code.EditInitialValue = Nothing
        Me.txtCombo_Code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCombo_Code.FindInitialValue = Nothing
        Me.txtCombo_Code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCombo_Code.IgnoreRequiered = False
        Me.txtCombo_Code.Location = New System.Drawing.Point(88, 16)
        Me.txtCombo_Code.Name = "txtCombo_Code"
        Me.txtCombo_Code.NewInitialValue = Nothing
        Me.txtCombo_Code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCombo_Code.Requiered = True
        Me.txtCombo_Code.Size = New System.Drawing.Size(88, 20)
        Me.txtCombo_Code.TabIndex = 85
        Me.txtCombo_Code.Text = ""
        '
        'txtAlmacen
        '
        Me.txtAlmacen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvcombmh.whse_code"))
        Me.txtAlmacen.EditInitialValue = Nothing
        Me.txtAlmacen.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAlmacen.FindInitialValue = Nothing
        Me.txtAlmacen.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAlmacen.IgnoreRequiered = False
        Me.txtAlmacen.Location = New System.Drawing.Point(88, 88)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.NewInitialValue = Nothing
        Me.txtAlmacen.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAlmacen.Requiered = True
        Me.txtAlmacen.Size = New System.Drawing.Size(48, 20)
        Me.txtAlmacen.TabIndex = 84
        Me.txtAlmacen.Text = ""
        '
        'txtTipoOrden
        '
        Me.txtTipoOrden.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvcombmh.order_type"))
        Me.txtTipoOrden.EditInitialValue = Nothing
        Me.txtTipoOrden.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTipoOrden.FindInitialValue = Nothing
        Me.txtTipoOrden.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTipoOrden.IgnoreRequiered = False
        Me.txtTipoOrden.Location = New System.Drawing.Point(88, 64)
        Me.txtTipoOrden.Name = "txtTipoOrden"
        Me.txtTipoOrden.NewInitialValue = Nothing
        Me.txtTipoOrden.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTipoOrden.Requiered = True
        Me.txtTipoOrden.Size = New System.Drawing.Size(48, 20)
        Me.txtTipoOrden.TabIndex = 83
        Me.txtTipoOrden.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(32, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Precio :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox2
        '
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvcombmh.Precio"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(88, 112)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = True
        Me.XTextBox2.Size = New System.Drawing.Size(72, 20)
        Me.XTextBox2.TabIndex = 81
        Me.XTextBox2.Text = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label24.Location = New System.Drawing.Point(528, 40)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 16)
        Me.Label24.TabIndex = 78
        Me.Label24.Text = "Fecha Fin:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(528, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Fecha Inicio:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_item_code
        '
        Me.xlk_item_code.CheckText = Nothing
        Me.xlk_item_code.DataMember = Nothing
        Me.xlk_item_code.DataSource = Me.LibXConnector1
        Me.xlk_item_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "unit_code=purch_unit", "costo=purch_cost", "precio=price"}
        Me.xlk_item_code.FilterField = "item_name"
        Me.xlk_item_code.IgnoreFindInBrowseMode = False
        Me.xlk_item_code.Location = New System.Drawing.Point(512, 176)
        Me.xlk_item_code.LookCaption = "Producto"
        Me.xlk_item_code.Name = "xlk_item_code"
        Me.xlk_item_code.ShowMessageNotFound = True
        Me.xlk_item_code.ShowWarning = False
        Me.xlk_item_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_item_code.SizesColumns = Nothing
        Me.xlk_item_code.SizesColumnsTab = Nothing
        Me.xlk_item_code.SqlString = New String() {Nothing}
        Me.xlk_item_code.SQLTab = Nothing
        Me.xlk_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.xlk_item_code.TabIndex = 79
        Me.xlk_item_code.TableName = "ivitemv1"
        Me.xlk_item_code.UseCopyConnection = False
        Me.xlk_item_code.UseRowRetrieveEvents = False
        Me.xlk_item_code.UseTab = False
        Me.xlk_item_code.VisParameters = New String() {"Producto=item_code", "Nombre=item_name", "Unidad=unit_code", "Precio=purch_cost", "Costo=price"}
        Me.xlk_item_code.WhereCondition = Nothing
        Me.xlk_item_code.WhereParameters = Nothing
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaFin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "pvcombmh.fecha_fin"))
        Me.dtpFechaFin.EditInitialValue = Nothing
        Me.dtpFechaFin.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dtpFechaFin.FindInitialValue = Nothing
        Me.dtpFechaFin.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin.IgnoreRequiered = False
        Me.dtpFechaFin.Location = New System.Drawing.Point(600, 40)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.NewInitialValue = Nothing
        Me.dtpFechaFin.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dtpFechaFin.Requiered = True
        Me.dtpFechaFin.Size = New System.Drawing.Size(112, 20)
        Me.dtpFechaFin.TabIndex = 77
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaIni.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "pvcombmh.fecha_init"))
        Me.dtpFechaIni.EditInitialValue = Nothing
        Me.dtpFechaIni.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dtpFechaIni.FindInitialValue = Nothing
        Me.dtpFechaIni.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaIni.IgnoreRequiered = False
        Me.dtpFechaIni.Location = New System.Drawing.Point(600, 16)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.NewInitialValue = Nothing
        Me.dtpFechaIni.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dtpFechaIni.Requiered = True
        Me.dtpFechaIni.Size = New System.Drawing.Size(112, 20)
        Me.dtpFechaIni.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(29, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Codigo :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(5, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Descripción :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvcombmh.combo_desc"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(88, 40)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = True
        Me.XTextBox1.Size = New System.Drawing.Size(368, 20)
        Me.XTextBox1.TabIndex = 20
        Me.XTextBox1.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(21, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Almacen :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Orden :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_Almacen
        '
        Me.xlk_Almacen.CheckText = Nothing
        Me.xlk_Almacen.DataMember = Nothing
        Me.xlk_Almacen.DataSource = Me.LibXConnector1
        Me.xlk_Almacen.DestParameters = New String() {"txtAlmacen=whse_code", "LabelAlmacen=whse_name"}
        Me.xlk_Almacen.FilterField = "whse_name"
        Me.xlk_Almacen.IgnoreFindInBrowseMode = False
        Me.xlk_Almacen.Location = New System.Drawing.Point(440, 88)
        Me.xlk_Almacen.LookCaption = "Almacen"
        Me.xlk_Almacen.Name = "xlk_Almacen"
        Me.xlk_Almacen.ShowMessageNotFound = True
        Me.xlk_Almacen.ShowWarning = False
        Me.xlk_Almacen.Size = New System.Drawing.Size(16, 20)
        Me.xlk_Almacen.SizesColumns = Nothing
        Me.xlk_Almacen.SizesColumnsTab = Nothing
        Me.xlk_Almacen.SqlString = Nothing
        Me.xlk_Almacen.SQLTab = Nothing
        Me.xlk_Almacen.SrcParameters = New String() {"whse_code=whse_code"}
        Me.xlk_Almacen.TabIndex = 19
        Me.xlk_Almacen.TableName = "ivwhsem"
        Me.xlk_Almacen.UseCopyConnection = False
        Me.xlk_Almacen.UseRowRetrieveEvents = False
        Me.xlk_Almacen.UseTab = False
        Me.xlk_Almacen.VisParameters = New String() {"Almacen=whse_code", "Descripcion=whse_name"}
        Me.xlk_Almacen.WhereCondition = Nothing
        Me.xlk_Almacen.WhereParameters = Nothing
        '
        'LabelAlmacen
        '
        Me.LabelAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAlmacen.Location = New System.Drawing.Point(136, 88)
        Me.LabelAlmacen.Name = "LabelAlmacen"
        Me.LabelAlmacen.Size = New System.Drawing.Size(304, 20)
        Me.LabelAlmacen.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 0)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cantidad:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_Tipo_Orden
        '
        Me.xlk_Tipo_Orden.CheckText = Nothing
        Me.xlk_Tipo_Orden.DataMember = Nothing
        Me.xlk_Tipo_Orden.DataSource = Me.LibXConnector1
        Me.xlk_Tipo_Orden.DestParameters = New String() {"txtTipoOrden=type_code", "LabelTipoOrden=type_name"}
        Me.xlk_Tipo_Orden.FilterField = "type_name"
        Me.xlk_Tipo_Orden.IgnoreFindInBrowseMode = False
        Me.xlk_Tipo_Orden.Location = New System.Drawing.Point(440, 40)
        Me.xlk_Tipo_Orden.LookCaption = "Tipo Venta"
        Me.xlk_Tipo_Orden.Name = "xlk_Tipo_Orden"
        Me.xlk_Tipo_Orden.ShowMessageNotFound = True
        Me.xlk_Tipo_Orden.ShowWarning = False
        Me.xlk_Tipo_Orden.Size = New System.Drawing.Size(16, 20)
        Me.xlk_Tipo_Orden.SizesColumns = Nothing
        Me.xlk_Tipo_Orden.SizesColumnsTab = Nothing
        Me.xlk_Tipo_Orden.SqlString = Nothing
        Me.xlk_Tipo_Orden.SQLTab = Nothing
        Me.xlk_Tipo_Orden.SrcParameters = New String() {"order_type=type_code"}
        Me.xlk_Tipo_Orden.TabIndex = 6
        Me.xlk_Tipo_Orden.TableName = "ivtypem"
        Me.xlk_Tipo_Orden.UseCopyConnection = False
        Me.xlk_Tipo_Orden.UseRowRetrieveEvents = False
        Me.xlk_Tipo_Orden.UseTab = False
        Me.xlk_Tipo_Orden.VisParameters = New String() {"Tipo Venta=type_code", "Descripcion=type_name"}
        Me.xlk_Tipo_Orden.WhereCondition = Nothing
        Me.xlk_Tipo_Orden.WhereParameters = Nothing
        '
        'LabelTipoOrden
        '
        Me.LabelTipoOrden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTipoOrden.Location = New System.Drawing.Point(136, 64)
        Me.LabelTipoOrden.Name = "LabelTipoOrden"
        Me.LabelTipoOrden.Size = New System.Drawing.Size(304, 20)
        Me.LabelTipoOrden.TabIndex = 5
        '
        'xcbo_unit_code
        '
        Me.xcbo_unit_code.AllowDefaultSort = True
        Me.xcbo_unit_code.bound = True
        Me.xcbo_unit_code.currValue = Nothing
        Me.xcbo_unit_code.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "pvcombmd.unit_code"))
        Me.xcbo_unit_code.DefaultWhereString = Nothing
        Me.xcbo_unit_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_unit_code.EditInitialValue = Nothing
        Me.xcbo_unit_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_unit_code.FindInitialValue = Nothing
        Me.xcbo_unit_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_unit_code.IgnoreRequiered = False
        Me.xcbo_unit_code.Location = New System.Drawing.Point(648, 184)
        Me.xcbo_unit_code.LookupKeyDisplayFields = "unit_name"
        Me.xcbo_unit_code.LookupKeyField = "unit_code"
        Me.xcbo_unit_code.LookupTableName = "ivunitv"
        Me.xcbo_unit_code.Name = "xcbo_unit_code"
        Me.xcbo_unit_code.NewInitialValue = Nothing
        Me.xcbo_unit_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_unit_code.Requiered = False
        Me.xcbo_unit_code.Required = False
        Me.xcbo_unit_code.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_unit_code.SqlString = Nothing
        Me.xcbo_unit_code.TabIndex = 80
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(778, 24)
        Me.LibXNavigator1.TabIndex = 2
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.DataMember = "pvcombmd"
        Me.LibXGrid1.DataSource = Me.LibXConnector1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 184)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(760, 280)
        Me.LibXGrid1.TabIndex = 3
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XDataGridTextButtonColumn1, Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn3, Me.xdt_unit_code, Me.xdt_Cantidad, Me.xdt_Oferta})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "pvcombmd"
        '
        'XDataGridTextButtonColumn1
        '
        Me.XDataGridTextButtonColumn1.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.XDataGridTextButtonColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XDataGridTextButtonColumn1.executeFindDuringFill = False
        Me.XDataGridTextButtonColumn1.Format = ""
        Me.XDataGridTextButtonColumn1.FormatInfo = Nothing
        Me.XDataGridTextButtonColumn1.HeaderText = "Producto"
        Me.XDataGridTextButtonColumn1.isReadOnly = False
        Me.XDataGridTextButtonColumn1.Lookup = Me.xlk_item_code
        Me.XDataGridTextButtonColumn1.MappingName = "item_code"
        Me.XDataGridTextButtonColumn1.MaxLength = 32767
        Me.XDataGridTextButtonColumn1.UseCustomCellFormat = False
        Me.XDataGridTextButtonColumn1.Width = 101
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Descripcion"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "item_name"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 200
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = "##,##0.00"
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Costo"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "costo"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 75
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Precio"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = False
        Me.XEditTextBoxColumn3.MappingName = "precio"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 75
        '
        'xdt_unit_code
        '
        Me.xdt_unit_code.ComboBox = Me.xcbo_unit_code
        Me.xdt_unit_code.Format = ""
        Me.xdt_unit_code.FormatInfo = Nothing
        Me.xdt_unit_code.HeaderText = "Unidad"
        Me.xdt_unit_code.isReadOnly = False
        Me.xdt_unit_code.MappingName = "unit_code"
        Me.xdt_unit_code.Width = 101
        '
        'xdt_Cantidad
        '
        Me.xdt_Cantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Cantidad.Format = ""
        Me.xdt_Cantidad.FormatInfo = Nothing
        Me.xdt_Cantidad.HeaderText = "Cantidad"
        Me.xdt_Cantidad.ImageList = Nothing
        Me.xdt_Cantidad.isReadOnly = False
        Me.xdt_Cantidad.MappingName = "cantidad"
        Me.xdt_Cantidad.MaxLength = 32767
        Me.xdt_Cantidad.UseCustomCellFormat = False
        Me.xdt_Cantidad.Width = 75
        '
        'xdt_Oferta
        '
        Me.xdt_Oferta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Oferta.Format = ""
        Me.xdt_Oferta.FormatInfo = Nothing
        Me.xdt_Oferta.HeaderText = "Oferta"
        Me.xdt_Oferta.ImageList = Nothing
        Me.xdt_Oferta.isReadOnly = False
        Me.xdt_Oferta.MappingName = "oferta"
        Me.xdt_Oferta.MaxLength = 32767
        Me.xdt_Oferta.UseCustomCellFormat = False
        Me.xdt_Oferta.Width = 75
        '
        'i_ptvcomb01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(778, 520)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.xcbo_unit_code)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ptvcomb01"
        Me.Text = "Ofertas y Combos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pvcombmh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pvcombmd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
        Try
            '// Validar cantidad
            If LibXConnector1.IsDataEditing = True Then
                If Me.xdt_Cantidad.Column = e.cell Then
                    If Val(e.value.ToString.Trim) <= 0 Then
                        Throw New ApplicationException("Cantidad inválido!")
                    End If
                End If
                '// Validar oferta
                If Me.xdt_Oferta.Column = e.cell Then
                    If Val(e.value.ToString.Trim) <= 0 Then
                        Throw New ApplicationException("Cantidad Oferta inválido!")
                    End If
                End If
                '//validad oferta menor a la cantidad
                If Me.xdt_Oferta.Column = e.cell Then
                    If Val(e.value.ToString.Trim) >= 0 Then
                        If Val(e.value.ToString.Trim) >= Me.xdt_Cantidad.TextBox.Text() Then
                            Throw New ApplicationException("Oferta  debe ser menor que la cantidad!")
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            e.hasErrors = True
            'Log.Add(ex, True)
        End Try
        

    End Sub


    Private Sub xlk_item_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_item_code.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            xcbo_unit_code.LoadDbItems(False)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xcbo_unit_code_BeforeLoadItems(ByVal sender As Object, ByVal e As LibX.LoadXComboItemsEventArgs) Handles xcbo_unit_code.BeforeLoadItems
        Try
            If LibXConnector1.IsDataEditing = True Then
                e.SqlString = "select * from ivunitv where item_code = '" & LibXGrid1.GetValue(xdt_unit_code).Trim & "'"
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles LibXGrid1.Navigate

    End Sub
End Class
