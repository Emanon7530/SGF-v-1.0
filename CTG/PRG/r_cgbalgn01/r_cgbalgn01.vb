Imports SGT.Contabilidad.Entidades
Public Class r_cgbalgn01
    Inherits System.Windows.Forms.Form
    Dim Serial As String
    Dim mDel As DataRow
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents txtPerdr_year As System.Windows.Forms.TextBox
    Friend WithEvents txtperdr_num As System.Windows.Forms.TextBox
    Friend WithEvents txtDept_code As System.Windows.Forms.TextBox
    Friend WithEvents lbldept_name As System.Windows.Forms.Label
    Friend WithEvents xlk_dept_code As LibX.LibXLookup
    Friend WithEvents xdt_FechaFinal As LibX.LibxDateTimePicker
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents cgbalgenm As System.Data.DataTable
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
    Friend WithEvents Chk_acumul As System.Windows.Forms.CheckBox
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents xtxsuc_code As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Chk_acumul = New System.Windows.Forms.CheckBox
        Me.xdt_FechaFinal = New LibX.LibxDateTimePicker
        Me.xlk_dept_code = New LibX.LibXLookup
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
        Me.cgbalgenm = New System.Data.DataTable
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
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.lbldept_name = New System.Windows.Forms.Label
        Me.txtPerdr_year = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtperdr_num = New System.Windows.Forms.TextBox
        Me.txtDept_code = New System.Windows.Forms.TextBox
        Me.btnIniciar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label4 = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.Label6 = New System.Windows.Forms.Label
        Me.xtxsuc_code = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cgbalgenm, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Text = "BALANZA GENERAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xtxsuc_code)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Chk_acumul)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaFinal)
        Me.GroupBox1.Controls.Add(Me.xlk_dept_code)
        Me.GroupBox1.Controls.Add(Me.lbldept_name)
        Me.GroupBox1.Controls.Add(Me.txtPerdr_year)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtperdr_num)
        Me.GroupBox1.Controls.Add(Me.txtDept_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 128)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Chk_acumul
        '
        Me.Chk_acumul.Location = New System.Drawing.Point(360, 16)
        Me.Chk_acumul.Name = "Chk_acumul"
        Me.Chk_acumul.Size = New System.Drawing.Size(80, 24)
        Me.Chk_acumul.TabIndex = 21
        Me.Chk_acumul.Text = "Acumulado"
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
        Me.xdt_FechaFinal.Location = New System.Drawing.Point(104, 95)
        Me.xdt_FechaFinal.Name = "xdt_FechaFinal"
        Me.xdt_FechaFinal.NewInitialValue = Nothing
        Me.xdt_FechaFinal.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.Requiered = False
        Me.xdt_FechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.xdt_FechaFinal.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaFinal.TabIndex = 20
        '
        'xlk_dept_code
        '
        Me.xlk_dept_code.AlternateFieldSearch = Nothing
        Me.xlk_dept_code.BeginCheck = False
        Me.xlk_dept_code.CheckText = Nothing
        Me.xlk_dept_code.ComboMode = False
        Me.xlk_dept_code.DataMember = Nothing
        Me.xlk_dept_code.DataSource = Me.LibXConnector1
        Me.xlk_dept_code.DestParameters = New String() {"txtDept_code=dept_code", "lbldept_name=dept_name"}
        Me.xlk_dept_code.FilterField = Nothing
        Me.xlk_dept_code.IgnoreFindInBrowseMode = False
        Me.xlk_dept_code.isCanceled = False
        Me.xlk_dept_code.Location = New System.Drawing.Point(424, 71)
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
        Me.xlk_dept_code.SrcParameters = New String() {"dept_code=txtDept_code"}
        Me.xlk_dept_code.TabIndex = 18
        Me.xlk_dept_code.TableName = "cgdeptm"
        Me.xlk_dept_code.TabStop = False
        Me.xlk_dept_code.UseCopyConnection = False
        Me.xlk_dept_code.UseRowRetrieveEvents = False
        Me.xlk_dept_code.UseTab = False
        Me.xlk_dept_code.VisParameters = New String() {"Código=dept_code", "Nombre=dept_name"}
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.cgbalgenm})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn21})
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
        'cgbalgenm
        '
        Me.cgbalgenm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn22})
        Me.cgbalgenm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"cgcb_serial", "line_no"}, True)})
        Me.cgbalgenm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn16, Me.DataColumn11}
        Me.cgbalgenm.TableName = "cgbalgenm"
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "perdr_year"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "perdr_num"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "line_no"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "acct_type"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "acct_no"
        Me.DataColumn13.MaxLength = 20
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "acct_name"
        Me.DataColumn14.MaxLength = 50
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "balance"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "cgcb_serial"
        Me.DataColumn16.MaxLength = 10
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "balg_date"
        Me.DataColumn17.DataType = GetType(System.DateTime)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "nivel_id"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "grupo_id"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "tipo_result"
        Me.DataColumn20.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable2.TableName = "cgbalgenm"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'DataColumn21
        '
        Me.DataColumn21.AllowDBNull = False
        Me.DataColumn21.ColumnName = "suc_code"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "suc_code"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'lbldept_name
        '
        Me.lbldept_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldept_name.Location = New System.Drawing.Point(160, 71)
        Me.lbldept_name.Name = "lbldept_name"
        Me.lbldept_name.Size = New System.Drawing.Size(264, 20)
        Me.lbldept_name.TabIndex = 16
        '
        'txtPerdr_year
        '
        Me.txtPerdr_year.Location = New System.Drawing.Point(104, 24)
        Me.txtPerdr_year.Name = "txtPerdr_year"
        Me.txtPerdr_year.Size = New System.Drawing.Size(56, 20)
        Me.txtPerdr_year.TabIndex = 15
        Me.txtPerdr_year.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(16, 24)
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
        Me.Label3.Location = New System.Drawing.Point(18, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Departamento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(30, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha Corte:"
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
        'txtDept_code
        '
        Me.txtDept_code.Location = New System.Drawing.Point(104, 71)
        Me.txtDept_code.Name = "txtDept_code"
        Me.txtDept_code.Size = New System.Drawing.Size(56, 20)
        Me.txtDept_code.TabIndex = 15
        Me.txtDept_code.Text = ""
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
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 191)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(560, 23)
        Me.ProgressBar1.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(160, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = " "
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"suc_code=suc_code", "Label4=suc_name"}
        Me.LibXLookup1.FilterField = "suc_name"
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(424, 48)
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
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"suc_code=suc_code"}
        Me.LibXLookup1.TabIndex = 24
        Me.LibXLookup1.TableName = "cgsucursal"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=suc_code", "Nombre=suc_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(48, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Sucursal:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxsuc_code
        '
        Me.xtxsuc_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgbalgenm.suc_code"))
        Me.xtxsuc_code.Location = New System.Drawing.Point(104, 48)
        Me.xtxsuc_code.Name = "xtxsuc_code"
        Me.xtxsuc_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxsuc_code.TabIndex = 26
        Me.xtxsuc_code.Text = " "
        '
        'r_cgbalgn01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 214)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Name = "r_cgbalgn01"
        Me.Text = "Balanza General"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cgbalgenm, System.ComponentModel.ISupportInitialize).EndInit()
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
            txtPerdr_year.Text = oPeriodo.year.ToString

            LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year.ToString
            LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number.ToString

            xdt_FechaFinal.Value = oPeriodo.Thru

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim oReport As LibX.ReportLib
        Dim SelecStmt, SelecStmt1, SelecStmt2 As String
        Dim sWhere As String
        Dim Periodo, Anio As Integer
        Dim xSelect As LibX.Data.XSelecStmt
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim xDelete As LibX.Data.XDeleteStmt
        Dim oEstado, oSucursal As DataTable
        Dim mEstado As DataTable
        Dim ID, Count, ic_status, oSucur As Integer
        Dim iC_resulBal, bal As Decimal
        Dim thru_date As String
        Try

            If txtperdr_num.Text.Trim <> "" And txtPerdr_year.Text.Trim <> "" Then
                If Me.Chk_acumul.Checked = True Then
                    sWhere = LibX.ConcatWherePart(sWhere, "(cgacctd.perdr_num <= " & txtperdr_num.Text & _
                                                          " and cgacctd.perdr_year = " & txtPerdr_year.Text & ") or ") & _
                                                          " (cgacctd.perdr_num = 13  and cgacctd.perdr_year = " & _
                                                          Val(txtPerdr_year.Text) - 1 & ")"
                Else
                    sWhere = LibX.ConcatWherePart(sWhere, " cgacctd.perdr_num = " & txtperdr_num.Text)
                End If
            End If

            If txtPerdr_year.Text.Trim <> "" Then
                '''If Me.Chk_acumul.Checked = True Then
                '''    sWhere = LibX.ConcatWherePart(sWhere, "(cgacctd.perdr_num = 13 " & _
                '''                                  " and cgacctd.perdr_year = " & Val(txtPerdr_year.Text) - 1 & ")")
                '''Else
                sWhere = LibX.ConcatWherePart(sWhere, " cgacctd.perdr_year = " & txtPerdr_year.Text)
                '''End If
            End If

            If txtDept_code.Text.Trim <> "" Then
                sWhere = LibX.ConcatWherePart(sWhere, " cgacctd.dept_code = " & txtDept_code.Text)
            End If
            If Val(xtxsuc_code.Text) > 0 Then
                sWhere = LibX.ConcatWherePart(sWhere, " cgacctd.suc_code = " & Val(xtxsuc_code.Text))
                oSucur = Val(Me.xtxsuc_code.Text)
            End If
            sWhere = LibX.ConcatWherePart(sWhere, " cgacctd.balance <> 0 ")
            '//Buscar el Inventario del periodo anterior 

            Periodo = Val(txtperdr_num.Text) - 1
            If Periodo = 0 Then
                Periodo = 13
            End If

            If Periodo = 12 Then
                Anio = Val(txtPerdr_year.Text) - 1
            Else
                Anio = Val(txtPerdr_year.Text)
            End If

            SelecStmt = " select cgcb_serial,perdr_num,perdr_year from cgbalgenm"
            mDel = LibX.Data.Manager.GetDataRow(SelecStmt)

            If mDel Is Nothing Then
            Else
                xDelete = New LibX.Data.XDeleteStmt("cgbalgenm")
                xDelete.Fields("cgcb_serial") = mDel!cgcb_serial
                xDelete.Execute()
            End If

            Serial = Val(txtperdr_num.Text).ToString("00") & "-" & Val(txtPerdr_year.Text)

            If oSucur > 0 Then
                SelecStmt = "select * from cgsucursal where suc_code = " & oSucur
            Else
                SelecStmt = "select * from cgsucursal"
            End If
            oSucursal = LibX.Data.Manager.GetDataTable(SelecStmt)

            For Each oRow1 As DataRow In oSucursal.Rows
                If Chk_acumul.Checked = True Then
                    SelecStmt = " select cgacctd.suc_code,estfn_tipo,cgacctd.perdr_year,acct_type,cgestfnd.acct_no," & _
                                " cgestfnd.estfn_groupid,isnull(estfn_nivel,0)estfn_nivel,cgestfnd.acct_descr," & _
                                " sum(cgacctd.balance) balance from cgacctd " & _
                                " inner join cgestfnd on cgacctd.acct_no=cgestfnd.acct_no " & _
                                " and cgacctd.suc_code =" & oRow1!suc_code & _
                                " inner join cgacctm on  cgacctm.acct_no=cgestfnd.acct_no " & _
                                " INNER JOIN cgestfnm on cgestfnd.estfn_code = cgestfnm.estfn_code " & _
                                " and estfn_tipo = 2 group by cgacctd.suc_code,estfn_tipo,cgacctd.perdr_year," & _
                                " acct_type,cgestfnd.acct_no,cgestfnd.estfn_groupid,estfn_nivel ,cgestfnd.acct_descr "

                    SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                    oEstado = LibX.Data.Manager.GetDataTable(SelecStmt)

                    SelecStmt = " select cgperdd.suc_code,2 estfn_tipo,cgperdd.perdr_year,3 acct_type," & _
                                     " 88888888 acct_no,5 estfn_groupid,2 estfn_nivel,'UTILIDAD O PERDIDA ACTUAL' acct_descr," & _
                                     " isnull(cgperdd.result_balance,0) balance from cgperdd " & _
                                     " where (cgperdd.perdr_year = " & txtPerdr_year.Text & _
                                     " And cgperdd.perdr_num < = " & txtperdr_num.Text & ")" & _
                                     " or (cgperdd.perdr_year = 13 " & _
                                     " And cgperdd.perdr_num < = " & Val(txtperdr_num.Text) - 1 & ")" & _
                                     " and cgperdd.suc_code = " & oRow1!suc_code

                    mEstado = LibX.Data.Manager.GetDataTable(SelecStmt)
                    If mEstado Is Nothing Then
                        GoTo Next_Sucursal
                    End If
                Else
                    SelecStmt = " select cgacctd.suc_code,estfn_tipo,cgacctd.perdr_num,cgacctd.perdr_year,acct_type,cgestfnd.acct_no," & _
                                " cgestfnd.estfn_groupid,isnull(estfn_nivel,0)estfn_nivel,cgestfnd.acct_descr," & _
                                " cgacctd.balance from cgacctd " & _
                                " inner join cgestfnd on cgacctd.acct_no=cgestfnd.acct_no " & _
                                " inner join cgacctm on  cgacctm.acct_no=cgestfnd.acct_no " & _
                                " INNER JOIN cgestfnm on cgestfnd.estfn_code = cgestfnm.estfn_code " & _
                                " and estfn_tipo = 2 and cgacctd.suc_code =" & oRow1!suc_code

                    SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)

                    SelecStmt2 = " UNION select cgperdd.suc_code,2 estfn_tipo, cgperdd.perdr_num,cgperdd.perdr_year,3 act_type," & _
                                 " 88888888 acct_no,5 estfn_groupid,2 estfn_nivel,'UTILIDAD O PERDIDA ACTUAL' acct_descr," & _
                                 " isnull(cgperdd.result_balance,0) balance from cgperdd " & _
                                 " where cgperdd.perdr_year = " & txtPerdr_year.Text & _
                                 " And cgperdd.perdr_num = " & txtperdr_num.Text & _
                                 " and cgperdd.suc_code = " & oRow1!suc_code

                    SelecStmt = SelecStmt & SelecStmt1 & SelecStmt2 & " order by suc_code,acct_type "
                    oEstado = LibX.Data.Manager.GetDataTable(SelecStmt)
                    If oEstado Is Nothing Then
                        GoTo Next_Sucursal
                    End If
                End If

                SelecStmt = " select thru_date from cgperdd  where cgperdd.perdr_year = " & txtPerdr_year.Text & _
                            " And cgperdd.perdr_num = " & txtperdr_num.Text & " and cgperdd.suc_code = " & oRow1!suc_code
                thru_date = LibX.Data.Manager.GetScalar(SelecStmt)
                ID = 1

                For Each oRow As DataRow In oEstado.Rows
                    Dim balg As DataRow = cgbalgenm.NewRow
                    ID = ID + 1
                    balg!cgcb_serial = Serial
                    balg!line_no = ID
                    balg!tipo_result = oRow!estfn_tipo
                    balg!acct_type = oRow!acct_type
                    balg!perdr_num = txtperdr_num.Text
                    balg!perdr_year = txtPerdr_year.Text
                    balg!acct_no = oRow!acct_no
                    balg!acct_name = oRow!acct_descr
                    balg!balance = oRow!balance
                    balg!balg_date = thru_date
                    balg!nivel_id = oRow!estfn_nivel
                    balg!grupo_id = oRow!estfn_groupid
                    balg!suc_code = orow!suc_code

                    If balg!cgcb_serial <> "" Then
                        cgbalgenm.Rows.Add(balg)
                    End If
                    ID = ID + 1
                    iC_resulBal = iC_resulBal + oRow!balance
                Next

                If LibX.Data.Manager.Connection.IsIntransaction = False Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                End If

                LibX.Data.Manager.Save(cgbalgenm)

                ID = ID + 1

                If Me.Chk_acumul.Checked = True Then
                    Count = mEstado.Rows.Count
                    For Each oRow As DataRow In mEstado.Rows
                        Dim ualg As DataRow = cgbalgenm.NewRow
                        bal = +oRow!balance
                        If Count <> 1 Then
                            GoTo next_row
                        Else
                            ualg!cgcb_serial = Serial
                            ualg!line_no = ID
                            ualg!tipo_result = oRow!estfn_tipo
                            ualg!acct_type = oRow!acct_type
                            ualg!perdr_num = txtperdr_num.Text
                            ualg!perdr_year = txtPerdr_year.Text
                            ualg!acct_no = oRow!acct_no
                            ualg!balance = bal
                            ualg!acct_name = oRow!acct_descr
                            ualg!balg_date = thru_date
                            ualg!nivel_id = oRow!estfn_nivel
                            ualg!grupo_id = oRow!estfn_groupid
                            ualg!suc_code = orow!suc_code

                            If ualg!cgcb_serial <> "" Then
                                cgbalgenm.Rows.Add(ualg)
                            End If
                            ID = ID + 1
                            iC_resulBal = iC_resulBal + oRow!balance
                        End If
next_row:
                        Count = Count - 1
                    Next

                    LibX.Data.Manager.Save(cgbalgenm)
                End If
Next_Sucursal:
            Next

            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            If cgbalgenm.Rows.Count > 0 Then
                imprimir()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
        End Try

    End Sub
    Private Sub imprimir()
        Dim oReport As LibX.ReportLib
        Dim SQLString As String
        Dim WhereString As String
        Dim InvInicial As Decimal
        Dim Periodo, Anio As Integer
        Try

            If txtperdr_num.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, " cgbalgenm.perdr_num = " & txtperdr_num.Text)
            End If

            If txtPerdr_year.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, " cgbalgenm.perdr_year= " & txtPerdr_year.Text)
            End If

            If txtDept_code.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, " cgbalgenm.dept_code = " & txtDept_code.Text)
            End If

            If Val(Me.xtxsuc_code.Text) > 0 Then
                WhereString = LibX.ConcatWherePart(WhereString, " cgbalgenm.suc_code = " & Val(Me.xtxsuc_code.Text))
            End If

            ''WhereString = LibX.ConcatWherePart(WhereString, " cgbalgenm.cgcb_serial = '" & Serial & "'")

            '//Buscar el Inventario del periodo anterior 
            Periodo = Val(txtperdr_num.Text) - 1
            If Periodo = 0 Then
                Periodo = 12
            End If
            If Periodo = 12 Then
                Anio = Val(txtPerdr_year.Text) - 1
            Else
                Anio = Val(txtPerdr_year.Text)
            End If

            oReport = New LibX.ReportLib("CTG", "r_cgbalgn01.rpt")

            oReport.RetrieveSQLQuery()
            SQLString = oReport.SQLQuery
            SQLString = LibX.ConcatWherePart(SQLString, WhereString)
            oReport.SQLQuery = SQLString

            oReport.Action = 1

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        Try

            Me.LibXConnector1.AcceptFind()
            Me.LibXConnector1.Find()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        'If MessageBox.Show("Seguro desea cerrar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Dialogbalg.Yes Then
        Me.Close()
        'End If
    End Sub

    Private Sub xdt_FechaFinal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xdt_FechaFinal.ValueChanged
        Try
            oPeriodo = oAnoFiscal.BuscarPeriodoPorFecha(Me.xdt_FechaFinal.Text)
            LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year
            LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number

            txtPerdr_year.Text = oPeriodo.year.ToString
            txtperdr_num.Text = oPeriodo.Number.ToString
            xdt_FechaFinal.Text = oPeriodo.Thru

            'LibXConnector1.CurrentDataRow!tran_date = oPeriodo.From
            'LibXConnector1.CurrentDataRow!tran_date1 = oPeriodo.Thru

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class
