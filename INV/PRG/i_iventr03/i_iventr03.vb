Imports System.Configuration.ConfigurationSettings
Imports SGT.Inventario.Entidades
Public Class i_iventr03
    Inherits System.Windows.Forms.Form
    Dim mConfig As SGT.Inventario.Common.Configuration
    Dim mArticulo As SGT.Inventario.Entidades.Articulo
    Dim WhereStmt As String
    Dim WhDefault As Integer
    Dim WhDest As Integer
    Dim WhSuplidor As Integer
    Dim oPermission As SGT.Administracion.Entidades.Permission

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
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox17 As LibX.XTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox18 As LibX.XTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents iventrdd As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
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
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents price As System.Data.DataColumn
    Friend WithEvents whse_name As LibX.XTextBox
    Friend WithEvents prov_name As LibX.XTextBox
    Friend WithEvents lk_prov_code As LibX.LibXLookup
    Friend WithEvents lk_whse_code As LibX.LibXLookup
    Friend WithEvents txtEntr_Number As LibX.XTextBox
    Friend WithEvents txtwhse_code As LibX.XTextBox
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents xdt_item_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents xdt_Descr As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_Cantidad As LibX.XEditTextBoxColumn
    Friend WithEvents btnCostos As System.Windows.Forms.Button
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents lk_item_code As LibX.LibXLookup
    Friend WithEvents xdtp_entr_date As LibX.LibxDateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents xcbo_type_code As LibX.LibXCombo
    Friend WithEvents cbx_entr_status As LibX.LibXCombo
    Friend WithEvents txtprov_code As LibX.XTextBox
    Friend WithEvents txtcosto As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtpurch_unit_cost As System.Windows.Forms.TextBox
    Friend WithEvents txtcostrd As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents gColExistencia As LibX.XEditTextBoxColumn
    Friend WithEvents DataTable1 As System.Data.DataTable
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
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.iventrdd = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
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
        Me.price = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataTable1 = New System.Data.DataTable
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
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.DataColumn41 = New System.Data.DataColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbx_entr_status = New LibX.LibXCombo
        Me.xcbo_type_code = New LibX.LibXCombo
        Me.xdtp_entr_date = New LibX.LibxDateTimePicker
        Me.lk_prov_code = New LibX.LibXLookup
        Me.lk_whse_code = New LibX.LibXLookup
        Me.txtwhse_code = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtEntr_Number = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.whse_name = New LibX.XTextBox
        Me.txtprov_code = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.prov_name = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox17 = New LibX.XTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBox18 = New LibX.XTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.xdt_item_code = New LibX.XDataGridTextButtonColumn
        Me.lk_item_code = New LibX.LibXLookup
        Me.gColExistencia = New LibX.XEditTextBoxColumn
        Me.xdt_Descr = New LibX.XEditTextBoxColumn
        Me.xdt_Cantidad = New LibX.XEditTextBoxColumn
        Me.btnCostos = New System.Windows.Forms.Button
        Me.txtcosto = New System.Windows.Forms.TextBox
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.txtpurch_unit_cost = New System.Windows.Forms.TextBox
        Me.txtcostrd = New System.Windows.Forms.TextBox
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iventrdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(682, 24)
        Me.LibXNavigator1.TabIndex = 0
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
        Me.LibXConnector1.DataMember = "iventrdm"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.iventrdd, Me.DataTable1})
        '
        'iventrdd
        '
        Me.iventrdd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.price, Me.DataColumn33, Me.DataColumn32, Me.DataColumn34, Me.DataColumn36, Me.DataColumn38, Me.DataColumn39})
        Me.iventrdd.TableName = "iventrdd"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Importe"
        Me.DataColumn1.DataType = GetType(System.Decimal)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "entr_number"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.AutoIncrement = True
        Me.DataColumn23.AutoIncrementSeed = CType(1, Long)
        Me.DataColumn23.ColumnName = "line_no"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "whse_code"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "item_code"
        Me.DataColumn25.MaxLength = 15
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "unit_code"
        Me.DataColumn26.MaxLength = 5
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "qty"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.ColumnName = "costo"
        Me.DataColumn28.DataType = GetType(System.Decimal)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "dscto"
        Me.DataColumn29.DataType = GetType(System.Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "itbis"
        Me.DataColumn30.DataType = GetType(System.Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "impto"
        Me.DataColumn31.DataType = GetType(System.Decimal)
        '
        'price
        '
        Me.price.AllowDBNull = False
        Me.price.ColumnName = "price"
        Me.price.DataType = GetType(System.Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.AllowDBNull = False
        Me.DataColumn33.ColumnName = "item_name"
        Me.DataColumn33.MaxLength = 100
        '
        'DataColumn32
        '
        Me.DataColumn32.AllowDBNull = False
        Me.DataColumn32.ColumnName = "purch_unit_cost"
        Me.DataColumn32.DataType = GetType(System.Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "sales_price"
        Me.DataColumn34.DataType = GetType(System.Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "costrd"
        Me.DataColumn36.DataType = GetType(System.Decimal)
        '
        'DataColumn38
        '
        Me.DataColumn38.AllowDBNull = False
        Me.DataColumn38.ColumnName = "entr_serial"
        Me.DataColumn38.DataType = GetType(System.Int32)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "existencia"
        Me.DataColumn39.DataType = GetType(System.Int32)
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn35, Me.DataColumn37, Me.DataColumn40, Me.DataColumn41})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"entr_serial"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn3}
        Me.DataTable1.TableName = "iventrdm"
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "entr_number"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.AutoIncrement = True
        Me.DataColumn3.ColumnName = "entr_serial"
        Me.DataColumn3.DataType = GetType(System.Int32)
        Me.DataColumn3.ReadOnly = True
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "mon_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "type_code"
        Me.DataColumn5.MaxLength = 3
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "whse_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "prov_code"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "entr_date"
        Me.DataColumn8.DataType = GetType(System.DateTime)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "total_amount"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "fob_amount"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "gastos_gen"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "gastos_aduana"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "tasa"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "disc_amount"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "itbis_amount"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "aply_impto"
        Me.DataColumn16.DataType = GetType(System.Int16)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "impto_amount"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "aply_dscto"
        Me.DataColumn18.DataType = GetType(System.Int16)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "entr_status"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "aply_itbis"
        Me.DataColumn20.DataType = GetType(System.Int16)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "edit_price"
        Me.DataColumn21.DataType = GetType(System.Int16)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "date_created"
        Me.DataColumn35.DataType = GetType(System.DateTime)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "userid"
        Me.DataColumn37.MaxLength = 20
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "entr_cond"
        Me.DataColumn40.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.SerialColumnName = "entr_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select iventrdm.* from iventrdm ", "inner join ivtypem on iventrdm.type_code = ivtypem.type_code", "and ivtypem.type_local = 1"}
        Me.LibXDbSourceTable1.TableName = "iventrdm"
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
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"entr_serial=entr_serial", "whse_code=whse_code"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = ""
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select iventrdd.*,ivitemm.item_name,existencia", "from iventrdd inner join ivitemm ", "on iventrdd.item_code = ivitemm.item_code", "inner join ivitemd on iventrdd.whse_code = ivitemd.whse_code", "and iventrdd.item_code = ivitemd.item_code"}
        Me.LibXDbSourceTable2.TableName = "iventrdd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "apli_ofert"
        Me.DataColumn41.DataType = GetType(System.Int16)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbx_entr_status)
        Me.GroupBox1.Controls.Add(Me.xcbo_type_code)
        Me.GroupBox1.Controls.Add(Me.xdtp_entr_date)
        Me.GroupBox1.Controls.Add(Me.lk_prov_code)
        Me.GroupBox1.Controls.Add(Me.lk_whse_code)
        Me.GroupBox1.Controls.Add(Me.txtwhse_code)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtEntr_Number)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.whse_name)
        Me.GroupBox1.Controls.Add(Me.txtprov_code)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.prov_name)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBox17)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TextBox18)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 128)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cbx_entr_status
        '
        Me.cbx_entr_status.AllowDefaultSort = True
        Me.cbx_entr_status.bound = True
        Me.cbx_entr_status.currValue = Nothing
        Me.cbx_entr_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "iventrdm.entr_status"))
        Me.cbx_entr_status.DefaultWhereString = Nothing
        Me.cbx_entr_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_entr_status.EditInitialValue = Nothing
        Me.cbx_entr_status.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cbx_entr_status.FindInitialValue = Nothing
        Me.cbx_entr_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cbx_entr_status.IgnoreRequiered = False
        Me.cbx_entr_status.Items.AddRange(New Object() {"2-Solicitado", "3-Modificado", "1-Aplicado", "0-Anulado"})
        Me.cbx_entr_status.Location = New System.Drawing.Point(552, 48)
        Me.cbx_entr_status.LookupKeyDisplayFields = Nothing
        Me.cbx_entr_status.LookupKeyField = Nothing
        Me.cbx_entr_status.LookupTableName = Nothing
        Me.cbx_entr_status.Name = "cbx_entr_status"
        Me.cbx_entr_status.NewInitialValue = Nothing
        Me.cbx_entr_status.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.cbx_entr_status.Requiered = False
        Me.cbx_entr_status.Required = False
        Me.cbx_entr_status.Size = New System.Drawing.Size(96, 21)
        Me.cbx_entr_status.SqlString = Nothing
        Me.cbx_entr_status.TabIndex = 16
        '
        'xcbo_type_code
        '
        Me.xcbo_type_code.AllowDefaultSort = True
        Me.xcbo_type_code.bound = True
        Me.xcbo_type_code.currValue = Nothing
        Me.xcbo_type_code.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "iventrdm.type_code"))
        Me.xcbo_type_code.DefaultWhereString = Nothing
        Me.xcbo_type_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_type_code.EditInitialValue = Nothing
        Me.xcbo_type_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_type_code.FindInitialValue = Nothing
        Me.xcbo_type_code.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_type_code.IgnoreRequiered = False
        Me.xcbo_type_code.Location = New System.Drawing.Point(80, 24)
        Me.xcbo_type_code.LookupKeyDisplayFields = "type_name"
        Me.xcbo_type_code.LookupKeyField = "type_code"
        Me.xcbo_type_code.LookupTableName = "ivtypem"
        Me.xcbo_type_code.Name = "xcbo_type_code"
        Me.xcbo_type_code.NewInitialValue = Nothing
        Me.xcbo_type_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_type_code.Requiered = False
        Me.xcbo_type_code.Required = False
        Me.xcbo_type_code.Size = New System.Drawing.Size(408, 21)
        Me.xcbo_type_code.SqlString = Nothing
        Me.xcbo_type_code.TabIndex = 15
        '
        'xdtp_entr_date
        '
        Me.xdtp_entr_date.CustomFormat = "dd/MM/yyyy"
        Me.xdtp_entr_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "iventrdm.entr_date"))
        Me.xdtp_entr_date.EditInitialValue = Nothing
        Me.xdtp_entr_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_entr_date.FindInitialValue = Nothing
        Me.xdtp_entr_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_entr_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdtp_entr_date.IgnoreRequiered = False
        Me.xdtp_entr_date.Location = New System.Drawing.Point(552, 24)
        Me.xdtp_entr_date.Name = "xdtp_entr_date"
        Me.xdtp_entr_date.NewInitialValue = Nothing
        Me.xdtp_entr_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_entr_date.Requiered = False
        Me.xdtp_entr_date.Size = New System.Drawing.Size(96, 20)
        Me.xdtp_entr_date.TabIndex = 3
        '
        'lk_prov_code
        '
        Me.lk_prov_code.CheckText = Nothing
        Me.lk_prov_code.DataMember = Nothing
        Me.lk_prov_code.DataSource = Me.LibXConnector1
        Me.lk_prov_code.DestParameters = New String() {"prov_code=prov_code", "prov_name=prov_name"}
        Me.lk_prov_code.FilterField = Nothing
        Me.lk_prov_code.IgnoreFindInBrowseMode = False
        Me.lk_prov_code.Location = New System.Drawing.Point(472, 72)
        Me.lk_prov_code.LookCaption = "Suplidores"
        Me.lk_prov_code.Name = "lk_prov_code"
        Me.lk_prov_code.ShowMessageNotFound = True
        Me.lk_prov_code.ShowWarning = False
        Me.lk_prov_code.Size = New System.Drawing.Size(16, 20)
        Me.lk_prov_code.SizesColumns = Nothing
        Me.lk_prov_code.SizesColumnsTab = Nothing
        Me.lk_prov_code.SqlString = Nothing
        Me.lk_prov_code.SQLTab = Nothing
        Me.lk_prov_code.SrcParameters = New String() {"prov_code=prov_code"}
        Me.lk_prov_code.TabIndex = 14
        Me.lk_prov_code.TableName = "cpprovm"
        Me.lk_prov_code.UseCopyConnection = False
        Me.lk_prov_code.UseRowRetrieveEvents = False
        Me.lk_prov_code.UseTab = False
        Me.lk_prov_code.VisParameters = New String() {"Código=prov_code", "Nombre=prov_name", "Contacto=contact_name"}
        Me.lk_prov_code.WhereCondition = Nothing
        Me.lk_prov_code.WhereParameters = Nothing
        '
        'lk_whse_code
        '
        Me.lk_whse_code.CheckText = Nothing
        Me.lk_whse_code.DataMember = Nothing
        Me.lk_whse_code.DataSource = Me.LibXConnector1
        Me.lk_whse_code.DestParameters = New String() {"whse_code=whse_code", "whse_name=whse_name"}
        Me.lk_whse_code.FilterField = Nothing
        Me.lk_whse_code.IgnoreFindInBrowseMode = False
        Me.lk_whse_code.Location = New System.Drawing.Point(472, 96)
        Me.lk_whse_code.LookCaption = "Almacenes"
        Me.lk_whse_code.Name = "lk_whse_code"
        Me.lk_whse_code.ShowMessageNotFound = True
        Me.lk_whse_code.ShowWarning = False
        Me.lk_whse_code.Size = New System.Drawing.Size(16, 20)
        Me.lk_whse_code.SizesColumns = Nothing
        Me.lk_whse_code.SizesColumnsTab = Nothing
        Me.lk_whse_code.SqlString = Nothing
        Me.lk_whse_code.SQLTab = Nothing
        Me.lk_whse_code.SrcParameters = New String() {"whse_code=whse_code"}
        Me.lk_whse_code.TabIndex = 13
        Me.lk_whse_code.TableName = "ivwhsem"
        Me.lk_whse_code.UseCopyConnection = False
        Me.lk_whse_code.UseRowRetrieveEvents = False
        Me.lk_whse_code.UseTab = False
        Me.lk_whse_code.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.lk_whse_code.WhereCondition = Nothing
        Me.lk_whse_code.WhereParameters = Nothing
        '
        'txtwhse_code
        '
        Me.txtwhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.whse_code"))
        Me.txtwhse_code.EditInitialValue = Nothing
        Me.txtwhse_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtwhse_code.FindInitialValue = Nothing
        Me.txtwhse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtwhse_code.IgnoreRequiered = False
        Me.txtwhse_code.Location = New System.Drawing.Point(80, 96)
        Me.txtwhse_code.Name = "txtwhse_code"
        Me.txtwhse_code.NewInitialValue = Nothing
        Me.txtwhse_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtwhse_code.Requiered = False
        Me.txtwhse_code.Size = New System.Drawing.Size(56, 20)
        Me.txtwhse_code.TabIndex = 6
        Me.txtwhse_code.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(24, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Almacen"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtEntr_Number
        '
        Me.txtEntr_Number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.entr_number"))
        Me.txtEntr_Number.EditInitialValue = Nothing
        Me.txtEntr_Number.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtEntr_Number.FindInitialValue = Nothing
        Me.txtEntr_Number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtEntr_Number.IgnoreRequiered = False
        Me.txtEntr_Number.Location = New System.Drawing.Point(80, 48)
        Me.txtEntr_Number.Name = "txtEntr_Number"
        Me.txtEntr_Number.NewInitialValue = Nothing
        Me.txtEntr_Number.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtEntr_Number.Requiered = False
        Me.txtEntr_Number.TabIndex = 2
        Me.txtEntr_Number.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pedido No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'whse_name
        '
        Me.whse_name.EditInitialValue = Nothing
        Me.whse_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.FindInitialValue = Nothing
        Me.whse_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.IgnoreRequiered = False
        Me.whse_name.Location = New System.Drawing.Point(144, 96)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.NewInitialValue = Nothing
        Me.whse_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.ReadOnly = True
        Me.whse_name.Requiered = False
        Me.whse_name.Size = New System.Drawing.Size(328, 20)
        Me.whse_name.TabIndex = 10
        Me.whse_name.TabStop = False
        Me.whse_name.Text = ""
        '
        'txtprov_code
        '
        Me.txtprov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.prov_code"))
        Me.txtprov_code.EditInitialValue = Nothing
        Me.txtprov_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtprov_code.FindInitialValue = Nothing
        Me.txtprov_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtprov_code.IgnoreRequiered = False
        Me.txtprov_code.Location = New System.Drawing.Point(80, 72)
        Me.txtprov_code.Name = "txtprov_code"
        Me.txtprov_code.NewInitialValue = Nothing
        Me.txtprov_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtprov_code.Requiered = False
        Me.txtprov_code.Size = New System.Drawing.Size(56, 20)
        Me.txtprov_code.TabIndex = 5
        Me.txtprov_code.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(24, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Suplidor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'prov_name
        '
        Me.prov_name.EditInitialValue = Nothing
        Me.prov_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.FindInitialValue = Nothing
        Me.prov_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.IgnoreRequiered = False
        Me.prov_name.Location = New System.Drawing.Point(144, 72)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.NewInitialValue = Nothing
        Me.prov_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.ReadOnly = True
        Me.prov_name.Requiered = False
        Me.prov_name.Size = New System.Drawing.Size(328, 20)
        Me.prov_name.TabIndex = 10
        Me.prov_name.TabStop = False
        Me.prov_name.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(504, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Fecha:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(504, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Usuario:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.userid"))
        Me.TextBox17.EditInitialValue = Nothing
        Me.TextBox17.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox17.FindInitialValue = Nothing
        Me.TextBox17.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox17.IgnoreRequiered = False
        Me.TextBox17.Location = New System.Drawing.Point(552, 72)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.NewInitialValue = Nothing
        Me.TextBox17.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox17.ReadOnly = True
        Me.TextBox17.Requiered = False
        Me.TextBox17.Size = New System.Drawing.Size(96, 20)
        Me.TextBox17.TabIndex = 1
        Me.TextBox17.TabStop = False
        Me.TextBox17.Text = ""
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(504, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Creado:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox18
        '
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.date_created"))
        Me.TextBox18.EditInitialValue = Nothing
        Me.TextBox18.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox18.FindInitialValue = Nothing
        Me.TextBox18.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox18.IgnoreRequiered = False
        Me.TextBox18.Location = New System.Drawing.Point(552, 96)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.NewInitialValue = Nothing
        Me.TextBox18.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox18.ReadOnly = True
        Me.TextBox18.Requiered = False
        Me.TextBox18.Size = New System.Drawing.Size(96, 20)
        Me.TextBox18.TabIndex = 1
        Me.TextBox18.TabStop = False
        Me.TextBox18.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(504, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Estatus:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(40, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tipo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Articulos"
        Me.LibXGrid1.DataMember = "iventrdd"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(0, 168)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(664, 232)
        Me.LibXGrid1.TabIndex = 2
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.xdt_item_code, Me.gColExistencia, Me.xdt_Descr, Me.xdt_Cantidad})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "iventrdd"
        '
        'xdt_item_code
        '
        Me.xdt_item_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.xdt_item_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_item_code.executeFindDuringFill = False
        Me.xdt_item_code.Format = ""
        Me.xdt_item_code.FormatInfo = Nothing
        Me.xdt_item_code.HeaderText = "Articulo"
        Me.xdt_item_code.isReadOnly = False
        Me.xdt_item_code.Lookup = Me.lk_item_code
        Me.xdt_item_code.MappingName = "item_code"
        Me.xdt_item_code.MaxLength = 32767
        Me.xdt_item_code.UseCustomCellFormat = False
        Me.xdt_item_code.Width = 150
        '
        'lk_item_code
        '
        Me.lk_item_code.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lk_item_code.CheckText = Nothing
        Me.lk_item_code.DataMember = Nothing
        Me.lk_item_code.DataSource = Me.LibXConnector1
        Me.lk_item_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "costo=purch_cost", "whse_code=whse_code", "price=price", "purch_unit_cost=purch_cost", "existencia=existencia"}
        Me.lk_item_code.FilterField = "item_name"
        Me.lk_item_code.IgnoreFindInBrowseMode = False
        Me.lk_item_code.Location = New System.Drawing.Point(385, 222)
        Me.lk_item_code.LookCaption = "Productos"
        Me.lk_item_code.Name = "lk_item_code"
        Me.lk_item_code.ShowMessageNotFound = True
        Me.lk_item_code.ShowWarning = False
        Me.lk_item_code.Size = New System.Drawing.Size(16, 20)
        Me.lk_item_code.SizesColumns = Nothing
        Me.lk_item_code.SizesColumnsTab = Nothing
        Me.lk_item_code.SqlString = New String() {"select ivitemm.item_code,ivitemm.item_name,", "ivitemd.whse_code,ivitemm.purch_unit,", "ivitemd.purch_cost,ivitemd.price,ivitemd.existencia ", "from ivitemm inner join ivitemd", "on ivitemm.item_code=ivitemd.item_code"}
        Me.lk_item_code.SQLTab = New String() {"select ivwhsem.whse_name Almacen,item_name Producto,Existencia ", "from ivitemd inner join ivitemm on ivitemd.item_code = ivitemm.item_code", "inner join ivwhsem on ivwhsem.whse_code = ivitemd.whse_code"}
        Me.lk_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.lk_item_code.TabIndex = 9
        Me.lk_item_code.TableName = "ivitemm"
        Me.lk_item_code.UseCopyConnection = False
        Me.lk_item_code.UseRowRetrieveEvents = False
        Me.lk_item_code.UseTab = True
        Me.lk_item_code.VisParameters = New String() {"Código=item_code", "Descripción=item_name", "Almacén=whse_code", "Precio=price", "Existecia=existencia"}
        Me.lk_item_code.WhereCondition = Nothing
        Me.lk_item_code.WhereParameters = "ivitemd.item_code='?item_code'"
        '
        'gColExistencia
        '
        Me.gColExistencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColExistencia.Format = ""
        Me.gColExistencia.FormatInfo = Nothing
        Me.gColExistencia.ImageList = Nothing
        Me.gColExistencia.isReadOnly = False
        Me.gColExistencia.MappingName = "existencia"
        Me.gColExistencia.MaxLength = 32767
        Me.gColExistencia.ReadOnly = True
        Me.gColExistencia.UseCustomCellFormat = False
        Me.gColExistencia.Width = 0
        '
        'xdt_Descr
        '
        Me.xdt_Descr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Descr.Format = ""
        Me.xdt_Descr.FormatInfo = Nothing
        Me.xdt_Descr.HeaderText = "Descripción"
        Me.xdt_Descr.ImageList = Nothing
        Me.xdt_Descr.isReadOnly = False
        Me.xdt_Descr.MappingName = "item_name"
        Me.xdt_Descr.MaxLength = 32767
        Me.xdt_Descr.ReadOnly = True
        Me.xdt_Descr.UseCustomCellFormat = False
        Me.xdt_Descr.Width = 350
        '
        'xdt_Cantidad
        '
        Me.xdt_Cantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Cantidad.Format = "##,##0"
        Me.xdt_Cantidad.FormatInfo = Nothing
        Me.xdt_Cantidad.HeaderText = "Cantidad"
        Me.xdt_Cantidad.ImageList = Nothing
        Me.xdt_Cantidad.isReadOnly = False
        Me.xdt_Cantidad.MappingName = "qty"
        Me.xdt_Cantidad.MaxLength = 32767
        Me.xdt_Cantidad.UseCustomCellFormat = False
        Me.xdt_Cantidad.Width = 101
        '
        'btnCostos
        '
        Me.btnCostos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCostos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCostos.Location = New System.Drawing.Point(8, 432)
        Me.btnCostos.Name = "btnCostos"
        Me.btnCostos.TabIndex = 8
        Me.btnCostos.Text = "&Costos"
        '
        'txtcosto
        '
        Me.txtcosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdd.costo"))
        Me.txtcosto.Enabled = False
        Me.txtcosto.Location = New System.Drawing.Point(104, 360)
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.TabIndex = 10
        Me.txtcosto.TabStop = False
        Me.txtcosto.Text = "TextBox1"
        '
        'txtPrice
        '
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdd.price"))
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(216, 360)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.TabIndex = 10
        Me.txtPrice.TabStop = False
        Me.txtPrice.Text = "TextBox1"
        '
        'txtpurch_unit_cost
        '
        Me.txtpurch_unit_cost.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdd.purch_unit_cost"))
        Me.txtpurch_unit_cost.Enabled = False
        Me.txtpurch_unit_cost.Location = New System.Drawing.Point(328, 360)
        Me.txtpurch_unit_cost.Name = "txtpurch_unit_cost"
        Me.txtpurch_unit_cost.TabIndex = 10
        Me.txtpurch_unit_cost.TabStop = False
        Me.txtpurch_unit_cost.Text = "TextBox1"
        '
        'txtcostrd
        '
        Me.txtcostrd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdd.costrd"))
        Me.txtcostrd.Enabled = False
        Me.txtcostrd.Location = New System.Drawing.Point(440, 360)
        Me.txtcostrd.Name = "txtcostrd"
        Me.txtcostrd.TabIndex = 10
        Me.txtcostrd.TabStop = False
        Me.txtcostrd.Text = "TextBox1"
        '
        'i_iventr03
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(682, 480)
        Me.Controls.Add(Me.lk_item_code)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.btnCostos)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtpurch_unit_cost)
        Me.Controls.Add(Me.txtcostrd)
        Me.Controls.Add(Me.txtcosto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "i_iventr03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pedidos Internos"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iventrdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub total_amount_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        CalcularNeto()
    End Sub

    Private Sub CalcularRubros(ByVal iRow As Integer)
        Try
            If LibXConnector1.IsDataEditing Then
                If iRow >= iventrdd.Rows.Count Then
                    Exit Sub
                End If

                If LibX.IsNull(iventrdd.Rows(iRow)!qty) Then
                    Exit Sub
                End If

                If LibX.IsNull(iventrdd.Rows(iRow)!costo) Then
                    Exit Sub
                End If

                If LibX.IsNull(LibXConnector1.CurrentDataRow!total_amount) Then
                    Exit Sub
                End If

                If txtwhse_code.Text.Length <= 0 Then
                    Throw New ApplicationException("Debe especificar el almacén!")
                End If

                Dim oParam As New Articulo.ParametrosCostosLocales

                With oParam
                    .Producto = iventrdd.Rows(iRow)!item_code.ToString
                    .Almacen = CType(txtwhse_code.Text, Integer)
                    .TotalBruto = Val(LibXConnector1.CurrentDataRow!total_amount.ToString)

                    If LibXConnector1.CurrentDataRow!aply_dscto.ToString = "1" Then
                        .TotalDescto = Val(LibXConnector1.CurrentDataRow!disc_amount.ToString)
                    Else
                        If Not LibX.IsNull(iventrdd.Rows(iRow)!dscto) _
                        AndAlso iventrdd.Rows(iRow)!dscto > 0 Then
                            .Retorno.Descuento = Val(iventrdd.Rows(iRow)!dscto.ToString)
                        End If
                    End If

                    If LibXConnector1.CurrentDataRow!aply_impto.ToString = "1" Then
                        .TotalImpuesto = Val(LibXConnector1.CurrentDataRow!impto_amount.ToString)
                    Else
                        If Not LibX.IsNull(LibXConnector1.CurrentDataRow!impto_amount) _
                        AndAlso LibXConnector1.CurrentDataRow!impto_amount > 0 Then
                            .Retorno.Impuesto = Val(LibXConnector1.CurrentDataRow!impto_amount.ToString)
                        End If
                    End If

                    If LibXConnector1.CurrentDataRow!aply_itbis.ToString = "1" Then
                        .TotalItbis = Val(LibXConnector1.CurrentDataRow!itbis_amount.ToString)
                    Else
                        If Not LibX.IsNull(LibXConnector1.CurrentDataRow!itbis_amount) _
                        AndAlso LibXConnector1.CurrentDataRow!itbis_amount > 0 Then
                            .Retorno.Itbis = (LibXConnector1.CurrentDataRow!itbis_amount.ToString)
                        End If
                    End If

                    .Cantidad = Val(iventrdd.Rows(iRow)!qty.ToString)
                    .Costo = Val(iventrdd.Rows(iRow)!costo.ToString)

                End With

                '// Importe = Qty * price
                If mArticulo.CalcularCostoLocal(oParam) = True Then
                    'If lck_edit_price.Checked = False Then
                    '    iventrdd.Rows(iRow)!price = oParam.Retorno.Precio '/ mConfig.GetTasaUS
                    'End If

                    iventrdd.Rows(iRow)!sales_price = oParam.Retorno.Precio
                    iventrdd.Rows(iRow)!purch_unit_cost = oParam.Retorno.CostoCompra '/ mConfig.GetTasaUS
                    iventrdd.Rows(iRow)!dscto = oParam.Retorno.Descuento * oParam.Cantidad
                    iventrdd.Rows(iRow)!itbis = oParam.Retorno.Itbis * oParam.Cantidad
                    iventrdd.Rows(iRow)!impto = oParam.Retorno.Impuesto * oParam.Cantidad
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub
    Private Function CalcularNeto() As Boolean
        Dim TotalAmount As Decimal
        Dim DiscAmount As Decimal
        Dim TaxAmount As Decimal
        Dim ItbisAmount As Decimal
        Dim Amount As Decimal
        Try


            Return True
        Catch ex As Exception
            LibX.Log.Show(ex)
            Return False
        End Try

    End Function

    Private Sub disc_amount_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        CalcularNeto()
    End Sub

    Private Sub itbis_amount_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        CalcularNeto()
    End Sub

    Private Sub tax_amount_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        CalcularNeto()
    End Sub

    Private Sub txtEntr_Number_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEntr_Number.LostFocus
        Try
            If LibXConnector1.State = LibX.LibxConnectorState.Insert Then
                If txtEntr_Number.Text.Length > 0 Then
                    If LibX.Data.Manager.GetScalar("select count(*) from iventrdm where entr_number = " & txtEntr_Number.Text) > 0 Then
                        Throw New ApplicationException("Existe una factura con ese número, verifique!")
                    End If
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
            txtEntr_Number.Text = ""
        End Try
    End Sub

    Private Sub i_iventr02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mConfig = New SGT.Inventario.Common.Configuration
            iventrdd.Columns("Importe").Expression = "qty*costo"
            mArticulo = New SGT.Inventario.Entidades.Articulo

            DataSet1.Tables("iventrdm").Columns("entr_number").AllowDBNull = True
            '''LibXGrid1.footerOperations.add("Importe", "sum(Importe)")
            '''LibXGrid1.footerOperations.add("dscto", "sum(dscto)")
            '''LibXGrid1.footerOperations.add("itbis", "sum(itbis)")

            WhSuplidor = AppSettings.Get("LibxProvCode")
            WhDefault = AppSettings.Get("LibxWhDefault")
            WhDest = AppSettings.Get("LibXWhDestino")

            oPermission = New SGT.Administracion.Entidades.Permission


        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub lk_item_code_BeforeExecuteQuery(ByVal sender As System.Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lk_item_code.BeforeDBExecuteQuery
        If WhDest > 0 Then
            e.aditionalWhere = "whse_code = " & WhDest.ToString
        End If

    End Sub

    Private Sub LibXLookup1_BeforeExecuteQuery(ByVal sender As System.Object, ByVal e As LibX.BeforeExecuteQueryEventArgs)
        e.aditionalWhere = " doc_input = 1 and type_local = 1"

    End Sub

    Private Sub LibXConnector1_RowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange
        CalcularNeto()
    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Dim SelecStmt As String
        Dim AxCrystalReport1 As LibX.ReportLib
        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
                '// Tomar el Connection String del config
                AxCrystalReport1 = New LibX.ReportLib("INV", "i_iventrd03.rpt")
                WhereStmt = String.Concat("iventrdm.type_code = '", LibXConnector1.CurrentDataRow!type_code.ToString, "'", _
                                         " and iventrdm.entr_number = ", LibXConnector1.CurrentDataRow!entr_number.ToString)

                With AxCrystalReport1
                    '// Recibir el SQL Query
                    .RetrieveSQLQuery()
                    SelecStmt = .SQLQuery
                    SelecStmt = LibX.MdlUtil.ReplaceWherePart(SelecStmt, WhereStmt)
                    .SQLQuery = SelecStmt

                    '// Ejecutar el reporte
                    .Action = 1
                End With
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Try
                Dim ParamRunner As New LibX.LibxPrgParams
                ParamRunner.Value = LibXConnector1.CurrentDataRow!entr_serial
                LibX.App.CurrentPrgParams = ParamRunner
                LibX.LibXRunner.Run("i_ivserie01", "INV")

            Catch ex As Exception
                LibX.Log.Show(ex)

            End Try

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        btnCostos.Enabled = Not LibXConnector1.IsEditing And LibXConnector1.HasRecords = True
    End Sub

    Private Sub btnProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCostos.Click
        Try
            Dim param As New LibX.LibxPrgParams

            If oPermission.isAutorization(SGT.Administracion.Entidades.Permission.TipoAutorizacionEnum.VerCostos) = False Then
                Throw New ApplicationException("No tiene autorización!")
            End If

            param.Datos.Add("where", "item_code = '" & _
                            LibXGrid1.GetCurrentRowView!item_code & _
                            "' and whse_code = " & _
                            LibXGrid1.GetCurrentRowView!whse_code)

            With param
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowPrint = False
                .AllowQuery = False
            End With

            LibX.App.CurrentPrgParams = param
            LibX.LibXRunner.Run("i_ivitem02", "INV")
            LibXConnector1.ExecuteFind()

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub btnProductos_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim param As New LibX.LibxPrgParams
            param.Datos.Add("where", "item_code = '" & _
                            LibXGrid1.GetCurrentRowView!item_code & "'")

            With param
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowPrint = False
                .AllowQuery = False
            End With

            LibX.App.CurrentPrgParams = param
            LibX.LibXRunner.Run("i_ivitem01", "INV")
            LibXConnector1.ExecuteFind()

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                e.UpdatingArgs.Row!tasa = mConfig.GetTasaUS
                e.UpdatingArgs.Row!type_code = "PDI" ' COMPRA EN DOLARES
                For Each ORow As DataRow In DataSet1.Tables("iventrdd").Rows
                    e.UpdatingArgs.Row!total_amount = Val(e.UpdatingArgs.Row!total_amount.ToString.Trim) + _
                                                    Val(ORow!costo.ToString.Trim) * Val(ORow!qty.ToString.Trim)
                Next

                LibXConnector1.CurrentDataRow!total_amount = Val(e.UpdatingArgs.Row!total_amount.ToString.Trim)
                e.UpdatingArgs.Row!entr_cond = 2 'CREDITO
                e.UpdatingArgs.Row!entr_number = CrearFactura()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        WhereStmt = e.Where
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            LibX.LibXRunner.Run("i_ivbrand01", "INV")
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            LibX.LibXRunner.Run("i_ivgroup01", "INV")

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub


    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        xcbo_type_code.currValue = "PDI"
        cbx_entr_status.currValue = 2
        xdtp_entr_date.Value = LibX.Data.Manager.Connection.GetDate.ToShortDateString
        txtprov_code.Text = WhSuplidor.ToString
        txtwhse_code.Text = WhDefault.ToString
        lk_prov_code.ExecuteFind()
        lk_whse_code.ExecuteFind()
    End Sub

    Private Sub lk_item_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lk_item_code.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            txtPrice.Text = e.row!price
            txtcosto.Text = e.row!purch_cost
            txtpurch_unit_cost.Text = e.row!purch_cost
            txtcostrd.Text = Val(e.row!purch_cost.ToString.Trim) * mConfig.GetTasaUS
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Function CrearFactura() As Integer
        Dim XInsert As LibX.Data.XInsertStmt
        Dim xSelect As LibX.Data.XSelecStmt
        Dim oRowCustomer As DataRow
        Dim oDoc As SGT.Inventario.Entidades.Documento


        Dim CustCode As Integer
        Dim Serial As Integer
        Dim DocNumber As Integer
        Try
            oDoc = New SGT.Inventario.Entidades.Documento("FCT")
            xSelect = New LibX.Data.XSelecStmt("cccustm")
            XInsert = New LibX.Data.XInsertStmt("ftfactm", "ftserial_no")

            CustCode = AppSettings.Get("LibxCustCode")

            xSelect.Parameters.Add("cust_code", CustCode.ToString)

            oRowCustomer = xSelect.GetDataRow

            XInsert.Fields("whse_code") = WhDest
            XInsert.Fields("term_code") = oRowCustomer!term_code.ToString
            XInsert.Fields("vend_code") = LibX.User.VendedorID
            XInsert.Fields("fact_date") = LibXConnector1.CurrentDataRow!entr_date
            XInsert.Fields("fact_total") = LibXConnector1.CurrentDataRow!total_amount * mConfig.GetTasaUS
            XInsert.Fields("descto") = 0
            XInsert.Fields("itbis") = 0
            XInsert.Fields("fact_status") = 1 '// DESPEACHO
            XInsert.Fields("type_code") = "FCT"
            XInsert.Fields("cust_code") = CustCode
            XInsert.Fields("fact_cond") = 2 '// CREDITO
            XInsert.Fields("bus_name") = oRowCustomer!cust_name
            XInsert.Fields("fact_nota") = xcbo_type_code.Text

            DocNumber = oDoc.GenerateNumber("FCT", WhDest)
            XInsert.Fields("fact_number") = DocNumber

            Serial = XInsert.Execute

            XInsert = New LibX.Data.XInsertStmt("ftfactd")
            XInsert.Fields("ftserial_no") = Serial
            XInsert.Fields("line_no") = 0
            XInsert.Fields("whse_code") = WhDest
            XInsert.Fields("item_code") = 0
            XInsert.Fields("qty") = 0
            XInsert.Fields("price") = 0
            XInsert.Fields("costo") = 0
            XInsert.Fields("dscto") = 0
            XInsert.Fields("itbis") = 0

            For Each oRow As DataRow In iventrdd.Rows
                XInsert.Fields("line_no").value = oRow!line_no
                'XInsert.Fields("whse_code").value = WhDest
                XInsert.Fields("item_code").value = oRow!item_code
                XInsert.Fields("qty").value = oRow!qty
                XInsert.Fields("price").value = oRow!costo * mConfig.GetTasaUS
                XInsert.Fields("costo").value = oRow!costo * mConfig.GetTasaUS

                XInsert.Execute()
            Next

            Return DocNumber

        Catch ex As Exception
            Throw
        End Try
    End Function


    Private Sub lk_item_code_CreatedGridColumns(ByVal sender As Object, ByVal e As LibX.CreatedGridColumnsEventArgs) Handles lk_item_code.CreatedGridColumns
        Try
            e.TStyle.GridColumnStyles.Item("item_code").Width = 150
            e.TStyle.GridColumnStyles.Item("item_name").Width = 400

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub lk_item_code_BeforeExecuteQuery1(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lk_item_code.BeforeExecuteQuery
        If WhDest > 0 Then
            e.aditionalWhere = "whse_code = " & WhDest.ToString
        End If

    End Sub

    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
        Try
            If e.cell = LibXGrid1.GetColNum(xdt_Cantidad) Then
                If Val(e.value.ToString.Trim) > Val(LibXGrid1.GetValue(gColExistencia).ToString.Trim) Then
                    LibXGrid1.SetValue(e.row, xdt_Cantidad, gColExistencia.GetValue)
                    Throw New ApplicationException("Cantidad excede la existencia disponible en almacen!")
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try

            If e.Action = LibX.LibxConnectionActions.Edit _
            Or e.Action = LibX.LibxConnectionActions.Delete Then
                If LibXConnector1.CurrentDataRow!entr_status = 0 _
                Or LibXConnector1.CurrentDataRow!entr_status = 1 Then
                    Throw New ApplicationException("Este documento no puede ser alterado!")
                End If

            End If

        Catch ex As Exception
            e.Handled = True
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaulteditValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultEditValues) Handles LibXConnector1.SettingDefaulteditValues
        cbx_entr_status.currValue = 2
    End Sub
End Class
