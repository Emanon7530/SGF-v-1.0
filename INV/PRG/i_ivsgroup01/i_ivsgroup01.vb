Public Class i_ivsgroup01
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
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents group_name As LibX.XTextBox
    Friend WithEvents sgroup_name As LibX.XTextBox
    Friend WithEvents sgroup_code As LibX.XTextBox
    Friend WithEvents LblGrupo As LibX.LibXLookup
    Friend WithEvents TxtGroup_code As LibX.XTextBox
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox2 As LibX.LibxCheckBox
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblGrupo = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.sgroup_name = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.sgroup_code = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.group_name = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtGroup_code = New LibX.XTextBox
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.DataSet1 = New System.Data.DataSet
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.LibxCheckBox2 = New LibX.LibxCheckBox
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibxCheckBox2)
        Me.GroupBox1.Controls.Add(Me.LibxCheckBox1)
        Me.GroupBox1.Controls.Add(Me.LblGrupo)
        Me.GroupBox1.Controls.Add(Me.sgroup_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.sgroup_code)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.group_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtGroup_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 120)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'LblGrupo
        '
        Me.LblGrupo.AlternateFieldSearch = Nothing
        Me.LblGrupo.BeginCheck = False
        Me.LblGrupo.CheckText = Nothing
        Me.LblGrupo.ComboMode = False
        Me.LblGrupo.DataMember = Nothing
        Me.LblGrupo.DataSource = Me.LibXConnector1
        Me.LblGrupo.DestParameters = New String() {"TxtGroup_code=group_code", "group_name=group_name"}
        Me.LblGrupo.FilterField = Nothing
        Me.LblGrupo.IgnoreFindInBrowseMode = False
        Me.LblGrupo.isCanceled = False
        Me.LblGrupo.Location = New System.Drawing.Point(456, 47)
        Me.LblGrupo.LookCaption = "Sub-grupos"
        Me.LblGrupo.Name = "LblGrupo"
        Me.LblGrupo.PopupSize = New System.Drawing.Size(0, 0)
        Me.LblGrupo.ShowFilter = True
        Me.LblGrupo.ShowMessageNotFound = True
        Me.LblGrupo.ShowWarning = False
        Me.LblGrupo.Size = New System.Drawing.Size(16, 20)
        Me.LblGrupo.SizesColumns = Nothing
        Me.LblGrupo.SizesColumnsTab = Nothing
        Me.LblGrupo.SqlString = Nothing
        Me.LblGrupo.SQLTab = Nothing
        Me.LblGrupo.SrcParameters = New String() {"TxtGroup_code=group_code"}
        Me.LblGrupo.TabIndex = 4
        Me.LblGrupo.TableName = "ivgroupm"
        Me.LblGrupo.TabStop = False
        Me.LblGrupo.UseCopyConnection = False
        Me.LblGrupo.UseRowRetrieveEvents = False
        Me.LblGrupo.UseTab = False
        Me.LblGrupo.VisParameters = New String() {"Código=group_code", "Nombre=group_name"}
        Me.LblGrupo.WhereCondition = Nothing
        Me.LblGrupo.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "ivsgroupm"
        Me.LibXConnector1.DataSource = Nothing
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = "INV"
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
        Me.LibXConnector1.UseTransactions = False
        '
        'sgroup_name
        '
        Me.sgroup_name.AcceptsReturn = True
        Me.sgroup_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.sgroup_name.EditInitialValue = Nothing
        Me.sgroup_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.sgroup_name.FieldDescription = ""
        Me.sgroup_name.FindInitialValue = Nothing
        Me.sgroup_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.sgroup_name.IgnoreRequiered = False
        Me.sgroup_name.Location = New System.Drawing.Point(128, 72)
        Me.sgroup_name.Name = "sgroup_name"
        Me.sgroup_name.NewInitialValue = Nothing
        Me.sgroup_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.sgroup_name.Requiered = False
        Me.sgroup_name.Size = New System.Drawing.Size(328, 20)
        Me.sgroup_name.StatusBarPanelDescripcion = Nothing
        Me.sgroup_name.TabIndex = 1
        Me.sgroup_name.Text = ""
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'sgroup_code
        '
        Me.sgroup_code.AcceptsReturn = True
        Me.sgroup_code.EditInitialValue = Nothing
        Me.sgroup_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.sgroup_code.FieldDescription = ""
        Me.sgroup_code.FindInitialValue = Nothing
        Me.sgroup_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.sgroup_code.IgnoreRequiered = False
        Me.sgroup_code.Location = New System.Drawing.Point(128, 24)
        Me.sgroup_code.Name = "sgroup_code"
        Me.sgroup_code.NewInitialValue = Nothing
        Me.sgroup_code.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.sgroup_code.Requiered = False
        Me.sgroup_code.Size = New System.Drawing.Size(64, 20)
        Me.sgroup_code.StatusBarPanelDescripcion = Nothing
        Me.sgroup_code.TabIndex = 0
        Me.sgroup_code.Text = ""
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'group_name
        '
        Me.group_name.AcceptsReturn = True
        Me.group_name.EditInitialValue = Nothing
        Me.group_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.group_name.FieldDescription = ""
        Me.group_name.FindInitialValue = Nothing
        Me.group_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.group_name.IgnoreRequiered = False
        Me.group_name.Location = New System.Drawing.Point(200, 47)
        Me.group_name.Name = "group_name"
        Me.group_name.NewInitialValue = Nothing
        Me.group_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.group_name.ReadOnly = True
        Me.group_name.Requiered = False
        Me.group_name.Size = New System.Drawing.Size(256, 20)
        Me.group_name.StatusBarPanelDescripcion = Nothing
        Me.group_name.TabIndex = 3
        Me.group_name.Text = ""
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(14, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Grupo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtGroup_code
        '
        Me.TxtGroup_code.AcceptsReturn = True
        Me.TxtGroup_code.EditInitialValue = Nothing
        Me.TxtGroup_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TxtGroup_code.FieldDescription = ""
        Me.TxtGroup_code.FindInitialValue = Nothing
        Me.TxtGroup_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TxtGroup_code.IgnoreRequiered = False
        Me.TxtGroup_code.Location = New System.Drawing.Point(128, 47)
        Me.TxtGroup_code.Name = "TxtGroup_code"
        Me.TxtGroup_code.NewInitialValue = Nothing
        Me.TxtGroup_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TxtGroup_code.Requiered = False
        Me.TxtGroup_code.Size = New System.Drawing.Size(64, 20)
        Me.TxtGroup_code.StatusBarPanelDescripcion = Nothing
        Me.TxtGroup_code.TabIndex = 2
        Me.TxtGroup_code.Text = ""
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Nothing
        Me.LibXNavigator1.FirstControlInFindMode = Nothing
        Me.LibXNavigator1.FirstControlInNewMode = Nothing
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(698, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2})
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivsgroupm.Incluido"))
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(200, 19)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = Nothing
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = False
        Me.LibxCheckBox1.TabIndex = 5
        Me.LibxCheckBox1.Text = "Incluido"
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'LibxCheckBox2
        '
        Me.LibxCheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivsgroupm.Oferta"))
        Me.LibxCheckBox2.EditInitialValue = Nothing
        Me.LibxCheckBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.FindInitialValue = Nothing
        Me.LibxCheckBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.IgnoreRequiered = False
        Me.LibxCheckBox2.KeepEnabled = False
        Me.LibxCheckBox2.Location = New System.Drawing.Point(352, 16)
        Me.LibxCheckBox2.Name = "LibxCheckBox2"
        Me.LibxCheckBox2.NewInitialValue = Nothing
        Me.LibxCheckBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.ReadOnly = False
        Me.LibxCheckBox2.Requiered = False
        Me.LibxCheckBox2.TabIndex = 6
        Me.LibxCheckBox2.Text = "Oferta"
        Me.LibxCheckBox2.ThreeState = True
        Me.LibxCheckBox2.value = Nothing
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"sgroup_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "ivsgroupm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "sgroup_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "group_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sgroup_name"
        Me.DataColumn3.MaxLength = 30
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
        Me.LibXDbSourceTable1.SerialColumnName = "group_code"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ivgroupm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9})
        Me.DataTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"group_code"}, True)})
        Me.DataTable2.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn4}
        Me.DataTable2.TableName = "ivgroupm"
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.AutoIncrement = True
        Me.DataColumn4.ColumnName = "group_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        Me.DataColumn4.ReadOnly = True
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "group_name"
        Me.DataColumn5.MaxLength = 30
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "prov_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "last_number"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "incluido"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "oferta"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'i_ivsgroup01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(698, 175)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivsgroup01"
        Me.Text = "Mantenimiento de sub-grupos de productos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub i_ivgroup01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState

    End Sub

    'Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
    '    Try
    '        If e.UpdatingArgs.StatementType = StatementType.Insert Then
    '            e.UpdatingArgs.Row!last_number = 0
    '        End If

    '        If e.UpdatingArgs.StatementType = StatementType.Update Then
    '            If LibX.IsNull(e.UpdatingArgs.Row!last_number) = True Then
    '                e.UpdatingArgs.Row!last_number = 0
    '            End If
    '        End If

    '    Catch ex As Exception
    '        e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
    '        LibX.Log.Show(ex)
    '    End Try
    'End Sub

End Class
