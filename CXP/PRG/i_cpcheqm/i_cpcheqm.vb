Public Class i_cpcheqm
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents LibxDateTimePicker2 As LibX.LibxDateTimePicker
    Friend WithEvents txtact_no As LibX.XTextBox
    Friend WithEvents XTextBox7 As LibX.XTextBox
    Friend WithEvents labelact_no As System.Windows.Forms.Label
    Friend WithEvents xlk_acct_no As LibX.LibXLookup
    Friend WithEvents xtxt_descripcion As LibX.XTextBox
    Friend WithEvents xtxt_chequera As LibX.XTextBox
    Friend WithEvents DataSet1 As System.Data.DataSet
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
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents xlk_ban_code As LibX.LibXLookup
    Friend WithEvents lblban_name As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents xtxt_balance_ult_conc As LibX.XMaskEdit
    Friend WithEvents xtxt_balance_inicial As LibX.XMaskEdit
    Friend WithEvents xtxt_cuenta_banco As LibX.XTextBox
    Friend WithEvents xtxt_balance_actual As LibX.XMaskEdit
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents cbconcm As System.Data.DataTable
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xlk_acct_no = New LibX.LibXLookup
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
        Me.cbconcm = New System.Data.DataTable
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.XTextBox7 = New LibX.XTextBox
        Me.xtxt_balance_ult_conc = New LibX.XMaskEdit
        Me.xtxt_balance_inicial = New LibX.XMaskEdit
        Me.xtxt_balance_actual = New LibX.XMaskEdit
        Me.txtact_no = New LibX.XTextBox
        Me.xtxt_cuenta_banco = New LibX.XTextBox
        Me.xtxt_descripcion = New LibX.XTextBox
        Me.LibxDateTimePicker2 = New LibX.LibxDateTimePicker
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.labelact_no = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.xtxt_chequera = New LibX.XTextBox
        Me.XTextBox1 = New LibX.XTextBox
        Me.xlk_ban_code = New LibX.LibXLookup
        Me.lblban_name = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbconcm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xlk_acct_no)
        Me.GroupBox1.Controls.Add(Me.XTextBox7)
        Me.GroupBox1.Controls.Add(Me.xtxt_balance_ult_conc)
        Me.GroupBox1.Controls.Add(Me.xtxt_balance_inicial)
        Me.GroupBox1.Controls.Add(Me.xtxt_balance_actual)
        Me.GroupBox1.Controls.Add(Me.txtact_no)
        Me.GroupBox1.Controls.Add(Me.xtxt_cuenta_banco)
        Me.GroupBox1.Controls.Add(Me.xtxt_descripcion)
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.labelact_no)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xtxt_chequera)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.xlk_ban_code)
        Me.GroupBox1.Controls.Add(Me.lblban_name)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 296)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'xlk_acct_no
        '
        Me.xlk_acct_no.AlternateFieldSearch = Nothing
        Me.xlk_acct_no.BeginCheck = False
        Me.xlk_acct_no.CheckText = Nothing
        Me.xlk_acct_no.ComboMode = False
        Me.xlk_acct_no.DataMember = Nothing
        Me.xlk_acct_no.DataSource = Me.LibXConnector1
        Me.xlk_acct_no.DestParameters = New String() {"txtact_no=acct_no", "labelact_no=acct_name"}
        Me.xlk_acct_no.FilterField = Nothing
        Me.xlk_acct_no.IgnoreFindInBrowseMode = False
        Me.xlk_acct_no.isCanceled = False
        Me.xlk_acct_no.Location = New System.Drawing.Point(520, 120)
        Me.xlk_acct_no.LookCaption = Nothing
        Me.xlk_acct_no.Name = "xlk_acct_no"
        Me.xlk_acct_no.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_acct_no.ShowFilter = True
        Me.xlk_acct_no.ShowMessageNotFound = True
        Me.xlk_acct_no.ShowWarning = False
        Me.xlk_acct_no.Size = New System.Drawing.Size(16, 20)
        Me.xlk_acct_no.SizesColumns = Nothing
        Me.xlk_acct_no.SizesColumnsTab = Nothing
        Me.xlk_acct_no.SqlString = Nothing
        Me.xlk_acct_no.SQLTab = Nothing
        Me.xlk_acct_no.SrcParameters = New String() {"cuenta_conta=acct_no"}
        Me.xlk_acct_no.TabIndex = 57
        Me.xlk_acct_no.TableName = "cgacctm"
        Me.xlk_acct_no.TabStop = False
        Me.xlk_acct_no.UseCopyConnection = False
        Me.xlk_acct_no.UseRowRetrieveEvents = False
        Me.xlk_acct_no.UseTab = False
        Me.xlk_acct_no.VisParameters = New String() {"Código=acct_no", "Descripción=acct_name", ""}
        Me.xlk_acct_no.WhereCondition = Nothing
        Me.xlk_acct_no.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "cpchequera"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
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
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.cbconcm})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"chequera"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "cpchequera"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "chequera"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "descripcion"
        Me.DataColumn2.MaxLength = 50
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "direccion"
        Me.DataColumn3.MaxLength = 50
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "ciudad"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "cuenta_banco"
        Me.DataColumn5.MaxLength = 20
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "cuenta_conta"
        Me.DataColumn6.MaxLength = 20
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "balance_actual"
        Me.DataColumn7.DataType = GetType(System.Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "fecha_ini"
        Me.DataColumn8.DataType = GetType(System.DateTime)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "balance_ini"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "fecha_conciliacion"
        Me.DataColumn10.DataType = GetType(System.DateTime)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "balance_ult_concil"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "ultimo_no_cheque"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "ban_code"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "cheque_format"
        Me.DataColumn14.MaxLength = 20
        '
        'cbconcm
        '
        Me.cbconcm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22})
        Me.cbconcm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"conc_serial"}, True)})
        Me.cbconcm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn15}
        Me.cbconcm.TableName = "cbconcm"
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.AutoIncrement = True
        Me.DataColumn15.ColumnName = "conc_serial"
        Me.DataColumn15.DataType = GetType(System.Int32)
        Me.DataColumn15.ReadOnly = True
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "conc_date"
        Me.DataColumn16.DataType = GetType(System.DateTime)
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.ColumnName = "chequera"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "conc_status"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "Saldo_ant"
        Me.DataColumn19.DataType = GetType(System.Decimal)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "Saldo_Banco"
        Me.DataColumn20.DataType = GetType(System.Decimal)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "Saldo_Libro"
        Me.DataColumn21.DataType = GetType(System.Decimal)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "Saldo_conciliado"
        Me.DataColumn22.DataType = GetType(System.Decimal)
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
        Me.LibXDbSourceTable1.KeyFields = ""
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "chequera"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cpchequera"
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
        Me.LibXDbSourceTable2.TableName = "cbconcm"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'XTextBox7
        '
        Me.XTextBox7.AcceptsReturn = True
        Me.XTextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpchequera.ultimo_no_cheque"))
        Me.XTextBox7.EditInitialValue = Nothing
        Me.XTextBox7.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox7.FieldDescription = ""
        Me.XTextBox7.FindInitialValue = Nothing
        Me.XTextBox7.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox7.IgnoreRequiered = False
        Me.XTextBox7.Location = New System.Drawing.Point(128, 264)
        Me.XTextBox7.Name = "XTextBox7"
        Me.XTextBox7.NewInitialValue = Nothing
        Me.XTextBox7.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox7.Requiered = False
        Me.XTextBox7.Size = New System.Drawing.Size(136, 20)
        Me.XTextBox7.StatusBarPanelDescripcion = Nothing
        Me.XTextBox7.TabIndex = 9
        Me.XTextBox7.Text = ""
        Me.XTextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xtxt_balance_ult_conc
        '
        Me.xtxt_balance_ult_conc.AcceptsReturn = True
        Me.xtxt_balance_ult_conc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpchequera.balance_ult_concil"))
        Me.xtxt_balance_ult_conc.EditInitialValue = Nothing
        Me.xtxt_balance_ult_conc.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_balance_ult_conc.Enabled = False
        Me.xtxt_balance_ult_conc.FieldDescription = ""
        Me.xtxt_balance_ult_conc.FindInitialValue = Nothing
        Me.xtxt_balance_ult_conc.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_balance_ult_conc.IgnoreRequiered = False
        Me.xtxt_balance_ult_conc.Location = New System.Drawing.Point(128, 240)
        Me.xtxt_balance_ult_conc.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxt_balance_ult_conc.Name = "xtxt_balance_ult_conc"
        Me.xtxt_balance_ult_conc.NewInitialValue = Nothing
        Me.xtxt_balance_ult_conc.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_balance_ult_conc.Requiered = True
        Me.xtxt_balance_ult_conc.Size = New System.Drawing.Size(136, 20)
        Me.xtxt_balance_ult_conc.StatusBarPanelDescripcion = Nothing
        Me.xtxt_balance_ult_conc.TabIndex = 8
        Me.xtxt_balance_ult_conc.Text = ""
        Me.xtxt_balance_ult_conc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xtxt_balance_inicial
        '
        Me.xtxt_balance_inicial.AcceptsReturn = True
        Me.xtxt_balance_inicial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpchequera.balance_ini"))
        Me.xtxt_balance_inicial.EditInitialValue = Nothing
        Me.xtxt_balance_inicial.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_balance_inicial.FieldDescription = ""
        Me.xtxt_balance_inicial.FindInitialValue = Nothing
        Me.xtxt_balance_inicial.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_balance_inicial.IgnoreRequiered = False
        Me.xtxt_balance_inicial.Location = New System.Drawing.Point(128, 192)
        Me.xtxt_balance_inicial.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxt_balance_inicial.Name = "xtxt_balance_inicial"
        Me.xtxt_balance_inicial.NewInitialValue = Nothing
        Me.xtxt_balance_inicial.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_balance_inicial.Requiered = True
        Me.xtxt_balance_inicial.Size = New System.Drawing.Size(136, 20)
        Me.xtxt_balance_inicial.StatusBarPanelDescripcion = Nothing
        Me.xtxt_balance_inicial.TabIndex = 6
        Me.xtxt_balance_inicial.Text = ""
        Me.xtxt_balance_inicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xtxt_balance_actual
        '
        Me.xtxt_balance_actual.AcceptsReturn = True
        Me.xtxt_balance_actual.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpchequera.balance_actual"))
        Me.xtxt_balance_actual.EditInitialValue = Nothing
        Me.xtxt_balance_actual.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_balance_actual.Enabled = False
        Me.xtxt_balance_actual.FieldDescription = ""
        Me.xtxt_balance_actual.FindInitialValue = Nothing
        Me.xtxt_balance_actual.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_balance_actual.IgnoreRequiered = False
        Me.xtxt_balance_actual.Location = New System.Drawing.Point(128, 144)
        Me.xtxt_balance_actual.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxt_balance_actual.Name = "xtxt_balance_actual"
        Me.xtxt_balance_actual.NewInitialValue = Nothing
        Me.xtxt_balance_actual.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_balance_actual.Requiered = True
        Me.xtxt_balance_actual.Size = New System.Drawing.Size(136, 20)
        Me.xtxt_balance_actual.StatusBarPanelDescripcion = Nothing
        Me.xtxt_balance_actual.TabIndex = 4
        Me.xtxt_balance_actual.Text = ""
        Me.xtxt_balance_actual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtact_no
        '
        Me.txtact_no.AcceptsReturn = True
        Me.txtact_no.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpchequera.cuenta_conta"))
        Me.txtact_no.EditInitialValue = Nothing
        Me.txtact_no.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtact_no.FieldDescription = ""
        Me.txtact_no.FindInitialValue = Nothing
        Me.txtact_no.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtact_no.IgnoreRequiered = False
        Me.txtact_no.Location = New System.Drawing.Point(128, 120)
        Me.txtact_no.Name = "txtact_no"
        Me.txtact_no.NewInitialValue = Nothing
        Me.txtact_no.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtact_no.Requiered = True
        Me.txtact_no.Size = New System.Drawing.Size(136, 20)
        Me.txtact_no.StatusBarPanelDescripcion = Nothing
        Me.txtact_no.TabIndex = 3
        Me.txtact_no.Text = ""
        '
        'xtxt_cuenta_banco
        '
        Me.xtxt_cuenta_banco.AcceptsReturn = True
        Me.xtxt_cuenta_banco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_cuenta_banco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpchequera.cuenta_banco"))
        Me.xtxt_cuenta_banco.EditInitialValue = Nothing
        Me.xtxt_cuenta_banco.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cuenta_banco.FieldDescription = ""
        Me.xtxt_cuenta_banco.FindInitialValue = Nothing
        Me.xtxt_cuenta_banco.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cuenta_banco.IgnoreRequiered = False
        Me.xtxt_cuenta_banco.Location = New System.Drawing.Point(128, 48)
        Me.xtxt_cuenta_banco.Name = "xtxt_cuenta_banco"
        Me.xtxt_cuenta_banco.NewInitialValue = Nothing
        Me.xtxt_cuenta_banco.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cuenta_banco.Requiered = True
        Me.xtxt_cuenta_banco.Size = New System.Drawing.Size(136, 20)
        Me.xtxt_cuenta_banco.StatusBarPanelDescripcion = Nothing
        Me.xtxt_cuenta_banco.TabIndex = 0
        Me.xtxt_cuenta_banco.Text = ""
        '
        'xtxt_descripcion
        '
        Me.xtxt_descripcion.AcceptsReturn = True
        Me.xtxt_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_descripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpchequera.descripcion"))
        Me.xtxt_descripcion.EditInitialValue = Nothing
        Me.xtxt_descripcion.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_descripcion.FieldDescription = ""
        Me.xtxt_descripcion.FindInitialValue = Nothing
        Me.xtxt_descripcion.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_descripcion.IgnoreRequiered = False
        Me.xtxt_descripcion.Location = New System.Drawing.Point(128, 72)
        Me.xtxt_descripcion.Name = "xtxt_descripcion"
        Me.xtxt_descripcion.NewInitialValue = Nothing
        Me.xtxt_descripcion.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_descripcion.Requiered = True
        Me.xtxt_descripcion.Size = New System.Drawing.Size(392, 20)
        Me.xtxt_descripcion.StatusBarPanelDescripcion = Nothing
        Me.xtxt_descripcion.TabIndex = 1
        Me.xtxt_descripcion.Text = ""
        '
        'LibxDateTimePicker2
        '
        Me.LibxDateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cpchequera.fecha_conciliacion"))
        Me.LibxDateTimePicker2.EditInitialValue = Nothing
        Me.LibxDateTimePicker2.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxDateTimePicker2.Enabled = False
        Me.LibxDateTimePicker2.FieldDescription = ""
        Me.LibxDateTimePicker2.FindInitialValue = Nothing
        Me.LibxDateTimePicker2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker2.IgnoreRequiered = True
        Me.LibxDateTimePicker2.Location = New System.Drawing.Point(128, 216)
        Me.LibxDateTimePicker2.Name = "LibxDateTimePicker2"
        Me.LibxDateTimePicker2.NewInitialValue = "now"
        Me.LibxDateTimePicker2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker2.Requiered = False
        Me.LibxDateTimePicker2.Size = New System.Drawing.Size(136, 20)
        Me.LibxDateTimePicker2.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker2.TabIndex = 7
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cpchequera.fecha_ini"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxDateTimePicker1.FieldDescription = ""
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = True
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(128, 168)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = "now"
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Requiered = True
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(136, 20)
        Me.LibxDateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker1.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(16, 240)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 16)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "Balance Ult. Conc.:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(35, 264)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 16)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Ultimo Cheque:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(14, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 16)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Fecha Conciliación:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(37, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Balance Inicial:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'labelact_no
        '
        Me.labelact_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelact_no.Location = New System.Drawing.Point(272, 120)
        Me.labelact_no.Name = "labelact_no"
        Me.labelact_no.Size = New System.Drawing.Size(248, 20)
        Me.labelact_no.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(46, 168)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 16)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Fecha Inicial:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(34, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 16)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Balance Actual:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(25, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Cuenta Contable:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(60, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Chequera:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(16, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 0)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cantidad:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(30, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Cuenta:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(25, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cuenta Bancaria:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_chequera
        '
        Me.xtxt_chequera.AcceptsReturn = True
        Me.xtxt_chequera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_chequera.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpchequera.chequera"))
        Me.xtxt_chequera.EditInitialValue = Nothing
        Me.xtxt_chequera.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_chequera.FieldDescription = ""
        Me.xtxt_chequera.FindInitialValue = Nothing
        Me.xtxt_chequera.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_chequera.IgnoreRequiered = False
        Me.xtxt_chequera.Location = New System.Drawing.Point(128, 24)
        Me.xtxt_chequera.Name = "xtxt_chequera"
        Me.xtxt_chequera.NewInitialValue = Nothing
        Me.xtxt_chequera.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_chequera.Requiered = True
        Me.xtxt_chequera.Size = New System.Drawing.Size(48, 20)
        Me.xtxt_chequera.StatusBarPanelDescripcion = Nothing
        Me.xtxt_chequera.TabIndex = 0
        Me.xtxt_chequera.Text = ""
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpchequera.ban_code"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(128, 96)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = True
        Me.XTextBox1.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 2
        Me.XTextBox1.Text = ""
        '
        'xlk_ban_code
        '
        Me.xlk_ban_code.AlternateFieldSearch = Nothing
        Me.xlk_ban_code.BeginCheck = False
        Me.xlk_ban_code.CheckText = Nothing
        Me.xlk_ban_code.ComboMode = False
        Me.xlk_ban_code.DataMember = Nothing
        Me.xlk_ban_code.DataSource = Me.LibXConnector1
        Me.xlk_ban_code.DestParameters = New String() {"ban_code=ban_code", "lblban_name=ban_name"}
        Me.xlk_ban_code.FilterField = Nothing
        Me.xlk_ban_code.IgnoreFindInBrowseMode = False
        Me.xlk_ban_code.isCanceled = False
        Me.xlk_ban_code.Location = New System.Drawing.Point(520, 96)
        Me.xlk_ban_code.LookCaption = "Bancos"
        Me.xlk_ban_code.Name = "xlk_ban_code"
        Me.xlk_ban_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_ban_code.ShowFilter = True
        Me.xlk_ban_code.ShowMessageNotFound = True
        Me.xlk_ban_code.ShowWarning = False
        Me.xlk_ban_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_ban_code.SizesColumns = Nothing
        Me.xlk_ban_code.SizesColumnsTab = Nothing
        Me.xlk_ban_code.SqlString = Nothing
        Me.xlk_ban_code.SQLTab = Nothing
        Me.xlk_ban_code.SrcParameters = New String() {"ban_code=ban_code"}
        Me.xlk_ban_code.TabIndex = 13
        Me.xlk_ban_code.TableName = "ftbanco"
        Me.xlk_ban_code.TabStop = False
        Me.xlk_ban_code.UseCopyConnection = False
        Me.xlk_ban_code.UseRowRetrieveEvents = False
        Me.xlk_ban_code.UseTab = False
        Me.xlk_ban_code.VisParameters = New String() {"Código=ban_code", "Banco=ban_name"}
        Me.xlk_ban_code.WhereCondition = Nothing
        Me.xlk_ban_code.WhereParameters = Nothing
        '
        'lblban_name
        '
        Me.lblban_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblban_name.Location = New System.Drawing.Point(184, 96)
        Me.lblban_name.Name = "lblban_name"
        Me.lblban_name.Size = New System.Drawing.Size(336, 20)
        Me.lblban_name.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(78, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Banco:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_cuenta_banco
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_chequera
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_cuenta_banco
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(690, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'i_cpcheqm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 352)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_cpcheqm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cuenta Bancaria"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbconcm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub xtxt_balance_inicial_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_balance_inicial.Validating
        If xtxt_balance_inicial.Text <> "" Then
            xtxt_balance_actual.Text = Format(Val(xtxt_balance_inicial.Text), "##,###,##0.00")
            xtxt_balance_ult_conc.Text = Format(Val(xtxt_balance_inicial.Text), "##,###,##0.00")
        End If
    End Sub
End Class
