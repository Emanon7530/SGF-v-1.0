Public Class i_cjperson01
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox2 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox3 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox4 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox5 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox6 As LibX.LibxCheckBox
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.LibxCheckBox2 = New LibX.LibxCheckBox
        Me.LibxCheckBox3 = New LibX.LibxCheckBox
        Me.LibxCheckBox4 = New LibX.LibxCheckBox
        Me.LibxCheckBox5 = New LibX.LibxCheckBox
        Me.LibxCheckBox6 = New LibX.LibxCheckBox
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 192)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjpersonal.pers_code"))
        Me.TextBox1.Location = New System.Drawing.Point(96, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 20)
        Me.TextBox1.TabIndex = 1
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
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjpersonal.Nombres"))
        Me.TextBox2.Location = New System.Drawing.Point(96, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(336, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(40, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(192, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cedula:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(674, 24)
        Me.LibXNavigator1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(32, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Direccion"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(32, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telefono:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(256, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Celular:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(24, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "%comision:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(224, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "%Descuento:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjpersonal.Direccion"))
        Me.TextBox3.Location = New System.Drawing.Point(96, 72)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(336, 20)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = ""
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjpersonal.Telefono"))
        Me.TextBox5.Location = New System.Drawing.Point(96, 96)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(120, 20)
        Me.TextBox5.TabIndex = 10
        Me.TextBox5.Text = ""
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjpersonal.Celular"))
        Me.TextBox6.Location = New System.Drawing.Point(304, 96)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(128, 20)
        Me.TextBox6.TabIndex = 11
        Me.TextBox6.Text = ""
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjpersonal.porc_comision"))
        Me.TextBox7.Location = New System.Drawing.Point(96, 120)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(120, 20)
        Me.TextBox7.TabIndex = 12
        Me.TextBox7.Text = ""
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjpersonal.porc_descuento"))
        Me.TextBox8.Location = New System.Drawing.Point(304, 120)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(128, 20)
        Me.TextBox8.TabIndex = 13
        Me.TextBox8.Text = ""
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjpersonal.Cedula"))
        Me.TextBox9.Location = New System.Drawing.Point(240, 24)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(192, 20)
        Me.TextBox9.TabIndex = 14
        Me.TextBox9.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(8, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Tipo Comision:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjpersonal.tipo_comision"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Items.AddRange(New Object() {"1 - Ventas", "2 - Dias", "3 - Domicilios"})
        Me.LibXCombo1.Location = New System.Drawing.Point(96, 144)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = Nothing
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(216, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LibxCheckBox6)
        Me.GroupBox2.Controls.Add(Me.LibxCheckBox5)
        Me.GroupBox2.Controls.Add(Me.LibxCheckBox4)
        Me.GroupBox2.Controls.Add(Me.LibxCheckBox3)
        Me.GroupBox2.Controls.Add(Me.LibxCheckBox2)
        Me.GroupBox2.Controls.Add(Me.LibxCheckBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(464, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 192)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Funciones"
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.LibXConnector1, "cjpersonal.isCajera"))
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(24, 24)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = Nothing
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = False
        Me.LibxCheckBox1.Size = New System.Drawing.Size(128, 16)
        Me.LibxCheckBox1.TabIndex = 0
        Me.LibxCheckBox1.Text = "Cajera:"
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'LibxCheckBox2
        '
        Me.LibxCheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.LibXConnector1, "cjpersonal.isVendedor"))
        Me.LibxCheckBox2.EditInitialValue = Nothing
        Me.LibxCheckBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.FindInitialValue = Nothing
        Me.LibxCheckBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.IgnoreRequiered = False
        Me.LibxCheckBox2.KeepEnabled = False
        Me.LibxCheckBox2.Location = New System.Drawing.Point(24, 48)
        Me.LibxCheckBox2.Name = "LibxCheckBox2"
        Me.LibxCheckBox2.NewInitialValue = Nothing
        Me.LibxCheckBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.ReadOnly = False
        Me.LibxCheckBox2.Requiered = False
        Me.LibxCheckBox2.Size = New System.Drawing.Size(128, 16)
        Me.LibxCheckBox2.TabIndex = 1
        Me.LibxCheckBox2.Text = "Vendedor:"
        Me.LibxCheckBox2.ThreeState = True
        Me.LibxCheckBox2.value = Nothing
        '
        'LibxCheckBox3
        '
        Me.LibxCheckBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.LibXConnector1, "cjpersonal.isSupervisor"))
        Me.LibxCheckBox3.EditInitialValue = Nothing
        Me.LibxCheckBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.FindInitialValue = Nothing
        Me.LibxCheckBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.IgnoreRequiered = False
        Me.LibxCheckBox3.KeepEnabled = False
        Me.LibxCheckBox3.Location = New System.Drawing.Point(24, 72)
        Me.LibxCheckBox3.Name = "LibxCheckBox3"
        Me.LibxCheckBox3.NewInitialValue = Nothing
        Me.LibxCheckBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.ReadOnly = False
        Me.LibxCheckBox3.Requiered = False
        Me.LibxCheckBox3.Size = New System.Drawing.Size(128, 16)
        Me.LibxCheckBox3.TabIndex = 2
        Me.LibxCheckBox3.Text = "Supervisor:"
        Me.LibxCheckBox3.ThreeState = True
        Me.LibxCheckBox3.value = Nothing
        '
        'LibxCheckBox4
        '
        Me.LibxCheckBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.LibXConnector1, "cjpersonal.isMensajero"))
        Me.LibxCheckBox4.EditInitialValue = Nothing
        Me.LibxCheckBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.FindInitialValue = Nothing
        Me.LibxCheckBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.IgnoreRequiered = False
        Me.LibxCheckBox4.KeepEnabled = False
        Me.LibxCheckBox4.Location = New System.Drawing.Point(24, 96)
        Me.LibxCheckBox4.Name = "LibxCheckBox4"
        Me.LibxCheckBox4.NewInitialValue = Nothing
        Me.LibxCheckBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.ReadOnly = False
        Me.LibxCheckBox4.Requiered = False
        Me.LibxCheckBox4.Size = New System.Drawing.Size(128, 16)
        Me.LibxCheckBox4.TabIndex = 3
        Me.LibxCheckBox4.Text = "Mensajero:"
        Me.LibxCheckBox4.ThreeState = True
        Me.LibxCheckBox4.value = Nothing
        '
        'LibxCheckBox5
        '
        Me.LibxCheckBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.LibXConnector1, "cjpersonal.PagarComision"))
        Me.LibxCheckBox5.EditInitialValue = Nothing
        Me.LibxCheckBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.FindInitialValue = Nothing
        Me.LibxCheckBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.IgnoreRequiered = False
        Me.LibxCheckBox5.KeepEnabled = False
        Me.LibxCheckBox5.Location = New System.Drawing.Point(24, 120)
        Me.LibxCheckBox5.Name = "LibxCheckBox5"
        Me.LibxCheckBox5.NewInitialValue = Nothing
        Me.LibxCheckBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.ReadOnly = False
        Me.LibxCheckBox5.Requiered = False
        Me.LibxCheckBox5.Size = New System.Drawing.Size(128, 16)
        Me.LibxCheckBox5.TabIndex = 4
        Me.LibxCheckBox5.Text = "Paga Comision:"
        Me.LibxCheckBox5.ThreeState = True
        Me.LibxCheckBox5.value = Nothing
        '
        'LibxCheckBox6
        '
        Me.LibxCheckBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.LibXConnector1, "cjpersonal.iniciarCaja"))
        Me.LibxCheckBox6.EditInitialValue = Nothing
        Me.LibxCheckBox6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox6.FindInitialValue = Nothing
        Me.LibxCheckBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox6.IgnoreRequiered = False
        Me.LibxCheckBox6.KeepEnabled = False
        Me.LibxCheckBox6.Location = New System.Drawing.Point(24, 144)
        Me.LibxCheckBox6.Name = "LibxCheckBox6"
        Me.LibxCheckBox6.NewInitialValue = Nothing
        Me.LibxCheckBox6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox6.ReadOnly = False
        Me.LibxCheckBox6.Requiered = False
        Me.LibxCheckBox6.Size = New System.Drawing.Size(128, 16)
        Me.LibxCheckBox6.TabIndex = 5
        Me.LibxCheckBox6.Text = "Auto Caja:"
        Me.LibxCheckBox6.ThreeState = True
        Me.LibxCheckBox6.value = Nothing
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
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "pers_code"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cjpersonal"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'i_cjperson01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(674, 296)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_cjperson01"
        Me.Text = "Registro de personal"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
