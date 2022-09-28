Public Class i_ftdevtp01
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
    Friend WithEvents LibXShortNavigator1 As LibX.LibXShortNavigator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents xtxt_dev_type As LibX.XTextBox
    Friend WithEvents xtxt_dev_name As LibX.XTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXShortNavigator1 = New LibX.LibXShortNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.xtxt_dev_type = New LibX.XTextBox
        Me.xtxt_dev_name = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXShortNavigator1
        '
        Me.LibXShortNavigator1.BuildMenu = True
        Me.LibXShortNavigator1.Connector = Me.LibXConnector1
        Me.LibXShortNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXShortNavigator1.FirstControlInEditMode = Me.xtxt_dev_name
        Me.LibXShortNavigator1.FirstControlInFindMode = Me.xtxt_dev_type
        Me.LibXShortNavigator1.FirstControlInNewMode = Me.xtxt_dev_type
        Me.LibXShortNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXShortNavigator1.Name = "LibXShortNavigator1"
        Me.LibXShortNavigator1.Size = New System.Drawing.Size(448, 24)
        Me.LibXShortNavigator1.TabIndex = 0
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
        Me.LibXConnector1.DataMember = "ftdevolt"
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
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.DataTable1.TableName = "ftdevolt"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "dev_type"
        Me.DataColumn1.MaxLength = 3
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "dev_name"
        Me.DataColumn2.MaxLength = 60
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "afect_inv"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "req_serie"
        Me.DataColumn4.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.TableName = "ftdevolt"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LibxCheckBox1)
        Me.GroupBox1.Controls.Add(Me.xtxt_dev_type)
        Me.GroupBox1.Controls.Add(Me.xtxt_dev_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 128)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(72, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Código:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ftdevolt.afect_inv"))
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(18, 72)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = Nothing
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = False
        Me.LibxCheckBox1.Size = New System.Drawing.Size(120, 16)
        Me.LibxCheckBox1.TabIndex = 2
        Me.LibxCheckBox1.Text = "Afecta inventario?"
        Me.LibxCheckBox1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'xtxt_dev_type
        '
        Me.xtxt_dev_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_dev_type.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftdevolt.dev_type"))
        Me.xtxt_dev_type.EditInitialValue = Nothing
        Me.xtxt_dev_type.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_dev_type.FieldDescription = ""
        Me.xtxt_dev_type.FindInitialValue = Nothing
        Me.xtxt_dev_type.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_dev_type.IgnoreRequiered = False
        Me.xtxt_dev_type.Location = New System.Drawing.Point(124, 24)
        Me.xtxt_dev_type.Name = "xtxt_dev_type"
        Me.xtxt_dev_type.NewInitialValue = Nothing
        Me.xtxt_dev_type.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_dev_type.Requiered = False
        Me.xtxt_dev_type.Size = New System.Drawing.Size(52, 20)
        Me.xtxt_dev_type.StatusBarPanelDescripcion = Nothing
        Me.xtxt_dev_type.TabIndex = 0
        Me.xtxt_dev_type.Text = ""
        '
        'xtxt_dev_name
        '
        Me.xtxt_dev_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_dev_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftdevolt.dev_name"))
        Me.xtxt_dev_name.EditInitialValue = Nothing
        Me.xtxt_dev_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_dev_name.FieldDescription = ""
        Me.xtxt_dev_name.FindInitialValue = Nothing
        Me.xtxt_dev_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_dev_name.IgnoreRequiered = False
        Me.xtxt_dev_name.Location = New System.Drawing.Point(124, 48)
        Me.xtxt_dev_name.Name = "xtxt_dev_name"
        Me.xtxt_dev_name.NewInitialValue = Nothing
        Me.xtxt_dev_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_dev_name.Requiered = False
        Me.xtxt_dev_name.Size = New System.Drawing.Size(264, 20)
        Me.xtxt_dev_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_dev_name.TabIndex = 1
        Me.xtxt_dev_name.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(48, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'i_ftdevtp01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 191)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXShortNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ftdevtp01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Motivos de devolución"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
