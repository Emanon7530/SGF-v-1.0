Imports SGT.Contabilidad
Imports SGT.Contabilidad.Entidades
Imports SGT.Contabilidad.Operaciones
Public Class p_pstccpr01
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
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
    Friend WithEvents txtperdr_year As System.Windows.Forms.TextBox
    Friend WithEvents txtperdr_num As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_facturacion As System.Windows.Forms.CheckBox
    Friend WithEvents chk_inventario As System.Windows.Forms.CheckBox
    Friend WithEvents txtDept_name As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents xdt_FechaInicial As LibX.LibxDateTimePicker
    Friend WithEvents xdt_FechaFinal As LibX.LibxDateTimePicker
    Friend WithEvents txttran_number As System.Windows.Forms.TextBox
    Friend WithEvents chk_cxc As System.Windows.Forms.CheckBox
    Friend WithEvents chk_cxp As System.Windows.Forms.CheckBox
    Friend WithEvents xtxttype_code As System.Windows.Forms.TextBox
    Friend WithEvents chk_control As System.Windows.Forms.CheckBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents rbt_Aplicar As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_Reversar As System.Windows.Forms.RadioButton
    Friend WithEvents xlk_chequera As LibX.LibXLookup
    Friend WithEvents txtChequera As System.Windows.Forms.TextBox
    Friend WithEvents Chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbltype_name As System.Windows.Forms.TextBox
    Friend WithEvents xtxsuc_code As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXLookup2 = New LibX.LibXLookup
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
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.xtxsuc_code = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.rbt_Aplicar = New System.Windows.Forms.RadioButton
        Me.xdt_FechaFinal = New LibX.LibxDateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.xlk_chequera = New LibX.LibXLookup
        Me.txtDept_name = New System.Windows.Forms.TextBox
        Me.txtChequera = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Chk_todos = New System.Windows.Forms.CheckBox
        Me.chk_cxp = New System.Windows.Forms.CheckBox
        Me.chk_cxc = New System.Windows.Forms.CheckBox
        Me.chk_facturacion = New System.Windows.Forms.CheckBox
        Me.chk_inventario = New System.Windows.Forms.CheckBox
        Me.chk_control = New System.Windows.Forms.CheckBox
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.lbltype_name = New System.Windows.Forms.TextBox
        Me.xtxttype_code = New System.Windows.Forms.TextBox
        Me.xdt_FechaInicial = New LibX.LibxDateTimePicker
        Me.txtperdr_year = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtperdr_num = New System.Windows.Forms.TextBox
        Me.txttran_number = New System.Windows.Forms.TextBox
        Me.rbt_Reversar = New System.Windows.Forms.RadioButton
        Me.btnIniciar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(688, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GENERAR ENTRADAS DE DIARIO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXLookup2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.xtxsuc_code)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.rbt_Aplicar)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaFinal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.xlk_chequera)
        Me.GroupBox1.Controls.Add(Me.txtDept_name)
        Me.GroupBox1.Controls.Add(Me.txtChequera)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.lbltype_name)
        Me.GroupBox1.Controls.Add(Me.xtxttype_code)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaInicial)
        Me.GroupBox1.Controls.Add(Me.txtperdr_year)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtperdr_num)
        Me.GroupBox1.Controls.Add(Me.txttran_number)
        Me.GroupBox1.Controls.Add(Me.rbt_Reversar)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 248)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"suc_code=suc_code", "TextBox1=suc_name"}
        Me.LibXLookup2.FilterField = "suc_name"
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(416, 120)
        Me.LibXLookup2.LookCaption = "Sucursales"
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
        Me.LibXLookup2.SrcParameters = New String() {"suc_code=suc_code"}
        Me.LibXLookup2.TabIndex = 31
        Me.LibXLookup2.TableName = "cgsucursal"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=suc_code", "Nombre=suc_name"}
        Me.LibXLookup2.WhereCondition = ""
        Me.LibXLookup2.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "cgtranrm"
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
        Me.LibXConnector1.UseTransactions = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"tranr_serial"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "cgtranrm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "tranr_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "tran_type"
        Me.DataColumn2.MaxLength = 3
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "tran_number"
        Me.DataColumn3.MaxLength = 10
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "tran_date"
        Me.DataColumn4.DataType = GetType(System.DateTime)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "date_created"
        Me.DataColumn5.DataType = GetType(System.DateTime)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "tran_descr"
        Me.DataColumn6.MaxLength = 80
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "tran_status"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "orign_code"
        Me.DataColumn8.MaxLength = 3
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "userid"
        Me.DataColumn9.MaxLength = 18
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "tran_reverse"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "perdr_year"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "perdr_num"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "tran_refer"
        Me.DataColumn13.MaxLength = 60
        '
        'DataColumn14
        '
        Me.DataColumn14.Caption = "chequera"
        Me.DataColumn14.ColumnName = "chequera"
        Me.DataColumn14.DataType = GetType(System.Int16)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "tran_date1"
        Me.DataColumn15.DataType = GetType(System.DateTime)
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "suc_code"
        Me.DataColumn16.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.TableName = "cgtranrm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(200, 120)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(216, 20)
        Me.TextBox1.TabIndex = 30
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = ""
        '
        'xtxsuc_code
        '
        Me.xtxsuc_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.suc_code"))
        Me.xtxsuc_code.Location = New System.Drawing.Point(112, 120)
        Me.xtxsuc_code.Name = "xtxsuc_code"
        Me.xtxsuc_code.Size = New System.Drawing.Size(88, 20)
        Me.xtxsuc_code.TabIndex = 28
        Me.xtxsuc_code.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(45, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Sucursal:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'rbt_Aplicar
        '
        Me.rbt_Aplicar.Location = New System.Drawing.Point(112, 16)
        Me.rbt_Aplicar.Name = "rbt_Aplicar"
        Me.rbt_Aplicar.Size = New System.Drawing.Size(144, 24)
        Me.rbt_Aplicar.TabIndex = 0
        Me.rbt_Aplicar.Text = "Aplicar a Contabilidad"
        '
        'xdt_FechaFinal
        '
        Me.xdt_FechaFinal.CustomFormat = "dd/MM/yyyy"
        Me.xdt_FechaFinal.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cgtranrm.tran_date1"))
        Me.xdt_FechaFinal.EditInitialValue = Nothing
        Me.xdt_FechaFinal.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.FieldDescription = ""
        Me.xdt_FechaFinal.FindInitialValue = Nothing
        Me.xdt_FechaFinal.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaFinal.IgnoreRequiered = False
        Me.xdt_FechaFinal.Location = New System.Drawing.Point(344, 96)
        Me.xdt_FechaFinal.Name = "xdt_FechaFinal"
        Me.xdt_FechaFinal.NewInitialValue = Nothing
        Me.xdt_FechaFinal.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.Requiered = False
        Me.xdt_FechaFinal.Size = New System.Drawing.Size(88, 20)
        Me.xdt_FechaFinal.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaFinal.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(240, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Fecha Final:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_chequera
        '
        Me.xlk_chequera.AlternateFieldSearch = Nothing
        Me.xlk_chequera.BeginCheck = False
        Me.xlk_chequera.CheckText = Nothing
        Me.xlk_chequera.ComboMode = False
        Me.xlk_chequera.DataMember = Nothing
        Me.xlk_chequera.DataSource = Me.LibXConnector1
        Me.xlk_chequera.DestParameters = New String() {"chequera=chequera", "txtdept_name=descripcion"}
        Me.xlk_chequera.FilterField = Nothing
        Me.xlk_chequera.IgnoreFindInBrowseMode = False
        Me.xlk_chequera.isCanceled = False
        Me.xlk_chequera.Location = New System.Drawing.Point(416, 168)
        Me.xlk_chequera.LookCaption = "Chequeras"
        Me.xlk_chequera.Name = "xlk_chequera"
        Me.xlk_chequera.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_chequera.ShowFilter = True
        Me.xlk_chequera.ShowMessageNotFound = True
        Me.xlk_chequera.ShowWarning = False
        Me.xlk_chequera.Size = New System.Drawing.Size(16, 20)
        Me.xlk_chequera.SizesColumns = Nothing
        Me.xlk_chequera.SizesColumnsTab = Nothing
        Me.xlk_chequera.SqlString = Nothing
        Me.xlk_chequera.SQLTab = Nothing
        Me.xlk_chequera.SrcParameters = New String() {"chequera=chequera"}
        Me.xlk_chequera.TabIndex = 26
        Me.xlk_chequera.TableName = "cpchequera"
        Me.xlk_chequera.TabStop = False
        Me.xlk_chequera.UseCopyConnection = False
        Me.xlk_chequera.UseRowRetrieveEvents = False
        Me.xlk_chequera.UseTab = False
        Me.xlk_chequera.VisParameters = New String() {"Código=chequera", "Nombre=descripcion"}
        Me.xlk_chequera.WhereCondition = Nothing
        Me.xlk_chequera.WhereParameters = Nothing
        '
        'txtDept_name
        '
        Me.txtDept_name.Location = New System.Drawing.Point(200, 168)
        Me.txtDept_name.Name = "txtDept_name"
        Me.txtDept_name.ReadOnly = True
        Me.txtDept_name.Size = New System.Drawing.Size(216, 20)
        Me.txtDept_name.TabIndex = 25
        Me.txtDept_name.TabStop = False
        Me.txtDept_name.Text = ""
        '
        'txtChequera
        '
        Me.txtChequera.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.chequera"))
        Me.txtChequera.Location = New System.Drawing.Point(112, 168)
        Me.txtChequera.Name = "txtChequera"
        Me.txtChequera.Size = New System.Drawing.Size(88, 20)
        Me.txtChequera.TabIndex = 7
        Me.txtChequera.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(41, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Chequera:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Chk_todos)
        Me.GroupBox2.Controls.Add(Me.chk_cxp)
        Me.GroupBox2.Controls.Add(Me.chk_cxc)
        Me.GroupBox2.Controls.Add(Me.chk_facturacion)
        Me.GroupBox2.Controls.Add(Me.chk_inventario)
        Me.GroupBox2.Controls.Add(Me.chk_control)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(440, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 176)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Módulo"
        '
        'Chk_todos
        '
        Me.Chk_todos.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Chk_todos.Location = New System.Drawing.Point(16, 16)
        Me.Chk_todos.Name = "Chk_todos"
        Me.Chk_todos.Size = New System.Drawing.Size(88, 16)
        Me.Chk_todos.TabIndex = 24
        Me.Chk_todos.Text = "Todos"
        '
        'chk_cxp
        '
        Me.chk_cxp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk_cxp.Location = New System.Drawing.Point(16, 81)
        Me.chk_cxp.Name = "chk_cxp"
        Me.chk_cxp.Size = New System.Drawing.Size(104, 16)
        Me.chk_cxp.TabIndex = 23
        Me.chk_cxp.Text = "Cuenta x Pagar"
        '
        'chk_cxc
        '
        Me.chk_cxc.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk_cxc.Location = New System.Drawing.Point(16, 65)
        Me.chk_cxc.Name = "chk_cxc"
        Me.chk_cxc.Size = New System.Drawing.Size(112, 16)
        Me.chk_cxc.TabIndex = 22
        Me.chk_cxc.Text = "Cuenta x Cobrar"
        '
        'chk_facturacion
        '
        Me.chk_facturacion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk_facturacion.Location = New System.Drawing.Point(16, 32)
        Me.chk_facturacion.Name = "chk_facturacion"
        Me.chk_facturacion.Size = New System.Drawing.Size(88, 16)
        Me.chk_facturacion.TabIndex = 20
        Me.chk_facturacion.Text = "Facturación"
        '
        'chk_inventario
        '
        Me.chk_inventario.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk_inventario.Location = New System.Drawing.Point(16, 49)
        Me.chk_inventario.Name = "chk_inventario"
        Me.chk_inventario.Size = New System.Drawing.Size(80, 16)
        Me.chk_inventario.TabIndex = 21
        Me.chk_inventario.Text = "Inventario"
        '
        'chk_control
        '
        Me.chk_control.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk_control.Location = New System.Drawing.Point(16, 97)
        Me.chk_control.Name = "chk_control"
        Me.chk_control.Size = New System.Drawing.Size(104, 16)
        Me.chk_control.TabIndex = 23
        Me.chk_control.Text = "Control Bancario"
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"xtxttype_code=type_code", "lbltype_name=type_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(416, 144)
        Me.LibXLookup1.LookCaption = "Tipos de Documentos"
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
        Me.LibXLookup1.SrcParameters = New String() {"xtxttype_code=type_code"}
        Me.LibXLookup1.TabIndex = 19
        Me.LibXLookup1.TableName = "ivtypem"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Documento=type_code", "Descripción=type_name"}
        Me.LibXLookup1.WhereCondition = "apply_ctg=1"
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'lbltype_name
        '
        Me.lbltype_name.Location = New System.Drawing.Point(200, 144)
        Me.lbltype_name.Name = "lbltype_name"
        Me.lbltype_name.ReadOnly = True
        Me.lbltype_name.Size = New System.Drawing.Size(216, 20)
        Me.lbltype_name.TabIndex = 18
        Me.lbltype_name.TabStop = False
        Me.lbltype_name.Text = ""
        '
        'xtxttype_code
        '
        Me.xtxttype_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.tran_type"))
        Me.xtxttype_code.Location = New System.Drawing.Point(112, 144)
        Me.xtxttype_code.Name = "xtxttype_code"
        Me.xtxttype_code.Size = New System.Drawing.Size(88, 20)
        Me.xtxttype_code.TabIndex = 6
        Me.xtxttype_code.Text = ""
        '
        'xdt_FechaInicial
        '
        Me.xdt_FechaInicial.CustomFormat = "dd/MM/yyyy"
        Me.xdt_FechaInicial.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cgtranrm.tran_date"))
        Me.xdt_FechaInicial.EditInitialValue = Nothing
        Me.xdt_FechaInicial.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicial.FieldDescription = ""
        Me.xdt_FechaInicial.FindInitialValue = Nothing
        Me.xdt_FechaInicial.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaInicial.IgnoreRequiered = False
        Me.xdt_FechaInicial.Location = New System.Drawing.Point(112, 96)
        Me.xdt_FechaInicial.Name = "xdt_FechaInicial"
        Me.xdt_FechaInicial.NewInitialValue = Nothing
        Me.xdt_FechaInicial.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicial.Requiered = False
        Me.xdt_FechaInicial.Size = New System.Drawing.Size(88, 20)
        Me.xdt_FechaInicial.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaInicial.TabIndex = 4
        '
        'txtperdr_year
        '
        Me.txtperdr_year.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.perdr_year"))
        Me.txtperdr_year.Location = New System.Drawing.Point(112, 48)
        Me.txtperdr_year.Name = "txtperdr_year"
        Me.txtperdr_year.ReadOnly = True
        Me.txtperdr_year.Size = New System.Drawing.Size(64, 20)
        Me.txtperdr_year.TabIndex = 2
        Me.txtperdr_year.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(8, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Tipo Documento:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(71, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Año:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(52, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Periodo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(27, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Fecha Inicial:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(50, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Número:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtperdr_num
        '
        Me.txtperdr_num.AcceptsReturn = True
        Me.txtperdr_num.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.perdr_num"))
        Me.txtperdr_num.Enabled = False
        Me.txtperdr_num.Location = New System.Drawing.Point(112, 72)
        Me.txtperdr_num.Name = "txtperdr_num"
        Me.txtperdr_num.ReadOnly = True
        Me.txtperdr_num.Size = New System.Drawing.Size(64, 20)
        Me.txtperdr_num.TabIndex = 3
        Me.txtperdr_num.Text = ""
        '
        'txttran_number
        '
        Me.txttran_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.tran_number"))
        Me.txttran_number.Location = New System.Drawing.Point(112, 192)
        Me.txttran_number.Name = "txttran_number"
        Me.txttran_number.Size = New System.Drawing.Size(88, 20)
        Me.txttran_number.TabIndex = 8
        Me.txttran_number.Text = ""
        '
        'rbt_Reversar
        '
        Me.rbt_Reversar.Location = New System.Drawing.Point(272, 16)
        Me.rbt_Reversar.Name = "rbt_Reversar"
        Me.rbt_Reversar.Size = New System.Drawing.Size(152, 24)
        Me.rbt_Reversar.TabIndex = 1
        Me.rbt_Reversar.Text = "Reversar de Contabilidad"
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(600, 64)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.TabIndex = 2
        Me.btnIniciar.Text = "Iniciar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(600, 232)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "Cerrar"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 319)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(688, 23)
        Me.ProgressBar1.TabIndex = 13
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(600, 88)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "Imprimir"
        '
        'p_pstccpr01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 342)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Name = "p_pstccpr01"
        Me.Text = "Generar Entradad de Diario"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim oPeriodo As Periodo
    Dim oAnoFiscal As AnoFiscal
    Dim oPaseCXC As Operaciones.GenerarEDCXC
    Dim oPaseCXP As Operaciones.GenerarEDCXP

    Dim oPaseINV As Operaciones.GenerarEDINV
    Dim oPaseFCT As Operaciones.GenerarEDFCT
    Dim oPaseCTB As Operaciones.GenerarEDCTB

    Private Sub p_acctpr01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LibXConnector1.Find()
            oAnoFiscal = New AnoFiscal
            oPeriodo = oAnoFiscal.BuscarPeriodoActual

            LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year
            LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number

            txtperdr_year.Text = oPeriodo.year.ToString
            txtperdr_num.Text = oPeriodo.Number.ToString

            LibXConnector1.CurrentDataRow!tran_date = oPeriodo.From
            LibXConnector1.CurrentDataRow!tran_date1 = oPeriodo.Thru

            xdt_FechaInicial.Value = oPeriodo.From
            xdt_FechaFinal.Value = oPeriodo.Thru
            Me.xlk_chequera.Enabled = False
            Me.txtChequera.Enabled = False
            Me.rbt_Aplicar.Checked = True
            Me.xtxttype_code.Enabled = True
            Me.LibXLookup1.Enabled = True
            Me.xdt_FechaFinal.Enabled = False

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        If rbt_Aplicar.Checked = True Then
            Aplicar()
        Else
            If rbt_Reversar.Checked = True Then
                Reversar()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("Seguro desea cerrar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub Reversar()
        Dim SelectStmt As String
        Dim sWhere As String
        Dim TranRserial As DataTable
        oPaseCXC = New Operaciones.GenerarEDCXC
        oPaseCXP = New Operaciones.GenerarEDCXP
        oPaseINV = New Operaciones.GenerarEDINV
        oPaseFCT = New Operaciones.GenerarEDFCT
        oPaseCTB = New Operaciones.GenerarEDCTB

        If MessageBox.Show("Desea Reversar una entrada?", "Reversar Entradas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        sWhere = "1=1"

        If Me.xtxttype_code.Text <> "" Then
            sWhere = LibX.ConcatWherePart(sWhere, "cgtranrm.tran_type = '" & Me.xtxttype_code.Text & "'")
        End If
        If Val(Me.xtxsuc_code.Text) > 0 Then
            sWhere = LibX.ConcatWherePart(sWhere, "cgtranrm.suc_code = " & Val(Me.xtxsuc_code.Text))
        End If

        '// cuenta x cobrar
        If chk_cxc.Checked = True Then

            SelectStmt = "select tranr_serial from cgtranrm where orign_code = 'CXC' and  perdr_year ='" & Me.txtperdr_year.Text & "'" & _
                     " and perdr_num =" & Me.txtperdr_num.Text & " and tran_status <> 1 "

            SelectStmt = LibX.ConcatWherePart(SelectStmt, sWhere)

            TranRserial = LibX.Data.Manager.GetDataTable(SelectStmt)

            If TranRserial.Rows.Count > 0 Then
                For Each oRow As DataRow In TranRserial.Rows
                    If oPaseCXC.Reversar(oRow!tranr_serial) = True Then
                    End If
                Next
                MessageBox.Show("Entrada de CXC Reversada existiosamente!", "Reversar Entradas cuentas por cobrar")
            End If
        End If

        '// cuenta x pagar
        If chk_cxp.Checked = True Then

            SelectStmt = "select tranr_serial from cgtranrm where orign_code = 'CXP' and  perdr_year ='" & Me.txtperdr_year.Text & "'" & _
                  " and perdr_num ='" & Me.txtperdr_num.Text & "' and tran_status <> 1 "

            SelectStmt = LibX.ConcatWherePart(SelectStmt, sWhere)
            TranRserial = LibX.Data.Manager.GetDataTable(SelectStmt)

            If TranRserial.Rows.Count > 0 Then
                For Each oRow As DataRow In TranRserial.Rows
                    If oPaseCXP.Reversar(orow!tranr_serial) = True Then
                    End If
                Next
                MessageBox.Show("Entrada de CXP reversada existiosamente!", "Reversar Entradas de cuentas por pagar")
            End If
        End If

        '// inventario
        If chk_inventario.Checked = True Then

            SelectStmt = "select tranr_serial from cgtranrm where orign_code = 'INV' and  perdr_year =" & Me.txtperdr_year.Text & _
                 " and perdr_num =" & Me.txtperdr_num.Text & " and tran_status <> 1 "

            SelectStmt = LibX.ConcatWherePart(SelectStmt, sWhere)
            TranRserial = LibX.Data.Manager.GetDataTable(SelectStmt)

            If TranRserial.Rows.Count > 0 Then
                For Each oRow As DataRow In TranRserial.Rows
                    If oPaseINV.Reversar(orow!tranr_serial) = True Then
                    End If
                Next
                MessageBox.Show("Entrada de INV reversada existiosamente!", "Reversar Entradas de Inventario")
            End If
        End If

        '// facturacion
        If chk_facturacion.Checked = True Then

            SelectStmt = "select tranr_serial from cgtranrm where orign_code = 'FCT' and  perdr_year =" & Me.txtperdr_year.Text & _
                             " and perdr_num =" & Me.txtperdr_num.Text & " and tran_status <> 1 "

            SelectStmt = LibX.ConcatWherePart(SelectStmt, sWhere)
            TranRserial = LibX.Data.Manager.GetDataTable(SelectStmt)

            If TranRserial.Rows.Count > 0 Then
                For Each oRow As DataRow In TranRserial.Rows
                    If oPaseFCT.Reversar(orow!tranr_serial) = True Then
                    End If
                Next
                MessageBox.Show("Entrada de FCT reversada existiosamente!", "Reversar Entradas de Facturacion")
            End If
        End If


        ''// Control Bancario
        If chk_control.Checked = True Then

            SelectStmt = "select tranr_serial from cgtranrm where orign_code = 'CTB' and  perdr_year =" & Me.txtperdr_year.Text & _
                             " and perdr_num =" & Me.txtperdr_num.Text & " and tran_status <> 1 "

            SelectStmt = LibX.ConcatWherePart(SelectStmt, sWhere)
            TranRserial = LibX.Data.Manager.GetDataTable(SelectStmt)

            If TranRserial.Rows.Count > 0 Then
                For Each oRow As DataRow In TranRserial.Rows
                    If oPaseCTB.Reversar(orow!tranr_serial) = True Then
                    End If
                Next
                MessageBox.Show("Entrada de CTB reversada existiosamente!", "Reversar Entradas de Control Bancario")
            End If
        End If

    End Sub
    Private Sub Aplicar()
        Dim oParamCXC As Operaciones.ParametrosGenerarEDCXC
        Dim oParamCXP As Operaciones.ParametrosGenerarEDCXP
        Dim oParamINV As Operaciones.ParametrosGenerarEDINV
        Dim oParamFCT As Operaciones.ParametrosGenerarEDFCT
        Dim oParamCTB As Operaciones.ParametrosGenerarEDCTB

        Try

            If MessageBox.Show("Desea iniciar la generación?", "Generar Entradas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If

            oPaseCXC = New Operaciones.GenerarEDCXC
            oPaseCXP = New Operaciones.GenerarEDCXP
            oPaseINV = New Operaciones.GenerarEDINV
            oPaseFCT = New Operaciones.GenerarEDFCT
            oPaseCTB = New Operaciones.GenerarEDCTB

            oParamCXC = New Operaciones.ParametrosGenerarEDCXC
            oParamCXP = New Operaciones.ParametrosGenerarEDCXP
            oParamINV = New Operaciones.ParametrosGenerarEDINV
            oParamFCT = New Operaciones.ParametrosGenerarEDFCT
            oParamCTB = New Operaciones.ParametrosGenerarEDCTB

            oPeriodo.year = Val(LibXConnector1.CurrentDataRow!perdr_year.ToString)
            oPeriodo.Number = Val(LibXConnector1.CurrentDataRow!perdr_num.ToString)

            If Me.xtxttype_code.Text.Trim <> "" Then
                oParamCXC.TipoDocumento = LibXConnector1.CurrentDataRow!tran_type.ToString.Trim
                oParamCXP.TipoDocumento = LibXConnector1.CurrentDataRow!tran_type.ToString.Trim
                oParamINV.TipoDocumento = LibXConnector1.CurrentDataRow!tran_type.ToString.Trim
                oParamFCT.TipoDocumento = LibXConnector1.CurrentDataRow!tran_type.ToString.Trim
                oParamCTB.TipoDocumento = LibXConnector1.CurrentDataRow!tran_type.ToString.Trim
            End If

            If Me.txttran_number.Text.Trim <> "" Then
                oParamCXC.Numero = LibXConnector1.CurrentDataRow!tran_number.ToString.Trim
                oParamCXP.Numero = LibXConnector1.CurrentDataRow!tran_number.ToString.Trim
                oParamINV.Numero = LibXConnector1.CurrentDataRow!tran_number.ToString.Trim
                oParamFCT.Numero = LibXConnector1.CurrentDataRow!tran_number.ToString.Trim
                oParamCTB.Numero = LibXConnector1.CurrentDataRow!tran_number.ToString.Trim
            End If

            If Val(Me.xtxsuc_code.Text.Trim) > 0 Then
                oParamCXC.Sucursal = LibXConnector1.CurrentDataRow!suc_code.ToString.Trim
                oParamCXP.Sucursal = LibXConnector1.CurrentDataRow!suc_code.ToString.Trim
                oParamINV.Sucursal = LibXConnector1.CurrentDataRow!suc_code.ToString.Trim
                oParamFCT.Sucursal = LibXConnector1.CurrentDataRow!suc_code.ToString.Trim
                oParamCTB.Sucursal = LibXConnector1.CurrentDataRow!suc_code.ToString.Trim
            End If

            oParamCXC.FechaInicial = CType(Me.xdt_FechaInicial.Value, Date)
            oParamCXP.FechaInicial = CType(Me.xdt_FechaInicial.Value, Date)
            oParamINV.FechaInicial = CType(Me.xdt_FechaInicial.Value, Date)
            oParamFCT.FechaInicial = CType(Me.xdt_FechaInicial.Value, Date)
            oParamCTB.FechaInicial = CType(Me.xdt_FechaInicial.Value, Date)

            oParamCXC.FechaFinal = CType(Me.xdt_FechaFinal.Value, Date)
            oParamCXP.FechaFinal = CType(Me.xdt_FechaFinal.Value, Date)
            oParamINV.FechaFinal = CType(Me.xdt_FechaFinal.Value, Date)
            oParamFCT.FechaFinal = CType(Me.xdt_FechaFinal.Value, Date)
            oParamCTB.FechaFinal = CType(Me.xdt_FechaFinal.Value, Date)

            If Me.txtChequera.Text.Trim <> "" Then
                oParamCXC.Chequera = Me.txtChequera.Text
                oParamCXP.Chequera = Me.txtChequera.Text
                oParamINV.Chequera = Me.txtChequera.Text
                oParamFCT.Chequera = Me.txtChequera.Text
                oParamCTB.Chequera = Me.txtChequera.Text
            End If

            If Chk_todos.Checked = True Then
                If oPaseCXC.Buscar(Me.xtxttype_code.Text, Val(Me.xtxsuc_code.Text), oPeriodo.year, oPeriodo.Number) = False Then
                    oPaseCXC.Aplicar(oParamCXC)
                End If
                If oPaseCXP.Buscar(Me.xtxttype_code.Text, Val(Me.xtxsuc_code.Text), oPeriodo.year, oPeriodo.Number) = False Then
                    oPaseCXP.Aplicar(oParamCXP)
                End If
                If oPaseINV.Buscar(Me.xtxttype_code.Text, Val(Me.xtxsuc_code.Text), oPeriodo.year, oPeriodo.Number) = False Then
                    oPaseINV.Aplicar(oParamINV)
                End If
                If oPaseFCT.Buscar(Me.xtxttype_code.Text, Val(Me.xtxsuc_code.Text), oPeriodo.year, oPeriodo.Number) = False Then
                    oPaseFCT.Aplicar(oParamFCT)
                End If
                If oPaseCTB.Buscar(Me.xtxttype_code.Text, Val(Me.xtxsuc_code.Text), oPeriodo.year, oPeriodo.Number) = False Then
                    oPaseCTB.Aplicar(oParamCTB)
                End If
                MessageBox.Show("Proceso terminado existiosamente!", "Generar Entradas de todos")
            Else
                '// cuenta x cobrar
                If chk_cxc.Checked = True Then
                    If oPaseCXC.Buscar(Me.xtxttype_code.Text, Val(Me.xtxsuc_code.Text), oPeriodo.year, oPeriodo.Number) = True Then
                        Throw New ApplicationException("Esta entrada para este ya ha sido generada, Verifique!")
                    End If
                    If oPaseCXC.Aplicar(oParamCXC) = True Then
                        MessageBox.Show("Proceso terminado existiosamente!", "Generar Entradas de Cuenta x Cobrar")
                    Else
                        MessageBox.Show("Proceso terminado!", "No se encotro movimiento de CXC para este periodo")
                    End If
                End If

                '// cuenta x pagar
                If chk_cxp.Checked = True Then
                    If oPaseCXP.Buscar(Me.xtxttype_code.Text, Val(Me.xtxsuc_code.Text), oPeriodo.year, oPeriodo.Number) = True Then
                        Throw New ApplicationException("Esta entrada para este ya ha sido generada, Verifique!")
                    End If
                    If oPaseCXP.Aplicar(oParamCXP) = True Then
                        MessageBox.Show("Proceso terminado existiosamente!", "Generar Entradas de Cuenta x Pagar")
                    Else
                        MessageBox.Show("Proceso terminado!", "No se encotro movimiento de CXP para este periodo")
                    End If
                End If

                '// inventario
                If chk_inventario.Checked = True Then
                    If oPaseINV.Buscar(Me.xtxttype_code.Text, Val(Me.xtxsuc_code.Text), oPeriodo.year, oPeriodo.Number) = True Then
                        Throw New ApplicationException("Esta entrada para este periodo ya ha sido generada, Verifique!")
                    End If
                    If oPaseINV.Aplicar(oParamINV) = True Then
                        MessageBox.Show("Proceso terminado existiosamente!", "Generar Entradas de Inventario")
                    Else
                        MessageBox.Show("Proceso terminado!", "No se encotro movimiento de INV para este periodo")
                    End If
                End If

                '// facturacion
                If chk_facturacion.Checked = True Then
                    If oPaseFCT.Buscar(Me.xtxttype_code.Text, Val(Me.xtxsuc_code.Text), oPeriodo.year, oPeriodo.Number) = True Then
                        Throw New ApplicationException("Esta entrada para este periodo ya ha sido generada, Verifique!")
                    End If
                    If oPaseFCT.Aplicar(oParamFCT) = True Then
                        MessageBox.Show("Proceso terminado existiosamente!", "Generar Entradas de Facturacion")
                    Else
                        MessageBox.Show("Proceso terminado!", "No se encotro movimiento de FCT para este periodo")
                    End If
                End If

                '// Control Bancario
                If chk_control.Checked = True Then
                    If oPaseCTB.Buscar(Me.xtxttype_code.Text, Val(Me.xtxsuc_code.Text), oPeriodo.year, oPeriodo.Number) = True Then
                        Throw New ApplicationException("Esta entrada ya ha sido generada, Verifique!")
                    End If
                    If oPaseCTB.Aplicar(oParamCTB) = True Then
                        MessageBox.Show("Proceso terminado existiosamente!", "Generar Entradas de Control Bancario")
                    Else
                        MessageBox.Show("Proceso terminado!", "No se encotro movimiento de LIBRO para este periodo")
                    End If
                End If
            End If

            'btnIniciar.Enabled = False
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub
    Private Sub rbt_Reversar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_Reversar.CheckedChanged
        If rbt_Reversar.Checked = True Then 'And Me.chk_control.Checked = False Then
            Label1.Text = "REVERSAR ENTRADAS DE DIARIO"
            Me.xlk_chequera.Enabled = False
            Me.xlk_chequera.Clear(True)
        Else
            Me.xlk_chequera.Enabled = True
        End If
        Me.txttran_number.Enabled = False
    End Sub

    Private Sub rbt_Aplicar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_Aplicar.CheckedChanged
        If Me.rbt_Aplicar.Checked = True Then 'And Me.chk_control.Checked = False Then
            Label1.Text = "GENERAR ENTRADAS DE DIARIO"
            If chk_control.Checked = False Then
                Me.xlk_chequera.Enabled = False
                Me.xlk_chequera.Clear(True)
            Else
                Me.xlk_chequera.Enabled = True
            End If
            Me.txttran_number.Enabled = True
        End If
    End Sub

    Private Sub xdt_FechaInicial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xdt_FechaInicial.ValueChanged
        Try
            oPeriodo = oAnoFiscal.BuscarPeriodoPorFecha(Me.xdt_FechaInicial.Text)
            LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year
            LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number

            txtperdr_year.Text = oPeriodo.year.ToString
            txtperdr_num.Text = oPeriodo.Number.ToString
            xdt_FechaFinal.Text = oPeriodo.Thru

            LibXConnector1.CurrentDataRow!tran_date = oPeriodo.From
            LibXConnector1.CurrentDataRow!tran_date1 = oPeriodo.Thru

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub chk_control_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_control.CheckedChanged
        If Me.chk_control.Checked = True And Me.Chk_todos.Checked = False Then
            Me.xlk_chequera.Enabled = True
            Me.txtChequera.Enabled = True
            Me.chk_facturacion.Checked = False
            Me.chk_inventario.Checked = False
            Me.chk_cxp.Checked = False
            Me.chk_cxc.Checked = False
        End If
        If Me.chk_control.Checked = True Then
            Me.xlk_chequera.Enabled = True
        Else
            Me.xlk_chequera.Enabled = False
            Me.txtChequera.Enabled = False
            Me.txtChequera.Text = ""
            Me.txtDept_name.Text = ""
        End If
    End Sub

    Private Sub Chk_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_todos.CheckedChanged
        If Me.Chk_todos.Checked = True Then
            Me.chk_inventario.Checked = True
            Me.chk_facturacion.Checked = True
            Me.chk_cxp.Checked = True
            Me.chk_cxc.Checked = True
            Me.chk_control.Checked = True
            Me.xlk_chequera.Enabled = True
            Me.txtChequera.Enabled = True
            Me.xtxttype_code.Enabled = False
            Me.LibXLookup1.Enabled = False
            Me.lbltype_name.Text = ""
            Me.xtxttype_code.Text = ""
        Else
            Me.chk_inventario.Checked = False
            Me.chk_facturacion.Checked = False
            Me.chk_cxp.Checked = False
            Me.chk_cxc.Checked = False
            Me.chk_control.Checked = False
            Me.xlk_chequera.Enabled = False
            Me.txtChequera.Enabled = False
            Me.xtxttype_code.Enabled = True
            Me.LibXLookup1.Enabled = True
            Me.txtChequera.Text = ""
            Me.txtDept_name.Text = ""
        End If
    End Sub

    Private Sub chk_facturacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_facturacion.CheckedChanged
        If Me.chk_facturacion.Checked = True And Me.Chk_todos.Checked = False Then
            Me.chk_inventario.Checked = False
            Me.chk_cxp.Checked = False
            Me.chk_cxc.Checked = False
            Me.chk_control.Checked = False
        End If
    End Sub

    Private Sub chk_inventario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_inventario.CheckedChanged
        If Me.chk_inventario.Checked = True And Me.Chk_todos.Checked = False Then
            Me.chk_facturacion.Checked = False
            Me.chk_cxp.Checked = False
            Me.chk_cxc.Checked = False
            Me.chk_control.Checked = False
        End If

    End Sub

    Private Sub chk_cxc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cxc.CheckedChanged
        If Me.chk_cxc.Checked = True And Me.Chk_todos.Checked = False Then
            Me.chk_facturacion.Checked = False
            Me.chk_cxp.Checked = False
            Me.chk_inventario.Checked = False
            Me.chk_control.Checked = False
        End If
    End Sub

    Private Sub chk_cxp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cxp.CheckedChanged
        If Me.chk_cxp.Checked = True And Me.Chk_todos.Checked = False Then
            Me.chk_facturacion.Checked = False
            Me.chk_cxc.Checked = False
            Me.chk_inventario.Checked = False
            Me.chk_control.Checked = False
        End If
    End Sub
End Class
