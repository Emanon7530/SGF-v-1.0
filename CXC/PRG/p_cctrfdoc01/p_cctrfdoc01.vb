Imports SGT.Inventario.Common
Imports SGT.CXC.Posteos
Imports System.Configuration.ConfigurationSettings

Public Class p_cctrfdoc01
    Inherits System.Windows.Forms.Form

    Dim oSiac As Integer

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
    Friend WithEvents ccinvcem As System.Data.DataTable
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblcust_name As System.Windows.Forms.Label
    Friend WithEvents xtxt_cust_code As LibX.XTextBox
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents xdt_FechaInicial As LibX.LibxDateTimePicker
    Friend WithEvents xlk_cust_dest As LibX.LibXLookup
    Friend WithEvents xtxt_cust_dest As LibX.XTextBox
    Friend WithEvents lblcust_dest As System.Windows.Forms.Label
    Friend WithEvents xdt_FechaFinal As LibX.LibxDateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents xlk_cust_code_orig As LibX.LibXLookup
    Friend WithEvents XD_aplicar As LibX.XDataGridBoolColumn
    Friend WithEvents XEditTe_tipo As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTe_numero As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTe_fecha As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTe_cliente As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTe_usuario As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.xdt_FechaInicial = New LibX.LibxDateTimePicker
        Me.xlk_cust_code_orig = New LibX.LibXLookup
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
        Me.DataColumn29 = New System.Data.DataColumn
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.lblcust_name = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.xtxt_cust_code = New LibX.XTextBox
        Me.xlk_cust_dest = New LibX.LibXLookup
        Me.Label1 = New System.Windows.Forms.Label
        Me.xtxt_cust_dest = New LibX.XTextBox
        Me.lblcust_dest = New System.Windows.Forms.Label
        Me.xdt_FechaFinal = New LibX.LibxDateTimePicker
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
        Me.XD_aplicar = New LibX.XDataGridBoolColumn
        Me.XEditTe_tipo = New LibX.XEditTextBoxColumn
        Me.XEditTe_numero = New LibX.XEditTextBoxColumn
        Me.XEditTe_fecha = New LibX.XEditTextBoxColumn
        Me.XEditTe_cliente = New LibX.XEditTextBoxColumn
        Me.XEditTe_usuario = New LibX.XEditTextBoxColumn
        Me.gcolmonto = New LibX.XEditTextBoxColumn
        Me.gColTipo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataView1 = New System.Data.DataView
        Me.btnAplicar = New System.Windows.Forms.Button
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
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaInicial)
        Me.GroupBox1.Controls.Add(Me.xlk_cust_code_orig)
        Me.GroupBox1.Controls.Add(Me.lblcust_name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xtxt_cust_code)
        Me.GroupBox1.Controls.Add(Me.xlk_cust_dest)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xtxt_cust_dest)
        Me.GroupBox1.Controls.Add(Me.lblcust_dest)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaFinal)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 104)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(456, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha Final:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha Inicial:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xdt_FechaInicial
        '
        Me.xdt_FechaInicial.CustomFormat = "dd/MM/yyyy"
        Me.xdt_FechaInicial.EditInitialValue = Nothing
        Me.xdt_FechaInicial.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicial.FieldDescription = ""
        Me.xdt_FechaInicial.FindInitialValue = Nothing
        Me.xdt_FechaInicial.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaInicial.IgnoreRequiered = False
        Me.xdt_FechaInicial.Location = New System.Drawing.Point(104, 72)
        Me.xdt_FechaInicial.Name = "xdt_FechaInicial"
        Me.xdt_FechaInicial.NewInitialValue = Nothing
        Me.xdt_FechaInicial.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicial.Requiered = False
        Me.xdt_FechaInicial.Size = New System.Drawing.Size(121, 20)
        Me.xdt_FechaInicial.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaInicial.TabIndex = 7
        '
        'xlk_cust_code_orig
        '
        Me.xlk_cust_code_orig.AlternateFieldSearch = Nothing
        Me.xlk_cust_code_orig.BeginCheck = False
        Me.xlk_cust_code_orig.CheckText = Nothing
        Me.xlk_cust_code_orig.ComboMode = False
        Me.xlk_cust_code_orig.DataMember = Nothing
        Me.xlk_cust_code_orig.DataSource = Me.LibXConnector1
        Me.xlk_cust_code_orig.DestParameters = New String() {"xtxt_cust_code=cust_code", "lblcust_name=cust_name"}
        Me.xlk_cust_code_orig.FilterField = "cust_name"
        Me.xlk_cust_code_orig.IgnoreFindInBrowseMode = False
        Me.xlk_cust_code_orig.isCanceled = False
        Me.xlk_cust_code_orig.Location = New System.Drawing.Point(632, 24)
        Me.xlk_cust_code_orig.LookCaption = "Clientes"
        Me.xlk_cust_code_orig.Name = "xlk_cust_code_orig"
        Me.xlk_cust_code_orig.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_cust_code_orig.ShowFilter = True
        Me.xlk_cust_code_orig.ShowMessageNotFound = True
        Me.xlk_cust_code_orig.ShowWarning = False
        Me.xlk_cust_code_orig.Size = New System.Drawing.Size(16, 20)
        Me.xlk_cust_code_orig.SizesColumns = Nothing
        Me.xlk_cust_code_orig.SizesColumnsTab = Nothing
        Me.xlk_cust_code_orig.SqlString = Nothing
        Me.xlk_cust_code_orig.SQLTab = New String() {Nothing}
        Me.xlk_cust_code_orig.SrcParameters = New String() {"xtxt_cust_code=cust_code"}
        Me.xlk_cust_code_orig.TabIndex = 6
        Me.xlk_cust_code_orig.TableName = "cccustm"
        Me.xlk_cust_code_orig.TabStop = False
        Me.xlk_cust_code_orig.UseCopyConnection = False
        Me.xlk_cust_code_orig.UseRowRetrieveEvents = False
        Me.xlk_cust_code_orig.UseTab = False
        Me.xlk_cust_code_orig.VisParameters = New String() {"Codigo=cust_code", "Nombre=cust_name"}
        Me.xlk_cust_code_orig.WhereCondition = "cust_credito = 1"
        Me.xlk_cust_code_orig.WhereParameters = ""
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
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ccinvcem})
        '
        'ccinvcem
        '
        Me.ccinvcem.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31})
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
        Me.DataColumn7.MaxLength = 100
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
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "suc_code"
        Me.DataColumn29.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable3.Source = New String() {"select ccinvcem.*, ", "       ccinvcem.type_code, ", "       ivtypem.[type_name], ", "       cccustm.cust_name ", "       from ccinvcem  ", "       inner join ivtypem  ", "       on ccinvcem.type_code = ivtypem.type_code  ", "       inner join cccustm ", "       on ccinvcem.cust_code = cccustm.cust_code ", "       where invce_status = 1"}
        Me.LibXDbSourceTable3.TableName = "ccinvcem"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "invce_datetran"
        Me.DataColumn30.DataType = GetType(System.DateTime)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "invce_create"
        Me.DataColumn31.DataType = GetType(System.DateTime)
        '
        'lblcust_name
        '
        Me.lblcust_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcust_name.Location = New System.Drawing.Point(168, 24)
        Me.lblcust_name.Name = "lblcust_name"
        Me.lblcust_name.Size = New System.Drawing.Size(464, 20)
        Me.lblcust_name.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Cliente Origen:"
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
        Me.xtxt_cust_code.Location = New System.Drawing.Point(104, 24)
        Me.xtxt_cust_code.Name = "xtxt_cust_code"
        Me.xtxt_cust_code.NewInitialValue = Nothing
        Me.xtxt_cust_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cust_code.Requiered = False
        Me.xtxt_cust_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_cust_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_cust_code.TabIndex = 4
        Me.xtxt_cust_code.Text = ""
        '
        'xlk_cust_dest
        '
        Me.xlk_cust_dest.AlternateFieldSearch = Nothing
        Me.xlk_cust_dest.BeginCheck = False
        Me.xlk_cust_dest.CheckText = Nothing
        Me.xlk_cust_dest.ComboMode = False
        Me.xlk_cust_dest.DataMember = Nothing
        Me.xlk_cust_dest.DataSource = Me.LibXConnector1
        Me.xlk_cust_dest.DestParameters = New String() {"xtxt_cust_dest=cust_code", "lblcust_dest=cust_name"}
        Me.xlk_cust_dest.FilterField = "cust_name"
        Me.xlk_cust_dest.IgnoreFindInBrowseMode = False
        Me.xlk_cust_dest.isCanceled = False
        Me.xlk_cust_dest.Location = New System.Drawing.Point(632, 48)
        Me.xlk_cust_dest.LookCaption = "Clientes"
        Me.xlk_cust_dest.Name = "xlk_cust_dest"
        Me.xlk_cust_dest.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_cust_dest.ShowFilter = True
        Me.xlk_cust_dest.ShowMessageNotFound = True
        Me.xlk_cust_dest.ShowWarning = False
        Me.xlk_cust_dest.Size = New System.Drawing.Size(16, 20)
        Me.xlk_cust_dest.SizesColumns = Nothing
        Me.xlk_cust_dest.SizesColumnsTab = Nothing
        Me.xlk_cust_dest.SqlString = Nothing
        Me.xlk_cust_dest.SQLTab = Nothing
        Me.xlk_cust_dest.SrcParameters = New String() {"xtxt_cust_dest=cust_code"}
        Me.xlk_cust_dest.TabIndex = 6
        Me.xlk_cust_dest.TableName = "cccustm"
        Me.xlk_cust_dest.TabStop = False
        Me.xlk_cust_dest.UseCopyConnection = False
        Me.xlk_cust_dest.UseRowRetrieveEvents = False
        Me.xlk_cust_dest.UseTab = False
        Me.xlk_cust_dest.VisParameters = New String() {"Codigo=cust_code", "Nombre=cust_name"}
        Me.xlk_cust_dest.WhereCondition = "cust_credito = 1"
        Me.xlk_cust_dest.WhereParameters = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente Destino:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_cust_dest
        '
        Me.xtxt_cust_dest.AcceptsReturn = True
        Me.xtxt_cust_dest.EditInitialValue = Nothing
        Me.xtxt_cust_dest.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cust_dest.FieldDescription = ""
        Me.xtxt_cust_dest.FindInitialValue = Nothing
        Me.xtxt_cust_dest.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cust_dest.IgnoreRequiered = False
        Me.xtxt_cust_dest.Location = New System.Drawing.Point(104, 48)
        Me.xtxt_cust_dest.Name = "xtxt_cust_dest"
        Me.xtxt_cust_dest.NewInitialValue = Nothing
        Me.xtxt_cust_dest.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cust_dest.Requiered = False
        Me.xtxt_cust_dest.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_cust_dest.StatusBarPanelDescripcion = Nothing
        Me.xtxt_cust_dest.TabIndex = 4
        Me.xtxt_cust_dest.Text = ""
        '
        'lblcust_dest
        '
        Me.lblcust_dest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcust_dest.Location = New System.Drawing.Point(168, 48)
        Me.lblcust_dest.Name = "lblcust_dest"
        Me.lblcust_dest.Size = New System.Drawing.Size(464, 20)
        Me.lblcust_dest.TabIndex = 5
        '
        'xdt_FechaFinal
        '
        Me.xdt_FechaFinal.CustomFormat = "dd/MM/yyyy"
        Me.xdt_FechaFinal.EditInitialValue = Nothing
        Me.xdt_FechaFinal.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.FieldDescription = ""
        Me.xdt_FechaFinal.FindInitialValue = Nothing
        Me.xdt_FechaFinal.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaFinal.IgnoreRequiered = False
        Me.xdt_FechaFinal.Location = New System.Drawing.Point(528, 72)
        Me.xdt_FechaFinal.Name = "xdt_FechaFinal"
        Me.xdt_FechaFinal.NewInitialValue = Nothing
        Me.xdt_FechaFinal.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.Requiered = False
        Me.xdt_FechaFinal.Size = New System.Drawing.Size(121, 20)
        Me.xdt_FechaFinal.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaFinal.TabIndex = 7
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
        Me.btnRefresh.Enabled = False
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Location = New System.Drawing.Point(696, 88)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 24)
        Me.btnRefresh.TabIndex = 10
        Me.btnRefresh.Text = "Buscar"
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
        Me.LibXGrid1.Location = New System.Drawing.Point(-16, 128)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(768, 360)
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
        Me.MenuItem7.Text = "Transferir"
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XD_aplicar, Me.XEditTe_tipo, Me.XEditTe_numero, Me.XEditTe_fecha, Me.XEditTe_cliente, Me.XEditTe_usuario, Me.gcolmonto, Me.gColTipo})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ccinvcem"
        '
        'XD_aplicar
        '
        Me.XD_aplicar.FalseValue = CType(0, Short)
        Me.XD_aplicar.HeaderText = "Aplicar"
        Me.XD_aplicar.MappingName = "Aplicar"
        Me.XD_aplicar.NullValue = 0
        Me.XD_aplicar.TrueValue = CType(1, Short)
        Me.XD_aplicar.UseCustomCellFormat = False
        Me.XD_aplicar.Width = 45
        '
        'XEditTe_tipo
        '
        Me.XEditTe_tipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTe_tipo.Format = ""
        Me.XEditTe_tipo.FormatInfo = Nothing
        Me.XEditTe_tipo.HeaderText = "Tipo Documento"
        Me.XEditTe_tipo.ImageList = Nothing
        Me.XEditTe_tipo.isReadOnly = True
        Me.XEditTe_tipo.MappingName = "type_name"
        Me.XEditTe_tipo.MaxLength = 32767
        Me.XEditTe_tipo.TabStop = True
        Me.XEditTe_tipo.UseCustomCellFormat = False
        Me.XEditTe_tipo.Width = 75
        '
        'XEditTe_numero
        '
        Me.XEditTe_numero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTe_numero.Format = ""
        Me.XEditTe_numero.FormatInfo = Nothing
        Me.XEditTe_numero.HeaderText = "Número"
        Me.XEditTe_numero.ImageList = Nothing
        Me.XEditTe_numero.isReadOnly = True
        Me.XEditTe_numero.MappingName = "invce_no"
        Me.XEditTe_numero.MaxLength = 32767
        Me.XEditTe_numero.TabStop = True
        Me.XEditTe_numero.UseCustomCellFormat = False
        Me.XEditTe_numero.Width = 80
        '
        'XEditTe_fecha
        '
        Me.XEditTe_fecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTe_fecha.Format = ""
        Me.XEditTe_fecha.FormatInfo = Nothing
        Me.XEditTe_fecha.HeaderText = "Fecha"
        Me.XEditTe_fecha.ImageList = Nothing
        Me.XEditTe_fecha.isReadOnly = True
        Me.XEditTe_fecha.MappingName = "invce_date"
        Me.XEditTe_fecha.MaxLength = 32767
        Me.XEditTe_fecha.TabStop = True
        Me.XEditTe_fecha.UseCustomCellFormat = False
        Me.XEditTe_fecha.Width = 80
        '
        'XEditTe_cliente
        '
        Me.XEditTe_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTe_cliente.Format = ""
        Me.XEditTe_cliente.FormatInfo = Nothing
        Me.XEditTe_cliente.HeaderText = "Cliente"
        Me.XEditTe_cliente.ImageList = Nothing
        Me.XEditTe_cliente.isReadOnly = True
        Me.XEditTe_cliente.MappingName = "cust_name"
        Me.XEditTe_cliente.MaxLength = 32767
        Me.XEditTe_cliente.TabStop = True
        Me.XEditTe_cliente.UseCustomCellFormat = False
        Me.XEditTe_cliente.Width = 250
        '
        'XEditTe_usuario
        '
        Me.XEditTe_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTe_usuario.Format = ""
        Me.XEditTe_usuario.FormatInfo = Nothing
        Me.XEditTe_usuario.HeaderText = "Usuario"
        Me.XEditTe_usuario.ImageList = Nothing
        Me.XEditTe_usuario.isReadOnly = True
        Me.XEditTe_usuario.MappingName = "userid"
        Me.XEditTe_usuario.MaxLength = 32767
        Me.XEditTe_usuario.TabStop = True
        Me.XEditTe_usuario.UseCustomCellFormat = False
        Me.XEditTe_usuario.Width = 75
        '
        'gcolmonto
        '
        Me.gcolmonto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gcolmonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolmonto.Format = "#,###,###.00"
        Me.gcolmonto.FormatInfo = Nothing
        Me.gcolmonto.HeaderText = "Montoi"
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
        Me.btnAplicar.Text = "Transferir"
        '
        'p_cctrfdoc01
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "p_cctrfdoc01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Transferir Facturas"
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
        Dim Oserial As DataRow
        Dim ftSerial As Integer
        Dim planSerial As Integer
        Dim ciaSerial As Integer
        Dim aseSerial As Integer
        Dim asePoliza As String
        Dim cstype As Integer
        Try
            If MessageBox.Show("Seguro desea Transferir?", "Transferir documentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
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
                    .Cliente = Val(Me.xtxt_cust_dest.Text.Trim)
                    .ClienteOrigen = Val(oRow!cust_code.ToString)
                    .TipoDocumento = oRow!type_code.ToString
                    .Descuento = 0
                    .Impuesto = Val(oRow!itbis.ToString)
                    .Monto = Val(oRow!total_amount.ToString)
                    .PagoPorAdelantado = False
                    .Termino = oRow!term_code.ToString
                    .SucCode = oRow!suc_code
                    .UseTransaction = False
                End With
                cstype = LibX.Data.Manager.GetScalar("select csttype_code from cccustm where cust_code = " & Val(oRow!cust_code.ToString))
                If oRow!type_code = "FSG" And cstype = 5 Then
                    ftSerial = LibX.Data.Manager.GetScalar("select ftserial_no from ftfactm where fact_number =" & oRow!invce_no & " and type_code ='FSG'")
                    ciaSerial = LibX.Data.Manager.GetScalar("select cia_serial from sgciasm where cust_code = " & Me.xtxt_cust_dest.Text)
                    planSerial = LibX.Data.Manager.GetScalar("select plan_serial from sgplanm where cust_code = " & Me.xtxt_cust_dest.Text & " and cia_serial = " & ciaSerial)
                    asePoliza = LibX.Data.Manager.GetScalar("select aseg_poliza from ftsegrm where ftserial_no = " & ftSerial)
                    aseSerial = LibX.Data.Manager.GetScalar("select aseg_serial from sgasegm where aseg_poliza = '" & asePoliza & "'")

                    XUpdate = New LibX.Data.XUpdateStmt("ccinvcem")
                    XUpdate.FieldsSet("invce_status") = 4
                    XUpdate.Fields("invce_serial") = oRow!invce_serial
                    XUpdate.Execute()

                    XUpdate = New LibX.Data.XUpdateStmt("ftsegrm")
                    XUpdate.FieldsSet("cia_serial") = ciaSerial
                    XUpdate.FieldsSet("plan_serial") = planSerial
                    XUpdate.Fields("ftserial_no") = ftSerial
                    XUpdate.Execute()

                    XUpdate = New LibX.Data.XUpdateStmt("cjtranrm")
                    XUpdate.FieldsSet("cust_seg") = Val(Me.xtxt_cust_dest.Text)
                    XUpdate.Fields("ftserial_no") = ftSerial
                    XUpdate.Execute()

                    XUpdate = New LibX.Data.XUpdateStmt("sgasegm")
                    XUpdate.FieldsSet("cia_serial") = ciaSerial
                    XUpdate.FieldsSet("plan_serial") = planSerial
                    XUpdate.Fields("aseg_serial") = aseSerial
                    XUpdate.Execute()
                End If

                oPost.TransferirFacturas(oParamPost)
                DataSet1.Tables("ccinvcem").Rows.Remove(oRow)
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub p_iventr01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LibXConnector1.Find()
            Me.LibXGrid1.footerOperations.add("Aplicar", "count(Aplicar)", "1=1")
            Me.LibXGrid1.footerOperations.add("type_code", "count(type_code)", "Aplicar=1")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        'LibXConnector1.AcceptFind()
        If LibXConnector1.HasRecords = True Then
            LibXConnector1.Edit()
        Else
            LibXConnector1.Find()
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

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DataSet1.Tables("ccinvcem").Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1
        Postear()
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            e.Sql = e.Sql.ToString.Trim.Replace("ccinvcem.Aplicar = 0", "1=1")

            e.AditionalWhere = "1=1"

            ''// Numero de documento
            If Not LibX.IsNull(Me.xdt_FechaInicial.Value) And Not LibX.IsNull(Me.xdt_FechaFinal.Value) Then
                e.AditionalWhere &= " and ccinvcem.invce_date between '" & _
                                CDate(Me.xdt_FechaInicial.Value).ToString(LibX.Data.Manager.GetSaveDateFormat) & "' and '" & _
                                CDate(Me.xdt_FechaFinal.Value).ToString(LibX.Data.Manager.GetSaveDateFormat) & "'"
            End If

            '// Cliente
            If Me.xtxt_cust_code.Text.Length <> 0 Then
                e.AditionalWhere &= " and ccinvcem.cust_code =" & Me.xtxt_cust_code.Text.Trim
            End If

            e.AditionalWhere &= " and ccinvcem.type_code in ('FCT','FPV','FSG')"

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        If e.Action = LibX.LibxConnectionActions.Find _
        Or e.AcceptedAction = LibX.LibxConnectionActions.Find Then
            DataSet1.Tables(0).Rows.Clear()
            LibXGrid1.ReadOnly = True
        End If

        If e.Action = LibX.LibxConnectionActions.Edit Then
            LibXGrid1.ReadOnly = False
        End If

        If e.AcceptedAction = LibX.LibxConnectionActions.Edit And DataSet1.Tables("ccinvcem").Select("Aplicar=1").Length > 0 Then
            Postear()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Me.xcbo_type_code.currValue = DBNull.Value
            'Me.xdt_due_date.Value = DBNull.Value
            'Me.xdt_invce_date.Value = DBNull.Value
            'Me.xtxt_cust_code.Text = ""
            'Me.xtxt_invce_no.Text = ""
            'Me.lblcust_name.Text = ""

            '// Refrescar
            btnRefresh_Click(sender, e)
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click
        DataSet1.Tables("ccinvcem").Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1
        ''If DataSet1.Tables("ccinvcem").Rows(LibXGrid1.CurrentRowIndex)!type_code = "FSG" Then
        ''    oSiac = InputBox("Digite el codigo de la compañia de Seguro", "Aseguradora")
        ''End If
        Postear()
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Me.btnMarkAll.Enabled = LibXConnector1.HasRecords = True
        Me.btnUnmarkall.Enabled = LibXConnector1.HasRecords = True
        Me.btnDetail.Enabled = LibXConnector1.HasRecords = True
        Me.btnAplicar.Enabled = LibXConnector1.HasRecords = True
    End Sub

    Private Sub LibXConnector1_SettingDefaultqueryValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultQueryValues) Handles LibXConnector1.SettingDefaultqueryValues
        Me.xdt_FechaFinal.Value = DBNull.Value
        Me.xdt_FechaInicial.Value = DBNull.Value
    End Sub

    Private Sub LibXLookup1_AfterSetValues(ByVal sender As System.Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_cust_code_orig.AfterSetValues
        btnRefresh.Enabled = e.dataFound
    End Sub

    Private Sub xlk_cust_code_orig__AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_cust_code_orig.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If
            If LibXConnector1.State = LibX.LibxConnectorState.Query Then
                LibXConnector1.AcceptFind()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

End Class
