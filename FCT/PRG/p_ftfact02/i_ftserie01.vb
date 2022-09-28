Public Class i_ftserie01
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
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
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
    Friend WithEvents DataColumn2 As System.Data.DataColumn
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
    Friend WithEvents ftfactd As System.Data.DataTable
    Friend WithEvents ftfactm As System.Data.DataTable
    Friend WithEvents xlk_serial_number As LibX.LibXLookup
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
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents XDataGridTextButtonColumn1 As LibX.XDataGridTextButtonColumn
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ivseriem = New System.Data.DataTable
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.ftfactd = New System.Data.DataTable
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.ftfactm = New System.Data.DataTable
        Me.DataColumn2 = New System.Data.DataColumn
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
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.DataView1 = New System.Data.DataView
        Me.xlk_serial_number = New LibX.LibXLookup
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
        Me.XDataGridTextButtonColumn1 = New LibX.XDataGridTextButtonColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivseriem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXConnector1.DataMember = "ftfactm"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2, Me.LibXDbSourceTable3})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivseriem, Me.ftfactd, Me.ftfactm})
        '
        'ivseriem
        '
        Me.ivseriem.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13})
        Me.ivseriem.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"serie_number"}, True), New System.Data.ForeignKeyConstraint("Relation1", "ftfactd", New String() {"item_code"}, New String() {"item_code"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)})
        Me.ivseriem.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn7}
        Me.ivseriem.TableName = "ivseriem"
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "serie_number"
        Me.DataColumn7.MaxLength = 20
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "entr_number"
        Me.DataColumn8.DataType = GetType(System.Int32)
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
        Me.DataColumn13.ColumnMapping = System.Data.MappingType.Hidden
        Me.DataColumn13.ColumnName = "ftserial_no"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'ftfactd
        '
        Me.ftfactd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn1})
        Me.ftfactd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"item_code"}, False)})
        Me.ftfactd.TableName = "ftfactd"
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
        'ftfactm
        '
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn2, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31})
        Me.ftfactm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no"}, True)})
        Me.ftfactm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn2}
        Me.ftfactm.TableName = "ftfactm"
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.AutoIncrement = True
        Me.DataColumn2.ColumnName = "ftserial_no"
        Me.DataColumn2.DataType = GetType(System.Int32)
        Me.DataColumn2.ReadOnly = True
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "whse_code"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "cotiz_serial"
        Me.DataColumn15.DataType = GetType(System.Int32)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "term_code"
        Me.DataColumn16.MaxLength = 5
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "addr_code"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "vend_code"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "fact_number"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "fact_date"
        Me.DataColumn20.DataType = GetType(System.DateTime)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "fact_total"
        Me.DataColumn21.DataType = GetType(System.Decimal)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "descto"
        Me.DataColumn22.DataType = GetType(System.Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "itbis"
        Me.DataColumn23.DataType = GetType(System.Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "total_comision"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "userid"
        Me.DataColumn25.MaxLength = 20
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "fact_status"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "date_created"
        Me.DataColumn27.DataType = GetType(System.DateTime)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "type_code"
        Me.DataColumn28.MaxLength = 3
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "cust_code"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "fact_cond"
        Me.DataColumn30.DataType = GetType(System.Int16)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "bus_name"
        Me.DataColumn31.MaxLength = 40
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
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ftfactm"
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
        Me.LibXDbSourceTable2.FillOnRowChange = True
        Me.LibXDbSourceTable2.HeaderIsOnGrid = False
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"ftserial_no=ftserial_no"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select ftfactm.ftserial_no,ftfactm.fact_number, ftfactd.item_code,ivitemm.item_na" & _
        "me, ftfactd.qty", "from ftfactd ", "inner join ivitemm ", "on ftfactd.item_code = ivitemm.item_code", "and ivitemm.item_serial =1", "inner join ftfactm on ftfactm.ftserial_no = ftfactd.ftserial_no"}
        Me.LibXDbSourceTable2.TableName = "ftfactd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = True
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
        Me.LibXDbSourceTable3.FillOnRowChange = True
        Me.LibXDbSourceTable3.HeaderIsOnGrid = True
        Me.LibXDbSourceTable3.InsertOrder = 0
        Me.LibXDbSourceTable3.IsDetail = True
        Me.LibXDbSourceTable3.KeyFields = Nothing
        Me.LibXDbSourceTable3.MasterDetailRelation = New String() {"ftserial_no=ftserial_no", "item_code=item_code"}
        Me.LibXDbSourceTable3.MasterTableName = "ftfactd"
        Me.LibXDbSourceTable3.SerialColumnName = Nothing
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = Nothing
        Me.LibXDbSourceTable3.TableName = "ivseriem"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
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
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_number"))
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
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cliente:"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.bus_name"))
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
        Me.DataView1.Table = Me.ftfactd
        '
        'xlk_serial_number
        '
        Me.xlk_serial_number.DataMember = Nothing
        Me.xlk_serial_number.DataSource = Me.LibXConnector1
        Me.xlk_serial_number.DestParameters = New String() {"serie_number=serie_number"}
        Me.xlk_serial_number.IgnoreFindInBrowseMode = False
        Me.xlk_serial_number.Location = New System.Drawing.Point(520, 176)
        Me.xlk_serial_number.LookCaption = "Seriales"
        Me.xlk_serial_number.Name = "xlk_serial_number"
        Me.xlk_serial_number.Size = New System.Drawing.Size(16, 20)
        Me.xlk_serial_number.SqlString = Nothing
        Me.xlk_serial_number.SrcParameters = New String() {"serie_number=serie_number"}
        Me.xlk_serial_number.TabIndex = 3
        Me.xlk_serial_number.TableName = "ivseriem"
        Me.xlk_serial_number.UseCopyConnection = False
        Me.xlk_serial_number.UseRowRetrieveEvents = False
        Me.xlk_serial_number.VisParameters = New String() {"Factura=entr_number", "Serial=serie_number"}
        Me.xlk_serial_number.WhereCondition = "ftserial_no is null"
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
        Me.LibXGrid1.Size = New System.Drawing.Size(392, 192)
        Me.LibXGrid1.TabIndex = 7
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ftfactd"
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
        Me.LibXGrid2.Location = New System.Drawing.Point(408, 104)
        Me.LibXGrid2.Name = "LibXGrid2"
        Me.LibXGrid2.ReadOnly = True
        Me.LibXGrid2.showFooterBar = False
        Me.LibXGrid2.Size = New System.Drawing.Size(192, 192)
        Me.LibXGrid2.TabIndex = 8
        Me.LibXGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle2})
        Me.LibXGrid2.UseAutoFillLines = True
        '
        'XdataGridTableStyle2
        '
        Me.XdataGridTableStyle2.DataGrid = Me.LibXGrid2
        Me.XdataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XDataGridTextButtonColumn1, Me.XEditTextBoxColumn3, Me.XEditTextBoxColumn1})
        Me.XdataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle2.MappingName = "ivseriem"
        '
        'XDataGridTextButtonColumn1
        '
        Me.XDataGridTextButtonColumn1.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.XDataGridTextButtonColumn1.executeFindDuringFill = True
        Me.XDataGridTextButtonColumn1.Format = ""
        Me.XDataGridTextButtonColumn1.FormatInfo = Nothing
        Me.XDataGridTextButtonColumn1.HeaderText = "Serie Número"
        Me.XDataGridTextButtonColumn1.Lookup = Me.xlk_serial_number
        Me.XDataGridTextButtonColumn1.MappingName = "serie_number"
        Me.XDataGridTextButtonColumn1.UseCustomCellFormat = False
        Me.XDataGridTextButtonColumn1.Width = 110
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Orden"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = False
        Me.XEditTextBoxColumn3.MappingName = "entr_number"
        Me.XEditTextBoxColumn3.ReadOnly = True
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 75
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Factura"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "ftserial_no"
        Me.XEditTextBoxColumn1.ReadOnly = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 0
        '
        'i_ftserie01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(610, 354)
        Me.Controls.Add(Me.LibXGrid2)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.xlk_serial_number)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "i_ftserie01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Series"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivseriem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        ''''Try
        ''''    If e.AcceptedAction = LibX.LibxConnectionActions.Find And LibXConnector1.HasRecords = True Then
        ''''        For Each oRow As DataRow In LibXConnector1.GetTable("ftfactd").rows
        ''''            Dim oRow1 As DataRow = DataSet1.Tables("ftfactd").NewRow
        ''''            oRow1.ItemArray = oRow.ItemArray
        ''''            DataSet1.Tables("ftfactd").Rows.Add(oRow1)
        ''''        Next
        ''''    End If
        ''''Catch ex As Exception
        ''''    LibX.Log.Show(ex)
        ''''End Try

    End Sub

    Private Sub i_ftserie01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            '''    If Not LibXConnector1 Is Nothing Then
            '''        If FactNumber <= 0 Then
            '''            Throw New ApplicationException("Debe enviar el número de factura")
            '''        Else
            '''            LibXConnector1.ExecuteFind("fact_number = " & FactNumber.ToString)
            '''        End If
            '''    End If

            ftfactm.Columns("ftserial_no").AutoIncrement = False
            ftfactd.Columns("ftserial_no").AutoIncrement = False
            ivseriem.Columns("ftserial_no").AutoIncrement = False
            LoadDocument()


        Catch ex As Exception
            LibX.Log.Show(ex)
            Me.Close()
        End Try

    End Sub

    Private Sub LoadDocument()
        Dim WhereStmt As String
        Try
            If LibX.App.CurrentPrgParams Is Nothing Then
                Exit Sub
            End If

            WhereStmt = "ftserial_no = " & LibX.App.CurrentPrgParams.Value.ToString
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
                    SaveSerial(ftfactd.Rows(e.previousRow))
                End If
            End If

            LoadDetail(ftfactd.Rows(e.row))

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LoadDetail(ByVal MasterRow As DataRow)
        Dim SelectStmt As String
        Dim oTable As DataTable
        Try
            SelectStmt = "select * from ivseriem " & _
                         " where item_code = '" & MasterRow!item_code.ToString & "'" & _
                         " and ftserial_no = " & MasterRow!ftserial_no.ToString

            ivseriem.Rows.Clear()
            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable.Rows.Count > 0 Then
                For Each oRow As DataRow In oTable.Rows
                    Dim oRow1 As DataRow = ivseriem.NewRow

                    oRow1.ItemArray = oRow.ItemArray
                    ivseriem.Rows.Add(oRow1)
                Next
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub SaveSerial(ByVal MasterRow As DataRow)
        Dim SelectStmt As String
        Dim xUpdate As LibX.Data.XUpdateStmt
        Try
            For Each orow As DataRow In ivseriem.Rows
                orow.BeginEdit()
                For Each oCol As DataColumn In ivseriem.Columns
                    If MasterRow.Table.Columns.Contains(oCol.ColumnName) Then
                        orow.Item(oCol.ColumnName) = MasterRow.Item(oCol.ColumnName)
                    End If
                Next
                orow.EndEdit()

                '// 
                xUpdate = New LibX.Data.XUpdateStmt("ivseriem")

                '// Actualizar el no de factura 
                xUpdate.FieldsSet("ftserial_no") = MasterRow!ftserial_no

                '// condición Numero de producto y serial numero
                xUpdate.Fields("item_code") = MasterRow!item_code
                xUpdate.Fields("serie_number") = orow!serie_number

                '// Actualizar
                xUpdate.Execute()
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub xlk_serial_number_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_serial_number.BeforeExecuteQuery
        Try
            If LibXGrid1.CurrentRowIndex > -1 Then
                e.aditionalWhere = "item_code = '" & ftfactd.Rows(LibXGrid1.CurrentRowIndex)!item_code & "' and ftserial_no is null"
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub ivseriem_RowChanging(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles ivseriem.RowChanging

    End Sub

    Private Sub xlk_serial_number_BeforeFind(ByVal sender As Object, ByVal e As LibX.LookupFindEventArgs) Handles xlk_serial_number.BeforeFind
        e.aditionalWhere = "ftserial_no is null"
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        Try
            If ivseriem.Rows.Count > 0 Then
                SaveSerial(ftfactd.Rows(LibXGrid1.CurrentRowIndex))
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

            If ivseriem.Rows.Count > Val(LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 2).Trim) Then
                LibXGrid2.CurrentRowIndex = e.previousRow
                Throw New ApplicationException("Cantidad excede la cantidad de productos vendidos")
            End If

            If ivseriem.Rows.Count = Val(LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 2).Trim) Then
                LibXGrid2.CurrentRowIndex = e.previousRow
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class
