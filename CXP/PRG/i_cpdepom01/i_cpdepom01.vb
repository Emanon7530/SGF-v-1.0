Imports LibX
Public Class i_cpdepom01
    Inherits System.Windows.Forms.Form
    Dim oDoc As SGT.Inventario.Entidades.Documento
    Dim cpDoc As SGT.CXP.Posteos.PostDocument
    Dim prov As Integer
    Dim mResta As Decimal
    

    Structure Valor5
        'declarando estructura calculos
        Dim Monto As Decimal
        Dim aplica As Decimal
        Dim descuento As Decimal
        Dim itbis As Decimal

    End Structure

    Dim Resultado As Valor5

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
    'Friend WithEvents lkItem_code As LibX.LibXLookup
    Friend WithEvents LibXGridDetalle As LibX.LibXGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents xlk_Suplidor As LibX.LibXLookup
    Friend WithEvents txtprov_code As LibX.XTextBox
    Friend WithEvents txtprov_name As LibX.XTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TexDoc_type As LibX.XDataGridTextButtonColumn
    Friend WithEvents TextDoc_no As LibX.XDataGridTextButtonColumn
    Friend WithEvents TexInvce_desc As LibX.XDataGridTextButtonColumn
    Friend WithEvents TexFecha_doc As LibX.XDataGridTextButtonColumn
    Friend WithEvents TextCantidad_dia As LibX.XDataGridTextButtonColumn
    Friend WithEvents TexMonto As LibX.XDataGridTextButtonColumn
    Friend WithEvents TexDescuento As LibX.XDataGridTextButtonColumn
    Friend WithEvents TexItbis As LibX.XDataGridTextButtonColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cpdepockm As System.Data.DataTable
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
    Friend WithEvents cpdepockd As System.Data.DataTable
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DSTcpdepockm As LibX.LibXDbSourceTable
    Friend WithEvents DTScpdepockd As LibX.LibXDbSourceTable
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents XTextBoxbanco As LibX.XTextBox
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XTextBoxMonto As LibX.XTextBox
    Friend WithEvents DataGridBoolAplicar As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents Valor As System.Data.DataColumn
    Friend WithEvents Aplicar As System.Data.DataColumn
    Friend WithEvents TextBoxValor As LibX.XEditTextBoxColumn
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents xtxt_chequera As LibX.XTextBox
    Friend WithEvents xtxt_numero As LibX.XTextBox
    Friend WithEvents xcbo_tipo_doc As LibX.LibXCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.cpdepockm = New System.Data.DataTable
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
        Me.cpdepockd = New System.Data.DataTable
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.Valor = New System.Data.DataColumn
        Me.Aplicar = New System.Data.DataColumn
        Me.DSTcpdepockm = New LibX.LibXDbSourceTable
        Me.DTScpdepockd = New LibX.LibXDbSourceTable
        Me.xtxt_chequera = New LibX.XTextBox
        Me.xtxt_numero = New LibX.XTextBox
        Me.LibXGridDetalle = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.DataGridBoolAplicar = New System.Windows.Forms.DataGridBoolColumn
        Me.TexDoc_type = New LibX.XDataGridTextButtonColumn
        Me.TextDoc_no = New LibX.XDataGridTextButtonColumn
        Me.TexInvce_desc = New LibX.XDataGridTextButtonColumn
        Me.TexFecha_doc = New LibX.XDataGridTextButtonColumn
        Me.TextCantidad_dia = New LibX.XDataGridTextButtonColumn
        Me.TexMonto = New LibX.XDataGridTextButtonColumn
        Me.TexDescuento = New LibX.XDataGridTextButtonColumn
        Me.TexItbis = New LibX.XDataGridTextButtonColumn
        Me.TextBoxValor = New LibX.XEditTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xcbo_tipo_doc = New LibX.LibXCombo
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.XTextBoxMonto = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.XTextBoxbanco = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.xlk_Suplidor = New LibX.LibXLookup
        Me.txtprov_code = New LibX.XTextBox
        Me.txtprov_name = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpdepockm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpdepockd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_chequera
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_numero
        Me.LibXNavigator1.FirstControlInNewMode = Nothing
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(866, 24)
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
        Me.LibXConnector1.DataMember = "cpdepockm"
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
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.DSTcpdepockm, Me.DTScpdepockd})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.cpdepockm, Me.cpdepockd})
        '
        'cpdepockm
        '
        Me.cpdepockm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29})
        Me.cpdepockm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"depo_code"}, True)})
        Me.cpdepockm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn19}
        Me.cpdepockm.TableName = "cpdepockm"
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.AutoIncrement = True
        Me.DataColumn19.ColumnName = "depo_code"
        Me.DataColumn19.DataType = GetType(System.Int32)
        Me.DataColumn19.ReadOnly = True
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "prov_code"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "chequera"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "tipo_doc"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "monto"
        Me.DataColumn23.DataType = GetType(System.Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "pago_auto"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "doc_vencido"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "estado"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "fecha_doc"
        Me.DataColumn27.DataType = GetType(System.DateTime)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "numero_ck"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "concepto"
        Me.DataColumn29.MaxLength = 50
        '
        'cpdepockd
        '
        Me.cpdepockd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.Valor, Me.Aplicar})
        Me.cpdepockd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"depo_code", "line_no"}, True)})
        Me.cpdepockd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn30, Me.DataColumn31}
        Me.cpdepockd.TableName = "cpdepockd"
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "depo_code"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.AllowDBNull = False
        Me.DataColumn31.ColumnName = "line_no"
        Me.DataColumn31.MaxLength = 40
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "type_code"
        Me.DataColumn32.MaxLength = 3
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "doc_no"
        Me.DataColumn33.MaxLength = 50
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "fecha_doc"
        Me.DataColumn34.DataType = GetType(System.DateTime)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "cantidad_dia"
        Me.DataColumn35.DataType = GetType(System.Int32)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "monto"
        Me.DataColumn36.DataType = GetType(System.Decimal)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "descuento"
        Me.DataColumn37.DataType = GetType(System.Decimal)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "itbis"
        Me.DataColumn38.DataType = GetType(System.Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "invce_desc"
        Me.DataColumn39.MaxLength = 60
        '
        'Valor
        '
        Me.Valor.Caption = "Valor"
        Me.Valor.ColumnName = "Valor"
        Me.Valor.DataType = GetType(System.Decimal)
        '
        'Aplicar
        '
        Me.Aplicar.Caption = "Aplicar"
        Me.Aplicar.ColumnName = "Aplicar"
        '
        'DSTcpdepockm
        '
        Me.DSTcpdepockm.AllowDelete = True
        Me.DSTcpdepockm.AllowEdit = True
        Me.DSTcpdepockm.AllowNew = True
        Me.DSTcpdepockm.AutoIncrementSerial = False
        Me.DSTcpdepockm.CustomDbUpdate = False
        Me.DSTcpdepockm.DeleteOrder = 0
        Me.DSTcpdepockm.FillOnQuery = True
        Me.DSTcpdepockm.FillOnRowChange = False
        Me.DSTcpdepockm.HeaderIsOnGrid = False
        Me.DSTcpdepockm.InnerJon = True
        Me.DSTcpdepockm.InsertOrder = 0
        Me.DSTcpdepockm.IsDetail = False
        Me.DSTcpdepockm.KeyFields = Nothing
        Me.DSTcpdepockm.LineColName = Nothing
        Me.DSTcpdepockm.MasterDetailRelation = Nothing
        Me.DSTcpdepockm.MasterTableName = Nothing
        Me.DSTcpdepockm.SerialColumnName = "depo_code"
        Me.DSTcpdepockm.Sort = Nothing
        Me.DSTcpdepockm.Source = Nothing
        Me.DSTcpdepockm.TableName = "cpdepockm"
        Me.DSTcpdepockm.UpdateOrder = 0
        Me.DSTcpdepockm.UseRowRetrieve = False
        '
        'DTScpdepockd
        '
        Me.DTScpdepockd.AllowDelete = True
        Me.DTScpdepockd.AllowEdit = True
        Me.DTScpdepockd.AllowNew = True
        Me.DTScpdepockd.AutoIncrementSerial = False
        Me.DTScpdepockd.CustomDbUpdate = False
        Me.DTScpdepockd.DeleteOrder = 0
        Me.DTScpdepockd.FillOnQuery = True
        Me.DTScpdepockd.FillOnRowChange = True
        Me.DTScpdepockd.HeaderIsOnGrid = False
        Me.DTScpdepockd.InnerJon = True
        Me.DTScpdepockd.InsertOrder = 0
        Me.DTScpdepockd.IsDetail = True
        Me.DTScpdepockd.KeyFields = Nothing
        Me.DTScpdepockd.LineColName = "line_no"
        Me.DTScpdepockd.MasterDetailRelation = New String() {"depo_code=depo_code"}
        Me.DTScpdepockd.MasterTableName = Nothing
        Me.DTScpdepockd.SerialColumnName = Nothing
        Me.DTScpdepockd.Sort = Nothing
        Me.DTScpdepockd.Source = New String() {"select cpdepockd.*,cpinvcem.invce_desc", "from cpdepockd inner join cpinvcem", "on cpdepockd.doc_no = cpinvcem.doc_no", "inner join cpdepockm", "on cpdepockd.depo_code = cpdepockm.depo_code"}
        Me.DTScpdepockd.TableName = "cpdepockd"
        Me.DTScpdepockd.UpdateOrder = 0
        Me.DTScpdepockd.UseRowRetrieve = False
        '
        'xtxt_chequera
        '
        Me.xtxt_chequera.AcceptsReturn = True
        Me.xtxt_chequera.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpdepockm.chequera"))
        Me.xtxt_chequera.EditInitialValue = Nothing
        Me.xtxt_chequera.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chequera.FieldDescription = ""
        Me.xtxt_chequera.FindInitialValue = Nothing
        Me.xtxt_chequera.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chequera.IgnoreRequiered = False
        Me.xtxt_chequera.Location = New System.Drawing.Point(136, 88)
        Me.xtxt_chequera.Name = "xtxt_chequera"
        Me.xtxt_chequera.NewInitialValue = Nothing
        Me.xtxt_chequera.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chequera.Requiered = False
        Me.xtxt_chequera.Size = New System.Drawing.Size(89, 20)
        Me.xtxt_chequera.StatusBarPanelDescripcion = Nothing
        Me.xtxt_chequera.TabIndex = 3
        Me.xtxt_chequera.Text = ""
        '
        'xtxt_numero
        '
        Me.xtxt_numero.AcceptsReturn = True
        Me.xtxt_numero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpdepockm.numero_ck"))
        Me.xtxt_numero.EditInitialValue = Nothing
        Me.xtxt_numero.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_numero.FieldDescription = ""
        Me.xtxt_numero.FindInitialValue = Nothing
        Me.xtxt_numero.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_numero.IgnoreRequiered = False
        Me.xtxt_numero.Location = New System.Drawing.Point(136, 16)
        Me.xtxt_numero.Name = "xtxt_numero"
        Me.xtxt_numero.NewInitialValue = Nothing
        Me.xtxt_numero.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_numero.Requiered = False
        Me.xtxt_numero.Size = New System.Drawing.Size(200, 20)
        Me.xtxt_numero.StatusBarPanelDescripcion = Nothing
        Me.xtxt_numero.TabIndex = 0
        Me.xtxt_numero.Text = ""
        '
        'LibXGridDetalle
        '
        Me.LibXGridDetalle.AllowSorting = False
        Me.LibXGridDetalle.AutoAdjustLastColumn = True
        Me.LibXGridDetalle.AutoSearch = False
        Me.LibXGridDetalle.BackgroundColor = System.Drawing.Color.White
        Me.LibXGridDetalle.CaptionText = "Documentos"
        Me.LibXGridDetalle.DataMember = "cpdepockd"
        Me.LibXGridDetalle.DataSource = Me.DataSet1
        Me.LibXGridDetalle.FullRowSelect = False
        Me.LibXGridDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGridDetalle.IsReadOnly = False
        Me.LibXGridDetalle.Location = New System.Drawing.Point(8, 208)
        Me.LibXGridDetalle.Name = "LibXGridDetalle"
        Me.LibXGridDetalle.ReadOnly = True
        Me.LibXGridDetalle.RowHeaderWidth = 30
        Me.LibXGridDetalle.searchText = ""
        Me.LibXGridDetalle.showFooterBar = True
        Me.LibXGridDetalle.Size = New System.Drawing.Size(848, 312)
        Me.LibXGridDetalle.TabIndex = 2
        Me.LibXGridDetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGridDetalle.UseAutoFillLines = True
        Me.LibXGridDetalle.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGridDetalle
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridBoolAplicar, Me.TexDoc_type, Me.TextDoc_no, Me.TexInvce_desc, Me.TexFecha_doc, Me.TextCantidad_dia, Me.TexMonto, Me.TexDescuento, Me.TexItbis, Me.TextBoxValor})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cpdepockd"
        Me.XdataGridTableStyle1.RowHeaderWidth = 30
        '
        'DataGridBoolAplicar
        '
        Me.DataGridBoolAplicar.FalseValue = "0"
        Me.DataGridBoolAplicar.HeaderText = "Aplicar"
        Me.DataGridBoolAplicar.MappingName = "Aplicar"
        Me.DataGridBoolAplicar.NullValue = "0"
        Me.DataGridBoolAplicar.TrueValue = "1"
        Me.DataGridBoolAplicar.Width = 40
        '
        'TexDoc_type
        '
        Me.TexDoc_type.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.TexDoc_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TexDoc_type.executeFindDuringFill = True
        Me.TexDoc_type.Format = ""
        Me.TexDoc_type.FormatInfo = Nothing
        Me.TexDoc_type.HeaderText = "Tipo"
        Me.TexDoc_type.isReadOnly = False
        Me.TexDoc_type.MappingName = "type_code"
        Me.TexDoc_type.MaxLength = 32767
        Me.TexDoc_type.TabStop = True
        Me.TexDoc_type.UseCustomCellFormat = False
        Me.TexDoc_type.Width = 75
        '
        'TextDoc_no
        '
        Me.TextDoc_no.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextDoc_no.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.TextDoc_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextDoc_no.executeFindDuringFill = True
        Me.TextDoc_no.Format = ""
        Me.TextDoc_no.FormatInfo = Nothing
        Me.TextDoc_no.HeaderText = "Numero"
        Me.TextDoc_no.isReadOnly = False
        Me.TextDoc_no.MappingName = "doc_no"
        Me.TextDoc_no.MaxLength = 32767
        Me.TextDoc_no.TabStop = True
        Me.TextDoc_no.UseCustomCellFormat = False
        Me.TextDoc_no.Width = 75
        '
        'TexInvce_desc
        '
        Me.TexInvce_desc.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.TexInvce_desc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TexInvce_desc.executeFindDuringFill = True
        Me.TexInvce_desc.Format = ""
        Me.TexInvce_desc.FormatInfo = Nothing
        Me.TexInvce_desc.HeaderText = "Descripción"
        Me.TexInvce_desc.isReadOnly = False
        Me.TexInvce_desc.MappingName = "invce_desc"
        Me.TexInvce_desc.MaxLength = 32767
        Me.TexInvce_desc.TabStop = True
        Me.TexInvce_desc.UseCustomCellFormat = False
        Me.TexInvce_desc.Width = 160
        '
        'TexFecha_doc
        '
        Me.TexFecha_doc.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.TexFecha_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TexFecha_doc.executeFindDuringFill = True
        Me.TexFecha_doc.Format = "mm/dd/yyyy"
        Me.TexFecha_doc.FormatInfo = Nothing
        Me.TexFecha_doc.HeaderText = "Fecha"
        Me.TexFecha_doc.isReadOnly = False
        Me.TexFecha_doc.MappingName = "fecha_doc"
        Me.TexFecha_doc.MaxLength = 32767
        Me.TexFecha_doc.TabStop = True
        Me.TexFecha_doc.UseCustomCellFormat = False
        Me.TexFecha_doc.Width = 75
        '
        'TextCantidad_dia
        '
        Me.TextCantidad_dia.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextCantidad_dia.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.TextCantidad_dia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextCantidad_dia.executeFindDuringFill = True
        Me.TextCantidad_dia.Format = "####"
        Me.TextCantidad_dia.FormatInfo = Nothing
        Me.TextCantidad_dia.HeaderText = "Dias Transcurrido"
        Me.TextCantidad_dia.isReadOnly = False
        Me.TextCantidad_dia.MappingName = "cantidad_dia"
        Me.TextCantidad_dia.MaxLength = 32767
        Me.TextCantidad_dia.TabStop = True
        Me.TextCantidad_dia.UseCustomCellFormat = False
        Me.TextCantidad_dia.Width = 75
        '
        'TexMonto
        '
        Me.TexMonto.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.TexMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TexMonto.executeFindDuringFill = True
        Me.TexMonto.Format = "##,###,##0.00"
        Me.TexMonto.FormatInfo = Nothing
        Me.TexMonto.HeaderText = "Monto"
        Me.TexMonto.isReadOnly = False
        Me.TexMonto.MappingName = "monto"
        Me.TexMonto.MaxLength = 32767
        Me.TexMonto.TabStop = True
        Me.TexMonto.UseCustomCellFormat = False
        Me.TexMonto.Width = 75
        '
        'TexDescuento
        '
        Me.TexDescuento.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.TexDescuento.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.TexDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TexDescuento.executeFindDuringFill = True
        Me.TexDescuento.Format = "##,###,##0.00"
        Me.TexDescuento.FormatInfo = Nothing
        Me.TexDescuento.HeaderText = "Descuento"
        Me.TexDescuento.isReadOnly = False
        Me.TexDescuento.MappingName = "descuento"
        Me.TexDescuento.MaxLength = 32767
        Me.TexDescuento.TabStop = True
        Me.TexDescuento.UseCustomCellFormat = False
        Me.TexDescuento.Width = 75
        '
        'TexItbis
        '
        Me.TexItbis.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.TexItbis.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.TexItbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TexItbis.executeFindDuringFill = True
        Me.TexItbis.Format = "##,###,##0.00"
        Me.TexItbis.FormatInfo = Nothing
        Me.TexItbis.HeaderText = "Itbis"
        Me.TexItbis.isReadOnly = False
        Me.TexItbis.MappingName = "itbis"
        Me.TexItbis.MaxLength = 32767
        Me.TexItbis.TabStop = True
        Me.TexItbis.UseCustomCellFormat = False
        Me.TexItbis.Width = 75
        '
        'TextBoxValor
        '
        Me.TextBoxValor.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBoxValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextBoxValor.Format = "##,###,##0.00"
        Me.TextBoxValor.FormatInfo = Nothing
        Me.TextBoxValor.HeaderText = "Valor"
        Me.TextBoxValor.ImageList = Nothing
        Me.TextBoxValor.isReadOnly = False
        Me.TextBoxValor.MappingName = "Valor"
        Me.TextBoxValor.MaxLength = 32767
        Me.TextBoxValor.TabStop = True
        Me.TextBoxValor.UseCustomCellFormat = False
        Me.TextBoxValor.Width = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xcbo_tipo_doc)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.XTextBoxMonto)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.XTextBoxbanco)
        Me.GroupBox1.Controls.Add(Me.xtxt_chequera)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xtxt_numero)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xlk_Suplidor)
        Me.GroupBox1.Controls.Add(Me.txtprov_code)
        Me.GroupBox1.Controls.Add(Me.txtprov_name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(848, 168)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'xcbo_tipo_doc
        '
        Me.xcbo_tipo_doc.AllowDefaultSort = True
        Me.xcbo_tipo_doc.bound = True
        Me.xcbo_tipo_doc.currValue = Nothing
        Me.xcbo_tipo_doc.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cpdepockm.tipo_doc"))
        Me.xcbo_tipo_doc.DefaultWhereString = Nothing
        Me.xcbo_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_tipo_doc.EditInitialValue = Nothing
        Me.xcbo_tipo_doc.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_tipo_doc.FieldDescription = ""
        Me.xcbo_tipo_doc.FindInitialValue = Nothing
        Me.xcbo_tipo_doc.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_tipo_doc.IgnoreRequiered = False
        Me.xcbo_tipo_doc.Location = New System.Drawing.Point(136, 40)
        Me.xcbo_tipo_doc.LookupKeyDisplayFields = "descripcion"
        Me.xcbo_tipo_doc.LookupKeyField = "tipo_doc"
        Me.xcbo_tipo_doc.LookupTableName = "cptipodoc"
        Me.xcbo_tipo_doc.Name = "xcbo_tipo_doc"
        Me.xcbo_tipo_doc.NewInitialValue = Nothing
        Me.xcbo_tipo_doc.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_tipo_doc.Requiered = False
        Me.xcbo_tipo_doc.Required = False
        Me.xcbo_tipo_doc.Size = New System.Drawing.Size(200, 21)
        Me.xcbo_tipo_doc.SqlString = Nothing
        Me.xcbo_tipo_doc.StatusBarPanelDescripcion = Nothing
        Me.xcbo_tipo_doc.TabIndex = 66
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cpdepockm.estado"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Items.AddRange(New Object() {"1-Activo", "0-Inactivo"})
        Me.LibXCombo1.Location = New System.Drawing.Point(648, 16)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = Nothing
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = "1"
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(112, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 5
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpdepockm.fecha_doc"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.FieldDescription = ""
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = False
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(648, 40)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = Nothing
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Requiered = False
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(112, 20)
        Me.LibxDateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker1.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpdepockm.concepto"))
        Me.TextBox1.Location = New System.Drawing.Point(136, 112)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(400, 48)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = ""
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(648, 104)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(112, 16)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "Pago Automatico"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(648, 88)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(80, 16)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Vencidos:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(67, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Concepto:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBoxMonto
        '
        Me.XTextBoxMonto.AcceptsReturn = True
        Me.XTextBoxMonto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpdepockm.monto"))
        Me.XTextBoxMonto.EditInitialValue = Nothing
        Me.XTextBoxMonto.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBoxMonto.FieldDescription = ""
        Me.XTextBoxMonto.FindInitialValue = Nothing
        Me.XTextBoxMonto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBoxMonto.IgnoreRequiered = False
        Me.XTextBoxMonto.Location = New System.Drawing.Point(648, 64)
        Me.XTextBoxMonto.Name = "XTextBoxMonto"
        Me.XTextBoxMonto.NewInitialValue = Nothing
        Me.XTextBoxMonto.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBoxMonto.Requiered = False
        Me.XTextBoxMonto.Size = New System.Drawing.Size(112, 20)
        Me.XTextBoxMonto.StatusBarPanelDescripcion = Nothing
        Me.XTextBoxMonto.TabIndex = 7
        Me.XTextBoxMonto.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(590, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Monto:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"chequera=chequera", "XTextBoxbanco=descripcion"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(520, 88)
        Me.LibXLookup1.LookCaption = "chequera"
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.ShowWarning = False
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SizesColumns = Nothing
        Me.LibXLookup1.SizesColumnsTab = Nothing
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"chequera=chequera"}
        Me.LibXLookup1.TabIndex = 62
        Me.LibXLookup1.TableName = "cpchequera"
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=chequera", "Descripción=descripcion"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'XTextBoxbanco
        '
        Me.XTextBoxbanco.AcceptsReturn = True
        Me.XTextBoxbanco.EditInitialValue = Nothing
        Me.XTextBoxbanco.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBoxbanco.FieldDescription = ""
        Me.XTextBoxbanco.FindInitialValue = Nothing
        Me.XTextBoxbanco.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBoxbanco.IgnoreRequiered = False
        Me.XTextBoxbanco.Location = New System.Drawing.Point(232, 88)
        Me.XTextBoxbanco.Name = "XTextBoxbanco"
        Me.XTextBoxbanco.NewInitialValue = Nothing
        Me.XTextBoxbanco.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBoxbanco.ReadOnly = True
        Me.XTextBoxbanco.Requiered = False
        Me.XTextBoxbanco.Size = New System.Drawing.Size(288, 20)
        Me.XTextBoxbanco.StatusBarPanelDescripcion = Nothing
        Me.XTextBoxbanco.TabIndex = 61
        Me.XTextBoxbanco.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(66, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 16)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Chequera:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(590, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(48, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Documento #:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(74, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Suplidor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_Suplidor
        '
        Me.xlk_Suplidor.AlternateFieldSearch = Nothing
        Me.xlk_Suplidor.CheckText = Nothing
        Me.xlk_Suplidor.ComboMode = False
        Me.xlk_Suplidor.DataMember = Nothing
        Me.xlk_Suplidor.DataSource = Me.LibXConnector1
        Me.xlk_Suplidor.DestParameters = New String() {"txtprov_code=prov_code", "txtprov_name=prov_name"}
        Me.xlk_Suplidor.FilterField = Nothing
        Me.xlk_Suplidor.IgnoreFindInBrowseMode = False
        Me.xlk_Suplidor.isCanceled = False
        Me.xlk_Suplidor.Location = New System.Drawing.Point(520, 64)
        Me.xlk_Suplidor.LookCaption = "Suplidor"
        Me.xlk_Suplidor.Name = "xlk_Suplidor"
        Me.xlk_Suplidor.PopupSize = New System.Drawing.Size(0, 0)
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
        Me.txtprov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpdepockm.prov_code"))
        Me.txtprov_code.EditInitialValue = Nothing
        Me.txtprov_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtprov_code.FieldDescription = ""
        Me.txtprov_code.FindInitialValue = Nothing
        Me.txtprov_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.IgnoreRequiered = False
        Me.txtprov_code.Location = New System.Drawing.Point(136, 64)
        Me.txtprov_code.Name = "txtprov_code"
        Me.txtprov_code.NewInitialValue = Nothing
        Me.txtprov_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.Requiered = False
        Me.txtprov_code.Size = New System.Drawing.Size(89, 20)
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
        Me.txtprov_name.Location = New System.Drawing.Point(232, 64)
        Me.txtprov_name.Name = "txtprov_name"
        Me.txtprov_name.NewInitialValue = Nothing
        Me.txtprov_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_name.ReadOnly = True
        Me.txtprov_name.Requiered = False
        Me.txtprov_name.Size = New System.Drawing.Size(288, 20)
        Me.txtprov_name.StatusBarPanelDescripcion = Nothing
        Me.txtprov_name.TabIndex = 31
        Me.txtprov_name.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(584, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Estatus:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(17, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Tipo de Documento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(696, 544)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 50
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(586, 544)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 16)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Decuento Aplicado:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(696, 568)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 20)
        Me.Label12.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(613, 568)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 16)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Itbis Aplicado:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(696, 592)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 20)
        Me.Label14.TabIndex = 54
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(608, 592)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Valor Aplicado:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8})
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
        Me.MenuItem7.Text = "Aplicar"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 7
        Me.MenuItem8.Text = "Anular"
        '
        'i_cpdepom01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(866, 656)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.LibXGridDetalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_cpdepom01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Solicitud de cheques"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpdepockm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpdepockd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ActualizaDocumentos()

        Dim i As Integer
        Dim oValue As Object
        Dim XUpdate As LibX.Data.XUpdateStmt

        Try

        Catch ex As Exception
            Log.Add(ex, True)

        End Try
    End Sub


    Private Sub DocumentoRequerido(ByVal pprov_code As String)

        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim lineno As Integer
        Dim dia As Integer

        Try

            If pprov_code = "" Then
                Throw New ApplicationException("seleccione el proveedor!")
            End If
            prov = pprov_code

            SelectStmt = "select cpopend.*,type_code,doc_no,invce_desc,itbis " & _
                        " from cpopend,cpinvcem " & _
                        " where cpopend.prov_code =' " & pprov_code.ToString & "'" & _
                        " and cpopend.balance > 0 and cpinvcem.prov_code = cpinvcem.prov_code " & _
                        " and cpinvcem.invce_serial = cpopend.invce_serial "

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Throw New ApplicationException("No se encontrarón productos con estos criterios!")
            End If

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No se encontrarón productos con estos criterios!")
            End If

            oTable.TableName = "cpdepockd"

            lineno = 0
            dia = 0

            cpdepockd.Rows.Clear()
            For Each oRow As DataRow In oTable.Rows
                Dim oRow1 As DataRow = cpdepockd.NewRow
                lineno += 1
                dia = DateDiff(DateInterval.Day, oRow!doc_date, DateTime.Now)
                oRow1!line_no = lineno
                oRow1!type_code = oRow!type_code
                oRow1!doc_no = oRow!doc_no
                oRow1!invce_desc = oRow!invce_desc
                'oRow1!fecha_doc = CType(oRow!doc_date, Date).ToString("MM/dd/yyyy")
                oRow1!fecha_doc = oRow!doc_date
                oRow1!cantidad_dia = dia
                oRow1!monto = oRow!balance
                oRow1!descuento = oRow!disc_amount
                oRow1!itbis = oRow!itbis
                oRow1!Aplicar = 0

                cpdepockd.Rows.Add(oRow1)
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xlk_Suplidor_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_Suplidor.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.State = LibX.LibxConnectorState.Insert Then

                DocumentoRequerido(e.row!prov_code)

            End If

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub

    Private Sub ApplyFilter()

        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim lineno As Integer
        Dim dia As Integer

        Try
            cpdepockd.Rows.Clear()
            SelectStmt = "select cpopend.*,type_code,doc_no,invce_desc,itbis " & _
                        " from cpopend,cpinvcem " & _
                         " where cpopend.prov_code =' " & prov & "'" & _
                        " and cpopend.disc_date <' " & CType(DateTime.Now, Date).ToString("MM/dd/yyyy") & "'" & _
                        " and cpopend.balance > 0 and cpinvcem.prov_code = cpinvcem.prov_code " & _
                        " and cpinvcem.invce_serial = cpopend.invce_serial "

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Throw New ApplicationException("No se encontrarón documentos con estos criterios!")
            End If

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No se encontrarón documentos con estos criterios!")
            End If

            oTable.TableName = "cpdepockd"

            lineno = 0
            dia = 0

            For Each oRow As DataRow In oTable.Rows
                Dim oRow1 As DataRow = cpdepockd.NewRow
                lineno += 1
                dia = DateDiff(DateInterval.Day, oRow!doc_date, DateTime.Now)
                oRow1!line_no = lineno
                oRow1!type_code = oRow!type_code
                oRow1!doc_no = oRow!doc_no
                oRow1!invce_desc = oRow!invce_desc
                'oRow1!fecha_doc = CType(oRow!doc_date, Date).ToString("MM/dd/yyyy")
                oRow1!fecha_doc = oRow!doc_date
                oRow1!cantidad_dia = dia
                oRow1!monto = oRow!balance
                oRow1!descuento = oRow!disc_amount
                oRow1!itbis = oRow!itbis

                cpdepockd.Rows.Add(oRow1)
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ApplyFilter()
        Else
            DocumentoRequerido(prov)
        End If
    End Sub
    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGridDetalle.CurrentRowChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                LibXGridDetalle.refreshFooter()
                Calcular()
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try

            If LibXConnector1.IsEditing = False AndAlso LibXConnector1.HasRecords = True Then
                Calcular()
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub


    Private Sub Calcular()
        Dim Aplicar, descuento, itbis As Decimal
        Dim oValue, oValue1 As Object
        Dim i, x As Integer
        Try

            'If LibXGridDetalle.Text.Length > 0 Then
            '    Aplicar = XTextBoxMonto.Text
            'End If

            'For i = 0 To LibXGridDetalle.getCurrentGridView.Count - 1

            '    oValue = Me.LibXGridDetalle.GetValue(i, Me.TexMonto)
            '    oValue -= Me.LibXGridDetalle.GetValue(i, Me.TexDescuento)
            '    oValue += Me.LibXGridDetalle.GetValue(i, Me.TexItbis)

            '    'Resultado.Monto += (-Resultado.descuento + Resultado.itbis)

            '    If Not IsNull(oValue) Then
            '        Resultado.Monto = oValue
            '    End If
            '    If Resultado.Monto > 0 Then
            '        LibXGridDetalle.SetValue(i, Me.TextBoxValor, Resultado.Monto)
            '    End If

            '    XTextBoxMonto.Text = Format(Resultado.Monto, "##,###,###.##")
            'Next

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        If e.Action = LibX.LibxConnectionActions.Find _
        Or e.AcceptedAction = LibX.LibxConnectionActions.Find Then
            DataSet1.Tables(0).Rows.Clear()
            DataSet1.Tables(1).Rows.Clear()
            LibXGridDetalle.ReadOnly = True
        End If

        If e.Action = LibX.LibxConnectionActions.Add Then
            LibXGridDetalle.ReadOnly = False
        End If

        If e.AcceptedAction = LibX.LibxConnectionActions.Add And DataSet1.Tables("cpdepockd").Select("Aplicar=1").Length > 0 Then
            Calcular()
        End If
    End Sub
    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGridDetalle.CellValidate
        Try

            '// APLICAR
            If LibXConnector1.IsDataEditing = True And e.row > -1 Then

                If e.cell = 0 Then
                    If LibX.IsNull(e.value) Then
                        e.hasErrors = True
                        Exit Sub
                    End If

                    If e.value = True Then
                        Me.TextBoxValor.ReadOnly = False
                        AsignarMonto(e.row)
                    Else
                        Me.TextBoxValor.ReadOnly = True
                        Me.LibXGridDetalle.SetValue(e.row, Me.TexMonto, 0)
                    End If
                End If

                If e.cell = Me.TexMonto.Column And _
                Me.LibXGridDetalle.GetValue(e.row, Me.TexMonto) = True Then
                    If Val(Me.LibXGridDetalle.GetValue(e.row, Me.TexMonto)) < _
                    Val(Me.LibXGridDetalle.GetValue(e.row, Me.TexMonto)) Then
                        Throw New ApplicationException("No puede aplicar un monto mayor al valor del documento!")
                    End If

                    If Val(Me.LibXGridDetalle.GetValue(e.row, Me.TexMonto)) > _
                    mResta Then
                        Throw New ApplicationException("No puede aplicar un monto mayor que el valor restante!")
                    End If

                End If

                Calcular()
            End If

        Catch ex As Exception
            e.hasErrors = True
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub AsignarMonto(ByVal Row As Integer)
        Try
            '// Si el monto del documento es menor que la parte a aplicar
            '// asignar el monto del documento como monto a aplicar
            If Me.LibXGridDetalle.GetValue(Row, Me.TexMonto) > 0 Then
                Me.LibXGridDetalle.SetValue(Row, Me.TexMonto)
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues

    End Sub

    Private Sub LibXGridDetalle_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles LibXGridDetalle.Navigate

    End Sub

    Private Sub i_cpdepom01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            LibXGridDetalle.footerOperations.add("type_code", "count(type_code)")
            LibXGridDetalle.footerOperations.add("Aplicar", "count(type_code)", "Aplicar=1")
            LibXGridDetalle.footerOperations.add("Monto", "sum(monto)", "aplicar=1")
            LibXGridDetalle.footerOperations.add("Monto", "sum(descuento)", "aplicar=1")
            LibXGridDetalle.footerOperations.add("Monto", "sum(itbis)", "aplicar=1")
            LibXGridDetalle.footerOperations.add("Monto", "sum(valor)", "aplicar=1")
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class
