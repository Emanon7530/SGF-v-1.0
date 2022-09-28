Imports SGT.Contabilidad.Entidades
Imports SGT.Administracion.Entidades

Public Class p_cbdocs02
    Inherits System.Windows.Forms.Form
    Dim oDocumento As SGT.Contabilidad.Entidades.Documentos
    Dim oPermisos As SGT.Administracion.Entidades.Permission
    Dim oParamPerm As SGT.Administracion.Entidades.Permission.ParametrosValidar
    Dim oBalance As SGT.ControlBancario.Entidades.Chequera
    Dim mSaldoConAnterior As Decimal = 0
    Dim mSaldoAnterir As Decimal = 0
  
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents xlk_chequera As LibX.LibXLookup
    Friend WithEvents xtxt_chequera_name As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents xcbo_doc_status As LibX.LibXCombo
    Friend WithEvents xtxt_chequera As LibX.XTextBox
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents xdt_FechaCorte As LibX.LibxDateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents xtxt_conc_serial As LibX.XTextBox
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnReversar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents xtx_disferencia As LibX.XTextBox
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents xcbo_estatus As LibX.LibXCombo
    Friend WithEvents DataColumn10 As System.Data.DataColumn

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
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
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.xcbo_doc_status = New LibX.LibXCombo
        Me.xdt_FechaCorte = New LibX.LibxDateTimePicker
        Me.xlk_chequera = New LibX.LibXLookup
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.xtxt_chequera = New LibX.XTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.xtxt_chequera_name = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.xtxt_conc_serial = New LibX.XTextBox
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xcbo_estatus = New LibX.LibXCombo
        Me.Label7 = New System.Windows.Forms.Label
        Me.xtx_disferencia = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.btnReversar = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = False
        Me.LibXConnector1.AllowNew = False
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "cbconcm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = "CTB"
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
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"conc_serial"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "cbconcm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "conc_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "conc_date"
        Me.DataColumn2.DataType = GetType(System.DateTime)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "chequera"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "conc_status"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Saldo_ant"
        Me.DataColumn5.DataType = GetType(System.Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Saldo_Banco"
        Me.DataColumn6.DataType = GetType(System.Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Saldo_Libro"
        Me.DataColumn7.DataType = GetType(System.Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Saldo_cerrado"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Saldo_conciliado"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "estatus"
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
        Me.LibXDbSourceTable3.SerialColumnName = "conc_serial"
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = Nothing
        Me.LibXDbSourceTable3.TableName = "cbconcm"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'xcbo_doc_status
        '
        Me.xcbo_doc_status.AllowDefaultSort = True
        Me.xcbo_doc_status.bound = True
        Me.xcbo_doc_status.currValue = Nothing
        Me.xcbo_doc_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cbconcm.conc_status"))
        Me.xcbo_doc_status.DefaultWhereString = Nothing
        Me.xcbo_doc_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_doc_status.EditInitialValue = "1"
        Me.xcbo_doc_status.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_doc_status.FieldDescription = ""
        Me.xcbo_doc_status.FindInitialValue = "2"
        Me.xcbo_doc_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_doc_status.IgnoreRequiered = False
        Me.xcbo_doc_status.Items.AddRange(New Object() {"1-Cerrada", "2-Pendiente", "0-Anulado"})
        Me.xcbo_doc_status.Location = New System.Drawing.Point(480, 24)
        Me.xcbo_doc_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_doc_status.LookupKeyField = Nothing
        Me.xcbo_doc_status.LookupTableName = Nothing
        Me.xcbo_doc_status.Name = "xcbo_doc_status"
        Me.xcbo_doc_status.NewInitialValue = "2"
        Me.xcbo_doc_status.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_doc_status.Requiered = False
        Me.xcbo_doc_status.Required = False
        Me.xcbo_doc_status.Size = New System.Drawing.Size(104, 21)
        Me.xcbo_doc_status.SqlString = Nothing
        Me.xcbo_doc_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_doc_status.TabIndex = 1
        '
        'xdt_FechaCorte
        '
        Me.xdt_FechaCorte.CustomFormat = "dd/MM/yyyy"
        Me.xdt_FechaCorte.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cbconcm.conc_date"))
        Me.xdt_FechaCorte.EditInitialValue = Nothing
        Me.xdt_FechaCorte.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaCorte.FieldDescription = ""
        Me.xdt_FechaCorte.FindInitialValue = Nothing
        Me.xdt_FechaCorte.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaCorte.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaCorte.IgnoreRequiered = False
        Me.xdt_FechaCorte.Location = New System.Drawing.Point(328, 24)
        Me.xdt_FechaCorte.Name = "xdt_FechaCorte"
        Me.xdt_FechaCorte.NewInitialValue = Nothing
        Me.xdt_FechaCorte.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaCorte.Requiered = False
        Me.xdt_FechaCorte.Size = New System.Drawing.Size(88, 20)
        Me.xdt_FechaCorte.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaCorte.TabIndex = 0
        '
        'xlk_chequera
        '
        Me.xlk_chequera.AlternateFieldSearch = Nothing
        Me.xlk_chequera.BeginCheck = False
        Me.xlk_chequera.CheckText = Nothing
        Me.xlk_chequera.ComboMode = False
        Me.xlk_chequera.DataMember = Nothing
        Me.xlk_chequera.DataSource = Me.LibXConnector1
        Me.xlk_chequera.DestParameters = New String() {"chequera=chequera", "xtxt_chequera_name=descripcion", "lblBceInicial=balance_ult_concil"}
        Me.xlk_chequera.FilterField = "descripcion"
        Me.xlk_chequera.IgnoreFindInBrowseMode = False
        Me.xlk_chequera.isCanceled = False
        Me.xlk_chequera.Location = New System.Drawing.Point(456, 48)
        Me.xlk_chequera.LookCaption = "Cuentas Bancarias"
        Me.xlk_chequera.Name = "xlk_chequera"
        Me.xlk_chequera.PopupSize = New System.Drawing.Size(600, 300)
        Me.xlk_chequera.ShowFilter = True
        Me.xlk_chequera.ShowMessageNotFound = True
        Me.xlk_chequera.ShowWarning = False
        Me.xlk_chequera.Size = New System.Drawing.Size(16, 20)
        Me.xlk_chequera.SizesColumns = New String() {"descripcion=300"}
        Me.xlk_chequera.SizesColumnsTab = Nothing
        Me.xlk_chequera.SqlString = Nothing
        Me.xlk_chequera.SQLTab = Nothing
        Me.xlk_chequera.SrcParameters = New String() {"chequera=chequera"}
        Me.xlk_chequera.TabIndex = 12
        Me.xlk_chequera.TableName = "cpchequera"
        Me.xlk_chequera.TabStop = False
        Me.xlk_chequera.UseCopyConnection = False
        Me.xlk_chequera.UseRowRetrieveEvents = False
        Me.xlk_chequera.UseTab = False
        Me.xlk_chequera.VisParameters = New String() {"Chequera=chequera", "Nombre=descripcion", "Cuenta Banco=cuenta_banco"}
        Me.xlk_chequera.WhereCondition = Nothing
        Me.xlk_chequera.WhereParameters = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(248, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha Corte:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(424, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Estatus:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_chequera
        '
        Me.xtxt_chequera.AcceptsReturn = True
        Me.xtxt_chequera.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbconcm.chequera"))
        Me.xtxt_chequera.EditInitialValue = Nothing
        Me.xtxt_chequera.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_chequera.FieldDescription = ""
        Me.xtxt_chequera.FindInitialValue = Nothing
        Me.xtxt_chequera.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chequera.IgnoreRequiered = False
        Me.xtxt_chequera.Location = New System.Drawing.Point(144, 48)
        Me.xtxt_chequera.Name = "xtxt_chequera"
        Me.xtxt_chequera.NewInitialValue = Nothing
        Me.xtxt_chequera.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chequera.Requiered = False
        Me.xtxt_chequera.Size = New System.Drawing.Size(88, 20)
        Me.xtxt_chequera.StatusBarPanelDescripcion = Nothing
        Me.xtxt_chequera.TabIndex = 3
        Me.xtxt_chequera.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(77, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Chequera:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_chequera_name
        '
        Me.xtxt_chequera_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xtxt_chequera_name.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.xtxt_chequera_name.Location = New System.Drawing.Point(240, 48)
        Me.xtxt_chequera_name.Name = "xtxt_chequera_name"
        Me.xtxt_chequera_name.Size = New System.Drawing.Size(208, 20)
        Me.xtxt_chequera_name.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(86, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Número:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_conc_serial
        '
        Me.xtxt_conc_serial.AcceptsReturn = True
        Me.xtxt_conc_serial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbconcm.conc_serial"))
        Me.xtxt_conc_serial.EditInitialValue = Nothing
        Me.xtxt_conc_serial.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_conc_serial.FieldDescription = ""
        Me.xtxt_conc_serial.FindInitialValue = Nothing
        Me.xtxt_conc_serial.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_conc_serial.IgnoreRequiered = False
        Me.xtxt_conc_serial.Location = New System.Drawing.Point(144, 24)
        Me.xtxt_conc_serial.Name = "xtxt_conc_serial"
        Me.xtxt_conc_serial.NewInitialValue = Nothing
        Me.xtxt_conc_serial.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_conc_serial.Requiered = False
        Me.xtxt_conc_serial.Size = New System.Drawing.Size(88, 20)
        Me.xtxt_conc_serial.StatusBarPanelDescripcion = Nothing
        Me.xtxt_conc_serial.TabIndex = 3
        Me.xtxt_conc_serial.Text = ""
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(696, 24)
        Me.LibXNavigator1.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xcbo_estatus)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.xtx_disferencia)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.XTextBox3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.btnReversar)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xtxt_chequera)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.xlk_chequera)
        Me.GroupBox1.Controls.Add(Me.xtxt_chequera_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xtxt_conc_serial)
        Me.GroupBox1.Controls.Add(Me.xcbo_doc_status)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaCorte)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 168)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'xcbo_estatus
        '
        Me.xcbo_estatus.AllowDefaultSort = True
        Me.xcbo_estatus.bound = True
        Me.xcbo_estatus.currValue = Nothing
        Me.xcbo_estatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cbconcm.estatus"))
        Me.xcbo_estatus.DefaultWhereString = Nothing
        Me.xcbo_estatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_estatus.EditInitialValue = ""
        Me.xcbo_estatus.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_estatus.FieldDescription = ""
        Me.xcbo_estatus.FindInitialValue = ""
        Me.xcbo_estatus.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_estatus.IgnoreRequiered = False
        Me.xcbo_estatus.Items.AddRange(New Object() {"1-Todos", "2-Emitidos", "3-Transito"})
        Me.xcbo_estatus.Location = New System.Drawing.Point(480, 48)
        Me.xcbo_estatus.LookupKeyDisplayFields = Nothing
        Me.xcbo_estatus.LookupKeyField = Nothing
        Me.xcbo_estatus.LookupTableName = Nothing
        Me.xcbo_estatus.Name = "xcbo_estatus"
        Me.xcbo_estatus.NewInitialValue = "2"
        Me.xcbo_estatus.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xcbo_estatus.Requiered = False
        Me.xcbo_estatus.Required = False
        Me.xcbo_estatus.Size = New System.Drawing.Size(104, 21)
        Me.xcbo_estatus.SqlString = Nothing
        Me.xcbo_estatus.StatusBarPanelDescripcion = Nothing
        Me.xcbo_estatus.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(70, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Disferencia:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtx_disferencia
        '
        Me.xtx_disferencia.AcceptsReturn = True
        Me.xtx_disferencia.EditInitialValue = Nothing
        Me.xtx_disferencia.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtx_disferencia.FieldDescription = ""
        Me.xtx_disferencia.FindInitialValue = Nothing
        Me.xtx_disferencia.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtx_disferencia.IgnoreRequiered = False
        Me.xtx_disferencia.Location = New System.Drawing.Point(144, 120)
        Me.xtx_disferencia.Name = "xtx_disferencia"
        Me.xtx_disferencia.NewInitialValue = Nothing
        Me.xtx_disferencia.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtx_disferencia.Requiered = False
        Me.xtx_disferencia.Size = New System.Drawing.Size(88, 20)
        Me.xtx_disferencia.StatusBarPanelDescripcion = Nothing
        Me.xtx_disferencia.TabIndex = 29
        Me.xtx_disferencia.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(30, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Balance Conciliado:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbconcm.Saldo_conciliado"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(144, 96)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(88, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 27
        Me.XTextBox3.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(350, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Balance Segun Banco:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbconcm.Saldo_Banco"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(480, 72)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(96, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 25
        Me.XTextBox2.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(22, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Balance Segun Libro:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cbconcm.Saldo_Libro"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(144, 72)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(88, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 23
        Me.XTextBox1.Text = ""
        '
        'btnReversar
        '
        Me.btnReversar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReversar.Location = New System.Drawing.Point(592, 72)
        Me.btnReversar.Name = "btnReversar"
        Me.btnReversar.Size = New System.Drawing.Size(75, 40)
        Me.btnReversar.TabIndex = 22
        Me.btnReversar.Text = "Reversar"
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Location = New System.Drawing.Point(592, 24)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 40)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Cerrar"
        '
        'p_cbdocs02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(696, 230)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.KeyPreview = True
        Me.Name = "p_cbdocs02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Generar Conciliacion"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Dim oReport As LibX.ReportLib
        Dim SelecStmt As String
        Dim Fec_ini As DateTime
        Dim cFecha, eFecha As String
        Dim fConcil, cEdate As String
        Dim sWhere As String
        Dim sEstatus As String

        Try
            
            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
                oReport = New LibX.ReportLib("CTB", "r_cbconc01.rpt")
                ''opcion agrada b
                'If Not (Me.xcbo_estatus.SelectedValue) Then
                '    sEstatus = Me.xcbo_estatus.SelectedValue
                'End If

                'If sEstatus <> "" Then
                '    If sEstatus = 1 Then
                '        sWhere = String.Concat(sWhere, " and cbconcm.estatus = ", Val(xcbo_estatus.SelectedValue))
                '    End If
                '    If sEstatus = 2 Then
                '        sWhere = String.Concat(sWhere, " and cbconcm.estatus = ", Val(xcbo_estatus.SelectedValue))
                '    End If
                'End If

                With oReport
                    eFecha = FechaConcilAnterior(LibXConnector1.CurrentDataRow!chequera, Year(Me.xdt_FechaCorte.Value) & "-" & Month(Me.xdt_FechaCorte.Value) & "-" & CType(Me.xdt_FechaCorte.Value, Date).Day & "'")
                    cFecha = Year(eFecha) & "-" & Month(eFecha) & "-" & CType(eFecha, Date).ToString("dd")
                    cEdate = LibXConnector1.CurrentDataRow!conc_date
                    fConcil = Year(cEdate) & "-" & Month(cEdate) & "-" & CType(cEdate, Date).ToString("dd")

                    If LibX.IsNull(xcbo_estatus.SelectedValue) Then
                        xcbo_estatus.SelectedValue = 1
                    End If

                    .ParameterFields(1) = String.Concat("@Serial;", LibXConnector1.CurrentDataRow!conc_serial.ToString.Trim, ";TRUE")
                    .ParameterFields(2) = String.Concat("@Fdate;", cFecha, ";TRUE")
                    .ParameterFields(3) = String.Concat("@fConc;", fConcil, ";TRUE")
                    .ParameterFields(4) = String.Concat("@Chequera;", Me.xtxt_chequera.Text, ";TRUE")
                    .ParameterFields(5) = String.Concat("@estatus;", Me.xcbo_estatus.SelectedValue, ";true")
                    .RetrieveSQLQuery()
                    .Action = 1
                End With
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        'opcion agregada b
        Try
            If e.AcceptedAction <> LibX.LibxConnectionActions.Find Then
                xcbo_estatus.Enabled = False
            Else
                xcbo_estatus.Enabled = True
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If Not e.row Is Nothing Then
                Me.btnClose.Enabled = (e.row!conc_status = 2)
                Me.btnReversar.Enabled = (e.row!conc_status <> 2)
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ChangingState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangingState
        Dim Disferencia As Decimal
        Me.btnClose.Enabled = e.isEditing = False AndAlso LibXConnector1.HasRecords = True AndAlso LibXConnector1.CurrentDataRow!conc_status = 2
        Me.btnReversar.Enabled = e.isEditing = False AndAlso LibXConnector1.HasRecords = True AndAlso LibXConnector1.CurrentDataRow!conc_status = 1
        If e.action = LibX.LibxConnectionActions.Cancel Or e.action = LibX.LibxConnectionActions.Find Then
            Me.xtx_disferencia.Text = ""
        End If
        If Me.XTextBox1.Text <> "" And Me.XTextBox3.Text <> "" Then
            Disferencia = CDbl(Me.XTextBox1.Text) - CDbl(XTextBox3.Text)
            Me.xtx_disferencia.Text = Disferencia
        End If
       
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim saldoAnterior As Decimal
        Dim saldoConciliado As Decimal
        Try
            If MessageBox.Show("Seguro desea CERRAR esta conciliacion?", "CERRAR Conciliacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If
            If CDbl(Me.xtx_disferencia.Text) <> 0 Then
                Throw New ApplicationException("Esta conciliacion no esta cuadrada!")
            End If
            oPermisos = New SGT.Administracion.Entidades.Permission
            oParamPerm = New SGT.Administracion.Entidades.Permission.ParametrosValidar
            oBalance = New SGT.ControlBancario.Entidades.Chequera(LibXConnector1.CurrentDataRow!chequera)

            oParamPerm.AccessKey = "CC"
            oParamPerm.UserID = LibX.User.UserID

            If oPermisos.isAutorization(oParamPerm) = False Then
                Throw New ApplicationException("No tiene permiso para cerrar conciliacion!")
            End If

            XUpdate = New LibX.Data.XUpdateStmt("cpchequera")
            If LibXConnector1.CurrentDataRow!saldo_conciliado = 0 Then
                saldoAnterior = LibXConnector1.CurrentDataRow!saldo_ant
                XUpdate.FieldsSet("balance_ult_concil") = saldoAnterior
            Else
                saldoConciliado = LibXConnector1.CurrentDataRow!saldo_conciliado
                XUpdate.FieldsSet("balance_ult_concil") = saldoConciliado
            End If
            XUpdate.FieldsSet("fecha_conciliacion") = LibXConnector1.CurrentDataRow!conc_date
            XUpdate.Fields("chequera") = LibXConnector1.CurrentDataRow!chequera
            XUpdate.Execute()

            mSaldoConAnterior = oBalance.ConcliadoAnterior(LibXConnector1.CurrentDataRow!chequera, LibXConnector1.CurrentDataRow!conc_serial)
            mSaldoAnterir = oBalance.SaldoAnterior(LibXConnector1.CurrentDataRow!chequera, LibXConnector1.CurrentDataRow!conc_serial)

            XUpdate = New LibX.Data.XUpdateStmt("cbconcm")
            XUpdate.FieldsSet("conc_status") = 1 '/ Cerrar
            If mSaldoConAnterior > 0 Then
                XUpdate.FieldsSet("saldo_ant") = mSaldoConAnterior
            Else
                XUpdate.FieldsSet("saldo_ant") = mSaldoAnterir
            End If
            XUpdate.Fields("conc_serial") = LibXConnector1.CurrentDataRow!conc_serial
            XUpdate.Execute()

            LibXConnector1.ExecuteFind("cbconcm.conc_serial = " & LibXConnector1.CurrentDataRow!conc_serial.ToString.Trim)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnReversar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReversar.Click
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim oConcilAnt As DataRow
        Try
            If VerificaConAnterior(LibXConnector1.CurrentDataRow!conc_serial + 1) = True Then
                Throw New ApplicationException("Antes debe reversar la conciliacion que esta despues de esta!")
            End If

            If MessageBox.Show("Seguro desea REVERSAR esta conciliacion?", "REVERSAR Conciliacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If
            oPermisos = New SGT.Administracion.Entidades.Permission
            oParamPerm = New SGT.Administracion.Entidades.Permission.ParametrosValidar
            oBalance = New SGT.ControlBancario.Entidades.Chequera(LibXConnector1.CurrentDataRow!chequera)

            oParamPerm.AccessKey = "RC"
            oParamPerm.UserID = LibX.User.UserID

            If oPermisos.isAutorization(oParamPerm) = False Then
                Throw New ApplicationException("No tiene permiso para reversar conciliacion!")
            End If

            XUpdate = New LibX.Data.XUpdateStmt("cpchequera")
            XUpdate.FieldsSet("balance_ult_concil") = oBalance.SaldoAnterior(LibXConnector1.CurrentDataRow!chequera, LibXConnector1.CurrentDataRow!conc_serial)
            XUpdate.FieldsSet("fecha_conciliacion") = oBalance.FechaAnterior(LibXConnector1.CurrentDataRow!chequera, LibXConnector1.CurrentDataRow!conc_date)
            XUpdate.Fields("chequera") = LibXConnector1.CurrentDataRow!chequera
            XUpdate.Execute()

            XUpdate = New LibX.Data.XUpdateStmt("cbconcm")
            XUpdate.FieldsSet("conc_status") = 2 '/ PENDIENTE
            XUpdate.Fields("conc_serial") = LibXConnector1.CurrentDataRow!conc_serial
            XUpdate.Execute()

            LibXConnector1.ReQuery()
            LibXConnector1.RefreshSources()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Function ReverMoviCol(ByVal sErialConsil As Integer)
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim oConcilAnt As DataTable
        Dim SQLQuery As String

        Try
            SQLQuery = "select cbm_serial from cbdocsm where conc_serial = " & sErialConsil
            oConcilAnt = LibX.Data.Manager.GetDataTable(SQLQuery)

            For Each oRow As DataRow In oConcilAnt.Rows
                XUpdate = New LibX.Data.XUpdateStmt("cbdocsm")
                XUpdate.FieldsSet("conc_serial") = ""
                XUpdate.Fields("cbm_serial") = oRow!cbm_serial
                XUpdate.Execute()
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Function
    Private Function FechaConcilAnterior(ByVal Chequera As Integer, ByVal FechaCorte As DateTime) As DateTime
        Dim SelectStmt As String
        Dim fEcha_conc As DateTime
        Dim Mfechaini As String
        Dim aNio, mEs, dIa As String
        Dim newMes As Integer
        Dim lastDaymes As Integer
        Try
            '//Fecha Conciliacion Anterior
            fEcha_conc = LibX.Data.Manager.GetScalar("select conc_date from cbconcm where chequera =" & Chequera.ToString & _
                         " and conc_date < '" & FechaCorte.ToString(LibX.Data.Manager.GetSaveDateFormat) & "'")

            If fEcha_conc = Nothing Then
                fEcha_conc = LibX.Data.Manager.GetScalar("select min(doc_date) from cbdocsm where month(doc_date) =" & Month(LibXConnector1.CurrentDataRow!conc_date.ToString.Trim) & _
                                                          " and year(doc_date) =" & Year(LibXConnector1.CurrentDataRow!conc_date.ToString.Trim))
            End If

            dIa = fEcha_conc.Day.ToString("00")
            mEs = fEcha_conc.Month.ToString("00")
            aNio = fEcha_conc.Year.ToString("0000")

            ''//Decterminar cual es el ultimo dia del mes para construir la fecha de inicio en la busqueda
            lastDaymes = LibX.Data.Manager.GetScalar("select day(dateadd(d,-1,dateadd(m,1,convert(datetime,'" & aNio & "' + " & "'" & mEs & "' + " & "'01'))))")

            newMes = mEs

            Mfechaini = aNio & "/" & newMes.ToString("00") & "/" & dIa

            Return Mfechaini

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Function
    Private Function VerificaConAnterior(ByVal sErialConsil As Integer) As Boolean
        Dim oConcilAnt As Integer
        Dim SQLQuery As String

        Try
            SQLQuery = "select count(*) from cbconcm where conc_status = 1 and conc_serial >= " & sErialConsil

            oConcilAnt = LibX.Data.Manager.GetScalar(SQLQuery)

            If oConcilAnt > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Function
    Private Sub p_cbdocs02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            oPermisos = New SGT.Administracion.Entidades.Permission

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

End Class
