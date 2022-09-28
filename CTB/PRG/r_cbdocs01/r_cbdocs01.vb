Imports LibX
Public Class r_cbdocs01
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Lbltype_code As LibX.LibXLookup
    Friend WithEvents fecHasta As LibX.LibxDateTimePicker
    Friend WithEvents Fecha_ini As LibX.LibxDateTimePicker
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents klx_chequera As LibX.LibXLookup
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents Xtxsuc_code As LibX.XTextBox
    Friend WithEvents Txttype_name As System.Windows.Forms.TextBox
    Friend WithEvents Txtchk_name As System.Windows.Forms.TextBox
    Friend WithEvents Xtxchequera As LibX.XTextBox
    Friend WithEvents Xtxtran_type As LibX.XTextBox
    Friend WithEvents Txtsuc_name As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
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
        Me.fecHasta = New LibX.LibxDateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Fecha_ini = New LibX.LibxDateTimePicker
        Me.Xtxchequera = New LibX.XTextBox
        Me.Xtxtran_type = New LibX.XTextBox
        Me.Xtxsuc_code = New LibX.XTextBox
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.Txtsuc_name = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXConnector1.DataMember = "vw_cbdocsv"
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn1, Me.DataColumn2})
        Me.DataTable1.TableName = "vw_cbdocsv"
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
        Me.DataColumn22.ColumnName = "tran_type"
        Me.DataColumn22.MaxLength = 3
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "chequera"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "descripcion"
        Me.DataColumn24.MaxLength = 50
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "doc_number"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.AllowDBNull = False
        Me.DataColumn26.ColumnName = "doc_date"
        Me.DataColumn26.DataType = GetType(System.DateTime)
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "doc_status"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "Benef"
        Me.DataColumn28.MaxLength = 60
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "valor"
        Me.DataColumn29.DataType = GetType(System.Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "debit_credit"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "debito"
        Me.DataColumn31.DataType = GetType(System.Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "credito"
        Me.DataColumn32.DataType = GetType(System.Decimal)
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "fecha_ini"
        Me.DataColumn1.ColumnName = "fecha_ini"
        Me.DataColumn1.DataType = GetType(System.DateTime)
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "fecha_fin"
        Me.DataColumn2.ColumnName = "fecha_fin"
        Me.DataColumn2.DataType = GetType(System.DateTime)
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
        Me.LibXDbSourceTable1.TableName = "vw_cbdocsv"
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
        Me.Label5.Text = "DIARIO DE DOCUMENTOS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(27, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Chequera:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(30, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Tipo Doc. :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txttype_name
        '
        Me.Txttype_name.Location = New System.Drawing.Point(160, 160)
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
        Me.Lbltype_code.Location = New System.Drawing.Point(408, 160)
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
        Me.Txtchk_name.Location = New System.Drawing.Point(159, 136)
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
        Me.klx_chequera.Location = New System.Drawing.Point(408, 137)
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
        'fecHasta
        '
        Me.fecHasta.CustomFormat = "dd/MM/yyyy"
        Me.fecHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "vw_cbdocsv.Fecha_fin"))
        Me.fecHasta.EditInitialValue = Nothing
        Me.fecHasta.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecHasta.FieldDescription = ""
        Me.fecHasta.FindInitialValue = ""
        Me.fecHasta.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecHasta.IgnoreRequiered = False
        Me.fecHasta.Location = New System.Drawing.Point(96, 88)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.NewInitialValue = Nothing
        Me.fecHasta.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecHasta.Requiered = False
        Me.fecHasta.Size = New System.Drawing.Size(121, 20)
        Me.fecHasta.StatusBarPanelDescripcion = Nothing
        Me.fecHasta.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Fecha Inicial :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Fecha Final :"
        '
        'Fecha_ini
        '
        Me.Fecha_ini.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_ini.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "vw_cbdocsv.Fecha_ini"))
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
        Me.Fecha_ini.Size = New System.Drawing.Size(121, 20)
        Me.Fecha_ini.StatusBarPanelDescripcion = Nothing
        Me.Fecha_ini.TabIndex = 31
        '
        'Xtxchequera
        '
        Me.Xtxchequera.AcceptsReturn = True
        Me.Xtxchequera.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "vw_cbdocsv.chequera"))
        Me.Xtxchequera.EditInitialValue = Nothing
        Me.Xtxchequera.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxchequera.FieldDescription = ""
        Me.Xtxchequera.FindInitialValue = Nothing
        Me.Xtxchequera.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxchequera.IgnoreRequiered = False
        Me.Xtxchequera.Location = New System.Drawing.Point(96, 136)
        Me.Xtxchequera.Name = "Xtxchequera"
        Me.Xtxchequera.NewInitialValue = Nothing
        Me.Xtxchequera.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxchequera.Requiered = False
        Me.Xtxchequera.Size = New System.Drawing.Size(64, 20)
        Me.Xtxchequera.StatusBarPanelDescripcion = Nothing
        Me.Xtxchequera.TabIndex = 32
        Me.Xtxchequera.Text = ""
        '
        'Xtxtran_type
        '
        Me.Xtxtran_type.AcceptsReturn = True
        Me.Xtxtran_type.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "vw_cbdocsv.tran_type"))
        Me.Xtxtran_type.EditInitialValue = Nothing
        Me.Xtxtran_type.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxtran_type.FieldDescription = ""
        Me.Xtxtran_type.FindInitialValue = Nothing
        Me.Xtxtran_type.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxtran_type.IgnoreRequiered = False
        Me.Xtxtran_type.Location = New System.Drawing.Point(96, 160)
        Me.Xtxtran_type.Name = "Xtxtran_type"
        Me.Xtxtran_type.NewInitialValue = Nothing
        Me.Xtxtran_type.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxtran_type.Requiered = False
        Me.Xtxtran_type.Size = New System.Drawing.Size(64, 20)
        Me.Xtxtran_type.StatusBarPanelDescripcion = Nothing
        Me.Xtxtran_type.TabIndex = 33
        Me.Xtxtran_type.Text = ""
        '
        'Xtxsuc_code
        '
        Me.Xtxsuc_code.AcceptsReturn = True
        Me.Xtxsuc_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "vw_cbdocsv.suc_code"))
        Me.Xtxsuc_code.EditInitialValue = Nothing
        Me.Xtxsuc_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxsuc_code.FieldDescription = ""
        Me.Xtxsuc_code.FindInitialValue = Nothing
        Me.Xtxsuc_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxsuc_code.IgnoreRequiered = False
        Me.Xtxsuc_code.Location = New System.Drawing.Point(96, 112)
        Me.Xtxsuc_code.Name = "Xtxsuc_code"
        Me.Xtxsuc_code.NewInitialValue = Nothing
        Me.Xtxsuc_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Xtxsuc_code.Requiered = False
        Me.Xtxsuc_code.Size = New System.Drawing.Size(64, 20)
        Me.Xtxsuc_code.StatusBarPanelDescripcion = Nothing
        Me.Xtxsuc_code.TabIndex = 40
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
        Me.LibXLookup1.Location = New System.Drawing.Point(408, 115)
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
        Me.Txtsuc_name.Location = New System.Drawing.Point(159, 113)
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
        Me.Label3.Location = New System.Drawing.Point(33, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Sucursal:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'r_cbdocs01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(530, 200)
        Me.Controls.Add(Me.Xtxsuc_code)
        Me.Controls.Add(Me.LibXLookup1)
        Me.Controls.Add(Me.Txtsuc_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Xtxtran_type)
        Me.Controls.Add(Me.Xtxchequera)
        Me.Controls.Add(Me.Fecha_ini)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fecHasta)
        Me.Controls.Add(Me.klx_chequera)
        Me.Controls.Add(Me.Txtchk_name)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txttype_name)
        Me.Controls.Add(Me.Lbltype_code)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "r_cbdocs01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Diario de Documentos"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim AxCrystalReport1 As LibX.ReportLib
        Dim SelecStmt As String
        Dim sFechaDesde As String
        Dim sFechaHasta As String
        Dim sWhere As String

        Try
            If Not IsNull(e.row!Fecha_ini) Then
                sFechaDesde = CDate(e.row!Fecha_ini).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(e.row!Fecha_fin) Then
                sFechaHasta = CDate(e.row!Fecha_fin).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            AxCrystalReport1 = New ReportLib("CTB", "r_cbdocs01.rpt")

            With AxCrystalReport1
                sWhere = " 1=1 "

                If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                    sWhere = String.Concat(sWhere, " and vw_cbdocsv.doc_date between '", Trim(sFechaDesde), "'and'", Trim(sFechaHasta), "'")
                ElseIf Trim(sFechaDesde) <> "" Then
                    sWhere = String.Concat(sWhere, " and vw_cbdocsv.doc_date = '", Trim(sFechaDesde), "'")
                ElseIf Trim(sFechaHasta) <> "" Then
                    sWhere = String.Concat(sWhere, " and vw_cbdocsv.doc_date = '", Trim(sFechaHasta), "'")
                End If

                If Not IsNull(e.row!chequera) Then
                    sWhere = String.Concat(sWhere, " and vw_cbdocsv.chequera = ", Trim(e.row!chequera.ToString))
                End If

                If Not IsNull(e.row!suc_code) Then
                    sWhere = String.Concat(sWhere, " and vw_cbdocsv.suc_code= ", Trim(e.row!suc_code.ToString))
                End If

                If Not IsNull(e.row!tran_type) Then
                    sWhere = String.Concat(sWhere, " and vw_cbdocsv.tran_type = '", Trim(e.row!tran_type.ToString), "'")
                End If

                .ParameterFields(1) = String.Concat("Fecha_ini;", Trim(sFechaDesde), ";TRUE")
                .ParameterFields(2) = String.Concat("fecha_fin;", Trim(sFechaHasta), ";true")

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
