Imports LibX
Imports SGT.Inventario
Imports SGT.Inventario.Entidades

Public Class i_ivpreciom01
    Inherits System.Windows.Forms.Form
    Dim oDoc As SGT.Inventario.Entidades.Documento
    Dim costo As Decimal
    Dim precio As Decimal
    Dim benef As Decimal
    Dim cambio As Decimal
    Dim mUnid As String
    Dim mConf As SGT.Inventario.Common.Configuration

    Structure Valor
        'declarando estructura calculos
        Dim costo As Decimal
        Dim precio As Decimal
        Dim benef As Decimal
        Dim cambio As Decimal

    End Structure

    Dim Resultado As Valor

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
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents lkItem_code As LibX.LibXLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents LibXGridDetalle As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents gColITem_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents gColitem_name As LibX.XEditTextBoxColumn
    Friend WithEvents txtwhse_code As LibX.XTextBox
    Friend WithEvents txtwhse_name As LibX.XTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gColCosto As LibX.XEditTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents xlk_Suplidor As LibX.LibXLookup
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
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents txtprov_code As LibX.XTextBox
    Friend WithEvents txtprov_name As LibX.XTextBox
    Friend WithEvents xlk_Almacen As LibX.LibXLookup
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gColPrecio As LibX.XEditTextBoxColumn
    Friend WithEvents gColBeneficio As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents txtBenef As LibX.XMaskEdit
    Friend WithEvents chkCalBenef As LibX.LibxCheckBox
    Friend WithEvents chkGenEtiqueta As LibX.LibxCheckBox
    Friend WithEvents chkEdPrecio As LibX.LibxCheckBox
    Friend WithEvents chkEdCosto As LibX.LibxCheckBox
    Friend WithEvents ivpreciom As System.Data.DataTable
    Friend WithEvents ivpreciod As System.Data.DataTable
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DSTivpreciom As LibX.LibXDbSourceTable
    Friend WithEvents DTSivpreciod As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents xcbo_estatus As LibX.LibXCombo
    Friend WithEvents gColUnid As LibX.XEditTextBoxColumn
    Friend WithEvents grp_Header As System.Windows.Forms.GroupBox
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents xlk_group_code As LibX.LibXLookup
    Friend WithEvents xtxt_group_name As LibX.XTextBox
    Friend WithEvents btnLoadItems As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents xtxt_group_code As LibX.XTextBox
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents gColCambio As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ivpreciom = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.ivpreciod = New System.Data.DataTable
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DSTivpreciom = New LibX.LibXDbSourceTable
        Me.DTSivpreciod = New LibX.LibXDbSourceTable
        Me.txtwhse_code = New LibX.XTextBox
        Me.lkItem_code = New LibX.LibXLookup
        Me.Label8 = New System.Windows.Forms.Label
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.LibXGridDetalle = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColITem_code = New LibX.XDataGridTextButtonColumn
        Me.gColitem_name = New LibX.XEditTextBoxColumn
        Me.gColCosto = New LibX.XEditTextBoxColumn
        Me.gColBeneficio = New LibX.XEditTextBoxColumn
        Me.gColPrecio = New LibX.XEditTextBoxColumn
        Me.gColUnid = New LibX.XEditTextBoxColumn
        Me.gColCambio = New LibX.XEditTextBoxColumn
        Me.xlk_Almacen = New LibX.LibXLookup
        Me.txtwhse_name = New LibX.XTextBox
        Me.grp_Header = New System.Windows.Forms.GroupBox
        Me.btnLoadItems = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.xlk_group_code = New LibX.LibXLookup
        Me.xtxt_group_code = New LibX.XTextBox
        Me.xtxt_group_name = New LibX.XTextBox
        Me.xcbo_estatus = New LibX.LibXCombo
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtBenef = New LibX.XMaskEdit
        Me.chkCalBenef = New LibX.LibxCheckBox
        Me.chkGenEtiqueta = New LibX.LibxCheckBox
        Me.chkEdPrecio = New LibX.LibxCheckBox
        Me.chkEdCosto = New LibX.LibxCheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.xlk_Suplidor = New LibX.LibXLookup
        Me.txtprov_code = New LibX.XTextBox
        Me.txtprov_name = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnActualizar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivpreciom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivpreciod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Nothing
        Me.LibXNavigator1.FirstControlInFindMode = Me.txtwhse_code
        Me.LibXNavigator1.FirstControlInNewMode = Me.txtwhse_code
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(850, 24)
        Me.LibXNavigator1.TabIndex = 0
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
        Me.LibXConnector1.DataMember = "ivpreciom"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = "INV"
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = "r_ivupdprice01.rpt"
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.DSTivpreciom, Me.DTSivpreciod})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivpreciom, Me.ivpreciod})
        '
        'ivpreciom
        '
        Me.ivpreciom.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn18, Me.DataColumn19})
        Me.ivpreciom.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"precio_code"}, True)})
        Me.ivpreciom.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.ivpreciom.TableName = "ivpreciom"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "precio_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "prov_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "whse_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "fecha"
        Me.DataColumn4.DataType = GetType(System.DateTime)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "editar_costo"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "editar_precio"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "generar_etiqueta"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "editar_benef"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "beneficio"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "estatus"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "group_code"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'ivpreciod
        '
        Me.ivpreciod.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22})
        Me.ivpreciod.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"precio_code", "item_code", "line_no"}, True)})
        Me.ivpreciod.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn10, Me.DataColumn11, Me.DataColumn17}
        Me.ivpreciod.TableName = "ivpreciod"
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "precio_code"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "item_code"
        Me.DataColumn11.MaxLength = 10
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
        Me.DataColumn13.ColumnName = "benef"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "precio"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "unidad"
        Me.DataColumn15.MaxLength = 4
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.Caption = "Item_name"
        Me.DataColumn16.ColumnName = "Item_name"
        Me.DataColumn16.MaxLength = 100
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.ColumnName = "line_no"
        Me.DataColumn17.MaxLength = 10
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "cambio"
        Me.DataColumn20.DataType = GetType(System.Decimal)
        '
        'DSTivpreciom
        '
        Me.DSTivpreciom.AllowDelete = True
        Me.DSTivpreciom.AllowEdit = True
        Me.DSTivpreciom.AllowNew = True
        Me.DSTivpreciom.AutoIncrementSerial = False
        Me.DSTivpreciom.CustomDbUpdate = False
        Me.DSTivpreciom.DeleteOrder = 0
        Me.DSTivpreciom.FillOnQuery = True
        Me.DSTivpreciom.FillOnRowChange = False
        Me.DSTivpreciom.HeaderIsOnGrid = False
        Me.DSTivpreciom.InnerJon = True
        Me.DSTivpreciom.InsertOrder = 0
        Me.DSTivpreciom.IsDetail = False
        Me.DSTivpreciom.KeyFields = Nothing
        Me.DSTivpreciom.LineColName = Nothing
        Me.DSTivpreciom.MasterDetailRelation = Nothing
        Me.DSTivpreciom.MasterTableName = Nothing
        Me.DSTivpreciom.SerialColumnName = "precio_code"
        Me.DSTivpreciom.Sort = Nothing
        Me.DSTivpreciom.Source = Nothing
        Me.DSTivpreciom.TableName = "ivpreciom"
        Me.DSTivpreciom.UpdateOrder = 0
        Me.DSTivpreciom.UseRowRetrieve = False
        '
        'DTSivpreciod
        '
        Me.DTSivpreciod.AllowDelete = True
        Me.DTSivpreciod.AllowEdit = True
        Me.DTSivpreciod.AllowNew = True
        Me.DTSivpreciod.AutoIncrementSerial = False
        Me.DTSivpreciod.CustomDbUpdate = False
        Me.DTSivpreciod.DeleteOrder = 0
        Me.DTSivpreciod.FillOnQuery = True
        Me.DTSivpreciod.FillOnRowChange = True
        Me.DTSivpreciod.HeaderIsOnGrid = False
        Me.DTSivpreciod.InnerJon = True
        Me.DTSivpreciod.InsertOrder = 0
        Me.DTSivpreciod.IsDetail = True
        Me.DTSivpreciod.KeyFields = Nothing
        Me.DTSivpreciod.LineColName = "line_no"
        Me.DTSivpreciod.MasterDetailRelation = New String() {"precio_code=precio_code"}
        Me.DTSivpreciod.MasterTableName = Nothing
        Me.DTSivpreciod.SerialColumnName = Nothing
        Me.DTSivpreciod.Sort = Nothing
        Me.DTSivpreciod.Source = New String() {"select ivpreciod.*,ivitemm.item_name ", "from ivpreciod inner join ivitemm", "on ivpreciod.item_code = ivitemm.item_code", "order by ivitemm.item_name "}
        Me.DTSivpreciod.TableName = "ivpreciod"
        Me.DTSivpreciod.UpdateOrder = 0
        Me.DTSivpreciod.UseRowRetrieve = False
        '
        'txtwhse_code
        '
        Me.txtwhse_code.AcceptsReturn = True
        Me.txtwhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivpreciom.whse_code"))
        Me.txtwhse_code.EditInitialValue = Nothing
        Me.txtwhse_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.FieldDescription = ""
        Me.txtwhse_code.FindInitialValue = Nothing
        Me.txtwhse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.IgnoreRequiered = False
        Me.txtwhse_code.Location = New System.Drawing.Point(112, 16)
        Me.txtwhse_code.Name = "txtwhse_code"
        Me.txtwhse_code.NewInitialValue = Nothing
        Me.txtwhse_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.Requiered = False
        Me.txtwhse_code.Size = New System.Drawing.Size(48, 20)
        Me.txtwhse_code.StatusBarPanelDescripcion = Nothing
        Me.txtwhse_code.TabIndex = 0
        Me.txtwhse_code.Text = ""
        '
        'lkItem_code
        '
        Me.lkItem_code.AlternateFieldSearch = Nothing
        Me.lkItem_code.BeginCheck = False
        Me.lkItem_code.CheckText = Nothing
        Me.lkItem_code.ComboMode = False
        Me.lkItem_code.DataMember = ""
        Me.lkItem_code.DataSource = Me.LibXConnector1
        Me.lkItem_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "costo=purch_cost", "precio=price", "benef=benef", "unidad=purch_unit"}
        Me.lkItem_code.FilterField = "item_name"
        Me.lkItem_code.IgnoreFindInBrowseMode = True
        Me.lkItem_code.isCanceled = False
        Me.lkItem_code.Location = New System.Drawing.Point(608, 80)
        Me.lkItem_code.LookCaption = "Productos"
        Me.lkItem_code.Name = "lkItem_code"
        Me.lkItem_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkItem_code.ShowFilter = True
        Me.lkItem_code.ShowMessageNotFound = True
        Me.lkItem_code.ShowWarning = False
        Me.lkItem_code.Size = New System.Drawing.Size(16, 20)
        Me.lkItem_code.SizesColumns = New String() {"item_name=450"}
        Me.lkItem_code.SizesColumnsTab = Nothing
        Me.lkItem_code.SqlString = New String() {"select ivitemm.item_code,item_name, existencia,", " ivitemd.price,purch_unit,benef,ivitemm.group_code,  ", " (purch_cost * ivunitd.factor) purch_cost, (price * factor) price", "from ivitemm ", "inner join ivitemd  ", " on ivitemm.item_code = ivitemd.item_code  ", "inner join ivunitd", "on ivunitd.item_code = ivitemd.item_code", "and ivitemm.purch_unit = ivunitd.unit_code"}
        Me.lkItem_code.SQLTab = Nothing
        Me.lkItem_code.SrcParameters = New String() {"item_code=item_code"}
        Me.lkItem_code.TabIndex = 6
        Me.lkItem_code.TableName = "ivitemv"
        Me.lkItem_code.TabStop = False
        Me.lkItem_code.UseCopyConnection = False
        Me.lkItem_code.UseRowRetrieveEvents = False
        Me.lkItem_code.UseTab = False
        Me.lkItem_code.VisParameters = New String() {"Nombre=item_name", "Costo=purch_cost", "Unidad=purch_unit", "Existencia=existencia", "Código=item_code"}
        Me.lkItem_code.WhereCondition = Nothing
        Me.lkItem_code.WhereParameters = Nothing
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(60, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Fecha:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ivpreciom.fecha"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.FieldDescription = ""
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = True
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(112, 88)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = "now"
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Requiered = False
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(120, 20)
        Me.LibxDateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker1.TabIndex = 3
        '
        'LibXGridDetalle
        '
        Me.LibXGridDetalle.AllowSorting = False
        Me.LibXGridDetalle.AutoAdjustLastColumn = True
        Me.LibXGridDetalle.AutoSearch = False
        Me.LibXGridDetalle.BackgroundColor = System.Drawing.Color.White
        Me.LibXGridDetalle.CaptionText = "Articulos"
        Me.LibXGridDetalle.DataMember = "ivpreciod"
        Me.LibXGridDetalle.DataSource = Me.DataSet1
        Me.LibXGridDetalle.FullRowSelect = False
        Me.LibXGridDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGridDetalle.IsReadOnly = False
        Me.LibXGridDetalle.Location = New System.Drawing.Point(8, 152)
        Me.LibXGridDetalle.Name = "LibXGridDetalle"
        Me.LibXGridDetalle.ReadOnly = True
        Me.LibXGridDetalle.RowHeaderWidth = 30
        Me.LibXGridDetalle.searchText = ""
        Me.LibXGridDetalle.showFooterBar = True
        Me.LibXGridDetalle.Size = New System.Drawing.Size(832, 352)
        Me.LibXGridDetalle.TabIndex = 2
        Me.LibXGridDetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGridDetalle.UseAutoFillLines = True
        Me.LibXGridDetalle.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGridDetalle
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColITem_code, Me.gColitem_name, Me.gColCosto, Me.gColBeneficio, Me.gColPrecio, Me.gColUnid, Me.gColCambio})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivpreciod"
        Me.XdataGridTableStyle1.RowHeaderWidth = 30
        '
        'gColITem_code
        '
        Me.gColITem_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColITem_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColITem_code.executeFindDuringFill = False
        Me.gColITem_code.Format = ""
        Me.gColITem_code.FormatInfo = Nothing
        Me.gColITem_code.HeaderText = "Producto"
        Me.gColITem_code.isReadOnly = False
        Me.gColITem_code.Lookup = Me.lkItem_code
        Me.gColITem_code.MappingName = "item_code"
        Me.gColITem_code.MaxLength = 32767
        Me.gColITem_code.TabStop = True
        Me.gColITem_code.UseCustomCellFormat = False
        Me.gColITem_code.Width = 125
        '
        'gColitem_name
        '
        Me.gColitem_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColitem_name.Format = ""
        Me.gColitem_name.FormatInfo = Nothing
        Me.gColitem_name.HeaderText = "Descripción"
        Me.gColitem_name.ImageList = Nothing
        Me.gColitem_name.isReadOnly = True
        Me.gColitem_name.MappingName = "Item_name"
        Me.gColitem_name.MaxLength = 32767
        Me.gColitem_name.ReadOnly = True
        Me.gColitem_name.TabStop = True
        Me.gColitem_name.UseCustomCellFormat = False
        Me.gColitem_name.Width = 290
        '
        'gColCosto
        '
        Me.gColCosto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColCosto.Format = "#,###,##0.00"
        Me.gColCosto.FormatInfo = Nothing
        Me.gColCosto.HeaderText = "Costoi"
        Me.gColCosto.ImageList = Nothing
        Me.gColCosto.isReadOnly = True
        Me.gColCosto.MappingName = "costo"
        Me.gColCosto.MaxLength = 32767
        Me.gColCosto.ReadOnly = True
        Me.gColCosto.TabStop = True
        Me.gColCosto.UseCustomCellFormat = False
        Me.gColCosto.Width = 75
        '
        'gColBeneficio
        '
        Me.gColBeneficio.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColBeneficio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColBeneficio.Format = "#,##0.00"
        Me.gColBeneficio.FormatInfo = Nothing
        Me.gColBeneficio.HeaderText = "Beneficioi"
        Me.gColBeneficio.ImageList = Nothing
        Me.gColBeneficio.isReadOnly = True
        Me.gColBeneficio.MappingName = "benef"
        Me.gColBeneficio.MaxLength = 32767
        Me.gColBeneficio.ReadOnly = True
        Me.gColBeneficio.TabStop = True
        Me.gColBeneficio.UseCustomCellFormat = False
        Me.gColBeneficio.Width = 80
        '
        'gColPrecio
        '
        Me.gColPrecio.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColPrecio.Format = "#,###,##0.00"
        Me.gColPrecio.FormatInfo = Nothing
        Me.gColPrecio.HeaderText = "Precioi"
        Me.gColPrecio.ImageList = Nothing
        Me.gColPrecio.isReadOnly = True
        Me.gColPrecio.MappingName = "precio"
        Me.gColPrecio.MaxLength = 32767
        Me.gColPrecio.ReadOnly = True
        Me.gColPrecio.TabStop = True
        Me.gColPrecio.UseCustomCellFormat = False
        Me.gColPrecio.Width = 75
        '
        'gColUnid
        '
        Me.gColUnid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.gColUnid.Format = "Unidad"
        Me.gColUnid.FormatInfo = Nothing
        Me.gColUnid.HeaderText = "Unidad"
        Me.gColUnid.ImageList = Nothing
        Me.gColUnid.isReadOnly = True
        Me.gColUnid.MappingName = "unidad"
        Me.gColUnid.MaxLength = 32767
        Me.gColUnid.ReadOnly = True
        Me.gColUnid.TabStop = True
        Me.gColUnid.UseCustomCellFormat = False
        Me.gColUnid.Width = 101
        '
        'gColCambio
        '
        Me.gColCambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColCambio.Format = "##0.00"
        Me.gColCambio.FormatInfo = Nothing
        Me.gColCambio.HeaderText = "% Cambio"
        Me.gColCambio.ImageList = Nothing
        Me.gColCambio.isReadOnly = True
        Me.gColCambio.MappingName = "cambio"
        Me.gColCambio.MaxLength = 32767
        Me.gColCambio.ReadOnly = True
        Me.gColCambio.TabStop = True
        Me.gColCambio.UseCustomCellFormat = False
        Me.gColCambio.Width = 60
        '
        'xlk_Almacen
        '
        Me.xlk_Almacen.AlternateFieldSearch = Nothing
        Me.xlk_Almacen.BeginCheck = False
        Me.xlk_Almacen.CheckText = Nothing
        Me.xlk_Almacen.ComboMode = False
        Me.xlk_Almacen.DataMember = Nothing
        Me.xlk_Almacen.DataSource = Me.LibXConnector1
        Me.xlk_Almacen.DestParameters = New String() {"txtwhse_code=whse_code", "txtwhse_name=whse_name"}
        Me.xlk_Almacen.FilterField = Nothing
        Me.xlk_Almacen.IgnoreFindInBrowseMode = False
        Me.xlk_Almacen.isCanceled = False
        Me.xlk_Almacen.Location = New System.Drawing.Point(488, 16)
        Me.xlk_Almacen.LookCaption = "Almacenes"
        Me.xlk_Almacen.Name = "xlk_Almacen"
        Me.xlk_Almacen.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_Almacen.ShowFilter = True
        Me.xlk_Almacen.ShowMessageNotFound = True
        Me.xlk_Almacen.ShowWarning = False
        Me.xlk_Almacen.Size = New System.Drawing.Size(16, 20)
        Me.xlk_Almacen.SizesColumns = Nothing
        Me.xlk_Almacen.SizesColumnsTab = Nothing
        Me.xlk_Almacen.SqlString = Nothing
        Me.xlk_Almacen.SQLTab = Nothing
        Me.xlk_Almacen.SrcParameters = New String() {"whse_code=whse_code"}
        Me.xlk_Almacen.TabIndex = 2
        Me.xlk_Almacen.TableName = "ivwhsem"
        Me.xlk_Almacen.TabStop = False
        Me.xlk_Almacen.UseCopyConnection = False
        Me.xlk_Almacen.UseRowRetrieveEvents = False
        Me.xlk_Almacen.UseTab = False
        Me.xlk_Almacen.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.xlk_Almacen.WhereCondition = Nothing
        Me.xlk_Almacen.WhereParameters = Nothing
        '
        'txtwhse_name
        '
        Me.txtwhse_name.AcceptsReturn = True
        Me.txtwhse_name.EditInitialValue = Nothing
        Me.txtwhse_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_name.FieldDescription = ""
        Me.txtwhse_name.FindInitialValue = Nothing
        Me.txtwhse_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_name.IgnoreRequiered = False
        Me.txtwhse_name.Location = New System.Drawing.Point(168, 16)
        Me.txtwhse_name.Name = "txtwhse_name"
        Me.txtwhse_name.NewInitialValue = Nothing
        Me.txtwhse_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_name.ReadOnly = True
        Me.txtwhse_name.Requiered = False
        Me.txtwhse_name.Size = New System.Drawing.Size(320, 20)
        Me.txtwhse_name.StatusBarPanelDescripcion = Nothing
        Me.txtwhse_name.TabIndex = 27
        Me.txtwhse_name.Text = ""
        '
        'grp_Header
        '
        Me.grp_Header.Controls.Add(Me.btnLoadItems)
        Me.grp_Header.Controls.Add(Me.Label2)
        Me.grp_Header.Controls.Add(Me.xlk_group_code)
        Me.grp_Header.Controls.Add(Me.xtxt_group_code)
        Me.grp_Header.Controls.Add(Me.xtxt_group_name)
        Me.grp_Header.Controls.Add(Me.xcbo_estatus)
        Me.grp_Header.Controls.Add(Me.Label1)
        Me.grp_Header.Controls.Add(Me.Label10)
        Me.grp_Header.Controls.Add(Me.txtBenef)
        Me.grp_Header.Controls.Add(Me.chkCalBenef)
        Me.grp_Header.Controls.Add(Me.chkGenEtiqueta)
        Me.grp_Header.Controls.Add(Me.chkEdPrecio)
        Me.grp_Header.Controls.Add(Me.chkEdCosto)
        Me.grp_Header.Controls.Add(Me.Label6)
        Me.grp_Header.Controls.Add(Me.xlk_Suplidor)
        Me.grp_Header.Controls.Add(Me.txtprov_code)
        Me.grp_Header.Controls.Add(Me.txtprov_name)
        Me.grp_Header.Controls.Add(Me.Label8)
        Me.grp_Header.Controls.Add(Me.LibxDateTimePicker1)
        Me.grp_Header.Controls.Add(Me.xlk_Almacen)
        Me.grp_Header.Controls.Add(Me.txtwhse_code)
        Me.grp_Header.Controls.Add(Me.txtwhse_name)
        Me.grp_Header.Controls.Add(Me.Label4)
        Me.grp_Header.Location = New System.Drawing.Point(8, 32)
        Me.grp_Header.Name = "grp_Header"
        Me.grp_Header.Size = New System.Drawing.Size(832, 120)
        Me.grp_Header.TabIndex = 1
        Me.grp_Header.TabStop = False
        '
        'btnLoadItems
        '
        Me.btnLoadItems.Enabled = False
        Me.btnLoadItems.Location = New System.Drawing.Point(480, 64)
        Me.btnLoadItems.Name = "btnLoadItems"
        Me.btnLoadItems.Size = New System.Drawing.Size(24, 20)
        Me.btnLoadItems.TabIndex = 48
        Me.btnLoadItems.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnLoadItems, "Taer la lista de productos de este suplidor")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(60, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Grupo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_group_code
        '
        Me.xlk_group_code.AlternateFieldSearch = Nothing
        Me.xlk_group_code.BeginCheck = False
        Me.xlk_group_code.CheckText = Nothing
        Me.xlk_group_code.ComboMode = False
        Me.xlk_group_code.DataMember = Nothing
        Me.xlk_group_code.DataSource = Me.LibXConnector1
        Me.xlk_group_code.DestParameters = New String() {"group_code=group_code", "xtxt_group_name=group_name"}
        Me.xlk_group_code.FilterField = Nothing
        Me.xlk_group_code.IgnoreFindInBrowseMode = False
        Me.xlk_group_code.isCanceled = False
        Me.xlk_group_code.Location = New System.Drawing.Point(488, 40)
        Me.xlk_group_code.LookCaption = "Grupo"
        Me.xlk_group_code.Name = "xlk_group_code"
        Me.xlk_group_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_group_code.ShowFilter = True
        Me.xlk_group_code.ShowMessageNotFound = True
        Me.xlk_group_code.ShowWarning = False
        Me.xlk_group_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_group_code.SizesColumns = Nothing
        Me.xlk_group_code.SizesColumnsTab = Nothing
        Me.xlk_group_code.SqlString = Nothing
        Me.xlk_group_code.SQLTab = Nothing
        Me.xlk_group_code.SrcParameters = New String() {"group_code=group_code"}
        Me.xlk_group_code.TabIndex = 45
        Me.xlk_group_code.TableName = "ivgroupm"
        Me.xlk_group_code.TabStop = False
        Me.xlk_group_code.UseCopyConnection = False
        Me.xlk_group_code.UseRowRetrieveEvents = False
        Me.xlk_group_code.UseTab = False
        Me.xlk_group_code.VisParameters = New String() {"Código=group_code", "Descripción=group_name"}
        Me.xlk_group_code.WhereCondition = Nothing
        Me.xlk_group_code.WhereParameters = Nothing
        '
        'xtxt_group_code
        '
        Me.xtxt_group_code.AcceptsReturn = True
        Me.xtxt_group_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivpreciom.group_code"))
        Me.xtxt_group_code.EditInitialValue = Nothing
        Me.xtxt_group_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_group_code.FieldDescription = ""
        Me.xtxt_group_code.FindInitialValue = Nothing
        Me.xtxt_group_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_group_code.IgnoreRequiered = False
        Me.xtxt_group_code.Location = New System.Drawing.Point(112, 40)
        Me.xtxt_group_code.Name = "xtxt_group_code"
        Me.xtxt_group_code.NewInitialValue = Nothing
        Me.xtxt_group_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_group_code.Requiered = False
        Me.xtxt_group_code.Size = New System.Drawing.Size(48, 20)
        Me.xtxt_group_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_group_code.TabIndex = 1
        Me.xtxt_group_code.Text = ""
        '
        'xtxt_group_name
        '
        Me.xtxt_group_name.AcceptsReturn = True
        Me.xtxt_group_name.EditInitialValue = Nothing
        Me.xtxt_group_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_group_name.FieldDescription = ""
        Me.xtxt_group_name.FindInitialValue = Nothing
        Me.xtxt_group_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_group_name.IgnoreRequiered = False
        Me.xtxt_group_name.Location = New System.Drawing.Point(168, 40)
        Me.xtxt_group_name.Name = "xtxt_group_name"
        Me.xtxt_group_name.NewInitialValue = Nothing
        Me.xtxt_group_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_group_name.ReadOnly = True
        Me.xtxt_group_name.Requiered = False
        Me.xtxt_group_name.Size = New System.Drawing.Size(320, 20)
        Me.xtxt_group_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_group_name.TabIndex = 47
        Me.xtxt_group_name.Text = ""
        '
        'xcbo_estatus
        '
        Me.xcbo_estatus.AllowDefaultSort = True
        Me.xcbo_estatus.bound = True
        Me.xcbo_estatus.currValue = Nothing
        Me.xcbo_estatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ivpreciom.estatus"))
        Me.xcbo_estatus.DefaultWhereString = Nothing
        Me.xcbo_estatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_estatus.EditInitialValue = Nothing
        Me.xcbo_estatus.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_estatus.FieldDescription = ""
        Me.xcbo_estatus.FindInitialValue = "1"
        Me.xcbo_estatus.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_estatus.IgnoreRequiered = False
        Me.xcbo_estatus.Items.AddRange(New Object() {"1-Pendiente Aplicar", "2-Aplicado"})
        Me.xcbo_estatus.Location = New System.Drawing.Point(384, 88)
        Me.xcbo_estatus.LookupKeyDisplayFields = Nothing
        Me.xcbo_estatus.LookupKeyField = Nothing
        Me.xcbo_estatus.LookupTableName = Nothing
        Me.xcbo_estatus.Name = "xcbo_estatus"
        Me.xcbo_estatus.NewInitialValue = "1"
        Me.xcbo_estatus.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_estatus.Requiered = False
        Me.xcbo_estatus.Required = False
        Me.xcbo_estatus.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_estatus.SqlString = Nothing
        Me.xcbo_estatus.StatusBarPanelDescripcion = Nothing
        Me.xcbo_estatus.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(328, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Estatus:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(688, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 16)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "% Beneficio:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtBenef
        '
        Me.txtBenef.AcceptsReturn = True
        Me.txtBenef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivpreciom.beneficio"))
        Me.txtBenef.EditInitialValue = Nothing
        Me.txtBenef.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtBenef.Enabled = False
        Me.txtBenef.FieldDescription = ""
        Me.txtBenef.FindInitialValue = Nothing
        Me.txtBenef.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtBenef.IgnoreRequiered = False
        Me.txtBenef.Location = New System.Drawing.Point(760, 56)
        Me.txtBenef.Masked = MaskedTextBox.Mask.Decimal
        Me.txtBenef.Name = "txtBenef"
        Me.txtBenef.NewInitialValue = Nothing
        Me.txtBenef.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtBenef.Requiered = False
        Me.txtBenef.Size = New System.Drawing.Size(48, 20)
        Me.txtBenef.StatusBarPanelDescripcion = Nothing
        Me.txtBenef.TabIndex = 8
        Me.txtBenef.Text = ""
        '
        'chkCalBenef
        '
        Me.chkCalBenef.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCalBenef.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivpreciom.editar_benef"))
        Me.chkCalBenef.EditInitialValue = Nothing
        Me.chkCalBenef.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chkCalBenef.FindInitialValue = Nothing
        Me.chkCalBenef.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chkCalBenef.IgnoreRequiered = False
        Me.chkCalBenef.KeepEnabled = False
        Me.chkCalBenef.Location = New System.Drawing.Point(552, 56)
        Me.chkCalBenef.Name = "chkCalBenef"
        Me.chkCalBenef.NewInitialValue = Nothing
        Me.chkCalBenef.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chkCalBenef.ReadOnly = False
        Me.chkCalBenef.Requiered = False
        Me.chkCalBenef.Size = New System.Drawing.Size(136, 16)
        Me.chkCalBenef.TabIndex = 7
        Me.chkCalBenef.Text = "Calcular Por Beneficio"
        Me.chkCalBenef.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.chkCalBenef.ThreeState = True
        Me.chkCalBenef.value = Nothing
        '
        'chkGenEtiqueta
        '
        Me.chkGenEtiqueta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkGenEtiqueta.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivpreciom.generar_etiqueta"))
        Me.chkGenEtiqueta.EditInitialValue = Nothing
        Me.chkGenEtiqueta.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chkGenEtiqueta.FindInitialValue = Nothing
        Me.chkGenEtiqueta.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chkGenEtiqueta.IgnoreRequiered = False
        Me.chkGenEtiqueta.KeepEnabled = False
        Me.chkGenEtiqueta.Location = New System.Drawing.Point(552, 72)
        Me.chkGenEtiqueta.Name = "chkGenEtiqueta"
        Me.chkGenEtiqueta.NewInitialValue = Nothing
        Me.chkGenEtiqueta.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chkGenEtiqueta.ReadOnly = False
        Me.chkGenEtiqueta.Requiered = False
        Me.chkGenEtiqueta.Size = New System.Drawing.Size(136, 16)
        Me.chkGenEtiqueta.TabIndex = 9
        Me.chkGenEtiqueta.Text = "Generar Etiqueta"
        Me.chkGenEtiqueta.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.chkGenEtiqueta.ThreeState = True
        Me.chkGenEtiqueta.value = Nothing
        '
        'chkEdPrecio
        '
        Me.chkEdPrecio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEdPrecio.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivpreciom.editar_precio"))
        Me.chkEdPrecio.EditInitialValue = Nothing
        Me.chkEdPrecio.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chkEdPrecio.FindInitialValue = Nothing
        Me.chkEdPrecio.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chkEdPrecio.IgnoreRequiered = False
        Me.chkEdPrecio.KeepEnabled = False
        Me.chkEdPrecio.Location = New System.Drawing.Point(552, 40)
        Me.chkEdPrecio.Name = "chkEdPrecio"
        Me.chkEdPrecio.NewInitialValue = Nothing
        Me.chkEdPrecio.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chkEdPrecio.ReadOnly = False
        Me.chkEdPrecio.Requiered = False
        Me.chkEdPrecio.Size = New System.Drawing.Size(136, 16)
        Me.chkEdPrecio.TabIndex = 6
        Me.chkEdPrecio.Text = "Editar Precio"
        Me.chkEdPrecio.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.chkEdPrecio.ThreeState = True
        Me.chkEdPrecio.value = Nothing
        '
        'chkEdCosto
        '
        Me.chkEdCosto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEdCosto.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivpreciom.editar_costo"))
        Me.chkEdCosto.EditInitialValue = Nothing
        Me.chkEdCosto.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chkEdCosto.FindInitialValue = Nothing
        Me.chkEdCosto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chkEdCosto.IgnoreRequiered = False
        Me.chkEdCosto.KeepEnabled = False
        Me.chkEdCosto.Location = New System.Drawing.Point(552, 24)
        Me.chkEdCosto.Name = "chkEdCosto"
        Me.chkEdCosto.NewInitialValue = Nothing
        Me.chkEdCosto.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chkEdCosto.ReadOnly = False
        Me.chkEdCosto.Requiered = False
        Me.chkEdCosto.Size = New System.Drawing.Size(136, 16)
        Me.chkEdCosto.TabIndex = 5
        Me.chkEdCosto.Text = "Editar Costo"
        Me.chkEdCosto.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.chkEdCosto.ThreeState = True
        Me.chkEdCosto.value = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(50, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Suplidor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_Suplidor
        '
        Me.xlk_Suplidor.AlternateFieldSearch = Nothing
        Me.xlk_Suplidor.BeginCheck = False
        Me.xlk_Suplidor.CheckText = Nothing
        Me.xlk_Suplidor.ComboMode = False
        Me.xlk_Suplidor.DataMember = Nothing
        Me.xlk_Suplidor.DataSource = Me.LibXConnector1
        Me.xlk_Suplidor.DestParameters = New String() {"txtprov_code=prov_code", "txtprov_name=prov_name"}
        Me.xlk_Suplidor.FilterField = Nothing
        Me.xlk_Suplidor.IgnoreFindInBrowseMode = False
        Me.xlk_Suplidor.isCanceled = False
        Me.xlk_Suplidor.Location = New System.Drawing.Point(464, 64)
        Me.xlk_Suplidor.LookCaption = "Suplidor"
        Me.xlk_Suplidor.Name = "xlk_Suplidor"
        Me.xlk_Suplidor.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_Suplidor.ShowFilter = True
        Me.xlk_Suplidor.ShowMessageNotFound = True
        Me.xlk_Suplidor.ShowWarning = False
        Me.xlk_Suplidor.Size = New System.Drawing.Size(16, 20)
        Me.xlk_Suplidor.SizesColumns = Nothing
        Me.xlk_Suplidor.SizesColumnsTab = Nothing
        Me.xlk_Suplidor.SqlString = Nothing
        Me.xlk_Suplidor.SQLTab = Nothing
        Me.xlk_Suplidor.SrcParameters = New String() {"prov_code=prov_code"}
        Me.xlk_Suplidor.TabIndex = 29
        Me.xlk_Suplidor.TableName = "cpprovm"
        Me.xlk_Suplidor.TabStop = False
        Me.xlk_Suplidor.UseCopyConnection = False
        Me.xlk_Suplidor.UseRowRetrieveEvents = False
        Me.xlk_Suplidor.UseTab = False
        Me.xlk_Suplidor.VisParameters = New String() {"Código=prov_code", "Descripción=prov_name"}
        Me.xlk_Suplidor.WhereCondition = Nothing
        Me.xlk_Suplidor.WhereParameters = Nothing
        '
        'txtprov_code
        '
        Me.txtprov_code.AcceptsReturn = True
        Me.txtprov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivpreciom.prov_code"))
        Me.txtprov_code.EditInitialValue = Nothing
        Me.txtprov_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.FieldDescription = ""
        Me.txtprov_code.FindInitialValue = Nothing
        Me.txtprov_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.IgnoreRequiered = False
        Me.txtprov_code.Location = New System.Drawing.Point(112, 64)
        Me.txtprov_code.Name = "txtprov_code"
        Me.txtprov_code.NewInitialValue = Nothing
        Me.txtprov_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.Requiered = False
        Me.txtprov_code.Size = New System.Drawing.Size(48, 20)
        Me.txtprov_code.StatusBarPanelDescripcion = Nothing
        Me.txtprov_code.TabIndex = 2
        Me.txtprov_code.Text = ""
        '
        'txtprov_name
        '
        Me.txtprov_name.AcceptsReturn = True
        Me.txtprov_name.EditInitialValue = Nothing
        Me.txtprov_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_name.FieldDescription = ""
        Me.txtprov_name.FindInitialValue = Nothing
        Me.txtprov_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_name.IgnoreRequiered = False
        Me.txtprov_name.Location = New System.Drawing.Point(168, 64)
        Me.txtprov_name.Name = "txtprov_name"
        Me.txtprov_name.NewInitialValue = Nothing
        Me.txtprov_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_name.ReadOnly = True
        Me.txtprov_name.Requiered = False
        Me.txtprov_name.Size = New System.Drawing.Size(296, 20)
        Me.txtprov_name.StatusBarPanelDescripcion = Nothing
        Me.txtprov_name.TabIndex = 31
        Me.txtprov_name.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(48, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Almacén:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnActualizar
        '
        Me.btnActualizar.Enabled = False
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnActualizar.Location = New System.Drawing.Point(8, 552)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.TabIndex = 3
        Me.btnActualizar.Text = "Actualizar"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "precio_old"
        Me.DataColumn21.DataType = GetType(System.Decimal)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "costo_old"
        Me.DataColumn22.DataType = GetType(System.Decimal)
        '
        'i_ivpreciom01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(850, 624)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.grp_Header)
        Me.Controls.Add(Me.LibXGridDetalle)
        Me.Controls.Add(Me.lkItem_code)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivpreciom01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Actualiza lista de precios por Proveedor"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivpreciom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivpreciod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Header.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ActualizaProductos()

        Dim i As Integer
        Dim oValue As Object
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim oUnidad As UnidadMedida
        Dim oParamUnd As UnidadMedida.ParametroConvertirValor

        Try

            oUnidad = New UnidadMedida
            oParamUnd = New UnidadMedida.ParametroConvertirValor

            For Each oRow As DataRow In ivpreciod.Rows

                '// Calcular los precios y costos porunidad
                CalcularRubros(oRow)

                '//actualiza productos  en el maestro de productos
                XUpdate = New LibX.Data.XUpdateStmt("ivitemd")

                XUpdate.FieldsSet("purch_cost") = oRow!costo
                XUpdate.FieldsSet("price") = oRow!precio
                XUpdate.FieldsSet("benef") = oRow!benef

                XUpdate.Fields("whse_code") = LibXConnector1.CurrentDataRow!whse_code
                XUpdate.Fields("item_code") = oRow!item_code

                XUpdate.Execute()

            Next
            btnActualizar.Enabled = False

        Catch ex As Exception
            Log.Add(ex, True)

        End Try
    End Sub

    Private Sub ActualizaEtiquetas()
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim oNewTAble As DataTable
        Try

            ''inserta los productos en la tabla de etiquetas
            SelectStmt = " SELECT 0 etiq_no, whse_code almacen, " & _
                         " ivitemm.item_code , " & _
                         " ivitemd.purch_cost costo,  " & _
                         " ivitemd.price precio," & _
                         " isnull((SELECT top 1 ivitemd.price * FACTOR FROM IVUNITD WHERE ITEM_CODE=ivitemm.ITEM_CODE AND UNIT_TYPE=2),NULL) AS precio2," & _
                         " ivitemm.item_name as descripcion,  " & _
                         " ivitemm.abreviada as abreviada,   " & _
                         " '0' as fact_no," & _
                         " null as fecha_factura," & _
                         " ivitemm.prov_code,	" & _
                         " (case when asumir_emp=1 then ivitemd.existencia else 1 end ) AS Cantidad," & _
                         " isnull((SELECT top 1 unit_code FROM IVUNITD WHERE ITEM_CODE=ivitemm.ITEM_CODE AND UNIT_TYPE=2),(SELECT top 1 unit_code FROM IVUNITD WHERE ITEM_CODE=ivitemm.ITEM_CODE AND UNIT_TYPE=3)) as unidad_compra," & _
                         " isnull((SELECT top 1 unit_code FROM IVUNITD WHERE ITEM_CODE=ivitemm.ITEM_CODE AND UNIT_TYPE=3),(SELECT top 1 unit_code FROM IVUNITD WHERE ITEM_CODE=ivitemm.ITEM_CODE AND UNIT_TYPE=2)) as unidad_venta ," & _
                         " ivitemd.existencia," & _
                         " ivitemm.group_code as grupo," & _
                         " ivitemm.sgroup_code as subgrp," & _
                         " ivitemm.item_status as estado," & _
                         " ivitemm.brand_code as marca," & _
                         " getdate() as fecha" & _
                         "  FROM ivitemm INNER JOIN ivitemd  " & _
                         " ON ivitemm.item_code = ivitemd.item_code   " & _
                         " where ivitemm.prov_code ='" & Me.txtprov_code.Text.ToString & "' " & _
                         " and ivitemd.whse_code=" & Me.txtwhse_code.Text.ToString & _
                         " and ivitemm.imprimir_etiq = 1 "

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt, "ivetiqm", True)

            If oTable.Rows.Count > 0 Then
                oNewTAble = LibX.Data.Manager.GetNewDataTable("ivetiqm", True)
                For Each oRow As DataRow In oTable.Rows
                    Dim oNewRow As DataRow = oNewTAble.NewRow

                    oNewRow.ItemArray = oRow.ItemArray
                    oNewTAble.Rows.Add(oNewRow)
                Next

                LibX.Data.Manager.Save(oNewTAble)
            End If

        Catch ex As Exception
            Log.Add(ex, True)

        End Try
    End Sub
    Private Sub ActualizaGrid()

        Dim i As Integer
        Dim oValue As Object

        Try

            For i = 0 To Me.LibXGridDetalle.getCurrentGridView.Count - 1
                precio = 0
                costo = 0
                benef = 0
                cambio = 0

                oValue = Me.LibXGridDetalle.GetValue(i, Me.gColCosto)
                If Not IsNull(oValue) Then
                    costo = oValue
                End If

                oValue = Me.LibXGridDetalle.GetValue(i, Me.gColPrecio)
                If Not IsNull(oValue) Then
                    precio = oValue
                End If

                If Me.txtBenef.Text.Length > 0 Then
                    oValue = Me.txtBenef.Text
                Else
                    oValue = Me.LibXGridDetalle.GetValue(i, Me.gColBeneficio)
                End If

                If Not IsNull(oValue) Then
                    benef = oValue
                End If

                Call Calculos(precio, costo, benef, Me.LibXGridDetalle.GetValue(i, Me.gColITem_code), Me.LibXGridDetalle.GetValue(i, Me.gColUnid))

                If Resultado.benef > 0 Then
                    LibXGridDetalle.SetValue(i, Me.gColBeneficio, Resultado.benef)
                End If

                If Resultado.precio > 0 Then
                    LibXGridDetalle.SetValue(i, Me.gColPrecio, Resultado.precio)
                End If

            Next

        Catch ex As Exception
            Log.Add(ex, True)

        End Try
    End Sub

    Private Function Calculos(ByVal pPrecio As Decimal, ByVal pCosto As Decimal, ByVal pBenef As Decimal, ByVal pitem_code As String, ByVal punit_code As String)
        ''crear una estructura que devuelva el precio y el beneficio
        precio = pPrecio
        costo = pCosto
        benef = pBenef
        cambio = 0

        Try
            Dim oProducto As New SGT.Inventario.Entidades.Articulo
            Dim oParam As New SGT.Inventario.Entidades.Articulo.ParametrosCostosLocales

            '//calculo marcado beneficio
            If Me.chkCalBenef.CheckState = 1 Then
                benef = Me.txtBenef.Text.ToString
                precio = costo * (1 + (benef / 100))
                cambio = ((costo - ProductoCosto(pitem_code)) / costo) * 100
            End If

            '//calculo marcado costo 
            If Me.chkEdCosto.CheckState = 1 And Me.chkEdPrecio.CheckState <> 1 Then
                precio = costo * (1 + (benef / 100))
                cambio = ((costo - ProductoCosto(pitem_code)) / costo) * 100
            End If

            '//calculo marcado costo y precio
            If Me.chkEdCosto.CheckState = 1 Or Me.chkEdPrecio.CheckState = 1 Then
                oParam.Precio = precio
                benef = ((precio - costo) / costo) * 100
                cambio = ((costo - ProductoCosto(pitem_code)) / costo) * 100
            End If

            With oParam
                .Almacen = Me.txtwhse_code.Text
                .Beneficio = benef
                .Costo = costo
                .Cantidad = 1
                .Descuento = 0
                .Importe = costo
                .IncluirDescuento = False
                .incluirISC = False
                '.IncluirITBIS = False
                .incluirOFERTA = False
                .ISC = 0
                '.Itbis = 0
                .Ofertas = 0
                .Producto = pitem_code 'LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, Me.gColITem_code)
                .TotalFactura = costo
                '.TotalITBIS = 0
                .UnidadCompra = punit_code 'LibXGridDetalle.GetValue(LibXGridDetalle.CurrentRowIndex, Me.gColUnid)
            End With

            oProducto.CalcularCostoLocal(oParam)

            Resultado.precio = Format(oParam.ValoresRetorno.Precio, "#,###,##0.00")
            Resultado.benef = Format(oParam.ValoresRetorno.Beneficio, "#,###,##0.00")
            Resultado.cambio = Format(((costo - ProductoCosto(pitem_code)) / costo) * 100, "#,###,##0.00")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Function

    Private Sub ProductosRequerido(ByVal pprov_code As String, ByVal pwhse_code As String)

        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim lineno As Integer
        Dim Factor As Decimal
        Dim oUnidad As SGT.Inventario.Entidades.UnidadMedida

        Try
            If pprov_code = "" Then
                Throw New ApplicationException("seleccione el proveedor!")
            End If

            If pwhse_code = "" Then
                Throw New ApplicationException("seleccione el almacen!")
            End If

            oUnidad = New SGT.Inventario.Entidades.UnidadMedida

            SelectStmt = "select ivitemm.item_code,item_name," & _
                        " ivitemd.price,purch_unit,benef,ivitemm.group_code, " & _
                        " purch_cost from ivitemm inner join ivitemd " & _
                        " on ivitemm.item_code = ivitemd.item_code " & _
                        " where whse_code = '" & pwhse_code.ToString & "'" & _
                        " and prov_code= '" & pprov_code.ToString & "'"

            If Me.xtxt_group_code.Text.Trim <> "" Then
                SelectStmt = SelectStmt.Trim & " and group_code = " & Me.xtxt_group_code.Text.Trim
            End If

            SelectStmt = SelectStmt.Trim & " order by item_name "

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Throw New ApplicationException("No se encontrarón productos con estos criterios!")
            End If

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No se encontrarón productos con estos criterios!")
            End If

            oTable.TableName = "ivpreciod"

            lineno = 0
            costo = 0
            precio = 0
            benef = 0

            ivpreciod.Rows.Clear()
            For Each oRow As DataRow In oTable.Rows
                Dim oRow1 As DataRow = ivpreciod.NewRow

                lineno += 1

                costo = oRow!purch_cost
                precio = oRow!price
                benef = oRow!benef


                Call Calculos(precio, costo, benef, oRow!item_code.ToString.Trim, oRow!purch_unit.ToString.Trim)

                Factor = oUnidad.GetFactor(oRow!item_code, oRow!purch_unit)

                oRow1!line_no = lineno
                oRow1!item_code = oRow!item_code
                oRow1!item_name = oRow!item_name
                oRow1!unidad = oRow!purch_unit
                oRow1!costo = costo * Factor
                oRow1!precio = precio * Factor
                oRow1!benef = benef
                oRow1!cambio = 0
                oRow1!costo_old = costo * Factor
                oRow1!precio_old = precio * Factor

                ivpreciod.Rows.Add(oRow1)
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try

            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then

                If IsNull(e.UpdatingArgs.Row!fecha) Then
                    e.UpdatingArgs.Row!fecha = LibX.Data.Manager.Connection.GetDate
                End If
            End If


        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            Log.Add(ex)

        End Try
    End Sub
    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        Try
            If ivpreciod.Select("cambio > 0").Length <= 0 Then
                Throw New ApplicationException("No se especificaron cambios en esta lista de precio, verifique!")
            End If
            ''For Each oRow As DataRow In ivpreciod.Select("cambio =0")
            ''    oRow.Delete()
            ''Next

        Catch ex As Exception
            e.Handled = True
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub lkItem_code_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkItem_code.BeforeSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.IsDataEditing = True Then
                '// Validar si el producto existe y si es asi
                '// aumentar la cantidad de lo contrario continuar
                If ProductoExiste(e.row!item_code) = True Then
                    LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, gColITem_code, "")
                    Throw New ApplicationException("Este Producto ya esta Registrado en esta Lista!")
                End If

            End If

        Catch ex As Exception
            e.handled = True
            LibXGridDetalle.Focus(LibXGridDetalle.CurrentRowIndex, 0)
            LibX.Log.Show(ex)

        End Try
    End Sub
    Private Function ProductoExiste(ByVal pitem_code As String) As Boolean
        Dim oRow As DataRow()
        Dim Qty As Integer
        Try
            oRow = ivpreciod.Select("item_code = '" & pitem_code.Trim & "'")

            If oRow.Length <= 0 Then
                Return False
            End If

            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
    Private Function ProductoCosto(ByVal pitem_code As String) As Decimal
        Dim olDcosto As Integer
        Dim selStmt As String
        Try
            selStmt = "select purch_cost from ivitemd where whse_code =1 and item_code = '" & pitem_code.Trim & "'"
            olDcosto = LibX.Data.Manager.GetScalar(selStmt)

            Return olDcosto

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function

    Private Sub lkItem_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lkItem_code.BeforeExecuteQuery
        Dim SelectStmt As String
        Try

            If Trim(Me.txtwhse_code.Text) <> "" Then
                e.aditionalWhere = String.Concat("ivitemd.whse_code ='", Trim(Me.txtwhse_code.Text), "'")
            End If
            'If Trim(Me.txtprov_code.Text) <> "" Then
            '    e.aditionalWhere = " and " & e.aditionalWhere & String.Concat(" and ivitemm.prov_code ='", Trim(Me.txtprov_code.Text), "'")
            'End If
            'SelectStmt = e.SQL & e.aditionalWhere

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_RowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange
        'Try
        '    If e.row Is Nothing Then
        '        Exit Sub
        '    End If
        '    If Not IsNull(e.row!doc_status) Then
        '        Me.LibXConnector1.AllowEdit = True
        '        Me.LibXConnector1.AllowDelete = True

        '        If Trim(e.row!doc_status) = "1" Then
        '            Me.LibXConnector1.AllowDelete = False
        '            Me.LibXConnector1.AllowEdit = False
        '        End If
        '        Me.LibXNavigator1.UpdateState()
        '    End If

        'Catch ex As Exception
        '    Log.Show(ex)

        'End Try
    End Sub

    Private Sub LibXConnector1_InsertedRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Update Then

            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            Log.Add(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try
            LibxDateTimePicker1.Value = LibX.Data.Manager.Connection.GetDate.ToShortDateString
            Me.xcbo_estatus.currValue = 1
            Me.txtwhse_code.Text = 1
            grp_Header.Enabled = True

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub



    Private Sub chkEdCosto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkEdCosto.CheckedChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                '///controla el estado de checkbox beneficio
                If Me.chkEdPrecio.CheckState = CheckState.Unchecked And Me.chkEdCosto.CheckState = CheckState.Unchecked Then
                    Me.chkCalBenef.Enabled = True
                Else
                    Me.chkCalBenef.Enabled = False
                End If

                ''//controla el estado de la columna costo
                If Me.chkEdCosto.CheckState = CheckState.Unchecked Then
                    gColCosto.ReadOnly = True
                    gColCosto.isReadOnly = True
                Else
                    gColCosto.ReadOnly = False
                    gColCosto.isReadOnly = False
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub chkEdPrecio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkEdPrecio.CheckedChanged
        Try

            If LibXConnector1.IsDataEditing = True Then
                '///controla el estado de checkbox beneficio
                If Me.chkEdPrecio.CheckState = CheckState.Unchecked And Me.chkEdCosto.CheckState = CheckState.Unchecked Then
                    Me.chkCalBenef.Enabled = True
                Else
                    Me.chkCalBenef.Enabled = False
                End If

                '///controla el estatus de la columna precio
                If Me.chkEdPrecio.CheckState = CheckState.Unchecked Then
                    gColPrecio.ReadOnly = True
                    gColPrecio.isReadOnly = True
                Else
                    gColPrecio.ReadOnly = False
                    gColPrecio.isReadOnly = False
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub chkCalBenef_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCalBenef.CheckedChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                ''///verifica si se marca el calcular beneficio
                If Me.chkCalBenef.CheckState = CheckState.Checked Then

                    Me.chkEdPrecio.Enabled = False
                    Me.chkEdCosto.Enabled = False
                    Me.txtBenef.Enabled = True
                    Me.txtBenef.Text = mConf.GetBenef
                    Me.txtBenef.Focus()

                ElseIf Me.chkCalBenef.CheckState = CheckState.Indeterminate Then

                    Me.chkCalBenef.CheckState = CheckState.Unchecked

                    Me.chkEdPrecio.Enabled = True
                    Me.chkEdCosto.Enabled = True
                    Me.txtBenef.Enabled = False
                    Me.txtBenef.Text = ""
                Else
                    Me.chkEdPrecio.Enabled = True
                    Me.chkEdCosto.Enabled = True
                    Me.txtBenef.Enabled = False
                    Me.txtBenef.Text = ""

                    If LibXConnector1.State = LibX.LibxConnectorState.Insert Then
                        ProductosRequerido(txtprov_code.Text.Trim, txtwhse_code.Text.Trim)
                    End If
                End If

                '//controla el estado de la columna costo y precio

                If Me.chkCalBenef.CheckState = 0 Then
                    Me.gColBeneficio.ReadOnly = True
                    Me.gColBeneficio.isReadOnly = True
                Else
                    Me.gColBeneficio.ReadOnly = False
                    Me.gColBeneficio.isReadOnly = False
                End If

                ''///verifica cuando se requiere marcar el beneficio
                Me.txtBenef.Requiered = Me.chkCalBenef.Checked
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub xlk_Suplidor_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_Suplidor.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.IsDataEditing = True Then
                Me.btnLoadItems.Enabled = True
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub
    Private Sub txtBenef_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBenef.LostFocus
        Try

            If chkCalBenef.CheckState = 1 Then
                If Me.txtBenef.Text = "" Then
                    Me.txtBenef.Focus()
                Else
                    '// actualiza los datos del grid
                    If Me.LibXGridDetalle.getCurrentGridView.Count > 0 Then
                        Me.ActualizaGrid()
                    End If
                End If
            End If


        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXGridDetalle_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGridDetalle.CellValidate

        Try

            If LibXConnector1.IsEditing = True Then

                If e.cell = Me.LibXGridDetalle.GetColNum(Me.gColCosto) Then
                    If e.value.ToString.Trim = "" Then
                        e.hasErrors = True
                        Exit Sub
                    End If

                    If Val(e.value.ToString.Trim) <= 0 Then
                        Throw New ApplicationException("Costo invalido, verifique!")
                    End If
                End If

                If e.cell = Me.LibXGridDetalle.GetColNum(Me.gColPrecio) Then
                    If e.value.ToString.Trim = "" Then
                        e.hasErrors = True
                        Exit Sub
                    End If

                    If Val(e.value.ToString.Trim) <= 0 Then
                        Throw New ApplicationException("Precio invalido, verifique!")
                    End If

                    If Val(e.value.ToString.Trim) < Val(Me.LibXGridDetalle.GetValue(e.row, gColCosto).ToString.Trim) Then
                        Throw New ApplicationException("Precio invalido, verifique!")
                    End If
                End If

                If e.cell = Me.LibXGridDetalle.GetColNum(Me.gColBeneficio) Then
                    If e.value.ToString.Trim = "" Then
                        e.hasErrors = True
                        Exit Sub
                    End If

                    If Val(e.value.ToString.Trim) <= 0 Then
                        Throw New ApplicationException("% Beneficio invalido, verifique!")
                    End If
                End If

                If e.cell = Me.LibXGridDetalle.GetColNum(Me.gColCosto) _
                Or e.cell = Me.LibXGridDetalle.GetColNum(Me.gColPrecio) _
                Or e.cell = Me.LibXGridDetalle.GetColNum(Me.gColBeneficio) Then

                    If e.value.ToString.Trim = "" Then
                        Exit Sub
                    End If

                    Call Calculos(LibXGridDetalle.GetValue(e.row, Me.gColPrecio), _
                                  LibXGridDetalle.GetValue(e.row, Me.gColCosto), _
                                  LibXGridDetalle.GetValue(e.row, Me.gColBeneficio), _
                                  LibXGridDetalle.GetValue(e.row, Me.gColITem_code), _
                                  LibXGridDetalle.GetValue(e.row, Me.gColUnid))


                    If Resultado.precio > 0 Then
                        LibXGridDetalle.SetValue(e.row, Me.gColPrecio, Resultado.precio)
                    End If


                    If Resultado.benef > 0 Then
                        LibXGridDetalle.SetValue(e.row, gColBeneficio, Resultado.benef)
                    End If
                    If Resultado.cambio <> 0 Then
                        LibXGridDetalle.SetValue(e.row, gColCambio, Resultado.cambio)
                    End If
                End If

            End If

        Catch ex As Exception
            e.hasErrors = True
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim XUpdate As LibX.Data.XUpdateStmt

        Try

            If MessageBox.Show("Seguro desea actualizar los precios de estos productos?", "Actualizar Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                LibX.Data.Manager.Connection.BeginTransaction()

                '// Actualizar los productos
                ActualizaProductos()

                '// Generar Etiqueta
                ActualizaEtiquetas()

                LibX.Data.Manager.Connection.CommitTransaction()


                '// Actualizar Registro
                XUpdate = New LibX.Data.XUpdateStmt("ivpreciom")
                XUpdate.FieldsSet("estatus") = 2 '//Aplicado
                XUpdate.Fields("precio_code") = LibXConnector1.CurrentDataRow!precio_code.ToString.Trim
                XUpdate.Execute()

                '// refrescar la pantalla
                xcbo_estatus.currValue = 2 '// APLICADO
                Me.LibXConnector1.AllowEdit = False
                Me.LibXConnector1.AllowDelete = False

                Me.LibXNavigator1.UpdateState()
            End If

        Catch ex As Exception
            '//LibX.Data.Manager.Connection.RollBackTransaction()
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If Not e.row Is Nothing Then
                LibXConnector1.AllowEdit = (e.row!estatus.ToString.Trim = "1")
                LibXConnector1.AllowDelete = (e.row!estatus.ToString.Trim = "1")
                btnActualizar.Enabled = (e.row!estatus.ToString.Trim = "1")

                LibXNavigator1.UpdateState()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub i_ivpreciom01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mConf = New SGT.Inventario.Common.Configuration
            LibXGridDetalle.footerOperations.add("item_code", "count(item_code)", "1=1")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGridDetalle_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LibXGridDetalle.GotFocus
        Try
            If Me.LibXConnector1.IsDataEditing = True Then
                If Me.chkCalBenef.Checked = True Or Me.chkEdPrecio.Checked = True Or Me.chkEdCosto.Checked = True Then
                    grp_Header.Enabled = False
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadItems.Click
        If LibXConnector1.IsDataEditing = True Then
            ProductosRequerido(Me.txtprov_code.Text.Trim, txtwhse_code.Text.Trim)
        End If

    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Me.btnLoadItems.Enabled = (e.isDataEditing And LibXConnector1.HasRecords = True)
        Me.btnActualizar.Enabled = (Not e.isDataEditing AndAlso LibXConnector1.HasRecords = True AndAlso LibXConnector1.CurrentDataRow!estatus.ToString.Trim = "1")

    End Sub

    Private Sub lkItem_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkItem_code.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.IsDataEditing = True Then
                LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.gColPrecio, e.row!price)
                LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.gColCosto, e.row!purch_cost)
                LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.gColBeneficio, e.row!benef)
                LibXGridDetalle.SetValue(LibXGridDetalle.CurrentRowIndex, Me.gColUnid, e.row!purch_unit)
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub CalcularRubros(ByVal oRow As DataRow)
        Dim Descuento As Decimal
        Dim mArticulo As SGT.Inventario.Entidades.Articulo
        Dim oParamArticulo As SGT.Inventario.Entidades.Articulo.ParametrosCostosLocales
        Try
            If LibXConnector1.IsDataEditing = False Then
                With ivpreciod
                    If oRow Is Nothing Then
                        Exit Sub
                    End If

                    If oRow.RowState = DataRowState.Deleted _
                    Or oRow.RowState = DataRowState.Detached Then
                        Exit Sub
                    End If

                    If LibX.IsNull(oRow!costo) Then
                        Exit Sub
                    End If

                    mArticulo = New SGT.Inventario.Entidades.Articulo
                    oParamArticulo = New SGT.Inventario.Entidades.Articulo.ParametrosCostosLocales

                    With oParamArticulo
                        .Producto = oRow!item_code.ToString
                        .Almacen = CType(txtwhse_code.Text, Integer)
                        .Costo = Val(oRow!costo.ToString)
                        .Cantidad = 1 '//
                        .Ofertas = 0
                        .UnidadCompra = oRow!unidad.ToString
                        .Descuento = 0
                        .ISC = 0

                        If LibX.IsNull(oRow!benef) = False Then
                            .Beneficio = oRow!benef
                        End If

                        .incluirOFERTA = False
                        '.IncluirITBIS = False
                        .incluirISC = False
                        .IncluirDescuento = False

                        .TotalFactura = Val(oRow!costo.ToString)
                        .Importe = Val(oRow!costo.ToString)
                        '.Descuento = Val(Me.disc_amount.Text.Trim)
                        '.TotalITBIS = 0
                        '.TotalISC = Val(Me.tax_amount.Text.Trim)
                    End With

                    '// Importe = Qty * price
                    If mArticulo.CalcularCostoLocal(oParamArticulo) = True Then
                        '// Iniciar Editar
                        oRow.BeginEdit()

                        '// Asignar valores
                        oRow!precio = Decimal.Round(oParamArticulo.ValoresRetorno.Precio, 2)
                        oRow!costo = Decimal.Round(oParamArticulo.ValoresRetorno.costo, 2)

                        '// Finalizar Editar
                        oRow.EndEdit()
                    End If
                End With
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_SettingDefaulteditValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultEditValues) Handles LibXConnector1.SettingDefaulteditValues
        grp_Header.Enabled = False
    End Sub

    Private Sub LibXConnector1_SettingDefaultqueryValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultQueryValues) Handles LibXConnector1.SettingDefaultqueryValues
        grp_Header.Enabled = True
    End Sub
End Class
