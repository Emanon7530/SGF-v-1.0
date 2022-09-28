Public Class i_pvtarjm01
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
    Friend WithEvents TextBox1 As LibX.XTextBox
    Friend WithEvents TextBox2 As LibX.XTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXShortNavigator1 As LibX.LibXShortNavigator
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents xlk_cust_code As LibX.LibXLookup
    Friend WithEvents lblcust_name As System.Windows.Forms.Label
    Friend WithEvents XMaskEdit1 As LibX.XMaskEdit
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents LibXCombo2 As LibX.LibXCombo
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.XMaskEdit1 = New LibX.XMaskEdit
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.lblcust_name = New System.Windows.Forms.Label
        Me.xlk_cust_code = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataColumn6 = New System.Data.DataColumn
        Me.XTextBox2 = New LibX.XTextBox
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox2 = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LibXShortNavigator1 = New LibX.LibXShortNavigator
        Me.LibXCombo2 = New LibX.LibXCombo
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LibXCombo2)
        Me.GroupBox1.Controls.Add(Me.XMaskEdit1)
        Me.GroupBox1.Controls.Add(Me.lblcust_name)
        Me.GroupBox1.Controls.Add(Me.xlk_cust_code)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 168)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'XMaskEdit1
        '
        Me.XMaskEdit1.AcceptsReturn = True
        Me.XMaskEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvtipotarm.recargo"))
        Me.XMaskEdit1.EditInitialValue = Nothing
        Me.XMaskEdit1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.FieldDescription = ""
        Me.XMaskEdit1.FindInitialValue = Nothing
        Me.XMaskEdit1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.IgnoreRequiered = False
        Me.XMaskEdit1.Location = New System.Drawing.Point(96, 120)
        Me.XMaskEdit1.Masked = MaskedTextBox.Mask.Decimal
        Me.XMaskEdit1.Name = "XMaskEdit1"
        Me.XMaskEdit1.NewInitialValue = Nothing
        Me.XMaskEdit1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XMaskEdit1.Requiered = False
        Me.XMaskEdit1.Size = New System.Drawing.Size(64, 20)
        Me.XMaskEdit1.StatusBarPanelDescripcion = Nothing
        Me.XMaskEdit1.TabIndex = 10
        Me.XMaskEdit1.Text = ""
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"tart_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "pvtipotarm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "tart_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "ban_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "Nombre"
        Me.DataColumn3.MaxLength = 50
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "cust_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "recargo"
        Me.DataColumn5.DataType = GetType(System.Decimal)
        '
        'lblcust_name
        '
        Me.lblcust_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcust_name.Location = New System.Drawing.Point(168, 96)
        Me.lblcust_name.Name = "lblcust_name"
        Me.lblcust_name.Size = New System.Drawing.Size(240, 20)
        Me.lblcust_name.TabIndex = 9
        '
        'xlk_cust_code
        '
        Me.xlk_cust_code.AlternateFieldSearch = Nothing
        Me.xlk_cust_code.BeginCheck = False
        Me.xlk_cust_code.CheckText = Nothing
        Me.xlk_cust_code.ComboMode = False
        Me.xlk_cust_code.DataMember = Nothing
        Me.xlk_cust_code.DataSource = Me.LibXConnector1
        Me.xlk_cust_code.DestParameters = New String() {"cust_code=cust_code", "lblcust_name=cust_name"}
        Me.xlk_cust_code.FilterField = Nothing
        Me.xlk_cust_code.IgnoreFindInBrowseMode = False
        Me.xlk_cust_code.isCanceled = False
        Me.xlk_cust_code.Location = New System.Drawing.Point(408, 96)
        Me.xlk_cust_code.LookCaption = "Cuentas a Creditos"
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
        Me.xlk_cust_code.TabIndex = 8
        Me.xlk_cust_code.TableName = "cccustm"
        Me.xlk_cust_code.TabStop = False
        Me.xlk_cust_code.UseCopyConnection = False
        Me.xlk_cust_code.UseRowRetrieveEvents = False
        Me.xlk_cust_code.UseTab = False
        Me.xlk_cust_code.VisParameters = New String() {"Codigo=cust_code", "Nombre=cust_name"}
        Me.xlk_cust_code.WhereCondition = "csttype_code = 4"
        Me.xlk_cust_code.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "pvtipotarm"
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
        Me.LibXDbSourceTable1.SerialColumnName = "tart_code"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "pvtipotarm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "type"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvtipotarm.cust_code"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(96, 96)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(64, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 3
        Me.XTextBox2.Text = ""
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "pvtipotarm.ban_code"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Location = New System.Drawing.Point(96, 48)
        Me.LibXCombo1.LookupKeyDisplayFields = "ban_name"
        Me.LibXCombo1.LookupKeyField = "ban_code"
        Me.LibXCombo1.LookupTableName = "ftbanco"
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(328, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(20, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "% Recargo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "pvtipotarm.Nombre"))
        Me.TextBox2.EditInitialValue = Nothing
        Me.TextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.FieldDescription = ""
        Me.TextBox2.FindInitialValue = Nothing
        Me.TextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.IgnoreRequiered = False
        Me.TextBox2.Location = New System.Drawing.Point(96, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.NewInitialValue = Nothing
        Me.TextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox2.Requiered = False
        Me.TextBox2.Size = New System.Drawing.Size(328, 20)
        Me.TextBox2.StatusBarPanelDescripcion = Nothing
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "pvtipotarm.tart_code"))
        Me.TextBox1.EditInitialValue = Nothing
        Me.TextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox1.FieldDescription = ""
        Me.TextBox1.FindInitialValue = Nothing
        Me.TextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox1.IgnoreRequiered = False
        Me.TextBox1.Location = New System.Drawing.Point(96, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.NewInitialValue = Nothing
        Me.TextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.TextBox1.Requiered = False
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.StatusBarPanelDescripcion = Nothing
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(40, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(44, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Banco:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(39, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Cuenta:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXShortNavigator1
        '
        Me.LibXShortNavigator1.BuildMenu = True
        Me.LibXShortNavigator1.Connector = Me.LibXConnector1
        Me.LibXShortNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXShortNavigator1.FirstControlInEditMode = Nothing
        Me.LibXShortNavigator1.FirstControlInFindMode = Nothing
        Me.LibXShortNavigator1.FirstControlInNewMode = Nothing
        Me.LibXShortNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXShortNavigator1.Name = "LibXShortNavigator1"
        Me.LibXShortNavigator1.Size = New System.Drawing.Size(450, 24)
        Me.LibXShortNavigator1.TabIndex = 0
        '
        'LibXCombo2
        '
        Me.LibXCombo2.AllowDefaultSort = True
        Me.LibXCombo2.bound = True
        Me.LibXCombo2.currValue = Nothing
        Me.LibXCombo2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "pvtipotarm.type"))
        Me.LibXCombo2.DefaultWhereString = Nothing
        Me.LibXCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo2.EditInitialValue = Nothing
        Me.LibXCombo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.FieldDescription = ""
        Me.LibXCombo2.FindInitialValue = Nothing
        Me.LibXCombo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.IgnoreRequiered = False
        Me.LibXCombo2.Items.AddRange(New Object() {"1-CREDITO", "2-DEBITO"})
        Me.LibXCombo2.Location = New System.Drawing.Point(96, 144)
        Me.LibXCombo2.LookupKeyDisplayFields = Nothing
        Me.LibXCombo2.LookupKeyField = Nothing
        Me.LibXCombo2.LookupTableName = Nothing
        Me.LibXCombo2.Name = "LibXCombo2"
        Me.LibXCombo2.NewInitialValue = Nothing
        Me.LibXCombo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.Requiered = False
        Me.LibXCombo2.Required = False
        Me.LibXCombo2.Size = New System.Drawing.Size(121, 21)
        Me.LibXCombo2.SqlString = Nothing
        Me.LibXCombo2.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo2.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(24, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tipo Tarjeta:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'i_pvtarjm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(450, 232)
        Me.Controls.Add(Me.LibXShortNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_pvtarjm01"
        Me.Text = "Tipos de Tarjetas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub i_ivgroup01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState

    End Sub
End Class
