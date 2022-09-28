Imports LibX
Public Class r_ccpaym01
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
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents xlk_cust_code As LibX.LibXLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fecha_fin As LibX.LibxDateTimePicker
    Friend WithEvents Txtcust_name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents LibXCombo2 As LibX.LibXCombo
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents txtcust_code As System.Windows.Forms.TextBox
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents vend_name As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents ccantiguedad As System.Data.DataTable
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
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
        Me.ccantiguedad = New System.Data.DataTable
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.Label2 = New System.Windows.Forms.Label
        Me.fecha_fin = New LibX.LibxDateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcust_code = New System.Windows.Forms.TextBox
        Me.Txtcust_name = New System.Windows.Forms.TextBox
        Me.xlk_cust_code = New LibX.LibXLookup
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.LibXCombo2 = New LibX.LibXCombo
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.vend_name = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccantiguedad, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXConnector1.DataMember = "ccinvcem"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.ccantiguedad})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.DataTable1.TableName = "ccinvcem"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "cust_code"
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "csttype_code"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "cust_status"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "fecha_fin"
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "vend_code"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'ccantiguedad
        '
        Me.ccantiguedad.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13})
        Me.ccantiguedad.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"cust_code"}, True)})
        Me.ccantiguedad.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn6}
        Me.ccantiguedad.TableName = "ccantiguedad"
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "cust_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "balance"
        Me.DataColumn7.DataType = GetType(System.Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "per1"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "per2"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "per3"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "per4"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "per5"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "fecha"
        Me.DataColumn13.DataType = GetType(System.DateTime)
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
        Me.LibXDbSourceTable1.Source = New String() {"select ", "ccinvcem.cust_code,cccustm.csttype_code,cccustm.cust_status,cccustm.vend_code", "from cccustm inner join ccinvcem on ccinvcem.cust_code = ccinvcem.cust_code"}
        Me.LibXDbSourceTable1.TableName = "ccinvcem"
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
        Me.LibXDbSourceTable2.TableName = "ccantiguedad"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha corte:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'fecha_fin
        '
        Me.fecha_fin.CustomFormat = "dd/MM/yyyy"
        Me.fecha_fin.EditInitialValue = Nothing
        Me.fecha_fin.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecha_fin.FieldDescription = ""
        Me.fecha_fin.FindInitialValue = ""
        Me.fecha_fin.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha_fin.IgnoreRequiered = False
        Me.fecha_fin.Location = New System.Drawing.Point(88, 64)
        Me.fecha_fin.Name = "fecha_fin"
        Me.fecha_fin.NewInitialValue = ""
        Me.fecha_fin.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.fecha_fin.Requiered = False
        Me.fecha_fin.Size = New System.Drawing.Size(120, 20)
        Me.fecha_fin.StatusBarPanelDescripcion = Nothing
        Me.fecha_fin.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(528, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 162)
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
        Me.Label3.Location = New System.Drawing.Point(32, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cliente:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtcust_code
        '
        Me.txtcust_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.cust_code"))
        Me.txtcust_code.Location = New System.Drawing.Point(88, 88)
        Me.txtcust_code.Name = "txtcust_code"
        Me.txtcust_code.Size = New System.Drawing.Size(64, 20)
        Me.txtcust_code.TabIndex = 0
        Me.txtcust_code.Text = ""
        '
        'Txtcust_name
        '
        Me.Txtcust_name.Location = New System.Drawing.Point(160, 88)
        Me.Txtcust_name.Name = "Txtcust_name"
        Me.Txtcust_name.ReadOnly = True
        Me.Txtcust_name.Size = New System.Drawing.Size(344, 20)
        Me.Txtcust_name.TabIndex = 2
        Me.Txtcust_name.TabStop = False
        Me.Txtcust_name.Text = ""
        '
        'xlk_cust_code
        '
        Me.xlk_cust_code.AlternateFieldSearch = Nothing
        Me.xlk_cust_code.BeginCheck = False
        Me.xlk_cust_code.CheckText = Nothing
        Me.xlk_cust_code.ComboMode = False
        Me.xlk_cust_code.DataMember = Nothing
        Me.xlk_cust_code.DataSource = Me.LibXConnector1
        Me.xlk_cust_code.DestParameters = New String() {"cust_code=cust_code", "Txtcust_name=cust_name"}
        Me.xlk_cust_code.FilterField = Nothing
        Me.xlk_cust_code.IgnoreFindInBrowseMode = True
        Me.xlk_cust_code.isCanceled = False
        Me.xlk_cust_code.Location = New System.Drawing.Point(504, 88)
        Me.xlk_cust_code.LookCaption = Nothing
        Me.xlk_cust_code.Name = "xlk_cust_code"
        Me.xlk_cust_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_cust_code.ShowFilter = True
        Me.xlk_cust_code.ShowMessageNotFound = True
        Me.xlk_cust_code.ShowWarning = False
        Me.xlk_cust_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_cust_code.SizesColumns = Nothing
        Me.xlk_cust_code.SizesColumnsTab = Nothing
        Me.xlk_cust_code.SqlString = Nothing
        Me.xlk_cust_code.SQLTab = Nothing
        Me.xlk_cust_code.SrcParameters = New String() {"cust_code=cust_code"}
        Me.xlk_cust_code.TabIndex = 1
        Me.xlk_cust_code.TableName = "cccustm"
        Me.xlk_cust_code.TabStop = False
        Me.xlk_cust_code.UseCopyConnection = False
        Me.xlk_cust_code.UseRowRetrieveEvents = False
        Me.xlk_cust_code.UseTab = False
        Me.xlk_cust_code.VisParameters = New String() {"Código=cust_code", "Nombre=cust_name"}
        Me.xlk_cust_code.WhereCondition = Nothing
        Me.xlk_cust_code.WhereParameters = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(618, 48)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "SALDO POR ANTIGUEDAD"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(46, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tipo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(32, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Estado:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ccinvcem.csttype_code"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Location = New System.Drawing.Point(88, 136)
        Me.LibXCombo1.LookupKeyDisplayFields = "csttype_name"
        Me.LibXCombo1.LookupKeyField = "csttype_code"
        Me.LibXCombo1.LookupTableName = "cccsttpm"
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(121, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 10
        '
        'LibXCombo2
        '
        Me.LibXCombo2.AllowDefaultSort = True
        Me.LibXCombo2.bound = True
        Me.LibXCombo2.currValue = Nothing
        Me.LibXCombo2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ccinvcem.cust_status"))
        Me.LibXCombo2.DefaultWhereString = Nothing
        Me.LibXCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo2.EditInitialValue = Nothing
        Me.LibXCombo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.FieldDescription = ""
        Me.LibXCombo2.FindInitialValue = "1"
        Me.LibXCombo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.IgnoreRequiered = False
        Me.LibXCombo2.Items.AddRange(New Object() {"0-Inactivo", "1-Activo", "2-Suspendido"})
        Me.LibXCombo2.Location = New System.Drawing.Point(88, 160)
        Me.LibXCombo2.LookupKeyDisplayFields = Nothing
        Me.LibXCombo2.LookupKeyField = Nothing
        Me.LibXCombo2.LookupTableName = Nothing
        Me.LibXCombo2.Name = "LibXCombo2"
        Me.LibXCombo2.NewInitialValue = ""
        Me.LibXCombo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.Requiered = False
        Me.LibXCombo2.Required = False
        Me.LibXCombo2.Size = New System.Drawing.Size(121, 21)
        Me.LibXCombo2.SqlString = Nothing
        Me.LibXCombo2.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo2.TabIndex = 11
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"vend_code=vend_code", "vend_name=vend_name"}
        Me.LibXLookup1.FilterField = "vend_name"
        Me.LibXLookup1.IgnoreFindInBrowseMode = True
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(504, 112)
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
        Me.LibXLookup1.SrcParameters = New String() {"vend_code=vend_code"}
        Me.LibXLookup1.TabIndex = 13
        Me.LibXLookup1.TableName = "ftvendm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=vend_code", "Nombre=vend_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'vend_name
        '
        Me.vend_name.Location = New System.Drawing.Point(160, 112)
        Me.vend_name.Name = "vend_name"
        Me.vend_name.ReadOnly = True
        Me.vend_name.Size = New System.Drawing.Size(344, 20)
        Me.vend_name.TabIndex = 14
        Me.vend_name.TabStop = False
        Me.vend_name.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ccinvcem.vend_code"))
        Me.TextBox2.Location = New System.Drawing.Point(88, 112)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(64, 20)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(32, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Vendedor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'r_ccpaym01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(618, 216)
        Me.Controls.Add(Me.LibXLookup1)
        Me.Controls.Add(Me.vend_name)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LibXCombo2)
        Me.Controls.Add(Me.LibXCombo1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.xlk_cust_code)
        Me.Controls.Add(Me.Txtcust_name)
        Me.Controls.Add(Me.txtcust_code)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fecha_fin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "r_ccpaym01"
        Me.Text = "Saldo por Antiguedad"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccantiguedad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim AxCrystalReport1 As LibX.ReportLib
        Dim xSelect As LibX.Data.XSelecStmt
        Dim oEstado As DataTable
        Dim oTable As DataTable
        Dim oRowamount As DataRow
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim SelecStmt As String
        Dim scliente As String
        Dim sTipo As String
        Dim sStatus As String
        Dim sFechaHasta As String
        Dim sCond As String
        Dim vend As String
        Dim sWhere As String
        Dim per As Integer

        Try

            e.DoFill = False

            fecha_fin.Refresh()

            If Not IsNull(fecha_fin.Value) Then
                sFechaHasta = CDate(fecha_fin.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            Else
                fecha_fin.Value = Now
            End If

            If Not IsNull(e.row!cust_code) Then
                scliente = e.row!cust_code.ToString
            End If

            If Not IsNull(e.row!csttype_code) Then
                sTipo = e.row!csttype_code.ToString
            End If

            If Not IsNull(e.row!cust_status) Then
                sStatus = e.row!cust_status.ToString
            End If

            If Not IsNull(e.row!vend_code) Then
                vend = e.row!vend_code.ToString
            End If


            AxCrystalReport1 = New ReportLib("CXC", "r_ccsaldo01.rpt")

            With AxCrystalReport1
                sWhere = " 1=1 "

                'If Trim(sFechaHasta) <> "" Then
                '    sWhere = String.Concat(sWhere, "and ccopend.doc_date <='", Trim(sFechaHasta), "'")
                'End If

                If Trim(scliente) <> "" Then
                    sWhere = String.Concat(sWhere, " and cccustm.cust_code = ", Trim(scliente))
                End If

                If Trim(sTipo) <> "" Then
                    sWhere = String.Concat(sWhere, " and cccustm.csttype_code = ", Trim(sTipo))
                End If

                If Trim(sStatus) <> "" Then
                    sWhere = String.Concat(sWhere, " and cccustm.cust_status = ", Trim(sStatus))
                End If
                If Trim(vend) <> "" Then
                    sWhere = String.Concat(sWhere, " and cccustm.vend_code = ", Trim(vend))
                End If

                If sFechaHasta <> "" Then

                End If

                SelecStmt = "delete from ccantiguedad where 1=1 "
                oTable = LibX.Data.Manager.GetDataTable(SelecStmt)

                SelecStmt = "select cccustm.cust_code,cccustm.balance,0.00 per1,0.00 per2,0.00 per3,0.00 per4,0.00 per5,null fecha from cccustm where balance > 0"

                SelecStmt = SelecStmt & " order by cust_code "
                oEstado = LibX.Data.Manager.GetDataTable(SelecStmt)

                LibX.Data.Manager.Connection.BeginTransaction()
                For Each oRow1 As DataRow In oEstado.Rows
                    Dim aNt As DataRow = ccantiguedad.NewRow
                    aNt!cust_code = oRow1!cust_code
                    aNt!balance = oRow1!balance
                    per = 1
                    aNt!per1 = Balantiguegad(oRow1!cust_code.ToString, per, CDate(Me.fecha_fin.Value).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat))
                    per = 2
                    aNt!per2 = Balantiguegad(oRow1!cust_code.ToString, per, CDate(Me.fecha_fin.Value).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat))
                    per = 3
                    aNt!per3 = Balantiguegad(oRow1!cust_code.ToString, per, CDate(Me.fecha_fin.Value).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat))
                    per = 4
                    aNt!per4 = Balantiguegad(oRow1!cust_code.ToString, per, CDate(Me.fecha_fin.Value).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat))
                    per = 5
                    aNt!per5 = Balantiguegad(oRow1!cust_code.ToString, per, CDate(Me.fecha_fin.Value).ToString.Trim(LibX.Data.Manager.GetSaveDateFormat))
                    aNt!fecha = Now

                    If aNt!cust_code <> Nothing Then
                        ccantiguedad.Rows.Add(aNt)
                    End If
                Next

                LibX.Data.Manager.Save(ccantiguedad)
                LibX.Data.Manager.Connection.CommitTransaction()

                If ccantiguedad.Rows.Count = 0 Then
                    MessageBox.Show("Cliente no tiene Documento Pendiente", "Balance", MessageBoxButtons.OK)
                    Return
                End If


                .ParameterFields(1) = String.Concat("fecha_fin;", Trim(sFechaHasta), ";TRUE")
                '// Recibir el SQL Query
                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                'SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, "ccopend.balance <> 0")
                .SQLQuery = SelecStmt

                '// Ejecutar el reporte
                .Action = 1
            End With

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub
    Private Function Balantiguegad(ByVal custCode As Integer, ByVal pEr As Integer, ByVal feCha As Date) As Decimal
        Dim SelectStmt, cond As String
        Dim oSelect As LibX.Data.XSelecStmt
        Dim oTable As DataTable
        Dim oCcopend As DataRow
        Dim bal As Decimal
        Dim sFecha As String
        Dim pr, cnt As Integer

        Try
            If Not LibX.IsNull(feCha) Then
                sFecha = CDate(fecha_fin.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If
            oSelect = New LibX.Data.XSelecStmt("ccopend", String.Concat("select * from ccopend where balance > 0 and cust_code =", custCode))
            oCcopend = oSelect.GetDataRow

            pr = pEr
            cond = "1=1"
            If pr = 1 Then
                cond = String.Concat(cond, " and DateDiff(Day, doc_date,getdate()) < 31 ")
            End If
            If pr = 2 Then
                cond = String.Concat(cond, " and datediff(day,doc_date,getdate()) between 31 and 61 ")
            End If
            If pr = 3 Then
                cond = String.Concat(cond, " and datediff(day,doc_date,getdate()) between 61 and 91  ")
            End If
            If pr = 4 Then
                cond = String.Concat(cond, " and datediff(day,doc_date,getdate()) between 91  and 120 ")
            End If
            If pr = 5 Then
                cond = String.Concat(cond, " and  DateDiff(Day, doc_date, getdate())  > 120  ")
            End If

            SelectStmt = "select sum(ccopend.balance)balance from ccopend where ccopend.cust_code =" & custCode & ""

            SelectStmt = LibX.MdlUtil.ConcatWherePart(SelectStmt, cond)
            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            For Each orow As DataRow In oTable.Rows
                bal = (Val(orow!balance.ToString))
                If bal = Nothing Then
                    bal = 0
                End If
            Next

            Return bal


        Catch ex As Exception
            LibX.Log.Show(ex)
            Return -1
        End Try
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Me.LibXConnector1.AcceptFind()
        Me.LibXConnector1.Find()
        Me.fecha_fin.Value = LibX.Data.Manager.Connection.GetDate

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
