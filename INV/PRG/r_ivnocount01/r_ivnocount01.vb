Imports LibX
Public Class r_ivnocount01
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
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fecIni As LibX.LibxDateTimePicker
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents xtxtwhse_code As LibX.XTextBox
    Friend WithEvents lblwhse_name As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents xlk_prov_code As LibX.LibXLookup
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblprov_name As System.Windows.Forms.Label
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents XTextBox4 As LibX.XTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
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
    Friend WithEvents XTextBox7 As LibX.XTextBox
    Friend WithEvents XTextBox8 As LibX.XTextBox
    Friend WithEvents lblgroup_name As System.Windows.Forms.Label
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents chk_gen_hoja_conteo As System.Windows.Forms.CheckBox
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents wh_code As LibX.XTextBox
    Friend WithEvents ivcounte As System.Data.DataTable
    Friend WithEvents xdbivcounte As LibX.LibXDbSourceTable
    Friend WithEvents xdbivcountd As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents XTextBox5 As LibX.XTextBox
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents XTextBox6 As LibX.XTextBox
    Friend WithEvents XTextBox9 As LibX.XTextBox
    Friend WithEvents LibXLookup4 As LibX.LibXLookup
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents XTextBox10 As LibX.XTextBox
    Friend WithEvents XTextBox11 As LibX.XTextBox
    Friend WithEvents LibXLookup5 As LibX.LibXLookup
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents XTextBox12 As LibX.XTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Ssubgrupo As System.Windows.Forms.Label
    Friend WithEvents Smarca As System.Windows.Forms.Label
    Friend WithEvents Sproducto As System.Windows.Forms.Label
    Friend WithEvents Chk_mayor As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_menor As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_igual As System.Windows.Forms.CheckBox
    Friend WithEvents ivcountd As System.Data.DataTable
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
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
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
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.ivcounte = New System.Data.DataTable
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.ivcountd = New System.Data.DataTable
        Me.DataColumn33 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.xdbivcounte = New LibX.LibXDbSourceTable
        Me.xdbivcountd = New LibX.LibXDbSourceTable
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
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
        Me.DataColumn49 = New System.Data.DataColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.fecIni = New LibX.LibxDateTimePicker
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.xtxtwhse_code = New LibX.XTextBox
        Me.lblwhse_name = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.xlk_prov_code = New LibX.LibXLookup
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblprov_name = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblgroup_name = New System.Windows.Forms.Label
        Me.XTextBox4 = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.wh_code = New LibX.XTextBox
        Me.XTextBox7 = New LibX.XTextBox
        Me.XTextBox8 = New LibX.XTextBox
        Me.chk_gen_hoja_conteo = New System.Windows.Forms.CheckBox
        Me.XTextBox5 = New LibX.XTextBox
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.Label4 = New System.Windows.Forms.Label
        Me.Ssubgrupo = New System.Windows.Forms.Label
        Me.XTextBox6 = New LibX.XTextBox
        Me.XTextBox9 = New LibX.XTextBox
        Me.LibXLookup4 = New LibX.LibXLookup
        Me.Label9 = New System.Windows.Forms.Label
        Me.Smarca = New System.Windows.Forms.Label
        Me.XTextBox10 = New LibX.XTextBox
        Me.XTextBox11 = New LibX.XTextBox
        Me.LibXLookup5 = New LibX.LibXLookup
        Me.Label11 = New System.Windows.Forms.Label
        Me.Sproducto = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.XTextBox12 = New LibX.XTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Chk_mayor = New System.Windows.Forms.CheckBox
        Me.Chk_menor = New System.Windows.Forms.CheckBox
        Me.Chk_igual = New System.Windows.Forms.CheckBox
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivcounte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivcountd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.LibXConnector1.DataMember = "ivitemm"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.xdbivcounte, Me.xdbivcountd})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.ivcounte, Me.ivcountd})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"item_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "ivitemm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "item_code"
        Me.DataColumn1.MaxLength = 10
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "item_serie"
        Me.DataColumn2.MaxLength = 40
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "item_name"
        Me.DataColumn3.MaxLength = 100
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "abreviada"
        Me.DataColumn4.MaxLength = 40
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "unit_code"
        Me.DataColumn5.MaxLength = 4
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "prov_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "brand_code"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sgroup_code"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "group_code"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "purch_unit"
        Me.DataColumn10.MaxLength = 5
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "taxable"
        Me.DataColumn11.DataType = GetType(System.Int16)
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "item_status"
        Me.DataColumn12.MaxLength = 20
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "item_created"
        Me.DataColumn13.DataType = GetType(System.DateTime)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "item_serial"
        Me.DataColumn14.DataType = GetType(System.Int16)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "userid"
        Me.DataColumn15.MaxLength = 20
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "total_onhand"
        Me.DataColumn16.DataType = GetType(System.Int32)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "imprimir_etiq"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "asumir_emp"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "sugerir_compra"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "Referencia"
        Me.DataColumn20.MaxLength = 20
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "Aplicar_Vcmto"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "sustancias"
        Me.DataColumn22.MaxLength = 300
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "existencia"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.ColumnName = "purch_cost"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "whse_code"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "fecha_conteo"
        Me.DataColumn26.DataType = GetType(System.DateTime)
        '
        'DataColumn46
        '
        Me.DataColumn46.AllowDBNull = False
        Me.DataColumn46.ColumnName = "whse_code1"
        Me.DataColumn46.DataType = GetType(System.Int32)
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "loc_row"
        Me.DataColumn47.MaxLength = 20
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "loc_col"
        Me.DataColumn48.MaxLength = 20
        '
        'ivcounte
        '
        Me.ivcounte.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32})
        Me.ivcounte.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"count_number"}, True)})
        Me.ivcounte.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn27}
        Me.ivcounte.TableName = "ivcounte"
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.AutoIncrement = True
        Me.DataColumn27.ColumnName = "count_number"
        Me.DataColumn27.DataType = GetType(System.Int32)
        Me.DataColumn27.ReadOnly = True
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "prov_code"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "whse_code"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "count_date"
        Me.DataColumn30.DataType = GetType(System.DateTime)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "count_desc"
        Me.DataColumn31.MaxLength = 60
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "userid"
        Me.DataColumn32.MaxLength = 20
        '
        'ivcountd
        '
        Me.ivcountd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn49})
        Me.ivcountd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"count_number", "pageno", "line_no"}, True)})
        Me.ivcountd.Namespace = ""
        Me.ivcountd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn34, Me.DataColumn44, Me.DataColumn45}
        Me.ivcountd.TableName = "ivcountd"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "Column1"
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
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select ivitemm.item_code,", "       ivitemm.item_name,", "       ivitemm.unit_code,", "       ivitemd.existencia,", "       ivitemd.purch_cost,", "       ivitemd.whse_code,", "       ivitemd.whse_code,", "       ivitemd.loc_row,", "       ivitemd.loc_col,", "       ivitemd.fecha_conteo", "    from ivitemm inner join ivitemd on", "         ivitemd.item_code = ivitemm.item_code", "   where ivitemm.item_status =1", " order by ivitemm.item_name"}
        Me.LibXDbSourceTable1.TableName = "ivitemm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'xdbivcounte
        '
        Me.xdbivcounte.AllowDelete = True
        Me.xdbivcounte.AllowEdit = True
        Me.xdbivcounte.AllowNew = True
        Me.xdbivcounte.AutoIncrementSerial = False
        Me.xdbivcounte.CustomDbUpdate = False
        Me.xdbivcounte.DeleteOrder = 0
        Me.xdbivcounte.FillOnQuery = True
        Me.xdbivcounte.FillOnRowChange = False
        Me.xdbivcounte.HeaderIsOnGrid = False
        Me.xdbivcounte.InnerJon = True
        Me.xdbivcounte.InsertOrder = 0
        Me.xdbivcounte.IsDetail = False
        Me.xdbivcounte.KeyFields = Nothing
        Me.xdbivcounte.LineColName = Nothing
        Me.xdbivcounte.MasterDetailRelation = Nothing
        Me.xdbivcounte.MasterTableName = Nothing
        Me.xdbivcounte.SerialColumnName = Nothing
        Me.xdbivcounte.Sort = Nothing
        Me.xdbivcounte.Source = Nothing
        Me.xdbivcounte.TableName = "ivcounte"
        Me.xdbivcounte.UpdateOrder = 0
        Me.xdbivcounte.UseRowRetrieve = False
        '
        'xdbivcountd
        '
        Me.xdbivcountd.AllowDelete = True
        Me.xdbivcountd.AllowEdit = True
        Me.xdbivcountd.AllowNew = True
        Me.xdbivcountd.AutoIncrementSerial = False
        Me.xdbivcountd.CustomDbUpdate = False
        Me.xdbivcountd.DeleteOrder = 0
        Me.xdbivcountd.FillOnQuery = True
        Me.xdbivcountd.FillOnRowChange = False
        Me.xdbivcountd.HeaderIsOnGrid = False
        Me.xdbivcountd.InnerJon = True
        Me.xdbivcountd.InsertOrder = 0
        Me.xdbivcountd.IsDetail = False
        Me.xdbivcountd.KeyFields = Nothing
        Me.xdbivcountd.LineColName = Nothing
        Me.xdbivcountd.MasterDetailRelation = Nothing
        Me.xdbivcountd.MasterTableName = Nothing
        Me.xdbivcountd.SerialColumnName = Nothing
        Me.xdbivcountd.Sort = Nothing
        Me.xdbivcountd.Source = Nothing
        Me.xdbivcountd.TableName = "ivcountd"
        Me.xdbivcountd.UpdateOrder = 0
        Me.xdbivcountd.UseRowRetrieve = False
        '
        'DataColumn34
        '
        Me.DataColumn34.AllowDBNull = False
        Me.DataColumn34.ColumnName = "count_number"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "unit_code"
        Me.DataColumn35.MaxLength = 4
        '
        'DataColumn36
        '
        Me.DataColumn36.AllowDBNull = False
        Me.DataColumn36.ColumnName = "item_code"
        Me.DataColumn36.MaxLength = 10
        '
        'DataColumn37
        '
        Me.DataColumn37.AllowDBNull = False
        Me.DataColumn37.ColumnName = "whse_code"
        Me.DataColumn37.DataType = GetType(System.Int32)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "count_qty"
        Me.DataColumn38.DataType = GetType(System.Int32)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "loc_row"
        Me.DataColumn39.MaxLength = 20
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "loc_bin"
        Me.DataColumn40.MaxLength = 20
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "estante"
        Me.DataColumn41.MaxLength = 20
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "qty_on_hand"
        Me.DataColumn42.DataType = GetType(System.Int32)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "factor"
        Me.DataColumn43.DataType = GetType(System.Decimal)
        '
        'DataColumn44
        '
        Me.DataColumn44.AllowDBNull = False
        Me.DataColumn44.ColumnName = "pageno"
        Me.DataColumn44.DataType = GetType(System.Int32)
        '
        'DataColumn45
        '
        Me.DataColumn45.AllowDBNull = False
        Me.DataColumn45.ColumnName = "line_no"
        Me.DataColumn45.DataType = GetType(System.Int32)
        '
        'DataColumn49
        '
        Me.DataColumn49.AllowDBNull = False
        Me.DataColumn49.ColumnName = "count_status"
        Me.DataColumn49.DataType = GetType(System.Int32)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(-5, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha Conteo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fecIni
        '
        Me.fecIni.CustomFormat = "dd/MM/yyyy"
        Me.fecIni.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ivitemm.fecha_conteo"))
        Me.fecIni.EditInitialValue = Nothing
        Me.fecIni.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecIni.FieldDescription = ""
        Me.fecIni.FindInitialValue = "Now"
        Me.fecIni.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecIni.IgnoreRequiered = False
        Me.fecIni.Location = New System.Drawing.Point(80, 64)
        Me.fecIni.Name = "fecIni"
        Me.fecIni.NewInitialValue = Nothing
        Me.fecIni.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecIni.Requiered = False
        Me.fecIni.Size = New System.Drawing.Size(88, 20)
        Me.fecIni.StatusBarPanelDescripcion = Nothing
        Me.fecIni.TabIndex = 0
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
        Me.GroupBox1.Location = New System.Drawing.Point(460, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 120)
        Me.GroupBox1.TabIndex = 4
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
        Me.btnLimpiar.Location = New System.Drawing.Point(8, 48)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(72, 32)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEjecutar.Location = New System.Drawing.Point(8, 14)
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
        Me.Label5.Size = New System.Drawing.Size(554, 48)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "LISTADO DE PRODUCTOS NO INVENTARIADO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xtxtwhse_code
        '
        Me.xtxtwhse_code.AcceptsReturn = True
        Me.xtxtwhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.whse_code"))
        Me.xtxtwhse_code.EditInitialValue = Nothing
        Me.xtxtwhse_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtwhse_code.FieldDescription = ""
        Me.xtxtwhse_code.FindInitialValue = Nothing
        Me.xtxtwhse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtwhse_code.IgnoreRequiered = False
        Me.xtxtwhse_code.Location = New System.Drawing.Point(88, 88)
        Me.xtxtwhse_code.Name = "xtxtwhse_code"
        Me.xtxtwhse_code.NewInitialValue = Nothing
        Me.xtxtwhse_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtwhse_code.Requiered = False
        Me.xtxtwhse_code.Size = New System.Drawing.Size(48, 20)
        Me.xtxtwhse_code.StatusBarPanelDescripcion = Nothing
        Me.xtxtwhse_code.TabIndex = 16
        Me.xtxtwhse_code.Text = ""
        '
        'lblwhse_name
        '
        Me.lblwhse_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblwhse_name.Location = New System.Drawing.Point(144, 88)
        Me.lblwhse_name.Name = "lblwhse_name"
        Me.lblwhse_name.Size = New System.Drawing.Size(272, 20)
        Me.lblwhse_name.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(22, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Almacen:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"whse_code=whse_code", "lblwhse_name=whse_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(416, 88)
        Me.LibXLookup1.LookCaption = "Almacenes"
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup1.ShowFilter = True
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.ShowWarning = False
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SizesColumns = Nothing
        Me.LibXLookup1.SizesColumnsTab = Nothing
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"whse_code=whse_code"}
        Me.LibXLookup1.TabIndex = 19
        Me.LibXLookup1.TableName = "ivwhsem"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Almacen=whse_code", "Descripcion=whse_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'xlk_prov_code
        '
        Me.xlk_prov_code.AlternateFieldSearch = Nothing
        Me.xlk_prov_code.BeginCheck = False
        Me.xlk_prov_code.CheckText = Nothing
        Me.xlk_prov_code.ComboMode = False
        Me.xlk_prov_code.DataMember = Nothing
        Me.xlk_prov_code.DataSource = Me.LibXConnector1
        Me.xlk_prov_code.DestParameters = New String() {"prov_code=prov_code", "lblprov_name=prov_name"}
        Me.xlk_prov_code.FilterField = "prov_name"
        Me.xlk_prov_code.IgnoreFindInBrowseMode = False
        Me.xlk_prov_code.isCanceled = False
        Me.xlk_prov_code.Location = New System.Drawing.Point(416, 112)
        Me.xlk_prov_code.LookCaption = "Suplidores"
        Me.xlk_prov_code.Name = "xlk_prov_code"
        Me.xlk_prov_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_prov_code.ShowFilter = True
        Me.xlk_prov_code.ShowMessageNotFound = True
        Me.xlk_prov_code.ShowWarning = False
        Me.xlk_prov_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_prov_code.SizesColumns = Nothing
        Me.xlk_prov_code.SizesColumnsTab = Nothing
        Me.xlk_prov_code.SqlString = Nothing
        Me.xlk_prov_code.SQLTab = Nothing
        Me.xlk_prov_code.SrcParameters = New String() {"prov_code=prov_code"}
        Me.xlk_prov_code.TabIndex = 23
        Me.xlk_prov_code.TableName = "cpprovm"
        Me.xlk_prov_code.TabStop = False
        Me.xlk_prov_code.UseCopyConnection = False
        Me.xlk_prov_code.UseRowRetrieveEvents = False
        Me.xlk_prov_code.UseTab = False
        Me.xlk_prov_code.VisParameters = New String() {"Suplidor=prov_code", "Nombre=prov_name"}
        Me.xlk_prov_code.WhereCondition = Nothing
        Me.xlk_prov_code.WhereParameters = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(24, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Suplidor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblprov_name
        '
        Me.lblprov_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblprov_name.Location = New System.Drawing.Point(144, 112)
        Me.lblprov_name.Name = "lblprov_name"
        Me.lblprov_name.Size = New System.Drawing.Size(272, 20)
        Me.lblprov_name.TabIndex = 21
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(88, 112)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 20
        Me.XTextBox3.Text = ""
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"group_code=group_code", "lblgroup_name=group_name"}
        Me.LibXLookup2.FilterField = "group_name"
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(416, 136)
        Me.LibXLookup2.LookCaption = "Grupos"
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
        Me.LibXLookup2.SrcParameters = New String() {"group_code=group_code"}
        Me.LibXLookup2.TabIndex = 27
        Me.LibXLookup2.TableName = "ivgroupm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Grupor=group_code", "Nombre=group_name"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(24, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Grupo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblgroup_name
        '
        Me.lblgroup_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblgroup_name.Location = New System.Drawing.Point(144, 136)
        Me.lblgroup_name.Name = "lblgroup_name"
        Me.lblgroup_name.Size = New System.Drawing.Size(272, 20)
        Me.lblgroup_name.TabIndex = 25
        '
        'XTextBox4
        '
        Me.XTextBox4.AcceptsReturn = True
        Me.XTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.XTextBox4.EditInitialValue = Nothing
        Me.XTextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.FieldDescription = ""
        Me.XTextBox4.FindInitialValue = Nothing
        Me.XTextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.IgnoreRequiered = False
        Me.XTextBox4.Location = New System.Drawing.Point(88, 136)
        Me.XTextBox4.Name = "XTextBox4"
        Me.XTextBox4.NewInitialValue = Nothing
        Me.XTextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.Requiered = False
        Me.XTextBox4.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox4.StatusBarPanelDescripcion = Nothing
        Me.XTextBox4.TabIndex = 24
        Me.XTextBox4.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(24, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'wh_code
        '
        Me.wh_code.AcceptsReturn = True
        Me.wh_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.whse_code"))
        Me.wh_code.EditInitialValue = Nothing
        Me.wh_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.wh_code.FieldDescription = ""
        Me.wh_code.FindInitialValue = Nothing
        Me.wh_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.wh_code.IgnoreRequiered = False
        Me.wh_code.Location = New System.Drawing.Point(80, 88)
        Me.wh_code.Name = "wh_code"
        Me.wh_code.NewInitialValue = Nothing
        Me.wh_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.wh_code.Requiered = False
        Me.wh_code.Size = New System.Drawing.Size(56, 20)
        Me.wh_code.StatusBarPanelDescripcion = Nothing
        Me.wh_code.TabIndex = 32
        Me.wh_code.Text = ""
        '
        'XTextBox7
        '
        Me.XTextBox7.AcceptsReturn = True
        Me.XTextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.XTextBox7.EditInitialValue = Nothing
        Me.XTextBox7.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox7.FieldDescription = ""
        Me.XTextBox7.FindInitialValue = Nothing
        Me.XTextBox7.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox7.IgnoreRequiered = False
        Me.XTextBox7.Location = New System.Drawing.Point(80, 112)
        Me.XTextBox7.Name = "XTextBox7"
        Me.XTextBox7.NewInitialValue = Nothing
        Me.XTextBox7.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox7.Requiered = False
        Me.XTextBox7.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox7.StatusBarPanelDescripcion = Nothing
        Me.XTextBox7.TabIndex = 33
        Me.XTextBox7.Text = ""
        '
        'XTextBox8
        '
        Me.XTextBox8.AcceptsReturn = True
        Me.XTextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.group_code"))
        Me.XTextBox8.EditInitialValue = Nothing
        Me.XTextBox8.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox8.FieldDescription = ""
        Me.XTextBox8.FindInitialValue = Nothing
        Me.XTextBox8.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox8.IgnoreRequiered = False
        Me.XTextBox8.Location = New System.Drawing.Point(80, 136)
        Me.XTextBox8.Name = "XTextBox8"
        Me.XTextBox8.NewInitialValue = Nothing
        Me.XTextBox8.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox8.Requiered = False
        Me.XTextBox8.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox8.StatusBarPanelDescripcion = Nothing
        Me.XTextBox8.TabIndex = 34
        Me.XTextBox8.Text = ""
        '
        'chk_gen_hoja_conteo
        '
        Me.chk_gen_hoja_conteo.Location = New System.Drawing.Point(376, 264)
        Me.chk_gen_hoja_conteo.Name = "chk_gen_hoja_conteo"
        Me.chk_gen_hoja_conteo.Size = New System.Drawing.Size(152, 16)
        Me.chk_gen_hoja_conteo.TabIndex = 35
        Me.chk_gen_hoja_conteo.Text = "Generar Hoja de Conteo"
        '
        'XTextBox5
        '
        Me.XTextBox5.AcceptsReturn = True
        Me.XTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.sgroup_code"))
        Me.XTextBox5.EditInitialValue = Nothing
        Me.XTextBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.FieldDescription = ""
        Me.XTextBox5.FindInitialValue = Nothing
        Me.XTextBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.IgnoreRequiered = False
        Me.XTextBox5.Location = New System.Drawing.Point(80, 160)
        Me.XTextBox5.Name = "XTextBox5"
        Me.XTextBox5.NewInitialValue = Nothing
        Me.XTextBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.Requiered = False
        Me.XTextBox5.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox5.StatusBarPanelDescripcion = Nothing
        Me.XTextBox5.TabIndex = 40
        Me.XTextBox5.Text = ""
        '
        'LibXLookup3
        '
        Me.LibXLookup3.AlternateFieldSearch = Nothing
        Me.LibXLookup3.BeginCheck = False
        Me.LibXLookup3.CheckText = Nothing
        Me.LibXLookup3.ComboMode = False
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Me.LibXConnector1
        Me.LibXLookup3.DestParameters = New String() {"sgroup_code=sgroup_code", "Ssubgrupo=sgroup_name"}
        Me.LibXLookup3.FilterField = "sgroup_name"
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.isCanceled = False
        Me.LibXLookup3.Location = New System.Drawing.Point(416, 160)
        Me.LibXLookup3.LookCaption = "Sub Grupos"
        Me.LibXLookup3.Name = "LibXLookup3"
        Me.LibXLookup3.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup3.ShowFilter = True
        Me.LibXLookup3.ShowMessageNotFound = True
        Me.LibXLookup3.ShowWarning = False
        Me.LibXLookup3.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup3.SizesColumns = Nothing
        Me.LibXLookup3.SizesColumnsTab = Nothing
        Me.LibXLookup3.SqlString = Nothing
        Me.LibXLookup3.SQLTab = Nothing
        Me.LibXLookup3.SrcParameters = New String() {"sgroup_code=sgroup_code"}
        Me.LibXLookup3.TabIndex = 39
        Me.LibXLookup3.TableName = "ivsgroupm"
        Me.LibXLookup3.TabStop = False
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.UseTab = False
        Me.LibXLookup3.VisParameters = New String() {"SubGrupo=sgroup_code", "Nombre=sgroup_name"}
        Me.LibXLookup3.WhereCondition = Nothing
        Me.LibXLookup3.WhereParameters = Nothing
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(8, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "SubGrupo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Ssubgrupo
        '
        Me.Ssubgrupo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Ssubgrupo.Location = New System.Drawing.Point(144, 160)
        Me.Ssubgrupo.Name = "Ssubgrupo"
        Me.Ssubgrupo.Size = New System.Drawing.Size(272, 20)
        Me.Ssubgrupo.TabIndex = 37
        '
        'XTextBox6
        '
        Me.XTextBox6.AcceptsReturn = True
        Me.XTextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.XTextBox6.EditInitialValue = Nothing
        Me.XTextBox6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.FieldDescription = ""
        Me.XTextBox6.FindInitialValue = Nothing
        Me.XTextBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.IgnoreRequiered = False
        Me.XTextBox6.Location = New System.Drawing.Point(88, 160)
        Me.XTextBox6.Name = "XTextBox6"
        Me.XTextBox6.NewInitialValue = Nothing
        Me.XTextBox6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.Requiered = False
        Me.XTextBox6.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox6.StatusBarPanelDescripcion = Nothing
        Me.XTextBox6.TabIndex = 36
        Me.XTextBox6.Text = ""
        '
        'XTextBox9
        '
        Me.XTextBox9.AcceptsReturn = True
        Me.XTextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.brand_code"))
        Me.XTextBox9.EditInitialValue = Nothing
        Me.XTextBox9.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.FieldDescription = ""
        Me.XTextBox9.FindInitialValue = Nothing
        Me.XTextBox9.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.IgnoreRequiered = False
        Me.XTextBox9.Location = New System.Drawing.Point(80, 184)
        Me.XTextBox9.Name = "XTextBox9"
        Me.XTextBox9.NewInitialValue = Nothing
        Me.XTextBox9.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.Requiered = False
        Me.XTextBox9.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox9.StatusBarPanelDescripcion = Nothing
        Me.XTextBox9.TabIndex = 45
        Me.XTextBox9.Text = ""
        '
        'LibXLookup4
        '
        Me.LibXLookup4.AlternateFieldSearch = Nothing
        Me.LibXLookup4.BeginCheck = False
        Me.LibXLookup4.CheckText = Nothing
        Me.LibXLookup4.ComboMode = False
        Me.LibXLookup4.DataMember = Nothing
        Me.LibXLookup4.DataSource = Me.LibXConnector1
        Me.LibXLookup4.DestParameters = New String() {"brand_code=brand_code", "smarca=brand_name"}
        Me.LibXLookup4.FilterField = "brand_name"
        Me.LibXLookup4.IgnoreFindInBrowseMode = False
        Me.LibXLookup4.isCanceled = False
        Me.LibXLookup4.Location = New System.Drawing.Point(416, 184)
        Me.LibXLookup4.LookCaption = "Marcas"
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
        Me.LibXLookup4.SrcParameters = New String() {"brand_code=brand_code"}
        Me.LibXLookup4.TabIndex = 44
        Me.LibXLookup4.TableName = "ivbrandm"
        Me.LibXLookup4.TabStop = False
        Me.LibXLookup4.UseCopyConnection = False
        Me.LibXLookup4.UseRowRetrieveEvents = False
        Me.LibXLookup4.UseTab = False
        Me.LibXLookup4.VisParameters = New String() {"Codigo=brand_code", "Nombre=brand_name"}
        Me.LibXLookup4.WhereCondition = Nothing
        Me.LibXLookup4.WhereParameters = Nothing
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(24, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Marca:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Smarca
        '
        Me.Smarca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Smarca.Location = New System.Drawing.Point(144, 184)
        Me.Smarca.Name = "Smarca"
        Me.Smarca.Size = New System.Drawing.Size(272, 20)
        Me.Smarca.TabIndex = 42
        '
        'XTextBox10
        '
        Me.XTextBox10.AcceptsReturn = True
        Me.XTextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.XTextBox10.EditInitialValue = Nothing
        Me.XTextBox10.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox10.FieldDescription = ""
        Me.XTextBox10.FindInitialValue = Nothing
        Me.XTextBox10.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox10.IgnoreRequiered = False
        Me.XTextBox10.Location = New System.Drawing.Point(88, 184)
        Me.XTextBox10.Name = "XTextBox10"
        Me.XTextBox10.NewInitialValue = Nothing
        Me.XTextBox10.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox10.Requiered = False
        Me.XTextBox10.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox10.StatusBarPanelDescripcion = Nothing
        Me.XTextBox10.TabIndex = 41
        Me.XTextBox10.Text = ""
        '
        'XTextBox11
        '
        Me.XTextBox11.AcceptsReturn = True
        Me.XTextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.item_code"))
        Me.XTextBox11.EditInitialValue = Nothing
        Me.XTextBox11.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox11.FieldDescription = ""
        Me.XTextBox11.FindInitialValue = Nothing
        Me.XTextBox11.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox11.IgnoreRequiered = False
        Me.XTextBox11.Location = New System.Drawing.Point(80, 208)
        Me.XTextBox11.Name = "XTextBox11"
        Me.XTextBox11.NewInitialValue = Nothing
        Me.XTextBox11.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox11.Requiered = False
        Me.XTextBox11.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox11.StatusBarPanelDescripcion = Nothing
        Me.XTextBox11.TabIndex = 49
        Me.XTextBox11.Text = ""
        '
        'LibXLookup5
        '
        Me.LibXLookup5.AlternateFieldSearch = Nothing
        Me.LibXLookup5.BeginCheck = False
        Me.LibXLookup5.CheckText = Nothing
        Me.LibXLookup5.ComboMode = False
        Me.LibXLookup5.DataMember = Nothing
        Me.LibXLookup5.DataSource = Me.LibXConnector1
        Me.LibXLookup5.DestParameters = New String() {"item_code=item_code", "Sproducto=item_name"}
        Me.LibXLookup5.FilterField = "item_name"
        Me.LibXLookup5.IgnoreFindInBrowseMode = False
        Me.LibXLookup5.isCanceled = False
        Me.LibXLookup5.Location = New System.Drawing.Point(416, 208)
        Me.LibXLookup5.LookCaption = "Grupos"
        Me.LibXLookup5.Name = "LibXLookup5"
        Me.LibXLookup5.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup5.ShowFilter = True
        Me.LibXLookup5.ShowMessageNotFound = True
        Me.LibXLookup5.ShowWarning = False
        Me.LibXLookup5.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup5.SizesColumns = Nothing
        Me.LibXLookup5.SizesColumnsTab = Nothing
        Me.LibXLookup5.SqlString = Nothing
        Me.LibXLookup5.SQLTab = Nothing
        Me.LibXLookup5.SrcParameters = New String() {"item_code=item_code"}
        Me.LibXLookup5.TabIndex = 48
        Me.LibXLookup5.TableName = "ivitemm"
        Me.LibXLookup5.TabStop = False
        Me.LibXLookup5.UseCopyConnection = False
        Me.LibXLookup5.UseRowRetrieveEvents = False
        Me.LibXLookup5.UseTab = False
        Me.LibXLookup5.VisParameters = New String() {"COdigo=item_code", "Nombre=item_name"}
        Me.LibXLookup5.WhereCondition = Nothing
        Me.LibXLookup5.WhereParameters = Nothing
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Location = New System.Drawing.Point(16, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 16)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Producto:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Sproducto
        '
        Me.Sproducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Sproducto.Location = New System.Drawing.Point(144, 208)
        Me.Sproducto.Name = "Sproducto"
        Me.Sproducto.Size = New System.Drawing.Size(272, 20)
        Me.Sproducto.TabIndex = 46
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Location = New System.Drawing.Point(0, 232)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 16)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Descripción:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'XTextBox12
        '
        Me.XTextBox12.AcceptsReturn = True
        Me.XTextBox12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.item_name"))
        Me.XTextBox12.EditInitialValue = Nothing
        Me.XTextBox12.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.FieldDescription = ""
        Me.XTextBox12.FindInitialValue = Nothing
        Me.XTextBox12.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.IgnoreRequiered = False
        Me.XTextBox12.Location = New System.Drawing.Point(80, 232)
        Me.XTextBox12.Name = "XTextBox12"
        Me.XTextBox12.NewInitialValue = Nothing
        Me.XTextBox12.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.Requiered = False
        Me.XTextBox12.Size = New System.Drawing.Size(352, 20)
        Me.XTextBox12.StatusBarPanelDescripcion = Nothing
        Me.XTextBox12.TabIndex = 50
        Me.XTextBox12.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label14.Location = New System.Drawing.Point(8, 264)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 16)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Existencia:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chk_mayor
        '
        Me.Chk_mayor.Location = New System.Drawing.Point(80, 264)
        Me.Chk_mayor.Name = "Chk_mayor"
        Me.Chk_mayor.Size = New System.Drawing.Size(88, 16)
        Me.Chk_mayor.TabIndex = 53
        Me.Chk_mayor.Text = "Mayor Cero"
        '
        'Chk_menor
        '
        Me.Chk_menor.Location = New System.Drawing.Point(168, 264)
        Me.Chk_menor.Name = "Chk_menor"
        Me.Chk_menor.Size = New System.Drawing.Size(88, 16)
        Me.Chk_menor.TabIndex = 54
        Me.Chk_menor.Text = "Menor Cero"
        '
        'Chk_igual
        '
        Me.Chk_igual.Location = New System.Drawing.Point(264, 264)
        Me.Chk_igual.Name = "Chk_igual"
        Me.Chk_igual.Size = New System.Drawing.Size(88, 16)
        Me.Chk_igual.TabIndex = 55
        Me.Chk_igual.Text = "Igual Cero"
        '
        'r_ivnocount01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(554, 344)
        Me.Controls.Add(Me.Chk_igual)
        Me.Controls.Add(Me.Chk_menor)
        Me.Controls.Add(Me.Chk_mayor)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.XTextBox12)
        Me.Controls.Add(Me.XTextBox11)
        Me.Controls.Add(Me.LibXLookup5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Sproducto)
        Me.Controls.Add(Me.XTextBox9)
        Me.Controls.Add(Me.LibXLookup4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Smarca)
        Me.Controls.Add(Me.XTextBox10)
        Me.Controls.Add(Me.XTextBox5)
        Me.Controls.Add(Me.LibXLookup3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Ssubgrupo)
        Me.Controls.Add(Me.XTextBox6)
        Me.Controls.Add(Me.chk_gen_hoja_conteo)
        Me.Controls.Add(Me.XTextBox8)
        Me.Controls.Add(Me.XTextBox7)
        Me.Controls.Add(Me.wh_code)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LibXLookup2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblgroup_name)
        Me.Controls.Add(Me.XTextBox4)
        Me.Controls.Add(Me.xlk_prov_code)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblprov_name)
        Me.Controls.Add(Me.XTextBox3)
        Me.Controls.Add(Me.LibXLookup1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblwhse_name)
        Me.Controls.Add(Me.xtxtwhse_code)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fecIni)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "r_ivnocount01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Productos no Inventariado"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivcounte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivcountd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            Dim SelecStmt As String
            Dim sFechaDesde As String
            Dim sFechaHasta As String
            Dim sCond As String
            Dim sWhere As String
            Dim sWh As String
            Dim sProv As String
            Dim Sgroup As String
            Dim Ssgroup As String
            Dim Sitem As String
            Dim AxCrystalReport1 As LibX.ReportLib
            Dim xSelect As LibX.Data.XSelecStmt
            Dim xUpdate As LibX.Data.XUpdateStmt
            Dim oTable As DataTable
            Dim oDoc As SGT.Inventario.Entidades.Documento
            Dim ConteoNo, PaginaNo, LineNo As Integer
            Dim Serial As Integer
            Dim HojaTitulo As String


            e.DoFill = False

            If Not IsNull(e.row!fecha_conteo) Then
                sFechaDesde = CDate(e.row!fecha_conteo).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(e.row!whse_code) Then
                sWh = e.row!whse_code
            End If

            If Not IsNull(e.row!prov_code) Then
                sProv = e.row!prov_code
            End If

            If Not IsNull(e.row!group_code) Then
                Sgroup = e.row!group_code
            End If

            If Not IsNull(e.row!sgroup_code) Then
                Ssgroup = e.row!sgroup_code
            End If

            If Not IsNull(e.row!item_code) Then
                Sitem = e.row!item_code
            End If

            If e.Where Is Nothing Then
                e.Where = "1=1"
            Else
                e.Where = e.Where.Replace("ivitemm.whse_code", "ivitemd.whse_code")
            End If

            If chk_gen_hoja_conteo.Checked = True Then

                sWhere = " 1=1 "

                If Trim(sFechaDesde) <> "" Then
                    e.Where = String.Concat(e.Where, " and (ivitemd.fecha_conteo <  '", Trim(sFechaDesde), "'" & _
                    " or  ivitemd.fecha_conteo is null)")
                End If

                If Trim(sWh) <> "" Then
                    e.Where = String.Concat(sWhere, " and ivitemd.whse_code = ", Trim(sWh))
                End If

                If Trim(sProv) <> "" Then
                    e.Where = String.Concat(e.Where, " and ivitemm.prov_code = ", Trim(sProv))
                End If

                If Trim(Sgroup) <> "" Then
                    e.Where = String.Concat(e.Where, " and ivitemm.group_code = ", Trim(Sgroup))
                End If

                If Trim(Ssgroup) <> "" Then
                    e.Where = String.Concat(e.Where, " and ivitemm.sgroup_code = ", Trim(Ssgroup))
                End If

                If Trim(Sitem) <> "" Then
                    e.Where = String.Concat(e.Where, " and ivitemm.item_code = ", Trim(Sitem))
                End If

                If Chk_mayor.Checked = True And Chk_menor.Checked = False And Chk_igual.Checked = False Then
                    e.Sql = LibX.ConcatWherePart(e.Sql, "ivitemd.existencia > 0 ")
                End If
                If Chk_mayor.Checked = False And Chk_menor.Checked = True And Chk_igual.Checked = False Then
                    e.Sql = LibX.ConcatWherePart(e.Sql, "ivitemd.existencia < 0 ")
                End If
                If Chk_mayor.Checked = False And Chk_menor.Checked = False And Chk_igual.Checked = True Then
                    e.Sql = LibX.ConcatWherePart(e.Sql, "ivitemd.existencia = 0 ")
                End If
                If Chk_mayor.Checked = True And Chk_menor.Checked = True And Chk_igual.Checked = False Then
                    e.Sql = LibX.ConcatWherePart(e.Sql, "ivitemd.existencia <> 0 ")
                End If
                If Chk_mayor.Checked = True And Chk_menor.Checked = False And Chk_igual.Checked = True Then
                    e.Sql = LibX.ConcatWherePart(e.Sql, "ivitemd.existencia => 0 ")
                End If
                If Chk_mayor.Checked = False And Chk_menor.Checked = True And Chk_igual.Checked = True Then
                    e.Sql = LibX.ConcatWherePart(e.Sql, "ivitemd.existencia <= 0 ")
                End If

                e.Sql = LibX.ConcatWherePart(e.Sql, "(ivitemd.frizado_inv = 0 OR ivitemd.frizado_inv IS NULL)")


                xSelect = New LibX.Data.XSelecStmt("ivitemm", LibX.ConcatWherePart(e.Sql, e.Where))
                oTable = xSelect.GetTable(True)

                xSelect.Dispose()

                If oTable.Rows.Count <= 0 Then
                    Throw New ApplicationException("No existen registros con esa condición!")
                End If

                HojaTitulo = InputBox("Digite el Titulo de esta hoja de conteo", "Titulo de la Hoja", "INVENTARIO FISICO AL " & LibX.Data.Manager.Connection.GetDate.ToString("dd/MM/yyyy"))
                If HojaTitulo.Trim = "" Then
                    Throw New ApplicationException("Debe especificar el titulo de la hoja de conteo!")
                End If
                If LibX.Data.Manager.Connection.IsIntransaction = False Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                End If

                PaginaNo = 0
                LineNo = 66
                Dim oNewRow1 As DataRow

                oNewRow1 = ivcounte.NewRow

                If wh_code.Text.Trim <> "" Then
                    oNewRow1!whse_code = wh_code.Text
                End If

                oNewRow1!count_date = LibX.Data.Manager.Connection.GetDate
                oNewRow1!count_desc = HojaTitulo

                If Not IsNull(e.row!fecha_conteo) Then
                    sFechaDesde = CDate(e.row!fecha_conteo).ToString(LibX.Data.Manager.GetSaveDateFormat)
                End If

                ivcounte.Rows.Add(oNewRow1)

                LibX.Data.Manager.Save(ivcounte, "count_number")
                ConteoNo = LibX.Data.Manager.LastSerialValue

                xUpdate = New LibX.Data.XUpdateStmt("ivitemd")
                xUpdate.FieldsSet("frizado_inv") = 1 '// En conteo
                xUpdate.FieldsSet("fecha_frizado") = LibX.Data.Manager.Connection.GetDate  '// En conteo
                xUpdate.Fields("item_code") = "11"
                xUpdate.Fields("whse_code") = 0

                For Each oRow As DataRow In oTable.Rows
                    Dim oNewRow As DataRow = ivcountd.NewRow

                    If LineNo >= 33 Then
                        LineNo = 1
                        PaginaNo += 1
                    End If

                    oNewRow!count_number = ConteoNo
                    oNewRow!PageNo = PaginaNo
                    oNewRow!line_no = LineNo
                    oNewRow!item_code = oRow!item_code
                    oNewRow!unit_code = oRow!unit_code
                    oNewRow!whse_code = oRow!whse_code
                    oNewRow!loc_row = oRow!loc_row
                    oNewRow!loc_bin = oRow!loc_col
                    'oNewRow!estante = oRow!estante
                    oNewRow!qty_on_hand = oRow!existencia
                    oNewRow!count_status = Val(SGT.Inventario.Entidades.Documento.EstatusHojaConteoEnum.Generada) 'Generada

                    ivcountd.Rows.Add(oNewRow)

                    LineNo += 1

                    xUpdate.Fields("item_code") = oRow!item_code
                    xUpdate.Fields("whse_code") = oRow!whse_code
                    xUpdate.Execute()
                Next

                LibX.Data.Manager.Save(ivcountd)
                If LibX.Data.Manager.Connection.IsIntransaction = True Then
                    LibX.Data.Manager.Connection.CommitTransaction()
                End If

                MessageBox.Show("Generación Exitosa " & oTable.Rows.Count.ToString.Trim & " Producto(s)", "Generar hoja de conteo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else

                AxCrystalReport1 = New LibX.ReportLib("INV", "r_ivnocount01.rpt")

                With AxCrystalReport1
                    sWhere = " 1=1 "

                    sWhere = String.Concat(sWhere, " and (ivitemd.frizado_inv = 0 OR ivitemd.frizado_inv IS NULL)")

                    If Trim(sFechaDesde) <> "" Then
                        sWhere = String.Concat(sWhere, " and (ivitemd.fecha_conteo <  '", Trim(sFechaDesde), "'" & _
                        " or  ivitemd.fecha_conteo is null)")
                    End If

                    If Trim(sWh) <> "" Then
                        sWhere = String.Concat(sWhere, " and ivitemd.whse_code = ", Trim(sWh))
                    End If

                    If Trim(sProv) <> "" Then
                        sWhere = String.Concat(sWhere, " and ivitemm.prov_code = ", Trim(sProv))
                    End If

                    If Trim(Sgroup) <> "" Then
                        sWhere = String.Concat(sWhere, " and ivitemm.group_code = ", Trim(Sgroup))
                    End If

                    If Trim(Ssgroup) <> "" Then
                        e.Where = String.Concat(e.Where, " and ivitemm.sgroup_code = ", Trim(Ssgroup))
                    End If

                    If Trim(Sitem) <> "" Then
                        e.Where = String.Concat(e.Where, " and ivitemm.item_code = ", Trim(Sitem))
                    End If

                    If Chk_mayor.Checked = True And Chk_menor.Checked = False And Chk_igual.Checked = False Then
                        sWhere = String.Concat(sWhere, " and ivitemd.existencia > 0 ")
                    End If
                    If Chk_mayor.Checked = False And Chk_menor.Checked = True And Chk_igual.Checked = False Then
                        sWhere = String.Concat(sWhere, " and ivitemd.existencia < 0 ")
                    End If
                    If Chk_mayor.Checked = False And Chk_menor.Checked = False And Chk_igual.Checked = True Then
                        sWhere = String.Concat(sWhere, " and ivitemd.existencia = 0 ")
                    End If
                    If Chk_mayor.Checked = True And Chk_menor.Checked = True And Chk_igual.Checked = False Then
                        sWhere = String.Concat(sWhere, " and ivitemd.existencia <> 0 ")
                    End If
                    If Chk_mayor.Checked = True And Chk_menor.Checked = False And Chk_igual.Checked = True Then
                        sWhere = String.Concat(sWhere, " and ivitemd.existencia => 0 ")
                    End If
                    If Chk_mayor.Checked = False And Chk_menor.Checked = True And Chk_igual.Checked = True Then
                        sWhere = String.Concat(sWhere, " and ivitemd.existencia <= 0 ")
                    End If

                    '// Recibir el SQL Query
                    .RetrieveSQLQuery()
                    SelecStmt = .SQLQuery
                    SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                    .SQLQuery = SelecStmt

                    .Action = 1
                End With

            End If
        Catch ex As Exception
            Log.Show(ex)
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Me.LibXConnector1.AcceptFind()
        Me.LibXConnector1.Find()
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        If Me.LibXConnector1.IsEditing Then
            Me.LibXConnector1.Cancel()
        End If
        Me.LibXConnector1.Find()
    End Sub

    Private Sub r_ftfact10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LibXConnector1.Find()
    End Sub
End Class
