Public Class c_ftdocs01
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
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents LibXCombo2 As LibX.LibXCombo
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
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
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents fecini As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents ftfactd As System.Data.DataTable
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents xlk_bus_name As LibX.LibXLookup
    Friend WithEvents xlk_cust_name As LibX.LibXLookup
    Friend WithEvents cust_name As System.Windows.Forms.TextBox
    Friend WithEvents xlk_item_name As LibX.LibXLookup
    Friend WithEvents xlk_vend_code As LibX.LibXLookup
    Friend WithEvents vend_name As System.Windows.Forms.TextBox
    Friend WithEvents txtitem_name As System.Windows.Forms.TextBox
    Friend WithEvents btnVisualizar As System.Windows.Forms.Button
    Friend WithEvents chk_Devoluciones As System.Windows.Forms.CheckBox
    Friend WithEvents lbldevoluciones As System.Windows.Forms.Label
    Friend WithEvents DataColumn1 As System.Data.DataColumn
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
    Friend WithEvents btnSeries As System.Windows.Forms.Button
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents xedSerial_afect As LibX.XEditTextBoxColumn
    Friend WithEvents mnuSeries As System.Windows.Forms.MenuItem
    Friend WithEvents DataTable1 As System.Data.DataTable
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
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents xdt_FechaFin As LibX.LibxDateTimePicker
    Friend WithEvents xdt_FechaInicio As LibX.LibxDateTimePicker
    Friend WithEvents rdb_Contado As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Credito As System.Windows.Forms.RadioButton
    Friend WithEvents xlnk_type_code As LibX.XDataGridLinkColumn
    Friend WithEvents xlnk_fact_number As LibX.XDataGridLinkColumn
    Friend WithEvents xlnk_cust_code As LibX.XDataGridLinkColumn
    Friend WithEvents xlnk_bus_name As LibX.XDataGridLinkColumn
    Friend WithEvents xlnk_fact_total As LibX.XDataGridLinkColumn
    Friend WithEvents xbln_fact_cond As LibX.XDataGridBoolColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents lblContado As System.Windows.Forms.Label
    Friend WithEvents lblCredito As System.Windows.Forms.Label
    Friend WithEvents lblServicios As System.Windows.Forms.Label
    Friend WithEvents chk_contado As System.Windows.Forms.CheckBox
    Friend WithEvents chk_credito As System.Windows.Forms.CheckBox
    Friend WithEvents chk_servicios As System.Windows.Forms.CheckBox
    Friend WithEvents gbx_Filter As System.Windows.Forms.GroupBox
    Friend WithEvents LibXCombo3 As LibX.LibXCombo
    Friend WithEvents xedfact_status As LibX.XDataGridComboBoxColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents xed_status_name As LibX.XEditTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXCombo2 = New LibX.LibXCombo
        Me.DataSet1 = New System.Data.DataSet
        Me.ftfactd = New System.Data.DataTable
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
        Me.fecini = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.rdb_Contado = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.xdt_FechaFin = New LibX.LibxDateTimePicker
        Me.xdt_FechaInicio = New LibX.LibxDateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.xlk_bus_name = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.xlk_cust_name = New LibX.LibXLookup
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.cust_name = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.txtitem_name = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.xlk_item_name = New LibX.LibXLookup
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.rdb_Credito = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.xlk_vend_code = New LibX.LibXLookup
        Me.vend_name = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
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
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.xlnk_cust_code = New LibX.XDataGridLinkColumn
        Me.xlnk_bus_name = New LibX.XDataGridLinkColumn
        Me.xbln_fact_cond = New LibX.XDataGridBoolColumn
        Me.xed_status_name = New LibX.XEditTextBoxColumn
        Me.xedfact_status = New LibX.XDataGridComboBoxColumn
        Me.xlnk_fact_total = New LibX.XDataGridLinkColumn
        Me.xedSerial_no = New LibX.XEditTextBoxColumn
        Me.xedSerial_afect = New LibX.XEditTextBoxColumn
        Me.gbx_Filter = New System.Windows.Forms.GroupBox
        Me.chk_Devoluciones = New System.Windows.Forms.CheckBox
        Me.chk_contado = New System.Windows.Forms.CheckBox
        Me.lbldevoluciones = New System.Windows.Forms.Label
        Me.lblContado = New System.Windows.Forms.Label
        Me.chk_credito = New System.Windows.Forms.CheckBox
        Me.lblCredito = New System.Windows.Forms.Label
        Me.lblServicios = New System.Windows.Forms.Label
        Me.chk_servicios = New System.Windows.Forms.CheckBox
        Me.btnVisualizar = New System.Windows.Forms.Button
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.btnPagos = New System.Windows.Forms.Button
        Me.btnCliente = New System.Windows.Forms.Button
        Me.btnCobros = New System.Windows.Forms.Button
        Me.btnRelacionado = New System.Windows.Forms.Button
        Me.btnSeries = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactd, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.LibXCombo2)
        Me.GroupBox1.Controls.Add(Me.rdb_Contado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaFin)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaInicio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xlk_bus_name)
        Me.GroupBox1.Controls.Add(Me.xlk_cust_name)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.cust_name)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.txtitem_name)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.xlk_item_name)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.rdb_Credito)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.xlk_vend_code)
        Me.GroupBox1.Controls.Add(Me.vend_name)
        Me.GroupBox1.Controls.Add(Me.TextBox11)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio"
        '
        'LibXCombo2
        '
        Me.LibXCombo2.AllowDefaultSort = True
        Me.LibXCombo2.bound = True
        Me.LibXCombo2.currValue = Nothing
        Me.LibXCombo2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.fact_status"))
        Me.LibXCombo2.DefaultWhereString = Nothing
        Me.LibXCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo2.EditInitialValue = Nothing
        Me.LibXCombo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.FindInitialValue = Nothing
        Me.LibXCombo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.IgnoreRequiered = False
        Me.LibXCombo2.Items.AddRange(New Object() {"0-Anulada", "1-En Almacen", "2-En Caja", "3-Despachada"})
        Me.LibXCombo2.Location = New System.Drawing.Point(528, 16)
        Me.LibXCombo2.LookupKeyDisplayFields = Nothing
        Me.LibXCombo2.LookupKeyField = Nothing
        Me.LibXCombo2.LookupTableName = Nothing
        Me.LibXCombo2.Name = "LibXCombo2"
        Me.LibXCombo2.NewInitialValue = Nothing
        Me.LibXCombo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.Requiered = False
        Me.LibXCombo2.Required = False
        Me.LibXCombo2.Size = New System.Drawing.Size(128, 21)
        Me.LibXCombo2.SqlString = Nothing
        Me.LibXCombo2.TabIndex = 15
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftfactd, Me.DataTable1})
        '
        'ftfactd
        '
        Me.ftfactd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.fecini, Me.DataColumn31, Me.DataColumn1, Me.DataColumn2, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38})
        Me.ftfactd.TableName = "ftfactd"
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "type_code"
        Me.DataColumn16.MaxLength = 3
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.ColumnName = "fact_number"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "fact_date"
        Me.DataColumn18.DataType = GetType(System.DateTime)
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "fact_status"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "phone"
        Me.DataColumn20.MaxLength = 8
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "cust_code"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "serie_number"
        Me.DataColumn22.MaxLength = 255
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "vend_code"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "item_code"
        Me.DataColumn24.MaxLength = 15
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "bus_name"
        Me.DataColumn25.MaxLength = 40
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "cust_name"
        Me.DataColumn26.MaxLength = 60
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "item_name"
        Me.DataColumn27.MaxLength = 100
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "price"
        Me.DataColumn28.DataType = GetType(System.Decimal)
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "fact_total"
        Me.DataColumn29.DataType = GetType(System.Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "fact_cond"
        Me.DataColumn30.DataType = GetType(System.Int16)
        '
        'fecini
        '
        Me.fecini.ColumnName = "FechaIni"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "FechaFin"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "ftserial_no"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "ftserial_afect"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "descto"
        Me.DataColumn35.DataType = GetType(System.Decimal)
        Me.DataColumn35.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "itbis"
        Me.DataColumn36.DataType = GetType(System.Decimal)
        Me.DataColumn36.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "Neto"
        Me.DataColumn37.DataType = GetType(System.Decimal)
        Me.DataColumn37.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DataColumn37.Expression = "fact_total+itbis-descto"
        Me.DataColumn37.ReadOnly = True
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "Estatus"
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34})
        Me.DataTable1.TableName = "ftfactm"
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "type_code"
        Me.DataColumn3.MaxLength = 3
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "fact_number"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "fact_date"
        Me.DataColumn5.DataType = GetType(System.DateTime)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "fact_status"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "phone"
        Me.DataColumn7.MaxLength = 8
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "cust_code"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "serie_number"
        Me.DataColumn9.MaxLength = 255
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "vend_code"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "item_code"
        Me.DataColumn11.MaxLength = 15
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "bus_name"
        Me.DataColumn12.MaxLength = 40
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "cust_name"
        Me.DataColumn13.MaxLength = 60
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "item_name"
        Me.DataColumn14.MaxLength = 100
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "price"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.AllowDBNull = False
        Me.DataColumn32.ColumnName = "fact_total"
        Me.DataColumn32.DataType = GetType(System.Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.AllowDBNull = False
        Me.DataColumn33.ColumnName = "fact_cond"
        Me.DataColumn33.DataType = GetType(System.Int16)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "ftserial_afect"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'rdb_Contado
        '
        Me.rdb_Contado.Location = New System.Drawing.Point(192, 64)
        Me.rdb_Contado.Name = "rdb_Contado"
        Me.rdb_Contado.Size = New System.Drawing.Size(72, 16)
        Me.rdb_Contado.TabIndex = 14
        Me.rdb_Contado.Text = "Contado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(50, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Tipo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.type_code"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Location = New System.Drawing.Point(88, 16)
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
        Me.LibXCombo1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(12, 88)
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
        Me.Label3.Location = New System.Drawing.Point(8, 64)
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
        Me.xdt_FechaFin.FindInitialValue = Nothing
        Me.xdt_FechaFin.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaFin.IgnoreRequiered = False
        Me.xdt_FechaFin.Location = New System.Drawing.Point(88, 88)
        Me.xdt_FechaFin.Name = "xdt_FechaFin"
        Me.xdt_FechaFin.NewInitialValue = Nothing
        Me.xdt_FechaFin.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFin.Requiered = False
        Me.xdt_FechaFin.Size = New System.Drawing.Size(96, 20)
        Me.xdt_FechaFin.TabIndex = 9
        '
        'xdt_FechaInicio
        '
        Me.xdt_FechaInicio.CustomFormat = "dd/MM/yyyy"
        Me.xdt_FechaInicio.EditInitialValue = Nothing
        Me.xdt_FechaInicio.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicio.FindInitialValue = Nothing
        Me.xdt_FechaInicio.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaInicio.IgnoreRequiered = False
        Me.xdt_FechaInicio.Location = New System.Drawing.Point(88, 64)
        Me.xdt_FechaInicio.Name = "xdt_FechaInicio"
        Me.xdt_FechaInicio.NewInitialValue = Nothing
        Me.xdt_FechaInicio.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicio.Requiered = False
        Me.xdt_FechaInicio.Size = New System.Drawing.Size(96, 20)
        Me.xdt_FechaInicio.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(333, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Teléfono:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(305, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cliente Cédito:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_bus_name
        '
        Me.xlk_bus_name.CheckText = Nothing
        Me.xlk_bus_name.DataMember = Nothing
        Me.xlk_bus_name.DataSource = Me.LibXConnector1
        Me.xlk_bus_name.DestParameters = New String() {"phone=phone", "bus_name=cust_name"}
        Me.xlk_bus_name.FilterField = Nothing
        Me.xlk_bus_name.IgnoreFindInBrowseMode = False
        Me.xlk_bus_name.Location = New System.Drawing.Point(640, 64)
        Me.xlk_bus_name.LookCaption = "Clientes Ocasionales"
        Me.xlk_bus_name.Name = "xlk_bus_name"
        Me.xlk_bus_name.ShowMessageNotFound = True
        Me.xlk_bus_name.ShowWarning = False
        Me.xlk_bus_name.Size = New System.Drawing.Size(16, 20)
        Me.xlk_bus_name.SizesColumns = Nothing
        Me.xlk_bus_name.SizesColumnsTab = Nothing
        Me.xlk_bus_name.SqlString = Nothing
        Me.xlk_bus_name.SQLTab = Nothing
        Me.xlk_bus_name.SrcParameters = New String() {"phone=phone"}
        Me.xlk_bus_name.TabIndex = 5
        Me.xlk_bus_name.TableName = "ftcustm"
        Me.xlk_bus_name.UseCopyConnection = False
        Me.xlk_bus_name.UseRowRetrieveEvents = False
        Me.xlk_bus_name.UseTab = False
        Me.xlk_bus_name.VisParameters = New String() {"Teléfono=phone", "Nombre=cust_name", "Compañía=company_name", "Código area=area_code"}
        Me.xlk_bus_name.WhereCondition = Nothing
        Me.xlk_bus_name.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "ftfactm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1})
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
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select distinct ftfactm.type_code,ftfactm.fact_number,ftfactm.fact_date,", "ftfactm.fact_status, ftfactm.phone,ftfactm.cust_code,", "ftseriem.serie_number,ftfactm.vend_code,ftfactd.item_code,", "ftfactm.bus_name,cccustm.cust_name,", "ivitemm.item_name,ftfactd.price,ftfactm.fact_total,ftfactm.fact_cond,ftserial_afe" & _
        "ct", "from ftfactm left outer join ftfactd ", "on ftfactd.ftserial_no = ftfactm.ftserial_no", "left outer join ftseriem", "on ftfactd.ftserial_no = ftseriem.ftserial_no", "and ftfactd.line_no = ftseriem.line_no", "inner join ivitemm on ivitemm.item_code = ftfactd.item_code", "left outer join cccustm", "on cccustm.cust_code = ftfactm.cust_code"}
        Me.LibXDbSourceTable1.TableName = "ftfactm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'xlk_cust_name
        '
        Me.xlk_cust_name.CheckText = Nothing
        Me.xlk_cust_name.DataMember = Nothing
        Me.xlk_cust_name.DataSource = Me.LibXConnector1
        Me.xlk_cust_name.DestParameters = New String() {"cust_code=cust_code", "cust_name=cust_name"}
        Me.xlk_cust_name.FilterField = Nothing
        Me.xlk_cust_name.IgnoreFindInBrowseMode = False
        Me.xlk_cust_name.Location = New System.Drawing.Point(640, 40)
        Me.xlk_cust_name.LookCaption = "Clientes Registrados"
        Me.xlk_cust_name.Name = "xlk_cust_name"
        Me.xlk_cust_name.ShowMessageNotFound = True
        Me.xlk_cust_name.ShowWarning = False
        Me.xlk_cust_name.Size = New System.Drawing.Size(16, 20)
        Me.xlk_cust_name.SizesColumns = Nothing
        Me.xlk_cust_name.SizesColumnsTab = Nothing
        Me.xlk_cust_name.SqlString = Nothing
        Me.xlk_cust_name.SQLTab = Nothing
        Me.xlk_cust_name.SrcParameters = New String() {"cust_code=cust_code"}
        Me.xlk_cust_name.TabIndex = 4
        Me.xlk_cust_name.TableName = "cccustm"
        Me.xlk_cust_name.UseCopyConnection = False
        Me.xlk_cust_name.UseRowRetrieveEvents = False
        Me.xlk_cust_name.UseTab = False
        Me.xlk_cust_name.VisParameters = New String() {"Código=cust_code", "Nombre=cust_name", "Contacto=contact_name"}
        Me.xlk_cust_name.WhereCondition = Nothing
        Me.xlk_cust_name.WhereParameters = Nothing
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.bus_name"))
        Me.TextBox3.Location = New System.Drawing.Point(392, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(248, 20)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.phone"))
        Me.TextBox4.Location = New System.Drawing.Point(392, 88)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(96, 20)
        Me.TextBox4.TabIndex = 2
        Me.TextBox4.Text = ""
        '
        'cust_name
        '
        Me.cust_name.Location = New System.Drawing.Point(448, 40)
        Me.cust_name.Name = "cust_name"
        Me.cust_name.ReadOnly = True
        Me.cust_name.Size = New System.Drawing.Size(192, 20)
        Me.cust_name.TabIndex = 1
        Me.cust_name.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.cust_code"))
        Me.TextBox1.Location = New System.Drawing.Point(392, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(48, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'txtitem_name
        '
        Me.txtitem_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.item_name"))
        Me.txtitem_name.Location = New System.Drawing.Point(392, 112)
        Me.txtitem_name.Name = "txtitem_name"
        Me.txtitem_name.Size = New System.Drawing.Size(248, 20)
        Me.txtitem_name.TabIndex = 3
        Me.txtitem_name.Text = ""
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.item_code"))
        Me.TextBox6.Location = New System.Drawing.Point(88, 112)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(208, 20)
        Me.TextBox6.TabIndex = 2
        Me.TextBox6.Text = ""
        '
        'xlk_item_name
        '
        Me.xlk_item_name.CheckText = Nothing
        Me.xlk_item_name.DataMember = Nothing
        Me.xlk_item_name.DataSource = Me.LibXConnector1
        Me.xlk_item_name.DestParameters = New String() {"item_code=item_code", "item_name=item_name"}
        Me.xlk_item_name.FilterField = Nothing
        Me.xlk_item_name.IgnoreFindInBrowseMode = False
        Me.xlk_item_name.Location = New System.Drawing.Point(640, 112)
        Me.xlk_item_name.LookCaption = "Productos"
        Me.xlk_item_name.Name = "xlk_item_name"
        Me.xlk_item_name.ShowMessageNotFound = True
        Me.xlk_item_name.ShowWarning = False
        Me.xlk_item_name.Size = New System.Drawing.Size(16, 20)
        Me.xlk_item_name.SizesColumns = Nothing
        Me.xlk_item_name.SizesColumnsTab = Nothing
        Me.xlk_item_name.SqlString = Nothing
        Me.xlk_item_name.SQLTab = Nothing
        Me.xlk_item_name.SrcParameters = New String() {"item_code=item_code"}
        Me.xlk_item_name.TabIndex = 5
        Me.xlk_item_name.TableName = "ivitemm"
        Me.xlk_item_name.UseCopyConnection = False
        Me.xlk_item_name.UseRowRetrieveEvents = False
        Me.xlk_item_name.UseTab = False
        Me.xlk_item_name.VisParameters = New String() {"Código=item_code", "Nombre=item_name"}
        Me.xlk_item_name.WhereCondition = Nothing
        Me.xlk_item_name.WhereParameters = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(26, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Producto:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(2, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Serie Número:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.serie_number"))
        Me.TextBox7.Location = New System.Drawing.Point(88, 136)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(208, 20)
        Me.TextBox7.TabIndex = 2
        Me.TextBox7.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(312, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Precio Venta:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.price"))
        Me.TextBox8.Location = New System.Drawing.Point(392, 136)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(96, 20)
        Me.TextBox8.TabIndex = 2
        Me.TextBox8.Text = ""
        '
        'rdb_Credito
        '
        Me.rdb_Credito.Location = New System.Drawing.Point(192, 88)
        Me.rdb_Credito.Name = "rdb_Credito"
        Me.rdb_Credito.Size = New System.Drawing.Size(64, 16)
        Me.rdb_Credito.TabIndex = 14
        Me.rdb_Credito.Text = "Crédito"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(472, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Estatus:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_number"))
        Me.TextBox9.Location = New System.Drawing.Point(392, 16)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(64, 20)
        Me.TextBox9.TabIndex = 2
        Me.TextBox9.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(312, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Doc. Número:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_vend_code
        '
        Me.xlk_vend_code.CheckText = Nothing
        Me.xlk_vend_code.DataMember = Nothing
        Me.xlk_vend_code.DataSource = Me.LibXConnector1
        Me.xlk_vend_code.DestParameters = New String() {"vend_code=vend_code", "vend_name=vend_name"}
        Me.xlk_vend_code.FilterField = Nothing
        Me.xlk_vend_code.IgnoreFindInBrowseMode = False
        Me.xlk_vend_code.Location = New System.Drawing.Point(288, 40)
        Me.xlk_vend_code.LookCaption = "Vendedores"
        Me.xlk_vend_code.Name = "xlk_vend_code"
        Me.xlk_vend_code.ShowMessageNotFound = True
        Me.xlk_vend_code.ShowWarning = False
        Me.xlk_vend_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_vend_code.SizesColumns = Nothing
        Me.xlk_vend_code.SizesColumnsTab = Nothing
        Me.xlk_vend_code.SqlString = Nothing
        Me.xlk_vend_code.SQLTab = Nothing
        Me.xlk_vend_code.SrcParameters = New String() {"vend_code=vend_code"}
        Me.xlk_vend_code.TabIndex = 4
        Me.xlk_vend_code.TableName = "ftvendm"
        Me.xlk_vend_code.UseCopyConnection = False
        Me.xlk_vend_code.UseRowRetrieveEvents = False
        Me.xlk_vend_code.UseTab = False
        Me.xlk_vend_code.VisParameters = New String() {"Código=vend_code", "Nombre=vend_name"}
        Me.xlk_vend_code.WhereCondition = Nothing
        Me.xlk_vend_code.WhereParameters = Nothing
        '
        'vend_name
        '
        Me.vend_name.Location = New System.Drawing.Point(128, 40)
        Me.vend_name.Name = "vend_name"
        Me.vend_name.ReadOnly = True
        Me.vend_name.Size = New System.Drawing.Size(160, 20)
        Me.vend_name.TabIndex = 1
        Me.vend_name.Text = ""
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.vend_code"))
        Me.TextBox11.Location = New System.Drawing.Point(88, 40)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(32, 20)
        Me.TextBox11.TabIndex = 0
        Me.TextBox11.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(23, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Vendedor:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(336, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Nombre:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(317, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 16)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Descripción:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXGrid1
        '
        Me.LibXGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = True
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Resultados de Busquedas"
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.Controls.Add(Me.LibXCombo3)
        Me.LibXGrid1.DataMember = "ftfactd"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = True
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 200)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(784, 280)
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
        Me.LibXCombo3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactd.fact_status"))
        Me.LibXCombo3.DefaultWhereString = Nothing
        Me.LibXCombo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo3.EditInitialValue = Nothing
        Me.LibXCombo3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
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
        Me.LibXCombo3.TabIndex = 16
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.HighlightText
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.xlnk_type_code, Me.xlnk_fact_number, Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn3, Me.xlnk_cust_code, Me.xlnk_bus_name, Me.xbln_fact_cond, Me.xed_status_name, Me.xedfact_status, Me.xlnk_fact_total, Me.xedSerial_no, Me.xedSerial_afect})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ftfactd"
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
        Me.xlnk_type_code.UseCustomCellFormat = True
        Me.xlnk_type_code.Width = 35
        '
        'xlnk_fact_number
        '
        Me.xlnk_fact_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xlnk_fact_number.Format = ""
        Me.xlnk_fact_number.FormatInfo = Nothing
        Me.xlnk_fact_number.HeaderText = "Número"
        Me.xlnk_fact_number.ImageList = Nothing
        Me.xlnk_fact_number.isReadOnly = False
        Me.xlnk_fact_number.MappingName = "fact_number"
        Me.xlnk_fact_number.MaxLength = 32767
        Me.xlnk_fact_number.UseCustomCellFormat = True
        Me.xlnk_fact_number.Width = 50
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Fecha"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "fact_date"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.UseCustomCellFormat = True
        Me.XEditTextBoxColumn1.Width = 65
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Vendedor"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "vend_code"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.UseCustomCellFormat = True
        Me.XEditTextBoxColumn2.Width = 50
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
        Me.XEditTextBoxColumn3.UseCustomCellFormat = True
        Me.XEditTextBoxColumn3.Width = 75
        '
        'xlnk_cust_code
        '
        Me.xlnk_cust_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xlnk_cust_code.Format = ""
        Me.xlnk_cust_code.FormatInfo = Nothing
        Me.xlnk_cust_code.HeaderText = "No. Cliente"
        Me.xlnk_cust_code.ImageList = Nothing
        Me.xlnk_cust_code.isReadOnly = False
        Me.xlnk_cust_code.MappingName = "cust_code"
        Me.xlnk_cust_code.MaxLength = 32767
        Me.xlnk_cust_code.UseCustomCellFormat = True
        Me.xlnk_cust_code.Width = 75
        '
        'xlnk_bus_name
        '
        Me.xlnk_bus_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xlnk_bus_name.Format = ""
        Me.xlnk_bus_name.FormatInfo = Nothing
        Me.xlnk_bus_name.HeaderText = "Nombre del Cliente"
        Me.xlnk_bus_name.ImageList = Nothing
        Me.xlnk_bus_name.isReadOnly = False
        Me.xlnk_bus_name.MappingName = "bus_name"
        Me.xlnk_bus_name.MaxLength = 32767
        Me.xlnk_bus_name.UseCustomCellFormat = True
        Me.xlnk_bus_name.Width = 250
        '
        'xbln_fact_cond
        '
        Me.xbln_fact_cond.FalseValue = CType(1, Short)
        Me.xbln_fact_cond.HeaderText = "Crédito"
        Me.xbln_fact_cond.MappingName = "fact_cond"
        Me.xbln_fact_cond.NullValue = 0
        Me.xbln_fact_cond.TrueValue = CType(2, Short)
        Me.xbln_fact_cond.UseCustomCellFormat = True
        Me.xbln_fact_cond.Width = 50
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
        Me.xedfact_status.MappingName = "fact_status"
        Me.xedfact_status.Width = 0
        '
        'xlnk_fact_total
        '
        Me.xlnk_fact_total.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xlnk_fact_total.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xlnk_fact_total.Format = "###,###,###.00"
        Me.xlnk_fact_total.FormatInfo = Nothing
        Me.xlnk_fact_total.HeaderText = "Monto"
        Me.xlnk_fact_total.ImageList = Nothing
        Me.xlnk_fact_total.isReadOnly = False
        Me.xlnk_fact_total.MappingName = "fact_total"
        Me.xlnk_fact_total.MaxLength = 32767
        Me.xlnk_fact_total.UseCustomCellFormat = True
        Me.xlnk_fact_total.Width = 75
        '
        'xedSerial_no
        '
        Me.xedSerial_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xedSerial_no.Format = ""
        Me.xedSerial_no.FormatInfo = Nothing
        Me.xedSerial_no.ImageList = Nothing
        Me.xedSerial_no.isReadOnly = False
        Me.xedSerial_no.MappingName = "ftserial_no"
        Me.xedSerial_no.MaxLength = 32767
        Me.xedSerial_no.UseCustomCellFormat = False
        Me.xedSerial_no.Width = 0
        '
        'xedSerial_afect
        '
        Me.xedSerial_afect.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xedSerial_afect.Format = ""
        Me.xedSerial_afect.FormatInfo = Nothing
        Me.xedSerial_afect.ImageList = Nothing
        Me.xedSerial_afect.isReadOnly = False
        Me.xedSerial_afect.MappingName = "ftserial_afect"
        Me.xedSerial_afect.MaxLength = 32767
        Me.xedSerial_afect.UseCustomCellFormat = False
        Me.xedSerial_afect.Width = 0
        '
        'gbx_Filter
        '
        Me.gbx_Filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filter.Controls.Add(Me.chk_Devoluciones)
        Me.gbx_Filter.Controls.Add(Me.chk_contado)
        Me.gbx_Filter.Controls.Add(Me.lbldevoluciones)
        Me.gbx_Filter.Controls.Add(Me.lblContado)
        Me.gbx_Filter.Controls.Add(Me.chk_credito)
        Me.gbx_Filter.Controls.Add(Me.lblCredito)
        Me.gbx_Filter.Controls.Add(Me.lblServicios)
        Me.gbx_Filter.Controls.Add(Me.chk_servicios)
        Me.gbx_Filter.Location = New System.Drawing.Point(680, 24)
        Me.gbx_Filter.Name = "gbx_Filter"
        Me.gbx_Filter.Size = New System.Drawing.Size(112, 168)
        Me.gbx_Filter.TabIndex = 2
        Me.gbx_Filter.TabStop = False
        Me.gbx_Filter.Text = "Filtrar"
        '
        'chk_Devoluciones
        '
        Me.chk_Devoluciones.Location = New System.Drawing.Point(8, 112)
        Me.chk_Devoluciones.Name = "chk_Devoluciones"
        Me.chk_Devoluciones.Size = New System.Drawing.Size(80, 16)
        Me.chk_Devoluciones.TabIndex = 12
        Me.chk_Devoluciones.Text = "Devoluciones"
        '
        'chk_contado
        '
        Me.chk_contado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk_contado.Location = New System.Drawing.Point(8, 16)
        Me.chk_contado.Name = "chk_contado"
        Me.chk_contado.Size = New System.Drawing.Size(96, 16)
        Me.chk_contado.TabIndex = 11
        Me.chk_contado.Text = "Facturas Cont."
        '
        'lbldevoluciones
        '
        Me.lbldevoluciones.BackColor = System.Drawing.Color.Pink
        Me.lbldevoluciones.Location = New System.Drawing.Point(8, 128)
        Me.lbldevoluciones.Name = "lbldevoluciones"
        Me.lbldevoluciones.Size = New System.Drawing.Size(56, 8)
        Me.lbldevoluciones.TabIndex = 10
        '
        'lblContado
        '
        Me.lblContado.BackColor = System.Drawing.Color.LightCyan
        Me.lblContado.Location = New System.Drawing.Point(8, 32)
        Me.lblContado.Name = "lblContado"
        Me.lblContado.Size = New System.Drawing.Size(56, 8)
        Me.lblContado.TabIndex = 9
        '
        'chk_credito
        '
        Me.chk_credito.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk_credito.Location = New System.Drawing.Point(8, 48)
        Me.chk_credito.Name = "chk_credito"
        Me.chk_credito.Size = New System.Drawing.Size(96, 16)
        Me.chk_credito.TabIndex = 11
        Me.chk_credito.Text = "Facturas Cred."
        '
        'lblCredito
        '
        Me.lblCredito.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblCredito.Location = New System.Drawing.Point(8, 64)
        Me.lblCredito.Name = "lblCredito"
        Me.lblCredito.Size = New System.Drawing.Size(56, 8)
        Me.lblCredito.TabIndex = 9
        '
        'lblServicios
        '
        Me.lblServicios.BackColor = System.Drawing.Color.White
        Me.lblServicios.Location = New System.Drawing.Point(8, 96)
        Me.lblServicios.Name = "lblServicios"
        Me.lblServicios.Size = New System.Drawing.Size(56, 8)
        Me.lblServicios.TabIndex = 9
        '
        'chk_servicios
        '
        Me.chk_servicios.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk_servicios.Location = New System.Drawing.Point(8, 80)
        Me.chk_servicios.Name = "chk_servicios"
        Me.chk_servicios.Size = New System.Drawing.Size(96, 16)
        Me.chk_servicios.TabIndex = 11
        Me.chk_servicios.Text = "Facturas Serv."
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVisualizar.Location = New System.Drawing.Point(8, 511)
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(804, 24)
        Me.LibXNavigator1.TabIndex = 4
        '
        'btnPagos
        '
        Me.btnPagos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPagos.Location = New System.Drawing.Point(88, 511)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.TabIndex = 3
        Me.btnPagos.Text = "Pagos"
        '
        'btnCliente
        '
        Me.btnCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCliente.Location = New System.Drawing.Point(168, 511)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.TabIndex = 3
        Me.btnCliente.Text = "Cliente"
        '
        'btnCobros
        '
        Me.btnCobros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCobros.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCobros.Location = New System.Drawing.Point(248, 511)
        Me.btnCobros.Name = "btnCobros"
        Me.btnCobros.TabIndex = 3
        Me.btnCobros.Text = "Cobro"
        '
        'btnRelacionado
        '
        Me.btnRelacionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRelacionado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRelacionado.Location = New System.Drawing.Point(328, 511)
        Me.btnRelacionado.Name = "btnRelacionado"
        Me.btnRelacionado.TabIndex = 3
        Me.btnRelacionado.Text = "Relacionado"
        '
        'btnSeries
        '
        Me.btnSeries.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSeries.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSeries.Location = New System.Drawing.Point(408, 511)
        Me.btnSeries.Name = "btnSeries"
        Me.btnSeries.TabIndex = 3
        Me.btnSeries.Text = "Series"
        '
        'c_ftdocs01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(804, 549)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.gbx_Filter)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPagos)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.btnCobros)
        Me.Controls.Add(Me.btnRelacionado)
        Me.Controls.Add(Me.btnSeries)
        Me.Name = "c_ftdocs01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consultar Movimientos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactd, System.ComponentModel.ISupportInitialize).EndInit()
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
                '// limpiar las condiciones unbound
                rdb_Contado.Checked = False
                rdb_Credito.Checked = False

                '// Asignar la fecha de busqueda desde el primero del mes y ano
                '// acutal hasta la fecha actual
                xdt_FechaFin.Value = LibX.Data.Manager.Connection.GetDate
                xdt_FechaInicio.Value = DateSerial(LibX.Data.Manager.Connection.GetDate.Year, LibX.Data.Manager.Connection.GetDate.Month, 1)

                '// Limpiar los resultados anteriores
                ftfactd.Rows.Clear()
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

            SelectStmt = String.Concat("select distinct ftfactm.type_code,ftfactm.fact_number,ftfactm.fact_date,", _
                                       " ftfactm.fact_status, ftfactm.phone,ftfactm.cust_code,", _
                                        " ftfactm.vend_code,ftfactm.bus_name,cccustm.cust_name,", _
                                        " ftfactm.fact_total, ftfactm.fact_cond,ftfactm.ftserial_no,ftfactm.descto,ftfactm.itbis, ", _
                                        "Case fact_status when 1 then  'En Almacen' ", _
                                        " when 2 then 'En Caja' when 3 then 'Despachada' when 0 then ", _
                                        " 'Anulada' End Estatus ", _
                                        " from ftfactm left outer join ftfactd ", _
                                        " on ftfactd.ftserial_no = ftfactm.ftserial_no ", _
                                        " left outer join ftseriem ", _
                                        " on ftfactd.ftserial_no = ftseriem.ftserial_no ", _
                                        " and ftfactd.line_no = ftseriem.line_no ", _
                                        " left outer join ivitemm on ivitemm.item_code = ftfactd.item_code ", _
                                        " left outer join cccustm ", _
                                        " on cccustm.cust_code = ftfactm.cust_code where 1=1 ")

            If Trim(e.Where) <> "" Then
                SelectStmt = SelectStmt.Trim & " and " & e.Where
            End If

            If LibX.IsNull(xdt_FechaInicio.Value) = False Then
                SelectStmt &= " and ftfactm.fact_date between '" & CType(xdt_FechaInicio.Value, Date).ToString(LibX.Data.Manager.GetSaveDateFormat) & _
                              "' and '" & CType(xdt_FechaFin.Value, Date).ToString(LibX.Data.Manager.GetSaveDateFormat) & "'"
            End If

            SelectStmt = oDoc.PrepareSelectStmt(SelectStmt)

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)
            oTable.TableName = "ftfactd"

            DataSet1.Merge(oTable, False, MissingSchemaAction.Ignore)

            LibXConnector1.HasRecords = (oTable.Rows.Count > 0)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Contado.CheckedChanged
        If LibXConnector1.IsEditing Then
            LibXConnector1.CurrentDataRow!fact_cond = 1
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Credito.CheckedChanged
        If LibXConnector1.IsEditing Then
            LibXConnector1.CurrentDataRow!fact_cond = 2
        End If
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click, mnuVisualizar.Click, xlnk_fact_number.LinkeClicked
        Dim xParam As LibX.LibxPrgParams
        Dim xParamAdm As SGT.Administracion.Entidades.Program.ParametrosVizualizar
        Dim xProgram As SGT.Administracion.Entidades.Program
        Try
            xParam = New LibX.LibxPrgParams
            xParamAdm = New SGT.Administracion.Entidades.Program.ParametrosVizualizar
            xProgram = New SGT.Administracion.Entidades.Program

            xParam.AllowDelete = False
            xParam.AllowEdit = False
            xParam.AllowNew = False
            xParam.AllowPrint = True
            xParam.AllowQuery = False

            xParam.Value = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xedSerial_no)
            xParam.initMode = LibX.LibxInitModes.Query
            xParam.WhereToExecute = "ftfactm.ftserial_no = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xedSerial_no)

            xParamAdm.Parametros = xParam
            xParamAdm.TipoDocumento = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_type_code)

            xProgram.Visualizar(xParamAdm)

            '''If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_type_code) = "FCT" Then
            '''    LibX.LibXRunner.Run("i_ftfact01", "FCT")
            '''End If

            '''If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_type_code) = "FTS" Then
            '''    LibX.LibXRunner.Run("i_ftfact02", "FCT")
            '''End If

            '''If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_type_code) = "DVF" Then
            '''    LibX.LibXRunner.Run("i_ftdevm01", "FCT")
            '''End If

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

            xParam.WhereToExecute = "cccustm.cust_code = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_cust_code).ToString

            LibX.App.CurrentPrgParams = xParam

            LibX.LibXRunner.Run("i_custrm01", "CXC")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagos.Click, mnuPagos.Click, xlnk_cust_code.LinkeClicked
        Dim oParam As LibX.LibxPrgParams

        Dim WhereStmt As String
        Try
            oParam = New LibX.LibxPrgParams
            oParam.WhereToExecute = "ccinvcem.type_code = '" & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_type_code).ToString & "'" & _
                                    " and ccinvcem.invce_no = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xlnk_fact_number).ToString
            LibX.App.CurrentPrgParams = oParam

            LibX.LibXRunner.Run("c_ccdocs01", "CXC", True)
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCobros.Click, mnuCobro.Click, xlnk_fact_total.LinkeClicked
        Dim oParam As LibX.LibxPrgParams
        Dim WhereStmt As String
        Try
            oParam = New LibX.LibxPrgParams
            oParam.WhereToExecute = "ftfactm.ftserial_no = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xedSerial_no).ToString
            LibX.App.CurrentPrgParams = oParam

            LibX.LibXRunner.Run("c_ftdocs03", "FCT", True)
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
            oParam.Datos.Add("fact_number", LibXGrid1.GetValue(xlnk_fact_number))
            oParam.WhereToExecute = "ftfactv.ftserial_afect = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xedSerial_no).ToString
            LibX.App.CurrentPrgParams = oParam

            LibX.LibXRunner.Run("c_ftdocs02", "FCT", True)
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub


    Private Sub btnSeries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeries.Click, mnuSeries.Click
        Dim Param As LibX.LibxPrgParams
        Try
            If ftfactd.Rows.Count <= 0 Then
                Exit Sub
            End If

            Param = New LibX.LibxPrgParams


            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "FCT" Then
                With Param
                    .Value = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xedSerial_no)
                End With
                LibX.App.CurrentPrgParams = Param

                LibX.LibXRunner.Run("i_ftserial", "FCT", True)
            End If

            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "DVF" Then
                With Param
                    If LibXConnector1.IsDataEditing Then
                        .Datos.Add("usetransaction", False)
                    End If

                    .Datos.Add("ftserial_no", LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xedSerial_no))
                    .Datos.Add("ftserial_afect", LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, xedSerial_afect))
                End With

                LibX.App.CurrentPrgParams = Param
                LibX.LibXRunner.Run("i_ftserial02", "FCT", True)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub rdb_Contado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rdb_Contado.KeyPress
        Try
            If LibXConnector1.IsEditing Then
                If Asc(e.KeyChar) = Keys.Escape Then
                    rdb_Contado.Checked = False
                    LibXConnector1.CurrentDataRow!fact_cond = DBNull.Value
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub rdb_Credito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rdb_Credito.KeyPress
        Try
            If LibXConnector1.IsEditing Then
                If Asc(e.KeyChar) = Keys.Escape Then
                    rdb_Credito.Checked = False
                    LibXConnector1.CurrentDataRow!fact_cond = DBNull.Value
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try

            btnCliente.Enabled = (e.isEditing = False And ftfactd.Rows.Count > 0)
            btnCobros.Enabled = (e.isEditing = False And ftfactd.Rows.Count > 0)
            btnPagos.Enabled = (e.isEditing = False And ftfactd.Rows.Count > 0)
            btnRelacionado.Enabled = (e.isEditing = False And ftfactd.Rows.Count > 0)
            btnSeries.Enabled = (e.isEditing = False And ftfactd.Rows.Count > 0)
            btnVisualizar.Enabled = (e.isEditing = False And ftfactd.Rows.Count > 0)

            gbx_Filter.Enabled = (e.isEditing = False And ftfactd.Rows.Count > 0)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles LibXGrid1.Navigate

    End Sub

    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid1.CurrentRowChanged
        Try
            If e.row < 0 Then
                Exit Sub
            End If

            If ftfactd.Rows.Count > 0 Then
                btnCliente.Enabled = Not LibX.IsNull(LibXGrid1.GetValue(xlnk_cust_code))
                'btnCobros.Enabled = LibXGrid1.GetValue(xedfact_status) = 3
                btnPagos.Enabled = LibXGrid1.GetValue(xbln_fact_cond) = True
                btnSeries.Enabled = (LibXGrid1.GetValue(xlnk_type_code) = "FCT" OrElse LibXGrid1.GetValue(xlnk_type_code) = "DVF")
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub c_ftdocs01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LibXGrid1.getCurrentGridView.Sort = "type_code,fact_number"
            LibXGrid1.footerOperations.add("type_code", "count(type_code)")
            LibXGrid1.footerOperations.add("fact_total", "sum(fact_total)")

            oDoc = New SGT.Facturacion.Entidades.Documento

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub


    Private Sub xbln_fact_cond_SetCellFormat(ByVal sender As Object, ByVal e As LibX.XDataGridFormatCellEventArgs) Handles xbln_fact_cond.SetCellFormat, XEditTextBoxColumn1.SetCellFormat, XEditTextBoxColumn2.SetCellFormat, XEditTextBoxColumn3.SetCellFormat, xlnk_bus_name.SetCellFormat, xlnk_cust_code.SetCellFormat, xlnk_fact_number.SetCellFormat, xlnk_fact_total.SetCellFormat, xlnk_type_code.SetCellFormat, xed_status_name.SetCellFormat
        Try

            If LibXGrid1.GetValue(e.RowNumber, xlnk_type_code) = "FCT" Then
                If (LibXGrid1.GetValue(e.RowNumber, xbln_fact_cond).ToString.Trim <> "" AndAlso LibXGrid1.GetValue(e.RowNumber, xbln_fact_cond) = False) Then
                    e.BackColor = lblContado.BackColor
                Else
                    e.BackColor = lblCredito.BackColor
                End If
            End If

            If LibXGrid1.GetValue(e.RowNumber, xlnk_type_code) = "DVF" Then
                e.BackColor = lbldevoluciones.BackColor
            End If

            If LibXGrid1.GetValue(e.RowNumber, xlnk_type_code) = "FTS" Then
                e.BackColor = lblServicios.BackColor
            End If


        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub chk_Facturas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_contado.CheckedChanged, chk_credito.CheckedChanged, chk_Devoluciones.CheckedChanged, chk_servicios.CheckedChanged
        Dim Filter As String = ""
        Try
            If chk_contado.Checked = True And chk_credito.Checked = True Then
                Filter = "(type_code ='FCT' and (fact_cond=1 or fact_cond=2))"

            ElseIf chk_contado.Checked = True Then
                Filter = "(type_code ='FCT' and fact_cond=1)"

            ElseIf chk_credito.Checked = True Then
                Filter = "(type_code ='FCT' and fact_cond=2)"

            End If

            If chk_Devoluciones.Checked = True Then
                If Filter.Trim.Length > 0 Then
                    Filter &= " or (type_code = 'DVF')"
                Else
                    Filter = " (type_code = 'DVF')"
                End If
            End If

            If chk_servicios.Checked = True Then
                If Filter.Trim.Length > 0 Then
                    Filter &= " or (type_code = 'FTS')"
                Else
                    Filter = " (type_code = 'FTS')"
                End If
            End If

            LibXGrid1.getCurrentGridView.RowFilter = Filter
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub ftfactd_RowChanged(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles ftfactd.RowChanged
        Try
            Dim idx As Integer
            If e.Action = DataRowAction.Add Then


            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class
