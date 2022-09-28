Imports LibX
Imports Ultra
Imports Ultra.Scan
Imports Ultra.Registry
Imports System.IO
Imports System.IO.File

Imports SGT.Administracion
Imports SGT.Administracion.Entidades

Imports System.Drawing.Printing
Imports System.Runtime.InteropServices

Public Class r_ivean_d
    Inherits System.Windows.Forms.Form

    Dim oPrinter As Ultra.Print

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
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents txtitem_name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents LibxDateTimePicker2 As LibX.LibxDateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Label9 As System.Windows.Forms.Label
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
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents lblwhse_name As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents xcbo_printmode As LibX.LibXCombo
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents xtxtletra As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
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
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtitem_name = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.xtxtletra = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.LibxDateTimePicker2 = New LibX.LibxDateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblwhse_name = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.Label10 = New System.Windows.Forms.Label
        Me.xcbo_printmode = New LibX.LibXCombo
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.XTextBox3 = New LibX.XTextBox
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Nothing)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn18, Me.DataColumn26})
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
        Me.DataColumn7.MaxLength = 50
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "abreviada"
        Me.DataColumn8.MaxLength = 30
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "fact_no"
        Me.DataColumn9.MaxLength = 10
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
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "imprime_tique"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "marca"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "fecha"
        Me.DataColumn21.DataType = GetType(System.DateTime)
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "item_name"
        Me.DataColumn22.MaxLength = 100
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "asumir_emp"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "estado"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "mod_serial"
        Me.DataColumn25.DataType = GetType(System.Int16)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "comp_name"
        Me.DataColumn18.MaxLength = 60
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "comp_phone1"
        Me.DataColumn26.MaxLength = 8
        '
        'LibXDbSourceTable3
        '
        Me.LibXDbSourceTable3.AllowDelete = True
        Me.LibXDbSourceTable3.AllowEdit = True
        Me.LibXDbSourceTable3.AllowNew = True
        Me.LibXDbSourceTable3.AutoIncrementSerial = False
        Me.LibXDbSourceTable3.CustomDbUpdate = False
        Me.LibXDbSourceTable3.DeleteOrder = 0
        Me.LibXDbSourceTable3.FillOnQuery = True
        Me.LibXDbSourceTable3.FillOnRowChange = False
        Me.LibXDbSourceTable3.HeaderIsOnGrid = False
        Me.LibXDbSourceTable3.InnerJon = True
        Me.LibXDbSourceTable3.InsertOrder = 0
        Me.LibXDbSourceTable3.IsDetail = False
        Me.LibXDbSourceTable3.KeyFields = Nothing
        Me.LibXDbSourceTable3.LineColName = Nothing
        Me.LibXDbSourceTable3.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable3.MasterTableName = Nothing
        Me.LibXDbSourceTable3.SerialColumnName = "etiq_no"
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = New String() {"select ivetiqm.*, ivitemm.item_name,ivitemm.asumir_emp,ivitemm.item_serie", "from ivetiqm, ivitemm, stinform", "where ivetiqm.item_code = ivitemm.item_code"}
        Me.LibXDbSourceTable3.TableName = "ivetiqm"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
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
        Me.LibXDbSourceTable2.TableName = Nothing
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.Location = New System.Drawing.Point(538, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 224)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(8, 80)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Cerrar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLimpiar.Location = New System.Drawing.Point(8, 47)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(72, 32)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Eliminar"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEjecutar.Location = New System.Drawing.Point(8, 13)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(72, 32)
        Me.btnEjecutar.TabIndex = 0
        Me.btnEjecutar.Text = "Ejecutar"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(634, 48)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "IMPRESION DE CODIGO DE BARRA"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtitem_name
        '
        Me.txtitem_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtitem_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.abreviada"))
        Me.txtitem_name.Location = New System.Drawing.Point(132, 88)
        Me.txtitem_name.Name = "txtitem_name"
        Me.txtitem_name.Size = New System.Drawing.Size(360, 20)
        Me.txtitem_name.TabIndex = 19
        Me.txtitem_name.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(64, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Producto:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(50, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Descripcion:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.almacen"))
        Me.TextBox2.Location = New System.Drawing.Point(132, 112)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(64, 20)
        Me.TextBox2.TabIndex = 23
        Me.TextBox2.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(66, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Almacen:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'xtxtletra
        '
        Me.xtxtletra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxtletra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.fact_no"))
        Me.xtxtletra.Location = New System.Drawing.Point(132, 136)
        Me.xtxtletra.Name = "xtxtletra"
        Me.xtxtletra.Size = New System.Drawing.Size(64, 20)
        Me.xtxtletra.TabIndex = 25
        Me.xtxtletra.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(48, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Identificador:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox4
        '
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.fact_no"))
        Me.TextBox4.Location = New System.Drawing.Point(132, 160)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(112, 20)
        Me.TextBox4.TabIndex = 27
        Me.TextBox4.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(51, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Factura No.:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(300, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Fecha Factura:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ivetiqm.fecha_factura"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.FieldDescription = ""
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = False
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(388, 160)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = Nothing
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Requiered = False
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.LibxDateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker1.TabIndex = 29
        '
        'LibxDateTimePicker2
        '
        Me.LibxDateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ivetiqm.fecha"))
        Me.LibxDateTimePicker2.EditInitialValue = Nothing
        Me.LibxDateTimePicker2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker2.FieldDescription = ""
        Me.LibxDateTimePicker2.FindInitialValue = Nothing
        Me.LibxDateTimePicker2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker2.IgnoreRequiered = False
        Me.LibxDateTimePicker2.Location = New System.Drawing.Point(132, 184)
        Me.LibxDateTimePicker2.Name = "LibxDateTimePicker2"
        Me.LibxDateTimePicker2.NewInitialValue = Nothing
        Me.LibxDateTimePicker2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker2.Requiered = False
        Me.LibxDateTimePicker2.Size = New System.Drawing.Size(112, 20)
        Me.LibxDateTimePicker2.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker2.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(38, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Fecha Creada:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ivetiqm.estado"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = "0"
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Items.AddRange(New Object() {"0-Creada", "1-Impresa"})
        Me.LibXCombo1.Location = New System.Drawing.Point(388, 184)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = Nothing
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(104, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(332, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Estatus:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblwhse_name
        '
        Me.lblwhse_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblwhse_name.Location = New System.Drawing.Point(204, 112)
        Me.lblwhse_name.Name = "lblwhse_name"
        Me.lblwhse_name.Size = New System.Drawing.Size(272, 20)
        Me.lblwhse_name.TabIndex = 34
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"item_code=item_code", "abreviada=abreviada", "almacen=almacen", "lblwhse_name=whse_name", "prov_code=prov_code", "lblprov_name=prov_name", "estado=estado"}
        Me.LibXLookup1.FilterField = "abreviada"
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(244, 64)
        Me.LibXLookup1.LookCaption = "Etiquetas"
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup1.ShowFilter = True
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.ShowWarning = False
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SizesColumns = Nothing
        Me.LibXLookup1.SizesColumnsTab = Nothing
        Me.LibXLookup1.SqlString = New String() {"select m.item_code,m.abreviada,m.almacen,h.whse_name,", "m.prov_code,p.prov_name,m.estado", "from ivetiqm m", "left  join  ivwhsem h", "on m.almacen=h.whse_code", "left join cpprovm p", "on  m.prov_code=p.prov_code"}
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"item_code=item_code"}
        Me.LibXLookup1.TabIndex = 35
        Me.LibXLookup1.TableName = "ivetiqm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=item_code", "Abreviada=abreviada", "Código Almacén=almacen", "Almacén Nombre =whse_name", "Suplidor=prov_code", "Nombre=prov_name", "Estado=estado"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "ivetiqm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = True
        Me.LibXConnector1.HandledUpdates = True
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable3})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"almacen=whse_code", "lblwhse_name=whse_name"}
        Me.LibXLookup2.FilterField = "whse_name"
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(476, 112)
        Me.LibXLookup2.LookCaption = "Almacenes"
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup2.ShowFilter = True
        Me.LibXLookup2.ShowMessageNotFound = True
        Me.LibXLookup2.ShowWarning = False
        Me.LibXLookup2.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup2.SizesColumns = Nothing
        Me.LibXLookup2.SizesColumnsTab = Nothing
        Me.LibXLookup2.SqlString = Nothing
        Me.LibXLookup2.SQLTab = Nothing
        Me.LibXLookup2.SrcParameters = New String() {"almacen=whse_code"}
        Me.LibXLookup2.TabIndex = 36
        Me.LibXLookup2.TableName = "ivwhsem"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Almacen=whse_code", "Descripcion=whse_name"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Location = New System.Drawing.Point(12, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 16)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Modelo de Etiqueta:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'xcbo_printmode
        '
        Me.xcbo_printmode.AllowDefaultSort = True
        Me.xcbo_printmode.bound = True
        Me.xcbo_printmode.currValue = Nothing
        Me.xcbo_printmode.DefaultWhereString = Nothing
        Me.xcbo_printmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_printmode.EditInitialValue = Nothing
        Me.xcbo_printmode.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_printmode.FieldDescription = ""
        Me.xcbo_printmode.FindInitialValue = Nothing
        Me.xcbo_printmode.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_printmode.IgnoreRequiered = False
        Me.xcbo_printmode.Location = New System.Drawing.Point(132, 208)
        Me.xcbo_printmode.LookupKeyDisplayFields = "mod_name"
        Me.xcbo_printmode.LookupKeyField = "mod_serial"
        Me.xcbo_printmode.LookupTableName = "ivetiqmod"
        Me.xcbo_printmode.Name = "xcbo_printmode"
        Me.xcbo_printmode.NewInitialValue = Nothing
        Me.xcbo_printmode.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_printmode.Requiered = False
        Me.xcbo_printmode.Required = False
        Me.xcbo_printmode.Size = New System.Drawing.Size(112, 21)
        Me.xcbo_printmode.SqlString = Nothing
        Me.xcbo_printmode.StatusBarPanelDescripcion = Nothing
        Me.xcbo_printmode.TabIndex = 40
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 40)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Generando ..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 16)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(522, 21)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 0
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivetiqm.item_code"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(133, 64)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(107, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 42
        Me.XTextBox3.Text = ""
        '
        'r_ivean_d
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(634, 288)
        Me.Controls.Add(Me.XTextBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.xcbo_printmode)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LibXLookup2)
        Me.Controls.Add(Me.LibXLookup1)
        Me.Controls.Add(Me.lblwhse_name)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LibXCombo1)
        Me.Controls.Add(Me.LibxDateTimePicker2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LibxDateTimePicker1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.xtxtletra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtitem_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "r_ivean_d"
        Me.Text = "Impresion de Codigo de Barra"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As System.Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            e.DoFill = False
            Dim oTable As DataTable
            Dim oRowPrinter, oRowempresa, oVence As DataRow
            Dim item, supli, itbis As String
            Dim serial As Integer
            Dim valor_itbis As Decimal
            Dim fecha As String
            Dim mes, anio As String
            Dim SelectStmt As String
            Dim ean_d As Integer = 74605023
            Dim barra As String
            Dim letra As String
            Dim FileEtiq As String = "C:\Etieque.txt"
            Dim xUpdate As LibX.Data.XUpdateStmt

            SelectStmt = LibX.ConcatWherePart(e.Sql, e.Where)

            '// Buscar etiquetas
            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Throw New ApplicationException("No existen etiquetas con este criterio")
            End If

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No existen etiquetas de este producto con ese estado")
            End If

            '//buscar configuracion de etiqueta
            SelectStmt = "select * from ivetiqmod"
            oRowPrinter = LibX.Data.Manager.GetDataRow(SelectStmt)

            '//Abrir el archivo 
            FileOpen(1, FileEtiq, OpenMode.Output, OpenAccess.Write, OpenShare.Shared)

            '//Inicializar la etiquetadora
            PrintLine(1, oRowPrinter!inicio_trabajo.ToString)

            '//Iniciar transaccion
            LibX.Data.Manager.Connection.BeginTransaction()

            '//Actualizar etiqueta
            xUpdate = New LibX.Data.XUpdateStmt("ivetiqm")
            xUpdate.Fields("etiq_no") = 1
            xUpdate.FieldsSet("estado") = 1

            '//Progreso
            Me.ProgressBar1.Maximum = oTable.Rows.Count + 1
            Me.ProgressBar1.Minimum = 1

            For Each oRow As DataRow In oTable.Rows
                '// Inicializar la etiqueta
                PrintLine(1, oRowPrinter!inicio_etiqueta.ToString)

                '// Empresa

                SelectStmt = "select comp_name,comp_phone1 from stinform"
                oRowempresa = LibX.Data.Manager.GetDataRow(SelectStmt)

                SelectStmt = "select percent_itbis from ivsetup"
                valor_itbis = LibX.Data.Manager.GetScalar(SelectStmt)

                item = oRow!item_code.ToString
                supli = oRow!prov_code.ToString
                letra = Me.xtxtletra.Text

                SelectStmt = "select barcode from  where item_code ='" & item & "' and substring(barra,14,14) = '" & letra & "'"
                barra = LibX.Data.Manager.GetScalar(SelectStmt)
                If Len(barra) = 0 Then
                    barra = ean_d &
                End If

                If Not oRowPrinter!sec_empresa Is DBNull.Value Or Not oRow!item_serie Is DBNull.Value Then
                    PrintLine(1, oRowPrinter!sec_empresa.ToString & "," & Chr(34) & oRow!item_serie.ToString & Chr(34))
                End If

                '//Codigo Barra
                If Not oRowPrinter!sec_barra Is DBNull.Value Or Not barra Is DBNull.Value Then
                    PrintLine(1, oRowPrinter!sec_barra.ToString & "," & Chr(34) & barra.ToString & Chr(34))
                End If

                If Not oRow!fact_no Is DBNull.Value And Not oRow!prov_code Is DBNull.Value Then
                    SelectStmt = "select entr_serial from iventrdm where entr_number ='" & oRow!fact_no & "' and prov_code=" & oRow!prov_code & ""
                    serial = LibX.Data.Manager.GetScalar(SelectStmt)
                End If

                SelectStmt = "select taxable from ivitemm where item_code ='" & item & "'"
                itbis = LibX.Data.Manager.GetScalar(SelectStmt)

                '// Telefono
                If Not oRowPrinter!sec_telefono Is DBNull.Value Or Not oRowempresa!comp_phone1 Is DBNull.Value Then
                    PrintLine(1, oRowPrinter!sec_telefono.ToString & "," & Chr(34) & oRowempresa!comp_phone1 & Chr(34))
                End If

                '// Factura de Compra
                If Not oRowPrinter!sec_factura Is DBNull.Value Or Not oRow!fact_no Is DBNull.Value Then
                    PrintLine(1, oRowPrinter!sec_factura.ToString & "," & Chr(34) & oRow!fact_no.ToString & Chr(34))
                End If

                '// Fecha de Compra
                fecha = oRow!fecha_factura.ToString.Trim
                If fecha <> "" Then
                    If Not oRowPrinter!sec_fechacompra Is DBNull.Value Or Not oRow!fecha_factura Is DBNull.Value Then
                        PrintLine(1, oRowPrinter!sec_fechacompra.ToString & "," & Chr(34) & Format(oRow!fecha_factura, "dd/MM/yyyy") & Chr(34))
                    End If
                End If
                If item <> "" And supli <> "" Then
                    SelectStmt = "select vcmto_month from ivvcmtod " & _
                                 " where doc_serial =" & serial & " and item_code ='" & item & "' and prov_code =" & supli & ""

                    mes = LibX.Data.Manager.GetScalar(SelectStmt)
                    If Len(mes) = 1 Then
                        mes = "0" & mes
                    End If
                End If
                If mes Is Nothing Then
                    mes = ""
                End If
                If item <> "" And supli <> "" Then
                    SelectStmt = "select vcmto_year from ivvcmtod " & _
                                 " where doc_serial =" & serial & " and item_code ='" & item & "' and prov_code =" & supli & ""

                    anio = LibX.Data.Manager.GetScalar(SelectStmt)
                End If
                If anio Is Nothing Then
                    anio = ""
                End If

                '// Suplidor
                If Not oRowPrinter!sec_suplidor Is DBNull.Value Or Not oRow!prov_code Is DBNull.Value Then
                    If mes <> "" And anio <> "" Then
                        PrintLine(1, oRowPrinter!sec_suplidor.ToString & "," & Chr(34) & oRow!prov_code.ToString & "  V:" & mes & "/" & anio.ToString & Chr(34))
                    Else
                        PrintLine(1, oRowPrinter!sec_suplidor.ToString & "," & Chr(34) & oRow!prov_code.ToString & Chr(34))
                    End If

                End If

                '// precio
                If Not oRowPrinter!sec_precio Is DBNull.Value Then
                    If itbis > 0 Then
                        PrintLine(1, oRowPrinter!sec_precio.ToString & "," & Chr(34) & Format(oRow!precio * (valor_itbis / 100 + 1), "###,##0.00") & Chr(34))
                    Else
                        PrintLine(1, oRowPrinter!sec_precio.ToString & "," & Chr(34) & Format(oRow!precio, "###,##0.00") & Chr(34))
                    End If
                End If


                '// Unidad Venta
                If Not oRowPrinter!sec_unidad Is DBNull.Value Then
                    PrintLine(1, oRowPrinter!sec_unidad.ToString & "," & Chr(34) & oRow!unidad_venta.ToString & Chr(34))
                End If

                If (oRow!unidad_venta <> oRow!unidad_compra) And Not oRow!precio2 Is DBNull.Value Then
                    '// precio

                    If Not oRowPrinter!sec_precio2 Is DBNull.Value Then
                        If itbis > 0 Then
                            PrintLine(1, oRowPrinter!sec_precio2.ToString & "," & Chr(34) & Format(oRow!precio2 * (valor_itbis / 100 + 1), "###,##0.00") & Chr(34))
                        Else
                            PrintLine(1, oRowPrinter!sec_precio2.ToString & "," & Chr(34) & Format(oRow!precio2, "###,##0.00") & Chr(34))
                        End If
                    End If

                    '// Unidad Compra
                    If Not oRowPrinter!sec_unidad2 Is DBNull.Value Then
                        PrintLine(1, oRowPrinter!sec_unidad2.ToString & "," & Chr(34) & oRow!unidad_compra.ToString & Chr(34))
                    End If
                End If

                '// Codigo Producto
                If Not oRowPrinter!sec_producto Is DBNull.Value Then
                    PrintLine(1, oRowPrinter!sec_producto.ToString & "," & Chr(34) & oRow!abreviada.ToString & Chr(34))
                End If

                '// cantidad
                PrintLine(1, oRowPrinter!cantidad.ToString & oRow!cantidad.ToString.Trim)

                '// fin de la etiqueta
                PrintLine(1, oRowPrinter!fin_etiqueta.ToString)

                '// Actualizar Etiqueta a Impresa
                xUpdate.Fields("etiq_no").value = oRow!etiq_no
                xUpdate.Execute()

                '// Actualizar
                Me.ProgressBar1.Value += 1

                SelectStmt = " update ivetiqm set estado = 1 where estado = 0 and item_code = '" & item & "'"
                oRowempresa = LibX.Data.Manager.GetDataRow(SelectStmt)

            Next

            FileClose(1)

            ImprimirEtiqueta(FileEtiq, oRowPrinter!printername.ToString)

            '// acentar la transaccion
            LibX.Data.Manager.Connection.CommitTransaction()

        Catch ex As Exception

            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If

            Try
                FileClose(1)
            Finally
            End Try
            Log.Show(ex)
        End Try
    End Sub

    Private Sub ImprimirEtiqueta(ByVal FileNameToPrint As String, ByVal PrinterName As String)
        Dim pd As New PrintDialog
        pd.PrinterSettings = New PrinterSettings
        pd.PrinterSettings.PrinterName = PrinterName
        If (pd.ShowDialog() = DialogResult.OK) Then
            ' Print the file to the printer.
            RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, FileNameToPrint)
        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Me.ProgressBar1.Maximum = 0
        Me.ProgressBar1.Minimum = 0
        Me.LibXConnector1.AcceptFind()
        Me.LibXConnector1.Find()
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Dim SelectStmt As String
        Dim DeleteStmt As DataRow
        Dim xDel As LibX.Data.XDeleteStmt
        Dim borrar As Integer
        'If Me.LibXConnector1.IsEditing Then
        '    Me.LibXConnector1.Cancel()
        'End If
        Me.LibXConnector1.Find()
        '//Eliminar todas las etiquetas que esten con estado impreso
        borrar = MessageBox.Show("Desea Eliminar las Etiquetas ya Impresa", "Borrar Registro", MessageBoxButtons.YesNo)
        If borrar = System.Windows.Forms.DialogResult.Yes Then
            SelectStmt = "delete from ivetiqm where estado = 1" ' where mod_serial = " & Me.xcbo_printmode.currValue.ToString
            LibX.Data.Manager.ExecuteNonQuery(SelectStmt)
        End If
    End Sub

    Private Sub r_ftfact10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LibXConnector1.Find()
    End Sub

    Private Sub LibXConnector1_SettingDefaultqueryValues(ByVal sender As System.Object, ByVal e As LibX.SettingDefaultQueryValues) Handles LibXConnector1.SettingDefaultqueryValues
        Me.xcbo_printmode.LoadDbItems(True)
        Me.xcbo_printmode.SelectedIndex = 1
    End Sub

End Class
