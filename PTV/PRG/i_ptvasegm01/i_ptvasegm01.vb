Public Class i_ptvasegm01
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents XTextBox5 As LibX.XTextBox
    Friend WithEvents XTextBox6 As LibX.XTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents LabCompañia As System.Windows.Forms.Label
    Friend WithEvents LabPlanseguro As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents LabCliente As System.Windows.Forms.Label
    Friend WithEvents xtx_estado As LibX.LibXCombo
    Friend WithEvents lbl_ciudad As System.Windows.Forms.Label
    Friend WithEvents xlk_city_code As LibX.LibXLookup
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_sector As System.Windows.Forms.Label
    Friend WithEvents xlk_sector_code As LibX.LibXLookup
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents XTextBox9 As LibX.XTextBox
    Friend WithEvents xtxt_city_code As LibX.XTextBox
    Friend WithEvents xtxt_cedula As LibX.XMaskEdit
    Friend WithEvents xtxt_telefono As LibX.XMaskEdit
    Friend WithEvents xtxt_cia_serial As LibX.XTextBox
    Friend WithEvents xtxt_aseg_nombre As LibX.XTextBox
    Friend WithEvents xtxt_aseg_poliza As LibX.XTextBox
    Friend WithEvents xtxt_aseg_address As LibX.XTextBox
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
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
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Lkl_clini_code As LibX.LibXLookup
    Friend WithEvents clini_name As System.Windows.Forms.Label
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents XTxtLimite As LibX.XTextBox
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.XTxtLimite = New LibX.XTextBox
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
        Me.Label14 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Lkl_clini_code = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.clini_name = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.lbl_sector = New System.Windows.Forms.Label
        Me.xlk_sector_code = New LibX.LibXLookup
        Me.Label13 = New System.Windows.Forms.Label
        Me.XTextBox9 = New LibX.XTextBox
        Me.lbl_ciudad = New System.Windows.Forms.Label
        Me.xlk_city_code = New LibX.LibXLookup
        Me.Label11 = New System.Windows.Forms.Label
        Me.xtxt_city_code = New LibX.XTextBox
        Me.LabCliente = New System.Windows.Forms.Label
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LabCompañia = New System.Windows.Forms.Label
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.Label10 = New System.Windows.Forms.Label
        Me.xtxt_aseg_address = New LibX.XTextBox
        Me.LabPlanseguro = New System.Windows.Forms.Label
        Me.XTextBox6 = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.XTextBox5 = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.xtxt_cedula = New LibX.XMaskEdit
        Me.xtxt_aseg_nombre = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.xtx_estado = New LibX.LibXCombo
        Me.Label5 = New System.Windows.Forms.Label
        Me.xtxt_telefono = New LibX.XMaskEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.xtxt_aseg_poliza = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.xtxt_cia_serial = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.XTxtLimite)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Lkl_clini_code)
        Me.GroupBox1.Controls.Add(Me.clini_name)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.LibxCheckBox1)
        Me.GroupBox1.Controls.Add(Me.lbl_sector)
        Me.GroupBox1.Controls.Add(Me.xlk_sector_code)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.XTextBox9)
        Me.GroupBox1.Controls.Add(Me.lbl_ciudad)
        Me.GroupBox1.Controls.Add(Me.xlk_city_code)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.xtxt_city_code)
        Me.GroupBox1.Controls.Add(Me.LabCliente)
        Me.GroupBox1.Controls.Add(Me.LibXLookup3)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.LabCompañia)
        Me.GroupBox1.Controls.Add(Me.LibXLookup2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.xtxt_aseg_address)
        Me.GroupBox1.Controls.Add(Me.LabPlanseguro)
        Me.GroupBox1.Controls.Add(Me.XTextBox6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.XTextBox5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.xtxt_cedula)
        Me.GroupBox1.Controls.Add(Me.xtxt_aseg_nombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xtx_estado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xtxt_telefono)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xtxt_aseg_poliza)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xtxt_cia_serial)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 336)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'XTxtLimite
        '
        Me.XTxtLimite.AcceptsReturn = True
        Me.XTxtLimite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTxtLimite.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.aseg_limite"))
        Me.XTxtLimite.EditInitialValue = Nothing
        Me.XTxtLimite.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTxtLimite.FieldDescription = ""
        Me.XTxtLimite.FindInitialValue = Nothing
        Me.XTxtLimite.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTxtLimite.IgnoreRequiered = False
        Me.XTxtLimite.Location = New System.Drawing.Point(104, 160)
        Me.XTxtLimite.Name = "XTxtLimite"
        Me.XTxtLimite.NewInitialValue = Nothing
        Me.XTxtLimite.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTxtLimite.Requiered = False
        Me.XTxtLimite.Size = New System.Drawing.Size(160, 20)
        Me.XTxtLimite.StatusBarPanelDescripcion = Nothing
        Me.XTxtLimite.TabIndex = 9
        Me.XTxtLimite.Text = ""
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"aseg_serial"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "sgasegm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "aseg_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "cia_serial"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "plan_serial"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "aseg_poliza"
        Me.DataColumn4.MaxLength = 20
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "aseg_nombre"
        Me.DataColumn5.MaxLength = 80
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "aseg_address"
        Me.DataColumn6.MaxLength = 120
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "aseg_phone"
        Me.DataColumn7.MaxLength = 13
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "aseg_cedula"
        Me.DataColumn8.MaxLength = 20
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "cust_code"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "aseg_status"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "city_code"
        Me.DataColumn11.MaxLength = 3
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sector_code"
        Me.DataColumn12.MaxLength = 3
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "aseg_principal"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "clini_code"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "aseg_apellidos"
        Me.DataColumn15.MaxLength = 40
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "aseg_limite"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(48, 160)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 16)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Limite:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.aseg_apellidos"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(320, 88)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(216, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 5
        Me.XTextBox2.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(263, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 16)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Apellidos:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Lkl_clini_code
        '
        Me.Lkl_clini_code.AlternateFieldSearch = Nothing
        Me.Lkl_clini_code.BeginCheck = False
        Me.Lkl_clini_code.CheckText = Nothing
        Me.Lkl_clini_code.ComboMode = False
        Me.Lkl_clini_code.DataMember = Nothing
        Me.Lkl_clini_code.DataSource = Me.LibXConnector1
        Me.Lkl_clini_code.DestParameters = New String() {"clini_code=clini_code", "clini_name=clini_name"}
        Me.Lkl_clini_code.FilterField = Nothing
        Me.Lkl_clini_code.IgnoreFindInBrowseMode = False
        Me.Lkl_clini_code.isCanceled = False
        Me.Lkl_clini_code.Location = New System.Drawing.Point(520, 112)
        Me.Lkl_clini_code.LookCaption = Nothing
        Me.Lkl_clini_code.Name = "Lkl_clini_code"
        Me.Lkl_clini_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.Lkl_clini_code.ShowFilter = True
        Me.Lkl_clini_code.ShowMessageNotFound = True
        Me.Lkl_clini_code.ShowWarning = False
        Me.Lkl_clini_code.Size = New System.Drawing.Size(16, 20)
        Me.Lkl_clini_code.SizesColumns = Nothing
        Me.Lkl_clini_code.SizesColumnsTab = Nothing
        Me.Lkl_clini_code.SqlString = Nothing
        Me.Lkl_clini_code.SQLTab = Nothing
        Me.Lkl_clini_code.SrcParameters = New String() {"clini_code=clini_code"}
        Me.Lkl_clini_code.TabIndex = 38
        Me.Lkl_clini_code.TableName = "sclinicam"
        Me.Lkl_clini_code.TabStop = False
        Me.Lkl_clini_code.UseCopyConnection = False
        Me.Lkl_clini_code.UseRowRetrieveEvents = False
        Me.Lkl_clini_code.UseTab = False
        Me.Lkl_clini_code.VisParameters = New String() {"Código=clini_code", "Descripción=clini_name"}
        Me.Lkl_clini_code.WhereCondition = Nothing
        Me.Lkl_clini_code.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "sgasegm"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
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
        Me.LibXDbSourceTable1.SerialColumnName = "aseg_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "sgasegm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "aseg_balance"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "bal_acumulado"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        '
        'clini_name
        '
        Me.clini_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.clini_name.Location = New System.Drawing.Point(176, 112)
        Me.clini_name.Name = "clini_name"
        Me.clini_name.Size = New System.Drawing.Size(344, 20)
        Me.clini_name.TabIndex = 37
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.clini_code"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(104, 112)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(64, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 6
        Me.XTextBox1.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(48, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 16)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Clinica:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "sgasegm.aseg_principal"))
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(544, 16)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = Nothing
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = True
        Me.LibxCheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox1.Size = New System.Drawing.Size(112, 16)
        Me.LibxCheckBox1.TabIndex = 34
        Me.LibxCheckBox1.Text = "Principal"
        Me.LibxCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'lbl_sector
        '
        Me.lbl_sector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_sector.Location = New System.Drawing.Point(176, 264)
        Me.lbl_sector.Name = "lbl_sector"
        Me.lbl_sector.Size = New System.Drawing.Size(344, 24)
        Me.lbl_sector.TabIndex = 33
        '
        'xlk_sector_code
        '
        Me.xlk_sector_code.AlternateFieldSearch = Nothing
        Me.xlk_sector_code.BeginCheck = False
        Me.xlk_sector_code.CheckText = Nothing
        Me.xlk_sector_code.ComboMode = False
        Me.xlk_sector_code.DataMember = Nothing
        Me.xlk_sector_code.DataSource = Me.LibXConnector1
        Me.xlk_sector_code.DestParameters = New String() {"city_code=city_code", "sector_code=sector_code", "lbl_sector=sector_name"}
        Me.xlk_sector_code.FilterField = Nothing
        Me.xlk_sector_code.IgnoreFindInBrowseMode = False
        Me.xlk_sector_code.isCanceled = False
        Me.xlk_sector_code.Location = New System.Drawing.Point(520, 264)
        Me.xlk_sector_code.LookCaption = Nothing
        Me.xlk_sector_code.Name = "xlk_sector_code"
        Me.xlk_sector_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_sector_code.ShowFilter = True
        Me.xlk_sector_code.ShowMessageNotFound = True
        Me.xlk_sector_code.ShowWarning = False
        Me.xlk_sector_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_sector_code.SizesColumns = Nothing
        Me.xlk_sector_code.SizesColumnsTab = Nothing
        Me.xlk_sector_code.SqlString = Nothing
        Me.xlk_sector_code.SQLTab = Nothing
        Me.xlk_sector_code.SrcParameters = New String() {"sector_code=sector_code"}
        Me.xlk_sector_code.TabIndex = 32
        Me.xlk_sector_code.TableName = "ccsectorm"
        Me.xlk_sector_code.TabStop = False
        Me.xlk_sector_code.UseCopyConnection = False
        Me.xlk_sector_code.UseRowRetrieveEvents = False
        Me.xlk_sector_code.UseTab = False
        Me.xlk_sector_code.VisParameters = New String() {"Código=sector_code", "Sector=sector_name"}
        Me.xlk_sector_code.WhereCondition = ""
        Me.xlk_sector_code.WhereParameters = Nothing
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(40, 264)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 16)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Sector:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox9
        '
        Me.XTextBox9.AcceptsReturn = True
        Me.XTextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.sector_code"))
        Me.XTextBox9.EditInitialValue = Nothing
        Me.XTextBox9.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.FieldDescription = ""
        Me.XTextBox9.FindInitialValue = Nothing
        Me.XTextBox9.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.IgnoreRequiered = False
        Me.XTextBox9.Location = New System.Drawing.Point(104, 264)
        Me.XTextBox9.Name = "XTextBox9"
        Me.XTextBox9.NewInitialValue = Nothing
        Me.XTextBox9.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.Requiered = False
        Me.XTextBox9.Size = New System.Drawing.Size(64, 20)
        Me.XTextBox9.StatusBarPanelDescripcion = Nothing
        Me.XTextBox9.TabIndex = 12
        Me.XTextBox9.Text = ""
        '
        'lbl_ciudad
        '
        Me.lbl_ciudad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ciudad.Location = New System.Drawing.Point(176, 240)
        Me.lbl_ciudad.Name = "lbl_ciudad"
        Me.lbl_ciudad.Size = New System.Drawing.Size(344, 24)
        Me.lbl_ciudad.TabIndex = 29
        '
        'xlk_city_code
        '
        Me.xlk_city_code.AlternateFieldSearch = Nothing
        Me.xlk_city_code.BeginCheck = False
        Me.xlk_city_code.CheckText = Nothing
        Me.xlk_city_code.ComboMode = False
        Me.xlk_city_code.DataMember = Nothing
        Me.xlk_city_code.DataSource = Me.LibXConnector1
        Me.xlk_city_code.DestParameters = New String() {"city_code=city_code", "lbl_ciudad=city_name"}
        Me.xlk_city_code.FilterField = "city_name"
        Me.xlk_city_code.IgnoreFindInBrowseMode = False
        Me.xlk_city_code.isCanceled = False
        Me.xlk_city_code.Location = New System.Drawing.Point(520, 240)
        Me.xlk_city_code.LookCaption = Nothing
        Me.xlk_city_code.Name = "xlk_city_code"
        Me.xlk_city_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_city_code.ShowFilter = True
        Me.xlk_city_code.ShowMessageNotFound = True
        Me.xlk_city_code.ShowWarning = False
        Me.xlk_city_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_city_code.SizesColumns = Nothing
        Me.xlk_city_code.SizesColumnsTab = Nothing
        Me.xlk_city_code.SqlString = Nothing
        Me.xlk_city_code.SQLTab = Nothing
        Me.xlk_city_code.SrcParameters = New String() {"city_code=city_code"}
        Me.xlk_city_code.TabIndex = 28
        Me.xlk_city_code.TableName = "cccity"
        Me.xlk_city_code.TabStop = False
        Me.xlk_city_code.UseCopyConnection = False
        Me.xlk_city_code.UseRowRetrieveEvents = False
        Me.xlk_city_code.UseTab = False
        Me.xlk_city_code.VisParameters = New String() {"Código=city_code", "Ciudad=city_name"}
        Me.xlk_city_code.WhereCondition = ""
        Me.xlk_city_code.WhereParameters = Nothing
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(40, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Ciudad:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_city_code
        '
        Me.xtxt_city_code.AcceptsReturn = True
        Me.xtxt_city_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_city_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.city_code"))
        Me.xtxt_city_code.EditInitialValue = Nothing
        Me.xtxt_city_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_city_code.FieldDescription = ""
        Me.xtxt_city_code.FindInitialValue = Nothing
        Me.xtxt_city_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_city_code.IgnoreRequiered = False
        Me.xtxt_city_code.Location = New System.Drawing.Point(104, 240)
        Me.xtxt_city_code.Name = "xtxt_city_code"
        Me.xtxt_city_code.NewInitialValue = Nothing
        Me.xtxt_city_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_city_code.Requiered = False
        Me.xtxt_city_code.Size = New System.Drawing.Size(64, 20)
        Me.xtxt_city_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_city_code.TabIndex = 11
        Me.xtxt_city_code.Text = ""
        '
        'LabCliente
        '
        Me.LabCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabCliente.Location = New System.Drawing.Point(176, 288)
        Me.LabCliente.Name = "LabCliente"
        Me.LabCliente.Size = New System.Drawing.Size(344, 24)
        Me.LabCliente.TabIndex = 25
        '
        'LibXLookup3
        '
        Me.LibXLookup3.AlternateFieldSearch = Nothing
        Me.LibXLookup3.BeginCheck = False
        Me.LibXLookup3.CheckText = Nothing
        Me.LibXLookup3.ComboMode = False
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Me.LibXConnector1
        Me.LibXLookup3.DestParameters = New String() {"cia_serial=cia_serial", "plan_serial=plan_serial", "LabPlanseguro=plan_name"}
        Me.LibXLookup3.FilterField = Nothing
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.isCanceled = False
        Me.LibXLookup3.Location = New System.Drawing.Point(520, 64)
        Me.LibXLookup3.LookCaption = Nothing
        Me.LibXLookup3.Name = "LibXLookup3"
        Me.LibXLookup3.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup3.ShowFilter = True
        Me.LibXLookup3.ShowMessageNotFound = True
        Me.LibXLookup3.ShowWarning = False
        Me.LibXLookup3.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup3.SizesColumns = Nothing
        Me.LibXLookup3.SizesColumnsTab = Nothing
        Me.LibXLookup3.SqlString = Nothing
        Me.LibXLookup3.SQLTab = Nothing
        Me.LibXLookup3.SrcParameters = New String() {"plan_serial=plan_serial"}
        Me.LibXLookup3.TabIndex = 24
        Me.LibXLookup3.TableName = "sgplanm"
        Me.LibXLookup3.TabStop = False
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.UseTab = False
        Me.LibXLookup3.VisParameters = New String() {"Código=plan_serial", "Descripción=plan_name"}
        Me.LibXLookup3.WhereCondition = Nothing
        Me.LibXLookup3.WhereParameters = Nothing
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"cia_serial=cia_serial", "LabCompañia=cia_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(520, 40)
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
        Me.LibXLookup1.SrcParameters = New String() {"cia_serial=cia_serial"}
        Me.LibXLookup1.TabIndex = 23
        Me.LibXLookup1.TableName = "sgciasm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=cia_serial", "Descripción=cia_name"}
        Me.LibXLookup1.WhereCondition = ""
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'LabCompañia
        '
        Me.LabCompañia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabCompañia.Location = New System.Drawing.Point(176, 40)
        Me.LabCompañia.Name = "LabCompañia"
        Me.LabCompañia.Size = New System.Drawing.Size(344, 20)
        Me.LabCompañia.TabIndex = 22
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"cust_code=cust_code", "LabCliente=cust_name"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(520, 288)
        Me.LibXLookup2.LookCaption = Nothing
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
        Me.LibXLookup2.SrcParameters = New String() {"cust_code=cust_code"}
        Me.LibXLookup2.TabIndex = 21
        Me.LibXLookup2.TableName = "cccustm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=cust_code", "Descripción=cust_name", ""}
        Me.LibXLookup2.WhereCondition = "csttype_code !=5"
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(32, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Dirección:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_aseg_address
        '
        Me.xtxt_aseg_address.AcceptsReturn = True
        Me.xtxt_aseg_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_aseg_address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.aseg_address"))
        Me.xtxt_aseg_address.EditInitialValue = Nothing
        Me.xtxt_aseg_address.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_aseg_address.FieldDescription = ""
        Me.xtxt_aseg_address.FindInitialValue = Nothing
        Me.xtxt_aseg_address.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_aseg_address.IgnoreRequiered = False
        Me.xtxt_aseg_address.Location = New System.Drawing.Point(104, 184)
        Me.xtxt_aseg_address.Multiline = True
        Me.xtxt_aseg_address.Name = "xtxt_aseg_address"
        Me.xtxt_aseg_address.NewInitialValue = Nothing
        Me.xtxt_aseg_address.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_aseg_address.Requiered = False
        Me.xtxt_aseg_address.Size = New System.Drawing.Size(432, 56)
        Me.xtxt_aseg_address.StatusBarPanelDescripcion = Nothing
        Me.xtxt_aseg_address.TabIndex = 10
        Me.xtxt_aseg_address.Text = ""
        '
        'LabPlanseguro
        '
        Me.LabPlanseguro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabPlanseguro.Location = New System.Drawing.Point(176, 64)
        Me.LabPlanseguro.Name = "LabPlanseguro"
        Me.LabPlanseguro.Size = New System.Drawing.Size(344, 20)
        Me.LabPlanseguro.TabIndex = 17
        '
        'XTextBox6
        '
        Me.XTextBox6.AcceptsReturn = True
        Me.XTextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.plan_serial"))
        Me.XTextBox6.EditInitialValue = Nothing
        Me.XTextBox6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.FieldDescription = ""
        Me.XTextBox6.FindInitialValue = Nothing
        Me.XTextBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.IgnoreRequiered = False
        Me.XTextBox6.Location = New System.Drawing.Point(104, 64)
        Me.XTextBox6.Name = "XTextBox6"
        Me.XTextBox6.NewInitialValue = Nothing
        Me.XTextBox6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.Requiered = False
        Me.XTextBox6.Size = New System.Drawing.Size(64, 20)
        Me.XTextBox6.StatusBarPanelDescripcion = Nothing
        Me.XTextBox6.TabIndex = 3
        Me.XTextBox6.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(8, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Cuenta Credito:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox5
        '
        Me.XTextBox5.AcceptsReturn = True
        Me.XTextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.cust_code"))
        Me.XTextBox5.EditInitialValue = Nothing
        Me.XTextBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.FieldDescription = ""
        Me.XTextBox5.FindInitialValue = Nothing
        Me.XTextBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.IgnoreRequiered = False
        Me.XTextBox5.Location = New System.Drawing.Point(104, 288)
        Me.XTextBox5.Name = "XTextBox5"
        Me.XTextBox5.NewInitialValue = Nothing
        Me.XTextBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.Requiered = False
        Me.XTextBox5.Size = New System.Drawing.Size(64, 20)
        Me.XTextBox5.StatusBarPanelDescripcion = Nothing
        Me.XTextBox5.TabIndex = 13
        Me.XTextBox5.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(40, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Cedula:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_cedula
        '
        Me.xtxt_cedula.AcceptsReturn = True
        Me.xtxt_cedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_cedula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.aseg_cedula"))
        Me.xtxt_cedula.EditInitialValue = Nothing
        Me.xtxt_cedula.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cedula.FieldDescription = ""
        Me.xtxt_cedula.FindInitialValue = Nothing
        Me.xtxt_cedula.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cedula.IgnoreRequiered = False
        Me.xtxt_cedula.Location = New System.Drawing.Point(104, 134)
        Me.xtxt_cedula.Masked = MaskedTextBox.Mask.None
        Me.xtxt_cedula.Name = "xtxt_cedula"
        Me.xtxt_cedula.NewInitialValue = Nothing
        Me.xtxt_cedula.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cedula.Requiered = False
        Me.xtxt_cedula.Size = New System.Drawing.Size(160, 20)
        Me.xtxt_cedula.StatusBarPanelDescripcion = Nothing
        Me.xtxt_cedula.TabIndex = 7
        Me.xtxt_cedula.Text = ""
        '
        'xtxt_aseg_nombre
        '
        Me.xtxt_aseg_nombre.AcceptsReturn = True
        Me.xtxt_aseg_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_aseg_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.aseg_nombre"))
        Me.xtxt_aseg_nombre.EditInitialValue = Nothing
        Me.xtxt_aseg_nombre.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_aseg_nombre.FieldDescription = ""
        Me.xtxt_aseg_nombre.FindInitialValue = Nothing
        Me.xtxt_aseg_nombre.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_aseg_nombre.IgnoreRequiered = False
        Me.xtxt_aseg_nombre.Location = New System.Drawing.Point(104, 88)
        Me.xtxt_aseg_nombre.Name = "xtxt_aseg_nombre"
        Me.xtxt_aseg_nombre.NewInitialValue = Nothing
        Me.xtxt_aseg_nombre.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_aseg_nombre.Requiered = False
        Me.xtxt_aseg_nombre.Size = New System.Drawing.Size(152, 20)
        Me.xtxt_aseg_nombre.StatusBarPanelDescripcion = Nothing
        Me.xtxt_aseg_nombre.TabIndex = 4
        Me.xtxt_aseg_nombre.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(360, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Estado:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtx_estado
        '
        Me.xtx_estado.AllowDefaultSort = True
        Me.xtx_estado.bound = True
        Me.xtx_estado.currValue = Nothing
        Me.xtx_estado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "sgasegm.aseg_status"))
        Me.xtx_estado.DefaultWhereString = Nothing
        Me.xtx_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xtx_estado.EditInitialValue = Nothing
        Me.xtx_estado.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtx_estado.FieldDescription = ""
        Me.xtx_estado.FindInitialValue = Nothing
        Me.xtx_estado.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtx_estado.IgnoreRequiered = False
        Me.xtx_estado.Items.AddRange(New Object() {"1-Activo", "2-Inativo"})
        Me.xtx_estado.Location = New System.Drawing.Point(416, 16)
        Me.xtx_estado.LookupKeyDisplayFields = Nothing
        Me.xtx_estado.LookupKeyField = Nothing
        Me.xtx_estado.LookupTableName = Nothing
        Me.xtx_estado.Name = "xtx_estado"
        Me.xtx_estado.NewInitialValue = Nothing
        Me.xtx_estado.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtx_estado.Requiered = False
        Me.xtx_estado.Required = False
        Me.xtx_estado.Size = New System.Drawing.Size(120, 21)
        Me.xtx_estado.SqlString = Nothing
        Me.xtx_estado.StatusBarPanelDescripcion = Nothing
        Me.xtx_estado.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(352, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Telefono:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_telefono
        '
        Me.xtxt_telefono.AcceptsReturn = True
        Me.xtxt_telefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_telefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.aseg_phone"))
        Me.xtxt_telefono.EditInitialValue = Nothing
        Me.xtxt_telefono.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono.FieldDescription = ""
        Me.xtxt_telefono.FindInitialValue = Nothing
        Me.xtxt_telefono.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono.IgnoreRequiered = False
        Me.xtxt_telefono.Location = New System.Drawing.Point(416, 134)
        Me.xtxt_telefono.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.xtxt_telefono.Name = "xtxt_telefono"
        Me.xtxt_telefono.NewInitialValue = Nothing
        Me.xtxt_telefono.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono.Requiered = False
        Me.xtxt_telefono.Size = New System.Drawing.Size(120, 20)
        Me.xtxt_telefono.StatusBarPanelDescripcion = Nothing
        Me.xtxt_telefono.TabIndex = 8
        Me.xtxt_telefono.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(43, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_aseg_poliza
        '
        Me.xtxt_aseg_poliza.AcceptsReturn = True
        Me.xtxt_aseg_poliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_aseg_poliza.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.aseg_poliza"))
        Me.xtxt_aseg_poliza.EditInitialValue = Nothing
        Me.xtxt_aseg_poliza.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_aseg_poliza.FieldDescription = ""
        Me.xtxt_aseg_poliza.FindInitialValue = Nothing
        Me.xtxt_aseg_poliza.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_aseg_poliza.IgnoreRequiered = False
        Me.xtxt_aseg_poliza.Location = New System.Drawing.Point(104, 16)
        Me.xtxt_aseg_poliza.Name = "xtxt_aseg_poliza"
        Me.xtxt_aseg_poliza.NewInitialValue = Nothing
        Me.xtxt_aseg_poliza.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_aseg_poliza.Requiered = False
        Me.xtxt_aseg_poliza.Size = New System.Drawing.Size(120, 20)
        Me.xtxt_aseg_poliza.StatusBarPanelDescripcion = Nothing
        Me.xtxt_aseg_poliza.TabIndex = 0
        Me.xtxt_aseg_poliza.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(13, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Póliza Seguro:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_cia_serial
        '
        Me.xtxt_cia_serial.AcceptsReturn = True
        Me.xtxt_cia_serial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.cia_serial"))
        Me.xtxt_cia_serial.EditInitialValue = Nothing
        Me.xtxt_cia_serial.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cia_serial.FieldDescription = ""
        Me.xtxt_cia_serial.FindInitialValue = Nothing
        Me.xtxt_cia_serial.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cia_serial.IgnoreRequiered = False
        Me.xtxt_cia_serial.Location = New System.Drawing.Point(104, 40)
        Me.xtxt_cia_serial.Name = "xtxt_cia_serial"
        Me.xtxt_cia_serial.NewInitialValue = Nothing
        Me.xtxt_cia_serial.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cia_serial.Requiered = False
        Me.xtxt_cia_serial.Size = New System.Drawing.Size(64, 20)
        Me.xtxt_cia_serial.StatusBarPanelDescripcion = Nothing
        Me.xtxt_cia_serial.TabIndex = 2
        Me.xtxt_cia_serial.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(35, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Compaña:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(21, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Plan Seguro:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_aseg_address
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_aseg_poliza
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_aseg_poliza
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(690, 24)
        Me.LibXNavigator1.TabIndex = 2
        '
        'i_ptvasegm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 392)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ptvasegm01"
        Me.Text = "Registro de Asegurado"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibX.LibxConnectionActions.Add Then
                xtx_estado.currValue = 1
            End If


            If e.AcceptedAction = LibX.LibxConnectionActions.Edit And _
               e.Action = LibX.LibxConnectionActions.Accept Then
                LibXConnector1.LoadDetail()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub

    Private Sub LibXLookup3_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles LibXLookup3.BeforeExecuteQuery
        Try

            If Me.xtxt_cia_serial.Text.Trim <> "" Then
                e.aditionalWhere = "cia_serial = " & Me.xtxt_cia_serial.Text.Trim
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub xlk_sector_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_sector_code.BeforeExecuteQuery
        Try

            If Me.xtxt_city_code.Text.Trim <> "" Then
                e.aditionalWhere = "city_code = '" & Me.xtxt_city_code.Text.Trim & "'"
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Dim mTipo As String
        Try

            If Not e.row Is Nothing Then
                If LibXConnector1.IsDataEditing = False And LibXConnector1.HasRecords = True Then
                    If findMod(Me.xtxt_aseg_poliza.Text) = True Then
                        LibXConnector1.AllowDelete = False
                    Else
                        LibXConnector1.AllowDelete = True
                    End If

                    LibXNavigator1.UpdateState()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Function findMod(ByVal asSeg As String) As Boolean
        Dim mov As Integer
        mov = LibX.Data.Manager.GetScalar("select count(*) from ftsegrm where aseg_poliza = '" & asSeg & "'")
        If mov > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub xtxt_aseg_address_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xtxt_aseg_address.TextChanged

    End Sub

End Class
