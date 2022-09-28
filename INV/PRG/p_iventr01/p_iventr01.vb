Imports SGT.Inventario.Common
Imports SGT.Inventario.Operaciones
Imports System.Configuration.ConfigurationSettings
Imports LibX

Public Class p_iventr01
    Inherits System.Windows.Forms.Form
    Dim oBloqueo As SGT.Inventario.Entidades.Ivbloqueo
    Dim Transf As Boolean

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents whse_name As System.Windows.Forms.TextBox
    Friend WithEvents prov_name As System.Windows.Forms.TextBox
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn4 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn5 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn6 As LibX.XEditTextBoxColumn
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents lblInternacionales As System.Windows.Forms.Label
    Friend WithEvents lblLocales As System.Windows.Forms.Label
    Friend WithEvents XEditTextBoxColumn7 As LibX.XEditTextBoxColumn
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
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnDetail As System.Windows.Forms.Button
    Friend WithEvents btnUnmarkall As System.Windows.Forms.Button
    Friend WithEvents btnMarkAll As System.Windows.Forms.Button
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents chk_internac As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Local As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents gColSerial As LibX.XEditTextBoxColumn
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
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents xtxt_entr_number As System.Windows.Forms.TextBox
    Friend WithEvents xdt_entr_date As LibX.LibxDateTimePicker
    Friend WithEvents xtxt_whse_code As System.Windows.Forms.TextBox
    Friend WithEvents xtxt_prov_code As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents xlk_whse_code As LibX.LibXLookup
    Friend WithEvents xlk_prov_code As LibX.LibXLookup
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xtxt_entr_number = New System.Windows.Forms.TextBox
        Me.xdt_entr_date = New LibX.LibxDateTimePicker
        Me.xlk_whse_code = New LibX.LibXLookup
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
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn63 = New System.Data.DataColumn
        Me.DataColumn65 = New System.Data.DataColumn
        Me.DataTable2 = New System.Data.DataTable
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
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.DataColumn61 = New System.Data.DataColumn
        Me.DataColumn62 = New System.Data.DataColumn
        Me.DataColumn64 = New System.Data.DataColumn
        Me.DataColumn66 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.whse_name = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.prov_name = New System.Windows.Forms.TextBox
        Me.xlk_prov_code = New LibX.LibXLookup
        Me.xtxt_whse_code = New System.Windows.Forms.TextBox
        Me.xtxt_prov_code = New System.Windows.Forms.TextBox
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnDetail = New System.Windows.Forms.Button
        Me.btnUnmarkall = New System.Windows.Forms.Button
        Me.btnMarkAll = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chk_internac = New System.Windows.Forms.CheckBox
        Me.chk_Local = New System.Windows.Forms.CheckBox
        Me.lblInternacionales = New System.Windows.Forms.Label
        Me.lblLocales = New System.Windows.Forms.Label
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn4 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn5 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn6 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn7 = New LibX.XEditTextBoxColumn
        Me.gColSerial = New LibX.XEditTextBoxColumn
        Me.DataView1 = New System.Data.DataView
        Me.btnAplicar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataColumn67 = New System.Data.DataColumn
        Me.DataColumn68 = New System.Data.DataColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xtxt_entr_number)
        Me.GroupBox1.Controls.Add(Me.xdt_entr_date)
        Me.GroupBox1.Controls.Add(Me.xlk_whse_code)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.whse_name)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.prov_name)
        Me.GroupBox1.Controls.Add(Me.xlk_prov_code)
        Me.GroupBox1.Controls.Add(Me.xtxt_whse_code)
        Me.GroupBox1.Controls.Add(Me.xtxt_prov_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 96)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio"
        '
        'xtxt_entr_number
        '
        Me.xtxt_entr_number.AcceptsReturn = True
        Me.xtxt_entr_number.Location = New System.Drawing.Point(88, 16)
        Me.xtxt_entr_number.Name = "xtxt_entr_number"
        Me.xtxt_entr_number.TabIndex = 0
        Me.xtxt_entr_number.Text = ""
        '
        'xdt_entr_date
        '
        Me.xdt_entr_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_entr_date.EditInitialValue = Nothing
        Me.xdt_entr_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_entr_date.FieldDescription = ""
        Me.xdt_entr_date.FindInitialValue = Nothing
        Me.xdt_entr_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_entr_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_entr_date.IgnoreRequiered = False
        Me.xdt_entr_date.Location = New System.Drawing.Point(424, 16)
        Me.xdt_entr_date.Name = "xdt_entr_date"
        Me.xdt_entr_date.NewInitialValue = Nothing
        Me.xdt_entr_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_entr_date.Requiered = False
        Me.xdt_entr_date.Size = New System.Drawing.Size(88, 20)
        Me.xdt_entr_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_entr_date.TabIndex = 3
        '
        'xlk_whse_code
        '
        Me.xlk_whse_code.AlternateFieldSearch = Nothing
        Me.xlk_whse_code.BeginCheck = False
        Me.xlk_whse_code.CheckText = Nothing
        Me.xlk_whse_code.ComboMode = False
        Me.xlk_whse_code.DataMember = Nothing
        Me.xlk_whse_code.DataSource = Me.LibXConnector1
        Me.xlk_whse_code.DestParameters = New String() {"xtxt_whse_code=whse_code", "whse_name=whse_name"}
        Me.xlk_whse_code.FilterField = Nothing
        Me.xlk_whse_code.IgnoreFindInBrowseMode = False
        Me.xlk_whse_code.isCanceled = False
        Me.xlk_whse_code.Location = New System.Drawing.Point(496, 40)
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
        Me.xlk_whse_code.SQLTab = Nothing
        Me.xlk_whse_code.SrcParameters = New String() {"xtxt_whse_code=whse_code"}
        Me.xlk_whse_code.TabIndex = 4
        Me.xlk_whse_code.TableName = "ivwhsem"
        Me.xlk_whse_code.TabStop = False
        Me.xlk_whse_code.UseCopyConnection = False
        Me.xlk_whse_code.UseRowRetrieveEvents = False
        Me.xlk_whse_code.UseTab = False
        Me.xlk_whse_code.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.xlk_whse_code.WhereCondition = Nothing
        Me.xlk_whse_code.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "iventrdm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn49, Me.DataColumn51, Me.DataColumn52, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn63, Me.DataColumn65, Me.DataColumn67})
        Me.DataTable1.TableName = "iventrdm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "entr_number"
        Me.DataColumn1.MaxLength = 20
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "mon_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "type_code"
        Me.DataColumn3.MaxLength = 3
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "whse_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "prov_code"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "entr_date"
        Me.DataColumn6.DataType = GetType(System.DateTime)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "total_amount"
        Me.DataColumn7.DataType = GetType(System.Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "fob_amount"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "gastos_gen"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "gastos_aduana"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "tasa"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "disc_amount"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "itbis_amount"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "aply_impto"
        Me.DataColumn14.DataType = GetType(System.Int16)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "impto_amount"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "aply_dscto"
        Me.DataColumn16.DataType = GetType(System.Int16)
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.ColumnName = "entr_status"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "aply_itbis"
        Me.DataColumn18.DataType = GetType(System.Int16)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "edit_price"
        Me.DataColumn19.DataType = GetType(System.Int16)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "date_created"
        Me.DataColumn20.DataType = GetType(System.DateTime)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "userid"
        Me.DataColumn21.MaxLength = 20
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "prov_name"
        Me.DataColumn22.MaxLength = 60
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "type_local"
        Me.DataColumn23.DataType = GetType(System.Int16)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "Aplicar"
        Me.DataColumn24.DataType = GetType(System.Int16)
        '
        'DataColumn49
        '
        Me.DataColumn49.AllowDBNull = False
        Me.DataColumn49.AutoIncrement = True
        Me.DataColumn49.ColumnName = "entr_serial"
        Me.DataColumn49.DataType = GetType(System.Int32)
        Me.DataColumn49.ReadOnly = True
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "entr_cond"
        Me.DataColumn51.DataType = GetType(System.Int32)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "apli_ofert"
        Me.DataColumn52.DataType = GetType(System.Int16)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "chk_numero"
        Me.DataColumn55.DataType = GetType(System.Int32)
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "ord_numero"
        Me.DataColumn56.DataType = GetType(System.Int32)
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "aply_orden"
        Me.DataColumn57.DataType = GetType(System.Int16)
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "term_code"
        Me.DataColumn58.MaxLength = 5
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "entr_ncf"
        Me.DataColumn63.MaxLength = 19
        '
        'DataColumn65
        '
        Me.DataColumn65.AllowDBNull = False
        Me.DataColumn65.ColumnName = "suc_code"
        Me.DataColumn65.DataType = GetType(System.Int32)
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn50, Me.DataColumn53, Me.DataColumn54, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn64, Me.DataColumn66, Me.DataColumn68})
        Me.DataTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"entr_number"}, True)})
        Me.DataTable2.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn25}
        Me.DataTable2.TableName = "iventrdd"
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "entr_number"
        Me.DataColumn25.MaxLength = 20
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "mon_code"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "type_code"
        Me.DataColumn27.MaxLength = 3
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.ColumnName = "whse_code"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "prov_code"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "entr_date"
        Me.DataColumn30.DataType = GetType(System.DateTime)
        '
        'DataColumn31
        '
        Me.DataColumn31.AllowDBNull = False
        Me.DataColumn31.ColumnName = "total_amount"
        Me.DataColumn31.DataType = GetType(System.Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "fob_amount"
        Me.DataColumn32.DataType = GetType(System.Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "gastos_gen"
        Me.DataColumn33.DataType = GetType(System.Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "gastos_aduana"
        Me.DataColumn34.DataType = GetType(System.Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "tasa"
        Me.DataColumn35.DataType = GetType(System.Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "disc_amount"
        Me.DataColumn36.DataType = GetType(System.Decimal)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "itbis_amount"
        Me.DataColumn37.DataType = GetType(System.Decimal)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "aply_impto"
        Me.DataColumn38.DataType = GetType(System.Int16)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "impto_amount"
        Me.DataColumn39.DataType = GetType(System.Decimal)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "aply_dscto"
        Me.DataColumn40.DataType = GetType(System.Int16)
        '
        'DataColumn41
        '
        Me.DataColumn41.AllowDBNull = False
        Me.DataColumn41.ColumnName = "entr_status"
        Me.DataColumn41.DataType = GetType(System.Int32)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "aply_itbis"
        Me.DataColumn42.DataType = GetType(System.Int16)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "edit_price"
        Me.DataColumn43.DataType = GetType(System.Int16)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "date_created"
        Me.DataColumn44.DataType = GetType(System.DateTime)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "userid"
        Me.DataColumn45.MaxLength = 20
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "prov_name"
        Me.DataColumn46.MaxLength = 60
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "type_local"
        Me.DataColumn47.DataType = GetType(System.Int16)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "Aplicar"
        Me.DataColumn48.DataType = GetType(System.Int16)
        '
        'DataColumn50
        '
        Me.DataColumn50.AllowDBNull = False
        Me.DataColumn50.AutoIncrement = True
        Me.DataColumn50.ColumnName = "entr_serial"
        Me.DataColumn50.DataType = GetType(System.Int32)
        Me.DataColumn50.ReadOnly = True
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "entr_cond"
        Me.DataColumn53.DataType = GetType(System.Int32)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "apli_ofert"
        Me.DataColumn54.DataType = GetType(System.Int16)
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "chk_numero"
        Me.DataColumn59.DataType = GetType(System.Int32)
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "ord_numero"
        Me.DataColumn60.DataType = GetType(System.Int32)
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "aply_orden"
        Me.DataColumn61.DataType = GetType(System.Int16)
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "term_code"
        Me.DataColumn62.MaxLength = 5
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "entr_ncf"
        Me.DataColumn64.MaxLength = 19
        '
        'DataColumn66
        '
        Me.DataColumn66.AllowDBNull = False
        Me.DataColumn66.ColumnName = "suc_code"
        Me.DataColumn66.DataType = GetType(System.Int32)
        '
        'LibXDbSourceTable1
        '
        Me.LibXDbSourceTable1.AllowDelete = False
        Me.LibXDbSourceTable1.AllowEdit = True
        Me.LibXDbSourceTable1.AllowNew = False
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
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select iventrdm.*,cpprovm.prov_name,ivtypem.type_local ", "from iventrdm inner join cpprovm", "on iventrdm.prov_code = cpprovm.prov_code", "inner join ivtypem on ivtypem.type_code = iventrdm.type_code"}
        Me.LibXDbSourceTable1.TableName = "iventrdm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = True
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
        Me.LibXDbSourceTable2.Source = New String() {"select iventrdm.*,cpprovm.prov_name,ivtypem.type_local ", "from iventrdm inner join cpprovm", "on iventrdm.prov_code = cpprovm.prov_code", "inner join ivtypem on ivtypem.type_code = iventrdm.type_code"}
        Me.LibXDbSourceTable2.TableName = "iventrdd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(336, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Factura:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Factura:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(24, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Almacén:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'whse_name
        '
        Me.whse_name.Location = New System.Drawing.Point(192, 40)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.ReadOnly = True
        Me.whse_name.Size = New System.Drawing.Size(304, 20)
        Me.whse_name.TabIndex = 3
        Me.whse_name.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(24, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Suplidor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'prov_name
        '
        Me.prov_name.Location = New System.Drawing.Point(192, 64)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.ReadOnly = True
        Me.prov_name.Size = New System.Drawing.Size(304, 20)
        Me.prov_name.TabIndex = 3
        Me.prov_name.Text = ""
        '
        'xlk_prov_code
        '
        Me.xlk_prov_code.AlternateFieldSearch = Nothing
        Me.xlk_prov_code.BeginCheck = False
        Me.xlk_prov_code.CheckText = Nothing
        Me.xlk_prov_code.ComboMode = False
        Me.xlk_prov_code.DataMember = Nothing
        Me.xlk_prov_code.DataSource = Me.LibXConnector1
        Me.xlk_prov_code.DestParameters = New String() {"xtxt_prov_code=prov_code", "prov_name=prov_name"}
        Me.xlk_prov_code.FilterField = Nothing
        Me.xlk_prov_code.IgnoreFindInBrowseMode = False
        Me.xlk_prov_code.isCanceled = False
        Me.xlk_prov_code.Location = New System.Drawing.Point(496, 64)
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
        Me.xlk_prov_code.SrcParameters = New String() {"xtxt_prov_code=prov_code"}
        Me.xlk_prov_code.TabIndex = 4
        Me.xlk_prov_code.TableName = "cpprovm"
        Me.xlk_prov_code.TabStop = False
        Me.xlk_prov_code.UseCopyConnection = False
        Me.xlk_prov_code.UseRowRetrieveEvents = False
        Me.xlk_prov_code.UseTab = False
        Me.xlk_prov_code.VisParameters = New String() {"Código=prov_code", "Nombre=prov_name", "Tipo=prov_type"}
        Me.xlk_prov_code.WhereCondition = Nothing
        Me.xlk_prov_code.WhereParameters = Nothing
        '
        'xtxt_whse_code
        '
        Me.xtxt_whse_code.AcceptsReturn = True
        Me.xtxt_whse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.whse_code"))
        Me.xtxt_whse_code.Location = New System.Drawing.Point(88, 40)
        Me.xtxt_whse_code.Name = "xtxt_whse_code"
        Me.xtxt_whse_code.TabIndex = 1
        Me.xtxt_whse_code.Text = ""
        '
        'xtxt_prov_code
        '
        Me.xtxt_prov_code.AcceptsReturn = True
        Me.xtxt_prov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "iventrdm.prov_code"))
        Me.xtxt_prov_code.Location = New System.Drawing.Point(88, 64)
        Me.xtxt_prov_code.Name = "xtxt_prov_code"
        Me.xtxt_prov_code.TabIndex = 2
        Me.xtxt_prov_code.Text = ""
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Location = New System.Drawing.Point(560, 40)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 32)
        Me.btnRefresh.TabIndex = 10
        Me.btnRefresh.Text = "Refrescar"
        '
        'btnDetail
        '
        Me.btnDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDetail.Location = New System.Drawing.Point(168, 496)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(80, 32)
        Me.btnDetail.TabIndex = 9
        Me.btnDetail.Text = "Visualizar"
        '
        'btnUnmarkall
        '
        Me.btnUnmarkall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUnmarkall.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnmarkall.Location = New System.Drawing.Point(88, 496)
        Me.btnUnmarkall.Name = "btnUnmarkall"
        Me.btnUnmarkall.Size = New System.Drawing.Size(80, 32)
        Me.btnUnmarkall.TabIndex = 8
        Me.btnUnmarkall.Text = "Desmarcar Todos"
        '
        'btnMarkAll
        '
        Me.btnMarkAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMarkAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarkAll.Location = New System.Drawing.Point(8, 496)
        Me.btnMarkAll.Name = "btnMarkAll"
        Me.btnMarkAll.Size = New System.Drawing.Size(80, 32)
        Me.btnMarkAll.TabIndex = 7
        Me.btnMarkAll.Text = "Marcar Todos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_internac)
        Me.GroupBox2.Controls.Add(Me.chk_Local)
        Me.GroupBox2.Controls.Add(Me.lblInternacionales)
        Me.GroupBox2.Controls.Add(Me.lblLocales)
        Me.GroupBox2.Location = New System.Drawing.Point(648, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(144, 96)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Leyenda"
        '
        'chk_internac
        '
        Me.chk_internac.Location = New System.Drawing.Point(8, 56)
        Me.chk_internac.Name = "chk_internac"
        Me.chk_internac.Size = New System.Drawing.Size(104, 16)
        Me.chk_internac.TabIndex = 8
        Me.chk_internac.Text = "Internacionales"
        '
        'chk_Local
        '
        Me.chk_Local.Location = New System.Drawing.Point(8, 24)
        Me.chk_Local.Name = "chk_Local"
        Me.chk_Local.Size = New System.Drawing.Size(80, 16)
        Me.chk_Local.TabIndex = 7
        Me.chk_Local.Text = "Locales"
        '
        'lblInternacionales
        '
        Me.lblInternacionales.BackColor = System.Drawing.Color.NavajoWhite
        Me.lblInternacionales.Location = New System.Drawing.Point(8, 72)
        Me.lblInternacionales.Name = "lblInternacionales"
        Me.lblInternacionales.Size = New System.Drawing.Size(56, 8)
        Me.lblInternacionales.TabIndex = 6
        '
        'lblLocales
        '
        Me.lblLocales.BackColor = System.Drawing.Color.Cyan
        Me.lblLocales.Location = New System.Drawing.Point(8, 40)
        Me.lblLocales.Name = "lblLocales"
        Me.lblLocales.Size = New System.Drawing.Size(56, 8)
        Me.lblLocales.TabIndex = 4
        '
        'LibXGrid1
        '
        Me.LibXGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = True
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Entradas pendientes"
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.DataMember = "iventrdd"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 112)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(784, 360)
        Me.LibXGrid1.TabIndex = 15
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8})
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
        'MenuItem8
        '
        Me.MenuItem8.Index = 7
        Me.MenuItem8.Text = "Anular"
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridBoolColumn1, Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn3, Me.XEditTextBoxColumn4, Me.XEditTextBoxColumn5, Me.XEditTextBoxColumn6, Me.XEditTextBoxColumn7, Me.gColSerial})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "iventrdd"
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.FalseValue = CType(0, Short)
        Me.DataGridBoolColumn1.HeaderText = "Aplicar"
        Me.DataGridBoolColumn1.MappingName = "Aplicar"
        Me.DataGridBoolColumn1.NullValue = CType(0, Short)
        Me.DataGridBoolColumn1.TrueValue = CType(1, Short)
        Me.DataGridBoolColumn1.Width = 40
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Número"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = True
        Me.XEditTextBoxColumn1.MappingName = "entr_number"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = True
        Me.XEditTextBoxColumn1.Width = 85
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
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = True
        Me.XEditTextBoxColumn2.Width = 80
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Tipo"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = True
        Me.XEditTextBoxColumn3.MappingName = "type_code"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.TabStop = True
        Me.XEditTextBoxColumn3.UseCustomCellFormat = True
        Me.XEditTextBoxColumn3.Width = 50
        '
        'XEditTextBoxColumn4
        '
        Me.XEditTextBoxColumn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn4.Format = ""
        Me.XEditTextBoxColumn4.FormatInfo = Nothing
        Me.XEditTextBoxColumn4.HeaderText = "Suplidor"
        Me.XEditTextBoxColumn4.ImageList = Nothing
        Me.XEditTextBoxColumn4.isReadOnly = True
        Me.XEditTextBoxColumn4.MappingName = "prov_name"
        Me.XEditTextBoxColumn4.MaxLength = 32767
        Me.XEditTextBoxColumn4.TabStop = True
        Me.XEditTextBoxColumn4.UseCustomCellFormat = True
        Me.XEditTextBoxColumn4.Width = 300
        '
        'XEditTextBoxColumn5
        '
        Me.XEditTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn5.Format = "###,###,##0.00"
        Me.XEditTextBoxColumn5.FormatInfo = Nothing
        Me.XEditTextBoxColumn5.HeaderText = "Montoi"
        Me.XEditTextBoxColumn5.ImageList = Nothing
        Me.XEditTextBoxColumn5.isReadOnly = True
        Me.XEditTextBoxColumn5.MappingName = "total_amount"
        Me.XEditTextBoxColumn5.MaxLength = 32767
        Me.XEditTextBoxColumn5.TabStop = True
        Me.XEditTextBoxColumn5.UseCustomCellFormat = True
        Me.XEditTextBoxColumn5.Width = 85
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
        Me.XEditTextBoxColumn6.UseCustomCellFormat = True
        Me.XEditTextBoxColumn6.Width = 95
        '
        'XEditTextBoxColumn7
        '
        Me.XEditTextBoxColumn7.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn7.Format = ""
        Me.XEditTextBoxColumn7.FormatInfo = Nothing
        Me.XEditTextBoxColumn7.ImageList = Nothing
        Me.XEditTextBoxColumn7.isReadOnly = False
        Me.XEditTextBoxColumn7.MappingName = "type_local"
        Me.XEditTextBoxColumn7.MaxLength = 32767
        Me.XEditTextBoxColumn7.TabStop = True
        Me.XEditTextBoxColumn7.UseCustomCellFormat = True
        Me.XEditTextBoxColumn7.Width = 0
        '
        'gColSerial
        '
        Me.gColSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColSerial.Format = ""
        Me.gColSerial.FormatInfo = Nothing
        Me.gColSerial.ImageList = Nothing
        Me.gColSerial.isReadOnly = True
        Me.gColSerial.MappingName = "entr_serial"
        Me.gColSerial.MaxLength = 32767
        Me.gColSerial.ReadOnly = True
        Me.gColSerial.TabStop = True
        Me.gColSerial.UseCustomCellFormat = False
        Me.gColSerial.Width = 0
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DataTable2
        '
        'btnAplicar
        '
        Me.btnAplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAplicar.Location = New System.Drawing.Point(712, 496)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(80, 32)
        Me.btnAplicar.TabIndex = 10
        Me.btnAplicar.Text = "Aplicar"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(560, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Limpiar"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "isc"
        Me.DataColumn67.DataType = GetType(System.Decimal)
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "isc"
        Me.DataColumn68.DataType = GetType(System.Decimal)
        '
        'p_iventr01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(802, 536)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDetail)
        Me.Controls.Add(Me.btnUnmarkall)
        Me.Controls.Add(Me.btnMarkAll)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "p_iventr01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Aplicar Entradas de Almacén"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub XEditTextBoxColumn1_SetCellFormat(ByVal sender As Object, ByVal e As LibX.XDataGridFormatCellEventArgs) Handles XEditTextBoxColumn1.SetCellFormat, _
                                                                                                                            XEditTextBoxColumn2.SetCellFormat, _
                                                                                                                            XEditTextBoxColumn3.SetCellFormat, _
                                                                                                                            XEditTextBoxColumn4.SetCellFormat, _
                                                                                                                            XEditTextBoxColumn5.SetCellFormat, _
                                                                                                                            XEditTextBoxColumn6.SetCellFormat, _
                                                                                                                            XEditTextBoxColumn7.SetCellFormat
        Try

            If Not LibX.IsNull(LibXGrid1.Item(e.RowNumber, 7)) _
            AndAlso LibXGrid1.Item(e.RowNumber, 7) = 1 Then
                e.BackColor = lblLocales.BackColor
            Else
                e.BackColor = lblInternacionales.BackColor
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        If e.Action = LibX.LibxConnectionActions.Find _
        Or e.AcceptedAction = LibX.LibxConnectionActions.Find Then
            DataSet1.Tables(0).Rows.Clear()
            DataSet1.Tables(1).Rows.Clear()
            LibXGrid1.ReadOnly = True
        End If

        If e.Action = LibX.LibxConnectionActions.Edit Then
            LibXGrid1.ReadOnly = False
        End If

        If e.AcceptedAction = LibX.LibxConnectionActions.Edit And DataSet1.Tables("iventrdd").Select("Aplicar=1").Length > 0 Then
            Postear()
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAll.Click
        For Each oRow As DataRow In DataSet1.Tables("iventrdd").Rows
            If oRow!entr_status = 2 Then
                oRow!Aplicar = 1
            End If
        Next

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnmarkall.Click
        For Each oRow As DataRow In DataSet1.Tables("iventrdd").Rows
            oRow!Aplicar = 0
        Next

    End Sub

    Private Sub Anular()
        Dim oParamPost As PostInventory.ParametrosAnular
        Dim oPost As PostInventory
        Dim SelectStmt As String
        Dim oiventrdd As DataTable
        Dim oiventrdm As DataTable
        Dim oArticulo As SGT.Inventario.Entidades.Articulo
        Dim oParam As SGT.Inventario.Entidades.Articulo.GetOnHandParameters
        Dim OnHand As Int16
        Dim XUpdate As LibX.Data.XUpdateStmt

        Try
            If MessageBox.Show("Seguro desea Anular estas entradas?", "Aplicar Entradas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Throw New ApplicationException("Operación Abortada!")
            End If

            For Each oRow As DataRow In DataSet1.Tables("iventrdd").Select("aplicar=1")
                '// Buscar los productos
                XUpdate = New LibX.Data.XUpdateStmt("iventrdm")

                XUpdate.FieldsSet("entr_status") = 0 'Anular
                XUpdate.Fields("entr_serial") = oRow!entr_serial
                XUpdate.Fields("prov_code") = oRow!prov_code

                XUpdate.Execute()

                DataSet1.Tables("iventrdd").Rows.Remove(oRow)
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Postear()

        Dim oParamPost As PostInventory.ParametrosAplicar
        Dim oPost As PostInventory
        Dim SelectStmt As String
        Dim oiventrdd As DataTable
        Dim oiventrdm As DataTable
        Dim oArticulo As SGT.Inventario.Entidades.Articulo
        Dim oParam As SGT.Inventario.Entidades.Articulo.GetOnHandParameters
        Dim OnHand As Integer
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim oDocumento As SGT.Inventario.Entidades.Documento
        Dim sItem As String

        Try
            If oBloqueo.BuscarBloqueo(DataSet1.Tables("iventrdd").Rows(LibXGrid1.CurrentRowIndex)!entr_serial, "CRD") = True Then
                Throw New ApplicationException("Esta entrada esta siendo modificada")
            End If
            If MessageBox.Show("Seguro desea aplicar estas entradas?", "Aplicar Entradas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Throw New ApplicationException("Operación Abortada!")
            End If

            oParamPost = New PostInventory.ParametrosAplicar
            oPost = New PostInventory

            oArticulo = New SGT.Inventario.Entidades.Articulo
            oParam = New SGT.Inventario.Entidades.Articulo.GetOnHandParameters

            For Each oRow As DataRow In DataSet1.Tables("iventrdd").Select("aplicar=1")

                '// Buscar los productos
                ''SelectStmt = String.Concat("select iventrdd.*,ivunitd.factor from iventrdd,ivunitd where iventrdd.item_code = ivunitd.item_code " & _
                ''                           " and iventrdd.unit_code = ivunitd.unit_code and entr_serial =", oRow!entr_serial.ToString)

                SelectStmt = String.Concat("select * from iventrdd where entr_serial =", oRow!entr_serial.ToString)
                oiventrdd = LibX.Data.Manager.GetDataTable(SelectStmt)

                If oiventrdd.Rows.Count <= 0 Then
                    Throw New ApplicationException("No se encontró productos para esta entrada!")
                End If

                '// Postear a inventario
                With oParamPost
                    .DocDate = oRow!entr_date
                    .Serial = oRow!entr_serial
                    .Numero = oRow!entr_number.ToString.Trim
                    .Referencia = oRow!prov_code.ToString.Trim
                    .Comprobante = oRow!entr_ncf.ToString.Trim
                    .TipoTransaccion = oRow!type_code.ToString.Trim
                    .Tasa = Val(oRow!Tasa.ToString.Trim)
                    .Termino = oRow!term_code.ToString.Trim
                    .Proveedor = Val(oRow!prov_code.ToString.Trim)
                    .UseTransaction = True
                    .Monto = Val(oRow!total_amount.ToString.Trim)
                    .Descuento = Val(oRow!disc_amount.ToString.Trim)
                    .Impuesto = Val(oRow!itbis_amount.ToString.Trim)
                    .SucCode = oRow!suc_code
                    .WebTrasnf = Transf
                    .Productos.Clear()

                    For Each oRowd As DataRow In oiventrdd.Rows
                        oParam.Producto = oRowd!item_code.ToString
                        oParam.WareHouse = Val(oRowd!whse_code.ToString)

                        OnHand = Val(oArticulo.GetOnHand(oParam).ToString)
                        sItem = LibX.Data.Manager.GetScalar("select unit_code from ivunitd where item_code ='" & oRowd!item_code.ToString & "' and unit_code = '" & oRowd!unit_code.ToString.Trim & "'")
                        If sItem = "" Then
                            Throw New ApplicationException("Hay productos con la unidad mal definida, Revisar!")
                        End If
                        .Productos.Add(oRowd!item_code.ToString, Val(oRowd!whse_code.ToString.Trim), _
                        Val(oRowd!qty.ToString.Trim) + Val(oRowd!qty_oferta.ToString.Trim), _
                        oRowd!unit_code.ToString.Trim, Val(oRowd!costo.ToString.Trim), _
                        Val(oRowd!purch_unit_cost.ToString.Trim), Val(oRowd!impto.ToString.Trim), _
                        Val(oRowd!price.ToString), OnHand, oRowd!factor, oRowd!benef)
                    Next
                End With

                '// Aplicar Entrada y Generar Etiqueta
                oPost.AplicarConEtiqueta(oParamPost)

                DataSet1.Tables("iventrdd").Rows.Remove(oRow)
            Next

            btnRefresh_Click(Me, New EventArgs)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub p_iventr01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            oBloqueo = New SGT.Inventario.Entidades.Ivbloqueo
            Me.xdt_entr_date.Value = DBNull.Value
            btnRefresh_Click(sender, e)
            Transf = CType(System.Configuration.ConfigurationSettings.AppSettings.Get("LibxTransf"), Boolean)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        e.AditionalWhere = "entr_status = 2" '// Pendiente Aplicar

        If Me.xtxt_whse_code.Text.Trim <> "" Then
            e.AditionalWhere &= " and iventrdm.whse_code = " & Me.xtxt_whse_code.Text.Trim
        End If

        If Me.xtxt_prov_code.Text.Trim <> "" Then
            e.AditionalWhere &= " and iventrdm.prov_code = " & Me.xtxt_prov_code.Text.Trim
        End If

        If Me.xtxt_entr_number.Text.Trim <> "" Then
            e.AditionalWhere &= " and iventrdm.entr_number = '" & Me.xtxt_prov_code.Text.Trim & "'"
        End If

        If Not LibX.IsNull(Me.xdt_entr_date.Value) Then
            e.AditionalWhere &= " and iventrdm.entr_date = '" & CDate(Me.xdt_entr_date.Value).ToString(LibX.Data.Manager.GetSaveDateFormat) & "'"
        End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetail.Click
        Dim ProgParam As LibX.LibxPrgParams
        Try
            ProgParam = New LibX.LibxPrgParams
            With ProgParam
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .AllowPrint = False
                .AllowQuery = False
                .IsFromOther = True
                .initMode = LibX.LibxInitModes.none
                .Value = LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColSerial)
                .WhereToExecute = "iventrdm.entr_serial =" & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColSerial).ToString
            End With

            LibX.App.CurrentPrgParams = ProgParam
            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 3).ToString.Trim = "PDI" Then
                LibX.LibXRunner.Run("i_iventr03", "INV")
            End If
            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 3).ToString.Trim = "CUS" Then
                'ProgParam.WhereToExecute = ""
                LibX.LibXRunner.Run("i_iventr01", "INV")
            End If
            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 3).ToString.Trim = "CRD" Then
                'ProgParam.WhereToExecute = ""
                LibX.LibXRunner.Run("i_iventr02", "INV")
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        btnMarkAll.Enabled = e.isEditing And LibXConnector1.HasRecords
        btnUnmarkall.Enabled = e.isEditing And LibXConnector1.HasRecords
        btnDetail.Enabled = e.isEditing And LibXConnector1.HasRecords
        btnAplicar.Enabled = e.isEditing And LibXConnector1.HasRecords
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.AcceptedAction = LibX.LibxConnectionActions.Find Then
                For Each oRow As DataRow In DataSet1.Tables("iventrdm").Rows
                    Dim nRow As DataRow = DataSet1.Tables("iventrdd").NewRow
                    nRow.ItemArray = oRow.ItemArray
                    nRow!Aplicar = 0
                    DataSet1.Tables("iventrdd").Rows.Add(nRow)
                Next
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Local.CheckedChanged
        ApplyFilter()

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_internac.CheckedChanged
        ApplyFilter()

    End Sub

    Private Sub ApplyFilter()
        Dim strfilter As String

        If chk_internac.Checked = True _
            And chk_Local.Checked = True Then
            strfilter = ""
        ElseIf chk_Local.Checked = True Then
            strfilter = "type_local = 1"
        ElseIf chk_internac.Checked = True Then
            strfilter = "type_local = 0"
        Else
            strfilter = ""
        End If
        DataView1.RowFilter = strfilter

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If LibXConnector1.IsDataEditing = True Then
            LibXConnector1.ShowWarningCancel = False
            LibXConnector1.Cancel()
        End If

        LibXConnector1.AcceptFind()
        If LibXConnector1.HasRecords = True Then
            LibXConnector1.Edit()
        Else
            LibXConnector1.Find()
        End If
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Button10_Click(sender, e)
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Button9_Click(sender, e)
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        btnRefresh_Click(sender, e)
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        If DataSet1.Tables("iventrdd").Rows(LibXGrid1.CurrentRowIndex)!entr_status = 2 Then
            DataSet1.Tables("iventrdd").Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1

            Postear()
        End If
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Button8_Click(Nothing, Nothing)
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        If DataSet1.Tables("iventrdd").Rows(LibXGrid1.CurrentRowIndex)!entr_status = 2 Then
            DataSet1.Tables("iventrdd").Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1
            Anular()
        End If
    End Sub

    Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click
        MenuItem7_Click(sender, e)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.xtxt_entr_number.Text = ""
        Me.xtxt_prov_code.Text = ""
        Me.xtxt_whse_code.Text = ""
        Me.xdt_entr_date.Value = DBNull.Value
        Me.xlk_prov_code.ExecuteFind()
        Me.xlk_whse_code.ExecuteFind()
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try

            btnMarkAll.Enabled = LibXConnector1.IsEditing And LibXConnector1.HasRecords
            btnUnmarkall.Enabled = LibXConnector1.IsEditing And LibXConnector1.HasRecords
            btnDetail.Enabled = LibXConnector1.IsEditing And LibXConnector1.HasRecords
            btnAplicar.Enabled = LibXConnector1.IsEditing And LibXConnector1.HasRecords


        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

End Class
