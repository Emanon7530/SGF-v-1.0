Public Class i_cccsttpm01
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup4 As LibX.LibXLookup
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup5 As LibX.LibXLookup
    Friend WithEvents LibXLookup6 As LibX.LibXLookup
    Friend WithEvents LibXLookup7 As LibX.LibXLookup
    Friend WithEvents LibXLookup8 As LibX.LibXLookup
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.LibXLookup4 = New LibX.LibXLookup
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LibXLookup5 = New LibX.LibXLookup
        Me.LibXLookup6 = New LibX.LibXLookup
        Me.LibXLookup7 = New LibX.LibXLookup
        Me.LibXLookup8 = New LibX.LibXLookup
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
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
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
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
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = "csttype_code"
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cccsttpm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 320)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LibXLookup1)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.LibXLookup2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.LibXLookup3)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.LibXLookup4)
        Me.GroupBox2.Controls.Add(Me.TextBox11)
        Me.GroupBox2.Controls.Add(Me.TextBox12)
        Me.GroupBox2.Controls.Add(Me.TextBox13)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.LibXLookup5)
        Me.GroupBox2.Controls.Add(Me.LibXLookup6)
        Me.GroupBox2.Controls.Add(Me.LibXLookup7)
        Me.GroupBox2.Controls.Add(Me.LibXLookup8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox14)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBox15)
        Me.GroupBox2.Controls.Add(Me.TextBox16)
        Me.GroupBox2.Controls.Add(Me.TextBox17)
        Me.GroupBox2.Controls.Add(Me.TextBox18)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 224)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información Contables"
        '
        'LibXLookup1
        '
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Nothing
        Me.LibXLookup1.DestParameters = Nothing
        Me.LibXLookup1.Location = New System.Drawing.Point(424, 24)
        Me.LibXLookup1.LookCaption = Nothing
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.Size = New System.Drawing.Size(20, 20)
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SrcParameters = Nothing
        Me.LibXLookup1.TabIndex = 4
        Me.LibXLookup1.TableName = Nothing
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.VisParameters = Nothing
        Me.LibXLookup1.WhereCondition = Nothing
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cccsttpm.acct_cxc"))
        Me.TextBox3.Location = New System.Drawing.Point(112, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(112, 20)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(10, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cuenta x Cobrar:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(232, 24)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(192, 20)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = ""
        '
        'LibXLookup2
        '
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Nothing
        Me.LibXLookup2.DestParameters = Nothing
        Me.LibXLookup2.Location = New System.Drawing.Point(424, 48)
        Me.LibXLookup2.LookCaption = Nothing
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.Size = New System.Drawing.Size(20, 20)
        Me.LibXLookup2.SqlString = Nothing
        Me.LibXLookup2.SrcParameters = Nothing
        Me.LibXLookup2.TabIndex = 4
        Me.LibXLookup2.TableName = Nothing
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.VisParameters = Nothing
        Me.LibXLookup2.WhereCondition = Nothing
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(26, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Caja y Banco:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cccsttpm.acct_cash"))
        Me.TextBox5.Location = New System.Drawing.Point(112, 48)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(112, 20)
        Me.TextBox5.TabIndex = 3
        Me.TextBox5.Text = ""
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(232, 48)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(192, 20)
        Me.TextBox6.TabIndex = 3
        Me.TextBox6.Text = ""
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(232, 72)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(192, 20)
        Me.TextBox7.TabIndex = 3
        Me.TextBox7.Text = ""
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cccsttpm.acct_sales_exc"))
        Me.TextBox8.Location = New System.Drawing.Point(112, 72)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(112, 20)
        Me.TextBox8.TabIndex = 3
        Me.TextBox8.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(8, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Ventas Excentas:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXLookup3
        '
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Nothing
        Me.LibXLookup3.DestParameters = Nothing
        Me.LibXLookup3.Location = New System.Drawing.Point(424, 72)
        Me.LibXLookup3.LookCaption = Nothing
        Me.LibXLookup3.Name = "LibXLookup3"
        Me.LibXLookup3.Size = New System.Drawing.Size(20, 20)
        Me.LibXLookup3.SqlString = Nothing
        Me.LibXLookup3.SrcParameters = Nothing
        Me.LibXLookup3.TabIndex = 4
        Me.LibXLookup3.TableName = Nothing
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.VisParameters = Nothing
        Me.LibXLookup3.WhereCondition = Nothing
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(232, 96)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(192, 20)
        Me.TextBox9.TabIndex = 3
        Me.TextBox9.Text = ""
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cccsttpm.acct_sales_grab"))
        Me.TextBox10.Location = New System.Drawing.Point(112, 96)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(112, 20)
        Me.TextBox10.TabIndex = 3
        Me.TextBox10.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(8, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Ventas Grabadas"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXLookup4
        '
        Me.LibXLookup4.DataMember = Nothing
        Me.LibXLookup4.DataSource = Nothing
        Me.LibXLookup4.DestParameters = Nothing
        Me.LibXLookup4.Location = New System.Drawing.Point(424, 96)
        Me.LibXLookup4.LookCaption = Nothing
        Me.LibXLookup4.Name = "LibXLookup4"
        Me.LibXLookup4.Size = New System.Drawing.Size(20, 20)
        Me.LibXLookup4.SqlString = Nothing
        Me.LibXLookup4.SrcParameters = Nothing
        Me.LibXLookup4.TabIndex = 4
        Me.LibXLookup4.TableName = Nothing
        Me.LibXLookup4.UseCopyConnection = False
        Me.LibXLookup4.UseRowRetrieveEvents = False
        Me.LibXLookup4.VisParameters = Nothing
        Me.LibXLookup4.WhereCondition = Nothing
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(232, 144)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(192, 20)
        Me.TextBox11.TabIndex = 3
        Me.TextBox11.Text = ""
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cccsttpm.acct_devol"))
        Me.TextBox12.Location = New System.Drawing.Point(112, 144)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(112, 20)
        Me.TextBox12.TabIndex = 3
        Me.TextBox12.Text = ""
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cccsttpm.acct_tax"))
        Me.TextBox13.Location = New System.Drawing.Point(112, 168)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(112, 20)
        Me.TextBox13.TabIndex = 3
        Me.TextBox13.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(72, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Itbis:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(25, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Devoluciones:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXLookup5
        '
        Me.LibXLookup5.DataMember = Nothing
        Me.LibXLookup5.DataSource = Nothing
        Me.LibXLookup5.DestParameters = Nothing
        Me.LibXLookup5.Location = New System.Drawing.Point(424, 144)
        Me.LibXLookup5.LookCaption = Nothing
        Me.LibXLookup5.Name = "LibXLookup5"
        Me.LibXLookup5.Size = New System.Drawing.Size(20, 20)
        Me.LibXLookup5.SqlString = Nothing
        Me.LibXLookup5.SrcParameters = Nothing
        Me.LibXLookup5.TabIndex = 4
        Me.LibXLookup5.TableName = Nothing
        Me.LibXLookup5.UseCopyConnection = False
        Me.LibXLookup5.UseRowRetrieveEvents = False
        Me.LibXLookup5.VisParameters = Nothing
        Me.LibXLookup5.WhereCondition = Nothing
        '
        'LibXLookup6
        '
        Me.LibXLookup6.DataMember = Nothing
        Me.LibXLookup6.DataSource = Nothing
        Me.LibXLookup6.DestParameters = Nothing
        Me.LibXLookup6.Location = New System.Drawing.Point(424, 192)
        Me.LibXLookup6.LookCaption = Nothing
        Me.LibXLookup6.Name = "LibXLookup6"
        Me.LibXLookup6.Size = New System.Drawing.Size(20, 20)
        Me.LibXLookup6.SqlString = Nothing
        Me.LibXLookup6.SrcParameters = Nothing
        Me.LibXLookup6.TabIndex = 4
        Me.LibXLookup6.TableName = Nothing
        Me.LibXLookup6.UseCopyConnection = False
        Me.LibXLookup6.UseRowRetrieveEvents = False
        Me.LibXLookup6.VisParameters = Nothing
        Me.LibXLookup6.WhereCondition = Nothing
        '
        'LibXLookup7
        '
        Me.LibXLookup7.DataMember = Nothing
        Me.LibXLookup7.DataSource = Nothing
        Me.LibXLookup7.DestParameters = Nothing
        Me.LibXLookup7.Location = New System.Drawing.Point(424, 120)
        Me.LibXLookup7.LookCaption = Nothing
        Me.LibXLookup7.Name = "LibXLookup7"
        Me.LibXLookup7.Size = New System.Drawing.Size(20, 20)
        Me.LibXLookup7.SqlString = Nothing
        Me.LibXLookup7.SrcParameters = Nothing
        Me.LibXLookup7.TabIndex = 4
        Me.LibXLookup7.TableName = Nothing
        Me.LibXLookup7.UseCopyConnection = False
        Me.LibXLookup7.UseRowRetrieveEvents = False
        Me.LibXLookup7.VisParameters = Nothing
        Me.LibXLookup7.WhereCondition = Nothing
        '
        'LibXLookup8
        '
        Me.LibXLookup8.DataMember = Nothing
        Me.LibXLookup8.DataSource = Nothing
        Me.LibXLookup8.DestParameters = Nothing
        Me.LibXLookup8.Location = New System.Drawing.Point(424, 168)
        Me.LibXLookup8.LookCaption = Nothing
        Me.LibXLookup8.Name = "LibXLookup8"
        Me.LibXLookup8.Size = New System.Drawing.Size(20, 20)
        Me.LibXLookup8.SqlString = Nothing
        Me.LibXLookup8.SrcParameters = Nothing
        Me.LibXLookup8.TabIndex = 4
        Me.LibXLookup8.TableName = Nothing
        Me.LibXLookup8.UseCopyConnection = False
        Me.LibXLookup8.UseRowRetrieveEvents = False
        Me.LibXLookup8.VisParameters = Nothing
        Me.LibXLookup8.WhereCondition = Nothing
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(42, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Adelantos:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(232, 168)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Size = New System.Drawing.Size(192, 20)
        Me.TextBox14.TabIndex = 3
        Me.TextBox14.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(33, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 16)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Descuentos:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cccsttpm.acct_desct"))
        Me.TextBox15.Location = New System.Drawing.Point(112, 120)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(112, 20)
        Me.TextBox15.TabIndex = 3
        Me.TextBox15.Text = ""
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cccsttpm.acct_adel"))
        Me.TextBox16.Location = New System.Drawing.Point(112, 192)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(112, 20)
        Me.TextBox16.TabIndex = 3
        Me.TextBox16.Text = ""
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(232, 120)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.ReadOnly = True
        Me.TextBox17.Size = New System.Drawing.Size(192, 20)
        Me.TextBox17.TabIndex = 3
        Me.TextBox17.Text = ""
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(232, 192)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.ReadOnly = True
        Me.TextBox18.Size = New System.Drawing.Size(192, 20)
        Me.TextBox18.TabIndex = 3
        Me.TextBox18.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cccsttpm.csttype_code"))
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
        Me.Label1.Text = "Código:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cccsttpm.csttype_name"))
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
        'i_cccsttpm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(698, 383)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_cccsttpm01"
        Me.Text = "Tipos de Clientes"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
