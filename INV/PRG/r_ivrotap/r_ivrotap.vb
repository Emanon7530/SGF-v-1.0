Imports LibX
Public Class r_ivrotap
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fecIni As LibX.LibxDateTimePicker
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents xtxtwhse_code As LibX.XTextBox
    Friend WithEvents lblwhse_name As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents xlk_prov_code As LibX.LibXLookup
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblprov_name As System.Windows.Forms.Label
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents XTextBox4 As LibX.XTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents XTextBox8 As LibX.XTextBox
    Friend WithEvents lblgroup_name As System.Windows.Forms.Label
    Friend WithEvents XTextBox5 As LibX.XTextBox
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents XTextBox6 As LibX.XTextBox
    Friend WithEvents XTextBox9 As LibX.XTextBox
    Friend WithEvents LibXLookup4 As LibX.LibXLookup
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents XTextBox10 As LibX.XTextBox
    Friend WithEvents XTextBox11 As LibX.XTextBox
    Friend WithEvents LibXLookup5 As LibX.LibXLookup
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Ssubgrupo As System.Windows.Forms.Label
    Friend WithEvents Smarca As System.Windows.Forms.Label
    Friend WithEvents Sproducto As System.Windows.Forms.Label
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Txtwh_code As LibX.XTextBox
    Friend WithEvents TxtProv_code As LibX.XTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtItem_name As LibX.XTextBox
    Friend WithEvents TxtPurch_cost As LibX.XTextBox
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
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
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.Label1 = New System.Windows.Forms.Label
        Me.fecIni = New LibX.LibxDateTimePicker
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.xtxtwhse_code = New LibX.XTextBox
        Me.lblwhse_name = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.xlk_prov_code = New LibX.LibXLookup
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblprov_name = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblgroup_name = New System.Windows.Forms.Label
        Me.XTextBox4 = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Txtwh_code = New LibX.XTextBox
        Me.TxtProv_code = New LibX.XTextBox
        Me.XTextBox8 = New LibX.XTextBox
        Me.XTextBox5 = New LibX.XTextBox
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.Label4 = New System.Windows.Forms.Label
        Me.Ssubgrupo = New System.Windows.Forms.Label
        Me.XTextBox6 = New LibX.XTextBox
        Me.XTextBox9 = New LibX.XTextBox
        Me.LibXLookup4 = New LibX.LibXLookup
        Me.Label9 = New System.Windows.Forms.Label
        Me.Smarca = New System.Windows.Forms.Label
        Me.XTextBox10 = New LibX.XTextBox
        Me.XTextBox11 = New LibX.XTextBox
        Me.LibXLookup5 = New LibX.LibXLookup
        Me.Label11 = New System.Windows.Forms.Label
        Me.Sproducto = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtItem_name = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtPurch_cost = New LibX.XTextBox
        Me.DataColumn5 = New System.Data.DataColumn
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
        Me.LibXConnector1.DataMember = "ivitemm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = True
        Me.LibXConnector1.HandledUpdates = True
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn5})
        Me.DataTable1.TableName = "ivitemm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "item_code"
        Me.DataColumn1.MaxLength = 15
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "item_name"
        Me.DataColumn2.MaxLength = 100
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "unit_code"
        Me.DataColumn3.MaxLength = 5
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "existencia"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "whse_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "loc_row"
        Me.DataColumn7.MaxLength = 20
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "loc_col"
        Me.DataColumn8.MaxLength = 20
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "datelast_sales"
        Me.DataColumn9.DataType = GetType(System.DateTime)
        '
        'DataColumn10
        '
        Me.DataColumn10.Caption = "eqty"
        Me.DataColumn10.ColumnName = "eqty"
        Me.DataColumn10.MaxLength = 10
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "group_code"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "brand_code"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "prov_code"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "prov_code1"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sgroup_code"
        Me.DataColumn15.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.Source = New String() {"select ivitemm.item_code,", "       ivitemm.item_name,", "       ivitemm.unit_code,", "       ivitemd.existencia,", "       ivitemd.purch_cost,", "       ivitemd.whse_code,", "       ivitemd.loc_row,", "       ivitemd.loc_col,", "       ivitemm.group_code,", "       ivitemm.brand_code,", "       ivitemm.prov_code,", "       ivitemm.prov_code,", "       ivitemm.sgroup_code,", "       ivitemd.datelast_sales", "    from ivitemm inner join ivitemd on", "         ivitemd.item_code = ivitemm.item_code", "   where ivitemm.item_status =1", " order by ivitemm.item_name"}
        Me.LibXDbSourceTable1.TableName = "ivitemm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(0, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha Venta:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fecIni
        '
        Me.fecIni.CustomFormat = "dd/MM/yyyy"
        Me.fecIni.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ivitemm.datelast_sales"))
        Me.fecIni.EditInitialValue = Nothing
        Me.fecIni.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecIni.FieldDescription = ""
        Me.fecIni.FindInitialValue = ""
        Me.fecIni.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecIni.IgnoreRequiered = False
        Me.fecIni.Location = New System.Drawing.Point(80, 64)
        Me.fecIni.Name = "fecIni"
        Me.fecIni.NewInitialValue = Nothing
        Me.fecIni.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecIni.Requiered = False
        Me.fecIni.Size = New System.Drawing.Size(88, 20)
        Me.fecIni.StatusBarPanelDescripcion = Nothing
        Me.fecIni.TabIndex = 0
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
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.Location = New System.Drawing.Point(500, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 120)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(8, 80)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Cerrar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLimpiar.Location = New System.Drawing.Point(8, 48)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(72, 32)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEjecutar.Location = New System.Drawing.Point(8, 14)
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
        Me.Label5.Size = New System.Drawing.Size(594, 48)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "LISTADO DE PRODUCTO PARA VERIFICAR ROTACION"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xtxtwhse_code
        '
        Me.xtxtwhse_code.AcceptsReturn = True
        Me.xtxtwhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.whse_code"))
        Me.xtxtwhse_code.EditInitialValue = Nothing
        Me.xtxtwhse_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtwhse_code.FieldDescription = ""
        Me.xtxtwhse_code.FindInitialValue = Nothing
        Me.xtxtwhse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtwhse_code.IgnoreRequiered = False
        Me.xtxtwhse_code.Location = New System.Drawing.Point(88, 88)
        Me.xtxtwhse_code.Name = "xtxtwhse_code"
        Me.xtxtwhse_code.NewInitialValue = Nothing
        Me.xtxtwhse_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtwhse_code.Requiered = False
        Me.xtxtwhse_code.Size = New System.Drawing.Size(48, 20)
        Me.xtxtwhse_code.StatusBarPanelDescripcion = Nothing
        Me.xtxtwhse_code.TabIndex = 16
        Me.xtxtwhse_code.Text = ""
        '
        'lblwhse_name
        '
        Me.lblwhse_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblwhse_name.Location = New System.Drawing.Point(144, 88)
        Me.lblwhse_name.Name = "lblwhse_name"
        Me.lblwhse_name.Size = New System.Drawing.Size(272, 20)
        Me.lblwhse_name.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(20, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Almacen:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"Txtwh_code=whse_code", "lblwhse_name=whse_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(416, 88)
        Me.LibXLookup1.LookCaption = "Almacenes"
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
        Me.LibXLookup1.SrcParameters = New String() {"Txtwh_code=whse_code"}
        Me.LibXLookup1.TabIndex = 2
        Me.LibXLookup1.TableName = "ivwhsem"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Almacen=whse_code", "Descripcion=whse_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'xlk_prov_code
        '
        Me.xlk_prov_code.AlternateFieldSearch = Nothing
        Me.xlk_prov_code.BeginCheck = False
        Me.xlk_prov_code.CheckText = Nothing
        Me.xlk_prov_code.ComboMode = False
        Me.xlk_prov_code.DataMember = Nothing
        Me.xlk_prov_code.DataSource = Me.LibXConnector1
        Me.xlk_prov_code.DestParameters = New String() {"TxtProv_code=prov_code", "lblprov_name=prov_name"}
        Me.xlk_prov_code.FilterField = "prov_name"
        Me.xlk_prov_code.IgnoreFindInBrowseMode = False
        Me.xlk_prov_code.isCanceled = False
        Me.xlk_prov_code.Location = New System.Drawing.Point(416, 112)
        Me.xlk_prov_code.LookCaption = "Suplidores"
        Me.xlk_prov_code.Name = "xlk_prov_code"
        Me.xlk_prov_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_prov_code.ShowFilter = True
        Me.xlk_prov_code.ShowMessageNotFound = True
        Me.xlk_prov_code.ShowWarning = False
        Me.xlk_prov_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_prov_code.SizesColumns = Nothing
        Me.xlk_prov_code.SizesColumnsTab = Nothing
        Me.xlk_prov_code.SqlString = Nothing
        Me.xlk_prov_code.SQLTab = Nothing
        Me.xlk_prov_code.SrcParameters = New String() {"TxtProv_code=prov_code"}
        Me.xlk_prov_code.TabIndex = 4
        Me.xlk_prov_code.TableName = "cpprovm"
        Me.xlk_prov_code.TabStop = False
        Me.xlk_prov_code.UseCopyConnection = False
        Me.xlk_prov_code.UseRowRetrieveEvents = False
        Me.xlk_prov_code.UseTab = False
        Me.xlk_prov_code.VisParameters = New String() {"Suplidor=prov_code", "Nombre=prov_name"}
        Me.xlk_prov_code.WhereCondition = Nothing
        Me.xlk_prov_code.WhereParameters = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(22, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Suplidor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblprov_name
        '
        Me.lblprov_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblprov_name.Location = New System.Drawing.Point(144, 112)
        Me.lblprov_name.Name = "lblprov_name"
        Me.lblprov_name.Size = New System.Drawing.Size(272, 20)
        Me.lblprov_name.TabIndex = 21
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(88, 112)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 20
        Me.XTextBox3.Text = ""
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"group_code=group_code", "lblgroup_name=group_name"}
        Me.LibXLookup2.FilterField = "group_name"
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(416, 136)
        Me.LibXLookup2.LookCaption = "Grupos"
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
        Me.LibXLookup2.SrcParameters = New String() {"group_code=group_code"}
        Me.LibXLookup2.TabIndex = 6
        Me.LibXLookup2.TableName = "ivgroupm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Grupor=group_code", "Nombre=group_name"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(32, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Grupo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblgroup_name
        '
        Me.lblgroup_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblgroup_name.Location = New System.Drawing.Point(144, 136)
        Me.lblgroup_name.Name = "lblgroup_name"
        Me.lblgroup_name.Size = New System.Drawing.Size(272, 20)
        Me.lblgroup_name.TabIndex = 25
        '
        'XTextBox4
        '
        Me.XTextBox4.AcceptsReturn = True
        Me.XTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.XTextBox4.EditInitialValue = Nothing
        Me.XTextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.FieldDescription = ""
        Me.XTextBox4.FindInitialValue = Nothing
        Me.XTextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.IgnoreRequiered = False
        Me.XTextBox4.Location = New System.Drawing.Point(88, 136)
        Me.XTextBox4.Name = "XTextBox4"
        Me.XTextBox4.NewInitialValue = Nothing
        Me.XTextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.Requiered = False
        Me.XTextBox4.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox4.StatusBarPanelDescripcion = Nothing
        Me.XTextBox4.TabIndex = 24
        Me.XTextBox4.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(71, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtwh_code
        '
        Me.Txtwh_code.AcceptsReturn = True
        Me.Txtwh_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.whse_code"))
        Me.Txtwh_code.EditInitialValue = Nothing
        Me.Txtwh_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Txtwh_code.FieldDescription = ""
        Me.Txtwh_code.FindInitialValue = Nothing
        Me.Txtwh_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Txtwh_code.IgnoreRequiered = False
        Me.Txtwh_code.Location = New System.Drawing.Point(80, 88)
        Me.Txtwh_code.Name = "Txtwh_code"
        Me.Txtwh_code.NewInitialValue = Nothing
        Me.Txtwh_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Txtwh_code.Requiered = False
        Me.Txtwh_code.Size = New System.Drawing.Size(56, 20)
        Me.Txtwh_code.StatusBarPanelDescripcion = Nothing
        Me.Txtwh_code.TabIndex = 1
        Me.Txtwh_code.Text = ""
        '
        'TxtProv_code
        '
        Me.TxtProv_code.AcceptsReturn = True
        Me.TxtProv_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.TxtProv_code.EditInitialValue = Nothing
        Me.TxtProv_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TxtProv_code.FieldDescription = ""
        Me.TxtProv_code.FindInitialValue = Nothing
        Me.TxtProv_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TxtProv_code.IgnoreRequiered = False
        Me.TxtProv_code.Location = New System.Drawing.Point(80, 112)
        Me.TxtProv_code.Name = "TxtProv_code"
        Me.TxtProv_code.NewInitialValue = Nothing
        Me.TxtProv_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TxtProv_code.Requiered = False
        Me.TxtProv_code.Size = New System.Drawing.Size(56, 20)
        Me.TxtProv_code.StatusBarPanelDescripcion = Nothing
        Me.TxtProv_code.TabIndex = 3
        Me.TxtProv_code.Text = ""
        '
        'XTextBox8
        '
        Me.XTextBox8.AcceptsReturn = True
        Me.XTextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.group_code"))
        Me.XTextBox8.EditInitialValue = Nothing
        Me.XTextBox8.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox8.FieldDescription = ""
        Me.XTextBox8.FindInitialValue = Nothing
        Me.XTextBox8.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox8.IgnoreRequiered = False
        Me.XTextBox8.Location = New System.Drawing.Point(80, 136)
        Me.XTextBox8.Name = "XTextBox8"
        Me.XTextBox8.NewInitialValue = Nothing
        Me.XTextBox8.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox8.Requiered = False
        Me.XTextBox8.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox8.StatusBarPanelDescripcion = Nothing
        Me.XTextBox8.TabIndex = 5
        Me.XTextBox8.Text = ""
        '
        'XTextBox5
        '
        Me.XTextBox5.AcceptsReturn = True
        Me.XTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.sgroup_code"))
        Me.XTextBox5.EditInitialValue = Nothing
        Me.XTextBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.FieldDescription = ""
        Me.XTextBox5.FindInitialValue = Nothing
        Me.XTextBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.IgnoreRequiered = False
        Me.XTextBox5.Location = New System.Drawing.Point(80, 160)
        Me.XTextBox5.Name = "XTextBox5"
        Me.XTextBox5.NewInitialValue = Nothing
        Me.XTextBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.Requiered = False
        Me.XTextBox5.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox5.StatusBarPanelDescripcion = Nothing
        Me.XTextBox5.TabIndex = 7
        Me.XTextBox5.Text = ""
        '
        'LibXLookup3
        '
        Me.LibXLookup3.AlternateFieldSearch = Nothing
        Me.LibXLookup3.BeginCheck = False
        Me.LibXLookup3.CheckText = Nothing
        Me.LibXLookup3.ComboMode = False
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Me.LibXConnector1
        Me.LibXLookup3.DestParameters = New String() {"sgroup_code=sgroup_code", "Ssubgrupo=sgroup_name"}
        Me.LibXLookup3.FilterField = "sgroup_name"
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.isCanceled = False
        Me.LibXLookup3.Location = New System.Drawing.Point(416, 160)
        Me.LibXLookup3.LookCaption = "Sub Grupos"
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
        Me.LibXLookup3.SrcParameters = New String() {"sgroup_code=sgroup_code"}
        Me.LibXLookup3.TabIndex = 8
        Me.LibXLookup3.TableName = "ivsgroupm"
        Me.LibXLookup3.TabStop = False
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.UseTab = False
        Me.LibXLookup3.VisParameters = New String() {"SubGrupo=sgroup_code", "Nombre=sgroup_name"}
        Me.LibXLookup3.WhereCondition = Nothing
        Me.LibXLookup3.WhereParameters = Nothing
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(12, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "SubGrupo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Ssubgrupo
        '
        Me.Ssubgrupo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Ssubgrupo.Location = New System.Drawing.Point(144, 160)
        Me.Ssubgrupo.Name = "Ssubgrupo"
        Me.Ssubgrupo.Size = New System.Drawing.Size(272, 20)
        Me.Ssubgrupo.TabIndex = 37
        '
        'XTextBox6
        '
        Me.XTextBox6.AcceptsReturn = True
        Me.XTextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.XTextBox6.EditInitialValue = Nothing
        Me.XTextBox6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.FieldDescription = ""
        Me.XTextBox6.FindInitialValue = Nothing
        Me.XTextBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.IgnoreRequiered = False
        Me.XTextBox6.Location = New System.Drawing.Point(88, 160)
        Me.XTextBox6.Name = "XTextBox6"
        Me.XTextBox6.NewInitialValue = Nothing
        Me.XTextBox6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.Requiered = False
        Me.XTextBox6.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox6.StatusBarPanelDescripcion = Nothing
        Me.XTextBox6.TabIndex = 36
        Me.XTextBox6.Text = ""
        '
        'XTextBox9
        '
        Me.XTextBox9.AcceptsReturn = True
        Me.XTextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.brand_code"))
        Me.XTextBox9.EditInitialValue = Nothing
        Me.XTextBox9.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.FieldDescription = ""
        Me.XTextBox9.FindInitialValue = Nothing
        Me.XTextBox9.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.IgnoreRequiered = False
        Me.XTextBox9.Location = New System.Drawing.Point(80, 184)
        Me.XTextBox9.Name = "XTextBox9"
        Me.XTextBox9.NewInitialValue = Nothing
        Me.XTextBox9.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.Requiered = False
        Me.XTextBox9.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox9.StatusBarPanelDescripcion = Nothing
        Me.XTextBox9.TabIndex = 9
        Me.XTextBox9.Text = ""
        '
        'LibXLookup4
        '
        Me.LibXLookup4.AlternateFieldSearch = Nothing
        Me.LibXLookup4.BeginCheck = False
        Me.LibXLookup4.CheckText = Nothing
        Me.LibXLookup4.ComboMode = False
        Me.LibXLookup4.DataMember = Nothing
        Me.LibXLookup4.DataSource = Me.LibXConnector1
        Me.LibXLookup4.DestParameters = New String() {"brand_code=brand_code", "smarca=brand_name"}
        Me.LibXLookup4.FilterField = "brand_name"
        Me.LibXLookup4.IgnoreFindInBrowseMode = False
        Me.LibXLookup4.isCanceled = False
        Me.LibXLookup4.Location = New System.Drawing.Point(416, 184)
        Me.LibXLookup4.LookCaption = "Marcas"
        Me.LibXLookup4.Name = "LibXLookup4"
        Me.LibXLookup4.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup4.ShowFilter = True
        Me.LibXLookup4.ShowMessageNotFound = True
        Me.LibXLookup4.ShowWarning = False
        Me.LibXLookup4.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup4.SizesColumns = Nothing
        Me.LibXLookup4.SizesColumnsTab = Nothing
        Me.LibXLookup4.SqlString = Nothing
        Me.LibXLookup4.SQLTab = Nothing
        Me.LibXLookup4.SrcParameters = New String() {"brand_code=brand_code"}
        Me.LibXLookup4.TabIndex = 10
        Me.LibXLookup4.TableName = "ivbrandm"
        Me.LibXLookup4.TabStop = False
        Me.LibXLookup4.UseCopyConnection = False
        Me.LibXLookup4.UseRowRetrieveEvents = False
        Me.LibXLookup4.UseTab = False
        Me.LibXLookup4.VisParameters = New String() {"Codigo=brand_code", "Nombre=brand_name"}
        Me.LibXLookup4.WhereCondition = Nothing
        Me.LibXLookup4.WhereParameters = Nothing
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(31, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Marca:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Smarca
        '
        Me.Smarca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Smarca.Location = New System.Drawing.Point(144, 184)
        Me.Smarca.Name = "Smarca"
        Me.Smarca.Size = New System.Drawing.Size(272, 20)
        Me.Smarca.TabIndex = 42
        '
        'XTextBox10
        '
        Me.XTextBox10.AcceptsReturn = True
        Me.XTextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.XTextBox10.EditInitialValue = Nothing
        Me.XTextBox10.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox10.FieldDescription = ""
        Me.XTextBox10.FindInitialValue = Nothing
        Me.XTextBox10.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox10.IgnoreRequiered = False
        Me.XTextBox10.Location = New System.Drawing.Point(88, 184)
        Me.XTextBox10.Name = "XTextBox10"
        Me.XTextBox10.NewInitialValue = Nothing
        Me.XTextBox10.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox10.Requiered = False
        Me.XTextBox10.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox10.StatusBarPanelDescripcion = Nothing
        Me.XTextBox10.TabIndex = 41
        Me.XTextBox10.Text = ""
        '
        'XTextBox11
        '
        Me.XTextBox11.AcceptsReturn = True
        Me.XTextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.item_code"))
        Me.XTextBox11.EditInitialValue = Nothing
        Me.XTextBox11.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox11.FieldDescription = ""
        Me.XTextBox11.FindInitialValue = Nothing
        Me.XTextBox11.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox11.IgnoreRequiered = False
        Me.XTextBox11.Location = New System.Drawing.Point(80, 208)
        Me.XTextBox11.Name = "XTextBox11"
        Me.XTextBox11.NewInitialValue = Nothing
        Me.XTextBox11.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox11.Requiered = False
        Me.XTextBox11.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox11.StatusBarPanelDescripcion = Nothing
        Me.XTextBox11.TabIndex = 11
        Me.XTextBox11.Text = ""
        '
        'LibXLookup5
        '
        Me.LibXLookup5.AlternateFieldSearch = Nothing
        Me.LibXLookup5.BeginCheck = False
        Me.LibXLookup5.CheckText = Nothing
        Me.LibXLookup5.ComboMode = False
        Me.LibXLookup5.DataMember = Nothing
        Me.LibXLookup5.DataSource = Me.LibXConnector1
        Me.LibXLookup5.DestParameters = New String() {"item_code=item_code", "Sproducto=item_name"}
        Me.LibXLookup5.FilterField = "item_name"
        Me.LibXLookup5.IgnoreFindInBrowseMode = False
        Me.LibXLookup5.isCanceled = False
        Me.LibXLookup5.Location = New System.Drawing.Point(416, 208)
        Me.LibXLookup5.LookCaption = "Grupos"
        Me.LibXLookup5.Name = "LibXLookup5"
        Me.LibXLookup5.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup5.ShowFilter = True
        Me.LibXLookup5.ShowMessageNotFound = True
        Me.LibXLookup5.ShowWarning = False
        Me.LibXLookup5.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup5.SizesColumns = Nothing
        Me.LibXLookup5.SizesColumnsTab = Nothing
        Me.LibXLookup5.SqlString = Nothing
        Me.LibXLookup5.SQLTab = Nothing
        Me.LibXLookup5.SrcParameters = New String() {"item_code=item_code"}
        Me.LibXLookup5.TabIndex = 12
        Me.LibXLookup5.TableName = "ivitemm"
        Me.LibXLookup5.TabStop = False
        Me.LibXLookup5.UseCopyConnection = False
        Me.LibXLookup5.UseRowRetrieveEvents = False
        Me.LibXLookup5.UseTab = False
        Me.LibXLookup5.VisParameters = New String() {"COdigo=item_code", "Nombre=item_name"}
        Me.LibXLookup5.WhereCondition = Nothing
        Me.LibXLookup5.WhereParameters = Nothing
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Location = New System.Drawing.Point(18, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 16)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Producto:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Sproducto
        '
        Me.Sproducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Sproducto.Location = New System.Drawing.Point(144, 208)
        Me.Sproducto.Name = "Sproducto"
        Me.Sproducto.Size = New System.Drawing.Size(272, 20)
        Me.Sproducto.TabIndex = 46
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Location = New System.Drawing.Point(4, 233)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 16)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Descripción:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtItem_name
        '
        Me.TxtItem_name.AcceptsReturn = True
        Me.TxtItem_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtItem_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.item_name"))
        Me.TxtItem_name.EditInitialValue = Nothing
        Me.TxtItem_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TxtItem_name.FieldDescription = ""
        Me.TxtItem_name.FindInitialValue = Nothing
        Me.TxtItem_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TxtItem_name.IgnoreRequiered = False
        Me.TxtItem_name.Location = New System.Drawing.Point(80, 232)
        Me.TxtItem_name.Name = "TxtItem_name"
        Me.TxtItem_name.NewInitialValue = Nothing
        Me.TxtItem_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TxtItem_name.Requiered = False
        Me.TxtItem_name.Size = New System.Drawing.Size(352, 20)
        Me.TxtItem_name.StatusBarPanelDescripcion = Nothing
        Me.TxtItem_name.TabIndex = 13
        Me.TxtItem_name.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(12, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Existencia:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ivitemm.existencia"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = "1"
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Items.AddRange(New Object() {"1->0", "2-<0", "3-=0", "4-<=0"})
        Me.LibXCombo1.Location = New System.Drawing.Point(80, 279)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = Nothing
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(80, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Location = New System.Drawing.Point(34, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 16)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Costo:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPurch_cost
        '
        Me.TxtPurch_cost.AcceptsReturn = True
        Me.TxtPurch_cost.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPurch_cost.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.purch_cost"))
        Me.TxtPurch_cost.EditInitialValue = Nothing
        Me.TxtPurch_cost.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TxtPurch_cost.FieldDescription = ""
        Me.TxtPurch_cost.FindInitialValue = Nothing
        Me.TxtPurch_cost.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TxtPurch_cost.IgnoreRequiered = False
        Me.TxtPurch_cost.Location = New System.Drawing.Point(80, 256)
        Me.TxtPurch_cost.Name = "TxtPurch_cost"
        Me.TxtPurch_cost.NewInitialValue = Nothing
        Me.TxtPurch_cost.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TxtPurch_cost.Requiered = False
        Me.TxtPurch_cost.Size = New System.Drawing.Size(80, 20)
        Me.TxtPurch_cost.StatusBarPanelDescripcion = Nothing
        Me.TxtPurch_cost.TabIndex = 55
        Me.TxtPurch_cost.Text = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "purch_cost"
        Me.DataColumn5.MaxLength = 0
        '
        'r_ivrotap
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(594, 320)
        Me.Controls.Add(Me.TxtPurch_cost)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LibXCombo1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtItem_name)
        Me.Controls.Add(Me.XTextBox11)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.XTextBox9)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.XTextBox10)
        Me.Controls.Add(Me.XTextBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.XTextBox6)
        Me.Controls.Add(Me.XTextBox8)
        Me.Controls.Add(Me.TxtProv_code)
        Me.Controls.Add(Me.Txtwh_code)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.XTextBox4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.XTextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.xtxtwhse_code)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LibXLookup5)
        Me.Controls.Add(Me.Sproducto)
        Me.Controls.Add(Me.LibXLookup4)
        Me.Controls.Add(Me.Smarca)
        Me.Controls.Add(Me.LibXLookup3)
        Me.Controls.Add(Me.Ssubgrupo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LibXLookup2)
        Me.Controls.Add(Me.lblgroup_name)
        Me.Controls.Add(Me.xlk_prov_code)
        Me.Controls.Add(Me.lblprov_name)
        Me.Controls.Add(Me.LibXLookup1)
        Me.Controls.Add(Me.lblwhse_name)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fecIni)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "r_ivrotap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Productos para verificar rotacion"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            Dim SelecStmt As String
            Dim sFechaDesde As String
            Dim sFechaHasta As String
            Dim sCond As String
            Dim sWhere As String
            Dim sWh As String
            Dim sProv As String
            Dim sGroup As String
            Dim sSgroup As String
            Dim sMarca As String
            Dim sProducto As String
            Dim sDescripcion As String
            Dim sCosto As String
            Dim sQty As String
            Dim AxCrystalReport1 As LibX.ReportLib
          

            e.DoFill = False

            If Not IsNull(e.row!datelast_sales) Then
                sFechaDesde = CDate(e.row!datelast_sales).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(e.row!whse_code) Then
                sWh = e.row!whse_code
            End If

            If Not IsNull(e.row!prov_code) Then
                sProv = e.row!prov_code
            End If

            If Not IsNull(e.row!group_code) Then
                sGroup = e.row!group_code
            End If

            If Not IsNull(e.row!sgroup_code) Then
                sSgroup = e.row!sgroup_code
            End If

            If Not IsNull(e.row!brand_code) Then
                sMarca = e.row!brand_code
            End If

            If Not IsNull(e.row!item_code) Then
                sProducto = e.row!item_code
            End If

            If Not IsNull(e.row!item_name) Then
                sDescripcion = e.row!item_name
            End If

            If Not IsNull(e.row!purch_cost) Then
                sCosto = e.row!purch_cost
            End If

            If Not IsNull(e.row!existencia) Then
                sQty = e.row!existencia
            End If

            AxCrystalReport1 = New LibX.ReportLib("INV", "r_ivrotap.rpt")

            With AxCrystalReport1
                sWhere = " 1=1 "

                If Trim(sFechaDesde) <> "" Then
                    sWhere = String.Concat(sWhere, " and (ivitemd.datelast_sales <  '", Trim(sFechaDesde), "'" & _
                    " or  ivitemd.datelast_sales is null)")
                End If

                If Trim(sWh) <> "" Then
                    sWhere = String.Concat(sWhere, " and ivitemd.whse_code = ", Trim(sWh))
                End If

                If Trim(sProv) <> "" Then
                    sWhere = String.Concat(sWhere, " and ivitemm.prov_code = ", Trim(sProv))
                End If

                If Trim(sGroup) <> "" Then
                    sWhere = String.Concat(sWhere, " and ivitemm.group_code = ", Trim(sGroup))
                End If

                If Trim(sSgroup) <> "" Then
                    sWhere = String.Concat(sWhere, " and ivitemm.sgroup_code = ", Trim(sSgroup))
                End If

                If Trim(sMarca) <> "" Then
                    sWhere = String.Concat(sWhere, " and ivitemm.brand_code = ", Trim(sMarca))
                End If

                If Trim(sProducto) <> "" Then
                    sWhere = String.Concat(sWhere, " and ivitemm.item_code = '", sProducto & "'")
                End If

                If Trim(sDescripcion) <> "" Then
                    sWhere = String.Concat(sWhere, " and ivitemm.item_name like '", sDescripcion & "%'")
                End If

                If Trim(sCosto) <> "" Then
                    sWhere = String.Concat(sWhere, " and ivitemd.purch_cost  ", Trim(sCosto))
                End If

                If Trim(sQty) <> "" Then
                    If Trim(sQty) = 1 Then
                        sWhere = String.Concat(sWhere, " and ivitemd.existencia >0 ")
                    End If
                    If Trim(sQty) = 2 Then
                        sWhere = String.Concat(sWhere, " and ivitemd.existencia <0 ")
                    End If
                    If Trim(sQty) = 3 Then
                        sWhere = String.Concat(sWhere, " and ivitemd.existencia =0 ")
                    End If
                    If Trim(sQty) = 4 Then
                        sWhere = String.Concat(sWhere, " and ivitemd.existencia <=0 ")
                    End If
                End If
                '// Recibir el SQL Query
                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                .SQLQuery = SelecStmt

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
