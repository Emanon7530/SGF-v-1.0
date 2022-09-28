Imports SGT.Inventario.Common
Imports SGT.CXC.Posteos
Imports System.Configuration.ConfigurationSettings

Public Class p_ccpaym01
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn4 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn6 As LibX.XEditTextBoxColumn
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnDetail As System.Windows.Forms.Button
    Friend WithEvents btnUnmarkall As System.Windows.Forms.Button
    Friend WithEvents btnMarkAll As System.Windows.Forms.Button
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents gColTipo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gcolmonto As LibX.XEditTextBoxColumn
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents XDataGridBoolColumn1 As LibX.XDataGridBoolColumn
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblcust_name As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents xdt_invce_date As LibX.LibxDateTimePicker
    Friend WithEvents xcbo_type_code As LibX.LibXCombo
    Friend WithEvents xdt_due_date As LibX.LibxDateTimePicker
    Friend WithEvents xtxt_cust_code As LibX.XTextBox
    Friend WithEvents btnTodos As System.Windows.Forms.Button
    Friend WithEvents DataTable1 As System.Data.DataTable
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
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents xtxt_paym_number As LibX.XTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
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
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.lblcust_name = New System.Windows.Forms.Label
        Me.xtxt_paym_number = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.xdt_invce_date = New LibX.LibxDateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.xcbo_type_code = New LibX.LibXCombo
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.xdt_due_date = New LibX.LibxDateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.xtxt_cust_code = New LibX.XTextBox
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnDetail = New System.Windows.Forms.Button
        Me.btnUnmarkall = New System.Windows.Forms.Button
        Me.btnMarkAll = New System.Windows.Forms.Button
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XDataGridBoolColumn1 = New LibX.XDataGridBoolColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn4 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn6 = New LibX.XEditTextBoxColumn
        Me.gcolmonto = New LibX.XEditTextBoxColumn
        Me.gColTipo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataView1 = New System.Data.DataView
        Me.btnAplicar = New System.Windows.Forms.Button
        Me.btnTodos = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.lblcust_name)
        Me.GroupBox1.Controls.Add(Me.xtxt_paym_number)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xdt_invce_date)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xcbo_type_code)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xdt_due_date)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xtxt_cust_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 112)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio"
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"xtxt_cust_code=cust_code", "lblcust_name=cust_name"}
        Me.LibXLookup1.FilterField = "cust_name"
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(656, 72)
        Me.LibXLookup1.LookCaption = "Clientes"
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
        Me.LibXLookup1.SrcParameters = New String() {"xtxt_cust_code=cust_code"}
        Me.LibXLookup1.TabIndex = 6
        Me.LibXLookup1.TableName = "cccustm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Codigo=cust_code", "Nombre=cust_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "ccpaymm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = True
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = True
        Me.LibXConnector1.ModuleName = ""
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = ""
        Me.LibXConnector1.ReportObject = Nothing
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable3})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn1, Me.DataColumn2})
        Me.DataTable1.TableName = "ccpaymm"
        '
        'DataColumn32
        '
        Me.DataColumn32.AllowDBNull = False
        Me.DataColumn32.AutoIncrement = True
        Me.DataColumn32.ColumnName = "paym_serial"
        Me.DataColumn32.DataType = GetType(System.Int32)
        Me.DataColumn32.ReadOnly = True
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "type_code"
        Me.DataColumn33.MaxLength = 3
        '
        'DataColumn34
        '
        Me.DataColumn34.AllowDBNull = False
        Me.DataColumn34.ColumnName = "paym_number"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "term_code"
        Me.DataColumn35.MaxLength = 5
        '
        'DataColumn36
        '
        Me.DataColumn36.AllowDBNull = False
        Me.DataColumn36.ColumnName = "cust_code"
        Me.DataColumn36.DataType = GetType(System.Int32)
        '
        'DataColumn37
        '
        Me.DataColumn37.AllowDBNull = False
        Me.DataColumn37.ColumnName = "invce_date"
        Me.DataColumn37.DataType = GetType(System.DateTime)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "detail"
        Me.DataColumn38.MaxLength = 60
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "due_date"
        Me.DataColumn39.DataType = GetType(System.DateTime)
        '
        'DataColumn40
        '
        Me.DataColumn40.AllowDBNull = False
        Me.DataColumn40.ColumnName = "amount"
        Me.DataColumn40.DataType = GetType(System.Decimal)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "itbis"
        Me.DataColumn41.DataType = GetType(System.Decimal)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "amount_grab"
        Me.DataColumn42.DataType = GetType(System.Decimal)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "amount_excent"
        Me.DataColumn43.DataType = GetType(System.Decimal)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "cargo_banc"
        Me.DataColumn44.DataType = GetType(System.Decimal)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "cargo_desc"
        Me.DataColumn45.DataType = GetType(System.Decimal)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "excento"
        Me.DataColumn46.DataType = GetType(System.Decimal)
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "impto"
        Me.DataColumn47.DataType = GetType(System.Decimal)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "invce_status"
        Me.DataColumn48.DataType = GetType(System.Int32)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "total_amount"
        Me.DataColumn49.DataType = GetType(System.Decimal)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "invce_ncf"
        Me.DataColumn50.MaxLength = 20
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "vend_code"
        Me.DataColumn51.DataType = GetType(System.Int32)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "chequera"
        Me.DataColumn52.DataType = GetType(System.Int32)
        '
        'DataColumn53
        '
        Me.DataColumn53.AllowDBNull = False
        Me.DataColumn53.ColumnName = "suc_code"
        Me.DataColumn53.DataType = GetType(System.Int32)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "invce_datetran"
        Me.DataColumn54.DataType = GetType(System.DateTime)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "invce_create"
        Me.DataColumn55.DataType = GetType(System.DateTime)
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "type_code1"
        Me.DataColumn56.MaxLength = 3
        '
        'DataColumn57
        '
        Me.DataColumn57.AllowDBNull = False
        Me.DataColumn57.ColumnName = "type_name"
        Me.DataColumn57.MaxLength = 30
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "cust_name"
        Me.DataColumn58.MaxLength = 100
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "aplicar"
        Me.DataColumn1.ColumnName = "aplicar"
        Me.DataColumn1.DataType = GetType(System.Int16)
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "userid"
        Me.DataColumn2.ColumnName = "userid"
        Me.DataColumn2.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable3.SerialColumnName = "paym_serial"
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = New String() {"select ccpaymm.*, ", "       ccpaymm.type_code, ", "       ivtypem.[type_name], ", "       cccustm.cust_name ", "       from ccpaymm  ", "       inner join ivtypem  ", "       on ccpaymm.type_code = ivtypem.type_code  ", "       inner join cccustm ", "       on ccpaymm.cust_code = cccustm.cust_code ", "       where invce_status = 2 "}
        Me.LibXDbSourceTable3.TableName = "ccpaymm"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'lblcust_name
        '
        Me.lblcust_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcust_name.Location = New System.Drawing.Point(192, 72)
        Me.lblcust_name.Name = "lblcust_name"
        Me.lblcust_name.Size = New System.Drawing.Size(464, 20)
        Me.lblcust_name.TabIndex = 5
        '
        'xtxt_paym_number
        '
        Me.xtxt_paym_number.AcceptsReturn = True
        Me.xtxt_paym_number.EditInitialValue = Nothing
        Me.xtxt_paym_number.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_paym_number.FieldDescription = ""
        Me.xtxt_paym_number.FindInitialValue = Nothing
        Me.xtxt_paym_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_paym_number.IgnoreRequiered = False
        Me.xtxt_paym_number.Location = New System.Drawing.Point(128, 48)
        Me.xtxt_paym_number.Name = "xtxt_paym_number"
        Me.xtxt_paym_number.NewInitialValue = Nothing
        Me.xtxt_paym_number.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_paym_number.Requiered = False
        Me.xtxt_paym_number.StatusBarPanelDescripcion = Nothing
        Me.xtxt_paym_number.TabIndex = 4
        Me.xtxt_paym_number.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(476, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Documento:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xdt_invce_date
        '
        Me.xdt_invce_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_invce_date.EditInitialValue = Nothing
        Me.xdt_invce_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_invce_date.FieldDescription = ""
        Me.xdt_invce_date.FindInitialValue = Nothing
        Me.xdt_invce_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_invce_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_invce_date.IgnoreRequiered = False
        Me.xdt_invce_date.Location = New System.Drawing.Point(584, 24)
        Me.xdt_invce_date.Name = "xdt_invce_date"
        Me.xdt_invce_date.NewInitialValue = Nothing
        Me.xdt_invce_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_invce_date.Requiered = False
        Me.xdt_invce_date.Size = New System.Drawing.Size(88, 20)
        Me.xdt_invce_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_invce_date.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo de Documento:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_type_code
        '
        Me.xcbo_type_code.AllowDefaultSort = True
        Me.xcbo_type_code.bound = True
        Me.xcbo_type_code.currValue = Nothing
        Me.xcbo_type_code.DefaultWhereString = "apply_cxc=1"
        Me.xcbo_type_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_type_code.EditInitialValue = Nothing
        Me.xcbo_type_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_type_code.FieldDescription = ""
        Me.xcbo_type_code.FindInitialValue = Nothing
        Me.xcbo_type_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_type_code.IgnoreRequiered = False
        Me.xcbo_type_code.Location = New System.Drawing.Point(128, 24)
        Me.xcbo_type_code.LookupKeyDisplayFields = "type_name"
        Me.xcbo_type_code.LookupKeyField = "type_code"
        Me.xcbo_type_code.LookupTableName = "ivtypem"
        Me.xcbo_type_code.Name = "xcbo_type_code"
        Me.xcbo_type_code.NewInitialValue = Nothing
        Me.xcbo_type_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_type_code.Requiered = False
        Me.xcbo_type_code.Required = False
        Me.xcbo_type_code.Size = New System.Drawing.Size(320, 21)
        Me.xcbo_type_code.SqlString = Nothing
        Me.xcbo_type_code.StatusBarPanelDescripcion = Nothing
        Me.xcbo_type_code.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Numero Documento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(472, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha Vencimiento:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xdt_due_date
        '
        Me.xdt_due_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_due_date.EditInitialValue = Nothing
        Me.xdt_due_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_due_date.FieldDescription = ""
        Me.xdt_due_date.FindInitialValue = Nothing
        Me.xdt_due_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_due_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_due_date.IgnoreRequiered = False
        Me.xdt_due_date.Location = New System.Drawing.Point(584, 48)
        Me.xdt_due_date.Name = "xdt_due_date"
        Me.xdt_due_date.NewInitialValue = Nothing
        Me.xdt_due_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_due_date.Requiered = False
        Me.xdt_due_date.Size = New System.Drawing.Size(88, 20)
        Me.xdt_due_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_due_date.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Cliente:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_cust_code
        '
        Me.xtxt_cust_code.AcceptsReturn = True
        Me.xtxt_cust_code.EditInitialValue = Nothing
        Me.xtxt_cust_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cust_code.FieldDescription = ""
        Me.xtxt_cust_code.FindInitialValue = Nothing
        Me.xtxt_cust_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cust_code.IgnoreRequiered = False
        Me.xtxt_cust_code.Location = New System.Drawing.Point(128, 72)
        Me.xtxt_cust_code.Name = "xtxt_cust_code"
        Me.xtxt_cust_code.NewInitialValue = Nothing
        Me.xtxt_cust_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cust_code.Requiered = False
        Me.xtxt_cust_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_cust_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_cust_code.TabIndex = 4
        Me.xtxt_cust_code.Text = ""
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
        Me.LibXDbSourceTable2.SerialColumnName = "invce_serial"
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select 0 as Aplicar,ccinvcem.invce_serial, ", "                       ccinvcem.type_code, ", "                      ivtypem.[type_name], ", "                       ccinvcem.invce_no,  ", "                       ccinvcem.invce_date, ", "                       ccinvcem.cust_code,  ", "                       cccustm.cust_name, ", "                       ccinvcem.total_amount  ", "                       from ccinvcem  ", "                       inner join ivtypem  ", "                       on ccinvcem.type_code = ivtypem.type_code  ", "                       inner join cccustm ", "                       on ccinvcem.cust_code = cccustm.cust_code "}
        Me.LibXDbSourceTable2.TableName = "ccinvcem"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
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
        Me.LibXDbSourceTable1.InnerJon = True
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "invce_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select ccinvcem.invce_serial,", "" & Microsoft.VisualBasic.ChrW(9) & "ccinvcem.type_code,", "" & Microsoft.VisualBasic.ChrW(9) & "ivtypem.[type_name],", "" & Microsoft.VisualBasic.ChrW(9) & "ccinvcem.invce_no,", "" & Microsoft.VisualBasic.ChrW(9) & "ccinvcem.invce_date,", "" & Microsoft.VisualBasic.ChrW(9) & "ccinvcem.cust_code,", "" & Microsoft.VisualBasic.ChrW(9) & "cccustm.cust_name,", "" & Microsoft.VisualBasic.ChrW(9) & "ccinvcem.total_amount" & Microsoft.VisualBasic.ChrW(9), "from ccinvcem ", "inner join ivtypem", "on ccinvcem.type_code = ivtypem.type_code", "inner join cccustm", "on ccinvcem.cust_code = cccustm.cust_code", "" & Microsoft.VisualBasic.ChrW(9), "" & Microsoft.VisualBasic.ChrW(9), "" & Microsoft.VisualBasic.ChrW(9)}
        Me.LibXDbSourceTable1.TableName = "ccinvcem"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Location = New System.Drawing.Point(696, 96)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 24)
        Me.btnRefresh.TabIndex = 10
        Me.btnRefresh.Text = "Refrescar"
        '
        'btnDetail
        '
        Me.btnDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDetail.Enabled = False
        Me.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDetail.Location = New System.Drawing.Point(168, 520)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(80, 32)
        Me.btnDetail.TabIndex = 9
        Me.btnDetail.Text = "Visualizar"
        '
        'btnUnmarkall
        '
        Me.btnUnmarkall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUnmarkall.Enabled = False
        Me.btnUnmarkall.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnmarkall.Location = New System.Drawing.Point(88, 520)
        Me.btnUnmarkall.Name = "btnUnmarkall"
        Me.btnUnmarkall.Size = New System.Drawing.Size(80, 32)
        Me.btnUnmarkall.TabIndex = 8
        Me.btnUnmarkall.Text = "Desmarcar Todos"
        '
        'btnMarkAll
        '
        Me.btnMarkAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMarkAll.Enabled = False
        Me.btnMarkAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarkAll.Location = New System.Drawing.Point(8, 520)
        Me.btnMarkAll.Name = "btnMarkAll"
        Me.btnMarkAll.Size = New System.Drawing.Size(80, 32)
        Me.btnMarkAll.TabIndex = 7
        Me.btnMarkAll.Text = "Marcar Todos"
        '
        'LibXGrid1
        '
        Me.LibXGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = True
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Documentos pendientes por Aplicar"
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.DataMember = "ccpaymm"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 120)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(848, 352)
        Me.LibXGrid1.TabIndex = 15
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Marcar Todos"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Desmarcar Todos"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Visualizar"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "Refrescar"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 5
        Me.MenuItem6.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 6
        Me.MenuItem7.Text = "Aplicar"
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XDataGridBoolColumn1, Me.XEditTextBoxColumn3, Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn4, Me.XEditTextBoxColumn6, Me.gcolmonto, Me.gColTipo})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ccpaymm"
        '
        'XDataGridBoolColumn1
        '
        Me.XDataGridBoolColumn1.FalseValue = CType(0, Short)
        Me.XDataGridBoolColumn1.HeaderText = "Aplicar"
        Me.XDataGridBoolColumn1.MappingName = "aplicar"
        Me.XDataGridBoolColumn1.NullValue = 0
        Me.XDataGridBoolColumn1.TrueValue = CType(1, Short)
        Me.XDataGridBoolColumn1.UseCustomCellFormat = False
        Me.XDataGridBoolColumn1.Width = 75
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Tipo Documento"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = True
        Me.XEditTextBoxColumn3.MappingName = "type_name"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.TabStop = True
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 150
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Número"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = True
        Me.XEditTextBoxColumn1.MappingName = "paym_number"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 80
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Fecha"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = True
        Me.XEditTextBoxColumn2.MappingName = "invce_date"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 80
        '
        'XEditTextBoxColumn4
        '
        Me.XEditTextBoxColumn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn4.Format = ""
        Me.XEditTextBoxColumn4.FormatInfo = Nothing
        Me.XEditTextBoxColumn4.HeaderText = "Cliente"
        Me.XEditTextBoxColumn4.ImageList = Nothing
        Me.XEditTextBoxColumn4.isReadOnly = True
        Me.XEditTextBoxColumn4.MappingName = "cust_name"
        Me.XEditTextBoxColumn4.MaxLength = 32767
        Me.XEditTextBoxColumn4.TabStop = True
        Me.XEditTextBoxColumn4.UseCustomCellFormat = False
        Me.XEditTextBoxColumn4.Width = 250
        '
        'XEditTextBoxColumn6
        '
        Me.XEditTextBoxColumn6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn6.Format = ""
        Me.XEditTextBoxColumn6.FormatInfo = Nothing
        Me.XEditTextBoxColumn6.HeaderText = "Usuario"
        Me.XEditTextBoxColumn6.ImageList = Nothing
        Me.XEditTextBoxColumn6.isReadOnly = True
        Me.XEditTextBoxColumn6.MappingName = "userid"
        Me.XEditTextBoxColumn6.MaxLength = 32767
        Me.XEditTextBoxColumn6.TabStop = True
        Me.XEditTextBoxColumn6.UseCustomCellFormat = False
        Me.XEditTextBoxColumn6.Width = 75
        '
        'gcolmonto
        '
        Me.gcolmonto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gcolmonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolmonto.Format = "##,###,##0.00"
        Me.gcolmonto.FormatInfo = Nothing
        Me.gcolmonto.HeaderText = "Monto i"
        Me.gcolmonto.ImageList = Nothing
        Me.gcolmonto.isReadOnly = False
        Me.gcolmonto.MappingName = "total_amount"
        Me.gcolmonto.MaxLength = 32767
        Me.gcolmonto.TabStop = True
        Me.gcolmonto.UseCustomCellFormat = False
        Me.gcolmonto.Width = 85
        '
        'gColTipo
        '
        Me.gColTipo.Format = ""
        Me.gColTipo.FormatInfo = Nothing
        Me.gColTipo.MappingName = "type_code"
        Me.gColTipo.Width = 0
        '
        'DataView1
        '
        Me.DataView1.AllowDelete = False
        Me.DataView1.AllowNew = False
        '
        'btnAplicar
        '
        Me.btnAplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAplicar.Enabled = False
        Me.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAplicar.Location = New System.Drawing.Point(696, 520)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(80, 32)
        Me.btnAplicar.TabIndex = 10
        Me.btnAplicar.Text = "Aplicar"
        '
        'btnTodos
        '
        Me.btnTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTodos.Location = New System.Drawing.Point(696, 72)
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.Size = New System.Drawing.Size(80, 24)
        Me.btnTodos.TabIndex = 10
        Me.btnTodos.Text = "Todos"
        Me.btnTodos.Visible = False
        '
        'p_ccpaym01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(898, 560)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDetail)
        Me.Controls.Add(Me.btnUnmarkall)
        Me.Controls.Add(Me.btnMarkAll)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.btnTodos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "p_ccpaym01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Aplicar Recibos de Imgresos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MarcarTodos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAll.Click
        For Each oRow As DataRow In DataSet1.Tables("ccpaymm").Rows
            oRow!Aplicar = 1
        Next

    End Sub

    Private Sub DesmarcarTodos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnmarkall.Click
        For Each oRow As DataRow In DataSet1.Tables("ccpaymm").Rows
            oRow!Aplicar = 0
        Next
    End Sub

    Private Sub Postear()
        Dim oParamPost As SGT.CXC.Posteos.PostDocument.ParametrosAplicar
        Dim oPost As SGT.CXC.Posteos.PostDocument
        Dim oTransacion As SGT.ControlBancario.Entidades.TipoDocumento

        Dim SelectStmt As String
        Dim rNumero As Integer
        ''Dim cNfng As Integer
        Dim XUpdate As LibX.Data.XUpdateStmt
        Try
            If MessageBox.Show("Seguro desea aplicar?", "Aplicar documentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Throw New ApplicationException("Operación Abortada!")
            End If

            oParamPost = New PostDocument.ParametrosAplicar
            oPost = New PostDocument
            rNumero = DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex)!paym_number
            If (DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex)!type_code = "RSM" Or DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex)!type_code = "DCC" Or _
              DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex)!type_code = "RPS") And Not LibX.IsNull(DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex)!vend_code) Then
                oTransacion = New SGT.ControlBancario.Entidades.TipoDocumento(DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex)!type_code, DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex)!chequera)
                If LibX.Data.Manager.Connection.IsIntransaction = False Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                End If
                rNumero = oTransacion.GenerateNumber(DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex)!type_code, DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex)!chequera)
            End If
            If (DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex)!type_code = "RSM" Or DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex)!type_code = "DCC" Or _
                     DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex)!type_code = "RPS") And rNumero = 0 Then
                Throw New ApplicationException("No se asigno el numero del documento")
            End If

            For Each oRow As DataRow In DataSet1.Tables("ccpaymm").Select("aplicar=1")

                If LibX.Data.Manager.Connection.IsIntransaction = False Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                End If
                XUpdate = New LibX.Data.XUpdateStmt("ccpaymm")
                XUpdate.FieldsSet("invce_status") = 3
                If rNumero > 0 Then
                    XUpdate.FieldsSet("paym_number") = rNumero
                    XUpdate.FieldsSet("vend_code") = DBNull.Value
                    XUpdate.FieldsSet("invce_date") = LibX.Data.Manager.GetScalar("select getdate()")
                End If
                XUpdate.FieldsSet("invce_datetran") = LibX.Data.Manager.GetScalar("select getdate()")
                XUpdate.Fields("paym_serial") = oRow!paym_serial

                XUpdate.Execute()

                XUpdate = New LibX.Data.XUpdateStmt("ccpaymd")
                XUpdate.FieldsSet("paym_status") = 3
                XUpdate.Fields("paym_serial") = oRow!paym_serial

                XUpdate.Execute()

                '// Postear a Cuentas x Cobrar
                With oParamPost
                    .Serial = oRow!paym_serial
                    If rNumero > 0 Then
                        .Numero = rNumero
                        .Fecha = LibX.Data.Manager.GetScalar("select getdate()")
                    Else
                        .Numero = Val(oRow!paym_number.ToString)
                        .Fecha = oRow!invce_date
                    End If
                    .Cliente = Val(oRow!cust_code.ToString)
                    .TipoDocumento = oRow!type_code.ToString
                    .Impuesto = Val(oRow!itbis.ToString)
                    .Descuento = Val(oRow!cargo_desc.ToString)
                    .Monto = Val(oRow!total_amount.ToString)
                    .PagoPorAdelantado = False
                    .Termino = oRow!term_code.ToString
                    .SucCode = oRow!suc_code
                    .UseTransaction = False
                End With

                oPost.AplicarCXC(oParamPost)

                DataSet1.Tables("ccpaymm").Rows.Remove(oRow)
            Next

            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
        End Try

    End Sub

    Private Sub p_iventr01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.xdt_invce_date.Value = DBNull.Value
            Me.xdt_due_date.Value = DBNull.Value
            Me.xcbo_type_code.LoadDbItems(True)
            Me.LibXGrid1.footerOperations.add("Aplicar", "count(Aplicar)", "1=1")
            Me.LibXGrid1.footerOperations.add("type_code", "count(type_code)", "Aplicar=1")

            btnRefresh_Click(sender, e)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        '// No mostrar la advertencia de cancelar
        LibXConnector1.ShowWarningCancel = False

        '// Cancelar cualquier accion
        LibXConnector1.Cancel()

        '// Refrescar la busqueda
        LibXConnector1.AcceptFind()

        If LibXConnector1.HasRecords = True Then
            LibXConnector1.Edit()
        End If
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        DesmarcarTodos(sender, e)
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        MarcarTodos(sender, e)
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        btnRefresh_Click(sender, e)
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex).BeginEdit()
        DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1
        DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex).EndEdit()
        Postear()

    End Sub
    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            e.AditionalWhere = "1=1"

            '// Tipo de Documento
            If Me.xcbo_type_code.currValue.ToString.Trim <> "" Then
                e.AditionalWhere &= " and ccpaymm.type_code ='" & Me.xcbo_type_code.currValue.trim & "'"
            End If

            '// Numero de documento
            If Me.xtxt_paym_number.Text.Length <> 0 Then
                e.AditionalWhere &= " and ccpaymm.paym_number =" & Me.xtxt_paym_number.Text.Trim
            End If

            '// Numero de documento
            If Not LibX.IsNull(xdt_due_date.Value) Then
                e.AditionalWhere &= " and ccpaymm.due_date =" & Me.xdt_due_date.Text.Trim
            End If

            '// Fecha
            If Not LibX.IsNull(xdt_invce_date.Value) Then
                e.AditionalWhere &= " and ccpaymm.invce_date ='" & Me.xdt_invce_date.Value & "'"
            End If

            '// Cliente
            If Me.xtxt_cust_code.Text.Length <> 0 Then
                e.AditionalWhere &= " and ccpaymm.cust_code =" & Me.xtxt_cust_code.Text.Trim
            End If

            '// Estatus
            e.AditionalWhere &= " and invce_status = 2"
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodos.Click
        Try
            Me.xcbo_type_code.currValue = DBNull.Value
            Me.xdt_due_date.Value = DBNull.Value
            Me.xdt_invce_date.Value = DBNull.Value
            Me.xtxt_cust_code.Text = ""
            Me.xtxt_paym_number.Text = ""
            Me.lblcust_name.Text = ""

            '// Refrescar
            btnRefresh_Click(sender, e)
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click
        DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex).BeginEdit()
        DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1
        DataSet1.Tables("ccpaymm").Rows(LibXGrid1.CurrentRowIndex).EndEdit()
        Postear()
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Me.btnMarkAll.Enabled = LibXConnector1.HasRecords = True
        Me.btnUnmarkall.Enabled = LibXConnector1.HasRecords = True
        Me.btnDetail.Enabled = LibXConnector1.HasRecords = True
        Me.btnAplicar.Enabled = LibXConnector1.HasRecords = True
    End Sub

End Class
