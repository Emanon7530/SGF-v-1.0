Imports LibX
Public Class r_cppaym01
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents prov_name As System.Windows.Forms.TextBox
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Fecha_Fin As LibX.LibxDateTimePicker
    Friend WithEvents Txtprov_code As System.Windows.Forms.TextBox
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
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents LblProv_code As LibX.LibXLookup
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
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
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.Fecha_Fin = New LibX.LibxDateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Txtprov_code = New System.Windows.Forms.TextBox
        Me.prov_name = New System.Windows.Forms.TextBox
        Me.LblProv_code = New LibX.LibXLookup
        Me.Label5 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
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
        Me.LibXConnector1.DataMember = "cpinvcem"
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"invce_serial"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn5}
        Me.DataTable1.TableName = "cpinvcem"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Fecha_Fin"
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "Prov_code"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Prov_type"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Balance"
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
        Me.LibXDbSourceTable1.TableName = "cpinvcem"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.AutoIncrement = True
        Me.DataColumn5.ColumnName = "invce_serial"
        Me.DataColumn5.DataType = GetType(System.Int32)
        Me.DataColumn5.ReadOnly = True
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "term_code"
        Me.DataColumn6.MaxLength = 5
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "type_code"
        Me.DataColumn7.MaxLength = 3
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "doc_no"
        Me.DataColumn8.MaxLength = 20
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "invce_desc"
        Me.DataColumn9.MaxLength = 60
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "doc_date"
        Me.DataColumn10.DataType = GetType(System.DateTime)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "disc_date"
        Me.DataColumn11.DataType = GetType(System.DateTime)
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "amount"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "disc_pct"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "due_date"
        Me.DataColumn14.DataType = GetType(System.DateTime)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "disc_amount"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "isc_amount"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "itbis"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "excento"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "impto"
        Me.DataColumn19.DataType = GetType(System.Decimal)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "invce_status"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "date_created"
        Me.DataColumn21.DataType = GetType(System.DateTime)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "userid"
        Me.DataColumn22.MaxLength = 20
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "invce_ncf"
        Me.DataColumn23.MaxLength = 20
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "dev_serial"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "entr_serial"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha corte:"
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
        'Fecha_Fin
        '
        Me.Fecha_Fin.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_Fin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cpinvcem.Fecha_Fin"))
        Me.Fecha_Fin.EditInitialValue = Nothing
        Me.Fecha_Fin.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Fin.FieldDescription = ""
        Me.Fecha_Fin.FindInitialValue = "Now"
        Me.Fecha_Fin.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha_Fin.IgnoreRequiered = False
        Me.Fecha_Fin.Location = New System.Drawing.Point(96, 56)
        Me.Fecha_Fin.Name = "Fecha_Fin"
        Me.Fecha_Fin.NewInitialValue = Nothing
        Me.Fecha_Fin.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Fin.Requiered = False
        Me.Fecha_Fin.Size = New System.Drawing.Size(88, 20)
        Me.Fecha_Fin.StatusBarPanelDescripcion = Nothing
        Me.Fecha_Fin.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(440, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 138)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(8, 83)
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
        Me.btnEjecutar.Location = New System.Drawing.Point(8, 13)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(72, 32)
        Me.btnEjecutar.TabIndex = 0
        Me.btnEjecutar.Text = "Ejecutar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(22, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Proveedor:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtprov_code
        '
        Me.Txtprov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.Prov_code"))
        Me.Txtprov_code.Location = New System.Drawing.Point(96, 88)
        Me.Txtprov_code.Name = "Txtprov_code"
        Me.Txtprov_code.Size = New System.Drawing.Size(64, 20)
        Me.Txtprov_code.TabIndex = 0
        Me.Txtprov_code.Text = ""
        '
        'prov_name
        '
        Me.prov_name.Location = New System.Drawing.Point(171, 88)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.ReadOnly = True
        Me.prov_name.Size = New System.Drawing.Size(240, 20)
        Me.prov_name.TabIndex = 2
        Me.prov_name.TabStop = False
        Me.prov_name.Text = ""
        '
        'LblProv_code
        '
        Me.LblProv_code.AlternateFieldSearch = Nothing
        Me.LblProv_code.BeginCheck = False
        Me.LblProv_code.CheckText = Nothing
        Me.LblProv_code.ComboMode = False
        Me.LblProv_code.DataMember = Nothing
        Me.LblProv_code.DataSource = Me.LibXConnector1
        Me.LblProv_code.DestParameters = New String() {"Txtprov_code=prov_code", "prov_name=prov_name"}
        Me.LblProv_code.FilterField = Nothing
        Me.LblProv_code.IgnoreFindInBrowseMode = True
        Me.LblProv_code.isCanceled = False
        Me.LblProv_code.Location = New System.Drawing.Point(416, 88)
        Me.LblProv_code.LookCaption = Nothing
        Me.LblProv_code.Name = "LblProv_code"
        Me.LblProv_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.LblProv_code.ShowFilter = True
        Me.LblProv_code.ShowMessageNotFound = True
        Me.LblProv_code.ShowWarning = False
        Me.LblProv_code.Size = New System.Drawing.Size(16, 20)
        Me.LblProv_code.SizesColumns = Nothing
        Me.LblProv_code.SizesColumnsTab = Nothing
        Me.LblProv_code.SqlString = Nothing
        Me.LblProv_code.SQLTab = Nothing
        Me.LblProv_code.SrcParameters = New String() {"Txtprov_code=prov_code"}
        Me.LblProv_code.TabIndex = 1
        Me.LblProv_code.TableName = "cpprovm"
        Me.LblProv_code.TabStop = False
        Me.LblProv_code.UseCopyConnection = False
        Me.LblProv_code.UseRowRetrieveEvents = False
        Me.LblProv_code.UseTab = False
        Me.LblProv_code.VisParameters = New String() {"Código=prov_code", "Nombre=prov_name"}
        Me.LblProv_code.WhereCondition = Nothing
        Me.LblProv_code.WhereParameters = Nothing
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
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "SALDO POR ANTIGUEDAD"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cpinvcem.Prov_type"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Location = New System.Drawing.Point(96, 120)
        Me.LibXCombo1.LookupKeyDisplayFields = "type_name"
        Me.LibXCombo1.LookupKeyField = "type_prov"
        Me.LibXCombo1.LookupTableName = "cptypep"
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(120, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(55, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tipo:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cpinvcem.Balance"))
        Me.TextBox1.Location = New System.Drawing.Point(96, 150)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(40, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Balance"
        '
        'r_cppaym01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(530, 192)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LibXCombo1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblProv_code)
        Me.Controls.Add(Me.prov_name)
        Me.Controls.Add(Me.Txtprov_code)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Fecha_Fin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "r_cppaym01"
        Me.Text = "Saldo por Antiguedad"
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
        Dim sProveedor As String
        Dim sTipo As String
        Dim sFechaHasta As String
        Dim sBala As String
        Dim sWhere As String

        Try

            e.DoFill = False

            Fecha_Fin.Refresh()

            If Not IsNull(Fecha_Fin.Value) Then
                sFechaHasta = CDate(Fecha_Fin.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(e.row!prov_code) Then
                sProveedor = e.row!prov_code.ToString
            End If
            If Not IsNull(e.row!prov_type) Then
                sTipo = e.row!prov_type.ToString
            End If

            If Not IsNull(e.row!balance) Then
                sBala = e.row!balance.ToString
            End If

            ''''sWhere = e.Where.Replace("Cliente1 =", "cust_code >=")
            ''''sWhere = sWhere.Replace("Cliente2 =", "cust_code <=")
            '''''sWhere = sWhere.Replace("FechaCorte =", "invce_date <=")

            AxCrystalReport1 = New ReportLib("CXP", "r_cpsaldo01.rpt")

            With AxCrystalReport1
                sWhere = " 1=1 "
             
                If Trim(sFechaHasta) <> "" Then
                    sWhere = String.Concat(sWhere, "and cpinvcem.doc_date<='", Trim(sFechaHasta), "'")
                End If

                If Trim(sProveedor) <> "" Then
                    sWhere = String.Concat(sWhere, " and cpprovm.prov_code = ", Trim(sProveedor))
                End If

                If Trim(sTipo) <> "" Then
                    sWhere = String.Concat(sWhere, " and cpprovm.prov_type = ", Trim(sTipo))
                End If

                If Trim(sBala) <> "" Then
                    sWhere = String.Concat(sWhere, " and cpprovm.balance  ", Trim(sBala))
                End If


                .ParameterFields(1) = String.Concat("Fecha_Fin;", Trim(sFechaHasta), ";TRUE")
                '.ParameterFields(2) = String.Concat("prov_code;", e.row!prov_code.ToString, ";TRUE")
                '.ParameterFields(3) = String.Concat("Proveedor2;", e.row!Proveedor2.ToString, ";TRUE")

                '// Recibir el SQL Query

                '// imprimir o no clientes con balance 0
                'If chk_clientes.Checked = True Then
                '    sWhere = "cpprovm.balance >= 0"
                'Else
                '    sWhere = "cpprovm.balance > 0"
                'End If

                '// Imprimir todos los documentos con o sin balance
                'If chk_documentos.Checked = False Then
                '    sWhere = "cpprovm.balance <> 0 "
                'End If

                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                .SQLQuery = SelecStmt

                '// Ejecutar el reporte
                '.WindowState = Crystal.WindowStateConstants.crptMaximized
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
        Me.Fecha_Fin.Value = LibX.Data.Manager.Connection.GetDate

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
