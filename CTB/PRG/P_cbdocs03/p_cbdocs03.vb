Imports SGT.Contabilidad.Entidades
Imports SGT.ControlBancario.Entidades

Imports System.Drawing.Printing
Imports System.Runtime.InteropServices

Imports SGT.Administracion
Imports SGT.Administracion.Entidades

Public Class p_cbdocs03
    Inherits System.Windows.Forms.Form
    Dim oDocumento As SGT.Contabilidad.Entidades.Documentos
    Dim oTransacion As SGT.ControlBancario.Entidades.TipoDocumento
    Dim oAplicar As SGT.CXP.Posteos.PostDocument
    Dim oChequera As cHequera
    Dim UseTransaction As Boolean = True
    Dim oTipo As Integer
    Dim oRowPrinter As DataRow
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
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents LibXDbSourceTable5 As LibX.LibXDbSourceTable
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents XDataGridTextButtonColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn4 As LibX.XEditTextBoxColumn
    Friend WithEvents gcoltran_type As LibX.XEditTextBoxColumn
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents xcbo_chequera As LibX.LibXCombo
    Friend WithEvents cbdocsm As System.Data.DataTable
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents xdt_doc_date As LibX.LibxDateTimePicker
    Friend WithEvents xtxt_doc_number As LibX.XTextBox
    Friend WithEvents btnCovertir As System.Windows.Forms.Button
    Friend WithEvents btnUnmarkall As System.Windows.Forms.Button
    Friend WithEvents btnMarkAll As System.Windows.Forms.Button
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents GcolAplicar As LibX.XDataGridBoolColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents xcbo_tran_type As LibX.LibXCombo
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn5 As LibX.XEditTextBoxColumn

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.cbdocsm = New System.Data.DataTable
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
        Me.LibXDbSourceTable5 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnLoad = New System.Windows.Forms.Button
        Me.xcbo_tran_type = New LibX.LibXCombo
        Me.xdt_doc_date = New LibX.LibxDateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.xtxt_doc_number = New LibX.XTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.xcbo_chequera = New LibX.LibXCombo
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.GcolAplicar = New LibX.XDataGridBoolColumn
        Me.gcoltran_type = New LibX.XEditTextBoxColumn
        Me.XDataGridTextButtonColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn4 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.btnCovertir = New System.Windows.Forms.Button
        Me.btnUnmarkall = New System.Windows.Forms.Button
        Me.btnMarkAll = New System.Windows.Forms.Button
        Me.DataView1 = New System.Data.DataView
        Me.DataColumn12 = New System.Data.DataColumn
        Me.XEditTextBoxColumn5 = New LibX.XEditTextBoxColumn
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbdocsm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = Nothing
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
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = True
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = True
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "cbdocsm"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable5})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.cbdocsm})
        '
        'cbdocsm
        '
        Me.cbdocsm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12})
        Me.cbdocsm.TableName = "cbdocsm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "tran_type"
        Me.DataColumn1.MaxLength = 3
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "doc_number"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "doc_date"
        Me.DataColumn3.DataType = GetType(System.DateTime)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "doc_status"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "benef"
        Me.DataColumn5.MaxLength = 60
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "amount"
        Me.DataColumn6.DataType = GetType(System.Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "type"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Aplicar"
        Me.DataColumn8.DataType = GetType(System.Int16)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "chequera"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "doc_origen"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.AutoIncrement = True
        Me.DataColumn11.ColumnName = "cbm_serial"
        Me.DataColumn11.DataType = GetType(System.Int32)
        Me.DataColumn11.ReadOnly = True
        '
        'LibXDbSourceTable5
        '
        Me.LibXDbSourceTable5.AllowDelete = True
        Me.LibXDbSourceTable5.AllowEdit = True
        Me.LibXDbSourceTable5.AllowNew = True
        Me.LibXDbSourceTable5.AutoIncrementSerial = False
        Me.LibXDbSourceTable5.CustomDbUpdate = True
        Me.LibXDbSourceTable5.DeleteOrder = 0
        Me.LibXDbSourceTable5.FillOnQuery = True
        Me.LibXDbSourceTable5.FillOnRowChange = False
        Me.LibXDbSourceTable5.HeaderIsOnGrid = False
        Me.LibXDbSourceTable5.InnerJon = True
        Me.LibXDbSourceTable5.InsertOrder = 0
        Me.LibXDbSourceTable5.IsDetail = False
        Me.LibXDbSourceTable5.KeyFields = Nothing
        Me.LibXDbSourceTable5.LineColName = Nothing
        Me.LibXDbSourceTable5.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable5.MasterTableName = Nothing
        Me.LibXDbSourceTable5.SerialColumnName = Nothing
        Me.LibXDbSourceTable5.Sort = Nothing
        Me.LibXDbSourceTable5.Source = New String() {"select cbdocsm.cbm_serial,cbdocsm.tran_type, cbdocsm.doc_number,", "cbdocsm .suc_code,", "cbdocsm.doc_date, cbdocsm.doc_status,benef,", "amount, type,cbdocsm.chequera,cbdocsm.doc_origen", "from cbdocsm inner join cgtrntpm", "on cgtrntpm.tran_type = cbdocsm.tran_type", "and cgtrntpm.type = 2 and cgtrntpm.chequera =cbdocsm.chequera", "and cbdocsm.doc_status = 2 and cbdocsm.tran_type in('CHQ','SOL')", "order by cbdocsm.tran_type,cbdocsm.doc_number"}
        Me.LibXDbSourceTable5.TableName = "cbdocsm"
        Me.LibXDbSourceTable5.UpdateOrder = 0
        Me.LibXDbSourceTable5.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLoad)
        Me.GroupBox1.Controls.Add(Me.xcbo_tran_type)
        Me.GroupBox1.Controls.Add(Me.xdt_doc_date)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xtxt_doc_number)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.xcbo_chequera)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 120)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnLoad
        '
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoad.Location = New System.Drawing.Point(698, 16)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(88, 40)
        Me.btnLoad.TabIndex = 13
        Me.btnLoad.Text = "Imprimir"
        '
        'xcbo_tran_type
        '
        Me.xcbo_tran_type.AllowDefaultSort = True
        Me.xcbo_tran_type.bound = True
        Me.xcbo_tran_type.currValue = Nothing
        Me.xcbo_tran_type.DefaultWhereString = "type_code in ('SOL','CHQ')"
        Me.xcbo_tran_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_tran_type.EditInitialValue = Nothing
        Me.xcbo_tran_type.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_tran_type.FieldDescription = ""
        Me.xcbo_tran_type.FindInitialValue = Nothing
        Me.xcbo_tran_type.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_tran_type.IgnoreRequiered = False
        Me.xcbo_tran_type.Location = New System.Drawing.Point(128, 88)
        Me.xcbo_tran_type.LookupKeyDisplayFields = "type_name"
        Me.xcbo_tran_type.LookupKeyField = "type_code"
        Me.xcbo_tran_type.LookupTableName = "ivtypem"
        Me.xcbo_tran_type.Name = "xcbo_tran_type"
        Me.xcbo_tran_type.NewInitialValue = "SOL"
        Me.xcbo_tran_type.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_tran_type.Requiered = False
        Me.xcbo_tran_type.Required = False
        Me.xcbo_tran_type.Size = New System.Drawing.Size(344, 21)
        Me.xcbo_tran_type.SqlString = Nothing
        Me.xcbo_tran_type.StatusBarPanelDescripcion = Nothing
        Me.xcbo_tran_type.TabIndex = 1
        '
        'xdt_doc_date
        '
        Me.xdt_doc_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_doc_date.EditInitialValue = Nothing
        Me.xdt_doc_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_doc_date.FieldDescription = ""
        Me.xdt_doc_date.FindInitialValue = Nothing
        Me.xdt_doc_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_doc_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_doc_date.IgnoreRequiered = False
        Me.xdt_doc_date.Location = New System.Drawing.Point(128, 40)
        Me.xdt_doc_date.Name = "xdt_doc_date"
        Me.xdt_doc_date.NewInitialValue = Nothing
        Me.xdt_doc_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_doc_date.Requiered = False
        Me.xdt_doc_date.Size = New System.Drawing.Size(88, 20)
        Me.xdt_doc_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_doc_date.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(81, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(14, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tipo de Documento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(63, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Chequera:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(72, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Número:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_doc_number
        '
        Me.xtxt_doc_number.AcceptsReturn = True
        Me.xtxt_doc_number.EditInitialValue = Nothing
        Me.xtxt_doc_number.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_doc_number.FieldDescription = ""
        Me.xtxt_doc_number.FindInitialValue = Nothing
        Me.xtxt_doc_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_doc_number.IgnoreRequiered = False
        Me.xtxt_doc_number.Location = New System.Drawing.Point(128, 16)
        Me.xtxt_doc_number.Name = "xtxt_doc_number"
        Me.xtxt_doc_number.NewInitialValue = Nothing
        Me.xtxt_doc_number.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_doc_number.Requiered = False
        Me.xtxt_doc_number.Size = New System.Drawing.Size(88, 20)
        Me.xtxt_doc_number.StatusBarPanelDescripcion = Nothing
        Me.xtxt_doc_number.TabIndex = 3
        Me.xtxt_doc_number.Text = ""
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(698, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 40)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Refrescar"
        '
        'xcbo_chequera
        '
        Me.xcbo_chequera.AllowDefaultSort = True
        Me.xcbo_chequera.bound = True
        Me.xcbo_chequera.currValue = Nothing
        Me.xcbo_chequera.DefaultWhereString = Nothing
        Me.xcbo_chequera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_chequera.EditInitialValue = Nothing
        Me.xcbo_chequera.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_chequera.FieldDescription = ""
        Me.xcbo_chequera.FindInitialValue = Nothing
        Me.xcbo_chequera.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_chequera.IgnoreRequiered = False
        Me.xcbo_chequera.Location = New System.Drawing.Point(128, 64)
        Me.xcbo_chequera.LookupKeyDisplayFields = "descripcion"
        Me.xcbo_chequera.LookupKeyField = "chequera"
        Me.xcbo_chequera.LookupTableName = "cpchequera"
        Me.xcbo_chequera.Name = "xcbo_chequera"
        Me.xcbo_chequera.NewInitialValue = "2"
        Me.xcbo_chequera.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_chequera.Requiered = False
        Me.xcbo_chequera.Required = False
        Me.xcbo_chequera.Size = New System.Drawing.Size(344, 21)
        Me.xcbo_chequera.SqlString = Nothing
        Me.xcbo_chequera.StatusBarPanelDescripcion = Nothing
        Me.xcbo_chequera.TabIndex = 1
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Documentos PENDIENTES de Impresión"
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.DataMember = "cbdocsm"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 144)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(800, 320)
        Me.LibXGrid1.TabIndex = 2
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem5, Me.MenuItem7, Me.MenuItem4})
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
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.Text = "Refrescar"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 3
        Me.MenuItem7.Text = "Convertir Solicitud"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 4
        Me.MenuItem4.Text = "Imprimir"
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.GcolAplicar, Me.XEditTextBoxColumn5, Me.gcoltran_type, Me.XDataGridTextButtonColumn1, Me.XEditTextBoxColumn4, Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn3})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cbdocsm"
        '
        'GcolAplicar
        '
        Me.GcolAplicar.FalseValue = CType(0, Short)
        Me.GcolAplicar.HeaderText = "Aplicar"
        Me.GcolAplicar.MappingName = "Aplicar"
        Me.GcolAplicar.NullValue = 0
        Me.GcolAplicar.TrueValue = CType(1, Short)
        Me.GcolAplicar.UseCustomCellFormat = False
        Me.GcolAplicar.Width = 50
        '
        'gcoltran_type
        '
        Me.gcoltran_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcoltran_type.Format = ""
        Me.gcoltran_type.FormatInfo = Nothing
        Me.gcoltran_type.HeaderText = "Tipo"
        Me.gcoltran_type.ImageList = Nothing
        Me.gcoltran_type.isReadOnly = True
        Me.gcoltran_type.MappingName = "tran_type"
        Me.gcoltran_type.MaxLength = 32767
        Me.gcoltran_type.ReadOnly = True
        Me.gcoltran_type.TabStop = True
        Me.gcoltran_type.UseCustomCellFormat = False
        Me.gcoltran_type.Width = 50
        '
        'XDataGridTextButtonColumn1
        '
        Me.XDataGridTextButtonColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XDataGridTextButtonColumn1.Format = ""
        Me.XDataGridTextButtonColumn1.FormatInfo = Nothing
        Me.XDataGridTextButtonColumn1.HeaderText = "Número"
        Me.XDataGridTextButtonColumn1.ImageList = Nothing
        Me.XDataGridTextButtonColumn1.isReadOnly = True
        Me.XDataGridTextButtonColumn1.MappingName = "doc_number"
        Me.XDataGridTextButtonColumn1.MaxLength = 32767
        Me.XDataGridTextButtonColumn1.ReadOnly = True
        Me.XDataGridTextButtonColumn1.TabStop = True
        Me.XDataGridTextButtonColumn1.UseCustomCellFormat = False
        Me.XDataGridTextButtonColumn1.Width = 101
        '
        'XEditTextBoxColumn4
        '
        Me.XEditTextBoxColumn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn4.Format = ""
        Me.XEditTextBoxColumn4.FormatInfo = Nothing
        Me.XEditTextBoxColumn4.ImageList = Nothing
        Me.XEditTextBoxColumn4.isReadOnly = True
        Me.XEditTextBoxColumn4.MappingName = "cbm_serial"
        Me.XEditTextBoxColumn4.MaxLength = 32767
        Me.XEditTextBoxColumn4.ReadOnly = True
        Me.XEditTextBoxColumn4.TabStop = True
        Me.XEditTextBoxColumn4.UseCustomCellFormat = False
        Me.XEditTextBoxColumn4.Width = 0
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Fecha"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = True
        Me.XEditTextBoxColumn1.MappingName = "doc_date"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.ReadOnly = True
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 101
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Beneficiario"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = True
        Me.XEditTextBoxColumn2.MappingName = "Benef"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.ReadOnly = True
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 275
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = "#,###,##0.00"
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Montoi"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = True
        Me.XEditTextBoxColumn3.MappingName = "amount"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.ReadOnly = True
        Me.XEditTextBoxColumn3.TabStop = True
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 101
        '
        'btnCovertir
        '
        Me.btnCovertir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCovertir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCovertir.Location = New System.Drawing.Point(648, 496)
        Me.btnCovertir.Name = "btnCovertir"
        Me.btnCovertir.Size = New System.Drawing.Size(80, 32)
        Me.btnCovertir.TabIndex = 11
        Me.btnCovertir.Text = "Convertir Solicitud"
        '
        'btnUnmarkall
        '
        Me.btnUnmarkall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUnmarkall.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnmarkall.Location = New System.Drawing.Point(104, 496)
        Me.btnUnmarkall.Name = "btnUnmarkall"
        Me.btnUnmarkall.Size = New System.Drawing.Size(80, 32)
        Me.btnUnmarkall.TabIndex = 12
        Me.btnUnmarkall.Text = "Desmarcar Todos"
        '
        'btnMarkAll
        '
        Me.btnMarkAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMarkAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarkAll.Location = New System.Drawing.Point(16, 496)
        Me.btnMarkAll.Name = "btnMarkAll"
        Me.btnMarkAll.Size = New System.Drawing.Size(80, 32)
        Me.btnMarkAll.TabIndex = 13
        Me.btnMarkAll.Text = "Marcar Todos"
        '
        'DataView1
        '
        Me.DataView1.AllowDelete = False
        Me.DataView1.AllowNew = False
        Me.DataView1.Table = Me.cbdocsm
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "suc_code"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'XEditTextBoxColumn5
        '
        Me.XEditTextBoxColumn5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn5.Format = ""
        Me.XEditTextBoxColumn5.FormatInfo = Nothing
        Me.XEditTextBoxColumn5.HeaderText = "Sucursal"
        Me.XEditTextBoxColumn5.ImageList = Nothing
        Me.XEditTextBoxColumn5.isReadOnly = False
        Me.XEditTextBoxColumn5.MappingName = "suc_code"
        Me.XEditTextBoxColumn5.MaxLength = 32767
        Me.XEditTextBoxColumn5.TabStop = True
        Me.XEditTextBoxColumn5.UseCustomCellFormat = False
        Me.XEditTextBoxColumn5.Width = 75
        '
        'p_cbdocs03
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(824, 534)
        Me.Controls.Add(Me.btnMarkAll)
        Me.Controls.Add(Me.btnUnmarkall)
        Me.Controls.Add(Me.btnCovertir)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "p_cbdocs03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Impresión de Cheques"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbdocsm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub i_cgjourm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            LibXGrid1.footerOperations.add("doc_number", "count(doc_number)")
            'LibXGrid1.getCurrentGridView.AllowDelete = False
            'LibXGrid1.getCurrentGridView.AllowNew = False

            RefreshGrid()

            Me.xcbo_chequera.LoadDbItems(True)
            Me.xcbo_tran_type.LoadDbItems(True)
            '// Me.xcbo_tran_type.SelectedValue = "CHQ"

        Catch ex As Exception
            LibX.Log.Add(ex)
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
        If e.AcceptedAction = LibX.LibxConnectionActions.Edit Then
            For Each oRow As DataRow In DataSet1.Tables("cbdocsm").Select("Aplicar=1")
                Convertir()
            Next
        End If
    End Sub

    Private Sub RefreshGrid()
        Try
            LibXConnector1.ExecuteFind()

            If LibXConnector1.HasRecords = True Then
                LibXConnector1.Edit()
            Else
                LibXConnector1.Find()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            e.AditionalWhere = "1 = 1" '// Pendientes

            If xcbo_chequera.Text.Trim <> "" Then
                e.AditionalWhere &= " and chequera = " & xcbo_chequera.SelectedValue.ToString.Trim
            End If

            If xcbo_tran_type.Text.Trim <> "" Then
                e.AditionalWhere &= " and cbdocsm.tran_type = '" & xcbo_tran_type.SelectedValue.ToString.Trim & "'"
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RefreshGrid()
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try
            For Each oRow As DataRow In DataSet1.Tables("cbdocsm").Select("Aplicar=1")
                Impresion()
            Next
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub btnCovertir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCovertir.Click
        If LibXConnector1.CurrentDataRow!tran_type = "SOL" Then
            For Each oRow As DataRow In DataSet1.Tables("cbdocsm").Select("Aplicar=1")
                Convertir()
            Next
        End If
    End Sub


    Private Function AsignarImpresion(ByVal IDChequera As Integer) As String
        Dim Archivo As String
        Dim SelectStmt As String
        Dim oRow As DataRow

        SelectStmt = "select cheque_format from cpchequera " & _
                     "where cpchequera.chequera = " & IDChequera.ToString.Trim

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oRow Is Nothing Then
            Return ""
        End If

        If LibX.IsNull(oRow!cheque_format) = True Then
            Return ""
        End If

        Archivo = oRow!cheque_format.ToString.Trim

        Return Archivo
    End Function

    Private Sub Convertir()
        Dim SelecStmt As String
        Dim AxCrystalReport1 As LibX.ReportLib
        Dim Archivo As String = ""
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim oTable As DataTable
        Dim neW_Number As Integer
        Dim CurrenSerial As Integer
        Dim mOnto As Decimal
        Dim SelectStmt As String

        Try
            oChequera = New Chequera(LibXConnector1.CurrentDataRow!chequera)
            Me.Cursor = Cursors.WaitCursor
            CurrenSerial = LibXConnector1.CurrentDataRow!cbm_serial
            mOnto = LibXConnector1.CurrentDataRow!amount

            SelectStmt = "select * from sgfprinter where print_default = 0 "
            oRowPrinter = LibX.Data.Manager.GetDataRow(SelectStmt)


            If LibX.IsNull(oChequera.Banco) = False Then
                Archivo = AsignarImpresion(oChequera.Banco)
            End If

            If UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            If LibXConnector1.CurrentDataRow!tran_type = "SOL" Then

                If MessageBox.Show("Seguro desea Imprimir Esta solicitud como Cheque ?", "Imprimir Cheque", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    Throw New ApplicationException("Operación Abortada!")
                End If

                If Not LibX.IsNull(LibXConnector1.CurrentDataRow!doc_origen) Then
                    Dim oPagar As SGT.CXP.Posteos.PostDocument.ParametrosPagar

                    SelecStmt = ("select cppaymd.invce_serial,type_code,cppaymm.prov_code,cppaymm.chequera,cppaymd.disc_amount," & _
                                 " cppaymd.balance,cppaymd.suc_code,cppaymm.paym_date " & _
                                 " from cppaymd inner join cppaymm on cppaymd.paym_serial = cppaymm.paym_serial " & _
                                 "and cppaymd.paym_serial = " & LibXConnector1.CurrentDataRow!doc_origen)

                    oTable = LibX.Data.Manager.GetDataTable(SelecStmt)

                    oPagar = New SGT.CXP.Posteos.PostDocument.ParametrosPagar
                    oAplicar = New SGT.CXP.Posteos.PostDocument

                    For Each oRow As DataRow In oTable.Rows
                        With oPagar
                            .Serial = oRow!invce_serial
                            .MontoAplicado = oRow!balance
                            .Descuento = oRow!disc_amount
                            .TipoDocumento = oRow!type_code
                            .Proveedor = oRow!prov_code
                            .Chequera = oRow!chequera
                            .Fecha = oRow!paym_date
                            .Sucursal = oRow!suc_code
                        End With

                        '// Aplicar el Pago
                        oAplicar.Pagar(oPagar)
                    Next
                End If

                If Not LibX.IsNull(LibXConnector1.CurrentDataRow!tran_type) Then

                    Dim oTransacion = New SGT.ControlBancario.Entidades.TipoDocumento("CHQ", LibXConnector1.CurrentDataRow!chequera)
                    neW_Number = oTransacion.GenerateNumber("CHQ", LibXConnector1.CurrentDataRow!chequera)

                    xUpdate = New LibX.Data.XUpdateStmt("cbdocsm")
                    xUpdate.FieldsSet("tran_type") = "CHQ"
                    xUpdate.FieldsSet("doc_status") = 1
                    xUpdate.FieldsSet("doc_number") = neW_Number
                    xUpdate.Fields("cbm_serial") = Val(LibXConnector1.CurrentDataRow!cbm_serial)
                    xUpdate.Execute()

                    If Not LibX.IsNull(LibXConnector1.CurrentDataRow!doc_origen) Then
                        xUpdate = New LibX.Data.XUpdateStmt("cppaymm")
                        xUpdate.FieldsSet("type_code") = "CHQ"
                        xUpdate.FieldsSet("paym_number") = neW_Number
                        xUpdate.FieldsSet("solicitud") = LibXConnector1.CurrentDataRow!doc_number
                        xUpdate.Fields("paym_serial") = Val(LibXConnector1.CurrentDataRow!doc_origen)
                        xUpdate.Execute()
                        LibXConnector1.ExecuteFind("cbm_serial = " & LibXConnector1.CurrentDataRow!cbm_serial.ToString.Trim)
                    End If
                End If
            Else
                xUpdate = New LibX.Data.XUpdateStmt("cbdocsm")
                xUpdate.FieldsSet("doc_status") = 1
                xUpdate.Fields("cbm_serial") = Val(LibXConnector1.CurrentDataRow!cbm_serial)
                xUpdate.Execute()
            End If

            '// Aplicar en chequera
            Dim oParamAplicar As SGT.ControlBancario.Entidades.Chequera.ParametrosAplicar
            oParamAplicar = New SGT.ControlBancario.Entidades.Chequera.ParametrosAplicar

            oParamAplicar.Chequera = oChequera.Codigo
            oParamAplicar.Monto = mOnto
            oParamAplicar.TipoDocumento = "CHQ"

            oChequera.Aplicar(oParamAplicar)

            If UseTransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            If Archivo = "" Then
                AxCrystalReport1 = New LibX.ReportLib("CTB", "r_cheques.rpt")
            Else
                AxCrystalReport1 = New LibX.ReportLib("CTB", Archivo)
            End If

            With AxCrystalReport1
                '// Recibir el SQL Query
                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, "cbdocsm.cbm_serial = " & CurrenSerial)
                .SQLQuery = SelecStmt
                .PrinterName = oRowPrinter!printername.ToString
                .Destination = 1

                '// Ejecutar el reporte
                .Action = 1

            End With

        Catch ex As Exception
            If UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
            LibX.Log.Show(ex)
        Finally
            Me.Cursor = Cursors.Default
            RefreshGrid()
        End Try

    End Sub
    '''Private Sub ImprimirCheque(ByVal PrinterName As String)
    '''    Dim pd As New PrintDialog
    '''    pd.PrinterSettings = New PrinterSettings
    '''    pd.PrinterSettings.PrinterName = PrinterName
    '''    If (pd.ShowDialog() = DialogResult.OK) Then
    '''        ' Print the file to the printer.
    '''        RawPrinterHelper.StartPagePrinter(pd.PrinterSettings.PrinterName)

    '''    End If

    '''End Sub
    Private Sub Impresion()
        Dim SelecStmt As String
        Dim AxCrystalReport1 As LibX.ReportLib
        Dim Archivo As String = ""
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim oTable As DataTable
        Dim neW_Number As Integer
        Dim CurrenSerial As Integer
        Dim mOnto As Decimal
        Dim SelectStmt As String
        Dim oParamAplicar As SGT.ControlBancario.Entidades.Chequera.ParametrosAplicar

        Try
            SelectStmt = "select * from sgfprinter where print_default = 0 "
            oRowPrinter = LibX.Data.Manager.GetDataRow(SelectStmt)

            oChequera = New Chequera(LibXConnector1.CurrentDataRow!chequera)
            Me.Cursor = Cursors.WaitCursor
            CurrenSerial = LibXConnector1.CurrentDataRow!cbm_serial
            mOnto = LibXConnector1.CurrentDataRow!amount

            If LibX.IsNull(oChequera.Banco) = False Then
                Archivo = AsignarImpresion(oChequera.Codigo)
            End If
            If LibXConnector1.CurrentDataRow!tran_type = "CHQ" Then
                If UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = False Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                End If

                xUpdate = New LibX.Data.XUpdateStmt("cbdocsm")
                xUpdate.FieldsSet("doc_status") = 1
                xUpdate.Fields("cbm_serial") = Val(LibXConnector1.CurrentDataRow!cbm_serial)
                xUpdate.Execute()

                '// Aplicar en chequera
                oParamAplicar = New SGT.ControlBancario.Entidades.Chequera.ParametrosAplicar

                oParamAplicar.Chequera = oChequera.Codigo
                oParamAplicar.Monto = mOnto
                oParamAplicar.TipoDocumento = "CHQ"
                oChequera.Aplicar(oParamAplicar)

                If UseTransaction = True Then
                    LibX.Data.Manager.Connection.CommitTransaction()
                End If
            End If

            If Archivo = "" Then
                AxCrystalReport1 = New LibX.ReportLib("CTB", "r_cheques.rpt")
            Else
                AxCrystalReport1 = New LibX.ReportLib("CTB", Archivo)
            End If

            With AxCrystalReport1
                '// Recibir el SQL Query
                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, "cbdocsm.cbm_serial = " & CurrenSerial)
                .SQLQuery = SelecStmt
                If LibXConnector1.CurrentDataRow!tran_type = "CHQ" Then
                    .PrinterName = oRowPrinter!print_name.ToString
                    .Destination = 1
                End If

                '// Ejecutar el reporte
                .Action = 1

            End With

        Catch ex As Exception
            If UseTransaction = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
            LibX.Log.Show(ex)
        Finally
            Me.Cursor = Cursors.Default
            RefreshGrid()
        End Try

    End Sub
    Private Sub btnUnmarkall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnmarkall.Click
        For Each oRow As DataRow In DataSet1.Tables("cbdocsm").Rows
            oRow!Aplicar = 0
        Next
    End Sub

    Private Sub btnMarkAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAll.Click
        For Each oRow As DataRow In DataSet1.Tables("cbdocsm").Rows
            oRow!Aplicar = 1
        Next
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        If LibXConnector1.CurrentDataRow!tran_type = "SOL" Then
            For Each oRow As DataRow In DataSet1.Tables("cbdocsm").Select("Aplicar=1")
                Convertir()
            Next
        End If
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Button1_Click(sender, e)
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        btnUnmarkall_Click(sender, e)
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        btnMarkAll_Click(sender, e)
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        For Each oRow As DataRow In DataSet1.Tables("cbdocsm").Select("Aplicar=1")
            Impresion()
        Next
    End Sub

End Class
