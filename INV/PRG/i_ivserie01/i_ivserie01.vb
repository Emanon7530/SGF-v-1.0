Public Class i_ivserie01
    Inherits System.Windows.Forms.Form
    Dim FactNumber As Integer

    '//////////////////////////////////////////////////////////////////
    '// SI ESTE PROGRAMA DEJA DE CONSULTAR (al buscar no trae datos) //
    '// Revisar las tablas del DataSet1 la columna ftserial_no debe  //
    '// debe estar autoincrement false, cuando se hacen cambios en   //
    '// en el LibxConnector este actualiza las tablas del dataset1 y //
    '// pone la columna ftserial_no autoincrement true               //
    '//////////////////////////////////////////////////////////////////
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pFactNumber As Integer)
        MyBase.New()

        FactNumber = pFactNumber
    End Sub

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
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents ivseriem As System.Data.DataTable
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    '<System.Diagnostics.DebuggerStepThrough()> 
    Friend WithEvents XEditTextBoxColumn5 As LibX.XEditTextBoxColumn
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents LibXGrid2 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents XdataGridTableStyle2 As LibX.XdataGridTableStyle
    Friend WithEvents XDBiventrdm As LibX.LibXDbSourceTable
    Friend WithEvents XDBiventrdd As LibX.LibXDbSourceTable
    Friend WithEvents XDBivseriem As LibX.LibXDbSourceTable
    Friend WithEvents iventrdm As System.Data.DataTable
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents iventrdd As System.Data.DataTable
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ivseriem = New System.Data.DataTable
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.iventrdm = New System.Data.DataTable
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.iventrdd = New System.Data.DataTable
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.XDBiventrdm = New LibX.LibXDbSourceTable
        Me.XDBiventrdd = New LibX.LibXDbSourceTable
        Me.XDBivseriem = New LibX.LibXDbSourceTable
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.DataView1 = New System.Data.DataView
        Me.btnAccept = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.XEditTextBoxColumn5 = New LibX.XEditTextBoxColumn
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.LibXGrid2 = New LibX.LibXGrid
        Me.XdataGridTableStyle2 = New LibX.XdataGridTableStyle
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivseriem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iventrdm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iventrdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = False
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "iventrdm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = True
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.XDBiventrdm, Me.XDBiventrdd, Me.XDBivseriem})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivseriem, Me.iventrdm, Me.iventrdd})
        '
        'ivseriem
        '
        Me.ivseriem.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn7, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn26})
        Me.ivseriem.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"serie_number"}, True)})
        Me.ivseriem.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn7}
        Me.ivseriem.TableName = "ivseriem"
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "serie_number"
        Me.DataColumn7.MaxLength = 20
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "item_code"
        Me.DataColumn9.MaxLength = 15
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "whse_code"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "prov_code"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "serie_status"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "ftserial_no"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "entr_serial"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'iventrdm
        '
        Me.iventrdm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn2, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn21, Me.DataColumn24})
        Me.iventrdm.TableName = "iventrdm"
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "entr_number"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "prov_code"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "prov_name"
        Me.DataColumn15.MaxLength = 60
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "entr_date"
        Me.DataColumn16.DataType = GetType(System.DateTime)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "whse_code"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.AutoIncrement = True
        Me.DataColumn24.ColumnName = "entr_serial"
        Me.DataColumn24.DataType = GetType(System.Int32)
        Me.DataColumn24.ReadOnly = True
        '
        'iventrdd
        '
        Me.iventrdd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn22, Me.DataColumn23, Me.DataColumn25})
        Me.iventrdd.TableName = "iventrdd"
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "item_code"
        Me.DataColumn18.MaxLength = 15
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "item_name"
        Me.DataColumn19.MaxLength = 100
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "qty"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "prov_code"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "whse_code"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "entr_serial"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'XDBiventrdm
        '
        Me.XDBiventrdm.AllowDelete = True
        Me.XDBiventrdm.AllowEdit = True
        Me.XDBiventrdm.AllowNew = True
        Me.XDBiventrdm.AutoIncrementSerial = False
        Me.XDBiventrdm.CustomDbUpdate = False
        Me.XDBiventrdm.DeleteOrder = 0
        Me.XDBiventrdm.FillOnQuery = True
        Me.XDBiventrdm.FillOnRowChange = False
        Me.XDBiventrdm.HeaderIsOnGrid = False
        Me.XDBiventrdm.InsertOrder = 0
        Me.XDBiventrdm.IsDetail = False
        Me.XDBiventrdm.KeyFields = Nothing
        Me.XDBiventrdm.MasterDetailRelation = Nothing
        Me.XDBiventrdm.MasterTableName = Nothing
        Me.XDBiventrdm.SerialColumnName = Nothing
        Me.XDBiventrdm.Sort = Nothing
        Me.XDBiventrdm.Source = New String() {"select iventrdm.entr_serial,iventrdm.entr_number,iventrdm.prov_code,cpprovm.prov_" & _
        "name,", "iventrdm.entr_date,iventrdm.whse_code", "from iventrdm inner join cpprovm on iventrdm.prov_code=cpprovm.prov_code"}
        Me.XDBiventrdm.TableName = "iventrdm"
        Me.XDBiventrdm.UpdateOrder = 0
        Me.XDBiventrdm.UseRowRetrieve = False
        '
        'XDBiventrdd
        '
        Me.XDBiventrdd.AllowDelete = True
        Me.XDBiventrdd.AllowEdit = True
        Me.XDBiventrdd.AllowNew = True
        Me.XDBiventrdd.AutoIncrementSerial = False
        Me.XDBiventrdd.CustomDbUpdate = False
        Me.XDBiventrdd.DeleteOrder = 0
        Me.XDBiventrdd.FillOnQuery = True
        Me.XDBiventrdd.FillOnRowChange = True
        Me.XDBiventrdd.HeaderIsOnGrid = False
        Me.XDBiventrdd.InsertOrder = 0
        Me.XDBiventrdd.IsDetail = True
        Me.XDBiventrdd.KeyFields = Nothing
        Me.XDBiventrdd.MasterDetailRelation = New String() {"entr_serial=entr_serial"}
        Me.XDBiventrdd.MasterTableName = Nothing
        Me.XDBiventrdd.SerialColumnName = Nothing
        Me.XDBiventrdd.Sort = Nothing
        Me.XDBiventrdd.Source = New String() {"select iventrdd.entr_serial,iventrdd.item_code,ivitemm.item_name,", " iventrdd.qty,iventrdm.prov_code,iventrdm.whse_code", "from iventrdd ", "inner join ivitemm ", "on iventrdd.item_code = ivitemm.item_code", "and ivitemm.item_serial =1", "inner join iventrdm on iventrdm.entr_serial = iventrdd.entr_serial"}
        Me.XDBiventrdd.TableName = "iventrdd"
        Me.XDBiventrdd.UpdateOrder = 0
        Me.XDBiventrdd.UseRowRetrieve = True
        '
        'XDBivseriem
        '
        Me.XDBivseriem.AllowDelete = True
        Me.XDBivseriem.AllowEdit = True
        Me.XDBivseriem.AllowNew = True
        Me.XDBivseriem.AutoIncrementSerial = False
        Me.XDBivseriem.CustomDbUpdate = False
        Me.XDBivseriem.DeleteOrder = 0
        Me.XDBivseriem.FillOnQuery = True
        Me.XDBivseriem.FillOnRowChange = True
        Me.XDBivseriem.HeaderIsOnGrid = True
        Me.XDBivseriem.InsertOrder = 0
        Me.XDBivseriem.IsDetail = True
        Me.XDBivseriem.KeyFields = Nothing
        Me.XDBivseriem.MasterDetailRelation = New String() {"entr_serial=entr_serial", "item_code=item_code"}
        Me.XDBivseriem.MasterTableName = "iventrdd"
        Me.XDBivseriem.SerialColumnName = Nothing
        Me.XDBivseriem.Sort = Nothing
        Me.XDBivseriem.Source = Nothing
        Me.XDBivseriem.TableName = "ivseriem"
        Me.XDBivseriem.UpdateOrder = 0
        Me.XDBivseriem.UseRowRetrieve = False
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "fact_number"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "item_code"
        Me.DataColumn4.MaxLength = 15
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "item_name"
        Me.DataColumn5.MaxLength = 100
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "qty"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "ftserial_no"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 88)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documento"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.entr_number"))
        Me.TextBox1.Location = New System.Drawing.Point(72, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Factura:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Suplidor"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.prov_name"))
        Me.TextBox2.Location = New System.Drawing.Point(72, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(376, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'DataView1
        '
        Me.DataView1.AllowDelete = False
        Me.DataView1.AllowEdit = False
        Me.DataView1.AllowNew = False
        Me.DataView1.Table = Me.iventrdd
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(448, 312)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.TabIndex = 4
        Me.btnAccept.Text = "Aceptar"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(528, 312)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancelar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(0, 296)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(608, 8)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'XEditTextBoxColumn5
        '
        Me.XEditTextBoxColumn5.Format = ""
        Me.XEditTextBoxColumn5.FormatInfo = Nothing
        Me.XEditTextBoxColumn5.HeaderText = "Factura No"
        Me.XEditTextBoxColumn5.ImageList = Nothing
        Me.XEditTextBoxColumn5.isReadOnly = False
        Me.XEditTextBoxColumn5.MappingName = "ftserial_no"
        Me.XEditTextBoxColumn5.ReadOnly = True
        Me.XEditTextBoxColumn5.UseCustomCellFormat = False
        Me.XEditTextBoxColumn5.Width = 0
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.CaptionText = "Productos Serializados"
        Me.LibXGrid1.DataMember = ""
        Me.LibXGrid1.DataSource = Me.DataView1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 104)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(424, 192)
        Me.LibXGrid1.TabIndex = 7
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "iventrdd"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Producto"
        Me.DataGridTextBoxColumn1.MappingName = "item_code"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn2.MappingName = "item_name"
        Me.DataGridTextBoxColumn2.Width = 200
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridTextBoxColumn3.MappingName = "qty"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'LibXGrid2
        '
        Me.LibXGrid2.AutoSearch = False
        Me.LibXGrid2.CaptionText = "Series"
        Me.LibXGrid2.DataMember = "ivseriem"
        Me.LibXGrid2.DataSource = Me.DataSet1
        Me.LibXGrid2.FullRowSelect = False
        Me.LibXGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid2.IsReadOnly = False
        Me.LibXGrid2.Location = New System.Drawing.Point(440, 104)
        Me.LibXGrid2.Name = "LibXGrid2"
        Me.LibXGrid2.ReadOnly = True
        Me.LibXGrid2.showFooterBar = False
        Me.LibXGrid2.Size = New System.Drawing.Size(160, 192)
        Me.LibXGrid2.TabIndex = 8
        Me.LibXGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle2})
        Me.LibXGrid2.UseAutoFillLines = True
        '
        'XdataGridTableStyle2
        '
        Me.XdataGridTableStyle2.DataGrid = Me.LibXGrid2
        Me.XdataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XEditTextBoxColumn2})
        Me.XdataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle2.MappingName = "ivseriem"
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Serie Número"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "serie_number"
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 115
        '
        'i_ivserie01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(610, 354)
        Me.Controls.Add(Me.LibXGrid2)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "i_ivserie01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Series"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivseriem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iventrdm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iventrdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction

    End Sub

    Private Sub i_ftserie01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            ivseriem.Columns("ftserial_no").AutoIncrement = False
            iventrdm.Columns("entr_serial").AutoIncrement = False
            LoadDocument()

        Catch ex As Exception
            LibX.Log.Show(ex)
            Me.Close()
        End Try

    End Sub

    Private Sub LoadDocument()
        Dim WhereStmt As String
        Try
            If LibXConnector1.Parameters Is Nothing Then
                Exit Sub
            End If

            WhereStmt = "entr_serial = " & LibXConnector1.Parameters.Value.ToString
            LibXConnector1.ExecuteFind(WhereStmt)

            LibXConnector1.Edit()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As System.Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid1.CurrentRowChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                If ivseriem.Rows.Count > 0 Then
                    SaveSerial(iventrdd.Rows(e.previousRow))
                End If
            End If

            LoadDetail(iventrdd.Rows(e.row))

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LoadDetail(ByVal MasterRow As DataRow)
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim oCmd As OleDb.OleDbCommand
        Dim oAdp As OleDb.OleDbDataAdapter

        Try
            SelectStmt = "select * from ivseriem " & _
                         " where item_code = '" & MasterRow!item_code.ToString & "'" & _
                         " and entr_serial = " & MasterRow!entr_serial.ToString

            oAdp = New OleDb.OleDbDataAdapter(SelectStmt, CType(LibX.Data.Manager.Connection.ConnectionObject, OleDb.OleDbConnection))
            oAdp.MissingMappingAction = MissingMappingAction.Passthrough

            ivseriem.Rows.Clear()
            oAdp.Fill(ivseriem)

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub SaveSerial(ByVal MasterRow As DataRow)
        Dim SelectStmt As String
        Dim xInsert As LibX.Data.XInsertStmt
        Try
            For Each orow As DataRow In ivseriem.Rows
                orow.BeginEdit()
                For Each oCol As DataColumn In ivseriem.Columns
                    If MasterRow.Table.Columns.Contains(oCol.ColumnName) Then
                        orow.Item(oCol.ColumnName) = MasterRow.Item(oCol.ColumnName)
                    End If
                Next
                orow.EndEdit()

            Next

            LibX.Data.Manager.Save(ivseriem)

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        Try
            If ivseriem.Rows.Count > 0 Then
                SaveSerial(iventrdd.Rows(LibXGrid1.CurrentRowIndex))
            End If
            Me.Close()

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            If MessageBox.Show("Seguro desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                LibXConnector1.Cancel()
                Me.Close()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXGrid2_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles LibXGrid2.Navigate

    End Sub

    Private Sub LibXGrid2_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid2.CurrentRowChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                If ivseriem.Rows.Count = Val(LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 2).Trim) Then
                    LibXGrid2.CurrentRowIndex = e.previousRow
                    Throw New ApplicationException("Cantidad excede la cantidad de productos vendidos")
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class
