Public Class i_cjncrm01
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
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
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
    Friend WithEvents xtxt_ncr_number As LibX.XTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents xdt_ncr_date As LibX.LibxDateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents XMaskEdit1 As LibX.XMaskEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents XMaskEdit2 As LibX.XMaskEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents xtxt_bus_name As LibX.XTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXCombo1 = New LibX.LibXCombo
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
        Me.XMaskEdit1 = New LibX.XMaskEdit
        Me.xdt_ncr_date = New LibX.LibxDateTimePicker
        Me.xtxt_ncr_number = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.xtxt_bus_name = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.XMaskEdit2 = New LibX.XMaskEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit1)
        Me.GroupBox1.Controls.Add(Me.xdt_ncr_date)
        Me.GroupBox1.Controls.Add(Me.xtxt_ncr_number)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xtxt_bus_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 168)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
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
        Me.LibXCombo1.Items.AddRange(New Object() {"1-Pendiente", "0-Aplicada"})
        Me.LibXCombo1.Location = New System.Drawing.Point(424, 72)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = Nothing
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = "1"
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(104, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 4
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ncr_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "cjncrm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "ncr_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "type_code"
        Me.DataColumn2.MaxLength = 3
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "ncr_number"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "ncr_date"
        Me.DataColumn4.DataType = GetType(System.DateTime)
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "ncr_amount"
        Me.DataColumn5.DataType = GetType(System.Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "ncr_balance"
        Me.DataColumn6.DataType = GetType(System.Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "ncr_estatus"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "ncr_ncf"
        Me.DataColumn8.MaxLength = 20
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "ftserial_no"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "bus_name"
        Me.DataColumn10.MaxLength = 60
        '
        'XMaskEdit1
        '
        Me.XMaskEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjncrm.ncr_amount"))
        Me.XMaskEdit1.EditInitialValue = Nothing
        Me.XMaskEdit1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.FieldDescription = ""
        Me.XMaskEdit1.FindInitialValue = Nothing
        Me.XMaskEdit1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.IgnoreRequiered = False
        Me.XMaskEdit1.Location = New System.Drawing.Point(112, 96)
        Me.XMaskEdit1.Masked = MaskedTextBox.Mask.None
        Me.XMaskEdit1.Name = "XMaskEdit1"
        Me.XMaskEdit1.NewInitialValue = Nothing
        Me.XMaskEdit1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.Requiered = False
        Me.XMaskEdit1.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit1.TabIndex = 3
        Me.XMaskEdit1.Text = ""
        '
        'xdt_ncr_date
        '
        Me.xdt_ncr_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_ncr_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cjncrm.ncr_date"))
        Me.xdt_ncr_date.EditInitialValue = Nothing
        Me.xdt_ncr_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_ncr_date.FieldDescription = ""
        Me.xdt_ncr_date.FindInitialValue = Nothing
        Me.xdt_ncr_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_ncr_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_ncr_date.IgnoreRequiered = False
        Me.xdt_ncr_date.Location = New System.Drawing.Point(112, 72)
        Me.xdt_ncr_date.Name = "xdt_ncr_date"
        Me.xdt_ncr_date.NewInitialValue = Nothing
        Me.xdt_ncr_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_ncr_date.Requiered = False
        Me.xdt_ncr_date.Size = New System.Drawing.Size(104, 20)
        Me.xdt_ncr_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_ncr_date.TabIndex = 2
        '
        'xtxt_ncr_number
        '
        Me.xtxt_ncr_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjncrm.ncr_number"))
        Me.xtxt_ncr_number.EditInitialValue = Nothing
        Me.xtxt_ncr_number.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_ncr_number.FieldDescription = ""
        Me.xtxt_ncr_number.FindInitialValue = Nothing
        Me.xtxt_ncr_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_ncr_number.IgnoreRequiered = False
        Me.xtxt_ncr_number.Location = New System.Drawing.Point(112, 24)
        Me.xtxt_ncr_number.Name = "xtxt_ncr_number"
        Me.xtxt_ncr_number.NewInitialValue = Nothing
        Me.xtxt_ncr_number.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_ncr_number.Requiered = False
        Me.xtxt_ncr_number.Size = New System.Drawing.Size(104, 20)
        Me.xtxt_ncr_number.StatusBarPanelDescripcion = Nothing
        Me.xtxt_ncr_number.TabIndex = 0
        Me.xtxt_ncr_number.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(56, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(65, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_bus_name
        '
        Me.xtxt_bus_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjncrm.bus_name"))
        Me.xtxt_bus_name.EditInitialValue = Nothing
        Me.xtxt_bus_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_bus_name.FieldDescription = ""
        Me.xtxt_bus_name.FindInitialValue = Nothing
        Me.xtxt_bus_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_bus_name.IgnoreRequiered = False
        Me.xtxt_bus_name.Location = New System.Drawing.Point(112, 48)
        Me.xtxt_bus_name.Name = "xtxt_bus_name"
        Me.xtxt_bus_name.NewInitialValue = Nothing
        Me.xtxt_bus_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_bus_name.Requiered = False
        Me.xtxt_bus_name.Size = New System.Drawing.Size(416, 20)
        Me.xtxt_bus_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_bus_name.TabIndex = 1
        Me.xtxt_bus_name.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(37, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Beneficiario:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(65, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Monto:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(368, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Balance:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XMaskEdit2
        '
        Me.XMaskEdit2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjncrm.ncr_balance"))
        Me.XMaskEdit2.EditInitialValue = Nothing
        Me.XMaskEdit2.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XMaskEdit2.FieldDescription = ""
        Me.XMaskEdit2.FindInitialValue = Nothing
        Me.XMaskEdit2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit2.IgnoreRequiered = False
        Me.XMaskEdit2.Location = New System.Drawing.Point(424, 96)
        Me.XMaskEdit2.Masked = MaskedTextBox.Mask.None
        Me.XMaskEdit2.Name = "XMaskEdit2"
        Me.XMaskEdit2.NewInitialValue = Nothing
        Me.XMaskEdit2.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XMaskEdit2.Requiered = False
        Me.XMaskEdit2.Size = New System.Drawing.Size(104, 20)
        Me.XMaskEdit2.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit2.TabIndex = 5
        Me.XMaskEdit2.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(371, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Estatus:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.LibXConnector1.DataMember = "cjncrm"
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
        Me.LibXDbSourceTable1.SerialColumnName = "ncr_code"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cjncrm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_bus_name
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_ncr_number
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_bus_name
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(690, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'i_cjncrm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 224)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_cjncrm01"
        Me.Text = "Notas de Crédito de Punto de Venta"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim oDocumento As SGT.Inventario.Entidades.Documento
    Dim whDefault As Integer

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Try

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub i_cjncrm01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oDocumento = New SGT.Inventario.Entidades.Documento("NCR")
        whDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxWhDefault")

    End Sub

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try
            If e.UpdatingArgs.StatementType = StatementType.Insert Then
                e.UpdatingArgs.Row!ncr_number = oDocumento.GenerateNumber("NCR", whDefault)
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex, True)
        End Try
    End Sub
End Class
