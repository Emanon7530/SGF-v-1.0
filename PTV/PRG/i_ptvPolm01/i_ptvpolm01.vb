Public Class i_ptvpolm01

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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents pvpolimh As LibX.LibXDbSourceTable
    Friend WithEvents pvpolimd As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents LabelTipoVenta As System.Windows.Forms.Label
    Friend WithEvents xlk_Tipo_Venta As LibX.LibXLookup
    Friend WithEvents LabelTipoVenta1 As System.Windows.Forms.Label
    Friend WithEvents xlk_Tipo_Venta1 As LibX.LibXLookup
    Friend WithEvents xlk_Tipo_Venta3 As LibX.LibXLookup
    Friend WithEvents LabelTipoVenta3 As System.Windows.Forms.Label
    Friend WithEvents LabelCliente As System.Windows.Forms.Label
    Friend WithEvents xlk_Cliente As LibX.LibXLookup
    Friend WithEvents xlk_TipoCliente As LibX.LibXLookup
    Friend WithEvents xlk_itemcode As LibX.LibXLookup
    Friend WithEvents xlk_Almacen As LibX.LibXLookup
    Friend WithEvents xlk_Categoria As LibX.LibXLookup
    Friend WithEvents xlk_Suplidor As LibX.LibXLookup
    Friend WithEvents xlk_subcategoria As LibX.LibXLookup
    Friend WithEvents xlk_marca As LibX.LibXLookup
    Friend WithEvents XDataGridComboBoxColumn1 As LibX.XDataGridComboBoxColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents cmbHoraFin As LibX.LibXCombo
    Friend WithEvents cmbHoraIni As LibX.LibXCombo
    Friend WithEvents dtpFechaFin As LibX.LibxDateTimePicker
    Friend WithEvents dtpFechaIni As LibX.LibxDateTimePicker
    Friend WithEvents LibXCombo2 As LibX.LibXCombo
    Friend WithEvents txtTipoVenta2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoVenta3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoVenta1 As System.Windows.Forms.TextBox
    Friend WithEvents DataTable1 As System.Data.DataTable
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
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents LibXCombo3 As LibX.LibXCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXCombo3 = New LibX.LibXCombo
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
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
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.LibXCombo2 = New LibX.LibXCombo
        Me.Label23 = New System.Windows.Forms.Label
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.txtTipoVenta2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTipoVenta3 = New System.Windows.Forms.TextBox
        Me.txtTipoVenta1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.xlk_marca = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.pvpolimh = New LibX.LibXDbSourceTable
        Me.pvpolimd = New LibX.LibXDbSourceTable
        Me.Label22 = New System.Windows.Forms.Label
        Me.xlk_Suplidor = New LibX.LibXLookup
        Me.Label13 = New System.Windows.Forms.Label
        Me.xlk_subcategoria = New LibX.LibXLookup
        Me.Label11 = New System.Windows.Forms.Label
        Me.xlk_Categoria = New LibX.LibXLookup
        Me.Label8 = New System.Windows.Forms.Label
        Me.xlk_Almacen = New LibX.LibXLookup
        Me.Label20 = New System.Windows.Forms.Label
        Me.xlk_itemcode = New LibX.LibXLookup
        Me.Label18 = New System.Windows.Forms.Label
        Me.xlk_TipoCliente = New LibX.LibXLookup
        Me.Label16 = New System.Windows.Forms.Label
        Me.xlk_Cliente = New LibX.LibXLookup
        Me.LabelCliente = New System.Windows.Forms.Label
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.xlk_Tipo_Venta1 = New LibX.LibXLookup
        Me.LabelTipoVenta1 = New System.Windows.Forms.Label
        Me.xlk_Tipo_Venta3 = New LibX.LibXLookup
        Me.LabelTipoVenta3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.xlk_Tipo_Venta = New LibX.LibXLookup
        Me.LabelTipoVenta = New System.Windows.Forms.Label
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbHoraFin = New LibX.LibXCombo
        Me.cmbHoraIni = New LibX.LibXCombo
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtpFechaFin = New LibX.LibxDateTimePicker
        Me.dtpFechaIni = New LibX.LibxDateTimePicker
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XDataGridComboBoxColumn1 = New LibX.XDataGridComboBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXCombo3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LibXCombo2)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.TextBox16)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.TextBox15)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.TextBox14)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.txtTipoVenta2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTipoVenta3)
        Me.GroupBox1.Controls.Add(Me.txtTipoVenta1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.xlk_marca)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.xlk_Suplidor)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.xlk_subcategoria)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.xlk_Categoria)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.xlk_Almacen)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.xlk_itemcode)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.xlk_TipoCliente)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.xlk_Cliente)
        Me.GroupBox1.Controls.Add(Me.LabelCliente)
        Me.GroupBox1.Controls.Add(Me.LibxCheckBox1)
        Me.GroupBox1.Controls.Add(Me.xlk_Tipo_Venta1)
        Me.GroupBox1.Controls.Add(Me.LabelTipoVenta1)
        Me.GroupBox1.Controls.Add(Me.xlk_Tipo_Venta3)
        Me.GroupBox1.Controls.Add(Me.LabelTipoVenta3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xlk_Tipo_Venta)
        Me.GroupBox1.Controls.Add(Me.LabelTipoVenta)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 352)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LibXCombo3
        '
        Me.LibXCombo3.AllowDefaultSort = True
        Me.LibXCombo3.bound = True
        Me.LibXCombo3.currValue = Nothing
        Me.LibXCombo3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "pvpolimh.tipo_poli"))
        Me.LibXCombo3.DefaultWhereString = Nothing
        Me.LibXCombo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo3.EditInitialValue = Nothing
        Me.LibXCombo3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo3.FindInitialValue = Nothing
        Me.LibXCombo3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo3.IgnoreRequiered = False
        Me.LibXCombo3.Items.AddRange(New Object() {"D-Descuento", "O-Oferta", "P-Precio"})
        Me.LibXCombo3.Location = New System.Drawing.Point(88, 312)
        Me.LibXCombo3.LookupKeyDisplayFields = Nothing
        Me.LibXCombo3.LookupKeyField = Nothing
        Me.LibXCombo3.LookupTableName = Nothing
        Me.LibXCombo3.Name = "LibXCombo3"
        Me.LibXCombo3.NewInitialValue = Nothing
        Me.LibXCombo3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo3.Requiered = True
        Me.LibXCombo3.Required = False
        Me.LibXCombo3.Size = New System.Drawing.Size(368, 21)
        Me.LibXCombo3.SqlString = Nothing
        Me.LibXCombo3.TabIndex = 84
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"poli_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "pvpolimh"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "poli_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "tipo_poli"
        Me.DataColumn2.MaxLength = 1
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "nivel_poli"
        Me.DataColumn3.DataType = GetType(System.Int16)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "aplica_domisi"
        Me.DataColumn4.MaxLength = 1
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "tipo_venta"
        Me.DataColumn5.MaxLength = 3
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "tipo_venta2"
        Me.DataColumn6.MaxLength = 3
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "tipo_venta3"
        Me.DataColumn7.MaxLength = 3
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Cliente"
        Me.DataColumn8.MaxLength = 4
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "tipo_cliente"
        Me.DataColumn9.MaxLength = 2
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "item_code"
        Me.DataColumn10.MaxLength = 6
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "unidad"
        Me.DataColumn11.MaxLength = 4
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "wh_code"
        Me.DataColumn12.MaxLength = 2
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "group_code"
        Me.DataColumn13.MaxLength = 3
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sgroup_code"
        Me.DataColumn14.MaxLength = 4
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "vend_code"
        Me.DataColumn15.MaxLength = 4
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "brand_code"
        Me.DataColumn16.MaxLength = 4
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "fecha_ini"
        Me.DataColumn17.DataType = GetType(System.DateTime)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "fecha_fin"
        Me.DataColumn18.DataType = GetType(System.DateTime)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "hora_ini"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "hora_fin"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "usuario"
        Me.DataColumn21.MaxLength = 8
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "qty_oferrta"
        Me.DataColumn22.DataType = GetType(System.Int16)
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26})
        Me.DataTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"poli_code", "line_no"}, True)})
        Me.DataTable2.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn23, Me.DataColumn24}
        Me.DataTable2.TableName = "pvpolimd"
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "poli_code"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.ColumnName = "line_no"
        Me.DataColumn24.DataType = GetType(System.Int16)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "qty_poli"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "precio_poli"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(16, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Tipo Politica :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo2
        '
        Me.LibXCombo2.AllowDefaultSort = True
        Me.LibXCombo2.bound = True
        Me.LibXCombo2.currValue = Nothing
        Me.LibXCombo2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "pvpolimh.nivel_poli"))
        Me.LibXCombo2.DefaultWhereString = Nothing
        Me.LibXCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo2.EditInitialValue = Nothing
        Me.LibXCombo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.FindInitialValue = Nothing
        Me.LibXCombo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.IgnoreRequiered = False
        Me.LibXCombo2.Items.AddRange(New Object() {"1-1", "2-2", "3-3", "4-4", "5-5", "6-6", "7-7", "8-8", "9-9"})
        Me.LibXCombo2.Location = New System.Drawing.Point(88, 24)
        Me.LibXCombo2.LookupKeyDisplayFields = Nothing
        Me.LibXCombo2.LookupKeyField = Nothing
        Me.LibXCombo2.LookupTableName = Nothing
        Me.LibXCombo2.Name = "LibXCombo2"
        Me.LibXCombo2.NewInitialValue = Nothing
        Me.LibXCombo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.Requiered = True
        Me.LibXCombo2.Required = False
        Me.LibXCombo2.Size = New System.Drawing.Size(80, 21)
        Me.LibXCombo2.SqlString = Nothing
        Me.LibXCombo2.TabIndex = 82
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label23.Location = New System.Drawing.Point(40, 288)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(39, 16)
        Me.Label23.TabIndex = 67
        Me.Label23.Text = "Marca:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvpolimh.brand_code"))
        Me.TextBox10.Location = New System.Drawing.Point(88, 288)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(48, 20)
        Me.TextBox10.TabIndex = 66
        Me.TextBox10.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(32, 264)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 16)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Suplidor:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvpolimh.vend_code"))
        Me.TextBox9.Location = New System.Drawing.Point(88, 264)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(48, 20)
        Me.TextBox9.TabIndex = 62
        Me.TextBox9.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(8, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 16)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Sub-Categoría:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvpolimh.sgroup_code"))
        Me.TextBox7.Location = New System.Drawing.Point(88, 240)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(48, 20)
        Me.TextBox7.TabIndex = 58
        Me.TextBox7.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(32, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Categoría:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvpolimh.group_code"))
        Me.TextBox6.Location = New System.Drawing.Point(88, 216)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(48, 20)
        Me.TextBox6.TabIndex = 54
        Me.TextBox6.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Location = New System.Drawing.Point(32, 192)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 16)
        Me.Label21.TabIndex = 51
        Me.Label21.Text = "Almacen:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvpolimh.wh_code"))
        Me.TextBox16.Location = New System.Drawing.Point(88, 192)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(48, 20)
        Me.TextBox16.TabIndex = 50
        Me.TextBox16.Text = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label19.Location = New System.Drawing.Point(32, 168)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 16)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "Producto:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvpolimh.item_code"))
        Me.TextBox15.Location = New System.Drawing.Point(88, 168)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(48, 20)
        Me.TextBox15.TabIndex = 46
        Me.TextBox15.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Location = New System.Drawing.Point(16, 144)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 16)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Tipo Cliente:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvpolimh.tipo_cliente"))
        Me.TextBox14.Location = New System.Drawing.Point(88, 144)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(48, 20)
        Me.TextBox14.TabIndex = 42
        Me.TextBox14.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(40, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 16)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Cliente:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvpolimh.Cliente"))
        Me.TextBox13.Location = New System.Drawing.Point(88, 120)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(48, 20)
        Me.TextBox13.TabIndex = 38
        Me.TextBox13.Text = ""
        '
        'txtTipoVenta2
        '
        Me.txtTipoVenta2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvpolimh.tipo_venta"))
        Me.txtTipoVenta2.Location = New System.Drawing.Point(88, 72)
        Me.txtTipoVenta2.Name = "txtTipoVenta2"
        Me.txtTipoVenta2.Size = New System.Drawing.Size(48, 20)
        Me.txtTipoVenta2.TabIndex = 2
        Me.txtTipoVenta2.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(16, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Tipo Venta 2:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(48, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Nivel:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(16, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tipo Venta 3:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTipoVenta3
        '
        Me.txtTipoVenta3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvpolimh.tipo_venta3"))
        Me.txtTipoVenta3.Location = New System.Drawing.Point(88, 96)
        Me.txtTipoVenta3.Name = "txtTipoVenta3"
        Me.txtTipoVenta3.Size = New System.Drawing.Size(48, 20)
        Me.txtTipoVenta3.TabIndex = 3
        Me.txtTipoVenta3.Text = ""
        '
        'txtTipoVenta1
        '
        Me.txtTipoVenta1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvpolimh.tipo_venta"))
        Me.txtTipoVenta1.Location = New System.Drawing.Point(88, 48)
        Me.txtTipoVenta1.Name = "txtTipoVenta1"
        Me.txtTipoVenta1.Size = New System.Drawing.Size(48, 20)
        Me.txtTipoVenta1.TabIndex = 1
        Me.txtTipoVenta1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(24, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Venta:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "pvpolimd.tipo_poli"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Items.AddRange(New Object() {"D-Descuento", "O-Oferta", "P-Precio"})
        Me.LibXCombo1.Location = New System.Drawing.Point(88, 312)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = Nothing
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(352, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.TabIndex = 70
        '
        'xlk_marca
        '
        Me.xlk_marca.CheckText = Nothing
        Me.xlk_marca.DataMember = Nothing
        Me.xlk_marca.DataSource = Me.LibXConnector1
        Me.xlk_marca.DestParameters = New String() {"TextBox10=brand_code", "Label22=brand_name"}
        Me.xlk_marca.FilterField = Nothing
        Me.xlk_marca.IgnoreFindInBrowseMode = False
        Me.xlk_marca.Location = New System.Drawing.Point(440, 288)
        Me.xlk_marca.LookCaption = Nothing
        Me.xlk_marca.Name = "xlk_marca"
        Me.xlk_marca.ShowMessageNotFound = True
        Me.xlk_marca.ShowWarning = False
        Me.xlk_marca.Size = New System.Drawing.Size(16, 20)
        Me.xlk_marca.SizesColumns = Nothing
        Me.xlk_marca.SizesColumnsTab = Nothing
        Me.xlk_marca.SqlString = Nothing
        Me.xlk_marca.SQLTab = Nothing
        Me.xlk_marca.SrcParameters = New String() {"brand_code=brand_code"}
        Me.xlk_marca.TabIndex = 69
        Me.xlk_marca.TableName = "ivbrandm"
        Me.xlk_marca.UseCopyConnection = False
        Me.xlk_marca.UseRowRetrieveEvents = False
        Me.xlk_marca.UseTab = False
        Me.xlk_marca.VisParameters = New String() {"Código=brand_code", "Descripción=brand_name"}
        Me.xlk_marca.WhereCondition = Nothing
        Me.xlk_marca.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "pvpolimh"
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
        Me.LibXConnector1.ReportName = Nothing
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.pvpolimh, Me.pvpolimd})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'pvpolimh
        '
        Me.pvpolimh.AllowDelete = True
        Me.pvpolimh.AllowEdit = True
        Me.pvpolimh.AllowNew = True
        Me.pvpolimh.AutoIncrementSerial = False
        Me.pvpolimh.CustomDbUpdate = False
        Me.pvpolimh.DeleteOrder = 0
        Me.pvpolimh.FillOnQuery = True
        Me.pvpolimh.FillOnRowChange = False
        Me.pvpolimh.HeaderIsOnGrid = False
        Me.pvpolimh.InsertOrder = 0
        Me.pvpolimh.IsDetail = False
        Me.pvpolimh.KeyFields = Nothing
        Me.pvpolimh.LineColName = Nothing
        Me.pvpolimh.MasterDetailRelation = New String() {Nothing}
        Me.pvpolimh.MasterTableName = Nothing
        Me.pvpolimh.SerialColumnName = "poli_code"
        Me.pvpolimh.Sort = Nothing
        Me.pvpolimh.Source = Nothing
        Me.pvpolimh.TableName = "pvpolimh"
        Me.pvpolimh.UpdateOrder = 0
        Me.pvpolimh.UseRowRetrieve = False
        '
        'pvpolimd
        '
        Me.pvpolimd.AllowDelete = True
        Me.pvpolimd.AllowEdit = True
        Me.pvpolimd.AllowNew = True
        Me.pvpolimd.AutoIncrementSerial = False
        Me.pvpolimd.CustomDbUpdate = False
        Me.pvpolimd.DeleteOrder = 0
        Me.pvpolimd.FillOnQuery = True
        Me.pvpolimd.FillOnRowChange = True
        Me.pvpolimd.HeaderIsOnGrid = False
        Me.pvpolimd.InsertOrder = 0
        Me.pvpolimd.IsDetail = True
        Me.pvpolimd.KeyFields = Nothing
        Me.pvpolimd.LineColName = "LINE_NO"
        Me.pvpolimd.MasterDetailRelation = New String() {"poli_code=poli_code"}
        Me.pvpolimd.MasterTableName = Nothing
        Me.pvpolimd.SerialColumnName = Nothing
        Me.pvpolimd.Sort = Nothing
        Me.pvpolimd.Source = Nothing
        Me.pvpolimd.TableName = "pvpolimd"
        Me.pvpolimd.UpdateOrder = 0
        Me.pvpolimd.UseRowRetrieve = False
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Location = New System.Drawing.Point(136, 288)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(304, 20)
        Me.Label22.TabIndex = 68
        '
        'xlk_Suplidor
        '
        Me.xlk_Suplidor.CheckText = Nothing
        Me.xlk_Suplidor.DataMember = Nothing
        Me.xlk_Suplidor.DataSource = Me.LibXConnector1
        Me.xlk_Suplidor.DestParameters = New String() {"TextBox9=prov_code", "Label13=prov_name"}
        Me.xlk_Suplidor.FilterField = Nothing
        Me.xlk_Suplidor.IgnoreFindInBrowseMode = False
        Me.xlk_Suplidor.Location = New System.Drawing.Point(440, 264)
        Me.xlk_Suplidor.LookCaption = Nothing
        Me.xlk_Suplidor.Name = "xlk_Suplidor"
        Me.xlk_Suplidor.ShowMessageNotFound = True
        Me.xlk_Suplidor.ShowWarning = False
        Me.xlk_Suplidor.Size = New System.Drawing.Size(16, 20)
        Me.xlk_Suplidor.SizesColumns = Nothing
        Me.xlk_Suplidor.SizesColumnsTab = Nothing
        Me.xlk_Suplidor.SqlString = Nothing
        Me.xlk_Suplidor.SQLTab = Nothing
        Me.xlk_Suplidor.SrcParameters = New String() {"vend_code=prov_code"}
        Me.xlk_Suplidor.TabIndex = 65
        Me.xlk_Suplidor.TableName = "cpprovm"
        Me.xlk_Suplidor.UseCopyConnection = False
        Me.xlk_Suplidor.UseRowRetrieveEvents = False
        Me.xlk_Suplidor.UseTab = False
        Me.xlk_Suplidor.VisParameters = New String() {"Código=prov_code", "Descripción=prov_name"}
        Me.xlk_Suplidor.WhereCondition = Nothing
        Me.xlk_Suplidor.WhereParameters = Nothing
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(136, 264)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(304, 20)
        Me.Label13.TabIndex = 64
        '
        'xlk_subcategoria
        '
        Me.xlk_subcategoria.CheckText = Nothing
        Me.xlk_subcategoria.DataMember = Nothing
        Me.xlk_subcategoria.DataSource = Me.LibXConnector1
        Me.xlk_subcategoria.DestParameters = New String() {"TextBox7=sgroup_code", "Label11=sgroup_name"}
        Me.xlk_subcategoria.FilterField = "sgroup_name"
        Me.xlk_subcategoria.IgnoreFindInBrowseMode = False
        Me.xlk_subcategoria.Location = New System.Drawing.Point(440, 240)
        Me.xlk_subcategoria.LookCaption = "Sub-categoría"
        Me.xlk_subcategoria.Name = "xlk_subcategoria"
        Me.xlk_subcategoria.ShowMessageNotFound = True
        Me.xlk_subcategoria.ShowWarning = False
        Me.xlk_subcategoria.Size = New System.Drawing.Size(16, 20)
        Me.xlk_subcategoria.SizesColumns = Nothing
        Me.xlk_subcategoria.SizesColumnsTab = Nothing
        Me.xlk_subcategoria.SqlString = Nothing
        Me.xlk_subcategoria.SQLTab = Nothing
        Me.xlk_subcategoria.SrcParameters = New String() {"sgroup_code=sgroup_code"}
        Me.xlk_subcategoria.TabIndex = 61
        Me.xlk_subcategoria.TableName = "ivsgroupm"
        Me.xlk_subcategoria.UseCopyConnection = False
        Me.xlk_subcategoria.UseRowRetrieveEvents = False
        Me.xlk_subcategoria.UseTab = False
        Me.xlk_subcategoria.VisParameters = New String() {"Código=sgroup_code", "Descripción=sgroup_name"}
        Me.xlk_subcategoria.WhereCondition = Nothing
        Me.xlk_subcategoria.WhereParameters = Nothing
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(136, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(304, 20)
        Me.Label11.TabIndex = 60
        '
        'xlk_Categoria
        '
        Me.xlk_Categoria.CheckText = Nothing
        Me.xlk_Categoria.DataMember = Nothing
        Me.xlk_Categoria.DataSource = Me.LibXConnector1
        Me.xlk_Categoria.DestParameters = New String() {"TextBox6=group_code", "Label8=group_name"}
        Me.xlk_Categoria.FilterField = "group_name"
        Me.xlk_Categoria.IgnoreFindInBrowseMode = False
        Me.xlk_Categoria.Location = New System.Drawing.Point(440, 216)
        Me.xlk_Categoria.LookCaption = "Categoría"
        Me.xlk_Categoria.Name = "xlk_Categoria"
        Me.xlk_Categoria.ShowMessageNotFound = True
        Me.xlk_Categoria.ShowWarning = False
        Me.xlk_Categoria.Size = New System.Drawing.Size(16, 20)
        Me.xlk_Categoria.SizesColumns = Nothing
        Me.xlk_Categoria.SizesColumnsTab = Nothing
        Me.xlk_Categoria.SqlString = Nothing
        Me.xlk_Categoria.SQLTab = Nothing
        Me.xlk_Categoria.SrcParameters = New String() {"group_code=group_code"}
        Me.xlk_Categoria.TabIndex = 57
        Me.xlk_Categoria.TableName = "ivgroupm"
        Me.xlk_Categoria.UseCopyConnection = False
        Me.xlk_Categoria.UseRowRetrieveEvents = False
        Me.xlk_Categoria.UseTab = False
        Me.xlk_Categoria.VisParameters = New String() {"Código=group_code", "Descripción=group_name"}
        Me.xlk_Categoria.WhereCondition = Nothing
        Me.xlk_Categoria.WhereParameters = Nothing
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(136, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(304, 20)
        Me.Label8.TabIndex = 56
        '
        'xlk_Almacen
        '
        Me.xlk_Almacen.CheckText = Nothing
        Me.xlk_Almacen.DataMember = Nothing
        Me.xlk_Almacen.DataSource = Me.LibXConnector1
        Me.xlk_Almacen.DestParameters = New String() {"TextBox16=whse_code", "Label20=whse_name"}
        Me.xlk_Almacen.FilterField = "whse_name"
        Me.xlk_Almacen.IgnoreFindInBrowseMode = False
        Me.xlk_Almacen.Location = New System.Drawing.Point(440, 192)
        Me.xlk_Almacen.LookCaption = "Almacen"
        Me.xlk_Almacen.Name = "xlk_Almacen"
        Me.xlk_Almacen.ShowMessageNotFound = True
        Me.xlk_Almacen.ShowWarning = False
        Me.xlk_Almacen.Size = New System.Drawing.Size(16, 20)
        Me.xlk_Almacen.SizesColumns = Nothing
        Me.xlk_Almacen.SizesColumnsTab = Nothing
        Me.xlk_Almacen.SqlString = Nothing
        Me.xlk_Almacen.SQLTab = Nothing
        Me.xlk_Almacen.SrcParameters = New String() {"wh_code=whse_code"}
        Me.xlk_Almacen.TabIndex = 53
        Me.xlk_Almacen.TableName = "ivwhsem"
        Me.xlk_Almacen.UseCopyConnection = False
        Me.xlk_Almacen.UseRowRetrieveEvents = False
        Me.xlk_Almacen.UseTab = False
        Me.xlk_Almacen.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.xlk_Almacen.WhereCondition = Nothing
        Me.xlk_Almacen.WhereParameters = Nothing
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Location = New System.Drawing.Point(136, 192)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(304, 20)
        Me.Label20.TabIndex = 52
        '
        'xlk_itemcode
        '
        Me.xlk_itemcode.CheckText = Nothing
        Me.xlk_itemcode.DataMember = Nothing
        Me.xlk_itemcode.DataSource = Me.LibXConnector1
        Me.xlk_itemcode.DestParameters = New String() {"TextBox15=item_code", "Label18=item_name"}
        Me.xlk_itemcode.FilterField = "item_name"
        Me.xlk_itemcode.IgnoreFindInBrowseMode = False
        Me.xlk_itemcode.Location = New System.Drawing.Point(440, 168)
        Me.xlk_itemcode.LookCaption = "Producto"
        Me.xlk_itemcode.Name = "xlk_itemcode"
        Me.xlk_itemcode.ShowMessageNotFound = True
        Me.xlk_itemcode.ShowWarning = False
        Me.xlk_itemcode.Size = New System.Drawing.Size(16, 20)
        Me.xlk_itemcode.SizesColumns = Nothing
        Me.xlk_itemcode.SizesColumnsTab = Nothing
        Me.xlk_itemcode.SqlString = Nothing
        Me.xlk_itemcode.SQLTab = Nothing
        Me.xlk_itemcode.SrcParameters = New String() {"item_code=item_code"}
        Me.xlk_itemcode.TabIndex = 49
        Me.xlk_itemcode.TableName = "ivitemm"
        Me.xlk_itemcode.UseCopyConnection = False
        Me.xlk_itemcode.UseRowRetrieveEvents = False
        Me.xlk_itemcode.UseTab = False
        Me.xlk_itemcode.VisParameters = New String() {"Código=item_code", "Descripción=item_name"}
        Me.xlk_itemcode.WhereCondition = Nothing
        Me.xlk_itemcode.WhereParameters = Nothing
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Location = New System.Drawing.Point(136, 168)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(304, 20)
        Me.Label18.TabIndex = 48
        '
        'xlk_TipoCliente
        '
        Me.xlk_TipoCliente.CheckText = Nothing
        Me.xlk_TipoCliente.DataMember = Nothing
        Me.xlk_TipoCliente.DataSource = Me.LibXConnector1
        Me.xlk_TipoCliente.DestParameters = New String() {"TextBox14=csttype_code", "Label16=csttype_name"}
        Me.xlk_TipoCliente.FilterField = "type_name"
        Me.xlk_TipoCliente.IgnoreFindInBrowseMode = False
        Me.xlk_TipoCliente.Location = New System.Drawing.Point(440, 144)
        Me.xlk_TipoCliente.LookCaption = "Tipo Cliente"
        Me.xlk_TipoCliente.Name = "xlk_TipoCliente"
        Me.xlk_TipoCliente.ShowMessageNotFound = True
        Me.xlk_TipoCliente.ShowWarning = False
        Me.xlk_TipoCliente.Size = New System.Drawing.Size(16, 20)
        Me.xlk_TipoCliente.SizesColumns = Nothing
        Me.xlk_TipoCliente.SizesColumnsTab = Nothing
        Me.xlk_TipoCliente.SqlString = Nothing
        Me.xlk_TipoCliente.SQLTab = Nothing
        Me.xlk_TipoCliente.SrcParameters = New String() {"tipo_cliente=csttype_code"}
        Me.xlk_TipoCliente.TabIndex = 45
        Me.xlk_TipoCliente.TableName = "cccsttpm"
        Me.xlk_TipoCliente.UseCopyConnection = False
        Me.xlk_TipoCliente.UseRowRetrieveEvents = False
        Me.xlk_TipoCliente.UseTab = False
        Me.xlk_TipoCliente.VisParameters = New String() {"Código=csttype_code", "Descripción=csttype_name"}
        Me.xlk_TipoCliente.WhereCondition = Nothing
        Me.xlk_TipoCliente.WhereParameters = Nothing
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Location = New System.Drawing.Point(136, 144)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(304, 20)
        Me.Label16.TabIndex = 44
        '
        'xlk_Cliente
        '
        Me.xlk_Cliente.CheckText = Nothing
        Me.xlk_Cliente.DataMember = Nothing
        Me.xlk_Cliente.DataSource = Me.LibXConnector1
        Me.xlk_Cliente.DestParameters = New String() {"TextBox13=cust_code", "LabelCliente=cust_name"}
        Me.xlk_Cliente.FilterField = "cust_name"
        Me.xlk_Cliente.IgnoreFindInBrowseMode = False
        Me.xlk_Cliente.Location = New System.Drawing.Point(440, 120)
        Me.xlk_Cliente.LookCaption = "Clientes"
        Me.xlk_Cliente.Name = "xlk_Cliente"
        Me.xlk_Cliente.ShowMessageNotFound = True
        Me.xlk_Cliente.ShowWarning = False
        Me.xlk_Cliente.Size = New System.Drawing.Size(16, 20)
        Me.xlk_Cliente.SizesColumns = Nothing
        Me.xlk_Cliente.SizesColumnsTab = Nothing
        Me.xlk_Cliente.SqlString = Nothing
        Me.xlk_Cliente.SQLTab = Nothing
        Me.xlk_Cliente.SrcParameters = New String() {"cliente=cust_code"}
        Me.xlk_Cliente.TabIndex = 41
        Me.xlk_Cliente.TableName = "cccustm"
        Me.xlk_Cliente.UseCopyConnection = False
        Me.xlk_Cliente.UseRowRetrieveEvents = False
        Me.xlk_Cliente.UseTab = False
        Me.xlk_Cliente.VisParameters = New String() {"Código=cust_code", "nombre=cust_name"}
        Me.xlk_Cliente.WhereCondition = Nothing
        Me.xlk_Cliente.WhereParameters = Nothing
        '
        'LabelCliente
        '
        Me.LabelCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelCliente.Location = New System.Drawing.Point(136, 120)
        Me.LabelCliente.Name = "LabelCliente"
        Me.LabelCliente.Size = New System.Drawing.Size(304, 20)
        Me.LabelCliente.TabIndex = 40
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "pvpolimh.aplica_domisi"))
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(208, 24)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = Nothing
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = False
        Me.LibxCheckBox1.Size = New System.Drawing.Size(80, 16)
        Me.LibxCheckBox1.TabIndex = 37
        Me.LibxCheckBox1.Text = "Domicilio"
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'xlk_Tipo_Venta1
        '
        Me.xlk_Tipo_Venta1.CheckText = Nothing
        Me.xlk_Tipo_Venta1.DataMember = Nothing
        Me.xlk_Tipo_Venta1.DataSource = Me.LibXConnector1
        Me.xlk_Tipo_Venta1.DestParameters = New String() {"txttipoventa2=type_code", "LabelTipoVenta1=type_name"}
        Me.xlk_Tipo_Venta1.FilterField = "type_name"
        Me.xlk_Tipo_Venta1.IgnoreFindInBrowseMode = False
        Me.xlk_Tipo_Venta1.Location = New System.Drawing.Point(440, 72)
        Me.xlk_Tipo_Venta1.LookCaption = "Tipo Venta"
        Me.xlk_Tipo_Venta1.Name = "xlk_Tipo_Venta1"
        Me.xlk_Tipo_Venta1.ShowMessageNotFound = True
        Me.xlk_Tipo_Venta1.ShowWarning = False
        Me.xlk_Tipo_Venta1.Size = New System.Drawing.Size(16, 20)
        Me.xlk_Tipo_Venta1.SizesColumns = Nothing
        Me.xlk_Tipo_Venta1.SizesColumnsTab = Nothing
        Me.xlk_Tipo_Venta1.SqlString = Nothing
        Me.xlk_Tipo_Venta1.SQLTab = Nothing
        Me.xlk_Tipo_Venta1.SrcParameters = New String() {"tipo_venta=type_code"}
        Me.xlk_Tipo_Venta1.TabIndex = 19
        Me.xlk_Tipo_Venta1.TableName = "ivtypem"
        Me.xlk_Tipo_Venta1.UseCopyConnection = False
        Me.xlk_Tipo_Venta1.UseRowRetrieveEvents = False
        Me.xlk_Tipo_Venta1.UseTab = False
        Me.xlk_Tipo_Venta1.VisParameters = New String() {"Tipo Venta=type_code", "Descripcion=type_name"}
        Me.xlk_Tipo_Venta1.WhereCondition = Nothing
        Me.xlk_Tipo_Venta1.WhereParameters = Nothing
        '
        'LabelTipoVenta1
        '
        Me.LabelTipoVenta1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTipoVenta1.Location = New System.Drawing.Point(136, 72)
        Me.LabelTipoVenta1.Name = "LabelTipoVenta1"
        Me.LabelTipoVenta1.Size = New System.Drawing.Size(304, 20)
        Me.LabelTipoVenta1.TabIndex = 18
        '
        'xlk_Tipo_Venta3
        '
        Me.xlk_Tipo_Venta3.CheckText = Nothing
        Me.xlk_Tipo_Venta3.DataMember = Nothing
        Me.xlk_Tipo_Venta3.DataSource = Me.LibXConnector1
        Me.xlk_Tipo_Venta3.DestParameters = New String() {"txttipoventa3=type_code", "LabelTipoVenta3=type_name"}
        Me.xlk_Tipo_Venta3.FilterField = "type_name"
        Me.xlk_Tipo_Venta3.IgnoreFindInBrowseMode = False
        Me.xlk_Tipo_Venta3.Location = New System.Drawing.Point(440, 96)
        Me.xlk_Tipo_Venta3.LookCaption = "Tipo Venta"
        Me.xlk_Tipo_Venta3.Name = "xlk_Tipo_Venta3"
        Me.xlk_Tipo_Venta3.ShowMessageNotFound = True
        Me.xlk_Tipo_Venta3.ShowWarning = False
        Me.xlk_Tipo_Venta3.Size = New System.Drawing.Size(16, 20)
        Me.xlk_Tipo_Venta3.SizesColumns = Nothing
        Me.xlk_Tipo_Venta3.SizesColumnsTab = Nothing
        Me.xlk_Tipo_Venta3.SqlString = Nothing
        Me.xlk_Tipo_Venta3.SQLTab = Nothing
        Me.xlk_Tipo_Venta3.SrcParameters = New String() {"tipo_venta=type_code"}
        Me.xlk_Tipo_Venta3.TabIndex = 13
        Me.xlk_Tipo_Venta3.TableName = "ivtypem"
        Me.xlk_Tipo_Venta3.UseCopyConnection = False
        Me.xlk_Tipo_Venta3.UseRowRetrieveEvents = False
        Me.xlk_Tipo_Venta3.UseTab = False
        Me.xlk_Tipo_Venta3.VisParameters = New String() {"Tipo Venta=type_code", "Descripcion=type_name"}
        Me.xlk_Tipo_Venta3.WhereCondition = Nothing
        Me.xlk_Tipo_Venta3.WhereParameters = Nothing
        '
        'LabelTipoVenta3
        '
        Me.LabelTipoVenta3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTipoVenta3.Location = New System.Drawing.Point(136, 96)
        Me.LabelTipoVenta3.Name = "LabelTipoVenta3"
        Me.LabelTipoVenta3.Size = New System.Drawing.Size(304, 20)
        Me.LabelTipoVenta3.TabIndex = 12
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
        'xlk_Tipo_Venta
        '
        Me.xlk_Tipo_Venta.CheckText = Nothing
        Me.xlk_Tipo_Venta.DataMember = Nothing
        Me.xlk_Tipo_Venta.DataSource = Me.LibXConnector1
        Me.xlk_Tipo_Venta.DestParameters = New String() {"txtTipoVenta1=type_code", "LabelTipoVenta=type_name"}
        Me.xlk_Tipo_Venta.FilterField = "type_name"
        Me.xlk_Tipo_Venta.IgnoreFindInBrowseMode = False
        Me.xlk_Tipo_Venta.Location = New System.Drawing.Point(440, 48)
        Me.xlk_Tipo_Venta.LookCaption = "Tipo Venta"
        Me.xlk_Tipo_Venta.Name = "xlk_Tipo_Venta"
        Me.xlk_Tipo_Venta.ShowMessageNotFound = True
        Me.xlk_Tipo_Venta.ShowWarning = False
        Me.xlk_Tipo_Venta.Size = New System.Drawing.Size(16, 20)
        Me.xlk_Tipo_Venta.SizesColumns = Nothing
        Me.xlk_Tipo_Venta.SizesColumnsTab = Nothing
        Me.xlk_Tipo_Venta.SqlString = Nothing
        Me.xlk_Tipo_Venta.SQLTab = Nothing
        Me.xlk_Tipo_Venta.SrcParameters = New String() {"tipo_venta=type_code"}
        Me.xlk_Tipo_Venta.TabIndex = 6
        Me.xlk_Tipo_Venta.TableName = "ivtypem"
        Me.xlk_Tipo_Venta.UseCopyConnection = False
        Me.xlk_Tipo_Venta.UseRowRetrieveEvents = False
        Me.xlk_Tipo_Venta.UseTab = False
        Me.xlk_Tipo_Venta.VisParameters = New String() {"Tipo Venta=type_code", "Descripcion=type_name"}
        Me.xlk_Tipo_Venta.WhereCondition = Nothing
        Me.xlk_Tipo_Venta.WhereParameters = Nothing
        '
        'LabelTipoVenta
        '
        Me.LabelTipoVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTipoVenta.Location = New System.Drawing.Point(136, 48)
        Me.LabelTipoVenta.Name = "LabelTipoVenta"
        Me.LabelTipoVenta.Size = New System.Drawing.Size(304, 20)
        Me.LabelTipoVenta.TabIndex = 5
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
        Me.LibXNavigator1.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbHoraFin)
        Me.GroupBox2.Controls.Add(Me.cmbHoraIni)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox2.Controls.Add(Me.dtpFechaIni)
        Me.GroupBox2.Location = New System.Drawing.Point(480, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 352)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        '
        'cmbHoraFin
        '
        Me.cmbHoraFin.AllowDefaultSort = False
        Me.cmbHoraFin.bound = True
        Me.cmbHoraFin.currValue = Nothing
        Me.cmbHoraFin.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "pvpolimh.hora_fin"))
        Me.cmbHoraFin.DefaultWhereString = Nothing
        Me.cmbHoraFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoraFin.EditInitialValue = Nothing
        Me.cmbHoraFin.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cmbHoraFin.FindInitialValue = Nothing
        Me.cmbHoraFin.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cmbHoraFin.IgnoreRequiered = False
        Me.cmbHoraFin.Items.AddRange(New Object() {"1-1:00 a.m.", "2-2:00 a.m.", "3-3:00 a.m.", "4-4:00 a.m.", "5-5:00 a.m.", "6-6:00 a.m.", "7-7:00 a.m.", "8-8:00 a.m.", "9-9:00 a.m.", "10-10:00 a.m.", "11-11:00 a.m.", "12-12:00 m.", "13-1:00 p.m.", "14-2:00 p.m.", "15-3:00 p.m.", "16-4:00 p.m.", "17-5:00 p.m.", "18-6:00 p.m.", "19-7:00 p.m.", "20-8:00 p.m.", "21-9:00 p.m.", "22-10:00 p.m.", "23-11:00 p.m.", "24-12:00 a.m."})
        Me.cmbHoraFin.Location = New System.Drawing.Point(96, 96)
        Me.cmbHoraFin.LookupKeyDisplayFields = Nothing
        Me.cmbHoraFin.LookupKeyField = Nothing
        Me.cmbHoraFin.LookupTableName = Nothing
        Me.cmbHoraFin.Name = "cmbHoraFin"
        Me.cmbHoraFin.NewInitialValue = Nothing
        Me.cmbHoraFin.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cmbHoraFin.Requiered = False
        Me.cmbHoraFin.Required = False
        Me.cmbHoraFin.Size = New System.Drawing.Size(121, 21)
        Me.cmbHoraFin.SqlString = Nothing
        Me.cmbHoraFin.TabIndex = 82
        '
        'cmbHoraIni
        '
        Me.cmbHoraIni.AllowDefaultSort = False
        Me.cmbHoraIni.bound = True
        Me.cmbHoraIni.currValue = Nothing
        Me.cmbHoraIni.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "pvpolimh.hora_ini"))
        Me.cmbHoraIni.DefaultWhereString = Nothing
        Me.cmbHoraIni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoraIni.EditInitialValue = Nothing
        Me.cmbHoraIni.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cmbHoraIni.FindInitialValue = Nothing
        Me.cmbHoraIni.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cmbHoraIni.IgnoreRequiered = False
        Me.cmbHoraIni.Items.AddRange(New Object() {"1-1:00 a.m.", "2-2:00 a.m.", "3-3:00 a.m.", "4-4:00 a.m.", "5-5:00 a.m.", "6-6:00 a.m.", "7-7:00 a.m.", "8-8:00 a.m.", "9-9:00 a.m.", "10-10:00 a.m.", "11-11:00 a.m.", "12-12:00 m.", "13-1:00 p.m.", "14-2:00 p.m.", "15-3:00 p.m.", "16-4:00 p.m.", "17-5:00 p.m.", "18-6:00 p.m.", "19-7:00 p.m.", "20-8:00 p.m.", "21-9:00 p.m.", "22-10:00 p.m.", "23-11:00 p.m.", "24-12:00 a.m."})
        Me.cmbHoraIni.Location = New System.Drawing.Point(96, 72)
        Me.cmbHoraIni.LookupKeyDisplayFields = Nothing
        Me.cmbHoraIni.LookupKeyField = Nothing
        Me.cmbHoraIni.LookupTableName = Nothing
        Me.cmbHoraIni.Name = "cmbHoraIni"
        Me.cmbHoraIni.NewInitialValue = Nothing
        Me.cmbHoraIni.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cmbHoraIni.Requiered = False
        Me.cmbHoraIni.Required = False
        Me.cmbHoraIni.Size = New System.Drawing.Size(121, 21)
        Me.cmbHoraIni.SqlString = Nothing
        Me.cmbHoraIni.TabIndex = 81
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvpolimh.usuario"))
        Me.Label28.Location = New System.Drawing.Point(96, 120)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(104, 20)
        Me.Label28.TabIndex = 80
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label27.Location = New System.Drawing.Point(32, 120)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(46, 16)
        Me.Label27.TabIndex = 79
        Me.Label27.Text = "Usuario:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label26.Location = New System.Drawing.Point(24, 96)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(51, 16)
        Me.Label26.TabIndex = 78
        Me.Label26.Text = "Hora Fin:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label25.Location = New System.Drawing.Point(24, 72)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(61, 16)
        Me.Label25.TabIndex = 76
        Me.Label25.Text = "Hora Inicio:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label24.Location = New System.Drawing.Point(24, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 16)
        Me.Label24.TabIndex = 74
        Me.Label24.Text = "Fecha Fin:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(24, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Fecha Inicio:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaFin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "pvpolimh.fecha_fin"))
        Me.dtpFechaFin.EditInitialValue = Nothing
        Me.dtpFechaFin.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dtpFechaFin.FindInitialValue = Nothing
        Me.dtpFechaFin.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin.IgnoreRequiered = False
        Me.dtpFechaFin.Location = New System.Drawing.Point(96, 48)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.NewInitialValue = Nothing
        Me.dtpFechaFin.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dtpFechaFin.Requiered = False
        Me.dtpFechaFin.Size = New System.Drawing.Size(112, 20)
        Me.dtpFechaFin.TabIndex = 73
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaIni.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "pvpolimh.fecha_fin"))
        Me.dtpFechaIni.EditInitialValue = Nothing
        Me.dtpFechaIni.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dtpFechaIni.FindInitialValue = Nothing
        Me.dtpFechaIni.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaIni.IgnoreRequiered = False
        Me.dtpFechaIni.Location = New System.Drawing.Point(96, 24)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.NewInitialValue = Nothing
        Me.dtpFechaIni.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.dtpFechaIni.Requiered = False
        Me.dtpFechaIni.Size = New System.Drawing.Size(112, 20)
        Me.dtpFechaIni.TabIndex = 0
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.DataMember = "pvpolimd"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 392)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(680, 120)
        Me.LibXGrid1.TabIndex = 73
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XEditTextBoxColumn1, Me.XDataGridComboBoxColumn1, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn3})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "pvpolimd"
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = True
        Me.XEditTextBoxColumn1.MappingName = "line_no"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 0
        '
        'XDataGridComboBoxColumn1
        '
        Me.XDataGridComboBoxColumn1.ComboBox = Me.LibXCombo1
        Me.XDataGridComboBoxColumn1.Format = ""
        Me.XDataGridComboBoxColumn1.FormatInfo = Nothing
        Me.XDataGridComboBoxColumn1.HeaderText = "TIPO POLITICA"
        Me.XDataGridComboBoxColumn1.isReadOnly = False
        Me.XDataGridComboBoxColumn1.MappingName = "tipo_poli"
        Me.XDataGridComboBoxColumn1.Width = 75
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = "####"
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "CANTIDAD"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "qty_poli"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 75
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = "#,##0.00"
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "PRECIO"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = False
        Me.XEditTextBoxColumn3.MappingName = "precio_poli"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 75
        '
        'i_ptvpolm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(698, 520)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ptvpolm01"
        Me.Text = "Politicas de Precios"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    


    Private Sub xlk_Tipo_Venta1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_Tipo_Venta1.BeforeExecuteQuery
        Try
            If Not txtTipoVenta2.Text = "" And Not txtTipoVenta3.Text = "" Then
                e.aditionalWhere = " ivtypem.type_code not in('" & txtTipoVenta2.Text & "','" & txtTipoVenta3.Text & "')"
            ElseIf Not txtTipoVenta2.Text = "" Then
                e.aditionalWhere = " ivtypem.type_code not like '" & txtTipoVenta2.Text & "'"
            ElseIf Not txtTipoVenta3.Text = "" Then
                e.aditionalWhere = " ivtypem.type_code not like '" & txtTipoVenta3.Text & "'"

            End If


        Catch ex As Exception
            e.handled = True
            LibX.Log.Show(ex)
        End Try
    End Sub


    Private Sub xlk_Tipo_Venta3_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_Tipo_Venta3.BeforeExecuteQuery
        Try
            If Not txtTipoVenta1.Text = "" And Not txtTipoVenta2.Text = "" Then
                e.aditionalWhere = " ivtypem.type_code not in('" & txtTipoVenta1.Text & "','" & txtTipoVenta2.Text & "')"
            ElseIf Not txtTipoVenta1.Text = "" Then
                e.aditionalWhere = " ivtypem.type_code not like '" & txtTipoVenta1.Text & "'"
            ElseIf Not txtTipoVenta2.Text = "" Then
                e.aditionalWhere = " ivtypem.type_code not like '" & txtTipoVenta2.Text & "'"

            End If


        Catch ex As Exception
            e.handled = True
            LibX.Log.Show(ex)
        End Try
    End Sub


    Private Sub xlk_Tipo_Venta_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_Tipo_Venta.BeforeExecuteQuery
        Try
            If Not txtTipoVenta2.Text = "" And Not txtTipoVenta3.Text = "" Then
                e.aditionalWhere = " ivtypem.type_code not in('" & txtTipoVenta2.Text & "','" & txtTipoVenta3.Text & "')"

            ElseIf Not txtTipoVenta2.Text = "" Then
                e.aditionalWhere = " ivtypem.type_code not like '" & txtTipoVenta2.Text & "'"
            ElseIf Not txtTipoVenta3.Text = "" Then
                e.aditionalWhere = " ivtypem.type_code not like '" & txtTipoVenta3.Text & "'"
            End If


        Catch ex As Exception
            e.handled = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles LibXGrid1.Navigate

    End Sub

    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid1.CurrentRowChanged


    End Sub
End Class
