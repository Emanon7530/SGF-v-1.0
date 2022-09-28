Imports SGT.Contabilidad.Entidades
Public Class r_tranr01
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents txtPerdr_year As System.Windows.Forms.TextBox
    Friend WithEvents txtperdr_num As System.Windows.Forms.TextBox
    Friend WithEvents xlk_dept_code As LibX.LibXLookup
    Friend WithEvents xdt_FechaInicial As LibX.LibxDateTimePicker
    Friend WithEvents xdt_FechaFinal As LibX.LibxDateTimePicker
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txttran_number As System.Windows.Forms.TextBox
    Friend WithEvents lbltype_code As System.Windows.Forms.Label
    Friend WithEvents txttype_code As System.Windows.Forms.TextBox
    Friend WithEvents RbtDetallado As System.Windows.Forms.RadioButton
    Friend WithEvents RbtResumido As System.Windows.Forms.RadioButton
    Friend WithEvents RbtDescuadre As System.Windows.Forms.RadioButton
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents xtxsuc_name As System.Windows.Forms.Label
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents xtxSuc_code As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RbtDescuadre = New System.Windows.Forms.RadioButton
        Me.RbtResumido = New System.Windows.Forms.RadioButton
        Me.RbtDetallado = New System.Windows.Forms.RadioButton
        Me.Txttran_number = New System.Windows.Forms.TextBox
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
        Me.Label6 = New System.Windows.Forms.Label
        Me.xdt_FechaFinal = New LibX.LibxDateTimePicker
        Me.xdt_FechaInicial = New LibX.LibxDateTimePicker
        Me.xlk_dept_code = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.lbltype_code = New System.Windows.Forms.Label
        Me.txtPerdr_year = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtperdr_num = New System.Windows.Forms.TextBox
        Me.txttype_code = New System.Windows.Forms.TextBox
        Me.btnIniciar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.xtxsuc_name = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.xtxSuc_code = New System.Windows.Forms.TextBox
        Me.DataColumn11 = New System.Data.DataColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(560, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LISTADO DE MOVIMIENTOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.xtxsuc_name)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.xtxSuc_code)
        Me.GroupBox1.Controls.Add(Me.RbtDescuadre)
        Me.GroupBox1.Controls.Add(Me.RbtResumido)
        Me.GroupBox1.Controls.Add(Me.RbtDetallado)
        Me.GroupBox1.Controls.Add(Me.Txttran_number)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaFinal)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaInicial)
        Me.GroupBox1.Controls.Add(Me.xlk_dept_code)
        Me.GroupBox1.Controls.Add(Me.lbltype_code)
        Me.GroupBox1.Controls.Add(Me.txtPerdr_year)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtperdr_num)
        Me.GroupBox1.Controls.Add(Me.txttype_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 176)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'RbtDescuadre
        '
        Me.RbtDescuadre.Location = New System.Drawing.Point(265, 63)
        Me.RbtDescuadre.Name = "RbtDescuadre"
        Me.RbtDescuadre.TabIndex = 25
        Me.RbtDescuadre.Text = "Descuadre"
        '
        'RbtResumido
        '
        Me.RbtResumido.Checked = True
        Me.RbtResumido.Location = New System.Drawing.Point(265, 43)
        Me.RbtResumido.Name = "RbtResumido"
        Me.RbtResumido.TabIndex = 24
        Me.RbtResumido.TabStop = True
        Me.RbtResumido.Text = "Resumido"
        '
        'RbtDetallado
        '
        Me.RbtDetallado.Location = New System.Drawing.Point(265, 22)
        Me.RbtDetallado.Name = "RbtDetallado"
        Me.RbtDetallado.TabIndex = 23
        Me.RbtDetallado.Text = "Detallado"
        '
        'Txttran_number
        '
        Me.Txttran_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgperdd.tran_number"))
        Me.Txttran_number.Location = New System.Drawing.Point(104, 142)
        Me.Txttran_number.Name = "Txttran_number"
        Me.Txttran_number.Size = New System.Drawing.Size(88, 20)
        Me.Txttran_number.TabIndex = 22
        Me.Txttran_number.Text = ""
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"perdr_year", "perdr_num"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2}
        Me.DataTable1.TableName = "cgperdd"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "perdr_year"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "perdr_num"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "from_date"
        Me.DataColumn3.DataType = GetType(System.DateTime)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "thru_date"
        Me.DataColumn4.DataType = GetType(System.DateTime)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "perdr_status"
        Me.DataColumn5.MaxLength = 1
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "perdr_begin"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "ic_balance"
        Me.DataColumn7.DataType = GetType(System.Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "result_balance"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "type_code"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "tran_number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(44, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Numero:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.xdt_FechaFinal.Location = New System.Drawing.Point(104, 72)
        Me.xdt_FechaFinal.Name = "xdt_FechaFinal"
        Me.xdt_FechaFinal.NewInitialValue = Nothing
        Me.xdt_FechaFinal.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.Requiered = False
        Me.xdt_FechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.xdt_FechaFinal.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaFinal.TabIndex = 20
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
        Me.xdt_FechaInicial.Location = New System.Drawing.Point(104, 48)
        Me.xdt_FechaInicial.Name = "xdt_FechaInicial"
        Me.xdt_FechaInicial.NewInitialValue = Nothing
        Me.xdt_FechaInicial.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicial.Requiered = False
        Me.xdt_FechaInicial.Size = New System.Drawing.Size(104, 20)
        Me.xdt_FechaInicial.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaInicial.TabIndex = 19
        '
        'xlk_dept_code
        '
        Me.xlk_dept_code.AlternateFieldSearch = Nothing
        Me.xlk_dept_code.BeginCheck = False
        Me.xlk_dept_code.CheckText = Nothing
        Me.xlk_dept_code.ComboMode = False
        Me.xlk_dept_code.DataMember = Nothing
        Me.xlk_dept_code.DataSource = Me.LibXConnector1
        Me.xlk_dept_code.DestParameters = New String() {"txttype_code=type_code", "lbltype_code=type_name"}
        Me.xlk_dept_code.FilterField = Nothing
        Me.xlk_dept_code.IgnoreFindInBrowseMode = False
        Me.xlk_dept_code.isCanceled = False
        Me.xlk_dept_code.Location = New System.Drawing.Point(437, 119)
        Me.xlk_dept_code.LookCaption = Nothing
        Me.xlk_dept_code.Name = "xlk_dept_code"
        Me.xlk_dept_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_dept_code.ShowFilter = True
        Me.xlk_dept_code.ShowMessageNotFound = True
        Me.xlk_dept_code.ShowWarning = False
        Me.xlk_dept_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_dept_code.SizesColumns = Nothing
        Me.xlk_dept_code.SizesColumnsTab = Nothing
        Me.xlk_dept_code.SqlString = Nothing
        Me.xlk_dept_code.SQLTab = Nothing
        Me.xlk_dept_code.SrcParameters = New String() {"type_code = type_code"}
        Me.xlk_dept_code.TabIndex = 18
        Me.xlk_dept_code.TableName = "ivtypem"
        Me.xlk_dept_code.TabStop = False
        Me.xlk_dept_code.UseCopyConnection = False
        Me.xlk_dept_code.UseRowRetrieveEvents = False
        Me.xlk_dept_code.UseTab = False
        Me.xlk_dept_code.VisParameters = New String() {"Código=type_code", "Nombre=type_name"}
        Me.xlk_dept_code.WhereCondition = Nothing
        Me.xlk_dept_code.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "cgperdd"
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
        Me.LibXDbSourceTable1.TableName = "cgperdd"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'lbltype_code
        '
        Me.lbltype_code.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltype_code.Location = New System.Drawing.Point(188, 119)
        Me.lbltype_code.Name = "lbltype_code"
        Me.lbltype_code.Size = New System.Drawing.Size(256, 20)
        Me.lbltype_code.TabIndex = 16
        '
        'txtPerdr_year
        '
        Me.txtPerdr_year.Location = New System.Drawing.Point(104, 24)
        Me.txtPerdr_year.Name = "txtPerdr_year"
        Me.txtPerdr_year.Size = New System.Drawing.Size(48, 20)
        Me.txtPerdr_year.TabIndex = 15
        Me.txtPerdr_year.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(16, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Periodo Actual:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(40, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo Doc.:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(26, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha Inicial:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(30, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha Final:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtperdr_num
        '
        Me.txtperdr_num.Location = New System.Drawing.Point(160, 24)
        Me.txtperdr_num.Name = "txtperdr_num"
        Me.txtperdr_num.Size = New System.Drawing.Size(48, 20)
        Me.txtperdr_num.TabIndex = 15
        Me.txtperdr_num.Text = ""
        '
        'txttype_code
        '
        Me.txttype_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgperdd.type_code"))
        Me.txttype_code.Location = New System.Drawing.Point(104, 119)
        Me.txttype_code.Name = "txttype_code"
        Me.txttype_code.Size = New System.Drawing.Size(88, 20)
        Me.txttype_code.TabIndex = 15
        Me.txttype_code.Text = ""
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(480, 64)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.TabIndex = 2
        Me.btnIniciar.Text = "Iniciar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(480, 88)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 239)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(560, 23)
        Me.ProgressBar1.TabIndex = 13
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"suc_code=suc_code", "xtxsuc_name=suc_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(438, 95)
        Me.LibXLookup1.LookCaption = Nothing
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
        Me.LibXLookup1.SrcParameters = New String() {"suc_code=suc_code"}
        Me.LibXLookup1.TabIndex = 29
        Me.LibXLookup1.TableName = "cgsucursal"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=suc_code", "Nombre=suc_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'xtxsuc_name
        '
        Me.xtxsuc_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xtxsuc_name.Location = New System.Drawing.Point(188, 95)
        Me.xtxsuc_name.Name = "xtxsuc_name"
        Me.xtxsuc_name.Size = New System.Drawing.Size(256, 20)
        Me.xtxsuc_name.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(40, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Sucursal:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxSuc_code
        '
        Me.xtxSuc_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgperdd.suc_code"))
        Me.xtxSuc_code.Location = New System.Drawing.Point(104, 95)
        Me.xtxSuc_code.Name = "xtxSuc_code"
        Me.xtxSuc_code.Size = New System.Drawing.Size(88, 20)
        Me.xtxSuc_code.TabIndex = 27
        Me.xtxSuc_code.Text = ""
        '
        'DataColumn11
        '
        Me.DataColumn11.Caption = "suc_code"
        Me.DataColumn11.ColumnName = "suc_code"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'r_tranr01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 262)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Name = "r_tranr01"
        Me.Text = "Listado de Movimientos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim oPeriodo As Periodo
    Dim WithEvents oAnoFiscal As AnoFiscal

    Private Sub p_acctpr01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            LibXConnector1.Find()

            oAnoFiscal = New AnoFiscal
            oPeriodo = oAnoFiscal.BuscarPeriodoActual

            txtperdr_num.Text = oPeriodo.Number.ToString
            txtperdr_year.Text = oPeriodo.year.ToString

            LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year.ToString
            LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number.ToString

            xdt_FechaInicial.Value = oPeriodo.From
            xdt_FechaFinal.Value = oPeriodo.Thru

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        Dim oReport As LibX.ReportLib
        Dim SQLString As String
        Dim WhereString As String
        Try

            If txtperdr_num.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgtranrm.perdr_num = " & txtperdr_num.Text)
            End If

            If txtPerdr_year.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgtranrm.perdr_year= " & txtPerdr_year.Text)
            End If

            If txttype_code.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgtranrm.tran_type = '" & txttype_code.Text & "'")
            End If

            If Txttran_number.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgtranrm.tran_number='" & Txttran_number.Text & "'")
            End If

            If Val(xtxSuc_code.Text.Trim) > 0 Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgtranrm.suc_code = " & Val(xtxSuc_code.Text))
            End If


            WhereString = LibX.ConcatWherePart(WhereString, "cgtranrm.tran_date between '" & _
                                CDate(xdt_FechaInicial.Value).ToString(LibX.Data.Manager.GetSaveDateFormat) & _
                                "' and '" & CDate(xdt_FechaFinal.Value).ToString(LibX.Data.Manager.GetSaveDateFormat) & "'")

            If Me.RbtDetallado.Checked = True Then
                oReport = New LibX.ReportLib("CTG", "r_tranrp02.rpt")
            End If
            If Me.RbtResumido.Checked = True Then
                oReport = New LibX.ReportLib("CTG", "r_tranrp04.rpt")
            End If
            If Me.RbtDescuadre.Checked = True Then
                oReport = New LibX.ReportLib("CTG", "r_tranrp03.rpt")
            End If

            oReport.RetrieveSQLQuery()
            SQLString = oReport.SQLQuery
            SQLString = LibX.ConcatWherePart(SQLString, WhereString)
            oReport.SQLQuery = SQLString

            oReport.ParameterFields(0) = String.Concat("Fecha_ini;", Trim(xdt_FechaInicial.Value), ";TRUE")
            oReport.ParameterFields(1) = String.Concat("Fecha_fin;", Trim(xdt_FechaInicial.Value), ";TRUE")

            oReport.Action = 1

            '  btnIniciar.Enabled = False
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("Seguro desea cerrar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

End Class
