Public Class i_ftserial
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
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents ivseriem As System.Data.DataTable
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
    Friend WithEvents DataGridTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents XdataGridTableStyle2 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblitem_code As System.Windows.Forms.Label
    Friend WithEvents lblitem_name As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
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
        Me.DataColumn35 = New System.Data.DataColumn
        Me.ftfactd = New System.Data.DataTable
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
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
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
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
        Me.DataGridTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.DataGridTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.DataGridTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.LibXGrid2 = New LibX.LibXGrid
        Me.XdataGridTableStyle2 = New LibX.XdataGridTableStyle
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblitem_code = New System.Windows.Forms.Label
        Me.lblitem_name = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
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
        Me.ivseriem.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn7, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn35})
        Me.ivseriem.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"serie_number"}, True), New System.Data.ForeignKeyConstraint("Relation1", "ftfactd", New String() {"item_code"}, New String() {"item_code"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)})
        Me.ivseriem.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn7}
        Me.ivseriem.TableName = "ivseriem"
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "serie_number"
        Me.DataColumn7.MaxLength = 255
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
        'DataColumn35
        '
        Me.DataColumn35.AllowDBNull = False
        Me.DataColumn35.ColumnName = "entr_serial"
        Me.DataColumn35.DataType = GetType(System.Int32)
        '
        'ftfactd
        '
        Me.ftfactd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn1, Me.DataColumn3, Me.DataColumn8, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39})
        Me.ftfactd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"item_code"}, False)})
        Me.ftfactd.TableName = "ftfactd"
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
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
        Me.DataColumn6.AllowDBNull = False
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
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "fact_number"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "type_code"
        Me.DataColumn8.MaxLength = 3
        '
        'DataColumn36
        '
        Me.DataColumn36.AllowDBNull = False
        Me.DataColumn36.ColumnName = "line_no"
        Me.DataColumn36.DataType = GetType(System.Int32)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "prov_code"
        Me.DataColumn37.DataType = GetType(System.Int32)
        '
        'DataColumn38
        '
        Me.DataColumn38.AllowDBNull = False
        Me.DataColumn38.ColumnName = "whse_code"
        Me.DataColumn38.DataType = GetType(System.Int32)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "existencia"
        Me.DataColumn39.DataType = GetType(System.Int32)
        '
        'ftfactm
        '
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn2, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43})
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
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "fact_number"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "fact_date"
        Me.DataColumn20.DataType = GetType(System.DateTime)
        '
        'DataColumn21
        '
        Me.DataColumn21.AllowDBNull = False
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
        Me.DataColumn26.AllowDBNull = False
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
        Me.DataColumn28.AllowDBNull = False
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
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "fact_cond"
        Me.DataColumn30.DataType = GetType(System.Int16)
        '
        'DataColumn31
        '
        Me.DataColumn31.AllowDBNull = False
        Me.DataColumn31.ColumnName = "bus_name"
        Me.DataColumn31.MaxLength = 40
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "dev_type"
        Me.DataColumn32.MaxLength = 3
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "fact_nota"
        Me.DataColumn33.MaxLength = 80
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "ftserial_afect"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "pay_adelant"
        Me.DataColumn40.DataType = GetType(System.Int32)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "phone"
        Me.DataColumn41.MaxLength = 8
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "pay_mora"
        Me.DataColumn42.DataType = GetType(System.Decimal)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "porc_comision"
        Me.DataColumn43.DataType = GetType(System.Decimal)
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
        Me.LibXDbSourceTable2.Source = New String() {"select ftfactm.ftserial_no,ftfactm.fact_number, ftfactd.item_code,", "ivitemm.item_name,ivitemm.prov_code,ftfactd.whse_code,", "ftfactd.qty,ftfactm.type_code,line_no,ivitemd.existencia", "from ftfactd ", "inner join ivitemm ", "on ftfactd.item_code = ivitemm.item_code", "and ivitemm.item_serial =1", "inner join ivitemd", "on ivitemd.item_code = ftfactd.item_code", "and ivitemd.whse_code = ftfactd.whse_code", "inner join ftfactm ", "on ftfactm.ftserial_no = ftfactd.ftserial_no"}
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
        Me.GroupBox1.Size = New System.Drawing.Size(760, 88)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documento"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_number"))
        Me.TextBox1.Location = New System.Drawing.Point(72, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(112, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TabStop = False
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
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente:"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.bus_name"))
        Me.TextBox2.Location = New System.Drawing.Point(72, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(376, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TabStop = False
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
        Me.xlk_serial_number.CheckText = Nothing
        Me.xlk_serial_number.DataMember = Nothing
        Me.xlk_serial_number.DataSource = Me.LibXConnector1
        Me.xlk_serial_number.DestParameters = New String() {"serie_number=serie_number", "entr_serial=entr_serial"}
        Me.xlk_serial_number.FilterField = Nothing
        Me.xlk_serial_number.IgnoreFindInBrowseMode = False
        Me.xlk_serial_number.Location = New System.Drawing.Point(520, 176)
        Me.xlk_serial_number.LookCaption = "Seriales"
        Me.xlk_serial_number.Name = "xlk_serial_number"
        Me.xlk_serial_number.ShowMessageNotFound = True
        Me.xlk_serial_number.ShowWarning = False
        Me.xlk_serial_number.Size = New System.Drawing.Size(16, 20)
        Me.xlk_serial_number.SizesColumns = Nothing
        Me.xlk_serial_number.SizesColumnsTab = Nothing
        Me.xlk_serial_number.SqlString = Nothing
        Me.xlk_serial_number.SQLTab = Nothing
        Me.xlk_serial_number.SrcParameters = New String() {"serie_number=serie_number"}
        Me.xlk_serial_number.TabIndex = 3
        Me.xlk_serial_number.TableName = "ivseriem"
        Me.xlk_serial_number.UseCopyConnection = False
        Me.xlk_serial_number.UseRowRetrieveEvents = False
        Me.xlk_serial_number.UseTab = False
        Me.xlk_serial_number.VisParameters = New String() {"Factura=entr_serial", "Serial=serie_number"}
        Me.xlk_serial_number.WhereCondition = "ftserial_no is null"
        Me.xlk_serial_number.WhereParameters = Nothing
        '
        'btnAccept
        '
        Me.btnAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAccept.Location = New System.Drawing.Point(616, 464)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.TabIndex = 5
        Me.btnAccept.Text = "Aceptar"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(696, 464)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancelar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 448)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 8)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'XEditTextBoxColumn5
        '
        Me.XEditTextBoxColumn5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn5.Format = ""
        Me.XEditTextBoxColumn5.FormatInfo = Nothing
        Me.XEditTextBoxColumn5.HeaderText = "Factura No"
        Me.XEditTextBoxColumn5.ImageList = Nothing
        Me.XEditTextBoxColumn5.isReadOnly = False
        Me.XEditTextBoxColumn5.MappingName = "ftserial_no"
        Me.XEditTextBoxColumn5.MaxLength = 32767
        Me.XEditTextBoxColumn5.ReadOnly = True
        Me.XEditTextBoxColumn5.UseCustomCellFormat = False
        Me.XEditTextBoxColumn5.Width = 0
        '
        'LibXGrid1
        '
        Me.LibXGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Productos Serializados"
        Me.LibXGrid1.DataMember = ""
        Me.LibXGrid1.DataSource = Me.DataView1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 104)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(560, 296)
        Me.LibXGrid1.TabIndex = 1
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ftfactd"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Producto"
        Me.DataGridTextBoxColumn1.ImageList = Nothing
        Me.DataGridTextBoxColumn1.isReadOnly = True
        Me.DataGridTextBoxColumn1.MappingName = "item_code"
        Me.DataGridTextBoxColumn1.MaxLength = 32767
        Me.DataGridTextBoxColumn1.UseCustomCellFormat = False
        Me.DataGridTextBoxColumn1.Width = 140
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn2.ImageList = Nothing
        Me.DataGridTextBoxColumn2.isReadOnly = True
        Me.DataGridTextBoxColumn2.MappingName = "item_name"
        Me.DataGridTextBoxColumn2.MaxLength = 32767
        Me.DataGridTextBoxColumn2.UseCustomCellFormat = False
        Me.DataGridTextBoxColumn2.Width = 300
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridTextBoxColumn3.ImageList = Nothing
        Me.DataGridTextBoxColumn3.isReadOnly = True
        Me.DataGridTextBoxColumn3.MappingName = "qty"
        Me.DataGridTextBoxColumn3.MaxLength = 32767
        Me.DataGridTextBoxColumn3.UseCustomCellFormat = False
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'LibXGrid2
        '
        Me.LibXGrid2.AllowSorting = False
        Me.LibXGrid2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LibXGrid2.AutoAdjustLastColumn = False
        Me.LibXGrid2.AutoSearch = False
        Me.LibXGrid2.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid2.CaptionText = "Series"
        Me.LibXGrid2.DataMember = "ivseriem"
        Me.LibXGrid2.DataSource = Me.DataSet1
        Me.LibXGrid2.FullRowSelect = False
        Me.LibXGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid2.IsReadOnly = False
        Me.LibXGrid2.Location = New System.Drawing.Point(576, 104)
        Me.LibXGrid2.Name = "LibXGrid2"
        Me.LibXGrid2.ReadOnly = True
        Me.LibXGrid2.searchText = ""
        Me.LibXGrid2.showFooterBar = True
        Me.LibXGrid2.Size = New System.Drawing.Size(192, 296)
        Me.LibXGrid2.TabIndex = 0
        Me.LibXGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle2})
        Me.LibXGrid2.UseAutoFillLines = True
        Me.LibXGrid2.UseHandCursor = False
        '
        'XdataGridTableStyle2
        '
        Me.XdataGridTableStyle2.AllowSorting = False
        Me.XdataGridTableStyle2.DataGrid = Me.LibXGrid2
        Me.XdataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn4, Me.XEditTextBoxColumn1})
        Me.XdataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle2.MappingName = "ivseriem"
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Serie Número"
        Me.DataGridTextBoxColumn4.MappingName = "serie_number"
        Me.DataGridTextBoxColumn4.Width = 130
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Factura"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "ftserial_no"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.ReadOnly = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 0
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(8, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Código:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(8, 432)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Descripción:"
        '
        'lblitem_code
        '
        Me.lblitem_code.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblitem_code.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblitem_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataView1, "item_code"))
        Me.lblitem_code.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblitem_code.Location = New System.Drawing.Point(80, 404)
        Me.lblitem_code.Name = "lblitem_code"
        Me.lblitem_code.Size = New System.Drawing.Size(184, 20)
        Me.lblitem_code.TabIndex = 10
        '
        'lblitem_name
        '
        Me.lblitem_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblitem_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblitem_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataView1, "item_name"))
        Me.lblitem_name.Location = New System.Drawing.Point(80, 428)
        Me.lblitem_name.Name = "lblitem_name"
        Me.lblitem_name.Size = New System.Drawing.Size(488, 20)
        Me.lblitem_name.TabIndex = 10
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Location = New System.Drawing.Point(8, 464)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Eliminar"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataView1, "existencia"))
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(480, 404)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(396, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Existencia:"
        '
        'i_ftserial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(778, 506)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblitem_code)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LibXGrid2)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.xlk_serial_number)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblitem_name)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "i_ftserial"
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


    Private Sub i_ftserie01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            LibXGrid2.footerOperations.add("serie_number", "count(serie_number)")
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
            If LibXConnector1.Parameters Is Nothing Then
                Exit Sub
            End If

            If LibXConnector1.Parameters.Datos.Contains("usetransaction") Then
                LibXConnector1.UseTransactions = CType(LibXConnector1.Parameters.Datos.Item("usetransaction"), Boolean)
            End If

            WhereStmt = "ftserial_no = " & LibXConnector1.Parameters.Value.ToString
            LibXConnector1.ExecuteFind(WhereStmt)

            LibXConnector1.Edit()

            If ftfactd.Rows.Count > 0 Then
                LoadDetail(ftfactd.Rows(0))
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXGrid1_CurrentRowChanged(ByVal sender As System.Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid1.CurrentRowChanged
        Try
            If LibXConnector1.IsDataEditing = True AndAlso ftfactd.Rows.Count > 0 Then
                If e.previousRow > -1 Then
                    SaveSerial(ftfactd.Rows(e.previousRow))
                End If
            End If

            If ftfactd.Rows.Count > 0 Then
                LoadDetail(ftfactd.Rows(e.row))
            End If
            InitGrid(e.row)

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LoadDetail(ByVal MasterRow As DataRow)
        Dim SelectStmt As String
        Dim oTable As DataTable
        Try
            If MasterRow Is Nothing Then
                Exit Sub
            End If

            SelectStmt = "select serie_number,item_code,whse_code,prov_code," & _
                         "serie_status,ftserial_no,entr_serial from ivseriem " & _
                         " where item_code = '" & MasterRow!item_code.ToString & "'" & _
                         " and ftserial_no = " & MasterRow!ftserial_no.ToString

            ivseriem.Rows.Clear()
            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable.Rows.Count > 0 Then
                For Each oRow As DataRow In oTable.Rows
                    Dim oRow1 As DataRow = ivseriem.NewRow

                    oRow1!serie_number = oRow!serie_number
                    oRow1!item_code = oRow!item_code
                    oRow1!whse_code = oRow!whse_code
                    oRow1!prov_code = oRow!prov_code
                    oRow1!serie_status = oRow!serie_status
                    oRow1!ftserial_no = oRow!ftserial_no
                    oRow1!entr_serial = oRow!entr_serial

                    ivseriem.Rows.Add(oRow1)
                Next
                ivseriem.AcceptChanges()

            End If

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub

    Private Sub RemoveRow(ByVal MasterRow As DataRow, ByVal pserie As String)
        Dim SelectStmt As String
        Try
            '// Si es una factura eliminar todas las series 
            '// para reinsertarla otra vez
            Try

                '// borrar las series por item

                If MasterRow Is Nothing Then
                    Exit Sub
                End If

                If pserie.Trim = "" Then
                    Exit Sub
                End If

                SelectStmt = "delete from ftseriem " & _
                             " where ftserial_no = " & MasterRow!ftserial_no.ToString

                SelectStmt = SelectStmt.Trim & _
                " and serie_number = '" & pserie & "'"

                LibX.Data.Manager.ExecuteNonQuery(SelectStmt)

            Catch ex As Exception
            End Try

            Try
                '// borrar las series productos
                SelectStmt = "delete from ivseriem " & _
                             " where ftserial_no = " & MasterRow!ftserial_no.ToString & _
                             "   and item_code = '" & MasterRow!item_code.ToString.Trim & _
                             "' and serie_number = '" & pserie & "'"

                LibX.Data.Manager.ExecuteNonQuery(SelectStmt)
            Catch ex As Exception
            End Try
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub SaveSerial(ByVal MasterRow As DataRow)
        Dim SelectStmt As String
        Dim iCount As Int16
        Dim oRowExist As DataRow
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim xDelete As LibX.Data.XDeleteStmt
        Dim xInsert As LibX.Data.XInsertStmt
        Dim xInsert1 As LibX.Data.XInsertStmt
        Dim DataSetChaged As DataSet
        Try
            '// Si es una factura eliminar todas las series 
            '// para reinsertarla otra vez

            If MasterRow Is Nothing Then
                Exit Sub
            End If

            DataSetChaged = DataSet1.GetChanges

            If DataSetChaged Is Nothing Then
                Exit Sub
            End If

            For Each orow As DataRow In DataSetChaged.Tables("ivseriem").Rows
                '// Si es una devolución eliminar las series
                '// por producto y no. de serie

                If orow.RowState = DataRowState.Deleted Then
                    RemoveRow(MasterRow, orow.Item("serie_number", DataRowVersion.Original))
                    GoTo NEXT_ROW
                End If


                Try
                    '// borrar las series productos
                    SelectStmt = "delete from ivseriem " & _
                                 " where ftserial_no = " & MasterRow!ftserial_no.ToString & _
                                 "   and item_code = '" & MasterRow!item_code.ToString.Trim & _
                                 "' and serie_number = '" & orow!serie_number.ToString.Trim & "'" & _
                                 "  and whse_code = " & MasterRow!whse_code.ToString.Trim

                    LibX.Data.Manager.ExecuteNonQuery(SelectStmt)
                Catch ex As Exception
                End Try

                ''SelectStmt = "select count(*) from ivseriem " & _
                ''             " where serie_number = '" & orow!serie_number.ToString.Trim & _
                ''             "'  and item_code <> '" & MasterRow!item_code.ToString.Trim & "'" & _
                ''             "  and whse_code <> " & MasterRow!whse_code.ToString.Trim

                ''iCount = LibX.Data.Manager.GetScalar(SelectStmt)

                ''If iCount > 0 Then
                ''    MessageBox.Show("Existe otro producto con esta serie '" & orow!serie_number.ToString.Trim & "'!", "Serie Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ''    GoTo NEXT_ROW
                ''End If

                orow.BeginEdit()
                For Each oCol As DataColumn In ivseriem.Columns
                    If MasterRow.Table.Columns.Contains(oCol.ColumnName) Then
                        orow.Item(oCol.ColumnName) = MasterRow.Item(oCol.ColumnName)
                    End If
                Next

                orow.EndEdit()

                '// verificar si existe esta serie
                '''SelectStmt = "select * from ivseriem " & _
                '''             " where item_code = '" & MasterRow!item_code.ToString.Trim & "'" & _
                '''             "   and serie_number = '" & orow!serie_number.ToString.Trim & "'" & _
                '''             "  and whse_code = " & MasterRow!whse_code.ToString.Trim

                SelectStmt = "select * from ivseriem " & _
                             " where serie_number = '" & orow!serie_number.ToString.Trim & "'" 

                oRowExist = LibX.Data.Manager.GetDataRow(SelectStmt)

                If oRowExist Is Nothing Then
                    If Not LibX.IsNull(orow!serie_number) Then
                        xInsert = New LibX.Data.XInsertStmt("ivseriem")

                        With xInsert
                            .Fields("item_code") = MasterRow!item_code
                            .Fields("serie_number") = orow!serie_number
                            .Fields("ftserial_no") = MasterRow!ftserial_no
                            .Fields("whse_code") = MasterRow!whse_code
                            .Fields("prov_code") = MasterRow!prov_code
                            .Fields("serie_status") = 1

                            .Execute()
                        End With

                        xInsert.Dispose()
                    End If
                Else
                    ''''If Not LibX.IsNull(oRowExist!ftserial_no) AndAlso MasterRow!type_code <> "DVF" _
                    ''''AndAlso oRowExist!ftserial_no <> MasterRow!ftserial_no Then
                    ''''    Throw New ApplicationException("Esta serie '" & orow!serie_number.ToString.Trim & "' no esta disponible!")
                    ''''End If

                    If LibX.IsNull(oRowExist!ftserial_no) And MasterRow!type_code = "DVF" Then
                        Throw New ApplicationException("Esta serie '" & orow!serie_number.ToString.Trim & "' no esta registrada como vendida!")
                    End If

                    xUpdate = New LibX.Data.XUpdateStmt("ivseriem")

                    With xUpdate
                        .FieldsSet("ftserial_no") = MasterRow!ftserial_no
                        .FieldsSet("item_code") = MasterRow!item_code
                        .FieldsSet("whse_code") = MasterRow!whse_code
                        .Fields("serie_number") = orow!serie_number.ToString.Trim

                        .Execute()
                    End With

                    xUpdate.Dispose()
                End If

                If Not LibX.IsNull(orow!serie_number) Then
                    Try

                        '// borrar las series por item

                        SelectStmt = "delete from ftseriem " & _
                                     " where ftserial_no = " & MasterRow!ftserial_no.ToString

                        If orow.RowState = DataRowState.Modified Then
                            SelectStmt = SelectStmt.Trim & _
                            " and serie_number = '" & orow("serie_number", DataRowVersion.Original).ToString.Trim & "'"
                        Else
                            SelectStmt = SelectStmt.Trim & _
                                        " and serie_number = '" & orow("serie_number").ToString.Trim & "'"
                        End If

                        LibX.Data.Manager.ExecuteNonQuery(SelectStmt)
                    Catch ex As Exception

                    End Try

                    '// Insertar las serie por documentos
                    xInsert1 = New LibX.Data.XInsertStmt("ftseriem")

                    With xInsert1
                        .Fields("serie_number") = orow!serie_number
                        .Fields("ftserial_no") = MasterRow!ftserial_no
                        .Fields("line_no") = MasterRow!line_no

                        .Execute()
                    End With

                    xInsert1.Dispose()
                End If
NEXT_ROW:
            Next

        Catch ex As Exception
            LibX.Log.Add(ex, True)

        End Try
    End Sub

    Private Sub xlk_serial_number_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_serial_number.BeforeExecuteQuery
        Try
            If LibXGrid1.CurrentRowIndex > -1 Then
                e.aditionalWhere = "item_code = '" & ftfactd.Rows(LibXGrid1.CurrentRowIndex)!item_code.ToString & "' and ftserial_no is null and " & _
                                    "whse_code = " & ftfactd.Rows(LibXGrid1.CurrentRowIndex)!whse_code.ToString
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)

        End Try
    End Sub

    Private Sub xlk_serial_number_BeforeFind(ByVal sender As Object, ByVal e As LibX.LookupFindEventArgs) Handles xlk_serial_number.BeforeFind
        e.aditionalWhere = "ftserial_no is null"
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        Try
            SaveSerial(ftfactd.Rows(LibXGrid1.CurrentRowIndex))
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
            LibX.Log.Add(ex, True)

        End Try
    End Sub

    Private Sub LibXGrid2_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGrid2.CurrentRowChanged
        Try

            'If ivseriem.Rows.Count > Val(LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 2).Trim) _
            'LibXGrid2.EndEdit(DataGridTextBoxColumn4, e.row, True)
            If ivseriem.Rows.Count > Val(LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 2).Trim) _
            AndAlso LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 2).ToString.Length > 0 Then

                Try
                    LibXGrid2.getCurrentGridView.Delete(LibXGrid2.getCurrentGridView.Count - 1)
                Finally
                End Try

                Throw New ApplicationException("Cantidad excede la cantidad de productos vendidos")
            End If


            ''If ivseriem.Rows.Count = Val(LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 2).Trim) Then
            ''    LibXGrid2.CurrentRowIndex = e.previousRow
            ''End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try

            For Each orow As DataRow In ivseriem.Rows
                orow.Delete()
            Next

            For Each oRow As DataRow In ftfactd.Rows
                SaveSerial(oRow)
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LibXGrid1.Click
        InitGrid(0)

    End Sub

    Private Sub InitGrid(ByVal row As Integer)
        Try
            '''LibXGrid2.EndInit()
            '''LibXGrid2.BeginInit()
            If ivseriem.Rows.Count <= 0 Then
                ivseriem.NewRow()
            End If
            LibXGrid2.Focus()
            LibXGrid2.BeginEdit(DataGridTextBoxColumn4, row)
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
End Class
