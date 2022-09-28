Public Class i_ptvfact05
    Inherits System.Windows.Forms.Form

    Dim WithEvents Label1 As System.Windows.Forms.Label
    Dim WithEvents Label4 As System.Windows.Forms.Label
    Dim WithEvents Label5 As System.Windows.Forms.Label
    Dim WithEvents Label7 As System.Windows.Forms.Label
    Dim WithEvents xcbo_Tipo As LibX.LibXCombo
    Dim WithEvents xtxt_address As LibX.XTextBox
    Dim WithEvents xtxt_telefono1 As LibX.XTextBox
    Dim WithEvents lbl_ciudad As System.Windows.Forms.Label
    Dim WithEvents xtxt_codigo As LibX.XMaskEdit
    Dim WithEvents Label13 As Label
    Dim WithEvents Label12 As Label
    Dim WithEvents lbl_Descuento As Label
    Dim WithEvents lbl_Cobertura As Label
    Dim WithEvents xlk_plan As LibX.LibXLookup
    Dim WithEvents xlk_compania As LibX.LibXLookup
    Dim WithEvents lbl_Compania As Label
    Dim WithEvents xtxt_plan As LibX.XTextBox
    Dim WithEvents xtxt_Compania As LibX.XTextBox
    Dim WithEvents Label10 As Label
    Dim WithEvents Label11 As Label
    Dim WithEvents lbl_Plan As Label
    Dim WithEvents Label9 As System.Windows.Forms.Label
    Dim WithEvents xlk_codigo As LibX.LibXLookup
    Dim WithEvents Label6 As System.Windows.Forms.Label
    Dim WithEvents XTextBox1 As LibX.XTextBox
    Dim WithEvents lbl_sector As System.Windows.Forms.Label
    Dim WithEvents Label8 As System.Windows.Forms.Label
    Dim WithEvents lbl_TipoDocumento As System.Windows.Forms.Label
    Dim WithEvents xlk_sector As LibX.LibXLookup
    Dim WithEvents xlk_ciudad As LibX.LibXLookup
    Dim WithEvents xtxt_sector As LibX.XTextBox
    Dim WithEvents xtxt_ciudad As LibX.XTextBox
    Dim WithEvents xtxt_nombre As LibX.XTextBox
    Dim WithEvents Label2 As System.Windows.Forms.Label
    Dim WithEvents Label3 As System.Windows.Forms.Label

    Dim WithEvents xlk_vend_code As LibX.LibXLookup
    Dim WithEvents lbl_mensajero As System.Windows.Forms.Label
    Dim WithEvents lbl_ult_domicilio As System.Windows.Forms.Label

    Dim oCliente As SGT.PuntodeVenta.Entidades.ClienteAsegurado
    Dim mExiste As Boolean

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents LBL_Title As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet

    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents sgasegm As System.Data.DataTable
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents lbl_Mensaje As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents XMaskEdit1 As LibX.XMaskEdit
    Private WithEvents xtxt_phone1 As LibX.XMaskEdit
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Lkl_clini_code As LibX.LibXLookup
    Friend WithEvents clini_name As System.Windows.Forms.Label
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents XTextBox4 As LibX.XTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtLimite As LibX.XTextBox
    Friend WithEvents XTextBox5 As LibX.XTextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.sgasegm = New System.Data.DataTable
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.XTextBox5 = New LibX.XTextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtLimite = New LibX.XTextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.XTextBox4 = New LibX.XTextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Lkl_clini_code = New LibX.LibXLookup
        Me.clini_name = New System.Windows.Forms.Label
        Me.lbl_Mensaje = New System.Windows.Forms.Label
        Me.xtxt_codigo = New LibX.XMaskEdit
        Me.xtxt_plan = New LibX.XTextBox
        Me.xtxt_Compania = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.xtxt_phone1 = New LibX.XMaskEdit
        Me.xtxt_sector = New LibX.XTextBox
        Me.xtxt_ciudad = New LibX.XTextBox
        Me.xtxt_nombre = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.xtxt_address = New LibX.XTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.XMaskEdit1 = New LibX.XMaskEdit
        Me.xlk_codigo = New LibX.LibXLookup
        Me.lbl_Cobertura = New System.Windows.Forms.Label
        Me.xlk_plan = New LibX.LibXLookup
        Me.xlk_compania = New LibX.LibXLookup
        Me.lbl_Compania = New System.Windows.Forms.Label
        Me.lbl_Plan = New System.Windows.Forms.Label
        Me.xlk_sector = New LibX.LibXLookup
        Me.xlk_ciudad = New LibX.LibXLookup
        Me.lbl_ciudad = New System.Windows.Forms.Label
        Me.lbl_sector = New System.Windows.Forms.Label
        Me.lbl_Descuento = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.LBL_Title = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.xtxt_telefono1 = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label16 = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sgasegm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.LibXConnector1.UseTransactions = True
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.sgasegm})
        '
        'sgasegm
        '
        Me.sgasegm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6})
        Me.sgasegm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"aseg_serial"}, True)})
        Me.sgasegm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn45}
        Me.sgasegm.TableName = "sgasegm"
        '
        'DataColumn45
        '
        Me.DataColumn45.AllowDBNull = False
        Me.DataColumn45.AutoIncrement = True
        Me.DataColumn45.ColumnName = "aseg_serial"
        Me.DataColumn45.DataType = GetType(System.Int32)
        Me.DataColumn45.ReadOnly = True
        '
        'DataColumn46
        '
        Me.DataColumn46.AllowDBNull = False
        Me.DataColumn46.ColumnName = "cia_serial"
        Me.DataColumn46.DataType = GetType(System.Int32)
        '
        'DataColumn47
        '
        Me.DataColumn47.AllowDBNull = False
        Me.DataColumn47.ColumnName = "plan_serial"
        Me.DataColumn47.DataType = GetType(System.Int32)
        '
        'DataColumn48
        '
        Me.DataColumn48.AllowDBNull = False
        Me.DataColumn48.ColumnName = "aseg_poliza"
        Me.DataColumn48.MaxLength = 20
        '
        'DataColumn49
        '
        Me.DataColumn49.AllowDBNull = False
        Me.DataColumn49.ColumnName = "aseg_nombre"
        Me.DataColumn49.MaxLength = 80
        '
        'DataColumn50
        '
        Me.DataColumn50.AllowDBNull = False
        Me.DataColumn50.ColumnName = "aseg_address"
        Me.DataColumn50.MaxLength = 120
        '
        'DataColumn51
        '
        Me.DataColumn51.AllowDBNull = False
        Me.DataColumn51.ColumnName = "aseg_phone"
        Me.DataColumn51.MaxLength = 13
        '
        'DataColumn52
        '
        Me.DataColumn52.AllowDBNull = False
        Me.DataColumn52.ColumnName = "aseg_cedula"
        Me.DataColumn52.MaxLength = 20
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "cust_code"
        Me.DataColumn53.DataType = GetType(System.Int32)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "aseg_status"
        Me.DataColumn54.DataType = GetType(System.Int32)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "city_code"
        Me.DataColumn55.MaxLength = 3
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "sector_code"
        Me.DataColumn56.MaxLength = 3
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "aseg_principal"
        Me.DataColumn57.DataType = GetType(System.Int32)
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "clini_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "aseg_apellidos"
        Me.DataColumn2.MaxLength = 40
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "aseg_limite"
        Me.DataColumn3.DataType = GetType(System.Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "balance"
        Me.DataColumn4.DataType = GetType(System.Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "aseg_balance"
        Me.DataColumn5.DataType = GetType(System.Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "bal_acumulado"
        Me.DataColumn6.DataType = GetType(System.Decimal)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.XTextBox5)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtLimite)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.XTextBox4)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.XTextBox3)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Lkl_clini_code)
        Me.GroupBox1.Controls.Add(Me.clini_name)
        Me.GroupBox1.Controls.Add(Me.lbl_Mensaje)
        Me.GroupBox1.Controls.Add(Me.xtxt_codigo)
        Me.GroupBox1.Controls.Add(Me.xtxt_plan)
        Me.GroupBox1.Controls.Add(Me.xtxt_Compania)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.xtxt_phone1)
        Me.GroupBox1.Controls.Add(Me.xtxt_sector)
        Me.GroupBox1.Controls.Add(Me.xtxt_ciudad)
        Me.GroupBox1.Controls.Add(Me.xtxt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.xtxt_address)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit1)
        Me.GroupBox1.Controls.Add(Me.xlk_codigo)
        Me.GroupBox1.Controls.Add(Me.lbl_Cobertura)
        Me.GroupBox1.Controls.Add(Me.xlk_plan)
        Me.GroupBox1.Controls.Add(Me.xlk_compania)
        Me.GroupBox1.Controls.Add(Me.lbl_Compania)
        Me.GroupBox1.Controls.Add(Me.lbl_Plan)
        Me.GroupBox1.Controls.Add(Me.xlk_sector)
        Me.GroupBox1.Controls.Add(Me.xlk_ciudad)
        Me.GroupBox1.Controls.Add(Me.lbl_ciudad)
        Me.GroupBox1.Controls.Add(Me.lbl_sector)
        Me.GroupBox1.Controls.Add(Me.lbl_Descuento)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 280)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'XTextBox5
        '
        Me.XTextBox5.AcceptsReturn = True
        Me.XTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.aseg_balance"))
        Me.XTextBox5.EditInitialValue = Nothing
        Me.XTextBox5.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox5.FieldDescription = ""
        Me.XTextBox5.FindInitialValue = Nothing
        Me.XTextBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.IgnoreRequiered = False
        Me.XTextBox5.Location = New System.Drawing.Point(462, 208)
        Me.XTextBox5.Name = "XTextBox5"
        Me.XTextBox5.NewInitialValue = Nothing
        Me.XTextBox5.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox5.Requiered = False
        Me.XTextBox5.Size = New System.Drawing.Size(104, 20)
        Me.XTextBox5.StatusBarPanelDescripcion = Nothing
        Me.XTextBox5.TabIndex = 24
        Me.XTextBox5.Text = ""
        Me.XTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label20.Location = New System.Drawing.Point(406, 210)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 16)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Balance:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtLimite
        '
        Me.txtLimite.AcceptsReturn = True
        Me.txtLimite.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.aseg_limite"))
        Me.txtLimite.EditInitialValue = Nothing
        Me.txtLimite.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtLimite.FieldDescription = ""
        Me.txtLimite.FindInitialValue = Nothing
        Me.txtLimite.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtLimite.IgnoreRequiered = False
        Me.txtLimite.Location = New System.Drawing.Point(272, 112)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.NewInitialValue = Nothing
        Me.txtLimite.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtLimite.Requiered = False
        Me.txtLimite.Size = New System.Drawing.Size(104, 20)
        Me.txtLimite.StatusBarPanelDescripcion = Nothing
        Me.txtLimite.TabIndex = 22
        Me.txtLimite.Text = ""
        Me.txtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label19.Location = New System.Drawing.Point(226, 113)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 16)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "L:imite:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox4
        '
        Me.XTextBox4.AcceptsReturn = True
        Me.XTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.aseg_apellidos"))
        Me.XTextBox4.EditInitialValue = Nothing
        Me.XTextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.FieldDescription = ""
        Me.XTextBox4.FindInitialValue = Nothing
        Me.XTextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.IgnoreRequiered = False
        Me.XTextBox4.Location = New System.Drawing.Point(368, 40)
        Me.XTextBox4.Name = "XTextBox4"
        Me.XTextBox4.NewInitialValue = Nothing
        Me.XTextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.Requiered = False
        Me.XTextBox4.Size = New System.Drawing.Size(200, 20)
        Me.XTextBox4.StatusBarPanelDescripcion = Nothing
        Me.XTextBox4.TabIndex = 3
        Me.XTextBox4.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label18.Location = New System.Drawing.Point(312, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 16)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Apellidos:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.clini_code"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(104, 232)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 10
        Me.XTextBox3.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Location = New System.Drawing.Point(48, 232)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 16)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "CLinica:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.Lkl_clini_code.FilterField = "clini_name"
        Me.Lkl_clini_code.IgnoreFindInBrowseMode = False
        Me.Lkl_clini_code.isCanceled = False
        Me.Lkl_clini_code.Location = New System.Drawing.Point(552, 232)
        Me.Lkl_clini_code.LookCaption = "Clinicas"
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
        Me.Lkl_clini_code.TabIndex = 19
        Me.Lkl_clini_code.TableName = "sclinicam"
        Me.Lkl_clini_code.TabStop = False
        Me.Lkl_clini_code.UseCopyConnection = False
        Me.Lkl_clini_code.UseRowRetrieveEvents = False
        Me.Lkl_clini_code.UseTab = False
        Me.Lkl_clini_code.VisParameters = New String() {"Codigo=clini_code", "Sector=clini_name"}
        Me.Lkl_clini_code.WhereCondition = Nothing
        Me.Lkl_clini_code.WhereParameters = Nothing
        '
        'clini_name
        '
        Me.clini_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.clini_name.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.clini_name.Location = New System.Drawing.Point(168, 232)
        Me.clini_name.Name = "clini_name"
        Me.clini_name.Size = New System.Drawing.Size(384, 20)
        Me.clini_name.TabIndex = 18
        '
        'lbl_Mensaje
        '
        Me.lbl_Mensaje.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_Mensaje.Location = New System.Drawing.Point(3, 261)
        Me.lbl_Mensaje.Name = "lbl_Mensaje"
        Me.lbl_Mensaje.Size = New System.Drawing.Size(570, 16)
        Me.lbl_Mensaje.TabIndex = 15
        Me.lbl_Mensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'xtxt_codigo
        '
        Me.xtxt_codigo.AcceptsReturn = True
        Me.xtxt_codigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.aseg_poliza"))
        Me.xtxt_codigo.EditInitialValue = Nothing
        Me.xtxt_codigo.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_codigo.FieldDescription = ""
        Me.xtxt_codigo.FindInitialValue = Nothing
        Me.xtxt_codigo.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_codigo.IgnoreRequiered = False
        Me.xtxt_codigo.Location = New System.Drawing.Point(104, 16)
        Me.xtxt_codigo.Masked = MaskedTextBox.Mask.None
        Me.xtxt_codigo.Name = "xtxt_codigo"
        Me.xtxt_codigo.NewInitialValue = Nothing
        Me.xtxt_codigo.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_codigo.Requiered = False
        Me.xtxt_codigo.StatusBarPanelDescripcion = Nothing
        Me.xtxt_codigo.TabIndex = 0
        Me.xtxt_codigo.Text = ""
        '
        'xtxt_plan
        '
        Me.xtxt_plan.AcceptsReturn = True
        Me.xtxt_plan.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.plan_serial"))
        Me.xtxt_plan.EditInitialValue = Nothing
        Me.xtxt_plan.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_plan.FieldDescription = ""
        Me.xtxt_plan.FindInitialValue = Nothing
        Me.xtxt_plan.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_plan.IgnoreRequiered = False
        Me.xtxt_plan.Location = New System.Drawing.Point(104, 88)
        Me.xtxt_plan.Name = "xtxt_plan"
        Me.xtxt_plan.NewInitialValue = Nothing
        Me.xtxt_plan.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_plan.Requiered = False
        Me.xtxt_plan.StatusBarPanelDescripcion = Nothing
        Me.xtxt_plan.TabIndex = 5
        Me.xtxt_plan.Text = ""
        Me.ToolTip1.SetToolTip(Me.xtxt_plan, "Para cambiar debe Aceptar y editar de nuevo")
        '
        'xtxt_Compania
        '
        Me.xtxt_Compania.AcceptsReturn = True
        Me.xtxt_Compania.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.cia_serial"))
        Me.xtxt_Compania.EditInitialValue = Nothing
        Me.xtxt_Compania.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Compania.FieldDescription = ""
        Me.xtxt_Compania.FindInitialValue = Nothing
        Me.xtxt_Compania.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Compania.IgnoreRequiered = False
        Me.xtxt_Compania.Location = New System.Drawing.Point(104, 64)
        Me.xtxt_Compania.Name = "xtxt_Compania"
        Me.xtxt_Compania.NewInitialValue = Nothing
        Me.xtxt_Compania.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Compania.Requiered = False
        Me.xtxt_Compania.StatusBarPanelDescripcion = Nothing
        Me.xtxt_Compania.TabIndex = 4
        Me.xtxt_Compania.Text = ""
        Me.ToolTip1.SetToolTip(Me.xtxt_Compania, "Para cambiar debe Aceptar y editar de nuevo")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(381, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "% Descuento:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(19, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 16)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "% Cobertura:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_phone1
        '
        Me.xtxt_phone1.AcceptsReturn = True
        Me.xtxt_phone1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.aseg_phone"))
        Me.xtxt_phone1.EditInitialValue = Nothing
        Me.xtxt_phone1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_phone1.FieldDescription = ""
        Me.xtxt_phone1.FindInitialValue = Nothing
        Me.xtxt_phone1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_phone1.IgnoreRequiered = False
        Me.xtxt_phone1.Location = New System.Drawing.Point(104, 208)
        Me.xtxt_phone1.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.xtxt_phone1.Name = "xtxt_phone1"
        Me.xtxt_phone1.NewInitialValue = Nothing
        Me.xtxt_phone1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_phone1.Requiered = False
        Me.xtxt_phone1.Size = New System.Drawing.Size(152, 20)
        Me.xtxt_phone1.StatusBarPanelDescripcion = Nothing
        Me.xtxt_phone1.TabIndex = 9
        Me.xtxt_phone1.Text = ""
        '
        'xtxt_sector
        '
        Me.xtxt_sector.AcceptsReturn = True
        Me.xtxt_sector.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.sector_code"))
        Me.xtxt_sector.EditInitialValue = Nothing
        Me.xtxt_sector.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_sector.FieldDescription = ""
        Me.xtxt_sector.FindInitialValue = Nothing
        Me.xtxt_sector.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_sector.IgnoreRequiered = False
        Me.xtxt_sector.Location = New System.Drawing.Point(104, 184)
        Me.xtxt_sector.Name = "xtxt_sector"
        Me.xtxt_sector.NewInitialValue = Nothing
        Me.xtxt_sector.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_sector.Requiered = False
        Me.xtxt_sector.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_sector.StatusBarPanelDescripcion = Nothing
        Me.xtxt_sector.TabIndex = 8
        Me.xtxt_sector.Text = ""
        '
        'xtxt_ciudad
        '
        Me.xtxt_ciudad.AcceptsReturn = True
        Me.xtxt_ciudad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.city_code"))
        Me.xtxt_ciudad.EditInitialValue = Nothing
        Me.xtxt_ciudad.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_ciudad.FieldDescription = ""
        Me.xtxt_ciudad.FindInitialValue = Nothing
        Me.xtxt_ciudad.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_ciudad.IgnoreRequiered = False
        Me.xtxt_ciudad.Location = New System.Drawing.Point(104, 160)
        Me.xtxt_ciudad.Name = "xtxt_ciudad"
        Me.xtxt_ciudad.NewInitialValue = Nothing
        Me.xtxt_ciudad.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_ciudad.Requiered = False
        Me.xtxt_ciudad.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_ciudad.StatusBarPanelDescripcion = Nothing
        Me.xtxt_ciudad.TabIndex = 7
        Me.xtxt_ciudad.Text = ""
        '
        'xtxt_nombre
        '
        Me.xtxt_nombre.AcceptsReturn = True
        Me.xtxt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.aseg_nombre"))
        Me.xtxt_nombre.EditInitialValue = Nothing
        Me.xtxt_nombre.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_nombre.FieldDescription = ""
        Me.xtxt_nombre.FindInitialValue = Nothing
        Me.xtxt_nombre.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_nombre.IgnoreRequiered = False
        Me.xtxt_nombre.Location = New System.Drawing.Point(104, 40)
        Me.xtxt_nombre.Name = "xtxt_nombre"
        Me.xtxt_nombre.NewInitialValue = Nothing
        Me.xtxt_nombre.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_nombre.Requiered = False
        Me.xtxt_nombre.Size = New System.Drawing.Size(200, 20)
        Me.xtxt_nombre.StatusBarPanelDescripcion = Nothing
        Me.xtxt_nombre.TabIndex = 2
        Me.xtxt_nombre.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(39, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Telefono:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(42, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(35, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Dirección:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(47, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ciudad:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(50, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Sector:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(16, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "NSS o Poliza:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_address
        '
        Me.xtxt_address.AcceptsReturn = True
        Me.xtxt_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.aseg_address"))
        Me.xtxt_address.EditInitialValue = Nothing
        Me.xtxt_address.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_address.FieldDescription = ""
        Me.xtxt_address.FindInitialValue = Nothing
        Me.xtxt_address.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_address.IgnoreRequiered = False
        Me.xtxt_address.Location = New System.Drawing.Point(104, 136)
        Me.xtxt_address.Name = "xtxt_address"
        Me.xtxt_address.NewInitialValue = Nothing
        Me.xtxt_address.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_address.Requiered = False
        Me.xtxt_address.Size = New System.Drawing.Size(464, 20)
        Me.xtxt_address.StatusBarPanelDescripcion = Nothing
        Me.xtxt_address.TabIndex = 6
        Me.xtxt_address.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(60, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Plan:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(5, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Compañia ARS:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(392, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Cedula No.:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XMaskEdit1
        '
        Me.XMaskEdit1.AcceptsReturn = True
        Me.XMaskEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgasegm.aseg_cedula"))
        Me.XMaskEdit1.EditInitialValue = Nothing
        Me.XMaskEdit1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.FieldDescription = ""
        Me.XMaskEdit1.FindInitialValue = Nothing
        Me.XMaskEdit1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.IgnoreRequiered = False
        Me.XMaskEdit1.Location = New System.Drawing.Point(464, 16)
        Me.XMaskEdit1.Masked = MaskedTextBox.Mask.None
        Me.XMaskEdit1.Name = "XMaskEdit1"
        Me.XMaskEdit1.NewInitialValue = Nothing
        Me.XMaskEdit1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.Requiered = False
        Me.XMaskEdit1.Size = New System.Drawing.Size(104, 20)
        Me.XMaskEdit1.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit1.TabIndex = 1
        Me.XMaskEdit1.Text = ""
        '
        'xlk_codigo
        '
        Me.xlk_codigo.AlternateFieldSearch = Nothing
        Me.xlk_codigo.BeginCheck = False
        Me.xlk_codigo.CheckText = Nothing
        Me.xlk_codigo.ComboMode = False
        Me.xlk_codigo.DataMember = ""
        Me.xlk_codigo.DataSource = Me.LibXConnector1
        Me.xlk_codigo.DestParameters = New String() {"aseg_poliza=aseg_poliza", "aseg_nombre=aseg_nombre", "aseg_apellidos=aseg_apellidos", "aseg_address=aseg_address", "city_code=city_code", "sector_code=sector_code", "plan_serial=plan_serial", "cia_serial=cia_serial", "aseg_cedula=aseg_cedula", "aseg_phone=aseg_phone", "aseg_serial=aseg_serial", "aseg_limite=aseg_limite", "aseg_balance=aseg_balance"}
        Me.xlk_codigo.FilterField = "aseg_nombre"
        Me.xlk_codigo.IgnoreFindInBrowseMode = True
        Me.xlk_codigo.isCanceled = False
        Me.xlk_codigo.Location = New System.Drawing.Point(208, 16)
        Me.xlk_codigo.LookCaption = "Clientes Asegurados"
        Me.xlk_codigo.Name = "xlk_codigo"
        Me.xlk_codigo.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_codigo.ShowFilter = True
        Me.xlk_codigo.ShowMessageNotFound = False
        Me.xlk_codigo.ShowWarning = False
        Me.xlk_codigo.Size = New System.Drawing.Size(16, 20)
        Me.xlk_codigo.SizesColumns = New String() {"aseg_nombre=450"}
        Me.xlk_codigo.SizesColumnsTab = Nothing
        Me.xlk_codigo.SqlString = New String() {"select * from sgasegm"}
        Me.xlk_codigo.SQLTab = Nothing
        Me.xlk_codigo.SrcParameters = New String() {"aseg_poliza=aseg_poliza"}
        Me.xlk_codigo.TabIndex = 9
        Me.xlk_codigo.TableName = "sgasegm"
        Me.xlk_codigo.TabStop = False
        Me.xlk_codigo.UseCopyConnection = False
        Me.xlk_codigo.UseRowRetrieveEvents = False
        Me.xlk_codigo.UseTab = False
        Me.xlk_codigo.VisParameters = New String() {"Poliza=aseg_Poliza", "Nombre=aseg_nombre", "Apellidos=aseg_apellidos", "Direccion=aseg_address"}
        Me.xlk_codigo.WhereCondition = Nothing
        Me.xlk_codigo.WhereParameters = Nothing
        '
        'lbl_Cobertura
        '
        Me.lbl_Cobertura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Cobertura.Location = New System.Drawing.Point(104, 112)
        Me.lbl_Cobertura.Name = "lbl_Cobertura"
        Me.lbl_Cobertura.Size = New System.Drawing.Size(100, 20)
        Me.lbl_Cobertura.TabIndex = 10
        '
        'xlk_plan
        '
        Me.xlk_plan.AlternateFieldSearch = Nothing
        Me.xlk_plan.BeginCheck = False
        Me.xlk_plan.CheckText = Nothing
        Me.xlk_plan.ComboMode = False
        Me.xlk_plan.DataMember = Nothing
        Me.xlk_plan.DataSource = Me.LibXConnector1
        Me.xlk_plan.DestParameters = New String() {"plan_serial=plan_serial", "lbl_Plan=plan_name", "lbl_cobertura=plan_cobertura", "lbl_descuento=plan_descto"}
        Me.xlk_plan.FilterField = "plan_name"
        Me.xlk_plan.IgnoreFindInBrowseMode = False
        Me.xlk_plan.isCanceled = False
        Me.xlk_plan.Location = New System.Drawing.Point(552, 88)
        Me.xlk_plan.LookCaption = "Planes"
        Me.xlk_plan.Name = "xlk_plan"
        Me.xlk_plan.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_plan.ShowFilter = True
        Me.xlk_plan.ShowMessageNotFound = True
        Me.xlk_plan.ShowWarning = False
        Me.xlk_plan.Size = New System.Drawing.Size(16, 20)
        Me.xlk_plan.SizesColumns = Nothing
        Me.xlk_plan.SizesColumnsTab = Nothing
        Me.xlk_plan.SqlString = Nothing
        Me.xlk_plan.SQLTab = Nothing
        Me.xlk_plan.SrcParameters = New String() {"plan_serial=plan_serial"}
        Me.xlk_plan.TabIndex = 9
        Me.xlk_plan.TableName = "sgplanm"
        Me.xlk_plan.TabStop = False
        Me.ToolTip1.SetToolTip(Me.xlk_plan, "Para cambiar debe Aceptar y editar de nuevo")
        Me.xlk_plan.UseCopyConnection = False
        Me.xlk_plan.UseRowRetrieveEvents = False
        Me.xlk_plan.UseTab = False
        Me.xlk_plan.VisParameters = New String() {"Plan=plan_serial", "Nombre=plan_name", "% Cobertura=plan_cobertura", "% Descuento=plan_descto"}
        Me.xlk_plan.WhereCondition = Nothing
        Me.xlk_plan.WhereParameters = Nothing
        '
        'xlk_compania
        '
        Me.xlk_compania.AlternateFieldSearch = Nothing
        Me.xlk_compania.BeginCheck = False
        Me.xlk_compania.CheckText = Nothing
        Me.xlk_compania.ComboMode = False
        Me.xlk_compania.DataMember = Nothing
        Me.xlk_compania.DataSource = Me.LibXConnector1
        Me.xlk_compania.DestParameters = New String() {"cia_serial=cia_serial", "lbl_Compania=cia_name"}
        Me.xlk_compania.FilterField = "cia_name"
        Me.xlk_compania.IgnoreFindInBrowseMode = False
        Me.xlk_compania.isCanceled = False
        Me.xlk_compania.Location = New System.Drawing.Point(552, 64)
        Me.xlk_compania.LookCaption = "Compañías"
        Me.xlk_compania.Name = "xlk_compania"
        Me.xlk_compania.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_compania.ShowFilter = True
        Me.xlk_compania.ShowMessageNotFound = True
        Me.xlk_compania.ShowWarning = False
        Me.xlk_compania.Size = New System.Drawing.Size(16, 20)
        Me.xlk_compania.SizesColumns = Nothing
        Me.xlk_compania.SizesColumnsTab = Nothing
        Me.xlk_compania.SqlString = New String() {Nothing}
        Me.xlk_compania.SQLTab = Nothing
        Me.xlk_compania.SrcParameters = New String() {"cia_serial=cia_serial"}
        Me.xlk_compania.TabIndex = 8
        Me.xlk_compania.TableName = "sgciasm"
        Me.xlk_compania.TabStop = False
        Me.ToolTip1.SetToolTip(Me.xlk_compania, "Para cambiar debe Aceptar y editar de nuevo")
        Me.xlk_compania.UseCopyConnection = False
        Me.xlk_compania.UseRowRetrieveEvents = False
        Me.xlk_compania.UseTab = False
        Me.xlk_compania.VisParameters = New String() {"Codigo=cia_serial", "Compania=cia_name", ""}
        Me.xlk_compania.WhereCondition = Nothing
        Me.xlk_compania.WhereParameters = Nothing
        '
        'lbl_Compania
        '
        Me.lbl_Compania.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Compania.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_Compania.Location = New System.Drawing.Point(208, 64)
        Me.lbl_Compania.Name = "lbl_Compania"
        Me.lbl_Compania.Size = New System.Drawing.Size(344, 20)
        Me.lbl_Compania.TabIndex = 7
        '
        'lbl_Plan
        '
        Me.lbl_Plan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Plan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_Plan.Location = New System.Drawing.Point(208, 88)
        Me.lbl_Plan.Name = "lbl_Plan"
        Me.lbl_Plan.Size = New System.Drawing.Size(344, 20)
        Me.lbl_Plan.TabIndex = 8
        '
        'xlk_sector
        '
        Me.xlk_sector.AlternateFieldSearch = Nothing
        Me.xlk_sector.BeginCheck = False
        Me.xlk_sector.CheckText = Nothing
        Me.xlk_sector.ComboMode = False
        Me.xlk_sector.DataMember = Nothing
        Me.xlk_sector.DataSource = Me.LibXConnector1
        Me.xlk_sector.DestParameters = New String() {"sector_code=sector_code", "lbl_sector=sector_name"}
        Me.xlk_sector.FilterField = "sector_name"
        Me.xlk_sector.IgnoreFindInBrowseMode = False
        Me.xlk_sector.isCanceled = False
        Me.xlk_sector.Location = New System.Drawing.Point(552, 184)
        Me.xlk_sector.LookCaption = "Sectores"
        Me.xlk_sector.Name = "xlk_sector"
        Me.xlk_sector.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_sector.ShowFilter = True
        Me.xlk_sector.ShowMessageNotFound = True
        Me.xlk_sector.ShowWarning = False
        Me.xlk_sector.Size = New System.Drawing.Size(16, 20)
        Me.xlk_sector.SizesColumns = Nothing
        Me.xlk_sector.SizesColumnsTab = Nothing
        Me.xlk_sector.SqlString = Nothing
        Me.xlk_sector.SQLTab = Nothing
        Me.xlk_sector.SrcParameters = New String() {"sector_code=sector_code"}
        Me.xlk_sector.TabIndex = 11
        Me.xlk_sector.TableName = "ccsectorm"
        Me.xlk_sector.TabStop = False
        Me.xlk_sector.UseCopyConnection = False
        Me.xlk_sector.UseRowRetrieveEvents = False
        Me.xlk_sector.UseTab = False
        Me.xlk_sector.VisParameters = New String() {"Codigo=sector_code", "Sector=sector_name"}
        Me.xlk_sector.WhereCondition = Nothing
        Me.xlk_sector.WhereParameters = Nothing
        '
        'xlk_ciudad
        '
        Me.xlk_ciudad.AlternateFieldSearch = Nothing
        Me.xlk_ciudad.BeginCheck = False
        Me.xlk_ciudad.CheckText = Nothing
        Me.xlk_ciudad.ComboMode = False
        Me.xlk_ciudad.DataMember = Nothing
        Me.xlk_ciudad.DataSource = Me.LibXConnector1
        Me.xlk_ciudad.DestParameters = New String() {"city_code=city_code", "lbl_Ciudad=city_name"}
        Me.xlk_ciudad.FilterField = "city_name"
        Me.xlk_ciudad.IgnoreFindInBrowseMode = False
        Me.xlk_ciudad.isCanceled = False
        Me.xlk_ciudad.Location = New System.Drawing.Point(552, 160)
        Me.xlk_ciudad.LookCaption = "Ciudad"
        Me.xlk_ciudad.Name = "xlk_ciudad"
        Me.xlk_ciudad.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_ciudad.ShowFilter = True
        Me.xlk_ciudad.ShowMessageNotFound = True
        Me.xlk_ciudad.ShowWarning = False
        Me.xlk_ciudad.Size = New System.Drawing.Size(16, 20)
        Me.xlk_ciudad.SizesColumns = Nothing
        Me.xlk_ciudad.SizesColumnsTab = Nothing
        Me.xlk_ciudad.SqlString = Nothing
        Me.xlk_ciudad.SQLTab = Nothing
        Me.xlk_ciudad.SrcParameters = New String() {"city_code=city_code"}
        Me.xlk_ciudad.TabIndex = 10
        Me.xlk_ciudad.TableName = "cccity"
        Me.xlk_ciudad.TabStop = False
        Me.xlk_ciudad.UseCopyConnection = False
        Me.xlk_ciudad.UseRowRetrieveEvents = False
        Me.xlk_ciudad.UseTab = False
        Me.xlk_ciudad.VisParameters = New String() {"Codigo=city_code", "Ciudad=city_name"}
        Me.xlk_ciudad.WhereCondition = Nothing
        Me.xlk_ciudad.WhereParameters = Nothing
        '
        'lbl_ciudad
        '
        Me.lbl_ciudad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ciudad.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_ciudad.Location = New System.Drawing.Point(168, 160)
        Me.lbl_ciudad.Name = "lbl_ciudad"
        Me.lbl_ciudad.Size = New System.Drawing.Size(384, 20)
        Me.lbl_ciudad.TabIndex = 8
        '
        'lbl_sector
        '
        Me.lbl_sector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_sector.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_sector.Location = New System.Drawing.Point(168, 184)
        Me.lbl_sector.Name = "lbl_sector"
        Me.lbl_sector.Size = New System.Drawing.Size(384, 20)
        Me.lbl_sector.TabIndex = 8
        '
        'lbl_Descuento
        '
        Me.lbl_Descuento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Descuento.Location = New System.Drawing.Point(464, 112)
        Me.lbl_Descuento.Name = "lbl_Descuento"
        Me.lbl_Descuento.Size = New System.Drawing.Size(104, 20)
        Me.lbl_Descuento.TabIndex = 13
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.CausesValidation = False
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelar.Location = New System.Drawing.Point(512, 352)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 23)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancelar la operación y cerrar esta pantalla")
        '
        'LBL_Title
        '
        Me.LBL_Title.BackColor = System.Drawing.Color.White
        Me.LBL_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBL_Title.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LBL_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Title.ForeColor = System.Drawing.Color.Blue
        Me.LBL_Title.Location = New System.Drawing.Point(0, 0)
        Me.LBL_Title.Name = "LBL_Title"
        Me.LBL_Title.Size = New System.Drawing.Size(594, 32)
        Me.LBL_Title.TabIndex = 0
        Me.LBL_Title.Text = "CLIENTE ASEGURADO"
        Me.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAceptar.Location = New System.Drawing.Point(432, 352)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(72, 23)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "Aceptar(F5)"
        Me.ToolTip1.SetToolTip(Me.btnAceptar, "Terminar de procesar los datos del asegurado")
        '
        'xtxt_telefono1
        '
        Me.xtxt_telefono1.AcceptsReturn = True
        Me.xtxt_telefono1.EditInitialValue = Nothing
        Me.xtxt_telefono1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono1.FieldDescription = ""
        Me.xtxt_telefono1.FindInitialValue = Nothing
        Me.xtxt_telefono1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono1.IgnoreRequiered = False
        Me.xtxt_telefono1.Location = New System.Drawing.Point(0, 0)
        Me.xtxt_telefono1.Name = "xtxt_telefono1"
        Me.xtxt_telefono1.NewInitialValue = Nothing
        Me.xtxt_telefono1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono1.Requiered = False
        Me.xtxt_telefono1.StatusBarPanelDescripcion = Nothing
        Me.xtxt_telefono1.TabIndex = 0
        Me.xtxt_telefono1.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(0, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(594, 16)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "PARA REALIZAR CAMBIO DEBE ACEPTAR(F5) Y LUEGO EDITAR INFAMACIÓN DEL CLIENTE"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'i_ptvfact05
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(594, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.LBL_Title)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "i_ptvfact05"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes Asegurados"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sgasegm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If LibXConnector1.IsDataEditing = True Then
            LibXConnector1.Cancel()
        End If

        Me.Close()
    End Sub

    Private Sub i_ptvfact03_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mExiste = False
        If Not Me.xlk_ciudad Is Nothing Then
            Me.xlk_ciudad.ExecuteFind()
        End If

        If Not Me.xlk_sector Is Nothing Then
            Me.xlk_sector.ExecuteFind()
        End If

        If Not xlk_compania Is Nothing Then
            xlk_compania.ExecuteFind()
        End If

        If Not xlk_plan Is Nothing Then
            xlk_plan.ExecuteFind()
        End If
        If Not Lkl_clini_code Is Nothing Then
            Lkl_clini_code.ExecuteFind()
        End If
    End Sub

    Private Sub xlk_codigo_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_codigo.AfterSetValues
        Try
            mExiste = e.dataFound

            If e.dataFound = False Then
                Exit Sub
            End If

            SetValues(e.row)

            If mExiste = True Then
                xlk_ciudad.Enabled = False
            Else
                xlk_ciudad.Enabled = True
            End If

            If Not Me.xlk_ciudad Is Nothing Then
                Me.xlk_ciudad.ExecuteFind()
            End If

            If mExiste = True Then
                xlk_sector.Enabled = False
            Else
                xlk_sector.Enabled = True
            End If

            If Not Me.xlk_sector Is Nothing Then
                Me.xlk_sector.ExecuteFind()
            End If

            If mExiste = True Then
                xlk_compania.Enabled = False
                xtxt_Compania.Enabled = False
            Else
                xlk_compania.Enabled = True
                xtxt_Compania.Enabled = True
            End If

            If Not xlk_compania Is Nothing Then
                xlk_compania.ExecuteFind()
            End If

            If mExiste = True Then
                xlk_plan.Enabled = False
                xtxt_plan.Enabled = False
            Else
                xlk_plan.Enabled = True
                xtxt_plan.Enabled = True
            End If

            If Not xlk_plan Is Nothing Then
                xlk_plan.ExecuteFind()
            End If
            If Not Lkl_clini_code Is Nothing Then
                Lkl_clini_code.ExecuteFind()
            End If


        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues

        Me.xtxt_codigo.Focus()
    End Sub

    Private Sub xlk_codigo_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_codigo.BeforeSetValues
        Try
            mExiste = e.dataFound
            If LibXConnector1.IsDataEditing = True Then
                If mExiste = False And Me.xtxt_codigo.Text.Trim <> "" Then
                    lbl_Mensaje.Text = "Asegurado No existe!"
                    lbl_Mensaje.ForeColor = System.Drawing.Color.Red
                    e.handled = True
                End If
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            LibXConnector1.Accept()
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Public Overloads Function ShowDialog(ByVal pCliente As SGT.PuntodeVenta.Entidades.ClienteAsegurado) As DialogResult
        oCliente = pCliente

        Return MyBase.ShowDialog
    End Function

    Private Sub LibXConnector1_InsertedRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Or e.UpdatingArgs.StatementType = StatementType.Update Then
                If mExiste = False Then
                    SetValues(e.UpdatingArgs.Row)
                End If
                If ValidarPalnSeguro(e.UpdatingArgs.Row!plan_serial, e.UpdatingArgs.Row!cia_serial) = False Then
                    Me.xtxt_plan.Text = ""
                    Me.lbl_Plan.Text = ""
                    Me.lbl_Cobertura.Text = ""
                    Throw New ApplicationException("Debe especificar un plan para esta aseguradora!")
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                If mExiste = True Then
                    e.UpdatingArgs.Status = UpdateStatus.SkipCurrentRow
                End If
                If ValidarPalnSeguro(e.UpdatingArgs.Row!plan_serial, e.UpdatingArgs.Row!cia_serial) = False Then
                    Me.xtxt_plan.Text = ""
                    Me.lbl_Plan.Text = ""
                    Me.lbl_Cobertura.Text = ""
                    Throw New ApplicationException("Debe especificar un plan para esta aseguradora!")
                End If
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub SetValues(ByVal oRow As DataRow)
        With oCliente
            .Codigo = oRow!aseg_serial
            If Not LibX.IsNull(oRow!aseg_cedula) Then .Cedula = oRow!aseg_cedula.ToString.Trim
            If Not LibX.IsNull(oRow!city_code) Then .Ciudad = oRow!city_code
            If Not LibX.IsNull(oRow!cia_serial) Then .CompaniaID = oRow!cia_serial
            If Not LibX.IsNull(oRow!cust_code) Then .Credito = oRow!cust_code
            If Not LibX.IsNull(oRow!aseg_address) Then .Direccion = oRow!aseg_address.ToString.Trim
            .Estatus = 1
            If Not LibX.IsNull(oRow!aseg_nombre) Then .Nombre = oRow!aseg_nombre.ToString.Trim
            If Not LibX.IsNull(oRow!aseg_apellidos) Then .Apellidos = oRow!aseg_apellidos.ToString.Trim
            If Not LibX.IsNull(oRow!plan_serial) Then .PlanID = oRow!plan_serial
            If Not LibX.IsNull(oRow!aseg_poliza) Then .Poliza = oRow!aseg_poliza
            If Not LibX.IsNull(oRow!aseg_principal) Then .Principal = oRow!aseg_principal
            If Not LibX.IsNull(oRow!sector_code) Then .Sector = oRow!sector_code
            If Not LibX.IsNull(oRow!aseg_phone) Then .Telefono = oRow!aseg_phone
            If Not LibX.IsNull(oRow!clini_code) Then .Clinica = oRow!clini_code
            If Not LibX.IsNull(oRow!aseg_limite) Then .LimiteCredito = oRow!aseg_limite
            If Not LibX.IsNull(oRow!aseg_balance) Then .Balance = oRow!aseg_balance
            If Not LibX.IsNull(oRow!bal_acumulado) Then .Acumulado = oRow!bal_acumulado
        End With
    End Sub

    Private Sub xtxt_codigo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_codigo.Validating
        If Me.xtxt_codigo.Text.Trim = "" Then
            e.Cancel = True
        End If
    End Sub
    Private Sub xlk_plan_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_plan.BeforeExecuteQuery
        Try

            If LibXConnector1.IsDataEditing = True Then
                e.aditionalWhere = "cia_serial = " & Me.xtxt_Compania.Text
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub i_ptvfact05_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If LibXConnector1.IsDataEditing = True Then
                If e.KeyCode = Keys.F5 Then
                    btnAceptar_Click(sender, New EventArgs)
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub
    Private Function ValidarPalnSeguro(ByVal pPanSerial As Integer, ByVal pCiaSerial As Integer) As Boolean
        Dim sPlan As Integer
        Dim sSQlsel As String
        Try
            sSQlsel = "select plan_serial from sgplanm where plan_serial =" & pPanSerial & " and cia_serial = " & pCiaSerial

            sPlan = LibX.Data.Manager.GetScalar(sSQlsel)

            If sPlan = Nothing Or sPlan = 0 Then
                Return False
            End If
            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Function
End Class
