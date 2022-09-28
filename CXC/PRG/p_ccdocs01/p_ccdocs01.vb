Imports SGT.Inventario.Common
Imports SGT.CXC.Posteos
Imports System.Configuration.ConfigurationSettings

Public Class p_ccdocs01
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
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents XDataGridBoolColumn1 As LibX.XDataGridBoolColumn
    Friend WithEvents ccinvcem As System.Data.DataTable
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblcust_name As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents xtxt_invce_no As LibX.XTextBox
    Friend WithEvents xdt_invce_date As LibX.LibxDateTimePicker
    Friend WithEvents xcbo_type_code As LibX.LibXCombo
    Friend WithEvents xdt_due_date As LibX.LibxDateTimePicker
    Friend WithEvents xtxt_cust_code As LibX.XTextBox
    Friend WithEvents btnTodos As System.Windows.Forms.Button
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ccinvcem = New System.Data.DataTable
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
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.lblcust_name = New System.Windows.Forms.Label
        Me.xtxt_invce_no = New LibX.XTextBox
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
        CType(Me.ccinvcem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.lblcust_name)
        Me.GroupBox1.Controls.Add(Me.xtxt_invce_no)
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
        Me.LibXConnector1.DataMember = "ccinvcem"
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
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ccinvcem})
        '
        'ccinvcem
        '
        Me.ccinvcem.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28})
        Me.ccinvcem.TableName = "ccinvcem"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "invce_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "type_code"
        Me.DataColumn2.MaxLength = 3
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "type_name"
        Me.DataColumn3.MaxLength = 30
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "invce_no"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "invce_date"
        Me.DataColumn5.DataType = GetType(System.DateTime)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "cust_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "cust_name"
        Me.DataColumn7.MaxLength = 60
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "total_amount"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Aplicar"
        Me.DataColumn9.DataType = GetType(System.Int16)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "term_code"
        Me.DataColumn10.MaxLength = 5
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "detail"
        Me.DataColumn11.MaxLength = 60
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "due_date"
        Me.DataColumn12.DataType = GetType(System.DateTime)
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "amount"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "itbis"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "amount_grab"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "amount_excent"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "cargo_banc"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "cargo_desc"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "excento"
        Me.DataColumn19.DataType = GetType(System.Decimal)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "impto"
        Me.DataColumn20.DataType = GetType(System.Decimal)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "invce_status"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "invce_ncf"
        Me.DataColumn22.MaxLength = 20
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "vend_code"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "cash_amount"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "card_amount"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "check_amount"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "type_code1"
        Me.DataColumn27.MaxLength = 3
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "chequera"
        Me.DataColumn28.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable3.SerialColumnName = "invce_serial"
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = New String() {"select ccinvcem.*, ", "       ccinvcem.type_code, ", "       ivtypem.[type_name], ", "       cccustm.cust_name ", "       from ccinvcem  ", "       inner join ivtypem  ", "       on ccinvcem.type_code = ivtypem.type_code  ", "       inner join cccustm ", "       on ccinvcem.cust_code = cccustm.cust_code ", "       where invce_status = 2 "}
        Me.LibXDbSourceTable3.TableName = "ccinvcem"
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
        'xtxt_invce_no
        '
        Me.xtxt_invce_no.AcceptsReturn = True
        Me.xtxt_invce_no.EditInitialValue = Nothing
        Me.xtxt_invce_no.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_invce_no.FieldDescription = ""
        Me.xtxt_invce_no.FindInitialValue = Nothing
        Me.xtxt_invce_no.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_invce_no.IgnoreRequiered = False
        Me.xtxt_invce_no.Location = New System.Drawing.Point(128, 48)
        Me.xtxt_invce_no.Name = "xtxt_invce_no"
        Me.xtxt_invce_no.NewInitialValue = Nothing
        Me.xtxt_invce_no.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_invce_no.Requiered = False
        Me.xtxt_invce_no.StatusBarPanelDescripcion = Nothing
        Me.xtxt_invce_no.TabIndex = 4
        Me.xtxt_invce_no.Text = ""
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
        Me.LibXGrid1.DataMember = "ccinvcem"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 120)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(768, 352)
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
        Me.XdataGridTableStyle1.MappingName = "ccinvcem"
        '
        'XDataGridBoolColumn1
        '
        Me.XDataGridBoolColumn1.FalseValue = CType(0, Short)
        Me.XDataGridBoolColumn1.HeaderText = "Aplicar"
        Me.XDataGridBoolColumn1.MappingName = "Aplicar"
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
        Me.XEditTextBoxColumn1.MappingName = "invce_no"
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
        Me.gcolmonto.Format = "##,###.##"
        Me.gcolmonto.FormatInfo = Nothing
        Me.gcolmonto.HeaderText = "Montoi"
        Me.gcolmonto.ImageList = Nothing
        Me.gcolmonto.isReadOnly = False
        Me.gcolmonto.MappingName = "amount"
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
        Me.DataView1.Table = Me.ccinvcem
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
        '
        'p_ccdocs01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(786, 560)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDetail)
        Me.Controls.Add(Me.btnUnmarkall)
        Me.Controls.Add(Me.btnMarkAll)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.btnTodos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "p_ccdocs01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Aplicar Documentos de CXC"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccinvcem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MarcarTodos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAll.Click
        For Each oRow As DataRow In DataSet1.Tables("ccinvcem").Rows
            oRow!Aplicar = 1
        Next

    End Sub

    Private Sub DesmarcarTodos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnmarkall.Click
        For Each oRow As DataRow In DataSet1.Tables("ccinvcem").Rows
            oRow!Aplicar = 0
        Next
    End Sub

    Private Sub Postear()
        Dim oParamPost As SGT.CXC.Posteos.PostDocument.ParametrosAplicar
        Dim oPost As SGT.CXC.Posteos.PostDocument

        Dim SelectStmt As String
        Dim oiventrdd As DataTable
        Dim oiventrdm As DataTable
        Dim OnHand As Int16
        Dim XUpdate As LibX.Data.XUpdateStmt
        Try
            If MessageBox.Show("Seguro desea aplicar?", "Aplicar documentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Throw New ApplicationException("Operación Abortada!")
            End If

            oParamPost = New PostDocument.ParametrosAplicar
            oPost = New PostDocument

            For Each oRow As DataRow In DataSet1.Tables("ccinvcem").Select("aplicar=1")
                '// Postear a inventario
                With oParamPost
                    .Serial = oRow!invce_serial
                    .Fecha = oRow!invce_date
                    .Numero = Val(oRow!invce_no.ToString)
                    .Cliente = Val(oRow!cust_code.ToString)
                    .TipoDocumento = oRow!type_code.ToString
                    .Impuesto = Val(oRow!itbis.ToString)
                    .Descuento = Val(oRow!cargo_desc.ToString)
                    .Monto = Val(oRow!amount.ToString)
                    .PagoPorAdelantado = False
                    .Termino = oRow!term_code.ToString
                    .SucCode = oRow!suc_code
                    .UseTransaction = False
                End With

                oPost.AplicarCXC(oParamPost)

                XUpdate = New LibX.Data.XUpdateStmt("ccinvcem")
                XUpdate.FieldsSet("invce_status") = 1 'Aplicada
                XUpdate.Fields("invce_serial") = oRow!invce_serial

                XUpdate.Execute()
                DataSet1.Tables("ccinvcem").Rows.Remove(oRow)
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
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
        DataSet1.Tables("ccinvcem").Rows(LibXGrid1.CurrentRowIndex).BeginEdit()
        DataSet1.Tables("ccinvcem").Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1
        DataSet1.Tables("ccinvcem").Rows(LibXGrid1.CurrentRowIndex).EndEdit()
        Postear()

    End Sub


    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            e.AditionalWhere = "1=1"

            '// Tipo de Documento
            If Me.xcbo_type_code.currValue.ToString.Trim <> "" Then
                e.AditionalWhere &= " and ccinvcem.type_code ='" & Me.xcbo_type_code.currValue.trim & "'"
            End If

            '// Numero de documento
            If Me.xtxt_invce_no.Text.Length <> 0 Then
                e.AditionalWhere &= " and ccinvcem.invce_no =" & Me.xtxt_invce_no.Text.Trim
            End If

            '// Numero de documento
            If Not LibX.IsNull(xdt_due_date.Value) Then
                e.AditionalWhere &= " and ccinvcem.due_date =" & Me.xdt_due_date.Text.Trim
            End If

            '// Fecha
            If Not LibX.IsNull(xdt_invce_date.Value) Then
                e.AditionalWhere &= " and ccinvcem.invce_date ='" & Me.xdt_invce_date.Value & "'"
            End If

            '// Cliente
            If Me.xtxt_cust_code.Text.Length <> 0 Then
                e.AditionalWhere &= " and ccinvcem.cust_code =" & Me.xtxt_cust_code.Text.Trim
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
            Me.xtxt_invce_no.Text = ""
            Me.lblcust_name.Text = ""

            '// Refrescar
            btnRefresh_Click(sender, e)
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click
        DataSet1.Tables("ccinvcem").Rows(LibXGrid1.CurrentRowIndex).BeginEdit()
        DataSet1.Tables("ccinvcem").Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1
        DataSet1.Tables("ccinvcem").Rows(LibXGrid1.CurrentRowIndex).EndEdit()
        Postear()
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Me.btnMarkAll.Enabled = LibXConnector1.HasRecords = True
        Me.btnUnmarkall.Enabled = LibXConnector1.HasRecords = True
        Me.btnDetail.Enabled = LibXConnector1.HasRecords = True
        Me.btnAplicar.Enabled = LibXConnector1.HasRecords = True

    End Sub

End Class
