Public Class i_ivconteoauto
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents xtxt_qty As LibX.XTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents qtyl As System.Windows.Forms.Label
    Friend WithEvents desc1l As System.Windows.Forms.Label
    Friend WithEvents ivcountaut As LibX.LibXDbSourceTable
    Friend WithEvents lkItem_code As LibX.LibXLookup
    Friend WithEvents Xtx_item As LibX.XTextBox
    Friend WithEvents BgenCount As System.Windows.Forms.Button
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents ivcounte As System.Data.DataTable
    Friend WithEvents ivcountd As System.Data.DataTable
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.ivcountaut = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.ivcounte = New System.Data.DataTable
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.ivcountd = New System.Data.DataTable
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
        Me.Xtx_item = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.qtyl = New System.Windows.Forms.Label
        Me.desc1l = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lkItem_code = New LibX.LibXLookup
        Me.xtxt_qty = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BgenCount = New System.Windows.Forms.Button
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivcounte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivcountd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Xtx_item)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.qtyl)
        Me.GroupBox1.Controls.Add(Me.desc1l)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lkItem_code)
        Me.GroupBox1.Controls.Add(Me.xtxt_qty)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ivcountaut.item_name"))
        Me.Label4.Location = New System.Drawing.Point(136, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(376, 20)
        Me.Label4.TabIndex = 15
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
        Me.LibXConnector1.DataMember = Nothing
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.ivcountaut, Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'ivcountaut
        '
        Me.ivcountaut.AllowDelete = True
        Me.ivcountaut.AllowEdit = True
        Me.ivcountaut.AllowNew = True
        Me.ivcountaut.AutoIncrementSerial = False
        Me.ivcountaut.CustomDbUpdate = False
        Me.ivcountaut.DeleteOrder = 0
        Me.ivcountaut.FillOnQuery = True
        Me.ivcountaut.FillOnRowChange = False
        Me.ivcountaut.HeaderIsOnGrid = False
        Me.ivcountaut.InnerJon = True
        Me.ivcountaut.InsertOrder = 0
        Me.ivcountaut.IsDetail = False
        Me.ivcountaut.KeyFields = Nothing
        Me.ivcountaut.LineColName = Nothing
        Me.ivcountaut.MasterDetailRelation = Nothing
        Me.ivcountaut.MasterTableName = Nothing
        Me.ivcountaut.SerialColumnName = "count_serial"
        Me.ivcountaut.Sort = Nothing
        Me.ivcountaut.Source = New String() {"select ivcountaut.*,item_name from ivcountaut,ivitemm ", "where ivcountaut.item_code=ivitemm.item_code"}
        Me.ivcountaut.TableName = "ivcountaut"
        Me.ivcountaut.UpdateOrder = 0
        Me.ivcountaut.UseRowRetrieve = False
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
        Me.LibXDbSourceTable1.TableName = "ivcounte"
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
        Me.LibXDbSourceTable2.TableName = "ivcountd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.ivcounte, Me.ivcountd})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.DataTable1.TableName = "ivcountaut"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "count_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "whse_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "item_code"
        Me.DataColumn3.MaxLength = 10
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "qty_count"
        Me.DataColumn4.DataType = GetType(System.Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "item_name"
        Me.DataColumn5.MaxLength = 100
        '
        'ivcounte
        '
        Me.ivcounte.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.ivcounte.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"count_number"}, True)})
        Me.ivcounte.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn6}
        Me.ivcounte.TableName = "ivcounte"
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.AutoIncrement = True
        Me.DataColumn6.ColumnName = "count_number"
        Me.DataColumn6.DataType = GetType(System.Int32)
        Me.DataColumn6.ReadOnly = True
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "prov_code"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "whse_code"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "count_date"
        Me.DataColumn9.DataType = GetType(System.DateTime)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "count_desc"
        Me.DataColumn10.MaxLength = 60
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "userid"
        Me.DataColumn11.MaxLength = 20
        '
        'ivcountd
        '
        Me.ivcountd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24})
        Me.ivcountd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"count_number", "pageno", "line_no"}, True)})
        Me.ivcountd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn12, Me.DataColumn22, Me.DataColumn23}
        Me.ivcountd.TableName = "ivcountd"
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "count_number"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "unit_code"
        Me.DataColumn13.MaxLength = 5
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "item_code"
        Me.DataColumn14.MaxLength = 10
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "whse_code"
        Me.DataColumn15.DataType = GetType(System.Int32)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "count_qty"
        Me.DataColumn16.DataType = GetType(System.Int32)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "loc_row"
        Me.DataColumn17.MaxLength = 20
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "loc_bin"
        Me.DataColumn18.MaxLength = 20
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "estante"
        Me.DataColumn19.MaxLength = 20
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "qty_on_hand"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "factor"
        Me.DataColumn21.DataType = GetType(System.Decimal)
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "pageno"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "line_no"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.ColumnName = "count_status"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'Xtx_item
        '
        Me.Xtx_item.AcceptsReturn = True
        Me.Xtx_item.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ivcountaut.item_code"))
        Me.Xtx_item.EditInitialValue = Nothing
        Me.Xtx_item.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtx_item.FieldDescription = ""
        Me.Xtx_item.FindInitialValue = Nothing
        Me.Xtx_item.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtx_item.IgnoreRequiered = False
        Me.Xtx_item.Location = New System.Drawing.Point(136, 48)
        Me.Xtx_item.Name = "Xtx_item"
        Me.Xtx_item.NewInitialValue = Nothing
        Me.Xtx_item.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtx_item.Requiered = False
        Me.Xtx_item.Size = New System.Drawing.Size(184, 20)
        Me.Xtx_item.StatusBarPanelDescripcion = Nothing
        Me.Xtx_item.TabIndex = 1
        Me.Xtx_item.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(48, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Producto leido:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'qtyl
        '
        Me.qtyl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.qtyl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivcountaut.qty_count"))
        Me.qtyl.Location = New System.Drawing.Point(136, 96)
        Me.qtyl.Name = "qtyl"
        Me.qtyl.Size = New System.Drawing.Size(72, 20)
        Me.qtyl.TabIndex = 10
        '
        'desc1l
        '
        Me.desc1l.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.desc1l.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivcountaut.item_name"))
        Me.desc1l.Location = New System.Drawing.Point(208, 96)
        Me.desc1l.Name = "desc1l"
        Me.desc1l.Size = New System.Drawing.Size(304, 20)
        Me.desc1l.TabIndex = 9
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
        'lkItem_code
        '
        Me.lkItem_code.AlternateFieldSearch = "item_name"
        Me.lkItem_code.BeginCheck = False
        Me.lkItem_code.CheckText = Nothing
        Me.lkItem_code.ComboMode = False
        Me.lkItem_code.DataMember = Nothing
        Me.lkItem_code.DataSource = Me.LibXConnector1
        Me.lkItem_code.DestParameters = New String() {"item_code=item_code"}
        Me.lkItem_code.FilterField = "item_name"
        Me.lkItem_code.IgnoreFindInBrowseMode = False
        Me.lkItem_code.isCanceled = False
        Me.lkItem_code.Location = New System.Drawing.Point(320, 48)
        Me.lkItem_code.LookCaption = "Productos"
        Me.lkItem_code.Name = "lkItem_code"
        Me.lkItem_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkItem_code.ShowFilter = True
        Me.lkItem_code.ShowMessageNotFound = True
        Me.lkItem_code.ShowWarning = False
        Me.lkItem_code.Size = New System.Drawing.Size(16, 20)
        Me.lkItem_code.SizesColumns = New String(-1) {}
        Me.lkItem_code.SizesColumnsTab = Nothing
        Me.lkItem_code.SqlString = New String() {"select distinct  ivitemv1.item_code,ivitemv1.item_name,ivitemv1.whse_code", "from ivitemv1 left join ivcbarram on ivitemv1.item_code=ivcbarram.item_code ", ""}
        Me.lkItem_code.SQLTab = Nothing
        Me.lkItem_code.SrcParameters = New String() {"item_code=item_code"}
        Me.lkItem_code.TabIndex = 2
        Me.lkItem_code.TableName = "ivitemv1"
        Me.lkItem_code.TabStop = False
        Me.lkItem_code.UseCopyConnection = False
        Me.lkItem_code.UseRowRetrieveEvents = False
        Me.lkItem_code.UseTab = False
        Me.lkItem_code.VisParameters = New String() {"Código=item_code", "Descripcion=item_name"}
        Me.lkItem_code.WhereCondition = "whse_code = 1"
        Me.lkItem_code.WhereParameters = Nothing
        '
        'xtxt_qty
        '
        Me.xtxt_qty.AcceptsReturn = True
        Me.xtxt_qty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ivcountaut.qty_count"))
        Me.xtxt_qty.EditInitialValue = Nothing
        Me.xtxt_qty.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_qty.FieldDescription = ""
        Me.xtxt_qty.FindInitialValue = Nothing
        Me.xtxt_qty.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_qty.IgnoreRequiered = False
        Me.xtxt_qty.Location = New System.Drawing.Point(136, 24)
        Me.xtxt_qty.Name = "xtxt_qty"
        Me.xtxt_qty.NewInitialValue = Nothing
        Me.xtxt_qty.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_qty.Requiered = False
        Me.xtxt_qty.Size = New System.Drawing.Size(88, 20)
        Me.xtxt_qty.StatusBarPanelDescripcion = Nothing
        Me.xtxt_qty.TabIndex = 0
        Me.xtxt_qty.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(72, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(72, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BgenCount
        '
        Me.BgenCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BgenCount.Location = New System.Drawing.Point(576, 40)
        Me.BgenCount.Name = "BgenCount"
        Me.BgenCount.Size = New System.Drawing.Size(88, 32)
        Me.BgenCount.TabIndex = 14
        Me.BgenCount.Text = "Generar Hoja de Conteo"
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_qty
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_qty
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_qty
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(690, 24)
        Me.LibXNavigator1.TabIndex = 2
        '
        'i_ivconteoauto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 208)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BgenCount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivconteoauto"
        Me.Text = "Conteo por Captuara de Codigo"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivcounte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivcountd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXLookup1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkItem_code.Load
        Me.xtxt_qty.Focus()
    End Sub
    Private Sub LibXLookup1_AfterSetValues(ByVal sender As System.Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkItem_code.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If
            If LibXConnector1.IsDataEditing = True Then
                Me.Xtx_item.Text = e.row!item_code.ToString.Trim
                Me.desc1l.Text = e.row!item_name.ToString.Trim
                If Me.xtxt_qty.Text = "" Then
                    Me.xtxt_qty.Text = 1
                End If
                Me.qtyl.Text = Me.xtxt_qty.Text
                LibXConnector1.Accept()
                Me.xtxt_qty.Focus()
                LibXConnector1.AddNew()
                Me.xtxt_qty.Focus()
                Me.xtxt_qty.Text = 1
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaulteditValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultEditValues) Handles LibXConnector1.SettingDefaulteditValues
        'Me.xtxt_qty.Text = 1
    End Sub
    Private Sub lkItem_code_BefeforeExecuteSqlFind(ByVal sender As Object, ByVal e As LibX.LookupFindEventArgs) Handles lkItem_code.BefeforeExecuteSqlFind
        Dim Selsqlstring As String
        Try

            If LibXConnector1.IsDataEditing = True Then
                If Len(Me.Xtx_item.Text.Trim) >= 8 And IsNumeric(Me.Xtx_item.Text.Trim) Then
                    e.SQL = e.SQL.Replace("ivitemv1.item_code =", "ivcbarram.barra =")
                End If
                '''e.SQL = e.SQL
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub BgenCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BgenCount.Click

        Dim SelecStmt As String
        Dim sWhere As String
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim oTable As DataTable
        Dim oDoc As SGT.Inventario.Entidades.Documento
        Dim ConteoNo, PaginaNo, LineNo As Integer
        Dim Serial As Integer
        Dim HojaTitulo As String
        Dim DeleteStmt As DataRow
        Dim xDel As LibX.Data.XDeleteStmt
        Dim borrar As Integer
        Try

            sWhere = "1=1"

            SelecStmt = " select ivitemm.prov_code,ivitemm.item_code,item_name,group_code,sgroup_code," & _
                        " brand_code,ivitemd.loc_row, loc_col, estante, ivitemd.whse_code, existencia,  " & _
                        " frizado_inv, ivitemm.unit_code, ivunitv.factor,sum(ivcountaut.qty_count) qty_count " & _
                        " from ivitemm inner join ivitemd  on ivitemm.item_code = ivitemd.item_code  " & _
                        " and (ivitemd.frizado_inv is null or ivitemd.frizado_inv = 0 ) " & _
                        " inner join ivunitv  on ivitemm.item_code = ivunitv.item_code " & _
                        " and ivitemm.unit_code = ivunitv.unit_code " & _
                        " inner join ivcountaut on ivitemm.item_code=ivcountaut.item_code "

            SelecStmt = LibX.ConcatWherePart(SelecStmt, sWhere)

            SelecStmt = SelecStmt & " group by ivitemm.prov_code,ivitemm.item_code,item_name,group_code,sgroup_code, " & _
                     " brand_code,ivitemd.loc_row, loc_col, estante, ivitemd.whse_code, existencia,  " & _
                     " frizado_inv, ivitemm.unit_code, ivunitv.factor  order by ivitemm.item_name "

            oTable = LibX.Data.Manager.GetDataTable(SelecStmt)

            If oTable.Rows.Count <= 0 Then
                borrar = MessageBox.Show("Productos ya pertenecen a una hoja de conteo!, Desea Eliminar la Lista? ", "Borrar Registro", MessageBoxButtons.YesNo)
                If borrar = System.Windows.Forms.DialogResult.Yes Then
                    If MessageBox.Show("Generación Exitosa " & oTable.Rows.Count.ToString.Trim & " Producto(s)", "Seguro que desea eliminar la lista", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) Then
                        SelecStmt = "delete from ivcountaut where 1 = 1"
                        LibX.Data.Manager.ExecuteNonQuery(SelecStmt)
                    End If
                    Return
                End If
                Return
            Else
            End If

            HojaTitulo = "CONTEO AUTOMATICO AL " & LibX.Data.Manager.Connection.GetDate.ToString("dd/MM/yyyy")

            If LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            PaginaNo = 0
            LineNo = 66
            Dim oNewRow1 As DataRow

            oNewRow1 = ivcounte.NewRow
            oNewRow1!whse_code = 1
            oNewRow1!count_date = LibX.Data.Manager.Connection.GetDate
            oNewRow1!count_desc = HojaTitulo

            ivcounte.Rows.Add(oNewRow1)

            LibX.Data.Manager.Save(ivcounte, "count_number")
            ConteoNo = LibX.Data.Manager.LastSerialValue

            xUpdate = New LibX.Data.XUpdateStmt("ivitemd")
            xUpdate.FieldsSet("frizado_inv") = 1 '// En conteo
            xUpdate.FieldsSet("fecha_frizado") = LibX.Data.Manager.Connection.GetDate  '// En conteo
            xUpdate.Fields("item_code") = "11"
            xUpdate.Fields("whse_code") = 0

            For Each oRow As DataRow In oTable.Rows
                Dim oNewRow As DataRow = ivcountd.NewRow

                If LineNo >= 33 Then
                    LineNo = 1
                    PaginaNo += 1
                End If

                oNewRow!count_number = ConteoNo
                oNewRow!PageNo = PaginaNo
                oNewRow!line_no = LineNo
                oNewRow!item_code = oRow!item_code
                oNewRow!unit_code = oRow!unit_code
                oNewRow!whse_code = oRow!whse_code
                oNewRow!loc_row = oRow!loc_row
                oNewRow!loc_bin = oRow!loc_col
                oNewRow!count_qty = oRow!qty_count
                oNewRow!estante = oRow!estante
                oNewRow!qty_on_hand = oRow!existencia
                oNewRow!count_status = Val(SGT.Inventario.Entidades.Documento.EstatusHojaConteoEnum.Editada) 'Generada

                ivcountd.Rows.Add(oNewRow)

                LineNo += 1

                xUpdate.Fields("item_code") = oRow!item_code
                xUpdate.Fields("whse_code") = oRow!whse_code
                xUpdate.Execute()
            Next

            LibX.Data.Manager.Save(ivcountd)
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            MessageBox.Show("Generación Exitosa " & oTable.Rows.Count.ToString.Trim & " Producto(s)", "Generar hoja de conteo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            LibX.Log.Add(ex, True)
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If Me.Xtx_item.Text = "" Then
                Throw New ApplicationException("No se puede guardar registro sin codigo!")
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub i_ivconteoauto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class


