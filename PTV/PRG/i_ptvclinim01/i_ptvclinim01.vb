Public Class i_ptvclinim01
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
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = True
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = True
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = Nothing
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
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 104)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "sclinicam.clini_code"))
        Me.TextBox1.Location = New System.Drawing.Point(128, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(72, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "C�digo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "sclinicam.clini_name"))
        Me.TextBox2.Location = New System.Drawing.Point(128, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(344, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(67, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.LibXDbSourceTable1.SerialColumnName = "clini_code"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "sclinicam"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'i_ptvclinim01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(698, 160)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ptvclinim01"
        Me.Text = "Mantenimiento de Ciudades"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub i_citym_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
