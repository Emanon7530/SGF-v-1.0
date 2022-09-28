Public Class i_cgcdifem01
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
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents ButtonMov As System.Windows.Forms.Button
    Friend WithEvents xcbo_acct_type As LibX.LibXCombo
    Friend WithEvents xtxAcct_no As LibX.XTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As LibX.XTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtperdr_num As LibX.XTextBox
    Friend WithEvents txtPerdr_year As LibX.XTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents xdt_FechaFinal As LibX.LibxDateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.xcbo_acct_type = New LibX.LibXCombo
        Me.xtxAcct_no = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xdt_FechaFinal = New LibX.LibxDateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.txtperdr_num = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPerdr_year = New LibX.XTextBox
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18})
        Me.DataTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"cgcb_serial", "line_no"}, True)})
        Me.DataTable2.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn10, Me.DataColumn13}
        Me.DataTable2.TableName = "cgbalgenm"
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "cgcb_serial"
        Me.DataColumn10.MaxLength = 10
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
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
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "line_no"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "acct_type"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "acct_no"
        Me.DataColumn15.MaxLength = 20
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "acct_name"
        Me.DataColumn16.MaxLength = 50
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "balance"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "balg_date"
        Me.DataColumn18.DataType = GetType(System.DateTime)
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = True
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "cgbalgenm"
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
        Me.LibXConnector1.RequeryData = True
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
        Me.LibXDbSourceTable1.AutoIncrementSerial = True
        Me.LibXDbSourceTable1.CustomDbUpdate = False
        Me.LibXDbSourceTable1.DeleteOrder = 0
        Me.LibXDbSourceTable1.FillOnQuery = True
        Me.LibXDbSourceTable1.FillOnRowChange = False
        Me.LibXDbSourceTable1.HeaderIsOnGrid = False
        Me.LibXDbSourceTable1.InnerJon = True
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.LineColName = "line_no"
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cgbalgenm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(704, 24)
        Me.LibXNavigator1.TabIndex = 1
        '
        'xcbo_acct_type
        '
        Me.xcbo_acct_type.AllowDefaultSort = True
        Me.xcbo_acct_type.bound = True
        Me.xcbo_acct_type.currValue = Nothing
        Me.xcbo_acct_type.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cgbalgenm.acct_type"))
        Me.xcbo_acct_type.DefaultWhereString = Nothing
        Me.xcbo_acct_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_acct_type.EditInitialValue = Nothing
        Me.xcbo_acct_type.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_acct_type.FieldDescription = ""
        Me.xcbo_acct_type.FindInitialValue = Nothing
        Me.xcbo_acct_type.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_acct_type.IgnoreRequiered = False
        Me.xcbo_acct_type.ItemHeight = 13
        Me.xcbo_acct_type.Location = New System.Drawing.Point(112, 72)
        Me.xcbo_acct_type.LookupKeyDisplayFields = "type_descr"
        Me.xcbo_acct_type.LookupKeyField = "acct_type"
        Me.xcbo_acct_type.LookupTableName = "cgacctpm"
        Me.xcbo_acct_type.Name = "xcbo_acct_type"
        Me.xcbo_acct_type.NewInitialValue = Nothing
        Me.xcbo_acct_type.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_acct_type.Requiered = False
        Me.xcbo_acct_type.Required = False
        Me.xcbo_acct_type.Size = New System.Drawing.Size(176, 21)
        Me.xcbo_acct_type.SqlString = Nothing
        Me.xcbo_acct_type.StatusBarPanelDescripcion = Nothing
        Me.xcbo_acct_type.TabIndex = 2
        '
        'xtxAcct_no
        '
        Me.xtxAcct_no.AcceptsReturn = True
        Me.xtxAcct_no.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgbalgenm.acct_no"))
        Me.xtxAcct_no.EditInitialValue = Nothing
        Me.xtxAcct_no.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxAcct_no.FieldDescription = ""
        Me.xtxAcct_no.FindInitialValue = Nothing
        Me.xtxAcct_no.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxAcct_no.IgnoreRequiered = False
        Me.xtxAcct_no.Location = New System.Drawing.Point(112, 24)
        Me.xtxAcct_no.Name = "xtxAcct_no"
        Me.xtxAcct_no.NewInitialValue = Nothing
        Me.xtxAcct_no.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxAcct_no.Requiered = False
        Me.xtxAcct_no.Size = New System.Drawing.Size(96, 20)
        Me.xtxAcct_no.StatusBarPanelDescripcion = Nothing
        Me.xtxAcct_no.TabIndex = 0
        Me.xtxAcct_no.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(20, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número Cuenta:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgbalgenm.acct_name"))
        Me.TextBox2.EditInitialValue = Nothing
        Me.TextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.FieldDescription = ""
        Me.TextBox2.FindInitialValue = Nothing
        Me.TextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.IgnoreRequiered = False
        Me.TextBox2.Location = New System.Drawing.Point(112, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.NewInitialValue = Nothing
        Me.TextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.Requiered = False
        Me.TextBox2.Size = New System.Drawing.Size(384, 20)
        Me.TextBox2.StatusBarPanelDescripcion = Nothing
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(59, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(22, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo de Cuenta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xdt_FechaFinal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.XTextBox3)
        Me.GroupBox1.Controls.Add(Me.txtperdr_num)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPerdr_year)
        Me.GroupBox1.Controls.Add(Me.xcbo_acct_type)
        Me.GroupBox1.Controls.Add(Me.xtxAcct_no)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'xdt_FechaFinal
        '
        Me.xdt_FechaFinal.CustomFormat = "dd/MM/yyyy"
        Me.xdt_FechaFinal.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cgbalgenm.balg_date"))
        Me.xdt_FechaFinal.EditInitialValue = Nothing
        Me.xdt_FechaFinal.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdt_FechaFinal.Enabled = False
        Me.xdt_FechaFinal.FieldDescription = ""
        Me.xdt_FechaFinal.FindInitialValue = Nothing
        Me.xdt_FechaFinal.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdt_FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaFinal.IgnoreRequiered = False
        Me.xdt_FechaFinal.Location = New System.Drawing.Point(568, 24)
        Me.xdt_FechaFinal.Name = "xdt_FechaFinal"
        Me.xdt_FechaFinal.NewInitialValue = Nothing
        Me.xdt_FechaFinal.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdt_FechaFinal.Requiered = False
        Me.xdt_FechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.xdt_FechaFinal.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaFinal.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(528, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Fecha:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(301, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Balance:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgbalgenm.balance"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(360, 72)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(136, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 6
        Me.XTextBox3.Text = ""
        Me.XTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtperdr_num
        '
        Me.txtperdr_num.AcceptsReturn = True
        Me.txtperdr_num.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgbalgenm.perdr_num"))
        Me.txtperdr_num.EditInitialValue = Nothing
        Me.txtperdr_num.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtperdr_num.FieldDescription = ""
        Me.txtperdr_num.FindInitialValue = Nothing
        Me.txtperdr_num.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtperdr_num.IgnoreRequiered = False
        Me.txtperdr_num.Location = New System.Drawing.Point(447, 24)
        Me.txtperdr_num.Name = "txtperdr_num"
        Me.txtperdr_num.NewInitialValue = Nothing
        Me.txtperdr_num.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtperdr_num.Requiered = False
        Me.txtperdr_num.Size = New System.Drawing.Size(48, 20)
        Me.txtperdr_num.StatusBarPanelDescripcion = Nothing
        Me.txtperdr_num.TabIndex = 5
        Me.txtperdr_num.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(288, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Periodo Actual:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPerdr_year
        '
        Me.txtPerdr_year.AcceptsReturn = True
        Me.txtPerdr_year.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgbalgenm.perdr_year"))
        Me.txtPerdr_year.EditInitialValue = Nothing
        Me.txtPerdr_year.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtPerdr_year.FieldDescription = ""
        Me.txtPerdr_year.FindInitialValue = Nothing
        Me.txtPerdr_year.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtPerdr_year.IgnoreRequiered = False
        Me.txtPerdr_year.Location = New System.Drawing.Point(379, 24)
        Me.txtPerdr_year.Name = "txtPerdr_year"
        Me.txtPerdr_year.NewInitialValue = Nothing
        Me.txtPerdr_year.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtPerdr_year.Requiered = False
        Me.txtPerdr_year.Size = New System.Drawing.Size(64, 20)
        Me.txtPerdr_year.StatusBarPanelDescripcion = Nothing
        Me.txtPerdr_year.TabIndex = 3
        Me.txtPerdr_year.Text = ""
        '
        'i_cgcdifem01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 190)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "i_cgcdifem01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Configuracion Balance General"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim mWhere As String
    Dim oPeriodo As SGT.Contabilidad.Entidades.Periodo
    Dim oAnoFiscal As SGT.Contabilidad.Entidades.AnoFiscal
    Dim oCuenta As SGT.Contabilidad.Entidades.Cuenta

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As System.Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            '''If e.Action = LibX.LibxConnectionActions.Add Then
            '''    rdb_Credito.Checked = False
            '''    rdb_Debito.Checked = False
            '''    txtNivel.Enabled = False
            '''End If

            '''If e.Action = LibX.LibxConnectionActions.Find Then
            '''    rdb_Credito.Checked = False
            '''    rdb_Debito.Checked = False
            '''End If

            '''If e.AcceptedAction = LibX.LibxConnectionActions.Find Then
            '''    If rdb_Credito.Checked = True Then
            '''        LibXConnector1.CurrentDataRow!acct_origen = -1
            '''    End If

            '''    If rdb_Debito.Checked = True Then
            '''        LibXConnector1.CurrentDataRow!acct_origen = 1
            '''    End If
            '''End If
            '''If e.Action = LibX.LibxConnectionActions.Edit Then
            '''    Me.xtxAcct_no.Enabled = False
            '''Else
            '''    Me.xtxAcct_no.Enabled = True
            '''End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As System.Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            oPeriodo = New SGT.Contabilidad.Entidades.Periodo
            oCuenta = New SGT.Contabilidad.Entidades.Cuenta
            oAnoFiscal = New SGT.Contabilidad.Entidades.AnoFiscal

            oPeriodo = oAnoFiscal.BuscarPeriodoActual

            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then
                e.UpdatingArgs.Row!line_no = FindLine() + 1
                e.UpdatingArgs.Row!cgcb_serial = Val(txtperdr_num.Text).ToString("00") & "-" & Val(txtPerdr_year.Text)
                e.UpdatingArgs.Row!balg_date = oPeriodo.Thru
                '''If rdb_Debito.Checked = True Then
                '''    'e.UpdatingArgs.Row!acct_origen = 1
                '''End If

                '''If rdb_Credito.Checked = True Then
                '''    e.UpdatingArgs.Row!acct_origen = -1
                '''End If
                ''''If Not LibX.IsNull(e.UpdatingArgs.Row!acct_contrl) Then
                ''''    If ConsultarTipo(e.UpdatingArgs.Row!acct_contrl) = False Then
                ''''        'e.UpdatingArgs.Row!acct_nivel = Actualizar(e.UpdatingArgs.Row!acct_contrl)
                ''''        'Else
                ''''        '    e.UpdatingArgs.Row!acct_nivel = 1
                ''''    End If
                ''''End If
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub LibXConnector1_ChangeState(ByVal sender As System.Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try
            oPeriodo = New SGT.Contabilidad.Entidades.Periodo
            oCuenta = New SGT.Contabilidad.Entidades.Cuenta
            oAnoFiscal = New SGT.Contabilidad.Entidades.AnoFiscal

            oPeriodo = oAnoFiscal.BuscarPeriodoActual

            'LibXConnector1.Find()

            txtperdr_num.Text = oPeriodo.Number.ToString
            txtPerdr_year.Text = oPeriodo.year.ToString
            xdt_FechaFinal.Value = oPeriodo.Thru

            If LibXConnector1.IsEditing = True And LibXConnector1.HasRecords = True Then
                LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year.ToString
                LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number.ToString
            End If

            If LibXConnector1.IsEditing = True And LibXConnector1.HasRecords = True Then
                If Not LibX.IsNull(LibXConnector1.CurrentDataRow!acct_no) Then
                    xtxAcct_no.Enabled = False
                Else
                    xtxAcct_no.Enabled = True
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub rdb_Debito_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '''If e.KeyChar = Microsoft.VisualBasic.ChrW(27) Then
        '''    rdb_Debito.Checked = False
        '''End If
    End Sub
    Private Sub rdb_Credito_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '''If e.KeyChar = Microsoft.VisualBasic.ChrW(27) Then
        '''    rdb_Credito.Checked = False
        '''End If
    End Sub

    Private Sub LibXConnector1_RowChange(ByVal sender As System.Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange
        Try
            '''If Not LibXConnector1.CurrentDataRow Is Nothing Then
            '''    If LibXConnector1.CurrentDataRow!acct_origen.ToString.Trim = "1" Then
            '''        rdb_Debito.Checked = True
            '''    End If

            '''    If LibXConnector1.CurrentDataRow!acct_origen.ToString.Trim = "-1" Then
            '''        rdb_Credito.Checked = True
            '''    End If
            '''End If
            If LibXConnector1.IsEditing = False And LibXConnector1.IsDataEditing = True Then  ''And LibXConnector1.HasRecords = True Then
                Me.xtxAcct_no.Enabled = False
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As System.Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        mWhere = e.Where
    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Dim oReport As LibX.ReportLib
        Dim SelecStmt As String
        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then
                oReport = New LibX.ReportLib("CTG", "r_cgbalgn01.rpt")
                With oReport
                    .RetrieveSQLQuery()
                    SelecStmt = .SQLQuery
                    'SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, mWhere)
                    .SQLQuery = SelecStmt

                    '// Ejecutar el reporte
                    .Action = 1
                End With
            End If
            If e.ButtonAction = XMsaComponents.XmsaButtons.Next _
            Or (e.ButtonAction = XMsaComponents.XmsaButtons.Prev) _
            Or (e.ButtonAction = XMsaComponents.XmsaButtons.First) _
            Or (e.ButtonAction = XMsaComponents.XmsaButtons.Last) Then
                '''Me.xlk_acct_control.ExecuteFind()
            End If
            '''If ConsultarMovimientos(LibXConnector1.CurrentDataRow!acct_no.ToString.Trim) = True Then
            '''    Me.btnMov.Enabled = True
            '''Else
            '''    Me.btnMov.Enabled = False
            '''End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub i_cgcdifem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oPeriodo = New SGT.Contabilidad.Entidades.Periodo
        oCuenta = New SGT.Contabilidad.Entidades.Cuenta
        oAnoFiscal = New SGT.Contabilidad.Entidades.AnoFiscal

        oPeriodo = oAnoFiscal.BuscarPeriodoActual

        LibXConnector1.Find()

        txtperdr_num.Text = oPeriodo.Number.ToString
        txtPerdr_year.Text = oPeriodo.year.ToString

        LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year.ToString
        LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number.ToString

        xdt_FechaFinal.Value = oPeriodo.Thru

    End Sub
    Private Sub LibXLookup1_BeforeExecuteQuery(ByVal sender As System.Object, ByVal e As LibX.BeforeExecuteQueryEventArgs)
        Try
            If LibXConnector1.IsDataEditing = True Then
                If LibX.IsNull(xcbo_acct_type.currValue) = False Then
                    e.aditionalWhere = "acct_type = " & LibXConnector1.CurrentDataRow!acct_type.ToString.Trim
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Function ConsultarMovimientos(ByVal pacct_no As String) As Boolean
        Dim XSelect As LibX.Data.XSelecStmt
        Dim oRow As DataRow
        Dim Find As Boolean
        Try

            XSelect = New LibX.Data.XSelecStmt("cgacctd")

            XSelect.Parameters.Add("acct_no", pacct_no)
            oRow = XSelect.GetDataRow()

            If oRow Is Nothing Then
                Find = False
            Else
                Find = True
            End If

            Return Find

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Function
    Private Function FindLine() As Integer
        Dim SelecTsmt As String
        Dim Find As Integer
        Try

            SelecTsmt = " select max(line_no) from cgbalgenm "
            Find = LibX.Data.Manager.GetScalar(SelecTsmt)
            Return Find

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Function

    Private Sub LibXConnector1_InsertedRow(ByVal sender As System.Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedRow
        If e.UpdatingArgs.StatementType = StatementType.Insert _
                      Or e.UpdatingArgs.StatementType = StatementType.Update Then
            If LibX.IsNull(e.UpdatingArgs.Row!acct_no) Then
                e.UpdatingArgs.Row.AcceptChanges()
            End If
        End If
    End Sub

End Class


