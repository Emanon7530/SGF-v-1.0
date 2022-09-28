Imports LibX
Public Class r_pvnc01
    Inherits System.Windows.Forms.Form
    Dim WhDefault As Integer
    Dim oDoc As SGT.Facturacion.Entidades.Documento
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Fecha_Fin As LibX.LibxDateTimePicker
    Friend WithEvents Fecha_Ini As LibX.LibxDateTimePicker
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents LibXLookup4 As LibX.LibXLookup
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents LibXLookup5 As LibX.LibXLookup
    Friend WithEvents caja_name As System.Windows.Forms.Label
    Friend WithEvents cajera_name As System.Windows.Forms.Label
    Friend WithEvents Chk_resumen As System.Windows.Forms.CheckBox
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
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtBalance As System.Windows.Forms.Label
    Friend WithEvents TxtBalace As System.Windows.Forms.TextBox
    Friend WithEvents DataTable1 As System.Data.DataTable
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
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
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Fecha_Fin = New LibX.LibxDateTimePicker
        Me.Fecha_Ini = New LibX.LibxDateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Chk_resumen = New System.Windows.Forms.CheckBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.LibXLookup4 = New LibX.LibXLookup
        Me.caja_name = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.LibXLookup5 = New LibX.LibXLookup
        Me.cajera_name = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtBalance = New System.Windows.Forms.Label
        Me.TxtBalace = New System.Windows.Forms.TextBox
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
        Me.LibXConnector1.DataMember = "cjncrm"
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
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ncr_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn6}
        Me.DataTable1.TableName = "cjncrm"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Fecha_Ini"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Fecha_Fin"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "caja_code"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "caje_code"
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "ncr_estatus"
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.AutoIncrement = True
        Me.DataColumn6.ColumnName = "ncr_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        Me.DataColumn6.ReadOnly = True
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "type_code"
        Me.DataColumn7.MaxLength = 3
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "ncr_number"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "ncr_date"
        Me.DataColumn9.DataType = GetType(System.DateTime)
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "ncr_amount"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "ncr_balance"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "ncr_ncf"
        Me.DataColumn12.MaxLength = 20
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "ftserial_no"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "bus_name"
        Me.DataColumn14.MaxLength = 60
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
        Me.LibXDbSourceTable1.TableName = "cjncrm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(9, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha inicial:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(16, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.GroupBox1.Location = New System.Drawing.Point(432, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 152)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(8, 104)
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
        Me.btnEjecutar.Location = New System.Drawing.Point(9, 16)
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
        Me.Label5.Size = New System.Drawing.Size(538, 48)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "RESUMEN DE NOTAS DE CREDITO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Fecha_Fin
        '
        Me.Fecha_Fin.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_Fin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjncrm.Fecha_Fin"))
        Me.Fecha_Fin.EditInitialValue = Nothing
        Me.Fecha_Fin.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Fin.FieldDescription = ""
        Me.Fecha_Fin.FindInitialValue = "Now"
        Me.Fecha_Fin.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha_Fin.IgnoreRequiered = False
        Me.Fecha_Fin.Location = New System.Drawing.Point(88, 88)
        Me.Fecha_Fin.Name = "Fecha_Fin"
        Me.Fecha_Fin.NewInitialValue = Nothing
        Me.Fecha_Fin.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Fin.Requiered = False
        Me.Fecha_Fin.Size = New System.Drawing.Size(128, 20)
        Me.Fecha_Fin.StatusBarPanelDescripcion = Nothing
        Me.Fecha_Fin.TabIndex = 1
        '
        'Fecha_Ini
        '
        Me.Fecha_Ini.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_Ini.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjncrm.Fecha_Ini"))
        Me.Fecha_Ini.EditInitialValue = Nothing
        Me.Fecha_Ini.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Ini.FieldDescription = ""
        Me.Fecha_Ini.FindInitialValue = "Now"
        Me.Fecha_Ini.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Ini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha_Ini.IgnoreRequiered = False
        Me.Fecha_Ini.Location = New System.Drawing.Point(88, 64)
        Me.Fecha_Ini.Name = "Fecha_Ini"
        Me.Fecha_Ini.NewInitialValue = Nothing
        Me.Fecha_Ini.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Ini.Requiered = False
        Me.Fecha_Ini.Size = New System.Drawing.Size(128, 20)
        Me.Fecha_Ini.StatusBarPanelDescripcion = Nothing
        Me.Fecha_Ini.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(45, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Caja.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(35, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Cajero.:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chk_resumen
        '
        Me.Chk_resumen.Checked = True
        Me.Chk_resumen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_resumen.Location = New System.Drawing.Point(272, 56)
        Me.Chk_resumen.Name = "Chk_resumen"
        Me.Chk_resumen.Size = New System.Drawing.Size(120, 24)
        Me.Chk_resumen.TabIndex = 39
        Me.Chk_resumen.Text = "Resumido "
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjncrm.caja_code"))
        Me.TextBox3.Location = New System.Drawing.Point(88, 112)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(56, 20)
        Me.TextBox3.TabIndex = 49
        Me.TextBox3.Text = ""
        '
        'LibXLookup4
        '
        Me.LibXLookup4.AlternateFieldSearch = Nothing
        Me.LibXLookup4.BeginCheck = False
        Me.LibXLookup4.CheckText = Nothing
        Me.LibXLookup4.ComboMode = False
        Me.LibXLookup4.DataMember = Nothing
        Me.LibXLookup4.DataSource = Me.LibXConnector1
        Me.LibXLookup4.DestParameters = New String() {"caja_code=caja_code", "caja_name=caja_name"}
        Me.LibXLookup4.FilterField = Nothing
        Me.LibXLookup4.IgnoreFindInBrowseMode = False
        Me.LibXLookup4.isCanceled = False
        Me.LibXLookup4.Location = New System.Drawing.Point(384, 112)
        Me.LibXLookup4.LookCaption = "Caja"
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
        Me.LibXLookup4.SrcParameters = New String() {"caja_code=caja_code"}
        Me.LibXLookup4.TabIndex = 47
        Me.LibXLookup4.TableName = "cjcajam"
        Me.LibXLookup4.TabStop = False
        Me.LibXLookup4.UseCopyConnection = False
        Me.LibXLookup4.UseRowRetrieveEvents = False
        Me.LibXLookup4.UseTab = False
        Me.LibXLookup4.VisParameters = New String() {"Código=caja_code", "Descripción=caja_name"}
        Me.LibXLookup4.WhereCondition = Nothing
        Me.LibXLookup4.WhereParameters = Nothing
        '
        'caja_name
        '
        Me.caja_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.caja_name.Location = New System.Drawing.Point(144, 112)
        Me.caja_name.Name = "caja_name"
        Me.caja_name.Size = New System.Drawing.Size(240, 20)
        Me.caja_name.TabIndex = 48
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjncrm.caje_code"))
        Me.TextBox4.Location = New System.Drawing.Point(88, 136)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(56, 20)
        Me.TextBox4.TabIndex = 52
        Me.TextBox4.Text = ""
        '
        'LibXLookup5
        '
        Me.LibXLookup5.AlternateFieldSearch = Nothing
        Me.LibXLookup5.BeginCheck = False
        Me.LibXLookup5.CheckText = Nothing
        Me.LibXLookup5.ComboMode = False
        Me.LibXLookup5.DataMember = Nothing
        Me.LibXLookup5.DataSource = Me.LibXConnector1
        Me.LibXLookup5.DestParameters = New String() {"caje_code=vend_code", "cajera_name=vend_name"}
        Me.LibXLookup5.FilterField = Nothing
        Me.LibXLookup5.IgnoreFindInBrowseMode = False
        Me.LibXLookup5.isCanceled = False
        Me.LibXLookup5.Location = New System.Drawing.Point(384, 136)
        Me.LibXLookup5.LookCaption = Nothing
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
        Me.LibXLookup5.SrcParameters = New String() {"caje_code=vend_code"}
        Me.LibXLookup5.TabIndex = 50
        Me.LibXLookup5.TableName = "ftvendm"
        Me.LibXLookup5.TabStop = False
        Me.LibXLookup5.UseCopyConnection = False
        Me.LibXLookup5.UseRowRetrieveEvents = False
        Me.LibXLookup5.UseTab = False
        Me.LibXLookup5.VisParameters = New String() {"Código=vend_code", "Descripción=vend_name"}
        Me.LibXLookup5.WhereCondition = "vend_cargo = 1"
        Me.LibXLookup5.WhereParameters = Nothing
        '
        'cajera_name
        '
        Me.cajera_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cajera_name.Location = New System.Drawing.Point(144, 136)
        Me.cajera_name.Name = "cajera_name"
        Me.cajera_name.Size = New System.Drawing.Size(240, 20)
        Me.cajera_name.TabIndex = 51
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cjncrm.ncr_estatus"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Items.AddRange(New Object() {"0-Saldado", "1-Pendiente"})
        Me.LibXCombo1.Location = New System.Drawing.Point(87, 160)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = Nothing
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(96, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Estatus.:"
        '
        'TxtBalance
        '
        Me.TxtBalance.AutoSize = True
        Me.TxtBalance.Location = New System.Drawing.Point(28, 184)
        Me.TxtBalance.Name = "TxtBalance"
        Me.TxtBalance.Size = New System.Drawing.Size(51, 16)
        Me.TxtBalance.TabIndex = 56
        Me.TxtBalance.Text = "Balance.:"
        '
        'TxtBalace
        '
        Me.TxtBalace.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjncrm.ncr_balance"))
        Me.TxtBalace.Location = New System.Drawing.Point(88, 184)
        Me.TxtBalace.Name = "TxtBalace"
        Me.TxtBalace.Size = New System.Drawing.Size(88, 20)
        Me.TxtBalace.TabIndex = 57
        Me.TxtBalace.Text = ""
        '
        'r_pvnc01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(538, 224)
        Me.Controls.Add(Me.TxtBalace)
        Me.Controls.Add(Me.TxtBalance)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LibXCombo1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LibXLookup5)
        Me.Controls.Add(Me.cajera_name)
        Me.Controls.Add(Me.LibXLookup4)
        Me.Controls.Add(Me.caja_name)
        Me.Controls.Add(Me.Chk_resumen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Fecha_Fin)
        Me.Controls.Add(Me.Fecha_Ini)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "r_pvnc01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen de Notas de Creditos"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim AxCrystalReport1 As LibX.ReportLib
        Try
            Dim SelecStmt As String
            Dim sFechaDesde As String
            Dim sFechaHasta As String
            Dim sCond As String
            Dim sStatus As String
            Dim sCaja As String
            Dim sCajero As String
            Dim sBala As String
            Dim sWhere As String

            If Not IsNull(Fecha_Ini.Value) Then
                sFechaDesde = CDate(Fecha_Ini.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(Fecha_Fin.Value) Then
                sFechaHasta = CDate(Fecha_Fin.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(e.row!caja_code) Then
                sCaja = e.row!caja_code.ToString
            End If
            If Not IsNull(e.row!caje_code) Then
                sCajero = e.row!caje_code.ToString
            End If

            If Not IsNull(e.row!ncr_balance) Then
                sBala = e.row!ncr_balance.ToString
            End If

            If Not IsNull(e.row!ncr_estatus) Then
                sStatus = e.row!ncr_estatus.ToString
            End If

            If Me.Chk_resumen.Checked = False Then
                AxCrystalReport1 = New ReportLib("PTV", "r_pvncd.rpt")
            Else
                AxCrystalReport1 = New ReportLib("PTV", "r_pvncr.rpt")
            End If

            With AxCrystalReport1
                sWhere = " 1=1 "
                If Me.Chk_resumen.Checked = True Then
                    If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                        sWhere = String.Concat(sWhere, " and cjncrm.ncr_date between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
                    ElseIf Trim(sFechaDesde) <> "" Then
                        sWhere = String.Concat(sWhere, " and cjncrm.ncr_date = '", Trim(sFechaDesde), "'")
                    ElseIf Trim(sFechaHasta) <> "" Then
                        sWhere = String.Concat(sWhere, " and cjncrm.ncr_date = '", Trim(sFechaHasta), "'")
                    End If

                    If e.row!caja_code.ToString.Trim <> "" Then
                        sWhere = String.Concat(sWhere, " and ftfactm.caja_code = '", e.row!caja_code.ToString & "'")
                    End If

                    If e.row!caje_code.ToString.Trim <> "" Then
                        sWhere = String.Concat(sWhere, " and ftfactm.caje_code = '", e.row!caje_code.ToString & "'")
                    End If

                    If Trim(sStatus) <> "" Then
                        sWhere = String.Concat(sWhere, " and cjncrm.ncr_estatus = ", Trim(sStatus))
                    End If

                    If Trim(sBala) <> "" Then
                        sWhere = String.Concat(sWhere, " and cjncrm.ncr_balance  ", Trim(sBala))
                    End If


                    'If Me.Chk_resumen.Checked = True Then
                    '    sWhere = String.Concat(sWhere, " and repventav.fact_inddomicilio = 1")
                    'End If

                Else
                    If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                        sWhere = String.Concat(sWhere, " and repncpvv.ncr_date between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
                    ElseIf Trim(sFechaDesde) <> "" Then
                        sWhere = String.Concat(sWhere, " and repncpvv.ncr_date = '", Trim(sFechaDesde), "'")
                    ElseIf Trim(sFechaHasta) <> "" Then
                        sWhere = String.Concat(sWhere, " and repncpvv.ncr_date = '", Trim(sFechaHasta), "'")
                    End If

                    'If e.row!whse_code.ToString.Trim <> "" Then
                    '    sWhere = String.Concat(sWhere, " and cjncrm.whse_code = ", e.row!whse_code.ToString)
                    'End If

                    'If e.row!type_code.ToString.Trim <> "" Then
                    '    sWhere = String.Concat(sWhere, " and cjncrm.type_code = '", e.row!type_code.ToString & "'")
                    'End If

                    If e.row!caja_code.ToString.Trim <> "" Then
                        sWhere = String.Concat(sWhere, " and repncpvv.caja_code = '", e.row!caja_code.ToString & "'")
                    End If

                    If e.row!caje_code.ToString.Trim <> "" Then
                        sWhere = String.Concat(sWhere, " and repncpvv.caje_code = '", e.row!caje_code.ToString & "'")
                    End If

                    If Trim(sStatus) <> "" Then
                        sWhere = String.Concat(sWhere, " and repncpvv.ncr_estatus = ", Trim(sStatus))
                    End If

                    If Trim(sBala) <> "" Then
                        sWhere = String.Concat(sWhere, " and repncpvv.ncr_balance   ", Trim(sBala))
                    End If



                    'If Me.Chk_domi.Checked = True Then
                    '    sWhere = String.Concat(sWhere, " and resventas.fact_inddomicilio = 1")
                    'End If

                End If

                .ParameterFields(0) = String.Concat("Fecha_Ini;", Trim(sFechaDesde), ";TRUE")
                .ParameterFields(1) = String.Concat("Fecha_Fin;", Trim(sFechaHasta), ";TRUE")

                '// Recibir el SQL Query
                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = LibX.MdlUtil.ReplaceWherePart(SelecStmt, sWhere)
                'SelecStmt = oDoc.PrepareSelectStmt(SelecStmt)

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
        oDoc = New SGT.Facturacion.Entidades.Documento

        WhDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxWhDefault")

    End Sub

    Private Sub Chk_efe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
