Imports SGT.Administracion.Entidades

Public Class i_ivitem02
    Inherits System.Windows.Forms.Form
    Dim mConf As SGT.Inventario.Common.Configuration
    Dim mUsePrice As Boolean = False
    Dim mCalcular As CalcularEnum = CalcularEnum.Precio

    Enum CalcularEnum
        Precio
        Beneficio
        Costo
        PrecioItbis
    End Enum

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
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox25 As LibX.XTextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TextBox26 As LibX.XTextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TextBox27 As LibX.XTextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents lk_whse_code As LibX.LibXLookup
    Friend WithEvents whse_name As LibX.XTextBox
    Friend WithEvents item_name As LibX.XTextBox
    Friend WithEvents lk_item_code As LibX.LibXLookup
    Friend WithEvents txtTasa As LibX.XMaskEdit
    Friend WithEvents txtitem_code As LibX.XTextBox
    Friend WithEvents txtBenef As LibX.XMaskEdit
    Friend WithEvents txtRound As LibX.XMaskEdit
    Friend WithEvents txtPrice As LibX.XMaskEdit
    Friend WithEvents cbx_AllowBO As LibX.LibxCheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtwhse_code As LibX.XTextBox
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnSerie As System.Windows.Forms.Button
    Friend WithEvents btnMov As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LibxCheckBox2 As LibX.LibxCheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtCosto As LibX.XMaskEdit
    Friend WithEvents txtITBIS As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As LibX.XMaskEdit
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents xchk_PagaITBIS As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox3 As LibX.LibxCheckBox
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
    Friend WithEvents ButtonEstadisticas As System.Windows.Forms.Button
    Friend WithEvents xtxtRound As LibX.XMaskEdit
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents xtxt_disc_pct As LibX.XMaskEdit
    Friend WithEvents xck_aplica_dscnt As LibX.LibxCheckBox
    Friend WithEvents txtPrecio2 As LibX.XMaskEdit
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents xchk_PagaITBIS2 As LibX.LibxCheckBox
    Friend WithEvents XMaskEdit1 As LibX.XMaskEdit
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label25 = New System.Windows.Forms.Label
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
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.LibxCheckBox2 = New LibX.LibxCheckBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTasa = New LibX.XMaskEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtPrice = New LibX.XMaskEdit
        Me.cbx_AllowBO = New LibX.LibxCheckBox
        Me.xtxtRound = New LibX.XMaskEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.XMaskEdit1 = New LibX.XMaskEdit
        Me.Label37 = New System.Windows.Forms.Label
        Me.xchk_PagaITBIS2 = New LibX.LibxCheckBox
        Me.txtPrecio2 = New LibX.XMaskEdit
        Me.LibxCheckBox3 = New LibX.LibxCheckBox
        Me.xchk_PagaITBIS = New LibX.LibxCheckBox
        Me.xck_aplica_dscnt = New LibX.LibxCheckBox
        Me.txtCosto = New LibX.XMaskEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtITBIS = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPrecio = New LibX.XMaskEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtRound = New LibX.XMaskEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtBenef = New LibX.XMaskEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.xtxt_disc_pct = New LibX.XMaskEdit
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TextBox25 = New LibX.XTextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.TextBox26 = New LibX.XTextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.TextBox27 = New LibX.XTextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.lk_whse_code = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.whse_name = New LibX.XTextBox
        Me.txtwhse_code = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.item_name = New LibX.XTextBox
        Me.txtitem_code = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lk_item_code = New LibX.LibXLookup
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.btnSerie = New System.Windows.Forms.Button
        Me.btnMov = New System.Windows.Forms.Button
        Me.ButtonEstadisticas = New System.Windows.Forms.Button
        Me.Label38 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.lk_whse_code)
        Me.GroupBox1.Controls.Add(Me.whse_name)
        Me.GroupBox1.Controls.Add(Me.txtwhse_code)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.item_name)
        Me.GroupBox1.Controls.Add(Me.txtitem_code)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lk_item_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 432)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label25)
        Me.GroupBox8.Controls.Add(Me.Label21)
        Me.GroupBox8.Controls.Add(Me.Label11)
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.Label28)
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox8.Location = New System.Drawing.Point(208, 192)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(240, 120)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Back Order"
        '
        'Label25
        '
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.existencia"))
        Me.Label25.Location = New System.Drawing.Point(136, 92)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 20)
        Me.Label25.TabIndex = 26
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"whse_code", "item_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2}
        Me.DataTable1.TableName = "ivitemd"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "whse_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
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
        Me.DataColumn3.ColumnName = "purch_cost"
        Me.DataColumn3.DataType = GetType(System.Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "porc_isc"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "last_cost"
        Me.DataColumn5.DataType = GetType(System.Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "avg_cost"
        Me.DataColumn6.DataType = GetType(System.Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "loc_row"
        Me.DataColumn7.MaxLength = 20
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "loc_col"
        Me.DataColumn8.MaxLength = 20
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "estante"
        Me.DataColumn9.MaxLength = 20
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "price"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "benef"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "BackOrder"
        Me.DataColumn12.DataType = GetType(System.Int16)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "existencia"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "datelast_purch"
        Me.DataColumn14.DataType = GetType(System.DateTime)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "datelast_sales"
        Me.DataColumn15.DataType = GetType(System.DateTime)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "taxable"
        Me.DataColumn16.DataType = GetType(System.Int16)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "rounded"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "Rorder_point"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "existencia_min"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "exitencia_max"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "cant_pedida"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "cant_recibida"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "numero_orden"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "frizado_inv"
        Me.DataColumn24.DataType = GetType(System.Int16)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "aplica_dscnt"
        Me.DataColumn25.DataType = GetType(System.Int16)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "fecha_frizado"
        Me.DataColumn26.DataType = GetType(System.DateTime)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "limite_frizado"
        Me.DataColumn27.DataType = GetType(System.DateTime)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "fecha_conteo"
        Me.DataColumn28.DataType = GetType(System.DateTime)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "ultima_trans"
        Me.DataColumn29.DataType = GetType(System.Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "vencimiento"
        Me.DataColumn30.DataType = GetType(System.Int16)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "itbis"
        Me.DataColumn31.DataType = GetType(System.Decimal)
        Me.DataColumn31.ReadOnly = True
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "precioitbis"
        Me.DataColumn32.DataType = GetType(System.Decimal)
        Me.DataColumn32.ReadOnly = True
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "disc_pct"
        Me.DataColumn33.DataType = GetType(System.Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "taxable2"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.cant_recibida"))
        Me.Label21.Location = New System.Drawing.Point(136, 68)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 20)
        Me.Label21.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.cant_pedida"))
        Me.Label11.Location = New System.Drawing.Point(136, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.numero_orden"))
        Me.Label8.Location = New System.Drawing.Point(136, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(24, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Cantidad Ordnada:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(24, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Cantidad Recibida:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(62, 92)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(62, 16)
        Me.Label28.TabIndex = 22
        Me.Label28.Text = "Existencia:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(42, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Numero Orden:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.LibxCheckBox2)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox4.Location = New System.Drawing.Point(456, 72)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(216, 112)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Control Inventario Fisico"
        '
        'Label31
        '
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label31.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.limite_frizado"))
        Me.Label31.Location = New System.Drawing.Point(112, 72)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 20)
        Me.Label31.TabIndex = 25
        '
        'Label30
        '
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label30.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.fecha_frizado"))
        Me.Label30.Location = New System.Drawing.Point(112, 46)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(88, 20)
        Me.Label30.TabIndex = 24
        '
        'LibxCheckBox2
        '
        Me.LibxCheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivitemd.frizado_inv"))
        Me.LibxCheckBox2.EditInitialValue = Nothing
        Me.LibxCheckBox2.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxCheckBox2.FindInitialValue = Nothing
        Me.LibxCheckBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.IgnoreRequiered = False
        Me.LibxCheckBox2.KeepEnabled = False
        Me.LibxCheckBox2.Location = New System.Drawing.Point(16, 24)
        Me.LibxCheckBox2.Name = "LibxCheckBox2"
        Me.LibxCheckBox2.NewInitialValue = Nothing
        Me.LibxCheckBox2.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxCheckBox2.ReadOnly = False
        Me.LibxCheckBox2.Requiered = False
        Me.LibxCheckBox2.Size = New System.Drawing.Size(184, 16)
        Me.LibxCheckBox2.TabIndex = 0
        Me.LibxCheckBox2.Text = "Existencia Frizada"
        Me.LibxCheckBox2.ThreeState = True
        Me.LibxCheckBox2.value = Nothing
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label18.Location = New System.Drawing.Point(24, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 16)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Limite Frizado"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label29.Location = New System.Drawing.Point(24, 48)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(77, 16)
        Me.Label29.TabIndex = 19
        Me.Label29.Text = "Fecha Frizado"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtTasa)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtPrice)
        Me.GroupBox3.Controls.Add(Me.cbx_AllowBO)
        Me.GroupBox3.Controls.Add(Me.xtxtRound)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Location = New System.Drawing.Point(208, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 112)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Control Compras"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(24, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Existencia Maxima:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTasa
        '
        Me.txtTasa.AcceptsReturn = True
        Me.txtTasa.BackColor = System.Drawing.SystemColors.Window
        Me.txtTasa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.existencia_min"))
        Me.txtTasa.EditInitialValue = Nothing
        Me.txtTasa.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTasa.FieldDescription = ""
        Me.txtTasa.FindInitialValue = Nothing
        Me.txtTasa.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTasa.IgnoreRequiered = False
        Me.txtTasa.Location = New System.Drawing.Point(136, 40)
        Me.txtTasa.Masked = MaskedTextBox.Mask.Decimal
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.NewInitialValue = Nothing
        Me.txtTasa.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtTasa.ReadOnly = True
        Me.txtTasa.Requiered = False
        Me.txtTasa.Size = New System.Drawing.Size(72, 20)
        Me.txtTasa.StatusBarPanelDescripcion = Nothing
        Me.txtTasa.TabIndex = 1
        Me.txtTasa.TabStop = False
        Me.txtTasa.Text = ""
        Me.txtTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(24, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 16)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Existencia Minimo:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPrice
        '
        Me.txtPrice.AcceptsReturn = True
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.exitencia_max"))
        Me.txtPrice.EditInitialValue = Nothing
        Me.txtPrice.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPrice.FieldDescription = ""
        Me.txtPrice.FindInitialValue = Nothing
        Me.txtPrice.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPrice.IgnoreRequiered = False
        Me.txtPrice.Location = New System.Drawing.Point(136, 16)
        Me.txtPrice.Masked = MaskedTextBox.Mask.Decimal
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.NewInitialValue = Nothing
        Me.txtPrice.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPrice.Requiered = False
        Me.txtPrice.Size = New System.Drawing.Size(72, 20)
        Me.txtPrice.StatusBarPanelDescripcion = Nothing
        Me.txtPrice.TabIndex = 0
        Me.txtPrice.TabStop = False
        Me.txtPrice.Text = ""
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbx_AllowBO
        '
        Me.cbx_AllowBO.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbx_AllowBO.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivitemd.BackOrder"))
        Me.cbx_AllowBO.EditInitialValue = Nothing
        Me.cbx_AllowBO.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cbx_AllowBO.FindInitialValue = Nothing
        Me.cbx_AllowBO.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cbx_AllowBO.IgnoreRequiered = False
        Me.cbx_AllowBO.KeepEnabled = False
        Me.cbx_AllowBO.Location = New System.Drawing.Point(72, 88)
        Me.cbx_AllowBO.Name = "cbx_AllowBO"
        Me.cbx_AllowBO.NewInitialValue = Nothing
        Me.cbx_AllowBO.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cbx_AllowBO.ReadOnly = False
        Me.cbx_AllowBO.Requiered = False
        Me.cbx_AllowBO.Size = New System.Drawing.Size(136, 16)
        Me.cbx_AllowBO.TabIndex = 3
        Me.cbx_AllowBO.Text = "BackOrder"
        Me.cbx_AllowBO.ThreeState = True
        Me.cbx_AllowBO.value = Nothing
        '
        'xtxtRound
        '
        Me.xtxtRound.AcceptsReturn = True
        Me.xtxtRound.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.Rorder_point"))
        Me.xtxtRound.EditInitialValue = Nothing
        Me.xtxtRound.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtRound.FieldDescription = ""
        Me.xtxtRound.FindInitialValue = Nothing
        Me.xtxtRound.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtRound.IgnoreRequiered = False
        Me.xtxtRound.Location = New System.Drawing.Point(136, 64)
        Me.xtxtRound.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxtRound.Name = "xtxtRound"
        Me.xtxtRound.NewInitialValue = Nothing
        Me.xtxtRound.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtRound.Requiered = False
        Me.xtxtRound.Size = New System.Drawing.Size(72, 20)
        Me.xtxtRound.StatusBarPanelDescripcion = Nothing
        Me.xtxtRound.TabIndex = 2
        Me.xtxtRound.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(72, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Reorden:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.XMaskEdit1)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.xchk_PagaITBIS2)
        Me.GroupBox2.Controls.Add(Me.txtPrecio2)
        Me.GroupBox2.Controls.Add(Me.LibxCheckBox3)
        Me.GroupBox2.Controls.Add(Me.xchk_PagaITBIS)
        Me.GroupBox2.Controls.Add(Me.xck_aplica_dscnt)
        Me.GroupBox2.Controls.Add(Me.txtCosto)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtITBIS)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtRound)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtBenef)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.xtxt_disc_pct)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(8, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 344)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Costos"
        '
        'XMaskEdit1
        '
        Me.XMaskEdit1.AcceptsReturn = True
        Me.XMaskEdit1.BackColor = System.Drawing.SystemColors.Window
        Me.XMaskEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.porc_isc"))
        Me.XMaskEdit1.EditInitialValue = Nothing
        Me.XMaskEdit1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.FieldDescription = ""
        Me.XMaskEdit1.FindInitialValue = Nothing
        Me.XMaskEdit1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.IgnoreRequiered = False
        Me.XMaskEdit1.Location = New System.Drawing.Point(104, 264)
        Me.XMaskEdit1.Masked = MaskedTextBox.Mask.Decimal
        Me.XMaskEdit1.Name = "XMaskEdit1"
        Me.XMaskEdit1.NewInitialValue = Nothing
        Me.XMaskEdit1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.ReadOnly = True
        Me.XMaskEdit1.Requiered = False
        Me.XMaskEdit1.Size = New System.Drawing.Size(72, 20)
        Me.XMaskEdit1.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit1.TabIndex = 18
        Me.XMaskEdit1.TabStop = False
        Me.XMaskEdit1.Text = ""
        Me.XMaskEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label37.Location = New System.Drawing.Point(8, 264)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(86, 16)
        Me.Label37.TabIndex = 19
        Me.Label37.Text = "Descto Lineal %"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xchk_PagaITBIS2
        '
        Me.xchk_PagaITBIS2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xchk_PagaITBIS2.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivitemd.taxable2"))
        Me.xchk_PagaITBIS2.EditInitialValue = Nothing
        Me.xchk_PagaITBIS2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xchk_PagaITBIS2.FindInitialValue = Nothing
        Me.xchk_PagaITBIS2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xchk_PagaITBIS2.IgnoreRequiered = False
        Me.xchk_PagaITBIS2.KeepEnabled = False
        Me.xchk_PagaITBIS2.Location = New System.Drawing.Point(31, 130)
        Me.xchk_PagaITBIS2.Name = "xchk_PagaITBIS2"
        Me.xchk_PagaITBIS2.NewInitialValue = Nothing
        Me.xchk_PagaITBIS2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xchk_PagaITBIS2.ReadOnly = False
        Me.xchk_PagaITBIS2.Requiered = False
        Me.xchk_PagaITBIS2.Size = New System.Drawing.Size(144, 16)
        Me.xchk_PagaITBIS2.TabIndex = 17
        Me.xchk_PagaITBIS2.Text = "Paga ITBIS Dos"
        Me.xchk_PagaITBIS2.ThreeState = True
        Me.xchk_PagaITBIS2.value = Nothing
        '
        'txtPrecio2
        '
        Me.txtPrecio2.AcceptsReturn = True
        Me.txtPrecio2.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrecio2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.precioitbis"))
        Me.txtPrecio2.EditInitialValue = Nothing
        Me.txtPrecio2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPrecio2.FieldDescription = ""
        Me.txtPrecio2.FindInitialValue = Nothing
        Me.txtPrecio2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPrecio2.IgnoreRequiered = False
        Me.txtPrecio2.Location = New System.Drawing.Point(104, 171)
        Me.txtPrecio2.Masked = MaskedTextBox.Mask.Decimal
        Me.txtPrecio2.Name = "txtPrecio2"
        Me.txtPrecio2.NewInitialValue = Nothing
        Me.txtPrecio2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPrecio2.ReadOnly = True
        Me.txtPrecio2.Requiered = False
        Me.txtPrecio2.Size = New System.Drawing.Size(72, 20)
        Me.txtPrecio2.StatusBarPanelDescripcion = Nothing
        Me.txtPrecio2.TabIndex = 16
        Me.txtPrecio2.TabStop = False
        Me.txtPrecio2.Text = ""
        Me.txtPrecio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LibxCheckBox3
        '
        Me.LibxCheckBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivitemd.vencimiento"))
        Me.LibxCheckBox3.EditInitialValue = Nothing
        Me.LibxCheckBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.FindInitialValue = Nothing
        Me.LibxCheckBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.IgnoreRequiered = False
        Me.LibxCheckBox3.KeepEnabled = False
        Me.LibxCheckBox3.Location = New System.Drawing.Point(8, 240)
        Me.LibxCheckBox3.Name = "LibxCheckBox3"
        Me.LibxCheckBox3.NewInitialValue = Nothing
        Me.LibxCheckBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.ReadOnly = False
        Me.LibxCheckBox3.Requiered = False
        Me.LibxCheckBox3.Size = New System.Drawing.Size(112, 16)
        Me.LibxCheckBox3.TabIndex = 15
        Me.LibxCheckBox3.Text = "Aplica Vencimientos"
        Me.LibxCheckBox3.ThreeState = True
        Me.LibxCheckBox3.value = 0
        '
        'xchk_PagaITBIS
        '
        Me.xchk_PagaITBIS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xchk_PagaITBIS.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivitemd.taxable"))
        Me.xchk_PagaITBIS.EditInitialValue = Nothing
        Me.xchk_PagaITBIS.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xchk_PagaITBIS.FindInitialValue = Nothing
        Me.xchk_PagaITBIS.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xchk_PagaITBIS.IgnoreRequiered = False
        Me.xchk_PagaITBIS.KeepEnabled = False
        Me.xchk_PagaITBIS.Location = New System.Drawing.Point(32, 112)
        Me.xchk_PagaITBIS.Name = "xchk_PagaITBIS"
        Me.xchk_PagaITBIS.NewInitialValue = Nothing
        Me.xchk_PagaITBIS.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xchk_PagaITBIS.ReadOnly = False
        Me.xchk_PagaITBIS.Requiered = False
        Me.xchk_PagaITBIS.Size = New System.Drawing.Size(144, 16)
        Me.xchk_PagaITBIS.TabIndex = 14
        Me.xchk_PagaITBIS.Text = "Paga ITBIS Uno"
        Me.xchk_PagaITBIS.ThreeState = True
        Me.xchk_PagaITBIS.value = Nothing
        '
        'xck_aplica_dscnt
        '
        Me.xck_aplica_dscnt.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xck_aplica_dscnt.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivitemd.aplica_dscnt"))
        Me.xck_aplica_dscnt.EditInitialValue = Nothing
        Me.xck_aplica_dscnt.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_aplica_dscnt.FindInitialValue = Nothing
        Me.xck_aplica_dscnt.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_aplica_dscnt.IgnoreRequiered = False
        Me.xck_aplica_dscnt.KeepEnabled = False
        Me.xck_aplica_dscnt.Location = New System.Drawing.Point(8, 195)
        Me.xck_aplica_dscnt.Name = "xck_aplica_dscnt"
        Me.xck_aplica_dscnt.NewInitialValue = Nothing
        Me.xck_aplica_dscnt.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_aplica_dscnt.ReadOnly = False
        Me.xck_aplica_dscnt.Requiered = False
        Me.xck_aplica_dscnt.Size = New System.Drawing.Size(112, 16)
        Me.xck_aplica_dscnt.TabIndex = 6
        Me.xck_aplica_dscnt.Text = "Descuento(%)  :"
        Me.xck_aplica_dscnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xck_aplica_dscnt.ThreeState = True
        Me.xck_aplica_dscnt.value = Nothing
        '
        'txtCosto
        '
        Me.txtCosto.AcceptsReturn = True
        Me.txtCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.purch_cost"))
        Me.txtCosto.EditInitialValue = Nothing
        Me.txtCosto.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCosto.FieldDescription = ""
        Me.txtCosto.FindInitialValue = Nothing
        Me.txtCosto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCosto.IgnoreRequiered = False
        Me.txtCosto.Location = New System.Drawing.Point(104, 16)
        Me.txtCosto.Masked = MaskedTextBox.Mask.Decimal
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.NewInitialValue = Nothing
        Me.txtCosto.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtCosto.Requiered = False
        Me.txtCosto.Size = New System.Drawing.Size(72, 20)
        Me.txtCosto.StatusBarPanelDescripcion = Nothing
        Me.txtCosto.TabIndex = 0
        Me.txtCosto.Text = ""
        Me.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(16, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Precio+ITBIS:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(53, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Costo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtITBIS
        '
        Me.txtITBIS.BackColor = System.Drawing.SystemColors.Control
        Me.txtITBIS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtITBIS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.itbis"))
        Me.txtITBIS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtITBIS.Location = New System.Drawing.Point(104, 147)
        Me.txtITBIS.Name = "txtITBIS"
        Me.txtITBIS.Size = New System.Drawing.Size(72, 20)
        Me.txtITBIS.TabIndex = 4
        Me.txtITBIS.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(56, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "ITBIS:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPrecio
        '
        Me.txtPrecio.AcceptsReturn = True
        Me.txtPrecio.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.price"))
        Me.txtPrecio.EditInitialValue = Nothing
        Me.txtPrecio.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPrecio.FieldDescription = ""
        Me.txtPrecio.FindInitialValue = Nothing
        Me.txtPrecio.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPrecio.IgnoreRequiered = False
        Me.txtPrecio.Location = New System.Drawing.Point(104, 88)
        Me.txtPrecio.Masked = MaskedTextBox.Mask.Decimal
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.NewInitialValue = Nothing
        Me.txtPrecio.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Requiered = False
        Me.txtPrecio.Size = New System.Drawing.Size(72, 20)
        Me.txtPrecio.StatusBarPanelDescripcion = Nothing
        Me.txtPrecio.TabIndex = 3
        Me.txtPrecio.TabStop = False
        Me.txtPrecio.Text = ""
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(51, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Precio:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtRound
        '
        Me.txtRound.AcceptsReturn = True
        Me.txtRound.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.rounded"))
        Me.txtRound.EditInitialValue = Nothing
        Me.txtRound.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtRound.FieldDescription = ""
        Me.txtRound.FindInitialValue = Nothing
        Me.txtRound.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtRound.IgnoreRequiered = False
        Me.txtRound.Location = New System.Drawing.Point(104, 64)
        Me.txtRound.Masked = MaskedTextBox.Mask.Decimal
        Me.txtRound.Name = "txtRound"
        Me.txtRound.NewInitialValue = Nothing
        Me.txtRound.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtRound.Requiered = False
        Me.txtRound.Size = New System.Drawing.Size(72, 20)
        Me.txtRound.StatusBarPanelDescripcion = Nothing
        Me.txtRound.TabIndex = 2
        Me.txtRound.Text = ""
        Me.txtRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Location = New System.Drawing.Point(30, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 16)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Redondeo:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtBenef
        '
        Me.txtBenef.AcceptsReturn = True
        Me.txtBenef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.benef"))
        Me.txtBenef.EditInitialValue = Nothing
        Me.txtBenef.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtBenef.FieldDescription = ""
        Me.txtBenef.FindInitialValue = Nothing
        Me.txtBenef.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtBenef.IgnoreRequiered = False
        Me.txtBenef.Location = New System.Drawing.Point(104, 40)
        Me.txtBenef.Masked = MaskedTextBox.Mask.Decimal
        Me.txtBenef.Name = "txtBenef"
        Me.txtBenef.NewInitialValue = Nothing
        Me.txtBenef.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtBenef.Requiered = False
        Me.txtBenef.Size = New System.Drawing.Size(72, 20)
        Me.txtBenef.StatusBarPanelDescripcion = Nothing
        Me.txtBenef.TabIndex = 1
        Me.txtBenef.Text = ""
        Me.txtBenef.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(26, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "% Beneficio"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_disc_pct
        '
        Me.xtxt_disc_pct.AcceptsReturn = True
        Me.xtxt_disc_pct.BackColor = System.Drawing.SystemColors.Window
        Me.xtxt_disc_pct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.disc_pct"))
        Me.xtxt_disc_pct.EditInitialValue = Nothing
        Me.xtxt_disc_pct.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_disc_pct.FieldDescription = ""
        Me.xtxt_disc_pct.FindInitialValue = Nothing
        Me.xtxt_disc_pct.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_disc_pct.IgnoreRequiered = False
        Me.xtxt_disc_pct.Location = New System.Drawing.Point(104, 216)
        Me.xtxt_disc_pct.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxt_disc_pct.Name = "xtxt_disc_pct"
        Me.xtxt_disc_pct.NewInitialValue = Nothing
        Me.xtxt_disc_pct.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_disc_pct.ReadOnly = True
        Me.xtxt_disc_pct.Requiered = False
        Me.xtxt_disc_pct.Size = New System.Drawing.Size(72, 20)
        Me.xtxt_disc_pct.StatusBarPanelDescripcion = Nothing
        Me.xtxt_disc_pct.TabIndex = 3
        Me.xtxt_disc_pct.TabStop = False
        Me.xtxt_disc_pct.Text = ""
        Me.xtxt_disc_pct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label36)
        Me.GroupBox7.Controls.Add(Me.Label35)
        Me.GroupBox7.Controls.Add(Me.Label34)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.Label26)
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox7.Location = New System.Drawing.Point(456, 320)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(216, 96)
        Me.GroupBox7.TabIndex = 8
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Fechas"
        '
        'Label36
        '
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label36.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.fecha_conteo"))
        Me.Label36.Location = New System.Drawing.Point(112, 64)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(88, 20)
        Me.Label36.TabIndex = 26
        '
        'Label35
        '
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label35.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.datelast_sales"))
        Me.Label35.Location = New System.Drawing.Point(112, 40)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(88, 20)
        Me.Label35.TabIndex = 25
        '
        'Label34
        '
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label34.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.datelast_purch"))
        Me.Label34.Location = New System.Drawing.Point(112, 16)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(88, 20)
        Me.Label34.TabIndex = 24
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Location = New System.Drawing.Point(15, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 16)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Ultimo Conteo:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label26.Location = New System.Drawing.Point(11, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(83, 16)
        Me.Label26.TabIndex = 15
        Me.Label26.Text = "Ultima Compra:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label27.Location = New System.Drawing.Point(24, 40)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(70, 16)
        Me.Label27.TabIndex = 15
        Me.Label27.Text = "Ultima venta:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBox25)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.TextBox26)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.TextBox27)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox6.Location = New System.Drawing.Point(208, 320)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(240, 96)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Localizacón"
        '
        'TextBox25
        '
        Me.TextBox25.AcceptsReturn = True
        Me.TextBox25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.estante"))
        Me.TextBox25.EditInitialValue = Nothing
        Me.TextBox25.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox25.FieldDescription = ""
        Me.TextBox25.FindInitialValue = Nothing
        Me.TextBox25.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox25.IgnoreRequiered = False
        Me.TextBox25.Location = New System.Drawing.Point(136, 16)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.NewInitialValue = Nothing
        Me.TextBox25.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox25.Requiered = False
        Me.TextBox25.Size = New System.Drawing.Size(72, 20)
        Me.TextBox25.StatusBarPanelDescripcion = Nothing
        Me.TextBox25.TabIndex = 0
        Me.TextBox25.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label22.Location = New System.Drawing.Point(80, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 16)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Estante:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox26
        '
        Me.TextBox26.AcceptsReturn = True
        Me.TextBox26.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.loc_row"))
        Me.TextBox26.EditInitialValue = Nothing
        Me.TextBox26.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox26.FieldDescription = ""
        Me.TextBox26.FindInitialValue = Nothing
        Me.TextBox26.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox26.IgnoreRequiered = False
        Me.TextBox26.Location = New System.Drawing.Point(136, 40)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.NewInitialValue = Nothing
        Me.TextBox26.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox26.Requiered = False
        Me.TextBox26.Size = New System.Drawing.Size(72, 20)
        Me.TextBox26.StatusBarPanelDescripcion = Nothing
        Me.TextBox26.TabIndex = 1
        Me.TextBox26.Text = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label23.Location = New System.Drawing.Point(100, 40)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(26, 16)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "Fila:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label24.Location = New System.Drawing.Point(73, 64)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 16)
        Me.Label24.TabIndex = 15
        Me.Label24.Text = "Columna:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox27
        '
        Me.TextBox27.AcceptsReturn = True
        Me.TextBox27.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.loc_col"))
        Me.TextBox27.EditInitialValue = Nothing
        Me.TextBox27.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox27.FieldDescription = ""
        Me.TextBox27.FindInitialValue = Nothing
        Me.TextBox27.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox27.IgnoreRequiered = False
        Me.TextBox27.Location = New System.Drawing.Point(136, 64)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.NewInitialValue = Nothing
        Me.TextBox27.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox27.Requiered = False
        Me.TextBox27.Size = New System.Drawing.Size(72, 20)
        Me.TextBox27.StatusBarPanelDescripcion = Nothing
        Me.TextBox27.TabIndex = 2
        Me.TextBox27.Text = ""
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label33)
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox5.Location = New System.Drawing.Point(456, 192)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(216, 120)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Histórico de Costos"
        '
        'Label33
        '
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label33.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.avg_cost"))
        Me.Label33.Location = New System.Drawing.Point(112, 40)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(88, 20)
        Me.Label33.TabIndex = 25
        '
        'Label32
        '
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label32.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.last_cost"))
        Me.Label32.Location = New System.Drawing.Point(112, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 20)
        Me.Label32.TabIndex = 24
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label19.Location = New System.Drawing.Point(56, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 16)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Ultimo:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label20.Location = New System.Drawing.Point(40, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 16)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Promedio:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lk_whse_code
        '
        Me.lk_whse_code.AlternateFieldSearch = Nothing
        Me.lk_whse_code.BeginCheck = False
        Me.lk_whse_code.CheckText = Nothing
        Me.lk_whse_code.ComboMode = False
        Me.lk_whse_code.DataMember = Nothing
        Me.lk_whse_code.DataSource = Me.LibXConnector1
        Me.lk_whse_code.DestParameters = New String() {"whse_code=whse_code", "whse_name=whse_name"}
        Me.lk_whse_code.FilterField = Nothing
        Me.lk_whse_code.IgnoreFindInBrowseMode = False
        Me.lk_whse_code.isCanceled = False
        Me.lk_whse_code.Location = New System.Drawing.Point(648, 48)
        Me.lk_whse_code.LookCaption = Nothing
        Me.lk_whse_code.Name = "lk_whse_code"
        Me.lk_whse_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lk_whse_code.ShowFilter = True
        Me.lk_whse_code.ShowMessageNotFound = True
        Me.lk_whse_code.ShowWarning = False
        Me.lk_whse_code.Size = New System.Drawing.Size(16, 20)
        Me.lk_whse_code.SizesColumns = Nothing
        Me.lk_whse_code.SizesColumnsTab = Nothing
        Me.lk_whse_code.SqlString = Nothing
        Me.lk_whse_code.SQLTab = Nothing
        Me.lk_whse_code.SrcParameters = New String() {"whse_code=whse_code"}
        Me.lk_whse_code.TabIndex = 14
        Me.lk_whse_code.TableName = "ivwhsem"
        Me.lk_whse_code.TabStop = False
        Me.lk_whse_code.UseCopyConnection = False
        Me.lk_whse_code.UseRowRetrieveEvents = False
        Me.lk_whse_code.UseTab = False
        Me.lk_whse_code.VisParameters = New String() {"Código=whse_code", "Almacén=whse_name"}
        Me.lk_whse_code.WhereCondition = Nothing
        Me.lk_whse_code.WhereParameters = Nothing
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = True
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "ivitemd"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
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
        Me.LibXDbSourceTable1.KeyFields = ""
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select ivitemd.*, ivitemv.itbis, ivitemv.precioitbis", "from ivitemd inner join ivitemv", "on ivitemd.item_code = ivitemv.item_code", "and ivitemd.whse_code = ivitemv.whse_code"}
        Me.LibXDbSourceTable1.TableName = "ivitemd"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
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
        Me.whse_name.Location = New System.Drawing.Point(192, 48)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.NewInitialValue = Nothing
        Me.whse_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.ReadOnly = True
        Me.whse_name.Requiered = False
        Me.whse_name.Size = New System.Drawing.Size(456, 20)
        Me.whse_name.StatusBarPanelDescripcion = Nothing
        Me.whse_name.TabIndex = 13
        Me.whse_name.TabStop = False
        Me.whse_name.Text = ""
        '
        'txtwhse_code
        '
        Me.txtwhse_code.AcceptsReturn = True
        Me.txtwhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.whse_code"))
        Me.txtwhse_code.EditInitialValue = Nothing
        Me.txtwhse_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtwhse_code.FieldDescription = ""
        Me.txtwhse_code.FindInitialValue = Nothing
        Me.txtwhse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.IgnoreRequiered = False
        Me.txtwhse_code.Location = New System.Drawing.Point(112, 48)
        Me.txtwhse_code.Name = "txtwhse_code"
        Me.txtwhse_code.NewInitialValue = Nothing
        Me.txtwhse_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.Requiered = False
        Me.txtwhse_code.Size = New System.Drawing.Size(72, 20)
        Me.txtwhse_code.StatusBarPanelDescripcion = Nothing
        Me.txtwhse_code.TabIndex = 1
        Me.txtwhse_code.Text = ""
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Almacen:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'item_name
        '
        Me.item_name.AcceptsReturn = True
        Me.item_name.EditInitialValue = Nothing
        Me.item_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.item_name.FieldDescription = ""
        Me.item_name.FindInitialValue = Nothing
        Me.item_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.item_name.IgnoreRequiered = False
        Me.item_name.Location = New System.Drawing.Point(192, 24)
        Me.item_name.Name = "item_name"
        Me.item_name.NewInitialValue = Nothing
        Me.item_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.item_name.ReadOnly = True
        Me.item_name.Requiered = False
        Me.item_name.Size = New System.Drawing.Size(456, 20)
        Me.item_name.StatusBarPanelDescripcion = Nothing
        Me.item_name.TabIndex = 10
        Me.item_name.TabStop = False
        Me.item_name.Text = ""
        '
        'txtitem_code
        '
        Me.txtitem_code.AcceptsReturn = True
        Me.txtitem_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemd.item_code"))
        Me.txtitem_code.EditInitialValue = Nothing
        Me.txtitem_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtitem_code.FieldDescription = ""
        Me.txtitem_code.FindInitialValue = Nothing
        Me.txtitem_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtitem_code.IgnoreRequiered = False
        Me.txtitem_code.Location = New System.Drawing.Point(112, 24)
        Me.txtitem_code.Name = "txtitem_code"
        Me.txtitem_code.NewInitialValue = Nothing
        Me.txtitem_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtitem_code.ReadOnly = True
        Me.txtitem_code.Requiered = False
        Me.txtitem_code.Size = New System.Drawing.Size(72, 20)
        Me.txtitem_code.StatusBarPanelDescripcion = Nothing
        Me.txtitem_code.TabIndex = 0
        Me.txtitem_code.TabStop = False
        Me.txtitem_code.Text = ""
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Articulo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lk_item_code
        '
        Me.lk_item_code.AlternateFieldSearch = Nothing
        Me.lk_item_code.BeginCheck = False
        Me.lk_item_code.CheckText = Nothing
        Me.lk_item_code.ComboMode = False
        Me.lk_item_code.DataMember = Nothing
        Me.lk_item_code.DataSource = Me.LibXConnector1
        Me.lk_item_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name"}
        Me.lk_item_code.FilterField = Nothing
        Me.lk_item_code.IgnoreFindInBrowseMode = False
        Me.lk_item_code.isCanceled = False
        Me.lk_item_code.Location = New System.Drawing.Point(648, 24)
        Me.lk_item_code.LookCaption = "Productos"
        Me.lk_item_code.Name = "lk_item_code"
        Me.lk_item_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lk_item_code.ShowFilter = True
        Me.lk_item_code.ShowMessageNotFound = True
        Me.lk_item_code.ShowWarning = False
        Me.lk_item_code.Size = New System.Drawing.Size(16, 20)
        Me.lk_item_code.SizesColumns = Nothing
        Me.lk_item_code.SizesColumnsTab = Nothing
        Me.lk_item_code.SqlString = Nothing
        Me.lk_item_code.SQLTab = Nothing
        Me.lk_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.lk_item_code.TabIndex = 14
        Me.lk_item_code.TableName = "ivitemm"
        Me.lk_item_code.TabStop = False
        Me.lk_item_code.UseCopyConnection = False
        Me.lk_item_code.UseRowRetrieveEvents = False
        Me.lk_item_code.UseTab = False
        Me.lk_item_code.VisParameters = New String() {"Código=item_code", "Producto=item_name"}
        Me.lk_item_code.WhereCondition = Nothing
        Me.lk_item_code.WhereParameters = Nothing
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
        Me.LibXNavigator1.TabIndex = 1
        '
        'btnSerie
        '
        Me.btnSerie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSerie.Location = New System.Drawing.Point(8, 480)
        Me.btnSerie.Name = "btnSerie"
        Me.btnSerie.TabIndex = 3
        Me.btnSerie.Text = "Vencimientos"
        '
        'btnMov
        '
        Me.btnMov.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMov.Location = New System.Drawing.Point(88, 480)
        Me.btnMov.Name = "btnMov"
        Me.btnMov.TabIndex = 0
        Me.btnMov.Text = "Movimientos"
        '
        'ButtonEstadisticas
        '
        Me.ButtonEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEstadisticas.Location = New System.Drawing.Point(168, 480)
        Me.ButtonEstadisticas.Name = "ButtonEstadisticas"
        Me.ButtonEstadisticas.TabIndex = 4
        Me.ButtonEstadisticas.Text = "Estadisticas"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label38.Location = New System.Drawing.Point(24, 216)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(71, 16)
        Me.Label38.TabIndex = 20
        Me.Label38.Text = "Descuento %"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'i_ivitem02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(698, 528)
        Me.Controls.Add(Me.ButtonEstadisticas)
        Me.Controls.Add(Me.btnSerie)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMov)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivitem02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Mantenimiento de Almacen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub i_ivitem02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mConf = New SGT.Inventario.Common.Configuration
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub FillItem()
        Dim oRow As DataRow
        Try
            If Not LibXConnector1.Parameters Is Nothing Then
                If Not LibXConnector1.Parameters.Value Is Nothing Then
                    If CType(LibXConnector1.Parameters.Value, String).Trim.Length > 0 Then
                        txtitem_code.Text = LibXConnector1.Parameters.Value
                        lk_item_code.ExecuteFind()
                    End If
                End If
                If LibXConnector1.Parameters.Datos.Count > 0 Then
                    If LibXConnector1.Parameters.Datos.Contains("ITBIS") Then
                        xchk_PagaITBIS.Checked = LibXConnector1.Parameters.Datos.Item("ITBIS")
                    End If
                End If
            End If

            oRow = LibX.Data.Manager.GetDataRow("select * from ivwhsem where whse_default = 1")

            If Not oRow Is Nothing Then
                txtwhse_code.Text = oRow!whse_code.ToString.Trim
                lk_whse_code.ExecuteFind()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Add Then
                FillItem()
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub TextBox4_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCosto.Validating
        Try
            If LibXConnector1.IsDataEditing Then
                Calcular(CalcularEnum.Precio)
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Function Calcular(ByVal pCalcular As CalcularEnum) As Boolean
        Dim costo As Decimal
        Dim ITBIS As Decimal
        Dim Costo2 As Decimal
        Dim Impto As Decimal
        Dim CostRD As Decimal
        Dim Benef, dITBIS As Decimal
        Dim Price, PriceITBIS As Decimal
        Dim dRound As Decimal

        Try

            If txtitem_code.Text.Length <= 0 Then
                Throw New ApplicationException("Especifique el Producto")
            End If

            If txtwhse_code.Text.Length <= 0 Then
                Throw New ApplicationException("Especifique el Almacen")
            End If

            mCalcular = False

            '// Costo en Dolar
            If txtCosto.Text.Trim <> "" Then
                costo = CType(txtCosto.Text.Trim, Decimal)
            End If

            '// Impuesto en Dolar
            If txtRound.Text.Trim <> "" Then
                dRound = CType(txtRound.Text.Trim, Decimal)
            End If

            '// % Beneficio
            If txtBenef.Text.Trim <> "" Then
                Benef = CType(txtBenef.Text.Trim, Decimal)
            End If

            '// Precio
            If txtPrecio.Text.Trim <> "" Then
                Price = CType(txtPrecio.Text.Trim, Decimal)
            End If

            If txtPrecio2.Text <> "" Then
                PriceITBIS = CType(txtPrecio2.Text.Trim, Decimal)
            End If

            Select Case pCalcular
                Case CalcularEnum.Beneficio
                    Benef = ((Price - costo) / costo) * 100.0

                Case CalcularEnum.Precio
                    Price = costo * (1.0 + (Benef / 100.0))

                Case CalcularEnum.Costo
                    costo = Price / (1.0 + (Benef / 100.0))

                Case CalcularEnum.PrecioItbis
                    If Me.xchk_PagaITBIS.Checked = True Then
                        PriceITBIS = CType(Me.txtPrecio2.Text.Trim, Decimal)
                        Price = PriceITBIS / (1.0 + (mConf.GetITBIS / 100.0))
                        Benef = ((Price - costo) / costo) * 100.0
                        ITBIS = PriceITBIS - Price
                    End If

                    If Me.xchk_PagaITBIS2.Checked = True Then
                        PriceITBIS = CType(Me.txtPrecio2.Text.Trim, Decimal)
                        Price = PriceITBIS / (1.0 + (mConf.GetITBISDOS / 100.0))
                        Benef = ((Price - costo) / costo) * 100.0
                        ITBIS = PriceITBIS - Price
                    End If

            End Select

            If Me.xchk_PagaITBIS.Checked = True Then
                ITBIS = Price * (mConf.GetITBIS / 100.0)
                PriceITBIS = Price + ITBIS
            Else
                If Me.xchk_PagaITBIS2.Checked = True Then
                    ITBIS = Price * (mConf.GetITBISDOS / 100.0)
                    PriceITBIS = Price + ITBIS
                Else
                    ITBIS = 0
                    PriceITBIS = 0
                End If
            End If

            ''''// Calcular costo y precio
            '''With oParamCalc
            '''    .Producto = Me.txtitem_code.Text
            '''    .Almacen = Me.txtwhse_code.Text
            '''    .Beneficio = Benef
            '''    .Costo = costo
            '''    .IncluirDescuento = False
            '''    .incluirISC = False
            '''    .IncluirITBIS = False
            '''    .incluirOFERTA = False
            '''    .Descuento = ""
            '''    .ISC = ""
            '''    .Ofertas = 0
            '''    .TotalFactura = costo
            '''    .TotalITBIS = 0
            '''    .Itbis = 0
            '''    .Cantidad = 1
            '''    .PagaItbis = xchk_PagaITBIS.Checked

            '''    '.Itbis = ITBIS
            '''    If mUsePrice = True Then
            '''        .Precio = Price
            '''    Else
            '''        .Precio = 0
            '''    End If

            '''    '.PagaItbis = Me.xchk_PagaITBIS.Checked
            '''End With

            '''oArticulo.CalcularCostoLocal(oParamCalc)

            Me.txtBenef.Text = Benef.ToString("##0.00")
            Me.txtCosto.Text = Format(costo, "###,###,##0.00")
            ''Me.txtPrecio.Text = Format(Price, "###,###,##0.00")
            Me.txtPrecio.Text = Decimal.Round(Price, 0)
            Me.txtPrecio2.Text = Format(PriceITBIS, "###,###,##0.00")
            Me.txtITBIS.Text = Format(ITBIS, "###,###,##0.00")

            mUsePrice = False
        Catch ex As Exception
            'LibX.Log.Show(ex)
        End Try
    End Function

    Private Sub cbxITBIS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If LibXConnector1.IsDataEditing Then
                Calcular(CalcularEnum.Precio)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            mUsePrice = False
            If e.AcceptedAction = LibX.LibxConnectionActions.Add And _
            e.Action = LibX.LibxConnectionActions.Accept Then
                If MessageBox.Show("Desea crear este producto para los demas almacenes?", "Replicar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    ReplicarAlmacen()
                End If
                Me.Close()
            End If

            If e.AcceptedAction = LibX.LibxConnectionActions.Edit And _
                e.Action = LibX.LibxConnectionActions.Accept Then
                'LibXConnector1.AcceptFind()
                Me.Close()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub


    Private Sub txtPrice_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPrice.Validating
        Try
            If LibXConnector1.IsDataEditing Then
                Calcular(CalcularEnum.Beneficio)
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then
                If Val(e.UpdatingArgs.Row!purch_cost.ToString) <= 0 Then
                    Throw New ApplicationException("Costo no puede ser menor o igual a cero (0)")
                End If

                If Val(e.UpdatingArgs.Row!price.ToString) <= 0 Then
                    Throw New ApplicationException("Precio no puede ser menor o igual a cero (0)")
                End If

                If Val(e.UpdatingArgs.Row!purch_cost.ToString) > Val(e.UpdatingArgs.Row!price.ToString) Then
                    Throw New ApplicationException("Costo no puede ser menor que precio")
                End If

                If Val(e.UpdatingArgs.Row!benef.ToString) < 0 Then
                    Throw New ApplicationException("Beneficio no puede ser negativo")
                End If
            End If

            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                e.UpdatingArgs.Row!existencia = 0
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
        End Try
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try
            btnSerie.Enabled = (Not e.isDataEditing And LibXConnector1.HasRecords = True)
            btnMov.Enabled = (Not e.isDataEditing And LibXConnector1.HasRecords = True)
            ButtonEstadisticas.Enabled = (Not e.isDataEditing And LibXConnector1.HasRecords = True)

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub btnMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMov.Click
        Dim oParam As LibX.LibxPrgParams
        Dim WhereStmt As String
        Dim c_ivdocs As c_ivdocs01
        Try
            oParam = New LibX.LibxPrgParams
            c_ivdocs = New c_ivdocs01
            WhereStmt = "ivtranrd.item_code = '" & LibXConnector1.CurrentDataRow!item_code.ToString.Trim & _
                        "' and ivtranrd.whse_code = " & LibXConnector1.CurrentDataRow!whse_code.ToString

            oParam.Datos.Add("where", WhereStmt)

            LibX.App.CurrentPrgParams = oParam

            c_ivdocs.ShowDialog()

            c_ivdocs = Nothing

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try
            If mConf Is Nothing Then
                mConf = New SGT.Inventario.Common.Configuration
            End If

            txtRound.Text = mConf.GetRounded
            txtBenef.Text = mConf.GetBenef
            cbx_AllowBO.Checked = mConf.GetAllowBO

            FillItem()

            Me.txtCosto.Focus()
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub txtBenef_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBenef.Validated
        Try
            If LibXConnector1.IsDataEditing And mCalcular = True Then
                Calcular(CalcularEnum.Precio)
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub ReplicarAlmacen()
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim oTable1 As DataTable
        Dim XInsert As LibX.Data.XInsertStmt
        Try
            SelectStmt = String.Concat("select whse_code from ivwhsem ", _
                                      " where whse_code <> ", LibXConnector1.CurrentDataRow!whse_code.ToString)

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Exit Sub
            End If

            XInsert = New LibX.Data.XInsertStmt("ivitemd")

            With XInsert
                For Each oCol As DataColumn In LibXConnector1.CurrentDataRow.Row.Table.Columns
                    If oCol.ColumnName.ToLower <> "itbis" And oCol.ColumnName.ToLower <> "precioitbis" Then
                        .Fields(oCol.ColumnName) = LibXConnector1.CurrentDataRow.Item(oCol.ColumnName)
                    End If
                Next
            End With

            For Each oRow As DataRow In oTable.Rows
                XInsert.Fields("whse_code").VALUE = oRow!whse_code.ToString

                XInsert.Execute()
            Next

            XInsert.Dispose()
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub xchk_PagaITBIS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xchk_PagaITBIS.CheckedChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                If xchk_PagaITBIS.Checked = True Then
                    xchk_PagaITBIS2.Checked = False
                End If
                Calcular(CalcularEnum.Precio)
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If LibXConnector1.HasRecords = True Then
                'Calcular()
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub txtCosto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCosto.TextChanged
        If LibXConnector1.IsDataEditing = True Then
            mCalcular = True
        End If
    End Sub

    Private Sub txtBenef_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBenef.TextChanged
        If LibXConnector1.IsDataEditing = True Then
            mCalcular = True
        End If
    End Sub

    Private Sub txtPrecio_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPrecio.Validating
        Try
            If LibXConnector1.IsDataEditing = True Then
                If Me.txtCosto.Text.Trim <> "" And Me.txtPrecio.Text.Trim <> "" Then
                    If CDbl(Me.txtCosto.Text.Trim) > CDbl(Me.txtPrecio.Text.Trim) Then
                        Throw New ApplicationException("El Precio no puede ser menor que el costo!")
                    End If
                End If

                mUsePrice = True
                mCalcular = True
                Calcular(CalcularEnum.Beneficio)

                'Calcular(CalcularEnum.Costo)
            End If

        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSerie.Click
        Dim oParam As LibX.LibxPrgParams
        Dim WhereStmt As String
        Dim c_vencimiento As i_ivserie01
        Try
            oParam = New LibX.LibxPrgParams
            c_vencimiento = New i_ivserie01

            WhereStmt = "ivvcmted.item_code = '" & LibXConnector1.CurrentDataRow!item_code.ToString.Trim & _
                        "' and ivvcmted.whse_code = " & LibXConnector1.CurrentDataRow!whse_code.ToString

            oParam.Datos.Add("where", WhereStmt)

            LibX.App.CurrentPrgParams = oParam

            c_vencimiento.ShowDialog()

            c_vencimiento = Nothing

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub ButtonEstadisticas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEstadisticas.Click
        Dim oParam As LibX.LibxPrgParams
        Dim WhereStmt As String
        Dim c_ivdocs As c_ivdocs02
        Try
            oParam = New LibX.LibxPrgParams
            c_ivdocs = New c_ivdocs02
            WhereStmt = "ivstadism.item_code = '" & LibXConnector1.CurrentDataRow!item_code.ToString.Trim & _
                        "' and ivstadism.whse_code = " & LibXConnector1.CurrentDataRow!whse_code.ToString

            oParam.Datos.Add("where", WhereStmt)
            oParam.Value = Me.txtitem_code.Text

            LibX.App.CurrentPrgParams = oParam

            c_ivdocs.ShowDialog()

            c_ivdocs = Nothing

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_SettingDefaulteditValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultEditValues) Handles LibXConnector1.SettingDefaulteditValues
        Me.txtCosto.Focus()

    End Sub

    Private Sub LibXConnector1_SettingDefaultqueryValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultQueryValues) Handles LibXConnector1.SettingDefaultqueryValues
        Me.txtitem_code.Focus()
    End Sub
    Private Sub LibxCheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xck_aplica_dscnt.CheckedChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                Me.xtxt_disc_pct.Enabled = Me.xck_aplica_dscnt.Checked
                If Me.xck_aplica_dscnt.Checked = False Then
                    Me.xtxt_disc_pct.Text = String.Empty
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xtxt_disc_pct_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_disc_pct.Validating
        Try
            If LibXConnector1.IsDataEditing = True Then
                If Val(Me.xtxt_disc_pct.Text.Trim) > 100 Then
                    Throw New ApplicationException("El descuento debe ser en % y no puede ser mayor a 50%")
                End If

                If Val(Me.xtxt_disc_pct.Text.Trim) > 50 Then
                    Throw New ApplicationException("El % de descuento es demasiado alto el producto estaria por debajo del costo")
                End If
            End If

        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub txtBenef_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBenef.Validating
        Try
            If LibXConnector1.IsDataEditing = True Then
                If Val(Me.txtBenef.Text.Trim) < 0 Then
                    Throw New ApplicationException("El Beneficio no puede ser negativo!")
                End If
            End If
        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub txtPrecio2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPrecio2.Validating
        Try
            If LibXConnector1.IsDataEditing Then
                mUsePrice = True
                mCalcular = True
                Calcular(CalcularEnum.PrecioItbis)
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xchk_PagaITBIS2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xchk_PagaITBIS2.CheckedChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                If xchk_PagaITBIS2.Checked = True Then
                    xchk_PagaITBIS.Checked = False
                End If
                Calcular(CalcularEnum.Precio)
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ChangingState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangingState
        Dim program As SGT.Administracion.Entidades.Permiso
        Try

            program = New SGT.Administracion.Entidades.Permiso(LibX.User.UserID, "i_ivitem01")
            LibXConnector1.AllowNew = program.Agregar
            LibXConnector1.AllowEdit = program.Editar
            LibXConnector1.AllowDelete = program.Borrar
            LibXConnector1.AllowQuery = program.Buscar
            LibXConnector1.AllowPrint = program.Imprimir

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub GroupBox7_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub xtxt_disc_pct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xtxt_disc_pct.TextChanged

    End Sub
End Class
