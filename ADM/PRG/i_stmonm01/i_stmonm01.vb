Public Class i_stmonm01
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
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents xtxt_mon_name As LibX.XTextBox
    Friend WithEvents xtxt_mon_code As LibX.XTextBox
    Friend WithEvents xtxt_mon_denominacion As LibX.XMaskEdit
    Friend WithEvents LibXShortNavigator1 As LibX.LibXShortNavigator
    Friend WithEvents stmoneda As System.Data.DataTable
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xtxt_mon_name = New LibX.XTextBox
        Me.DataSet1 = New System.Data.DataSet
        Me.stmoneda = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.xtxt_mon_code = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.xtxt_mon_denominacion = New LibX.XMaskEdit
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataColumn5 = New System.Data.DataColumn
        Me.LibXShortNavigator1 = New LibX.LibXShortNavigator
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stmoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xtxt_mon_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xtxt_mon_code)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xtxt_mon_denominacion)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 120)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'xtxt_mon_name
        '
        Me.xtxt_mon_name.AcceptsReturn = True
        Me.xtxt_mon_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "stmoneda.mon_name"))
        Me.xtxt_mon_name.EditInitialValue = Nothing
        Me.xtxt_mon_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_mon_name.FieldDescription = ""
        Me.xtxt_mon_name.FindInitialValue = Nothing
        Me.xtxt_mon_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_mon_name.IgnoreRequiered = False
        Me.xtxt_mon_name.Location = New System.Drawing.Point(96, 48)
        Me.xtxt_mon_name.Name = "xtxt_mon_name"
        Me.xtxt_mon_name.NewInitialValue = Nothing
        Me.xtxt_mon_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_mon_name.Requiered = False
        Me.xtxt_mon_name.Size = New System.Drawing.Size(256, 20)
        Me.xtxt_mon_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_mon_name.TabIndex = 1
        Me.xtxt_mon_name.Text = ""
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.stmoneda})
        '
        'stmoneda
        '
        Me.stmoneda.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.stmoneda.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"mon_code"}, True)})
        Me.stmoneda.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.stmoneda.TableName = "stmoneda"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "mon_code"
        Me.DataColumn1.MaxLength = 3
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "mon_name"
        Me.DataColumn2.MaxLength = 50
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "mon_denominacion"
        Me.DataColumn3.DataType = GetType(System.Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "mon_valor"
        Me.DataColumn4.DataType = GetType(System.Decimal)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_mon_code
        '
        Me.xtxt_mon_code.AcceptsReturn = True
        Me.xtxt_mon_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "stmoneda.mon_code"))
        Me.xtxt_mon_code.EditInitialValue = Nothing
        Me.xtxt_mon_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_mon_code.FieldDescription = ""
        Me.xtxt_mon_code.FindInitialValue = Nothing
        Me.xtxt_mon_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_mon_code.IgnoreRequiered = False
        Me.xtxt_mon_code.Location = New System.Drawing.Point(96, 24)
        Me.xtxt_mon_code.Name = "xtxt_mon_code"
        Me.xtxt_mon_code.NewInitialValue = Nothing
        Me.xtxt_mon_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_mon_code.Requiered = False
        Me.xtxt_mon_code.Size = New System.Drawing.Size(64, 20)
        Me.xtxt_mon_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_mon_code.TabIndex = 0
        Me.xtxt_mon_code.Text = ""
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
        Me.Label3.Location = New System.Drawing.Point(3, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Denominación:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_mon_denominacion
        '
        Me.xtxt_mon_denominacion.AcceptsReturn = True
        Me.xtxt_mon_denominacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "stmoneda.mon_denominacion"))
        Me.xtxt_mon_denominacion.EditInitialValue = Nothing
        Me.xtxt_mon_denominacion.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_mon_denominacion.FieldDescription = ""
        Me.xtxt_mon_denominacion.FindInitialValue = Nothing
        Me.xtxt_mon_denominacion.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_mon_denominacion.IgnoreRequiered = False
        Me.xtxt_mon_denominacion.Location = New System.Drawing.Point(96, 72)
        Me.xtxt_mon_denominacion.Masked = MaskedTextBox.Mask.None
        Me.xtxt_mon_denominacion.Name = "xtxt_mon_denominacion"
        Me.xtxt_mon_denominacion.NewInitialValue = Nothing
        Me.xtxt_mon_denominacion.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_mon_denominacion.Requiered = False
        Me.xtxt_mon_denominacion.Size = New System.Drawing.Size(88, 20)
        Me.xtxt_mon_denominacion.StatusBarPanelDescripcion = Nothing
        Me.xtxt_mon_denominacion.TabIndex = 2
        Me.xtxt_mon_denominacion.Text = ""
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
        Me.LibXConnector1.DataMember = "stmoneda"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
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
        Me.LibXDbSourceTable1.KeyFields = ""
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "stmoneda"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "display_order"
        Me.DataColumn5.DataType = GetType(System.Int32)
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
        Me.LibXShortNavigator1.Size = New System.Drawing.Size(386, 24)
        Me.LibXShortNavigator1.TabIndex = 2
        '
        'i_stmonm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(386, 183)
        Me.Controls.Add(Me.LibXShortNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_stmonm01"
        Me.Text = "Mantenimiento de Monedas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stmoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        Me.xtxt_mon_code.Focus()
    End Sub

    Private Sub LibXConnector1_SettingDefaultqueryValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultQueryValues) Handles LibXConnector1.SettingDefaultqueryValues
        Me.xtxt_mon_code.Focus()
    End Sub
End Class
