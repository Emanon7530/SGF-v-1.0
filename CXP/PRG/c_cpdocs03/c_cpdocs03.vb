Public Class c_cpdocs03
    Inherits System.Windows.Forms.Form
    Dim oDoc As SGT.Facturacion.Entidades.Documento
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents LibXCombo2 As LibX.LibXCombo
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents xlk_cust_name As LibX.LibXLookup
    Friend WithEvents prov_name As System.Windows.Forms.TextBox
    Friend WithEvents btnVisualizar As System.Windows.Forms.Button
    Friend WithEvents xedSerial_no As LibX.XEditTextBoxColumn
    Friend WithEvents btnCliente As System.Windows.Forms.Button
    Friend WithEvents mnuVisualizar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPagos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCliente As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCobro As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRelacionado As System.Windows.Forms.MenuItem
    Friend WithEvents btnPagos As System.Windows.Forms.Button
    Friend WithEvents btnCobros As System.Windows.Forms.Button
    Friend WithEvents btnRelacionado As System.Windows.Forms.Button
    Friend WithEvents mnuSeries As System.Windows.Forms.MenuItem
    Friend WithEvents xdt_FechaFin As LibX.LibxDateTimePicker
    Friend WithEvents xdt_FechaInicio As LibX.LibxDateTimePicker
    Friend WithEvents xlnk_type_code As LibX.XDataGridLinkColumn
    Friend WithEvents xlnk_fact_number As LibX.XDataGridLinkColumn
    Friend WithEvents xlnk_cust_code As LibX.XDataGridLinkColumn
    Friend WithEvents xlnk_bus_name As LibX.XDataGridLinkColumn
    Friend WithEvents xlnk_fact_total As LibX.XDataGridLinkColumn
    Friend WithEvents gbx_Filter As System.Windows.Forms.GroupBox
    Friend WithEvents LibXCombo3 As LibX.LibXCombo
    Friend WithEvents xedfact_status As LibX.XDataGridComboBoxColumn
    Friend WithEvents xed_status_name As LibX.XEditTextBoxColumn
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents xxdt_itbis As LibX.XEditTextBoxColumn
    Friend WithEvents xxdt_cargo_desc As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_Amount As LibX.XEditTextBoxColumn
    Friend WithEvents chk_otros As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Facturas As System.Windows.Forms.CheckBox
    Friend WithEvents chk_recibos As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Notascredito As System.Windows.Forms.CheckBox
    Friend WithEvents lblOtros As System.Windows.Forms.Label
    Friend WithEvents lblFacturas As System.Windows.Forms.Label
    Friend WithEvents lblRecibos As System.Windows.Forms.Label
    Friend WithEvents lblNotasCredito As System.Windows.Forms.Label
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
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents cpprovm As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo4 As LibX.LibXCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXCombo2 = New LibX.LibXCombo
        Me.DataSet1 = New System.Data.DataSet
        Me.cpprovm = New System.Data.DataTable
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
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.xdt_FechaFin = New LibX.LibxDateTimePicker
        Me.xdt_FechaInicio = New LibX.LibxDateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.xlk_cust_name = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.prov_name = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuVisualizar = New System.Windows.Forms.MenuItem
        Me.mnuPagos = New System.Windows.Forms.MenuItem
        Me.mnuCliente = New System.Windows.Forms.MenuItem
        Me.mnuCobro = New System.Windows.Forms.MenuItem
        Me.mnuRelacionado = New System.Windows.Forms.MenuItem
        Me.mnuSeries = New System.Windows.Forms.MenuItem
        Me.LibXCombo3 = New LibX.LibXCombo
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.xlnk_type_code = New LibX.XDataGridLinkColumn
        Me.xlnk_fact_number = New LibX.XDataGridLinkColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.xlnk_cust_code = New LibX.XDataGridLinkColumn
        Me.xlnk_bus_name = New LibX.XDataGridLinkColumn
        Me.xed_status_name = New LibX.XEditTextBoxColumn
        Me.xedfact_status = New LibX.XDataGridComboBoxColumn
        Me.xdt_Amount = New LibX.XEditTextBoxColumn
        Me.xxdt_cargo_desc = New LibX.XEditTextBoxColumn
        Me.xxdt_itbis = New LibX.XEditTextBoxColumn
        Me.xlnk_fact_total = New LibX.XDataGridLinkColumn
        Me.xedSerial_no = New LibX.XEditTextBoxColumn
        Me.gbx_Filter = New System.Windows.Forms.GroupBox
        Me.chk_otros = New System.Windows.Forms.CheckBox
        Me.chk_Facturas = New System.Windows.Forms.CheckBox
        Me.lblOtros = New System.Windows.Forms.Label
        Me.lblFacturas = New System.Windows.Forms.Label
        Me.chk_recibos = New System.Windows.Forms.CheckBox
        Me.lblRecibos = New System.Windows.Forms.Label
        Me.lblNotasCredito = New System.Windows.Forms.Label
        Me.chk_Notascredito = New System.Windows.Forms.CheckBox
        Me.btnVisualizar = New System.Windows.Forms.Button
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.btnPagos = New System.Windows.Forms.Button
        Me.btnCliente = New System.Windows.Forms.Button
        Me.btnCobros = New System.Windows.Forms.Button
        Me.btnRelacionado = New System.Windows.Forms.Button
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.LibXCombo4 = New LibX.LibXCombo
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpprovm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LibXGrid1.SuspendLayout()
        Me.gbx_Filter.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LibXCombo4)
        Me.GroupBox1.Controls.Add(Me.LibXCombo2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaFin)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaInicio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xlk_cust_name)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.prov_name)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio"
        '
        'LibXCombo2
        '
        Me.LibXCombo2.AllowDefaultSort = True
        Me.LibXCombo2.bound = True
        Me.LibXCombo2.currValue = Nothing
        Me.LibXCombo2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cpdocsv.invce_status"))
        Me.LibXCombo2.DefaultWhereString = Nothing
        Me.LibXCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo2.EditInitialValue = Nothing
        Me.LibXCombo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.FieldDescription = ""
        Me.LibXCombo2.FindInitialValue = Nothing
        Me.LibXCombo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.IgnoreRequiered = False
        Me.LibXCombo2.Items.AddRange(New Object() {"0-Anulada", "1-En Almacen", "2-En Caja", "3-Despachada"})
        Me.LibXCombo2.Location = New System.Drawing.Point(160, 64)
        Me.LibXCombo2.LookupKeyDisplayFields = Nothing
        Me.LibXCombo2.LookupKeyField = Nothing
        Me.LibXCombo2.LookupTableName = Nothing
        Me.LibXCombo2.Name = "LibXCombo2"
        Me.LibXCombo2.NewInitialValue = Nothing
        Me.LibXCombo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.Requiered = False
        Me.LibXCombo2.Required = False
        Me.LibXCombo2.Size = New System.Drawing.Size(216, 21)
        Me.LibXCombo2.SqlString = Nothing
        Me.LibXCombo2.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo2.TabIndex = 15
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.cpprovm, Me.DataTable1})
        '
        'cpprovm
        '
        Me.cpprovm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn1, Me.DataColumn12})
        Me.cpprovm.TableName = "cpprovm"
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.ColumnName = "type_code"
        Me.DataColumn24.MaxLength = 3
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "doc_no"
        Me.DataColumn25.MaxLength = 20
        Me.DataColumn25.ReadOnly = True
        '
        'DataColumn26
        '
        Me.DataColumn26.AllowDBNull = False
        Me.DataColumn26.ColumnName = "doc_date"
        Me.DataColumn26.DataType = GetType(System.DateTime)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "invce_status"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "phone"
        Me.DataColumn28.MaxLength = 14
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.AutoIncrement = True
        Me.DataColumn29.ColumnName = "prov_code"
        Me.DataColumn29.DataType = GetType(System.Int32)
        Me.DataColumn29.ReadOnly = True
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "prov_name"
        Me.DataColumn30.MaxLength = 60
        '
        'DataColumn31
        '
        Me.DataColumn31.AllowDBNull = False
        Me.DataColumn31.ColumnName = "amount"
        Me.DataColumn31.DataType = GetType(System.Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.AllowDBNull = False
        Me.DataColumn32.ColumnName = "amount1"
        Me.DataColumn32.DataType = GetType(System.Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.AllowDBNull = False
        Me.DataColumn33.AutoIncrement = True
        Me.DataColumn33.ColumnName = "invce_serial"
        Me.DataColumn33.DataType = GetType(System.Int32)
        Me.DataColumn33.ReadOnly = True
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "disc_amount"
        Me.DataColumn34.DataType = GetType(System.Decimal)
        Me.DataColumn34.ReadOnly = True
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "itbis"
        Me.DataColumn35.DataType = GetType(System.Decimal)
        Me.DataColumn35.ReadOnly = True
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "Estatus"
        Me.DataColumn36.MaxLength = 17
        Me.DataColumn36.ReadOnly = True
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "balance"
        Me.DataColumn1.DataType = GetType(System.Decimal)
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.DataTable1.TableName = "cpdocsv"
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.AutoIncrement = True
        Me.DataColumn2.ColumnName = "invce_serial"
        Me.DataColumn2.DataType = GetType(System.Int32)
        Me.DataColumn2.ReadOnly = True
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "type_code"
        Me.DataColumn3.MaxLength = 3
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "doc_no"
        Me.DataColumn4.MaxLength = 20
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "doc_date"
        Me.DataColumn5.DataType = GetType(System.DateTime)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "invce_status"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "phone"
        Me.DataColumn7.MaxLength = 20
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "prov_code"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "prov_name"
        Me.DataColumn9.MaxLength = 60
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "amount"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(40, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Tipo de Documento:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cpdocsv.type_code"))
        Me.LibXCombo1.DefaultWhereString = "apply_cxc = 1"
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Location = New System.Drawing.Point(160, 16)
        Me.LibXCombo1.LookupKeyDisplayFields = "type_name"
        Me.LibXCombo1.LookupKeyField = "type_code"
        Me.LibXCombo1.LookupTableName = "ivtypem"
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(216, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(568, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Fecha Final:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(564, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fecha Inicial:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xdt_FechaFin
        '
        Me.xdt_FechaFin.CustomFormat = "dd/MM/yyyy"
        Me.xdt_FechaFin.EditInitialValue = Nothing
        Me.xdt_FechaFin.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFin.FieldDescription = ""
        Me.xdt_FechaFin.FindInitialValue = Nothing
        Me.xdt_FechaFin.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaFin.IgnoreRequiered = False
        Me.xdt_FechaFin.Location = New System.Drawing.Point(648, 88)
        Me.xdt_FechaFin.Name = "xdt_FechaFin"
        Me.xdt_FechaFin.NewInitialValue = Nothing
        Me.xdt_FechaFin.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFin.Requiered = False
        Me.xdt_FechaFin.Size = New System.Drawing.Size(96, 20)
        Me.xdt_FechaFin.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaFin.TabIndex = 9
        '
        'xdt_FechaInicio
        '
        Me.xdt_FechaInicio.CustomFormat = "dd/MM/yyyy"
        Me.xdt_FechaInicio.EditInitialValue = Nothing
        Me.xdt_FechaInicio.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicio.FieldDescription = ""
        Me.xdt_FechaInicio.FindInitialValue = Nothing
        Me.xdt_FechaInicio.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaInicio.IgnoreRequiered = False
        Me.xdt_FechaInicio.Location = New System.Drawing.Point(648, 64)
        Me.xdt_FechaInicio.Name = "xdt_FechaInicio"
        Me.xdt_FechaInicio.NewInitialValue = Nothing
        Me.xdt_FechaInicio.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicio.Requiered = False
        Me.xdt_FechaInicio.Size = New System.Drawing.Size(96, 20)
        Me.xdt_FechaInicio.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaInicio.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(527, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Teléfono del Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(97, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Suplidor:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_cust_name
        '
        Me.xlk_cust_name.AlternateFieldSearch = Nothing
        Me.xlk_cust_name.BeginCheck = False
        Me.xlk_cust_name.CheckText = Nothing
        Me.xlk_cust_name.ComboMode = False
        Me.xlk_cust_name.DataMember = Nothing
        Me.xlk_cust_name.DataSource = Me.LibXConnector1
        Me.xlk_cust_name.DestParameters = New String() {"prov_code=prov_code", "prov_name=prov_name"}
        Me.xlk_cust_name.FilterField = Nothing
        Me.xlk_cust_name.IgnoreFindInBrowseMode = False
        Me.xlk_cust_name.isCanceled = False
        Me.xlk_cust_name.Location = New System.Drawing.Point(528, 88)
        Me.xlk_cust_name.LookCaption = "Suplidores Registrados"
        Me.xlk_cust_name.Name = "xlk_cust_name"
        Me.xlk_cust_name.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_cust_name.ShowFilter = True
        Me.xlk_cust_name.ShowMessageNotFound = True
        Me.xlk_cust_name.ShowWarning = False
        Me.xlk_cust_name.Size = New System.Drawing.Size(16, 20)
        Me.xlk_cust_name.SizesColumns = Nothing
        Me.xlk_cust_name.SizesColumnsTab = Nothing
        Me.xlk_cust_name.SqlString = Nothing
        Me.xlk_cust_name.SQLTab = Nothing
        Me.xlk_cust_name.SrcParameters = New String() {"prov_code=prov_code"}
        Me.xlk_cust_name.TabIndex = 4
        Me.xlk_cust_name.TableName = "cpprovm"
        Me.xlk_cust_name.TabStop = False
        Me.xlk_cust_name.UseCopyConnection = False
        Me.xlk_cust_name.UseRowRetrieveEvents = False
        Me.xlk_cust_name.UseTab = False
        Me.xlk_cust_name.VisParameters = New String() {"Código=prov_code", "Nombre=prov_name", "Contacto=contact_name"}
        Me.xlk_cust_name.WhereCondition = Nothing
        Me.xlk_cust_name.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "cpdocsv"
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
        Me.LibXDbSourceTable1.CustomDbUpdate = True
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
        Me.LibXDbSourceTable1.SerialColumnName = "invce_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select cpdocsv.invce_serial,", " cpdocsv.type_code,", "cpdocsv.doc_no,", "cpdocsv.suc_code,", "cpdocsv.doc_date,", "cpdocsv.invce_status, ", "cpprovm.phone,", "cpdocsv.prov_code,", "cpprovm.prov_name,", "cpdocsv.amount", "from cpdocsv ", "inner join cpprovm", "on cpprovm.prov_code = cpdocsv.prov_code", "order by doc_date,invce_status"}
        Me.LibXDbSourceTable1.TableName = "cpdocsv"
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
        Me.LibXDbSourceTable2.Source = New String() {"select distinct cpdocsv.type_code,cpdocsv.doc_no,cpdocsv.doc_date,   ", "                cpprovm.phone,cpdocsv.prov_code, cpdocsv.suc_code,", "                cpdocsv.prov_name,cpdocsv.amount, cpdocsv.neto balance,   ", "                cpdocsv.invce_serial,isnull(cpdocsv.disc_amount,0)disc_amount,isn" & _
        "ull(cpdocsv.itbis,0)itbis,  ", "           Case invce_status when 1 then  'Aplicado'   when 2 then 'Pendiente Apl" & _
        "icar' ", "      when 3 then 'Saldado' when 0 then   'Anulado' End Estatus from cpdocsv", "      inner join cpprovm  on cpprovm.prov_code = cpdocsv.prov_code  ", "order by doc_date, Estatus "}
        Me.LibXDbSourceTable2.TableName = "cpprovm"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.prov_name"))
        Me.TextBox3.Location = New System.Drawing.Point(160, 112)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(384, 20)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpprovm.phone"))
        Me.TextBox4.Location = New System.Drawing.Point(648, 40)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(96, 20)
        Me.TextBox4.TabIndex = 2
        Me.TextBox4.Text = ""
        '
        'prov_name
        '
        Me.prov_name.Location = New System.Drawing.Point(224, 88)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.ReadOnly = True
        Me.prov_name.Size = New System.Drawing.Size(304, 20)
        Me.prov_name.TabIndex = 1
        Me.prov_name.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpdocsv.prov_code"))
        Me.TextBox1.Location = New System.Drawing.Point(160, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(22, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Estatus del Documento:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpdocsv.doc_no"))
        Me.TextBox9.Location = New System.Drawing.Point(648, 16)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(96, 20)
        Me.TextBox9.TabIndex = 2
        Me.TextBox9.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(526, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Documento Número:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(36, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 16)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Nombre del Suplidor:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AllowNavigation = False
        Me.LibXGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = True
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Resultados de Busquedas"
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.Controls.Add(Me.LibXCombo3)
        Me.LibXGrid1.DataMember = "cpprovm"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = True
        Me.LibXGrid1.Location = New System.Drawing.Point(0, 176)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(1008, 424)
        Me.LibXGrid1.TabIndex = 1
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuVisualizar, Me.mnuPagos, Me.mnuCliente, Me.mnuCobro, Me.mnuRelacionado, Me.mnuSeries})
        '
        'mnuVisualizar
        '
        Me.mnuVisualizar.Index = 0
        Me.mnuVisualizar.Text = "Visualizar"
        '
        'mnuPagos
        '
        Me.mnuPagos.Index = 1
        Me.mnuPagos.Text = "Pagos"
        '
        'mnuCliente
        '
        Me.mnuCliente.Index = 2
        Me.mnuCliente.Text = "Cliente"
        '
        'mnuCobro
        '
        Me.mnuCobro.Index = 3
        Me.mnuCobro.Text = "Cobro"
        '
        'mnuRelacionado
        '
        Me.mnuRelacionado.Index = 4
        Me.mnuRelacionado.Text = "Relacionado"
        '
        'mnuSeries
        '
        Me.mnuSeries.Index = 5
        Me.mnuSeries.Text = "Series"
        '
        'LibXCombo3
        '
        Me.LibXCombo3.AllowDefaultSort = False
        Me.LibXCombo3.bound = True
        Me.LibXCombo3.currValue = Nothing
        Me.LibXCombo3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cpdocsv.invce_status"))
        Me.LibXCombo3.DefaultWhereString = Nothing
        Me.LibXCombo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo3.EditInitialValue = Nothing
        Me.LibXCombo3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo3.FieldDescription = ""
        Me.LibXCombo3.FindInitialValue = Nothing
        Me.LibXCombo3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo3.IgnoreRequiered = False
        Me.LibXCombo3.Items.AddRange(New Object() {"1-En almacen", "2-En Caja", "3-Despachada", "4-Pendiente Autorización", "0-Anulada"})
        Me.LibXCombo3.Location = New System.Drawing.Point(338, 264)
        Me.LibXCombo3.LookupKeyDisplayFields = Nothing
        Me.LibXCombo3.LookupKeyField = Nothing
        Me.LibXCombo3.LookupTableName = Nothing
        Me.LibXCombo3.Name = "LibXCombo3"
        Me.LibXCombo3.NewInitialValue = Nothing
        Me.LibXCombo3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo3.Requiered = False
        Me.LibXCombo3.Required = False
        Me.LibXCombo3.Size = New System.Drawing.Size(128, 21)
        Me.LibXCombo3.SqlString = Nothing
        Me.LibXCombo3.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo3.TabIndex = 16
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.HighlightText
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.xlnk_type_code, Me.xlnk_fact_number, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn3, Me.xlnk_cust_code, Me.xlnk_bus_name, Me.xed_status_name, Me.xedfact_status, Me.xdt_Amount, Me.xxdt_cargo_desc, Me.xxdt_itbis, Me.xlnk_fact_total, Me.xedSerial_no})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cpprovm"
        '
        'xlnk_type_code
        '
        Me.xlnk_type_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xlnk_type_code.Format = ""
        Me.xlnk_type_code.FormatInfo = Nothing
        Me.xlnk_type_code.HeaderText = "Tipo"
        Me.xlnk_type_code.ImageList = Nothing
        Me.xlnk_type_code.isReadOnly = False
        Me.xlnk_type_code.MappingName = "type_code"
        Me.xlnk_type_code.MaxLength = 32767
        Me.xlnk_type_code.TabStop = True
        Me.xlnk_type_code.UseCustomCellFormat = True
        Me.xlnk_type_code.Width = 50
        '
        'xlnk_fact_number
        '
        Me.xlnk_fact_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xlnk_fact_number.Format = ""
        Me.xlnk_fact_number.FormatInfo = Nothing
        Me.xlnk_fact_number.HeaderText = "Número"
        Me.xlnk_fact_number.ImageList = Nothing
        Me.xlnk_fact_number.isReadOnly = False
        Me.xlnk_fact_number.MappingName = "doc_no"
        Me.xlnk_fact_number.MaxLength = 32767
        Me.xlnk_fact_number.TabStop = True
        Me.xlnk_fact_number.UseCustomCellFormat = True
        Me.xlnk_fact_number.Width = 75
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Fecha"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "doc_date"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = True
        Me.XEditTextBoxColumn1.Width = 75
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Teléfono"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = False
        Me.XEditTextBoxColumn3.MappingName = "phone"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.TabStop = True
        Me.XEditTextBoxColumn3.UseCustomCellFormat = True
        Me.XEditTextBoxColumn3.Width = 75
        '
        'xlnk_cust_code
        '
        Me.xlnk_cust_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xlnk_cust_code.Format = ""
        Me.xlnk_cust_code.FormatInfo = Nothing
        Me.xlnk_cust_code.HeaderText = "Codigo "
        Me.xlnk_cust_code.ImageList = Nothing
        Me.xlnk_cust_code.isReadOnly = False
        Me.xlnk_cust_code.MappingName = "prov_code"
        Me.xlnk_cust_code.MaxLength = 32767
        Me.xlnk_cust_code.TabStop = True
        Me.xlnk_cust_code.UseCustomCellFormat = True
        Me.xlnk_cust_code.Width = 75
        '
        'xlnk_bus_name
        '
        Me.xlnk_bus_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xlnk_bus_name.Format = ""
        Me.xlnk_bus_name.FormatInfo = Nothing
        Me.xlnk_bus_name.HeaderText = "Nombre del Suplidor"
        Me.xlnk_bus_name.ImageList = Nothing
        Me.xlnk_bus_name.isReadOnly = False
        Me.xlnk_bus_name.MappingName = "prov_name"
        Me.xlnk_bus_name.MaxLength = 32767
        Me.xlnk_bus_name.TabStop = True
        Me.xlnk_bus_name.UseCustomCellFormat = True
        Me.xlnk_bus_name.Width = 350
        '
        'xed_status_name
        '
        Me.xed_status_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xed_status_name.Format = ""
        Me.xed_status_name.FormatInfo = Nothing
        Me.xed_status_name.HeaderText = "Estatus"
        Me.xed_status_name.ImageList = Nothing
        Me.xed_status_name.isReadOnly = False
        Me.xed_status_name.MappingName = "Estatus"
        Me.xed_status_name.MaxLength = 32767
        Me.xed_status_name.TabStop = True
        Me.xed_status_name.UseCustomCellFormat = True
        Me.xed_status_name.Width = 101
        '
        'xedfact_status
        '
        Me.xedfact_status.ComboBox = Me.LibXCombo3
        Me.xedfact_status.Format = ""
        Me.xedfact_status.FormatInfo = Nothing
        Me.xedfact_status.HeaderText = "Estatus"
        Me.xedfact_status.isReadOnly = False
        Me.xedfact_status.MappingName = "invce_status"
        Me.xedfact_status.Width = 0
        '
        'xdt_Amount
        '
        Me.xdt_Amount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_Amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Amount.Format = "###,###,###.00"
        Me.xdt_Amount.FormatInfo = Nothing
        Me.xdt_Amount.HeaderText = "Monto Brutoi"
        Me.xdt_Amount.ImageList = Nothing
        Me.xdt_Amount.isReadOnly = False
        Me.xdt_Amount.MappingName = "amount"
        Me.xdt_Amount.MaxLength = 32767
        Me.xdt_Amount.TabStop = True
        Me.xdt_Amount.UseCustomCellFormat = True
        Me.xdt_Amount.Width = 80
        '
        'xxdt_cargo_desc
        '
        Me.xxdt_cargo_desc.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xxdt_cargo_desc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xxdt_cargo_desc.Format = "###,##0.00"
        Me.xxdt_cargo_desc.FormatInfo = Nothing
        Me.xxdt_cargo_desc.HeaderText = "Descuentoi"
        Me.xxdt_cargo_desc.ImageList = Nothing
        Me.xxdt_cargo_desc.isReadOnly = False
        Me.xxdt_cargo_desc.MappingName = "disc_amount"
        Me.xxdt_cargo_desc.MaxLength = 32767
        Me.xxdt_cargo_desc.TabStop = True
        Me.xxdt_cargo_desc.UseCustomCellFormat = True
        Me.xxdt_cargo_desc.Width = 80
        '
        'xxdt_itbis
        '
        Me.xxdt_itbis.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xxdt_itbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xxdt_itbis.Format = "###,##0.00"
        Me.xxdt_itbis.FormatInfo = Nothing
        Me.xxdt_itbis.HeaderText = "Itbisi"
        Me.xxdt_itbis.ImageList = Nothing
        Me.xxdt_itbis.isReadOnly = False
        Me.xxdt_itbis.MappingName = "itbis"
        Me.xxdt_itbis.MaxLength = 32767
        Me.xxdt_itbis.TabStop = True
        Me.xxdt_itbis.UseCustomCellFormat = True
        Me.xxdt_itbis.Width = 80
        '
        'xlnk_fact_total
        '
        Me.xlnk_fact_total.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xlnk_fact_total.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xlnk_fact_total.Format = "###,###,###.00"
        Me.xlnk_fact_total.FormatInfo = Nothing
        Me.xlnk_fact_total.HeaderText = "Montoi"
        Me.xlnk_fact_total.ImageList = Nothing
        Me.xlnk_fact_total.isReadOnly = False
        Me.xlnk_fact_total.MappingName = "balance"
        Me.xlnk_fact_total.MaxLength = 32767
        Me.xlnk_fact_total.TabStop = True
        Me.xlnk_fact_total.UseCustomCellFormat = True
        Me.xlnk_fact_total.Width = 80
        '
        'xedSerial_no
        '
        Me.xedSerial_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xedSerial_no.Format = ""
        Me.xedSerial_no.FormatInfo = Nothing
        Me.xedSerial_no.ImageList = Nothing
        Me.xedSerial_no.isReadOnly = False
        Me.xedSerial_no.MappingName = "invce_serial"
        Me.xedSerial_no.MaxLength = 32767
        Me.xedSerial_no.TabStop = True
        Me.xedSerial_no.UseCustomCellFormat = False
        Me.xedSerial_no.Width = 0
        '
        'gbx_Filter
        '
        Me.gbx_Filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filter.Controls.Add(Me.chk_otros)
        Me.gbx_Filter.Controls.Add(Me.chk_Facturas)
        Me.gbx_Filter.Controls.Add(Me.lblOtros)
        Me.gbx_Filter.Controls.Add(Me.lblFacturas)
        Me.gbx_Filter.Controls.Add(Me.chk_recibos)
        Me.gbx_Filter.Controls.Add(Me.lblRecibos)
        Me.gbx_Filter.Controls.Add(Me.lblNotasCredito)
        Me.gbx_Filter.Controls.Add(Me.chk_Notascredito)
        Me.gbx_Filter.Location = New System.Drawing.Point(876, 24)
        Me.gbx_Filter.Name = "gbx_Filter"
        Me.gbx_Filter.Size = New System.Drawing.Size(136, 144)
        Me.gbx_Filter.TabIndex = 2
        Me.gbx_Filter.TabStop = False
        Me.gbx_Filter.Text = "Filtrar"
        '
        'chk_otros
        '
        Me.chk_otros.Location = New System.Drawing.Point(8, 112)
        Me.chk_otros.Name = "chk_otros"
        Me.chk_otros.Size = New System.Drawing.Size(80, 16)
        Me.chk_otros.TabIndex = 12
        Me.chk_otros.Text = "Otros"
        '
        'chk_Facturas
        '
        Me.chk_Facturas.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk_Facturas.Location = New System.Drawing.Point(8, 16)
        Me.chk_Facturas.Name = "chk_Facturas"
        Me.chk_Facturas.Size = New System.Drawing.Size(96, 16)
        Me.chk_Facturas.TabIndex = 11
        Me.chk_Facturas.Text = "Facturas"
        '
        'lblOtros
        '
        Me.lblOtros.BackColor = System.Drawing.Color.Pink
        Me.lblOtros.Location = New System.Drawing.Point(8, 128)
        Me.lblOtros.Name = "lblOtros"
        Me.lblOtros.Size = New System.Drawing.Size(56, 8)
        Me.lblOtros.TabIndex = 10
        '
        'lblFacturas
        '
        Me.lblFacturas.BackColor = System.Drawing.Color.LightCyan
        Me.lblFacturas.Location = New System.Drawing.Point(8, 32)
        Me.lblFacturas.Name = "lblFacturas"
        Me.lblFacturas.Size = New System.Drawing.Size(56, 8)
        Me.lblFacturas.TabIndex = 9
        '
        'chk_recibos
        '
        Me.chk_recibos.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk_recibos.Location = New System.Drawing.Point(8, 48)
        Me.chk_recibos.Name = "chk_recibos"
        Me.chk_recibos.Size = New System.Drawing.Size(112, 16)
        Me.chk_recibos.TabIndex = 11
        Me.chk_recibos.Text = "Cheque de Pago"
        '
        'lblRecibos
        '
        Me.lblRecibos.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblRecibos.Location = New System.Drawing.Point(8, 64)
        Me.lblRecibos.Name = "lblRecibos"
        Me.lblRecibos.Size = New System.Drawing.Size(56, 8)
        Me.lblRecibos.TabIndex = 9
        '
        'lblNotasCredito
        '
        Me.lblNotasCredito.BackColor = System.Drawing.Color.White
        Me.lblNotasCredito.Location = New System.Drawing.Point(8, 96)
        Me.lblNotasCredito.Name = "lblNotasCredito"
        Me.lblNotasCredito.Size = New System.Drawing.Size(56, 8)
        Me.lblNotasCredito.TabIndex = 9
        '
        'chk_Notascredito
        '
        Me.chk_Notascredito.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk_Notascredito.Location = New System.Drawing.Point(8, 80)
        Me.chk_Notascredito.Name = "chk_Notascredito"
        Me.chk_Notascredito.Size = New System.Drawing.Size(112, 16)
        Me.chk_Notascredito.TabIndex = 11
        Me.chk_Notascredito.Text = "Notas Credito"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVisualizar.Location = New System.Drawing.Point(8, 632)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.TabIndex = 3
        Me.btnVisualizar.Text = "Visualizar"
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(1028, 24)
        Me.LibXNavigator1.TabIndex = 4
        '
        'btnPagos
        '
        Me.btnPagos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPagos.Location = New System.Drawing.Point(88, 632)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.TabIndex = 3
        Me.btnPagos.Text = "Pagos"
        '
        'btnCliente
        '
        Me.btnCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCliente.Location = New System.Drawing.Point(168, 632)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.TabIndex = 3
        Me.btnCliente.Text = "Cliente"
        '
        'btnCobros
        '
        Me.btnCobros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCobros.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCobros.Location = New System.Drawing.Point(248, 632)
        Me.btnCobros.Name = "btnCobros"
        Me.btnCobros.TabIndex = 3
        Me.btnCobros.Text = "Cobro"
        '
        'btnRelacionado
        '
        Me.btnRelacionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRelacionado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRelacionado.Location = New System.Drawing.Point(328, 632)
        Me.btnRelacionado.Name = "btnRelacionado"
        Me.btnRelacionado.TabIndex = 3
        Me.btnRelacionado.Text = "Relacionado"
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Sucursal"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "suc_code"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 75
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "suc_code"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "suc_code"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(89, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Sucursal:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo4
        '
        Me.LibXCombo4.AllowDefaultSort = True
        Me.LibXCombo4.bound = True
        Me.LibXCombo4.currValue = Nothing
        Me.LibXCombo4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cpdocsv.type_code"))
        Me.LibXCombo4.DefaultWhereString = " "
        Me.LibXCombo4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo4.EditInitialValue = Nothing
        Me.LibXCombo4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo4.FieldDescription = ""
        Me.LibXCombo4.FindInitialValue = Nothing
        Me.LibXCombo4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo4.IgnoreRequiered = False
        Me.LibXCombo4.Location = New System.Drawing.Point(160, 40)
        Me.LibXCombo4.LookupKeyDisplayFields = "suc_name"
        Me.LibXCombo4.LookupKeyField = "suc_code"
        Me.LibXCombo4.LookupTableName = "cgsucursal"
        Me.LibXCombo4.Name = "LibXCombo4"
        Me.LibXCombo4.NewInitialValue = Nothing
        Me.LibXCombo4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo4.Requiered = False
        Me.LibXCombo4.Required = False
        Me.LibXCombo4.Size = New System.Drawing.Size(216, 21)
        Me.LibXCombo4.SqlString = Nothing
        Me.LibXCombo4.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo4.TabIndex = 16
        '
        'c_cpdocs03
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1028, 670)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.gbx_Filter)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPagos)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.btnCobros)
        Me.Controls.Add(Me.btnRelacionado)
        Me.Name = "c_cpdocs03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consultar Movimientos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpprovm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LibXGrid1.ResumeLayout(False)
        Me.gbx_Filter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try

            If e.Action = LibX.LibxConnectionActions.Find Then
                '// Asignar la fecha de busqueda desde el primero del mes y ano
                '// acutal hasta la fecha actual
                xdt_FechaFin.Value = LibX.Data.Manager.Connection.GetDate
                xdt_FechaInicio.Value = DateSerial(LibX.Data.Manager.Connection.GetDate.Year, LibX.Data.Manager.Connection.GetDate.Month, 1)

                '// Limpiar los resultados anteriores
                cpprovm.Rows.Clear()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim DataCol(1) As DataColumn
        Dim LoadAll As Integer = 1

        Try
            e.DoFill = False

            SelectStmt = String.Concat("select distinct cpdocsv.type_code,cpdocsv.doc_no,cpdocsv.suc_code,cpdocsv.doc_date, " & _
                                       "  cpprovm.phone,cpdocsv.prov_code, " & _
                                       "  cpdocsv.prov_name,cpdocsv.amount, cpdocsv.neto balance, " & _
                                       "  cpdocsv.invce_serial,isnull(cpdocsv.disc_amount,0)disc_amount,isnull(cpdocsv.itbis,0)itbis," & _
                                       "  Case invce_status when 1 then  'Aplicado' " & _
                                       "  when 2 then 'Pendiente Aplicar' when 3 then 'Saldado' when 0 then " & _
                                       "  'Anulado' End Estatus from cpdocsv " & _
                                       "  inner join cpprovm  on cpprovm.prov_code = cpdocsv.prov_code ")

            If Trim(e.Where) <> "" Then
                SelectStmt = SelectStmt.Trim & " and " & e.Where
            End If

            If LibX.IsNull(xdt_FechaInicio.Value) = False Then
                SelectStmt &= " and cpdocsv.doc_date between '" & CType(xdt_FechaInicio.Value, Date).ToString(LibX.Data.Manager.GetSaveDateFormat) & _
                              "' and '" & CType(xdt_FechaFin.Value, Date).ToString(LibX.Data.Manager.GetSaveDateFormat) & "'"
            End If
            SelectStmt = SelectStmt.Trim & " order by doc_date,Estatus "

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)
            oTable.TableName = "cpprovm"

            DataSet1.Merge(oTable, False, MissingSchemaAction.Ignore)

            LibXConnector1.HasRecords = (oTable.Rows.Count > 0)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click, mnuVisualizar.Click, xlnk_fact_number.LinkeClicked
        Dim xParam As LibX.LibxPrgParams
        Dim XParamAdm As SGT.Administracion.Entidades.Program.ParametrosVizualizar
        Dim XProgram As SGT.Administracion.Entidades.Program
        Try
            xParam = New LibX.LibxPrgParams
            XParamAdm = New SGT.Administracion.Entidades.Program.ParametrosVizualizar
            XProgram = New SGT.Administracion.Entidades.Program

            xParam.AllowDelete = False
            xParam.AllowEdit = False
            xParam.AllowNew = False
            xParam.AllowPrint = True
            xParam.AllowQuery = False

            xParam.Value = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xedSerial_no)
            xParam.initMode = LibX.LibxInitModes.Query
            xParam.WhereToExecute = "cpdocsv.invce_serial = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xedSerial_no)

            XParamAdm.Parametros = xParam
            XParamAdm.TipoDocumento = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_type_code)

            XProgram.Visualizar(XParamAdm)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCliente.Click, mnuCliente.Click, xlnk_bus_name.LinkeClicked
        Dim xParam As LibX.LibxPrgParams
        Try
            xParam = New LibX.LibxPrgParams
            xParam.AllowDelete = False
            xParam.AllowEdit = False
            xParam.AllowNew = False
            xParam.AllowPrint = True
            xParam.AllowQuery = False

            xParam.WhereToExecute = "cpprovm.prov_code = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_cust_code).ToString

            LibX.App.CurrentPrgParams = xParam

            LibX.LibXRunner.Run("i_cpprovm01", "CXP", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagos.Click, mnuPagos.Click, xlnk_cust_code.LinkeClicked
        Dim oParam As LibX.LibxPrgParams

        Dim WhereStmt As String
        Try
            oParam = New LibX.LibxPrgParams
            oParam.WhereToExecute = "cpdocsv.type_code = '" & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_type_code).ToString & "'" & _
                                    " and cpdocsv.doc_no = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_fact_number).ToString

            LibX.App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("c_cpdocs02", "CXP", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCobros.Click, mnuCobro.Click, xlnk_fact_total.LinkeClicked
        Dim oParam As LibX.LibxPrgParams
        Dim WhereStmt As String
        Try
            oParam = New LibX.LibxPrgParams
            oParam.WhereToExecute = "cpdocsv.invce_serial = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xedSerial_no).ToString
            LibX.App.CurrentPrgParams = oParam

            LibX.LibXRunner.Run("i_cppaym01", "CXP", True)
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelacionado.Click, mnuRelacionado.Click, xlnk_type_code.LinkeClicked
        Dim oParam As LibX.LibxPrgParams
        Dim WhereStmt As String
        Try
            oParam = New LibX.LibxPrgParams
            oParam.Datos.Add("type_code", LibXGrid1.GetValue(xlnk_type_code))
            oParam.Datos.Add("entr_number", LibXGrid1.GetValue(xlnk_fact_number))
            oParam.WhereToExecute = "iventrdm.entr_serial = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xedSerial_no).ToString
            LibX.App.CurrentPrgParams = oParam

            LibX.LibXRunner.Run("i_iventrm02", "CRD", True)
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try

            btnCliente.Enabled = (e.isEditing = False And cpprovm.Rows.Count > 0)
            btnCobros.Enabled = (e.isEditing = False And cpprovm.Rows.Count > 0)
            btnPagos.Enabled = (e.isEditing = False And cpprovm.Rows.Count > 0)
            btnRelacionado.Enabled = (e.isEditing = False And cpprovm.Rows.Count > 0)
            btnVisualizar.Enabled = (e.isEditing = False And cpprovm.Rows.Count > 0)
            gbx_Filter.Enabled = (e.isEditing = False And cpprovm.Rows.Count > 0)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid1.CurrentRowChanged
        Try
            If e.row < 0 Then
                Exit Sub
            End If

            If cpprovm.Rows.Count > 0 Then
                btnCliente.Enabled = Not LibX.IsNull(LibXGrid1.GetValue(xlnk_cust_code))
                'btnCobros.Enabled = LibXGrid1.GetValue(xedfact_status) = 3
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub c_ftdocs01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LibXGrid1.getCurrentGridView.Sort = "type_code,doc_no"
            LibXGrid1.footerOperations.add("type_code", "count(type_code)")
            LibXGrid1.footerOperations.add("amount", "sum(amount)")

            oDoc = New SGT.Facturacion.Entidades.Documento

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub


    Private Sub xbln_fact_cond_SetCellFormat(ByVal sender As System.Object, ByVal e As LibX.XDataGridFormatCellEventArgs) Handles XEditTextBoxColumn1.SetCellFormat, XEditTextBoxColumn3.SetCellFormat, xlnk_bus_name.SetCellFormat, xlnk_cust_code.SetCellFormat, xlnk_fact_number.SetCellFormat, xlnk_fact_total.SetCellFormat, xlnk_type_code.SetCellFormat, xed_status_name.SetCellFormat, xdt_Amount.SetCellFormat, xxdt_cargo_desc.SetCellFormat, xxdt_itbis.SetCellFormat
        Try

            If LibXGrid1.GetValue(e.RowNumber, xlnk_type_code) = "CRD" Then
                e.BackColor = lblFacturas.BackColor
            End If

            If LibXGrid1.GetValue(e.RowNumber, xlnk_type_code) = "NCR" Then
                e.BackColor = lblNotasCredito.BackColor
            End If

            If LibXGrid1.GetValue(e.RowNumber, xlnk_type_code) = "CHQ" Then
                e.BackColor = lblRecibos.BackColor
            End If


        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub chk_Facturas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_otros.CheckedChanged, chk_Facturas.CheckedChanged, chk_recibos.CheckedChanged, chk_Notascredito.CheckedChanged
        Dim Filter As String = ""
        Try
            If chk_Facturas.Checked = True Then
                Filter = "(type_code ='CRD')"
            End If

            If chk_recibos.Checked = True Then
                If Filter.Trim.Length > 0 Then
                    Filter &= " or (type_code = 'CHQ')"
                Else
                    Filter = " (type_code = 'CHQ')"
                End If
            End If

            If chk_Notascredito.Checked = True Then
                If Filter.Trim.Length > 0 Then
                    Filter &= " or (type_code = 'NCR')"
                Else
                    Filter = " (type_code = 'NCR')"
                End If
            End If

            If chk_otros.Checked = True Then
                If Filter.Trim.Length > 0 Then
                    Filter &= " or (type_code not in ('NCR','CHQ','CRD'))"
                Else
                    Filter = " (type_code not in ('NCR','CHQ','CRD'))"
                End If
            End If

            LibXGrid1.getCurrentGridView.RowFilter = Filter
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

End Class
