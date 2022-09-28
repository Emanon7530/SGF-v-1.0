Public Class i_ftserial02
    Inherits System.Windows.Forms.Form
    Dim FactNumber As Integer
    Dim WhDefault As Integer

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
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents xlk_serial_number As LibX.LibXLookup
    '<System.Diagnostics.DebuggerStepThrough()> 
    Friend WithEvents XEditTextBoxColumn5 As LibX.XEditTextBoxColumn
    Friend WithEvents LibXGrid2 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle2 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gColSerieNumber As LibX.XDataGridTextButtonColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents DataSet1 As System.Data.DataSet
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
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents DataColumn73 As System.Data.DataColumn
    Friend WithEvents DataColumn74 As System.Data.DataColumn
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents DataColumn76 As System.Data.DataColumn
    Friend WithEvents DataColumn77 As System.Data.DataColumn
    Friend WithEvents DataColumn78 As System.Data.DataColumn
    Friend WithEvents ftfactm As System.Data.DataTable
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ftfactm = New System.Data.DataTable
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.DataTable3 = New System.Data.DataTable
        Me.DataColumn72 = New System.Data.DataColumn
        Me.DataColumn73 = New System.Data.DataColumn
        Me.DataColumn74 = New System.Data.DataColumn
        Me.DataColumn75 = New System.Data.DataColumn
        Me.DataColumn76 = New System.Data.DataColumn
        Me.DataColumn77 = New System.Data.DataColumn
        Me.DataColumn78 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.xlk_serial_number = New LibX.LibXLookup
        Me.XEditTextBoxColumn5 = New LibX.XEditTextBoxColumn
        Me.LibXGrid2 = New LibX.LibXGrid
        Me.XdataGridTableStyle2 = New LibX.XdataGridTableStyle
        Me.gColSerieNumber = New LibX.XDataGridTextButtonColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
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
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn71 = New System.Data.DataColumn
        Me.LibXNavigator1 = New LibX.LibXNavigator
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable3})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftfactm, Me.DataTable3})
        '
        'ftfactm
        '
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60})
        Me.ftfactm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no"}, True)})
        Me.ftfactm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn36}
        Me.ftfactm.TableName = "ftfactm"
        '
        'DataColumn36
        '
        Me.DataColumn36.AllowDBNull = False
        Me.DataColumn36.AutoIncrement = True
        Me.DataColumn36.ColumnName = "ftserial_no"
        Me.DataColumn36.DataType = GetType(System.Int32)
        Me.DataColumn36.ReadOnly = True
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "whse_code"
        Me.DataColumn37.DataType = GetType(System.Int32)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "dev_type"
        Me.DataColumn38.MaxLength = 3
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "cotiz_serial"
        Me.DataColumn39.DataType = GetType(System.Int32)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "term_code"
        Me.DataColumn40.MaxLength = 5
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "addr_code"
        Me.DataColumn41.DataType = GetType(System.Int32)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "vend_code"
        Me.DataColumn42.DataType = GetType(System.Int32)
        '
        'DataColumn43
        '
        Me.DataColumn43.AllowDBNull = False
        Me.DataColumn43.ColumnName = "fact_number"
        Me.DataColumn43.DataType = GetType(System.Int32)
        '
        'DataColumn44
        '
        Me.DataColumn44.AllowDBNull = False
        Me.DataColumn44.ColumnName = "fact_date"
        Me.DataColumn44.DataType = GetType(System.DateTime)
        '
        'DataColumn45
        '
        Me.DataColumn45.AllowDBNull = False
        Me.DataColumn45.ColumnName = "fact_total"
        Me.DataColumn45.DataType = GetType(System.Decimal)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "descto"
        Me.DataColumn46.DataType = GetType(System.Decimal)
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "itbis"
        Me.DataColumn47.DataType = GetType(System.Decimal)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "userid"
        Me.DataColumn48.MaxLength = 20
        '
        'DataColumn49
        '
        Me.DataColumn49.AllowDBNull = False
        Me.DataColumn49.ColumnName = "fact_status"
        Me.DataColumn49.DataType = GetType(System.Int32)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "date_created"
        Me.DataColumn50.DataType = GetType(System.DateTime)
        '
        'DataColumn51
        '
        Me.DataColumn51.AllowDBNull = False
        Me.DataColumn51.ColumnName = "type_code"
        Me.DataColumn51.MaxLength = 3
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "cust_code"
        Me.DataColumn52.DataType = GetType(System.Int32)
        '
        'DataColumn53
        '
        Me.DataColumn53.AllowDBNull = False
        Me.DataColumn53.ColumnName = "fact_cond"
        Me.DataColumn53.DataType = GetType(System.Int16)
        '
        'DataColumn54
        '
        Me.DataColumn54.AllowDBNull = False
        Me.DataColumn54.ColumnName = "bus_name"
        Me.DataColumn54.MaxLength = 40
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "fact_nota"
        Me.DataColumn55.MaxLength = 80
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "ftserial_afect"
        Me.DataColumn56.DataType = GetType(System.Int32)
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "pay_adelant"
        Me.DataColumn57.DataType = GetType(System.Int32)
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "phone"
        Me.DataColumn58.MaxLength = 8
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "pay_mora"
        Me.DataColumn59.DataType = GetType(System.Decimal)
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "porc_comision"
        Me.DataColumn60.DataType = GetType(System.Decimal)
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn72, Me.DataColumn73, Me.DataColumn74, Me.DataColumn75, Me.DataColumn76, Me.DataColumn77, Me.DataColumn78})
        Me.DataTable3.TableName = "ftseriem"
        '
        'DataColumn72
        '
        Me.DataColumn72.AllowDBNull = False
        Me.DataColumn72.ColumnName = "ftserial_no"
        Me.DataColumn72.DataType = GetType(System.Int32)
        '
        'DataColumn73
        '
        Me.DataColumn73.AllowDBNull = False
        Me.DataColumn73.ColumnName = "serie_number"
        Me.DataColumn73.MaxLength = 255
        '
        'DataColumn74
        '
        Me.DataColumn74.AllowDBNull = False
        Me.DataColumn74.ColumnName = "line_no"
        Me.DataColumn74.DataType = GetType(System.Int32)
        '
        'DataColumn75
        '
        Me.DataColumn75.AllowDBNull = False
        Me.DataColumn75.ColumnName = "entr_number"
        Me.DataColumn75.DataType = GetType(System.Int32)
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "prov_name"
        Me.DataColumn76.MaxLength = 60
        '
        'DataColumn77
        '
        Me.DataColumn77.AllowDBNull = False
        Me.DataColumn77.ColumnName = "entr_date"
        Me.DataColumn77.DataType = GetType(System.DateTime)
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "serie_status"
        Me.DataColumn78.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.SerialColumnName = "ftserial_no"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ftfactm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
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
        Me.LibXDbSourceTable3.HeaderIsOnGrid = False
        Me.LibXDbSourceTable3.InsertOrder = 0
        Me.LibXDbSourceTable3.IsDetail = True
        Me.LibXDbSourceTable3.KeyFields = Nothing
        Me.LibXDbSourceTable3.MasterDetailRelation = New String() {"ftserial_no=ftserial_no"}
        Me.LibXDbSourceTable3.MasterTableName = ""
        Me.LibXDbSourceTable3.SerialColumnName = Nothing
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = New String() {"select ftseriem.*,iventrdm.entr_number,cpprovm.prov_name,entr_date,ivseriem.serie" & _
        "_status", " from ftseriem", "inner join ivseriem ", "on ivseriem.ftserial_no = ftseriem.ftserial_no", "inner join iventrdm", "on iventrdm.entr_serial = ivseriem.entr_serial", "inner join cpprovm", "on iventrdm.prov_code = iventrdm.prov_code", ""}
        Me.LibXDbSourceTable3.TableName = "ftseriem"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 80)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documento"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_number"))
        Me.TextBox1.Location = New System.Drawing.Point(112, 24)
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
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Devolución No.:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.bus_name"))
        Me.TextBox2.Location = New System.Drawing.Point(112, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(376, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.ftserial_afect"))
        Me.TextBox3.Location = New System.Drawing.Point(384, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(104, 20)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.TabStop = False
        Me.TextBox3.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(312, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Factura No.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_serial_number
        '
        Me.xlk_serial_number.CheckText = Nothing
        Me.xlk_serial_number.DataMember = Nothing
        Me.xlk_serial_number.DataSource = Me.LibXConnector1
        Me.xlk_serial_number.DestParameters = New String() {"serie_number=serie_number", "entr_number=entr_number", "entr_date=entr_date", "prov_name=prov_name"}
        Me.xlk_serial_number.FilterField = Nothing
        Me.xlk_serial_number.IgnoreFindInBrowseMode = True
        Me.xlk_serial_number.Location = New System.Drawing.Point(272, 216)
        Me.xlk_serial_number.LookCaption = "Seriales"
        Me.xlk_serial_number.Name = "xlk_serial_number"
        Me.xlk_serial_number.ShowMessageNotFound = True
        Me.xlk_serial_number.ShowWarning = False
        Me.xlk_serial_number.Size = New System.Drawing.Size(16, 20)
        Me.xlk_serial_number.SizesColumns = Nothing
        Me.xlk_serial_number.SizesColumnsTab = Nothing
        Me.xlk_serial_number.SqlString = New String() {"select ivseriem.serie_number,iventrdm.entr_number,cpprovm.prov_name,", "iventrdm.entr_date,ivseriem.ftserial_no", " from ivseriem", "left outer join iventrdm", "on iventrdm.entr_serial = ivseriem.entr_serial", "left outer join cpprovm", "on cpprovm.prov_code = iventrdm.prov_code"}
        Me.xlk_serial_number.SQLTab = Nothing
        Me.xlk_serial_number.SrcParameters = New String() {"serie_number=serie_number"}
        Me.xlk_serial_number.TabIndex = 3
        Me.xlk_serial_number.TableName = "ivseriem"
        Me.xlk_serial_number.UseCopyConnection = False
        Me.xlk_serial_number.UseRowRetrieveEvents = False
        Me.xlk_serial_number.UseTab = False
        Me.xlk_serial_number.VisParameters = New String() {"Factura=ftserial_no", "Serial=serie_number", "#/Compra=entr_number", "Fecha=entr_date", "Suplidor=prov_name"}
        Me.xlk_serial_number.WhereCondition = "ivseriem.ftserial_no is not null"
        Me.xlk_serial_number.WhereParameters = Nothing
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
        'LibXGrid2
        '
        Me.LibXGrid2.AllowSorting = False
        Me.LibXGrid2.AutoAdjustLastColumn = True
        Me.LibXGrid2.AutoSearch = False
        Me.LibXGrid2.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid2.CaptionText = "Series"
        Me.LibXGrid2.DataMember = "ftseriem"
        Me.LibXGrid2.DataSource = Me.DataSet1
        Me.LibXGrid2.FullRowSelect = False
        Me.LibXGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid2.IsReadOnly = False
        Me.LibXGrid2.Location = New System.Drawing.Point(8, 120)
        Me.LibXGrid2.Name = "LibXGrid2"
        Me.LibXGrid2.ReadOnly = True
        Me.LibXGrid2.searchText = ""
        Me.LibXGrid2.showFooterBar = False
        Me.LibXGrid2.Size = New System.Drawing.Size(672, 288)
        Me.LibXGrid2.TabIndex = 0
        Me.LibXGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle2})
        Me.LibXGrid2.UseAutoFillLines = False
        Me.LibXGrid2.UseHandCursor = False
        '
        'XdataGridTableStyle2
        '
        Me.XdataGridTableStyle2.AllowSorting = False
        Me.XdataGridTableStyle2.DataGrid = Me.LibXGrid2
        Me.XdataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColSerieNumber, Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn3})
        Me.XdataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle2.MappingName = "ftseriem"
        '
        'gColSerieNumber
        '
        Me.gColSerieNumber.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColSerieNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColSerieNumber.executeFindDuringFill = False
        Me.gColSerieNumber.Format = ""
        Me.gColSerieNumber.FormatInfo = Nothing
        Me.gColSerieNumber.HeaderText = "Serial Número"
        Me.gColSerieNumber.isReadOnly = False
        Me.gColSerieNumber.Lookup = Me.xlk_serial_number
        Me.gColSerieNumber.MappingName = "serie_number"
        Me.gColSerieNumber.MaxLength = 32767
        Me.gColSerieNumber.UseCustomCellFormat = False
        Me.gColSerieNumber.Width = 150
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Factura"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = True
        Me.XEditTextBoxColumn1.MappingName = "entr_number"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.ReadOnly = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 75
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Fecha"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = True
        Me.XEditTextBoxColumn2.MappingName = "entr_date"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.ReadOnly = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 75
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Suplidor"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = True
        Me.XEditTextBoxColumn3.MappingName = "prov_name"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.ReadOnly = True
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 150
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "ftserial_no"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "whse_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "cotiz_serial"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "term_code"
        Me.DataColumn4.MaxLength = 5
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "addr_code"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "vend_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "fact_number"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "fact_date"
        Me.DataColumn8.DataType = GetType(System.DateTime)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "fact_total"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "descto"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "itbis"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "total_comision"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "userid"
        Me.DataColumn13.MaxLength = 20
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "fact_status"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "date_created"
        Me.DataColumn15.DataType = GetType(System.DateTime)
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "type_code"
        Me.DataColumn16.MaxLength = 3
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "cust_code"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "fact_cond"
        Me.DataColumn18.DataType = GetType(System.Int16)
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "bus_name"
        Me.DataColumn19.MaxLength = 40
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "dev_type"
        Me.DataColumn20.MaxLength = 3
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "fact_nota"
        Me.DataColumn21.MaxLength = 80
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "ftserial_afect"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "pay_adelant"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "phone"
        Me.DataColumn24.MaxLength = 8
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "pay_mora"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "porc_comision"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "serie_number"
        Me.DataColumn27.MaxLength = 255
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.ColumnName = "item_code"
        Me.DataColumn28.MaxLength = 15
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "whse_code"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "prov_code"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "serie_status"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnMapping = System.Data.MappingType.Hidden
        Me.DataColumn32.ColumnName = "ftserial_no"
        Me.DataColumn32.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.AllowDBNull = False
        Me.DataColumn33.ColumnName = "entr_serial"
        Me.DataColumn33.DataType = GetType(System.Int32)
        '
        'DataColumn34
        '
        Me.DataColumn34.AllowDBNull = False
        Me.DataColumn34.ColumnName = "entr_number"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "prov_name"
        Me.DataColumn35.MaxLength = 60
        '
        'DataColumn71
        '
        Me.DataColumn71.AllowDBNull = False
        Me.DataColumn71.ColumnName = "entr_date"
        Me.DataColumn71.DataType = GetType(System.DateTime)
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(690, 24)
        Me.LibXNavigator1.TabIndex = 7
        '
        'i_ftserial02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 448)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.LibXGrid2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.xlk_serial_number)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "i_ftserial02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Series"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.AcceptedAction = LibX.LibxConnectionActions.Edit Then
                UpdateSeries()
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub i_ftserie01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            LibXGrid2.footerOperations.add("serie_number", "count(serie_number)")
            'xlk_serial_number.UseCopyConnection = True
            ftfactm.Columns("ftserial_no").AutoIncrement = False
            WhDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxWhDefault")

            If LibXConnector1.Parameters.Datos.Item("Modo") = "DEV" Then
                xlk_serial_number.WhereCondition = "ivseriem.ftserial_no is not null"
            End If

            If LibXConnector1.Parameters.Datos.Item("Modo") = "FCT" Then
                xlk_serial_number.WhereCondition = "ivseriem.ftserial_no is null"
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
            Me.Close()
        End Try

    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If MessageBox.Show("Seguro desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                LibXConnector1.Parameters.Datos.Add("Status", False)
                LibXConnector1.Cancel()
                Me.Close()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)

        End Try
    End Sub


    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        Try
            For Each oRow As DataRow In DataSet1.Tables("ftseriem").Rows
                If LibX.IsNull(oRow!line_no) = True Then
                    oRow!line_no = Val(DataSet1.Tables("ftseriem").Compute("count(line_no)", "").ToString.Trim) + 1
                End If
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub UpdateSeries()
        Dim XUpdate As LibX.Data.XUpdateStmt

        XUpdate = New LibX.Data.XUpdateStmt("ivseriem")
        XUpdate.FieldsSet("ftserial_no") = 0
        XUpdate.Fields("serie_number") = ""

        For Each oRow As DataRow In DataSet1.Tables("ftseriem").Rows
            XUpdate.FieldsSet("ftserial_no") = oRow!ftserial_no
            XUpdate.Fields("serie_number") = oRow!serie_number
            XUpdate.Execute()
        Next
    End Sub
End Class
