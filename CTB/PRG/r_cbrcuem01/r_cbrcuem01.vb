Imports LibX
Public Class r_cbrcuem01
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
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lbltype_code As LibX.LibXLookup
    Friend WithEvents Fecha_ini As LibX.LibxDateTimePicker
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents klx_chequera As LibX.LibXLookup
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Xtxsuc_code As LibX.XTextBox
    Friend WithEvents Txttype_name As System.Windows.Forms.TextBox
    Friend WithEvents Txtchk_name As System.Windows.Forms.TextBox
    Friend WithEvents Xtxchequera As LibX.XTextBox
    Friend WithEvents Xtxtran_type As LibX.XTextBox
    Friend WithEvents Txtsuc_name As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents XTextBox4 As LibX.XTextBox
    Friend WithEvents XTextBox5 As LibX.XTextBox
    Friend WithEvents acct_name As System.Windows.Forms.TextBox
    Friend WithEvents fecha_fin As LibX.LibxDateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
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
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Txttype_name = New System.Windows.Forms.TextBox
        Me.Lbltype_code = New LibX.LibXLookup
        Me.Txtchk_name = New System.Windows.Forms.TextBox
        Me.klx_chequera = New LibX.LibXLookup
        Me.Label2 = New System.Windows.Forms.Label
        Me.Fecha_ini = New LibX.LibxDateTimePicker
        Me.Xtxchequera = New LibX.XTextBox
        Me.Xtxtran_type = New LibX.XTextBox
        Me.Xtxsuc_code = New LibX.XTextBox
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.Txtsuc_name = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.acct_name = New System.Windows.Forms.TextBox
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.XTextBox4 = New LibX.XTextBox
        Me.XTextBox5 = New LibX.XTextBox
        Me.fecha_fin = New LibX.LibxDateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.LibXConnector1.DataMember = "vw_cbdocsd"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = True
        Me.LibXConnector1.HandledUpdates = True
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
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn1, Me.DataColumn2})
        Me.DataTable2.TableName = "vw_cbdocsd"
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "cbm_serial"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "suc_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "acct_no"
        Me.DataColumn5.MaxLength = 20
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "tran_type"
        Me.DataColumn6.MaxLength = 3
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "doc_number"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "valor"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.AutoIncrement = True
        Me.DataColumn9.ColumnName = "chequera"
        Me.DataColumn9.DataType = GetType(System.Int32)
        Me.DataColumn9.ReadOnly = True
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "descripcion"
        Me.DataColumn10.MaxLength = 50
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "debito"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        Me.DataColumn11.ReadOnly = True
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "credito"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        Me.DataColumn12.ReadOnly = True
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "doc_date"
        Me.DataColumn13.DataType = GetType(System.DateTime)
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "doc_status"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "Benef"
        Me.DataColumn15.MaxLength = 60
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "debit_credit"
        Me.DataColumn16.DataType = GetType(System.Int32)
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "perdr_year"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "perdr_num"
        Me.DataColumn2.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.TableName = "vw_cbdocsd"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.Location = New System.Drawing.Point(440, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 136)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(8, 96)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Cerrar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLimpiar.Location = New System.Drawing.Point(8, 56)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(72, 32)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEjecutar.Location = New System.Drawing.Point(8, 16)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(72, 32)
        Me.btnEjecutar.TabIndex = 0
        Me.btnEjecutar.Text = "Ejecutar"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(530, 48)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "RESUMEN DE CUENTA"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(29, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Chequera :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(30, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Tipo Doc. :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txttype_name
        '
        Me.Txttype_name.Location = New System.Drawing.Point(160, 181)
        Me.Txttype_name.Name = "Txttype_name"
        Me.Txttype_name.ReadOnly = True
        Me.Txttype_name.Size = New System.Drawing.Size(248, 20)
        Me.Txttype_name.TabIndex = 23
        Me.Txttype_name.Text = ""
        '
        'Lbltype_code
        '
        Me.Lbltype_code.AlternateFieldSearch = Nothing
        Me.Lbltype_code.BeginCheck = False
        Me.Lbltype_code.CheckText = Nothing
        Me.Lbltype_code.ComboMode = False
        Me.Lbltype_code.DataMember = Nothing
        Me.Lbltype_code.DataSource = Me.LibXConnector1
        Me.Lbltype_code.DestParameters = New String() {"Xtxtran_type=tran_type", "Txttype_name=tran_descr"}
        Me.Lbltype_code.FilterField = Nothing
        Me.Lbltype_code.IgnoreFindInBrowseMode = False
        Me.Lbltype_code.isCanceled = False
        Me.Lbltype_code.Location = New System.Drawing.Point(408, 181)
        Me.Lbltype_code.LookCaption = Nothing
        Me.Lbltype_code.Name = "Lbltype_code"
        Me.Lbltype_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.Lbltype_code.ShowFilter = True
        Me.Lbltype_code.ShowMessageNotFound = True
        Me.Lbltype_code.ShowWarning = False
        Me.Lbltype_code.Size = New System.Drawing.Size(16, 20)
        Me.Lbltype_code.SizesColumns = Nothing
        Me.Lbltype_code.SizesColumnsTab = Nothing
        Me.Lbltype_code.SqlString = New String() {"select distinct tran_type,tran_descr from cgtrntpm", "where conciliable = 1 "}
        Me.Lbltype_code.SQLTab = Nothing
        Me.Lbltype_code.SrcParameters = New String() {"Xtxtran_type=tran_type", "chequera = chequera"}
        Me.Lbltype_code.TabIndex = 24
        Me.Lbltype_code.TableName = "cgtrntpm"
        Me.Lbltype_code.TabStop = False
        Me.Lbltype_code.UseCopyConnection = False
        Me.Lbltype_code.UseRowRetrieveEvents = False
        Me.Lbltype_code.UseTab = False
        Me.Lbltype_code.VisParameters = New String() {"Código=tran_type", "Nombre=tran_descr"}
        Me.Lbltype_code.WhereCondition = Nothing
        Me.Lbltype_code.WhereParameters = Nothing
        '
        'Txtchk_name
        '
        Me.Txtchk_name.Location = New System.Drawing.Point(159, 157)
        Me.Txtchk_name.Name = "Txtchk_name"
        Me.Txtchk_name.ReadOnly = True
        Me.Txtchk_name.Size = New System.Drawing.Size(249, 20)
        Me.Txtchk_name.TabIndex = 25
        Me.Txtchk_name.Text = ""
        '
        'klx_chequera
        '
        Me.klx_chequera.AlternateFieldSearch = Nothing
        Me.klx_chequera.BeginCheck = False
        Me.klx_chequera.CheckText = Nothing
        Me.klx_chequera.ComboMode = False
        Me.klx_chequera.DataMember = Nothing
        Me.klx_chequera.DataSource = Me.LibXConnector1
        Me.klx_chequera.DestParameters = New String() {"Xtxchequera=chequera", "Txtchk_name=descripcion"}
        Me.klx_chequera.FilterField = Nothing
        Me.klx_chequera.IgnoreFindInBrowseMode = False
        Me.klx_chequera.isCanceled = False
        Me.klx_chequera.Location = New System.Drawing.Point(408, 158)
        Me.klx_chequera.LookCaption = Nothing
        Me.klx_chequera.Name = "klx_chequera"
        Me.klx_chequera.PopupSize = New System.Drawing.Size(0, 0)
        Me.klx_chequera.ShowFilter = True
        Me.klx_chequera.ShowMessageNotFound = True
        Me.klx_chequera.ShowWarning = False
        Me.klx_chequera.Size = New System.Drawing.Size(16, 20)
        Me.klx_chequera.SizesColumns = Nothing
        Me.klx_chequera.SizesColumnsTab = Nothing
        Me.klx_chequera.SqlString = Nothing
        Me.klx_chequera.SQLTab = Nothing
        Me.klx_chequera.SrcParameters = New String() {"Xtxchequera=chequera"}
        Me.klx_chequera.TabIndex = 26
        Me.klx_chequera.TableName = "cpchequera"
        Me.klx_chequera.TabStop = False
        Me.klx_chequera.UseCopyConnection = False
        Me.klx_chequera.UseRowRetrieveEvents = False
        Me.klx_chequera.UseTab = False
        Me.klx_chequera.VisParameters = New String() {"Código=chequera", "Nombre=descripcion"}
        Me.klx_chequera.WhereCondition = Nothing
        Me.klx_chequera.WhereParameters = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Fecha Inicio:"
        '
        'Fecha_ini
        '
        Me.Fecha_ini.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_ini.EditInitialValue = Nothing
        Me.Fecha_ini.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_ini.FieldDescription = ""
        Me.Fecha_ini.FindInitialValue = ""
        Me.Fecha_ini.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_ini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha_ini.IgnoreRequiered = False
        Me.Fecha_ini.Location = New System.Drawing.Point(96, 64)
        Me.Fecha_ini.Name = "Fecha_ini"
        Me.Fecha_ini.NewInitialValue = Nothing
        Me.Fecha_ini.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_ini.Requiered = False
        Me.Fecha_ini.Size = New System.Drawing.Size(88, 20)
        Me.Fecha_ini.StatusBarPanelDescripcion = Nothing
        Me.Fecha_ini.TabIndex = 0
        '
        'Xtxchequera
        '
        Me.Xtxchequera.AcceptsReturn = True
        Me.Xtxchequera.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "vw_cbdocsd.chequera"))
        Me.Xtxchequera.EditInitialValue = Nothing
        Me.Xtxchequera.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxchequera.FieldDescription = ""
        Me.Xtxchequera.FindInitialValue = Nothing
        Me.Xtxchequera.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxchequera.IgnoreRequiered = False
        Me.Xtxchequera.Location = New System.Drawing.Point(96, 157)
        Me.Xtxchequera.Name = "Xtxchequera"
        Me.Xtxchequera.NewInitialValue = Nothing
        Me.Xtxchequera.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxchequera.Requiered = False
        Me.Xtxchequera.Size = New System.Drawing.Size(64, 20)
        Me.Xtxchequera.StatusBarPanelDescripcion = Nothing
        Me.Xtxchequera.TabIndex = 5
        Me.Xtxchequera.Text = ""
        '
        'Xtxtran_type
        '
        Me.Xtxtran_type.AcceptsReturn = True
        Me.Xtxtran_type.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "vw_cbdocsd.tran_type"))
        Me.Xtxtran_type.EditInitialValue = Nothing
        Me.Xtxtran_type.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxtran_type.FieldDescription = ""
        Me.Xtxtran_type.FindInitialValue = Nothing
        Me.Xtxtran_type.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxtran_type.IgnoreRequiered = False
        Me.Xtxtran_type.Location = New System.Drawing.Point(96, 181)
        Me.Xtxtran_type.Name = "Xtxtran_type"
        Me.Xtxtran_type.NewInitialValue = Nothing
        Me.Xtxtran_type.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxtran_type.Requiered = False
        Me.Xtxtran_type.Size = New System.Drawing.Size(64, 20)
        Me.Xtxtran_type.StatusBarPanelDescripcion = Nothing
        Me.Xtxtran_type.TabIndex = 6
        Me.Xtxtran_type.Text = ""
        '
        'Xtxsuc_code
        '
        Me.Xtxsuc_code.AcceptsReturn = True
        Me.Xtxsuc_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "vw_cbdocsd.suc_code"))
        Me.Xtxsuc_code.EditInitialValue = Nothing
        Me.Xtxsuc_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxsuc_code.FieldDescription = ""
        Me.Xtxsuc_code.FindInitialValue = Nothing
        Me.Xtxsuc_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxsuc_code.IgnoreRequiered = False
        Me.Xtxsuc_code.Location = New System.Drawing.Point(96, 133)
        Me.Xtxsuc_code.Name = "Xtxsuc_code"
        Me.Xtxsuc_code.NewInitialValue = Nothing
        Me.Xtxsuc_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxsuc_code.Requiered = False
        Me.Xtxsuc_code.Size = New System.Drawing.Size(64, 20)
        Me.Xtxsuc_code.StatusBarPanelDescripcion = Nothing
        Me.Xtxsuc_code.TabIndex = 4
        Me.Xtxsuc_code.Text = ""
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"xtxsuc_code=suc_code", "Txtsuc_name=suc_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(408, 136)
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
        Me.LibXLookup1.SrcParameters = New String() {"xtxsuc_code=suc_code"}
        Me.LibXLookup1.TabIndex = 39
        Me.LibXLookup1.TableName = "cgsucursal"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=suc_code", "Nombre=suc_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'Txtsuc_name
        '
        Me.Txtsuc_name.Location = New System.Drawing.Point(159, 134)
        Me.Txtsuc_name.Name = "Txtsuc_name"
        Me.Txtsuc_name.ReadOnly = True
        Me.Txtsuc_name.Size = New System.Drawing.Size(249, 20)
        Me.Txtsuc_name.TabIndex = 38
        Me.Txtsuc_name.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(35, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Sucursal :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Periodo:"
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "vw_cbdocsd.acct_no"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(96, 206)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(64, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 7
        Me.XTextBox3.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(42, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 16)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Cuenta :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'acct_name
        '
        Me.acct_name.Location = New System.Drawing.Point(160, 206)
        Me.acct_name.Name = "acct_name"
        Me.acct_name.ReadOnly = True
        Me.acct_name.Size = New System.Drawing.Size(248, 20)
        Me.acct_name.TabIndex = 45
        Me.acct_name.Text = ""
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"acct_no=acct_no", "acct_name=acct_name"}
        Me.LibXLookup2.FilterField = "acct_name"
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(408, 206)
        Me.LibXLookup2.LookCaption = Nothing
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup2.ShowFilter = True
        Me.LibXLookup2.ShowMessageNotFound = True
        Me.LibXLookup2.ShowWarning = False
        Me.LibXLookup2.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup2.SizesColumns = Nothing
        Me.LibXLookup2.SizesColumnsTab = Nothing
        Me.LibXLookup2.SqlString = New String() {"select acct_no,acct_name from cgacctm"}
        Me.LibXLookup2.SQLTab = Nothing
        Me.LibXLookup2.SrcParameters = New String() {"acct_no=acct_no"}
        Me.LibXLookup2.TabIndex = 46
        Me.LibXLookup2.TableName = "cgacctm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=acct_no", "Nombre=acct_name"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'XTextBox4
        '
        Me.XTextBox4.AcceptsReturn = True
        Me.XTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "vw_cbdocsd.perdr_num"))
        Me.XTextBox4.EditInitialValue = Nothing
        Me.XTextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.FieldDescription = ""
        Me.XTextBox4.FindInitialValue = Nothing
        Me.XTextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.IgnoreRequiered = False
        Me.XTextBox4.Location = New System.Drawing.Point(95, 112)
        Me.XTextBox4.Name = "XTextBox4"
        Me.XTextBox4.NewInitialValue = Nothing
        Me.XTextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.Requiered = False
        Me.XTextBox4.Size = New System.Drawing.Size(41, 20)
        Me.XTextBox4.StatusBarPanelDescripcion = Nothing
        Me.XTextBox4.TabIndex = 2
        Me.XTextBox4.Text = ""
        '
        'XTextBox5
        '
        Me.XTextBox5.AcceptsReturn = True
        Me.XTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "vw_cbdocsd.perdr_year"))
        Me.XTextBox5.EditInitialValue = Nothing
        Me.XTextBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.FieldDescription = ""
        Me.XTextBox5.FindInitialValue = Nothing
        Me.XTextBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.IgnoreRequiered = False
        Me.XTextBox5.Location = New System.Drawing.Point(133, 112)
        Me.XTextBox5.Name = "XTextBox5"
        Me.XTextBox5.NewInitialValue = Nothing
        Me.XTextBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.Requiered = False
        Me.XTextBox5.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox5.StatusBarPanelDescripcion = Nothing
        Me.XTextBox5.TabIndex = 3
        Me.XTextBox5.Text = ""
        '
        'fecha_fin
        '
        Me.fecha_fin.CustomFormat = "dd/MM/yyyy"
        Me.fecha_fin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "vw_cbdocsd.doc_date"))
        Me.fecha_fin.EditInitialValue = Nothing
        Me.fecha_fin.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecha_fin.FieldDescription = ""
        Me.fecha_fin.FindInitialValue = ""
        Me.fecha_fin.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha_fin.IgnoreRequiered = False
        Me.fecha_fin.Location = New System.Drawing.Point(96, 88)
        Me.fecha_fin.Name = "fecha_fin"
        Me.fecha_fin.NewInitialValue = Nothing
        Me.fecha_fin.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecha_fin.Requiered = False
        Me.fecha_fin.Size = New System.Drawing.Size(88, 20)
        Me.fecha_fin.StatusBarPanelDescripcion = Nothing
        Me.fecha_fin.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Fecha Fin:"
        '
        'r_cbrcuem01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(530, 256)
        Me.Controls.Add(Me.fecha_fin)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.XTextBox5)
        Me.Controls.Add(Me.XTextBox4)
        Me.Controls.Add(Me.XTextBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.acct_name)
        Me.Controls.Add(Me.LibXLookup2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Xtxsuc_code)
        Me.Controls.Add(Me.LibXLookup1)
        Me.Controls.Add(Me.Txtsuc_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Xtxtran_type)
        Me.Controls.Add(Me.Xtxchequera)
        Me.Controls.Add(Me.Fecha_ini)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.klx_chequera)
        Me.Controls.Add(Me.Txtchk_name)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txttype_name)
        Me.Controls.Add(Me.Lbltype_code)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "r_cbrcuem01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Resumen de Cuentas"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim AxCrystalReport1 As LibX.ReportLib
        Dim SelecStmt As String
        Dim sFechaDesde As String
        Dim sFechaHasta As String
        Dim sChequera As String
        Dim sWhere As String

        Try
            If Not IsNull(Me.Fecha_ini.Value) Then
                sFechaDesde = CDate(Me.Fecha_ini.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(Me.fecha_fin.Value) Then
                sFechaHasta = CDate(Me.fecha_fin.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If sFechaDesde <> "" And sFechaHasta = "" Then
                sFechaDesde = ""
            End If

            If e.row!chequera <> 0 Then
                sChequera = e.row!chequera.ToString
            End If

            AxCrystalReport1 = New ReportLib("CTB", "r_cbrcuem01.rpt")

            With AxCrystalReport1
                sWhere = " 1=1 "

                If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                    sWhere = String.Concat(sWhere, " and vw_cbdocsd.doc_date between '", Trim(sFechaDesde), "'and'", Trim(sFechaHasta), "'")
                ElseIf Trim(sFechaDesde) <> "" Then
                    sWhere = String.Concat(sWhere, " and vw_cbdocsd.doc_date = '", Trim(sFechaDesde), "'")
                ElseIf Trim(sFechaHasta) <> "" Then
                    sWhere = String.Concat(sWhere, " and vw_cbdocsd.doc_date = '", Trim(sFechaHasta), "'")
                End If

                If Not IsNull(e.row!perdr_year) Then
                    sWhere = String.Concat(sWhere, " and vw_cbdocsd.perdr_year = ", Trim(e.row!perdr_year.ToString))
                End If
                If Not IsNull(e.row!perdr_num) Then
                    sWhere = String.Concat(sWhere, " and vw_cbdocsd.perdr_num = ", Trim(e.row!perdr_num.ToString))
                End If

                If Not IsNull(sChequera) Then
                    sWhere = String.Concat(sWhere, " and vw_cbdocsd.chequera = ", Trim(sChequera.ToString))
                End If

                If Not IsNull(e.row!suc_code) Then
                    sWhere = String.Concat(sWhere, " and vw_cbdocsd.suc_code= ", Trim(e.row!suc_code.ToString))
                End If

                If Not IsNull(e.row!tran_type) Then
                    sWhere = String.Concat(sWhere, " and vw_cbdocsd.tran_type = '", Trim(e.row!tran_type.ToString), "'")
                End If

                If Not IsNull(e.row!acct_no) Then
                    sWhere = String.Concat(sWhere, " and vw_cbdocsd.acct_no = '", Trim(e.row!acct_no.ToString), "'")
                End If
                '''.ParameterFields(1) = String.Concat("Fecha_ini;", Trim(sFechaDesde), ";TRUE")
                '''.ParameterFields(2) = String.Concat("fecha_fin;", Trim(sFechaHasta), ";true")

                '// Recibir el SQL Query
                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                .SQLQuery = SelecStmt

                '// Ejecutar el reporte
                .Action = 1

            End With

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Me.LibXConnector1.AcceptFind()
        Me.LibXConnector1.Find()
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        If Me.LibXConnector1.IsEditing Then
            Me.LibXConnector1.Cancel()
        End If
        Me.LibXConnector1.Find()
    End Sub

    Private Sub r_ftfact10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LibXConnector1.Find()
    End Sub

End Class
