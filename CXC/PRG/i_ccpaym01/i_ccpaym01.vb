Imports SGT.Inventario
Imports SGT.Inventario.Entidades
Imports SGT.Caja.Entidades
Imports SGT.PuntodeVenta.Entidades
Imports LibX
Public Class i_ccpaym01
    Inherits System.Windows.Forms.Form
    Dim oDocument As Documento
    Dim mResta As Decimal
    Dim oCaja As Caja
    Dim oCajera As Cajera
    Dim oCajaAbierta As CajaAbierta
    Dim mTipoDocumento As String = "RCE"

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents cust_name As System.Windows.Forms.TextBox
    Friend WithEvents xdtp_paym_date As LibX.LibxDateTimePicker
    Friend WithEvents xcbo_paym_status As LibX.LibXCombo
    Friend WithEvents txtAmount As LibX.XMaskEdit
    Friend WithEvents txtPaym_number As LibX.XMaskEdit
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents xlk_cust_code As LibX.LibXLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ftfactm As System.Data.DataTable
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
    Friend WithEvents xtxt_cust_code As LibX.XTextBox
    Friend WithEvents xlk_caje_code As LibX.LibXLookup
    Friend WithEvents xlk_caja_code As LibX.LibXLookup
    Friend WithEvents labecaje_name As System.Windows.Forms.Label
    Friend WithEvents xtxt_caje_code As LibX.XTextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents labelcaja_name As System.Windows.Forms.Label
    Friend WithEvents xtxt_caja_code As LibX.XTextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents xtxt_ncf As LibX.XMaskEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ftfactm = New System.Data.DataTable
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
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.xtxt_cust_code = New LibX.XTextBox
        Me.txtPaym_number = New LibX.XMaskEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.xlk_caje_code = New LibX.LibXLookup
        Me.xlk_caja_code = New LibX.LibXLookup
        Me.labecaje_name = New System.Windows.Forms.Label
        Me.xtxt_caje_code = New LibX.XTextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.labelcaja_name = New System.Windows.Forms.Label
        Me.xtxt_caja_code = New LibX.XTextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.xlk_cust_code = New LibX.LibXLookup
        Me.xdtp_paym_date = New LibX.LibxDateTimePicker
        Me.xcbo_paym_status = New LibX.LibXCombo
        Me.cust_name = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAmount = New LibX.XMaskEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnAplicar = New System.Windows.Forms.Button
        Me.xtxt_ncf = New LibX.XMaskEdit
        Me.Label9 = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_cust_code
        Me.LibXNavigator1.FirstControlInFindMode = Nothing
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_cust_code
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(818, 24)
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
        Me.LibXConnector1.DataMember = "ftfactm"
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
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftfactm})
        '
        'ftfactm
        '
        Me.ftfactm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40})
        Me.ftfactm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no"}, True)})
        Me.ftfactm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.ftfactm.TableName = "ftfactm"
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
        Me.DataColumn3.ColumnName = "dev_type"
        Me.DataColumn3.MaxLength = 3
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "cotiz_serial"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "term_code"
        Me.DataColumn5.MaxLength = 5
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "addr_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "vend_code"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "fact_number"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "fact_date"
        Me.DataColumn9.DataType = GetType(System.DateTime)
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "fact_total"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "descto"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "itbis"
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
        Me.DataColumn19.ColumnName = "bus_name"
        Me.DataColumn19.MaxLength = 100
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "fact_nota"
        Me.DataColumn20.MaxLength = 80
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "ftserial_afect"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "pay_adelant"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "phone"
        Me.DataColumn23.MaxLength = 13
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "pay_mora"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "porc_comision"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "caja_code"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "caje_code"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "init_serial"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "fact_inddomicilio"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "address"
        Me.DataColumn30.MaxLength = 200
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "seg_amount"
        Me.DataColumn31.DataType = GetType(System.Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "prov_code"
        Me.DataColumn32.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "fact_impresa"
        Me.DataColumn33.DataType = GetType(System.Int32)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "fact_ncf"
        Me.DataColumn34.MaxLength = 40
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "cust_serial"
        Me.DataColumn35.DataType = GetType(System.Int32)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "fact_time"
        Me.DataColumn36.MaxLength = 12
        '
        'DataColumn37
        '
        Me.DataColumn37.AllowDBNull = False
        Me.DataColumn37.ColumnName = "suc_code"
        Me.DataColumn37.DataType = GetType(System.Int32)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "abono"
        Me.DataColumn38.DataType = GetType(System.Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "fact_create"
        Me.DataColumn39.DataType = GetType(System.DateTime)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "ncf_type"
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
        Me.LibXDbSourceTable1.InnerJon = True
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "ftserial_no"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ftfactm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'xtxt_cust_code
        '
        Me.xtxt_cust_code.AcceptsReturn = True
        Me.xtxt_cust_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.cust_code"))
        Me.xtxt_cust_code.EditInitialValue = Nothing
        Me.xtxt_cust_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cust_code.FieldDescription = ""
        Me.xtxt_cust_code.FindInitialValue = Nothing
        Me.xtxt_cust_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cust_code.IgnoreRequiered = False
        Me.xtxt_cust_code.Location = New System.Drawing.Point(96, 88)
        Me.xtxt_cust_code.Name = "xtxt_cust_code"
        Me.xtxt_cust_code.NewInitialValue = Nothing
        Me.xtxt_cust_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cust_code.Requiered = False
        Me.xtxt_cust_code.Size = New System.Drawing.Size(80, 20)
        Me.xtxt_cust_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_cust_code.TabIndex = 1
        Me.xtxt_cust_code.Text = ""
        '
        'txtPaym_number
        '
        Me.txtPaym_number.AcceptsReturn = True
        Me.txtPaym_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_number"))
        Me.txtPaym_number.EditInitialValue = Nothing
        Me.txtPaym_number.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtPaym_number.FieldDescription = ""
        Me.txtPaym_number.FindInitialValue = Nothing
        Me.txtPaym_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtPaym_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaym_number.IgnoreRequiered = False
        Me.txtPaym_number.Location = New System.Drawing.Point(664, 16)
        Me.txtPaym_number.Masked = MaskedTextBox.Mask.None
        Me.txtPaym_number.Name = "txtPaym_number"
        Me.txtPaym_number.NewInitialValue = Nothing
        Me.txtPaym_number.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtPaym_number.Requiered = False
        Me.txtPaym_number.Size = New System.Drawing.Size(128, 32)
        Me.txtPaym_number.StatusBarPanelDescripcion = Nothing
        Me.txtPaym_number.TabIndex = 0
        Me.txtPaym_number.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.xlk_caje_code)
        Me.GroupBox1.Controls.Add(Me.xlk_caja_code)
        Me.GroupBox1.Controls.Add(Me.labecaje_name)
        Me.GroupBox1.Controls.Add(Me.xtxt_caje_code)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.labelcaja_name)
        Me.GroupBox1.Controls.Add(Me.xtxt_caja_code)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.txtPaym_number)
        Me.GroupBox1.Controls.Add(Me.xlk_cust_code)
        Me.GroupBox1.Controls.Add(Me.xdtp_paym_date)
        Me.GroupBox1.Controls.Add(Me.xcbo_paym_status)
        Me.GroupBox1.Controls.Add(Me.cust_name)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xtxt_cust_code)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.xtxt_ncf)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 216)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(11, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Tipo Egreso:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.dev_type"))
        Me.LibXCombo1.DefaultWhereString = "req_serie = 9"
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Location = New System.Drawing.Point(96, 64)
        Me.LibXCombo1.LookupKeyDisplayFields = "dev_name"
        Me.LibXCombo1.LookupKeyField = "dev_type"
        Me.LibXCombo1.LookupTableName = "ftdevolt"
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = "GAS"
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(392, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 58
        '
        'xlk_caje_code
        '
        Me.xlk_caje_code.AlternateFieldSearch = Nothing
        Me.xlk_caje_code.BeginCheck = False
        Me.xlk_caje_code.CheckText = Nothing
        Me.xlk_caje_code.ComboMode = False
        Me.xlk_caje_code.DataMember = Nothing
        Me.xlk_caje_code.DataSource = Me.LibXConnector1
        Me.xlk_caje_code.DestParameters = New String() {"caje_code=vend_code", "labecaje_name=vend_name"}
        Me.xlk_caje_code.FilterField = "vend_name"
        Me.xlk_caje_code.IgnoreFindInBrowseMode = False
        Me.xlk_caje_code.isCanceled = False
        Me.xlk_caje_code.Location = New System.Drawing.Point(472, 40)
        Me.xlk_caje_code.LookCaption = "Cajeras"
        Me.xlk_caje_code.Name = "xlk_caje_code"
        Me.xlk_caje_code.PopupSize = New System.Drawing.Size(400, 300)
        Me.xlk_caje_code.ShowFilter = True
        Me.xlk_caje_code.ShowMessageNotFound = True
        Me.xlk_caje_code.ShowWarning = False
        Me.xlk_caje_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_caje_code.SizesColumns = Nothing
        Me.xlk_caje_code.SizesColumnsTab = Nothing
        Me.xlk_caje_code.SqlString = Nothing
        Me.xlk_caje_code.SQLTab = Nothing
        Me.xlk_caje_code.SrcParameters = New String() {"caje_code=vend_code"}
        Me.xlk_caje_code.TabIndex = 57
        Me.xlk_caje_code.TableName = "ftvendm"
        Me.xlk_caje_code.TabStop = False
        Me.xlk_caje_code.UseCopyConnection = False
        Me.xlk_caje_code.UseRowRetrieveEvents = False
        Me.xlk_caje_code.UseTab = False
        Me.xlk_caje_code.VisParameters = New String() {"Código=vend_code", "Nombre=vend_name"}
        Me.xlk_caje_code.WhereCondition = "vend_cargo = 1"
        Me.xlk_caje_code.WhereParameters = Nothing
        '
        'xlk_caja_code
        '
        Me.xlk_caja_code.AlternateFieldSearch = Nothing
        Me.xlk_caja_code.BeginCheck = False
        Me.xlk_caja_code.CheckText = Nothing
        Me.xlk_caja_code.ComboMode = False
        Me.xlk_caja_code.DataMember = Nothing
        Me.xlk_caja_code.DataSource = Me.LibXConnector1
        Me.xlk_caja_code.DestParameters = New String() {"caja_code=caja_code", "labelcaja_name=caja_name"}
        Me.xlk_caja_code.FilterField = "caja_name"
        Me.xlk_caja_code.IgnoreFindInBrowseMode = False
        Me.xlk_caja_code.isCanceled = False
        Me.xlk_caja_code.Location = New System.Drawing.Point(472, 16)
        Me.xlk_caja_code.LookCaption = "Listado de Cajas"
        Me.xlk_caja_code.Name = "xlk_caja_code"
        Me.xlk_caja_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_caja_code.ShowFilter = True
        Me.xlk_caja_code.ShowMessageNotFound = True
        Me.xlk_caja_code.ShowWarning = False
        Me.xlk_caja_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_caja_code.SizesColumns = Nothing
        Me.xlk_caja_code.SizesColumnsTab = Nothing
        Me.xlk_caja_code.SqlString = Nothing
        Me.xlk_caja_code.SQLTab = Nothing
        Me.xlk_caja_code.SrcParameters = New String() {"caja_code=caja_code"}
        Me.xlk_caja_code.TabIndex = 56
        Me.xlk_caja_code.TableName = "cjcajam"
        Me.xlk_caja_code.TabStop = False
        Me.xlk_caja_code.UseCopyConnection = False
        Me.xlk_caja_code.UseRowRetrieveEvents = False
        Me.xlk_caja_code.UseTab = False
        Me.xlk_caja_code.VisParameters = New String() {"Código=caja_code", "Nombre=caja_name"}
        Me.xlk_caja_code.WhereCondition = Nothing
        Me.xlk_caja_code.WhereParameters = Nothing
        '
        'labecaje_name
        '
        Me.labecaje_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labecaje_name.Location = New System.Drawing.Point(160, 40)
        Me.labecaje_name.Name = "labecaje_name"
        Me.labecaje_name.Size = New System.Drawing.Size(312, 20)
        Me.labecaje_name.TabIndex = 55
        '
        'xtxt_caje_code
        '
        Me.xtxt_caje_code.AcceptsReturn = True
        Me.xtxt_caje_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.caje_code"))
        Me.xtxt_caje_code.EditInitialValue = Nothing
        Me.xtxt_caje_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_caje_code.FieldDescription = "Digite el codigo de la cajera"
        Me.xtxt_caje_code.FindInitialValue = Nothing
        Me.xtxt_caje_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_caje_code.IgnoreRequiered = False
        Me.xtxt_caje_code.Location = New System.Drawing.Point(96, 40)
        Me.xtxt_caje_code.Name = "xtxt_caje_code"
        Me.xtxt_caje_code.NewInitialValue = Nothing
        Me.xtxt_caje_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_caje_code.Requiered = False
        Me.xtxt_caje_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_caje_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_caje_code.TabIndex = 49
        Me.xtxt_caje_code.Text = ""
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(38, 40)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(41, 16)
        Me.Label34.TabIndex = 54
        Me.Label34.Text = "Cajera:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'labelcaja_name
        '
        Me.labelcaja_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelcaja_name.Location = New System.Drawing.Point(160, 16)
        Me.labelcaja_name.Name = "labelcaja_name"
        Me.labelcaja_name.Size = New System.Drawing.Size(312, 20)
        Me.labelcaja_name.TabIndex = 53
        '
        'xtxt_caja_code
        '
        Me.xtxt_caja_code.AcceptsReturn = True
        Me.xtxt_caja_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.caja_code"))
        Me.xtxt_caja_code.EditInitialValue = Nothing
        Me.xtxt_caja_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_caja_code.FieldDescription = "Digite el codigo de la caja"
        Me.xtxt_caja_code.FindInitialValue = Nothing
        Me.xtxt_caja_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_caja_code.IgnoreRequiered = False
        Me.xtxt_caja_code.Location = New System.Drawing.Point(96, 16)
        Me.xtxt_caja_code.Name = "xtxt_caja_code"
        Me.xtxt_caja_code.NewInitialValue = Nothing
        Me.xtxt_caja_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_caja_code.Requiered = False
        Me.xtxt_caja_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_caja_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_caja_code.TabIndex = 47
        Me.xtxt_caja_code.Text = ""
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(48, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(31, 16)
        Me.Label32.TabIndex = 52
        Me.Label32.Text = "Caja:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_cust_code
        '
        Me.xlk_cust_code.AlternateFieldSearch = Nothing
        Me.xlk_cust_code.BeginCheck = False
        Me.xlk_cust_code.CheckText = Nothing
        Me.xlk_cust_code.ComboMode = False
        Me.xlk_cust_code.DataMember = Nothing
        Me.xlk_cust_code.DataSource = Me.LibXConnector1
        Me.xlk_cust_code.DestParameters = New String() {"cust_code=cust_code"}
        Me.xlk_cust_code.FilterField = "cust_name"
        Me.xlk_cust_code.IgnoreFindInBrowseMode = False
        Me.xlk_cust_code.isCanceled = False
        Me.xlk_cust_code.Location = New System.Drawing.Point(176, 88)
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
        Me.xlk_cust_code.SQLTab = Nothing
        Me.xlk_cust_code.SrcParameters = New String() {"cust_code=cust_code"}
        Me.xlk_cust_code.TabIndex = 5
        Me.xlk_cust_code.TableName = "cccustm"
        Me.xlk_cust_code.TabStop = False
        Me.xlk_cust_code.UseCopyConnection = False
        Me.xlk_cust_code.UseRowRetrieveEvents = False
        Me.xlk_cust_code.UseTab = False
        Me.xlk_cust_code.VisParameters = New String() {"Código=cust_code", "Nombre=cust_name", "Límite Crédito=credit_limit", "Balance=balance"}
        Me.xlk_cust_code.WhereCondition = Nothing
        Me.xlk_cust_code.WhereParameters = Nothing
        '
        'xdtp_paym_date
        '
        Me.xdtp_paym_date.CustomFormat = "dd/MM/yyyy"
        Me.xdtp_paym_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.fact_date"))
        Me.xdtp_paym_date.EditInitialValue = Nothing
        Me.xdtp_paym_date.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdtp_paym_date.FieldDescription = ""
        Me.xdtp_paym_date.FindInitialValue = Nothing
        Me.xdtp_paym_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdtp_paym_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xdtp_paym_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdtp_paym_date.IgnoreRequiered = False
        Me.xdtp_paym_date.Location = New System.Drawing.Point(664, 128)
        Me.xdtp_paym_date.Name = "xdtp_paym_date"
        Me.xdtp_paym_date.NewInitialValue = "Now"
        Me.xdtp_paym_date.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdtp_paym_date.Requiered = False
        Me.xdtp_paym_date.Size = New System.Drawing.Size(128, 32)
        Me.xdtp_paym_date.StatusBarPanelDescripcion = Nothing
        Me.xdtp_paym_date.TabIndex = 6
        '
        'xcbo_paym_status
        '
        Me.xcbo_paym_status.AllowDefaultSort = True
        Me.xcbo_paym_status.bound = True
        Me.xcbo_paym_status.currValue = Nothing
        Me.xcbo_paym_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.fact_status"))
        Me.xcbo_paym_status.DefaultWhereString = Nothing
        Me.xcbo_paym_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_paym_status.EditInitialValue = Nothing
        Me.xcbo_paym_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_paym_status.FieldDescription = ""
        Me.xcbo_paym_status.FindInitialValue = Nothing
        Me.xcbo_paym_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_paym_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xcbo_paym_status.IgnoreRequiered = False
        Me.xcbo_paym_status.Items.AddRange(New Object() {"0-Anulada", "1-Pendiente", "2-Cobrada"})
        Me.xcbo_paym_status.Location = New System.Drawing.Point(664, 88)
        Me.xcbo_paym_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_paym_status.LookupKeyField = Nothing
        Me.xcbo_paym_status.LookupTableName = Nothing
        Me.xcbo_paym_status.Name = "xcbo_paym_status"
        Me.xcbo_paym_status.NewInitialValue = "2"
        Me.xcbo_paym_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_paym_status.Requiered = False
        Me.xcbo_paym_status.Required = False
        Me.xcbo_paym_status.Size = New System.Drawing.Size(128, 33)
        Me.xcbo_paym_status.SqlString = Nothing
        Me.xcbo_paym_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_paym_status.TabIndex = 5
        '
        'cust_name
        '
        Me.cust_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cust_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.bus_name"))
        Me.cust_name.Location = New System.Drawing.Point(96, 112)
        Me.cust_name.Name = "cust_name"
        Me.cust_name.Size = New System.Drawing.Size(392, 20)
        Me.cust_name.TabIndex = 2
        Me.cust_name.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(585, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(36, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(598, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAmount
        '
        Me.txtAmount.AcceptsReturn = True
        Me.txtAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_total"))
        Me.txtAmount.EditInitialValue = Nothing
        Me.txtAmount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAmount.FieldDescription = ""
        Me.txtAmount.FindInitialValue = Nothing
        Me.txtAmount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.IgnoreRequiered = False
        Me.txtAmount.Location = New System.Drawing.Point(664, 168)
        Me.txtAmount.Masked = MaskedTextBox.Mask.Decimal
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.NewInitialValue = Nothing
        Me.txtAmount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtAmount.Requiered = False
        Me.txtAmount.Size = New System.Drawing.Size(128, 38)
        Me.txtAmount.StatusBarPanelDescripcion = Nothing
        Me.txtAmount.TabIndex = 4
        Me.txtAmount.Text = ""
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(536, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Monto a Pagar:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(48, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nota:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox7
        '
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_nota"))
        Me.TextBox7.Location = New System.Drawing.Point(96, 136)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(392, 64)
        Me.TextBox7.TabIndex = 3
        Me.TextBox7.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(589, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Estatus:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(12, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Beneficiario:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnAplicar
        '
        Me.btnAplicar.Enabled = False
        Me.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAplicar.Location = New System.Drawing.Point(8, 264)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(75, 32)
        Me.btnAplicar.TabIndex = 4
        Me.btnAplicar.Text = "Cobrar (F9)"
        '
        'xtxt_ncf
        '
        Me.xtxt_ncf.AcceptsReturn = True
        Me.xtxt_ncf.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_ncf"))
        Me.xtxt_ncf.EditInitialValue = Nothing
        Me.xtxt_ncf.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_ncf.FieldDescription = ""
        Me.xtxt_ncf.FindInitialValue = Nothing
        Me.xtxt_ncf.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_ncf.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_ncf.IgnoreRequiered = False
        Me.xtxt_ncf.Location = New System.Drawing.Point(664, 51)
        Me.xtxt_ncf.Masked = MaskedTextBox.Mask.None
        Me.xtxt_ncf.Name = "xtxt_ncf"
        Me.xtxt_ncf.NewInitialValue = Nothing
        Me.xtxt_ncf.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_ncf.Requiered = False
        Me.xtxt_ncf.Size = New System.Drawing.Size(128, 32)
        Me.xtxt_ncf.StatusBarPanelDescripcion = Nothing
        Me.xtxt_ncf.TabIndex = 0
        Me.xtxt_ncf.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(608, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 22)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "NCF:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'i_ccpaym01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(818, 312)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "i_ccpaym01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Recibo de Egresos"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftfactm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues


        Try
            xcbo_paym_status.currValue = Val(EstatusDocumentosEnum.Pendiente) 'Pendiente de aplicar
            Me.xdtp_paym_date.Value = oCajaAbierta.Fecha

            Me.xtxt_caja_code.Text = oCaja.Code
            Me.labelcaja_name.Text = oCaja.Name

            Me.xtxt_caje_code.Text = oCajera.Code
            Me.labecaje_name.Text = oCajera.Name

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub


    Private Sub xlk_cust_code_AfterSetValues(ByVal sender As System.Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_cust_code.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            cust_name.Text = e.row!cust_name.ToString

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Dim XUpdate As LibX.Data.XUpdateStmt
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                '// Datos
                If Me.cust_name.Text = "" Then
                    Throw New ApplicationException("Debe especificar el beneficiario!")
                End If
                e.UpdatingArgs.Row!type_code = mTipoDocumento 'RECIBO DE EGRESO

                If LibX.IsNull(e.UpdatingArgs.Row!fact_ncf) Then
                    e.UpdatingArgs.Row!fact_ncf = oDocument.GenerateNCF("RCE", LibX.User.WhDefault, SGT.Inventario.Entidades.Documento.TipoNCFEnum.GastosMenores)
                End If

                e.UpdatingArgs.Row!fact_cond = 1 '// Contado
                e.UpdatingArgs.Row!itbis = 0
                e.UpdatingArgs.Row!descto = 0
                e.UpdatingArgs.Row!whse_code = LibX.User.WhDefault
                e.UpdatingArgs.Row!suc_code = LibX.User.Sucursal
                e.UpdatingArgs.Row!fact_create = LibX.Data.Manager.GetScalar("select getdate()")
                e.UpdatingArgs.Row!fact_inddomicilio = 0
                e.UpdatingArgs.Row!init_serial = oCajaAbierta.Serial
                e.UpdatingArgs.Row!vend_code = oCajaAbierta.CajeraCode
            End If

            '// Anular documento
            If e.UpdatingArgs.StatementType = StatementType.Delete Then
                '// Anular Documento
                If e.UpdatingArgs.Row.Item("fact_status", DataRowVersion.Original) = Val(EstatusDocumentosEnum.Cobrada) Then
                    e.UpdatingArgs.Status = UpdateStatus.SkipCurrentRow
                    XUpdate = New LibX.Data.XUpdateStmt("ftfactm")
                    XUpdate.FieldsSet("fact_status") = Val(EstatusDocumentosEnum.Anulada)
                    XUpdate.Fields("ftserial_no") = e.UpdatingArgs.Row.Item("ftserial_no", DataRowVersion.Original)
                    XUpdate.Execute()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
        End Try
    End Sub

    Private Sub i_ccpaym01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Try

                oDocument = New SGT.Inventario.Entidades.Documento(mTipoDocumento)
                DataSet1.Tables("ftfactm").Columns("fact_number").AllowDBNull = True

                '// buscar el personal correspondiente para este usuario
                'oCajera = New Cajera(LibX.User.VendedorID)
                ''oCajera = New Cajera(CajaAbierta.CajeraCode)
                oCajera = New Cajera(LibX.User.VendedorID)
                oCajaAbierta = New CajaAbierta

                '// si este usuario no es una cajera no permitir trabajar en recibos
                If oCajera.esCajera = False Then
                    Throw New ApplicationException("Debe especificar una cajera para iniciar una caja!")
                End If

                '// si no hay cajas abiertas no permitir trabajar
                If oCajaAbierta.HayCajasAbiertas = False Then
                    Throw New ApplicationException("Debe iniciar una caja para realizar las operaciones del dia!")
                End If

                '// Si se envia el codigo de la caja para trabajar
                If Not LibXConnector1.Parameters Is Nothing Then
                    If CType(LibXConnector1.Parameters.Value, Integer) > 0 Then
                        oCajaAbierta.Serial = CType(LibXConnector1.Parameters.Value, Integer)
                        If oCajaAbierta.Load = False Then
                            Throw New ApplicationException("Las operaciones para este parametros no existen!")
                        End If
                    Else
                        '// Si es un vendedor mostrar la lista de cajas abiertas 
                        LibX.LibXRunner.Run("i_cjopen", "CAJ", True)
                    End If
                Else
                    '// Si es un vendedor mostrar la lista de cajas abiertas 
                    LibX.LibXRunner.Run("i_cjopen", "CAJ", True)
                End If

                Me.Text &= " - [" & "CAJERA - " & oCajaAbierta.Fecha.ToString("dd/MM/yyyy") & "]"

                If CajaAbierta.CajeraCode <= 0 Then
                    Me.Close()
                    Exit Sub
                End If

                oCaja = New Caja(CajaAbierta.CajaCode)
                '// Mostrar los datos de la caja y la cajera
                Me.xtxt_caja_code.Text = oCaja.Code
                Me.xtxt_caja_code.NewInitialValue = oCaja.Code
                Me.labelcaja_name.Text = oCaja.Name

                Me.xtxt_caje_code.Text = oCajera.Code
                Me.xtxt_caje_code.NewInitialValue = oCajera.Code
                Me.labecaje_name.Text = oCajera.Name


            Catch ex As Exception
                LibX.Log.Show(ex)
            End Try
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        e.AditionalWhere = "ftfactm.type_code = 'RCE' and ftfactm.whse_code = " & LibX.User.WhDefault

    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Dim XReport As LibX.ReportLib
        Dim SelectStmt As String
        Dim XUpdate As LibX.Data.XUpdateStmt
        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
                XReport = New LibX.ReportLib("CXC", "r_ccpaym01.rpt")

                XReport.RetrieveSQLQuery()
                SelectStmt = XReport.SQLQuery

                SelectStmt = LibX.ConcatWherePart(SelectStmt.Trim, _
                                                " ftfactm.ftserial_no = " & _
                                                LibXConnector1.CurrentDataRow!ftserial_no.ToString)
                XReport.SQLQuery = SelectStmt
                XReport.Action = 1

                '// Actualizar el documento si ya fue impreso
                If LibX.IsNull(LibXConnector1.CurrentDataRow!fact_impresa) = True _
                OrElse LibXConnector1.CurrentDataRow!fact_impresa = 0 Then
                    XUpdate = New LibX.Data.XUpdateStmt("ftfactm")
                    XUpdate.FieldsSet("fact_impresa") = 1
                    XUpdate.Fields("ftserial_no") = LibXConnector1.CurrentDataRow!ftserial_no

                    XUpdate.Execute()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub xlk_cust_code_CreatedGridColumns(ByVal sender As Object, ByVal e As LibX.CreatedGridColumnsEventArgs) Handles xlk_cust_code.CreatedGridColumns
        e.TStyle.GridColumnStyles("cust_name").Width = 600
    End Sub

    Private Sub CobrarDocumento(ByVal p_serial_no As Integer)
        Dim XDelete As LibX.Data.XDeleteStmt
        Try
            Dim op As New LibxPrgParams

            op.IsFromOther = True
            op.initMode = LibxInitModes.Edit
            op.WhereToExecute = "ftfactm.ftserial_no = " & p_serial_no.ToString.Trim
            App.CurrentPrgParams = op

            LibX.LibXRunner.Run("i_cjfact01", "CAJ", True)

            LibXConnector1.CurrentDataRow.Row.RejectChanges()
            LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & p_serial_no.ToString.Trim)

            If LibXConnector1.CurrentDataRow.Row!fact_status = Val(EstatusDocumentosEnum.Pendiente) Then
                ''''// Borrar Detalle
                '''XDelete = New LibX.Data.XDeleteStmt("ccpaymd")
                '''XDelete.Fields("paym_serial") = p_serial_no
                '''XDelete.Fields("type_code") = LibXConnector1.CurrentDataRow.Row!type_code.ToString.Trim
                '''XDelete.Execute()

                '// Borrar Cabecera
                XDelete = New LibX.Data.XDeleteStmt("ftfactm")
                XDelete.Fields("ftserial_no") = p_serial_no
                XDelete.Execute()

                XDelete.Dispose()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    '''Private Sub CobrarDocumento(ByVal p_serial_no As Integer)
    '''    Try
    '''        Dim op As New LibxPrgParams

    '''        op.IsFromOther = True
    '''        op.initMode = LibxInitModes.Edit
    '''        op.WhereToExecute = "ftfactm.ftserial_no = " & p_serial_no.ToString.Trim
    '''        App.CurrentPrgParams = op

    '''        LibX.LibXRunner.Run("i_cjfact01", "CAJ", True)

    '''        LibXConnector1.CurrentDataRow.Row.RejectChanges()
    '''        LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & p_serial_no.ToString.Trim)

    '''    Catch ex As Exception
    '''        LibX.Log.Add(ex)
    '''    End Try
    '''End Sub


    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If Not e.row Is Nothing Then
                LibXConnector1.AllowEdit = True
                LibXConnector1.AllowDelete = True

                If e.row!fact_status = Val(EstatusDocumentosEnum.Cobrada) _
                Or e.row!fact_status = Val(EstatusDocumentosEnum.Anulada) Then
                    LibXConnector1.AllowEdit = False
                End If

                If e.row!fact_status = Val(EstatusDocumentosEnum.Anulada) Then
                    LibXConnector1.AllowDelete = False
                End If

                LibXNavigator1.UpdateState()

                btnAplicar.Enabled = (LibXConnector1.IsEditing = False AndAlso LibXConnector1.HasRecords = True AndAlso e.row!fact_status = Val(EstatusDocumentosEnum.Pendiente))
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click
        Try
            CobrarDocumento(LibXConnector1.CurrentDataRow!ftserial_no)
            Me.Close()
            Exit Sub
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub i_ccpaym01_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If LibXConnector1.IsEditing = False And LibXConnector1.HasRecords = True Then
                If e.KeyCode = Keys.F9 Then
                    CobrarDocumento(LibXConnector1.CurrentDataRow!ftserial_no)
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        If e.AcceptedAction = LibxConnectionActions.Add _
        Or e.AcceptedAction = LibxConnectionActions.Edit Then
            Dim Serial As Integer
            '// Refrescar

            If LibX.IsNull(LibXConnector1.CurrentDataRow!ftserial_no) = False Then
                Serial = LibXConnector1.CurrentDataRow!ftserial_no
            Else
                Serial = LibX.Data.Manager.LastSerialValue
            End If

            LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & Serial.ToString.Trim)

            '// Cobrar
            CobrarDocumento(Serial)
            Me.Close()

            '// Refrescar
            LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & Serial.ToString.Trim)
        End If

    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try
            btnAplicar.Enabled = (e.isEditing = False AndAlso LibXConnector1.HasRecords = True AndAlso LibXConnector1.CurrentDataRow!fact_status = Val(EstatusDocumentosEnum.Pendiente))

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub
End Class
