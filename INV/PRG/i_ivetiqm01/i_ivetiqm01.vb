Public Class i_ivetiqm01
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents LabelProducto As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelAlmacen As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As LibX.XTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As LibX.XTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup4 As LibX.LibXLookup
    Friend WithEvents LabelProveedor As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelGrupo As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LabelSubgrupo As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LabelMarca As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents Labelqty As System.Windows.Forms.Label
    Friend WithEvents Labelcosto As System.Windows.Forms.Label
    Friend WithEvents Labelprecio As System.Windows.Forms.Label
    Friend WithEvents txt_imp_etiq As LibX.LibxCheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents xtxt_abreviada As LibX.XTextBox
    Friend WithEvents xtxt_brand_code As LibX.XTextBox
    Friend WithEvents xtxt_sgroup_code As LibX.XTextBox
    Friend WithEvents xtxt_group_code As LibX.XTextBox
    Friend WithEvents xtxt_unit_code As LibX.XTextBox
    Friend WithEvents xtxt_prov_code As LibX.XTextBox
    Friend WithEvents xtxt_whse_code As LibX.XTextBox
    Friend WithEvents xtxt_purch_unit As LibX.XTextBox
    Friend WithEvents xtxt_qty As LibX.XTextBox
    Friend WithEvents xlk_whse_code As LibX.LibXLookup
    Friend WithEvents xtxt_item_code As LibX.XTextBox
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents Labelprecio2 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Labelprecio2 = New System.Windows.Forms.Label
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.xtxt_item_code = New LibX.XTextBox
        Me.xtxt_abreviada = New LibX.XTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Labelprecio = New System.Windows.Forms.Label
        Me.Labelcosto = New System.Windows.Forms.Label
        Me.Labelqty = New System.Windows.Forms.Label
        Me.txt_imp_etiq = New LibX.LibxCheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LabelMarca = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.xtxt_brand_code = New LibX.XTextBox
        Me.LabelSubgrupo = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.xtxt_sgroup_code = New LibX.XTextBox
        Me.LabelGrupo = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.xtxt_group_code = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.xtxt_unit_code = New LibX.XTextBox
        Me.LibXLookup4 = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LabelProveedor = New System.Windows.Forms.Label
        Me.xtxt_prov_code = New LibX.XTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TextBox11 = New LibX.XTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TextBox10 = New LibX.XTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.xlk_whse_code = New LibX.LibXLookup
        Me.LabelAlmacen = New System.Windows.Forms.Label
        Me.xtxt_whse_code = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.xtxt_purch_unit = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LabelProducto = New System.Windows.Forms.Label
        Me.xtxt_qty = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Labelprecio2)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.xtxt_item_code)
        Me.GroupBox1.Controls.Add(Me.xtxt_abreviada)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Labelprecio)
        Me.GroupBox1.Controls.Add(Me.Labelcosto)
        Me.GroupBox1.Controls.Add(Me.Labelqty)
        Me.GroupBox1.Controls.Add(Me.txt_imp_etiq)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.LabelMarca)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.xtxt_brand_code)
        Me.GroupBox1.Controls.Add(Me.LabelSubgrupo)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.xtxt_sgroup_code)
        Me.GroupBox1.Controls.Add(Me.LabelGrupo)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.xtxt_group_code)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xtxt_unit_code)
        Me.GroupBox1.Controls.Add(Me.LibXLookup4)
        Me.GroupBox1.Controls.Add(Me.LabelProveedor)
        Me.GroupBox1.Controls.Add(Me.xtxt_prov_code)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TextBox11)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.xlk_whse_code)
        Me.GroupBox1.Controls.Add(Me.LabelAlmacen)
        Me.GroupBox1.Controls.Add(Me.xtxt_whse_code)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xtxt_purch_unit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.LabelProducto)
        Me.GroupBox1.Controls.Add(Me.xtxt_qty)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 336)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Labelprecio2
        '
        Me.Labelprecio2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Labelprecio2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.precio2"))
        Me.Labelprecio2.Location = New System.Drawing.Point(408, 240)
        Me.Labelprecio2.Name = "Labelprecio2"
        Me.Labelprecio2.Size = New System.Drawing.Size(80, 20)
        Me.Labelprecio2.TabIndex = 63
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"etiq_no", "almacen", "item_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3}
        Me.DataTable1.TableName = "ivetiqm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "etiq_no"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "almacen"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "item_code"
        Me.DataColumn3.MaxLength = 10
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "costo"
        Me.DataColumn4.DataType = GetType(System.Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "precio"
        Me.DataColumn5.DataType = GetType(System.Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "precio2"
        Me.DataColumn6.DataType = GetType(System.Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "descripcion"
        Me.DataColumn7.MaxLength = 100
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "abreviada"
        Me.DataColumn8.MaxLength = 40
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "fact_no"
        Me.DataColumn9.MaxLength = 20
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "fecha_factura"
        Me.DataColumn10.DataType = GetType(System.DateTime)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "prov_code"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "cantidad"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "unidad_compra"
        Me.DataColumn13.MaxLength = 5
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "unidad_venta"
        Me.DataColumn14.MaxLength = 5
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "existencia"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "grupo"
        Me.DataColumn16.DataType = GetType(System.Int32)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "subgrp"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "estado"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "marca"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "fecha"
        Me.DataColumn20.DataType = GetType(System.DateTime)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Location = New System.Drawing.Point(360, 240)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 16)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "Precio2:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.fecha"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.FieldDescription = ""
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = False
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(408, 264)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = Nothing
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Requiered = False
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(80, 20)
        Me.LibxDateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker1.TabIndex = 3
        '
        'xtxt_item_code
        '
        Me.xtxt_item_code.AcceptsReturn = True
        Me.xtxt_item_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.item_code"))
        Me.xtxt_item_code.EditInitialValue = Nothing
        Me.xtxt_item_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_item_code.FieldDescription = ""
        Me.xtxt_item_code.FindInitialValue = Nothing
        Me.xtxt_item_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_item_code.IgnoreRequiered = False
        Me.xtxt_item_code.Location = New System.Drawing.Point(136, 24)
        Me.xtxt_item_code.Name = "xtxt_item_code"
        Me.xtxt_item_code.NewInitialValue = Nothing
        Me.xtxt_item_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_item_code.Requiered = False
        Me.xtxt_item_code.Size = New System.Drawing.Size(80, 20)
        Me.xtxt_item_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_item_code.TabIndex = 0
        Me.xtxt_item_code.Text = ""
        '
        'xtxt_abreviada
        '
        Me.xtxt_abreviada.AcceptsReturn = True
        Me.xtxt_abreviada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.abreviada"))
        Me.xtxt_abreviada.EditInitialValue = Nothing
        Me.xtxt_abreviada.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_abreviada.FieldDescription = ""
        Me.xtxt_abreviada.FindInitialValue = Nothing
        Me.xtxt_abreviada.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_abreviada.IgnoreRequiered = False
        Me.xtxt_abreviada.Location = New System.Drawing.Point(136, 48)
        Me.xtxt_abreviada.Name = "xtxt_abreviada"
        Me.xtxt_abreviada.NewInitialValue = Nothing
        Me.xtxt_abreviada.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_abreviada.Requiered = False
        Me.xtxt_abreviada.Size = New System.Drawing.Size(352, 20)
        Me.xtxt_abreviada.StatusBarPanelDescripcion = Nothing
        Me.xtxt_abreviada.TabIndex = 61
        Me.xtxt_abreviada.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(67, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 16)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "Abreviada:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Labelprecio
        '
        Me.Labelprecio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Labelprecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.precio"))
        Me.Labelprecio.Location = New System.Drawing.Point(408, 216)
        Me.Labelprecio.Name = "Labelprecio"
        Me.Labelprecio.Size = New System.Drawing.Size(80, 20)
        Me.Labelprecio.TabIndex = 59
        '
        'Labelcosto
        '
        Me.Labelcosto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Labelcosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.costo"))
        Me.Labelcosto.Location = New System.Drawing.Point(136, 216)
        Me.Labelcosto.Name = "Labelcosto"
        Me.Labelcosto.Size = New System.Drawing.Size(80, 20)
        Me.Labelcosto.TabIndex = 58
        '
        'Labelqty
        '
        Me.Labelqty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Labelqty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1, "existencia"))
        Me.Labelqty.Location = New System.Drawing.Point(408, 192)
        Me.Labelqty.Name = "Labelqty"
        Me.Labelqty.Size = New System.Drawing.Size(80, 20)
        Me.Labelqty.TabIndex = 57
        '
        'txt_imp_etiq
        '
        Me.txt_imp_etiq.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txt_imp_etiq.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivetiqm.estado"))
        Me.txt_imp_etiq.EditInitialValue = Nothing
        Me.txt_imp_etiq.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txt_imp_etiq.FindInitialValue = Nothing
        Me.txt_imp_etiq.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txt_imp_etiq.IgnoreRequiered = False
        Me.txt_imp_etiq.KeepEnabled = False
        Me.txt_imp_etiq.Location = New System.Drawing.Point(504, 24)
        Me.txt_imp_etiq.Name = "txt_imp_etiq"
        Me.txt_imp_etiq.NewInitialValue = Nothing
        Me.txt_imp_etiq.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txt_imp_etiq.ReadOnly = False
        Me.txt_imp_etiq.Requiered = False
        Me.txt_imp_etiq.Size = New System.Drawing.Size(112, 16)
        Me.txt_imp_etiq.TabIndex = 56
        Me.txt_imp_etiq.Text = "Estado Impreso:"
        Me.txt_imp_etiq.ThreeState = True
        Me.txt_imp_etiq.value = Nothing
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(360, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Fecha:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(88, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 16)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Costo:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelMarca
        '
        Me.LabelMarca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelMarca.Location = New System.Drawing.Point(192, 168)
        Me.LabelMarca.Name = "LabelMarca"
        Me.LabelMarca.Size = New System.Drawing.Size(296, 20)
        Me.LabelMarca.TabIndex = 50
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label20.Location = New System.Drawing.Point(86, 168)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(39, 16)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "Marca:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_brand_code
        '
        Me.xtxt_brand_code.AcceptsReturn = True
        Me.xtxt_brand_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.marca"))
        Me.xtxt_brand_code.EditInitialValue = Nothing
        Me.xtxt_brand_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_brand_code.FieldDescription = ""
        Me.xtxt_brand_code.FindInitialValue = Nothing
        Me.xtxt_brand_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_brand_code.IgnoreRequiered = False
        Me.xtxt_brand_code.Location = New System.Drawing.Point(136, 168)
        Me.xtxt_brand_code.Name = "xtxt_brand_code"
        Me.xtxt_brand_code.NewInitialValue = Nothing
        Me.xtxt_brand_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_brand_code.Requiered = False
        Me.xtxt_brand_code.Size = New System.Drawing.Size(48, 20)
        Me.xtxt_brand_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_brand_code.TabIndex = 48
        Me.xtxt_brand_code.Text = ""
        '
        'LabelSubgrupo
        '
        Me.LabelSubgrupo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSubgrupo.Location = New System.Drawing.Point(192, 144)
        Me.LabelSubgrupo.Name = "LabelSubgrupo"
        Me.LabelSubgrupo.Size = New System.Drawing.Size(296, 20)
        Me.LabelSubgrupo.TabIndex = 46
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label18.Location = New System.Drawing.Point(62, 144)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 16)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Sub-Grupo:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_sgroup_code
        '
        Me.xtxt_sgroup_code.AcceptsReturn = True
        Me.xtxt_sgroup_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.subgrp"))
        Me.xtxt_sgroup_code.EditInitialValue = Nothing
        Me.xtxt_sgroup_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_sgroup_code.FieldDescription = ""
        Me.xtxt_sgroup_code.FindInitialValue = Nothing
        Me.xtxt_sgroup_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_sgroup_code.IgnoreRequiered = False
        Me.xtxt_sgroup_code.Location = New System.Drawing.Point(136, 144)
        Me.xtxt_sgroup_code.Name = "xtxt_sgroup_code"
        Me.xtxt_sgroup_code.NewInitialValue = Nothing
        Me.xtxt_sgroup_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_sgroup_code.Requiered = False
        Me.xtxt_sgroup_code.Size = New System.Drawing.Size(48, 20)
        Me.xtxt_sgroup_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_sgroup_code.TabIndex = 44
        Me.xtxt_sgroup_code.Text = ""
        '
        'LabelGrupo
        '
        Me.LabelGrupo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelGrupo.Location = New System.Drawing.Point(192, 120)
        Me.LabelGrupo.Name = "LabelGrupo"
        Me.LabelGrupo.Size = New System.Drawing.Size(296, 20)
        Me.LabelGrupo.TabIndex = 42
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Location = New System.Drawing.Point(86, 120)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 16)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Grupo:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_group_code
        '
        Me.xtxt_group_code.AcceptsReturn = True
        Me.xtxt_group_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.grupo"))
        Me.xtxt_group_code.EditInitialValue = Nothing
        Me.xtxt_group_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_group_code.FieldDescription = ""
        Me.xtxt_group_code.FindInitialValue = Nothing
        Me.xtxt_group_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_group_code.IgnoreRequiered = False
        Me.xtxt_group_code.Location = New System.Drawing.Point(136, 120)
        Me.xtxt_group_code.Name = "xtxt_group_code"
        Me.xtxt_group_code.NewInitialValue = Nothing
        Me.xtxt_group_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_group_code.Requiered = False
        Me.xtxt_group_code.Size = New System.Drawing.Size(48, 20)
        Me.xtxt_group_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_group_code.TabIndex = 40
        Me.xtxt_group_code.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(320, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Unidad Venta:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_unit_code
        '
        Me.xtxt_unit_code.AcceptsReturn = True
        Me.xtxt_unit_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.unidad_venta"))
        Me.xtxt_unit_code.EditInitialValue = Nothing
        Me.xtxt_unit_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_unit_code.FieldDescription = ""
        Me.xtxt_unit_code.FindInitialValue = Nothing
        Me.xtxt_unit_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_unit_code.IgnoreRequiered = False
        Me.xtxt_unit_code.Location = New System.Drawing.Point(408, 96)
        Me.xtxt_unit_code.Name = "xtxt_unit_code"
        Me.xtxt_unit_code.NewInitialValue = Nothing
        Me.xtxt_unit_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_unit_code.Requiered = False
        Me.xtxt_unit_code.Size = New System.Drawing.Size(80, 20)
        Me.xtxt_unit_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_unit_code.TabIndex = 36
        Me.xtxt_unit_code.Text = ""
        '
        'LibXLookup4
        '
        Me.LibXLookup4.AlternateFieldSearch = Nothing
        Me.LibXLookup4.BeginCheck = False
        Me.LibXLookup4.CheckText = Nothing
        Me.LibXLookup4.ComboMode = False
        Me.LibXLookup4.DataMember = Nothing
        Me.LibXLookup4.DataSource = Me.LibXConnector1
        Me.LibXLookup4.DestParameters = New String() {"prov_code=prov_code", "LabelProveedor=prov_name"}
        Me.LibXLookup4.FilterField = Nothing
        Me.LibXLookup4.IgnoreFindInBrowseMode = False
        Me.LibXLookup4.isCanceled = False
        Me.LibXLookup4.Location = New System.Drawing.Point(472, 288)
        Me.LibXLookup4.LookCaption = Nothing
        Me.LibXLookup4.Name = "LibXLookup4"
        Me.LibXLookup4.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup4.ShowFilter = True
        Me.LibXLookup4.ShowMessageNotFound = True
        Me.LibXLookup4.ShowWarning = False
        Me.LibXLookup4.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup4.SizesColumns = Nothing
        Me.LibXLookup4.SizesColumnsTab = Nothing
        Me.LibXLookup4.SqlString = Nothing
        Me.LibXLookup4.SQLTab = Nothing
        Me.LibXLookup4.SrcParameters = New String() {"prov_code=prov_code"}
        Me.LibXLookup4.TabIndex = 35
        Me.LibXLookup4.TableName = "cpprovm"
        Me.LibXLookup4.TabStop = False
        Me.LibXLookup4.UseCopyConnection = False
        Me.LibXLookup4.UseRowRetrieveEvents = False
        Me.LibXLookup4.UseTab = False
        Me.LibXLookup4.VisParameters = New String() {"Código=prov_code", "Nombre=prov_name"}
        Me.LibXLookup4.WhereCondition = Nothing
        Me.LibXLookup4.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "ivetiqm"
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
        Me.LibXDbSourceTable1.SerialColumnName = "etiq_no"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ivetiqm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LabelProveedor
        '
        Me.LabelProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelProveedor.Location = New System.Drawing.Point(224, 288)
        Me.LabelProveedor.Name = "LabelProveedor"
        Me.LabelProveedor.Size = New System.Drawing.Size(256, 20)
        Me.LabelProveedor.TabIndex = 34
        '
        'xtxt_prov_code
        '
        Me.xtxt_prov_code.AcceptsReturn = True
        Me.xtxt_prov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.prov_code"))
        Me.xtxt_prov_code.EditInitialValue = Nothing
        Me.xtxt_prov_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_code.FieldDescription = ""
        Me.xtxt_prov_code.FindInitialValue = Nothing
        Me.xtxt_prov_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_code.IgnoreRequiered = False
        Me.xtxt_prov_code.Location = New System.Drawing.Point(136, 288)
        Me.xtxt_prov_code.Name = "xtxt_prov_code"
        Me.xtxt_prov_code.NewInitialValue = Nothing
        Me.xtxt_prov_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_code.Requiered = False
        Me.xtxt_prov_code.Size = New System.Drawing.Size(80, 20)
        Me.xtxt_prov_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_prov_code.TabIndex = 2
        Me.xtxt_prov_code.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(80, 288)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 16)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Suplidor:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox11
        '
        Me.TextBox11.AcceptsReturn = True
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.fecha_factura"))
        Me.TextBox11.EditInitialValue = Nothing
        Me.TextBox11.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox11.FieldDescription = ""
        Me.TextBox11.FindInitialValue = Nothing
        Me.TextBox11.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox11.IgnoreRequiered = False
        Me.TextBox11.Location = New System.Drawing.Point(136, 264)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.NewInitialValue = Nothing
        Me.TextBox11.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox11.Requiered = False
        Me.TextBox11.Size = New System.Drawing.Size(80, 20)
        Me.TextBox11.StatusBarPanelDescripcion = Nothing
        Me.TextBox11.TabIndex = 8
        Me.TextBox11.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(48, 264)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 16)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Fecha Entrada:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox10
        '
        Me.TextBox10.AcceptsReturn = True
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.fact_no"))
        Me.TextBox10.EditInitialValue = Nothing
        Me.TextBox10.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox10.FieldDescription = ""
        Me.TextBox10.FindInitialValue = Nothing
        Me.TextBox10.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox10.IgnoreRequiered = False
        Me.TextBox10.Location = New System.Drawing.Point(136, 240)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.NewInitialValue = Nothing
        Me.TextBox10.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox10.Requiered = False
        Me.TextBox10.Size = New System.Drawing.Size(80, 20)
        Me.TextBox10.StatusBarPanelDescripcion = Nothing
        Me.TextBox10.TabIndex = 7
        Me.TextBox10.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(64, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 16)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Factura No:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(342, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Existencia:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(362, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 16)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Precio:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_whse_code
        '
        Me.xlk_whse_code.AlternateFieldSearch = Nothing
        Me.xlk_whse_code.BeginCheck = False
        Me.xlk_whse_code.CheckText = Nothing
        Me.xlk_whse_code.ComboMode = False
        Me.xlk_whse_code.DataMember = Nothing
        Me.xlk_whse_code.DataSource = Me.LibXConnector1
        Me.xlk_whse_code.DestParameters = New String() {"almacen=whse_code", "labelAlmacen=whse_name"}
        Me.xlk_whse_code.FilterField = Nothing
        Me.xlk_whse_code.IgnoreFindInBrowseMode = False
        Me.xlk_whse_code.isCanceled = False
        Me.xlk_whse_code.Location = New System.Drawing.Point(472, 72)
        Me.xlk_whse_code.LookCaption = Nothing
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
        Me.xlk_whse_code.SrcParameters = New String() {"almacen=whse_code"}
        Me.xlk_whse_code.TabIndex = 19
        Me.xlk_whse_code.TableName = "ivwhsem"
        Me.xlk_whse_code.TabStop = False
        Me.xlk_whse_code.UseCopyConnection = False
        Me.xlk_whse_code.UseRowRetrieveEvents = False
        Me.xlk_whse_code.UseTab = False
        Me.xlk_whse_code.VisParameters = New String() {"Código=whse_code", "Descripcion=whse_name"}
        Me.xlk_whse_code.WhereCondition = Nothing
        Me.xlk_whse_code.WhereParameters = Nothing
        '
        'LabelAlmacen
        '
        Me.LabelAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAlmacen.Location = New System.Drawing.Point(192, 72)
        Me.LabelAlmacen.Name = "LabelAlmacen"
        Me.LabelAlmacen.Size = New System.Drawing.Size(280, 20)
        Me.LabelAlmacen.TabIndex = 18
        '
        'xtxt_whse_code
        '
        Me.xtxt_whse_code.AcceptsReturn = True
        Me.xtxt_whse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.almacen"))
        Me.xtxt_whse_code.EditInitialValue = Nothing
        Me.xtxt_whse_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_whse_code.FieldDescription = ""
        Me.xtxt_whse_code.FindInitialValue = Nothing
        Me.xtxt_whse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_whse_code.IgnoreRequiered = False
        Me.xtxt_whse_code.Location = New System.Drawing.Point(136, 72)
        Me.xtxt_whse_code.Name = "xtxt_whse_code"
        Me.xtxt_whse_code.NewInitialValue = Nothing
        Me.xtxt_whse_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_whse_code.Requiered = False
        Me.xtxt_whse_code.Size = New System.Drawing.Size(48, 20)
        Me.xtxt_whse_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_whse_code.TabIndex = 1
        Me.xtxt_whse_code.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(74, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Almacen:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(38, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Unidad Compra:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_purch_unit
        '
        Me.xtxt_purch_unit.AcceptsReturn = True
        Me.xtxt_purch_unit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.unidad_compra"))
        Me.xtxt_purch_unit.EditInitialValue = Nothing
        Me.xtxt_purch_unit.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_purch_unit.FieldDescription = ""
        Me.xtxt_purch_unit.FindInitialValue = Nothing
        Me.xtxt_purch_unit.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_purch_unit.IgnoreRequiered = False
        Me.xtxt_purch_unit.Location = New System.Drawing.Point(136, 96)
        Me.xtxt_purch_unit.Name = "xtxt_purch_unit"
        Me.xtxt_purch_unit.NewInitialValue = Nothing
        Me.xtxt_purch_unit.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_purch_unit.Requiered = False
        Me.xtxt_purch_unit.Size = New System.Drawing.Size(48, 20)
        Me.xtxt_purch_unit.StatusBarPanelDescripcion = Nothing
        Me.xtxt_purch_unit.TabIndex = 3
        Me.xtxt_purch_unit.Text = ""
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
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"xtxt_item_code=item_code", "LabelProducto=item_name"}
        Me.LibXLookup1.FilterField = "item_name"
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(472, 24)
        Me.LibXLookup1.LookCaption = "Productos"
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup1.ShowFilter = True
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.ShowWarning = False
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SizesColumns = New String() {"item_name=500"}
        Me.LibXLookup1.SizesColumnsTab = Nothing
        Me.LibXLookup1.SqlString = New String() {"select ivitemm.item_code,item_name,abreviada,ivitemd.whse_code,", "purch_unit,ivitemm.unit_code,ivitemm.group_code,group_name,", "ivitemm.sgroup_code,sgroup_name,ivitemm.brand_code,brand_name,", "ivitemd.purch_cost,ivitemd.price,ivitemd.existencia,ivunitd.factor ", "from ivitemm ", "inner join ivitemd", "on ivitemd.item_code = ivitemm.item_code", "left outer join ivgroupm", "on ivgroupm.group_code = ivitemm.group_code ", "left outer join ivsgroupm", "on ivsgroupm.sgroup_code = ivitemm.sgroup_code", "left outer join ivbrandm", "on ivbrandm.brand_code = ivitemm.brand_code", "left outer join ivunitd", "on ivitemm.item_code = ivunitd.item_code", "and ivitemm.purch_unit = ivunitd.unit_code "}
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"item_code=item_code"}
        Me.LibXLookup1.TabIndex = 6
        Me.LibXLookup1.TableName = "ivetiqm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Almacen=whse_code", "Código=item_code", "Descripcion=item_name", "Costo=purch_cost", "Precio=price", "Existencia=existencia", "Unidad=unit_code"}
        Me.LibXLookup1.WhereCondition = ""
        Me.LibXLookup1.WhereParameters = ""
        '
        'LabelProducto
        '
        Me.LabelProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ivetiqm.descripcion"))
        Me.LabelProducto.Location = New System.Drawing.Point(224, 24)
        Me.LabelProducto.Name = "LabelProducto"
        Me.LabelProducto.Size = New System.Drawing.Size(248, 20)
        Me.LabelProducto.TabIndex = 5
        '
        'xtxt_qty
        '
        Me.xtxt_qty.AcceptsReturn = True
        Me.xtxt_qty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.cantidad"))
        Me.xtxt_qty.EditInitialValue = Nothing
        Me.xtxt_qty.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_qty.FieldDescription = ""
        Me.xtxt_qty.FindInitialValue = Nothing
        Me.xtxt_qty.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_qty.IgnoreRequiered = False
        Me.xtxt_qty.Location = New System.Drawing.Point(136, 192)
        Me.xtxt_qty.Name = "xtxt_qty"
        Me.xtxt_qty.NewInitialValue = Nothing
        Me.xtxt_qty.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_qty.Requiered = False
        Me.xtxt_qty.Size = New System.Drawing.Size(80, 20)
        Me.xtxt_qty.StatusBarPanelDescripcion = Nothing
        Me.xtxt_qty.TabIndex = 1
        Me.xtxt_qty.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(72, 24)
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
        Me.Label3.Location = New System.Drawing.Point(72, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Nothing
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_item_code
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_item_code
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(690, 24)
        Me.LibXNavigator1.TabIndex = 2
        '
        'i_ivetiqm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 392)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivetiqm01"
        Me.Text = "Mantenimiento de Etiquetas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXLookup1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibXLookup1.Load

    End Sub

    Private Sub LibXLookup1_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles LibXLookup1.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.IsDataEditing = True Then
                Me.LabelProducto.Text = e.row!item_name.ToString.Trim
                Me.xtxt_abreviada.Text = e.row!abreviada.ToString.Trim
                Me.xtxt_whse_code.Text = e.row!whse_code.ToString.Trim
                Me.xtxt_purch_unit.Text = e.row!purch_unit.ToString.Trim
                Me.xtxt_unit_code.Text = e.row!unit_code.ToString.Trim
                Me.xtxt_group_code.Text = e.row!group_code.ToString.Trim
                Me.LabelGrupo.Text = e.row!group_name.ToString.Trim
                Me.xtxt_sgroup_code.Text = e.row!sgroup_code.ToString.Trim
                Me.LabelSubgrupo.Text = e.row!sgroup_name.ToString.Trim
                Me.xtxt_brand_code.Text = e.row!brand_code.ToString.Trim
                Me.LabelMarca.Text = e.row!brand_name.ToString.Trim
                Me.Labelqty.Text = e.row!existencia.ToString.Trim
                Me.Labelcosto.Text = e.row!purch_cost.ToString.Trim
                Me.Labelprecio.Text = e.row!price.ToString.Trim
                Me.txt_imp_etiq.Text = 0
                Me.Labelprecio2.Text = e.row!price.ToString.Trim * e.row!factor.ToString.Trim
                Me.xlk_whse_code.ExecuteFind()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

   
    'Private Sub LibXLookup1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles LibXLookup1.BeforeExecuteQuery
    '    Try
    '        If LibXConnector1.IsDataEditing = True AndAlso Me.xtxt_whse_code.Text.Trim <> "" Then
    '            'e.aditionalWhere = "whse_code = " & Me.xtxt_whse_code.Text.Trim
    '            Me.xlk_whse_code.ExecuteFind()
    '        End If

    '    Catch ex As Exception
    '        LibX.Log.Add(ex)


    '    End Try
    'End Sub
End Class
