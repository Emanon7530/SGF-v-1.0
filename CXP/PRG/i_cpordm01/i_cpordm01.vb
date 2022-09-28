Imports SGT.Inventario
Imports SGT.Inventario.Entidades
Imports LibX
Public Class i_cpordm01
    Inherits System.Windows.Forms.Form
    Dim oDocument As Documento
    Dim mResta As Decimal
    Dim Porc_mora As Decimal
    Dim WhDefault As Integer
    Dim mUnid As String
    Dim mAcction As LibxConnectionActions
    Dim Conf As SGT.Inventario.Common.Configuration
    Dim Transf As Boolean = False
    Dim mMoneda As Integer

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
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As LibX.XTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents xlk_cust_code As LibX.LibXLookup
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents xdtp_paym_date As LibX.LibxDateTimePicker
    Friend WithEvents xcbo_paym_status As LibX.LibXCombo
    Friend WithEvents txtAmount As LibX.XTextBox
    Friend WithEvents prov_name As LibX.XTextBox
    Friend WithEvents DSTcpordnm As LibX.LibXDbSourceTable
    Friend WithEvents DTScpordnd As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn4 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn6 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents xtxtwhse_name As LibX.XTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents cpordnd As System.Data.DataTable
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents xtxtwhse_code As LibX.XTextBox
    Friend WithEvents xlk_whse_code As LibX.LibXLookup
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents XTextBox4 As LibX.XTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents XEditTextBoxColumn5 As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_Qty As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_Costo As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents cpordnm As System.Data.DataTable
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents xdt_unit_code As LibX.XEditTextBoxColumn
    Friend WithEvents xtxt_ordn_number As LibX.XTextBox
    Friend WithEvents xtxt_prov_code As LibX.XTextBox
    Friend WithEvents btnSugeridos As System.Windows.Forms.Button
    Friend WithEvents xdt_item_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents lkl_item_code As LibX.LibXLookup
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents xtxsuccode As LibX.XTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents btnTransf As System.Windows.Forms.Button
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents btnSerie As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(i_cpordm01))
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.cpordnd = New System.Data.DataTable
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.cpordnm = New System.Data.DataTable
        Me.DataColumn2 = New System.Data.DataColumn
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
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DSTcpordnm = New LibX.LibXDbSourceTable
        Me.DTScpordnd = New LibX.LibXDbSourceTable
        Me.xtxt_prov_code = New LibX.XTextBox
        Me.xtxt_ordn_number = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnTransf = New System.Windows.Forms.Button
        Me.XTextBox1 = New LibX.XTextBox
        Me.xtxsuccode = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.XTextBox4 = New LibX.XTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.xlk_cust_code = New LibX.LibXLookup
        Me.xdtp_paym_date = New LibX.LibxDateTimePicker
        Me.xcbo_paym_status = New LibX.LibXCombo
        Me.prov_name = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAmount = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox7 = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.xtxtwhse_code = New LibX.XTextBox
        Me.xtxtwhse_name = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.xlk_whse_code = New LibX.LibXLookup
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.xdt_item_code = New LibX.XDataGridTextButtonColumn
        Me.lkl_item_code = New LibX.LibXLookup
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn4 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.xdt_Qty = New LibX.XEditTextBoxColumn
        Me.xdt_unit_code = New LibX.XEditTextBoxColumn
        Me.xdt_Costo = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn6 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn5 = New LibX.XEditTextBoxColumn
        Me.DataView1 = New System.Data.DataView
        Me.btnSugeridos = New System.Windows.Forms.Button
        Me.btnSerie = New System.Windows.Forms.Button
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpordnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpordnm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_prov_code
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_ordn_number
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_prov_code
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(890, 24)
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
        Me.LibXConnector1.DataMember = "cpordnm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = "CXP"
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = "r_cpordm01.rpt"
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.DSTcpordnm, Me.DTScpordnd})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.cpordnd, Me.cpordnm})
        '
        'cpordnd
        '
        Me.cpordnd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn1, Me.DataColumn3, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn30, Me.DataColumn31, Me.DataColumn33})
        Me.cpordnd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ordn_serial", "whse_code", "item_code"}, True)})
        Me.cpordnd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn20, Me.DataColumn21, Me.DataColumn22}
        Me.cpordnd.TableName = "cpordnd"
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "ordn_serial"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.AllowDBNull = False
        Me.DataColumn21.ColumnName = "whse_code"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "item_code"
        Me.DataColumn22.MaxLength = 10
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "Qty"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "price"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "item_name"
        Me.DataColumn25.MaxLength = 100
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Importe"
        Me.DataColumn1.DataType = GetType(System.Decimal)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "itbis"
        Me.DataColumn3.DataType = GetType(System.Decimal)
        Me.DataColumn3.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "promedio"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sugerida"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "diasventa"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "reorden"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "unit_code"
        Me.DataColumn27.MaxLength = 4
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "Existencia"
        Me.DataColumn28.DataType = GetType(System.Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "costo"
        Me.DataColumn30.DataType = GetType(System.Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "ref_code"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "suc_code"
        Me.DataColumn33.DataType = GetType(System.Int32)
        '
        'cpordnm
        '
        Me.cpordnm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn2, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn29, Me.DataColumn32, Me.DataColumn34})
        Me.cpordnm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ordn_serial"}, True)})
        Me.cpordnm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn2}
        Me.cpordnm.TableName = "cpordnm"
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.AutoIncrement = True
        Me.DataColumn2.ColumnName = "ordn_serial"
        Me.DataColumn2.DataType = GetType(System.Int32)
        Me.DataColumn2.ReadOnly = True
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "type_code"
        Me.DataColumn4.MaxLength = 3
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "prov_code"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ordn_date"
        Me.DataColumn6.DataType = GetType(System.DateTime)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "ordn_number"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "ordn_note"
        Me.DataColumn8.MaxLength = 60
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "ordn_status"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "total_amount"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "whse_code"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "total_itbis"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "maximo"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "minimo"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "reorden"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "periodo"
        Me.DataColumn16.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "no_cotizacion"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "suc_code"
        Me.DataColumn32.DataType = GetType(System.Int32)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "moneda"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'DSTcpordnm
        '
        Me.DSTcpordnm.AllowDelete = True
        Me.DSTcpordnm.AllowEdit = True
        Me.DSTcpordnm.AllowNew = True
        Me.DSTcpordnm.AutoIncrementSerial = False
        Me.DSTcpordnm.CustomDbUpdate = False
        Me.DSTcpordnm.DeleteOrder = 0
        Me.DSTcpordnm.FillOnQuery = True
        Me.DSTcpordnm.FillOnRowChange = False
        Me.DSTcpordnm.HeaderIsOnGrid = False
        Me.DSTcpordnm.InnerJon = True
        Me.DSTcpordnm.InsertOrder = 0
        Me.DSTcpordnm.IsDetail = False
        Me.DSTcpordnm.KeyFields = Nothing
        Me.DSTcpordnm.LineColName = Nothing
        Me.DSTcpordnm.MasterDetailRelation = Nothing
        Me.DSTcpordnm.MasterTableName = Nothing
        Me.DSTcpordnm.SerialColumnName = "ordn_serial"
        Me.DSTcpordnm.Sort = Nothing
        Me.DSTcpordnm.Source = Nothing
        Me.DSTcpordnm.TableName = "cpordnm"
        Me.DSTcpordnm.UpdateOrder = 0
        Me.DSTcpordnm.UseRowRetrieve = False
        '
        'DTScpordnd
        '
        Me.DTScpordnd.AllowDelete = True
        Me.DTScpordnd.AllowEdit = True
        Me.DTScpordnd.AllowNew = True
        Me.DTScpordnd.AutoIncrementSerial = False
        Me.DTScpordnd.CustomDbUpdate = False
        Me.DTScpordnd.DeleteOrder = 0
        Me.DTScpordnd.FillOnQuery = True
        Me.DTScpordnd.FillOnRowChange = True
        Me.DTScpordnd.HeaderIsOnGrid = False
        Me.DTScpordnd.InnerJon = True
        Me.DTScpordnd.InsertOrder = 0
        Me.DTScpordnd.IsDetail = True
        Me.DTScpordnd.KeyFields = Nothing
        Me.DTScpordnd.LineColName = Nothing
        Me.DTScpordnd.MasterDetailRelation = New String() {"ordn_serial=ordn_serial", "whse_code=whse_code"}
        Me.DTScpordnd.MasterTableName = Nothing
        Me.DTScpordnd.SerialColumnName = Nothing
        Me.DTScpordnd.Sort = Nothing
        Me.DTScpordnd.Source = New String() {"select cpordnd.*,ivitemm.item_name ", "from cpordnd inner join ivitemm", "on cpordnd.item_code = ivitemm.item_code order by item_name,promedio desc"}
        Me.DTScpordnd.TableName = "cpordnd"
        Me.DTScpordnd.UpdateOrder = 0
        Me.DTScpordnd.UseRowRetrieve = False
        '
        'xtxt_prov_code
        '
        Me.xtxt_prov_code.AcceptsReturn = True
        Me.xtxt_prov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpordnm.prov_code"))
        Me.xtxt_prov_code.EditInitialValue = Nothing
        Me.xtxt_prov_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_prov_code.FieldDescription = ""
        Me.xtxt_prov_code.FindInitialValue = Nothing
        Me.xtxt_prov_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_code.IgnoreRequiered = False
        Me.xtxt_prov_code.Location = New System.Drawing.Point(104, 40)
        Me.xtxt_prov_code.Name = "xtxt_prov_code"
        Me.xtxt_prov_code.NewInitialValue = Nothing
        Me.xtxt_prov_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_code.Requiered = False
        Me.xtxt_prov_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_prov_code.TabIndex = 3
        Me.xtxt_prov_code.Text = ""
        '
        'xtxt_ordn_number
        '
        Me.xtxt_ordn_number.AcceptsReturn = True
        Me.xtxt_ordn_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpordnm.ordn_number"))
        Me.xtxt_ordn_number.EditInitialValue = Nothing
        Me.xtxt_ordn_number.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_ordn_number.FieldDescription = ""
        Me.xtxt_ordn_number.FindInitialValue = Nothing
        Me.xtxt_ordn_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_ordn_number.IgnoreRequiered = True
        Me.xtxt_ordn_number.Location = New System.Drawing.Point(104, 16)
        Me.xtxt_ordn_number.Name = "xtxt_ordn_number"
        Me.xtxt_ordn_number.NewInitialValue = Nothing
        Me.xtxt_ordn_number.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_ordn_number.Requiered = False
        Me.xtxt_ordn_number.Size = New System.Drawing.Size(104, 20)
        Me.xtxt_ordn_number.StatusBarPanelDescripcion = Nothing
        Me.xtxt_ordn_number.TabIndex = 6
        Me.xtxt_ordn_number.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTransf)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.xtxsuccode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.XTextBox4)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.xtxt_ordn_number)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.xlk_cust_code)
        Me.GroupBox1.Controls.Add(Me.xdtp_paym_date)
        Me.GroupBox1.Controls.Add(Me.xcbo_paym_status)
        Me.GroupBox1.Controls.Add(Me.prov_name)
        Me.GroupBox1.Controls.Add(Me.xtxt_prov_code)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.xtxtwhse_code)
        Me.GroupBox1.Controls.Add(Me.xtxtwhse_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xlk_whse_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 176)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnTransf
        '
        Me.btnTransf.Image = CType(resources.GetObject("btnTransf.Image"), System.Drawing.Image)
        Me.btnTransf.Location = New System.Drawing.Point(8, 144)
        Me.btnTransf.Name = "btnTransf"
        Me.btnTransf.Size = New System.Drawing.Size(32, 23)
        Me.btnTransf.TabIndex = 46
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpordnm.suc_code"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(104, 88)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 17
        Me.XTextBox1.Text = ""
        Me.XTextBox1.Visible = False
        '
        'xtxsuccode
        '
        Me.xtxsuccode.AcceptsReturn = True
        Me.xtxsuccode.EditInitialValue = Nothing
        Me.xtxsuccode.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxsuccode.FieldDescription = ""
        Me.xtxsuccode.FindInitialValue = Nothing
        Me.xtxsuccode.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxsuccode.IgnoreRequiered = False
        Me.xtxsuccode.Location = New System.Drawing.Point(208, 88)
        Me.xtxsuccode.Name = "xtxsuccode"
        Me.xtxsuccode.NewInitialValue = Nothing
        Me.xtxsuccode.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxsuccode.ReadOnly = True
        Me.xtxsuccode.Requiered = False
        Me.xtxsuccode.Size = New System.Drawing.Size(344, 20)
        Me.xtxsuccode.StatusBarPanelDescripcion = Nothing
        Me.xtxsuccode.TabIndex = 16
        Me.xtxsuccode.TabStop = False
        Me.xtxsuccode.Text = ""
        Me.xtxsuccode.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(44, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Sucursal:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label1.Visible = False
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"suc_code=suc_code", "xtxsuccode=suc_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(552, 88)
        Me.LibXLookup1.LookCaption = "Sucursales"
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup1.ShowFilter = True
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.ShowWarning = False
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SizesColumns = Nothing
        Me.LibXLookup1.SizesColumnsTab = Nothing
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SQLTab = New String() {Nothing}
        Me.LibXLookup1.SrcParameters = New String() {"suc_code=suc_code"}
        Me.LibXLookup1.TabIndex = 18
        Me.LibXLookup1.TableName = "cgsucursal"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.Visible = False
        Me.LibXLookup1.VisParameters = New String() {"Código=suc_code", "Nombre=suc_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = ""
        '
        'XTextBox4
        '
        Me.XTextBox4.AcceptsReturn = True
        Me.XTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpordnm.periodo"))
        Me.XTextBox4.EditInitialValue = Nothing
        Me.XTextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox4.FieldDescription = ""
        Me.XTextBox4.FindInitialValue = Nothing
        Me.XTextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.IgnoreRequiered = True
        Me.XTextBox4.Location = New System.Drawing.Point(712, 16)
        Me.XTextBox4.Name = "XTextBox4"
        Me.XTextBox4.NewInitialValue = Nothing
        Me.XTextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox4.Requiered = False
        Me.XTextBox4.Size = New System.Drawing.Size(120, 20)
        Me.XTextBox4.StatusBarPanelDescripcion = Nothing
        Me.XTextBox4.TabIndex = 2
        Me.XTextBox4.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(624, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Periodo (Días):"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(47, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Número:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_cust_code
        '
        Me.xlk_cust_code.AlternateFieldSearch = Nothing
        Me.xlk_cust_code.BeginCheck = False
        Me.xlk_cust_code.CheckText = Nothing
        Me.xlk_cust_code.ComboMode = False
        Me.xlk_cust_code.DataMember = Nothing
        Me.xlk_cust_code.DataSource = Me.LibXConnector1
        Me.xlk_cust_code.DestParameters = New String() {"prov_code=prov_code", "prov_name=prov_name", "balance=balance"}
        Me.xlk_cust_code.FilterField = "prov_name"
        Me.xlk_cust_code.IgnoreFindInBrowseMode = False
        Me.xlk_cust_code.isCanceled = False
        Me.xlk_cust_code.Location = New System.Drawing.Point(552, 40)
        Me.xlk_cust_code.LookCaption = "Clientes"
        Me.xlk_cust_code.Name = "xlk_cust_code"
        Me.xlk_cust_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_cust_code.ShowFilter = True
        Me.xlk_cust_code.ShowMessageNotFound = True
        Me.xlk_cust_code.ShowWarning = False
        Me.xlk_cust_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_cust_code.SizesColumns = Nothing
        Me.xlk_cust_code.SizesColumnsTab = Nothing
        Me.xlk_cust_code.SqlString = Nothing
        Me.xlk_cust_code.SQLTab = New String() {"select type_code Tipo, doc_No Número,", "       cpinvcem.doc_date Fecha, cpinvcem.due_date Vencimiento, ", "       cpinvcem.amount Monto, itbis Itbis, cpopend.balance Balance", "from cpinvcem inner join cpopend", "on cpinvcem.invce_serial = cpopend.invce_serial", "and cpopend.balance <> 0"}
        Me.xlk_cust_code.SrcParameters = New String() {"prov_code=prov_code"}
        Me.xlk_cust_code.TabIndex = 5
        Me.xlk_cust_code.TableName = "cpprovm"
        Me.xlk_cust_code.TabStop = False
        Me.xlk_cust_code.UseCopyConnection = False
        Me.xlk_cust_code.UseRowRetrieveEvents = False
        Me.xlk_cust_code.UseTab = True
        Me.xlk_cust_code.VisParameters = New String() {"Código=prov_code", "Nombre=prov_name", "Límite Crédito=credit_limit", "Balance=balance"}
        Me.xlk_cust_code.WhereCondition = Nothing
        Me.xlk_cust_code.WhereParameters = "cpinvcem.prov_code = ?prov_code"
        '
        'xdtp_paym_date
        '
        Me.xdtp_paym_date.CustomFormat = "dd/MM/yyyy"
        Me.xdtp_paym_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cpordnm.ordn_date"))
        Me.xdtp_paym_date.EditInitialValue = Nothing
        Me.xdtp_paym_date.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdtp_paym_date.FieldDescription = ""
        Me.xdtp_paym_date.FindInitialValue = Nothing
        Me.xdtp_paym_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_paym_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdtp_paym_date.IgnoreRequiered = False
        Me.xdtp_paym_date.Location = New System.Drawing.Point(464, 16)
        Me.xdtp_paym_date.Name = "xdtp_paym_date"
        Me.xdtp_paym_date.NewInitialValue = "Now"
        Me.xdtp_paym_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_paym_date.Requiered = False
        Me.xdtp_paym_date.Size = New System.Drawing.Size(104, 20)
        Me.xdtp_paym_date.StatusBarPanelDescripcion = Nothing
        Me.xdtp_paym_date.TabIndex = 1
        '
        'xcbo_paym_status
        '
        Me.xcbo_paym_status.AllowDefaultSort = True
        Me.xcbo_paym_status.bound = True
        Me.xcbo_paym_status.currValue = Nothing
        Me.xcbo_paym_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cpordnm.ordn_status"))
        Me.xcbo_paym_status.DefaultWhereString = Nothing
        Me.xcbo_paym_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_paym_status.EditInitialValue = Nothing
        Me.xcbo_paym_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_paym_status.FieldDescription = ""
        Me.xcbo_paym_status.FindInitialValue = Nothing
        Me.xcbo_paym_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_paym_status.IgnoreRequiered = False
        Me.xcbo_paym_status.Items.AddRange(New Object() {"1-Generada", "2-Pendiente de aplicar", "3-Aplicada", "0-Anulado"})
        Me.xcbo_paym_status.Location = New System.Drawing.Point(712, 40)
        Me.xcbo_paym_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_paym_status.LookupKeyField = Nothing
        Me.xcbo_paym_status.LookupTableName = Nothing
        Me.xcbo_paym_status.Name = "xcbo_paym_status"
        Me.xcbo_paym_status.NewInitialValue = "2"
        Me.xcbo_paym_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_paym_status.Requiered = False
        Me.xcbo_paym_status.Required = False
        Me.xcbo_paym_status.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_paym_status.SqlString = Nothing
        Me.xcbo_paym_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_paym_status.TabIndex = 8
        '
        'prov_name
        '
        Me.prov_name.AcceptsReturn = True
        Me.prov_name.EditInitialValue = Nothing
        Me.prov_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.FieldDescription = ""
        Me.prov_name.FindInitialValue = Nothing
        Me.prov_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.IgnoreRequiered = False
        Me.prov_name.Location = New System.Drawing.Point(208, 40)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.NewInitialValue = Nothing
        Me.prov_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.ReadOnly = True
        Me.prov_name.Requiered = False
        Me.prov_name.Size = New System.Drawing.Size(344, 20)
        Me.prov_name.StatusBarPanelDescripcion = Nothing
        Me.prov_name.TabIndex = 2
        Me.prov_name.TabStop = False
        Me.prov_name.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(35, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Proveedor:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(416, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAmount
        '
        Me.txtAmount.AcceptsReturn = True
        Me.txtAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpordnm.total_amount"))
        Me.txtAmount.EditInitialValue = Nothing
        Me.txtAmount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAmount.FieldDescription = ""
        Me.txtAmount.FindInitialValue = Nothing
        Me.txtAmount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAmount.IgnoreRequiered = False
        Me.txtAmount.Location = New System.Drawing.Point(712, 64)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.NewInitialValue = Nothing
        Me.txtAmount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAmount.Requiered = False
        Me.txtAmount.Size = New System.Drawing.Size(120, 20)
        Me.txtAmount.StatusBarPanelDescripcion = Nothing
        Me.txtAmount.TabIndex = 9
        Me.txtAmount.Text = ""
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(656, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Monto:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(64, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nota:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox7
        '
        Me.TextBox7.AcceptsReturn = True
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpordnm.ordn_note"))
        Me.TextBox7.EditInitialValue = Nothing
        Me.TextBox7.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox7.FieldDescription = ""
        Me.TextBox7.FindInitialValue = Nothing
        Me.TextBox7.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox7.IgnoreRequiered = False
        Me.TextBox7.Location = New System.Drawing.Point(104, 112)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.NewInitialValue = Nothing
        Me.TextBox7.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox7.Requiered = False
        Me.TextBox7.Size = New System.Drawing.Size(728, 56)
        Me.TextBox7.StatusBarPanelDescripcion = Nothing
        Me.TextBox7.TabIndex = 5
        Me.TextBox7.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(656, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Estatus:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxtwhse_code
        '
        Me.xtxtwhse_code.AcceptsReturn = True
        Me.xtxtwhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpordnm.whse_code"))
        Me.xtxtwhse_code.EditInitialValue = Nothing
        Me.xtxtwhse_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxtwhse_code.FieldDescription = ""
        Me.xtxtwhse_code.FindInitialValue = Nothing
        Me.xtxtwhse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtwhse_code.IgnoreRequiered = False
        Me.xtxtwhse_code.Location = New System.Drawing.Point(104, 64)
        Me.xtxtwhse_code.Name = "xtxtwhse_code"
        Me.xtxtwhse_code.NewInitialValue = Nothing
        Me.xtxtwhse_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtwhse_code.Requiered = False
        Me.xtxtwhse_code.StatusBarPanelDescripcion = Nothing
        Me.xtxtwhse_code.TabIndex = 4
        Me.xtxtwhse_code.Text = ""
        '
        'xtxtwhse_name
        '
        Me.xtxtwhse_name.AcceptsReturn = True
        Me.xtxtwhse_name.EditInitialValue = Nothing
        Me.xtxtwhse_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtwhse_name.FieldDescription = ""
        Me.xtxtwhse_name.FindInitialValue = Nothing
        Me.xtxtwhse_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtwhse_name.IgnoreRequiered = False
        Me.xtxtwhse_name.Location = New System.Drawing.Point(208, 64)
        Me.xtxtwhse_name.Name = "xtxtwhse_name"
        Me.xtxtwhse_name.NewInitialValue = Nothing
        Me.xtxtwhse_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtwhse_name.ReadOnly = True
        Me.xtxtwhse_name.Requiered = False
        Me.xtxtwhse_name.Size = New System.Drawing.Size(344, 20)
        Me.xtxtwhse_name.StatusBarPanelDescripcion = Nothing
        Me.xtxtwhse_name.TabIndex = 2
        Me.xtxtwhse_name.TabStop = False
        Me.xtxtwhse_name.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(44, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Almacen:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_whse_code
        '
        Me.xlk_whse_code.AlternateFieldSearch = Nothing
        Me.xlk_whse_code.BeginCheck = False
        Me.xlk_whse_code.CheckText = Nothing
        Me.xlk_whse_code.ComboMode = False
        Me.xlk_whse_code.DataMember = Nothing
        Me.xlk_whse_code.DataSource = Me.LibXConnector1
        Me.xlk_whse_code.DestParameters = New String() {"whse_code=whse_code", "xtxtwhse_name=whse_name"}
        Me.xlk_whse_code.FilterField = Nothing
        Me.xlk_whse_code.IgnoreFindInBrowseMode = False
        Me.xlk_whse_code.isCanceled = False
        Me.xlk_whse_code.Location = New System.Drawing.Point(552, 64)
        Me.xlk_whse_code.LookCaption = "Almacenes"
        Me.xlk_whse_code.Name = "xlk_whse_code"
        Me.xlk_whse_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_whse_code.ShowFilter = True
        Me.xlk_whse_code.ShowMessageNotFound = True
        Me.xlk_whse_code.ShowWarning = False
        Me.xlk_whse_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_whse_code.SizesColumns = Nothing
        Me.xlk_whse_code.SizesColumnsTab = Nothing
        Me.xlk_whse_code.SqlString = Nothing
        Me.xlk_whse_code.SQLTab = New String() {Nothing}
        Me.xlk_whse_code.SrcParameters = New String() {"whse_code=whse_code"}
        Me.xlk_whse_code.TabIndex = 5
        Me.xlk_whse_code.TableName = "ivwhsem"
        Me.xlk_whse_code.TabStop = False
        Me.xlk_whse_code.UseCopyConnection = False
        Me.xlk_whse_code.UseRowRetrieveEvents = False
        Me.xlk_whse_code.UseTab = False
        Me.xlk_whse_code.VisParameters = New String() {"Código=whse_code", "Nombre=whse_name"}
        Me.xlk_whse_code.WhereCondition = Nothing
        Me.xlk_whse_code.WhereParameters = ""
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Productos"
        Me.LibXGrid1.DataMember = "cpordnd"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 216)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(864, 352)
        Me.LibXGrid1.TabIndex = 0
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.xdt_item_code, Me.DataGridTextBoxColumn1, Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn4, Me.XEditTextBoxColumn3, Me.xdt_Qty, Me.xdt_unit_code, Me.xdt_Costo, Me.XEditTextBoxColumn6, Me.XEditTextBoxColumn5})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cpordnd"
        '
        'xdt_item_code
        '
        Me.xdt_item_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.xdt_item_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_item_code.executeFindDuringFill = False
        Me.xdt_item_code.Format = ""
        Me.xdt_item_code.FormatInfo = Nothing
        Me.xdt_item_code.HeaderText = "Producto"
        Me.xdt_item_code.isReadOnly = False
        Me.xdt_item_code.Lookup = Me.lkl_item_code
        Me.xdt_item_code.MappingName = "item_code"
        Me.xdt_item_code.MaxLength = 32767
        Me.xdt_item_code.TabStop = True
        Me.xdt_item_code.UseCustomCellFormat = True
        Me.xdt_item_code.Width = 75
        '
        'lkl_item_code
        '
        Me.lkl_item_code.AlternateFieldSearch = Nothing
        Me.lkl_item_code.BeginCheck = False
        Me.lkl_item_code.CheckText = Nothing
        Me.lkl_item_code.ComboMode = False
        Me.lkl_item_code.DataMember = Nothing
        Me.lkl_item_code.DataSource = Me.LibXConnector1
        Me.lkl_item_code.DestParameters = New String() {"item_code=item_code", "barra=barra", "refer=refer", "item_name=item_name", "costo=purch_cost", "price=price", "unit_code=purch_unit", "existencia=existencia", "benef=benef", "diasventa=dia", "promedio=Prom_mens", "sugerida=sugerencia"}
        Me.lkl_item_code.Enabled = False
        Me.lkl_item_code.FilterField = "item_name"
        Me.lkl_item_code.IgnoreFindInBrowseMode = False
        Me.lkl_item_code.isCanceled = False
        Me.lkl_item_code.Location = New System.Drawing.Point(440, 320)
        Me.lkl_item_code.LookCaption = "Productos"
        Me.lkl_item_code.Name = "lkl_item_code"
        Me.lkl_item_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkl_item_code.ShowFilter = True
        Me.lkl_item_code.ShowLookup = False
        Me.lkl_item_code.ShowMessageNotFound = True
        Me.lkl_item_code.ShowWarning = False
        Me.lkl_item_code.Size = New System.Drawing.Size(16, 20)
        Me.lkl_item_code.SizesColumns = New String() {"item_name=350"}
        Me.lkl_item_code.SizesColumnsTab = Nothing
        Me.lkl_item_code.SqlString = New String() {"select  ivitemv1.item_code", ",ivcbarram.barra", ",ivreferm.refer" & Microsoft.VisualBasic.ChrW(9), ",ivitemv1.item_name", ",ivitemv1.whse_code", ",ivitemv1.purch_unit", ",ivitemv1.price", ",ivitemv1.purch_cost*factor purch_cost", ",ivitemv1.price price", ",ivitemv1.existencia", ",ivitemv1.benef ", ",ivitemv1.dia", ",vw_promedio.prom_mens", ",case when ivitemv1.existencia > vw_promedio.prom_mens then 0", "" & Microsoft.VisualBasic.ChrW(9) & "  when ivitemv1.existencia = vw_promedio.prom_mens then 0 ", "" & Microsoft.VisualBasic.ChrW(9) & "  when (vw_promedio.prom_mens - ivitemv1.existencia) > 0 then (vw_promedio.prom_" & _
        "mens - ivitemv1.existencia) ", "end sugerencia", "from ivitemv1 ", "left outer join ivunitd", "on ivunitd.unit_code = ivitemv1.purch_unit", "and ivunitd.item_code = ivitemv1.item_code", " LEFT OUTER JOIN ivcbarram", " ON ivcbarram.item_code = ivitemv1.item_code", "LEFT OUTER JOIN ivreferm", " ON ivreferm.item_code = ivitemv1.item_code", "LEFT OUTER JOIN vw_promedio", " ON  vw_promedio.item_code = ivitemv1.item_code"}
        Me.lkl_item_code.SQLTab = New String() {Nothing}
        Me.lkl_item_code.SrcParameters = New String() {"item_code=item_code", "item_code=barra", "item_code=refer"}
        Me.lkl_item_code.TabIndex = 15
        Me.lkl_item_code.TableName = "ivitemv1"
        Me.lkl_item_code.TabStop = False
        Me.lkl_item_code.UseCopyConnection = False
        Me.lkl_item_code.UseRowRetrieveEvents = False
        Me.lkl_item_code.UseTab = False
        Me.lkl_item_code.Visible = False
        Me.lkl_item_code.VisParameters = New String() {"Descripción=item_name", "Costo=purch_cost", "Unidad=purch_unit", "Precio=price", "Existecia=existencia", "Promedio=prom_mens", "Beneficio=benef", "Código=item_code", "Barra=barra", "Referencia=refer"}
        Me.lkl_item_code.WhereCondition = "item_status =1"
        Me.lkl_item_code.WhereParameters = ""
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Almacen"
        Me.DataGridTextBoxColumn1.MappingName = "whse_code"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Descripción"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = True
        Me.XEditTextBoxColumn1.MappingName = "item_name"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.ReadOnly = True
        Me.XEditTextBoxColumn1.TabStop = False
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 200
        '
        'XEditTextBoxColumn4
        '
        Me.XEditTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn4.Format = ""
        Me.XEditTextBoxColumn4.FormatInfo = Nothing
        Me.XEditTextBoxColumn4.HeaderText = "Existenciai"
        Me.XEditTextBoxColumn4.ImageList = Nothing
        Me.XEditTextBoxColumn4.isReadOnly = True
        Me.XEditTextBoxColumn4.MappingName = "Existencia"
        Me.XEditTextBoxColumn4.MaxLength = 32767
        Me.XEditTextBoxColumn4.ReadOnly = True
        Me.XEditTextBoxColumn4.TabStop = False
        Me.XEditTextBoxColumn4.UseCustomCellFormat = True
        Me.XEditTextBoxColumn4.Width = 90
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Sugerenciai"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = True
        Me.XEditTextBoxColumn3.MappingName = "sugerida"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.ReadOnly = True
        Me.XEditTextBoxColumn3.TabStop = False
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 75
        '
        'xdt_Qty
        '
        Me.xdt_Qty.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_Qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Qty.Format = ""
        Me.xdt_Qty.FormatInfo = Nothing
        Me.xdt_Qty.HeaderText = "Cantidadi"
        Me.xdt_Qty.ImageList = Nothing
        Me.xdt_Qty.isReadOnly = False
        Me.xdt_Qty.MappingName = "Qty"
        Me.xdt_Qty.MaxLength = 32767
        Me.xdt_Qty.TabStop = True
        Me.xdt_Qty.UseCustomCellFormat = False
        Me.xdt_Qty.Width = 75
        '
        'xdt_unit_code
        '
        Me.xdt_unit_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_unit_code.Format = ""
        Me.xdt_unit_code.FormatInfo = Nothing
        Me.xdt_unit_code.HeaderText = "Unidad"
        Me.xdt_unit_code.ImageList = Nothing
        Me.xdt_unit_code.isReadOnly = True
        Me.xdt_unit_code.MappingName = "unit_code"
        Me.xdt_unit_code.MaxLength = 32767
        Me.xdt_unit_code.ReadOnly = True
        Me.xdt_unit_code.TabStop = False
        Me.xdt_unit_code.UseCustomCellFormat = False
        Me.xdt_unit_code.Width = 75
        '
        'xdt_Costo
        '
        Me.xdt_Costo.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_Costo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_Costo.Format = "##,###,##0.0000"
        Me.xdt_Costo.FormatInfo = Nothing
        Me.xdt_Costo.HeaderText = "Costoi"
        Me.xdt_Costo.ImageList = Nothing
        Me.xdt_Costo.isReadOnly = True
        Me.xdt_Costo.MappingName = "costo"
        Me.xdt_Costo.MaxLength = 32767
        Me.xdt_Costo.ReadOnly = True
        Me.xdt_Costo.TabStop = False
        Me.xdt_Costo.UseCustomCellFormat = False
        Me.xdt_Costo.Width = 75
        '
        'XEditTextBoxColumn6
        '
        Me.XEditTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn6.Format = ""
        Me.XEditTextBoxColumn6.FormatInfo = Nothing
        Me.XEditTextBoxColumn6.HeaderText = "Ult. dias Ventai"
        Me.XEditTextBoxColumn6.ImageList = Nothing
        Me.XEditTextBoxColumn6.isReadOnly = True
        Me.XEditTextBoxColumn6.MappingName = "diasventa"
        Me.XEditTextBoxColumn6.MaxLength = 32767
        Me.XEditTextBoxColumn6.ReadOnly = True
        Me.XEditTextBoxColumn6.TabStop = False
        Me.XEditTextBoxColumn6.UseCustomCellFormat = False
        Me.XEditTextBoxColumn6.Width = 80
        '
        'XEditTextBoxColumn5
        '
        Me.XEditTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn5.Format = ""
        Me.XEditTextBoxColumn5.FormatInfo = Nothing
        Me.XEditTextBoxColumn5.HeaderText = "Prom. Ventai"
        Me.XEditTextBoxColumn5.ImageList = Nothing
        Me.XEditTextBoxColumn5.isReadOnly = True
        Me.XEditTextBoxColumn5.MappingName = "promedio"
        Me.XEditTextBoxColumn5.MaxLength = 32767
        Me.XEditTextBoxColumn5.ReadOnly = True
        Me.XEditTextBoxColumn5.TabStop = False
        Me.XEditTextBoxColumn5.UseCustomCellFormat = False
        Me.XEditTextBoxColumn5.Width = 80
        '
        'DataView1
        '
        Me.DataView1.AllowNew = False
        Me.DataView1.Table = Me.cpordnd
        '
        'btnSugeridos
        '
        Me.btnSugeridos.Enabled = False
        Me.btnSugeridos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSugeridos.Location = New System.Drawing.Point(8, 601)
        Me.btnSugeridos.Name = "btnSugeridos"
        Me.btnSugeridos.Size = New System.Drawing.Size(80, 40)
        Me.btnSugeridos.TabIndex = 2
        Me.btnSugeridos.Text = "Ordenar Sugeridos"
        Me.btnSugeridos.Visible = False
        '
        'btnSerie
        '
        Me.btnSerie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSerie.Location = New System.Drawing.Point(120, 600)
        Me.btnSerie.Name = "btnSerie"
        Me.btnSerie.TabIndex = 16
        Me.btnSerie.Text = "Detalle"
        '
        'i_cpordm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(890, 656)
        Me.Controls.Add(Me.btnSerie)
        Me.Controls.Add(Me.btnSugeridos)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.lkl_item_code)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_cpordm01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Editar Orden de Compras"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpordnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpordnm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try
            Me.xcbo_paym_status.currValue = 1
            xtxtwhse_code.Text = WhDefault
            xlk_whse_code.ExecuteFind()

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub xlk_cust_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_cust_code.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Dim XUpdate As LibX.Data.XUpdateStmt
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert _
                Or e.UpdatingArgs.StatementType = StatementType.Update Then
                '// Datos
                e.UpdatingArgs.Row!type_code = "ORD"
                e.UpdatingArgs.Row!ordn_number = oDocument.GenerateNumber("ORD", WhDefault)
                e.UpdatingArgs.Row!moneda = mMoneda
                e.UpdatingArgs.Row!suc_code = 1

                e.UpdatingArgs.Row!ordn_status = 2
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
        End Try
    End Sub

    Private Sub i_ccpaym01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            oDocument = New Documento("ORD")

            LibXGrid1.footerOperations.add("itbis", "sum(itbis)")
            LibXGrid1.footerOperations.add("importe", "sum(importe)")
            cpordnd.Columns("Importe").Expression = "(price*qty)+itbis"

            WhDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibXWhDefault")
            Conf = New SGT.Inventario.Common.Configuration
            Transf = CType(System.Configuration.ConfigurationSettings.AppSettings.Get("LibxTransf"), Boolean)
            Me.btnTransf.Visible = Transf
            Me.btnTransf.Enabled = Transf
            mAcction = New LibxConnectionActions

            '// No agregar
            LibXGrid1.getCurrentGridView.AllowNew = True

            '// No agregar
            LibXGrid1.getCurrentGridView.AllowNew = True

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        e.AditionalWhere = "cpordnm.type_code='ORD' "
    End Sub

    Private Sub xlk_cust_code_CreatedGridColumns(ByVal sender As Object, ByVal e As LibX.CreatedGridColumnsEventArgs) Handles xlk_cust_code.CreatedGridColumns
        Try
            e.TStyle.GridColumnStyles.Item("prov_name").Width = 500
            e.TStyle.GridColumnStyles.Item("credit_limit").Width = 150
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub ActualizaTotal()
        Try
            Dim i As Integer
            Dim oCant As Integer
            Dim oValue As Object
            Dim costo As Decimal
            Dim total As Decimal = 0

            For i = 0 To Me.LibXGrid1.getCurrentGridView.Count - 1
                oCant = 0
                costo = 0

                oValue = Me.LibXGrid1.GetValue(i, Me.xdt_Qty)
                If Not IsNull(oValue) Then
                    oCant = oValue
                End If

                oValue = Me.LibXGrid1.GetValue(i, Me.xdt_Costo)
                If Not IsNull(oValue) Then
                    costo = oValue
                End If
                total += oCant * costo
            Next

            Me.txtAmount.Text = CDec(total).ToString("###,###,##0.00")

        Catch ex As Exception
            Log.Add(ex, True)

        End Try
    End Sub
    Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
        Dim oValidarPrecio As Articulo.ParametrosPrecioValido
        Dim Descuento As Decimal
        Dim Monto As Decimal
        Try
            '''If Me.LibXGrid1.GetColNum(Me.xdt_Price) = e.cell Then
            '''    Exit Sub
            '''End If

            ''If Me.total_amount.Text.Length <= 0 Then
            ''    e.hasErrors = True
            ''    LibXGrid1.SetValue(e.row, Me.xdt_item_code, "")
            ''    Throw New ApplicationException("Debe digitar el Monto de la factura antes de digitar los productos!")
            ''End If

            ''''// Validar cantidad
            '''If Me.xdt_item_code.Column = e.cell Then
            '''    If e.value.ToString.Trim = "" Then
            '''        e.hasErrors = True
            '''        Exit Sub
            '''    End If
            '''End If

            '// Validar cantidad
            If Me.xdt_Qty.Column = e.cell Then
                If LibXGrid1.GetValue(e.row, Me.xdt_item_code).ToString.Trim = "" Then
                    LibXGrid1.Focus(e.row, 0)
                    Exit Sub
                End If

                If Val(e.value.ToString.Trim) <= 0 Then
                    e.hasErrors = True
                    Exit Sub
                End If

                'mPrevPrice = Me.LibXGrid1.GetValue(e.row, Me.xdt_Price)
            End If
            If e.cell = Me.xdt_unit_code.Column Then
                'If LibXGrid1.GetValue(e.row, xdt_Cantidad) = "" Then
                If LibX.IsNull(e.value) Then
                    LibXGrid1.Focus(e.row, e.cell)
                    Exit Sub
                End If
            End If

            'If LibX.IsNull(e.value) Then
            '    e.hasErrors = True
            '    Exit Sub
            'End If

            '// Validar costo
            If Me.LibXGrid1.GetColNum(Me.xdt_Costo) = e.cell Then
                If Val(e.value.ToString.Trim) <= 0 Then
                    e.hasErrors = True
                End If
                'If Me.LibXGrid1.GetValue(e.row, Me.xdt_Price).ToString.Trim <> "" Then mPrevPrice = Me.LibXGrid1.GetValue(e.row, Me.xdt_Price)
            End If

            '// Validar Precio
            'If Me.LibXGrid1.GetColNum(Me.xdt_Price) = e.cell Then
            '    If Val(e.value.ToString.Trim) <= 0 And LibXGrid1.GetValue(e.row, Me.xdt_item_code).ToString.Trim = "" Then
            '        'Throw New Applibxconnetor1licationException("Precio inválido!")
            '        MessageBox.Show("No hay unidad Asignada, Precio Invalido")
            '        LibXGrid1.Focus(e.row, 0)
            '    End If

            '    If lck_edit_price.Checked = True Then
            '        oValidarPrecio = New Articulo.ParametrosPrecioValido

            '        oValidarPrecio.Producto = Me.LibXGrid1.GetValue(e.row, Me.xdt_item_code)
            '        oValidarPrecio.Almacen = Me.txtwhse_code.Text
            '        oValidarPrecio.Precio = e.value
            '        oValidarPrecio.Unidad = Me.LibXGrid1.GetValue(Me.xdt_UnitCode)
            '        oValidarPrecio.Costo = Me.LibXGrid1.GetValue(e.row, Me.xdt_Costo)

            '        If mArticulo.isPrecioValido(oValidarPrecio) = False Then
            '            Me.LibXGrid1.SetValue(e.row, Me.xdt_Price, mPrevPrice)
            '            Throw New ApplicationException("Precio invalido!")
            '        End If
            'End If
            'End If

        Catch ex As Exception
            e.hasErrors = True
            LibX.Log.Show(ex)
        Finally
            ActualizaTotal()
        End Try
    End Sub
    ''Private Sub LibXGrid1_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGrid1.CellValidate
    ''    Try
    ''        '// CANTIDAD
    ''        If Me.xdt_Qty.Column = e.cell Then
    ''            If IsNull(Me.xdt_Qty.GetValue) Then
    ''                Exit Sub
    ''            End If

    ''            If Val(e.value.ToString.Trim) < 0 Then
    ''                LibXGrid1.SetValue(e.row, xdt_Qty, 0)
    ''                Throw New ApplicationException("No puede ordenar cantidad negativa")
    ''            End If

    ''            'LibXGrid1.SelectNextControl(Me.LibXGrid1, True, False, False, True)

    ''            If e.row = Me.LibXGrid1.getCurrentGridView.Count - 1 Then
    ''                SendKeys.Send("{TAB}")
    ''            End If
    ''            If Me.xdt_Qty.Column = e.cell Then
    ''                If LibXGrid1.GetValue(e.row, Me.xdt_item_code).ToString.Trim = "" Then
    ''                    LibXGrid1.Focus(e.row, 0)
    ''                    Exit Sub
    ''                End If
    ''            End If
    ''        End If
    ''    Catch ex As Exception
    ''        e.hasErrors = True
    ''        LibX.Log.Show(ex)
    ''    Finally
    ''        ActualizaTotal()
    ''    End Try
    ''End Sub

    Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail
        Try
            If LibXConnector1.IsDataEditing = True Then
                If cpordnd.Select("qty > 0").Length <= 0 Then
                    Throw New ApplicationException("No se especificaron las cantidades a ordenar de ningun producto, verifique!")
                End If

                ''For Each oRow As DataRow In cpordnd.Select("qty =0")
                ''    oRow.Delete()
                ''Next
            End If

        Catch ex As Exception
            e.Handled = True
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If LibXConnector1.IsEditing = False And LibXConnector1.HasRecords = True Then
                If Not e.row Is Nothing Then
                    If e.row!ordn_status = 3 Then
                        LibXConnector1.AllowEdit = False
                        LibXConnector1.AllowDelete = False
                    Else
                        LibXConnector1.AllowNew = True
                        LibXConnector1.AllowEdit = True
                        LibXConnector1.AllowDelete = True
                    End If

                    'If e.row!moneda = 1 Then
                    '    Me.Chk_RD.Checked = True
                    '    Me.Chk_US.Checked = False
                    'Else
                    '    If e.row!moneda = 2 Then
                    '        Me.Chk_US.Checked = True
                    '        Me.Chk_RD.Checked = False
                    '    End If
                    'End If
                    LibXNavigator1.UpdateState()
                End If

                Me.btnSugeridos.Enabled = LibXConnector1.IsDataEditing
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibxConnectionActions.Find Then
                Me.xcbo_paym_status.currValue = 1
            End If

            If e.Action = LibxConnectionActions.Edit Then
                Me.xdt_item_code.ReadOnly = True
                Me.xdt_item_code.isReadOnly = True
                'Else
                'Me.xdt_item_code.ReadOnly = False
                'Me.xdt_item_code.isReadOnly = False
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub lkl_item_code_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkl_item_code.AfterSetValues
        Try
            'If LibXConnector1.IsDataEditing = True Then
            If e.dataFound = False Then
                Exit Sub
            End If
            'If Me.Chk_RD.Checked = True Then
            '    LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, xdt_Costo, e.row!purch_cost)
            'Else
            '    LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, xdt_Costo, e.row!costus)
            'End If
            'End If
        Catch ex As Exception
            LibX.Log.Show(ex, True)
        End Try
    End Sub
    Private Sub lkl_item_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lkl_item_code.BeforeExecuteQuery
        Try

            If xtxtwhse_code.Text.Length > 0 Then
                e.aditionalWhere = "whse_code = " & xtxtwhse_code.Text
            End If

        Catch ex As Exception
            LibX.Log.Show(ex, True)
        End Try

    End Sub
    Private Sub lkl_item_code_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkl_item_code.BeforeSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            If LibXConnector1.IsDataEditing = True Then
                '// Validar si el producto existe y si es asi
                '// aumentar la cantidad de lo contrario continuar
                If ProductoExiste(e.row!item_code) = True Then
                    LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, xdt_item_code, "")
                    Throw New ApplicationException("Este producto ya esta registrado en esta factura!")
                End If
            End If

        Catch ex As Exception
            e.handled = True
            LibXGrid1.Focus(LibXGrid1.CurrentRowIndex, 0)
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        mAcction = e.Action
        For Each orow As DataRow In cpordnd.Rows
            If mAcction = LibxConnectionActions.Edit Then
                If Not LibX.IsNull(orow!sugerida) Then
                    If orow!sugerida > 0 And orow!qty = 0 Then
                        orow!qty = orow!sugerida
                    End If
                End If
            End If
        Next
    End Sub
    Private Function ProductoExiste(ByVal pitem_code As String) As Boolean
        Dim oRow As DataRow()
        Dim Qty As Integer
        Try
            oRow = cpordnd.Select("item_code = '" & pitem_code.Trim & "'")

            If oRow.Length <= 0 Then
                Return False
            End If

            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
    Private Sub LibXConnector1_InsertingDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingDetailRow
        Dim XUpdate As LibX.Data.XUpdateStmt
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then

                XUpdate = New LibX.Data.XUpdateStmt("ivitemd")

                XUpdate.FieldsSet("Cant_Pedida") = e.UpdatingArgs.Row!qty
                XUpdate.FieldsSet("numero_orden") = xtxt_ordn_number.Text
                XUpdate.Fields("item_code") = e.UpdatingArgs.Row!item_code
                XUpdate.Fields("whse_code") = e.UpdatingArgs.Row!whse_code
                XUpdate.Execute()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub btnSugeridos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSugeridos.Click
        Try

            For Each orow As DataRow In cpordnd.Rows
                If Not LibX.IsNull(orow!sugerida) Then
                    If orow!sugerida > 0 Then
                        orow!qty = orow!sugerida
                    End If
                End If
            Next

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub btnTransf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransf.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If Val(LibXConnector1.CurrentDataRow!ordn_serial) <> 0 Then
                EnviarOrdenCompras(LibXConnector1.CurrentDataRow!ordn_serial)
            End If
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub EnviarOrdenCompras(ByVal sErial As Integer)
        Dim wsSGF1 As WSSGF1.WSSGF1

        Dim oDataSet As DataSet

        Dim oTableCpordnm As DataTable
        Dim oTableCpordnm1 As DataTable
        Dim oTableCpordnd As DataTable
        Dim oTableCpordnd1 As DataTable
        Dim oRemote As DataTable
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim Number As String

        Try

            '// cpimvcem
            oTableCpordnm = LibX.Data.Manager.GetDataTable("select * from cpordnm where ordn_serial = " & sErial.ToString.Trim)

            If oTableCpordnm.Rows.Count <= 0 Then
                Throw New ApplicationException("No hay informaciones pendiente de transferir")
            End If


            For Each oRow1 As DataRow In oTableCpordnm.Rows
                oTableCpordnm1 = LibX.Data.Manager.GetDataTable("select * from cpordnm where ord_serial = " & oRow1!ord_serial)
                oTableCpordnm1.TableName = "cpordnm"

                oTableCpordnd1 = LibX.Data.Manager.GetDataTable("select * from cpordnd where ord_serial = " & oRow1!ord_serial)
                oTableCpordnd1.TableName = "cpordnd"

                '// DataSet
                oDataSet = New DataSet("dsSGF1")

                '// Tablas
                oDataSet.Tables.Add(oTableCpordnm1)
                oDataSet.Tables.Add(oTableCpordnd1)

                wsSGF1 = New WSSGF1.WSSGF1

                oRemote = LibX.Data.Manager.GetDataTable("select * from scremote where estatus = 1")

                If oRemote Is Nothing Then
                    Throw New ApplicationException("No hay estaciones remotas configuradas!")
                End If

                If oRemote.Rows.Count <= 0 Then
                    Throw New ApplicationException("No hay estaciones remotas configuradas!")
                End If

                For Each oRow As DataRow In oRemote.Rows
                    wsSGF1.Url = oRow!url.ToString.Trim
                    wsSGF1.Credentials = System.Net.CredentialCache.DefaultCredentials

                    If wsSGF1.InsertarEntradaDiario(oDataSet) Then
                        Number = oDataSet.Tables(0).Rows(0)!tran_number
                    End If
                Next
                xUpdate = New LibX.Data.XUpdateStmt("cpordnm")
                xUpdate.FieldsSet("tran_status") = 4
                xUpdate.Fields("ord_serial") = oRow1!ord_serial
                xUpdate.Fields("suc_code") = oRow1!suc_code
                xUpdate.Execute()
            Next

        Catch ex As Exception
            Throw
        End Try
    End Sub

    'Private Sub Chk_RD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.Chk_RD.Checked = True Then
    '        Me.Chk_US.Checked = False
    '        mMoneda = 1
    '    End If
    'End Sub

    'Private Sub Chk_US_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.Chk_US.Checked = True Then
    '        Me.Chk_RD.Checked = False
    '        mMoneda = 2
    '    End If
    'End Sub
    Private Sub btnSerie_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSerie.Click
        Dim oParam As LibX.LibxPrgParams
        Dim WhereStmt As String
        Dim c_almacen As i_ivserie01
        Try
            oParam = New LibX.LibxPrgParams
            c_almacen = New i_ivserie01

            WhereStmt = "ivitemv1.item_code = '" & LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, xdt_item_code) & "'"

            oParam.Datos.Add("where", WhereStmt)

            LibX.App.CurrentPrgParams = oParam

            c_almacen.ShowDialog()

            c_almacen = Nothing

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

End Class
